#r "nuget: FSharp.Data"
#r @"C:\Repositories\Modernization\ConsoleFsharp\bin\Debug\net10.0\ConsoleFsharp.dll"
#r "nuget: Iride"
#load @"C:\Repositories\Modernization\ConsoleFsharp\Scripts\Sanitation.fsx"

open System.Text
open FSharp.Data
open System
open System.IO
open System.Collections.Generic
open System.Xml.Linq
open System.Xml.XPath


open Sanitation
open Program
open Ergonomics
open Shorthand
open Rdf.Namespace
open Rdfs.Namespace
open Owl.Namespace
open Xsd.Namespace
open Xs.Namespace
open Xml.spec.Namespace
open Loc.premis.Namespace
open Cidocrm.Namespace


let xPathFromXElement (el: XElement)(separator :string) : string =
    // For each element step, compute [n] among same-name siblings (1-based) when needed.
    let step (e: XElement) =
        let name = e.Name.LocalName

        match e.Parent with
        | null ->
            // Root element: just its name
            name
        | parent ->
            // Position among siblings with the same name
            let siblingsSameName = parent.Elements(e.Name) |> Seq.toList
            if siblingsSameName.Length <= 1 then
                name
            else
                let index =
                    siblingsSameName
                    |> List.findIndex (fun s -> Object.ReferenceEquals(s, e))
                    |> (+) 1
                sprintf "%s%d" name index

    el.AncestorsAndSelf()
    |> Seq.rev
    |> Seq.map step
    |> String.concat  separator
    |> fun path ->  path


let xPathFromXAttribute (attr: XAttribute)(attributeSigil:string)(segmentSeparator :string) : string =
    // XAttribute.Parent is the owning XElement; it can be null in edge-cases (detached attributes).
    match attr.Parent with
    | null ->
        // No owner element -> degrade gracefully to just the attribute name.
        // (Or: failwith "Detached XAttribute has no Parent XElement.")
        if attr.Name.Namespace = XNamespace.None then
            attributeSigil + attr.Name.LocalName
        else
            attributeSigil + attr.Name.NamespaceName + segmentSeparator + attr.Name.LocalName
    | parentEl ->
        let elementPath = xPathFromXElement parentEl segmentSeparator

        // Attribute "name" rendering policy:
        // - If no namespace: "@local"
        // - If namespaced: "@{namespaceUri}:local"
        // If you'd rather use prefixes, you'd need a prefix map (XNamespace -> string).
        let attrName =
            if attr.Name.Namespace = XNamespace.None then
                attributeSigil + attr.Name.LocalName
            else
                attributeSigil + attr.Name.NamespaceName + segmentSeparator + attr.Name.LocalName

        elementPath + attrName
let namespaceXPathFromXElement(el: XElement) = xPathFromXElement el ":"
let namespaceXPathFromXAttribute(attr: XAttribute) = xPathFromXAttribute attr "-" ":"

Path.GetInvalidFileNameChars()
 |> Array.iter (fun invalidCharacter -> 
                Console.WriteLine invalidCharacter
)

let fileXPathFromXElement(el: XElement) = sanitizeFilePath (xPathFromXElement el "\\")
let fileXPathFromXAttribute(attr: XAttribute) = sanitizeFilePath (xPathFromXAttribute attr "@" "\\")
module MSBuild =
    module Core =
        module xsd =
            [<Literal>]
            let filePath =
                @"C:\Surfaces\Microsoft\msbuild\src\MSBuild\MSBuild\Microsoft.Build.Core.xsd"

            let fileName = Path.GetFileName  filePath
            let text = File.ReadAllText(filePath)

            type Provider = XmlProvider<filePath>
            let root = Provider.Parse(text)


GraphRuntime.inMemoryDataset.Graphs |> Seq.iter (fun graph -> graph.Clear())
let a = rdf.``type``

let msb = NamedGraph.inhabitant (mint.prefixID $"{MSBuild.Core.xsd.root.TargetNamespace}/" "msb") @"C:\Repositories\Modernization\ConsoleFsharp\MSBuild\msb"

let fileNamespace = NamedGraph.inhabitant (mint.prefixID $"urn:{MSBuild.Core.xsd.fileName}:" MSBuild.Core.xsd.fileName ) @"C:\Repositories\Modernization\ConsoleFsharp\MSBuild\Microsoft.Build.Core"

fileNamespace.iri --- a --> premis.File >-: msb
fileNamespace.iri --- a --> cidocrm.E73_Information_Object >-: msb
fileNamespace._prefix MSBuild.Core.xsd.root.XElement.Name.LocalName --- a --> xs._prefixID._prefix MSBuild.Core.xsd.root.XElement.Name.LocalName >-: msb
let graphFromXElement (xElement: XElement) = 
    let namespaceXPath = namespaceXPathFromXElement xElement 
    let fileXPath = fileXPathFromXElement xElement 
    let xpathGraph = NamedGraph.inhabitant (mint.prefixID $"{MSBuild.Core.xsd.root.TargetNamespace}/{namespaceXPath}" "msb") $"""C:\Repositories\Modernization\ConsoleFsharp\MSBuild\Microsoft.Build.Core\{fileXPath}"""
    xpathGraph

let graphFromXAttribute (xAttribute :XAttribute)  = 
    let namespaceXPath = namespaceXPathFromXAttribute xAttribute 
    let fileXPath = fileXPathFromXAttribute xAttribute 
    let xpathGraph = NamedGraph.inhabitant (mint.prefixID $"{MSBuild.Core.xsd.root.TargetNamespace}/{namespaceXPath}" "msb") $"""C:\Repositories\Modernization\ConsoleFsharp\MSBuild\Microsoft.Build.Core\{fileXPath}"""
    xpathGraph


let localNameFromQnameLiteral (qnameLiteral:string) = qnameLiteral.Split(":") |> Array.last
let elementXpathGraphs =
    MSBuild.Core.xsd.root.XElement.DescendantsAndSelf()
        |> Seq.map graphFromXElement
        |> Seq.toList
let attributeXpathGraphs =
    MSBuild.Core.xsd.root.XElement.DescendantsAndSelf()
        |> Seq.collect (fun xElement -> 
            match xElement.HasAttributes with
            | false -> Seq.ofList [msb]
            | true ->
                xElement.Attributes()
                |> Seq.map graphFromXAttribute
        )
        |> Seq.toList
MSBuild.Core.xsd.root.XElement.DescendantsAndSelf()
    |> Seq.iter (fun xElement -> 
        let xElementXpath = namespaceXPathFromXElement xElement 
        let elementXpathIri = fileNamespace._prefix xElementXpath
        let elementXpathGraph = graphFromXElement xElement

        elementXpathIri --- xml'spec.``dt-stag`` --> xElement.Name.LocalName^^xsd.string >-: elementXpathGraph 
        xs._prefixID._prefix xElement.Name.LocalName  --- a -->  owl.Class >-: elementXpathGraph 
        match xElement.Parent with
        | null -> // root has no parent, but treat filet container itself as parent
            fileNamespace.iri --- xml'spec.``dt-parentchild`` --> elementXpathIri >=: [msb ; elementXpathGraph]
        | parent ->
            let xElementParentXpath = namespaceXPathFromXElement parent 
            let parentXpath = fileNamespace._prefix xElementParentXpath
            parentXpath --- xml'spec.``dt-parentchild`` --> elementXpathIri >-: elementXpathGraph
        match xElement.HasAttributes with
        | false -> ()
        | true ->
            xElement.Attributes()
            |> Seq.iter (fun xAttribute -> 
                let xAttributeXpath = namespaceXPathFromXAttribute xAttribute
                let attributeXpathIri = fileNamespace._prefix xAttributeXpath
                let attributeXpathGraph = graphFromXAttribute xAttribute
                elementXpathIri --- xml'spec.``dt-attr`` --> attributeXpathIri >=: [elementXpathGraph ; attributeXpathGraph] 
                attributeXpathIri --- xml'spec.``dt-attrname`` --> xAttribute.Name.LocalName^^xsd.string >-: attributeXpathGraph 
                xs._prefixID._prefix xAttribute.Name.LocalName  --- a -->  owl.ObjectProperty >-: attributeXpathGraph 
            )
    )


MSBuild.Core.xsd.root.Elements
        |> Array.filter (fun element -> element.Type.IsSome)
        |> Array.map (fun element -> 
            let elementType = msb._prefix (localNameFromQnameLiteral element.Type.Value)
            let elementXpathGraph = graphFromXElement element.XElement
            elementType  --- rdfs.subClassOf --> xs._prefixID._prefix element.XElement.Name.LocalName  >-: elementXpathGraph
            msb._prefix element.Name --- a --> elementType >-: elementXpathGraph
            
        )

         
// MSBuild.Core.xsd.root.Elements
//     |> Array.filter (fun element -> element.Annotation.IsSome)
//     |> Array.iter (fun element -> 
//         msb._prefix element.Name --- xs.documentation --> element.Annotation.Value.Documentation >-: msb
//     )
// 
// MSBuild.Core.xsd.root.Elements
//     |> Array.filter (fun element -> element.Type.IsSome)
//     |> Array.iter (fun element -> 
//         msb._prefix element.Name --- xs.``type`` --> msb._prefix (localNameFromQnameLiteral element.Type.Value) >-: msb
//     )
// 
// MSBuild.Core.xsd.root.Elements
//     |> Array.filter (fun element -> element.ComplexType.IsSome)
//     |> Array.iter (fun element -> 
//         msb._prefix element.Name --- xs.complexType --> element.ComplexType.Value.Sequence.Groups >-: msb
//     )



// xs.documentation --- rdfs.subPropertyOf --> xs.annotation >-: msb
// xs.annotation --- rdfs.subPropertyOf --> rdfs.comment >-: msb
GraphRuntime.Serialization.Turtle.save  msb
let graphs = elementXpathGraphs @ attributeXpathGraphs
graphs |> List.iter (fun namedGraph -> 
     GraphRuntime.Serialization.Turtle.save  namedGraph
)
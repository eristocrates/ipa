#time on
fsi.PrintLength <- 10
fsi.ShowDeclarationValues <- false

open System
#r "nuget: SQLProvider.MsSql, 1.5.18"
#load @"C:\Secret\InforSecrets.fsx"
open InforSecrets
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\PowershellErgonomics.fsx"
open PowershellErgonomics
open FSharp.Data.Sql
open FSharp.Data.Sql.MsSql
open System.Linq
#r "nuget: FSharp.Collections.ParallelSeq"
open FSharp.Collections.ParallelSeq
open System.Threading
open System.IO
open System.Text
open System.Xml
open System.Xml.Linq
open System.Xml.XPath
open System.Xml.Serialization
open System.Xml.Schema
#r "nuget: FSharp.Literals, 2.2.15"
open FSharp.Literals
#r "nuget: FSharp.Data"
open FSharp.Data
#r "nuget: FSharp.XExtensions"
open FSharp.XExtensions
#r "nuget: LitXml"
open LitXml
#r "nuget: Fabulous.AST"
open Fabulous.AST
open Fantomas.Core
#r "nuget: Humanizer.Core"
open Humanizer
#r "nuget: CaseConverter"
open CaseConverter
#r "nuget: SQLProvider.MsSql, 1.5.27"
#r "nuget: Microsoft.Data.SqlClient, 5.2.2"
#r "nuget: Microsoft.SqlServer.DacFx, 162.5.57"
#r "nuget: FSharp.Literals, 2.2.15"
module FSharpLiteral = FSharp.Literals.Literal

open Microsoft.SqlServer
// #r "nuget: Microsoft.Data.SqlClient, 6.0.0"
// open Microsoft.Data.SqlClient

#r "nuget: SafeName, 0.1.1"
open SafeName

#r "nuget: XSDLib, 1.0.1.3"
open W3C

#r "nuget: TextCopy"
open TextCopy

let clipboard = new Clipboard()
let clip (text:string) = clipboard.SetText text












type Dac.Model.TSqlObject with 
    member this.ast = this.GetAst()
    member this.children = this.GetChildren() |> Seq.toArray
    member this.parent = this.GetParent()
    member this.referenced = this.GetReferenced() |> Seq.toArray
    member this.referencedRelationshipInstances = this.GetReferencedRelationshipInstances() |> Seq.toArray
    member this.referencing = this.GetReferencing() |> Seq.toArray
    member this.referencingRelationshipInstances = this.GetReferencingRelationshipInstances() |> Seq.toArray
    member this.script = this.GetScript() |> Seq.toArray
    member this.sourceInformation = this.GetSourceInformation()

type Dac.Model.TSqlModel with 
        member this.TableValuedFunctions =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "TableValuedFunction")

        member this.ScalarFunctions =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "ScalarFunction")

        member this.Indexes =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Index")

        member this.CheckConstraints =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "CheckConstraint")

        member this.DatabaseOptions =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "DatabaseOptions")

        member this.DefaultConstraints =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "DefaultConstraint")

        member this.DmlTriggers =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "DmlTrigger")

        member this.ExtendedPropertys =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "ExtendedProperty")

        member this.ForeignKeyConstraints =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "ForeignKeyConstraint")

        member this.Logins =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Login")

        member this.PrimaryKeyConstraints =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "PrimaryKeyConstraint")

        member this.Procedures =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Procedure")

        member this.Roles =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Role")

        member this.RoleMemberships =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "RoleMembership")

        member this.Schemas =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Schema")

        member this.Statisticss =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Statistics")

        member this.Synonyms =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Synonym")

        member this.Tables =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Table")

        member this.TableTypes =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "TableType")

        member this.UniqueConstraints =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "UniqueConstraint")

        member this.Users =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "User")

        member this.Views =
            this.GetObjects(Dac.Model.DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "View")



type XmlSchemaInference with 
    member this.fromXElements (elements: XElement array) =
        elements
        |> Array.fold (fun schemas element ->
            use reader = element.CreateReader()
            this.InferSchema(reader, schemas)
        ) (XmlSchemaSet())

    member this.fromFile (xmlFile: FileInfo) =
        let output_directory = xmlFile.DirectoryName
            

        let fileStem = Path.GetFileNameWithoutExtension(xmlFile.FullName)


        let schemas =
            use reader = XmlReader.Create(xmlFile.FullName)

            this.InferSchema(reader).Schemas()
            |> Seq.cast<XmlSchema>
            |> Seq.toArray

        let writer_settings = XmlWriterSettings()
        writer_settings.Indent <- true

        schemas
        |> Array.mapi (fun index schema ->
            let xsd_path =
                if schemas.Length = 1 then
                    Path.Combine(xmlFile.DirectoryName, $"{fileStem}.xsd")
                else
                    Path.Combine(
                        xmlFile.DirectoryName,
                        $"{fileStem}.{index + 1}.xsd"
                    )

            use writer = XmlWriter.Create(xsd_path, writer_settings)
            schema.Write(writer)

            xsd_path)


type InforProdSql =
    SqlDataProvider<ConnectionString=Prod.connection_string, IndividualsAmount=10000, UseOptionTypes=Common.NullableColumnType.OPTION>

let operations = InforProdSql.GetDataContext()

let xsdInference = XmlSchemaInference()



module HansenDataDistribution = 
    [<Literal>]
    let xmlFilePath =  @"D:/Surface/Company/Infor/Download_Center/Product/Operations_and_Regulations/Release/Infor_Public_Sector_2025_04_01/IPS_2025_04_01/Deployment Files/MetaData/MetaData.xml"
    let xmlFile = FileInfo xmlFilePath
    type Provider = XmlProvider<UseOriginalNames = true, PreferDateOnly = true,
            Sample = xmlFilePath >
    let xml = Provider.Load xmlFilePath



module Dacpac = 
        [<Literal>]
        let xmlFilePath = @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\SqlDatabase\Metadata\dapac\model.xml"
        let xmlFile = new FileInfo(xmlFilePath)
        let xsdFile = Path.ChangeExtension(xmlFilePath, ".xsd") |> FileInfo
        type Provider = XmlProvider<UseOriginalNames = true, PreferDateOnly = true,
                Sample = xmlFilePath >
        let xml = Provider.Load xmlFilePath

        let Model =
            let options = Dac.Model.ModelLoadOptions()

            options.LoadAsScriptBackedModel <- true
            options.ModelStorageType <- Dac.DacSchemaModelStorageType.Memory

            Dac.Model.TSqlModel.LoadFromDacpac(@"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\SqlDatabase\Metadata\operations.dacpac", options)


type Dac.Model.ObjectIdentifier with 
  member this.display  = Dacpac.Model.DisplayServices.GetDisplayName(this, Dac.Model.EscapeStyle.EscapeIfNecessary, false)
  member this.fullDisplay  = Dacpac.Model.DisplayServices.GetDisplayName(this, Dac.Model.EscapeStyle.EscapeIfNecessary, true)
  
type Dac.Model.TSqlObject with 
  member this.simpleName  = Dacpac.Model.DisplayServices.GetElementName (this, Dac.Model.ElementNameStyle.SimpleName)
  member this.escapedSimpleName  = Dacpac.Model.DisplayServices.GetElementName (this, Dac.Model.ElementNameStyle.EscapedSimpleName)
  member this.fullyQualifiedName  = Dacpac.Model.DisplayServices.GetElementName (this, Dac.Model.ElementNameStyle.FullyQualifiedName)
  member this.escapedFullyQualifiedName  = Dacpac.Model.DisplayServices.GetElementName (this, Dac.Model.ElementNameStyle.EscapedFullyQualifiedName)
  member this.maybeProductFamily = 
    HansenDataDistribution.xml.hansenMetadata.productFamilies
    |> Array.tryFind (fun productFamily -> 
                            match this.fullyQualifiedName with 
                            | "MetaData" -> this.fullyQualifiedName = productFamily.name
                            | _ -> this.fullyQualifiedName = productFamily.name.ToUpperInvariant().Replace('.','_')
    )
  member this.maybeTable = 
    HansenDataDistribution.xml.hansenMetadata.productFamilies
    |> Array.tryPick (fun productFamily -> 
                        productFamily.tables
                        |> Array.tryFind (fun table -> 
                            match this.fullyQualifiedName with 
                            | "MetaData" -> this.fullyQualifiedName = table.name
                            | _ -> this.fullyQualifiedName = table.name.ToUpperInvariant().Replace('.','_')
                        )
    )

type Dac.Model.ModelTypeClass with 
    member this.metadata = this.Metadata |> Seq.toArray
    member this.properties = this.Properties |> Seq.toArray


// xsdInference.fromFile Dacpac.xmlFile


module Folder = 
    let WebServices = DirectoryInfo @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\WebServices"
    let Generated = DirectoryInfo @"C:\Repositories\appsdb\IPS_Sites\integration\InforModel\Generated"



type XmlSchemaSet with 
    member this.globalElements = this.GlobalElements.Values |> Seq.cast<XmlSchemaElement> |> Seq.toArray
    member this.globalAttributes = this.GlobalAttributes.Values |> Seq.cast<XmlSchemaAttribute> |> Seq.toArray
    member this.globalTypes = this.GlobalTypes.Values |> Seq.cast<XmlSchemaType> |> Seq.toArray



    static member fromFiles (xsdFiles : FileInfo array) = 
        let xmlSchemaSet = new XmlSchemaSet()
        xmlSchemaSet.XmlResolver <- XmlUrlResolver()
        let xmlSchemas =
            xsdFiles
            |> Array.map (fun xsdFile ->
                xmlSchemaSet.Add(null, xsdFile.FullName)
            )
        xmlSchemaSet.Compile()
        xmlSchemas, xmlSchemaSet

type XmlSchemaObjectTable with 
    member this.values = this.Values |> Seq.cast<XmlSchemaElement> |> Seq.toArray
    member this.names = this

let wsdlFiles = 
    Directory.GetFiles(Folder.WebServices.FullName, "*.wsdl",SearchOption.AllDirectories)
    |> Array.Parallel.map (fun wsdlFilePath -> 
    new FileInfo(wsdlFilePath)
    )


let withInheritedNamespaces (element: XElement) =
    let extracted = XElement(element)

    element.AncestorsAndSelf()
    |> Seq.collect _.Attributes()
    |> Seq.filter _.IsNamespaceDeclaration
    |> Seq.distinctBy _.Name
    |> Seq.iter (fun namespaceAttribute ->
        if isNull (extracted.Attribute(namespaceAttribute.Name)) then
            extracted.SetAttributeValue(
                namespaceAttribute.Name,
                namespaceAttribute.Value
            )
    )

    extracted




    
type QualifiedDeclaration =
    {
        modulePath : string list
        declaration : WidgetBuilder<SyntaxOak.ModuleDecl>
    }

type ModuleNode =
    {
        declarations : WidgetBuilder<SyntaxOak.ModuleDecl> list
        modules : Map<string, ModuleNode>
    }



type Type with 
    member this.FSharpName = FSharpLiteral.stringifyTypeDynamic this



module XSD = 

    type TypeReference =
        | BuiltInType of XmlQualifiedName * Type
        | SimpleType of XmlQualifiedName * XSD.simpleType
        | ComplexType of XmlQualifiedName * XSD.complexType
        | UnresolvedType of XmlQualifiedName
    type Indicator = 
        | OrderIndicator of Order
        | ElementOccurrenceIndicator of ElementOccurrence
        | GroupIndicator of Group
    and Order = 
        | AllOrder of XSD.all
        | ChoiceOrder of XSD.choice
        | SequenceOrder of XSD.sequence
    and ElementOccurrence = 
        | MaxOccurs of int
        | MinOccurs of int
        | Unbounded
    and Group = 
        | GroupName of XSD.group
        | AttributeGroupName of XSD.attributeGroup

type XmlQualifiedName with 

    member this.maybeXmlSchemaType =
        match this with 
        | null -> None 
        | _ -> this |> XmlSchemaType.GetBuiltInSimpleType |> Option.ofObj
    member this.maybeClrType = 
        match this.maybeXmlSchemaType with 
        | Some xmlSchemaType -> Some xmlSchemaType.Datatype.ValueType
        | None -> None

    member this.clrTypeName = 
        match this.maybeClrType with 
        | Some clrType -> clrType.FSharpName
        | None -> 
                match this.Name with 
                | "anyType" -> "obj"
                | name -> name.Replace(".","'")


type XSD.schema with

    member this.resolveType (qualifiedName: XmlQualifiedName) =

        match qualifiedName.maybeClrType with
        | Some clrType ->
            XSD.BuiltInType(qualifiedName, clrType)

        | None ->

            match
                this.simpleTypes
                |> Array.tryFind (fun (simpleType:XSD.simpleType) -> simpleType.Content.name = qualifiedName.Name )
            with
            | Some simpleType ->
                XSD.SimpleType(qualifiedName, simpleType)

            | None ->

                match
                    this.complexTypes
                    |> Array.tryFind (fun (complexType:XSD.complexType) -> complexType.Content.name = qualifiedName.Name )
                with
                | Some complexType ->
                    XSD.ComplexType(qualifiedName, complexType)

                | None ->
                    XSD.UnresolvedType qualifiedName
    member this.elements =
        this.element
        |> Seq.toArray

    member this.attributes =
        this.attribute
        |> Seq.toArray

    member this.simpleTypes =
        this.simpleType
        |> Seq.toArray
    member this.unenumeratedSimpleTypes =
        this.simpleType
        |> Seq.filter (fun simpleType -> simpleType.Content.restriction.enumeration.Count() = 0)
        |> Seq.toArray
    member this.enumeratedSimpleTypes =
        this.simpleType
        |> Seq.filter (fun simpleType -> simpleType.Content.restriction.enumeration.Count() > 0)
        |> Seq.toArray

    member this.complexTypes =
        Array.concat [|
            this.complexType |> Seq.filter (fun complexType -> not ( isNull complexType) ) |> Seq.toArray
        |]

    member this.groups =
        this.group
        |> Seq.toArray

    member this.attributeGroups =
        this.attributeGroup
        |> Seq.toArray

    member this.notations =
        this.notation
        |> Seq.toArray

    member this.annotations =
        this.annotation
        |> Seq.toArray

    member this.includes =
        this.include
        |> Seq.toArray

    member this.imports =
        this.import
        |> Seq.toArray

    member this.redefines =
        this.redefine
        |> Seq.toArray

type XSD.enumeration with
    member this.lexicalValue =
        this.Untyped.Attribute(XName.Get "value").Value
type XSD.restriction with

    member this.enumerations =
        this.enumeration
        |> Seq.toArray

    member this.enumerationValues =
        this.enumerations
        |> Array.map _.lexicalValue

    member this.baseName = this.``base``
    member this.maybeClrType = this.baseName.maybeClrType



type XSD.simpleType with 
    member this.restriction = this.Content.restriction
    member this.qualifiedTypeName  =
        let segments =
            this.Content.name.Split('.') |> Array.toList

        let typeName =
            segments
            |> List.last

        let modulePath =
            segments
            |> List.take (segments.Length - 1)

        modulePath, typeName, this

    member this.qualifiedDeclaration =

        let modulePath, typeName, _ =
            this.qualifiedTypeName

        let declaration =
            Ast.Union(typeName) {
                for enumeration in this.Content.restriction.enumeration ->
                    Ast.UnionCase(
                        enumeration.lexicalValue,
                        FSharpLiteral.stringifyTypeDynamic
                            this.Content.restriction.maybeClrType.Value
                    )
            }
            |> Ast.AnyModuleDecl

        {
            modulePath = modulePath
            declaration = declaration
        }
    member this.asAstUnion = 
            Ast.Union(this.Content.name.Replace(".","'")) {
                for enumeration in this.Content.restriction.enumeration ->
                    Ast.UnionCase(
                        enumeration.lexicalValue,
                        FSharpLiteral.stringifyTypeDynamic
                            this.Content.restriction.maybeClrType.Value
                    )
            }
        

type XSD.explicitGroup with 
    member this.elements = this.element |> Seq.toArray



type XSD.sequence with
    member this.minOccurs =

        match this.Untyped.Attribute(XName.Get "minOccurs") with
        | null ->
            XSD.MinOccurs 1
        | attribute ->
            attribute.Value
            |> int
            |> XSD.MinOccurs

    member this.maxOccurs  =
        match this.Untyped.Attribute(XName.Get "maxOccurs") with
        | null ->
            XSD.MaxOccurs 1

        | attribute when attribute.Value = "unbounded" ->
            XSD.Unbounded

        | attribute ->
            attribute.Value
            |> int
            |> XSD.MaxOccurs


type XSD.localElement with 
    member this.maybeClrType = 
        match this.``type`` with 
        | null -> None 
        | xmlSchemaSimpleType ->  xmlSchemaSimpleType.maybeClrType
    member this.clrTypeName = 
        match this.maybeClrType with 
        | Some clrType -> clrType.FSharpName
        | None -> 
            match this.``type`` with 
            | null -> 
                match this.name with 
                | "anyType" -> "obj"
                | _ -> "unit"
            | xmlQualifiedName -> xmlQualifiedName.clrTypeName

type XSD.complexType with
    member this.sequence = this.Content.sequence

    member this.qualifiedTypeName  =
        let segments =
            this.Content.name.Split('.') |> Array.toList

        let typeName =
            segments
            |> List.last

        let modulePath =
            segments
            |> List.take (segments.Length - 1)

        modulePath, typeName, this
    member this.elements = this.Content.sequence.Content.element |> Seq.toArray
    member this.qualifiedDeclaration =

        let modulePath, typeName, _ =
            this.qualifiedTypeName

        let declaration =
            match typeName with 
            | "ArrayOfString" -> Ast.Abbrev(typeName, "string array") |> Ast.AnyModuleDecl
            | "ArrayOfAnyType" -> Ast.Abbrev(typeName, "obj array") |> Ast.AnyModuleDecl
            | _ -> 
                Ast.Record(typeName) {
                    for element in this.elements do 
                        Ast.Field(element.name, element.clrTypeName)
                }|> Ast.AnyModuleDecl
                

        {
            modulePath = modulePath
            declaration = declaration
        }
    member this.asAstRecord = 
                match this.Content.name with 
                | typeName -> 
                        Ast.Record(typeName.Replace(".","'")){
                            for element in this.elements do 
                                    match this.Content.sequence.minOccurs, this.Content.sequence.maxOccurs with 
                                    | XSD.MinOccurs 0, XSD.MaxOccurs 1 -> Ast.Field(element.name, $"{element.clrTypeName} option")
                                    | XSD.MinOccurs minOccurs, XSD.MaxOccurs maxOccurs when maxOccurs > 1 -> Ast.Field(element.name, $"{element.clrTypeName} array")
                                    | _, _ -> Ast.Field(element.name, element.clrTypeName)
                        }
                                


module ModuleNode =

    let empty =
        {
            declarations = []
            modules = Map.empty
        }

    let rec add
        (modulePath : string list)
        (declaration : WidgetBuilder<SyntaxOak.ModuleDecl>)
        (node : ModuleNode)
        : ModuleNode =

        match modulePath with
        | [] ->
            {
                node with
                    declarations =
                        declaration :: node.declarations
            }

        | moduleName :: remainingPath ->

            let child =
                node.modules
                |> Map.tryFind moduleName
                |> Option.defaultValue empty

            let updatedChild =
                add remainingPath declaration child

            {
                node with
                    modules =
                        node.modules
                        |> Map.add moduleName updatedChild
            }
let rec nestedModule moduleName node =
    Ast.Module(moduleName) {

        for declaration in node.declarations do
            declaration

        for KeyValue(childModuleName, childNode) in node.modules do
            nestedModule childModuleName childNode
    }





type XmlRepresentation = 
    {
        xmlFile :FileInfo
        xsdFile :FileInfo
        xmlSchema :XSD.schema
        
    }
    member this.qualifiedDeclarations = 
        Array.concat [|
            this.xmlSchema.enumeratedSimpleTypes |> Array.map (fun simpleType -> simpleType.qualifiedDeclaration)
            this.xmlSchema.complexTypes |> Array.map (fun complexType -> complexType.qualifiedDeclaration)

        |]
    member this.moduleTree = 
        this.qualifiedDeclarations
        |> Seq.fold
            (fun tree qualifiedDeclaration ->
                ModuleNode.add
                    qualifiedDeclaration.modulePath
                    qualifiedDeclaration.declaration
                    tree)
            ModuleNode.empty
    member this.asAstModule = 
    
            Ast.AnonymousModule(){
                Ast.Open("System")
                Ast.Module("Infor"){
                    for enumeratedSimpleType in this.xmlSchema.enumeratedSimpleTypes do 
                        Ast.Union(enumeratedSimpleType.Content.name.Replace(".","'")){
                            for enumeration in enumeratedSimpleType.restriction.enumerations do 
                                match enumeratedSimpleType.restriction.baseName.maybeClrType with 
                                | Some clrType -> Ast.UnionCase(enumeration.lexicalValue, clrType.FSharpName)
                                | None -> Ast.UnionCase(enumeration.lexicalValue)
                                
                        }
                    for complexType in this.xmlSchema.complexTypes do 
                        match complexType.Content.name with 
                        | typeName -> 
                                Ast.Record(typeName.Replace(".","'")){
                                    for element in complexType.elements do 
                                            match element.minOccurs with 
                                            | 0m -> Ast.Field(element.name, $"{element.clrTypeName} option")
                                            | _ -> Ast.Field(element.name, element.clrTypeName)
                                }
                                |> _.toRecursive()
                                
                }

              } 



type WebServicesRepresentation = 
    {
        wsdlRepresentations : XmlRepresentation array
    }
    member this.complexTypes = 
        this.wsdlRepresentations 
        |> Array.collect (fun wsdlRepresentation -> wsdlRepresentation.xmlSchema.complexTypes)
    member this.enumeratedSimpleTypes = 
        this.wsdlRepresentations 
        |> Array.collect (fun wsdlRepresentation -> wsdlRepresentation.xmlSchema.enumeratedSimpleTypes)
    member this.simpleTypes = 
        this.wsdlRepresentations 
        |> Array.collect (fun wsdlRepresentation -> wsdlRepresentation.xmlSchema.simpleTypes)
    member this.complexTypesByMoniker = 
        this.complexTypes 
        |> Array.map (fun complexType -> complexType.Content.name, complexType)
        |> Map.ofArray



let webServicesRepresentation = 
    {
        wsdlRepresentations =
            Folder.WebServices.GetFiles("*.xsd",SearchOption.AllDirectories)
            |> Array.Parallel.map (fun xsdFile -> 
                {
        
                    xmlFile = Path.ChangeExtension(xsdFile.FullName, ".wsdl") |> FileInfo
                    xsdFile = xsdFile
                    xmlSchema = XSD.schema.Load xsdFile
                }
            )
    }

let dacpacRepresentation = 
    {
        xmlFile = Dacpac.xmlFile
        xsdFile = Dacpac.xsdFile
        xmlSchema = XSD.schema.Load Dacpac.xsdFile
    }

webServicesRepresentation.complexTypes.Length 
webServicesRepresentation.complexTypesByMoniker["Hansen.CRM.ServiceRequest"]


    


dacpacRepresentation.xmlSchema.elements[0].Content.complexType.sequence.Content.elements[0].name
dacpacRepresentation.xmlSchema.elements[0].Content.complexType.sequence.Content.elements[0].complexType.sequence.Content.elements[0].name
dacpacRepresentation.xmlSchema.elements[0].Content.complexType.sequence.Content.elements[0].complexType.sequence.Content.elements[0].complexType.sequence.Content.elements
|> Array.map (fun element -> element.name)


dacpacRepresentation.xmlSchema.elements[0].Content.complexType.sequence.Content.elements[0].complexType.sequence.Content.elements[0].complexType.sequence.Content.elements
|> Array.choose (fun element -> 
    try
        Some element.complexType.sequence
    with 
    | _ -> None )
|> Array.collect (fun sequence -> 
    sequence.Content.element
    |> Seq.map (fun nestedElement -> nestedElement.complexType.simpleContent) |> Seq.toArray
    )



dacpacRepresentation.xmlSchema.elements[0].Content.complexType.sequence.Content.elements[0].complexType.sequence.Content.elements[0].complexType.sequence.Content.elements
|> Array.choose (fun element -> 
    try
        let _ = element.complexType.sequence
        None
    with 
    | _ -> Some element )
|> Array.map (fun element -> element.complexType.attribute)


(*
dacpacRepresentation.xmlSchema.elements[0].Content.complexType.sequence.Content.elements[0].complexType.sequence.Content.elements[0].complexType.sequence.Content.elements
|> Array.filter (fun element -> not (isNull element.complexType))
|> Array.map (fun element -> element.complexType.sequence)
*)


let dacSchemas = Dacpac.xml.Model.Elements |> Array.filter (fun element -> element.Type = "SqlSchema")
let dacTables = Dacpac.xml.Model.Elements |> Array.filter (fun element -> element.Type = "SqlTable")
let dacSchema = dacSchemas |> Array.randomChoice

dacSchema
let dacpacSchema =
    Dacpac.Model.Schemas
    |> PSeq.find (fun schema ->
        match dacSchema.Name with 
        | Some name -> schema.escapedFullyQualifiedName = name
        | None -> false
    )

dacpacSchema.maybeProductFamily
let dacpacTable = Dacpac.Model.Tables |> Seq.head
dacpacTable.ObjectType.properties |> Array.iter (fun property -> printfn "%s" property.Name)
let productFamilySchemas = 
    HansenDataDistribution.xml.hansenMetadata.productFamilies
    |> Array.Parallel.map (fun productFamily -> 
                        Dacpac.Model.Schemas |> PSeq.find (fun schema -> 
                            match productFamily.name with 
                            | "MetaData" -> schema.fullyQualifiedName = productFamily.name
                            | _ -> schema.fullyQualifiedName = productFamily.name.ToUpperInvariant().Replace('.','_')
                            )
    )



productFamilySchemas.Length

let targetComplexTypes = 
        [|
            "Hansen.CRM.ServiceRequest" 
        |]
        |> Array.map (fun moniker -> webServicesRepresentation.complexTypesByMoniker[moniker])


Ast.Oak() {
    Ast.AnonymousModule(){
        Ast.Open ("System")
        targetComplexTypes[0].asAstRecord
        for complexType in targetComplexTypes[1..] do 
            complexType.asAstRecord.toRecursive()
    }
}
|> Gen.mkOak
|> Gen.run    
|> clip


let dacObjectTypes = 
    Dacpac.Model.GetObjects(Dac.Model.DacQueryScopes.All)
    |> PSeq.map (fun modelObject -> modelObject.ObjectType.Name)
    |> PSeq.toArray
    |> Array.distinct
    |> Array.sort

let dacObjectPropertiesByObjectType = 
    dacObjectTypes 
    |> Array.map (fun dacObjectType -> 
            let dacObject =
                Dacpac.Model.GetObjects(Dac.Model.DacQueryScopes.All)
                |> PSeq.find (fun modelObject -> modelObject.ObjectType.Name = dacObjectType)
            dacObjectType, dacObject.ObjectType.properties
            
            
            )
dacObjectPropertiesByObjectType[0]

let dacNamespaces = 
    dacObjectPropertiesByObjectType
    |> Array.collect (fun (_, properties) -> 
        properties |> Array.map (fun property -> property.DataType.Namespace))
        |> Array.distinct
        |> Array.sort
    


Ast.Oak() {
    Ast.AnonymousModule(){
        Ast.HashDirective( "r", "\"nuget: Microsoft.SqlServer.DacFx, 162.5.57\"" )
        Ast.Open ("System")
        Ast.Open ("Microsoft.SqlServer.TransactSql.ScriptDom")
        for dacNamespace in dacNamespaces do 
            Ast.Open(dacNamespace)
        Ast.Union("ModelType"){
            for dacObjectType in dacObjectTypes do 
                match dacObjectType with 
                | "Statistics" -> Ast.UnionCase($"{dacObjectType}Model", $"{dacObjectType}")
                | _ -> Ast.UnionCase($"{dacObjectType.Singularize()}Model", $"{dacObjectType.Singularize()}")
        }
        (*
        for dacObjectType, dacObjectProperties in dacObjectPropertiesByObjectType do 
            if dacObjectProperties.Length > 0 then 
                Ast.Record($"{dacObjectType.Singularize()}"){
                    for property in dacObjectProperties do 
                        match property.Name, property.DataType.FSharpName with 
                        | fieldName, "SqlScriptProperty" -> Ast.Field(fieldName, "string")
                        | fieldName, fieldTypeName -> Ast.Field(fieldName, fieldTypeName)
                } |> _.toRecursive()
        *)
    }
}
|> Gen.mkOak
|> Gen.run    
|> clip

let addresses = 
    query {
        for address in operations.Property.Address do 
            where (
                address.Stno = "8339"
                && address.Stname = "Old Bainbridge"
                
                )
            select address 
    }
    |> Seq.toArray
let address = addresses[0]
address.Opta
address.Optb
address.Optd
address.Optb

type Common.SqlEntity with 
    member this.columnValuesWithDefinition = this.ColumnValuesWithDefinition |> Seq.toArray
    member this.columnDefinitions = 
        this.ColumnValuesWithDefinition
        |> Seq.choose (fun (columnDatabaseName, rowValue, maybeColumnDefinition) -> maybeColumnDefinition)
        |> Seq.toArray
    member this.objColumns = 
        this.ColumnValuesWithDefinition
        |> Seq.filter (fun (columnDatabaseName, rowValue, maybeColumnDefinition) -> maybeColumnDefinition.IsSome)
        |> Seq.map (fun (columnDatabaseName, rowValue, maybeColumnDefinition) -> rowValue, maybeColumnDefinition.Value)
        |> Seq.toArray
    member this.columnClrTypeNames =
        this.objColumns
        |> Array.map (fun (valueObj, column) -> column.TypeMapping.ClrType)
        |> Array.distinct
        |> Array.sort
    member this.DateTimeColumns = 
        this.objColumns
        |> Array.choose (fun (objValue, column) ->  
                        match objValue with 
                        | :? DateTime as value -> Some(value, column)
                        | _ -> None
                        )
    member this.DoubleColumns = 
        this.objColumns
        |> Array.choose (fun (objValue, column) ->  
                        match objValue with 
                        | :? Double as value -> Some(value, column)
                        | _ -> None
                        )
    member this.Int16Columns = 
        this.objColumns
        |> Array.choose (fun (objValue, column) ->  
                        match objValue with 
                        | :? Int16 as value -> Some(value, column)
                        | _ -> None
                        )
    member this.Int32Columns = 
        this.objColumns
        |> Array.choose (fun (objValue, column) ->  
                        match objValue with 
                        | :? Int32 as value -> Some(value, column)
                        | _ -> None
                        )

    member this.StringColumns = 
        this.objColumns
        |> Array.choose (fun (objValue, column) ->  
                        match objValue with 
                        | :? String as value -> Some(value, column)
                        | _ -> None
                        )


let addessEntity = address :> Common.SqlEntity
addessEntity
addessEntity.StringColumns

let columnDatabaseName, rowValue, maybeColumnDefinition = addessEntity.columnValuesWithDefinition[0]
columnDatabaseName
rowValue
let columnDefinition = maybeColumnDefinition.Value
columnDefinition






// 
open System
open System.IO
open System.Text
open System.Xml.Linq

#r "nuget: FSharp.Data"
open FSharp.Data



#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\StringErgonomics.fsx"

open StringErgonomics
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\ParsingOLD\Language\Programming\FSharp\FSLang.fsx"




[<RequireQualifiedAccess>]
type Status =
    | Permanent
    | Provisional
    | Historical
// TODO look into Constrained Resource Identifiers
// https://www.ietf.org/archive/id/draft-ietf-core-href-26.html
type Scheme =
    {

      namespaceUriString: string
      lexicalForm: string
      description: string
      status: Status
      criSchemeNumber: int
      wellKnownUriSupport: string option

     }

module uri =
    module schemes =
        /// https://www.iana.org/assignments/uri-schemes/uri-schemes.xml
        [<Literal>]
        let filePath =
            @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\WorldWideWeb\uri-schemes.xml"

        let xml = XmlProvider<filePath>.Load filePath

let schemeRegistry =
    uri.schemes.xml.Registries
    |> Array.find (fun registry -> registry.Title = "Uniform Resource Identifier (URI) Schemes")

let schemes =
    schemeRegistry.Records
    |> Array.distinctBy (fun scheme -> scheme.Value.Value.XElement.Value)
    |> Array.Parallel.filter (fun scheme -> not (scheme.Value.Value.XElement.Value.Contains("OBSOLETE")))

let schemeRecords =
    schemes
    |> Array.Parallel.map (fun scheme ->

        let namespaceUriStringMeta = scheme.XElement.Name.NamespaceName
        let lexicalFormMeta = scheme.Value.Value.XElement.Value

        let descriptionMeta =
            if scheme.Description.Value.Value.Value = lexicalFormMeta then
                "None"
            else
                $"Some(\"\"\"{trimmedString scheme.Description.Value.Value.Value}\"\"\")"

        let statusMeta =
            match scheme.Status.Value with
            | "Permanent" -> Status.Permanent
            | "Provisional" -> Status.Provisional
            | "Historical" -> Status.Historical

        let criSchemeNumberMeta = scheme.Cri.Value

        // TODO fix wellKnownUriSupport
        let wellKnownUriSupportMeta =
            match scheme.WellKnown with
            | _ when scheme.WellKnown.IsSome ->
                match scheme.WellKnown.Value.Value with
                | _ when scheme.WellKnown.Value.Value.IsSome ->
                    match scheme.WellKnown.Value.Value.Value with
                    | "-" -> "None"
                    | "" -> "None"
                    | _ -> $"""Some("{scheme.WellKnown.Value.Value.Value}")"""
                | _ -> "None"
            | _ -> "None"

        let letMeta = FSLang.Ensure.letBinding lexicalFormMeta

        let schemeRecord =
            trimmedString
                $"""
let {letMeta} = 
    {{
    
        lexicalForm = "{lexicalFormMeta}"
        description = {descriptionMeta}
        status = Iana.Status.{statusMeta}
        criSchemeNumber = {criSchemeNumberMeta}
        wellKnownUriSupport = {wellKnownUriSupportMeta}
        

    }}

            """

        schemeRecord

    )
    |> String.concat "\n\n"

let schemeBindings =
    schemes
    |> Array.Parallel.map (fun scheme ->

        FSLang.Ensure.letBinding scheme.Value.Value.XElement.Value

    )
    |> String.concat " ; "

let URISchemes =
    trimmedString
        $"""
#load @"{Path.Combine(__SOURCE_DIRECTORY__, __SOURCE_FILE__)}"

type Scheme = 
    {{

        lexicalForm:string
        description:string option
        status: Iana.Status
        criSchemeNumber:int
        wellKnownUriSupport: string option

    }}
{schemeRecords}
let all = [|{schemeBindings}|]
    
    """

File.WriteAllText(Path.Combine("WorldWideWeb", "URISchemes.fsx"), URISchemes)

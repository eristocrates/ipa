open System
open System.Text

#r "nuget: XParsec"
open XParsec
#r @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Project\ParserCombinator\bin\Debug\net10.0\Ergonomics.dll"

open Ergonomics.XParsecErgonomics
#r @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Project\ParserCombinator\bin\Debug\net10.0\Unicodepoint.dll"
open Unicodepoint
#r @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Project\ParserCombinator\bin\Debug\net10.0\ParserCombinator.dll"

open ParserCombinator.IRI
open ParserCombinator.Turtle




// TODO handle multiplicity of possible prefixes. declared preferred by creators, my fully qualified preferences, etc
type Prefix_ID =
    {

      namespace_reference: IRI
      content_reference: IRI voption
      turtle_prefix: Turtle_Prefix_Name

     }

    static member from_namespace (namespace_input: string) (prefix_input: string) =

        {

          namespace_reference = result_from_parse IRI.parse OnInput namespace_input
          content_reference = ValueNone
          turtle_prefix = Turtle_Prefix_Name.from_string prefix_input

        }

    static member from_namespace_content
        (namespace_input: string)

        (content_input: string)
        (prefix_input: string)
        =

        {

          namespace_reference = result_from_parse IRI.parse OnInput namespace_input
          content_reference = ValueSome(result_from_parse IRI.parse OnInput content_input)
          turtle_prefix = Turtle_Prefix_Name.from_string prefix_input

        }




type Prefixed_Name =
    {

      prefix_name: Turtle_Prefix_Name
      local_name: Turtle_Local_Name

     }

    member this.as_characters =
        Seq.concat [

                     this.prefix_name.as_characters
                     seq { { as_rune = Rune ':' } }
                     this.local_name.as_characters

                      ]

    member this.as_string = $"{this.prefix_name.as_string}:{this.local_name.as_string}"

    member this.expanded prefix_ids =
        let prefix_id =
            prefix_ids
            |> Seq.find (fun prefix_id -> prefix_id.turtle_prefix = this.prefix_name)


        $"{prefix_id.namespace_reference.as_string}{this.local_name}"

    static member from_strings (prefix_input: string) (local_input: string) =
        {

          prefix_name = Turtle_Prefix_Name.from_string prefix_input
          local_name = Turtle_Local_Name.from_string local_input

        }

    static member from_prefix_id (prefix_id: Prefix_ID) (local_input: string) =
        {

          prefix_name = prefix_id.turtle_prefix
          local_name = Turtle_Local_Name.from_string local_input

        }

type IRIREF =
    { as_name: IRI_Reference }

    member this.as_string = $"<{this.as_name.as_string}>"

    static member from_string(input: string) =
        { as_name = result_from_parse IRI_Reference.parse OnInput input }

type RDF_IRI =
    | FromPrefixedName of Prefixed_Name
    | FromIRIREF of IRIREF

    member this.as_string =
        match this with
        | FromPrefixedName prefixed_name -> prefixed_name.as_string
        | FromIRIREF iriref -> iriref.as_string






let file_scheme (filePath: string) =
    let solidusPath = filePath.Replace("\\", "/")
    $"file:///{solidusPath}"


module https =
    module www =
        module example =
            module com =
                let prefix_id = Prefix_ID.from_namespace "https://www.example.com/" "example"






module Surface =
    let prefix_id = Prefix_ID.from_namespace (file_scheme @"D:\Surface\") "Surface"

module Artifact =
    let prefix_id = Prefix_ID.from_namespace (file_scheme @"D:\Artifact\") "Artifact"

let prefix_ids =
    seq {

        https.www.example.com.prefix_id
        Surface.prefix_id
        Artifact.prefix_id

    }

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Parsing\Identifier\Resource\XML\XML.fsx"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Parsing\Identifier\Resource\IRI\IRI.fsx"

open IRI


type RDF_Namespace =

    {

      namespace_prefix: XML.NonColon_Name
      namespace_name: IRI_Reference

     }

open System
open System.Web
open System.Text
open System.IO
open System.Globalization
open System.Collections.Immutable

#r "nuget: FSharp.Data"
#r "nuget: XParsec"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\ParserCombinator\Identifier\Resource\Internationalized\Internationalized_Resource_Identifier.fsx"

open Internationalized_Resource_Identifier

open XParsec
open XParsecErgonomics

open FSharp.Data
open UnicodeStandard


























[<Struct>]
type Prefix_Mapping =
    {

      preferred_prefix: string
      personal_prefix: string option

     }

    static member namespaces =
        Map.ofList [

                     "https://www.w3.org/ns/activitystreams#",
                     { preferred_prefix = "as"
                       personal_prefix = None }
                     "http://www.w3.org/ns/csvw#",
                     { preferred_prefix = "csvw"
                       personal_prefix = None }
                     "http://www.w3.org/ns/dcat#",
                     { preferred_prefix = "dcat"
                       personal_prefix = None }
                     "http://www.w3.org/ns/dqv#",
                     { preferred_prefix = "dqv"
                       personal_prefix = None }
                     "https://www.w3.org/ns/duv#",
                     { preferred_prefix = "duv"
                       personal_prefix = None }
                     "http://www.w3.org/2003/g/data-view#",
                     { preferred_prefix = "grddl"
                       personal_prefix = None }
                     "http://www.w3.org/ns/json-ld#",
                     { preferred_prefix = "jsonld"
                       personal_prefix = None }
                     "http://www.w3.org/ns/ldp#",
                     { preferred_prefix = "ldp"
                       personal_prefix = None }
                     "http://www.w3.org/ns/ma-ont#",
                     { preferred_prefix = "ma"
                       personal_prefix = None }
                     "http://www.w3.org/ns/oa#",
                     { preferred_prefix = "oa"
                       personal_prefix = None }
                     "http://www.w3.org/ns/odrl/2/",
                     { preferred_prefix = "odrl"
                       personal_prefix = None }
                     "http://www.w3.org/ns/org#",
                     { preferred_prefix = "org"
                       personal_prefix = None }
                     "http://www.w3.org/2002/07/owl#",
                     { preferred_prefix = "owl"
                       personal_prefix = None }
                     "http://www.w3.org/ns/prov#",
                     { preferred_prefix = "prov"
                       personal_prefix = None }
                     "http://purl.org/linked-data/cube#",
                     { preferred_prefix = "qb"
                       personal_prefix = None }
                     "http://www.w3.org/1999/02/22-rdf-syntax-ns#",
                     { preferred_prefix = "rdf"
                       personal_prefix = None }
                     "http://www.w3.org/ns/rdfa#",
                     { preferred_prefix = "rdfa"
                       personal_prefix = None }
                     "http://www.w3.org/2000/01/rdf-schema#",
                     { preferred_prefix = "rdfs"
                       personal_prefix = None }
                     "http://www.w3.org/2007/rif#",
                     { preferred_prefix = "rif"
                       personal_prefix = None }
                     "http://www.w3.org/ns/r2rml#",
                     { preferred_prefix = "rr"
                       personal_prefix = None }
                     "http://www.w3.org/ns/sparql-service-description#",
                     { preferred_prefix = "sd"
                       personal_prefix = None }
                     "http://www.w3.org/2004/02/skos/core#",
                     { preferred_prefix = "skos"
                       personal_prefix = None }
                     "http://www.w3.org/2008/05/skos-xl#",
                     { preferred_prefix = "skosxl"
                       personal_prefix = None }
                     "http://www.w3.org/ns/ssn/",
                     { preferred_prefix = "ssn"
                       personal_prefix = None }
                     "http://www.w3.org/ns/sosa/",
                     { preferred_prefix = "sosa"
                       personal_prefix = None }
                     "http://www.w3.org/2006/time#",
                     { preferred_prefix = "time"
                       personal_prefix = None }
                     "http://rdfs.org/ns/void#",
                     { preferred_prefix = "void"
                       personal_prefix = None }
                     "http://www.w3.org/2007/05/powder#",
                     { preferred_prefix = "wdr"
                       personal_prefix = None }
                     "http://www.w3.org/2007/05/powder-s#",
                     { preferred_prefix = "wdrs"
                       personal_prefix = None }
                     "http://www.w3.org/1999/xhtml/vocab#",
                     { preferred_prefix = "xhv"
                       personal_prefix = None }
                     "http://www.w3.org/XML/1998/namespace",
                     { preferred_prefix = "xml"
                       personal_prefix = None }
                     "http://www.w3.org/2001/XMLSchema#",
                     { preferred_prefix = "xsd"
                       personal_prefix = None }
                     "http://www.example.org/",
                     { preferred_prefix = "ex"
                       personal_prefix = Some("example") }

                      ]

[<Struct>]
type IRIREF =
    {

      as'string: string
      iri: IRI voption
      relative_reference: Internationalized_Relative_Reference voption
      is'relative: bool

     }

    static member parse: Parser<IRIREF, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (IRI_Reference.parse
             |>> fun iri_reference ->

                     {

                       as'string = $"<iri_reference.as'string>"
                       iri = iri_reference.iri
                       relative_reference = iri_reference.relative_reference
                       is'relative = iri_reference.is'relative

                     }

            )
            """ IRIREF 	::= 	'<' ([^#x00-#x20<>"{}|^`\] | UCHAR)* '>' """

type Version_Directive = { versionSpecifier: string }

[<RequireQualifiedAccess>]
type Directive =
    | VERSION of Version_Directive
    | version of Version_Directive

type RDF_Language_String =
    {

      as'string: string
      language_tag: string
      initial_text_direction: string option


     }

type RDF_Datatyped_String =
    {

      as'string: string
      datatype: IRIREF

     }

type RDF_Literal =
    | FromRDFLanguageString of RDF_Language_String
    | FromRDFDatatypedString of RDF_Datatyped_String

type Blank_Node = { label: string }

[<Struct>]
type Prefix_ID =
    {

      namespace_reference: string
      prefix_name: string option

     }

    static member from'namespace_iri_string(namespace_iri_string: string) =
        let iri = result'from_parse IRI.parse OnInput namespace_iri_string

        {

          namespace_reference = iri.as'string
          prefix_name =
            match Prefix_Mapping.namespaces.TryFind namespace_iri_string with
            | Some prefix_mapping -> Some(defaultArg prefix_mapping.personal_prefix prefix_mapping.preferred_prefix)
            | _ -> None

        }

[<Struct>]
type CURIE =
    {

      prefix_id: Prefix_ID
      local_name: string
      expanded_name: string
      prefixed_name: string

     }



    static member from_prefix_id (prefix_id: Prefix_ID) (local_name: string) =
        {

          prefix_id = prefix_id
          local_name = local_name
          expanded_name = $"{prefix_id.namespace_reference}{local_name}"
          prefixed_name = $"{prefix_id.prefix_name.Value}:{local_name}"


        }

[<RequireQualifiedAccess>]
type RDF_IRI =
    | FromIRIREF of IRIREF
    | FromCURIE of CURIE

type RDF_Verb = { as'string: string; iri: RDF_IRI }




[<RequireQualifiedAccess>]
type RDF_Subject =
    | FromRDFIRI of RDF_IRI
    | FromBlankNode of Blank_Node

and [<RequireQualifiedAccess>] RDF_Predicate =
    | FromRDFIRI of RDF_IRI
    | FromRDFVerb of RDF_Verb

and [<RequireQualifiedAccess>] RDF_Object =
    | FromRDFIRI of RDF_IRI
    | FromBlankNode of Blank_Node
    | FromRDFliteral of RDF_Literal
    | FromRDFTripleTerm of RDF_Triple_Term

and RDF_Triple_Term = { triple: Triple }

and Triple =
    {

      subject: RDF_Subject
      predicate: RDF_Predicate
      object: RDF_Object

     }

[<RequireQualifiedAccess>]
type Statement =
    | FromDirective of Directive
    | FromTriple of Triple



[<Struct>]
type RDF_Term_Kind =
    | IRIREF
    | CURIE
    | DatatypedLiteral
    | LanguageString
    | Blank
    | Triple


[<Struct>]
type RDF_Term =
    {

      kind: RDF_Term_Kind
      iri: IRI option
      prefix_id: Prefix_ID
      local_name: string
      expanded_name: string
      prefixed_name: string
      as'string: string

     }



(*
    store.CreateEntity();
    store.CreateEntity();

    foreach (var entity in store.Entities) {
        Console.WriteLine($"entity {entity}");
    }
    // > entity id: 1  []       Info:  [] entity has no components
    // > entity id: 2  []

*)

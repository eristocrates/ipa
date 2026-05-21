open System
open System.Threading
open System.IO
open System.IO.Compression
open System.Net.Http
open System.Xml
open System.Text
open System.IO
open System.Globalization

#r "nuget: dotNetRdf"

open VDS.RDF
open VDS.RDF.Parsing
open VDS.RDF.JsonLd

#r "nuget: FParsec"
#r "nuget: FParsec-Pipes"

#r "nuget: FsHttp"

open FsHttp

#r "nuget: FSharp.Data"
open FSharp.Data

#r "nuget: Unquote"
#r "nuget: XParsec"

#r "nuget: Hedgehog"

#r "nuget: NeatIntervals"


open Swensen.Unquote.Assertions

#r "nuget: FsCheck"

open FsCheck

#r "nuget: MessagePack"
#r "nuget: MessagePack.FSharpExtensions"

open MessagePack
open MessagePack.Resolvers
open MessagePack.FSharp

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\PowershellErgonomics.fsx"

open PowershellErgonomics
#r "nuget: ObjectLayoutInspector"
open ObjectLayoutInspector

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\ParserCombinator\Identifier\Resource\Internationalized\Internationalized_Resource_Identifier.fsx"

open StringExtensions

open Resource_Identifier
open XParsecErgonomics
open Unicode_Standard
open XParsec
open Internationalized_Resource_Identifier

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\FileSystemErgonomics.fsx"
open FileSystemErgonomics


#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\IriPathing.fsx"
open IriPathing

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\LMDB\LMDB.fsx"
open LMDB

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Extensions\JavascriptObjectNotationExtensions.fsx"

open JavascriptObjectNotationExtensions

open FSharp.Json

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Registry_Priors.fsx"







[<Literal>]
let DoxAletheiaRootDirectory =
    @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia"

let VocabularyDirectory =
    ensure_path (Path.Combine(DoxAletheiaRootDirectory, "Vocabulary"))





let domain_base = "https://eristocrates.dev/ontology"

let namespace_to_prefix_overrides =
    [|

       "http://rdfs.org/sioc/types#", "sioc_types"
       "http://rdfs.org/sioc/actions#", "sioc_actions"
       "http://rdfs.org/sioc/services#", "sioc_services"
       "http://www.w3.org/2005/xpath-functions", "xfn" // for functions — associated with fn. The namespace prefix used in this document for most functions that are available to users is fn.
       "http://www.w3.org/2005/xpath-functions/array", "xfn_array" // for functions — associated with . This namespace is used for some functions that manipulate maps (see 17.3 Functions that Operate on Arrays). The namespace prefix used in this document for these functions is array. These functions are available to users in exactly the same way as those in the fn namespace.
       "http://www.w3.org/2005/xpath-functions/map", "xfn_map" // for functions — associated with . This namespace is used for some functions that manipulate maps (see 17.1 Functions that Operate on Maps). The namespace prefix used in this document for these functions is map. These functions are available to users in exactly the same way as those in the fn namespace.
       "http://www.w3.org/2005/xpath-functions/math", "xfn_math" // for functions — associated with . This namespace is used for some mathematical functions. The namespace prefix used in this document for these functions is math. These functions are available to users in exactly the same way as those in the fn namespace.
       "http://www.w3.org/2005/xqt-errors", "xqt_err" // — associated with . There are no functions in this namespace; it is used for error codes. This document uses the prefix err to represent the namespace URI http://www.w3.org/2005/xqt-errors, which is the namespace for all XPath and XQuery error codes and messages. This namespace prefix is not predeclared and its use in this document is not normative.
       "http://www.w3.org/2006/time#", "owl_time"
       "https://www.w3.org/2003/05/xpath-datatypes#", "xdt"
       "https://www.w3.org/2010/xslt-xquery-serialization", "xqt_output" // [Definition: the Output declaration namespace, ]; associated with output. There are no functions in this namespace: it is used for serialization parameters, as described in [XSLT and XQuery Serialization 3.1]
       "http://www.w3.org/2011/http-headers#", "http-headers"
       "http://www.w3.org/2011/http-methods#", "http-methods"
       "http://www.example.org/", "example"


       |]






let endogenous =
    [|

       $"{domain_base}/adhoc/", ""
       "https://w3id.org/uri4uri/mime/application/", "mime_application"
       $"{domain_base}/operator/", "op" // "Functions defined with the op prefix are described here to underpin the definitions of the operators in [XML Path Language (XPath) 3.1], [XQuery 3.1: An XML Query Language] and [XSL Transformations (XSLT) Version 3.0]. These functions are not available directly to users, and there is no requirement that implementations should actually provide these functions. For this reason, no namespace is associated with the op prefix. For example, multiplication is generally associated with the * operator, but it is described as a function in this document:
       $"{domain_base}/resource_description_framework/", "rdfx"
       $"{domain_base}/unicode/", "unicode"
       $"{domain_base}/vocabulary/", "vocabulary"
       "https://leoncountyfl-my.sharepoint.com/personal/collierb_leoncountyfl_gov/Documents/ontology/swin/", "swin"

       |]

let exogenous =
    [|


       "http://example.org/geologic/", "geol"
       "http://www.w3.org/2001/XMLSchema-instance#", "xsi"
       "http://www.w3.org/ns/time/gregorian#", "greg"
       "https://www.w3.org/1998/Math/MathML", "mathml" // [Definition: the MathML namespace namespace, ]
       "https://www.w3.org/1999/xhtml", "xhtml" // [Definition: the XHTML namespace namespace, ];
       "https://www.w3.org/2000/svg", "svg" // [Definition: the SVG namespace, ]; and
       "http://www.w3.org/1999/XSL/Transform", "xslt"
       "http://www.lexinfo.net/ontology/3.0/lexinfo#", "lexinfo"
       "http://www.w3.org/ns/lemon/frac#", "frac"
       "http://www.w3.org/ns/lemon/lime#", "lime"
       "http://www.w3.org/ns/lemon/ontolex#", "ontolex"
       "http://www.w3.org/ns/lemon/synsem#", "synsem"
       "http://www.w3.org/ns/lemon/vartrans#", "vartrans"
       "https://w3id.org/linkml/", "linkml"
       "http://schema.org/", "schema"


       |]

let webpage_prefixes =
    [|


       "http://chromedevtools.github.io/devtools-protocol#", "cdp"
       "http://www.w3.org/2011/http#", "http"
       "http://www.w3.org/2011/http-statusCodes#", "http-statusCodes"
       "https://chromedevtools.github.io/devtools-protocol/tot/Network/#", "cdpNetwork"
       "https://chromedevtools.github.io/devtools-protocol/tot/Page/#", "cdpPage"
       "https://www.rfc-editor.org/info/bcp47#", "bcp47"
       "https://x.com/", "twitter"
       "https://x.com/i/api#", "twitterApi"
       "https://x.com/i/communities/", "community"

       |]

let project_prefixes =
    [|

       "http://www.esri.com/schemas/ArcGIS/3.3.0/", "esri"
       "https://schema.infor.com/InforOAGIS/", "infor"
       "https://support.esri.com/en-us/gis-dictionary/", "gis-dict"
       "http://intraraster.leoncountyfl.gov/intraraster/", "intraraster"


       "http://intraraster.leoncountyfl.gov/intraraster/rest/services/MapServices/", "MapServices"
       "http://intraraster.leoncountyfl.gov/intraraster/rest/services/MapServices/",
       "LCPW_OverlayStormwaterInfrastructure_D_WM"
       "http://intraraster.leoncountyfl.gov/intraraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/0/",
       "Drainage_Network"
       "http://intraraster.leoncountyfl.gov/intraraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/1/",
       "Outfall"
       "http://intraraster.leoncountyfl.gov/intraraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/2/",
       "Stormwater_Pond"
       "http://intraraster.leoncountyfl.gov/intraraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/3/",
       "End_Point"
       "http://intraraster.leoncountyfl.gov/intraraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/4/",
       "Inlet"
       "http://intraraster.leoncountyfl.gov/intraraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/5/",
       "Debris_Trap"
       "http://intraraster.leoncountyfl.gov/intraraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/6/",
       "Junction_Fixed"
       "http://intraraster.leoncountyfl.gov/intraraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/7/",
       "Connectivity"
       "http://intraraster.leoncountyfl.gov/intraraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/8/",
       "Generic_Storm_Asset"
       "http://intraraster.leoncountyfl.gov/intraraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/9/",
       "Stormwater_Pond_Discharge"
       "http://intraraster.leoncountyfl.gov/intraraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/10/",
       "Private_Point"
       "http://intraraster.leoncountyfl.gov/intraraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/11/",
       "Conduit"
       "http://intraraster.leoncountyfl.gov/intraraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/12/",
       "Culvert_Cross_Drain"
       "http://intraraster.leoncountyfl.gov/intraraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/13/",
       "Ditch_Point"
       "http://intraraster.leoncountyfl.gov/intraraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/14/",
       "Ditch"
       "http://intraraster.leoncountyfl.gov/intraraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/15/",
       "Bridge_Point"
       "http://intraraster.leoncountyfl.gov/intraraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/16/",
       "Bridge"
       "http://intraraster.leoncountyfl.gov/intraraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/17/",
       "Stormwater_Pond___Top_of_Bank"
       "http://intraraster.leoncountyfl.gov/intraraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/18/",
       "Outfall_Drainage_Area_MS4"
       "http://intraraster.leoncountyfl.gov/intraraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/19/",
       "Outfall_Drainage_Area"
       "http://intraraster.leoncountyfl.gov/intraraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/20/",
       "Outfall_Drainage_Area_MOF"
       "http://intraraster.leoncountyfl.gov/intraraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/21/",
       "Media_Points"
       "http://intraraster.leoncountyfl.gov/intraraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/22/",
       "Damage"
       "http://intraraster.leoncountyfl.gov/intraraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/23/",
       "Non_Drainage_Network"
       "http://intraraster.leoncountyfl.gov/intraraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/24/",
       "Media_Points_Without_Photos"
       "http://intraraster.leoncountyfl.gov/intraraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/25/",
       "Interference"
       "http://intraraster.leoncountyfl.gov/intraraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/26/",
       "Pollution_Control_Box"

       |]



let RDFa_Core_Initial_Context =
    [|


       "http://purl.org/linked-data/cube#", "qb" // "Data Cubes","The RDF Data Cube Vocabulary","W3C Recommendation"
       "http://rdfs.org/ns/void#", "void" // VoID,"Describing Linked Dataets with the VoID Vocabulary","W3C Interest Group Note"
       "http://www.w3.org/1999/02/22-rdf-syntax-ns#", "rdf" // RDF,"RDF Semantics","W3C Recommendation"
       "http://www.w3.org/1999/xhtml/vocab#", "xhv" // "RDFa Default Prefix","RDFa Core 1.1","W3C Recommendation"
       "http://www.w3.org/2000/01/rdf-schema#", "rdfs" // "RDF Schema","RDF Semantics","W3C Recommendation"
       "http://www.w3.org/2001/XMLSchema#", "xsd" // "XML Schema Datatypes","XML Schema Part 2: Datatypes Second Edition","W3C Recommendation"
       "http://www.w3.org/2002/07/owl#", "owl" // OWL,"OWL Overview","W3C Recommendation"
       "http://www.w3.org/2003/g/data-view#", "grddl" // GRDDL,"Gleaning Resource Descriptions from Dialects of Languages (GRDDL)","W3C Recommendation"
       "http://www.w3.org/2004/02/skos/core#", "skos" // "SKOS Core","SKOS Simple Knowledge Organization System Reference","W3C Recommendation"
       "http://www.w3.org/2006/time#", "time" // "Time Ontology","Time Ontology in OWL","W3C Recommendation"
       "http://www.w3.org/2007/05/powder#", "wdr" // POWDER,"Protocol for Web Description Resources (POWDER): Formal Semantics","W3C Recommendation"
       "http://www.w3.org/2007/05/powder-s#", "wdrs" // "POWDER-S","Protocol for Web Description Resources (POWDER): Formal Semantics","W3C Recommendation"
       "http://www.w3.org/2007/rif#", "rif" // RIF,"RIF Overview","W3C Recommendation"
       "http://www.w3.org/2008/05/skos-xl#", "skosxl" // "SKOS eXtension for Labels","SKOS Simple Knowledge Organization System Reference","W3C Recommendation"
       "http://www.w3.org/ns/csvw#", "csvw" // "Metadata for Tabular Data","Metadata Vocabulary for Tabular Data","W3C Recommendation"
       "http://www.w3.org/ns/dcat#", "dcat" // "Data Catalog Vocabulary","Data Catalog Vocabulary (DCAT)","W3C Recommendation"
       "http://www.w3.org/ns/dqv#", "dqv" // "Data Quality Vocabulary","Data               on the Web Best Practices: Data Quality Vocabulary","W3C WG Note"
       "http://www.w3.org/ns/json-ld#", "jsonld" // "JSON-LD","JSON-LD 1.1, A JSON-based Serialization for Linked Data","W3C Recommendation"
       "http://www.w3.org/ns/ldp#", "ldp" // "Linked Data Platform Vocabulary","Linked Data Platform 1.0","W3C Recommendation"
       "http://www.w3.org/ns/ma-ont#", "ma" // "Ontology for Media Resources","Ontology for Media Resources 1.0","W3C Recommendation"
       "http://www.w3.org/ns/oa#", "oa" // "Web Annotation Vocabulary","Web Annotation Vocabulary","W3C Recommendation"
       "http://www.w3.org/ns/odrl/2/", "odrl" // "ODRL Vocabulary & Expression 2.2","ODRL Vocabulary & Expression 2.2","W3C Recommendation"
       "http://www.w3.org/ns/org#", "org" // Organizations,"The Organization Ontology","W3C Recommendation"
       "http://www.w3.org/ns/prov#", "prov" // "Provenance Vocabulary","Provenance Ontology","W3C Recommendation"
       "http://www.w3.org/ns/r2rml#", "rr" // R2RML,"R2RML: RDB to RDF Mapping Language","W3C Recommendation"
       "http://www.w3.org/ns/rdfa#", "rdfa" // "RDFa Vocabulary","RDFa Core 1.1","W3C Recommendation"
       "http://www.w3.org/ns/sosa/", "sosa" // "Sensor, Observation, Sample, and Actuator Ontology","Semantic Sensor Network Ontology","W3C Recommendation"
       "http://www.w3.org/ns/sparql-service-description#", "sd" // "SPARQL 1.1 Service Description","SPARQL 1.1 Service Description","W3C Recommendation"
       "http://www.w3.org/ns/ssn/", "ssn" // "Semantic Sensor Network Ontology","Semantic Sensor Network Ontology","W3C Recommendation"
       "http://www.w3.org/XML/1998/namespace", "xml" // "XML Reserved Prefix","Namespaces in XML 1.0","W3C Recommendation"
       "https://www.w3.org/ns/activitystreams#", "as" // "Activity Vocabulary","Activity Vocabulary","W3C Recommendation"
       "https://www.w3.org/ns/duv#", "duv" // "Dataet Usage Vocabulary","Dataet Usage Vocabulary","W3C WG Note"

       |]



































let personal_vocabularies =
    Array.concat [| RDFa_Core_Initial_Context
                    endogenous
                    webpage_prefixes
                    exogenous
                    project_prefixes
                    namespace_to_prefix_overrides


                     |]

let prefix_map =
    personal_vocabularies
    |> Array.map (fun (vocabulary, prefix) -> (prefix, vocabulary))
    |> Map.ofArray

































type RDF_Prefix = private Prefix of string

type CURIE =
    { prefix: RDF_Prefix
      reference: string }

module Resolved_IRI =

    let from_lexical_forms (lexical_forms: Lexical_Form array) =
        lexical_forms
        |> Array.map (fun lexical_form -> ResolvedIRI lexical_form.form_id.to_encoding)

    let from_trusted_string (raw_string: string) =
        Database.Get.Lexical_Forms_from_Strings [| raw_string |]
        |> from_lexical_forms
        |> Database.Get.RDF_Terms_From_RDF_Term_Data
        |> Array.filter (fun term -> term.rdf_term_data.IsResolvedIRI)
        |> Array.find (fun term -> RDF_Term.to_string term = raw_string)

    let from_trusted_strings (namespace_string: string) (local_names: string array) =
        let form_strings =
            local_names
            |> Array.Parallel.map (fun local_name -> $"{namespace_string}{local_name}")

        Database.Get.Lexical_Forms_from_Strings form_strings
        |> from_lexical_forms
        |> Database.Get.RDF_Terms_From_RDF_Term_Data
        |> Array.Parallel.filter (fun term -> term.rdf_term_data.IsResolvedIRI)
        |> Array.Parallel.choose (fun term ->
            if form_strings
               |> Array.exists (fun form_string -> RDF_Term.to_string term = form_string) then
                Some(term)
            else
                None

        )






module Relative_IRI =

    let from_lexical_forms (lexical_forms: Lexical_Form array) =
        lexical_forms
        |> Array.map (fun lexical_form -> RelativeIRI lexical_form.form_id.to_encoding)

    let from_trusted_string (raw_string: string) =
        Database.Get.Lexical_Forms_from_Strings [| raw_string |]
        |> from_lexical_forms
        |> Database.Get.RDF_Terms_From_RDF_Term_Data
        |> Array.filter (fun term -> term.rdf_term_data.IsRelativeIRI)
        |> Array.find (fun term -> RDF_Term.to_string term = raw_string)

    let low_lined (raw_string: string) =
        from_trusted_string (raw_string.Replace(" ", "_"))

    let resolve (RelativeIRI relative_form_id) (ResolvedIRI resolved_form_id) =
        Resolved_IRI.from_trusted_string
            $"{relative_form_id
               |> Form_ID.from_encoding
               |> Form_ID.to_string}{resolved_form_id
                                     |> Form_ID.from_encoding
                                     |> Form_ID.to_string}"

    let lexical_form (RelativeIRI form_id_bytes) =
        let form_id = Form_ID.from_encoding form_id_bytes

        { string_value = form_id |> Form_ID.to_string
          form_id = form_id }



type RDF_Prefix with
    static member from_string(raw_string: string) = Prefix raw_string

    member this.representation =
        let (Prefix prefix) = this
        $"{prefix}:"

    member this.namespace_name =
        let (Prefix prefix) = this
        Resolved_IRI.from_trusted_string prefix_map[prefix]


type CURIE with

    member this.expand =
        Resolved_IRI.from_trusted_string $"{RDF_Term.to_string this.prefix.namespace_name}{this.reference}"

    member this.representation = $"{this.prefix.representation}{this.reference}"

    static member from_prefix(prefix: RDF_Prefix) =
        {

          prefix = prefix
          reference = String.Empty

        }

type RDF_Prefix with
    member this.compact = CURIE.from_prefix this


let prefix_label (prefix_label: string) (raw_local_name: string) =

    (*
    {

      prefix = RDF_Prefix.from_string prefix_label
      reference = raw_local_name

    }
*)
    let prefix = RDF_Prefix.from_string prefix_label
    let local_name = raw_local_name.Replace(" ", "_")


    try
        Resolved_IRI.from_trusted_string $"{RDF_Term.to_string prefix.namespace_name}{local_name}"
    with
    | err -> failwith $"{prefix_label}:{raw_local_name} failed with error message: {err.Message}"

let prefix_labels (prefix_label: string) (raw_local_names: string array) =

    let prefix = RDF_Prefix.from_string prefix_label

    let local_names =
        raw_local_names
        |> Array.Parallel.map (fun raw_local_name -> raw_local_name.Replace(" ", "_"))


    try
        Resolved_IRI.from_trusted_strings $"{RDF_Term.to_string prefix.namespace_name}" local_names
    with
    | err -> failwithf "%s with local names %A  failed with error message: %s" prefix_label local_names err.Message






















module rdf =
    let prefix = prefix_label "rdf"


    /// The class of containers of alternatives.
    let Alt = prefix "Alt"


    /// The class of unordered containers.
    let Bag = prefix "Bag"


    /// A class representing a compound literal.
    let CompoundLiteral = prefix "CompoundLiteral"


    /// The datatype of RDF literals storing fragments of HTML content
    let HTML = prefix "HTML"


    /// The datatype of RDF literals storing JSON content.
    let JSON = prefix "JSON"


    /// The class of RDF Lists.
    let List = prefix "List"


    /// The class of plain (i.e. untyped) literal values, as used in RIF and OWL 2
    let PlainLiteral = prefix "PlainLiteral"


    /// The class of RDF properties.
    let Property = prefix "Property"


    /// The class of ordered containers.
    let Seq = prefix "Seq"


    /// The class of RDF statements.
    let Statement = prefix "Statement"


    /// The datatype of XML literal values.
    let XMLLiteral = prefix "XMLLiteral"


    /// The base direction component of a CompoundLiteral.
    let direction = prefix "direction"


    /// The first item in the subject RDF list.
    let first = prefix "first"


    /// The datatype of language-tagged string values
    let langString = prefix "langString"


    /// The language component of a CompoundLiteral.
    let language = prefix "language"


    /// The empty list, with no items in it. If the rest of a list is nil then the list has no more items in it.
    let nil = prefix "nil"


    /// The object of the subject RDF statement.
    let object = prefix "object"


    /// The predicate of the subject RDF statement.
    let predicate = prefix "predicate"


    /// The rest of the subject RDF list after the first item.
    let rest = prefix "rest"


    /// The subject of the subject RDF statement.
    let subject = prefix "subject"


    /// The subject is an instance of a class.
    let ``type`` = prefix "type"


    /// Idiomatic property used for structured values.
    let value = prefix "value"

let a = rdf.``type``



module rdfs =
    let prefix = prefix_label "rdfs"


    /// The class of classes.
    let Class = prefix "Class"


    /// The class of RDF containers.
    let Container = prefix "Container"


    /// The class of container membership properties, rdf:_1, rdf:_2, ...,
    ///                     all of which are sub-properties of 'member'.
    let ContainerMembershipProperty = prefix "ContainerMembershipProperty"


    /// The class of RDF datatypes.
    let Datatype = prefix "Datatype"


    /// The class of literal values, eg. textual strings and integers.
    let Literal = prefix "Literal"


    /// The class resource, everything.
    let Resource = prefix "Resource"


    /// A description of the subject resource.
    let comment = prefix "comment"


    /// A domain of the subject property.
    let domain = prefix "domain"


    /// The defininition of the subject resource.
    let isDefinedBy = prefix "isDefinedBy"


    /// A human-readable name for the subject.
    let label = prefix "label"


    /// A member of the subject resource.
    let ``member`` = prefix "member"


    /// A range of the subject property.
    let range = prefix "range"


    /// Further information about the subject resource.
    let seeAlso = prefix "seeAlso"


    /// The subject is a subclass of a class.
    let subClassOf = prefix "subClassOf"


    /// The subject is a subproperty of a property.
    let subPropertyOf = prefix "subPropertyOf"

module owl =

    let prefix = prefix_label "owl"

    /// The class of collections of pairwise different individuals.
    let AllDifferent = prefix "AllDifferent"


    /// The class of collections of pairwise disjoint classes.
    let AllDisjointClasses = prefix "AllDisjointClasses"


    /// The class of collections of pairwise disjoint properties.
    let AllDisjointProperties = prefix "AllDisjointProperties"


    /// The class of annotated annotations for which the RDF serialization consists of an annotated subject, predicate and object.
    let Annotation = prefix "Annotation"


    /// The class of annotation properties.
    let AnnotationProperty = prefix "AnnotationProperty"


    /// The class of asymmetric properties.
    let AsymmetricProperty = prefix "AsymmetricProperty"


    /// The class of annotated axioms for which the RDF serialization consists of an annotated subject, predicate and object.
    let Axiom = prefix "Axiom"


    /// The class of OWL classes.
    let Class = prefix "Class"


    /// The class of OWL data ranges, which are special kinds of datatypes. Note: The use of the IRI owl:DataRange has been deprecated as of OWL 2. The IRI rdfs:Datatype SHOULD be used instead.
    let DataRange = prefix "DataRange"


    /// The class of data properties.
    let DatatypeProperty = prefix "DatatypeProperty"


    /// The class of deprecated classes.
    let DeprecatedClass = prefix "DeprecatedClass"


    /// The class of deprecated properties.
    let DeprecatedProperty = prefix "DeprecatedProperty"


    /// The class of functional properties.
    let FunctionalProperty = prefix "FunctionalProperty"


    /// The class of inverse-functional properties.
    let InverseFunctionalProperty = prefix "InverseFunctionalProperty"


    /// The class of irreflexive properties.
    let IrreflexiveProperty = prefix "IrreflexiveProperty"


    /// The class of named individuals.
    let NamedIndividual = prefix "NamedIndividual"


    /// The class of negative property assertions.
    let NegativePropertyAssertion = prefix "NegativePropertyAssertion"


    /// This is the empty class.
    let Nothing = prefix "Nothing"


    /// The class of object properties.
    let ObjectProperty = prefix "ObjectProperty"


    /// The class of ontologies.
    let Ontology = prefix "Ontology"


    /// The class of ontology properties.
    let OntologyProperty = prefix "OntologyProperty"


    /// The class of reflexive properties.
    let ReflexiveProperty = prefix "ReflexiveProperty"


    /// The class of property restrictions.
    let Restriction = prefix "Restriction"


    /// The class of symmetric properties.
    let SymmetricProperty = prefix "SymmetricProperty"


    /// The class of OWL individuals.
    let Thing = prefix "Thing"


    /// The class of transitive properties.
    let TransitiveProperty = prefix "TransitiveProperty"


    /// The property that determines the class that a universal property restriction refers to.
    let allValuesFrom = prefix "allValuesFrom"


    /// The property that determines the predicate of an annotated axiom or annotated annotation.
    let annotatedProperty = prefix "annotatedProperty"


    /// The property that determines the subject of an annotated axiom or annotated annotation.
    let annotatedSource = prefix "annotatedSource"


    /// The property that determines the object of an annotated axiom or annotated annotation.
    let annotatedTarget = prefix "annotatedTarget"


    /// The property that determines the predicate of a negative property assertion.
    let assertionProperty = prefix "assertionProperty"


    /// The annotation property that indicates that a given ontology is backward compatible with another ontology.
    let backwardCompatibleWith = prefix "backwardCompatibleWith"


    /// The data property that does not relate any individual to any data value.
    let bottomDataProperty = prefix "bottomDataProperty"


    /// The object property that does not relate any two individuals.
    let bottomObjectProperty = prefix "bottomObjectProperty"


    /// The property that determines the cardinality of an exact cardinality restriction.
    let cardinality = prefix "cardinality"


    /// The property that determines that a given class is the complement of another class.
    let complementOf = prefix "complementOf"


    /// The property that determines that a given data range is the complement of another data range with respect to the data domain.
    let datatypeComplementOf = prefix "datatypeComplementOf"


    /// The annotation property that indicates that a given entity has been deprecated.
    let deprecated = prefix "deprecated"


    /// The property that determines that two given individuals are different.
    let differentFrom = prefix "differentFrom"


    /// The property that determines that a given class is equivalent to the disjoint union of a collection of other classes.
    let disjointUnionOf = prefix "disjointUnionOf"


    /// The property that determines that two given classes are disjoint.
    let disjointWith = prefix "disjointWith"


    /// The property that determines the collection of pairwise different individuals in a owl:AllDifferent axiom.
    let distinctMembers = prefix "distinctMembers"


    /// The property that determines that two given classes are equivalent, and that is used to specify datatype definitions.
    let equivalentClass = prefix "equivalentClass"


    /// The property that determines that two given properties are equivalent.
    let equivalentProperty = prefix "equivalentProperty"


    /// The property that determines the collection of properties that jointly build a key.
    let hasKey = prefix "hasKey"


    /// The property that determines the property that a self restriction refers to.
    let hasSelf = prefix "hasSelf"


    /// The property that determines the individual that a has-value restriction refers to.
    let hasValue = prefix "hasValue"


    /// The property that is used for importing other ontologies into a given ontology.
    let imports = prefix "imports"


    /// The annotation property that indicates that a given ontology is incompatible with another ontology.
    let incompatibleWith = prefix "incompatibleWith"


    /// The property that determines the collection of classes or data ranges that build an intersection.
    let intersectionOf = prefix "intersectionOf"


    /// The property that determines that two given properties are inverse.
    let inverseOf = prefix "inverseOf"


    /// The property that determines the cardinality of a maximum cardinality restriction.
    let maxCardinality = prefix "maxCardinality"


    /// The property that determines the cardinality of a maximum qualified cardinality restriction.
    let maxQualifiedCardinality = prefix "maxQualifiedCardinality"


    /// The property that determines the collection of members in either a owl:AllDifferent, owl:AllDisjointClasses or owl:AllDisjointProperties axiom.
    let members = prefix "members"


    /// The property that determines the cardinality of a minimum cardinality restriction.
    let minCardinality = prefix "minCardinality"


    /// The property that determines the cardinality of a minimum qualified cardinality restriction.
    let minQualifiedCardinality = prefix "minQualifiedCardinality"


    /// The property that determines the class that a qualified object cardinality restriction refers to.
    let onClass = prefix "onClass"


    /// The property that determines the data range that a qualified data cardinality restriction refers to.
    let onDataRange = prefix "onDataRange"


    /// The property that determines the datatype that a datatype restriction refers to.
    let onDatatype = prefix "onDatatype"


    /// The property that determines the n-tuple of properties that a property restriction on an n-ary data range refers to.
    let onProperties = prefix "onProperties"


    /// The property that determines the property that a property restriction refers to.
    let onProperty = prefix "onProperty"


    /// The property that determines the collection of individuals or data values that build an enumeration.
    let oneOf = prefix "oneOf"


    /// The annotation property that indicates the predecessor ontology of a given ontology.
    let priorVersion = prefix "priorVersion"


    /// The property that determines the n-tuple of properties that build a sub property chain of a given property.
    let propertyChainAxiom = prefix "propertyChainAxiom"


    /// The property that determines that two given properties are disjoint.
    let propertyDisjointWith = prefix "propertyDisjointWith"


    /// The property that determines the cardinality of an exact qualified cardinality restriction.
    let qualifiedCardinality = prefix "qualifiedCardinality"


    /// The property that determines that two given individuals are equal.
    let sameAs = prefix "sameAs"


    /// The property that determines the class that an existential property restriction refers to.
    let someValuesFrom = prefix "someValuesFrom"


    /// The property that determines the subject of a negative property assertion.
    let sourceIndividual = prefix "sourceIndividual"


    /// The property that determines the object of a negative object property assertion.
    let targetIndividual = prefix "targetIndividual"


    /// The property that determines the value of a negative data property assertion.
    let targetValue = prefix "targetValue"


    /// The data property that relates every individual to every data value.
    let topDataProperty = prefix "topDataProperty"


    /// The object property that relates every two individuals.
    let topObjectProperty = prefix "topObjectProperty"


    /// The property that determines the collection of classes or data ranges that build a union.
    let unionOf = prefix "unionOf"


    /// The property that identifies the version IRI of an ontology.
    let versionIRI = prefix "versionIRI"


    /// The annotation property that provides version information for an ontology or another OWL construct.
    let versionInfo = prefix "versionInfo"


    /// The property that determines the collection of facet-value pairs that define a datatype restriction.
    let withRestrictions = prefix "withRestrictions"



module owl_time =

    let prefix = prefix_label "owl_time"


    /// Description of date and time structured with separate values for the various elements of a calendar-clock system. The temporal reference system is fixed to Gregorian Calendar, and the range of year, month, day properties restricted to corresponding XML Schema types xsd:gYear, xsd:gMonth and xsd:gDay, respectively.
    let DateTimeDescription = prefix "DateTimeDescription"


    /// DateTimeInterval is a subclass of ProperInterval, defined using the multi-element DateTimeDescription.
    let DateTimeInterval = prefix "DateTimeInterval"


    /// The day of week
    let DayOfWeek = prefix "DayOfWeek"


    /// Duration of a temporal extent expressed as a number scaled by a temporal unit
    let Duration = prefix "Duration"


    /// Description of temporal extent structured with separate values for the various elements of a calendar-clock system. The temporal reference system is fixed to Gregorian Calendar, and the range of each of the numeric properties is restricted to xsd:decimal
    let DurationDescription = prefix "DurationDescription"



    let Friday = prefix "Friday"


    /// Description of date and time structured with separate values for the various elements of a calendar-clock system
    let GeneralDateTimeDescription = prefix "GeneralDateTimeDescription"


    /// Description of temporal extent structured with separate values for the various elements of a calendar-clock system.
    let GeneralDurationDescription = prefix "GeneralDurationDescription"


    /// A temporal entity with zero extent or duration
    let Instant = prefix "Instant"


    /// A temporal entity with an extent or duration
    let Interval = prefix "Interval"



    let January = prefix "January"



    let Monday = prefix "Monday"


    /// The month of the year
    let MonthOfYear = prefix "MonthOfYear"


    /// A temporal entity with non-zero extent or duration, i.e. for which the value of the beginning and end are different
    let ProperInterval = prefix "ProperInterval"



    let Saturday = prefix "Saturday"



    let Sunday = prefix "Sunday"


    /// A temporal reference system, such as a temporal coordinate system (with an origin, direction, and scale), a calendar-clock combination, or a (possibly hierarchical) ordinal system.
    ///
    /// This is a stub class, representing the set of all temporal reference systems.
    let TRS = prefix "TRS"


    /// Time extent; duration of a time interval separate from its particular start position
    let TemporalDuration = prefix "TemporalDuration"


    /// A temporal interval or instant.
    let TemporalEntity = prefix "TemporalEntity"


    /// A position on a time-line
    let TemporalPosition = prefix "TemporalPosition"


    /// A standard duration, which provides a scale factor for a time extent, or the granularity or precision for a time position.
    let TemporalUnit = prefix "TemporalUnit"



    let Thursday = prefix "Thursday"


    /// A temporal position described using either a (nominal) value from an ordinal reference system, or a (numeric) value in a temporal coordinate system.
    let TimePosition = prefix "TimePosition"


    /// A Time Zone specifies the amount by which the local time is offset from UTC.
    /// 	A time zone is usually denoted geographically (e.g. Australian Eastern Daylight Time), with a constant value in a given region.
    /// The region where it applies and the offset from UTC are specified by a locally recognised governing authority.
    let TimeZone = prefix "TimeZone"



    let Tuesday = prefix "Tuesday"



    let Wednesday = prefix "Wednesday"


    /// Year duration
    let Year = prefix "Year"


    /// Gives directionality to time. If a temporal entity T1 is after another temporal entity T2, then the beginning of T1 is after the end of T2.
    let after = prefix "after"


    /// Gives directionality to time. If a temporal entity T1 is before another temporal entity T2, then the end of T1 is before the beginning of T2. Thus, "before" can be considered to be basic to instants and derived for intervals.
    let before = prefix "before"


    /// Day position in a calendar-clock system.
    ///
    /// The range of this property is not specified, so can be replaced by any specific representation of a calendar day from any calendar.
    let day = prefix "day"


    /// The day of week, whose value is a member of the class time:DayOfWeek
    let dayOfWeek = prefix "dayOfWeek"


    /// The number of the day within the year
    let dayOfYear = prefix "dayOfYear"


    /// length of, or element of the length of, a temporal extent expressed in days
    let days = prefix "days"


    /// Day of month - formulated as a text string with a pattern constraint to reproduce the same lexical form as gDay, except that values up to 99 are permitted, in order to support calendars with more than 31 days in a month.
    /// Note that the value-space is not defined, so a generic OWL2 processor cannot compute ordering relationships of values of this type.
    let generalDay = prefix "generalDay"


    /// Month of year - formulated as a text string with a pattern constraint to reproduce the same lexical form as gMonth, except that values up to 20 are permitted, in order to support calendars with more than 12 months in the year.
    /// Note that the value-space is not defined, so a generic OWL2 processor cannot compute ordering relationships of values of this type.
    let generalMonth = prefix "generalMonth"


    /// Year number - formulated as a text string with a pattern constraint to reproduce the same lexical form as gYear, but not restricted to values from the Gregorian calendar.
    /// Note that the value-space is not defined, so a generic OWL2 processor cannot compute ordering relationships of values of this type.
    let generalYear = prefix "generalYear"


    /// Beginning of a temporal entity
    let hasBeginning = prefix "hasBeginning"


    /// Value of DateTimeInterval expressed as a structured value. The beginning and end of the interval coincide with the limits of the shortest element in the description.
    let hasDateTimeDescription = prefix "hasDateTimeDescription"


    /// Duration of a temporal entity, expressed as a scaled value or nominal value
    let hasDuration = prefix "hasDuration"


    /// Duration of a temporal entity, expressed using a structured description
    let hasDurationDescription = prefix "hasDurationDescription"


    /// End of a temporal entity.
    let hasEnd = prefix "hasEnd"


    /// The temporal reference system used by a temporal position or extent description.
    let hasTRS = prefix "hasTRS"


    /// Duration of a temporal entity.
    let hasTemporalDuration = prefix "hasTemporalDuration"


    /// Supports the association of a temporal entity (instant or interval) to any thing
    let hasTime = prefix "hasTime"


    /// Extent of a temporal entity, expressed using xsd:duration
    let hasXSDDuration = prefix "hasXSDDuration"


    /// Hour position in a calendar-clock system.
    let hour = prefix "hour"


    /// length of, or element of the length of, a temporal extent expressed in hours
    let hours = prefix "hours"


    /// Position of an instant, expressed using a structured description
    let inDateTime = prefix "inDateTime"


    /// Position of a time instant
    let inTemporalPosition = prefix "inTemporalPosition"


    /// Position of an instant, expressed as a temporal coordinate or nominal value
    let inTimePosition = prefix "inTimePosition"


    /// Position of an instant, expressed using xsd:date
    let inXSDDate = prefix "inXSDDate"


    /// Position of an instant, expressed using xsd:dateTime
    let inXSDDateTime = prefix "inXSDDateTime"


    /// Position of an instant, expressed using xsd:dateTimeStamp
    let inXSDDateTimeStamp = prefix "inXSDDateTimeStamp"


    /// Position of an instant, expressed using xsd:gYear
    let inXSDgYear = prefix "inXSDgYear"


    /// Position of an instant, expressed using xsd:gYearMonth
    let inXSDgYearMonth = prefix "inXSDgYearMonth"


    /// An instant that falls inside the interval. It is not intended to include beginnings and ends of intervals.
    let inside = prefix "inside"


    /// If a proper interval T1 is intervalAfter another proper interval T2, then the beginning of T1 is after the end of T2.
    let intervalAfter = prefix "intervalAfter"


    /// If a proper interval T1 is intervalBefore another proper interval T2, then the end of T1 is before the beginning of T2.
    let intervalBefore = prefix "intervalBefore"


    /// If a proper interval T1 is intervalContains another proper interval T2, then the beginning of T1 is before the beginning of T2, and the end of T1 is after the end of T2.
    let intervalContains = prefix "intervalContains"


    /// If a proper interval T1 is intervalDisjoint another proper interval T2, then the beginning of T1 is after the end of T2, or the end of T1 is before the beginning of T2, i.e. the intervals do not overlap in any way, but their ordering relationship is not known.
    let intervalDisjoint = prefix "intervalDisjoint"


    /// If a proper interval T1 is intervalDuring another proper interval T2, then the beginning of T1 is after the beginning of T2, and the end of T1 is before the end of T2.
    let intervalDuring = prefix "intervalDuring"


    /// If a proper interval T1 is intervalEquals another proper interval T2, then the beginning of T1 is coincident with the beginning of T2, and the end of T1 is coincident with the end of T2.
    let intervalEquals = prefix "intervalEquals"


    /// If a proper interval T1 is intervalFinishedBy another proper interval T2, then the beginning of T1 is before the beginning of T2, and the end of T1 is coincident with the end of T2.
    let intervalFinishedBy = prefix "intervalFinishedBy"


    /// If a proper interval T1 is intervalFinishes another proper interval T2, then the beginning of T1 is after the beginning of T2, and the end of T1 is coincident with the end of T2.
    let intervalFinishes = prefix "intervalFinishes"


    /// If a proper interval T1 is intervalIn another proper interval T2, then the beginning of T1 is after the beginning of T2 or is coincident with the beginning of T2, and the end of T1 is before the end of T2, or is coincident with the end of T2, except that end of T1 may not be coincident with the end of T2 if the beginning of T1 is coincident with the beginning of T2.
    let intervalIn = prefix "intervalIn"


    /// If a proper interval T1 is intervalMeets another proper interval T2, then the end of T1 is coincident with the beginning of T2.
    let intervalMeets = prefix "intervalMeets"


    /// If a proper interval T1 is intervalMetBy another proper interval T2, then the beginning of T1 is coincident with the end of T2.
    let intervalMetBy = prefix "intervalMetBy"


    /// If a proper interval T1 is intervalOverlappedBy another proper interval T2, then the beginning of T1 is after the beginning of T2, the beginning of T1 is before the end of T2, and the end of T1 is after the end of T2.
    let intervalOverlappedBy = prefix "intervalOverlappedBy"


    /// If a proper interval T1 is intervalOverlaps another proper interval T2, then the beginning of T1 is before the beginning of T2, the end of T1 is after the beginning of T2, and the end of T1 is before the end of T2.
    let intervalOverlaps = prefix "intervalOverlaps"


    /// If a proper interval T1 is intervalStarted another proper interval T2, then the beginning of T1 is coincident with the beginning of T2, and the end of T1 is after the end of T2.
    let intervalStartedBy = prefix "intervalStartedBy"


    /// If a proper interval T1 is intervalStarts another proper interval T2, then the beginning of T1 is coincident with the beginning of T2, and the end of T1 is before the end of T2.
    let intervalStarts = prefix "intervalStarts"


    /// Minute position in a calendar-clock system.
    let minute = prefix "minute"


    /// length, or element of, a temporal extent expressed in minutes
    let minutes = prefix "minutes"


    /// Month position in a calendar-clock system.
    ///
    /// The range of this property is not specified, so can be replaced by any specific representation of a calendar month from any calendar.
    let month = prefix "month"


    /// The month of the year, whose value is a member of the class time:MonthOfYear
    let monthOfYear = prefix "monthOfYear"


    /// length of, or element of the length of, a temporal extent expressed in months
    let months = prefix "months"


    /// The (nominal) value indicating temporal position in an ordinal reference system
    let nominalPosition = prefix "nominalPosition"


    /// Value of a temporal extent expressed as a decimal number scaled by a temporal unit
    let numericDuration = prefix "numericDuration"


    /// The (numeric) value indicating position within a temporal coordinate system
    let numericPosition = prefix "numericPosition"


    /// Second position in a calendar-clock system.
    let second = prefix "second"


    /// length of, or element of the length of, a temporal extent expressed in seconds
    let seconds = prefix "seconds"


    /// The time zone for clock elements in the temporal position
    let timeZone = prefix "timeZone"



    let unitDay = prefix "unitDay"



    let unitHour = prefix "unitHour"



    let unitMinute = prefix "unitMinute"



    let unitMonth = prefix "unitMonth"



    let unitSecond = prefix "unitSecond"


    /// The temporal unit which provides the precision of a date-time value or scale of a temporal extent
    let unitType = prefix "unitType"



    let unitWeek = prefix "unitWeek"



    let unitYear = prefix "unitYear"


    /// Week number within the year.
    let week = prefix "week"


    /// length of, or element of the length of, a temporal extent expressed in weeks
    let weeks = prefix "weeks"


    /// Value of DateTimeInterval expressed as a compact value.
    let xsdDateTime = prefix "xsdDateTime"


    /// Year position in a calendar-clock system.
    ///
    /// The range of this property is not specified, so can be replaced by any specific representation of a calendar year from any calendar.
    let year = prefix "year"


    /// length of, or element of the length of, a temporal extent expressed in years
    let years = prefix "years"

module xsi =
    let prefix = prefix_label "xsi"
    let nil = prefix "nil"
    let ``type`` = prefix "type"



module xdt =
    let prefix = prefix_label "xdt"
    /// The datatype xdt:untyped denotes the dynamic type of an element node that has not been validated, or has been validated in skip mode. No predefined types are derived from xdt:untyped.
    let untyped = prefix "untyped"
    /// The datatype xdt:untypedAtomic denotes untyped atomic data, such as text that has not been assigned a more specific type. An attribute that has been validated in skip mode is represented in the Data Model by an attribute node with the type xdt:untypedAtomic. No predefined types are derived from xdt:untypedAtomic.
    let untypedAtomic = prefix "untypedAtomic"
    /// The datatype xdt:anyAtomicType is an atomic type that includes all atomic values (and no values that are not atomic). Its base type is xs:anySimpleType from which all simple types, including atomic, list, and union types are derived. All primitive atomic types, such as xs:integer and xs:string, have xdt:anyAtomicType as their base type.
    let anyAtomicType = prefix "anyAtomicType"
    /// The type xdt:dayTimeDuration is derived from xs:duration by restricting its lexical representation to contain only the days, hours, minutes and seconds components. The value space of xdt:dayTimeDuration is the set of fractional second values. The components of xdt:dayTimeDuration correspond to the day, hour, minute and second components defined in Section 5.5.3.2 of ISO 8601, , respectively. xdt:dayTimeDuration is derived from xs:duration as follows:
    let dayTimeDuration = prefix "dayTimeDuration"

    /// The type xdt:yearMonthDuration is derived from xs:duration by restricting its lexical representation to contain only the year and month components. The value space of xdt:yearMonthDuration is the set of xs:integer month values. The year and month components of xdt:yearMonthDuration correspond to the Gregorian year and month components defined in section 5.5.3.2 of ISO 8601, respectively.
    let yearMonthDuration = prefix "yearMonthDuration"

module xsd =
    let prefix = prefix_label "xsd"
    let anyURI = prefix "anyURI"
    let anyAtomicType = prefix "anyAtomicType"
    let anySimpleType = prefix "anySimpleType"
    let base64Binary = prefix "base64Binary"
    let boolean = prefix "boolean"
    let byte = prefix "byte"
    let date = prefix "date"
    let dateTime = prefix "dateTime"
    let dateTimeStamp = prefix "dateTimeStamp"
    let dayTimeDuration = prefix "dayTimeDuration"
    let decimal = prefix "decimal"
    let double = prefix "double"
    let duration = prefix "duration"
    let ENTITIES = prefix "ENTITIES"
    let ENTITY = prefix "ENTITY"
    let float = prefix "float"
    let gDay = prefix "gDay"
    let gMonth = prefix "gMonth"
    let gMonthDay = prefix "gMonthDay"
    let gYear = prefix "gYear"
    let gYearMonth = prefix "gYearMonth"
    let hexBinary = prefix "hexBinary"
    let ID = prefix "ID"
    let IDREF = prefix "IDREF"
    let IDREFS = prefix "IDREFS"
    let int = prefix "int"
    let integer = prefix "integer"
    let language = prefix "language"
    let long = prefix "long"
    let Name = prefix "Name"
    let NCName = prefix "NCName"
    let negativeInteger = prefix "negativeInteger"
    let NMTOKEN = prefix "NMTOKEN"
    let NMTOKENS = prefix "NMTOKENS"
    let nonNegativeInteger = prefix "nonNegativeInteger"
    let nonPositiveInteger = prefix "nonPositiveInteger"
    let normalizedString = prefix "normalizedString"
    let NOTATION = prefix "NOTATION"
    let positiveInteger = prefix "positiveInteger"
    let precisionDecimal = prefix "precisionDecimal"
    let QName = prefix "QName"
    let short = prefix "short"
    let string = prefix "string"
    let time = prefix "time"
    let token = prefix "token"
    let unsignedByte = prefix "unsignedByte"
    let unsignedInt = prefix "unsignedInt"
    let unsignedLong = prefix "unsignedLong"
    let unsignedShort = prefix "unsignedShort"
    let yearMonthDuration = prefix "yearMonthDuration"







type Language_Tag = private LanguageTag of Lexical_Form

type Language_Tag with
    static member en =
        Database.Get.Lexical_Forms_from_Strings [| "en" |]
        |> Array.head
        |> LanguageTag

type Region_Subtag = private RegionSubtag of Lexical_Form

type Region_Subtag with
    static member US =
        Database.Get.Lexical_Forms_from_Strings [| "US" |]
        |> Array.head
        |> RegionSubtag

type Base_Direction = private BaseDirection of Lexical_Form

type Base_Direction with
    static member ltr =
        Database.Get.Lexical_Forms_from_Strings [| "ltr" |]
        |> Array.head
        |> BaseDirection

    static member rtl =
        Database.Get.Lexical_Forms_from_Strings [| "rtl" |]
        |> Array.head
        |> BaseDirection

module RDF_Literal =

    let from_lexical_forms_as_simple (lexical_forms: Lexical_Form array) =
        lexical_forms
        |> Array.map (fun lexical_form -> SimpleLiteral lexical_form.form_id.to_encoding)

    let from_lexical_forms_as_language (LanguageTag language_tag) (lexical_forms: Lexical_Form array) =
        lexical_forms
        |> Array.map (fun lexical_form ->
            LanguageString(lexical_form.form_id.to_encoding, language_tag.form_id.to_encoding))

    let from_lexical_forms_as_region
        (LanguageTag language_tag)
        (RegionSubtag region_subtag)
        (lexical_forms: Lexical_Form array)
        =
        lexical_forms
        |> Array.map (fun lexical_form ->
            LanguageRegionString(
                lexical_form.form_id.to_encoding,
                language_tag.form_id.to_encoding,
                region_subtag.form_id.to_encoding
            ))

    let from_lexical_forms_as_language_with_direction
        (LanguageTag language_tag)
        (BaseDirection direction)
        (lexical_forms: Lexical_Form array)
        =
        lexical_forms
        |> Array.map (fun lexical_form ->
            DirectedLanguageString(
                lexical_form.form_id.to_encoding,
                language_tag.form_id.to_encoding,
                direction.form_id.to_encoding
            ))

    let from_lexical_forms_as_region_with_direction
        (LanguageTag language_tag)
        (RegionSubtag region_subtag)
        (BaseDirection direction)
        (lexical_forms: Lexical_Form array)
        =
        lexical_forms
        |> Array.map (fun lexical_form ->
            DirectedLanguageRegionString(
                lexical_form.form_id.to_encoding,
                language_tag.form_id.to_encoding,
                region_subtag.form_id.to_encoding,
                direction.form_id.to_encoding
            ))

    let from_lexical_forms_as_type (ResolvedIRI datatype_id) (lexical_forms: Lexical_Form array) =
        lexical_forms
        |> Array.map (fun lexical_form -> DatatypedLiteral(lexical_form.form_id.to_encoding, datatype_id))

    let simple (raw_string: string) =
        Database.Get.Lexical_Forms_from_Strings [| raw_string |]
        |> from_lexical_forms_as_simple
        |> Database.Get.RDF_Terms_From_RDF_Term_Data
        |> Array.filter (fun term -> term.rdf_term_data.IsSimpleLiteral)
        |> Array.find (fun term -> RDF_Term.to_string term = raw_string)


    let language (raw_string: string) (language_tag: Language_Tag) =

        Database.Get.Lexical_Forms_from_Strings [| raw_string |]
        |> from_lexical_forms_as_language language_tag
        |> Database.Get.RDF_Terms_From_RDF_Term_Data
        |> Array.filter (fun term -> term.rdf_term_data.IsLanguageString)
        |> Array.find (fun term -> RDF_Term.to_string term = raw_string)

    let english (raw_string: string) = language raw_string Language_Tag.en

    let region (raw_string: string) (language_tag: Language_Tag) (region_subtag: Region_Subtag) =

        Database.Get.Lexical_Forms_from_Strings [| raw_string |]
        |> from_lexical_forms_as_region language_tag region_subtag
        |> Database.Get.RDF_Terms_From_RDF_Term_Data
        |> Array.filter (fun term -> term.rdf_term_data.IsLanguageRegionString)
        |> Array.find (fun term -> RDF_Term.to_string term = raw_string)

    let america (raw_string: string) =
        region raw_string Language_Tag.en Region_Subtag.US

    let directed (raw_string: string) (language_tag: Language_Tag) (direction: Base_Direction) =

        Database.Get.Lexical_Forms_from_Strings [| raw_string |]
        |> from_lexical_forms_as_language_with_direction language_tag direction
        |> Database.Get.RDF_Terms_From_RDF_Term_Data
        |> Array.filter (fun term -> term.rdf_term_data.IsDirectedLanguageString)
        |> Array.find (fun term -> RDF_Term.to_string term = raw_string)

    let directed_region
        (raw_string: string)
        (language_tag: Language_Tag)
        (region_subtag: Region_Subtag)
        (direction: Base_Direction)
        =

        Database.Get.Lexical_Forms_from_Strings [| raw_string |]
        |> from_lexical_forms_as_region_with_direction language_tag region_subtag direction
        |> Database.Get.RDF_Terms_From_RDF_Term_Data
        |> Array.filter (fun term -> term.rdf_term_data.IsDirectedLanguageString)
        |> Array.find (fun term -> RDF_Term.to_string term = raw_string)

    let datatyped (raw_string: string) (datatype_iri: RDF_Term) =

        Database.Get.Lexical_Forms_from_Strings [| raw_string |]
        |> from_lexical_forms_as_type datatype_iri.rdf_term_data
        |> Database.Get.RDF_Terms_From_RDF_Term_Data
        |> Array.filter (fun term -> term.rdf_term_data.IsDatatypedLiteral)
        |> Array.find (fun term -> RDF_Term.to_string term = raw_string)

    let autotyped<'ValueType> (value: 'ValueType) =
        let value_string, datatype_iri =
            let invariant_string =
                if box value = null then
                    String.Empty
                else
                    Convert.ToString(value, CultureInfo.InvariantCulture)

            match box value with
            | :? Boolean as value -> (if value then "true" else "false"), xsd.boolean
            | :? (Byte array) as value -> Convert.ToBase64String(value), xsd.base64Binary
            | :? Byte as value -> invariant_string, xsd.unsignedByte
            | :? DateOnly as value -> value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture), xsd.date
            | :? DateTime as value -> value.ToString("o", CultureInfo.InvariantCulture), xsd.dateTime
            | :? DateTimeOffset as value -> value.ToString("o", CultureInfo.InvariantCulture), xsd.dateTimeStamp
            | :? Decimal as value -> invariant_string, xsd.decimal
            | :? Double as value -> value.ToString("R", CultureInfo.InvariantCulture), xsd.double
            | :? Int16 as value -> invariant_string, xsd.short
            | :? Int32 as value -> invariant_string, xsd.int
            | :? Int64 as value -> invariant_string, xsd.long
            | :? SByte as value -> invariant_string, xsd.byte
            | :? Single as value -> value.ToString("R", CultureInfo.InvariantCulture), xsd.float
            | :? TimeOnly as value -> value.ToString("HH:mm:ss.fffffff", CultureInfo.InvariantCulture), xsd.time
            | :? TimeSpan as value -> Xml.XmlConvert.ToString(value), xsd.duration
            | :? UInt16 as value -> invariant_string, xsd.unsignedShort
            | :? UInt32 as value -> invariant_string, xsd.unsignedInt
            | :? UInt64 as value -> invariant_string, xsd.unsignedLong
            | :? Uri as value -> value.AbsoluteUri, xsd.anyURI
            | :? XmlQualifiedName as value -> value.ToString(), xsd.QName
            | null -> "true", xsi.nil
            | value when value.GetType() = typeof<Object> -> invariant_string, xdt.anyAtomicType
            | value -> invariant_string, xsd.string

        datatyped value_string datatype_iri

    module Binary =

        let base64 (bytes: Byte array) =
            let value_string = Convert.ToBase64String(bytes)

            datatyped value_string xsd.base64Binary

        let hex (bytes: Byte array) =
            let value_string = Convert.ToHexString(bytes)

            datatyped value_string xsd.hexBinary

    module Temporal =
        module duration =
            let timeDuration (timespan: TimeSpan) =
                let value_string = Xml.XmlConvert.ToString(timespan)

                datatyped value_string xsd.duration

            let dayTimeDuration (timespan: TimeSpan) =
                let value_string = Xml.XmlConvert.ToString(timespan)

                datatyped value_string xdt.dayTimeDuration


            let yearMonthDuration (years: int) (months: int) =
                let total_months = years * 12 + months

                let value_string =
                    if total_months = 0 then
                        "P0M"
                    else
                        let absolute_months = abs total_months
                        let years_part = absolute_months / 12
                        let months_part = absolute_months % 12
                        let sign = if total_months < 0 then "-" else ""

                        let year_text =
                            if years_part = 0 then
                                ""
                            else
                                $"{years_part}Y"

                        let month_text =
                            if months_part = 0 then
                                ""
                            else
                                $"{months_part}M"

                        $"{sign}P{year_text}{month_text}"

                datatyped value_string xdt.yearMonthDuration

        module date =

            let only (date: DateOnly) =
                let value_string = date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)

                datatyped value_string xsd.date

            let from_datetime (datetime: DateTime) =
                let value_string = datetime.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)

                datatyped value_string xsd.date

            let time (datetime: DateTime) =
                let value_string = datetime.ToString("o", CultureInfo.InvariantCulture)

                datatyped value_string xsd.dateTime

            let timeStamp (datetime_offset: DateTimeOffset) =
                let value_string = datetime_offset.ToString("o", CultureInfo.InvariantCulture)

                datatyped value_string xsd.dateTimeStamp

        module time =

            let only (time: TimeOnly) =
                let value_string = time.ToString("HH:mm:ss.fffffff", CultureInfo.InvariantCulture)

                datatyped value_string xsd.time

            let from_datetime (datetime: DateTime) =
                let value_string =
                    datetime.ToString("HH:mm:ss.fffffff", CultureInfo.InvariantCulture)

                datatyped value_string xsd.time

        module period =

            let day (datetime: DateTime) =
                let value_string =
                    $"""---{datetime.Day.ToString("00", CultureInfo.InvariantCulture)}"""

                datatyped value_string xsd.gDay


            let month (datetime: DateTime) =
                let value_string =
                    $"""--{datetime.Month.ToString("00", CultureInfo.InvariantCulture)}"""

                datatyped value_string xsd.gMonth


            let monthDay (datetime: DateTime) =
                let value_string =
                    $"""--{datetime.Month.ToString("00", CultureInfo.InvariantCulture)}-{datetime.Day.ToString("00", CultureInfo.InvariantCulture)}"""

                datatyped value_string xsd.gMonthDay


            let year (datetime: DateTime) =
                let value_string = datetime.Year.ToString("0000", CultureInfo.InvariantCulture)

                datatyped value_string xsd.gYear


            let yearMonth (datetime: DateTime) =
                let value_string =
                    $"""{datetime.Year.ToString("0000", CultureInfo.InvariantCulture)}-{datetime.Month.ToString("00", CultureInfo.InvariantCulture)}"""

                datatyped value_string xsd.gYearMonth

            let generalDay (day: int) =
                test <@ day >= 1 && day <= 99 @>
                let value_string = $"""---{day.ToString("00", CultureInfo.InvariantCulture)}"""

                datatyped value_string owl_time.generalDay


            let generalMonth (month: int) =
                test <@ month >= 1 && month <= 20 @>
                let value_string = $"""--{month.ToString("00", CultureInfo.InvariantCulture)}"""

                datatyped value_string owl_time.generalMonth


            let generalYear (year: int) =
                let value_string = year.ToString("0000", CultureInfo.InvariantCulture)

                datatyped value_string owl_time.generalYear


    module Numeric =

        let private bigint_value_string (value: bigint) =
            value.ToString(CultureInfo.InvariantCulture)

        let integer (value: bigint) =
            datatyped (bigint_value_string value) xsd.integer

        let negativeInteger (value: bigint) =
            test <@ value < 0I @>
            datatyped (bigint_value_string value) xsd.negativeInteger

        let nonNegativeInteger (value: bigint) =
            test <@ value >= 0I @>
            datatyped (bigint_value_string value) xsd.nonNegativeInteger

        let nonPositiveInteger (value: bigint) =
            test <@ value <= 0I @>
            datatyped (bigint_value_string value) xsd.nonPositiveInteger

        let positiveInteger (value: bigint) =
            test <@ value > 0I @>
            datatyped (bigint_value_string value) xsd.positiveInteger

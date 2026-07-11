open System
open System.Xml
open System.Text
open System.IO
open System.Globalization

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

// #r "nuget: ObjectLayoutInspector"
// open ObjectLayoutInspector

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\ParserCombinator\Identifier\Resource\Internationalized\Internationalized_Resource_Identifier.fsx"

open StringExtensions

open Resource_Identifier
open XParsecErgonomics
open Unicode_Standard
open XParsec
open Internationalized_Resource_Identifier

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\LMDB\LMDB.fsx"
open LMDB

let personal_domain_base = "https://eristocrates.dev/ontology"

let endogenous =
    [|

       "", $"{personal_domain_base}/adhoc/"
       "unicode", $"{personal_domain_base}/unicode/"
       "vocabulary", $"{personal_domain_base}/vocabulary/"
       "mime_application", "https://w3id.org/uri4uri/mime/application/"
       "example", "http://www.example.org/"
       "rdfx", $"{personal_domain_base}/resource_description_framework/"
       "op", $"{personal_domain_base}/operator/" // "Functions defined with the op prefix are described here to underpin the definitions of the operators in [XML Path Language (XPath) 3.1], [XQuery 3.1: An XML Query Language] and [XSL Transformations (XSLT) Version 3.0]. These functions are not available directly to users, and there is no requirement that implementations should actually provide these functions. For this reason, no namespace is associated with the op prefix. For example, multiplication is generally associated with the * operator, but it is described as a function in this document:


       |]

let webpage_prefixes =
    [|

       "http", "http://www.w3.org/2011/http#"
       "http-headers", "http://www.w3.org/2011/http-headers#"
       "http-methods", "http://www.w3.org/2011/http-methods#"
       "http-statusCodes", "http://www.w3.org/2011/http-statusCodes#"
       "twitter", "https://x.com/"
       "twitterApi", "https://x.com/i/api#"
       "community", "https://x.com/i/communities/"
       "cdpNetwork", "https://chromedevtools.github.io/devtools-protocol/tot/Network/#"
       "cdpPage", "https://chromedevtools.github.io/devtools-protocol/tot/Page/#"
       "cdp", "http://chromedevtools.github.io/devtools-protocol#"
       "bcp47", "https://www.rfc-editor.org/info/bcp47#"

       |]


let exogenous =
    [|

       "dct", "http://purl.org/dc/terms/"
       "doap", "http://usefulinc.com/ns/doap#"
       "earl", "http://www.w3.org/ns/earl#"
       "foaf", "http://xmlns.com/foaf/0.1/"
       "jsonld", "http://www.w3.org/ns/json-ld#"
       "ptr", "http://www.w3.org/2009/pointers#"
       "sioc", "http://rdfs.org/sioc/ns#"
       "sioc_actions", "http://rdfs.org/sioc/actions#"
       "sioc_services", "http://rdfs.org/sioc/services#"
       "sioc_types", "http://rdfs.org/sioc/types#"
       "xdt", "https://www.w3.org/2003/05/xpath-datatypes#"
       "xqt_output", "https://www.w3.org/2010/xslt-xquery-serialization" // [Definition: the Output declaration namespace, ]; associated with output. There are no functions in this namespace: it is used for serialization parameters, as described in [XSLT and XQuery Serialization 3.1]
       "xhtml", "https://www.w3.org/1999/xhtml" // [Definition: the XHTML namespace namespace, ];
       "svg", "https://www.w3.org/2000/svg" // [Definition: the SVG namespace, ]; and
       "mathml", "https://www.w3.org/1998/Math/MathML" // [Definition: the MathML namespace namespace, ]
       "xs", "http://www.w3.org/2001/XMLSchema"
       "xfn", "http://www.w3.org/2005/xpath-functions" // for functions — associated with fn. The namespace prefix used in this document for most functions that are available to users is fn.
       "xfn_math", "http://www.w3.org/2005/xpath-functions/math" // for functions — associated with . This namespace is used for some mathematical functions. The namespace prefix used in this document for these functions is math. These functions are available to users in exactly the same way as those in the fn namespace.
       "xfn_map", "http://www.w3.org/2005/xpath-functions/map" // for functions — associated with . This namespace is used for some functions that manipulate maps (see 17.1 Functions that Operate on Maps). The namespace prefix used in this document for these functions is map. These functions are available to users in exactly the same way as those in the fn namespace.
       "xfn_array", "http://www.w3.org/2005/xpath-functions/array" // for functions — associated with . This namespace is used for some functions that manipulate maps (see 17.3 Functions that Operate on Arrays). The namespace prefix used in this document for these functions is array. These functions are available to users in exactly the same way as those in the fn namespace.
       "xqt_err", "http://www.w3.org/2005/xqt-errors" // — associated with . There are no functions in this namespace; it is used for error codes. This document uses the prefix err to represent the namespace URI http://www.w3.org/2005/xqt-errors, which is the namespace for all XPath and XQuery error codes and messages. This namespace prefix is not predeclared and its use in this document is not normative.
       "owl_time", "http://www.w3.org/2006/time#"
       "geol", "http://example.org/geologic/"
       "greg", "http://www.w3.org/ns/time/gregorian#"
       "prov", "http://www.w3.org/ns/prov#"
       "xsi", "http://www.w3.org/2001/XMLSchema-instance#"




       |]

let RDFa_Core_Initial_Context =
    [|



       "as", "https://www.w3.org/ns/activitystreams#" // "Activity Vocabulary","Activity Vocabulary","W3C Recommendation"
       "csvw", "http://www.w3.org/ns/csvw#" // "Metadata for Tabular Data","Metadata Vocabulary for Tabular Data","W3C Recommendation"
       "dcat", "http://www.w3.org/ns/dcat#" // "Data Catalog Vocabulary","Data Catalog Vocabulary (DCAT)","W3C Recommendation"
       "dqv", "http://www.w3.org/ns/dqv#" // "Data Quality Vocabulary","Data               on the Web Best Practices: Data Quality Vocabulary","W3C WG Note"
       "duv", "https://www.w3.org/ns/duv#" // "Dataset Usage Vocabulary","Dataset Usage Vocabulary","W3C WG Note"
       "grddl", "http://www.w3.org/2003/g/data-view#" // GRDDL,"Gleaning Resource Descriptions from Dialects of Languages (GRDDL)","W3C Recommendation"
       "jsonld", "http://www.w3.org/ns/json-ld#" // "JSON-LD","JSON-LD 1.1, A JSON-based Serialization for Linked Data","W3C Recommendation"
       "ldp", "http://www.w3.org/ns/ldp#" // "Linked Data Platform Vocabulary","Linked Data Platform 1.0","W3C Recommendation"
       "ma", "http://www.w3.org/ns/ma-ont#" // "Ontology for Media Resources","Ontology for Media Resources 1.0","W3C Recommendation"
       "oa", "http://www.w3.org/ns/oa#" // "Web Annotation Vocabulary","Web Annotation Vocabulary","W3C Recommendation"
       "odrl", "http://www.w3.org/ns/odrl/2/" // "ODRL Vocabulary & Expression 2.2","ODRL Vocabulary & Expression 2.2","W3C Recommendation"
       "org", "http://www.w3.org/ns/org#" // Organizations,"The Organization Ontology","W3C Recommendation"
       "owl", "http://www.w3.org/2002/07/owl#" // OWL,"OWL Overview","W3C Recommendation"
       "prov", "http://www.w3.org/ns/prov#" // "Provenance Vocabulary","Provenance Ontology","W3C Recommendation"
       "qb", "http://purl.org/linked-data/cube#" // "Data Cubes","The RDF Data Cube Vocabulary","W3C Recommendation"
       "rdf", "http://www.w3.org/1999/02/22-rdf-syntax-ns#" // RDF,"RDF Semantics","W3C Recommendation"
       "rdfa", "http://www.w3.org/ns/rdfa#" // "RDFa Vocabulary","RDFa Core 1.1","W3C Recommendation"
       "rdfs", "http://www.w3.org/2000/01/rdf-schema#" // "RDF Schema","RDF Semantics","W3C Recommendation"
       "rif", "http://www.w3.org/2007/rif#" // RIF,"RIF Overview","W3C Recommendation"
       "rr", "http://www.w3.org/ns/r2rml#" // R2RML,"R2RML: RDB to RDF Mapping Language","W3C Recommendation"
       "sd", "http://www.w3.org/ns/sparql-service-description#" // "SPARQL 1.1 Service Description","SPARQL 1.1 Service Description","W3C Recommendation"
       "skos", "http://www.w3.org/2004/02/skos/core#" // "SKOS Core","SKOS Simple Knowledge Organization System Reference","W3C Recommendation"
       "skosxl", "http://www.w3.org/2008/05/skos-xl#" // "SKOS eXtension for Labels","SKOS Simple Knowledge Organization System Reference","W3C Recommendation"
       "sosa", "http://www.w3.org/ns/sosa/" // "Sensor, Observation, Sample, and Actuator Ontology","Semantic Sensor Network Ontology","W3C Recommendation"
       "ssn", "http://www.w3.org/ns/ssn/" // "Semantic Sensor Network Ontology","Semantic Sensor Network Ontology","W3C Recommendation"
       "time", "http://www.w3.org/2006/time#" // "Time Ontology","Time Ontology in OWL","W3C Recommendation"
       "void", "http://rdfs.org/ns/void#" // VoID,"Describing Linked Datasets with the VoID Vocabulary","W3C Interest Group Note"
       "wdr", "http://www.w3.org/2007/05/powder#" // POWDER,"Protocol for Web Description Resources (POWDER): Formal Semantics","W3C Recommendation"
       "wdrs", "http://www.w3.org/2007/05/powder-s#" // "POWDER-S","Protocol for Web Description Resources (POWDER): Formal Semantics","W3C Recommendation"
       "xhv", "http://www.w3.org/1999/xhtml/vocab#" // "RDFa Default Prefix","RDFa Core 1.1","W3C Recommendation"
       "xml", "http://www.w3.org/XML/1998/namespace" // "XML Reserved Prefix","Namespaces in XML 1.0","W3C Recommendation"
       "xsd", "http://www.w3.org/2001/XMLSchema#" // "XML Schema Datatypes","XML Schema Part 2: Datatypes Second Edition","W3C Recommendation"


       |]

let prefix_map =
    Map.ofArray
    <| Array.concat [|

                       RDFa_Core_Initial_Context
                       endogenous
                       webpage_prefixes
                       exogenous

                        |]

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
        |> Database.Get.Transient_Terms_From_Persistent_Terms
        |> Array.filter (fun term -> term.persistent_term.IsResolvedIRI)
        |> Array.find (fun term -> Transient_Term.to_string term = raw_string)






module Relative_IRI =

    let from_lexical_forms (lexical_forms: Lexical_Form array) =
        lexical_forms
        |> Array.map (fun lexical_form -> RelativeIRI lexical_form.form_id.to_encoding)

    let from_trusted_string (raw_string: string) =
        Database.Get.Lexical_Forms_from_Strings [| raw_string |]
        |> from_lexical_forms
        |> Database.Get.Transient_Terms_From_Persistent_Terms
        |> Array.filter (fun term -> term.persistent_term.IsRelativeIRI)
        |> Array.find (fun term -> Transient_Term.to_string term = raw_string)

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
        Resolved_IRI.from_trusted_string $"{Transient_Term.to_string this.prefix.namespace_name}{this.reference}"

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

    Resolved_IRI.from_trusted_string $"{Transient_Term.to_string prefix.namespace_name}{local_name}"





















module rdf =
    let prefix = prefix_label "rdf"

    /// 	rdfs:comment "The datatype of RDF literals storing fragments of HTML content" .
    let HTML = prefix "HTML"
    /// 	rdfs:comment "The datatype of language-tagged string values" .
    let langString = prefix "langString"
    let dirLangString = prefix "dirLangString"
    /// 	rdfs:comment "The class of plain (i.e. untyped) literal values, as used in RIF and OWL 2" .
    let PlainLiteral = prefix "PlainLiteral"
    /// 	rdfs:comment "The subject is an instance of a class." ;
    let ``type`` = prefix "type"
    /// 	rdfs:comment "The class of RDF properties." ;
    let Property = prefix "Property"
    /// 	rdfs:comment "The class of RDF statements." .
    let Statement = prefix "Statement"
    /// 	rdfs:comment "The subject of the subject RDF statement." ;
    let subject = prefix "subject"
    /// 	rdfs:comment "The predicate of the subject RDF statement." ;
    let predicate = prefix "predicate"
    /// 	rdfs:comment "The object of the subject RDF statement." ;
    let object = prefix "object"
    /// 	rdfs:comment "The class of unordered containers." ;
    let Bag = prefix "Bag"
    /// 	rdfs:comment "The class of ordered containers." ;
    let Seq = prefix "Seq"
    /// 	rdfs:comment "The class of containers of alternatives." ;
    let Alt = prefix "Alt"
    /// 	rdfs:comment "Idiomatic property used for structured values." ;
    let value = prefix "value"
    /// 	rdfs:comment "The class of RDF Lists." ;
    let List = prefix "List"
    /// 	rdfs:comment "The empty list, with no items in it. If the rest of a list is nil then the list has no more items in it." .
    let nil = prefix "nil"
    /// 	rdfs:comment "The first item in the subject RDF list." ;
    let first = prefix "first"
    /// 	rdfs:comment "The rest of the subject RDF list after the first item." ;
    let rest = prefix "rest"
    /// 	rdfs:comment "The datatype of XML literal values." .
    let XMLLiteral = prefix "XMLLiteral"
    /// 	rdfs:comment "The datatype of RDF literals storing JSON content." ;
    let JSON = prefix "JSON"
    /// 	rdfs:comment "A class representing a compound literal." ;
    let CompoundLiteral = prefix "CompoundLiteral"
    /// 	rdfs:comment "The language component of a CompoundLiteral." ;
    let language = prefix "language"
    /// 	rdfs:comment "The base direction component of a CompoundLiteral." ;
    let direction = prefix "direction"

let a = rdf.``type``


module owl =
    module time =
        let prefix = prefix_label "owl_time"

        let generalDay = prefix "generalDay"

        let generalMonth = prefix "generalMonth"

        let generalYear = prefix "generalYear"

module xsi =
    let prefix = prefix_label "xsi"
    let nil = prefix "nil"


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




module unicode =

    let prefix = prefix_label "unicode"

    let Unicode_Character_Property = prefix "Unicode_Character_Property"
    let Unicode_Name_Alias = prefix "Unicode_Name_Alias"
    let name_alias = prefix "name_alias"
    let Name_Alias = prefix "Name_Alias"
    let alias_type = prefix "alias_type"
    let Code_Point = prefix "Code_Point"



module rdfx =
    let prefix = prefix_label "rdfx"
    let subject_of = prefix "subject_of"
    let predicate_of = prefix "predicate_of"
    let object_of = prefix "object_of"
    let context_of = prefix "context_of"
    let Resolved_IRI = prefix "Resolved_IRI"
    let RDF_Literal = prefix "RDF_Literal"
    let Blank_Node = prefix "Blank_Node"
    let Dollar_Variable = prefix "Dollar_Variable"
    let Question_Variable = prefix "Question_Variable"
    let Triple = prefix "Triple"
    let IRIREF = prefix "IRIREF"
    let Relative_IRI = prefix "Relative_IRI"
    let Skolem_IRI = prefix "Skolem_IRI"
    let RDF_String = prefix "RDF_String"
    let CURIE = prefix "CURIE"
    let RDF_Prefix = prefix "RDF_Prefix"
    let RDF_Variable = prefix "RDF_Variable"
    let RDF_Subject = prefix "RDF_Subject"
    let TTSubject = prefix "TTSubject"
    let RTSubject = prefix "RTSubject"
    let RDF_Predicate = prefix "RDF_Predicate"
    let RDF_Object = prefix "RDF_Object"
    let TTObject = prefix "TTObject"
    let RTObject = prefix "RTObject"
    let RDF_Collection = prefix "RDF_Collection"
    let RDF_Triple = prefix "RDF_Triple"
    let Triple_Term = prefix "Triple_Term"
    let Reified_Triple = prefix "Reified_Triple"
    let RDF_Quad = prefix "RDF_Quad"
    let RDF_Context = prefix "RDF_Context"
    let RDF_Formula = prefix "RDF_Formula"
    let Unnamed_Graph = prefix "Unnamed_Graph"
    let Named_Graph = prefix "Named_Graph"
    let RDF_Graph = prefix "RDF_Graph"
    let RDF_Dataset = prefix "RDF_Dataset"
    let Default_Context = prefix "Default_Context"

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
        |> Database.Get.Transient_Terms_From_Persistent_Terms
        |> Array.filter (fun term -> term.persistent_term.IsSimpleLiteral)
        |> Array.find (fun term -> Transient_Term.to_string term = raw_string)


    let language (raw_string: string) (language_tag: Language_Tag) =

        Database.Get.Lexical_Forms_from_Strings [| raw_string |]
        |> from_lexical_forms_as_language language_tag
        |> Database.Get.Transient_Terms_From_Persistent_Terms
        |> Array.filter (fun term -> term.persistent_term.IsLanguageString)
        |> Array.find (fun term -> Transient_Term.to_string term = raw_string)

    let english (raw_string: string) = language raw_string Language_Tag.en

    let region (raw_string: string) (language_tag: Language_Tag) (region_subtag: Region_Subtag) =

        Database.Get.Lexical_Forms_from_Strings [| raw_string |]
        |> from_lexical_forms_as_region language_tag region_subtag
        |> Database.Get.Transient_Terms_From_Persistent_Terms
        |> Array.filter (fun term -> term.persistent_term.IsLanguageRegionString)
        |> Array.find (fun term -> Transient_Term.to_string term = raw_string)

    let america (raw_string: string) =
        region raw_string Language_Tag.en Region_Subtag.US

    let directed (raw_string: string) (language_tag: Language_Tag) (direction: Base_Direction) =

        Database.Get.Lexical_Forms_from_Strings [| raw_string |]
        |> from_lexical_forms_as_language_with_direction language_tag direction
        |> Database.Get.Transient_Terms_From_Persistent_Terms
        |> Array.filter (fun term -> term.persistent_term.IsDirectedLanguageString)
        |> Array.find (fun term -> Transient_Term.to_string term = raw_string)

    let directed_region
        (raw_string: string)
        (language_tag: Language_Tag)
        (region_subtag: Region_Subtag)
        (direction: Base_Direction)
        =

        Database.Get.Lexical_Forms_from_Strings [| raw_string |]
        |> from_lexical_forms_as_region_with_direction language_tag region_subtag direction
        |> Database.Get.Transient_Terms_From_Persistent_Terms
        |> Array.filter (fun term -> term.persistent_term.IsDirectedLanguageString)
        |> Array.find (fun term -> Transient_Term.to_string term = raw_string)

    let datatyped (raw_string: string) (datatype_iri: Transient_Term) =

        Database.Get.Lexical_Forms_from_Strings [| raw_string |]
        |> from_lexical_forms_as_type datatype_iri.persistent_term
        |> Database.Get.Transient_Terms_From_Persistent_Terms
        |> Array.filter (fun term -> term.persistent_term.IsDatatypedLiteral)
        |> Array.find (fun term -> Transient_Term.to_string term = raw_string)

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

                datatyped value_string owl.time.generalDay


            let generalMonth (month: int) =
                test <@ month >= 1 && month <= 20 @>
                let value_string = $"""--{month.ToString("00", CultureInfo.InvariantCulture)}"""

                datatyped value_string owl.time.generalMonth


            let generalYear (year: int) =
                let value_string = year.ToString("0000", CultureInfo.InvariantCulture)

                datatyped value_string owl.time.generalYear


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

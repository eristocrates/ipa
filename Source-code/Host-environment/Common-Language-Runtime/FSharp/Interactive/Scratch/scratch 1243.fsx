open System
open System.Collections.Generic
open System.Globalization
open System.Text
open System.Diagnostics
open System.IO
open System.Linq
open System.Text
open System.Text.Json
open System.Xml
open System.Xml.Linq
open System.Xml.XPath

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\UnicodeStandard\PropertyAliases.fsx"
#r "nuget: FSharp.UMX"
#r "nuget: LightningDB"
#r "nuget: MessagePack"
#r "nuget: Unquote"
#r "nuget: XParsec"

open FSharp.UMX
open LightningDB
open MessagePack
open PropertyAliases
open Swensen.Unquote.Assertions

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\LMDB\LMDB.fsx"
open LMDB


#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\XmlErgonomics.fsx"

open XmlErgonomics

// open Unicode_Standard
// open StringExtensions
// Configure DB for duplicate keys


// open RdfErgonomics
// open Unicode_Standard
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\DiagnosticsErgonomics.fsx"
open DiagnosticsErgonomics







let context_iri = iri $"https://eristocrates.dev/ontology/unicode/"



















module ucd =

    [<Literal>]
    let file_path = @"D:\Surface\Standards\Unicode\UCD\17.0.0\ucdxml\ucd.all.flat.xml"

    let xml = XPathNavigator.Load(file_path)

let namespace_manager = new XmlNamespaceManager(ucd.xml.NameTable)

let ucd_namespace =
    ucd.xml
    |> XPathNavigator.xmlns namespace_manager "ucd" "http://www.unicode.org/ns/2003/ucd/1.0"




let xpath (expression: string) (xpath_navigator: XPathNavigator) =
    let xpath_expression = XPathExpression.Compile(expression)
    xpath_expression.SetContext(namespace_manager)

    xpath_navigator
        .Select(
            xpath_expression
        )
        .toElementArray

let char_elements =
    time_operation "char_elements" (fun () ->
        ucd.xml
        |> xpath $"//ucd:char"
        |> Array.Parallel.filter (fun char_element ->

            String.IsNullOrWhiteSpace(char_element.GetAttribute("first-cp", ""))

        )

    )

let char_attributes =
    time_operation "char_attributes" (fun () ->
        char_elements
        |> Array.Parallel.collect (fun element ->
            element.MoveToFirstAttribute() |> ignore
            element.Attributes

        )
        |> Array.Parallel.filter (fun char_attribute -> not (String.IsNullOrEmpty char_attribute.Value))

    )



let code_point_from_attribute (char_attribute: XPathNavigator) =
    let char_attribute_element = char_attribute.Parent
    let hexdigit_string = char_attribute_element.Attribute "cp"
    // test <@ hexdigit_string.Length > 0 @>
    hexdigit_string




let character_properties =

    time_operation "character_properties" (fun () ->
        char_attributes
        |> Array.Parallel.map (fun char_attribute ->
            let code_point = code_point_from_attribute char_attribute

            (code_point, char_attribute.LocalName, char_attribute.Value)

        ))










let name_aliases =
    time_operation "name_aliases" (fun () ->
        ucd.xml
        |> xpath $"//ucd:name-alias"
        |> Array.Parallel.map (fun name_alias_element ->

            let alias_attribute = name_alias_element.Attribute "alias"
            let type_attribute = name_alias_element.Attribute "type"
            let char_element_with_name_alias = name_alias_element.Parent
            let code_point = char_element_with_name_alias.Attribute "cp"
            (code_point, alias_attribute, type_attribute)

        )

    )


















































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




type RDF_String = { lexical_form: string }
type Resolved_IRI = private ResolvedIRI of RDF_String
type Relative_IRI = private RelativeIRI of RDF_String
type RDF_Prefix = private Prefix of RDF_String


type CURIE =
    { prefix: RDF_Prefix
      reference: Relative_IRI }

[<RequireQualifiedAccess>]
type Language_Direction =
    | ltr
    | rtl

type RDF_Literal =
    { lexical_form: string
      datatype: Resolved_IRI
      language_tag: string option
      region_subtag: string option
      base_direction: Language_Direction option }




type Resolved_IRI with



    static member from_trusted_string(raw_string: string) =
        { lexical_form = raw_string } |> ResolvedIRI

    static member from_iriref(iriref: string) =
        { lexical_form = iriref[1 .. iriref.Length - 2] }
        |> ResolvedIRI

    member this.representation =
        let (ResolvedIRI resolved_iri) = this
        $"<{resolved_iri.lexical_form}>"

    member this.lexical_form =
        let (ResolvedIRI resolved_iri) = this
        resolved_iri.lexical_form


type Relative_IRI with

    static member raw(raw_string: string) =
        { lexical_form = raw_string } |> RelativeIRI

    static member low_lined(raw_string: string) =
        { lexical_form = raw_string.Replace(" ", "_") }
        |> RelativeIRI

    member this.representation =
        let (RelativeIRI relative_iri) = this
        $"<{relative_iri.lexical_form}>"

    member this.resolve(ResolvedIRI namespace_name) =
        let (RelativeIRI local_name) = this
        Resolved_IRI.from_trusted_string $"{namespace_name.lexical_form}{local_name.lexical_form}"

    member this.lexical_form =
        let (RelativeIRI relative_iri) = this
        relative_iri.lexical_form



type RDF_Prefix with
    static member from_string(raw_string: string) = Prefix { lexical_form = raw_string }

    member this.representation =
        let (Prefix prefix) = this
        $"{prefix.lexical_form}:"

    member this.mapping =
        let (Prefix prefix) = this
        Resolved_IRI.from_trusted_string prefix_map[prefix.lexical_form]


type CURIE with

    member this.expand = this.reference.resolve this.prefix.mapping

    member this.representation = this.expand.representation
    member this.as_iri = this.expand

    static member from_prefix(prefix: RDF_Prefix) =
        {

          prefix = prefix
          reference = Relative_IRI.raw ""

        }


type RDF_Prefix with
    member this.compact = CURIE.from_prefix this






















let prefix_label (prefix_label: string) (raw_local_name: string) =

    {

      prefix = RDF_Prefix.from_string prefix_label
      reference = Relative_IRI.low_lined raw_local_name

    }



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















type RDF_Literal with


    member this.representation =
        match (this.lexical_form, this.datatype.lexical_form, this.language_tag, this.region_subtag, this.base_direction)
            with
        | (_, "http://www.w3.org/2001/XMLSchema#string", None, None, None) -> this.lexical_form
        | (_, _, None, None, None) when
            this.datatype.lexical_form
            <> "http://www.w3.org/2001/XMLSchema#string"
            ->
            $"\"{this.lexical_form}\"^^{this.datatype.representation}"
        | (_, "http://www.w3.org/1999/02/22-rdf-syntax-ns#langString", Some (language_tag), None, None) ->
            $"\"{this.lexical_form}\"@{language_tag}"
        | (_, "http://www.w3.org/1999/02/22-rdf-syntax-ns#dirLangString", Some (language_tag), None, Some (direction)) ->
            $"\"{this.lexical_form}\"@{language_tag}-{direction}"
        | (_, "http://www.w3.org/1999/02/22-rdf-syntax-ns#langString", Some (language_tag), Some (region_subtag), None) ->
            $"\"{this.lexical_form}\"@{language_tag}-{region_subtag}"
        | _ -> failwith $"Unmatched RDF_Literal representation:\n{this}"
    // $"{this.lexical_form}^^{this.datatype.representation.as_String}"


    static member simple(lexical_form: string) =
        {

          lexical_form = lexical_form
          datatype = xsd.string.expand
          language_tag = None
          region_subtag = None
          base_direction = None

        }

    static member datatyped (lexical_form: string) (datatype_iri: Resolved_IRI) =
        {

          lexical_form = lexical_form
          datatype = datatype_iri
          language_tag = None
          region_subtag = None
          base_direction = None

        }

    static member language (lexical_form: string) (language_tag: string) =
        {

          lexical_form = lexical_form
          datatype = rdf.langString.expand
          language_tag = Some(language_tag)
          region_subtag = None
          base_direction = None

        }

    static member directed (lexical_form: string) (language_tag: string) (direction: Language_Direction) =
        {

          lexical_form = lexical_form
          datatype = rdf.dirLangString.expand
          language_tag = Some(language_tag)
          region_subtag = None
          base_direction = Some(direction)

        }



    static member region (lexical_form: string) (language_tag: string) (region_subtag: string) =
        {

          lexical_form = lexical_form
          datatype = rdf.dirLangString.expand
          language_tag = Some(language_tag)
          region_subtag = Some(region_subtag)
          base_direction = None

        }



    static member english(lexical_form: string) =
        {

          lexical_form = lexical_form
          datatype = rdf.dirLangString.expand
          language_tag = Some("en")
          region_subtag = None
          base_direction = None

        }

    static member america(lexical_form: string) =

        {

          lexical_form = lexical_form
          datatype = rdf.dirLangString.expand
          language_tag = Some("en")
          region_subtag = Some("US")
          base_direction = None

        }



    static member autotyped<'ValueType>(value: 'ValueType) =
        let lexical_form, datatype_iri =
            let invariant_string =
                if box value = null then
                    String.Empty
                else
                    Convert.ToString(value, CultureInfo.InvariantCulture)

            match box value with
            | :? Boolean as value -> (if value then "true" else "false"), xsd.boolean.expand
            | :? (Byte array) as value -> Convert.ToBase64String(value), xsd.base64Binary.expand
            | :? Byte as value -> invariant_string, xsd.unsignedByte.expand
            | :? DateOnly as value -> value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture), xsd.date.expand
            | :? DateTime as value -> value.ToString("o", CultureInfo.InvariantCulture), xsd.dateTime.expand
            | :? DateTimeOffset as value -> value.ToString("o", CultureInfo.InvariantCulture), xsd.dateTimeStamp.expand
            | :? Decimal as value -> invariant_string, xsd.decimal.expand
            | :? Double as value -> value.ToString("R", CultureInfo.InvariantCulture), xsd.double.expand
            | :? Int16 as value -> invariant_string, xsd.short.expand
            | :? Int32 as value -> invariant_string, xsd.int.expand
            | :? Int64 as value -> invariant_string, xsd.long.expand
            | :? SByte as value -> invariant_string, xsd.byte.expand
            | :? Single as value -> value.ToString("R", CultureInfo.InvariantCulture), xsd.float.expand
            | :? TimeOnly as value -> value.ToString("HH:mm:ss.fffffff", CultureInfo.InvariantCulture), xsd.time.expand
            | :? TimeSpan as value -> Xml.XmlConvert.ToString(value), xsd.duration.expand
            | :? UInt16 as value -> invariant_string, xsd.unsignedShort.expand
            | :? UInt32 as value -> invariant_string, xsd.unsignedInt.expand
            | :? UInt64 as value -> invariant_string, xsd.unsignedLong.expand
            | :? Uri as value -> value.AbsoluteUri, xsd.anyURI.expand
            | :? XmlQualifiedName as value -> value.ToString(), xsd.QName.expand
            | null -> "true", xsi.nil.expand
            | value when value.GetType() = typeof<Object> -> invariant_string, xdt.anyAtomicType.expand
            | value -> invariant_string, xsd.string.expand

        RDF_Literal.datatyped lexical_form datatype_iri

module Literal =

    module Binary =

        let base64 (bytes: Byte array) =
            let lexical_form = Convert.ToBase64String(bytes)

            RDF_Literal.datatyped lexical_form xsd.base64Binary.expand

        let hex (bytes: Byte array) =
            let lexical_form = Convert.ToHexString(bytes)

            RDF_Literal.datatyped lexical_form xsd.hexBinary.expand


    module Temporal =
        module duration =
            let timeDuration (timespan: TimeSpan) =
                let lexical_form = Xml.XmlConvert.ToString(timespan)

                RDF_Literal.datatyped lexical_form xsd.duration.expand

            let dayTimeDuration (timespan: TimeSpan) =
                let lexical_form = Xml.XmlConvert.ToString(timespan)

                RDF_Literal.datatyped lexical_form xdt.dayTimeDuration.expand


            let yearMonthDuration (years: int) (months: int) =
                let total_months = years * 12 + months

                let lexical_form =
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

                RDF_Literal.datatyped lexical_form xdt.yearMonthDuration.expand

        module date =

            let only (date: DateOnly) =
                let lexical_form = date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)

                RDF_Literal.datatyped lexical_form xsd.date.expand

            let from_datetime (datetime: DateTime) =
                let lexical_form = datetime.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)

                RDF_Literal.datatyped lexical_form xsd.date.expand

            let time (datetime: DateTime) =
                let lexical_form = datetime.ToString("o", CultureInfo.InvariantCulture)

                RDF_Literal.datatyped lexical_form xsd.dateTime.expand

            let timeStamp (datetime_offset: DateTimeOffset) =
                let lexical_form = datetime_offset.ToString("o", CultureInfo.InvariantCulture)

                RDF_Literal.datatyped lexical_form xsd.dateTimeStamp.expand

        module time =

            let only (time: TimeOnly) =
                let lexical_form = time.ToString("HH:mm:ss.fffffff", CultureInfo.InvariantCulture)

                RDF_Literal.datatyped lexical_form xsd.time.expand

            let from_datetime (datetime: DateTime) =
                let lexical_form =
                    datetime.ToString("HH:mm:ss.fffffff", CultureInfo.InvariantCulture)

                RDF_Literal.datatyped lexical_form xsd.time.expand

        module period =

            let day (datetime: DateTime) =
                let lexical_form =
                    $"""---{datetime.Day.ToString("00", CultureInfo.InvariantCulture)}"""

                RDF_Literal.datatyped lexical_form xsd.gDay.expand


            let month (datetime: DateTime) =
                let lexical_form =
                    $"""--{datetime.Month.ToString("00", CultureInfo.InvariantCulture)}"""

                RDF_Literal.datatyped lexical_form xsd.gMonth.expand


            let monthDay (datetime: DateTime) =
                let lexical_form =
                    $"""--{datetime.Month.ToString("00", CultureInfo.InvariantCulture)}-{datetime.Day.ToString("00", CultureInfo.InvariantCulture)}"""

                RDF_Literal.datatyped lexical_form xsd.gMonthDay.expand


            let year (datetime: DateTime) =
                let lexical_form = datetime.Year.ToString("0000", CultureInfo.InvariantCulture)

                RDF_Literal.datatyped lexical_form xsd.gYear.expand


            let yearMonth (datetime: DateTime) =
                let lexical_form =
                    $"""{datetime.Year.ToString("0000", CultureInfo.InvariantCulture)}-{datetime.Month.ToString("00", CultureInfo.InvariantCulture)}"""

                RDF_Literal.datatyped lexical_form xsd.gYearMonth.expand

            let generalDay (day: int) =
                test <@ day >= 1 && day <= 99 @>
                let lexical_form = $"""---{day.ToString("00", CultureInfo.InvariantCulture)}"""

                RDF_Literal.datatyped lexical_form owl.time.generalDay.expand


            let generalMonth (month: int) =
                test <@ month >= 1 && month <= 20 @>
                let lexical_form = $"""--{month.ToString("00", CultureInfo.InvariantCulture)}"""

                RDF_Literal.datatyped lexical_form owl.time.generalMonth.expand


            let generalYear (year: int) =
                let lexical_form = year.ToString("0000", CultureInfo.InvariantCulture)

                RDF_Literal.datatyped lexical_form owl.time.generalYear.expand


    module Numeric =

        let private bigint_lexical_form (value: bigint) =
            value.ToString(CultureInfo.InvariantCulture)

        let integer (value: bigint) =
            RDF_Literal.datatyped (bigint_lexical_form value) xsd.integer.expand

        let negativeInteger (value: bigint) =
            test <@ value < 0I @>
            RDF_Literal.datatyped (bigint_lexical_form value) xsd.negativeInteger.expand

        let nonNegativeInteger (value: bigint) =
            test <@ value >= 0I @>
            RDF_Literal.datatyped (bigint_lexical_form value) xsd.nonNegativeInteger.expand

        let nonPositiveInteger (value: bigint) =
            test <@ value <= 0I @>
            RDF_Literal.datatyped (bigint_lexical_form value) xsd.nonPositiveInteger.expand

        let positiveInteger (value: bigint) =
            test <@ value > 0I @>
            RDF_Literal.datatyped (bigint_lexical_form value) xsd.positiveInteger.expand


module Representation =
    module IRIREF =

        let resolved_iri (iriref: string) =
            { lexical_form = iriref } |> ResolvedIRI

        let relative_iri (iriref: string) =
            { lexical_form = iriref } |> RelativeIRI

    module Literal =
        let simple (literal: string) = RDF_Literal.simple literal
// TODO figure out how to handle other representations































let turtle_escape_set =
    Set.ofArray [| "~"
                   "."
                   "-"
                   "!"
                   "$"
                   "&"
                   "'"
                   "("
                   ")"
                   "*"
                   "+"
                   ","
                   ";"
                   "="
                   "/"
                   "?"
                   "#"
                   "@"
                   "%" |]

module Set =
    let ContainsAny (curString: string) (string_set: Set<string>) =
        string_set
        |> Seq.exists (fun set_element -> curString.Contains(set_element))

























let code_point_iri_lexical_forms =
    character_properties
    |> Array.map (fun (code_point, _, _) -> code_point)
    |> Array.distinct
    |> Array.map (fun local_name -> $"https://eristocrates.dev/ontology/unicode/{local_name}"

    )

let attribute_iri_lexical_forms =
    character_properties
    |> Array.map (fun (_, char_attribute_LocalName, _) -> char_attribute_LocalName)
    |> Array.distinct
    |> Array.map (fun local_name -> $"https://eristocrates.dev/ontology/unicode/{local_name}"

    )

let attribute_literal_lexical_forms =
    character_properties
    |> Array.map (fun (_, _, char_attribute_value) -> char_attribute_value)
    |> Array.distinct


let alias_literal_lexical_forms =
    name_aliases
    |> Array.map (fun (_, alias_attribute, _) -> alias_attribute)
    |> Array.distinct

let alias_iri_lexical_forms =
    alias_literal_lexical_forms
    |> Array.map (fun local_name -> $"https://eristocrates.dev/ontology/unicode/{local_name}"

    )

let alias_type_iri_lexical_forms =
    name_aliases
    |> Array.map (fun (_, _, type_attribute) -> type_attribute)
    |> Array.distinct
    |> Array.map (fun local_name -> $"https://eristocrates.dev/ontology/unicode/{local_name}"

    )


let iri_forms =
    Array.concat [|

                    code_point_iri_lexical_forms
                    attribute_iri_lexical_forms
                    alias_iri_lexical_forms
                    alias_type_iri_lexical_forms

                     |]

let literal_forms =
    Array.concat [|

                    attribute_literal_lexical_forms
                    alias_literal_lexical_forms

                     |]


let iri_terms =
    Database.Get.Lexical_Forms_from_Strings iri_forms
    |> iri_terms_from_lexical_forms
    |> Database.Get.Transient_Terms_From_Persistent_Terms

let literal_terms =
    Database.Get.Lexical_Forms_from_Strings literal_forms
    |> simple_literal_terms_from_lexical_forms
    |> Database.Get.Transient_Terms_From_Persistent_Terms





let a = iri "http://www.w3.org/1999/02/22-rdf-syntax-ns#type"
let value_iri = iri "http://www.w3.org/1999/02/22-rdf-syntax-ns#value"
let Code_Point_iri = iri unicode.Code_Point.expand.lexical_form
let Name_Alias_iri = iri unicode.Name_Alias.expand.lexical_form

let Unicode_Character_Property_iri =
    iri unicode.Unicode_Character_Property.expand.lexical_form

let name_alias_iri = iri unicode.name_alias.expand.lexical_form
let alias_type_iri = iri unicode.alias_type.expand.lexical_form














let transient_term_lexical_form_string (term: Transient_Term) =
    term.persistent_term
    |> Persistent_Term.lexical_form_id
    |> Lexical_Form.string_from_form_id

let terms_by_lexical_form_string (terms: Transient_Term array) =
    let dictionary = Dictionary<string, Transient_Term>()

    for term in terms do
        let key = transient_term_lexical_form_string term

        if not (dictionary.ContainsKey key) then
            dictionary.Add(key, term)

    dictionary

let iri_term_by_string_lookup = terms_by_lexical_form_string iri_terms

let literal_term_by_string_lookup = terms_by_lexical_form_string literal_terms

let iri_lookup string_value = iri_term_by_string_lookup[string_value]

let simple_literal_lookup string_value =
    literal_term_by_string_lookup[string_value]











character_properties
|> Array.distinctBy (fun (_, char_attribute, _) -> char_attribute)
|> Array.map (fun (_, char_attribute, _) ->
    let char_attribute_iri =
        iri_lookup $"https://eristocrates.dev/ontology/unicode/{char_attribute}"

    Quad.spoc char_attribute_iri a Unicode_Character_Property_iri context_iri

)
|> Assert.Quads























let mutable total_stopwatch = Stopwatch.StartNew()

let mutable total_quads_written = 0


let code_point_elements =
    character_properties
    |> Array.distinctBy (fun (code_point, _, _) -> code_point)

let code_point_elements_batch_cardinality = code_point_elements.Length / batch_size

code_point_elements
|> Array.chunkBySize batch_size
|> Array.iteri (fun batch_index code_point_batch ->

    let batch_stopwatch = Stopwatch.StartNew()

    let quads =
        code_point_batch
        |> Array.map (fun (code_point, _, _) ->
            let code_point_iri =
                iri_lookup $"https://eristocrates.dev/ontology/unicode/{code_point}"

            Quad.spoc code_point_iri a Code_Point_iri context_iri

        )

    let expansion_elapsed = batch_stopwatch.Elapsed

    Assert.Quads quads

    batch_stopwatch.Stop()


    total_quads_written <- total_quads_written + quads.Length

    let total_rate =
        float total_quads_written
        / total_stopwatch.Elapsed.TotalSeconds

    let batch_rate =
        float quads.Length
        / batch_stopwatch.Elapsed.TotalSeconds

    printfn
        "batch=%i/%d rows=%i quads=%i expansion=%O batch_elapsed=%O batch_rate=%.0f quads/sec total=%i total_elapsed=%O total_rate=%.0f quads/sec"
        batch_index
        code_point_elements_batch_cardinality
        code_point_batch.Length
        quads.Length
        expansion_elapsed
        batch_stopwatch.Elapsed
        batch_rate
        total_quads_written
        total_stopwatch.Elapsed
        total_rate)

total_stopwatch.Stop()

printfn
    "done total_quads=%i elapsed=%O average_rate=%.0f quads/sec"
    total_quads_written
    total_stopwatch.Elapsed
    (float total_quads_written
     / total_stopwatch.Elapsed.TotalSeconds)


















total_stopwatch = Stopwatch.StartNew()

total_quads_written = 0

let character_property_batch_cardinality = character_properties.Length / batch_size

character_properties
|> Array.chunkBySize batch_size
|> Array.iteri (fun batch_index character_property_batch ->

    let batch_stopwatch = Stopwatch.StartNew()

    let quads =
        character_property_batch
        |> Array.map (fun (code_point, char_attribute, char_attribute_value) ->

            let code_point_iri =
                iri_lookup $"https://eristocrates.dev/ontology/unicode/{code_point}"

            let char_attribute_iri =
                iri_lookup $"https://eristocrates.dev/ontology/unicode/{char_attribute}"

            let attribute_literal = simple_literal_lookup char_attribute_value

            Quad.spoc code_point_iri char_attribute_iri attribute_literal context_iri

        )

    let expansion_elapsed = batch_stopwatch.Elapsed

    Assert.Quads quads

    batch_stopwatch.Stop()


    total_quads_written <- total_quads_written + quads.Length

    let total_rate =
        float total_quads_written
        / total_stopwatch.Elapsed.TotalSeconds

    let batch_rate =
        float quads.Length
        / batch_stopwatch.Elapsed.TotalSeconds

    printfn
        "batch=%i/%d rows=%i quads=%i expansion=%O batch_elapsed=%O batch_rate=%.0f quads/sec total=%i total_elapsed=%O total_rate=%.0f quads/sec"
        batch_index
        character_property_batch_cardinality
        character_property_batch.Length
        quads.Length
        expansion_elapsed
        batch_stopwatch.Elapsed
        batch_rate
        total_quads_written
        total_stopwatch.Elapsed
        total_rate)

total_stopwatch.Stop()

printfn
    "done total_quads=%i elapsed=%O average_rate=%.0f quads/sec"
    total_quads_written
    total_stopwatch.Elapsed
    (float total_quads_written
     / total_stopwatch.Elapsed.TotalSeconds)






























































total_stopwatch <- Stopwatch.StartNew()

total_quads_written <- 0

name_aliases
|> Array.chunkBySize batch_size
|> Array.iteri (fun batch_index name_alias_batch ->

    let batch_stopwatch = Stopwatch.StartNew()

    let quads =
        name_alias_batch
        |> Array.collect (fun (code_point, alias_attribute, type_attribute) ->

            let code_point_iri =
                iri_lookup $"https://eristocrates.dev/ontology/unicode/{code_point}"

            let alias_iri =
                iri_lookup $"https://eristocrates.dev/ontology/unicode/{alias_attribute}"

            let alias_literal = simple_literal_lookup alias_attribute

            let type_iri =
                iri_lookup $"https://eristocrates.dev/ontology/unicode/{type_attribute}"

            [|

               Quad.spoc code_point_iri name_alias_iri alias_iri context_iri
               Quad.spoc alias_iri a Name_Alias_iri context_iri
               Quad.spoc alias_iri alias_type_iri type_iri context_iri
               Quad.spoc alias_iri value_iri alias_literal context_iri

               |]

        )

    let expansion_elapsed = batch_stopwatch.Elapsed

    Assert.Quads quads

    batch_stopwatch.Stop()

    total_quads_written <- total_quads_written + quads.Length

    let total_rate =
        float total_quads_written
        / total_stopwatch.Elapsed.TotalSeconds

    let batch_rate =
        float quads.Length
        / batch_stopwatch.Elapsed.TotalSeconds

    printfn
        "batch=%i rows=%i quads=%i expansion=%O batch_elapsed=%O batch_rate=%.0f quads/sec total=%i total_elapsed=%O total_rate=%.0f quads/sec"
        batch_index
        name_alias_batch.Length
        quads.Length
        expansion_elapsed
        batch_stopwatch.Elapsed
        batch_rate
        total_quads_written
        total_stopwatch.Elapsed
        total_rate)

total_stopwatch.Stop()

printfn
    "done total_quads=%i elapsed=%O average_rate=%.0f quads/sec"
    total_quads_written
    total_stopwatch.Elapsed
    (float total_quads_written
     / total_stopwatch.Elapsed.TotalSeconds)








let code_point_iri = iri "https://eristocrates.dev/ontology/unicode/31850"
let na_iri = iri $"https://eristocrates.dev/ontology/unicode/na"
let kIRG_UKSource = iri $"https://eristocrates.dev/ontology/unicode/kIRG_UKSource"
let UK_10329 = simple_literal "UK-10329"

Query._poc kIRG_UKSource UK_10329 context_iri

character_properties
|> Array.filter (fun (code_point, _, _) -> code_point = "3184F")






//

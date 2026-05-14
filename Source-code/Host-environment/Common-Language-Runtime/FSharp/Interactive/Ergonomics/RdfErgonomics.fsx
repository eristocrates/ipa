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

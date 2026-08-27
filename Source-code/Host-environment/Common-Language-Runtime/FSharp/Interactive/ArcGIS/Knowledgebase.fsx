#time on

fsi.PrintLength <- 30
fsi.ShowDeclarationValues <- true

open System.IO
open System.IO.Compression
open System.Text

open System
open System.IO
open System.Text
open System.Xml
open System.Xml.Serialization
open System.Xml.Linq
open System.Globalization
open System.Collections
open System.Reflection
open System.Reflection.Emit
open System.Diagnostics
open Microsoft.FSharp.Reflection
open System.Collections.Generic



#r "nuget: XParsec"
#r "nuget: NeatIntervals"
#r "nuget: FRange"
#r "nuget: UUIDNext"
#r "nuget: CommunityToolkit.HighPerformance"
#r "nuget: FSharp.Json"
#r "nuget: FSharp.Data"
#r "nuget: FSharp.Data.Adaptive"
#r "nuget: FSharp.HashCollections"
#r "nuget: Yog.FSharp"
#r "nuget: QuikGraph"
#r "nuget: QuikGraph.Serialization"
#r "nuget: QuikGraph.Graphviz"
#r "nuget: QuikGraph.Data"
#r "nuget: QuikGraph.MSAGL"
#r "nuget: QuikGraph.Petri"
#r "nuget: FSharp.Json"
#r "nuget: FSharp.ViewEngine"
#r "nuget: Fss-lib.Core"
#r "nuget: Fabulous.AST"
#r "nuget: HtmlToOpenXml.dll"

open FSharp.Data.XElementExtensions
open FSharp.Json


#r "nuget: FsHttp"
open FsHttp

#r "nuget: dotNetRdf"
open VDS.RDF
open VDS.RDF.Query.Inference
open VDS.RDF.Ontology
open VDS.RDF.Nodes
open VDS.RDF.Query.Builder
open VDS.RDF.Query.Patterns
open VDS.RDF.Parsing
open VDS.RDF.JsonLd
open VDS.RDF
open VDS.RDF.Writing
open VDS.RDF.Query.Datasets
open VDS.RDF.Storage
open VDS.RDF.Query
open VDS.RDF.Parsing.Tokens

#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Solution\DoxAletheia\Ergonomic_Extensions\obj\Release\net10.0"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Solution\DoxAletheia\DotNetRDFSharp\obj\Release\net10.0"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Solution\DoxAletheia\Rdf_Vocabulary\obj\Release\net10.0"
#r "Ergonomic_Extensions.dll"
#r "DotNetRDFSharp.dll"
#r "Rdf_Vocabulary.dll"

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID
open NamespaceRegistry
open PrettierNaming
open PrettierNaming.FSharp_Keywords
open JsonErgonomics
open IOExtensions
open ArrayErgonomics
open RdfExtensions
open StringExtensions
open System.Net.Http
open RDF_Shorthand
// open RDF_Query
open Graph_Data
open XmlErgonomics
open HtmlErgonomics



open http.www.w3.org._1999._02._22_rdf_syntax_ns.hash
open http.www.w3.org._2000._01.rdf_schema.hash
open http.www.w3.org._2002._07.owl.hash
open http.www.w3.org._2001.XMLSchema.hash
open http.xmlns.com.foaf._0._1.slash



#r "nuget: Esri.ArcGISRuntime, 300.0.0"

open Esri.ArcGISRuntime
open Esri.ArcGISRuntime.Data
open Esri.ArcGISRuntime.Portal
open Esri.ArcGISRuntime.Mapping

#r "nuget: FSharp.Collections.ParallelSeq"
open FSharp.Collections.ParallelSeq

open FSharp.Data
open FSharp.Data.Adaptive




open Fabulous.AST
open Fantomas.Core.SyntaxOak

open type Fabulous.AST.Ast


open type Html_Tag

open FSharp.ViewEngine
open Fss.Types
#r "nuget: CaseConverter"
open CaseConverter

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\PowershellErgonomics.fsx"
open PowershellErgonomics
#r "nuget: FsExcel"
open FsExcel



// RDFa Core Initial Context
// https://www.w3.org/2011/rdfa-context/rdfa-1.1

// "Activity Vocabulary"                               , "Activity Vocabulary"                                                  , "W3C Recommendation"
open https.www.w3.org.ns.activitystreams.hash
// "Metadata for Tabular Data"                         , "Metadata Vocabulary for Tabular Data"                                 , "W3C Recommendation"
open http.www.w3.org.ns.csvw.hash
// "Data Catalog Vocabulary"                           , "Data Catalog Vocabulary (DCAT)"                                       , "W3C Recommendation"
open http.www.w3.org.ns.dcat.hash
// "Data Quality Vocabulary"                           , "Data               on the Web Best Practices: Data Quality Vocabulary", "W3C WG Note"
open http.www.w3.org.ns.dqv.hash
// GRDDL                                               , "Gleaning Resource Descriptions from Dialects of Languages (GRDDL)"    , "W3C Recommendation"
open http.www.w3.org._2003.g.data_view.hash
// "JSON-LD"                                           , "JSON-LD 1.1, A JSON-based Serialization for Linked Data"              , "W3C Recommendation"
open http.www.w3.org.ns.json_ld.hash
// "Linked Data Platform Vocabulary"                   , "Linked Data Platform 1.0"                                             , "W3C Recommendation"
open http.www.w3.org.ns.ldp.hash
// "Ontology for Media Resources"                      , "Ontology for Media Resources 1.0"                                     , "W3C Recommendation"
open http.www.w3.org.ns.ma_ont.hash
// "Web Annotation Vocabulary"                         , "Web Annotation Vocabulary"                                            , "W3C Recommendation"
open http.www.w3.org.ns.oa.hash
// "ODRL Vocabulary & Expression 2.2"                  , "ODRL Vocabulary & Expression 2.2"                                     , "W3C Recommendation"
open http.www.w3.org.ns.odrl._2.slash
// Organizations                                       , "The Organization Ontology"                                            , "W3C Recommendation"
open http.www.w3.org.ns.org.hash
// OWL                                                 , "OWL Overview"                                                         , "W3C Recommendation"
open http.www.w3.org._2002._07.owl.hash
// "Provenance Vocabulary"                             , "Provenance Ontology"                                                  , "W3C Recommendation"
open http.www.w3.org.ns.prov.hash
// "Data Cubes"                                        , "The RDF Data Cube Vocabulary"                                         , "W3C Recommendation"
open http.purl.org.linked_data.cube.hash
// RDF                                                 , "RDF Semantics"                                                        , "W3C Recommendation"
open http.www.w3.org._1999._02._22_rdf_syntax_ns.hash
// "RDFa Vocabulary"                                   , "RDFa Core 1.1"                                                        , "W3C Recommendation"
open http.www.w3.org.ns.rdfa.hash
// "RDF Schema"                                        , "RDF Semantics"                                                        , "W3C Recommendation"
open http.www.w3.org._2000._01.rdf_schema.hash
// R2RML                                               , "R2RML: RDB to RDF Mapping Language"                                   , "W3C Recommendation"
open http.www.w3.org.ns.r2rml.hash
// "SPARQL 1.1 Service Description"                    , "SPARQL 1.1 Service Description"                                       , "W3C Recommendation"
open http.www.w3.org.ns.sparql_service_description.hash
// "SKOS Core"                                         , "SKOS Simple Knowledge Organization System Reference"                  , "W3C Recommendation
open http.www.w3.org._2004._02.skos.core.hash
// "SKOS eXtension for Labels"                         , "SKOS Simple Knowledge Organization System Reference"                  , "W3C Recommendation"
open http.www.w3.org._2008._05.skos_xl.hash
// "Semantic Sensor Network Ontology"                  , "Semantic Sensor Network Ontology"                                     , "W3C Recommendation"
open http.www.w3.org.ns.ssn.slash
// "Sensor, Observation, Sample, and Actuator Ontology", "Semantic Sensor Network Ontology"                                     , "W3C Recommendation"
open http.www.w3.org.ns.sosa.slash
// "Time Ontology"                                     , "Time Ontology in OWL"                                                 , "W3C Recommendation"
open http.www.w3.org._2006.time.hash
// VoID                                                , "Describing Linked Datasets with the VoID Vocabulary"                  , "W3C Interest Group Note"
open http.rdfs.org.ns._void.hash
// POWDER                                              , "Protocol for Web Description Resources (POWDER): Formal Semantics"    , "W3C Recommendation"
open http.www.w3.org._2007._05.powder.hash
// "POWDER-S"                                          , "Protocol for Web Description Resources (POWDER): Formal Semantics"    , "W3C Recommendation"
open http.www.w3.org._2007._05.powder_s.hash
// "RDFa Default Prefix"                               , "RDFa Core 1.1"                                                        , "W3C Recommendation"
open http.www.w3.org._1999.xhtml.vocab.hash
// "XML Reserved Prefix"                               , "Namespaces in XML 1.0"                                                , "W3C Recommendation"
open http.www.w3.org.XML._1998.namespace_.hash
// "XML Schema Datatypes"                              , "XML Schema Part 2: Datatypes Second Edition"                          , "W3C Recommendation"
open http.www.w3.org._2001.XMLSchema.hash
// ccREL                                          , "ccREL: The Creative Commons Rights Expression Language"
open http.creativecommons.org.ns.hash 
// "Common Tag Ontology"                          , "Common Tag Specification"
open http.commontag.org.ns.hash 
// "Dublin Core Metadata Terms"                   , "DCMI Metadata Terms"
open http.purl.org.dc.terms.slash 
// "Dublin Core Metadata Terms"                   , "DCMI Metadata Terms"
open http.purl.org.dc.terms.slash 
// "Dublin Core Metadata Element Set, Version 1.1", "Dublin Core Metadata Element Set, Version 1.1"
open http.purl.org.dc.elements._1._1.slash 
// FOAF                                           , "FOAF Vocabulary Specification"
open http.xmlns.com.foaf._0._1.slash 
// "GoodRelations Ontology"                       , "GoodRelations Language Reference"
open http.purl.org.goodrelations.v1.hash 
// "iCalendar terms in RDF"                       , "iCalendar terms in RDF"
open http.www.w3.org._2002._12.cal.ical.hash 
// "Facebook's Open Graph protocol"               , "Open Graph Protocol"
open http.ogp.me.ns.hash 
// "RDF Review Vocabulary"                        , "RDF Review Vocabulary"
open http.purl.org.stuff.rev.hash 
// "SIOC Core Ontology"                           , "SIOC Core Ontology Specification"
open http.rdfs.org.sioc.ns.hash 
// "vCard in RDF"                                 , "Representing vCard Objects in RDF"
open http.www.w3.org._2006.vcard.ns.hash 
// "The Schema.org vocabulary"                    , "Full Schema.org documentation"
open https.schema.org.slash 


#r "nuget: FSharp.Data.WsdlProvider, 0.8.0-alpha"














open FSharp.Data
open System.ServiceModel

#r @"C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\WebServices\bin\Messaging.dll"




#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Core.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.Storm.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.AgencyDefined.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.AssetAnalysis.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.AssetValuation.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.Building.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.DataExchngUtil.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.Fleet.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.FleetMgmt.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.IndWaste.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.LCA.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.Park.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.Plant.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.Railway.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.Reservoir.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.Risk.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.Roadway.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.Sewer.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.SolidWaste.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.Street.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.UsageArea.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.Water.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Billing.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Budgeting.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Cashiering.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.CDR.Building.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.CDR.BusinessLicense.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.CDR.CodeEnforcement.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.CDR.Planning.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.CDR.Project.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.CDR.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.CDR.TradeLicense.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.CDR.Use.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Contract.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.AccessControl.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.AgencyVariables.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.Attachments.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.AuditingTrail.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.BatchProcessing.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.Configuration.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.Correspondence.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.DataManagement.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.DataOutput.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.Filter.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.FilterCode.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.HealthCheck.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.IO.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.License.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.Metrics.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.Migration.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.OAuth.OAuthUtils.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.Proxies.Client.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.Reporting.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.Security.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.CRM.CallCentre.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.CRM.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.DynamicPortal.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.GIS.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.GISExtension.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Incident.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Inventory.MaterialsManagement.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Inventory.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.MetaData.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.MeterManagement.Water.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Planning.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Property.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Resources.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.ResourcesManager.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.ResourcesManager.Scheduling.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.SolidWasteManagement.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.WorkManagement.Proxies.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen8ClientProxies.dll"

#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Infor.Authentication.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Infor.PublicSector.Core.FileSystemManagement.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Infor.PublicSector.Core.LocalTime.dll"
#r @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Infor.Security.Cryptography.dll"





#load @"C:\Secret\InforSecrets.fsx"







#I @"C:\Repositories\appsdb\IPS_Sites\integration\SoapApi\obj\Release\net10.0"
#I @"C:\Repositories\appsdb\IPS_Sites\integration\WebServices\Hansen\Core\Security\obj\Release\net10.0"
#I @"C:\Repositories\appsdb\IPS_Sites\integration\WebServices\Hansen\AssetManagement\Storm\obj\Release\net10.0"
#r "SoapApi.dll"
#r "Security.dll"
#r "Storm.dll"

// #load @"C:\Repositories\appsdb\IPS_Sites\integration\WebServices\Hansen\AssetManagement\Storm\Hansen.AssetManagement.Storm.StormInlet.fs"














type SparqlResultSet with
    member this.variable_column(rdf_variable: RDF_Variable) =
        this.Results
        |> Seq.map (fun result ->
            result.Item rdf_variable.identifier
            |> RDF_Term.from_vds_node)
        |> Seq.toArray

// ─────────────────────────────────────────────────────────────
// Existing dotNetRDF query-form adapters
// ─────────────────────────────────────────────────────────────

let SELECT_ALL () : ISelectBuilder = QueryBuilder.SelectAll()


let SELECT (variables: RDF_Variable seq) : ISelectBuilder =
    variables
    |> Seq.map (fun variable -> variable.identifier)
    |> Seq.toArray
    |> QueryBuilder.Select


let CONSTRUCT (pattern_builder: TriplePatternBuilder) (formula: Formula) : IQueryBuilder =
    QueryBuilder.Construct(
        Action<IDescribeGraphPatternBuilder> (fun construct_template ->
            construct_template.Where(pattern_builder |> formula.as_graph_pattern)
            |> ignore)
    )


let ASK () : IQueryBuilder = QueryBuilder.Ask()


let DISCOVER (variables: RDF_Variable seq) : IDescribeBuilder =
    variables
    |> Seq.map (fun variable -> variable.question_form)
    |> Seq.toArray
    |> QueryBuilder.Describe


let DESCRIBE (iris: Iri seq) : SparqlQuery =
    iris
    |> Seq.map (fun iri -> iri.uri)
    |> Seq.toArray
    |> QueryBuilder.Describe
    |> fun builder -> builder.BuildQuery()


let repair_describe_variables (query: SparqlQuery) : SparqlQuery =
    if query.QueryType = SparqlQueryType.Describe then

        let query_variables = query.Variables :?> Generic.ICollection<SparqlVariable>

        query.DescribeVariables
        |> Seq.filter (fun token -> token.TokenType = Token.VARIABLE)
        |> Seq.iter (fun token ->

            let variable_name = token.Value.Substring(1)

            let already_registered =
                query_variables
                |> Seq.exists (fun variable -> variable.Name = variable_name)

            if not already_registered then
                query_variables.Add(SparqlVariable(variable_name, true)))

    query


let WHERE (pattern_builder: TriplePatternBuilder) (formula: Formula) (query_builder: IQueryBuilder) : SparqlQuery =
    query_builder
        .Where(pattern_builder |> formula.as_graph_pattern)
        .BuildQuery()
    |> repair_describe_variables


let private process_query (graph: IGraph) (query: SparqlQuery) : obj =
    let dataset = new InMemoryDataset(graph)

    let processor = new LeviathanQueryProcessor(dataset)

    processor.ProcessQuery(query)


type From_Where_Draft =
    { source_graph: IGraph option
      where_formula: Formula option }


let private empty_from_where_draft =
    { source_graph = None
      where_formula = None }


type From_Where_Builder<'Result>(execute: IGraph -> Formula -> 'Result) =

    member _.Yield(_: unit) : From_Where_Draft = empty_from_where_draft

    member _.Zero() : From_Where_Draft = empty_from_where_draft

    member _.For(_draft: From_Where_Draft, continuation: unit -> From_Where_Draft) : From_Where_Draft = continuation ()


    [<CustomOperation("from")>]
    member _.From(draft: From_Where_Draft, graph: IGraph) : From_Where_Draft =
        match draft.source_graph with
        | Some _ -> invalidOp "The query already contains a source graph."

        | None -> { draft with source_graph = Some graph }


    [<CustomOperation("where")>]
    member _.Where(draft: From_Where_Draft, formula: Formula) : From_Where_Draft =
        match draft.where_formula with
        | Some _ -> invalidOp "The query already contains a where clause."

        | None -> { draft with where_formula = Some formula }


    member _.Run(draft: From_Where_Draft) : 'Result =
        let graph =
            match draft.source_graph with
            | Some graph -> graph

            | None -> invalidOp "The query requires a graph supplied with 'from'."


        let where_formula =
            match draft.where_formula with
            | Some formula -> formula

            | None -> invalidOp "The query requires a 'where' clause."


        execute graph where_formula

type From_Draft = { source_graph: IGraph option }


let private empty_from_draft = { source_graph = None }


type From_Builder<'Result>(execute: IGraph -> 'Result) =

    member _.Yield(_: unit) : From_Draft = empty_from_draft

    member _.Zero() : From_Draft = empty_from_draft

    member _.For(_draft: From_Draft, continuation: unit -> From_Draft) : From_Draft = continuation ()


    [<CustomOperation("from")>]
    member _.From(draft: From_Draft, graph: IGraph) : From_Draft =
        match draft.source_graph with
        | Some _ -> invalidOp "The query already contains a source graph."

        | None -> { draft with source_graph = Some graph }


    member _.Run(draft: From_Draft) : 'Result =
        let graph =
            match draft.source_graph with
            | Some graph -> graph

            | None -> invalidOp "The query requires a graph supplied with 'from'."


        execute graph

module sparql =

    let select (variables: RDF_Variable seq) : From_Where_Builder<SparqlResultSet> =
        From_Where_Builder<SparqlResultSet> (fun graph where_formula ->

            let pattern_builder = TriplePatternBuilder(graph.NamespaceMap)

            let query_builder = SELECT variables :> IQueryBuilder

            let query =
                query_builder
                |> WHERE pattern_builder where_formula

            process_query graph query :?> SparqlResultSet)


    let select_all: From_Where_Builder<SparqlResultSet> =
        From_Where_Builder<SparqlResultSet> (fun graph where_formula ->

            let pattern_builder = TriplePatternBuilder(graph.NamespaceMap)

            let query_builder = SELECT_ALL() :> IQueryBuilder

            let query =
                query_builder
                |> WHERE pattern_builder where_formula

            process_query graph query :?> SparqlResultSet)


    let construct (construct_formula: Formula) : From_Where_Builder<IGraph> =
        From_Where_Builder<IGraph> (fun graph where_formula ->

            let pattern_builder = TriplePatternBuilder(graph.NamespaceMap)

            let query_builder = CONSTRUCT pattern_builder construct_formula

            let query =
                query_builder
                |> WHERE pattern_builder where_formula

            process_query graph query :?> IGraph)


    let ask: From_Where_Builder<bool> =
        From_Where_Builder<bool> (fun graph where_formula ->

            let pattern_builder = TriplePatternBuilder(graph.NamespaceMap)

            let query = ASK() |> WHERE pattern_builder where_formula

            let result_set = process_query graph query :?> SparqlResultSet

            result_set.Result)


    let discover (variables: RDF_Variable seq) : From_Where_Builder<IGraph> =
        From_Where_Builder<IGraph> (fun graph where_formula ->

            let pattern_builder = TriplePatternBuilder(graph.NamespaceMap)

            let query_builder = DISCOVER variables :> IQueryBuilder

            let query =
                query_builder
                |> WHERE pattern_builder where_formula

            process_query graph query :?> IGraph)


    let describe (iris: Iri seq) : From_Builder<IGraph> =
        From_Builder<IGraph> (fun graph ->

            let query = DESCRIBE iris

            process_query graph query :?> IGraph)



let in_memory_dataset = new InMemoryDataset(new DiskDemandTripleStore(), true, false)
module Folder = 
    let MapServer = PathInfo.from_string @"D:\Artifact\Company\Esri\LCPW_OverlayStormwaterInfrastructure_D_WM"

let esri_file = PathInfo.from_string  @"D:\Artifact\Company\Esri\LCPW_OverlayStormwaterInfrastructure_D_WM\LCPW_OverlayStormwaterInfrastructure_D_WM.ttl.gz"
let infor_file = PathInfo.from_string @"D:\Artifact\Company\Infor\MetaData\MetaData.ttl.gz"
let esri_graph_name = Iri_Reference(esri_file.path) |> IRIREF
let infor_graph_name = Iri_Reference(infor_file.path) |> IRIREF
in_memory_dataset.HasGraph(esri_graph_name.vds_node) |> ignore
in_memory_dataset.HasGraph(infor_graph_name.vds_node) |> ignore
let esri_graph  = in_memory_dataset[esri_graph_name.vds_node]
let infor_graph  = in_memory_dataset[infor_graph_name.vds_node]


let reasoner = RdfsReasoner()
reasoner.Apply(esri_graph)
reasoner.Apply(infor_graph)

let default_graph = new OntologyGraph()
default_graph.Assert(Seq.concat [esri_graph.Triples ; infor_graph.Triples])


let a = rdf.type_



module Esri = 

      module ArcGISRuntime = 

        let _namespace_name = "https://developers.arcgis.com/net/api-reference/api/net/Esri.ArcGISRuntime/"
        let _prefix_id = {namespace_name = _namespace_name ; namespace_prefix = "ArcGISRuntime"}
        let _prefix (local_name:string) = Prefixed_Name(_prefix_id, local_name.low_lined) |> PrefixedName  
        let service_info = _prefix "service_info"
        let sublayer = _prefix "sublayer"
        let feature = _prefix "feature"
module interraster = 

            let _namespace_name = $"https://interraster.leoncountyfl.gov/interraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/"

            let _prefix_id = {namespace_name = _namespace_name ; namespace_prefix = "interraster"}

            let _prefix (local_name:string) = Prefixed_Name(_prefix_id, local_name.low_lined) |> PrefixedName  


module infor = 
    let _namespace_name = @"http://schema.infor.com/InforOAGIS/2/"
    let _prefix_id = {namespace_name = _namespace_name ; namespace_prefix = "infor"}

    let _prefix (local_name:string) = Prefixed_Name(_prefix_id, local_name.low_lined.Replace("\\","-")) |> PrefixedName  
    let _element_class (local_name:string) = Prefixed_Name(_prefix_id,  local_name |> Converters.SplitCamelCase  |> Converters.ToTitleCase |> _.low_lined ) |> PrefixedName  
    let _attribute_property (local_name:string) = Prefixed_Name(_prefix_id,  local_name |> Converters.SplitCamelCase  |> Converters.ToSnakeCase |> _.low_lined ) |> PrefixedName  
    let _element_property (local_name:string) = Prefixed_Name(_prefix_id,  local_name |> Converters.SplitCamelCase  |> Converters.ToSnakeCase |> _.low_lined ) |> PrefixedName  
    let value_references = _prefix "value_references"
    let value_referenced_by = _prefix "value_referenced_by"
    let table_key = _prefix "table_key"

    let cardinalityChild = _attribute_property "cardinalityChild"
    let cardinalityParent = _attribute_property "cardinalityParent"
    let cardinalityUsedByApplication = _attribute_property "cardinalityUsedByApplication"
    let commonId = _attribute_property "commonId"
    let dataPrecision = _attribute_property "dataPrecision"
    let dataScale = _attribute_property "dataScale"
    let databaseName = _attribute_property "databaseName"
    let databaseSchema = _attribute_property "databaseSchema"
    let databaseTable = _attribute_property "databaseTable"
    let databaseColumn = _attribute_property "databaseColumn"
    let defaultValue = _attribute_property "defaultValue"
    let deleteRule = _attribute_property "deleteRule"
    let deploymentStatus = _attribute_property "deploymentStatus"
    let description = _attribute_property "description"
    let direction = _attribute_property "direction"
    let displayDescription = _attribute_property "displayDescription"
    let displayName = _attribute_property "displayName"
    let displayTitle = _attribute_property "displayTitle"
    let displayTitleLong = _attribute_property "displayTitleLong"
    let effectiveDateTime = _attribute_property "effectiveDateTime"
    let enumerationName = _attribute_property "enumerationName"
    let expiredDateTime = _attribute_property "expiredDateTime"
    let hasNullRecord = _attribute_property "hasNullRecord"
    let identitySeed = _attribute_property "identitySeed"
    let identityStep = _attribute_property "identityStep"
    let isAgencyEnhancable = _attribute_property "isAgencyEnhancable"
    let isHansen = _attribute_property "isHansen"
    let isLicensed = _attribute_property "isLicensed"
    let isNullable = _attribute_property "isNullable"
    let isRequired = _attribute_property "isRequired"
    let isUnique = _attribute_property "isUnique"
    let length = _attribute_property "length"
    let locale = _attribute_property "locale"
    let name = _attribute_property "name"
    let oracleStatement = _attribute_property "oracleStatement"
    let order = _attribute_property "order"
    let owner = _attribute_property "owner"
    let platform = _attribute_property "platform"
    let remarks = _attribute_property "remarks"
    let showSearchOrder = _attribute_property "showSearchOrder"
    let statement = _attribute_property "statement"
    let type_ = _attribute_property "type"
    let useSearchOrder = _attribute_property "useSearchOrder"
    let value = _attribute_property "value"
    let column = _element_property "column"
    let customCreateStatement = _element_property "customCreateStatement"
    let domainColumn = _element_property "domainColumn"
    let domainColumnReference = _element_property "domainColumnReference"
    let enumeration = _element_property "enumeration"
    let enumerationCheckConstraint = _element_property "enumerationCheckConstraint"
    let enumerationCheckColumn = _element_property "enumerationCheckColumn"
    let EnumerationCheckColumn = _element_class "enumerationCheckColumn"
    let enumerationValue = _element_property "enumerationValue"
    let foreignColumnReference = _element_property "foreignColumnReference"
    let foreignKeyConstraint = _element_property "foreignKeyConstraint"
    let foreignKeyColumn = _element_property "foreignKeyColumn"
    let ForeignKeyColumn = _element_class "foreignKeyColumn"
    let hansenDataDistribution = _element_property "hansenDataDistribution"
    let hansenMetadata = _element_property "hansenMetadata"
    let index = _element_property "index"
    let localColumnReference = _element_property "localColumnReference"
    let primaryKeyConstraint = _element_property "primaryKeyConstraint"
    let primaryKeyColumn = _element_property "primaryKeyColumn"
    let PrimaryKeyColumn = _element_class "primaryKeyColumn"
    let productFamily = _element_property "productFamily"
    let referencingConstraint = _element_property "referencingConstraint"
    let referencingColumn = _element_property "referencingColumn"
    let ReferencingColumn = _element_class "referencingColumn"
    let requiredSystemLicense = _element_property "requiredSystemLicense"
    let systemLicense = _element_property "systemLicense"
    let table = _element_property "table"
    let tableCheckConstraint = _element_property "tableCheckConstraint"
    let tableCheckColumn = _element_property "tableCheckColumn"
    let TableCheckColumn = _element_class "tableCheckColumn"
    let text = _element_property "text"
    let uniqueConstraint = _element_property "uniqueConstraint"
    let uniqueColumn = _element_property "uniqueColumn"
    let UniqueColumn = _element_class "uniqueColumn"


module h8importtool = 
    let _namespace_name = $"http://www.infor.com/Hansen8/2011/08/Maps.xsd#"
    let _prefix_id = {namespace_name = _namespace_name ; namespace_prefix = "h8importtool"}

    let _prefix (local_name:string) = Prefixed_Name(_prefix_id, local_name.low_lined) |> PrefixedName  
    let map = _prefix "map"
    let map_column = _prefix "map_column"
    let from_layer = _prefix "from_layer"
    let from_field = _prefix "from_field"
    let to_table = _prefix "to_table"
    let to_column = _prefix "to_column"



    
    let Maps = _prefix "Maps"
    let Map = _prefix "Map"
    let Mapping = _prefix "Mapping"
    let Key = _prefix "Key"
    let IsDefault = _prefix "IsDefault"
    let Name = _prefix "Name"
    let SourceFilePath = _prefix "SourceFilePath"
    let SheetName = _prefix "SheetName"
    let ConnectionString = _prefix "ConnectionString"
    let ProviderName = _prefix "ProviderName"
    let UploadOption = _prefix "UploadOption"
    let IsFirstRowHeader = _prefix "IsFirstRowHeader"
    let CreatedDate = _prefix "CreatedDate"
    let CreatedBy = _prefix "CreatedBy"
    let MapColumn = _prefix "MapColumn"
    let MapKey = _prefix "MapKey"
    let SourceColumnName = _prefix "SourceColumnName"
    let TargetColumnCommonId = _prefix "TargetColumnCommonId"
    let TargetColumnType = _prefix "TargetColumnType"
    let MapTableInformation = _prefix "MapTableInformation"
    let ProductFamilyOwner = _prefix "ProductFamilyOwner"
    let ProductFamilyName = _prefix "ProductFamilyName"
    let TableName = _prefix "TableName"
    let TableCommonId = _prefix "TableCommonId"
    let TableKey = _prefix "TableKey"
    let System'Data'OleDb = _prefix "System'Data'OleDb"
module www2k = 
    let _namespace_name = "http://www.w3.org/2000/"
    
    let _prefix_id = {namespace_name = _namespace_name ; namespace_prefix = "www2k"}

    let _prefix (local_name:string) = Prefixed_Name(_prefix_id, local_name.low_lined) |> PrefixedName  
    let xmlns = _prefix "xmlns"
module InforProdSql =
    let _namespace_name = "https://inforprodsql.LeonAD.gov#"
    let _prefix_id = {namespace_name = _namespace_name ; namespace_prefix = "inforprodsql"}
    let _prefix (local_name:string) = Prefixed_Name(_prefix_id, local_name.low_lined) |> PrefixedName  
    let Schema = _prefix "Schema"
    let Table = _prefix "Table"
    let Column = _prefix "Column"


let test_name = "test_graph"
let test_directory = Path.Combine(__SOURCE_DIRECTORY__, test_name)



























let s = !? "s"
let p = !? "p"
let o = !? "o"

sparql.select [ s; p; o ] {
    where ( !> s --- p --> o )
    from default_graph
}



let described_graph = 
    sparql.describe [interraster._prefix "JN1188"] {
        from esri_graph
    }
described_graph.NamespaceMap.AddNamespace(interraster._prefix_id.namespace_prefix, new Uri(interraster._prefix_id.namespace_name))
described_graph.NamespaceMap.AddNamespace(Esri.ArcGISRuntime._prefix_id.namespace_prefix, new Uri(Esri.ArcGISRuntime._prefix_id.namespace_name))
described_graph.NamespaceMap.AddNamespace("owl", owl._namespace_iri.uri)
described_graph |> Turtle.write_igraph test_directory "results"

let selected_inlets = 
    sparql.select [s] {
            from esri_graph
            where (!> s --- a --> Esri.ArcGISRuntime._prefix "Inlet_Feature")
    }
let inlet_features = selected_inlets.variable_column s |> Array.choose (fun term -> 
    match term with 
    | IriRDFTerm iri -> Some iri
    | _ -> None
    )

let random_inlet_feature = inlet_features |> Array.randomChoice

let described_inlet = 
    sparql.describe [random_inlet_feature] {
        from esri_graph
    }

described_inlet.NamespaceMap.AddNamespace(interraster._prefix_id.namespace_prefix, new Uri(interraster._prefix_id.namespace_name))
described_inlet.NamespaceMap.AddNamespace(Esri.ArcGISRuntime._prefix_id.namespace_prefix, new Uri(Esri.ArcGISRuntime._prefix_id.namespace_name))

let described_inlet_graph = RDF_Graph.from_vds_graph described_inlet

let datatype_properties = 
    described_inlet_graph.triples
    |> Seq.choose (fun triple -> 
        match triple.curPredicate, triple.curObject with 
        | IriPredicate iri_predicate, LiteralObject literal_object -> Some (iri_predicate,literal_object) 
        | _ -> None
         )
let object_properties = 
    described_inlet_graph.triples
    |> Seq.choose (fun triple -> 
        match triple.curPredicate, triple.curObject with 
        | IriPredicate iri_predicate, IriObject iri_object -> Some (iri_predicate,iri_object) 
        | _ -> None
         )






let rdf_graph_result = 
    sparql.construct  (!> s --- a --> Esri.ArcGISRuntime._prefix "Junction_Fixed_Feature")  {
        from esri_graph
        where (!> s --- a --> Esri.ArcGISRuntime._prefix "Junction_Fixed_Feature")
    } |> RDF_Graph.from_vds_graph
let vds_graph_result = 
    rdf_graph_result
     |> IGraph.from_rdf_graph



vds_graph_result.NamespaceMap.AddNamespace(interraster._prefix_id.namespace_prefix, new Uri(interraster._prefix_id.namespace_name))
vds_graph_result.NamespaceMap.AddNamespace(Esri.ArcGISRuntime._prefix_id.namespace_prefix, new Uri(Esri.ArcGISRuntime._prefix_id.namespace_name))
vds_graph_result 
 |> Turtle.write_igraph test_directory "results"


(*




module MapServer = 
    let fs (map_server:ArcGISMapImageLayer) = 
        Oak() {
          Namespace("interraster"){
            Open("System")
            Open("System.IO")
            Module(map_server.Name) {
              Value("test", Ast.String("test"))

            }
          }
        }
        |> Gen.mkOak
        |> Gen.run    







let Layers = 
    map_server.Sublayers
    |> Array.Parallel.collect (fun Sublayer -> Sublayer.Sublayers )
    |> Array.Parallel.append map_server.Sublayers
    |> Array.Parallel.toArray
    |> Array.Parallel.map (fun Sublayer -> 
          match Sublayer with
            | :? ArcGISMapImageSublayer as layer -> layer
            | layer ->
                failwithf
                    "Expected ArcGISMapImageSublayer, but received %s."
                    (layer.GetType().FullName)
    
    )

let test_layer = Layers |> Array.randomChoice


test_layer
test_layer.MapServiceSublayerInfo
test_layer.Table


let all_features_query = QueryParameters()
all_features_query.WhereClause <- "1 = 1"
all_features_query.ReturnGeometry <- true

let feature_result =
    test_table.QueryFeaturesAsync(
        all_features_query,
        QueryFeatureFields.LoadAll
    )
    |> Async.AwaitTask
    |> Async.RunSynchronously

let features =
    feature_result
    |> Seq.toArray
    
    *)












































module soap =

    let Envelope =
        Xml.element "soap:Envelope"

    let Body =
        Xml.element "soap:Body"

    let _xmlns_soap =
        Xml._attribute "xmlns:soap"

type Hansen.AssetManagement.Storm.StormInlet with 
    member this.serializer = 
    
        XmlSerializer(
            this.GetType(),
                XmlRootAttribute(
                    "oBusinessObject",
                    Namespace = "http://hansen.com/"
                )

        )
    member this.oBusinessObject() = 
        let output = StringBuilder()

        let settings =
            XmlWriterSettings(
                Indent = true,
                OmitXmlDeclaration = true
            )

        use writer =
            XmlWriter.Create(output, settings)

        this.serializer.Serialize(
            writer,
            this
        )

        output.ToString()





let test_inlet = new Hansen.AssetManagement.Storm.StormInlet()
test_inlet
test_inlet.ID <- "test"


type Credential = 
    {
        ticket:string
        timestamp: DateTimeOffset
    }
[<Literal>]
let ticket_file_path = @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\ArcGIS\ticket.json"
let ticket_file = JsonProvider<ticket_file_path>.Load ticket_file_path

type XDocument with 
    member this.unformatted_text = 
            this.ToString( SaveOptions.DisableFormatting )

    member this.PostAction(soap_action:string)(endpoint:Uri) = 
                http {
                    POST endpoint.OriginalString

                    header
                        "SOAPAction"
                        $"\"{soap_action}\""

                    body
                    ContentType "text/xml" Encoding.UTF8
                    text this.unformatted_text
                }
                |> Request.send
                |> Response.toText

let ticket = 
    if FileInfo(ticket_file_path).Exists && DateTimeOffset.Now < ticket_file.Timestamp.AddHours 24 then
        ticket_file.Ticket
    else
        String.Empty
let login_document = Hansen.Core.Security.LoginService.ServiceLogin.document "Hansen8" InforSecrets.Login.username InforSecrets.Login.password ticket


type LoginResponse = XmlProvider<"""
<soap:Envelope xmlns:soap="http://schemas.xmlsoap.org/soap/envelope/" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <soap:Body>
    <ServiceLoginResponse xmlns="http://hansen.com/">
      <ServiceLoginResult>
        <Code>0</Code>
        <Date>2026-07-27T15:38:05.0457298</Date>
        <Severity>Success</Severity>
        <Message>General Success</Message>
        <Reference>RESULT(0,Success,7/27/2026,True,General Success)</Reference>
        <IsSuccess>true</IsSuccess>
        <HasFailed>false</HasFailed>
        <IsNoDataFound>false</IsNoDataFound>
      </ServiceLoginResult>
      <ticket>ZW5jcnlwdGVkOk1EQXdNREF3TURBeE51dk9MRkRiMWxPRnZBSzVkWDAxbVl0WFVTejBkUXdjZ3FvQytCMDN2N3lsS1hvTUJYek1xTXVZdm1XMGhGaXZGY28xeStraXFwWG5PZnFQSDM4QTM1MnlaUERiUEVpMU5nSFcvak5JL1lsRStCKzM0WXhNUk1xKytHT0JJWjdxb2tINkkzRENVMXVXWWQ2QlMyaUNORlU3TDVLN0pqMmJEN3RtSllEaU5PbVZ6N2JTN3UrRFZLeGNDaGN5eUo1SnNJdjlzOUx5dXRGeElUb2xkYWhiQWd3MHhlQ2dEVlBhYWN0TGRXZUMrcWpMd2huT0h1MjFkR3FPYmJRa3VHQThsWVBrWDFhV3llOURVa0ZDeGVHM0F5UT0=</ticket>
    </ServiceLoginResponse>
  </soap:Body>
</soap:Envelope>""">



let login_response =
    login_document.PostAction Hansen.Core.Security.LoginService.ServiceLogin.soap_action Hansen.Core.Security.LoginService.uri
    |> LoginResponse.Parse
login_response.XElement.ToString() |> clip

if ticket = String.Empty then 

    let credential  = 
        {
            ticket = login_response.Body.ServiceLoginResponse.Ticket
            timestamp = DateTimeOffset.Now
        }

    File.WriteAllText(ticket_file_path,Json.serialize credential)

test_inlet



(*


let loaded_storm_assemblies =
    AppDomain.CurrentDomain.GetAssemblies()
    |> Array.filter (fun assembly ->
        assembly.GetName().Name = "Storm"
    )

loaded_storm_assemblies
|> Array.map (fun assembly ->
    assembly.FullName,
    assembly.Location,
    assembly.GetType(
        "Hansen.AssetManagement.Storm.StormInlet",
        throwOnError = false,
        ignoreCase = false
    )
)
test_inlet.GetType().AssemblyQualifiedName

AppDomain.CurrentDomain.GetAssemblies()
|> Array.choose (fun assembly ->
    let candidate =
        assembly.GetType(
            "Hansen.AssetManagement.Storm.StormInlet",
            throwOnError = false,
            ignoreCase = false
        )

    if isNull candidate then
        None
    else
        Some (
            candidate.AssemblyQualifiedName,
            assembly.Location
        )
)


*)


let add_document = Hansen.AssetManagement.Storm.StormInletService.Add_1B2M2Y8AsgTpgAmY7PhCfgAA.document login_response.Body.ServiceLoginResponse.Ticket test_inlet

let add_response = 
    add_document.PostAction Hansen.AssetManagement.Storm.StormInletService.Add_1B2M2Y8AsgTpgAmY7PhCfgAA.soap_action Hansen.AssetManagement.Storm.StormInletService.uri

test_inlet.XCoordinate <- 123.0
let update_document = Hansen.AssetManagement.Storm.StormInletService.Update1.document ticket test_inlet
let update_response = 
    update_document.PostAction Hansen.AssetManagement.Storm.StormInletService.Update1.soap_action Hansen.AssetManagement.Storm.StormInletService.uri
Console.WriteLine update_response











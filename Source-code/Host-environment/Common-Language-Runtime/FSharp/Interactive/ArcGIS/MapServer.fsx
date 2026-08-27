#time on

fsi.PrintLength <- 3
fsi.ShowDeclarationValues <- false

open System
open System.Data
open System.IO
open System.IO.Compression
open System.Text
open System.Xml.XPath
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
open System.Collections
open System.Xml.Schema



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
open VDS.RDF.Nodes
open VDS.RDF.Query.Builder
open VDS.RDF.Query.Patterns
open VDS.RDF.Parsing
open VDS.RDF.JsonLd
open VDS.RDF.Query.Datasets
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
// open XmlErgonomics
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


#r "nuget: SQLProvider.MsSql, 1.5.18"
open FSharp.Data.Sql
open FSharp.Data.Sql.MsSql

#r "nuget: ClosedXML"

#r "nuget: FSharp.Collections.ParallelSeq"
open FSharp.Collections.ParallelSeq

open FSharp.Data
open FSharp.Data.Adaptive.Transaction
open FSharp.HashCollections


#r "nuget: FsExcel"
open FsExcel


open Fabulous.AST
open Fantomas.Core.SyntaxOak



open type Html_Tag

open FSharp.ViewEngine
open Fss.Types
#r "nuget: CaseConverter"
open CaseConverter

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\PowershellErgonomics.fsx"
open PowershellErgonomics




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
#r @"C:\Repositories\appsdb\IPS_Sites\integration\Mappings.xml\System.Web.Services.dll"



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

#load @"C:\Secret\InforSecrets.fsx"

open InforSecrets







#r "nuget: Microsoft.SqlServer.DacFx"

open Microsoft.SqlServer.Dac
open Microsoft.SqlServer.Dac.Model










#r "nuget: SqlHydra.Query, 4.0.4"
open SqlHydra
open SqlHydra.Query
#r @"C:\Repositories\appsdb\IPS_Sites\integration\InforSql\obj\Release\net10.0\InforSql.dll"
open leoncountyfl.gov

#r "nuget: FSharp.XExtensions"
open FSharp.XExtensions
#r "nuget: LitXml"
open LitXml



#r "nuget: Catalyst.Models.English"

open Catalyst
open Catalyst.Models
open Mosaik.Core


English.Register()
Storage.Current <- DiskStorage("catalyst-models")

module nlp =
    let pipeline = Pipeline.For(Language.English)

    let recognizer =
        AveragePerceptronEntityRecognizer.FromStoreAsync(Language.English, Version.Latest, "WikiNER")
        |> Async.AwaitTask
        |> Async.RunSynchronously

    pipeline.Add(recognizer) |> ignore

    let process_single (input: string) =
        let document = Document(input, Language.English)
        pipeline.ProcessSingle(document)

    let process_multiple (inputs: string array) =
        let documents =
            inputs
            |> Array.map (fun input -> Document(input, Language.English) :> IDocument)
            |> Array.toSeq
        pipeline.Process documents


type InforProdSql = SqlDataProvider<ConnectionString=Prod.connection_string, IndividualsAmount=10000, UseOptionTypes=Common.NullableColumnType.OPTION>

module Document = 
    let dacpac = FilePathInfo (FileInfo @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\SqlDatabase\Metadata\operations.dacpac")
    let infor_graph = FilePathInfo(FileInfo @"D:\Artifact\Company\Infor\Metadata\MetaData.ttl.gz" )

module InforProdSql =
    let _namespace_name = "https://inforprodsql.LeonAD.gov#"
    let _prefix_id = {namespace_name = _namespace_name ; namespace_prefix = "inforprodsql"}
    let _prefix (local_name:string) = Prefixed_Name(_prefix_id, local_name.low_lined) |> PrefixedName  
    let Schema = _prefix "Schema"
    let Table = _prefix "Table"
    let Column = _prefix "Column"
    
    module operations = 
        let abox = InforProdSql.GetDataContext()
        let tbox = 
            let options = ModelLoadOptions()

            options.LoadAsScriptBackedModel <- true
            options.ModelStorageType <- DacSchemaModelStorageType.Memory

            TSqlModel.LoadFromDacpac(Document.dacpac.path, options)


        let TableValuedFunctions =
            tbox.GetObjects(DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "TableValuedFunction")

        let ScalarFunctions =
            tbox.GetObjects(DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "ScalarFunction")

        let Indexes =
            tbox.GetObjects(DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Index")

        let CheckConstraints =
            tbox.GetObjects(DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "CheckConstraint")

        let DatabaseOptionss =
            tbox.GetObjects(DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "DatabaseOptions")

        let DefaultConstraints =
            tbox.GetObjects(DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "DefaultConstraint")

        let DmlTriggers =
            tbox.GetObjects(DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "DmlTrigger")

        let ExtendedPropertys =
            tbox.GetObjects(DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "ExtendedProperty")

        let ForeignKeyConstraints =
            tbox.GetObjects(DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "ForeignKeyConstraint")

        let Logins =
            tbox.GetObjects(DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Login")

        let PrimaryKeyConstraints =
            tbox.GetObjects(DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "PrimaryKeyConstraint")

        let Procedures =
            tbox.GetObjects(DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Procedure")

        let Roles =
            tbox.GetObjects(DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Role")

        let RoleMemberships =
            tbox.GetObjects(DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "RoleMembership")

        let Schemas =
            tbox.GetObjects(DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Schema")

        let Statisticss =
            tbox.GetObjects(DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Statistics")

        let Synonyms =
            tbox.GetObjects(DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Synonym")

        let Tables =
            tbox.GetObjects(DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "Table")

        let TableTypes =
            tbox.GetObjects(DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "TableType")

        let UniqueConstraints =
            tbox.GetObjects(DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "UniqueConstraint")

        let Users =
            tbox.GetObjects(DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "User")

        let Views =
            tbox.GetObjects(DacQueryScopes.All)
            |> PSeq.filter (fun model_object -> model_object.ObjectType.Name = "View")



let table_key_from_name (table_name: string) =

    let result =
        query {
            for Dbtable in InforProdSql.operations.abox.MetaData.Dbtable do
                where (Dbtable.Commonid.Value = table_name)
                select Dbtable.Tablekey
        }
        |> Seq.toArray
    if result.Length < 1 then
        None
    else
        Some(result[0])

[<Literal>]
let mapping_directory =
    @"D:\www\update\Integration\Interraster\LCPW_OverlayStormwaterInfrastructure_D_WM"








let is_nullish (string_value: string) =
    (String.IsNullOrWhiteSpace(string_value))
    || string_value = "N/A"
    || string_value = "<Null>"
    || string_value = "None"
    || string_value = "null"

let is_not_nullish (string_value: string) = not (is_nullish string_value)



let xpath (expression: string) (xpath_navigator: XPathNavigator) =
    let xpath_expression = XPathExpression.Compile(expression)

    xpath_navigator
        .Select(
            xpath_expression
        )
        .toElementArray



ArcGISRuntimeEnvironment.Initialize()
let test_name = "test_graph"
let test_directory = Path.Combine(__SOURCE_DIRECTORY__, test_name)




let a = rdf.type_

module dbug =
    let _namespace_iri = Namespace_Iri dbug |> NamespaceIRI
    let _prefix (local_name:string) = Prefixed_Name(xsi, local_name.low_lined) |> PrefixedName  

    let this_ = _prefix "this"
    let example = _prefix "example"

    let Alice = _prefix "Alice"
    let Bob = _prefix "Bob"



module Esri = 

      module ArcGISRuntime = 

        let _namespace_name = "https://developers.arcgis.com/net/api-reference/api/net/Esri.ArcGISRuntime/"
        let _prefix_id = {namespace_name = _namespace_name ; namespace_prefix = "ArcGISRuntime"}
        let _prefix (local_name:string) = Prefixed_Name(_prefix_id, local_name.low_lined) |> PrefixedName  
        let service_info = _prefix "service_info"
        let sublayer = _prefix "sublayer"
        let feature = _prefix "feature"


module interraster = 
    module Catalog = 
        // let pjson = JsonProvider<"https://interraster.leoncountyfl.gov/interraster/rest/services?f=pjson">.Load "https://interraster.leoncountyfl.gov/interraster/rest/services?f=pjson"

        module MapServices = 
            let _namespace_name = $"https://interraster.leoncountyfl.gov/interraster/rest/services/MapServices/"
            let _prefix_id = {namespace_name = _namespace_name ; namespace_prefix = "interraster"}

            let _prefix (local_name:string) = Prefixed_Name(_prefix_id, local_name.low_lined) |> PrefixedName  
            module LCPW_OverlayStormwaterInfrastructure_D_WM =
                // let pjson = JsonProvider<"https://interraster.leoncountyfl.gov/interraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/MapServer?f=pjson">.Load "https://interraster.leoncountyfl.gov/interraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/MapServer?f=pjson"
                let MapServer =
                        ArcGISMapImageLayer(Uri( "https://interraster.leoncountyfl.gov/interraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/MapServer" ))
        
        
open interraster.Catalog.MapServices.LCPW_OverlayStormwaterInfrastructure_D_WM
open VDS.RDF
open VDS.RDF.Query.Datasets
open VDS.RDF.Query
open VDS.RDF.Query.Builder
open VDS.RDF.Query.Patterns

MapServer.LoadTablesAndLayersAsync()
    |> Async.AwaitTask
    |> Async.RunSynchronously


type System.Type with 
    member this.GroupedProperties = 
        this.GetProperties()
        |> Array.groupBy (fun Property -> Property.PropertyType)
        |> Array.sortBy (fun (PropertyType, Properties ) -> PropertyType.FullName)
        |> Array.collect (fun (PropertyType, Properties ) ->
            Properties |> Array.map (fun Property -> sprintf "%s : %s" Property.Name PropertyType.FullName) |> Array.insertAt 0 "\n"
            )
    member this.PropertyTypeFullNames = 
        this.GetProperties()
        |> Array.map (fun Property -> Property.PropertyType.FullName )
        |> Array.distinct
        |> Array.sort
    member this.SystemPropertyTypes = 
        this.PropertyTypeFullNames
        |> Array.filter (fun PropertyTypeFullName -> PropertyTypeFullName.StartsWith("System") && not (PropertyTypeFullName.StartsWith("System.Collections")) )
    member this.CollectionPropertyTypes = 
        this.PropertyTypeFullNames
        |> Array.filter (fun PropertyTypeFullName -> PropertyTypeFullName.Contains("List") )


let inline predicates (value:'Type) =  

        value.GetType().GetProperties()
        |> Array.filter (fun Property -> Property.GetValue(value) <> null)
        |> Array.map (fun Property -> 
            let predicate_local_name = Converters.ToSnakeCase Property.Name
            Esri.ArcGISRuntime._prefix predicate_local_name 
        )
        |> Array.toList
        
let id_predicates = 
    set [
        "id"
        "service_layer_id"
    ]


    

type Field_Type =
    | OIDField of string
    | TextField of string
    | GlobalIDField of string
    | Int16Field of int16
    | Float64Field of double
    | DateField of DateTime
    | Int32Field of int
    | UnknownField of obj

    member private this.boxed_value : obj =
        match this with
        | OIDField value -> box value
        | TextField value -> box value
        | GlobalIDField value -> box value
        | Int16Field value -> box value
        | Float64Field value -> box value
        | DateField value -> box value
        | Int32Field value -> box value
        | UnknownField value -> value


    member this.as_string : string =
        Convert.ToString(
            this.boxed_value,
            CultureInfo.InvariantCulture
        )

    member this.as_int16 : int16 =
        Convert.ToInt16(
            this.boxed_value,
            CultureInfo.InvariantCulture
        )

    member this.as_double : double =
        Convert.ToDouble(
            this.boxed_value,
            CultureInfo.InvariantCulture
        )

    member this.as_date_time : DateTime =
        Convert.ToDateTime(
            this.boxed_value,
            CultureInfo.InvariantCulture
        )

    member this.as_int32 : int =
        Convert.ToInt32(
            this.boxed_value,
            CultureInfo.InvariantCulture
        )

    member this.as_object : obj =
        this.boxed_value

// TODO next reconcile this with updated dotnetrdfsharp
let rec inline predicateObjectList (value:'Type) =  

        value.GetType().GetProperties()
        |> Array.filter (fun Property -> Property.GetValue(value) <> null)
        |> Array.choose (fun Property -> 
            let predicate_local_name = Converters.ToSnakeCase Property.Name
            let key_predicate = Esri.ArcGISRuntime._prefix predicate_local_name
            let obj_value = Property.GetValue(value)
            match obj_value with 
            | :? System.String as value when not (String.IsNullOrWhiteSpace(value)) && id_predicates.Contains (predicate_local_name) -> Some (key_predicate ->-  value .*^ xsd.ID)
            | :? System.String as value when not (String.IsNullOrWhiteSpace(value)) -> Some (key_predicate ->- RDF_Literal.autotyped value)
            | :? Boolean as value -> Some(key_predicate ->- RDF_Literal.autotyped value)
            | :? (Byte array) as value -> Some(key_predicate ->- RDF_Literal.autotyped value)
            | :? Byte as value -> Some(key_predicate ->- RDF_Literal.autotyped value)
            | :? DateOnly as value -> Some(key_predicate ->- RDF_Literal.autotyped value)
            | :? DateTime as value -> Some(key_predicate ->- RDF_Literal.autotyped value)
            | :? DateTimeOffset as value -> Some(key_predicate ->- RDF_Literal.autotyped value)
            | :? Decimal as value -> Some(key_predicate ->- RDF_Literal.autotyped value)
            | :? Double as value when Double.IsNormal value && id_predicates.Contains (predicate_local_name)  -> Some(key_predicate ->-  (string value) .*^ xsd.ID)
            | :? Double as value -> Some(key_predicate ->- RDF_Literal.autotyped value)
            | :? Int16 as value -> Some(key_predicate ->- RDF_Literal.autotyped value)
            | :? Int32 as value -> Some(key_predicate ->- RDF_Literal.autotyped value)
            | :? Int64 as value when  id_predicates.Contains (predicate_local_name) -> Some(key_predicate ->-  (string value) .*^ xsd.ID)
            | :? Int64 as value -> Some(key_predicate ->- RDF_Literal.autotyped value)
            | :? SByte as value -> Some(key_predicate ->- RDF_Literal.autotyped value)
            | :? Single as value -> Some(key_predicate ->- RDF_Literal.autotyped value)
            | :? TimeOnly as value -> Some(key_predicate ->- RDF_Literal.autotyped value)
            | :? TimeSpan as value -> Some(key_predicate ->- RDF_Literal.autotyped value)
            | :? UInt16 as value -> Some(key_predicate ->- RDF_Literal.autotyped value)
            | :? UInt32 as value -> Some(key_predicate ->- RDF_Literal.autotyped value)
            | :? UInt64 as value when  id_predicates.Contains (predicate_local_name) -> Some(key_predicate ->-  (string value) .*^ xsd.ID)
            | :? UInt64 as value -> Some(key_predicate ->- RDF_Literal.autotyped value)
            | :? Uri as value -> Some(key_predicate ->- RDF_Literal.autotyped value)
            | :? Guid as value -> Some(key_predicate ->- RDF_Literal.autotyped value)
            | :? LoadStatus as value -> Some(key_predicate ->- RDF_Literal.simple(value.ToString()))
            | _ -> None
        )
        |> Array.toList






let inline GroupedProperties (value:'Type) = 
        value.GetType().GetProperties()
        |> Array.filter (fun Property -> Property.GetValue(value) <> null && not (Property.PropertyType.IsValueType))
        |> Array.groupBy (fun Property -> Property.PropertyType)
        |> Array.sortBy (fun (PropertyType, Properties ) -> PropertyType.FullName)
        |> Array.collect (fun (PropertyType, Properties ) ->
            Properties |> Array.map (fun Property -> sprintf "%s : %s" Property.Name PropertyType.FullName) |> Array.insertAt 0 "\n"
            )
let inline GroupedValues (value:'Type) = 
        value.GetType().GetProperties()
        |> Array.filter (fun Property -> Property.GetValue(value) <> null && Property.PropertyType.IsValueType)
        |> Array.groupBy (fun Property -> Property.PropertyType)
        |> Array.sortBy (fun (PropertyType, Properties ) -> PropertyType.FullName)
        |> Array.collect (fun (PropertyType, Properties ) ->
            Properties |> Array.map (fun Property -> sprintf "%s : %s" Property.Name PropertyType.FullName) |> Array.insertAt 0 "\n"
            )


type ArcGISMapImageLayer with 
    member this.directory = Directory.CreateDirectory $@"D:\Artifact\Company\Esri\{this.Name.low_lined}"
    member this._prefix_id = {namespace_name = $"https://interraster.leoncountyfl.gov/interraster/rest/services/MapServices/{this.Name.low_lined}/" ; namespace_prefix = "interraster"}
    member  this._prefix (local_name:string) = Prefixed_Name(this._prefix_id, local_name.low_lined) |> PrefixedName  
    member this.named_individual = this._prefix "MapServer"
    member this.owl_class = Esri.ArcGISRuntime._prefix (this.GetType().FullName)

    member this.predicateObjectList = predicateObjectList this
    member this.predicates = predicates this
    member this.GroupedProperties = GroupedProperties this
    member this.GroupedValues = GroupedValues this
        
type ArcGISServices.ArcGISMapServiceInfo with 
    member this.owl_class = Esri.ArcGISRuntime._prefix (this.GetType().FullName)
    member this.predicateObjectList = predicateObjectList this
    member this.predicates = predicates this
    member this.GroupedProperties = GroupedProperties this
    member this.GroupedValues = GroupedValues this
        
type ArcGISServices.ArcGISMapServiceSublayerInfo with 
    member this.owl_class = Esri.ArcGISRuntime._prefix (this.GetType().FullName)
    member this.predicateObjectList = predicateObjectList this
    member this.predicates = predicates this
    member this.GroupedProperties = GroupedProperties this
    member this.GroupedValues = GroupedValues this
        

type CodedValueDomain with 
    member this.owl_class = Esri.ArcGISRuntime._prefix typeof<CodedValueDomain>.FullName
    member this.named_individual = MapServer._prefix this.Name
    member this.predicateObjectList = predicateObjectList this
    member this.predicates = predicates this
    
    member this.GroupedProperties = GroupedProperties this
    member this.GroupedValues = GroupedValues this
type CodedValue with 
    member this.owl_class = Esri.ArcGISRuntime._prefix typeof<CodedValue>.FullName
    member this.named_individual domain_name = MapServer._prefix $"{domain_name}.{this.Name}"
    member this.predicateObjectList = predicateObjectList this
    member this.predicates = predicates this
    
    member this.GroupedProperties = GroupedProperties this
    member this.GroupedValues = GroupedValues this
type Geometry.Envelope with 
    member this.owl_class = Esri.ArcGISRuntime._prefix typeof<Geometry.Envelope>.FullName
    member this.predicateObjectList = predicateObjectList this
    member this.predicates = predicates this
    
    member this.GroupedProperties = GroupedProperties this
    member this.GroupedValues = GroupedValues this
type ArcGISServices.MapServiceCapabilities with 
    member this.owl_class = Esri.ArcGISRuntime._prefix typeof<ArcGISServices.MapServiceCapabilities>.FullName
    member this.predicateObjectList = predicateObjectList this
    member this.predicates = predicates this
    
    member this.GroupedProperties = GroupedProperties this
    member this.GroupedValues = GroupedValues this
type Geometry.SpatialReference with 
    member this.owl_class = Esri.ArcGISRuntime._prefix typeof<Geometry.SpatialReference>.FullName
    member this.predicateObjectList = predicateObjectList this
    member this.predicates = predicates this
    
    member this.GroupedProperties = GroupedProperties this
    member this.GroupedValues = GroupedValues this

type ServiceFeatureTable with 
    member this.owl_class = Esri.ArcGISRuntime._prefix typeof<ServiceFeatureTable>.FullName
    member this.predicateObjectList = predicateObjectList this
    member this.predicates = predicates this
    
    member this.GroupedProperties = GroupedProperties this
    member this.GroupedValues = GroupedValues this
type ArcGISServices.ArcGISFeatureLayerInfo with 
    member this.owl_class = Esri.ArcGISRuntime._prefix typeof<ArcGISServices.ArcGISFeatureLayerInfo>.FullName
    member this.predicateObjectList = predicateObjectList this
    member this.predicates = predicates this
    
    member this.GroupedProperties = GroupedProperties this
    member this.GroupedValues = GroupedValues this

type ArcGISMapImageSublayer with 
    member this.parent_name = 
        try 
            Some this.MapServiceSublayerInfo.ParentLayerInfo.Name
        with 
        | _ -> None
    member this.directory = 
        match this.parent_name with 
        | Some parent_name -> 
            Path.Combine(MapServer.directory.FullName,"esriGeometry" + this.MapServiceSublayerInfo.GeometryType.ToString(),parent_name.low_lined,this.Name.low_lined)  |> Directory.CreateDirectory
        | None -> Path.Combine(MapServer.directory.FullName,"esriGeometry" + this.MapServiceSublayerInfo.GeometryType.ToString(),this.Name.low_lined) |> Directory.CreateDirectory

    member this.named_individual = MapServer._prefix this.Name
    member this.owl_class = Esri.ArcGISRuntime._prefix typeof<ArcGISMapImageSublayer>.FullName
    member this.feature_class = Esri.ArcGISRuntime._prefix $"{this.Name}_Feature"
    member this.predicateObjectList = predicateObjectList this
    member this.predicates = predicates this
    member this.GroupedProperties = GroupedProperties this
    member this.GroupedValues = GroupedValues this
// TODO try getting layers and sparql querying!


let target_layers = 
    set [
        "Inlet"
        "Conduit"
        "Culvert Cross Drain"
        "Debris Trap"
        "Ditch"
        "End Point"
        "Junction Fixed"
        "Outfall"
        "Stormwater Pond"
        "Stormwater Pond Discharge"
        "Outfall Drainage Area"
        "Outfall Drainage Area MOF"
        "Outfall Drainage Area MS4"
        "Stormwater Pond - Top of Bank"
    ]
let layers = 
    MapServer.Sublayers
    // |> Seq.filter (fun layer -> target_layers.Contains(layer.Name))
    |> Seq.toArray
    |> Array.Parallel.collect (fun layer -> layer.Sublayers |> Seq.toArray )
    |> Array.append (MapServer.Sublayers |> Seq.toArray) 
    |> Array.Parallel.map (fun layer -> layer :?> ArcGISMapImageSublayer)
    |> Array.Parallel.filter (fun layer -> layer.Table <> null)
    |> Array.sortBy (fun layer -> layer.Table.NumberOfFeatures)

let layer_by_id = 
    layers
    |> Array.Parallel.map (fun layer -> layer.Id,layer)
    |> Map.ofSeq

let layer_individuals = 
    layers 
    |> Array.Parallel.map (fun layer -> layer.named_individual)
    |> Array.toList

let tables = 
    layers
    |> Array.Parallel.filter (fun layer -> layer.Table <> null)
    |> Array.Parallel.map (fun layer -> layer.Table  )
    |> Array.sortBy (fun table -> table.NumberOfFeatures)

let fields= 
    tables
    |> Array.Parallel.collect (fun table -> table.Fields |> Seq.toArray )
let domain_by_field = 
    fields
    |> Array.Parallel.filter (fun field -> field.Domain <> null)
    |> Array.Parallel.map (fun field -> field.Name,field.Domain :?> CodedValueDomain)
    |> Map.ofArray

let field_by_name = 
    fields
    |> Array.Parallel.map (fun field -> field.Name,field)
    |> Map.ofSeq
let field_types = 
    fields
    |> Array.Parallel.map (fun field -> field.FieldType.ToString())
    |> Array.distinct
let domains = 
    fields
    |> Array.Parallel.filter (fun field -> field.Domain <> null)
    |> Array.Parallel.map (fun field -> field.Domain :?> CodedValueDomain)
let domain_individuals = 
    domains
    |> Array.map (fun domain -> MapServer._prefix domain.Name)

let coded_values = 
    domains
    |> Array.Parallel.collect (fun domain -> 
        domain.CodedValues
        |> Seq.map (fun coded_value -> coded_value,domain)
        |> Seq.toArray
        )

let feature_query = QueryParameters()
feature_query.WhereClause <- "1 = 1"
feature_query.ReturnGeometry <- true

let features = 
    tables
    |> Array.Parallel.collect (fun (table) -> 

        table.QueryFeaturesAsync(
            feature_query,
            QueryFeatureFields.LoadAll
        )
        |> Async.AwaitTask
        |> Async.RunSynchronously
        |> Seq.toArray

    )

    








type Field_Kind = 
    | ACCEPT_DATE
    | ACCURACYCODE
    | ACREAGE
    | ACRES
    | ACTIVITY
    | ANCILLARYROLE
    | ATTACHEDTOID
    | ATTRIBUTECOMPLETE
    | CAPACITY
    | CREATIONDATE
    | CREATOR
    | CREW
    | DAMAGEID
    | DAMAGETYPE
    | DATAFILE
    | DATECREATED
    | DATEMODIFIED
    | DATE_
    | DESCRIPTION
    | DIAMETER
    | DIGITALPICTUREID
    | DIGITALPICTUREID_E
    | DIGITALPICTUREID_S
    | DIGITALPICTUREID_W
    | DOWNSTREAMDEPTH
    | DOWNSTREAMELEVATION
    | DOWNSTREAM_DEPTH
    | DOWNSTREAM_ELEV
    | DRAINAGEAREA
    | DRAINAGEBASIN
    | DRAINAGE_AREA
    | DRAWINGID
    | EASTING
    | EDITDATE
    | EDITOR
    | ELEMENTX
    | ELEMENTY
    | ENABLED
    | FACILITYID
    | FIELDCOMMENTS
    | FIELDCOMPLETE
    | FIELDCREW
    | FIELD_COMMENTS_
    | FILE_NAME
    | FILE_NAME_1
    | FILTER
    | FILTERLOCATION
    | FILTERTYPE
    | FINAL_NAME
    | FOLDER
    | GLOBALID
    | HEIGHT
    | HOTLINK
    | HYD_ID
    | HYPERLINK
    | HYPERLINK_AR
    | IMAGERYYEAR
    | INFILTRATION
    | INSPDATE
    | INVENTORIED_BY
    | INVENTORYDATE
    | INVENTORYTYPE
    | INVERTELEV
    | INVERT_ELEV
    | INVERT_ELEV29
    | ISINFALL
    | LEGACYID
    | LEGACY_ID
    | LFEET
    | LIFECYCLE
    | LOCATION
    | LOC_DESC
    | MAINTBY
    | MATERIAL
    | MEDIA_CODE
    | MILES
    | NEEDSATTENTION
    | NORTHING
    | NOTES
    | NUM_BARRELS
    | OBJECTID
    | OBSTRUCTION
    | ORIGINALSOURCE
    | OUTFALLID
    | OUTFALLTYPE
    | OWNER
    | PARCELID
    | PARENTID
    | PERCT_GRD
    | PHOTOID
    | PHOTO_FOLDER
    | PHOTO_NUM
    | PID_1
    | PIPESHAPE
    | PLACE
    | PONDID
    | PONDTYPE
    | PONDYR
    | POND_ID
    | PRFRESOLUTION
    | RAW_NAME
    | RELATEDFEATURE
    | ROTATION_AZ
    | SHAPE_Area
    | SHAPE_Length
    | SLOT_ELEV
    | SOURCE
    | SOURCEYEAR
    | STORAGE_FULL_PATH_ADDR
    | STORAGE_PATH_ADDR
    | STORAGE_STATIC_PATH_ADDR
    | STRCT_DEPTH
    | STRUCTUREID
    | STRUCTURETYPE
    | STRUCTURE_ID
    | SUBTYPEFIELD
    | SURFACETYPE
    | Shape_Area
    | Shape_Length
    | UNDERDRAINS
    | UNITDESC
    | UNITID
    | UPDATESOURCE
    | UPSTREAMDEPTH
    | UPSTREAMELEVATION
    | UPSTREAMSTUCTUREID
    | UPSTREAM_DEPTH
    | UPSTREAM_ELEV
    | VIEW_
    | WATERBODYNAME
    | WBID
    | WHOCREATED
    | WHOMODIFIED
    | WIDTH
    | Z29
    | ZVALUE














let maybe_domain_value  field_name field_value = 
    fields
    |> Array.tryPick (fun field -> 
        if field.Name = field_name && field.Domain <> null then 
            let domain = field.Domain :?> CodedValueDomain
            domain.CodedValues |> Seq.tryPick (fun coded_value -> 
                if coded_value.Code = field_value then 
                    Some(domain,coded_value)
                else 
                    None)
        else
            None
    )











type Feature with 
    member this.table = this.FeatureTable :?> ServiceFeatureTable
    member this.named_individual = MapServer._prefix this.id
    member this.maybe_subtype = 
        try 
            this.table.FeatureTypes
            |> Seq.toArray
            |> Array.tryFind (fun feature_type -> 
        
                match Int32.TryParse (string feature_type.Id) , this.SUBTYPEFIELD with 
                | (true, subtype_id),Some(feature_subtype_id)  when subtype_id = feature_subtype_id -> true
                | (_,_),_-> false
            
            
                )
        with 
        | err -> failwithf "%s %O failed with error %s " this.named_individual.lexical_form this err.Message
    
    member this.layer = layer_by_id[(this.FeatureTable :?> ServiceFeatureTable).ServiceLayerId]
    
    member this.maybe_attributes = this.Attributes |> Seq.map (|KeyValue|) |> Map.ofSeq
    member this.attributes = 
        this.Attributes
        |> Seq.toArray
        |> Array.map (|KeyValue|)
        |> Array.filter (fun (key,value) -> not (String.IsNullOrWhiteSpace (string value)))
        |> Array.choose (fun (key,value) -> 
            let maybe_attribute = this.maybe_attributes.TryFind(key)
            match maybe_attribute with 
            | None -> None
            | Some attribute when attribute = null -> None
            | Some attribute -> 
                let field = fields |> Array.find (fun field -> field.Name = key)
                try
                    match field.FieldType.ToString() with 
                    | "OID" -> Some(key, string attribute |> OIDField)
                    | "GlobalID" -> Some (key, string attribute |> GlobalIDField)
                    | "Int16" -> Some (key, string attribute |> Int16.Parse  |> Int16Field)
                    | "Float64" -> Some (key, string attribute |> Double.Parse  |> Float64Field)
                    | "Date" -> Some (key, string attribute |> DateTime.Parse  |> DateField)
                    | "Int32" -> Some (key, string attribute |> Int32.Parse  |> Int32Field)
                    | "Text" -> Some (key, string attribute   |> TextField)
                    | _ -> Some(key, UnknownField attribute)
                with 
                | err -> 
                    printfn "%s %O failed with error %s " this.named_individual.lexical_form this err.Message
                    Some(key, UnknownField attribute)

        )
        |> Map.ofArray


    member this.field (field_kind:Field_Kind) = 

            let maybe_attribute = this.maybe_attributes.TryFind(field_kind.ToString())
            match maybe_attribute with 
            | None -> None
            | Some attribute when attribute = null -> None
            | Some attribute -> 
                match field_by_name[field_kind.ToString()].FieldType.ToString() with 
                | "OID" -> Some(string attribute |> OIDField)
                | "GlobalID" -> Some (string attribute |> GlobalIDField)
                | "Int16" -> Some (string attribute |> Int16.Parse  |> Int16Field)
                | "Float64" -> Some (string attribute |> Double.Parse  |> Float64Field)
                | "Date" -> Some (string attribute |> DateTime.Parse  |> DateField)
                | "Int32" -> Some (string attribute |> Int32.Parse  |> Int32Field)
                | "Text" -> Some (string attribute   |> TextField)
                | _ -> Some(UnknownField attribute)
    member this.id = 
            match this.field UNITID with 
            | Some (TextField unit_id) -> unit_id 
            | _ -> string this.Attributes["GLOBALID"]

    member this.predicateAttributeList= 
            this.attributes
            |> Map.toList
            |> List.map (fun (field_name,attribute_value) ->
                            let predicate_local_name = $"{this.layer.Name}.{field_name}"
                            let key_predicate = MapServer._prefix predicate_local_name

                            match maybe_domain_value field_name attribute_value.as_string with 
                            | Some (domain,coded_value) -> 
                                key_predicate ->- MapServer._prefix $"{domain.Name}.{coded_value.Name}"
                            | None -> 
                                match attribute_value with 
                                | _ when field_name.ToLowerInvariant().Contains("year") -> key_predicate ->-  attribute_value.as_string .*^ xsd.gYear
                                | OIDField value -> key_predicate ->- RDF_Literal.autotyped value
                                | TextField value -> key_predicate ->- RDF_Literal.autotyped value
                                | GlobalIDField value -> key_predicate ->- RDF_Literal.autotyped value
                                | Int16Field value -> key_predicate ->- RDF_Literal.autotyped  value
                                | Float64Field value -> key_predicate ->- RDF_Literal.autotyped  value
                                | DateField value -> key_predicate ->- RDF_Literal.autotyped  value
                                | Int32Field value -> key_predicate ->- RDF_Literal.autotyped  value
                                | UnknownField value -> key_predicate ->- RDF_Literal.autotyped  value
        
            )
    
    member this.directory = Path.Combine(this.layer.directory.FullName,this.id)  |> Directory.CreateDirectory
    member this.owl_superclass = Esri.ArcGISRuntime._prefix (this.GetType().FullName)
    member this.feature_class = Esri.ArcGISRuntime._prefix $"{this.layer.Name}_Feature"
    member this.owl_class = 
        try
            match this.maybe_subtype with 
            | Some subtype -> Esri.ArcGISRuntime._prefix $"{this.layer.Name}.{subtype.Name}_Feature"
            | None -> this.feature_class
        with 
        | err -> 
            printfn "%s %O failed with error %s " this.named_individual.lexical_form this err.Message
            this.feature_class

    member this.predicateObjectList = predicateObjectList this
    member this.predicates = predicates this
    member this.GroupedProperties = GroupedProperties this
    member this.GroupedValues = GroupedValues this
    member this.maybe_x = 
        match this.Geometry.GeometryType with 
        | Geometry.GeometryType.Point -> 
            let x = (this.Geometry :?> Geometry.MapPoint).X
            if Double.IsNormal x  then 
                Some x
            else
                None
            
        | _ -> None
    member this.maybe_y = 
        match this.Geometry.GeometryType with 
        | Geometry.GeometryType.Point -> 
            let y = (this.Geometry :?> Geometry.MapPoint).Y 
            if Double.IsNormal y then 
                Some y
            else 
                None
        | _ -> None
    member this.maybe_z = 
        match this.Geometry.GeometryType with 
        | Geometry.GeometryType.Point -> 
            let z = (this.Geometry :?> Geometry.MapPoint).Z 
            if Double.IsNormal z  then 
                Some z
            else 
                this.ZVALUE

        | _ -> None
    member this.maybe_xyz = this.maybe_x,this.maybe_y,this.maybe_z
    member this.predicateGeometryList = 
        let x_predicate = MapServer._prefix "x_coordinate"
        let y_predicate = MapServer._prefix "y_coordinate"
        let z_predicate = MapServer._prefix "z_coordinate"
        [
            if this.maybe_x.IsSome then 
                x_predicate ->- RDF_Literal.autotyped this.maybe_x.Value
            if this.maybe_y.IsSome then 
                y_predicate ->- RDF_Literal.autotyped this.maybe_y.Value
            if this.maybe_z.IsSome then 
                z_predicate ->- RDF_Literal.autotyped this.maybe_z.Value
        ]

    member this.ACCEPT_DATE = this.field ACCEPT_DATE |> Option.map (fun value -> value.as_string)
    member this.ACREAGE = this.field ACREAGE |> Option.map (fun value -> value.as_double)
    member this.ACRES = this.field ACRES |> Option.map (fun value -> value.as_double)
    member this.ACTIVITY = this.field ACTIVITY |> Option.map (fun value -> value.as_string)
    member this.ATTACHEDTOID = this.field ATTACHEDTOID |> Option.map (fun value -> value.as_string)
    member this.AccuracyCode'ACCURACYCODE = this.field ACCURACYCODE |> Option.map (fun value -> value.as_string)
    member this.Accuracy_Code'ACCURACYCODE = this.field ACCURACYCODE |> Option.map (fun value -> value.as_string)
    member this.AncillaryRole'ANCILLARYROLE = this.field ANCILLARYROLE |> Option.map (fun value -> value.as_int16)
    member this.AttributeComplete'ATTRIBUTECOMPLETE = this.field ATTRIBUTECOMPLETE |> Option.map (fun value -> value.as_int16)
    member this.CAPACITY = this.field CAPACITY |> Option.map (fun value -> value.as_double)
    member this.CREW = this.field CREW |> Option.map (fun value -> value.as_string)
    member this.Company'FIELDCREW = this.field FIELDCREW |> Option.map (fun value -> value.as_string)
    member this.CreationDate'CREATIONDATE = this.field CREATIONDATE |> Option.map (fun value -> value.as_date_time)
    member this.Creator'CREATOR = this.field CREATOR |> Option.map (fun value -> value.as_string)
    member this.Crew'CREW = this.field CREW |> Option.map (fun value -> value.as_string)
    member this.DATECREATED = this.field DATECREATED |> Option.map (fun value -> value.as_date_time)
    member this.DATEMODIFIED = this.field DATEMODIFIED |> Option.map (fun value -> value.as_date_time)
    member this.DIGITALPICTUREID = this.field DIGITALPICTUREID |> Option.map (fun value -> value.as_string)
    member this.DIGITALPICTUREID_2'DIGITALPICTUREID_S = this.field DIGITALPICTUREID_S |> Option.map (fun value -> value.as_string)
    member this.DIGITALPICTUREID_3'DIGITALPICTUREID_E = this.field DIGITALPICTUREID_E |> Option.map (fun value -> value.as_string)
    member this.DIGITALPICTUREID_4'DIGITALPICTUREID_W = this.field DIGITALPICTUREID_W |> Option.map (fun value -> value.as_string)
    member this.DOWNSTREAMDEPTH = this.field DOWNSTREAMDEPTH |> Option.map (fun value -> value.as_double)
    member this.DOWNSTREAMELEVATION = this.field DOWNSTREAMELEVATION |> Option.map (fun value -> value.as_double)
    member this.DOWNSTREAM_DEPTH = this.field DOWNSTREAM_DEPTH |> Option.map (fun value -> value.as_double)
    member this.DOWNSTREAM_ELEV = this.field DOWNSTREAM_ELEV |> Option.map (fun value -> value.as_double)
    member this.DRAINAGEAREA = this.field DRAINAGEAREA |> Option.map (fun value -> value.as_double)
    member this.DRAINAGEBASIN = this.field DRAINAGEBASIN |> Option.map (fun value -> value.as_string)
    member this.DRAINAGE_AREA = this.field DRAINAGE_AREA |> Option.map (fun value -> value.as_double)
    member this.DRAWINGID = this.field DRAWINGID |> Option.map (fun value -> value.as_string)
    member this.DamageID'DAMAGEID = this.field DAMAGEID |> Option.map (fun value -> value.as_string)
    member this.DamageType'DAMAGETYPE = this.field DAMAGETYPE |> Option.map (fun value -> value.as_string)
    member this.Datafile'DATAFILE = this.field DATAFILE |> Option.map (fun value -> value.as_string)
    member this.Date'DATE_ = this.field DATE_ |> Option.map (fun value -> value.as_date_time)
    member this.Date_Created'DATECREATED = this.field DATECREATED |> Option.map (fun value -> value.as_date_time)
    member this.Date_Modified'DATEMODIFIED = this.field DATEMODIFIED |> Option.map (fun value -> value.as_date_time)
    member this.Diameter'DIAMETER = this.field DIAMETER |> Option.map (fun value -> value.as_int16)
    member this.Drawing_ID'DRAWINGID = this.field DRAWINGID |> Option.map (fun value -> value.as_string)
    member this.EASTING = this.field EASTING |> Option.map (fun value -> value.as_double)
    member this.ELEMENTX = this.field ELEMENTX |> Option.map (fun value -> value.as_double)
    member this.ELEMENTY = this.field ELEMENTY |> Option.map (fun value -> value.as_double)
    member this.ENABLED = this.field ENABLED |> Option.map (fun value -> value.as_int16)
    member this.Easting'EASTING = this.field EASTING |> Option.map (fun value -> value.as_double)
    member this.EditDate'EDITDATE = this.field EDITDATE |> Option.map (fun value -> value.as_date_time)
    member this.Editor'EDITOR = this.field EDITOR |> Option.map (fun value -> value.as_string)
    member this.Enabled'ENABLED = this.field ENABLED |> Option.map (fun value -> value.as_int16)
    member this.FACILITYID = this.field FACILITYID |> Option.map (fun value -> value.as_string)
    member this.FIELDCOMMENTS = this.field FIELDCOMMENTS |> Option.map (fun value -> value.as_string)
    member this.FILTERTYPE = this.field FILTERTYPE |> Option.map (fun value -> value.as_string)
    member this.FieldComments'FIELDCOMMENTS = this.field FIELDCOMMENTS |> Option.map (fun value -> value.as_string)
    member this.FieldComments'FIELD_COMMENTS_ = this.field FIELD_COMMENTS_ |> Option.map (fun value -> value.as_string)
    member this.FieldComplete'FIELDCOMPLETE = this.field FIELDCOMPLETE |> Option.map (fun value -> value.as_int16)
    member this.File_Name'FILE_NAME_1 = this.field FILE_NAME_1 |> Option.map (fun value -> value.as_string)
    member this.Filename'FILE_NAME = this.field FILE_NAME |> Option.map (fun value -> value.as_string)
    member this.Filter'FILTER = this.field FILTER |> Option.map (fun value -> value.as_int16)
    member this.FilterLocation'FILTERLOCATION = this.field FILTERLOCATION |> Option.map (fun value -> value.as_string)
    member this.Final_Name'FINAL_NAME = this.field FINAL_NAME |> Option.map (fun value -> value.as_string)
    member this.Folder'FOLDER = this.field FOLDER |> Option.map (fun value -> value.as_string)
    member this.GLOBALID = this.field GLOBALID |> Option.map (fun value -> value.as_string)
    member this.GlobalID'GLOBALID = this.field GLOBALID |> Option.map (fun value -> value.as_string)
    member this.HEIGHT = this.field HEIGHT |> Option.map (fun value -> value.as_double)
    member this.HYPERLINK_AR = this.field HYPERLINK_AR |> Option.map (fun value -> value.as_string)
    member this.Hotlink'HOTLINK = this.field HOTLINK |> Option.map (fun value -> value.as_string)
    member this.Hyperlink'HYPERLINK = this.field HYPERLINK |> Option.map (fun value -> value.as_string)
    member this.IMAGERYYEAR = this.field IMAGERYYEAR |> Option.map (fun value -> value.as_string)
    member this.INVENTORYDATE = this.field INVENTORYDATE |> Option.map (fun value -> value.as_date_time)
    member this.INVERTELEV = this.field INVERTELEV |> Option.map (fun value -> value.as_double)
    member this.INVERT_ELEV = this.field INVERT_ELEV |> Option.map (fun value -> value.as_double)
    member this.INVERT_ELEV29 = this.field INVERT_ELEV29 |> Option.map (fun value -> value.as_double)
    member this.ISINFALL = this.field ISINFALL |> Option.map (fun value -> value.as_int32)
    member this.Inspdate'INSPDATE = this.field INSPDATE |> Option.map (fun value -> value.as_date_time)
    member this.Inventoried_by'INVENTORIED_BY = this.field INVENTORIED_BY |> Option.map (fun value -> value.as_string)
    member this.InventoryType'INVENTORYTYPE = this.field INVENTORYTYPE |> Option.map (fun value -> value.as_string)
    member this.Inventory_Type'INVENTORYTYPE = this.field INVENTORYTYPE |> Option.map (fun value -> value.as_string)
    member this.IsInfall'ISINFALL = this.field ISINFALL |> Option.map (fun value -> value.as_int16)
    member this.LEGACYID = this.field LEGACYID |> Option.map (fun value -> value.as_string)
    member this.LFEET = this.field LFEET |> Option.map (fun value -> value.as_double)
    member this.LOCATION = this.field LOCATION |> Option.map (fun value -> value.as_string)
    member this.LegacyID'LEGACY_ID = this.field LEGACY_ID |> Option.map (fun value -> value.as_string)
    member this.Lifecycle'LIFECYCLE = this.field LIFECYCLE |> Option.map (fun value -> value.as_string)
    member this.Location'LOC_DESC = this.field LOC_DESC |> Option.map (fun value -> value.as_string)
    member this.Location_Date'INVENTORYDATE = this.field INVENTORYDATE |> Option.map (fun value -> value.as_date_time)
    member this.MILES = this.field MILES |> Option.map (fun value -> value.as_double)
    member this.MaintBy'MAINTBY = this.field MAINTBY |> Option.map (fun value -> value.as_string)
    member this.Material'MATERIAL = this.field MATERIAL |> Option.map (fun value -> value.as_string)
    member this.Media_Code'MEDIA_CODE = this.field MEDIA_CODE |> Option.map (fun value -> value.as_string)
    member this.NEEDSATTENTION = this.field NEEDSATTENTION |> Option.map (fun value -> value.as_int16)
    member this.NORTHING = this.field NORTHING |> Option.map (fun value -> value.as_double)
    member this.NOTES = this.field NOTES |> Option.map (fun value -> value.as_string)
    member this.NUM_BARRELS = this.field NUM_BARRELS |> Option.map (fun value -> value.as_int32)
    member this.NeedsAttention'NEEDSATTENTION = this.field NEEDSATTENTION |> Option.map (fun value -> value.as_int16)
    member this.Northing'NORTHING = this.field NORTHING |> Option.map (fun value -> value.as_double)
    member this.Notes'DESCRIPTION = this.field DESCRIPTION |> Option.map (fun value -> value.as_string)
    member this.Notes'NOTES = this.field NOTES |> Option.map (fun value -> value.as_string)
    member this.OBJECTID = this.field OBJECTID |> Option.map (fun value -> value.as_string)
    member this.OBSTRUCTION = this.field OBSTRUCTION |> Option.map (fun value -> value.as_string)
    member this.ORIGINALSOURCE = this.field ORIGINALSOURCE |> Option.map (fun value -> value.as_string)
    member this.OUTFALLID = this.field OUTFALLID |> Option.map (fun value -> value.as_string)
    member this.OUTFALLTYPE = this.field OUTFALLTYPE |> Option.map (fun value -> value.as_string)
    member this.Original_Source'ORIGINALSOURCE = this.field ORIGINALSOURCE |> Option.map (fun value -> value.as_string)
    member this.Owner'OWNER = this.field OWNER |> Option.map (fun value -> value.as_string)
    member this.PARCELID = this.field PARCELID |> Option.map (fun value -> value.as_string)
    member this.PARENTID = this.field PARENTID |> Option.map (fun value -> value.as_string)
    member this.PERCT_GRD = this.field PERCT_GRD |> Option.map (fun value -> value.as_double)
    member this.PID_1 = this.field PID_1 |> Option.map (fun value -> value.as_string)
    member this.PLACE = this.field PLACE |> Option.map (fun value -> value.as_string)
    member this.PONDID = this.field PONDID |> Option.map (fun value -> value.as_string)
    member this.PONDYR = this.field PONDYR |> Option.map (fun value -> value.as_string)
    member this.PRFRESOLUTION = this.field PRFRESOLUTION |> Option.map (fun value -> value.as_string)
    member this.PRFResolution'PRFRESOLUTION = this.field PRFRESOLUTION |> Option.map (fun value -> value.as_string)
    member this.PhotoID'PHOTOID = this.field PHOTOID |> Option.map (fun value -> value.as_string)
    member this.PhotoNum'PHOTO_NUM = this.field PHOTO_NUM |> Option.map (fun value -> value.as_int16)
    member this.Photo_Folder'PHOTO_FOLDER = this.field PHOTO_FOLDER |> Option.map (fun value -> value.as_string)
    member this.PipeShape'PIPESHAPE = this.field PIPESHAPE |> Option.map (fun value -> value.as_string)
    member this.PondID'PONDID = this.field PONDID |> Option.map (fun value -> value.as_string)
    member this.PondID'POND_ID = this.field POND_ID |> Option.map (fun value -> value.as_string)
    member this.PondType'PONDTYPE = this.field PONDTYPE |> Option.map (fun value -> value.as_string)
    member this.Pond_Number'HYD_ID = this.field HYD_ID |> Option.map (fun value -> value.as_string)
    member this.Raw_Name'RAW_NAME = this.field RAW_NAME |> Option.map (fun value -> value.as_string)
    member this.RelatedFeature'RELATEDFEATURE = this.field RELATEDFEATURE |> Option.map (fun value -> value.as_string)
    member this.Rotation_Az'ROTATION_AZ = this.field ROTATION_AZ |> Option.map (fun value -> value.as_int16)
    member this.SHAPE_Area = this.field SHAPE_Area |> Option.map (fun value -> value.as_double)
    member this.SHAPE_Length = this.field SHAPE_Length |> Option.map (fun value -> value.as_double)
    member this.SLOT_ELEV = this.field SLOT_ELEV |> Option.map (fun value -> value.as_double)
    member this.SOURCEYEAR = this.field SOURCEYEAR |> Option.map (fun value -> value.as_string)
    member this.STORAGE_FULL_PATH_ADDR = this.field STORAGE_FULL_PATH_ADDR |> Option.map (fun value -> value.as_string)
    member this.STORAGE_STATIC_PATH_ADDR = this.field STORAGE_STATIC_PATH_ADDR |> Option.map (fun value -> value.as_string)
    member this.STRCT_DEPTH = this.field STRCT_DEPTH |> Option.map (fun value -> value.as_double)
    member this.STRUCTUREID = this.field STRUCTUREID |> Option.map (fun value -> value.as_string)
    member this.STRUCTURETYPE = this.field STRUCTURETYPE |> Option.map (fun value -> value.as_string)
    member this.SUBTYPEFIELD = this.field SUBTYPEFIELD |> Option.map (fun value -> value.as_int32)
    member this.Shape_Area = this.field Shape_Area |> Option.map (fun value -> value.as_double)
    member this.Shape_Length = this.field Shape_Length |> Option.map (fun value -> value.as_double)
    member this.Source'SOURCE = this.field SOURCE |> Option.map (fun value -> value.as_string)
    member this.Storage_Path_Address'STORAGE_PATH_ADDR = this.field STORAGE_PATH_ADDR |> Option.map (fun value -> value.as_string)
    member this.Struct_ID'STRUCTURE_ID = this.field STRUCTURE_ID |> Option.map (fun value -> value.as_string)
    member this.StructureID'STRUCTUREID = this.field STRUCTUREID |> Option.map (fun value -> value.as_string)
    member this.SubtypeField'SUBTYPEFIELD = this.field SUBTYPEFIELD |> Option.map (fun value -> value.as_int32)
    member this.SurfaceType'SURFACETYPE = this.field SURFACETYPE |> Option.map (fun value -> value.as_string)
    member this.UNDERDRAINS = this.field UNDERDRAINS |> Option.map (fun value -> value.as_double)
    member this.UNITDESC = this.field UNITDESC |> Option.map (fun value -> value.as_string)
    member this.UNITID = this.field UNITID |> Option.map (fun value -> value.as_string)
    member this.UPDATESOURCE = this.field UPDATESOURCE |> Option.map (fun value -> value.as_string)
    member this.UPSTREAMDEPTH = this.field UPSTREAMDEPTH |> Option.map (fun value -> value.as_double)
    member this.UPSTREAMELEVATION = this.field UPSTREAMELEVATION |> Option.map (fun value -> value.as_double)
    member this.UPSTREAMSTUCTUREID = this.field UPSTREAMSTUCTUREID |> Option.map (fun value -> value.as_string)
    member this.UPSTREAM_DEPTH = this.field UPSTREAM_DEPTH |> Option.map (fun value -> value.as_double)
    member this.UPSTREAM_ELEV = this.field UPSTREAM_ELEV |> Option.map (fun value -> value.as_double)
    member this.Update__Source'UPDATESOURCE = this.field UPDATESOURCE |> Option.map (fun value -> value.as_string)
    member this.View'VIEW_ = this.field VIEW_ |> Option.map (fun value -> value.as_string)
    member this.WATERBODYNAME = this.field WATERBODYNAME |> Option.map (fun value -> value.as_string)
    member this.WBID = this.field WBID |> Option.map (fun value -> value.as_string)
    member this.WHOMODIFIED = this.field WHOMODIFIED |> Option.map (fun value -> value.as_string)
    member this.WIDTH = this.field WIDTH |> Option.map (fun value -> value.as_double)
    member this.WhoCreated'WHOCREATED = this.field WHOCREATED |> Option.map (fun value -> value.as_string)
    member this.Who_Created'WHOCREATED = this.field WHOCREATED |> Option.map (fun value -> value.as_string)
    member this.Who_Modified'WHOMODIFIED = this.field WHOMODIFIED |> Option.map (fun value -> value.as_string)
    member this.Z29 = this.field Z29 |> Option.map (fun value -> value.as_double)
    member this.ZVALUE = this.field ZVALUE |> Option.map (fun value -> value.as_double)
    member this.ZValue'ZVALUE = this.field ZVALUE |> Option.map (fun value -> value.as_double)
    member this.``Inflow\Infiltration'INFILTRATION`` = this.field INFILTRATION |> Option.map (fun value -> value.as_int16)




module codegen = 
    let layer_types = 
                    target_layers
                    |> Seq.map (fun layer  -> 
                        sprintf """
    type %s_Layer= 
        { 
            name :string
            features :%s_Feature list
        }
                                """
                                layer.normalize_identifier
                                layer.normalize_identifier
                                )
                    |> String.concat "\n"
    let layer_records = 
                    target_layers
                    |> Seq.map (fun layer  -> 
                        sprintf """
    let %s : %s_Layer= 
        { 
            name = "%s"
            features = 
                features
                |> Array.Parallel.filter (fun feature -> feature.layer.Name = "%s")
                |> Array.toList
                |> List.map %s_Feature.from_feature
        }
                                """
                                layer.normalize_identifier
                                layer.normalize_identifier
                                layer
                                layer
                                layer.normalize_identifier
                                )
                    |> String.concat "\n"
    let field_binding (field:Field) = 
        let binding =
                if field.Alias <> field.Name then 
                    sprintf "%s'%s" field.Alias field.Name
                else 
                    field.Name
        binding.normalize_identifier

    let field_members = 

        fields |> Array.map (fun field -> 
            let binding = field_binding field
            let case = field.Name
            let conversion = 
                            match field.FieldType.ToString() with 
                            | "Int16" -> "int16 option"
                            | "Float64" -> "double option"
                            | "Date" -> "date_time option"
                            | "Int32" -> "int32 option"
                            | _ -> "string option"


            sprintf "member this.%s = this.field %s |> Option.map (fun value -> value.as_%s)" binding case conversion)
            |> Array.distinct
            |> Array.sort
            |> String.concat "\n"
    let cli_type_from_field_type (field_type:FieldType) = 
        match field_type.ToString() with 
        | "Int16" ->  "int16 option"
        | "Float64" ->  "double option"
        | "Date" ->  "DateTime option"
        | "Int32" ->  "int option"
        | _ -> "string option"

    let feature_types = 
            Ast.Oak() {
              Ast.AnonymousModule() {
                for table in tables do
                    (Ast.Record(table.DisplayName.normalize_identifier + "_Feature") {
                        for field in table.Fields do 
                            Ast.Field(field.Name, cli_type_from_field_type field.FieldType)
                        Ast.Field("x", "double option")
                        Ast.Field("y", "double option")
                        Ast.Field("z", "double option")
                    }).members(){
                        Ast.Member("from_feature(feature:Feature)",
                            Ast.RecordExpr([

                                for field in table.Fields do 
                                    let binding = field_binding field
                                    Ast.RecordFieldExpr(field.Name, sprintf "feature.%s" binding)
                                Ast.RecordFieldExpr("x", "feature.maybe_x")
                                Ast.RecordFieldExpr("y", "feature.maybe_y")
                                Ast.RecordFieldExpr("z", "feature.maybe_z")
                            ])
                            ).toStatic()
                    }

            }
            }
            |> Gen.mkOak
            |> Gen.run    

clip codegen.field_members
clip codegen.feature_types

clip codegen.layer_types
clip codegen.layer_records

// TODO next add x and y


type Stormwater_Pond___Top_of_Bank_Feature =
    { OBJECTID: string option
      ANCILLARYROLE: int16 option
      ENABLED: int16 option
      LIFECYCLE: string option
      PARENTID: string option
      OWNER: string option
      MAINTBY: string option
      SOURCE: string option
      FACILITYID: string option
      LEGACYID: string option
      NOTES: string option
      PONDTYPE: string option
      PARCELID: string option
      ACTIVITY: string option
      FILTER: int16 option
      FILTERTYPE: string option
      FILTERLOCATION: string option
      ORIGINALSOURCE: string option
      DATECREATED: DateTime option
      WHOCREATED: string option
      UPDATESOURCE: string option
      DATEMODIFIED: DateTime option
      WHOMODIFIED: string option
      ACCURACYCODE: string option
      LOCATION: string option
      DIGITALPICTUREID: string option
      HYPERLINK_AR: string option
      POND_ID: string option
      SUBTYPEFIELD: int option
      DRAINAGEAREA: double option
      ACREAGE: double option
      CAPACITY: double option
      IMAGERYYEAR: string option
      GLOBALID: string option
      PONDYR: string option
      SHAPE_Length: double option
      x: double option
      y: double option
      z: double option }

    static member from_feature(feature:Feature) =
        { OBJECTID = feature.OBJECTID
          ANCILLARYROLE = feature.AncillaryRole'ANCILLARYROLE
          ENABLED = feature.Enabled'ENABLED
          LIFECYCLE = feature.Lifecycle'LIFECYCLE
          PARENTID = feature.PARENTID
          OWNER = feature.Owner'OWNER
          MAINTBY = feature.MaintBy'MAINTBY
          SOURCE = feature.Source'SOURCE
          FACILITYID = feature.FACILITYID
          LEGACYID = feature.LEGACYID
          NOTES = feature.NOTES
          PONDTYPE = feature.PondType'PONDTYPE
          PARCELID = feature.PARCELID
          ACTIVITY = feature.ACTIVITY
          FILTER = feature.Filter'FILTER
          FILTERTYPE = feature.FILTERTYPE
          FILTERLOCATION = feature.FilterLocation'FILTERLOCATION
          ORIGINALSOURCE = feature.Original_Source'ORIGINALSOURCE
          DATECREATED = feature.Date_Created'DATECREATED
          WHOCREATED = feature.Who_Created'WHOCREATED
          UPDATESOURCE = feature.Update__Source'UPDATESOURCE
          DATEMODIFIED = feature.Date_Modified'DATEMODIFIED
          WHOMODIFIED = feature.Who_Modified'WHOMODIFIED
          ACCURACYCODE = feature.Accuracy_Code'ACCURACYCODE
          LOCATION = feature.LOCATION
          DIGITALPICTUREID = feature.DIGITALPICTUREID
          HYPERLINK_AR = feature.HYPERLINK_AR
          POND_ID = feature.PondID'POND_ID
          SUBTYPEFIELD = feature.SUBTYPEFIELD
          DRAINAGEAREA = feature.DRAINAGEAREA
          ACREAGE = feature.ACREAGE
          CAPACITY = feature.CAPACITY
          IMAGERYYEAR = feature.IMAGERYYEAR
          GLOBALID = feature.GLOBALID
          PONDYR = feature.PONDYR
          SHAPE_Length = feature.SHAPE_Length
          x = feature.maybe_x
          y = feature.maybe_y
          z = feature.maybe_z }

type Outfall_Drainage_Area_MS4_Feature =
    { OBJECTID: string option
      FACILITYID: string option
      ATTACHEDTOID: string option
      NOTES: string option
      ACRES: double option
      GLOBALID: string option
      Shape_Length: double option
      Shape_Area: double option
      x: double option
      y: double option
      z: double option }

    static member from_feature(feature:Feature) =
        { OBJECTID = feature.OBJECTID
          FACILITYID = feature.FACILITYID
          ATTACHEDTOID = feature.ATTACHEDTOID
          NOTES = feature.NOTES
          ACRES = feature.ACRES
          GLOBALID = feature.GLOBALID
          Shape_Length = feature.Shape_Length
          Shape_Area = feature.Shape_Area
          x = feature.maybe_x
          y = feature.maybe_y
          z = feature.maybe_z }

type Outfall_Drainage_Area_Feature =
    { OBJECTID: string option
      FACILITYID: string option
      ATTACHEDTOID: string option
      NOTES: string option
      ACRES: double option
      GLOBALID: string option
      SHAPE_Length: double option
      SHAPE_Area: double option
      x: double option
      y: double option
      z: double option }

    static member from_feature(feature:Feature) =
        { OBJECTID = feature.OBJECTID
          FACILITYID = feature.FACILITYID
          ATTACHEDTOID = feature.ATTACHEDTOID
          NOTES = feature.NOTES
          ACRES = feature.ACRES
          GLOBALID = feature.GLOBALID
          SHAPE_Length = feature.SHAPE_Length
          SHAPE_Area = feature.SHAPE_Area
          x = feature.maybe_x
          y = feature.maybe_y
          z = feature.maybe_z }

type Outfall_Drainage_Area_MOF_Feature =
    { OBJECTID: string option
      FACILITYID: string option
      ATTACHEDTOID: string option
      NOTES: string option
      ACRES: double option
      GLOBALID: string option
      Shape_Length: double option
      Shape_Area: double option
      x: double option
      y: double option
      z: double option }

    static member from_feature(feature:Feature) =
        { OBJECTID = feature.OBJECTID
          FACILITYID = feature.FACILITYID
          ATTACHEDTOID = feature.ATTACHEDTOID
          NOTES = feature.NOTES
          ACRES = feature.ACRES
          GLOBALID = feature.GLOBALID
          Shape_Length = feature.Shape_Length
          Shape_Area = feature.Shape_Area
          x = feature.maybe_x
          y = feature.maybe_y
          z = feature.maybe_z }

type Media_Points_Feature =
    { OBJECTID: string option
      HYD_ID: string option
      NOTES: string option
      FOLDER: string option
      RAW_NAME: string option
      FINAL_NAME: string option
      MEDIA_CODE: string option
      VIEW_: string option
      LOC_DESC: string option
      ELEMENTX: double option
      ELEMENTY: double option
      DATE_: DateTime option
      STORAGE_PATH_ADDR: string option
      FILE_NAME: string option
      STORAGE_FULL_PATH_ADDR: string option
      STORAGE_STATIC_PATH_ADDR: string option
      PHOTOID: string option
      FIELDCREW: string option
      CREATIONDATE: DateTime option
      CREATOR: string option
      EDITDATE: DateTime option
      EDITOR: string option
      STRUCTURE_ID: string option
      ROTATION_AZ: int16 option
      PHOTO_NUM: int16 option
      HYPERLINK: string option
      HOTLINK: string option
      GLOBALID: string option
      x: double option
      y: double option
      z: double option }

    static member from_feature(feature:Feature) =
        { OBJECTID = feature.OBJECTID
          HYD_ID = feature.Pond_Number'HYD_ID
          NOTES = feature.Notes'NOTES
          FOLDER = feature.Folder'FOLDER
          RAW_NAME = feature.Raw_Name'RAW_NAME
          FINAL_NAME = feature.Final_Name'FINAL_NAME
          MEDIA_CODE = feature.Media_Code'MEDIA_CODE
          VIEW_ = feature.View'VIEW_
          LOC_DESC = feature.Location'LOC_DESC
          ELEMENTX = feature.ELEMENTX
          ELEMENTY = feature.ELEMENTY
          DATE_ = feature.Date'DATE_
          STORAGE_PATH_ADDR = feature.Storage_Path_Address'STORAGE_PATH_ADDR
          FILE_NAME = feature.Filename'FILE_NAME
          STORAGE_FULL_PATH_ADDR = feature.STORAGE_FULL_PATH_ADDR
          STORAGE_STATIC_PATH_ADDR = feature.STORAGE_STATIC_PATH_ADDR
          PHOTOID = feature.PhotoID'PHOTOID
          FIELDCREW = feature.Company'FIELDCREW
          CREATIONDATE = feature.CreationDate'CREATIONDATE
          CREATOR = feature.Creator'CREATOR
          EDITDATE = feature.EditDate'EDITDATE
          EDITOR = feature.Editor'EDITOR
          STRUCTURE_ID = feature.Struct_ID'STRUCTURE_ID
          ROTATION_AZ = feature.Rotation_Az'ROTATION_AZ
          PHOTO_NUM = feature.PhotoNum'PHOTO_NUM
          HYPERLINK = feature.Hyperlink'HYPERLINK
          HOTLINK = feature.Hotlink'HOTLINK
          GLOBALID = feature.GlobalID'GLOBALID
          x = feature.maybe_x
          y = feature.maybe_y
          z = feature.maybe_z }

type Damage_Feature =
    { OBJECTID: string option
      PONDID: string option
      DESCRIPTION: string option
      PHOTOID: string option
      HOTLINK: string option
      DATAFILE: string option
      INSPDATE: DateTime option
      NORTHING: double option
      EASTING: double option
      INVENTORIED_BY: string option
      PHOTO_FOLDER: string option
      DAMAGEID: string option
      DAMAGETYPE: string option
      GLOBALID: string option
      x: double option
      y: double option
      z: double option }

    static member from_feature(feature:Feature) =
        { OBJECTID = feature.OBJECTID
          PONDID = feature.PondID'PONDID
          DESCRIPTION = feature.Notes'DESCRIPTION
          PHOTOID = feature.PhotoID'PHOTOID
          HOTLINK = feature.Hotlink'HOTLINK
          DATAFILE = feature.Datafile'DATAFILE
          INSPDATE = feature.Inspdate'INSPDATE
          NORTHING = feature.Northing'NORTHING
          EASTING = feature.Easting'EASTING
          INVENTORIED_BY = feature.Inventoried_by'INVENTORIED_BY
          PHOTO_FOLDER = feature.Photo_Folder'PHOTO_FOLDER
          DAMAGEID = feature.DamageID'DAMAGEID
          DAMAGETYPE = feature.DamageType'DAMAGETYPE
          GLOBALID = feature.GLOBALID
          x = feature.maybe_x
          y = feature.maybe_y
          z = feature.maybe_z }

type Outfall_Feature =
    { OBJECTID: string option
      FACILITYID: string option
      ATTACHEDTOID: string option
      UPSTREAMSTUCTUREID: string option
      OUTFALLTYPE: string option
      WATERBODYNAME: string option
      WBID: string option
      DRAINAGEBASIN: string option
      NOTES: string option
      GLOBALID: string option
      STRUCTURETYPE: string option
      OUTFALLID: string option
      UNITID: string option
      x: double option
      y: double option
      z: double option }

    static member from_feature(feature:Feature) =
        { OBJECTID = feature.OBJECTID
          FACILITYID = feature.FACILITYID
          ATTACHEDTOID = feature.ATTACHEDTOID
          UPSTREAMSTUCTUREID = feature.UPSTREAMSTUCTUREID
          OUTFALLTYPE = feature.OUTFALLTYPE
          WATERBODYNAME = feature.WATERBODYNAME
          WBID = feature.WBID
          DRAINAGEBASIN = feature.DRAINAGEBASIN
          NOTES = feature.NOTES
          GLOBALID = feature.GLOBALID
          STRUCTURETYPE = feature.STRUCTURETYPE
          OUTFALLID = feature.OUTFALLID
          UNITID = feature.UNITID
          x = feature.maybe_x
          y = feature.maybe_y
          z = feature.maybe_z }

type Stormwater_Pond_Feature =
    { OBJECTID: string option
      ANCILLARYROLE: int16 option
      ENABLED: int16 option
      LIFECYCLE: string option
      PARENTID: string option
      OWNER: string option
      MAINTBY: string option
      SOURCE: string option
      FACILITYID: string option
      LEGACYID: string option
      EASTING: double option
      NORTHING: double option
      NOTES: string option
      PONDTYPE: string option
      PARCELID: string option
      ACTIVITY: string option
      FILTER: int16 option
      FILTERTYPE: string option
      FILTERLOCATION: string option
      ORIGINALSOURCE: string option
      DATECREATED: DateTime option
      WHOCREATED: string option
      UPDATESOURCE: string option
      DATEMODIFIED: DateTime option
      WHOMODIFIED: string option
      ACCURACYCODE: string option
      LOCATION: string option
      GLOBALID: string option
      SUBTYPEFIELD: int option
      ZVALUE: double option
      Z29: double option
      PONDID: string option
      DRAINAGE_AREA: double option
      ACREAGE: double option
      CAPACITY: double option
      IMAGERYYEAR: string option
      UNITDESC: string option
      UNITID: string option
      x: double option
      y: double option
      z: double option }

    static member from_feature(feature:Feature) =
        { OBJECTID = feature.OBJECTID
          ANCILLARYROLE = feature.AncillaryRole'ANCILLARYROLE
          ENABLED = feature.Enabled'ENABLED
          LIFECYCLE = feature.Lifecycle'LIFECYCLE
          PARENTID = feature.PARENTID
          OWNER = feature.Owner'OWNER
          MAINTBY = feature.MaintBy'MAINTBY
          SOURCE = feature.Source'SOURCE
          FACILITYID = feature.FACILITYID
          LEGACYID = feature.LEGACYID
          EASTING = feature.EASTING
          NORTHING = feature.NORTHING
          NOTES = feature.NOTES
          PONDTYPE = feature.PondType'PONDTYPE
          PARCELID = feature.PARCELID
          ACTIVITY = feature.ACTIVITY
          FILTER = feature.Filter'FILTER
          FILTERTYPE = feature.FILTERTYPE
          FILTERLOCATION = feature.FilterLocation'FILTERLOCATION
          ORIGINALSOURCE = feature.Original_Source'ORIGINALSOURCE
          DATECREATED = feature.Date_Created'DATECREATED
          WHOCREATED = feature.Who_Created'WHOCREATED
          UPDATESOURCE = feature.Update__Source'UPDATESOURCE
          DATEMODIFIED = feature.Date_Modified'DATEMODIFIED
          WHOMODIFIED = feature.Who_Modified'WHOMODIFIED
          ACCURACYCODE = feature.Accuracy_Code'ACCURACYCODE
          LOCATION = feature.LOCATION
          GLOBALID = feature.GLOBALID
          SUBTYPEFIELD = feature.SUBTYPEFIELD
          ZVALUE = feature.ZVALUE
          Z29 = feature.Z29
          PONDID = feature.PONDID
          DRAINAGE_AREA = feature.DRAINAGE_AREA
          ACREAGE = feature.ACREAGE
          CAPACITY = feature.CAPACITY
          IMAGERYYEAR = feature.IMAGERYYEAR
          UNITDESC = feature.UNITDESC
          UNITID = feature.UNITID
          x = feature.maybe_x
          y = feature.maybe_y
          z = feature.maybe_z }

type End_Point_Feature =
    { OBJECTID: string option
      ANCILLARYROLE: int16 option
      LIFECYCLE: string option
      PARENTID: string option
      OWNER: string option
      MAINTBY: string option
      SOURCE: string option
      FACILITYID: string option
      LEGACYID: string option
      LOCATION: string option
      INVENTORYDATE: DateTime option
      INVENTORYTYPE: string option
      EASTING: double option
      NORTHING: double option
      INFILTRATION: int16 option
      DIGITALPICTUREID: string option
      FIELDCOMPLETE: int16 option
      ATTRIBUTECOMPLETE: int16 option
      NOTES: string option
      PRFRESOLUTION: string option
      DRAWINGID: string option
      ORIGINALSOURCE: string option
      DATECREATED: DateTime option
      WHOCREATED: string option
      UPDATESOURCE: string option
      DATEMODIFIED: DateTime option
      WHOMODIFIED: string option
      ACCURACYCODE: string option
      MATERIAL: string option
      ISINFALL: int16 option
      RELATEDFEATURE: string option
      HYPERLINK_AR: string option
      OBSTRUCTION: string option
      CREW: string option
      ENABLED: int16 option
      NEEDSATTENTION: int16 option
      SUBTYPEFIELD: int option
      ZVALUE: double option
      FIELDCOMMENTS: string option
      IMAGERYYEAR: string option
      GLOBALID: string option
      STRUCTUREID: string option
      OUTFALLID: string option
      UNITID: string option
      x: double option
      y: double option
      z: double option }

    static member from_feature(feature:Feature) =
        { OBJECTID = feature.OBJECTID
          ANCILLARYROLE = feature.AncillaryRole'ANCILLARYROLE
          LIFECYCLE = feature.Lifecycle'LIFECYCLE
          PARENTID = feature.PARENTID
          OWNER = feature.Owner'OWNER
          MAINTBY = feature.MaintBy'MAINTBY
          SOURCE = feature.Source'SOURCE
          FACILITYID = feature.FACILITYID
          LEGACYID = feature.LEGACYID
          LOCATION = feature.LOCATION
          INVENTORYDATE = feature.INVENTORYDATE
          INVENTORYTYPE = feature.InventoryType'INVENTORYTYPE
          EASTING = feature.EASTING
          NORTHING = feature.NORTHING
          INFILTRATION = feature.``Inflow\Infiltration'INFILTRATION``
          DIGITALPICTUREID = feature.DIGITALPICTUREID
          FIELDCOMPLETE = feature.FieldComplete'FIELDCOMPLETE
          ATTRIBUTECOMPLETE = feature.AttributeComplete'ATTRIBUTECOMPLETE
          NOTES = feature.NOTES
          PRFRESOLUTION = feature.PRFResolution'PRFRESOLUTION
          DRAWINGID = feature.Drawing_ID'DRAWINGID
          ORIGINALSOURCE = feature.ORIGINALSOURCE
          DATECREATED = feature.DATECREATED
          WHOCREATED = feature.WhoCreated'WHOCREATED
          UPDATESOURCE = feature.UPDATESOURCE
          DATEMODIFIED = feature.DATEMODIFIED
          WHOMODIFIED = feature.WHOMODIFIED
          ACCURACYCODE = feature.AccuracyCode'ACCURACYCODE
          MATERIAL = feature.Material'MATERIAL
          ISINFALL = feature.IsInfall'ISINFALL
          RELATEDFEATURE = feature.RelatedFeature'RELATEDFEATURE
          HYPERLINK_AR = feature.HYPERLINK_AR
          OBSTRUCTION = feature.OBSTRUCTION
          CREW = feature.Crew'CREW
          ENABLED = feature.ENABLED
          NEEDSATTENTION = feature.NeedsAttention'NEEDSATTENTION
          SUBTYPEFIELD = feature.SUBTYPEFIELD
          ZVALUE = feature.ZValue'ZVALUE
          FIELDCOMMENTS = feature.FieldComments'FIELDCOMMENTS
          IMAGERYYEAR = feature.IMAGERYYEAR
          GLOBALID = feature.GLOBALID
          STRUCTUREID = feature.STRUCTUREID
          OUTFALLID = feature.OUTFALLID
          UNITID = feature.UNITID
          x = feature.maybe_x
          y = feature.maybe_y
          z = feature.maybe_z }

type Inlet_Feature =
    { OBJECTID: string option
      ANCILLARYROLE: int16 option
      LIFECYCLE: string option
      PARENTID: string option
      OWNER: string option
      MAINTBY: string option
      SOURCE: string option
      FACILITYID: string option
      LEGACYID: string option
      LOCATION: string option
      INVENTORYDATE: DateTime option
      INVENTORYTYPE: string option
      EASTING: double option
      NORTHING: double option
      INFILTRATION: int16 option
      DIGITALPICTUREID: string option
      FIELDCOMPLETE: int16 option
      ATTRIBUTECOMPLETE: int16 option
      NOTES: string option
      PRFRESOLUTION: string option
      DRAWINGID: string option
      ORIGINALSOURCE: string option
      DATECREATED: DateTime option
      WHOCREATED: string option
      UPDATESOURCE: string option
      DATEMODIFIED: DateTime option
      WHOMODIFIED: string option
      ACCURACYCODE: string option
      MATERIAL: string option
      RELATEDFEATURE: string option
      HYPERLINK_AR: string option
      OBSTRUCTION: string option
      CREW: string option
      FIELDCOMMENTS: string option
      ZVALUE: double option
      SUBTYPEFIELD: int option
      STRCT_DEPTH: double option
      UNDERDRAINS: double option
      SLOT_ELEV: double option
      INVERTELEV: double option
      ISINFALL: int option
      INVERT_ELEV29: double option
      ENABLED: int16 option
      NEEDSATTENTION: int16 option
      PLACE: string option
      PID_1: string option
      IMAGERYYEAR: string option
      GLOBALID: string option
      STRUCTUREID: string option
      OUTFALLID: string option
      UNITID: string option
      x: double option
      y: double option
      z: double option }

    static member from_feature(feature:Feature) =
        { OBJECTID = feature.OBJECTID
          ANCILLARYROLE = feature.AncillaryRole'ANCILLARYROLE
          LIFECYCLE = feature.Lifecycle'LIFECYCLE
          PARENTID = feature.PARENTID
          OWNER = feature.Owner'OWNER
          MAINTBY = feature.MaintBy'MAINTBY
          SOURCE = feature.Source'SOURCE
          FACILITYID = feature.FACILITYID
          LEGACYID = feature.LEGACYID
          LOCATION = feature.LOCATION
          INVENTORYDATE = feature.INVENTORYDATE
          INVENTORYTYPE = feature.InventoryType'INVENTORYTYPE
          EASTING = feature.EASTING
          NORTHING = feature.NORTHING
          INFILTRATION = feature.``Inflow\Infiltration'INFILTRATION``
          DIGITALPICTUREID = feature.DIGITALPICTUREID
          FIELDCOMPLETE = feature.FieldComplete'FIELDCOMPLETE
          ATTRIBUTECOMPLETE = feature.AttributeComplete'ATTRIBUTECOMPLETE
          NOTES = feature.NOTES
          PRFRESOLUTION = feature.PRFResolution'PRFRESOLUTION
          DRAWINGID = feature.Drawing_ID'DRAWINGID
          ORIGINALSOURCE = feature.ORIGINALSOURCE
          DATECREATED = feature.DATECREATED
          WHOCREATED = feature.WhoCreated'WHOCREATED
          UPDATESOURCE = feature.UPDATESOURCE
          DATEMODIFIED = feature.DATEMODIFIED
          WHOMODIFIED = feature.WHOMODIFIED
          ACCURACYCODE = feature.AccuracyCode'ACCURACYCODE
          MATERIAL = feature.Material'MATERIAL
          RELATEDFEATURE = feature.RelatedFeature'RELATEDFEATURE
          HYPERLINK_AR = feature.HYPERLINK_AR
          OBSTRUCTION = feature.OBSTRUCTION
          CREW = feature.CREW
          FIELDCOMMENTS = feature.FIELDCOMMENTS
          ZVALUE = feature.ZVALUE
          SUBTYPEFIELD = feature.SUBTYPEFIELD
          STRCT_DEPTH = feature.STRCT_DEPTH
          UNDERDRAINS = feature.UNDERDRAINS
          SLOT_ELEV = feature.SLOT_ELEV
          INVERTELEV = feature.INVERTELEV
          ISINFALL = feature.ISINFALL
          INVERT_ELEV29 = feature.INVERT_ELEV29
          ENABLED = feature.ENABLED
          NEEDSATTENTION = feature.NEEDSATTENTION
          PLACE = feature.PLACE
          PID_1 = feature.PID_1
          IMAGERYYEAR = feature.IMAGERYYEAR
          GLOBALID = feature.GLOBALID
          STRUCTUREID = feature.STRUCTUREID
          OUTFALLID = feature.OUTFALLID
          UNITID = feature.UNITID
          x = feature.maybe_x
          y = feature.maybe_y
          z = feature.maybe_z }

type Debris_Trap_Feature =
    { OBJECTID: string option
      LIFECYCLE: string option
      PARENTID: string option
      OWNER: string option
      MAINTBY: string option
      SOURCE: string option
      FACILITYID: string option
      LEGACYID: string option
      ATTACHEDTOID: string option
      NEEDSATTENTION: int16 option
      LOCATION: string option
      INVENTORYDATE: DateTime option
      INVENTORYTYPE: string option
      EASTING: double option
      NORTHING: double option
      DIGITALPICTUREID: string option
      FIELDCOMPLETE: int16 option
      ATTRIBUTECOMPLETE: int16 option
      NOTES: string option
      PRFRESOLUTION: string option
      ORIGINALSOURCE: string option
      DATECREATED: DateTime option
      WHOCREATED: string option
      UPDATESOURCE: string option
      DATEMODIFIED: DateTime option
      WHOMODIFIED: string option
      ACCURACYCODE: string option
      HYPERLINK_AR: string option
      FIELDCOMMENTS: string option
      ZVALUE: double option
      Z29: double option
      IMAGERYYEAR: string option
      GLOBALID: string option
      OUTFALLID: string option
      UNITID: string option
      x: double option
      y: double option
      z: double option }

    static member from_feature(feature:Feature) =
        { OBJECTID = feature.OBJECTID
          LIFECYCLE = feature.Lifecycle'LIFECYCLE
          PARENTID = feature.PARENTID
          OWNER = feature.Owner'OWNER
          MAINTBY = feature.MaintBy'MAINTBY
          SOURCE = feature.Source'SOURCE
          FACILITYID = feature.FACILITYID
          LEGACYID = feature.LEGACYID
          ATTACHEDTOID = feature.ATTACHEDTOID
          NEEDSATTENTION = feature.NeedsAttention'NEEDSATTENTION
          LOCATION = feature.LOCATION
          INVENTORYDATE = feature.INVENTORYDATE
          INVENTORYTYPE = feature.InventoryType'INVENTORYTYPE
          EASTING = feature.EASTING
          NORTHING = feature.NORTHING
          DIGITALPICTUREID = feature.DIGITALPICTUREID
          FIELDCOMPLETE = feature.FieldComplete'FIELDCOMPLETE
          ATTRIBUTECOMPLETE = feature.AttributeComplete'ATTRIBUTECOMPLETE
          NOTES = feature.NOTES
          PRFRESOLUTION = feature.PRFResolution'PRFRESOLUTION
          ORIGINALSOURCE = feature.ORIGINALSOURCE
          DATECREATED = feature.DATECREATED
          WHOCREATED = feature.WhoCreated'WHOCREATED
          UPDATESOURCE = feature.UPDATESOURCE
          DATEMODIFIED = feature.DATEMODIFIED
          WHOMODIFIED = feature.WHOMODIFIED
          ACCURACYCODE = feature.AccuracyCode'ACCURACYCODE
          HYPERLINK_AR = feature.HYPERLINK_AR
          FIELDCOMMENTS = feature.FIELDCOMMENTS
          ZVALUE = feature.ZVALUE
          Z29 = feature.Z29
          IMAGERYYEAR = feature.IMAGERYYEAR
          GLOBALID = feature.GLOBALID
          OUTFALLID = feature.OUTFALLID
          UNITID = feature.UNITID
          x = feature.maybe_x
          y = feature.maybe_y
          z = feature.maybe_z }

type Junction_Fixed_Feature =
    { OBJECTID: string option
      ANCILLARYROLE: int16 option
      ENABLED: int16 option
      LIFECYCLE: string option
      PARENTID: string option
      OWNER: string option
      MAINTBY: string option
      SOURCE: string option
      FACILITYID: string option
      NEEDSATTENTION: int16 option
      LOCATION: string option
      INVENTORYDATE: DateTime option
      INVENTORYTYPE: string option
      EASTING: double option
      NORTHING: double option
      INFILTRATION: int16 option
      DIGITALPICTUREID: string option
      FIELDCOMPLETE: int16 option
      ATTRIBUTECOMPLETE: int16 option
      NOTES: string option
      DRAWINGID: string option
      ORIGINALSOURCE: string option
      DATECREATED: DateTime option
      WHOCREATED: string option
      UPDATESOURCE: string option
      DATEMODIFIED: DateTime option
      WHOMODIFIED: string option
      ACCURACYCODE: string option
      MATERIAL: string option
      RELATEDFEATURE: string option
      HYPERLINK_AR: string option
      CREW: string option
      LEGACY_ID: string option
      SUBTYPEFIELD: int option
      FIELDCOMMENTS: string option
      ZVALUE: double option
      PRFRESOLUTION: string option
      STRCT_DEPTH: double option
      OBSTRUCTION: string option
      INVERT_ELEV: double option
      ISINFALL: int option
      IMAGERYYEAR: string option
      GLOBALID: string option
      STRUCTUREID: string option
      OUTFALLID: string option
      UNITID: string option
      x: double option
      y: double option
      z: double option }

    static member from_feature(feature:Feature) =
        { OBJECTID = feature.OBJECTID
          ANCILLARYROLE = feature.AncillaryRole'ANCILLARYROLE
          ENABLED = feature.Enabled'ENABLED
          LIFECYCLE = feature.Lifecycle'LIFECYCLE
          PARENTID = feature.PARENTID
          OWNER = feature.Owner'OWNER
          MAINTBY = feature.MaintBy'MAINTBY
          SOURCE = feature.Source'SOURCE
          FACILITYID = feature.FACILITYID
          NEEDSATTENTION = feature.NeedsAttention'NEEDSATTENTION
          LOCATION = feature.LOCATION
          INVENTORYDATE = feature.INVENTORYDATE
          INVENTORYTYPE = feature.InventoryType'INVENTORYTYPE
          EASTING = feature.EASTING
          NORTHING = feature.NORTHING
          INFILTRATION = feature.``Inflow\Infiltration'INFILTRATION``
          DIGITALPICTUREID = feature.DIGITALPICTUREID
          FIELDCOMPLETE = feature.FieldComplete'FIELDCOMPLETE
          ATTRIBUTECOMPLETE = feature.AttributeComplete'ATTRIBUTECOMPLETE
          NOTES = feature.NOTES
          DRAWINGID = feature.Drawing_ID'DRAWINGID
          ORIGINALSOURCE = feature.ORIGINALSOURCE
          DATECREATED = feature.DATECREATED
          WHOCREATED = feature.WhoCreated'WHOCREATED
          UPDATESOURCE = feature.UPDATESOURCE
          DATEMODIFIED = feature.DATEMODIFIED
          WHOMODIFIED = feature.WHOMODIFIED
          ACCURACYCODE = feature.AccuracyCode'ACCURACYCODE
          MATERIAL = feature.Material'MATERIAL
          RELATEDFEATURE = feature.RelatedFeature'RELATEDFEATURE
          HYPERLINK_AR = feature.HYPERLINK_AR
          CREW = feature.CREW
          LEGACY_ID = feature.LegacyID'LEGACY_ID
          SUBTYPEFIELD = feature.SubtypeField'SUBTYPEFIELD
          FIELDCOMMENTS = feature.FIELDCOMMENTS
          ZVALUE = feature.ZVALUE
          PRFRESOLUTION = feature.PRFRESOLUTION
          STRCT_DEPTH = feature.STRCT_DEPTH
          OBSTRUCTION = feature.OBSTRUCTION
          INVERT_ELEV = feature.INVERT_ELEV
          ISINFALL = feature.ISINFALL
          IMAGERYYEAR = feature.IMAGERYYEAR
          GLOBALID = feature.GLOBALID
          STRUCTUREID = feature.STRUCTUREID
          OUTFALLID = feature.OUTFALLID
          UNITID = feature.UNITID
          x = feature.maybe_x
          y = feature.maybe_y
          z = feature.maybe_z }

type Connectivity_Feature =
    { OBJECTID: string option
      ENABLED: int16 option
      LIFECYCLE: string option
      PARENTID: string option
      OWNER: string option
      SOURCE: string option
      FACILITYID: string option
      LEGACYID: string option
      NOTES: string option
      SUBTYPEFIELD: int option
      IMAGERYYEAR: string option
      GLOBALID: string option
      SHAPE_Length: double option
      x: double option
      y: double option
      z: double option }

    static member from_feature(feature:Feature) =
        { OBJECTID = feature.OBJECTID
          ENABLED = feature.Enabled'ENABLED
          LIFECYCLE = feature.Lifecycle'LIFECYCLE
          PARENTID = feature.PARENTID
          OWNER = feature.Owner'OWNER
          SOURCE = feature.Source'SOURCE
          FACILITYID = feature.FACILITYID
          LEGACYID = feature.LEGACYID
          NOTES = feature.NOTES
          SUBTYPEFIELD = feature.SubtypeField'SUBTYPEFIELD
          IMAGERYYEAR = feature.IMAGERYYEAR
          GLOBALID = feature.GLOBALID
          SHAPE_Length = feature.SHAPE_Length
          x = feature.maybe_x
          y = feature.maybe_y
          z = feature.maybe_z }

type Generic_Storm_Asset_Feature =
    { OBJECTID: string option
      ANCILLARYROLE: int16 option
      ENABLED: int16 option
      LIFECYCLE: string option
      PARENTID: string option
      OWNER: string option
      MAINTBY: string option
      SOURCE: string option
      FACILITYID: string option
      LEGACYID: string option
      SUBTYPEFIELD: int option
      EASTING: double option
      NORTHING: double option
      ZVALUE: double option
      Z29: double option
      NOTES: string option
      INVENTORYDATE: DateTime option
      FIELDCOMMENTS: string option
      PRFRESOLUTION: string option
      IMAGERYYEAR: string option
      GLOBALID: string option
      STRUCTUREID: string option
      x: double option
      y: double option
      z: double option }

    static member from_feature(feature:Feature) =
        { OBJECTID = feature.OBJECTID
          ANCILLARYROLE = feature.AncillaryRole'ANCILLARYROLE
          ENABLED = feature.Enabled'ENABLED
          LIFECYCLE = feature.Lifecycle'LIFECYCLE
          PARENTID = feature.PARENTID
          OWNER = feature.Owner'OWNER
          MAINTBY = feature.MaintBy'MAINTBY
          SOURCE = feature.Source'SOURCE
          FACILITYID = feature.FACILITYID
          LEGACYID = feature.LEGACYID
          SUBTYPEFIELD = feature.SubtypeField'SUBTYPEFIELD
          EASTING = feature.EASTING
          NORTHING = feature.NORTHING
          ZVALUE = feature.ZVALUE
          Z29 = feature.Z29
          NOTES = feature.NOTES
          INVENTORYDATE = feature.Location_Date'INVENTORYDATE
          FIELDCOMMENTS = feature.FieldComments'FIELDCOMMENTS
          PRFRESOLUTION = feature.PRFResolution'PRFRESOLUTION
          IMAGERYYEAR = feature.IMAGERYYEAR
          GLOBALID = feature.GLOBALID
          STRUCTUREID = feature.StructureID'STRUCTUREID
          x = feature.maybe_x
          y = feature.maybe_y
          z = feature.maybe_z }

type Stormwater_Pond_Discharge_Feature =
    { OBJECTID: string option
      ANCILLARYROLE: int16 option
      ENABLED: int16 option
      LIFECYCLE: string option
      PARENTID: string option
      OWNER: string option
      MAINTBY: string option
      SOURCE: string option
      FACILITYID: string option
      LEGACYID: string option
      NEEDSATTENTION: int16 option
      LOCATION: string option
      INVENTORYDATE: DateTime option
      INVENTORYTYPE: string option
      EASTING: double option
      NORTHING: double option
      Z29: double option
      INFILTRATION: int16 option
      DIGITALPICTUREID: string option
      FIELDCOMPLETE: int16 option
      ATTRIBUTECOMPLETE: int16 option
      NOTES: string option
      DRAWINGID: string option
      ORIGINALSOURCE: string option
      DATECREATED: DateTime option
      WHOCREATED: string option
      UPDATESOURCE: string option
      DATEMODIFIED: DateTime option
      WHOMODIFIED: string option
      ACCURACYCODE: string option
      HYPERLINK_AR: string option
      DIGITALPICTUREID_S: string option
      DIGITALPICTUREID_E: string option
      DIGITALPICTUREID_W: string option
      SUBTYPEFIELD: int option
      FIELDCOMMENTS: string option
      ZVALUE: double option
      PRFRESOLUTION: string option
      IMAGERYYEAR: string option
      GLOBALID: string option
      STRUCTUREID: string option
      OUTFALLID: string option
      STRUCTURETYPE: string option
      UNITID: string option
      x: double option
      y: double option
      z: double option }

    static member from_feature(feature:Feature) =
        { OBJECTID = feature.OBJECTID
          ANCILLARYROLE = feature.AncillaryRole'ANCILLARYROLE
          ENABLED = feature.Enabled'ENABLED
          LIFECYCLE = feature.Lifecycle'LIFECYCLE
          PARENTID = feature.PARENTID
          OWNER = feature.Owner'OWNER
          MAINTBY = feature.MaintBy'MAINTBY
          SOURCE = feature.Source'SOURCE
          FACILITYID = feature.FACILITYID
          LEGACYID = feature.LEGACYID
          NEEDSATTENTION = feature.NeedsAttention'NEEDSATTENTION
          LOCATION = feature.LOCATION
          INVENTORYDATE = feature.INVENTORYDATE
          INVENTORYTYPE = feature.InventoryType'INVENTORYTYPE
          EASTING = feature.EASTING
          NORTHING = feature.NORTHING
          Z29 = feature.Z29
          INFILTRATION = feature.``Inflow\Infiltration'INFILTRATION``
          DIGITALPICTUREID = feature.DIGITALPICTUREID
          FIELDCOMPLETE = feature.FieldComplete'FIELDCOMPLETE
          ATTRIBUTECOMPLETE = feature.AttributeComplete'ATTRIBUTECOMPLETE
          NOTES = feature.NOTES
          DRAWINGID = feature.Drawing_ID'DRAWINGID
          ORIGINALSOURCE = feature.ORIGINALSOURCE
          DATECREATED = feature.DATECREATED
          WHOCREATED = feature.WhoCreated'WHOCREATED
          UPDATESOURCE = feature.UPDATESOURCE
          DATEMODIFIED = feature.DATEMODIFIED
          WHOMODIFIED = feature.WHOMODIFIED
          ACCURACYCODE = feature.AccuracyCode'ACCURACYCODE
          HYPERLINK_AR = feature.HYPERLINK_AR
          DIGITALPICTUREID_S = feature.DIGITALPICTUREID_2'DIGITALPICTUREID_S
          DIGITALPICTUREID_E = feature.DIGITALPICTUREID_3'DIGITALPICTUREID_E
          DIGITALPICTUREID_W = feature.DIGITALPICTUREID_4'DIGITALPICTUREID_W
          SUBTYPEFIELD = feature.SUBTYPEFIELD
          FIELDCOMMENTS = feature.FIELDCOMMENTS
          ZVALUE = feature.ZVALUE
          PRFRESOLUTION = feature.PRFRESOLUTION
          IMAGERYYEAR = feature.IMAGERYYEAR
          GLOBALID = feature.GLOBALID
          STRUCTUREID = feature.STRUCTUREID
          OUTFALLID = feature.OUTFALLID
          STRUCTURETYPE = feature.STRUCTURETYPE
          UNITID = feature.UNITID
          x = feature.maybe_x
          y = feature.maybe_y
          z = feature.maybe_z }

type Private_Point_Feature =
    { OBJECTID: string option
      ANCILLARYROLE: int16 option
      ENABLED: int16 option
      LIFECYCLE: string option
      PARENTID: string option
      OWNER: string option
      MAINTBY: string option
      SOURCE: string option
      FACILITYID: string option
      LEGACYID: string option
      SUBTYPEFIELD: int option
      EASTING: double option
      NORTHING: double option
      ZVALUE: double option
      Z29: double option
      NOTES: string option
      IMAGERYYEAR: string option
      GLOBALID: string option
      x: double option
      y: double option
      z: double option }

    static member from_feature(feature:Feature) =
        { OBJECTID = feature.OBJECTID
          ANCILLARYROLE = feature.AncillaryRole'ANCILLARYROLE
          ENABLED = feature.Enabled'ENABLED
          LIFECYCLE = feature.Lifecycle'LIFECYCLE
          PARENTID = feature.PARENTID
          OWNER = feature.Owner'OWNER
          MAINTBY = feature.MaintBy'MAINTBY
          SOURCE = feature.Source'SOURCE
          FACILITYID = feature.FACILITYID
          LEGACYID = feature.LEGACYID
          SUBTYPEFIELD = feature.SubtypeField'SUBTYPEFIELD
          EASTING = feature.EASTING
          NORTHING = feature.NORTHING
          ZVALUE = feature.ZVALUE
          Z29 = feature.Z29
          NOTES = feature.NOTES
          IMAGERYYEAR = feature.IMAGERYYEAR
          GLOBALID = feature.GLOBALID
          x = feature.maybe_x
          y = feature.maybe_y
          z = feature.maybe_z }

type Conduit_Feature =
    { OBJECTID: string option
      ENABLED: int16 option
      LIFECYCLE: string option
      PARENTID: string option
      ACCEPT_DATE: string option
      OWNER: string option
      MAINTBY: string option
      SOURCE: string option
      FACILITYID: string option
      LEGACYID: string option
      INVENTORYDATE: DateTime option
      DIGITALPICTUREID: string option
      FIELDCOMPLETE: int16 option
      ATTRIBUTECOMPLETE: int16 option
      NOTES: string option
      DRAWINGID: string option
      ORIGINALSOURCE: string option
      DATECREATED: DateTime option
      WHOCREATED: string option
      UPDATESOURCE: string option
      DATEMODIFIED: DateTime option
      ACCURACYCODE: string option
      WHOMODIFIED: string option
      MATERIAL: string option
      PIPESHAPE: string option
      DIAMETER: int16 option
      NEEDSATTENTION: int16 option
      FIELD_COMMENTS_: string option
      SUBTYPEFIELD: int option
      UPSTREAMDEPTH: double option
      UPSTREAMELEVATION: double option
      DOWNSTREAMDEPTH: double option
      DOWNSTREAMELEVATION: double option
      LFEET: double option
      PERCT_GRD: double option
      WIDTH: double option
      HEIGHT: double option
      IMAGERYYEAR: string option
      GLOBALID: string option
      OUTFALLID: string option
      UNITID: string option
      SHAPE_Length: double option
      x: double option
      y: double option
      z: double option }

    static member from_feature(feature:Feature) =
        { OBJECTID = feature.OBJECTID
          ENABLED = feature.Enabled'ENABLED
          LIFECYCLE = feature.Lifecycle'LIFECYCLE
          PARENTID = feature.PARENTID
          ACCEPT_DATE = feature.ACCEPT_DATE
          OWNER = feature.Owner'OWNER
          MAINTBY = feature.MaintBy'MAINTBY
          SOURCE = feature.Source'SOURCE
          FACILITYID = feature.FACILITYID
          LEGACYID = feature.LEGACYID
          INVENTORYDATE = feature.INVENTORYDATE
          DIGITALPICTUREID = feature.DIGITALPICTUREID
          FIELDCOMPLETE = feature.FieldComplete'FIELDCOMPLETE
          ATTRIBUTECOMPLETE = feature.AttributeComplete'ATTRIBUTECOMPLETE
          NOTES = feature.NOTES
          DRAWINGID = feature.DRAWINGID
          ORIGINALSOURCE = feature.ORIGINALSOURCE
          DATECREATED = feature.DATECREATED
          WHOCREATED = feature.WhoCreated'WHOCREATED
          UPDATESOURCE = feature.UPDATESOURCE
          DATEMODIFIED = feature.DATEMODIFIED
          ACCURACYCODE = feature.AccuracyCode'ACCURACYCODE
          WHOMODIFIED = feature.WHOMODIFIED
          MATERIAL = feature.Material'MATERIAL
          PIPESHAPE = feature.PipeShape'PIPESHAPE
          DIAMETER = feature.Diameter'DIAMETER
          NEEDSATTENTION = feature.NeedsAttention'NEEDSATTENTION
          FIELD_COMMENTS_ = feature.FieldComments'FIELD_COMMENTS_
          SUBTYPEFIELD = feature.SubtypeField'SUBTYPEFIELD
          UPSTREAMDEPTH = feature.UPSTREAMDEPTH
          UPSTREAMELEVATION = feature.UPSTREAMELEVATION
          DOWNSTREAMDEPTH = feature.DOWNSTREAMDEPTH
          DOWNSTREAMELEVATION = feature.DOWNSTREAMELEVATION
          LFEET = feature.LFEET
          PERCT_GRD = feature.PERCT_GRD
          WIDTH = feature.WIDTH
          HEIGHT = feature.HEIGHT
          IMAGERYYEAR = feature.IMAGERYYEAR
          GLOBALID = feature.GLOBALID
          OUTFALLID = feature.OUTFALLID
          UNITID = feature.UNITID
          SHAPE_Length = feature.SHAPE_Length
          x = feature.maybe_x
          y = feature.maybe_y
          z = feature.maybe_z }

type Culvert_Cross_Drain_Feature =
    { OBJECTID: string option
      ENABLED: int16 option
      LIFECYCLE: string option
      PARENTID: string option
      OWNER: string option
      MAINTBY: string option
      SOURCE: string option
      FACILITYID: string option
      LEGACYID: string option
      INVENTORYDATE: DateTime option
      DIGITALPICTUREID: string option
      FIELDCOMPLETE: int16 option
      ATTRIBUTECOMPLETE: int16 option
      NOTES: string option
      DRAWINGID: string option
      ORIGINALSOURCE: string option
      DATECREATED: DateTime option
      WHOCREATED: string option
      UPDATESOURCE: string option
      DATEMODIFIED: DateTime option
      ACCURACYCODE: string option
      WHOMODIFIED: string option
      MATERIAL: string option
      PIPESHAPE: string option
      DIAMETER: int16 option
      NEEDSATTENTION: int16 option
      FIELD_COMMENTS_: string option
      SUBTYPEFIELD: int option
      WIDTH: double option
      HEIGHT: double option
      ACCEPT_DATE: string option
      UPSTREAM_ELEV: double option
      UPSTREAM_DEPTH: double option
      DOWNSTREAM_ELEV: double option
      DOWNSTREAM_DEPTH: double option
      NUM_BARRELS: int option
      IMAGERYYEAR: string option
      GLOBALID: string option
      LFEET: double option
      PERCT_GRD: double option
      OUTFALLID: string option
      UNITID: string option
      SHAPE_Length: double option
      x: double option
      y: double option
      z: double option }

    static member from_feature(feature:Feature) =
        { OBJECTID = feature.OBJECTID
          ENABLED = feature.Enabled'ENABLED
          LIFECYCLE = feature.Lifecycle'LIFECYCLE
          PARENTID = feature.PARENTID
          OWNER = feature.Owner'OWNER
          MAINTBY = feature.MaintBy'MAINTBY
          SOURCE = feature.Source'SOURCE
          FACILITYID = feature.FACILITYID
          LEGACYID = feature.LEGACYID
          INVENTORYDATE = feature.INVENTORYDATE
          DIGITALPICTUREID = feature.DIGITALPICTUREID
          FIELDCOMPLETE = feature.FieldComplete'FIELDCOMPLETE
          ATTRIBUTECOMPLETE = feature.AttributeComplete'ATTRIBUTECOMPLETE
          NOTES = feature.NOTES
          DRAWINGID = feature.DRAWINGID
          ORIGINALSOURCE = feature.ORIGINALSOURCE
          DATECREATED = feature.DATECREATED
          WHOCREATED = feature.WhoCreated'WHOCREATED
          UPDATESOURCE = feature.UPDATESOURCE
          DATEMODIFIED = feature.DATEMODIFIED
          ACCURACYCODE = feature.AccuracyCode'ACCURACYCODE
          WHOMODIFIED = feature.WHOMODIFIED
          MATERIAL = feature.Material'MATERIAL
          PIPESHAPE = feature.PipeShape'PIPESHAPE
          DIAMETER = feature.Diameter'DIAMETER
          NEEDSATTENTION = feature.NeedsAttention'NEEDSATTENTION
          FIELD_COMMENTS_ = feature.FieldComments'FIELD_COMMENTS_
          SUBTYPEFIELD = feature.SubtypeField'SUBTYPEFIELD
          WIDTH = feature.WIDTH
          HEIGHT = feature.HEIGHT
          ACCEPT_DATE = feature.ACCEPT_DATE
          UPSTREAM_ELEV = feature.UPSTREAM_ELEV
          UPSTREAM_DEPTH = feature.UPSTREAM_DEPTH
          DOWNSTREAM_ELEV = feature.DOWNSTREAM_ELEV
          DOWNSTREAM_DEPTH = feature.DOWNSTREAM_DEPTH
          NUM_BARRELS = feature.NUM_BARRELS
          IMAGERYYEAR = feature.IMAGERYYEAR
          GLOBALID = feature.GLOBALID
          LFEET = feature.LFEET
          PERCT_GRD = feature.PERCT_GRD
          OUTFALLID = feature.OUTFALLID
          UNITID = feature.UNITID
          SHAPE_Length = feature.SHAPE_Length
          x = feature.maybe_x
          y = feature.maybe_y
          z = feature.maybe_z }

type Ditch_Point_Feature =
    { OBJECTID: string option
      ANCILLARYROLE: int16 option
      ENABLED: int16 option
      LIFECYCLE: string option
      PARENTID: string option
      OWNER: string option
      MAINTBY: string option
      SOURCE: string option
      FACILITYID: string option
      LEGACYID: string option
      EASTING: double option
      NORTHING: double option
      NOTES: string option
      INVENTORYDATE: DateTime option
      INVENTORYTYPE: string option
      ORIGINALSOURCE: string option
      DATECREATED: DateTime option
      WHOCREATED: string option
      UPDATESOURCE: string option
      DATEMODIFIED: DateTime option
      WHOMODIFIED: string option
      ACCURACYCODE: string option
      INFILTRATION: int16 option
      NEEDSATTENTION: int16 option
      RELATEDFEATURE: string option
      SUBTYPEFIELD: int option
      ZVALUE: double option
      Z29: double option
      IMAGERYYEAR: string option
      GLOBALID: string option
      x: double option
      y: double option
      z: double option }

    static member from_feature(feature:Feature) =
        { OBJECTID = feature.OBJECTID
          ANCILLARYROLE = feature.AncillaryRole'ANCILLARYROLE
          ENABLED = feature.Enabled'ENABLED
          LIFECYCLE = feature.Lifecycle'LIFECYCLE
          PARENTID = feature.PARENTID
          OWNER = feature.Owner'OWNER
          MAINTBY = feature.MaintBy'MAINTBY
          SOURCE = feature.Source'SOURCE
          FACILITYID = feature.FACILITYID
          LEGACYID = feature.LEGACYID
          EASTING = feature.EASTING
          NORTHING = feature.NORTHING
          NOTES = feature.NOTES
          INVENTORYDATE = feature.Location_Date'INVENTORYDATE
          INVENTORYTYPE = feature.Inventory_Type'INVENTORYTYPE
          ORIGINALSOURCE = feature.Original_Source'ORIGINALSOURCE
          DATECREATED = feature.Date_Created'DATECREATED
          WHOCREATED = feature.Who_Created'WHOCREATED
          UPDATESOURCE = feature.Update__Source'UPDATESOURCE
          DATEMODIFIED = feature.Date_Modified'DATEMODIFIED
          WHOMODIFIED = feature.Who_Modified'WHOMODIFIED
          ACCURACYCODE = feature.Accuracy_Code'ACCURACYCODE
          INFILTRATION = feature.``Inflow\Infiltration'INFILTRATION``
          NEEDSATTENTION = feature.NeedsAttention'NEEDSATTENTION
          RELATEDFEATURE = feature.RelatedFeature'RELATEDFEATURE
          SUBTYPEFIELD = feature.SubtypeField'SUBTYPEFIELD
          ZVALUE = feature.ZValue'ZVALUE
          Z29 = feature.Z29
          IMAGERYYEAR = feature.IMAGERYYEAR
          GLOBALID = feature.GLOBALID
          x = feature.maybe_x
          y = feature.maybe_y
          z = feature.maybe_z }

type Ditch_Feature =
    { OBJECTID: string option
      ENABLED: int16 option
      LIFECYCLE: string option
      PARENTID: string option
      OWNER: string option
      MAINTBY: string option
      SOURCE: string option
      FACILITYID: string option
      LEGACYID: string option
      INVENTORYDATE: DateTime option
      DIGITALPICTUREID: string option
      FIELDCOMPLETE: int16 option
      ATTRIBUTECOMPLETE: int16 option
      NOTES: string option
      DRAWINGID: string option
      ORIGINALSOURCE: string option
      DATECREATED: DateTime option
      WHOCREATED: string option
      DATEMODIFIED: DateTime option
      ACCURACYCODE: string option
      WHOMODIFIED: string option
      SURFACETYPE: string option
      RELATEDFEATURE: string option
      SUBTYPEFIELD: int option
      FIELDCOMMENTS: string option
      MILES: double option
      IMAGERYYEAR: string option
      GLOBALID: string option
      OUTFALLID: string option
      UNITID: string option
      SHAPE_Length: double option
      x: double option
      y: double option
      z: double option }

    static member from_feature(feature:Feature) =
        { OBJECTID = feature.OBJECTID
          ENABLED = feature.Enabled'ENABLED
          LIFECYCLE = feature.Lifecycle'LIFECYCLE
          PARENTID = feature.PARENTID
          OWNER = feature.Owner'OWNER
          MAINTBY = feature.MaintBy'MAINTBY
          SOURCE = feature.Source'SOURCE
          FACILITYID = feature.FACILITYID
          LEGACYID = feature.LEGACYID
          INVENTORYDATE = feature.INVENTORYDATE
          DIGITALPICTUREID = feature.DIGITALPICTUREID
          FIELDCOMPLETE = feature.FieldComplete'FIELDCOMPLETE
          ATTRIBUTECOMPLETE = feature.AttributeComplete'ATTRIBUTECOMPLETE
          NOTES = feature.NOTES
          DRAWINGID = feature.DRAWINGID
          ORIGINALSOURCE = feature.ORIGINALSOURCE
          DATECREATED = feature.DATECREATED
          WHOCREATED = feature.WhoCreated'WHOCREATED
          DATEMODIFIED = feature.DATEMODIFIED
          ACCURACYCODE = feature.AccuracyCode'ACCURACYCODE
          WHOMODIFIED = feature.WHOMODIFIED
          SURFACETYPE = feature.SurfaceType'SURFACETYPE
          RELATEDFEATURE = feature.RelatedFeature'RELATEDFEATURE
          SUBTYPEFIELD = feature.SubtypeField'SUBTYPEFIELD
          FIELDCOMMENTS = feature.FieldComments'FIELDCOMMENTS
          MILES = feature.MILES
          IMAGERYYEAR = feature.IMAGERYYEAR
          GLOBALID = feature.GLOBALID
          OUTFALLID = feature.OUTFALLID
          UNITID = feature.UNITID
          SHAPE_Length = feature.SHAPE_Length
          x = feature.maybe_x
          y = feature.maybe_y
          z = feature.maybe_z }

type Bridge_Point_Feature =
    { OBJECTID: string option
      ANCILLARYROLE: int16 option
      ENABLED: int16 option
      LIFECYCLE: string option
      PARENTID: string option
      OWNER: string option
      MAINTBY: string option
      SOURCE: string option
      FACILITYID: string option
      LEGACYID: string option
      EASTING: double option
      NORTHING: double option
      NOTES: string option
      INVENTORYDATE: DateTime option
      INVENTORYTYPE: string option
      ORIGINALSOURCE: string option
      DATECREATED: DateTime option
      WHOCREATED: string option
      UPDATESOURCE: string option
      DATEMODIFIED: DateTime option
      WHOMODIFIED: string option
      ACCURACYCODE: string option
      INFILTRATION: int16 option
      NEEDSATTENTION: int16 option
      RELATEDFEATURE: string option
      SUBTYPEFIELD: int option
      ZVALUE: double option
      Z29: double option
      IMAGERYYEAR: string option
      GLOBALID: string option
      x: double option
      y: double option
      z: double option }

    static member from_feature(feature:Feature) =
        { OBJECTID = feature.OBJECTID
          ANCILLARYROLE = feature.AncillaryRole'ANCILLARYROLE
          ENABLED = feature.Enabled'ENABLED
          LIFECYCLE = feature.Lifecycle'LIFECYCLE
          PARENTID = feature.PARENTID
          OWNER = feature.Owner'OWNER
          MAINTBY = feature.MaintBy'MAINTBY
          SOURCE = feature.Source'SOURCE
          FACILITYID = feature.FACILITYID
          LEGACYID = feature.LEGACYID
          EASTING = feature.EASTING
          NORTHING = feature.NORTHING
          NOTES = feature.NOTES
          INVENTORYDATE = feature.Location_Date'INVENTORYDATE
          INVENTORYTYPE = feature.Inventory_Type'INVENTORYTYPE
          ORIGINALSOURCE = feature.Original_Source'ORIGINALSOURCE
          DATECREATED = feature.Date_Created'DATECREATED
          WHOCREATED = feature.Who_Created'WHOCREATED
          UPDATESOURCE = feature.Update__Source'UPDATESOURCE
          DATEMODIFIED = feature.Date_Modified'DATEMODIFIED
          WHOMODIFIED = feature.Who_Modified'WHOMODIFIED
          ACCURACYCODE = feature.Accuracy_Code'ACCURACYCODE
          INFILTRATION = feature.``Inflow\Infiltration'INFILTRATION``
          NEEDSATTENTION = feature.NeedsAttention'NEEDSATTENTION
          RELATEDFEATURE = feature.RelatedFeature'RELATEDFEATURE
          SUBTYPEFIELD = feature.SubtypeField'SUBTYPEFIELD
          ZVALUE = feature.ZValue'ZVALUE
          Z29 = feature.Z29
          IMAGERYYEAR = feature.IMAGERYYEAR
          GLOBALID = feature.GLOBALID
          x = feature.maybe_x
          y = feature.maybe_y
          z = feature.maybe_z }

type Bridge_Feature =
    { OBJECTID: string option
      ENABLED: int16 option
      LIFECYCLE: string option
      PARENTID: string option
      OWNER: string option
      MAINTBY: string option
      SOURCE: string option
      FACILITYID: string option
      LEGACYID: string option
      INVENTORYDATE: DateTime option
      DIGITALPICTUREID: string option
      FIELDCOMPLETE: int16 option
      ATTRIBUTECOMPLETE: int16 option
      NOTES: string option
      DRAWINGID: string option
      ORIGINALSOURCE: string option
      DATECREATED: DateTime option
      WHOCREATED: string option
      UPDATESOURCE: string option
      DATEMODIFIED: DateTime option
      ACCURACYCODE: string option
      WHOMODIFIED: string option
      MATERIAL: string option
      PIPESHAPE: string option
      DIAMETER: int16 option
      NEEDSATTENTION: int16 option
      FIELD_COMMENTS_: string option
      SUBTYPEFIELD: int option
      WIDTH: double option
      HEIGHT: double option
      ACCEPT_DATE: string option
      UPSTREAM_ELEV: double option
      UPSTREAM_DEPTH: double option
      DOWNSTREAM_ELEV: double option
      DOWNSTREAM_DEPTH: double option
      NUM_BARRELS: int option
      IMAGERYYEAR: string option
      LFEET: double option
      PERCT_GRD: double option
      GLOBALID: string option
      Shape_Length: double option
      x: double option
      y: double option
      z: double option }

    static member from_feature(feature:Feature) =
        { OBJECTID = feature.OBJECTID
          ENABLED = feature.Enabled'ENABLED
          LIFECYCLE = feature.Lifecycle'LIFECYCLE
          PARENTID = feature.PARENTID
          OWNER = feature.Owner'OWNER
          MAINTBY = feature.MaintBy'MAINTBY
          SOURCE = feature.Source'SOURCE
          FACILITYID = feature.FACILITYID
          LEGACYID = feature.LEGACYID
          INVENTORYDATE = feature.INVENTORYDATE
          DIGITALPICTUREID = feature.DIGITALPICTUREID
          FIELDCOMPLETE = feature.FieldComplete'FIELDCOMPLETE
          ATTRIBUTECOMPLETE = feature.AttributeComplete'ATTRIBUTECOMPLETE
          NOTES = feature.NOTES
          DRAWINGID = feature.DRAWINGID
          ORIGINALSOURCE = feature.ORIGINALSOURCE
          DATECREATED = feature.DATECREATED
          WHOCREATED = feature.WhoCreated'WHOCREATED
          UPDATESOURCE = feature.UPDATESOURCE
          DATEMODIFIED = feature.DATEMODIFIED
          ACCURACYCODE = feature.AccuracyCode'ACCURACYCODE
          WHOMODIFIED = feature.WHOMODIFIED
          MATERIAL = feature.Material'MATERIAL
          PIPESHAPE = feature.PipeShape'PIPESHAPE
          DIAMETER = feature.Diameter'DIAMETER
          NEEDSATTENTION = feature.NeedsAttention'NEEDSATTENTION
          FIELD_COMMENTS_ = feature.FieldComments'FIELD_COMMENTS_
          SUBTYPEFIELD = feature.SubtypeField'SUBTYPEFIELD
          WIDTH = feature.WIDTH
          HEIGHT = feature.HEIGHT
          ACCEPT_DATE = feature.ACCEPT_DATE
          UPSTREAM_ELEV = feature.UPSTREAM_ELEV
          UPSTREAM_DEPTH = feature.UPSTREAM_DEPTH
          DOWNSTREAM_ELEV = feature.DOWNSTREAM_ELEV
          DOWNSTREAM_DEPTH = feature.DOWNSTREAM_DEPTH
          NUM_BARRELS = feature.NUM_BARRELS
          IMAGERYYEAR = feature.IMAGERYYEAR
          LFEET = feature.LFEET
          PERCT_GRD = feature.PERCT_GRD
          GLOBALID = feature.GLOBALID
          Shape_Length = feature.Shape_Length
          x = feature.maybe_x
          y = feature.maybe_y
          z = feature.maybe_z }

type Media_Points_Without_Photos_Feature =
    { OBJECTID: string option
      HYD_ID: string option
      NOTES: string option
      FOLDER: string option
      RAW_NAME: string option
      FINAL_NAME: string option
      MEDIA_CODE: string option
      VIEW_: string option
      LOC_DESC: string option
      ELEMENTX: double option
      ELEMENTY: double option
      DATE_: DateTime option
      STORAGE_PATH_ADDR: string option
      FILE_NAME: string option
      STORAGE_FULL_PATH_ADDR: string option
      STORAGE_STATIC_PATH_ADDR: string option
      PHOTOID: string option
      FIELDCREW: string option
      CREATIONDATE: DateTime option
      CREATOR: string option
      EDITDATE: DateTime option
      EDITOR: string option
      STRUCTURE_ID: string option
      ROTATION_AZ: int16 option
      PHOTO_NUM: int16 option
      HYPERLINK: string option
      HOTLINK: string option
      GLOBALID: string option
      FILE_NAME_1: string option
      x: double option
      y: double option
      z: double option }

    static member from_feature(feature:Feature) =
        { OBJECTID = feature.OBJECTID
          HYD_ID = feature.Pond_Number'HYD_ID
          NOTES = feature.Notes'NOTES
          FOLDER = feature.Folder'FOLDER
          RAW_NAME = feature.Raw_Name'RAW_NAME
          FINAL_NAME = feature.Final_Name'FINAL_NAME
          MEDIA_CODE = feature.Media_Code'MEDIA_CODE
          VIEW_ = feature.View'VIEW_
          LOC_DESC = feature.Location'LOC_DESC
          ELEMENTX = feature.ELEMENTX
          ELEMENTY = feature.ELEMENTY
          DATE_ = feature.Date'DATE_
          STORAGE_PATH_ADDR = feature.Storage_Path_Address'STORAGE_PATH_ADDR
          FILE_NAME = feature.Filename'FILE_NAME
          STORAGE_FULL_PATH_ADDR = feature.STORAGE_FULL_PATH_ADDR
          STORAGE_STATIC_PATH_ADDR = feature.STORAGE_STATIC_PATH_ADDR
          PHOTOID = feature.PhotoID'PHOTOID
          FIELDCREW = feature.Company'FIELDCREW
          CREATIONDATE = feature.CreationDate'CREATIONDATE
          CREATOR = feature.Creator'CREATOR
          EDITDATE = feature.EditDate'EDITDATE
          EDITOR = feature.Editor'EDITOR
          STRUCTURE_ID = feature.Struct_ID'STRUCTURE_ID
          ROTATION_AZ = feature.Rotation_Az'ROTATION_AZ
          PHOTO_NUM = feature.PhotoNum'PHOTO_NUM
          HYPERLINK = feature.Hyperlink'HYPERLINK
          HOTLINK = feature.Hotlink'HOTLINK
          GLOBALID = feature.GlobalID'GLOBALID
          FILE_NAME_1 = feature.File_Name'FILE_NAME_1
          x = feature.maybe_x
          y = feature.maybe_y
          z = feature.maybe_z }

type Interference_Feature =
    { OBJECTID: string option
      LIFECYCLE: string option
      PARENTID: string option
      OWNER: string option
      MAINTBY: string option
      SOURCE: string option
      FACILITYID: string option
      LEGACYID: string option
      ATTACHEDTOID: string option
      NEEDSATTENTION: int16 option
      LOCATION: string option
      INVENTORYDATE: DateTime option
      INVENTORYTYPE: string option
      EASTING: double option
      NORTHING: double option
      ZVALUE: double option
      Z29: double option
      DIGITALPICTUREID: string option
      FIELDCOMPLETE: int16 option
      ATTRIBUTECOMPLETE: int16 option
      NOTES: string option
      PRFRESOLUTION: string option
      DRAWINGID: string option
      ORIGINALSOURCE: string option
      DATECREATED: DateTime option
      WHOCREATED: string option
      UPDATESOURCE: string option
      DATEMODIFIED: DateTime option
      WHOMODIFIED: string option
      ACCURACYCODE: string option
      HYPERLINK_AR: string option
      FIELDCOMMENTS: string option
      SOURCEYEAR: string option
      x: double option
      y: double option
      z: double option }

    static member from_feature(feature:Feature) =
        { OBJECTID = feature.OBJECTID
          LIFECYCLE = feature.Lifecycle'LIFECYCLE
          PARENTID = feature.PARENTID
          OWNER = feature.Owner'OWNER
          MAINTBY = feature.MaintBy'MAINTBY
          SOURCE = feature.Source'SOURCE
          FACILITYID = feature.FACILITYID
          LEGACYID = feature.LEGACYID
          ATTACHEDTOID = feature.ATTACHEDTOID
          NEEDSATTENTION = feature.NeedsAttention'NEEDSATTENTION
          LOCATION = feature.LOCATION
          INVENTORYDATE = feature.INVENTORYDATE
          INVENTORYTYPE = feature.InventoryType'INVENTORYTYPE
          EASTING = feature.EASTING
          NORTHING = feature.NORTHING
          ZVALUE = feature.ZVALUE
          Z29 = feature.Z29
          DIGITALPICTUREID = feature.DIGITALPICTUREID
          FIELDCOMPLETE = feature.FieldComplete'FIELDCOMPLETE
          ATTRIBUTECOMPLETE = feature.AttributeComplete'ATTRIBUTECOMPLETE
          NOTES = feature.NOTES
          PRFRESOLUTION = feature.PRFResolution'PRFRESOLUTION
          DRAWINGID = feature.DRAWINGID
          ORIGINALSOURCE = feature.ORIGINALSOURCE
          DATECREATED = feature.DATECREATED
          WHOCREATED = feature.WhoCreated'WHOCREATED
          UPDATESOURCE = feature.UPDATESOURCE
          DATEMODIFIED = feature.DATEMODIFIED
          WHOMODIFIED = feature.WHOMODIFIED
          ACCURACYCODE = feature.AccuracyCode'ACCURACYCODE
          HYPERLINK_AR = feature.HYPERLINK_AR
          FIELDCOMMENTS = feature.FIELDCOMMENTS
          SOURCEYEAR = feature.SOURCEYEAR
          x = feature.maybe_x
          y = feature.maybe_y
          z = feature.maybe_z }

type Pollution_Control_Box_Feature =
    { OBJECTID: string option
      LIFECYCLE: string option
      PARENTID: string option
      OWNER: string option
      MAINTBY: string option
      SOURCE: string option
      FACILITYID: string option
      LEGACYID: string option
      ATTACHEDTOID: string option
      NEEDSATTENTION: int16 option
      LOCATION: string option
      INVENTORYDATE: DateTime option
      INVENTORYTYPE: string option
      EASTING: double option
      NORTHING: double option
      DIGITALPICTUREID: string option
      FIELDCOMPLETE: int16 option
      ATTRIBUTECOMPLETE: int16 option
      NOTES: string option
      PRFRESOLUTION: string option
      DRAWINGID: string option
      ORIGINALSOURCE: string option
      DATECREATED: DateTime option
      WHOCREATED: string option
      UPDATESOURCE: string option
      DATEMODIFIED: DateTime option
      WHOMODIFIED: string option
      ACCURACYCODE: string option
      HYPERLINK_AR: string option
      FIELDCOMMENTS: string option
      ZVALUE: double option
      Z29: double option
      IMAGERYYEAR: string option
      x: double option
      y: double option
      z: double option }

    static member from_feature(feature:Feature) =
        { OBJECTID = feature.OBJECTID
          LIFECYCLE = feature.Lifecycle'LIFECYCLE
          PARENTID = feature.PARENTID
          OWNER = feature.Owner'OWNER
          MAINTBY = feature.MaintBy'MAINTBY
          SOURCE = feature.Source'SOURCE
          FACILITYID = feature.FACILITYID
          LEGACYID = feature.LEGACYID
          ATTACHEDTOID = feature.ATTACHEDTOID
          NEEDSATTENTION = feature.NeedsAttention'NEEDSATTENTION
          LOCATION = feature.LOCATION
          INVENTORYDATE = feature.INVENTORYDATE
          INVENTORYTYPE = feature.InventoryType'INVENTORYTYPE
          EASTING = feature.EASTING
          NORTHING = feature.NORTHING
          DIGITALPICTUREID = feature.DIGITALPICTUREID
          FIELDCOMPLETE = feature.FieldComplete'FIELDCOMPLETE
          ATTRIBUTECOMPLETE = feature.AttributeComplete'ATTRIBUTECOMPLETE
          NOTES = feature.NOTES
          PRFRESOLUTION = feature.PRFResolution'PRFRESOLUTION
          DRAWINGID = feature.DRAWINGID
          ORIGINALSOURCE = feature.ORIGINALSOURCE
          DATECREATED = feature.DATECREATED
          WHOCREATED = feature.WhoCreated'WHOCREATED
          UPDATESOURCE = feature.UPDATESOURCE
          DATEMODIFIED = feature.DATEMODIFIED
          WHOMODIFIED = feature.WHOMODIFIED
          ACCURACYCODE = feature.AccuracyCode'ACCURACYCODE
          HYPERLINK_AR = feature.HYPERLINK_AR
          FIELDCOMMENTS = feature.FIELDCOMMENTS
          ZVALUE = feature.ZValue'ZVALUE
          Z29 = feature.Z29
          IMAGERYYEAR = feature.IMAGERYYEAR
          x = feature.maybe_x
          y = feature.maybe_y
          z = feature.maybe_z }

type Stormwater_Feature = 
    | StormwaterPondTopofBankFeature of Stormwater_Pond___Top_of_Bank_Feature
    | OutfallDrainageAreaMS4Feature of Outfall_Drainage_Area_MS4_Feature
    | OutfallDrainageAreaFeature of Outfall_Drainage_Area_Feature
    | OutfallDrainageAreaMOFFeature of Outfall_Drainage_Area_MOF_Feature
    | MediaPointsFeature of Media_Points_Feature
    | DamageFeature of Damage_Feature
    | OutfallFeature of Outfall_Feature
    | StormwaterPondFeature of Stormwater_Pond_Feature
    | EndPointFeature of End_Point_Feature
    | InletFeature of Inlet_Feature
    | DebrisTrapFeature of Debris_Trap_Feature
    | JunctionFixedFeature of Junction_Fixed_Feature
    | ConnectivityFeature of Connectivity_Feature
    | GenericStormAssetFeature of Generic_Storm_Asset_Feature
    | StormwaterPondDischargeFeature of Stormwater_Pond_Discharge_Feature
    | PrivatePointFeature of Private_Point_Feature
    | ConduitFeature of Conduit_Feature
    | CulvertCrossDrainFeature of Culvert_Cross_Drain_Feature
    | DitchPointFeature of Ditch_Point_Feature
    | DitchFeature of Ditch_Feature
    | BridgePointFeature of Bridge_Point_Feature
    | BridgeFeature of Bridge_Feature
    | MediaPointsWithoutPhotosFeature of Media_Points_Without_Photos_Feature
    | InterferenceFeature of Interference_Feature
    | PollutionControlBoxFeature of Pollution_Control_Box_Feature

type Stormwater_Layer = 
    {
        name:string
        features:Stormwater_Feature list
    }

type Conduit_Layer= 
    { 
        name :string
        features :Conduit_Feature list
    }
                            

type Culvert_Cross_Drain_Layer= 
    { 
        name :string
        features :Culvert_Cross_Drain_Feature list
    }
                            

type Debris_Trap_Layer= 
    { 
        name :string
        features :Debris_Trap_Feature list
    }
                            

type Ditch_Layer= 
    { 
        name :string
        features :Ditch_Feature list
    }
                            

type End_Point_Layer= 
    { 
        name :string
        features :End_Point_Feature list
    }
                            

type Inlet_Layer= 
    { 
        name :string
        features :Inlet_Feature list
    }
                            

type Junction_Fixed_Layer= 
    { 
        name :string
        features :Junction_Fixed_Feature list
    }
                            

type Outfall_Layer= 
    { 
        name :string
        features :Outfall_Feature list
    }
                            

type Outfall_Drainage_Area_Layer= 
    { 
        name :string
        features :Outfall_Drainage_Area_Feature list
    }
                            

type Outfall_Drainage_Area_MOF_Layer= 
    { 
        name :string
        features :Outfall_Drainage_Area_MOF_Feature list
    }
                            

type Outfall_Drainage_Area_MS4_Layer= 
    { 
        name :string
        features :Outfall_Drainage_Area_MS4_Feature list
    }
                            

type Stormwater_Pond_Layer= 
    { 
        name :string
        features :Stormwater_Pond_Feature list
    }
                            

type Stormwater_Pond___Top_of_Bank_Layer= 
    { 
        name :string
        features :Stormwater_Pond___Top_of_Bank_Feature list
    }
                            

type Stormwater_Pond_Discharge_Layer= 
    { 
        name :string
        features :Stormwater_Pond_Discharge_Feature list
    }
                            












let Conduit : Conduit_Layer= 
    { 
        name = "Conduit"
        features = 
            features
            |> Array.Parallel.filter (fun feature -> feature.layer.Name = "Conduit")
            |> Array.toList
            |> List.map Conduit_Feature.from_feature
    }
                            

let Culvert_Cross_Drain : Culvert_Cross_Drain_Layer= 
    { 
        name = "Culvert Cross Drain"
        features = 
            features
            |> Array.Parallel.filter (fun feature -> feature.layer.Name = "Culvert Cross Drain")
            |> Array.toList
            |> List.map Culvert_Cross_Drain_Feature.from_feature
    }
                            

let Debris_Trap : Debris_Trap_Layer= 
    { 
        name = "Debris Trap"
        features = 
            features
            |> Array.Parallel.filter (fun feature -> feature.layer.Name = "Debris Trap")
            |> Array.toList
            |> List.map Debris_Trap_Feature.from_feature
    }
                            

let Ditch : Ditch_Layer= 
    { 
        name = "Ditch"
        features = 
            features
            |> Array.Parallel.filter (fun feature -> feature.layer.Name = "Ditch")
            |> Array.toList
            |> List.map Ditch_Feature.from_feature
    }
                            

let End_Point : End_Point_Layer= 
    { 
        name = "End Point"
        features = 
            features
            |> Array.Parallel.filter (fun feature -> feature.layer.Name = "End Point")
            |> Array.toList
            |> List.map End_Point_Feature.from_feature
    }
                            

let Inlet : Inlet_Layer= 
    { 
        name = "Inlet"
        features = 
            features
            |> Array.Parallel.filter (fun feature -> feature.layer.Name = "Inlet")
            |> Array.toList
            |> List.map Inlet_Feature.from_feature
    }
                            

let Junction_Fixed : Junction_Fixed_Layer= 
    { 
        name = "Junction Fixed"
        features = 
            features
            |> Array.Parallel.filter (fun feature -> feature.layer.Name = "Junction Fixed")
            |> Array.toList
            |> List.map Junction_Fixed_Feature.from_feature
    }
                            

let Outfall : Outfall_Layer= 
    { 
        name = "Outfall"
        features = 
            features
            |> Array.Parallel.filter (fun feature -> feature.layer.Name = "Outfall")
            |> Array.toList
            |> List.map Outfall_Feature.from_feature
    }
                            

let Outfall_Drainage_Area : Outfall_Drainage_Area_Layer= 
    { 
        name = "Outfall Drainage Area"
        features = 
            features
            |> Array.Parallel.filter (fun feature -> feature.layer.Name = "Outfall Drainage Area")
            |> Array.toList
            |> List.map Outfall_Drainage_Area_Feature.from_feature
    }
                            

let Outfall_Drainage_Area_MOF : Outfall_Drainage_Area_MOF_Layer= 
    { 
        name = "Outfall Drainage Area MOF"
        features = 
            features
            |> Array.Parallel.filter (fun feature -> feature.layer.Name = "Outfall Drainage Area MOF")
            |> Array.toList
            |> List.map Outfall_Drainage_Area_MOF_Feature.from_feature
    }
                            

let Outfall_Drainage_Area_MS4 : Outfall_Drainage_Area_MS4_Layer= 
    { 
        name = "Outfall Drainage Area MS4"
        features = 
            features
            |> Array.Parallel.filter (fun feature -> feature.layer.Name = "Outfall Drainage Area MS4")
            |> Array.toList
            |> List.map Outfall_Drainage_Area_MS4_Feature.from_feature
    }
                            

let Stormwater_Pond : Stormwater_Pond_Layer= 
    { 
        name = "Stormwater Pond"
        features = 
            features
            |> Array.Parallel.filter (fun feature -> feature.layer.Name = "Stormwater Pond")
            |> Array.toList
            |> List.map Stormwater_Pond_Feature.from_feature
    }
                            

let Stormwater_Pond___Top_of_Bank : Stormwater_Pond___Top_of_Bank_Layer= 
    { 
        name = "Stormwater Pond - Top of Bank"
        features = 
            features
            |> Array.Parallel.filter (fun feature -> feature.layer.Name = "Stormwater Pond - Top of Bank")
            |> Array.toList
            |> List.map Stormwater_Pond___Top_of_Bank_Feature.from_feature
    }
                            

let Stormwater_Pond_Discharge : Stormwater_Pond_Discharge_Layer= 
    { 
        name = "Stormwater Pond Discharge"
        features = 
            features
            |> Array.Parallel.filter (fun feature -> feature.layer.Name = "Stormwater Pond Discharge")
            |> Array.toList
            |> List.map Stormwater_Pond_Discharge_Feature.from_feature
    }
                            
                                                                        
(*

let stormwater_features = 
    features
    |> Array.Parallel.filter (fun feature -> target_layers.Contains feature.layer.Name)
    |> Array.Parallel.map (fun feature ->
    
    match feature.FeatureTable.DisplayName.normalize_identifier with 
    | "Stormwater_Pond___Top_of_Bank" -> Stormwater_Pond___Top_of_Bank_Feature.from_feature feature |> StormwaterPondTopofBankFeature
    | "Outfall_Drainage_Area_MS4" -> Outfall_Drainage_Area_MS4_Feature.from_feature feature |> OutfallDrainageAreaMS4Feature
    | "Outfall_Drainage_Area" -> Outfall_Drainage_Area_Feature.from_feature feature |> OutfallDrainageAreaFeature
    | "Outfall_Drainage_Area_MOF" -> Outfall_Drainage_Area_MOF_Feature.from_feature feature |> OutfallDrainageAreaMOFFeature
    | "Media_Points" -> Media_Points_Feature.from_feature feature |> MediaPointsFeature
    | "Damage" -> Damage_Feature.from_feature feature |> DamageFeature
    | "Outfall" -> Outfall_Feature.from_feature feature |> OutfallFeature
    | "Stormwater_Pond" -> Stormwater_Pond_Feature.from_feature feature |> StormwaterPondFeature
    | "End_Point" -> End_Point_Feature.from_feature feature |> EndPointFeature
    | "Inlet" -> Inlet_Feature.from_feature feature |> InletFeature
    | "Debris_Trap" -> Debris_Trap_Feature.from_feature feature |> DebrisTrapFeature
    | "Junction_Fixed" -> Junction_Fixed_Feature.from_feature feature |> JunctionFixedFeature
    | "Connectivity" -> Connectivity_Feature.from_feature feature |> ConnectivityFeature
    | "Generic_Storm_Asset" -> Generic_Storm_Asset_Feature.from_feature feature |> GenericStormAssetFeature
    | "Stormwater_Pond_Discharge" -> Stormwater_Pond_Discharge_Feature.from_feature feature |> StormwaterPondDischargeFeature
    | "Private_Point" -> Private_Point_Feature.from_feature feature |> PrivatePointFeature
    | "Conduit" -> Conduit_Feature.from_feature feature |> ConduitFeature
    | "Culvert_Cross_Drain" -> Culvert_Cross_Drain_Feature.from_feature feature |> CulvertCrossDrainFeature
    | "Ditch_Point" -> Ditch_Point_Feature.from_feature feature |> DitchPointFeature
    | "Ditch" -> Ditch_Feature.from_feature feature |> DitchFeature
    | "Bridge_Point" -> Bridge_Point_Feature.from_feature feature |> BridgePointFeature
    | "Bridge" -> Bridge_Feature.from_feature feature |> BridgeFeature
    | "Media_Points_Without_Photos" -> Media_Points_Without_Photos_Feature.from_feature feature |> MediaPointsWithoutPhotosFeature
    | "Interference" -> Interference_Feature.from_feature feature |> InterferenceFeature
    | "Pollution_Control_Box" -> Pollution_Control_Box_Feature.from_feature feature |> PollutionControlBoxFeature
    | _ -> failwithf "Unknown feature layer for feature %O" feature
    )


*)




let random_layer = layers |> Array.randomChoice
let random_table = tables |> Array.randomChoice
let random_field = fields |> Array.randomChoice
let random_domain = domains |> Array.randomChoice
let random_domain_individual = domain_individuals |> Array.randomChoice
let random_coded_value,_ = coded_values |>  Array.randomChoice            
let random_feature = features |> Array.randomChoice
// let random_stormwater_feature = stormwater_features |> Array.randomChoice


module ExcelRows =

    let private optionTypeDefinition =
        typedefof<option<_>>

    let private isOptionType (valueType: System.Type) =
        valueType.IsGenericType
        && valueType.GetGenericTypeDefinition() = optionTypeDefinition

    let private columnType (valueType: System.Type) =
        if isOptionType valueType then
            valueType.GetGenericArguments().[0]
        else
            valueType

    let private cellValue
        (declaredType: System.Type)
        (value: obj)
        : obj =

        if isOptionType declaredType then
            // F# represents None as null when the option is boxed.
            if isNull value then
                box DBNull.Value
            else
                let unionCase, fields =
                    FSharpValue.GetUnionFields(value, declaredType)

                match unionCase.Name, fields with
                | "Some", [| underlyingValue |] ->
                    if isNull underlyingValue then
                        box DBNull.Value
                    else
                        underlyingValue

                | _ ->
                    box DBNull.Value

        elif isNull value then
            box DBNull.Value

        else
            value

    let fromRecords<'Record>
        (records: 'Record list)
        : DataRow list =

        let recordType = typeof<'Record>

        if not (FSharpType.IsRecord recordType) then
            invalidArg
                (nameof records)
                $"{recordType.FullName} is not an F# record type."

        let fields =
            FSharpType.GetRecordFields(recordType)

        let dataTable =
            new DataTable(recordType.Name)

        // Preserve the record's declared field order and underlying types.
        fields
        |> Array.iter (fun field ->
            dataTable.Columns.Add(
                field.Name,
                columnType field.PropertyType
            )
            |> ignore)

        records
        |> List.iter (fun record ->

            let row = dataTable.NewRow()

            fields
            |> Array.iteri (fun columnIndex field ->

                let originalValue =
                    field.GetValue(box record)

                row.[columnIndex] <-
                    cellValue field.PropertyType originalValue
            )

            dataTable.Rows.Add(row)
        )

        dataTable.Rows
        |> Seq.cast<DataRow>
        |> Seq.toList

let xlsx_file = new FileInfo @"D:\Persistence\XLSX\LCG\MapServer.xlsx"
let tableItems records =
    records
    |> ExcelRows.fromRecords
    |> TableItems

[

        Worksheet Conduit.name
        FsExcel.Table [
            TableName Conduit.name
            tableItems Conduit.features
        ]
        Worksheet Culvert_Cross_Drain.name
        FsExcel.Table [
            TableName Culvert_Cross_Drain.name
            tableItems Culvert_Cross_Drain.features
        ]
        Worksheet Debris_Trap.name
        FsExcel.Table [
            TableName Debris_Trap.name
            tableItems Debris_Trap.features
        ]
        Worksheet Ditch.name
        FsExcel.Table [
            TableName Ditch.name
            tableItems Ditch.features
        ]
        Worksheet End_Point.name
        FsExcel.Table [
            TableName End_Point.name
            tableItems End_Point.features
        ]
        Worksheet Inlet.name
        FsExcel.Table [
            TableName Inlet.name
            tableItems Inlet.features
        ]
        Worksheet Junction_Fixed.name
        FsExcel.Table [
            TableName Junction_Fixed.name
            tableItems Junction_Fixed.features
        ]
        Worksheet Outfall.name
        FsExcel.Table [
            TableName Outfall.name
            tableItems Outfall.features
        ]
        Worksheet Outfall_Drainage_Area.name
        FsExcel.Table [
            TableName Outfall_Drainage_Area.name
            tableItems Outfall_Drainage_Area.features
        ]
        Worksheet Outfall_Drainage_Area_MOF.name
        FsExcel.Table [
            TableName Outfall_Drainage_Area_MOF.name
            tableItems Outfall_Drainage_Area_MOF.features
        ]
        Worksheet Outfall_Drainage_Area_MS4.name
        FsExcel.Table [
            TableName Outfall_Drainage_Area_MS4.name
            tableItems Outfall_Drainage_Area_MS4.features
        ]
        Worksheet Stormwater_Pond.name
        FsExcel.Table [
            TableName Stormwater_Pond.name
            tableItems Stormwater_Pond.features
        ]
        Worksheet Stormwater_Pond___Top_of_Bank.name
        FsExcel.Table [
            TableName Stormwater_Pond___Top_of_Bank.name
            tableItems Stormwater_Pond___Top_of_Bank.features
        ]
        Worksheet Stormwater_Pond_Discharge.name    
        FsExcel.Table [
            TableName Stormwater_Pond_Discharge.name
            tableItems Stormwater_Pond_Discharge.features
        ]
]
|> Render.AsFile xlsx_file.FullName





Directory.GetFiles(@"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\WebServices", "*.wsdl",SearchOption.AllDirectories)
|> Array.Parallel.iter (fun wsdl_file_path -> 
    let wsdl_file = new FileInfo(wsdl_file_path)

    let xsd_file = Path.ChangeExtension(wsdl_file_path,".xsd") |> FileInfo
    let wsdl_xdocument = XDocument.Load(wsdl_file.FullName)
    let maybe_xsd_element = 
        wsdl_xdocument.Root.Descendants()
        |> Seq.tryFind(fun element -> 
            match element.Name.NamespaceName, element.Name.LocalName with 
            |"http://www.w3.org/2001/XMLSchema","schema" -> true
            | _ -> false
            )
    match maybe_xsd_element with 
    | Some xsd_element -> xsd_element.Save xsd_file.FullName
    | None -> ()


)


let xsd_elements = 

    Directory.GetFiles(@"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\WebServices", "*.xsd",SearchOption.AllDirectories)
    |> Array.Parallel.collect (fun xsd_file_path -> 
    let xsd_file = new FileInfo(xsd_file_path)
    let xsd_xdocument = XDocument.Load(xsd_file.FullName)
    xsd_xdocument.Root.Elements() |> Seq.toArray

    )

xsd_elements.Length

module Mappings = 
    type H8Map = 
        {
            Key: int
            IsDefault: bool
            Name: string
            SourceFilePath: string
            SheetName: string
            ConnectionString: string
            ProviderName: string
            UploadOption: string
            IsFirstRowHeader: string
            CreatedDate: string
            CreatedBy: string
            MapColumns:H8MapColumn array
        }
    and H8MapColumn = 
        {
            MapKey: int
            SourceColumnName: string
            TargetColumnCommonId: string
            TargetColumnType: Type

        }
    module xml =
        let text =
                elem "Maps" {
                    attr "xmlns" "http://www.infor.com/Hansen8/2011/08/Maps.xsd"
                    elem "Map" {
                        attr "Importance" "10"
                        value "This segment is very important"
                        elem "avb"
                    }
                    elem "SecondSegment" {
                        attr "Importance" "2"
                        value "This segment is not very important"
                    }
                }
        let file = Path.Combine(__SOURCE_DIRECTORY__,"Mappings.xml") |> FileInfo

ElementBuilder.writeToPath Mappings.xml.file.FullName Mappings.xml.text


































































type StormLiftStationAsset =
    {
        // StormLiftStation
        ID: string

        // StormLiftStation
        UnitDesc: string option

        // StormLiftStation
        Area: string option

        // StormLiftStation
        Organization: string option

        // StormLiftStation
        Ownership: string option
    }

    static member from_conduit (conduit: Conduit_Feature) =
        {
            ID = conduit.UNITID.Value
            UnitDesc = conduit.NOTES
            Area = conduit.OUTFALLID
            Organization = conduit.MAINTBY
            Ownership = conduit.OWNER
        }


type StormServiceLineAsset =
    {
        // StormServiceLine
        ID: string

        // StormServiceLine
        UnitDesc: string option

        // StormServiceLine
        Area: string option

        // StormServiceLine
        Organization: string option

        // StormServiceLine
        Ownership: string option
    }

    static member from_culvert_cross_drain
        (culvert_cross_drain: Culvert_Cross_Drain_Feature)
        =
        {
            ID = culvert_cross_drain.UNITID.Value
            UnitDesc = culvert_cross_drain.NOTES
            Area = culvert_cross_drain.OUTFALLID
            Organization = culvert_cross_drain.MAINTBY
            Ownership = culvert_cross_drain.OWNER
        }


type StormValveAsset =
    {
        // StormValve
        ID: string

        // StormValve
        UnitDesc: string option

        // StormValve
        Area: string option

        // StormValve
        Organization: string option

        // StormValve
        Ownership: string option

        // StormValve
        AddressQualifier: string option

        // StormValve
        XCoordinate: double option

        // StormValve
        YCoordinate: double option

        // StormValve
        ZCoordinate: double option
    }

    static member from_debris_trap (debris_trap: Debris_Trap_Feature) =
        {
            ID = debris_trap.UNITID.Value
            UnitDesc = debris_trap.NOTES
            Area = debris_trap.OUTFALLID
            Organization = debris_trap.MAINTBY
            Ownership = debris_trap.OWNER
            AddressQualifier = debris_trap.LOCATION
            XCoordinate = debris_trap.x
            YCoordinate = debris_trap.y
            ZCoordinate = debris_trap.ZVALUE
        }


type StormBackflowPreventerAsset =
    {
        // StormBackflowPreventer
        ID: string

        // StormBackflowPreventer
        UnitDesc: string option

        // StormBackflowPreventer
        Area: string option

        // StormBackflowPreventer
        Organization: string option

        // StormBackflowPreventer
        Ownership: string option
    }

    static member from_ditch (ditch: Ditch_Feature) =
        {
            ID = ditch.UNITID.Value
            UnitDesc = ditch.NOTES
            Area = ditch.OUTFALLID
            Organization = ditch.MAINTBY
            Ownership = ditch.OWNER
        }


type StormNodeAsset =
    {
        // StormNode
        ID: string

        // StormNode
        UnitDesc: string option

        // StormNode
        Area: string option

        // StormNode
        Organization: string option

        // StormNode
        Ownership: string option

        // StormNode
        AddressQualifier: string option

        // StormNode
        XCoordinate: double option

        // StormNode
        YCoordinate: double option

        // StormNode
        ZCoordinate: double option
    }

    static member from_end_point (end_point: End_Point_Feature) =
        {
            ID = end_point.UNITID.Value
            UnitDesc = end_point.NOTES
            Area = end_point.OUTFALLID
            Organization = end_point.MAINTBY
            Ownership = end_point.OWNER
            AddressQualifier = end_point.LOCATION
            XCoordinate = end_point.x
            YCoordinate = end_point.y
            ZCoordinate = end_point.ZVALUE
        }


type StormInletAsset =
    {
        // StormInlet
        ID: string

        // StormInlet
        UnitDesc: string option

        // StormInlet
        Area: string option

        // StormInlet
        Organization: string option

        // StormInlet
        Ownership: string option

        // StormInlet
        AddressQualifier: string option

        // StormInlet
        XCoordinate: double option

        // StormInlet
        YCoordinate: double option

        // StormInlet
        ZCoordinate: double option
    }

    static member from_inlet (inlet: Inlet_Feature) =
        {
            ID = inlet.UNITID.Value
            UnitDesc = inlet.NOTES
            Area = inlet.OUTFALLID
            Organization = inlet.MAINTBY
            Ownership = inlet.OWNER
            AddressQualifier = inlet.LOCATION
            XCoordinate = inlet.x
            YCoordinate = inlet.y
            ZCoordinate = inlet.ZVALUE
        }


type StormManholeAsset =
    {
        // StormManhole
        ID: string

        // StormManhole
        UnitDesc: string option

        // StormManhole
        Area: string option

        // StormManhole
        Organization: string option

        // StormManhole
        Ownership: string option

        // StormManhole
        AddressQualifier: string option

        // StormManhole
        XCoordinate: double option

        // StormManhole
        YCoordinate: double option

        // StormManhole
        ZCoordinate: double option
    }

    static member from_junction_fixed
        (junction_fixed: Junction_Fixed_Feature)
        =
        {
            ID = junction_fixed.UNITID.Value
            UnitDesc = junction_fixed.NOTES
            Area = junction_fixed.OUTFALLID
            Organization = junction_fixed.MAINTBY
            Ownership = junction_fixed.OWNER
            AddressQualifier = junction_fixed.LOCATION
            XCoordinate = junction_fixed.x
            YCoordinate = junction_fixed.y
            ZCoordinate = junction_fixed.ZVALUE
        }


type ComplexAsset =
    {
        // Complex
        ID: string

        // Complex
        UnitDesc: string option

        // Complex
        Area: string option

        // Complex
        XCoordinate: double option

        // Complex
        YCoordinate: double option
    }

    static member from_outfall (outfall: Outfall_Feature) =
        {
            ID = outfall.UNITID.Value
            UnitDesc = outfall.NOTES
            Area = outfall.OUTFALLID
            XCoordinate = outfall.x
            YCoordinate = outfall.y
        }


type StormMiscellaneousAsset =
    {
        // StormMiscellaneous
        ID: string

        // StormMiscellaneous
        UnitDesc: string option

        // StormMiscellaneous
        Organization: string option

        // StormMiscellaneous
        Ownership: string option

        // StormMiscellaneous
        AddressQualifier: string option

        // StormMiscellaneous
        UnitType: string option

        // StormMiscellaneous
        XCoordinate: double option

        // StormMiscellaneous
        YCoordinate: double option

        // StormMiscellaneous
        ZCoordinate: double option
    }

    static member from_stormwater_pond
        (stormwater_pond: Stormwater_Pond_Feature)
        =
        {
            ID = stormwater_pond.UNITID.Value
            UnitDesc = stormwater_pond.NOTES
            Organization = stormwater_pond.MAINTBY
            Ownership = stormwater_pond.OWNER
            AddressQualifier = stormwater_pond.LOCATION
            UnitType = stormwater_pond.PONDTYPE
            XCoordinate = stormwater_pond.x
            YCoordinate = stormwater_pond.y
            ZCoordinate = stormwater_pond.ZVALUE
        }


type StormLeveeAsset =
    {
        // StormLevee
        ID: string

        // StormLevee
        UnitDesc: string option

        // StormLevee
        Area: string option

        // StormLevee
        Organization: string option

        // StormLevee
        Ownership: string option

        // StormLevee
        AddressQualifier: string option

        // StormLevee
        XCoordinate: double option

        // StormLevee
        YCoordinate: double option

        // StormLevee
        ZCoordinate: double option
    }

    static member from_stormwater_pond_discharge
        (stormwater_pond_discharge: Stormwater_Pond_Discharge_Feature)
        =
        {
            ID = stormwater_pond_discharge.UNITID.Value
            UnitDesc = stormwater_pond_discharge.NOTES
            Area = stormwater_pond_discharge.OUTFALLID
            Organization = stormwater_pond_discharge.MAINTBY
            Ownership = stormwater_pond_discharge.OWNER
            AddressQualifier = stormwater_pond_discharge.LOCATION
            XCoordinate = stormwater_pond_discharge.x
            YCoordinate = stormwater_pond_discharge.y
            ZCoordinate = stormwater_pond_discharge.ZVALUE
        }


type Feature_Dataset = 
    {
        map_server:ArcGISMapImageLayer
        map_server_formula:Formula
        feature_classes: Feature_Class array
    }
    static member formula (map_server:ArcGISMapImageLayer) = 
                let full_extent = map_server._prefix "full_extent"
                let FullExtent = map_server._prefix "MapServer.FullExtent" 
                let spatial_reference = map_server._prefix "spatial_reference" 
                let SpatialReference = map_server._prefix "MapServer.FullExtent.SpatialReference" 


                
                !| [
                    map_server.owl_class
                    map_server.FullExtent.owl_class
                    map_server.FullExtent.SpatialReference.owl_class
                    random_coded_value.owl_class
                    random_domain.owl_class
                    ] --- a --> owl.Class
                -!> map_server.named_individual
                    -~| map_server.predicateObjectList
                    -~| map_server.ServiceInfo.predicateObjectList
                    -~| [
                            Esri.ArcGISRuntime.sublayer ->| layer_individuals
                            a ->| [owl.NamedIndividual ; map_server.owl_class]
                        ]
                 --- full_extent
                 -->/ FullExtent
                    -~| map_server.FullExtent.predicateObjectList
                    -~| [a ->- map_server.FullExtent.owl_class]
                --- spatial_reference 
                -->/ SpatialReference
                    -~| map_server.FullExtent.SpatialReference.predicateObjectList
                    --- a --> map_server.FullExtent.SpatialReference.owl_class
                
                    

and Feature_Class = 
    {
        layer:ArcGISMapImageSublayer
        table:ServiceFeatureTable
        feature_class_formula:Formula
        features : Stormwater_Feature array 
    }
    static member formula (layer:ArcGISMapImageSublayer) = 
                                    let subtype_formulas = 
                                        layer.MapServiceSublayerInfo.FeatureSubtypes
                                        |> Seq.map (fun Subtype -> !> layer.named_individual --- Esri.ArcGISRuntime._prefix "subtype" --> MapServer._prefix $"{layer.Name}.{Subtype.Name}")
                                        |> Seq.toList
                                    let feature_individuals = 
                                        features
                                        |> Array.Parallel.filter (fun feature -> feature.layer.Id = layer.Id)
                                        |> Array.Parallel.map (fun feature ->   feature.named_individual) 
                                        |> Array.toList
                                                                                
                                    let attribute_formulas = 
                                        layer.MapServiceSublayerInfo.Fields
                                        |> Seq.map (fun field -> 
                                            !> layer.named_individual --- Esri.ArcGISRuntime._prefix "attribute"
                                            -->/ MapServer._prefix $"{layer.Name}.{field.Name}"
                                                -~|[
                                                    a ->- rdf.Property
                                                    rdfs.domain ->- layer.feature_class
                                                    
                                                ]
                                            --- Esri.ArcGISRuntime._prefix "field"
                                            -->/ MapServer._prefix field.Name
                                                -~|>[
                                                    a ->- owl.Class
                                                    rdfs.subClassOf ->- Esri.ArcGISRuntime._prefix "Field"
                                                    
                                                ]
                    
                                            )
                                        |> Seq.toList
                                    !| [
                                        Esri.ArcGISRuntime._prefix "Field"
                                        layer.feature_class
                                        layer.owl_class
                                        ] --- a --> owl.Class
                                    -!> layer.named_individual
                                        -~| layer.predicateObjectList
                                        -~| layer.MapServiceSublayerInfo.predicateObjectList
                                        -~| layer.Table.predicateObjectList
                                        -~| layer.Table.LayerInfo.predicateObjectList
                                        -~|> [
                                                    a ->| [owl.NamedIndividual ; layer.owl_class]
                                                    Esri.ArcGISRuntime._prefix "feature_class" ->- layer.feature_class
                                            ]
                                    -*| List.concat [ subtype_formulas ; attribute_formulas ]
                                    
and Feature_Entity = 
    {
        feature:Feature
        feature_formula:Formula
    }
    static member formula(feature:Feature) =
                                            !> feature.owl_class --- a --> owl.Class
                                            -!> feature.layer.named_individual
                                            --- Esri.ArcGISRuntime._prefix "feature"
                                            -->/ feature.named_individual 
                                                -~| [ a ->| [owl.NamedIndividual ; feature.owl_class]]
                                                -~|> List.concat [ 
                                                        feature.predicateObjectList
                                                        feature.predicateAttributeList
                                                        feature.predicateGeometryList
                                                        ]
                                            -*| [
                                                if feature.owl_class <> feature.feature_class then
                                                    !>feature.owl_class --- rdfs.subClassOf -->/ 
                                                    feature.feature_class -~| [ a ->- owl.Class ]
                                                    --- rdfs.subClassOf -->/ 
                                                    feature.owl_superclass --- a --> owl.Class
                                                else 
                                                    !>feature.feature_class -~| [ a ->- owl.Class ]
                                                    --- rdfs.subClassOf -->/ 
                                                    feature.owl_superclass --- a --> owl.Class

                                            ]
                                            -*| [
                                                if feature.OUTFALLID.IsSome then 
                                                    !< feature.named_individual --- MapServer._prefix "outfall" -->/ 
                                                    MapServer._prefix feature.OUTFALLID.Value  -~| [ a ->- owl.NamedIndividual] --- a -->/ 
                                                    MapServer._prefix "Outfall" --- a --> owl.Class
                                            ]


let domain_formula = 
    { Formula.Empty with triples = 
                                    domains
                                    |> Array.map (fun domain -> 
                                                                    let coded_value_individuals = domain.CodedValues |> Seq.map (fun coded_value -> coded_value.named_individual domain.Name) |> Seq.toList

                                                                    !> domain.named_individual -~|> [ 
                                                                        a ->- domain.owl_class
                                                                        MapServer._prefix "coded_value" ->| coded_value_individuals
        
                                                                    ]
                                    )
                                    |> Array.toSeq
                                    |> Seq.collect (fun formula -> formula.triples)
                                    |> HashSet.ofSeq
    }

let coded_value_formula = 
    { Formula.Empty with triples = 

                                    coded_values
                                    |> Array.map (fun (coded_value,domain) -> 
                                        let coded_value_individual = coded_value.named_individual domain.Name
                                        let code_literal = 
                                            match domain.FieldType.ToString() with 
                                            | "Int16" -> string coded_value.Code |> Int16.Parse |> RDF_Literal.autotyped
                                            | "Float64" -> string coded_value.Code |> Double.Parse |> RDF_Literal.autotyped
                                            | "Date" -> string coded_value.Code |> DateTime.Parse |> RDF_Literal.autotyped
                                            | "Int32" -> string coded_value.Code |> Int32.Parse |> RDF_Literal.autotyped
                                            | _-> string coded_value.Code |> RDF_Literal.autotyped

                                        !> coded_value_individual -~|> [
                                            a ->- coded_value.owl_class
                                            MapServer._prefix "coded_value_code" ->- code_literal
                                            MapServer._prefix "coded_value_name" ->- RDF_Literal.simple coded_value.Name


                                        ])
                                    |> Array.toSeq
                                    |> Seq.collect (fun formula -> formula.triples)
                                    |> HashSet.ofSeq
    }















// TODO move into doxaletheia

let save_gzipped_turtle
    (file_path: string)
    (graph: IGraph)
    =
    use file_stream =
        new FileStream(
            file_path,
            FileMode.Create,
            FileAccess.Write,
            FileShare.None
        )

    use gzip_stream =
        new GZipStream(
            file_stream,
            CompressionLevel.Optimal
        )

    use text_writer =
        new StreamWriter(
            gzip_stream,
            UTF8Encoding(false)
        )

    let turtle_writer =
        CompressingTurtleWriter()

    turtle_writer.Save(graph, text_writer)








let feature_dataset = 
    {
        map_server = MapServer
        map_server_formula = Feature_Dataset.formula MapServer
        feature_classes = 
            layers
            |> Array.Parallel.filter (fun layer -> layer.Table <> null)
            |> Array.Parallel.map (fun layer -> 
            {
                layer = layer
                table = layer.Table
                feature_class_formula = Feature_Class.formula layer
                features = 
                    features
                    |> Array.Parallel.choose(fun feature -> 
                        if feature.table.LayerInfo.ServiceLayerId = layer.Id then 
                            Some ( {
                                    feature = feature
                                    feature_formula = Feature_Entity.formula feature
                            } )
                        else 
                            None
                        )

            }
            )
    }


domain_formula |> write_draft feature_dataset.map_server.directory.FullName "domains"
coded_value_formula |> write_draft feature_dataset.map_server.directory.FullName "coded_values"
feature_dataset.map_server_formula |> write_draft feature_dataset.map_server.directory.FullName feature_dataset.map_server.Name.low_lined
feature_dataset.feature_classes
// |> Array.Parallel.filter (fun feature_class -> feature_class.layer.Name = "Inlet")
|> Array.Parallel.iter (fun feature_class -> 
    feature_class.feature_class_formula |> write_draft feature_class.layer.directory.FullName feature_class.layer.Name.low_lined
    feature_class.features
    |> Array.Parallel.iter (fun stormwater_feature ->
         stormwater_feature.feature_formula |> write_draft stormwater_feature.feature.directory.FullName stormwater_feature.feature.id.low_lined ) 
         )


















































let esri_files = (DirectoryPathInfo MapServer.directory).descendant_files "*.ttl"

let esri_dataset = new InMemoryDataset(new DiskDemandTripleStore(), true, false)



let esri_graph  =
    esri_files
    // |> Array.Parallel.filter (fun file_path -> not (file_path.Contains(fibo_substring) ))
    |> Array.iteri (fun file_index ttl_file_path -> 
        let ttl_file = PathInfo.from_string ttl_file_path
        let vocabulary_name = Iri_Reference(ttl_file.path) |> IRIREF
        printfn "file %d of %d\t\t%s" file_index esri_files.Length vocabulary_name.lexical_form
        esri_dataset.HasGraph(vocabulary_name.vds_node) |> ignore
        )
    let graph = new ThreadSafeGraph()
    graph.Assert(esri_dataset.Triples) |> ignore
    graph



save_gzipped_turtle @"D:\Artifact\Company\Esri\LCPW_OverlayStormwaterInfrastructure_D_WM\LCPW_OverlayStormwaterInfrastructure_D_WM.ttl.gz" esri_graph
































let layer'table_names =
    [| "Inlet", "Hansen.AssetManagement.Storm.StormInlet"
       "Conduit", "Hansen.AssetManagement.Storm.StormLiftStation"
       "Culvert Cross Drain", "Hansen.AssetManagement.Storm.StormServiceLine"
       "Debris Trap", "Hansen.AssetManagement.Storm.StormValve"
       "Ditch", "Hansen.AssetManagement.Storm.StormBackflowPreventer"
       "End Point", "Hansen.AssetManagement.Storm.StormNode"
       "Junction Fixed", "Hansen.AssetManagement.Storm.StormManhole"
       "Outfall", "Hansen.AssetManagement.UsageArea.Complex"
       "Stormwater Pond", "Hansen.AssetManagement.Storm.StormMiscellaneous"
       "Stormwater Pond Discharge", "Hansen.AssetManagement.Storm.StormLevee"

       |]


let layer'field'productFamily'table'column_names =
    [|

       "Conduit", "UNITID", "AssetManagement.Storm", "StormLiftStation", "ID"
       "Conduit", "NOTES", "AssetManagement.Storm", "StormLiftStation", "UnitDesc"
       "Conduit", "OUTFALLID", "AssetManagement.Storm", "StormLiftStation", "Area"
       "Conduit", "MAINTBY", "AssetManagement.Storm", "StormLiftStation", "Organization"
       "Conduit", "OWNER", "AssetManagement.Storm", "StormLiftStation", "Ownership"
       "Culvert Cross Drain", "UNITID", "AssetManagement.Storm", "StormServiceLine", "ID"
       "Culvert Cross Drain", "NOTES", "AssetManagement.Storm", "StormServiceLine", "UnitDesc"
       "Culvert Cross Drain", "OUTFALLID", "AssetManagement.Storm", "StormServiceLine", "Area"
       "Culvert Cross Drain", "MAINTBY", "AssetManagement.Storm", "StormServiceLine", "Organization"
       "Culvert Cross Drain", "OWNER", "AssetManagement.Storm", "StormServiceLine", "Ownership"
       "Debris Trap", "UNITID", "AssetManagement.Storm", "StormValve", "ID"
       "Debris Trap", "NOTES", "AssetManagement.Storm", "StormValve", "UnitDesc"
       "Debris Trap", "OUTFALLID", "AssetManagement.Storm", "StormValve", "Area"
       "Debris Trap", "MAINTBY", "AssetManagement.Storm", "StormValve", "Organization"
       "Debris Trap", "OWNER", "AssetManagement.Storm", "StormValve", "Ownership"
       "Debris Trap", "LOCATION", "AssetManagement.Storm", "StormValve", "AddressQualifier"
       "Debris Trap", "x", "AssetManagement.Storm", "StormValve", "XCoordinate"
       "Debris Trap", "y", "AssetManagement.Storm", "StormValve", "YCoordinate"
       "Debris Trap", "ZVALUE", "AssetManagement.Storm", "StormValve", "ZCoordinate"
       "Ditch", "UNITID", "AssetManagement.Storm", "StormBackflowPreventer", "ID"
       "Ditch", "NOTES", "AssetManagement.Storm", "StormBackflowPreventer", "UnitDesc"
       "Ditch", "OUTFALLID", "AssetManagement.Storm", "StormBackflowPreventer", "Area"
       "Ditch", "MAINTBY", "AssetManagement.Storm", "StormBackflowPreventer", "Organization"
       "Ditch", "OWNER", "AssetManagement.Storm", "StormBackflowPreventer", "Ownership"
       "End Point", "UNITID", "AssetManagement.Storm", "StormNode", "ID"
       "End Point", "NOTES", "AssetManagement.Storm", "StormNode", "UnitDesc"
       "End Point", "OUTFALLID", "AssetManagement.Storm", "StormNode", "Area"
       "End Point", "MAINTBY", "AssetManagement.Storm", "StormNode", "Organization"
       "End Point", "OWNER", "AssetManagement.Storm", "StormNode", "Ownership"
       "End Point", "LOCATION", "AssetManagement.Storm", "StormNode", "AddressQualifier"
       "End Point", "x", "AssetManagement.Storm", "StormNode", "XCoordinate"
       "End Point", "y", "AssetManagement.Storm", "StormNode", "YCoordinate"
       "End Point", "ZVALUE", "AssetManagement.Storm", "StormNode", "ZCoordinate"
       "Inlet", "UNITID", "AssetManagement.Storm", "StormInlet", "ID"
       "Inlet", "NOTES", "AssetManagement.Storm", "StormInlet", "UnitDesc"
       "Inlet", "OUTFALLID", "AssetManagement.Storm", "StormInlet", "Area"
       "Inlet", "MAINTBY", "AssetManagement.Storm", "StormInlet", "Organization"
       "Inlet", "OWNER", "AssetManagement.Storm", "StormInlet", "Ownership"
       "Inlet", "LOCATION", "AssetManagement.Storm", "StormInlet", "AddressQualifier"
       "Inlet", "x", "AssetManagement.Storm", "StormInlet", "XCoordinate"
       "Inlet", "y", "AssetManagement.Storm", "StormInlet", "YCoordinate"
       "Inlet", "ZVALUE", "AssetManagement.Storm", "StormInlet", "ZCoordinate"
       "Junction Fixed", "UNITID", "AssetManagement.Storm", "StormManhole", "ID"
       "Junction Fixed", "NOTES", "AssetManagement.Storm", "StormManhole", "UnitDesc"
       "Junction Fixed", "OUTFALLID", "AssetManagement.Storm", "StormManhole", "Area"
       "Junction Fixed", "MAINTBY", "AssetManagement.Storm", "StormManhole", "Organization"
       "Junction Fixed", "OWNER", "AssetManagement.Storm", "StormManhole", "Ownership"
       "Junction Fixed", "LOCATION", "AssetManagement.Storm", "StormManhole", "AddressQualifier"
       "Junction Fixed", "x", "AssetManagement.Storm", "StormManhole", "XCoordinate"
       "Junction Fixed", "y", "AssetManagement.Storm", "StormManhole", "YCoordinate"
       "Junction Fixed", "ZVALUE", "AssetManagement.Storm", "StormManhole", "ZCoordinate"
       "Outfall", "UNITID", "AssetManagement.UsageArea", "Complex", "ID"
       "Outfall", "NOTES", "AssetManagement.UsageArea", "Complex", "UnitDesc"
       "Outfall", "OUTFALLID", "AssetManagement.UsageArea", "Complex", "Area"
       "Outfall", "x", "AssetManagement.UsageArea", "Complex", "XCoordinate"
       "Outfall", "y", "AssetManagement.UsageArea", "Complex", "YCoordinate"
       "Stormwater Pond", "UNITID", "AssetManagement.Storm", "StormMiscellaneous", "ID"
       "Stormwater Pond", "NOTES", "AssetManagement.Storm", "StormMiscellaneous", "UnitDesc"
       "Stormwater Pond", "MAINTBY", "AssetManagement.Storm", "StormMiscellaneous", "Organization"
       "Stormwater Pond", "OWNER", "AssetManagement.Storm", "StormMiscellaneous", "Ownership"
       "Stormwater Pond", "LOCATION", "AssetManagement.Storm", "StormMiscellaneous", "AddressQualifier"
       "Stormwater Pond", "PONDTYPE", "AssetManagement.Storm", "StormMiscellaneous", "UnitType"
       "Stormwater Pond", "x", "AssetManagement.Storm", "StormMiscellaneous", "XCoordinate"
       "Stormwater Pond", "y", "AssetManagement.Storm", "StormMiscellaneous", "YCoordinate"
       "Stormwater Pond", "ZVALUE", "AssetManagement.Storm", "StormMiscellaneous", "ZCoordinate"
       "Stormwater Pond Discharge", "UNITID", "AssetManagement.Storm", "StormLevee", "ID"
       "Stormwater Pond Discharge", "NOTES", "AssetManagement.Storm", "StormLevee", "UnitDesc"
       "Stormwater Pond Discharge", "OUTFALLID", "AssetManagement.Storm", "StormLevee", "Area"
       "Stormwater Pond Discharge", "MAINTBY", "AssetManagement.Storm", "StormLevee", "Organization"
       "Stormwater Pond Discharge", "OWNER", "AssetManagement.Storm", "StormLevee", "Ownership"
       "Stormwater Pond Discharge", "LOCATION", "AssetManagement.Storm", "StormLevee", "AddressQualifier"
       "Stormwater Pond Discharge", "x", "AssetManagement.Storm", "StormLevee", "XCoordinate"
       "Stormwater Pond Discharge", "y", "AssetManagement.Storm", "StormLevee", "YCoordinate"
       "Stormwater Pond Discharge", "ZVALUE", "AssetManagement.Storm", "StormLevee", "ZCoordinate"


       |]


















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

module HansenDataDistribution =
    [<Literal>]
    let file_path =
        @"D:/Surface/Company/Infor/Download_Center/Product/Operations_and_Regulations/Release/Infor_Public_Sector_2025_04_01/IPS_2025_04_01/Deployment Files/MetaData/MetaData.xml"

    let xml = XmlProvider<file_path>.Load file_path
    let navigator = XPathNavigator.Load(file_path)


module Folder = 
    let MetaData = !/ @"D:\Artifact\Company\Infor\MetaData"
    let H8ImportTool = MetaData ./ "H8ImportTool"
    let SystemLicense = MetaData ./ "SystemLicense"
    let DomainColumn = MetaData ./ "DomainColumn"
    let ProductFamily = MetaData ./ "ProductFamily"




































let system_license_formula = 
    { 
        Formula.Empty with triples = 
                                        HansenDataDistribution.xml.HansenMetadata.SystemLicenses
                                        |> Seq.collect (fun SystemLicense -> 
                                            let system_license = infor._prefix SystemLicense.Name
                                            let owl_class = infor._element_class SystemLicense.XElement.Name.LocalName
                                            let formula = 
                                                !> owl_class --- a --> owl.Class 
                                                -!> system_license
                                                    -~|> [
                                                            a ->- owl_class
                                                            infor.name ->= SystemLicense.Name
                                                            if SystemLicense.Description.IsSome && not (String.IsNullOrWhiteSpace SystemLicense.Description.Value) then 
                                                                infor.description ->= SystemLicense.Description.Value
                                                            if SystemLicense.EffectiveDateTime.IsSome then 
                                                                infor.effectiveDateTime ->= SystemLicense.EffectiveDateTime.Value
                                                    ]
                                            formula.triples
                                        )
                                        |> HashSet.ofSeq

    }

system_license_formula |> write_draft Folder.SystemLicense.path "SystemLicense"

let domain_column_formula = 
    { 
        Formula.Empty with triples = 
                                        HansenDataDistribution.xml.HansenMetadata.DomainColumns
                                        |> Seq.collect (fun DomainColumn -> 
                                            let domain_column = infor._prefix DomainColumn.Name
                                            let owl_class = infor._element_class DomainColumn.XElement.Name.LocalName
                                            let formula =
                                                !> owl_class --- a --> owl.Class 
                                                -!> domain_column
                                                    -~|> [
                                                            a ->- owl_class
                                                            infor.name ->= DomainColumn.Name
                                                            infor.databaseName ->= DomainColumn.DatabaseName
                                                            if DomainColumn.DefaultValue.IsSome && not (String.IsNullOrWhiteSpace DomainColumn.DefaultValue.Value) then 
                                                                infor.defaultValue ->= DomainColumn.DefaultValue.Value
                                                            infor.length ->= DomainColumn.Length
                                                            infor.isRequired ->= DomainColumn.IsRequired
                                                            infor.type_ ->= DomainColumn.Type
                                                            infor.dataScale ->= DomainColumn.DataScale
                                                            infor.dataPrecision ->= DomainColumn.DataPrecision
                                                            infor.showSearchOrder ->= DomainColumn.ShowSearchOrder
                                                            infor.useSearchOrder ->= DomainColumn.UseSearchOrder
                                                            infor.isNullable ->= DomainColumn.IsNullable
                                                            infor.locale ->= DomainColumn.Locale
                                                    ]
                                            formula.triples
                                        )
                                        |> HashSet.ofSeq

    }
domain_column_formula |> write_draft Folder.DomainColumn.path "DomainColumn"

let product_family_schemas = 
    HansenDataDistribution.xml.HansenMetadata.ProductFamilies
    |> Array.Parallel.choose (fun ProductFamily -> 
        InforProdSql.operations.Schemas |> PSeq.tryFind (fun Schema -> 
                            let fully_qualified_name = InforProdSql.operations.tbox.DisplayServices.GetElementName(Schema, ElementNameStyle.FullyQualifiedName)
                            fully_qualified_name = ProductFamily.Name.ToUpperInvariant().Replace('.','_')
                            
                            )
    )

let product_family_formulas = 
                                        HansenDataDistribution.xml.HansenMetadata.ProductFamilies
                                        |> Array.Parallel.map (fun ProductFamily -> 
                                            let product_family = infor._prefix ProductFamily.Name
                                            let schema_name = ProductFamily.Name.ToUpperInvariant().Replace('.','_')
                                            let database_schema = InforProdSql._prefix schema_name
                                            let directory = Folder.ProductFamily ./ ProductFamily.Name
                                            let owl_class = infor._element_class ProductFamily.XElement.Name.LocalName
                                            let tables = 
                                                ProductFamily.Tables |> Array.Parallel.map (fun table -> infor._prefix $"Hansen.{ProductFamily.Name}.{table.Name}") |> Array.toList
                                            let database_tables = 
                                                ProductFamily.Tables |> Array.Parallel.map (fun table -> InforProdSql._prefix $"{schema_name}.{table.DatabaseName}") |> Array.toList
                                            let formula =
                                                !| [InforProdSql.Schema ; owl_class ] --- a --> owl.Class 
                                                -!> product_family
                                                    -~| [
                                                            a ->- owl_class
                                                            infor.name ->= ProductFamily.Name
                                                            infor.isAgencyEnhancable ->= ProductFamily.IsAgencyEnhancable
                                                            infor.owner ->= ProductFamily.Owner
                                                            infor.isHansen ->= ProductFamily.IsHansen 
                                                            infor.table ->| tables
                                                            infor.databaseTable ->| database_tables

                                                        ]
                                                --- infor.databaseSchema
                                                -->/ database_schema 
                                                    -~|> [ 
                                                            a ->- InforProdSql.Schema
                                                            infor.databaseName ->= schema_name
                                                        ]
                                                    
                                            formula |> write_draft directory.path ProductFamily.Name
                                            formula
                                        )

let target_product_families = 
    set [
        "AssetManagement"
        "AssetManagement.Storm"
        "AssetManagement.UsageArea"
    ]



let table_formulas = 
                                        HansenDataDistribution.xml.HansenMetadata.ProductFamilies
                                        |> Array.Parallel.filter (fun ProductFamily -> target_product_families.Contains(ProductFamily.Name))
                                        |> Array.Parallel.collect (fun ProductFamily -> 
                                            let product_family = infor._prefix ProductFamily.Name
                                            let schema_name = ProductFamily.Name.ToUpperInvariant().Replace('.','_')
                                            let database_schema = InforProdSql._prefix schema_name
                                            ProductFamily.Tables
                                            |> Array.Parallel.filter (fun Table -> Table.DatabaseName.StartsWith("COMP"))
                                            |> Array.Parallel.map (fun Table -> 
                                            

                                                let directory = Folder.ProductFamily ./ ProductFamily.Name ./ Table.Name
                                                let owl_class = infor._element_class Table.XElement.Name.LocalName
                                                let table = infor._prefix $"Hansen.{ProductFamily.Name}.{Table.Name}"
                                                let database_table = InforProdSql._prefix $"{schema_name}.{Table.DatabaseName}"
                                                let columns = 
                                                    Table.Columns |> Array.Parallel.map (fun Column -> infor._prefix $"Hansen.{ProductFamily.Name}.{Table.Name}.{Column.Name}") |> Array.toList
                                                let database_columns = 
                                                    Table.Columns |> Array.Parallel.map (fun Column -> InforProdSql._prefix $"{schema_name}.{Table.DatabaseName}.{Column.DatabaseName}") |> Array.toList
                                                let primary_keys = 
                                                    match Table.PrimaryKeyConstraint with 
                                                    | Some primaryKeyConstraint -> primaryKeyConstraint.LocalColumnReferences |> Array.map (fun LocalColumnReference -> infor._prefix $"Hansen.{LocalColumnReference.Name}") |> Array.toList
                                                    | None -> []

                                                let referencing_formulas = 
                                                    Table.ReferencingConstraints
                                                    |> Array.collect (fun ReferencingConstraint -> 
                                                        Array.zip ReferencingConstraint.LocalColumnReferences ReferencingConstraint.ForeignColumnReferences
                                                        |> Array.map (fun (LocalColumnReference,ForeignColumnReference) -> 
                                                            let local_column = infor._prefix $"Hansen.{LocalColumnReference.Name}"
                                                            let foreign_column = infor._prefix $"Hansen.{ForeignColumnReference.Name}"
                                                            !> local_column --- infor.value_referenced_by  -->/ foreign_column --- infor.value_references --> local_column
                                                            
                                                             )
                                                        )
                                                        |> Array.toList
                                                let foreign_key_formulas = 
                                                    Table.ForeignKeyConstraints
                                                    |> Array.collect (fun ForeignKeyConstraint -> 
                                                        Array.zip ForeignKeyConstraint.LocalColumnReferences ForeignKeyConstraint.ForeignColumnReferences
                                                        |> Array.map (fun (LocalColumnReference,ForeignColumnReference) -> 
                                                            let local_column = infor._prefix $"Hansen.{LocalColumnReference.Name}"
                                                            let foreign_column = infor._prefix $"Hansen.{ForeignColumnReference.Name}"
                                                            !> local_column --- infor.value_references  -->/ foreign_column --- infor.value_referenced_by  --> local_column
                                                            
                                                             )
                                                        )
                                                        |> Array.toList
                                                let enumeration_formulas = 
                                                    Table.EnumerationCheckConstraints
                                                    |> Array.map (fun EnumerationCheckConstraint -> !>(infor._prefix $"Hansen.{EnumerationCheckConstraint.LocalColumnReference}") --- infor.enumeration --> (infor._prefix $"Enumeration.{EnumerationCheckConstraint.EnumerationName}") )
                                                    |> Array.toList
                                                let unique_formulas = 
                                                    Table.UniqueConstraints
                                                    |> Array.collect (fun UniqueConstraint -> 
                                                        UniqueConstraint.LocalColumnReferences
                                                        |> Array.map (fun LocalColumnReference -> !> (infor._prefix $"Hansen.{LocalColumnReference.Name}") --- a --> infor.UniqueColumn))
                                                    |> Array.toList
                                                let maybe_table_key = table_key_from_name Table.Name
                                                let formula =
                                                    !| [ InforProdSql.Table ; owl_class ] --- a --> owl.Class 
                                                    -!> database_table --- a --> InforProdSql.Table
                                                    -*| referencing_formulas
                                                    -*| foreign_key_formulas
                                                    -*| enumeration_formulas
                                                    -*| unique_formulas
                                                    -!> table
                                                        -~|> [
                                                                a ->- owl_class
                                                                infor.name ->= Table.Name
                                                                infor.productFamily ->- product_family
                                                                infor.databaseSchema ->- database_schema
                                                                infor.databaseName ->= Table.DatabaseName
                                                                infor.databaseTable ->- database_table
                                                                infor.hasNullRecord ->= Table.HasNullRecord
                                                                infor.type_ ->= Table.Type
                                                                infor.deploymentStatus ->= Table.DeploymentStatus
                                                                infor.isLicensed ->= Table.IsLicensed
                                                                infor.locale ->= Table.Text.Locale
                                                                if Table.Text.Description.IsSome && not (String.IsNullOrWhiteSpace Table.Text.Description.Value) then 
                                                                    infor.description ->= Table.Text.Description.Value
                                                                if Table.Text.Remarks.IsSome && not (String.IsNullOrWhiteSpace Table.Text.Remarks.Value) then 
                                                                    infor.remarks ->= Table.Text.Remarks.Value
                                                                infor.primaryKeyColumn ->| primary_keys
                                                                if maybe_table_key.IsSome then
                                                                    infor.table_key ->= maybe_table_key.Value
                                                                

                                                            ]
                                                    
                                                formula |> write_draft directory.path Table.Name
                                                formula
                                            )
                                        )


let column_formulas = 
                                        HansenDataDistribution.xml.HansenMetadata.ProductFamilies
                                        |> Array.Parallel.filter (fun ProductFamily -> target_product_families.Contains(ProductFamily.Name))
                                        |> Array.Parallel.collect (fun ProductFamily -> 
                                            let product_family = infor._prefix ProductFamily.Name
                                            let schema_name = ProductFamily.Name.ToUpperInvariant().Replace('.','_')
                                            let database_schema = InforProdSql._prefix schema_name
                                            ProductFamily.Tables
                                            |> Array.Parallel.filter (fun Table -> Table.DatabaseName.StartsWith("COMP"))
                                            |> Array.Parallel.collect (fun Table -> 
                                            
                                                let table = infor._prefix $"Hansen.{ProductFamily.Name}.{Table.Name}"
                                                let database_table = InforProdSql._prefix $"{schema_name}.{Table.DatabaseName}"
                                                let primary_key_formulas = 
                                                    match Table.PrimaryKeyConstraint with 
                                                    | Some primaryKeyConstraint -> primaryKeyConstraint.LocalColumnReferences |> Array.map (fun LocalColumnReference -> !> (infor._prefix $"Hansen.{LocalColumnReference.Name}") --- a --> infor.PrimaryKeyColumn) |> Array.toList
                                                    | None -> []

                                                Table.Columns
                                                |> Array.Parallel.map (fun Column -> 
                                                
                                                    let directory = Folder.ProductFamily ./ ProductFamily.Name ./ Table.Name ./ Column.Name
                                                    let owl_class = infor._element_class Column.XElement.Name.LocalName
                                                    let column = infor._prefix $"Hansen.{ProductFamily.Name}.{Table.Name}.{Column.Name}"
                                                    let database_column = InforProdSql._prefix $"{schema_name}.{Table.DatabaseName}.{Column.DatabaseName}"
                                                    // TODO handle referencing  and referenced by columns 
                                                    (*
                                                    let columns = 
                                                        Table.Columns |> Array.Parallel.map (fun Column -> infor._prefix $"Hansen.{ProductFamily.Name}.{Table.Name}.{Column.Name}") |> Array.toList
                                                    let database_columns = 
                                                        Table.Columns |> Array.Parallel.map (fun Column -> InforProdSql._prefix $"{schema_name}.{Table.DatabaseName}.{Column.DatabaseName}") |> Array.toList
                                                    *)
                                                    let formula =
                                                        !| [ InforProdSql.Column ; infor.PrimaryKeyColumn ; owl_class ] --- a --> owl.Class 
                                                        -!> database_column --- a --> InforProdSql.Column
                                                        -*| primary_key_formulas
                                                        -!> table -~| [infor.databaseColumn ->- database_column]
                                                        --- infor.column
                                                         -->/column
                                                            -~|> [
                                                                    a ->- owl_class
                                                                    infor.name ->= Column.Name
                                                                    infor.isNullable ->= Column.IsNullable
                                                                    infor.databaseName ->= Column.DatabaseName
                                                                    if Column.DefaultValue.IsSome && not (String.IsNullOrWhiteSpace Column.DefaultValue.Value) then 
                                                                        infor.defaultValue ->= Column.DefaultValue.Value
                                                                    infor.length ->= Column.Length
                                                                    infor.isRequired ->= Column.IsRequired
                                                                    infor.type_ ->= Column.Type
                                                                    infor.dataScale ->= Column.DataScale
                                                                    infor.dataPrecision ->= Column.DataPrecision
                                                                    infor.showSearchOrder ->= Column.ShowSearchOrder
                                                                    infor.useSearchOrder ->= Column.UseSearchOrder
                                                                    infor.locale ->= Column.Text.Locale
                                                                    if Column.Text.Description.IsSome && not (String.IsNullOrWhiteSpace Column.Text.Description.Value) then 
                                                                        infor.description ->= Column.Text.Description.Value
                                                                    if Column.Text.Remarks.IsSome && not (String.IsNullOrWhiteSpace Column.Text.Remarks.Value) then 
                                                                        infor.remarks ->= Column.Text.Remarks.Value
                                                                    if Column.Text.DisplayDescription.IsSome && not (String.IsNullOrWhiteSpace Column.Text.DisplayDescription.Value) then 
                                                                        infor.displayDescription ->= Column.Text.DisplayDescription.Value
                                                                    if Column.Text.DisplayTitle.IsSome && not (String.IsNullOrWhiteSpace Column.Text.DisplayTitle.Value) then 
                                                                        infor.displayTitle ->= Column.Text.DisplayTitle.Value
                                                                    if Column.Text.DisplayTitleLong.IsSome && not (String.IsNullOrWhiteSpace Column.Text.DisplayTitleLong.Value) then 
                                                                        infor.displayTitleLong ->= Column.Text.DisplayTitleLong.Value
                                                                ]
                                                    
                                                    formula |> write_draft directory.path Table.Name
                                                    formula

                                                )

                                            )
                                        )
// TODO hansenMetaData enumerations



module Hansen8ClientProxies =
    [<Literal>]
    let file_path =
        @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen8ClientProxies.dll"

    let dll = Assembly.LoadFile file_path
let moniker_to_target_column_type (productFamily_name: string) (table_name: string) (column_name: string) =
    match productFamily_name, table_name, column_name with
    | _, _, "Organization" -> "System.String"
    | _, _, _ ->
        let clrTable =
            Hansen8ClientProxies.dll.DefinedTypes
            |> Seq.tryFind (fun moniker -> moniker.FullName = $"Hansen.{productFamily_name}.{table_name}")
            |> Option.get
        try
            let clrColumn =
                clrTable.DeclaredFields
                |> Seq.tryFind (fun declared_field -> declared_field.Name = column_name)
                |> Option.get

            clrColumn.FieldType.FullName
        with
        | err -> failwithf "Hansen.%s.%s.%s failed with message %s" productFamily_name table_name column_name err.Message
let table_databaseName_from_name =

    HansenDataDistribution.navigator
    |> xpath "//table"
    |> Array.Parallel.map (fun table -> table.Attribute "name", table.Attribute "databaseName")
    |> Map.ofArray

let h8import_formula =
    { 
        Formula.Empty with triples = 
                                        layer'table_names
                                        |> Seq.collect (fun (esri_layer_name,infor_table_name) -> 

                                            let map_name = $"{esri_layer_name.low_lined}_to_Hansen.{infor_table_name}"
                                            let map = h8importtool._prefix map_name
                                            let esri_layer = MapServer._prefix esri_layer_name
                                            let infor_table = infor._prefix $"Hansen.{infor_table_name}"
                                            let filtered_names = 
                                                layer'field'productFamily'table'column_names
                                                |> Array.filter(fun (layer_name, field_name, productFamily_name, table_name, column_name) -> layer_name = esri_layer_name && $"{productFamily_name}.{table_name}" = infor_table_name)
                                            let formula = 
                                                
                                               !> h8importtool.Maps 
                                               --- h8importtool.map
                                               -->/ map -~|> [
                                                    a ->- h8importtool.Map
                                                    h8importtool.Name ->= map_name
                                                    h8importtool.from_layer ->- esri_layer
                                                    h8importtool.to_table ->- infor_table
                                                    h8importtool.ProductFamilyOwner ->= "Hansen"
                                                    h8importtool.IsDefault ->= false
                                                    h8importtool.SheetName ->= esri_layer_name
                                                    h8importtool.ProviderName ->= "System.Data.OleDb"
                                                    h8importtool.UploadOption ->= 6
                                                    h8importtool.IsFirstRowHeader ->= true
                                                    h8importtool.CreatedDate ->= DateTime.Now
                                                    h8importtool.CreatedBy ->= @"LEONAD\collierb"
                                                    
                                                ]
                                                -*| [
                                                    for layer_name, field_name, productFamily_name, table_name, column_name in filtered_names do
                                                        let map_column_name = $"{layer_name}.{field_name}_to_Hansen.{productFamily_name}.{table_name}.{column_name}"
                                                        let map_column = h8importtool._prefix map_column_name
                                                        let source_field = MapServer._prefix $"{layer_name}.{field_name}"
                                                        let target_column = infor._prefix $"Hansen.{productFamily_name}.{table_name}.{column_name}"
                                                        let column_type = moniker_to_target_column_type productFamily_name table_name column_name
                                                        let table_key =  table_key_from_name table_name |> Option.get

                                                        !> map 
                                                        -~| [
                                                            h8importtool.ProductFamilyName ->= productFamily_name
                                                            h8importtool.TableName ->= table_databaseName_from_name[table_name]
                                                            h8importtool.TableCommonId ->= table_name

                                                        ]
                                                        --- h8importtool.map_column 
                                                        -->/ map_column -~|> [
                                                            a ->- h8importtool.MapColumn
                                                            h8importtool.from_field ->- source_field
                                                            h8importtool.to_column ->- target_column
                                                            h8importtool.TargetColumnCommonId ->= column_name
                                                            h8importtool.TargetColumnType ->= column_type

                                                            ]
                                                ]
                                            formula.triples
                                        )
                                        |> HashSet.ofSeq

    }
!| [
        h8importtool.Mapping
        h8importtool.MapColumn
        h8importtool.Map
     ] --- a --> owl.Class
-!| [
        h8importtool.ProductFamilyOwner
        h8importtool.ProductFamilyName
        h8importtool.TableName
        h8importtool.TableCommonId
        h8importtool.TableKey

] --- rdfs.subPropertyOf --> h8importtool.MapTableInformation
-!> h8importtool.Maps -~|
    [
        a ->- h8importtool.Mapping
        www2k.xmlns ->= "http://www.infor.com/Hansen8/2011/08/Maps.xsd"

    ]
-*| [h8import_formula] |> write_draft Folder.H8ImportTool.path "H8ImportTool"






let infor_files = Folder.MetaData.descendant_files "*.ttl"

let infor_dataset = new InMemoryDataset(new DiskDemandTripleStore(), true, false)



let infor_graph  =
    infor_files
    // |> Array.Parallel.filter (fun file_path -> not (file_path.Contains(fibo_substring) ))
    |> Array.iteri (fun file_index ttl_file_path -> 
        let ttl_file = PathInfo.from_string ttl_file_path
        let vocabulary_name = Iri_Reference(ttl_file.path) |> IRIREF
        printfn "file %d of %d\t\t%s" file_index infor_files.Length vocabulary_name.lexical_form
        infor_dataset.HasGraph(vocabulary_name.vds_node) |> ignore
        )
    let graph = new ThreadSafeGraph()
    graph.Assert(infor_dataset.Triples) |> ignore
    graph



save_gzipped_turtle Document.infor_graph.path infor_graph







fsi.AddPrinter<ArcGISFeature>(fun feature ->  (feature.attributes |> Map.toArray |> Array.map (fun attribute -> sprintf "%O" attribute) |> String.concat "\n") + "\n\n")


let sample_features = 
    target_layers
    |> Seq.map (fun layer -> 

        layer,features
        |> Array.Parallel.filter (fun feature -> feature.layer.Name = layer)
        |> Array.randomSample 3
        |> Array.map (fun feature -> feature.id,feature)

    )
    |> Seq.toArray



let conduit_features = 
    features
    |> Array.Parallel.filter (fun feature -> feature.layer.Name = "Conduit")
















let random_conduit = conduit_features |> Array.randomChoice

random_conduit.attributes |> Map.toArray |> Array.iter (fun attribute -> printfn "%O" attribute)
random_conduit.attributes
|> Map.toArray
|> Array.choose(fun (attribute_name,_) ->

    layer'field'productFamily'table'column_names
    |> Array.tryFind (fun (layer_name, field_name, productFamily_name, table_name, column_name) -> 
        layer_name = "Conduit" && field_name = attribute_name)
    )
     



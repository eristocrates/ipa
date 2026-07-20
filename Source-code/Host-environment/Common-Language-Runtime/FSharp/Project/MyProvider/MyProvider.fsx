// C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\RdfProvided.txt
fsi.ShowDeclarationValues <- false
# time on
open System
open System.IO
open System.Text

#r "nuget: FSharp.Data.Adaptive, 1.2.26"
// open FSharp.Data.Adaptive

#r "nuget: Unquote"

open Swensen.Unquote.Assertions

#r "nuget: Blake3"
open Blake3



#r "nuget: FSharp.HashCollections"
open FSharp.HashCollections

#r "nuget: FSharpPlus"
open FSharpPlus
#r "nuget: Yog.FSharp"

open Yog.Model
open Yog.Builder
open Yog.IO
open Yog.Pathfinding.Dijkstra
open Yog.Render
open Yog.Render.Dot
open Yog.Render.Mermaid

#r "nuget: QuikGraph"
#r "nuget: QuikGraph.Serialization"
#r "nuget: QuikGraph.Graphviz"
#r "nuget: QuikGraph.Data"
#r "nuget: QuikGraph.MSAGL"
#r "nuget: QuikGraph.Petri"

open QuikGraph
open QuikGraph.Serialization
open QuikGraph.Graphviz
open QuikGraph.Data
open QuikGraph.MSAGL
open QuikGraph.Petri

#r "nuget: d2lang-cs"
#r "nuget: DiagramStudio.Core"

open DiagramStudio

#r "nuget: Rubjerg.Graphviz"
open Rubjerg.Graphviz

#r @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Project\MyProvider\src\MyProvider.Runtime\bin\Release\net8.0\Ergonomic_Extensions.dll"
#r @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Project\MyProvider\src\MyProvider.Runtime\bin\Release\net8.0\XParsec.dll"
#r @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Project\MyProvider\src\MyProvider.Runtime\bin\Release\net8.0\ParserCombinator.dll"
#r @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Project\MyProvider\src\MyProvider.Runtime\bin\Release\net8.0\NeatIntervals.dll"
#r @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Project\MyProvider\src\MyProvider.Runtime\bin\Release\net8.0\FRange.dll"
#r @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Project\MyProvider\src\MyProvider.Runtime\bin\Release\net8.0\UUIDNext.dll"
#r @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Project\MyProvider\src\MyProvider.Runtime\bin\Release\net8.0\Blake3.dll"
#r @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Project\MyProvider\src\MyProvider.Runtime\bin\Release\net8.0\dotNetRdf.dll"
#r @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Project\MyProvider\src\MyProvider.Runtime\bin\Release\net8.0\LightningDB.dll"
#r @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Project\MyProvider\src\MyProvider.Runtime\bin\Release\net8.0\Interval_Range.dll"
#r @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Project\MyProvider\src\MyProvider.Runtime\bin\Release\net8.0\MyProvider.Runtime.dll"
open Rdf_Provider

open LightningDB
open Blake3

open VDS.RDF
open VDS.RDF.Parsing
open VDS.RDF.Parsing.Tokens
open VDS.RDF.Storage
open VDS.RDF.Writing
open VDS.RDF.Query.Datasets
open VDS.RDF.Writing.Formatting

open DoxAletheia
open Interval_Range
open IntervalErgonomics
open StringExtensions
open ByteExtensions

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\MermaidErgonomics.fsx"
open MermaidErgonomics

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Namespace_Prefixes.fsx"
open Namespace_Prefixes
// TODO test cyjs https://www.github.com/fslaborg/Cyjs.NET
#r "nuget: Cyjs.NET"
// TODO test Plotly.NET
#r "nuget: Plotly.NET"
// TODO investigate flips solver https://fslab.org/flips/#/
// TODO investigate deedle https://fslab.org/Deedle/tutorial.html
// RDFa Core Initial Context
// https://www.w3.org/2011/rdfa-context/rdfa-1.1




#r "nuget: FSharp.Data"
open FSharp.Data



#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\PowershellErgonomics.fsx"
open PowershellErgonomics
open XParsec
open NeatIntervals
open UUIDNext
open Blake3

open System
open System.IO
open System.Xml
open System.Xml.Linq
open System.Xml.XPath



#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\XmlErgonomics.fsx"

open XmlErgonomics


#r "nuget: FSharp.Collections.ParallelSeq"
open FSharp.Collections.ParallelSeq


#r "nuget: FSharp.HashCollections"

open FSharp.HashCollections










type rdf =
    Rdf_Vocabulary<"http://www.w3.org/1999/02/22-rdf-syntax-ns#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\1999\02\22-rdf-syntax-ns\hash\rdf.ttl">

type xsd =
    Rdf_Vocabulary<"http://www.w3.org/2001/XMLSchema#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2001\XMLSchema\hash\xsd.ttl">
    
type rdfs =
    Rdf_Vocabulary<"http://www.w3.org/2000/01/rdf-schema#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2000\01\rdf-schema\hash\rdfs.ttl">
    
type owl =
    Rdf_Vocabulary<"http://www.w3.org/2002/07/owl#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2002\07\owl\hash\owl.ttl">


type owl_time =
    Rdf_Vocabulary<"http://www.w3.org/2006/time#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2006\time\hash\time.ttl">


type foaf =
    Rdf_Vocabulary<"http://xmlns.com/foaf/0.1/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\xmlns.com\foaf\0.1\slash\foaf.ttl">

type olo = Rdf_Vocabulary<"http://purl.org/ontology/olo/core#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\purl.org\ontology\olo\core\hash\olo.ttl"> 

(*



type as_ =
    Rdf_Vocabulary<"https://www.w3.org/ns/activitystreams#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\www.w3.org\ns\activitystreams\hash\as.ttl">

type csvw =
    Rdf_Vocabulary<"http://www.w3.org/ns/csvw#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\csvw\hash\csvw.ttl">

type dcat =
    Rdf_Vocabulary<"http://www.w3.org/ns/dcat#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\dcat\hash\dcat.ttl">

type dqv =
    Rdf_Vocabulary<"http://www.w3.org/ns/dqv#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\dqv\hash\dqv.ttl">

type duv =
    Rdf_Vocabulary<"http://www.w3.org/ns/duv#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\duv\hash\duv.ttl">

type grddl =
    Rdf_Vocabulary<"http://www.w3.org/2003/g/data-view#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2003\g\data-view\hash\grddl.ttl">

type jsonld =
    Rdf_Vocabulary<"http://www.w3.org/ns/json-ld#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\json-ld\hash\jsonld.ttl">

type ldp =
    Rdf_Vocabulary<"http://www.w3.org/ns/ldp#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\ldp\hash\ldp.ttl">

type ma_ont =
    Rdf_Vocabulary<"http://www.w3.org/ns/ma-ont#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\ma-ont\hash\ma-ont.ttl">

type oa =
    Rdf_Vocabulary<"http://www.w3.org/ns/oa#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\oa\hash\oa.ttl">

type odrl =
    Rdf_Vocabulary<"http://www.w3.org/ns/odrl/2/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\odrl\2\slash\odrl.ttl">

type org =
    Rdf_Vocabulary<"http://www.w3.org/ns/org#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\org\hash\org.ttl">


type prov =
    Rdf_Vocabulary<"http://www.w3.org/ns/prov#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\prov\hash\prov.ttl">

type qb =
    Rdf_Vocabulary<"http://purl.org/linked-data/cube#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\purl.org\linked-data\cube\hash\qb.ttl">


type rdfa =
    Rdf_Vocabulary<"http://www.w3.org/ns/rdfa#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\rdfa\hash\rdfa.ttl">

// TODO get rif 	http://www.w3.org/2007/rif#
// unfortunately involves implementing mapping https://www.w3.org/TR/rif-in-rdf/
type rr =
    Rdf_Vocabulary<"http://www.w3.org/ns/r2rml#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\r2rml\hash\rr.ttl">

type sd =
    Rdf_Vocabulary<"http://www.w3.org/ns/sparql-service-description#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\sparql-service-description\hash\sd.ttl">

type skos =
    Rdf_Vocabulary<"http://www.w3.org/2004/02/skos/core#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2004\02\skos\core\hash\skos.ttl">

type skosxl =
    Rdf_Vocabulary<"http://www.w3.org/2008/05/skos-xl#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2008\05\skos-xl\hash\skosxl.ttl">

type ssno =
    Rdf_Vocabulary<"http://www.w3.org/ns/ssn/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\ssn\slash\ssno.ttl">

type sosa =
    Rdf_Vocabulary<"http://www.w3.org/ns/sosa/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\sosa\slash\sosa.ttl">


type void_ =
    Rdf_Vocabulary<"http://rdfs.org/ns/void#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\rdfs.org\ns\void\hash\void.ttl">

type powder =
    Rdf_Vocabulary<"http://www.w3.org/2007/05/powder#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2007\05\powder\hash\powder.ttl">

type wdrs =
    Rdf_Vocabulary<"http://www.w3.org/2007/05/powder-s#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2007\05\powder-s\hash\wdrs.ttl">

type xhv =
    Rdf_Vocabulary<"http://www.w3.org/1999/xhtml/vocab#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\1999\xhtml\vocab\hash\xhv.ttl">
// TODO process full xhtml dtd https://www.w3.org/TR/xhtml1/xhtml1.zip



// Some vocabularies are currently in development at W3C and they may become W3C Recommendations or Notes, i.e., may become part of the table above. It is therefore advisable to consider their prefixes reserved for now. These are:

type earl =
    Rdf_Vocabulary<"http://www.w3.org/ns/earl#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\earl\hash\earl.ttl">




// Widely used Vocabulary prefixes based on the vocabulary usage on the Semantic Web
// https://www.w3.org/2010/02/rdfa/profile/data/








type cc =
    Rdf_Vocabulary<"http://creativecommons.org/ns#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\creativecommons.org\ns\hash\cc.ttl">

type ctag =
    Rdf_Vocabulary<"http://commontag.org/ns#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\commontag.org\ns\hash\ctag.ttl">

type dcterms =
    Rdf_Vocabulary<"http://purl.org/dc/terms/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\purl.org\dc\terms\slash\dcterms.ttl">

type dce =
    Rdf_Vocabulary<"http://purl.org/dc/elements/1.1/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\purl.org\dc\elements\1.1\slash\dce.ttl">


type gr =
    Rdf_Vocabulary<"http://purl.org/goodrelations/v1#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\purl.org\goodrelations\v1\hash\gr.ttl">
// TODO get ical 	http://www.w3.org/2002/12/cal/icaltzd#
// unfortunately requires dealing with malformed syntax, multiple rdf:IDs
// i'll try cal instead
type cal =
    Rdf_Vocabulary<"http://www.w3.org/2002/12/cal/ical#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2002\12\cal\ical\hash\cal.ttl">

type og =
    Rdf_Vocabulary<"http://ogp.me/ns#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\ogp.me\ns\hash\og.ttl">

type rev =
    Rdf_Vocabulary<"http://purl.org/stuff/rev#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\purl.org\stuff\rev\hash\rev.ttl">

type sioc =
    Rdf_Vocabulary<"http://rdfs.org/sioc/ns#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\rdfs.org\sioc\ns\hash\sioc.ttl">

type vcard =
    Rdf_Vocabulary<"http://www.w3.org/2006/vcard/ns#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2006\vcard\ns\hash\vcard.ttl">

type schemas =
    Rdf_Vocabulary<"https://schema.org/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\schema.org\slash\schemas.ttl">

// ------------------------------------------------------------------------------------------------------------------------------------------------------


type tsioc =
    Rdf_Vocabulary<"http://rdfs.org/sioc/types#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\rdfs.org\sioc\types\hash\tsioc.ttl">

type tzont =
    Rdf_Vocabulary<"http://www.w3.org/2006/timezone#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2006\timezone\hash\tzont.ttl">


type hydra =
    Rdf_Vocabulary<"http://www.w3.org/ns/hydra/core#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\hydra\core\hash\hydra.ttl">


type fresnel =
    Rdf_Vocabulary<"http://www.w3.org/2004/09/fresnel#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2004\09\fresnel\hash\fresnel.ttl">

type voaf =
    Rdf_Vocabulary<"http://purl.org/vocommons/voaf#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\purl.org\vocommons\voaf\hash\voaf.ttl">

type vann =
    Rdf_Vocabulary<"http://purl.org/vocab/vann/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\purl.org\vocab\vann\slash\vann.ttl">

type vaem =
    Rdf_Vocabulary<"http://www.linkedmodel.org/schema/vaem#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.linkedmodel.org\schema\vaem\hash\vaem.ttl">

type lemon =
    Rdf_Vocabulary<"http://lemon-model.net/lemon#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\lemon-model.net\lemon\hash\lemon.ttl">

type ontolex =
    Rdf_Vocabulary<"http://www.w3.org/ns/lemon/ontolex#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\lemon\ontolex\hash\ontolex.ttl">

type vartrans =
    Rdf_Vocabulary<"http://www.w3.org/ns/lemon/vartrans#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\lemon\vartrans\hash\vartrans.ttl">

type synsem =
    Rdf_Vocabulary<"http://www.w3.org/ns/lemon/synsem#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\lemon\synsem\hash\synsem.ttl">

type decomp =
    Rdf_Vocabulary<"http://www.w3.org/ns/lemon/decomp#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\lemon\decomp\hash\lexdcp.ttl">

type lime =
    Rdf_Vocabulary<"http://www.w3.org/ns/lemon/lime#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\lemon\lime\hash\lime.ttl">

type lexinfo =
    Rdf_Vocabulary<"http://www.lexinfo.net/ontology/2.0/lexinfo#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.lexinfo.net\ontology\2.0\lexinfo\hash\lexinfo.ttl">

type termlex =
    Rdf_Vocabulary<"https://termlex.oeg.fi.upm.es/termlex#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\termlex.oeg.fi.upm.es\termlex\hash\termlex.ttl">

type fno =
    Rdf_Vocabulary<"https://w3id.org/function/ontology#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\function\ontology\hash\fno.ttl">

type fnom =
    Rdf_Vocabulary<"https://w3id.org/function/vocabulary/mapping#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\function\vocabulary\mapping\hash\fnom.ttl">

type fnoi =
    Rdf_Vocabulary<"https://w3id.org/function/vocabulary/implementation#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\function\vocabulary\implementation\hash\fnoi.ttl">

type fnoc =
    Rdf_Vocabulary<"https://w3id.org/function/vocabulary/composition#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\function\vocabulary\composition\hash\fnoc.ttl">

type rml_io =
    Rdf_Vocabulary<"http://w3id.org/rml/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\w3id.org\rml\slash\rml-io.ttl">

type rml_cc =
    Rdf_Vocabulary<"http://w3id.org/rml/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\w3id.org\rml\slash\rml-cc.ttl">

type rml_fnml =
    Rdf_Vocabulary<"http://w3id.org/rml/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\w3id.org\rml\slash\rml-fnml.ttl">

type rml_star =
    Rdf_Vocabulary<"http://w3id.org/rml/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\w3id.org\rml\slash\rml-star.ttl">

type sh =
    Rdf_Vocabulary<"http://www.w3.org/ns/shacl#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\shacl\hash\sh.ttl">

type psh =
    Rdf_Vocabulary<"http://ns.inria.fr/probabilistic-shacl/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\ns.inria.fr\probabilistic-shacl\slash\psh.ttl">

type shsh =
    Rdf_Vocabulary<"http://www.w3.org/ns/shacl-shacl#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\shacl-shacl\hash\shsh.ttl">

type shex =
    Rdf_Vocabulary<"http://www.w3.org/ns/shex#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\shex\hash\shex.ttl">

type sp =
    Rdf_Vocabulary<"http://spinrdf.org/sp#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\spinrdf.org\sp\hash\sp.ttl">

type spin =
    Rdf_Vocabulary<"http://spinrdf.org/spin#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\spinrdf.org\spin\hash\spin.ttl">

type agrontology =
    Rdf_Vocabulary<"http://aims.fao.org/aos/agrontology#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\aims.fao.org\aos\agrontology\hash\agrontology.ttl">

type nmo =
    Rdf_Vocabulary<"http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.semanticdesktop.org\ontologies\2007\03\22\nmo\hash\nmo.ttl">

type nexif =
    Rdf_Vocabulary<"http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.semanticdesktop.org\ontologies\2007\05\10\nexif\hash\nexif.ttl">

type nid3 =
    Rdf_Vocabulary<"http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.semanticdesktop.org\ontologies\2007\05\10\nid3\hash\nid3.ttl">

type pimo =
    Rdf_Vocabulary<"http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.semanticdesktop.org\ontologies\2007\11\01\pimo\hash\pimo.ttl">

type tmo =
    Rdf_Vocabulary<"http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.semanticdesktop.org\ontologies\2008\05\20\tmo\hash\tmo.ttl">

type tnrl =
    Rdf_Vocabulary<"http://tracker.api.gnome.org/ontology/v3/nrl#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\tracker.api.gnome.org\ontology\v3\nrl\hash\tnrl.ttl">

type tnie =
    Rdf_Vocabulary<"http://tracker.api.gnome.org/ontology/v3/nie#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\tracker.api.gnome.org\ontology\v3\nie\hash\tnie.ttl">

type tnao =
    Rdf_Vocabulary<"http://tracker.api.gnome.org/ontology/v3/nao#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\tracker.api.gnome.org\ontology\v3\nao\hash\tnao.ttl">

type tnco =
    Rdf_Vocabulary<"http://tracker.api.gnome.org/ontology/v3/nco#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\tracker.api.gnome.org\ontology\v3\nco\hash\tnco.ttl">

type tnfo =
    Rdf_Vocabulary<"http://tracker.api.gnome.org/ontology/v3/nfo#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\tracker.api.gnome.org\ontology\v3\nfo\hash\tnfo.ttl">

type tnmm =
    Rdf_Vocabulary<"http://tracker.api.gnome.org/ontology/v3/nmm#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\tracker.api.gnome.org\ontology\v3\nmm\hash\tnmm.ttl">

type tmfo =
    Rdf_Vocabulary<"http://tracker.api.gnome.org/ontology/v3/mfo#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\tracker.api.gnome.org\ontology\v3\mfo\hash\tmfo.ttl">

type tracker =
    Rdf_Vocabulary<"http://tracker.api.gnome.org/ontology/v3/tracker#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\tracker.api.gnome.org\ontology\v3\tracker\hash\tracker.ttl">

type tslo =
    Rdf_Vocabulary<"http://tracker.api.gnome.org/ontology/v3/slo#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\tracker.api.gnome.org\ontology\v3\slo\hash\tslo.ttl">

type tosinfo =
    Rdf_Vocabulary<"http://tracker.api.gnome.org/ontology/v3/osinfo#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\tracker.api.gnome.org\ontology\v3\osinfo\hash\tosinfo.ttl">

type nie =
    Rdf_Vocabulary<"http://www.semanticdesktop.org/ontologies/2007/01/19/nie#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.semanticdesktop.org\ontologies\2007\01\19\nie\hash\nie.ttl">

type nco =
    Rdf_Vocabulary<"http://www.semanticdesktop.org/ontologies/2007/03/22/nco#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.semanticdesktop.org\ontologies\2007\03\22\nco\hash\nco.ttl">

type nfo =
    Rdf_Vocabulary<"http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.semanticdesktop.org\ontologies\2007\03\22\nfo\hash\nfo.ttl">

type ncal =
    Rdf_Vocabulary<"http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.semanticdesktop.org\ontologies\2007\04\02\ncal\hash\ncal.ttl">

type nao =
    Rdf_Vocabulary<"http://www.semanticdesktop.org/ontologies/2007/08/15/nao#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.semanticdesktop.org\ontologies\2007\08\15\nao\hash\nao.ttl">

type nrl =
    Rdf_Vocabulary<"http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.semanticdesktop.org\ontologies\2007\08\15\nrl\hash\nrl.ttl">

type linkml =
    Rdf_Vocabulary<"https://w3id.org/linkml/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-meta.owl.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-annotations.model.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-annotations.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-datasets.model.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-datasets.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-extensions.model.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-extensions.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-mappings.model.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-mappings.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-meta.model.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-meta.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-types.model.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-types.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-units.model.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-units.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-validation.model.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-validation.ttl">


type ermrk =
    Rdf_Vocabulary<"http://www.essepuntato.it/2008/12/earmark#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.essepuntato.it\2008\12\earmark\hash\ermrk-ghost.owl.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.essepuntato.it\2008\12\earmark\hash\ermrk-shell.owl.ttl">

type solid =
    Rdf_Vocabulary<"http://www.w3.org/ns/solid/terms#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\solid\terms\hash\solid.ttl">

type ws =
    Rdf_Vocabulary<"http://www.w3.org/ns/pim/space#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\pim\space\hash\ws.ttl">

type acl =
    Rdf_Vocabulary<"http://www.w3.org/ns/auth/acl#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\auth\acl\hash\acl.ttl">

type http =
    Rdf_Vocabulary<"http://www.w3.org/2011/http#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2011\http\hash\http.ttl">

type cnt =
    Rdf_Vocabulary<"http://www.w3.org/2011/content#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2011\content\hash\cnt.ttl">

type rel =
    Rdf_Vocabulary<"http://purl.org/vocab/relationship/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\purl.org\vocab\relationship\slash\rel.ttl">

type pext =
    Rdf_Vocabulary<"http://www.ontotext.com/proton/protonext#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.ontotext.com\proton\protonext\hash\pext.ttl">

type ptop =
    Rdf_Vocabulary<"http://www.ontotext.com/proton/protontop#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.ontotext.com\proton\protontop\hash\ptop.ttl">

type om =
    Rdf_Vocabulary<"https://open-metadata.org/ontology/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\open-metadata.org\ontology\slash\om.ttl">

type dbpedia_owl =
    Rdf_Vocabulary<"http://dbpedia.org/ontology/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\dbpedia.org\ontology\slash\dbpedia-owl.ttl">

type dbnary =
    Rdf_Vocabulary<"http://kaiko.getalp.org/dbnary#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\kaiko.getalp.org\dbnary\hash\dbnary.ttl">

type lib =
    Rdf_Vocabulary<"http://purl.org/library/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\purl.org\library\slash\lib.ttl">

type frapo =
    Rdf_Vocabulary<"http://purl.org/cerif/frapo/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\purl.org\cerif\frapo\slash\frapo.ttl">

type ocds =
    Rdf_Vocabulary<"http://purl.org/onto-ocds/ocds#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\purl.org\onto-ocds\ocds\hash\ocds.ttl">

type dg =
    Rdf_Vocabulary<"https://w3id.org/dingo#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\dingo\hash\dg.ttl">




module fibo =
    type PaymentsAndSchedules =
        Rdf_Vocabulary<"https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\spec.edmcouncil.org\fibo\ontology\master\2026Q1\FND\ProductsAndServices\PaymentsAndSchedules.ttl">

*)
let a = rdf.``type``

/// https://www.w3.org/XML/1998/namespace
type xml =
    static member _namespace_name = "http://www.w3.org/XML/1998/namespace#"

    static member _prefix local_name =
        Namespaced_IRI.parse xml._namespace_name local_name
        |> NamespacedName

    /// Designed for identifying the human language used in the scope of the element to which it's attached.
    static member lang = xml._prefix "lang"
    /// Designed to express whether or not the document's creator wishes white space to be considered as significant in the scope of the element to which it's attached.
    static member space = xml._prefix "space"
    /// The XML Base specification (Second edition) describes a facility, similar to that of HTML BASE, for defining base URIs for parts of XML documents. It defines a single attribute, xml:base, and describes in detail the procedure for its use in processing relative URI refeferences.
    static member base_ = xml._prefix "base"
    /// The xml:id specification defines a single attribute, xml:id, known to be of type ID independently of any DTD or schema.
    static member id = xml._prefix "id"




/// https://www.w3.org/TR/xmlschema-1/#Instance_Document_Constructions
type xsi =
    static member _namespace_name = "https://www.w3.org/2001/XMLSchema-instance#"

    static member _prefix local_name =
        Namespaced_IRI.parse xsi._namespace_name local_name
        |> NamespacedName

    /// https://www.w3.org/TR/xmlschema-1/#xsi_type
    static member type_ = xsi._prefix "type"
    /// https://www.w3.org/TR/xmlschema-1/#xsi_nil
    static member nil = xsi._prefix "nil"
    /// https://www.w3.org/TR/xmlschema-1/#xsi_schemaLocation
    static member schemaLocation = xsi._prefix "schemaLocation"

    /// https://www.w3.org/TR/xmlschema-1/#xsi_schemaLocation
    static member noNamespaceSchemaLocation = xsi._prefix "noNamespaceSchemaLocation"



type xdt =
    static member _namespace_name = "https://www.w3.org/2003/05/xpath-datatypes#"

    static member _prefix local_name =
        Namespaced_IRI.parse xdt._namespace_name local_name
        |> NamespacedName

    /// The datatype xdt:untyped denotes the dynamic type of an element node that has not been validated, or has been validated in skip mode. No predefined types are derived from xdt:untyped.
    static member untyped = xdt._prefix "untyped"
    /// The datatype xdt:untypedAtomic denotes untyped atomic data, such as text that has not been assigned a more specific type. An attribute that has been validated in skip mode is represented in the Data Model by an attribute node with the type xdt:untypedAtomic. No predefined types are derived from xdt:untypedAtomic.
    static member untypedAtomic = xdt._prefix "untypedAtomic"
    /// The datatype xdt:anyAtomicType is an atomic type that includes all atomic values (and no values that are not atomic). Its base type is xs:anySimpleType from which all simple types, including atomic, list, and union types are derived. All primitive atomic types, such as xs:integer and xs:string, have xdt:anyAtomicType as their base type.
    static member anyAtomicType = xdt._prefix "anyAtomicType"
    /// The type xdt:dayTimeDuration is derived from xs:duration by restricting its lexical representation to contain only the days, hours, minutes and seconds components. The value space of xdt:dayTimeDuration is the set of fractional second values. The components of xdt:dayTimeDuration correspond to the day, hour, minute and second components defined in Section 5.5.3.2 of ISO 8601, , respectively. xdt:dayTimeDuration is derived from xs:duration as follows:
    static member dayTimeDuration = xdt._prefix "dayTimeDuration"

    /// The type xdt:yearMonthDuration is derived from xs:duration by restricting its lexical representation to contain only the year and month components. The value space of xdt:yearMonthDuration is the set of xs:integer month values. The year and month components of xdt:yearMonthDuration correspond to the Gregorian year and month components defined in section 5.5.3.2 of ISO 8601, respectively.
    static member yearMonthDuration = xdt._prefix "yearMonthDuration"












































































module Rdf_Literal =
    open System
    open System.Globalization
    open System.Xml

    let simple lexical_form = SimpleLiteral lexical_form

    let en lexical_form =
        LanguageString(lexical_form, Language_Tag.en)

    let en_us lexical_form =
        RegionString(lexical_form, Language_Tag.en, Region_Subtag.US)

    let datatyped lexical_form datatype =
        DatatypedLiteral(lexical_form, datatype)

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
            | :? Guid as value -> value.ToString(), xsd.ID
            | null -> "true", xsi.nil
            | value when value.GetType() = typeof<Object> -> invariant_string, xdt.anyAtomicType
            | value -> invariant_string, xsd.string

        datatyped value_string datatype_iri

    let true_ = autotyped true
    let false_ = autotyped false

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




































// TODO consider FSharp.HashCollections


type Formula =
    {

      subjects: Rdf_Subject array
      predicates: Rdf_Predicate array
      objects: Rdf_Object array
      predicateObjectLists: PredicateObjectList array
      triples: HashSet<Rdf_Triple>

     }

    static member from_subject subject_term =

        { subjects = [| subject_term |]
          predicates = [||]
          objects = [||]
          predicateObjectLists = [||]
          triples = HashSet.empty

        }

    static member from_subjects subjects =

        { subjects = subjects |> List.toArray
          predicates = [||]
          objects = [||]
          predicateObjectLists = [||]
          triples = HashSet.empty

        }

    static member from_predicate predicate_term =

        { subjects = [||]
          predicates = [| predicate_term |]
          objects = [||]
          predicateObjectLists = [||]
          triples = HashSet.empty

        }

    static member from_predicates predicates =

        { subjects = [||]
          predicates = predicates
          objects = [||]
          predicateObjectLists = [||]
          triples = HashSet.empty

        }

    static member from_object object_term =

        { subjects = [||]
          predicates = [||]
          objects = [| object_term |]
          predicateObjectLists = [||]
          triples = HashSet.empty

        }

    static member from_objects objects =

        { subjects = [||]
          predicates = [||]
          objects = objects
          predicateObjectLists = [||]
          triples = HashSet.empty

        }


    member this.materialize_triples =
        let triples_from_terms =
            Triples.from_terms this.subjects this.predicates this.objects

        let triples_from_subjects_predicateObjectLists =
            Triples.from_subjects_predicateObjectLists this.subjects this.predicateObjectLists

        { subjects = [||]
          predicates = [||]
          objects = [||]
          predicateObjectLists = [||]
          triples =
            HashSet.union
                this.triples
                (triples_from_terms
                 + triples_from_subjects_predicateObjectLists)


        }

    member this.add_subjects subject_terms =
        { this with subjects = this.subjects |> Array.append subject_terms }

    member this.add_subject subject_term = this.add_subjects [| subject_term |]


    member this.add_predicates predicate_terms =

        { this with predicates = this.predicates |> Array.append predicate_terms }

    member this.add_predicateObjectLists predicateObjectLists =

        { this with
            predicateObjectLists =
                this.predicateObjectLists
                |> Array.append predicateObjectLists }

    member this.add_predicate predicate_term =
        this.add_predicates [| predicate_term |]

    member this.add_objects object_terms =
        { this with objects = this.objects |> Array.append object_terms }

    member this.add_object object_term = this.add_objects [| object_term |]

    member this.add_literal literal =
        Rdf_Literal.autotyped literal
        |> Rdf_Object.LiteralObject
        |> this.add_object

    member this.add_literals literals =
        literals
        |> List.toArray
        |> Array.Parallel.map (fun literal ->
            literal
            |> Rdf_Literal.autotyped
            |> Rdf_Object.LiteralObject)
        |> this.add_objects



let global_prefix_map = global_prefix_declarations |> Map.ofArray


let prefixed_name (delimiter: string) (iri: Namespaced_IRI) =
    let namespace_name = iri.namespace_iriref.as_rendered_string
    let prefix_label = global_prefix_map[namespace_name]
    sprintf "%s%s%s" prefix_label delimiter iri.local_name.as_raw_string


let curie (iri: Namespaced_IRI) = iri |> prefixed_name ":"




let map_prefixes (graph: IGraph) =
    global_prefix_declarations
    |> Array.Parallel.iter (fun (namespace_name, prefix_label) ->

        let uri_nodes =
            graph.AllNodes
            |> Seq.toArray
            |> Array.Parallel.choose (fun inode ->
                if inode.NodeType = NodeType.Uri then
                    Some(inode :?> UriNode)
                else
                    None

            )

        let term_is_namespaced =
            uri_nodes
            |> Array.Parallel.exists (fun uri_node ->

                uri_node.Uri.OriginalString.StartsWith(namespace_name)

            )

        if term_is_namespaced then
            graph.NamespaceMap.AddNamespace(prefix_label, new Uri(namespace_name)))


type Rdf_Graph = { triples: HashSet<Rdf_Triple> }


type Textual_Syntax =
    {

      syntax_name: string
      file_extension: string

     }
    member this.file_path parent_directory stem =
        Directory.CreateDirectory(parent_directory)
        |> ignore

        Path.Combine(parent_directory, sprintf "%s.%s" stem this.file_extension)


module NTriples =
    let syntax =
        { syntax_name = "NTriples"
          file_extension = "nt"

        }

    let mime_type = Mime_Path.application.n.triples.media_type

    let parser = NTriplesParser()

    let parse (text: string) (graph: IGraph) =
        try
            use reader = new StringReader(text)
            parser.Load(graph, reader)
        with 
        | err -> 
            clip text
            failwithf "The text in the clipboard failed to parse with error %s" err.Message

    let iriref_nt (iriref: IRIREF) = "<" + iriref.as_raw_string + ">"



    let blank_node_nt (blank_node: Blank_Node) =
        match blank_node with
        | BlankNodeIdentifier identifier -> sprintf "_:%s" identifier
        // TODO handle nt representation of blanknodepropertylist
        | BlankNodePropertyList (identifier, predicateObjectList) -> sprintf "_:%s" identifier

    let subject_nt (rdf_subject: Rdf_Subject) =
        match rdf_subject with
        | IRIREFSubject iriref -> iriref_nt iriref
        | BlankNodeSubject blank_node -> blank_node_nt blank_node

    let predicate_nt (rdf_predicate: Rdf_Predicate) =
        match rdf_predicate with
        | IRIREFPredicate iriref -> iriref_nt iriref

    let rdf_literal_nt (rdf_literal: Rdf_Literal) =

        match rdf_literal with
        | SimpleLiteral lexical_form -> sprintf "\"%s\"" lexical_form
        | LongLiteral lexical_form -> sprintf "\"\"\"%s\"\"\"" lexical_form
        | DatatypedLiteral (lexical_form, datatype) -> sprintf "\"%s\"^^%s" lexical_form (iriref_nt datatype)
        | LanguageString (lexical_form, language) -> sprintf "\"%s\"@%s" lexical_form (language.ToString())
        | RegionString (lexical_form, language, region) ->
            sprintf "\"%s\"@%s-%s" lexical_form (language.ToString()) (region.ToString())
        | DirectedLanguageString (lexical_form, language, base_direction) ->
            sprintf "\"%s\"@%s--%s" lexical_form (language.ToString()) base_direction.lexical_form
        | DirectedRegionString (lexical_form, language, region, base_direction) ->
            sprintf
                "\"%s\"@%s-%s--%s"
                lexical_form
                (language.ToString())
                (region.ToString())
                base_direction.lexical_form

    let rec object_nt (rdf_object: Rdf_Object) =
        match rdf_object with
        | IRIREFObject iriref -> iriref_nt iriref
        | BlankNodeObject blank_node -> blank_node_nt blank_node
        | LiteralObject rdf_literal -> rdf_literal_nt rdf_literal
        | TripleTermObject triple_term ->
            sprintf
                "<<(%s %s %s)>>"
                (subject_nt triple_term.ttSubject)
                (predicate_nt triple_term.ttPredicate)
                (object_nt triple_term.ttObject)

    let triple_nt (rdf_triple: Rdf_Triple) =
        sprintf
            "%s %s %s ."
            (subject_nt rdf_triple.curSubject)
            (predicate_nt rdf_triple.curPredicate)
            (object_nt rdf_triple.curObject)

    let triple_term_nt (triple_term: Triple_Term) =
        match triple_term with
        | TripleTerm triple ->
            sprintf
                "<<(%s %s %s)>>"
                (subject_nt triple_term.ttSubject)
                (predicate_nt triple_term.ttPredicate)
                (object_nt triple_term.ttObject)

    let graph_lines (rdf_graph: Rdf_Graph) =
        rdf_graph.triples
        |> HashSet.toArray
        |> Array.Parallel.map (fun triple -> triple_nt triple)

    let graph_text (rdf_graph: Rdf_Graph) =
        graph_lines rdf_graph |> String.concat "\n"



module NQuads =
    let syntax =
        { syntax_name = "N-Quads"
          file_extension = "nq" }

    let mime_type = Mime_Path.application.n.quads.media_type

module TriG =
    let syntax =
        { syntax_name = "TriG"
          file_extension = "trig"

        }

    let mime_type = Mime_Path.application.trig.media_type

module D2 =

    let syntax =
        { syntax_name = "D2"
          file_extension = "d2" }

    let prefix_delimiter = "\\:"

    let vertex_d2 (vertex: Vertex) =
        vertex.as_rendered_string prefix_delimiter global_prefix_map

    let edge_d2 (edge: Edge) =
        edge.as_rendered_string prefix_delimiter global_prefix_map

    let graph_lines (rdf_graph: Rdf_Graph) =
        rdf_graph.triples
        |> HashSet.toArray
        |> Array.Parallel.map (fun triple ->
            SubjectVertex triple.curSubject, ObjectVertex triple.curObject, PredicateEdge triple.curPredicate)
        |> Array.Parallel.map (fun (in_vertex, out_vertex, out_edge) ->
            sprintf "%s -> %s : %s" (vertex_d2 in_vertex) (vertex_d2 out_vertex) (edge_d2 out_edge))

    let graph_text (rdf_graph: Rdf_Graph) =
        rdf_graph |> graph_lines |> String.concat "\n"

    let write_draft (parent_directory: string) (stem: string) (draft: Formula) =
        let file_text = { triples = draft.triples } |> graph_text

        let file_path = syntax.file_path parent_directory stem
        File.WriteAllText(file_path, file_text)



type YoGraph = Graph<Vertex, Edge>
type Quik_Edge = TaggedEdge<Vertex, Edge>
type Quik_Graph = BidirectionalGraph<Vertex, Quik_Edge>


module Rdf_Graph =
    let to_igraph (rdf_graph: Rdf_Graph) =
        let igraph = new ThreadSafeGraph()
        NTriples.parse (NTriples.graph_text rdf_graph) igraph
        igraph


    let to_yograph (rdf_graph: Rdf_Graph) =
        rdf_graph.triples
        |> HashSet.toArray
        |> Array.Parallel.map (fun triple ->
            SubjectVertex triple.curSubject, ObjectVertex triple.curObject, PredicateEdge triple.curPredicate)
        |> Array.toList
        |> Labeled.fromList Directed
        |> Labeled.toGraph

    let to_quik_graph (rdf_graph: Rdf_Graph) =
        let quik_graph = new Quik_Graph()

        rdf_graph.triples
        |> HashSet.toArray
        |> Array.map (fun triple ->
            quik_graph.AddVerticesAndEdge(
                new Quik_Edge(
                    SubjectVertex triple.curSubject,
                    ObjectVertex triple.curObject,
                    PredicateEdge triple.curPredicate
                )
            ))
        |> ignore

        quik_graph



module Turtle =
    let syntax =
        { syntax_name = "Turtle"
          file_extension = "ttl" }

    let mime_type = Mime_Path.text.turtle.media_type

    let private isValidPrefixedNameRelaxed (s: string) =
        if s.Contains(".") then
            true
        else
            TurtleSpecsHelper.IsValidQName(s)

    let private percentEncodeCharUtf8 (ch: char) =
        Encoding.UTF8.GetBytes([| ch |])
        |> Seq.map (fun b -> "%" + b.ToString("X2"))
        |> String.concat ""

    let private isForbiddenInTurtleIriRef (ch: char) =
        let code = int ch

        code <= 0x20
        || code = 0x7F
        || ch = '<'
        || ch = '>'
        || ch = '"'
        || ch = '{'
        || ch = '}'
        || ch = '|'
        || ch = '^'
        || ch = '`'
        || ch = '\\'

    let private escapeIriRefByPercentEncoding (iri: string) =
        let sb = StringBuilder(iri.Length)

        for ch in iri do
            if isForbiddenInTurtleIriRef ch then
                sb.Append(percentEncodeCharUtf8 ch) |> ignore
            else
                sb.Append(ch) |> ignore

        sb.ToString()

    let private formatIriRefFromOriginalString (uri: Uri) =
        "<"
        + escapeIriRefByPercentEncoding uri.OriginalString
        + ">"

    let private isAsciiSafeLocal (local: string) =
        if String.IsNullOrEmpty(local) then
            false
        else
            let isStartOk ch = Char.IsLetterOrDigit(ch) || ch = '_'

            let isRestOk ch =
                Char.IsLetterOrDigit(ch)
                || ch = '_'
                || ch = '-'
                || ch = '.'

            isStartOk local.[0]
            && local |> Seq.forall isRestOk

    let private isValidLocalName (local: string) =
        if String.IsNullOrEmpty(local) then
            false
        elif local.Contains("/") then
            false
        else
            TurtleSpecsHelper.IsValidQName("p:" + local)
            || isAsciiSafeLocal local

    let private tryReduceToPrefixOnly (nsMap: INamespaceMapper) (uriOriginal: string) =
        nsMap.Prefixes
        |> Seq.tryPick (fun (p: string) ->
            let nsUri = nsMap.GetNamespaceUri(p)

            if isNull (box nsUri) then
                None
            else
                let ns = nsUri.OriginalString

                if uriOriginal.Equals(ns, StringComparison.Ordinal) then
                    Some(p + ":")
                else
                    None)

    let private tryReduceToPrefixedNameLongest (nsMap: INamespaceMapper) (uriOriginal: string) : string option =
        let candidates: (string * string) list =
            nsMap.Prefixes
            |> Seq.choose (fun (p: string) ->
                let nsUri = nsMap.GetNamespaceUri(p)

                if isNull (box nsUri) then
                    None
                else
                    Some(p, nsUri.OriginalString))
            |> Seq.filter (fun (_pfx: string, ns: string) -> uriOriginal.StartsWith(ns, StringComparison.Ordinal))
            |> Seq.sortByDescending (fun (_pfx: string, ns: string) -> ns.Length)
            |> Seq.toList

        let rec pick (xs: (string * string) list) =
            match xs with
            | [] -> None
            | (pfx, ns) :: rest ->
                let local = uriOriginal.Substring(ns.Length)

                if isValidLocalName local then
                    Some(pfx + ":" + local)
                else
                    pick rest

        pick candidates

    let private tryReduceToPrefixedName (nsMap: INamespaceMapper) (uriOriginal: string) =
        match tryReduceToPrefixOnly nsMap uriOriginal with
        | Some p -> Some p
        | None -> tryReduceToPrefixedNameLongest nsMap uriOriginal

    type UnicodePrefixedNameTurtleW3CFormatter(g: IGraph) =
        inherit TurtleW3CFormatter(g)

        override _.IsValidQName(value: string) = isValidPrefixedNameRelaxed value

        override _.FormatUriNode(u: IUriNode, segment: Nullable<TripleSegment>) =
            let uri = u.Uri

            if
                segment.HasValue
                && segment.Value = TripleSegment.Predicate
                && uri.AbsoluteUri.Equals(RdfSpecsHelper.RdfType, StringComparison.Ordinal)
            then
                "a"
            else
                match tryReduceToPrefixedName g.NamespaceMap uri.OriginalString with
                | Some prefixedName -> prefixedName
                | None -> formatIriRefFromOriginalString uri

    let private writeAllPrefixes (tw: TextWriter) (g: IGraph) =
        g.NamespaceMap.Prefixes
        |> Seq.sort
        |> Seq.iter (fun p ->
            let ns = g.NamespaceMap.GetNamespaceUri(p)
            tw.Write("@prefix ")
            tw.Write(p)
            tw.Write(": <")
            tw.Write(ns.OriginalString)
            tw.WriteLine("> ."))

        tw.WriteLine()

    let write_igraph (parent_directory: string) (stem: string) (graph: VDS.RDF.IGraph) =
        map_prefixes graph

        use file_stream =
            new FileStream(syntax.file_path parent_directory stem, FileMode.Create, FileAccess.Write, FileShare.Read)

        use stream_writer = new StreamWriter(file_stream, new UTF8Encoding(false))

        writeAllPrefixes stream_writer graph

        let formatter = UnicodePrefixedNameTurtleW3CFormatter(graph) :> ITripleFormatter

        for triple in graph.Triples do
            stream_writer.WriteLine(formatter.Format(triple))

        stream_writer.Flush()

    (*

    let writer =
        let writer = new CompressingTurtleWriter(TurtleSyntax.W3C)
        writer.HighSpeedModePermitted <- false
        writer.PrettyPrintMode <- true
        writer

    let write_igraph (parent_directory: string) (stem: string) (graph: VDS.RDF.IGraph) =
        map_prefixes graph
        writer.Save(graph, syntax.file_path parent_directory stem)

*)
    let write_draft (parent_directory: string) (stem: string) (draft: Formula) =
        let file_path = syntax.file_path parent_directory stem

        { triples = draft.triples }
        |> Rdf_Graph.to_igraph
        |> write_igraph parent_directory stem


module ddot =
    module it =
        let syntax =
            { syntax_name = "ddot.it"
              file_extension = "ddot" }

        let triple_ddot (rdf_triple: Rdf_Triple) =
            sprintf
                "%s..%s..%s"
                (NTriples.subject_nt rdf_triple.curSubject)
                (NTriples.predicate_nt rdf_triple.curPredicate)
                (NTriples.object_nt rdf_triple.curObject)

        let graph_lines (rdf_graph: Rdf_Graph) =
            rdf_graph.triples
            |> HashSet.toArray
            |> Array.Parallel.map (fun triple -> triple_ddot triple)

        let graph_text (rdf_graph: Rdf_Graph) =
            rdf_graph |> graph_lines |> String.concat "\n"

        let write_draft (parent_directory: string) (stem: string) (draft: Formula) =
            let file_text = { triples = draft.triples } |> graph_text

            let file_path = syntax.file_path parent_directory stem
            File.WriteAllText(file_path, file_text)



module Dot =

    let syntax =
        { syntax_name = "Graphviz"
          file_extension = "dot" }

    let prefix_delimiter = ":"

    let vertex_dot (vertex: Vertex) =
        vertex.as_rendered_string prefix_delimiter global_prefix_map

    let edge_dot (edge: Edge) =
        edge.as_rendered_string prefix_delimiter global_prefix_map

    let yog_options: Dot.Options<Vertex, Edge> =
        {

          NodeLabel = (fun vertex_id vertex -> vertex_dot vertex)
          EdgeLabel = (fun edge -> edge_dot edge)
          HighlightedSourceNodes = Set.empty
          HighlightedSinkNodes = Set.empty
          HighlightedNodes = Set.empty
          HighlightedEdges = Set.empty
          NodeShape = "ellipse"
          HighlightColor = "red"

        }


    let write_yograph (parent_directory: string) (stem: string) (yograph: YoGraph) =
        let file_path = syntax.file_path parent_directory stem
        Dot.writeFile file_path yog_options yograph

    let write_quik_graph (parent_directory: string) (stem: string) (quik_graph: Quik_Graph) =
        let dot_graph = new GraphvizAlgorithm<Vertex, Quik_Edge>(quik_graph)

        dot_graph.FormatVertex.Add (fun args ->

            args.VertexFormat.Label <- (vertex_dot args.Vertex)

        )

        dot_graph.FormatEdge.Add (fun args ->

            args.EdgeFormat.Label.Value <- (edge_dot args.Edge.Tag)

        )



        dot_graph.Generate(new FileDotEngine(), (syntax.file_path parent_directory stem))
        |> ignore

    let write_draft_from_yograph (parent_directory: string) (stem: string) (draft: Formula) =
        { triples = draft.triples }
        |> Rdf_Graph.to_yograph
        |> write_yograph parent_directory $"{stem}.yog"

    let write_draft_from_quik_graph (parent_directory: string) (stem: string) (draft: Formula) =
        { triples = draft.triples }
        |> Rdf_Graph.to_quik_graph
        |> write_quik_graph parent_directory $"{stem}.quik"

    let write_draft (parent_directory: string) (stem: string) (draft: Formula) =
        draft
        |> write_draft_from_yograph parent_directory stem

        draft
        |> write_draft_from_quik_graph parent_directory stem

module Mermaid =

    let syntax =
        { syntax_name = "Mermaid"
          file_extension = "mmd" }

    let prefix_delimiter = ":"

    let vertex_mmd (vertex: Vertex) =
        vertex.as_rendered_string prefix_delimiter global_prefix_map

    let edge_mmd (edge: Edge) =
        edge.as_rendered_string prefix_delimiter global_prefix_map

    let options: Mermaid.Options<Vertex, Edge> =
        {

          Direction = "LR"
          NodeLabel = (fun vertex_id vertex -> vertex_mmd vertex)
          EdgeLabel = (fun edge -> edge_mmd edge)
          HighlightedEdges = Set.empty
          HighlightedNodes = Set.empty
          HighlightedSinkNodes = Set.empty
          HighlightedSourceNodes = Set.empty

        }

    let write_yograph (parent_directory: string) (stem: string) yograph =
        let file_path = syntax.file_path parent_directory stem
        Mermaid.writeFile file_path options yograph

    let write_draft (parent_directory: string) (stem: string) (draft: Formula) =
        { triples = draft.triples }
        |> Rdf_Graph.to_yograph
        |> write_yograph parent_directory stem




module Formula =
    let materialize_triples (draft: Formula) = draft.materialize_triples
    let emit_triples (draft: Formula) = draft.triples
    let to_rdf_graph (draft: Formula) = { triples = draft.triples }

    let to_igraph (draft: Formula) =
        draft |> to_rdf_graph |> Rdf_Graph.to_igraph




















// lexical adders

let (^@) lexical_form language_tag =
    LanguageString(lexical_form, language_tag)

let (^@@) lexical_form (language_tag, region_subtag) =
    RegionString(lexical_form, language_tag, region_subtag)

let (^^) lexical_form datatype =
    DatatypedLiteral(lexical_form, datatype)
// TODO consider something for long string literals


// unary starters
let inline (!>) (subject_term: ^SubjectType when ^SubjectType: (member as_subject: Rdf_Subject)) : Formula =
    Formula.from_subject subject_term.as_subject

let inline (!|)
    (subject_terms: ^SubjectType list when ^SubjectType: (member as_subject: Rdf_Subject))
    : Formula =
    subject_terms
    |> List.map (fun subject_term -> subject_term.as_subject)
    |> Formula.from_subjects

let inline (!/)
    (predicate_term: ^PredicateType when ^PredicateType: (member as_predicate: Rdf_Predicate))
    : Formula =
    Formula.from_predicate predicate_term.as_predicate

let inline (!<) (object_term: ^ObjectType when ^ObjectType: (member as_object: Rdf_Object)) : Formula =
    Formula.from_object object_term.as_object

let inline (!<=) value_object =
    Rdf_Literal.autotyped value_object
    |> Rdf_Object.LiteralObject
    |> Formula.from_object


// subject adders
let inline (-!>)
    (draft: Formula)
    (subject_term: ^SubjectType when ^SubjectType: (member as_subject: Rdf_Subject))
    =
    draft.add_subject subject_term.as_subject
let inline (-!|)
    (draft: Formula)
    (subject_terms: ^SubjectType list when ^SubjectType: (member as_subject: Rdf_Subject))
    =
    subject_terms
    |> List.map (fun subject_term -> subject_term.as_subject)
    |> List.toArray
    |> draft.add_subjects


// predicate adders
let inline (---)
    (draft: Formula)
    (predicate_term: ^PredicateType when ^PredicateType: (member as_predicate: Rdf_Predicate))
    =
    draft.add_predicate predicate_term.as_predicate

let inline (--|)
    (draft: Formula)
    (predicate_terms: ^PredicateType list when ^PredicateType: (member as_predicate: Rdf_Predicate))
    =
    predicate_terms
    |> List.toArray
    |> Array.Parallel.map (fun predicate_term -> predicate_term.as_predicate)
    |> draft.add_predicates

// predicateObjectList adders
let inline (-~|) (draft: Formula) (predicateObjectLists: PredicateObjectList list) =
    predicateObjectLists
    |> List.toArray
    |> draft.add_predicateObjectLists

let inline (-~|>) (draft: Formula) (predicateObjectLists: PredicateObjectList list) =
    predicateObjectLists
    |> List.toArray
    |> draft.add_predicateObjectLists
    |> Formula.materialize_triples


let inline (->-)
    (predicate: ^PredicateType when ^PredicateType: (member as_predicate: Rdf_Predicate))
    (object: ^ObjectType when ^ObjectType: (member as_object: Rdf_Object))
    =
    PredicateObjectList.from_terms predicate.as_predicate [| object.as_object |]

let inline (->|)
    (predicate: ^PredicateType when ^PredicateType: (member as_predicate: Rdf_Predicate))
    (object_terms: ^ObjectType list when ^ObjectType: (member as_object: Rdf_Object))
    =
    let objects =
        object_terms
        |> List.toArray
        |> Array.Parallel.map (fun object_term -> object_term.as_object)

    PredicateObjectList.from_terms predicate.as_predicate objects

let inline (->=) (predicate: ^PredicateType when ^PredicateType: (member as_predicate: Rdf_Predicate)) value_object =
    PredicateObjectList.from_terms
        predicate.as_predicate
        [| Rdf_Literal.autotyped value_object
           |> Rdf_Object.LiteralObject |]

let inline (->=|) (predicate: ^PredicateType when ^PredicateType: (member as_predicate: Rdf_Predicate)) value_objects =
    let objects =
        value_objects
        |> List.map (fun value_object ->
            Rdf_Literal.autotyped value_object
            |> Rdf_Object.LiteralObject)
        |> List.toArray

    PredicateObjectList.from_terms predicate.as_predicate objects


let inline (-->) (draft: Formula) (object_term: ^ObjectType when ^ObjectType: (member as_object: Rdf_Object)) =
    draft.add_object object_term.as_object
    |> Formula.materialize_triples

let inline (-<-)
    (draft: Formula)
    (subject_term: ^SubjectType when ^SubjectType: (member as_subject: Rdf_Subject))
    =
    draft.add_subject subject_term.as_subject
    |> Formula.materialize_triples

let inline (-<-/)
    (draft: Formula)
    (subject_term: ^SubjectType when ^SubjectType: (member as_subject: Rdf_Subject))
    =
    let materialized_draft =
        draft.add_subject subject_term.as_subject
        |> Formula.materialize_triples

    { materialized_draft with

        subjects = [| subject_term.as_subject |]

     }

let inline (-->/) (draft: Formula) (object_term: ^ObjectType when ^ObjectType: (member as_object: Rdf_Object)) =
    let materialized_draft =
        draft.add_object object_term.as_object
        |> Formula.materialize_triples

    { materialized_draft with

        subjects =
            match object_term.as_object.maybe_subject with
            | Some subject -> [| subject |]
            | None -> [||]

     }

let inline (-->=) (draft: Formula) literal =
    draft.add_literal literal
    |> Formula.materialize_triples

let inline (-->^) (draft: Formula) (lexical_form: string) (datatype: IRIREF) =
    draft.add_literal (lexical_form ^^ datatype)
    |> Formula.materialize_triples

let inline (-->@) (draft: Formula) (lexical_form: string) (language_tag: Language_Tag) =
    lexical_form ^@ language_tag
    |> draft.add_literal
    |> Formula.materialize_triples

let inline (-->@@)
    (draft: Formula)
    (lexical_form: string)
    (language_tag: Language_Tag)
    (region_subtag: Region_Subtag)
    =
    lexical_form ^@@ (language_tag, region_subtag)
    |> draft.add_literal
    |> Formula.materialize_triples


let inline (-->=|) (draft: Formula) literals =
    draft.add_literals literals
    |> Formula.materialize_triples

let inline (-->^|) (draft: Formula) (lexical_forms: string list) (datatype: IRIREF) =
    lexical_forms
    |> List.map (fun lexical_form -> lexical_form ^^ datatype)
    |> draft.add_literals
    |> Formula.materialize_triples

let inline (-->@|) (draft: Formula) (lexical_forms: string list) (language_tag: Language_Tag) =
    lexical_forms
    |> List.map (fun lexical_form -> lexical_form ^@ language_tag)
    |> draft.add_literals
    |> Formula.materialize_triples

let inline (-->@@|)
    (draft: Formula)
    (lexical_forms: string list)
    (language_tag: Language_Tag)
    (region_subtag: Region_Subtag)
    =
    lexical_forms
    |> List.map (fun lexical_form -> lexical_form ^@@ (language_tag, region_subtag))
    |> draft.add_literals
    |> Formula.materialize_triples




/// predicate object+
let inline (-->|)
    (draft: Formula)
    (object_terms: ^ObjectType list when ^ObjectType: (member as_object: Rdf_Object))
    =
    object_terms
    |> List.toArray
    |> Array.Parallel.map (fun object_term -> object_term.as_object)
    |> draft.add_objects
    |> Formula.materialize_triples






(*







type Named_Graph =
    { name: Rdf_Subject option
      graph: Rdf_Graph }

type Rdf_Dataset =
    {

      default_graph: Rdf_Graph
      named_graphs: Named_Graph seq

     }





type Property_Graph =
    {

      graph_label: string

      node_ids: Vertex_ID array

     }




*)







(*
fsi.ShowDeclarationValues <- true
let changeable = cval 10
(*
let dependent = changeable |> AVal.map (fun cvalue -> 2 * cvalue)

dependent |> AVal.force // => 20
transact (fun () -> changeable.Value <- 1)
dependent |> AVal.force // => 2
*)

let input = clist [ 1; 2; 3 ]

let dependent =
    input
    |> AList.map (fun v -> v * v)
    |> AList.fold (+) 0

1 + 4 + 9 + 16
dependent |> AVal.force // => 14
transact (fun () -> input.Append 4)
dependent |> AVal.force // => 30


let a = cval "some dependency"
let b = cval "other input"
let param = cval 0.5

let result =
    param
    |> AVal.bind (fun p ->
        if p <= 0.33 then a :> aval<_>
        elif p <= 0.66 then b :> aval<_>
        else AVal.constant "invalid")

result |> AVal.force

*)


let write_draft parent_directory stem draft =
    Turtle.write_draft parent_directory stem draft
    Dot.write_draft parent_directory stem draft
    ddot.it.write_draft parent_directory stem draft
    Mermaid.write_draft parent_directory stem draft
    D2.write_draft parent_directory stem draft




















































type dbug =
    static member _namespace_name = "https://eristocrates.dev/ontology/dbug/"

    static member _prefix local_name =
        Namespaced_IRI.parse dbug._namespace_name local_name
        |> NamespacedName

    static member this_ = dbug._prefix "this"
    static member example = dbug._prefix "example"
    static member Bob = dbug._prefix "Bob"
    static member The_Mona_Lisa = dbug._prefix "The_Mona_Lisa"
    static member Alice = dbug._prefix "Alice"

    static member Charlie = dbug._prefix "Charlie"
    static member Sasha = dbug._prefix "Sasha"
    static member Leonardo_da_Vinci = dbug._prefix "Leonardo_da_Vinci"
    static member La_Joconde_a_Washington = dbug._prefix "La_Joconde_à_Washington"
    static member archipelago = dbug._prefix "archipelago"


type commonplace =
    static member _namespace_name = "https://eristocrates.dev/ontology/commonplace/"

    static member _prefix local_name =
        Namespaced_IRI.parse commonplace._namespace_name local_name
        |> NamespacedName



type sanctuary =
    static member _namespace_name = "https://eristocrates.dev/ontology/sanctuary/"

    static member _prefix local_name =
        Namespaced_IRI.parse sanctuary._namespace_name local_name
        |> NamespacedName

    static member eristocrates = sanctuary._prefix "eristocrates"
    static member siamesederp = sanctuary._prefix "siamesederp"





(*


module The_16th_Sanctuary = 
    module Rhythm_Games = 
        module rhythm_game_chat = 


            [<Literal>]
            let sample_file_path =
                @"D:\Surface\Personal\16thSanctuary\The 16th Sanctuary - Rhythm Games - rhythm-game-chat [879472415682490408].json"

            let json = JsonProvider<sample_file_path>.Load sample_file_path







let discord_users = 
    The_16th_Sanctuary.Rhythm_Games.rhythm_game_chat.json.Messages
    |> Array.Parallel.map (fun Message -> 

        sanctuary._prefix Message.Author.Name

    )
    |> Array.distinct
    |> Array.sort
    |> Array.toList

discord_users.Length


let current_nickname_by_name = 
    The_16th_Sanctuary.Rhythm_Games.rhythm_game_chat.json.Messages
    |> Array.Parallel.map (fun Message -> 

        Message.Author.Name, Message.Author.Nickname

    )
    |> Array.distinct
    |> Array.sort
    |> Map.ofArray
let roles_by_name = 
    The_16th_Sanctuary.Rhythm_Games.rhythm_game_chat.json.Messages
    |> Array.Parallel.map (fun Message -> 

        Message.Author.Name, Message.Author.Roles |> Array.Parallel.map (fun Role -> Role.Name)

    )
    |> Array.distinct
    |> Array.sort
    |> Map.ofArray

roles_by_name["cndr_scnr"]







!|discord_users
-~|> [ a ->- foaf.Person ]
|> write_draft __SOURCE_DIRECTORY__ "test_graph"


*)






module ucd =

    let _namespace_name = "http://www.unicode.org/ns/2003/ucd/1.0"
    let _prefix (local_name:string) =
        Namespaced_IRI.parse _namespace_name (local_name.Replace(" ","_"))
        |> NamespacedName
    [<Literal>]
    let file_path = @"D:\Surface\Standards\Unicode\UCD\17.0.0\ucdxml\ucd.all.flat.xml"

    let xpath = XPathNavigator.Load(file_path)
    let namespace_manager = new XmlNamespaceManager(xpath.NameTable)

    xpath
    |> XPathNavigator.xmlns namespace_manager "ucd" _namespace_name
    |> ignore
    let xml = XmlProvider<file_path>.Load(file_path)


let xpath (expression: string) (xpath_navigator: XPathNavigator) =
    let xpath_expression = XPathExpression.Compile(expression)
    xpath_expression.SetContext(ucd.namespace_manager)

    xpath_navigator
        .Select(
            xpath_expression
        )
        .toElementArray

let unicode_directory = Path.Combine(__SOURCE_DIRECTORY__,"unicode")


type ucdx = 
    static member _namespace_name = "https://eristocrates.dev/ontology/ucdx/"

    static member _prefix (local_name:string) =
        Namespaced_IRI.parse ucdx._namespace_name (local_name.Replace(" ","_"))
        |> NamespacedName
    static member Block = ucdx._prefix "Block"
    static member Block_List = ucdx._prefix "Block_List"
    static member Code_Point_List = ucdx._prefix "Code_Point_List"
    static member name = ucdx._prefix "name"
    static member first_code_point = ucdx._prefix "first_code_point"
    static member last_code_point = ucdx._prefix "last_code_point"
    static member Code_Point = ucdx._prefix "Code_Point"


ucd.xml.Blocks
|> Array.take 1
|> Array.iter (fun Block -> 

    let block = ucdx._prefix Block.Name
    let first_code_point = ucdx._prefix Block.FirstCp.Value
    let last_code_point = ucdx._prefix Block.LastCp
    
    let block_directory = Path.Combine(unicode_directory,Block.Name.Replace(" ","_"))
    Directory.CreateDirectory block_directory |> ignore


    !>block  -~|> [ 

            a ->- ucdx.Block 
            ucdx.name ->= Block.Name
            ucdx.first_code_point ->- first_code_point
            ucdx.last_code_point ->- last_code_point

        ] 
    -!| [ first_code_point ; last_code_point ] --- a --> ucdx.Code_Point 
        |> write_draft block_directory Block.Name
    
)


type Block_Range = 
    {

    name: string
    interval_range: Interval<int, FRange.Range<int>>

    }

let block_ranges = 

    ucd.xml.Blocks
    |> Array.Parallel.map (fun Block -> 

        {
            name = Block.Name
            interval_range =  (int $"0x{Block.FirstCp.Value}") +-+ (int $"0x{Block.LastCp}")
        }



)


ucd.xpath
|> xpath $"//ucd:char"
|> Array.toSeq
|> PSeq.filter (fun char_element ->

    let cp = char_element.Attribute "cp" 
    String.IsNullOrWhiteSpace(char_element.GetAttribute("first-cp", ""))
    && block_ranges[0].interval_range |> Interval_Range.contains (int $"0x{cp}")

)
|>PSeq.iter (fun char_element -> 

    let cp = char_element.Attribute "cp"
    let code_point = ucd._prefix cp
    let ordinal = int $"0x{cp}"
    let block_name = 
        block_ranges
        |> Array.pick (fun block_range -> 
        
        if block_range.interval_range |> Interval_Range.contains ordinal then
            Some block_range.name
        else 
            None
        
        )
    let code_point_directory = Path.Combine(unicode_directory,block_name.Replace(" ","_"), cp)
    let block = ucdx._prefix block_name
    char_element.MoveToFirstAttribute() |> ignore
    let predicateObjectLists =
        char_element.Attributes
        |> Array.Parallel.filter (fun char_attribute -> not (String.IsNullOrEmpty char_attribute.Value))
        |> Array.Parallel.map (fun char_attribute -> (ucdx._prefix char_attribute.LocalName) ->= char_attribute.Value)
        |> Array.toList
    
    !>block --- rdfs.``member``--> code_point
    -!> code_point -~|> predicateObjectLists
    |> write_draft code_point_directory cp
        

    


)


(*




// TODO  next separate lmdb all string encodings and type serializations

// TODO look into generation of force directed graphs (vasturiano, ngraph etc)
// TODO look into fable for js generation
// TODO look into formalizing https://archipelago.gg/
// TODO look into getting python ast ( maybe even from f# somehow?)


*)





(*

<Bob> <is a> <person>.
<Bob> <is a friend of> <Alice>.
<Bob> <is born on> <the 4th of July 1990>.
<Bob> <is interested in> <the Mona Lisa>.
<the Mona Lisa> <was created by> <Leonardo da Vinci>.
<the video 'La Joconde à Washington'> <is about> <the Mona Lisa>.


*)
(*


!>dbug.Bob
-~| [

      a ->- foaf.Person
      rel.friendOf ->- dbug.Alice
      foaf.birthday ->= (DateOnly.Parse("7/4/1990"))

      ]
--- pext.isInterestedIn
-->/ dbug.The_Mona_Lisa
--- om.createdBy
--> dbug.Leonardo_da_Vinci
-!> dbug.La_Joconde_a_Washington
-~|> [ a ->- lib.Video
       foaf.focus ->- dbug.The_Mona_Lisa ]


*)










// TODO decide on how to handle querying.
// do i hook into dotnetrdf and grafeo, or hand roll my own sparql/gremlin/cypher?
(*

!<= "Alice" --| [ sioc.name; foaf.name ]
-<-/ dbug.Alice
--- a
-->/ foaf.Person
--- a
--> owl.Class
-!> dbug.Alice
-~| [ a ->- foaf.Person
      foaf.knows ->- dbug.Bob
      foaf.name ->=| [ "Alice"; "alice" ] ]
|> Turtle.write_draft __SOURCE_DIRECTORY__ "test_graph"



*)





// TODO rework lmdb?
// maybe explicitly create property graph types....
// maybe explicitly create property graph types....

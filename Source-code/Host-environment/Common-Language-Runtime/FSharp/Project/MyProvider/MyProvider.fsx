// C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\RdfProvided.txt
fsi.ShowDeclarationValues <- false

open System
open System.IO
open System.Text

#r "nuget: Unquote"
open Swensen.Unquote.Assertions

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

#r "nuget: dotNetRdf"

#r @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Project\MyProvider\src\MyProvider.Runtime\bin\Release\netstandard2.0\MyProvider.Runtime.dll"

open VDS.RDF
open VDS.RDF.Parsing
open VDS.RDF.Parsing.Tokens
open VDS.RDF.Storage
open VDS.RDF.Writing
open VDS.RDF.Query.Datasets
open MyNamespace
open MyProvider

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Namespace_Prefixes.fsx"
open Namespace_Prefixes

// RDFa Core Initial Context
// https://www.w3.org/2011/rdfa-context/rdfa-1.1
type as_ =
    RDF_Vocabulary<"https://www.w3.org/ns/activitystreams#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\www.w3.org\ns\activitystreams\hash\as.ttl">

type csvw =
    RDF_Vocabulary<"http://www.w3.org/ns/csvw#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\csvw\hash\csvw.ttl">

type dcat =
    RDF_Vocabulary<"http://www.w3.org/ns/dcat#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\dcat\hash\dcat.ttl">

type dqv =
    RDF_Vocabulary<"http://www.w3.org/ns/dqv#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\dqv\hash\dqv.ttl">

type duv =
    RDF_Vocabulary<"http://www.w3.org/ns/duv#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\duv\hash\duv.ttl">

type grddl =
    RDF_Vocabulary<"http://www.w3.org/2003/g/data-view#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2003\g\data-view\hash\grddl.ttl">

type jsonld =
    RDF_Vocabulary<"http://www.w3.org/ns/json-ld#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\json-ld\hash\jsonld.ttl">

type ldp =
    RDF_Vocabulary<"http://www.w3.org/ns/ldp#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\ldp\hash\ldp.ttl">

type ma_ont =
    RDF_Vocabulary<"http://www.w3.org/ns/ma-ont#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\ma-ont\hash\ma-ont.ttl">

type oa =
    RDF_Vocabulary<"http://www.w3.org/ns/oa#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\oa\hash\oa.ttl">

type odrl =
    RDF_Vocabulary<"http://www.w3.org/ns/odrl/2/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\odrl\2\slash\odrl.ttl">

type org =
    RDF_Vocabulary<"http://www.w3.org/ns/org#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\org\hash\org.ttl">

type owl =
    RDF_Vocabulary<"http://www.w3.org/2002/07/owl#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2002\07\owl\hash\owl.ttl">

type prov =
    RDF_Vocabulary<"http://www.w3.org/ns/prov#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\prov\hash\prov.ttl">

type qb =
    RDF_Vocabulary<"http://purl.org/linked-data/cube#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\purl.org\linked-data\cube\hash\qb.ttl">

type rdf =
    RDF_Vocabulary<"http://www.w3.org/1999/02/22-rdf-syntax-ns#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\1999\02\22-rdf-syntax-ns\hash\rdf.ttl">

type rdfa =
    RDF_Vocabulary<"http://www.w3.org/ns/rdfa#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\rdfa\hash\rdfa.ttl">

type rdfs =
    RDF_Vocabulary<"http://www.w3.org/2000/01/rdf-schema#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2000\01\rdf-schema\hash\rdfs.ttl">
// TODO get rif 	http://www.w3.org/2007/rif#
// unfortunately involves implementing mapping https://www.w3.org/TR/rif-in-rdf/
type rr =
    RDF_Vocabulary<"http://www.w3.org/ns/r2rml#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\r2rml\hash\rr.ttl">

type sd =
    RDF_Vocabulary<"http://www.w3.org/ns/sparql-service-description#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\sparql-service-description\hash\sd.ttl">

type skos =
    RDF_Vocabulary<"http://www.w3.org/2004/02/skos/core#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2004\02\skos\core\hash\skos.ttl">

type skosxl =
    RDF_Vocabulary<"http://www.w3.org/2008/05/skos-xl#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2008\05\skos-xl\hash\skosxl.ttl">

type ssno =
    RDF_Vocabulary<"http://www.w3.org/ns/ssn/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\ssn\slash\ssno.ttl">

type sosa =
    RDF_Vocabulary<"http://www.w3.org/ns/sosa/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\sosa\slash\sosa.ttl">


type void_ =
    RDF_Vocabulary<"http://rdfs.org/ns/void#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\rdfs.org\ns\void\hash\void.ttl">

type powder =
    RDF_Vocabulary<"http://www.w3.org/2007/05/powder#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2007\05\powder\hash\powder.ttl">

type wdrs =
    RDF_Vocabulary<"http://www.w3.org/2007/05/powder-s#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2007\05\powder-s\hash\wdrs.ttl">

type xhv =
    RDF_Vocabulary<"http://www.w3.org/1999/xhtml/vocab#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\1999\xhtml\vocab\hash\xhv.ttl">
// TODO process full xhtml dtd https://www.w3.org/TR/xhtml1/xhtml1.zip

type xsd =
    RDF_Vocabulary<"http://www.w3.org/2001/XMLSchema#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2001\XMLSchema\hash\xsd.ttl">


// Some vocabularies are currently in development at W3C and they may become W3C Recommendations or Notes, i.e., may become part of the table above. It is therefore advisable to consider their prefixes reserved for now. These are:

type earl =
    RDF_Vocabulary<"http://www.w3.org/ns/earl#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\earl\hash\earl.ttl">




// Widely used Vocabulary prefixes based on the vocabulary usage on the Semantic Web
// https://www.w3.org/2010/02/rdfa/profile/data/








type cc =
    RDF_Vocabulary<"http://creativecommons.org/ns#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\creativecommons.org\ns\hash\cc.ttl">

type ctag =
    RDF_Vocabulary<"http://commontag.org/ns#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\commontag.org\ns\hash\ctag.ttl">

type dcterms =
    RDF_Vocabulary<"http://purl.org/dc/terms/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\purl.org\dc\terms\slash\dcterms.ttl">

type dce =
    RDF_Vocabulary<"http://purl.org/dc/elements/1.1/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\purl.org\dc\elements\1.1\slash\dce.ttl">

type foaf =
    RDF_Vocabulary<"http://xmlns.com/foaf/0.1/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\xmlns.com\foaf\0.1\slash\foaf.ttl">

type gr =
    RDF_Vocabulary<"http://purl.org/goodrelations/v1#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\purl.org\goodrelations\v1\hash\gr.ttl">
// TODO get ical 	http://www.w3.org/2002/12/cal/icaltzd#
// unfortunately requires dealing with malformed syntax, multiple rdf:IDs
// i'll try cal instead
type cal =
    RDF_Vocabulary<"http://www.w3.org/2002/12/cal/ical#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2002\12\cal\ical\hash\cal.ttl">

type og =
    RDF_Vocabulary<"http://ogp.me/ns#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\ogp.me\ns\hash\og.ttl">

type rev =
    RDF_Vocabulary<"http://purl.org/stuff/rev#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\purl.org\stuff\rev\hash\rev.ttl">

type sioc =
    RDF_Vocabulary<"http://rdfs.org/sioc/ns#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\rdfs.org\sioc\ns\hash\sioc.ttl">

type vcard =
    RDF_Vocabulary<"http://www.w3.org/2006/vcard/ns#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2006\vcard\ns\hash\vcard.ttl">

type schemas =
    RDF_Vocabulary<"https://schema.org/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\schema.org\slash\schemas.ttl">

// ------------------------------------------------------------------------------------------------------------------------------------------------------


type tsioc =
    RDF_Vocabulary<"http://rdfs.org/sioc/types#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\rdfs.org\sioc\types\hash\tsioc.ttl">

type tzont =
    RDF_Vocabulary<"http://www.w3.org/2006/timezone#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2006\timezone\hash\tzont.ttl">


type hydra =
    RDF_Vocabulary<"http://www.w3.org/ns/hydra/core#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\hydra\core\hash\hydra.ttl">


type fresnel =
    RDF_Vocabulary<"http://www.w3.org/2004/09/fresnel#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2004\09\fresnel\hash\fresnel.ttl">

type voaf =
    RDF_Vocabulary<"http://purl.org/vocommons/voaf#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\purl.org\vocommons\voaf\hash\voaf.ttl">

type vann =
    RDF_Vocabulary<"http://purl.org/vocab/vann/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\purl.org\vocab\vann\slash\vann.ttl">

type vaem =
    RDF_Vocabulary<"http://www.linkedmodel.org/schema/vaem#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.linkedmodel.org\schema\vaem\hash\vaem.ttl">

type lemon =
    RDF_Vocabulary<"http://lemon-model.net/lemon#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\lemon-model.net\lemon\hash\lemon.ttl">

type ontolex =
    RDF_Vocabulary<"http://www.w3.org/ns/lemon/ontolex#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\lemon\ontolex\hash\ontolex.ttl">

type vartrans =
    RDF_Vocabulary<"http://www.w3.org/ns/lemon/vartrans#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\lemon\vartrans\hash\vartrans.ttl">

type synsem =
    RDF_Vocabulary<"http://www.w3.org/ns/lemon/synsem#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\lemon\synsem\hash\synsem.ttl">

type decomp =
    RDF_Vocabulary<"http://www.w3.org/ns/lemon/decomp#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\lemon\decomp\hash\lexdcp.ttl">

type lime =
    RDF_Vocabulary<"http://www.w3.org/ns/lemon/lime#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\lemon\lime\hash\lime.ttl">

type lexinfo =
    RDF_Vocabulary<"http://www.lexinfo.net/ontology/2.0/lexinfo#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.lexinfo.net\ontology\2.0\lexinfo\hash\lexinfo.ttl">

type termlex =
    RDF_Vocabulary<"https://termlex.oeg.fi.upm.es/termlex#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\termlex.oeg.fi.upm.es\termlex\hash\termlex.ttl">

type fno =
    RDF_Vocabulary<"https://w3id.org/function/ontology#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\function\ontology\hash\fno.ttl">

type fnom =
    RDF_Vocabulary<"https://w3id.org/function/vocabulary/mapping#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\function\vocabulary\mapping\hash\fnom.ttl">

type fnoi =
    RDF_Vocabulary<"https://w3id.org/function/vocabulary/implementation#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\function\vocabulary\implementation\hash\fnoi.ttl">

type fnoc =
    RDF_Vocabulary<"https://w3id.org/function/vocabulary/composition#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\function\vocabulary\composition\hash\fnoc.ttl">

type rml_io =
    RDF_Vocabulary<"http://w3id.org/rml/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\w3id.org\rml\slash\rml-io.ttl">

type rml_cc =
    RDF_Vocabulary<"http://w3id.org/rml/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\w3id.org\rml\slash\rml-cc.ttl">

type rml_fnml =
    RDF_Vocabulary<"http://w3id.org/rml/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\w3id.org\rml\slash\rml-fnml.ttl">

type rml_star =
    RDF_Vocabulary<"http://w3id.org/rml/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\w3id.org\rml\slash\rml-star.ttl">

type sh =
    RDF_Vocabulary<"http://www.w3.org/ns/shacl#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\shacl\hash\sh.ttl">

type psh =
    RDF_Vocabulary<"http://ns.inria.fr/probabilistic-shacl/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\ns.inria.fr\probabilistic-shacl\slash\psh.ttl">

type shsh =
    RDF_Vocabulary<"http://www.w3.org/ns/shacl-shacl#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\shacl-shacl\hash\shsh.ttl">

type shex =
    RDF_Vocabulary<"http://www.w3.org/ns/shex#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\shex\hash\shex.ttl">

type sp =
    RDF_Vocabulary<"http://spinrdf.org/sp#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\spinrdf.org\sp\hash\sp.ttl">

type spin =
    RDF_Vocabulary<"http://spinrdf.org/spin#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\spinrdf.org\spin\hash\spin.ttl">

type agrontology =
    RDF_Vocabulary<"http://aims.fao.org/aos/agrontology#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\aims.fao.org\aos\agrontology\hash\agrontology.ttl">

type nmo =
    RDF_Vocabulary<"http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.semanticdesktop.org\ontologies\2007\03\22\nmo\hash\nmo.ttl">

type nexif =
    RDF_Vocabulary<"http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.semanticdesktop.org\ontologies\2007\05\10\nexif\hash\nexif.ttl">

type nid3 =
    RDF_Vocabulary<"http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.semanticdesktop.org\ontologies\2007\05\10\nid3\hash\nid3.ttl">

type pimo =
    RDF_Vocabulary<"http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.semanticdesktop.org\ontologies\2007\11\01\pimo\hash\pimo.ttl">

type tmo =
    RDF_Vocabulary<"http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.semanticdesktop.org\ontologies\2008\05\20\tmo\hash\tmo.ttl">

type tnrl =
    RDF_Vocabulary<"http://tracker.api.gnome.org/ontology/v3/nrl#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\tracker.api.gnome.org\ontology\v3\nrl\hash\tnrl.ttl">

type tnie =
    RDF_Vocabulary<"http://tracker.api.gnome.org/ontology/v3/nie#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\tracker.api.gnome.org\ontology\v3\nie\hash\tnie.ttl">

type tnao =
    RDF_Vocabulary<"http://tracker.api.gnome.org/ontology/v3/nao#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\tracker.api.gnome.org\ontology\v3\nao\hash\tnao.ttl">

type tnco =
    RDF_Vocabulary<"http://tracker.api.gnome.org/ontology/v3/nco#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\tracker.api.gnome.org\ontology\v3\nco\hash\tnco.ttl">

type tnfo =
    RDF_Vocabulary<"http://tracker.api.gnome.org/ontology/v3/nfo#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\tracker.api.gnome.org\ontology\v3\nfo\hash\tnfo.ttl">

type tnmm =
    RDF_Vocabulary<"http://tracker.api.gnome.org/ontology/v3/nmm#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\tracker.api.gnome.org\ontology\v3\nmm\hash\tnmm.ttl">

type tmfo =
    RDF_Vocabulary<"http://tracker.api.gnome.org/ontology/v3/mfo#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\tracker.api.gnome.org\ontology\v3\mfo\hash\tmfo.ttl">

type tracker =
    RDF_Vocabulary<"http://tracker.api.gnome.org/ontology/v3/tracker#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\tracker.api.gnome.org\ontology\v3\tracker\hash\tracker.ttl">

type tslo =
    RDF_Vocabulary<"http://tracker.api.gnome.org/ontology/v3/slo#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\tracker.api.gnome.org\ontology\v3\slo\hash\tslo.ttl">

type tosinfo =
    RDF_Vocabulary<"http://tracker.api.gnome.org/ontology/v3/osinfo#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\tracker.api.gnome.org\ontology\v3\osinfo\hash\tosinfo.ttl">

type nie =
    RDF_Vocabulary<"http://www.semanticdesktop.org/ontologies/2007/01/19/nie#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.semanticdesktop.org\ontologies\2007\01\19\nie\hash\nie.ttl">

type nco =
    RDF_Vocabulary<"http://www.semanticdesktop.org/ontologies/2007/03/22/nco#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.semanticdesktop.org\ontologies\2007\03\22\nco\hash\nco.ttl">

type nfo =
    RDF_Vocabulary<"http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.semanticdesktop.org\ontologies\2007\03\22\nfo\hash\nfo.ttl">

type ncal =
    RDF_Vocabulary<"http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.semanticdesktop.org\ontologies\2007\04\02\ncal\hash\ncal.ttl">

type nao =
    RDF_Vocabulary<"http://www.semanticdesktop.org/ontologies/2007/08/15/nao#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.semanticdesktop.org\ontologies\2007\08\15\nao\hash\nao.ttl">

type nrl =
    RDF_Vocabulary<"http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.semanticdesktop.org\ontologies\2007\08\15\nrl\hash\nrl.ttl">

type linkml =
    RDF_Vocabulary<"https://w3id.org/linkml/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-meta.owl.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-annotations.model.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-annotations.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-datasets.model.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-datasets.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-extensions.model.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-extensions.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-mappings.model.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-mappings.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-meta.model.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-meta.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-types.model.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-types.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-units.model.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-units.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-validation.model.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\w3id.org\linkml\slash\linkml-validation.ttl">

type owl_time =
    RDF_Vocabulary<"http://www.w3.org/2006/time#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2006\time\hash\time.ttl">

type ermrk =
    RDF_Vocabulary<"http://www.essepuntato.it/2008/12/earmark#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.essepuntato.it\2008\12\earmark\hash\ermrk-ghost.owl.ttl;C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.essepuntato.it\2008\12\earmark\hash\ermrk-shell.owl.ttl">

type solid =
    RDF_Vocabulary<"http://www.w3.org/ns/solid/terms#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\solid\terms\hash\solid.ttl">

type ws =
    RDF_Vocabulary<"http://www.w3.org/ns/pim/space#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\pim\space\hash\ws.ttl">

type acl =
    RDF_Vocabulary<"http://www.w3.org/ns/auth/acl#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\ns\auth\acl\hash\acl.ttl">

type http =
    RDF_Vocabulary<"http://www.w3.org/2011/http#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2011\http\hash\http.ttl">

type cnt =
    RDF_Vocabulary<"http://www.w3.org/2011/content#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.w3.org\2011\content\hash\cnt.ttl">

type rel =
    RDF_Vocabulary<"http://purl.org/vocab/relationship/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\purl.org\vocab\relationship\slash\rel.ttl">

type pext =
    RDF_Vocabulary<"http://www.ontotext.com/proton/protonext#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.ontotext.com\proton\protonext\hash\pext.ttl">

type ptop =
    RDF_Vocabulary<"http://www.ontotext.com/proton/protontop#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\www.ontotext.com\proton\protontop\hash\ptop.ttl">

type om =
    RDF_Vocabulary<"https://open-metadata.org/ontology/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\https\open-metadata.org\ontology\slash\om.ttl">

type dbpedia_owl =
    RDF_Vocabulary<"http://dbpedia.org/ontology/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\dbpedia.org\ontology\slash\dbpedia-owl.ttl">

type dbnary =
    RDF_Vocabulary<"http://kaiko.getalp.org/dbnary#", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\kaiko.getalp.org\dbnary\hash\dbnary.ttl">

type lib =
    RDF_Vocabulary<"http://purl.org/library/", @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary\http\purl.org\library\slash\lib.ttl">

let a = rdf.``type``

/// https://www.w3.org/XML/1998/namespace
type xml =
    static member _namespace_name = "http://www.w3.org/XML/1998/namespace#"

    static member _prefix local_name =
        NamespacedIri(xml._namespace_name, local_name)
        |> Iri.FromNamespacedIri

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
        NamespacedIri(xsi._namespace_name, local_name)
        |> Iri.FromNamespacedIri

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
        NamespacedIri(xdt._namespace_name, local_name)
        |> Iri.FromNamespacedIri

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


// type data = static member _ "data:text/plain;charset=UTF-8;"











































































module Literal =
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










































type PredicateObjectList =

    {

      verb: Predicate_Term
      objectLists: ObjectList array

     }


    static member inline from_terms (predicate: Predicate_Term) (objects: Object_Term array) =
        {

          verb = predicate
          objectLists =
            objects
            |> Array.map (fun object_term ->
                { object_term = object_term
                  annotations = [||]

                })



        }

and ObjectList =
    { object_term: Object_Term
      annotations: Annotation array }

and Annotation =
    | Reifier of Subject_Term
    | AnnotationBlock of PredicateObjectList

module Triples =
    let from_terms
        (subject_terms: Subject_Term array)
        (predicate_terms: Predicate_Term array)
        (object_terms: Object_Term array)
        =
        object_terms
        |> Array.Parallel.collect (fun object_term ->

            predicate_terms
            |> Array.Parallel.collect (fun predicate_term ->

                subject_terms
                |> Array.Parallel.map (fun subject_term ->

                    {

                      curSubject = subject_term
                      curPredicate = predicate_term
                      curObject = object_term

                    }

                )))
        |> Set.ofArray

    let from_subjects_predicateObjectLists
        (subject_terms: Subject_Term array)
        (predicateObjectLists: PredicateObjectList array)
        =
        subject_terms
        |> Array.Parallel.collect (fun subject_term ->
            predicateObjectLists
            |> Array.Parallel.collect (fun predicateObjectList ->
                predicateObjectList.objectLists
                |> Array.Parallel.map (fun objectList ->
                    // TODO deal with annotations


                    { curSubject = subject_term
                      curPredicate = predicateObjectList.verb
                      curObject = objectList.object_term }

                )



            )



        )
        |> Set.ofArray





type Quad =
    { triple: Triple
      curGraph: Subject_Term option }
    static member inline from_terms
        (subject: ^SubjectType when ^SubjectType: (member as_subject: Subject_Term))
        (predicate: ^PredicateType when ^PredicateType: (member as_predicate: Predicate_Term))
        (object: ^ObjectType when ^ObjectType: (member as_object: Object_Term))
        (graph_name: ^SubjectType when ^SubjectType: (member as_subject: Subject_Term))
        =
        {

          triple = Triple.from_terms subject predicate object
          curGraph = Some graph_name.as_subject

        }

    member this.curSubject = this.triple.curSubject


    member this.curPredicate = this.triple.curPredicate

    member this.curObject = this.triple.curObject



let inline predicateObjectList
    (predicate: ^PredicateType when ^PredicateType: (member as_predicate: Predicate_Term))
    (objectlist: ^ObjectType array when ^ObjectType: (member as_object: Object_Term))
    : Predicate_Term * Object_Term array =
    predicate.as_predicate,
    objectlist
    |> Array.map (fun objecttlist_item -> objecttlist_item.as_object)



let inline ttriples (subjectlist: Subject_Term list) (predicateObjectLists: (Predicate_Term * Object_Term list) list) =
    set [ for subject in subjectlist do
              for predicate, objectlist in predicateObjectLists do
                  for object in objectlist do
                      { curSubject = subject
                        curPredicate = predicate
                        curObject = object } ]






// (subject * ((predicate * (object list))list)) list

// object * predicate
// object * predicate * subject

// <^SubjectType, ^PredicateType, ^ObjectType when ^SubjectType:  and ^PredicateType: (member as_predicate: Predicate_Term) and ^ObjectType: (member as_object: Object_Term)> =




type Draft_Document =
    {

      subjects: Subject_Term array
      predicates: Predicate_Term array
      objects: Object_Term array
      predicateObjectLists: PredicateObjectList array
      triples: Set<Triple>

     }

    static member from_subject subject_term =

        { subjects = [| subject_term |]
          predicates = [||]
          objects = [||]
          predicateObjectLists = [||]
          triples = set [||]

        }

    static member from_subjects subjects =

        { subjects = subjects |> List.toArray
          predicates = [||]
          objects = [||]
          predicateObjectLists = [||]
          triples = set [||]

        }

    static member from_predicate predicate_term =

        { subjects = [||]
          predicates = [| predicate_term |]
          objects = [||]
          predicateObjectLists = [||]
          triples = set [||]

        }

    static member from_predicates predicates =

        { subjects = [||]
          predicates = predicates
          objects = [||]
          predicateObjectLists = [||]
          triples = set [||]

        }

    static member from_object object_term =

        { subjects = [||]
          predicates = [||]
          objects = [| object_term |]
          predicateObjectLists = [||]
          triples = set [||]

        }

    static member from_objects objects =

        { subjects = [||]
          predicates = [||]
          objects = objects
          predicateObjectLists = [||]
          triples = set [||]

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
            Set.union
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
        Literal.autotyped literal
        |> Object_Term.FromLiteral
        |> this.add_object

    member this.add_literals literals =
        literals
        |> List.toArray
        |> Array.Parallel.map (fun literal ->
            literal
            |> Literal.autotyped
            |> Object_Term.FromLiteral)
        |> this.add_objects



let global_prefix_map = global_prefix_declarations |> Map.ofArray

let curie (iri: Namespaced_Iri) =
    sprintf "%s:%s" global_prefix_map[iri.namespace_name] iri.local_name

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


[<StructuralComparison; StructuralEquality>]
type Vertex_ID = private NodeID of UInt64

[<StructuralComparison; StructuralEquality>]
type Edge_ID = private EdgeID of UInt64

[<RequireQualifiedAccess; StructuralComparison; StructuralEquality>]
type Vertex =
    | FromSubject of Subject_Term
    | FromObject of Object_Term
    member this.yog_label =
        match this with
        | FromSubject (Subject_Term.FromIri (Iri.FromNamespacedIri iri)) -> curie iri
        | FromObject (Object_Term.FromIri (Iri.FromNamespacedIri iri)) -> curie iri
        | FromSubject subject_term -> subject_term.rdf_string
        | FromObject object_term -> object_term.rdf_string



(*

    | FromIri of  Iri
    | FromBlankNode of  Blank_Node
    | FromLiteral of  Literal
    | FromTripleTerm of Triple_Term
    static member from_subject (subject_term :Subject_Term) =
        match subject_term with
        | Subject_Term.FromIri iri -> FromIri iri
        | Subject_Term.FromBlankNode blank_node -> FromBlankNode blank_node
    static member from_object (object_term :Object_Term) =
        match object_term with
        | Object_Term.FromIri iri -> FromIri iri
        | Object_Term.FromBlankNode blank_node -> FromBlankNode blank_node
        | Object_Term.FromLiteral literal -> FromLiteral literal
        | Object_Term.FromTripleTerm triple_term -> FromTripleTerm triple_term


    *)




[<RequireQualifiedAccess; StructuralComparison; StructuralEquality>]
type Edge =
    | FromTriple of Triple
    | FromPredicate of Predicate_Term

    member this.yog_label =
        match this with
        | FromTriple triple ->
            match triple.curPredicate with
            | Predicate_Term.FromIri (Iri.FromNamespacedIri iri) -> curie iri
            | Predicate_Term.FromIri iri -> iri.rdf_string
        | FromPredicate predicate_term ->
            match predicate_term with
            | Predicate_Term.FromIri (Iri.FromNamespacedIri iri) -> curie iri
            | Predicate_Term.FromIri iri -> iri.rdf_string



type Textual_Syntax =
    {

      syntax_name: string
      file_extension: string

     }
    member this.file_path parent_directory stem =
        Directory.CreateDirectory(parent_directory)
        |> ignore

        Path.Combine(parent_directory, sprintf "%s.%s" stem this.file_extension)


module NQuads =
    let syntax =
        { syntax_name = "N-Quads"
          file_extension = "nq" }

    let mime = Mime_Path.application.n.quads.media_type

module TriG =
    let syntax =
        { syntax_name = "TriG"
          file_extension = "trig"

        }

    let mime = Mime_Path.application.trig.media_type

module NTriples =
    let syntax =
        { syntax_name = "NTriples"
          file_extension = "nt"

        }

    let mime = Mime_Path.application.n.triples.media_type

    let parser = NTriplesParser()

    let parse (text: string) (graph: IGraph) =
        use reader = new StringReader(text)
        parser.Load(graph, reader)




type Rdf_Graph =
    { triples: Set<Triple> }
    member this.nt_lines =
        this.triples
        |> Set.toArray
        |> Array.Parallel.map (fun triple -> triple.nt)

    member this.nt_text = this.nt_lines |> String.concat "\n"

    member this.ddot_lines =
        this.triples
        |> Set.toArray
        |> Array.Parallel.map (fun triple -> triple.ddot)

    member this.ddot_text = this.ddot_lines |> String.concat "\n"


    member this.to_igraph() =
        let igraph = new ThreadSafeGraph()
        NTriples.parse this.nt_text igraph
        igraph


    member this.as_igraph(igraph: IGraph) = NTriples.parse this.nt_text igraph




module Rdf_Graph =
    let to_igraph (rdf_graph: Rdf_Graph) =
        let igraph = new ThreadSafeGraph()
        NTriples.parse rdf_graph.nt_text igraph
        igraph


    let to_yograph (rdf_graph: Rdf_Graph) =
        rdf_graph.triples
        |> Set.toArray
        |> Array.Parallel.map (fun triple ->
            Vertex.FromSubject triple.curSubject,
            Vertex.FromObject triple.curObject,
            Edge.FromPredicate triple.curPredicate)
        |> Array.toList
        |> Labeled.fromList Directed
        |> Labeled.toGraph

    let to_d2_lines (rdf_graph: Rdf_Graph) =
        rdf_graph.triples
        |> Set.toArray
        |> Array.Parallel.map (fun triple ->
            Vertex.FromSubject triple.curSubject,
            Vertex.FromObject triple.curObject,
            Edge.FromPredicate triple.curPredicate)
        |> Array.Parallel.map (fun (in_vertex, out_vertex, out_edge) ->
            sprintf "%s -> %s : %s" in_vertex.yog_label out_vertex.yog_label out_edge.yog_label)

    let to_d2_text (rdf_graph: Rdf_Graph) =
        rdf_graph |> to_d2_lines |> String.concat "\n"


module Turtle =
    let syntax =
        { syntax_name = "Turtle"
          file_extension = "ttl" }

    let mime = Mime_Path.text.turtle.media_type


    let writer =
        let writer = new CompressingTurtleWriter(TurtleSyntax.Rdf11Star)
        writer.HighSpeedModePermitted <- false
        writer.PrettyPrintMode <- true
        writer

    let write_igraph (parent_directory: string) (stem: string) (graph: VDS.RDF.IGraph) =
        map_prefixes graph
        writer.Save(graph, syntax.file_path parent_directory stem)

    let write_draft (parent_directory: string) (stem: string) (draft: Draft_Document) =
        let file_path = syntax.file_path parent_directory stem

        { triples = draft.triples }
        |> Rdf_Graph.to_igraph
        |> write_igraph parent_directory stem


module ddot =
    let syntax =
        { syntax_name = "ddot.it"
          file_extension = "ddot" }

module Dot =

    let syntax =
        { syntax_name = "Graphviz"
          file_extension = "dot" }

    let options: Dot.Options<Vertex, Edge> =
        {

          NodeLabel = (fun vertex_id vertex -> vertex.yog_label)
          EdgeLabel = (fun edge -> edge.yog_label)
          HighlightedSourceNodes = Set.empty
          HighlightedSinkNodes = Set.empty
          HighlightedNodes = Set.empty
          HighlightedEdges = Set.empty
          NodeShape = "ellipse"
          HighlightColor = "red"

        }


    let write_yograph (parent_directory: string) (stem: string) yograph =
        let file_path = syntax.file_path parent_directory stem
        Dot.writeFile file_path options yograph

    let write_draft (parent_directory: string) (stem: string) (draft: Draft_Document) =
        { triples = draft.triples }
        |> Rdf_Graph.to_yograph
        |> write_yograph parent_directory stem

module Mermaid =

    let syntax =
        { syntax_name = "Mermaid"
          file_extension = "mmd" }

    let options: Mermaid.Options<Vertex, Edge> =
        {

          Direction = "LR"
          NodeLabel = (fun vertex_id vertex -> vertex.yog_label)
          EdgeLabel = (fun edge -> edge.yog_label)
          HighlightedEdges = Set.empty
          HighlightedNodes = Set.empty
          HighlightedSinkNodes = Set.empty
          HighlightedSourceNodes = Set.empty

        }

    let write_yograph (parent_directory: string) (stem: string) yograph =
        let file_path = syntax.file_path parent_directory stem
        Mermaid.writeFile file_path options yograph

    let write_draft (parent_directory: string) (stem: string) (draft: Draft_Document) =
        { triples = draft.triples }
        |> Rdf_Graph.to_yograph
        |> write_yograph parent_directory stem

module D2 =

    let syntax =
        { syntax_name = "D2"
          file_extension = "d2" }

    let write_draft (parent_directory: string) (stem: string) (draft: Draft_Document) =
        let file_text =
            { triples = draft.triples }
            |> Rdf_Graph.to_d2_text

        let file_path = syntax.file_path parent_directory stem
        File.WriteAllText(file_path, file_text)



module Working_Statement =
    let materialize_triples (draft: Draft_Document) = draft.materialize_triples
    let emit_triples (draft: Draft_Document) = draft.triples
    let to_rdf_graph (draft: Draft_Document) = { triples = draft.triples }

    let to_igraph (draft: Draft_Document) =
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
let inline (!>) (subject_term: ^SubjectType when ^SubjectType: (member as_subject: Subject_Term)) : Draft_Document =
    Draft_Document.from_subject subject_term.as_subject

let inline (!|)
    (subject_terms: ^SubjectType list when ^SubjectType: (member as_subject: Subject_Term))
    : Draft_Document =
    subject_terms
    |> List.map (fun subject_term -> subject_term.as_subject)
    |> Draft_Document.from_subjects

let inline (!/)
    (predicate_term: ^PredicateType when ^PredicateType: (member as_predicate: Predicate_Term))
    : Draft_Document =
    Draft_Document.from_predicate predicate_term.as_predicate

let inline (!<) (object_term: ^ObjectType when ^ObjectType: (member as_object: Object_Term)) : Draft_Document =
    Draft_Document.from_object object_term.as_object

let inline (!<=) value_object =
    Literal.autotyped value_object
    |> Object_Term.FromLiteral
    |> Draft_Document.from_object


// subject adders
let inline (-!>)
    (draft: Draft_Document)
    (subject_term: ^SubjectType when ^SubjectType: (member as_subject: Subject_Term))
    =
    draft.add_subject subject_term.as_subject


// predicate adders
let inline (---)
    (draft: Draft_Document)
    (predicate_term: ^PredicateType when ^PredicateType: (member as_predicate: Predicate_Term))
    =
    draft.add_predicate predicate_term.as_predicate

let inline (--|)
    (draft: Draft_Document)
    (predicate_terms: ^PredicateType list when ^PredicateType: (member as_predicate: Predicate_Term))
    =
    predicate_terms
    |> List.toArray
    |> Array.Parallel.map (fun predicate_term -> predicate_term.as_predicate)
    |> draft.add_predicates

// predicateObjectList adders
let inline (-~|) (draft: Draft_Document) (predicateObjectLists: PredicateObjectList list) =
    predicateObjectLists
    |> List.toArray
    |> draft.add_predicateObjectLists

let inline (-~|>) (draft: Draft_Document) (predicateObjectLists: PredicateObjectList list) =
    predicateObjectLists
    |> List.toArray
    |> draft.add_predicateObjectLists
    |> Working_Statement.materialize_triples


let inline (->-)
    (predicate: ^PredicateType when ^PredicateType: (member as_predicate: Predicate_Term))
    (object: ^ObjectType when ^ObjectType: (member as_object: Object_Term))
    =
    PredicateObjectList.from_terms predicate.as_predicate [| object.as_object |]

let inline (->=) (predicate: ^PredicateType when ^PredicateType: (member as_predicate: Predicate_Term)) value_object =
    PredicateObjectList.from_terms
        predicate.as_predicate
        [| Literal.autotyped value_object
           |> Object_Term.FromLiteral |]

let inline (->=|) (predicate: ^PredicateType when ^PredicateType: (member as_predicate: Predicate_Term)) value_objects =
    let objects =
        value_objects
        |> List.map (fun value_object ->
            Literal.autotyped value_object
            |> Object_Term.FromLiteral)
        |> List.toArray

    PredicateObjectList.from_terms predicate.as_predicate objects


let inline (-->) (draft: Draft_Document) (object_term: ^ObjectType when ^ObjectType: (member as_object: Object_Term)) =
    draft.add_object object_term.as_object
    |> Working_Statement.materialize_triples

let inline (-<-)
    (draft: Draft_Document)
    (subject_term: ^SubjectType when ^SubjectType: (member as_subject: Subject_Term))
    =
    draft.add_subject subject_term.as_subject
    |> Working_Statement.materialize_triples

let inline (-<-/)
    (draft: Draft_Document)
    (subject_term: ^SubjectType when ^SubjectType: (member as_subject: Subject_Term))
    =
    let materialized_draft =
        draft.add_subject subject_term.as_subject
        |> Working_Statement.materialize_triples

    { materialized_draft with

        subjects = [| subject_term.as_subject |]

     }

let inline (-->/) (draft: Draft_Document) (object_term: ^ObjectType when ^ObjectType: (member as_object: Object_Term)) =
    let materialized_draft =
        draft.add_object object_term.as_object
        |> Working_Statement.materialize_triples

    { materialized_draft with

        subjects = object_term.as_object.to_subject

     }

let inline (-->=) (draft: Draft_Document) literal =
    draft.add_literal literal
    |> Working_Statement.materialize_triples

let inline (-->^) (draft: Draft_Document) (lexical_form: string) (datatype: Iri) =
    draft.add_literal (lexical_form ^^ datatype)
    |> Working_Statement.materialize_triples

let inline (-->@) (draft: Draft_Document) (lexical_form: string) (language_tag: Language_Tag) =
    lexical_form ^@ language_tag
    |> draft.add_literal
    |> Working_Statement.materialize_triples

let inline (-->@@)
    (draft: Draft_Document)
    (lexical_form: string)
    (language_tag: Language_Tag)
    (region_subtag: Region_Subtag)
    =
    lexical_form ^@@ (language_tag, region_subtag)
    |> draft.add_literal
    |> Working_Statement.materialize_triples


let inline (-->=|) (draft: Draft_Document) literals =
    draft.add_literals literals
    |> Working_Statement.materialize_triples

let inline (-->^|) (draft: Draft_Document) (lexical_forms: string list) (datatype: Iri) =
    lexical_forms
    |> List.map (fun lexical_form -> lexical_form ^^ datatype)
    |> draft.add_literals
    |> Working_Statement.materialize_triples

let inline (-->@|) (draft: Draft_Document) (lexical_forms: string list) (language_tag: Language_Tag) =
    lexical_forms
    |> List.map (fun lexical_form -> lexical_form ^@ language_tag)
    |> draft.add_literals
    |> Working_Statement.materialize_triples

let inline (-->@@|)
    (draft: Draft_Document)
    (lexical_forms: string list)
    (language_tag: Language_Tag)
    (region_subtag: Region_Subtag)
    =
    lexical_forms
    |> List.map (fun lexical_form -> lexical_form ^@@ (language_tag, region_subtag))
    |> draft.add_literals
    |> Working_Statement.materialize_triples




/// predicate object+
let inline (-->|)
    (draft: Draft_Document)
    (object_terms: ^ObjectType list when ^ObjectType: (member as_object: Object_Term))
    =
    object_terms
    |> List.toArray
    |> Array.Parallel.map (fun object_term -> object_term.as_object)
    |> draft.add_objects
    |> Working_Statement.materialize_triples

(*

// let subjectlist, predicate = subjectlist_predicate
// ttriples subjectlist [| predicateObjectList predicate [| object |] |]

/// subject+ predicate
let inline (-|--)
    (subjectlist: ^SubjectType array when ^SubjectType: (member as_subject: Subject_Term))
    (predicate: ^PredicateType when ^PredicateType: (member as_predicate: Predicate_Term))
    =
    subjectlist, predicate










let inline (-->=)
    (subjectlist_predicate: ^SubjectType array * ^PredicateType when ^SubjectType: (member as_subject: Subject_Term) and ^PredicateType: (member as_predicate:
                                Predicate_Term))
    object
    =
    let subjectlist, predicate = subjectlist_predicate
    ttriples subjectlist [| predicateObjectList predicate [| Literal.autotyped object |] |]

let inline (-->@)
    (subjectlist_predicate: ^SubjectType array * ^PredicateType when ^SubjectType: (member as_subject: Subject_Term) and ^PredicateType: (member as_predicate:
                                Predicate_Term))
    (lexical_form: string)
    (language_tag: Language_Tag)
    =
    let subjectlist, predicate = subjectlist_predicate
    ttriples subjectlist [| predicateObjectList predicate [| lexical_form ^@ language_tag |] |]

let inline (-->^)
    (subjectlist_predicate: ^SubjectType array * ^PredicateType when ^SubjectType: (member as_subject: Subject_Term) and ^PredicateType: (member as_predicate:
                                Predicate_Term))
    (lexical_form: string)
    (datatype: Iri)
    =
    let subjectlist, predicate = subjectlist_predicate
    ttriples subjectlist [| predicateObjectList predicate [| lexical_form ^^ datatype |] |]
let inline (->~)
    (predicate: ^PredicateType when ^PredicateType: (member as_predicate: Predicate_Term))
    (objectlist: ^ObjectType array when ^ObjectType: (member as_object: Object_Term))
    =
    predicateObjectList predicate objectlist

let inline (->~=) (predicate: ^PredicateType when ^PredicateType: (member as_predicate: Predicate_Term)) objectlist =
    predicateObjectList
        predicate
        (objectlist
         |> Array.map (fun list_item -> Literal.autotyped list_item))

let inline (->~@)
    (predicate: ^PredicateType when ^PredicateType: (member as_predicate: Predicate_Term))
    (objectlist: string array)
    (language_tag: Language_Tag)
    =
    predicateObjectList
        predicate
        (objectlist
         |> Array.map (fun lexical_form -> lexical_form ^@ language_tag))

let inline (->~^)
    (predicate: ^PredicateType when ^PredicateType: (member as_predicate: Predicate_Term))
    (objectlist: string array)
    (datatype: Iri)
    =
    predicateObjectList
        predicate
        (objectlist
         |> Array.map (fun lexical_form -> lexical_form ^^ datatype))


let inline (->-@)
    (predicate: ^PredicateType when ^PredicateType: (member as_predicate: Predicate_Term))
    (lexical_form: string)
    (language_tag: Language_Tag)
    =
    predicateObjectList predicate [| lexical_form ^@ language_tag |]

let inline (->-^)
    (predicate: ^PredicateType when ^PredicateType: (member as_predicate: Predicate_Term))
    (lexical_form: string)
    (datatype: Iri)
    =
    predicateObjectList predicate [| lexical_form ^^ datatype |]

*)








type Named_Graph =
    { name: Subject_Term option
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






















type dbug =
    static member _namespace_name = "https://eristocrates.dev/ontology/dbug/"

    static member _prefix local_name =
        NamespacedIri(dbug._namespace_name, local_name)
        |> Iri.FromNamespacedIri

    static member this_ = dbug._prefix "this"
    static member example = dbug._prefix "example"
    static member Bob = dbug._prefix "Bob"
    static member The_Mona_Lisa = dbug._prefix "The_Mona_Lisa"
    static member Alice = dbug._prefix "Alice"

    static member Charlie = dbug._prefix "Charlie"
    static member Sasha = dbug._prefix "Sasha"
    static member eris = dbug._prefix "eris"
    static member syris = dbug._prefix "syris"
    static member Leonardo_da_Vinci = dbug._prefix "Leonardo_da_Vinci"
    static member La_Joconde_a_Washington = dbug._prefix "La_Joconde_à_Washington"


(*

<Bob> <is a> <person>.
<Bob> <is a friend of> <Alice>.
<Bob> <is born on> <the 4th of July 1990>.
<Bob> <is interested in> <the Mona Lisa>.
<the Mona Lisa> <was created by> <Leonardo da Vinci>.
<the video 'La Joconde à Washington'> <is about> <the Mona Lisa>.

*)

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
-~|> [

       a ->- lib.Video
       foaf.focus ->- dbug.The_Mona_Lisa ]
|> Turtle.write_draft __SOURCE_DIRECTORY__ "test_graph"
// TODO next figure out how i fixed iri text again

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


// TODO rework lmdb?
// maybe explicitly create property graph types....

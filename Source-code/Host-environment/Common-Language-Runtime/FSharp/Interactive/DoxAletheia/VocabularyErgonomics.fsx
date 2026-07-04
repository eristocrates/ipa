fsi.ShowDeclarationValues <- false

open System
open System.IO
open System.Net.Http
open System.IO.Compression
open System.Text.RegularExpressions




#r "nuget: FSharp.Data"
open FSharp.Data

#r "nuget: FsHttp"
open FsHttp

#r "nuget: dotNetRdf"

open VDS.RDF
open VDS.RDF.Parsing
open VDS.RDF.JsonLd
open VDS.RDF.Query.Datasets
open VDS.RDF.Storage
open VDS.RDF.Parsing.Tokens
open VDS.RDF.Writing

#r "nuget: FSharp.Data"
#r "nuget: FSharp.Data.JsonSchema.Core"
#r "nuget: FSharp.Data.JsonSchema.NJsonSchema"
#r "nuget: FSharp.Data.JsonSchema.OpenApi"
#r "nuget: FSharp.Json"


open FSharp.Data
open FSharp.Data.JsonExtensions
open FSharp.Json

#r "nuget: Unquote"
open Swensen.Unquote.Assertions

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\IriPathing.fsx"
open IriPathing

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\PowershellErgonomics.fsx"
open PowershellErgonomics

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\HttpErgonomics.fsx"
open HttpErgonomics

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\FileSystemErgonomics.fsx"
open FileSystemErgonomics

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Extensions\JavascriptObjectNotationExtensions.fsx"

open JavascriptObjectNotationExtensions

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Namespace_Prefixes.fsx"
open Namespace_Prefixes







let should_overwrite = false
let global_graph = new ThreadSafeGraph()

let voaf_vocabulary =
    global_graph.CreateUriNode(UriFactory.Create("http://purl.org/vocommons/voaf#Vocabulary"))

let rdf_type =
    global_graph.CreateUriNode(UriFactory.Create("http://www.w3.org/1999/02/22-rdf-syntax-ns#type"))

let vann_preferredNamespacePrefix =
    global_graph.CreateUriNode(UriFactory.Create("http://purl.org/vocab/vann/preferredNamespacePrefix"))

let vann_preferredNamespaceUri =
    global_graph.CreateUriNode(UriFactory.Create("http://purl.org/vocab/vann/preferredNamespaceUri"))

let dcat_distribution =
    global_graph.CreateUriNode(UriFactory.Create("http://www.w3.org/ns/dcat#distribution"))

let dcat_keyword =
    global_graph.CreateUriNode(UriFactory.Create("http://www.w3.org/ns/dcat#keyword"))


let rdfs_label =
    global_graph.CreateUriNode(UriFactory.Create("http://www.w3.org/2000/01/rdf-schema#label"))

let rdfs_comment =
    global_graph.CreateUriNode(UriFactory.Create("http://www.w3.org/2000/01/rdf-schema#comment"))


[<Literal>]
let DoxAletheiaRootDirectory =
    @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia"


let VocabularyDirectory =
    ensure_path (Path.Combine(DoxAletheiaRootDirectory, "Vocabulary"))
// TODO remove extant vocabularies
(*
       "http://purl.org/spar/scoro/", "http://purl.org/spar/scoro.ttl" // "spar.scoro"
       "http://purl.org/spar/biro/", "http://purl.org/spar/biro.ttl" // "spar.biro"
       "http://purl.org/spar/c4o/", "http://purl.org/spar/c4o.ttl" // "spar.c4o"
       "http://purl.org/spar/cito/", "http://purl.org/spar/cito.ttl" // "spar.cito"
       "http://purl.org/spar/datacite/", "http://purl.org/spar/datacite.ttl" // "spar.datacite"
       "http://purl.org/spar/deo/", "http://purl.org/spar/deo.ttl" // "spar.deo"
       "http://purl.org/spar/doco/", "http://purl.org/spar/doco.ttl" // "spar.doco"
       "http://purl.org/spar/fabio/", "http://purl.org/spar/fabio.ttl" // "spar.fabio"
       "http://purl.org/spar/pro/", "http://purl.org/spar/pro.ttl" // "spar.pro"
       "http://purl.org/spar/pso/", "http://purl.org/spar/pso.ttl" // "spar.pso"
       "http://purl.org/spar/pwo/", "http://purl.org/spar/pwo.ttl" // "spar.pwo"
       "http://purl.org/dc/dcam/", "http://purl.org/dc/dcam/" // "dcmi.dcam"
       "http://purl.org/dc/dcmitype/", "http://purl.org/dc/dcmitype/" // "dcmi.dctype"
       "http://purl.org/dc/elements/1.1/", "http://purl.org/dc/elements/1.1/" // "dcmi.dc"
       "http://purl.org/dc/terms/", "http://purl.org/dc/terms/" // "dcmi.dcterms"
       "http://purl.org/goodrelations/v1#", "http://purl.org/goodrelations/v1.owl" // "gr"
       "http://purl.org/iso25964/skos-thes#", "https://www.dublincore.org/specifications/skos-thes/ns/skos-thes.ttl" // "skos.thes"
       "http://purl.org/linked-data/cube#", "http://purl.org/linked-data/cube#" // "qube"
       "http://purl.org/net/p-plan#", "http://purl.org/net/p-plan#" // "pplan"
       "http://purl.org/ontology/bibo/", "http://purl.org/ontology/bibo/" // "dcmi.bibo"
       "http://purl.org/vocab/cpsv#", "https://github.com/SEMICeu/CPSV-AP/raw/refs/heads/master/releases/3.2.0/rdf/cpsv-ap.ttl" // "semic.public.service"
       "http://purl.org/vocab/vann/", "http://purl.org/vocab/vann/" // "vann"
       "http://purl.org/vocommons/voaf#", "http://purl.org/vocommons/voaf#" // "voaf"
       "http://qudt.org/schema/qudt/", "http://qudt.org/3.1.10/schema/datatype" // "qudt-datatype"
       "http://qudt.org/schema/qudt/", "http://qudt.org/3.1.10/schema/qudt" // "qudt"
       "http://qudt.org/schema/qudt/", "http://qudt.org/3.1.10/schema/shacl/overlay/qudt" // "qudt-shacl-overlay"
       "http://qudt.org/schema/qudt/", "http://qudt.org/3.1.10/schema/shacl/qudt" // "qudt-shacl"
       "http://schema.org/", "https://datashapes.org/schema.ttl" // "schema.shacl"
       "http://semanticscience.org/resource/SIO_", "http://semanticscience.org/ontology/sio.owl" // "obo.sio"
       "http://usefulinc.com/ns/doap#", "https://lov.linkeddata.es/dataset/lov/vocabs/doap/versions/2012-01-04.n3" // "doap"
       "http://w3id.org/nfdi4ing/metadata4ing#", "http://w3id.org/nfdi4ing/metadata4ing#" // "m4i"
       "http://w3id.org/rml/", "http://w3id.org/rml/" // "rml"
       "http://www.cidoc-crm.org/cidoc-crm/", "https://cidoc-crm.org/rdfs/7.1.1/CIDOC_CRM_v7.1.1.rdf" // "cidocrm"
       "http://www.ebi.ac.uk/swo/SWO_", "http://purl.obolibrary.org/obo/swo.owl" // "obo.swo"
       "http://www.opmw.org/ontology/", "https://www.opmw.org/model/OPMW/opmw3.1.owl" // "opmw"
       "http://www.w3.org/1999/02/22-rdf-syntax-ns#", "http://www.w3.org/1999/02/22-rdf-syntax-ns#" // "rdf"
       "http://www.w3.org/2000/01/rdf-schema#", "http://www.w3.org/2000/01/rdf-schema#" // "rdfs"
       "http://www.w3.org/2000/10/swap/log#", "http://www.w3.org/2000/10/swap/log" // "swap.log"
       "http://www.w3.org/2000/10/swap/pim/contact#", "http://www.w3.org/2000/10/swap/pim/contact" // "swap.pim.contact"
       "http://www.w3.org/2002/07/owl#", "http://www.w3.org/2002/07/owl#" // "owl"
       "http://www.w3.org/2002/12/cal/ical#", "http://www.w3.org/2002/12/cal/ical#" // "ical"
       "http://www.w3.org/2004/02/skos/core#", "http://www.w3.org/2004/02/skos/core#" // "skos"
       "http://www.w3.org/2006/time#", "http://www.w3.org/2006/time#" // "time"
       "http://www.w3.org/2006/timezone#", "http://www.w3.org/2006/timezone#" // "tzont"
       "http://www.w3.org/2006/vcard/ns#", "http://www.w3.org/2006/vcard/ns#" // "vcard"
       "http://www.w3.org/ns/adms#", "http://www.w3.org/ns/adms#" // "adms"
       "http://www.w3.org/ns/csvw#", "http://www.w3.org/ns/csvw#" // "csvw"
       "http://www.w3.org/ns/dcat#", "http://www.w3.org/ns/dcat#" // "dcat"
       "http://www.w3.org/ns/dqv#", "https://www.w3.org/ns/dqv.ttl" // "dqv"
       "http://www.w3.org/ns/hydra/core#", "http://www.w3.org/ns/hydra/core#" // "hydra"
       "http://www.w3.org/ns/lemon/decomp#", "http://www.w3.org/ns/lemon/decomp#" // "ontolex.decomp"
       "http://www.w3.org/ns/lemon/frac#", "C:\Repositories\Modernization\ConsoleFsharp\ResourceDescriptionFramework\Vocabulary\Generated\http\www.w3.org\ns\lemon\frac\hash\frac.ttl" // "ontolex.frac"
       "http://www.w3.org/ns/lemon/lexicog#", "http://www.w3.org/ns/lemon/lexicog#" // "ontolex.lexicog"
       "http://www.w3.org/ns/lemon/lime#", "http://www.w3.org/ns/lemon/lime#" // "ontolex.lime"
       "http://www.w3.org/ns/lemon/ontolex#", "http://www.w3.org/ns/lemon/ontolex#" // "ontolex"
       "http://www.w3.org/ns/lemon/synsem#", "http://www.w3.org/ns/lemon/synsem#" // "ontolex.synsem"
       "http://www.w3.org/ns/lemon/vartrans#", "http://www.w3.org/ns/lemon/vartrans#" // "ontolex.vartrans"
       "http://www.w3.org/ns/locn#", "http://www.w3.org/ns/locn#" // "locn"
       "http://www.w3.org/ns/oa#", "http://www.w3.org/ns/oa#" // "oa"
       "http://www.w3.org/ns/org#", "http://www.w3.org/ns/org#" // "org"
       "http://www.w3.org/ns/pim/space#", "http://www.w3.org/ns/pim/space#" // "space"
       "http://www.w3.org/ns/prov#", "http://www.w3.org/ns/prov#" // "prov"
       "http://www.w3.org/ns/r2rml#", "http://www.w3.org/ns/r2rml#" // "r2rml"
       "http://www.w3.org/ns/solid/terms#", "http://www.w3.org/ns/solid/terms#" // "solid"
       "http://www.w3.org/ns/sosa/", "http://www.w3.org/ns/sosa/" // "sosa"
       "http://www.w3.org/ns/sparql#", "http://www.w3.org/ns/sparql#" // "sparql"
       "http://www.w3.org/ns/ssn/", "http://www.w3.org/ns/ssn/" // "ssn"
       "http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#", "http://d2rq.org/terms/d2rq.ttl" // "d2rq"
       "http://xmlns.com/foaf/0.1/", "https://lov.linkeddata.es/dataset/lov/vocabs/foaf/versions/2014-01-14.n3" // "foaf"
       "https://saref.etsi.org/core/", "https://saref.etsi.org/core/v4.1.1/saref.ttl" // "saref"
       "https://schema.org/", "https://schema.org/version/latest/schemaorg-all-https.ttl" // "schema"
       "https://w3id.org/okn/o/sd#", "https://knowledgecaptureanddiscovery.github.io/SoftwareDescriptionOntology/release/1.9.0/ontology.ttl" // "sd"
       "https://w3id.org/pko#", "https://perks-project.github.io/pk-ontology/pko/latest/pko.ttl" // "pko"
       "https://w3id.org/semapv/vocab/", "https://github.com/mapping-commons/semantic-mapping-vocabulary/raw/refs/heads/main/semapv.owl" // "semapv"
       "http://purl.obolibrary.org/obo/BFO_", "https://github.com/CommonCoreOntology/CommonCoreOntologies/raw/refs/heads/develop/src/cco-imports/bfo-core.ttl" // "obo.bfo"
       "http://purl.obolibrary.org/obo/NCIT_", "http://purl.obolibrary.org/obo/ncit.owl" // "obo.ncit"

*)



let multipart_distributions =
    [|

       "https://w3id.org/linkml/",
       [|

          "https://raw.githubusercontent.com/linkml/linkml/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/owl/meta.owl.ttl"
          "https://raw.githubusercontent.com/linkml/linkml/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/annotations.model.ttl"
          "https://raw.githubusercontent.com/linkml/linkml/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/annotations.ttl"
          "https://raw.githubusercontent.com/linkml/linkml/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/datasets.model.ttl"
          "https://raw.githubusercontent.com/linkml/linkml/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/datasets.ttl"
          "https://raw.githubusercontent.com/linkml/linkml/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/extensions.model.ttl"
          "https://raw.githubusercontent.com/linkml/linkml/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/extensions.ttl"
          "https://raw.githubusercontent.com/linkml/linkml/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/mappings.model.ttl"
          "https://raw.githubusercontent.com/linkml/linkml/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/mappings.ttl"
          "https://raw.githubusercontent.com/linkml/linkml/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/meta.model.ttl"
          "https://raw.githubusercontent.com/linkml/linkml/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/meta.ttl"
          "https://raw.githubusercontent.com/linkml/linkml/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/types.model.ttl"
          "https://raw.githubusercontent.com/linkml/linkml/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/types.ttl"
          "https://raw.githubusercontent.com/linkml/linkml/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/units.model.ttl"
          "https://raw.githubusercontent.com/linkml/linkml/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/units.ttl"
          "https://raw.githubusercontent.com/linkml/linkml/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/validation.model.ttl"
          "https://raw.githubusercontent.com/linkml/linkml/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/validation.ttl" |]

       "http://www.essepuntato.it/2008/12/earmark#",
       [| "https://essepuntato.github.io/earmark/ghost/current/ghost.owl" // "dwellonit.earmark.ghost"
          "https://essepuntato.it/earmark/shell/current/shell.owl" |] // "dwellonit.earmark.shell"
       "http://www.ontology-of-units-of-measure.org/resource/om-2/",
       [|

          "https://raw.githubusercontent.com/HajoRijgersberg/OM/refs/heads/master/om-2-ucum.ttl" // "om2-ucum"
          "https://raw.githubusercontent.com/HajoRijgersberg/OM/refs/heads/master/om-2.0.rdf" // "om2"

          |]


       "http://ns.ottr.xyz/0.4/",
       [|


          "https://spec.ottr.xyz/bOTTR/0.1.2/core-vocabulary.owl.ttl" // "ottr.bOTTR"
          "https://spec.ottr.xyz/rOTTR/0.2.0/puntypes.owl.ttl" // "ottr.rOTTR.puntypes"
          "https://spec.ottr.xyz/rOTTR/0.2.0/types.owl.ttl" // "ottr.rOTTR.types"
          "https://spec.ottr.xyz/rOTTR/0.2.0/types.shacl.ttl" // "ottr.rOTTR.shacl"
          "https://spec.ottr.xyz/wOTTR/0.4.5/core-grammar.shacl.ttl" // "ottr.wOTTR.shacl"
          "https://spec.ottr.xyz/wOTTR/0.4.5/core-vocabulary.owl.ttl" // "ottr.wOTTR"

          |]

       "http://data.europa.eu/m8g/",
       [|

          "https://github.com/SEMICeu/CCCEV/raw/refs/heads/master/releases/2.1.0/voc/cccev.ttl" // "semic.criterion_evidence"
          "https://github.com/SEMICeu/Core-Business-Vocabulary/raw/refs/heads/master/releases/2.2.0/voc/core-business-ap.ttl" // "semic.business"
          "https://github.com/SEMICeu/Core-Location-Vocabulary/raw/refs/heads/master/releases/2.1.0/voc/core-location.ttl" // "semic.location"
          "https://github.com/SEMICeu/Core-Person-Vocabulary/raw/refs/heads/master/releases/2.1.1/voc/core-person-ap.ttl" // "semic.person"
          "https://github.com/SEMICeu/Core-Public-Event-Vocabulary/raw/refs/heads/master/releases/1.1.0/voc/core-public-event.ttl" // "semic.public.event"
          "https://github.com/SEMICeu/CPOV/raw/refs/heads/master/releases/2.1.1/voc/core-public-organisation-ap.ttl" // "semic.public.organization"

          |]

       // TODO remember to try running this overnight
       (*
       "http://www.w3.org/2006/03/wn/wn20/instances/",[|

            "https://www.w3.org/2006/03/wn/wn20/instances/index.rdf"
            "https://www.w3.org/2006/03/wn/wn20/schemas/wnfull.rdfs"
            "https://www.w3.org/2006/03/wn/wn20/rdf/wordnet-synset.rdf"
            "https://www.w3.org/2006/03/wn/wn20/rdf/full/wordnet-wordsensesandwords.rdf"
            "https://www.w3.org/2006/03/wn/wn20/rdf/basic/wordnet-senselabels.rdf"
            "https://www.w3.org/2006/03/wn/wn20/rdf/wordnet-hyponym.rdf"
            "https://www.w3.org/2006/03/wn/wn20/rdf/wordnet-entailment.rdf"
            "https://www.w3.org/2006/03/wn/wn20/rdf/wordnet-similarity.rdf"
            "https://www.w3.org/2006/03/wn/wn20/rdf/wordnet-membermeronym.rdf"
            "https://www.w3.org/2006/03/wn/wn20/rdf/wordnet-substancemeronym.rdf"
            "https://www.w3.org/2006/03/wn/wn20/rdf/wordnet-partmeronym.rdf"
            "https://www.w3.org/2006/03/wn/wn20/rdf/wordnet-classifiedby.rdf"
            "https://www.w3.org/2006/03/wn/wn20/rdf/wordnet-causes.rdf"
            "https://www.w3.org/2006/03/wn/wn20/rdf/wordnet-sameverbgroupas.rdf"
            "https://www.w3.org/2006/03/wn/wn20/rdf/wordnet-attribute.rdf"
            "https://www.w3.org/2006/03/wn/wn20/rdf/full/wordnet-derivationallyrelated.rdf"
            "https://www.w3.org/2006/03/wn/wn20/rdf/full/wordnet-antonym.rdf"
            "https://www.w3.org/2006/03/wn/wn20/rdf/full/wordnet-seealso.rdf"
            "https://www.w3.org/2006/03/wn/wn20/rdf/full/wordnet-participleof.rdf"
            "https://www.w3.org/2006/03/wn/wn20/rdf/full/wordnet-pertainsto.rdf"
            "https://www.w3.org/2006/03/wn/wn20/rdf/wordnet-glossary.rdf"
            "https://www.w3.org/2006/03/wn/wn20/rdf/wordnet-frame.rdf"

       |]
*)

       |]

let manual_distributions =
    [|
       "http://kaiko.getalp.org/dbnary#", "https://kaiko.getalp.org/static/datamodel/2.1.2/ontology.ttl"
       "http://www.w3.org/2011/http-headers#", "https://www.w3.org/2011/http-headers.rdf"
       "http://www.w3.org/2011/http-methods#", "http://www.w3.org/2011/http-methods.rdf"
       "http://www.w3.org/2011/http-statusCodes#", "http://www.w3.org/2011/http-statusCodes.rdf"
       "https://www.w3.org/ns/posix/stat#", "https://www.w3.org/ns/posix/stat.rdf"
       "http://www.w3.org/2001/XMLSchema#", "https://raw.githubusercontent.com/ruby-rdf/rdf/refs/heads/develop/etc/xsd.ttl"
       "https://www.w3.org/ns/activitystreams#", "https://www.w3.org/ns/activitystreams-owl"
       "http://www.w3.org/ns/json-ld#", "https://www.w3.org/ns/json-ld.jsonld"
       "http://www.w3.org/2007/05/powder#", "https://www.w3.org/TR/2007/WD-powder-voc-20070925/wdr.rdf"
       // "http://www.w3.org/2002/12/cal/icaltzd#", "https://www.w3.org/2002/12/cal/icaltzd.rdf"
       "https://schema.org/", "https://schema.org/version/latest/schemaorg-current-https.ttl"
       "https://termlex.oeg.fi.upm.es/termlex#", "https://termlex.oeg.fi.upm.es/static/termlex.rdf"
       "https://w3id.org/function/ontology#", "https://fno.io/ontology/ontology.ttl"
       "https://w3id.org/function/vocabulary/mapping#", "https://fno.io/vocabulary/mapping/0.2.1/ontology.ttl"
       "https://w3id.org/function/vocabulary/implementation#", "https://fno.io/vocabulary/implementation/0.1.1/ontology.ttl"
       "https://w3id.org/function/vocabulary/composition#", "https://fno.io/vocabulary/composition/0.1.0/ontology.ttl"
       "http://www.w3.org/ns/shacl-shacl#", "https://www.w3.org/ns/shacl-shacl.ttl"
       "http://www.w3.org/ns/shex#", "https://www.w3.org/ns/shex.ttl"
       "http://aims.fao.org/aos/agrontology#", "http://aims.fao.org/aos/agrontology" // "agrontology"
       "http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#", "http://www.semanticdesktop.org/ontologies/2007/03/22/nmo/nmo.trig" // "nepomuk.nmo.v1"
       "http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#", "http://www.semanticdesktop.org/ontologies/2007/05/10/nexif/nexif.trig" // "nepomuk.nexif.v1"
       "http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#", "http://www.semanticdesktop.org/ontologies/2007/05/10/nid3/nid3.trig" // "nepomuk.nid3.v1"
       "http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#", "http://www.semanticdesktop.org/ontologies/2007/11/01/pimo/pimo.trig" // "nepomuk.pimo.v1"
       "http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#", "http://www.semanticdesktop.org/ontologies/2008/05/20/tmo/v1.1/tmo.trig" // "nepomuk.tmo.v1"
       "http://tracker.api.gnome.org/ontology/v3/nrl#", "https://github.com/GNOME/tinysparql/raw/refs/heads/main/src/ontologies/12-nrl.ontology"
       "http://tracker.api.gnome.org/ontology/v3/nie#", "https://github.com/GNOME/tinysparql/raw/refs/heads/main/src/ontologies/nepomuk/30-nie.ontology"
       "http://tracker.api.gnome.org/ontology/v3/nao#", "https://github.com/GNOME/tinysparql/raw/refs/heads/main/src/ontologies/nepomuk/31-nao.ontology"
       "http://tracker.api.gnome.org/ontology/v3/nco#", "https://github.com/GNOME/tinysparql/raw/refs/heads/main/src/ontologies/nepomuk/32-nco.ontology"
       "http://tracker.api.gnome.org/ontology/v3/nfo#", "https://github.com/GNOME/tinysparql/raw/refs/heads/main/src/ontologies/nepomuk/33-nfo.ontology"
       "http://tracker.api.gnome.org/ontology/v3/nmm#", "https://github.com/GNOME/tinysparql/raw/refs/heads/main/src/ontologies/nepomuk/38-nmm.ontology"
       "http://tracker.api.gnome.org/ontology/v3/mfo#", "https://github.com/GNOME/tinysparql/raw/refs/heads/main/src/ontologies/nepomuk/41-mfo.ontology"
       "http://tracker.api.gnome.org/ontology/v3/tracker#", "https://github.com/GNOME/tinysparql/raw/refs/heads/main/src/ontologies/nepomuk/90-tracker.ontology"
       "http://tracker.api.gnome.org/ontology/v3/slo#", "https://github.com/GNOME/tinysparql/raw/refs/heads/main/src/ontologies/nepomuk/92-slo.ontology"
       "http://tracker.api.gnome.org/ontology/v3/osinfo#", "https://github.com/GNOME/tinysparql/raw/refs/heads/main/src/ontologies/nepomuk/93-libosinfo.ontology"
       "http://datashapes.org/dash#", "https://datashapes.org/dash.ttl" // "dash"
       "http://eulersharp.sourceforge.net/2003/03swap/agent#", "http://eulersharp.sourceforge.net/2003/03swap/agent" // "swap.agent"
       "http://eulersharp.sourceforge.net/2003/03swap/bioSKOSSchemes#", "http://eulersharp.sourceforge.net/2003/03swap/bioSKOSSchemes" // "swap.bioSKOSSchemes"
       "http://eulersharp.sourceforge.net/2003/03swap/care#", "http://eulersharp.sourceforge.net/2003/03swap/care" // "swap.care"
       "http://eulersharp.sourceforge.net/2003/03swap/coding#", "http://eulersharp.sourceforge.net/2003/03swap/coding" // "swap.coding"
       "http://eulersharp.sourceforge.net/2003/03swap/computer#", "http://eulersharp.sourceforge.net/2003/03swap/computer" // "swap.computer"
       "http://eulersharp.sourceforge.net/2003/03swap/countries#", "http://eulersharp.sourceforge.net/2003/03swap/countries" // "swap.countries"
       "http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#", "http://eulersharp.sourceforge.net/2003/03swap/decisionSupport" // "swap.decisionSupport"
       "http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#", "http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure" // "swap.digitalProcedure"
       "http://eulersharp.sourceforge.net/2003/03swap/document#", "http://eulersharp.sourceforge.net/2003/03swap/document" // "swap.document"
       "http://eulersharp.sourceforge.net/2003/03swap/environment#", "http://eulersharp.sourceforge.net/2003/03swap/environment" // "swap.environment"
       "http://eulersharp.sourceforge.net/2003/03swap/event#", "http://eulersharp.sourceforge.net/2003/03swap/event" // "swap.event"
       "http://eulersharp.sourceforge.net/2003/03swap/foster#", "http://eulersharp.sourceforge.net/2003/03swap/foster" // "swap.foster"
       "http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#", "http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality" // "swap.genomeAbnormality"
       "http://eulersharp.sourceforge.net/2003/03swap/human#", "http://eulersharp.sourceforge.net/2003/03swap/human" // "swap.human"
       "http://eulersharp.sourceforge.net/2003/03swap/humanBody#", "http://eulersharp.sourceforge.net/2003/03swap/humanBody" // "swap.humanBody"
       "http://eulersharp.sourceforge.net/2003/03swap/languages#", "http://eulersharp.sourceforge.net/2003/03swap/languages" // "swap.languages"
       "http://eulersharp.sourceforge.net/2003/03swap/organism#", "http://eulersharp.sourceforge.net/2003/03swap/organism" // "swap.organism"
       "http://eulersharp.sourceforge.net/2003/03swap/organization#", "http://eulersharp.sourceforge.net/2003/03swap/organization" // "swap.organization"
       "http://eulersharp.sourceforge.net/2003/03swap/physicalResource#", "http://eulersharp.sourceforge.net/2003/03swap/physicalResource" // "swap.physicalResource"
       "http://eulersharp.sourceforge.net/2003/03swap/quantities#", "http://eulersharp.sourceforge.net/2003/03swap/quantities" // "swap.quantities"
       "http://eulersharp.sourceforge.net/2003/03swap/space#", "http://eulersharp.sourceforge.net/2003/03swap/space" // "swap.space"
       "http://eulersharp.sourceforge.net/2003/03swap/sparql#", "http://eulersharp.sourceforge.net/2003/03swap/sparql" // "swap.sparql"
       "http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#", "http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis" // "swap.sparqlAnalysis"
       "http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysisTemplate#", "http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysisTemplate" // "swap.sparqlAnalysisTemplate"
       "http://eulersharp.sourceforge.net/2003/03swap/substanceForms#", "http://eulersharp.sourceforge.net/2003/03swap/substanceForms" // "swap.substanceForms"
       "http://eulersharp.sourceforge.net/2003/03swap/time#", "http://eulersharp.sourceforge.net/2003/03swap/time" // "swap.time"
       "http://eulersharp.sourceforge.net/2003/03swap/units#", "http://eulersharp.sourceforge.net/2003/03swap/units" // "swap.units"
       "http://eulersharp.sourceforge.net/2003/03swap/weekScheme#", "http://eulersharp.sourceforge.net/2003/03swap/weekScheme" // "swap.weekScheme"
       "http://eulersharp.sourceforge.net/2003/03swap/workflow#", "http://eulersharp.sourceforge.net/2003/03swap/workflow" // "swap.workflow"
       // "http://example.org/dctap#", "https://github.com/dcmi/dctap/raw/refs/heads/main/dctap.ttl" // "dcmi.dctap"
       "http://id.loc.gov/ontologies/bflc/", "https://id.loc.gov/ontologies/bflc.rdf"
       // "http://id.loc.gov/ontologies/bibframe/", "https://github.com/lcnetdev/bibframe-ontology/raw/refs/heads/main/bibframe.rdf" // "loc.bibframe"
       "http://open-services.net/ns/am#", "https://docs.oasis-open-projects.org/oslc-op/am/v3.0/os/architecture-management-vocab.ttl" // "oasis.oslc.am"
       "http://open-services.net/ns/auto#", "https://docs.oasis-open-projects.org/oslc-op/auto/v2.1/psd01/automation-vocab.ttl" // "oasis.oslc.auto"
       "http://open-services.net/ns/cm#", "https://docs.oasis-open-projects.org/oslc-op/cm/v3.0/errata01/os/change-mgt-vocab.ttl" // "oasis.oslc.cm"
       "http://open-services.net/ns/config#", "https://docs.oasis-open-projects.org/oslc-op/config/v1.1/psd01/config-vocab.ttl" // "oasis.oslc.config"
       "http://open-services.net/ns/core/trs#", "https://docs.oasis-open-projects.org/oslc-op/trs/v3.0/os/trs-vocab.ttl" // "oasis.oslc.trs"
       "http://open-services.net/ns/core/trspatch#", "https://docs.oasis-open-projects.org/oslc-op/trs/v3.0/os/trs-vocab.ttl" // "oasis.oslc.trs.patch"
       "http://open-services.net/ns/qm#", "https://docs.oasis-open-projects.org/oslc-op/qm/v2.1/os/quality-management-vocab.ttl" // "oasis.oslc.qm"
       "http://open-services.net/ns/rm#", "https://docs.oasis-open-projects.org/oslc-op/rm/v2.1/os/requirements-management-vocab.ttl" // "oasis.oslc.rm"
       "http://open-services.net/ns/sysmlv2#", "https://docs.oasis-open-projects.org/oslc-op/sysml/v2.0/psd01/sysml-vocab.ttl" // "oasis.oslc.sysml"
       "http://openprovenance.org/model/opmo#", "https://openprovenance.org/opm/model/opmo-20101012.owl" // "opmo"
       "http://purl.org/ontology/olo/core#", "https://github.com/smiy/orderedlistonto/raw/refs/heads/master/rdf/orderedlistontology.n3" // "olo"
       "http://purl.org/spar/bido/", "http://purl.org/spar/bido.ttl" // "spar.bido"
       "http://purl.org/spar/fivestars/", "http://purl.org/spar/fivestars.ttl" // "spar.fivestars"
       "http://purl.org/spar/fr/", "http://purl.org/spar/fr.ttl" // "spar.fr"
       "http://purl.org/spar/frbr/", "http://purl.org/spar/frbr.ttl" // "spar.frbr"
       "http://purl.org/spar/mito/", "http://purl.org/spar/mito.ttl" // "spar.mito"
       "http://purl.org/cerif/frapo/", "http://purl.org/spar/frapo.ttl" // "spar.frapo"
       "http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#", "http://www.daml.org/services/owl-s/1.2/ActorDefault.owl" // "owl_s.ActorDefault"
       "http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#", "http://www.daml.org/services/owl-s/1.2/generic/Expression.owl" // "owl_s.Expression"
       "http://www.daml.org/services/owl-s/1.2/generic/ObjectList.owl#", "http://www.daml.org/services/owl-s/1.2/generic/ObjectList.owl" // "owl_s.ObjectList"
       "http://www.daml.org/services/owl-s/1.2/Grounding.owl#", "http://www.daml.org/services/owl-s/1.2/Grounding.owl" // "owl_s.Grounding"
       "http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl", "http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl" // "owl_s.GroundingDeprecatedElements"
       "http://www.daml.org/services/owl-s/1.2/Process.owl", "http://www.daml.org/services/owl-s/1.2/ProcessDeprecatedElements.owl" // "owl_s.ProcessDeprecatedElements"
       "http://www.daml.org/services/owl-s/1.2/Process.owl#", "http://www.daml.org/services/owl-s/1.2/Process.owl" // "owl_s.Process"
       "http://www.daml.org/services/owl-s/1.2/Profile.owl#", "http://www.daml.org/services/owl-s/1.2/Profile.owl" // "owl_s.Profile"
       "http://www.daml.org/services/owl-s/1.2/ProfileAdditionalParameters.owl#", "http://www.daml.org/services/owl-s/1.2/ProfileAdditionalParameters.owl" // "owl_s.Profile.AdditionalParameters"
       "http://www.daml.org/services/owl-s/1.2/Resource.owl#", "http://www.daml.org/services/owl-s/1.2/Resource.owl" // "owl_s.Resource"
       "http://www.daml.org/services/owl-s/1.2/Service.owl#", "https://www.daml.org/services/owl-s/1.2/Service.owl" // "owl_s.Service"
       "http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#", "https://github.com/iddi/sofia/raw/refs/heads/master/eu.sofia.adk.common/ontologies/foundational/DOLCE-Lite.owl" // "dolce.lite"
       "http://www.loc.gov/premis/rdf/v3/", "https://github.com/lcnetdev/PREMIS/raw/refs/heads/master/premis3.owl" // "loc.premis"
       "http://www.lexinfo.net/ontology/3.0/lexinfo#", "http://www.lexinfo.net/ontology/3.0/lexinfo.ttl" // "ontolex.lexinfo"
       "http://www.w3.org/2000/10/swap/crypto#", "http://www.w3.org/2000/10/swap/crypto" // "swap.crypto"
       "http://www.w3.org/2000/10/swap/grammar/bnf#", "http://www.w3.org/2000/10/swap/grammar/bnf" // "swap.grammar.bnf"
       "http://www.w3.org/2000/10/swap/list#", "http://www.w3.org/2000/10/swap/list" // "swap.list"
       "http://www.w3.org/2000/10/swap/math#", "http://www.w3.org/2000/10/swap/math" // "swap.math"
       "http://www.w3.org/2000/10/swap/os#", "http://www.w3.org/2000/10/swap/os" // "swap.os"
       "http://www.w3.org/2000/10/swap/pim/doc#", "http://www.w3.org/2000/10/swap/pim/doc" // "swap.pim.doc"
       "http://www.w3.org/2000/10/swap/pim/email#", "http://www.w3.org/2000/10/swap/pim/email" // "swap.pim.email"
       "http://www.w3.org/2000/10/swap/pim/ical#", "http://www.w3.org/2000/10/swap/pim/ical" // "swap.pim.ical"
       "http://www.w3.org/2000/10/swap/pim/qif#", "http://www.w3.org/2000/10/swap/pim/qif" // "swap.pim.qif"
       "http://www.w3.org/2000/10/swap/pim/travelFig#", "http://www.w3.org/2000/10/swap/pim/travelFig" // "swap.pim.travelFig"
       "http://www.w3.org/2000/10/swap/pim/travelTerms#", "http://www.w3.org/2000/10/swap/pim/travelTerms" // "swap.pim.travelTerms"
       "http://www.w3.org/2000/10/swap/pim/usps#", "http://www.w3.org/2000/10/swap/pim/usps" // "swap.pim.usps"
       "http://www.w3.org/2000/10/swap/reason#", "http://www.w3.org/2000/10/swap/reason" // "swap.reason"
       "http://www.w3.org/2000/10/swap/set#", "http://www.w3.org/2000/10/swap/set" // "swap.set"
       "http://www.w3.org/2000/10/swap/string#", "http://www.w3.org/2000/10/swap/string" // "swap.string"
       "http://www.w3.org/2004/06/rei#", "http://www.w3.org/2004/06/rei#" // "rei"
       "http://www.w3.org/ns/solid/acp#", "http://www.w3.org/ns/solid/acp#" // "acp"
       "http://www.w3.org/ns/solid/interop#", "http://www.w3.org/ns/solid/interop#" // "interop"
       "http://www.w3.org/ns/solid/notifications#", "http://www.w3.org/ns/solid/notifications#" // "notify"
       "http://www.w3.org/ns/solid/oidc#", "http://www.w3.org/ns/solid/oidc#" // "oidc"
       "http://www.w3.org/ns/spec#", "http://www.w3.org/ns/spec#" // "spec"
       "https://globalwordnet.github.io/schemas/wn#", "https://www.w3.org/2006/03/wn/wn20/schemas/wnfull.rdfs" // "wordnet.wn"
       "https://ns.dublincore.org/openwemi/", "https://dcmi.github.io/openwemi/ns/openWEMI.ttl" // "dcmi.openwemi"
       // "https://purl.org/heals/eo#", "https://raw.githubusercontent.com/tetherless-world/explanation-ontology/master/Ontologies/v2/explanation-ontology.owl" // "eo"
       "https://spdx.org/rdf/3.1/terms/", "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl" // "spdx3"
       "http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#", "https://github.com/iddi/sofia/raw/refs/heads/master/eu.sofia.adk.common/ontologies/foundational/ExtendedDnS.owl" // "dns"
       // "http://www.opengis.net/ont/geosparql#", "http://www.opengis.net/ont/geosparql#" // "opengis.geosparql"
       "http://www.opengis.net/ont/sf#", "http://www.opengis.net/ont/sf#" // "opengis.sf"
       "http://www.essepuntato.it/2008/12/pattern#", "https://sourceforge.net/p/dwellonit/code/HEAD/tree/StructuralPattern/pattern.owl?format=raw" // "dwellonit.pattern"
       // "http://www.essepuntato.it/2011/02/argumentmodel/", "https://sourceforge.net/p/dwellonit/code/HEAD/tree/ArgumentModel/argumentmodel.owl?format=raw" // "dwellonit.arg"
       "http://www.essepuntato.it/2012/04/tvc/", "https://sourceforge.net/p/dwellonit/code/HEAD/tree/TimeIndexedValueInContext/tvc.owl?format=raw" // "dwellonit.tvc"
       "http://www.essepuntato.it/2013/10/vagueness/", "https://sourceforge.net/p/dwellonit/code/HEAD/tree/VaguenessOntology/model.owl?format=raw" // "dwellonit.vag"
       "http://qudt.org/vocab/constant/", "http://qudt.org/3.1.10/vocab/constant" // "qudt-constant"
       "http://qudt.org/vocab/dimensionvector", "http://qudt.org/3.1.10/vocab/dimensionvector" // "qudt-dimensionvector"
       "http://qudt.org/vocab/quantitykind", "http://qudt.org/3.1.10/vocab/quantitykind" // "qudt-quantitykind"
       "http://qudt.org/vocab/soqk", "http://qudt.org/3.1.10/vocab/soqk" // "qudt-system-quantitykind"
       "http://purl.org/swan/2.0/", "https://rawcdn.githack.com/pav-ontology/swan-ontology/2.0.1/swan.owl" // "swan"
       "http://purl.org/swan/2.0/collections/", "https://rawcdn.githack.com/pav-ontology/swan-ontology/2.0.1/collections.owl" // "swan.collections"
       "http://purl.org/swan/2.0/discourse-elements/", "https://rawcdn.githack.com/pav-ontology/swan-ontology/2.0.1/discourse-elements.owl" // "swan.discourse.elements"
       "http://purl.org/swan/2.0/discourse-relationships/", "https://rawcdn.githack.com/pav-ontology/swan-ontology/2.0.1/discourse-relationships.owl" // "swan.discourse.relationships"
       "http://purl.org/swan/2.0/experiment", "https://rawcdn.githack.com/pav-ontology/swan-ontology/2.0.1/experiments.owl" // "swan.experiments"
       "http://purl.org/dcx/lrmi-terms/", "http://dublincore.org/specifications/lrmi/lrmi_terms/2022-06-14/lrmi-terms.ttl" // "dcmi.lrmi"
       "http://purl.org/dcx/lrmi-vocabs/alignmentType/", "http://dublincore.org/vocabs/alignmentType.ttl" // "dcmi.lrmi.alignment"
       "http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/", "http://dublincore.org/vocabs/educationalAudienceRole.ttl" // "dcmi.lrmi.audRole"
       "http://purl.org/dcx/lrmi-vocabs/educationalUse/", "	http://dublincore.org/vocabs/educationalUse.ttl" // "dcmi.lrmi.edUse"
       "http://purl.org/dcx/lrmi-vocabs/interactivityType/", "http://dublincore.org/vocabs/interactivityType.ttl" // "dcmi.lrmi.interact"
       "http://purl.org/dcx/lrmi-vocabs/learningResourceType/", "https://www.dublincore.org/vocabs/learningResourceType.ttl" // "dcmi.lrmi.resourceType"
       "http://www.w3.org/2006/03/wn/wn20/schema/", "https://www.w3.org/2006/03/wn/wn20/schemas/wnfull.rdfs"
       "https://www.commoncoreontologies.org/", "https://github.com/CommonCoreOntology/CommonCoreOntologies/raw/refs/heads/develop/src/cco-merged/CommonCoreOntologiesMerged.ttl"
       "https://www.commoncoreontologies.org/BarcodeOntology/", "https://github.com/CommonCoreOntology/CommonCoreOntologies/raw/refs/heads/develop/src/cco-extensions/BarcodeOntology.ttl"
       "https://www.commoncoreontologies.org/FamilialRelationsOntology", "https://github.com/CommonCoreOntology/CommonCoreOntologies/raw/refs/heads/develop/src/cco-extensions/FamilialRelationsOntology.ttl"
       // "https://www.commoncoreontologies.org/mro/", "https://github.com/CommonCoreOntology/CommonCoreOntologies/raw/refs/heads/develop/src/cco-extensions/ModalRelationOntology.ttl" // "cco.mro"
       "https://open-metadata.org/ontology/", "https://github.com/open-metadata/OpenMetadataStandards/raw/refs/heads/main/rdf/ontology/openmetadata.ttl"



       |]


manual_distributions
|> Array.Parallel.groupBy (fun (namespace_name, namespace_distribution) -> namespace_name)
|> Array.Parallel.filter (fun (namespace_name, distributions) -> distributions.Length > 1)












module prefixcc =
    [<Literal>]
    let filePath =
        @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\prefix.cc.json"

    let json = JsonProvider<filePath>.Load filePath

let decompress_gzip_file (source_path: string) (destination_path: string) =
    use source_stream = File.OpenRead(source_path)

    use gzip_stream = new GZipStream(source_stream, CompressionMode.Decompress)

    use destination_stream = File.Create(destination_path)

    gzip_stream.CopyTo(destination_stream)



let private is_high_surrogate_code_unit value = value >= 0xD800 && value <= 0xDBFF

let private is_low_surrogate_code_unit value = value >= 0xDC00 && value <= 0xDFFF

let private surrogate_pair_to_code_point high low =
    0x10000
    + ((high - 0xD800) <<< 10)
    + (low - 0xDC00)

let normalize_escaped_surrogate_pairs (text: string) =
    Regex.Replace(
        text,
        @"\\u([dD][89aAbB][0-9a-fA-F]{2})\\u([dD][c-fC-F][0-9a-fA-F]{2})",
        MatchEvaluator (fun m ->
            let high = Convert.ToInt32(m.Groups.[1].Value, 16)
            let low = Convert.ToInt32(m.Groups.[2].Value, 16)

            if is_high_surrogate_code_unit high
               && is_low_surrogate_code_unit low then
                let code_point = surrogate_pair_to_code_point high low
                sprintf "\\U%08X" code_point
            else
                m.Value)
    )



module Turtle =


    let writer =
        let writer = new CompressingTurtleWriter(TurtleSyntax.Rdf11Star)
        writer.HighSpeedModePermitted <- false
        writer.PrettyPrintMode <- true
        writer

    let write (file_path: string) (graph: VDS.RDF.IGraph) = writer.Save(graph, file_path)

// TODO move these to NQuads module
let normalize_nquads_file (source_path: string) (destination_path: string) =
    use reader = new StreamReader(source_path)

    use writer = new StreamWriter(destination_path, false, System.Text.Encoding.UTF8)

    while not reader.EndOfStream do
        let line = reader.ReadLine()
        let normalized_line = normalize_escaped_surrogate_pairs line
        writer.WriteLine(normalized_line)


let find_first_bad_nquad_line (path: string) =
    let parser = NQuadsParser()

    use reader = new StreamReader(path)

    let mutable line_number = 0
    let mutable result: (int * string * string) option = None

    while result.IsNone && not reader.EndOfStream do
        line_number <- line_number + 1

        let line = reader.ReadLine()

        if not (String.IsNullOrWhiteSpace line) then
            try
                let store = new TripleStore()
                use line_reader = new StringReader(line)
                parser.Load(store, line_reader)
            with
            | err -> result <- Some(line_number, err.Message, line)

    result

let write_valid_nquads_only (source_path: string) (destination_path: string) =
    let parser = NQuadsParser()

    use reader = new StreamReader(source_path)
    use writer = new StreamWriter(destination_path, false, System.Text.Encoding.UTF8)

    use error_writer =
        new StreamWriter(destination_path + ".errors.txt", false, System.Text.Encoding.UTF8)

    let mutable line_number = 0
    let mutable kept = 0
    let mutable rejected = 0

    while not reader.EndOfStream do
        line_number <- line_number + 1
        let line = reader.ReadLine()

        if not (String.IsNullOrWhiteSpace line) then
            try
                let store = new TripleStore()
                use line_reader = new StringReader(line)
                parser.Load(store, line_reader)

                writer.WriteLine(line)
                kept <- kept + 1
            with
            | err ->
                rejected <- rejected + 1
                error_writer.WriteLine($"LINE {line_number}")
                error_writer.WriteLine(err.Message)
                error_writer.WriteLine(line)
                error_writer.WriteLine()

    printfn "Kept %i lines; rejected %i lines." kept rejected






module lov =
    type Meta = { last_meta: DateTimeOffset }

    let v2Base = "https://lov.linkeddata.es/dataset/lov/api/v2"

    let excluded_graph_names =
        set [

              "http://lov_server:3333/dataset/lov"

               ]

    module vocabulary =
        [<Literal>]
        let filePath =
            @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\lov.vocabulary.json"

        let json = JsonProvider<filePath>.Load filePath

        [<Literal>]
        let list_path =
            @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\lov.vocabulary.json"

        let get_list () =
            download_remote_to_local $"{v2Base}/vocabulary/list" list_path

    module dump =
        module n3 =

            [<Literal>]
            let gz_path =
                @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\lov.n3.gz"

            let file_path = gz_path.Replace(".gz", "")

            let gz () =
                http {
                    GET $"https://lov.linkeddata.es/lov.n3.gz"

                }
                |> Request.send

            [<Literal>]
            let meta_file_path =
                @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\lov.n3.meta.json"

            let refresh () =
                let response = gz ()
                if response.originalHttpResponseMessage.IsSuccessStatusCode then
                    Response.saveFile gz_path response
                    decompress_gzip_file gz_path file_path
                    let last_meta = { last_meta = DateTimeOffset.Now }
                    let meta_file_content = Json.serialize last_meta
                    File.WriteAllText(meta_file_path, meta_file_content)

            let json = JsonProvider<meta_file_path>.Load meta_file_path

            if json.LastMeta.Date < DateTime.Now.Date then
                refresh ()

            let graph = new ThreadSafeGraph()
            FileLoader.Load(graph, file_path)

            let vocabularies =

                graph.GetTriplesWithPredicateObject(rdf_type, voaf_vocabulary)
                |> Seq.toArray
                |> Array.Parallel.map (fun vocabulary_triple -> vocabulary_triple.Subject :?> UriNode)


            let vocabulary'preferredNamespaceUri =

                vocabularies
                |> Array.Parallel.collect (fun vocabulary ->
                    graph.GetTriplesWithSubjectPredicate(vocabulary, vann_preferredNamespaceUri)
                    |> Seq.toArray
                    |> Array.Parallel.map (fun preferred_uri_triple ->
                        let preferred_namespace = preferred_uri_triple.Object :?> LiteralNode
                        (vocabulary, preferred_namespace)

                    )

                )

            let vocabulary'preferredNamespaceUri'preferredNamespacePrefixes =
                vocabulary'preferredNamespaceUri
                |> Array.Parallel.collect (fun (vocabulary, preferred_namespace) ->
                    graph.GetTriplesWithSubjectPredicate(vocabulary, vann_preferredNamespacePrefix)
                    |> Seq.toArray
                    |> Array.Parallel.map (fun preferred_prefix_triple ->

                        let preferred_prefix = preferred_prefix_triple.Object :?> LiteralNode
                        (vocabulary, preferred_namespace, preferred_prefix)

                    )

                )


            let vocabulary'preferredNamespaceUri'preferredNamespacePrefixes'distribution =
                vocabulary'preferredNamespaceUri'preferredNamespacePrefixes

                |> Array.Parallel.collect (fun (vocabulary, preferred_namespace, preferred_prefix) ->
                    graph.GetTriplesWithSubjectPredicate(vocabulary, dcat_distribution)
                    |> Seq.toArray
                    |> Array.Parallel.filter (fun distribution_triple -> distribution_triple.Object.NodeType = NodeType.Uri)
                    |> Array.Parallel.map (fun distribution_triple ->

                        let distribution = distribution_triple.Object :?> UriNode
                        (vocabulary, preferred_namespace, preferred_prefix, distribution)

                    )

                )



        module nq =

            [<Literal>]
            let gz_path =
                @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\lov.nq.gz"

            let file_path = gz_path.Replace(".gz", "")
            let normalized_path = Path.ChangeExtension(file_path, ".normalized.nq")
            let cleaned_path = Path.ChangeExtension(normalized_path, ".cleaned.nq")

            let gz () =
                http {
                    GET $"https://lov.linkeddata.es/lov.nq.gz"

                }
                |> Request.send


            [<Literal>]
            let meta_file_path =
                @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\lov.nq.meta.json"

            let refresh () =
                let response = gz ()
                if response.originalHttpResponseMessage.IsSuccessStatusCode then
                    Response.saveFile gz_path response
                    decompress_gzip_file gz_path file_path
                    normalize_nquads_file file_path normalized_path
                    write_valid_nquads_only normalized_path cleaned_path
                    let last_meta = { last_meta = DateTimeOffset.Now }
                    let meta_file_content = Json.serialize last_meta
                    File.WriteAllText(meta_file_path, meta_file_content)

            let json = JsonProvider<meta_file_path>.Load meta_file_path

            if json.LastMeta.Date < DateTime.Now.Date then
                refresh ()

            let dataset = new DatasetFileManager(cleaned_path, false)

            let graph_names =
                dataset.ListGraphNames()
                |> Seq.toArray
                |> Array.Parallel.choose (fun graph_name ->

                    if excluded_graph_names.Contains(graph_name) then
                        None
                    else
                        Some graph_name


                )








    module Lov_Keyword =
        let API = dump.n3.graph.CreateLiteralNode("API")
        let Academy = dump.n3.graph.CreateLiteralNode("Academy")
        let Biology = dump.n3.graph.CreateLiteralNode("Biology")
        let CSV = dump.n3.graph.CreateLiteralNode("CSV")
        let Catalogs = dump.n3.graph.CreateLiteralNode("Catalogs")
        let Contracts = dump.n3.graph.CreateLiteralNode("Contracts")
        let Environment = dump.n3.graph.CreateLiteralNode("Environment")
        let Events = dump.n3.graph.CreateLiteralNode("Events")
        let FRBR = dump.n3.graph.CreateLiteralNode("FRBR")
        let Food = dump.n3.graph.CreateLiteralNode("Food")
        let Games = dump.n3.graph.CreateLiteralNode("Games")
        let General_and_Upper = dump.n3.graph.CreateLiteralNode("General & Upper")
        let Geography = dump.n3.graph.CreateLiteralNode("Geography")
        let Geometry = dump.n3.graph.CreateLiteralNode("Geometry")
        let Government = dump.n3.graph.CreateLiteralNode("Government")
        let Health = dump.n3.graph.CreateLiteralNode("Health")
        let Image = dump.n3.graph.CreateLiteralNode("Image")
        let Industry = dump.n3.graph.CreateLiteralNode("Industry")
        let IoT = dump.n3.graph.CreateLiteralNode("IoT")
        let Metadata = dump.n3.graph.CreateLiteralNode("Metadata")
        let Methods = dump.n3.graph.CreateLiteralNode("Methods")
        let Multimedia = dump.n3.graph.CreateLiteralNode("Multimedia")
        let Music = dump.n3.graph.CreateLiteralNode("Music")
        let PLM = dump.n3.graph.CreateLiteralNode("PLM")
        let PROTON = dump.n3.graph.CreateLiteralNode("PROTON")
        let People = dump.n3.graph.CreateLiteralNode("People")
        let Press = dump.n3.graph.CreateLiteralNode("Press")
        let Quality = dump.n3.graph.CreateLiteralNode("Quality")
        let RDF = dump.n3.graph.CreateLiteralNode("RDF")
        let Rec = dump.n3.graph.CreateLiteralNode("Rec")
        let SPAR = dump.n3.graph.CreateLiteralNode("SPAR")
        let SSDesk = dump.n3.graph.CreateLiteralNode("SSDesk")
        let Security = dump.n3.graph.CreateLiteralNode("Security")
        let Services = dump.n3.graph.CreateLiteralNode("Services")
        let Society = dump.n3.graph.CreateLiteralNode("Society")
        let Support = dump.n3.graph.CreateLiteralNode("Support")
        let Tag = dump.n3.graph.CreateLiteralNode("Tag")
        let Time = dump.n3.graph.CreateLiteralNode("Time")
        let Transport = dump.n3.graph.CreateLiteralNode("Transport")
        let Travel = dump.n3.graph.CreateLiteralNode("Travel")
        let Vocabularies = dump.n3.graph.CreateLiteralNode("Vocabularies")
        let W3CRec = dump.n3.graph.CreateLiteralNode("W3CRec")
        let eBusiness = dump.n3.graph.CreateLiteralNode("eBusiness")

        let _search (keyword: ILiteralNode) =
            dump.n3.graph.GetTriplesWithPredicateObject(dcat_keyword, keyword)
            |> Seq.toArray
            |> Array.Parallel.map (fun keyword_triple -> keyword_triple.Subject :?> UriNode)





let label_from_namespaceIriString (namespaceIriString: string) =

    let label_from_prefixcc =
        prefixcc.json.JsonValue.Properties
        |> Array.Parallel.tryPick (fun (jsonKey, jsonValue) ->

            if (jsonValue.AsString() = namespaceIriString) then
                Some(jsonKey)
            else
                None)

    match label_from_prefixcc with
    | _ when label_from_prefixcc.IsNone ->
        let label_from_lov =
            lov.vocabulary.json
            |> Array.Parallel.tryPick (fun vocabulary ->

                if vocabulary.Nsp = namespaceIriString then
                    Some(vocabulary.Prefix)
                else
                    None

            )

        label_from_lov

    | _ -> label_from_prefixcc



let namespace_directory_path_from_namespace_name namespace_name =
    ensure_path (Path.Combine(VocabularyDirectory, iriToRelativePath namespace_name))




let is_terminal_delimited (iri_string: string) =
    iri_string.EndsWith('#')
    || iri_string.EndsWith('/')

let is_not_terminal_delimited (iri_string: string) =
    not (iri_string |> is_terminal_delimited)


let absolute_graph_names =
    lov.dump.nq.graph_names
    |> Array.Parallel.filter (fun graph_name -> graph_name |> is_not_terminal_delimited)


(*


let namespace_names_by_graph_node =
    lov.dump.n3.vocabulary'preferredNamespaceUri'preferredNamespacePrefixes'distribution
    |> Array.Parallel.filter (fun (graph_node, preferredNamespaceUri, preferredNamespacePrefixes, distribution) ->
        lov.dump.nq.graph_names
        |> Array.Parallel.exists (fun graph_name -> graph_node.Uri.OriginalString = graph_name)

    )
    |> Array.Parallel.map (fun (graph_node, preferredNamespaceUri, preferredNamespacePrefixes, distribution) ->
        preferredNamespaceUri.Value)
    |> Array.distinct
    |> Array.sort

let namespace_names_by_preffered_namespace_uri =
    lov.dump.n3.vocabulary'preferredNamespaceUri'preferredNamespacePrefixes'distribution
    |> Array.Parallel.filter (fun (graph_node, preferredNamespaceUri, preferredNamespacePrefixes, distribution) ->
        lov.dump.nq.graph_names
        |> Array.Parallel.exists (fun graph_name -> preferredNamespaceUri.Value = graph_name)

    )
    |> Array.Parallel.map (fun (graph_node, preferredNamespaceUri, preferredNamespacePrefixes, distribution) ->
        preferredNamespaceUri.Value)
    |> Array.distinct
    |> Array.sort

let graph_names_without_namespace =
    lov.dump.n3.vocabulary'preferredNamespaceUri'preferredNamespacePrefixes'distribution
    |> Array.Parallel.filter (fun (graph_node, preferredNamespaceUri, preferredNamespacePrefixes, distribution) ->
        lov.dump.nq.graph_names
        |> Array.Parallel.exists (fun graph_name ->
            not (graph_node.Uri.OriginalString = graph_name)
            && not (preferredNamespaceUri.Value = graph_name))

    )
    |> Array.Parallel.map (fun (graph_node, preferredNamespaceUri, preferredNamespacePrefixes, distribution) ->
        preferredNamespaceUri.Value)
    |> Array.distinct
    |> Array.sort

let distributions_by_graph_name graph_name =
    graph_name,
    lov.dump.n3.vocabulary'preferredNamespaceUri'preferredNamespacePrefixes'distribution
    |> Array.Parallel.filter (fun (graph_node, preferredNamespaceUri, preferredNamespacePrefixes, distribution) ->
        graph_node.Uri.OriginalString = graph_name)


let graph_name_probe =
    absolute_graph_names
    |> Array.Parallel.map (fun graph_name ->

        graph_name,
        lov.dump.n3.vocabulary'preferredNamespaceUri
        |> Array.Parallel.tryPick (fun (vocabulary, preferred_namespace) ->

            if vocabulary.Uri.OriginalString = graph_name then
                Some preferred_namespace.Value
            else
                None)

    )



graph_name_probe |> Array.Parallel.filter (fun (graph_name, maybe_namespace) -> maybe_namespace.IsNone)


*)

let test_graph_name = "http://bblfish.net/work/atom-owl/2006-06-06/"

lov.dump.nq.graph_names
|> Array.Parallel.filter (fun graph_name -> graph_name = test_graph_name)



lov.dump.n3.vocabulary'preferredNamespaceUri
|> Array.pick (fun (vocabulary, preferred_namespace) ->

    if vocabulary.Uri.OriginalString = test_graph_name then
        Some preferred_namespace.Value
    else
        None)


let graph_namespace_name_prefixes =
    let graph_names =
        lov.dump.nq.graph_names
        |> Array.Parallel.filter (fun graph_name -> graph_name |> is_terminal_delimited)
        |> Array.Parallel.map (fun graph_name -> graph_name, graph_name)

    let preferred_namespaces =
        absolute_graph_names
        |> Array.Parallel.map (fun graph_name ->

            graph_name,
            lov.dump.n3.vocabulary'preferredNamespaceUri
            |> Array.pick (fun (vocabulary, preferred_namespace) ->

                if vocabulary.Uri.OriginalString = graph_name then
                    Some preferred_namespace.Value
                else
                    None)

        )

    Array.concat [|

                    graph_names
                    preferred_namespaces

                     |]
    |> Array.Parallel.map (fun (graph_name, namespace_name) ->

        lov.dump.n3.vocabulary'preferredNamespaceUri'preferredNamespacePrefixes
        |> Array.pick (fun (vocabulary, preferred_namespace, preferred_prefix) ->

            if vocabulary.Uri.OriginalString = graph_name then
                Some(graph_name, preferred_namespace.Value, preferred_prefix.Value)
            else
                None


        )


    )



let lov_prefixes =
    lov.vocabulary.json
    |> Array.Parallel.map (fun vocabulary -> vocabulary.Nsp, vocabulary.Prefix)

let prefixcc_prefixes =
    prefixcc.json.JsonValue.Properties
    |> Array.Parallel.map (fun (jsonKey, jsonValue) -> jsonValue.AsString(), jsonKey)

let all_prefixes =
    Array.concat [|

                    lov_prefixes
                    prefixcc_prefixes

                     |]
    |> Array.distinct
    |> Array.sortBy (fun (namespace_name, preferred_prefix) -> namespace_name)

let all_prefix_groupings =
    all_prefixes
    |> Array.Parallel.groupBy (fun (namespace_name, preferred_prefix) -> namespace_name)




let singular_prefix_namespaces =
    all_prefix_groupings
    |> Array.Parallel.filter (fun (namespace_name, prefix_groupings) -> prefix_groupings.Length = 1)


let multiple_prefix_namespaces =
    all_prefix_groupings
    |> Array.Parallel.filter (fun (namespace_name, prefix_groupings) -> prefix_groupings.Length > 1)
    |> Array.Parallel.map (fun (namespace_name, prefix_groupings) ->
        let prefixes =
            prefix_groupings
            |> Array.Parallel.map (fun (namespace_name, preferred_prefix) -> preferred_prefix)
            |> Array.Parallel.sortBy (fun prefix -> prefix.Length)
            |> Array.distinct
            |> Array.rev

        namespace_name, prefixes

    )
    |> Array.Parallel.sortBy (fun (namespace_name, prefixes) -> prefixes.Length)
    |> Array.rev





let singular_match_content =
    singular_prefix_namespaces
    |> Array.sortBy (fun (namespace_name, preferred_prefix) -> namespace_name)
    |> Array.collect (fun (namespace_name, prefix_groupings) ->
        prefix_groupings
        |> Array.map (fun (namespace_name, preferred_prefix) ->
            let prefix_match =
                match namespace_name with
                | "http://www.loc.gov/premis/rdf/v1#" -> "premisv1"
                | "http://www.lexinfo.net/ontology/2.0/lexinfo#" -> "lexinfov2"
                | "http://spdx.org/rdf/terms#" -> "spdxv1"
                | "http://purl.org/swan/1.2/discourse-elements/" -> "swandev1_2"
                | "http://ns.ottr.xyz/templates#" -> "ottr_tpl"
                | "http://www.ontologyrepository.com/CommonCoreOntologies/" -> "comcore"
                | "http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#" -> "obs"
                | "http://opendata.caceres.es/def/ontomunicipio#" -> "ontomun"

                | _ when namespace_name.Contains('.') -> preferred_prefix.Replace('.', '_')
                | _ -> preferred_prefix
            $"""    "{namespace_name}", "{prefix_match}" """

        )

    )

let targeted_match target_prefix namespace_name preferred_prefix =
    if preferred_prefix = target_prefix then
        $"""    "{namespace_name}", "{preferred_prefix}" """
    else
        $"""    // "{namespace_name}", "{preferred_prefix}" """

let multiple_match_content =
    multiple_prefix_namespaces
    |> Array.sortBy (fun (namespace_name, preferred_prefix) -> namespace_name)
    |> Array.collect (fun (namespace_name, prefixes) ->
        prefixes
        |> Array.mapi (fun index preferred_prefix ->
            match namespace_name with
            | "http://www.w3.org/ns/dcat#" -> targeted_match "dcat" namespace_name preferred_prefix
            | "http://www.w3.org/2001/XMLSchema#" -> targeted_match "xsd" namespace_name preferred_prefix
            | _ ->
                if index = 0 then
                    $"""    "{namespace_name}", "{preferred_prefix}" """
                else
                    $"""    // "{namespace_name}", "{preferred_prefix}" """

        )

    )

let manual_namespace_names =
    Array.concat [|

                    manual_distributions
                    |> Array.map (fun (namespace_name, _) -> namespace_name)
                    multipart_distributions
                    |> Array.map (fun (namespace_name, _) -> namespace_name) |]


let unmatched_namespaces =
    manual_namespace_names
    |> Array.Parallel.choose (fun namespace_name ->

        let namespace_exists =
            global_prefix_declarations
            |> Array.exists (fun (global_namespace, global_prefix) -> namespace_name = global_namespace)
        if namespace_exists then
            None
        else
            Some namespace_name

    )


let manual_match_content =
    [|

       "https://eristocrates.dev/ontology/sanctuary/", "sanctuary"
       "https://www.w3.org/ns/posix/stat#", "posix"
       "http://www.w3.org/2011/http-headers#", "http_headers"
       "http://www.w3.org/2011/http-statusCodes#", "http_statusCodes"
       "https://eristocrates.dev/ontology/dbug/", "dbug"
       "http://www.w3.org/2006/time#", "owl_time"
       "https://termlex.oeg.fi.upm.es/termlex#", "termlex"
       "https://w3id.org/function/vocabulary/implementation#", "fnoi"
       "https://w3id.org/function/vocabulary/composition#", "fnoc"
       "http://aims.fao.org/aos/agrontology#", "agrontology"
       "http://tracker.api.gnome.org/ontology/v3/nrl#", "tnrl"
       "http://tracker.api.gnome.org/ontology/v3/nie#", "tnie"
       "http://tracker.api.gnome.org/ontology/v3/nao#", "tnao"
       "http://tracker.api.gnome.org/ontology/v3/nco#", "tnco"
       "http://tracker.api.gnome.org/ontology/v3/nfo#", "tnfo"
       "http://tracker.api.gnome.org/ontology/v3/nmm#", "tnmm"
       "http://tracker.api.gnome.org/ontology/v3/mfo#", "tmfo"
       "http://tracker.api.gnome.org/ontology/v3/tracker#", "tracker"
       "http://tracker.api.gnome.org/ontology/v3/slo#", "tslo"
       "http://tracker.api.gnome.org/ontology/v3/osinfo#", "tosinfo"
       "http://eulersharp.sourceforge.net/2003/03swap/coding#", "swap_coding"
       "http://eulersharp.sourceforge.net/2003/03swap/computer#", "swap_computer"
       "http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#", "swap_decisionSupport"
       "http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#", "swap_digitalProcedure"
       "http://eulersharp.sourceforge.net/2003/03swap/document#", "swap_document"
       "http://eulersharp.sourceforge.net/2003/03swap/foster#", "swap_foster"
       "http://eulersharp.sourceforge.net/2003/03swap/physicalResource#", "swap_physicalResource"
       "http://eulersharp.sourceforge.net/2003/03swap/quantities#", "swap_quantities"
       "http://eulersharp.sourceforge.net/2003/03swap/space#", "swap_space"
       "http://eulersharp.sourceforge.net/2003/03swap/sparql#", "swap_sparql"
       "http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#", "swap_sparqlAnalysis"
       "http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysisTemplate#", "swap_sparqlAnalysisTemplate"
       "http://eulersharp.sourceforge.net/2003/03swap/substanceForms#", "swap_substanceForms"
       "http://eulersharp.sourceforge.net/2003/03swap/time#", "swap_time"
       "http://eulersharp.sourceforge.net/2003/03swap/weekScheme#", "swap_weekScheme"
       "http://eulersharp.sourceforge.net/2003/03swap/workflow#", "swap_workflow"
       "http://example.org/dctap#", "dctap"
       "http://open-services.net/ns/am#", "oslc_am"
       "http://open-services.net/ns/auto#", "oslc_auto"
       "http://open-services.net/ns/cm#", "cm"
       "http://open-services.net/ns/config#", "config"
       "http://open-services.net/ns/core/trs#", "trs"
       "http://open-services.net/ns/core/trspatch#", "trs_patch"
       "http://open-services.net/ns/qm#", "qm"
       "http://open-services.net/ns/rm#", "oslc_rm"
       "http://open-services.net/ns/sysmlv2#", "sysml"
       "http://purl.obolibrary.org/obo/BFO_", "bfo"
       "http://purl.org/spar/bido/", "bido"
       "http://purl.org/spar/fivestars/", "fivestars"
       "http://purl.org/spar/fr/", "spar_fr"
       "http://purl.org/spar/frbr/", "frbr"
       "http://purl.org/spar/mito/", "mito"
       "http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#", "owls_ActorDefault"
       "http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#", "owls_Expression"
       "http://www.daml.org/services/owl-s/1.2/generic/ObjectList.owl#", "owls_ObjectList"
       "http://www.daml.org/services/owl-s/1.2/Grounding.owl#", "owls_Grounding"
       "http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl", "owls_GroundingDeprecatedElements"
       "http://www.daml.org/services/owl-s/1.2/Process.owl", "owls_Process"
       "http://www.daml.org/services/owl-s/1.2/Process.owl#", "owls_Process"
       "http://www.daml.org/services/owl-s/1.2/Profile.owl#", "owls_Profile"
       "http://www.daml.org/services/owl-s/1.2/ProfileAdditionalParameters.owl#", "owls_ProfileAdditionalParameters"
       "http://www.daml.org/services/owl-s/1.2/Resource.owl#", "owls_Resource"
       "http://www.daml.org/services/owl-s/1.2/Service.owl#", "owls_Service"
       "http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#", "dolce"
       "http://www.w3.org/2000/10/swap/pim/email#", "email"
       "http://www.w3.org/2000/10/swap/pim/ical#", "swap_ical"
       "http://www.w3.org/2000/10/swap/pim/qif#", "qif"
       "http://www.w3.org/2000/10/swap/pim/travelFig#", "travelFig"
       "http://www.w3.org/2000/10/swap/pim/travelTerms#", "travelTerms"
       "http://www.w3.org/2000/10/swap/pim/usps#", "usps"
       "https://purl.org/heals/eo#", "xpln"
       "https://spdx.org/rdf/3.1/terms/", "spdx"
       "http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#", "dolcextend"
       "http://www.essepuntato.it/2011/02/argumentmodel/", "argu"
       "http://qudt.org/vocab/dimensionvector", "qudt_dimensionvector"
       "http://qudt.org/vocab/quantitykind", "qudt_quantitykind"
       "http://qudt.org/vocab/soqk", "qudt_soqk"
       "http://purl.org/swan/2.0/", "swan"
       "http://purl.org/swan/2.0/collections/", "swancol"
       "http://purl.org/swan/2.0/discourse-elements/", "swande"
       "http://purl.org/swan/2.0/experiment", "swanex"
       "http://purl.org/dcx/lrmi-terms/", "lrmi"
       "http://purl.org/dcx/lrmi-vocabs/alignmentType/", "lrmi_alignmentType"
       "http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/", "lrmi_educationalAudienceRole"
       "http://purl.org/dcx/lrmi-vocabs/educationalUse/", "lrmi_educationalUse"
       "http://purl.org/dcx/lrmi-vocabs/interactivityType/", "lrmi_interactivityType"
       "http://purl.org/dcx/lrmi-vocabs/learningResourceType/", "lrmi_learningResourceType"
       "https://www.commoncoreontologies.org/", "cco"
       "https://www.commoncoreontologies.org/mro/", "ccmro"
       "http://ns.ottr.xyz/0.4/", "ottr"
       "http://www.w3.org/2006/03/wn/wn20/instances/", "wn20instances"
       "http://www.w3.org/2006/03/wn/wn20/schema/", "wn20schema"
       "https://open-metadata.org/ontology/", "om"
       "https://www.commoncoreontologies.org/BarcodeOntology/", "barcode"
       "https://www.commoncoreontologies.org/FamilialRelationsOntology", "famrel"

       |]
    |> Array.map (fun (namespace_name, preferred_prefix) -> $"""    "{namespace_name}", "{preferred_prefix}" """)

let match_content =
    Array.concat [| [| "let global_prefix_declarations = [|" |]
                    singular_match_content
                    multiple_match_content
                    manual_match_content
                    [| "|]" |]

                     |]

File.WriteAllLines(@"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Namespace_Prefixes.fsx", match_content)




test <@ unmatched_namespaces.Length = 0 @>


// TODO handle the ~90 duplicate prefixes
// maybe lazy _ suffix?
let duplicate_prefixes =
    global_prefix_declarations
    |> Array.Parallel.groupBy (fun (namespace_name, prefix_label) -> prefix_label)
    |> Array.Parallel.filter (fun (prefix_label, namespace_groupings) -> namespace_groupings.Length > 1
    // test <@ namespace_groupings.Length = 1 @>
    (*
        namespace_groupings
        |> Array.Parallel.choose (fun namespace_grouping ->
        if namespace_groupings.Length > 1 then
            Some namespace_grouping
        else None
        )

        *)


    )
    |> Array.sortBy (fun (prefix_label, namespace_groupings) -> prefix_label)

// test <@ duplicate_prefixes.Length = 0 @>




let singular_namespace_prefixes =
    all_prefixes
    |> Array.Parallel.groupBy (fun (namespace_name, preferred_prefix) -> preferred_prefix)
    |> Array.Parallel.filter (fun (preferred_prefix, namespace_groupings) -> namespace_groupings.Length = 1)


let multiple_namespace_prefixes =
    all_prefixes
    |> Array.Parallel.groupBy (fun (namespace_name, preferred_prefix) -> preferred_prefix)
    |> Array.Parallel.filter (fun (preferred_prefix, namespace_groupings) -> namespace_groupings.Length > 1)
    |> Array.Parallel.map (fun (preferred_prefix, namespace_groupings) ->
        let namespaces =
            namespace_groupings
            |> Array.Parallel.map (fun (namespace_name, preferred_prefix) -> namespace_name)
            |> Array.Parallel.sort
            |> Array.distinct

        preferred_prefix, namespaces

    )
    |> Array.Parallel.sortBy (fun (preferred_prefix, namespaces) -> namespaces.Length)
    |> Array.rev

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


let reserved_keywords =
    set [

          "abstract"
          "and"
          "as"
          "assert"
          "base"
          "begin"
          "class"
          "default"
          "delegate"
          "do"
          "done"
          "downcast"
          "downto"
          "elif"
          "else"
          "end"
          "exception"
          "extern"
          "false"
          "finally"
          "fixed"
          "for"
          "fun"
          "function"
          "global"
          "if"
          "in"
          "inherit"
          "inline"
          "interface"
          "internal"
          "lazy"
          "let"
          "match"
          "member"
          "module"
          "mutable"
          "namespace"
          "new"
          "not"
          "null"
          "of"
          "open"
          "or"
          "override"
          "private"
          "public"
          "rec"
          "return"
          "select"
          "static"
          "struct"
          "then"
          "to"
          "true"
          "try"
          "type"
          "upcast"
          "use"
          "val"
          "void"
          "when"
          "while"
          "with"
          "yield"
          "const"
          "asr"
          "land"
          "lor"
          "lsl"
          "lsr"
          "lxor"
          "mod"
          "sig"
          "break"
          "checked"
          "component"
          "const"
          "constraint"
          "continue"
          "event"
          "external"
          "include"
          "mixin"
          "parallel"
          "process"
          "protected"
          "pure"
          "sealed"
          "tailcall"
          "trait"
          "virtual"

           ]

let lov_content =
    graph_namespace_name_prefixes
    |> Array.Parallel.map (fun (graph_name, namespace_name, preferred_prefix) ->

        let namespace_directory_path =
            namespace_directory_path_from_namespace_name namespace_name

        let prefix_declaration =
            global_prefix_declarations
            |> Array.pick (fun (vocabulary, prefix) ->

                if vocabulary = namespace_name then
                    Some prefix
                else
                    None

            )

        let file_stem =
            match namespace_name with
            | "http://www.w3.org/2001/sw/hcls/ns/transmed/" -> prefix_declaration
            | _ -> preferred_prefix
        let ttl_path = Path.Combine(namespace_directory_path, $"{file_stem}.ttl")


        match File.Exists(ttl_path), should_overwrite with
        | false, _
        | true, true

         ->
            let graph = new ThreadSafeGraph()

            lov.dump.nq.dataset.LoadGraph(graph, graph_name)
            map_prefixes graph
            Console.WriteLine $"Saving {namespace_name} as {file_stem}.ttl"
            Turtle.write ttl_path graph
        | _, _ -> ()

        let type_binding =
            match file_stem with
            | prefix when reserved_keywords.Contains(prefix) -> $"{prefix}_"
            | _ -> file_stem.Replace('-', '_').Replace('.', '_')

        $"""type {type_binding} = RDF_Vocabulary<"{namespace_name}", @"{ttl_path}"> """

    )











let acceptedMediaTypes =
    [|

       $"{MediaType.application.trig};q=1"
       $"{MediaType.application.nquads};q=0.95"
       $"{MediaType.text.turtle};q=0.9"
       $"{MediaType.application.ntriples};q=0.85"
       $"{MediaType.application.rdfxml};q=0.8"
       $"{MediaType.application.ldjson};q=0.75"
       $"{MediaType.application.json};q=0.7"
       $"{MediaType.application.xml};q=0.6"
       $"{MediaType.text.xml};q=0.55"
       $"{MediaType.text.html};q=0.4"
       $"{MediaType.text.plain};q=0.2"
       $"{MediaType.text.plain};charset=utf-8;q=0.2"
       $"{MediaType.any};q=0.1"

       |]




let http_client = new HttpClient()

acceptedMediaTypes
|> Array.iter (fun media_type ->

    http_client.DefaultRequestHeaders.Accept.ParseAdd(media_type))



let rdf_loader = new Loader(http_client)
rdf_loader.FollowRedirects <- true













let file_stem_from_name_distribution namespace_name namespace_distribution =

    let distribution_uri = new Uri(namespace_distribution)
    let distribution_stem = distribution_uri.Segments |> Array.last

    match label_from_namespaceIriString namespace_name with
    | _ when namespace_name = "http://www.w3.org/2001/XMLSchema#" -> "xsd"
    | Some prefix_label when namespace_name <> namespace_distribution -> $"{prefix_label}-{distribution_stem}"
    | Some prefix_label -> prefix_label
    | None -> distribution_stem


let errored_namespaces = new ResizeArray<string>()
File.WriteAllLines(Path.Combine(__SOURCE_DIRECTORY__, "ErroredNamespaces.txt"), errored_namespaces)

let distribution_http_response (distribution: string) : HttpResponseMessage option =
    try
        let http_response =
            http {
                GET(distribution.Replace("https", "http"))
                UserAgent userAgent
                Accept(acceptedMediaTypes |> String.concat ", ")
            }
            |> Request.send
            |> Response.asOriginalHttpResponseMessage

        Some http_response

    with
    | err ->
        errored_namespaces.Add $"HTTP failed for {distribution}: {err.Message}"
        None

let manual_content =
    manual_distributions
    |> Array.Parallel.map (fun (namespace_name, namespace_distribution) ->
        let namespace_uri = new Uri(namespace_name)
        let distribution_uri = new Uri(namespace_distribution)

        let namespace_directory_path =
            namespace_directory_path_from_namespace_name namespace_name

        let prefix_declaration =
            try
                global_prefix_declarations
                |> Array.pick (fun (vocabulary, prefix) ->

                    if vocabulary = namespace_name then
                        Some prefix
                    else
                        None

                )
            with
            | err -> failwith $"{namespace_name} {namespace_distribution} failed with error {err.Message}"

        let file_stem =
            match namespace_name with
            | "http://www.w3.org/2001/XMLSchema#" -> "xsd"
            | "http://www.w3.org/ns/dcat#" -> "dcat"
            | _ -> prefix_declaration


        let ttl_path = Path.Combine(namespace_directory_path, $"{file_stem}.ttl")



        match File.Exists(ttl_path), should_overwrite with
        | false, _
        | true, true

         ->
            let graph = new ThreadSafeGraph()

            try
                match namespace_name with
                | "http://www.essepuntato.it/2011/02/argumentmodel/"
                | "http://example.org/dctap#"
                | "http://www.opengis.net/ont/geosparql#"
                | "https://www.commoncoreontologies.org/"
                | "https://w3id.org/linkml/"
                | "http://data.europa.eu/m8g/"
                | "http://www.w3.org/2001/XMLSchema#" -> rdf_loader.LoadGraph(graph, distribution_uri, TurtleParser())
                | "http://id.loc.gov/ontologies/bflc/"
                | "http://id.loc.gov/ontologies/bibframe/"
                | "http://www.w3.org/2002/12/cal/icaltzd#"
                | "http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#"
                | "http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#"
                | "http://www.loc.gov/premis/rdf/v3/"
                | "http://www.essepuntato.it/2008/12/earmark#"
                | "https://raw.githubusercontent.com/tetherless-world/explanation-ontology/master/Ontologies/v2/explanation-ontology.owl"
                | "http://aims.fao.org/aos/agrontology#" -> rdf_loader.LoadGraph(graph, distribution_uri, RdfXmlParser())
                | _ when namespace_name.StartsWith("http://tracker.api.gnome.org/ontology/v3/") -> rdf_loader.LoadGraph(graph, distribution_uri, TurtleParser())
                | _ when namespace_name.StartsWith("http://eulersharp.sourceforge.net/2003/03swap/") -> rdf_loader.LoadGraph(graph, distribution_uri, TurtleParser())
                | _ when namespace_name.StartsWith("http://www.semanticdesktop.org/ontologies") ->
                    let dataset = new ThreadSafeTripleStore()
                    rdf_loader.LoadDataset(dataset, distribution_uri, TriGParser())
                    for dataset_graph in dataset.Graphs do
                        graph.Merge(dataset_graph, false)
                | _ -> rdf_loader.LoadGraph(graph, distribution_uri)

                Console.WriteLine $"Saving {namespace_name} as {file_stem}.ttl"
                map_prefixes graph
                Turtle.write ttl_path graph
            with
            | err ->
                // errored_namespaces.Add $"{namespace_name} {namespace_distribution} failed with error {err.Message}"
                match distribution_http_response namespace_distribution with

                | Some http_response when http_response.IsSuccessStatusCode ->

                    let file_text =
                        http_response.Content.ReadAsStringAsync()
                        |> Async.AwaitTask
                        |> Async.RunSynchronously
                    try
                        StringParser.Parse(graph, file_text)
                        Console.WriteLine $"Saving {namespace_name} as {file_stem}.ttl"
                        map_prefixes graph
                        Turtle.write ttl_path graph
                    with
                    | err -> errored_namespaces.Add $"{namespace_name} {namespace_distribution} failed with error {err.Message}"
                | _ -> errored_namespaces.Add $"No http response for {namespace_name} distribution {namespace_distribution}"
        | _, _ -> ()

        let type_binding =
            match file_stem with
            | prefix when reserved_keywords.Contains(prefix) -> $"{prefix}_"
            | _ -> file_stem.Replace('-', '_').Replace('.', '_')

        $"""type {type_binding} = RDF_Vocabulary<"{namespace_name}", @"{ttl_path}"> """

    )


let multipart_content =

    multipart_distributions
    |> Array.Parallel.map (fun (namespace_name, namespace_distributions) ->
        let ttl_paths =
            namespace_distributions
            |> Array.Parallel.map (fun namespace_distribution ->
                let namespace_uri = new Uri(namespace_name)
                let distribution_uri = new Uri(namespace_distribution)

                let namespace_directory_path =
                    namespace_directory_path_from_namespace_name namespace_name


                let file_stem =
                    let file_name =
                        file_stem_from_name_distribution namespace_name namespace_distribution
                    file_name.Replace(".ttl", "")

                let ttl_path = Path.Combine(namespace_directory_path, $"{file_stem}.ttl")



                match File.Exists(ttl_path), should_overwrite with
                | false, _
                | true, true

                 ->
                    let graph = new ThreadSafeGraph()

                    match namespace_name with
                    | _ ->
                        try
                            rdf_loader.LoadGraph(graph, distribution_uri)
                            Console.WriteLine $"Saving {namespace_name} as {file_stem}.ttl"
                            map_prefixes graph
                            Turtle.write ttl_path graph
                        with
                        | err ->
                            // errored_namespaces.Add $"{namespace_name} {namespace_distribution} failed with error {err.Message}"
                            match distribution_http_response namespace_distribution with

                            | Some http_response when http_response.IsSuccessStatusCode ->

                                let file_text =
                                    http_response.Content.ReadAsStringAsync()
                                    |> Async.AwaitTask
                                    |> Async.RunSynchronously
                                try
                                    StringParser.Parse(graph, file_text)
                                    Console.WriteLine $"Saving {namespace_name} as {file_stem}.ttl"
                                    map_prefixes graph
                                    Turtle.write ttl_path graph

                                with
                                | err -> errored_namespaces.Add $"{namespace_name} {namespace_distribution} failed with error {err.Message}"
                            | _ -> errored_namespaces.Add $"No http response for {namespace_name} distribution {namespace_distribution}"
                    ttl_path
                | _, _ -> "")
            |> Array.filter (fun ttl_path -> ttl_path <> "")
            |> String.concat ";"

        let prefix_declaration =
            global_prefix_declarations
            |> Array.pick (fun (vocabulary, prefix) ->

                if vocabulary = namespace_name then
                    Some prefix
                else
                    None

            )
        let type_binding =
            match prefix_declaration with
            | prefix when reserved_keywords.Contains(prefix) -> $"{prefix}_"
            | _ ->
                prefix_declaration
                    .Replace('-', '_')
                    .Replace('.', '_')

        $"""type {type_binding} = RDF_Vocabulary<"{namespace_name}", @"{ttl_paths}"> """

    )

let provider_content =
    Array.concat [|

                    lov_content
                    manual_content
                    multipart_content

                     |]
    |> Array.insertAt
        0
        """
#r @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Project\MyProvider\src\MyProvider.Runtime\bin\Release\netstandard2.0\MyProvider.Runtime.dll"

open MyNamespace
open MyProvider
    """


File.WriteAllLines(Path.Combine(__SOURCE_DIRECTORY__, "RdfProvided.txt"), provider_content)
File.WriteAllLines(Path.Combine(__SOURCE_DIRECTORY__, "ErroredNamespaces.txt"), errored_namespaces)

// TODO investigate linkml output

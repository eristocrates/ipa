#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"

#r "Metaprogramming.dll"

open Metaprogramming
#r "PathErgonomics.dll"

open PathErgonomics
#r "BrowserErgonomics.dll"
open BrowserErgonomics
#r "PageErgonomics.dll"
open PageErgonomics
#r "TaskErgonomics.dll"
open TaskErgonomics
#r "SparqlErgonomics.dll"
open SparqlErgonomics

#r "RdfAsm.dll"

open RdfAsm

#r "RdfIO.dll"

open RdfIO

#r "RdfDsl.dll"

open RdfDsl

#r "UrlErgonomics.dll"

open UrlErgonomics

open FSharp.Data

open Dubzer.WhatwgUrl
open PuppeteerSharp
open FsHttp
open System.IO.Compression
open System.IO
open VDS.RDF.Query.Datasets
open VDS.RDF
open VDS.RDF.Parsing
open System
open FolkerKinzel.MimeTypes
open System.Threading
open RDFSharp.Model
open System.Threading.Tasks



(*

        "http://www.w3.org/2002/12/cal/icaltzd#", "https://www.w3.org/2002/12/cal/icaltzd.rdf"
        "http://example.org/dctap#", "https://github.com/dcmi/dctap/raw/refs/heads/main/dctap.ttl" // "dcmi.dctap"
        "http://id.loc.gov/ontologies/bibframe/", "https://github.com/lcnetdev/bibframe-ontology/raw/refs/heads/main/bibframe.rdf" // "loc.bibframe"
        "https://purl.org/heals/eo#", "https://raw.githubusercontent.com/tetherless-world/explanation-ontology/master/Ontologies/v2/explanation-ontology.owl" // "eo"
        "http://www.opengis.net/ont/geosparql#", "http://www.opengis.net/ont/geosparql#" // "opengis.geosparql"
        "http://www.essepuntato.it/2011/02/argumentmodel/", "https://sourceforge.net/p/dwellonit/code/HEAD/tree/ArgumentModel/argumentmodel.owl?format=raw" // "dwellonit.arg"
        "https://www.commoncoreontologies.org/mro/", "https://github.com/CommonCoreOntology/CommonCoreOntologies/raw/refs/heads/develop/src/cco-extensions/ModalRelationOntology.ttl" // "cco.mro"

        "http://data.europa.eu/m8g/", "https://github.com/SEMICeu/CCCEV/raw/refs/heads/master/releases/2.1.0/voc/cccev.ttl"
        "http://data.europa.eu/m8g/", "https://github.com/SEMICeu/Core-Business-Vocabulary/raw/refs/heads/master/releases/2.2.0/voc/core-business-ap.ttl"
        "http://data.europa.eu/m8g/", "https://github.com/SEMICeu/Core-Location-Vocabulary/raw/refs/heads/master/releases/2.1.0/voc/core-location.ttl"
        "http://data.europa.eu/m8g/", "https://github.com/SEMICeu/Core-Person-Vocabulary/raw/refs/heads/master/releases/2.1.1/voc/core-person-ap.ttl"
        "http://data.europa.eu/m8g/", "https://github.com/SEMICeu/Core-Public-Event-Vocabulary/raw/refs/heads/master/releases/1.1.0/voc/core-public-event.ttl"
        "http://data.europa.eu/m8g/", "https://github.com/SEMICeu/CPOV/raw/refs/heads/master/releases/2.1.1/voc/core-public-organisation-ap.ttl"
        "http://ns.ottr.xyz/0.4/", "https://spec.ottr.xyz/bOTTR/0.1.2/core-vocabulary.owl.ttl"
        "http://ns.ottr.xyz/0.4/", "https://spec.ottr.xyz/rOTTR/0.2.0/puntypes.owl.ttl"
        "http://ns.ottr.xyz/0.4/", "https://spec.ottr.xyz/rOTTR/0.2.0/types.owl.ttl"
        "http://ns.ottr.xyz/0.4/", "https://spec.ottr.xyz/rOTTR/0.2.0/types.shacl.ttl"
        "http://ns.ottr.xyz/0.4/", "https://spec.ottr.xyz/wOTTR/0.4.5/core-grammar.shacl.ttl"
        "http://ns.ottr.xyz/0.4/", "https://spec.ottr.xyz/wOTTR/0.4.5/core-vocabulary.owl.ttl"
        "http://qudt.org/schema/qudt/", "http://qudt.org/3.1.10/schema/datatype"
        "http://qudt.org/schema/qudt/", "http://qudt.org/3.1.10/schema/qudt"
        "http://qudt.org/schema/qudt/", "http://qudt.org/3.1.10/schema/shacl/overlay/qudt"
        "http://qudt.org/schema/qudt/", "http://qudt.org/3.1.10/schema/shacl/qudt"
        "http://www.loc.gov/premis/rdf/v3/", "https://id.loc.gov/ontologies/premis-3-0-0.rdf"
        "http://www.ontology-of-units-of-measure.org/resource/om-2/", "https://github.com/HajoRijgersberg/OM/raw/refs/heads/master/om-2-ucum.ttl"
*)


let singletonDistributions =
    [|
        "http://aims.fao.org/aos/agrontology#", "http://aims.fao.org/aos/agrontology"
        "http://datashapes.org/dash#", "https://datashapes.org/dash.ttl"
        "http://eulersharp.sourceforge.net/2003/03swap/agent#", "http://eulersharp.sourceforge.net/2003/03swap/agent"
        "http://eulersharp.sourceforge.net/2003/03swap/bioSKOSSchemes#", "http://eulersharp.sourceforge.net/2003/03swap/bioSKOSSchemes"
        "http://eulersharp.sourceforge.net/2003/03swap/care#", "http://eulersharp.sourceforge.net/2003/03swap/care"
        "http://eulersharp.sourceforge.net/2003/03swap/coding#", "http://eulersharp.sourceforge.net/2003/03swap/coding"
        "http://eulersharp.sourceforge.net/2003/03swap/computer#", "http://eulersharp.sourceforge.net/2003/03swap/computer"
        "http://eulersharp.sourceforge.net/2003/03swap/countries#", "http://eulersharp.sourceforge.net/2003/03swap/countries"
        "http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#", "http://eulersharp.sourceforge.net/2003/03swap/decisionSupport"
        "http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#", "http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure"
        "http://eulersharp.sourceforge.net/2003/03swap/document#", "http://eulersharp.sourceforge.net/2003/03swap/document"
        "http://eulersharp.sourceforge.net/2003/03swap/environment#", "http://eulersharp.sourceforge.net/2003/03swap/environment"
        "http://eulersharp.sourceforge.net/2003/03swap/event#", "http://eulersharp.sourceforge.net/2003/03swap/event"
        "http://eulersharp.sourceforge.net/2003/03swap/foster#", "http://eulersharp.sourceforge.net/2003/03swap/foster"
        "http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#", "http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality"
        "http://eulersharp.sourceforge.net/2003/03swap/human#", "http://eulersharp.sourceforge.net/2003/03swap/human"
        "http://eulersharp.sourceforge.net/2003/03swap/humanBody#", "http://eulersharp.sourceforge.net/2003/03swap/humanBody"
        "http://eulersharp.sourceforge.net/2003/03swap/languages#", "http://eulersharp.sourceforge.net/2003/03swap/languages"
        "http://eulersharp.sourceforge.net/2003/03swap/organism#", "http://eulersharp.sourceforge.net/2003/03swap/organism"
        "http://eulersharp.sourceforge.net/2003/03swap/organization#", "http://eulersharp.sourceforge.net/2003/03swap/organization"
        "http://eulersharp.sourceforge.net/2003/03swap/physicalResource#", "http://eulersharp.sourceforge.net/2003/03swap/physicalResource"
        "http://eulersharp.sourceforge.net/2003/03swap/quantities#", "http://eulersharp.sourceforge.net/2003/03swap/quantities"
        "http://eulersharp.sourceforge.net/2003/03swap/space#", "http://eulersharp.sourceforge.net/2003/03swap/space"
        "http://eulersharp.sourceforge.net/2003/03swap/sparql#", "http://eulersharp.sourceforge.net/2003/03swap/sparql"
        "http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#", "http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis"
        "http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysisTemplate#", "http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysisTemplate"
        "http://eulersharp.sourceforge.net/2003/03swap/substanceForms#", "http://eulersharp.sourceforge.net/2003/03swap/substanceForms"
        "http://eulersharp.sourceforge.net/2003/03swap/time#", "http://eulersharp.sourceforge.net/2003/03swap/time"
        "http://eulersharp.sourceforge.net/2003/03swap/units#", "http://eulersharp.sourceforge.net/2003/03swap/units"
        "http://eulersharp.sourceforge.net/2003/03swap/weekScheme#", "http://eulersharp.sourceforge.net/2003/03swap/weekScheme"
        "http://eulersharp.sourceforge.net/2003/03swap/workflow#", "http://eulersharp.sourceforge.net/2003/03swap/workflow"
        "http://example.org/dctap#", "https://github.com/dcmi/dctap/raw/refs/heads/main/dctap.ttl"
        "http://id.loc.gov/ontologies/bflc/", "https://id.loc.gov/ontologies/bflc.rdf"
        "http://id.loc.gov/ontologies/bibframe/", "https://id.loc.gov/ontologies/bibframe.rdf"
        "http://kaiko.getalp.org/dbnary#", "https://kaiko.getalp.org/static/datamodel/2.1.2/ontology.ttl"
        "http://open-services.net/ns/am#", "https://docs.oasis-open-projects.org/oslc-op/am/v3.0/os/architecture-management-vocab.ttl"
        "http://open-services.net/ns/auto#", "https://docs.oasis-open-projects.org/oslc-op/auto/v2.1/psd01/automation-vocab.ttl"
        "http://open-services.net/ns/cm#", "https://docs.oasis-open-projects.org/oslc-op/cm/v3.0/errata01/os/change-mgt-vocab.ttl"
        "http://open-services.net/ns/config#", "https://docs.oasis-open-projects.org/oslc-op/config/v1.1/psd01/config-vocab.ttl"
        "http://open-services.net/ns/core/trs#", "https://docs.oasis-open-projects.org/oslc-op/trs/v3.0/os/trs-vocab.ttl"
        "http://open-services.net/ns/core/trspatch#", "https://docs.oasis-open-projects.org/oslc-op/trs/v3.0/os/trs-vocab.ttl"
        "http://open-services.net/ns/core#", "https://docs.oasis-open-projects.org/oslc-op/core/v3.0/os/core-vocab.ttl"
        "http://open-services.net/ns/qm#", "https://docs.oasis-open-projects.org/oslc-op/qm/v2.1/os/quality-management-vocab.ttl"
        "http://open-services.net/ns/rm#", "https://docs.oasis-open-projects.org/oslc-op/rm/v2.1/os/requirements-management-vocab.ttl"
        "http://open-services.net/ns/sysmlv2#", "https://docs.oasis-open-projects.org/oslc-op/sysml/v2.0/psd01/sysml-vocab.ttl"
        "http://openprovenance.org/model/opmo#", "https://openprovenance.org/opm/model/opmo-20101012.owl"
        "http://purl.obolibrary.org/obo/BFO_", "https://github.com/CommonCoreOntology/CommonCoreOntologies/raw/refs/heads/develop/src/cco-imports/bfo-core.ttl"
        "http://purl.obolibrary.org/obo/NCIT_", "http://purl.obolibrary.org/obo/ncit.owl"
        "http://purl.org/cerif/frapo/", "http://purl.org/spar/frapo.ttl"
        "http://purl.org/dc/dcam/", "http://purl.org/dc/dcam/"
        "http://purl.org/dc/dcmitype/", "http://purl.org/dc/dcmitype/"
        "http://purl.org/dc/elements/1.1/", "http://purl.org/dc/elements/1.1/"
        "http://purl.org/dc/terms/", "http://purl.org/dc/terms/"
        "http://purl.org/dcx/lrmi-terms/", "http://dublincore.org/specifications/lrmi/lrmi_terms/2022-06-14/lrmi-terms.ttl"
        "http://purl.org/dcx/lrmi-vocabs/alignmentType/", "http://dublincore.org/vocabs/alignmentType.ttl"
        "http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/", "http://dublincore.org/vocabs/educationalAudienceRole.ttl"
        "http://purl.org/dcx/lrmi-vocabs/educationalUse/", "http://dublincore.org/vocabs/educationalUse.ttl"
        "http://purl.org/dcx/lrmi-vocabs/interactivityType/", "http://dublincore.org/vocabs/interactivityType.ttl"
        "http://purl.org/dcx/lrmi-vocabs/learningResourceType/", "https://www.dublincore.org/vocabs/learningResourceType.ttl"
        "http://purl.org/goodrelations/v1#", "http://purl.org/goodrelations/v1.owl"
        "http://purl.org/HDT/hdt#", "https://www.w3.org/submissions/2011/SUBM-HDT-RDFS-20110330/HDT.rdf"
        "http://purl.org/iso25964/skos-thes#", "https://www.dublincore.org/specifications/skos-thes/ns/skos-thes.ttl"
        "http://purl.org/linked-data/cube#", "http://purl.org/linked-data/cube#"
        "http://purl.org/net/p-plan#", "http://purl.org/net/p-plan#"
        "http://purl.org/ontology/bibo/", "http://purl.org/ontology/bibo/"
        "http://purl.org/ontology/olo/core#", "https://github.com/smiy/orderedlistonto/raw/refs/heads/master/rdf/orderedlistontology.n3"
        "http://purl.org/spar/bido/", "http://purl.org/spar/bido.ttl"
        "http://purl.org/spar/biro/", "http://purl.org/spar/biro.ttl"
        "http://purl.org/spar/c4o/", "http://purl.org/spar/c4o.ttl"
        "http://purl.org/spar/cito/", "http://purl.org/spar/cito.ttl"
        "http://purl.org/spar/datacite/", "http://purl.org/spar/datacite.ttl"
        "http://purl.org/spar/deo/", "http://purl.org/spar/deo.ttl"
        "http://purl.org/spar/doco/", "http://purl.org/spar/doco.ttl"
        "http://purl.org/spar/fabio/", "http://purl.org/spar/fabio.ttl"
        "http://purl.org/spar/fivestars/", "http://purl.org/spar/fivestars.ttl"
        "http://purl.org/spar/fr/", "http://purl.org/spar/fr.ttl"
        "http://purl.org/spar/frbr/", "http://purl.org/spar/frbr.ttl"
        "http://purl.org/spar/mito/", "http://purl.org/spar/mito.ttl"
        "http://purl.org/spar/pro/", "http://purl.org/spar/pro.ttl"
        "http://purl.org/spar/pso/", "http://purl.org/spar/pso.ttl"
        "http://purl.org/spar/pwo/", "http://purl.org/spar/pwo.ttl"
        "http://purl.org/spar/scoro/", "http://purl.org/spar/scoro.ttl"
        "http://purl.org/swan/2.0/", "https://rawcdn.githack.com/pav-ontology/swan-ontology/2.0.1/swan.owl"
        "http://purl.org/swan/2.0/collections/", "https://rawcdn.githack.com/pav-ontology/swan-ontology/2.0.1/collections.owl"
        "http://purl.org/swan/2.0/discourse-elements/", "https://rawcdn.githack.com/pav-ontology/swan-ontology/2.0.1/discourse-elements.owl"
        "http://purl.org/swan/2.0/discourse-relationships/", "https://rawcdn.githack.com/pav-ontology/swan-ontology/2.0.1/discourse-relationships.owl"
        "http://purl.org/swan/2.0/experiment", "https://rawcdn.githack.com/pav-ontology/swan-ontology/2.0.1/experiments.owl"
        "http://purl.org/vocab/cpsv#", "https://github.com/SEMICeu/CPSV-AP/raw/refs/heads/master/releases/3.2.0/rdf/cpsv-ap.ttl"
        "http://purl.org/vocab/vann/", "http://purl.org/vocab/vann/"
        "http://purl.org/vocommons/voaf#", "http://purl.org/vocommons/voaf#"
        "http://qudt.org/vocab/constant/", "http://qudt.org/3.1.10/vocab/constant"
        "http://qudt.org/vocab/dimensionvector", "http://qudt.org/3.1.10/vocab/dimensionvector"
        "http://qudt.org/vocab/quantitykind", "http://qudt.org/3.1.10/vocab/quantitykind"
        "http://qudt.org/vocab/soqk", "http://qudt.org/3.1.10/vocab/soqk"
        "http://schema.org/", "https://datashapes.org/schema.ttl"
        "http://semanticscience.org/resource/SIO_", "http://semanticscience.org/ontology/sio.owl"
        "http://tracker.api.gnome.org/ontology/v3/mfo#", "https://github.com/GNOME/tinysparql/raw/refs/heads/main/src/ontologies/nepomuk/41-mfo.ontology"
        "http://tracker.api.gnome.org/ontology/v3/nao#", "https://github.com/GNOME/tinysparql/raw/refs/heads/main/src/ontologies/nepomuk/31-nao.ontology"
        "http://tracker.api.gnome.org/ontology/v3/nco#", "https://github.com/GNOME/tinysparql/raw/refs/heads/main/src/ontologies/nepomuk/32-nco.ontology"
        "http://tracker.api.gnome.org/ontology/v3/nfo#", "https://github.com/GNOME/tinysparql/raw/refs/heads/main/src/ontologies/nepomuk/33-nfo.ontology"
        "http://tracker.api.gnome.org/ontology/v3/nie#", "https://github.com/GNOME/tinysparql/raw/refs/heads/main/src/ontologies/nepomuk/30-nie.ontology"
        "http://tracker.api.gnome.org/ontology/v3/nmm#", "https://github.com/GNOME/tinysparql/raw/refs/heads/main/src/ontologies/nepomuk/38-nmm.ontology"
        "http://tracker.api.gnome.org/ontology/v3/nrl#", "https://github.com/GNOME/tinysparql/raw/refs/heads/main/src/ontologies/12-nrl.ontology"
        "http://tracker.api.gnome.org/ontology/v3/osinfo#", "https://github.com/GNOME/tinysparql/raw/refs/heads/main/src/ontologies/nepomuk/93-libosinfo.ontology"
        "http://tracker.api.gnome.org/ontology/v3/slo#", "https://github.com/GNOME/tinysparql/raw/refs/heads/main/src/ontologies/nepomuk/92-slo.ontology"
        "http://tracker.api.gnome.org/ontology/v3/tracker#", "https://github.com/GNOME/tinysparql/raw/refs/heads/main/src/ontologies/nepomuk/90-tracker.ontology"
        "http://usefulinc.com/ns/doap#", "https://lov.linkeddata.es/dataset/lov/vocabs/doap/versions/2012-01-04.n3"
        "http://w3id.org/nfdi4ing/metadata4ing#", "http://w3id.org/nfdi4ing/metadata4ing#"
        "http://w3id.org/rml/", "http://w3id.org/rml/"
        "http://www.cidoc-crm.org/cidoc-crm/", "https://cidoc-crm.org/rdfs/7.1.1/CIDOC_CRM_v7.1.1.rdf"
        "http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#", "http://www.daml.org/services/owl-s/1.2/ActorDefault.owl"
        "http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#", "http://www.daml.org/services/owl-s/1.2/generic/Expression.owl"
        "http://www.daml.org/services/owl-s/1.2/generic/ObjectList.owl#", "http://www.daml.org/services/owl-s/1.2/generic/ObjectList.owl"
        "http://www.daml.org/services/owl-s/1.2/Grounding.owl#", "http://www.daml.org/services/owl-s/1.2/Grounding.owl"
        "http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl", "http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl"
        "http://www.daml.org/services/owl-s/1.2/Process.owl", "http://www.daml.org/services/owl-s/1.2/ProcessDeprecatedElements.owl"
        "http://www.daml.org/services/owl-s/1.2/Process.owl#", "http://www.daml.org/services/owl-s/1.2/Process.owl"
        "http://www.daml.org/services/owl-s/1.2/Profile.owl#", "http://www.daml.org/services/owl-s/1.2/Profile.owl"
        "http://www.daml.org/services/owl-s/1.2/ProfileAdditionalParameters.owl#", "http://www.daml.org/services/owl-s/1.2/ProfileAdditionalParameters.owl"
        "http://www.daml.org/services/owl-s/1.2/Resource.owl#", "http://www.daml.org/services/owl-s/1.2/Resource.owl"
        "http://www.daml.org/services/owl-s/1.2/Service.owl#", "https://www.daml.org/services/owl-s/1.2/Service.owl"
        "http://www.ebi.ac.uk/swo/SWO_", "http://purl.obolibrary.org/obo/swo.owl"
        "http://www.essepuntato.it/2008/12/earmark#", "https://sourceforge.net/p/dwellonit/code/HEAD/tree/EARMARK/Current%20Version/earmark_ghost-1_2.owl?format=raw"
        "http://www.essepuntato.it/2008/12/earmark#", "https://sourceforge.net/p/dwellonit/code/HEAD/tree/EARMARK/Current%20Version/earmark_shell-2_0.owl?format=raw"
        "http://www.essepuntato.it/2008/12/pattern#", "https://sourceforge.net/p/dwellonit/code/HEAD/tree/StructuralPattern/pattern.owl?format=raw"
        "http://www.essepuntato.it/2011/02/argumentmodel/", "https://sourceforge.net/p/dwellonit/code/HEAD/tree/ArgumentModel/argumentmodel.owl?format=raw"
        "http://www.essepuntato.it/2012/04/tvc/", "https://sourceforge.net/p/dwellonit/code/HEAD/tree/TimeIndexedValueInContext/tvc.owl?format=raw"
        "http://www.essepuntato.it/2013/10/vagueness/", "https://sourceforge.net/p/dwellonit/code/HEAD/tree/VaguenessOntology/model.owl?format=raw"
        "http://www.lexinfo.net/ontology/3.0/lexinfo#", "http://www.lexinfo.net/ontology/3.0/lexinfo.ttl"
        "http://www.lexinfo.net/ontology/3.0/lexinfo#", "http://www.lexinfo.net/ontology/3.0/lexinfo#"
        "http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#", "https://github.com/iddi/sofia/raw/refs/heads/master/eu.sofia.adk.common/ontologies/foundational/DOLCE-Lite.owl"
        "http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#",
        "https://github.com/iddi/sofia/raw/refs/heads/master/eu.sofia.adk.common/ontologies/foundational/ExtendedDnS.owl"
        "http://www.loc.gov/premis/rdf/v3/", "https://github.com/lcnetdev/PREMIS/raw/refs/heads/master/premis3.owl"
        "http://www.ontology-of-units-of-measure.org/resource/om-2/", "https://github.com/HajoRijgersberg/OM/raw/refs/heads/master/om-2.0.rdf"
        "http://www.opengis.net/ont/geosparql#", "http://www.opengis.net/ont/geosparql#"
        "http://www.opengis.net/ont/sf#", "http://www.opengis.net/ont/sf#"
        "http://www.opmw.org/ontology/", "https://www.opmw.org/model/OPMW/opmw3.1.owl"
        "http://www.semanticdesktop.org/ontologies/2007/01/19/nie#", "http://www.semanticdesktop.org/ontologies/2007/01/19/nie/nie.trig"
        "http://www.semanticdesktop.org/ontologies/2007/03/22/nco#", "http://www.semanticdesktop.org/ontologies/2007/03/22/nco/nco.trig"
        "http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#", "http://www.semanticdesktop.org/ontologies/2007/03/22/nfo/nfo.trig"
        "http://www.semanticdesktop.org/ontologies/2007/03/22/nmo#", "http://www.semanticdesktop.org/ontologies/2007/03/22/nmo/nmo.trig"
        "http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#", "http://www.semanticdesktop.org/ontologies/2007/04/02/ncal/ncal.trig"
        "http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#", "http://www.semanticdesktop.org/ontologies/2007/05/10/nexif/nexif.trig"
        "http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#", "http://www.semanticdesktop.org/ontologies/2007/05/10/nid3/nid3.trig"
        "http://www.semanticdesktop.org/ontologies/2007/08/15/nao#", "http://www.semanticdesktop.org/ontologies/2007/08/15/nao/nao.trig"
        "http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#", "http://www.semanticdesktop.org/ontologies/2007/08/15/nrl/nrl.trig"
        "http://www.semanticdesktop.org/ontologies/2007/11/01/pimo#", "http://www.semanticdesktop.org/ontologies/2007/11/01/pimo/pimo.trig"
        "http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#", "http://www.semanticdesktop.org/ontologies/2008/05/20/tmo/v1.1/tmo.trig"
        "http://www.w3.org/1999/02/22-rdf-syntax-ns#", "http://www.w3.org/1999/02/22-rdf-syntax-ns#"
        "http://www.w3.org/2000/01/rdf-schema#", "http://www.w3.org/2000/01/rdf-schema#"
        "http://www.w3.org/2000/10/swap/crypto#", "http://www.w3.org/2000/10/swap/crypto"
        "http://www.w3.org/2000/10/swap/grammar/bnf#", "http://www.w3.org/2000/10/swap/grammar/bnf"
        "http://www.w3.org/2000/10/swap/list#", "http://www.w3.org/2000/10/swap/list"
        "http://www.w3.org/2000/10/swap/log#", "http://www.w3.org/2000/10/swap/log"
        "http://www.w3.org/2000/10/swap/math#", "http://www.w3.org/2000/10/swap/math"
        "http://www.w3.org/2000/10/swap/os#", "http://www.w3.org/2000/10/swap/os"
        "http://www.w3.org/2000/10/swap/pim/contact#", "http://www.w3.org/2000/10/swap/pim/contact"
        "http://www.w3.org/2000/10/swap/pim/doc#", "http://www.w3.org/2000/10/swap/pim/doc"
        "http://www.w3.org/2000/10/swap/pim/email#", "http://www.w3.org/2000/10/swap/pim/email"
        "http://www.w3.org/2000/10/swap/pim/ical#", "http://www.w3.org/2000/10/swap/pim/ical"
        "http://www.w3.org/2000/10/swap/pim/qif#", "http://www.w3.org/2000/10/swap/pim/qif"
        "http://www.w3.org/2000/10/swap/pim/travelFig#", "http://www.w3.org/2000/10/swap/pim/travelFig"
        "http://www.w3.org/2000/10/swap/pim/travelTerms#", "http://www.w3.org/2000/10/swap/pim/travelTerms"
        "http://www.w3.org/2000/10/swap/pim/usps#", "http://www.w3.org/2000/10/swap/pim/usps"
        "http://www.w3.org/2000/10/swap/reason#", "http://www.w3.org/2000/10/swap/reason"
        "http://www.w3.org/2000/10/swap/set#", "http://www.w3.org/2000/10/swap/set"
        "http://www.w3.org/2000/10/swap/string#", "http://www.w3.org/2000/10/swap/string"
        "http://www.w3.org/2001/XMLSchema#", "https://raw.githubusercontent.com/ruby-rdf/rdf/refs/heads/develop/etc/xsd.ttl"
        "http://www.w3.org/2002/07/owl#", "http://www.w3.org/2002/07/owl#"
        "http://www.w3.org/2002/12/cal/ical#", "http://www.w3.org/2002/12/cal/ical#"
        "http://www.w3.org/2004/02/skos/core#", "http://www.w3.org/2004/02/skos/core#"
        "http://www.w3.org/2004/06/rei#", "http://www.w3.org/2004/06/rei#"
        "http://www.w3.org/2006/03/wn/wn20/instances/synset-", "https://www.w3.org/2006/03/wn/wn20/instances/index.rdf"
        "http://www.w3.org/2006/03/wn/wn20/instances/word-", "https://www.w3.org/2006/03/wn/wn20/instances/index.rdf"
        "http://www.w3.org/2006/03/wn/wn20/instances/wordsense-", "https://www.w3.org/2006/03/wn/wn20/instances/index.rdf"
        "http://www.w3.org/2006/03/wn/wn20/schema/", "https://www.w3.org/2006/03/wn/wn20/schemas/wnfull.rdfs"
        "http://www.w3.org/2006/time#", "http://www.w3.org/2006/time#"
        "http://www.w3.org/2006/timezone#", "http://www.w3.org/2006/timezone#"
        "http://www.w3.org/2006/vcard/ns#", "http://www.w3.org/2006/vcard/ns#"
        "http://www.w3.org/2007/05/powder#", "https://www.w3.org/TR/2007/WD-powder-voc-20070925/wdr.rdf"
        "http://www.w3.org/2011/http-headers#", "https://www.w3.org/2011/http-headers.rdf"
        "http://www.w3.org/2011/http-methods#", "http://www.w3.org/2011/http-methods.rdf"
        "http://www.w3.org/2011/http-statusCodes#", "http://www.w3.org/2011/http-statusCodes.rdf"
        "http://www.w3.org/ns/adms#", "http://www.w3.org/ns/adms#"
        "http://www.w3.org/ns/csvw#", "http://www.w3.org/ns/csvw#"
        "http://www.w3.org/ns/dcat#", "http://www.w3.org/ns/dcat#"
        "http://www.w3.org/ns/dqv#", "https://www.w3.org/ns/dqv.ttl"
        "http://www.w3.org/ns/hydra/core#", "http://www.w3.org/ns/hydra/core#"
        "http://www.w3.org/ns/json-ld#", "https://www.w3.org/ns/json-ld.jsonld"
        "http://www.w3.org/ns/lemon/decomp#", "http://www.w3.org/ns/lemon/decomp#"
        "http://www.w3.org/ns/lemon/frac#", "http://www.w3.org/ns/lemon/frac"
        "http://www.w3.org/ns/lemon/lexicog#", "http://www.w3.org/ns/lemon/lexicog#"
        "http://www.w3.org/ns/lemon/lime#", "http://www.w3.org/ns/lemon/lime#"
        "http://www.w3.org/ns/lemon/ontolex#", "http://www.w3.org/ns/lemon/ontolex#"
        "http://www.w3.org/ns/lemon/synsem#", "http://www.w3.org/ns/lemon/synsem#"
        "http://www.w3.org/ns/lemon/vartrans#", "http://www.w3.org/ns/lemon/vartrans#"
        "http://www.w3.org/ns/locn#", "http://www.w3.org/ns/locn#"
        "http://www.w3.org/ns/oa#", "http://www.w3.org/ns/oa#"
        "http://www.w3.org/ns/org#", "http://www.w3.org/ns/org#"
        "http://www.w3.org/ns/pim/space#", "http://www.w3.org/ns/pim/space#"
        "http://www.w3.org/ns/prov#", "http://www.w3.org/ns/prov#"
        "http://www.w3.org/ns/r2rml#", "http://www.w3.org/ns/r2rml#"
        "http://www.w3.org/ns/rdfa#", "http://www.w3.org/ns/rdfa#"
        "http://www.w3.org/ns/shacl-shacl#", "http://www.w3.org/ns/shacl-shacl#"
        "http://www.w3.org/ns/shacl-shacl#", "https://www.w3.org/ns/shacl-shacl.ttl"
        "http://www.w3.org/ns/shacl#", "http://www.w3.org/ns/shacl#"
        "http://www.w3.org/ns/shex#", "https://www.w3.org/ns/shex.ttl"
        "http://www.w3.org/ns/solid/acp#", "http://www.w3.org/ns/solid/acp#"
        "http://www.w3.org/ns/solid/interop#", "http://www.w3.org/ns/solid/interop#"
        "http://www.w3.org/ns/solid/notifications#", "http://www.w3.org/ns/solid/notifications#"
        "http://www.w3.org/ns/solid/oidc#", "http://www.w3.org/ns/solid/oidc#"
        "http://www.w3.org/ns/solid/terms#", "http://www.w3.org/ns/solid/terms#"
        "http://www.w3.org/ns/sosa/", "http://www.w3.org/ns/sosa/"
        "http://www.w3.org/ns/spec#", "http://www.w3.org/ns/spec#"
        "http://www.w3.org/ns/ssn/", "http://www.w3.org/ns/ssn/"
        "http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#", "C:\Surfaces\temp\d2rq.rdf"
        "http://xmlns.com/foaf/0.1/", "https://lov.linkeddata.es/dataset/lov/vocabs/foaf/versions/2014-01-14.n3"
        "https:///www.commoncoreontologies.org/", "https://github.com/CommonCoreOntology/CommonCoreOntologies/raw/refs/heads/develop/src/cco-modules/GeospatialOntology.ttl"
        "https://globalwordnet.github.io/schemas/wn#", "https://globalwordnet.github.io/schemas/wn#"
        "https://globalwordnet.github.io/schemas/wn#", "https://www.w3.org/2006/03/wn/wn20/schemas/wnfull.rdfs"
        "https://ns.dublincore.org/openwemi/", "https://dcmi.github.io/openwemi/ns/openWEMI.ttl"
        "https://open-metadata.org/ontology/", "https://github.com/open-metadata/OpenMetadataStandards/raw/refs/heads/main/rdf/ontology/openmetadata.ttl"
        "https://purl.org/heals/eo#", "https://raw.githubusercontent.com/tetherless-world/explanation-ontology/master/Ontologies/v2/explanation-ontology.owl"
        "https://saref.etsi.org/core/", "https://saref.etsi.org/core/v4.1.1/saref.ttl"
        "https://schema.org/", "https://schema.org/version/latest/schemaorg-all-https.ttl"
        "https://schema.org/", "https://schema.org/version/latest/schemaorg-current-https.ttl"
        "https://spdx.org/rdf/3.1/terms/", "https://spdx.github.io/spdx-spec/3.1-RC1/rdf/spdx-model.ttl"
        "https://termlex.oeg.fi.upm.es/termlex#", "https://termlex.oeg.fi.upm.es/static/termlex.rdf"
        "https://w3id.org/function/ontology#", "https://fno.io/ontology/ontology.ttl"
        "https://w3id.org/function/vocabulary/composition#", "https://fno.io/vocabulary/composition/0.1.0/ontology.ttl"
        "https://w3id.org/function/vocabulary/implementation#", "https://fno.io/vocabulary/implementation/0.1.1/ontology.ttl"
        "https://w3id.org/function/vocabulary/mapping#", "https://fno.io/vocabulary/mapping/0.2.1/ontology.ttl"
        "https://w3id.org/linkml/", "https://github.com/linkml/linkml/raw/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/owl/meta.owl.ttl"
        "https://w3id.org/linkml/", "https://github.com/linkml/linkml/raw/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/annotations.model.ttl"
        "https://w3id.org/linkml/", "https://github.com/linkml/linkml/raw/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/annotations.ttl"
        "https://w3id.org/linkml/", "https://github.com/linkml/linkml/raw/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/datasets.model.ttl"
        "https://w3id.org/linkml/", "https://github.com/linkml/linkml/raw/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/datasets.ttl"
        "https://w3id.org/linkml/", "https://github.com/linkml/linkml/raw/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/extensions.model.ttl"
        "https://w3id.org/linkml/", "https://github.com/linkml/linkml/raw/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/extensions.ttl"
        "https://w3id.org/linkml/", "https://github.com/linkml/linkml/raw/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/mappings.model.ttl"
        "https://w3id.org/linkml/", "https://github.com/linkml/linkml/raw/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/mappings.ttl"
        "https://w3id.org/linkml/", "https://github.com/linkml/linkml/raw/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/meta.model.ttl"
        "https://w3id.org/linkml/", "https://github.com/linkml/linkml/raw/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/meta.ttl"
        "https://w3id.org/linkml/", "https://github.com/linkml/linkml/raw/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/types.model.ttl"
        "https://w3id.org/linkml/", "https://github.com/linkml/linkml/raw/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/types.ttl"
        "https://w3id.org/linkml/", "https://github.com/linkml/linkml/raw/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/units.model.ttl"
        "https://w3id.org/linkml/", "https://github.com/linkml/linkml/raw/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/units.ttl"
        "https://w3id.org/linkml/", "https://github.com/linkml/linkml/raw/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/validation.model.ttl"
        "https://w3id.org/linkml/", "https://github.com/linkml/linkml/raw/refs/heads/main/packages/linkml_runtime/src/linkml_runtime/linkml_model/rdf/validation.ttl"
        "https://w3id.org/okn/o/sd#", "https://knowledgecaptureanddiscovery.github.io/SoftwareDescriptionOntology/release/1.9.0/ontology.ttl"
        "https://w3id.org/pko#", "https://perks-project.github.io/pk-ontology/pko/latest/pko.ttl"
        "https://w3id.org/semapv/vocab/", "https://github.com/mapping-commons/semantic-mapping-vocabulary/raw/refs/heads/main/semapv.owl"
        "https://w3id.org/valueflows/ont/vf#", "https://codeberg.org/valueflows/pages/raw/branch/main/assets/all_vf.TTL"
        "https://www.commoncoreontologies.org/",
        "https://github.com/CommonCoreOntology/CommonCoreOntologies/raw/refs/heads/develop/src/cco-merged/CommonCoreOntologiesMerged.ttl"
        "https://www.commoncoreontologies.org/", "https://github.com/CommonCoreOntology/CommonCoreOntologies/raw/refs/heads/develop/src/cco-modules/AgentOntology.ttl"
        "https://www.commoncoreontologies.org/", "https://github.com/CommonCoreOntology/CommonCoreOntologies/raw/refs/heads/develop/src/cco-modules/ArtifactOntology.ttl"
        "https://www.commoncoreontologies.org/", "https://github.com/CommonCoreOntology/CommonCoreOntologies/raw/refs/heads/develop/src/cco-modules/CurrencyUnitOntology.ttl"
        "https://www.commoncoreontologies.org/", "https://github.com/CommonCoreOntology/CommonCoreOntologies/raw/refs/heads/develop/src/cco-modules/EventOntology.ttl"
        "https://www.commoncoreontologies.org/",
        "https://github.com/CommonCoreOntology/CommonCoreOntologies/raw/refs/heads/develop/src/cco-modules/ExtendedRelationOntology.ttl"
        "https://www.commoncoreontologies.org/", "https://github.com/CommonCoreOntology/CommonCoreOntologies/raw/refs/heads/develop/src/cco-modules/FacilityOntology.ttl"
        "https://www.commoncoreontologies.org/",
        "https://github.com/CommonCoreOntology/CommonCoreOntologies/raw/refs/heads/develop/src/cco-modules/InformationEntityOntology.ttl"
        "https://www.commoncoreontologies.org/", "https://github.com/CommonCoreOntology/CommonCoreOntologies/raw/refs/heads/develop/src/cco-modules/QualityOntology.ttl"
        "https://www.commoncoreontologies.org/", "https://github.com/CommonCoreOntology/CommonCoreOntologies/raw/refs/heads/develop/src/cco-modules/TimeOntology.ttl"
        "https://www.commoncoreontologies.org/",
        "https://github.com/CommonCoreOntology/CommonCoreOntologies/raw/refs/heads/develop/src/cco-modules/UnitsOfMeasureOntology.ttl"
        "https://www.commoncoreontologies.org/BarcodeOntology/",
        "https://github.com/CommonCoreOntology/CommonCoreOntologies/raw/refs/heads/develop/src/cco-extensions/BarcodeOntology.ttl"
        "https://www.commoncoreontologies.org/FamilialRelationsOntology",
        "https://github.com/CommonCoreOntology/CommonCoreOntologies/raw/refs/heads/develop/src/cco-extensions/FamilialRelationsOntology.ttl"
        "https://www.commoncoreontologies.org/mro/",
        "https://github.com/CommonCoreOntology/CommonCoreOntologies/raw/refs/heads/develop/src/cco-extensions/ModalRelationOntology.ttl"
        "https://www.gleif.org/ontology/Base/", "https://www.gleif.org/ontology/v1.0/Base/ontology.ttl"
        "https://www.gleif.org/ontology/EntityLegalForm/", "https://www.gleif.org/ontology/v1.0/EntityLegalForm/ontology.ttl"
        "https://www.gleif.org/ontology/L1/", "https://www.gleif.org/ontology/pylodev2/data_file.ttl"
        "https://www.gleif.org/ontology/L1/", "https://www.gleif.org/ontology/v1.0/L1/ontology.ttl"
        "https://www.gleif.org/ontology/L2/", "https://www.gleif.org/ontology/v1.0/L2/ontology.ttl"
        "https://www.gleif.org/ontology/L2Parent/", "https://www.gleif.org/ontology/v1.0/L2Parent/ontology.ttl"
        "https://www.gleif.org/ontology/RegistrationAuthority/", "https://www.gleif.org/ontology/v1.0/RegistrationAuthority/ontology.ttl"
        "https://www.gleif.org/ontology/ReportingException/", "https://www.gleif.org/ontology/v1.0/ReportingException/ontology.ttl"
        "https://www.ica.org/standards/RiC/ontology#", "https://www.ica.org/standards/RiC/RiC-O_1-1.rdf"
        "https://www.omg.org/spec/Commons/AnnotationVocabulary/", "https://www.omg.org/spec/Commons/AnnotationVocabulary.ttl"
        "https://www.omg.org/spec/Commons/BusinessAuthorizations/", "https://www.omg.org/spec/Commons/BusinessAuthorizations.ttl"
        "https://www.omg.org/spec/Commons/Classifiers/", "https://www.omg.org/spec/Commons/Classifiers.ttl"
        "https://www.omg.org/spec/Commons/CodesAndCodeSets/", "https://www.omg.org/spec/Commons/CodesAndCodeSets.ttl"
        "https://www.omg.org/spec/Commons/Collections/", "https://www.omg.org/spec/Commons/Collections.ttl"
        "https://www.omg.org/spec/Commons/ContextualDesignators/", "https://www.omg.org/spec/Commons/ContextualDesignators.ttl"
        "https://www.omg.org/spec/Commons/ContextualIdentifiers/", "https://www.omg.org/spec/Commons/ContextualIdentifiers.ttl"
        "https://www.omg.org/spec/Commons/DatesAndTimes/", "https://www.omg.org/spec/Commons/DatesAndTimes.ttl"
        "https://www.omg.org/spec/Commons/Designators/", "https://www.omg.org/spec/Commons/Designators.ttl"
        "https://www.omg.org/spec/Commons/Documents/", "https://www.omg.org/spec/Commons/Documents.ttl"
        "https://www.omg.org/spec/Commons/Identifiers/", "https://www.omg.org/spec/Commons/Identifiers.ttl"
        "https://www.omg.org/spec/Commons/Locations/", "https://www.omg.org/spec/Commons/Locations.ttl"
        "https://www.omg.org/spec/Commons/Organizations/", "https://www.omg.org/spec/Commons/Organizations.ttl"
        "https://www.omg.org/spec/Commons/PartiesAndSituations/", "https://www.omg.org/spec/Commons/PartiesAndSituations.ttl"
        "https://www.omg.org/spec/Commons/QuantitiesAndUnits/", "https://www.omg.org/spec/Commons/QuantitiesAndUnits.ttl"
        "https://www.omg.org/spec/Commons/RegistrationAuthorities/", "https://www.omg.org/spec/Commons/RegistrationAuthorities.ttl"
        "https://www.omg.org/spec/Commons/RegulatoryAgencies/", "https://www.omg.org/spec/Commons/RegulatoryAgencies.ttl"
        "https://www.omg.org/spec/Commons/RolesAndCompositions/", "https://www.omg.org/spec/Commons/RolesAndCompositions.ttl"
        "https://www.omg.org/spec/Commons/SitesAndFacilities/", "https://www.omg.org/spec/Commons/SitesAndFacilities.ttl"
        "https://www.omg.org/spec/Commons/TextDatatype/", "https://www.omg.org/spec/Commons/TextDatatype.ttl"
        "https://www.omg.org/spec/LCC/Countries/CountryRepresentation/", "https://www.omg.org/spec/LCC/Countries/CountryRepresentation.ttl"
        "https://www.omg.org/spec/LCC/Countries/ISO3166-1-CountryCodes/", "https://www.omg.org/spec/LCC/Countries/ISO3166-1-CountryCodes.ttl"
        "https://www.omg.org/spec/LCC/Countries/Regions/ISO3166-2-SubdivisionCodes-CA/", "https://www.omg.org/spec/LCC/Countries/Regions/ISO3166-2-SubdivisionCodes-CA.ttl"
        "https://www.omg.org/spec/LCC/Countries/Regions/ISO3166-2-SubdivisionCodes-GB/", "https://www.omg.org/spec/LCC/Countries/Regions/ISO3166-2-SubdivisionCodes-GB.ttl"
        "https://www.omg.org/spec/LCC/Countries/Regions/ISO3166-2-SubdivisionCodes-MX/", "https://www.omg.org/spec/LCC/Countries/Regions/ISO3166-2-SubdivisionCodes-MX.ttl"
        "https://www.omg.org/spec/LCC/Countries/Regions/ISO3166-2-SubdivisionCodes-US/", "https://www.omg.org/spec/LCC/Countries/Regions/ISO3166-2-SubdivisionCodes-US.ttl"
        "https://www.w3.org/ns/activitystreams#", "https://www.w3.org/ns/activitystreams-owl"
        "https://www.w3.org/ns/posix/stat#", "https://www.w3.org/ns/posix/stat.rdf"
    |]
    |> Array.map (fun (namespaceName, namespaceDistribution) -> DomUrl namespaceName, DomUrl namespaceDistribution)

// TODO move somewhere else
type RDFNamespace with
    member this.asPrefixId = {
        prefixLabel = this.NamespacePrefix
        namespaceName = this.NamespaceUri.OriginalString
    }

let chrome = CdpBrowser.Connect()

let missingNamespaceDistributions =
    singletonDistributions
    |> Array.filter (fun (namespaceName, namespaceDistribution) ->
        let namespaceFile = Path.Combine(namespaceName.asFolder.FullName, "text", "turtle.ttl") |> FileInfo
        not namespaceFile.Exists)



// missingNamespaceDistributions
let downloadDistributions (distributionFilter: DomUrl * DomUrl -> bool) (distributions: array<DomUrl * DomUrl>) =

    distributions
    |> Array.filter distributionFilter
    |> Array.Parallel.iter (fun (namespaceName, namespaceDistribution) ->
        printfn "%s %s" namespaceName.Href namespaceDistribution.Href

        let options = new CreatePageOptions()
        options.Background <- true
        let distributionTab = chrome.NewPageAsync(options).await.asCdp
        let distributionMimeType = MimeType.FromFileName namespaceDistribution.extension
        let distributionFile =
            Path.Combine(namespaceName.asFolder.FullName, distributionMimeType.MediaType, $"{distributionMimeType.SubType}{namespaceDistribution.extension}")
            |> FileInfo

        let downloadedFile =
            Path.Combine(Folder.Downloads.FullName, namespaceDistribution.fileName)
            |> FileInfo

        let maybeDistributionText =

            if not downloadedFile.Exists then
                try

                    printfn "%s %s trying to get text from tab" namespaceName.Href namespaceDistribution.Href
                    distributionTab.GoToAsync(namespaceDistribution.Href).await.asCdp.TextAsync().await
                    |> Some
                with _ ->

                    printfn "%s %s tab response text failed" namespaceName.Href namespaceDistribution.Href
                    if downloadedFile.Exists then
                        printfn "%s %s text found in download folder" namespaceName.Href namespaceDistribution.Href
                        File.ReadAllText(downloadedFile.FullName) |> Some
                    else
                        printfn "%s %s no text found in downloded folder" namespaceName.Href namespaceDistribution.Href
                        None
            else
                None
        match maybeDistributionText with
        | Some distributionText ->
            printfn "%s %s distribution text found" namespaceName.Href namespaceDistribution.Href

            Directory.CreateDirectory distributionFile.DirectoryName |> ignore
            File.WriteAllText(distributionFile.FullName, distributionText)
            printfn "%s %s saved text at %s" namespaceName.Href namespaceDistribution.Href distributionFile.FullName

            match namespaceDistribution.extension with
            | ".ttl" ->
                try
                    let distributionGraph = new ThreadSafeGraph()
                    FileLoader.Load(distributionGraph, distributionFile.FullName)
                    let parentDirectory = Path.Combine(namespaceName.asFolder.FullName, "text")
                    distributionGraph |> Turtle.writeIgraph parentDirectory "turtle"
                with _ ->
                    ()

            | _ -> ()

        | None -> printfn "%s %s no distribution text found" namespaceName.Href namespaceDistribution.Href

        Thread.Sleep(1000)
        distributionTab.CloseAsync() |> ignore


    )




let distributionFilter (namespaceName: DomUrl, namespaceDistribution: DomUrl) =
    namespaceName.Host = "www.semanticdesktop.org"

singletonDistributions |> downloadDistributions distributionFilter

let maybePrefixIdFromUrl (namespaceName: DomUrl) =
    match namespaceName.Href, RDFNamespaceRegister.GetByUri(namespaceName.Href, true) with
    | _, null -> None
    | _, rdfNamespace -> Some rdfNamespace.asPrefixId

Task.Run(fun () ->
    singletonDistributions
    |> Array.filter distributionFilter
    |> Array.iter (fun (namespaceName, namespaceDistribution) ->

        match maybePrefixIdFromUrl namespaceName with
        | None -> printfn "No prefix found for %s" namespaceName.Href
        | Some prefixId ->
            printfn "prefix %s found for %s" prefixId.prefixLabel prefixId.namespaceName
            let namespaceVocabulary = RdfVocabulary.fromPrefixId prefixId

            printfn "trying to write module %s for %s" namespaceVocabulary.fsxFile.FullName namespaceName.Href
            RdfVocabulary.asModule namespaceVocabulary
            |> fun fsxText -> File.WriteAllText(namespaceVocabulary.fsxFile.FullName, fsxText)


    ))

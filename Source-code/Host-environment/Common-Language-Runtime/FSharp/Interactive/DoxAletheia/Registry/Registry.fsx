#time on
fsi.ShowDeclarationValues <- false
fsi.PrintLength <- 30


open System
open System.IO
open System.Linq
open System.Collections.Generic

open System.IO.Compression


#r "nuget: FsHttp"
open FsHttp

#r "nuget: FSharp.Data"
open FSharp.Data

#r "nuget: FSharp.Collections.ParallelSeq"
open FSharp.Collections.ParallelSeq
#r "nuget: dotNetRdf"
#r "nuget: Unquote"
open Swensen.Unquote.Assertions

#r "nuget: FSharp.Json"
open FSharp.Json

open VDS.RDF
open VDS.RDF.Parsing
open VDS.RDF.JsonLd
open VDS.RDF.Query.Datasets
open VDS.RDF.Storage



#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\PowershellErgonomics.fsx"

open PowershellErgonomics

#r @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Solution\DoxAletheia\Ergonomic_Extensions\obj\Release\net10.0\Ergonomic_Extensions.dll"
open DoxAletheia
open PrettierNaming.FSharp_Keywords
open JsonErgonomics
open IOExtensions
open ArrayErgonomics
open RdfExtensions
open StringExtensions
open System.Net.Http










let manual_distributions =
    [|



       
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
       "https://www.gleif.org/ontology/L1/", "https://www.gleif.org/ontology/pylodev2/data_file.ttl"
       "http://purl.org/HDT/hdt#", "https://www.w3.org/submissions/2011/SUBM-HDT-RDFS-20110330/HDT.rdf"
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












type Iri = UriNode

type Vocabulary_Metadata = 
    {
        namespace_prefix:string
        namespace_name:string
    }

type Vocabulary(metadata: Vocabulary_Metadata) =
    let namespace_uri = new Uri(metadata.namespace_name)
    let namespace_iri = Iri(namespace_uri)
    let namespace_prefix = metadata.namespace_prefix
    member this._uri = namespace_uri
    member this._iri = namespace_iri
    member this._prefix = namespace_prefix








type PathInfo = 
    | FilePathInfo of FileInfo
    | DirectoryPathInfo of DirectoryInfo
    member this.path = 
        match this with 
        | FilePathInfo file -> file.FullName
        | DirectoryPathInfo directory -> directory.FullName
    member this.stem = 
        match this with 
        | FilePathInfo file -> Path.GetFileNameWithoutExtension file.FullName
        | DirectoryPathInfo directory -> directory.Name
    member this.extension = 
        match this with 
        | FilePathInfo file -> file.Extension.TrimStart('.')
        | DirectoryPathInfo directory -> String.Empty
    member this.as_file = 
        match this with 
        | FilePathInfo file -> file
        | DirectoryPathInfo directory -> new FileInfo(directory.FullName)
    member this.as_directory = 
        match this with 
        | FilePathInfo file -> new DirectoryInfo(file.FullName)
        | DirectoryPathInfo directory -> directory
    member this.parent_directory = 
        match this with 
        | FilePathInfo file -> file.Directory
        | DirectoryPathInfo directory -> directory.Parent
    member this.save_file_text (file_text:string) = 
        if not (this.parent_directory.Exists) then 
            Directory.CreateDirectory(this.parent_directory.FullName) |> ignore
        File.WriteAllText(this.as_file.FullName, file_text )
    member this.save_file_lines (file_lines:string array) = 
        if not (this.parent_directory.Exists) then 
            Directory.CreateDirectory(this.parent_directory.FullName) |> ignore
        File.WriteAllLines(this.as_file.FullName, file_lines )
    member this.child_files (pattern:string) = Directory.GetFiles(this.path, pattern, SearchOption.TopDirectoryOnly)
    member this.descendant_files (pattern:string) = Directory.GetFiles(this.path, pattern, SearchOption.AllDirectories)

    // TODO be mindful of unintended consequences from defaulting to directory 
    /// defaults to non existant directory 
    static member from_string (path:string) = 
    
        match File.Exists(path),Directory.Exists(path) with 
        | true,false -> new FileInfo(path) |> FilePathInfo
        | _,_ when Path.EndsInDirectorySeparator path -> new DirectoryInfo(path) |> DirectoryPathInfo
        | _,_ when Path.GetExtension(path).TrimStart('.').Length > 0 -> new FileInfo(path) |> FilePathInfo
        | _,_ -> new DirectoryInfo(path) |> DirectoryPathInfo


let (!/) (root_path:string) = PathInfo.from_string root_path 
let (./) (parent:PathInfo) (relative:string) = 
    Path.Combine(parent.path,relative) |> PathInfo.from_string

module Folder = 
    let DoxAletheia = !/ @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia"

    let Vocabulary = DoxAletheia ./ "Vocabulary"
    let https = Vocabulary ./ "https"
    let Downloaded = Vocabulary ./ "Downloaded"
    let Authored = Vocabulary ./ "Authored"
    let Manual = Vocabulary ./ "Manual"
    let fibo = Vocabulary ./ @"https\spec.edmcouncil.org"



module Document =
    module manual_name_distribution = 
        [<Literal>]
        let literal_path = @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Registry\manual_name_distribution.csv"
        let csv() = CsvProvider<literal_path>.Load literal_path
    let manual_metadata = Folder.Manual ./ "manual_metadata.json"
    module Bioregistry = 
        let registry = JsonProvider<"https://github.com/biopragmatics/bioregistry/raw/refs/heads/main/src/bioregistry/data/bioregistry.json">.Load "https://github.com/biopragmatics/bioregistry/raw/refs/heads/main/src/bioregistry/data/bioregistry.json"
    module lov = 
    
        [<Literal>]
        let filePath =
            @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\lov.vocabulary.json"

        let json = JsonProvider<filePath>.Load filePath


    module prefixcc =
        [<Literal>]
        let filePath =
            @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\prefix.cc.json"

        let json = JsonProvider<filePath>.Load filePath


// ensure 1 to 1 
test <@ 
        Document.manual_name_distribution.csv().Rows
        |> PSeq.map (fun row -> row.Namespace_name, row.Namespace_distribution)
        |> PSeq.groupBy (fun (namespace_name, namespace_distribution) -> namespace_name)
        |> PSeq.filter (fun (namespace_name, distributions) -> distributions.Count() > 1)
        |> PSeq.isEmpty
    @>







let log_lines = new ResizeArray<string>()






module fibo =
    let distribution_probe = 
        http {
            GET "https://github.com/edmcouncil/fibo/releases/latest"
        }
        |> Request.send
    let download_distribution (distribution:string) =
        http {

            GET distribution

        }
        |> Request.send

    let extraction_directory = Folder.Vocabulary ./ @"https\spec.edmcouncil.org"

    let latest_source = distribution_probe.originalHttpResponseMessage.RequestMessage.RequestUri.OriginalString + ".zip"
    printfn "latest fibo source: %s" latest_source

        

    let file_name = 
        (iri_to_relative_path latest_source).Replace("\\bare", "").Split("\\")
        |> Array.last
    let version = 
        let master_ = "master_" 
        let zip = ".zip" 
        file_name[master_.Length..file_name.Length-zip.Length-1]
    printfn "latest fibo version: %s" version

    let content_directory = extraction_directory ./ $@"fibo\ontology\master\{version}"
    if not content_directory.as_directory.Exists then 
        Directory.CreateDirectory(content_directory.path) |> ignore

    let fibo_zip = content_directory ./ @"prod.ttl.zip"

    if not fibo_zip.as_file.Exists then 
        let distribution = $"https://spec.edmcouncil.org/fibo/ontology/master/{version}/prod.ttl.zip"
        printfn "downloading fibo version %s" version
        let response = download_distribution distribution

        if response.originalHttpResponseMessage.IsSuccessStatusCode then
            Response.saveFile fibo_zip.as_file.FullName response
            if not Folder.fibo.as_directory.Exists then
                Directory.CreateDirectory(Folder.fibo.path) |> ignore
            ZipFile.ExtractToDirectory(fibo_zip.as_file.FullName, Folder.fibo.as_directory.FullName)
        printfn "fibo version %s download complete" version
    else 
        printfn "fibo version %s already downloaded" version

    let vocabulary_files =
        content_directory.descendant_files "*.ttl"
    

    let namespaces_from_files =
        vocabulary_files
        // |> Array.randomSample 10
        |> Array.Parallel.collect (fun rdf_file ->

            try

                let file_graph = new ThreadSafeGraph()
                FileLoader.Load(file_graph, rdf_file)

                file_graph.NamespaceMap.Prefixes
                |> Seq.map (fun prefix ->
                    let namespace_uri = file_graph.NamespaceMap.GetNamespaceUri prefix

                    (namespace_uri.OriginalString, prefix)

                )
                |> Seq.toArray

            with 
            | err -> 
                log_lines.Add(sprintf "%s %s   errored with %s" (nameof rdf_file) rdf_file err.Message) 
                [||]
        )
        |> Array.distinct

    let metadata =
        printfn "processing fibo metadata"
        vocabulary_files
        |> Array.Parallel.choose (fun ttl_path ->
            let file_stem = Path.GetFileNameWithoutExtension ttl_path

            let type_binding =
                match file_stem with
                | prefix when reserved_keywords.Contains(prefix) -> $"{prefix}_"
                | _ -> file_stem.Replace('-', '_').Replace('.', '_')

            let from_index = Folder.https.path.Length + 1

            let to_index =
                ttl_path.ToCharArray()
                |> Array.reversible_index -4

            let subpath =
                ttl_path[from_index..to_index]
                    .Replace("\\", "/")
                    .Replace($"/master/{version}", "")

            let reconstructed_namespace = $"https://{subpath}/"

            let maybe_namespace_prefix =
                namespaces_from_files
                |> Array.Parallel.tryFind (fun (namespace_name, prefix_label) ->
                    namespace_name = reconstructed_namespace

                )

            match maybe_namespace_prefix with
            | Some (namespace_name, prefix_label) -> 
                    Some {
                            namespace_prefix = prefix_label
                            namespace_name = namespace_name
                        }
            | None -> None)

    test <@ vocabulary_files.Length = metadata.Length @>
    printfn "fibo metadata complete"




























let manual_namespace_names = 
                    Document.manual_name_distribution.csv().Rows
                            |> PSeq.map (fun row -> row.Namespace_name)
                            |> PSeq.toArray
let prefixcc_namespace_names = 

                Document.prefixcc.json.JsonValue.AsRecord
                |> Array.Parallel.map (fun (key,value) -> value.AsString())

let lov_namespace_names =
    Document.lov.json
    |> Array.Parallel.map (fun vocabulary -> vocabulary.Nsp)

let filesystem_namespace_names = 
    Folder.Vocabulary.descendant_files "*.ttl"
    |> Array.Parallel.filter (fun file_path -> not (file_path.Contains(@"https\spec.edmcouncil.org\fibo")))
    |> Array.Parallel.collect (fun file_path ->
        try


            let file_graph = new ThreadSafeGraph()
            FileLoader.Load(file_graph, file_path)

            file_graph.NamespaceMap.Prefixes
            |> Seq.map (fun prefix ->
                let namespace_uri = file_graph.NamespaceMap.GetNamespaceUri prefix

                namespace_uri.OriginalString

            )
            |> Seq.toArray
        with 
        | err -> 
            log_lines.Add(sprintf "filepath %s   errored with %s" file_path err.Message) 
            [||]
    )





let prefixcc_namespace_pair = 

                Document.prefixcc.json.JsonValue.AsRecord
                |> Array.Parallel.map (fun (key,value) -> value.AsString(), key)

let lov_namespace_pair =
    Document.lov.json
    |> Array.Parallel.map (fun vocabulary -> vocabulary.Nsp, vocabulary.Prefix)

let filesystem_namespace_pair = 
    Folder.Vocabulary.descendant_files "*.ttl"
    |> Array.Parallel.filter (fun file_path -> not (file_path.Contains(@"https\spec.edmcouncil.org\fibo")))
    |> Array.Parallel.collect (fun file_path ->

        try

            let file_graph = new ThreadSafeGraph()
            FileLoader.Load(file_graph, file_path)

            file_graph.NamespaceMap.Prefixes
            |> Seq.map (fun prefix ->
                let namespace_uri = file_graph.NamespaceMap.GetNamespaceUri prefix

                namespace_uri.OriginalString, prefix

            )
            |> Seq.toArray

        with 
        | err -> 
            log_lines.Add(sprintf "filepath %s   errored with %s" file_path err.Message) 
            [||]
    )


let normalize_namespace_name (namespace_name: string) =
    let normalized = namespace_name.circumtrimmed

    if String.IsNullOrWhiteSpace normalized then
        invalidArg (nameof namespace_name) "A namespace IRI cannot be empty."

    normalized

let normalize_prefix_label (prefix_label: string) =
    let normalized = prefix_label.circumtrimmed

    if String.IsNullOrWhiteSpace normalized then
        invalidArg (nameof prefix_label) "A prefix label cannot be empty."

    normalized

let namespace_names = 
    Array.concat [|
        manual_namespace_names
        prefixcc_namespace_names
        lov_namespace_names
        filesystem_namespace_names
    |]
    |> Array.filter (fun namespace_name -> not (String.IsNullOrWhiteSpace namespace_name))
    |> Array.map normalize_namespace_name
    |> Array.distinct
    |> Array.sort

let namespace_pairs = 
    Array.concat [|
        prefixcc_namespace_pair
        lov_namespace_pair
        filesystem_namespace_pair
    |]
    |> Array.filter (fun (namespace_name, prefix_label ) -> not (String.IsNullOrWhiteSpace prefix_label))
    |> Array.map (fun (namespace_name, prefix_label ) -> normalize_namespace_name namespace_name,normalize_prefix_label prefix_label)
    |> Array.distinct
    |> Array.sort















let prefixes_grouped_by_namespace =
    namespace_pairs
    |> Array.groupBy(fun (namespace_name, prefix_label) -> namespace_name)
    |> Array.map (fun (namespace_name,pairs) -> namespace_name, pairs |> Array.map (fun (_,prefix_label) -> prefix_label) |> Array.sortBy(fun prefix_label -> prefix_label.Length))
let namespaces_grouped_by_prefix =
    namespace_pairs
    |> Array.groupBy(fun (namespace_name, prefix_label) -> prefix_label)
    |> Array.map (fun (prefix_label,pairs) -> prefix_label, pairs |> Array.map (fun (namespace_name,_) -> namespace_name) |> Array.sort)

let namespaces_with_singular_prefix = 
    prefixes_grouped_by_namespace
    |> Array.Parallel.filter (fun (namespace_name,prefixes) -> prefixes.Length = 1)
let namespaces_with_multiple_prefixes = 
    prefixes_grouped_by_namespace
    |> Array.Parallel.filter (fun (namespace_name,prefixes) -> prefixes.Length > 1)




let prefixes_with_singular_namespaces = 
    namespaces_grouped_by_prefix
    |> Array.Parallel.filter (fun (prefix,namespace_names) -> namespace_names.Length = 1)
let prefixes_with_multiple_namespaces = 
    namespaces_grouped_by_prefix
    |> Array.Parallel.filter (fun (prefix,namespace_names) -> namespace_names.Length > 1)




[<StructuralEquality; StructuralComparison>]
type Namespace_Prefix_Vertex =
    | Namespace of namespace_name: string
    | Prefix of prefix_label: string

type Namespace_Prefix_Component_Kind =
    | Missing_Prefix
    | Unambiguous
    | Prefix_Aliases
    | Prefix_Collision
    | Entangled_Conflict

type Namespace_Prefix_Component =
    {
        namespaces: string array
        prefixes: string array
        kind: Namespace_Prefix_Component_Kind
    }

let namespace_prefix_components
    (namespace_names: string array)
    (namespace_pairs: (string * string) array)
    =
    let adjacency =
        Dictionary<
            Namespace_Prefix_Vertex,
            ResizeArray<Namespace_Prefix_Vertex>
         >()

    let ensure_vertex vertex =
        if not (adjacency.ContainsKey vertex) then
            adjacency.Add(vertex, ResizeArray())

    let add_edge left right =
        ensure_vertex left
        ensure_vertex right
        adjacency[left].Add right

    // Include namespaces for which no prefix candidate exists.
    for namespace_name in namespace_names do
        ensure_vertex (Namespace namespace_name)

    for namespace_name, prefix_label in namespace_pairs do
        let namespace_vertex = Namespace namespace_name
        let prefix_vertex = Prefix prefix_label

        add_edge namespace_vertex prefix_vertex
        add_edge prefix_vertex namespace_vertex

    let visited = HashSet<Namespace_Prefix_Vertex>()
    let components = ResizeArray<Namespace_Prefix_Component>()

    for starting_vertex in adjacency.Keys do
        if not (visited.Contains starting_vertex) then
            let queue = Queue<Namespace_Prefix_Vertex>()
            let component_vertices =
                ResizeArray<Namespace_Prefix_Vertex>()

            queue.Enqueue starting_vertex

            while queue.Count > 0 do
                let current_vertex = queue.Dequeue()

                if visited.Add current_vertex then
                    component_vertices.Add current_vertex

                    for adjacent_vertex in adjacency[current_vertex] do
                        if not (visited.Contains adjacent_vertex) then
                            queue.Enqueue adjacent_vertex

            let namespaces =
                component_vertices
                |> Seq.choose (function
                    | Namespace namespace_name ->
                        Some namespace_name
                    | Prefix _ ->
                        None
                )
                |> Seq.sort
                |> Seq.toArray

            let prefixes =
                component_vertices
                |> Seq.choose (function
                    | Prefix prefix_label ->
                        Some prefix_label
                    | Namespace _ ->
                        None
                )
                |> Seq.sortBy (fun prefix_label ->
                    prefix_label.Length,
                    prefix_label
                )
                |> Seq.toArray

            let kind =
                match namespaces.Length, prefixes.Length with
                | 1, 0 ->
                    Missing_Prefix

                | 1, 1 ->
                    Unambiguous

                | 1, prefix_count when prefix_count > 1 ->
                    Prefix_Aliases

                | namespace_count, 1 when namespace_count > 1 ->
                    Prefix_Collision

                | namespace_count, prefix_count
                    when namespace_count > 1
                    && prefix_count > 1 ->
                    Entangled_Conflict

                | namespace_count, prefix_count ->
                    failwithf
                        "Unexpected component shape: %i namespaces and %i prefixes."
                        namespace_count
                        prefix_count

            components.Add {
                namespaces = namespaces
                prefixes = prefixes
                kind = kind
            }

    components
    |> Seq.sortBy (fun component_ ->
        component_.kind,
        component_.namespaces |> Array.tryHead,
        component_.prefixes |> Array.tryHead
    )
    |> Seq.toArray

let candidate_components =
    namespace_prefix_components
        namespace_names
        namespace_pairs

let unresolved_components =
    candidate_components
    |> Array.filter (fun component_ ->
        component_.kind <> Unambiguous
    )

let missing_prefix_components =
    candidate_components
    |> Array.filter (fun component_ ->
        component_.kind = Missing_Prefix
    )

let prefix_alias_components =
    candidate_components
    |> Array.filter (fun component_ ->
        component_.kind = Prefix_Aliases
    )

let prefix_collision_components =
    candidate_components
    |> Array.filter (fun component_ ->
        component_.kind = Prefix_Collision
    )

let entangled_conflict_components =
    candidate_components
    |> Array.filter (fun component_ ->
        component_.kind = Entangled_Conflict
    )















type Unresolved_Namespace =
    | No_Prefix_Candidates of namespace_name: string
    | All_Prefix_Candidates_Claimed of
        namespace_name: string *
        prefix_candidates: string array
    member this.namespace_name = 
        match this with 
        | No_Prefix_Candidates name -> name
        | All_Prefix_Candidates_Claimed (name,_) -> name

type Namespace_Prefix_Resolution =
    {
        resolved: (string * string) array
        unresolved: Unresolved_Namespace array
    }

let resolve_namespace_prefixes
    (namespace_names: string array)
    (namespace_pairs: (string * string) array)
    (manual_overrides: Map<string, string>)
    : Namespace_Prefix_Resolution
    =

    let order_prefixes prefixes =
        prefixes
        |> Array.distinct
        |> Array.sortWith (fun (left:string) (right:string) ->
            let by_length =
                compare right.Length left.Length

            if by_length <> 0 then
                by_length
            else
                StringComparer.Ordinal.Compare(left, right)
        )

    let prefixes_by_namespace =
        namespace_pairs
        |> Array.groupBy fst
        |> Array.map (fun (namespace_name, pairs) ->
            namespace_name,
            pairs
            |> Array.map snd
            |> order_prefixes
        )
        |> Map.ofArray

    let all_namespaces =
        Array.concat [|
            namespace_names
            namespace_pairs |> Array.map fst
            manual_overrides |> Map.toArray |> Array.map fst
        |]
        |> Array.distinct
        |> Array.sort

    let conflicting_manual_overrides =
        manual_overrides
        |> Map.toArray
        |> Array.groupBy snd
        |> Array.filter (fun (_, assignments) ->
            assignments.Length > 1
        )

    if conflicting_manual_overrides.Length > 0 then
        let conflicts =
            conflicting_manual_overrides
            |> Array.map (fun (prefix_label, assignments) ->
                let namespaces =
                    assignments
                    |> Array.map fst
                    |> String.concat ", "

                sprintf "%s → %s" prefix_label namespaces
            )
            |> String.concat Environment.NewLine

        failwithf
            "Manual overrides assign the same prefix to multiple namespaces:%s%s"
            Environment.NewLine
            conflicts

    let used_prefixes =
        HashSet<string>(StringComparer.Ordinal)

    let resolved =
        ResizeArray<string * string>()

    let unresolved =
        ResizeArray<Unresolved_Namespace>()

    // Manual overrides are authoritative and reserve their prefixes first.
    for KeyValue(namespace_name, prefix_label) in manual_overrides do
        if String.IsNullOrWhiteSpace prefix_label then
            invalidArg
                (nameof manual_overrides)
                (sprintf
                    "The manual prefix for %s is empty."
                    namespace_name)

        used_prefixes.Add prefix_label
        |> ignore

        resolved.Add(namespace_name, prefix_label)

    let automatically_resolved_namespaces =
        all_namespaces
        |> Array.filter (fun namespace_name ->
            not (manual_overrides.ContainsKey namespace_name)
        )
        |> Array.sortBy (fun namespace_name ->
            let candidate_count =
                prefixes_by_namespace
                |> Map.tryFind namespace_name
                |> Option.map Array.length
                |> Option.defaultValue 0

            // Resolve namespaces with fewer alternatives first.
            candidate_count,
            namespace_name
        )

    for namespace_name in automatically_resolved_namespaces do
        let candidates =
            prefixes_by_namespace
            |> Map.tryFind namespace_name
            |> Option.defaultValue [||]

        match candidates with
        | [||] ->
            unresolved.Add(
                No_Prefix_Candidates namespace_name
            )

        | _ ->
            match
                candidates
                |> Array.tryFind (fun prefix_label ->
                    not (used_prefixes.Contains prefix_label)
                )
            with
            | Some prefix_label ->
                used_prefixes.Add prefix_label
                |> ignore

                resolved.Add(namespace_name, prefix_label)

            | None ->
                unresolved.Add(
                    All_Prefix_Candidates_Claimed(
                        namespace_name,
                        candidates
                    )
                )

    {
        resolved =
            resolved
            |> Seq.sortBy fst
            |> Seq.toArray

        unresolved =
            unresolved
            |> Seq.toArray
    }


let manual_prefix_overrides =
    Map.ofArray  [|

        "http://rdfs.co/juso/", "juso"
        "http://bblfish.net/work/atom-owl/2006-06-06/", "atomowl"
        "http://rdfs.co/juso/kr/0.1", "jusokr"
        "https://w3id.org/squap/", "squap"
        "http://ns.inria.fr/munc/", "munc"
        "http://w3id.org/rml/io/", "rml_io"
        "http://w3id.org/rml/cc/", "rml_cc"
        "http://w3id.org/rml/fnml/", "rml_fnml"
        "http://purl.org/limo-ontology/limo/", "limo"
        "http://w3id.org/rml/star/", "rml_star"
        "http://www.w3.org/2006/time#", "owl_time"
        "https://w3id.org/dingo/", "dingo"
        "http://ns.inria.fr/semed/eduprogression/", "eduprog"
        "https://w3id.org/aerOS/data-catalog#", "aosdatcat"
        "http://www.w3.org/2000/10/swap/pim/doc#", "swap_doc"
        "http://ns.ottr.xyz/0.4/", "ottr"
        "https://w3id.org/aerOS/continuum#", "aoscon"
        "https://w3id.org/sulo/sulo/", "sulo"
        "https://w3id.org/nen2660/", "nen2660"
        "http://www.observedchange.com/moac/ns#", "moac"
        "http://www.observedchange.com/tisc/ns#", "tisc"
        "https://w3id.org/i40/rami/", "rami"
        "http://advene.org/ns/cinelab/ld#", "cinelab"
        "http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#", "personlink"
        "http://data.ign.fr/ontologies/geofla#", "geofr"
        "http://dati.senato.it/osr/", "senatosr"
        "http://elite.polito.it/ontologies/dogont.owl#", "dogontowl"
        "http://lod.xdams.org/reload/oad/", "reload"
        "http://ltsc.ieee.org/rdf/lomv1p0/lom#", "lomv1p"
        "http://mu.semte.ch/vocabularies/ext/", "vocext"
        "http://ns.inria.fr/ludo/v1#", "ludov1"
        "http://ns.inria.fr/prissma/v2#", "prissmav2"
        "http://ns.inria.fr/provoc/", "provocfr"
        "http://ontology.eil.utoronto.ca/icontact.owl#", "icontact"
        "http://opencoinage.org/rdf/", "ocoinage"
        "http://opendata.caceres.es/def/ontomunicipio#", "onmunpio"
        "http://poderopedia.com/vocab/", "poderopedia"
        "http://purl.org/LiMo/0.1/", "LiMo"
        "http://purl.org/NET/cloudisus#", "netcloudisus"
        "http://purl.org/ctic/infraestructuras/localizacion#", "ctic"
        "http://purl.org/essglobal/vocab/v1.0/", "essglobalv1"
        "http://purl.org/foodontology#", "foodont"
        "http://purl.org/net/hifm/ontology#", "hifm"
        "http://purl.org/ontology/dvia#", "dviont"
        "http://purl.org/qb4olap/cubes#", "qb4olap"
        "http://purl.org/twc/ontology/cdm.owl#", "twcdm"
        "http://purl.org/voc/uneskos#", "vocuneskos"
        "http://purl.uniprot.org/taxonomy/", "uniprotax"
        "http://qudt.org/vocab/sou/", "qudtsou"
        "http://rdfs.org/ns/void-ext#", "extvoid"
        "http://search.yahoo.com/searchmonkey/media/", "searchmonkey"
        "http://semweb.mmlab.be/ns/stoptimes#", "mmlab"
        "http://simile.mit.edu/2003/10/ontologies/vraCore3#", "mitvraCore"
        "http://sparql.cwrc.ca/ontology/cwrc#", "cacwrc"
        "http://static.datafoodconsortium.org/ontologies/DFC_FullModel.owl#", "datafoodconsortium"
        "http://sw.deri.org/2005/08/conf/cfp.owl#", "confp.owl"
        "http://purl.org/essglobal/vocab/", "essglobal"
        "http://umbel.org/umbel/ac/", "umbelac"
        "http://vcharpenay.github.io/hto/hto.xml#", "hto"
        "http://voag.linkedmodel.org/voag#", "voagm"
        "http://project-haystack.org/hto#", "haystack"
        "http://vocab.deri.ie/am#", "ieam"
        "http://vocab.deri.ie/orca#", "ieorca"
        "http://vocab.deri.ie/raul#", "ieraul"
        "http://vocab.deri.ie/tao#", "ietao"
        "http://vocab.sti2.at/vsearch#", "atvsearch"
        "http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#", "conel"
        "http://www.bbc.co.uk/ontologies/news/", "bbcnews"
        "http://www.bbc.co.uk/ontologies/sport/", "bbcsport"
        "http://www.data-knowledge.org/dk/schema/rdf/latest/", "dataknowledge"
        "http://www.essepuntato.it/2013/03/cito-functions/", "cito-func"
        "http://www.eurocris.org/ontologies/cerif/1.3#", "cerif13"
        "http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#", "VoIDWarehouse"
        "http://www.identity.org/ontologies/identity.owl#", "identitorg"
        "http://www.kanzaki.com/ns/music#", "kanzaki"
        "http://www.lexinfo.net/ontology/3.0/lexinfo#", "lexinfov3"
        "http://www.loc.gov/premis/rdf/v3/", "premisv3"
        "http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl#", "odptimeindexedsituation"
        "http://www.purl.org/limo-ontology/limo#", "limont"
        "http://www.rkbexplorer.com/ontologies/acm#", "rkacm"
        "http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#", "connectype"
        "http://www.w3.org/2001/02pd/rec54.rdf#", "rec54rdf"
        "http://www.w3.org/2004/03/trix/swp-2/", "trixswp-2"
        "http://www.w3.org/ns/md#", "nsmd"
        "http://datashapes.org/graphql#", "dsgraphql"
        "https://graphql.org/", "graphql"
        "https://id.parliament.uk/schema/", "schema"
        "http://purl.org/net/hifm/data#", "hifmdata"
        "https://linkeddata.cultureelerfgoed.nl/def/ceo#", "ceo"
        "https://privatealpha.com/ontology/ibis/1#", "paibis"
        "https://privatealpha.com/ontology/transformation/1#", "patransform"
        "https://test4.example.com/", "test4"
        "https://triplydb.com/Triply/tp/def/", "triply"
        "https://w3id.org/TRO/", "w3TRO"
        "https://w3id.org/amv/", "w3amv"
        "https://w3id.org/dco#", "w3dco"
        "https://w3id.org/def/foo#", "w3foo"
        "https://w3id.org/def/och#", "w3och"
        "https://w3id.org/def/saref4bldg#", "sarefforbldg"
        "https://w3id.org/dpv#", "w3dpv"
        "https://w3id.org/dt#", "w3dt"
        "https://w3id.org/env/puv#", "envpuv"
        "https://w3id.org/ifc/IFC4_ADD1#", "ifcadd"
        "https://w3id.org/legalhtml/ov#", "legalhtml"
        "https://w3id.org/loin#", "w3loin"
        "https://w3id.org/mdo/full/", "mdofull"
        "https://w3id.org/mdr#", "w3mdr"
        "https://w3id.org/multidimensional-interface/ontology#", "multont"
        "https://w3id.org/seo#", "w3seo"
        "https://w3id.org/vocab/olca#", "w3olca"
        "https://w3id.org/xapi/ontology#", "w3xapi"


        "http://eulersharp.sourceforge.net/2003/03swap/coding#", "swapcoding"
        "http://eulersharp.sourceforge.net/2003/03swap/computer#", "swapcomputer"
        "http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#", "swapdecisionSupport"
        "http://eulersharp.sourceforge.net/2003/03swap/digitalProcedure#", "swapdigitalProcedure"
        "http://eulersharp.sourceforge.net/2003/03swap/document#", "swapdocument"
        "http://eulersharp.sourceforge.net/2003/03swap/foster#", "swapfoster"
        "http://eulersharp.sourceforge.net/2003/03swap/physicalResource#", "swapphysicalResource"
        "http://eulersharp.sourceforge.net/2003/03swap/quantities#", "swapquantities"
        "http://eulersharp.sourceforge.net/2003/03swap/space#", "swapspace"
        "http://eulersharp.sourceforge.net/2003/03swap/sparql#", "swapsparql"
        "http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysis#", "swapsparqlAnalysis"
        "http://eulersharp.sourceforge.net/2003/03swap/sparqlAnalysisTemplate#", "swapsparqlAnalysisTemplate"
        "http://eulersharp.sourceforge.net/2003/03swap/substanceForms#", "swapsubstanceForms"
        "http://eulersharp.sourceforge.net/2003/03swap/time#", "swaptime"
        "http://eulersharp.sourceforge.net/2003/03swap/weekScheme#", "swapweekScheme"
        "http://eulersharp.sourceforge.net/2003/03swap/workflow#", "swapworkflow"
        "http://aims.fao.org/aos/agrontology#", "aos"
        "http://open-services.net/ns/am#", "osam"
        "http://open-services.net/ns/auto#", "osauto"
        "http://open-services.net/ns/cm#", "oscm"
        "http://open-services.net/ns/config#", "osconfig"
        "http://open-services.net/ns/core/trs#", "ostrs"
        "http://open-services.net/ns/core/trspatch#", "ostrspatch"
        "http://open-services.net/ns/qm#", "osqm"
        "http://open-services.net/ns/rm#", "osrm"
        "http://open-services.net/ns/sysmlv2#", "ossysmlv2"
        "http://purl.org/HDT/hdt#", "hdt"

        "http://purl.org/dcx/lrmi-terms/", "dcxlrmi"
        "http://purl.org/dcx/lrmi-vocabs/alignmentType/", "lrmialignmentType"
        "http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/", "lrmieducationalAudienceRole"
        "http://purl.org/dcx/lrmi-vocabs/educationalUse/", "lrmieducationalUse"
        "http://purl.org/dcx/lrmi-vocabs/interactivityType/", "lrmiinteractivityType"
        "http://purl.org/dcx/lrmi-vocabs/learningResourceType/", "lrmilearningResourceType"

        "http://purl.org/spar/bido/", "sparbido"
        "http://purl.org/spar/fivestars/", "sparfivestars"
        "http://purl.org/spar/fr/", "sparfr"
        "http://purl.org/spar/frbr/", "sparfrbr"
        "http://purl.org/spar/mito/", "sparmito"
        "http://purl.org/swan/2.0/", "swan"
        "http://purl.org/swan/2.0/collections/", "swancollections"
        "http://purl.org/swan/2.0/discourse-elements/", "swandiscourse-elements"
        "http://purl.org/swan/2.0/experiment", "swanexperiment"
        "http://qudt.org/vocab/dimensionvector", "dimensionvector"
        "http://qudt.org/vocab/quantitykind", "quantitykind"
        "http://qudt.org/vocab/soqk", "qudtsoqk"
        "http://tracker.api.gnome.org/ontology/v3/mfo#", "tmfo"
        "http://tracker.api.gnome.org/ontology/v3/nao#", "tnao"
        "http://tracker.api.gnome.org/ontology/v3/nco#", "tnco"
        "http://tracker.api.gnome.org/ontology/v3/nfo#", "tnfo"
        "http://tracker.api.gnome.org/ontology/v3/nie#", "tnie"
        "http://tracker.api.gnome.org/ontology/v3/nmm#", "tnmm"
        "http://tracker.api.gnome.org/ontology/v3/nrl#", "tnrl"
        "http://tracker.api.gnome.org/ontology/v3/osinfo#", "tosinfo"
        "http://tracker.api.gnome.org/ontology/v3/slo#", "tslo"
        "http://tracker.api.gnome.org/ontology/v3/tracker#", "ttracker"
        "http://www.daml.org/services/owl-s/1.2/ActorDefault.owl#", "owlsActorDefault"
        "http://www.daml.org/services/owl-s/1.2/Grounding.owl#", "owlsGrounding"
        "http://www.daml.org/services/owl-s/1.2/GroundingDeprecatedElements.owl", "owlsGroundingDeprecatedElements"
        "http://www.daml.org/services/owl-s/1.2/Process.owl", "damlProcess"
        "http://www.daml.org/services/owl-s/1.2/Process.owl#", "owlsProcess"
        "http://www.daml.org/services/owl-s/1.2/Profile.owl#", "owlsProfile"
        "http://www.daml.org/services/owl-s/1.2/ProfileAdditionalParameters.owl#", "owlsProfileAdditionalParameters"
        "http://www.daml.org/services/owl-s/1.2/Resource.owl#", "owlsResource"
        "http://www.daml.org/services/owl-s/1.2/generic/ObjectList.owl#", "owlsObjectList"
        "http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#", "DOLCE-Lite"
        "http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#", "ExtendedDnS"
        "http://www.w3.org/2000/10/swap/pim/email#", "swapemail"
        "http://www.w3.org/2000/10/swap/pim/ical#", "swapical"
        "http://www.w3.org/2000/10/swap/pim/qif#", "swapqif"
        "http://www.w3.org/2000/10/swap/pim/travelFig#", "swaptravelFig"
        "http://www.w3.org/2000/10/swap/pim/travelTerms#", "swaptravelTerms"
        "http://www.w3.org/2000/10/swap/pim/usps#", "swapusps"
        "http://www.w3.org/2011/http-headers#", "httpheaders"
        "http://www.w3.org/2011/http-statusCodes#", "httpstatusCodes"
        "https://open-metadata.org/ontology/", "om"
        "https://spdx.org/rdf/3.1/terms/", "spdx"
        "http://spdx.org/rdf/terms#", "spdxterms"

        "http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#", "isobserv"
        "http://rdf.muninn-project.org/ontologies/appearances#", "appear"
        "https://termlex.oeg.fi.upm.es/termlex#", "termlex"
        "https://w3id.org/function/vocabulary/composition#", "w3compo"
        "https://w3id.org/function/vocabulary/implementation#", "w3imp"
        "https://www.commoncoreontologies.org/", "comcore"
        "https://www.commoncoreontologies.org/BarcodeOntology/", "comcoreBar"
        "https://www.commoncoreontologies.org/FamilialRelationsOntology", "comcoreFam"
        "https://www.omg.org/spec/Commons/BusinessAuthorizations/", "BusinessAuthorizations"
        "https://www.omg.org/spec/Commons/Classifiers/", "Classifiers"
        "https://www.omg.org/spec/Commons/CodesAndCodeSets/", "CodesAndCodeSets"
        "https://www.omg.org/spec/Commons/Collections/", "Collections"
        "https://www.omg.org/spec/Commons/ContextualDesignators/", "ContextualDesignators"
        "https://www.omg.org/spec/Commons/ContextualIdentifiers/", "ContextualIdentifiers"
        "https://www.omg.org/spec/Commons/DatesAndTimes/", "DatesAndTimes"
        "https://www.omg.org/spec/Commons/Designators/", "Designators"
        "https://www.omg.org/spec/Commons/Documents/", "Documents"
        "https://www.omg.org/spec/Commons/Identifiers/", "Identifiers"
        "https://www.omg.org/spec/Commons/Locations/", "Locations"
        "https://www.omg.org/spec/Commons/Organizations/", "Organizations"
        "https://www.omg.org/spec/Commons/PartiesAndSituations/", "PartiesAndSituations"
        "https://www.omg.org/spec/Commons/QuantitiesAndUnits/", "QuantitiesAndUnits"
        "https://www.omg.org/spec/Commons/RegistrationAuthorities/", "RegistrationAuthorities"
        "https://www.omg.org/spec/Commons/RegulatoryAgencies/", "RegulatoryAgencies"
        "https://www.omg.org/spec/Commons/RolesAndCompositions/", "RolesAndCompositions"
        "https://www.omg.org/spec/Commons/SitesAndFacilities/", "SitesAndFacilities"
        "https://www.omg.org/spec/Commons/TextDatatype/", "TextDatatype"
        "https://www.omg.org/spec/LCC/Countries/CountryRepresentation/", "CountryRepresentation"
        "https://www.omg.org/spec/LCC/Countries/ISO3166-1-CountryCodes/", "ISO3166-1-CountryCodes"
        "https://www.omg.org/spec/LCC/Countries/Regions/ISO3166-2-SubdivisionCodes-CA/", "ISO3166-2-SubdivisionCodes-CA"
        "https://www.omg.org/spec/LCC/Countries/Regions/ISO3166-2-SubdivisionCodes-GB/", "ISO3166-2-SubdivisionCodes-GB"
        "https://www.omg.org/spec/LCC/Countries/Regions/ISO3166-2-SubdivisionCodes-MX/", "ISO3166-2-SubdivisionCodes-MX"
        "https://www.omg.org/spec/LCC/Countries/Regions/ISO3166-2-SubdivisionCodes-US/", "ISO3166-2-SubdivisionCodes-US"
        "https://www.w3.org/ns/posix/stat#", "stat"
        "http://www.w3.org/ns/posix/stat#", "postat"



        

        
    |]

let resolution =
    resolve_namespace_prefixes
        namespace_names
        namespace_pairs
        manual_prefix_overrides


let unresolved_namespaces =
    resolution.unresolved

let all_prefixes_taken =
    unresolved_namespaces
    |> Array.filter (fun unresolved -> unresolved.IsAll_Prefix_Candidates_Claimed )
    |> Array.map (fun unresolved -> unresolved.namespace_name)
    |> Array.map  (fun namespace_name -> new Uri(namespace_name))
    |> Array.map (fun namespace_uri -> 
        match namespace_uri.OriginalString, namespace_uri.Segments |> Array.last  with 
        | namespace_name, "" -> sprintf "\"%s\", \"%s\"" namespace_name (namespace_uri.Segments[namespace_uri.Segments.Length - 1].Replace("/",""))
        | namespace_name, prefix_label -> sprintf "\"%s\", \"%s\"" namespace_name (prefix_label.Replace("/",""))
    
        )
    |> String.concat "\n"
    |> clip



let no_prefixes_found =
    unresolved_namespaces
    |> Array.filter (fun unresolved -> unresolved.IsNo_Prefix_Candidates )
    |> Array.map (fun unresolved -> unresolved.namespace_name)
    |> Array.map  (fun namespace_name -> new Uri(namespace_name))
    |> Array.map (fun namespace_uri -> 
        match namespace_uri.OriginalString, namespace_uri.Segments |> Array.last  with 
        | namespace_name, "" -> sprintf "\"%s\", \"%s\"" namespace_name (namespace_uri.Segments[namespace_uri.Segments.Length - 1].Replace("/",""))
        | namespace_name, prefix_label -> sprintf "\"%s\", \"%s\"" namespace_name (prefix_label.Replace("/",""))
    
        )
    |> String.concat "\n"
    |> clip


let unresolved_namespace_names = 
    resolution.unresolved
    |> Array.map (fun unresolved -> unresolved.namespace_name)






unresolved_namespace_names.Length











let prefixid =
    resolution.resolved
    |> Map.ofArray
















let default_graph = new ThreadSafeGraph()

let voaf_vocabulary =
    default_graph.CreateUriNode(UriFactory.Create("http://purl.org/vocommons/voaf#Vocabulary"))

let rdf_type =
    default_graph.CreateUriNode(UriFactory.Create("http://www.w3.org/1999/02/22-rdf-syntax-ns#type"))

let vann_preferredNamespacePrefix =
    default_graph.CreateUriNode(UriFactory.Create("http://purl.org/vocab/vann/preferredNamespacePrefix"))

let vann_preferredNamespaceUri =
    default_graph.CreateUriNode(UriFactory.Create("http://purl.org/vocab/vann/preferredNamespaceUri"))

let dcat_distribution =
    default_graph.CreateUriNode(UriFactory.Create("http://www.w3.org/ns/dcat#distribution"))

let dcat_keyword =
    default_graph.CreateUriNode(UriFactory.Create("http://www.w3.org/ns/dcat#keyword"))


let rdfs_label =
    default_graph.CreateUriNode(UriFactory.Create("http://www.w3.org/2000/01/rdf-schema#label"))

let rdfs_comment =
    default_graph.CreateUriNode(UriFactory.Create("http://www.w3.org/2000/01/rdf-schema#comment"))












































module lov =
    type Meta = { last_meta: DateTimeOffset }

    let v2Base = "https://lov.linkeddata.es/dataset/lov/api/v2"

    let excluded_graph_names =
        set [

              "http://lov_server:3333/dataset/lov"

               ]

    module vocabulary =

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
                printfn "downloading lov.n3.gz"

                if response.originalHttpResponseMessage.IsSuccessStatusCode then
                    Response.saveFile gz_path response
                    decompress_gzip_file gz_path file_path
                    let last_meta = { last_meta = DateTimeOffset.Now }
                    let meta_file_content = Json.serialize last_meta
                    File.WriteAllText(meta_file_path, meta_file_content)
                    printfn "lov.n3.gz download complete"

            let json = JsonProvider<meta_file_path>.Load meta_file_path

            if json.LastMeta.Date < DateTime.Now.Date then
                printfn "updating lov.n3.gz from %A to current" json.LastMeta.Date
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
                    |> Array.Parallel.filter (fun distribution_triple ->
                        distribution_triple.Object.NodeType = NodeType.Uri)
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
                printfn "downloading lov.nq.gz"

                if response.originalHttpResponseMessage.IsSuccessStatusCode then
                    Response.saveFile gz_path response
                    decompress_gzip_file gz_path file_path
                    normalize_nquads_file file_path normalized_path
                    write_valid_nquads_only normalized_path cleaned_path
                    let last_meta = { last_meta = DateTimeOffset.Now }
                    let meta_file_content = Json.serialize last_meta
                    File.WriteAllText(meta_file_path, meta_file_content)
                    printfn "lov.nq.gz download complete"

            let json = JsonProvider<meta_file_path>.Load meta_file_path

            if json.LastMeta.Date < DateTime.Now.Date then
                printfn "updating lov.nq.gz from %A to current" json.LastMeta.Date
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










let is_terminal_delimited (iri_string: string) =
    iri_string.EndsWith('#')
    || iri_string.EndsWith('/')

let is_not_terminal_delimited (iri_string: string) =
    not (iri_string |> is_terminal_delimited)


let absolute_graph_names =
    lov.dump.nq.graph_names
    |> Array.Parallel.filter (fun graph_name -> graph_name |> is_not_terminal_delimited)


namespace_names |> Array.tryFind(fun name  -> name.StartsWith "http://contsem.unizar.es/def/sector-publico/pproc")

lov.dump.nq.graph_names
|> Array.Parallel.filter (fun graph_name -> graph_name |> is_terminal_delimited)
let terminated_graph_namespace = 
    lov.dump.nq.graph_names
    |> Array.Parallel.filter(fun graph_name -> is_terminal_delimited graph_name)
    |> Array.Parallel.map (fun graph_name -> graph_name,graph_name )

let bare_graph_names = 
    lov.dump.nq.graph_names
    |> Array.Parallel.filter(fun graph_name -> is_not_terminal_delimited graph_name)

let bare_graph_namespace_names =
    bare_graph_names
    |> Array.map(fun graph_name  -> 
        graph_name, namespace_names 
        |> Array.Parallel.choose(fun namespace_name  -> 
            if namespace_name.StartsWith(graph_name) then 
                Some (namespace_name)
            else
                None
    )
    )
let bare_graph_namespace = 
    bare_graph_namespace_names
    |> Array.Parallel.filter (fun (graph_name, namespace_names) -> namespace_names.Length > 1)
    |> Array.Parallel.map  (fun (graph_name, namespace_names) -> graph_name, namespace_names |> Array.sortBy (fun namespace_name -> namespace_name.Length) |> Array.head)


let graph_names_missing_namespace_names = 
    bare_graph_namespace_names
    |> Array.filter (fun (graph_name, namespace_names) -> namespace_names.Length < 1)
    |> Array.map (fun (graph_name, namespace_names) -> graph_name)
    |> String.concat "\n"
    |> clip


let map_prefixes (prefix_label:string)(namespace_name:string)(graph: IGraph) =
            
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
                graph.NamespaceMap.AddNamespace(prefix_label, new Uri(namespace_name))




let lov_metadata =
        Array.concat [|
            terminated_graph_namespace
            bare_graph_namespace

        |]
        |> Array.Parallel.choose (fun (graph_name, namespace_name) -> 

        try
            let namespace_directory = Folder.Vocabulary ./ iri_to_relative_path namespace_name


            let prefix_label = prefixid[namespace_name]
            let ttl_file = namespace_directory ./ $"{prefix_label}.ttl"


            if not (ttl_file.as_file.Exists) then
                let graph = new ThreadSafeGraph()

                lov.dump.nq.dataset.LoadGraph(graph, graph_name)
                graph |> map_prefixes prefix_label namespace_name
                Console.WriteLine $"Saving {namespace_name} as {prefix_label}.ttl"
                Directory.CreateDirectory(ttl_file.parent_directory.FullName) |> ignore
                Turtle.write ttl_file.path graph

            Some {
                namespace_prefix = prefix_label
                namespace_name = namespace_name

            }

        with
        | err ->
            log_lines.Add(sprintf "lov graph_name %s  namespace_name %s errored with %s" graph_name namespace_name err.Message) 
            None
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
        log_lines.Add $"HTTP failed for {distribution}: {err.Message}"
        None

let manual_content =
    manual_distributions
    |> Array.Parallel.choose (fun (namespace_name, namespace_distribution) ->
        try

            let namespace_uri = new Uri(namespace_name)
            let distribution_uri = new Uri(namespace_distribution)

            let namespace_directory = Folder.Vocabulary ./ iri_to_relative_path namespace_name
            let prefix_label = prefixid[namespace_name]



            let ttl_file = namespace_directory ./ $"{prefix_label}.ttl"



            if not (ttl_file.as_file.Exists) then
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

                    Console.WriteLine $"Saving {namespace_name} as {prefix_label}.ttl"
                    graph |> map_prefixes prefix_label namespace_name
                    Directory.CreateDirectory(ttl_file.parent_directory.FullName) |> ignore
                    Turtle.write ttl_file.path graph
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
                            Console.WriteLine $"Saving {namespace_name} as {prefix_label}.ttl"
                            graph |> map_prefixes prefix_label namespace_name
                            Directory.CreateDirectory(ttl_file.parent_directory.FullName) |> ignore
                            Turtle.write ttl_file.path graph
                        with
                        | err -> log_lines.Add $"{namespace_name} {namespace_distribution} failed with error {err.Message}"
                    | _ -> log_lines.Add $"No http response for {namespace_name} distribution {namespace_distribution}"

            Some {
                    namespace_prefix = prefix_label
                    namespace_name = namespace_name
                }

        with
        | err ->
            log_lines.Add(sprintf "manual  namespace_name %s distribution %s errored with %s" namespace_name namespace_distribution err.Message) 
            None
    )

let file_stem_from_name_distribution namespace_name namespace_distribution =

    let distribution_uri = new Uri(namespace_distribution)
    let distribution_stem = distribution_uri.Segments |> Array.last

    match prefixid[namespace_name] with
    | _ when namespace_name = "http://www.w3.org/2001/XMLSchema#" -> "xsd"
    | prefix_label when namespace_name <> namespace_distribution -> $"{prefix_label}-{distribution_stem}"
    | prefix_label -> prefix_label


let multipart_content =
    multipart_distributions
    |> Array.Parallel.choose (fun (namespace_name, namespace_distributions) ->
        try

            let ttl_paths =
                namespace_distributions
                |> Array.Parallel.map (fun namespace_distribution ->
                    let namespace_uri = new Uri(namespace_name)
                    let distribution_uri = new Uri(namespace_distribution)

                    let namespace_directory = Folder.Vocabulary ./ iri_to_relative_path namespace_name
                    let file_stem =
                        let file_name = 
                                let distribution_uri = new Uri(namespace_distribution)
                                let distribution_stem = distribution_uri.Segments |> Array.last

                                match prefixid[namespace_name] with
                                | _ when namespace_name = "http://www.w3.org/2001/XMLSchema#" -> "xsd"
                                | prefix_label when namespace_name <> namespace_distribution -> $"{prefix_label}-{distribution_stem}"
                                | prefix_label -> prefix_label

                        file_name.Replace(".ttl", "")
                    let prefix_label = prefixid[namespace_name]
                    let ttl_file = namespace_directory ./ $"{file_stem}.ttl"




                    if not (ttl_file.as_file.Exists) then
                        let graph = new ThreadSafeGraph()

                        match namespace_name with
                        | _ ->
                            try
                                rdf_loader.LoadGraph(graph, distribution_uri)
                                Console.WriteLine $"Saving {namespace_name} as {file_stem}.ttl"
                                graph |> map_prefixes prefix_label namespace_name
                                Directory.CreateDirectory(ttl_file.parent_directory.FullName) |> ignore
                                Turtle.write ttl_file.path graph
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
                                        Console.WriteLine $"Saving {namespace_name} as {prefix_label}.ttl"
                                        graph |> map_prefixes prefix_label namespace_name
                                        Directory.CreateDirectory(ttl_file.parent_directory.FullName) |> ignore
                                        Turtle.write ttl_file.path graph

                                    with
                                    | err -> log_lines.Add $"{namespace_name} {namespace_distribution} failed with error {err.Message}"
                                | _ -> log_lines.Add $"No http response for {namespace_name} distribution {namespace_distribution}"
                    ttl_file.path
                )


            Some {
                namespace_prefix = prefixid[namespace_name]
                namespace_name = namespace_name

            }

        with
        | err ->
            log_lines.Add(sprintf "multipart namespace_name %s distributions %A errored with %s" namespace_name namespace_distributions err.Message) 
            None

    )





File.WriteAllLines(Path.Combine(__SOURCE_DIRECTORY__, "ErroredNamespaces.txt"), log_lines)



















let in_memory_dataset = new InMemoryDataset(new DiskDemandTripleStore(), true, false)



Folder.Vocabulary.child_files "*.ttl"
|> Array.map (fun graph_file -> 
    let graph_uri = new Uri(graph_file)
    let graph_name = new Iri(graph_uri)
    in_memory_dataset.HasGraph(graph_name))





let rdf = 
    Vocabulary {
        namespace_prefix = "rdf"
        namespace_name = "http://www.w3.org/1999/02/22-rdf-syntax-ns#"
    }
        


module DoxAletheia.Rdf_Distribution.Multi



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

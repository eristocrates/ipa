namespace http.www.w3.org.ns.lemon.lime.hash

open DoxAletheia.Rdf_Vocabulary

module lime =
    let _namespace_name = "http://www.w3.org/ns/lemon/lime#"

    /// <summary>
    /// A conceptualization set represents a collection of links between lexical entries in a Lexicon and lexical concepts in a Concept Set they evoke.
    /// <see href="http://www.w3.org/ns/lemon/lime#ConceptualizationSet"></see></summary>
    let ConceptualizationSet =
        Namespaced_IRI.parse _namespace_name "ConceptualizationSet" |> NamespacedName

    /// <summary>
    /// The 'lexicon dataset' property indicates the lexicon that contains the entries refered to in a lexicalization set or a conceptualization set.
    /// <see href="http://www.w3.org/ns/lemon/lime#lexiconDataset"></see></summary>
    let lexiconDataset =
        Namespaced_IRI.parse _namespace_name "lexiconDataset" |> NamespacedName

    /// <summary>
    /// A lexicon represents a collection of lexical entries for a particular language or domain.
    /// <see href="http://www.w3.org/ns/lemon/lime#Lexicon"></see></summary>
    let Lexicon = Namespaced_IRI.parse _namespace_name "Lexicon" |> NamespacedName

    /// <summary>
    /// The 'conceptual dataset' property relates a lexical link set or a conceptualization set to a corresponding concept set.
    /// <see href="http://www.w3.org/ns/lemon/lime#conceptualDataset"></see></summary>
    let conceptualDataset =
        Namespaced_IRI.parse _namespace_name "conceptualDataset" |> NamespacedName

    /// <summary>
    /// A lexical linkset represents a collection of links between a reference dataset and a set of lexical concepts (e.g. synsets of a wordnet).
    /// <see href="http://www.w3.org/ns/lemon/lime#LexicalLinkset"></see></summary>
    let LexicalLinkset =
        Namespaced_IRI.parse _namespace_name "LexicalLinkset" |> NamespacedName

    /// <summary>
    /// The 'partition' property relates a lexicalization set or lexical linkset to a logical subset that contains lexicalizations for a given ontological type only.
    /// <see href="http://www.w3.org/ns/lemon/lime#partition"></see></summary>
    let partition = Namespaced_IRI.parse _namespace_name "partition" |> NamespacedName

    /// <summary>
    /// The 'reference dataset' property indicates the dataset that contains the domain objects or vocabulary elements that are either referenced by a given lexicon, providing the grounding vocabulary for the meaning of the lexical entries, or linked to lexical concepts in a concept set by means of a lexical link set.
    /// <see href="http://www.w3.org/ns/lemon/lime#referenceDataset"></see></summary>
    let referenceDataset =
        Namespaced_IRI.parse _namespace_name "referenceDataset" |> NamespacedName

    /// <summary>
    /// A 'lexicalization set' is a dataset that comprises a collection of lexicalizations, that is pairs of lexical entry and corresponding reference in the associated ontology/vocabulary/dataset.
    /// <see href="http://www.w3.org/ns/lemon/lime#LexicalizationSet"></see></summary>
    let LexicalizationSet =
        Namespaced_IRI.parse _namespace_name "LexicalizationSet" |> NamespacedName

    /// <summary>
    /// The 'lexicalization model' property indicates the model used for representing lexical information. Possible values include (but are not limited to) http://www.w3.org/2000/01/rdf-schema# (for the use of rdfs:label), http://www.w3.org/2004/02/skos/core (for the use of skos:pref/alt/hiddenLabel), http://www.w3.org/2008/05/skos-xl (for the use of skosxl:pref/alt/hiddenLabel) and http://www.w3.org/ns/lemon/all for lemon.
    /// <see href="http://www.w3.org/ns/lemon/lime#lexicalizationModel"></see></summary>
    let lexicalizationModel =
        Namespaced_IRI.parse _namespace_name "lexicalizationModel" |> NamespacedName

    /// <summary>
    /// The  'language' property indicates the language of a lexicon, a lexical entry, a concept set or a lexicalization set.
    /// <see href="http://www.w3.org/ns/lemon/lime#language"></see></summary>
    let language = Namespaced_IRI.parse _namespace_name "language" |> NamespacedName
    /// <summary>
    /// The 'entry' property relates a lexicon to one of the lexical entries contained in it.
    /// <see href="http://www.w3.org/ns/lemon/lime#entry"></see></summary>
    let entry = Namespaced_IRI.parse _namespace_name "entry" |> NamespacedName

    /// <summary>
    /// The 'average ambiguity' property indicates the average number of lexical concepts evoked by each lemma/canonical form in the lexicon.
    /// <see href="http://www.w3.org/ns/lemon/lime#avgAmbiguity"></see></summary>
    let avgAmbiguity =
        Namespaced_IRI.parse _namespace_name "avgAmbiguity" |> NamespacedName

    /// <summary>
    /// The 'average number of lexicalizations' property indicate the average number of lexicalizations per ontology element. The exact formula for calculating the average is indicated in the specification: https://www.w3.org/community/ontolex/wiki/Final_Model_Specification#LexicalizationSet
    /// <see href="http://www.w3.org/ns/lemon/lime#avgNumOfLexicalizations"></see></summary>
    let avgNumOfLexicalizations =
        Namespaced_IRI.parse _namespace_name "avgNumOfLexicalizations" |> NamespacedName

    /// <summary>
    /// The 'average number of links' property indicates the average number of links for each entity in the conceptual dataset.
    /// <see href="http://www.w3.org/ns/lemon/lime#avgNumOfLinks"></see></summary>
    let avgNumOfLinks =
        Namespaced_IRI.parse _namespace_name "avgNumOfLinks" |> NamespacedName

    /// <summary>
    /// The 'average synonymy' property indicates the average number of lexical entries evoking each lexical concept in the concept set.
    /// <see href="http://www.w3.org/ns/lemon/lime#avgSynonymy"></see></summary>
    let avgSynonymy =
        Namespaced_IRI.parse _namespace_name "avgSynonymy" |> NamespacedName

    /// <summary>
    /// The 'concepts' property indicates the number of lexical concepts defined in a concept set or involved in either a LexicalLinkset or ConceptualizationSet.
    /// <see href="http://www.w3.org/ns/lemon/lime#concepts"></see></summary>
    let concepts = Namespaced_IRI.parse _namespace_name "concepts" |> NamespacedName

    /// <summary>
    /// The 'conceptualizations' property indicates the number of distinct conceptualizations in a conceptualization set.
    /// <see href="http://www.w3.org/ns/lemon/lime#conceptualizations"></see></summary>
    let conceptualizations =
        Namespaced_IRI.parse _namespace_name "conceptualizations" |> NamespacedName

    /// <summary>
    /// The 'lexical entries' property indicates the number of distinct lexical entries contained in a lexicon or lexicalization set.
    /// <see href="http://www.w3.org/ns/lemon/lime#lexicalEntries"></see></summary>
    let lexicalEntries =
        Namespaced_IRI.parse _namespace_name "lexicalEntries" |> NamespacedName

    /// <summary>
    /// The 'lexicalizations' property indicates the total number of lexicalizations in a lexicalization set, that is the number of unique pairs of lexical entry and denoted ontology element.
    /// <see href="http://www.w3.org/ns/lemon/lime#lexicalizations"></see></summary>
    let lexicalizations =
        Namespaced_IRI.parse _namespace_name "lexicalizations" |> NamespacedName

    /// <summary>
    /// The 'linguistic catalog' property indicates the catalog of linguistic categories used in a lexicon to define linguistic properties of lexical entries.
    /// <see href="http://www.w3.org/ns/lemon/lime#linguisticCatalog"></see></summary>
    let linguisticCatalog =
        Namespaced_IRI.parse _namespace_name "linguisticCatalog" |> NamespacedName

    /// <summary>
    /// The 'links' property indicates the number of links between concepts in the concept set and entities in the reference dataset.
    /// <see href="http://www.w3.org/ns/lemon/lime#links"></see></summary>
    let links = Namespaced_IRI.parse _namespace_name "links" |> NamespacedName
    /// <summary>
    /// The 'percentage' property expresses the percentage of entities in the reference dataset which have at least one lexicalization in a lexicalization set or are linked to a lexical concept in a lexical linkset.
    /// <see href="http://www.w3.org/ns/lemon/lime#percentage"></see></summary>
    let percentage = Namespaced_IRI.parse _namespace_name "percentage" |> NamespacedName
    /// <summary>
    /// The 'references' property indicates the number of distinct ontology or vocabulary elements that are either associated with lexical entries via a lexicalization set or linked to lexical concepts via a lexical link set.
    /// <see href="http://www.w3.org/ns/lemon/lime#references"></see></summary>
    let references = Namespaced_IRI.parse _namespace_name "references" |> NamespacedName

    /// <summary>
    /// The 'resource type' property indicates the type of ontological entity of a lexicalization set or lexical linkset.
    /// <see href="http://www.w3.org/ns/lemon/lime#resourceType"></see></summary>
    let resourceType =
        Namespaced_IRI.parse _namespace_name "resourceType" |> NamespacedName

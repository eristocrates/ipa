#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\RDFErgonomics.fsx"
open RDFErgonomics

module lexicog =

    let _prefix = prefix_label "lexicog"

    let ConceptualizationSet = _prefix "ConceptualizationSet"


    let LexicalLinkset = _prefix "LexicalLinkset"


    /// A 'lexicalization set' is a dataset that comprises a collection of lexicalizations, that is pairs of lexical entry and corresponding reference in the associated ontology/vocabulary/dataset.
    let LexicalizationSet = _prefix "LexicalizationSet"


    let Lexicon = _prefix "Lexicon"


    let avgAmbiguity = _prefix "avgAmbiguity"


    /// The 'average number of lexicalizations' property indicate the average number of lexicalizations per ontology element. The exact formula for calculating the average is indicated in the specification: https://www.w3.org/community/ontolex/wiki/Final_Model_Specification#LexicalizationSet
    let avgNumOfLexicalizations = _prefix "avgNumOfLexicalizations"


    /// The 'average number of links' property indicates the average number of links for each entity in the conceptual dataset.
    let avgNumOfLinks = _prefix "avgNumOfLinks"


    let avgSynonymy = _prefix "avgSynonymy"


    /// The 'concepts' property indicates the number of lexical concepts defined in a concept set or involved in either a LexicalLinkset or ConceptualizationSet.
    let concepts = _prefix "concepts"


    let conceptualDataset = _prefix "conceptualDataset"


    /// The 'conceptualizations' property indicates the number of distinct conceptualizations in a conceptualization set.
    let conceptualizations = _prefix "conceptualizations"


    let entry = _prefix "entry"


    /// The  'language' property indicates the language of a lexicon, a lexical entry, a concept set or a lexicalization set.
    let language = _prefix "language"


    /// The 'lexical entries' property indicates the number of distinct lexical entries contained in a lexicon or lexicalization set.
    let lexicalEntries = _prefix "lexicalEntries"


    /// The 'lexicalization model' property indicates the model used for representing lexical information. Possible values include (but are not limited to) http://www.w3.org/2000/01/rdf-schema# (for the use of rdfs:label), http://www.w3.org/2004/02/skos/core (for the use of skos:pref/alt/hiddenLabel), http://www.w3.org/2008/05/skos-xl (for the use of skosxl:pref/alt/hiddenLabel) and http://www.w3.org/ns/lemon/all for lemon.
    let lexicalizationModel = _prefix "lexicalizationModel"


    /// The 'lexicalizations' property indicates the total number of lexicalizations in a lexicalization set, that is the number of unique pairs of lexical entry and denoted ontology element.
    let lexicalizations = _prefix "lexicalizations"


    /// The 'lexicon dataset' property indicates the lexicon that contains the entries refered to in a lexicalization set or a conceptualization set.
    let lexiconDataset = _prefix "lexiconDataset"


    let linguisticCatalog = _prefix "linguisticCatalog"


    let links = _prefix "links"


    /// The 'partition' property relates a lexicalization set or lexical linkset to a logical subset that contains lexicalizations for a given ontological type only.
    let partition = _prefix "partition"


    /// The 'percentage' property expresses the percentage of entities in the reference dataset which have at least one lexicalization in a lexicalization set or are linked to a lexical concept in a lexical linkset.
    let percentage = _prefix "percentage"


    /// The 'reference dataset' property indicates the dataset that contains the domain objects or vocabulary elements that are either referenced by a given lexicon, providing the grounding vocabulary for the meaning of the lexical entries, or linked to lexical concepts in a concept set by means of a lexical link set.
    let referenceDataset = _prefix "referenceDataset"


    let references = _prefix "references"


    /// The 'resource type' property indicates the type of ontological entity of a lexicalization set or lexical linkset.
    let resourceType = _prefix "resourceType"

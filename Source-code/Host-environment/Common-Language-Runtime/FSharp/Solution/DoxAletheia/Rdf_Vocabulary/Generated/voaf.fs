namespace http.purl.org.vocommons.voaf.hash

open DoxAletheia

module voaf =
    let _namespace_name = "http://purl.org/vocommons/voaf#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Deprecated since v1.1
    /// <see href="http://purl.org/vocommons/voaf#exampleDataset"></see></summary>
    let exampleDataset = _prefix "exampleDataset"
    /// <summary>
    /// A vocabulary used in the linked data cloud. An instance of voaf:Vocabulary relies on or is used by at least another instance of voaf:Vocabulary
    /// <see href="http://purl.org/vocommons/voaf#Vocabulary"></see></summary>
    let Vocabulary = _prefix "Vocabulary"
    /// <summary>
    /// Class used to store the number of occurences of a vocabulary in a particular dataset
    /// <see href="http://purl.org/vocommons/voaf#DatasetOccurrences"></see></summary>
    let DatasetOccurrences = _prefix "DatasetOccurrences"
    /// <summary>
    /// Indicates that the subject vocabulary uses or extends some class or property of the object vocabulary
    /// <see href="http://purl.org/vocommons/voaf#reliesOn"></see></summary>
    let reliesOn = _prefix "reliesOn"
    /// <summary>
    /// Indicates that the subject vocabulary is used by the object vocabulary
    /// <see href="http://purl.org/vocommons/voaf#usedBy"></see></summary>
    let usedBy = _prefix "usedBy"
    /// <summary>
    /// A vocabulary space defines any relevant grouping of vocabularies e.g., designed for similar purposes or domains, or designed by the same publisher or the same project, etc.
    ///           A vocabulary can belong to zero, one or more vocabulary spaces.Dublin Core properties isPartOf and hasPart are used to link a vocabulary to a vocabulary space.
    /// <see href="http://purl.org/vocommons/voaf#VocabularySpace"></see></summary>
    let VocabularySpace = _prefix "VocabularySpace"
    /// <summary>
    /// The number of classes defined in the vocabulary namespace. Classes imported from other namespaces are not taken into account.
    /// <see href="http://purl.org/vocommons/voaf#classNumber"></see></summary>
    let classNumber = _prefix "classNumber"
    /// <summary>
    /// Deprecated since v2.4
    /// <see href="http://purl.org/vocommons/voaf#dataset"></see></summary>
    let dataset = _prefix "dataset"
    /// <summary>
    /// Indicates that the subject vocabulary extends the expressivity of the object vocabulary by declaring subsumption relationships, using object vocabulary class as domain or range of a subject vocabulary property, defining local restrictions etc ...
    /// <see href="http://purl.org/vocommons/voaf#extends"></see></summary>
    let extends = _prefix "extends"
    /// <summary>
    /// Indicates that the subject vocabulary generalizes by some superclasses or superproperties the object vocabulary.
    /// <see href="http://purl.org/vocommons/voaf#generalizes"></see></summary>
    let generalizes = _prefix "generalizes"
    /// <summary>
    /// Indicates that the subject vocabulary contains some declaration of disjoint classes with the object vocabulary.
    /// <see href="http://purl.org/vocommons/voaf#hasDisjunctionsWith"></see></summary>
    let hasDisjunctionsWith = _prefix "hasDisjunctionsWith"
    /// <summary>
    /// Indicates that the subject vocabulary declares some equivalent classes or properties with the object vocabulary.
    /// <see href="http://purl.org/vocommons/voaf#hasEquivalencesWith"></see></summary>
    let hasEquivalencesWith = _prefix "hasEquivalencesWith"
    /// <summary>
    /// dataset in which a vocabulary occurred
    /// <see href="http://purl.org/vocommons/voaf#inDataset"></see></summary>
    let inDataset = _prefix "inDataset"
    /// <summary>
    /// Indicates that the subject vocabulary uses the object vocabulary in metadata at global vocabulary level or at element level
    /// <see href="http://purl.org/vocommons/voaf#metadataVoc"></see></summary>
    let metadataVoc = _prefix "metadataVoc"
    /// <summary>
    /// Number of occurrences of a vocabulary in a dataset
    /// <see href="http://purl.org/vocommons/voaf#occurrences"></see></summary>
    let occurrences = _prefix "occurrences"
    /// <summary>
    /// Number of datasets using a resource.
    /// <see href="http://purl.org/vocommons/voaf#occurrencesInDatasets"></see></summary>
    let occurrencesInDatasets = _prefix "occurrencesInDatasets"
    /// <summary>
    /// Number of vocabularies using a resource
    /// <see href="http://purl.org/vocommons/voaf#occurrencesInVocabularies"></see></summary>
    let occurrencesInVocabularies = _prefix "occurrencesInVocabularies"
    /// <summary>
    /// The number of properties defined in the vocabulary namespace. Properties imported from other namespaces are not taken into account.
    /// <see href="http://purl.org/vocommons/voaf#propertyNumber"></see></summary>
    let propertyNumber = _prefix "propertyNumber"
    /// <summary>
    /// Distinct number of datasets reusing a resource.
    /// <see href="http://purl.org/vocommons/voaf#reusedByDatasets"></see></summary>
    let reusedByDatasets = _prefix "reusedByDatasets"
    /// <summary>
    /// Distinct number of vocabularies reusing a resource.
    /// <see href="http://purl.org/vocommons/voaf#reusedByVocabularies"></see></summary>
    let reusedByVocabularies = _prefix "reusedByVocabularies"
    /// <summary>
    /// Used to assert that two vocabularies are similar in scope and objectives, independently of the fact that they otherwise refer to each other.
    /// <see href="http://purl.org/vocommons/voaf#similar"></see></summary>
    let similar = _prefix "similar"
    /// <summary>
    /// Indicates that the subject vocabulary defines some subclasses or subproperties of the object vocabulary, or local restrictions on those.
    /// <see href="http://purl.org/vocommons/voaf#specializes"></see></summary>
    let specializes = _prefix "specializes"
    /// <summary>
    /// Describes future tasks planned by a resource curator. This property is primarily intended to be used for vocabularies or datasets, but the domain is left open, it can be used for any resource. Use iCalendar Vtodo class and its properties to further describe the task calendar, priorities etc.
    /// <see href="http://purl.org/vocommons/voaf#toDoList"></see></summary>
    let toDoList = _prefix "toDoList"
    /// <summary>
    /// usage statistics in a dataset
    /// <see href="http://purl.org/vocommons/voaf#usageInDataset"></see></summary>
    let usageInDataset = _prefix "usageInDataset"

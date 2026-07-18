namespace http.purl.org.vocommons.voaf.hash

open DoxAletheia.Rdf_Vocabulary

module voaf =
    let _namespace_name = "http://purl.org/vocommons/voaf#"

    /// <summary>
    /// Deprecated since v1.1
    /// <see href="http://purl.org/vocommons/voaf#exampleDataset"></see></summary>
    let exampleDataset =
        Namespaced_IRI.parse _namespace_name "exampleDataset" |> NamespacedName

    /// <summary>
    /// A vocabulary used in the linked data cloud. An instance of voaf:Vocabulary relies on or is used by at least another instance of voaf:Vocabulary
    /// <see href="http://purl.org/vocommons/voaf#Vocabulary"></see></summary>
    let Vocabulary = Namespaced_IRI.parse _namespace_name "Vocabulary" |> NamespacedName

    /// <summary>
    /// Class used to store the number of occurences of a vocabulary in a particular dataset
    /// <see href="http://purl.org/vocommons/voaf#DatasetOccurrences"></see></summary>
    let DatasetOccurrences =
        Namespaced_IRI.parse _namespace_name "DatasetOccurrences" |> NamespacedName

    /// <summary>
    /// Indicates that the subject vocabulary uses or extends some class or property of the object vocabulary
    /// <see href="http://purl.org/vocommons/voaf#reliesOn"></see></summary>
    let reliesOn = Namespaced_IRI.parse _namespace_name "reliesOn" |> NamespacedName
    /// <summary>
    /// Indicates that the subject vocabulary is used by the object vocabulary
    /// <see href="http://purl.org/vocommons/voaf#usedBy"></see></summary>
    let usedBy = Namespaced_IRI.parse _namespace_name "usedBy" |> NamespacedName

    /// <summary>
    /// A vocabulary space defines any relevant grouping of vocabularies e.g., designed for similar purposes or domains, or designed by the same publisher or the same project, etc.
    ///           A vocabulary can belong to zero, one or more vocabulary spaces.Dublin Core properties isPartOf and hasPart are used to link a vocabulary to a vocabulary space.
    /// <see href="http://purl.org/vocommons/voaf#VocabularySpace"></see></summary>
    let VocabularySpace =
        Namespaced_IRI.parse _namespace_name "VocabularySpace" |> NamespacedName

    /// <summary>
    /// The number of classes defined in the vocabulary namespace. Classes imported from other namespaces are not taken into account.
    /// <see href="http://purl.org/vocommons/voaf#classNumber"></see></summary>
    let classNumber =
        Namespaced_IRI.parse _namespace_name "classNumber" |> NamespacedName

    /// <summary>
    /// Deprecated since v2.4
    /// <see href="http://purl.org/vocommons/voaf#dataset"></see></summary>
    let dataset = Namespaced_IRI.parse _namespace_name "dataset" |> NamespacedName
    /// <summary>
    /// Indicates that the subject vocabulary extends the expressivity of the object vocabulary by declaring subsumption relationships, using object vocabulary class as domain or range of a subject vocabulary property, defining local restrictions etc ...
    /// <see href="http://purl.org/vocommons/voaf#extends"></see></summary>
    let extends = Namespaced_IRI.parse _namespace_name "extends" |> NamespacedName

    /// <summary>
    /// Indicates that the subject vocabulary generalizes by some superclasses or superproperties the object vocabulary.
    /// <see href="http://purl.org/vocommons/voaf#generalizes"></see></summary>
    let generalizes =
        Namespaced_IRI.parse _namespace_name "generalizes" |> NamespacedName

    /// <summary>
    /// Indicates that the subject vocabulary contains some declaration of disjoint classes with the object vocabulary.
    /// <see href="http://purl.org/vocommons/voaf#hasDisjunctionsWith"></see></summary>
    let hasDisjunctionsWith =
        Namespaced_IRI.parse _namespace_name "hasDisjunctionsWith" |> NamespacedName

    /// <summary>
    /// Indicates that the subject vocabulary declares some equivalent classes or properties with the object vocabulary.
    /// <see href="http://purl.org/vocommons/voaf#hasEquivalencesWith"></see></summary>
    let hasEquivalencesWith =
        Namespaced_IRI.parse _namespace_name "hasEquivalencesWith" |> NamespacedName

    /// <summary>
    /// dataset in which a vocabulary occurred
    /// <see href="http://purl.org/vocommons/voaf#inDataset"></see></summary>
    let inDataset = Namespaced_IRI.parse _namespace_name "inDataset" |> NamespacedName

    /// <summary>
    /// Indicates that the subject vocabulary uses the object vocabulary in metadata at global vocabulary level or at element level
    /// <see href="http://purl.org/vocommons/voaf#metadataVoc"></see></summary>
    let metadataVoc =
        Namespaced_IRI.parse _namespace_name "metadataVoc" |> NamespacedName

    /// <summary>
    /// Number of occurrences of a vocabulary in a dataset
    /// <see href="http://purl.org/vocommons/voaf#occurrences"></see></summary>
    let occurrences =
        Namespaced_IRI.parse _namespace_name "occurrences" |> NamespacedName

    /// <summary>
    /// Number of datasets using a resource.
    /// <see href="http://purl.org/vocommons/voaf#occurrencesInDatasets"></see></summary>
    let occurrencesInDatasets =
        Namespaced_IRI.parse _namespace_name "occurrencesInDatasets" |> NamespacedName

    /// <summary>
    /// Number of vocabularies using a resource
    /// <see href="http://purl.org/vocommons/voaf#occurrencesInVocabularies"></see></summary>
    let occurrencesInVocabularies =
        Namespaced_IRI.parse _namespace_name "occurrencesInVocabularies" |> NamespacedName

    /// <summary>
    /// The number of properties defined in the vocabulary namespace. Properties imported from other namespaces are not taken into account.
    /// <see href="http://purl.org/vocommons/voaf#propertyNumber"></see></summary>
    let propertyNumber =
        Namespaced_IRI.parse _namespace_name "propertyNumber" |> NamespacedName

    /// <summary>
    /// Distinct number of datasets reusing a resource.
    /// <see href="http://purl.org/vocommons/voaf#reusedByDatasets"></see></summary>
    let reusedByDatasets =
        Namespaced_IRI.parse _namespace_name "reusedByDatasets" |> NamespacedName

    /// <summary>
    /// Distinct number of vocabularies reusing a resource.
    /// <see href="http://purl.org/vocommons/voaf#reusedByVocabularies"></see></summary>
    let reusedByVocabularies =
        Namespaced_IRI.parse _namespace_name "reusedByVocabularies" |> NamespacedName

    /// <summary>
    /// Used to assert that two vocabularies are similar in scope and objectives, independently of the fact that they otherwise refer to each other.
    /// <see href="http://purl.org/vocommons/voaf#similar"></see></summary>
    let similar = Namespaced_IRI.parse _namespace_name "similar" |> NamespacedName

    /// <summary>
    /// Indicates that the subject vocabulary defines some subclasses or subproperties of the object vocabulary, or local restrictions on those.
    /// <see href="http://purl.org/vocommons/voaf#specializes"></see></summary>
    let specializes =
        Namespaced_IRI.parse _namespace_name "specializes" |> NamespacedName

    /// <summary>
    /// Describes future tasks planned by a resource curator. This property is primarily intended to be used for vocabularies or datasets, but the domain is left open, it can be used for any resource. Use iCalendar Vtodo class and its properties to further describe the task calendar, priorities etc.
    /// <see href="http://purl.org/vocommons/voaf#toDoList"></see></summary>
    let toDoList = Namespaced_IRI.parse _namespace_name "toDoList" |> NamespacedName

    /// <summary>
    /// usage statistics in a dataset
    /// <see href="http://purl.org/vocommons/voaf#usageInDataset"></see></summary>
    let usageInDataset =
        Namespaced_IRI.parse _namespace_name "usageInDataset" |> NamespacedName

namespace http.purl.org.cld.terms.slash

open DoxAletheia.Rdf_Vocabulary

module cld =
    let _namespace_name = "http://purl.org/cld/terms/"

    /// <summary>
    /// A set of methods by which items are added to a collection.
    /// <see href="http://purl.org/cld/terms/AccrualMethod"></see></summary>
    let AccrualMethod =
        Namespaced_IRI.parse _namespace_name "AccrualMethod" |> NamespacedName

    /// <summary>
    /// A set of policies governing the addition of items are added to a collection.
    /// <see href="http://purl.org/cld/terms/AccrualPolicy"></see></summary>
    let AccrualPolicy =
        Namespaced_IRI.parse _namespace_name "AccrualPolicy" |> NamespacedName

    /// <summary>
    /// A set of types of collection description.
    /// <see href="http://purl.org/cld/terms/CDType"></see></summary>
    let CDType = Namespaced_IRI.parse _namespace_name "CDType" |> NamespacedName
    /// <summary>
    /// A set of frequencies with which a repeatable event occurs..
    /// <see href="http://purl.org/cld/terms/Frequency"></see></summary>
    let Frequency = Namespaced_IRI.parse _namespace_name "Frequency" |> NamespacedName

    /// <summary>
    /// Instances of this datatype are dates or periods of time represented as literals according to the rules specified in Recordkeeping Metadata Schema Extension to ISO8601.
    /// <see href="http://purl.org/cld/terms/RKMS-ISO8601"></see></summary>
    let ``RKMS-ISO8601`` =
        Namespaced_IRI.parse _namespace_name "RKMS-ISO8601" |> NamespacedName

    /// <summary>
    /// A second collection that is associated with the current collection.
    /// <see href="http://purl.org/cld/terms/associatedCollection"></see></summary>
    let associatedCollection =
        Namespaced_IRI.parse _namespace_name "associatedCollection" |> NamespacedName

    /// <summary>
    /// A catalogue for, or index of, the collection.
    /// <see href="http://purl.org/cld/terms/catalogueOrIndex"></see></summary>
    let catalogueOrIndex =
        Namespaced_IRI.parse _namespace_name "catalogueOrIndex" |> NamespacedName

    /// <summary>
    /// A range of dates over which the individual items within the collection were created.
    /// <see href="http://purl.org/cld/terms/dateItemsCreated"></see></summary>
    let dateItemsCreated =
        Namespaced_IRI.parse _namespace_name "dateItemsCreated" |> NamespacedName

    /// <summary>
    /// A collection that is described by the current collection.
    /// <see href="http://purl.org/cld/terms/describedCollection"></see></summary>
    let describedCollection =
        Namespaced_IRI.parse _namespace_name "describedCollection" |> NamespacedName

    /// <summary>
    /// A service that provides access to the items within the collection.
    /// <see href="http://purl.org/cld/terms/isAccessedVia"></see></summary>
    let isAccessedVia =
        Namespaced_IRI.parse _namespace_name "isAccessedVia" |> NamespacedName

    /// <summary>
    /// A location where the collection is held.
    /// <see href="http://purl.org/cld/terms/isLocatedAt"></see></summary>
    let isLocatedAt =
        Namespaced_IRI.parse _namespace_name "isLocatedAt" |> NamespacedName

    /// <summary>
    /// The media type, physical or digital, of one or more items within the collection.
    /// <see href="http://purl.org/cld/terms/itemFormat"></see></summary>
    let itemFormat = Namespaced_IRI.parse _namespace_name "itemFormat" |> NamespacedName
    /// <summary>
    /// The nature or genre of the content of one or more items within the collection.
    /// <see href="http://purl.org/cld/terms/itemType"></see></summary>
    let itemType = Namespaced_IRI.parse _namespace_name "itemType" |> NamespacedName

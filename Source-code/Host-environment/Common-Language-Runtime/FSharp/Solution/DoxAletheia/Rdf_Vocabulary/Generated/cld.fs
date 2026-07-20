namespace http.purl.org.cld.terms.slash

open DoxAletheia

module cld =
    let _namespace_name = "http://purl.org/cld/terms/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A set of methods by which items are added to a collection.
    /// <see href="http://purl.org/cld/terms/AccrualMethod"></see></summary>
    let AccrualMethod = _prefix "AccrualMethod"
    /// <summary>
    /// A set of policies governing the addition of items are added to a collection.
    /// <see href="http://purl.org/cld/terms/AccrualPolicy"></see></summary>
    let AccrualPolicy = _prefix "AccrualPolicy"
    /// <summary>
    /// A set of types of collection description.
    /// <see href="http://purl.org/cld/terms/CDType"></see></summary>
    let CDType = _prefix "CDType"
    /// <summary>
    /// A set of frequencies with which a repeatable event occurs..
    /// <see href="http://purl.org/cld/terms/Frequency"></see></summary>
    let Frequency = _prefix "Frequency"
    /// <summary>
    /// Instances of this datatype are dates or periods of time represented as literals according to the rules specified in Recordkeeping Metadata Schema Extension to ISO8601.
    /// <see href="http://purl.org/cld/terms/RKMS-ISO8601"></see></summary>
    let ``RKMS-ISO8601`` = _prefix "RKMS-ISO8601"
    /// <summary>
    /// A second collection that is associated with the current collection.
    /// <see href="http://purl.org/cld/terms/associatedCollection"></see></summary>
    let associatedCollection = _prefix "associatedCollection"
    /// <summary>
    /// A catalogue for, or index of, the collection.
    /// <see href="http://purl.org/cld/terms/catalogueOrIndex"></see></summary>
    let catalogueOrIndex = _prefix "catalogueOrIndex"
    /// <summary>
    /// A range of dates over which the individual items within the collection were created.
    /// <see href="http://purl.org/cld/terms/dateItemsCreated"></see></summary>
    let dateItemsCreated = _prefix "dateItemsCreated"
    /// <summary>
    /// A collection that is described by the current collection.
    /// <see href="http://purl.org/cld/terms/describedCollection"></see></summary>
    let describedCollection = _prefix "describedCollection"
    /// <summary>
    /// A service that provides access to the items within the collection.
    /// <see href="http://purl.org/cld/terms/isAccessedVia"></see></summary>
    let isAccessedVia = _prefix "isAccessedVia"
    /// <summary>
    /// A location where the collection is held.
    /// <see href="http://purl.org/cld/terms/isLocatedAt"></see></summary>
    let isLocatedAt = _prefix "isLocatedAt"
    /// <summary>
    /// The media type, physical or digital, of one or more items within the collection.
    /// <see href="http://purl.org/cld/terms/itemFormat"></see></summary>
    let itemFormat = _prefix "itemFormat"
    /// <summary>
    /// The nature or genre of the content of one or more items within the collection.
    /// <see href="http://purl.org/cld/terms/itemType"></see></summary>
    let itemType = _prefix "itemType"

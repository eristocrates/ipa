namespace http.purl.org.cld.cdtype.slash

open DoxAletheia

module cdtype =
    let _namespace_name = "http://purl.org/cld/cdtype/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A collection of individual records describing the items, and the intellectual content of those items, of a second collection. The records provide information about individual items. There are no intrinsic relationships between the records, and each record is essentially self-contained.
    /// <see href="http://purl.org/cld/cdtype/AnalyticFindingAid"></see></summary>
    let AnalyticFindingAid = _prefix "AnalyticFindingAid"
    /// <summary>
    /// A catalogue for, or index of, a collection.
    /// <see href="http://purl.org/cld/cdtype/CatalogueOrIndex"></see></summary>
    let CatalogueOrIndex = _prefix "CatalogueOrIndex"
    /// <summary>
    /// A collection of records describing the individual items, and the intellectual content of those items, of a second collection. The records provide information about the collection and/or about the individual items, including contextual information about the relations between items and the collection. Relationships exist between records, and records are interpreted in the context of those relationships.
    /// <see href="http://purl.org/cld/cdtype/HierarchicFindingAid"></see></summary>
    let HierarchicFindingAid = _prefix "HierarchicFindingAid"
    /// <summary>
    /// A collection of records consisting of information derived from items in a second collection, regardless of the content of those items.
    /// <see href="http://purl.org/cld/cdtype/IndexingFindingAid"></see></summary>
    let IndexingFindingAid = _prefix "IndexingFindingAid"

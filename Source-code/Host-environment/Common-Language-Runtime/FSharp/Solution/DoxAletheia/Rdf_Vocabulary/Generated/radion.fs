namespace http.www.w3.org.ns.radion.hash

open DoxAletheia.Rdf_Vocabulary

module radion =
    let _namespace_name = "http://www.w3.org/ns/radion#"
    /// <summary>
    /// An Asset represents the conceptual content of a resource. A particular
    ///     Asset may have zero or more Distributions in different formats.
    /// <see href="http://www.w3.org/ns/radion#Asset"></see></summary>
    let Asset = Namespaced_IRI.parse _namespace_name "Asset" |> NamespacedName

    /// <summary>
    /// A Distribution is a particular representation or concretisation of an
    ///     Asset in the form of a downloadable computer file that implements the intellectual content of an
    ///     Asset. A particular Distribution is typically associated with one Asset.
    /// <see href="http://www.w3.org/ns/radion#Distribution"></see></summary>
    let Distribution =
        Namespaced_IRI.parse _namespace_name "Distribution" |> NamespacedName

    /// <summary>
    /// A Repository is a system or service that provides facilities for storage and
    ///     maintenance of descriptions of Assets and Distributions. A Repository will typically contain descriptions
    ///     of several Assets and functionality that allows users to search and access these descriptions. The
    ///     Distributions - the actual files themselves - will typically be available from the Repository or
    ///     elsewhere on the World Wide Web.
    /// <see href="http://www.w3.org/ns/radion#Repository"></see></summary>
    let Repository = Namespaced_IRI.parse _namespace_name "Repository" |> NamespacedName

    /// <summary>
    /// The distribution relationship associates an Asset (its domain) with a Distribution (its range). It is the inverse of distributionOf
    /// <see href="http://www.w3.org/ns/radion#distribution"></see></summary>
    let distribution =
        Namespaced_IRI.parse _namespace_name "distribution" |> NamespacedName

    /// <summary>
    /// The distributionOf relationship associates a Distribution (its domain) with the Asset (its range) of which it is a Distribution. It is the inverse of distribution
    /// <see href="http://www.w3.org/ns/radion#distributionOf"></see></summary>
    let distributionOf =
        Namespaced_IRI.parse _namespace_name "distributionOf" |> NamespacedName

    /// <summary>
    /// A word or phrase used to succinctly descibe the Asset
    /// <see href="http://www.w3.org/ns/radion#keyword"></see></summary>
    let keyword = Namespaced_IRI.parse _namespace_name "keyword" |> NamespacedName
    /// <summary>
    /// The version number or other designation of the Asset; the value should be a free text string
    /// <see href="http://www.w3.org/ns/radion#version"></see></summary>
    let version = Namespaced_IRI.parse _namespace_name "version" |> NamespacedName

    /// <summary>
    /// Notes on the particular version of the Asset.
    /// <see href="http://www.w3.org/ns/radion#versionNotes"></see></summary>
    let versionNotes =
        Namespaced_IRI.parse _namespace_name "versionNotes" |> NamespacedName

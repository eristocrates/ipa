namespace http.tracker.api.gnome.org.ontology.v3.tracker.hash

open DoxAletheia.Rdf_Vocabulary

module tracker =
    let _namespace_name = "http://tracker.api.gnome.org/ontology/v3/tracker#"

    /// <summary>
    /// External reference to online services
    /// <see href="http://tracker.api.gnome.org/ontology/v3/tracker#ExternalReference"></see></summary>
    let ExternalReference =
        Namespaced_IRI.parse _namespace_name "ExternalReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/tracker#IndexedFolder"></see>
    /// </summary>
    let IndexedFolder =
        Namespaced_IRI.parse _namespace_name "IndexedFolder" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/tracker#available"></see>
    /// </summary>
    let available = Namespaced_IRI.parse _namespace_name "available" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/tracker#extractor-data-source"></see>
    /// </summary>
    let ``extractor-data-source`` =
        Namespaced_IRI.parse _namespace_name "extractor-data-source" |> NamespacedName

    /// <summary>
    /// Hash identifying the extractor of the metadata
    /// <see href="http://tracker.api.gnome.org/ontology/v3/tracker#extractorHash"></see></summary>
    let extractorHash =
        Namespaced_IRI.parse _namespace_name "extractorHash" |> NamespacedName

    /// <summary>
    /// Links the information element with the external reference
    /// <see href="http://tracker.api.gnome.org/ontology/v3/tracker#hasExternalReference"></see></summary>
    let hasExternalReference =
        Namespaced_IRI.parse _namespace_name "hasExternalReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/tracker#isDefaultTag"></see>
    /// </summary>
    let isDefaultTag =
        Namespaced_IRI.parse _namespace_name "isDefaultTag" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/tracker#isOptical"></see>
    /// </summary>
    let isOptical = Namespaced_IRI.parse _namespace_name "isOptical" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/tracker#isRemovable"></see>
    /// </summary>
    let isRemovable =
        Namespaced_IRI.parse _namespace_name "isRemovable" |> NamespacedName

    /// <summary>
    /// Identifier of the external reference
    /// <see href="http://tracker.api.gnome.org/ontology/v3/tracker#referenceIdentifier"></see></summary>
    let referenceIdentifier =
        Namespaced_IRI.parse _namespace_name "referenceIdentifier" |> NamespacedName

    /// <summary>
    /// Source of the external reference (eg. 'Musicbrainz')
    /// <see href="http://tracker.api.gnome.org/ontology/v3/tracker#referenceSource"></see></summary>
    let referenceSource =
        Namespaced_IRI.parse _namespace_name "referenceSource" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/tracker#tagRelatedTo"></see>
    /// </summary>
    let tagRelatedTo =
        Namespaced_IRI.parse _namespace_name "tagRelatedTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/tracker#unmountDate"></see>
    /// </summary>
    let unmountDate =
        Namespaced_IRI.parse _namespace_name "unmountDate" |> NamespacedName

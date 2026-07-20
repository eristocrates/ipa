namespace http.tracker.api.gnome.org.ontology.v3.tracker.hash

open DoxAletheia

module tracker =
    let _namespace_name = "http://tracker.api.gnome.org/ontology/v3/tracker#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// External reference to online services
    /// <see href="http://tracker.api.gnome.org/ontology/v3/tracker#ExternalReference"></see></summary>
    let ExternalReference = _prefix "ExternalReference"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/tracker#IndexedFolder"></see>
    /// </summary>
    let IndexedFolder = _prefix "IndexedFolder"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/tracker#available"></see>
    /// </summary>
    let available = _prefix "available"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/tracker#extractor-data-source"></see>
    /// </summary>
    let ``extractor-data-source`` = _prefix "extractor-data-source"
    /// <summary>
    /// Hash identifying the extractor of the metadata
    /// <see href="http://tracker.api.gnome.org/ontology/v3/tracker#extractorHash"></see></summary>
    let extractorHash = _prefix "extractorHash"
    /// <summary>
    /// Links the information element with the external reference
    /// <see href="http://tracker.api.gnome.org/ontology/v3/tracker#hasExternalReference"></see></summary>
    let hasExternalReference = _prefix "hasExternalReference"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/tracker#isDefaultTag"></see>
    /// </summary>
    let isDefaultTag = _prefix "isDefaultTag"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/tracker#isOptical"></see>
    /// </summary>
    let isOptical = _prefix "isOptical"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/tracker#isRemovable"></see>
    /// </summary>
    let isRemovable = _prefix "isRemovable"
    /// <summary>
    /// Identifier of the external reference
    /// <see href="http://tracker.api.gnome.org/ontology/v3/tracker#referenceIdentifier"></see></summary>
    let referenceIdentifier = _prefix "referenceIdentifier"
    /// <summary>
    /// Source of the external reference (eg. 'Musicbrainz')
    /// <see href="http://tracker.api.gnome.org/ontology/v3/tracker#referenceSource"></see></summary>
    let referenceSource = _prefix "referenceSource"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/tracker#tagRelatedTo"></see>
    /// </summary>
    let tagRelatedTo = _prefix "tagRelatedTo"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/tracker#unmountDate"></see>
    /// </summary>
    let unmountDate = _prefix "unmountDate"

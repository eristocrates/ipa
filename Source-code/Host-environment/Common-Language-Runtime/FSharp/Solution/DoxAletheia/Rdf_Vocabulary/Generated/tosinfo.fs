namespace http.tracker.api.gnome.org.ontology.v3.osinfo.hash

open DoxAletheia.Rdf_Vocabulary

module tosinfo =
    let _namespace_name = "http://tracker.api.gnome.org/ontology/v3/osinfo#"
    /// <summary>
    /// An operating system installer
    /// <see href="http://tracker.api.gnome.org/ontology/v3/osinfo#Installer"></see></summary>
    let Installer = Namespaced_IRI.parse _namespace_name "Installer" |> NamespacedName
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/osinfo#id"></see>
    /// </summary>
    let id = Namespaced_IRI.parse _namespace_name "id" |> NamespacedName
    /// <summary>
    /// Languages supported by installer/live media.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/osinfo#language"></see></summary>
    let language = Namespaced_IRI.parse _namespace_name "language" |> NamespacedName
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/osinfo#mediaId"></see>
    /// </summary>
    let mediaId = Namespaced_IRI.parse _namespace_name "mediaId" |> NamespacedName

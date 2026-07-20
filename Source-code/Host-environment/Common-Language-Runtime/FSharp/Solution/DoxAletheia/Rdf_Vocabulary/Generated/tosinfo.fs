namespace http.tracker.api.gnome.org.ontology.v3.osinfo.hash

open DoxAletheia

module tosinfo =
    let _namespace_name = "http://tracker.api.gnome.org/ontology/v3/osinfo#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An operating system installer
    /// <see href="http://tracker.api.gnome.org/ontology/v3/osinfo#Installer"></see></summary>
    let Installer = _prefix "Installer"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/osinfo#id"></see>
    /// </summary>
    let id = _prefix "id"
    /// <summary>
    /// Languages supported by installer/live media.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/osinfo#language"></see></summary>
    let language = _prefix "language"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/osinfo#mediaId"></see>
    /// </summary>
    let mediaId = _prefix "mediaId"

namespace http.rdf.myexperiment.org.ontologies.snarm.slash

open DoxAletheia.Rdf_Vocabulary

module snarm =
    let _namespace_name = "http://rdf.myexperiment.org/ontologies/snarm/"
    /// <summary>
    /// The Unrestricted Access to an AccessType
    /// <see href="http://rdf.myexperiment.org/ontologies/snarm/Access"></see></summary>
    let Access = Namespaced_IRI.parse _namespace_name "Access" |> NamespacedName

    /// <summary>
    /// The AccessType an Access provides
    /// <see href="http://rdf.myexperiment.org/ontologies/snarm/has-access-type"></see></summary>
    let ``has-access-type`` =
        Namespaced_IRI.parse _namespace_name "has-access-type" |> NamespacedName

    /// <summary>
    /// The Accesser that is getting access
    /// <see href="http://rdf.myexperiment.org/ontologies/snarm/Accesser"></see></summary>
    let Accesser = Namespaced_IRI.parse _namespace_name "Accesser" |> NamespacedName
    /// <summary>
    /// The AccessType that is being giving, e.g. view, edit, download, etc.
    /// <see href="http://rdf.myexperiment.org/ontologies/snarm/AccessType"></see></summary>
    let AccessType = Namespaced_IRI.parse _namespace_name "AccessType" |> NamespacedName
    /// <summary>
    /// A Policy for the access rights to an object for users in the social network
    /// <see href="http://rdf.myexperiment.org/ontologies/snarm/Policy"></see></summary>
    let Policy = Namespaced_IRI.parse _namespace_name "Policy" |> NamespacedName

    /// <summary>
    /// The restricted Access to an AccessType
    /// <see href="http://rdf.myexperiment.org/ontologies/snarm/RestrictedAccess"></see></summary>
    let RestrictedAccess =
        Namespaced_IRI.parse _namespace_name "RestrictedAccess" |> NamespacedName

    /// <summary>
    /// An Accesser that a Mode provides access to
    /// <see href="http://rdf.myexperiment.org/ontologies/snarm/has-accesser"></see></summary>
    let ``has-accesser`` =
        Namespaced_IRI.parse _namespace_name "has-accesser" |> NamespacedName

    /// <summary>
    /// An Access that a Policy provides
    /// <see href="http://rdf.myexperiment.org/ontologies/snarm/has-access"></see></summary>
    let ``has-access`` =
        Namespaced_IRI.parse _namespace_name "has-access" |> NamespacedName

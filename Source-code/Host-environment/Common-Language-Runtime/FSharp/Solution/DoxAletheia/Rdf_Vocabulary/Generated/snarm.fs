namespace http.rdf.myexperiment.org.ontologies.snarm.slash

open DoxAletheia

module snarm =
    let _namespace_name = "http://rdf.myexperiment.org/ontologies/snarm/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The Unrestricted Access to an AccessType
    /// <see href="http://rdf.myexperiment.org/ontologies/snarm/Access"></see></summary>
    let Access = _prefix "Access"
    /// <summary>
    /// The AccessType an Access provides
    /// <see href="http://rdf.myexperiment.org/ontologies/snarm/has-access-type"></see></summary>
    let ``has-access-type`` = _prefix "has-access-type"
    /// <summary>
    /// The Accesser that is getting access
    /// <see href="http://rdf.myexperiment.org/ontologies/snarm/Accesser"></see></summary>
    let Accesser = _prefix "Accesser"
    /// <summary>
    /// The AccessType that is being giving, e.g. view, edit, download, etc.
    /// <see href="http://rdf.myexperiment.org/ontologies/snarm/AccessType"></see></summary>
    let AccessType = _prefix "AccessType"
    /// <summary>
    /// A Policy for the access rights to an object for users in the social network
    /// <see href="http://rdf.myexperiment.org/ontologies/snarm/Policy"></see></summary>
    let Policy = _prefix "Policy"
    /// <summary>
    /// The restricted Access to an AccessType
    /// <see href="http://rdf.myexperiment.org/ontologies/snarm/RestrictedAccess"></see></summary>
    let RestrictedAccess = _prefix "RestrictedAccess"
    /// <summary>
    /// An Accesser that a Mode provides access to
    /// <see href="http://rdf.myexperiment.org/ontologies/snarm/has-accesser"></see></summary>
    let ``has-accesser`` = _prefix "has-accesser"
    /// <summary>
    /// An Access that a Policy provides
    /// <see href="http://rdf.myexperiment.org/ontologies/snarm/has-access"></see></summary>
    let ``has-access`` = _prefix "has-access"

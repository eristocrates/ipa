namespace https.spec.edmcouncil.org.fibo.ontology.FND.Organizations.FormalOrganizations.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_org_fm =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/Employee"></see>
    /// </summary>
    let Employee = Namespaced_IRI.parse _namespace_name "Employee" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/isEmployedIn"></see>
    /// </summary>
    let isEmployedIn =
        Namespaced_IRI.parse _namespace_name "isEmployedIn" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/Employment"></see>
    /// </summary>
    let Employment = Namespaced_IRI.parse _namespace_name "Employment" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/isEmployeeOf"></see>
    /// </summary>
    let isEmployeeOf =
        Namespaced_IRI.parse _namespace_name "isEmployeeOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/Employer"></see>
    /// </summary>
    let Employer = Namespaced_IRI.parse _namespace_name "Employer" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/hasEmployee"></see>
    /// </summary>
    let hasEmployee =
        Namespaced_IRI.parse _namespace_name "hasEmployee" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/isEmployingParty"></see>
    /// </summary>
    let isEmployingParty =
        Namespaced_IRI.parse _namespace_name "isEmployingParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/hasEmployedParty"></see>
    /// </summary>
    let hasEmployedParty =
        Namespaced_IRI.parse _namespace_name "hasEmployedParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/hasEmployingParty"></see>
    /// </summary>
    let hasEmployingParty =
        Namespaced_IRI.parse _namespace_name "hasEmployingParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/Group"></see>
    /// </summary>
    let Group = Namespaced_IRI.parse _namespace_name "Group" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/employs"></see>
    /// </summary>
    let employs = Namespaced_IRI.parse _namespace_name "employs" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/isEmployedBy"></see>
    /// </summary>
    let isEmployedBy =
        Namespaced_IRI.parse _namespace_name "isEmployedBy" |> NamespacedName

namespace https.spec.edmcouncil.org.fibo.ontology.FND.Organizations.FormalOrganizations.slash

open DoxAletheia

module fibo_fnd_org_fm =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/Employee"></see>
    /// </summary>
    let Employee = _prefix "Employee"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/isEmployedIn"></see>
    /// </summary>
    let isEmployedIn = _prefix "isEmployedIn"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/Employment"></see>
    /// </summary>
    let Employment = _prefix "Employment"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/isEmployeeOf"></see>
    /// </summary>
    let isEmployeeOf = _prefix "isEmployeeOf"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/Employer"></see>
    /// </summary>
    let Employer = _prefix "Employer"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/hasEmployee"></see>
    /// </summary>
    let hasEmployee = _prefix "hasEmployee"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/isEmployingParty"></see>
    /// </summary>
    let isEmployingParty = _prefix "isEmployingParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/hasEmployedParty"></see>
    /// </summary>
    let hasEmployedParty = _prefix "hasEmployedParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/hasEmployingParty"></see>
    /// </summary>
    let hasEmployingParty = _prefix "hasEmployingParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/Group"></see>
    /// </summary>
    let Group = _prefix "Group"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/employs"></see>
    /// </summary>
    let employs = _prefix "employs"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/isEmployedBy"></see>
    /// </summary>
    let isEmployedBy = _prefix "isEmployedBy"

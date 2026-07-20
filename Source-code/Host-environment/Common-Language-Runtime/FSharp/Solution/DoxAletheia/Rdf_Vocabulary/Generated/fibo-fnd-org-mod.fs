namespace https.spec.edmcouncil.org.fibo.ontology.FND.Organizations.MetadataFNDOrganizations.slash

open DoxAletheia

module fibo_fnd_org_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/MetadataFNDOrganizations/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/MetadataFNDOrganizations/OrganizationsModule"></see>
    /// </summary>
    let OrganizationsModule = _prefix "OrganizationsModule"

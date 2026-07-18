namespace https.spec.edmcouncil.org.fibo.ontology.FND.Organizations.MetadataFNDOrganizations.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_org_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/MetadataFNDOrganizations/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/MetadataFNDOrganizations/OrganizationsModule"></see>
    /// </summary>
    let OrganizationsModule =
        Namespaced_IRI.parse _namespace_name "OrganizationsModule" |> NamespacedName

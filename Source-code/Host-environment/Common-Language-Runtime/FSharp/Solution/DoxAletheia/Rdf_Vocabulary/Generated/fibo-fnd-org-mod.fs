namespace https.spec.edmcouncil.org.fibo.ontology.FND.Organizations.MetadataFNDOrganizations.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_org_mod =
    let _namespace_iri = Namespace_Iri fibo_fnd_org_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-org-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata for the EDMC-FIBO Foundations (FND) Organizations Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/MetadataFNDOrganizations/">https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/MetadataFNDOrganizations/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_org_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-org-mod:OrganizationsModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"organizations module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/MetadataFNDOrganizations/OrganizationsModule">https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/MetadataFNDOrganizations/OrganizationsModule</seealso>
    let OrganizationsModule =
        Prefixed_Name(fibo_fnd_org_mod, "OrganizationsModule") |> PrefixedName

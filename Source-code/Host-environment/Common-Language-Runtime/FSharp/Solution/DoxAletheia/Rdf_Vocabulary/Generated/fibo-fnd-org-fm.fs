namespace https.spec.edmcouncil.org.fibo.ontology.FND.Organizations.FormalOrganizations.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_org_fm =
    let _namespace_iri = Namespace_Iri fibo_fnd_org_fm |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-org-fm:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Formal Organizations Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/">https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_org_fm, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-org-fm:Employee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"employee"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/Employee">https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/Employee</seealso>
    let Employee = Prefixed_Name(fibo_fnd_org_fm, "Employee") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-org-fm:Employer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"employer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/Employer">https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/Employer</seealso>
    let Employer = Prefixed_Name(fibo_fnd_org_fm, "Employer") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-org-fm:Employment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"employment"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/Employment">https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/Employment</seealso>
    let Employment = Prefixed_Name(fibo_fnd_org_fm, "Employment") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-org-fm:Group</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/Group">https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/Group</seealso>
    let Group = Prefixed_Name(fibo_fnd_org_fm, "Group") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-org-fm:employs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"employs"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/employs">https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/employs</seealso>
    let employs = Prefixed_Name(fibo_fnd_org_fm, "employs") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-org-fm:hasEmployedParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has employed party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/hasEmployedParty">https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/hasEmployedParty</seealso>
    let hasEmployedParty =
        Prefixed_Name(fibo_fnd_org_fm, "hasEmployedParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-org-fm:hasEmployee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has employee"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/hasEmployee">https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/hasEmployee</seealso>
    let hasEmployee = Prefixed_Name(fibo_fnd_org_fm, "hasEmployee") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-org-fm:hasEmployingParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has employing party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/hasEmployingParty">https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/hasEmployingParty</seealso>
    let hasEmployingParty =
        Prefixed_Name(fibo_fnd_org_fm, "hasEmployingParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-org-fm:isEmployedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is employed by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/isEmployedBy">https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/isEmployedBy</seealso>
    let isEmployedBy = Prefixed_Name(fibo_fnd_org_fm, "isEmployedBy") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-org-fm:isEmployedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is employed in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/isEmployedIn">https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/isEmployedIn</seealso>
    let isEmployedIn = Prefixed_Name(fibo_fnd_org_fm, "isEmployedIn") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-org-fm:isEmployeeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is employee of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/isEmployeeOf">https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/isEmployeeOf</seealso>
    let isEmployeeOf = Prefixed_Name(fibo_fnd_org_fm, "isEmployeeOf") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-org-fm:isEmployingParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is employing party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/isEmployingParty">https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/isEmployingParty</seealso>
    let isEmployingParty =
        Prefixed_Name(fibo_fnd_org_fm, "isEmployingParty") |> PrefixedName

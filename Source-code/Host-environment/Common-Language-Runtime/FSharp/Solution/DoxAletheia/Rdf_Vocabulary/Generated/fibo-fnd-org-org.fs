namespace https.spec.edmcouncil.org.fibo.ontology.FND.Organizations.Organizations.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_org_org =
    let _namespace_iri = Namespace_Iri fibo_fnd_org_org |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-org-org:ContactPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/Organizations/ContactPoint">https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/Organizations/ContactPoint</seealso>
    let ContactPoint = Prefixed_Name(fibo_fnd_org_org, "ContactPoint") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-org-org:Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/Organizations/Organization">https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/Organizations/Organization</seealso>
    let Organization = Prefixed_Name(fibo_fnd_org_org, "Organization") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-org-org:hasContactPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/Organizations/hasContactPoint">https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/Organizations/hasContactPoint</seealso>
    let hasContactPoint =
        Prefixed_Name(fibo_fnd_org_org, "hasContactPoint") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-org-org:hasMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/Organizations/hasMember">https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/Organizations/hasMember</seealso>
    let hasMember = Prefixed_Name(fibo_fnd_org_org, "hasMember") |> PrefixedName

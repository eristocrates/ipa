namespace https.spec.edmcouncil.org.fibo.ontology.LOAN.MetadataLOAN.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_loan_mod =
    let _namespace_iri = Namespace_Iri fibo_loan_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-loan-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata for the FIBO Loans (LOAN) Domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/MetadataLOAN/">https://spec.edmcouncil.org/fibo/ontology/LOAN/MetadataLOAN/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_loan_mod, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-loan-mod:LOANDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"loan domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/MetadataLOAN/LOANDomain">https://spec.edmcouncil.org/fibo/ontology/LOAN/MetadataLOAN/LOANDomain</seealso>
    let LOANDomain = Prefixed_Name(fibo_loan_mod, "LOANDomain") |> PrefixedName

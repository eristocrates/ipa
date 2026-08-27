namespace https.spec.edmcouncil.org.fibo.ontology.LOAN.LoansGeneral.MetadataLOANLoansGeneral.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_loan_ln_mod =
    let _namespace_iri = Namespace_Iri fibo_loan_ln_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-loan-ln-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata for the EDMC-FIBO Loans (LOAN) Loans General Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/MetadataLOANLoansGeneral/">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/MetadataLOANLoansGeneral/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_loan_ln_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-ln-mod:LoansGeneralModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"loans general module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/MetadataLOANLoansGeneral/LoansGeneralModule">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/MetadataLOANLoansGeneral/LoansGeneralModule</seealso>
    let LoansGeneralModule =
        Prefixed_Name(fibo_loan_ln_mod, "LoansGeneralModule") |> PrefixedName

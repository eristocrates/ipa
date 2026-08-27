namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FinancialInstruments.MetadataFBCFinancialInstruments.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fbc_fi_mod =
    let _namespace_iri = Namespace_Iri fibo_fbc_fi_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fbc-fi-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata about the EDMC-FIBO Financial Business and Commerce(FBC) Financial Instruments Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/MetadataFBCFinancialInstruments/">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/MetadataFBCFinancialInstruments/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fbc_fi_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-mod:FinancialInstrumentsModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"financial instruments module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/MetadataFBCFinancialInstruments/FinancialInstrumentsModule">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/MetadataFBCFinancialInstruments/FinancialInstrumentsModule</seealso>
    let FinancialInstrumentsModule =
        Prefixed_Name(fibo_fbc_fi_mod, "FinancialInstrumentsModule") |> PrefixedName

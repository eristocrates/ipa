namespace https.spec.edmcouncil.org.fibo.ontology.IND.InterestRates.MetadataINDInterestRates.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_ind_ir_mod =
    let _namespace_iri = Namespace_Iri fibo_ind_ir_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-ind-ir-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata about the EDMC-FIBO Indices and Indicators (IND) Interest Rates Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MetadataINDInterestRates/">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MetadataINDInterestRates/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_ind_ir_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-mod:InterestRatesModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"interest rates module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MetadataINDInterestRates/InterestRatesModule">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MetadataINDInterestRates/InterestRatesModule</seealso>
    let InterestRatesModule =
        Prefixed_Name(fibo_ind_ir_mod, "InterestRatesModule") |> PrefixedName

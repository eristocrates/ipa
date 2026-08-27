namespace https.spec.edmcouncil.org.fibo.ontology.IND.ForeignExchange.MetadataINDForeignExchange.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_ind_fx_mod =
    let _namespace_iri = Namespace_Iri fibo_ind_fx_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-ind-fx-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata about the EDMC-FIBO Indices and Indicators (IND) Foreign Exchange Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/MetadataINDForeignExchange/">https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/MetadataINDForeignExchange/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_ind_fx_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-fx-mod:ForeignExchangeModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"foreign exchange module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/MetadataINDForeignExchange/ForeignExchangeModule">https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/MetadataINDForeignExchange/ForeignExchangeModule</seealso>
    let ForeignExchangeModule =
        Prefixed_Name(fibo_ind_fx_mod, "ForeignExchangeModule") |> PrefixedName

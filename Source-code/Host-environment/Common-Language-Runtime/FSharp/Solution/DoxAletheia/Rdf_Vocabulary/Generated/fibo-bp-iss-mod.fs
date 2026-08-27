namespace https.spec.edmcouncil.org.fibo.ontology.BP.SecuritiesIssuance.MetadataBPSecuritiesIssuance.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_bp_iss_mod =
    let _namespace_iri = Namespace_Iri fibo_bp_iss_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-bp-iss-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata for the EDMC-FIBO Business Process (BP) Securities Issuance Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BP/SecuritiesIssuance/MetadataBPSecuritiesIssuance/">https://spec.edmcouncil.org/fibo/ontology/BP/SecuritiesIssuance/MetadataBPSecuritiesIssuance/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_bp_iss_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-bp-iss-mod:SecuritiesIssuanceModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"securities issuance module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BP/SecuritiesIssuance/MetadataBPSecuritiesIssuance/SecuritiesIssuanceModule">https://spec.edmcouncil.org/fibo/ontology/BP/SecuritiesIssuance/MetadataBPSecuritiesIssuance/SecuritiesIssuanceModule</seealso>
    let SecuritiesIssuanceModule =
        Prefixed_Name(fibo_bp_iss_mod, "SecuritiesIssuanceModule") |> PrefixedName

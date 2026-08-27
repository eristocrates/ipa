namespace https.spec.edmcouncil.org.fibo.ontology.CAE.CorporateEvents.MetadataCAECorporateEvents.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_cae_ce_mod =
    let _namespace_iri = Namespace_Iri fibo_cae_ce_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-cae-ce-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata for the EDMC-FIBO Corporate Actions and Events (CAE) Corporate Events Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/MetadataCAECorporateEvents/">https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/MetadataCAECorporateEvents/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_cae_ce_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-cae-ce-mod:CorporateEventsModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"corporate events module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/MetadataCAECorporateEvents/CorporateEventsModule">https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/MetadataCAECorporateEvents/CorporateEventsModule</seealso>
    let CorporateEventsModule =
        Prefixed_Name(fibo_cae_ce_mod, "CorporateEventsModule") |> PrefixedName

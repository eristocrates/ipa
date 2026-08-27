namespace https.spec.edmcouncil.org.fibo.ontology.CAE.MetadataCAE.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_cae_mod =
    let _namespace_iri = Namespace_Iri fibo_cae_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-cae-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata about the FIBO Corporate Actions and Events (CAE) Domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/CAE/MetadataCAE/">https://spec.edmcouncil.org/fibo/ontology/CAE/MetadataCAE/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_cae_mod, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-cae-mod:CAEDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"corporate actions and events domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/CAE/MetadataCAE/CAEDomain">https://spec.edmcouncil.org/fibo/ontology/CAE/MetadataCAE/CAEDomain</seealso>
    let CAEDomain = Prefixed_Name(fibo_cae_mod, "CAEDomain") |> PrefixedName

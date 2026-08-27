namespace https.spec.edmcouncil.org.fibo.ontology.FBC.MetadataFBC.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fbc_mod =
    let _namespace_iri = Namespace_Iri fibo_fbc_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fbc-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata about the FIBO Financial Business and Commerce (FBC) Domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/MetadataFBC/">https://spec.edmcouncil.org/fibo/ontology/FBC/MetadataFBC/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fbc_mod, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-mod:FBCDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"financial business and commerce domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/MetadataFBC/FBCDomain">https://spec.edmcouncil.org/fibo/ontology/FBC/MetadataFBC/FBCDomain</seealso>
    let FBCDomain = Prefixed_Name(fibo_fbc_mod, "FBCDomain") |> PrefixedName

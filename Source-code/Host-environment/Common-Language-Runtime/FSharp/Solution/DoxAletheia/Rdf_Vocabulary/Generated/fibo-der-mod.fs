namespace https.spec.edmcouncil.org.fibo.ontology.DER.MetadataDER.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_der_mod =
    let _namespace_iri = Namespace_Iri fibo_der_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-der-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata about the FIBO Derivatives (DER) Domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/MetadataDER/">https://spec.edmcouncil.org/fibo/ontology/DER/MetadataDER/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_der_mod, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-mod:DERDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"derivatives domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/MetadataDER/DERDomain">https://spec.edmcouncil.org/fibo/ontology/DER/MetadataDER/DERDomain</seealso>
    let DERDomain = Prefixed_Name(fibo_der_mod, "DERDomain") |> PrefixedName

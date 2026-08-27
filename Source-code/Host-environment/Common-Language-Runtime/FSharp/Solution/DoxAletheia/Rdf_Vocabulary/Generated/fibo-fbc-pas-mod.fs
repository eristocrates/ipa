namespace https.spec.edmcouncil.org.fibo.ontology.FBC.ProductsAndServices.MetadataFBCProductsAndServices.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fbc_pas_mod =
    let _namespace_iri = Namespace_Iri fibo_fbc_pas_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fbc-pas-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata about the EDMC-FIBO Financial Business and Commerce(FBC) Products and Services Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/MetadataFBCProductsAndServices/">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/MetadataFBCProductsAndServices/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fbc_pas_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-mod:FBCProductsAndServicesModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"products and services module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/MetadataFBCProductsAndServices/FBCProductsAndServicesModule">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/MetadataFBCProductsAndServices/FBCProductsAndServicesModule</seealso>
    let FBCProductsAndServicesModule =
        Prefixed_Name(fibo_fbc_pas_mod, "FBCProductsAndServicesModule") |> PrefixedName

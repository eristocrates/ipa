namespace https.spec.edmcouncil.org.fibo.ontology.FND.ProductsAndServices.MetadataFNDProductsAndServices.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_pas_mod =
    let _namespace_iri = Namespace_Iri fibo_fnd_pas_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-pas-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata for the EDMC-FIBO Foundations (FND) Products and Services Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/MetadataFNDProductsAndServices/">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/MetadataFNDProductsAndServices/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_pas_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-pas-mod:ProductsAndServicesModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"products and services module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/MetadataFNDProductsAndServices/ProductsAndServicesModule">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/MetadataFNDProductsAndServices/ProductsAndServicesModule</seealso>
    let ProductsAndServicesModule =
        Prefixed_Name(fibo_fnd_pas_mod, "ProductsAndServicesModule") |> PrefixedName

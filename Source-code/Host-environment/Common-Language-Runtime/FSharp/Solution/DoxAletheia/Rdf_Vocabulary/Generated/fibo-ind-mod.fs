namespace https.spec.edmcouncil.org.fibo.ontology.IND.MetadataIND.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_ind_mod =
    let _namespace_iri = Namespace_Iri fibo_ind_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-ind-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata about the FIBO Indices and Indicators (IND) Domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/MetadataIND/">https://spec.edmcouncil.org/fibo/ontology/IND/MetadataIND/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_ind_mod, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-mod:INDDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"indices and indicators module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/MetadataIND/INDDomain">https://spec.edmcouncil.org/fibo/ontology/IND/MetadataIND/INDDomain</seealso>
    let INDDomain = Prefixed_Name(fibo_ind_mod, "INDDomain") |> PrefixedName

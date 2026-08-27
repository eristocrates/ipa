namespace https.spec.edmcouncil.org.fibo.ontology.BE.MetadataBE.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_be_mod =
    let _namespace_iri = Namespace_Iri fibo_be_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-be-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata about the FIBO Business Entities (BE) Domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/MetadataBE/">https://spec.edmcouncil.org/fibo/ontology/BE/MetadataBE/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_be_mod, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-be-mod:BEDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"business entities (BE) domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/MetadataBE/BEDomain">https://spec.edmcouncil.org/fibo/ontology/BE/MetadataBE/BEDomain</seealso>
    let BEDomain = Prefixed_Name(fibo_be_mod, "BEDomain") |> PrefixedName

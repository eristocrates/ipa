namespace https.spec.edmcouncil.org.fibo.ontology.MetadataFIBO.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_spec =
    let _namespace_iri = Namespace_Iri fibo_spec |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-spec:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata for FIBO"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/MetadataFIBO/">https://spec.edmcouncil.org/fibo/ontology/MetadataFIBO/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_spec, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-spec:FIBOSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"FIBO Specification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/MetadataFIBO/FIBOSpecification">https://spec.edmcouncil.org/fibo/ontology/MetadataFIBO/FIBOSpecification</seealso>
    let FIBOSpecification =
        Prefixed_Name(fibo_spec, "FIBOSpecification") |> PrefixedName

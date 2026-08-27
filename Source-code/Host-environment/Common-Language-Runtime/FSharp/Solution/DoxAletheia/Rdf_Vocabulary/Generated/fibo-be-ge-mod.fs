namespace https.spec.edmcouncil.org.fibo.ontology.BE.GovernmentEntities.MetadataBEGovernmentEntities.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_be_ge_mod =
    let _namespace_iri = Namespace_Iri fibo_be_ge_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-be-ge-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata about the EDMC-FIBO Business Entities (BE) Government Entities Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/MetadataBEGovernmentEntities/">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/MetadataBEGovernmentEntities/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_be_ge_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-mod:GovernmentEntitiesModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"government entities module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/MetadataBEGovernmentEntities/GovernmentEntitiesModule">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/MetadataBEGovernmentEntities/GovernmentEntitiesModule</seealso>
    let GovernmentEntitiesModule =
        Prefixed_Name(fibo_be_ge_mod, "GovernmentEntitiesModule") |> PrefixedName

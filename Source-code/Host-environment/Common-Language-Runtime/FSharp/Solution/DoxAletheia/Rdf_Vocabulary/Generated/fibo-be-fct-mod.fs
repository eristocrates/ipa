namespace https.spec.edmcouncil.org.fibo.ontology.BE.FunctionalEntities.MetadataBEFunctionalEntities.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_be_fct_mod =
    let _namespace_iri = Namespace_Iri fibo_be_fct_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-be-fct-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata about the EDMC-FIBO Business Entities (BE) Functional Entities Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/MetadataBEFunctionalEntities/">https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/MetadataBEFunctionalEntities/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_be_fct_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-fct-mod:FunctionalEntitiesModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"functional entities module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/MetadataBEFunctionalEntities/FunctionalEntitiesModule">https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/MetadataBEFunctionalEntities/FunctionalEntitiesModule</seealso>
    let FunctionalEntitiesModule =
        Prefixed_Name(fibo_be_fct_mod, "FunctionalEntitiesModule") |> PrefixedName

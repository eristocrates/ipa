namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FunctionalEntities.MetadataFBCFunctionalEntities.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fbc_fct_mod =
    let _namespace_iri = Namespace_Iri fibo_fbc_fct_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fbc-fct-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata about the FIBO Financial Business and Commerce (FBC) Functional Entities Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/MetadataFBCFunctionalEntities/">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/MetadataFBCFunctionalEntities/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fbc_fct_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-mod:FunctionalEntitiesModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"functional entities module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/MetadataFBCFunctionalEntities/FunctionalEntitiesModule">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/MetadataFBCFunctionalEntities/FunctionalEntitiesModule</seealso>
    let FunctionalEntitiesModule =
        Prefixed_Name(fibo_fbc_fct_mod, "FunctionalEntitiesModule") |> PrefixedName

namespace https.spec.edmcouncil.org.fibo.ontology.EXMP.LegalEntities.MetadataEXMPLegalEntities.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_exmp_le_mod =
    let _namespace_iri = Namespace_Iri fibo_exmp_le_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-exmp-le-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata about the FIBO Example Legal Entities Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MetadataEXMPLegalEntities/">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MetadataEXMPLegalEntities/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_exmp_le_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-mod:ExampleLegalEntitiesModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"example legal entities module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MetadataEXMPLegalEntities/ExampleLegalEntitiesModule">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MetadataEXMPLegalEntities/ExampleLegalEntitiesModule</seealso>
    let ExampleLegalEntitiesModule =
        Prefixed_Name(fibo_exmp_le_mod, "ExampleLegalEntitiesModule") |> PrefixedName

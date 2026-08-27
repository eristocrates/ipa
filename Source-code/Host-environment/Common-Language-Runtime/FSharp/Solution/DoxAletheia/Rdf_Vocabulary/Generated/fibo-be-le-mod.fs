namespace https.spec.edmcouncil.org.fibo.ontology.BE.LegalEntities.MetadataBELegalEntities.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_be_le_mod =
    let _namespace_iri = Namespace_Iri fibo_be_le_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-be-le-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata about the EDMC-FIBO Business Entities (BE) Legal Entities Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/MetadataBELegalEntities/">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/MetadataBELegalEntities/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_be_le_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-le-mod:LegalEntitiesModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"legal entities module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/MetadataBELegalEntities/LegalEntitiesModule">https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/MetadataBELegalEntities/LegalEntitiesModule</seealso>
    let LegalEntitiesModule =
        Prefixed_Name(fibo_be_le_mod, "LegalEntitiesModule") |> PrefixedName

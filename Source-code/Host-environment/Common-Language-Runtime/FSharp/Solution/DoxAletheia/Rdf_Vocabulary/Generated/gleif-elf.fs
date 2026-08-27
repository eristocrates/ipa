namespace https.www.gleif.org.ontology.EntityLegalForm.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module gleif_elf =
    let _namespace_iri = Namespace_Iri gleif_elf |> NamespaceIRI
    /// <summary>
    ///   <para>gleif-elf:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>voaf:Vocabulary</para>
    ///
    /// labels<para>"Entity Legal Form Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/EntityLegalForm/">https://www.gleif.org/ontology/EntityLegalForm/</seealso>
    let _prefix_iri = Prefixed_Name(gleif_elf, "") |> PrefixedName
    /// <summary>
    ///   <para>gleif-elf:ELFregistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>gleif-base:Registry</para>
    ///
    /// labels<para>"ELF registry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/EntityLegalForm/ELFregistry">https://www.gleif.org/ontology/EntityLegalForm/ELFregistry</seealso>
    let ELFregistry = Prefixed_Name(gleif_elf, "ELFregistry") |> PrefixedName
    /// <summary>
    ///   <para>gleif-elf:EntityLegalForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"entity legal form"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/EntityLegalForm/EntityLegalForm">https://www.gleif.org/ontology/EntityLegalForm/EntityLegalForm</seealso>
    let EntityLegalForm = Prefixed_Name(gleif_elf, "EntityLegalForm") |> PrefixedName

    /// <summary>
    ///   <para>gleif-elf:EntityLegalFormIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"entity legal form identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/EntityLegalForm/EntityLegalFormIdentifier">https://www.gleif.org/ontology/EntityLegalForm/EntityLegalFormIdentifier</seealso>
    let EntityLegalFormIdentifier =
        Prefixed_Name(gleif_elf, "EntityLegalFormIdentifier") |> PrefixedName

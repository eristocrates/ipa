namespace http.voag.linkedmodel.org.schema.voag.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module voag =
    let _namespace_iri = Namespace_Iri voag |> NamespaceIRI
    /// <summary>
    ///   <para>voag:QUDT-Attribution</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://voag.linkedmodel.org/schema/voag#QUDT-Attribution">http://voag.linkedmodel.org/schema/voag#QUDT-Attribution</seealso>
    let QUDT_Attribution = Prefixed_Name(voag, "QUDT-Attribution") |> PrefixedName

    /// <summary>
    ///   <para>voag:QUDT-DIMENSIONS-VocabCatalogEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>vaem:CatalogEntry</para>
    ///
    /// labels<para>"QUDT DIMENSIONS Vocab Catalog Entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/schema/voag#QUDT-DIMENSIONS-VocabCatalogEntry">http://voag.linkedmodel.org/schema/voag#QUDT-DIMENSIONS-VocabCatalogEntry</seealso>
    let QUDT_DIMENSIONS_VocabCatalogEntry =
        Prefixed_Name(voag, "QUDT-DIMENSIONS-VocabCatalogEntry") |> PrefixedName

    /// <summary>
    ///   <para>voag:QUDT-QUANTITY-KINDS-VocabCatalogEntry_v1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>vaem:CatalogEntry</para>
    ///
    /// labels<para>"QUDT Quantity Kinds Vocabulary Catalog Entry v1.2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/schema/voag#QUDT-QUANTITY-KINDS-VocabCatalogEntry_v1.2">http://voag.linkedmodel.org/schema/voag#QUDT-QUANTITY-KINDS-VocabCatalogEntry_v1.2</seealso>
    let ``QUDT_QUANTITY_KINDS_VocabCatalogEntry_v1.2`` =
        Prefixed_Name(voag, "QUDT-QUANTITY-KINDS-VocabCatalogEntry_v1.2") |> PrefixedName

    /// <summary>
    ///   <para>voag:QUDT-SchemaCatalogEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>vaem:CatalogEntry</para>
    ///
    /// labels<para>"QUDT Schema Catalog Entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/schema/voag#QUDT-SchemaCatalogEntry">http://voag.linkedmodel.org/schema/voag#QUDT-SchemaCatalogEntry</seealso>
    let QUDT_SchemaCatalogEntry =
        Prefixed_Name(voag, "QUDT-SchemaCatalogEntry") |> PrefixedName

    /// <summary>
    ///   <para>voag:supersededBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"superseded by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://voag.linkedmodel.org/schema/voag#supersededBy">http://voag.linkedmodel.org/schema/voag#supersededBy</seealso>
    let supersededBy = Prefixed_Name(voag, "supersededBy") |> PrefixedName

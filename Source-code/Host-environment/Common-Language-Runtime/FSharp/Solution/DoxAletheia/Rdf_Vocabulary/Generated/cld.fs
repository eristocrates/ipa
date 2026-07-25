namespace http.purl.org.cld.terms.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cld =
    let _namespace_iri = Namespace_Iri cld |> NamespaceIRI
    /// <summary>
    ///   <para>cld:AccrualMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>A set of methods by which items are added to a collection.</para>
    /// labels<para>Collection Description Accrual Method Vocabulary</para></remarks>
    /// <seealso href="http://purl.org/cld/terms/AccrualMethod">http://purl.org/cld/terms/AccrualMethod</seealso>
    let AccrualMethod = Prefixed_Name(cld, "AccrualMethod") |> PrefixedName
    /// <summary>
    ///   <para>cld:CDType</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>A set of types of collection description.</para>
    /// labels<para>Collection Description Type Vocabulary</para></remarks>
    /// <seealso href="http://purl.org/cld/terms/CDType">http://purl.org/cld/terms/CDType</seealso>
    let CDType = Prefixed_Name(cld, "CDType") |> PrefixedName
    /// <summary>
    ///   <para>cld:catalogueOrIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A catalogue for, or index of, the collection.</para>
    /// labels<para>Catalogue or Index</para></remarks>
    /// <seealso href="http://purl.org/cld/terms/catalogueOrIndex">http://purl.org/cld/terms/catalogueOrIndex</seealso>
    let catalogueOrIndex = Prefixed_Name(cld, "catalogueOrIndex") |> PrefixedName

    /// <summary>
    ///   <para>cld:associatedCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A second collection that is associated with the current collection.</para>
    /// labels<para>Associated Collection</para></remarks>
    /// <seealso href="http://purl.org/cld/terms/associatedCollection">http://purl.org/cld/terms/associatedCollection</seealso>
    let associatedCollection =
        Prefixed_Name(cld, "associatedCollection") |> PrefixedName

    /// <summary>
    ///   <para>cld:describedCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A collection that is described by the current collection.</para>
    /// labels<para>Described Collection</para></remarks>
    /// <seealso href="http://purl.org/cld/terms/describedCollection">http://purl.org/cld/terms/describedCollection</seealso>
    let describedCollection = Prefixed_Name(cld, "describedCollection") |> PrefixedName
    /// <summary>
    ///   <para>cld:isLocatedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A location where the collection is held.</para>
    /// labels<para>Is Located At</para></remarks>
    /// <seealso href="http://purl.org/cld/terms/isLocatedAt">http://purl.org/cld/terms/isLocatedAt</seealso>
    let isLocatedAt = Prefixed_Name(cld, "isLocatedAt") |> PrefixedName
    /// <summary>
    ///   <para>cld:RKMS-ISO8601</para>
    /// </summary>
    /// <remarks>
    ///   <para>Instances of this datatype are dates or periods of time represented as literals according to the rules specified in Recordkeeping Metadata Schema Extension to ISO8601.</para>
    /// labels<para>Recordkeeping Metadata Schema Extension to ISO8601</para></remarks>
    /// <seealso href="http://purl.org/cld/terms/RKMS-ISO8601">http://purl.org/cld/terms/RKMS-ISO8601</seealso>
    let RKMS_ISO8601 = Prefixed_Name(cld, "RKMS-ISO8601") |> PrefixedName
    /// <summary>
    ///   <para>cld:itemFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The media type, physical or digital, of one or more items within the collection.</para>
    /// labels<para>Item Format</para></remarks>
    /// <seealso href="http://purl.org/cld/terms/itemFormat">http://purl.org/cld/terms/itemFormat</seealso>
    let itemFormat = Prefixed_Name(cld, "itemFormat") |> PrefixedName
    /// <summary>
    ///   <para>cld:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/cld/terms/">http://purl.org/cld/terms/</seealso>
    let _prefix_iri = Prefixed_Name(cld, "") |> PrefixedName
    /// <summary>
    ///   <para>cld:AccrualPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>A set of policies governing the addition of items are added to a collection.</para>
    /// labels<para>Collection Description Accrual Policy Vocabulary</para></remarks>
    /// <seealso href="http://purl.org/cld/terms/AccrualPolicy">http://purl.org/cld/terms/AccrualPolicy</seealso>
    let AccrualPolicy = Prefixed_Name(cld, "AccrualPolicy") |> PrefixedName
    /// <summary>
    ///   <para>cld:Frequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>A set of frequencies with which a repeatable event occurs..</para>
    /// labels<para>Collection Description Frequency Vocabulary</para></remarks>
    /// <seealso href="http://purl.org/cld/terms/Frequency">http://purl.org/cld/terms/Frequency</seealso>
    let Frequency = Prefixed_Name(cld, "Frequency") |> PrefixedName
    /// <summary>
    ///   <para>cld:dateItemsCreated</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A range of dates over which the individual items within the collection were created.</para>
    /// labels<para>Date Items Created</para></remarks>
    /// <seealso href="http://purl.org/cld/terms/dateItemsCreated">http://purl.org/cld/terms/dateItemsCreated</seealso>
    let dateItemsCreated = Prefixed_Name(cld, "dateItemsCreated") |> PrefixedName
    /// <summary>
    ///   <para>cld:isAccessedVia</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A service that provides access to the items within the collection.</para>
    /// labels<para>Is Accessed Via</para></remarks>
    /// <seealso href="http://purl.org/cld/terms/isAccessedVia">http://purl.org/cld/terms/isAccessedVia</seealso>
    let isAccessedVia = Prefixed_Name(cld, "isAccessedVia") |> PrefixedName
    /// <summary>
    ///   <para>cld:itemType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The nature or genre of the content of one or more items within the collection.</para>
    /// labels<para>Item Type</para></remarks>
    /// <seealso href="http://purl.org/cld/terms/itemType">http://purl.org/cld/terms/itemType</seealso>
    let itemType = Prefixed_Name(cld, "itemType") |> PrefixedName

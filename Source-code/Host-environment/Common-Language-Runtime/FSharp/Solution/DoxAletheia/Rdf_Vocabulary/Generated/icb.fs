namespace https.w3id.org.isCharacterisedBy.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module icb =
    let _namespace_iri = Namespace_Iri icb |> NamespaceIRI
    /// <summary>
    ///   <para>icb:Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Property is a qualifiable or quantifiable attribute, or characteristic of something. or somebody</para>
    /// labels<para>Property</para></remarks>
    /// <seealso href="https://w3id.org/isCharacterisedBy#Property">https://w3id.org/isCharacterisedBy#Property</seealso>
    let Property = Prefixed_Name(icb, "Property") |> PrefixedName
    /// <summary>
    ///   <para>icb:belongsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a member and the group it belongs to.</para>
    /// labels<para>belongsTo</para></remarks>
    /// <seealso href="https://w3id.org/isCharacterisedBy#belongsTo">https://w3id.org/isCharacterisedBy#belongsTo</seealso>
    let belongsTo = Prefixed_Name(icb, "belongsTo") |> PrefixedName
    /// <summary>
    ///   <para>icb:isCharacterisedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a SubjectOfInterest and the Property that characterises it.</para>
    /// labels<para>isCharacterisedBy</para></remarks>
    /// <seealso href="https://w3id.org/isCharacterisedBy#isCharacterisedBy">https://w3id.org/isCharacterisedBy#isCharacterisedBy</seealso>
    let isCharacterisedBy = Prefixed_Name(icb, "isCharacterisedBy") |> PrefixedName
    /// <summary>
    ///   <para>icb:Unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A reference to the unit of measure of a quantifiable aspect (attribute or characteristic).</para>
    /// labels<para>Unit</para></remarks>
    /// <seealso href="https://w3id.org/isCharacterisedBy#Unit">https://w3id.org/isCharacterisedBy#Unit</seealso>
    let Unit = Prefixed_Name(icb, "Unit") |> PrefixedName
    /// <summary>
    ///   <para>icb:characterises</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a Property and the SubjectOfInterest it characterises.</para>
    /// labels<para>characterises</para></remarks>
    /// <seealso href="https://w3id.org/isCharacterisedBy#characterises">https://w3id.org/isCharacterisedBy#characterises</seealso>
    let characterises = Prefixed_Name(icb, "characterises") |> PrefixedName
    /// <summary>
    ///   <para>icb:hasUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a quantifiable property and a unit of measurement</para>
    /// labels<para>hasUnit</para></remarks>
    /// <seealso href="https://w3id.org/isCharacterisedBy#hasUnit">https://w3id.org/isCharacterisedBy#hasUnit</seealso>
    let hasUnit = Prefixed_Name(icb, "hasUnit") |> PrefixedName
    /// <summary>
    ///   <para>icb:minValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Minimun permissible value.</para>
    /// labels<para>minValue</para></remarks>
    /// <seealso href="https://w3id.org/isCharacterisedBy#minValue">https://w3id.org/isCharacterisedBy#minValue</seealso>
    let minValue = Prefixed_Name(icb, "minValue") |> PrefixedName
    /// <summary>
    ///   <para>icb:maxValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Maximum permissible value.</para>
    /// labels<para>maxValue</para></remarks>
    /// <seealso href="https://w3id.org/isCharacterisedBy#maxValue">https://w3id.org/isCharacterisedBy#maxValue</seealso>
    let maxValue = Prefixed_Name(icb, "maxValue") |> PrefixedName
    /// <summary>
    ///   <para>icb:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specific value.</para>
    /// labels<para>value</para></remarks>
    /// <seealso href="https://w3id.org/isCharacterisedBy#value">https://w3id.org/isCharacterisedBy#value</seealso>
    let value = Prefixed_Name(icb, "value") |> PrefixedName
    /// <summary>
    ///   <para>icb:isGroupingOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a group and the members of such group. All the members of a group have the same charabterists or attributes.</para>
    /// labels<para>isGroupingOf</para></remarks>
    /// <seealso href="https://w3id.org/isCharacterisedBy#isGroupingOf">https://w3id.org/isCharacterisedBy#isGroupingOf</seealso>
    let isGroupingOf = Prefixed_Name(icb, "isGroupingOf") |> PrefixedName
    /// <summary>
    ///   <para>icb:isUnitFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between an unit and the property of which it is a unit of measurement.</para>
    /// labels<para>isUnitFor</para></remarks>
    /// <seealso href="https://w3id.org/isCharacterisedBy#isUnitFor">https://w3id.org/isCharacterisedBy#isUnitFor</seealso>
    let isUnitFor = Prefixed_Name(icb, "isUnitFor") |> PrefixedName
    /// <summary>
    ///   <para>icb:SubjectOfInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A subject of interest is an abstraction of a real world phenomena (thing, person, event, etc).</para>
    /// labels<para>SubjectOfInterest</para></remarks>
    /// <seealso href="https://w3id.org/isCharacterisedBy#SubjectOfInterest">https://w3id.org/isCharacterisedBy#SubjectOfInterest</seealso>
    let SubjectOfInterest = Prefixed_Name(icb, "SubjectOfInterest") |> PrefixedName

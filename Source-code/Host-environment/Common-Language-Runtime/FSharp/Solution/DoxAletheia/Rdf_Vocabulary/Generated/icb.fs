namespace https.w3id.org.isCharacterisedBy.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module icb =
    let _namespace_iri = Namespace_Iri icb |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:isCharacterisedBy#Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Property is a qualifiable or quantifiable attribute, or characteristic of something. or somebody"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isCharacterisedBy#Property">https://w3id.org/isCharacterisedBy#Property</seealso>
    let Property = Prefixed_Name(icb, "Property") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isCharacterisedBy#SubjectOfInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A subject of interest is an abstraction of a real world phenomena (thing, person, event, etc)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SubjectOfInterest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isCharacterisedBy#SubjectOfInterest">https://w3id.org/isCharacterisedBy#SubjectOfInterest</seealso>
    let SubjectOfInterest = Prefixed_Name(icb, "SubjectOfInterest") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isCharacterisedBy#Unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A reference to the unit of measure of a quantifiable aspect (attribute or characteristic)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isCharacterisedBy#Unit">https://w3id.org/isCharacterisedBy#Unit</seealso>
    let Unit = Prefixed_Name(icb, "Unit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isCharacterisedBy#belongsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between a member and the group it belongs to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"belongsTo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isCharacterisedBy#belongsTo">https://w3id.org/isCharacterisedBy#belongsTo</seealso>
    let belongsTo = Prefixed_Name(icb, "belongsTo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isCharacterisedBy#characterises</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between a Property and the SubjectOfInterest it characterises."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"characterises"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isCharacterisedBy#characterises">https://w3id.org/isCharacterisedBy#characterises</seealso>
    let characterises = Prefixed_Name(icb, "characterises") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isCharacterisedBy#hasUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between a quantifiable property and a unit of measurement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasUnit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isCharacterisedBy#hasUnit">https://w3id.org/isCharacterisedBy#hasUnit</seealso>
    let hasUnit = Prefixed_Name(icb, "hasUnit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isCharacterisedBy#isCharacterisedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between a SubjectOfInterest and the Property that characterises it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isCharacterisedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isCharacterisedBy#isCharacterisedBy">https://w3id.org/isCharacterisedBy#isCharacterisedBy</seealso>
    let isCharacterisedBy = Prefixed_Name(icb, "isCharacterisedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isCharacterisedBy#isGroupingOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between a group and the members of such group. All the members of a group have the same charabterists or attributes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isGroupingOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isCharacterisedBy#isGroupingOf">https://w3id.org/isCharacterisedBy#isGroupingOf</seealso>
    let isGroupingOf = Prefixed_Name(icb, "isGroupingOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isCharacterisedBy#isUnitFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between an unit and the property of which it is a unit of measurement."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isUnitFor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isCharacterisedBy#isUnitFor">https://w3id.org/isCharacterisedBy#isUnitFor</seealso>
    let isUnitFor = Prefixed_Name(icb, "isUnitFor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isCharacterisedBy#maxValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Maximum permissible value."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"maxValue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isCharacterisedBy#maxValue">https://w3id.org/isCharacterisedBy#maxValue</seealso>
    let maxValue = Prefixed_Name(icb, "maxValue") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isCharacterisedBy#minValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Minimun permissible value."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"minValue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isCharacterisedBy#minValue">https://w3id.org/isCharacterisedBy#minValue</seealso>
    let minValue = Prefixed_Name(icb, "minValue") |> PrefixedName
    /// <summary>
    ///   <para>w3id:isCharacterisedBy#value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specific value."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/isCharacterisedBy#value">https://w3id.org/isCharacterisedBy#value</seealso>
    let value = Prefixed_Name(icb, "value") |> PrefixedName

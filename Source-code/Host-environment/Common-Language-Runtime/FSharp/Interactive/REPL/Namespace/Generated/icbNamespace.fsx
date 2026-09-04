#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module icb =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://w3id.org/isCharacterisedBy#" "icb"

    /// <summary>
    ///   <para>rdfs:label : Property^^xsd:string</para>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:comment : Property is a qualifiable or quantifiable attribute, or characteristic of something. or somebody^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/isCharacterisedBy^^xsd:string</para>
    ///   <a href="https://w3id.org/isCharacterisedBy#Property">icb:Property</a>
    /// </summary>
    let Property = _prefixId.prefix "Property"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : SubjectOfInterest^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/isCharacterisedBy^^xsd:string</para>
    ///   <para>rdfs:comment : A subject of interest is an abstraction of a real world phenomena (thing, person, event, etc).^^xsd:string</para>
    ///   <a href="https://w3id.org/isCharacterisedBy#SubjectOfInterest">icb:SubjectOfInterest</a>
    /// </summary>
    let SubjectOfInterest = _prefixId.prefix "SubjectOfInterest"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Unit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/isCharacterisedBy^^xsd:string</para>
    ///   <para>rdfs:comment : A reference to the unit of measure of a quantifiable aspect (attribute or characteristic).^^xsd:string</para>
    ///   <a href="https://w3id.org/isCharacterisedBy#Unit">icb:Unit</a>
    /// </summary>
    let Unit = _prefixId.prefix "Unit"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : belongsTo^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/isCharacterisedBy^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between a member and the group it belongs to.^^xsd:string</para>
    ///   <a href="https://w3id.org/isCharacterisedBy#belongsTo">icb:belongsTo</a>
    /// </summary>
    let belongsTo = _prefixId.prefix "belongsTo"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : characterises^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/isCharacterisedBy^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between a Property and the SubjectOfInterest it characterises.^^xsd:string</para>
    ///   <a href="https://w3id.org/isCharacterisedBy#characterises">icb:characterises</a>
    /// </summary>
    let characterises = _prefixId.prefix "characterises"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : hasUnit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/isCharacterisedBy^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between a quantifiable property and a unit of measurement^^xsd:string</para>
    ///   <a href="https://w3id.org/isCharacterisedBy#hasUnit">icb:hasUnit</a>
    /// </summary>
    let hasUnit = _prefixId.prefix "hasUnit"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : isCharacterisedBy^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/isCharacterisedBy^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between a SubjectOfInterest and the Property that characterises it.^^xsd:string</para>
    ///   <a href="https://w3id.org/isCharacterisedBy#isCharacterisedBy">icb:isCharacterisedBy</a>
    /// </summary>
    let isCharacterisedBy = _prefixId.prefix "isCharacterisedBy"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : isGroupingOf^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/isCharacterisedBy^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between a group and the members of such group. All the members of a group have the same charabterists or attributes.^^xsd:string</para>
    ///   <a href="https://w3id.org/isCharacterisedBy#isGroupingOf">icb:isGroupingOf</a>
    /// </summary>
    let isGroupingOf = _prefixId.prefix "isGroupingOf"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : isUnitFor^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/isCharacterisedBy^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between an unit and the property of which it is a unit of measurement.^^xsd:string</para>
    ///   <a href="https://w3id.org/isCharacterisedBy#isUnitFor">icb:isUnitFor</a>
    /// </summary>
    let isUnitFor = _prefixId.prefix "isUnitFor"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : maxValue^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/isCharacterisedBy^^xsd:string</para>
    ///   <para>rdfs:comment : Maximum permissible value.^^xsd:string</para>
    ///   <a href="https://w3id.org/isCharacterisedBy#maxValue">icb:maxValue</a>
    /// </summary>
    let maxValue = _prefixId.prefix "maxValue"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : minValue^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/isCharacterisedBy^^xsd:string</para>
    ///   <para>rdfs:comment : Minimun permissible value.^^xsd:string</para>
    ///   <a href="https://w3id.org/isCharacterisedBy#minValue">icb:minValue</a>
    /// </summary>
    let minValue = _prefixId.prefix "minValue"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : value^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/isCharacterisedBy^^xsd:string</para>
    ///   <para>rdfs:comment : Specific value.^^xsd:string</para>
    ///   <a href="https://w3id.org/isCharacterisedBy#value">icb:value</a>
    /// </summary>
    let value = _prefixId.prefix "value"

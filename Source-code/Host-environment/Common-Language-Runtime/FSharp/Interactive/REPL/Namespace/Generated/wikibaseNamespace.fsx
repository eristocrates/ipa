#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module wikibase =
    let _prefixId = PrefixId.fromNamespaceLabel "http://wikiba.se/ontology#" "wikibase"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : BestRank^^xsd:string</para>
    ///   <para>rdfs:comment : This class marks statement that has the best rank for its property.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#BestRank">wikibase:BestRank</a>
    /// </summary>
    let BestRank = _prefixId.prefix "BestRank"
    let CommonsMedia = _prefixId.prefix "CommonsMedia"
    let DeprecatedRank = _prefixId.prefix "DeprecatedRank"
    /// <summary>
    ///   <para>rdfs:label : Dump^^xsd:string</para>
    ///   <para>rdfs:comment : A dump of wikidata content.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#Dump">wikibase:Dump</a>
    /// </summary>
    let Dump = _prefixId.prefix "Dump"
    /// <summary>
    ///   <para>rdfs:label : Entity^^xsd:string</para>
    ///   <para>rdfs:comment : Wikibase entity.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#Entity">wikibase:Entity</a>
    /// </summary>
    let Entity = _prefixId.prefix "Entity"
    let ExternalId = _prefixId.prefix "ExternalId"
    /// <summary>
    ///   <para>rdfs:label : Form^^xsd:string</para>
    ///   <para>rdfs:comment : Wikibase Form.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#Form">wikibase:Form</a>
    /// </summary>
    let Form = _prefixId.prefix "Form"
    /// <summary>
    ///   <para>rdfs:label : GeoAutoPrecision^^xsd:string</para>
    ///   <para>rdfs:comment : This coordinate value uses automatic precision since the user did not specify one.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#GeoAutoPrecision">wikibase:GeoAutoPrecision</a>
    /// </summary>
    let GeoAutoPrecision = _prefixId.prefix "GeoAutoPrecision"
    let GeoShape = _prefixId.prefix "GeoShape"
    let Globecoordinate = _prefixId.prefix "Globecoordinate"
    /// <summary>
    ///   <para>rdfs:label : GlobecoordinateValue^^xsd:string</para>
    ///   <para>rdfs:comment : Wikibase extended value representing geographic coordinate.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#GlobecoordinateValue">wikibase:GlobecoordinateValue</a>
    /// </summary>
    let GlobecoordinateValue = _prefixId.prefix "GlobecoordinateValue"
    /// <summary>
    ///   <para>rdfs:label : Item^^xsd:string</para>
    ///   <para>rdfs:comment : Wikibase item.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#Item">wikibase:Item</a>
    /// </summary>
    let Item = _prefixId.prefix "Item"
    /// <summary>
    ///   <para>rdfs:label : Lexeme^^xsd:string</para>
    ///   <para>rdfs:comment : Wikibase Lexeme.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#Lexeme">wikibase:Lexeme</a>
    /// </summary>
    let Lexeme = _prefixId.prefix "Lexeme"
    let Math = _prefixId.prefix "Math"
    let Monolingualtext = _prefixId.prefix "Monolingualtext"
    let NormalRank = _prefixId.prefix "NormalRank"
    let PreferredRank = _prefixId.prefix "PreferredRank"
    /// <summary>
    ///   <para>rdfs:label : Property^^xsd:string</para>
    ///   <para>rdfs:comment : Wikibase property.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#Property">wikibase:Property</a>
    /// </summary>
    let Property = _prefixId.prefix "Property"
    /// <summary>
    ///   <para>rdfs:label : PropertyType^^xsd:string</para>
    ///   <para>rdfs:comment : Type of a wikibase property.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#PropertyType">wikibase:PropertyType</a>
    /// </summary>
    let PropertyType = _prefixId.prefix "PropertyType"
    let Quantity = _prefixId.prefix "Quantity"
    /// <summary>
    ///   <para>rdfs:label : QuantityValue^^xsd:string</para>
    ///   <para>rdfs:comment : Wikibase extended value representing quantity.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#QuantityValue">wikibase:QuantityValue</a>
    /// </summary>
    let QuantityValue = _prefixId.prefix "QuantityValue"
    /// <summary>
    ///   <para>rdfs:label : Rank^^xsd:string</para>
    ///   <para>rdfs:comment : Wikibase statement rank.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#Rank">wikibase:Rank</a>
    /// </summary>
    let Rank = _prefixId.prefix "Rank"
    /// <summary>
    ///   <para>rdfs:label : Reference^^xsd:string</para>
    ///   <para>rdfs:comment : A reference to sources supporting the claim.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#Reference">wikibase:Reference</a>
    /// </summary>
    let Reference = _prefixId.prefix "Reference"
    /// <summary>
    ///   <para>rdfs:label : Statement^^xsd:string</para>
    ///   <para>rdfs:comment : A reified statement.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#Statement">wikibase:Statement</a>
    /// </summary>
    let Statement = _prefixId.prefix "Statement"
    let String = _prefixId.prefix "String"
    let TabularData = _prefixId.prefix "TabularData"
    let Time = _prefixId.prefix "Time"
    /// <summary>
    ///   <para>rdfs:label : TimeValue^^xsd:string</para>
    ///   <para>rdfs:comment : Wikibase extended value representing time.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#TimeValue">wikibase:TimeValue</a>
    /// </summary>
    let TimeValue = _prefixId.prefix "TimeValue"
    let Url = _prefixId.prefix "Url"
    /// <summary>
    ///   <para>rdfs:label : Value^^xsd:string</para>
    ///   <para>rdfs:comment : Wikibase extended value.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#Value">wikibase:Value</a>
    /// </summary>
    let Value = _prefixId.prefix "Value"
    let WikibaseItem = _prefixId.prefix "WikibaseItem"
    let WikibaseProperty = _prefixId.prefix "WikibaseProperty"
    /// <summary>
    ///   <para>rdfs:label : badge^^xsd:string</para>
    ///   <para>rdfs:comment : Badge on the Wiki page.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#badge">wikibase:badge</a>
    /// </summary>
    let badge = _prefixId.prefix "badge"
    /// <summary>
    ///   <para>rdfs:label : claim^^xsd:string</para>
    ///   <para>rdfs:comment : Link between Wikibase Property and claim predicate.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#claim">wikibase:claim</a>
    /// </summary>
    let claim = _prefixId.prefix "claim"
    /// <summary>
    ///   <para>rdfs:label : directClaim^^xsd:string</para>
    ///   <para>rdfs:comment : Link between Wikibase Property and direct claim predicate.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#directClaim">wikibase:directClaim</a>
    /// </summary>
    let directClaim = _prefixId.prefix "directClaim"
    /// <summary>
    ///   <para>rdfs:label : geoGlobe^^xsd:string</para>
    ///   <para>rdfs:comment : Globe reference URL.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#geoGlobe">wikibase:geoGlobe</a>
    /// </summary>
    let geoGlobe = _prefixId.prefix "geoGlobe"
    /// <summary>
    ///   <para>rdfs:label : geoLatitude^^xsd:string</para>
    ///   <para>rdfs:comment : Coordinate latitude.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#geoLatitude">wikibase:geoLatitude</a>
    /// </summary>
    let geoLatitude = _prefixId.prefix "geoLatitude"
    /// <summary>
    ///   <para>rdfs:label : geoLongitude^^xsd:string</para>
    ///   <para>rdfs:comment : Coordinate longitude.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#geoLongitude">wikibase:geoLongitude</a>
    /// </summary>
    let geoLongitude = _prefixId.prefix "geoLongitude"
    /// <summary>
    ///   <para>rdfs:label : geoPrecision^^xsd:string</para>
    ///   <para>rdfs:comment : Coordinate precision.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#geoPrecision">wikibase:geoPrecision</a>
    /// </summary>
    let geoPrecision = _prefixId.prefix "geoPrecision"
    /// <summary>
    ///   <para>rdfs:label : grammaticalFeature^^xsd:string</para>
    ///   <para>rdfs:comment : Form grammatical feature.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#grammaticalFeature">wikibase:grammaticalFeature</a>
    /// </summary>
    let grammaticalFeature = _prefixId.prefix "grammaticalFeature"
    /// <summary>
    ///   <para>rdfs:label : hasViolationForConstraint^^xsd:string</para>
    ///   <para>rdfs:comment : Link between statement violating constraint and the constraint.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#hasViolationForConstraint">wikibase:hasViolationForConstraint</a>
    /// </summary>
    let hasViolationForConstraint = _prefixId.prefix "hasViolationForConstraint"
    /// <summary>
    ///   <para>rdfs:label : lemma^^xsd:string</para>
    ///   <para>rdfs:comment : Lexeme lemma.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#lemma">wikibase:lemma</a>
    /// </summary>
    let lemma = _prefixId.prefix "lemma"
    /// <summary>
    ///   <para>rdfs:label : lexicalCategory^^xsd:string</para>
    ///   <para>rdfs:comment : Lexeme lexical category.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#lexicalCategory">wikibase:lexicalCategory</a>
    /// </summary>
    let lexicalCategory = _prefixId.prefix "lexicalCategory"
    /// <summary>
    ///   <para>rdfs:label : novalue^^xsd:string</para>
    ///   <para>rdfs:comment : Link between Wikibase Property and no value class.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#novalue">wikibase:novalue</a>
    /// </summary>
    let novalue = _prefixId.prefix "novalue"
    /// <summary>
    ///   <para>rdfs:label : qualifier^^xsd:string</para>
    ///   <para>rdfs:comment : Link between Wikibase Property and qualifier predicate.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#qualifier">wikibase:qualifier</a>
    /// </summary>
    let qualifier = _prefixId.prefix "qualifier"
    /// <summary>
    ///   <para>rdfs:label : qualifierValue^^xsd:string</para>
    ///   <para>rdfs:comment : Link between Wikibase Property and qualifier value predicate.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#qualifierValue">wikibase:qualifierValue</a>
    /// </summary>
    let qualifierValue = _prefixId.prefix "qualifierValue"
    /// <summary>
    ///   <para>rdfs:label : qualifierValueNormalized^^xsd:string</para>
    ///   <para>rdfs:comment : Link between Wikibase Property and qualifier normalized value predicate.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#qualifierValueNormalized">wikibase:qualifierValueNormalized</a>
    /// </summary>
    let qualifierValueNormalized = _prefixId.prefix "qualifierValueNormalized"
    /// <summary>
    ///   <para>rdfs:label : quantityAmount^^xsd:string</para>
    ///   <para>rdfs:comment : Amount of quantity.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#quantityAmount">wikibase:quantityAmount</a>
    /// </summary>
    let quantityAmount = _prefixId.prefix "quantityAmount"
    /// <summary>
    ///   <para>rdfs:label : quantityLowerBound^^xsd:string</para>
    ///   <para>rdfs:comment : Lower bound of the value.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#quantityLowerBound">wikibase:quantityLowerBound</a>
    /// </summary>
    let quantityLowerBound = _prefixId.prefix "quantityLowerBound"
    /// <summary>
    ///   <para>rdfs:label : quantityNormalized^^xsd:string</para>
    ///   <para>rdfs:comment : Representation of this quantity in standard units.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#quantityNormalized">wikibase:quantityNormalized</a>
    /// </summary>
    let quantityNormalized = _prefixId.prefix "quantityNormalized"
    /// <summary>
    ///   <para>rdfs:label : quantityUnit^^xsd:string</para>
    ///   <para>rdfs:comment : Unit of measurement.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#quantityUnit">wikibase:quantityUnit</a>
    /// </summary>
    let quantityUnit = _prefixId.prefix "quantityUnit"
    /// <summary>
    ///   <para>rdfs:label : quantityUpperBound^^xsd:string</para>
    ///   <para>rdfs:comment : Upper bound of the value.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#quantityUpperBound">wikibase:quantityUpperBound</a>
    /// </summary>
    let quantityUpperBound = _prefixId.prefix "quantityUpperBound"
    /// <summary>
    ///   <para>rdfs:label : rank^^xsd:string</para>
    ///   <para>rdfs:comment : Statement rank.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#rank">wikibase:rank</a>
    /// </summary>
    let rank = _prefixId.prefix "rank"
    /// <summary>
    ///   <para>rdfs:label : reference^^xsd:string</para>
    ///   <para>rdfs:comment : Link between Wikibase Property and reference predicate.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#reference">wikibase:reference</a>
    /// </summary>
    let reference = _prefixId.prefix "reference"
    /// <summary>
    ///   <para>rdfs:label : referenceValue^^xsd:string</para>
    ///   <para>rdfs:comment : Link between Wikibase Property and reference value predicate.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#referenceValue">wikibase:referenceValue</a>
    /// </summary>
    let referenceValue = _prefixId.prefix "referenceValue"
    /// <summary>
    ///   <para>rdfs:label : referenceValueNormalized^^xsd:string</para>
    ///   <para>rdfs:comment : Link between Wikibase Property and reference normalized value predicate.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#referenceValueNormalized">wikibase:referenceValueNormalized</a>
    /// </summary>
    let referenceValueNormalized = _prefixId.prefix "referenceValueNormalized"
    /// <summary>
    ///   <para>rdfs:label : statementProperty^^xsd:string</para>
    ///   <para>rdfs:comment : Link between Wikibase Property and statement property predicate.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#statementProperty">wikibase:statementProperty</a>
    /// </summary>
    let statementProperty = _prefixId.prefix "statementProperty"
    /// <summary>
    ///   <para>rdfs:label : statementValue^^xsd:string</para>
    ///   <para>rdfs:comment : Link between Wikibase Property and statement value predicate.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#statementValue">wikibase:statementValue</a>
    /// </summary>
    let statementValue = _prefixId.prefix "statementValue"
    /// <summary>
    ///   <para>rdfs:label : statementValueNormalized^^xsd:string</para>
    ///   <para>rdfs:comment : Link between Wikibase Property and statement normalized value predicate.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#statementValueNormalized">wikibase:statementValueNormalized</a>
    /// </summary>
    let statementValueNormalized = _prefixId.prefix "statementValueNormalized"
    /// <summary>
    ///   <para>rdfs:label : timeCalendarModel^^xsd:string</para>
    ///   <para>rdfs:comment : Preferred calendar used to display this date to the user.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#timeCalendarModel">wikibase:timeCalendarModel</a>
    /// </summary>
    let timeCalendarModel = _prefixId.prefix "timeCalendarModel"
    /// <summary>
    ///   <para>rdfs:label : timePrecision^^xsd:string</para>
    ///   <para>rdfs:comment : Datetime precision.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#timePrecision">wikibase:timePrecision</a>
    /// </summary>
    let timePrecision = _prefixId.prefix "timePrecision"
    /// <summary>
    ///   <para>rdfs:label : timeTimezone^^xsd:string</para>
    ///   <para>rdfs:comment : Timezone offset from UTC in minutes.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#timeTimezone">wikibase:timeTimezone</a>
    /// </summary>
    let timeTimezone = _prefixId.prefix "timeTimezone"
    /// <summary>
    ///   <para>rdfs:label : timeValue^^xsd:string</para>
    ///   <para>rdfs:comment : Time value as datetime literal.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#timeValue">wikibase:timeValue</a>
    /// </summary>
    let timeValue = _prefixId.prefix "timeValue"
    /// <summary>
    ///   <para>rdfs:label : wikiGroup^^xsd:string</para>
    ///   <para>rdfs:comment : Wiki group that the site belongs to.^^xsd:string</para>
    ///   <a href="http://wikiba.se/ontology#wikiGroup">wikibase:wikiGroup</a>
    /// </summary>
    let wikiGroup = _prefixId.prefix "wikiGroup"

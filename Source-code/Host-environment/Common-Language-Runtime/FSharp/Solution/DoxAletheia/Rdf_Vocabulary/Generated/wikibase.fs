namespace http.wikiba.se.ontology.hash

open DoxAletheia

module wikibase =
    let _namespace_name = "http://wikiba.se/ontology#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Wikibase Form.
    /// <see href="http://wikiba.se/ontology#Form"></see></summary>
    let Form = _prefix "Form"
    /// <summary>
    /// Wikibase item.
    /// <see href="http://wikiba.se/ontology#Item"></see></summary>
    let Item = _prefix "Item"
    /// <summary>
    /// Wikibase Lexeme.
    /// <see href="http://wikiba.se/ontology#Lexeme"></see></summary>
    let Lexeme = _prefix "Lexeme"
    /// <summary>
    /// Wikibase property.
    /// <see href="http://wikiba.se/ontology#Property"></see></summary>
    let Property = _prefix "Property"
    /// <summary>
    /// This class marks statement that has the best rank for its property.
    /// <see href="http://wikiba.se/ontology#BestRank"></see></summary>
    let BestRank = _prefix "BestRank"
    /// <summary>
    /// Wikimedia Commons reference type.
    /// <see href="http://wikiba.se/ontology#CommonsMedia"></see></summary>
    let CommonsMedia = _prefix "CommonsMedia"
    /// <summary>
    /// Type of a wikibase property.
    /// <see href="http://wikiba.se/ontology#PropertyType"></see></summary>
    let PropertyType = _prefix "PropertyType"
    /// <summary>
    /// Deprecated statement rank.
    /// <see href="http://wikiba.se/ontology#DeprecatedRank"></see></summary>
    let DeprecatedRank = _prefix "DeprecatedRank"
    /// <summary>
    /// Wikibase statement rank.
    /// <see href="http://wikiba.se/ontology#Rank"></see></summary>
    let Rank = _prefix "Rank"
    /// <summary>
    /// A dump of wikidata content.
    /// <see href="http://wikiba.se/ontology#Dump"></see></summary>
    let Dump = _prefix "Dump"
    /// <summary>
    /// Wikibase entity.
    /// <see href="http://wikiba.se/ontology#Entity"></see></summary>
    let Entity = _prefix "Entity"
    /// <summary>
    /// Type for referring to ID defined by external authority.
    /// <see href="http://wikiba.se/ontology#ExternalId"></see></summary>
    let ExternalId = _prefix "ExternalId"
    /// <summary>
    /// This coordinate value uses automatic precision since the user did not specify one.
    /// <see href="http://wikiba.se/ontology#GeoAutoPrecision"></see></summary>
    let GeoAutoPrecision = _prefix "GeoAutoPrecision"
    /// <summary>
    /// Type for storing links to geoshape data.
    /// <see href="http://wikiba.se/ontology#GeoShape"></see></summary>
    let GeoShape = _prefix "GeoShape"
    /// <summary>
    /// Coordinate type.
    /// <see href="http://wikiba.se/ontology#Globecoordinate"></see></summary>
    let Globecoordinate = _prefix "Globecoordinate"
    /// <summary>
    /// Wikibase extended value representing geographic coordinate.
    /// <see href="http://wikiba.se/ontology#GlobecoordinateValue"></see></summary>
    let GlobecoordinateValue = _prefix "GlobecoordinateValue"
    /// <summary>
    /// Wikibase extended value.
    /// <see href="http://wikiba.se/ontology#Value"></see></summary>
    let Value = _prefix "Value"
    /// <summary>
    /// Type for mathematical expressions as supported by the Math extension.
    /// <see href="http://wikiba.se/ontology#Math"></see></summary>
    let Math = _prefix "Math"
    /// <summary>
    /// Type for text in single language.
    /// <see href="http://wikiba.se/ontology#Monolingualtext"></see></summary>
    let Monolingualtext = _prefix "Monolingualtext"
    /// <summary>
    /// Normal statement rank.
    /// <see href="http://wikiba.se/ontology#NormalRank"></see></summary>
    let NormalRank = _prefix "NormalRank"
    /// <summary>
    /// Preferred statement rank.
    /// <see href="http://wikiba.se/ontology#PreferredRank"></see></summary>
    let PreferredRank = _prefix "PreferredRank"
    /// <summary>
    /// Type for numerical quantity.
    /// <see href="http://wikiba.se/ontology#Quantity"></see></summary>
    let Quantity = _prefix "Quantity"
    /// <summary>
    /// Wikibase extended value representing quantity.
    /// <see href="http://wikiba.se/ontology#QuantityValue"></see></summary>
    let QuantityValue = _prefix "QuantityValue"
    /// <summary>
    /// A reference to sources supporting the claim.
    /// <see href="http://wikiba.se/ontology#Reference"></see></summary>
    let Reference = _prefix "Reference"
    /// <summary>
    /// A reified statement.
    /// <see href="http://wikiba.se/ontology#Statement"></see></summary>
    let Statement = _prefix "Statement"
    /// <summary>
    /// Basic string type.
    /// <see href="http://wikiba.se/ontology#String"></see></summary>
    let String = _prefix "String"
    /// <summary>
    /// Type for storing links to tabular data.
    /// <see href="http://wikiba.se/ontology#TabularData"></see></summary>
    let TabularData = _prefix "TabularData"
    /// <summary>
    /// Date and time value type.
    /// <see href="http://wikiba.se/ontology#Time"></see></summary>
    let Time = _prefix "Time"
    /// <summary>
    /// Wikibase extended value representing time.
    /// <see href="http://wikiba.se/ontology#TimeValue"></see></summary>
    let TimeValue = _prefix "TimeValue"
    /// <summary>
    /// URL link type.
    /// <see href="http://wikiba.se/ontology#Url"></see></summary>
    let Url = _prefix "Url"
    /// <summary>
    /// Type for referring to another Wikibase item.
    /// <see href="http://wikiba.se/ontology#WikibaseItem"></see></summary>
    let WikibaseItem = _prefix "WikibaseItem"
    /// <summary>
    /// Type for referring to a Wikibase property.
    /// <see href="http://wikiba.se/ontology#WikibaseProperty"></see></summary>
    let WikibaseProperty = _prefix "WikibaseProperty"
    /// <summary>
    /// Badge on the Wiki page.
    /// <see href="http://wikiba.se/ontology#badge"></see></summary>
    let badge = _prefix "badge"
    /// <summary>
    /// Link between Wikibase Property and claim predicate.
    /// <see href="http://wikiba.se/ontology#claim"></see></summary>
    let claim = _prefix "claim"
    /// <summary>
    /// Link between Wikibase Property and direct claim predicate.
    /// <see href="http://wikiba.se/ontology#directClaim"></see></summary>
    let directClaim = _prefix "directClaim"
    /// <summary>
    /// Globe reference URL.
    /// <see href="http://wikiba.se/ontology#geoGlobe"></see></summary>
    let geoGlobe = _prefix "geoGlobe"
    /// <summary>
    /// Coordinate latitude.
    /// <see href="http://wikiba.se/ontology#geoLatitude"></see></summary>
    let geoLatitude = _prefix "geoLatitude"
    /// <summary>
    /// Coordinate longitude.
    /// <see href="http://wikiba.se/ontology#geoLongitude"></see></summary>
    let geoLongitude = _prefix "geoLongitude"
    /// <summary>
    /// Coordinate precision.
    /// <see href="http://wikiba.se/ontology#geoPrecision"></see></summary>
    let geoPrecision = _prefix "geoPrecision"
    /// <summary>
    /// Form grammatical feature.
    /// <see href="http://wikiba.se/ontology#grammaticalFeature"></see></summary>
    let grammaticalFeature = _prefix "grammaticalFeature"
    /// <summary>
    /// Link between statement violating constraint and the constraint.
    /// <see href="http://wikiba.se/ontology#hasViolationForConstraint"></see></summary>
    let hasViolationForConstraint = _prefix "hasViolationForConstraint"
    /// <summary>
    /// Lexeme lemma.
    /// <see href="http://wikiba.se/ontology#lemma"></see></summary>
    let lemma = _prefix "lemma"
    /// <summary>
    /// Lexeme lexical category.
    /// <see href="http://wikiba.se/ontology#lexicalCategory"></see></summary>
    let lexicalCategory = _prefix "lexicalCategory"
    /// <summary>
    /// Link between Wikibase Property and no value class.
    /// <see href="http://wikiba.se/ontology#novalue"></see></summary>
    let novalue = _prefix "novalue"
    /// <summary>
    /// Link between Wikibase Property and qualifier predicate.
    /// <see href="http://wikiba.se/ontology#qualifier"></see></summary>
    let qualifier = _prefix "qualifier"
    /// <summary>
    /// Link between Wikibase Property and qualifier value predicate.
    /// <see href="http://wikiba.se/ontology#qualifierValue"></see></summary>
    let qualifierValue = _prefix "qualifierValue"
    /// <summary>
    /// Link between Wikibase Property and qualifier normalized value predicate.
    /// <see href="http://wikiba.se/ontology#qualifierValueNormalized"></see></summary>
    let qualifierValueNormalized = _prefix "qualifierValueNormalized"
    /// <summary>
    /// Amount of quantity.
    /// <see href="http://wikiba.se/ontology#quantityAmount"></see></summary>
    let quantityAmount = _prefix "quantityAmount"
    /// <summary>
    /// Lower bound of the value.
    /// <see href="http://wikiba.se/ontology#quantityLowerBound"></see></summary>
    let quantityLowerBound = _prefix "quantityLowerBound"
    /// <summary>
    /// Representation of this quantity in standard units.
    /// <see href="http://wikiba.se/ontology#quantityNormalized"></see></summary>
    let quantityNormalized = _prefix "quantityNormalized"
    /// <summary>
    /// Unit of measurement.
    /// <see href="http://wikiba.se/ontology#quantityUnit"></see></summary>
    let quantityUnit = _prefix "quantityUnit"
    /// <summary>
    /// Upper bound of the value.
    /// <see href="http://wikiba.se/ontology#quantityUpperBound"></see></summary>
    let quantityUpperBound = _prefix "quantityUpperBound"
    /// <summary>
    /// Statement rank.
    /// <see href="http://wikiba.se/ontology#rank"></see></summary>
    let rank = _prefix "rank"
    /// <summary>
    /// Link between Wikibase Property and reference predicate.
    /// <see href="http://wikiba.se/ontology#reference"></see></summary>
    let reference = _prefix "reference"
    /// <summary>
    /// Link between Wikibase Property and reference value predicate.
    /// <see href="http://wikiba.se/ontology#referenceValue"></see></summary>
    let referenceValue = _prefix "referenceValue"
    /// <summary>
    /// Link between Wikibase Property and reference normalized value predicate.
    /// <see href="http://wikiba.se/ontology#referenceValueNormalized"></see></summary>
    let referenceValueNormalized = _prefix "referenceValueNormalized"
    /// <summary>
    /// Link between Wikibase Property and statement property predicate.
    /// <see href="http://wikiba.se/ontology#statementProperty"></see></summary>
    let statementProperty = _prefix "statementProperty"
    /// <summary>
    /// Link between Wikibase Property and statement value predicate.
    /// <see href="http://wikiba.se/ontology#statementValue"></see></summary>
    let statementValue = _prefix "statementValue"
    /// <summary>
    /// Link between Wikibase Property and statement normalized value predicate.
    /// <see href="http://wikiba.se/ontology#statementValueNormalized"></see></summary>
    let statementValueNormalized = _prefix "statementValueNormalized"
    /// <summary>
    /// Preferred calendar used to display this date to the user.
    /// <see href="http://wikiba.se/ontology#timeCalendarModel"></see></summary>
    let timeCalendarModel = _prefix "timeCalendarModel"
    /// <summary>
    /// Datetime precision.
    /// <see href="http://wikiba.se/ontology#timePrecision"></see></summary>
    let timePrecision = _prefix "timePrecision"
    /// <summary>
    /// Timezone offset from UTC in minutes.
    /// <see href="http://wikiba.se/ontology#timeTimezone"></see></summary>
    let timeTimezone = _prefix "timeTimezone"
    /// <summary>
    /// Time value as datetime literal.
    /// <see href="http://wikiba.se/ontology#timeValue"></see></summary>
    let timeValue = _prefix "timeValue"
    /// <summary>
    /// Wiki group that the site belongs to.
    /// <see href="http://wikiba.se/ontology#wikiGroup"></see></summary>
    let wikiGroup = _prefix "wikiGroup"

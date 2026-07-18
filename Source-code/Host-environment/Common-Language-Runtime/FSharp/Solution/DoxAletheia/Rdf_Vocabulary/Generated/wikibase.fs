namespace http.wikiba.se.ontology.hash

open DoxAletheia.Rdf_Vocabulary

module wikibase =
    let _namespace_name = "http://wikiba.se/ontology#"
    /// <summary>
    /// Wikibase Form.
    /// <see href="http://wikiba.se/ontology#Form"></see></summary>
    let Form = Namespaced_IRI.parse _namespace_name "Form" |> NamespacedName
    /// <summary>
    /// Wikibase item.
    /// <see href="http://wikiba.se/ontology#Item"></see></summary>
    let Item = Namespaced_IRI.parse _namespace_name "Item" |> NamespacedName
    /// <summary>
    /// Wikibase Lexeme.
    /// <see href="http://wikiba.se/ontology#Lexeme"></see></summary>
    let Lexeme = Namespaced_IRI.parse _namespace_name "Lexeme" |> NamespacedName
    /// <summary>
    /// Wikibase property.
    /// <see href="http://wikiba.se/ontology#Property"></see></summary>
    let Property = Namespaced_IRI.parse _namespace_name "Property" |> NamespacedName
    /// <summary>
    /// This class marks statement that has the best rank for its property.
    /// <see href="http://wikiba.se/ontology#BestRank"></see></summary>
    let BestRank = Namespaced_IRI.parse _namespace_name "BestRank" |> NamespacedName

    /// <summary>
    /// Wikimedia Commons reference type.
    /// <see href="http://wikiba.se/ontology#CommonsMedia"></see></summary>
    let CommonsMedia =
        Namespaced_IRI.parse _namespace_name "CommonsMedia" |> NamespacedName

    /// <summary>
    /// Type of a wikibase property.
    /// <see href="http://wikiba.se/ontology#PropertyType"></see></summary>
    let PropertyType =
        Namespaced_IRI.parse _namespace_name "PropertyType" |> NamespacedName

    /// <summary>
    /// Deprecated statement rank.
    /// <see href="http://wikiba.se/ontology#DeprecatedRank"></see></summary>
    let DeprecatedRank =
        Namespaced_IRI.parse _namespace_name "DeprecatedRank" |> NamespacedName

    /// <summary>
    /// Wikibase statement rank.
    /// <see href="http://wikiba.se/ontology#Rank"></see></summary>
    let Rank = Namespaced_IRI.parse _namespace_name "Rank" |> NamespacedName
    /// <summary>
    /// A dump of wikidata content.
    /// <see href="http://wikiba.se/ontology#Dump"></see></summary>
    let Dump = Namespaced_IRI.parse _namespace_name "Dump" |> NamespacedName
    /// <summary>
    /// Wikibase entity.
    /// <see href="http://wikiba.se/ontology#Entity"></see></summary>
    let Entity = Namespaced_IRI.parse _namespace_name "Entity" |> NamespacedName
    /// <summary>
    /// Type for referring to ID defined by external authority.
    /// <see href="http://wikiba.se/ontology#ExternalId"></see></summary>
    let ExternalId = Namespaced_IRI.parse _namespace_name "ExternalId" |> NamespacedName

    /// <summary>
    /// This coordinate value uses automatic precision since the user did not specify one.
    /// <see href="http://wikiba.se/ontology#GeoAutoPrecision"></see></summary>
    let GeoAutoPrecision =
        Namespaced_IRI.parse _namespace_name "GeoAutoPrecision" |> NamespacedName

    /// <summary>
    /// Type for storing links to geoshape data.
    /// <see href="http://wikiba.se/ontology#GeoShape"></see></summary>
    let GeoShape = Namespaced_IRI.parse _namespace_name "GeoShape" |> NamespacedName

    /// <summary>
    /// Coordinate type.
    /// <see href="http://wikiba.se/ontology#Globecoordinate"></see></summary>
    let Globecoordinate =
        Namespaced_IRI.parse _namespace_name "Globecoordinate" |> NamespacedName

    /// <summary>
    /// Wikibase extended value representing geographic coordinate.
    /// <see href="http://wikiba.se/ontology#GlobecoordinateValue"></see></summary>
    let GlobecoordinateValue =
        Namespaced_IRI.parse _namespace_name "GlobecoordinateValue" |> NamespacedName

    /// <summary>
    /// Wikibase extended value.
    /// <see href="http://wikiba.se/ontology#Value"></see></summary>
    let Value = Namespaced_IRI.parse _namespace_name "Value" |> NamespacedName
    /// <summary>
    /// Type for mathematical expressions as supported by the Math extension.
    /// <see href="http://wikiba.se/ontology#Math"></see></summary>
    let Math = Namespaced_IRI.parse _namespace_name "Math" |> NamespacedName

    /// <summary>
    /// Type for text in single language.
    /// <see href="http://wikiba.se/ontology#Monolingualtext"></see></summary>
    let Monolingualtext =
        Namespaced_IRI.parse _namespace_name "Monolingualtext" |> NamespacedName

    /// <summary>
    /// Normal statement rank.
    /// <see href="http://wikiba.se/ontology#NormalRank"></see></summary>
    let NormalRank = Namespaced_IRI.parse _namespace_name "NormalRank" |> NamespacedName

    /// <summary>
    /// Preferred statement rank.
    /// <see href="http://wikiba.se/ontology#PreferredRank"></see></summary>
    let PreferredRank =
        Namespaced_IRI.parse _namespace_name "PreferredRank" |> NamespacedName

    /// <summary>
    /// Type for numerical quantity.
    /// <see href="http://wikiba.se/ontology#Quantity"></see></summary>
    let Quantity = Namespaced_IRI.parse _namespace_name "Quantity" |> NamespacedName

    /// <summary>
    /// Wikibase extended value representing quantity.
    /// <see href="http://wikiba.se/ontology#QuantityValue"></see></summary>
    let QuantityValue =
        Namespaced_IRI.parse _namespace_name "QuantityValue" |> NamespacedName

    /// <summary>
    /// A reference to sources supporting the claim.
    /// <see href="http://wikiba.se/ontology#Reference"></see></summary>
    let Reference = Namespaced_IRI.parse _namespace_name "Reference" |> NamespacedName
    /// <summary>
    /// A reified statement.
    /// <see href="http://wikiba.se/ontology#Statement"></see></summary>
    let Statement = Namespaced_IRI.parse _namespace_name "Statement" |> NamespacedName
    /// <summary>
    /// Basic string type.
    /// <see href="http://wikiba.se/ontology#String"></see></summary>
    let String = Namespaced_IRI.parse _namespace_name "String" |> NamespacedName

    /// <summary>
    /// Type for storing links to tabular data.
    /// <see href="http://wikiba.se/ontology#TabularData"></see></summary>
    let TabularData =
        Namespaced_IRI.parse _namespace_name "TabularData" |> NamespacedName

    /// <summary>
    /// Date and time value type.
    /// <see href="http://wikiba.se/ontology#Time"></see></summary>
    let Time = Namespaced_IRI.parse _namespace_name "Time" |> NamespacedName
    /// <summary>
    /// Wikibase extended value representing time.
    /// <see href="http://wikiba.se/ontology#TimeValue"></see></summary>
    let TimeValue = Namespaced_IRI.parse _namespace_name "TimeValue" |> NamespacedName
    /// <summary>
    /// URL link type.
    /// <see href="http://wikiba.se/ontology#Url"></see></summary>
    let Url = Namespaced_IRI.parse _namespace_name "Url" |> NamespacedName

    /// <summary>
    /// Type for referring to another Wikibase item.
    /// <see href="http://wikiba.se/ontology#WikibaseItem"></see></summary>
    let WikibaseItem =
        Namespaced_IRI.parse _namespace_name "WikibaseItem" |> NamespacedName

    /// <summary>
    /// Type for referring to a Wikibase property.
    /// <see href="http://wikiba.se/ontology#WikibaseProperty"></see></summary>
    let WikibaseProperty =
        Namespaced_IRI.parse _namespace_name "WikibaseProperty" |> NamespacedName

    /// <summary>
    /// Badge on the Wiki page.
    /// <see href="http://wikiba.se/ontology#badge"></see></summary>
    let badge = Namespaced_IRI.parse _namespace_name "badge" |> NamespacedName
    /// <summary>
    /// Link between Wikibase Property and claim predicate.
    /// <see href="http://wikiba.se/ontology#claim"></see></summary>
    let claim = Namespaced_IRI.parse _namespace_name "claim" |> NamespacedName

    /// <summary>
    /// Link between Wikibase Property and direct claim predicate.
    /// <see href="http://wikiba.se/ontology#directClaim"></see></summary>
    let directClaim =
        Namespaced_IRI.parse _namespace_name "directClaim" |> NamespacedName

    /// <summary>
    /// Globe reference URL.
    /// <see href="http://wikiba.se/ontology#geoGlobe"></see></summary>
    let geoGlobe = Namespaced_IRI.parse _namespace_name "geoGlobe" |> NamespacedName

    /// <summary>
    /// Coordinate latitude.
    /// <see href="http://wikiba.se/ontology#geoLatitude"></see></summary>
    let geoLatitude =
        Namespaced_IRI.parse _namespace_name "geoLatitude" |> NamespacedName

    /// <summary>
    /// Coordinate longitude.
    /// <see href="http://wikiba.se/ontology#geoLongitude"></see></summary>
    let geoLongitude =
        Namespaced_IRI.parse _namespace_name "geoLongitude" |> NamespacedName

    /// <summary>
    /// Coordinate precision.
    /// <see href="http://wikiba.se/ontology#geoPrecision"></see></summary>
    let geoPrecision =
        Namespaced_IRI.parse _namespace_name "geoPrecision" |> NamespacedName

    /// <summary>
    /// Form grammatical feature.
    /// <see href="http://wikiba.se/ontology#grammaticalFeature"></see></summary>
    let grammaticalFeature =
        Namespaced_IRI.parse _namespace_name "grammaticalFeature" |> NamespacedName

    /// <summary>
    /// Link between statement violating constraint and the constraint.
    /// <see href="http://wikiba.se/ontology#hasViolationForConstraint"></see></summary>
    let hasViolationForConstraint =
        Namespaced_IRI.parse _namespace_name "hasViolationForConstraint" |> NamespacedName

    /// <summary>
    /// Lexeme lemma.
    /// <see href="http://wikiba.se/ontology#lemma"></see></summary>
    let lemma = Namespaced_IRI.parse _namespace_name "lemma" |> NamespacedName

    /// <summary>
    /// Lexeme lexical category.
    /// <see href="http://wikiba.se/ontology#lexicalCategory"></see></summary>
    let lexicalCategory =
        Namespaced_IRI.parse _namespace_name "lexicalCategory" |> NamespacedName

    /// <summary>
    /// Link between Wikibase Property and no value class.
    /// <see href="http://wikiba.se/ontology#novalue"></see></summary>
    let novalue = Namespaced_IRI.parse _namespace_name "novalue" |> NamespacedName
    /// <summary>
    /// Link between Wikibase Property and qualifier predicate.
    /// <see href="http://wikiba.se/ontology#qualifier"></see></summary>
    let qualifier = Namespaced_IRI.parse _namespace_name "qualifier" |> NamespacedName

    /// <summary>
    /// Link between Wikibase Property and qualifier value predicate.
    /// <see href="http://wikiba.se/ontology#qualifierValue"></see></summary>
    let qualifierValue =
        Namespaced_IRI.parse _namespace_name "qualifierValue" |> NamespacedName

    /// <summary>
    /// Link between Wikibase Property and qualifier normalized value predicate.
    /// <see href="http://wikiba.se/ontology#qualifierValueNormalized"></see></summary>
    let qualifierValueNormalized =
        Namespaced_IRI.parse _namespace_name "qualifierValueNormalized" |> NamespacedName

    /// <summary>
    /// Amount of quantity.
    /// <see href="http://wikiba.se/ontology#quantityAmount"></see></summary>
    let quantityAmount =
        Namespaced_IRI.parse _namespace_name "quantityAmount" |> NamespacedName

    /// <summary>
    /// Lower bound of the value.
    /// <see href="http://wikiba.se/ontology#quantityLowerBound"></see></summary>
    let quantityLowerBound =
        Namespaced_IRI.parse _namespace_name "quantityLowerBound" |> NamespacedName

    /// <summary>
    /// Representation of this quantity in standard units.
    /// <see href="http://wikiba.se/ontology#quantityNormalized"></see></summary>
    let quantityNormalized =
        Namespaced_IRI.parse _namespace_name "quantityNormalized" |> NamespacedName

    /// <summary>
    /// Unit of measurement.
    /// <see href="http://wikiba.se/ontology#quantityUnit"></see></summary>
    let quantityUnit =
        Namespaced_IRI.parse _namespace_name "quantityUnit" |> NamespacedName

    /// <summary>
    /// Upper bound of the value.
    /// <see href="http://wikiba.se/ontology#quantityUpperBound"></see></summary>
    let quantityUpperBound =
        Namespaced_IRI.parse _namespace_name "quantityUpperBound" |> NamespacedName

    /// <summary>
    /// Statement rank.
    /// <see href="http://wikiba.se/ontology#rank"></see></summary>
    let rank = Namespaced_IRI.parse _namespace_name "rank" |> NamespacedName
    /// <summary>
    /// Link between Wikibase Property and reference predicate.
    /// <see href="http://wikiba.se/ontology#reference"></see></summary>
    let reference = Namespaced_IRI.parse _namespace_name "reference" |> NamespacedName

    /// <summary>
    /// Link between Wikibase Property and reference value predicate.
    /// <see href="http://wikiba.se/ontology#referenceValue"></see></summary>
    let referenceValue =
        Namespaced_IRI.parse _namespace_name "referenceValue" |> NamespacedName

    /// <summary>
    /// Link between Wikibase Property and reference normalized value predicate.
    /// <see href="http://wikiba.se/ontology#referenceValueNormalized"></see></summary>
    let referenceValueNormalized =
        Namespaced_IRI.parse _namespace_name "referenceValueNormalized" |> NamespacedName

    /// <summary>
    /// Link between Wikibase Property and statement property predicate.
    /// <see href="http://wikiba.se/ontology#statementProperty"></see></summary>
    let statementProperty =
        Namespaced_IRI.parse _namespace_name "statementProperty" |> NamespacedName

    /// <summary>
    /// Link between Wikibase Property and statement value predicate.
    /// <see href="http://wikiba.se/ontology#statementValue"></see></summary>
    let statementValue =
        Namespaced_IRI.parse _namespace_name "statementValue" |> NamespacedName

    /// <summary>
    /// Link between Wikibase Property and statement normalized value predicate.
    /// <see href="http://wikiba.se/ontology#statementValueNormalized"></see></summary>
    let statementValueNormalized =
        Namespaced_IRI.parse _namespace_name "statementValueNormalized" |> NamespacedName

    /// <summary>
    /// Preferred calendar used to display this date to the user.
    /// <see href="http://wikiba.se/ontology#timeCalendarModel"></see></summary>
    let timeCalendarModel =
        Namespaced_IRI.parse _namespace_name "timeCalendarModel" |> NamespacedName

    /// <summary>
    /// Datetime precision.
    /// <see href="http://wikiba.se/ontology#timePrecision"></see></summary>
    let timePrecision =
        Namespaced_IRI.parse _namespace_name "timePrecision" |> NamespacedName

    /// <summary>
    /// Timezone offset from UTC in minutes.
    /// <see href="http://wikiba.se/ontology#timeTimezone"></see></summary>
    let timeTimezone =
        Namespaced_IRI.parse _namespace_name "timeTimezone" |> NamespacedName

    /// <summary>
    /// Time value as datetime literal.
    /// <see href="http://wikiba.se/ontology#timeValue"></see></summary>
    let timeValue = Namespaced_IRI.parse _namespace_name "timeValue" |> NamespacedName
    /// <summary>
    /// Wiki group that the site belongs to.
    /// <see href="http://wikiba.se/ontology#wikiGroup"></see></summary>
    let wikiGroup = Namespaced_IRI.parse _namespace_name "wikiGroup" |> NamespacedName

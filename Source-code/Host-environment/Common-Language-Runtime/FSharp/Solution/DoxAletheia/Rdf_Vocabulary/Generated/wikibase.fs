namespace http.wikiba.se.ontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module wikibase =
    let _namespace_iri = Namespace_Iri wikibase |> NamespaceIRI
    /// <summary>
    ///   <para>wikibase:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"The system ontology of Wikibase"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Wikibase system ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#">http://wikiba.se/ontology#</seealso>
    let _prefix_iri = Prefixed_Name(wikibase, "") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:BestRank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class marks statement that has the best rank for its property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"BestRank"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#BestRank">http://wikiba.se/ontology#BestRank</seealso>
    let BestRank = Prefixed_Name(wikibase, "BestRank") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:CommonsMedia</para>
    /// </summary>
    /// <remarks>
    ///   <para>wikibase:PropertyType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Wikimedia Commons reference type."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CommonsMedia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#CommonsMedia">http://wikiba.se/ontology#CommonsMedia</seealso>
    let CommonsMedia = Prefixed_Name(wikibase, "CommonsMedia") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:DeprecatedRank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>wikibase:Rank</para>
    ///   <para>"Deprecated statement rank."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DeprecatedRank"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#DeprecatedRank">http://wikiba.se/ontology#DeprecatedRank</seealso>
    let DeprecatedRank = Prefixed_Name(wikibase, "DeprecatedRank") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:Dump</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A dump of wikidata content."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dump"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#Dump">http://wikiba.se/ontology#Dump</seealso>
    let Dump = Prefixed_Name(wikibase, "Dump") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:Entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Wikibase entity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#Entity">http://wikiba.se/ontology#Entity</seealso>
    let Entity = Prefixed_Name(wikibase, "Entity") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:ExternalId</para>
    /// </summary>
    /// <remarks>
    ///   <para>wikibase:PropertyType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Type for referring to ID defined by external authority."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"WikibaseExternalId"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#ExternalId">http://wikiba.se/ontology#ExternalId</seealso>
    let ExternalId = Prefixed_Name(wikibase, "ExternalId") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:Form</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Wikibase Form."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Form"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#Form">http://wikiba.se/ontology#Form</seealso>
    let Form = Prefixed_Name(wikibase, "Form") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:GeoAutoPrecision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This coordinate value uses automatic precision since the user did not specify one."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"GeoAutoPrecision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#GeoAutoPrecision">http://wikiba.se/ontology#GeoAutoPrecision</seealso>
    let GeoAutoPrecision = Prefixed_Name(wikibase, "GeoAutoPrecision") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:GeoShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>wikibase:PropertyType</para>
    ///   <para>"Type for storing links to geoshape data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"GeoShape"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#GeoShape">http://wikiba.se/ontology#GeoShape</seealso>
    let GeoShape = Prefixed_Name(wikibase, "GeoShape") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:Globecoordinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>wikibase:PropertyType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Coordinate type."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Globecoordinate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#Globecoordinate">http://wikiba.se/ontology#Globecoordinate</seealso>
    let Globecoordinate = Prefixed_Name(wikibase, "Globecoordinate") |> PrefixedName

    /// <summary>
    ///   <para>wikibase:GlobecoordinateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Wikibase extended value representing geographic coordinate."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"GlobecoordinateValue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#GlobecoordinateValue">http://wikiba.se/ontology#GlobecoordinateValue</seealso>
    let GlobecoordinateValue =
        Prefixed_Name(wikibase, "GlobecoordinateValue") |> PrefixedName

    /// <summary>
    ///   <para>wikibase:Item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Wikibase item."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Item"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#Item">http://wikiba.se/ontology#Item</seealso>
    let Item = Prefixed_Name(wikibase, "Item") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:Lexeme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Wikibase Lexeme."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Lexeme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#Lexeme">http://wikiba.se/ontology#Lexeme</seealso>
    let Lexeme = Prefixed_Name(wikibase, "Lexeme") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:Math</para>
    /// </summary>
    /// <remarks>
    ///   <para>wikibase:PropertyType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Type for mathematical expressions as supported by the Math extension."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mathematial expression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#Math">http://wikiba.se/ontology#Math</seealso>
    let Math = Prefixed_Name(wikibase, "Math") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:Monolingualtext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>wikibase:PropertyType</para>
    ///   <para>"Type for text in single language."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Monolingualtext"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#Monolingualtext">http://wikiba.se/ontology#Monolingualtext</seealso>
    let Monolingualtext = Prefixed_Name(wikibase, "Monolingualtext") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:NormalRank</para>
    /// </summary>
    /// <remarks>
    ///   <para>wikibase:Rank</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Normal statement rank."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NormalRank"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#NormalRank">http://wikiba.se/ontology#NormalRank</seealso>
    let NormalRank = Prefixed_Name(wikibase, "NormalRank") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:PreferredRank</para>
    /// </summary>
    /// <remarks>
    ///   <para>wikibase:Rank</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Preferred statement rank."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PreferredRank"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#PreferredRank">http://wikiba.se/ontology#PreferredRank</seealso>
    let PreferredRank = Prefixed_Name(wikibase, "PreferredRank") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Wikibase property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#Property">http://wikiba.se/ontology#Property</seealso>
    let Property = Prefixed_Name(wikibase, "Property") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:PropertyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Type of a wikibase property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PropertyType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#PropertyType">http://wikiba.se/ontology#PropertyType</seealso>
    let PropertyType = Prefixed_Name(wikibase, "PropertyType") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:Quantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>wikibase:PropertyType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Type for numerical quantity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Quantity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#Quantity">http://wikiba.se/ontology#Quantity</seealso>
    let Quantity = Prefixed_Name(wikibase, "Quantity") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:QuantityValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Wikibase extended value representing quantity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"QuantityValue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#QuantityValue">http://wikiba.se/ontology#QuantityValue</seealso>
    let QuantityValue = Prefixed_Name(wikibase, "QuantityValue") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:Rank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Wikibase statement rank."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Rank"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#Rank">http://wikiba.se/ontology#Rank</seealso>
    let Rank = Prefixed_Name(wikibase, "Rank") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:Reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A reference to sources supporting the claim."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#Reference">http://wikiba.se/ontology#Reference</seealso>
    let Reference = Prefixed_Name(wikibase, "Reference") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:Statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A reified statement."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Statement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#Statement">http://wikiba.se/ontology#Statement</seealso>
    let Statement = Prefixed_Name(wikibase, "Statement") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:String</para>
    /// </summary>
    /// <remarks>
    ///   <para>wikibase:PropertyType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Basic string type."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"String"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#String">http://wikiba.se/ontology#String</seealso>
    let String = Prefixed_Name(wikibase, "String") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:TabularData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>wikibase:PropertyType</para>
    ///   <para>"Type for storing links to tabular data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TabularData"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#TabularData">http://wikiba.se/ontology#TabularData</seealso>
    let TabularData = Prefixed_Name(wikibase, "TabularData") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:Time</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>wikibase:PropertyType</para>
    ///   <para>"Date and time value type."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#Time">http://wikiba.se/ontology#Time</seealso>
    let Time = Prefixed_Name(wikibase, "Time") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:TimeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Wikibase extended value representing time."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TimeValue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#TimeValue">http://wikiba.se/ontology#TimeValue</seealso>
    let TimeValue = Prefixed_Name(wikibase, "TimeValue") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:Url</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>wikibase:PropertyType</para>
    ///   <para>"URL link type."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Url"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#Url">http://wikiba.se/ontology#Url</seealso>
    let Url = Prefixed_Name(wikibase, "Url") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:Value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Wikibase extended value."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#Value">http://wikiba.se/ontology#Value</seealso>
    let Value = Prefixed_Name(wikibase, "Value") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:WikibaseItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>wikibase:PropertyType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Type for referring to another Wikibase item."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"WikibaseItem"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#WikibaseItem">http://wikiba.se/ontology#WikibaseItem</seealso>
    let WikibaseItem = Prefixed_Name(wikibase, "WikibaseItem") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:WikibaseProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>wikibase:PropertyType</para>
    ///   <para>"Type for referring to a Wikibase property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"WikibaseProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#WikibaseProperty">http://wikiba.se/ontology#WikibaseProperty</seealso>
    let WikibaseProperty = Prefixed_Name(wikibase, "WikibaseProperty") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:badge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Badge on the Wiki page."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"badge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#badge">http://wikiba.se/ontology#badge</seealso>
    let badge = Prefixed_Name(wikibase, "badge") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:claim</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Link between Wikibase Property and claim predicate."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"claim"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#claim">http://wikiba.se/ontology#claim</seealso>
    let claim = Prefixed_Name(wikibase, "claim") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:directClaim</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Link between Wikibase Property and direct claim predicate."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"directClaim"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#directClaim">http://wikiba.se/ontology#directClaim</seealso>
    let directClaim = Prefixed_Name(wikibase, "directClaim") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:geoGlobe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Globe reference URL."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"geoGlobe"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#geoGlobe">http://wikiba.se/ontology#geoGlobe</seealso>
    let geoGlobe = Prefixed_Name(wikibase, "geoGlobe") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:geoLatitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Coordinate latitude."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"geoLatitude"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#geoLatitude">http://wikiba.se/ontology#geoLatitude</seealso>
    let geoLatitude = Prefixed_Name(wikibase, "geoLatitude") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:geoLongitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Coordinate longitude."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"geoLongitude"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#geoLongitude">http://wikiba.se/ontology#geoLongitude</seealso>
    let geoLongitude = Prefixed_Name(wikibase, "geoLongitude") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:geoPrecision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Coordinate precision."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"geoPrecision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#geoPrecision">http://wikiba.se/ontology#geoPrecision</seealso>
    let geoPrecision = Prefixed_Name(wikibase, "geoPrecision") |> PrefixedName

    /// <summary>
    ///   <para>wikibase:grammaticalFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Form grammatical feature."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"grammaticalFeature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#grammaticalFeature">http://wikiba.se/ontology#grammaticalFeature</seealso>
    let grammaticalFeature =
        Prefixed_Name(wikibase, "grammaticalFeature") |> PrefixedName

    /// <summary>
    ///   <para>wikibase:hasViolationForConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Link between statement violating constraint and the constraint."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasViolationForConstraint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#hasViolationForConstraint">http://wikiba.se/ontology#hasViolationForConstraint</seealso>
    let hasViolationForConstraint =
        Prefixed_Name(wikibase, "hasViolationForConstraint") |> PrefixedName

    /// <summary>
    ///   <para>wikibase:lemma</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Lexeme lemma."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"lemma"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#lemma">http://wikiba.se/ontology#lemma</seealso>
    let lemma = Prefixed_Name(wikibase, "lemma") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:lexicalCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Lexeme lexical category."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"lexicalCategory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#lexicalCategory">http://wikiba.se/ontology#lexicalCategory</seealso>
    let lexicalCategory = Prefixed_Name(wikibase, "lexicalCategory") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:novalue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Link between Wikibase Property and no value class."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"novalue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#novalue">http://wikiba.se/ontology#novalue</seealso>
    let novalue = Prefixed_Name(wikibase, "novalue") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:qualifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Link between Wikibase Property and qualifier predicate."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"qualifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#qualifier">http://wikiba.se/ontology#qualifier</seealso>
    let qualifier = Prefixed_Name(wikibase, "qualifier") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:qualifierValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Link between Wikibase Property and qualifier value predicate."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"qualifierValue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#qualifierValue">http://wikiba.se/ontology#qualifierValue</seealso>
    let qualifierValue = Prefixed_Name(wikibase, "qualifierValue") |> PrefixedName

    /// <summary>
    ///   <para>wikibase:qualifierValueNormalized</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Link between Wikibase Property and qualifier normalized value predicate."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"qualifierValueNormalized"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#qualifierValueNormalized">http://wikiba.se/ontology#qualifierValueNormalized</seealso>
    let qualifierValueNormalized =
        Prefixed_Name(wikibase, "qualifierValueNormalized") |> PrefixedName

    /// <summary>
    ///   <para>wikibase:quantityAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Amount of quantity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"quantityAmount"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#quantityAmount">http://wikiba.se/ontology#quantityAmount</seealso>
    let quantityAmount = Prefixed_Name(wikibase, "quantityAmount") |> PrefixedName

    /// <summary>
    ///   <para>wikibase:quantityLowerBound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Lower bound of the value."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"quantityLowerBound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#quantityLowerBound">http://wikiba.se/ontology#quantityLowerBound</seealso>
    let quantityLowerBound =
        Prefixed_Name(wikibase, "quantityLowerBound") |> PrefixedName

    /// <summary>
    ///   <para>wikibase:quantityNormalized</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Representation of this quantity in standard units."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"quantityNormalized"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#quantityNormalized">http://wikiba.se/ontology#quantityNormalized</seealso>
    let quantityNormalized =
        Prefixed_Name(wikibase, "quantityNormalized") |> PrefixedName

    /// <summary>
    ///   <para>wikibase:quantityUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Unit of measurement."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"quantityUnit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#quantityUnit">http://wikiba.se/ontology#quantityUnit</seealso>
    let quantityUnit = Prefixed_Name(wikibase, "quantityUnit") |> PrefixedName

    /// <summary>
    ///   <para>wikibase:quantityUpperBound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Upper bound of the value."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"quantityUpperBound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#quantityUpperBound">http://wikiba.se/ontology#quantityUpperBound</seealso>
    let quantityUpperBound =
        Prefixed_Name(wikibase, "quantityUpperBound") |> PrefixedName

    /// <summary>
    ///   <para>wikibase:rank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Statement rank."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"rank"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#rank">http://wikiba.se/ontology#rank</seealso>
    let rank = Prefixed_Name(wikibase, "rank") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Link between Wikibase Property and reference predicate."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#reference">http://wikiba.se/ontology#reference</seealso>
    let reference = Prefixed_Name(wikibase, "reference") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:referenceValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Link between Wikibase Property and reference value predicate."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"referenceValue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#referenceValue">http://wikiba.se/ontology#referenceValue</seealso>
    let referenceValue = Prefixed_Name(wikibase, "referenceValue") |> PrefixedName

    /// <summary>
    ///   <para>wikibase:referenceValueNormalized</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Link between Wikibase Property and reference normalized value predicate."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"referenceValueNormalized"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#referenceValueNormalized">http://wikiba.se/ontology#referenceValueNormalized</seealso>
    let referenceValueNormalized =
        Prefixed_Name(wikibase, "referenceValueNormalized") |> PrefixedName

    /// <summary>
    ///   <para>wikibase:statementProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Link between Wikibase Property and statement property predicate."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"statementProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#statementProperty">http://wikiba.se/ontology#statementProperty</seealso>
    let statementProperty = Prefixed_Name(wikibase, "statementProperty") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:statementValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Link between Wikibase Property and statement value predicate."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"statementValue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#statementValue">http://wikiba.se/ontology#statementValue</seealso>
    let statementValue = Prefixed_Name(wikibase, "statementValue") |> PrefixedName

    /// <summary>
    ///   <para>wikibase:statementValueNormalized</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Link between Wikibase Property and statement normalized value predicate."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"statementValueNormalized"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#statementValueNormalized">http://wikiba.se/ontology#statementValueNormalized</seealso>
    let statementValueNormalized =
        Prefixed_Name(wikibase, "statementValueNormalized") |> PrefixedName

    /// <summary>
    ///   <para>wikibase:timeCalendarModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Preferred calendar used to display this date to the user."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"timeCalendarModel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#timeCalendarModel">http://wikiba.se/ontology#timeCalendarModel</seealso>
    let timeCalendarModel = Prefixed_Name(wikibase, "timeCalendarModel") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:timePrecision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Datetime precision."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"timePrecision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#timePrecision">http://wikiba.se/ontology#timePrecision</seealso>
    let timePrecision = Prefixed_Name(wikibase, "timePrecision") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:timeTimezone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Timezone offset from UTC in minutes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"timeTimezone"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#timeTimezone">http://wikiba.se/ontology#timeTimezone</seealso>
    let timeTimezone = Prefixed_Name(wikibase, "timeTimezone") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:timeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Time value as datetime literal."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"timeValue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#timeValue">http://wikiba.se/ontology#timeValue</seealso>
    let timeValue = Prefixed_Name(wikibase, "timeValue") |> PrefixedName
    /// <summary>
    ///   <para>wikibase:wikiGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Wiki group that the site belongs to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"wikiGroup"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://wikiba.se/ontology#wikiGroup">http://wikiba.se/ontology#wikiGroup</seealso>
    let wikiGroup = Prefixed_Name(wikibase, "wikiGroup") |> PrefixedName

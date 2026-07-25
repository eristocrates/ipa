namespace http.qudt.org.schema.qudt.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module qudt =
    let _namespace_iri = Namespace_Iri qudt |> NamespaceIRI
    /// <summary>
    ///   <para>qudt:EndianType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Endian Type</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/EndianType">http://qudt.org/schema/qudt/EndianType</seealso>
    let EndianType = Prefixed_Name(qudt, "EndianType") |> PrefixedName
    /// <summary>
    ///   <para>qudt:Scale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Scales (also called "scales of measurement" or "levels of measurement")  are expressions that typically refer to the theory of scale types.</para>
    /// labels<para>Scale</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/Scale">http://qudt.org/schema/qudt/Scale</seealso>
    let Scale = Prefixed_Name(qudt, "Scale") |> PrefixedName
    /// <summary>
    ///   <para>qudt:figureLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>figure label</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/figureLabel">http://qudt.org/schema/qudt/figureLabel</seealso>
    let figureLabel = Prefixed_Name(qudt, "figureLabel") |> PrefixedName
    /// <summary>
    ///   <para>qudt:height</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>height</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/height">http://qudt.org/schema/qudt/height</seealso>
    let height = Prefixed_Name(qudt, "height") |> PrefixedName
    /// <summary>
    ///   <para>qudt:imageLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>image location</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/imageLocation">http://qudt.org/schema/qudt/imageLocation</seealso>
    let imageLocation = Prefixed_Name(qudt, "imageLocation") |> PrefixedName
    /// <summary>
    ///   <para>qudt:landscape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>landscape</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/landscape">http://qudt.org/schema/qudt/landscape</seealso>
    let landscape = Prefixed_Name(qudt, "landscape") |> PrefixedName

    /// <summary>
    ///   <para>qudt:ISO8601-UTCDateTime-BasicFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:DateTimeStringEncodingType</para>
    ///
    /// labels<para>ISO 8601 UTC Date Time - Basic Format</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/ISO8601-UTCDateTime-BasicFormat">http://qudt.org/schema/qudt/ISO8601-UTCDateTime-BasicFormat</seealso>
    let ISO8601_UTCDateTime_BasicFormat =
        Prefixed_Name(qudt, "ISO8601-UTCDateTime-BasicFormat") |> PrefixedName

    /// <summary>
    ///   <para>qudt:IntegerEncodingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Integer Encoding</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/IntegerEncodingType">http://qudt.org/schema/qudt/IntegerEncodingType</seealso>
    let IntegerEncodingType = Prefixed_Name(qudt, "IntegerEncodingType") |> PrefixedName
    /// <summary>
    ///   <para>qudt:IntervalScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>median, percentile &amp; Monotonic increasing (order (&lt;)) &amp; totally ordered set</para>
    ///   <para>&lt;p&gt;The interval type allows for the degree of difference between items, but not the ratio between them. Examples include temperature with the Celsius scale, which has two defined points (the freezing and boiling point of water at specific conditions) and then separated into 100 intervals, date when measured from an arbitrary epoch (such as AD), percentage such as a percentage return on a stock,[16] location in Cartesian coordinates, and direction measured in degrees from true or magnetic north. Ratios are not meaningful since 20 Â°C cannot be said to be "twice as hot" as 10 Â°C, nor can multiplication/division be carried out between any two dates directly. However, ratios of differences can be expressed; for example, one difference can be twice another. Interval type variables are sometimes also called "scaled variables", but the formal mathematical term is an affine space (in this case an affine line).&lt;/p&gt;
    /// &lt;p&gt;Characteristics: median, percentile &amp;amp; Monotonic increasing (order (&amp;lt;) &amp;amp; totally ordered set&lt;/p&gt;</para>
    /// labels<para>Interval scale</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/IntervalScale">http://qudt.org/schema/qudt/IntervalScale</seealso>
    let IntervalScale = Prefixed_Name(qudt, "IntervalScale") |> PrefixedName
    /// <summary>
    ///   <para>qudt:OrdinalScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ordinal type allows for rank order (1st, 2nd, 3rd, etc.) by which data can be sorted, but still does not allow for relative degree of difference between them. Examples include, on one hand, dichotomous data with dichotomous (or dichotomized) values such as 'sick' vs. 'healthy' when measuring health, 'guilty' vs. 'innocent' when making judgments in courts, 'wrong/false' vs. 'right/true' when measuring truth value, and, on the other hand, non-dichotomous data consisting of a spectrum of values, such as 'completely agree', 'mostly agree', 'mostly disagree', 'completely disagree' when measuring opinion.</para>
    /// labels<para>Ordinal scale</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/OrdinalScale">http://qudt.org/schema/qudt/OrdinalScale</seealso>
    let OrdinalScale = Prefixed_Name(qudt, "OrdinalScale") |> PrefixedName
    /// <summary>
    ///   <para>qudt:RatioScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ratio type takes its name from the fact that measurement is the estimation of the ratio between a magnitude of a continuous quantity and a unit magnitude of the same kind (Michell, 1997, 1999). A ratio scale possesses a meaningful (unique and non-arbitrary) zero value. Most measurement in the physical sciences and engineering is done on ratio scales. Examples include mass, length, duration, plane angle, energy and electric charge. In contrast to interval scales, ratios are now meaningful because having a non-arbitrary zero point makes it meaningful to say, for example, that one object has "twice the length" of another (= is "twice as long"). Very informally, many ratio scales can be described as specifying "how much" of something (i.e. an amount or magnitude) or "how many" (a count). The Kelvin temperature scale is a ratio scale because it has a unique, non-arbitrary zero point called absolute zero.</para>
    /// labels<para>Ratio scale</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/RatioScale">http://qudt.org/schema/qudt/RatioScale</seealso>
    let RatioScale = Prefixed_Name(qudt, "RatioScale") |> PrefixedName
    /// <summary>
    ///   <para>qudt:NominalScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A nominal scale differentiates between items or subjects based only on their names or (meta-)categories and other qualitative classifications they belong to; thus dichotomous data involves the construction of classifications as well as the classification of items. Discovery of an exception to a classification can be viewed as progress. Numbers may be used to represent the variables but the numbers do not have numerical value or relationship: For example, a Globally unique identifier. Examples of these classifications include gender, nationality, ethnicity, language, genre, style, biological species, and form. In a university one could also use hall of affiliation as an example.</para>
    /// labels<para>Nominal scale</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/NominalScale">http://qudt.org/schema/qudt/NominalScale</seealso>
    let NominalScale = Prefixed_Name(qudt, "NominalScale") |> PrefixedName
    /// <summary>
    ///   <para>qudt:LatexString</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>A type of string in which some characters may be wrapped with '\\(' and '\\) characters for LaTeX rendering.</para>
    /// labels<para>Latex String</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/LatexString">http://qudt.org/schema/qudt/LatexString</seealso>
    let LatexString = Prefixed_Name(qudt, "LatexString") |> PrefixedName

    /// <summary>
    ///   <para>qudt:LongUnsignedIntegerEncoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:IntegerEncodingType</para>
    ///
    /// labels<para>Long Unsigned Integer Encoding</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/LongUnsignedIntegerEncoding">http://qudt.org/schema/qudt/LongUnsignedIntegerEncoding</seealso>
    let LongUnsignedIntegerEncoding =
        Prefixed_Name(qudt, "LongUnsignedIntegerEncoding") |> PrefixedName

    /// <summary>
    ///   <para>qudt:isoNormativeReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>normative reference (ISO)</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/isoNormativeReference">http://qudt.org/schema/qudt/isoNormativeReference</seealso>
    let isoNormativeReference =
        Prefixed_Name(qudt, "isoNormativeReference") |> PrefixedName

    /// <summary>
    ///   <para>qudt:reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>reference</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/reference">http://qudt.org/schema/qudt/reference</seealso>
    let reference = Prefixed_Name(qudt, "reference") |> PrefixedName
    /// <summary>
    ///   <para>qudt:CardinalityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Cardinality Type</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/CardinalityType">http://qudt.org/schema/qudt/CardinalityType</seealso>
    let CardinalityType = Prefixed_Name(qudt, "CardinalityType") |> PrefixedName

    /// <summary>
    ///   <para>qudt:plainTextDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>description (plain text)</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/plainTextDescription">http://qudt.org/schema/qudt/plainTextDescription</seealso>
    let plainTextDescription =
        Prefixed_Name(qudt, "plainTextDescription") |> PrefixedName

    /// <summary>
    ///   <para>qudt:bytes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>bytes</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/bytes">http://qudt.org/schema/qudt/bytes</seealso>
    let bytes = Prefixed_Name(qudt, "bytes") |> PrefixedName
    /// <summary>
    ///   <para>qudt:Citation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Provides a simple way of making citations.</para>
    /// labels<para>Citation</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/Citation">http://qudt.org/schema/qudt/Citation</seealso>
    let Citation = Prefixed_Name(qudt, "Citation") |> PrefixedName
    /// <summary>
    ///   <para>qudt:Comment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Comment</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/Comment">http://qudt.org/schema/qudt/Comment</seealso>
    let Comment = Prefixed_Name(qudt, "Comment") |> PrefixedName
    /// <summary>
    ///   <para>qudt:Verifiable</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:AspectClass</para>
    ///   <para>An aspect class that holds properties that provide external knowledge and specifications of a given resource.</para>
    /// labels<para>Verifiable</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/Verifiable">http://qudt.org/schema/qudt/Verifiable</seealso>
    let Verifiable = Prefixed_Name(qudt, "Verifiable") |> PrefixedName
    /// <summary>
    ///   <para>qudt:id</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>qudt id</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/id">http://qudt.org/schema/qudt/id</seealso>
    let id = Prefixed_Name(qudt, "id") |> PrefixedName

    /// <summary>
    ///   <para>qudt:isAllowedUnitOfSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>allowed unit of system</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/isAllowedUnitOfSystem">http://qudt.org/schema/qudt/isAllowedUnitOfSystem</seealso>
    let isAllowedUnitOfSystem =
        Prefixed_Name(qudt, "isAllowedUnitOfSystem") |> PrefixedName

    /// <summary>
    ///   <para>qudt:byteOrder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>byte order</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/byteOrder">http://qudt.org/schema/qudt/byteOrder</seealso>
    let byteOrder = Prefixed_Name(qudt, "byteOrder") |> PrefixedName
    /// <summary>
    ///   <para>qudt:Datatype</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>QUDT Datatype</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/Datatype">http://qudt.org/schema/qudt/Datatype</seealso>
    let Datatype = Prefixed_Name(qudt, "Datatype") |> PrefixedName
    /// <summary>
    ///   <para>qudt:oleDBName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>OLE DB name</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/oleDBName">http://qudt.org/schema/qudt/oleDBName</seealso>
    let oleDBName = Prefixed_Name(qudt, "oleDBName") |> PrefixedName
    /// <summary>
    ///   <para>qudt:ansiSQLName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>ANSI SQL Name</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/ansiSQLName">http://qudt.org/schema/qudt/ansiSQLName</seealso>
    let ansiSQLName = Prefixed_Name(qudt, "ansiSQLName") |> PrefixedName
    /// <summary>
    ///   <para>qudt:cardinality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>cardinality</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/cardinality">http://qudt.org/schema/qudt/cardinality</seealso>
    let cardinality = Prefixed_Name(qudt, "cardinality") |> PrefixedName

    /// <summary>
    ///   <para>qudt:microsoftSQLServerName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Microsoft SQL Server name</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/microsoftSQLServerName">http://qudt.org/schema/qudt/microsoftSQLServerName</seealso>
    let microsoftSQLServerName =
        Prefixed_Name(qudt, "microsoftSQLServerName") |> PrefixedName

    /// <summary>
    ///   <para>qudt:isMetricUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>is metric unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/isMetricUnit">http://qudt.org/schema/qudt/isMetricUnit</seealso>
    let isMetricUnit = Prefixed_Name(qudt, "isMetricUnit") |> PrefixedName
    /// <summary>
    ///   <para>qudt:lowerBound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>lower bound</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/lowerBound">http://qudt.org/schema/qudt/lowerBound</seealso>
    let lowerBound = Prefixed_Name(qudt, "lowerBound") |> PrefixedName
    /// <summary>
    ///   <para>qudt:AspectClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Aspect Class</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/AspectClass">http://qudt.org/schema/qudt/AspectClass</seealso>
    let AspectClass = Prefixed_Name(qudt, "AspectClass") |> PrefixedName

    /// <summary>
    ///   <para>qudt:informativeReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>informative reference</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/informativeReference">http://qudt.org/schema/qudt/informativeReference</seealso>
    let informativeReference =
        Prefixed_Name(qudt, "informativeReference") |> PrefixedName

    /// <summary>
    ///   <para>qudt:Concept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The root class for all QUDT concepts.</para>
    /// labels<para>QUDT Concept</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/Concept">http://qudt.org/schema/qudt/Concept</seealso>
    let Concept = Prefixed_Name(qudt, "Concept") |> PrefixedName

    /// <summary>
    ///   <para>qudt:DoublePrecisionEncoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:FloatingPointEncodingType</para>
    ///
    /// labels<para>Single Precision Real Encoding</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/DoublePrecisionEncoding">http://qudt.org/schema/qudt/DoublePrecisionEncoding</seealso>
    let DoublePrecisionEncoding =
        Prefixed_Name(qudt, "DoublePrecisionEncoding") |> PrefixedName

    /// <summary>
    ///   <para>qudt:bits</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>bits</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/bits">http://qudt.org/schema/qudt/bits</seealso>
    let bits = Prefixed_Name(qudt, "bits") |> PrefixedName
    /// <summary>
    ///   <para>qudt:symbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>symbol</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/symbol">http://qudt.org/schema/qudt/symbol</seealso>
    let symbol = Prefixed_Name(qudt, "symbol") |> PrefixedName
    /// <summary>
    ///   <para>qudt:UTF8-StringEncoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:StringEncodingType</para>
    ///
    /// labels<para>UTF-8 Encoding</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/UTF8-StringEncoding">http://qudt.org/schema/qudt/UTF8-StringEncoding</seealso>
    let UTF8_StringEncoding = Prefixed_Name(qudt, "UTF8-StringEncoding") |> PrefixedName

    /// <summary>
    ///   <para>qudt:numeratorDimensionVector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>numerator dimension vector</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/numeratorDimensionVector">http://qudt.org/schema/qudt/numeratorDimensionVector</seealso>
    let numeratorDimensionVector =
        Prefixed_Name(qudt, "numeratorDimensionVector") |> PrefixedName

    /// <summary>
    ///   <para>qudt:numericValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>numeric value</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/numericValue">http://qudt.org/schema/qudt/numericValue</seealso>
    let numericValue = Prefixed_Name(qudt, "numericValue") |> PrefixedName
    /// <summary>
    ///   <para>qudt:Aspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:AspectClass</para>
    ///   <para>An aspect is an abstract type class that defines properties that can be reused.</para>
    /// labels<para>QUDT Aspect</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/Aspect">http://qudt.org/schema/qudt/Aspect</seealso>
    let Aspect = Prefixed_Name(qudt, "Aspect") |> PrefixedName
    /// <summary>
    ///   <para>qudt:hasBaseQuantityKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has base quantity kind</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/hasBaseQuantityKind">http://qudt.org/schema/qudt/hasBaseQuantityKind</seealso>
    let hasBaseQuantityKind = Prefixed_Name(qudt, "hasBaseQuantityKind") |> PrefixedName
    /// <summary>
    ///   <para>qudt:Discipline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Discipline</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/Discipline">http://qudt.org/schema/qudt/Discipline</seealso>
    let Discipline = Prefixed_Name(qudt, "Discipline") |> PrefixedName
    /// <summary>
    ///   <para>qudt:DomainSpecificUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A domain-specific unit is a categorization of how units may be associated with an area of science, engineering or other discipline.</para>
    /// labels<para>Domain-specific Unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/DomainSpecificUnit">http://qudt.org/schema/qudt/DomainSpecificUnit</seealso>
    let DomainSpecificUnit = Prefixed_Name(qudt, "DomainSpecificUnit") |> PrefixedName

    /// <summary>
    ///   <para>qudt:FloatingPointEncodingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Floating Point Encoding</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/FloatingPointEncodingType">http://qudt.org/schema/qudt/FloatingPointEncodingType</seealso>
    let FloatingPointEncodingType =
        Prefixed_Name(qudt, "FloatingPointEncodingType") |> PrefixedName

    /// <summary>
    ///   <para>qudt:orderedType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>ordered type</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/orderedType">http://qudt.org/schema/qudt/orderedType</seealso>
    let orderedType = Prefixed_Name(qudt, "orderedType") |> PrefixedName
    /// <summary>
    ///   <para>qudt:pythonName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>python name</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/pythonName">http://qudt.org/schema/qudt/pythonName</seealso>
    let pythonName = Prefixed_Name(qudt, "pythonName") |> PrefixedName

    /// <summary>
    ///   <para>qudt:DateTimeStringEncodingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Date Time String Encoding Type</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/DateTimeStringEncodingType">http://qudt.org/schema/qudt/DateTimeStringEncodingType</seealso>
    let DateTimeStringEncodingType =
        Prefixed_Name(qudt, "DateTimeStringEncodingType") |> PrefixedName

    /// <summary>
    ///   <para>qudt:vectorMagnitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>vector magnitude</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/vectorMagnitude">http://qudt.org/schema/qudt/vectorMagnitude</seealso>
    let vectorMagnitude = Prefixed_Name(qudt, "vectorMagnitude") |> PrefixedName
    /// <summary>
    ///   <para>qudt:BaseUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A &lt;em&gt;Base Unit&lt;/em&gt; is a unit adopted by convention for a base quantity.</para>
    /// labels<para>Base Unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/BaseUnit">http://qudt.org/schema/qudt/BaseUnit</seealso>
    let BaseUnit = Prefixed_Name(qudt, "BaseUnit") |> PrefixedName
    /// <summary>
    ///   <para>qudt:BigEndian</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:EndianType</para>
    ///
    /// labels<para>Big Endian</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/BigEndian">http://qudt.org/schema/qudt/BigEndian</seealso>
    let BigEndian = Prefixed_Name(qudt, "BigEndian") |> PrefixedName
    /// <summary>
    ///   <para>qudt:ScaledUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Scaled unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/ScaledUnit">http://qudt.org/schema/qudt/ScaledUnit</seealso>
    let ScaledUnit = Prefixed_Name(qudt, "ScaledUnit") |> PrefixedName
    /// <summary>
    ///   <para>qudt:PartiallyOrdered</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:OrderedType</para>
    ///
    /// labels<para>Partially Ordered</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/PartiallyOrdered">http://qudt.org/schema/qudt/PartiallyOrdered</seealso>
    let PartiallyOrdered = Prefixed_Name(qudt, "PartiallyOrdered") |> PrefixedName
    /// <summary>
    ///   <para>qudt:order</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>order</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/order">http://qudt.org/schema/qudt/order</seealso>
    let order = Prefixed_Name(qudt, "order") |> PrefixedName
    /// <summary>
    ///   <para>qudt:Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Organization</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/Organization">http://qudt.org/schema/qudt/Organization</seealso>
    let Organization = Prefixed_Name(qudt, "Organization") |> PrefixedName
    /// <summary>
    ///   <para>qudt:QuantityKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A &lt;b&gt;Quantity Kind&lt;/b&gt; is any observable property that can be  measured and quantified numerically. Familiar examples include physical properties such as length, mass, time, force, energy, power, electric charge, etc. Less familiar examples include currency, interest rate, price to earning ratio, and information capacity.</para>
    /// labels<para>Quantity Kind</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/QuantityKind">http://qudt.org/schema/qudt/QuantityKind</seealso>
    let QuantityKind = Prefixed_Name(qudt, "QuantityKind") |> PrefixedName
    /// <summary>
    ///   <para>qudt:BinaryPrefixUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A &lt;em&gt;Binary Prefix Unit&lt;/em&gt; is a unit prefix for multiples of units in data processing, data transmission, and digital information, notably the bit and the byte, to indicate multiplication by a power of 2.</para>
    /// labels<para>Binary Prefix Unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/BinaryPrefixUnit">http://qudt.org/schema/qudt/BinaryPrefixUnit</seealso>
    let BinaryPrefixUnit = Prefixed_Name(qudt, "BinaryPrefixUnit") |> PrefixedName
    /// <summary>
    ///   <para>qudt:PrefixUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Prefix unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/PrefixUnit">http://qudt.org/schema/qudt/PrefixUnit</seealso>
    let PrefixUnit = Prefixed_Name(qudt, "PrefixUnit") |> PrefixedName
    /// <summary>
    ///   <para>qudt:LogarithmicUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Logarithmic units are abstract mathematical units that can be used to express any quantities (physical or mathematical) that are defined on a logarithmic scale, that is, as being proportional to the value of a logarithm function. Examples of logarithmic units include common units of information and entropy, such as the bit, and the byte, as well as units of relative signal strength magnitude such as the decibel.</para>
    /// labels<para>Logarithmic Unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/LogarithmicUnit">http://qudt.org/schema/qudt/LogarithmicUnit</seealso>
    let LogarithmicUnit = Prefixed_Name(qudt, "LogarithmicUnit") |> PrefixedName
    /// <summary>
    ///   <para>qudt:MathFunctionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Math Function Type</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/MathFunctionType">http://qudt.org/schema/qudt/MathFunctionType</seealso>
    let MathFunctionType = Prefixed_Name(qudt, "MathFunctionType") |> PrefixedName
    /// <summary>
    ///   <para>qudt:StandardsUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Standards unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/StandardsUnit">http://qudt.org/schema/qudt/StandardsUnit</seealso>
    let StandardsUnit = Prefixed_Name(qudt, "StandardsUnit") |> PrefixedName
    /// <summary>
    ///   <para>qudt:OctetEncoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:BooleanEncodingType</para>
    ///   <para>qudt:ByteEncodingType</para>
    ///
    /// labels<para>OCTET Encoding</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/OctetEncoding">http://qudt.org/schema/qudt/OctetEncoding</seealso>
    let OctetEncoding = Prefixed_Name(qudt, "OctetEncoding") |> PrefixedName
    /// <summary>
    ///   <para>qudt:Unordered</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:OrderedType</para>
    ///
    /// labels<para>Unordered</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/Unordered">http://qudt.org/schema/qudt/Unordered</seealso>
    let Unordered = Prefixed_Name(qudt, "Unordered") |> PrefixedName
    /// <summary>
    ///   <para>qudt:TotallyOrdered</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:OrderedType</para>
    ///
    /// labels<para>Totally Ordered</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/TotallyOrdered">http://qudt.org/schema/qudt/TotallyOrdered</seealso>
    let TotallyOrdered = Prefixed_Name(qudt, "TotallyOrdered") |> PrefixedName
    /// <summary>
    ///   <para>qudt:systemDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>system dimension</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/systemDimension">http://qudt.org/schema/qudt/systemDimension</seealso>
    let systemDimension = Prefixed_Name(qudt, "systemDimension") |> PrefixedName
    /// <summary>
    ///   <para>qudt:unitFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>unit for</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/unitFor">http://qudt.org/schema/qudt/unitFor</seealso>
    let unitFor = Prefixed_Name(qudt, "unitFor") |> PrefixedName
    /// <summary>
    ///   <para>qudt:valueQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>value for quantity</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/valueQuantity">http://qudt.org/schema/qudt/valueQuantity</seealso>
    let valueQuantity = Prefixed_Name(qudt, "valueQuantity") |> PrefixedName
    /// <summary>
    ///   <para>qudt:Enumeration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>&lt;p&gt;An enumeration is a set of literals from which a single value is selected. Each literal can have a tag as an integer within a standard encoding appropriate to the range of integer values. Consistency of enumeration types will allow them, and the enumerated values, to be referred to unambiguously either through symbolic name or encoding. Enumerated values are also controlled vocabularies and as such need to be standardized. Without this consistency enumeration literals can be stated differently and result in  data conflicts and misinterpretations.&lt;/p&gt;
    ///
    /// &lt;p&gt;The tags are a set of positive whole numbers, not necessarily contiguous and having no numerical significance, each corresponding to the associated literal identifier. An order attribute can also be given on the enumeration elements. An enumeration can itself be a member of an enumeration. This allows enumerations to be enumerated in a selection. Enumerations are also subclasses of &lt;em&gt;Scalar Datatype&lt;/em&gt;. This allows them to be used as the reference of a datatype specification.&lt;/p&gt;</para>
    /// labels<para>Enumeration</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/Enumeration">http://qudt.org/schema/qudt/Enumeration</seealso>
    let Enumeration = Prefixed_Name(qudt, "Enumeration") |> PrefixedName
    /// <summary>
    ///   <para>qudt:default</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>default</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/default">http://qudt.org/schema/qudt/default</seealso>
    let default_ = Prefixed_Name(qudt, "default") |> PrefixedName
    /// <summary>
    ///   <para>qudt:isUnitOfSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is unit of system</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/isUnitOfSystem">http://qudt.org/schema/qudt/isUnitOfSystem</seealso>
    let isUnitOfSystem = Prefixed_Name(qudt, "isUnitOfSystem") |> PrefixedName
    /// <summary>
    ///   <para>qudt:Unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A unit of measure, or unit, is a particular quantity value that has been chosen as a scale for measuring other quantities the same kind (more generally of equivalent dimension). For example, the meter is a quantity of length that has been rigorously defined and standardized by the BIPM (International Board of Weights and Measures). Any measurement of the length can be expressed as a number multiplied by the unit meter. More formally, the value of a physical quantity Q with respect to a unit (U) is expressed as the scalar multiple of a real number (n) and U, as  \\(Q = nU\\).</para>
    /// labels<para>Unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/Unit">http://qudt.org/schema/qudt/Unit</seealso>
    let Unit = Prefixed_Name(qudt, "Unit") |> PrefixedName
    /// <summary>
    ///   <para>qudt:dbpediaMatch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>dbpedia match</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/dbpediaMatch">http://qudt.org/schema/qudt/dbpediaMatch</seealso>
    let dbpediaMatch = Prefixed_Name(qudt, "dbpediaMatch") |> PrefixedName
    /// <summary>
    ///   <para>qudt:BinaryScaledUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A &lt;em&gt;Binary Scaled Unit&lt;/em&gt; specifies a binary multipler for scaling.</para>
    /// labels<para>Binary scaled unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/BinaryScaledUnit">http://qudt.org/schema/qudt/BinaryScaledUnit</seealso>
    let BinaryScaledUnit = Prefixed_Name(qudt, "BinaryScaledUnit") |> PrefixedName
    /// <summary>
    ///   <para>qudt:hasPrefixUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>prefix unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/hasPrefixUnit">http://qudt.org/schema/qudt/hasPrefixUnit</seealso>
    let hasPrefixUnit = Prefixed_Name(qudt, "hasPrefixUnit") |> PrefixedName
    /// <summary>
    ///   <para>qudt:Encoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Encoding</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/Encoding">http://qudt.org/schema/qudt/Encoding</seealso>
    let Encoding = Prefixed_Name(qudt, "Encoding") |> PrefixedName
    /// <summary>
    ///   <para>qudt:BooleanEncoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:BooleanEncodingType</para>
    ///
    /// labels<para>Boolean Encoding</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/BooleanEncoding">http://qudt.org/schema/qudt/BooleanEncoding</seealso>
    let BooleanEncoding = Prefixed_Name(qudt, "BooleanEncoding") |> PrefixedName
    /// <summary>
    ///   <para>qudt:PhysicalConstant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A physical constant is a physical quantity that is generally believed to be both universal in nature and constant in time. It can be contrasted with a mathematical constant, which is a fixed numerical value but does not directly involve any physical measurement. There are many physical constants in science, some of the most widely recognized being the speed of light in vacuum c, Newton's gravitational constant G, Planck's constant h, the electric permittivity of free space Îµ0, and the elementary charge e. Physical constants can take many dimensional forms, or may be dimensionless depending on the system of quantities and units used.</para>
    /// labels<para>Physical Constant</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/PhysicalConstant">http://qudt.org/schema/qudt/PhysicalConstant</seealso>
    let PhysicalConstant = Prefixed_Name(qudt, "PhysicalConstant") |> PrefixedName
    /// <summary>
    ///   <para>qudt:Quantifiable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>&lt;p&gt;&lt;em&gt;Quantifiable&lt;/em&gt; ascribes to some thing the capability of being measured, observed, or counted.&lt;/p&gt;</para>
    /// labels<para>Quantifiable</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/Quantifiable">http://qudt.org/schema/qudt/Quantifiable</seealso>
    let Quantifiable = Prefixed_Name(qudt, "Quantifiable") |> PrefixedName
    /// <summary>
    ///   <para>qudt:unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/unit">http://qudt.org/schema/qudt/unit</seealso>
    let unit = Prefixed_Name(qudt, "unit") |> PrefixedName
    /// <summary>
    ///   <para>qudt:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>value</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/value">http://qudt.org/schema/qudt/value</seealso>
    let value = Prefixed_Name(qudt, "value") |> PrefixedName
    /// <summary>
    ///   <para>qudt:standardUncertainty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>standard uncertainty</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/standardUncertainty">http://qudt.org/schema/qudt/standardUncertainty</seealso>
    let standardUncertainty = Prefixed_Name(qudt, "standardUncertainty") |> PrefixedName

    /// <summary>
    ///   <para>qudt:relativeStandardUncertainty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>relative standard uncertainty</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/relativeStandardUncertainty">http://qudt.org/schema/qudt/relativeStandardUncertainty</seealso>
    let relativeStandardUncertainty =
        Prefixed_Name(qudt, "relativeStandardUncertainty") |> PrefixedName

    /// <summary>
    ///   <para>qudt:coherentUnitSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>coherent unit system</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/coherentUnitSystem">http://qudt.org/schema/qudt/coherentUnitSystem</seealso>
    let coherentUnitSystem = Prefixed_Name(qudt, "coherentUnitSystem") |> PrefixedName
    /// <summary>
    ///   <para>qudt:element</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>element</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/element">http://qudt.org/schema/qudt/element</seealso>
    let element = Prefixed_Name(qudt, "element") |> PrefixedName
    /// <summary>
    ///   <para>qudt:EnumerationScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Enumeration scale</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/EnumerationScale">http://qudt.org/schema/qudt/EnumerationScale</seealso>
    let EnumerationScale = Prefixed_Name(qudt, "EnumerationScale") |> PrefixedName
    /// <summary>
    ///   <para>qudt:Figure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Figure</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/Figure">http://qudt.org/schema/qudt/Figure</seealso>
    let Figure = Prefixed_Name(qudt, "Figure") |> PrefixedName
    /// <summary>
    ///   <para>qudt:figureCaption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>figure caption</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/figureCaption">http://qudt.org/schema/qudt/figureCaption</seealso>
    let figureCaption = Prefixed_Name(qudt, "figureCaption") |> PrefixedName
    /// <summary>
    ///   <para>qudt:image</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>image</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/image">http://qudt.org/schema/qudt/image</seealso>
    let image = Prefixed_Name(qudt, "image") |> PrefixedName
    /// <summary>
    ///   <para>qudt:width</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>width</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/width">http://qudt.org/schema/qudt/width</seealso>
    let width = Prefixed_Name(qudt, "width") |> PrefixedName

    /// <summary>
    ///   <para>qudt:IEEE754_1985RealEncoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:FloatingPointEncodingType</para>
    ///
    /// labels<para>IEEE 754 1985 Real Encoding</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/IEEE754_1985RealEncoding">http://qudt.org/schema/qudt/IEEE754_1985RealEncoding</seealso>
    let IEEE754_1985RealEncoding =
        Prefixed_Name(qudt, "IEEE754_1985RealEncoding") |> PrefixedName

    /// <summary>
    ///   <para>qudt:ImperialUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>British/Imperial units where these are not aligned to international customary units.</para>
    /// labels<para>Imperial Unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/ImperialUnit">http://qudt.org/schema/qudt/ImperialUnit</seealso>
    let ImperialUnit = Prefixed_Name(qudt, "ImperialUnit") |> PrefixedName

    /// <summary>
    ///   <para>qudt:International-CustomaryUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Customary units defined in terms of exact multiplers with SI metric units, as specified in the 1959 International Yard and Pound agreement.</para>
    /// labels<para>Customary Unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/International-CustomaryUnit">http://qudt.org/schema/qudt/International-CustomaryUnit</seealso>
    let International_CustomaryUnit =
        Prefixed_Name(qudt, "International-CustomaryUnit") |> PrefixedName

    /// <summary>
    ///   <para>qudt:LittleEndian</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:EndianType</para>
    ///
    /// labels<para>Little Endian</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/LittleEndian">http://qudt.org/schema/qudt/LittleEndian</seealso>
    let LittleEndian = Prefixed_Name(qudt, "LittleEndian") |> PrefixedName
    /// <summary>
    ///   <para>qudt:MKS-Unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The MKS system of units is a physical system of units that expresses any given measurement using fundamental units of the metre, kilogram, and/or second (MKS).</para>
    /// labels<para>MKS-Unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/MKS-Unit">http://qudt.org/schema/qudt/MKS-Unit</seealso>
    let MKS_Unit = Prefixed_Name(qudt, "MKS-Unit") |> PrefixedName
    /// <summary>
    ///   <para>qudt:NIST_SP811_Comment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>NIST SP~811 Comment</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/NIST_SP811_Comment">http://qudt.org/schema/qudt/NIST_SP811_Comment</seealso>
    let NIST_SP811_Comment = Prefixed_Name(qudt, "NIST_SP811_Comment") |> PrefixedName

    /// <summary>
    ///   <para>qudt:applicablePlanckUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>applicable Planck unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/applicablePlanckUnit">http://qudt.org/schema/qudt/applicablePlanckUnit</seealso>
    let applicablePlanckUnit =
        Prefixed_Name(qudt, "applicablePlanckUnit") |> PrefixedName

    /// <summary>
    ///   <para>qudt:belongsToSystemOfQuantities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>belongs to system of quantities</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/belongsToSystemOfQuantities">http://qudt.org/schema/qudt/belongsToSystemOfQuantities</seealso>
    let belongsToSystemOfQuantities =
        Prefixed_Name(qudt, "belongsToSystemOfQuantities") |> PrefixedName

    /// <summary>
    ///   <para>qudt:categorizedAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>categorized as</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/categorizedAs">http://qudt.org/schema/qudt/categorizedAs</seealso>
    let categorizedAs = Prefixed_Name(qudt, "categorizedAs") |> PrefixedName
    /// <summary>
    ///   <para>qudt:code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>code</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/code">http://qudt.org/schema/qudt/code</seealso>
    let code = Prefixed_Name(qudt, "code") |> PrefixedName

    /// <summary>
    ///   <para>qudt:conversionCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>conversion coefficient</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/conversionCoefficient">http://qudt.org/schema/qudt/conversionCoefficient</seealso>
    let conversionCoefficient =
        Prefixed_Name(qudt, "conversionCoefficient") |> PrefixedName

    /// <summary>
    ///   <para>qudt:currencyExponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>currency exponent</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/currencyExponent">http://qudt.org/schema/qudt/currencyExponent</seealso>
    let currencyExponent = Prefixed_Name(qudt, "currencyExponent") |> PrefixedName
    /// <summary>
    ///   <para>qudt:definitionReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>definition reference</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/definitionReference">http://qudt.org/schema/qudt/definitionReference</seealso>
    let definitionReference = Prefixed_Name(qudt, "definitionReference") |> PrefixedName

    /// <summary>
    ///   <para>qudt:denominatorDimensionVector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>denominator dimension vector</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/denominatorDimensionVector">http://qudt.org/schema/qudt/denominatorDimensionVector</seealso>
    let denominatorDimensionVector =
        Prefixed_Name(qudt, "denominatorDimensionVector") |> PrefixedName

    /// <summary>
    ///   <para>qudt:derivedQuantityKindOfSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>derived quantity kind of system</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/derivedQuantityKindOfSystem">http://qudt.org/schema/qudt/derivedQuantityKindOfSystem</seealso>
    let derivedQuantityKindOfSystem =
        Prefixed_Name(qudt, "derivedQuantityKindOfSystem") |> PrefixedName

    /// <summary>
    ///   <para>qudt:systemDerivedQuantityKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>system derived quantity kind</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/systemDerivedQuantityKind">http://qudt.org/schema/qudt/systemDerivedQuantityKind</seealso>
    let systemDerivedQuantityKind =
        Prefixed_Name(qudt, "systemDerivedQuantityKind") |> PrefixedName

    /// <summary>
    ///   <para>qudt:dimensionExponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>dimension exponent</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/dimensionExponent">http://qudt.org/schema/qudt/dimensionExponent</seealso>
    let dimensionExponent = Prefixed_Name(qudt, "dimensionExponent") |> PrefixedName
    /// <summary>
    ///   <para>qudt:dimensionInverse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>dimension inverse</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/dimensionInverse">http://qudt.org/schema/qudt/dimensionInverse</seealso>
    let dimensionInverse = Prefixed_Name(qudt, "dimensionInverse") |> PrefixedName
    /// <summary>
    ///   <para>qudt:elementKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>element kind</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/elementKind">http://qudt.org/schema/qudt/elementKind</seealso>
    let elementKind = Prefixed_Name(qudt, "elementKind") |> PrefixedName
    /// <summary>
    ///   <para>qudt:exactMatch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>exact match</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/exactMatch">http://qudt.org/schema/qudt/exactMatch</seealso>
    let exactMatch = Prefixed_Name(qudt, "exactMatch") |> PrefixedName
    /// <summary>
    ///   <para>qudt:fieldCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>field code</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/fieldCode">http://qudt.org/schema/qudt/fieldCode</seealso>
    let fieldCode = Prefixed_Name(qudt, "fieldCode") |> PrefixedName
    /// <summary>
    ///   <para>qudt:figure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>figure</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/figure">http://qudt.org/schema/qudt/figure</seealso>
    let figure = Prefixed_Name(qudt, "figure") |> PrefixedName
    /// <summary>
    ///   <para>qudt:BitEncodingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Bit Encoding</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/BitEncodingType">http://qudt.org/schema/qudt/BitEncodingType</seealso>
    let BitEncodingType = Prefixed_Name(qudt, "BitEncodingType") |> PrefixedName
    /// <summary>
    ///   <para>qudt:BooleanEncodingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Boolean encoding type</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/BooleanEncodingType">http://qudt.org/schema/qudt/BooleanEncodingType</seealso>
    let BooleanEncodingType = Prefixed_Name(qudt, "BooleanEncodingType") |> PrefixedName
    /// <summary>
    ///   <para>qudt:CGS-Unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>&lt;p&gt;The C.G.S. System of Units defined four units of measure as a basic set from which all otherC.G.S units are derived. These are: &lt;/p&gt;
    /// &lt;ol&gt;
    /// &lt;li&gt;length: cm = centimetre; &lt;/li&gt;
    /// &lt;li&gt;mass: g = gram;&lt;/li&gt;
    /// &lt;li&gt; time: s = second; &lt;/li&gt;
    /// &lt;li&gt; luminous intensity: cd = candela, originally new candle.&lt;/li&gt;
    /// &lt;/ol&gt;</para>
    /// labels<para>CGS Unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/CGS-Unit">http://qudt.org/schema/qudt/CGS-Unit</seealso>
    let CGS_Unit = Prefixed_Name(qudt, "CGS-Unit") |> PrefixedName
    /// <summary>
    ///   <para>qudt:ByteEncodingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Byte Encoding</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/ByteEncodingType">http://qudt.org/schema/qudt/ByteEncodingType</seealso>
    let ByteEncodingType = Prefixed_Name(qudt, "ByteEncodingType") |> PrefixedName
    /// <summary>
    ///   <para>qudt:Quantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>&lt;p class="lm-para"&gt;A &lt;b&gt;quantity&lt;/b&gt; is the measurement of an observable property of a particular object, event, or physical system. A quantity is always associated with the context of measurement (i.e. the thing measured, the measured value, the accuracy of measurement, etc.) whereas the underlying &lt;b&gt;quantity kind&lt;/b&gt; is independent of any particular measurement. Thus, length is a quantity kind while the height of a rocket is a specific quantity of length; its magnitude that may be expressed in meters, feet, inches, etc. Examples of physical quantities include physical constants, such as the speed of light in a vacuum, Planck's constant, the electric permittivity of free space, and the fine structure constant. &lt;/p&gt;
    ///
    /// &lt;p class="lm-para"&gt;In other words, quantities are quantifiable aspects of the world, such as the duration of a movie, the distance between two points, velocity of a car, the pressure of the atmosphere, and a person's weight; and units are used to describe their numerical measure.
    ///
    /// &lt;p class="lm-para"&gt;Many &lt;b&gt;quantity kinds&lt;/b&gt; are related to each other by various physical laws, and as a result, the associated units of some quantity kinds can be expressed as products (or ratios) of powers of other quantity kinds (e.g., momentum is mass times velocity and velocity is defined as distance divided by time). In this way, some quantities can be calculated from other measured quantities using their associations to the quantity kinds in these expressions. These quantity kind relationships are also discussed in dimensional analysis. Those that cannot be so expressed can be regarded as "fundamental" in this sense.&lt;/p&gt;
    /// &lt;p class="lm-para"&gt;A quantity is distinguished from a "quantity kind" in that the former carries a value and the latter is a type specifier.&lt;/p&gt;</para>
    /// labels<para>Quantity</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/Quantity">http://qudt.org/schema/qudt/Quantity</seealso>
    let Quantity = Prefixed_Name(qudt, "Quantity") |> PrefixedName
    /// <summary>
    ///   <para>qudt:dataType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>datatype</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/dataType">http://qudt.org/schema/qudt/dataType</seealso>
    let dataType = Prefixed_Name(qudt, "dataType") |> PrefixedName
    /// <summary>
    ///   <para>qudt:citation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>citation</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/citation">http://qudt.org/schema/qudt/citation</seealso>
    let citation = Prefixed_Name(qudt, "citation") |> PrefixedName
    /// <summary>
    ///   <para>qudt:literal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>literal</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/literal">http://qudt.org/schema/qudt/literal</seealso>
    let literal = Prefixed_Name(qudt, "literal") |> PrefixedName
    /// <summary>
    ///   <para>qudt:NonSI-Unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>&lt;p class="lm-para"&gt;A parent class for all units that are not SI Units&lt;/p&gt;</para>
    /// labels<para>Non-SI Unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/NonSI-Unit">http://qudt.org/schema/qudt/NonSI-Unit</seealso>
    let NonSI_Unit = Prefixed_Name(qudt, "NonSI-Unit") |> PrefixedName
    /// <summary>
    ///   <para>qudt:CT_UNCOUNTABLE</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:CardinalityType</para>
    ///
    /// labels<para>Uncountable Cardinality Type</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/CT_UNCOUNTABLE">http://qudt.org/schema/qudt/CT_UNCOUNTABLE</seealso>
    let CT_UNCOUNTABLE = Prefixed_Name(qudt, "CT_UNCOUNTABLE") |> PrefixedName
    /// <summary>
    ///   <para>qudt:EnumeratedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Enumerated Value</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/EnumeratedValue">http://qudt.org/schema/qudt/EnumeratedValue</seealso>
    let EnumeratedValue = Prefixed_Name(qudt, "EnumeratedValue") |> PrefixedName
    /// <summary>
    ///   <para>qudt:CharEncodingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Char Encoding Type</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/CharEncodingType">http://qudt.org/schema/qudt/CharEncodingType</seealso>
    let CharEncodingType = Prefixed_Name(qudt, "CharEncodingType") |> PrefixedName
    /// <summary>
    ///   <para>qudt:floatPercentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>float percentage</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/floatPercentage">http://qudt.org/schema/qudt/floatPercentage</seealso>
    let floatPercentage = Prefixed_Name(qudt, "floatPercentage") |> PrefixedName

    /// <summary>
    ///   <para>qudt:CT_COUNTABLY-INFINITE</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:CardinalityType</para>
    ///
    /// labels<para>Countably Infinite Cardinality Type</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/CT_COUNTABLY-INFINITE">http://qudt.org/schema/qudt/CT_COUNTABLY-INFINITE</seealso>
    let CT_COUNTABLY_INFINITE =
        Prefixed_Name(qudt, "CT_COUNTABLY-INFINITE") |> PrefixedName

    /// <summary>
    ///   <para>qudt:valueUnion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>value union</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/valueUnion">http://qudt.org/schema/qudt/valueUnion</seealso>
    let valueUnion = Prefixed_Name(qudt, "valueUnion") |> PrefixedName
    /// <summary>
    ///   <para>qudt:hasQuantityKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has quantity kind</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/hasQuantityKind">http://qudt.org/schema/qudt/hasQuantityKind</seealso>
    let hasQuantityKind = Prefixed_Name(qudt, "hasQuantityKind") |> PrefixedName
    /// <summary>
    ///   <para>qudt:mathMLdefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>mathML definition</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/mathMLdefinition">http://qudt.org/schema/qudt/mathMLdefinition</seealso>
    let mathMLdefinition = Prefixed_Name(qudt, "mathMLdefinition") |> PrefixedName
    /// <summary>
    ///   <para>qudt:latexDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>latex definition</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/latexDefinition">http://qudt.org/schema/qudt/latexDefinition</seealso>
    let latexDefinition = Prefixed_Name(qudt, "latexDefinition") |> PrefixedName

    /// <summary>
    ///   <para>qudt:baseUSCustomaryUnitDimensions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>base US Customary unit dimensions</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/baseUSCustomaryUnitDimensions">http://qudt.org/schema/qudt/baseUSCustomaryUnitDimensions</seealso>
    let baseUSCustomaryUnitDimensions =
        Prefixed_Name(qudt, "baseUSCustomaryUnitDimensions") |> PrefixedName

    /// <summary>
    ///   <para>qudt:generalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>generalization</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/generalization">http://qudt.org/schema/qudt/generalization</seealso>
    let generalization = Prefixed_Name(qudt, "generalization") |> PrefixedName
    /// <summary>
    ///   <para>qudt:isQuantityKindOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is quantity kind of</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/isQuantityKindOf">http://qudt.org/schema/qudt/isQuantityKindOf</seealso>
    let isQuantityKindOf = Prefixed_Name(qudt, "isQuantityKindOf") |> PrefixedName
    /// <summary>
    ///   <para>qudt:hasDimensionVector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has dimension vector</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/hasDimensionVector">http://qudt.org/schema/qudt/hasDimensionVector</seealso>
    let hasDimensionVector = Prefixed_Name(qudt, "hasDimensionVector") |> PrefixedName


    let QuantityKindDimensionVector =
        Prefixed_Name(qudt, "QuantityKindDimensionVector") |> PrefixedName

    /// <summary>
    ///   <para>qudt:applicableUSCustomaryUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>applicable US Customary unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/applicableUSCustomaryUnit">http://qudt.org/schema/qudt/applicableUSCustomaryUnit</seealso>
    let applicableUSCustomaryUnit =
        Prefixed_Name(qudt, "applicableUSCustomaryUnit") |> PrefixedName

    /// <summary>
    ///   <para>qudt:baseCGSUnitDimensions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>base CGS unit dimensions</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/baseCGSUnitDimensions">http://qudt.org/schema/qudt/baseCGSUnitDimensions</seealso>
    let baseCGSUnitDimensions =
        Prefixed_Name(qudt, "baseCGSUnitDimensions") |> PrefixedName

    /// <summary>
    ///   <para>qudt:baseISOUnitDimensions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>base ISO unit dimensions</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/baseISOUnitDimensions">http://qudt.org/schema/qudt/baseISOUnitDimensions</seealso>
    let baseISOUnitDimensions =
        Prefixed_Name(qudt, "baseISOUnitDimensions") |> PrefixedName

    /// <summary>
    ///   <para>qudt:qkdvDenominator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>denominator dimension vector</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/qkdvDenominator">http://qudt.org/schema/qudt/qkdvDenominator</seealso>
    let qkdvDenominator = Prefixed_Name(qudt, "qkdvDenominator") |> PrefixedName
    /// <summary>
    ///   <para>qudt:CT_FINITE</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:CardinalityType</para>
    ///
    /// labels<para>Finite Cardinality Type</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/CT_FINITE">http://qudt.org/schema/qudt/CT_FINITE</seealso>
    let CT_FINITE = Prefixed_Name(qudt, "CT_FINITE") |> PrefixedName
    /// <summary>
    ///   <para>qudt:dataEncoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>data encoding</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/dataEncoding">http://qudt.org/schema/qudt/dataEncoding</seealso>
    let dataEncoding = Prefixed_Name(qudt, "dataEncoding") |> PrefixedName
    /// <summary>
    ///   <para>qudt:baseUnitDimensions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>base unit dimensions</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/baseUnitDimensions">http://qudt.org/schema/qudt/baseUnitDimensions</seealso>
    let baseUnitDimensions = Prefixed_Name(qudt, "baseUnitDimensions") |> PrefixedName
    /// <summary>
    ///   <para>qudt:quantityValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>quantity value</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/quantityValue">http://qudt.org/schema/qudt/quantityValue</seealso>
    let quantityValue = Prefixed_Name(qudt, "quantityValue") |> PrefixedName

    /// <summary>
    ///   <para>qudt:SystemOfQuantityKinds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A system of quantity kinds is a set of one or more quantity kinds together with a set of zero or more algebraic equations that define relationships between quantity kinds in the set. In the physical sciences, the equations relating quantity kinds are typically physical laws and definitional relations, and constants of proportionality. Examples include Newtonâ€™s First Law of Motion, Coulombâ€™s Law, and the definition of velocity as the instantaneous change in position.  In almost all cases, the system identifies a subset of base quantity kinds. The base set is chosen so that all other quantity kinds of interest can be derived from the base quantity kinds and the algebraic equations. If the unit system is explicitly associated with a quantity kind system, then the unit system must define at least one unit for each quantity kind.  From a scientific point of view, the division of quantities into base quantities and derived quantities is a matter of convention.</para>
    /// labels<para>System of Quantity Kinds</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/SystemOfQuantityKinds">http://qudt.org/schema/qudt/SystemOfQuantityKinds</seealso>
    let SystemOfQuantityKinds =
        Prefixed_Name(qudt, "SystemOfQuantityKinds") |> PrefixedName

    /// <summary>
    ///   <para>qudt:applicableImperialUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>applicable Imperial unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/applicableImperialUnit">http://qudt.org/schema/qudt/applicableImperialUnit</seealso>
    let applicableImperialUnit =
        Prefixed_Name(qudt, "applicableImperialUnit") |> PrefixedName

    /// <summary>
    ///   <para>qudt:CharEncoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:BooleanEncodingType</para>
    ///   <para>qudt:CharEncodingType</para>
    ///
    /// labels<para>Char Encoding</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/CharEncoding">http://qudt.org/schema/qudt/CharEncoding</seealso>
    let CharEncoding = Prefixed_Name(qudt, "CharEncoding") |> PrefixedName
    /// <summary>
    ///   <para>qudt:latexSymbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>latex symbol</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/latexSymbol">http://qudt.org/schema/qudt/latexSymbol</seealso>
    let latexSymbol = Prefixed_Name(qudt, "latexSymbol") |> PrefixedName
    /// <summary>
    ///   <para>qudt:applicableUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>applicable unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/applicableUnit">http://qudt.org/schema/qudt/applicableUnit</seealso>
    let applicableUnit = Prefixed_Name(qudt, "applicableUnit") |> PrefixedName

    /// <summary>
    ///   <para>qudt:dimensionVectorForSI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>dimension vector for SI</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/dimensionVectorForSI">http://qudt.org/schema/qudt/dimensionVectorForSI</seealso>
    let dimensionVectorForSI =
        Prefixed_Name(qudt, "dimensionVectorForSI") |> PrefixedName

    /// <summary>
    ///   <para>qudt:expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>expression</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/expression">http://qudt.org/schema/qudt/expression</seealso>
    let expression = Prefixed_Name(qudt, "expression") |> PrefixedName
    /// <summary>
    ///   <para>qudt:qkdvNumerator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>numerator dimension vector</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/qkdvNumerator">http://qudt.org/schema/qudt/qkdvNumerator</seealso>
    let qkdvNumerator = Prefixed_Name(qudt, "qkdvNumerator") |> PrefixedName

    /// <summary>
    ///   <para>qudt:baseImperialUnitDimensions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>base Imperial unit dimensions</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/baseImperialUnitDimensions">http://qudt.org/schema/qudt/baseImperialUnitDimensions</seealso>
    let baseImperialUnitDimensions =
        Prefixed_Name(qudt, "baseImperialUnitDimensions") |> PrefixedName

    /// <summary>
    ///   <para>qudt:dimensionExponentForAmountOfSubstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>dimension exponent for amount of substance</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/dimensionExponentForAmountOfSubstance">http://qudt.org/schema/qudt/dimensionExponentForAmountOfSubstance</seealso>
    let dimensionExponentForAmountOfSubstance =
        Prefixed_Name(qudt, "dimensionExponentForAmountOfSubstance") |> PrefixedName

    /// <summary>
    ///   <para>qudt:dimensionExponentForLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>dimension exponent for length</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/dimensionExponentForLength">http://qudt.org/schema/qudt/dimensionExponentForLength</seealso>
    let dimensionExponentForLength =
        Prefixed_Name(qudt, "dimensionExponentForLength") |> PrefixedName

    /// <summary>
    ///   <para>qudt:dimensionExponentForElectricCurrent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>dimension exponent for electric current</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/dimensionExponentForElectricCurrent">http://qudt.org/schema/qudt/dimensionExponentForElectricCurrent</seealso>
    let dimensionExponentForElectricCurrent =
        Prefixed_Name(qudt, "dimensionExponentForElectricCurrent") |> PrefixedName

    /// <summary>
    ///   <para>qudt:dimensionExponentForThermodynamicTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>dimension exponent for thermodynamic temperature</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/dimensionExponentForThermodynamicTemperature">http://qudt.org/schema/qudt/dimensionExponentForThermodynamicTemperature</seealso>
    let dimensionExponentForThermodynamicTemperature =
        Prefixed_Name(qudt, "dimensionExponentForThermodynamicTemperature") |> PrefixedName

    /// <summary>
    ///   <para>qudt:dimensionlessExponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>dimensionless exponent</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/dimensionlessExponent">http://qudt.org/schema/qudt/dimensionlessExponent</seealso>
    let dimensionlessExponent =
        Prefixed_Name(qudt, "dimensionlessExponent") |> PrefixedName

    /// <summary>
    ///   <para>qudt:QuantityKindDimensionVector_CGS-EMU</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A &lt;em&gt;CGS EMU Dimension Vector&lt;/em&gt; is used to specify the dimensions for EMU C.G.S. quantity kind.</para>
    /// labels<para>CGS EMU Dimension vector</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/QuantityKindDimensionVector_CGS-EMU">http://qudt.org/schema/qudt/QuantityKindDimensionVector_CGS-EMU</seealso>
    let QuantityKindDimensionVector_CGS_EMU =
        Prefixed_Name(qudt, "QuantityKindDimensionVector_CGS-EMU") |> PrefixedName

    /// <summary>
    ///   <para>qudt:QuantityKindDimensionVector_CGS-ESU</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A &lt;em&gt;CGS ESU Dimension Vector&lt;/em&gt; is used to specify the dimensions for ESU C.G.S. quantity kind.</para>
    /// labels<para>CGS ESU Dimension vector</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/QuantityKindDimensionVector_CGS-ESU">http://qudt.org/schema/qudt/QuantityKindDimensionVector_CGS-ESU</seealso>
    let QuantityKindDimensionVector_CGS_ESU =
        Prefixed_Name(qudt, "QuantityKindDimensionVector_CGS-ESU") |> PrefixedName

    /// <summary>
    ///   <para>qudt:QuantityKindDimensionVector_CGS-LH</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A &lt;em&gt;CGS LH Dimension Vector&lt;/em&gt; is used to specify the dimensions for Lorentz-Heaviside C.G.S. quantity kind.</para>
    /// labels<para>CGS LH Dimension vector</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/QuantityKindDimensionVector_CGS-LH">http://qudt.org/schema/qudt/QuantityKindDimensionVector_CGS-LH</seealso>
    let QuantityKindDimensionVector_CGS_LH =
        Prefixed_Name(qudt, "QuantityKindDimensionVector_CGS-LH") |> PrefixedName

    /// <summary>
    ///   <para>qudt:QuantityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Quantity type</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/QuantityType">http://qudt.org/schema/qudt/QuantityType</seealso>
    let QuantityType = Prefixed_Name(qudt, "QuantityType") |> PrefixedName
    /// <summary>
    ///   <para>qudt:example</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>The 'qudt:example' property is used to annotate an instance of a class with a reference to a concept that is an example. The type of this property is 'rdf:Property'. This allows both scalar and object ranges.</para>
    /// labels<para>example</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/example">http://qudt.org/schema/qudt/example</seealso>
    let example = Prefixed_Name(qudt, "example") |> PrefixedName
    /// <summary>
    ///   <para>qudt:ruleType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>rule type</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/ruleType">http://qudt.org/schema/qudt/ruleType</seealso>
    let ruleType = Prefixed_Name(qudt, "ruleType") |> PrefixedName
    /// <summary>
    ///   <para>qudt:SI-Unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The International System of Units (SI) defines seven units of measure as a basic set from which all other SI units are derived. These SI base units and their physical quantities are: metre for length kilogram for mass second for time ampere for electric current kelvin for temperature candela for luminous intensity mole for the amount of substance. The SI base quantities form a set of mutually independent dimensions as required by dimensional analysis commonly employed in science and technology.</para>
    /// labels<para>SI Unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/SI-Unit">http://qudt.org/schema/qudt/SI-Unit</seealso>
    let SI_Unit = Prefixed_Name(qudt, "SI-Unit") |> PrefixedName
    /// <summary>
    ///   <para>qudt:SignednessType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Signedness type</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/SignednessType">http://qudt.org/schema/qudt/SignednessType</seealso>
    let SignednessType = Prefixed_Name(qudt, "SignednessType") |> PrefixedName
    /// <summary>
    ///   <para>qudt:SOU_CGS</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:SystemOfUnits</para>
    ///
    /// labels<para>CGS System of Units</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/SOU_CGS">http://qudt.org/schema/qudt/SOU_CGS</seealso>
    let SOU_CGS = Prefixed_Name(qudt, "SOU_CGS") |> PrefixedName
    /// <summary>
    ///   <para>qudt:SystemOfUnits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A system of units is a set of units which are chosen as the reference scales for some set of quantity kinds together with the definitions of each unit. Units may be defined by experimental observation or by proportion to another unit not included in the system. If the unit system is explicitly associated with a quantity kind system, then the unit system must define at least one unit for each quantity kind.</para>
    /// labels<para>System of Units</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/SystemOfUnits">http://qudt.org/schema/qudt/SystemOfUnits</seealso>
    let SystemOfUnits = Prefixed_Name(qudt, "SystemOfUnits") |> PrefixedName
    /// <summary>
    ///   <para>qudt:SOU_IMPERIAL</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:SystemOfUnits</para>
    ///
    /// labels<para>Imperial System of Units</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/SOU_IMPERIAL">http://qudt.org/schema/qudt/SOU_IMPERIAL</seealso>
    let SOU_IMPERIAL = Prefixed_Name(qudt, "SOU_IMPERIAL") |> PrefixedName
    /// <summary>
    ///   <para>qudt:SOU_SI</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:SystemOfUnits</para>
    ///
    /// labels<para>SI International System of Units</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/SOU_SI">http://qudt.org/schema/qudt/SOU_SI</seealso>
    let SOU_SI = Prefixed_Name(qudt, "SOU_SI") |> PrefixedName
    /// <summary>
    ///   <para>qudt:SOU_USCS</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:SystemOfUnits</para>
    ///
    /// labels<para>US Customary System of Units</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/SOU_USCS">http://qudt.org/schema/qudt/SOU_USCS</seealso>
    let SOU_USCS = Prefixed_Name(qudt, "SOU_USCS") |> PrefixedName
    /// <summary>
    ///   <para>qudt:ScalarDatatype</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Scalar Datatype</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/ScalarDatatype">http://qudt.org/schema/qudt/ScalarDatatype</seealso>
    let ScalarDatatype = Prefixed_Name(qudt, "ScalarDatatype") |> PrefixedName
    /// <summary>
    ///   <para>qudt:rdfsDatatype</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>rdfs datatype</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/rdfsDatatype">http://qudt.org/schema/qudt/rdfsDatatype</seealso>
    let rdfsDatatype = Prefixed_Name(qudt, "rdfsDatatype") |> PrefixedName
    /// <summary>
    ///   <para>qudt:length</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>length</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/length">http://qudt.org/schema/qudt/length</seealso>
    let length = Prefixed_Name(qudt, "length") |> PrefixedName
    /// <summary>
    ///   <para>qudt:minInclusive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>min inclusive</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/minInclusive">http://qudt.org/schema/qudt/minInclusive</seealso>
    let minInclusive = Prefixed_Name(qudt, "minInclusive") |> PrefixedName
    /// <summary>
    ///   <para>qudt:minExclusive</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>min exclusive</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/minExclusive">http://qudt.org/schema/qudt/minExclusive</seealso>
    let minExclusive = Prefixed_Name(qudt, "minExclusive") |> PrefixedName
    /// <summary>
    ///   <para>qudt:maxExclusive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>max exclusive</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/maxExclusive">http://qudt.org/schema/qudt/maxExclusive</seealso>
    let maxExclusive = Prefixed_Name(qudt, "maxExclusive") |> PrefixedName
    /// <summary>
    ///   <para>qudt:permissibleMaths</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>permissible maths</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/permissibleMaths">http://qudt.org/schema/qudt/permissibleMaths</seealso>
    let permissibleMaths = Prefixed_Name(qudt, "permissibleMaths") |> PrefixedName
    /// <summary>
    ///   <para>qudt:MathsFunctionType</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/MathsFunctionType">http://qudt.org/schema/qudt/MathsFunctionType</seealso>
    let MathsFunctionType = Prefixed_Name(qudt, "MathsFunctionType") |> PrefixedName
    /// <summary>
    ///   <para>qudt:scaleType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>scale type</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/scaleType">http://qudt.org/schema/qudt/scaleType</seealso>
    let scaleType = Prefixed_Name(qudt, "scaleType") |> PrefixedName
    /// <summary>
    ///   <para>qudt:dataStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>data structure</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/dataStructure">http://qudt.org/schema/qudt/dataStructure</seealso>
    let dataStructure = Prefixed_Name(qudt, "dataStructure") |> PrefixedName
    /// <summary>
    ///   <para>qudt:ScaleType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Scale type</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/ScaleType">http://qudt.org/schema/qudt/ScaleType</seealso>
    let ScaleType = Prefixed_Name(qudt, "ScaleType") |> PrefixedName
    /// <summary>
    ///   <para>qudt:isScalingOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>is scaling of</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/isScalingOf">http://qudt.org/schema/qudt/isScalingOf</seealso>
    let isScalingOf = Prefixed_Name(qudt, "isScalingOf") |> PrefixedName

    /// <summary>
    ///   <para>qudt:ShortUnsignedIntegerEncoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:IntegerEncodingType</para>
    ///   <para>qudt:BooleanEncodingType</para>
    ///
    /// labels<para>Short Unsigned Integer Encoding</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/ShortUnsignedIntegerEncoding">http://qudt.org/schema/qudt/ShortUnsignedIntegerEncoding</seealso>
    let ShortUnsignedIntegerEncoding =
        Prefixed_Name(qudt, "ShortUnsignedIntegerEncoding") |> PrefixedName

    /// <summary>
    ///   <para>qudt:SignedIntegerEncoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:IntegerEncodingType</para>
    ///
    /// labels<para>Signed Integer Encoding</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/SignedIntegerEncoding">http://qudt.org/schema/qudt/SignedIntegerEncoding</seealso>
    let SignedIntegerEncoding =
        Prefixed_Name(qudt, "SignedIntegerEncoding") |> PrefixedName

    /// <summary>
    ///   <para>qudt:SinglePrecisionRealEncoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:FloatingPointEncodingType</para>
    ///
    /// labels<para>Single Precision Real Encoding</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/SinglePrecisionRealEncoding">http://qudt.org/schema/qudt/SinglePrecisionRealEncoding</seealso>
    let SinglePrecisionRealEncoding =
        Prefixed_Name(qudt, "SinglePrecisionRealEncoding") |> PrefixedName

    /// <summary>
    ///   <para>qudt:Statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Statement</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/Statement">http://qudt.org/schema/qudt/Statement</seealso>
    let Statement = Prefixed_Name(qudt, "Statement") |> PrefixedName
    /// <summary>
    ///   <para>qudt:StructuredDatatype</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Structured Data Type</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/StructuredDatatype">http://qudt.org/schema/qudt/StructuredDatatype</seealso>
    let StructuredDatatype = Prefixed_Name(qudt, "StructuredDatatype") |> PrefixedName
    /// <summary>
    ///   <para>qudt:elementType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>element type</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/elementType">http://qudt.org/schema/qudt/elementType</seealso>
    let elementType = Prefixed_Name(qudt, "elementType") |> PrefixedName
    /// <summary>
    ///   <para>qudt:Symbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Symbol</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/Symbol">http://qudt.org/schema/qudt/Symbol</seealso>
    let Symbol = Prefixed_Name(qudt, "Symbol") |> PrefixedName

    /// <summary>
    ///   <para>qudt:baseDimensionEnumeration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>base dimension enumeration</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/baseDimensionEnumeration">http://qudt.org/schema/qudt/baseDimensionEnumeration</seealso>
    let baseDimensionEnumeration =
        Prefixed_Name(qudt, "baseDimensionEnumeration") |> PrefixedName

    /// <summary>
    ///   <para>qudt:hasUnitSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has unit system</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/hasUnitSystem">http://qudt.org/schema/qudt/hasUnitSystem</seealso>
    let hasUnitSystem = Prefixed_Name(qudt, "hasUnitSystem") |> PrefixedName
    /// <summary>
    ///   <para>qudt:hasCoherentUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>coherent unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/hasCoherentUnit">http://qudt.org/schema/qudt/hasCoherentUnit</seealso>
    let hasCoherentUnit = Prefixed_Name(qudt, "hasCoherentUnit") |> PrefixedName
    /// <summary>
    ///   <para>qudt:hasUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/hasUnit">http://qudt.org/schema/qudt/hasUnit</seealso>
    let hasUnit = Prefixed_Name(qudt, "hasUnit") |> PrefixedName
    /// <summary>
    ///   <para>qudt:hasDerivedUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>derived unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/hasDerivedUnit">http://qudt.org/schema/qudt/hasDerivedUnit</seealso>
    let hasDerivedUnit = Prefixed_Name(qudt, "hasDerivedUnit") |> PrefixedName
    /// <summary>
    ///   <para>qudt:hasDefinedUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>defined unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/hasDefinedUnit">http://qudt.org/schema/qudt/hasDefinedUnit</seealso>
    let hasDefinedUnit = Prefixed_Name(qudt, "hasDefinedUnit") |> PrefixedName
    /// <summary>
    ///   <para>qudt:hasBaseUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>base unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/hasBaseUnit">http://qudt.org/schema/qudt/hasBaseUnit</seealso>
    let hasBaseUnit = Prefixed_Name(qudt, "hasBaseUnit") |> PrefixedName

    /// <summary>
    ///   <para>qudt:applicablePhysicalConstant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>applicable physical constant</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/applicablePhysicalConstant">http://qudt.org/schema/qudt/applicablePhysicalConstant</seealso>
    let applicablePhysicalConstant =
        Prefixed_Name(qudt, "applicablePhysicalConstant") |> PrefixedName

    /// <summary>
    ///   <para>qudt:hasDerivedCoherentUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>derived coherent unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/hasDerivedCoherentUnit">http://qudt.org/schema/qudt/hasDerivedCoherentUnit</seealso>
    let hasDerivedCoherentUnit =
        Prefixed_Name(qudt, "hasDerivedCoherentUnit") |> PrefixedName

    /// <summary>
    ///   <para>qudt:hasAllowedUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>allowed unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/hasAllowedUnit">http://qudt.org/schema/qudt/hasAllowedUnit</seealso>
    let hasAllowedUnit = Prefixed_Name(qudt, "hasAllowedUnit") |> PrefixedName
    /// <summary>
    ///   <para>qudt:UCUMci-term</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>Lexical pattern for the terminal symbols in the case-insensitive version of UCUM code</para>
    /// labels<para>case-insensitive UCUM term</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/UCUMci-term">http://qudt.org/schema/qudt/UCUMci-term</seealso>
    let UCUMci_term = Prefixed_Name(qudt, "UCUMci-term") |> PrefixedName
    /// <summary>
    ///   <para>qudt:UCUMcs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>Lexical pattern for the case-sensitive version of UCUM code</para>
    /// labels<para>case-sensitive UCUM code</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/UCUMcs">http://qudt.org/schema/qudt/UCUMcs</seealso>
    let UCUMcs = Prefixed_Name(qudt, "UCUMcs") |> PrefixedName
    /// <summary>
    ///   <para>qudt:UCUMcs-term</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>Lexical pattern for the terminal symbols in the case-sensitive version of UCUM code</para>
    /// labels<para>case-sensitive UCUM terminal</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/UCUMcs-term">http://qudt.org/schema/qudt/UCUMcs-term</seealso>
    let UCUMcs_term = Prefixed_Name(qudt, "UCUMcs-term") |> PrefixedName
    /// <summary>
    ///   <para>qudt:US-CustomaryUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Customary units used in USA not including those aligned to the SI system as specified in the 1960 agreement</para>
    /// labels<para>US-Customary unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/US-CustomaryUnit">http://qudt.org/schema/qudt/US-CustomaryUnit</seealso>
    let US_CustomaryUnit = Prefixed_Name(qudt, "US-CustomaryUnit") |> PrefixedName
    /// <summary>
    ///   <para>qudt:US-SurveyUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>US survey units (length and area) are defined slightly different to the International Customary units agreed in 1960. They retain earlier multipliers relative to the metre:
    /// 1 mile = 5280 feet
    /// 1 foot = 1200/3297 metres
    /// 1 inch = 1/12 foot</para>
    /// labels<para>US-Survey unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/US-SurveyUnit">http://qudt.org/schema/qudt/US-SurveyUnit</seealso>
    let US_SurveyUnit = Prefixed_Name(qudt, "US-SurveyUnit") |> PrefixedName

    /// <summary>
    ///   <para>qudt:UTF16-StringEncoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:StringEncodingType</para>
    ///
    /// labels<para>UTF-16 String</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/UTF16-StringEncoding">http://qudt.org/schema/qudt/UTF16-StringEncoding</seealso>
    let UTF16_StringEncoding =
        Prefixed_Name(qudt, "UTF16-StringEncoding") |> PrefixedName

    /// <summary>
    ///   <para>qudt:conversionOffset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>conversion offset</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/conversionOffset">http://qudt.org/schema/qudt/conversionOffset</seealso>
    let conversionOffset = Prefixed_Name(qudt, "conversionOffset") |> PrefixedName

    /// <summary>
    ///   <para>qudt:ucumCaseInsensitiveCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>ucum case-insensitive code</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/ucumCaseInsensitiveCode">http://qudt.org/schema/qudt/ucumCaseInsensitiveCode</seealso>
    let ucumCaseInsensitiveCode =
        Prefixed_Name(qudt, "ucumCaseInsensitiveCode") |> PrefixedName

    /// <summary>
    ///   <para>qudt:uneceCommonCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>unece common code</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/uneceCommonCode">http://qudt.org/schema/qudt/uneceCommonCode</seealso>
    let uneceCommonCode = Prefixed_Name(qudt, "uneceCommonCode") |> PrefixedName

    /// <summary>
    ///   <para>qudt:conversionMultiplier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>conversion multiplier</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/conversionMultiplier">http://qudt.org/schema/qudt/conversionMultiplier</seealso>
    let conversionMultiplier =
        Prefixed_Name(qudt, "conversionMultiplier") |> PrefixedName

    /// <summary>
    ///   <para>qudt:iec61360Code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>iec-61360 code</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/iec61360Code">http://qudt.org/schema/qudt/iec61360Code</seealso>
    let iec61360Code = Prefixed_Name(qudt, "iec61360Code") |> PrefixedName
    /// <summary>
    ///   <para>qudt:siUnitsExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>si units expression</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/siUnitsExpression">http://qudt.org/schema/qudt/siUnitsExpression</seealso>
    let siUnitsExpression = Prefixed_Name(qudt, "siUnitsExpression") |> PrefixedName
    /// <summary>
    ///   <para>qudt:ucumCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>ucum code</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/ucumCode">http://qudt.org/schema/qudt/ucumCode</seealso>
    let ucumCode = Prefixed_Name(qudt, "ucumCode") |> PrefixedName

    /// <summary>
    ///   <para>qudt:ucumCaseSensitiveCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>ucum case-sensitive code</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/ucumCaseSensitiveCode">http://qudt.org/schema/qudt/ucumCaseSensitiveCode</seealso>
    let ucumCaseSensitiveCode =
        Prefixed_Name(qudt, "ucumCaseSensitiveCode") |> PrefixedName

    /// <summary>
    ///   <para>qudt:UnsignedIntegerEncoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:IntegerEncodingType</para>
    ///
    /// labels<para>Unsigned Integer Encoding</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/UnsignedIntegerEncoding">http://qudt.org/schema/qudt/UnsignedIntegerEncoding</seealso>
    let UnsignedIntegerEncoding =
        Prefixed_Name(qudt, "UnsignedIntegerEncoding") |> PrefixedName

    /// <summary>
    ///   <para>qudt:normativeReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>normative reference</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/normativeReference">http://qudt.org/schema/qudt/normativeReference</seealso>
    let normativeReference = Prefixed_Name(qudt, "normativeReference") |> PrefixedName
    /// <summary>
    ///   <para>qudt:Wikipedia</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:Organization</para>
    ///
    /// labels<para>Wikipedia</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/Wikipedia">http://qudt.org/schema/qudt/Wikipedia</seealso>
    let Wikipedia = Prefixed_Name(qudt, "Wikipedia") |> PrefixedName
    /// <summary>
    ///   <para>qudt:acronym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>acronym</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/acronym">http://qudt.org/schema/qudt/acronym</seealso>
    let acronym = Prefixed_Name(qudt, "acronym") |> PrefixedName
    /// <summary>
    ///   <para>qudt:referenceUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>reference unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/referenceUnit">http://qudt.org/schema/qudt/referenceUnit</seealso>
    let referenceUnit = Prefixed_Name(qudt, "referenceUnit") |> PrefixedName

    /// <summary>
    ///   <para>qudt:relevantQuantityKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>relevant quantity kind</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/relevantQuantityKind">http://qudt.org/schema/qudt/relevantQuantityKind</seealso>
    let relevantQuantityKind =
        Prefixed_Name(qudt, "relevantQuantityKind") |> PrefixedName

    /// <summary>
    ///   <para>qudt:systemDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>system definition</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/systemDefinition">http://qudt.org/schema/qudt/systemDefinition</seealso>
    let systemDefinition = Prefixed_Name(qudt, "systemDefinition") |> PrefixedName
    /// <summary>
    ///   <para>qudt:url</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>url</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/url">http://qudt.org/schema/qudt/url</seealso>
    let url = Prefixed_Name(qudt, "url") |> PrefixedName
    /// <summary>
    ///   <para>qudt:specialization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>specialization</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/specialization">http://qudt.org/schema/qudt/specialization</seealso>
    let specialization = Prefixed_Name(qudt, "specialization") |> PrefixedName
    /// <summary>
    ///   <para>qudt:applicableCGSUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>applicable CGS unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/applicableCGSUnit">http://qudt.org/schema/qudt/applicableCGSUnit</seealso>
    let applicableCGSUnit = Prefixed_Name(qudt, "applicableCGSUnit") |> PrefixedName

    /// <summary>
    ///   <para>qudt:baseSIUnitDimensions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>base SI unit dimensions</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/baseSIUnitDimensions">http://qudt.org/schema/qudt/baseSIUnitDimensions</seealso>
    let baseSIUnitDimensions =
        Prefixed_Name(qudt, "baseSIUnitDimensions") |> PrefixedName

    /// <summary>
    ///   <para>qudt:applicableSIUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>applicable SI unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/applicableSIUnit">http://qudt.org/schema/qudt/applicableSIUnit</seealso>
    let applicableSIUnit = Prefixed_Name(qudt, "applicableSIUnit") |> PrefixedName
    /// <summary>
    ///   <para>qudt:applicableISOUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>applicable ISO unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/applicableISOUnit">http://qudt.org/schema/qudt/applicableISOUnit</seealso>
    let applicableISOUnit = Prefixed_Name(qudt, "applicableISOUnit") |> PrefixedName

    /// <summary>
    ///   <para>qudt:QuantityKindDimensionVector_SI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Quantity Kind Dimension vector (SI)</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/QuantityKindDimensionVector_SI">http://qudt.org/schema/qudt/QuantityKindDimensionVector_SI</seealso>
    let QuantityKindDimensionVector_SI =
        Prefixed_Name(qudt, "QuantityKindDimensionVector_SI") |> PrefixedName

    /// <summary>
    ///   <para>qudt:dimensionExponentForLuminousIntensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>dimension exponent for luminous intensity</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/dimensionExponentForLuminousIntensity">http://qudt.org/schema/qudt/dimensionExponentForLuminousIntensity</seealso>
    let dimensionExponentForLuminousIntensity =
        Prefixed_Name(qudt, "dimensionExponentForLuminousIntensity") |> PrefixedName

    /// <summary>
    ///   <para>qudt:dimensionExponentForMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>dimension exponent for mass</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/dimensionExponentForMass">http://qudt.org/schema/qudt/dimensionExponentForMass</seealso>
    let dimensionExponentForMass =
        Prefixed_Name(qudt, "dimensionExponentForMass") |> PrefixedName

    /// <summary>
    ///   <para>qudt:dimensionExponentForTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>dimension exponent for time</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/dimensionExponentForTime">http://qudt.org/schema/qudt/dimensionExponentForTime</seealso>
    let dimensionExponentForTime =
        Prefixed_Name(qudt, "dimensionExponentForTime") |> PrefixedName

    /// <summary>
    ///   <para>qudt:QuantityKindDimensionVector_CGS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A &lt;em&gt;CGS Dimension Vector&lt;/em&gt; is used to specify the dimensions for a C.G.S. quantity kind.</para>
    /// labels<para>CGS Dimension vector</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/QuantityKindDimensionVector_CGS">http://qudt.org/schema/qudt/QuantityKindDimensionVector_CGS</seealso>
    let QuantityKindDimensionVector_CGS =
        Prefixed_Name(qudt, "QuantityKindDimensionVector_CGS") |> PrefixedName

    /// <summary>
    ///   <para>qudt:QuantityKindDimensionVector_CGS-GAUSS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A &lt;em&gt;CGS GAUSS Dimension Vector&lt;/em&gt; is used to specify the dimensions for Gaussioan C.G.S. quantity kind.</para>
    /// labels<para>CGS GAUSS Dimension vector</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/QuantityKindDimensionVector_CGS-GAUSS">http://qudt.org/schema/qudt/QuantityKindDimensionVector_CGS-GAUSS</seealso>
    let QuantityKindDimensionVector_CGS_GAUSS =
        Prefixed_Name(qudt, "QuantityKindDimensionVector_CGS-GAUSS") |> PrefixedName

    /// <summary>
    ///   <para>qudt:QuantityKindDimensionVector_ISO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>ISO Dimension vector</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/QuantityKindDimensionVector_ISO">http://qudt.org/schema/qudt/QuantityKindDimensionVector_ISO</seealso>
    let QuantityKindDimensionVector_ISO =
        Prefixed_Name(qudt, "QuantityKindDimensionVector_ISO") |> PrefixedName

    /// <summary>
    ///   <para>qudt:QuantityKindDimensionVector_Imperial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Imperial dimension vector</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/QuantityKindDimensionVector_Imperial">http://qudt.org/schema/qudt/QuantityKindDimensionVector_Imperial</seealso>
    let QuantityKindDimensionVector_Imperial =
        Prefixed_Name(qudt, "QuantityKindDimensionVector_Imperial") |> PrefixedName

    /// <summary>
    ///   <para>qudt:guidance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>guidance</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/guidance">http://qudt.org/schema/qudt/guidance</seealso>
    let guidance = Prefixed_Name(qudt, "guidance") |> PrefixedName

    /// <summary>
    ///   <para>qudt:isBaseQuantityKindOfSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is base quantity kind of system</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/isBaseQuantityKindOfSystem">http://qudt.org/schema/qudt/isBaseQuantityKindOfSystem</seealso>
    let isBaseQuantityKindOfSystem =
        Prefixed_Name(qudt, "isBaseQuantityKindOfSystem") |> PrefixedName

    /// <summary>
    ///   <para>qudt:isCoherentUnitOfSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is coherent unit of system</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/isCoherentUnitOfSystem">http://qudt.org/schema/qudt/isCoherentUnitOfSystem</seealso>
    let isCoherentUnitOfSystem =
        Prefixed_Name(qudt, "isCoherentUnitOfSystem") |> PrefixedName

    /// <summary>
    ///   <para>qudt:isDerivedCoherentUnitOfSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is coherent derived unit of system</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/isDerivedCoherentUnitOfSystem">http://qudt.org/schema/qudt/isDerivedCoherentUnitOfSystem</seealso>
    let isDerivedCoherentUnitOfSystem =
        Prefixed_Name(qudt, "isDerivedCoherentUnitOfSystem") |> PrefixedName

    /// <summary>
    ///   <para>qudt:hasDerivedNonCoherentUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has coherent derived unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/hasDerivedNonCoherentUnit">http://qudt.org/schema/qudt/hasDerivedNonCoherentUnit</seealso>
    let hasDerivedNonCoherentUnit =
        Prefixed_Name(qudt, "hasDerivedNonCoherentUnit") |> PrefixedName

    /// <summary>
    ///   <para>qudt:isDerivedNonCoherentUnitOfSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is non-coherent derived unit of system</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/isDerivedNonCoherentUnitOfSystem">http://qudt.org/schema/qudt/isDerivedNonCoherentUnitOfSystem</seealso>
    let isDerivedNonCoherentUnitOfSystem =
        Prefixed_Name(qudt, "isDerivedNonCoherentUnitOfSystem") |> PrefixedName

    /// <summary>
    ///   <para>qudt:hasDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has dimension</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/hasDimension">http://qudt.org/schema/qudt/hasDimension</seealso>
    let hasDimension = Prefixed_Name(qudt, "hasDimension") |> PrefixedName
    /// <summary>
    ///   <para>qudt:hasNumeratorPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has quantity kind dimension vector numerator part</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/hasNumeratorPart">http://qudt.org/schema/qudt/hasNumeratorPart</seealso>
    let hasNumeratorPart = Prefixed_Name(qudt, "hasNumeratorPart") |> PrefixedName
    /// <summary>
    ///   <para>qudt:hasQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has quantity</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/hasQuantity">http://qudt.org/schema/qudt/hasQuantity</seealso>
    let hasQuantity = Prefixed_Name(qudt, "hasQuantity") |> PrefixedName

    /// <summary>
    ///   <para>qudt:hasReferenceQuantityKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has reference quantity kind</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/hasReferenceQuantityKind">http://qudt.org/schema/qudt/hasReferenceQuantityKind</seealso>
    let hasReferenceQuantityKind =
        Prefixed_Name(qudt, "hasReferenceQuantityKind") |> PrefixedName

    /// <summary>
    ///   <para>qudt:hasVocabulary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>has vocabulary</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/hasVocabulary">http://qudt.org/schema/qudt/hasVocabulary</seealso>
    let hasVocabulary = Prefixed_Name(qudt, "hasVocabulary") |> PrefixedName
    /// <summary>
    ///   <para>qudt:integerPercentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>integer percentage</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/integerPercentage">http://qudt.org/schema/qudt/integerPercentage</seealso>
    let integerPercentage = Prefixed_Name(qudt, "integerPercentage") |> PrefixedName
    /// <summary>
    ///   <para>qudt:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>qudt description</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/description">http://qudt.org/schema/qudt/description</seealso>
    let description = Prefixed_Name(qudt, "description") |> PrefixedName
    /// <summary>
    ///   <para>qudt:rationale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>rationale</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/rationale">http://qudt.org/schema/qudt/rationale</seealso>
    let rationale = Prefixed_Name(qudt, "rationale") |> PrefixedName
    /// <summary>
    ///   <para>qudt:hasRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has rule</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/hasRule">http://qudt.org/schema/qudt/hasRule</seealso>
    let hasRule = Prefixed_Name(qudt, "hasRule") |> PrefixedName
    /// <summary>
    ///   <para>qudt:Rule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Rule</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/Rule">http://qudt.org/schema/qudt/Rule</seealso>
    let Rule = Prefixed_Name(qudt, "Rule") |> PrefixedName
    /// <summary>
    ///   <para>qudt:QuantityValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A &lt;i&gt;Quantity Value&lt;/i&gt; expresses the magnitude and kind of a quantity and is given by the product of a numerical value &lt;code&gt;n&lt;/code&gt; and a unit of measure &lt;code&gt;U&lt;/code&gt;. The number multiplying the unit is referred to as the numerical value of the quantity expressed in that unit. Refer to &lt;a href="http://physics.nist.gov/Pubs/SP811/sec07.html"&gt;NIST SP 811 section 7&lt;/a&gt; for more on quantity values.</para>
    /// labels<para>Quantity value</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/QuantityValue">http://qudt.org/schema/qudt/QuantityValue</seealso>
    let QuantityValue = Prefixed_Name(qudt, "QuantityValue") |> PrefixedName
    /// <summary>
    ///   <para>qudt:CountingUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Used for all units that express counts. Examples are Atomic Number, Number, Number per Year, Percent and Sample per Second.</para>
    /// labels<para>Counting Unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/CountingUnit">http://qudt.org/schema/qudt/CountingUnit</seealso>
    let CountingUnit = Prefixed_Name(qudt, "CountingUnit") |> PrefixedName
    /// <summary>
    ///   <para>qudt:CurrencyUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Currency Units have their own subclass of unit because: (a) they have additonal properites such as 'country' and (b) their URIs do not conform to the same rules as other units.</para>
    ///   <para>Used for all units that express currency.</para>
    /// labels<para>Currency Unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/CurrencyUnit">http://qudt.org/schema/qudt/CurrencyUnit</seealso>
    let CurrencyUnit = Prefixed_Name(qudt, "CurrencyUnit") |> PrefixedName
    /// <summary>
    ///   <para>qudt:DataEncoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>&lt;p&gt;&lt;em&gt;Data Encoding&lt;/em&gt; expresses the properties that specify how data is represented at the bit and byte level. These properties are applicable to describing raw data.&lt;/p&gt;</para>
    /// labels<para>Data Encoding</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/DataEncoding">http://qudt.org/schema/qudt/DataEncoding</seealso>
    let DataEncoding = Prefixed_Name(qudt, "DataEncoding") |> PrefixedName
    /// <summary>
    ///   <para>qudt:encoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>encoding</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/encoding">http://qudt.org/schema/qudt/encoding</seealso>
    let encoding = Prefixed_Name(qudt, "encoding") |> PrefixedName
    /// <summary>
    ///   <para>qudt:bitOrder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>bit order</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/bitOrder">http://qudt.org/schema/qudt/bitOrder</seealso>
    let bitOrder = Prefixed_Name(qudt, "bitOrder") |> PrefixedName
    /// <summary>
    ///   <para>qudt:basis</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>basis</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/basis">http://qudt.org/schema/qudt/basis</seealso>
    let basis = Prefixed_Name(qudt, "basis") |> PrefixedName
    /// <summary>
    ///   <para>qudt:odbcName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>ODBC name</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/odbcName">http://qudt.org/schema/qudt/odbcName</seealso>
    let odbcName = Prefixed_Name(qudt, "odbcName") |> PrefixedName
    /// <summary>
    ///   <para>qudt:bounded</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>bounded</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/bounded">http://qudt.org/schema/qudt/bounded</seealso>
    let bounded = Prefixed_Name(qudt, "bounded") |> PrefixedName
    /// <summary>
    ///   <para>qudt:oracleSQLName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>ORACLE SQL name</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/oracleSQLName">http://qudt.org/schema/qudt/oracleSQLName</seealso>
    let oracleSQLName = Prefixed_Name(qudt, "oracleSQLName") |> PrefixedName
    /// <summary>
    ///   <para>qudt:vbName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Vusal Basic name</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/vbName">http://qudt.org/schema/qudt/vbName</seealso>
    let vbName = Prefixed_Name(qudt, "vbName") |> PrefixedName
    /// <summary>
    ///   <para>qudt:mySQLName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>MySQL name</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/mySQLName">http://qudt.org/schema/qudt/mySQLName</seealso>
    let mySQLName = Prefixed_Name(qudt, "mySQLName") |> PrefixedName
    /// <summary>
    ///   <para>qudt:OrderedType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Ordered type</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/OrderedType">http://qudt.org/schema/qudt/OrderedType</seealso>
    let OrderedType = Prefixed_Name(qudt, "OrderedType") |> PrefixedName
    /// <summary>
    ///   <para>qudt:javaName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>java name</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/javaName">http://qudt.org/schema/qudt/javaName</seealso>
    let javaName = Prefixed_Name(qudt, "javaName") |> PrefixedName
    /// <summary>
    ///   <para>qudt:cName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Datatype name in the C programming language</para>
    /// labels<para>C Language name</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/cName">http://qudt.org/schema/qudt/cName</seealso>
    let cName = Prefixed_Name(qudt, "cName") |> PrefixedName
    /// <summary>
    ///   <para>qudt:protocolBuffersName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>protocol buffers name</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/protocolBuffersName">http://qudt.org/schema/qudt/protocolBuffersName</seealso>
    let protocolBuffersName = Prefixed_Name(qudt, "protocolBuffersName") |> PrefixedName
    /// <summary>
    ///   <para>qudt:jsName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Javascript name</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/jsName">http://qudt.org/schema/qudt/jsName</seealso>
    let jsName = Prefixed_Name(qudt, "jsName") |> PrefixedName
    /// <summary>
    ///   <para>qudt:matlabName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>matlab name</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/matlabName">http://qudt.org/schema/qudt/matlabName</seealso>
    let matlabName = Prefixed_Name(qudt, "matlabName") |> PrefixedName
    /// <summary>
    ///   <para>qudt:StringEncodingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>String Encoding Type</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/StringEncodingType">http://qudt.org/schema/qudt/StringEncodingType</seealso>
    let StringEncodingType = Prefixed_Name(qudt, "StringEncodingType") |> PrefixedName
    /// <summary>
    ///   <para>qudt:DecimalPrefixUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A &lt;em&gt;Decimal Prefix Unit&lt;/em&gt; is a unit prefix for multiples of units that are powers of 10.</para>
    /// labels<para>Decimal Prefix Unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/DecimalPrefixUnit">http://qudt.org/schema/qudt/DecimalPrefixUnit</seealso>
    let DecimalPrefixUnit = Prefixed_Name(qudt, "DecimalPrefixUnit") |> PrefixedName
    /// <summary>
    ///   <para>qudt:DerivedCoherentUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Derived coherent unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/DerivedCoherentUnit">http://qudt.org/schema/qudt/DerivedCoherentUnit</seealso>
    let DerivedCoherentUnit = Prefixed_Name(qudt, "DerivedCoherentUnit") |> PrefixedName
    /// <summary>
    ///   <para>qudt:DerivedUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>A DerivedUnit is a type specification for units that are derived from other units.</para>
    /// labels<para>Derived Unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/DerivedUnit">http://qudt.org/schema/qudt/DerivedUnit</seealso>
    let DerivedUnit = Prefixed_Name(qudt, "DerivedUnit") |> PrefixedName

    /// <summary>
    ///   <para>qudt:DerivedNonCoherentUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Derived non coherent unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/DerivedNonCoherentUnit">http://qudt.org/schema/qudt/DerivedNonCoherentUnit</seealso>
    let DerivedNonCoherentUnit =
        Prefixed_Name(qudt, "DerivedNonCoherentUnit") |> PrefixedName

    /// <summary>
    ///   <para>qudt:RuleType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Rule Type</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/RuleType">http://qudt.org/schema/qudt/RuleType</seealso>
    let RuleType = Prefixed_Name(qudt, "RuleType") |> PrefixedName
    /// <summary>
    ///   <para>qudt:SIGNED</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:SignednessType</para>
    ///
    /// labels<para>Signed</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/SIGNED">http://qudt.org/schema/qudt/SIGNED</seealso>
    let SIGNED = Prefixed_Name(qudt, "SIGNED") |> PrefixedName
    /// <summary>
    ///   <para>qudt:SOU_NATURAL_UNITS</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:SystemOfUnits</para>
    ///   <para>&lt;p&gt;In physics, natural units are physical units of measurement based only on universal physical constants. For example the elementary charge e is a natural unit of electric charge, or the speed of light c is a natural unit of speed.&lt;/p&gt;
    /// &lt;p&gt;A purely natural system of units is defined in such a way that some set of selected universal physical constants are normalized to unity; that is, their numerical values in terms of these units become exactly 1.&lt;/p&gt;
    /// &lt;p&gt;Examples are Planck Units and Atomic Units. Atomic units (au or a.u.) form a system of natural units which is especially convenient for atomic physics calculations. There are two different kinds of atomic units, which one might name Hartree atomic units and Rydberg atomic units, which differ in the choice of the unit of mass and charge.&lt;/p&gt;
    /// &lt;p&gt;Planck units are unique among systems of natural units, because they are not defined in terms of properties of any prototype, physical object, or even elementary particle.&lt;/p&gt;</para>
    /// labels<para>System of Natural Units</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/SOU_NATURAL_UNITS">http://qudt.org/schema/qudt/SOU_NATURAL_UNITS</seealso>
    let SOU_NATURAL_UNITS = Prefixed_Name(qudt, "SOU_NATURAL_UNITS") |> PrefixedName
    /// <summary>
    ///   <para>qudt:isBaseUnitOfSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is base unit of system</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/isBaseUnitOfSystem">http://qudt.org/schema/qudt/isBaseUnitOfSystem</seealso>
    let isBaseUnitOfSystem = Prefixed_Name(qudt, "isBaseUnitOfSystem") |> PrefixedName
    /// <summary>
    ///   <para>qudt:hasDenominatorPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has quantity kind dimension vector denominator part</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/hasDenominatorPart">http://qudt.org/schema/qudt/hasDenominatorPart</seealso>
    let hasDenominatorPart = Prefixed_Name(qudt, "hasDenominatorPart") |> PrefixedName
    /// <summary>
    ///   <para>qudt:hasNonCoherentUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has non-coherent unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/hasNonCoherentUnit">http://qudt.org/schema/qudt/hasNonCoherentUnit</seealso>
    let hasNonCoherentUnit = Prefixed_Name(qudt, "hasNonCoherentUnit") |> PrefixedName
    /// <summary>
    ///   <para>qudt:abbreviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>abbreviation</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/abbreviation">http://qudt.org/schema/qudt/abbreviation</seealso>
    let abbreviation = Prefixed_Name(qudt, "abbreviation") |> PrefixedName
    /// <summary>
    ///   <para>qudt:ConstantValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Used to specify the values of a constant.</para>
    /// labels<para>Constant value</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/ConstantValue">http://qudt.org/schema/qudt/ConstantValue</seealso>
    let ConstantValue = Prefixed_Name(qudt, "ConstantValue") |> PrefixedName
    /// <summary>
    ///   <para>qudt:DimensionlessUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Dimensionless Unit is a quantity for which all the exponents of the factors corresponding to the base quantities in its quantity dimension are zero.</para>
    /// labels<para>Dimensionless Unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/DimensionlessUnit">http://qudt.org/schema/qudt/DimensionlessUnit</seealso>
    let DimensionlessUnit = Prefixed_Name(qudt, "DimensionlessUnit") |> PrefixedName
    /// <summary>
    ///   <para>qudt:isDimensionInSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is dimension in system</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/isDimensionInSystem">http://qudt.org/schema/qudt/isDimensionInSystem</seealso>
    let isDimensionInSystem = Prefixed_Name(qudt, "isDimensionInSystem") |> PrefixedName
    /// <summary>
    ///   <para>qudt:maxInclusive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>max inclusive</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/maxInclusive">http://qudt.org/schema/qudt/maxInclusive</seealso>
    let maxInclusive = Prefixed_Name(qudt, "maxInclusive") |> PrefixedName
    /// <summary>
    ///   <para>qudt:exactConstant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>exact constant</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/exactConstant">http://qudt.org/schema/qudt/exactConstant</seealso>
    let exactConstant = Prefixed_Name(qudt, "exactConstant") |> PrefixedName
    /// <summary>
    ///   <para>qudt:ResourceUnit</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/ResourceUnit">http://qudt.org/schema/qudt/ResourceUnit</seealso>
    let ResourceUnit = Prefixed_Name(qudt, "ResourceUnit") |> PrefixedName

    /// <summary>
    ///   <para>qudt:permissibleTransformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>permissible transformation</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/permissibleTransformation">http://qudt.org/schema/qudt/permissibleTransformation</seealso>
    let permissibleTransformation =
        Prefixed_Name(qudt, "permissibleTransformation") |> PrefixedName

    /// <summary>
    ///   <para>qudt:TransformType</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/TransformType">http://qudt.org/schema/qudt/TransformType</seealso>
    let TransformType = Prefixed_Name(qudt, "TransformType") |> PrefixedName

    /// <summary>
    ///   <para>qudt:ShortSignedIntegerEncoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:IntegerEncodingType</para>
    ///
    /// labels<para>Short Signed Integer Encoding</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/ShortSignedIntegerEncoding">http://qudt.org/schema/qudt/ShortSignedIntegerEncoding</seealso>
    let ShortSignedIntegerEncoding =
        Prefixed_Name(qudt, "ShortSignedIntegerEncoding") |> PrefixedName

    /// <summary>
    ///   <para>qudt:UNSIGNED</para>
    /// </summary>
    /// <remarks>
    ///   <para>qudt:SignednessType</para>
    ///
    /// labels<para>Unsigned</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/UNSIGNED">http://qudt.org/schema/qudt/UNSIGNED</seealso>
    let UNSIGNED = Prefixed_Name(qudt, "UNSIGNED") |> PrefixedName

    /// <summary>
    ///   <para>qudt:isDefinedUnitOfSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>defined unit of system</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/isDefinedUnitOfSystem">http://qudt.org/schema/qudt/isDefinedUnitOfSystem</seealso>
    let isDefinedUnitOfSystem =
        Prefixed_Name(qudt, "isDefinedUnitOfSystem") |> PrefixedName

    /// <summary>
    ///   <para>qudt:isDerivedUnitOfSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is derived unit of system</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/isDerivedUnitOfSystem">http://qudt.org/schema/qudt/isDerivedUnitOfSystem</seealso>
    let isDerivedUnitOfSystem =
        Prefixed_Name(qudt, "isDerivedUnitOfSystem") |> PrefixedName

    /// <summary>
    ///   <para>qudt:BaseDimensionMagnitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>&lt;p class="lm-para"&gt;A &lt;em&gt;Dimension&lt;/em&gt; expresses a magnitude for a base quantiy kind such as mass, length and time.&lt;/p&gt;
    /// &lt;p class="lm-para"&gt;DEPRECATED - each exponent is expressed as a property. Keep until a validaiton of this has been done.&lt;/p&gt;</para>
    /// labels<para>Base Dimension Magnitude</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/BaseDimensionMagnitude">http://qudt.org/schema/qudt/BaseDimensionMagnitude</seealso>
    let BaseDimensionMagnitude =
        Prefixed_Name(qudt, "BaseDimensionMagnitude") |> PrefixedName

    /// <summary>
    ///   <para>qudt:allowedPattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://qudt.org/schema/qudt/allowedPattern">http://qudt.org/schema/qudt/allowedPattern</seealso>
    let allowedPattern = Prefixed_Name(qudt, "allowedPattern") |> PrefixedName
    /// <summary>
    ///   <para>qudt:DecimalScaledUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Decimal scaled unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/DecimalScaledUnit">http://qudt.org/schema/qudt/DecimalScaledUnit</seealso>
    let DecimalScaledUnit = Prefixed_Name(qudt, "DecimalScaledUnit") |> PrefixedName
    /// <summary>
    ///   <para>qudt:UCUMci</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>Lexical pattern for the case-insensitive version of UCUM code</para>
    /// labels<para>case-insensitive UCUM code</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/UCUMci">http://qudt.org/schema/qudt/UCUMci</seealso>
    let UCUMci = Prefixed_Name(qudt, "UCUMci") |> PrefixedName
    /// <summary>
    ///   <para>qudt:mathDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>math definition</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/mathDefinition">http://qudt.org/schema/qudt/mathDefinition</seealso>
    let mathDefinition = Prefixed_Name(qudt, "mathDefinition") |> PrefixedName
    /// <summary>
    ///   <para>qudt:upperBound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>upper bound</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/upperBound">http://qudt.org/schema/qudt/upperBound</seealso>
    let upperBound = Prefixed_Name(qudt, "upperBound") |> PrefixedName
    /// <summary>
    ///   <para>qudt:negativeDeltaLimit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>negative delta limit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/negativeDeltaLimit">http://qudt.org/schema/qudt/negativeDeltaLimit</seealso>
    let negativeDeltaLimit = Prefixed_Name(qudt, "negativeDeltaLimit") |> PrefixedName
    /// <summary>
    ///   <para>qudt:omUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>om unit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/omUnit">http://qudt.org/schema/qudt/omUnit</seealso>
    let omUnit = Prefixed_Name(qudt, "omUnit") |> PrefixedName
    /// <summary>
    ///   <para>qudt:onlineReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>online reference</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/onlineReference">http://qudt.org/schema/qudt/onlineReference</seealso>
    let onlineReference = Prefixed_Name(qudt, "onlineReference") |> PrefixedName
    /// <summary>
    ///   <para>qudt:outOfScope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>out of scope</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/outOfScope">http://qudt.org/schema/qudt/outOfScope</seealso>
    let outOfScope = Prefixed_Name(qudt, "outOfScope") |> PrefixedName
    /// <summary>
    ///   <para>qudt:positiveDeltaLimit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Positive delta limit</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/positiveDeltaLimit">http://qudt.org/schema/qudt/positiveDeltaLimit</seealso>
    let positiveDeltaLimit = Prefixed_Name(qudt, "positiveDeltaLimit") |> PrefixedName
    /// <summary>
    ///   <para>qudt:quantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>quantity</para></remarks>
    /// <seealso href="http://qudt.org/schema/qudt/quantity">http://qudt.org/schema/qudt/quantity</seealso>
    let quantity = Prefixed_Name(qudt, "quantity") |> PrefixedName

namespace http.purl.oclc.org.NET.muo.muo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module muo =
    let _namespace_iri = Namespace_Iri muo |> NamespaceIRI
    /// <summary>
    ///   <para>muo:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"
    ///          Classes and properties of this ontology have been
    ///          designed by the MyMobileWeb project.
    ///       "</para>
    /// labels<para>"MUO - Measurement Units Ontology"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/muo#">http://purl.oclc.org/NET/muo/muo#</seealso>
    let _prefix_iri = Prefixed_Name(muo, "") |> PrefixedName
    /// <summary>
    ///   <para>muo:BaseUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Base units are units that have not been derived from any other unit. In turn, base units can be used to derive other measurement units."</para>
    ///   <para>"Base units are units that have not been derived from any other unit. In turn, base units can be used to derive other measurement units. The International System of Units (SI), recognizes several base units for base physical qualities assumed to be mutually independent."</para>
    /// labels<para>"Base unit of measurement"</para><para>"Base unit"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/muo#BaseUnit">http://purl.oclc.org/NET/muo/muo#BaseUnit</seealso>
    let BaseUnit = Prefixed_Name(muo, "BaseUnit") |> PrefixedName
    /// <summary>
    ///   <para>muo:ComplexDerivedUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Units that are derived from two or more measurement units (i.e. a derived unit which is defined by means of more than one unit in its dimensional equation). For instance, the complex derived unit meter per second squared is defined by a dimensional equation with two units: m and s2."</para>
    /// labels<para>"Complex derived unit of measurement"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/muo#ComplexDerivedUnit">http://purl.oclc.org/NET/muo/muo#ComplexDerivedUnit</seealso>
    let ComplexDerivedUnit = Prefixed_Name(muo, "ComplexDerivedUnit") |> PrefixedName
    /// <summary>
    ///   <para>muo:DerivedUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Some physical qualities (such as area, acceleration, etc.), called derived physical qualities, are defined in terms of base qualities via a system of dimensional equations. The derived units for derived qualities are obtained from these equations combinated with the base units."</para>
    /// labels<para>"Derived unit of measurement"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/muo#DerivedUnit">http://purl.oclc.org/NET/muo/muo#DerivedUnit</seealso>
    let DerivedUnit = Prefixed_Name(muo, "DerivedUnit") |> PrefixedName
    /// <summary>
    ///   <para>muo:MetricUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"FIX"</para>
    /// labels<para>"Metric unit"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/muo#MetricUnit">http://purl.oclc.org/NET/muo/muo#MetricUnit</seealso>
    let MetricUnit = Prefixed_Name(muo, "MetricUnit") |> PrefixedName
    /// <summary>
    ///   <para>muo:PhysicalQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The physical qualities such as mass, weight, speed, etc. are kind of properties that can be quantified i.e. that can be perceived, measured or even calculated. The concept of physical quality is similar to the notion of quality, used in metrology, the science of measurement. We distinguish between: 1) A physical quality in the general sense: a kind of physical property ascribed to phenomena that can be quantified for a particular phenomenon (e.g. length and electrical charge); 2) A physical quantity in the particular sense: a quantifiable property ascribed to a particular phenomenon (e.g. the weight of my device). MUO only uses physical quantities in the general sense."</para>
    /// labels<para>"Physical quality"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/muo#PhysicalQuality">http://purl.oclc.org/NET/muo/muo#PhysicalQuality</seealso>
    let PhysicalQuality = Prefixed_Name(muo, "PhysicalQuality") |> PrefixedName
    /// <summary>
    ///   <para>muo:Prefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A prefix (also known as a metric prefix) is a name or associated symbol that precedes a unit of measure (or its symbol) to form a decimal multiple or submultiple. Prefixes are used to reduce the quantity of zeroes in numerical equivalencies. For instance, 1000 meters can be written as 1 kilometer, using the prefix kilo, a symbol to represent the number 1000."</para>
    /// labels<para>"Prefix"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/muo#Prefix">http://purl.oclc.org/NET/muo/muo#Prefix</seealso>
    let Prefix = Prefixed_Name(muo, "Prefix") |> PrefixedName
    /// <summary>
    ///   <para>muo:QualityValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The value of an individual quality, for instance, the weight of an individual object.   If we consider metrology, the value of a physical quality Q is expressed as the product of a numerical value {Q} and a physical unit [Q]: Q = {Q} x [Q]. In MUO, the class muo:QualityValue is used to represent the values of qualities, Q. Instances of this class are related with 1) exactly one unit, suitable for measure the physical quality (meters for length, grams for weight, etc), by means of the property muo:measuredIn, [Q]; 2) a number, which express the relationship between the value and the unit by means of the rdf:value property, {Q}; 3) a time, which expresses the quality value along the line of time. Quality values can be temporalized, but this is not always necessary.
    /// "</para>
    /// labels<para>"Quality value"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/muo#QualityValue">http://purl.oclc.org/NET/muo/muo#QualityValue</seealso>
    let QualityValue = Prefixed_Name(muo, "QualityValue") |> PrefixedName
    /// <summary>
    ///   <para>muo:SIUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Unit belonging to the International System of Units. The SI recognizes several base and derived units for some physical qualities assumed to be mutually independent."</para>
    /// labels<para>"SI unit"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/muo#SIUnit">http://purl.oclc.org/NET/muo/muo#SIUnit</seealso>
    let SIUnit = Prefixed_Name(muo, "SIUnit") |> PrefixedName
    /// <summary>
    ///   <para>muo:SimpleDerivedUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Units that are derived from exactly one base unit. There are two main possibilities. On one hand, there are units that are derived by adding a prefix to the unit. The prefix is a name or associated symbol (e.g. kilo) that precedes a unit of measure (e.g. meter) to form a decimal multiple or submultiple (e.g. Kilometer). Derived units, obtained by the application of a prefix, measure the same physical quality as its base unit. On the other hand, there are another kind of simple derived units that are also obtained from exactly one base unit but they measure a different physical quality. They are obtained by changing the exponent of the unit in the dimensional equation. For instance, this is how square meters are derived from meters. This exponent is represented in MUO with the datatype property muo:dimensionalSize. Combining this two patterns we can represent units that are obtained from a prefix and that have a dimension size different from 1, for instance, the unit square kilometer."</para>
    /// labels<para>"Derived unit of measurement made out of exactly one base unit"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/muo#SimpleDerivedUnit">http://purl.oclc.org/NET/muo/muo#SimpleDerivedUnit</seealso>
    let SimpleDerivedUnit = Prefixed_Name(muo, "SimpleDerivedUnit") |> PrefixedName
    /// <summary>
    ///   <para>muo:UnitOfMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measurement units are standards for measurement of physical properties or qualities. Every unit is related to a particular kind of property. For instance, the meter unit is uniquely related to the length property. Under our ontological approach, units are abstract spaces used as a reference metrics for quality spaces, such as physical qualia, and they are counted by some number. For instance, weight-units define some quality spaces for the weight-quality where specific weights of objects, like devices or persons, are located by means of comparisons with the proper weight-value of the selected weight-unit."</para>
    /// labels<para>"Unit of measurement"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/muo#UnitOfMeasurement">http://purl.oclc.org/NET/muo/muo#UnitOfMeasurement</seealso>
    let UnitOfMeasurement = Prefixed_Name(muo, "UnitOfMeasurement") |> PrefixedName
    /// <summary>
    ///   <para>muo:altSymbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Alternate (standarized) symbol of the entity"</para>
    /// labels<para>"Alternate Symbol"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/muo#altSymbol">http://purl.oclc.org/NET/muo/muo#altSymbol</seealso>
    let altSymbol = Prefixed_Name(muo, "altSymbol") |> PrefixedName
    /// <summary>
    ///   <para>muo:derivesFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a unit with another unit from which the former is derived. For instance, square meter derives from meter."</para>
    /// labels<para>"Derives from"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/muo#derivesFrom">http://purl.oclc.org/NET/muo/muo#derivesFrom</seealso>
    let derivesFrom = Prefixed_Name(muo, "derivesFrom") |> PrefixedName
    /// <summary>
    ///   <para>muo:dimensionalSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The dimensional size of a simple derived unit, i.e., the exponent of the dimension in the dimensional equation. For instance, for square meters, the dimensional size is two."</para>
    /// labels<para>"Dimensional size"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/muo#dimensionalSize">http://purl.oclc.org/NET/muo/muo#dimensionalSize</seealso>
    let dimensionalSize = Prefixed_Name(muo, "dimensionalSize") |> PrefixedName

    /// <summary>
    ///   <para>muo:equivalentObjectProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/muo#equivalentObjectProperty">http://purl.oclc.org/NET/muo/muo#equivalentObjectProperty</seealso>
    let equivalentObjectProperty =
        Prefixed_Name(muo, "equivalentObjectProperty") |> PrefixedName

    /// <summary>
    ///   <para>muo:factor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Modification factor that multiples the base value of the unit"</para>
    /// labels<para>"Factor"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/muo#factor">http://purl.oclc.org/NET/muo/muo#factor</seealso>
    let factor = Prefixed_Name(muo, "factor") |> PrefixedName
    /// <summary>
    ///   <para>muo:inTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The time of a particular quality value (e.g. the weight of Carlos yesterday)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"In Time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/muo#inTime">http://purl.oclc.org/NET/muo/muo#inTime</seealso>
    let inTime = Prefixed_Name(muo, "inTime") |> PrefixedName
    /// <summary>
    ///   <para>muo:measuredIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The unit used in the measurement of a particular quality value"</para>
    /// labels<para>"Measured in"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/muo#measuredIn">http://purl.oclc.org/NET/muo/muo#measuredIn</seealso>
    let measuredIn = Prefixed_Name(muo, "measuredIn") |> PrefixedName
    /// <summary>
    ///   <para>muo:measuresQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The physical quality the unit is able to measure."</para>
    /// labels<para>"Measures quality"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/muo#measuresQuality">http://purl.oclc.org/NET/muo/muo#measuresQuality</seealso>
    let measuresQuality = Prefixed_Name(muo, "measuresQuality") |> PrefixedName
    /// <summary>
    ///   <para>muo:modifierPrefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The modifier prefix that applies to a derived unit of measurement"</para>
    /// labels<para>"Unit prefix"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/muo#modifierPrefix">http://purl.oclc.org/NET/muo/muo#modifierPrefix</seealso>
    let modifierPrefix = Prefixed_Name(muo, "modifierPrefix") |> PrefixedName
    /// <summary>
    ///   <para>muo:numericalValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/muo#numericalValue">http://purl.oclc.org/NET/muo/muo#numericalValue</seealso>
    let numericalValue = Prefixed_Name(muo, "numericalValue") |> PrefixedName
    /// <summary>
    ///   <para>muo:prefSymbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Standarized symbol of the entity"</para>
    /// labels<para>"Preferred Symbol"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/muo#prefSymbol">http://purl.oclc.org/NET/muo/muo#prefSymbol</seealso>
    let prefSymbol = Prefixed_Name(muo, "prefSymbol") |> PrefixedName
    /// <summary>
    ///   <para>muo:preferredUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The user-preferred unit for measuring the values of a muo:qualityValue subproperty (e.g. weight). This information is used by the conversion service to convert a value expressed in one unit to the preferred one."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Preferred Unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/muo#preferredUnit">http://purl.oclc.org/NET/muo/muo#preferredUnit</seealso>
    let preferredUnit = Prefixed_Name(muo, "preferredUnit") |> PrefixedName

    /// <summary>
    ///   <para>muo:propertyMeasuresQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The physical quality measured by a muo:qualityValue subproperty (e.g. weight)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Property Measures Quality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/muo#propertyMeasuresQuality">http://purl.oclc.org/NET/muo/muo#propertyMeasuresQuality</seealso>
    let propertyMeasuresQuality =
        Prefixed_Name(muo, "propertyMeasuresQuality") |> PrefixedName

    /// <summary>
    ///   <para>muo:qualityLiteralValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/muo#qualityLiteralValue">http://purl.oclc.org/NET/muo/muo#qualityLiteralValue</seealso>
    let qualityLiteralValue = Prefixed_Name(muo, "qualityLiteralValue") |> PrefixedName
    /// <summary>
    ///   <para>muo:qualityValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>"The quality value of a measurable physical quality of an entity or phenomenon.
    ///       "</para>
    /// labels<para>"Quality value"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/muo#qualityValue">http://purl.oclc.org/NET/muo/muo#qualityValue</seealso>
    let qualityValue = Prefixed_Name(muo, "qualityValue") |> PrefixedName

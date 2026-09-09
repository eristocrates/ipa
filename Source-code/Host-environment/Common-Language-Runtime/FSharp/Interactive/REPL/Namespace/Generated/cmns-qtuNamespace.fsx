#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``cmns-qtu`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/QuantitiesAndUnits/" "cmns-qtu"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : arbitrary unit^^xsd:string</para>
    ///   <para>dct:source : ISO 11240 Health informatics - Identification of medicinal products - Data elements and structures for the unique identification and exchange of units of measurement, clause 3.1.1^^xsd:string</para>
    ///   <para>skos:definition : arbitrarily defined unit of measurement, where a relation of the unit to a physical unit of the SI does not exist or is unknown^^xsd:string</para>
    ///   <para>skos:note : Arbitrary units represent references to materials or procedures that are defined outside of the SI system. A quantity value is arbitrarily assigned to the reference preparation or the result of a measurement procedure, usually specific for a particular substance. This generally precludes comparability of quantity values across different systems and components for this type of units.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/ArbitraryUnit">cmns-qtu:ArbitraryUnit</a>
    /// </summary>
    let ArbitraryUnit = _prefixId.prefix "ArbitraryUnit"
    /// <summary>
    ///   <para>rdfs:label : base quantity kind^^xsd:string</para>
    ///   <para>dct:source : ISO 11240 Health informatics - Identification of medicinal products - Data elements and structures for the unique identification and exchange of units of measurement, clause 3.1.2^^xsd:stringdct:source : ISO 80000-1:2009 Quantities and units - Part 1: General, clause 3.4^^xsd:stringdct:source : https://www.omg.org/spec/SysML/^^xsd:anyURI</para>
    ///   <para>skos:definition : quantity in a conventionally chosen subset of a given system of quantities, where no quantity in the subset can be expressed in terms of the other quantities within that subset^^xsd:string</para>
    ///   <para>skos:example : The International System of Quantities (ISQ) comprises these base quantities (with their SI base measurement units): length (meter), mass (kilogram), duration (second), electric current (ampere), thermodynamic temperature (kelvin), amount of substance (mole), and luminous intensity (candela). These base quantities are not mutually comparable. All quantities of any one of these kinds are, however, mutually comparable.^^xsd:string</para>
    ///   <para>skos:note : The subset mentioned in the definition is termed the 'set of base quantities'. Base quantities are referred to as being mutually independent since a base quantity cannot be expressed as a product of powers of the other base quantities.^^xsd:string</para>
    ///   <para>cmns-av:synonym : base quantity^^xsd:stringcmns-av:synonym : simple quantity kind^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/BaseQuantityKind">cmns-qtu:BaseQuantityKind</a>
    /// </summary>
    let BaseQuantityKind = _prefixId.prefix "BaseQuantityKind"
    /// <summary>
    ///   <para>rdfs:label : base unit^^xsd:string</para>
    ///   <para>dct:source : ISO 11240 Health informatics - Identification of medicinal products - Data elements and structures for the unique identification and exchange of units of measurement, clause 3.1.3^^xsd:stringdct:source : ISO 80000-1:2009 Quantities and units - Part 1: General, clause 3.10^^xsd:stringdct:source : https://www.omg.org/spec/SysML/^^xsd:anyURI</para>
    ///   <para>skos:definition : measurement unit that is defined by a system of units to be the reference measurement unit for a base quantity^^xsd:string</para>
    ///   <para>skos:example : In the SI, the meter is the base unit of length. In the CGS systems, the centimeter is the base unit of length.^^xsd:string</para>
    ///   <para>skos:note : In each coherent system of units, there is only one base unit for each base quantity. A base unit may also serve for a derived quantity of the same quantity dimension.^^xsd:string</para>
    ///   <para>cmns-av:synonym : simple unit^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/BaseUnit">cmns-qtu:BaseUnit</a>
    /// </summary>
    let BaseUnit = _prefixId.prefix "BaseUnit"
    /// <summary>
    ///   <para>rdfs:label : coherent derived unit^^xsd:string</para>
    ///   <para>dct:source : ISO 11240 Health informatics - Identification of medicinal products - Data elements and structures for the unique identification and exchange of units of measurement, clause 3.1.4^^xsd:stringdct:source : ISO 80000-1:2009 Quantities and units - Part 1: General, clause 3.12^^xsd:string</para>
    ///   <para>skos:definition : derived unit that, for a given system of quantities and for a chosen set of base units, is a product of powers of base units with no other proportionality factor than one^^xsd:string</para>
    ///   <para>skos:example : If the meter, the second, and the mole are base units, the mole per cubic meter is the coherent derived unit of amount-of-substance concentration when amount-of-substance concentration is defined by the quantity equation c = n/V. The kilometer per hour and the knot, given as examples of derived units, are not coherent derived units in such a system of quantities.^^xsd:string</para>
    ///   <para>skos:note : A power of a base unit is the base unit raised to an exponent. Coherence can be determined only with respect to a particular system of quantities and a given set of base units.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/CoherentDerivedUnit">cmns-qtu:CoherentDerivedUnit</a>
    /// </summary>
    let CoherentDerivedUnit = _prefixId.prefix "CoherentDerivedUnit"
    /// <summary>
    ///   <para>rdfs:label : constant^^xsd:string</para>
    ///   <para>skos:definition : symbol that represents a value that does not change (i.e., is fixed) with respect to a formula or expression^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/Constant">cmns-qtu:Constant</a>
    /// </summary>
    let Constant = _prefixId.prefix "Constant"
    /// <summary>
    ///   <para>rdfs:label : conversion-based unit^^xsd:string</para>
    ///   <para>dct:source : https://www.omg.org/spec/SysML/^^xsd:anyURI</para>
    ///   <para>skos:definition : derived unit that is defined with respect to another reference unit through an explicit conversion relationship^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/ConversionBasedUnit">cmns-qtu:ConversionBasedUnit</a>
    /// </summary>
    let ConversionBasedUnit = _prefixId.prefix "ConversionBasedUnit"
    /// <summary>
    ///   <para>rdfs:label : conversion factor between units^^xsd:string</para>
    ///   <para>dct:source : ISO 11240 Health informatics - Identification of medicinal products - Data elements and structures for the unique identification and exchange of units of measurement, clause 3.1.6^^xsd:stringdct:source : ISO 80000-1:2009 Quantities and units - Part 1: General, clause 3.24^^xsd:string</para>
    ///   <para>skos:definition : ratio of two measurement units for quantities of the same kind^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/ConversionFactorBetweenUnits">cmns-qtu:ConversionFactorBetweenUnits</a>
    /// </summary>
    let ConversionFactorBetweenUnits = _prefixId.prefix "ConversionFactorBetweenUnits"
    /// <summary>
    ///   <para>rdfs:label : cyclic ratio scale^^xsd:string</para>
    ///   <para>dct:source : https://www.omg.org/spec/SysML/^^xsd:anyURI</para>
    ///   <para>skos:definition : measurement scale that represents a ratio scale with a periodic cycle^^xsd:string</para>
    ///   <para>skos:example : 'cyclic degree' (to express planar angular measures) with modulus = 360 and unit 'degree'^^xsd:stringskos:example : 'hour of day' with modulus = 24 and unit 'hour'^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/CyclicRatioScale">cmns-qtu:CyclicRatioScale</a>
    /// </summary>
    let CyclicRatioScale = _prefixId.prefix "CyclicRatioScale"
    /// <summary>
    ///   <para>rdfs:label : derived quantity kind^^xsd:string</para>
    ///   <para>dct:source : ISO 11240 Health informatics - Identification of medicinal products - Data elements and structures for the unique identification and exchange of units of measurement, clause 3.1.7^^xsd:stringdct:source : ISO 80000-1:2009 Quantities and units - Part 1: General, clause 3.5^^xsd:stringdct:source : https://www.omg.org/spec/SysML/^^xsd:anyURI</para>
    ///   <para>skos:definition : quantity, in a system of quantities, defined in terms of the base quantities of that system^^xsd:string</para>
    ///   <para>skos:example : In a system of quantities having the base quantities length and mass, mass density is a derived quantity defined as the quotient of mass and volume (length to the power three).^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/DerivedQuantityKind">cmns-qtu:DerivedQuantityKind</a>
    /// </summary>
    let DerivedQuantityKind = _prefixId.prefix "DerivedQuantityKind"
    /// <summary>
    ///   <para>rdfs:label : derived unit^^xsd:string</para>
    ///   <para>dct:source : ISO 11240 Health informatics - Identification of medicinal products - Data elements and structures for the unique identification and exchange of units of measurement, clause 3.1.8^^xsd:stringdct:source : ISO 80000-1:2009 Quantities and units - Part 1: General, clause 3.11^^xsd:stringdct:source : https://www.omg.org/spec/SysML/^^xsd:anyURI</para>
    ///   <para>skos:definition : measurement unit for a derived quantity, i.e., one that is defined with respect to one or more base units, such as as a product of powers of one or more other measurement units^^xsd:string</para>
    ///   <para>skos:example : The meter per second, symbol m/s, and the centimeter per second, symbol cm/s, are derived units of speed in the SI. The kilometer per hour, symbol km/h, is a measurement unit of speed outside the SI but accepted for use with the SI. The knot, equal to one nautical mile per hour, is a measurement unit of speed outside the SI.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/DerivedUnit">cmns-qtu:DerivedUnit</a>
    /// </summary>
    let DerivedUnit = _prefixId.prefix "DerivedUnit"
    /// <summary>
    ///   <para>rdfs:label : dimensionless quantity^^xsd:string</para>
    ///   <para>dct:source : ISO 11240 Health informatics - Identification of medicinal products - Data elements and structures for the unique identification and exchange of units of measurement, clause 3.1.10^^xsd:stringdct:source : ISO 80000-1:2009 Quantities and units - Part 1: General, clause 3.8^^xsd:stringdct:source : https://www.omg.org/spec/SysML/^^xsd:anyURI</para>
    ///   <para>skos:definition : quantity for which all the exponents of the factors corresponding to the base quantities in its quantity dimension are zero^^xsd:string</para>
    ///   <para>skos:example : Plane angle, solid angle, refractive index, relative permeability, mass fraction, friction factor, Mach number^^xsd:string</para>
    ///   <para>skos:note : Some quantities of dimension one are defined as the ratios of two quantities of the same kind. The coherent derived unit is the number one, symbol 1.^^xsd:stringskos:note : The measurement units and values of quantities of dimension one are numbers, but such quantities convey more information than a number.^^xsd:stringskos:note : The term 'dimensionless quantity' is commonly used and is included for historical reasons. It stems from the fact that all exponents are zero in the symbolic representation of the dimension for such quantities. The term 'quantity of dimension one' reflects the convention in which the symbolic representation of the dimension for such quantities is the symbol 1. This dimension is not a number, but the neutral element for multiplication of dimensions.^^xsd:string</para>
    ///   <para>cmns-av:synonym : quantity of dimension one^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/DimensionlessQuantity">cmns-qtu:DimensionlessQuantity</a>
    /// </summary>
    let DimensionlessQuantity = _prefixId.prefix "DimensionlessQuantity"
    /// <summary>
    ///   <para>rdfs:label : expression^^xsd:string</para>
    ///   <para>skos:definition : finite combination of symbols that are well-formed according to applicable rules^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/Expression">cmns-qtu:Expression</a>
    /// </summary>
    let Expression = _prefixId.prefix "Expression"
    /// <summary>
    ///   <para>rdfs:label : factor^^xsd:string</para>
    ///   <para>skos:definition : number or quantity that when multiplied with another produces a given number or expression^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/Factor">cmns-qtu:Factor</a>
    /// </summary>
    let Factor = _prefixId.prefix "Factor"

    let InternationalSystemOfQuantities =
        _prefixId.prefix "InternationalSystemOfQuantities"

    let InternationalSystemOfUnits = _prefixId.prefix "InternationalSystemOfUnits"
    /// <summary>
    ///   <para>rdfs:label : interval scale^^xsd:string</para>
    ///   <para>dct:source : https://plato.stanford.edu/entries/measurement-science/^^xsd:anyURIdct:source : https://www.omg.org/spec/SysML/^^xsd:anyURIdct:source : https://www.statista.com/statistics-glossary/definition/320/interval_scale/^^xsd:anyURI</para>
    ///   <para>skos:definition : measurement scale that represents quantitative values and for which mode, median and mean can be calculated^^xsd:string</para>
    ///   <para>skos:example : Celsius and Fahrenheit are examples of interval scales: they represent equality or inequality among intervals of temperature, but not ratios of temperature, because their zero points are arbitrary. Rating scales, where it is assumed that the distances between the single expressions of evaluation (score) are equal, are also interval scales with no natural zero point.^^xsd:string</para>
    ///   <para>skos:note : Linear interval scales allow both multiplication by a positive number and a constant shift, e.g., the conversion from Celsius to Fahrenheit.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/IntervalScale">cmns-qtu:IntervalScale</a>
    /// </summary>
    let IntervalScale = _prefixId.prefix "IntervalScale"
    /// <summary>
    ///   <para>rdfs:label : logarithmic scale^^xsd:string</para>
    ///   <para>dct:source : https://en.wikipedia.org/wiki/Logarithmic_scale/^^xsd:anyURIdct:source : https://plato.stanford.edu/entries/measurement-science/^^xsd:anyURIdct:source : https://www.omg.org/spec/SysML/^^xsd:anyURI</para>
    ///   <para>skos:definition : measurement scale on which the actual distance of a point from the scale's zero is proportional to the logarithm of the corresponding scale number rather than to the number itself^^xsd:string</para>
    ///   <para>skos:example : A logarithmic scale (or log scale) is a way of displaying numerical data over a very wide range of values in a compact way - typically the largest numbers in the data are hundreds or even thousands of times larger than the smallest numbers. Such a scale is nonlinear: the numbers 10 and 20, and 60 and 70, are not the same distance apart on a log scale. Rather, the numbers 10 and 100, and 60 and 600 are equally spaced. Thus moving a unit of distance along the scale means the number has been multiplied by 10 (or some other fixed factor).^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/LogarithmicScale">cmns-qtu:LogarithmicScale</a>
    /// </summary>
    let LogarithmicScale = _prefixId.prefix "LogarithmicScale"
    /// <summary>
    ///   <para>rdfs:label : material measure^^xsd:string</para>
    ///   <para>dct:source : ISO 11240 Health informatics - Identification of medicinal products - Data elements and structures for the unique identification and exchange of units of measurement, clause 3.1.14^^xsd:string</para>
    ///   <para>skos:definition : something that reproduces or supplies one or more quantities, each with an assigned quantity value^^xsd:string</para>
    ///   <para>skos:example : Ruler, standard weight, volume measure^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/MaterialMeasure">cmns-qtu:MaterialMeasure</a>
    /// </summary>
    let MaterialMeasure = _prefixId.prefix "MaterialMeasure"
    /// <summary>
    ///   <para>rdfs:label : measure^^xsd:string</para>
    ///   <para>dct:source : https://stats.oecd.org/glossary/detail.asp?ID=7062^^xsd:anyURI</para>
    ///   <para>skos:definition : amount or degree of something; the dimensions, capacity, or amount of something ascertained by measuring^^xsd:string</para>
    ///   <para>skos:note : Measure refers to the phenomenon or phenomena to be measured in a data set. In a data set, the instance of a measure is often called an observation.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/Measure">cmns-qtu:Measure</a>
    /// </summary>
    let Measure = _prefixId.prefix "Measure"
    /// <summary>
    ///   <para>rdfs:label : measurement procedure^^xsd:string</para>
    ///   <para>skos:definition : procedure of a measurement according to one or more measurement principles (i.e. phenomena, observables) and a given measurement method, based on a measurement model and including any calculation to obtain a measurement result^^xsd:string</para>
    ///   <para>skos:example : Lowering of the concentration of glucose in blood in a fasting rabbit is an observable that can be applied to the measurement of insulin concentration in a preparation. Together with a description of the measurement method this can be used to define a measurement procedure.^^xsd:string</para>
    ///   <para>skos:note : A measurement procedure can include a statement concerning a target measurement uncertainty.^^xsd:stringskos:note : A measurement procedure is usually documented in sufficient detail to enable an operator to perform a measurement.^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : SOP^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 11240 Health informatics - Identification of medicinal products - Data elements and structures for the unique identification and exchange of units of measurement, clause 3.1.16^^xsd:string</para>
    ///   <para>cmns-av:synonym : standard operating procedure^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/MeasurementProcedure">cmns-qtu:MeasurementProcedure</a>
    /// </summary>
    let MeasurementProcedure = _prefixId.prefix "MeasurementProcedure"
    /// <summary>
    ///   <para>rdfs:label : measurement reference^^xsd:string</para>
    ///   <para>skos:definition : measurement unit, measurement procedure, reference material, or a combination of such^^xsd:string</para>
    ///   <para>skos:note : Note that the concept of a measurement reference is currently not defined in terms and definitions in the VIM standard, but rather in Note 2 on quantity.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : International Vocabulary of Metrology - Basic and General Concepts and Associated Terms (VIM), Third Edition, JCGM 200:2012, available at https://www.bipm.org/documents/20126/2071204/JCGM_200_2012.pdf^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/MeasurementReference">cmns-qtu:MeasurementReference</a>
    /// </summary>
    let MeasurementReference = _prefixId.prefix "MeasurementReference"
    /// <summary>
    ///   <para>rdfs:label : measurement scale^^xsd:string</para>
    ///   <para>dct:source : ISO 80000-1:2009 Quantities and units - Part 1: General, clause 3.27^^xsd:stringdct:source : https://plato.stanford.edu/entries/measurement-science/^^xsd:anyURIdct:source : https://www.omg.org/spec/SysML/^^xsd:anyURI</para>
    ///   <para>skos:definition : ordered set of quantity values of quantities of a given kind of quantity used in ranking, according to magnitude, quantities of that kind^^xsd:string</para>
    ///   <para>skos:note : Note that the majority of scalar quantities can be expressed by just using a MeasurementUnit directly as its measurement reference. This implies expression of a scalar quantity value on a ratio scale. However, for full coverage of all quantity value expressions, additional explicit measurement scales with additional semantics are needed, such as ordinal scale, interval scale, ratio scale with additional limit values, cyclic ratio scale and logarithmic scale.^^xsd:string</para>
    ///   <para>cmns-av:synonym : quantity-value scale^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/MeasurementScale">cmns-qtu:MeasurementScale</a>
    /// </summary>
    let MeasurementScale = _prefixId.prefix "MeasurementScale"
    /// <summary>
    ///   <para>rdfs:label : measurement unit^^xsd:string</para>
    ///   <para>dct:source : ISO 11240 Health informatics - Identification of medicinal products - Data elements and structures for the unique identification and exchange of units of measurement, clause 3.1.33^^xsd:stringdct:source : ISO 80000-1:2009 Quantities and units - Part 1: General, clause 3.9^^xsd:stringdct:source : https://www.omg.org/spec/SysML/^^xsd:anyURI</para>
    ///   <para>skos:definition : real scalar quantity, defined and adopted by convention, with which any other quantity of the same kind can be compared to express the ratio of the second quantity to the first one as a number^^xsd:string</para>
    ///   <para>skos:example : week, day, hour, minute, second, kilogram, joule, meter^^xsd:string</para>
    ///   <para>skos:note : A Unit is a quantity in terms of which the magnitudes of other quantities that have the same quantity kind can be stated. A unit often relies on precise and reproducible ways to measure the unit. For example, a unit of length such as meter may be specified as a multiple of a particular wavelength of light. A unit may also specify less stable or precise ways to express some value, such as a cost expressed in some currency, or a severity rating measured by a numerical scale.^^xsd:stringskos:note : Depending on the nature of the reference scale, the unit of measurement expression may stand either for a physical unit of measurement that is related to a system of quantities (e.g. SI units) or for an arbitrarily defined unit of measurement, which may refer to a certain reference material, a standard measurement procedure, a material measure or even to a combination of those.^^xsd:stringskos:note : For a given quantity, the short term 'unit' is often combined with the quantity name, such as 'mass unit' or 'unit of mass'.^^xsd:stringskos:note : Measurement units are designated by conventionally assigned names and symbols.^^xsd:stringskos:note : Measurement units of quantities of dimension one are numbers. In some cases, these measurement units are given special names, e.g. radian, steradian, and decibel, or are expressed by quotients such as millimole per mole equal to 10 to the power minus 3 and microgram per kilogram equal to 10 to the power minus 9.^^xsd:stringskos:note : Measurement units of quantities of the same quantity dimension may be designated by the same name and symbol even when the quantities are not of the same kind. For example, joule per kelvin and J/K are respectively the name and symbol of both a measurement unit of heat capacity and a measurement unit of entropy, which are generally not considered to be quantities of the same kind. However, in some cases special measurement unit names are restricted to be used with quantities of specific kind only. For example, the measurement unit 'second to the power minus one' (1/s) is called hertz (Hz) when used for frequencies and becquerel (Bq) when used for activities of radionuclides. As another example, the joule (J) is used as a unit of energy, but never as a unit of moment of force, i.e. the newton meter (N m).^^xsd:string</para>
    ///   <para>cmns-av:synonym : unit of measurement^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/MeasurementUnit">cmns-qtu:MeasurementUnit</a>
    /// </summary>
    let MeasurementUnit = _prefixId.prefix "MeasurementUnit"
    /// <summary>
    ///   <para>rdfs:label : nominal scale^^xsd:string</para>
    ///   <para>dct:source : https://plato.stanford.edu/entries/measurement-science/^^xsd:anyURIdct:source : https://www.ncbi.nlm.nih.gov/pmc/articles/PMC4589638/^^xsd:anyURI</para>
    ///   <para>skos:definition : measurement scale that represents objects as belonging to classes that have no particular order^^xsd:string</para>
    ///   <para>skos:example : Many nominal scales are qualitative in nature. A common example of a nominal scale is that of gender identity, which is a way of describing one's persistent inner concept of their gender. While the terminology from a psychological and medical perspective continues to evolve, the scale covers individuals who self identify as male or female as well as those that have a less determinant perspective, such as transsexual or non-binary.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/NominalScale">cmns-qtu:NominalScale</a>
    /// </summary>
    let NominalScale = _prefixId.prefix "NominalScale"
    /// <summary>
    ///   <para>rdfs:label : ordinal scale^^xsd:string</para>
    ///   <para>dct:source : ISO 80000-1:2009 Quantities and units - Part 1: General, clause 3.28^^xsd:stringdct:source : https://plato.stanford.edu/entries/measurement-science/^^xsd:anyURIdct:source : https://www.omg.org/spec/SysML/^^xsd:anyURI</para>
    ///   <para>skos:definition : quantity-value scale for ordinal quantities, i.e., one that represents order but no further algebraic structure^^xsd:string</para>
    ///   <para>skos:example : For example, the Mohs scale of mineral hardness represents minerals with numbers ranging from 1 (softest) to 10 (hardest), but there is no empirical significance to equality among intervals or ratios of those numbers.^^xsd:string</para>
    ///   <para>skos:note : An ordinal quantity-value scale may be established by measurements according to a measurement procedure.^^xsd:stringskos:note : Ordinal scales allow any transformation function as long as it is monotonic and increasing.^^xsd:string</para>
    ///   <para>cmns-av:synonym : ordinal quantity-value scale^^xsd:stringcmns-av:synonym : ordinal value scale^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/OrdinalScale">cmns-qtu:OrdinalScale</a>
    /// </summary>
    let OrdinalScale = _prefixId.prefix "OrdinalScale"
    /// <summary>
    ///   <para>rdfs:label : percentage^^xsd:string</para>
    ///   <para>skos:definition : ratio value expressed as a fraction of 100, i.e., in which the denominator is fixed rather than variable and equal to 100^^xsd:string</para>
    ///   <para>skos:note : The percent value is computed by multiplying the numeric value of the ratio by 100.^^xsd:stringskos:note : While many percentage values are between 0 and 100, there is no mathematical restriction and percentages may take on other values (positive or negative), particularly in the case of comparisons (percent change).^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/Percentage">cmns-qtu:Percentage</a>
    /// </summary>
    let Percentage = _prefixId.prefix "Percentage"
    /// <summary>
    ///   <para>rdfs:label : physical unit^^xsd:string</para>
    ///   <para>dct:source : ISO 11240 Health informatics - Identification of medicinal products - Data elements and structures for the unique identification and exchange of units of measurement, clause 3.1.21^^xsd:string</para>
    ///   <para>skos:definition : unit of measurement that is defined using a physical quantity^^xsd:string</para>
    ///   <para>skos:note : Its definition relates measured quantities to the base quantities through a set of well-defined equations.^^xsd:stringskos:note : Physical units and their related scales are defined independently of the measurement procedure and the measured components. They relate to an internationally standardized system of units and equations governing the mathematical relations between those units.^^xsd:string</para>
    ///   <para>cmns-av:synonym : physical unit of measurement^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/PhysicalUnit">cmns-qtu:PhysicalUnit</a>
    /// </summary>
    let PhysicalUnit = _prefixId.prefix "PhysicalUnit"
    /// <summary>
    ///   <para>rdfs:label : prefix^^xsd:string</para>
    ///   <para>dct:source : ISO 11240 Health informatics - Identification of medicinal products - Data elements and structures for the unique identification and exchange of units of measurement, clause 3.1.22^^xsd:string</para>
    ///   <para>skos:definition : named multiple or sub-multiple multiplication factor used in the specification of a derived unit^^xsd:string</para>
    ///   <para>skos:note : A prefix is a word or symbol for attachment to the name or symbol of a unit in order to form units that are multiples or sub-multiples of that unit.^^xsd:stringskos:note : A system of units may specify a set of prefixes.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/Prefix">cmns-qtu:Prefix</a>
    /// </summary>
    let Prefix = _prefixId.prefix "Prefix"
    /// <summary>
    ///   <para>rdfs:label : prefixed unit^^xsd:string</para>
    ///   <para>dct:source : https://www.omg.org/spec/SysML/^^xsd:anyURI</para>
    ///   <para>skos:definition : conversion-based unit that is defined with respect to another measurement reference unit through a linear conversion relationship with a named prefix that represents a multiple or submultiple of a unit^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/PrefixedUnit">cmns-qtu:PrefixedUnit</a>
    /// </summary>
    let PrefixedUnit = _prefixId.prefix "PrefixedUnit"
    /// <summary>
    ///   <para>rdfs:label : quantity dimension^^xsd:string</para>
    ///   <para>dct:source : ISO 11240 Health informatics - Identification of medicinal products - Data elements and structures for the unique identification and exchange of units of measurement, clause 3.1.9^^xsd:stringdct:source : ISO 80000-1:2009 Quantities and units - Part 1: General, clause 3.7^^xsd:stringdct:source : https://www.omg.org/spec/SysML/^^xsd:anyURI</para>
    ///   <para>skos:definition : expression of the dependence of a quantity on the base quantities of a system of quantities as a product of powers of factors corresponding to the base quantities, omitting any numerical factor^^xsd:string</para>
    ///   <para>skos:note : A power of a factor is the factor raised to an exponent. Each factor is the dimension of a base quantity.^^xsd:stringskos:note : In a given system of quantities,
    /// - quantities of the same kind have the same quantity dimension,
    /// - quantities of different quantity dimensions are always of different kinds, and
    /// - quantities having the same quantity dimension are not necessarily of the same kind.^^xsd:stringskos:note : In deriving the dimension of a quantity, no account is taken of its scalar, vector, or tensor character.^^xsd:stringskos:note : The conventional symbolic representation of the dimension of a base quantity is a single upper case letter in roman (upright) type. The conventional symbolic representation of the dimension of a derived quantity is the product of powers of the dimensions of the base quantities according to the definition of the derived quantity. The dimension of a quantity Q is denoted by dim Q.^^xsd:string</para>
    ///   <para>cmns-av:synonym : dimension^^xsd:stringcmns-av:synonym : dimension of a quantity^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/QuantityDimension">cmns-qtu:QuantityDimension</a>
    /// </summary>
    let QuantityDimension = _prefixId.prefix "QuantityDimension"
    /// <summary>
    ///   <para>rdfs:label : quantity kind^^xsd:string</para>
    ///   <para>dct:source : ISO 11240 Health informatics - Identification of medicinal products - Data elements and structures for the unique identification and exchange of units of measurement, clause 3.1.12^^xsd:stringdct:source : ISO 80000-1:2009 Quantities and units - Part 1: General, clause 3.2^^xsd:stringdct:source : https://www.omg.org/spec/SysML/^^xsd:anyURI</para>
    ///   <para>skos:definition : aspect common to mutually comparable quantities^^xsd:string</para>
    ///   <para>skos:example : The quantities diameter, circumference, and wavelength are generally considered to be quantities of the same kind, namely, of the kind of quantity called length.^^xsd:stringskos:example : The quantities heat, kinetic energy, and potential energy are generally considered to be quantities of the same kind, namely, of the kind of quantity called energy.^^xsd:stringskos:example : The quantities moment of force and energy are, by convention, not regarded as being of the same kind, although they have the same dimension. Similarly for heat capacity and entropy, as well as for number of entities, relative permeability, and mass fraction.^^xsd:string</para>
    ///   <para>skos:note : Quantities of the same kind within a given system of quantities have the same quantity dimension. However, quantities of the same dimension are not necessarily of the same kind.^^xsd:string</para>
    ///   <para>cmns-av:synonym : kind of quantity^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/QuantityKind">cmns-qtu:QuantityKind</a>
    /// </summary>
    let QuantityKind = _prefixId.prefix "QuantityKind"
    /// <summary>
    ///   <para>rdfs:label : quantity kind power factor^^xsd:string</para>
    ///   <para>dct:source : https://www.omg.org/spec/SysML/^^xsd:anyURI</para>
    ///   <para>skos:definition : factor in a product of powers that defines a derived quantity^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/QuantityKindPowerFactor">cmns-qtu:QuantityKindPowerFactor</a>
    /// </summary>
    let QuantityKindPowerFactor = _prefixId.prefix "QuantityKindPowerFactor"
    /// <summary>
    ///   <para>rdfs:label : quantity name^^xsd:string</para>
    ///   <para>skos:definition : human-readable textual representation of the quantity^^xsd:string</para>
    ///   <para>skos:note : A number of systems of quantities and units encode a quantity, such as a unit of measure, via a generally accepted abbreviation. URIs representing such quantities are very useful in applications that require globally unique, machine readable names, but are less accessible to people. This concept is intended to provide the corresponding name for a given quantity in the context of a specific system of quantities and units for human consumption.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/QuantityName">cmns-qtu:QuantityName</a>
    /// </summary>
    let QuantityName = _prefixId.prefix "QuantityName"
    /// <summary>
    ///   <para>rdfs:label : ratio^^xsd:string</para>
    ///   <para>dct:source : https://stats.oecd.org/glossary/detail.asp?ID=6688^^xsd:anyURIdct:source : https://www150.statcan.gc.ca/n1/edu/power-pouvoir/glossary-glossaire/5214842-eng.htm#r^^xsd:anyURI</para>
    ///   <para>skos:definition : proportional relationship between two different quantity values that gives rise to a datum of a specific quantity kind^^xsd:string</para>
    ///   <para>skos:note : A ratio is a quantity measured with respect to some other quantity, or in mathematics a quotient of two numbers or expressions, arrived at by dividing one by the other.^^xsd:string</para>
    ///   <para>cmns-av:synonym : rate^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/Ratio">cmns-qtu:Ratio</a>
    /// </summary>
    let Ratio = _prefixId.prefix "Ratio"
    /// <summary>
    ///   <para>rdfs:label : ratio scale^^xsd:string</para>
    ///   <para>dct:source : https://plato.stanford.edu/entries/measurement-science/^^xsd:anyURIdct:source : https://www.omg.org/spec/SysML/^^xsd:anyURI</para>
    ///   <para>skos:definition : measurement scale that represents quantitative values, allows comparison of differences in values, has a fixed zero value and is invariant under multiplication by a positive number^^xsd:string</para>
    ///   <para>skos:example : The Kelvin scale is a ratio scale, as are the familiar scales representing mass in kilograms, length in meters and duration in seconds.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/RatioScale">cmns-qtu:RatioScale</a>
    /// </summary>
    let RatioScale = _prefixId.prefix "RatioScale"

    /// <summary>
    ///   <para>rdfs:label : ratio scale with additional limit values^^xsd:string</para>
    ///   <para>dct:source : https://www.omg.org/spec/SysML/^^xsd:anyURI</para>
    ///   <para>skos:definition : measurement scale that that represents a ratio scale that has additional limit values^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/RatioScaleWithAdditionalLimitValues">cmns-qtu:RatioScaleWithAdditionalLimitValues</a>
    /// </summary>
    let RatioScaleWithAdditionalLimitValues =
        _prefixId.prefix "RatioScaleWithAdditionalLimitValues"

    /// <summary>
    ///   <para>rdfs:label : reference material^^xsd:string</para>
    ///   <para>dct:source : ISO 11240 Health informatics - Identification of medicinal products - Data elements and structures for the unique identification and exchange of units of measurement, clause 3.1.26^^xsd:string</para>
    ///   <para>skos:definition : material, sufficiently homogeneous and stable with reference to specified properties, which has been established to be fit for its intended use in measurement or in examination of nominal properties^^xsd:string</para>
    ///   <para>skos:note : Some reference materials have assigned quantity values that are metrologically traceable to a measurement unit outside a system of units. Such materials include vaccines to which International Units (IU) have been assigned by the World Health Organization (WHO).^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/ReferenceMaterial">cmns-qtu:ReferenceMaterial</a>
    /// </summary>
    let ReferenceMaterial = _prefixId.prefix "ReferenceMaterial"
    /// <summary>
    ///   <para>rdfs:label : scalar quantity^^xsd:string</para>
    ///   <para>dct:source : ISO 11240 Health informatics - Identification of medicinal products - Data elements and structures for the unique identification and exchange of units of measurement, clause 3.1.24^^xsd:stringdct:source : ISO 80000-1:2009 Quantities and units - Part 1: General, clause 3.1^^xsd:stringdct:source : https://www.omg.org/spec/SysML/^^xsd:anyURI</para>
    ///   <para>skos:definition : property of a phenomenon, body, or substance, where the property has a magnitude that can be expressed by means of a number and a reference^^xsd:string</para>
    ///   <para>skos:example : second, kilogram, joule, meter^^xsd:string</para>
    ///   <para>skos:note : A quantity as defined in ISO 80000 is a scalar. However, a vector or a tensor, the components of which are quantities, is also considered to be a quantity.^^xsd:stringskos:note : A reference can be a measurement unit, a measurement procedure, a reference material, or a combination of such.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/ScalarQuantity">cmns-qtu:ScalarQuantity</a>
    /// </summary>
    let ScalarQuantity = _prefixId.prefix "ScalarQuantity"
    /// <summary>
    ///   <para>rdfs:label : scalar quantity value^^xsd:string</para>
    ///   <para>dct:source : ISO 11240 Health informatics - Identification of medicinal products - Data elements and structures for the unique identification and exchange of units of measurement, clauses 3.1.19, 3.1.25^^xsd:stringdct:source : ISO 80000-1:2009 Quantities and units - Part 1: General, clause 3.19^^xsd:stringdct:source : https://www.omg.org/spec/SysML/^^xsd:anyURI</para>
    ///   <para>skos:definition : number and reference together expressing the magnitude of a quantity^^xsd:string</para>
    ///   <para>skos:note : According to the type of reference, a quantity value is either
    /// - a product of a number and a measurement unit; the measurement unit one is generally not indicated for quantities of dimension one, or
    /// - a number and a reference to a measurement procedure, or
    /// - a number and a reference material.^^xsd:string</para>
    ///   <para>cmns-av:synonym : measurement^^xsd:stringcmns-av:synonym : value of a quantity^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/ScalarQuantityValue">cmns-qtu:ScalarQuantityValue</a>
    /// </summary>
    let ScalarQuantityValue = _prefixId.prefix "ScalarQuantityValue"
    /// <summary>
    ///   <para>rdfs:label : scalar quantity value range^^xsd:string</para>
    ///   <para>skos:definition : expression of the lowest possible value and/or highest possible value for some scalar quantity^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/ScalarQuantityValueRange">cmns-qtu:ScalarQuantityValueRange</a>
    /// </summary>
    let ScalarQuantityValueRange = _prefixId.prefix "ScalarQuantityValueRange"
    /// <summary>
    ///   <para>rdfs:label : system of quantities</para>
    ///   <para>dct:source : ISO 11240 Health informatics - Identification of medicinal products - Data elements and structures for the unique identification and exchange of units of measurement, clause 3.1.29^^xsd:stringdct:source : ISO 80000-1:2009 Quantities and units - Part 1: General, clause 3.3^^xsd:stringdct:source : https://www.omg.org/spec/SysML/^^xsd:anyURI</para>
    ///   <para>skos:definition : set of quantities together with a set of non-contradictory equations relating those quantities^^xsd:string</para>
    ///   <para>skos:example : The International System of Quantities (ISQ) is an example of a SystemOfQuantities, defined in ISO 31 and ISO/IEC 80000.^^xsd:string</para>
    ///   <para>skos:note : Ordinal quantities, such as Rockwell C hardness, and nominal properties, such as color of light, are usually not considered to be part of a system of quantities because they are related to other quantities through empirical relations only.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/SystemOfQuantities">cmns-qtu:SystemOfQuantities</a>
    /// </summary>
    let SystemOfQuantities = _prefixId.prefix "SystemOfQuantities"
    /// <summary>
    ///   <para>rdfs:label : system of units^^xsd:string</para>
    ///   <para>dct:source : ISO 11240 Health informatics - Identification of medicinal products - Data elements and structures for the unique identification and exchange of units of measurement, clause 3.1.30^^xsd:stringdct:source : ISO 80000-1:2009 Quantities and units - Part 1: General, clause 3.13^^xsd:stringdct:source : https://www.omg.org/spec/SysML/^^xsd:anyURI</para>
    ///   <para>skos:definition : set of base units and derived units, together with their multiples and submultiples, defined in accordance with given rules, for a given system of quantities^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/SystemOfUnits">cmns-qtu:SystemOfUnits</a>
    /// </summary>
    let SystemOfUnits = _prefixId.prefix "SystemOfUnits"
    /// <summary>
    ///   <para>rdfs:label : total^^xsd:string</para>
    ///   <para>skos:definition : sum of the values for some characteristic of all units^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/Total">cmns-qtu:Total</a>
    /// </summary>
    let Total = _prefixId.prefix "Total"
    /// <summary>
    ///   <para>rdfs:label : unit power factor^^xsd:string</para>
    ///   <para>dct:source : https://www.omg.org/spec/SysML/^^xsd:anyURI</para>
    ///   <para>skos:definition : factor in a product of powers that defines a derived unit^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/UnitPowerFactor">cmns-qtu:UnitPowerFactor</a>
    /// </summary>
    let UnitPowerFactor = _prefixId.prefix "UnitPowerFactor"
    /// <summary>
    ///   <para>rdfs:label : variable^^xsd:string</para>
    ///   <para>skos:definition : symbol that represents a parameter in a formula or expression^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/Variable">cmns-qtu:Variable</a>
    /// </summary>
    let Variable = _prefixId.prefix "Variable"
    /// <summary>
    ///   <para>rdfs:label : describes actual expression^^xsd:string</para>
    ///   <para>skos:definition : specifies the calculation or expression used to determine the value of something^^xsd:string</para>
    ///   <para>skos:note : In cases where some expression can only be calculated in SPARQL or via rules, this property is useful for stating what that calculation should be using the input arguments to the expression.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/describesActualExpression">cmns-qtu:describesActualExpression</a>
    /// </summary>
    let describesActualExpression = _prefixId.prefix "describesActualExpression"
    /// <summary>
    ///   <para>rdfs:label : expresses the magnitude of^^xsd:string</para>
    ///   <para>skos:definition : specifies the quantity that some quantity value reflects^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/expressesTheMagnitudeOf">cmns-qtu:expressesTheMagnitudeOf</a>
    /// </summary>
    let expressesTheMagnitudeOf = _prefixId.prefix "expressesTheMagnitudeOf"
    /// <summary>
    ///   <para>rdfs:label : has argument^^xsd:string</para>
    ///   <para>skos:definition : indicates a specific input to a function, formula or expression, also known as an independent variable^^xsd:string</para>
    ///   <para>skos:scopeNote : Note that this property and its subproperties apply in the context of quantities and units as well as statistical measures. They are not intended to support more general mathematics.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/hasArgument">cmns-qtu:hasArgument</a>
    /// </summary>
    let hasArgument = _prefixId.prefix "hasArgument"
    /// <summary>
    ///   <para>rdfs:label : has denominator^^xsd:string</para>
    ///   <para>skos:definition : specifies the quantity value that is the part of a fraction 'below the line' and signifies the value by which the numerator should be divided^^xsd:string</para>
    ///   <para>skos:note : If a fraction is considered as an ordered pair, the denominator is the second argument of the fraction.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/hasDenominator">cmns-qtu:hasDenominator</a>
    /// </summary>
    let hasDenominator = _prefixId.prefix "hasDenominator"
    /// <summary>
    ///   <para>rdfs:label : has dimension^^xsd:string</para>
    ///   <para>skos:definition : indicates a measurable extent associated with a given quantity kind in some system of quantities, which may be derived, depending on the choice of base quantity^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/hasDimension">cmns-qtu:hasDimension</a>
    /// </summary>
    let hasDimension = _prefixId.prefix "hasDimension"
    /// <summary>
    ///   <para>rdfs:label : has exponent^^xsd:string</para>
    ///   <para>skos:definition : indicates the number of times a number should be multiplied by itself^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/hasExponent">cmns-qtu:hasExponent</a>
    /// </summary>
    let hasExponent = _prefixId.prefix "hasExponent"
    /// <summary>
    ///   <para>rdfs:label : has expression^^xsd:string</para>
    ///   <para>skos:definition : specifies a finite combination of symbols, including constants, variables that may be ordered via one or more operators, that is well-formed according to rules that depend on the language and context^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/hasExpression">cmns-qtu:hasExpression</a>
    /// </summary>
    let hasExpression = _prefixId.prefix "hasExpression"
    /// <summary>
    ///   <para>rdfs:label : has factor^^xsd:string</para>
    ///   <para>skos:definition : indicates a number or quantity that when multiplied with another produces a given number or expression^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/hasFactor">cmns-qtu:hasFactor</a>
    /// </summary>
    let hasFactor = _prefixId.prefix "hasFactor"
    /// <summary>
    ///   <para>rdfs:label : has factor value^^xsd:string</para>
    ///   <para>skos:definition : indicates the numeric multiple or submultiple multiplication factor^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/hasFactorValue">cmns-qtu:hasFactorValue</a>
    /// </summary>
    let hasFactorValue = _prefixId.prefix "hasFactorValue"
    /// <summary>
    ///   <para>rdfs:label : has lower bound^^xsd:string</para>
    ///   <para>skos:definition : specifies the quantity value that is the lower value of a pair of values representing a range^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/hasLowerBound">cmns-qtu:hasLowerBound</a>
    /// </summary>
    let hasLowerBound = _prefixId.prefix "hasLowerBound"
    /// <summary>
    ///   <para>rdfs:label : has maximum permissive value^^xsd:string</para>
    ///   <para>skos:definition : indicates the maximum allowed value for a measurement on the given scale^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/hasMaximumPermissiveValue">cmns-qtu:hasMaximumPermissiveValue</a>
    /// </summary>
    let hasMaximumPermissiveValue = _prefixId.prefix "hasMaximumPermissiveValue"
    /// <summary>
    ///   <para>rdfs:label : has measurement reference^^xsd:string</para>
    ///   <para>skos:definition : indicates the reference against which a quantity can be expressed with respect to a number^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/hasMeasurementReference">cmns-qtu:hasMeasurementReference</a>
    /// </summary>
    let hasMeasurementReference = _prefixId.prefix "hasMeasurementReference"
    /// <summary>
    ///   <para>rdfs:label : has measurement unit^^xsd:string</para>
    ///   <para>skos:definition : indicates the unit against which a quantity can be expressed in a quantity value^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/hasMeasurementUnit">cmns-qtu:hasMeasurementUnit</a>
    /// </summary>
    let hasMeasurementUnit = _prefixId.prefix "hasMeasurementUnit"
    /// <summary>
    ///   <para>rdfs:label : has minimum permissive value^^xsd:string</para>
    ///   <para>skos:definition : indicates the minimum allowed value for a measurement on the given scale^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/hasMinimumPermissiveValue">cmns-qtu:hasMinimumPermissiveValue</a>
    /// </summary>
    let hasMinimumPermissiveValue = _prefixId.prefix "hasMinimumPermissiveValue"
    /// <summary>
    ///   <para>rdfs:label : has numerator^^xsd:string</para>
    ///   <para>skos:definition : specifies the quantity value that is the part of a fraction 'above the line' and signifies the value to be divided by the denominator^^xsd:string</para>
    ///   <para>skos:note : If a fraction is considered as an ordered pair, the numerator is the first argument of the fraction.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/hasNumerator">cmns-qtu:hasNumerator</a>
    /// </summary>
    let hasNumerator = _prefixId.prefix "hasNumerator"
    /// <summary>
    ///   <para>rdfs:label : has numeric value^^xsd:string</para>
    ///   <para>dct:source : https://www.omg.org/spec/SysML/^^xsd:anyURI</para>
    ///   <para>skos:definition : indicates a particular magnitude or designation for a given observable characteristic that is a number^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/hasNumericValue">cmns-qtu:hasNumericValue</a>
    /// </summary>
    let hasNumericValue = _prefixId.prefix "hasNumericValue"
    /// <summary>
    ///   <para>rdfs:label : has quantity kind^^xsd:string</para>
    ///   <para>skos:definition : indicates the class of mutually comparable quantities involved in the definition of an individual quantity or factor^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/hasQuantityKind">cmns-qtu:hasQuantityKind</a>
    /// </summary>
    let hasQuantityKind = _prefixId.prefix "hasQuantityKind"
    /// <summary>
    ///   <para>rdfs:label : has quantity value^^xsd:string</para>
    ///   <para>skos:definition : relates something (an expression, formula, etc.) to its magnitude expressed as a number together with its unit of measure (if applicable)^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/hasQuantityValue">cmns-qtu:hasQuantityValue</a>
    /// </summary>
    let hasQuantityValue = _prefixId.prefix "hasQuantityValue"
    /// <summary>
    ///   <para>rdfs:label : has quantity value range^^xsd:string</para>
    ///   <para>skos:definition : relates something (an expression, formula, etc.) to its magnitude expressed as range of numbers together with their unit(s) of measure (if applicable)^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/hasQuantityValueRange">cmns-qtu:hasQuantityValueRange</a>
    /// </summary>
    let hasQuantityValueRange = _prefixId.prefix "hasQuantityValueRange"
    /// <summary>
    ///   <para>rdfs:label : has upper bound^^xsd:string</para>
    ///   <para>skos:definition : specifies the quantity value that is the higher value of a pair of values representing a range^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/hasUpperBound">cmns-qtu:hasUpperBound</a>
    /// </summary>
    let hasUpperBound = _prefixId.prefix "hasUpperBound"
    /// <summary>
    ///   <para>rdfs:label : is derived from^^xsd:string</para>
    ///   <para>skos:definition : indicates something from which the subject is obtained or determined^^xsd:string</para>
    ///   <para>skos:example : a derived quantity is derived from a base quantity; a derived unit is derived from a base unit^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/isDerivedFrom">cmns-qtu:isDerivedFrom</a>
    /// </summary>
    let isDerivedFrom = _prefixId.prefix "isDerivedFrom"
    /// <summary>
    ///   <para>rdfs:label : is dimension of^^xsd:string</para>
    ///   <para>skos:definition : indicates a measurable extent associated with a given quantity kind in some system of quantities, which may be derived, depending on the choice of base quantity^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/isDimensionOf">cmns-qtu:isDimensionOf</a>
    /// </summary>
    let isDimensionOf = _prefixId.prefix "isDimensionOf"
    /// <summary>
    ///   <para>rdfs:label : is maximum inclusive^^xsd:string</para>
    ///   <para>skos:definition : indicates whether something, such as a measurement scale, includes the absolute maximum permissive value or not^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/isMaximumInclusive">cmns-qtu:isMaximumInclusive</a>
    /// </summary>
    let isMaximumInclusive = _prefixId.prefix "isMaximumInclusive"
    /// <summary>
    ///   <para>rdfs:label : is minimum inclusive^^xsd:string</para>
    ///   <para>skos:definition : indicates whether something, such as a measurement scale, includes the absolute minimum permissive value or not^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/isMinimumInclusive">cmns-qtu:isMinimumInclusive</a>
    /// </summary>
    let isMinimumInclusive = _prefixId.prefix "isMinimumInclusive"
    /// <summary>
    ///   <para>rdfs:label : is value of^^xsd:string</para>
    ///   <para>skos:definition : is the measure that the value represents^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/isValueOf">cmns-qtu:isValueOf</a>
    /// </summary>
    let isValueOf = _prefixId.prefix "isValueOf"
    /// <summary>
    ///   <para>rdfs:label : specializes^^xsd:string</para>
    ///   <para>skos:definition : indicates something whose nature is more general (broader than) the subject^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/specializes">cmns-qtu:specializes</a>
    /// </summary>
    let specializes = _prefixId.prefix "specializes"

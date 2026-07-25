namespace http.purl.oclc.org.NET.ssnx.qu.qu.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module qu =
    let _namespace_iri = Namespace_Iri qu |> NamespaceIRI
    /// <summary>
    ///   <para>qu:QuantityKindFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A QuantityKindFactor represents a factor in the product of powers that defines a DerivedQuantityKind.</para>
    /// labels<para>QuantityKindFactor</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#QuantityKindFactor">http://purl.oclc.org/NET/ssnx/qu/qu#QuantityKindFactor</seealso>
    let QuantityKindFactor = Prefixed_Name(qu, "QuantityKindFactor") |> PrefixedName
    /// <summary>
    ///   <para>qu:ScaleValueDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A ScaleValueDefinition represents a specific value for a measurement scale.</para>
    /// labels<para>ScaleValueDefinition</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#ScaleValueDefinition">http://purl.oclc.org/NET/ssnx/qu/qu#ScaleValueDefinition</seealso>
    let ScaleValueDefinition = Prefixed_Name(qu, "ScaleValueDefinition") |> PrefixedName
    /// <summary>
    ///   <para>qu:SystemOfUnits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A SystemOfUnits represents the [VIM] concept of 'system of units' that is defined as 'set of base units and derived units, together with their multiples and submultiples, defined in accordance with given rules, for a given system of quantities'. It collects a list of Unit that are known in the system. A SysML SystemOfUnits only optionally defines multiples and submultiples.</para>
    /// labels<para>SystemOfUnits</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#SystemOfUnits">http://purl.oclc.org/NET/ssnx/qu/qu#SystemOfUnits</seealso>
    let SystemOfUnits = Prefixed_Name(qu, "SystemOfUnits") |> PrefixedName
    /// <summary>
    ///   <para>qu:UnitFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A UnitFactor represents a factor in the product of powers that defines a DerivedUnit.</para>
    /// labels<para>UnitFactor</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#UnitFactor">http://purl.oclc.org/NET/ssnx/qu/qu#UnitFactor</seealso>
    let UnitFactor = Prefixed_Name(qu, "UnitFactor") |> PrefixedName
    /// <summary>
    ///   <para>qu:Scale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Scale represents the [VIM] concept of a "measurement scale" that is defined as an "ordered set of quantity values of
    /// quantities of a given kind of quantity used in ranking, according to magnitude, quantities of that kind." A Scale specifies one
    /// or more fixed values that have a specific significance in the definition of the associating QuantityKind.
    /// For example the "thermodynamic temperature" kind of quantity is defined by specifying the values of 0 and 273.16 kelvin as
    /// the temperatures of absolute zero and the triple point of water respectively.
    /// A Scale does not always need to specify a unit. For example the "Rockwell C Hardness Scale" or the "Beaufort Wind Force
    /// Scale" are ordinal scales that do not have a particular associated unit. Similarly, subjective scales for a "priority" or "risk" kind
    /// of quantity with e.g. value definitions 0 for "low", 1 for "medium" and 3 for "high" do not have a particular associated unit.</para>
    /// labels<para>Scale</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#Scale">http://purl.oclc.org/NET/ssnx/qu/qu#Scale</seealso>
    let Scale = Prefixed_Name(qu, "Scale") |> PrefixedName
    /// <summary>
    ///   <para>qu:Prefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Prefix represents a named multiple or submultiple multiplication factor used in the specification of a PrefixedUnit. A
    /// SystemOfUnits may specify a set of prefixes.</para>
    /// labels<para>Prefix</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#Prefix">http://purl.oclc.org/NET/ssnx/qu/qu#Prefix</seealso>
    let Prefix = Prefixed_Name(qu, "Prefix") |> PrefixedName
    /// <summary>
    ///   <para>qu:Unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Unit is an abstract classifier that represents the [VIM] concept of "measurement unit" that is defined as "real scalar quantity,
    /// defined and adopted by convention, with which any other quantity of the same kind can be compared to express the ratio of the
    /// two quantities as a number."</para>
    /// labels<para>Unit</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#Unit">http://purl.oclc.org/NET/ssnx/qu/qu#Unit</seealso>
    let Unit = Prefixed_Name(qu, "Unit") |> PrefixedName
    /// <summary>
    ///   <para>qu:ConversionBasedUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A ConversionBasedUnit is an abstract classifier that is a Unit that represents a measurement unit that is defined with respect to
    /// another reference unit through an explicit conversion relationship.</para>
    /// labels<para>ConversionBasedUnit</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#ConversionBasedUnit">http://purl.oclc.org/NET/ssnx/qu/qu#ConversionBasedUnit</seealso>
    let ConversionBasedUnit = Prefixed_Name(qu, "ConversionBasedUnit") |> PrefixedName
    /// <summary>
    ///   <para>qu:DerivedQuantityKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A DerivedQuantityKind is a QuantityKind that represents a kind of quantity that is defined as a product of powers of one or
    /// more other kinds of quantity. A DerivedQuantityKind may also be used to define a synonym kind of quantity for another kind
    /// of quantity.
    /// For example "velocity" can be specified as the product of "length" to the power one times "time" to the power minus one, and
    /// subsequently "speed" can be specified as "velocity" to the power one.</para>
    /// labels<para>DerivedQuantityKind</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#DerivedQuantityKind">http://purl.oclc.org/NET/ssnx/qu/qu#DerivedQuantityKind</seealso>
    let DerivedQuantityKind = Prefixed_Name(qu, "DerivedQuantityKind") |> PrefixedName
    /// <summary>
    ///   <para>qu:definitionURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>URI that references an external definition.</para>
    /// labels<para>definitionURI</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#definitionURI">http://purl.oclc.org/NET/ssnx/qu/qu#definitionURI</seealso>
    let definitionURI = Prefixed_Name(qu, "definitionURI") |> PrefixedName
    /// <summary>
    ///   <para>qu:referenceUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>Specifies the unit with respect to which the ConversionBasedUnit is defined.</para>
    /// labels<para>referenceUnit</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#referenceUnit">http://purl.oclc.org/NET/ssnx/qu/qu#referenceUnit</seealso>
    let referenceUnit = Prefixed_Name(qu, "referenceUnit") |> PrefixedName
    /// <summary>
    ///   <para>qu:quantityKindFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Rational number that specifies the factor in the quantity conversion relationship.</para>
    /// labels<para>quantity kind factor</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#quantityKindFactor">http://purl.oclc.org/NET/ssnx/qu/qu#quantityKindFactor</seealso>
    let quantityKindFactor = Prefixed_Name(qu, "quantityKindFactor") |> PrefixedName
    /// <summary>
    ///   <para>qu:DerivedUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A DerivedUnit is a Unit that represents a measurement unit that is defined as a product of powers of one or more other
    /// measurement units.
    /// For example the measurement unit "metre per second" for "velocity" is specified as the product of "metre" to the power one
    /// times "second" to the power minus one</para>
    /// labels<para>DerivedUnit</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#DerivedUnit">http://purl.oclc.org/NET/ssnx/qu/qu#DerivedUnit</seealso>
    let DerivedUnit = Prefixed_Name(qu, "DerivedUnit") |> PrefixedName
    /// <summary>
    ///   <para>qu:unitFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Rational number that specifies the factor in the unit conversion relationship.</para>
    /// labels<para>unit factor</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#unitFactor">http://purl.oclc.org/NET/ssnx/qu/qu#unitFactor</seealso>
    let unitFactor = Prefixed_Name(qu, "unitFactor") |> PrefixedName
    /// <summary>
    ///   <para>qu:Dimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Dimension represents the [VIM] concept of 'quantity dimension' that is defined as 'expression of the dependence of a quantity on the base quantities of a system of quantities as a product of powers of factors corresponding to the base quantities, omitting any numerical factor.'
    ///
    /// For example in the ISQ the quantity dimension of 'force' is denoted by dim F = Lï¿½Mï¿½T^2, where 'F' is the symbol for 'force', and 'L', 'M', 'T' are the symbols for the ISQ base quantities 'length', 'mass' and 'time' respectively.
    ///
    /// The Dimension of any QuantityKind can be derived through the algorithm that is defined in C.5.3.20 with SystemOfQuantities. The actual Dimension for a given QuantityKind depends on the choice of baseQuantityKind specified in a SystemOfQuantities.</para>
    /// labels<para>Dimension</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#Dimension">http://purl.oclc.org/NET/ssnx/qu/qu#Dimension</seealso>
    let Dimension = Prefixed_Name(qu, "Dimension") |> PrefixedName
    /// <summary>
    ///   <para>qu:symbolicExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Symbolic expression of the quantity dimension's product of powers, in terms of symbols of the kinds of quantity that represent the base kinds of quantity and their exponents.</para>
    /// labels<para>symbolicExpression</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#symbolicExpression">http://purl.oclc.org/NET/ssnx/qu/qu#symbolicExpression</seealso>
    let symbolicExpression = Prefixed_Name(qu, "symbolicExpression") |> PrefixedName
    /// <summary>
    ///   <para>qu:baseUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Ordered set of Unit that specifies the base units of the system of units. A "base unit" is defined in [VIM] as a "measurement unit that is adopted by convention for a base quantity," i.e. it is the (preferred) unit in which base quantities of the associated systemOfQuantities are expressed.</para>
    /// labels<para>baseUnit</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#baseUnit">http://purl.oclc.org/NET/ssnx/qu/qu#baseUnit</seealso>
    let baseUnit = Prefixed_Name(qu, "baseUnit") |> PrefixedName
    /// <summary>
    ///   <para>qu:quantityKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>Specification of the associated QuantityKind.</para>
    /// labels<para>quantityKind</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#quantityKind">http://purl.oclc.org/NET/ssnx/qu/qu#quantityKind</seealso>
    let quantityKind = Prefixed_Name(qu, "quantityKind") |> PrefixedName
    /// <summary>
    ///   <para>qu:code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A code is a string that uniquely identifies an individual.</para>
    /// labels<para>code</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#code">http://purl.oclc.org/NET/ssnx/qu/qu#code</seealso>
    let code = Prefixed_Name(qu, "code") |> PrefixedName
    /// <summary>
    ///   <para>qu:conversionOffset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Rational number that specifies the offset in the unit conversion relationship.</para>
    /// labels<para>conversionOffset</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#conversionOffset">http://purl.oclc.org/NET/ssnx/qu/qu#conversionOffset</seealso>
    let conversionOffset = Prefixed_Name(qu, "conversionOffset") |> PrefixedName
    /// <summary>
    ///   <para>qu:propertyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specification of the associated ProeprtyType.</para>
    /// labels<para>propertyType</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#propertyType">http://purl.oclc.org/NET/ssnx/qu/qu#propertyType</seealso>
    let propertyType = Prefixed_Name(qu, "propertyType") |> PrefixedName
    /// <summary>
    ///   <para>qu:specificQuantityKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A specialization relationship between two kinds of quantities.</para>
    /// labels<para>specificQuantityKind</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#specificQuantityKind">http://purl.oclc.org/NET/ssnx/qu/qu#specificQuantityKind</seealso>
    let specificQuantityKind = Prefixed_Name(qu, "specificQuantityKind") |> PrefixedName
    /// <summary>
    ///   <para>qu:unitKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>Specification of the associated Unit "Kind".</para>
    /// labels<para>unitKind</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#unitKind">http://purl.oclc.org/NET/ssnx/qu/qu#unitKind</seealso>
    let unitKind = Prefixed_Name(qu, "unitKind") |> PrefixedName
    /// <summary>
    ///   <para>qu:unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>Specification of the associated Unit.</para>
    /// labels<para>unit</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#unit">http://purl.oclc.org/NET/ssnx/qu/qu#unit</seealso>
    let unit = Prefixed_Name(qu, "unit") |> PrefixedName
    /// <summary>
    ///   <para>qu:SimpleUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A SimpleUnit is a Unit that represents a measurement unit that does not depend on any other Unit. Typically a base unit would
    /// be specified as a SimpleUnit.</para>
    /// labels<para>SimpleUnit</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#SimpleUnit">http://purl.oclc.org/NET/ssnx/qu/qu#SimpleUnit</seealso>
    let SimpleUnit = Prefixed_Name(qu, "SimpleUnit") |> PrefixedName
    /// <summary>
    ///   <para>qu:generalQuantityKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>A generalization relationship between two kinds of quantities.</para>
    /// labels<para>generalQuantityKind</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#generalQuantityKind">http://purl.oclc.org/NET/ssnx/qu/qu#generalQuantityKind</seealso>
    let generalQuantityKind = Prefixed_Name(qu, "generalQuantityKind") |> PrefixedName
    /// <summary>
    ///   <para>qu:quantityComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Quantities attached to a system.</para>
    /// labels<para>quantityComponent</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#quantityComponent">http://purl.oclc.org/NET/ssnx/qu/qu#quantityComponent</seealso>
    let quantityComponent = Prefixed_Name(qu, "quantityComponent") |> PrefixedName
    /// <summary>
    ///   <para>qu:baseQuantityKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Ordered set of QuantityKind that specifies the base quantities of the system of quantities. This is a subset of the complete quantityKind list. The base quantities define the basis for the quantity dimension of a kind of quantity.</para>
    /// labels<para>baseQuantityKind</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#baseQuantityKind">http://purl.oclc.org/NET/ssnx/qu/qu#baseQuantityKind</seealso>
    let baseQuantityKind = Prefixed_Name(qu, "baseQuantityKind") |> PrefixedName
    /// <summary>
    ///   <para>qu:DimensionFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A DimensionFactor represents a factor in the product of powers that defines a Dimension.</para>
    /// labels<para>DimensionFactor</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#DimensionFactor">http://purl.oclc.org/NET/ssnx/qu/qu#DimensionFactor</seealso>
    let DimensionFactor = Prefixed_Name(qu, "DimensionFactor") |> PrefixedName
    /// <summary>
    ///   <para>qu:dimensionFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>Rational number that specifies the factor in the dimension conversion relationship.</para>
    /// labels<para>dimension factor</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#dimensionFactor">http://purl.oclc.org/NET/ssnx/qu/qu#dimensionFactor</seealso>
    let dimensionFactor = Prefixed_Name(qu, "dimensionFactor") |> PrefixedName
    /// <summary>
    ///   <para>qu:baseDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Reference to the QuantityKind that represents the base quantity dimension in the factor.</para>
    /// labels<para>baseDimension</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#baseDimension">http://purl.oclc.org/NET/ssnx/qu/qu#baseDimension</seealso>
    let baseDimension = Prefixed_Name(qu, "baseDimension") |> PrefixedName
    /// <summary>
    ///   <para>qu:expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specifies the unit conversion relationship in some expression syntax.</para>
    /// labels<para>conversionExpression</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#expression">http://purl.oclc.org/NET/ssnx/qu/qu#expression</seealso>
    let expression = Prefixed_Name(qu, "expression") |> PrefixedName

    /// <summary>
    ///   <para>qu:GeneralConversionUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A GeneralConversionUnit is a ConversionBasedUnit that represents a measurement unit that is defined with respect to another
    /// reference measurement unit through a conversion relationship expressed in some syntax through a general mathematical
    /// expression.
    /// The unit conversion relationship is defined by the following equation:
    /// valueRU / valueCU = f(valueRU, valueCU)
    /// where:
    /// valueRU is the quantity value expressed in the referenceUnit, and,
    /// valueCU is the quantity value expressed in the GeneralConversionUnit, and,
    /// f(valueRU, valueCU) is a mathematical expression that includes valueRU and valueCU.</para>
    /// labels<para>GeneralConversionUnit</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#GeneralConversionUnit">http://purl.oclc.org/NET/ssnx/qu/qu#GeneralConversionUnit</seealso>
    let GeneralConversionUnit =
        Prefixed_Name(qu, "GeneralConversionUnit") |> PrefixedName

    /// <summary>
    ///   <para>qu:LinearConversionUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A LinearConversionUnit is a ConversionBasedUnit that represents a measurement unit that is defined with respect to another
    /// measurement reference unit through a linear conversion relationship with a conversion factor.
    /// The unit conversion relationship is defined by the following equation:
    /// valueRU = factor · valueCU,
    /// where:
    /// valueRU is the quantity value expressed in the referenceUnit, and,
    /// valueCU is the quantity value expressed in the LinearConversionUnit.</para>
    /// labels<para>LinearConversionUnit</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#LinearConversionUnit">http://purl.oclc.org/NET/ssnx/qu/qu#LinearConversionUnit</seealso>
    let LinearConversionUnit = Prefixed_Name(qu, "LinearConversionUnit") |> PrefixedName
    /// <summary>
    ///   <para>qu:conversionFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Rational number that specifies the factor in the unit conversion relationship.</para>
    /// labels<para>conversionFactor</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#conversionFactor">http://purl.oclc.org/NET/ssnx/qu/qu#conversionFactor</seealso>
    let conversionFactor = Prefixed_Name(qu, "conversionFactor") |> PrefixedName
    /// <summary>
    ///   <para>qu:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>name</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#name">http://purl.oclc.org/NET/ssnx/qu/qu#name</seealso>
    let name = Prefixed_Name(qu, "name") |> PrefixedName
    /// <summary>
    ///   <para>qu:symbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Short symbolic name.</para>
    /// labels<para>symbol</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#symbol">http://purl.oclc.org/NET/ssnx/qu/qu#symbol</seealso>
    let symbol = Prefixed_Name(qu, "symbol") |> PrefixedName
    /// <summary>
    ///   <para>qu:PrefixedUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Prefix represents a named multiple or submultiple multiplication factor used in the specification of a PrefixedUnit. A
    /// SystemOfUnits may specify a set of prefixes.</para>
    /// labels<para>PrefixedUnit</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#PrefixedUnit">http://purl.oclc.org/NET/ssnx/qu/qu#PrefixedUnit</seealso>
    let PrefixedUnit = Prefixed_Name(qu, "PrefixedUnit") |> PrefixedName
    /// <summary>
    ///   <para>qu:PropertyKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A PropertyKind  is a meta-property which helps to characterise categories of properties e.g. scalar, vector</para>
    /// labels<para>PropertyKind</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#PropertyKind">http://purl.oclc.org/NET/ssnx/qu/qu#PropertyKind</seealso>
    let PropertyKind = Prefixed_Name(qu, "PropertyKind") |> PrefixedName
    /// <summary>
    ///   <para>qu:unitMultipleFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Specifies the multiple or submultiple multiplication factor.</para>
    /// labels<para>unitMultipleFactor</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#unitMultipleFactor">http://purl.oclc.org/NET/ssnx/qu/qu#unitMultipleFactor</seealso>
    let unitMultipleFactor = Prefixed_Name(qu, "unitMultipleFactor") |> PrefixedName
    /// <summary>
    ///   <para>qu:prefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>Ordered set of Prefix that specifies the prefixes for multiples and submultiples of units in the system</para>
    /// labels<para>prefix</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#prefix">http://purl.oclc.org/NET/ssnx/qu/qu#prefix</seealso>
    let prefix = Prefixed_Name(qu, "prefix") |> PrefixedName
    /// <summary>
    ///   <para>qu:scale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>Specification of a Scale that is associated to the QuantityKind.</para>
    /// labels<para>scale</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#scale">http://purl.oclc.org/NET/ssnx/qu/qu#scale</seealso>
    let scale = Prefixed_Name(qu, "scale") |> PrefixedName
    /// <summary>
    ///   <para>qu:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Textual description</para>
    /// labels<para>description</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#description">http://purl.oclc.org/NET/ssnx/qu/qu#description</seealso>
    let description = Prefixed_Name(qu, "description") |> PrefixedName
    /// <summary>
    ///   <para>qu:factorQuantityKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>Specification of the associated QuantityKind.</para>
    /// labels<para>factorQuantityKind</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#factorQuantityKind">http://purl.oclc.org/NET/ssnx/qu/qu#factorQuantityKind</seealso>
    let factorQuantityKind = Prefixed_Name(qu, "factorQuantityKind") |> PrefixedName
    /// <summary>
    ///   <para>qu:exponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Rational number that specifies the exponent of the power to which the unit is raised.</para>
    /// labels<para>exponent</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#exponent">http://purl.oclc.org/NET/ssnx/qu/qu#exponent</seealso>
    let exponent = Prefixed_Name(qu, "exponent") |> PrefixedName
    /// <summary>
    ///   <para>qu:numericalValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specifies the numerical value.</para>
    /// labels<para>numericalValue</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#numericalValue">http://purl.oclc.org/NET/ssnx/qu/qu#numericalValue</seealso>
    let numericalValue = Prefixed_Name(qu, "numericalValue") |> PrefixedName
    /// <summary>
    ///   <para>qu:SimpleQuantityKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A SimpleQuantityKind is a QuantityKind that represents a kind of quantity that does not depend on any other QuantityKind.
    /// Typically a base quantity would be specified as a SimpleQuantityKind.</para>
    /// labels<para>SimpleQuantityKind</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#SimpleQuantityKind">http://purl.oclc.org/NET/ssnx/qu/qu#SimpleQuantityKind</seealso>
    let SimpleQuantityKind = Prefixed_Name(qu, "SimpleQuantityKind") |> PrefixedName

    /// <summary>
    ///   <para>qu:SpecializedQuantityKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A SpecializedQuantityKind is a QuantityKind that represents a kind of quantity that is a specialization of another kind of
    /// quantity.
    /// For example, "distance", "width", "depth", "radius" and "wavelength" can all be specified as specializations of the "length"
    /// SimpleQuantityKind.</para>
    /// labels<para>SpecializedQuantityKind</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#SpecializedQuantityKind">http://purl.oclc.org/NET/ssnx/qu/qu#SpecializedQuantityKind</seealso>
    let SpecializedQuantityKind =
        Prefixed_Name(qu, "SpecializedQuantityKind") |> PrefixedName

    /// <summary>
    ///   <para>qu:dimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Derived ordered set of Dimension. The actual dimension of a QuantityKind depends on the list of baseQuantityKind that are specified in an actual SystemOfQuantities, see the DerivedDimensions constraint.</para>
    /// labels<para>dimension</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#dimension">http://purl.oclc.org/NET/ssnx/qu/qu#dimension</seealso>
    let dimension = Prefixed_Name(qu, "dimension") |> PrefixedName
    /// <summary>
    ///   <para>qu:unitComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>Ordered set of Unit that specifies the units that are known in the system.</para>
    /// labels<para>unitComponent</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#unitComponent">http://purl.oclc.org/NET/ssnx/qu/qu#unitComponent</seealso>
    let unitComponent = Prefixed_Name(qu, "unitComponent") |> PrefixedName
    /// <summary>
    ///   <para>qu:systemOfQuantities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Reference to the SystemOfQuantities for which the units are specified.</para>
    /// labels<para>systemOfQuantities</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#systemOfQuantities">http://purl.oclc.org/NET/ssnx/qu/qu#systemOfQuantities</seealso>
    let systemOfQuantities = Prefixed_Name(qu, "systemOfQuantities") |> PrefixedName
    /// <summary>
    ///   <para>qu:scaleValueDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>Ordered set of ScaleValueDefinition that specifies the defined numerical value(s) and textual definition(s) for the measurement scale.</para>
    /// labels<para>scaleValueDefinition</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#scaleValueDefinition">http://purl.oclc.org/NET/ssnx/qu/qu#scaleValueDefinition</seealso>
    let scaleValueDefinition = Prefixed_Name(qu, "scaleValueDefinition") |> PrefixedName
    /// <summary>
    ///   <para>qu:QuantityKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A QuantityKind is an abstract classifier that represents the [VIM] concept of "kind of quantity" that is defined as "aspect
    /// common to mutually comparable quantities." A QuantityKind represents the essence of a quantity without any numerical
    /// value or unit. Quantities of the same kind within a given system of quantities have the same quantity dimension. However,
    /// quantities of the same dimension are not necessarily of the same kind.</para>
    /// labels<para>QuantityKind</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#QuantityKind">http://purl.oclc.org/NET/ssnx/qu/qu#QuantityKind</seealso>
    let QuantityKind = Prefixed_Name(qu, "QuantityKind") |> PrefixedName
    /// <summary>
    ///   <para>qu:SystemOfQuantities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A SystemOfQuantities represents the [VIM] concept of 'system of quantities' that is defined as a 'set of quantities together with a set of non-contradictory equations relating those quantities'. It collects a list of QuantityKind that specifies the kinds of quantity that are known in the system.
    ///
    /// The International System of Quantities (ISQ) is an example of a SystemOfQuantities, defined in ISO 31 and ISO/IEC 80000.</para>
    /// labels<para>SystemOfQuantities</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/qu/qu#SystemOfQuantities">http://purl.oclc.org/NET/ssnx/qu/qu#SystemOfQuantities</seealso>
    let SystemOfQuantities = Prefixed_Name(qu, "SystemOfQuantities") |> PrefixedName

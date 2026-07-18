namespace http.purl.oclc.org.NET.ssnx.qu.qu.hash

open DoxAletheia.Rdf_Vocabulary

module qu =
    let _namespace_name = "http://purl.oclc.org/NET/ssnx/qu/qu#"

    /// <summary>
    /// A QuantityKind is an abstract classifier that represents the [VIM] concept of "kind of quantity" that is defined as "aspect
    /// common to mutually comparable quantities." A QuantityKind represents the essence of a quantity without any numerical
    /// value or unit. Quantities of the same kind within a given system of quantities have the same quantity dimension. However,
    /// quantities of the same dimension are not necessarily of the same kind.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#QuantityKind"></see></summary>
    let QuantityKind =
        Namespaced_IRI.parse _namespace_name "QuantityKind" |> NamespacedName

    /// <summary>
    /// A QuantityKindFactor represents a factor in the product of powers that defines a DerivedQuantityKind.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#QuantityKindFactor"></see></summary>
    let QuantityKindFactor =
        Namespaced_IRI.parse _namespace_name "QuantityKindFactor" |> NamespacedName

    /// <summary>
    /// A Scale represents the [VIM] concept of a "measurement scale" that is defined as an "ordered set of quantity values of
    /// quantities of a given kind of quantity used in ranking, according to magnitude, quantities of that kind." A Scale specifies one
    /// or more fixed values that have a specific significance in the definition of the associating QuantityKind.
    /// For example the "thermodynamic temperature" kind of quantity is defined by specifying the values of 0 and 273.16 kelvin as
    /// the temperatures of absolute zero and the triple point of water respectively.
    /// A Scale does not always need to specify a unit. For example the "Rockwell C Hardness Scale" or the "Beaufort Wind Force
    /// Scale" are ordinal scales that do not have a particular associated unit. Similarly, subjective scales for a "priority" or "risk" kind
    /// of quantity with e.g. value definitions 0 for "low", 1 for "medium" and 3 for "high" do not have a particular associated unit.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#Scale"></see></summary>
    let Scale = Namespaced_IRI.parse _namespace_name "Scale" |> NamespacedName

    /// <summary>
    /// A ScaleValueDefinition represents a specific value for a measurement scale.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#ScaleValueDefinition"></see></summary>
    let ScaleValueDefinition =
        Namespaced_IRI.parse _namespace_name "ScaleValueDefinition" |> NamespacedName

    /// <summary>
    /// A SystemOfQuantities represents the [VIM] concept of 'system of quantities' that is defined as a 'set of quantities together with a set of non-contradictory equations relating those quantities'. It collects a list of QuantityKind that specifies the kinds of quantity that are known in the system.
    ///
    /// The International System of Quantities (ISQ) is an example of a SystemOfQuantities, defined in ISO 31 and ISO/IEC 80000.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#SystemOfQuantities"></see></summary>
    let SystemOfQuantities =
        Namespaced_IRI.parse _namespace_name "SystemOfQuantities" |> NamespacedName

    /// <summary>
    /// A SystemOfUnits represents the [VIM] concept of 'system of units' that is defined as 'set of base units and derived units, together with their multiples and submultiples, defined in accordance with given rules, for a given system of quantities'. It collects a list of Unit that are known in the system. A SysML SystemOfUnits only optionally defines multiples and submultiples.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#SystemOfUnits"></see></summary>
    let SystemOfUnits =
        Namespaced_IRI.parse _namespace_name "SystemOfUnits" |> NamespacedName

    /// <summary>
    /// A Unit is an abstract classifier that represents the [VIM] concept of "measurement unit" that is defined as "real scalar quantity,
    /// defined and adopted by convention, with which any other quantity of the same kind can be compared to express the ratio of the
    /// two quantities as a number."
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#Unit"></see></summary>
    let Unit = Namespaced_IRI.parse _namespace_name "Unit" |> NamespacedName
    /// <summary>
    /// A UnitFactor represents a factor in the product of powers that defines a DerivedUnit.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#UnitFactor"></see></summary>
    let UnitFactor = Namespaced_IRI.parse _namespace_name "UnitFactor" |> NamespacedName

    /// <summary>
    /// A ConversionBasedUnit is an abstract classifier that is a Unit that represents a measurement unit that is defined with respect to
    /// another reference unit through an explicit conversion relationship.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#ConversionBasedUnit"></see></summary>
    let ConversionBasedUnit =
        Namespaced_IRI.parse _namespace_name "ConversionBasedUnit" |> NamespacedName

    /// <summary>
    /// Specifies the unit with respect to which the ConversionBasedUnit is defined.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#referenceUnit"></see></summary>
    let referenceUnit =
        Namespaced_IRI.parse _namespace_name "referenceUnit" |> NamespacedName

    /// <summary>
    /// A DerivedQuantityKind is a QuantityKind that represents a kind of quantity that is defined as a product of powers of one or
    /// more other kinds of quantity. A DerivedQuantityKind may also be used to define a synonym kind of quantity for another kind
    /// of quantity.
    /// For example "velocity" can be specified as the product of "length" to the power one times "time" to the power minus one, and
    /// subsequently "speed" can be specified as "velocity" to the power one.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#DerivedQuantityKind"></see></summary>
    let DerivedQuantityKind =
        Namespaced_IRI.parse _namespace_name "DerivedQuantityKind" |> NamespacedName

    /// <summary>
    /// Rational number that specifies the factor in the quantity conversion relationship.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#quantityKindFactor"></see></summary>
    let quantityKindFactor =
        Namespaced_IRI.parse _namespace_name "quantityKindFactor" |> NamespacedName

    /// <summary>
    /// A DerivedUnit is a Unit that represents a measurement unit that is defined as a product of powers of one or more other
    /// measurement units.
    /// For example the measurement unit "metre per second" for "velocity" is specified as the product of "metre" to the power one
    /// times "second" to the power minus one
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#DerivedUnit"></see></summary>
    let DerivedUnit =
        Namespaced_IRI.parse _namespace_name "DerivedUnit" |> NamespacedName

    /// <summary>
    /// Rational number that specifies the factor in the unit conversion relationship.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#unitFactor"></see></summary>
    let unitFactor = Namespaced_IRI.parse _namespace_name "unitFactor" |> NamespacedName
    /// <summary>
    /// A Dimension represents the [VIM] concept of 'quantity dimension' that is defined as 'expression of the dependence of a quantity on the base quantities of a system of quantities as a product of powers of factors corresponding to the base quantities, omitting any numerical factor.'
    ///
    /// For example in the ISQ the quantity dimension of 'force' is denoted by dim F = Lï¿½Mï¿½T^2, where 'F' is the symbol for 'force', and 'L', 'M', 'T' are the symbols for the ISQ base quantities 'length', 'mass' and 'time' respectively.
    ///
    /// The Dimension of any QuantityKind can be derived through the algorithm that is defined in C.5.3.20 with SystemOfQuantities. The actual Dimension for a given QuantityKind depends on the choice of baseQuantityKind specified in a SystemOfQuantities.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#Dimension"></see></summary>
    let Dimension = Namespaced_IRI.parse _namespace_name "Dimension" |> NamespacedName

    /// <summary>
    /// A DimensionFactor represents a factor in the product of powers that defines a Dimension.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#DimensionFactor"></see></summary>
    let DimensionFactor =
        Namespaced_IRI.parse _namespace_name "DimensionFactor" |> NamespacedName

    /// <summary>
    /// Rational number that specifies the factor in the dimension conversion relationship.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#dimensionFactor"></see></summary>
    let dimensionFactor =
        Namespaced_IRI.parse _namespace_name "dimensionFactor" |> NamespacedName

    /// <summary>
    /// Symbolic expression of the quantity dimension's product of powers, in terms of symbols of the kinds of quantity that represent the base kinds of quantity and their exponents.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#symbolicExpression"></see></summary>
    let symbolicExpression =
        Namespaced_IRI.parse _namespace_name "symbolicExpression" |> NamespacedName

    /// <summary>
    /// A Reference to the QuantityKind that represents the base quantity dimension in the factor.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#baseDimension"></see></summary>
    let baseDimension =
        Namespaced_IRI.parse _namespace_name "baseDimension" |> NamespacedName

    /// <summary>
    /// A GeneralConversionUnit is a ConversionBasedUnit that represents a measurement unit that is defined with respect to another
    /// reference measurement unit through a conversion relationship expressed in some syntax through a general mathematical
    /// expression.
    /// The unit conversion relationship is defined by the following equation:
    /// valueRU / valueCU = f(valueRU, valueCU)
    /// where:
    /// valueRU is the quantity value expressed in the referenceUnit, and,
    /// valueCU is the quantity value expressed in the GeneralConversionUnit, and,
    /// f(valueRU, valueCU) is a mathematical expression that includes valueRU and valueCU.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#GeneralConversionUnit"></see></summary>
    let GeneralConversionUnit =
        Namespaced_IRI.parse _namespace_name "GeneralConversionUnit" |> NamespacedName

    /// <summary>
    /// Specifies the unit conversion relationship in some expression syntax.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#expression"></see></summary>
    let expression = Namespaced_IRI.parse _namespace_name "expression" |> NamespacedName

    /// <summary>
    /// A LinearConversionUnit is a ConversionBasedUnit that represents a measurement unit that is defined with respect to another
    /// measurement reference unit through a linear conversion relationship with a conversion factor.
    /// The unit conversion relationship is defined by the following equation:
    /// valueRU = factor · valueCU,
    /// where:
    /// valueRU is the quantity value expressed in the referenceUnit, and,
    /// valueCU is the quantity value expressed in the LinearConversionUnit.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#LinearConversionUnit"></see></summary>
    let LinearConversionUnit =
        Namespaced_IRI.parse _namespace_name "LinearConversionUnit" |> NamespacedName

    /// <summary>
    /// Rational number that specifies the factor in the unit conversion relationship.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#conversionFactor"></see></summary>
    let conversionFactor =
        Namespaced_IRI.parse _namespace_name "conversionFactor" |> NamespacedName

    /// <summary>
    /// A Prefix represents a named multiple or submultiple multiplication factor used in the specification of a PrefixedUnit. A
    /// SystemOfUnits may specify a set of prefixes.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#Prefix"></see></summary>
    let Prefix = Namespaced_IRI.parse _namespace_name "Prefix" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/qu/qu#name"></see>
    /// </summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName
    /// <summary>
    /// Short symbolic name.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#symbol"></see></summary>
    let symbol = Namespaced_IRI.parse _namespace_name "symbol" |> NamespacedName

    /// <summary>
    /// Specifies the multiple or submultiple multiplication factor.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#unitMultipleFactor"></see></summary>
    let unitMultipleFactor =
        Namespaced_IRI.parse _namespace_name "unitMultipleFactor" |> NamespacedName

    /// <summary>
    /// A Prefix represents a named multiple or submultiple multiplication factor used in the specification of a PrefixedUnit. A
    /// SystemOfUnits may specify a set of prefixes.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#PrefixedUnit"></see></summary>
    let PrefixedUnit =
        Namespaced_IRI.parse _namespace_name "PrefixedUnit" |> NamespacedName

    /// <summary>
    /// Ordered set of Prefix that specifies the prefixes for multiples and submultiples of units in the system
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#prefix"></see></summary>
    let prefix = Namespaced_IRI.parse _namespace_name "prefix" |> NamespacedName

    /// <summary>
    /// A PropertyKind  is a meta-property which helps to characterise categories of properties e.g. scalar, vector
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#PropertyKind"></see></summary>
    let PropertyKind =
        Namespaced_IRI.parse _namespace_name "PropertyKind" |> NamespacedName

    /// <summary>
    /// Specification of a Scale that is associated to the QuantityKind.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#scale"></see></summary>
    let scale = Namespaced_IRI.parse _namespace_name "scale" |> NamespacedName

    /// <summary>
    /// URI that references an external definition.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#definitionURI"></see></summary>
    let definitionURI =
        Namespaced_IRI.parse _namespace_name "definitionURI" |> NamespacedName

    /// <summary>
    /// Textual description
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#description"></see></summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    /// Specification of the associated QuantityKind.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#factorQuantityKind"></see></summary>
    let factorQuantityKind =
        Namespaced_IRI.parse _namespace_name "factorQuantityKind" |> NamespacedName

    /// <summary>
    /// Rational number that specifies the exponent of the power to which the unit is raised.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#exponent"></see></summary>
    let exponent = Namespaced_IRI.parse _namespace_name "exponent" |> NamespacedName

    /// <summary>
    /// Ordered set of ScaleValueDefinition that specifies the defined numerical value(s) and textual definition(s) for the measurement scale.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#scaleValueDefinition"></see></summary>
    let scaleValueDefinition =
        Namespaced_IRI.parse _namespace_name "scaleValueDefinition" |> NamespacedName

    /// <summary>
    /// Specification of the associated Unit.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#unit"></see></summary>
    let unit = Namespaced_IRI.parse _namespace_name "unit" |> NamespacedName

    /// <summary>
    /// Specifies the numerical value.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#numericalValue"></see></summary>
    let numericalValue =
        Namespaced_IRI.parse _namespace_name "numericalValue" |> NamespacedName

    /// <summary>
    /// A SimpleQuantityKind is a QuantityKind that represents a kind of quantity that does not depend on any other QuantityKind.
    /// Typically a base quantity would be specified as a SimpleQuantityKind.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#SimpleQuantityKind"></see></summary>
    let SimpleQuantityKind =
        Namespaced_IRI.parse _namespace_name "SimpleQuantityKind" |> NamespacedName

    /// <summary>
    /// A SimpleUnit is a Unit that represents a measurement unit that does not depend on any other Unit. Typically a base unit would
    /// be specified as a SimpleUnit.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#SimpleUnit"></see></summary>
    let SimpleUnit = Namespaced_IRI.parse _namespace_name "SimpleUnit" |> NamespacedName

    /// <summary>
    /// A SpecializedQuantityKind is a QuantityKind that represents a kind of quantity that is a specialization of another kind of
    /// quantity.
    /// For example, "distance", "width", "depth", "radius" and "wavelength" can all be specified as specializations of the "length"
    /// SimpleQuantityKind.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#SpecializedQuantityKind"></see></summary>
    let SpecializedQuantityKind =
        Namespaced_IRI.parse _namespace_name "SpecializedQuantityKind" |> NamespacedName

    /// <summary>
    /// A generalization relationship between two kinds of quantities.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#generalQuantityKind"></see></summary>
    let generalQuantityKind =
        Namespaced_IRI.parse _namespace_name "generalQuantityKind" |> NamespacedName

    /// <summary>
    /// Derived ordered set of Dimension. The actual dimension of a QuantityKind depends on the list of baseQuantityKind that are specified in an actual SystemOfQuantities, see the DerivedDimensions constraint.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#dimension"></see></summary>
    let dimension = Namespaced_IRI.parse _namespace_name "dimension" |> NamespacedName

    /// <summary>
    /// Quantities attached to a system.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#quantityComponent"></see></summary>
    let quantityComponent =
        Namespaced_IRI.parse _namespace_name "quantityComponent" |> NamespacedName

    /// <summary>
    /// Ordered set of QuantityKind that specifies the base quantities of the system of quantities. This is a subset of the complete quantityKind list. The base quantities define the basis for the quantity dimension of a kind of quantity.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#baseQuantityKind"></see></summary>
    let baseQuantityKind =
        Namespaced_IRI.parse _namespace_name "baseQuantityKind" |> NamespacedName

    /// <summary>
    /// Ordered set of Unit that specifies the units that are known in the system.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#unitComponent"></see></summary>
    let unitComponent =
        Namespaced_IRI.parse _namespace_name "unitComponent" |> NamespacedName

    /// <summary>
    /// Ordered set of Unit that specifies the base units of the system of units. A "base unit" is defined in [VIM] as a "measurement unit that is adopted by convention for a base quantity," i.e. it is the (preferred) unit in which base quantities of the associated systemOfQuantities are expressed.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#baseUnit"></see></summary>
    let baseUnit = Namespaced_IRI.parse _namespace_name "baseUnit" |> NamespacedName

    /// <summary>
    /// Reference to the SystemOfQuantities for which the units are specified.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#systemOfQuantities"></see></summary>
    let systemOfQuantities =
        Namespaced_IRI.parse _namespace_name "systemOfQuantities" |> NamespacedName

    /// <summary>
    /// Specification of the associated QuantityKind.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#quantityKind"></see></summary>
    let quantityKind =
        Namespaced_IRI.parse _namespace_name "quantityKind" |> NamespacedName

    /// <summary>
    /// A code is a string that uniquely identifies an individual.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#code"></see></summary>
    let code = Namespaced_IRI.parse _namespace_name "code" |> NamespacedName

    /// <summary>
    /// Rational number that specifies the offset in the unit conversion relationship.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#conversionOffset"></see></summary>
    let conversionOffset =
        Namespaced_IRI.parse _namespace_name "conversionOffset" |> NamespacedName

    /// <summary>
    /// Specification of the associated ProeprtyType.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#propertyType"></see></summary>
    let propertyType =
        Namespaced_IRI.parse _namespace_name "propertyType" |> NamespacedName

    /// <summary>
    /// A specialization relationship between two kinds of quantities.
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#specificQuantityKind"></see></summary>
    let specificQuantityKind =
        Namespaced_IRI.parse _namespace_name "specificQuantityKind" |> NamespacedName

    /// <summary>
    /// Specification of the associated Unit "Kind".
    /// <see href="http://purl.oclc.org/NET/ssnx/qu/qu#unitKind"></see></summary>
    let unitKind = Namespaced_IRI.parse _namespace_name "unitKind" |> NamespacedName

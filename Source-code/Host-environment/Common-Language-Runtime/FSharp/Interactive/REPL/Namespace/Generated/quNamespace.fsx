#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module qu =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.oclc.org/NET/ssnx/qu/qu#" "qu"

    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'ConversionBasedUnit' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Unit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : A ConversionBasedUnit is an abstract classifier that is a Unit that represents a measurement unit that is defined with respect to
    /// another reference unit through an explicit conversion relationship.^^xsd:string</para>
    ///   <para>rdfs:label : ConversionBasedUnit^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#ConversionBasedUnit">qu:ConversionBasedUnit</a>
    /// </summary>
    let ConversionBasedUnit = _prefixId.prefix "ConversionBasedUnit"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'DerivedQuantityKind ' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Quantity^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : A DerivedQuantityKind is a QuantityKind that represents a kind of quantity that is defined as a product of powers of one or
    /// more other kinds of quantity. A DerivedQuantityKind may also be used to define a synonym kind of quantity for another kind
    /// of quantity.
    /// For example "velocity" can be specified as the product of "length" to the power one times "time" to the power minus one, and
    /// subsequently "speed" can be specified as "velocity" to the power one.^^xsd:string</para>
    ///   <para>rdfs:label : DerivedQuantityKind^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#DerivedQuantityKind">qu:DerivedQuantityKind</a>
    /// </summary>
    let DerivedQuantityKind = _prefixId.prefix "DerivedQuantityKind"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'DerivedUnit' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Unit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : A DerivedUnit is a Unit that represents a measurement unit that is defined as a product of powers of one or more other
    /// measurement units.
    /// For example the measurement unit "metre per second" for "velocity" is specified as the product of "metre" to the power one
    /// times "second" to the power minus one^^xsd:string</para>
    ///   <para>rdfs:label : DerivedUnit^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#DerivedUnit">qu:DerivedUnit</a>
    /// </summary>
    let DerivedUnit = _prefixId.prefix "DerivedUnit"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'Dimension' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Dimension^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : A Dimension represents the [VIM] concept of 'quantity dimension' that is defined as 'expression of the dependence of a quantity on the base quantities of a system of quantities as a product of powers of factors corresponding to the base quantities, omitting any numerical factor.'
    ///
    /// For example in the ISQ the quantity dimension of 'force' is denoted by dim F = Lï¿½Mï¿½T^2, where 'F' is the symbol for 'force', and 'L', 'M', 'T' are the symbols for the ISQ base quantities 'length', 'mass' and 'time' respectively.
    ///
    /// The Dimension of any QuantityKind can be derived through the algorithm that is defined in C.5.3.20 with SystemOfQuantities. The actual Dimension for a given QuantityKind depends on the choice of baseQuantityKind specified in a SystemOfQuantities.^^xsd:string</para>
    ///   <para>rdfs:label : Dimension^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#Dimension">qu:Dimension</a>
    /// </summary>
    let Dimension = _prefixId.prefix "Dimension"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'DimensionFactor' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Dimension^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : A DimensionFactor represents a factor in the product of powers that defines a Dimension.^^xsd:string</para>
    ///   <para>rdfs:label : DimensionFactor^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#DimensionFactor">qu:DimensionFactor</a>
    /// </summary>
    let DimensionFactor = _prefixId.prefix "DimensionFactor"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'GeneralConversionUnit' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Unit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : A GeneralConversionUnit is a ConversionBasedUnit that represents a measurement unit that is defined with respect to another
    /// reference measurement unit through a conversion relationship expressed in some syntax through a general mathematical
    /// expression.
    /// The unit conversion relationship is defined by the following equation:
    /// valueRU / valueCU = f(valueRU, valueCU)
    /// where:
    /// valueRU is the quantity value expressed in the referenceUnit, and,
    /// valueCU is the quantity value expressed in the GeneralConversionUnit, and,
    /// f(valueRU, valueCU) is a mathematical expression that includes valueRU and valueCU.^^xsd:string</para>
    ///   <para>rdfs:label : GeneralConversionUnit^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#GeneralConversionUnit">qu:GeneralConversionUnit</a>
    /// </summary>
    let GeneralConversionUnit = _prefixId.prefix "GeneralConversionUnit"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'LinearConversionUnit' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Unit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : A LinearConversionUnit is a ConversionBasedUnit that represents a measurement unit that is defined with respect to another
    /// measurement reference unit through a linear conversion relationship with a conversion factor.
    /// The unit conversion relationship is defined by the following equation:
    /// valueRU = factor · valueCU,
    /// where:
    /// valueRU is the quantity value expressed in the referenceUnit, and,
    /// valueCU is the quantity value expressed in the LinearConversionUnit.^^xsd:string</para>
    ///   <para>rdfs:label : LinearConversionUnit^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#LinearConversionUnit">qu:LinearConversionUnit</a>
    /// </summary>
    let LinearConversionUnit = _prefixId.prefix "LinearConversionUnit"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'Prefix' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Unit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : A Prefix represents a named multiple or submultiple multiplication factor used in the specification of a PrefixedUnit. A
    /// SystemOfUnits may specify a set of prefixes.^^xsd:string</para>
    ///   <para>rdfs:label : Prefix^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#Prefix">qu:Prefix</a>
    /// </summary>
    let Prefix = _prefixId.prefix "Prefix"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'Prefix' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Unit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : A Prefix represents a named multiple or submultiple multiplication factor used in the specification of a PrefixedUnit. A
    /// SystemOfUnits may specify a set of prefixes.^^xsd:string</para>
    ///   <para>rdfs:label : PrefixedUnit^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#PrefixedUnit">qu:PrefixedUnit</a>
    /// </summary>
    let PrefixedUnit = _prefixId.prefix "PrefixedUnit"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Quantity^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : A PropertyKind  is a meta-property which helps to characterise categories of properties e.g. scalar, vector^^xsd:string</para>
    ///   <para>rdfs:label : PropertyKind^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#PropertyKind">qu:PropertyKind</a>
    /// </summary>
    let PropertyKind = _prefixId.prefix "PropertyKind"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'QuantityKind' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Quantity^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : A QuantityKind is an abstract classifier that represents the [VIM] concept of "kind of quantity" that is defined as "aspect
    /// common to mutually comparable quantities." A QuantityKind represents the essence of a quantity without any numerical
    /// value or unit. Quantities of the same kind within a given system of quantities have the same quantity dimension. However,
    /// quantities of the same dimension are not necessarily of the same kind.^^xsd:string</para>
    ///   <para>rdfs:label : QuantityKind^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#QuantityKind">qu:QuantityKind</a>
    /// </summary>
    let QuantityKind = _prefixId.prefix "QuantityKind"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'QuantityKindFactor' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Quantity^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : A QuantityKindFactor represents a factor in the product of powers that defines a DerivedQuantityKind.^^xsd:string</para>
    ///   <para>rdfs:label : QuantityKindFactor^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#QuantityKindFactor">qu:QuantityKindFactor</a>
    /// </summary>
    let QuantityKindFactor = _prefixId.prefix "QuantityKindFactor"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'Scale' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Scale^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : A Scale represents the [VIM] concept of a "measurement scale" that is defined as an "ordered set of quantity values of
    /// quantities of a given kind of quantity used in ranking, according to magnitude, quantities of that kind." A Scale specifies one
    /// or more fixed values that have a specific significance in the definition of the associating QuantityKind.
    /// For example the "thermodynamic temperature" kind of quantity is defined by specifying the values of 0 and 273.16 kelvin as
    /// the temperatures of absolute zero and the triple point of water respectively.
    /// A Scale does not always need to specify a unit. For example the "Rockwell C Hardness Scale" or the "Beaufort Wind Force
    /// Scale" are ordinal scales that do not have a particular associated unit. Similarly, subjective scales for a "priority" or "risk" kind
    /// of quantity with e.g. value definitions 0 for "low", 1 for "medium" and 3 for "high" do not have a particular associated unit.^^xsd:string</para>
    ///   <para>rdfs:label : Scale^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#Scale">qu:Scale</a>
    /// </summary>
    let Scale = _prefixId.prefix "Scale"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'ScaleValueDefinition' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Scale^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : A ScaleValueDefinition represents a specific value for a measurement scale.^^xsd:string</para>
    ///   <para>rdfs:label : ScaleValueDefinition^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#ScaleValueDefinition">qu:ScaleValueDefinition</a>
    /// </summary>
    let ScaleValueDefinition = _prefixId.prefix "ScaleValueDefinition"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'SimpleQuantityKind' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Quantity^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : A SimpleQuantityKind is a QuantityKind that represents a kind of quantity that does not depend on any other QuantityKind.
    /// Typically a base quantity would be specified as a SimpleQuantityKind.^^xsd:string</para>
    ///   <para>rdfs:label : SimpleQuantityKind^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#SimpleQuantityKind">qu:SimpleQuantityKind</a>
    /// </summary>
    let SimpleQuantityKind = _prefixId.prefix "SimpleQuantityKind"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'SimpleUnit' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Unit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : A SimpleUnit is a Unit that represents a measurement unit that does not depend on any other Unit. Typically a base unit would
    /// be specified as a SimpleUnit.^^xsd:string</para>
    ///   <para>rdfs:label : SimpleUnit^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#SimpleUnit">qu:SimpleUnit</a>
    /// </summary>
    let SimpleUnit = _prefixId.prefix "SimpleUnit"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'SpecializedQuantityKind' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Quantity^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : A SpecializedQuantityKind is a QuantityKind that represents a kind of quantity that is a specialization of another kind of
    /// quantity.
    /// For example, "distance", "width", "depth", "radius" and "wavelength" can all be specified as specializations of the "length"
    /// SimpleQuantityKind.^^xsd:string</para>
    ///   <para>rdfs:label : SpecializedQuantityKind^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#SpecializedQuantityKind">qu:SpecializedQuantityKind</a>
    /// </summary>
    let SpecializedQuantityKind = _prefixId.prefix "SpecializedQuantityKind"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'SystemOfQuantities' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Dimension^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : A SystemOfQuantities represents the [VIM] concept of 'system of quantities' that is defined as a 'set of quantities together with a set of non-contradictory equations relating those quantities'. It collects a list of QuantityKind that specifies the kinds of quantity that are known in the system.
    ///
    /// The International System of Quantities (ISQ) is an example of a SystemOfQuantities, defined in ISO 31 and ISO/IEC 80000.^^xsd:string</para>
    ///   <para>rdfs:label : SystemOfQuantities^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#SystemOfQuantities">qu:SystemOfQuantities</a>
    /// </summary>
    let SystemOfQuantities = _prefixId.prefix "SystemOfQuantities"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'SystemOfUnits' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Dimension^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : A SystemOfUnits represents the [VIM] concept of 'system of units' that is defined as 'set of base units and derived units, together with their multiples and submultiples, defined in accordance with given rules, for a given system of quantities'. It collects a list of Unit that are known in the system. A SysML SystemOfUnits only optionally defines multiples and submultiples.^^xsd:string</para>
    ///   <para>rdfs:label : SystemOfUnits^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#SystemOfUnits">qu:SystemOfUnits</a>
    /// </summary>
    let SystemOfUnits = _prefixId.prefix "SystemOfUnits"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'Unit' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Unit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : A Unit is an abstract classifier that represents the [VIM] concept of "measurement unit" that is defined as "real scalar quantity,
    /// defined and adopted by convention, with which any other quantity of the same kind can be compared to express the ratio of the
    /// two quantities as a number."^^xsd:string</para>
    ///   <para>rdfs:label : Unit^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#Unit">qu:Unit</a>
    /// </summary>
    let Unit = _prefixId.prefix "Unit"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'UnitFactor' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Unit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : A UnitFactor represents a factor in the product of powers that defines a DerivedUnit.^^xsd:string</para>
    ///   <para>rdfs:label : UnitFactor^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#UnitFactor">qu:UnitFactor</a>
    /// </summary>
    let UnitFactor = _prefixId.prefix "UnitFactor"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'baseDimension' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Dimension^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : A Reference to the QuantityKind that represents the base quantity dimension in the factor.^^xsd:string</para>
    ///   <para>rdfs:label : baseDimension^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#baseDimension">qu:baseDimension</a>
    /// </summary>
    let baseDimension = _prefixId.prefix "baseDimension"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'baseQuantityKind' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Dimension^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : Ordered set of QuantityKind that specifies the base quantities of the system of quantities. This is a subset of the complete quantityKind list. The base quantities define the basis for the quantity dimension of a kind of quantity.^^xsd:string</para>
    ///   <para>rdfs:label : baseQuantityKind^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#baseQuantityKind">qu:baseQuantityKind</a>
    /// </summary>
    let baseQuantityKind = _prefixId.prefix "baseQuantityKind"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'baseUnit' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Dimension^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : Ordered set of Unit that specifies the base units of the system of units. A "base unit" is defined in [VIM] as a "measurement unit that is adopted by convention for a base quantity," i.e. it is the (preferred) unit in which base quantities of the associated systemOfQuantities are expressed.^^xsd:string</para>
    ///   <para>rdfs:label : baseUnit^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#baseUnit">qu:baseUnit</a>
    /// </summary>
    let baseUnit = _prefixId.prefix "baseUnit"
    /// <summary>
    ///   <para>dce:source : skos:closeMatch 'code' [QUDT] http://qudt.org/^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Data^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : A code is a string that uniquely identifies an individual.^^xsd:string</para>
    ///   <para>dce:description : short symbolic name^^xsd:string</para>
    ///   <para>rdfs:label : code^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#code">qu:code</a>
    /// </summary>
    let code = _prefixId.prefix "code"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'factor' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Data^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : Rational number that specifies the factor in the unit conversion relationship.^^xsd:string</para>
    ///   <para>rdfs:label : conversionFactor^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#conversionFactor">qu:conversionFactor</a>
    /// </summary>
    let conversionFactor = _prefixId.prefix "conversionFactor"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'offset' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Data^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : Rational number that specifies the offset in the unit conversion relationship.^^xsd:string</para>
    ///   <para>rdfs:label : conversionOffset^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#conversionOffset">qu:conversionOffset</a>
    /// </summary>
    let conversionOffset = _prefixId.prefix "conversionOffset"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'definitionURI' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Data^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : URI that references an external definition.^^xsd:string</para>
    ///   <para>dce:description : URI that contains an authoritative definition of the referent thing^^xsd:string</para>
    ///   <para>rdfs:label : definitionURI^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#definitionURI">qu:definitionURI</a>
    /// </summary>
    let definitionURI = _prefixId.prefix "definitionURI"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'description' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Data^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : Textual description^^xsd:string</para>
    ///   <para>rdfs:label : description^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#description">qu:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'dimension' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Quantity^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : Derived ordered set of Dimension. The actual dimension of a QuantityKind depends on the list of baseQuantityKind that are specified in an actual SystemOfQuantities, see the DerivedDimensions constraint.^^xsd:string</para>
    ///   <para>rdfs:label : dimension^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#dimension">qu:dimension</a>
    /// </summary>
    let dimension = _prefixId.prefix "dimension"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'factor' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Dimension^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : Rational number that specifies the factor in the dimension conversion relationship.^^xsd:string</para>
    ///   <para>rdfs:label : dimension factor^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#dimensionFactor">qu:dimensionFactor</a>
    /// </summary>
    let dimensionFactor = _prefixId.prefix "dimensionFactor"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'exponent' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Data^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : Rational number that specifies the exponent of the power to which the unit is raised.^^xsd:string</para>
    ///   <para>rdfs:label : exponent^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#exponent">qu:exponent</a>
    /// </summary>
    let exponent = _prefixId.prefix "exponent"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'expression' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Data^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies the unit conversion relationship in some expression syntax.^^xsd:string</para>
    ///   <para>rdfs:label : conversionExpression^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#expression">qu:expression</a>
    /// </summary>
    let expression = _prefixId.prefix "expression"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'quantityKind' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Quantity^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : Specification of the associated QuantityKind.^^xsd:string</para>
    ///   <para>rdfs:label : factorQuantityKind^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#factorQuantityKind">qu:factorQuantityKind</a>
    /// </summary>
    let factorQuantityKind = _prefixId.prefix "factorQuantityKind"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'generalization' [QUDT] http:qudt.org^^xsd:stringdce:source : skos:exactMatch 'general' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Quantity^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : A generalization relationship between two kinds of quantities.^^xsd:string</para>
    ///   <para>rdfs:label : generalQuantityKind^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#generalQuantityKind">qu:generalQuantityKind</a>
    /// </summary>
    let generalQuantityKind = _prefixId.prefix "generalQuantityKind"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'name' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Data^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>dce:description : human-readable word or sequence of words by which a thing is known^^xsd:string</para>
    ///   <para>rdfs:label : name^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#name">qu:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'value' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Data^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies the numerical value.^^xsd:string</para>
    ///   <para>rdfs:label : numericalValue^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#numericalValue">qu:numericalValue</a>
    /// </summary>
    let numericalValue = _prefixId.prefix "numericalValue"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'prefix' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Unit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : Ordered set of Prefix that specifies the prefixes for multiples and submultiples of units in the system^^xsd:string</para>
    ///   <para>rdfs:label : prefix^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#prefix">qu:prefix</a>
    /// </summary>
    let prefix = _prefixId.prefix "prefix"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Quantity^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : Specification of the associated ProeprtyType.^^xsd:string</para>
    ///   <para>rdfs:label : propertyType^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#propertyType">qu:propertyType</a>
    /// </summary>
    let propertyType = _prefixId.prefix "propertyType"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'quantityKind' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Dimension^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : Quantities attached to a system.^^xsd:string</para>
    ///   <para>rdfs:label : quantityComponent^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#quantityComponent">qu:quantityComponent</a>
    /// </summary>
    let quantityComponent = _prefixId.prefix "quantityComponent"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'quantityKind' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Quantity^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : Specification of the associated QuantityKind.^^xsd:string</para>
    ///   <para>rdfs:label : quantityKind^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#quantityKind">qu:quantityKind</a>
    /// </summary>
    let quantityKind = _prefixId.prefix "quantityKind"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'factor' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Quantity^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : Rational number that specifies the factor in the quantity conversion relationship.^^xsd:string</para>
    ///   <para>rdfs:label : quantity kind factor^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#quantityKindFactor">qu:quantityKindFactor</a>
    /// </summary>
    let quantityKindFactor = _prefixId.prefix "quantityKindFactor"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'referenceUnit' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Unit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies the unit with respect to which the ConversionBasedUnit is defined.^^xsd:string</para>
    ///   <para>rdfs:label : referenceUnit^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#referenceUnit">qu:referenceUnit</a>
    /// </summary>
    let referenceUnit = _prefixId.prefix "referenceUnit"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'scale' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Scale^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : Specification of a Scale that is associated to the QuantityKind.^^xsd:string</para>
    ///   <para>rdfs:label : scale^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#scale">qu:scale</a>
    /// </summary>
    let scale = _prefixId.prefix "scale"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'valueDefinition' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Scale^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : Ordered set of ScaleValueDefinition that specifies the defined numerical value(s) and textual definition(s) for the measurement scale.^^xsd:string</para>
    ///   <para>rdfs:label : scaleValueDefinition^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#scaleValueDefinition">qu:scaleValueDefinition</a>
    /// </summary>
    let scaleValueDefinition = _prefixId.prefix "scaleValueDefinition"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>dce:source : skos:exactMatch 'specific' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:comment : A specialization relationship between two kinds of quantities.^^xsd:string</para>
    ///   <para>rdfs:label : specificQuantityKind^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Quantity^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#specificQuantityKind">qu:specificQuantityKind</a>
    /// </summary>
    let specificQuantityKind = _prefixId.prefix "specificQuantityKind"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'symbol' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Data^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : Short symbolic name.^^xsd:string</para>
    ///   <para>dce:description : short symbolic name^^xsd:string</para>
    ///   <para>rdfs:label : symbol^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#symbol">qu:symbol</a>
    /// </summary>
    let symbol = _prefixId.prefix "symbol"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'symbolicExpression' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Data^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : Symbolic expression of the quantity dimension's product of powers, in terms of symbols of the kinds of quantity that represent the base kinds of quantity and their exponents.^^xsd:string</para>
    ///   <para>rdfs:label : symbolicExpression^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#symbolicExpression">qu:symbolicExpression</a>
    /// </summary>
    let symbolicExpression = _prefixId.prefix "symbolicExpression"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'systemOfQuantities' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Dimension^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : Reference to the SystemOfQuantities for which the units are specified.^^xsd:string</para>
    ///   <para>rdfs:label : systemOfQuantities^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#systemOfQuantities">qu:systemOfQuantities</a>
    /// </summary>
    let systemOfQuantities = _prefixId.prefix "systemOfQuantities"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'quantityKind' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Unit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : Specification of the associated Unit.^^xsd:string</para>
    ///   <para>rdfs:label : unit^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#unit">qu:unit</a>
    /// </summary>
    let unit = _prefixId.prefix "unit"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'unit' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Dimension^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : Ordered set of Unit that specifies the units that are known in the system.^^xsd:string</para>
    ///   <para>rdfs:label : unitComponent^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#unitComponent">qu:unitComponent</a>
    /// </summary>
    let unitComponent = _prefixId.prefix "unitComponent"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'factor' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Unit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : Rational number that specifies the factor in the unit conversion relationship.^^xsd:string</para>
    ///   <para>rdfs:label : unit factor^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#unitFactor">qu:unitFactor</a>
    /// </summary>
    let unitFactor = _prefixId.prefix "unitFactor"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Unit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : Specification of the associated Unit "Kind".^^xsd:string</para>
    ///   <para>rdfs:label : unitKind^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#unitKind">qu:unitKind</a>
    /// </summary>
    let unitKind = _prefixId.prefix "unitKind"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'factor' [SysML 1.2-QUDV] http://www.omgwiki.org/OMGSysML/doku.php?id=sysml-qudv:quantities_units_dimensions_values_qudv^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.omgsysml.org/qudv#Data^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://purl.oclc.org/NET/ssnx/qu^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies the multiple or submultiple multiplication factor.^^xsd:string</para>
    ///   <para>rdfs:label : unitMultipleFactor^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/qu/qu#unitMultipleFactor">qu:unitMultipleFactor</a>
    /// </summary>
    let unitMultipleFactor = _prefixId.prefix "unitMultipleFactor"

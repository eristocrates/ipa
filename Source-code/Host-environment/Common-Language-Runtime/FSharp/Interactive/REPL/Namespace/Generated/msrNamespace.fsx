#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module msr =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.telegraphis.net/ontology/measurement/measurement#" "msr"

    let _namespaceIri = _prefixId.prefix ""
    let Area = _prefixId.prefix "Area"
    /// <summary>
    ///   <para>rdfs:label : Area Measurement</para>
    ///   <a href="http://www.telegraphis.net/ontology/measurement/measurement#AreaMeasurement">msr:AreaMeasurement</a>
    /// </summary>
    let AreaMeasurement = _prefixId.prefix "AreaMeasurement"
    let AreaUnit = _prefixId.prefix "AreaUnit"
    let Km2 = _prefixId.prefix "Km2"
    /// <summary>
    ///   <para>rdfs:label : Measurement</para>
    ///   <para>rdfs:description : A measurement is a statistic that measures a quantity that may or may not have units.</para>
    ///   <a href="http://www.telegraphis.net/ontology/measurement/measurement#Measurement">msr:Measurement</a>
    /// </summary>
    let Measurement = _prefixId.prefix "Measurement"
    /// <summary>
    ///   <para>rdfs:label : Quantity</para>
    ///   <para>rdfs:description : A quantity is a quantifiable quality of an object.</para>
    ///   <a href="http://www.telegraphis.net/ontology/measurement/measurement#Quantity">msr:Quantity</a>
    /// </summary>
    let Quantity = _prefixId.prefix "Quantity"
    /// <summary>
    ///   <para>rdfs:label : Unit</para>
    ///   <para>rdfs:description : A unit is a particular quantity against which another quantity may be compared.  Hence, a unit is dimensionful and provides a ratio by which a quantity may be measured.</para>
    ///   <a href="http://www.telegraphis.net/ontology/measurement/measurement#Unit">msr:Unit</a>
    /// </summary>
    let Unit = _prefixId.prefix "Unit"
    /// <summary>
    ///   <para>rdfs:label : Unit Class</para>
    ///   <para>rdfs:description : A unit class is a subset of units, with no particular restriction on its contents (i.e. it may be a set of units measuring orthogonal quantities, making a UnitSystem, or a set of units measuring the same quantity).</para>
    ///   <a href="http://www.telegraphis.net/ontology/measurement/measurement#UnitClass">msr:UnitClass</a>
    /// </summary>
    let UnitClass = _prefixId.prefix "UnitClass"
    /// <summary>
    ///   <para>rdfs:label : Unit System</para>
    ///   <para>rdfs:description : A unit system is a class of units for which no two elements in the class measure the same dimension (i.e. all dimensions are orthogonal to each other, or measure dimensions derived from a set of orthogonal dimensions with units derived from the units that measure those orthogonal dimensions specified in the system.</para>
    ///   <a href="http://www.telegraphis.net/ontology/measurement/measurement#UnitSystem">msr:UnitSystem</a>
    /// </summary>
    let UnitSystem = _prefixId.prefix "UnitSystem"
    /// <summary>
    ///   <para>rdfs:label : area</para>
    ///   <a href="http://www.telegraphis.net/ontology/measurement/measurement#area">msr:area</a>
    /// </summary>
    let area = _prefixId.prefix "area"
    /// <summary>
    ///   <para>rdfs:label : equivalent quantity</para>
    ///   <para>rdfs:description : An equivalent quantity of a unit class is the quantity measured by all units in the unit class.</para>
    ///   <a href="http://www.telegraphis.net/ontology/measurement/measurement#equivalentQuantity">msr:equivalentQuantity</a>
    /// </summary>
    let equivalentQuantity = _prefixId.prefix "equivalentQuantity"
    /// <summary>
    ///   <para>rdfs:label : equivalent unit class</para>
    ///   <para>rdfs:description : An equivalent unit class of a quantity is the unit class corresponding to units that measure the quantity.</para>
    ///   <a href="http://www.telegraphis.net/ontology/measurement/measurement#equivalentUnitClass">msr:equivalentUnitClass</a>
    /// </summary>
    let equivalentUnitClass = _prefixId.prefix "equivalentUnitClass"
    let measuredQuantity = _prefixId.prefix "measuredQuantity"
    /// <summary>
    ///   <para>rdfs:label : measured quantity</para>
    ///   <para>rdfs:description : The quantity measured for a measurement.</para>
    ///   <a href="http://www.telegraphis.net/ontology/measurement/measurement#quantityMeasured">msr:quantityMeasured</a>
    /// </summary>
    let quantityMeasured = _prefixId.prefix "quantityMeasured"
    /// <summary>
    ///   <para>rdfs:label : unit</para>
    ///   <para>rdfs:description : The unit a measurement is made in.</para>
    ///   <a href="http://www.telegraphis.net/ontology/measurement/measurement#unit">msr:unit</a>
    /// </summary>
    let unit = _prefixId.prefix "unit"
    let unitClass = _prefixId.prefix "unitClass"
    let units = _prefixId.prefix "units"

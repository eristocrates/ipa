namespace http.www.telegraphis.net.ontology.measurement.measurement.hash

open DoxAletheia

module msr =
    let _namespace_name = "http://www.telegraphis.net/ontology/measurement/measurement#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.telegraphis.net/ontology/measurement/measurement#units"></see>
    /// </summary>
    let units = _prefix "units"
    /// <summary>
    ///   <see href="http://www.telegraphis.net/ontology/measurement/measurement#Area"></see>
    /// </summary>
    let Area = _prefix "Area"
    /// <summary>
    ///   <see href="http://www.telegraphis.net/ontology/measurement/measurement#equivalentUnitClass"></see>
    /// </summary>
    let equivalentUnitClass = _prefix "equivalentUnitClass"
    /// <summary>
    ///   <see href="http://www.telegraphis.net/ontology/measurement/measurement#AreaUnit"></see>
    /// </summary>
    let AreaUnit = _prefix "AreaUnit"
    /// <summary>
    ///   <see href="http://www.telegraphis.net/ontology/measurement/measurement#Quantity"></see>
    /// </summary>
    let Quantity = _prefix "Quantity"
    /// <summary>
    ///   <see href="http://www.telegraphis.net/ontology/measurement/measurement#AreaMeasurement"></see>
    /// </summary>
    let AreaMeasurement = _prefix "AreaMeasurement"
    /// <summary>
    ///   <see href="http://www.telegraphis.net/ontology/measurement/measurement#unit"></see>
    /// </summary>
    let unit = _prefix "unit"
    /// <summary>
    ///   <see href="http://www.telegraphis.net/ontology/measurement/measurement#measuredQuantity"></see>
    /// </summary>
    let measuredQuantity = _prefix "measuredQuantity"
    /// <summary>
    ///   <see href="http://www.telegraphis.net/ontology/measurement/measurement#Measurement"></see>
    /// </summary>
    let Measurement = _prefix "Measurement"
    /// <summary>
    ///   <see href="http://www.telegraphis.net/ontology/measurement/measurement#equivalentQuantity"></see>
    /// </summary>
    let equivalentQuantity = _prefix "equivalentQuantity"
    /// <summary>
    ///   <see href="http://www.telegraphis.net/ontology/measurement/measurement#UnitClass"></see>
    /// </summary>
    let UnitClass = _prefix "UnitClass"
    /// <summary>
    ///   <see href="http://www.telegraphis.net/ontology/measurement/measurement#Unit"></see>
    /// </summary>
    let Unit = _prefix "Unit"
    /// <summary>
    ///   <see href="http://www.telegraphis.net/ontology/measurement/measurement#Km2"></see>
    /// </summary>
    let Km2 = _prefix "Km2"
    /// <summary>
    ///   <see href="http://www.telegraphis.net/ontology/measurement/measurement#quantityMeasured"></see>
    /// </summary>
    let quantityMeasured = _prefix "quantityMeasured"
    /// <summary>
    ///   <see href="http://www.telegraphis.net/ontology/measurement/measurement#UnitSystem"></see>
    /// </summary>
    let UnitSystem = _prefix "UnitSystem"
    /// <summary>
    ///   <see href="http://www.telegraphis.net/ontology/measurement/measurement#area"></see>
    /// </summary>
    let area = _prefix "area"
    /// <summary>
    ///   <see href="http://www.telegraphis.net/ontology/measurement/measurement#unitClass"></see>
    /// </summary>
    let unitClass = _prefix "unitClass"

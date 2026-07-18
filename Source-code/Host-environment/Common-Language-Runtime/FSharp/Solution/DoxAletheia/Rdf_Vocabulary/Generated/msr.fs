namespace http.www.telegraphis.net.ontology.measurement.measurement.hash

open DoxAletheia.Rdf_Vocabulary

module msr =
    let _namespace_name = "http://www.telegraphis.net/ontology/measurement/measurement#"
    /// <summary>
    ///   <see href="http://www.telegraphis.net/ontology/measurement/measurement#units"></see>
    /// </summary>
    let units = Namespaced_IRI.parse _namespace_name "units" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.telegraphis.net/ontology/measurement/measurement#Area"></see>
    /// </summary>
    let Area = Namespaced_IRI.parse _namespace_name "Area" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.telegraphis.net/ontology/measurement/measurement#equivalentUnitClass"></see>
    /// </summary>
    let equivalentUnitClass =
        Namespaced_IRI.parse _namespace_name "equivalentUnitClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.telegraphis.net/ontology/measurement/measurement#AreaUnit"></see>
    /// </summary>
    let AreaUnit = Namespaced_IRI.parse _namespace_name "AreaUnit" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.telegraphis.net/ontology/measurement/measurement#Quantity"></see>
    /// </summary>
    let Quantity = Namespaced_IRI.parse _namespace_name "Quantity" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.telegraphis.net/ontology/measurement/measurement#AreaMeasurement"></see>
    /// </summary>
    let AreaMeasurement =
        Namespaced_IRI.parse _namespace_name "AreaMeasurement" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.telegraphis.net/ontology/measurement/measurement#unit"></see>
    /// </summary>
    let unit = Namespaced_IRI.parse _namespace_name "unit" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.telegraphis.net/ontology/measurement/measurement#measuredQuantity"></see>
    /// </summary>
    let measuredQuantity =
        Namespaced_IRI.parse _namespace_name "measuredQuantity" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.telegraphis.net/ontology/measurement/measurement#Measurement"></see>
    /// </summary>
    let Measurement =
        Namespaced_IRI.parse _namespace_name "Measurement" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.telegraphis.net/ontology/measurement/measurement#equivalentQuantity"></see>
    /// </summary>
    let equivalentQuantity =
        Namespaced_IRI.parse _namespace_name "equivalentQuantity" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.telegraphis.net/ontology/measurement/measurement#UnitClass"></see>
    /// </summary>
    let UnitClass = Namespaced_IRI.parse _namespace_name "UnitClass" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.telegraphis.net/ontology/measurement/measurement#Unit"></see>
    /// </summary>
    let Unit = Namespaced_IRI.parse _namespace_name "Unit" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.telegraphis.net/ontology/measurement/measurement#Km2"></see>
    /// </summary>
    let Km2 = Namespaced_IRI.parse _namespace_name "Km2" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.telegraphis.net/ontology/measurement/measurement#quantityMeasured"></see>
    /// </summary>
    let quantityMeasured =
        Namespaced_IRI.parse _namespace_name "quantityMeasured" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.telegraphis.net/ontology/measurement/measurement#UnitSystem"></see>
    /// </summary>
    let UnitSystem = Namespaced_IRI.parse _namespace_name "UnitSystem" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.telegraphis.net/ontology/measurement/measurement#area"></see>
    /// </summary>
    let area = Namespaced_IRI.parse _namespace_name "area" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.telegraphis.net/ontology/measurement/measurement#unitClass"></see>
    /// </summary>
    let unitClass = Namespaced_IRI.parse _namespace_name "unitClass" |> NamespacedName

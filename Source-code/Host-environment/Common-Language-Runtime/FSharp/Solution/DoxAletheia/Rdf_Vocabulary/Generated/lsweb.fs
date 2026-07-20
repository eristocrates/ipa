namespace http.ontology.cybershare.utep.edu.ELSEWeb.elseweb_data.owl.hash

open DoxAletheia

module lsweb =
    let _namespace_name =
        "http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Characteristic"></see>
    /// </summary>
    let Characteristic = _prefix "Characteristic"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#DatasetManifestation"></see>
    /// </summary>
    let DatasetManifestation = _prefix "DatasetManifestation"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Entity"></see>
    /// </summary>
    let Entity = _prefix "Entity"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Format"></see>
    /// </summary>
    let Format = _prefix "Format"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#GeographicRegion"></see>
    /// </summary>
    let GeographicRegion = _prefix "GeographicRegion"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#GeospatialDataset"></see>
    /// </summary>
    let GeospatialDataset = _prefix "GeospatialDataset"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Provider"></see>
    /// </summary>
    let Provider = _prefix "Provider"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Theme"></see>
    /// </summary>
    let Theme = _prefix "Theme"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#TimePeriod"></see>
    /// </summary>
    let TimePeriod = _prefix "TimePeriod"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Unit"></see>
    /// </summary>
    let Unit = _prefix "Unit"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#encodedInFormat"></see>
    /// </summary>
    let encodedInFormat = _prefix "encodedInFormat"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#hasManifestation"></see>
    /// </summary>
    let hasManifestation = _prefix "hasManifestation"

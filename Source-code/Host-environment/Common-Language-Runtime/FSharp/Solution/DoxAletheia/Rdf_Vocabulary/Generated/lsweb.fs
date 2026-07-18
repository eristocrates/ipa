namespace http.ontology.cybershare.utep.edu.ELSEWeb.elseweb_data.owl.hash

open DoxAletheia.Rdf_Vocabulary

module lsweb =
    let _namespace_name =
        "http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#"

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Characteristic"></see>
    /// </summary>
    let Characteristic =
        Namespaced_IRI.parse _namespace_name "Characteristic" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#DatasetManifestation"></see>
    /// </summary>
    let DatasetManifestation =
        Namespaced_IRI.parse _namespace_name "DatasetManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Entity"></see>
    /// </summary>
    let Entity = Namespaced_IRI.parse _namespace_name "Entity" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Format"></see>
    /// </summary>
    let Format = Namespaced_IRI.parse _namespace_name "Format" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#GeographicRegion"></see>
    /// </summary>
    let GeographicRegion =
        Namespaced_IRI.parse _namespace_name "GeographicRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#GeospatialDataset"></see>
    /// </summary>
    let GeospatialDataset =
        Namespaced_IRI.parse _namespace_name "GeospatialDataset" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Provider"></see>
    /// </summary>
    let Provider = Namespaced_IRI.parse _namespace_name "Provider" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Theme"></see>
    /// </summary>
    let Theme = Namespaced_IRI.parse _namespace_name "Theme" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#TimePeriod"></see>
    /// </summary>
    let TimePeriod = Namespaced_IRI.parse _namespace_name "TimePeriod" |> NamespacedName
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Unit"></see>
    /// </summary>
    let Unit = Namespaced_IRI.parse _namespace_name "Unit" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#encodedInFormat"></see>
    /// </summary>
    let encodedInFormat =
        Namespaced_IRI.parse _namespace_name "encodedInFormat" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#hasManifestation"></see>
    /// </summary>
    let hasManifestation =
        Namespaced_IRI.parse _namespace_name "hasManifestation" |> NamespacedName

namespace http.rdf.insee.fr.def.demo.hash

open DoxAletheia.Rdf_Vocabulary

module idemo =
    let _namespace_name = "http://rdf.insee.fr/def/demo#"

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/demo#PopulationLegale"></see>
    /// </summary>
    let PopulationLegale =
        Namespaced_IRI.parse _namespace_name "PopulationLegale" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/demo#date"></see>
    /// </summary>
    let date = Namespaced_IRI.parse _namespace_name "date" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/demo#population"></see>
    /// </summary>
    let population = Namespaced_IRI.parse _namespace_name "population" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/demo#populationCompteeAPart"></see>
    /// </summary>
    let populationCompteeAPart =
        Namespaced_IRI.parse _namespace_name "populationCompteeAPart" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/demo#populationMunicipale"></see>
    /// </summary>
    let populationMunicipale =
        Namespaced_IRI.parse _namespace_name "populationMunicipale" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/demo#populationTotale"></see>
    /// </summary>
    let populationTotale =
        Namespaced_IRI.parse _namespace_name "populationTotale" |> NamespacedName

namespace http.rdf.insee.fr.def.demo.hash

open DoxAletheia

module idemo =
    let _namespace_name = "http://rdf.insee.fr/def/demo#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/demo#PopulationLegale"></see>
    /// </summary>
    let PopulationLegale = _prefix "PopulationLegale"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/demo#date"></see>
    /// </summary>
    let date = _prefix "date"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/demo#population"></see>
    /// </summary>
    let population = _prefix "population"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/demo#populationCompteeAPart"></see>
    /// </summary>
    let populationCompteeAPart = _prefix "populationCompteeAPart"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/demo#populationMunicipale"></see>
    /// </summary>
    let populationMunicipale = _prefix "populationMunicipale"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/demo#populationTotale"></see>
    /// </summary>
    let populationTotale = _prefix "populationTotale"

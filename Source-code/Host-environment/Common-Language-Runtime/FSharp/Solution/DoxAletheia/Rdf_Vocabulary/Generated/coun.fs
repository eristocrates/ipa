namespace http.www.daml.org._2001._09.countries.iso_3166_ont.hash

open DoxAletheia.Rdf_Vocabulary

module coun =
    let _namespace_name = "http://www.daml.org/2001/09/countries/iso-3166-ont#"
    /// <summary>
    ///   <see href="http://www.daml.org/2001/09/countries/iso-3166-ont#Country"></see>
    /// </summary>
    let Country = Namespaced_IRI.parse _namespace_name "Country" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.daml.org/2001/09/countries/iso-3166-ont#code"></see>
    /// </summary>
    let code = Namespaced_IRI.parse _namespace_name "code" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.daml.org/2001/09/countries/iso-3166-ont#name"></see>
    /// </summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName

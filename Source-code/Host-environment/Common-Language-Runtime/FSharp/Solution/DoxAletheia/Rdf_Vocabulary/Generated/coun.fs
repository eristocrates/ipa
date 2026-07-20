namespace http.www.daml.org._2001._09.countries.iso_3166_ont.hash

open DoxAletheia

module coun =
    let _namespace_name = "http://www.daml.org/2001/09/countries/iso-3166-ont#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/2001/09/countries/iso-3166-ont#Country"></see>
    /// </summary>
    let Country = _prefix "Country"
    /// <summary>
    ///   <see href="http://www.daml.org/2001/09/countries/iso-3166-ont#code"></see>
    /// </summary>
    let code = _prefix "code"
    /// <summary>
    ///   <see href="http://www.daml.org/2001/09/countries/iso-3166-ont#name"></see>
    /// </summary>
    let name = _prefix "name"

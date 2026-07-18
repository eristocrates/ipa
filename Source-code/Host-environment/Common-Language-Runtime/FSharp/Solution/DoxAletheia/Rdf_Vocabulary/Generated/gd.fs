namespace http.reference.data.gov.def.govdata.slash

open DoxAletheia.Rdf_Vocabulary

module gd =
    let _namespace_name = "http://reference.data.gov/def/govdata/"
    /// <summary>
    ///   <see href="http://reference.data.gov/def/govdata/Country"></see>
    /// </summary>
    let Country = Namespaced_IRI.parse _namespace_name "Country" |> NamespacedName
    /// <summary>
    ///   <see href="http://reference.data.gov/def/govdata/County"></see>
    /// </summary>
    let County = Namespaced_IRI.parse _namespace_name "County" |> NamespacedName
    /// <summary>
    ///   <see href="http://reference.data.gov/def/govdata/Record"></see>
    /// </summary>
    let Record = Namespaced_IRI.parse _namespace_name "Record" |> NamespacedName
    /// <summary>
    ///   <see href="http://reference.data.gov/def/govdata/RecordSet"></see>
    /// </summary>
    let RecordSet = Namespaced_IRI.parse _namespace_name "RecordSet" |> NamespacedName
    /// <summary>
    ///   <see href="http://reference.data.gov/def/govdata/Report"></see>
    /// </summary>
    let Report = Namespaced_IRI.parse _namespace_name "Report" |> NamespacedName
    /// <summary>
    ///   <see href="http://reference.data.gov/def/govdata/Site"></see>
    /// </summary>
    let Site = Namespaced_IRI.parse _namespace_name "Site" |> NamespacedName
    /// <summary>
    ///   <see href="http://reference.data.gov/def/govdata/State"></see>
    /// </summary>
    let State = Namespaced_IRI.parse _namespace_name "State" |> NamespacedName
    /// <summary>
    ///   <see href="http://reference.data.gov/def/govdata/Survey"></see>
    /// </summary>
    let Survey = Namespaced_IRI.parse _namespace_name "Survey" |> NamespacedName
    /// <summary>
    ///   <see href="http://reference.data.gov/def/govdata/count"></see>
    /// </summary>
    let count = Namespaced_IRI.parse _namespace_name "count" |> NamespacedName
    /// <summary>
    ///   <see href="http://reference.data.gov/def/govdata/country"></see>
    /// </summary>
    let country = Namespaced_IRI.parse _namespace_name "country" |> NamespacedName
    /// <summary>
    ///   <see href="http://reference.data.gov/def/govdata/countyCode"></see>
    /// </summary>
    let countyCode = Namespaced_IRI.parse _namespace_name "countyCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov/def/govdata/denominator"></see>
    /// </summary>
    let denominator =
        Namespaced_IRI.parse _namespace_name "denominator" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov/def/govdata/median"></see>
    /// </summary>
    let median = Namespaced_IRI.parse _namespace_name "median" |> NamespacedName
    /// <summary>
    ///   <see href="http://reference.data.gov/def/govdata/percentage"></see>
    /// </summary>
    let percentage = Namespaced_IRI.parse _namespace_name "percentage" |> NamespacedName
    /// <summary>
    ///   <see href="http://reference.data.gov/def/govdata/record"></see>
    /// </summary>
    let record = Namespaced_IRI.parse _namespace_name "record" |> NamespacedName
    /// <summary>
    ///   <see href="http://reference.data.gov/def/govdata/recordset"></see>
    /// </summary>
    let recordset = Namespaced_IRI.parse _namespace_name "recordset" |> NamespacedName
    /// <summary>
    ///   <see href="http://reference.data.gov/def/govdata/stateCode"></see>
    /// </summary>
    let stateCode = Namespaced_IRI.parse _namespace_name "stateCode" |> NamespacedName

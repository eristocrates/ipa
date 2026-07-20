namespace http.reference.data.gov.def.govdata.slash

open DoxAletheia

module gd =
    let _namespace_name = "http://reference.data.gov/def/govdata/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov/def/govdata/Country"></see>
    /// </summary>
    let Country = _prefix "Country"
    /// <summary>
    ///   <see href="http://reference.data.gov/def/govdata/County"></see>
    /// </summary>
    let County = _prefix "County"
    /// <summary>
    ///   <see href="http://reference.data.gov/def/govdata/Record"></see>
    /// </summary>
    let Record = _prefix "Record"
    /// <summary>
    ///   <see href="http://reference.data.gov/def/govdata/RecordSet"></see>
    /// </summary>
    let RecordSet = _prefix "RecordSet"
    /// <summary>
    ///   <see href="http://reference.data.gov/def/govdata/Report"></see>
    /// </summary>
    let Report = _prefix "Report"
    /// <summary>
    ///   <see href="http://reference.data.gov/def/govdata/Site"></see>
    /// </summary>
    let Site = _prefix "Site"
    /// <summary>
    ///   <see href="http://reference.data.gov/def/govdata/State"></see>
    /// </summary>
    let State = _prefix "State"
    /// <summary>
    ///   <see href="http://reference.data.gov/def/govdata/Survey"></see>
    /// </summary>
    let Survey = _prefix "Survey"
    /// <summary>
    ///   <see href="http://reference.data.gov/def/govdata/count"></see>
    /// </summary>
    let count = _prefix "count"
    /// <summary>
    ///   <see href="http://reference.data.gov/def/govdata/country"></see>
    /// </summary>
    let country = _prefix "country"
    /// <summary>
    ///   <see href="http://reference.data.gov/def/govdata/countyCode"></see>
    /// </summary>
    let countyCode = _prefix "countyCode"
    /// <summary>
    ///   <see href="http://reference.data.gov/def/govdata/denominator"></see>
    /// </summary>
    let denominator = _prefix "denominator"
    /// <summary>
    ///   <see href="http://reference.data.gov/def/govdata/median"></see>
    /// </summary>
    let median = _prefix "median"
    /// <summary>
    ///   <see href="http://reference.data.gov/def/govdata/percentage"></see>
    /// </summary>
    let percentage = _prefix "percentage"
    /// <summary>
    ///   <see href="http://reference.data.gov/def/govdata/record"></see>
    /// </summary>
    let record = _prefix "record"
    /// <summary>
    ///   <see href="http://reference.data.gov/def/govdata/recordset"></see>
    /// </summary>
    let recordset = _prefix "recordset"
    /// <summary>
    ///   <see href="http://reference.data.gov/def/govdata/stateCode"></see>
    /// </summary>
    let stateCode = _prefix "stateCode"

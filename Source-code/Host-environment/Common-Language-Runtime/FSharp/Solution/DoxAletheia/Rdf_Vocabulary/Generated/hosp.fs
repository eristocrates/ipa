namespace http.health.data.gov.def.hospital.slash

open DoxAletheia

module hosp =
    let _namespace_name = "http://health.data.gov/def/hospital/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://health.data.gov/def/hospital/Hospital"></see>
    /// </summary>
    let Hospital = _prefix "Hospital"
    /// <summary>
    ///   <see href="http://health.data.gov/def/hospital/HospitalOwnershipType"></see>
    /// </summary>
    let HospitalOwnershipType = _prefix "HospitalOwnershipType"
    /// <summary>
    ///   <see href="http://health.data.gov/def/hospital/HospitalType"></see>
    /// </summary>
    let HospitalType = _prefix "HospitalType"
    /// <summary>
    ///   <see href="http://health.data.gov/def/hospital/accreditation"></see>
    /// </summary>
    let accreditation = _prefix "accreditation"
    /// <summary>
    ///   <see href="http://health.data.gov/def/hospital/cacProvider"></see>
    /// </summary>
    let cacProvider = _prefix "cacProvider"
    /// <summary>
    ///   <see href="http://health.data.gov/def/hospital/emergencyServices"></see>
    /// </summary>
    let emergencyServices = _prefix "emergencyServices"
    /// <summary>
    ///   <see href="http://health.data.gov/def/hospital/mpvProvider"></see>
    /// </summary>
    let mpvProvider = _prefix "mpvProvider"
    /// <summary>
    ///   <see href="http://health.data.gov/def/hospital/ownership"></see>
    /// </summary>
    let ownership = _prefix "ownership"
    /// <summary>
    ///   <see href="http://health.data.gov/def/hospital/site"></see>
    /// </summary>
    let site = _prefix "site"
    /// <summary>
    ///   <see href="http://health.data.gov/def/hospital/treats"></see>
    /// </summary>
    let treats = _prefix "treats"
    /// <summary>
    ///   <see href="http://health.data.gov/def/hospital/type"></see>
    /// </summary>
    let type_ = _prefix "type"

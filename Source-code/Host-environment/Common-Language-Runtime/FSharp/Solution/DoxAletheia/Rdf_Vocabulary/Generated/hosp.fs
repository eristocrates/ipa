namespace http.health.data.gov.def.hospital.slash

open DoxAletheia.Rdf_Vocabulary

module hosp =
    let _namespace_name = "http://health.data.gov/def/hospital/"
    /// <summary>
    ///   <see href="http://health.data.gov/def/hospital/Hospital"></see>
    /// </summary>
    let Hospital = Namespaced_IRI.parse _namespace_name "Hospital" |> NamespacedName

    /// <summary>
    ///   <see href="http://health.data.gov/def/hospital/HospitalOwnershipType"></see>
    /// </summary>
    let HospitalOwnershipType =
        Namespaced_IRI.parse _namespace_name "HospitalOwnershipType" |> NamespacedName

    /// <summary>
    ///   <see href="http://health.data.gov/def/hospital/HospitalType"></see>
    /// </summary>
    let HospitalType =
        Namespaced_IRI.parse _namespace_name "HospitalType" |> NamespacedName

    /// <summary>
    ///   <see href="http://health.data.gov/def/hospital/accreditation"></see>
    /// </summary>
    let accreditation =
        Namespaced_IRI.parse _namespace_name "accreditation" |> NamespacedName

    /// <summary>
    ///   <see href="http://health.data.gov/def/hospital/cacProvider"></see>
    /// </summary>
    let cacProvider =
        Namespaced_IRI.parse _namespace_name "cacProvider" |> NamespacedName

    /// <summary>
    ///   <see href="http://health.data.gov/def/hospital/emergencyServices"></see>
    /// </summary>
    let emergencyServices =
        Namespaced_IRI.parse _namespace_name "emergencyServices" |> NamespacedName

    /// <summary>
    ///   <see href="http://health.data.gov/def/hospital/mpvProvider"></see>
    /// </summary>
    let mpvProvider =
        Namespaced_IRI.parse _namespace_name "mpvProvider" |> NamespacedName

    /// <summary>
    ///   <see href="http://health.data.gov/def/hospital/ownership"></see>
    /// </summary>
    let ownership = Namespaced_IRI.parse _namespace_name "ownership" |> NamespacedName
    /// <summary>
    ///   <see href="http://health.data.gov/def/hospital/site"></see>
    /// </summary>
    let site = Namespaced_IRI.parse _namespace_name "site" |> NamespacedName
    /// <summary>
    ///   <see href="http://health.data.gov/def/hospital/treats"></see>
    /// </summary>
    let treats = Namespaced_IRI.parse _namespace_name "treats" |> NamespacedName
    /// <summary>
    ///   <see href="http://health.data.gov/def/hospital/type"></see>
    /// </summary>
    let type_ = Namespaced_IRI.parse _namespace_name "type" |> NamespacedName

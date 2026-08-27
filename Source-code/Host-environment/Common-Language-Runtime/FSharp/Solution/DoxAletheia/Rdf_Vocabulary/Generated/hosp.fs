namespace http.health.data.gov.def.hospital.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module hosp =
    let _namespace_iri = Namespace_Iri hosp |> NamespaceIRI
    /// <summary>
    ///   <para>hosp:Hospital</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Hospital"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://health.data.gov/def/hospital/Hospital">http://health.data.gov/def/hospital/Hospital</seealso>
    let Hospital = Prefixed_Name(hosp, "Hospital") |> PrefixedName

    /// <summary>
    ///   <para>hosp:HospitalOwnershipType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"HospitalOwnershipType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://health.data.gov/def/hospital/HospitalOwnershipType">http://health.data.gov/def/hospital/HospitalOwnershipType</seealso>
    let HospitalOwnershipType =
        Prefixed_Name(hosp, "HospitalOwnershipType") |> PrefixedName

    /// <summary>
    ///   <para>hosp:HospitalType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"HospitalType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://health.data.gov/def/hospital/HospitalType">http://health.data.gov/def/hospital/HospitalType</seealso>
    let HospitalType = Prefixed_Name(hosp, "HospitalType") |> PrefixedName
    /// <summary>
    ///   <para>hosp:accreditation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"accreditation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://health.data.gov/def/hospital/accreditation">http://health.data.gov/def/hospital/accreditation</seealso>
    let accreditation = Prefixed_Name(hosp, "accreditation") |> PrefixedName
    /// <summary>
    ///   <para>hosp:cacProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"cacProvider"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://health.data.gov/def/hospital/cacProvider">http://health.data.gov/def/hospital/cacProvider</seealso>
    let cacProvider = Prefixed_Name(hosp, "cacProvider") |> PrefixedName
    /// <summary>
    ///   <para>hosp:emergencyServices</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"emergencyServices"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://health.data.gov/def/hospital/emergencyServices">http://health.data.gov/def/hospital/emergencyServices</seealso>
    let emergencyServices = Prefixed_Name(hosp, "emergencyServices") |> PrefixedName
    /// <summary>
    ///   <para>hosp:mpvProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"mpvProvider"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://health.data.gov/def/hospital/mpvProvider">http://health.data.gov/def/hospital/mpvProvider</seealso>
    let mpvProvider = Prefixed_Name(hosp, "mpvProvider") |> PrefixedName
    /// <summary>
    ///   <para>hosp:ownership</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"ownership"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://health.data.gov/def/hospital/ownership">http://health.data.gov/def/hospital/ownership</seealso>
    let ownership = Prefixed_Name(hosp, "ownership") |> PrefixedName
    /// <summary>
    ///   <para>hosp:site</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"site"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://health.data.gov/def/hospital/site">http://health.data.gov/def/hospital/site</seealso>
    let site = Prefixed_Name(hosp, "site") |> PrefixedName
    /// <summary>
    ///   <para>hosp:treats</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"treats"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://health.data.gov/def/hospital/treats">http://health.data.gov/def/hospital/treats</seealso>
    let treats = Prefixed_Name(hosp, "treats") |> PrefixedName
    /// <summary>
    ///   <para>hosp:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://health.data.gov/def/hospital/type">http://health.data.gov/def/hospital/type</seealso>
    let type_ = Prefixed_Name(hosp, "type") |> PrefixedName

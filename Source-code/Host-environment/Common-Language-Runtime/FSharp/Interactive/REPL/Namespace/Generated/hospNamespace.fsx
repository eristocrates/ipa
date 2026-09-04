#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module hosp =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://health.data.gov/def/hospital/" "hosp"

    /// <summary>
    ///   <para>rdfs:label : Hospital^^xsd:string</para>
    ///   <a href="http://health.data.gov/def/hospital/Hospital">hosp:Hospital</a>
    /// </summary>
    let Hospital = _prefixId.prefix "Hospital"
    /// <summary>
    ///   <para>rdfs:label : HospitalOwnershipType^^xsd:string</para>
    ///   <a href="http://health.data.gov/def/hospital/HospitalOwnershipType">hosp:HospitalOwnershipType</a>
    /// </summary>
    let HospitalOwnershipType = _prefixId.prefix "HospitalOwnershipType"
    /// <summary>
    ///   <para>rdfs:label : HospitalType^^xsd:string</para>
    ///   <a href="http://health.data.gov/def/hospital/HospitalType">hosp:HospitalType</a>
    /// </summary>
    let HospitalType = _prefixId.prefix "HospitalType"
    /// <summary>
    ///   <para>rdfs:label : accreditation^^xsd:string</para>
    ///   <a href="http://health.data.gov/def/hospital/accreditation">hosp:accreditation</a>
    /// </summary>
    let accreditation = _prefixId.prefix "accreditation"
    /// <summary>
    ///   <para>rdfs:label : cacProvider^^xsd:string</para>
    ///   <a href="http://health.data.gov/def/hospital/cacProvider">hosp:cacProvider</a>
    /// </summary>
    let cacProvider = _prefixId.prefix "cacProvider"
    /// <summary>
    ///   <para>rdfs:label : emergencyServices^^xsd:string</para>
    ///   <a href="http://health.data.gov/def/hospital/emergencyServices">hosp:emergencyServices</a>
    /// </summary>
    let emergencyServices = _prefixId.prefix "emergencyServices"
    /// <summary>
    ///   <para>rdfs:label : mpvProvider^^xsd:string</para>
    ///   <a href="http://health.data.gov/def/hospital/mpvProvider">hosp:mpvProvider</a>
    /// </summary>
    let mpvProvider = _prefixId.prefix "mpvProvider"
    /// <summary>
    ///   <para>rdfs:label : ownership^^xsd:string</para>
    ///   <a href="http://health.data.gov/def/hospital/ownership">hosp:ownership</a>
    /// </summary>
    let ownership = _prefixId.prefix "ownership"
    /// <summary>
    ///   <para>rdfs:label : site^^xsd:string</para>
    ///   <a href="http://health.data.gov/def/hospital/site">hosp:site</a>
    /// </summary>
    let site = _prefixId.prefix "site"
    /// <summary>
    ///   <para>rdfs:label : treats^^xsd:string</para>
    ///   <a href="http://health.data.gov/def/hospital/treats">hosp:treats</a>
    /// </summary>
    let treats = _prefixId.prefix "treats"
    /// <summary>
    ///   <para>rdfs:label : type^^xsd:string</para>
    ///   <a href="http://health.data.gov/def/hospital/type">hosp:type</a>
    /// </summary>
    let type_ = _prefixId.prefix "type"

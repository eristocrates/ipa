namespace https.w3id.org.dpv.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module w3dpv =
    let _namespace_iri = Namespace_Iri w3dpv |> NamespaceIRI

    /// <summary>
    ///   <para>w3dpv:RightExerciseActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RightExerciseActivity">https://w3id.org/dpv#RightExerciseActivity</seealso>
    let RightExerciseActivity =
        Prefixed_Name(w3dpv, "RightExerciseActivity") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:rights-classes</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#rights-classes">https://w3id.org/dpv#rights-classes</seealso>
    let rights_classes = Prefixed_Name(w3dpv, "rights-classes") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ConsentWithdrawn</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#ConsentStatus</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ConsentWithdrawn">https://w3id.org/dpv#ConsentWithdrawn</seealso>
    let ConsentWithdrawn = Prefixed_Name(w3dpv, "ConsentWithdrawn") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:CybersecurityTraining</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CybersecurityTraining">https://w3id.org/dpv#CybersecurityTraining</seealso>
    let CybersecurityTraining =
        Prefixed_Name(w3dpv, "CybersecurityTraining") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:StaffTraining</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#StaffTraining">https://w3id.org/dpv#StaffTraining</seealso>
    let StaffTraining = Prefixed_Name(w3dpv, "StaffTraining") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:DPIA</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DPIA">https://w3id.org/dpv#DPIA</seealso>
    let DPIA = Prefixed_Name(w3dpv, "DPIA") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RightsImpactAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RightsImpactAssessment">https://w3id.org/dpv#RightsImpactAssessment</seealso>
    let RightsImpactAssessment =
        Prefixed_Name(w3dpv, "RightsImpactAssessment") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataBackupProtocols</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataBackupProtocols">https://w3id.org/dpv#DataBackupProtocols</seealso>
    let DataBackupProtocols =
        Prefixed_Name(w3dpv, "DataBackupProtocols") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataBreachNotice</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataBreachNotice">https://w3id.org/dpv#DataBreachNotice</seealso>
    let DataBreachNotice = Prefixed_Name(w3dpv, "DataBreachNotice") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SecurityIncidentNotice</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SecurityIncidentNotice">https://w3id.org/dpv#SecurityIncidentNotice</seealso>
    let SecurityIncidentNotice =
        Prefixed_Name(w3dpv, "SecurityIncidentNotice") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataBreachNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataBreachNotification">https://w3id.org/dpv#DataBreachNotification</seealso>
    let DataBreachNotification =
        Prefixed_Name(w3dpv, "DataBreachNotification") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SecurityIncidentNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SecurityIncidentNotification">https://w3id.org/dpv#SecurityIncidentNotification</seealso>
    let SecurityIncidentNotification =
        Prefixed_Name(w3dpv, "SecurityIncidentNotification") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataBreachRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataBreachRecord">https://w3id.org/dpv#DataBreachRecord</seealso>
    let DataBreachRecord = Prefixed_Name(w3dpv, "DataBreachRecord") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RecordsOfActivities</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RecordsOfActivities">https://w3id.org/dpv#RecordsOfActivities</seealso>
    let RecordsOfActivities =
        Prefixed_Name(w3dpv, "RecordsOfActivities") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataController</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataController">https://w3id.org/dpv#DataController</seealso>
    let DataController = Prefixed_Name(w3dpv, "DataController") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:MobilePlatformSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#MobilePlatformSecurity">https://w3id.org/dpv#MobilePlatformSecurity</seealso>
    let MobilePlatformSecurity =
        Prefixed_Name(w3dpv, "MobilePlatformSecurity") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Modify</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Processing</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Modify">https://w3id.org/dpv#Modify</seealso>
    let Modify = Prefixed_Name(w3dpv, "Modify") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Monitor</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Processing</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Monitor">https://w3id.org/dpv#Monitor</seealso>
    let Monitor = Prefixed_Name(w3dpv, "Monitor") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:MonitoringPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#MonitoringPolicy">https://w3id.org/dpv#MonitoringPolicy</seealso>
    let MonitoringPolicy = Prefixed_Name(w3dpv, "MonitoringPolicy") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:MonotonicCounterPseudonymisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#MonotonicCounterPseudonymisation">https://w3id.org/dpv#MonotonicCounterPseudonymisation</seealso>
    let MonotonicCounterPseudonymisation =
        Prefixed_Name(w3dpv, "MonotonicCounterPseudonymisation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Move</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Processing</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Move">https://w3id.org/dpv#Move</seealso>
    let Move = Prefixed_Name(w3dpv, "Move") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:MultiFactorAuthentication</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#MultiFactorAuthentication">https://w3id.org/dpv#MultiFactorAuthentication</seealso>
    let MultiFactorAuthentication =
        Prefixed_Name(w3dpv, "MultiFactorAuthentication") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:MultiNationalScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#GeographicCoverage</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#MultiNationalScale">https://w3id.org/dpv#MultiNationalScale</seealso>
    let MultiNationalScale = Prefixed_Name(w3dpv, "MultiNationalScale") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:NDA</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#LegalMeasure</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NDA">https://w3id.org/dpv#NDA</seealso>
    let NDA = Prefixed_Name(w3dpv, "NDA") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:NationalAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NationalAuthority">https://w3id.org/dpv#NationalAuthority</seealso>
    let NationalAuthority = Prefixed_Name(w3dpv, "NationalAuthority") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:NationalScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#GeographicCoverage</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NationalScale">https://w3id.org/dpv#NationalScale</seealso>
    let NationalScale = Prefixed_Name(w3dpv, "NationalScale") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:NearlyGlobalScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#GeographicCoverage</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NearlyGlobalScale">https://w3id.org/dpv#NearlyGlobalScale</seealso>
    let NearlyGlobalScale = Prefixed_Name(w3dpv, "NearlyGlobalScale") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Necessity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Necessity">https://w3id.org/dpv#Necessity</seealso>
    let Necessity = Prefixed_Name(w3dpv, "Necessity") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:NegotiateContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NegotiateContract">https://w3id.org/dpv#NegotiateContract</seealso>
    let NegotiateContract = Prefixed_Name(w3dpv, "NegotiateContract") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:NegotiatedContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#LegalBasis</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NegotiatedContract">https://w3id.org/dpv#NegotiatedContract</seealso>
    let NegotiatedContract = Prefixed_Name(w3dpv, "NegotiatedContract") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:NetworkProxyRouting</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NetworkProxyRouting">https://w3id.org/dpv#NetworkProxyRouting</seealso>
    let NetworkProxyRouting =
        Prefixed_Name(w3dpv, "NetworkProxyRouting") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PhysicalSupplySecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#PhysicalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PhysicalSupplySecurity">https://w3id.org/dpv#PhysicalSupplySecurity</seealso>
    let PhysicalSupplySecurity =
        Prefixed_Name(w3dpv, "PhysicalSupplySecurity") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PhysicalSurveillance</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#PhysicalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PhysicalSurveillance">https://w3id.org/dpv#PhysicalSurveillance</seealso>
    let PhysicalSurveillance =
        Prefixed_Name(w3dpv, "PhysicalSurveillance") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PoliticalCampaign</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PoliticalCampaign">https://w3id.org/dpv#PoliticalCampaign</seealso>
    let PoliticalCampaign = Prefixed_Name(w3dpv, "PoliticalCampaign") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PostQuantumCryptography</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PostQuantumCryptography">https://w3id.org/dpv#PostQuantumCryptography</seealso>
    let PostQuantumCryptography =
        Prefixed_Name(w3dpv, "PostQuantumCryptography") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PostedNotice</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PostedNotice">https://w3id.org/dpv#PostedNotice</seealso>
    let PostedNotice = Prefixed_Name(w3dpv, "PostedNotice") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:PrimaryImportance</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Importance</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PrimaryImportance">https://w3id.org/dpv#PrimaryImportance</seealso>
    let PrimaryImportance = Prefixed_Name(w3dpv, "PrimaryImportance") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:PrimaryUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#ReuseCompatibility</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PrimaryUse">https://w3id.org/dpv#PrimaryUse</seealso>
    let PrimaryUse = Prefixed_Name(w3dpv, "PrimaryUse") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Principle</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Principle">https://w3id.org/dpv#Principle</seealso>
    let Principle = Prefixed_Name(w3dpv, "Principle") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:PrintedNotice</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PrintedNotice">https://w3id.org/dpv#PrintedNotice</seealso>
    let PrintedNotice = Prefixed_Name(w3dpv, "PrintedNotice") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:PrivacyByDefault</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PrivacyByDefault">https://w3id.org/dpv#PrivacyByDefault</seealso>
    let PrivacyByDefault = Prefixed_Name(w3dpv, "PrivacyByDefault") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PrivacyPreservingProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PrivacyPreservingProtocol">https://w3id.org/dpv#PrivacyPreservingProtocol</seealso>
    let PrivacyPreservingProtocol =
        Prefixed_Name(w3dpv, "PrivacyPreservingProtocol") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PrivateCommunalSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Location</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PrivateCommunalSpace">https://w3id.org/dpv#PrivateCommunalSpace</seealso>
    let PrivateCommunalSpace =
        Prefixed_Name(w3dpv, "PrivateCommunalSpace") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PrivateInformationRetrieval</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PrivateInformationRetrieval">https://w3id.org/dpv#PrivateInformationRetrieval</seealso>
    let PrivateInformationRetrieval =
        Prefixed_Name(w3dpv, "PrivateInformationRetrieval") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PrivateLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Location</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PrivateLocation">https://w3id.org/dpv#PrivateLocation</seealso>
    let PrivateLocation = Prefixed_Name(w3dpv, "PrivateLocation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PrivatelyOperatedPublicSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Location</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PrivatelyOperatedPublicSpace">https://w3id.org/dpv#PrivatelyOperatedPublicSpace</seealso>
    let PrivatelyOperatedPublicSpace =
        Prefixed_Name(w3dpv, "PrivatelyOperatedPublicSpace") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PubliclyAccessibleSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Location</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PubliclyAccessibleSpace">https://w3id.org/dpv#PubliclyAccessibleSpace</seealso>
    let PubliclyAccessibleSpace =
        Prefixed_Name(w3dpv, "PubliclyAccessibleSpace") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PrivatelyOwnedPublicSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Location</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PrivatelyOwnedPublicSpace">https://w3id.org/dpv#PrivatelyOwnedPublicSpace</seealso>
    let PrivatelyOwnedPublicSpace =
        Prefixed_Name(w3dpv, "PrivatelyOwnedPublicSpace") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PrivatelyOwnedSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Location</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PrivatelyOwnedSpace">https://w3id.org/dpv#PrivatelyOwnedSpace</seealso>
    let PrivatelyOwnedSpace =
        Prefixed_Name(w3dpv, "PrivatelyOwnedSpace") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ProcessingCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ProcessingCondition">https://w3id.org/dpv#ProcessingCondition</seealso>
    let ProcessingCondition =
        Prefixed_Name(w3dpv, "ProcessingCondition") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ProcessingDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ProcessingDuration">https://w3id.org/dpv#ProcessingDuration</seealso>
    let ProcessingDuration = Prefixed_Name(w3dpv, "ProcessingDuration") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ProcessingLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ProcessingLocation">https://w3id.org/dpv#ProcessingLocation</seealso>
    let ProcessingLocation = Prefixed_Name(w3dpv, "ProcessingLocation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SecurityIncidentRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SecurityIncidentRecord">https://w3id.org/dpv#SecurityIncidentRecord</seealso>
    let SecurityIncidentRecord =
        Prefixed_Name(w3dpv, "SecurityIncidentRecord") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SecurityKnowledgeTraining</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SecurityKnowledgeTraining">https://w3id.org/dpv#SecurityKnowledgeTraining</seealso>
    let SecurityKnowledgeTraining =
        Prefixed_Name(w3dpv, "SecurityKnowledgeTraining") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SecurityRoleProcedures</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SecurityRoleProcedures">https://w3id.org/dpv#SecurityRoleProcedures</seealso>
    let SecurityRoleProcedures =
        Prefixed_Name(w3dpv, "SecurityRoleProcedures") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SellDataToThirdParties</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SellDataToThirdParties">https://w3id.org/dpv#SellDataToThirdParties</seealso>
    let SellDataToThirdParties =
        Prefixed_Name(w3dpv, "SellDataToThirdParties") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SellProducts</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SellProducts">https://w3id.org/dpv#SellProducts</seealso>
    let SellProducts = Prefixed_Name(w3dpv, "SellProducts") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasRequestStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasRequestStatus">https://w3id.org/dpv#hasRequestStatus</seealso>
    let hasRequestStatus = Prefixed_Name(w3dpv, "hasRequestStatus") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasResidualRisk</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasResidualRisk">https://w3id.org/dpv#hasResidualRisk</seealso>
    let hasResidualRisk = Prefixed_Name(w3dpv, "hasResidualRisk") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasResponsibleEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasResponsibleEntity">https://w3id.org/dpv#hasResponsibleEntity</seealso>
    let hasResponsibleEntity =
        Prefixed_Name(w3dpv, "hasResponsibleEntity") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasReuseCompatibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasReuseCompatibility">https://w3id.org/dpv#hasReuseCompatibility</seealso>
    let hasReuseCompatibility =
        Prefixed_Name(w3dpv, "hasReuseCompatibility") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasRight">https://w3id.org/dpv#hasRight</seealso>
    let hasRight = Prefixed_Name(w3dpv, "hasRight") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasRisk</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasRisk">https://w3id.org/dpv#hasRisk</seealso>
    let hasRisk = Prefixed_Name(w3dpv, "hasRisk") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:CannotWithdrawFromProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#EntityNonPermissiveInvolvement</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CannotWithdrawFromProcess">https://w3id.org/dpv#CannotWithdrawFromProcess</seealso>
    let CannotWithdrawFromProcess =
        Prefixed_Name(w3dpv, "CannotWithdrawFromProcess") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractConfidentialityClause</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#ContractualClause</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractConfidentialityClause">https://w3id.org/dpv#ContractConfidentialityClause</seealso>
    let ContractConfidentialityClause =
        Prefixed_Name(w3dpv, "ContractConfidentialityClause") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataSecurityManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataSecurityManagement">https://w3id.org/dpv#DataSecurityManagement</seealso>
    let DataSecurityManagement =
        Prefixed_Name(w3dpv, "DataSecurityManagement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataStoragePolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataStoragePolicy">https://w3id.org/dpv#DataStoragePolicy</seealso>
    let DataStoragePolicy = Prefixed_Name(w3dpv, "DataStoragePolicy") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:DataSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataSubject">https://w3id.org/dpv#DataSubject</seealso>
    let DataSubject = Prefixed_Name(w3dpv, "DataSubject") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataSubjectInformed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#EntityInformedStatus</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataSubjectInformed">https://w3id.org/dpv#DataSubjectInformed</seealso>
    let DataSubjectInformed =
        Prefixed_Name(w3dpv, "DataSubjectInformed") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataSubjectRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Right</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataSubjectRight">https://w3id.org/dpv#DataSubjectRight</seealso>
    let DataSubjectRight = Prefixed_Name(w3dpv, "DataSubjectRight") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:RightsManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RightsManagement">https://w3id.org/dpv#RightsManagement</seealso>
    let RightsManagement = Prefixed_Name(w3dpv, "RightsManagement") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Scale</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Scale">https://w3id.org/dpv#Scale</seealso>
    let Scale = Prefixed_Name(w3dpv, "Scale") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:processing-scale-classes</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#processing-scale-classes">https://w3id.org/dpv#processing-scale-classes</seealso>
    let processing_scale_classes =
        Prefixed_Name(w3dpv, "processing-scale-classes") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:JITNotice</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#JITNotice">https://w3id.org/dpv#JITNotice</seealso>
    let JITNotice = Prefixed_Name(w3dpv, "JITNotice") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:JobApplicant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#HumanSubject</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#JobApplicant">https://w3id.org/dpv#JobApplicant</seealso>
    let JobApplicant = Prefixed_Name(w3dpv, "JobApplicant") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:JointDataControllers</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#JointDataControllers">https://w3id.org/dpv#JointDataControllers</seealso>
    let JointDataControllers =
        Prefixed_Name(w3dpv, "JointDataControllers") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:JointDataControllersAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#LegalBasis</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#LegalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#JointDataControllersAgreement">https://w3id.org/dpv#JointDataControllersAgreement</seealso>
    let JointDataControllersAgreement =
        Prefixed_Name(w3dpv, "JointDataControllersAgreement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Justification</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Justification">https://w3id.org/dpv#Justification</seealso>
    let Justification = Prefixed_Name(w3dpv, "Justification") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:LargeDataVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#DataVolume</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#LargeDataVolume">https://w3id.org/dpv#LargeDataVolume</seealso>
    let LargeDataVolume = Prefixed_Name(w3dpv, "LargeDataVolume") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:LargeScaleOfDataSubjects</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#DataSubjectScale</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#LargeScaleOfDataSubjects">https://w3id.org/dpv#LargeScaleOfDataSubjects</seealso>
    let LargeScaleOfDataSubjects =
        Prefixed_Name(w3dpv, "LargeScaleOfDataSubjects") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:LargeScaleProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#ProcessingScale</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#LargeScaleProcessing">https://w3id.org/dpv#LargeScaleProcessing</seealso>
    let LargeScaleProcessing =
        Prefixed_Name(w3dpv, "LargeScaleProcessing") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ProcessingScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ProcessingScale">https://w3id.org/dpv#ProcessingScale</seealso>
    let ProcessingScale = Prefixed_Name(w3dpv, "ProcessingScale") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Law</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Law">https://w3id.org/dpv#Law</seealso>
    let Law = Prefixed_Name(w3dpv, "Law") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Lawful</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Lawfulness</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Lawful">https://w3id.org/dpv#Lawful</seealso>
    let Lawful = Prefixed_Name(w3dpv, "Lawful") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Lawfulness</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Lawfulness">https://w3id.org/dpv#Lawfulness</seealso>
    let Lawfulness = Prefixed_Name(w3dpv, "Lawfulness") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ObligationViolated</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#RuleFulfilmentStatus</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ObligationViolated">https://w3id.org/dpv#ObligationViolated</seealso>
    let ObligationViolated = Prefixed_Name(w3dpv, "ObligationViolated") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:RuleViolated</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#RuleFulfilmentStatus</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RuleViolated">https://w3id.org/dpv#RuleViolated</seealso>
    let RuleViolated = Prefixed_Name(w3dpv, "RuleViolated") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Observe</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Processing</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Observe">https://w3id.org/dpv#Observe</seealso>
    let Observe = Prefixed_Name(w3dpv, "Observe") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ObservedPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ObservedPersonalData">https://w3id.org/dpv#ObservedPersonalData</seealso>
    let ObservedPersonalData =
        Prefixed_Name(w3dpv, "ObservedPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ObtainConsent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ObtainConsent">https://w3id.org/dpv#ObtainConsent</seealso>
    let ObtainConsent = Prefixed_Name(w3dpv, "ObtainConsent") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Share</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Processing</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Share">https://w3id.org/dpv#Share</seealso>
    let Share = Prefixed_Name(w3dpv, "Share") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:SingleSignOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SingleSignOn">https://w3id.org/dpv#SingleSignOn</seealso>
    let SingleSignOn = Prefixed_Name(w3dpv, "SingleSignOn") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:SingularDataVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#DataVolume</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SingularDataVolume">https://w3id.org/dpv#SingularDataVolume</seealso>
    let SingularDataVolume = Prefixed_Name(w3dpv, "SingularDataVolume") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SingularScaleOfDataSubjects</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#DataSubjectScale</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SingularScaleOfDataSubjects">https://w3id.org/dpv#SingularScaleOfDataSubjects</seealso>
    let SingularScaleOfDataSubjects =
        Prefixed_Name(w3dpv, "SingularScaleOfDataSubjects") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SmallDataVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#DataVolume</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SmallDataVolume">https://w3id.org/dpv#SmallDataVolume</seealso>
    let SmallDataVolume = Prefixed_Name(w3dpv, "SmallDataVolume") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SmallScaleOfDataSubjects</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#DataSubjectScale</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SmallScaleOfDataSubjects">https://w3id.org/dpv#SmallScaleOfDataSubjects</seealso>
    let SmallScaleOfDataSubjects =
        Prefixed_Name(w3dpv, "SmallScaleOfDataSubjects") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SmallScaleProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#ProcessingScale</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SmallScaleProcessing">https://w3id.org/dpv#SmallScaleProcessing</seealso>
    let SmallScaleProcessing =
        Prefixed_Name(w3dpv, "SmallScaleProcessing") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SocialMediaMarketing</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SocialMediaMarketing">https://w3id.org/dpv#SocialMediaMarketing</seealso>
    let SocialMediaMarketing =
        Prefixed_Name(w3dpv, "SocialMediaMarketing") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SporadicDataVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#DataVolume</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SporadicDataVolume">https://w3id.org/dpv#SporadicDataVolume</seealso>
    let SporadicDataVolume = Prefixed_Name(w3dpv, "SporadicDataVolume") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:SporadicFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Frequency</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SporadicFrequency">https://w3id.org/dpv#SporadicFrequency</seealso>
    let SporadicFrequency = Prefixed_Name(w3dpv, "SporadicFrequency") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SporadicScaleOfDataSubjects</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#DataSubjectScale</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SporadicScaleOfDataSubjects">https://w3id.org/dpv#SporadicScaleOfDataSubjects</seealso>
    let SporadicScaleOfDataSubjects =
        Prefixed_Name(w3dpv, "SporadicScaleOfDataSubjects") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasAuthority">https://w3id.org/dpv#hasAuthority</seealso>
    let hasAuthority = Prefixed_Name(w3dpv, "hasAuthority") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasAutomationLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasAutomationLevel">https://w3id.org/dpv#hasAutomationLevel</seealso>
    let hasAutomationLevel = Prefixed_Name(w3dpv, "hasAutomationLevel") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasComplianceStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasComplianceStatus">https://w3id.org/dpv#hasComplianceStatus</seealso>
    let hasComplianceStatus =
        Prefixed_Name(w3dpv, "hasComplianceStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasConformanceStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasConformanceStatus">https://w3id.org/dpv#hasConformanceStatus</seealso>
    let hasConformanceStatus =
        Prefixed_Name(w3dpv, "hasConformanceStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasConsentControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasConsentControl">https://w3id.org/dpv#hasConsentControl</seealso>
    let hasConsentControl = Prefixed_Name(w3dpv, "hasConsentControl") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:consent-controls-classes</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#consent-controls-classes">https://w3id.org/dpv#consent-controls-classes</seealso>
    let consent_controls_classes =
        Prefixed_Name(w3dpv, "consent-controls-classes") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:HardwareSecurityProtocols</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#HardwareSecurityProtocols">https://w3id.org/dpv#HardwareSecurityProtocols</seealso>
    let HardwareSecurityProtocols =
        Prefixed_Name(w3dpv, "HardwareSecurityProtocols") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:HashFunctions</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#HashFunctions">https://w3id.org/dpv#HashFunctions</seealso>
    let HashFunctions = Prefixed_Name(w3dpv, "HashFunctions") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:LocalLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Location</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#LocalLocation">https://w3id.org/dpv#LocalLocation</seealso>
    let LocalLocation = Prefixed_Name(w3dpv, "LocalLocation") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:LocationLocality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Location</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#LocationLocality">https://w3id.org/dpv#LocationLocality</seealso>
    let LocationLocality = Prefixed_Name(w3dpv, "LocationLocality") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:PartialAutomation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#AutomationLevel</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PartialAutomation">https://w3id.org/dpv#PartialAutomation</seealso>
    let PartialAutomation = Prefixed_Name(w3dpv, "PartialAutomation") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Query</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Processing</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Query">https://w3id.org/dpv#Query</seealso>
    let Query = Prefixed_Name(w3dpv, "Query") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:SupraNationalUnion</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SupraNationalUnion">https://w3id.org/dpv#SupraNationalUnion</seealso>
    let SupraNationalUnion = Prefixed_Name(w3dpv, "SupraNationalUnion") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasConsequenceOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasConsequenceOn">https://w3id.org/dpv#hasConsequenceOn</seealso>
    let hasConsequenceOn = Prefixed_Name(w3dpv, "hasConsequenceOn") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:isRepresentativeFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#isRepresentativeFor">https://w3id.org/dpv#isRepresentativeFor</seealso>
    let isRepresentativeFor =
        Prefixed_Name(w3dpv, "isRepresentativeFor") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Aggregate</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Processing</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Aggregate">https://w3id.org/dpv#Aggregate</seealso>
    let Aggregate = Prefixed_Name(w3dpv, "Aggregate") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Alter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Processing</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Alter">https://w3id.org/dpv#Alter</seealso>
    let Alter = Prefixed_Name(w3dpv, "Alter") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:AlgorithmicLogic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#AlgorithmicLogic">https://w3id.org/dpv#AlgorithmicLogic</seealso>
    let AlgorithmicLogic = Prefixed_Name(w3dpv, "AlgorithmicLogic") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:AmbulanceProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#AmbulanceProvider">https://w3id.org/dpv#AmbulanceProvider</seealso>
    let AmbulanceProvider = Prefixed_Name(w3dpv, "AmbulanceProvider") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:EmergencyServiceProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#EmergencyServiceProvider">https://w3id.org/dpv#EmergencyServiceProvider</seealso>
    let EmergencyServiceProvider =
        Prefixed_Name(w3dpv, "EmergencyServiceProvider") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Analyse</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Processing</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Analyse">https://w3id.org/dpv#Analyse</seealso>
    let Analyse = Prefixed_Name(w3dpv, "Analyse") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ConformanceStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ConformanceStatus">https://w3id.org/dpv#ConformanceStatus</seealso>
    let ConformanceStatus = Prefixed_Name(w3dpv, "ConformanceStatus") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Conformant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#ConformanceStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Conformant">https://w3id.org/dpv#Conformant</seealso>
    let Conformant = Prefixed_Name(w3dpv, "Conformant") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Consent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#LegalBasis</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Consent">https://w3id.org/dpv#Consent</seealso>
    let Consent = Prefixed_Name(w3dpv, "Consent") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:legal-basis-classes</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#legal-basis-classes">https://w3id.org/dpv#legal-basis-classes</seealso>
    let legal_basis_classes =
        Prefixed_Name(w3dpv, "legal-basis-classes") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ConsentControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ConsentControl">https://w3id.org/dpv#ConsentControl</seealso>
    let ConsentControl = Prefixed_Name(w3dpv, "ConsentControl") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:EntityInvolvement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#EntityInvolvement">https://w3id.org/dpv#EntityInvolvement</seealso>
    let EntityInvolvement = Prefixed_Name(w3dpv, "EntityInvolvement") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ConsentExpired</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#ConsentStatus</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ConsentExpired">https://w3id.org/dpv#ConsentExpired</seealso>
    let ConsentExpired = Prefixed_Name(w3dpv, "ConsentExpired") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ConsentStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ConsentStatus">https://w3id.org/dpv#ConsentStatus</seealso>
    let ConsentStatus = Prefixed_Name(w3dpv, "ConsentStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ConsentStatusInvalidForProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#ConsentStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ConsentStatusInvalidForProcessing">https://w3id.org/dpv#ConsentStatusInvalidForProcessing</seealso>
    let ConsentStatusInvalidForProcessing =
        Prefixed_Name(w3dpv, "ConsentStatusInvalidForProcessing") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:consent-status-classes</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#consent-status-classes">https://w3id.org/dpv#consent-status-classes</seealso>
    let consent_status_classes =
        Prefixed_Name(w3dpv, "consent-status-classes") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ConsentInvalidated</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#ConsentStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ConsentInvalidated">https://w3id.org/dpv#ConsentInvalidated</seealso>
    let ConsentInvalidated = Prefixed_Name(w3dpv, "ConsentInvalidated") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ConsentManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ConsentManagement">https://w3id.org/dpv#ConsentManagement</seealso>
    let ConsentManagement = Prefixed_Name(w3dpv, "ConsentManagement") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:PrivacyNotice</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PrivacyNotice">https://w3id.org/dpv#PrivacyNotice</seealso>
    let PrivacyNotice = Prefixed_Name(w3dpv, "PrivacyNotice") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:notice-classes</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#notice-classes">https://w3id.org/dpv#notice-classes</seealso>
    let notice_classes = Prefixed_Name(w3dpv, "notice-classes") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ConsentReceipt</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ConsentReceipt">https://w3id.org/dpv#ConsentReceipt</seealso>
    let ConsentReceipt = Prefixed_Name(w3dpv, "ConsentReceipt") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ConsentRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ConsentRecord">https://w3id.org/dpv#ConsentRecord</seealso>
    let ConsentRecord = Prefixed_Name(w3dpv, "ConsentRecord") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataProcessingRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataProcessingRecord">https://w3id.org/dpv#DataProcessingRecord</seealso>
    let DataProcessingRecord =
        Prefixed_Name(w3dpv, "DataProcessingRecord") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ConsentRefused</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#ConsentStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ConsentRefused">https://w3id.org/dpv#ConsentRefused</seealso>
    let ConsentRefused = Prefixed_Name(w3dpv, "ConsentRefused") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ConsentRequestDeferred</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#ConsentStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ConsentRequestDeferred">https://w3id.org/dpv#ConsentRequestDeferred</seealso>
    let ConsentRequestDeferred =
        Prefixed_Name(w3dpv, "ConsentRequestDeferred") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:CredentialManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CredentialManagement">https://w3id.org/dpv#CredentialManagement</seealso>
    let CredentialManagement =
        Prefixed_Name(w3dpv, "CredentialManagement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:CrossBorderTransfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Processing</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CrossBorderTransfer">https://w3id.org/dpv#CrossBorderTransfer</seealso>
    let CrossBorderTransfer =
        Prefixed_Name(w3dpv, "CrossBorderTransfer") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Transfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Processing</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Transfer">https://w3id.org/dpv#Transfer</seealso>
    let Transfer = Prefixed_Name(w3dpv, "Transfer") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:CryptographicKeyManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CryptographicKeyManagement">https://w3id.org/dpv#CryptographicKeyManagement</seealso>
    let CryptographicKeyManagement =
        Prefixed_Name(w3dpv, "CryptographicKeyManagement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:EncryptionInUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#EncryptionInUse">https://w3id.org/dpv#EncryptionInUse</seealso>
    let EncryptionInUse = Prefixed_Name(w3dpv, "EncryptionInUse") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:EndToEndEncryption</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#EndToEndEncryption">https://w3id.org/dpv#EndToEndEncryption</seealso>
    let EndToEndEncryption = Prefixed_Name(w3dpv, "EndToEndEncryption") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:EndlessDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Duration</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#EndlessDuration">https://w3id.org/dpv#EndlessDuration</seealso>
    let EndlessDuration = Prefixed_Name(w3dpv, "EndlessDuration") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:EnforceAccessControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#EnforceAccessControl">https://w3id.org/dpv#EnforceAccessControl</seealso>
    let EnforceAccessControl =
        Prefixed_Name(w3dpv, "EnforceAccessControl") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:EnforceSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#EnforceSecurity">https://w3id.org/dpv#EnforceSecurity</seealso>
    let EnforceSecurity = Prefixed_Name(w3dpv, "EnforceSecurity") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:EnterIntoContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#LegalBasis</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#EnterIntoContract">https://w3id.org/dpv#EnterIntoContract</seealso>
    let EnterIntoContract = Prefixed_Name(w3dpv, "EnterIntoContract") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Entity">https://w3id.org/dpv#Entity</seealso>
    let Entity = Prefixed_Name(w3dpv, "Entity") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:entities-classes</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#entities-classes">https://w3id.org/dpv#entities-classes</seealso>
    let entities_classes = Prefixed_Name(w3dpv, "entities-classes") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:EntityActiveInvolvement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#EntityActiveInvolvement">https://w3id.org/dpv#EntityActiveInvolvement</seealso>
    let EntityActiveInvolvement =
        Prefixed_Name(w3dpv, "EntityActiveInvolvement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:EntityInvolved</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#EntityInvolvementStatus</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#EntityInvolved">https://w3id.org/dpv#EntityInvolved</seealso>
    let EntityInvolved = Prefixed_Name(w3dpv, "EntityInvolved") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:EntityNonInvolvement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#EntityNonInvolvement">https://w3id.org/dpv#EntityNonInvolvement</seealso>
    let EntityNonInvolvement =
        Prefixed_Name(w3dpv, "EntityNonInvolvement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:EntityNotInvolved</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#EntityInvolvementStatus</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#EntityNotInvolved">https://w3id.org/dpv#EntityNotInvolved</seealso>
    let EntityNotInvolved = Prefixed_Name(w3dpv, "EntityNotInvolved") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:EntityPassiveInvolvement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#EntityPassiveInvolvement">https://w3id.org/dpv#EntityPassiveInvolvement</seealso>
    let EntityPassiveInvolvement =
        Prefixed_Name(w3dpv, "EntityPassiveInvolvement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ImproveInternalCRMProcesses</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Purpose</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ImproveInternalCRMProcesses">https://w3id.org/dpv#ImproveInternalCRMProcesses</seealso>
    let ImproveInternalCRMProcesses =
        Prefixed_Name(w3dpv, "ImproveInternalCRMProcesses") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ImprovePublicServices</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ImprovePublicServices">https://w3id.org/dpv#ImprovePublicServices</seealso>
    let ImprovePublicServices =
        Prefixed_Name(w3dpv, "ImprovePublicServices") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ImproveTransportMobility</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ImproveTransportMobility">https://w3id.org/dpv#ImproveTransportMobility</seealso>
    let ImproveTransportMobility =
        Prefixed_Name(w3dpv, "ImproveTransportMobility") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:IncidentManagementProcedures</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#IncidentManagementProcedures">https://w3id.org/dpv#IncidentManagementProcedures</seealso>
    let IncidentManagementProcedures =
        Prefixed_Name(w3dpv, "IncidentManagementProcedures") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:IncidentReportingCommunication</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#IncidentReportingCommunication">https://w3id.org/dpv#IncidentReportingCommunication</seealso>
    let IncidentReportingCommunication =
        Prefixed_Name(w3dpv, "IncidentReportingCommunication") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:IncorrectData</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#IncorrectData">https://w3id.org/dpv#IncorrectData</seealso>
    let IncorrectData = Prefixed_Name(w3dpv, "IncorrectData") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PersonnelOffboarding</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Purpose</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PersonnelOffboarding">https://w3id.org/dpv#PersonnelOffboarding</seealso>
    let PersonnelOffboarding =
        Prefixed_Name(w3dpv, "PersonnelOffboarding") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PersonnelOnboarding</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PersonnelOnboarding">https://w3id.org/dpv#PersonnelOnboarding</seealso>
    let PersonnelOnboarding =
        Prefixed_Name(w3dpv, "PersonnelOnboarding") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PersonnelPayment</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PersonnelPayment">https://w3id.org/dpv#PersonnelPayment</seealso>
    let PersonnelPayment = Prefixed_Name(w3dpv, "PersonnelPayment") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PersonnelPerformanceEvaluation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PersonnelPerformanceEvaluation">https://w3id.org/dpv#PersonnelPerformanceEvaluation</seealso>
    let PersonnelPerformanceEvaluation =
        Prefixed_Name(w3dpv, "PersonnelPerformanceEvaluation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PersonnelPerformanceManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PersonnelPerformanceManagement">https://w3id.org/dpv#PersonnelPerformanceManagement</seealso>
    let PersonnelPerformanceManagement =
        Prefixed_Name(w3dpv, "PersonnelPerformanceManagement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RenewedConsentGiven</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#ConsentStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RenewedConsentGiven">https://w3id.org/dpv#RenewedConsentGiven</seealso>
    let RenewedConsentGiven =
        Prefixed_Name(w3dpv, "RenewedConsentGiven") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RepairImpairments</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Purpose</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RepairImpairments">https://w3id.org/dpv#RepairImpairments</seealso>
    let RepairImpairments = Prefixed_Name(w3dpv, "RepairImpairments") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:RequestAccepted</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#RequestStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RequestAccepted">https://w3id.org/dpv#RequestAccepted</seealso>
    let RequestAccepted = Prefixed_Name(w3dpv, "RequestAccepted") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:RequestStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RequestStatus">https://w3id.org/dpv#RequestStatus</seealso>
    let RequestStatus = Prefixed_Name(w3dpv, "RequestStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RequestAcknowledged</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#RequestStatus</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RequestAcknowledged">https://w3id.org/dpv#RequestAcknowledged</seealso>
    let RequestAcknowledged =
        Prefixed_Name(w3dpv, "RequestAcknowledged") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RequestActionDelayed</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#RequestStatus</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RequestActionDelayed">https://w3id.org/dpv#RequestActionDelayed</seealso>
    let RequestActionDelayed =
        Prefixed_Name(w3dpv, "RequestActionDelayed") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RequestFulfilled</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#RequestStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RequestFulfilled">https://w3id.org/dpv#RequestFulfilled</seealso>
    let RequestFulfilled = Prefixed_Name(w3dpv, "RequestFulfilled") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:RequestInitiated</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#RequestStatus</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RequestInitiated">https://w3id.org/dpv#RequestInitiated</seealso>
    let RequestInitiated = Prefixed_Name(w3dpv, "RequestInitiated") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RequestRequiredActionPerformed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#RequestStatus</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RequestRequiredActionPerformed">https://w3id.org/dpv#RequestRequiredActionPerformed</seealso>
    let RequestRequiredActionPerformed =
        Prefixed_Name(w3dpv, "RequestRequiredActionPerformed") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RequestRequiresAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#RequestStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RequestRequiresAction">https://w3id.org/dpv#RequestRequiresAction</seealso>
    let RequestRequiresAction =
        Prefixed_Name(w3dpv, "RequestRequiresAction") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RequestStatusQuery</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#RequestStatus</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RequestStatusQuery">https://w3id.org/dpv#RequestStatusQuery</seealso>
    let RequestStatusQuery = Prefixed_Name(w3dpv, "RequestStatusQuery") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:RequestUnfulfilled</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#RequestStatus</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RequestUnfulfilled">https://w3id.org/dpv#RequestUnfulfilled</seealso>
    let RequestUnfulfilled = Prefixed_Name(w3dpv, "RequestUnfulfilled") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Required</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Necessity</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Required">https://w3id.org/dpv#Required</seealso>
    let Required = Prefixed_Name(w3dpv, "Required") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ResidualRisk</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ResidualRisk">https://w3id.org/dpv#ResidualRisk</seealso>
    let ResidualRisk = Prefixed_Name(w3dpv, "ResidualRisk") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Risk</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Risk">https://w3id.org/dpv#Risk</seealso>
    let Risk = Prefixed_Name(w3dpv, "Risk") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Restrict</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Processing</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Restrict">https://w3id.org/dpv#Restrict</seealso>
    let Restrict = Prefixed_Name(w3dpv, "Restrict") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ReversingProcessInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#EntityPermissiveInvolvement</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ReversingProcessInput">https://w3id.org/dpv#ReversingProcessInput</seealso>
    let ReversingProcessInput =
        Prefixed_Name(w3dpv, "ReversingProcessInput") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ReversingProcessOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#EntityPermissiveInvolvement</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ReversingProcessOutput">https://w3id.org/dpv#ReversingProcessOutput</seealso>
    let ReversingProcessOutput =
        Prefixed_Name(w3dpv, "ReversingProcessOutput") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ReviewImpactAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ReviewImpactAssessment">https://w3id.org/dpv#ReviewImpactAssessment</seealso>
    let ReviewImpactAssessment =
        Prefixed_Name(w3dpv, "ReviewImpactAssessment") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ReviewProcedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ReviewProcedure">https://w3id.org/dpv#ReviewProcedure</seealso>
    let ReviewProcedure = Prefixed_Name(w3dpv, "ReviewProcedure") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RightExerciseNotice</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RightExerciseNotice">https://w3id.org/dpv#RightExerciseNotice</seealso>
    let RightExerciseNotice =
        Prefixed_Name(w3dpv, "RightExerciseNotice") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RightNotice</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RightNotice">https://w3id.org/dpv#RightNotice</seealso>
    let RightNotice = Prefixed_Name(w3dpv, "RightNotice") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RightFulfilmentNotice</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RightFulfilmentNotice">https://w3id.org/dpv#RightFulfilmentNotice</seealso>
    let RightFulfilmentNotice =
        Prefixed_Name(w3dpv, "RightFulfilmentNotice") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RightsFulfilment</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RightsFulfilment">https://w3id.org/dpv#RightsFulfilment</seealso>
    let RightsFulfilment = Prefixed_Name(w3dpv, "RightsFulfilment") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:RiskLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RiskLevel">https://w3id.org/dpv#RiskLevel</seealso>
    let RiskLevel = Prefixed_Name(w3dpv, "RiskLevel") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RiskMitigationMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RiskMitigationMeasure">https://w3id.org/dpv#RiskMitigationMeasure</seealso>
    let RiskMitigationMeasure =
        Prefixed_Name(w3dpv, "RiskMitigationMeasure") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SMEOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SMEOrganisation">https://w3id.org/dpv#SMEOrganisation</seealso>
    let SMEOrganisation = Prefixed_Name(w3dpv, "SMEOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SafeguardForDataTransfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SafeguardForDataTransfer">https://w3id.org/dpv#SafeguardForDataTransfer</seealso>
    let SafeguardForDataTransfer =
        Prefixed_Name(w3dpv, "SafeguardForDataTransfer") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ScientificResearch</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ScientificResearch">https://w3id.org/dpv#ScientificResearch</seealso>
    let ScientificResearch = Prefixed_Name(w3dpv, "ScientificResearch") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Scope</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Scope">https://w3id.org/dpv#Scope</seealso>
    let Scope = Prefixed_Name(w3dpv, "Scope") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Screen</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Processing</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Screen">https://w3id.org/dpv#Screen</seealso>
    let Screen = Prefixed_Name(w3dpv, "Screen") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Seal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Seal">https://w3id.org/dpv#Seal</seealso>
    let Seal = Prefixed_Name(w3dpv, "Seal") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SecondaryImportance</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Importance</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SecondaryImportance">https://w3id.org/dpv#SecondaryImportance</seealso>
    let SecondaryImportance =
        Prefixed_Name(w3dpv, "SecondaryImportance") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SecondaryUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#ReuseCompatibility</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SecondaryUse">https://w3id.org/dpv#SecondaryUse</seealso>
    let SecondaryUse = Prefixed_Name(w3dpv, "SecondaryUse") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SecretSharingSchemes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SecretSharingSchemes">https://w3id.org/dpv#SecretSharingSchemes</seealso>
    let SecretSharingSchemes =
        Prefixed_Name(w3dpv, "SecretSharingSchemes") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Sector</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Sector">https://w3id.org/dpv#Sector</seealso>
    let Sector = Prefixed_Name(w3dpv, "Sector") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SecureMultiPartyComputation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SecureMultiPartyComputation">https://w3id.org/dpv#SecureMultiPartyComputation</seealso>
    let SecureMultiPartyComputation =
        Prefixed_Name(w3dpv, "SecureMultiPartyComputation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SecureProcessingEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SecureProcessingEnvironment">https://w3id.org/dpv#SecureProcessingEnvironment</seealso>
    let SecureProcessingEnvironment =
        Prefixed_Name(w3dpv, "SecureProcessingEnvironment") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SecurityAudit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SecurityAudit">https://w3id.org/dpv#SecurityAudit</seealso>
    let SecurityAudit = Prefixed_Name(w3dpv, "SecurityAudit") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:CloudLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Location</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CloudLocation">https://w3id.org/dpv#CloudLocation</seealso>
    let CloudLocation = Prefixed_Name(w3dpv, "CloudLocation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractExecutionStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractExecutionStatus">https://w3id.org/dpv#ContractExecutionStatus</seealso>
    let ContractExecutionStatus =
        Prefixed_Name(w3dpv, "ContractExecutionStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataSubjectRightsManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataSubjectRightsManagement">https://w3id.org/dpv#DataSubjectRightsManagement</seealso>
    let DataSubjectRightsManagement =
        Prefixed_Name(w3dpv, "DataSubjectRightsManagement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataSubjectScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataSubjectScale">https://w3id.org/dpv#DataSubjectScale</seealso>
    let DataSubjectScale = Prefixed_Name(w3dpv, "DataSubjectScale") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataSubjectUninformed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#EntityInformedStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataSubjectUninformed">https://w3id.org/dpv#DataSubjectUninformed</seealso>
    let DataSubjectUninformed =
        Prefixed_Name(w3dpv, "DataSubjectUninformed") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:FixedSingularLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#LocationFixture</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#FixedSingularLocation">https://w3id.org/dpv#FixedSingularLocation</seealso>
    let FixedSingularLocation =
        Prefixed_Name(w3dpv, "FixedSingularLocation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:NoticeCommunicated</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#NoticeStatus</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NoticeCommunicated">https://w3id.org/dpv#NoticeCommunicated</seealso>
    let NoticeCommunicated = Prefixed_Name(w3dpv, "NoticeCommunicated") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:NoticeGenerated</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#NoticeStatus</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NoticeGenerated">https://w3id.org/dpv#NoticeGenerated</seealso>
    let NoticeGenerated = Prefixed_Name(w3dpv, "NoticeGenerated") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:NoticeLatest</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#NoticeStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NoticeLatest">https://w3id.org/dpv#NoticeLatest</seealso>
    let NoticeLatest = Prefixed_Name(w3dpv, "NoticeLatest") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:NoticeUpdated</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#NoticeStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NoticeUpdated">https://w3id.org/dpv#NoticeUpdated</seealso>
    let NoticeUpdated = Prefixed_Name(w3dpv, "NoticeUpdated") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:NoticeUsed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#NoticeStatus</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NoticeUsed">https://w3id.org/dpv#NoticeUsed</seealso>
    let NoticeUsed = Prefixed_Name(w3dpv, "NoticeUsed") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:NotificationCompleted</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#NotificationStatus</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NotificationCompleted">https://w3id.org/dpv#NotificationCompleted</seealso>
    let NotificationCompleted =
        Prefixed_Name(w3dpv, "NotificationCompleted") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:NotificationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NotificationStatus">https://w3id.org/dpv#NotificationStatus</seealso>
    let NotificationStatus = Prefixed_Name(w3dpv, "NotificationStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:NotificationNotNeeded</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#NotificationStatus</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NotificationNotNeeded">https://w3id.org/dpv#NotificationNotNeeded</seealso>
    let NotificationNotNeeded =
        Prefixed_Name(w3dpv, "NotificationNotNeeded") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ObjectingToProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#EntityPermissiveInvolvement</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ObjectingToProcess">https://w3id.org/dpv#ObjectingToProcess</seealso>
    let ObjectingToProcess = Prefixed_Name(w3dpv, "ObjectingToProcess") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Obligation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Rule</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Obligation">https://w3id.org/dpv#Obligation</seealso>
    let Obligation = Prefixed_Name(w3dpv, "Obligation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ObligationFulfilled</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#RuleFulfilmentStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ObligationFulfilled">https://w3id.org/dpv#ObligationFulfilled</seealso>
    let ObligationFulfilled =
        Prefixed_Name(w3dpv, "ObligationFulfilled") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ObligationUnfulfilled</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#RuleFulfilmentStatus</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ObligationUnfulfilled">https://w3id.org/dpv#ObligationUnfulfilled</seealso>
    let ObligationUnfulfilled =
        Prefixed_Name(w3dpv, "ObligationUnfulfilled") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ProvidedData</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ProvidedData">https://w3id.org/dpv#ProvidedData</seealso>
    let ProvidedData = Prefixed_Name(w3dpv, "ProvidedData") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ProvidedPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ProvidedPersonalData">https://w3id.org/dpv#ProvidedPersonalData</seealso>
    let ProvidedPersonalData =
        Prefixed_Name(w3dpv, "ProvidedPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ProviderStandardFormContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#LegalBasis</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ProviderStandardFormContract">https://w3id.org/dpv#ProviderStandardFormContract</seealso>
    let ProviderStandardFormContract =
        Prefixed_Name(w3dpv, "ProviderStandardFormContract") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Pseudonymise</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Processing</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Pseudonymise">https://w3id.org/dpv#Pseudonymise</seealso>
    let Pseudonymise = Prefixed_Name(w3dpv, "Pseudonymise") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:PublicDataSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#DataSource</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PublicDataSource">https://w3id.org/dpv#PublicDataSource</seealso>
    let PublicDataSource = Prefixed_Name(w3dpv, "PublicDataSource") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:PublicInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#LegalBasis</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PublicInterest">https://w3id.org/dpv#PublicInterest</seealso>
    let PublicInterest = Prefixed_Name(w3dpv, "PublicInterest") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PublicInterestCompleted</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#PublicInterestStatus</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PublicInterestCompleted">https://w3id.org/dpv#PublicInterestCompleted</seealso>
    let PublicInterestCompleted =
        Prefixed_Name(w3dpv, "PublicInterestCompleted") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PublicInterestStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PublicInterestStatus">https://w3id.org/dpv#PublicInterestStatus</seealso>
    let PublicInterestStatus =
        Prefixed_Name(w3dpv, "PublicInterestStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PublicInterestObjected</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#PublicInterestStatus</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PublicInterestObjected">https://w3id.org/dpv#PublicInterestObjected</seealso>
    let PublicInterestObjected =
        Prefixed_Name(w3dpv, "PublicInterestObjected") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PublicInterestOngoing</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#PublicInterestStatus</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PublicInterestOngoing">https://w3id.org/dpv#PublicInterestOngoing</seealso>
    let PublicInterestOngoing =
        Prefixed_Name(w3dpv, "PublicInterestOngoing") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PublicInterestPending</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#PublicInterestStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PublicInterestPending">https://w3id.org/dpv#PublicInterestPending</seealso>
    let PublicInterestPending =
        Prefixed_Name(w3dpv, "PublicInterestPending") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PublicLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Location</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PublicLocation">https://w3id.org/dpv#PublicLocation</seealso>
    let PublicLocation = Prefixed_Name(w3dpv, "PublicLocation") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasApplicableLaw</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasApplicableLaw">https://w3id.org/dpv#hasApplicableLaw</seealso>
    let hasApplicableLaw = Prefixed_Name(w3dpv, "hasApplicableLaw") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:jurisdiction-properties</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#jurisdiction-properties">https://w3id.org/dpv#jurisdiction-properties</seealso>
    let jurisdiction_properties =
        Prefixed_Name(w3dpv, "jurisdiction-properties") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasAssessment">https://w3id.org/dpv#hasAssessment</seealso>
    let hasAssessment = Prefixed_Name(w3dpv, "hasAssessment") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasOrganisationalMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasOrganisationalMeasure">https://w3id.org/dpv#hasOrganisationalMeasure</seealso>
    let hasOrganisationalMeasure =
        Prefixed_Name(w3dpv, "hasOrganisationalMeasure") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:isBefore</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#isBefore">https://w3id.org/dpv#isBefore</seealso>
    let isBefore = Prefixed_Name(w3dpv, "isBefore") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:isDeterminedByEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#isDeterminedByEntity">https://w3id.org/dpv#isDeterminedByEntity</seealso>
    let isDeterminedByEntity =
        Prefixed_Name(w3dpv, "isDeterminedByEntity") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:isDuring</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#isDuring">https://w3id.org/dpv#isDuring</seealso>
    let isDuring = Prefixed_Name(w3dpv, "isDuring") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:isExercisedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#isExercisedAt">https://w3id.org/dpv#isExercisedAt</seealso>
    let isExercisedAt = Prefixed_Name(w3dpv, "isExercisedAt") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:isImplementedByEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#isImplementedByEntity">https://w3id.org/dpv#isImplementedByEntity</seealso>
    let isImplementedByEntity =
        Prefixed_Name(w3dpv, "isImplementedByEntity") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:isIndicatedAtTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#isIndicatedAtTime">https://w3id.org/dpv#isIndicatedAtTime</seealso>
    let isIndicatedAtTime = Prefixed_Name(w3dpv, "isIndicatedAtTime") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:isIndicatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#isIndicatedBy">https://w3id.org/dpv#isIndicatedBy</seealso>
    let isIndicatedBy = Prefixed_Name(w3dpv, "isIndicatedBy") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:isMitigatedByMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#isMitigatedByMeasure">https://w3id.org/dpv#isMitigatedByMeasure</seealso>
    let isMitigatedByMeasure =
        Prefixed_Name(w3dpv, "isMitigatedByMeasure") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:isNotApplicableFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#isNotApplicableFor">https://w3id.org/dpv#isNotApplicableFor</seealso>
    let isNotApplicableFor = Prefixed_Name(w3dpv, "isNotApplicableFor") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:isOrganisationalUnitOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#isOrganisationalUnitOf">https://w3id.org/dpv#isOrganisationalUnitOf</seealso>
    let isOrganisationalUnitOf =
        Prefixed_Name(w3dpv, "isOrganisationalUnitOf") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractPerformance</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#LegalBasis</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractPerformance">https://w3id.org/dpv#ContractPerformance</seealso>
    let ContractPerformance =
        Prefixed_Name(w3dpv, "ContractPerformance") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Derive</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Processing</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Derive">https://w3id.org/dpv#Derive</seealso>
    let Derive = Prefixed_Name(w3dpv, "Derive") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:DerivedData</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DerivedData">https://w3id.org/dpv#DerivedData</seealso>
    let DerivedData = Prefixed_Name(w3dpv, "DerivedData") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:LawEnforcementOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#LawEnforcementOrganisation">https://w3id.org/dpv#LawEnforcementOrganisation</seealso>
    let LawEnforcementOrganisation =
        Prefixed_Name(w3dpv, "LawEnforcementOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:LawfulnessUnknown</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Lawfulness</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#LawfulnessUnknown">https://w3id.org/dpv#LawfulnessUnknown</seealso>
    let LawfulnessUnknown = Prefixed_Name(w3dpv, "LawfulnessUnknown") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ObservedData</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ObservedData">https://w3id.org/dpv#ObservedData</seealso>
    let ObservedData = Prefixed_Name(w3dpv, "ObservedData") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ServiceLevelAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#LegalBasis</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ServiceLevelAgreement">https://w3id.org/dpv#ServiceLevelAgreement</seealso>
    let ServiceLevelAgreement =
        Prefixed_Name(w3dpv, "ServiceLevelAgreement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:entities-datasubject-properties</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#entities-datasubject-properties">https://w3id.org/dpv#entities-datasubject-properties</seealso>
    let entities_datasubject_properties =
        Prefixed_Name(w3dpv, "entities-datasubject-properties") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:entities-legalrole-properties</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#entities-legalrole-properties">https://w3id.org/dpv#entities-legalrole-properties</seealso>
    let entities_legalrole_properties =
        Prefixed_Name(w3dpv, "entities-legalrole-properties") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasSubsidiary</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasSubsidiary">https://w3id.org/dpv#hasSubsidiary</seealso>
    let hasSubsidiary = Prefixed_Name(w3dpv, "hasSubsidiary") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:CombatClimateChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CombatClimateChange">https://w3id.org/dpv#CombatClimateChange</seealso>
    let CombatClimateChange =
        Prefixed_Name(w3dpv, "CombatClimateChange") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Combine</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Processing</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Combine">https://w3id.org/dpv#Combine</seealso>
    let Combine = Prefixed_Name(w3dpv, "Combine") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:CommercialResearch</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CommercialResearch">https://w3id.org/dpv#CommercialResearch</seealso>
    let CommercialResearch = Prefixed_Name(w3dpv, "CommercialResearch") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ConfidentialData</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ConfidentialData">https://w3id.org/dpv#ConfidentialData</seealso>
    let ConfidentialData = Prefixed_Name(w3dpv, "ConfidentialData") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:CustomerCare</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Purpose</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CustomerCare">https://w3id.org/dpv#CustomerCare</seealso>
    let CustomerCare = Prefixed_Name(w3dpv, "CustomerCare") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:CompatibilityUnknown</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#ReuseCompatibility</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CompatibilityUnknown">https://w3id.org/dpv#CompatibilityUnknown</seealso>
    let CompatibilityUnknown =
        Prefixed_Name(w3dpv, "CompatibilityUnknown") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ComplianceIndeterminate</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#ComplianceStatus</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ComplianceIndeterminate">https://w3id.org/dpv#ComplianceIndeterminate</seealso>
    let ComplianceIndeterminate =
        Prefixed_Name(w3dpv, "ComplianceIndeterminate") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ComplianceStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ComplianceStatus">https://w3id.org/dpv#ComplianceStatus</seealso>
    let ComplianceStatus = Prefixed_Name(w3dpv, "ComplianceStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractTemporarilySuspended</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#ContractPerformanceStatus</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractTemporarilySuspended">https://w3id.org/dpv#ContractTemporarilySuspended</seealso>
    let ContractTemporarilySuspended =
        Prefixed_Name(w3dpv, "ContractTemporarilySuspended") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractTerminated</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#ContractTerminationStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractTerminated">https://w3id.org/dpv#ContractTerminated</seealso>
    let ContractTerminated = Prefixed_Name(w3dpv, "ContractTerminated") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DifferentialPrivacy</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DifferentialPrivacy">https://w3id.org/dpv#DifferentialPrivacy</seealso>
    let DifferentialPrivacy =
        Prefixed_Name(w3dpv, "DifferentialPrivacy") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:FullyRandomisedPseudonymisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#FullyRandomisedPseudonymisation">https://w3id.org/dpv#FullyRandomisedPseudonymisation</seealso>
    let FullyRandomisedPseudonymisation =
        Prefixed_Name(w3dpv, "FullyRandomisedPseudonymisation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Generate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Processing</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Generate">https://w3id.org/dpv#Generate</seealso>
    let Generate = Prefixed_Name(w3dpv, "Generate") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:LegalCompliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#LegalCompliance">https://w3id.org/dpv#LegalCompliance</seealso>
    let LegalCompliance = Prefixed_Name(w3dpv, "LegalCompliance") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:OfferContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#OfferContract">https://w3id.org/dpv#OfferContract</seealso>
    let OfferContract = Prefixed_Name(w3dpv, "OfferContract") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:OfficialAuthorityExerciseOngoing</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OfficialAuthorityExerciseStatus</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#OfficialAuthorityExerciseOngoing">https://w3id.org/dpv#OfficialAuthorityExerciseOngoing</seealso>
    let OfficialAuthorityExerciseOngoing =
        Prefixed_Name(w3dpv, "OfficialAuthorityExerciseOngoing") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:OftenFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Frequency</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#OftenFrequency">https://w3id.org/dpv#OftenFrequency</seealso>
    let OftenFrequency = Prefixed_Name(w3dpv, "OftenFrequency") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:OperatingSystemSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#OperatingSystemSecurity">https://w3id.org/dpv#OperatingSystemSecurity</seealso>
    let OperatingSystemSecurity =
        Prefixed_Name(w3dpv, "OperatingSystemSecurity") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PublicPolicyMaking</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PublicPolicyMaking">https://w3id.org/dpv#PublicPolicyMaking</seealso>
    let PublicPolicyMaking = Prefixed_Name(w3dpv, "PublicPolicyMaking") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PublicRegisterOfEntities</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PublicRegisterOfEntities">https://w3id.org/dpv#PublicRegisterOfEntities</seealso>
    let PublicRegisterOfEntities =
        Prefixed_Name(w3dpv, "PublicRegisterOfEntities") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PublicRelations</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PublicRelations">https://w3id.org/dpv#PublicRelations</seealso>
    let PublicRelations = Prefixed_Name(w3dpv, "PublicRelations") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:StandardsConformance</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#StandardsConformance">https://w3id.org/dpv#StandardsConformance</seealso>
    let StandardsConformance =
        Prefixed_Name(w3dpv, "StandardsConformance") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasConsentStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasConsentStatus">https://w3id.org/dpv#hasConsentStatus</seealso>
    let hasConsentStatus = Prefixed_Name(w3dpv, "hasConsentStatus") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasConsequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasConsequence">https://w3id.org/dpv#hasConsequence</seealso>
    let hasConsequence = Prefixed_Name(w3dpv, "hasConsequence") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:risk-properties</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#risk-properties">https://w3id.org/dpv#risk-properties</seealso>
    let risk_properties = Prefixed_Name(w3dpv, "risk-properties") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:isOutsideOfLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#isOutsideOfLocation">https://w3id.org/dpv#isOutsideOfLocation</seealso>
    let isOutsideOfLocation =
        Prefixed_Name(w3dpv, "isOutsideOfLocation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:isPolicyFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#isPolicyFor">https://w3id.org/dpv#isPolicyFor</seealso>
    let isPolicyFor = Prefixed_Name(w3dpv, "isPolicyFor") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ActivityHalted</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#ActivityStatus</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ActivityHalted">https://w3id.org/dpv#ActivityHalted</seealso>
    let ActivityHalted = Prefixed_Name(w3dpv, "ActivityHalted") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ContractRenewed</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#ContractPerformanceStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractRenewed">https://w3id.org/dpv#ContractRenewed</seealso>
    let ContractRenewed = Prefixed_Name(w3dpv, "ContractRenewed") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ProvideProductRecommendations</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ProvideProductRecommendations">https://w3id.org/dpv#ProvideProductRecommendations</seealso>
    let ProvideProductRecommendations =
        Prefixed_Name(w3dpv, "ProvideProductRecommendations") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:contract-properties</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#contract-properties">https://w3id.org/dpv#contract-properties</seealso>
    let contract_properties =
        Prefixed_Name(w3dpv, "contract-properties") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:entities-authority-properties</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#entities-authority-properties">https://w3id.org/dpv#entities-authority-properties</seealso>
    let entities_authority_properties =
        Prefixed_Name(w3dpv, "entities-authority-properties") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:entities-properties</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#entities-properties">https://w3id.org/dpv#entities-properties</seealso>
    let entities_properties =
        Prefixed_Name(w3dpv, "entities-properties") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasActiveEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasActiveEntity">https://w3id.org/dpv#hasActiveEntity</seealso>
    let hasActiveEntity = Prefixed_Name(w3dpv, "hasActiveEntity") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasStorageCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasStorageCondition">https://w3id.org/dpv#hasStorageCondition</seealso>
    let hasStorageCondition =
        Prefixed_Name(w3dpv, "hasStorageCondition") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Context</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Context">https://w3id.org/dpv#Context</seealso>
    let Context = Prefixed_Name(w3dpv, "Context") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:context-classes</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#context-classes">https://w3id.org/dpv#context-classes</seealso>
    let context_classes = Prefixed_Name(w3dpv, "context-classes") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ConsentGiven</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#ConsentStatus</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ConsentGiven">https://w3id.org/dpv#ConsentGiven</seealso>
    let ConsentGiven = Prefixed_Name(w3dpv, "ConsentGiven") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ConsentStatusValidForProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#ConsentStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ConsentStatusValidForProcessing">https://w3id.org/dpv#ConsentStatusValidForProcessing</seealso>
    let ConsentStatusValidForProcessing =
        Prefixed_Name(w3dpv, "ConsentStatusValidForProcessing") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PermissionManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PermissionManagement">https://w3id.org/dpv#PermissionManagement</seealso>
    let PermissionManagement =
        Prefixed_Name(w3dpv, "PermissionManagement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ConsentNotice</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ConsentNotice">https://w3id.org/dpv#ConsentNotice</seealso>
    let ConsentNotice = Prefixed_Name(w3dpv, "ConsentNotice") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataProcessorContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#LegalBasis</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataProcessorContract">https://w3id.org/dpv#DataProcessorContract</seealso>
    let DataProcessorContract =
        Prefixed_Name(w3dpv, "DataProcessorContract") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:CorrectingProcessInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#EntityPermissiveInvolvement</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CorrectingProcessInput">https://w3id.org/dpv#CorrectingProcessInput</seealso>
    let CorrectingProcessInput =
        Prefixed_Name(w3dpv, "CorrectingProcessInput") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:EducationalOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#EducationalOrganisation">https://w3id.org/dpv#EducationalOrganisation</seealso>
    let EducationalOrganisation =
        Prefixed_Name(w3dpv, "EducationalOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:EducationalTraining</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#EducationalTraining">https://w3id.org/dpv#EducationalTraining</seealso>
    let EducationalTraining =
        Prefixed_Name(w3dpv, "EducationalTraining") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:EffectivenessDeterminationProcedures</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#EffectivenessDeterminationProcedures">https://w3id.org/dpv#EffectivenessDeterminationProcedures</seealso>
    let EffectivenessDeterminationProcedures =
        Prefixed_Name(w3dpv, "EffectivenessDeterminationProcedures") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ElderlyDataSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#HumanSubject</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ElderlyDataSubject">https://w3id.org/dpv#ElderlyDataSubject</seealso>
    let ElderlyDataSubject = Prefixed_Name(w3dpv, "ElderlyDataSubject") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:VulnerableDataSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#HumanSubject</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#VulnerableDataSubject">https://w3id.org/dpv#VulnerableDataSubject</seealso>
    let VulnerableDataSubject =
        Prefixed_Name(w3dpv, "VulnerableDataSubject") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ElderlyHuman</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#HumanSubject</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ElderlyHuman">https://w3id.org/dpv#ElderlyHuman</seealso>
    let ElderlyHuman = Prefixed_Name(w3dpv, "ElderlyHuman") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:EmergencyHealthcareProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#EmergencyHealthcareProvider">https://w3id.org/dpv#EmergencyHealthcareProvider</seealso>
    let EmergencyHealthcareProvider =
        Prefixed_Name(w3dpv, "EmergencyHealthcareProvider") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:HugeScaleOfDataSubjects</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#DataSubjectScale</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#HugeScaleOfDataSubjects">https://w3id.org/dpv#HugeScaleOfDataSubjects</seealso>
    let HugeScaleOfDataSubjects =
        Prefixed_Name(w3dpv, "HugeScaleOfDataSubjects") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:HumanInvolved</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#HumanInvolvement</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#HumanInvolved">https://w3id.org/dpv#HumanInvolved</seealso>
    let HumanInvolved = Prefixed_Name(w3dpv, "HumanInvolved") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:HumanInvolvement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#HumanInvolvement">https://w3id.org/dpv#HumanInvolvement</seealso>
    let HumanInvolvement = Prefixed_Name(w3dpv, "HumanInvolvement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:MaintainFraudDatabase</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#MaintainFraudDatabase">https://w3id.org/dpv#MaintainFraudDatabase</seealso>
    let MaintainFraudDatabase =
        Prefixed_Name(w3dpv, "MaintainFraudDatabase") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:MakeAvailable</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Processing</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#MakeAvailable">https://w3id.org/dpv#MakeAvailable</seealso>
    let MakeAvailable = Prefixed_Name(w3dpv, "MakeAvailable") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ManageConsent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ManageConsent">https://w3id.org/dpv#ManageConsent</seealso>
    let ManageConsent = Prefixed_Name(w3dpv, "ManageConsent") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Patient</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#HumanSubject</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Patient">https://w3id.org/dpv#Patient</seealso>
    let Patient = Prefixed_Name(w3dpv, "Patient") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:PaymentManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PaymentManagement">https://w3id.org/dpv#PaymentManagement</seealso>
    let PaymentManagement = Prefixed_Name(w3dpv, "PaymentManagement") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ServiceProvision</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ServiceProvision">https://w3id.org/dpv#ServiceProvision</seealso>
    let ServiceProvision = Prefixed_Name(w3dpv, "ServiceProvision") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RecommendationNotFollowed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#RuleFulfilmentStatus</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RecommendationNotFollowed">https://w3id.org/dpv#RecommendationNotFollowed</seealso>
    let RecommendationNotFollowed =
        Prefixed_Name(w3dpv, "RecommendationNotFollowed") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Record</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Processing</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Record">https://w3id.org/dpv#Record</seealso>
    let Record = Prefixed_Name(w3dpv, "Record") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RecruitmentAdvertising</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RecruitmentAdvertising">https://w3id.org/dpv#RecruitmentAdvertising</seealso>
    let RecruitmentAdvertising =
        Prefixed_Name(w3dpv, "RecruitmentAdvertising") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RecruitmentApplicantBackgroundCheck</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RecruitmentApplicantBackgroundCheck">https://w3id.org/dpv#RecruitmentApplicantBackgroundCheck</seealso>
    let RecruitmentApplicantBackgroundCheck =
        Prefixed_Name(w3dpv, "RecruitmentApplicantBackgroundCheck") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RecruitmentApplicantCriminalBackgroundCheck</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RecruitmentApplicantCriminalBackgroundCheck">https://w3id.org/dpv#RecruitmentApplicantCriminalBackgroundCheck</seealso>
    let RecruitmentApplicantCriminalBackgroundCheck =
        Prefixed_Name(w3dpv, "RecruitmentApplicantCriminalBackgroundCheck") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RecruitmentApplicantInformationAuthentication</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RecruitmentApplicantInformationAuthentication">https://w3id.org/dpv#RecruitmentApplicantInformationAuthentication</seealso>
    let RecruitmentApplicantInformationAuthentication =
        Prefixed_Name(w3dpv, "RecruitmentApplicantInformationAuthentication") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RecruitmentApplicantSelection</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RecruitmentApplicantSelection">https://w3id.org/dpv#RecruitmentApplicantSelection</seealso>
    let RecruitmentApplicantSelection =
        Prefixed_Name(w3dpv, "RecruitmentApplicantSelection") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RecruitmentApplicationAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RecruitmentApplicationAnalysis">https://w3id.org/dpv#RecruitmentApplicationAnalysis</seealso>
    let RecruitmentApplicationAnalysis =
        Prefixed_Name(w3dpv, "RecruitmentApplicationAnalysis") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RecruitmentApplicationManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RecruitmentApplicationManagement">https://w3id.org/dpv#RecruitmentApplicationManagement</seealso>
    let RecruitmentApplicationManagement =
        Prefixed_Name(w3dpv, "RecruitmentApplicationManagement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RecruitmentApplicationScreening</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RecruitmentApplicationScreening">https://w3id.org/dpv#RecruitmentApplicationScreening</seealso>
    let RecruitmentApplicationScreening =
        Prefixed_Name(w3dpv, "RecruitmentApplicationScreening") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RecruitmentInterviewAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RecruitmentInterviewAnalysis">https://w3id.org/dpv#RecruitmentInterviewAnalysis</seealso>
    let RecruitmentInterviewAnalysis =
        Prefixed_Name(w3dpv, "RecruitmentInterviewAnalysis") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RecruitmentInterviewManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RecruitmentInterviewManagement">https://w3id.org/dpv#RecruitmentInterviewManagement</seealso>
    let RecruitmentInterviewManagement =
        Prefixed_Name(w3dpv, "RecruitmentInterviewManagement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RecruitmentInterviewAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RecruitmentInterviewAssessment">https://w3id.org/dpv#RecruitmentInterviewAssessment</seealso>
    let RecruitmentInterviewAssessment =
        Prefixed_Name(w3dpv, "RecruitmentInterviewAssessment") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RecruitmentTargetedAdvertising</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RecruitmentTargetedAdvertising">https://w3id.org/dpv#RecruitmentTargetedAdvertising</seealso>
    let RecruitmentTargetedAdvertising =
        Prefixed_Name(w3dpv, "RecruitmentTargetedAdvertising") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:TargetedAdvertising</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#TargetedAdvertising">https://w3id.org/dpv#TargetedAdvertising</seealso>
    let TargetedAdvertising =
        Prefixed_Name(w3dpv, "TargetedAdvertising") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Reformat</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Processing</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Reformat">https://w3id.org/dpv#Reformat</seealso>
    let Reformat = Prefixed_Name(w3dpv, "Reformat") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:RefuseConsent</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RefuseConsent">https://w3id.org/dpv#RefuseConsent</seealso>
    let RefuseConsent = Prefixed_Name(w3dpv, "RefuseConsent") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:RefuseContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RefuseContract">https://w3id.org/dpv#RefuseContract</seealso>
    let RefuseContract = Prefixed_Name(w3dpv, "RefuseContract") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:TrustedComputing</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#TrustedComputing">https://w3id.org/dpv#TrustedComputing</seealso>
    let TrustedComputing = Prefixed_Name(w3dpv, "TrustedComputing") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:TrustedExecutionEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#TrustedExecutionEnvironment">https://w3id.org/dpv#TrustedExecutionEnvironment</seealso>
    let TrustedExecutionEnvironment =
        Prefixed_Name(w3dpv, "TrustedExecutionEnvironment") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:UncategorisedData</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#UncategorisedData">https://w3id.org/dpv#UncategorisedData</seealso>
    let UncategorisedData = Prefixed_Name(w3dpv, "UncategorisedData") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Unexpected</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#ExpectationStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Unexpected">https://w3id.org/dpv#Unexpected</seealso>
    let Unexpected = Prefixed_Name(w3dpv, "Unexpected") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasLawfulness</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasLawfulness">https://w3id.org/dpv#hasLawfulness</seealso>
    let hasLawfulness = Prefixed_Name(w3dpv, "hasLawfulness") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasLegalBasis</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasLegalBasis">https://w3id.org/dpv#hasLegalBasis</seealso>
    let hasLegalBasis = Prefixed_Name(w3dpv, "hasLegalBasis") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasLegalMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasLegalMeasure">https://w3id.org/dpv#hasLegalMeasure</seealso>
    let hasLegalMeasure = Prefixed_Name(w3dpv, "hasLegalMeasure") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasLikelihood</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasLikelihood">https://w3id.org/dpv#hasLikelihood</seealso>
    let hasLikelihood = Prefixed_Name(w3dpv, "hasLikelihood") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasNecessity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasNecessity">https://w3id.org/dpv#hasNecessity</seealso>
    let hasNecessity = Prefixed_Name(w3dpv, "hasNecessity") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasNonInvolvedEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasNonInvolvedEntity">https://w3id.org/dpv#hasNonInvolvedEntity</seealso>
    let hasNonInvolvedEntity =
        Prefixed_Name(w3dpv, "hasNonInvolvedEntity") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasNonPersonalDataProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasNonPersonalDataProcess">https://w3id.org/dpv#hasNonPersonalDataProcess</seealso>
    let hasNonPersonalDataProcess =
        Prefixed_Name(w3dpv, "hasNonPersonalDataProcess") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:process-properties</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#process-properties">https://w3id.org/dpv#process-properties</seealso>
    let process_properties = Prefixed_Name(w3dpv, "process-properties") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasNotice</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasNotice">https://w3id.org/dpv#hasNotice</seealso>
    let hasNotice = Prefixed_Name(w3dpv, "hasNotice") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:notice-properties</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#notice-properties">https://w3id.org/dpv#notice-properties</seealso>
    let notice_properties = Prefixed_Name(w3dpv, "notice-properties") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasNoticeIcon</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasNoticeIcon">https://w3id.org/dpv#hasNoticeIcon</seealso>
    let hasNoticeIcon = Prefixed_Name(w3dpv, "hasNoticeIcon") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasNoticeLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasNoticeLayer">https://w3id.org/dpv#hasNoticeLayer</seealso>
    let hasNoticeLayer = Prefixed_Name(w3dpv, "hasNoticeLayer") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasNoticeStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasNoticeStatus">https://w3id.org/dpv#hasNoticeStatus</seealso>
    let hasNoticeStatus = Prefixed_Name(w3dpv, "hasNoticeStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasNotificationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasNotificationStatus">https://w3id.org/dpv#hasNotificationStatus</seealso>
    let hasNotificationStatus =
        Prefixed_Name(w3dpv, "hasNotificationStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasObligation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasObligation">https://w3id.org/dpv#hasObligation</seealso>
    let hasObligation = Prefixed_Name(w3dpv, "hasObligation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasOrganisationalUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasOrganisationalUnit">https://w3id.org/dpv#hasOrganisationalUnit</seealso>
    let hasOrganisationalUnit =
        Prefixed_Name(w3dpv, "hasOrganisationalUnit") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractUnderReview</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#ContractPreparationStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractUnderReview">https://w3id.org/dpv#ContractUnderReview</seealso>
    let ContractUnderReview =
        Prefixed_Name(w3dpv, "ContractUnderReview") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SecurityMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SecurityMethod">https://w3id.org/dpv#SecurityMethod</seealso>
    let SecurityMethod = Prefixed_Name(w3dpv, "SecurityMethod") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:LegalComplianceAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#LegalComplianceAssessment">https://w3id.org/dpv#LegalComplianceAssessment</seealso>
    let LegalComplianceAssessment =
        Prefixed_Name(w3dpv, "LegalComplianceAssessment") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:OfficialAuthorityExerciseCompleted</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OfficialAuthorityExerciseStatus</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#OfficialAuthorityExerciseCompleted">https://w3id.org/dpv#OfficialAuthorityExerciseCompleted</seealso>
    let OfficialAuthorityExerciseCompleted =
        Prefixed_Name(w3dpv, "OfficialAuthorityExerciseCompleted") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:OfficialAuthorityExerciseStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#OfficialAuthorityExerciseStatus">https://w3id.org/dpv#OfficialAuthorityExerciseStatus</seealso>
    let OfficialAuthorityExerciseStatus =
        Prefixed_Name(w3dpv, "OfficialAuthorityExerciseStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:OfficialAuthorityExercisePending</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OfficialAuthorityExerciseStatus</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#OfficialAuthorityExercisePending">https://w3id.org/dpv#OfficialAuthorityExercisePending</seealso>
    let OfficialAuthorityExercisePending =
        Prefixed_Name(w3dpv, "OfficialAuthorityExercisePending") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:OfficialAuthorityOfController</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#LegalBasis</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#OfficialAuthorityOfController">https://w3id.org/dpv#OfficialAuthorityOfController</seealso>
    let OfficialAuthorityOfController =
        Prefixed_Name(w3dpv, "OfficialAuthorityOfController") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SpecialCategoryPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SpecialCategoryPersonalData">https://w3id.org/dpv#SpecialCategoryPersonalData</seealso>
    let SpecialCategoryPersonalData =
        Prefixed_Name(w3dpv, "SpecialCategoryPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasAuditStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasAuditStatus">https://w3id.org/dpv#hasAuditStatus</seealso>
    let hasAuditStatus = Prefixed_Name(w3dpv, "hasAuditStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:isImplementedUsingTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#isImplementedUsingTechnology">https://w3id.org/dpv#isImplementedUsingTechnology</seealso>
    let isImplementedUsingTechnology =
        Prefixed_Name(w3dpv, "isImplementedUsingTechnology") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractualClausePartiallyFulfilled</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#ContractualClauseFulfilmentStatus</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractualClausePartiallyFulfilled">https://w3id.org/dpv#ContractualClausePartiallyFulfilled</seealso>
    let ContractualClausePartiallyFulfilled =
        Prefixed_Name(w3dpv, "ContractualClausePartiallyFulfilled") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Guideline</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Guideline">https://w3id.org/dpv#Guideline</seealso>
    let Guideline = Prefixed_Name(w3dpv, "Guideline") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:SingularFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Frequency</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SingularFrequency">https://w3id.org/dpv#SingularFrequency</seealso>
    let SingularFrequency = Prefixed_Name(w3dpv, "SingularFrequency") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasApplicability</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasApplicability">https://w3id.org/dpv#hasApplicability</seealso>
    let hasApplicability = Prefixed_Name(w3dpv, "hasApplicability") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:isAuthorityFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#isAuthorityFor">https://w3id.org/dpv#isAuthorityFor</seealso>
    let isAuthorityFor = Prefixed_Name(w3dpv, "isAuthorityFor") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv#">https://w3id.org/dpv#</seealso>
    let _prefix_iri = Prefixed_Name(w3dpv, "") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:AsymmetricCryptography</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#AsymmetricCryptography">https://w3id.org/dpv#AsymmetricCryptography</seealso>
    let AsymmetricCryptography =
        Prefixed_Name(w3dpv, "AsymmetricCryptography") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:CryptographicMethods</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CryptographicMethods">https://w3id.org/dpv#CryptographicMethods</seealso>
    let CryptographicMethods =
        Prefixed_Name(w3dpv, "CryptographicMethods") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:AuditApproved</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#AuditStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#AuditApproved">https://w3id.org/dpv#AuditApproved</seealso>
    let AuditApproved = Prefixed_Name(w3dpv, "AuditApproved") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:AuditStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#AuditStatus">https://w3id.org/dpv#AuditStatus</seealso>
    let AuditStatus = Prefixed_Name(w3dpv, "AuditStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:CustomerClaimsManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Purpose</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CustomerClaimsManagement">https://w3id.org/dpv#CustomerClaimsManagement</seealso>
    let CustomerClaimsManagement =
        Prefixed_Name(w3dpv, "CustomerClaimsManagement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:CustomerRelationshipManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CustomerRelationshipManagement">https://w3id.org/dpv#CustomerRelationshipManagement</seealso>
    let CustomerRelationshipManagement =
        Prefixed_Name(w3dpv, "CustomerRelationshipManagement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:CustomerSolvencyMonitoring</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CustomerSolvencyMonitoring">https://w3id.org/dpv#CustomerSolvencyMonitoring</seealso>
    let CustomerSolvencyMonitoring =
        Prefixed_Name(w3dpv, "CustomerSolvencyMonitoring") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:CybersecurityAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CybersecurityAssessment">https://w3id.org/dpv#CybersecurityAssessment</seealso>
    let CybersecurityAssessment =
        Prefixed_Name(w3dpv, "CybersecurityAssessment") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:HumanInvolvementForOversight</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#HumanInvolvement</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#HumanInvolvementForOversight">https://w3id.org/dpv#HumanInvolvementForOversight</seealso>
    let HumanInvolvementForOversight =
        Prefixed_Name(w3dpv, "HumanInvolvementForOversight") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:HumanNotInvolved</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#HumanInvolvement</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#HumanNotInvolved">https://w3id.org/dpv#HumanNotInvolved</seealso>
    let HumanNotInvolved = Prefixed_Name(w3dpv, "HumanNotInvolved") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:HybridPublicPrivateSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Location</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#HybridPublicPrivateSpace">https://w3id.org/dpv#HybridPublicPrivateSpace</seealso>
    let HybridPublicPrivateSpace =
        Prefixed_Name(w3dpv, "HybridPublicPrivateSpace") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:IPRManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#IPRManagement">https://w3id.org/dpv#IPRManagement</seealso>
    let IPRManagement = Prefixed_Name(w3dpv, "IPRManagement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:IdentifyingPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#IdentifyingPersonalData">https://w3id.org/dpv#IdentifyingPersonalData</seealso>
    let IdentifyingPersonalData =
        Prefixed_Name(w3dpv, "IdentifyingPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:IdentityManagementMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#IdentityManagementMethod">https://w3id.org/dpv#IdentityManagementMethod</seealso>
    let IdentityManagementMethod =
        Prefixed_Name(w3dpv, "IdentityManagementMethod") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:IdentityVerification</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#IdentityVerification">https://w3id.org/dpv#IdentityVerification</seealso>
    let IdentityVerification =
        Prefixed_Name(w3dpv, "IdentityVerification") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Immigrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#HumanSubject</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Immigrant">https://w3id.org/dpv#Immigrant</seealso>
    let Immigrant = Prefixed_Name(w3dpv, "Immigrant") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Impact</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Impact">https://w3id.org/dpv#Impact</seealso>
    let Impact = Prefixed_Name(w3dpv, "Impact") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:RiskAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RiskAssessment">https://w3id.org/dpv#RiskAssessment</seealso>
    let RiskAssessment = Prefixed_Name(w3dpv, "RiskAssessment") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ImpliedConsent</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#LegalBasis</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ImpliedConsent">https://w3id.org/dpv#ImpliedConsent</seealso>
    let ImpliedConsent = Prefixed_Name(w3dpv, "ImpliedConsent") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Importance</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Importance">https://w3id.org/dpv#Importance</seealso>
    let Importance = Prefixed_Name(w3dpv, "Importance") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ImproveExistingProductsAndServices</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ImproveExistingProductsAndServices">https://w3id.org/dpv#ImproveExistingProductsAndServices</seealso>
    let ImproveExistingProductsAndServices =
        Prefixed_Name(w3dpv, "ImproveExistingProductsAndServices") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:OptimisationForController</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#OptimisationForController">https://w3id.org/dpv#OptimisationForController</seealso>
    let OptimisationForController =
        Prefixed_Name(w3dpv, "OptimisationForController") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ImproveHealthcare</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ImproveHealthcare">https://w3id.org/dpv#ImproveHealthcare</seealso>
    let ImproveHealthcare = Prefixed_Name(w3dpv, "ImproveHealthcare") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:TrackingByFirstParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Processing</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#TrackingByFirstParty">https://w3id.org/dpv#TrackingByFirstParty</seealso>
    let TrackingByFirstParty =
        Prefixed_Name(w3dpv, "TrackingByFirstParty") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:TrackingByThirdParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Processing</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#TrackingByThirdParty">https://w3id.org/dpv#TrackingByThirdParty</seealso>
    let TrackingByThirdParty =
        Prefixed_Name(w3dpv, "TrackingByThirdParty") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasInverseJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasInverseJurisdiction">https://w3id.org/dpv#hasInverseJurisdiction</seealso>
    let hasInverseJurisdiction =
        Prefixed_Name(w3dpv, "hasInverseJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasInvolvement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasInvolvement">https://w3id.org/dpv#hasInvolvement</seealso>
    let hasInvolvement = Prefixed_Name(w3dpv, "hasInvolvement") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:LocalityScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#GeographicCoverage</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#LocalityScale">https://w3id.org/dpv#LocalityScale</seealso>
    let LocalityScale = Prefixed_Name(w3dpv, "LocalityScale") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:LoggingPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#LoggingPolicy">https://w3id.org/dpv#LoggingPolicy</seealso>
    let LoggingPolicy = Prefixed_Name(w3dpv, "LoggingPolicy") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PasswordAuthentication</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PasswordAuthentication">https://w3id.org/dpv#PasswordAuthentication</seealso>
    let PasswordAuthentication =
        Prefixed_Name(w3dpv, "PasswordAuthentication") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RecommendationFollowed</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#RuleFulfilmentStatus</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RecommendationFollowed">https://w3id.org/dpv#RecommendationFollowed</seealso>
    let RecommendationFollowed =
        Prefixed_Name(w3dpv, "RecommendationFollowed") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:TemporalDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#TemporalDuration">https://w3id.org/dpv#TemporalDuration</seealso>
    let TemporalDuration = Prefixed_Name(w3dpv, "TemporalDuration") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasExpectation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasExpectation">https://w3id.org/dpv#hasExpectation</seealso>
    let hasExpectation = Prefixed_Name(w3dpv, "hasExpectation") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasFee</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasFee">https://w3id.org/dpv#hasFee</seealso>
    let hasFee = Prefixed_Name(w3dpv, "hasFee") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:rights-properties</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#rights-properties">https://w3id.org/dpv#rights-properties</seealso>
    let rights_properties = Prefixed_Name(w3dpv, "rights-properties") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ConsentRevoked</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#ConsentStatus</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ConsentRevoked">https://w3id.org/dpv#ConsentRevoked</seealso>
    let ConsentRevoked = Prefixed_Name(w3dpv, "ConsentRevoked") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ConsentUnknown</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#ConsentStatus</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ConsentUnknown">https://w3id.org/dpv#ConsentUnknown</seealso>
    let ConsentUnknown = Prefixed_Name(w3dpv, "ConsentUnknown") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Consequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Consequence">https://w3id.org/dpv#Consequence</seealso>
    let Consequence = Prefixed_Name(w3dpv, "Consequence") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:RiskConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RiskConcept">https://w3id.org/dpv#RiskConcept</seealso>
    let RiskConcept = Prefixed_Name(w3dpv, "RiskConcept") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ConsequenceAsSideEffect</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ConsequenceAsSideEffect">https://w3id.org/dpv#ConsequenceAsSideEffect</seealso>
    let ConsequenceAsSideEffect =
        Prefixed_Name(w3dpv, "ConsequenceAsSideEffect") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ConsequenceOfSuccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ConsequenceOfSuccess">https://w3id.org/dpv#ConsequenceOfSuccess</seealso>
    let ConsequenceOfSuccess =
        Prefixed_Name(w3dpv, "ConsequenceOfSuccess") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Consultation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Consultation">https://w3id.org/dpv#Consultation</seealso>
    let Consultation = Prefixed_Name(w3dpv, "Consultation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:entities-legalrole-classes</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#entities-legalrole-classes">https://w3id.org/dpv#entities-legalrole-classes</seealso>
    let entities_legalrole_classes =
        Prefixed_Name(w3dpv, "entities-legalrole-classes") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataControllerDataSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#DataSource</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataControllerDataSource">https://w3id.org/dpv#DataControllerDataSource</seealso>
    let DataControllerDataSource =
        Prefixed_Name(w3dpv, "DataControllerDataSource") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataSource">https://w3id.org/dpv#DataSource</seealso>
    let DataSource = Prefixed_Name(w3dpv, "DataSource") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:EntityUnintendedInvolvement</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#EntityInvolvementStatus</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#EntityUnintendedInvolvement">https://w3id.org/dpv#EntityUnintendedInvolvement</seealso>
    let EntityUnintendedInvolvement =
        Prefixed_Name(w3dpv, "EntityUnintendedInvolvement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Unintended</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#IntentionStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Unintended">https://w3id.org/dpv#Unintended</seealso>
    let Unintended = Prefixed_Name(w3dpv, "Unintended") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:PhysicalMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PhysicalMeasure">https://w3id.org/dpv#PhysicalMeasure</seealso>
    let PhysicalMeasure = Prefixed_Name(w3dpv, "PhysicalMeasure") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:physical-measures-classes</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#physical-measures-classes">https://w3id.org/dpv#physical-measures-classes</seealso>
    let physical_measures_classes =
        Prefixed_Name(w3dpv, "physical-measures-classes") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Erase</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Processing</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Erase">https://w3id.org/dpv#Erase</seealso>
    let Erase = Prefixed_Name(w3dpv, "Erase") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:EstablishContractualAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#EstablishContractualAgreement">https://w3id.org/dpv#EstablishContractualAgreement</seealso>
    let EstablishContractualAgreement =
        Prefixed_Name(w3dpv, "EstablishContractualAgreement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:IndeterminateDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Duration</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#IndeterminateDuration">https://w3id.org/dpv#IndeterminateDuration</seealso>
    let IndeterminateDuration =
        Prefixed_Name(w3dpv, "IndeterminateDuration") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:IndustryConsortium</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#IndustryConsortium">https://w3id.org/dpv#IndustryConsortium</seealso>
    let IndustryConsortium = Prefixed_Name(w3dpv, "IndustryConsortium") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:InferredData</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#InferredData">https://w3id.org/dpv#InferredData</seealso>
    let InferredData = Prefixed_Name(w3dpv, "InferredData") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:InferredPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#InferredPersonalData">https://w3id.org/dpv#InferredPersonalData</seealso>
    let InferredPersonalData =
        Prefixed_Name(w3dpv, "InferredPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:InformationAudit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#InformationAudit">https://w3id.org/dpv#InformationAudit</seealso>
    let InformationAudit = Prefixed_Name(w3dpv, "InformationAudit") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:InformationFlowControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#InformationFlowControl">https://w3id.org/dpv#InformationFlowControl</seealso>
    let InformationFlowControl =
        Prefixed_Name(w3dpv, "InformationFlowControl") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:InformationSecurityPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#InformationSecurityPolicy">https://w3id.org/dpv#InformationSecurityPolicy</seealso>
    let InformationSecurityPolicy =
        Prefixed_Name(w3dpv, "InformationSecurityPolicy") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:InnovativeUseOfExistingTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#InnovativeUseOfTechnology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#InnovativeUseOfExistingTechnology">https://w3id.org/dpv#InnovativeUseOfExistingTechnology</seealso>
    let InnovativeUseOfExistingTechnology =
        Prefixed_Name(w3dpv, "InnovativeUseOfExistingTechnology") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:InnovativeUseOfTechnology</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#InnovativeUseOfTechnology">https://w3id.org/dpv#InnovativeUseOfTechnology</seealso>
    let InnovativeUseOfTechnology =
        Prefixed_Name(w3dpv, "InnovativeUseOfTechnology") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:InnovativeUseOfNewTechnologies</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#InnovativeUseOfTechnology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#InnovativeUseOfNewTechnologies">https://w3id.org/dpv#InnovativeUseOfNewTechnologies</seealso>
    let InnovativeUseOfNewTechnologies =
        Prefixed_Name(w3dpv, "InnovativeUseOfNewTechnologies") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:IntellectualPropertyData</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#IntellectualPropertyData">https://w3id.org/dpv#IntellectualPropertyData</seealso>
    let IntellectualPropertyData =
        Prefixed_Name(w3dpv, "IntellectualPropertyData") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:IntentionStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#IntentionStatus">https://w3id.org/dpv#IntentionStatus</seealso>
    let IntentionStatus = Prefixed_Name(w3dpv, "IntentionStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:InternalResourceOptimisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#InternalResourceOptimisation">https://w3id.org/dpv#InternalResourceOptimisation</seealso>
    let InternalResourceOptimisation =
        Prefixed_Name(w3dpv, "InternalResourceOptimisation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:NonConformant</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#ConformanceStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NonConformant">https://w3id.org/dpv#NonConformant</seealso>
    let NonConformant = Prefixed_Name(w3dpv, "NonConformant") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:NonGovernmentalOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NonGovernmentalOrganisation">https://w3id.org/dpv#NonGovernmentalOrganisation</seealso>
    let NonGovernmentalOrganisation =
        Prefixed_Name(w3dpv, "NonGovernmentalOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:NonPersonalDataProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NonPersonalDataProcess">https://w3id.org/dpv#NonPersonalDataProcess</seealso>
    let NonPersonalDataProcess =
        Prefixed_Name(w3dpv, "NonPersonalDataProcess") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Process</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Process">https://w3id.org/dpv#Process</seealso>
    let Process = Prefixed_Name(w3dpv, "Process") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:process-classes</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#process-classes">https://w3id.org/dpv#process-classes</seealso>
    let process_classes = Prefixed_Name(w3dpv, "process-classes") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:NonPublicDataSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#DataSource</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NonPublicDataSource">https://w3id.org/dpv#NonPublicDataSource</seealso>
    let NonPublicDataSource =
        Prefixed_Name(w3dpv, "NonPublicDataSource") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:NotApplicable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Applicability</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NotApplicable">https://w3id.org/dpv#NotApplicable</seealso>
    let NotApplicable = Prefixed_Name(w3dpv, "NotApplicable") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:NotAutomated</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#AutomationLevel</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NotAutomated">https://w3id.org/dpv#NotAutomated</seealso>
    let NotAutomated = Prefixed_Name(w3dpv, "NotAutomated") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:NotAvailable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Applicability</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NotAvailable">https://w3id.org/dpv#NotAvailable</seealso>
    let NotAvailable = Prefixed_Name(w3dpv, "NotAvailable") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ProfessionalConfidentialData</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ProfessionalConfidentialData">https://w3id.org/dpv#ProfessionalConfidentialData</seealso>
    let ProfessionalConfidentialData =
        Prefixed_Name(w3dpv, "ProfessionalConfidentialData") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ProfessionalTraining</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ProfessionalTraining">https://w3id.org/dpv#ProfessionalTraining</seealso>
    let ProfessionalTraining =
        Prefixed_Name(w3dpv, "ProfessionalTraining") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Profiling</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Processing</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Profiling">https://w3id.org/dpv#Profiling</seealso>
    let Profiling = Prefixed_Name(w3dpv, "Profiling") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Prohibition</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Rule</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Prohibition">https://w3id.org/dpv#Prohibition</seealso>
    let Prohibition = Prefixed_Name(w3dpv, "Prohibition") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SellInsightsFromData</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SellInsightsFromData">https://w3id.org/dpv#SellInsightsFromData</seealso>
    let SellInsightsFromData =
        Prefixed_Name(w3dpv, "SellInsightsFromData") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SellProductsToDataSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Purpose</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SellProductsToDataSubject">https://w3id.org/dpv#SellProductsToDataSubject</seealso>
    let SellProductsToDataSubject =
        Prefixed_Name(w3dpv, "SellProductsToDataSubject") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SemiPrivateSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Location</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SemiPrivateSpace">https://w3id.org/dpv#SemiPrivateSpace</seealso>
    let SemiPrivateSpace = Prefixed_Name(w3dpv, "SemiPrivateSpace") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:SensitiveData</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SensitiveData">https://w3id.org/dpv#SensitiveData</seealso>
    let SensitiveData = Prefixed_Name(w3dpv, "SensitiveData") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasRiskAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasRiskAssessment">https://w3id.org/dpv#hasRiskAssessment</seealso>
    let hasRiskAssessment = Prefixed_Name(w3dpv, "hasRiskAssessment") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasRiskLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasRiskLevel">https://w3id.org/dpv#hasRiskLevel</seealso>
    let hasRiskLevel = Prefixed_Name(w3dpv, "hasRiskLevel") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasScope</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasScope">https://w3id.org/dpv#hasScope</seealso>
    let hasScope = Prefixed_Name(w3dpv, "hasScope") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasSector</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasSector">https://w3id.org/dpv#hasSector</seealso>
    let hasSector = Prefixed_Name(w3dpv, "hasSector") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RightExerciseRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RightExerciseRecord">https://w3id.org/dpv#RightExerciseRecord</seealso>
    let RightExerciseRecord =
        Prefixed_Name(w3dpv, "RightExerciseRecord") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SecurityProcedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SecurityProcedure">https://w3id.org/dpv#SecurityProcedure</seealso>
    let SecurityProcedure = Prefixed_Name(w3dpv, "SecurityProcedure") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:risk-classes</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#risk-classes">https://w3id.org/dpv#risk-classes</seealso>
    let risk_classes = Prefixed_Name(w3dpv, "risk-classes") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ConsequenceOfFailure</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ConsequenceOfFailure">https://w3id.org/dpv#ConsequenceOfFailure</seealso>
    let ConsequenceOfFailure =
        Prefixed_Name(w3dpv, "ConsequenceOfFailure") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Consult</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Processing</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Consult">https://w3id.org/dpv#Consult</seealso>
    let Consult = Prefixed_Name(w3dpv, "Consult") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ConsultationWithAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ConsultationWithAuthority">https://w3id.org/dpv#ConsultationWithAuthority</seealso>
    let ConsultationWithAuthority =
        Prefixed_Name(w3dpv, "ConsultationWithAuthority") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ConsultationWithDPO</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ConsultationWithDPO">https://w3id.org/dpv#ConsultationWithDPO</seealso>
    let ConsultationWithDPO =
        Prefixed_Name(w3dpv, "ConsultationWithDPO") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ConsultationWithDataSubjectRepresentative</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ConsultationWithDataSubjectRepresentative">https://w3id.org/dpv#ConsultationWithDataSubjectRepresentative</seealso>
    let ConsultationWithDataSubjectRepresentative =
        Prefixed_Name(w3dpv, "ConsultationWithDataSubjectRepresentative") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataControllerContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#LegalBasis</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataControllerContract">https://w3id.org/dpv#DataControllerContract</seealso>
    let DataControllerContract =
        Prefixed_Name(w3dpv, "DataControllerContract") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataProcessingAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#LegalMeasure</para>
    ///   <para>w3id:dpv#LegalBasis</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataProcessingAgreement">https://w3id.org/dpv#DataProcessingAgreement</seealso>
    let DataProcessingAgreement =
        Prefixed_Name(w3dpv, "DataProcessingAgreement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataDeletionPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataDeletionPolicy">https://w3id.org/dpv#DataDeletionPolicy</seealso>
    let DataDeletionPolicy = Prefixed_Name(w3dpv, "DataDeletionPolicy") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataProcessingPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataProcessingPolicy">https://w3id.org/dpv#DataProcessingPolicy</seealso>
    let DataProcessingPolicy =
        Prefixed_Name(w3dpv, "DataProcessingPolicy") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataErasurePolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataErasurePolicy">https://w3id.org/dpv#DataErasurePolicy</seealso>
    let DataErasurePolicy = Prefixed_Name(w3dpv, "DataErasurePolicy") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:EnvironmentalProtection</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#PhysicalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#EnvironmentalProtection">https://w3id.org/dpv#EnvironmentalProtection</seealso>
    let EnvironmentalProtection =
        Prefixed_Name(w3dpv, "EnvironmentalProtection") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:IncreaseServiceRobustness</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#IncreaseServiceRobustness">https://w3id.org/dpv#IncreaseServiceRobustness</seealso>
    let IncreaseServiceRobustness =
        Prefixed_Name(w3dpv, "IncreaseServiceRobustness") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PersonnelPerformanceMonitoring</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Purpose</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PersonnelPerformanceMonitoring">https://w3id.org/dpv#PersonnelPerformanceMonitoring</seealso>
    let PersonnelPerformanceMonitoring =
        Prefixed_Name(w3dpv, "PersonnelPerformanceMonitoring") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PersonnelPerformancePrediction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Purpose</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PersonnelPerformancePrediction">https://w3id.org/dpv#PersonnelPerformancePrediction</seealso>
    let PersonnelPerformancePrediction =
        Prefixed_Name(w3dpv, "PersonnelPerformancePrediction") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PersonnelPromotionManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PersonnelPromotionManagement">https://w3id.org/dpv#PersonnelPromotionManagement</seealso>
    let PersonnelPromotionManagement =
        Prefixed_Name(w3dpv, "PersonnelPromotionManagement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PersonnelTerminationManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Purpose</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PersonnelTerminationManagement">https://w3id.org/dpv#PersonnelTerminationManagement</seealso>
    let PersonnelTerminationManagement =
        Prefixed_Name(w3dpv, "PersonnelTerminationManagement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PersonnelWorkloadManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Purpose</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PersonnelWorkloadManagement">https://w3id.org/dpv#PersonnelWorkloadManagement</seealso>
    let PersonnelWorkloadManagement =
        Prefixed_Name(w3dpv, "PersonnelWorkloadManagement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PhysicalAccessControlMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#PhysicalMeasure</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PhysicalAccessControlMethod">https://w3id.org/dpv#PhysicalAccessControlMethod</seealso>
    let PhysicalAccessControlMethod =
        Prefixed_Name(w3dpv, "PhysicalAccessControlMethod") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PhysicalAuthorisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#PhysicalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PhysicalAuthorisation">https://w3id.org/dpv#PhysicalAuthorisation</seealso>
    let PhysicalAuthorisation =
        Prefixed_Name(w3dpv, "PhysicalAuthorisation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PhysicalDeviceSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#PhysicalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PhysicalDeviceSecurity">https://w3id.org/dpv#PhysicalDeviceSecurity</seealso>
    let PhysicalDeviceSecurity =
        Prefixed_Name(w3dpv, "PhysicalDeviceSecurity") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PhysicalInterruptionProtection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#PhysicalMeasure</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PhysicalInterruptionProtection">https://w3id.org/dpv#PhysicalInterruptionProtection</seealso>
    let PhysicalInterruptionProtection =
        Prefixed_Name(w3dpv, "PhysicalInterruptionProtection") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PhysicalNetworkSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#PhysicalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PhysicalNetworkSecurity">https://w3id.org/dpv#PhysicalNetworkSecurity</seealso>
    let PhysicalNetworkSecurity =
        Prefixed_Name(w3dpv, "PhysicalNetworkSecurity") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PhysicalSecureStorage</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#PhysicalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PhysicalSecureStorage">https://w3id.org/dpv#PhysicalSecureStorage</seealso>
    let PhysicalSecureStorage =
        Prefixed_Name(w3dpv, "PhysicalSecureStorage") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Retrieve</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Processing</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Retrieve">https://w3id.org/dpv#Retrieve</seealso>
    let Retrieve = Prefixed_Name(w3dpv, "Retrieve") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ReversingProcessEffects</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#EntityPermissiveInvolvement</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ReversingProcessEffects">https://w3id.org/dpv#ReversingProcessEffects</seealso>
    let ReversingProcessEffects =
        Prefixed_Name(w3dpv, "ReversingProcessEffects") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:VitalInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#LegalBasis</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#VitalInterest">https://w3id.org/dpv#VitalInterest</seealso>
    let VitalInterest = Prefixed_Name(w3dpv, "VitalInterest") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:VitalInterestCompleted</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#VitalInterestStatus</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#VitalInterestCompleted">https://w3id.org/dpv#VitalInterestCompleted</seealso>
    let VitalInterestCompleted =
        Prefixed_Name(w3dpv, "VitalInterestCompleted") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:VitalInterestStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#VitalInterestStatus">https://w3id.org/dpv#VitalInterestStatus</seealso>
    let VitalInterestStatus =
        Prefixed_Name(w3dpv, "VitalInterestStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasOutcome</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasOutcome">https://w3id.org/dpv#hasOutcome</seealso>
    let hasOutcome = Prefixed_Name(w3dpv, "hasOutcome") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasParty">https://w3id.org/dpv#hasParty</seealso>
    let hasParty = Prefixed_Name(w3dpv, "hasParty") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasPassiveEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasPassiveEntity">https://w3id.org/dpv#hasPassiveEntity</seealso>
    let hasPassiveEntity = Prefixed_Name(w3dpv, "hasPassiveEntity") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasPermission</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasPermission">https://w3id.org/dpv#hasPermission</seealso>
    let hasPermission = Prefixed_Name(w3dpv, "hasPermission") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasPersonalData">https://w3id.org/dpv#hasPersonalData</seealso>
    let hasPersonalData = Prefixed_Name(w3dpv, "hasPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasPersonalDataHandling</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasPersonalDataHandling">https://w3id.org/dpv#hasPersonalDataHandling</seealso>
    let hasPersonalDataHandling =
        Prefixed_Name(w3dpv, "hasPersonalDataHandling") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasPersonalDataProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasPersonalDataProcess">https://w3id.org/dpv#hasPersonalDataProcess</seealso>
    let hasPersonalDataProcess =
        Prefixed_Name(w3dpv, "hasPersonalDataProcess") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasProcess">https://w3id.org/dpv#hasProcess</seealso>
    let hasProcess = Prefixed_Name(w3dpv, "hasProcess") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasProcessing">https://w3id.org/dpv#hasProcessing</seealso>
    let hasProcessing = Prefixed_Name(w3dpv, "hasProcessing") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:processing-properties</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#processing-properties">https://w3id.org/dpv#processing-properties</seealso>
    let processing_properties =
        Prefixed_Name(w3dpv, "processing-properties") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasProcessingCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasProcessingCondition">https://w3id.org/dpv#hasProcessingCondition</seealso>
    let hasProcessingCondition =
        Prefixed_Name(w3dpv, "hasProcessingCondition") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasProcessingScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasProcessingScale">https://w3id.org/dpv#hasProcessingScale</seealso>
    let hasProcessingScale = Prefixed_Name(w3dpv, "hasProcessingScale") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasProhibition</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasProhibition">https://w3id.org/dpv#hasProhibition</seealso>
    let hasProhibition = Prefixed_Name(w3dpv, "hasProhibition") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ConsentRequested</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#ConsentStatus</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ConsentRequested">https://w3id.org/dpv#ConsentRequested</seealso>
    let ConsentRequested = Prefixed_Name(w3dpv, "ConsentRequested") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:CustomerManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CustomerManagement">https://w3id.org/dpv#CustomerManagement</seealso>
    let CustomerManagement = Prefixed_Name(w3dpv, "CustomerManagement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:CustomerOrderManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CustomerOrderManagement">https://w3id.org/dpv#CustomerOrderManagement</seealso>
    let CustomerOrderManagement =
        Prefixed_Name(w3dpv, "CustomerOrderManagement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:HumanInvolvementForInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#HumanInvolvement</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#HumanInvolvementForInput">https://w3id.org/dpv#HumanInvolvementForInput</seealso>
    let HumanInvolvementForInput =
        Prefixed_Name(w3dpv, "HumanInvolvementForInput") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:HumanInvolvementForIntervention</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#HumanInvolvement</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#HumanInvolvementForIntervention">https://w3id.org/dpv#HumanInvolvementForIntervention</seealso>
    let HumanInvolvementForIntervention =
        Prefixed_Name(w3dpv, "HumanInvolvementForIntervention") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:HumanInvolvementForVerification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#HumanInvolvement</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#HumanInvolvementForVerification">https://w3id.org/dpv#HumanInvolvementForVerification</seealso>
    let HumanInvolvementForVerification =
        Prefixed_Name(w3dpv, "HumanInvolvementForVerification") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:HumanResourceManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#HumanResourceManagement">https://w3id.org/dpv#HumanResourceManagement</seealso>
    let HumanResourceManagement =
        Prefixed_Name(w3dpv, "HumanResourceManagement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PublicSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Location</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PublicSpace">https://w3id.org/dpv#PublicSpace</seealso>
    let PublicSpace = Prefixed_Name(w3dpv, "PublicSpace") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:PrivateSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Location</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PrivateSpace">https://w3id.org/dpv#PrivateSpace</seealso>
    let PrivateSpace = Prefixed_Name(w3dpv, "PrivateSpace") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:IdentityAuthentication</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#IdentityAuthentication">https://w3id.org/dpv#IdentityAuthentication</seealso>
    let IdentityAuthentication =
        Prefixed_Name(w3dpv, "IdentityAuthentication") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:MediumDataVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#DataVolume</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#MediumDataVolume">https://w3id.org/dpv#MediumDataVolume</seealso>
    let MediumDataVolume = Prefixed_Name(w3dpv, "MediumDataVolume") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PenetrationTestingMethods</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PenetrationTestingMethods">https://w3id.org/dpv#PenetrationTestingMethods</seealso>
    let PenetrationTestingMethods =
        Prefixed_Name(w3dpv, "PenetrationTestingMethods") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Permission</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Rule</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Permission">https://w3id.org/dpv#Permission</seealso>
    let Permission = Prefixed_Name(w3dpv, "Permission") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:RecordManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RecordManagement">https://w3id.org/dpv#RecordManagement</seealso>
    let RecordManagement = Prefixed_Name(w3dpv, "RecordManagement") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasIdentifier">https://w3id.org/dpv#hasIdentifier</seealso>
    let hasIdentifier = Prefixed_Name(w3dpv, "hasIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasImpact</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasImpact">https://w3id.org/dpv#hasImpact</seealso>
    let hasImpact = Prefixed_Name(w3dpv, "hasImpact") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:EntityUninformed</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#EntityUninformed">https://w3id.org/dpv#EntityUninformed</seealso>
    let EntityUninformed = Prefixed_Name(w3dpv, "EntityUninformed") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:DashboardNotice</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DashboardNotice">https://w3id.org/dpv#DashboardNotice</seealso>
    let DashboardNotice = Prefixed_Name(w3dpv, "DashboardNotice") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:DataAltruism</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataAltruism">https://w3id.org/dpv#DataAltruism</seealso>
    let DataAltruism = Prefixed_Name(w3dpv, "DataAltruism") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataBreachImpactAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataBreachImpactAssessment">https://w3id.org/dpv#DataBreachImpactAssessment</seealso>
    let DataBreachImpactAssessment =
        Prefixed_Name(w3dpv, "DataBreachImpactAssessment") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:EntityInvolvementStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#EntityInvolvementStatus">https://w3id.org/dpv#EntityInvolvementStatus</seealso>
    let EntityInvolvementStatus =
        Prefixed_Name(w3dpv, "EntityInvolvementStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Intended</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#IntentionStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Intended">https://w3id.org/dpv#Intended</seealso>
    let Intended = Prefixed_Name(w3dpv, "Intended") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:MetadataManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#MetadataManagement">https://w3id.org/dpv#MetadataManagement</seealso>
    let MetadataManagement = Prefixed_Name(w3dpv, "MetadataManagement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PersonalisedAdvertising</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PersonalisedAdvertising">https://w3id.org/dpv#PersonalisedAdvertising</seealso>
    let PersonalisedAdvertising =
        Prefixed_Name(w3dpv, "PersonalisedAdvertising") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RecruitmentInterviewScheduling</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RecruitmentInterviewScheduling">https://w3id.org/dpv#RecruitmentInterviewScheduling</seealso>
    let RecruitmentInterviewScheduling =
        Prefixed_Name(w3dpv, "RecruitmentInterviewScheduling") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Transmit</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Processing</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Transmit">https://w3id.org/dpv#Transmit</seealso>
    let Transmit = Prefixed_Name(w3dpv, "Transmit") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasJointDataControllers</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasJointDataControllers">https://w3id.org/dpv#hasJointDataControllers</seealso>
    let hasJointDataControllers =
        Prefixed_Name(w3dpv, "hasJointDataControllers") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasJurisdiction">https://w3id.org/dpv#hasJurisdiction</seealso>
    let hasJurisdiction = Prefixed_Name(w3dpv, "hasJurisdiction") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasJustification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasJustification">https://w3id.org/dpv#hasJustification</seealso>
    let hasJustification = Prefixed_Name(w3dpv, "hasJustification") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:SecurityAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SecurityAssessment">https://w3id.org/dpv#SecurityAssessment</seealso>
    let SecurityAssessment = Prefixed_Name(w3dpv, "SecurityAssessment") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:EntityIntendedInvolvement</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#EntityInvolvementStatus</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#EntityIntendedInvolvement">https://w3id.org/dpv#EntityIntendedInvolvement</seealso>
    let EntityIntendedInvolvement =
        Prefixed_Name(w3dpv, "EntityIntendedInvolvement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:MessageAuthenticationCodes</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#MessageAuthenticationCodes">https://w3id.org/dpv#MessageAuthenticationCodes</seealso>
    let MessageAuthenticationCodes =
        Prefixed_Name(w3dpv, "MessageAuthenticationCodes") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RecruitmentManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RecruitmentManagement">https://w3id.org/dpv#RecruitmentManagement</seealso>
    let RecruitmentManagement =
        Prefixed_Name(w3dpv, "RecruitmentManagement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ThirdPartyAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#LegalMeasure</para>
    ///   <para>w3id:dpv#LegalBasis</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ThirdPartyAgreement">https://w3id.org/dpv#ThirdPartyAgreement</seealso>
    let ThirdPartyAgreement =
        Prefixed_Name(w3dpv, "ThirdPartyAgreement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasImpactAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasImpactAssessment">https://w3id.org/dpv#hasImpactAssessment</seealso>
    let hasImpactAssessment =
        Prefixed_Name(w3dpv, "hasImpactAssessment") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractActive</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#ContractActivationStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractActive">https://w3id.org/dpv#ContractActive</seealso>
    let ContractActive = Prefixed_Name(w3dpv, "ContractActive") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RightNonFulfilmentNotice</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RightNonFulfilmentNotice">https://w3id.org/dpv#RightNonFulfilmentNotice</seealso>
    let RightNonFulfilmentNotice =
        Prefixed_Name(w3dpv, "RightNonFulfilmentNotice") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ConsultationWithDataSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ConsultationWithDataSubject">https://w3id.org/dpv#ConsultationWithDataSubject</seealso>
    let ConsultationWithDataSubject =
        Prefixed_Name(w3dpv, "ConsultationWithDataSubject") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ConsumerStandardFormContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#LegalBasis</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ConsumerStandardFormContract">https://w3id.org/dpv#ConsumerStandardFormContract</seealso>
    let ConsumerStandardFormContract =
        Prefixed_Name(w3dpv, "ConsumerStandardFormContract") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PseudonymisedData</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PseudonymisedData">https://w3id.org/dpv#PseudonymisedData</seealso>
    let PseudonymisedData = Prefixed_Name(w3dpv, "PseudonymisedData") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContinuousFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Frequency</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContinuousFrequency">https://w3id.org/dpv#ContinuousFrequency</seealso>
    let ContinuousFrequency =
        Prefixed_Name(w3dpv, "ContinuousFrequency") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Frequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Frequency">https://w3id.org/dpv#Frequency</seealso>
    let Frequency = Prefixed_Name(w3dpv, "Frequency") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ContractStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractStatus">https://w3id.org/dpv#ContractStatus</seealso>
    let ContractStatus = Prefixed_Name(w3dpv, "ContractStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:contract-status-classes</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#contract-status-classes">https://w3id.org/dpv#contract-status-classes</seealso>
    let contract_status_classes =
        Prefixed_Name(w3dpv, "contract-status-classes") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ExpectationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ExpectationStatus">https://w3id.org/dpv#ExpectationStatus</seealso>
    let ExpectationStatus = Prefixed_Name(w3dpv, "ExpectationStatus") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Expected</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#ExpectationStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Expected">https://w3id.org/dpv#Expected</seealso>
    let Expected = Prefixed_Name(w3dpv, "Expected") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ExplicitlyExpressedConsent</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#LegalBasis</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ExplicitlyExpressedConsent">https://w3id.org/dpv#ExplicitlyExpressedConsent</seealso>
    let ExplicitlyExpressedConsent =
        Prefixed_Name(w3dpv, "ExplicitlyExpressedConsent") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ExpressedConsent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#LegalBasis</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ExpressedConsent">https://w3id.org/dpv#ExpressedConsent</seealso>
    let ExpressedConsent = Prefixed_Name(w3dpv, "ExpressedConsent") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:consent-types-classes</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#consent-types-classes">https://w3id.org/dpv#consent-types-classes</seealso>
    let consent_types_classes =
        Prefixed_Name(w3dpv, "consent-types-classes") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Export</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Processing</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Export">https://w3id.org/dpv#Export</seealso>
    let Export = Prefixed_Name(w3dpv, "Export") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:InformedConsent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#LegalBasis</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#InformedConsent">https://w3id.org/dpv#InformedConsent</seealso>
    let InformedConsent = Prefixed_Name(w3dpv, "InformedConsent") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:FederatedLocations</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#LocationFixture</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#FederatedLocations">https://w3id.org/dpv#FederatedLocations</seealso>
    let FederatedLocations = Prefixed_Name(w3dpv, "FederatedLocations") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:FeeNotRequired</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#FeeRequirement</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#FeeNotRequired">https://w3id.org/dpv#FeeNotRequired</seealso>
    let FeeNotRequired = Prefixed_Name(w3dpv, "FeeNotRequired") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:InternationalOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#InternationalOrganisation">https://w3id.org/dpv#InternationalOrganisation</seealso>
    let InternationalOrganisation =
        Prefixed_Name(w3dpv, "InternationalOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:IntrusionDetectionSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#IntrusionDetectionSystem">https://w3id.org/dpv#IntrusionDetectionSystem</seealso>
    let IntrusionDetectionSystem =
        Prefixed_Name(w3dpv, "IntrusionDetectionSystem") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:VitalInterestPending</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#VitalInterestStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#VitalInterestPending">https://w3id.org/dpv#VitalInterestPending</seealso>
    let VitalInterestPending =
        Prefixed_Name(w3dpv, "VitalInterestPending") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:VulnerabilityTestingMethods</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#VulnerabilityTestingMethods">https://w3id.org/dpv#VulnerabilityTestingMethods</seealso>
    let VulnerabilityTestingMethods =
        Prefixed_Name(w3dpv, "VulnerabilityTestingMethods") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:WebBrowserSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#WebBrowserSecurity">https://w3id.org/dpv#WebBrowserSecurity</seealso>
    let WebBrowserSecurity = Prefixed_Name(w3dpv, "WebBrowserSecurity") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:WebSecurityProtocols</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#WebSecurityProtocols">https://w3id.org/dpv#WebSecurityProtocols</seealso>
    let WebSecurityProtocols =
        Prefixed_Name(w3dpv, "WebSecurityProtocols") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:WirelessSecurityProtocols</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#WirelessSecurityProtocols">https://w3id.org/dpv#WirelessSecurityProtocols</seealso>
    let WirelessSecurityProtocols =
        Prefixed_Name(w3dpv, "WirelessSecurityProtocols") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:WithdrawingFromProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#EntityPermissiveInvolvement</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#WithdrawingFromProcess">https://w3id.org/dpv#WithdrawingFromProcess</seealso>
    let WithdrawingFromProcess =
        Prefixed_Name(w3dpv, "WithdrawingFromProcess") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:WithinDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Location</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#WithinDevice">https://w3id.org/dpv#WithinDevice</seealso>
    let WithinDevice = Prefixed_Name(w3dpv, "WithinDevice") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:WithinPhysicalEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Location</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#WithinPhysicalEnvironment">https://w3id.org/dpv#WithinPhysicalEnvironment</seealso>
    let WithinPhysicalEnvironment =
        Prefixed_Name(w3dpv, "WithinPhysicalEnvironment") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:WithinVirtualEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Location</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#WithinVirtualEnvironment">https://w3id.org/dpv#WithinVirtualEnvironment</seealso>
    let WithinVirtualEnvironment =
        Prefixed_Name(w3dpv, "WithinVirtualEnvironment") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ZeroKnowledgeAuthentication</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ZeroKnowledgeAuthentication">https://w3id.org/dpv#ZeroKnowledgeAuthentication</seealso>
    let ZeroKnowledgeAuthentication =
        Prefixed_Name(w3dpv, "ZeroKnowledgeAuthentication") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:consent-properties</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#consent-properties">https://w3id.org/dpv#consent-properties</seealso>
    let consent_properties = Prefixed_Name(w3dpv, "consent-properties") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:context-properties</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#context-properties">https://w3id.org/dpv#context-properties</seealso>
    let context_properties = Prefixed_Name(w3dpv, "context-properties") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasServiceConsumer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasServiceConsumer">https://w3id.org/dpv#hasServiceConsumer</seealso>
    let hasServiceConsumer = Prefixed_Name(w3dpv, "hasServiceConsumer") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasServiceProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasServiceProvider">https://w3id.org/dpv#hasServiceProvider</seealso>
    let hasServiceProvider = Prefixed_Name(w3dpv, "hasServiceProvider") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasSeverity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasSeverity">https://w3id.org/dpv#hasSeverity</seealso>
    let hasSeverity = Prefixed_Name(w3dpv, "hasSeverity") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Autonomous</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#AutomationLevel</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Autonomous">https://w3id.org/dpv#Autonomous</seealso>
    let Autonomous = Prefixed_Name(w3dpv, "Autonomous") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Consumer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#HumanSubject</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Consumer">https://w3id.org/dpv#Consumer</seealso>
    let Consumer = Prefixed_Name(w3dpv, "Consumer") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:StandardFormContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#LegalBasis</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#StandardFormContract">https://w3id.org/dpv#StandardFormContract</seealso>
    let StandardFormContract =
        Prefixed_Name(w3dpv, "StandardFormContract") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContextuallyAnonymisedData</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContextuallyAnonymisedData">https://w3id.org/dpv#ContextuallyAnonymisedData</seealso>
    let ContextuallyAnonymisedData =
        Prefixed_Name(w3dpv, "ContextuallyAnonymisedData") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:OrganisationGovernance</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#OrganisationGovernance">https://w3id.org/dpv#OrganisationGovernance</seealso>
    let OrganisationGovernance =
        Prefixed_Name(w3dpv, "OrganisationGovernance") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataImporter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataImporter">https://w3id.org/dpv#DataImporter</seealso>
    let DataImporter = Prefixed_Name(w3dpv, "DataImporter") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataInteroperabilityManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataInteroperabilityManagement">https://w3id.org/dpv#DataInteroperabilityManagement</seealso>
    let DataInteroperabilityManagement =
        Prefixed_Name(w3dpv, "DataInteroperabilityManagement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:EvaluationScoring</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#EvaluationScoring">https://w3id.org/dpv#EvaluationScoring</seealso>
    let EvaluationScoring = Prefixed_Name(w3dpv, "EvaluationScoring") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:NaturalPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NaturalPerson">https://w3id.org/dpv#NaturalPerson</seealso>
    let NaturalPerson = Prefixed_Name(w3dpv, "NaturalPerson") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PhysicalAuthentication</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#PhysicalMeasure</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PhysicalAuthentication">https://w3id.org/dpv#PhysicalAuthentication</seealso>
    let PhysicalAuthentication =
        Prefixed_Name(w3dpv, "PhysicalAuthentication") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PhysicalInterceptionProtection</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#PhysicalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PhysicalInterceptionProtection">https://w3id.org/dpv#PhysicalInterceptionProtection</seealso>
    let PhysicalInterceptionProtection =
        Prefixed_Name(w3dpv, "PhysicalInterceptionProtection") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RequestRejected</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#RequestStatus</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RequestRejected">https://w3id.org/dpv#RequestRejected</seealso>
    let RequestRejected = Prefixed_Name(w3dpv, "RequestRejected") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasName">https://w3id.org/dpv#hasName</seealso>
    let hasName = Prefixed_Name(w3dpv, "hasName") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:DataExporter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataExporter">https://w3id.org/dpv#DataExporter</seealso>
    let DataExporter = Prefixed_Name(w3dpv, "DataExporter") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:DataGovernance</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataGovernance">https://w3id.org/dpv#DataGovernance</seealso>
    let DataGovernance = Prefixed_Name(w3dpv, "DataGovernance") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:DataHandlingClause</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#LegalMeasure</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataHandlingClause">https://w3id.org/dpv#DataHandlingClause</seealso>
    let DataHandlingClause = Prefixed_Name(w3dpv, "DataHandlingClause") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:EvaluationOfIndividuals</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#EvaluationScoring</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#EvaluationOfIndividuals">https://w3id.org/dpv#EvaluationOfIndividuals</seealso>
    let EvaluationOfIndividuals =
        Prefixed_Name(w3dpv, "EvaluationOfIndividuals") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Infer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Processing</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Infer">https://w3id.org/dpv#Infer</seealso>
    let Infer = Prefixed_Name(w3dpv, "Infer") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:UseSyntheticData</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#UseSyntheticData">https://w3id.org/dpv#UseSyntheticData</seealso>
    let UseSyntheticData = Prefixed_Name(w3dpv, "UseSyntheticData") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:BiometricAuthentication</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#BiometricAuthentication">https://w3id.org/dpv#BiometricAuthentication</seealso>
    let BiometricAuthentication =
        Prefixed_Name(w3dpv, "BiometricAuthentication") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Recipient</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Recipient">https://w3id.org/dpv#Recipient</seealso>
    let Recipient = Prefixed_Name(w3dpv, "Recipient") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataInteroperabilityAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataInteroperabilityAssessment">https://w3id.org/dpv#DataInteroperabilityAssessment</seealso>
    let DataInteroperabilityAssessment =
        Prefixed_Name(w3dpv, "DataInteroperabilityAssessment") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataInteroperabilityImprovement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataInteroperabilityImprovement">https://w3id.org/dpv#DataInteroperabilityImprovement</seealso>
    let DataInteroperabilityImprovement =
        Prefixed_Name(w3dpv, "DataInteroperabilityImprovement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataInventoryManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataInventoryManagement">https://w3id.org/dpv#DataInventoryManagement</seealso>
    let DataInventoryManagement =
        Prefixed_Name(w3dpv, "DataInventoryManagement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataProcessor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataProcessor">https://w3id.org/dpv#DataProcessor</seealso>
    let DataProcessor = Prefixed_Name(w3dpv, "DataProcessor") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataProtectionAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataProtectionAuthority">https://w3id.org/dpv#DataProtectionAuthority</seealso>
    let DataProtectionAuthority =
        Prefixed_Name(w3dpv, "DataProtectionAuthority") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataProtectionOfficer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataProtectionOfficer">https://w3id.org/dpv#DataProtectionOfficer</seealso>
    let DataProtectionOfficer =
        Prefixed_Name(w3dpv, "DataProtectionOfficer") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataProtectionTraining</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataProtectionTraining">https://w3id.org/dpv#DataProtectionTraining</seealso>
    let DataProtectionTraining =
        Prefixed_Name(w3dpv, "DataProtectionTraining") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataQualityAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataQualityAssessment">https://w3id.org/dpv#DataQualityAssessment</seealso>
    let DataQualityAssessment =
        Prefixed_Name(w3dpv, "DataQualityAssessment") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataRedaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataRedaction">https://w3id.org/dpv#DataRedaction</seealso>
    let DataRedaction = Prefixed_Name(w3dpv, "DataRedaction") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataSanitisationTechnique</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataSanitisationTechnique">https://w3id.org/dpv#DataSanitisationTechnique</seealso>
    let DataSanitisationTechnique =
        Prefixed_Name(w3dpv, "DataSanitisationTechnique") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataRestorationPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataRestorationPolicy">https://w3id.org/dpv#DataRestorationPolicy</seealso>
    let DataRestorationPolicy =
        Prefixed_Name(w3dpv, "DataRestorationPolicy") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:FeeRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#FeeRequirement">https://w3id.org/dpv#FeeRequirement</seealso>
    let FeeRequirement = Prefixed_Name(w3dpv, "FeeRequirement") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:FeeRequired</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#FeeRequired">https://w3id.org/dpv#FeeRequired</seealso>
    let FeeRequired = Prefixed_Name(w3dpv, "FeeRequired") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Filter</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Processing</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Filter">https://w3id.org/dpv#Filter</seealso>
    let Filter = Prefixed_Name(w3dpv, "Filter") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:FireDepartment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#FireDepartment">https://w3id.org/dpv#FireDepartment</seealso>
    let FireDepartment = Prefixed_Name(w3dpv, "FireDepartment") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:FixedLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#LocationFixture</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#FixedLocation">https://w3id.org/dpv#FixedLocation</seealso>
    let FixedLocation = Prefixed_Name(w3dpv, "FixedLocation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:FixedMultipleLocations</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#LocationFixture</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#FixedMultipleLocations">https://w3id.org/dpv#FixedMultipleLocations</seealso>
    let FixedMultipleLocations =
        Prefixed_Name(w3dpv, "FixedMultipleLocations") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:FixedOccurrencesDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#FixedOccurrencesDuration">https://w3id.org/dpv#FixedOccurrencesDuration</seealso>
    let FixedOccurrencesDuration =
        Prefixed_Name(w3dpv, "FixedOccurrencesDuration") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ForProfitOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ForProfitOrganisation">https://w3id.org/dpv#ForProfitOrganisation</seealso>
    let ForProfitOrganisation =
        Prefixed_Name(w3dpv, "ForProfitOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Format</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Processing</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Format">https://w3id.org/dpv#Format</seealso>
    let Format = Prefixed_Name(w3dpv, "Format") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Structure</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Processing</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Structure">https://w3id.org/dpv#Structure</seealso>
    let Structure = Prefixed_Name(w3dpv, "Structure") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:MisusePreventionAndDetection</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#MisusePreventionAndDetection">https://w3id.org/dpv#MisusePreventionAndDetection</seealso>
    let MisusePreventionAndDetection =
        Prefixed_Name(w3dpv, "MisusePreventionAndDetection") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:LayeredNotice</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#LayeredNotice">https://w3id.org/dpv#LayeredNotice</seealso>
    let LayeredNotice = Prefixed_Name(w3dpv, "LayeredNotice") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasEntity">https://w3id.org/dpv#hasEntity</seealso>
    let hasEntity = Prefixed_Name(w3dpv, "hasEntity") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:processing-context-properties</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#processing-context-properties">https://w3id.org/dpv#processing-context-properties</seealso>
    let processing_context_properties =
        Prefixed_Name(w3dpv, "processing-context-properties") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasActivityStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasActivityStatus">https://w3id.org/dpv#hasActivityStatus</seealso>
    let hasActivityStatus = Prefixed_Name(w3dpv, "hasActivityStatus") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasStatus">https://w3id.org/dpv#hasStatus</seealso>
    let hasStatus = Prefixed_Name(w3dpv, "hasStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasTechnicalMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasTechnicalMeasure">https://w3id.org/dpv#hasTechnicalMeasure</seealso>
    let hasTechnicalMeasure =
        Prefixed_Name(w3dpv, "hasTechnicalMeasure") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasThirdCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasThirdCountry">https://w3id.org/dpv#hasThirdCountry</seealso>
    let hasThirdCountry = Prefixed_Name(w3dpv, "hasThirdCountry") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Contract</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#LegalBasis</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Contract">https://w3id.org/dpv#Contract</seealso>
    let Contract = Prefixed_Name(w3dpv, "Contract") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractActivationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractActivationStatus">https://w3id.org/dpv#ContractActivationStatus</seealso>
    let ContractActivationStatus =
        Prefixed_Name(w3dpv, "ContractActivationStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataJurisdictionPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataJurisdictionPolicy">https://w3id.org/dpv#DataJurisdictionPolicy</seealso>
    let DataJurisdictionPolicy =
        Prefixed_Name(w3dpv, "DataJurisdictionPolicy") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataLiteracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataLiteracy">https://w3id.org/dpv#DataLiteracy</seealso>
    let DataLiteracy = Prefixed_Name(w3dpv, "DataLiteracy") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:NetworkSecurityProtocols</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NetworkSecurityProtocols">https://w3id.org/dpv#NetworkSecurityProtocols</seealso>
    let NetworkSecurityProtocols =
        Prefixed_Name(w3dpv, "NetworkSecurityProtocols") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:NonCitizen</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#HumanSubject</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NonCitizen">https://w3id.org/dpv#NonCitizen</seealso>
    let NonCitizen = Prefixed_Name(w3dpv, "NonCitizen") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:NonCommercialPurpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NonCommercialPurpose">https://w3id.org/dpv#NonCommercialPurpose</seealso>
    let NonCommercialPurpose =
        Prefixed_Name(w3dpv, "NonCommercialPurpose") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:NonCommercialResearch</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NonCommercialResearch">https://w3id.org/dpv#NonCommercialResearch</seealso>
    let NonCommercialResearch =
        Prefixed_Name(w3dpv, "NonCommercialResearch") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:VitalInterestObjected</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#VitalInterestStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#VitalInterestObjected">https://w3id.org/dpv#VitalInterestObjected</seealso>
    let VitalInterestObjected =
        Prefixed_Name(w3dpv, "VitalInterestObjected") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:VitalInterestOfDataSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#LegalBasis</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#VitalInterestOfDataSubject">https://w3id.org/dpv#VitalInterestOfDataSubject</seealso>
    let VitalInterestOfDataSubject =
        Prefixed_Name(w3dpv, "VitalInterestOfDataSubject") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:VitalInterestOfNaturalPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#LegalBasis</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#VitalInterestOfNaturalPerson">https://w3id.org/dpv#VitalInterestOfNaturalPerson</seealso>
    let VitalInterestOfNaturalPerson =
        Prefixed_Name(w3dpv, "VitalInterestOfNaturalPerson") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasPhysicalMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasPhysicalMeasure">https://w3id.org/dpv#hasPhysicalMeasure</seealso>
    let hasPhysicalMeasure = Prefixed_Name(w3dpv, "hasPhysicalMeasure") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasPolicy">https://w3id.org/dpv#hasPolicy</seealso>
    let hasPolicy = Prefixed_Name(w3dpv, "hasPolicy") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:serialisation-jsonld</para>
    /// </summary>
    /// <remarks>
    ///   <para>prof:ResourceDescriptor</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#serialisation-jsonld">https://w3id.org/dpv#serialisation-jsonld</seealso>
    let serialisation_jsonld =
        Prefixed_Name(w3dpv, "serialisation-jsonld") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:serialisation-n3</para>
    /// </summary>
    /// <remarks>
    ///   <para>prof:ResourceDescriptor</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#serialisation-n3">https://w3id.org/dpv#serialisation-n3</seealso>
    let serialisation_n3 = Prefixed_Name(w3dpv, "serialisation-n3") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ContractAmended</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#ContractPerformanceStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractAmended">https://w3id.org/dpv#ContractAmended</seealso>
    let ContractAmended = Prefixed_Name(w3dpv, "ContractAmended") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractPerformanceStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractPerformanceStatus">https://w3id.org/dpv#ContractPerformanceStatus</seealso>
    let ContractPerformanceStatus =
        Prefixed_Name(w3dpv, "ContractPerformanceStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractualClause</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractualClause">https://w3id.org/dpv#ContractualClause</seealso>
    let ContractualClause = Prefixed_Name(w3dpv, "ContractualClause") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ContractApproved</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#ContractPreparationStatus</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractApproved">https://w3id.org/dpv#ContractApproved</seealso>
    let ContractApproved = Prefixed_Name(w3dpv, "ContractApproved") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractPreparationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractPreparationStatus">https://w3id.org/dpv#ContractPreparationStatus</seealso>
    let ContractPreparationStatus =
        Prefixed_Name(w3dpv, "ContractPreparationStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Representative</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Representative">https://w3id.org/dpv#Representative</seealso>
    let Representative = Prefixed_Name(w3dpv, "Representative") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataPublishedByDataSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#DataSubjectDataSource</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataPublishedByDataSubject">https://w3id.org/dpv#DataPublishedByDataSubject</seealso>
    let DataPublishedByDataSubject =
        Prefixed_Name(w3dpv, "DataPublishedByDataSubject") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataSubjectDataSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#DataSource</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataSubjectDataSource">https://w3id.org/dpv#DataSubjectDataSource</seealso>
    let DataSubjectDataSource =
        Prefixed_Name(w3dpv, "DataSubjectDataSource") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataQualityManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataQualityManagement">https://w3id.org/dpv#DataQualityManagement</seealso>
    let DataQualityManagement =
        Prefixed_Name(w3dpv, "DataQualityManagement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataQualityImprovement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataQualityImprovement">https://w3id.org/dpv#DataQualityImprovement</seealso>
    let DataQualityImprovement =
        Prefixed_Name(w3dpv, "DataQualityImprovement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:FRIA</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#FRIA">https://w3id.org/dpv#FRIA</seealso>
    let FRIA = Prefixed_Name(w3dpv, "FRIA") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:NonCompliant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#ComplianceStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NonCompliant">https://w3id.org/dpv#NonCompliant</seealso>
    let NonCompliant = Prefixed_Name(w3dpv, "NonCompliant") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:PrivacyByDesign</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PrivacyByDesign">https://w3id.org/dpv#PrivacyByDesign</seealso>
    let PrivacyByDesign = Prefixed_Name(w3dpv, "PrivacyByDesign") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:VitalInterestOngoing</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#VitalInterestStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#VitalInterestOngoing">https://w3id.org/dpv#VitalInterestOngoing</seealso>
    let VitalInterestOngoing =
        Prefixed_Name(w3dpv, "VitalInterestOngoing") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasPurpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasPurpose">https://w3id.org/dpv#hasPurpose</seealso>
    let hasPurpose = Prefixed_Name(w3dpv, "hasPurpose") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:purposes-properties</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#purposes-properties">https://w3id.org/dpv#purposes-properties</seealso>
    let purposes_properties =
        Prefixed_Name(w3dpv, "purposes-properties") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasRecipientThirdParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasRecipientThirdParty">https://w3id.org/dpv#hasRecipientThirdParty</seealso>
    let hasRecipientThirdParty =
        Prefixed_Name(w3dpv, "hasRecipientThirdParty") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasRecommendation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasRecommendation">https://w3id.org/dpv#hasRecommendation</seealso>
    let hasRecommendation = Prefixed_Name(w3dpv, "hasRecommendation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasRecordOfActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasRecordOfActivity">https://w3id.org/dpv#hasRecordOfActivity</seealso>
    let hasRecordOfActivity =
        Prefixed_Name(w3dpv, "hasRecordOfActivity") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasRelationWithDataSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasRelationWithDataSubject">https://w3id.org/dpv#hasRelationWithDataSubject</seealso>
    let hasRelationWithDataSubject =
        Prefixed_Name(w3dpv, "hasRelationWithDataSubject") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:serialisation-rdf</para>
    /// </summary>
    /// <remarks>
    ///   <para>prof:ResourceDescriptor</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#serialisation-rdf">https://w3id.org/dpv#serialisation-rdf</seealso>
    let serialisation_rdf = Prefixed_Name(w3dpv, "serialisation-rdf") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:AILiteracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#AILiteracy">https://w3id.org/dpv#AILiteracy</seealso>
    let AILiteracy = Prefixed_Name(w3dpv, "AILiteracy") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:DigitalLiteracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DigitalLiteracy">https://w3id.org/dpv#DigitalLiteracy</seealso>
    let DigitalLiteracy = Prefixed_Name(w3dpv, "DigitalLiteracy") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Notice</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Notice">https://w3id.org/dpv#Notice</seealso>
    let Notice = Prefixed_Name(w3dpv, "Notice") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Customer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#HumanSubject</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Customer">https://w3id.org/dpv#Customer</seealso>
    let Customer = Prefixed_Name(w3dpv, "Customer") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Clinic</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Clinic">https://w3id.org/dpv#Clinic</seealso>
    let Clinic = Prefixed_Name(w3dpv, "Clinic") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Location">https://w3id.org/dpv#Location</seealso>
    let Location = Prefixed_Name(w3dpv, "Location") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:RemoteLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Location</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RemoteLocation">https://w3id.org/dpv#RemoteLocation</seealso>
    let RemoteLocation = Prefixed_Name(w3dpv, "RemoteLocation") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:CodeOfConduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CodeOfConduct">https://w3id.org/dpv#CodeOfConduct</seealso>
    let CodeOfConduct = Prefixed_Name(w3dpv, "CodeOfConduct") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:GuidelinesPrinciple</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#GuidelinesPrinciple">https://w3id.org/dpv#GuidelinesPrinciple</seealso>
    let GuidelinesPrinciple =
        Prefixed_Name(w3dpv, "GuidelinesPrinciple") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:CollectedData</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CollectedData">https://w3id.org/dpv#CollectedData</seealso>
    let CollectedData = Prefixed_Name(w3dpv, "CollectedData") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Data</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Data">https://w3id.org/dpv#Data</seealso>
    let Data = Prefixed_Name(w3dpv, "Data") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:PersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PersonalData">https://w3id.org/dpv#PersonalData</seealso>
    let PersonalData = Prefixed_Name(w3dpv, "PersonalData") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:PublicBenefit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PublicBenefit">https://w3id.org/dpv#PublicBenefit</seealso>
    let PublicBenefit = Prefixed_Name(w3dpv, "PublicBenefit") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:CommercialPurpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CommercialPurpose">https://w3id.org/dpv#CommercialPurpose</seealso>
    let CommercialPurpose = Prefixed_Name(w3dpv, "CommercialPurpose") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:CommerciallyConfidentialData</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CommerciallyConfidentialData">https://w3id.org/dpv#CommerciallyConfidentialData</seealso>
    let CommerciallyConfidentialData =
        Prefixed_Name(w3dpv, "CommerciallyConfidentialData") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:CommunicationForCustomerCare</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CommunicationForCustomerCare">https://w3id.org/dpv#CommunicationForCustomerCare</seealso>
    let CommunicationForCustomerCare =
        Prefixed_Name(w3dpv, "CommunicationForCustomerCare") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:CommunicationManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Purpose</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CommunicationManagement">https://w3id.org/dpv#CommunicationManagement</seealso>
    let CommunicationManagement =
        Prefixed_Name(w3dpv, "CommunicationManagement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ReuseCompatibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ReuseCompatibility">https://w3id.org/dpv#ReuseCompatibility</seealso>
    let ReuseCompatibility = Prefixed_Name(w3dpv, "ReuseCompatibility") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ComplianceAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ComplianceAssessment">https://w3id.org/dpv#ComplianceAssessment</seealso>
    let ComplianceAssessment =
        Prefixed_Name(w3dpv, "ComplianceAssessment") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ComplianceMonitoring</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ComplianceMonitoring">https://w3id.org/dpv#ComplianceMonitoring</seealso>
    let ComplianceMonitoring =
        Prefixed_Name(w3dpv, "ComplianceMonitoring") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ComplianceUnknown</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#ComplianceStatus</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ComplianceUnknown">https://w3id.org/dpv#ComplianceUnknown</seealso>
    let ComplianceUnknown = Prefixed_Name(w3dpv, "ComplianceUnknown") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ComplianceViolation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#ComplianceStatus</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ComplianceViolation">https://w3id.org/dpv#ComplianceViolation</seealso>
    let ComplianceViolation =
        Prefixed_Name(w3dpv, "ComplianceViolation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ConditionalAutomation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#AutomationLevel</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ConditionalAutomation">https://w3id.org/dpv#ConditionalAutomation</seealso>
    let ConditionalAutomation =
        Prefixed_Name(w3dpv, "ConditionalAutomation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ConfidentialityAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#LegalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ConfidentialityAgreement">https://w3id.org/dpv#ConfidentialityAgreement</seealso>
    let ConfidentialityAgreement =
        Prefixed_Name(w3dpv, "ConfidentialityAgreement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:LegalMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#LegalMeasure">https://w3id.org/dpv#LegalMeasure</seealso>
    let LegalMeasure = Prefixed_Name(w3dpv, "LegalMeasure") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:LegalAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#LegalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#LegalAgreement">https://w3id.org/dpv#LegalAgreement</seealso>
    let LegalAgreement = Prefixed_Name(w3dpv, "LegalAgreement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:legal-measures-classes</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#legal-measures-classes">https://w3id.org/dpv#legal-measures-classes</seealso>
    let legal_measures_classes =
        Prefixed_Name(w3dpv, "legal-measures-classes") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ConformanceAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ConformanceAssessment">https://w3id.org/dpv#ConformanceAssessment</seealso>
    let ConformanceAssessment =
        Prefixed_Name(w3dpv, "ConformanceAssessment") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DistributionAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#LegalBasis</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DistributionAgreement">https://w3id.org/dpv#DistributionAgreement</seealso>
    let DistributionAgreement =
        Prefixed_Name(w3dpv, "DistributionAgreement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DocumentRandomisedPseudonymisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DocumentRandomisedPseudonymisation">https://w3id.org/dpv#DocumentRandomisedPseudonymisation</seealso>
    let DocumentRandomisedPseudonymisation =
        Prefixed_Name(w3dpv, "DocumentRandomisedPseudonymisation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DocumentSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DocumentSecurity">https://w3id.org/dpv#DocumentSecurity</seealso>
    let DocumentSecurity = Prefixed_Name(w3dpv, "DocumentSecurity") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Download</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Processing</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Download">https://w3id.org/dpv#Download</seealso>
    let Download = Prefixed_Name(w3dpv, "Download") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Duration">https://w3id.org/dpv#Duration</seealso>
    let Duration = Prefixed_Name(w3dpv, "Duration") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:EULA</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#LegalBasis</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#EULA">https://w3id.org/dpv#EULA</seealso>
    let EULA = Prefixed_Name(w3dpv, "EULA") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:LicenseAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#LegalBasis</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#LicenseAgreement">https://w3id.org/dpv#LicenseAgreement</seealso>
    let LicenseAgreement = Prefixed_Name(w3dpv, "LicenseAgreement") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:EconomicUnion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#EconomicUnion">https://w3id.org/dpv#EconomicUnion</seealso>
    let EconomicUnion = Prefixed_Name(w3dpv, "EconomicUnion") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:HashMessageAuthenticationCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#HashMessageAuthenticationCode">https://w3id.org/dpv#HashMessageAuthenticationCode</seealso>
    let HashMessageAuthenticationCode =
        Prefixed_Name(w3dpv, "HashMessageAuthenticationCode") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:HealthcareOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#HealthcareOrganisation">https://w3id.org/dpv#HealthcareOrganisation</seealso>
    let HealthcareOrganisation =
        Prefixed_Name(w3dpv, "HealthcareOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:HighAutomation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#AutomationLevel</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#HighAutomation">https://w3id.org/dpv#HighAutomation</seealso>
    let HighAutomation = Prefixed_Name(w3dpv, "HighAutomation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:HomomorphicEncryption</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#HomomorphicEncryption">https://w3id.org/dpv#HomomorphicEncryption</seealso>
    let HomomorphicEncryption =
        Prefixed_Name(w3dpv, "HomomorphicEncryption") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Hospital</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Hospital">https://w3id.org/dpv#Hospital</seealso>
    let Hospital = Prefixed_Name(w3dpv, "Hospital") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:HugeDataVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#DataVolume</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#HugeDataVolume">https://w3id.org/dpv#HugeDataVolume</seealso>
    let HugeDataVolume = Prefixed_Name(w3dpv, "HugeDataVolume") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Organise</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Processing</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Organise">https://w3id.org/dpv#Organise</seealso>
    let Organise = Prefixed_Name(w3dpv, "Organise") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:PIA</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PIA">https://w3id.org/dpv#PIA</seealso>
    let PIA = Prefixed_Name(w3dpv, "PIA") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ParentLegalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ParentLegalEntity">https://w3id.org/dpv#ParentLegalEntity</seealso>
    let ParentLegalEntity = Prefixed_Name(w3dpv, "ParentLegalEntity") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ParentOfDataSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#HumanSubject</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ParentOfDataSubject">https://w3id.org/dpv#ParentOfDataSubject</seealso>
    let ParentOfDataSubject =
        Prefixed_Name(w3dpv, "ParentOfDataSubject") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ParentOfHuman</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#HumanSubject</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ParentOfHuman">https://w3id.org/dpv#ParentOfHuman</seealso>
    let ParentOfHuman = Prefixed_Name(w3dpv, "ParentOfHuman") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:PartiallyCompliant</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#ComplianceStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PartiallyCompliant">https://w3id.org/dpv#PartiallyCompliant</seealso>
    let PartiallyCompliant = Prefixed_Name(w3dpv, "PartiallyCompliant") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Participant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#HumanSubject</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Participant">https://w3id.org/dpv#Participant</seealso>
    let Participant = Prefixed_Name(w3dpv, "Participant") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:PassiveRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Right</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PassiveRight">https://w3id.org/dpv#PassiveRight</seealso>
    let PassiveRight = Prefixed_Name(w3dpv, "PassiveRight") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:PassivelyInvolved</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#InvolvementStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PassivelyInvolved">https://w3id.org/dpv#PassivelyInvolved</seealso>
    let PassivelyInvolved = Prefixed_Name(w3dpv, "PassivelyInvolved") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:RecipientInformed</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#EntityInformedStatus</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RecipientInformed">https://w3id.org/dpv#RecipientInformed</seealso>
    let RecipientInformed = Prefixed_Name(w3dpv, "RecipientInformed") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RecipientUninformed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#EntityInformedStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RecipientUninformed">https://w3id.org/dpv#RecipientUninformed</seealso>
    let RecipientUninformed =
        Prefixed_Name(w3dpv, "RecipientUninformed") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Recommendation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Rule</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Recommendation">https://w3id.org/dpv#Recommendation</seealso>
    let Recommendation = Prefixed_Name(w3dpv, "Recommendation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:TechnicalServiceProvision</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#TechnicalServiceProvision">https://w3id.org/dpv#TechnicalServiceProvision</seealso>
    let TechnicalServiceProvision =
        Prefixed_Name(w3dpv, "TechnicalServiceProvision") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:TechnicalStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#TechnicalStandard">https://w3id.org/dpv#TechnicalStandard</seealso>
    let TechnicalStandard = Prefixed_Name(w3dpv, "TechnicalStandard") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Technology</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Technology">https://w3id.org/dpv#Technology</seealso>
    let Technology = Prefixed_Name(w3dpv, "Technology") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:TerminateContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#TerminateContract">https://w3id.org/dpv#TerminateContract</seealso>
    let TerminateContract = Prefixed_Name(w3dpv, "TerminateContract") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:TermsOfService</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#ContractualClause</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#TermsOfService">https://w3id.org/dpv#TermsOfService</seealso>
    let TermsOfService = Prefixed_Name(w3dpv, "TermsOfService") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ThirdCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ThirdCountry">https://w3id.org/dpv#ThirdCountry</seealso>
    let ThirdCountry = Prefixed_Name(w3dpv, "ThirdCountry") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ThirdParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ThirdParty">https://w3id.org/dpv#ThirdParty</seealso>
    let ThirdParty = Prefixed_Name(w3dpv, "ThirdParty") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ThirdPartyContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#LegalBasis</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ThirdPartyContract">https://w3id.org/dpv#ThirdPartyContract</seealso>
    let ThirdPartyContract = Prefixed_Name(w3dpv, "ThirdPartyContract") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ThirdPartyDataSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#DataSource</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ThirdPartyDataSource">https://w3id.org/dpv#ThirdPartyDataSource</seealso>
    let ThirdPartyDataSource =
        Prefixed_Name(w3dpv, "ThirdPartyDataSource") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ThirdPartySecurityProcedures</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ThirdPartySecurityProcedures">https://w3id.org/dpv#ThirdPartySecurityProcedures</seealso>
    let ThirdPartySecurityProcedures =
        Prefixed_Name(w3dpv, "ThirdPartySecurityProcedures") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Tourist</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#HumanSubject</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Tourist">https://w3id.org/dpv#Tourist</seealso>
    let Tourist = Prefixed_Name(w3dpv, "Tourist") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Tracking</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Processing</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Tracking">https://w3id.org/dpv#Tracking</seealso>
    let Tracking = Prefixed_Name(w3dpv, "Tracking") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasImpactOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasImpactOn">https://w3id.org/dpv#hasImpactOn</seealso>
    let hasImpactOn = Prefixed_Name(w3dpv, "hasImpactOn") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasImportance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasImportance">https://w3id.org/dpv#hasImportance</seealso>
    let hasImportance = Prefixed_Name(w3dpv, "hasImportance") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasIndicationMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasIndicationMethod">https://w3id.org/dpv#hasIndicationMethod</seealso>
    let hasIndicationMethod =
        Prefixed_Name(w3dpv, "hasIndicationMethod") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:legal-basis-properties</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#legal-basis-properties">https://w3id.org/dpv#legal-basis-properties</seealso>
    let legal_basis_properties =
        Prefixed_Name(w3dpv, "legal-basis-properties") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasInformedStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasInformedStatus">https://w3id.org/dpv#hasInformedStatus</seealso>
    let hasInformedStatus = Prefixed_Name(w3dpv, "hasInformedStatus") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasIntention</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasIntention">https://w3id.org/dpv#hasIntention</seealso>
    let hasIntention = Prefixed_Name(w3dpv, "hasIntention") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:serialisation-html</para>
    /// </summary>
    /// <remarks>
    ///   <para>prof:ResourceDescriptor</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#serialisation-html">https://w3id.org/dpv#serialisation-html</seealso>
    let serialisation_html = Prefixed_Name(w3dpv, "serialisation-html") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:OrganisationalMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#OrganisationalMeasure">https://w3id.org/dpv#OrganisationalMeasure</seealso>
    let OrganisationalMeasure =
        Prefixed_Name(w3dpv, "OrganisationalMeasure") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractAmendmentClause</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#ContractualClause</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractAmendmentClause">https://w3id.org/dpv#ContractAmendmentClause</seealso>
    let ContractAmendmentClause =
        Prefixed_Name(w3dpv, "ContractAmendmentClause") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:contract-clause-classes</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#contract-clause-classes">https://w3id.org/dpv#contract-clause-classes</seealso>
    let contract_clause_classes =
        Prefixed_Name(w3dpv, "contract-clause-classes") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractBreached</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#ContractTerminationStatus</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractBreached">https://w3id.org/dpv#ContractBreached</seealso>
    let ContractBreached = Prefixed_Name(w3dpv, "ContractBreached") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractTerminationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractTerminationStatus">https://w3id.org/dpv#ContractTerminationStatus</seealso>
    let ContractTerminationStatus =
        Prefixed_Name(w3dpv, "ContractTerminationStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractByNegotiationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#LegalBasis</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractByNegotiationType">https://w3id.org/dpv#ContractByNegotiationType</seealso>
    let ContractByNegotiationType =
        Prefixed_Name(w3dpv, "ContractByNegotiationType") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractDefinitions</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#ContractualClause</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractDefinitions">https://w3id.org/dpv#ContractDefinitions</seealso>
    let ContractDefinitions =
        Prefixed_Name(w3dpv, "ContractDefinitions") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractDisputeResolutionClause</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#ContractualClause</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractDisputeResolutionClause">https://w3id.org/dpv#ContractDisputeResolutionClause</seealso>
    let ContractDisputeResolutionClause =
        Prefixed_Name(w3dpv, "ContractDisputeResolutionClause") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractDrafted</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#ContractPreparationStatus</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractDrafted">https://w3id.org/dpv#ContractDrafted</seealso>
    let ContractDrafted = Prefixed_Name(w3dpv, "ContractDrafted") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:DataSubProcessor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataSubProcessor">https://w3id.org/dpv#DataSubProcessor</seealso>
    let DataSubProcessor = Prefixed_Name(w3dpv, "DataSubProcessor") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:InverseJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Jurisdiction</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#InverseJurisdiction">https://w3id.org/dpv#InverseJurisdiction</seealso>
    let InverseJurisdiction =
        Prefixed_Name(w3dpv, "InverseJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:NotInvolved</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#InvolvementStatus</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NotInvolved">https://w3id.org/dpv#NotInvolved</seealso>
    let NotInvolved = Prefixed_Name(w3dpv, "NotInvolved") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:NotRequired</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Necessity</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NotRequired">https://w3id.org/dpv#NotRequired</seealso>
    let NotRequired = Prefixed_Name(w3dpv, "NotRequired") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ProhibitionUnviolated</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#RuleFulfilmentStatus</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ProhibitionUnviolated">https://w3id.org/dpv#ProhibitionUnviolated</seealso>
    let ProhibitionUnviolated =
        Prefixed_Name(w3dpv, "ProhibitionUnviolated") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ProhibitionViolated</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#RuleFulfilmentStatus</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ProhibitionViolated">https://w3id.org/dpv#ProhibitionViolated</seealso>
    let ProhibitionViolated =
        Prefixed_Name(w3dpv, "ProhibitionViolated") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ProtectionOfIPR</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ProtectionOfIPR">https://w3id.org/dpv#ProtectionOfIPR</seealso>
    let ProtectionOfIPR = Prefixed_Name(w3dpv, "ProtectionOfIPR") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ProtectionOfPublicSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ProtectionOfPublicSecurity">https://w3id.org/dpv#ProtectionOfPublicSecurity</seealso>
    let ProtectionOfPublicSecurity =
        Prefixed_Name(w3dpv, "ProtectionOfPublicSecurity") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ProvideEventRecommendations</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ProvideEventRecommendations">https://w3id.org/dpv#ProvideEventRecommendations</seealso>
    let ProvideEventRecommendations =
        Prefixed_Name(w3dpv, "ProvideEventRecommendations") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ProvidePersonalisedRecommendations</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ProvidePersonalisedRecommendations">https://w3id.org/dpv#ProvidePersonalisedRecommendations</seealso>
    let ProvidePersonalisedRecommendations =
        Prefixed_Name(w3dpv, "ProvidePersonalisedRecommendations") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ProvideOfficialStatistics</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ProvideOfficialStatistics">https://w3id.org/dpv#ProvideOfficialStatistics</seealso>
    let ProvideOfficialStatistics =
        Prefixed_Name(w3dpv, "ProvideOfficialStatistics") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SensitivityLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SensitivityLevel">https://w3id.org/dpv#SensitivityLevel</seealso>
    let SensitivityLevel = Prefixed_Name(w3dpv, "SensitivityLevel") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Severity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Severity">https://w3id.org/dpv#Severity</seealso>
    let Severity = Prefixed_Name(w3dpv, "Severity") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Service">https://w3id.org/dpv#Service</seealso>
    let Service = Prefixed_Name(w3dpv, "Service") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ServiceConsumer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ServiceConsumer">https://w3id.org/dpv#ServiceConsumer</seealso>
    let ServiceConsumer = Prefixed_Name(w3dpv, "ServiceConsumer") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ServiceProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ServiceProvider">https://w3id.org/dpv#ServiceProvider</seealso>
    let ServiceProvider = Prefixed_Name(w3dpv, "ServiceProvider") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ServiceRegistration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Purpose</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ServiceRegistration">https://w3id.org/dpv#ServiceRegistration</seealso>
    let ServiceRegistration =
        Prefixed_Name(w3dpv, "ServiceRegistration") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ServiceUsageAnalytics</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ServiceUsageAnalytics">https://w3id.org/dpv#ServiceUsageAnalytics</seealso>
    let ServiceUsageAnalytics =
        Prefixed_Name(w3dpv, "ServiceUsageAnalytics") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:status-properties</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#status-properties">https://w3id.org/dpv#status-properties</seealso>
    let status_properties = Prefixed_Name(w3dpv, "status-properties") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasAddress">https://w3id.org/dpv#hasAddress</seealso>
    let hasAddress = Prefixed_Name(w3dpv, "hasAddress") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasAlgorithmicLogic</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasAlgorithmicLogic">https://w3id.org/dpv#hasAlgorithmicLogic</seealso>
    let hasAlgorithmicLogic =
        Prefixed_Name(w3dpv, "hasAlgorithmicLogic") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasThirdParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasThirdParty">https://w3id.org/dpv#hasThirdParty</seealso>
    let hasThirdParty = Prefixed_Name(w3dpv, "hasThirdParty") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasUncategorisedData</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasUncategorisedData">https://w3id.org/dpv#hasUncategorisedData</seealso>
    let hasUncategorisedData =
        Prefixed_Name(w3dpv, "hasUncategorisedData") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasUnstructuredData</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasUnstructuredData">https://w3id.org/dpv#hasUnstructuredData</seealso>
    let hasUnstructuredData =
        Prefixed_Name(w3dpv, "hasUnstructuredData") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:isAfter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#isAfter">https://w3id.org/dpv#isAfter</seealso>
    let isAfter = Prefixed_Name(w3dpv, "isAfter") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:isApplicableFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#isApplicableFor">https://w3id.org/dpv#isApplicableFor</seealso>
    let isApplicableFor = Prefixed_Name(w3dpv, "isApplicableFor") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:serialisation-ttl</para>
    /// </summary>
    /// <remarks>
    ///   <para>prof:ResourceDescriptor</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#serialisation-ttl">https://w3id.org/dpv#serialisation-ttl</seealso>
    let serialisation_ttl = Prefixed_Name(w3dpv, "serialisation-ttl") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:AINotice</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#AINotice">https://w3id.org/dpv#AINotice</seealso>
    let AINotice = Prefixed_Name(w3dpv, "AINotice") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:jurisdiction-classes</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#jurisdiction-classes">https://w3id.org/dpv#jurisdiction-classes</seealso>
    let jurisdiction_classes =
        Prefixed_Name(w3dpv, "jurisdiction-classes") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Client</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#HumanSubject</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Client">https://w3id.org/dpv#Client</seealso>
    let Client = Prefixed_Name(w3dpv, "Client") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ContractDisputed</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#ContractTerminationStatus</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractDisputed">https://w3id.org/dpv#ContractDisputed</seealso>
    let ContractDisputed = Prefixed_Name(w3dpv, "ContractDisputed") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ContractExpired</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#ContractTerminationStatus</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractExpired">https://w3id.org/dpv#ContractExpired</seealso>
    let ContractExpired = Prefixed_Name(w3dpv, "ContractExpired") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ContractExtended</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#ContractTerminationStatus</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractExtended">https://w3id.org/dpv#ContractExtended</seealso>
    let ContractExtended = Prefixed_Name(w3dpv, "ContractExtended") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataTransferImpactAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataTransferImpactAssessment">https://w3id.org/dpv#DataTransferImpactAssessment</seealso>
    let DataTransferImpactAssessment =
        Prefixed_Name(w3dpv, "DataTransferImpactAssessment") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ImpactAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ImpactAssessment">https://w3id.org/dpv#ImpactAssessment</seealso>
    let ImpactAssessment = Prefixed_Name(w3dpv, "ImpactAssessment") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:JudicialOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#JudicialOrganisation">https://w3id.org/dpv#JudicialOrganisation</seealso>
    let JudicialOrganisation =
        Prefixed_Name(w3dpv, "JudicialOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:NoticeStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NoticeStatus">https://w3id.org/dpv#NoticeStatus</seealso>
    let NoticeStatus = Prefixed_Name(w3dpv, "NoticeStatus") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:NoticeIcon</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NoticeIcon">https://w3id.org/dpv#NoticeIcon</seealso>
    let NoticeIcon = Prefixed_Name(w3dpv, "NoticeIcon") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:NoticeLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NoticeLayer">https://w3id.org/dpv#NoticeLayer</seealso>
    let NoticeLayer = Prefixed_Name(w3dpv, "NoticeLayer") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:NoticeStale</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#NoticeStatus</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NoticeStale">https://w3id.org/dpv#NoticeStale</seealso>
    let NoticeStale = Prefixed_Name(w3dpv, "NoticeStale") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:NoticeUnused</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#NoticeStatus</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NoticeUnused">https://w3id.org/dpv#NoticeUnused</seealso>
    let NoticeUnused = Prefixed_Name(w3dpv, "NoticeUnused") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Notification</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Notification">https://w3id.org/dpv#Notification</seealso>
    let Notification = Prefixed_Name(w3dpv, "Notification") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:NotificationFailed</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#NotificationStatus</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NotificationFailed">https://w3id.org/dpv#NotificationFailed</seealso>
    let NotificationFailed = Prefixed_Name(w3dpv, "NotificationFailed") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:NotificationOngoing</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#NotificationStatus</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NotificationOngoing">https://w3id.org/dpv#NotificationOngoing</seealso>
    let NotificationOngoing =
        Prefixed_Name(w3dpv, "NotificationOngoing") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:NotificationPlanned</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#NotificationStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NotificationPlanned">https://w3id.org/dpv#NotificationPlanned</seealso>
    let NotificationPlanned =
        Prefixed_Name(w3dpv, "NotificationPlanned") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ProtectionOfNationalSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ProtectionOfNationalSecurity">https://w3id.org/dpv#ProtectionOfNationalSecurity</seealso>
    let ProtectionOfNationalSecurity =
        Prefixed_Name(w3dpv, "ProtectionOfNationalSecurity") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SensitiveNonPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SensitiveNonPersonalData">https://w3id.org/dpv#SensitiveNonPersonalData</seealso>
    let SensitiveNonPersonalData =
        Prefixed_Name(w3dpv, "SensitiveNonPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SensitivePersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SensitivePersonalData">https://w3id.org/dpv#SensitivePersonalData</seealso>
    let SensitivePersonalData =
        Prefixed_Name(w3dpv, "SensitivePersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasSensitivityLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasSensitivityLevel">https://w3id.org/dpv#hasSensitivityLevel</seealso>
    let hasSensitivityLevel =
        Prefixed_Name(w3dpv, "hasSensitivityLevel") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasService</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasService">https://w3id.org/dpv#hasService</seealso>
    let hasService = Prefixed_Name(w3dpv, "hasService") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:CannotOptInToProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#EntityNonPermissiveInvolvement</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CannotOptInToProcess">https://w3id.org/dpv#CannotOptInToProcess</seealso>
    let CannotOptInToProcess =
        Prefixed_Name(w3dpv, "CannotOptInToProcess") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractBeingPerformed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#ContractPerformanceStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractBeingPerformed">https://w3id.org/dpv#ContractBeingPerformed</seealso>
    let ContractBeingPerformed =
        Prefixed_Name(w3dpv, "ContractBeingPerformed") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractByDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#LegalBasis</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractByDomain">https://w3id.org/dpv#ContractByDomain</seealso>
    let ContractByDomain = Prefixed_Name(w3dpv, "ContractByDomain") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:DataReusePolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataReusePolicy">https://w3id.org/dpv#DataReusePolicy</seealso>
    let DataReusePolicy = Prefixed_Name(w3dpv, "DataReusePolicy") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:FileSystemSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#FileSystemSecurity">https://w3id.org/dpv#FileSystemSecurity</seealso>
    let FileSystemSecurity = Prefixed_Name(w3dpv, "FileSystemSecurity") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:NonProfitOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NonProfitOrganisation">https://w3id.org/dpv#NonProfitOrganisation</seealso>
    let NonProfitOrganisation =
        Prefixed_Name(w3dpv, "NonProfitOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PrivateSectorBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PrivateSectorBody">https://w3id.org/dpv#PrivateSectorBody</seealso>
    let PrivateSectorBody = Prefixed_Name(w3dpv, "PrivateSectorBody") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SearchFunctionalities</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SearchFunctionalities">https://w3id.org/dpv#SearchFunctionalities</seealso>
    let SearchFunctionalities =
        Prefixed_Name(w3dpv, "SearchFunctionalities") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasRecipientDataController</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasRecipientDataController">https://w3id.org/dpv#hasRecipientDataController</seealso>
    let hasRecipientDataController =
        Prefixed_Name(w3dpv, "hasRecipientDataController") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:organisational-measures-classes</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#organisational-measures-classes">https://w3id.org/dpv#organisational-measures-classes</seealso>
    let organisational_measures_classes =
        Prefixed_Name(w3dpv, "organisational-measures-classes") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:AcademicResearch</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#AcademicResearch">https://w3id.org/dpv#AcademicResearch</seealso>
    let AcademicResearch = Prefixed_Name(w3dpv, "AcademicResearch") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Purpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Purpose">https://w3id.org/dpv#Purpose</seealso>
    let Purpose = Prefixed_Name(w3dpv, "Purpose") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:purposes-classes</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#purposes-classes">https://w3id.org/dpv#purposes-classes</seealso>
    let purposes_classes = Prefixed_Name(w3dpv, "purposes-classes") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:AcademicScientificOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#AcademicScientificOrganisation">https://w3id.org/dpv#AcademicScientificOrganisation</seealso>
    let AcademicScientificOrganisation =
        Prefixed_Name(w3dpv, "AcademicScientificOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Organisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Organisation">https://w3id.org/dpv#Organisation</seealso>
    let Organisation = Prefixed_Name(w3dpv, "Organisation") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:AcceptContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#AcceptContract">https://w3id.org/dpv#AcceptContract</seealso>
    let AcceptContract = Prefixed_Name(w3dpv, "AcceptContract") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ContractControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractControl">https://w3id.org/dpv#ContractControl</seealso>
    let ContractControl = Prefixed_Name(w3dpv, "ContractControl") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:AcceptableRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Rule</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#AcceptableRule">https://w3id.org/dpv#AcceptableRule</seealso>
    let AcceptableRule = Prefixed_Name(w3dpv, "AcceptableRule") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:AcceptableUsePolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#AcceptableUsePolicy">https://w3id.org/dpv#AcceptableUsePolicy</seealso>
    let AcceptableUsePolicy =
        Prefixed_Name(w3dpv, "AcceptableUsePolicy") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Collect</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Processing</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Collect">https://w3id.org/dpv#Collect</seealso>
    let Collect = Prefixed_Name(w3dpv, "Collect") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:CollectedPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CollectedPersonalData">https://w3id.org/dpv#CollectedPersonalData</seealso>
    let CollectedPersonalData =
        Prefixed_Name(w3dpv, "CollectedPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractPartiallyFulfilled</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#ContractFulfilmentStatus</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractPartiallyFulfilled">https://w3id.org/dpv#ContractPartiallyFulfilled</seealso>
    let ContractPartiallyFulfilled =
        Prefixed_Name(w3dpv, "ContractPartiallyFulfilled") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractPartiallySigned</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#ContractExecutionStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractPartiallySigned">https://w3id.org/dpv#ContractPartiallySigned</seealso>
    let ContractPartiallySigned =
        Prefixed_Name(w3dpv, "ContractPartiallySigned") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractPreamble</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#ContractualClause</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractPreamble">https://w3id.org/dpv#ContractPreamble</seealso>
    let ContractPreamble = Prefixed_Name(w3dpv, "ContractPreamble") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ContractRejected</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#ContractPreparationStatus</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractRejected">https://w3id.org/dpv#ContractRejected</seealso>
    let ContractRejected = Prefixed_Name(w3dpv, "ContractRejected") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractSignedByParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#ContractExecutionStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractSignedByParty">https://w3id.org/dpv#ContractSignedByParty</seealso>
    let ContractSignedByParty =
        Prefixed_Name(w3dpv, "ContractSignedByParty") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RuleUnfulfilled</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#RuleFulfilmentStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RuleUnfulfilled">https://w3id.org/dpv#RuleUnfulfilled</seealso>
    let RuleUnfulfilled = Prefixed_Name(w3dpv, "RuleUnfulfilled") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:DeviceNotice</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DeviceNotice">https://w3id.org/dpv#DeviceNotice</seealso>
    let DeviceNotice = Prefixed_Name(w3dpv, "DeviceNotice") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:FulfilmentOfContractualObligation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#FulfilmentOfContractualObligation">https://w3id.org/dpv#FulfilmentOfContractualObligation</seealso>
    let FulfilmentOfContractualObligation =
        Prefixed_Name(w3dpv, "FulfilmentOfContractualObligation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:FulfilmentOfObligation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#FulfilmentOfObligation">https://w3id.org/dpv#FulfilmentOfObligation</seealso>
    let FulfilmentOfObligation =
        Prefixed_Name(w3dpv, "FulfilmentOfObligation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:FullAutomation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#AutomationLevel</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#FullAutomation">https://w3id.org/dpv#FullAutomation</seealso>
    let FullAutomation = Prefixed_Name(w3dpv, "FullAutomation") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:G2BContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#LegalBasis</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#G2BContract">https://w3id.org/dpv#G2BContract</seealso>
    let G2BContract = Prefixed_Name(w3dpv, "G2BContract") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:G2CContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#LegalBasis</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#G2CContract">https://w3id.org/dpv#G2CContract</seealso>
    let G2CContract = Prefixed_Name(w3dpv, "G2CContract") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:G2GContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#LegalBasis</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#G2GContract">https://w3id.org/dpv#G2GContract</seealso>
    let G2GContract = Prefixed_Name(w3dpv, "G2GContract") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:GeneratedData</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#GeneratedData">https://w3id.org/dpv#GeneratedData</seealso>
    let GeneratedData = Prefixed_Name(w3dpv, "GeneratedData") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:GeneratedPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#GeneratedPersonalData">https://w3id.org/dpv#GeneratedPersonalData</seealso>
    let GeneratedPersonalData =
        Prefixed_Name(w3dpv, "GeneratedPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:GeographicCoverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#GeographicCoverage">https://w3id.org/dpv#GeographicCoverage</seealso>
    let GeographicCoverage = Prefixed_Name(w3dpv, "GeographicCoverage") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:GlobalScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#GeographicCoverage</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#GlobalScale">https://w3id.org/dpv#GlobalScale</seealso>
    let GlobalScale = Prefixed_Name(w3dpv, "GlobalScale") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:GraphicalNotice</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#GraphicalNotice">https://w3id.org/dpv#GraphicalNotice</seealso>
    let GraphicalNotice = Prefixed_Name(w3dpv, "GraphicalNotice") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:GuardianOfDataSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#HumanSubject</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#GuardianOfDataSubject">https://w3id.org/dpv#GuardianOfDataSubject</seealso>
    let GuardianOfDataSubject =
        Prefixed_Name(w3dpv, "GuardianOfDataSubject") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:GuardianOfHuman</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#HumanSubject</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#GuardianOfHuman">https://w3id.org/dpv#GuardianOfHuman</seealso>
    let GuardianOfHuman = Prefixed_Name(w3dpv, "GuardianOfHuman") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:LegitimateInterestAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#LegitimateInterestAssessment">https://w3id.org/dpv#LegitimateInterestAssessment</seealso>
    let LegitimateInterestAssessment =
        Prefixed_Name(w3dpv, "LegitimateInterestAssessment") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:LegitimateInterestInformed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#LegitimateInterestStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#LegitimateInterestInformed">https://w3id.org/dpv#LegitimateInterestInformed</seealso>
    let LegitimateInterestInformed =
        Prefixed_Name(w3dpv, "LegitimateInterestInformed") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:OptimisationForConsumer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#OptimisationForConsumer">https://w3id.org/dpv#OptimisationForConsumer</seealso>
    let OptimisationForConsumer =
        Prefixed_Name(w3dpv, "OptimisationForConsumer") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ServiceOptimisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ServiceOptimisation">https://w3id.org/dpv#ServiceOptimisation</seealso>
    let ServiceOptimisation =
        Prefixed_Name(w3dpv, "ServiceOptimisation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PublicSectorBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PublicSectorBody">https://w3id.org/dpv#PublicSectorBody</seealso>
    let PublicSectorBody = Prefixed_Name(w3dpv, "PublicSectorBody") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:PubliclyOwnedSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Location</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PubliclyOwnedSpace">https://w3id.org/dpv#PubliclyOwnedSpace</seealso>
    let PubliclyOwnedSpace = Prefixed_Name(w3dpv, "PubliclyOwnedSpace") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:QuantumCryptography</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#QuantumCryptography">https://w3id.org/dpv#QuantumCryptography</seealso>
    let QuantumCryptography =
        Prefixed_Name(w3dpv, "QuantumCryptography") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RNGPseudonymisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RNGPseudonymisation">https://w3id.org/dpv#RNGPseudonymisation</seealso>
    let RNGPseudonymisation =
        Prefixed_Name(w3dpv, "RNGPseudonymisation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ROPA</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ROPA">https://w3id.org/dpv#ROPA</seealso>
    let ROPA = Prefixed_Name(w3dpv, "ROPA") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:RandomLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#LocationFixture</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RandomLocation">https://w3id.org/dpv#RandomLocation</seealso>
    let RandomLocation = Prefixed_Name(w3dpv, "RandomLocation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RecertificationPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RecertificationPolicy">https://w3id.org/dpv#RecertificationPolicy</seealso>
    let RecertificationPolicy =
        Prefixed_Name(w3dpv, "RecertificationPolicy") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SymmetricCryptography</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SymmetricCryptography">https://w3id.org/dpv#SymmetricCryptography</seealso>
    let SymmetricCryptography =
        Prefixed_Name(w3dpv, "SymmetricCryptography") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SymmetricEncryption</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SymmetricEncryption">https://w3id.org/dpv#SymmetricEncryption</seealso>
    let SymmetricEncryption =
        Prefixed_Name(w3dpv, "SymmetricEncryption") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SyntheticData</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SyntheticData">https://w3id.org/dpv#SyntheticData</seealso>
    let SyntheticData = Prefixed_Name(w3dpv, "SyntheticData") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SystematicMonitoring</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#ProcessingContext</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SystematicMonitoring">https://w3id.org/dpv#SystematicMonitoring</seealso>
    let SystematicMonitoring =
        Prefixed_Name(w3dpv, "SystematicMonitoring") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:TOM-properties</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#TOM-properties">https://w3id.org/dpv#TOM-properties</seealso>
    let TOM_properties = Prefixed_Name(w3dpv, "TOM-properties") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:rules-properties</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#rules-properties">https://w3id.org/dpv#rules-properties</seealso>
    let rules_properties = Prefixed_Name(w3dpv, "rules-properties") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasDuration">https://w3id.org/dpv#hasDuration</seealso>
    let hasDuration = Prefixed_Name(w3dpv, "hasDuration") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasEntityControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasEntityControl">https://w3id.org/dpv#hasEntityControl</seealso>
    let hasEntityControl = Prefixed_Name(w3dpv, "hasEntityControl") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:EntityControl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dpv#EntityControl">https://w3id.org/dpv#EntityControl</seealso>
    let EntityControl = Prefixed_Name(w3dpv, "EntityControl") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasTechnicalOrganisationalMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasTechnicalOrganisationalMeasure">https://w3id.org/dpv#hasTechnicalOrganisationalMeasure</seealso>
    let hasTechnicalOrganisationalMeasure =
        Prefixed_Name(w3dpv, "hasTechnicalOrganisationalMeasure") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasEntityInvolvement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasEntityInvolvement">https://w3id.org/dpv#hasEntityInvolvement</seealso>
    let hasEntityInvolvement =
        Prefixed_Name(w3dpv, "hasEntityInvolvement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasFrequency">https://w3id.org/dpv#hasFrequency</seealso>
    let hasFrequency = Prefixed_Name(w3dpv, "hasFrequency") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasFulfilmentStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasFulfilmentStatus">https://w3id.org/dpv#hasFulfilmentStatus</seealso>
    let hasFulfilmentStatus =
        Prefixed_Name(w3dpv, "hasFulfilmentStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasGeographicCoverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasGeographicCoverage">https://w3id.org/dpv#hasGeographicCoverage</seealso>
    let hasGeographicCoverage =
        Prefixed_Name(w3dpv, "hasGeographicCoverage") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasHumanInvolvement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasHumanInvolvement">https://w3id.org/dpv#hasHumanInvolvement</seealso>
    let hasHumanInvolvement =
        Prefixed_Name(w3dpv, "hasHumanInvolvement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ResearchAndDevelopment</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ResearchAndDevelopment">https://w3id.org/dpv#ResearchAndDevelopment</seealso>
    let ResearchAndDevelopment =
        Prefixed_Name(w3dpv, "ResearchAndDevelopment") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:entities-organisation-classes</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#entities-organisation-classes">https://w3id.org/dpv#entities-organisation-classes</seealso>
    let entities_organisation_classes =
        Prefixed_Name(w3dpv, "entities-organisation-classes") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Rule</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Rule">https://w3id.org/dpv#Rule</seealso>
    let Rule = Prefixed_Name(w3dpv, "Rule") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Policy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Policy">https://w3id.org/dpv#Policy</seealso>
    let Policy = Prefixed_Name(w3dpv, "Policy") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Processing</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Processing">https://w3id.org/dpv#Processing</seealso>
    let Processing = Prefixed_Name(w3dpv, "Processing") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:processing-classes</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#processing-classes">https://w3id.org/dpv#processing-classes</seealso>
    let processing_classes = Prefixed_Name(w3dpv, "processing-classes") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:TechnicalMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#TechnicalMeasure">https://w3id.org/dpv#TechnicalMeasure</seealso>
    let TechnicalMeasure = Prefixed_Name(w3dpv, "TechnicalMeasure") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Acquire</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Processing</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Acquire">https://w3id.org/dpv#Acquire</seealso>
    let Acquire = Prefixed_Name(w3dpv, "Acquire") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ActiveRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Right</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ActiveRight">https://w3id.org/dpv#ActiveRight</seealso>
    let ActiveRight = Prefixed_Name(w3dpv, "ActiveRight") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Right</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Right">https://w3id.org/dpv#Right</seealso>
    let Right = Prefixed_Name(w3dpv, "Right") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:status-classes</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#status-classes">https://w3id.org/dpv#status-classes</seealso>
    let status_classes = Prefixed_Name(w3dpv, "status-classes") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ActivityCompleted</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#ActivityStatus</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ActivityCompleted">https://w3id.org/dpv#ActivityCompleted</seealso>
    let ActivityCompleted = Prefixed_Name(w3dpv, "ActivityCompleted") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ActivityNotCompleted</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#ActivityStatus</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ActivityNotCompleted">https://w3id.org/dpv#ActivityNotCompleted</seealso>
    let ActivityNotCompleted =
        Prefixed_Name(w3dpv, "ActivityNotCompleted") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ActivityPlanned</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#ActivityStatus</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ActivityPlanned">https://w3id.org/dpv#ActivityPlanned</seealso>
    let ActivityPlanned = Prefixed_Name(w3dpv, "ActivityPlanned") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Status</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Status">https://w3id.org/dpv#Status</seealso>
    let Status = Prefixed_Name(w3dpv, "Status") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Adult</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#HumanSubject</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Adult">https://w3id.org/dpv#Adult</seealso>
    let Adult = Prefixed_Name(w3dpv, "Adult") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Advertising</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Advertising">https://w3id.org/dpv#Advertising</seealso>
    let Advertising = Prefixed_Name(w3dpv, "Advertising") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Marketing</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Marketing">https://w3id.org/dpv#Marketing</seealso>
    let Marketing = Prefixed_Name(w3dpv, "Marketing") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:AgeVerification</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#AgeVerification">https://w3id.org/dpv#AgeVerification</seealso>
    let AgeVerification = Prefixed_Name(w3dpv, "AgeVerification") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Verification</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Verification">https://w3id.org/dpv#Verification</seealso>
    let Verification = Prefixed_Name(w3dpv, "Verification") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ProcessingContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ProcessingContext">https://w3id.org/dpv#ProcessingContext</seealso>
    let ProcessingContext = Prefixed_Name(w3dpv, "ProcessingContext") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:processing-context-classes</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#processing-context-classes">https://w3id.org/dpv#processing-context-classes</seealso>
    let processing_context_classes =
        Prefixed_Name(w3dpv, "processing-context-classes") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Align</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Processing</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Align">https://w3id.org/dpv#Align</seealso>
    let Align = Prefixed_Name(w3dpv, "Align") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Anonymisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Anonymisation">https://w3id.org/dpv#Anonymisation</seealso>
    let Anonymisation = Prefixed_Name(w3dpv, "Anonymisation") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Deidentification</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Deidentification">https://w3id.org/dpv#Deidentification</seealso>
    let Deidentification = Prefixed_Name(w3dpv, "Deidentification") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Anonymise</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Processing</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Anonymise">https://w3id.org/dpv#Anonymise</seealso>
    let Anonymise = Prefixed_Name(w3dpv, "Anonymise") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:AnonymisedData</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#AnonymisedData">https://w3id.org/dpv#AnonymisedData</seealso>
    let AnonymisedData = Prefixed_Name(w3dpv, "AnonymisedData") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:NonPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#NonPersonalData">https://w3id.org/dpv#NonPersonalData</seealso>
    let NonPersonalData = Prefixed_Name(w3dpv, "NonPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:personal-data-classes</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#personal-data-classes">https://w3id.org/dpv#personal-data-classes</seealso>
    let personal_data_classes =
        Prefixed_Name(w3dpv, "personal-data-classes") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Applicability</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Applicability">https://w3id.org/dpv#Applicability</seealso>
    let Applicability = Prefixed_Name(w3dpv, "Applicability") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Applicant</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#HumanSubject</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Applicant">https://w3id.org/dpv#Applicant</seealso>
    let Applicant = Prefixed_Name(w3dpv, "Applicant") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ApprovalProcedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ApprovalProcedure">https://w3id.org/dpv#ApprovalProcedure</seealso>
    let ApprovalProcedure = Prefixed_Name(w3dpv, "ApprovalProcedure") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:GovernanceProcedures</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#GovernanceProcedures">https://w3id.org/dpv#GovernanceProcedures</seealso>
    let GovernanceProcedures =
        Prefixed_Name(w3dpv, "GovernanceProcedures") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Assess</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Processing</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Assess">https://w3id.org/dpv#Assess</seealso>
    let Assess = Prefixed_Name(w3dpv, "Assess") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Assessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Assessment">https://w3id.org/dpv#Assessment</seealso>
    let Assessment = Prefixed_Name(w3dpv, "Assessment") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:AssetManagementProcedures</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#AssetManagementProcedures">https://w3id.org/dpv#AssetManagementProcedures</seealso>
    let AssetManagementProcedures =
        Prefixed_Name(w3dpv, "AssetManagementProcedures") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:AssistiveAutomation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#AutomationLevel</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#AssistiveAutomation">https://w3id.org/dpv#AssistiveAutomation</seealso>
    let AssistiveAutomation =
        Prefixed_Name(w3dpv, "AssistiveAutomation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:AutomationLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#AutomationLevel">https://w3id.org/dpv#AutomationLevel</seealso>
    let AutomationLevel = Prefixed_Name(w3dpv, "AutomationLevel") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:AsylumSeeker</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#HumanSubject</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#AsylumSeeker">https://w3id.org/dpv#AsylumSeeker</seealso>
    let AsylumSeeker = Prefixed_Name(w3dpv, "AsylumSeeker") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:VulnerableHuman</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#HumanSubject</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#VulnerableHuman">https://w3id.org/dpv#VulnerableHuman</seealso>
    let VulnerableHuman = Prefixed_Name(w3dpv, "VulnerableHuman") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:AsymmetricEncryption</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#AsymmetricEncryption">https://w3id.org/dpv#AsymmetricEncryption</seealso>
    let AsymmetricEncryption =
        Prefixed_Name(w3dpv, "AsymmetricEncryption") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Encryption</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Encryption">https://w3id.org/dpv#Encryption</seealso>
    let Encryption = Prefixed_Name(w3dpv, "Encryption") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Audit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Audit">https://w3id.org/dpv#Audit</seealso>
    let Audit = Prefixed_Name(w3dpv, "Audit") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:AuditConditionallyApproved</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#AuditStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#AuditConditionallyApproved">https://w3id.org/dpv#AuditConditionallyApproved</seealso>
    let AuditConditionallyApproved =
        Prefixed_Name(w3dpv, "AuditConditionallyApproved") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:AuditNotRequired</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#AuditStatus</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#AuditNotRequired">https://w3id.org/dpv#AuditNotRequired</seealso>
    let AuditNotRequired = Prefixed_Name(w3dpv, "AuditNotRequired") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:AuditRejected</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#AuditStatus</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#AuditRejected">https://w3id.org/dpv#AuditRejected</seealso>
    let AuditRejected = Prefixed_Name(w3dpv, "AuditRejected") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:AuditRequested</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#AuditStatus</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#AuditRequested">https://w3id.org/dpv#AuditRequested</seealso>
    let AuditRequested = Prefixed_Name(w3dpv, "AuditRequested") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:AuditRequired</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#AuditStatus</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#AuditRequired">https://w3id.org/dpv#AuditRequired</seealso>
    let AuditRequired = Prefixed_Name(w3dpv, "AuditRequired") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Authentication-ABC</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Authentication-ABC">https://w3id.org/dpv#Authentication-ABC</seealso>
    let Authentication_ABC = Prefixed_Name(w3dpv, "Authentication-ABC") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:CryptographicAuthentication</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CryptographicAuthentication">https://w3id.org/dpv#CryptographicAuthentication</seealso>
    let CryptographicAuthentication =
        Prefixed_Name(w3dpv, "CryptographicAuthentication") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Authentication-PABC</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Authentication-PABC">https://w3id.org/dpv#Authentication-PABC</seealso>
    let Authentication_PABC =
        Prefixed_Name(w3dpv, "Authentication-PABC") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:AuthenticationProtocols</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#AuthenticationProtocols">https://w3id.org/dpv#AuthenticationProtocols</seealso>
    let AuthenticationProtocols =
        Prefixed_Name(w3dpv, "AuthenticationProtocols") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:AuthorisationProcedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#AuthorisationProcedure">https://w3id.org/dpv#AuthorisationProcedure</seealso>
    let AuthorisationProcedure =
        Prefixed_Name(w3dpv, "AuthorisationProcedure") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:AuthorisationProtocols</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#AuthorisationProtocols">https://w3id.org/dpv#AuthorisationProtocols</seealso>
    let AuthorisationProtocols =
        Prefixed_Name(w3dpv, "AuthorisationProtocols") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Authority</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Authority">https://w3id.org/dpv#Authority</seealso>
    let Authority = Prefixed_Name(w3dpv, "Authority") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:GovernmentalOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#GovernmentalOrganisation">https://w3id.org/dpv#GovernmentalOrganisation</seealso>
    let GovernmentalOrganisation =
        Prefixed_Name(w3dpv, "GovernmentalOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:entities-authority-classes</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#entities-authority-classes">https://w3id.org/dpv#entities-authority-classes</seealso>
    let entities_authority_classes =
        Prefixed_Name(w3dpv, "entities-authority-classes") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:AuthorityInformed</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#EntityInformedStatus</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#AuthorityInformed">https://w3id.org/dpv#AuthorityInformed</seealso>
    let AuthorityInformed = Prefixed_Name(w3dpv, "AuthorityInformed") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:EntityInformedStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#EntityInformedStatus">https://w3id.org/dpv#EntityInformedStatus</seealso>
    let EntityInformedStatus =
        Prefixed_Name(w3dpv, "EntityInformedStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:EntityInformed</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#EntityInformedStatus</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#EntityInformed">https://w3id.org/dpv#EntityInformed</seealso>
    let EntityInformed = Prefixed_Name(w3dpv, "EntityInformed") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:AuthorityUninformed</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#EntityInformedStatus</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#AuthorityUninformed">https://w3id.org/dpv#AuthorityUninformed</seealso>
    let AuthorityUninformed =
        Prefixed_Name(w3dpv, "AuthorityUninformed") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:AutomatedDecisionMaking</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#AutomatedDecisionMaking">https://w3id.org/dpv#AutomatedDecisionMaking</seealso>
    let AutomatedDecisionMaking =
        Prefixed_Name(w3dpv, "AutomatedDecisionMaking") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DecisionMaking</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DecisionMaking">https://w3id.org/dpv#DecisionMaking</seealso>
    let DecisionMaking = Prefixed_Name(w3dpv, "DecisionMaking") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:AutomatedScoringOfIndividuals</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#ScoringOfIndividuals</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#AutomatedScoringOfIndividuals">https://w3id.org/dpv#AutomatedScoringOfIndividuals</seealso>
    let AutomatedScoringOfIndividuals =
        Prefixed_Name(w3dpv, "AutomatedScoringOfIndividuals") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ScoringOfIndividuals</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#EvaluationScoring</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ScoringOfIndividuals">https://w3id.org/dpv#ScoringOfIndividuals</seealso>
    let ScoringOfIndividuals =
        Prefixed_Name(w3dpv, "ScoringOfIndividuals") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:B2B2CContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#LegalBasis</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#B2B2CContract">https://w3id.org/dpv#B2B2CContract</seealso>
    let B2B2CContract = Prefixed_Name(w3dpv, "B2B2CContract") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:LegalBasis</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#LegalBasis">https://w3id.org/dpv#LegalBasis</seealso>
    let LegalBasis = Prefixed_Name(w3dpv, "LegalBasis") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:B2CContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#LegalBasis</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#B2CContract">https://w3id.org/dpv#B2CContract</seealso>
    let B2CContract = Prefixed_Name(w3dpv, "B2CContract") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:B2BContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#LegalBasis</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#B2BContract">https://w3id.org/dpv#B2BContract</seealso>
    let B2BContract = Prefixed_Name(w3dpv, "B2BContract") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:contract-types-classes</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#contract-types-classes">https://w3id.org/dpv#contract-types-classes</seealso>
    let contract_types_classes =
        Prefixed_Name(w3dpv, "contract-types-classes") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractByEntityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#LegalBasis</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractByEntityType">https://w3id.org/dpv#ContractByEntityType</seealso>
    let ContractByEntityType =
        Prefixed_Name(w3dpv, "ContractByEntityType") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:BackgroundChecks</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#BackgroundChecks">https://w3id.org/dpv#BackgroundChecks</seealso>
    let BackgroundChecks = Prefixed_Name(w3dpv, "BackgroundChecks") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:C2BContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#LegalBasis</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#C2BContract">https://w3id.org/dpv#C2BContract</seealso>
    let C2BContract = Prefixed_Name(w3dpv, "C2BContract") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:C2CContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#LegalBasis</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#C2CContract">https://w3id.org/dpv#C2CContract</seealso>
    let C2CContract = Prefixed_Name(w3dpv, "C2CContract") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:CannotChallengeProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#EntityNonPermissiveInvolvement</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CannotChallengeProcess">https://w3id.org/dpv#CannotChallengeProcess</seealso>
    let CannotChallengeProcess =
        Prefixed_Name(w3dpv, "CannotChallengeProcess") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:EntityNonPermissiveInvolvement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#EntityNonPermissiveInvolvement">https://w3id.org/dpv#EntityNonPermissiveInvolvement</seealso>
    let EntityNonPermissiveInvolvement =
        Prefixed_Name(w3dpv, "EntityNonPermissiveInvolvement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:CannotChallengeProcessInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#EntityNonPermissiveInvolvement</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CannotChallengeProcessInput">https://w3id.org/dpv#CannotChallengeProcessInput</seealso>
    let CannotChallengeProcessInput =
        Prefixed_Name(w3dpv, "CannotChallengeProcessInput") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:CannotChallengeProcessOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#EntityNonPermissiveInvolvement</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CannotChallengeProcessOutput">https://w3id.org/dpv#CannotChallengeProcessOutput</seealso>
    let CannotChallengeProcessOutput =
        Prefixed_Name(w3dpv, "CannotChallengeProcessOutput") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:CannotCorrectProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#EntityNonPermissiveInvolvement</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CannotCorrectProcess">https://w3id.org/dpv#CannotCorrectProcess</seealso>
    let CannotCorrectProcess =
        Prefixed_Name(w3dpv, "CannotCorrectProcess") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:CannotCorrectProcessInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#EntityNonPermissiveInvolvement</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CannotCorrectProcessInput">https://w3id.org/dpv#CannotCorrectProcessInput</seealso>
    let CannotCorrectProcessInput =
        Prefixed_Name(w3dpv, "CannotCorrectProcessInput") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:CannotCorrectProcessOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#EntityNonPermissiveInvolvement</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CannotCorrectProcessOutput">https://w3id.org/dpv#CannotCorrectProcessOutput</seealso>
    let CannotCorrectProcessOutput =
        Prefixed_Name(w3dpv, "CannotCorrectProcessOutput") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:CannotObjectToProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#EntityNonPermissiveInvolvement</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CannotObjectToProcess">https://w3id.org/dpv#CannotObjectToProcess</seealso>
    let CannotObjectToProcess =
        Prefixed_Name(w3dpv, "CannotObjectToProcess") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:CannotOptOutFromProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#EntityNonPermissiveInvolvement</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CannotOptOutFromProcess">https://w3id.org/dpv#CannotOptOutFromProcess</seealso>
    let CannotOptOutFromProcess =
        Prefixed_Name(w3dpv, "CannotOptOutFromProcess") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:CannotReverseProcessEffects</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#EntityNonPermissiveInvolvement</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CannotReverseProcessEffects">https://w3id.org/dpv#CannotReverseProcessEffects</seealso>
    let CannotReverseProcessEffects =
        Prefixed_Name(w3dpv, "CannotReverseProcessEffects") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:CannotReverseProcessInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#EntityNonPermissiveInvolvement</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CannotReverseProcessInput">https://w3id.org/dpv#CannotReverseProcessInput</seealso>
    let CannotReverseProcessInput =
        Prefixed_Name(w3dpv, "CannotReverseProcessInput") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:CannotReverseProcessOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#EntityNonPermissiveInvolvement</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CannotReverseProcessOutput">https://w3id.org/dpv#CannotReverseProcessOutput</seealso>
    let CannotReverseProcessOutput =
        Prefixed_Name(w3dpv, "CannotReverseProcessOutput") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Certification</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Certification">https://w3id.org/dpv#Certification</seealso>
    let Certification = Prefixed_Name(w3dpv, "Certification") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:CertificationSeal</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CertificationSeal">https://w3id.org/dpv#CertificationSeal</seealso>
    let CertificationSeal = Prefixed_Name(w3dpv, "CertificationSeal") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ChallengingProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#EntityPermissiveInvolvement</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ChallengingProcess">https://w3id.org/dpv#ChallengingProcess</seealso>
    let ChallengingProcess = Prefixed_Name(w3dpv, "ChallengingProcess") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:EntityPermissiveInvolvement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#EntityPermissiveInvolvement">https://w3id.org/dpv#EntityPermissiveInvolvement</seealso>
    let EntityPermissiveInvolvement =
        Prefixed_Name(w3dpv, "EntityPermissiveInvolvement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ChallengingProcessInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#EntityPermissiveInvolvement</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ChallengingProcessInput">https://w3id.org/dpv#ChallengingProcessInput</seealso>
    let ChallengingProcessInput =
        Prefixed_Name(w3dpv, "ChallengingProcessInput") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ChallengingProcessOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#EntityPermissiveInvolvement</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ChallengingProcessOutput">https://w3id.org/dpv#ChallengingProcessOutput</seealso>
    let ChallengingProcessOutput =
        Prefixed_Name(w3dpv, "ChallengingProcessOutput") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:CharityOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CharityOrganisation">https://w3id.org/dpv#CharityOrganisation</seealso>
    let CharityOrganisation =
        Prefixed_Name(w3dpv, "CharityOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:LegalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#LegalEntity">https://w3id.org/dpv#LegalEntity</seealso>
    let LegalEntity = Prefixed_Name(w3dpv, "LegalEntity") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Child</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#HumanSubject</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Child">https://w3id.org/dpv#Child</seealso>
    let Child = Prefixed_Name(w3dpv, "Child") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Citizen</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#HumanSubject</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Citizen">https://w3id.org/dpv#Citizen</seealso>
    let Citizen = Prefixed_Name(w3dpv, "Citizen") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:City</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#City">https://w3id.org/dpv#City</seealso>
    let City = Prefixed_Name(w3dpv, "City") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Region</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Region">https://w3id.org/dpv#Region</seealso>
    let Region = Prefixed_Name(w3dpv, "Region") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ContractFulfilled</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#ContractFulfilmentStatus</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractFulfilled">https://w3id.org/dpv#ContractFulfilled</seealso>
    let ContractFulfilled = Prefixed_Name(w3dpv, "ContractFulfilled") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractFulfilmentStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractFulfilmentStatus">https://w3id.org/dpv#ContractFulfilmentStatus</seealso>
    let ContractFulfilmentStatus =
        Prefixed_Name(w3dpv, "ContractFulfilmentStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractFullyExecuted</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#ContractExecutionStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractFullyExecuted">https://w3id.org/dpv#ContractFullyExecuted</seealso>
    let ContractFullyExecuted =
        Prefixed_Name(w3dpv, "ContractFullyExecuted") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractFullySigned</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#ContractExecutionStatus</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractFullySigned">https://w3id.org/dpv#ContractFullySigned</seealso>
    let ContractFullySigned =
        Prefixed_Name(w3dpv, "ContractFullySigned") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractInactive</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#ContractActivationStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractInactive">https://w3id.org/dpv#ContractInactive</seealso>
    let ContractInactive = Prefixed_Name(w3dpv, "ContractInactive") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractJurisdictionClause</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#ContractualClause</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractJurisdictionClause">https://w3id.org/dpv#ContractJurisdictionClause</seealso>
    let ContractJurisdictionClause =
        Prefixed_Name(w3dpv, "ContractJurisdictionClause") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractNegotiated</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#ContractPreparationStatus</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractNegotiated">https://w3id.org/dpv#ContractNegotiated</seealso>
    let ContractNegotiated = Prefixed_Name(w3dpv, "ContractNegotiated") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractNotFulfilled</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#ContractFulfilmentStatus</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractNotFulfilled">https://w3id.org/dpv#ContractNotFulfilled</seealso>
    let ContractNotFulfilled =
        Prefixed_Name(w3dpv, "ContractNotFulfilled") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractOffered</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#ContractPreparationStatus</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractOffered">https://w3id.org/dpv#ContractOffered</seealso>
    let ContractOffered = Prefixed_Name(w3dpv, "ContractOffered") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataTransferLegalBasis</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#LegalBasis</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataTransferLegalBasis">https://w3id.org/dpv#DataTransferLegalBasis</seealso>
    let DataTransferLegalBasis =
        Prefixed_Name(w3dpv, "DataTransferLegalBasis") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataTransferNotice</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataTransferNotice">https://w3id.org/dpv#DataTransferNotice</seealso>
    let DataTransferNotice = Prefixed_Name(w3dpv, "DataTransferNotice") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:DataTransferRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataTransferRecord">https://w3id.org/dpv#DataTransferRecord</seealso>
    let DataTransferRecord = Prefixed_Name(w3dpv, "DataTransferRecord") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:DataVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataVolume">https://w3id.org/dpv#DataVolume</seealso>
    let DataVolume = Prefixed_Name(w3dpv, "DataVolume") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DecentralisedLocations</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#LocationFixture</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DecentralisedLocations">https://w3id.org/dpv#DecentralisedLocations</seealso>
    let DecentralisedLocations =
        Prefixed_Name(w3dpv, "DecentralisedLocations") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:LocationFixture</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#LocationFixture">https://w3id.org/dpv#LocationFixture</seealso>
    let LocationFixture = Prefixed_Name(w3dpv, "LocationFixture") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Delete</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Processing</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Delete">https://w3id.org/dpv#Delete</seealso>
    let Delete = Prefixed_Name(w3dpv, "Delete") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Remove</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Processing</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Remove">https://w3id.org/dpv#Remove</seealso>
    let Remove = Prefixed_Name(w3dpv, "Remove") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:DeliveryOfGoods</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DeliveryOfGoods">https://w3id.org/dpv#DeliveryOfGoods</seealso>
    let DeliveryOfGoods = Prefixed_Name(w3dpv, "DeliveryOfGoods") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RequestedServiceProvision</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RequestedServiceProvision">https://w3id.org/dpv#RequestedServiceProvision</seealso>
    let RequestedServiceProvision =
        Prefixed_Name(w3dpv, "RequestedServiceProvision") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DerivedPersonalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DerivedPersonalData">https://w3id.org/dpv#DerivedPersonalData</seealso>
    let DerivedPersonalData =
        Prefixed_Name(w3dpv, "DerivedPersonalData") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DesignStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DesignStandard">https://w3id.org/dpv#DesignStandard</seealso>
    let DesignStandard = Prefixed_Name(w3dpv, "DesignStandard") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Standard</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Standard">https://w3id.org/dpv#Standard</seealso>
    let Standard = Prefixed_Name(w3dpv, "Standard") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Destruct</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Processing</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Destruct">https://w3id.org/dpv#Destruct</seealso>
    let Destruct = Prefixed_Name(w3dpv, "Destruct") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DeterministicPseudonymisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DeterministicPseudonymisation">https://w3id.org/dpv#DeterministicPseudonymisation</seealso>
    let DeterministicPseudonymisation =
        Prefixed_Name(w3dpv, "DeterministicPseudonymisation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Pseudonymisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Pseudonymisation">https://w3id.org/dpv#Pseudonymisation</seealso>
    let Pseudonymisation = Prefixed_Name(w3dpv, "Pseudonymisation") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Deterrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Rule</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Deterrence">https://w3id.org/dpv#Deterrence</seealso>
    let Deterrence = Prefixed_Name(w3dpv, "Deterrence") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:UnacceptableRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Rule</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#UnacceptableRule">https://w3id.org/dpv#UnacceptableRule</seealso>
    let UnacceptableRule = Prefixed_Name(w3dpv, "UnacceptableRule") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:DeterrenceFollowed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#RuleFulfilmentStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DeterrenceFollowed">https://w3id.org/dpv#DeterrenceFollowed</seealso>
    let DeterrenceFollowed = Prefixed_Name(w3dpv, "DeterrenceFollowed") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RuleFulfilmentStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RuleFulfilmentStatus">https://w3id.org/dpv#RuleFulfilmentStatus</seealso>
    let RuleFulfilmentStatus =
        Prefixed_Name(w3dpv, "RuleFulfilmentStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RuleFulfilled</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#RuleFulfilmentStatus</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RuleFulfilled">https://w3id.org/dpv#RuleFulfilled</seealso>
    let RuleFulfilled = Prefixed_Name(w3dpv, "RuleFulfilled") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DeterrenceNotFollowed</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#RuleFulfilmentStatus</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DeterrenceNotFollowed">https://w3id.org/dpv#DeterrenceNotFollowed</seealso>
    let DeterrenceNotFollowed =
        Prefixed_Name(w3dpv, "DeterrenceNotFollowed") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DigitalRightsManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DigitalRightsManagement">https://w3id.org/dpv#DigitalRightsManagement</seealso>
    let DigitalRightsManagement =
        Prefixed_Name(w3dpv, "DigitalRightsManagement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DigitalSignatures</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DigitalSignatures">https://w3id.org/dpv#DigitalSignatures</seealso>
    let DigitalSignatures = Prefixed_Name(w3dpv, "DigitalSignatures") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:DirectMarketing</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DirectMarketing">https://w3id.org/dpv#DirectMarketing</seealso>
    let DirectMarketing = Prefixed_Name(w3dpv, "DirectMarketing") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DisasterRecoveryProcedures</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DisasterRecoveryProcedures">https://w3id.org/dpv#DisasterRecoveryProcedures</seealso>
    let DisasterRecoveryProcedures =
        Prefixed_Name(w3dpv, "DisasterRecoveryProcedures") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Disclose</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Processing</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Disclose">https://w3id.org/dpv#Disclose</seealso>
    let Disclose = Prefixed_Name(w3dpv, "Disclose") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DiscloseByTransmission</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Processing</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DiscloseByTransmission">https://w3id.org/dpv#DiscloseByTransmission</seealso>
    let DiscloseByTransmission =
        Prefixed_Name(w3dpv, "DiscloseByTransmission") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Display</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Processing</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Display">https://w3id.org/dpv#Display</seealso>
    let Display = Prefixed_Name(w3dpv, "Display") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:DisputeManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DisputeManagement">https://w3id.org/dpv#DisputeManagement</seealso>
    let DisputeManagement = Prefixed_Name(w3dpv, "DisputeManagement") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Disseminate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Processing</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Disseminate">https://w3id.org/dpv#Disseminate</seealso>
    let Disseminate = Prefixed_Name(w3dpv, "Disseminate") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DistributedSystemSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DistributedSystemSecurity">https://w3id.org/dpv#DistributedSystemSecurity</seealso>
    let DistributedSystemSecurity =
        Prefixed_Name(w3dpv, "DistributedSystemSecurity") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:LegalComplianceAudit</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#LegalComplianceAudit">https://w3id.org/dpv#LegalComplianceAudit</seealso>
    let LegalComplianceAudit =
        Prefixed_Name(w3dpv, "LegalComplianceAudit") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:TechnicalOrganisationalMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#TechnicalOrganisationalMeasure">https://w3id.org/dpv#TechnicalOrganisationalMeasure</seealso>
    let TechnicalOrganisationalMeasure =
        Prefixed_Name(w3dpv, "TechnicalOrganisationalMeasure") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:TOM-classes</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#TOM-classes">https://w3id.org/dpv#TOM-classes</seealso>
    let TOM_classes = Prefixed_Name(w3dpv, "TOM-classes") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:LegalObligation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#LegalBasis</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#LegalObligation">https://w3id.org/dpv#LegalObligation</seealso>
    let LegalObligation = Prefixed_Name(w3dpv, "LegalObligation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:LegalObligationCompleted</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#LegalObligationStatus</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#LegalObligationCompleted">https://w3id.org/dpv#LegalObligationCompleted</seealso>
    let LegalObligationCompleted =
        Prefixed_Name(w3dpv, "LegalObligationCompleted") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:LegalObligationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#LegalObligationStatus">https://w3id.org/dpv#LegalObligationStatus</seealso>
    let LegalObligationStatus =
        Prefixed_Name(w3dpv, "LegalObligationStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:legal-basis-status-classes</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#legal-basis-status-classes">https://w3id.org/dpv#legal-basis-status-classes</seealso>
    let legal_basis_status_classes =
        Prefixed_Name(w3dpv, "legal-basis-status-classes") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:LegalObligationOngoing</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#LegalObligationStatus</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#LegalObligationOngoing">https://w3id.org/dpv#LegalObligationOngoing</seealso>
    let LegalObligationOngoing =
        Prefixed_Name(w3dpv, "LegalObligationOngoing") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:LegalObligationPending</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#LegalObligationStatus</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#LegalObligationPending">https://w3id.org/dpv#LegalObligationPending</seealso>
    let LegalObligationPending =
        Prefixed_Name(w3dpv, "LegalObligationPending") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:LegitimateInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#LegalBasis</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#LegitimateInterest">https://w3id.org/dpv#LegitimateInterest</seealso>
    let LegitimateInterest = Prefixed_Name(w3dpv, "LegitimateInterest") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:LegitimateInterestStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#LegitimateInterestStatus">https://w3id.org/dpv#LegitimateInterestStatus</seealso>
    let LegitimateInterestStatus =
        Prefixed_Name(w3dpv, "LegitimateInterestStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:LegitimateInterestNotObjected</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#LegitimateInterestStatus</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#LegitimateInterestNotObjected">https://w3id.org/dpv#LegitimateInterestNotObjected</seealso>
    let LegitimateInterestNotObjected =
        Prefixed_Name(w3dpv, "LegitimateInterestNotObjected") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:LegitimateInterestObjected</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#LegitimateInterestStatus</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#LegitimateInterestObjected">https://w3id.org/dpv#LegitimateInterestObjected</seealso>
    let LegitimateInterestObjected =
        Prefixed_Name(w3dpv, "LegitimateInterestObjected") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:LegitimateInterestOfController</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#LegalBasis</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#LegitimateInterestOfController">https://w3id.org/dpv#LegitimateInterestOfController</seealso>
    let LegitimateInterestOfController =
        Prefixed_Name(w3dpv, "LegitimateInterestOfController") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:LegitimateInterestOfDataSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#LegalBasis</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#LegitimateInterestOfDataSubject">https://w3id.org/dpv#LegitimateInterestOfDataSubject</seealso>
    let LegitimateInterestOfDataSubject =
        Prefixed_Name(w3dpv, "LegitimateInterestOfDataSubject") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:LegitimateInterestOfThirdParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#LegalBasis</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#LegitimateInterestOfThirdParty">https://w3id.org/dpv#LegitimateInterestOfThirdParty</seealso>
    let LegitimateInterestOfThirdParty =
        Prefixed_Name(w3dpv, "LegitimateInterestOfThirdParty") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:LegitimateInterestUninformed</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#LegitimateInterestStatus</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#LegitimateInterestUninformed">https://w3id.org/dpv#LegitimateInterestUninformed</seealso>
    let LegitimateInterestUninformed =
        Prefixed_Name(w3dpv, "LegitimateInterestUninformed") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Likelihood</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Likelihood">https://w3id.org/dpv#Likelihood</seealso>
    let Likelihood = Prefixed_Name(w3dpv, "Likelihood") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:LocalEnvironmentScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#GeographicCoverage</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#LocalEnvironmentScale">https://w3id.org/dpv#LocalEnvironmentScale</seealso>
    let LocalEnvironmentScale =
        Prefixed_Name(w3dpv, "LocalEnvironmentScale") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:OptimiseUserInterface</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#OptimiseUserInterface">https://w3id.org/dpv#OptimiseUserInterface</seealso>
    let OptimiseUserInterface =
        Prefixed_Name(w3dpv, "OptimiseUserInterface") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:OptingInToProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#EntityPermissiveInvolvement</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#OptingInToProcess">https://w3id.org/dpv#OptingInToProcess</seealso>
    let OptingInToProcess = Prefixed_Name(w3dpv, "OptingInToProcess") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:OptingOutFromProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#EntityPermissiveInvolvement</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#OptingOutFromProcess">https://w3id.org/dpv#OptingOutFromProcess</seealso>
    let OptingOutFromProcess =
        Prefixed_Name(w3dpv, "OptingOutFromProcess") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Optional</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Necessity</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Optional">https://w3id.org/dpv#Optional</seealso>
    let Optional = Prefixed_Name(w3dpv, "Optional") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:OralNotice</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#OralNotice">https://w3id.org/dpv#OralNotice</seealso>
    let OralNotice = Prefixed_Name(w3dpv, "OralNotice") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:OrganisationComplianceManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#OrganisationComplianceManagement">https://w3id.org/dpv#OrganisationComplianceManagement</seealso>
    let OrganisationComplianceManagement =
        Prefixed_Name(w3dpv, "OrganisationComplianceManagement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:OrganisationRiskManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#OrganisationRiskManagement">https://w3id.org/dpv#OrganisationRiskManagement</seealso>
    let OrganisationRiskManagement =
        Prefixed_Name(w3dpv, "OrganisationRiskManagement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:OrganisationalUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#OrganisationalUnit">https://w3id.org/dpv#OrganisationalUnit</seealso>
    let OrganisationalUnit = Prefixed_Name(w3dpv, "OrganisationalUnit") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:StartupOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#StartupOrganisation">https://w3id.org/dpv#StartupOrganisation</seealso>
    let StartupOrganisation =
        Prefixed_Name(w3dpv, "StartupOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:StatisticalConfidentialityAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#LegalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#StatisticalConfidentialityAgreement">https://w3id.org/dpv#StatisticalConfidentialityAgreement</seealso>
    let StatisticalConfidentialityAgreement =
        Prefixed_Name(w3dpv, "StatisticalConfidentialityAgreement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:StatisticallyConfidentialData</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#StatisticallyConfidentialData">https://w3id.org/dpv#StatisticallyConfidentialData</seealso>
    let StatisticallyConfidentialData =
        Prefixed_Name(w3dpv, "StatisticallyConfidentialData") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:StorageCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#StorageCondition">https://w3id.org/dpv#StorageCondition</seealso>
    let StorageCondition = Prefixed_Name(w3dpv, "StorageCondition") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:StorageDeletion</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#StorageDeletion">https://w3id.org/dpv#StorageDeletion</seealso>
    let StorageDeletion = Prefixed_Name(w3dpv, "StorageDeletion") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:StorageDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#StorageDuration">https://w3id.org/dpv#StorageDuration</seealso>
    let StorageDuration = Prefixed_Name(w3dpv, "StorageDuration") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:StorageLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#StorageLocation">https://w3id.org/dpv#StorageLocation</seealso>
    let StorageLocation = Prefixed_Name(w3dpv, "StorageLocation") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:StorageRestoration</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#StorageRestoration">https://w3id.org/dpv#StorageRestoration</seealso>
    let StorageRestoration = Prefixed_Name(w3dpv, "StorageRestoration") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Store</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Processing</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Store">https://w3id.org/dpv#Store</seealso>
    let Store = Prefixed_Name(w3dpv, "Store") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Student</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#HumanSubject</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Student">https://w3id.org/dpv#Student</seealso>
    let Student = Prefixed_Name(w3dpv, "Student") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SubProcessorAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#LegalMeasure</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#LegalBasis</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SubProcessorAgreement">https://w3id.org/dpv#SubProcessorAgreement</seealso>
    let SubProcessorAgreement =
        Prefixed_Name(w3dpv, "SubProcessorAgreement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Subscriber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#HumanSubject</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Subscriber">https://w3id.org/dpv#Subscriber</seealso>
    let Subscriber = Prefixed_Name(w3dpv, "Subscriber") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SubsidiaryLegalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SubsidiaryLegalEntity">https://w3id.org/dpv#SubsidiaryLegalEntity</seealso>
    let SubsidiaryLegalEntity =
        Prefixed_Name(w3dpv, "SubsidiaryLegalEntity") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SupportContractNegotiation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SupportContractNegotiation">https://w3id.org/dpv#SupportContractNegotiation</seealso>
    let SupportContractNegotiation =
        Prefixed_Name(w3dpv, "SupportContractNegotiation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SupportEntityDecisionMaking</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SupportEntityDecisionMaking">https://w3id.org/dpv#SupportEntityDecisionMaking</seealso>
    let SupportEntityDecisionMaking =
        Prefixed_Name(w3dpv, "SupportEntityDecisionMaking") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SupportExchangeOfViews</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SupportExchangeOfViews">https://w3id.org/dpv#SupportExchangeOfViews</seealso>
    let SupportExchangeOfViews =
        Prefixed_Name(w3dpv, "SupportExchangeOfViews") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SupportInformedConsentDecision</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SupportInformedConsentDecision">https://w3id.org/dpv#SupportInformedConsentDecision</seealso>
    let SupportInformedConsentDecision =
        Prefixed_Name(w3dpv, "SupportInformedConsentDecision") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:SupraNationalAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#SupraNationalAuthority">https://w3id.org/dpv#SupraNationalAuthority</seealso>
    let SupraNationalAuthority =
        Prefixed_Name(w3dpv, "SupraNationalAuthority") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasContact</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasContact">https://w3id.org/dpv#hasContact</seealso>
    let hasContact = Prefixed_Name(w3dpv, "hasContact") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasContext">https://w3id.org/dpv#hasContext</seealso>
    let hasContext = Prefixed_Name(w3dpv, "hasContext") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasContractControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasContractControl">https://w3id.org/dpv#hasContractControl</seealso>
    let hasContractControl = Prefixed_Name(w3dpv, "hasContractControl") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasContractStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasContractStatus">https://w3id.org/dpv#hasContractStatus</seealso>
    let hasContractStatus = Prefixed_Name(w3dpv, "hasContractStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasContractualClause</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasContractualClause">https://w3id.org/dpv#hasContractualClause</seealso>
    let hasContractualClause =
        Prefixed_Name(w3dpv, "hasContractualClause") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasContractualFulfilmentStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasContractualFulfilmentStatus">https://w3id.org/dpv#hasContractualFulfilmentStatus</seealso>
    let hasContractualFulfilmentStatus =
        Prefixed_Name(w3dpv, "hasContractualFulfilmentStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasCountry">https://w3id.org/dpv#hasCountry</seealso>
    let hasCountry = Prefixed_Name(w3dpv, "hasCountry") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasLocation">https://w3id.org/dpv#hasLocation</seealso>
    let hasLocation = Prefixed_Name(w3dpv, "hasLocation") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasData</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasData">https://w3id.org/dpv#hasData</seealso>
    let hasData = Prefixed_Name(w3dpv, "hasData") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:personal-data-properties</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#personal-data-properties">https://w3id.org/dpv#personal-data-properties</seealso>
    let personal_data_properties =
        Prefixed_Name(w3dpv, "personal-data-properties") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasDataController</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasDataController">https://w3id.org/dpv#hasDataController</seealso>
    let hasDataController = Prefixed_Name(w3dpv, "hasDataController") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasDataExporter</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasDataExporter">https://w3id.org/dpv#hasDataExporter</seealso>
    let hasDataExporter = Prefixed_Name(w3dpv, "hasDataExporter") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasDataImporter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasDataImporter">https://w3id.org/dpv#hasDataImporter</seealso>
    let hasDataImporter = Prefixed_Name(w3dpv, "hasDataImporter") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasRecipient</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasRecipient">https://w3id.org/dpv#hasRecipient</seealso>
    let hasRecipient = Prefixed_Name(w3dpv, "hasRecipient") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasDataProcessor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasDataProcessor">https://w3id.org/dpv#hasDataProcessor</seealso>
    let hasDataProcessor = Prefixed_Name(w3dpv, "hasDataProcessor") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasDataProtectionOfficer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasDataProtectionOfficer">https://w3id.org/dpv#hasDataProtectionOfficer</seealso>
    let hasDataProtectionOfficer =
        Prefixed_Name(w3dpv, "hasDataProtectionOfficer") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasRepresentative</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasRepresentative">https://w3id.org/dpv#hasRepresentative</seealso>
    let hasRepresentative = Prefixed_Name(w3dpv, "hasRepresentative") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasDataSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasDataSource">https://w3id.org/dpv#hasDataSource</seealso>
    let hasDataSource = Prefixed_Name(w3dpv, "hasDataSource") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasDataSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasDataSubject">https://w3id.org/dpv#hasDataSubject</seealso>
    let hasDataSubject = Prefixed_Name(w3dpv, "hasDataSubject") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasHumanSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasHumanSubject">https://w3id.org/dpv#hasHumanSubject</seealso>
    let hasHumanSubject = Prefixed_Name(w3dpv, "hasHumanSubject") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasDataSubjectScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasDataSubjectScale">https://w3id.org/dpv#hasDataSubjectScale</seealso>
    let hasDataSubjectScale =
        Prefixed_Name(w3dpv, "hasDataSubjectScale") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasScale">https://w3id.org/dpv#hasScale</seealso>
    let hasScale = Prefixed_Name(w3dpv, "hasScale") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:processing-scale-properties</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#processing-scale-properties">https://w3id.org/dpv#processing-scale-properties</seealso>
    let processing_scale_properties =
        Prefixed_Name(w3dpv, "processing-scale-properties") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:hasDataVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasDataVolume">https://w3id.org/dpv#hasDataVolume</seealso>
    let hasDataVolume = Prefixed_Name(w3dpv, "hasDataVolume") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasDeterrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasDeterrence">https://w3id.org/dpv#hasDeterrence</seealso>
    let hasDeterrence = Prefixed_Name(w3dpv, "hasDeterrence") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:hasRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#hasRule">https://w3id.org/dpv#hasRule</seealso>
    let hasRule = Prefixed_Name(w3dpv, "hasRule") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:isResidualRiskOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#isResidualRiskOf">https://w3id.org/dpv#isResidualRiskOf</seealso>
    let isResidualRiskOf = Prefixed_Name(w3dpv, "isResidualRiskOf") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:isSubsidiaryOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#isSubsidiaryOf">https://w3id.org/dpv#isSubsidiaryOf</seealso>
    let isSubsidiaryOf = Prefixed_Name(w3dpv, "isSubsidiaryOf") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:mitigatesRisk</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#mitigatesRisk">https://w3id.org/dpv#mitigatesRisk</seealso>
    let mitigatesRisk = Prefixed_Name(w3dpv, "mitigatesRisk") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:supportsComplianceWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#supportsComplianceWith">https://w3id.org/dpv#supportsComplianceWith</seealso>
    let supportsComplianceWith =
        Prefixed_Name(w3dpv, "supportsComplianceWith") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:contract-control-classes</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#contract-control-classes">https://w3id.org/dpv#contract-control-classes</seealso>
    let contract_control_classes =
        Prefixed_Name(w3dpv, "contract-control-classes") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:rules-classes</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#rules-classes">https://w3id.org/dpv#rules-classes</seealso>
    let rules_classes = Prefixed_Name(w3dpv, "rules-classes") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Access</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Processing</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Access">https://w3id.org/dpv#Access</seealso>
    let Access = Prefixed_Name(w3dpv, "Access") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Use</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Processing</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Use">https://w3id.org/dpv#Use</seealso>
    let Use = Prefixed_Name(w3dpv, "Use") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:AccessControlMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#AccessControlMethod">https://w3id.org/dpv#AccessControlMethod</seealso>
    let AccessControlMethod =
        Prefixed_Name(w3dpv, "AccessControlMethod") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:technical-measures-classes</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#technical-measures-classes">https://w3id.org/dpv#technical-measures-classes</seealso>
    let technical_measures_classes =
        Prefixed_Name(w3dpv, "technical-measures-classes") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:AccountManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#AccountManagement">https://w3id.org/dpv#AccountManagement</seealso>
    let AccountManagement = Prefixed_Name(w3dpv, "AccountManagement") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Obtain</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Processing</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Obtain">https://w3id.org/dpv#Obtain</seealso>
    let Obtain = Prefixed_Name(w3dpv, "Obtain") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ActivelyInvolved</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#InvolvementStatus</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ActivelyInvolved">https://w3id.org/dpv#ActivelyInvolved</seealso>
    let ActivelyInvolved = Prefixed_Name(w3dpv, "ActivelyInvolved") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:InvolvementStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#InvolvementStatus">https://w3id.org/dpv#InvolvementStatus</seealso>
    let InvolvementStatus = Prefixed_Name(w3dpv, "InvolvementStatus") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ActivityStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ActivityStatus">https://w3id.org/dpv#ActivityStatus</seealso>
    let ActivityStatus = Prefixed_Name(w3dpv, "ActivityStatus") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ActivityMonitoring</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ActivityMonitoring">https://w3id.org/dpv#ActivityMonitoring</seealso>
    let ActivityMonitoring = Prefixed_Name(w3dpv, "ActivityMonitoring") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ActivityOngoing</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#ActivityStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ActivityOngoing">https://w3id.org/dpv#ActivityOngoing</seealso>
    let ActivityOngoing = Prefixed_Name(w3dpv, "ActivityOngoing") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ActivityProposed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#ActivityStatus</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ActivityProposed">https://w3id.org/dpv#ActivityProposed</seealso>
    let ActivityProposed = Prefixed_Name(w3dpv, "ActivityProposed") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Adapt</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Processing</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Adapt">https://w3id.org/dpv#Adapt</seealso>
    let Adapt = Prefixed_Name(w3dpv, "Adapt") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Transform</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Processing</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Transform">https://w3id.org/dpv#Transform</seealso>
    let Transform = Prefixed_Name(w3dpv, "Transform") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:HumanSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#HumanSubject">https://w3id.org/dpv#HumanSubject</seealso>
    let HumanSubject = Prefixed_Name(w3dpv, "HumanSubject") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:entities-datasubject-classes</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#entities-datasubject-classes">https://w3id.org/dpv#entities-datasubject-classes</seealso>
    let entities_datasubject_classes =
        Prefixed_Name(w3dpv, "entities-datasubject-classes") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Compliant</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#ComplianceStatus</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Compliant">https://w3id.org/dpv#Compliant</seealso>
    let Compliant = Prefixed_Name(w3dpv, "Compliant") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractTerminationClause</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#ContractualClause</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractTerminationClause">https://w3id.org/dpv#ContractTerminationClause</seealso>
    let ContractTerminationClause =
        Prefixed_Name(w3dpv, "ContractTerminationClause") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractUnderNegotiation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#ContractPreparationStatus</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractUnderNegotiation">https://w3id.org/dpv#ContractUnderNegotiation</seealso>
    let ContractUnderNegotiation =
        Prefixed_Name(w3dpv, "ContractUnderNegotiation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractViolated</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#ContractFulfilmentStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractViolated">https://w3id.org/dpv#ContractViolated</seealso>
    let ContractViolated = Prefixed_Name(w3dpv, "ContractViolated") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractualClauseFulfilled</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#ContractualClauseFulfilmentStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractualClauseFulfilled">https://w3id.org/dpv#ContractualClauseFulfilled</seealso>
    let ContractualClauseFulfilled =
        Prefixed_Name(w3dpv, "ContractualClauseFulfilled") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractualClauseFulfilmentStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractualClauseFulfilmentStatus">https://w3id.org/dpv#ContractualClauseFulfilmentStatus</seealso>
    let ContractualClauseFulfilmentStatus =
        Prefixed_Name(w3dpv, "ContractualClauseFulfilmentStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractualClauseNotFulfilled</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#ContractualClauseFulfilmentStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractualClauseNotFulfilled">https://w3id.org/dpv#ContractualClauseNotFulfilled</seealso>
    let ContractualClauseNotFulfilled =
        Prefixed_Name(w3dpv, "ContractualClauseNotFulfilled") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractualClauseViolated</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#ContractualClauseFulfilmentStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractualClauseViolated">https://w3id.org/dpv#ContractualClauseViolated</seealso>
    let ContractualClauseViolated =
        Prefixed_Name(w3dpv, "ContractualClauseViolated") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ContractualTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#LegalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ContractualTerms">https://w3id.org/dpv#ContractualTerms</seealso>
    let ContractualTerms = Prefixed_Name(w3dpv, "ContractualTerms") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ControllerDataSubjectAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#LegalMeasure</para>
    ///   <para>w3id:dpv#LegalBasis</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ControllerDataSubjectAgreement">https://w3id.org/dpv#ControllerDataSubjectAgreement</seealso>
    let ControllerDataSubjectAgreement =
        Prefixed_Name(w3dpv, "ControllerDataSubjectAgreement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:DataSubjectContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#LegalBasis</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#DataSubjectContract">https://w3id.org/dpv#DataSubjectContract</seealso>
    let DataSubjectContract =
        Prefixed_Name(w3dpv, "DataSubjectContract") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ControllerInformed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#EntityInformedStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ControllerInformed">https://w3id.org/dpv#ControllerInformed</seealso>
    let ControllerInformed = Prefixed_Name(w3dpv, "ControllerInformed") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ControllerProcessorAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#LegalBasis</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#LegalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ControllerProcessorAgreement">https://w3id.org/dpv#ControllerProcessorAgreement</seealso>
    let ControllerProcessorAgreement =
        Prefixed_Name(w3dpv, "ControllerProcessorAgreement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ControllerUninformed</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#EntityInformedStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ControllerUninformed">https://w3id.org/dpv#ControllerUninformed</seealso>
    let ControllerUninformed =
        Prefixed_Name(w3dpv, "ControllerUninformed") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Copy</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Processing</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Copy">https://w3id.org/dpv#Copy</seealso>
    let Copy = Prefixed_Name(w3dpv, "Copy") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:CorrectingProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#EntityPermissiveInvolvement</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CorrectingProcess">https://w3id.org/dpv#CorrectingProcess</seealso>
    let CorrectingProcess = Prefixed_Name(w3dpv, "CorrectingProcess") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:CorrectingProcessOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#EntityPermissiveInvolvement</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CorrectingProcessOutput">https://w3id.org/dpv#CorrectingProcessOutput</seealso>
    let CorrectingProcessOutput =
        Prefixed_Name(w3dpv, "CorrectingProcessOutput") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:CounterMoneyLaundering</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#CounterMoneyLaundering">https://w3id.org/dpv#CounterMoneyLaundering</seealso>
    let CounterMoneyLaundering =
        Prefixed_Name(w3dpv, "CounterMoneyLaundering") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:FraudPreventionAndDetection</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#FraudPreventionAndDetection">https://w3id.org/dpv#FraudPreventionAndDetection</seealso>
    let FraudPreventionAndDetection =
        Prefixed_Name(w3dpv, "FraudPreventionAndDetection") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Counterterrorism</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Purpose</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Counterterrorism">https://w3id.org/dpv#Counterterrorism</seealso>
    let Counterterrorism = Prefixed_Name(w3dpv, "Counterterrorism") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Country</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Country">https://w3id.org/dpv#Country</seealso>
    let Country = Prefixed_Name(w3dpv, "Country") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Jurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Jurisdiction">https://w3id.org/dpv#Jurisdiction</seealso>
    let Jurisdiction = Prefixed_Name(w3dpv, "Jurisdiction") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Employee</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#HumanSubject</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Employee">https://w3id.org/dpv#Employee</seealso>
    let Employee = Prefixed_Name(w3dpv, "Employee") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:EmploymentContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#LegalBasis</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#EmploymentContract">https://w3id.org/dpv#EmploymentContract</seealso>
    let EmploymentContract = Prefixed_Name(w3dpv, "EmploymentContract") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:EncryptionAtRest</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#EncryptionAtRest">https://w3id.org/dpv#EncryptionAtRest</seealso>
    let EncryptionAtRest = Prefixed_Name(w3dpv, "EncryptionAtRest") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:EncryptionInTransfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#EncryptionInTransfer">https://w3id.org/dpv#EncryptionInTransfer</seealso>
    let EncryptionInTransfer =
        Prefixed_Name(w3dpv, "EncryptionInTransfer") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:HumanInvolvementForControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#HumanInvolvement</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#HumanInvolvementForControl">https://w3id.org/dpv#HumanInvolvementForControl</seealso>
    let HumanInvolvementForControl =
        Prefixed_Name(w3dpv, "HumanInvolvementForControl") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:HumanInvolvementForDecision</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#HumanInvolvement</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#HumanInvolvementForDecision">https://w3id.org/dpv#HumanInvolvementForDecision</seealso>
    let HumanInvolvementForDecision =
        Prefixed_Name(w3dpv, "HumanInvolvementForDecision") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:WithdrawConsent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#WithdrawConsent">https://w3id.org/dpv#WithdrawConsent</seealso>
    let WithdrawConsent = Prefixed_Name(w3dpv, "WithdrawConsent") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ProvideConsent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ProvideConsent">https://w3id.org/dpv#ProvideConsent</seealso>
    let ProvideConsent = Prefixed_Name(w3dpv, "ProvideConsent") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ReaffirmConsent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ReaffirmConsent">https://w3id.org/dpv#ReaffirmConsent</seealso>
    let ReaffirmConsent = Prefixed_Name(w3dpv, "ReaffirmConsent") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:ManagementStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ManagementStandard">https://w3id.org/dpv#ManagementStandard</seealso>
    let ManagementStandard = Prefixed_Name(w3dpv, "ManagementStandard") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Match</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Processing</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Match">https://w3id.org/dpv#Match</seealso>
    let Match = Prefixed_Name(w3dpv, "Match") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:MediumScaleOfDataSubjects</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#DataSubjectScale</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#MediumScaleOfDataSubjects">https://w3id.org/dpv#MediumScaleOfDataSubjects</seealso>
    let MediumScaleOfDataSubjects =
        Prefixed_Name(w3dpv, "MediumScaleOfDataSubjects") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:MediumScaleProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#ProcessingScale</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#MediumScaleProcessing">https://w3id.org/dpv#MediumScaleProcessing</seealso>
    let MediumScaleProcessing =
        Prefixed_Name(w3dpv, "MediumScaleProcessing") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Member</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#HumanSubject</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Member">https://w3id.org/dpv#Member</seealso>
    let Member = Prefixed_Name(w3dpv, "Member") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:MemberPartnerManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#MemberPartnerManagement">https://w3id.org/dpv#MemberPartnerManagement</seealso>
    let MemberPartnerManagement =
        Prefixed_Name(w3dpv, "MemberPartnerManagement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:MentallyVulnerableDataSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#HumanSubject</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#MentallyVulnerableDataSubject">https://w3id.org/dpv#MentallyVulnerableDataSubject</seealso>
    let MentallyVulnerableDataSubject =
        Prefixed_Name(w3dpv, "MentallyVulnerableDataSubject") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:MentallyVulnerableHuman</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#HumanSubject</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#MentallyVulnerableHuman">https://w3id.org/dpv#MentallyVulnerableHuman</seealso>
    let MentallyVulnerableHuman =
        Prefixed_Name(w3dpv, "MentallyVulnerableHuman") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PermissionNotUtilised</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#RuleFulfilmentStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PermissionNotUtilised">https://w3id.org/dpv#PermissionNotUtilised</seealso>
    let PermissionNotUtilised =
        Prefixed_Name(w3dpv, "PermissionNotUtilised") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PermissionUtilised</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#RuleFulfilmentStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PermissionUtilised">https://w3id.org/dpv#PermissionUtilised</seealso>
    let PermissionUtilised = Prefixed_Name(w3dpv, "PermissionUtilised") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:PersonalDataAudit</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PersonalDataAudit">https://w3id.org/dpv#PersonalDataAudit</seealso>
    let PersonalDataAudit = Prefixed_Name(w3dpv, "PersonalDataAudit") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PersonalDataHandling</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PersonalDataHandling">https://w3id.org/dpv#PersonalDataHandling</seealso>
    let PersonalDataHandling =
        Prefixed_Name(w3dpv, "PersonalDataHandling") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PersonalDataProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PersonalDataProcess">https://w3id.org/dpv#PersonalDataProcess</seealso>
    let PersonalDataProcess =
        Prefixed_Name(w3dpv, "PersonalDataProcess") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PersonalSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Location</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PersonalSpace">https://w3id.org/dpv#PersonalSpace</seealso>
    let PersonalSpace = Prefixed_Name(w3dpv, "PersonalSpace") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Personalisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Personalisation">https://w3id.org/dpv#Personalisation</seealso>
    let Personalisation = Prefixed_Name(w3dpv, "Personalisation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PersonalisedBenefits</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PersonalisedBenefits">https://w3id.org/dpv#PersonalisedBenefits</seealso>
    let PersonalisedBenefits =
        Prefixed_Name(w3dpv, "PersonalisedBenefits") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ServicePersonalisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ServicePersonalisation">https://w3id.org/dpv#ServicePersonalisation</seealso>
    let ServicePersonalisation =
        Prefixed_Name(w3dpv, "ServicePersonalisation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PersonnelBehaviourMonitoring</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PersonnelBehaviourMonitoring">https://w3id.org/dpv#PersonnelBehaviourMonitoring</seealso>
    let PersonnelBehaviourMonitoring =
        Prefixed_Name(w3dpv, "PersonnelBehaviourMonitoring") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PersonnelMonitoring</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PersonnelMonitoring">https://w3id.org/dpv#PersonnelMonitoring</seealso>
    let PersonnelMonitoring =
        Prefixed_Name(w3dpv, "PersonnelMonitoring") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PersonnelHiring</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PersonnelHiring">https://w3id.org/dpv#PersonnelHiring</seealso>
    let PersonnelHiring = Prefixed_Name(w3dpv, "PersonnelHiring") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:PersonnelManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#PersonnelManagement">https://w3id.org/dpv#PersonnelManagement</seealso>
    let PersonnelManagement =
        Prefixed_Name(w3dpv, "PersonnelManagement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:RegionalAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RegionalAuthority">https://w3id.org/dpv#RegionalAuthority</seealso>
    let RegionalAuthority = Prefixed_Name(w3dpv, "RegionalAuthority") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:RegionalScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#GeographicCoverage</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RegionalScale">https://w3id.org/dpv#RegionalScale</seealso>
    let RegionalScale = Prefixed_Name(w3dpv, "RegionalScale") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:RegulatorySandbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#RegulatorySandbox">https://w3id.org/dpv#RegulatorySandbox</seealso>
    let RegulatorySandbox = Prefixed_Name(w3dpv, "RegulatorySandbox") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:Safeguard</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#OrganisationalMeasure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Safeguard">https://w3id.org/dpv#Safeguard</seealso>
    let Safeguard = Prefixed_Name(w3dpv, "Safeguard") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:ReligiousAssociations</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#ReligiousAssociations">https://w3id.org/dpv#ReligiousAssociations</seealso>
    let ReligiousAssociations =
        Prefixed_Name(w3dpv, "ReligiousAssociations") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:UninformedConsent</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#LegalBasis</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#UninformedConsent">https://w3id.org/dpv#UninformedConsent</seealso>
    let UninformedConsent = Prefixed_Name(w3dpv, "UninformedConsent") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:UnknownApplicability</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Applicability</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#UnknownApplicability">https://w3id.org/dpv#UnknownApplicability</seealso>
    let UnknownApplicability =
        Prefixed_Name(w3dpv, "UnknownApplicability") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Unlawful</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Lawfulness</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Unlawful">https://w3id.org/dpv#Unlawful</seealso>
    let Unlawful = Prefixed_Name(w3dpv, "Unlawful") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:UnstructuredData</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#UnstructuredData">https://w3id.org/dpv#UnstructuredData</seealso>
    let UnstructuredData = Prefixed_Name(w3dpv, "UnstructuredData") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:UntilEventDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#UntilEventDuration">https://w3id.org/dpv#UntilEventDuration</seealso>
    let UntilEventDuration = Prefixed_Name(w3dpv, "UntilEventDuration") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:UntilTimeDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#UntilTimeDuration">https://w3id.org/dpv#UntilTimeDuration</seealso>
    let UntilTimeDuration = Prefixed_Name(w3dpv, "UntilTimeDuration") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:UnverifiedData</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#UnverifiedData">https://w3id.org/dpv#UnverifiedData</seealso>
    let UnverifiedData = Prefixed_Name(w3dpv, "UnverifiedData") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:UsageControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#UsageControl">https://w3id.org/dpv#UsageControl</seealso>
    let UsageControl = Prefixed_Name(w3dpv, "UsageControl") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:User</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#HumanSubject</para>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#User">https://w3id.org/dpv#User</seealso>
    let User = Prefixed_Name(w3dpv, "User") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:UserInterfacePersonalisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#UserInterfacePersonalisation">https://w3id.org/dpv#UserInterfacePersonalisation</seealso>
    let UserInterfacePersonalisation =
        Prefixed_Name(w3dpv, "UserInterfacePersonalisation") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:VariableLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#LocationFixture</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#VariableLocation">https://w3id.org/dpv#VariableLocation</seealso>
    let VariableLocation = Prefixed_Name(w3dpv, "VariableLocation") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:VendorManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#VendorManagement">https://w3id.org/dpv#VendorManagement</seealso>
    let VendorManagement = Prefixed_Name(w3dpv, "VendorManagement") |> PrefixedName
    /// <summary>
    ///   <para>w3dpv:VendorPayment</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#VendorPayment">https://w3id.org/dpv#VendorPayment</seealso>
    let VendorPayment = Prefixed_Name(w3dpv, "VendorPayment") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:VendorRecordsManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#VendorRecordsManagement">https://w3id.org/dpv#VendorRecordsManagement</seealso>
    let VendorRecordsManagement =
        Prefixed_Name(w3dpv, "VendorRecordsManagement") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:VendorSelectionAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#Purpose</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#VendorSelectionAssessment">https://w3id.org/dpv#VendorSelectionAssessment</seealso>
    let VendorSelectionAssessment =
        Prefixed_Name(w3dpv, "VendorSelectionAssessment") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:VerifiedData</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#VerifiedData">https://w3id.org/dpv#VerifiedData</seealso>
    let VerifiedData = Prefixed_Name(w3dpv, "VerifiedData") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:VirtualisationSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dpv#TechnicalMeasure</para>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#VirtualisationSecurity">https://w3id.org/dpv#VirtualisationSecurity</seealso>
    let VirtualisationSecurity =
        Prefixed_Name(w3dpv, "VirtualisationSecurity") |> PrefixedName

    /// <summary>
    ///   <para>w3dpv:Visitor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:dpv#HumanSubject</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dpv#Visitor">https://w3id.org/dpv#Visitor</seealso>
    let Visitor = Prefixed_Name(w3dpv, "Visitor") |> PrefixedName

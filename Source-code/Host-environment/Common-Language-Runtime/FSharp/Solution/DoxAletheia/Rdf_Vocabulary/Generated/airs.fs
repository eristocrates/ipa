namespace https.raw.githubusercontent.com.airs_linked_data.lov.latest.src.airs_vocabulary.ttl.hash

open DoxAletheia

module airs =
    let _namespace_name =
        "https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// This represents a referenceable street location of an item, using an addressing system other than geospatial terms, often with postal system terms.  airs:hasDescription is a description of the physical location or other information pertinent to this address, and hasExplanationForNoPhysicalAddress clarifies why the address doesn't have a physical presence.
    /// <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#Address"></see></summary>
    let Address = _prefix "Address"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#explanationForNoPhysicalAddess"></see>
    /// </summary>
    let explanationForNoPhysicalAddess = _prefix "explanationForNoPhysicalAddess"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#physicalAddress"></see>
    /// </summary>
    let physicalAddress = _prefix "physicalAddress"
    /// <summary>
    /// For property &lt;http://www.w3.org/2006/vcard/ns:hasRelated&gt;, it indicates the person within each agency who has overall responsibility for updating the information about the agency, its sites and its services, etc.
    /// <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#ResourceInfo"></see></summary>
    let ResourceInfo = _prefix "ResourceInfo"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasResourceInfo"></see>
    /// </summary>
    let hasResourceInfo = _prefix "hasResourceInfo"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#mailingAddress"></see>
    /// </summary>
    let mailingAddress = _prefix "mailingAddress"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#AgeRequirement"></see>
    /// </summary>
    let AgeRequirement = _prefix "AgeRequirement"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#maximumAge"></see>
    /// </summary>
    let maximumAge = _prefix "maximumAge"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#minimumAge"></see>
    /// </summary>
    let minimumAge = _prefix "minimumAge"
    /// <summary>
    /// Agencies are organizations that offer services at locations. Agencies provide services directly or they may have "child" agencies that offer these services. Services are offered at sites that belong to an agency. Services are represented by the combination of taxonomy codes offered at a location; this idea is called a SiteService. To recap: Agencies don't provide services directly, they provide them through sites. For property &lt;http://www.w3.org/2006/vcard/ns:hasRelated&gt; This represents the agency contact.  1) Contact is the person at an Agency, or Site who will interface with the public or who has responsibility for the entity, like a site manager or director.
    /// <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#Agency"></see></summary>
    let Agency = _prefix "Agency"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#yearIncorporated"></see>
    /// </summary>
    let yearIncorporated = _prefix "yearIncorporated"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#recordOwner"></see>
    /// </summary>
    let recordOwner = _prefix "recordOwner"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#AlternateName"></see>
    /// </summary>
    let AlternateName = _prefix "AlternateName"
    /// <summary>
    /// These are alternate names for an object. Confidential indicates that the alternate name won't be shared with the public.
    /// <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasAlternateName"></see></summary>
    let hasAlternateName = _prefix "hasAlternateName"
    /// <summary>
    /// A web location that has more information related to the SiteService, Agency, etc..  For example a facebook page for the Agency, that is supplementary to the Agency's main website.
    /// <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#InternetResource"></see></summary>
    let InternetResource = _prefix "InternetResource"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasInternetResource"></see>
    /// </summary>
    let hasInternetResource = _prefix "hasInternetResource"
    /// <summary>
    /// Groups together multiple Services that are related somehow.
    /// <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#ServiceGroup"></see></summary>
    let ServiceGroup = _prefix "ServiceGroup"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasServiceGroup"></see>
    /// </summary>
    let hasServiceGroup = _prefix "hasServiceGroup"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#excludedFromWebsite"></see>
    /// </summary>
    let excludedFromWebsite = _prefix "excludedFromWebsite"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#legalStatus"></see>
    /// </summary>
    let legalStatus = _prefix "legalStatus"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#fein"></see>
    /// </summary>
    let fein = _prefix "fein"
    /// <summary>
    /// If applicable, information about the license type (dct:title)/accreditation held by the agency and the body that licensed/accredited it.
    /// <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#LicenseAccreditation"></see></summary>
    let LicenseAccreditation = _prefix "LicenseAccreditation"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasLicenseAccreditation"></see>
    /// </summary>
    let hasLicenseAccreditation = _prefix "hasLicenseAccreditation"
    /// <summary>
    /// Sites are physical locations or none physical locations (a website or hotline). Site is used for two purposes. First, it is used by Agency to provide the location of the agency in Agency.AgencyLocation (note this type of Site would never have any SiteService children). Second, sites are also the location where services are provided. This would be the Agency.Site element (note this type of Site would have SiteService children).
    /// <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#Site"></see></summary>
    let Site = _prefix "Site"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasSite"></see>
    /// </summary>
    let hasSite = _prefix "hasSite"
    /// <summary>
    /// Akin to a "Program", as in for example "a homeless outreach program".  Can be delivered at many "airs:Site[s]", and the nexus of the two is an airs:SiteService
    /// <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#Service"></see></summary>
    let Service = _prefix "Service"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#offersService"></see>
    /// </summary>
    let offersService = _prefix "offersService"
    /// <summary>
    /// ApplicationProcess describes the steps taken to apply for or access the service; also known as the 'intake process'. For example, "Call for an appointment" or "Walk in only".
    /// <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#ApplicationProcess"></see></summary>
    let ApplicationProcess = _prefix "ApplicationProcess"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#Document"></see>
    /// </summary>
    let Document = _prefix "Document"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#GenderRequirement"></see>
    /// </summary>
    let GenderRequirement = _prefix "GenderRequirement"
    /// <summary>
    /// Languages offered, and available times, at the SiteService
    /// <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#LanguageAvailability"></see></summary>
    let LanguageAvailability = _prefix "LanguageAvailability"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasLanguageTimeOpen"></see>
    /// </summary>
    let hasLanguageTimeOpen = _prefix "hasLanguageTimeOpen"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#licensedBy"></see>
    /// </summary>
    let licensedBy = _prefix "licensedBy"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#lastActionType"></see>
    /// </summary>
    let lastActionType = _prefix "lastActionType"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#availableForReferral"></see>
    /// </summary>
    let availableForReferral = _prefix "availableForReferral"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#dateOfLastAction"></see>
    /// </summary>
    let dateOfLastAction = _prefix "dateOfLastAction"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#availableForDirectory"></see>
    /// </summary>
    let availableForDirectory = _prefix "availableForDirectory"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#dateLastVerified"></see>
    /// </summary>
    let dateLastVerified = _prefix "dateLastVerified"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#attributesResourceSpecialist"></see>
    /// </summary>
    let attributesResourceSpecialist = _prefix "attributesResourceSpecialist"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#availableForResearch"></see>
    /// </summary>
    let availableForResearch = _prefix "availableForResearch"
    /// <summary>
    /// Activities that are only offered a certain time of year, such as seasonal tax preparation, summer camps and holiday meals.
    /// <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#Seasonal"></see></summary>
    let Seasonal = _prefix "Seasonal"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#seasonal"></see>
    /// </summary>
    let seasonal = _prefix "seasonal"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasSeasonalSchedule"></see>
    /// </summary>
    let hasSeasonalSchedule = _prefix "hasSeasonalSchedule"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasAgency"></see>
    /// </summary>
    let hasAgency = _prefix "hasAgency"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#status"></see>
    /// </summary>
    let status = _prefix "status"
    /// <summary>
    /// SiteService is the smallest unit describing a "service" that is offered at a Site. It can be thought of as the intersection of a Site and a Taxonomy code (or related Taxonomy codes) and meta data about what is offered. A "Service" however is not represented as its own element because the "Service" cannot exist without a location (the site).
    /// <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#SiteService"></see></summary>
    let SiteService = _prefix "SiteService"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasSiteService"></see>
    /// </summary>
    let hasSiteService = _prefix "hasSiteService"
    /// <summary>
    /// This is the geographic area served by the SiteService. This can be anything from a single neighborhood to an entire country. Types can also be mixed; perhaps one city and 6 nearby ZIP codes. In this case the required element would be City and there would be additional ZIP codes. A national 1-800 hotline would have one Country element.
    /// <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#ServiceArea"></see></summary>
    let ServiceArea = _prefix "ServiceArea"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#censusTract"></see>
    /// </summary>
    let censusTract = _prefix "censusTract"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#servesGeographicArea"></see>
    /// </summary>
    let servesGeographicArea = _prefix "servesGeographicArea"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasAddress"></see>
    /// </summary>
    let hasAddress = _prefix "hasAddress"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#disabilitiesAccess"></see>
    /// </summary>
    let disabilitiesAccess = _prefix "disabilitiesAccess"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#transportationServicesAccess"></see>
    /// </summary>
    let transportationServicesAccess = _prefix "transportationServicesAccess"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#directions"></see>
    /// </summary>
    let directions = _prefix "directions"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#openHoursDescription"></see>
    /// </summary>
    let openHoursDescription = _prefix "openHoursDescription"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasSpatialLocation"></see>
    /// </summary>
    let hasSpatialLocation = _prefix "hasSpatialLocation"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#locatedAtCrossStreet"></see>
    /// </summary>
    let locatedAtCrossStreet = _prefix "locatedAtCrossStreet"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#opensAtTimes"></see>
    /// </summary>
    let opensAtTimes = _prefix "opensAtTimes"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#paymentMethodAccepted"></see>
    /// </summary>
    let paymentMethodAccepted = _prefix "paymentMethodAccepted"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasApplicationProcess"></see>
    /// </summary>
    let hasApplicationProcess = _prefix "hasApplicationProcess"
    /// <summary>
    /// General eligibility is a text area to list any eligibility requirements for participation or services. This can include any exclusions, both negative and positive requirements (i.e. must have/ can't have are all requirements)
    /// <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiresGeneralEligibility"></see></summary>
    let requiresGeneralEligibility = _prefix "requiresGeneralEligibility"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasGenderRequirement"></see>
    /// </summary>
    let hasGenderRequirement = _prefix "hasGenderRequirement"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#structuresFees"></see>
    /// </summary>
    let structuresFees = _prefix "structuresFees"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#notAlwaysAvailable"></see>
    /// </summary>
    let notAlwaysAvailable = _prefix "notAlwaysAvailable"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiredDocumentation"></see>
    /// </summary>
    let requiredDocumentation = _prefix "requiredDocumentation"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#Taxonomy"></see>
    /// </summary>
    let Taxonomy = _prefix "Taxonomy"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#taxonomyCode"></see>
    /// </summary>
    let taxonomyCode = _prefix "taxonomyCode"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#taxonomyTerm"></see>
    /// </summary>
    let taxonomyTerm = _prefix "taxonomyTerm"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#describesInternetResource"></see>
    /// </summary>
    let describesInternetResource = _prefix "describesInternetResource"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#explainsNoPhysicalAddress"></see>
    /// </summary>
    let explainsNoPhysicalAddress = _prefix "explainsNoPhysicalAddress"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasAreaDefinition"></see>
    /// </summary>
    let hasAreaDefinition = _prefix "hasAreaDefinition"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasDateAdded"></see>
    /// </summary>
    let hasDateAdded = _prefix "hasDateAdded"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasDescription"></see>
    /// </summary>
    let hasDescription = _prefix "hasDescription"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasIRSStatus"></see>
    /// </summary>
    let hasIRSStatus = _prefix "hasIRSStatus"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasLicenseType"></see>
    /// </summary>
    let hasLicenseType = _prefix "hasLicenseType"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasProgramName"></see>
    /// </summary>
    let hasProgramName = _prefix "hasProgramName"
    /// <summary>
    /// Use this if the address can not be shared due to security concerns, such as an assaulted women's shelter. While it is possible to code an address as Confidential="true", in this case the address is so confidential that it won't be shared at all.
    /// <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasReasonAddressWithheld"></see></summary>
    let hasReasonAddressWithheld = _prefix "hasReasonAddressWithheld"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasServiceGroupName"></see>
    /// </summary>
    let hasServiceGroupName = _prefix "hasServiceGroupName"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasTaxonomy"></see>
    /// </summary>
    let hasTaxonomy = _prefix "hasTaxonomy"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasTelephone"></see>
    /// </summary>
    let hasTelephone = _prefix "hasTelephone"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#isConfidential"></see>
    /// </summary>
    let isConfidential = _prefix "isConfidential"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#isLocatedInCity"></see>
    /// </summary>
    let isLocatedInCity = _prefix "isLocatedInCity"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#isLocatedInCounty"></see>
    /// </summary>
    let isLocatedInCounty = _prefix "isLocatedInCounty"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#isLocatedInPostalCode"></see>
    /// </summary>
    let isLocatedInPostalCode = _prefix "isLocatedInPostalCode"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#isLocatedInState"></see>
    /// </summary>
    let isLocatedInState = _prefix "isLocatedInState"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#isLocatedWithinCountry"></see>
    /// </summary>
    let isLocatedWithinCountry = _prefix "isLocatedWithinCountry"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#publicAccessToTransportation"></see>
    /// </summary>
    let publicAccessToTransportation = _prefix "publicAccessToTransportation"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiresDocument"></see>
    /// </summary>
    let requiresDocument = _prefix "requiresDocument"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiresFamily"></see>
    /// </summary>
    let requiresFamily = _prefix "requiresFamily"
    /// <summary>
    /// Information about any age or gender related requirements or inclusions for a particular service at a particular location.
    /// <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiresGender"></see></summary>
    let requiresGender = _prefix "requiresGender"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiresIncome"></see>
    /// </summary>
    let requiresIncome = _prefix "requiresIncome"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiresMaximumAge"></see>
    /// </summary>
    let requiresMaximumAge = _prefix "requiresMaximumAge"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiresMinimumAge"></see>
    /// </summary>
    let requiresMinimumAge = _prefix "requiresMinimumAge"
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiresResidency"></see>
    /// </summary>
    let requiresResidency = _prefix "requiresResidency"

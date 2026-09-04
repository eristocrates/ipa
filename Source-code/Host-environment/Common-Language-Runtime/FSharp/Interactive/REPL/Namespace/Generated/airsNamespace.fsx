#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module airs =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#" "airs"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : This represents a referenceable street location of an item, using an addressing system other than geospatial terms, often with postal system terms.  airs:hasDescription is a description of the physical location or other information pertinent to this address, and hasExplanationForNoPhysicalAddress clarifies why the address doesn't have a physical presence.</para>
    ///   <a href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#Address">airs:Address</a>
    /// </summary>
    let Address = _prefixId.prefix "Address"
    /// <summary>
    ///   <para>dcterms:description : Age requirements for participation, independent of gender.^^xsd:string</para>
    ///   <a href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#AgeRequirement">airs:AgeRequirement</a>
    /// </summary>
    let AgeRequirement = _prefixId.prefix "AgeRequirement"
    /// <summary>
    ///   <para>rdfs:label : Agenciardfs:label : Agencyrdfs:label : Agence</para>
    ///   <para>rdfs:comment : Agencies are organizations that offer services at locations. Agencies provide services directly or they may have "child" agencies that offer these services. Services are offered at sites that belong to an agency. Services are represented by the combination of taxonomy codes offered at a location; this idea is called a SiteService. To recap: Agencies don't provide services directly, they provide them through sites. For property &lt;http://www.w3.org/2006/vcard/ns:hasRelated&gt; This represents the agency contact.  1) Contact is the person at an Agency, or Site who will interface with the public or who has responsibility for the entity, like a site manager or director.</para>
    ///   <a href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#Agency">airs:Agency</a>
    /// </summary>
    let Agency = _prefixId.prefix "Agency"
    let AlternateName = _prefixId.prefix "AlternateName"
    /// <summary>
    ///   <para>rdfs:comment : ApplicationProcess describes the steps taken to apply for or access the service; also known as the 'intake process'. For example, "Call for an appointment" or "Walk in only".</para>
    ///   <a href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#ApplicationProcess">airs:ApplicationProcess</a>
    /// </summary>
    let ApplicationProcess = _prefixId.prefix "ApplicationProcess"
    let Document = _prefixId.prefix "Document"
    /// <summary>
    ///   <para>dcterms:description : Any gender requirements for participation.  Further restrictions upon age for a given gender are also available.^^xsd:string</para>
    ///   <a href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#GenderRequirement">airs:GenderRequirement</a>
    /// </summary>
    let GenderRequirement = _prefixId.prefix "GenderRequirement"
    /// <summary>
    ///   <para>rdfs:comment : A web location that has more information related to the SiteService, Agency, etc..  For example a facebook page for the Agency, that is supplementary to the Agency's main website.</para>
    ///   <a href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#InternetResource">airs:InternetResource</a>
    /// </summary>
    let InternetResource = _prefixId.prefix "InternetResource"
    /// <summary>
    ///   <para>rdfs:comment : Languages offered, and available times, at the SiteService</para>
    ///   <a href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#LanguageAvailability">airs:LanguageAvailability</a>
    /// </summary>
    let LanguageAvailability = _prefixId.prefix "LanguageAvailability"
    /// <summary>
    ///   <para>rdfs:comment : If applicable, information about the license type (dct:title)/accreditation held by the agency and the body that licensed/accredited it.</para>
    ///   <a href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#LicenseAccreditation">airs:LicenseAccreditation</a>
    /// </summary>
    let LicenseAccreditation = _prefixId.prefix "LicenseAccreditation"
    /// <summary>
    ///   <para>rdfs:comment : For property &lt;http://www.w3.org/2006/vcard/ns:hasRelated&gt;, it indicates the person within each agency who has overall responsibility for updating the information about the agency, its sites and its services, etc.</para>
    ///   <a href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#ResourceInfo">airs:ResourceInfo</a>
    /// </summary>
    let ResourceInfo = _prefixId.prefix "ResourceInfo"
    /// <summary>
    ///   <para>rdfs:comment : Activities that are only offered a certain time of year, such as seasonal tax preparation, summer camps and holiday meals.</para>
    ///   <a href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#Seasonal">airs:Seasonal</a>
    /// </summary>
    let Seasonal = _prefixId.prefix "Seasonal"
    /// <summary>
    ///   <para>rdfs:comment : Akin to a "Program", as in for example "a homeless outreach program".  Can be delivered at many "airs:Site[s]", and the nexus of the two is an airs:SiteService</para>
    ///   <a href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#Service">airs:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    /// <summary>
    ///   <para>rdfs:comment : This is the geographic area served by the SiteService. This can be anything from a single neighborhood to an entire country. Types can also be mixed; perhaps one city and 6 nearby ZIP codes. In this case the required element would be City and there would be additional ZIP codes. A national 1-800 hotline would have one Country element.</para>
    ///   <a href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#ServiceArea">airs:ServiceArea</a>
    /// </summary>
    let ServiceArea = _prefixId.prefix "ServiceArea"
    /// <summary>
    ///   <para>rdfs:comment : Groups together multiple Services that are related somehow.</para>
    ///   <a href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#ServiceGroup">airs:ServiceGroup</a>
    /// </summary>
    let ServiceGroup = _prefixId.prefix "ServiceGroup"
    /// <summary>
    ///   <para>rdfs:comment : Sites are physical locations or none physical locations (a website or hotline). Site is used for two purposes. First, it is used by Agency to provide the location of the agency in Agency.AgencyLocation (note this type of Site would never have any SiteService children). Second, sites are also the location where services are provided. This would be the Agency.Site element (note this type of Site would have SiteService children).</para>
    ///   <a href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#Site">airs:Site</a>
    /// </summary>
    let Site = _prefixId.prefix "Site"
    /// <summary>
    ///   <para>rdfs:comment : SiteService is the smallest unit describing a "service" that is offered at a Site. It can be thought of as the intersection of a Site and a Taxonomy code (or related Taxonomy codes) and meta data about what is offered. A "Service" however is not represented as its own element because the "Service" cannot exist without a location (the site).</para>
    ///   <a href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#SiteService">airs:SiteService</a>
    /// </summary>
    let SiteService = _prefixId.prefix "SiteService"
    let Taxonomy = _prefixId.prefix "Taxonomy"
    let attributesResourceSpecialist = _prefixId.prefix "attributesResourceSpecialist"
    let availableForDirectory = _prefixId.prefix "availableForDirectory"
    let availableForReferral = _prefixId.prefix "availableForReferral"
    let availableForResearch = _prefixId.prefix "availableForResearch"
    let censusTract = _prefixId.prefix "censusTract"
    let dateLastVerified = _prefixId.prefix "dateLastVerified"
    let dateOfLastAction = _prefixId.prefix "dateOfLastAction"
    let describesInternetResource = _prefixId.prefix "describesInternetResource"
    let directions = _prefixId.prefix "directions"
    let disabilitiesAccess = _prefixId.prefix "disabilitiesAccess"
    let excludedFromWebsite = _prefixId.prefix "excludedFromWebsite"
    let explainsNoPhysicalAddress = _prefixId.prefix "explainsNoPhysicalAddress"

    let explanationForNoPhysicalAddess =
        _prefixId.prefix "explanationForNoPhysicalAddess"

    let fein = _prefixId.prefix "fein"
    let hasAddress = _prefixId.prefix "hasAddress"
    let hasAgency = _prefixId.prefix "hasAgency"
    /// <summary>
    ///   <para>rdfs:comment : These are alternate names for an object. Confidential indicates that the alternate name won't be shared with the public.</para>
    ///   <a href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasAlternateName">airs:hasAlternateName</a>
    /// </summary>
    let hasAlternateName = _prefixId.prefix "hasAlternateName"
    let hasApplicationProcess = _prefixId.prefix "hasApplicationProcess"
    let hasAreaDefinition = _prefixId.prefix "hasAreaDefinition"
    let hasDateAdded = _prefixId.prefix "hasDateAdded"
    let hasDescription = _prefixId.prefix "hasDescription"
    let hasGenderRequirement = _prefixId.prefix "hasGenderRequirement"
    let hasIRSStatus = _prefixId.prefix "hasIRSStatus"
    let hasInternetResource = _prefixId.prefix "hasInternetResource"
    let hasLanguageTimeOpen = _prefixId.prefix "hasLanguageTimeOpen"
    let hasLicenseAccreditation = _prefixId.prefix "hasLicenseAccreditation"
    let hasLicenseType = _prefixId.prefix "hasLicenseType"
    let hasProgramName = _prefixId.prefix "hasProgramName"
    /// <summary>
    ///   <para>rdfs:comment : Use this if the address can not be shared due to security concerns, such as an assaulted women's shelter. While it is possible to code an address as Confidential="true", in this case the address is so confidential that it won't be shared at all.</para>
    ///   <a href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasReasonAddressWithheld">airs:hasReasonAddressWithheld</a>
    /// </summary>
    let hasReasonAddressWithheld = _prefixId.prefix "hasReasonAddressWithheld"
    let hasResourceInfo = _prefixId.prefix "hasResourceInfo"
    let hasSeasonalSchedule = _prefixId.prefix "hasSeasonalSchedule"
    let hasServiceGroup = _prefixId.prefix "hasServiceGroup"
    let hasServiceGroupName = _prefixId.prefix "hasServiceGroupName"
    let hasSite = _prefixId.prefix "hasSite"
    let hasSiteService = _prefixId.prefix "hasSiteService"
    let hasSpatialLocation = _prefixId.prefix "hasSpatialLocation"
    let hasTaxonomy = _prefixId.prefix "hasTaxonomy"
    let hasTelephone = _prefixId.prefix "hasTelephone"
    let isConfidential = _prefixId.prefix "isConfidential"
    let isLocatedInCity = _prefixId.prefix "isLocatedInCity"
    let isLocatedInCounty = _prefixId.prefix "isLocatedInCounty"
    let isLocatedInPostalCode = _prefixId.prefix "isLocatedInPostalCode"
    let isLocatedInState = _prefixId.prefix "isLocatedInState"
    let isLocatedWithinCountry = _prefixId.prefix "isLocatedWithinCountry"
    let lastActionType = _prefixId.prefix "lastActionType"
    let legalStatus = _prefixId.prefix "legalStatus"
    let licensedBy = _prefixId.prefix "licensedBy"
    let locatedAtCrossStreet = _prefixId.prefix "locatedAtCrossStreet"
    let mailingAddress = _prefixId.prefix "mailingAddress"
    let maximumAge = _prefixId.prefix "maximumAge"
    let minimumAge = _prefixId.prefix "minimumAge"
    let notAlwaysAvailable = _prefixId.prefix "notAlwaysAvailable"
    let offersService = _prefixId.prefix "offersService"
    let openHoursDescription = _prefixId.prefix "openHoursDescription"
    let opensAtTimes = _prefixId.prefix "opensAtTimes"
    let paymentMethodAccepted = _prefixId.prefix "paymentMethodAccepted"
    let physicalAddress = _prefixId.prefix "physicalAddress"
    let publicAccessToTransportation = _prefixId.prefix "publicAccessToTransportation"
    let recordOwner = _prefixId.prefix "recordOwner"
    /// <summary>
    ///   <para>dcterms:description : A description of documents that are required in order to access services offered at a SiteService.^^xsd:string</para>
    ///   <a href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiredDocumentation">airs:requiredDocumentation</a>
    /// </summary>
    let requiredDocumentation = _prefixId.prefix "requiredDocumentation"
    let requiresDocument = _prefixId.prefix "requiresDocument"
    let requiresFamily = _prefixId.prefix "requiresFamily"
    /// <summary>
    ///   <para>rdfs:comment : Information about any age or gender related requirements or inclusions for a particular service at a particular location.</para>
    ///   <a href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiresGender">airs:requiresGender</a>
    /// </summary>
    let requiresGender = _prefixId.prefix "requiresGender"
    /// <summary>
    ///   <para>rdfs:comment : General eligibility is a text area to list any eligibility requirements for participation or services. This can include any exclusions, both negative and positive requirements (i.e. must have/ can't have are all requirements)</para>
    ///   <a href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiresGeneralEligibility">airs:requiresGeneralEligibility</a>
    /// </summary>
    let requiresGeneralEligibility = _prefixId.prefix "requiresGeneralEligibility"
    let requiresIncome = _prefixId.prefix "requiresIncome"
    let requiresMaximumAge = _prefixId.prefix "requiresMaximumAge"
    let requiresMinimumAge = _prefixId.prefix "requiresMinimumAge"
    let requiresResidency = _prefixId.prefix "requiresResidency"
    let seasonal = _prefixId.prefix "seasonal"
    let servesGeographicArea = _prefixId.prefix "servesGeographicArea"
    let status = _prefixId.prefix "status"
    let structuresFees = _prefixId.prefix "structuresFees"
    let taxonomyCode = _prefixId.prefix "taxonomyCode"
    let taxonomyTerm = _prefixId.prefix "taxonomyTerm"
    let transportationServicesAccess = _prefixId.prefix "transportationServicesAccess"
    let yearIncorporated = _prefixId.prefix "yearIncorporated"

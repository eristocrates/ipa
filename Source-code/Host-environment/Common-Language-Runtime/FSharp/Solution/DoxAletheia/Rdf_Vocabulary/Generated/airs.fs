namespace https.raw.githubusercontent.com.airs_linked_data.lov.latest.src.airs_vocabulary.ttl.hash

open DoxAletheia.Rdf_Vocabulary

module airs =
    let _namespace_name =
        "https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#"

    /// <summary>
    /// This represents a referenceable street location of an item, using an addressing system other than geospatial terms, often with postal system terms.  airs:hasDescription is a description of the physical location or other information pertinent to this address, and hasExplanationForNoPhysicalAddress clarifies why the address doesn't have a physical presence.
    /// <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#Address"></see></summary>
    let Address = Namespaced_IRI.parse _namespace_name "Address" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#explanationForNoPhysicalAddess"></see>
    /// </summary>
    let explanationForNoPhysicalAddess =
        Namespaced_IRI.parse _namespace_name "explanationForNoPhysicalAddess" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#physicalAddress"></see>
    /// </summary>
    let physicalAddress =
        Namespaced_IRI.parse _namespace_name "physicalAddress" |> NamespacedName

    /// <summary>
    /// For property &lt;http://www.w3.org/2006/vcard/ns:hasRelated&gt;, it indicates the person within each agency who has overall responsibility for updating the information about the agency, its sites and its services, etc.
    /// <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#ResourceInfo"></see></summary>
    let ResourceInfo =
        Namespaced_IRI.parse _namespace_name "ResourceInfo" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasResourceInfo"></see>
    /// </summary>
    let hasResourceInfo =
        Namespaced_IRI.parse _namespace_name "hasResourceInfo" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#mailingAddress"></see>
    /// </summary>
    let mailingAddress =
        Namespaced_IRI.parse _namespace_name "mailingAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#AgeRequirement"></see>
    /// </summary>
    let AgeRequirement =
        Namespaced_IRI.parse _namespace_name "AgeRequirement" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#maximumAge"></see>
    /// </summary>
    let maximumAge = Namespaced_IRI.parse _namespace_name "maximumAge" |> NamespacedName
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#minimumAge"></see>
    /// </summary>
    let minimumAge = Namespaced_IRI.parse _namespace_name "minimumAge" |> NamespacedName
    /// <summary>
    /// Agencies are organizations that offer services at locations. Agencies provide services directly or they may have "child" agencies that offer these services. Services are offered at sites that belong to an agency. Services are represented by the combination of taxonomy codes offered at a location; this idea is called a SiteService. To recap: Agencies don't provide services directly, they provide them through sites. For property &lt;http://www.w3.org/2006/vcard/ns:hasRelated&gt; This represents the agency contact.  1) Contact is the person at an Agency, or Site who will interface with the public or who has responsibility for the entity, like a site manager or director.
    /// <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#Agency"></see></summary>
    let Agency = Namespaced_IRI.parse _namespace_name "Agency" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#yearIncorporated"></see>
    /// </summary>
    let yearIncorporated =
        Namespaced_IRI.parse _namespace_name "yearIncorporated" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#recordOwner"></see>
    /// </summary>
    let recordOwner =
        Namespaced_IRI.parse _namespace_name "recordOwner" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#AlternateName"></see>
    /// </summary>
    let AlternateName =
        Namespaced_IRI.parse _namespace_name "AlternateName" |> NamespacedName

    /// <summary>
    /// These are alternate names for an object. Confidential indicates that the alternate name won't be shared with the public.
    /// <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasAlternateName"></see></summary>
    let hasAlternateName =
        Namespaced_IRI.parse _namespace_name "hasAlternateName" |> NamespacedName

    /// <summary>
    /// A web location that has more information related to the SiteService, Agency, etc..  For example a facebook page for the Agency, that is supplementary to the Agency's main website.
    /// <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#InternetResource"></see></summary>
    let InternetResource =
        Namespaced_IRI.parse _namespace_name "InternetResource" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasInternetResource"></see>
    /// </summary>
    let hasInternetResource =
        Namespaced_IRI.parse _namespace_name "hasInternetResource" |> NamespacedName

    /// <summary>
    /// Groups together multiple Services that are related somehow.
    /// <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#ServiceGroup"></see></summary>
    let ServiceGroup =
        Namespaced_IRI.parse _namespace_name "ServiceGroup" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasServiceGroup"></see>
    /// </summary>
    let hasServiceGroup =
        Namespaced_IRI.parse _namespace_name "hasServiceGroup" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#excludedFromWebsite"></see>
    /// </summary>
    let excludedFromWebsite =
        Namespaced_IRI.parse _namespace_name "excludedFromWebsite" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#legalStatus"></see>
    /// </summary>
    let legalStatus =
        Namespaced_IRI.parse _namespace_name "legalStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#fein"></see>
    /// </summary>
    let fein = Namespaced_IRI.parse _namespace_name "fein" |> NamespacedName

    /// <summary>
    /// If applicable, information about the license type (dct:title)/accreditation held by the agency and the body that licensed/accredited it.
    /// <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#LicenseAccreditation"></see></summary>
    let LicenseAccreditation =
        Namespaced_IRI.parse _namespace_name "LicenseAccreditation" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasLicenseAccreditation"></see>
    /// </summary>
    let hasLicenseAccreditation =
        Namespaced_IRI.parse _namespace_name "hasLicenseAccreditation" |> NamespacedName

    /// <summary>
    /// Sites are physical locations or none physical locations (a website or hotline). Site is used for two purposes. First, it is used by Agency to provide the location of the agency in Agency.AgencyLocation (note this type of Site would never have any SiteService children). Second, sites are also the location where services are provided. This would be the Agency.Site element (note this type of Site would have SiteService children).
    /// <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#Site"></see></summary>
    let Site = Namespaced_IRI.parse _namespace_name "Site" |> NamespacedName
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasSite"></see>
    /// </summary>
    let hasSite = Namespaced_IRI.parse _namespace_name "hasSite" |> NamespacedName
    /// <summary>
    /// Akin to a "Program", as in for example "a homeless outreach program".  Can be delivered at many "airs:Site[s]", and the nexus of the two is an airs:SiteService
    /// <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#Service"></see></summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#offersService"></see>
    /// </summary>
    let offersService =
        Namespaced_IRI.parse _namespace_name "offersService" |> NamespacedName

    /// <summary>
    /// ApplicationProcess describes the steps taken to apply for or access the service; also known as the 'intake process'. For example, "Call for an appointment" or "Walk in only".
    /// <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#ApplicationProcess"></see></summary>
    let ApplicationProcess =
        Namespaced_IRI.parse _namespace_name "ApplicationProcess" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#Document"></see>
    /// </summary>
    let Document = Namespaced_IRI.parse _namespace_name "Document" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#GenderRequirement"></see>
    /// </summary>
    let GenderRequirement =
        Namespaced_IRI.parse _namespace_name "GenderRequirement" |> NamespacedName

    /// <summary>
    /// Languages offered, and available times, at the SiteService
    /// <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#LanguageAvailability"></see></summary>
    let LanguageAvailability =
        Namespaced_IRI.parse _namespace_name "LanguageAvailability" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasLanguageTimeOpen"></see>
    /// </summary>
    let hasLanguageTimeOpen =
        Namespaced_IRI.parse _namespace_name "hasLanguageTimeOpen" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#licensedBy"></see>
    /// </summary>
    let licensedBy = Namespaced_IRI.parse _namespace_name "licensedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#lastActionType"></see>
    /// </summary>
    let lastActionType =
        Namespaced_IRI.parse _namespace_name "lastActionType" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#availableForReferral"></see>
    /// </summary>
    let availableForReferral =
        Namespaced_IRI.parse _namespace_name "availableForReferral" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#dateOfLastAction"></see>
    /// </summary>
    let dateOfLastAction =
        Namespaced_IRI.parse _namespace_name "dateOfLastAction" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#availableForDirectory"></see>
    /// </summary>
    let availableForDirectory =
        Namespaced_IRI.parse _namespace_name "availableForDirectory" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#dateLastVerified"></see>
    /// </summary>
    let dateLastVerified =
        Namespaced_IRI.parse _namespace_name "dateLastVerified" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#attributesResourceSpecialist"></see>
    /// </summary>
    let attributesResourceSpecialist =
        Namespaced_IRI.parse _namespace_name "attributesResourceSpecialist" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#availableForResearch"></see>
    /// </summary>
    let availableForResearch =
        Namespaced_IRI.parse _namespace_name "availableForResearch" |> NamespacedName

    /// <summary>
    /// Activities that are only offered a certain time of year, such as seasonal tax preparation, summer camps and holiday meals.
    /// <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#Seasonal"></see></summary>
    let Seasonal = Namespaced_IRI.parse _namespace_name "Seasonal" |> NamespacedName
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#seasonal"></see>
    /// </summary>
    let seasonal = Namespaced_IRI.parse _namespace_name "seasonal" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasSeasonalSchedule"></see>
    /// </summary>
    let hasSeasonalSchedule =
        Namespaced_IRI.parse _namespace_name "hasSeasonalSchedule" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasAgency"></see>
    /// </summary>
    let hasAgency = Namespaced_IRI.parse _namespace_name "hasAgency" |> NamespacedName
    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#status"></see>
    /// </summary>
    let status = Namespaced_IRI.parse _namespace_name "status" |> NamespacedName

    /// <summary>
    /// SiteService is the smallest unit describing a "service" that is offered at a Site. It can be thought of as the intersection of a Site and a Taxonomy code (or related Taxonomy codes) and meta data about what is offered. A "Service" however is not represented as its own element because the "Service" cannot exist without a location (the site).
    /// <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#SiteService"></see></summary>
    let SiteService =
        Namespaced_IRI.parse _namespace_name "SiteService" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasSiteService"></see>
    /// </summary>
    let hasSiteService =
        Namespaced_IRI.parse _namespace_name "hasSiteService" |> NamespacedName

    /// <summary>
    /// This is the geographic area served by the SiteService. This can be anything from a single neighborhood to an entire country. Types can also be mixed; perhaps one city and 6 nearby ZIP codes. In this case the required element would be City and there would be additional ZIP codes. A national 1-800 hotline would have one Country element.
    /// <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#ServiceArea"></see></summary>
    let ServiceArea =
        Namespaced_IRI.parse _namespace_name "ServiceArea" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#censusTract"></see>
    /// </summary>
    let censusTract =
        Namespaced_IRI.parse _namespace_name "censusTract" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#servesGeographicArea"></see>
    /// </summary>
    let servesGeographicArea =
        Namespaced_IRI.parse _namespace_name "servesGeographicArea" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasAddress"></see>
    /// </summary>
    let hasAddress = Namespaced_IRI.parse _namespace_name "hasAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#disabilitiesAccess"></see>
    /// </summary>
    let disabilitiesAccess =
        Namespaced_IRI.parse _namespace_name "disabilitiesAccess" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#transportationServicesAccess"></see>
    /// </summary>
    let transportationServicesAccess =
        Namespaced_IRI.parse _namespace_name "transportationServicesAccess" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#directions"></see>
    /// </summary>
    let directions = Namespaced_IRI.parse _namespace_name "directions" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#openHoursDescription"></see>
    /// </summary>
    let openHoursDescription =
        Namespaced_IRI.parse _namespace_name "openHoursDescription" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasSpatialLocation"></see>
    /// </summary>
    let hasSpatialLocation =
        Namespaced_IRI.parse _namespace_name "hasSpatialLocation" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#locatedAtCrossStreet"></see>
    /// </summary>
    let locatedAtCrossStreet =
        Namespaced_IRI.parse _namespace_name "locatedAtCrossStreet" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#opensAtTimes"></see>
    /// </summary>
    let opensAtTimes =
        Namespaced_IRI.parse _namespace_name "opensAtTimes" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#paymentMethodAccepted"></see>
    /// </summary>
    let paymentMethodAccepted =
        Namespaced_IRI.parse _namespace_name "paymentMethodAccepted" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasApplicationProcess"></see>
    /// </summary>
    let hasApplicationProcess =
        Namespaced_IRI.parse _namespace_name "hasApplicationProcess" |> NamespacedName

    /// <summary>
    /// General eligibility is a text area to list any eligibility requirements for participation or services. This can include any exclusions, both negative and positive requirements (i.e. must have/ can't have are all requirements)
    /// <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiresGeneralEligibility"></see></summary>
    let requiresGeneralEligibility =
        Namespaced_IRI.parse _namespace_name "requiresGeneralEligibility" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasGenderRequirement"></see>
    /// </summary>
    let hasGenderRequirement =
        Namespaced_IRI.parse _namespace_name "hasGenderRequirement" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#structuresFees"></see>
    /// </summary>
    let structuresFees =
        Namespaced_IRI.parse _namespace_name "structuresFees" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#notAlwaysAvailable"></see>
    /// </summary>
    let notAlwaysAvailable =
        Namespaced_IRI.parse _namespace_name "notAlwaysAvailable" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiredDocumentation"></see>
    /// </summary>
    let requiredDocumentation =
        Namespaced_IRI.parse _namespace_name "requiredDocumentation" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#Taxonomy"></see>
    /// </summary>
    let Taxonomy = Namespaced_IRI.parse _namespace_name "Taxonomy" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#taxonomyCode"></see>
    /// </summary>
    let taxonomyCode =
        Namespaced_IRI.parse _namespace_name "taxonomyCode" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#taxonomyTerm"></see>
    /// </summary>
    let taxonomyTerm =
        Namespaced_IRI.parse _namespace_name "taxonomyTerm" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#describesInternetResource"></see>
    /// </summary>
    let describesInternetResource =
        Namespaced_IRI.parse _namespace_name "describesInternetResource" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#explainsNoPhysicalAddress"></see>
    /// </summary>
    let explainsNoPhysicalAddress =
        Namespaced_IRI.parse _namespace_name "explainsNoPhysicalAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasAreaDefinition"></see>
    /// </summary>
    let hasAreaDefinition =
        Namespaced_IRI.parse _namespace_name "hasAreaDefinition" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasDateAdded"></see>
    /// </summary>
    let hasDateAdded =
        Namespaced_IRI.parse _namespace_name "hasDateAdded" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasDescription"></see>
    /// </summary>
    let hasDescription =
        Namespaced_IRI.parse _namespace_name "hasDescription" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasIRSStatus"></see>
    /// </summary>
    let hasIRSStatus =
        Namespaced_IRI.parse _namespace_name "hasIRSStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasLicenseType"></see>
    /// </summary>
    let hasLicenseType =
        Namespaced_IRI.parse _namespace_name "hasLicenseType" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasProgramName"></see>
    /// </summary>
    let hasProgramName =
        Namespaced_IRI.parse _namespace_name "hasProgramName" |> NamespacedName

    /// <summary>
    /// Use this if the address can not be shared due to security concerns, such as an assaulted women's shelter. While it is possible to code an address as Confidential="true", in this case the address is so confidential that it won't be shared at all.
    /// <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasReasonAddressWithheld"></see></summary>
    let hasReasonAddressWithheld =
        Namespaced_IRI.parse _namespace_name "hasReasonAddressWithheld" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasServiceGroupName"></see>
    /// </summary>
    let hasServiceGroupName =
        Namespaced_IRI.parse _namespace_name "hasServiceGroupName" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasTaxonomy"></see>
    /// </summary>
    let hasTaxonomy =
        Namespaced_IRI.parse _namespace_name "hasTaxonomy" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasTelephone"></see>
    /// </summary>
    let hasTelephone =
        Namespaced_IRI.parse _namespace_name "hasTelephone" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#isConfidential"></see>
    /// </summary>
    let isConfidential =
        Namespaced_IRI.parse _namespace_name "isConfidential" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#isLocatedInCity"></see>
    /// </summary>
    let isLocatedInCity =
        Namespaced_IRI.parse _namespace_name "isLocatedInCity" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#isLocatedInCounty"></see>
    /// </summary>
    let isLocatedInCounty =
        Namespaced_IRI.parse _namespace_name "isLocatedInCounty" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#isLocatedInPostalCode"></see>
    /// </summary>
    let isLocatedInPostalCode =
        Namespaced_IRI.parse _namespace_name "isLocatedInPostalCode" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#isLocatedInState"></see>
    /// </summary>
    let isLocatedInState =
        Namespaced_IRI.parse _namespace_name "isLocatedInState" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#isLocatedWithinCountry"></see>
    /// </summary>
    let isLocatedWithinCountry =
        Namespaced_IRI.parse _namespace_name "isLocatedWithinCountry" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#publicAccessToTransportation"></see>
    /// </summary>
    let publicAccessToTransportation =
        Namespaced_IRI.parse _namespace_name "publicAccessToTransportation" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiresDocument"></see>
    /// </summary>
    let requiresDocument =
        Namespaced_IRI.parse _namespace_name "requiresDocument" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiresFamily"></see>
    /// </summary>
    let requiresFamily =
        Namespaced_IRI.parse _namespace_name "requiresFamily" |> NamespacedName

    /// <summary>
    /// Information about any age or gender related requirements or inclusions for a particular service at a particular location.
    /// <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiresGender"></see></summary>
    let requiresGender =
        Namespaced_IRI.parse _namespace_name "requiresGender" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiresIncome"></see>
    /// </summary>
    let requiresIncome =
        Namespaced_IRI.parse _namespace_name "requiresIncome" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiresMaximumAge"></see>
    /// </summary>
    let requiresMaximumAge =
        Namespaced_IRI.parse _namespace_name "requiresMaximumAge" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiresMinimumAge"></see>
    /// </summary>
    let requiresMinimumAge =
        Namespaced_IRI.parse _namespace_name "requiresMinimumAge" |> NamespacedName

    /// <summary>
    ///   <see href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiresResidency"></see>
    /// </summary>
    let requiresResidency =
        Namespaced_IRI.parse _namespace_name "requiresResidency" |> NamespacedName

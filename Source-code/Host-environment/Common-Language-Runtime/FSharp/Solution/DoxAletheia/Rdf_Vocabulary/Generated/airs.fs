namespace https.raw.githubusercontent.com.airs_linked_data.lov.latest.src.airs_vocabulary.ttl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module airs =
    let _namespace_iri = Namespace_Iri airs |> NamespaceIRI
    /// <summary>
    ///   <para>airs:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#</seealso>
    let _prefix_iri = Prefixed_Name(airs, "") |> PrefixedName
    /// <summary>
    ///   <para>airs:Address</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This represents a referenceable street location of an item, using an addressing system other than geospatial terms, often with postal system terms.  airs:hasDescription is a description of the physical location or other information pertinent to this address, and hasExplanationForNoPhysicalAddress clarifies why the address doesn't have a physical presence."</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#Address">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#Address</seealso>
    let Address = Prefixed_Name(airs, "Address") |> PrefixedName
    /// <summary>
    ///   <para>airs:AgeRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#AgeRequirement">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#AgeRequirement</seealso>
    let AgeRequirement = Prefixed_Name(airs, "AgeRequirement") |> PrefixedName
    /// <summary>
    ///   <para>airs:Agency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Agencies are organizations that offer services at locations. Agencies provide services directly or they may have "child" agencies that offer these services. Services are offered at sites that belong to an agency. Services are represented by the combination of taxonomy codes offered at a location; this idea is called a SiteService. To recap: Agencies don't provide services directly, they provide them through sites. For property &lt;http://www.w3.org/2006/vcard/ns:hasRelated&gt; This represents the agency contact.  1) Contact is the person at an Agency, or Site who will interface with the public or who has responsibility for the entity, like a site manager or director."</para>
    /// labels<para>"Agency"</para><para>"Agencia"</para><para>"Agence"</para></remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#Agency">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#Agency</seealso>
    let Agency = Prefixed_Name(airs, "Agency") |> PrefixedName
    /// <summary>
    ///   <para>airs:AlternateName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#AlternateName">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#AlternateName</seealso>
    let AlternateName = Prefixed_Name(airs, "AlternateName") |> PrefixedName
    /// <summary>
    ///   <para>airs:ApplicationProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ApplicationProcess describes the steps taken to apply for or access the service; also known as the 'intake process'. For example, "Call for an appointment" or "Walk in only"."</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#ApplicationProcess">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#ApplicationProcess</seealso>
    let ApplicationProcess = Prefixed_Name(airs, "ApplicationProcess") |> PrefixedName
    /// <summary>
    ///   <para>airs:Document</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#Document">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#Document</seealso>
    let Document = Prefixed_Name(airs, "Document") |> PrefixedName
    /// <summary>
    ///   <para>airs:GenderRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#GenderRequirement">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#GenderRequirement</seealso>
    let GenderRequirement = Prefixed_Name(airs, "GenderRequirement") |> PrefixedName
    /// <summary>
    ///   <para>airs:InternetResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A web location that has more information related to the SiteService, Agency, etc..  For example a facebook page for the Agency, that is supplementary to the Agency's main website."</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#InternetResource">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#InternetResource</seealso>
    let InternetResource = Prefixed_Name(airs, "InternetResource") |> PrefixedName

    /// <summary>
    ///   <para>airs:LanguageAvailability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Languages offered, and available times, at the SiteService"</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#LanguageAvailability">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#LanguageAvailability</seealso>
    let LanguageAvailability =
        Prefixed_Name(airs, "LanguageAvailability") |> PrefixedName

    /// <summary>
    ///   <para>airs:LicenseAccreditation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"If applicable, information about the license type (dct:title)/accreditation held by the agency and the body that licensed/accredited it."</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#LicenseAccreditation">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#LicenseAccreditation</seealso>
    let LicenseAccreditation =
        Prefixed_Name(airs, "LicenseAccreditation") |> PrefixedName

    /// <summary>
    ///   <para>airs:ResourceInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"For property &lt;http://www.w3.org/2006/vcard/ns:hasRelated&gt;, it indicates the person within each agency who has overall responsibility for updating the information about the agency, its sites and its services, etc."</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#ResourceInfo">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#ResourceInfo</seealso>
    let ResourceInfo = Prefixed_Name(airs, "ResourceInfo") |> PrefixedName
    /// <summary>
    ///   <para>airs:Seasonal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Activities that are only offered a certain time of year, such as seasonal tax preparation, summer camps and holiday meals."</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#Seasonal">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#Seasonal</seealso>
    let Seasonal = Prefixed_Name(airs, "Seasonal") |> PrefixedName
    /// <summary>
    ///   <para>airs:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Akin to a "Program", as in for example "a homeless outreach program".  Can be delivered at many "airs:Site[s]", and the nexus of the two is an airs:SiteService"</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#Service">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#Service</seealso>
    let Service = Prefixed_Name(airs, "Service") |> PrefixedName
    /// <summary>
    ///   <para>airs:ServiceArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This is the geographic area served by the SiteService. This can be anything from a single neighborhood to an entire country. Types can also be mixed; perhaps one city and 6 nearby ZIP codes. In this case the required element would be City and there would be additional ZIP codes. A national 1-800 hotline would have one Country element."</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#ServiceArea">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#ServiceArea</seealso>
    let ServiceArea = Prefixed_Name(airs, "ServiceArea") |> PrefixedName
    /// <summary>
    ///   <para>airs:ServiceGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Groups together multiple Services that are related somehow."</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#ServiceGroup">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#ServiceGroup</seealso>
    let ServiceGroup = Prefixed_Name(airs, "ServiceGroup") |> PrefixedName
    /// <summary>
    ///   <para>airs:Site</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:Class</para>
    ///   <para>"Sites are physical locations or none physical locations (a website or hotline). Site is used for two purposes. First, it is used by Agency to provide the location of the agency in Agency.AgencyLocation (note this type of Site would never have any SiteService children). Second, sites are also the location where services are provided. This would be the Agency.Site element (note this type of Site would have SiteService children)."</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#Site">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#Site</seealso>
    let Site = Prefixed_Name(airs, "Site") |> PrefixedName
    /// <summary>
    ///   <para>airs:SiteService</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:Class</para>
    ///   <para>"SiteService is the smallest unit describing a "service" that is offered at a Site. It can be thought of as the intersection of a Site and a Taxonomy code (or related Taxonomy codes) and meta data about what is offered. A "Service" however is not represented as its own element because the "Service" cannot exist without a location (the site)."</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#SiteService">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#SiteService</seealso>
    let SiteService = Prefixed_Name(airs, "SiteService") |> PrefixedName
    /// <summary>
    ///   <para>airs:Taxonomy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#Taxonomy">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#Taxonomy</seealso>
    let Taxonomy = Prefixed_Name(airs, "Taxonomy") |> PrefixedName

    /// <summary>
    ///   <para>airs:attributesResourceSpecialist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#attributesResourceSpecialist">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#attributesResourceSpecialist</seealso>
    let attributesResourceSpecialist =
        Prefixed_Name(airs, "attributesResourceSpecialist") |> PrefixedName

    /// <summary>
    ///   <para>airs:availableForDirectory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#availableForDirectory">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#availableForDirectory</seealso>
    let availableForDirectory =
        Prefixed_Name(airs, "availableForDirectory") |> PrefixedName

    /// <summary>
    ///   <para>airs:availableForReferral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#availableForReferral">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#availableForReferral</seealso>
    let availableForReferral =
        Prefixed_Name(airs, "availableForReferral") |> PrefixedName

    /// <summary>
    ///   <para>airs:availableForResearch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#availableForResearch">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#availableForResearch</seealso>
    let availableForResearch =
        Prefixed_Name(airs, "availableForResearch") |> PrefixedName

    /// <summary>
    ///   <para>airs:censusTract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#censusTract">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#censusTract</seealso>
    let censusTract = Prefixed_Name(airs, "censusTract") |> PrefixedName
    /// <summary>
    ///   <para>airs:dateLastVerified</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#dateLastVerified">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#dateLastVerified</seealso>
    let dateLastVerified = Prefixed_Name(airs, "dateLastVerified") |> PrefixedName
    /// <summary>
    ///   <para>airs:dateOfLastAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#dateOfLastAction">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#dateOfLastAction</seealso>
    let dateOfLastAction = Prefixed_Name(airs, "dateOfLastAction") |> PrefixedName

    /// <summary>
    ///   <para>airs:describesInternetResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#describesInternetResource">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#describesInternetResource</seealso>
    let describesInternetResource =
        Prefixed_Name(airs, "describesInternetResource") |> PrefixedName

    /// <summary>
    ///   <para>airs:directions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#directions">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#directions</seealso>
    let directions = Prefixed_Name(airs, "directions") |> PrefixedName
    /// <summary>
    ///   <para>airs:disabilitiesAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#disabilitiesAccess">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#disabilitiesAccess</seealso>
    let disabilitiesAccess = Prefixed_Name(airs, "disabilitiesAccess") |> PrefixedName
    /// <summary>
    ///   <para>airs:excludedFromWebsite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#excludedFromWebsite">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#excludedFromWebsite</seealso>
    let excludedFromWebsite = Prefixed_Name(airs, "excludedFromWebsite") |> PrefixedName

    /// <summary>
    ///   <para>airs:explainsNoPhysicalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#explainsNoPhysicalAddress">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#explainsNoPhysicalAddress</seealso>
    let explainsNoPhysicalAddress =
        Prefixed_Name(airs, "explainsNoPhysicalAddress") |> PrefixedName

    /// <summary>
    ///   <para>airs:explanationForNoPhysicalAddess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#explanationForNoPhysicalAddess">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#explanationForNoPhysicalAddess</seealso>
    let explanationForNoPhysicalAddess =
        Prefixed_Name(airs, "explanationForNoPhysicalAddess") |> PrefixedName

    /// <summary>
    ///   <para>airs:fein</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#fein">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#fein</seealso>
    let fein = Prefixed_Name(airs, "fein") |> PrefixedName
    /// <summary>
    ///   <para>airs:hasAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasAddress">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasAddress</seealso>
    let hasAddress = Prefixed_Name(airs, "hasAddress") |> PrefixedName
    /// <summary>
    ///   <para>airs:hasAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasAgency">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasAgency</seealso>
    let hasAgency = Prefixed_Name(airs, "hasAgency") |> PrefixedName
    /// <summary>
    ///   <para>airs:hasAlternateName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"These are alternate names for an object. Confidential indicates that the alternate name won't be shared with the public."</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasAlternateName">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasAlternateName</seealso>
    let hasAlternateName = Prefixed_Name(airs, "hasAlternateName") |> PrefixedName

    /// <summary>
    ///   <para>airs:hasApplicationProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasApplicationProcess">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasApplicationProcess</seealso>
    let hasApplicationProcess =
        Prefixed_Name(airs, "hasApplicationProcess") |> PrefixedName

    /// <summary>
    ///   <para>airs:hasAreaDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasAreaDefinition">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasAreaDefinition</seealso>
    let hasAreaDefinition = Prefixed_Name(airs, "hasAreaDefinition") |> PrefixedName
    /// <summary>
    ///   <para>airs:hasDateAdded</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasDateAdded">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasDateAdded</seealso>
    let hasDateAdded = Prefixed_Name(airs, "hasDateAdded") |> PrefixedName
    /// <summary>
    ///   <para>airs:hasDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasDescription">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasDescription</seealso>
    let hasDescription = Prefixed_Name(airs, "hasDescription") |> PrefixedName

    /// <summary>
    ///   <para>airs:hasGenderRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasGenderRequirement">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasGenderRequirement</seealso>
    let hasGenderRequirement =
        Prefixed_Name(airs, "hasGenderRequirement") |> PrefixedName

    /// <summary>
    ///   <para>airs:hasIRSStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasIRSStatus">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasIRSStatus</seealso>
    let hasIRSStatus = Prefixed_Name(airs, "hasIRSStatus") |> PrefixedName
    /// <summary>
    ///   <para>airs:hasInternetResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasInternetResource">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasInternetResource</seealso>
    let hasInternetResource = Prefixed_Name(airs, "hasInternetResource") |> PrefixedName
    /// <summary>
    ///   <para>airs:hasLanguageTimeOpen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasLanguageTimeOpen">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasLanguageTimeOpen</seealso>
    let hasLanguageTimeOpen = Prefixed_Name(airs, "hasLanguageTimeOpen") |> PrefixedName

    /// <summary>
    ///   <para>airs:hasLicenseAccreditation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasLicenseAccreditation">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasLicenseAccreditation</seealso>
    let hasLicenseAccreditation =
        Prefixed_Name(airs, "hasLicenseAccreditation") |> PrefixedName

    /// <summary>
    ///   <para>airs:hasLicenseType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasLicenseType">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasLicenseType</seealso>
    let hasLicenseType = Prefixed_Name(airs, "hasLicenseType") |> PrefixedName
    /// <summary>
    ///   <para>airs:hasProgramName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasProgramName">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasProgramName</seealso>
    let hasProgramName = Prefixed_Name(airs, "hasProgramName") |> PrefixedName

    /// <summary>
    ///   <para>airs:hasReasonAddressWithheld</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Use this if the address can not be shared due to security concerns, such as an assaulted women's shelter. While it is possible to code an address as Confidential="true", in this case the address is so confidential that it won't be shared at all."</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasReasonAddressWithheld">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasReasonAddressWithheld</seealso>
    let hasReasonAddressWithheld =
        Prefixed_Name(airs, "hasReasonAddressWithheld") |> PrefixedName

    /// <summary>
    ///   <para>airs:hasResourceInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasResourceInfo">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasResourceInfo</seealso>
    let hasResourceInfo = Prefixed_Name(airs, "hasResourceInfo") |> PrefixedName
    /// <summary>
    ///   <para>airs:hasSeasonalSchedule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasSeasonalSchedule">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasSeasonalSchedule</seealso>
    let hasSeasonalSchedule = Prefixed_Name(airs, "hasSeasonalSchedule") |> PrefixedName
    /// <summary>
    ///   <para>airs:hasServiceGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasServiceGroup">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasServiceGroup</seealso>
    let hasServiceGroup = Prefixed_Name(airs, "hasServiceGroup") |> PrefixedName
    /// <summary>
    ///   <para>airs:hasServiceGroupName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasServiceGroupName">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasServiceGroupName</seealso>
    let hasServiceGroupName = Prefixed_Name(airs, "hasServiceGroupName") |> PrefixedName
    /// <summary>
    ///   <para>airs:hasSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasSite">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasSite</seealso>
    let hasSite = Prefixed_Name(airs, "hasSite") |> PrefixedName
    /// <summary>
    ///   <para>airs:hasSiteService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasSiteService">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasSiteService</seealso>
    let hasSiteService = Prefixed_Name(airs, "hasSiteService") |> PrefixedName
    /// <summary>
    ///   <para>airs:hasSpatialLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasSpatialLocation">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasSpatialLocation</seealso>
    let hasSpatialLocation = Prefixed_Name(airs, "hasSpatialLocation") |> PrefixedName
    /// <summary>
    ///   <para>airs:hasTaxonomy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasTaxonomy">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasTaxonomy</seealso>
    let hasTaxonomy = Prefixed_Name(airs, "hasTaxonomy") |> PrefixedName
    /// <summary>
    ///   <para>airs:hasTelephone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasTelephone">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#hasTelephone</seealso>
    let hasTelephone = Prefixed_Name(airs, "hasTelephone") |> PrefixedName
    /// <summary>
    ///   <para>airs:isConfidential</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#isConfidential">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#isConfidential</seealso>
    let isConfidential = Prefixed_Name(airs, "isConfidential") |> PrefixedName
    /// <summary>
    ///   <para>airs:isLocatedInCity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#isLocatedInCity">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#isLocatedInCity</seealso>
    let isLocatedInCity = Prefixed_Name(airs, "isLocatedInCity") |> PrefixedName
    /// <summary>
    ///   <para>airs:isLocatedInCounty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#isLocatedInCounty">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#isLocatedInCounty</seealso>
    let isLocatedInCounty = Prefixed_Name(airs, "isLocatedInCounty") |> PrefixedName

    /// <summary>
    ///   <para>airs:isLocatedInPostalCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#isLocatedInPostalCode">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#isLocatedInPostalCode</seealso>
    let isLocatedInPostalCode =
        Prefixed_Name(airs, "isLocatedInPostalCode") |> PrefixedName

    /// <summary>
    ///   <para>airs:isLocatedInState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#isLocatedInState">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#isLocatedInState</seealso>
    let isLocatedInState = Prefixed_Name(airs, "isLocatedInState") |> PrefixedName

    /// <summary>
    ///   <para>airs:isLocatedWithinCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#isLocatedWithinCountry">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#isLocatedWithinCountry</seealso>
    let isLocatedWithinCountry =
        Prefixed_Name(airs, "isLocatedWithinCountry") |> PrefixedName

    /// <summary>
    ///   <para>airs:lastActionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#lastActionType">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#lastActionType</seealso>
    let lastActionType = Prefixed_Name(airs, "lastActionType") |> PrefixedName
    /// <summary>
    ///   <para>airs:legalStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#legalStatus">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#legalStatus</seealso>
    let legalStatus = Prefixed_Name(airs, "legalStatus") |> PrefixedName
    /// <summary>
    ///   <para>airs:licensedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#licensedBy">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#licensedBy</seealso>
    let licensedBy = Prefixed_Name(airs, "licensedBy") |> PrefixedName

    /// <summary>
    ///   <para>airs:locatedAtCrossStreet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#locatedAtCrossStreet">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#locatedAtCrossStreet</seealso>
    let locatedAtCrossStreet =
        Prefixed_Name(airs, "locatedAtCrossStreet") |> PrefixedName

    /// <summary>
    ///   <para>airs:mailingAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#mailingAddress">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#mailingAddress</seealso>
    let mailingAddress = Prefixed_Name(airs, "mailingAddress") |> PrefixedName
    /// <summary>
    ///   <para>airs:maximumAge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#maximumAge">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#maximumAge</seealso>
    let maximumAge = Prefixed_Name(airs, "maximumAge") |> PrefixedName
    /// <summary>
    ///   <para>airs:minimumAge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#minimumAge">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#minimumAge</seealso>
    let minimumAge = Prefixed_Name(airs, "minimumAge") |> PrefixedName
    /// <summary>
    ///   <para>airs:notAlwaysAvailable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#notAlwaysAvailable">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#notAlwaysAvailable</seealso>
    let notAlwaysAvailable = Prefixed_Name(airs, "notAlwaysAvailable") |> PrefixedName
    /// <summary>
    ///   <para>airs:offersService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#offersService">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#offersService</seealso>
    let offersService = Prefixed_Name(airs, "offersService") |> PrefixedName

    /// <summary>
    ///   <para>airs:openHoursDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#openHoursDescription">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#openHoursDescription</seealso>
    let openHoursDescription =
        Prefixed_Name(airs, "openHoursDescription") |> PrefixedName

    /// <summary>
    ///   <para>airs:opensAtTimes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#opensAtTimes">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#opensAtTimes</seealso>
    let opensAtTimes = Prefixed_Name(airs, "opensAtTimes") |> PrefixedName

    /// <summary>
    ///   <para>airs:paymentMethodAccepted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#paymentMethodAccepted">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#paymentMethodAccepted</seealso>
    let paymentMethodAccepted =
        Prefixed_Name(airs, "paymentMethodAccepted") |> PrefixedName

    /// <summary>
    ///   <para>airs:physicalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#physicalAddress">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#physicalAddress</seealso>
    let physicalAddress = Prefixed_Name(airs, "physicalAddress") |> PrefixedName

    /// <summary>
    ///   <para>airs:publicAccessToTransportation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#publicAccessToTransportation">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#publicAccessToTransportation</seealso>
    let publicAccessToTransportation =
        Prefixed_Name(airs, "publicAccessToTransportation") |> PrefixedName

    /// <summary>
    ///   <para>airs:recordOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#recordOwner">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#recordOwner</seealso>
    let recordOwner = Prefixed_Name(airs, "recordOwner") |> PrefixedName

    /// <summary>
    ///   <para>airs:requiredDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiredDocumentation">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiredDocumentation</seealso>
    let requiredDocumentation =
        Prefixed_Name(airs, "requiredDocumentation") |> PrefixedName

    /// <summary>
    ///   <para>airs:requiresDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiresDocument">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiresDocument</seealso>
    let requiresDocument = Prefixed_Name(airs, "requiresDocument") |> PrefixedName
    /// <summary>
    ///   <para>airs:requiresFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiresFamily">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiresFamily</seealso>
    let requiresFamily = Prefixed_Name(airs, "requiresFamily") |> PrefixedName
    /// <summary>
    ///   <para>airs:requiresGender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Information about any age or gender related requirements or inclusions for a particular service at a particular location."</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiresGender">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiresGender</seealso>
    let requiresGender = Prefixed_Name(airs, "requiresGender") |> PrefixedName

    /// <summary>
    ///   <para>airs:requiresGeneralEligibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"General eligibility is a text area to list any eligibility requirements for participation or services. This can include any exclusions, both negative and positive requirements (i.e. must have/ can't have are all requirements)"</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiresGeneralEligibility">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiresGeneralEligibility</seealso>
    let requiresGeneralEligibility =
        Prefixed_Name(airs, "requiresGeneralEligibility") |> PrefixedName

    /// <summary>
    ///   <para>airs:requiresIncome</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiresIncome">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiresIncome</seealso>
    let requiresIncome = Prefixed_Name(airs, "requiresIncome") |> PrefixedName
    /// <summary>
    ///   <para>airs:requiresMaximumAge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiresMaximumAge">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiresMaximumAge</seealso>
    let requiresMaximumAge = Prefixed_Name(airs, "requiresMaximumAge") |> PrefixedName
    /// <summary>
    ///   <para>airs:requiresMinimumAge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiresMinimumAge">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiresMinimumAge</seealso>
    let requiresMinimumAge = Prefixed_Name(airs, "requiresMinimumAge") |> PrefixedName
    /// <summary>
    ///   <para>airs:requiresResidency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiresResidency">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#requiresResidency</seealso>
    let requiresResidency = Prefixed_Name(airs, "requiresResidency") |> PrefixedName
    /// <summary>
    ///   <para>airs:seasonal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#seasonal">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#seasonal</seealso>
    let seasonal = Prefixed_Name(airs, "seasonal") |> PrefixedName

    /// <summary>
    ///   <para>airs:servesGeographicArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#servesGeographicArea">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#servesGeographicArea</seealso>
    let servesGeographicArea =
        Prefixed_Name(airs, "servesGeographicArea") |> PrefixedName

    /// <summary>
    ///   <para>airs:status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#status">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#status</seealso>
    let status = Prefixed_Name(airs, "status") |> PrefixedName
    /// <summary>
    ///   <para>airs:structuresFees</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#structuresFees">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#structuresFees</seealso>
    let structuresFees = Prefixed_Name(airs, "structuresFees") |> PrefixedName
    /// <summary>
    ///   <para>airs:taxonomyCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#taxonomyCode">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#taxonomyCode</seealso>
    let taxonomyCode = Prefixed_Name(airs, "taxonomyCode") |> PrefixedName
    /// <summary>
    ///   <para>airs:taxonomyTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#taxonomyTerm">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#taxonomyTerm</seealso>
    let taxonomyTerm = Prefixed_Name(airs, "taxonomyTerm") |> PrefixedName

    /// <summary>
    ///   <para>airs:transportationServicesAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#transportationServicesAccess">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#transportationServicesAccess</seealso>
    let transportationServicesAccess =
        Prefixed_Name(airs, "transportationServicesAccess") |> PrefixedName

    /// <summary>
    ///   <para>airs:yearIncorporated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#yearIncorporated">https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#yearIncorporated</seealso>
    let yearIncorporated = Prefixed_Name(airs, "yearIncorporated") |> PrefixedName

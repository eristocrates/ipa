namespace http.purl.org.onto_ocds.ocds.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ocds =
    let _namespace_iri = Namespace_Iri ocds |> NamespaceIRI
    /// <summary>
    ///   <para>ocds:Award</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An award for the given procurement. There may be more than one award per contracting process e.g. because the contract is split amongst different providers, or because it is a standing offer.</para>
    /// labels<para>Award</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#Award">http://purl.org/onto-ocds/ocds#Award</seealso>
    let Award = Prefixed_Name(ocds, "Award") |> PrefixedName
    /// <summary>
    ///   <para>ocds:Change</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Change</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#Change">http://purl.org/onto-ocds/ocds#Change</seealso>
    let Change = Prefixed_Name(ocds, "Change") |> PrefixedName
    /// <summary>
    ///   <para>ocds:Classification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Classification</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#Classification">http://purl.org/onto-ocds/ocds#Classification</seealso>
    let Classification = Prefixed_Name(ocds, "Classification") |> PrefixedName
    /// <summary>
    ///   <para>ocds:contactPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Contact point</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#contactPoint">http://purl.org/onto-ocds/ocds#contactPoint</seealso>
    let contactPoint = Prefixed_Name(ocds, "contactPoint") |> PrefixedName
    /// <summary>
    ///   <para>ocds:contactPointName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The name of the contact person, department, or contact point, for correspondence relating to this contracting process.</para>
    /// labels<para>Contact point name</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#contactPointName">http://purl.org/onto-ocds/ocds#contactPointName</seealso>
    let contactPointName = Prefixed_Name(ocds, "contactPointName") |> PrefixedName
    /// <summary>
    ///   <para>ocds:contractAmendment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Contract amendment</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#contractAmendment">http://purl.org/onto-ocds/ocds#contractAmendment</seealso>
    let contractAmendment = Prefixed_Name(ocds, "contractAmendment") |> PrefixedName
    /// <summary>
    ///   <para>ocds:contractDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Contract description</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#contractDescription">http://purl.org/onto-ocds/ocds#contractDescription</seealso>
    let contractDescription = Prefixed_Name(ocds, "contractDescription") |> PrefixedName
    /// <summary>
    ///   <para>ocds:contractId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The identifier for this contract. It must be unique and cannot change within its Open Contracting Process (defined by a single ocid). See the [identifier guidance](http://standard.open-contracting.org/latest/en/schema/identifiers/) for further details.</para>
    /// labels<para>Contract ID</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#contractId">http://purl.org/onto-ocds/ocds#contractId</seealso>
    let contractId = Prefixed_Name(ocds, "contractId") |> PrefixedName
    /// <summary>
    ///   <para>ocds:contractItems</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The goods, services, and any intangible outcomes in this contract. Note: If the items are the same as the award do not repeat.</para>
    /// labels<para>Items Contracted</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#contractItems">http://purl.org/onto-ocds/ocds#contractItems</seealso>
    let contractItems = Prefixed_Name(ocds, "contractItems") |> PrefixedName
    /// <summary>
    ///   <para>ocds:contractPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The period for which the contract has been awarded.</para>
    ///   <para>The start and end date for the contract.</para>
    /// labels<para>Contract period</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#contractPeriod">http://purl.org/onto-ocds/ocds#contractPeriod</seealso>
    let contractPeriod = Prefixed_Name(ocds, "contractPeriod") |> PrefixedName
    /// <summary>
    ///   <para>ocds:Address</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An address. This may be the legally registered address of the organization, or may be a correspondence address for this particular contracting process.</para>
    /// labels<para>Address</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#Address">http://purl.org/onto-ocds/ocds#Address</seealso>
    let Address = Prefixed_Name(ocds, "Address") |> PrefixedName
    /// <summary>
    ///   <para>ocds:awardStatusActive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ocds:AwardStatus</para>
    ///   <para>This award has been made, and is currently in force.</para>
    /// labels<para>active</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#awardStatusActive">http://purl.org/onto-ocds/ocds#awardStatusActive</seealso>
    let awardStatusActive = Prefixed_Name(ocds, "awardStatusActive") |> PrefixedName

    /// <summary>
    ///   <para>ocds:awardStatusUnsuccessful</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ocds:AwardStatus</para>
    ///   <para>This award could not be successfully made. If items or supplier details are included within the award section, then these narrow the scope of the unsuccessful award (i.e. the award of noted items, or an award to the noted supplier, was unsuccessful, but there may be other successful awards for different items listed in the tender, or to different suppliers).</para>
    /// labels<para>unsuccessful</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#awardStatusUnsuccessful">http://purl.org/onto-ocds/ocds#awardStatusUnsuccessful</seealso>
    let awardStatusUnsuccessful =
        Prefixed_Name(ocds, "awardStatusUnsuccessful") |> PrefixedName

    /// <summary>
    ///   <para>ocds:awardDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Award description</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#awardDescription">http://purl.org/onto-ocds/ocds#awardDescription</seealso>
    let awardDescription = Prefixed_Name(ocds, "awardDescription") |> PrefixedName
    /// <summary>
    ///   <para>ocds:awardFollows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#awardFollows">http://purl.org/onto-ocds/ocds#awardFollows</seealso>
    let awardFollows = Prefixed_Name(ocds, "awardFollows") |> PrefixedName
    /// <summary>
    ///   <para>ocds:tenderAmendment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para></para>
    /// labels<para>Tender amendment</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#tenderAmendment">http://purl.org/onto-ocds/ocds#tenderAmendment</seealso>
    let tenderAmendment = Prefixed_Name(ocds, "tenderAmendment") |> PrefixedName
    /// <summary>
    ///   <para>ocds:AwardCriteria</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The award criteria code list describes the basis on which contract awards will be made.</para>
    /// labels<para>Codelist Award Criteria</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#AwardCriteria">http://purl.org/onto-ocds/ocds#AwardCriteria</seealso>
    let AwardCriteria = Prefixed_Name(ocds, "AwardCriteria") |> PrefixedName
    /// <summary>
    ///   <para>ocds:Budget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This section contain information about the budget line, and associated projects, through which this contracting process is funded. It draws upon data model of the [Budget Data Package](https://github.com/openspending/budget-data-package/blob/master/specification.md), and should be used to cross-reference to more detailed information held using a Budget Data Package, or, where no linked Budget Data Package is available, to provide enough information to allow a user to manually or automatically cross-reference with another published source of budget and project information.</para>
    /// labels<para>Budget</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#Budget">http://purl.org/onto-ocds/ocds#Budget</seealso>
    let Budget = Prefixed_Name(ocds, "Budget") |> PrefixedName

    /// <summary>
    ///   <para>ocds:contractStatusPending</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ocds:ContractStatus</para>
    ///   <para>This contract has been proposed, but is not yet in force. It may be awaiting signature.</para>
    /// labels<para>pending</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#contractStatusPending">http://purl.org/onto-ocds/ocds#contractStatusPending</seealso>
    let contractStatusPending =
        Prefixed_Name(ocds, "contractStatusPending") |> PrefixedName

    /// <summary>
    ///   <para>ocds:Identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Identifier</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#Identifier">http://purl.org/onto-ocds/ocds#Identifier</seealso>
    let Identifier = Prefixed_Name(ocds, "Identifier") |> PrefixedName
    /// <summary>
    ///   <para>ocds:InitiationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Contracting processes may be formed under a number of different processes. Currently, only ‘tender’ is supported in this codelist. Future versions of the standard may support other Initiation Types. The initiation type may be provide information to consuming applications on the different blocks of data and releases they should expect from a contracting process.</para>
    /// labels<para>Codelist Initiation Type</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#InitiationType">http://purl.org/onto-ocds/ocds#InitiationType</seealso>
    let InitiationType = Prefixed_Name(ocds, "InitiationType") |> PrefixedName

    /// <summary>
    ///   <para>ocds:initiationTypeTender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ocds:InitiationType</para>
    ///   <para>An open competitive bidding or tendering to form contracts. The process generally involves publicly inviting prospective contractors to submit bids for evaluation and selecting a winner or winners.</para>
    /// labels<para>tender</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#initiationTypeTender">http://purl.org/onto-ocds/ocds#initiationTypeTender</seealso>
    let initiationTypeTender =
        Prefixed_Name(ocds, "initiationTypeTender") |> PrefixedName

    /// <summary>
    ///   <para>ocds:Lot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Es una conexión de uno o más ítems</para>
    /// labels<para>Lote</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#Lot">http://purl.org/onto-ocds/ocds#Lot</seealso>
    let Lot = Prefixed_Name(ocds, "Lot") |> PrefixedName
    /// <summary>
    ///   <para>ocds:methodLimited</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ocds:Method</para>
    ///   <para>Limited tendering means a procurement method whereby the procuring entity contacts a supplier or suppliers of its choice.</para>
    /// labels<para>limited</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#methodLimited">http://purl.org/onto-ocds/ocds#methodLimited</seealso>
    let methodLimited = Prefixed_Name(ocds, "methodLimited") |> PrefixedName
    /// <summary>
    ///   <para>ocds:Milestone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Milestone</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#Milestone">http://purl.org/onto-ocds/ocds#Milestone</seealso>
    let Milestone = Prefixed_Name(ocds, "Milestone") |> PrefixedName

    /// <summary>
    ///   <para>ocds:OrganizationIdentifierScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Organization Identifier Scheme currently uses the codes from the International Aid Transparency Initiative ‘Organisation Registration Agency’ codelist. See the identifiers section for more information on organization identifiers.</para>
    /// labels<para>Codelist Organization Identifier Scheme</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#OrganizationIdentifierScheme">http://purl.org/onto-ocds/ocds#OrganizationIdentifierScheme</seealso>
    let OrganizationIdentifierScheme =
        Prefixed_Name(ocds, "OrganizationIdentifierScheme") |> PrefixedName

    /// <summary>
    ///   <para>ocds:Planning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>nformation from the planning phase of the contracting process. Note that many other fields may be filled in a planning release, in the appropriate fields in other schema sections, these would likely be estimates at this stage e.g. totalValue in tender</para>
    /// labels<para>Planning</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#Planning">http://purl.org/onto-ocds/ocds#Planning</seealso>
    let Planning = Prefixed_Name(ocds, "Planning") |> PrefixedName
    /// <summary>
    ///   <para>ocds:releaseTagAward</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ocds:ReleaseTag</para>
    ///
    /// labels<para>award</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#releaseTagAward">http://purl.org/onto-ocds/ocds#releaseTagAward</seealso>
    let releaseTagAward = Prefixed_Name(ocds, "releaseTagAward") |> PrefixedName

    /// <summary>
    ///   <para>ocds:releaseTagAwardCancellation</para>
    /// </summary>
    /// <remarks>
    ///   <para>ocds:ReleaseTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>awardCancellation</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#releaseTagAwardCancellation">http://purl.org/onto-ocds/ocds#releaseTagAwardCancellation</seealso>
    let releaseTagAwardCancellation =
        Prefixed_Name(ocds, "releaseTagAwardCancellation") |> PrefixedName

    /// <summary>
    ///   <para>ocds:releaseTagCompiled</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ocds:ReleaseTag</para>
    ///   <para>This tag is used only in compiled records, which have merged together multiple releases to provide a snapshot view of the contract, and a version history.</para>
    /// labels<para>compiled</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#releaseTagCompiled">http://purl.org/onto-ocds/ocds#releaseTagCompiled</seealso>
    let releaseTagCompiled = Prefixed_Name(ocds, "releaseTagCompiled") |> PrefixedName
    /// <summary>
    ///   <para>ocds:releaseTagContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>ocds:ReleaseTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>contract</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#releaseTagContract">http://purl.org/onto-ocds/ocds#releaseTagContract</seealso>
    let releaseTagContract = Prefixed_Name(ocds, "releaseTagContract") |> PrefixedName
    /// <summary>
    ///   <para>ocds:documentDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A short description of the document. We recommend descriptions do not exceed 250 words. In the event the document is not accessible online, the description field can be used to describe arrangements for obtaining a copy of the document.</para>
    /// labels<para>Document description</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#documentDescription">http://purl.org/onto-ocds/ocds#documentDescription</seealso>
    let documentDescription = Prefixed_Name(ocds, "documentDescription") |> PrefixedName
    /// <summary>
    ///   <para>ocds:documentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A classification of the document described taken from the [documentType codelist](http://standard.open-contracting.org/latest/en/schema/codelists/#document-type). Values from the provided codelist should be used wherever possible, though extended values can be provided if the codelist does not have a relevant code.</para>
    /// labels<para>Document type</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#documentType">http://purl.org/onto-ocds/ocds#documentType</seealso>
    let documentType = Prefixed_Name(ocds, "documentType") |> PrefixedName
    /// <summary>
    ///   <para>ocds:AwardStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An award move through multiple states. Releases over time may update the status of an award.</para>
    /// labels<para>Codelist Award Status</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#AwardStatus">http://purl.org/onto-ocds/ocds#AwardStatus</seealso>
    let AwardStatus = Prefixed_Name(ocds, "AwardStatus") |> PrefixedName

    /// <summary>
    ///   <para>ocds:awardStatusCancelled</para>
    /// </summary>
    /// <remarks>
    ///   <para>ocds:AwardStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>This award has been cancelled.</para>
    /// labels<para>cancelled</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#awardStatusCancelled">http://purl.org/onto-ocds/ocds#awardStatusCancelled</seealso>
    let awardStatusCancelled =
        Prefixed_Name(ocds, "awardStatusCancelled") |> PrefixedName

    /// <summary>
    ///   <para>ocds:methodSelective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ocds:Method</para>
    ///   <para>Selective tendering means a procurement method whereby only qualified suppliers are invited by the procuring entity to submit a tender.</para>
    /// labels<para>selective</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#methodSelective">http://purl.org/onto-ocds/ocds#methodSelective</seealso>
    let methodSelective = Prefixed_Name(ocds, "methodSelective") |> PrefixedName
    /// <summary>
    ///   <para>ocds:Period</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Period</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#Period">http://purl.org/onto-ocds/ocds#Period</seealso>
    let Period = Prefixed_Name(ocds, "Period") |> PrefixedName
    /// <summary>
    ///   <para>ocds:ReleaseTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A contracting process may result in a number of releases of information over time. These should be tagged to indicate the stage of the contracting process they relate to.</para>
    /// labels<para>Codelist ReleaseTag</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#ReleaseTag">http://purl.org/onto-ocds/ocds#ReleaseTag</seealso>
    let ReleaseTag = Prefixed_Name(ocds, "ReleaseTag") |> PrefixedName

    /// <summary>
    ///   <para>ocds:releaseTagAwardUpdate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ocds:ReleaseTag</para>
    ///
    /// labels<para>awardUpdate</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#releaseTagAwardUpdate">http://purl.org/onto-ocds/ocds#releaseTagAwardUpdate</seealso>
    let releaseTagAwardUpdate =
        Prefixed_Name(ocds, "releaseTagAwardUpdate") |> PrefixedName

    /// <summary>
    ///   <para>ocds:releaseTagContractAmendment</para>
    /// </summary>
    /// <remarks>
    ///   <para>ocds:ReleaseTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>contractAmendment</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#releaseTagContractAmendment">http://purl.org/onto-ocds/ocds#releaseTagContractAmendment</seealso>
    let releaseTagContractAmendment =
        Prefixed_Name(ocds, "releaseTagContractAmendment") |> PrefixedName

    /// <summary>
    ///   <para>ocds:releaseTagImplementationUpdate</para>
    /// </summary>
    /// <remarks>
    ///   <para>ocds:ReleaseTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>implementationUpdate</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#releaseTagImplementationUpdate">http://purl.org/onto-ocds/ocds#releaseTagImplementationUpdate</seealso>
    let releaseTagImplementationUpdate =
        Prefixed_Name(ocds, "releaseTagImplementationUpdate") |> PrefixedName

    /// <summary>
    ///   <para>ocds:releaseTagPlanning</para>
    /// </summary>
    /// <remarks>
    ///   <para>ocds:ReleaseTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>planning</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#releaseTagPlanning">http://purl.org/onto-ocds/ocds#releaseTagPlanning</seealso>
    let releaseTagPlanning = Prefixed_Name(ocds, "releaseTagPlanning") |> PrefixedName

    /// <summary>
    ///   <para>ocds:releaseTagTenderUpdate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ocds:ReleaseTag</para>
    ///   <para>An updated to an existing tender release. There should be at least one tender release with the same ocid, but an earlier releaseDate, before a tenderUpdate is published. An update may add new information or make corrections to prior published information. It should not be used for formal legal amendments to a tender, for which the tenderAmendment tag should be used.</para>
    /// labels<para>tenderUpdate</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#releaseTagTenderUpdate">http://purl.org/onto-ocds/ocds#releaseTagTenderUpdate</seealso>
    let releaseTagTenderUpdate =
        Prefixed_Name(ocds, "releaseTagTenderUpdate") |> PrefixedName

    /// <summary>
    ///   <para>ocds:Tender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Data regarding tender process - publicly inviting prospective contractors to submit bids for evaluation and selecting a winner or winners</para>
    /// labels<para>Tender</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#Tender">http://purl.org/onto-ocds/ocds#Tender</seealso>
    let Tender = Prefixed_Name(ocds, "Tender") |> PrefixedName

    /// <summary>
    ///   <para>ocds:tenderStatusCancelled</para>
    /// </summary>
    /// <remarks>
    ///   <para>ocds:TenderStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The tender process has been cancelled.</para>
    /// labels<para>cancelled</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#tenderStatusCancelled">http://purl.org/onto-ocds/ocds#tenderStatusCancelled</seealso>
    let tenderStatusCancelled =
        Prefixed_Name(ocds, "tenderStatusCancelled") |> PrefixedName

    /// <summary>
    ///   <para>ocds:tenderStatusUnsuccessful</para>
    /// </summary>
    /// <remarks>
    ///   <para>ocds:TenderStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The tender process as unsucessful.</para>
    /// labels<para>unsuccessful</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#tenderStatusUnsuccessful">http://purl.org/onto-ocds/ocds#tenderStatusUnsuccessful</seealso>
    let tenderStatusUnsuccessful =
        Prefixed_Name(ocds, "tenderStatusUnsuccessful") |> PrefixedName

    /// <summary>
    ///   <para>ocds:Transaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A spending transaction related to the contracting process. Draws upon the data models of the [Budget Data Package](https://github.com/openspending/budget-data-package/blob/master/specification.md) and the [International Aid Transpareny Initiative](http://iatistandard.org/activity-standard/iati-activities/iati-activity/transaction/) and should be used to cross-reference to more detailed information held using a Budget Data Package, IATI file, or to provide enough information to allow a user to manually or automatically cross-reference with some other published source of transactional spending data.</para>
    /// labels<para>Transaction Information</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#Transaction">http://purl.org/onto-ocds/ocds#Transaction</seealso>
    let Transaction = Prefixed_Name(ocds, "Transaction") |> PrefixedName
    /// <summary>
    ///   <para>ocds:Value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Value</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#Value">http://purl.org/onto-ocds/ocds#Value</seealso>
    let Value = Prefixed_Name(ocds, "Value") |> PrefixedName

    /// <summary>
    ///   <para>ocds:additionalIdentifiers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A list of additional / supplemental identifiers for the organization, using the [organization identifier guidance](http://standard.open-contracting.org/latest/en/schema/identifiers/). This could be used to provide an internally used identifier for this organization in addition to the primary legal entity identifier.</para>
    /// labels<para>Additional identifiers</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#additionalIdentifiers">http://purl.org/onto-ocds/ocds#additionalIdentifiers</seealso>
    let additionalIdentifiers =
        Prefixed_Name(ocds, "additionalIdentifiers") |> PrefixedName

    /// <summary>
    ///   <para>ocds:milestoneDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A description of the milestone.</para>
    /// labels<para>Milestone description</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#milestoneDescription">http://purl.org/onto-ocds/ocds#milestoneDescription</seealso>
    let milestoneDescription =
        Prefixed_Name(ocds, "milestoneDescription") |> PrefixedName

    /// <summary>
    ///   <para>ocds:awardStatusPending</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ocds:AwardStatus</para>
    ///   <para>This award has been proposed, but is not yet in force. This may be due to a cooling off period, or some other process.</para>
    /// labels<para>pending</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#awardStatusPending">http://purl.org/onto-ocds/ocds#awardStatusPending</seealso>
    let awardStatusPending = Prefixed_Name(ocds, "awardStatusPending") |> PrefixedName
    /// <summary>
    ///   <para>ocds:awardId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The identifier for this award. It must be unique and cannot change within the Open Contracting Process it is part of (defined by a single ocid). See the [identifier guidance](http://standard.open-contracting.org/latest/en/schema/identifiers/) for further details.</para>
    /// labels<para>Award ID</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#awardId">http://purl.org/onto-ocds/ocds#awardId</seealso>
    let awardId = Prefixed_Name(ocds, "awardId") |> PrefixedName
    /// <summary>
    ///   <para>ocds:tenderers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>All entities who submit a tender.</para>
    /// labels<para>Tenderers</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#tenderers">http://purl.org/onto-ocds/ocds#tenderers</seealso>
    let tenderers = Prefixed_Name(ocds, "tenderers") |> PrefixedName
    /// <summary>
    ///   <para>ocds:ContactPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An person, contact point or department to contact in relation to this contracting process.</para>
    /// labels<para>Contact point</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#ContactPoint">http://purl.org/onto-ocds/ocds#ContactPoint</seealso>
    let ContactPoint = Prefixed_Name(ocds, "ContactPoint") |> PrefixedName

    /// <summary>
    ///   <para>ocds:contractStatusActive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ocds:ContractStatus</para>
    ///   <para>This contract has been signed by all the parties, and is now legally in force.</para>
    /// labels<para>active</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#contractStatusActive">http://purl.org/onto-ocds/ocds#contractStatusActive</seealso>
    let contractStatusActive =
        Prefixed_Name(ocds, "contractStatusActive") |> PrefixedName

    /// <summary>
    ///   <para>ocds:contractStatusTerminated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ocds:ContractStatus</para>
    ///   <para>This contract was signed and in force, and has now come to a close. This may be due to successful completion of the contract, or may be early termination due to some non-completion.</para>
    /// labels<para>terminated</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#contractStatusTerminated">http://purl.org/onto-ocds/ocds#contractStatusTerminated</seealso>
    let contractStatusTerminated =
        Prefixed_Name(ocds, "contractStatusTerminated") |> PrefixedName

    /// <summary>
    ///   <para>ocds:DocumentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This list provides details of the documents that publishers may wish to provide at various points their contracting process.</para>
    /// labels<para>Codelist Document Type</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#DocumentType">http://purl.org/onto-ocds/ocds#DocumentType</seealso>
    let DocumentType = Prefixed_Name(ocds, "DocumentType") |> PrefixedName
    /// <summary>
    ///   <para>ocds:contracts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Information from the contract creation phase of the procurement process.</para>
    /// labels<para>Contracts</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#contracts">http://purl.org/onto-ocds/ocds#contracts</seealso>
    let contracts = Prefixed_Name(ocds, "contracts") |> PrefixedName
    /// <summary>
    ///   <para>ocds:contractFollows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#contractFollows">http://purl.org/onto-ocds/ocds#contractFollows</seealso>
    let contractFollows = Prefixed_Name(ocds, "contractFollows") |> PrefixedName

    /// <summary>
    ///   <para>ocds:releaseTagContractTermination</para>
    /// </summary>
    /// <remarks>
    ///   <para>ocds:ReleaseTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>contractTermination</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#releaseTagContractTermination">http://purl.org/onto-ocds/ocds#releaseTagContractTermination</seealso>
    let releaseTagContractTermination =
        Prefixed_Name(ocds, "releaseTagContractTermination") |> PrefixedName

    /// <summary>
    ///   <para>ocds:documentUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Direct link to the document or attachment. The server providing access to this document should be configured to correctly report the document mime type.</para>
    /// labels<para>Document URL</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#documentUrl">http://purl.org/onto-ocds/ocds#documentUrl</seealso>
    let documentUrl = Prefixed_Name(ocds, "documentUrl") |> PrefixedName
    /// <summary>
    ///   <para>ocds:email</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The e-mail address of the contact point/person.</para>
    /// labels<para>Email</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#email">http://purl.org/onto-ocds/ocds#email</seealso>
    let email = Prefixed_Name(ocds, "email") |> PrefixedName
    /// <summary>
    ///   <para>ocds:faxNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The fax number of the contact point/person. This should include the international dialling code.</para>
    /// labels<para>Fax number</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#faxNumber">http://purl.org/onto-ocds/ocds#faxNumber</seealso>
    let faxNumber = Prefixed_Name(ocds, "faxNumber") |> PrefixedName
    /// <summary>
    ///   <para>ocds:releaseTagTender</para>
    /// </summary>
    /// <remarks>
    ///   <para>ocds:ReleaseTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Announcing a new tender (call for proposals) process. Tender release should contain details of the goods or services being sought.</para>
    /// labels<para>tender</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#releaseTagTender">http://purl.org/onto-ocds/ocds#releaseTagTender</seealso>
    let releaseTagTender = Prefixed_Name(ocds, "releaseTagTender") |> PrefixedName
    /// <summary>
    ///   <para>ocds:SubmissionMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The submission method codelist is used to identify the mechanism through which a submission may be made.</para>
    /// labels<para>Codelist Submission Method</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#SubmissionMethod">http://purl.org/onto-ocds/ocds#SubmissionMethod</seealso>
    let SubmissionMethod = Prefixed_Name(ocds, "SubmissionMethod") |> PrefixedName
    /// <summary>
    ///   <para>ocds:tenderStatusActive</para>
    /// </summary>
    /// <remarks>
    ///   <para>ocds:TenderStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A tender process is currently taking place.</para>
    /// labels<para>active</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#tenderStatusActive">http://purl.org/onto-ocds/ocds#tenderStatusActive</seealso>
    let tenderStatusActive = Prefixed_Name(ocds, "tenderStatusActive") |> PrefixedName

    /// <summary>
    ///   <para>ocds:tenderStatusComplete</para>
    /// </summary>
    /// <remarks>
    ///   <para>ocds:TenderStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The tender process as unsucessful.</para>
    /// labels<para>complete</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#tenderStatusComplete">http://purl.org/onto-ocds/ocds#tenderStatusComplete</seealso>
    let tenderStatusComplete =
        Prefixed_Name(ocds, "tenderStatusComplete") |> PrefixedName

    /// <summary>
    ///   <para>ocds:eligibilityCriteria</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A description of any eligibility criteria for potential suppliers.</para>
    /// labels<para>Eligibility criteria</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#eligibilityCriteria">http://purl.org/onto-ocds/ocds#eligibilityCriteria</seealso>
    let eligibilityCriteria = Prefixed_Name(ocds, "eligibilityCriteria") |> PrefixedName
    /// <summary>
    ///   <para>ocds:TenderStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The tender.status field is used to indicate the current status of a tender process.</para>
    /// labels<para>Codelist Tender Status</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#TenderStatus">http://purl.org/onto-ocds/ocds#TenderStatus</seealso>
    let TenderStatus = Prefixed_Name(ocds, "TenderStatus") |> PrefixedName
    /// <summary>
    ///   <para>ocds:tenderStatusPlanned</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ocds:TenderStatus</para>
    ///   <para>This tender has been proposed, but is not yet taking place.</para>
    /// labels<para>planned</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#tenderStatusPlanned">http://purl.org/onto-ocds/ocds#tenderStatusPlanned</seealso>
    let tenderStatusPlanned = Prefixed_Name(ocds, "tenderStatusPlanned") |> PrefixedName

    /// <summary>
    ///   <para>ocds:implementationMilestones</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>As milestones are completed, milestone completions should be documented.</para>
    /// labels<para>Implementation milestones</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#implementationMilestones">http://purl.org/onto-ocds/ocds#implementationMilestones</seealso>
    let implementationMilestones =
        Prefixed_Name(ocds, "implementationMilestones") |> PrefixedName

    /// <summary>
    ///   <para>ocds:locality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The locality. For example, Mountain View.</para>
    /// labels<para>Locality</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#locality">http://purl.org/onto-ocds/ocds#locality</seealso>
    let locality = Prefixed_Name(ocds, "locality") |> PrefixedName
    /// <summary>
    ///   <para>ocds:Unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Unit</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#Unit">http://purl.org/onto-ocds/ocds#Unit</seealso>
    let Unit = Prefixed_Name(ocds, "Unit") |> PrefixedName
    /// <summary>
    ///   <para>ocds:address</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Address</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#address">http://purl.org/onto-ocds/ocds#address</seealso>
    let address = Prefixed_Name(ocds, "address") |> PrefixedName
    /// <summary>
    ///   <para>ocds:amendmentRationale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>An explanation for the amendment.</para>
    /// labels<para>Amendment rationale</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#amendmentRationale">http://purl.org/onto-ocds/ocds#amendmentRationale</seealso>
    let amendmentRationale = Prefixed_Name(ocds, "amendmentRationale") |> PrefixedName
    /// <summary>
    ///   <para>ocds:award</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Information from the award phase of the contracting process. There may be more than one award per contracting process e.g. because the contract is split amongst different providers, or because it is a standing offer.</para>
    /// labels<para>Awards</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#award">http://purl.org/onto-ocds/ocds#award</seealso>
    let award = Prefixed_Name(ocds, "award") |> PrefixedName
    /// <summary>
    ///   <para>ocds:awardCriteria</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specify the award criteria for the procurement, using the [award criteria codelist](http://standard.open-contracting.org/latest/en/schema/codelists/#award-criteria)</para>
    /// labels<para>Award criteria</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#awardCriteria">http://purl.org/onto-ocds/ocds#awardCriteria</seealso>
    let awardCriteria = Prefixed_Name(ocds, "awardCriteria") |> PrefixedName

    /// <summary>
    ///   <para>ocds:awardCriteriaBestValueToGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>ocds:AwardCriteria</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>bestValueToGovernment</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#awardCriteriaBestValueToGovernment">http://purl.org/onto-ocds/ocds#awardCriteriaBestValueToGovernment</seealso>
    let awardCriteriaBestValueToGovernment =
        Prefixed_Name(ocds, "awardCriteriaBestValueToGovernment") |> PrefixedName

    /// <summary>
    ///   <para>ocds:additionalClassifications</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An array of additional classifications for the item. See the [itemClassificationScheme](http://standard.open-contracting.org/latest/en/schema/codelists/#item-classification-scheme) codelist for common options to use in OCDS. This may also be used to present codes from an internal classification scheme.</para>
    /// labels<para>Additional classifications</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#additionalClassifications">http://purl.org/onto-ocds/ocds#additionalClassifications</seealso>
    let additionalClassifications =
        Prefixed_Name(ocds, "additionalClassifications") |> PrefixedName

    /// <summary>
    ///   <para>ocds:numberOfTenderers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The number of entities who submit a tender.</para>
    /// labels<para>Number of tenders</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#numberOfTenderers">http://purl.org/onto-ocds/ocds#numberOfTenderers</seealso>
    let numberOfTenderers = Prefixed_Name(ocds, "numberOfTenderers") |> PrefixedName
    /// <summary>
    ///   <para>ocds:amendmentDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The data of this amendment.</para>
    /// labels<para>Amendment Date</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#amendmentDate">http://purl.org/onto-ocds/ocds#amendmentDate</seealso>
    let amendmentDate = Prefixed_Name(ocds, "amendmentDate") |> PrefixedName
    /// <summary>
    ///   <para>ocds:awardAmendment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Award amendment</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#awardAmendment">http://purl.org/onto-ocds/ocds#awardAmendment</seealso>
    let awardAmendment = Prefixed_Name(ocds, "awardAmendment") |> PrefixedName

    /// <summary>
    ///   <para>ocds:awardCriteriaBestProposal</para>
    /// </summary>
    /// <remarks>
    ///   <para>ocds:AwardCriteria</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>bestProposal</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#awardCriteriaBestProposal">http://purl.org/onto-ocds/ocds#awardCriteriaBestProposal</seealso>
    let awardCriteriaBestProposal =
        Prefixed_Name(ocds, "awardCriteriaBestProposal") |> PrefixedName

    /// <summary>
    ///   <para>ocds:awardCriteriaLowestCost</para>
    /// </summary>
    /// <remarks>
    ///   <para>ocds:AwardCriteria</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>lowestCost</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#awardCriteriaLowestCost">http://purl.org/onto-ocds/ocds#awardCriteriaLowestCost</seealso>
    let awardCriteriaLowestCost =
        Prefixed_Name(ocds, "awardCriteriaLowestCost") |> PrefixedName

    /// <summary>
    ///   <para>ocds:awardDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date of the contract award. This is usually the date on which a decision to award was made.</para>
    /// labels<para>Award date</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#awardDate">http://purl.org/onto-ocds/ocds#awardDate</seealso>
    let awardDate = Prefixed_Name(ocds, "awardDate") |> PrefixedName
    /// <summary>
    ///   <para>ocds:tender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>The activities undertaken in order to enter into a contract.</para>
    /// labels<para>Tender</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#tender">http://purl.org/onto-ocds/ocds#tender</seealso>
    let tender = Prefixed_Name(ocds, "tender") |> PrefixedName
    /// <summary>
    ///   <para>ocds:tenderDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Tender description</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#tenderDescription">http://purl.org/onto-ocds/ocds#tenderDescription</seealso>
    let tenderDescription = Prefixed_Name(ocds, "tenderDescription") |> PrefixedName
    /// <summary>
    ///   <para>ocds:planning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Information from the planning phase of the contracting process. This includes information related to the process of deciding what to contract for, when and how.</para>
    /// labels<para>Planning</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#planning">http://purl.org/onto-ocds/ocds#planning</seealso>
    let planning = Prefixed_Name(ocds, "planning") |> PrefixedName
    /// <summary>
    ///   <para>ocds:procuringEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The entity managing the procurement, which may be different from the buyer who is paying / using the items being procured.</para>
    /// labels<para>Procuring entity</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#procuringEntity">http://purl.org/onto-ocds/ocds#procuringEntity</seealso>
    let procuringEntity = Prefixed_Name(ocds, "procuringEntity") |> PrefixedName
    /// <summary>
    ///   <para>ocds:project</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The name of the project that through which this contracting process is funded (if applicable). Some organizations maintain a registry of projects, and the data should use the name by which the project is known in that registry. No translation option is offered for this string, as translated values can be provided in third-party data, linked from the data source above.</para>
    /// labels<para>Project Title</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#project">http://purl.org/onto-ocds/ocds#project</seealso>
    let project = Prefixed_Name(ocds, "project") |> PrefixedName

    /// <summary>
    ///   <para>ocds:awardCriteriaDetails</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Any detailed or further information on the award or selection criteria.</para>
    /// labels<para>Award criteria details</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#awardCriteriaDetails">http://purl.org/onto-ocds/ocds#awardCriteriaDetails</seealso>
    let awardCriteriaDetails =
        Prefixed_Name(ocds, "awardCriteriaDetails") |> PrefixedName

    /// <summary>
    ///   <para>ocds:awardCriteriaSingleBidOnly</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ocds:AwardCriteria</para>
    ///
    /// labels<para>singleBidOnly</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#awardCriteriaSingleBidOnly">http://purl.org/onto-ocds/ocds#awardCriteriaSingleBidOnly</seealso>
    let awardCriteriaSingleBidOnly =
        Prefixed_Name(ocds, "awardCriteriaSingleBidOnly") |> PrefixedName

    /// <summary>
    ///   <para>ocds:releaseDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The date this information is released, it may well be the same as the parent publishedDate, it must not be later than the publishedDate from the parent package. It is used to determine merge order.</para>
    /// labels<para>Release Date</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#releaseDate">http://purl.org/onto-ocds/ocds#releaseDate</seealso>
    let releaseDate = Prefixed_Name(ocds, "releaseDate") |> PrefixedName
    /// <summary>
    ///   <para>ocds:awardDocuments</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>All documents and attachments related to the award, including any notices.</para>
    /// labels<para>Award documents</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#awardDocuments">http://purl.org/onto-ocds/ocds#awardDocuments</seealso>
    let awardDocuments = Prefixed_Name(ocds, "awardDocuments") |> PrefixedName
    /// <summary>
    ///   <para>ocds:tenderValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The total upper estimated value of the procurement.</para>
    /// labels<para>Tender value</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#tenderValue">http://purl.org/onto-ocds/ocds#tenderValue</seealso>
    let tenderValue = Prefixed_Name(ocds, "tenderValue") |> PrefixedName
    /// <summary>
    ///   <para>ocds:awardID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The award against which this contract is being issued.</para>
    /// labels<para>Award ID</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#awardID">http://purl.org/onto-ocds/ocds#awardID</seealso>
    let awardID = Prefixed_Name(ocds, "awardID") |> PrefixedName
    /// <summary>
    ///   <para>ocds:awardURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#awardURL">http://purl.org/onto-ocds/ocds#awardURL</seealso>
    let awardURL = Prefixed_Name(ocds, "awardURL") |> PrefixedName
    /// <summary>
    ///   <para>ocds:budget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Budget</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#budget">http://purl.org/onto-ocds/ocds#budget</seealso>
    let budget = Prefixed_Name(ocds, "budget") |> PrefixedName
    /// <summary>
    ///   <para>ocds:budgetDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#budgetDescription">http://purl.org/onto-ocds/ocds#budgetDescription</seealso>
    let budgetDescription = Prefixed_Name(ocds, "budgetDescription") |> PrefixedName
    /// <summary>
    ///   <para>ocds:budgetId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>An identifier for the budget line item which provides funds for this contracting process. This identifier should be possible to cross-reference against the provided data source.</para>
    /// labels<para>Budget ID</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#budgetId">http://purl.org/onto-ocds/ocds#budgetId</seealso>
    let budgetId = Prefixed_Name(ocds, "budgetId") |> PrefixedName
    /// <summary>
    ///   <para>ocds:budgetSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Used to point either to a corresponding Budget Data Package, or to a machine or human-readable source where users can find further information on the budget line item identifiers, or project identifiers, provided here.</para>
    /// labels<para>Budget Data Source</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#budgetSource">http://purl.org/onto-ocds/ocds#budgetSource</seealso>
    let budgetSource = Prefixed_Name(ocds, "budgetSource") |> PrefixedName
    /// <summary>
    ///   <para>ocds:buyer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The buyer is the entity whose budget will be used to purchase the goods. This may be different from the procuring agency who may be specified in the tender data.</para>
    /// labels<para>Buyer</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#buyer">http://purl.org/onto-ocds/ocds#buyer</seealso>
    let buyer = Prefixed_Name(ocds, "buyer") |> PrefixedName
    /// <summary>
    ///   <para>ocds:classification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The primary classification for the item. See the [itemClassificationScheme](http://standard.open-contracting.org/latest/en/schema/codelists/#item-classification-scheme) to identify preferred classification lists, including CPV and GSIN.</para>
    /// labels<para>Classification</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#classification">http://purl.org/onto-ocds/ocds#classification</seealso>
    let classification = Prefixed_Name(ocds, "classification") |> PrefixedName

    /// <summary>
    ///   <para>ocds:classificationScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An classification should be drawn from an existing scheme or list of codes. This field is used to indicate the scheme/codelist from which the classification is drawn. For line item classifications, this value should represent an known [Item Classification Scheme](http://standard.open-contracting.org/latest/en/schema/codelists/#item-classification-scheme) wherever possible.</para>
    /// labels<para>Classification scheme</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#classificationScheme">http://purl.org/onto-ocds/ocds#classificationScheme</seealso>
    let classificationScheme =
        Prefixed_Name(ocds, "classificationScheme") |> PrefixedName

    /// <summary>
    ///   <para>ocds:awardPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The date or period on which an award is anticipated to be made.</para>
    /// labels<para>Award period</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#awardPeriod">http://purl.org/onto-ocds/ocds#awardPeriod</seealso>
    let awardPeriod = Prefixed_Name(ocds, "awardPeriod") |> PrefixedName
    /// <summary>
    ///   <para>ocds:awardStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The current status of the award drawn from the [awardStatus codelist](http://standard.open-contracting.org/latest/en/schema/codelists/#award-status)</para>
    /// labels<para>Award status</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#awardStatus">http://purl.org/onto-ocds/ocds#awardStatus</seealso>
    let awardStatus = Prefixed_Name(ocds, "awardStatus") |> PrefixedName
    /// <summary>
    ///   <para>ocds:awardTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Award title</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#awardTitle">http://purl.org/onto-ocds/ocds#awardTitle</seealso>
    let awardTitle = Prefixed_Name(ocds, "awardTitle") |> PrefixedName
    /// <summary>
    ///   <para>ocds:awardValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The total value of this award. In the case of a framework contract this may be the total estimated lifetime value, or maximum value, of the agreement. There may be more than one award per procurement.</para>
    /// labels<para>Award value</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#awardValue">http://purl.org/onto-ocds/ocds#awardValue</seealso>
    let awardValue = Prefixed_Name(ocds, "awardValue") |> PrefixedName
    /// <summary>
    ///   <para>ocds:budgetAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The value of the budget line item.</para>
    /// labels<para>Budget amount</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#budgetAmount">http://purl.org/onto-ocds/ocds#budgetAmount</seealso>
    let budgetAmount = Prefixed_Name(ocds, "budgetAmount") |> PrefixedName
    /// <summary>
    ///   <para>ocds:budgetUri</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A URI pointing directly to a machine-readable record about the related budget or projects for this contracting process.</para>
    /// labels<para>Linked budget information</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#budgetUri">http://purl.org/onto-ocds/ocds#budgetUri</seealso>
    let budgetUri = Prefixed_Name(ocds, "budgetUri") |> PrefixedName
    /// <summary>
    ///   <para>ocds:changes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Comma-separated list of affected fields.</para>
    /// labels<para>Amended fields</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#changes">http://purl.org/onto-ocds/ocds#changes</seealso>
    let changes = Prefixed_Name(ocds, "changes") |> PrefixedName

    /// <summary>
    ///   <para>ocds:classificationDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A textual description or title for the code.</para>
    /// labels<para>Classification description</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#classificationDescription">http://purl.org/onto-ocds/ocds#classificationDescription</seealso>
    let classificationDescription =
        Prefixed_Name(ocds, "classificationDescription") |> PrefixedName

    /// <summary>
    ///   <para>ocds:classificationId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The classification code drawn from the selected scheme.</para>
    /// labels<para>Classification ID</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#classificationId">http://purl.org/onto-ocds/ocds#classificationId</seealso>
    let classificationId = Prefixed_Name(ocds, "classificationId") |> PrefixedName
    /// <summary>
    ///   <para>ocds:classificationUri</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A URI to identify the code. In the event individual URIs are not available for items in the identifier scheme this value should be left blank.</para>
    /// labels<para>Classification URI</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#classificationUri">http://purl.org/onto-ocds/ocds#classificationUri</seealso>
    let classificationUri = Prefixed_Name(ocds, "classificationUri") |> PrefixedName
    /// <summary>
    ///   <para>ocds:contactPointUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A web address for the contact point/person.</para>
    /// labels<para>Contact point URL</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#contactPointUrl">http://purl.org/onto-ocds/ocds#contactPointUrl</seealso>
    let contactPointUrl = Prefixed_Name(ocds, "contactPointUrl") |> PrefixedName
    /// <summary>
    ///   <para>ocds:contractDocuments</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>All documents and attachments related to the contract, including any notices.</para>
    /// labels<para>Contract documents</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#contractDocuments">http://purl.org/onto-ocds/ocds#contractDocuments</seealso>
    let contractDocuments = Prefixed_Name(ocds, "contractDocuments") |> PrefixedName
    /// <summary>
    ///   <para>ocds:contractLots</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>List of lots associated with the contract</para>
    /// labels<para>Contract lots</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#contractLots">http://purl.org/onto-ocds/ocds#contractLots</seealso>
    let contractLots = Prefixed_Name(ocds, "contractLots") |> PrefixedName
    /// <summary>
    ///   <para>ocds:contractStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The current status of the contract. Drawn from the [contractStatus codelist](http://standard.open-contracting.org/latest/en/schema/codelists/#contract-status)</para>
    /// labels<para>Contract status</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#contractStatus">http://purl.org/onto-ocds/ocds#contractStatus</seealso>
    let contractStatus = Prefixed_Name(ocds, "contractStatus") |> PrefixedName
    /// <summary>
    ///   <para>ocds:contractSuppliers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The suppliers awarded this contract. Is an implementacion of DNCP</para>
    /// labels<para>Contract Suppliers</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#contractSuppliers">http://purl.org/onto-ocds/ocds#contractSuppliers</seealso>
    let contractSuppliers = Prefixed_Name(ocds, "contractSuppliers") |> PrefixedName
    /// <summary>
    ///   <para>ocds:contractTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Contract title</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#contractTitle">http://purl.org/onto-ocds/ocds#contractTitle</seealso>
    let contractTitle = Prefixed_Name(ocds, "contractTitle") |> PrefixedName
    /// <summary>
    ///   <para>ocds:contractValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The total value of this contract.</para>
    /// labels<para>Contract value</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#contractValue">http://purl.org/onto-ocds/ocds#contractValue</seealso>
    let contractValue = Prefixed_Name(ocds, "contractValue") |> PrefixedName
    /// <summary>
    ///   <para>ocds:countryName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The country name. For example, United States.</para>
    /// labels<para>Country name</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#countryName">http://purl.org/onto-ocds/ocds#countryName</seealso>
    let countryName = Prefixed_Name(ocds, "countryName") |> PrefixedName
    /// <summary>
    ///   <para>ocds:currency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The currency in 3-letter ISO 4217 format.</para>
    /// labels<para>Currency</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#currency">http://purl.org/onto-ocds/ocds#currency</seealso>
    let currency = Prefixed_Name(ocds, "currency") |> PrefixedName
    /// <summary>
    ///   <para>ocds:datePublished</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date on which the document was first published. This is particularly important for legally important documents such as notices of a tender.</para>
    /// labels<para>Publication date</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#datePublished">http://purl.org/onto-ocds/ocds#datePublished</seealso>
    let datePublished = Prefixed_Name(ocds, "datePublished") |> PrefixedName
    /// <summary>
    ///   <para>ocds:dateSigned</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date the contract was signed. In the case of multiple signatures, the date of the last signature.</para>
    /// labels<para>Date of signature</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#dateSigned">http://purl.org/onto-ocds/ocds#dateSigned</seealso>
    let dateSigned = Prefixed_Name(ocds, "dateSigned") |> PrefixedName
    /// <summary>
    ///   <para>ocds:dncpContractCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Código de contrato de la DNCP</para>
    /// labels<para>Código de contrato</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#dncpContractCode">http://purl.org/onto-ocds/ocds#dncpContractCode</seealso>
    let dncpContractCode = Prefixed_Name(ocds, "dncpContractCode") |> PrefixedName

    /// <summary>
    ///   <para>ocds:documentDateModified</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date that the document was last modified</para>
    /// labels<para>Document modification date</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#documentDateModified">http://purl.org/onto-ocds/ocds#documentDateModified</seealso>
    let documentDateModified =
        Prefixed_Name(ocds, "documentDateModified") |> PrefixedName

    /// <summary>
    ///   <para>ocds:documentId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A local, unique identifier for this document. This field is used to keep track of multiple revisions of a document through the compilation from release to record mechanism.</para>
    /// labels<para>Document ID</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#documentId">http://purl.org/onto-ocds/ocds#documentId</seealso>
    let documentId = Prefixed_Name(ocds, "documentId") |> PrefixedName
    /// <summary>
    ///   <para>ocds:documentLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Specifies the language of the linked document using either two-digit [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes), or extended [BCP47 language tags](http://www.w3.org/International/articles/language-tags/). The use of two-letter codes from [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) is strongly recommended unless there is a clear user need for distinguishing the language subtype.</para>
    /// labels<para>Document language</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#documentLanguage">http://purl.org/onto-ocds/ocds#documentLanguage</seealso>
    let documentLanguage = Prefixed_Name(ocds, "documentLanguage") |> PrefixedName
    /// <summary>
    ///   <para>ocds:documentTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The document title.</para>
    /// labels<para>Document title</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#documentTitle">http://purl.org/onto-ocds/ocds#documentTitle</seealso>
    let documentTitle = Prefixed_Name(ocds, "documentTitle") |> PrefixedName

    /// <summary>
    ///   <para>ocds:documentTypeAwardNotice</para>
    /// </summary>
    /// <remarks>
    ///   <para>ocds:DocumentType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The formal notice that gives details of the contract award. This may be a link to a downloadable document, to a web page, or to an official gazette in which the notice is contained.</para>
    /// labels<para>awardNotice</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#documentTypeAwardNotice">http://purl.org/onto-ocds/ocds#documentTypeAwardNotice</seealso>
    let documentTypeAwardNotice =
        Prefixed_Name(ocds, "documentTypeAwardNotice") |> PrefixedName

    /// <summary>
    ///   <para>ocds:documentTypeTenderNotice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ocds:DocumentType</para>
    ///   <para>The formal notice that gives details of a tender. This may be a link to a downloadable document, to a web page, or to an official gazette in which the notice is contained.</para>
    /// labels<para>tenderNotice</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#documentTypeTenderNotice">http://purl.org/onto-ocds/ocds#documentTypeTenderNotice</seealso>
    let documentTypeTenderNotice =
        Prefixed_Name(ocds, "documentTypeTenderNotice") |> PrefixedName

    /// <summary>
    ///   <para>ocds:documents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A list of documents related to the planning process.</para>
    /// labels<para>Documents</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#documents">http://purl.org/onto-ocds/ocds#documents</seealso>
    let documents = Prefixed_Name(ocds, "documents") |> PrefixedName
    /// <summary>
    ///   <para>ocds:dueDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The date the milestone is due.</para>
    /// labels<para>Due date</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#dueDate">http://purl.org/onto-ocds/ocds#dueDate</seealso>
    let dueDate = Prefixed_Name(ocds, "dueDate") |> PrefixedName
    /// <summary>
    ///   <para>ocds:endDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The end date for the period.</para>
    /// labels<para>End date</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#endDate">http://purl.org/onto-ocds/ocds#endDate</seealso>
    let endDate = Prefixed_Name(ocds, "endDate") |> PrefixedName
    /// <summary>
    ///   <para>ocds:enquiryPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The period during which enquiries may be made and answered.</para>
    /// labels<para>Enquiry period</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#enquiryPeriod">http://purl.org/onto-ocds/ocds#enquiryPeriod</seealso>
    let enquiryPeriod = Prefixed_Name(ocds, "enquiryPeriod") |> PrefixedName
    /// <summary>
    ///   <para>ocds:format</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The format of the document taken from the [IANA Media Types code list](http://www.iana.org/assignments/media-types/), with the addition of one extra value for 'offline/print', used when this document entry is being used to describe the offline publication of a document. Use values from the template column. Links to web pages should be tagged 'text/html'.</para>
    /// labels<para>Format</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#format">http://purl.org/onto-ocds/ocds#format</seealso>
    let format = Prefixed_Name(ocds, "format") |> PrefixedName
    /// <summary>
    ///   <para>ocds:former_value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The previous value of the changed property, in whatever type the property is.</para>
    /// labels<para>Former value</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#former_value">http://purl.org/onto-ocds/ocds#former_value</seealso>
    let former_value = Prefixed_Name(ocds, "former_value") |> PrefixedName
    /// <summary>
    ///   <para>ocds:ics_CDNCP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ocds:ItemClassificationScheme</para>
    ///   <para>Catálogo de productos, bienes y servicios de la Dirección Nacional de Contrataciones Públicas del Paraguay Nivel 5, basado en UNSPSC.</para>
    /// labels<para>CDNCP</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#ics_CDNCP">http://purl.org/onto-ocds/ocds#ics_CDNCP</seealso>
    let ics_CDNCP = Prefixed_Name(ocds, "ics_CDNCP") |> PrefixedName
    /// <summary>
    ///   <para>ocds:ics_CPV</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ocds:ItemClassificationScheme</para>
    ///   <para>The Common Procurement Vocabulary is a standard adopted by the Commission of the European Community, and consisting of a main vocabulary for defining the subject of a contract, and a supplementary vocabulary for adding further qualitative information. The main vocabulary, identified in OCDS by the code CPV, is based on a tree structure comprising codes of up to 9 digits (an 8 digit code plus a check digit) associated with a wording that describes the type of supplies, works or services forming the subject of the contract.</para>
    /// labels<para>CPV</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#ics_CPV">http://purl.org/onto-ocds/ocds#ics_CPV</seealso>
    let ics_CPV = Prefixed_Name(ocds, "ics_CPV") |> PrefixedName
    /// <summary>
    ///   <para>ocds:ics_CPVS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ocds:ItemClassificationScheme</para>
    ///   <para>The Common Procurement Vocabulary is a standard adopted by the Commission of the European Community, and consisting of a main vocabulary for defining the subject of a contract, and a supplementary vocabulary for adding further qualitative information. The supplementary vocabulary, identified in OCDS by the code CPVS, is made up of an alphanumeric code with a corresponding wording allowing further details to be added regarding the specific nature or destination of the goods to be purchased.</para>
    /// labels<para>CPVS</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#ics_CPVS">http://purl.org/onto-ocds/ocds#ics_CPVS</seealso>
    let ics_CPVS = Prefixed_Name(ocds, "ics_CPVS") |> PrefixedName
    /// <summary>
    ///   <para>ocds:ics_GSIN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ocds:ItemClassificationScheme</para>
    ///   <para>The Canadia federal government uses Goods and Services Identification Number (GSIN) codes to identify generic product descriptions for its procurement activities. The full list is published and maintained at buyandsell.gc.ca</para>
    /// labels<para>GSIN</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#ics_GSIN">http://purl.org/onto-ocds/ocds#ics_GSIN</seealso>
    let ics_GSIN = Prefixed_Name(ocds, "ics_GSIN") |> PrefixedName
    /// <summary>
    ///   <para>ocds:identifierId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The identifier of the organization in the selected scheme.</para>
    /// labels<para>Identifier ID</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#identifierId">http://purl.org/onto-ocds/ocds#identifierId</seealso>
    let identifierId = Prefixed_Name(ocds, "identifierId") |> PrefixedName
    /// <summary>
    ///   <para>ocds:identifierScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Organization identifiers be drawn from an existing identification scheme. This field is used to indicate the scheme or codelist in which the identifier will be found. This value should be drawn from the [Organization Identifier Scheme](http://standard.open-contracting.org/latest/en/schema/codelists/#organization-identifier-scheme).</para>
    /// labels<para>Identifier scheme</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#identifierScheme">http://purl.org/onto-ocds/ocds#identifierScheme</seealso>
    let identifierScheme = Prefixed_Name(ocds, "identifierScheme") |> PrefixedName
    /// <summary>
    ///   <para>ocds:identifierUri</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A URI to identify the organization, such as those provided by [Open Corporates](http://www.opencorporates.com) or some other relevant URI provider. This is not for listing the website of the organization: that can be done through the url field of the Organization contact point.</para>
    /// labels<para>Identifier URI</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#identifierUri">http://purl.org/onto-ocds/ocds#identifierUri</seealso>
    let identifierUri = Prefixed_Name(ocds, "identifierUri") |> PrefixedName
    /// <summary>
    ///   <para>ocds:implementation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Information related to the implementation of the contract in accordance with the obligations laid out therein.</para>
    /// labels<para>Implementation</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#implementation">http://purl.org/onto-ocds/ocds#implementation</seealso>
    let implementation = Prefixed_Name(ocds, "implementation") |> PrefixedName

    /// <summary>
    ///   <para>ocds:implementationDocuments</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Documents and reports that are part of the implementation phase e.g. audit and evaluation reports.</para>
    /// labels<para>Implementation documents</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#implementationDocuments">http://purl.org/onto-ocds/ocds#implementationDocuments</seealso>
    let implementationDocuments =
        Prefixed_Name(ocds, "implementationDocuments") |> PrefixedName

    /// <summary>
    ///   <para>ocds:initiationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>String specifying the type of initiation process used for this contract, taken from the [initiationType](http://standard.open-contracting.org/latest/en/schema/codelists/#initiation-type) codelist. Currently only tender is supported.</para>
    /// labels<para>Initiation Type</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#initiationType">http://purl.org/onto-ocds/ocds#initiationType</seealso>
    let initiationType = Prefixed_Name(ocds, "initiationType") |> PrefixedName
    /// <summary>
    ///   <para>ocds:itemDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A description of the goods, services to be provided.</para>
    /// labels<para>Item description</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#itemDescription">http://purl.org/onto-ocds/ocds#itemDescription</seealso>
    let itemDescription = Prefixed_Name(ocds, "itemDescription") |> PrefixedName
    /// <summary>
    ///   <para>ocds:itemId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A local identifier to reference and merge the items by. Must be unique within a given array of items.</para>
    /// labels<para>Item ID</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#itemId">http://purl.org/onto-ocds/ocds#itemId</seealso>
    let itemId = Prefixed_Name(ocds, "itemId") |> PrefixedName
    /// <summary>
    ///   <para>ocds:legalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The legally registered name of the organization.</para>
    /// labels<para>Legal name</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#legalName">http://purl.org/onto-ocds/ocds#legalName</seealso>
    let legalName = Prefixed_Name(ocds, "legalName") |> PrefixedName
    /// <summary>
    ///   <para>ocds:lotId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#lotId">http://purl.org/onto-ocds/ocds#lotId</seealso>
    let lotId = Prefixed_Name(ocds, "lotId") |> PrefixedName
    /// <summary>
    ///   <para>ocds:lotItems</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#lotItems">http://purl.org/onto-ocds/ocds#lotItems</seealso>
    let lotItems = Prefixed_Name(ocds, "lotItems") |> PrefixedName
    /// <summary>
    ///   <para>ocds:lotTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#lotTitle">http://purl.org/onto-ocds/ocds#lotTitle</seealso>
    let lotTitle = Prefixed_Name(ocds, "lotTitle") |> PrefixedName

    /// <summary>
    ///   <para>ocds:milestoneDateModified</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date the milestone was last reviewed or modified and the status was altered or confirmed to still be correct.</para>
    /// labels<para>Milestone modification date</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#milestoneDateModified">http://purl.org/onto-ocds/ocds#milestoneDateModified</seealso>
    let milestoneDateModified =
        Prefixed_Name(ocds, "milestoneDateModified") |> PrefixedName

    /// <summary>
    ///   <para>ocds:milestoneDocuments</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>List of documents associated with this milestone.</para>
    /// labels<para>Milestone documents</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#milestoneDocuments">http://purl.org/onto-ocds/ocds#milestoneDocuments</seealso>
    let milestoneDocuments = Prefixed_Name(ocds, "milestoneDocuments") |> PrefixedName
    /// <summary>
    ///   <para>ocds:milestoneId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A local identifier for this milestone, unique within this block. This field is used to keep track of multiple revisions of a milestone through the compilation from release to record mechanism.</para>
    /// labels<para>Milestone ID</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#milestoneId">http://purl.org/onto-ocds/ocds#milestoneId</seealso>
    let milestoneId = Prefixed_Name(ocds, "milestoneId") |> PrefixedName
    /// <summary>
    ///   <para>ocds:milestoneStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The status that was realized on the date provided in dateModified, drawn from the [milestoneStatus codelist](http://standard.open-contracting.org/latest/en/schema/codelists/#milestone-status).</para>
    /// labels<para>Milestone status</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#milestoneStatus">http://purl.org/onto-ocds/ocds#milestoneStatus</seealso>
    let milestoneStatus = Prefixed_Name(ocds, "milestoneStatus") |> PrefixedName
    /// <summary>
    ///   <para>ocds:milestoneTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Milestone title</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#milestoneTitle">http://purl.org/onto-ocds/ocds#milestoneTitle</seealso>
    let milestoneTitle = Prefixed_Name(ocds, "milestoneTitle") |> PrefixedName
    /// <summary>
    ///   <para>ocds:milestones</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A list of milestones associated with the tender.</para>
    /// labels<para>Milestones</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#milestones">http://purl.org/onto-ocds/ocds#milestones</seealso>
    let milestones = Prefixed_Name(ocds, "milestones") |> PrefixedName
    /// <summary>
    ///   <para>ocds:minValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The minimum estimated value of the procurement.</para>
    /// labels<para>Minimum value</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#minValue">http://purl.org/onto-ocds/ocds#minValue</seealso>
    let minValue = Prefixed_Name(ocds, "minValue") |> PrefixedName
    /// <summary>
    ///   <para>ocds:ocid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A globally unique identifier for this Open Contracting Process. Composed of a publisher prefix and an identifier for the contracting process. For more information see the [Open Contracting Identifier guidance](http://standard.open-contracting.org/latest/en/schema/identifiers/)</para>
    /// labels<para>Open Contracting ID</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#ocid">http://purl.org/onto-ocds/ocds#ocid</seealso>
    let ocid = Prefixed_Name(ocds, "ocid") |> PrefixedName
    /// <summary>
    ///   <para>ocds:ois_AF-CBR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ocds:OrganizationIdentifierScheme</para>
    ///   <para>Website not yet searchable.</para>
    /// labels<para>AF-CBR</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#ois_AF-CBR">http://purl.org/onto-ocds/ocds#ois_AF-CBR</seealso>
    let ois_AF_CBR = Prefixed_Name(ocds, "ois_AF-CBR") |> PrefixedName
    /// <summary>
    ///   <para>ocds:ois_AF-MOE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ocds:OrganizationIdentifierScheme</para>
    ///   <para></para>
    /// labels<para>AF-MOE</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#ois_AF-MOE">http://purl.org/onto-ocds/ocds#ois_AF-MOE</seealso>
    let ois_AF_MOE = Prefixed_Name(ocds, "ois_AF-MOE") |> PrefixedName
    /// <summary>
    ///   <para>ocds:organizationName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The common name of the organization. The ID property provides an space for the formal legal name, and so this may either repeat that value, or could provide the common name by which this organization is known. This field could also include details of the department or sub-unit involved in this contracting process.</para>
    /// labels<para>Organization name</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#organizationName">http://purl.org/onto-ocds/ocds#organizationName</seealso>
    let organizationName = Prefixed_Name(ocds, "organizationName") |> PrefixedName
    /// <summary>
    ///   <para>ocds:planningPrecedes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#planningPrecedes">http://purl.org/onto-ocds/ocds#planningPrecedes</seealso>
    let planningPrecedes = Prefixed_Name(ocds, "planningPrecedes") |> PrefixedName
    /// <summary>
    ///   <para>ocds:planningRationale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The rationale for the procurement provided in free text. More detail can be provided in an attached document.</para>
    /// labels<para>Planning rationale</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#planningRationale">http://purl.org/onto-ocds/ocds#planningRationale</seealso>
    let planningRationale = Prefixed_Name(ocds, "planningRationale") |> PrefixedName
    /// <summary>
    ///   <para>ocds:planningUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Url para poder identificar el servicio que es utilizado para generar la planificación</para>
    /// labels<para>Planning URL</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#planningUrl">http://purl.org/onto-ocds/ocds#planningUrl</seealso>
    let planningUrl = Prefixed_Name(ocds, "planningUrl") |> PrefixedName
    /// <summary>
    ///   <para>ocds:postalCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The postal code. For example, 94043.</para>
    /// labels<para>Postal code</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#postalCode">http://purl.org/onto-ocds/ocds#postalCode</seealso>
    let postalCode = Prefixed_Name(ocds, "postalCode") |> PrefixedName
    /// <summary>
    ///   <para>ocds:procurementMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Specify tendering method against the [method codelist](http://standard.open-contracting.org/latest/en/schema/codelists/#method) as per [GPA definitions](http://www.wto.org/english/docs_e/legal_e/rev-gpr-94_01_e.htm) of Open, Selective, Limited</para>
    /// labels<para>Procurement method</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#procurementMethod">http://purl.org/onto-ocds/ocds#procurementMethod</seealso>
    let procurementMethod = Prefixed_Name(ocds, "procurementMethod") |> PrefixedName

    /// <summary>
    ///   <para>ocds:procurementMethodRationale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Rationale of procurement method, especially in the case of Limited tendering.</para>
    /// labels<para>Procurement method rationale</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#procurementMethodRationale">http://purl.org/onto-ocds/ocds#procurementMethodRationale</seealso>
    let procurementMethodRationale =
        Prefixed_Name(ocds, "procurementMethodRationale") |> PrefixedName

    /// <summary>
    ///   <para>ocds:projectID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>An external identifier for the project that this contracting process forms part of, or is funded via (if applicable). Some organizations maintain a registry of projects, and the data should use the identifier from the relevant registry of projects.</para>
    /// labels<para>Project Identifier</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#projectID">http://purl.org/onto-ocds/ocds#projectID</seealso>
    let projectID = Prefixed_Name(ocds, "projectID") |> PrefixedName
    /// <summary>
    ///   <para>ocds:property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The property name that has been changed relative to the place the amendment is. For example if the contract value has changed, then the property under changes within the contract.amendment would be value.amount.</para>
    /// labels<para>Property</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#property">http://purl.org/onto-ocds/ocds#property</seealso>
    let property = Prefixed_Name(ocds, "property") |> PrefixedName

    /// <summary>
    ///   <para>ocds:providerOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The Organization Identifier for the organization from which the funds in this transaction originate. Expressed following the Organizational Identifier standard - consult the documentation and the codelist.</para>
    /// labels<para>Provider organization</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#providerOrganization">http://purl.org/onto-ocds/ocds#providerOrganization</seealso>
    let providerOrganization =
        Prefixed_Name(ocds, "providerOrganization") |> PrefixedName

    /// <summary>
    ///   <para>ocds:quantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number of units required</para>
    /// labels<para>quantity</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#quantity">http://purl.org/onto-ocds/ocds#quantity</seealso>
    let quantity = Prefixed_Name(ocds, "quantity") |> PrefixedName

    /// <summary>
    ///   <para>ocds:receiverOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The Organization Identifier for the organization which receives the funds in this transaction. Expressed following the Organizational Identifier standard - consult the documentation and the codelist.</para>
    /// labels<para>Receiver organization</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#receiverOrganization">http://purl.org/onto-ocds/ocds#receiverOrganization</seealso>
    let receiverOrganization =
        Prefixed_Name(ocds, "receiverOrganization") |> PrefixedName

    /// <summary>
    ///   <para>ocds:region</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The region. For example, CA.</para>
    /// labels<para>Region</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#region">http://purl.org/onto-ocds/ocds#region</seealso>
    let region = Prefixed_Name(ocds, "region") |> PrefixedName
    /// <summary>
    ///   <para>ocds:releaseLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>pecifies the default language of the data using either two-digit ISO 639-1, or extended BCP47 language tags. The use of two-letter codes from ISO 639-1 is strongly recommended.</para>
    /// labels<para>Release language</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#releaseLanguage">http://purl.org/onto-ocds/ocds#releaseLanguage</seealso>
    let releaseLanguage = Prefixed_Name(ocds, "releaseLanguage") |> PrefixedName
    /// <summary>
    ///   <para>ocds:startDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The start date for the period.</para>
    /// labels<para>Start date</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#startDate">http://purl.org/onto-ocds/ocds#startDate</seealso>
    let startDate = Prefixed_Name(ocds, "startDate") |> PrefixedName
    /// <summary>
    ///   <para>ocds:streetAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The street address. For example, 1600 Amphitheatre Pkwy</para>
    /// labels<para>Street address</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#streetAddress">http://purl.org/onto-ocds/ocds#streetAddress</seealso>
    let streetAddress = Prefixed_Name(ocds, "streetAddress") |> PrefixedName
    /// <summary>
    ///   <para>ocds:submissionMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>pecify the method by which bids must be submitted, in person, written, or electronic auction. Using the [submission method codelist](http://standard.open-contracting.org/latest/en/schema/codelists/#submission-method)</para>
    /// labels<para>Submission method</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#submissionMethod">http://purl.org/onto-ocds/ocds#submissionMethod</seealso>
    let submissionMethod = Prefixed_Name(ocds, "submissionMethod") |> PrefixedName

    /// <summary>
    ///   <para>ocds:submissionMethodDetails</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Any detailed or further information on the submission method. This may include the address, e-mail address or online service to which bids should be submitted, and any special requirements to be followed for submissions.</para>
    /// labels<para>Submission method details</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#submissionMethodDetails">http://purl.org/onto-ocds/ocds#submissionMethodDetails</seealso>
    let submissionMethodDetails =
        Prefixed_Name(ocds, "submissionMethodDetails") |> PrefixedName

    /// <summary>
    ///   <para>ocds:submissionMethodElectronicAuction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ocds:SubmissionMethod</para>
    ///
    /// labels<para>electronicAuction</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#submissionMethodElectronicAuction">http://purl.org/onto-ocds/ocds#submissionMethodElectronicAuction</seealso>
    let submissionMethodElectronicAuction =
        Prefixed_Name(ocds, "submissionMethodElectronicAuction") |> PrefixedName

    /// <summary>
    ///   <para>ocds:submissionMethodElectronicSubmission</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ocds:SubmissionMethod</para>
    ///
    /// labels<para>electronicSubmission</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#submissionMethodElectronicSubmission">http://purl.org/onto-ocds/ocds#submissionMethodElectronicSubmission</seealso>
    let submissionMethodElectronicSubmission =
        Prefixed_Name(ocds, "submissionMethodElectronicSubmission") |> PrefixedName

    /// <summary>
    ///   <para>ocds:submissionMethodInPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ocds:SubmissionMethod</para>
    ///
    /// labels<para>inPerson</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#submissionMethodInPerson">http://purl.org/onto-ocds/ocds#submissionMethodInPerson</seealso>
    let submissionMethodInPerson =
        Prefixed_Name(ocds, "submissionMethodInPerson") |> PrefixedName

    /// <summary>
    ///   <para>ocds:submissionMethodWritten</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ocds:SubmissionMethod</para>
    ///
    /// labels<para>written</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#submissionMethodWritten">http://purl.org/onto-ocds/ocds#submissionMethodWritten</seealso>
    let submissionMethodWritten =
        Prefixed_Name(ocds, "submissionMethodWritten") |> PrefixedName

    /// <summary>
    ///   <para>ocds:suppliers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The suppliers awarded this award. If different suppliers have been awarded different items of values, these should be split into separate award blocks.</para>
    /// labels<para>Suppliers</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#suppliers">http://purl.org/onto-ocds/ocds#suppliers</seealso>
    let suppliers = Prefixed_Name(ocds, "suppliers") |> PrefixedName
    /// <summary>
    ///   <para>ocds:tag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A value from the [releaseTag codelist](http://standard.open-contracting.org/latest/en/schema/codelists/#release-tag) that identifies the nature of the release being made. Tags may be used to filter release, or, in future, for for advanced validation when certain kinds of releases should contain certain fields.</para>
    /// labels<para>Release Tag</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#tag">http://purl.org/onto-ocds/ocds#tag</seealso>
    let tag = Prefixed_Name(ocds, "tag") |> PrefixedName
    /// <summary>
    ///   <para>ocds:telephone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The telephone number of the contact point/person. This should include the international dialling code.</para>
    /// labels<para>Telephone</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#telephone">http://purl.org/onto-ocds/ocds#telephone</seealso>
    let telephone = Prefixed_Name(ocds, "telephone") |> PrefixedName
    /// <summary>
    ///   <para>ocds:tenderDocuments</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>All documents and attachments related to the tender, including any notices. See the [documentType codelist](http://standard.open-contracting.org/latest/en/schema/codelists/#document-type) for details of potential documents to include.</para>
    /// labels<para>Tender documents</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#tenderDocuments">http://purl.org/onto-ocds/ocds#tenderDocuments</seealso>
    let tenderDocuments = Prefixed_Name(ocds, "tenderDocuments") |> PrefixedName
    /// <summary>
    ///   <para>ocds:tenderFollows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#tenderFollows">http://purl.org/onto-ocds/ocds#tenderFollows</seealso>
    let tenderFollows = Prefixed_Name(ocds, "tenderFollows") |> PrefixedName
    /// <summary>
    ///   <para>ocds:tenderId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>An identifier for this tender process. This may be the same as the ocid, or may be drawn from an internally held identifier for this tender.</para>
    /// labels<para>Tender ID</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#tenderId">http://purl.org/onto-ocds/ocds#tenderId</seealso>
    let tenderId = Prefixed_Name(ocds, "tenderId") |> PrefixedName
    /// <summary>
    ///   <para>ocds:tenderItems</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The goods and services to be purchased, broken into line items wherever possible. Items should not be duplicated, but a quantity of 2 specified instead.</para>
    /// labels<para>Items to be procured</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#tenderItems">http://purl.org/onto-ocds/ocds#tenderItems</seealso>
    let tenderItems = Prefixed_Name(ocds, "tenderItems") |> PrefixedName
    /// <summary>
    ///   <para>ocds:tenderLots</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>List of lots associated with the tender</para>
    /// labels<para>Tender lots</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#tenderLots">http://purl.org/onto-ocds/ocds#tenderLots</seealso>
    let tenderLots = Prefixed_Name(ocds, "tenderLots") |> PrefixedName
    /// <summary>
    ///   <para>ocds:tenderPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The period when the tender is open for submissions. The end date is the closing date for tender submissions.</para>
    /// labels<para>Tender period</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#tenderPeriod">http://purl.org/onto-ocds/ocds#tenderPeriod</seealso>
    let tenderPeriod = Prefixed_Name(ocds, "tenderPeriod") |> PrefixedName
    /// <summary>
    ///   <para>ocds:tenderPrecedes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#tenderPrecedes">http://purl.org/onto-ocds/ocds#tenderPrecedes</seealso>
    let tenderPrecedes = Prefixed_Name(ocds, "tenderPrecedes") |> PrefixedName
    /// <summary>
    ///   <para>ocds:tenderStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The current status of the tender based on the [tenderStatus codelist](http://standard.open-contracting.org/latest/en/schema/codelists/#tender-status)</para>
    /// labels<para>Tender Status</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#tenderStatus">http://purl.org/onto-ocds/ocds#tenderStatus</seealso>
    let tenderStatus = Prefixed_Name(ocds, "tenderStatus") |> PrefixedName
    /// <summary>
    ///   <para>ocds:tenderTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Tender title</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#tenderTitle">http://purl.org/onto-ocds/ocds#tenderTitle</seealso>
    let tenderTitle = Prefixed_Name(ocds, "tenderTitle") |> PrefixedName
    /// <summary>
    ///   <para>ocds:tenderUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Url para poder identificar el servicio que es utilizado para generar la convocatoria</para>
    /// labels<para>Tender URL</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#tenderUrl">http://purl.org/onto-ocds/ocds#tenderUrl</seealso>
    let tenderUrl = Prefixed_Name(ocds, "tenderUrl") |> PrefixedName
    /// <summary>
    ///   <para>ocds:transactionAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The value of the transaction.</para>
    /// labels<para>Transaction amount</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#transactionAmount">http://purl.org/onto-ocds/ocds#transactionAmount</seealso>
    let transactionAmount = Prefixed_Name(ocds, "transactionAmount") |> PrefixedName
    /// <summary>
    ///   <para>ocds:transactionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date of the transaction</para>
    /// labels<para>Transaction date</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#transactionDate">http://purl.org/onto-ocds/ocds#transactionDate</seealso>
    let transactionDate = Prefixed_Name(ocds, "transactionDate") |> PrefixedName
    /// <summary>
    ///   <para>ocds:transactionId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A unique identifier for this transaction. This identifier should be possible to cross-reference against the provided data source. For the budget data package this is the id, for IATI, the transaction reference.</para>
    /// labels<para>Transaction ID</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#transactionId">http://purl.org/onto-ocds/ocds#transactionId</seealso>
    let transactionId = Prefixed_Name(ocds, "transactionId") |> PrefixedName
    /// <summary>
    ///   <para>ocds:transactionSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Used to point either to a corresponding Budget Data Package, IATI file, or machine or human-readable source where users can find further information on the budget line item identifiers, or project identifiers, provided here.</para>
    /// labels<para>Transaction Data Source</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#transactionSource">http://purl.org/onto-ocds/ocds#transactionSource</seealso>
    let transactionSource = Prefixed_Name(ocds, "transactionSource") |> PrefixedName
    /// <summary>
    ///   <para>ocds:transactionUri</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A URI pointing directly to a machine-readable record about this spending transaction.</para>
    /// labels<para>Linked spending information</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#transactionUri">http://purl.org/onto-ocds/ocds#transactionUri</seealso>
    let transactionUri = Prefixed_Name(ocds, "transactionUri") |> PrefixedName
    /// <summary>
    ///   <para>ocds:transactions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A list of the spending transactions made against this contract</para>
    /// labels<para>Transactions</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#transactions">http://purl.org/onto-ocds/ocds#transactions</seealso>
    let transactions = Prefixed_Name(ocds, "transactions") |> PrefixedName
    /// <summary>
    ///   <para>ocds:unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Description of the unit which the good comes in e.g. hours, kilograms. Made up of a unit name, and the value of a single unit.</para>
    /// labels<para>Unit</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#unit">http://purl.org/onto-ocds/ocds#unit</seealso>
    let unit = Prefixed_Name(ocds, "unit") |> PrefixedName
    /// <summary>
    ///   <para>ocds:unitName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Name of the unit</para>
    /// labels<para>Unit name</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#unitName">http://purl.org/onto-ocds/ocds#unitName</seealso>
    let unitName = Prefixed_Name(ocds, "unitName") |> PrefixedName
    /// <summary>
    ///   <para>ocds:unitValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Unit value</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#unitValue">http://purl.org/onto-ocds/ocds#unitValue</seealso>
    let unitValue = Prefixed_Name(ocds, "unitValue") |> PrefixedName
    /// <summary>
    ///   <para>ocds:valueAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Amount as a number.</para>
    /// labels<para>Amount</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#valueAmount">http://purl.org/onto-ocds/ocds#valueAmount</seealso>
    let valueAmount = Prefixed_Name(ocds, "valueAmount") |> PrefixedName
    /// <summary>
    ///   <para>ocds:awardPrecedes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#awardPrecedes">http://purl.org/onto-ocds/ocds#awardPrecedes</seealso>
    let awardPrecedes = Prefixed_Name(ocds, "awardPrecedes") |> PrefixedName
    /// <summary>
    ///   <para>ocds:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#">http://purl.org/onto-ocds/ocds#</seealso>
    let _prefix_iri = Prefixed_Name(ocds, "") |> PrefixedName
    /// <summary>
    ///   <para>ocds:Amendment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Amendment</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#Amendment">http://purl.org/onto-ocds/ocds#Amendment</seealso>
    let Amendment = Prefixed_Name(ocds, "Amendment") |> PrefixedName
    /// <summary>
    ///   <para>ocds:Contract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information regarding the signed contract between the buyer and supplier(s).</para>
    /// labels<para>Contract</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#Contract">http://purl.org/onto-ocds/ocds#Contract</seealso>
    let Contract = Prefixed_Name(ocds, "Contract") |> PrefixedName
    /// <summary>
    ///   <para>ocds:ContractStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Contracts can move through multiple states. Releases over time may update the status of a contract.</para>
    /// labels<para>Codelist Contract Status</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#ContractStatus">http://purl.org/onto-ocds/ocds#ContractStatus</seealso>
    let ContractStatus = Prefixed_Name(ocds, "ContractStatus") |> PrefixedName

    /// <summary>
    ///   <para>ocds:contractStatusCancelled</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ocds:ContractStatus</para>
    ///   <para>This contract has been cancelled prior to being signed.</para>
    /// labels<para>cancelled</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#contractStatusCancelled">http://purl.org/onto-ocds/ocds#contractStatusCancelled</seealso>
    let contractStatusCancelled =
        Prefixed_Name(ocds, "contractStatusCancelled") |> PrefixedName

    /// <summary>
    ///   <para>ocds:Document</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Links to, or descriptions of, external documents can be attached at various locations within the standard. Documents may be supporting information, formal notices, downloadable forms, or any other kind of resource that should be made public as part of full open contracting.</para>
    /// labels<para>Document</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#Document">http://purl.org/onto-ocds/ocds#Document</seealso>
    let Document = Prefixed_Name(ocds, "Document") |> PrefixedName
    /// <summary>
    ///   <para>ocds:Implementation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information during the performance / implementation stage of the contract.</para>
    /// labels<para>Implementation</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#Implementation">http://purl.org/onto-ocds/ocds#Implementation</seealso>
    let Implementation = Prefixed_Name(ocds, "Implementation") |> PrefixedName
    /// <summary>
    ///   <para>ocds:Item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A good, service, or work to be contracted.</para>
    /// labels<para>Item</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#Item">http://purl.org/onto-ocds/ocds#Item</seealso>
    let Item = Prefixed_Name(ocds, "Item") |> PrefixedName

    /// <summary>
    ///   <para>ocds:ItemClassificationScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#ItemClassificationScheme">http://purl.org/onto-ocds/ocds#ItemClassificationScheme</seealso>
    let ItemClassificationScheme =
        Prefixed_Name(ocds, "ItemClassificationScheme") |> PrefixedName

    /// <summary>
    ///   <para>ocds:Method</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The method codelist is based upon the GPA Definitions provided here.</para>
    /// labels<para>Codelist Method</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#Method">http://purl.org/onto-ocds/ocds#Method</seealso>
    let Method = Prefixed_Name(ocds, "Method") |> PrefixedName
    /// <summary>
    ///   <para>ocds:methodOpen</para>
    /// </summary>
    /// <remarks>
    ///   <para>ocds:Method</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Open tendering means a procurement method whereby all interested suppliers may submit a tender.</para>
    /// labels<para>open</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#methodOpen">http://purl.org/onto-ocds/ocds#methodOpen</seealso>
    let methodOpen = Prefixed_Name(ocds, "methodOpen") |> PrefixedName
    /// <summary>
    ///   <para>ocds:Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An organization.</para>
    /// labels<para>Organization</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#Organization">http://purl.org/onto-ocds/ocds#Organization</seealso>
    let Organization = Prefixed_Name(ocds, "Organization") |> PrefixedName
    /// <summary>
    ///   <para>ocds:Release</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Open Contracting Release</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#Release">http://purl.org/onto-ocds/ocds#Release</seealso>
    let Release = Prefixed_Name(ocds, "Release") |> PrefixedName

    /// <summary>
    ///   <para>ocds:releaseTagContractUpdate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ocds:ReleaseTag</para>
    ///
    /// labels<para>contractUpdate</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#releaseTagContractUpdate">http://purl.org/onto-ocds/ocds#releaseTagContractUpdate</seealso>
    let releaseTagContractUpdate =
        Prefixed_Name(ocds, "releaseTagContractUpdate") |> PrefixedName

    /// <summary>
    ///   <para>ocds:releaseTagImplementation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ocds:ReleaseTag</para>
    ///
    /// labels<para>implementation</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#releaseTagImplementation">http://purl.org/onto-ocds/ocds#releaseTagImplementation</seealso>
    let releaseTagImplementation =
        Prefixed_Name(ocds, "releaseTagImplementation") |> PrefixedName

    /// <summary>
    ///   <para>ocds:releaseTagTenderAmendment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ocds:ReleaseTag</para>
    ///   <para>An amendment to an existing tender release. There should be at least one tender release with the same ocid, but an earlier releaseDate, before a tenderAmendment is published. The term amendment has legal meaning in many jurisdictions.</para>
    /// labels<para>tenderAmendment</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#releaseTagTenderAmendment">http://purl.org/onto-ocds/ocds#releaseTagTenderAmendment</seealso>
    let releaseTagTenderAmendment =
        Prefixed_Name(ocds, "releaseTagTenderAmendment") |> PrefixedName

    /// <summary>
    ///   <para>ocds:releaseTagTenderCancellation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ocds:ReleaseTag</para>
    ///
    /// labels<para>tenderCancellation</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#releaseTagTenderCancellation">http://purl.org/onto-ocds/ocds#releaseTagTenderCancellation</seealso>
    let releaseTagTenderCancellation =
        Prefixed_Name(ocds, "releaseTagTenderCancellation") |> PrefixedName

    /// <summary>
    ///   <para>ocds:hasEnquiries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para> Yes/No field to indicate whether enquiries were part of tender process.</para>
    /// labels<para>Has enquiries</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#hasEnquiries">http://purl.org/onto-ocds/ocds#hasEnquiries</seealso>
    let hasEnquiries = Prefixed_Name(ocds, "hasEnquiries") |> PrefixedName
    /// <summary>
    ///   <para>ocds:ics_UNSPSC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ocds:ItemClassificationScheme</para>
    ///   <para>The United Nations Standard Products and Services Code (UNSPSC) is a hierarchical convention that is used to classify all products and services. Machine readable meta-data for UNSPSC is not provided as open data: and so publishers should consider alternative classification shemes that do provide open data lookup tables wherever possible.</para>
    /// labels<para>UNSPSC</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#ics_UNSPSC">http://purl.org/onto-ocds/ocds#ics_UNSPSC</seealso>
    let ics_UNSPSC = Prefixed_Name(ocds, "ics_UNSPSC") |> PrefixedName
    /// <summary>
    ///   <para>ocds:id</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A unique identifier that identifies this release. A release ID must be unique within a release-package and must not contain the # character.</para>
    /// labels<para>Release ID</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#id">http://purl.org/onto-ocds/ocds#id</seealso>
    let id = Prefixed_Name(ocds, "id") |> PrefixedName
    /// <summary>
    ///   <para>ocds:identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The primary identifier for this organization. Identifiers that uniquely pick out a legal entity should be preferred. Consult the [organization identifier guidance](http://standard.open-contracting.org/latest/en/schema/identifiers/) for the preferred scheme and identifier to use.</para>
    /// labels<para>Organization identifier</para></remarks>
    /// <seealso href="http://purl.org/onto-ocds/ocds#identifier">http://purl.org/onto-ocds/ocds#identifier</seealso>
    let identifier = Prefixed_Name(ocds, "identifier") |> PrefixedName

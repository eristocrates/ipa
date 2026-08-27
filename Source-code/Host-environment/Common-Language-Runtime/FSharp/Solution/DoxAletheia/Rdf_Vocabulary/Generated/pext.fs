namespace http.www.ontotext.com.proton.protonext.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pext =
    let _namespace_iri = Namespace_Iri pext |> NamespaceIRI
    /// <summary>
    ///   <para>onto:proton/protonext#isAuthorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Any author of a product. Links an author (producer) to its creation ."</para>
    /// labels<para>"Author"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#isAuthorOf">http://www.ontotext.com/proton/protonext#isAuthorOf</seealso>
    let isAuthorOf = Prefixed_Name(pext, "isAuthorOf") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#isBirthPlaceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A place where a person is born. The relation between a location and a person who is born in this location."</para>
    /// labels<para>"is a Birth Place of"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#isBirthPlaceOf">http://www.ontotext.com/proton/protonext#isBirthPlaceOf</seealso>
    let isBirthPlaceOf = Prefixed_Name(pext, "isBirthPlaceOf") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#isCurrentlyInterestedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isCurrentlyInterestedIn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#isCurrentlyInterestedIn">http://www.ontotext.com/proton/protonext#isCurrentlyInterestedIn</seealso>
    let isCurrentlyInterestedIn =
        Prefixed_Name(pext, "isCurrentlyInterestedIn") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#isInterestedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isInterestedIn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#isInterestedIn">http://www.ontotext.com/proton/protonext#isInterestedIn</seealso>
    let isInterestedIn = Prefixed_Name(pext, "isInterestedIn") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#isWrittenAbout</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between an RDF document containing the descriptions of locations that share a common border"</para>
    /// labels<para>"RDF document containing the descriptions of locations that share a common border"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#isWrittenAbout">http://www.ontotext.com/proton/protonext#isWrittenAbout</seealso>
    let isWrittenAbout = Prefixed_Name(pext, "isWrittenAbout") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#issueOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation of a specific issue, number, and/or volume and a periodical publication."</para>
    /// labels<para>"Issue of"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#issueOf">http://www.ontotext.com/proton/protonext#issueOf</seealso>
    let issueOf = Prefixed_Name(pext, "issueOf") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#locationMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a geographic region and a map depicting its location"</para>
    /// labels<para>"Location Map"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#locationMap">http://www.ontotext.com/proton/protonext#locationMap</seealso>
    let locationMap = Prefixed_Name(pext, "locationMap") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#locationName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The name of a georgaphic region."</para>
    /// labels<para>"Location Name"</para><para>"Name"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#locationName">http://www.ontotext.com/proton/protonext#locationName</seealso>
    let locationName = Prefixed_Name(pext, "locationName") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#musicInstrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a musician and the instrument he plays"</para>
    /// labels<para>"Instrument of a Musician"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#musicInstrument">http://www.ontotext.com/proton/protonext#musicInstrument</seealso>
    let musicInstrument = Prefixed_Name(pext, "musicInstrument") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#nationalityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The nationality of a person. The relation between a person and his nationality."</para>
    /// labels<para>"Nationality of a Person"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#nationalityOf">http://www.ontotext.com/proton/protonext#nationalityOf</seealso>
    let nationalityOf = Prefixed_Name(pext, "nationalityOf") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#nearby</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation of a location nearby another location"</para>
    /// labels<para>"Location Nearby another Location"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#nearby">http://www.ontotext.com/proton/protonext#nearby</seealso>
    let nearby = Prefixed_Name(pext, "nearby") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#neighbour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation of a location sharing a common location with another location"</para>
    /// labels<para>"Location Sharing a Common Location with Another Location"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#neighbour">http://www.ontotext.com/proton/protonext#neighbour</seealso>
    let neighbour = Prefixed_Name(pext, "neighbour") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#ofCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a government organization and its country."</para>
    /// labels<para>"of Country"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#ofCountry">http://www.ontotext.com/proton/protonext#ofCountry</seealso>
    let ofCountry = Prefixed_Name(pext, "ofCountry") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#officialPositionIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property models the Person-&gt;hasPosition-&gt;Location."</para>
    /// labels<para>"Official Position in"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#officialPositionIn">http://www.ontotext.com/proton/protonext#officialPositionIn</seealso>
    let officialPositionIn = Prefixed_Name(pext, "officialPositionIn") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#organizationPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between an organization and a concrete job position in it."</para>
    /// labels<para>"within Organization"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#organizationPosition">http://www.ontotext.com/proton/protonext#organizationPosition</seealso>
    let organizationPosition =
        Prefixed_Name(pext, "organizationPosition") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#ownerOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relationship between an object and an agent who owns it."</para>
    /// labels<para>"Owner"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#ownerOf">http://www.ontotext.com/proton/protonext#ownerOf</seealso>
    let ownerOf = Prefixed_Name(pext, "ownerOf") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#ownershipOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relationship between an object being a property/possessions of somebody."</para>
    /// labels<para>"Ownership"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#ownershipOf">http://www.ontotext.com/proton/protonext#ownershipOf</seealso>
    let ownershipOf = Prefixed_Name(pext, "ownershipOf") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#partOfPostalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation between the part of postal address and a given postal address."</para>
    /// labels<para>"a Part of a Postal Address"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#partOfPostalAddress">http://www.ontotext.com/proton/protonext#partOfPostalAddress</seealso>
    let partOfPostalAddress = Prefixed_Name(pext, "partOfPostalAddress") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#pointAwardedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between the scored point in a sport game and the sport club who won it."</para>
    /// labels<para>"Awarded Sport Club"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#pointAwardedTo">http://www.ontotext.com/proton/protonext#pointAwardedTo</seealso>
    let pointAwardedTo = Prefixed_Name(pext, "pointAwardedTo") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#positionContactInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a position and the contact information for it. This contact information can be the postal address of the office for the position or an virtual address in the Internet."</para>
    /// labels<para>"Contact Information for a Position within Organization"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#positionContactInformation">http://www.ontotext.com/proton/protonext#positionContactInformation</seealso>
    let positionContactInformation =
        Prefixed_Name(pext, "positionContactInformation") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#positionWithinOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between the job position and the organization it is available in. The organization where the job position is available."</para>
    /// labels<para>"Position within Organization"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#positionWithinOrganization">http://www.ontotext.com/proton/protonext#positionWithinOrganization</seealso>
    let positionWithinOrganization =
        Prefixed_Name(pext, "positionWithinOrganization") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#productOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a producer and the product produced. The producer is restricted to an organization, like Microsoft, Ford, GM, etc."</para>
    /// labels<para>"Product"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#productOf">http://www.ontotext.com/proton/protonext#productOf</seealso>
    let productOf = Prefixed_Name(pext, "productOf") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#publishedWithin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between an article and the colelction within which the article is published."</para>
    /// labels<para>"Published within"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#publishedWithin">http://www.ontotext.com/proton/protonext#publishedWithin</seealso>
    let publishedWithin = Prefixed_Name(pext, "publishedWithin") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#socialPositionCelebrity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a social position of Celebrity and the person who has it."</para>
    /// labels<para>"Social Position Holder Celebrity"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#socialPositionCelebrity">http://www.ontotext.com/proton/protonext#socialPositionCelebrity</seealso>
    let socialPositionCelebrity =
        Prefixed_Name(pext, "socialPositionCelebrity") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#socialPositionCleric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a social position of Cleric and the person who has it."</para>
    /// labels<para>"Social Position Cleric"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#socialPositionCleric">http://www.ontotext.com/proton/protonext#socialPositionCleric</seealso>
    let socialPositionCleric =
        Prefixed_Name(pext, "socialPositionCleric") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#socialPositionNobelty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a social position of Nobelty and the person who has it."</para>
    /// labels<para>"Social Position Holder Nobelty"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#socialPositionNobelty">http://www.ontotext.com/proton/protonext#socialPositionNobelty</seealso>
    let socialPositionNobelty =
        Prefixed_Name(pext, "socialPositionNobelty") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#socialPositionOutOfLaws</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a social position of OutOfLaws and the person who has it."</para>
    /// labels<para>"Social Position Holder OutOfLaws"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#socialPositionOutOfLaws">http://www.ontotext.com/proton/protonext#socialPositionOutOfLaws</seealso>
    let socialPositionOutOfLaws =
        Prefixed_Name(pext, "socialPositionOutOfLaws") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#stockExchangeIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Name of the company on the Stock Exchange, where it is traded. At present, if a company is traded on two SEs with different indices, there is no way to encode which of them is applicable where."</para>
    /// labels<para>"Stock Exchange Index"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#stockExchangeIndex">http://www.ontotext.com/proton/protonext#stockExchangeIndex</seealso>
    let stockExchangeIndex = Prefixed_Name(pext, "stockExchangeIndex") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#subSectorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"The general part-of relation that takes place between a whole and each of its parts. It has number of specializations."</para>
    /// labels<para>"Subsector of"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#subSectorOf">http://www.ontotext.com/proton/protonext#subSectorOf</seealso>
    let subSectorOf = Prefixed_Name(pext, "subSectorOf") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#tradedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates the Public Company to the Stock Exchange where it is traded"</para>
    /// labels<para>"Traded on"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#tradedOn">http://www.ontotext.com/proton/protonext#tradedOn</seealso>
    let tradedOn = Prefixed_Name(pext, "tradedOn") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#transmission</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Describes the transmission type of a given car model"</para>
    /// labels<para>"transmission"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#transmission">http://www.ontotext.com/proton/protonext#transmission</seealso>
    let transmission = Prefixed_Name(pext, "transmission") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#ATM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An unattended electronic machine in a public place, connected to a data system and related equipment and activated by a bank customer to obtain cash withdrawals and other banking services."</para>
    /// labels<para>"Automatic Teller Machine (ATM)"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#ATM">http://www.ontotext.com/proton/protonext#ATM</seealso>
    let ATM = Prefixed_Name(pext, "ATM") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#AcademicJournal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A journal publishing scientific articles"</para>
    /// labels<para>"Academic journal"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#AcademicJournal">http://www.ontotext.com/proton/protonext#AcademicJournal</seealso>
    let AcademicJournal = Prefixed_Name(pext, "AcademicJournal") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Accident</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Accident"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Accident">http://www.ontotext.com/proton/protonext#Accident</seealso>
    let Accident = Prefixed_Name(pext, "Accident") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Account</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An explicit agreement between agents. Typically, service providers (e.g. banks or ISPs) provide accounts to their customers or users, which are considered account owners. The existence of the account depends on the provider, even though the user owns it in some metaphoric sense. Examples could be bank, ISP, e-Commerce, ICQ, email accounts. The accounts are usually aligned with a sort of contract."</para>
    /// labels<para>"Account"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Account">http://www.ontotext.com/proton/protonext#Account</seealso>
    let Account = Prefixed_Name(pext, "Account") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Acquirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The event of the acquiring of one organization by another."</para>
    /// labels<para>"Acquirement"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Acquirement">http://www.ontotext.com/proton/protonext#Acquirement</seealso>
    let Acquirement = Prefixed_Name(pext, "Acquirement") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Each activity is a Happening which involves volition and participants. It has temporal dimension. It is distinguished from Events by the fact that the activity does not trigger change of state and does not have a conceptual end point."</para>
    /// labels<para>"Activity"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Activity">http://www.ontotext.com/proton/protonext#Activity</seealso>
    let Activity = Prefixed_Name(pext, "Activity") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Actor</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#ArtProfession</para>
    ///   <para>"Any actor acts in a dramatic production and who works in film, television, theatre, or radio in that capacity. (Wikipedia)"</para>
    /// labels<para>"Actor"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Actor">http://www.ontotext.com/proton/protonext#Actor</seealso>
    let Actor = Prefixed_Name(pext, "Actor") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Address</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any sort of address, specifying how to locate something somewhere."</para>
    /// labels<para>"Address"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Address">http://www.ontotext.com/proton/protonext#Address</seealso>
    let Address = Prefixed_Name(pext, "Address") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#AdministrativeRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any administrative region. NIMA GNS designators - PCLIX"</para>
    /// labels<para>"Administrative Region"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#AdministrativeRegion">http://www.ontotext.com/proton/protonext#AdministrativeRegion</seealso>
    let AdministrativeRegion =
        Prefixed_Name(pext, "AdministrativeRegion") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#AgriculturalColony</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A tract of land set aside for agricultural settlement. NIMA GNS designator L.AGRC."</para>
    /// labels<para>"Agricultural Colony"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#AgriculturalColony">http://www.ontotext.com/proton/protonext#AgriculturalColony</seealso>
    let AgriculturalColony = Prefixed_Name(pext, "AgriculturalColony") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#AgriculturalFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An agricultural facility; a building and/or tract of land used for improving agriculture"</para>
    /// labels<para>"Agricultural Facility"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#AgriculturalFacility">http://www.ontotext.com/proton/protonext#AgriculturalFacility</seealso>
    let AgriculturalFacility =
        Prefixed_Name(pext, "AgriculturalFacility") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#Airbase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An area used to store supplies, provide barracks for air force personnel, hangars and runways for aircraft, and from which operations are initiated"</para>
    /// labels<para>"Airbase"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Airbase">http://www.ontotext.com/proton/protonext#Airbase</seealso>
    let Airbase = Prefixed_Name(pext, "Airbase") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Airline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A company providing air transport services."</para>
    /// labels<para>"Airline"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Airline">http://www.ontotext.com/proton/protonext#Airline</seealso>
    let Airline = Prefixed_Name(pext, "Airline") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#AirplaneEngine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Engines of airplanes"</para>
    /// labels<para>"Airplane Engine"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#AirplaneEngine">http://www.ontotext.com/proton/protonext#AirplaneEngine</seealso>
    let AirplaneEngine = Prefixed_Name(pext, "AirplaneEngine") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#AirplaneModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A concrete model of an airplane which determines the main features of any airplane of this model. For example, Boeing 737, Airbus A330, etc."</para>
    /// labels<para>"Airplane Model"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#AirplaneModel">http://www.ontotext.com/proton/protonext#AirplaneModel</seealso>
    let AirplaneModel = Prefixed_Name(pext, "AirplaneModel") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Airport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An airport, including heliports. NIMA GNS designators AIRP, AIRH."</para>
    /// labels<para>"Airport"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Airport">http://www.ontotext.com/proton/protonext#Airport</seealso>
    let Airport = Prefixed_Name(pext, "Airport") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Album</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An recording of a several songs. Usually from the same singer."</para>
    /// labels<para>"Album"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Album">http://www.ontotext.com/proton/protonext#Album</seealso>
    let Album = Prefixed_Name(pext, "Album") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#AlcoholicBeverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A type (specific receipe) for a beverage. For instance: Guiness Beer, Absolut Currant, etc."</para>
    /// labels<para>"Alcoholic Beverage"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#AlcoholicBeverage">http://www.ontotext.com/proton/protonext#AlcoholicBeverage</seealso>
    let AlcoholicBeverage = Prefixed_Name(pext, "AlcoholicBeverage") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Ambassador</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#JobTitle</para>
    ///   <para>"Any ambassador, a title of a position of representing a country abroad"</para>
    /// labels<para>"Ambassador"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Ambassador">http://www.ontotext.com/proton/protonext#Ambassador</seealso>
    let Ambassador = Prefixed_Name(pext, "Ambassador") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#AmericanFootballLeague</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any American football league"</para>
    /// labels<para>"American Football League"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#AmericanFootballLeague">http://www.ontotext.com/proton/protonext#AmericanFootballLeague</seealso>
    let AmericanFootballLeague =
        Prefixed_Name(pext, "AmericanFootballLeague") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#AmericanFootballPlayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Sportsman</para>
    ///   <para>"Any player of American football."</para>
    /// labels<para>"American Football Player"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#AmericanFootballPlayer">http://www.ontotext.com/proton/protonext#AmericanFootballPlayer</seealso>
    let AmericanFootballPlayer =
        Prefixed_Name(pext, "AmericanFootballPlayer") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#AmericanFootballTeam</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any American Football Team"</para>
    /// labels<para>"American Football Team"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#AmericanFootballTeam">http://www.ontotext.com/proton/protonext#AmericanFootballTeam</seealso>
    let AmericanFootballTeam =
        Prefixed_Name(pext, "AmericanFootballTeam") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#Amphibian</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Amphibian denotes animals such as frogs, salamanders, and caecilians, that are ectothermic (or cold-blooded) animals and metamorphose from a juvenile water-breathing form, either to an adult air-breathing form, or to a paedomorph that retains some juvenile characteristics. (Wikipedia)"</para>
    /// labels<para>"Amphibian"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Amphibian">http://www.ontotext.com/proton/protonext#Amphibian</seealso>
    let Amphibian = Prefixed_Name(pext, "Amphibian") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#AmusementPark</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Commercially operated enterprises that offer rides, games, and other forms of entertainment. NIMA GNS designator - no equivalents."</para>
    /// labels<para>"Amusement Park"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#AmusementPark">http://www.ontotext.com/proton/protonext#AmusementPark</seealso>
    let AmusementPark = Prefixed_Name(pext, "AmusementPark") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Animal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Animals are a major group of multicellular, eukaryotic organisms. Their body plan eventually becomes fixed as they develop. Most animals are motile. (Wikipedia)"</para>
    /// labels<para>"Animal"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Animal">http://www.ontotext.com/proton/protonext#Animal</seealso>
    let Animal = Prefixed_Name(pext, "Animal") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Announcement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A formal public statement; "the government made an announcement about the changes in the drug war" ; "a declaration of independence".) WordNet 1.7.1"</para>
    /// labels<para>"Announcement"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Announcement">http://www.ontotext.com/proton/protonext#Announcement</seealso>
    let Announcement = Prefixed_Name(pext, "Announcement") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Arachnid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Arachnid denotes a class of joint-legged invertebrate animals in the subphylum Chelicerata. All arachnids have eight legs, although in some species the front pair may convert to a sensory function. (Wikipedia)"</para>
    /// labels<para>"Arachnid"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Arachnid">http://www.ontotext.com/proton/protonext#Arachnid</seealso>
    let Arachnid = Prefixed_Name(pext, "Arachnid") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Arch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A natural or man-made structure in the form of an arch"</para>
    /// labels<para>"Arch"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Arch">http://www.ontotext.com/proton/protonext#Arch</seealso>
    let Arch = Prefixed_Name(pext, "Arch") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Archaea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Archaea (archeon) are a group of single-celled microorganisms without a cell nucleus or any other membrane-bound organelles (Wikipedia)"</para>
    /// labels<para>"Archaea"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Archaea">http://www.ontotext.com/proton/protonext#Archaea</seealso>
    let Archaea = Prefixed_Name(pext, "Archaea") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Archipelago</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Seas or areas in a sea that contain numerous islands; also, the island groups themselves. NIMA GNS designator - no equivalent."</para>
    /// labels<para>"Archipelago"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Archipelago">http://www.ontotext.com/proton/protonext#Archipelago</seealso>
    let Archipelago = Prefixed_Name(pext, "Archipelago") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Architect</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Profession</para>
    ///   <para>"Any architect, a profession of planning, design and oversight of the construction of buildings. (Wikipedia)"</para>
    /// labels<para>"Architect"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Architect">http://www.ontotext.com/proton/protonext#Architect</seealso>
    let Architect = Prefixed_Name(pext, "Architect") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Arena</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any arena"</para>
    /// labels<para>"Arena"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Arena">http://www.ontotext.com/proton/protonext#Arena</seealso>
    let Arena = Prefixed_Name(pext, "Arena") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Art</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Art is the product or process of deliberately arranging items (often with symbolic significance) in a way that influences and affects one or more of the senses, emotions, and intellect. Wikipedia."</para>
    /// labels<para>"Art"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Art">http://www.ontotext.com/proton/protonext#Art</seealso>
    let Art = Prefixed_Name(pext, "Art") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#ArtPerformance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific performance taking place at some moment, somewhere. Quite often starting at 19:00 in the theatre, stadium, etc."</para>
    /// labels<para>"Art Performance"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#ArtPerformance">http://www.ontotext.com/proton/protonext#ArtPerformance</seealso>
    let ArtPerformance = Prefixed_Name(pext, "ArtPerformance") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#ArtProfession</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A profession in the area of art."</para>
    /// labels<para>"Sportsman"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#ArtProfession">http://www.ontotext.com/proton/protonext#ArtProfession</seealso>
    let ArtProfession = Prefixed_Name(pext, "ArtProfession") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Artery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any artery as a part of the body."</para>
    /// labels<para>"Artery"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Artery">http://www.ontotext.com/proton/protonext#Artery</seealso>
    let Artery = Prefixed_Name(pext, "Artery") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Article</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A relatively short document published as a part of Resource Collection."</para>
    /// labels<para>"Article"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Article">http://www.ontotext.com/proton/protonext#Article</seealso>
    let Article = Prefixed_Name(pext, "Article") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#ArtificialSatellite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A satellite created by humans"</para>
    /// labels<para>"Artificial Satellite"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#ArtificialSatellite">http://www.ontotext.com/proton/protonext#ArtificialSatellite</seealso>
    let ArtificialSatellite = Prefixed_Name(pext, "ArtificialSatellite") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Artist</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#ArtProfession</para>
    ///   <para>"Any artist a profession engaging in a broad spectrum of activities related to creating art, practicing the arts and/or demonstrating an art. (Wikipedia)"</para>
    /// labels<para>"Artist"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Artist">http://www.ontotext.com/proton/protonext#Artist</seealso>
    let Artist = Prefixed_Name(pext, "Artist") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Asteroid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Asteroids are a class of small Solar System bodies in orbit around the Sun. Wikipedia"</para>
    /// labels<para>"Asteroid"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Asteroid">http://www.ontotext.com/proton/protonext#Asteroid</seealso>
    let Asteroid = Prefixed_Name(pext, "Asteroid") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Astronaut</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Profession</para>
    ///   <para>"Any astronaut, a profession allowing to command, pilot, or serve as a crew member of a spacecraft. (Wikipedia)"</para>
    /// labels<para>"Astronaut"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Astronaut">http://www.ontotext.com/proton/protonext#Astronaut</seealso>
    let Astronaut = Prefixed_Name(pext, "Astronaut") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#AstronomicalObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any object studied by astronomers, (usually quite large natural and inanimate) object that is located in the physical universe and is not on the surface of the Earth. Definition partly derived from OpenCyc 0.7"</para>
    /// labels<para>"Astronomical Object"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#AstronomicalObject">http://www.ontotext.com/proton/protonext#AstronomicalObject</seealso>
    let AstronomicalObject = Prefixed_Name(pext, "AstronomicalObject") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Athlete</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Sportsman</para>
    ///   <para>"Any athlete, a profession involving sport activities."</para>
    /// labels<para>"Athlete"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Athlete">http://www.ontotext.com/proton/protonext#Athlete</seealso>
    let Athlete = Prefixed_Name(pext, "Athlete") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Atoll</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any atoll"</para>
    /// labels<para>"Atoll"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Atoll">http://www.ontotext.com/proton/protonext#Atoll</seealso>
    let Atoll = Prefixed_Name(pext, "Atoll") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#AudioRecording</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An recording of a piece of music."</para>
    /// labels<para>"Audio Recording"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#AudioRecording">http://www.ontotext.com/proton/protonext#AudioRecording</seealso>
    let AudioRecording = Prefixed_Name(pext, "AudioRecording") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#AustralianFootballLeague</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Australian football league"</para>
    /// labels<para>"Australian Football League"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#AustralianFootballLeague">http://www.ontotext.com/proton/protonext#AustralianFootballLeague</seealso>
    let AustralianFootballLeague =
        Prefixed_Name(pext, "AustralianFootballLeague") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#AustralianRulesFootballPlayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Sportsman</para>
    ///   <para>"The profession of an australian rules football player"</para>
    /// labels<para>"Australian rules football player"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#AustralianRulesFootballPlayer">http://www.ontotext.com/proton/protonext#AustralianRulesFootballPlayer</seealso>
    let AustralianRulesFootballPlayer =
        Prefixed_Name(pext, "AustralianRulesFootballPlayer") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#AutoRacingLeague</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Auto Racing league"</para>
    /// labels<para>"Auto Racing League"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#AutoRacingLeague">http://www.ontotext.com/proton/protonext#AutoRacingLeague</seealso>
    let AutoRacingLeague = Prefixed_Name(pext, "AutoRacingLeague") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#AutomobileEngine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Engines of automobiles"</para>
    /// labels<para>"Automobile Engine"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#AutomobileEngine">http://www.ontotext.com/proton/protonext#AutomobileEngine</seealso>
    let AutomobileEngine = Prefixed_Name(pext, "AutomobileEngine") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Award</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any award. An award is something given to a person or a group of people to recognize excellence in a certain field; a certificate of excellence, for example trophies, titles, medals, badges, etc."</para>
    /// labels<para>"Award"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Award">http://www.ontotext.com/proton/protonext#Award</seealso>
    let Award = Prefixed_Name(pext, "Award") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Bacteria</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Bacteria is a single-celled, prokaryote microorganisms, typically a few micrometres in length (Wikipedia)"</para>
    /// labels<para>"Bacteria"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Bacteria">http://www.ontotext.com/proton/protonext#Bacteria</seealso>
    let Bacteria = Prefixed_Name(pext, "Bacteria") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#BadmintonPlayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Sportsman</para>
    ///   <para>"The profession of badminton player"</para>
    /// labels<para>"Badminton player"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#BadmintonPlayer">http://www.ontotext.com/proton/protonext#BadmintonPlayer</seealso>
    let BadmintonPlayer = Prefixed_Name(pext, "BadmintonPlayer") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Band</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any band, a group performing music or other activity together."</para>
    /// labels<para>"Band"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Band">http://www.ontotext.com/proton/protonext#Band</seealso>
    let Band = Prefixed_Name(pext, "Band") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Bank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A company providing financial services like credits, deposits, etc."</para>
    ///   <para>"A business establishment in which money is kept for saving or commercial purposes or is invested, supplied for loans, or exchanged."</para>
    /// labels<para>"Bank"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Bank">http://www.ontotext.com/proton/protonext#Bank</seealso>
    let Bank = Prefixed_Name(pext, "Bank") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Barracks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A building for lodging military personnel"</para>
    /// labels<para>"Barracks"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Barracks">http://www.ontotext.com/proton/protonext#Barracks</seealso>
    let Barracks = Prefixed_Name(pext, "Barracks") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#BaseballLeague</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Baseball league"</para>
    /// labels<para>"Baseball League"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#BaseballLeague">http://www.ontotext.com/proton/protonext#BaseballLeague</seealso>
    let BaseballLeague = Prefixed_Name(pext, "BaseballLeague") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#BaseballPlayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Sportsman</para>
    ///   <para>"The profession of baseball player"</para>
    /// labels<para>"Baseball player"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#BaseballPlayer">http://www.ontotext.com/proton/protonext#BaseballPlayer</seealso>
    let BaseballPlayer = Prefixed_Name(pext, "BaseballPlayer") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#BaseballTeam</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Baseball team"</para>
    /// labels<para>"Baseball Team"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#BaseballTeam">http://www.ontotext.com/proton/protonext#BaseballTeam</seealso>
    let BaseballTeam = Prefixed_Name(pext, "BaseballTeam") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#BasketballLeague</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Basketball league"</para>
    /// labels<para>"Basketball League"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#BasketballLeague">http://www.ontotext.com/proton/protonext#BasketballLeague</seealso>
    let BasketballLeague = Prefixed_Name(pext, "BasketballLeague") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#BasketballPlayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Sportsman</para>
    ///   <para>"The profession of basketball player"</para>
    /// labels<para>"Basketball player"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#BasketballPlayer">http://www.ontotext.com/proton/protonext#BasketballPlayer</seealso>
    let BasketballPlayer = Prefixed_Name(pext, "BasketballPlayer") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#BasketballTeam</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any basketball team"</para>
    /// labels<para>"Basketball Team"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#BasketballTeam">http://www.ontotext.com/proton/protonext#BasketballTeam</seealso>
    let BasketballTeam = Prefixed_Name(pext, "BasketballTeam") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Battlefield</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A site of a land battle of historical importance. NIMA GNS designator L.BTL."</para>
    /// labels<para>"Battlefield"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Battlefield">http://www.ontotext.com/proton/protonext#Battlefield</seealso>
    let Battlefield = Prefixed_Name(pext, "Battlefield") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Bay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Indentations of a coastline or shoreline enclosing a part of a body of water; bodies of water partly surrounded by land. We use this category for bahias; for coves; and for embayments. NIMA GNS designators BAY, BAYS."</para>
    /// labels<para>"Bay"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Bay">http://www.ontotext.com/proton/protonext#Bay</seealso>
    let Bay = Prefixed_Name(pext, "Bay") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Beach</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Sloping shores along a body of water that is washed by waves or tides and is usually covered by sand or gravel. ... We use this category for sandy areas; and for strands. NIMA GNS designator BCH, BCHS."</para>
    /// labels<para>"Beach"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Beach">http://www.ontotext.com/proton/protonext#Beach</seealso>
    let Beach = Prefixed_Name(pext, "Beach") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Beacon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A fixed artificial navigation mark"</para>
    /// labels<para>"Beacon"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Beacon">http://www.ontotext.com/proton/protonext#Beacon</seealso>
    let Beacon = Prefixed_Name(pext, "Beacon") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Beverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any liquid suitable for drinking (WordNet, 1.7). The instances of this class are types of drinks, specific receipts. For instance: Diet Coke, Bacardi Spice."</para>
    /// labels<para>"Beverage"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Beverage">http://www.ontotext.com/proton/protonext#Beverage</seealso>
    let Beverage = Prefixed_Name(pext, "Beverage") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Bight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An open body of water forming a slight recession in a coastline"</para>
    /// labels<para>"Bight"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Bight">http://www.ontotext.com/proton/protonext#Bight</seealso>
    let Bight = Prefixed_Name(pext, "Bight") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#BiogeographicRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Geographic regions characterized chiefly by the dominant forms of plant life and the prevailing climate. [Adapted from American Heritage Dict. of the English Language, 4th ed.] We use this category for biomes; for ecoregions; and for vegetation. Omitted ADL sub-classes: Barren lands, Grasslands, Habitats, Snow Regions, Wetlands. NIMA GNS designator - no equivalent. Some correspondence to class Hypsographic Features."</para>
    /// labels<para>"Biogeographic Region"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#BiogeographicRegion">http://www.ontotext.com/proton/protonext#BiogeographicRegion</seealso>
    let BiogeographicRegion = Prefixed_Name(pext, "BiogeographicRegion") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#BiologicalDatabase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A database containing information about biological entities."</para>
    /// labels<para>"Biological Database"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#BiologicalDatabase">http://www.ontotext.com/proton/protonext#BiologicalDatabase</seealso>
    let BiologicalDatabase = Prefixed_Name(pext, "BiologicalDatabase") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#BiologicalSubstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any substance or element that has biological nature or origine."</para>
    /// labels<para>"Biological Substance"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#BiologicalSubstance">http://www.ontotext.com/proton/protonext#BiologicalSubstance</seealso>
    let BiologicalSubstance = Prefixed_Name(pext, "BiologicalSubstance") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Bird</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Bird denotes feathered, winged, bipedal, endothermic (warm-blooded), egg-laying, vertebrate animals. (Wikipedia)"</para>
    /// labels<para>"Bird"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Bird">http://www.ontotext.com/proton/protonext#Bird</seealso>
    let Bird = Prefixed_Name(pext, "Bird") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Bishop</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#ClericTitle</para>
    ///   <para>"Any bishop, an official in the Roman-Catholic church."</para>
    /// labels<para>"Bishop"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Bishop">http://www.ontotext.com/proton/protonext#Bishop</seealso>
    let Bishop = Prefixed_Name(pext, "Bishop") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#BoardMeeting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A meeting whose main participants are members of a board."</para>
    /// labels<para>"Board Meeting"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#BoardMeeting">http://www.ontotext.com/proton/protonext#BoardMeeting</seealso>
    let BoardMeeting = Prefixed_Name(pext, "BoardMeeting") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#BoardMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#JobTitle</para>
    ///   <para>"Any board member, a title of the member of the board of any board"</para>
    /// labels<para>"Board Member"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#BoardMember">http://www.ontotext.com/proton/protonext#BoardMember</seealso>
    let BoardMember = Prefixed_Name(pext, "BoardMember") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#BodyPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any part of the body of any living entity"</para>
    /// labels<para>"Body Part"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#BodyPart">http://www.ontotext.com/proton/protonext#BodyPart</seealso>
    let BodyPart = Prefixed_Name(pext, "BodyPart") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Bog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"http://www.eionet.europa.eu/gemet/concept?ns=1&amp;cp=12161. NIMA GNS designator H.BOG."</para>
    /// labels<para>"Bog"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Bog">http://www.ontotext.com/proton/protonext#Bog</seealso>
    let Bog = Prefixed_Name(pext, "Bog") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Bone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any bone as a part of the body."</para>
    /// labels<para>"Bone"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Bone">http://www.ontotext.com/proton/protonext#Bone</seealso>
    let Bone = Prefixed_Name(pext, "Bone") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Book</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A relatively large published document. It may or may not have chapters. There could be series of books considered as volumes of a single one."</para>
    /// labels<para>"Book"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Book">http://www.ontotext.com/proton/protonext#Book</seealso>
    let Book = Prefixed_Name(pext, "Book") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Boxer</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Sportsman</para>
    ///   <para>"The profession of boxer"</para>
    /// labels<para>"Boxer"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Boxer">http://www.ontotext.com/proton/protonext#Boxer</seealso>
    let Boxer = Prefixed_Name(pext, "Boxer") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#BoxingLeague</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Boxing league"</para>
    /// labels<para>"Boxing League"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#BoxingLeague">http://www.ontotext.com/proton/protonext#BoxingLeague</seealso>
    let BoxingLeague = Prefixed_Name(pext, "BoxingLeague") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Brain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any brain as a part of the body."</para>
    /// labels<para>"Brain"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Brain">http://www.ontotext.com/proton/protonext#Brain</seealso>
    let Brain = Prefixed_Name(pext, "Brain") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Brand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The American Marketing Association defines a brand as a "Name, term, design, symbol, or any other feature that identifies one seller's good or service as distinct from those of other sellers." Wikipedia. Examples: Dodge and Milka"</para>
    /// labels<para>"Brand"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Brand">http://www.ontotext.com/proton/protonext#Brand</seealso>
    let Brand = Prefixed_Name(pext, "Brand") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Breakwater</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A structure erected to break the force of waves at the entrance to a harbor or port"</para>
    /// labels<para>"Breakwater"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Breakwater">http://www.ontotext.com/proton/protonext#Breakwater</seealso>
    let Breakwater = Prefixed_Name(pext, "Breakwater") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Bridge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Structures erected over a depression or obstacle to carry traffic. [USGS Circ 1048] We use this category for covered bridges; for drawbridges; for overpasses; for trestles; and for viaducts. NIMA GNS designator BDG, BDGQ."</para>
    /// labels<para>"Bridge"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Bridge">http://www.ontotext.com/proton/protonext#Bridge</seealso>
    let Bridge = Prefixed_Name(pext, "Bridge") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#BritishRoyalty</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#NobeltyTitle</para>
    ///   <para>"Any British Royalty, a title of a memebr of the British royal family."</para>
    /// labels<para>"British Royalty"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#BritishRoyalty">http://www.ontotext.com/proton/protonext#BritishRoyalty</seealso>
    let BritishRoyalty = Prefixed_Name(pext, "BritishRoyalty") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#BroadcastNetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A broadcast network is an organization, such as a corporation or other voluntary association, that provides live television or recorded content, such as movies, newscasts, sports, Public affairs programming, and other television programs for broadcast over a group of radio stations or television stations. Wikipedia"</para>
    /// labels<para>"Broadcast network"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#BroadcastNetwork">http://www.ontotext.com/proton/protonext#BroadcastNetwork</seealso>
    let BroadcastNetwork = Prefixed_Name(pext, "BroadcastNetwork") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Broadcaster</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A company that broadcasts audio or video content to a dispersed audience via any audio visual medium. Wikipedia"</para>
    /// labels<para>"Broadcaster"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Broadcaster">http://www.ontotext.com/proton/protonext#Broadcaster</seealso>
    let Broadcaster = Prefixed_Name(pext, "Broadcaster") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Building</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Permanent constructions that are roofed and usually walled. [USGS Circ 1048] We use this category for administrative facilities; for administrative facilities; for animal pounds; for animal shelters; for aquariums; for barns; for border posts; for cabins; for castles; for city halls; for civic centers; for civil buildings; for club houses; for coast guard stations; for commissaries; for community centers; for community houses; for conference facilities; for consulates; for convention centers; for customs houses; for customs posts; for depots; for embassy buildings; for exhibition buildings; for facilities; for facility centers; for fire stations; for firehouses; for forest stations; for government buildings; for guard stations; for halls; for headquarters; for hostels; for hotels; for houses; for inns; for inspection stations; for legation buildings; for lodges; for missions; for motels; for neighborhood centers; for offices; for park headquarters; for patrol posts; for pavilions; for planetariums; for plazas; for police posts; for public buildings; for ranger stations; for restaurants; for shelters; for shops; for stations; for structures; for student unions; for studios; for substations; for taverns; for town halls; for trading posts; for treatment plants; for United States Government establishments; for visitor centers; for walls; and for warehouses NIMA GNS designator BLDG."</para>
    /// labels<para>"Building"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Building">http://www.ontotext.com/proton/protonext#Building</seealso>
    let Building = Prefixed_Name(pext, "Building") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#BullFighter</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Sportsman</para>
    ///   <para>"Professional toreros (also called matadors) who execute various formal moves which can be interpreted and innovated according to the bullfighter's style or school. Wikipedia"</para>
    /// labels<para>"Bull Fighter"</para><para>"BullFighter"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#BullFighter">http://www.ontotext.com/proton/protonext#BullFighter</seealso>
    let BullFighter = Prefixed_Name(pext, "BullFighter") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#BushLand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A small clump of conspicuous bushes in an otherwise bare area"</para>
    /// labels<para>"Bush"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#BushLand">http://www.ontotext.com/proton/protonext#BushLand</seealso>
    let BushLand = Prefixed_Name(pext, "BushLand") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#BusinessAbstraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An abstraction related to business."</para>
    /// labels<para>"Business Abstraction"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#BusinessAbstraction">http://www.ontotext.com/proton/protonext#BusinessAbstraction</seealso>
    let BusinessAbstraction = Prefixed_Name(pext, "BusinessAbstraction") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#CEO</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#JobTitle</para>
    ///   <para>"Any CEO, a title of a chief executive officer of an organization."</para>
    /// labels<para>"CEO"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#CEO">http://www.ontotext.com/proton/protonext#CEO</seealso>
    let CEO = Prefixed_Name(pext, "CEO") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#CalendarMonth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific month of the year, such as: Jan., Feb., etc."</para>
    /// labels<para>"Calendar Month"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#CalendarMonth">http://www.ontotext.com/proton/protonext#CalendarMonth</seealso>
    let CalendarMonth = Prefixed_Name(pext, "CalendarMonth") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#CalendarYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific year, such as 2000, taken as a time interval"</para>
    /// labels<para>"Calendar Year"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#CalendarYear">http://www.ontotext.com/proton/protonext#CalendarYear</seealso>
    let CalendarYear = Prefixed_Name(pext, "CalendarYear") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Camp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Designated areas on which primitive structure(s) are erected for temporary shelter or where recreational vehicles are temporarily parked. [USGS Circ 1048] We use this category for campgrounds; for camping sites; for logging camps; for oil camps; for refugee camps; for RV parks; and for trailer parks (recreational). NIMA GNS designators CMP, CMPL, CMPLA, CMPO, CMPQ, CMPRF."</para>
    /// labels<para>"Camp"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Camp">http://www.ontotext.com/proton/protonext#Camp</seealso>
    let Camp = Prefixed_Name(pext, "Camp") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#CanadianFootballLeague</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Canadian Football league"</para>
    /// labels<para>"Canadian Football League"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#CanadianFootballLeague">http://www.ontotext.com/proton/protonext#CanadianFootballLeague</seealso>
    let CanadianFootballLeague =
        Prefixed_Name(pext, "CanadianFootballLeague") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#CanadianFootballPlayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Profession</para>
    ///   <para>"Any player of Canadian football."</para>
    /// labels<para>"Canadian Football Player"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#CanadianFootballPlayer">http://www.ontotext.com/proton/protonext#CanadianFootballPlayer</seealso>
    let CanadianFootballPlayer =
        Prefixed_Name(pext, "CanadianFootballPlayer") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#CanadianFootballTeam</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Canadian Football Team"</para>
    /// labels<para>"Canadian Football Team"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#CanadianFootballTeam">http://www.ontotext.com/proton/protonext#CanadianFootballTeam</seealso>
    let CanadianFootballTeam =
        Prefixed_Name(pext, "CanadianFootballTeam") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#Canal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Artificial waterways with no flow or a controlled flow used for navigation (canal), or for draining or irrigating land (ditch). We use this category for canal bends; for canalized streams; for ditch mouths; for ditches; for drainage canals; for drainage ditches; for drains (channels); for flumes (manmade); for irrigation canals; for irrigation ditches; for irrigation systems; for laterals; for navigation canals; and for underground irrigation canals. NIMA GNS designators CNL,CNLA, CNLB, CNLD, CNLI, CNLN, CNLQ, CNLSB, CNLX."</para>
    /// labels<para>"Canal"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Canal">http://www.ontotext.com/proton/protonext#Canal</seealso>
    let Canal = Prefixed_Name(pext, "Canal") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Canyon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Relatively narrow, deep depressions with steep sides, the bottom of which generally has a continuous slope ... We use this category for barrancas; for chasms; for flumes (natural); for gorges; for gulches; for quebradas; and for ravines. NIMA GNS designator CNSU, CNYN, CNYU, GRGE, RAVU, RVN."</para>
    /// labels<para>"Canyon"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Canyon">http://www.ontotext.com/proton/protonext#Canyon</seealso>
    let Canyon = Prefixed_Name(pext, "Canyon") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Cape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Projection of land extending into a body of water that prominently marks a change in or interrupts the coastal trend of that water body. We use this category for headlands; for peninsulas; for points (physiographic); and for promontories. NIMA GNS designator CAPE, HDLD, PROM."</para>
    /// labels<para>"Cape"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Cape">http://www.ontotext.com/proton/protonext#Cape</seealso>
    let Cape = Prefixed_Name(pext, "Cape") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Capital</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Towns or cities that are the official seats of government in a political entity, such as a state or nation. [American Heritage Dic. of the English Language, 4th ed.] We use this category for county seats; for national capitals; and for state capitals. NIMA GNS designators PPLC, PPLA"</para>
    /// labels<para>"Capital"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Capital">http://www.ontotext.com/proton/protonext#Capital</seealso>
    let Capital = Prefixed_Name(pext, "Capital") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Car</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any automoabile car."</para>
    /// labels<para>"Car"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Car">http://www.ontotext.com/proton/protonext#Car</seealso>
    let Car = Prefixed_Name(pext, "Car") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#CarModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A concrete model of a car which determines the main features of any car of this model. For example, Ford-T or BMW Z3."</para>
    /// labels<para>"Car Model"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#CarModel">http://www.ontotext.com/proton/protonext#CarModel</seealso>
    let CarModel = Prefixed_Name(pext, "CarModel") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Cardinal</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#ClericTitle</para>
    ///   <para>"Any Cardinal, a high official in the Roman-Catholic church."</para>
    /// labels<para>"Cardinal"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Cardinal">http://www.ontotext.com/proton/protonext#Cardinal</seealso>
    let Cardinal = Prefixed_Name(pext, "Cardinal") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Cave</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Natural underground passageways or chambers, or hollowed out cavities in the side of a cliff. ... We use this category for cave entrances; for caverns; for grottoes; for natural tunnels; and for underground lakes. NIMA GNS designator CAVE."</para>
    /// labels<para>"Cave"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Cave">http://www.ontotext.com/proton/protonext#Cave</seealso>
    let Cave = Prefixed_Name(pext, "Cave") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Celebrity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The situation of holding a position in a society as celebrity."</para>
    /// labels<para>"Celebrity"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Celebrity">http://www.ontotext.com/proton/protonext#Celebrity</seealso>
    let Celebrity = Prefixed_Name(pext, "Celebrity") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#CelebrityTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The social function of celebrity, a status of notoriety in the society."</para>
    /// labels<para>"Celebrity"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#CelebrityTitle">http://www.ontotext.com/proton/protonext#CelebrityTitle</seealso>
    let CelebrityTitle = Prefixed_Name(pext, "CelebrityTitle") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Chancellor</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#JobTitle</para>
    ///   <para>"Any Chancellor, a title of various official positions in the governments of many nations. (Wikipedia)"</para>
    /// labels<para>"Chancellor"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Chancellor">http://www.ontotext.com/proton/protonext#Chancellor</seealso>
    let Chancellor = Prefixed_Name(pext, "Chancellor") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Channel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) (a) Relatively narrow seas or stretches of water between two close landmasses and connecting two larger bodies of water; (b) Deeper parts of a moving body of water (as bays, estuaries, or straits) through which the main current flows or which affords the best passage through an area otherwise too shallow to navigate. ... We use this category for chutes (hydrographic); for cutoffs (hydrographic); for inlets; for lake channels; for marine channels; for narrows (hydrographic); for navigation channels; for reaches (hydrographic); for sounds (bodies of water); and for straits. NIMA GNS designators CHN, CHNL, CHNM, CHNN, STRT."</para>
    /// labels<para>"Channel"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Channel">http://www.ontotext.com/proton/protonext#Channel</seealso>
    let Channel = Prefixed_Name(pext, "Channel") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Charity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Charity, an organization involved in the practice of benevolent giving and caring. (Wikipedia)"</para>
    /// labels<para>"Charity"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Charity">http://www.ontotext.com/proton/protonext#Charity</seealso>
    let Charity = Prefixed_Name(pext, "Charity") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#ChemicalCompound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific chemical compound, such as H2O or Zarin."</para>
    /// labels<para>"Chemical Compound"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#ChemicalCompound">http://www.ontotext.com/proton/protonext#ChemicalCompound</seealso>
    let ChemicalCompound = Prefixed_Name(pext, "ChemicalCompound") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#ChemicalElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A chemical element is a pure chemical substance consisting of one type of atom distinguished by its atomic number, which is the number of protons in its nucleus. Wikipedia"</para>
    /// labels<para>"Chemical element"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#ChemicalElement">http://www.ontotext.com/proton/protonext#ChemicalElement</seealso>
    let ChemicalElement = Prefixed_Name(pext, "ChemicalElement") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#ChemicalSubstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any substance or element that has chemical nature."</para>
    /// labels<para>"Chemical substance"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#ChemicalSubstance">http://www.ontotext.com/proton/protonext#ChemicalSubstance</seealso>
    let ChemicalSubstance = Prefixed_Name(pext, "ChemicalSubstance") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#ChessPlayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Sportsman</para>
    ///   <para>"The profession of a chess player"</para>
    /// labels<para>"Chess player"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#ChessPlayer">http://www.ontotext.com/proton/protonext#ChessPlayer</seealso>
    let ChessPlayer = Prefixed_Name(pext, "ChessPlayer") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#ChristianPatriarch</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#ClericTitle</para>
    ///   <para>"Any Christian Patriarch."</para>
    /// labels<para>"Christian Patriarch"</para><para>"Patriarch"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#ChristianPatriarch">http://www.ontotext.com/proton/protonext#ChristianPatriarch</seealso>
    let ChristianPatriarch = Prefixed_Name(pext, "ChristianPatriarch") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#City</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) For smaller, less formally established communities, use 'populated places'. For independent cities, use 'countries, 2nd order divisions. Incorporated populated places. [Adapted from USGS Circ 1048] We use this category for municipalities; for towns; and for urban areas. NIMA GNS designator PPL."</para>
    /// labels<para>"City"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#City">http://www.ontotext.com/proton/protonext#City</seealso>
    let City = Prefixed_Name(pext, "City") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Cleric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The situation of holding a position in society as cleric."</para>
    /// labels<para>"Cleric"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Cleric">http://www.ontotext.com/proton/protonext#Cleric</seealso>
    let Cleric = Prefixed_Name(pext, "Cleric") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#ClericTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The social function of a cleric, involving the church."</para>
    /// labels<para>"Cleric"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#ClericTitle">http://www.ontotext.com/proton/protonext#ClericTitle</seealso>
    let ClericTitle = Prefixed_Name(pext, "ClericTitle") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Coast</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT: Coastal Zones) Strips of land (of indefinite width) that extend from the low-tide line inland to the first major change in landform features. [Adapted from Glossary of Geology, 4th ed.] We use this category for coastal plains; for coasts; for intertidal zones; for offshore areas; for shorelines; and for shores. NIMA GNS designators CST, SHOR."</para>
    /// labels<para>"Coast"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Coast">http://www.ontotext.com/proton/protonext#Coast</seealso>
    let Coast = Prefixed_Name(pext, "Coast") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#CoconutGrove</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A planting of coconut trees"</para>
    /// labels<para>"Coconut grove"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#CoconutGrove">http://www.ontotext.com/proton/protonext#CoconutGrove</seealso>
    let CoconutGrove = Prefixed_Name(pext, "CoconutGrove") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#College</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"College"</para>
    ///   <para>"An education organization between the school and the university. In some cases it is a part of university."</para>
    /// labels<para>"College"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#College">http://www.ontotext.com/proton/protonext#College</seealso>
    let College = Prefixed_Name(pext, "College") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Colour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any colour, a visual perceptual property, e.g. red, blue, yellow, etc. (Wikipedia)"</para>
    /// labels<para>"Colour"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Colour">http://www.ontotext.com/proton/protonext#Colour</seealso>
    let Colour = Prefixed_Name(pext, "Colour") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Comedian</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#ArtProfession</para>
    ///   <para>"The profession of a comedian"</para>
    /// labels<para>"Comedian"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Comedian">http://www.ontotext.com/proton/protonext#Comedian</seealso>
    let Comedian = Prefixed_Name(pext, "Comedian") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#ComicsCharacter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A character from a comics."</para>
    /// labels<para>"Comics character"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#ComicsCharacter">http://www.ontotext.com/proton/protonext#ComicsCharacter</seealso>
    let ComicsCharacter = Prefixed_Name(pext, "ComicsCharacter") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#ComicsCreator</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#ArtProfession</para>
    ///   <para>"The profession of comics creator "</para>
    /// labels<para>"Comics creator "</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#ComicsCreator">http://www.ontotext.com/proton/protonext#ComicsCreator</seealso>
    let ComicsCreator = Prefixed_Name(pext, "ComicsCreator") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Commander</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#JobTitle</para>
    ///   <para>"Any commander, title of being commander or having a leading role in a military unit or other organization."</para>
    /// labels<para>"Commander"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Commander">http://www.ontotext.com/proton/protonext#Commander</seealso>
    let Commander = Prefixed_Name(pext, "Commander") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#CommercialOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Organization that buys or sells goods or services for a profit. It may also be a Business or it may merely be a sub-organization of a Business entity."</para>
    /// labels<para>"Commercial Organization"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#CommercialOrganization">http://www.ontotext.com/proton/protonext#CommercialOrganization</seealso>
    let CommercialOrganization =
        Prefixed_Name(pext, "CommercialOrganization") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#Company</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A private, legal, corporate entity with the legal rights to own property, manage itself, and sue or be sued. It is established by a charter or registration granted by the government."</para>
    /// labels<para>"Company"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Company">http://www.ontotext.com/proton/protonext#Company</seealso>
    let Company = Prefixed_Name(pext, "Company") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Concert</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An art performance consisting of playing music."</para>
    /// labels<para>"Concert"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Concert">http://www.ontotext.com/proton/protonext#Concert</seealso>
    let Concert = Prefixed_Name(pext, "Concert") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Confluence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"in geography, describes the meeting of two or more bodies of water. The opposite of a watershed. NIMA GNS designator H.CNFL."</para>
    /// labels<para>"Confluence"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Confluence">http://www.ontotext.com/proton/protonext#Confluence</seealso>
    let Confluence = Prefixed_Name(pext, "Confluence") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Congressman</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#JobTitle</para>
    ///   <para>"Any Congressman, a title of a position in congress."</para>
    /// labels<para>"Congressman"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Congressman">http://www.ontotext.com/proton/protonext#Congressman</seealso>
    let Congressman = Prefixed_Name(pext, "Congressman") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Continent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Earth's major land masses, including both dry land and continental shelves. NIMA GNS designator - no equivalent."</para>
    /// labels<para>"Continent"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Continent">http://www.ontotext.com/proton/protonext#Continent</seealso>
    let Continent = Prefixed_Name(pext, "Continent") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#ContinentalShelf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A zone adjacent to a continent (or around an island) that extends from the low water line to a depth at which there is usually a marked increase of slope towards oceanic depths"</para>
    /// labels<para>"Shelf"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#ContinentalShelf">http://www.ontotext.com/proton/protonext#ContinentalShelf</seealso>
    let ContinentalShelf = Prefixed_Name(pext, "ContinentalShelf") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Contract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any sort of contract or treaty, as well, as other documents signed or otherwise accepted by more than one agent."</para>
    /// labels<para>"Contract"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Contract">http://www.ontotext.com/proton/protonext#Contract</seealso>
    let Contract = Prefixed_Name(pext, "Contract") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FTT) Territory occupied by a large group of people organized under a single, usually independent government, and recognized internationally as a country. [Adapted from American Heritage Dic. of the English Language, 4th ed.] We use this category for nations; and for republics. NIMA GNS designators PCL, PCLD, PCLF, PCLI, PCLS. FIPS 10-4 is applicable, difining: Basic geopolitical entities assigned country codes include the following categories: (a) independent states; (b) dependent areas; (c) areas of quasi-independence, non-contiguous territories, possessions without populations, areas with special sovereignty associations, areas without sovereignty; (d) political regimes not recognized by the United States; and (e) outlying areas of the United States. The list of basic entities provides complete coverage of the land areas of the world without overlap or duplication."</para>
    /// labels<para>"Country"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Country">http://www.ontotext.com/proton/protonext#Country</seealso>
    let Country = Prefixed_Name(pext, "Country") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#CountryCapital</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A capital of a Country. NIMA GNS designator PPLC."</para>
    /// labels<para>"Country Capital"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#CountryCapital">http://www.ontotext.com/proton/protonext#CountryCapital</seealso>
    let CountryCapital = Prefixed_Name(pext, "CountryCapital") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#County</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT: Countries, 2nd order divisions) Second-order divisions of a nation such as parishes, boroughs, counties, municipios, or judicial divisions, and independent cities such as those in Maryland, Missouri, Nevada, and Virginia. [Adapted from USGS Circ 1048] We use this category for boroughs; for counties; for judicial divisions; for municipios; for parishes; and for second-order administrative divisions. NIMA GNS designator ADM2."</para>
    /// labels<para>"County"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#County">http://www.ontotext.com/proton/protonext#County</seealso>
    let County = Prefixed_Name(pext, "County") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Cove</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"a small type of bay or coastal inlet. http://www.eionet.europa.eu/gemet/concept/10142 NIMA GNS designator H.COVE."</para>
    /// labels<para>"Cove"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Cove">http://www.ontotext.com/proton/protonext#Cove</seealso>
    let Cove = Prefixed_Name(pext, "Cove") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Crater</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Circular-shaped depressions at the summit of a volcanic core or on the surface of the land caused by the impact of a meteorite; man-made depressions caused by an explosion. ... We use this category for calderas. NIMA GNS designator CRTR, CLDA."</para>
    /// labels<para>"Crater"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Crater">http://www.ontotext.com/proton/protonext#Crater</seealso>
    let Crater = Prefixed_Name(pext, "Crater") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Creek</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT: Guts) Relatively small coastal waterways connecting larger bodies of water or other waterways. NIMA GNS designator CRKT, INLT."</para>
    /// labels<para>"Creek"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Creek">http://www.ontotext.com/proton/protonext#Creek</seealso>
    let Creek = Prefixed_Name(pext, "Creek") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#CricketLeague</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Cricket league"</para>
    /// labels<para>"Cricket League"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#CricketLeague">http://www.ontotext.com/proton/protonext#CricketLeague</seealso>
    let CricketLeague = Prefixed_Name(pext, "CricketLeague") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Cricketer</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Profession</para>
    ///   <para>"The profession of cricketer"</para>
    /// labels<para>"Cricketer "</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Cricketer">http://www.ontotext.com/proton/protonext#Cricketer</seealso>
    let Cricketer = Prefixed_Name(pext, "Cricketer") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Crustacean</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Crustaceans denotes a group of arthropods animals, which includes crabs, lobsters, crayfish, shrimp, krill and barnacles. (Wikipedia)"</para>
    /// labels<para>"Crustacean"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Crustacean">http://www.ontotext.com/proton/protonext#Crustacean</seealso>
    let Crustacean = Prefixed_Name(pext, "Crustacean") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#CultivatedArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An area under cultivation"</para>
    /// labels<para>"Cultivated area"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#CultivatedArea">http://www.ontotext.com/proton/protonext#CultivatedArea</seealso>
    let CultivatedArea = Prefixed_Name(pext, "CultivatedArea") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#CurlingLeague</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Curling league"</para>
    /// labels<para>"Curling League"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#CurlingLeague">http://www.ontotext.com/proton/protonext#CurlingLeague</seealso>
    let CurlingLeague = Prefixed_Name(pext, "CurlingLeague") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Currency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Specific currency, usually national"</para>
    /// labels<para>"Currency"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Currency">http://www.ontotext.com/proton/protonext#Currency</seealso>
    let Currency = Prefixed_Name(pext, "Currency") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#DataSchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A particular notation for representation, standardization, and/or structuring of infomation. It can range from db schema, through ontology, to any sort of taxonomies, nomenclatures and subject hierarchies. Examples are Dublin Core, KIMO, SIC, XML, RDFS"</para>
    /// labels<para>"Data Schema"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#DataSchema">http://www.ontotext.com/proton/protonext#DataSchema</seealso>
    let DataSchema = Prefixed_Name(pext, "DataSchema") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Database</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A dataset loaded in a system supporting search, update and other operations over the information in the dataset."</para>
    /// labels<para>"Database"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Database">http://www.ontotext.com/proton/protonext#Database</seealso>
    let Database = Prefixed_Name(pext, "Database") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A dataset is information encoded in a defined structure (for example, lists, tables, and databases), intended to be useful for direct machine processing (DCMI Type.) Somehow structured and interrelated body of information, data, or knowledge. This includes databases, knowledge bases, catalogues, registries, specific lists, etc. All tangible aspects (like media or host) are irrelevant for this class - it only considers the abstract information. What can be considered as a single document is outside the scope of this class, although it can be comprehensive in terms of size and structure."</para>
    /// labels<para>"Dataset"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Dataset">http://www.ontotext.com/proton/protonext#Dataset</seealso>
    let Dataset = Prefixed_Name(pext, "Dataset") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific date, as 12th of April, 1956, as the time period (the 24 hours of the day)"</para>
    /// labels<para>"Date"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Date">http://www.ontotext.com/proton/protonext#Date</seealso>
    let Date = Prefixed_Name(pext, "Date") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#DayOfMonth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific day of a given month. The days are numbered from 1 to 28, 29, 30, or 31 depending on the month and the year."</para>
    /// labels<para>"Day of Month"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#DayOfMonth">http://www.ontotext.com/proton/protonext#DayOfMonth</seealso>
    let DayOfMonth = Prefixed_Name(pext, "DayOfMonth") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#DayOfWeek</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific day of the week. The week has seven days: Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, and Sunday."</para>
    /// labels<para>"Day of Week"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#DayOfWeek">http://www.ontotext.com/proton/protonext#DayOfWeek</seealso>
    let DayOfWeek = Prefixed_Name(pext, "DayOfWeek") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#DayTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Specific time (point) during the day, when the day is not specified. Like in "the supermarket is closing 20:30 p.m.""</para>
    /// labels<para>"Daytime"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#DayTime">http://www.ontotext.com/proton/protonext#DayTime</seealso>
    let DayTime = Prefixed_Name(pext, "DayTime") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Death</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The event to die."</para>
    /// labels<para>"Death"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Death">http://www.ontotext.com/proton/protonext#Death</seealso>
    let Death = Prefixed_Name(pext, "Death") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Delta</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Flat plains formed by alluvial deposits at the mouth of a stream. NIMA GNS designator DLTA."</para>
    /// labels<para>"Delta of a River"</para><para>"Delta"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Delta">http://www.ontotext.com/proton/protonext#Delta</seealso>
    let Delta = Prefixed_Name(pext, "Delta") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Deputy</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#JobTitle</para>
    ///   <para>"The occupation of deputy"</para>
    /// labels<para>"Deputy"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Deputy">http://www.ontotext.com/proton/protonext#Deputy</seealso>
    let Deputy = Prefixed_Name(pext, "Deputy") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Desert</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Regions rendered barren or partially barren by environmental extremes, especially by low rainfall. [USGS Circ 1048] We use this category for arid regions; for bajadas; for rock deserts; for sandy areas; for sandy deserts; and for stony deserts. NIMA GNS designators DSRT, ERG, HMDA, REG."</para>
    /// labels<para>"Desert"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Desert">http://www.ontotext.com/proton/protonext#Desert</seealso>
    let Desert = Prefixed_Name(pext, "Desert") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Device</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Device">http://www.ontotext.com/proton/protonext#Device</seealso>
    let Device = Prefixed_Name(pext, "Device") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Disease</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific sort of desease, such as AIDS, SARS, Parcinson, etc. The instances of those class can often by considered as terms instead of entities, but in all cases, those are the general phenomena, not the particular situations when somebody is suffering the disease."</para>
    /// labels<para>"Disease"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Disease">http://www.ontotext.com/proton/protonext#Disease</seealso>
    let Disease = Prefixed_Name(pext, "Disease") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Ditch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A ditch is usually defined as a small to moderate depression created to channel water.(Wikipedia). http://www.eionet.europa.eu/gemet/concept/2276. NIMA GNS designators H.DTCH, H.DTCHD, H.DTCHI, H.DTCHM."</para>
    /// labels<para>"Ditch"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Ditch">http://www.ontotext.com/proton/protonext#Ditch</seealso>
    let Ditch = Prefixed_Name(pext, "Ditch") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Division</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Branch, division, department, laboratory, etc. within an organisation. Usually, not a legal agent and not independent."</para>
    /// labels<para>"Division"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Division">http://www.ontotext.com/proton/protonext#Division</seealso>
    let Division = Prefixed_Name(pext, "Division") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#DrainageBasin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An area drained by a stream. NIMA GNS designator L.BSND."</para>
    /// labels<para>"Drainage Basin"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#DrainageBasin">http://www.ontotext.com/proton/protonext#DrainageBasin</seealso>
    let DrainageBasin = Prefixed_Name(pext, "DrainageBasin") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Drug</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A chemical substance used to improve the health condition of a person, animal, etc. For example, Aspirin, Viagra, etc."</para>
    /// labels<para>"Drug"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Drug">http://www.ontotext.com/proton/protonext#Drug</seealso>
    let Drug = Prefixed_Name(pext, "Drug") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#EMail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An identifier that determines a electronic mail box."</para>
    /// labels<para>"E-mail"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#EMail">http://www.ontotext.com/proton/protonext#EMail</seealso>
    let EMail = Prefixed_Name(pext, "EMail") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#EducationalOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An organization devoted to teaching activities."</para>
    /// labels<para>"Educational Organization"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#EducationalOrganization">http://www.ontotext.com/proton/protonext#EducationalOrganization</seealso>
    let EducationalOrganization =
        Prefixed_Name(pext, "EducationalOrganization") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#Election</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Generic concept of Election which is normally held at regular periods of time, president elections of the US, municipal elections, etc.."</para>
    /// labels<para>"Election"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Election">http://www.ontotext.com/proton/protonext#Election</seealso>
    let Election = Prefixed_Name(pext, "Election") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#ElectionOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Election happening at a particular date."</para>
    /// labels<para>"Election"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#ElectionOccurrence">http://www.ontotext.com/proton/protonext#ElectionOccurrence</seealso>
    let ElectionOccurrence = Prefixed_Name(pext, "ElectionOccurrence") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#ElectronicMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A webpage of a map"</para>
    /// labels<para>"Map"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#ElectronicMap">http://www.ontotext.com/proton/protonext#ElectronicMap</seealso>
    let ElectronicMap = Prefixed_Name(pext, "ElectronicMap") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#EmbryoBodyPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Embryology is a science that studies the development of the embryo. This class denotes different composing substances/elements of the embryo and related body parts, and hence is referred to as a body part. It is inspired form DBPedia Embryology/AnatomicalStructure, which has instances as Blastocyst, Amniotic cavity, Vitelline membrane, etc."</para>
    /// labels<para>"Embryo Body Part"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#EmbryoBodyPart">http://www.ontotext.com/proton/protonext#EmbryoBodyPart</seealso>
    let EmbryoBodyPart = Prefixed_Name(pext, "EmbryoBodyPart") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#EntertainmentCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Entertainment Company, a company involved in the entertainment business, e.g. Warner Brothers, MTV, Lido, etc."</para>
    /// labels<para>"Entertainment Company"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#EntertainmentCompany">http://www.ontotext.com/proton/protonext#EntertainmentCompany</seealso>
    let EntertainmentCompany =
        Prefixed_Name(pext, "EntertainmentCompany") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#Estuary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A partly enclosed coastal body of water with one or more rivers or streams flowing into it, and with a free connection to the open sea. NIMA GNS designator H.ESTY."</para>
    /// labels<para>"Estuary"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Estuary">http://www.ontotext.com/proton/protonext#Estuary</seealso>
    let Estuary = Prefixed_Name(pext, "Estuary") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#EthnicGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any ethnic group. A group of people whose members identify with each other, through a common heritage, often consisting of a common language, a common culture (often including a shared religion) and an ideology that stresses common ancestry or endogamy. (Wikipedia)."</para>
    /// labels<para>"Ethnic Group"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#EthnicGroup">http://www.ontotext.com/proton/protonext#EthnicGroup</seealso>
    let EthnicGroup = Prefixed_Name(pext, "EthnicGroup") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#FInlet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An inlet which has been filled in, or blocked by deposits"</para>
    /// labels<para>"Former Inlet"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#FInlet">http://www.ontotext.com/proton/protonext#FInlet</seealso>
    let FInlet = Prefixed_Name(pext, "FInlet") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Facility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT: Manmade Features, no def) Any regions and locations determined artificially, as a result of human activity. Many of the ADL sub-classes are omitted. NIMA GNS - no direct equivalent, although many sub-types are defined as classes (S, R) and designators."</para>
    /// labels<para>"Facility"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Facility">http://www.ontotext.com/proton/protonext#Facility</seealso>
    let Facility = Prefixed_Name(pext, "Facility") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#FashionModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Profession</para>
    ///   <para>"Any model, a profession involving posing to draw attention to a particualr object or cause."</para>
    /// labels<para>"Model"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#FashionModel">http://www.ontotext.com/proton/protonext#FashionModel</seealso>
    let FashionModel = Prefixed_Name(pext, "FashionModel") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#FaxNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A phone number connected to a fax machine."</para>
    /// labels<para>"Fax Number"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#FaxNumber">http://www.ontotext.com/proton/protonext#FaxNumber</seealso>
    let FaxNumber = Prefixed_Name(pext, "FaxNumber") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Festival</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any widely recognized festival or holiday, such as, Christmas or St. Valentine's Day."</para>
    /// labels<para>"Festival"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Festival">http://www.ontotext.com/proton/protonext#Festival</seealso>
    let Festival = Prefixed_Name(pext, "Festival") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#FestivalOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An occurrence of a Festival or holiday, Sofia Film Festival 2011, Christmas of 2010 or St. Valentine's Day of 2011."</para>
    /// labels<para>"Festival Held at a Particular Time"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#FestivalOccurrence">http://www.ontotext.com/proton/protonext#FestivalOccurrence</seealso>
    let FestivalOccurrence = Prefixed_Name(pext, "FestivalOccurrence") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#FictionalCharacter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The characters in fictional artwork like movies, books, etc"</para>
    /// labels<para>"Fictional Character"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#FictionalCharacter">http://www.ontotext.com/proton/protonext#FictionalCharacter</seealso>
    let FictionalCharacter = Prefixed_Name(pext, "FictionalCharacter") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#FieldHockeyLeague</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Field Hockey league"</para>
    /// labels<para>"Field Hockey League"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#FieldHockeyLeague">http://www.ontotext.com/proton/protonext#FieldHockeyLeague</seealso>
    let FieldHockeyLeague = Prefixed_Name(pext, "FieldHockeyLeague") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#FigureSkater</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Sportsman</para>
    ///   <para>"The profession of figure skater"</para>
    /// labels<para>"Figure skater"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#FigureSkater">http://www.ontotext.com/proton/protonext#FigureSkater</seealso>
    let FigureSkater = Prefixed_Name(pext, "FigureSkater") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#FilmFestival</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any festival involving showing a film."</para>
    /// labels<para>"Film Festival"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#FilmFestival">http://www.ontotext.com/proton/protonext#FilmFestival</seealso>
    let FilmFestival = Prefixed_Name(pext, "FilmFestival") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Fish</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A fish is any gill-bearing aquatic vertebrate (or craniate) animal that lacks limbs with digits. (Wikipedia)"</para>
    /// labels<para>"Fish"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Fish">http://www.ontotext.com/proton/protonext#Fish</seealso>
    let Fish = Prefixed_Name(pext, "Fish") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#FishingArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A bank or area where fishermen go to catch fish. NIMA GNS designator H.FISH."</para>
    /// labels<para>"Fishing Area"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#FishingArea">http://www.ontotext.com/proton/protonext#FishingArea</seealso>
    let FishingArea = Prefixed_Name(pext, "FishingArea") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Fjord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Long narrow glacially-eroded inlets of the sea, U-shaped and steep-walled, generally several hundred meters deep, between high rocky cliffs or slopes along a mountainous coast. ... We use this category for fiords; and for lochs. NIMA GNS designator FJD, FJDS."</para>
    /// labels<para>"Fjord"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Fjord">http://www.ontotext.com/proton/protonext#Fjord</seealso>
    let Fjord = Prefixed_Name(pext, "Fjord") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#FloweringPlant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any flowering plant"</para>
    /// labels<para>"Flowering plant"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#FloweringPlant">http://www.ontotext.com/proton/protonext#FloweringPlant</seealso>
    let FloweringPlant = Prefixed_Name(pext, "FloweringPlant") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Food</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Food is any eatable or drinkable substance that is normally consumed by humans. DBPedia"</para>
    /// labels<para>"Food"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Food">http://www.ontotext.com/proton/protonext#Food</seealso>
    let Food = Prefixed_Name(pext, "Food") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#FootballMatch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any instance of a soccer match."</para>
    /// labels<para>"Football match"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#FootballMatch">http://www.ontotext.com/proton/protonext#FootballMatch</seealso>
    let FootballMatch = Prefixed_Name(pext, "FootballMatch") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Forest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Dense growths of trees, plants, and underbrush covering a large area. [American Heritage Dic. of the English Language, 4th ed.] We use this category for forest reserves; and for national forests. Omitted ADL sub-classes: Petrified forests, Rain forests, Woods (the sub-classes collapsed here). NIMA GNS designator FRST, FRSTF, GDVC, GRVO, GRVP, GRVPN, TREE."</para>
    /// labels<para>"Forest"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Forest">http://www.ontotext.com/proton/protonext#Forest</seealso>
    let Forest = Prefixed_Name(pext, "Forest") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#ForestClearing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An area in a forest with trees removed. NIMA GNS designator L.CLG."</para>
    /// labels<para>"Clearing"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#ForestClearing">http://www.ontotext.com/proton/protonext#ForestClearing</seealso>
    let ForestClearing = Prefixed_Name(pext, "ForestClearing") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#FormulaOneRacer</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Sportsman</para>
    ///   <para>"The profession of formula one racer"</para>
    /// labels<para>"Formula one racer"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#FormulaOneRacer">http://www.ontotext.com/proton/protonext#FormulaOneRacer</seealso>
    let FormulaOneRacer = Prefixed_Name(pext, "FormulaOneRacer") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Fungus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Fungus is a member of a large group of eukaryotic organisms that includes microorganisms such as yeasts and molds (Wikipedia)"</para>
    /// labels<para>"Fungus"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Fungus">http://www.ontotext.com/proton/protonext#Fungus</seealso>
    let Fungus = Prefixed_Name(pext, "Fungus") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#GaelicGamesPlayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Sportsman</para>
    ///   <para>"The profession of gaelic games player"</para>
    /// labels<para>"Gaelic games player"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#GaelicGamesPlayer">http://www.ontotext.com/proton/protonext#GaelicGamesPlayer</seealso>
    let GaelicGamesPlayer = Prefixed_Name(pext, "GaelicGamesPlayer") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Galaxy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A galaxy is a massive, gravitationally bound system that consists of stars and stellar remnants, an interstellar medium of gas and dust, and an important but poorly understood component tentatively dubbed dark matter. Wikipedia"</para>
    /// labels<para>"Galaxy"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Galaxy">http://www.ontotext.com/proton/protonext#Galaxy</seealso>
    let Galaxy = Prefixed_Name(pext, "Galaxy") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Game</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Game. Activity involving participants usually divided in teams, which obeys particualr rules, and has often a winner."</para>
    /// labels<para>"Game"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Game">http://www.ontotext.com/proton/protonext#Game</seealso>
    let Game = Prefixed_Name(pext, "Game") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Gap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Ravines or gorges cut deeply through mountain ridges, or between hills or mountains. We use this category for cols; for defiles; for passes; for saddles (physiographic); and for sills (physiographic). NIMA GNS designator GAP, GAPU, GAPF, PASS, SILL, SILU."</para>
    /// labels<para>"Gap"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Gap">http://www.ontotext.com/proton/protonext#Gap</seealso>
    let Gap = Prefixed_Name(pext, "Gap") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Gene</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gene is a molecular unit of heredity of a living organism. Wikipedia"</para>
    /// labels<para>"Gene"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Gene">http://www.ontotext.com/proton/protonext#Gene</seealso>
    let Gene = Prefixed_Name(pext, "Gene") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Genre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Genre. Denotes any category of literature as well as various other forms of art or culture, e.g., music, based on some loose set of stylistic criteria. Genres are formed by conventions that change over time as new genres are invented and the use of old ones are discontinued. (Wikipedia)"</para>
    /// labels<para>"Genre"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Genre">http://www.ontotext.com/proton/protonext#Genre</seealso>
    let Genre = Prefixed_Name(pext, "Genre") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#GeographicLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Geographic Region with lattitude and longitude coordinates"</para>
    /// labels<para>"Geographic Region"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#GeographicLocation">http://www.ontotext.com/proton/protonext#GeographicLocation</seealso>
    let GeographicLocation = Prefixed_Name(pext, "GeographicLocation") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#GeopoliticalOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any geopolitical organization, an organization based on geo-political principles."</para>
    /// labels<para>"Geopolitical Organisation"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#GeopoliticalOrganization">http://www.ontotext.com/proton/protonext#GeopoliticalOrganization</seealso>
    let GeopoliticalOrganization =
        Prefixed_Name(pext, "GeopoliticalOrganization") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#Geyser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A spring characterized by intermittent discharge of water ejected turbulently and accompanied by a vapour phase (steam). NIMA GNS designator H.GYSR."</para>
    /// labels<para>"Geyser"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Geyser">http://www.ontotext.com/proton/protonext#Geyser</seealso>
    let Geyser = Prefixed_Name(pext, "Geyser") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Glacier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A mass of ice, usually at high latitudes or high elevations, with sufficient thickness to flow away from the source area in lobes, tongues, or masses"</para>
    /// labels<para>"Glacier"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Glacier">http://www.ontotext.com/proton/protonext#Glacier</seealso>
    let Glacier = Prefixed_Name(pext, "Glacier") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#GlobalRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Things like Southeastern Europe, Middle East, Oceania are global regions"</para>
    /// labels<para>"Global Region"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#GlobalRegion">http://www.ontotext.com/proton/protonext#GlobalRegion</seealso>
    let GlobalRegion = Prefixed_Name(pext, "GlobalRegion") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#GolfLeague</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Golf league"</para>
    /// labels<para>"Golf League"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#GolfLeague">http://www.ontotext.com/proton/protonext#GolfLeague</seealso>
    let GolfLeague = Prefixed_Name(pext, "GolfLeague") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#GolfPlayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Sportsman</para>
    ///   <para>"Any player of Golf."</para>
    /// labels<para>"Golf Player"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#GolfPlayer">http://www.ontotext.com/proton/protonext#GolfPlayer</seealso>
    let GolfPlayer = Prefixed_Name(pext, "GolfPlayer") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Government</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The governmental cabinet"</para>
    ///   <para>"The government of a country."</para>
    /// labels<para>"Government"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Government">http://www.ontotext.com/proton/protonext#Government</seealso>
    let Government = Prefixed_Name(pext, "Government") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#GovernmentAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The governmental cabinet"</para>
    ///   <para>"A government agency is a permanent or semi-permanent organization in the machinery of government that is responsible for the oversight and administration of specific functions, such as an intelligence agency. DBPedia"</para>
    /// labels<para>"Government"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#GovernmentAgency">http://www.ontotext.com/proton/protonext#GovernmentAgency</seealso>
    let GovernmentAgency = Prefixed_Name(pext, "GovernmentAgency") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#GovernmentBuilding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A government building, a building which serves the government, or where government officials work."</para>
    /// labels<para>"Government Building"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#GovernmentBuilding">http://www.ontotext.com/proton/protonext#GovernmentBuilding</seealso>
    let GovernmentBuilding = Prefixed_Name(pext, "GovernmentBuilding") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#GovernmentOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The government of a country, i.e. the authorized country administration, without account for a specific government elected and being in power for some period. This notion of government groups all the administration, including any sort of ministries, agencies, commissions, etc."</para>
    /// labels<para>"Government Organization"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#GovernmentOrganization">http://www.ontotext.com/proton/protonext#GovernmentOrganization</seealso>
    let GovernmentOrganization =
        Prefixed_Name(pext, "GovernmentOrganization") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#Governor</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#JobTitle</para>
    ///   <para>"Any Governor, a title of Governor of a district."</para>
    /// labels<para>"Governor"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Governor">http://www.ontotext.com/proton/protonext#Governor</seealso>
    let Governor = Prefixed_Name(pext, "Governor") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Grape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any grape"</para>
    /// labels<para>"Grape"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Grape">http://www.ontotext.com/proton/protonext#Grape</seealso>
    let Grape = Prefixed_Name(pext, "Grape") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Grassland</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An area dominated by grass vegetation"</para>
    /// labels<para>"Grassland"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Grassland">http://www.ontotext.com/proton/protonext#Grassland</seealso>
    let Grassland = Prefixed_Name(pext, "Grassland") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#GridironFootballPlayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Sportsman</para>
    ///   <para>"Any player of a gridilon football."</para>
    /// labels<para>"Gridilon Football Player"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#GridironFootballPlayer">http://www.ontotext.com/proton/protonext#GridironFootballPlayer</seealso>
    let GridironFootballPlayer =
        Prefixed_Name(pext, "GridironFootballPlayer") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#Gulf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Largest of various forms of inlets of the sea; usually larger, more enclosed, and more deeply indented than bays. NIMA GNS designator GULF."</para>
    /// labels<para>"Gulf"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Gulf">http://www.ontotext.com/proton/protonext#Gulf</seealso>
    let Gulf = Prefixed_Name(pext, "Gulf") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Guyot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A seamount having a comparatively smooth, flat top"</para>
    /// labels<para>"Tablemount"</para><para>"Guyot"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Guyot">http://www.ontotext.com/proton/protonext#Guyot</seealso>
    let Guyot = Prefixed_Name(pext, "Guyot") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#HandballLeague</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Handball league"</para>
    /// labels<para>"Handball League"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#HandballLeague">http://www.ontotext.com/proton/protonext#HandballLeague</seealso>
    let HandballLeague = Prefixed_Name(pext, "HandballLeague") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Harbor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Sheltered areas of water where ships or other watercraft can anchor or dock. We use this category for anchorages; for anclajes; for boat yards; for boatyards; for dock yards; for docking basins; for dockyards; for dry docks; for harbors; for marine terminals; for moorings; for ports; for roadsteads (anchorages); and for turning basins. The following sub-classes included (i.e. not-distinguishable): Marinas, Piers. NIMA GNS designators HBR, HBRX, MAR, BTYD, PIER, DCK, DCKB, DCKY, PRT, AIRS."</para>
    /// labels<para>"Harbor"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Harbor">http://www.ontotext.com/proton/protonext#Harbor</seealso>
    let Harbor = Prefixed_Name(pext, "Harbor") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Heath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An upland moor or sandy area dominated by low shrubby vegetation including heather"</para>
    /// labels<para>"Heath"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Heath">http://www.ontotext.com/proton/protonext#Heath</seealso>
    let Heath = Prefixed_Name(pext, "Heath") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#HistoricBuilding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Historic Building, an old building with historic value."</para>
    /// labels<para>"Historic Building"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#HistoricBuilding">http://www.ontotext.com/proton/protonext#HistoricBuilding</seealso>
    let HistoricBuilding = Prefixed_Name(pext, "HistoricBuilding") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#HistoricPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Historic Place, an old place with historic value."</para>
    /// labels<para>"Historic Place"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#HistoricPlace">http://www.ontotext.com/proton/protonext#HistoricPlace</seealso>
    let HistoricPlace = Prefixed_Name(pext, "HistoricPlace") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#HockeyTeam</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Hockey team"</para>
    /// labels<para>"Hockey Team"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#HockeyTeam">http://www.ontotext.com/proton/protonext#HockeyTeam</seealso>
    let HockeyTeam = Prefixed_Name(pext, "HockeyTeam") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Holiday</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Holiday is a day designated as having special significance for which individuals, a government, or a religious group have deemed that observance is warranted. Wikipedia"</para>
    /// labels<para>"Holiday"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Holiday">http://www.ontotext.com/proton/protonext#Holiday</seealso>
    let Holiday = Prefixed_Name(pext, "Holiday") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#HomePage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The web page address of a page that is considered main for a web cite."</para>
    /// labels<para>"Home Page"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#HomePage">http://www.ontotext.com/proton/protonext#HomePage</seealso>
    let HomePage = Prefixed_Name(pext, "HomePage") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Hospital</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Hospital, a building which is a hospital."</para>
    /// labels<para>"Hospital"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Hospital">http://www.ontotext.com/proton/protonext#Hospital</seealso>
    let Hospital = Prefixed_Name(pext, "Hospital") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Hotel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A hotel is an establishment that provides paid lodging on a short-term basis. Wikipedia"</para>
    /// labels<para>"Hotel"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Hotel">http://www.ontotext.com/proton/protonext#Hotel</seealso>
    let Hotel = Prefixed_Name(pext, "Hotel") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Human</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Human is a mammal referred to Primate. Also of the sort of hommo sapiens. It has two subClasses: Man and Woman."</para>
    /// labels<para>"Human"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Human">http://www.ontotext.com/proton/protonext#Human</seealso>
    let Human = Prefixed_Name(pext, "Human") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#HydrographicStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) For constructed bodies of water. For natural water bodies, use 'hydrographic features'. We use this category for boat landings; for boat launches; for boat ramps; for sluices; and for water mills. Many sub-classes omitted; those considered are also made sub-classes of WaterRegion. NIMA GNS ... no direct equivalent."</para>
    /// labels<para>"Hydrographic Structure"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#HydrographicStructure">http://www.ontotext.com/proton/protonext#HydrographicStructure</seealso>
    let HydrographicStructure =
        Prefixed_Name(pext, "HydrographicStructure") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#IPAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Internet Protocol address (IP address) is a numerical label assigned to each device (e.g., computer, printer) participating in a computer network that uses the Internet Protocol for communication. Wikipedia"</para>
    /// labels<para>"IP Address"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#IPAddress">http://www.ontotext.com/proton/protonext#IPAddress</seealso>
    let IPAddress = Prefixed_Name(pext, "IPAddress") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#ISBN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The ISBN (International Standard Book Number) is a unique machine-readable identification number, which marks any book unmistakably."</para>
    /// labels<para>"ISBN"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#ISBN">http://www.ontotext.com/proton/protonext#ISBN</seealso>
    let ISBN = Prefixed_Name(pext, "ISBN") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#ISSN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The ISSN (International Standard Serial Number) is an eight-digit number which identifies periodical publications as such, including electronic serials. More than one million ISSN numbers have so far been assigned."</para>
    /// labels<para>"ISSN"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#ISSN">http://www.ontotext.com/proton/protonext#ISSN</seealso>
    let ISSN = Prefixed_Name(pext, "ISSN") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#IceHockeyLeague</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Ice Hockey league"</para>
    /// labels<para>"Ice Hockey League"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#IceHockeyLeague">http://www.ontotext.com/proton/protonext#IceHockeyLeague</seealso>
    let IceHockeyLeague = Prefixed_Name(pext, "IceHockeyLeague") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#IceHockeyPlayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Sportsman</para>
    ///   <para>"The profession of ice hockey player"</para>
    /// labels<para>"Hockey player"</para><para>"Ice hockey player"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#IceHockeyPlayer">http://www.ontotext.com/proton/protonext#IceHockeyPlayer</seealso>
    let IceHockeyPlayer = Prefixed_Name(pext, "IceHockeyPlayer") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Icecap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A dome-shaped mass of glacial ice covering an area of mountain summits or other high lands; smaller than an ice sheet"</para>
    /// labels<para>"Icecap"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Icecap">http://www.ontotext.com/proton/protonext#Icecap</seealso>
    let Icecap = Prefixed_Name(pext, "Icecap") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Ideology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An ideology is a set of ideas that constitute one's goals, expectations, and actions. Wikipedia."</para>
    /// labels<para>"Ideology"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Ideology">http://www.ontotext.com/proton/protonext#Ideology</seealso>
    let Ideology = Prefixed_Name(pext, "Ideology") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#ImageDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Image"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#ImageDocument">http://www.ontotext.com/proton/protonext#ImageDocument</seealso>
    let ImageDocument = Prefixed_Name(pext, "ImageDocument") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#IndustrySector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A classification of companies that have similar production processes, similar products, etc."</para>
    /// labels<para>"Industry Sector"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#IndustrySector">http://www.ontotext.com/proton/protonext#IndustrySector</seealso>
    let IndustrySector = Prefixed_Name(pext, "IndustrySector") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#InformationSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Information Space"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#InformationSpace">http://www.ontotext.com/proton/protonext#InformationSpace</seealso>
    let InformationSpace = Prefixed_Name(pext, "InformationSpace") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#InformationSpaceProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Information Space Profile"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#InformationSpaceProfile">http://www.ontotext.com/proton/protonext#InformationSpaceProfile</seealso>
    let InformationSpaceProfile =
        Prefixed_Name(pext, "InformationSpaceProfile") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#InlineHockeyLeague</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Inline Hockey league"</para>
    /// labels<para>"Inline Hockey League"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#InlineHockeyLeague">http://www.ontotext.com/proton/protonext#InlineHockeyLeague</seealso>
    let InlineHockeyLeague = Prefixed_Name(pext, "InlineHockeyLeague") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Insect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Insects are a class within the arthropods that have a chitinous exoskeleton, a three-part body (head, thorax, and abdomen), three pairs of jointed legs, compound eyes, and two antennae. (Wikipedia)"</para>
    /// labels<para>"Insect"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Insect">http://www.ontotext.com/proton/protonext#Insect</seealso>
    let Insect = Prefixed_Name(pext, "Insect") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Institute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A research organization devoted primarily on search in some scientific research."</para>
    /// labels<para>"Institute"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Institute">http://www.ontotext.com/proton/protonext#Institute</seealso>
    let Institute = Prefixed_Name(pext, "Institute") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#InsuranceCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A company providing insurance services agains different dangerous or risky events."</para>
    /// labels<para>"Insurance Company"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#InsuranceCompany">http://www.ontotext.com/proton/protonext#InsuranceCompany</seealso>
    let InsuranceCompany = Prefixed_Name(pext, "InsuranceCompany") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#InternationalOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Legal international organization. Legal in this case means officially recognized by more than one government."</para>
    /// labels<para>"International Organization"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#InternationalOrganization">http://www.ontotext.com/proton/protonext#InternationalOrganization</seealso>
    let InternationalOrganization =
        Prefixed_Name(pext, "InternationalOrganization") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#InternetAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An identifier that determines a resource on the Internet."</para>
    /// labels<para>"Internet Address"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#InternetAddress">http://www.ontotext.com/proton/protonext#InternetAddress</seealso>
    let InternetAddress = Prefixed_Name(pext, "InternetAddress") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#InternetDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A domain name is an identification string that defines the area of administrative autonomy, authority, or control in the Internet. Wikipedia."</para>
    /// labels<para>"Internet Domain"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#InternetDomain">http://www.ontotext.com/proton/protonext#InternetDomain</seealso>
    let InternetDomain = Prefixed_Name(pext, "InternetDomain") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#IrrigationSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A network of ditches and one or more of the following elements: water supply, reservoir, canal, pump, well, drain, etc. NIMA GNS designator H.SYSI."</para>
    /// labels<para>"Irrigation System"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#IrrigationSystem">http://www.ontotext.com/proton/protonext#IrrigationSystem</seealso>
    let IrrigationSystem = Prefixed_Name(pext, "IrrigationSystem") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Island</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Tracts of land smaller than a continent, surrounded by the water of an ocean, sea, lake or stream. [Glossary of Geology, 4th ed.] We use this category for atolls; for cays; for island arcs; for isles; for islets; for keys (islands); for land-tied islands; and for mangrove islands. NIMA GNS designator ISL, ISLF, ISLM, ISLS, ISLT, ISLX"</para>
    /// labels<para>"Island"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Island">http://www.ontotext.com/proton/protonext#Island</seealso>
    let Island = Prefixed_Name(pext, "Island") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#IssueOfPeriodical</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific issue, number, and/or volume of periodical publication such as magazine."</para>
    /// labels<para>"Issue of Periodical"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#IssueOfPeriodical">http://www.ontotext.com/proton/protonext#IssueOfPeriodical</seealso>
    let IssueOfPeriodical = Prefixed_Name(pext, "IssueOfPeriodical") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Isthmus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Narrow sections of land in a body of water connecting two larger land areas. NIMA GNS designator ISTH."</para>
    /// labels<para>"Isthmus"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Isthmus">http://www.ontotext.com/proton/protonext#Isthmus</seealso>
    let Isthmus = Prefixed_Name(pext, "Isthmus") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#JobTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The name of a position a person holds within an organization."</para>
    /// labels<para>"Job Title"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#JobTitle">http://www.ontotext.com/proton/protonext#JobTitle</seealso>
    let JobTitle = Prefixed_Name(pext, "JobTitle") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Journalist</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Profession</para>
    ///   <para>"Any journalist, a profession of collecting and disseminating information about current events, people, trends, and issues. (Wikipedia)"</para>
    /// labels<para>"Journalist"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Journalist">http://www.ontotext.com/proton/protonext#Journalist</seealso>
    let Journalist = Prefixed_Name(pext, "Journalist") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Judge</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Profession</para>
    ///   <para>"Any judge, a profession of presiding over a court of law, either alone or as part of a panel of judges. (Wikipedia)"</para>
    /// labels<para>"Judge"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Judge">http://www.ontotext.com/proton/protonext#Judge</seealso>
    let Judge = Prefixed_Name(pext, "Judge") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Jungle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Tropical regions of wild, tangled, dense vegetation. NIMA GNS designator - no equivalent."</para>
    /// labels<para>"Jungle"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Jungle">http://www.ontotext.com/proton/protonext#Jungle</seealso>
    let Jungle = Prefixed_Name(pext, "Jungle") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#LacrosseLeague</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Lacrosse league"</para>
    /// labels<para>"Lacrosse League"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#LacrosseLeague">http://www.ontotext.com/proton/protonext#LacrosseLeague</seealso>
    let LacrosseLeague = Prefixed_Name(pext, "LacrosseLeague") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Lagoon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A body of water cut off from the open sea by coral reefs or sand bars. http://www.eionet.europa.eu/gemet/concept/4589. NIMA GNS designator H.LGN, H.LGNS, H.LGNX."</para>
    /// labels<para>"Lagoon"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Lagoon">http://www.ontotext.com/proton/protonext#Lagoon</seealso>
    let Lagoon = Prefixed_Name(pext, "Lagoon") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Lake</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Use 'reservoirs' for human engineered lakes. Natural inland bodies of standing water, generally of appreciable size, occupying a depression in the Earth's surface. [Adapted from Glossary of Geology, 4th ed.] We use this category for beaver ponds; for crater lakes; for dry lakes; for fish ponds; for fishponds; for inland seas; for intermittent lakes; for intermittent oxbow lakes; for intermittent ponds; for intermittent pools; for intermittent salt lakes; for intermittent salt ponds; for lagoons; for laguna; for lake beds; for lochs; for millponds; for oxbow lakes; for ponds; for pools (water bodies); for salt evaporation ponds; for salt lakes; for salt ponds; and for tarns. NIMA GNS designators LBED, LK, LKC, LKI, LKN, LKNI, LKO, LKOI, LKS, LKSB, LKSC, LKSI, LKSN, LKSNI, LKX"</para>
    /// labels<para>"Lake"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Lake">http://www.ontotext.com/proton/protonext#Lake</seealso>
    let Lake = Prefixed_Name(pext, "Lake") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#LandArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A tract of land without homogeneous character or boundaries. NIMA GNS designator L.AREA."</para>
    /// labels<para>"Area"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#LandArea">http://www.ontotext.com/proton/protonext#LandArea</seealso>
    let LandArea = Prefixed_Name(pext, "LandArea") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#LandRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any sort of land regions which are sort of natural, i.e. excluding urban areas, political and administrative regions. It combines number of ADL feature types under Physiographic features and Regions. Omitted ADL sub-classes: Badlands, Bars, Basins, Bight, Cirques, Cliffs, Dunes, Flats, Karst areas. Ledges, Massifs, Mineral deposit areas, Moraines, Natural rock formations, Arches, Playas, Seafloor Features, Tectonic features, Volcanic features (Volcano put under Mountain), Subcontinents. NIMA GNS designators FSR, FURU, HMCK, PLDR, RKFL, SINK, SLID, SLP, SLPU, TERU, TRR."</para>
    /// labels<para>"Land Region"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#LandRegion">http://www.ontotext.com/proton/protonext#LandRegion</seealso>
    let LandRegion = Prefixed_Name(pext, "LandRegion") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#LaunchFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Areas from which rockets/missiles may be housed and projected, usually equipped with associated buildings and facilities. [USGS Circ 1048] We use this category for missile sites. NIMA GNS designator - no equivalent."</para>
    /// labels<para>"Launch Facility"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#LaunchFacility">http://www.ontotext.com/proton/protonext#LaunchFacility</seealso>
    let LaunchFacility = Prefixed_Name(pext, "LaunchFacility") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#LawFirm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A law firm is a business entity formed by one or more lawyers to engage in the practice of law. The primary service provided by a law firm is to advise clients (individuals or corporations) about their legal rights and responsibilities, and to represent their clients in civil or criminal cases, business transactions, and other matters in which legal advice and other assistance are sought. DBPedia"</para>
    /// labels<para>"Law firm"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#LawFirm">http://www.ontotext.com/proton/protonext#LawFirm</seealso>
    let LawFirm = Prefixed_Name(pext, "LawFirm") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Lawyer</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Profession</para>
    ///   <para>"Any lawyer, a profession of according to Black's Law Dictionary, is a person learned in the law; as an attorney, counsel or solicitor; a person who is practicing law. of judges. (Wikipedia)"</para>
    /// labels<para>"Lawyer"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Lawyer">http://www.ontotext.com/proton/protonext#Lawyer</seealso>
    let Lawyer = Prefixed_Name(pext, "Lawyer") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#LegalCases</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Denotes concrete legal cases, such as Dennis v. United States, Francis v. Resweber, United_States v. Virginia, etc."</para>
    /// labels<para>"Legal Cases"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#LegalCases">http://www.ontotext.com/proton/protonext#LegalCases</seealso>
    let LegalCases = Prefixed_Name(pext, "LegalCases") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Legislation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Various sorts of legislative documents, including consitutions, laws, etc."</para>
    /// labels<para>"Legislation"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Legislation">http://www.ontotext.com/proton/protonext#Legislation</seealso>
    let Legislation = Prefixed_Name(pext, "Legislation") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Library</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collection of books, journals, audio and video materials, etc."</para>
    /// labels<para>"Library"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Library">http://www.ontotext.com/proton/protonext#Library</seealso>
    let Library = Prefixed_Name(pext, "Library") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#LibraryBuilding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A building in which library organization is housed."</para>
    /// labels<para>"Library"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#LibraryBuilding">http://www.ontotext.com/proton/protonext#LibraryBuilding</seealso>
    let LibraryBuilding = Prefixed_Name(pext, "LibraryBuilding") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#LibraryOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An education organization teaching pupils from first grade to tenth/eleventh/twelfth grade. It could be a primary school, or a secondary school."</para>
    /// labels<para>"Library"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#LibraryOrganization">http://www.ontotext.com/proton/protonext#LibraryOrganization</seealso>
    let LibraryOrganization = Prefixed_Name(pext, "LibraryOrganization") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Lieutenant</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#JobTitle</para>
    ///   <para>"Any lieutenant, title in a military unit."</para>
    /// labels<para>"Lieutenant"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Lieutenant">http://www.ontotext.com/proton/protonext#Lieutenant</seealso>
    let Lieutenant = Prefixed_Name(pext, "Lieutenant") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#LightHouse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A tower, building, or other type of structure designed to emit light from a system of lamps and lenses and used as an aid to navigation for maritime pilots at sea or on inland waterways"</para>
    /// labels<para>"Lighthouse"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#LightHouse">http://www.ontotext.com/proton/protonext#LightHouse</seealso>
    let LightHouse = Prefixed_Name(pext, "LightHouse") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#LivingObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Living object is any organism which is living, e.g. breathing and regular lifecycle."</para>
    /// labels<para>"Living Object"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#LivingObject">http://www.ontotext.com/proton/protonext#LivingObject</seealso>
    let LivingObject = Prefixed_Name(pext, "LivingObject") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#LocalCapital</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A capital of a Province or smaller administrative region. NIMA GNS designator PPLA."</para>
    /// labels<para>"Local Capital"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#LocalCapital">http://www.ontotext.com/proton/protonext#LocalCapital</seealso>
    let LocalCapital = Prefixed_Name(pext, "LocalCapital") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#LocationOfSpecialInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any place with some particular value, which triggers interest."</para>
    /// labels<para>"Location of Special Interest"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#LocationOfSpecialInterest">http://www.ontotext.com/proton/protonext#LocationOfSpecialInterest</seealso>
    let LocationOfSpecialInterest =
        Prefixed_Name(pext, "LocationOfSpecialInterest") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#Lock</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Stretches of water in canals, streams, or docks, enclosed by gates at each end, and used in raising and lowering boats as they pass from one water level to another. NIMA GNS designator LOCK."</para>
    /// labels<para>"Lock"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Lock">http://www.ontotext.com/proton/protonext#Lock</seealso>
    let Lock = Prefixed_Name(pext, "Lock") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Locomotive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Locomotive, a railway vehicle that provides the motive power for a train. (Wikipedia)"</para>
    /// labels<para>"Locomotive"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Locomotive">http://www.ontotext.com/proton/protonext#Locomotive</seealso>
    let Locomotive = Prefixed_Name(pext, "Locomotive") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#LymphNode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Lymph is a general concept gathering all lymph nodes of the body."</para>
    /// labels<para>"Lymphatic Node"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#LymphNode">http://www.ontotext.com/proton/protonext#LymphNode</seealso>
    let LymphNode = Prefixed_Name(pext, "LymphNode") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Machine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any produced device with particular purpose that uses energy to perform some activity. The device has parts that perform or assist in performing any type of work. (Wikipedia)"</para>
    /// labels<para>"Machine"</para><para>"Device"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Machine">http://www.ontotext.com/proton/protonext#Machine</seealso>
    let Machine = Prefixed_Name(pext, "Machine") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Magazine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A periodic paperback publication; "it takes several years before a magazine starts to break even or make money"), WordNet 1.7.1. This includes also journals and digests. The specific issues typically contain a number of different articles."</para>
    /// labels<para>"Magazine"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Magazine">http://www.ontotext.com/proton/protonext#Magazine</seealso>
    let Magazine = Prefixed_Name(pext, "Magazine") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#MagazineIssue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific issue of a magazine, journal or digest."</para>
    /// labels<para>"Magazine Issue"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#MagazineIssue">http://www.ontotext.com/proton/protonext#MagazineIssue</seealso>
    let MagazineIssue = Prefixed_Name(pext, "MagazineIssue") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Mammal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Mammals are members of a class of air-breathing vertebrate animals characterized by the possession of hair, three middle ear bones, and mammary glands functional in mothers with young. Most mammals also possess sweat glands and specialized teeth, and the largest group of mammals, the placentals, have a placenta which feeds the offspring during gestation. (Wikipedia)"</para>
    /// labels<para>"Mammal"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Mammal">http://www.ontotext.com/proton/protonext#Mammal</seealso>
    let Mammal = Prefixed_Name(pext, "Mammal") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Man</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A male human."</para>
    /// labels<para>"Man"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Man">http://www.ontotext.com/proton/protonext#Man</seealso>
    let Man = Prefixed_Name(pext, "Man") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Manager</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#JobTitle</para>
    ///   <para>"Any manager, the title of a management position in an organization."</para>
    /// labels<para>"Manager"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Manager">http://www.ontotext.com/proton/protonext#Manager</seealso>
    let Manager = Prefixed_Name(pext, "Manager") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Market</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In contrast to IndustrySector, the market is determined by the customers instead of the business or the manifacturers. The market can be defined in terms of types of goods/services, geographic region, price levels and typical customer behaviours. Corresponding to the third sense in WordNet 1.7.1 "the customers for a particular product or service"."</para>
    /// labels<para>"Market"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Market">http://www.ontotext.com/proton/protonext#Market</seealso>
    let Market = Prefixed_Name(pext, "Market") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Marsh</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An area of open ground overlaid with wet peaty soils; a wetland dominated by grass-like vegetation; a flat area, subject to periodic salt water inundation, dominated by grassy salt-tolerant plants; a salt flat or salt encrusted plain subject to periodic inundation from flooding or high tides"</para>
    /// labels<para>"Marsh"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Marsh">http://www.ontotext.com/proton/protonext#Marsh</seealso>
    let Marsh = Prefixed_Name(pext, "Marsh") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#MartialArtist</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Sportsman</para>
    ///   <para>"The profession of a martial artist"</para>
    /// labels<para>"Martial artist"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#MartialArtist">http://www.ontotext.com/proton/protonext#MartialArtist</seealso>
    let MartialArtist = Prefixed_Name(pext, "MartialArtist") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Mayor</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#JobTitle</para>
    ///   <para>"Any Mayor, a title of the head of a municipality."</para>
    /// labels<para>"Mayor"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Mayor">http://www.ontotext.com/proton/protonext#Mayor</seealso>
    let Mayor = Prefixed_Name(pext, "Mayor") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Meadow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A small, poorly drained area dominated by grassy vegetation"</para>
    /// labels<para>"Meadow"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Meadow">http://www.ontotext.com/proton/protonext#Meadow</seealso>
    let Meadow = Prefixed_Name(pext, "Meadow") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#MediaBrand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A brand of a media company."</para>
    /// labels<para>"Media Brand"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#MediaBrand">http://www.ontotext.com/proton/protonext#MediaBrand</seealso>
    let MediaBrand = Prefixed_Name(pext, "MediaBrand") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#MediaCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Media Company"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#MediaCompany">http://www.ontotext.com/proton/protonext#MediaCompany</seealso>
    let MediaCompany = Prefixed_Name(pext, "MediaCompany") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#MediaProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A mass media product (for instance a newspaper) abstracted from its organizational and ownership aspects (i.e. from its publisher) and considered more as a social phenomenon, partly a brand."</para>
    /// labels<para>"Media Product"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#MediaProduct">http://www.ontotext.com/proton/protonext#MediaProduct</seealso>
    let MediaProduct = Prefixed_Name(pext, "MediaProduct") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Meeting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A meeting is a gathering of two or more people that has been convened for the purpose of achieving a common goal through verbal interaction, such as sharing information or reaching an agreement. Wikipedia."</para>
    /// labels<para>"Meeting"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Meeting">http://www.ontotext.com/proton/protonext#Meeting</seealso>
    let Meeting = Prefixed_Name(pext, "Meeting") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#MeetingProceedings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collection of articles or presentations published as a book."</para>
    /// labels<para>"Meeting Proceedings"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#MeetingProceedings">http://www.ontotext.com/proton/protonext#MeetingProceedings</seealso>
    let MeetingProceedings = Prefixed_Name(pext, "MeetingProceedings") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#MemberOfParliament</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#JobTitle</para>
    ///   <para>"Any member of parliament, a title of a member of parliament."</para>
    /// labels<para>"Member of Parliament"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#MemberOfParliament">http://www.ontotext.com/proton/protonext#MemberOfParliament</seealso>
    let MemberOfParliament = Prefixed_Name(pext, "MemberOfParliament") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Mention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An area of a document that can be considered a mention of something."</para>
    /// labels<para>"Section"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Mention">http://www.ontotext.com/proton/protonext#Mention</seealso>
    let Mention = Prefixed_Name(pext, "Mention") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Message</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A written message, including various postings in newspapers or public sources, job position adverts, etc."</para>
    /// labels<para>"Message"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Message">http://www.ontotext.com/proton/protonext#Message</seealso>
    let Message = Prefixed_Name(pext, "Message") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#MilitaryAreas</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FTT) We use this category for air force bases; for army facilities; for arsenals; for artillery ranges; for barracks; for bases (military); for camps (military); for forts; for infantry camps; for maneuver areas; for military bases; for military installations; for national guard facilities; and for naval bases. The following NIMA designators fit here: MILB, INSM, SCHM. The following ADL types are skipped as irrelevant: Cadastral areas,"</para>
    /// labels<para>"Military Areas"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#MilitaryAreas">http://www.ontotext.com/proton/protonext#MilitaryAreas</seealso>
    let MilitaryAreas = Prefixed_Name(pext, "MilitaryAreas") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#MilitaryCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any military command, the organization which has a commanding role in a military organization."</para>
    /// labels<para>"Military Command"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#MilitaryCommand">http://www.ontotext.com/proton/protonext#MilitaryCommand</seealso>
    let MilitaryCommand = Prefixed_Name(pext, "MilitaryCommand") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#MilitaryConflict</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An event of organized, armed, and often prolonged conflict carried on between states, nations, or other parties. Wikipedia."</para>
    /// labels<para>"Military Conflict"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#MilitaryConflict">http://www.ontotext.com/proton/protonext#MilitaryConflict</seealso>
    let MilitaryConflict = Prefixed_Name(pext, "MilitaryConflict") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#MilitaryOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any military organisation, the structuring of the armed forces of a state so as to offer military capability required by the national defence policy. (Wikipedia)"</para>
    /// labels<para>"Military Organisation"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#MilitaryOrganization">http://www.ontotext.com/proton/protonext#MilitaryOrganization</seealso>
    let MilitaryOrganization =
        Prefixed_Name(pext, "MilitaryOrganization") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#MilitaryPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Profession</para>
    ///   <para>"Any occupation involving service in the military."</para>
    /// labels<para>"Military Person"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#MilitaryPerson">http://www.ontotext.com/proton/protonext#MilitaryPerson</seealso>
    let MilitaryPerson = Prefixed_Name(pext, "MilitaryPerson") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#MilitaryUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any military unit, a smaller military organization."</para>
    /// labels<para>"Military Unit"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#MilitaryUnit">http://www.ontotext.com/proton/protonext#MilitaryUnit</seealso>
    let MilitaryUnit = Prefixed_Name(pext, "MilitaryUnit") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#MineSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Places or areas from which commercial minerals are or were removed by excavation from the Earth. [Adapted from USGS Feature Class Definitions &lt;http://mapping.usgs.gov/www/ti/GNIS/gnis_users_guide_appendixc.html&gt;] We use this category for adits (mine sites); for chrome mines; for coal mines; for collieries; for copper mines; for diatomite mines; for gold mines; for gravel pits; for iron mines; for lead mines; for mine entrances; for mine shafts; for mines; for mining areas; for mining camps; for nickel mines; for open pit mines; for placer mines; for quarries; for salt mines; for strip mines; and for tin mines. NIMA GNS designators MN, MNA, MNAU, MNC, MNCR, MNDT, MNCU, MNFE, MNN, MNNI, MNPB, MNPL. MNQ, MNSN."</para>
    /// labels<para>"Mine Site"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#MineSite">http://www.ontotext.com/proton/protonext#MineSite</seealso>
    let MineSite = Prefixed_Name(pext, "MineSite") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Ministry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(Department) A specific ministry or department, structural unit of the government of specific country with focus and authority on specific problems of the country."</para>
    /// labels<para>"Ministry"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Ministry">http://www.ontotext.com/proton/protonext#Ministry</seealso>
    let Ministry = Prefixed_Name(pext, "Ministry") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#MixedMartialArtsLeague</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Mixed Martial Arts league"</para>
    /// labels<para>"Mixed Martial Arts League"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#MixedMartialArtsLeague">http://www.ontotext.com/proton/protonext#MixedMartialArtsLeague</seealso>
    let MixedMartialArtsLeague =
        Prefixed_Name(pext, "MixedMartialArtsLeague") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#Mollusca</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Mollusca is a large phylum of invertebrate animals. This is the largest marine phylum, comprising about 23% of all the named marine organisms. Numerous molluscs also live in freshwater and terrestrial habitats. Molluscs are highly diverse, not only in size and in anatomical structure, but also in behaviour and in habitat. (Wikipedia)"</para>
    /// labels<para>"Mollusca"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Mollusca">http://www.ontotext.com/proton/protonext#Mollusca</seealso>
    let Mollusca = Prefixed_Name(pext, "Mollusca") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Monarch</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#NobeltyTitle</para>
    ///   <para>"Any Monarch, a title of a head of state in a monarchy."</para>
    /// labels<para>"Monarch"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Monarch">http://www.ontotext.com/proton/protonext#Monarch</seealso>
    let Monarch = Prefixed_Name(pext, "Monarch") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Money</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific amount of money in specific currency"</para>
    /// labels<para>"Money"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Money">http://www.ontotext.com/proton/protonext#Money</seealso>
    let Money = Prefixed_Name(pext, "Money") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Month</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific month, like Dec 2000, as a time period."</para>
    /// labels<para>"Month"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Month">http://www.ontotext.com/proton/protonext#Month</seealso>
    let Month = Prefixed_Name(pext, "Month") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Monument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Structures erected as memorials. [Adapted from American Heritage Dic. of the English Language, 4th ed.] We use this category for cairns; for landmarks (monuments); for memorials; for national monuments; for pyramids; for shrines; for statues; and for tombs. NIMA GNS designators MNMT, PYR, PYRS, CARN."</para>
    /// labels<para>"Monument"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Monument">http://www.ontotext.com/proton/protonext#Monument</seealso>
    let Monument = Prefixed_Name(pext, "Monument") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#MotorcycleRacingLeague</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Motorcycle Racing league"</para>
    /// labels<para>"Motorcycle Racing League"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#MotorcycleRacingLeague">http://www.ontotext.com/proton/protonext#MotorcycleRacingLeague</seealso>
    let MotorcycleRacingLeague =
        Prefixed_Name(pext, "MotorcycleRacingLeague") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#Mountain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Landmasses that project conspicuously above their surroundings. [USGS Circ 1048] We use this category for cerros; for cordilleras; for foothills; for hills; for knolls; for mounds; and for mounts. Omitted ADL sub-classes: Continental divides. NIMA GNS designator MT, MTS, MTSU, MTU, MND, KNLU, KNSU, CDAU, HLL, HLLS, HLLU, HLSU."</para>
    /// labels<para>"Mountain"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Mountain">http://www.ontotext.com/proton/protonext#Mountain</seealso>
    let Mountain = Prefixed_Name(pext, "Mountain") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#MountainPass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any mountain pass. NIMA GNS designators - no direct equivalents"</para>
    /// labels<para>"Mountain Pass"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#MountainPass">http://www.ontotext.com/proton/protonext#MountainPass</seealso>
    let MountainPass = Prefixed_Name(pext, "MountainPass") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#MountainRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) (a) Chains of hills or mountains; (b) somewhat linear, complex mountainous or hilly areas. ... We use this category for ranges (physiographic); and for sierra. NIMA GNS designator RNGU."</para>
    /// labels<para>"Mountain Range"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#MountainRange">http://www.ontotext.com/proton/protonext#MountainRange</seealso>
    let MountainRange = Prefixed_Name(pext, "MountainRange") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#MountainSummit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Peaks of mountains. [USGS Circ 1048] We use this category for ahus; for mountain crests; for nunataks; for peaks; and for summits. NIMA GNS designators PK, PKS, PKSU, PKU."</para>
    /// labels<para>"Mountain Summit"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#MountainSummit">http://www.ontotext.com/proton/protonext#MountainSummit</seealso>
    let MountainSummit = Prefixed_Name(pext, "MountainSummit") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Movie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A film, also called a movie or motion picture, is a series of still or moving images. Wikipedia."</para>
    /// labels<para>"Movie"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Movie">http://www.ontotext.com/proton/protonext#Movie</seealso>
    let Movie = Prefixed_Name(pext, "Movie") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#MudFlat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A relatively level area of mud either between high and low tide lines, or subject to flooding; a large flat area of mud or sand attached to the shore and alternately covered and uncovered by the tide; a tropical tidal mud flat characterized by mangrove vegetation"</para>
    /// labels<para>"Mud Flat"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#MudFlat">http://www.ontotext.com/proton/protonext#MudFlat</seealso>
    let MudFlat = Prefixed_Name(pext, "MudFlat") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Muscle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any muscle of a body."</para>
    /// labels<para>"Muscle"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Muscle">http://www.ontotext.com/proton/protonext#Muscle</seealso>
    let Muscle = Prefixed_Name(pext, "Muscle") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Museum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any museum, an institution that houses and cares for a collection of artifacts and other objects of scientific, artistic, or historical importance and makes them available for public viewing through exhibits that may be permanent or temporary. (Wikipedia)"</para>
    /// labels<para>"Museum"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Museum">http://www.ontotext.com/proton/protonext#Museum</seealso>
    let Museum = Prefixed_Name(pext, "Museum") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#MusicCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Musical company, a company involved in the music business, e.g. sells compositions, recordings and performances of music, like Soni Music Entertainment."</para>
    /// labels<para>"Musical Company"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#MusicCompany">http://www.ontotext.com/proton/protonext#MusicCompany</seealso>
    let MusicCompany = Prefixed_Name(pext, "MusicCompany") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#MusicFestival</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any festival involving playing music."</para>
    /// labels<para>"Music Festival"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#MusicFestival">http://www.ontotext.com/proton/protonext#MusicFestival</seealso>
    let MusicFestival = Prefixed_Name(pext, "MusicFestival") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#MusicGenre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any genre which pertians to music, e.g. classical, folk, pop, etc."</para>
    /// labels<para>"Music Genre"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#MusicGenre">http://www.ontotext.com/proton/protonext#MusicGenre</seealso>
    let MusicGenre = Prefixed_Name(pext, "MusicGenre") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Musical</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Musical is a form of theatre or movie combining music, songs, spoken dialogue and dance. (Wikipedia)"</para>
    /// labels<para>"Musical"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Musical">http://www.ontotext.com/proton/protonext#Musical</seealso>
    let Musical = Prefixed_Name(pext, "Musical") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#MusicalComposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An original piece of music."</para>
    /// labels<para>"Musical Composition"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#MusicalComposition">http://www.ontotext.com/proton/protonext#MusicalComposition</seealso>
    let MusicalComposition = Prefixed_Name(pext, "MusicalComposition") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#MusicalInstrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Musical Instrument, a device created or adapted for the purpose of making musical sounds. (Wikipedia)"</para>
    /// labels<para>"Musical Instrument"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#MusicalInstrument">http://www.ontotext.com/proton/protonext#MusicalInstrument</seealso>
    let MusicalInstrument = Prefixed_Name(pext, "MusicalInstrument") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Musician</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#ArtProfession</para>
    ///   <para>"Any musician, a profession of writing, performing, or making music. (Wikipedia)"</para>
    /// labels<para>"Musician"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Musician">http://www.ontotext.com/proton/protonext#Musician</seealso>
    let Musician = Prefixed_Name(pext, "Musician") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Narrows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A tidal strait. NIMA GNS designator H.NRWS."</para>
    /// labels<para>"Narrows"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Narrows">http://www.ontotext.com/proton/protonext#Narrows</seealso>
    let Narrows = Prefixed_Name(pext, "Narrows") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#NascarDriver</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Sportsman</para>
    ///   <para>"The profession of nascar driver"</para>
    /// labels<para>"Nascar driver"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#NascarDriver">http://www.ontotext.com/proton/protonext#NascarDriver</seealso>
    let NascarDriver = Prefixed_Name(pext, "NascarDriver") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#NationalCollegiateAthleticAssociationAthlete</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Sportsman</para>
    ///   <para>"The profession of national collegiate athletic association athlete"</para>
    /// labels<para>"National collegiate athletic association athlete"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#NationalCollegiateAthleticAssociationAthlete">http://www.ontotext.com/proton/protonext#NationalCollegiateAthleticAssociationAthlete</seealso>
    let NationalCollegiateAthleticAssociationAthlete =
        Prefixed_Name(pext, "NationalCollegiateAthleticAssociationAthlete") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#Nationality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any nationality. In most cases it is connected with a country name, but there are notionalities without countries - Kurd, etc."</para>
    /// labels<para>"Nationality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Nationality">http://www.ontotext.com/proton/protonext#Nationality</seealso>
    let Nationality = Prefixed_Name(pext, "Nationality") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#NaturalPhenomenon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Such as particular disease, the Gulfstream and other similar natural abstractions. The particular events or objects which could instantiate an abstract natural phenomena (i.e. specific sickness event caused by a disease) are not instances of this class."</para>
    /// labels<para>"Natural Phenomenon"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#NaturalPhenomenon">http://www.ontotext.com/proton/protonext#NaturalPhenomenon</seealso>
    let NaturalPhenomenon = Prefixed_Name(pext, "NaturalPhenomenon") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#NaturalSatellite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A satellite which is not a direct result of human activity"</para>
    /// labels<para>"Natural Satellite"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#NaturalSatellite">http://www.ontotext.com/proton/protonext#NaturalSatellite</seealso>
    let NaturalSatellite = Prefixed_Name(pext, "NaturalSatellite") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Nerve</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Nerve is a general concept gathering all nerves of a body."</para>
    /// labels<para>"Nerve"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Nerve">http://www.ontotext.com/proton/protonext#Nerve</seealso>
    let Nerve = Prefixed_Name(pext, "Nerve") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#NewsAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A news agency is an organization of journalists established to supply news reports to news organizations: newspapers, magazines, and radio and television broadcasters. Wikipedia"</para>
    /// labels<para>"News agency"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#NewsAgency">http://www.ontotext.com/proton/protonext#NewsAgency</seealso>
    let NewsAgency = Prefixed_Name(pext, "NewsAgency") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Newspaper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A newspaper abstracted from its organizational and ownership aspects as well as from a specific issue or paper body."</para>
    /// labels<para>"Newspaper"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Newspaper">http://www.ontotext.com/proton/protonext#Newspaper</seealso>
    let Newspaper = Prefixed_Name(pext, "Newspaper") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#NewspaperIssue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific issue of a newspaper."</para>
    /// labels<para>"Newspaper Issue"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#NewspaperIssue">http://www.ontotext.com/proton/protonext#NewspaperIssue</seealso>
    let NewspaperIssue = Prefixed_Name(pext, "NewspaperIssue") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Nobelty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The situation of holding a position in society as nobelty."</para>
    /// labels<para>"Nobelty"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Nobelty">http://www.ontotext.com/proton/protonext#Nobelty</seealso>
    let Nobelty = Prefixed_Name(pext, "Nobelty") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#NobeltyTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The social function of a nobelty."</para>
    /// labels<para>"Nobelty"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#NobeltyTitle">http://www.ontotext.com/proton/protonext#NobeltyTitle</seealso>
    let NobeltyTitle = Prefixed_Name(pext, "NobeltyTitle") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#Non-ProfitOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Non-Profit Organization, an organization that does not distribute its surplus funds to owners or shareholders, but instead uses them to help pursue its goals. (Wikipedia)"</para>
    /// labels<para>"Non-Orofit Organisation"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Non-ProfitOrganisation">http://www.ontotext.com/proton/protonext#Non-ProfitOrganisation</seealso>
    let Non_ProfitOrganisation =
        Prefixed_Name(pext, "Non-ProfitOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#NonAlcoholicBeverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A type (specific receipe) for a beverage. For instance: Coca Cola, Schweppes, Apple Juice, etc."</para>
    /// labels<para>"Non Alcoholic Beverage"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#NonAlcoholicBeverage">http://www.ontotext.com/proton/protonext#NonAlcoholicBeverage</seealso>
    let NonAlcoholicBeverage =
        Prefixed_Name(pext, "NonAlcoholicBeverage") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#NonGeographicLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A non-geographic region in some 3D space. The Longitude and Latitude properties for such objects could be void."</para>
    /// labels<para>"Non-Geographic Location"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#NonGeographicLocation">http://www.ontotext.com/proton/protonext#NonGeographicLocation</seealso>
    let NonGeographicLocation =
        Prefixed_Name(pext, "NonGeographicLocation") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#Oasis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Fertile, vegetated areas in the midst of a desert, where the water table has come close enough to the surface for wells and springs or seepages to exist, thus making them suitable for human habitation. NIMA GNS designator OAS."</para>
    /// labels<para>"Oasis"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Oasis">http://www.ontotext.com/proton/protonext#Oasis</seealso>
    let Oasis = Prefixed_Name(pext, "Oasis") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Ocean</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Continuous salt-water bodies that surround the continents and fill the Earth's great depressions. NIMA GNS designator OCN"</para>
    /// labels<para>"Ocean"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Ocean">http://www.ontotext.com/proton/protonext#Ocean</seealso>
    let Ocean = Prefixed_Name(pext, "Ocean") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Offer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Something offered (as a proposal or bid), WordNet 1.7.1. An offer is a statement made by the offerer to a specific agent or without recepient."</para>
    /// labels<para>"Offer"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Offer">http://www.ontotext.com/proton/protonext#Offer</seealso>
    let Offer = Prefixed_Name(pext, "Offer") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#OfficialPoliticalMeeting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A meeting whose main participants are political entities playing official roles within it."</para>
    /// labels<para>"Official Political Meeting"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#OfficialPoliticalMeeting">http://www.ontotext.com/proton/protonext#OfficialPoliticalMeeting</seealso>
    let OfficialPoliticalMeeting =
        Prefixed_Name(pext, "OfficialPoliticalMeeting") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#OfficialPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A job position having a representative function with respect to an organization. Usually this is a position within a governmental organization."</para>
    /// labels<para>"Official Position"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#OfficialPosition">http://www.ontotext.com/proton/protonext#OfficialPosition</seealso>
    let OfficialPosition = Prefixed_Name(pext, "OfficialPosition") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#OilField</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Areas with reserves of recoverable petroleum or where petroleum has been removed from the Earth. ... We use this category for gas fields; for gasfields; for oilfields; for petroleum fields; and for storage fields (petroleum). NIMA GNS designator CMPO, OILF, OILQ, OILW, PMPO, GASF."</para>
    /// labels<para>"Oil Field"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#OilField">http://www.ontotext.com/proton/protonext#OilField</seealso>
    let OilField = Prefixed_Name(pext, "OilField") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#OlympicGames</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The institution of Olympic Games held every 4 years"</para>
    /// labels<para>"Olympic Games"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#OlympicGames">http://www.ontotext.com/proton/protonext#OlympicGames</seealso>
    let OlympicGames = Prefixed_Name(pext, "OlympicGames") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#OlympicGamesOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific issue of the games, like Athens 2004"</para>
    /// labels<para>"Olympic Games"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#OlympicGamesOccurrence">http://www.ontotext.com/proton/protonext#OlympicGamesOccurrence</seealso>
    let OlympicGamesOccurrence =
        Prefixed_Name(pext, "OlympicGamesOccurrence") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#OperaPerformance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An art performance following an opera music and script."</para>
    /// labels<para>"Opera Performance"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#OperaPerformance">http://www.ontotext.com/proton/protonext#OperaPerformance</seealso>
    let OperaPerformance = Prefixed_Name(pext, "OperaPerformance") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Orchard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A planting of fruit or nut trees"</para>
    /// labels<para>"Orchard"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Orchard">http://www.ontotext.com/proton/protonext#Orchard</seealso>
    let Orchard = Prefixed_Name(pext, "Orchard") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Order</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A statement used to request someone to supply something in return for payment and providing specifications and quantities. WordNet 2.1."</para>
    /// labels<para>"Order"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Order">http://www.ontotext.com/proton/protonext#Order</seealso>
    let Order = Prefixed_Name(pext, "Order") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#OutOfLaws</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The situation of holding a position in a society as out of law."</para>
    /// labels<para>"OutOfLaws"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#OutOfLaws">http://www.ontotext.com/proton/protonext#OutOfLaws</seealso>
    let OutOfLaws = Prefixed_Name(pext, "OutOfLaws") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#OutOfLawsTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Criminal, the social function of a person who has committed a crime and is out of the law."</para>
    /// labels<para>"Criminal"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#OutOfLawsTitle">http://www.ontotext.com/proton/protonext#OutOfLawsTitle</seealso>
    let OutOfLawsTitle = Prefixed_Name(pext, "OutOfLawsTitle") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Overfalls</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An area of breaking waves caused by the meeting of currents or by waves moving against the current. NIMA GNS designator H.OVF."</para>
    /// labels<para>"Overfalls"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Overfalls">http://www.ontotext.com/proton/protonext#Overfalls</seealso>
    let Overfalls = Prefixed_Name(pext, "Overfalls") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#PaintballLeague</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Paintball league"</para>
    /// labels<para>"Paintball League"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#PaintballLeague">http://www.ontotext.com/proton/protonext#PaintballLeague</seealso>
    let PaintballLeague = Prefixed_Name(pext, "PaintballLeague") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Painting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any painting, the results of a practice of applying paint, pigment, color or other medium[1] to a surface (support base). (Wikipedia)"</para>
    /// labels<para>"painting"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Painting">http://www.ontotext.com/proton/protonext#Painting</seealso>
    let Painting = Prefixed_Name(pext, "Painting") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Parish</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A district of religious land. NIMA GNS designator A.PRSH."</para>
    /// labels<para>"Parish"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Parish">http://www.ontotext.com/proton/protonext#Parish</seealso>
    let Parish = Prefixed_Name(pext, "Parish") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Park</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Places or areas developed for public use or recreation. [USGS Circ 1048] We use this category for arboretums; for botanical gardens; for commemorative areas; for commons; for gardens; for marine parks; for national forests; for national parks; for national seashores; for park gates; for picnic areas; for playgrounds; for provincial parks; for public use areas; for recreation areas; for rest areas; for scenic areas; for state forests; for state parks; for urban parks; for village squares; for wilderness areas; for zoological gardens; and for zoos. Omitted sub-classes: Viewing locations. NIMA GNS designators PRK, PRKHQ, PRKGT"</para>
    /// labels<para>"Park"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Park">http://www.ontotext.com/proton/protonext#Park</seealso>
    let Park = Prefixed_Name(pext, "Park") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Parliament</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A legislative assembly representative at national or regional level. It can also be called Senate, etc."</para>
    /// labels<para>"Parliament"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Parliament">http://www.ontotext.com/proton/protonext#Parliament</seealso>
    let Parliament = Prefixed_Name(pext, "Parliament") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Patent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A registered (or awaiting registration) patent for specific invention or design."</para>
    /// labels<para>"Patent"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Patent">http://www.ontotext.com/proton/protonext#Patent</seealso>
    let Patent = Prefixed_Name(pext, "Patent") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Peninsula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A land region surrounded by water from most sides, but having land connect to bigger land region. NIMA GNS designator PEN, PENX."</para>
    /// labels<para>"Peninsula"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Peninsula">http://www.ontotext.com/proton/protonext#Peninsula</seealso>
    let Peninsula = Prefixed_Name(pext, "Peninsula") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Percent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific percent value"</para>
    /// labels<para>"Percent"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Percent">http://www.ontotext.com/proton/protonext#Percent</seealso>
    let Percent = Prefixed_Name(pext, "Percent") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#PerformanceSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Buildings where cultural events are presented before an audience. We use this category for amphitheaters; for amphitheatres; for auditoriums; for bowls (performance); for coliseums; for concert halls; for opera houses; for playhouses; for recital halls; for stages (performance); for symphony halls; for theaters; and for theatres. NIMA GNS designator AMTH."</para>
    /// labels<para>"Performance Site"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#PerformanceSite">http://www.ontotext.com/proton/protonext#PerformanceSite</seealso>
    let PerformanceSite = Prefixed_Name(pext, "PerformanceSite") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#PeriodicalPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A periodical publication, disregarding its specific issues, numbers, volumes, etc."</para>
    /// labels<para>"Periodical Publication"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#PeriodicalPublication">http://www.ontotext.com/proton/protonext#PeriodicalPublication</seealso>
    let PeriodicalPublication =
        Prefixed_Name(pext, "PeriodicalPublication") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#PetroleumBasin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An area underlain by an oil-rich structural basin. NIMA GNS designator L.BSNP."</para>
    /// labels<para>"Petroleum Basin"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#PetroleumBasin">http://www.ontotext.com/proton/protonext#PetroleumBasin</seealso>
    let PetroleumBasin = Prefixed_Name(pext, "PetroleumBasin") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Philosopher</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Profession</para>
    ///   <para>"Any philosopher, a profession of studying of general and fundamental problems, such as those connected with existence, knowledge, values, reason, mind, and language."</para>
    /// labels<para>"Philosopher"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Philosopher">http://www.ontotext.com/proton/protonext#Philosopher</seealso>
    let Philosopher = Prefixed_Name(pext, "Philosopher") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#PhoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sequence of digits which represents an address of a telephone device within a telephone net."</para>
    /// labels<para>"Phone Number"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#PhoneNumber">http://www.ontotext.com/proton/protonext#PhoneNumber</seealso>
    let PhoneNumber = Prefixed_Name(pext, "PhoneNumber") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#PieceOfArt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An artifact, namely a piece of art, usually, matterial object. Typical instances are paintings and sculptures. Corresponds to the Wordnet 1.7.1 synset "art, fine art - the products of human creativity; works of art collectively; "an art exhibition"@en ; "a fine collection of art")""</para>
    /// labels<para>"Piece of Art"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#PieceOfArt">http://www.ontotext.com/proton/protonext#PieceOfArt</seealso>
    let PieceOfArt = Prefixed_Name(pext, "PieceOfArt") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Pipeline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Tubular conduits of substantial length, with pumps, valves, and control devices, for conveying fluids, gases, or finely divided solids. [USGS Circ 1048] We use this category for compressor stations; for gas pipelines; for oil pipeline junctions; for oil pipeline terminals; for oil pipelines; for oil pumping stations; for pump houses; for pumphouses; for pumping stations; and for water pumping stations. NIMA GNS designators OILP, OILJ, TRMO, PMPO, PMPW."</para>
    /// labels<para>"Pipeline"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Pipeline">http://www.ontotext.com/proton/protonext#Pipeline</seealso>
    let Pipeline = Prefixed_Name(pext, "Pipeline") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Plain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Regions of general uniform slope, comparatively level and of considerable extent. [USGS Circ 1048] We use this category for interfluves; and for llanos. NIMA GNS designators PLN, PLNU, PLNX, INTF."</para>
    /// labels<para>"Plain"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Plain">http://www.ontotext.com/proton/protonext#Plain</seealso>
    let Plain = Prefixed_Name(pext, "Plain") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Planet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any of the celestial bodies (other than comets or satellites) that revolve around the sun in the solar system. Definition partly derived from WordNet 1.7"</para>
    /// labels<para>"Planet"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Planet">http://www.ontotext.com/proton/protonext#Planet</seealso>
    let Planet = Prefixed_Name(pext, "Planet") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Plant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Plants are living organisms. They include familiar organisms such as trees, flowers, herbs, bushes, grasses, vines, ferns, mosses, and green algae. (Wikipedia)"</para>
    /// labels<para>"Plant"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Plant">http://www.ontotext.com/proton/protonext#Plant</seealso>
    let Plant = Prefixed_Name(pext, "Plant") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Plateau</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Comparatively flat areas of great extent and elevation; specif. extensive land regions considerably above the adjacent country or above sea level; commonly limited on at least one side by an abrupt descent, have flat or nearly smooth surfaces but are often dissected by deep valleys and surmounted by high hills or mountains, and have a large part of their total surface at or near the summit level. We use this category for table mountains; and for tablelands. The ADL type Mesas, collapsed here. NIMA GNS designators PLAT, PLTX, PLTU, MESA, MESU, TMSU, TMST."</para>
    /// labels<para>"Plateau"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Plateau">http://www.ontotext.com/proton/protonext#Plateau</seealso>
    let Plateau = Prefixed_Name(pext, "Plateau") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Play</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A play is a form of literature written by a playwright, usually consisting of scripted dialogue between characters, intended for theatrical performance rather than just reading. DBPedia"</para>
    /// labels<para>"Play"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Play">http://www.ontotext.com/proton/protonext#Play</seealso>
    let Play = Prefixed_Name(pext, "Play") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#PlayboyPlaymate</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#JobTitle</para>
    ///   <para>"The occupation of playboy playmate"</para>
    /// labels<para>"Playboy playmate"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#PlayboyPlaymate">http://www.ontotext.com/proton/protonext#PlayboyPlaymate</seealso>
    let PlayboyPlaymate = Prefixed_Name(pext, "PlayboyPlaymate") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#PokerPlayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Profession</para>
    ///   <para>"The profession of a poker player"</para>
    /// labels<para>"Poker player"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#PokerPlayer">http://www.ontotext.com/proton/protonext#PokerPlayer</seealso>
    let PokerPlayer = Prefixed_Name(pext, "PokerPlayer") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#PolishKing</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#NobeltyTitle</para>
    ///   <para>"A title of Polish kings."</para>
    /// labels<para>"Polish king"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#PolishKing">http://www.ontotext.com/proton/protonext#PolishKing</seealso>
    let PolishKing = Prefixed_Name(pext, "PolishKing") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#PoliticalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any organization which has a political functions."</para>
    /// labels<para>"Political Entity"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#PoliticalEntity">http://www.ontotext.com/proton/protonext#PoliticalEntity</seealso>
    let PoliticalEntity = Prefixed_Name(pext, "PoliticalEntity") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#PoliticalParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An organization to gain political power. Definition taken from WordNet 1.7"</para>
    /// labels<para>"Political Party"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#PoliticalParty">http://www.ontotext.com/proton/protonext#PoliticalParty</seealso>
    let PoliticalParty = Prefixed_Name(pext, "PoliticalParty") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#PoliticalRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL, Political Entity) We use this category for commonwealths; for dependent political entities; for freely associated states; for independent political entities; for oblasts; for political entities; and for semi-independent political entities. Sub-classes omitted: Countries, 4th order divisions. NIMA GNS class: A, Administrative Boundary Features."</para>
    /// labels<para>"Political Region"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#PoliticalRegion">http://www.ontotext.com/proton/protonext#PoliticalRegion</seealso>
    let PoliticalRegion = Prefixed_Name(pext, "PoliticalRegion") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Politician</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Profession</para>
    ///   <para>"Any Politician, a profession of participating in the political life of a given society."</para>
    /// labels<para>"Politician"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Politician">http://www.ontotext.com/proton/protonext#Politician</seealso>
    let Politician = Prefixed_Name(pext, "Politician") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#PoloLeague</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Polo league"</para>
    /// labels<para>"Polo League"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#PoloLeague">http://www.ontotext.com/proton/protonext#PoloLeague</seealso>
    let PoloLeague = Prefixed_Name(pext, "PoloLeague") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Pond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A pond is a body of standing water, either natural or man-made, that is usually smaller than a lake. (Wikipedia). http://www.eionet.europa.eu/gemet/concept/6507. NIMA GNS designator H.PND, H.PNDI, H.PNDN, H.PNDNI, H.PNDS, H.PNDSF, H.PNDSI, H.PNDSN, H.MFGN."</para>
    /// labels<para>"Pond"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Pond">http://www.ontotext.com/proton/protonext#Pond</seealso>
    let Pond = Prefixed_Name(pext, "Pond") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Pool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A small and comparatively still, deep part of a larger body of water. NIMA GNS designator H.POOL, H.POOLI."</para>
    /// labels<para>"Pool"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Pool">http://www.ontotext.com/proton/protonext#Pool</seealso>
    let Pool = Prefixed_Name(pext, "Pool") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Pope</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#ClericTitle</para>
    ///   <para>"Any Pope. the head of the Roman-Catholic church."</para>
    /// labels<para>"Pope"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Pope">http://www.ontotext.com/proton/protonext#Pope</seealso>
    let Pope = Prefixed_Name(pext, "Pope") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#PopulatedPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Places or areas with clustered or scattered buildings and a permanent human population. ... We use this category for agricultural colonies; for communes; for communities; for hamlets; for homesteads; for locales; for localities; for metropolitan areas; for populated localities; for ppl; for pueblos; for settlements; for suburbs; for villages; and with religious facilities for religious populated places. NIMA GNS designator PPL, PPL(x)"</para>
    /// labels<para>"Populated Place"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#PopulatedPlace">http://www.ontotext.com/proton/protonext#PopulatedPlace</seealso>
    let PopulatedPlace = Prefixed_Name(pext, "PopulatedPlace") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#PopulatedPlaceName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Part of a postal address denoting the name of a village, town, city, country, etc."</para>
    /// labels<para>"Town Name"</para><para>"Country Name"</para><para>"Village Name"</para><para>"Name of a Populated Place"</para><para>"City Name"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#PopulatedPlaceName">http://www.ontotext.com/proton/protonext#PopulatedPlaceName</seealso>
    let PopulatedPlaceName = Prefixed_Name(pext, "PopulatedPlaceName") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#PositionOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The situation of a job position which is available in a particular organization, such as CEO, CTO, executive assistant, etc."</para>
    /// labels<para>"Position in an organization"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#PositionOrganization">http://www.ontotext.com/proton/protonext#PositionOrganization</seealso>
    let PositionOrganization =
        Prefixed_Name(pext, "PositionOrganization") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#Possession</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any property, e.g. possessions, the situation of owning an object."</para>
    /// labels<para>"Possessions"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Possession">http://www.ontotext.com/proton/protonext#Possession</seealso>
    let Possession = Prefixed_Name(pext, "Possession") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#PostalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An address of a geographical place - usually a building. A postal address consists, usually, of a country name, zip code, city/village name, street name and number, a person name."</para>
    /// labels<para>"Postal Address"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#PostalAddress">http://www.ontotext.com/proton/protonext#PostalAddress</seealso>
    let PostalAddress = Prefixed_Name(pext, "PostalAddress") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#PowerStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any power station"</para>
    /// labels<para>"Power station"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#PowerStation">http://www.ontotext.com/proton/protonext#PowerStation</seealso>
    let PowerStation = Prefixed_Name(pext, "PowerStation") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#President</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#JobTitle</para>
    ///   <para>"Any president, a title of a president of a country or an organization."</para>
    /// labels<para>"President"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#President">http://www.ontotext.com/proton/protonext#President</seealso>
    let President = Prefixed_Name(pext, "President") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Priest</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Profession</para>
    ///   <para>"Any priest, a professsion of a person who is authorized to perform the sacred rites of a religion. (Wikipedia)"</para>
    /// labels<para>"Priest"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Priest">http://www.ontotext.com/proton/protonext#Priest</seealso>
    let Priest = Prefixed_Name(pext, "Priest") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#PrimeMinister</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#JobTitle</para>
    ///   <para>"Any prime minister, a title Prime minister of a country."</para>
    /// labels<para>"Prime Minister"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#PrimeMinister">http://www.ontotext.com/proton/protonext#PrimeMinister</seealso>
    let PrimeMinister = Prefixed_Name(pext, "PrimeMinister") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Profession</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A profession is a vocation founded upon specialized educational training. Wikipedia."</para>
    /// labels<para>"Profession"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Profession">http://www.ontotext.com/proton/protonext#Profession</seealso>
    let Profession = Prefixed_Name(pext, "Profession") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Profile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Profile"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Profile">http://www.ontotext.com/proton/protonext#Profile</seealso>
    let Profile = Prefixed_Name(pext, "Profile") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#ProgrammingLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A formal language for encoding of computer programs."</para>
    /// labels<para>"Programming language"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#ProgrammingLanguage">http://www.ontotext.com/proton/protonext#ProgrammingLanguage</seealso>
    let ProgrammingLanguage = Prefixed_Name(pext, "ProgrammingLanguage") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Project</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A project is carefully planned event to achieve a particular aim. Based on Wikipedia."</para>
    /// labels<para>"Project"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Project">http://www.ontotext.com/proton/protonext#Project</seealso>
    let Project = Prefixed_Name(pext, "Project") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#ProtectedArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Protected Area, an area which benefits of special attention and is with limited access or protected in other ways."</para>
    /// labels<para>"Protected Area"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#ProtectedArea">http://www.ontotext.com/proton/protonext#ProtectedArea</seealso>
    let ProtectedArea = Prefixed_Name(pext, "ProtectedArea") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Protein</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Denotes any protein as a biological substance."</para>
    /// labels<para>"Protein"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Protein">http://www.ontotext.com/proton/protonext#Protein</seealso>
    let Protein = Prefixed_Name(pext, "Protein") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Province</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT: Countries, 1st Order Divisions) First-order divisions of a nation. [USGS Circ 1048] We use this category for cantons; for first-order administrative divisions; for provinces; for states; and for territories. NIMA GNS designator ADM1. Also corresponds to the FIPS 10-4 principal administrative division defined as "an administrative area directly subordinate to the pertinent governing authority " NIMA GNS designator ADM1."</para>
    /// labels<para>"Province"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Province">http://www.ontotext.com/proton/protonext#Province</seealso>
    let Province = Prefixed_Name(pext, "Province") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#PublicCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Company which is publicly traded on a Stock Exchange."</para>
    /// labels<para>"Public Company"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#PublicCompany">http://www.ontotext.com/proton/protonext#PublicCompany</seealso>
    let PublicCompany = Prefixed_Name(pext, "PublicCompany") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#PublishedMaterial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document that is published or intended for publishing"</para>
    /// labels<para>"Published Material"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#PublishedMaterial">http://www.ontotext.com/proton/protonext#PublishedMaterial</seealso>
    let PublishedMaterial = Prefixed_Name(pext, "PublishedMaterial") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#PublishingCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An organization which main activity is mass publishing of information. Often, the publishers issue periodic and/or non-periodic documents on paper media. While on-line publishing is considered a typical activity for publishers, the streaming electronic media such as TV and Radio Stations are not."</para>
    /// labels<para>"Publishing Company"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#PublishingCompany">http://www.ontotext.com/proton/protonext#PublishingCompany</seealso>
    let PublishingCompany = Prefixed_Name(pext, "PublishingCompany") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Quarter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific quarter of a specific year, such as Q4 1999"</para>
    /// labels<para>"Quarter"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Quarter">http://www.ontotext.com/proton/protonext#Quarter</seealso>
    let Quarter = Prefixed_Name(pext, "Quarter") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#RaceCourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A racecourse is a horse racing track."</para>
    /// labels<para>"Race Course"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#RaceCourse">http://www.ontotext.com/proton/protonext#RaceCourse</seealso>
    let RaceCourse = Prefixed_Name(pext, "RaceCourse") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#RadioCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A company that broadcasts audio content."</para>
    /// labels<para>"Radio company"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#RadioCompany">http://www.ontotext.com/proton/protonext#RadioCompany</seealso>
    let RadioCompany = Prefixed_Name(pext, "RadioCompany") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#RadioControlledRacingLeague</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Radio Controlled Racing league"</para>
    /// labels<para>"Radio Controlled Racing League"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#RadioControlledRacingLeague">http://www.ontotext.com/proton/protonext#RadioControlledRacingLeague</seealso>
    let RadioControlledRacingLeague =
        Prefixed_Name(pext, "RadioControlledRacingLeague") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#RadioStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A brand of a radio station."</para>
    /// labels<para>"Radio Station"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#RadioStation">http://www.ontotext.com/proton/protonext#RadioStation</seealso>
    let RadioStation = Prefixed_Name(pext, "RadioStation") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#RailroadFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT: Railroad Features) We use this category for metro rail stations; for railroad junctions; for railroad sidings; for railroad spurs; for railroad stations; for railroad stops; for railroad switches; for railroad yards; for railways; for subway stations; for switches (railroad); and for tramways. NIMA GNS designator RJCT, RR, RRQ, RSD, RSGNL, RSTN, RSTNQ, RSTP, RSTPQ, RYD."</para>
    /// labels<para>"Railroad Facility"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#RailroadFacility">http://www.ontotext.com/proton/protonext#RailroadFacility</seealso>
    let RailroadFacility = Prefixed_Name(pext, "RailroadFacility") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#RailroadTunnel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A tunnel for trains. NIMA GNS designator RTNL."</para>
    /// labels<para>"Railroad Tunnel"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#RailroadTunnel">http://www.ontotext.com/proton/protonext#RailroadTunnel</seealso>
    let RailroadTunnel = Prefixed_Name(pext, "RailroadTunnel") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Ramp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gentle slope connecting areas of different elevations"</para>
    /// labels<para>"Ramp"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Ramp">http://www.ontotext.com/proton/protonext#Ramp</seealso>
    let Ramp = Prefixed_Name(pext, "Ramp") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Rapids</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A turbulent section of a stream associated with a steep, irregular stream bed. NIMA GNS designator H.RPDS."</para>
    /// labels<para>"Rapids"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Rapids">http://www.ontotext.com/proton/protonext#Rapids</seealso>
    let Rapids = Prefixed_Name(pext, "Rapids") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#RecreationalFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) We use this category for access areas; for access sites; for boardwalks; for casinos; for clubs (recreational); for country clubs; for fairgrounds; for fishing areas; for fishing lodges; for fitness centers; for gun clubs; for hunt posts; for hunting lodges; for ice skating rinks; for playgrounds; for recreation sites; for resorts; for riding stables; for spas; for sportsman lodges; for stables; for yacht clubs; for youth centers; and for youth facilities. NIMA GNS designators - no direct equivalents."</para>
    /// labels<para>"Recreational Facility"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#RecreationalFacility">http://www.ontotext.com/proton/protonext#RecreationalFacility</seealso>
    let RecreationalFacility =
        Prefixed_Name(pext, "RecreationalFacility") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#RecurringEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Recurring sequence of events, such as Olympic Games, etc.."</para>
    /// labels<para>"Recurring Event"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#RecurringEvent">http://www.ontotext.com/proton/protonext#RecurringEvent</seealso>
    let RecurringEvent = Prefixed_Name(pext, "RecurringEvent") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Reef</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Chains of rocks or coral at or near the surface of water. [USGS Circ 1048] We use this category for barrier reefs; and for fringing reefs. Collapsed ADL sub-class: Coral Reefs. NIMA GNS designator RF, RFSU, RFU, RFC, H.RFX."</para>
    /// labels<para>"Reef"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Reef">http://www.ontotext.com/proton/protonext#Reef</seealso>
    let Reef = Prefixed_Name(pext, "Reef") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Referee</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Profession</para>
    ///   <para>"A referee is the person of authority, in a variety of sports, who is responsible for presiding over the game from a neutral point of view. (Wikipedia)"</para>
    /// labels<para>"Referee"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Referee">http://www.ontotext.com/proton/protonext#Referee</seealso>
    let Referee = Prefixed_Name(pext, "Referee") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#ReferenceLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) We use this category for astronomical stations; for beacons; for bench marks; for boundaries; for boundary markers; for buoys; for control points; for geodectic stations; for geographic centers; for landmarks (reference locations); for light houses; for light stations; for lighthouses; for markers; for milestones; for plaques; for poles (sphere); for triangulation stations; and for walls. NIMNA GNS designators LTHSE, BP, TRIG."</para>
    /// labels<para>"Reference Location"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#ReferenceLocation">http://www.ontotext.com/proton/protonext#ReferenceLocation</seealso>
    let ReferenceLocation = Prefixed_Name(pext, "ReferenceLocation") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#RegionMention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Region Mention"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#RegionMention">http://www.ontotext.com/proton/protonext#RegionMention</seealso>
    let RegionMention = Prefixed_Name(pext, "RegionMention") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#ReligiousLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Things like Monastery, Church"</para>
    /// labels<para>"Religious Location"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#ReligiousLocation">http://www.ontotext.com/proton/protonext#ReligiousLocation</seealso>
    let ReligiousLocation = Prefixed_Name(pext, "ReligiousLocation") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#ReligiousOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Organization which offers ideas and opinions about life. Just joking."</para>
    /// labels<para>"Religious Organization"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#ReligiousOrganization">http://www.ontotext.com/proton/protonext#ReligiousOrganization</seealso>
    let ReligiousOrganization =
        Prefixed_Name(pext, "ReligiousOrganization") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#Report</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document describing the result of some event."</para>
    /// labels<para>"Report"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Report">http://www.ontotext.com/proton/protonext#Report</seealso>
    let Report = Prefixed_Name(pext, "Report") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Reptile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Reptiles are animals in the class Reptilia. They are characterized by breathing air, laying shelled eggs, and having skin covered in scales and/or scutes. Reptiles are classically viewed as having a "cold-blooded" metabolism. They are tetrapods. Modern reptiles inhabit every continent with the exception of Antarctica. Example of an reptile is the crocodile. (Wikipedia)"</para>
    /// labels<para>"Reptile"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Reptile">http://www.ontotext.com/proton/protonext#Reptile</seealso>
    let Reptile = Prefixed_Name(pext, "Reptile") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#ResearchArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Specific research area, topic or field."</para>
    /// labels<para>"Research Area"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#ResearchArea">http://www.ontotext.com/proton/protonext#ResearchArea</seealso>
    let ResearchArea = Prefixed_Name(pext, "ResearchArea") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#ResearchOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An organization performing scientific research."</para>
    /// labels<para>"Research Organization"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#ResearchOrganization">http://www.ontotext.com/proton/protonext#ResearchOrganization</seealso>
    let ResearchOrganization =
        Prefixed_Name(pext, "ResearchOrganization") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#Reserve</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Areas set aside for the preservation of fauna, flora, and their natural habitats. [Macmillan Encyc., 2001] We use this category for agricultural reserves; for conservation areas; for demonstration areas; for environmental areas; for forest reserves; for game management areas; for hunting reserves; for management areas (reserves); for natural areas; for nature reserves; for palm tree reserves; for preserves; for primitive areas; for protected areas; for reservations (nature sites); for road less areas; for sanctuaries (wildlife); for wildlife areas; for wildlife refuges; and for wildlife reserves. NIMA GNS designators RES, RESA, RESF, RESH, RESN, RESP, RESV, RESW."</para>
    /// labels<para>"Reserve"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Reserve">http://www.ontotext.com/proton/protonext#Reserve</seealso>
    let Reserve = Prefixed_Name(pext, "Reserve") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Reservoir</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Artificially impounded bodies of water. We use this category for covered reservoirs; and for intermittent reservoirs. (incl. dams) NIMA GNS designator RSV, RSVI."</para>
    /// labels<para>"Reservoir"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Reservoir">http://www.ontotext.com/proton/protonext#Reservoir</seealso>
    let Reservoir = Prefixed_Name(pext, "Reservoir") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#ResourceCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collection is an aggregation of information resources. The term collection means that the resource is described as a group; its parts may be separately described and navigated. (DCMI type Collection)"</para>
    /// labels<para>"Resource Collection"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#ResourceCollection">http://www.ontotext.com/proton/protonext#ResourceCollection</seealso>
    let ResourceCollection = Prefixed_Name(pext, "ResourceCollection") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Restaurant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any restaurant, a place where food, drink and dessert to customers is prepared and served in return for money. (Wikipedia)"</para>
    /// labels<para>"Restaurant"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Restaurant">http://www.ontotext.com/proton/protonext#Restaurant</seealso>
    let Restaurant = Prefixed_Name(pext, "Restaurant") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Ridge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Elevations with a narrow, elongated crest which can be part of a hill or mountain. ... We use this category for aretes; for beach ridges; for cuestas; for eskers; for hogbacks; for icecap ridges; for rises (seafloor); and for spurs (physiographic). Omitted ADL sub-classes: Drumlin. NIMA GNS designators RDGB, RDGE, RDGG, RDGU, RISU, SPRU, SPUR."</para>
    /// labels<para>"Ridge"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Ridge">http://www.ontotext.com/proton/protonext#Ridge</seealso>
    let Ridge = Prefixed_Name(pext, "Ridge") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#River</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Natural freshwater surface streams of considerable volume and a permanent or seasonal flow, moving in a definite channel toward a sea, lake, or another river; any large streams, or ones larger than brooks or creeks, such as the trunk stream and larger branches of a drainage system. We use this category for rios. NIM GNS designators ... no direct equivalents!"</para>
    /// labels<para>"River"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#River">http://www.ontotext.com/proton/protonext#River</seealso>
    let River = Prefixed_Name(pext, "River") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#RiverCutoff</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A new channel cut by a river across the neck of an oxbow. NIMA GNS designator H.CUTF."</para>
    /// labels<para>"Cutoff"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#RiverCutoff">http://www.ontotext.com/proton/protonext#RiverCutoff</seealso>
    let RiverCutoff = Prefixed_Name(pext, "RiverCutoff") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Roadway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Open ways for passage of vehicles. [USGS Circ 1048] We use this category for caravan routes; for causeways; for drives; for highways; for intersections; for parkways; for road bends; for road cuts; for road junctions; for roads; for streets; and for traffic circles. NIMA GNS designators CSWY, CSWYQ, RD, RDA, RDB, RDCUT, RDJCT, RDST, RTE, STKR."</para>
    /// labels<para>"Roadway"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Roadway">http://www.ontotext.com/proton/protonext#Roadway</seealso>
    let Roadway = Prefixed_Name(pext, "Roadway") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#RugbyClub</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A rugby team"</para>
    ///   <para>"A sport club that organizes the playing of rugby."</para>
    /// labels<para>"Rugby Club"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#RugbyClub">http://www.ontotext.com/proton/protonext#RugbyClub</seealso>
    let RugbyClub = Prefixed_Name(pext, "RugbyClub") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#RugbyLeague</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Rugby League"</para>
    /// labels<para>"Rugby League"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#RugbyLeague">http://www.ontotext.com/proton/protonext#RugbyLeague</seealso>
    let RugbyLeague = Prefixed_Name(pext, "RugbyLeague") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#RugbyPlayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Sportsman</para>
    ///   <para>"The profession of rugby player"</para>
    /// labels<para>"Rugby player"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#RugbyPlayer">http://www.ontotext.com/proton/protonext#RugbyPlayer</seealso>
    let RugbyPlayer = Prefixed_Name(pext, "RugbyPlayer") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Saddleback</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A low part, resembling in shape a saddle, in a ridge or between contiguous seamounts"</para>
    /// labels<para>"Saddle"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Saddleback">http://www.ontotext.com/proton/protonext#Saddleback</seealso>
    let Saddleback = Prefixed_Name(pext, "Saddleback") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Saint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any saint, a holy person, in whom Christ dwells, whether in heaven or in earth."</para>
    /// labels<para>"Saint"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Saint">http://www.ontotext.com/proton/protonext#Saint</seealso>
    let Saint = Prefixed_Name(pext, "Saint") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Sale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any event in which a participant is receiving a good from another participant of the event on the basis of some payment."</para>
    /// labels<para>"Sale"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Sale">http://www.ontotext.com/proton/protonext#Sale</seealso>
    let Sale = Prefixed_Name(pext, "Sale") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Satellite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An astronomic object orbiting around a planet or star. Definition partly derived from WordNet 1.7"</para>
    /// labels<para>"Satellite"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Satellite">http://www.ontotext.com/proton/protonext#Satellite</seealso>
    let Satellite = Prefixed_Name(pext, "Satellite") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#School</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An education organization teaching pupils from first grade to tenth/eleventh/twelfth grade. It could be a primary school, or a secondary school."</para>
    /// labels<para>"School"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#School">http://www.ontotext.com/proton/protonext#School</seealso>
    let School = Prefixed_Name(pext, "School") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Science</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A well established, big research area"</para>
    /// labels<para>"Science"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Science">http://www.ontotext.com/proton/protonext#Science</seealso>
    let Science = Prefixed_Name(pext, "Science") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Scientist</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Profession</para>
    ///   <para>"Any scientist, a profession of studying and making research on a particualr subject."</para>
    /// labels<para>"Scientist"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Scientist">http://www.ontotext.com/proton/protonext#Scientist</seealso>
    let Scientist = Prefixed_Name(pext, "Scientist") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Scrubland</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An area of low trees, bushes, and shrubs stunted by some environmental limitation"</para>
    /// labels<para>"Scrubland"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Scrubland">http://www.ontotext.com/proton/protonext#Scrubland</seealso>
    let Scrubland = Prefixed_Name(pext, "Scrubland") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Sculpture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any sculpture, three-dimensional artwork created by shaping or combining hard materials. (Wikipedia)"</para>
    /// labels<para>"Sculpture"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Sculpture">http://www.ontotext.com/proton/protonext#Sculpture</seealso>
    let Sculpture = Prefixed_Name(pext, "Sculpture") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Sea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Large bodies of salt water. NIMA GNS designator SEA"</para>
    /// labels<para>"Sea"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Sea">http://www.ontotext.com/proton/protonext#Sea</seealso>
    let Sea = Prefixed_Name(pext, "Sea") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#SeaSound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A long arm of the sea forming a channel between the mainland and an island or islands; or connecting two larger bodies of water. NIMA GNS designator H.SD."</para>
    /// labels<para>"Sound"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#SeaSound">http://www.ontotext.com/proton/protonext#SeaSound</seealso>
    let SeaSound = Prefixed_Name(pext, "SeaSound") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#SeaTongue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An elongate (tongue-like) extension of a flat sea floor into an adjacent higher feature"</para>
    /// labels<para>"Tongue"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#SeaTongue">http://www.ontotext.com/proton/protonext#SeaTongue</seealso>
    let SeaTongue = Prefixed_Name(pext, "SeaTongue") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#SeaTrench</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A long, narrow, characteristically very deep and asymmetrical depression of the sea floor, with relatively steep sides"</para>
    /// labels<para>"Trench"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#SeaTrench">http://www.ontotext.com/proton/protonext#SeaTrench</seealso>
    let SeaTrench = Prefixed_Name(pext, "SeaTrench") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#SeaTrough</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A long depression of the sea floor characteristically flat bottomed and steep sided, and normally shallower than a trench"</para>
    /// labels<para>"Trough"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#SeaTrough">http://www.ontotext.com/proton/protonext#SeaTrough</seealso>
    let SeaTrough = Prefixed_Name(pext, "SeaTrough") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Seachannels</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Continuously sloping, elongated depressions commonly found in fans or plains and customarily bordered by levees on one or two sides (U.SCSU; U.SCSU)"</para>
    /// labels<para>"Seachannels"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Seachannels">http://www.ontotext.com/proton/protonext#Seachannels</seealso>
    let Seachannels = Prefixed_Name(pext, "Seachannels") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Seamount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An elevation rising generally more than 1,000 meters and of limited extent across the summit. (U.SMSU; U.SMU)"</para>
    /// labels<para>"Seamount"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Seamount">http://www.ontotext.com/proton/protonext#Seamount</seealso>
    let Seamount = Prefixed_Name(pext, "Seamount") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Season</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"One of the seasons of the year. In the places with a temperate climate there are four seasons: spring, summer, autumn, and winter."</para>
    /// labels<para>"Season"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Season">http://www.ontotext.com/proton/protonext#Season</seealso>
    let Season = Prefixed_Name(pext, "Season") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Section</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An area of a document that can be considered a document in itself. Compare with pext:Mention, which is also an area of a document. Imported from the iSIM ontology."</para>
    /// labels<para>"Section"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Section">http://www.ontotext.com/proton/protonext#Section</seealso>
    let Section = Prefixed_Name(pext, "Section") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Senator</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#JobTitle</para>
    ///   <para>"Any Senator, a title of the member of the senat."</para>
    /// labels<para>"Senator"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Senator">http://www.ontotext.com/proton/protonext#Senator</seealso>
    let Senator = Prefixed_Name(pext, "Senator") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Settlement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes a populated place with organisation, like city, village, town"</para>
    /// labels<para>"Settlement"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Settlement">http://www.ontotext.com/proton/protonext#Settlement</seealso>
    let Settlement = Prefixed_Name(pext, "Settlement") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Ship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A vehicle which moves on water."</para>
    /// labels<para>"Ship"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Ship">http://www.ontotext.com/proton/protonext#Ship</seealso>
    let Ship = Prefixed_Name(pext, "Ship") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Shoal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Hazards to surface navigation composed of unconsolidated material. (U.SHSU; U.SHLU)"</para>
    /// labels<para>"Shoal"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Shoal">http://www.ontotext.com/proton/protonext#Shoal</seealso>
    let Shoal = Prefixed_Name(pext, "Shoal") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#ShoppingMall</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Shopping Mall, a building which is a shopping mall"</para>
    /// labels<para>"Shopping Mall"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#ShoppingMall">http://www.ontotext.com/proton/protonext#ShoppingMall</seealso>
    let ShoppingMall = Prefixed_Name(pext, "ShoppingMall") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#SingleAlbum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A representative for a musician album."</para>
    ///   <para>"Any Single Album"</para>
    /// labels<para>"Single"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#SingleAlbum">http://www.ontotext.com/proton/protonext#SingleAlbum</seealso>
    let SingleAlbum = Prefixed_Name(pext, "SingleAlbum") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#SingleSong</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A representative for an album or a musician song."</para>
    /// labels<para>"Single"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#SingleSong">http://www.ontotext.com/proton/protonext#SingleSong</seealso>
    let SingleSong = Prefixed_Name(pext, "SingleSong") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#SingleSongOrAlbum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Single Song and Album"</para>
    /// labels<para>"Single"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#SingleSongOrAlbum">http://www.ontotext.com/proton/protonext#SingleSongOrAlbum</seealso>
    let SingleSongOrAlbum = Prefixed_Name(pext, "SingleSongOrAlbum") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#SiteOfSpecialScientificInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any sites of special scientific interest, a place with scientific value, where some scientific activities or experiments are carried out, or which is observed for scientific reasons."</para>
    /// labels<para>"Site of Special Scientific Interest"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#SiteOfSpecialScientificInterest">http://www.ontotext.com/proton/protonext#SiteOfSpecialScientificInterest</seealso>
    let SiteOfSpecialScientificInterest =
        Prefixed_Name(pext, "SiteOfSpecialScientificInterest") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#SkiArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Ski Area, a mounatain area (usually) where there re ski resorts or one can ski."</para>
    /// labels<para>"Ski Area"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#SkiArea">http://www.ontotext.com/proton/protonext#SkiArea</seealso>
    let SkiArea = Prefixed_Name(pext, "SkiArea") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Skyscraper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Skyscraper, a highrise building, usually in downtown city areas."</para>
    /// labels<para>"Skyscraper"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Skyscraper">http://www.ontotext.com/proton/protonext#Skyscraper</seealso>
    let Skyscraper = Prefixed_Name(pext, "Skyscraper") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#SnookerPlayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Sportsman</para>
    ///   <para>"A profession of a sportsman that plays snooker, which is a billiard derivate. From DBPedia"</para>
    /// labels<para>"Snooker player"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#SnookerPlayer">http://www.ontotext.com/proton/protonext#SnookerPlayer</seealso>
    let SnookerPlayer = Prefixed_Name(pext, "SnookerPlayer") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#SoccerClub</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sport club that organizes the playing of soccer."</para>
    ///   <para>"A soccer (football) team"</para>
    /// labels<para>"Soccer Club"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#SoccerClub">http://www.ontotext.com/proton/protonext#SoccerClub</seealso>
    let SoccerClub = Prefixed_Name(pext, "SoccerClub") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#SoccerLeague</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Soccer league"</para>
    /// labels<para>"Soccer League"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#SoccerLeague">http://www.ontotext.com/proton/protonext#SoccerLeague</seealso>
    let SoccerLeague = Prefixed_Name(pext, "SoccerLeague") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#SoccerManager</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#JobTitle</para>
    ///   <para>"Any soccer manager, the title of a manager of a soccer team."</para>
    /// labels<para>"Soccer Manager"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#SoccerManager">http://www.ontotext.com/proton/protonext#SoccerManager</seealso>
    let SoccerManager = Prefixed_Name(pext, "SoccerManager") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#SoccerPlayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Sportsman</para>
    ///   <para>"The profession of soccer player"</para>
    /// labels<para>"Soccer player"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#SoccerPlayer">http://www.ontotext.com/proton/protonext#SoccerPlayer</seealso>
    let SoccerPlayer = Prefixed_Name(pext, "SoccerPlayer") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#SocialAbstraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any sort of general social phenomenon, such as particular sort of art or science"</para>
    /// labels<para>"Social Abstraction"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#SocialAbstraction">http://www.ontotext.com/proton/protonext#SocialAbstraction</seealso>
    let SocialAbstraction = Prefixed_Name(pext, "SocialAbstraction") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#SocialFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The name of a function a person has in the society like nobely, job title, celebrity, etc."</para>
    /// labels<para>"Social Function"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#SocialFunction">http://www.ontotext.com/proton/protonext#SocialFunction</seealso>
    let SocialFunction = Prefixed_Name(pext, "SocialFunction") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#SoftballLeague</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Softball league"</para>
    /// labels<para>"Softball League"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#SoftballLeague">http://www.ontotext.com/proton/protonext#SoftballLeague</seealso>
    let SoftballLeague = Prefixed_Name(pext, "SoftballLeague") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Software</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Software is a collection of computer programs and related data that provide the instructions telling a computer what to do. (Wikipedia)"</para>
    /// labels<para>"Software"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Software">http://www.ontotext.com/proton/protonext#Software</seealso>
    let Software = Prefixed_Name(pext, "Software") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#SoftwareAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An artificial agent which operates in a software environment."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Software Agent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#SoftwareAgent">http://www.ontotext.com/proton/protonext#SoftwareAgent</seealso>
    let SoftwareAgent = Prefixed_Name(pext, "SoftwareAgent") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Song</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An recording of a song."</para>
    /// labels<para>"Song"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Song">http://www.ontotext.com/proton/protonext#Song</seealso>
    let Song = Prefixed_Name(pext, "Song") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#SpaceMission</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Mission in space in which space shuttles or space crafts are involved."</para>
    /// labels<para>"Space Mission"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#SpaceMission">http://www.ontotext.com/proton/protonext#SpaceMission</seealso>
    let SpaceMission = Prefixed_Name(pext, "SpaceMission") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#SpaceShuttle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Spaceshuttle is a reusable launch system and orbital spacecraft operated by the U.S. National Aeronautics and Space Administration (NASA) (Wikipedia)."</para>
    /// labels<para>"Space Shuttle"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#SpaceShuttle">http://www.ontotext.com/proton/protonext#SpaceShuttle</seealso>
    let SpaceShuttle = Prefixed_Name(pext, "SpaceShuttle") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#SpaceStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Spacestation. A space station (also called an orbital station) is a manned satellite designed to remain in space. (Wikipedia)"</para>
    /// labels<para>"Space Station"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#SpaceStation">http://www.ontotext.com/proton/protonext#SpaceStation</seealso>
    let SpaceStation = Prefixed_Name(pext, "SpaceStation") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Spacecraft</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"[WN1.7] Space vehicle - a craft capable of traveling in outer space; technically a satellite around the sun."</para>
    /// labels<para>"Spacecraft"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Spacecraft">http://www.ontotext.com/proton/protonext#Spacecraft</seealso>
    let Spacecraft = Prefixed_Name(pext, "Spacecraft") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#SpeedwayLeague</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Speedway league"</para>
    /// labels<para>"Speedway League"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#SpeedwayLeague">http://www.ontotext.com/proton/protonext#SpeedwayLeague</seealso>
    let SpeedwayLeague = Prefixed_Name(pext, "SpeedwayLeague") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#SpeedwayTeam</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any speedway team"</para>
    /// labels<para>"Speedway team"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#SpeedwayTeam">http://www.ontotext.com/proton/protonext#SpeedwayTeam</seealso>
    let SpeedwayTeam = Prefixed_Name(pext, "SpeedwayTeam") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Sport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific type of sport game"</para>
    /// labels<para>"Sport"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Sport">http://www.ontotext.com/proton/protonext#Sport</seealso>
    let Sport = Prefixed_Name(pext, "Sport") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#SportBuilding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A building providing facilities for practice of sport(s)."</para>
    /// labels<para>"Sport Building"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#SportBuilding">http://www.ontotext.com/proton/protonext#SportBuilding</seealso>
    let SportBuilding = Prefixed_Name(pext, "SportBuilding") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#SportClub</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sports club, football club or F1 team. Those should be considered commercial although in many cases they are not run for profit."</para>
    ///   <para>"An organization arranging the practice of some sports by teams or individuals."</para>
    /// labels<para>"Sport Club"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#SportClub">http://www.ontotext.com/proton/protonext#SportClub</seealso>
    let SportClub = Prefixed_Name(pext, "SportClub") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#SportEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An event involving use, maintain or improve of physical fitness of its participants. Usually it is organized."</para>
    /// labels<para>"Sport Event"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#SportEvent">http://www.ontotext.com/proton/protonext#SportEvent</seealso>
    let SportEvent = Prefixed_Name(pext, "SportEvent") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#SportFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Fields, centers, or open areas maintained for the purpose of holding sporting events and activities. [USGS Circ 1048] We use this category for aquatic centers; for arenas; for athletic complexes; for athletic fields; for ball parks; for baseball fields; for dragways; for equestrian centers; for fields; for football fields; for golf clubs; for golf courses; for gymnasiums; for natatoriums; for physical education facilities; for pistol ranges (sport); for polo fields; for pools, swimming; for race tracks; for racecourses; for racetracks; for raceways; for rifle ranges; for rodeo grounds; for shooting ranges (sport); for skeet shooting ranges; for ski areas; for ski facilities; for ski trails; for speedways; for stadiums; for swim clubs; for swimming pools; for tennis clubs; and for tennis courts. NIMA GNS designators RECG, RECR, STDM, ATHF."</para>
    /// labels<para>"Sport Facility"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#SportFacility">http://www.ontotext.com/proton/protonext#SportFacility</seealso>
    let SportFacility = Prefixed_Name(pext, "SportFacility") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#SportGame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sport game is any instance of a sport event, where teams or individuals gather to play according to particular predetermined rules, such as soccer match, tennis match, car race, etc. It can also denote the activity of playing a particular sport game."</para>
    /// labels<para>"Sport Game"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#SportGame">http://www.ontotext.com/proton/protonext#SportGame</seealso>
    let SportGame = Prefixed_Name(pext, "SportGame") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#SportGamePoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Denotes a point scored in a given sport game."</para>
    /// labels<para>"Sport Game Point"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#SportGamePoint">http://www.ontotext.com/proton/protonext#SportGamePoint</seealso>
    let SportGamePoint = Prefixed_Name(pext, "SportGamePoint") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#SportOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An organization (local, national or international) which main activity is related to one or more sports. Those could be clubs, as well, as all the sorts of federations."</para>
    /// labels<para>"Sport Organization"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#SportOrganization">http://www.ontotext.com/proton/protonext#SportOrganization</seealso>
    let SportOrganization = Prefixed_Name(pext, "SportOrganization") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#SportsFederation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An organization representing which controls the practice of some sport on national, regional or international level."</para>
    /// labels<para>"Sports Federation"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#SportsFederation">http://www.ontotext.com/proton/protonext#SportsFederation</seealso>
    let SportsFederation = Prefixed_Name(pext, "SportsFederation") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#SportsLeague</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any sports league, a group of sports teams or individual athletes that compete against each other in a specific sport. (Wikipedia)"</para>
    /// labels<para>"Sports League"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#SportsLeague">http://www.ontotext.com/proton/protonext#SportsLeague</seealso>
    let SportsLeague = Prefixed_Name(pext, "SportsLeague") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Sportsman</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A profession of a person involved in a sport."</para>
    /// labels<para>"Sportsman"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Sportsman">http://www.ontotext.com/proton/protonext#Sportsman</seealso>
    let Sportsman = Prefixed_Name(pext, "Sportsman") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Spring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Places where underground water flows naturally to the surface of the Earth. ... We use this category for mineral springs; and for sulfur springs. NIMA GNS designators SPNG, SPNS, SPNT."</para>
    /// labels<para>"Spring"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Spring">http://www.ontotext.com/proton/protonext#Spring</seealso>
    let Spring = Prefixed_Name(pext, "Spring") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Stadium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A special sort of sport building, usually for open-air sports such as soccer."</para>
    /// labels<para>"Stadium"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Stadium">http://www.ontotext.com/proton/protonext#Stadium</seealso>
    let Stadium = Prefixed_Name(pext, "Stadium") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Star</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An astronomic object of hot gases that radiates energy derived from thermonuclear reactions in the interior. Definition partly derived from WordNet 1.7"</para>
    /// labels<para>"Star"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Star">http://www.ontotext.com/proton/protonext#Star</seealso>
    let Star = Prefixed_Name(pext, "Star") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Station</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any station, a place where busses, trains, sheeps, boats, etc. stop, like railway station, bussstop, etc."</para>
    /// labels<para>"Station"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Station">http://www.ontotext.com/proton/protonext#Station</seealso>
    let Station = Prefixed_Name(pext, "Station") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#StockExchange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Stock Exchange where public companies are traded, e. g. Nasdaq, NYSE, etc."</para>
    /// labels<para>"Stock Exchange"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#StockExchange">http://www.ontotext.com/proton/protonext#StockExchange</seealso>
    let StockExchange = Prefixed_Name(pext, "StockExchange") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#StockExchangeIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A stock exchange/market index is a method of measuring a section of the stock market. (Wikipedia)"</para>
    /// labels<para>"Stock Exchange Index"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#StockExchangeIndex">http://www.ontotext.com/proton/protonext#StockExchangeIndex</seealso>
    let StockExchangeIndex = Prefixed_Name(pext, "StockExchangeIndex") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Stream</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Linear bodies of water flowing on the Earth's surface. We use this category for anabranches; for brooks; for burns (hydrographic); for confluences; for creeks; for distributaries; for dry stream beds; for forks (physiographic features); for intermittent streams; for lost rivers; for meanders; for stream bends; for stream mouths; for tidal creeks; for tributaries; and for watercourses. NIMA GNS designators STM, STMA, STMB, STMC, STMD, STMH, STMI, STMIX, STMM, STMQ, STMS, STMSB, STMX"</para>
    /// labels<para>"Stream"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Stream">http://www.ontotext.com/proton/protonext#Stream</seealso>
    let Stream = Prefixed_Name(pext, "Stream") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Street</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The general notion for a roadway within a city or village, often, surrounded by buildings. We put here boulevards, streets, avenues, etc. NIMA GNS designator - missing."</para>
    /// labels<para>"Street"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Street">http://www.ontotext.com/proton/protonext#Street</seealso>
    let Street = Prefixed_Name(pext, "Street") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#StreetName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Part of a postal address denoting the street name."</para>
    /// labels<para>"Street Name"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#StreetName">http://www.ontotext.com/proton/protonext#StreetName</seealso>
    let StreetName = Prefixed_Name(pext, "StreetName") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#StreetNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Part of a postal address denoting the street number."</para>
    /// labels<para>"Street Number"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#StreetNumber">http://www.ontotext.com/proton/protonext#StreetNumber</seealso>
    let StreetNumber = Prefixed_Name(pext, "StreetNumber") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Swimmer</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Sportsman</para>
    ///   <para>"The profession of swimmer"</para>
    /// labels<para>"Swimmer"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Swimmer">http://www.ontotext.com/proton/protonext#Swimmer</seealso>
    let Swimmer = Prefixed_Name(pext, "Swimmer") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#TVChannel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A brand of a television channel."</para>
    /// labels<para>"TV Channel"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#TVChannel">http://www.ontotext.com/proton/protonext#TVChannel</seealso>
    let TVChannel = Prefixed_Name(pext, "TVChannel") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#TVCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A company that broadcasts audio and video content."</para>
    /// labels<para>"TV company"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#TVCompany">http://www.ontotext.com/proton/protonext#TVCompany</seealso>
    let TVCompany = Prefixed_Name(pext, "TVCompany") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Team</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A group of people gathered for some task, say a project. Teams are usually not formally established and not meant to perform as a single agent for purposes outside the scope of their task. Teams may "live" within organizations, spread between multiple organizations, or be independent form any organization."</para>
    /// labels<para>"Team"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Team">http://www.ontotext.com/proton/protonext#Team</seealso>
    let Team = Prefixed_Name(pext, "Team") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Telecom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A telecommunications company"</para>
    /// labels<para>"Telecom"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Telecom">http://www.ontotext.com/proton/protonext#Telecom</seealso>
    let Telecom = Prefixed_Name(pext, "Telecom") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#TelecomFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT: Telecommunication Features) We use this category for antenna field sites; for communication centers; for radio stations; for television stations; and for transmission lines. NIMA GNS designators COMC, STNR, STNS."</para>
    /// labels<para>"Telecom Facility"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#TelecomFacility">http://www.ontotext.com/proton/protonext#TelecomFacility</seealso>
    let TelecomFacility = Prefixed_Name(pext, "TelecomFacility") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#TelevisionEpisode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Denotes any episod of any television series."</para>
    /// labels<para>"Television Episode"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#TelevisionEpisode">http://www.ontotext.com/proton/protonext#TelevisionEpisode</seealso>
    let TelevisionEpisode = Prefixed_Name(pext, "TelevisionEpisode") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#TelevisionProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Denotes programms produced in the television and for television airing."</para>
    /// labels<para>"Television Product"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#TelevisionProduct">http://www.ontotext.com/proton/protonext#TelevisionProduct</seealso>
    let TelevisionProduct = Prefixed_Name(pext, "TelevisionProduct") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#TelevisionShow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any television show"</para>
    /// labels<para>"Television Show"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#TelevisionShow">http://www.ontotext.com/proton/protonext#TelevisionShow</seealso>
    let TelevisionShow = Prefixed_Name(pext, "TelevisionShow") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#TemporalAbstraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any sort of abstraction used to refer to specific periods of time. Thus, the month of September is an instance of this class, while Sept 1989 is not (it is a specific TimeInterval, and thus not abstract)"</para>
    /// labels<para>"Temporal Abstraction"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#TemporalAbstraction">http://www.ontotext.com/proton/protonext#TemporalAbstraction</seealso>
    let TemporalAbstraction = Prefixed_Name(pext, "TemporalAbstraction") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#TennisLeague</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Tennis league"</para>
    /// labels<para>"Tennis League"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#TennisLeague">http://www.ontotext.com/proton/protonext#TennisLeague</seealso>
    let TennisLeague = Prefixed_Name(pext, "TennisLeague") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#TennisPlayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Sportsman</para>
    ///   <para>"The profession of tennis player"</para>
    /// labels<para>"Tennis player"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#TennisPlayer">http://www.ontotext.com/proton/protonext#TennisPlayer</seealso>
    let TennisPlayer = Prefixed_Name(pext, "TennisPlayer") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Territory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Territory a region of land which can be a part of contry that is non-sovereign or a geographic region determined by some charateristics. (Wikipedia) (http://www.eionet.europa.eu/gemet/concept?ns=1&amp;cp=8401. NIMA GNS designator A.TERR."</para>
    /// labels<para>"Territory"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Territory">http://www.ontotext.com/proton/protonext#Territory</seealso>
    let Territory = Prefixed_Name(pext, "Territory") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#TheatrePerformance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An art performance following a stage play."</para>
    /// labels<para>"Theatre Performance"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#TheatrePerformance">http://www.ontotext.com/proton/protonext#TheatrePerformance</seealso>
    let TheatrePerformance = Prefixed_Name(pext, "TheatrePerformance") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#TimeZone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A time zone is a region on Earth that has a uniform standard time for legal, commercial, and social purposes. Wikipedia."</para>
    /// labels<para>"Time Zone"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#TimeZone">http://www.ontotext.com/proton/protonext#TimeZone</seealso>
    let TimeZone = Prefixed_Name(pext, "TimeZone") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Tournament</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Tournament which is held regularly at particular time intervals, every year, every week, etc."</para>
    /// labels<para>"Tournament"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Tournament">http://www.ontotext.com/proton/protonext#Tournament</seealso>
    let Tournament = Prefixed_Name(pext, "Tournament") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#TournamentOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Tournament held at a particular time"</para>
    /// labels<para>"Tournament"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#TournamentOccurrence">http://www.ontotext.com/proton/protonext#TournamentOccurrence</seealso>
    let TournamentOccurrence =
        Prefixed_Name(pext, "TournamentOccurrence") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#Tower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Manmade structures, higher than their diameter, generally used for observation, storage, or electronic transmission. We use this category for carillons; for fire lookouts; and for pagodas. NIMA GNS designator TOWR."</para>
    /// labels<para>"Tower"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Tower">http://www.ontotext.com/proton/protonext#Tower</seealso>
    let Tower = Prefixed_Name(pext, "Tower") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Town</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any town"</para>
    /// labels<para>"Town"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Town">http://www.ontotext.com/proton/protonext#Town</seealso>
    let Town = Prefixed_Name(pext, "Town") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#TradeUnion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Trade Union, an organization of workers that have banded together to achieve common goals such as better working conditions. (Wikipedia)"</para>
    /// labels<para>"Trade Union"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#TradeUnion">http://www.ontotext.com/proton/protonext#TradeUnion</seealso>
    let TradeUnion = Prefixed_Name(pext, "TradeUnion") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#TransportFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT: Transportation Features) We use this category for air routes; for caravan routes; for corridors; for crossings; for depots; for ferries; for fords (crossings); for fuel depots; for gates (manmade); for halting places (transportation); for highway maintenance sites; for portages; for rest houses; for routes; for ship tracks; for stock routes; for terminals (transportation); and for transit facilities. Omitted sub-classes: Aqueducts, Cableways, Parking Sites. NIMA GNS designator - no direct equivalents."</para>
    /// labels<para>"Transport Facility"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#TransportFacility">http://www.ontotext.com/proton/protonext#TransportFacility</seealso>
    let TransportFacility = Prefixed_Name(pext, "TransportFacility") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Tundra</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Treeless, level, or gently rolling plains characteristic of arctic or subarctic regions, having a permanently frozen subsoil, and usually supporting low growing vegetation such as lichens, mosses, and stunted shrubs. [USGS Circ 1048] We use this category for Arctic land. NIMA GNS designator TUND, LAND."</para>
    /// labels<para>"Tundra"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Tundra">http://www.ontotext.com/proton/protonext#Tundra</seealso>
    let Tundra = Prefixed_Name(pext, "Tundra") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Tunnel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Underground or underwater passages. [USGS Circ 1048] We use this category for canal tunnels; for railroad tunnels; and for road tunnels. NIMA GNS designator TNL, TNLC, TNLN, TNLRD, TNLS"</para>
    /// labels<para>"Tunnel"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Tunnel">http://www.ontotext.com/proton/protonext#Tunnel</seealso>
    let Tunnel = Prefixed_Name(pext, "Tunnel") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#University</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An educational organization higher than school."</para>
    /// labels<para>"University"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#University">http://www.ontotext.com/proton/protonext#University</seealso>
    let University = Prefixed_Name(pext, "University") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#UrbanDistrict</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT: Countries, 3rd order divisions) Minor civil units. [USGS Circ 1048] We use this category for barrios; for precincts; for third-order administrative divisions; and for townships. NIMA GNS designator ADM3."</para>
    /// labels<para>"Urban District"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#UrbanDistrict">http://www.ontotext.com/proton/protonext#UrbanDistrict</seealso>
    let UrbanDistrict = Prefixed_Name(pext, "UrbanDistrict") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#User</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"User"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#User">http://www.ontotext.com/proton/protonext#User</seealso>
    let User = Prefixed_Name(pext, "User") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#UserProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"User Profile"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#UserProfile">http://www.ontotext.com/proton/protonext#UserProfile</seealso>
    let UserProfile = Prefixed_Name(pext, "UserProfile") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Valley</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Low-lying land bordered by higher ground; especially elongate, relatively large gently sloping depressions of the Earth's surface, commonly situated between two mountains or between ranges of hills or mountains, and often containing a stream with an outlet. [Glossary of Geology, 4th ed.] We use this category for forks (physiographic features); for glens; for hanging valleys; for hollows; for median valleys; and for shelf valleys (seafloor). NIMA GNS designators VAL, VALG, VALU, VALS, VALX, VLSU, FRKU, FRSU, MDVU, SHVU."</para>
    /// labels<para>"Valley"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Valley">http://www.ontotext.com/proton/protonext#Valley</seealso>
    let Valley = Prefixed_Name(pext, "Valley") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Vehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any sort of specific vehicle, mean of transportation."</para>
    /// labels<para>"Vehicle"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Vehicle">http://www.ontotext.com/proton/protonext#Vehicle</seealso>
    let Vehicle = Prefixed_Name(pext, "Vehicle") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Vein</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Vein is a general concept gathering all veins of a body."</para>
    /// labels<para>"Vein"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Vein">http://www.ontotext.com/proton/protonext#Vein</seealso>
    let Vein = Prefixed_Name(pext, "Vein") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#VicePresident</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#JobTitle</para>
    ///   <para>"Any Vice President, the title of a vice president in a country or in an organization."</para>
    /// labels<para>"Vice President"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#VicePresident">http://www.ontotext.com/proton/protonext#VicePresident</seealso>
    let VicePresident = Prefixed_Name(pext, "VicePresident") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#VicePrimeMinister</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#JobTitle</para>
    ///   <para>"Any Vice Prime Minister, the title of a vice prime minister in a country."</para>
    /// labels<para>"Vice Prime Minister"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#VicePrimeMinister">http://www.ontotext.com/proton/protonext#VicePrimeMinister</seealso>
    let VicePrimeMinister = Prefixed_Name(pext, "VicePrimeMinister") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#VideoGame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any electronic game that involves interaction with a user interface to generate visual feedback on a video device. (Wikipedia)"</para>
    /// labels<para>"Video Game"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#VideoGame">http://www.ontotext.com/proton/protonext#VideoGame</seealso>
    let VideoGame = Prefixed_Name(pext, "VideoGame") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#VideogamesLeague</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Videogames league"</para>
    /// labels<para>"Videogames League"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#VideogamesLeague">http://www.ontotext.com/proton/protonext#VideogamesLeague</seealso>
    let VideogamesLeague = Prefixed_Name(pext, "VideogamesLeague") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Village</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any village"</para>
    /// labels<para>"Village"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Village">http://www.ontotext.com/proton/protonext#Village</seealso>
    let Village = Prefixed_Name(pext, "Village") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Vineyard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Plantings of grapevines"</para>
    /// labels<para>"Vineyard"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Vineyard">http://www.ontotext.com/proton/protonext#Vineyard</seealso>
    let Vineyard = Prefixed_Name(pext, "Vineyard") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Volcano</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Vents in the surface of the Earth through which magma and associated gases erupt; also, the forms or structures, usually conical, that are produced by the erupted material. NIMA GNS designator VLC."</para>
    /// labels<para>"Volcano"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Volcano">http://www.ontotext.com/proton/protonext#Volcano</seealso>
    let Volcano = Prefixed_Name(pext, "Volcano") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#VolleyballLeague</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Volleyball league"</para>
    /// labels<para>"Volleyball League"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#VolleyballLeague">http://www.ontotext.com/proton/protonext#VolleyballLeague</seealso>
    let VolleyballLeague = Prefixed_Name(pext, "VolleyballLeague") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#VolleyballPlayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Sportsman</para>
    ///   <para>"A profession of a volleyball player."</para>
    /// labels<para>"Snooker player"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#VolleyballPlayer">http://www.ontotext.com/proton/protonext#VolleyballPlayer</seealso>
    let VolleyballPlayer = Prefixed_Name(pext, "VolleyballPlayer") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Wadi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A valley or ravine, bounded by relatively steep banks. NIMA GNS designator H.WAD, H.WADB, H.WADJ, H.WADM, H.WADS, H.WADX."</para>
    /// labels<para>"Wadi"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Wadi">http://www.ontotext.com/proton/protonext#Wadi</seealso>
    let Wadi = Prefixed_Name(pext, "Wadi") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#WaterBank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT: Banks) Sloping margins of, or the ground bordering, a stream, and serving to confine the water to the natural channel during the normal course of flow. [Glossary of Geology, 4th ed.] We use this category for stream banks. NIMA GNS designator BKSU, BNK, BNKR, BNKU, BNKX."</para>
    /// labels<para>"Water Bank"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#WaterBank">http://www.ontotext.com/proton/protonext#WaterBank</seealso>
    let WaterBank = Prefixed_Name(pext, "WaterBank") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#WaterCurrent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A net transport of ocean water along a definable path. http://www.eionet.europa.eu/gemet/concept/5792 NIMA GNS designator H.CRNT."</para>
    /// labels<para>"Current"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#WaterCurrent">http://www.ontotext.com/proton/protonext#WaterCurrent</seealso>
    let WaterCurrent = Prefixed_Name(pext, "WaterCurrent") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#WaterReach</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A straight section of a navigable stream or channel between two bends. NIMA GNS designator H.RCH."</para>
    /// labels<para>"Reach"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#WaterReach">http://www.ontotext.com/proton/protonext#WaterReach</seealso>
    let WaterReach = Prefixed_Name(pext, "WaterReach") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#WaterRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT: Hydrographic Features) For natural bodies of water. For constructed waterways, reservoirs, and such, use 'hydrographic structures'. We use this category for bodies of water; for eddies; for fluvial features; for marine features; for overfalls; for upwellings; for water bodies; for waterholes; and for whirlpools. Many of the ADL hydrographic features ignored. NIMA GNS class H."</para>
    /// labels<para>"Water Region"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#WaterRegion">http://www.ontotext.com/proton/protonext#WaterRegion</seealso>
    let WaterRegion = Prefixed_Name(pext, "WaterRegion") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#WaterTank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A contained pool or tank of water at, below, or above ground level. NIMA GNS designator H.RSVT."</para>
    /// labels<para>"Water Tank"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#WaterTank">http://www.ontotext.com/proton/protonext#WaterTank</seealso>
    let WaterTank = Prefixed_Name(pext, "WaterTank") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Watercourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A natural, well-defined channel produced by flowing water, or an artificial channel designed to carry flowing water. NIMA GNS designator H.WTRC."</para>
    /// labels<para>"Watercourse"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Watercourse">http://www.ontotext.com/proton/protonext#Watercourse</seealso>
    let Watercourse = Prefixed_Name(pext, "Watercourse") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Waterfalls</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(ADL FT) Perpendicular or very steep falls of water in the course of a stream. ... We use this category for cascades; for cataracts; and for falls. NIMA GNS designator FLLS, FLLSX"</para>
    /// labels<para>"Waterfalls"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Waterfalls">http://www.ontotext.com/proton/protonext#Waterfalls</seealso>
    let Waterfalls = Prefixed_Name(pext, "Waterfalls") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Waterhole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A natural hole, hollow, or small depression that contains water, used by man and animals, especially in arid areas. NIMA GNS designator H.WTRH."</para>
    /// labels<para>"Waterhole"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Waterhole">http://www.ontotext.com/proton/protonext#Waterhole</seealso>
    let Waterhole = Prefixed_Name(pext, "Waterhole") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#WeaponModelOrSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A concrete model of a weapon that determines its main features. For example, Patriot, SU-28, and Kalashnikov."</para>
    /// labels<para>"Weapon Model or System"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#WeaponModelOrSystem">http://www.ontotext.com/proton/protonext#WeaponModelOrSystem</seealso>
    let WeaponModelOrSystem = Prefixed_Name(pext, "WeaponModelOrSystem") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#WebPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The internet address of a web page on the net."</para>
    /// labels<para>"Web Page"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#WebPage">http://www.ontotext.com/proton/protonext#WebPage</seealso>
    let WebPage = Prefixed_Name(pext, "WebPage") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Week</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specific week of a specific year (say the 41st of 2001)"</para>
    /// labels<para>"Week"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Week">http://www.ontotext.com/proton/protonext#Week</seealso>
    let Week = Prefixed_Name(pext, "Week") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Well</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A cylindrical hole, pit, or tunnel drilled or dug down to a depth from which water, oil, or gas can be pumped or brought to the surface. NIMA GNS designator H.WLL, H.WLLQ, H.WLLS."</para>
    /// labels<para>"Well"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Well">http://www.ontotext.com/proton/protonext#Well</seealso>
    let Well = Prefixed_Name(pext, "Well") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Whirlpool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A turbulent, rotating movement of water in a stream. NIMA GNS designator H.WHRL."</para>
    /// labels<para>"Whirlpool"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Whirlpool">http://www.ontotext.com/proton/protonext#Whirlpool</seealso>
    let Whirlpool = Prefixed_Name(pext, "Whirlpool") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#WineRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Wine Region, a region where wine is produced."</para>
    /// labels<para>"Wine Region"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#WineRegion">http://www.ontotext.com/proton/protonext#WineRegion</seealso>
    let WineRegion = Prefixed_Name(pext, "WineRegion") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Woman</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A female human."</para>
    /// labels<para>"Woman"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Woman">http://www.ontotext.com/proton/protonext#Woman</seealso>
    let Woman = Prefixed_Name(pext, "Woman") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#WorldHeritageSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any world heritage site, a old site with historic value of world magnitude to be preserved."</para>
    /// labels<para>"World Heritage Site"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#WorldHeritageSite">http://www.ontotext.com/proton/protonext#WorldHeritageSite</seealso>
    let WorldHeritageSite = Prefixed_Name(pext, "WorldHeritageSite") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Wrestler</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#Sportsman</para>
    ///   <para>"The profession of wrestler"</para>
    /// labels<para>"Wrestler"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Wrestler">http://www.ontotext.com/proton/protonext#Wrestler</seealso>
    let Wrestler = Prefixed_Name(pext, "Wrestler") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Writer</para>
    /// </summary>
    /// <remarks>
    ///   <para>onto:proton/protonext#ArtProfession</para>
    ///   <para>"Any writer, a profession of producing literary content. (Wikipedia)"</para>
    /// labels<para>"Writer"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Writer">http://www.ontotext.com/proton/protonext#Writer</seealso>
    let Writer = Prefixed_Name(pext, "Writer") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#ZipCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Part of a postal address denoting the zip code."</para>
    /// labels<para>"ZipCode"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#ZipCode">http://www.ontotext.com/proton/protonext#ZipCode</seealso>
    let ZipCode = Prefixed_Name(pext, "ZipCode") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#Zone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A land region defined to play a role. For example, a buffer between two nations in which military presence is minimal or absent or zone around the site of the Chernobyl disaster to protect people from radiation. (NIMA GNS designator A.ZN, A.ZNB."</para>
    /// labels<para>"Zone"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#Zone">http://www.ontotext.com/proton/protonext#Zone</seealso>
    let Zone = Prefixed_Name(pext, "Zone") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#accountProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between an account and an agent (usually organization) providing and managing it"</para>
    /// labels<para>"Account Provider"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#accountProvider">http://www.ontotext.com/proton/protonext#accountProvider</seealso>
    let accountProvider = Prefixed_Name(pext, "accountProvider") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#acquired</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The participant of an acquirement event which became a property of another participant in this event."</para>
    /// labels<para>"Acquired"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#acquired">http://www.ontotext.com/proton/protonext#acquired</seealso>
    let acquired = Prefixed_Name(pext, "acquired") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#acquirer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The participant of an acquirement event which became an owner of another participant in this event."</para>
    /// labels<para>"Acquirer"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#acquirer">http://www.ontotext.com/proton/protonext#acquirer</seealso>
    let acquirer = Prefixed_Name(pext, "acquirer") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#activeInSector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes that the organization is active within the industry sector"</para>
    /// labels<para>"Active in Sector"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#activeInSector">http://www.ontotext.com/proton/protonext#activeInSector</seealso>
    let activeInSector = Prefixed_Name(pext, "activeInSector") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#appointedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A concrete job position appointed by a given person."</para>
    /// labels<para>"Appointed by"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#appointedBy">http://www.ontotext.com/proton/protonext#appointedBy</seealso>
    let appointedBy = Prefixed_Name(pext, "appointedBy") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#appointmentFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A concrete job position which is assigned to the position available in a given organization."</para>
    /// labels<para>"Posision"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#appointmentFor">http://www.ontotext.com/proton/protonext#appointmentFor</seealso>
    let appointmentFor = Prefixed_Name(pext, "appointmentFor") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#architect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a facility and its architect."</para>
    /// labels<para>"Architect"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#architect">http://www.ontotext.com/proton/protonext#architect</seealso>
    let architect = Prefixed_Name(pext, "architect") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#authorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Any author of a product. Links any object to its author (producer)."</para>
    /// labels<para>"Author"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#authorOf">http://www.ontotext.com/proton/protonext#authorOf</seealso>
    let authorOf = Prefixed_Name(pext, "authorOf") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#birthDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The relation between a person and the date he/she is born."</para>
    /// labels<para>"Birthday"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#birthDate">http://www.ontotext.com/proton/protonext#birthDate</seealso>
    let birthDate = Prefixed_Name(pext, "birthDate") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#birthPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a person and the place he/she is born."</para>
    /// labels<para>"Place of Birth"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#birthPlace">http://www.ontotext.com/proton/protonext#birthPlace</seealso>
    let birthPlace = Prefixed_Name(pext, "birthPlace") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#carAssemblyIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a car model and the country it is assembled in."</para>
    /// labels<para>"Car Assembly in"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#carAssemblyIn">http://www.ontotext.com/proton/protonext#carAssemblyIn</seealso>
    let carAssemblyIn = Prefixed_Name(pext, "carAssemblyIn") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#causeOfDeath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Any cause of death."</para>
    /// labels<para>"Cause of a Death"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#causeOfDeath">http://www.ontotext.com/proton/protonext#causeOfDeath</seealso>
    let causeOfDeath = Prefixed_Name(pext, "causeOfDeath") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#combatantFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"the relation between a military unit and the organization it represents in a military conflict."</para>
    /// labels<para>"Combatant from"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#combatantFrom">http://www.ontotext.com/proton/protonext#combatantFrom</seealso>
    let combatantFrom = Prefixed_Name(pext, "combatantFrom") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#compliantWithSchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"It links a dataset with a schema it complies to."</para>
    /// labels<para>"Compliant with Schema"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#compliantWithSchema">http://www.ontotext.com/proton/protonext#compliantWithSchema</seealso>
    let compliantWithSchema = Prefixed_Name(pext, "compliantWithSchema") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#conflictCombatant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a military organization, which participates as a combatant in a military conflict"</para>
    /// labels<para>"Combatant"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#conflictCombatant">http://www.ontotext.com/proton/protonext#conflictCombatant</seealso>
    let conflictCombatant = Prefixed_Name(pext, "conflictCombatant") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#containsLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"The relation between a location and another location that is contained by the first one."</para>
    ///   <para>"Relation between two locations where the first contains the other."</para>
    /// labels<para>"Contains a Location"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#containsLocation">http://www.ontotext.com/proton/protonext#containsLocation</seealso>
    let containsLocation = Prefixed_Name(pext, "containsLocation") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#currentFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The relation between a recurring event and its frequency."</para>
    /// labels<para>"Current Frequency"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#currentFrequency">http://www.ontotext.com/proton/protonext#currentFrequency</seealso>
    let currentFrequency = Prefixed_Name(pext, "currentFrequency") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#datePublished</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Typically, associated with the creation or availability of the resource. Recommended best practice for encoding the date value is defined in a profile of ISO 8601 [W3CDTF] and includes (among others) dates of the form YYYY-MM-DD. This date is related to an event of publishing which here is implicit. If necessary for the task it can be made explicit in an extension of the ontology."</para>
    /// labels<para>"Date Published"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#datePublished">http://www.ontotext.com/proton/protonext#datePublished</seealso>
    let datePublished = Prefixed_Name(pext, "datePublished") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#deathDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The relation between a person and the date he/she died."</para>
    /// labels<para>"Deathday"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#deathDate">http://www.ontotext.com/proton/protonext#deathDate</seealso>
    let deathDate = Prefixed_Name(pext, "deathDate") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#deathPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a person and the place he/she died."</para>
    /// labels<para>"Place of Death"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#deathPlace">http://www.ontotext.com/proton/protonext#deathPlace</seealso>
    let deathPlace = Prefixed_Name(pext, "deathPlace") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#designerOfFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Any author of engineering and architecture designs. The relation between an author and the facility he has designed."</para>
    /// labels<para>"Designer"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#designerOfFacility">http://www.ontotext.com/proton/protonext#designerOfFacility</seealso>
    let designerOfFacility = Prefixed_Name(pext, "designerOfFacility") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#districtRepresented</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"the relation between an official position, usually political and the location it represents. The district represented by an official position, usually political."</para>
    /// labels<para>"Represented District"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#districtRepresented">http://www.ontotext.com/proton/protonext#districtRepresented</seealso>
    let districtRepresented = Prefixed_Name(pext, "districtRepresented") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#finalOccuranceDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The date of the last occurrence of a recurring event."</para>
    /// labels<para>"Date of Last Occurance"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#finalOccuranceDate">http://www.ontotext.com/proton/protonext#finalOccuranceDate</seealso>
    let finalOccuranceDate = Prefixed_Name(pext, "finalOccuranceDate") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#firstOccuranceDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The date of the first occurrence of a recurring event."</para>
    /// labels<para>"Date of First Occurance"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#firstOccuranceDate">http://www.ontotext.com/proton/protonext#firstOccuranceDate</seealso>
    let firstOccuranceDate = Prefixed_Name(pext, "firstOccuranceDate") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#fiscalNetIncome</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Net Income last year."</para>
    /// labels<para>"fiscal net income"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#fiscalNetIncome">http://www.ontotext.com/proton/protonext#fiscalNetIncome</seealso>
    let fiscalNetIncome = Prefixed_Name(pext, "fiscalNetIncome") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#fiscalSales</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Sales last year."</para>
    /// labels<para>"fiscal sales"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#fiscalSales">http://www.ontotext.com/proton/protonext#fiscalSales</seealso>
    let fiscalSales = Prefixed_Name(pext, "fiscalSales") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#genreOfAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between an agent and the genre he is occupied in."</para>
    /// labels<para>"Genre Of"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#genreOfAgent">http://www.ontotext.com/proton/protonext#genreOfAgent</seealso>
    let genreOfAgent = Prefixed_Name(pext, "genreOfAgent") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates address to an agent. Will be used for URL, email and other addresses."</para>
    /// labels<para>"has Address"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasAddress">http://www.ontotext.com/proton/protonext#hasAddress</seealso>
    let hasAddress = Prefixed_Name(pext, "hasAddress") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasAirport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between a city and an airport near to the city."</para>
    /// labels<para>"has Airport"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasAirport">http://www.ontotext.com/proton/protonext#hasAirport</seealso>
    let hasAirport = Prefixed_Name(pext, "hasAirport") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasBottomOffset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has Bottom Offset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasBottomOffset">http://www.ontotext.com/proton/protonext#hasBottomOffset</seealso>
    let hasBottomOffset = Prefixed_Name(pext, "hasBottomOffset") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasBrother</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a person and his/her brother."</para>
    /// labels<para>"has Brother"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasBrother">http://www.ontotext.com/proton/protonext#hasBrother</seealso>
    let hasBrother = Prefixed_Name(pext, "hasBrother") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasCapabilities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasCapabilities"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasCapabilities">http://www.ontotext.com/proton/protonext#hasCapabilities</seealso>
    let hasCapabilities = Prefixed_Name(pext, "hasCapabilities") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasCapital</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has Capital"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasCapital">http://www.ontotext.com/proton/protonext#hasCapital</seealso>
    let hasCapital = Prefixed_Name(pext, "hasCapital") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasCelebrityTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between the status of celebrity and its celebrity title of notoriety in the society."</para>
    /// labels<para>"has Celebrity Title"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasCelebrityTitle">http://www.ontotext.com/proton/protonext#hasCelebrityTitle</seealso>
    let hasCelebrityTitle = Prefixed_Name(pext, "hasCelebrityTitle") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasClericTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a Cleric and its cleric title, like Bishop, Pole, etc."</para>
    /// labels<para>"has Cleric Title"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasClericTitle">http://www.ontotext.com/proton/protonext#hasClericTitle</seealso>
    let hasClericTitle = Prefixed_Name(pext, "hasClericTitle") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Denotes that the Sector has the specified SIC code"</para>
    /// labels<para>"has Code"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasCode">http://www.ontotext.com/proton/protonext#hasCode</seealso>
    let hasCode = Prefixed_Name(pext, "hasCode") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasCommander</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a military unit and the person who commands it."</para>
    /// labels<para>"Commander"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasCommander">http://www.ontotext.com/proton/protonext#hasCommander</seealso>
    let hasCommander = Prefixed_Name(pext, "hasCommander") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasCurrency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between a country and the currency used within the country"</para>
    /// labels<para>"has Currency"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasCurrency">http://www.ontotext.com/proton/protonext#hasCurrency</seealso>
    let hasCurrency = Prefixed_Name(pext, "hasCurrency") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasDaughter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a person and his/her daughter."</para>
    /// labels<para>"has Daughter"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasDaughter">http://www.ontotext.com/proton/protonext#hasDaughter</seealso>
    let hasDaughter = Prefixed_Name(pext, "hasDaughter") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasDevice"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasDevice">http://www.ontotext.com/proton/protonext#hasDevice</seealso>
    let hasDevice = Prefixed_Name(pext, "hasDevice") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasEMail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates an object (usually a person) to its email."</para>
    /// labels<para>"has E-mail"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasEMail">http://www.ontotext.com/proton/protonext#hasEMail</seealso>
    let hasEMail = Prefixed_Name(pext, "hasEMail") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasEndOffset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasEndOffset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasEndOffset">http://www.ontotext.com/proton/protonext#hasEndOffset</seealso>
    let hasEndOffset = Prefixed_Name(pext, "hasEndOffset") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasFather</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a person and his/her father."</para>
    /// labels<para>"has Father"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasFather">http://www.ontotext.com/proton/protonext#hasFather</seealso>
    let hasFather = Prefixed_Name(pext, "hasFather") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasFax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates an object (usually an organization) to its fax number."</para>
    /// labels<para>"has Fax"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasFax">http://www.ontotext.com/proton/protonext#hasFax</seealso>
    let hasFax = Prefixed_Name(pext, "hasFax") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between a country and its government"</para>
    /// labels<para>"has Government"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasGovernment">http://www.ontotext.com/proton/protonext#hasGovernment</seealso>
    let hasGovernment = Prefixed_Name(pext, "hasGovernment") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasHusband</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a woman to her spouse."</para>
    /// labels<para>"has Husband"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasHusband">http://www.ontotext.com/proton/protonext#hasHusband</seealso>
    let hasHusband = Prefixed_Name(pext, "hasHusband") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasISProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"a relation between an Information Space and its Profile"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasISProfile"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasISProfile">http://www.ontotext.com/proton/protonext#hasISProfile</seealso>
    let hasISProfile = Prefixed_Name(pext, "hasISProfile") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasInternetAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates an object to its internet address."</para>
    /// labels<para>"has Internet Address"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasInternetAddress">http://www.ontotext.com/proton/protonext#hasInternetAddress</seealso>
    let hasInternetAddress = Prefixed_Name(pext, "hasInternetAddress") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasLeftOffset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has Left Offset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasLeftOffset">http://www.ontotext.com/proton/protonext#hasLeftOffset</seealso>
    let hasLeftOffset = Prefixed_Name(pext, "hasLeftOffset") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasLocation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasLocation">http://www.ontotext.com/proton/protonext#hasLocation</seealso>
    let hasLocation = Prefixed_Name(pext, "hasLocation") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasMinister</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a minister and his/her ministry."</para>
    /// labels<para>"has Minister"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasMinister">http://www.ontotext.com/proton/protonext#hasMinister</seealso>
    let hasMinister = Prefixed_Name(pext, "hasMinister") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasMobilePhone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates an object (usually a person) to its mobile phone number."</para>
    /// labels<para>"has Mobile Phone"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasMobilePhone">http://www.ontotext.com/proton/protonext#hasMobilePhone</seealso>
    let hasMobilePhone = Prefixed_Name(pext, "hasMobilePhone") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasMother</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a person to his/her mother."</para>
    /// labels<para>"has Mother"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasMother">http://www.ontotext.com/proton/protonext#hasMother</seealso>
    let hasMother = Prefixed_Name(pext, "hasMother") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasNobeltyTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between the social position and the social title of nobelty."</para>
    /// labels<para>"has Nobetlty Title"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasNobeltyTitle">http://www.ontotext.com/proton/protonext#hasNobeltyTitle</seealso>
    let hasNobeltyTitle = Prefixed_Name(pext, "hasNobeltyTitle") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasOutOfLawsTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between the status of a criminal, and title, for instance a prisoner."</para>
    /// labels<para>"has OutOfLaws Title"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasOutOfLawsTitle">http://www.ontotext.com/proton/protonext#hasOutOfLawsTitle</seealso>
    let hasOutOfLawsTitle = Prefixed_Name(pext, "hasOutOfLawsTitle") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasPhone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates an object (usually a person or an organization) to its telephone number."</para>
    /// labels<para>"has Phone"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasPhone">http://www.ontotext.com/proton/protonext#hasPhone</seealso>
    let hasPhone = Prefixed_Name(pext, "hasPhone") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a given sport game event and a point scored in it."</para>
    /// labels<para>"Point Scorred in a Sport Game"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasPoint">http://www.ontotext.com/proton/protonext#hasPoint</seealso>
    let hasPoint = Prefixed_Name(pext, "hasPoint") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasPrimeMinister</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a government and its head."</para>
    /// labels<para>"has Prime Minister"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasPrimeMinister">http://www.ontotext.com/proton/protonext#hasPrimeMinister</seealso>
    let hasPrimeMinister = Prefixed_Name(pext, "hasPrimeMinister") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasProfession</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between a person and his/her profession."</para>
    /// labels<para>"has Profession"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasProfession">http://www.ontotext.com/proton/protonext#hasProfession</seealso>
    let hasProfession = Prefixed_Name(pext, "hasProfession") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasPublisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An entity responsible for making the resource available. Examples of Publisher include a person, an organization, or a service. (DC2003ISO)"</para>
    /// labels<para>"has Publisher"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasPublisher">http://www.ontotext.com/proton/protonext#hasPublisher</seealso>
    let hasPublisher = Prefixed_Name(pext, "hasPublisher") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#hasRecurringEventInstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a particular event as an element of a recurring event."</para>
    /// labels<para>"Recurring Event Instance"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasRecurringEventInstance">http://www.ontotext.com/proton/protonext#hasRecurringEventInstance</seealso>
    let hasRecurringEventInstance =
        Prefixed_Name(pext, "hasRecurringEventInstance") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#hasRightOffset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has Right Offset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasRightOffset">http://www.ontotext.com/proton/protonext#hasRightOffset</seealso>
    let hasRightOffset = Prefixed_Name(pext, "hasRightOffset") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a happening with some of the roles in it"</para>
    /// labels<para>"has role"</para><para>"hasRole"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasRole">http://www.ontotext.com/proton/protonext#hasRole</seealso>
    let hasRole = Prefixed_Name(pext, "hasRole") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Natural relation between documents and sections. Imported from the iSIM ontology."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has Section"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasSection">http://www.ontotext.com/proton/protonext#hasSection</seealso>
    let hasSection = Prefixed_Name(pext, "hasSection") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasShareholder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between a commercial organization and a person that owns shares of the organization."</para>
    /// labels<para>"has shareholder"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasShareholder">http://www.ontotext.com/proton/protonext#hasShareholder</seealso>
    let hasShareholder = Prefixed_Name(pext, "hasShareholder") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasSister</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a person to his/her sister."</para>
    /// labels<para>"has Sister"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasSister">http://www.ontotext.com/proton/protonext#hasSister</seealso>
    let hasSister = Prefixed_Name(pext, "hasSister") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#hasSocialFunctionTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Generic property relating a Social Position to its name defined as an instance of a sub-class of pext:SocialFunction"</para>
    /// labels<para>"has Title"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasSocialFunctionTitle">http://www.ontotext.com/proton/protonext#hasSocialFunctionTitle</seealso>
    let hasSocialFunctionTitle =
        Prefixed_Name(pext, "hasSocialFunctionTitle") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#hasSocialPositionCelebrity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a person and the social position of Celebrity he has."</para>
    /// labels<para>"has Social Position Celebrity"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasSocialPositionCelebrity">http://www.ontotext.com/proton/protonext#hasSocialPositionCelebrity</seealso>
    let hasSocialPositionCelebrity =
        Prefixed_Name(pext, "hasSocialPositionCelebrity") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#hasSocialPositionCleric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a person and the social position of Cleric he has."</para>
    /// labels<para>"has Social Position Cleric"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasSocialPositionCleric">http://www.ontotext.com/proton/protonext#hasSocialPositionCleric</seealso>
    let hasSocialPositionCleric =
        Prefixed_Name(pext, "hasSocialPositionCleric") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#hasSocialPositionNobelty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a person and the social position of Nobelty he has."</para>
    /// labels<para>"has Social Position Nobelty"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasSocialPositionNobelty">http://www.ontotext.com/proton/protonext#hasSocialPositionNobelty</seealso>
    let hasSocialPositionNobelty =
        Prefixed_Name(pext, "hasSocialPositionNobelty") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#hasSocialPositionOutOfLaws</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a person and the social position of OutOfLaws he has."</para>
    /// labels<para>"has Social Position OutOfLaws"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasSocialPositionOutOfLaws">http://www.ontotext.com/proton/protonext#hasSocialPositionOutOfLaws</seealso>
    let hasSocialPositionOutOfLaws =
        Prefixed_Name(pext, "hasSocialPositionOutOfLaws") |> PrefixedName

    /// <summary>
    ///   <para>onto:proton/protonext#hasSon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a person to his/her son."</para>
    /// labels<para>"has Son"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasSon">http://www.ontotext.com/proton/protonext#hasSon</seealso>
    let hasSon = Prefixed_Name(pext, "hasSon") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasStartOffset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasStartOffset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasStartOffset">http://www.ontotext.com/proton/protonext#hasStartOffset</seealso>
    let hasStartOffset = Prefixed_Name(pext, "hasStartOffset") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasStationaryPhone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates an object (usually a person) to its stationary phone number."</para>
    /// labels<para>"has Stationary Phone"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasStationaryPhone">http://www.ontotext.com/proton/protonext#hasStationaryPhone</seealso>
    let hasStationaryPhone = Prefixed_Name(pext, "hasStationaryPhone") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasString"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasString">http://www.ontotext.com/proton/protonext#hasString</seealso>
    let hasString = Prefixed_Name(pext, "hasString") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a job position to its title."</para>
    /// labels<para>"has Title"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasTitle">http://www.ontotext.com/proton/protonext#hasTitle</seealso>
    let hasTitle = Prefixed_Name(pext, "hasTitle") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasTopOffset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has Top Offset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasTopOffset">http://www.ontotext.com/proton/protonext#hasTopOffset</seealso>
    let hasTopOffset = Prefixed_Name(pext, "hasTopOffset") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Relates a currency to its unit. Examples: dollar, euro, etc."</para>
    /// labels<para>"has Unit"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasUnit">http://www.ontotext.com/proton/protonext#hasUnit</seealso>
    let hasUnit = Prefixed_Name(pext, "hasUnit") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasUserProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"a relation between an User and its Profile"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasUserProfile"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasUserProfile">http://www.ontotext.com/proton/protonext#hasUserProfile</seealso>
    let hasUserProfile = Prefixed_Name(pext, "hasUserProfile") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasWebPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates an object (usually a person or an organization) to its web page."</para>
    /// labels<para>"has Web Page"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasWebPage">http://www.ontotext.com/proton/protonext#hasWebPage</seealso>
    let hasWebPage = Prefixed_Name(pext, "hasWebPage") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#hasWife</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a man to his spouse."</para>
    /// labels<para>"has Wife"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#hasWife">http://www.ontotext.com/proton/protonext#hasWife</seealso>
    let hasWife = Prefixed_Name(pext, "hasWife") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext#industryOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between an organization and the industry sector it is active in."</para>
    /// labels<para>"Industry"</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext#industryOf">http://www.ontotext.com/proton/protonext#industryOf</seealso>
    let industryOf = Prefixed_Name(pext, "industryOf") |> PrefixedName

#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``gleif-base`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://www.gleif.org/ontology/Base/" "gleif-base"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>skos:definition : A partnership, corporation, or other organization having the capacity to negotiate contracts, assume financial obligations, and pay off debts, organized under the laws of some jurisdiction.^^xsd:string</para>
    ///   <para>rdfs:label : entity^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/Entity">gleif-base:Entity</a>
    /// </summary>
    let Entity = _prefixId.prefix "Entity"
    /// <summary>
    ///   <para>skos:definition : The reason that an entity ceased to exist and/or operate.^^xsd:string</para>
    ///   <para>rdfs:label : entity expiration reason^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/EntityExpirationReason">gleif-base:EntityExpirationReason</a>
    /// </summary>
    let EntityExpirationReason = _prefixId.prefix "EntityExpirationReason"

    let EntityExpirationReasonCorporateAction =
        _prefixId.prefix "EntityExpirationReasonCorporateAction"

    let EntityExpirationReasonDissolved =
        _prefixId.prefix "EntityExpirationReasonDissolved"

    let EntityExpirationReasonOther = _prefixId.prefix "EntityExpirationReasonOther"
    /// <summary>
    ///   <para>skos:definition : The operational and/or legal registration status of the entity (may be ACTIVE or INACTIVE)^^xsd:string</para>
    ///   <para>rdfs:label : entity status^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/EntityStatus">gleif-base:EntityStatus</a>
    /// </summary>
    let EntityStatus = _prefixId.prefix "EntityStatus"
    let EntityStatusActive = _prefixId.prefix "EntityStatusActive"
    let EntityStatusInactive = _prefixId.prefix "EntityStatusInactive"
    let GLEIF = _prefixId.prefix "GLEIF"
    /// <summary>
    ///   <para>skos:definition : Sequence of characters, capable of uniquely identifying that with which it is associated, within a specified context.^^xsd:string</para>
    ///   <para>rdfs:label : identifier^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/Identifier">gleif-base:Identifier</a>
    /// </summary>
    let Identifier = _prefixId.prefix "Identifier"
    /// <summary>
    ///   <para>skos:definition : abstract superclass to represent a reified directed relationship^^xsd:string</para>
    ///   <para>rdfs:label : legal entity relationship^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/LegalEntityRelationship">gleif-base:LegalEntityRelationship</a>
    /// </summary>
    let LegalEntityRelationship = _prefixId.prefix "LegalEntityRelationship"
    /// <summary>
    ///   <para>skos:definition : Any entity which can incur legal obligation and can be sued at law.^^xsd:string</para>
    ///   <para>rdfs:label : legal person^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/LegalPerson">gleif-base:LegalPerson</a>
    /// </summary>
    let LegalPerson = _prefixId.prefix "LegalPerson"
    /// <summary>
    ///   <para>skos:definition : A period of time, with at least a start time, and possibly an end.^^xsd:string</para>
    ///   <para>rdfs:label : period</para>
    ///   <a href="https://www.gleif.org/ontology/Base/Period">gleif-base:Period</a>
    /// </summary>
    let Period = _prefixId.prefix "Period"
    /// <summary>
    ///   <para>rdfs:label : physical address</para>
    ///   <para>skos:note : An address is a collection of information, presented in a mostly fixed format, used for describing the location of a building, apartment, or other structure or a plot of land, generally using political boundaries and street names as references, along with other identifiers such as house or apartment numbers.  Some addresses also contain special codes to aid routing of mail and packages, such as a ZIP code or post code. (Wikipedia)^^xsd:string</para>
    ///   <para>skos:definition : a physical address where communications can be addressed, papers served or representatives located for any kind of organization or person^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/PhysicalAddress">gleif-base:PhysicalAddress</a>
    /// </summary>
    let PhysicalAddress = _prefixId.prefix "PhysicalAddress"
    /// <summary>
    ///   <para>skos:definition : An address transliterated to ASCII characters.^^xsd:string</para>
    ///   <para>rdfs:label : physical address ASCII^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/PhysicalAddressASCII">gleif-base:PhysicalAddressASCII</a>
    /// </summary>
    let PhysicalAddressASCII = _prefixId.prefix "PhysicalAddressASCII"
    /// <summary>
    ///   <para>skos:prefLabel : registration authority^^xsd:string</para>
    ///   <para>skos:definition : An organization that is responsible for maintaining a registry and provides registration services.^^xsd:string</para>
    ///   <para>skos:altLabel : RA^^xsd:string</para>
    ///   <para>rdfs:label : registration authority^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/RegistrationAuthority">gleif-base:RegistrationAuthority</a>
    /// </summary>
    let RegistrationAuthority = _prefixId.prefix "RegistrationAuthority"
    /// <summary>
    ///   <para>skos:definition : A lifecycle stage indicating the status of a given registration of something, such as a business or legal entity.^^xsd:string</para>
    ///   <para>rdfs:label : registration status^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/RegistrationStatus">gleif-base:RegistrationStatus</a>
    /// </summary>
    let RegistrationStatus = _prefixId.prefix "RegistrationStatus"
    /// <summary>
    ///   <para>skos:definition : A system, typically an information system, that records the registration of items.^^xsd:string</para>
    ///   <para>rdfs:label : registry^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/Registry">gleif-base:Registry</a>
    /// </summary>
    let Registry = _prefixId.prefix "Registry"
    /// <summary>
    ///   <para>skos:definition : An entry in a registry that specifies something about the thing that is recorded.^^xsd:string</para>
    ///   <para>rdfs:label : registry entry^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/RegistryEntry">gleif-base:RegistryEntry</a>
    /// </summary>
    let RegistryEntry = _prefixId.prefix "RegistryEntry"
    /// <summary>
    ///   <para>skos:definition : An identifier associated with an entry in a registry, i.e., one that provides an index to the registry for the recorded item.^^xsd:string</para>
    ///   <para>rdfs:label : registry identifier^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/RegistryIdentifier">gleif-base:RegistryIdentifier</a>
    /// </summary>
    let RegistryIdentifier = _prefixId.prefix "RegistryIdentifier"
    /// <summary>
    ///   <para>skos:definition : An abbreviation for the entity identified.^^xsd:string</para>
    ///   <para>rdfs:label : has abbreviation^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasAbbreviation">gleif-base:hasAbbreviation</a>
    /// </summary>
    let hasAbbreviation = _prefixId.prefix "hasAbbreviation"
    /// <summary>
    ///   <para>skos:definition : An abbreviation using a language local to the entity identified; may be English.^^xsd:string</para>
    ///   <para>rdfs:label : has abbreviation local^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasAbbreviationLocal">gleif-base:hasAbbreviationLocal</a>
    /// </summary>
    let hasAbbreviationLocal = _prefixId.prefix "hasAbbreviationLocal"
    /// <summary>
    ///   <para>skos:definition : An abbreviation transliterated into a Western alphabet.^^xsd:string</para>
    ///   <para>rdfs:label : has abbreviation transliterated^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasAbbreviationTransliterated">gleif-base:hasAbbreviationTransliterated</a>
    /// </summary>
    let hasAbbreviationTransliterated = _prefixId.prefix "hasAbbreviationTransliterated"
    /// <summary>
    ///   <para>skos:definition : Means to collect the one to three specifically-named optional additional address line elements.^^xsd:string</para>
    ///   <para>rdfs:label : has additional address line^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasAdditionalAddressLine">gleif-base:hasAdditionalAddressLine</a>
    /// </summary>
    let hasAdditionalAddressLine = _prefixId.prefix "hasAdditionalAddressLine"
    /// <summary>
    ///   <para>skos:definition : Has a means by which the entity may be located or contacted or may receive correspondence.^^xsd:string</para>
    ///   <para>rdfs:label : has address^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasAddress">gleif-base:hasAddress</a>
    /// </summary>
    let hasAddress = _prefixId.prefix "hasAddress"
    /// <summary>
    ///   <para>skos:definition : An address of the headquarters of the Entity.^^xsd:string</para>
    ///   <para>rdfs:label : has address headquarters^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasAddressHeadquarters">gleif-base:hasAddressHeadquarters</a>
    /// </summary>
    let hasAddressHeadquarters = _prefixId.prefix "hasAddressHeadquarters"
    /// <summary>
    ///   <para>skos:definition : An address of the entity as recorded in the registration of the entity in its legal jurisdiction.^^xsd:string</para>
    ///   <para>rdfs:label : has address legal^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasAddressLegal">gleif-base:hasAddressLegal</a>
    /// </summary>
    let hasAddressLegal = _prefixId.prefix "hasAddressLegal"
    /// <summary>
    ///   <para>skos:definition : The mandatory first address line element.^^xsd:string</para>
    ///   <para>rdfs:label : has address line 1^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasAddressLine1">gleif-base:hasAddressLine1</a>
    /// </summary>
    let hasAddressLine1 = _prefixId.prefix "hasAddressLine1"
    /// <summary>
    ///   <para>skos:definition : The second line of the one to three optional additional address line elements.^^xsd:string</para>
    ///   <para>rdfs:label : has address line 2^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasAddressLine2">gleif-base:hasAddressLine2</a>
    /// </summary>
    let hasAddressLine2 = _prefixId.prefix "hasAddressLine2"
    /// <summary>
    ///   <para>skos:note : This element SHALL be omitted if address line 2 is omitted.^^xsd:string</para>
    ///   <para>skos:definition : The third line of the one to three optional additional address line elements.^^xsd:string</para>
    ///   <para>rdfs:label : has address line 3^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasAddressLine3">gleif-base:hasAddressLine3</a>
    /// </summary>
    let hasAddressLine3 = _prefixId.prefix "hasAddressLine3"
    /// <summary>
    ///   <para>skos:note : This element SHALL be omitted if address line 3 is omitted.^^xsd:string</para>
    ///   <para>skos:definition : The fourth line of the one to three optional additional address line elements.^^xsd:string</para>
    ///   <para>rdfs:label : has address line 4^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasAddressLine4">gleif-base:hasAddressLine4</a>
    /// </summary>
    let hasAddressLine4 = _prefixId.prefix "hasAddressLine4"
    /// <summary>
    ///   <para>skos:definition : Optional, additional structured version of an external house number, or range of numbers, contained in one of the address line elements.^^xsd:string</para>
    ///   <para>rdfs:label : has address number^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasAddressNumber">gleif-base:hasAddressNumber</a>
    /// </summary>
    let hasAddressNumber = _prefixId.prefix "hasAddressNumber"

    /// <summary>
    ///   <para>skos:definition : Optional, additional structured version of an internal location number, or range of numbers, contained in one of the address line elements.^^xsd:string</para>
    ///   <para>rdfs:label : has address number within building^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasAddressNumberWithinBuilding">gleif-base:hasAddressNumberWithinBuilding</a>
    /// </summary>
    let hasAddressNumberWithinBuilding =
        _prefixId.prefix "hasAddressNumberWithinBuilding"

    /// <summary>
    ///   <para>skos:definition : An address which has been converted from original to western text.^^xsd:string</para>
    ///   <para>rdfs:label : has address transliterated^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasAddressTransliterated">gleif-base:hasAddressTransliterated</a>
    /// </summary>
    let hasAddressTransliterated = _prefixId.prefix "hasAddressTransliterated"
    /// <summary>
    ///   <para>skos:definition : The mandatory name of the city.^^xsd:string</para>
    ///   <para>rdfs:label : has city^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasCity">gleif-base:hasCity</a>
    /// </summary>
    let hasCity = _prefixId.prefix "hasCity"
    /// <summary>
    ///   <para>skos:definition : The country, based on the 2-character ISO 3166-1 country code.^^xsd:string</para>
    ///   <para>rdfs:label : has country^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasCountry">gleif-base:hasCountry</a>
    /// </summary>
    let hasCountry = _prefixId.prefix "hasCountry"
    /// <summary>
    ///   <para>skos:definition : Indicates a geographic region in which some service is provided, or to which some policy applies, or in which something is available.^^xsd:string</para>
    ///   <para>rdfs:label : has coverage area^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasCoverageArea">gleif-base:hasCoverageArea</a>
    /// </summary>
    let hasCoverageArea = _prefixId.prefix "hasCoverageArea"
    /// <summary>
    ///   <para>skos:definition : The end time of a period.^^xsd:string</para>
    ///   <para>rdfs:label : has end</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasEnd">gleif-base:hasEnd</a>
    /// </summary>
    let hasEnd = _prefixId.prefix "hasEnd"
    /// <summary>
    ///   <para>skos:definition : The date that the entity ceased to operate, whether due to dissolution, merger or acquisition.^^xsd:string</para>
    ///   <para>rdfs:label : has entity expiration date^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasEntityExpirationDate">gleif-base:hasEntityExpirationDate</a>
    /// </summary>
    let hasEntityExpirationDate = _prefixId.prefix "hasEntityExpirationDate"
    /// <summary>
    ///   <para>skos:definition : The reason that an entity ceased to exist and/or operate.^^xsd:string</para>
    ///   <para>rdfs:label : has entity expiration reason^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasEntityExpirationReason">gleif-base:hasEntityExpirationReason</a>
    /// </summary>
    let hasEntityExpirationReason = _prefixId.prefix "hasEntityExpirationReason"
    /// <summary>
    ///   <para>skos:definition : Indicates the status of the entity (i.e., active, inactive).^^xsd:string</para>
    ///   <para>rdfs:label : has entity status^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasEntityStatus">gleif-base:hasEntityStatus</a>
    /// </summary>
    let hasEntityStatus = _prefixId.prefix "hasEntityStatus"
    /// <summary>
    ///   <para>skos:definition : The mandatory first address line element.^^xsd:string</para>
    ///   <para>rdfs:label : has first address line^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasFirstAddressLine">gleif-base:hasFirstAddressLine</a>
    /// </summary>
    let hasFirstAddressLine = _prefixId.prefix "hasFirstAddressLine"
    /// <summary>
    ///   <para>skos:definition : The country or region where something is located.^^xsd:string</para>
    ///   <para>rdfs:label : has geographic region^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasGeographicRegion">gleif-base:hasGeographicRegion</a>
    /// </summary>
    let hasGeographicRegion = _prefixId.prefix "hasGeographicRegion"
    /// <summary>
    ///   <para>skos:definition : The date on which an identifier or other registered item was first registered.^^xsd:string</para>
    ///   <para>rdfs:label : has initial registration date^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasInitialRegistrationDate">gleif-base:hasInitialRegistrationDate</a>
    /// </summary>
    let hasInitialRegistrationDate = _prefixId.prefix "hasInitialRegistrationDate"
    /// <summary>
    ///   <para>skos:definition : The date that the detail of a specific registration in the registry was last revised.^^xsd:string</para>
    ///   <para>rdfs:label : has last modification date^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasLastUpdateDate">gleif-base:hasLastUpdateDate</a>
    /// </summary>
    let hasLastUpdateDate = _prefixId.prefix "hasLastUpdateDate"
    /// <summary>
    ///   <para>skos:definition : The jurisdiction of legal formation and registration of the entity (and upon which the LegalForm data element is also dependent). ^^xsd:string</para>
    ///   <para>rdfs:label : has legal jurisdiction^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasLegalJurisdiction">gleif-base:hasLegalJurisdiction</a>
    /// </summary>
    let hasLegalJurisdiction = _prefixId.prefix "hasLegalJurisdiction"
    let hasLegalName = _prefixId.prefix "hasLegalName"
    /// <summary>
    ///   <para>skos:definition : Optional free text address line to hold content from other address lines containing explicit routing information (this element's presence indicates that this address is a routing / 'care of' address).^^xsd:string</para>
    ///   <para>rdfs:label : mail routing^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasMailRouting">gleif-base:hasMailRouting</a>
    /// </summary>
    let hasMailRouting = _prefixId.prefix "hasMailRouting"
    /// <summary>
    ///   <para>skos:definition : Associates a name, reference name, or appellation with an individual resource.^^xsd:string</para>
    ///   <para>rdfs:label : has name^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasName">gleif-base:hasName</a>
    /// </summary>
    let hasName = _prefixId.prefix "hasName"
    /// <summary>
    ///   <para>skos:prefLabel : has name ASCII^^xsd:string</para>
    ///   <para>skos:definition : The name used to refer to a person or organization in 7 bit ASCII text (ISO 646); also valid UNICODE (ISO 10646).^^xsd:string</para>
    ///   <para>skos:altLabel : has ASCII name^^xsd:string</para>
    ///   <para>rdfs:label : has name ASCII^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasNameASCII">gleif-base:hasNameASCII</a>
    /// </summary>
    let hasNameASCII = _prefixId.prefix "hasNameASCII"
    /// <summary>
    ///   <para>skos:prefLabel : has name ASCII automatic^^xsd:string</para>
    ///   <para>skos:definition : Legal name of the entity transliterated to ASCII characters, auto-transliterated by the managing LOU.^^xsd:string</para>
    ///   <para>skos:altLabel : has auto ASCII transliterated legal name^^xsd:string</para>
    ///   <para>rdfs:label : has name ASCII automatic^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasNameASCIIAutomatic">gleif-base:hasNameASCIIAutomatic</a>
    /// </summary>
    let hasNameASCIIAutomatic = _prefixId.prefix "hasNameASCIIAutomatic"
    /// <summary>
    ///   <para>skos:prefLabel : has name ASCII preferred^^xsd:string</para>
    ///   <para>skos:definition : Legal name of the entity transliterated to ASCII characters, provided by the entity for this purpose.^^xsd:string</para>
    ///   <para>skos:altLabel : has preferred transliterated legal name^^xsd:string</para>
    ///   <para>rdfs:label : has name ASCII preferred^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasNameASCIIPreferred">gleif-base:hasNameASCIIPreferred</a>
    /// </summary>
    let hasNameASCIIPreferred = _prefixId.prefix "hasNameASCIIPreferred"
    /// <summary>
    ///   <para>skos:prefLabel : has name additional^^xsd:string</para>
    ///   <para>skos:definition : The name used to refer to an person or organization informally.^^xsd:string</para>
    ///   <para>skos:altLabel : has other name^^xsd:string</para>
    ///   <para>rdfs:label : has name additional^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasNameAdditional">gleif-base:hasNameAdditional</a>
    /// </summary>
    let hasNameAdditional = _prefixId.prefix "hasNameAdditional"
    /// <summary>
    ///   <para>skos:definition : Registered name of the entity in an alternative language in the legal jurisdiction in which the entity is registered.^^xsd:string</para>
    ///   <para>rdfs:label : has name additional local^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasNameAdditionalLocal">gleif-base:hasNameAdditionalLocal</a>
    /// </summary>
    let hasNameAdditionalLocal = _prefixId.prefix "hasNameAdditionalLocal"
    /// <summary>
    ///   <para>skos:prefLabel : has name legal^^xsd:string</para>
    ///   <para>skos:definition : The name used to refer to an person or organization in legal communications.^^xsd:string</para>
    ///   <para>skos:altLabel : has legal name^^xsd:string</para>
    ///   <para>rdfs:label : has name legal^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasNameLegal">gleif-base:hasNameLegal</a>
    /// </summary>
    let hasNameLegal = _prefixId.prefix "hasNameLegal"
    /// <summary>
    ///   <para>skos:prefLabel : has name legal local^^xsd:string</para>
    ///   <para>skos:definition : The name used to refer to an person or organization in legal communications in local alphabet, which may be English.^^xsd:string</para>
    ///   <para>skos:altLabel : has local legal name^^xsd:string</para>
    ///   <para>rdfs:label : has name legal local^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasNameLegalLocal">gleif-base:hasNameLegalLocal</a>
    /// </summary>
    let hasNameLegalLocal = _prefixId.prefix "hasNameLegalLocal"
    /// <summary>
    ///   <para>skos:prefLabel : has name local^^xsd:string</para>
    ///   <para>skos:definition : A name in a language local to the entity identified; may be English.^^xsd:string</para>
    ///   <para>skos:altLabel : has local name^^xsd:string</para>
    ///   <para>rdfs:label : has name local^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasNameLocal">gleif-base:hasNameLocal</a>
    /// </summary>
    let hasNameLocal = _prefixId.prefix "hasNameLocal"
    /// <summary>
    ///   <para>skos:definition : A primary legal name previously used by this entity.^^xsd:string</para>
    ///   <para>rdfs:label : has name previous legal^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasNamePreviousLegal">gleif-base:hasNamePreviousLegal</a>
    /// </summary>
    let hasNamePreviousLegal = _prefixId.prefix "hasNamePreviousLegal"
    /// <summary>
    ///   <para>skos:prefLabel : has name trading or operating^^xsd:string</para>
    ///   <para>rdfs:label : has name trading or operating^^xsd:string</para>
    ///   <para>skos:altLabel : operating under^^xsd:stringskos:altLabel : has trading or operating name^^xsd:stringskos:altLabel : trading as^^xsd:stringskos:altLabel : brand name^^xsd:stringskos:altLabel : doing business as^^xsd:string</para>
    ///   <para>skos:definition : A 'trading as', 'brand name' or 'operating under' name currently used by this entity in addition to, but not replacing, the (primary) legal, official registered name^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasNameTradingOrOperating">gleif-base:hasNameTradingOrOperating</a>
    /// </summary>
    let hasNameTradingOrOperating = _prefixId.prefix "hasNameTradingOrOperating"
    /// <summary>
    ///   <para>skos:prefLabel : has name translated English^^xsd:string</para>
    ///   <para>skos:definition : The name used to refer to a person or organization, translated into English. Transliterated to ASCII by definition.^^xsd:string</para>
    ///   <para>skos:altLabel : has English name^^xsd:stringskos:altLabel : has international name^^xsd:string</para>
    ///   <para>rdfs:label : has name translated English^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasNameTranslatedEnglish">gleif-base:hasNameTranslatedEnglish</a>
    /// </summary>
    let hasNameTranslatedEnglish = _prefixId.prefix "hasNameTranslatedEnglish"
    /// <summary>
    ///   <para>skos:prefLabel : has name transliterated^^xsd:string</para>
    ///   <para>skos:definition : The name used to refer to a person or organization, converted from original to western text. Not generally the legal name.^^xsd:string</para>
    ///   <para>skos:altLabel : has transliterated name^^xsd:stringskos:altLabel : has transliterated other names^^xsd:string</para>
    ///   <para>rdfs:label : has name transliterated^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasNameTransliterated">gleif-base:hasNameTransliterated</a>
    /// </summary>
    let hasNameTransliterated = _prefixId.prefix "hasNameTransliterated"
    /// <summary>
    ///   <para>skos:definition : The date by which a specific registration in the registry must be renewed or updated.^^xsd:string</para>
    ///   <para>rdfs:label : has next renewal date^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasNextRenewalDate">gleif-base:hasNextRenewalDate</a>
    /// </summary>
    let hasNextRenewalDate = _prefixId.prefix "hasNextRenewalDate"
    /// <summary>
    ///   <para>skos:definition : The (optional) postal code of this address as specified by the local postal service.^^xsd:string</para>
    ///   <para>rdfs:label : has postal code^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasPostalCode">gleif-base:hasPostalCode</a>
    /// </summary>
    let hasPostalCode = _prefixId.prefix "hasPostalCode"
    /// <summary>
    ///   <para>skos:prefLabel : has region^^xsd:string</para>
    ///   <para>skos:definition : The (optional) region or subdivision (state, province, region, etc.) based on the 4- to 6-character ISO 3166-2 region code^^xsd:string</para>
    ///   <para>skos:altLabel : has state^^xsd:stringskos:altLabel : has subdivision^^xsd:string</para>
    ///   <para>rdfs:label : has region^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasRegion">gleif-base:hasRegion</a>
    /// </summary>
    let hasRegion = _prefixId.prefix "hasRegion"
    /// <summary>
    ///   <para>skos:definition : indicates the status of a specific registration, such as for an identifier or license^^xsd:string</para>
    ///   <para>rdfs:label : has registration status^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasRegistrationStatus">gleif-base:hasRegistrationStatus</a>
    /// </summary>
    let hasRegistrationStatus = _prefixId.prefix "hasRegistrationStatus"
    /// <summary>
    ///   <para>skos:definition : The entity that is the source of the directed relationship.^^xsd:string</para>
    ///   <para>rdfs:label : has source^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasSource">gleif-base:hasSource</a>
    /// </summary>
    let hasSource = _prefixId.prefix "hasSource"
    /// <summary>
    ///   <para>skos:definition : The start time of a period.^^xsd:string</para>
    ///   <para>rdfs:label : has start</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasStart">gleif-base:hasStart</a>
    /// </summary>
    let hasStart = _prefixId.prefix "hasStart"
    /// <summary>
    ///   <para>skos:definition : The surviving/new entity which continues/replaces this registration.^^xsd:string</para>
    ///   <para>rdfs:label : has successor^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasSuccessor">gleif-base:hasSuccessor</a>
    /// </summary>
    let hasSuccessor = _prefixId.prefix "hasSuccessor"
    /// <summary>
    ///   <para>skos:definition : The name of the successor entity.^^xsd:string</para>
    ///   <para>rdfs:label : has successor name^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasSuccessorName">gleif-base:hasSuccessorName</a>
    /// </summary>
    let hasSuccessorName = _prefixId.prefix "hasSuccessorName"
    /// <summary>
    ///   <para>skos:definition : Has a unique combination of alphanumeric characters or binary representation corresponding to the identifier, code, or other element to which it applies.^^xsd:string</para>
    ///   <para>rdfs:label : has tag^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasTag">gleif-base:hasTag</a>
    /// </summary>
    let hasTag = _prefixId.prefix "hasTag"
    /// <summary>
    ///   <para>skos:definition : The entity that plays the target of the directed relationship.^^xsd:string</para>
    ///   <para>rdfs:label : has target^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasTarget">gleif-base:hasTarget</a>
    /// </summary>
    let hasTarget = _prefixId.prefix "hasTarget"
    /// <summary>
    ///   <para>skos:definition : A website associated with something, including but not limited to an organization.^^xsd:string</para>
    ///   <para>rdfs:label : has website^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/hasWebsite">gleif-base:hasWebsite</a>
    /// </summary>
    let hasWebsite = _prefixId.prefix "hasWebsite"
    /// <summary>
    ///   <para>skos:definition : The relationship between an identifier and the thing it uniquely identifies.^^xsd:string</para>
    ///   <para>rdfs:label : identifies^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/identifies">gleif-base:identifies</a>
    /// </summary>
    let identifies = _prefixId.prefix "identifies"
    /// <summary>
    ///   <para>skos:definition : Relates something to another thing that has some role in directing its affairs.^^xsd:string</para>
    ///   <para>rdfs:label : is managed by^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/isManagedBy">gleif-base:isManagedBy</a>
    /// </summary>
    let isManagedBy = _prefixId.prefix "isManagedBy"
    /// <summary>
    ///   <para>skos:definition : Any additional qualitative properties that help to categorize the relationship.^^xsd:string</para>
    ///   <para>rdfs:label : is qualified by^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/isQualifiedBy">gleif-base:isQualifiedBy</a>
    /// </summary>
    let isQualifiedBy = _prefixId.prefix "isQualifiedBy"
    /// <summary>
    ///   <para>skos:definition : Any additional quantitative properties that help to categorize the relationship.^^xsd:string</para>
    ///   <para>rdfs:label : is quantified by^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/isQuantifiedBy">gleif-base:isQuantifiedBy</a>
    /// </summary>
    let isQuantifiedBy = _prefixId.prefix "isQuantifiedBy"
    /// <summary>
    ///   <para>skos:definition : indicates the registry that something is registered in^^xsd:string</para>
    ///   <para>rdfs:label : is registered in^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/isRegisteredIn">gleif-base:isRegisteredIn</a>
    /// </summary>
    let isRegisteredIn = _prefixId.prefix "isRegisteredIn"
    /// <summary>
    ///   <para>skos:definition : The thing which the registry entry is a record of.^^xsd:string</para>
    ///   <para>rdfs:label : records^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/Base/records">gleif-base:records</a>
    /// </summary>
    let records = _prefixId.prefix "records"

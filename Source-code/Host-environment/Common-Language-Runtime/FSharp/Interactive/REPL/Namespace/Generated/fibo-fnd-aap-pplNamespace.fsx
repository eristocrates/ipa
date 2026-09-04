#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fnd-aap-ppl`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/" "fibo-fnd-aap-ppl"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : adult^^xsd:string</para>
    ///   <para>skos:definition : person who has attained the age of majority as defined in some jurisdiction^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://en.wikipedia.org/wiki/Adult^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/Adult">fibo-fnd-aap-ppl:Adult</a>
    /// </summary>
    let Adult = _prefixId.prefix "Adult"
    /// <summary>
    ///   <para>rdfs:label : age of majority^^xsd:string</para>
    ///   <para>skos:definition : age at which someone acquires the rights and responsibilities of an adult in some jurisdiction^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/AgeOfMajority">fibo-fnd-aap-ppl:AgeOfMajority</a>
    /// </summary>
    let AgeOfMajority = _prefixId.prefix "AgeOfMajority"
    /// <summary>
    ///   <para>rdfs:label : birth certificate^^xsd:string</para>
    ///   <para>skos:definition : an original document certifying the circumstances of the birth, or a certified copy of or representation of the ensuing registration of that birth^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://en.wikipedia.org/wiki/Birth_certificate^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : A birth certificate is a vital record that documents the birth of a child. Depending on the jurisdiction, a record of birth might or might not contain verification of the event by such as a midwife or doctor.^^xsd:string</para>
    ///   <para>cmns-av:synonym : certificate of live birth^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/BirthCertificate">fibo-fnd-aap-ppl:BirthCertificate</a>
    /// </summary>
    let BirthCertificate = _prefixId.prefix "BirthCertificate"

    /// <summary>
    ///   <para>rdfs:label : birth certificate identification scheme^^xsd:string</para>
    ///   <para>skos:definition : system for allocating identifiers to birth certificates^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Schemes for birth certificate identification are typically regionally defined, and there may be jurisdiction-specific scope required as an additional restriction on a specific scheme.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/BirthCertificateIdentificationScheme">fibo-fnd-aap-ppl:BirthCertificateIdentificationScheme</a>
    /// </summary>
    let BirthCertificateIdentificationScheme =
        _prefixId.prefix "BirthCertificateIdentificationScheme"

    /// <summary>
    ///   <para>rdfs:label : birth certificate identifier^^xsd:string</para>
    ///   <para>skos:definition : identifier associated with a vital record documenting the birth of a child^^xsd:string</para>
    ///   <para>cmns-av:synonym : birth certificate number^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/BirthCertificateIdentifier">fibo-fnd-aap-ppl:BirthCertificateIdentifier</a>
    /// </summary>
    let BirthCertificateIdentifier = _prefixId.prefix "BirthCertificateIdentifier"
    /// <summary>
    ///   <para>rdfs:label : contact^^xsd:string</para>
    ///   <para>skos:definition : role or associated with a party serving as a designated point of communication, typically within a system or process^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/Contact">fibo-fnd-aap-ppl:Contact</a>
    /// </summary>
    let Contact = _prefixId.prefix "Contact"
    /// <summary>
    ///   <para>rdfs:label : contact record^^xsd:string</para>
    ///   <para>skos:definition : record about a party in a specific communicative or liaison role^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Contact records may include attributes such as name, role, communication channel, and affiliation, They may be found in registries, schemas, systems such as those designed for customer relationship management (CRM), enterprise resource planning (ERP), health information, legal and regulatory compliance and others, as well as personal address books, to support communications, coordination, support, or compliance.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/ContactRecord">fibo-fnd-aap-ppl:ContactRecord</a>
    /// </summary>
    let ContactRecord = _prefixId.prefix "ContactRecord"
    /// <summary>
    ///   <para>rdfs:label : date of birth^^xsd:string</para>
    ///   <para>skos:definition : explicit date, i.e., the day, month and year, on which an individual was born^^xsd:string</para>
    ///   <para>cmns-av:synonym : birth date^^xsd:stringcmns-av:synonym : birthday^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DateOfBirth">fibo-fnd-aap-ppl:DateOfBirth</a>
    /// </summary>
    let DateOfBirth = _prefixId.prefix "DateOfBirth"
    /// <summary>
    ///   <para>rdfs:label : date of death^^xsd:string</para>
    ///   <para>skos:definition : explicit date, i.e., the day, month and year, on which an individual died^^xsd:string</para>
    ///   <para>cmns-av:synonym : death date^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DateOfDeath">fibo-fnd-aap-ppl:DateOfDeath</a>
    /// </summary>
    let DateOfDeath = _prefixId.prefix "DateOfDeath"
    /// <summary>
    ///   <para>rdfs:label : death certificate^^xsd:string</para>
    ///   <para>skos:definition : original document certifying the circumstances of the death (such as how and when it occurred), or a certified copy of or representation of the ensuing registration of that death^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A death certificate is a vital record documenting information (including age, occupation, place of birth, place of residence, and often identifying the parents and possibly spouse of the deceased) relating to a dead person and including a doctor's certification of the cause of death.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DeathCertificate">fibo-fnd-aap-ppl:DeathCertificate</a>
    /// </summary>
    let DeathCertificate = _prefixId.prefix "DeathCertificate"

    /// <summary>
    ///   <para>rdfs:label : death certificate identification scheme^^xsd:string</para>
    ///   <para>skos:definition : system for allocating identifiers to death certificates^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Schemes for death certificate identification are typically regionally defined, and there may be jurisdiction-specific scope required as an additional restriction on a specific scheme.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DeathCertificateIdentificationScheme">fibo-fnd-aap-ppl:DeathCertificateIdentificationScheme</a>
    /// </summary>
    let DeathCertificateIdentificationScheme =
        _prefixId.prefix "DeathCertificateIdentificationScheme"

    /// <summary>
    ///   <para>rdfs:label : death certificate identifier^^xsd:string</para>
    ///   <para>skos:definition : identifier associated with a vital record documenting the death of an individual^^xsd:string</para>
    ///   <para>cmns-av:synonym : death certificate number^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DeathCertificateIdentifier">fibo-fnd-aap-ppl:DeathCertificateIdentifier</a>
    /// </summary>
    let DeathCertificateIdentifier = _prefixId.prefix "DeathCertificateIdentifier"
    /// <summary>
    ///   <para>rdfs:label : driver's license^^xsd:string</para>
    ///   <para>skos:definition : an official document which states that a person may operate a motorized vehicle, such as a motorcycle, car, truck or a bus, on a public roadway or provides official identifying information for a non-driver^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://en.wikipedia.org/wiki/Non-driver_identification_card#Non-driver_identification_cards^^xsd:anyURI</para>
    ///   <para>cmns-av:synonym : driving licence^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DriversLicense">fibo-fnd-aap-ppl:DriversLicense</a>
    /// </summary>
    let DriversLicense = _prefixId.prefix "DriversLicense"

    /// <summary>
    ///   <para>rdfs:label : driver's license identification scheme^^xsd:string</para>
    ///   <para>skos:definition : system for allocating identifiers to driver's, operating, or non-driver identification documents^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Schemes for driver's license identification are typically regionally defined, and there may be jurisdiction-specific scope required as an additional restriction on a specific scheme.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DriversLicenseIdentificationScheme">fibo-fnd-aap-ppl:DriversLicenseIdentificationScheme</a>
    /// </summary>
    let DriversLicenseIdentificationScheme =
        _prefixId.prefix "DriversLicenseIdentificationScheme"

    /// <summary>
    ///   <para>rdfs:label : driver's license identifier^^xsd:string</para>
    ///   <para>skos:definition : identifier associated with a drivers' or operating license for operating a motor vehicle or non-driver identification card^^xsd:string</para>
    ///   <para>cmns-av:synonym : driver's license number^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DriversLicenseIdentifier">fibo-fnd-aap-ppl:DriversLicenseIdentifier</a>
    /// </summary>
    let DriversLicenseIdentifier = _prefixId.prefix "DriversLicenseIdentifier"
    /// <summary>
    ///   <para>rdfs:label : emancipated minor^^xsd:string</para>
    ///   <para>skos:definition : a minor who is allowed to conduct a business or any other occupation on his or her own behalf or for their own account outside the control of a parent or guardian^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://en.wikipedia.org/wiki/Emancipated_minor^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : The minor will then have full contractual capacity to conclude contracts with regard to the business. Whether parental consent is needed to achieve emancipated status varies from case to case. In some cases, court permission is necessary. Protocols vary by jurisdiction.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/EmancipatedMinor">fibo-fnd-aap-ppl:EmancipatedMinor</a>
    /// </summary>
    let EmancipatedMinor = _prefixId.prefix "EmancipatedMinor"
    /// <summary>
    ///   <para>rdfs:label : identity document^^xsd:string</para>
    ///   <para>skos:definition : any legal document which may be used to verify aspects of a person's identity^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://en.wikipedia.org/wiki/Identification_card^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : If issued in the form of a small, mostly standard-sized card, it is usually called an identity card (IC). Countries which do not have formal identity documents may require informal documents. In the absence of a formal identity document, driving licenses can be used in many countries as a method of proof of identity, although some countries do not accept driving licenses for identification, often because in those countries they don't expire as documents and can be old and easily forged. Most countries accept passports as a form of identification. Most countries have the rule that foreign citizens need to have their passport or occasionally a national identity card from their country available at any time if they do not have residence permit in the country.^^xsd:string</para>
    ///   <para>cmns-av:synonym : identity card^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/IdentityDocument">fibo-fnd-aap-ppl:IdentityDocument</a>
    /// </summary>
    let IdentityDocument = _prefixId.prefix "IdentityDocument"
    /// <summary>
    ///   <para>rdfs:label : incapacitated adult^^xsd:string</para>
    ///   <para>skos:definition : an adult who is legally identified as not having legal capacity, typically as a result of some inherent physical or mental incapacity or as a result of having contracted some illness which temporarily deprives them of such capacity^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://en.wikipedia.org/wiki/Capacity_(law)^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : Individuals may have an inherent physical condition which prevents them from achieving the normal levels of performance expected from persons of comparable age, or their inability to match current levels of performance may be caused by contracting an illness. Whatever the cause, if the resulting condition is such that individuals cannot care for themselves, or may act in ways that are against their interests, those persons are vulnerable through dependency and require the protection of the state against the risks of abuse or exploitation. Hence, any agreements that were made are voidable, and a court may declare that person a ward of the state and grant power of attorney to an appointed legal guardian.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/IncapacitatedAdult">fibo-fnd-aap-ppl:IncapacitatedAdult</a>
    /// </summary>
    let IncapacitatedAdult = _prefixId.prefix "IncapacitatedAdult"
    /// <summary>
    ///   <para>rdfs:label : legal age^^xsd:string</para>
    ///   <para>skos:definition : age at which someone acquires the capacity to do something that they were prohibited from doing before under the law in some jurisdiction^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/LegalAge">fibo-fnd-aap-ppl:LegalAge</a>
    /// </summary>
    let LegalAge = _prefixId.prefix "LegalAge"
    /// <summary>
    ///   <para>rdfs:label : legal working age^^xsd:string</para>
    ///   <para>skos:definition : age at which someone acquires the capacity to work legally in some jurisdiction^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/LegalWorkingAge">fibo-fnd-aap-ppl:LegalWorkingAge</a>
    /// </summary>
    let LegalWorkingAge = _prefixId.prefix "LegalWorkingAge"
    /// <summary>
    ///   <para>rdfs:label : legal working age person^^xsd:string</para>
    ///   <para>skos:definition : person whose age is greater than the minimum legal working age specified in a jurisdiction in which they work^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/LegalWorkingAgePerson">fibo-fnd-aap-ppl:LegalWorkingAgePerson</a>
    /// </summary>
    let LegalWorkingAgePerson = _prefixId.prefix "LegalWorkingAgePerson"
    /// <summary>
    ///   <para>rdfs:label : legally capable adult^^xsd:string</para>
    ///   <para>skos:definition : person who has attained the age of majority as defined in some jurisdiction and who is allowed to conduct a business or any other occupation on his or her own behalf or for their own account^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/LegallyCapableAdult">fibo-fnd-aap-ppl:LegallyCapableAdult</a>
    /// </summary>
    let LegallyCapableAdult = _prefixId.prefix "LegallyCapableAdult"
    /// <summary>
    ///   <para>rdfs:label : minor^^xsd:string</para>
    ///   <para>skos:definition : a person under a certain age, usually the age of majority in a given jurisdiction, which legally demarcates childhood from adulthood^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://en.wikipedia.org/wiki/Minor_(law)^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : The age depends upon jurisdiction and application, but is generally 18.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/Minor">fibo-fnd-aap-ppl:Minor</a>
    /// </summary>
    let Minor = _prefixId.prefix "Minor"
    /// <summary>
    ///   <para>rdfs:label : national identification number^^xsd:string</para>
    ///   <para>skos:definition : number or text which appears on an identity document issued by a country or jurisdiction^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://en.wikipedia.org/wiki/National_identification_number^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : A national identification number, national identity number, or national insurance number is used by the governments of many countries as a means of tracking their citizens, permanent residents, and temporary residents for the purposes of work, taxation, government benefits, health care, and other governmentally-related functions. The number will appear on an identity document issued by a country.
    ///
    /// The ways in which such a system is implemented are dependent on the country, but in most cases, a citizen is issued an identification number at birth or when they reach a legal age (typically the age of 18). Non-citizens may be issued such numbers when they enter the country, or when granted a temporary or permanent residence permit.
    ///
    /// Many countries issued such numbers ostensibly for a singular purpose, but over time, they become a de facto national identification number. For example, the United States originally developed its Social Security number system as a means of disbursing Social Security benefits. However, due to function creep, the number has become utilized for other purposes to the point where it is almost essential to have one to, among other things, open a bank account, obtain a credit card, or drive a car.^^xsd:string</para>
    ///   <para>cmns-av:synonym : national identity number^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/NationalIdentificationNumber">fibo-fnd-aap-ppl:NationalIdentificationNumber</a>
    /// </summary>
    let NationalIdentificationNumber = _prefixId.prefix "NationalIdentificationNumber"

    /// <summary>
    ///   <para>rdfs:label : national identification number scheme^^xsd:string</para>
    ///   <para>skos:definition : system for allocating identifiers to national identification numbers^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Schemes for national identification numbers are jurisdiction-specific by country.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/NationalIdentificationNumberScheme">fibo-fnd-aap-ppl:NationalIdentificationNumberScheme</a>
    /// </summary>
    let NationalIdentificationNumberScheme =
        _prefixId.prefix "NationalIdentificationNumberScheme"

    /// <summary>
    ///   <para>rdfs:label : passport^^xsd:string</para>
    ///   <para>skos:definition : formal identity document, issued by a national government, which certifies the identity and nationality of its holder for the purpose of international travel^^xsd:string</para>
    ///   <para>fibo-fnd-utl-av:definitionOrigin : https://en.wikipedia.org/wiki/Passport^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : The elements of identity contained in all standardized passports include information about the holder, including name, date of birth, gender and place of birth.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/Passport">fibo-fnd-aap-ppl:Passport</a>
    /// </summary>
    let Passport = _prefixId.prefix "Passport"
    /// <summary>
    ///   <para>rdfs:label : passport number^^xsd:string</para>
    ///   <para>skos:definition : national identification number associated with a passport^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/PassportNumber">fibo-fnd-aap-ppl:PassportNumber</a>
    /// </summary>
    let PassportNumber = _prefixId.prefix "PassportNumber"

    /// <summary>
    ///   <para>rdfs:label : passport number identification scheme^^xsd:string</para>
    ///   <para>skos:definition : system for allocating identifiers to passports^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Schemes for passport identification are jurisdiction-specific by country.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/PassportNumberIdentificationScheme">fibo-fnd-aap-ppl:PassportNumberIdentificationScheme</a>
    /// </summary>
    let PassportNumberIdentificationScheme =
        _prefixId.prefix "PassportNumberIdentificationScheme"

    /// <summary>
    ///   <para>rdfs:label : person</para>
    ///   <para>skos:definition : individual human being, with consciousness of self^^xsd:string</para>
    ///   <para>cmns-av:synonym : natural person^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/Person">fibo-fnd-aap-ppl:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>rdfs:label : person name^^xsd:string</para>
    ///   <para>skos:definition : designation by which someone is known in some context^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/PersonName">fibo-fnd-aap-ppl:PersonName</a>
    /// </summary>
    let PersonName = _prefixId.prefix "PersonName"
    /// <summary>
    ///   <para>rdfs:label : place of birth^^xsd:string</para>
    ///   <para>skos:definition : physical location, including country, region, and municipality where an individual was born^^xsd:string</para>
    ///   <para>cmns-av:synonym : birth place^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/PlaceOfBirth">fibo-fnd-aap-ppl:PlaceOfBirth</a>
    /// </summary>
    let PlaceOfBirth = _prefixId.prefix "PlaceOfBirth"
    /// <summary>
    ///   <para>rdfs:label : has age of majority^^xsd:string</para>
    ///   <para>skos:definition : relates someone to the age required to attain the capacity to engage in certain transactions or be treated legally as an adult in some jurisdiction^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasAgeOfMajority">fibo-fnd-aap-ppl:hasAgeOfMajority</a>
    /// </summary>
    let hasAgeOfMajority = _prefixId.prefix "hasAgeOfMajority"
    /// <summary>
    ///   <para>rdfs:label : has citizenship^^xsd:string</para>
    ///   <para>skos:definition : links a person to their country of citizenship^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasCitizenship">fibo-fnd-aap-ppl:hasCitizenship</a>
    /// </summary>
    let hasCitizenship = _prefixId.prefix "hasCitizenship"
    /// <summary>
    ///   <para>rdfs:label : has date of birth^^xsd:string</para>
    ///   <para>skos:definition : identifies the date on which an individual was born^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasDateOfBirth">fibo-fnd-aap-ppl:hasDateOfBirth</a>
    /// </summary>
    let hasDateOfBirth = _prefixId.prefix "hasDateOfBirth"
    /// <summary>
    ///   <para>rdfs:label : has date of death^^xsd:string</para>
    ///   <para>skos:definition : identifies the date on which an individual died^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasDateOfDeath">fibo-fnd-aap-ppl:hasDateOfDeath</a>
    /// </summary>
    let hasDateOfDeath = _prefixId.prefix "hasDateOfDeath"
    /// <summary>
    ///   <para>rdfs:label : has family name^^xsd:string</para>
    ///   <para>skos:definition : indicates the name shared in common to identify the members of a family, as distinguished from each member's given name^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : 'Family name' is more commonly used in the United Kingdom than in the United States to refer to someone's surname.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasFamilyName">fibo-fnd-aap-ppl:hasFamilyName</a>
    /// </summary>
    let hasFamilyName = _prefixId.prefix "hasFamilyName"
    /// <summary>
    ///   <para>rdfs:label : has first name^^xsd:string</para>
    ///   <para>skos:definition : indicates the given name or first name of a person, that is, the name chosen for them at birth or changed by them subsequently from the name given at birth^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasFirstName">fibo-fnd-aap-ppl:hasFirstName</a>
    /// </summary>
    let hasFirstName = _prefixId.prefix "hasFirstName"
    /// <summary>
    ///   <para>rdfs:label : has full legal name^^xsd:string</para>
    ///   <para>skos:definition : indicates the complete name of a person, typically used in formal situations including those of a legal or contractual nature^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasFullLegalName">fibo-fnd-aap-ppl:hasFullLegalName</a>
    /// </summary>
    let hasFullLegalName = _prefixId.prefix "hasFullLegalName"
    /// <summary>
    ///   <para>rdfs:label : has gender^^xsd:string</para>
    ///   <para>skos:definition : links a particular gender value with a person^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasGender">fibo-fnd-aap-ppl:hasGender</a>
    /// </summary>
    let hasGender = _prefixId.prefix "hasGender"
    /// <summary>
    ///   <para>rdfs:label : has given name^^xsd:string</para>
    ///   <para>skos:definition : indicates the given name or first name of a person, that is, the name chosen for them at birth or changed by them subsequently from the name given at birth^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasGivenName">fibo-fnd-aap-ppl:hasGivenName</a>
    /// </summary>
    let hasGivenName = _prefixId.prefix "hasGivenName"
    /// <summary>
    ///   <para>rdfs:label : has last name^^xsd:string</para>
    ///   <para>skos:definition : indicates the name shared in common to identify the members of a family, as distinguished from each member's given name^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasLastName">fibo-fnd-aap-ppl:hasLastName</a>
    /// </summary>
    let hasLastName = _prefixId.prefix "hasLastName"
    /// <summary>
    ///   <para>rdfs:label : has maiden name^^xsd:string</para>
    ///   <para>skos:definition : indicates the name shared in common to identify the members of a family, that predates any changes of name due to marriage^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasMaidenName">fibo-fnd-aap-ppl:hasMaidenName</a>
    /// </summary>
    let hasMaidenName = _prefixId.prefix "hasMaidenName"
    /// <summary>
    ///   <para>rdfs:label : has middle name or initial^^xsd:string</para>
    ///   <para>skos:definition : one or more additional names or initial letters for names that occur between a person's first and last name^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasMiddleNameOrInitial">fibo-fnd-aap-ppl:hasMiddleNameOrInitial</a>
    /// </summary>
    let hasMiddleNameOrInitial = _prefixId.prefix "hasMiddleNameOrInitial"
    /// <summary>
    ///   <para>rdfs:label : has minimum legal working age^^xsd:string</para>
    ///   <para>skos:definition : relates someone to the minimum legal working age for the jurisdiction in which they reside^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasMinimumLegalWorkingAge">fibo-fnd-aap-ppl:hasMinimumLegalWorkingAge</a>
    /// </summary>
    let hasMinimumLegalWorkingAge = _prefixId.prefix "hasMinimumLegalWorkingAge"
    /// <summary>
    ///   <para>rdfs:label : has name prefix^^xsd:string</para>
    ///   <para>skos:definition : indicates a character or sequence of characters, preceding a person's name, that provides additional information about the person, such as a form of address representing a title, honorific, or military rank^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasNamePrefix">fibo-fnd-aap-ppl:hasNamePrefix</a>
    /// </summary>
    let hasNamePrefix = _prefixId.prefix "hasNamePrefix"
    /// <summary>
    ///   <para>rdfs:label : has name suffix^^xsd:string</para>
    ///   <para>skos:definition : indicates a character or sequence of characters, following a person's name, that provides additional information about the person, such as their position, educational degree, accreditation, office, or honor^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasNameSuffix">fibo-fnd-aap-ppl:hasNameSuffix</a>
    /// </summary>
    let hasNameSuffix = _prefixId.prefix "hasNameSuffix"
    /// <summary>
    ///   <para>rdfs:label : has person name^^xsd:string</para>
    ///   <para>skos:definition : links a name to an individual^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Note that the concept of a person name may include symbology as long as the symbols are properly encoded. Because person name is a class, other iconography or symbology that cannot be encoded in UTF-8 can, alternatively, be linked or attached as a separate image or in another form.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasPersonName">fibo-fnd-aap-ppl:hasPersonName</a>
    /// </summary>
    let hasPersonName = _prefixId.prefix "hasPersonName"
    /// <summary>
    ///   <para>rdfs:label : has place of birth^^xsd:string</para>
    ///   <para>skos:definition : identifies the location where an individual was born^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasPlaceOfBirth">fibo-fnd-aap-ppl:hasPlaceOfBirth</a>
    /// </summary>
    let hasPlaceOfBirth = _prefixId.prefix "hasPlaceOfBirth"
    /// <summary>
    ///   <para>rdfs:label : has point of contact^^xsd:string</para>
    ///   <para>skos:definition : identifies a party designated as the point of contact for^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasPointOfContact">fibo-fnd-aap-ppl:hasPointOfContact</a>
    /// </summary>
    let hasPointOfContact = _prefixId.prefix "hasPointOfContact"
    /// <summary>
    ///   <para>rdfs:label : has primary residence^^xsd:string</para>
    ///   <para>skos:definition : identifies a dwelling where an individual resides the majority of the year^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : For tax purposes, in cases when an individual owns more than one home, their primary residence is the home in which they reside most of the time, and for which they can provide evidence to that effect. Having said this, there are cases, such as for individuals that have dual citizenship, where they may have multiple primary residences, one in each country in which they maintain a home. There may also be subtle issues related to 'rent control' that may impact the statements an individual makes about their primary residence. In other words, one cannot necessarily infer a person's identity from their primary place of residence.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasPrimaryResidence">fibo-fnd-aap-ppl:hasPrimaryResidence</a>
    /// </summary>
    let hasPrimaryResidence = _prefixId.prefix "hasPrimaryResidence"
    /// <summary>
    ///   <para>rdfs:label : has residence^^xsd:string</para>
    ///   <para>skos:definition : identifies a dwelling where an individual lives^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasResidence">fibo-fnd-aap-ppl:hasResidence</a>
    /// </summary>
    let hasResidence = _prefixId.prefix "hasResidence"
    /// <summary>
    ///   <para>rdfs:label : has surname^^xsd:string</para>
    ///   <para>skos:definition : indicates the name shared in common to identify the members of a family, as distinguished from each member's given name^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasSurname">fibo-fnd-aap-ppl:hasSurname</a>
    /// </summary>
    let hasSurname = _prefixId.prefix "hasSurname"
    /// <summary>
    ///   <para>rdfs:label : is point of contact for^^xsd:string</para>
    ///   <para>skos:definition : is the entity or purpose for which the party is the point of contact^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/isPointOfContactFor">fibo-fnd-aap-ppl:isPointOfContactFor</a>
    /// </summary>
    let isPointOfContactFor = _prefixId.prefix "isPointOfContactFor"

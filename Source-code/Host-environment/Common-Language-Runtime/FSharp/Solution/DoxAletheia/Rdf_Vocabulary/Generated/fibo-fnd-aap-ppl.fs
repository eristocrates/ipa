namespace https.spec.edmcouncil.org.fibo.ontology.FND.AgentsAndPeople.People.slash

open DoxAletheia

module fibo_fnd_aap_ppl =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/Adult"></see>
    /// </summary>
    let Adult = _prefix "Adult"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/Person"></see>
    /// </summary>
    let Person = _prefix "Person"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasAgeOfMajority"></see>
    /// </summary>
    let hasAgeOfMajority = _prefix "hasAgeOfMajority"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/AgeOfMajority"></see>
    /// </summary>
    let AgeOfMajority = _prefix "AgeOfMajority"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/LegalAge"></see>
    /// </summary>
    let LegalAge = _prefix "LegalAge"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/BirthCertificate"></see>
    /// </summary>
    let BirthCertificate = _prefix "BirthCertificate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/IdentityDocument"></see>
    /// </summary>
    let IdentityDocument = _prefix "IdentityDocument"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/BirthCertificateIdentifier"></see>
    /// </summary>
    let BirthCertificateIdentifier = _prefix "BirthCertificateIdentifier"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/BirthCertificateIdentificationScheme"></see>
    /// </summary>
    let BirthCertificateIdentificationScheme =
        _prefix "BirthCertificateIdentificationScheme"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/Contact"></see>
    /// </summary>
    let Contact = _prefix "Contact"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/ContactRecord"></see>
    /// </summary>
    let ContactRecord = _prefix "ContactRecord"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DateOfBirth"></see>
    /// </summary>
    let DateOfBirth = _prefix "DateOfBirth"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DateOfDeath"></see>
    /// </summary>
    let DateOfDeath = _prefix "DateOfDeath"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DeathCertificate"></see>
    /// </summary>
    let DeathCertificate = _prefix "DeathCertificate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DeathCertificateIdentifier"></see>
    /// </summary>
    let DeathCertificateIdentifier = _prefix "DeathCertificateIdentifier"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DeathCertificateIdentificationScheme"></see>
    /// </summary>
    let DeathCertificateIdentificationScheme =
        _prefix "DeathCertificateIdentificationScheme"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DriversLicense"></see>
    /// </summary>
    let DriversLicense = _prefix "DriversLicense"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DriversLicenseIdentifier"></see>
    /// </summary>
    let DriversLicenseIdentifier = _prefix "DriversLicenseIdentifier"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DriversLicenseIdentificationScheme"></see>
    /// </summary>
    let DriversLicenseIdentificationScheme =
        _prefix "DriversLicenseIdentificationScheme"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/EmancipatedMinor"></see>
    /// </summary>
    let EmancipatedMinor = _prefix "EmancipatedMinor"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/Minor"></see>
    /// </summary>
    let Minor = _prefix "Minor"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/IncapacitatedAdult"></see>
    /// </summary>
    let IncapacitatedAdult = _prefix "IncapacitatedAdult"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/LegallyCapableAdult"></see>
    /// </summary>
    let LegallyCapableAdult = _prefix "LegallyCapableAdult"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/LegalWorkingAge"></see>
    /// </summary>
    let LegalWorkingAge = _prefix "LegalWorkingAge"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/LegalWorkingAgePerson"></see>
    /// </summary>
    let LegalWorkingAgePerson = _prefix "LegalWorkingAgePerson"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasMinimumLegalWorkingAge"></see>
    /// </summary>
    let hasMinimumLegalWorkingAge = _prefix "hasMinimumLegalWorkingAge"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/NationalIdentificationNumber"></see>
    /// </summary>
    let NationalIdentificationNumber = _prefix "NationalIdentificationNumber"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/NationalIdentificationNumberScheme"></see>
    /// </summary>
    let NationalIdentificationNumberScheme =
        _prefix "NationalIdentificationNumberScheme"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/Passport"></see>
    /// </summary>
    let Passport = _prefix "Passport"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/PassportNumber"></see>
    /// </summary>
    let PassportNumber = _prefix "PassportNumber"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/PassportNumberIdentificationScheme"></see>
    /// </summary>
    let PassportNumberIdentificationScheme =
        _prefix "PassportNumberIdentificationScheme"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasDateOfDeath"></see>
    /// </summary>
    let hasDateOfDeath = _prefix "hasDateOfDeath"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/PersonName"></see>
    /// </summary>
    let PersonName = _prefix "PersonName"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasResidence"></see>
    /// </summary>
    let hasResidence = _prefix "hasResidence"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasCitizenship"></see>
    /// </summary>
    let hasCitizenship = _prefix "hasCitizenship"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasDateOfBirth"></see>
    /// </summary>
    let hasDateOfBirth = _prefix "hasDateOfBirth"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasPlaceOfBirth"></see>
    /// </summary>
    let hasPlaceOfBirth = _prefix "hasPlaceOfBirth"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/PlaceOfBirth"></see>
    /// </summary>
    let PlaceOfBirth = _prefix "PlaceOfBirth"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasGender"></see>
    /// </summary>
    let hasGender = _prefix "hasGender"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasFullLegalName"></see>
    /// </summary>
    let hasFullLegalName = _prefix "hasFullLegalName"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasNamePrefix"></see>
    /// </summary>
    let hasNamePrefix = _prefix "hasNamePrefix"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasNameSuffix"></see>
    /// </summary>
    let hasNameSuffix = _prefix "hasNameSuffix"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasSurname"></see>
    /// </summary>
    let hasSurname = _prefix "hasSurname"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasFamilyName"></see>
    /// </summary>
    let hasFamilyName = _prefix "hasFamilyName"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasPersonName"></see>
    /// </summary>
    let hasPersonName = _prefix "hasPersonName"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasLastName"></see>
    /// </summary>
    let hasLastName = _prefix "hasLastName"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasFirstName"></see>
    /// </summary>
    let hasFirstName = _prefix "hasFirstName"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasGivenName"></see>
    /// </summary>
    let hasGivenName = _prefix "hasGivenName"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasMaidenName"></see>
    /// </summary>
    let hasMaidenName = _prefix "hasMaidenName"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasMiddleNameOrInitial"></see>
    /// </summary>
    let hasMiddleNameOrInitial = _prefix "hasMiddleNameOrInitial"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasPointOfContact"></see>
    /// </summary>
    let hasPointOfContact = _prefix "hasPointOfContact"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasPrimaryResidence"></see>
    /// </summary>
    let hasPrimaryResidence = _prefix "hasPrimaryResidence"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/isPointOfContactFor"></see>
    /// </summary>
    let isPointOfContactFor = _prefix "isPointOfContactFor"

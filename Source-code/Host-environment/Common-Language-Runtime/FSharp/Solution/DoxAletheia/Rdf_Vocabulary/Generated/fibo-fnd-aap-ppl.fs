namespace https.spec.edmcouncil.org.fibo.ontology.FND.AgentsAndPeople.People.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_aap_ppl =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/Adult"></see>
    /// </summary>
    let Adult = Namespaced_IRI.parse _namespace_name "Adult" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/Person"></see>
    /// </summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasAgeOfMajority"></see>
    /// </summary>
    let hasAgeOfMajority =
        Namespaced_IRI.parse _namespace_name "hasAgeOfMajority" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/AgeOfMajority"></see>
    /// </summary>
    let AgeOfMajority =
        Namespaced_IRI.parse _namespace_name "AgeOfMajority" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/LegalAge"></see>
    /// </summary>
    let LegalAge = Namespaced_IRI.parse _namespace_name "LegalAge" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/BirthCertificate"></see>
    /// </summary>
    let BirthCertificate =
        Namespaced_IRI.parse _namespace_name "BirthCertificate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/IdentityDocument"></see>
    /// </summary>
    let IdentityDocument =
        Namespaced_IRI.parse _namespace_name "IdentityDocument" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/BirthCertificateIdentifier"></see>
    /// </summary>
    let BirthCertificateIdentifier =
        Namespaced_IRI.parse _namespace_name "BirthCertificateIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/BirthCertificateIdentificationScheme"></see>
    /// </summary>
    let BirthCertificateIdentificationScheme =
        Namespaced_IRI.parse _namespace_name "BirthCertificateIdentificationScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/Contact"></see>
    /// </summary>
    let Contact = Namespaced_IRI.parse _namespace_name "Contact" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/ContactRecord"></see>
    /// </summary>
    let ContactRecord =
        Namespaced_IRI.parse _namespace_name "ContactRecord" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DateOfBirth"></see>
    /// </summary>
    let DateOfBirth =
        Namespaced_IRI.parse _namespace_name "DateOfBirth" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DateOfDeath"></see>
    /// </summary>
    let DateOfDeath =
        Namespaced_IRI.parse _namespace_name "DateOfDeath" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DeathCertificate"></see>
    /// </summary>
    let DeathCertificate =
        Namespaced_IRI.parse _namespace_name "DeathCertificate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DeathCertificateIdentifier"></see>
    /// </summary>
    let DeathCertificateIdentifier =
        Namespaced_IRI.parse _namespace_name "DeathCertificateIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DeathCertificateIdentificationScheme"></see>
    /// </summary>
    let DeathCertificateIdentificationScheme =
        Namespaced_IRI.parse _namespace_name "DeathCertificateIdentificationScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DriversLicense"></see>
    /// </summary>
    let DriversLicense =
        Namespaced_IRI.parse _namespace_name "DriversLicense" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DriversLicenseIdentifier"></see>
    /// </summary>
    let DriversLicenseIdentifier =
        Namespaced_IRI.parse _namespace_name "DriversLicenseIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/DriversLicenseIdentificationScheme"></see>
    /// </summary>
    let DriversLicenseIdentificationScheme =
        Namespaced_IRI.parse _namespace_name "DriversLicenseIdentificationScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/EmancipatedMinor"></see>
    /// </summary>
    let EmancipatedMinor =
        Namespaced_IRI.parse _namespace_name "EmancipatedMinor" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/Minor"></see>
    /// </summary>
    let Minor = Namespaced_IRI.parse _namespace_name "Minor" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/IncapacitatedAdult"></see>
    /// </summary>
    let IncapacitatedAdult =
        Namespaced_IRI.parse _namespace_name "IncapacitatedAdult" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/LegallyCapableAdult"></see>
    /// </summary>
    let LegallyCapableAdult =
        Namespaced_IRI.parse _namespace_name "LegallyCapableAdult" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/LegalWorkingAge"></see>
    /// </summary>
    let LegalWorkingAge =
        Namespaced_IRI.parse _namespace_name "LegalWorkingAge" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/LegalWorkingAgePerson"></see>
    /// </summary>
    let LegalWorkingAgePerson =
        Namespaced_IRI.parse _namespace_name "LegalWorkingAgePerson" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasMinimumLegalWorkingAge"></see>
    /// </summary>
    let hasMinimumLegalWorkingAge =
        Namespaced_IRI.parse _namespace_name "hasMinimumLegalWorkingAge" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/NationalIdentificationNumber"></see>
    /// </summary>
    let NationalIdentificationNumber =
        Namespaced_IRI.parse _namespace_name "NationalIdentificationNumber" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/NationalIdentificationNumberScheme"></see>
    /// </summary>
    let NationalIdentificationNumberScheme =
        Namespaced_IRI.parse _namespace_name "NationalIdentificationNumberScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/Passport"></see>
    /// </summary>
    let Passport = Namespaced_IRI.parse _namespace_name "Passport" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/PassportNumber"></see>
    /// </summary>
    let PassportNumber =
        Namespaced_IRI.parse _namespace_name "PassportNumber" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/PassportNumberIdentificationScheme"></see>
    /// </summary>
    let PassportNumberIdentificationScheme =
        Namespaced_IRI.parse _namespace_name "PassportNumberIdentificationScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasDateOfDeath"></see>
    /// </summary>
    let hasDateOfDeath =
        Namespaced_IRI.parse _namespace_name "hasDateOfDeath" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/PersonName"></see>
    /// </summary>
    let PersonName = Namespaced_IRI.parse _namespace_name "PersonName" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasResidence"></see>
    /// </summary>
    let hasResidence =
        Namespaced_IRI.parse _namespace_name "hasResidence" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasCitizenship"></see>
    /// </summary>
    let hasCitizenship =
        Namespaced_IRI.parse _namespace_name "hasCitizenship" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasDateOfBirth"></see>
    /// </summary>
    let hasDateOfBirth =
        Namespaced_IRI.parse _namespace_name "hasDateOfBirth" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasPlaceOfBirth"></see>
    /// </summary>
    let hasPlaceOfBirth =
        Namespaced_IRI.parse _namespace_name "hasPlaceOfBirth" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/PlaceOfBirth"></see>
    /// </summary>
    let PlaceOfBirth =
        Namespaced_IRI.parse _namespace_name "PlaceOfBirth" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasGender"></see>
    /// </summary>
    let hasGender = Namespaced_IRI.parse _namespace_name "hasGender" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasFullLegalName"></see>
    /// </summary>
    let hasFullLegalName =
        Namespaced_IRI.parse _namespace_name "hasFullLegalName" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasNamePrefix"></see>
    /// </summary>
    let hasNamePrefix =
        Namespaced_IRI.parse _namespace_name "hasNamePrefix" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasNameSuffix"></see>
    /// </summary>
    let hasNameSuffix =
        Namespaced_IRI.parse _namespace_name "hasNameSuffix" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasSurname"></see>
    /// </summary>
    let hasSurname = Namespaced_IRI.parse _namespace_name "hasSurname" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasFamilyName"></see>
    /// </summary>
    let hasFamilyName =
        Namespaced_IRI.parse _namespace_name "hasFamilyName" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasPersonName"></see>
    /// </summary>
    let hasPersonName =
        Namespaced_IRI.parse _namespace_name "hasPersonName" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasLastName"></see>
    /// </summary>
    let hasLastName =
        Namespaced_IRI.parse _namespace_name "hasLastName" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasFirstName"></see>
    /// </summary>
    let hasFirstName =
        Namespaced_IRI.parse _namespace_name "hasFirstName" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasGivenName"></see>
    /// </summary>
    let hasGivenName =
        Namespaced_IRI.parse _namespace_name "hasGivenName" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasMaidenName"></see>
    /// </summary>
    let hasMaidenName =
        Namespaced_IRI.parse _namespace_name "hasMaidenName" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasMiddleNameOrInitial"></see>
    /// </summary>
    let hasMiddleNameOrInitial =
        Namespaced_IRI.parse _namespace_name "hasMiddleNameOrInitial" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasPointOfContact"></see>
    /// </summary>
    let hasPointOfContact =
        Namespaced_IRI.parse _namespace_name "hasPointOfContact" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/hasPrimaryResidence"></see>
    /// </summary>
    let hasPrimaryResidence =
        Namespaced_IRI.parse _namespace_name "hasPrimaryResidence" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/isPointOfContactFor"></see>
    /// </summary>
    let isPointOfContactFor =
        Namespaced_IRI.parse _namespace_name "isPointOfContactFor" |> NamespacedName

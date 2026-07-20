namespace http.rdvocab.info.ElementsGr2.slash

open DoxAletheia

module rdag2 =
    let _namespace_name = "http://rdvocab.info/ElementsGr2/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/addressOfTheCorporateBody"></see>
    /// </summary>
    let addressOfTheCorporateBody = _prefix "addressOfTheCorporateBody"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/addressOfThePerson"></see>
    /// </summary>
    let addressOfThePerson = _prefix "addressOfThePerson"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/affiliation"></see>
    /// </summary>
    let affiliation = _prefix "affiliation"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/associatedInstitution"></see>
    /// </summary>
    let associatedInstitution = _prefix "associatedInstitution"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/biographicalInformation"></see>
    /// </summary>
    let biographicalInformation = _prefix "biographicalInformation"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/cataloguersNote"></see>
    /// </summary>
    let cataloguersNote = _prefix "cataloguersNote"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/name"></see>
    /// </summary>
    let name = _prefix "name"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/corporateHistory"></see>
    /// </summary>
    let corporateHistory = _prefix "corporateHistory"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/countryAssociatedWithThePerson"></see>
    /// </summary>
    let countryAssociatedWithThePerson = _prefix "countryAssociatedWithThePerson"

    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/dateAssociatedWithTheCorporateBody"></see>
    /// </summary>
    let dateAssociatedWithTheCorporateBody =
        _prefix "dateAssociatedWithTheCorporateBody"

    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/dateOfConferenceEtc"></see>
    /// </summary>
    let dateOfConferenceEtc = _prefix "dateOfConferenceEtc"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/dateOfEstablishment"></see>
    /// </summary>
    let dateOfEstablishment = _prefix "dateOfEstablishment"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/dateOfTermination"></see>
    /// </summary>
    let dateOfTermination = _prefix "dateOfTermination"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/dateAssociatedWithTheFamily"></see>
    /// </summary>
    let dateAssociatedWithTheFamily = _prefix "dateAssociatedWithTheFamily"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/dateAssociatedWithThePerson"></see>
    /// </summary>
    let dateAssociatedWithThePerson = _prefix "dateAssociatedWithThePerson"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/dateOfDeath"></see>
    /// </summary>
    let dateOfDeath = _prefix "dateOfDeath"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/dateOfBirth"></see>
    /// </summary>
    let dateOfBirth = _prefix "dateOfBirth"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/periodOfActivityOfThePerson"></see>
    /// </summary>
    let periodOfActivityOfThePerson = _prefix "periodOfActivityOfThePerson"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/DateAssociatedWithThePerson"></see>
    /// </summary>
    let DateAssociatedWithThePerson = _prefix "DateAssociatedWithThePerson"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/dateOfUsage"></see>
    /// </summary>
    let dateOfUsage = _prefix "dateOfUsage"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/familyHistory"></see>
    /// </summary>
    let familyHistory = _prefix "familyHistory"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/fieldOfActivityOfTheCorporateBody"></see>
    /// </summary>
    let fieldOfActivityOfTheCorporateBody = _prefix "fieldOfActivityOfTheCorporateBody"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/fieldOfActivityOfThePerson"></see>
    /// </summary>
    let fieldOfActivityOfThePerson = _prefix "fieldOfActivityOfThePerson"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/fullerFormOfName"></see>
    /// </summary>
    let fullerFormOfName = _prefix "fullerFormOfName"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/fullerFormOfNamePerson"></see>
    /// </summary>
    let fullerFormOfNamePerson = _prefix "fullerFormOfNamePerson"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/gender"></see>
    /// </summary>
    let gender = _prefix "gender"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/hereditaryTitle"></see>
    /// </summary>
    let hereditaryTitle = _prefix "hereditaryTitle"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/identifierForTheCorporateBody"></see>
    /// </summary>
    let identifierForTheCorporateBody = _prefix "identifierForTheCorporateBody"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/identifierForTheFamily"></see>
    /// </summary>
    let identifierForTheFamily = _prefix "identifierForTheFamily"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/identifierForThePerson"></see>
    /// </summary>
    let identifierForThePerson = _prefix "identifierForThePerson"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/languageOfTheCorporateBody"></see>
    /// </summary>
    let languageOfTheCorporateBody = _prefix "languageOfTheCorporateBody"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/languageOfThePerson"></see>
    /// </summary>
    let languageOfThePerson = _prefix "languageOfThePerson"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/locationOfConferenceEtc"></see>
    /// </summary>
    let locationOfConferenceEtc = _prefix "locationOfConferenceEtc"

    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/placeAssociatedWithTheCorporateBody"></see>
    /// </summary>
    let placeAssociatedWithTheCorporateBody =
        _prefix "placeAssociatedWithTheCorporateBody"

    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/locationOfHeadquarters"></see>
    /// </summary>
    let locationOfHeadquarters = _prefix "locationOfHeadquarters"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/statusOfIdentification"></see>
    /// </summary>
    let statusOfIdentification = _prefix "statusOfIdentification"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/sourceConsulted"></see>
    /// </summary>
    let sourceConsulted = _prefix "sourceConsulted"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/nameOfTheCorporateBody"></see>
    /// </summary>
    let nameOfTheCorporateBody = _prefix "nameOfTheCorporateBody"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/preferredNameForTheCorporateBody"></see>
    /// </summary>
    let preferredNameForTheCorporateBody = _prefix "preferredNameForTheCorporateBody"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/variantNameForTheCorporateBody"></see>
    /// </summary>
    let variantNameForTheCorporateBody = _prefix "variantNameForTheCorporateBody"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/nameOfTheFamily"></see>
    /// </summary>
    let nameOfTheFamily = _prefix "nameOfTheFamily"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/preferredNameForTheFamily"></see>
    /// </summary>
    let preferredNameForTheFamily = _prefix "preferredNameForTheFamily"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/variantNameForTheFamily"></see>
    /// </summary>
    let variantNameForTheFamily = _prefix "variantNameForTheFamily"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/nameOfThePerson"></see>
    /// </summary>
    let nameOfThePerson = _prefix "nameOfThePerson"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/preferredNameForThePerson"></see>
    /// </summary>
    let preferredNameForThePerson = _prefix "preferredNameForThePerson"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/variantNameForThePerson"></see>
    /// </summary>
    let variantNameForThePerson = _prefix "variantNameForThePerson"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/note"></see>
    /// </summary>
    let note = _prefix "note"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/numberOfAConferenceEtc"></see>
    /// </summary>
    let numberOfAConferenceEtc = _prefix "numberOfAConferenceEtc"

    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/otherDesignationAssociatedWithTheCorporateBody"></see>
    /// </summary>
    let otherDesignationAssociatedWithTheCorporateBody =
        _prefix "otherDesignationAssociatedWithTheCorporateBody"

    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/otherDesignationAssociatedWithThePerson"></see>
    /// </summary>
    let otherDesignationAssociatedWithThePerson =
        _prefix "otherDesignationAssociatedWithThePerson"

    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/placeAssociatedWithTheFamily"></see>
    /// </summary>
    let placeAssociatedWithTheFamily = _prefix "placeAssociatedWithTheFamily"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/placeOfBirth"></see>
    /// </summary>
    let placeOfBirth = _prefix "placeOfBirth"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/placeOfDeath"></see>
    /// </summary>
    let placeOfDeath = _prefix "placeOfDeath"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/placeOfResidence"></see>
    /// </summary>
    let placeOfResidence = _prefix "placeOfResidence"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/professionOrOccupation"></see>
    /// </summary>
    let professionOrOccupation = _prefix "professionOrOccupation"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/prominentMemberOfTheFamily"></see>
    /// </summary>
    let prominentMemberOfTheFamily = _prefix "prominentMemberOfTheFamily"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/scopeOfUsage"></see>
    /// </summary>
    let scopeOfUsage = _prefix "scopeOfUsage"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/titleOfThePerson"></see>
    /// </summary>
    let titleOfThePerson = _prefix "titleOfThePerson"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/typeOfFamily"></see>
    /// </summary>
    let typeOfFamily = _prefix "typeOfFamily"
    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/undifferentiatedNameIndicator"></see>
    /// </summary>
    let undifferentiatedNameIndicator = _prefix "undifferentiatedNameIndicator"

    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/undifferentiatedNameIndicatorPerson"></see>
    /// </summary>
    let undifferentiatedNameIndicatorPerson =
        _prefix "undifferentiatedNameIndicatorPerson"

    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/undifferentiatedNameIndicatorCorporateBody"></see>
    /// </summary>
    let undifferentiatedNameIndicatorCorporateBody =
        _prefix "undifferentiatedNameIndicatorCorporateBody"

    /// <summary>
    ///   <see href="http://rdvocab.info/ElementsGr2/undifferentiatedNameIndicatorFamily"></see>
    /// </summary>
    let undifferentiatedNameIndicatorFamily =
        _prefix "undifferentiatedNameIndicatorFamily"

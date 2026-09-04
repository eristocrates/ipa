#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module rdag2 =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://rdvocab.info/ElementsGr2/" "rdag2"

    let DateAssociatedWithThePerson = _prefixId.prefix "DateAssociatedWithThePerson"
    /// <summary>
    ///   <para>skos:scopeNote : FRAD 4.3.</para>
    ///   <para>skos:definition : The address of a corporate body’s headquarters or offices, or an e-mail or Internet address for the body.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : addressOfTheCorporateBody</para>
    ///   <para>rdfs:label : Address of the corporate body</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/addressOfTheCorporateBody">rdag2:addressOfTheCorporateBody</a>
    /// </summary>
    let addressOfTheCorporateBody = _prefixId.prefix "addressOfTheCorporateBody"
    /// <summary>
    ///   <para>skos:scopeNote : FRAD 4.1.</para>
    ///   <para>skos:definition : The address of a person’s place of residence, business, or employer, and/or an e-mail or Internet address.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : addressOfThePerson</para>
    ///   <para>rdfs:label : Address of the person</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/addressOfThePerson">rdag2:addressOfThePerson</a>
    /// </summary>
    let addressOfThePerson = _prefixId.prefix "addressOfThePerson"
    /// <summary>
    ///   <para>skos:scopeNote : FRAD 4.1.</para>
    ///   <para>skos:definition : A group with which a person is affiliated or has been affiliated through employment, membership, cultural identity, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : affiliation</para>
    ///   <para>rdfs:label : Affiliation</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/affiliation">rdag2:affiliation</a>
    /// </summary>
    let affiliation = _prefixId.prefix "affiliation"
    /// <summary>
    ///   <para>skos:definition : An institution commonly associated with a corporate body.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : associatedInstitution</para>
    ///   <para>rdfs:label : Associated institution</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/associatedInstitution">rdag2:associatedInstitution</a>
    /// </summary>
    let associatedInstitution = _prefixId.prefix "associatedInstitution"
    /// <summary>
    ///   <para>skos:scopeNote : FRAD 4.1.</para>
    ///   <para>skos:definition : Information pertaining to the life or history of a person.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : biographicalInformation</para>
    ///   <para>rdfs:label : Biographical information</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/biographicalInformation">rdag2:biographicalInformation</a>
    /// </summary>
    let biographicalInformation = _prefixId.prefix "biographicalInformation"
    /// <summary>
    ///   <para>skos:definition : An annotation that might be helpful to those using or revising the authorized access point representing an entity or relationship data, or creating an authorized access point representing a related entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : cataloguersNote</para>
    ///   <para>rdfs:label : Cataloguer's note</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/cataloguersNote">rdag2:cataloguersNote</a>
    /// </summary>
    let cataloguersNote = _prefixId.prefix "cataloguersNote"
    /// <summary>
    ///   <para>skos:scopeNote : FRAD 4.3.</para>
    ///   <para>skos:definition : Information pertaining to the history of a corporate body.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : corporateHistory</para>
    ///   <para>rdfs:label : Corporate history</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/corporateHistory">rdag2:corporateHistory</a>
    /// </summary>
    let corporateHistory = _prefixId.prefix "corporateHistory"

    /// <summary>
    ///   <para>skos:scopeNote : FRAD 4.1.</para>
    ///   <para>skos:definition : A country with which a person is identified.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : countryAssociatedWithThePerson</para>
    ///   <para>rdfs:label : Country associated with the person</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/countryAssociatedWithThePerson">rdag2:countryAssociatedWithThePerson</a>
    /// </summary>
    let countryAssociatedWithThePerson =
        _prefixId.prefix "countryAssociatedWithThePerson"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateAssociatedWithTheCorporateBody</para>
    ///   <para>skos:definition : The date or range of dates on which a conference, etc., is held, or a date with which a corporate body is otherwise associated (e.g., date of founding).</para>
    ///   <para>rdfs:label : Date associated with the corporate body</para>
    ///   <para>skos:scopeNote : FRBR 4.7.4 and FRAD 4.3.</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/dateAssociatedWithTheCorporateBody">rdag2:dateAssociatedWithTheCorporateBody</a>
    /// </summary>
    let dateAssociatedWithTheCorporateBody =
        _prefixId.prefix "dateAssociatedWithTheCorporateBody"

    /// <summary>
    ///   <para>skos:scopeNote : FRAD 4.2.</para>
    ///   <para>skos:definition : A significant date associated with a family.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateAssociatedWithTheFamily</para>
    ///   <para>rdfs:label : Date associated with the family</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/dateAssociatedWithTheFamily">rdag2:dateAssociatedWithTheFamily</a>
    /// </summary>
    let dateAssociatedWithTheFamily = _prefixId.prefix "dateAssociatedWithTheFamily"
    /// <summary>
    ///   <para>skos:scopeNote : FRBR 4.6.2 and FRAD 4.1.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateAssociatedWithThePerson</para>
    ///   <para>rdfs:label : Date associated with the person</para>
    ///   <para>skos:definition : A significant date associated with a person (e.g., date of birth, date of death).</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/dateAssociatedWithThePerson">rdag2:dateAssociatedWithThePerson</a>
    /// </summary>
    let dateAssociatedWithThePerson = _prefixId.prefix "dateAssociatedWithThePerson"
    /// <summary>
    ///   <para>skos:definition : The year a person was born. Date of birth may also include the month and day of the person’s birth.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfBirth</para>
    ///   <para>rdfs:label : Date of birth</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/dateOfBirth">rdag2:dateOfBirth</a>
    /// </summary>
    let dateOfBirth = _prefixId.prefix "dateOfBirth"
    /// <summary>
    ///   <para>skos:scopeNote : FRBR 4.7.4 and FRAD 4.3.</para>
    ///   <para>skos:definition : The date or range of dates on which a conference, congress, meeting, exhibition, fair, festival, etc., was held.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfConferenceEtc</para>
    ///   <para>rdfs:label : Date of conference, etc.</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/dateOfConferenceEtc">rdag2:dateOfConferenceEtc</a>
    /// </summary>
    let dateOfConferenceEtc = _prefixId.prefix "dateOfConferenceEtc"
    /// <summary>
    ///   <para>skos:scopeNote : FRBR 4.6.2 and FRAD 4.1.</para>
    ///   <para>skos:definition : The year a person died. Date of death may also include the month and day of the person’s death.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfDeath</para>
    ///   <para>rdfs:label : Date of death</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/dateOfDeath">rdag2:dateOfDeath</a>
    /// </summary>
    let dateOfDeath = _prefixId.prefix "dateOfDeath"
    /// <summary>
    ///   <para>skos:scopeNote : FRBR 4.7.4 and FRAD 4.3.</para>
    ///   <para>skos:definition : The date on which a corporate body was established or founded.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfEstablishment</para>
    ///   <para>rdfs:label : Date of establishment</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/dateOfEstablishment">rdag2:dateOfEstablishment</a>
    /// </summary>
    let dateOfEstablishment = _prefixId.prefix "dateOfEstablishment"
    /// <summary>
    ///   <para>skos:scopeNote : FRBR 4.7.4 and FRAD 4.3.</para>
    ///   <para>skos:definition : The date on which a corporate body was terminated or dissolved.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfTermination</para>
    ///   <para>rdfs:label : Date of termination</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/dateOfTermination">rdag2:dateOfTermination</a>
    /// </summary>
    let dateOfTermination = _prefixId.prefix "dateOfTermination"
    /// <summary>
    ///   <para>skos:definition : A date or range of dates associated with the use of the name designated as the preferred name for a person.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfUsage</para>
    ///   <para>rdfs:label : Date of usage</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/dateOfUsage">rdag2:dateOfUsage</a>
    /// </summary>
    let dateOfUsage = _prefixId.prefix "dateOfUsage"
    /// <summary>
    ///   <para>skos:scopeNote : FRAD 4.2.</para>
    ///   <para>skos:definition : Information pertaining to the history of a family.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : familyHistory</para>
    ///   <para>rdfs:label : Family history</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/familyHistory">rdag2:familyHistory</a>
    /// </summary>
    let familyHistory = _prefixId.prefix "familyHistory"

    /// <summary>
    ///   <para>skos:scopeNote : FRAD 4.3.</para>
    ///   <para>skos:definition : A field of business in which a corporate body is engaged, its area of competence, responsibility, jurisdiction, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : fieldOfActivityOfTheCorporateBody</para>
    ///   <para>rdfs:label : Field of activity of the corporate body</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/fieldOfActivityOfTheCorporateBody">rdag2:fieldOfActivityOfTheCorporateBody</a>
    /// </summary>
    let fieldOfActivityOfTheCorporateBody =
        _prefixId.prefix "fieldOfActivityOfTheCorporateBody"

    /// <summary>
    ///   <para>skos:scopeNote : FRBR 4.6.4 and FRAD 4.1.</para>
    ///   <para>skos:definition : A field of endeavour, area of expertise, etc., in which a person is engaged or was engaged.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : fieldOfActivityOfThePerson</para>
    ///   <para>rdfs:label : Field of activity of the person</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/fieldOfActivityOfThePerson">rdag2:fieldOfActivityOfThePerson</a>
    /// </summary>
    let fieldOfActivityOfThePerson = _prefixId.prefix "fieldOfActivityOfThePerson"
    /// <summary>
    ///   <para>skos:scopeNote : FRBR 4.6.1 and FRAD 4.1.</para>
    ///   <para>skos:definition : The full form of a part of a name represented only by an initial or abbreviation in the form chosen as the preferred name, or a part of the name not included in the form chosen as the preferred name.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : fullerFormOfName</para>
    ///   <para>rdfs:label : Fuller form of name</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/fullerFormOfName">rdag2:fullerFormOfName</a>
    /// </summary>
    let fullerFormOfName = _prefixId.prefix "fullerFormOfName"
    /// <summary>
    ///   <para>skos:definition : The full form of a part of a name represented only by an initial or abbreviation in the form chosen as the preferred name, or a part of the name not included in the form chosen as the preferred name.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : fullerFormOfNamePerson</para>
    ///   <para>rdfs:label : Fuller form of name (Person)</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/fullerFormOfNamePerson">rdag2:fullerFormOfNamePerson</a>
    /// </summary>
    let fullerFormOfNamePerson = _prefixId.prefix "fullerFormOfNamePerson"
    /// <summary>
    ///   <para>skos:scopeNote : FRAD 4.1.</para>
    ///   <para>skos:definition : The gender with which a person identifies.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : gender</para>
    ///   <para>rdfs:label : Gender</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/gender">rdag2:gender</a>
    /// </summary>
    let gender = _prefixId.prefix "gender"
    /// <summary>
    ///   <para>skos:scopeNote : FRAD 4.2.</para>
    ///   <para>skos:definition : A title of nobility, etc., associated with a family.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hereditaryTitle</para>
    ///   <para>rdfs:label : Hereditary title</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/hereditaryTitle">rdag2:hereditaryTitle</a>
    /// </summary>
    let hereditaryTitle = _prefixId.prefix "hereditaryTitle"
    /// <summary>
    ///   <para>skos:scopeNote : FRAD 5.2.</para>
    ///   <para>skos:definition : A character string uniquely associated with a corporate body, or with a surrogate for a corporate body (e.g., an authority record), that
    /// serves to differentiate that corporate body from other corporate bodies.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : identifierForTheCorporateBody</para>
    ///   <para>rdfs:label : Identifier for the corporate body</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/identifierForTheCorporateBody">rdag2:identifierForTheCorporateBody</a>
    /// </summary>
    let identifierForTheCorporateBody = _prefixId.prefix "identifierForTheCorporateBody"
    /// <summary>
    ///   <para>skos:scopeNote : FRAD 5.2.</para>
    ///   <para>skos:definition : A character string uniquely associated with a family, or with a surrogate for a family (e.g., an authority record), that serves to differentiate that family from other families.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : identifierForTheFamily</para>
    ///   <para>rdfs:label : Identifier for the family</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/identifierForTheFamily">rdag2:identifierForTheFamily</a>
    /// </summary>
    let identifierForTheFamily = _prefixId.prefix "identifierForTheFamily"
    /// <summary>
    ///   <para>skos:definition : A character string uniquely associated with a person, or with a surrogate for a person (e.g., an authority record), that serves to differentiate that person from other persons.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : identifierForThePerson</para>
    ///   <para>rdfs:label : Identifier for the person</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/identifierForThePerson">rdag2:identifierForThePerson</a>
    /// </summary>
    let identifierForThePerson = _prefixId.prefix "identifierForThePerson"
    /// <summary>
    ///   <para>skos:scopeNote : FRAD 4.3.</para>
    ///   <para>skos:definition : A language a corporate body uses in its communications.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : languageOfTheCorporateBody</para>
    ///   <para>rdfs:label : Language of the corporate body</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/languageOfTheCorporateBody">rdag2:languageOfTheCorporateBody</a>
    /// </summary>
    let languageOfTheCorporateBody = _prefixId.prefix "languageOfTheCorporateBody"
    /// <summary>
    ///   <para>skos:scopeNote : FRAD 4.1.</para>
    ///   <para>skos:definition : A language a person uses when writing for publication, broadcasting, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : languageOfThePerson</para>
    ///   <para>rdfs:label : Language of the person</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/languageOfThePerson">rdag2:languageOfThePerson</a>
    /// </summary>
    let languageOfThePerson = _prefixId.prefix "languageOfThePerson"
    /// <summary>
    ///   <para>skos:definition : A local place in which a conference, congress, meeting, exhibition, fair, festival, etc., was held.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : locationOfConferenceEtc</para>
    ///   <para>rdfs:label : Location of conference, etc.</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/locationOfConferenceEtc">rdag2:locationOfConferenceEtc</a>
    /// </summary>
    let locationOfConferenceEtc = _prefixId.prefix "locationOfConferenceEtc"
    /// <summary>
    ///   <para>skos:scopeNote : FRBR 4.7.3 and FRAD 4.3.</para>
    ///   <para>skos:definition : A country, state, province, etc., or local place in which an organization has its headquarters.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : locationOfHeadquarters</para>
    ///   <para>rdfs:label : Location of headquarters</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/locationOfHeadquarters">rdag2:locationOfHeadquarters</a>
    /// </summary>
    let locationOfHeadquarters = _prefixId.prefix "locationOfHeadquarters"
    /// <summary>
    ///   <para>rdfs:label : Name</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : name</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/name">rdag2:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>skos:scopeNote : FRBR 4.7.1 and FRAD 5.2.</para>
    ///   <para>skos:definition : A word, character, or group of words and/or characters by which a corporate body is known.</para>
    ///   <para>rdfs:label : Name of the corporate body</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : nameOfTheCorporateBody</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/nameOfTheCorporateBody">rdag2:nameOfTheCorporateBody</a>
    /// </summary>
    let nameOfTheCorporateBody = _prefixId.prefix "nameOfTheCorporateBody"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : nameOfTheFamily</para>
    ///   <para>rdfs:label : Name of the family</para>
    ///   <para>skos:definition : A word, character, or group of words and/or characters by which a family is known.</para>
    ///   <para>skos:scopeNote : FRAD 5.2.</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/nameOfTheFamily">rdag2:nameOfTheFamily</a>
    /// </summary>
    let nameOfTheFamily = _prefixId.prefix "nameOfTheFamily"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : nameOfThePerson</para>
    ///   <para>rdfs:label : Name of the person</para>
    ///   <para>skos:definition : A word, character, or group of words and/or characters by which a person is known.</para>
    ///   <para>skos:scopeNote : FRBR 4.6.1 and FRAD 5.2.</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/nameOfThePerson">rdag2:nameOfThePerson</a>
    /// </summary>
    let nameOfThePerson = _prefixId.prefix "nameOfThePerson"
    /// <summary>
    ///   <para>skos:definition : An annotation providing additional information relating to data recorded in another element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : note</para>
    ///   <para>rdfs:label : Note</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/note">rdag2:note</a>
    /// </summary>
    let note = _prefixId.prefix "note"
    /// <summary>
    ///   <para>skos:definition : A designation of the sequencing of a conference, etc., within a series of conferences, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : numberOfAConferenceEtc</para>
    ///   <para>rdfs:label : Number of a conference, etc.</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/numberOfAConferenceEtc">rdag2:numberOfAConferenceEtc</a>
    /// </summary>
    let numberOfAConferenceEtc = _prefixId.prefix "numberOfAConferenceEtc"

    /// <summary>
    ///   <para>skos:scopeNote : FRBR 4.7.2, 4.7.5 and FRAD 4.3.</para>
    ///   <para>skos:definition : A word, phrase, or abbreviation indicating incorporation or legal status of a corporate body, or any term serving to differentiate the body from other corporate bodies, persons, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : otherDesignationAssociatedWithTheCorporateBody</para>
    ///   <para>rdfs:label : Other designation associated with the corporate body</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/otherDesignationAssociatedWithTheCorporateBody">rdag2:otherDesignationAssociatedWithTheCorporateBody</a>
    /// </summary>
    let otherDesignationAssociatedWithTheCorporateBody =
        _prefixId.prefix "otherDesignationAssociatedWithTheCorporateBody"

    /// <summary>
    ///   <para>skos:scopeNote : FRBR 4.6.4 and FRAD 4.1.</para>
    ///   <para>skos:definition : A term other than a title that is associated with a person’s name.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : otherDesignationAssociatedWithThePerson</para>
    ///   <para>rdfs:label : Other designation associated with the person</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/otherDesignationAssociatedWithThePerson">rdag2:otherDesignationAssociatedWithThePerson</a>
    /// </summary>
    let otherDesignationAssociatedWithThePerson =
        _prefixId.prefix "otherDesignationAssociatedWithThePerson"

    /// <summary>
    ///   <para>skos:scopeNote : FRBR 4.6.2 and FRAD 4.1.</para>
    ///   <para>skos:definition : A date or range of dates indicative of the period in which a person was active in his or her primary field of endeavour.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : periodOfActivityOfThePerson</para>
    ///   <para>rdfs:label : Period of activity of the person</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/periodOfActivityOfThePerson">rdag2:periodOfActivityOfThePerson</a>
    /// </summary>
    let periodOfActivityOfThePerson = _prefixId.prefix "periodOfActivityOfThePerson"

    /// <summary>
    ///   <para>rdfs:label : Place associated with the corporate body</para>
    ///   <para>skos:definition : A significant location associated with a corporate body (e.g., location of a conference, etc., location of the headquarters of an
    /// organization).</para>
    ///   <para>skos:scopeNote : FRBR 4.7.3 and FRAD 4.3.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeAssociatedWithTheCorporateBody</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/placeAssociatedWithTheCorporateBody">rdag2:placeAssociatedWithTheCorporateBody</a>
    /// </summary>
    let placeAssociatedWithTheCorporateBody =
        _prefixId.prefix "placeAssociatedWithTheCorporateBody"

    /// <summary>
    ///   <para>skos:scopeNote : FRAD 4.2.</para>
    ///   <para>skos:definition : A place where a family resides or has resided or has some connection.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeAssociatedWithTheFamily</para>
    ///   <para>rdfs:label : Place associated with the family</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/placeAssociatedWithTheFamily">rdag2:placeAssociatedWithTheFamily</a>
    /// </summary>
    let placeAssociatedWithTheFamily = _prefixId.prefix "placeAssociatedWithTheFamily"
    /// <summary>
    ///   <para>skos:scopeNote : FRAD 4.1.</para>
    ///   <para>skos:definition : The town, city, province, state, and/or country in which a person was born.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeOfBirth</para>
    ///   <para>rdfs:label : Place of birth</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/placeOfBirth">rdag2:placeOfBirth</a>
    /// </summary>
    let placeOfBirth = _prefixId.prefix "placeOfBirth"
    /// <summary>
    ///   <para>skos:scopeNote : FRAD 4.1.</para>
    ///   <para>skos:definition : The town, city, province, state, and/or country in which a person died.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeOfDeath</para>
    ///   <para>rdfs:label : Place of death</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/placeOfDeath">rdag2:placeOfDeath</a>
    /// </summary>
    let placeOfDeath = _prefixId.prefix "placeOfDeath"
    /// <summary>
    ///   <para>skos:scopeNote : FRAD 4.1.</para>
    ///   <para>skos:definition : A town, city, province, state, and/or country in which a person resides or has resided.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeOfResidence</para>
    ///   <para>rdfs:label : Place of residence</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/placeOfResidence">rdag2:placeOfResidence</a>
    /// </summary>
    let placeOfResidence = _prefixId.prefix "placeOfResidence"

    /// <summary>
    ///   <para>skos:scopeNote : FRBR 4.6.1 and FRAD 5.2.</para>
    ///   <para>skos:definition : The name or form of name chosen as the basis for the authorized access point representing that body.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : preferredNameForTheCorporateBody</para>
    ///   <para>rdfs:label : Preferred name for the corporate body</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/preferredNameForTheCorporateBody">rdag2:preferredNameForTheCorporateBody</a>
    /// </summary>
    let preferredNameForTheCorporateBody =
        _prefixId.prefix "preferredNameForTheCorporateBody"

    /// <summary>
    ///   <para>skos:scopeNote : FRAD 5.2.</para>
    ///   <para>skos:definition : The name or form of name chosen as the basis for the authorized access point representing that family.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : preferredNameForTheFamily</para>
    ///   <para>rdfs:label : Preferred name for the family</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/preferredNameForTheFamily">rdag2:preferredNameForTheFamily</a>
    /// </summary>
    let preferredNameForTheFamily = _prefixId.prefix "preferredNameForTheFamily"
    /// <summary>
    ///   <para>skos:scopeNote : FRBR 4.6.1 and FRAD 5.2.</para>
    ///   <para>skos:definition : The name or form of name chosen as the basis for the authorized access point representing that person.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : preferredNameForThePerson</para>
    ///   <para>rdfs:label : Preferred name for the person</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/preferredNameForThePerson">rdag2:preferredNameForThePerson</a>
    /// </summary>
    let preferredNameForThePerson = _prefixId.prefix "preferredNameForThePerson"
    /// <summary>
    ///   <para>skos:scopeNote : FRAD 4.1.</para>
    ///   <para>skos:definition : A profession or occupation in which a person works or has worked.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : professionOrOccupation</para>
    ///   <para>rdfs:label : Profession or occupation</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/professionOrOccupation">rdag2:professionOrOccupation</a>
    /// </summary>
    let professionOrOccupation = _prefixId.prefix "professionOrOccupation"
    /// <summary>
    ///   <para>skos:scopeNote : FRAD 4.2.</para>
    ///   <para>skos:definition : A well-known individual who is a member of a family.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : prominentMemberOfTheFamily</para>
    ///   <para>rdfs:label : Prominent member of the family</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/prominentMemberOfTheFamily">rdag2:prominentMemberOfTheFamily</a>
    /// </summary>
    let prominentMemberOfTheFamily = _prefixId.prefix "prominentMemberOfTheFamily"
    /// <summary>
    ///   <para>skos:definition : The type or form of work associated with the name designated as the preferred name for a person, family, or corporate body.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : scopeOfUsage</para>
    ///   <para>rdfs:label : Scope of usage</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/scopeOfUsage">rdag2:scopeOfUsage</a>
    /// </summary>
    let scopeOfUsage = _prefixId.prefix "scopeOfUsage"
    /// <summary>
    ///   <para>skos:definition : A resource used in determining the name, title,or other identifying attributes of an entity, or in determining the relationship between entities.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sourceConsulted</para>
    ///   <para>rdfs:label : Source consulted</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/sourceConsulted">rdag2:sourceConsulted</a>
    /// </summary>
    let sourceConsulted = _prefixId.prefix "sourceConsulted"
    /// <summary>
    ///   <para>skos:definition : An indication of the level of authentication of the data identifying an entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : statusOfIdentification</para>
    ///   <para>rdfs:label : Status of identification</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/statusOfIdentification">rdag2:statusOfIdentification</a>
    /// </summary>
    let statusOfIdentification = _prefixId.prefix "statusOfIdentification"
    /// <summary>
    ///   <para>skos:scopeNote : FRBR 4.6.3 and FRAD 4.1.</para>
    ///   <para>skos:definition : A word or phrase indicative of royalty, nobility, or ecclesiastical rank or office, or a term of address for a person of religious vocation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : titleOfThePerson</para>
    ///   <para>rdfs:label : Title of the person</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/titleOfThePerson">rdag2:titleOfThePerson</a>
    /// </summary>
    let titleOfThePerson = _prefixId.prefix "titleOfThePerson"
    /// <summary>
    ///   <para>skos:definition : A categorization or generic descriptor for the type of family.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : typeOfFamily</para>
    ///   <para>rdfs:label : Type of family</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/typeOfFamily">rdag2:typeOfFamily</a>
    /// </summary>
    let typeOfFamily = _prefixId.prefix "typeOfFamily"
    /// <summary>
    ///   <para>skos:definition : A categorization indicating that the core elements recorded are insufficient to differentiate between two or more entities with the same name.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : undifferentiatedNameIndicator</para>
    ///   <para>rdfs:label : Undifferentiated name indicator</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/undifferentiatedNameIndicator">rdag2:undifferentiatedNameIndicator</a>
    /// </summary>
    let undifferentiatedNameIndicator = _prefixId.prefix "undifferentiatedNameIndicator"

    /// <summary>
    ///   <para>skos:definition : A categorization indicating that the core elements recorded are insufficient to differentiate between two or more corporate bodies with the same name.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : undifferentiatedNameIndicatorCorporateBody</para>
    ///   <para>rdfs:label : Undifferentiated name indicator (Corporate Body)</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/undifferentiatedNameIndicatorCorporateBody">rdag2:undifferentiatedNameIndicatorCorporateBody</a>
    /// </summary>
    let undifferentiatedNameIndicatorCorporateBody =
        _prefixId.prefix "undifferentiatedNameIndicatorCorporateBody"

    /// <summary>
    ///   <para>skos:definition : A categorization indicating that the core elements recorded are insufficient to differentiate between two or more families with the same name.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : undifferentiatedNameIndicatorFamily</para>
    ///   <para>rdfs:label : Undifferentiated name indicator (Family)</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/undifferentiatedNameIndicatorFamily">rdag2:undifferentiatedNameIndicatorFamily</a>
    /// </summary>
    let undifferentiatedNameIndicatorFamily =
        _prefixId.prefix "undifferentiatedNameIndicatorFamily"

    /// <summary>
    ///   <para>skos:definition : A categorization indicating that the core elements recorded are insufficient to differentiate between two or more persons with the same name.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : undifferentiatedNameIndicatorPerson</para>
    ///   <para>rdfs:label : Undifferentiated name indicator (Person)</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/undifferentiatedNameIndicatorPerson">rdag2:undifferentiatedNameIndicatorPerson</a>
    /// </summary>
    let undifferentiatedNameIndicatorPerson =
        _prefixId.prefix "undifferentiatedNameIndicatorPerson"

    /// <summary>
    ///   <para>skos:definition : A name or form of name by which a corporate body is known that differs from the name or form of name chosen as the preferred
    /// name.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : variantNameForTheCorporateBody</para>
    ///   <para>rdfs:label : Variant name for the corporate body</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/variantNameForTheCorporateBody">rdag2:variantNameForTheCorporateBody</a>
    /// </summary>
    let variantNameForTheCorporateBody =
        _prefixId.prefix "variantNameForTheCorporateBody"

    /// <summary>
    ///   <para>skos:definition : A name or form of name by which a family is known that differs from the name or form of name chosen as the preferred name.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : variantNameForTheFamily</para>
    ///   <para>rdfs:label : Variant name for the family</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/variantNameForTheFamily">rdag2:variantNameForTheFamily</a>
    /// </summary>
    let variantNameForTheFamily = _prefixId.prefix "variantNameForTheFamily"
    /// <summary>
    ///   <para>skos:definition : A name or form of name by which a person is known that differs from the name or form of name chosen as the preferred name.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : variantNameForThePerson</para>
    ///   <para>rdfs:label : Variant name for the person</para>
    ///   <a href="http://rdvocab.info/ElementsGr2/variantNameForThePerson">rdag2:variantNameForThePerson</a>
    /// </summary>
    let variantNameForThePerson = _prefixId.prefix "variantNameForThePerson"

namespace http.rdvocab.info.ElementsGr2.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rdag2 =
    let _namespace_iri = Namespace_Iri rdag2 |> NamespaceIRI
    /// <summary>
    ///   <para>rdag2:addressOfThePerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Address of the person</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/addressOfThePerson">http://rdvocab.info/ElementsGr2/addressOfThePerson</seealso>
    let addressOfThePerson = Prefixed_Name(rdag2, "addressOfThePerson") |> PrefixedName
    /// <summary>
    ///   <para>rdag2:cataloguersNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Cataloguer's note</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/cataloguersNote">http://rdvocab.info/ElementsGr2/cataloguersNote</seealso>
    let cataloguersNote = Prefixed_Name(rdag2, "cataloguersNote") |> PrefixedName
    /// <summary>
    ///   <para>rdag2:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Name</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/name">http://rdvocab.info/ElementsGr2/name</seealso>
    let name = Prefixed_Name(rdag2, "name") |> PrefixedName
    /// <summary>
    ///   <para>rdag2:corporateHistory</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Corporate history</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/corporateHistory">http://rdvocab.info/ElementsGr2/corporateHistory</seealso>
    let corporateHistory = Prefixed_Name(rdag2, "corporateHistory") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:languageOfTheCorporateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Language of the corporate body</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/languageOfTheCorporateBody">http://rdvocab.info/ElementsGr2/languageOfTheCorporateBody</seealso>
    let languageOfTheCorporateBody =
        Prefixed_Name(rdag2, "languageOfTheCorporateBody") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:languageOfThePerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Language of the person</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/languageOfThePerson">http://rdvocab.info/ElementsGr2/languageOfThePerson</seealso>
    let languageOfThePerson =
        Prefixed_Name(rdag2, "languageOfThePerson") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:placeAssociatedWithTheCorporateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Place associated with the corporate body</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/placeAssociatedWithTheCorporateBody">http://rdvocab.info/ElementsGr2/placeAssociatedWithTheCorporateBody</seealso>
    let placeAssociatedWithTheCorporateBody =
        Prefixed_Name(rdag2, "placeAssociatedWithTheCorporateBody") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:statusOfIdentification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Status of identification</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/statusOfIdentification">http://rdvocab.info/ElementsGr2/statusOfIdentification</seealso>
    let statusOfIdentification =
        Prefixed_Name(rdag2, "statusOfIdentification") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:sourceConsulted</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Source consulted</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/sourceConsulted">http://rdvocab.info/ElementsGr2/sourceConsulted</seealso>
    let sourceConsulted = Prefixed_Name(rdag2, "sourceConsulted") |> PrefixedName
    /// <summary>
    ///   <para>rdag2:nameOfTheFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Name of the family</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/nameOfTheFamily">http://rdvocab.info/ElementsGr2/nameOfTheFamily</seealso>
    let nameOfTheFamily = Prefixed_Name(rdag2, "nameOfTheFamily") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:preferredNameForTheFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Preferred name for the family</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/preferredNameForTheFamily">http://rdvocab.info/ElementsGr2/preferredNameForTheFamily</seealso>
    let preferredNameForTheFamily =
        Prefixed_Name(rdag2, "preferredNameForTheFamily") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:variantNameForTheFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Variant name for the family</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/variantNameForTheFamily">http://rdvocab.info/ElementsGr2/variantNameForTheFamily</seealso>
    let variantNameForTheFamily =
        Prefixed_Name(rdag2, "variantNameForTheFamily") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:variantNameForThePerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Variant name for the person</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/variantNameForThePerson">http://rdvocab.info/ElementsGr2/variantNameForThePerson</seealso>
    let variantNameForThePerson =
        Prefixed_Name(rdag2, "variantNameForThePerson") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:dateOfConferenceEtc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Date of conference, etc.</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/dateOfConferenceEtc">http://rdvocab.info/ElementsGr2/dateOfConferenceEtc</seealso>
    let dateOfConferenceEtc =
        Prefixed_Name(rdag2, "dateOfConferenceEtc") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:dateAssociatedWithTheFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Date associated with the family</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/dateAssociatedWithTheFamily">http://rdvocab.info/ElementsGr2/dateAssociatedWithTheFamily</seealso>
    let dateAssociatedWithTheFamily =
        Prefixed_Name(rdag2, "dateAssociatedWithTheFamily") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:placeOfDeath</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Place of death</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/placeOfDeath">http://rdvocab.info/ElementsGr2/placeOfDeath</seealso>
    let placeOfDeath = Prefixed_Name(rdag2, "placeOfDeath") |> PrefixedName
    /// <summary>
    ///   <para>rdag2:placeOfResidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Place of residence</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/placeOfResidence">http://rdvocab.info/ElementsGr2/placeOfResidence</seealso>
    let placeOfResidence = Prefixed_Name(rdag2, "placeOfResidence") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:biographicalInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Biographical information</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/biographicalInformation">http://rdvocab.info/ElementsGr2/biographicalInformation</seealso>
    let biographicalInformation =
        Prefixed_Name(rdag2, "biographicalInformation") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:countryAssociatedWithThePerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Country associated with the person</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/countryAssociatedWithThePerson">http://rdvocab.info/ElementsGr2/countryAssociatedWithThePerson</seealso>
    let countryAssociatedWithThePerson =
        Prefixed_Name(rdag2, "countryAssociatedWithThePerson") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:fullerFormOfNamePerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Fuller form of name (Person)</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/fullerFormOfNamePerson">http://rdvocab.info/ElementsGr2/fullerFormOfNamePerson</seealso>
    let fullerFormOfNamePerson =
        Prefixed_Name(rdag2, "fullerFormOfNamePerson") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:hereditaryTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Hereditary title</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/hereditaryTitle">http://rdvocab.info/ElementsGr2/hereditaryTitle</seealso>
    let hereditaryTitle = Prefixed_Name(rdag2, "hereditaryTitle") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:identifierForThePerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Identifier for the person</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/identifierForThePerson">http://rdvocab.info/ElementsGr2/identifierForThePerson</seealso>
    let identifierForThePerson =
        Prefixed_Name(rdag2, "identifierForThePerson") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:locationOfConferenceEtc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Location of conference, etc.</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/locationOfConferenceEtc">http://rdvocab.info/ElementsGr2/locationOfConferenceEtc</seealso>
    let locationOfConferenceEtc =
        Prefixed_Name(rdag2, "locationOfConferenceEtc") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:locationOfHeadquarters</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Location of headquarters</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/locationOfHeadquarters">http://rdvocab.info/ElementsGr2/locationOfHeadquarters</seealso>
    let locationOfHeadquarters =
        Prefixed_Name(rdag2, "locationOfHeadquarters") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:nameOfTheCorporateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Name of the corporate body</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/nameOfTheCorporateBody">http://rdvocab.info/ElementsGr2/nameOfTheCorporateBody</seealso>
    let nameOfTheCorporateBody =
        Prefixed_Name(rdag2, "nameOfTheCorporateBody") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:preferredNameForTheCorporateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Preferred name for the corporate body</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/preferredNameForTheCorporateBody">http://rdvocab.info/ElementsGr2/preferredNameForTheCorporateBody</seealso>
    let preferredNameForTheCorporateBody =
        Prefixed_Name(rdag2, "preferredNameForTheCorporateBody") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:dateAssociatedWithTheCorporateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Date associated with the corporate body</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/dateAssociatedWithTheCorporateBody">http://rdvocab.info/ElementsGr2/dateAssociatedWithTheCorporateBody</seealso>
    let dateAssociatedWithTheCorporateBody =
        Prefixed_Name(rdag2, "dateAssociatedWithTheCorporateBody") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:dateOfTermination</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Date of termination</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/dateOfTermination">http://rdvocab.info/ElementsGr2/dateOfTermination</seealso>
    let dateOfTermination = Prefixed_Name(rdag2, "dateOfTermination") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:dateOfEstablishment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Date of establishment</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/dateOfEstablishment">http://rdvocab.info/ElementsGr2/dateOfEstablishment</seealso>
    let dateOfEstablishment =
        Prefixed_Name(rdag2, "dateOfEstablishment") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:dateOfBirth</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Date of birth</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/dateOfBirth">http://rdvocab.info/ElementsGr2/dateOfBirth</seealso>
    let dateOfBirth = Prefixed_Name(rdag2, "dateOfBirth") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:DateAssociatedWithThePerson</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/DateAssociatedWithThePerson">http://rdvocab.info/ElementsGr2/DateAssociatedWithThePerson</seealso>
    let DateAssociatedWithThePerson =
        Prefixed_Name(rdag2, "DateAssociatedWithThePerson") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:dateOfUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Date of usage</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/dateOfUsage">http://rdvocab.info/ElementsGr2/dateOfUsage</seealso>
    let dateOfUsage = Prefixed_Name(rdag2, "dateOfUsage") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:fieldOfActivityOfTheCorporateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Field of activity of the corporate body</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/fieldOfActivityOfTheCorporateBody">http://rdvocab.info/ElementsGr2/fieldOfActivityOfTheCorporateBody</seealso>
    let fieldOfActivityOfTheCorporateBody =
        Prefixed_Name(rdag2, "fieldOfActivityOfTheCorporateBody") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:periodOfActivityOfThePerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Period of activity of the person</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/periodOfActivityOfThePerson">http://rdvocab.info/ElementsGr2/periodOfActivityOfThePerson</seealso>
    let periodOfActivityOfThePerson =
        Prefixed_Name(rdag2, "periodOfActivityOfThePerson") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:scopeOfUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Scope of usage</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/scopeOfUsage">http://rdvocab.info/ElementsGr2/scopeOfUsage</seealso>
    let scopeOfUsage = Prefixed_Name(rdag2, "scopeOfUsage") |> PrefixedName
    /// <summary>
    ///   <para>rdag2:familyHistory</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Family history</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/familyHistory">http://rdvocab.info/ElementsGr2/familyHistory</seealso>
    let familyHistory = Prefixed_Name(rdag2, "familyHistory") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:fieldOfActivityOfThePerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Field of activity of the person</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/fieldOfActivityOfThePerson">http://rdvocab.info/ElementsGr2/fieldOfActivityOfThePerson</seealso>
    let fieldOfActivityOfThePerson =
        Prefixed_Name(rdag2, "fieldOfActivityOfThePerson") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:fullerFormOfName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Fuller form of name</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/fullerFormOfName">http://rdvocab.info/ElementsGr2/fullerFormOfName</seealso>
    let fullerFormOfName = Prefixed_Name(rdag2, "fullerFormOfName") |> PrefixedName
    /// <summary>
    ///   <para>rdag2:gender</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Gender</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/gender">http://rdvocab.info/ElementsGr2/gender</seealso>
    let gender = Prefixed_Name(rdag2, "gender") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:identifierForTheCorporateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Identifier for the corporate body</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/identifierForTheCorporateBody">http://rdvocab.info/ElementsGr2/identifierForTheCorporateBody</seealso>
    let identifierForTheCorporateBody =
        Prefixed_Name(rdag2, "identifierForTheCorporateBody") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:identifierForTheFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Identifier for the family</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/identifierForTheFamily">http://rdvocab.info/ElementsGr2/identifierForTheFamily</seealso>
    let identifierForTheFamily =
        Prefixed_Name(rdag2, "identifierForTheFamily") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:variantNameForTheCorporateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Variant name for the corporate body</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/variantNameForTheCorporateBody">http://rdvocab.info/ElementsGr2/variantNameForTheCorporateBody</seealso>
    let variantNameForTheCorporateBody =
        Prefixed_Name(rdag2, "variantNameForTheCorporateBody") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:preferredNameForThePerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Preferred name for the person</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/preferredNameForThePerson">http://rdvocab.info/ElementsGr2/preferredNameForThePerson</seealso>
    let preferredNameForThePerson =
        Prefixed_Name(rdag2, "preferredNameForThePerson") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:numberOfAConferenceEtc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Number of a conference, etc.</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/numberOfAConferenceEtc">http://rdvocab.info/ElementsGr2/numberOfAConferenceEtc</seealso>
    let numberOfAConferenceEtc =
        Prefixed_Name(rdag2, "numberOfAConferenceEtc") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:nameOfThePerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Name of the person</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/nameOfThePerson">http://rdvocab.info/ElementsGr2/nameOfThePerson</seealso>
    let nameOfThePerson = Prefixed_Name(rdag2, "nameOfThePerson") |> PrefixedName
    /// <summary>
    ///   <para>rdag2:note</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Note</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/note">http://rdvocab.info/ElementsGr2/note</seealso>
    let note = Prefixed_Name(rdag2, "note") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:otherDesignationAssociatedWithTheCorporateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Other designation associated with the corporate body</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/otherDesignationAssociatedWithTheCorporateBody">http://rdvocab.info/ElementsGr2/otherDesignationAssociatedWithTheCorporateBody</seealso>
    let otherDesignationAssociatedWithTheCorporateBody =
        Prefixed_Name(rdag2, "otherDesignationAssociatedWithTheCorporateBody") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:placeAssociatedWithTheFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Place associated with the family</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/placeAssociatedWithTheFamily">http://rdvocab.info/ElementsGr2/placeAssociatedWithTheFamily</seealso>
    let placeAssociatedWithTheFamily =
        Prefixed_Name(rdag2, "placeAssociatedWithTheFamily") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:placeOfBirth</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Place of birth</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/placeOfBirth">http://rdvocab.info/ElementsGr2/placeOfBirth</seealso>
    let placeOfBirth = Prefixed_Name(rdag2, "placeOfBirth") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:professionOrOccupation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Profession or occupation</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/professionOrOccupation">http://rdvocab.info/ElementsGr2/professionOrOccupation</seealso>
    let professionOrOccupation =
        Prefixed_Name(rdag2, "professionOrOccupation") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:prominentMemberOfTheFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Prominent member of the family</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/prominentMemberOfTheFamily">http://rdvocab.info/ElementsGr2/prominentMemberOfTheFamily</seealso>
    let prominentMemberOfTheFamily =
        Prefixed_Name(rdag2, "prominentMemberOfTheFamily") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:titleOfThePerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Title of the person</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/titleOfThePerson">http://rdvocab.info/ElementsGr2/titleOfThePerson</seealso>
    let titleOfThePerson = Prefixed_Name(rdag2, "titleOfThePerson") |> PrefixedName
    /// <summary>
    ///   <para>rdag2:typeOfFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Type of family</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/typeOfFamily">http://rdvocab.info/ElementsGr2/typeOfFamily</seealso>
    let typeOfFamily = Prefixed_Name(rdag2, "typeOfFamily") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:undifferentiatedNameIndicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Undifferentiated name indicator</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/undifferentiatedNameIndicator">http://rdvocab.info/ElementsGr2/undifferentiatedNameIndicator</seealso>
    let undifferentiatedNameIndicator =
        Prefixed_Name(rdag2, "undifferentiatedNameIndicator") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:undifferentiatedNameIndicatorPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Undifferentiated name indicator (Person)</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/undifferentiatedNameIndicatorPerson">http://rdvocab.info/ElementsGr2/undifferentiatedNameIndicatorPerson</seealso>
    let undifferentiatedNameIndicatorPerson =
        Prefixed_Name(rdag2, "undifferentiatedNameIndicatorPerson") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:undifferentiatedNameIndicatorCorporateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Undifferentiated name indicator (Corporate Body)</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/undifferentiatedNameIndicatorCorporateBody">http://rdvocab.info/ElementsGr2/undifferentiatedNameIndicatorCorporateBody</seealso>
    let undifferentiatedNameIndicatorCorporateBody =
        Prefixed_Name(rdag2, "undifferentiatedNameIndicatorCorporateBody") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:undifferentiatedNameIndicatorFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Undifferentiated name indicator (Family)</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/undifferentiatedNameIndicatorFamily">http://rdvocab.info/ElementsGr2/undifferentiatedNameIndicatorFamily</seealso>
    let undifferentiatedNameIndicatorFamily =
        Prefixed_Name(rdag2, "undifferentiatedNameIndicatorFamily") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:otherDesignationAssociatedWithThePerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Other designation associated with the person</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/otherDesignationAssociatedWithThePerson">http://rdvocab.info/ElementsGr2/otherDesignationAssociatedWithThePerson</seealso>
    let otherDesignationAssociatedWithThePerson =
        Prefixed_Name(rdag2, "otherDesignationAssociatedWithThePerson") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:addressOfTheCorporateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Address of the corporate body</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/addressOfTheCorporateBody">http://rdvocab.info/ElementsGr2/addressOfTheCorporateBody</seealso>
    let addressOfTheCorporateBody =
        Prefixed_Name(rdag2, "addressOfTheCorporateBody") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:affiliation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Affiliation</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/affiliation">http://rdvocab.info/ElementsGr2/affiliation</seealso>
    let affiliation = Prefixed_Name(rdag2, "affiliation") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:associatedInstitution</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Associated institution</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/associatedInstitution">http://rdvocab.info/ElementsGr2/associatedInstitution</seealso>
    let associatedInstitution =
        Prefixed_Name(rdag2, "associatedInstitution") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:dateAssociatedWithThePerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Date associated with the person</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/dateAssociatedWithThePerson">http://rdvocab.info/ElementsGr2/dateAssociatedWithThePerson</seealso>
    let dateAssociatedWithThePerson =
        Prefixed_Name(rdag2, "dateAssociatedWithThePerson") |> PrefixedName

    /// <summary>
    ///   <para>rdag2:dateOfDeath</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Date of death</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr2/dateOfDeath">http://rdvocab.info/ElementsGr2/dateOfDeath</seealso>
    let dateOfDeath = Prefixed_Name(rdag2, "dateOfDeath") |> PrefixedName

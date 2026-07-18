namespace http.d_nb.info.standards.elementset.gnd.hash

open DoxAletheia.Rdf_Vocabulary

module gndo =
    let _namespace_name = "http://d-nb.info/standards/elementset/gnd#"

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#listMembers"></see>
    /// </summary>
    let listMembers =
        Namespaced_IRI.parse _namespace_name "listMembers" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#dnbStaff"></see>
    /// </summary>
    let dnbStaff = Namespaced_IRI.parse _namespace_name "dnbStaff" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#alexanderHaffner"></see>
    /// </summary>
    let alexanderHaffner =
        Namespaced_IRI.parse _namespace_name "alexanderHaffner" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#AdministrativeUnit"></see>
    /// </summary>
    let AdministrativeUnit =
        Namespaced_IRI.parse _namespace_name "AdministrativeUnit" |> NamespacedName

    /// <summary>
    /// Expresses the MARC 21 equivalent for this element in the GND MARC
    ///       format.
    /// <see href="http://d-nb.info/standards/elementset/gnd#marc21equivalent"></see></summary>
    let marc21equivalent =
        Namespaced_IRI.parse _namespace_name "marc21equivalent" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#PlaceOrGeographicName"></see>
    /// </summary>
    let PlaceOrGeographicName =
        Namespaced_IRI.parse _namespace_name "PlaceOrGeographicName" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#AuthorityResource"></see>
    /// </summary>
    let AuthorityResource =
        Namespaced_IRI.parse _namespace_name "AuthorityResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#BuildingOrMemorial"></see>
    /// </summary>
    let BuildingOrMemorial =
        Namespaced_IRI.parse _namespace_name "BuildingOrMemorial" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#CharactersOrMorphemes"></see>
    /// </summary>
    let CharactersOrMorphemes =
        Namespaced_IRI.parse _namespace_name "CharactersOrMorphemes" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#SubjectHeading"></see>
    /// </summary>
    let SubjectHeading =
        Namespaced_IRI.parse _namespace_name "SubjectHeading" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#Collection"></see>
    /// </summary>
    let Collection = Namespaced_IRI.parse _namespace_name "Collection" |> NamespacedName
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#Work"></see>
    /// </summary>
    let Work = Namespaced_IRI.parse _namespace_name "Work" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#CollectiveManuscript"></see>
    /// </summary>
    let CollectiveManuscript =
        Namespaced_IRI.parse _namespace_name "CollectiveManuscript" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#CollectivePseudonym"></see>
    /// </summary>
    let CollectivePseudonym =
        Namespaced_IRI.parse _namespace_name "CollectivePseudonym" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#DifferentiatedPerson"></see>
    /// </summary>
    let DifferentiatedPerson =
        Namespaced_IRI.parse _namespace_name "DifferentiatedPerson" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#Company"></see>
    /// </summary>
    let Company = Namespaced_IRI.parse _namespace_name "Company" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#CorporateBody"></see>
    /// </summary>
    let CorporateBody =
        Namespaced_IRI.parse _namespace_name "CorporateBody" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#ConferenceOrEvent"></see>
    /// </summary>
    let ConferenceOrEvent =
        Namespaced_IRI.parse _namespace_name "ConferenceOrEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#Country"></see>
    /// </summary>
    let Country = Namespaced_IRI.parse _namespace_name "Country" |> NamespacedName
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#Person"></see>
    /// </summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#UndifferentiatedPerson"></see>
    /// </summary>
    let UndifferentiatedPerson =
        Namespaced_IRI.parse _namespace_name "UndifferentiatedPerson" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#EarlierNameOfThePerson"></see>
    /// </summary>
    let EarlierNameOfThePerson =
        Namespaced_IRI.parse _namespace_name "EarlierNameOfThePerson" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#VariantNameOfThePerson"></see>
    /// </summary>
    let VariantNameOfThePerson =
        Namespaced_IRI.parse _namespace_name "VariantNameOfThePerson" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#EthnographicName"></see>
    /// </summary>
    let EthnographicName =
        Namespaced_IRI.parse _namespace_name "EthnographicName" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#Expression"></see>
    /// </summary>
    let Expression = Namespaced_IRI.parse _namespace_name "Expression" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#ExtraterrestrialTerritory"></see>
    /// </summary>
    let ExtraterrestrialTerritory =
        Namespaced_IRI.parse _namespace_name "ExtraterrestrialTerritory" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#Family"></see>
    /// </summary>
    let Family = Namespaced_IRI.parse _namespace_name "Family" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#FictiveCorporateBody"></see>
    /// </summary>
    let FictiveCorporateBody =
        Namespaced_IRI.parse _namespace_name "FictiveCorporateBody" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#FictivePlace"></see>
    /// </summary>
    let FictivePlace =
        Namespaced_IRI.parse _namespace_name "FictivePlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#FictiveTerm"></see>
    /// </summary>
    let FictiveTerm =
        Namespaced_IRI.parse _namespace_name "FictiveTerm" |> NamespacedName

    /// <summary>
    /// Use FictiveTerm instead
    /// <see href="http://d-nb.info/standards/elementset/gnd#Fictive_term"></see></summary>
    let Fictive_term =
        Namespaced_IRI.parse _namespace_name "Fictive_term" |> NamespacedName

    /// <summary>
    /// The complete or a fuller form of name of a person, family or corporate body
    /// <see href="http://d-nb.info/standards/elementset/gnd#FullerFormOfNameOfThePerson"></see></summary>
    let FullerFormOfNameOfThePerson =
        Namespaced_IRI.parse _namespace_name "FullerFormOfNameOfThePerson" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#Gods"></see>
    /// </summary>
    let Gods = Namespaced_IRI.parse _namespace_name "Gods" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#GroupOfPersons"></see>
    /// </summary>
    let GroupOfPersons =
        Namespaced_IRI.parse _namespace_name "GroupOfPersons" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#HistoricSingleEventOrEra"></see>
    /// </summary>
    let HistoricSingleEventOrEra =
        Namespaced_IRI.parse _namespace_name "HistoricSingleEventOrEra" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#Language"></see>
    /// </summary>
    let Language = Namespaced_IRI.parse _namespace_name "Language" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#LaterNameOfThePerson"></see>
    /// </summary>
    let LaterNameOfThePerson =
        Namespaced_IRI.parse _namespace_name "LaterNameOfThePerson" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#LiteraryOrLegendaryCharacter"></see>
    /// </summary>
    let LiteraryOrLegendaryCharacter =
        Namespaced_IRI.parse _namespace_name "LiteraryOrLegendaryCharacter" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#Manuscript"></see>
    /// </summary>
    let Manuscript = Namespaced_IRI.parse _namespace_name "Manuscript" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#MeansOfTransportWithIndividualName"></see>
    /// </summary>
    let MeansOfTransportWithIndividualName =
        Namespaced_IRI.parse _namespace_name "MeansOfTransportWithIndividualName" |> NamespacedName

    /// <summary>
    /// Use gndo:MeansOfTransportWithIndividualName
    /// <see href="http://d-nb.info/standards/elementset/gnd#MeansOfTransportWithIndividual_name"></see></summary>
    let MeansOfTransportWithIndividual_name =
        Namespaced_IRI.parse _namespace_name "MeansOfTransportWithIndividual_name" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#MemberState"></see>
    /// </summary>
    let MemberState =
        Namespaced_IRI.parse _namespace_name "MemberState" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#MusicalCorporateBody"></see>
    /// </summary>
    let MusicalCorporateBody =
        Namespaced_IRI.parse _namespace_name "MusicalCorporateBody" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#MusicalWork"></see>
    /// </summary>
    let MusicalWork =
        Namespaced_IRI.parse _namespace_name "MusicalWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#NameOfSmallGeographicUnitLyingWithinAnotherGeographicUnit"></see>
    /// </summary>
    let NameOfSmallGeographicUnitLyingWithinAnotherGeographicUnit =
        Namespaced_IRI.parse _namespace_name "NameOfSmallGeographicUnitLyingWithinAnotherGeographicUnit" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#NameOfThePerson"></see>
    /// </summary>
    let NameOfThePerson =
        Namespaced_IRI.parse _namespace_name "NameOfThePerson" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#NaturalGeographicUnit"></see>
    /// </summary>
    let NaturalGeographicUnit =
        Namespaced_IRI.parse _namespace_name "NaturalGeographicUnit" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#NomenclatureInBiologyOrChemistry"></see>
    /// </summary>
    let NomenclatureInBiologyOrChemistry =
        Namespaced_IRI.parse _namespace_name "NomenclatureInBiologyOrChemistry" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#OrganOfCorporateBody"></see>
    /// </summary>
    let OrganOfCorporateBody =
        Namespaced_IRI.parse _namespace_name "OrganOfCorporateBody" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#PreferredNameOfThePerson"></see>
    /// </summary>
    let PreferredNameOfThePerson =
        Namespaced_IRI.parse _namespace_name "PreferredNameOfThePerson" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#ProductNameOrBrandName"></see>
    /// </summary>
    let ProductNameOrBrandName =
        Namespaced_IRI.parse _namespace_name "ProductNameOrBrandName" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#ProjectOrProgram"></see>
    /// </summary>
    let ProjectOrProgram =
        Namespaced_IRI.parse _namespace_name "ProjectOrProgram" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#ProvenanceCharacteristic"></see>
    /// </summary>
    let ProvenanceCharacteristic =
        Namespaced_IRI.parse _namespace_name "ProvenanceCharacteristic" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#Pseudonym"></see>
    /// </summary>
    let Pseudonym = Namespaced_IRI.parse _namespace_name "Pseudonym" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#PseudonymNameOfThePerson"></see>
    /// </summary>
    let PseudonymNameOfThePerson =
        Namespaced_IRI.parse _namespace_name "PseudonymNameOfThePerson" |> NamespacedName

    /// <summary>
    /// The person’s real name
    /// <see href="http://d-nb.info/standards/elementset/gnd#RealNameOfThePerson"></see></summary>
    let RealNameOfThePerson =
        Namespaced_IRI.parse _namespace_name "RealNameOfThePerson" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#ReligiousAdministrativeUnit"></see>
    /// </summary>
    let ReligiousAdministrativeUnit =
        Namespaced_IRI.parse _namespace_name "ReligiousAdministrativeUnit" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#ReligiousCorporateBody"></see>
    /// </summary>
    let ReligiousCorporateBody =
        Namespaced_IRI.parse _namespace_name "ReligiousCorporateBody" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#ReligiousTerritory"></see>
    /// </summary>
    let ReligiousTerritory =
        Namespaced_IRI.parse _namespace_name "ReligiousTerritory" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#RoyalOrMemberOfARoyalHouse"></see>
    /// </summary>
    let RoyalOrMemberOfARoyalHouse =
        Namespaced_IRI.parse _namespace_name "RoyalOrMemberOfARoyalHouse" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#SeriesOfConferenceOrEvent"></see>
    /// </summary>
    let SeriesOfConferenceOrEvent =
        Namespaced_IRI.parse _namespace_name "SeriesOfConferenceOrEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#SoftwareProduct"></see>
    /// </summary>
    let SoftwareProduct =
        Namespaced_IRI.parse _namespace_name "SoftwareProduct" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#Spirits"></see>
    /// </summary>
    let Spirits = Namespaced_IRI.parse _namespace_name "Spirits" |> NamespacedName

    /// <summary>
    /// Use startingOrFinalPointOfADistance (with a minor s) instead
    /// <see href="http://d-nb.info/standards/elementset/gnd#StartingOrFinalPointOfADistance"></see></summary>
    let StartingOrFinalPointOfADistance =
        Namespaced_IRI.parse _namespace_name "StartingOrFinalPointOfADistance" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#startingOrFinalPointOfADistance"></see>
    /// </summary>
    let startingOrFinalPointOfADistance =
        Namespaced_IRI.parse _namespace_name "startingOrFinalPointOfADistance" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#SubjectHeadingSensoStricto"></see>
    /// </summary>
    let SubjectHeadingSensoStricto =
        Namespaced_IRI.parse _namespace_name "SubjectHeadingSensoStricto" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#TerritorialCorporateBodyOrAdministrativeUnit"></see>
    /// </summary>
    let TerritorialCorporateBodyOrAdministrativeUnit =
        Namespaced_IRI.parse _namespace_name "TerritorialCorporateBodyOrAdministrativeUnit" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#VersionOfAMusicalWork"></see>
    /// </summary>
    let VersionOfAMusicalWork =
        Namespaced_IRI.parse _namespace_name "VersionOfAMusicalWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#WayBorderOrLine"></see>
    /// </summary>
    let WayBorderOrLine =
        Namespaced_IRI.parse _namespace_name "WayBorderOrLine" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#abbreviatedNameForTheConferenceOrEvent"></see>
    /// </summary>
    let abbreviatedNameForTheConferenceOrEvent =
        Namespaced_IRI.parse _namespace_name "abbreviatedNameForTheConferenceOrEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#variantNameForTheConferenceOrEvent"></see>
    /// </summary>
    let variantNameForTheConferenceOrEvent =
        Namespaced_IRI.parse _namespace_name "variantNameForTheConferenceOrEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#abbreviatedNameForTheCorporateBody"></see>
    /// </summary>
    let abbreviatedNameForTheCorporateBody =
        Namespaced_IRI.parse _namespace_name "abbreviatedNameForTheCorporateBody" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#variantNameForTheCorporateBody"></see>
    /// </summary>
    let variantNameForTheCorporateBody =
        Namespaced_IRI.parse _namespace_name "variantNameForTheCorporateBody" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#abbreviatedNameForThePlaceOrGeographicName"></see>
    /// </summary>
    let abbreviatedNameForThePlaceOrGeographicName =
        Namespaced_IRI.parse _namespace_name "abbreviatedNameForThePlaceOrGeographicName" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#variantNameForThePlaceOrGeographicName"></see>
    /// </summary>
    let variantNameForThePlaceOrGeographicName =
        Namespaced_IRI.parse _namespace_name "variantNameForThePlaceOrGeographicName" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#abbreviatedNameForTheWork"></see>
    /// </summary>
    let abbreviatedNameForTheWork =
        Namespaced_IRI.parse _namespace_name "abbreviatedNameForTheWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#variantNameForTheWork"></see>
    /// </summary>
    let variantNameForTheWork =
        Namespaced_IRI.parse _namespace_name "variantNameForTheWork" |> NamespacedName

    /// <summary>
    /// An academic degree.
    /// <see href="http://d-nb.info/standards/elementset/gnd#academicDegree"></see></summary>
    let academicDegree =
        Namespaced_IRI.parse _namespace_name "academicDegree" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#accordingWork"></see>
    /// </summary>
    let accordingWork =
        Namespaced_IRI.parse _namespace_name "accordingWork" |> NamespacedName

    /// <summary>
    /// An author, artist, etc., relating him/her to a resource for which there is or once was substantial authority for designating that person as author, creator, etc. of the work
    /// <see href="http://d-nb.info/standards/elementset/gnd#accreditedArtist"></see></summary>
    let accreditedArtist =
        Namespaced_IRI.parse _namespace_name "accreditedArtist" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#artist"></see>
    /// </summary>
    let artist = Namespaced_IRI.parse _namespace_name "artist" |> NamespacedName

    /// <summary>
    /// An author, artist, etc., relating him/her to a resource for which there is or once was substantial authority for designating that person as author, creator, etc. of the work
    /// <see href="http://d-nb.info/standards/elementset/gnd#accreditedAuthor"></see></summary>
    let accreditedAuthor =
        Namespaced_IRI.parse _namespace_name "accreditedAuthor" |> NamespacedName

    /// <summary>
    /// A person, family, or organization responsible for creating a work that is primarily textual in content, regardless of media type (e.g., printed text, spoken word, electronic text, tactile text) or genre (e.g., poems, novels, screenplays, blogs). Use also for persons, etc., creating a new work by paraphrasing, rewriting, or adapting works by another creator such that the modification has substantially changed the nature and content of the original or changed the medium of expression
    /// <see href="http://d-nb.info/standards/elementset/gnd#author"></see></summary>
    let author = Namespaced_IRI.parse _namespace_name "author" |> NamespacedName

    /// <summary>
    /// An author, artist, etc., relating him/her to a resource for which there is or once was substantial authority for designating that person as author, creator, etc. of the work
    /// <see href="http://d-nb.info/standards/elementset/gnd#accreditedComposer"></see></summary>
    let accreditedComposer =
        Namespaced_IRI.parse _namespace_name "accreditedComposer" |> NamespacedName

    /// <summary>
    /// A person, family, or organization responsible for creating or contributing to a musical resource by adding music to a work that originally lacked it or supplements it
    /// <see href="http://d-nb.info/standards/elementset/gnd#composer"></see></summary>
    let composer = Namespaced_IRI.parse _namespace_name "composer" |> NamespacedName

    /// <summary>
    /// Relationship between a person, family, or corporate body and another person, family, or corporate body which cannot be specified more closely
    /// <see href="http://d-nb.info/standards/elementset/gnd#acquaintanceshipOrFriendship"></see></summary>
    let acquaintanceshipOrFriendship =
        Namespaced_IRI.parse _namespace_name "acquaintanceshipOrFriendship" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#memberOfTheFamily"></see>
    /// </summary>
    let memberOfTheFamily =
        Namespaced_IRI.parse _namespace_name "memberOfTheFamily" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#addition"></see>
    /// </summary>
    let addition = Namespaced_IRI.parse _namespace_name "addition" |> NamespacedName
    /// <summary>
    /// A person, family, or organization to whom the correspondence in a work is addressed.
    /// <see href="http://d-nb.info/standards/elementset/gnd#addressee"></see></summary>
    let addressee = Namespaced_IRI.parse _namespace_name "addressee" |> NamespacedName

    /// <summary>
    /// A corporate body associated with a person or group of persons.
    /// <see href="http://d-nb.info/standards/elementset/gnd#affiliation"></see></summary>
    let affiliation =
        Namespaced_IRI.parse _namespace_name "affiliation" |> NamespacedName

    /// <summary>
    /// A corporate body associated with a person or group of persons.
    /// 		This property is equivalent to gndo:affiliation but gives a literal instead of
    /// 		a URI.
    /// <see href="http://d-nb.info/standards/elementset/gnd#affiliationAsLiteral"></see></summary>
    let affiliationAsLiteral =
        Namespaced_IRI.parse _namespace_name "affiliationAsLiteral" |> NamespacedName

    /// <summary>
    /// A person who makes manuscript annotations on an item.
    /// <see href="http://d-nb.info/standards/elementset/gnd#annotator"></see></summary>
    let annotator = Namespaced_IRI.parse _namespace_name "annotator" |> NamespacedName
    /// <summary>
    /// A person, family, or organization responsible for creating an
    /// 		architectural design, including a pictorial representation intended to show how a building,
    /// 		etc., will look when completed. It also oversees the construction of structures.
    /// <see href="http://d-nb.info/standards/elementset/gnd#architect"></see></summary>
    let architect = Namespaced_IRI.parse _namespace_name "architect" |> NamespacedName
    /// <summary>
    /// A person, family, or organization contributing to a musical
    /// 		work by rewriting the composition for a medium of performance different from that
    /// 		for which the work was originally intended, or modifying the work for the same
    /// 		medium of performance, etc., such that the musical substance of the original
    /// 		composition remains essentially unchanged. For extensive modification that effectively
    /// 		results in the creation of a new musical work, see composer.
    /// <see href="http://d-nb.info/standards/elementset/gnd#arranger"></see></summary>
    let arranger = Namespaced_IRI.parse _namespace_name "arranger" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#associatedDate"></see>
    /// </summary>
    let associatedDate =
        Namespaced_IRI.parse _namespace_name "associatedDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#associatedPlace"></see>
    /// </summary>
    let associatedPlace =
        Namespaced_IRI.parse _namespace_name "associatedPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#beginningOfPeriod"></see>
    /// </summary>
    let beginningOfPeriod =
        Namespaced_IRI.parse _namespace_name "beginningOfPeriod" |> NamespacedName

    /// <summary>
    /// A person, family, or corporate body being the benefactor of a work, a thing, or a corporate body
    /// <see href="http://d-nb.info/standards/elementset/gnd#benefactor"></see></summary>
    let benefactor = Namespaced_IRI.parse _namespace_name "benefactor" |> NamespacedName

    /// <summary>
    /// Summary of the essential biographical, historical, or other
    ///       information about the described entity.
    /// <see href="http://d-nb.info/standards/elementset/gnd#biographicalOrHistoricalInformation"></see></summary>
    let biographicalOrHistoricalInformation =
        Namespaced_IRI.parse _namespace_name "biographicalOrHistoricalInformation" |> NamespacedName

    /// <summary>
    /// P1 gnd:superPropertyOf P2 states that P2 is a subproperty of P1. The
    ///       gndo:superPropertyOf property is transitive.
    /// <see href="http://d-nb.info/standards/elementset/gnd#superPropertyOf"></see></summary>
    let superPropertyOf =
        Namespaced_IRI.parse _namespace_name "superPropertyOf" |> NamespacedName

    /// <summary>
    /// A person who binds an item
    /// <see href="http://d-nb.info/standards/elementset/gnd#bookbinder"></see></summary>
    let bookbinder = Namespaced_IRI.parse _namespace_name "bookbinder" |> NamespacedName

    /// <summary>
    /// A person or organization involved in manufacturing a manifestation by being responsible for the entire graphic design of a book, including arrangement of type and illustration, choice of materials, and process used
    /// <see href="http://d-nb.info/standards/elementset/gnd#bookdesigner"></see></summary>
    let bookdesigner =
        Namespaced_IRI.parse _namespace_name "bookdesigner" |> NamespacedName

    /// <summary>
    /// Use broader term general instead
    /// <see href="http://d-nb.info/standards/elementset/gnd#broaderTerm"></see></summary>
    let broaderTerm =
        Namespaced_IRI.parse _namespace_name "broaderTerm" |> NamespacedName

    /// <summary>
    /// Broader term
    /// <see href="http://d-nb.info/standards/elementset/gnd#broaderTermGeneral"></see></summary>
    let broaderTermGeneral =
        Namespaced_IRI.parse _namespace_name "broaderTermGeneral" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#narrowerTermGeneral"></see>
    /// </summary>
    let narrowerTermGeneral =
        Namespaced_IRI.parse _namespace_name "narrowerTermGeneral" |> NamespacedName

    /// <summary>
    /// The generic relation is a semantic relation between two concepts
    ///       where the intension of one of the concepts includes that of the other concepts and at least
    ///       one additional delimiting characteristic is added.
    /// <see href="http://d-nb.info/standards/elementset/gnd#broaderTermGeneric"></see></summary>
    let broaderTermGeneric =
        Namespaced_IRI.parse _namespace_name "broaderTermGeneric" |> NamespacedName

    /// <summary>
    /// The generic relation is a semantic relation between two concepts
    ///       where the intension of one of the concepts includes that of the other concepts and at least
    ///       one additional delimiting characteristic is added.
    /// <see href="http://d-nb.info/standards/elementset/gnd#narrowerTermGeneric"></see></summary>
    let narrowerTermGeneric =
        Namespaced_IRI.parse _namespace_name "narrowerTermGeneric" |> NamespacedName

    /// <summary>
    /// The instance relationship links a general concept such as a class of
    ///       things or events, and an individual instance oft hat class, which is often represented by a
    ///       proper name.
    /// <see href="http://d-nb.info/standards/elementset/gnd#broaderTermInstantial"></see></summary>
    let broaderTermInstantial =
        Namespaced_IRI.parse _namespace_name "broaderTermInstantial" |> NamespacedName

    /// <summary>
    /// The instance relationship links a general concept such as a class of
    ///       things or events, and an individual instance oft hat class, which is often represented by a
    ///       proper name.
    /// <see href="http://d-nb.info/standards/elementset/gnd#narrowerTermInstantial"></see></summary>
    let narrowerTermInstantial =
        Namespaced_IRI.parse _namespace_name "narrowerTermInstantial" |> NamespacedName

    /// <summary>
    /// The hierarchical whole-part relationship covers a limited range of
    ///       situations in which a part of an entity or system belongs uniquely to a particular possessing
    ///       whole. When applied to persons, this is the relation between a single person (particularly gods)
    /// 	  and hierarchically broader groups of gods and mythologic entities.
    /// <see href="http://d-nb.info/standards/elementset/gnd#broaderTermPartitive"></see></summary>
    let broaderTermPartitive =
        Namespaced_IRI.parse _namespace_name "broaderTermPartitive" |> NamespacedName

    /// <summary>
    /// The hierarchical whole-part relationship covers a limited range of
    ///       situations in which a part of an entity or system belongs uniquely to a particular possessing
    ///       whole. When applied to persons, this is the relation between a single person (particularly gods)
    /// 	  and hierarchically superior groups of gods and mythologic entities.
    /// <see href="http://d-nb.info/standards/elementset/gnd#narrowerTermPartitive"></see></summary>
    let narrowerTermPartitive =
        Namespaced_IRI.parse _namespace_name "narrowerTermPartitive" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#broaderTermWithMoreThanOneElement"></see>
    /// </summary>
    let broaderTermWithMoreThanOneElement =
        Namespaced_IRI.parse _namespace_name "broaderTermWithMoreThanOneElement" |> NamespacedName

    /// <summary>
    /// Use gndo:broaderTermGeneral instead
    /// <see href="http://d-nb.info/standards/elementset/gnd#broderTermGeneral"></see></summary>
    let broderTermGeneral =
        Namespaced_IRI.parse _namespace_name "broderTermGeneral" |> NamespacedName

    /// <summary>
    /// A person, family, or corporate body in charge of financing and constructing a building
    /// <see href="http://d-nb.info/standards/elementset/gnd#buildingOwner"></see></summary>
    let buildingOwner =
        Namespaced_IRI.parse _namespace_name "buildingOwner" |> NamespacedName

    /// <summary>
    /// A person, family, or organization responsible for creating a map, atlas, globe, or other cartographic work
    /// <see href="http://d-nb.info/standards/elementset/gnd#cartographer"></see></summary>
    let cartographer =
        Namespaced_IRI.parse _namespace_name "cartographer" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#celebratedCorporateBody"></see>
    /// </summary>
    let celebratedCorporateBody =
        Namespaced_IRI.parse _namespace_name "celebratedCorporateBody" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#celebratedFamily"></see>
    /// </summary>
    let celebratedFamily =
        Namespaced_IRI.parse _namespace_name "celebratedFamily" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#celebratedPerson"></see>
    /// </summary>
    let celebratedPerson =
        Namespaced_IRI.parse _namespace_name "celebratedPerson" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#celebratedTopic"></see>
    /// </summary>
    let celebratedTopic =
        Namespaced_IRI.parse _namespace_name "celebratedTopic" |> NamespacedName

    /// <summary>
    /// A significant place for a person or family
    /// <see href="http://d-nb.info/standards/elementset/gnd#characteristicPlace"></see></summary>
    let characteristicPlace =
        Namespaced_IRI.parse _namespace_name "characteristicPlace" |> NamespacedName

    /// <summary>
    /// A person responsible for creating or contributing to a work of movement
    /// <see href="http://d-nb.info/standards/elementset/gnd#choreographer"></see></summary>
    let choreographer =
        Namespaced_IRI.parse _namespace_name "choreographer" |> NamespacedName

    /// <summary>
    /// A person or organization whose work is largely quoted or extracted in works to which he or she did not contribute directly. Such quotations are found particularly in exhibition catalogs, collections of photographs, etc.
    /// <see href="http://d-nb.info/standards/elementset/gnd#citedArtist"></see></summary>
    let citedArtist =
        Namespaced_IRI.parse _namespace_name "citedArtist" |> NamespacedName

    /// <summary>
    /// A person or organization whose work is largely quoted or extracted in works to which he or she did not contribute directly. Such quotations are found particularly in exhibition catalogs, collections of photographs, etc.
    /// <see href="http://d-nb.info/standards/elementset/gnd#citedAuthor"></see></summary>
    let citedAuthor =
        Namespaced_IRI.parse _namespace_name "citedAuthor" |> NamespacedName

    /// <summary>
    /// A person or organization whose work is largely quoted or extracted in works to which he or she did not contribute directly. Such quotations are found particularly in exhibition catalogs, collections of photographs, etc.
    /// <see href="http://d-nb.info/standards/elementset/gnd#citedComposer"></see></summary>
    let citedComposer =
        Namespaced_IRI.parse _namespace_name "citedComposer" |> NamespacedName

    /// <summary>
    /// A curator who brings together items from various sources that are then arranged, described, and cataloged as a collection. A collector is neither the creator of the material nor a person to whom manuscripts in the collection may have been addressed
    /// <see href="http://d-nb.info/standards/elementset/gnd#collector"></see></summary>
    let collector = Namespaced_IRI.parse _namespace_name "collector" |> NamespacedName
    /// <summary>
    /// A person, family, or organization responsible for creating a new work (e.g., a bibliography, a directory) through the act of compilation, e.g., selecting, arranging, aggregating, and editing data, information, etc
    /// <see href="http://d-nb.info/standards/elementset/gnd#compiler"></see></summary>
    let compiler = Namespaced_IRI.parse _namespace_name "compiler" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#complexSeeReferenceSubject"></see>
    /// </summary>
    let complexSeeReferenceSubject =
        Namespaced_IRI.parse _namespace_name "complexSeeReferenceSubject" |> NamespacedName

    /// <summary>
    /// A person or organization permitting the temporary use of a book, manuscript, etc., such as for photocopying or microfilming
    /// <see href="http://d-nb.info/standards/elementset/gnd#conferrer"></see></summary>
    let conferrer = Namespaced_IRI.parse _namespace_name "conferrer" |> NamespacedName

    /// <summary>
    /// Use contributingFamily instead.
    /// <see href="http://d-nb.info/standards/elementset/gnd#contributinFamily"></see></summary>
    let contributinFamily =
        Namespaced_IRI.parse _namespace_name "contributinFamily" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#contributingFamily"></see>
    /// </summary>
    let contributingFamily =
        Namespaced_IRI.parse _namespace_name "contributingFamily" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#contributingCorporateBody"></see>
    /// </summary>
    let contributingCorporateBody =
        Namespaced_IRI.parse _namespace_name "contributingCorporateBody" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#contributingPerson"></see>
    /// </summary>
    let contributingPerson =
        Namespaced_IRI.parse _namespace_name "contributingPerson" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#contributingPlaceOrGeographicName"></see>
    /// </summary>
    let contributingPlaceOrGeographicName =
        Namespaced_IRI.parse _namespace_name "contributingPlaceOrGeographicName" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#coordinates"></see>
    /// </summary>
    let coordinates =
        Namespaced_IRI.parse _namespace_name "coordinates" |> NamespacedName

    /// <summary>
    /// A person or family who is known as scribe or copyist.
    /// <see href="http://d-nb.info/standards/elementset/gnd#copist"></see></summary>
    let copist = Namespaced_IRI.parse _namespace_name "copist" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#corporateBodyIsMember"></see>
    /// </summary>
    let corporateBodyIsMember =
        Namespaced_IRI.parse _namespace_name "corporateBodyIsMember" |> NamespacedName

    /// <summary>
    /// A person or family being a member of (another) family
    /// <see href="http://d-nb.info/standards/elementset/gnd#member"></see></summary>
    let member_ = Namespaced_IRI.parse _namespace_name "member" |> NamespacedName

    /// <summary>
    /// A person or organization who was either the writer or recipient of a letter or other communication
    /// <see href="http://d-nb.info/standards/elementset/gnd#correspondent"></see></summary>
    let correspondent =
        Namespaced_IRI.parse _namespace_name "correspondent" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#counting"></see>
    /// </summary>
    let counting = Namespaced_IRI.parse _namespace_name "counting" |> NamespacedName
    /// <summary>
    /// A person or organization performing the work, i.e., the name of a person or organization associated with the intellectual content of the work. This category does not include the publisher or personal affiliation, or sponsor except where it is also the corporate author
    /// <see href="http://d-nb.info/standards/elementset/gnd#creator"></see></summary>
    let creator = Namespaced_IRI.parse _namespace_name "creator" |> NamespacedName
    /// <summary>
    /// A person, family, or organization conceiving, aggregating, and/or organizing an exhibition, collection, or other item
    /// <see href="http://d-nb.info/standards/elementset/gnd#curator"></see></summary>
    let curator = Namespaced_IRI.parse _namespace_name "curator" |> NamespacedName

    /// <summary>
    /// Date of birth and death of a person, years in which a family has been known to exist
    /// <see href="http://d-nb.info/standards/elementset/gnd#dateOfBirth"></see></summary>
    let dateOfBirth =
        Namespaced_IRI.parse _namespace_name "dateOfBirth" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#dateOfBirthAndDeath"></see>
    /// </summary>
    let dateOfBirthAndDeath =
        Namespaced_IRI.parse _namespace_name "dateOfBirthAndDeath" |> NamespacedName

    /// <summary>
    /// Date of a conference
    /// <see href="http://d-nb.info/standards/elementset/gnd#dateOfConferenceOrEvent"></see></summary>
    let dateOfConferenceOrEvent =
        Namespaced_IRI.parse _namespace_name "dateOfConferenceOrEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#dateOfDeath"></see>
    /// </summary>
    let dateOfDeath =
        Namespaced_IRI.parse _namespace_name "dateOfDeath" |> NamespacedName

    /// <summary>
    /// Date or year in which an object was found (not to be used in connection with persons, families and corporate bodies)
    /// <see href="http://d-nb.info/standards/elementset/gnd#dateOfDiscovery"></see></summary>
    let dateOfDiscovery =
        Namespaced_IRI.parse _namespace_name "dateOfDiscovery" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#dateOfEstablishment"></see>
    /// </summary>
    let dateOfEstablishment =
        Namespaced_IRI.parse _namespace_name "dateOfEstablishment" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#dateOfEstablishmentAndTermination"></see>
    /// </summary>
    let dateOfEstablishmentAndTermination =
        Namespaced_IRI.parse _namespace_name "dateOfEstablishmentAndTermination" |> NamespacedName

    /// <summary>
    /// Date (year) in which a written historical document was created or a building constructed
    /// <see href="http://d-nb.info/standards/elementset/gnd#dateOfProduction"></see></summary>
    let dateOfProduction =
        Namespaced_IRI.parse _namespace_name "dateOfProduction" |> NamespacedName

    /// <summary>
    /// Date of publication of the first expression of a work
    /// <see href="http://d-nb.info/standards/elementset/gnd#dateOfPublication"></see></summary>
    let dateOfPublication =
        Namespaced_IRI.parse _namespace_name "dateOfPublication" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#dateOfTermination"></see>
    /// </summary>
    let dateOfTermination =
        Namespaced_IRI.parse _namespace_name "dateOfTermination" |> NamespacedName

    /// <summary>
    /// A person, family, or organization to whom a resource is dedicated
    /// <see href="http://d-nb.info/standards/elementset/gnd#dedicatee"></see></summary>
    let dedicatee = Namespaced_IRI.parse _namespace_name "dedicatee" |> NamespacedName
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#definition"></see>
    /// </summary>
    let definition = Namespaced_IRI.parse _namespace_name "definition" |> NamespacedName
    /// <summary>
    /// A person, family, or organization responsible for creating a design for an object
    /// <see href="http://d-nb.info/standards/elementset/gnd#designer"></see></summary>
    let designer = Namespaced_IRI.parse _namespace_name "designer" |> NamespacedName
    /// <summary>
    /// A person responsible for the general management and supervision of a filmed performance, a radio or television program, etc.
    /// <see href="http://d-nb.info/standards/elementset/gnd#director"></see></summary>
    let director = Namespaced_IRI.parse _namespace_name "director" |> NamespacedName

    /// <summary>
    /// A person in charge of photographing a motion picture, who plans the technical aspets of lighting and photographing of scenes, and often assists the director in the choice of angles, camera setups, and lighting moods. He or she may also supervise the further processing of filmed material up to the completion of the work print. Cinematographer is also referred to as director of photography. Do not confuse with videographer
    /// <see href="http://d-nb.info/standards/elementset/gnd#directorOfPhotography"></see></summary>
    let directorOfPhotography =
        Namespaced_IRI.parse _namespace_name "directorOfPhotography" |> NamespacedName

    /// <summary>
    /// A person or organization to which authorship has been dubiously or incorrectly ascribed
    /// <see href="http://d-nb.info/standards/elementset/gnd#doubtfulArtist"></see></summary>
    let doubtfulArtist =
        Namespaced_IRI.parse _namespace_name "doubtfulArtist" |> NamespacedName

    /// <summary>
    /// A person or organization to which authorship has been dubiously or incorrectly ascribed
    /// <see href="http://d-nb.info/standards/elementset/gnd#doubtfulAuthor"></see></summary>
    let doubtfulAuthor =
        Namespaced_IRI.parse _namespace_name "doubtfulAuthor" |> NamespacedName

    /// <summary>
    /// A person or organization to which authorship has been dubiously or incorrectly ascribed
    /// <see href="http://d-nb.info/standards/elementset/gnd#doubtfulComposer"></see></summary>
    let doubtfulComposer =
        Namespaced_IRI.parse _namespace_name "doubtfulComposer" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#easternmostLongitude"></see>
    /// </summary>
    let easternmostLongitude =
        Namespaced_IRI.parse _namespace_name "easternmostLongitude" |> NamespacedName

    /// <summary>
    /// A person, family, or organization contributing to a resource by revising or elucidating the content, e.g., adding an introduction, notes, or other critical matter. An editor may also prepare a resource for production, publication, or distribution. For major revisions, adaptations, etc., that substantially change the nature and content of the original work, resulting in a new work, see author
    /// <see href="http://d-nb.info/standards/elementset/gnd#editor"></see></summary>
    let editor = Namespaced_IRI.parse _namespace_name "editor" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#endOfPeriod"></see>
    /// </summary>
    let endOfPeriod =
        Namespaced_IRI.parse _namespace_name "endOfPeriod" |> NamespacedName

    /// <summary>
    /// A person or organization who cuts letters, figures, etc. on a surface, such as a wooden or metal plate used for printing
    /// <see href="http://d-nb.info/standards/elementset/gnd#engraver"></see></summary>
    let engraver = Namespaced_IRI.parse _namespace_name "engraver" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#epithetGenericNameTitleOrTerritory"></see>
    /// </summary>
    let epithetGenericNameTitleOrTerritory =
        Namespaced_IRI.parse _namespace_name "epithetGenericNameTitleOrTerritory" |> NamespacedName

    /// <summary>
    /// A person or organization who produces text or images for printing by subjecting metal, glass, or some other surface to acid or the corrosive action of some other substance
    /// <see href="http://d-nb.info/standards/elementset/gnd#etcher"></see></summary>
    let etcher = Namespaced_IRI.parse _namespace_name "etcher" |> NamespacedName
    /// <summary>
    /// A person, family, or corporate body in charge of an exhibition.
    /// <see href="http://d-nb.info/standards/elementset/gnd#exhibitor"></see></summary>
    let exhibitor = Namespaced_IRI.parse _namespace_name "exhibitor" |> NamespacedName

    /// <summary>
    /// A family relationship between a person or family and another person or family
    /// <see href="http://d-nb.info/standards/elementset/gnd#familialRelationship"></see></summary>
    let familialRelationship =
        Namespaced_IRI.parse _namespace_name "familialRelationship" |> NamespacedName

    /// <summary>
    /// A fictitious person, family, or corporate body ascertained to be the author
    /// <see href="http://d-nb.info/standards/elementset/gnd#fictitiousAuthor"></see></summary>
    let fictitiousAuthor =
        Namespaced_IRI.parse _namespace_name "fictitiousAuthor" |> NamespacedName

    /// <summary>
    /// Field of activity of a person, corporate body, conference or event.
    /// <see href="http://d-nb.info/standards/elementset/gnd#fieldOfActivity"></see></summary>
    let fieldOfActivity =
        Namespaced_IRI.parse _namespace_name "fieldOfActivity" |> NamespacedName

    /// <summary>
    /// A person’s field of study
    /// <see href="http://d-nb.info/standards/elementset/gnd#fieldOfStudy"></see></summary>
    let fieldOfStudy =
        Namespaced_IRI.parse _namespace_name "fieldOfStudy" |> NamespacedName

    /// <summary>
    /// A person or organization that takes primary responsibility for a particular activity or endeavor. May be combined with another relator term or code to show the greater importance this person or organization has regarding that particular role. If more than one relator is assigned to a heading, use the Lead relator only if it applies to all the relators
    /// <see href="http://d-nb.info/standards/elementset/gnd#firstArtist"></see></summary>
    let firstArtist =
        Namespaced_IRI.parse _namespace_name "firstArtist" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#firstAuthor"></see>
    /// </summary>
    let firstAuthor =
        Namespaced_IRI.parse _namespace_name "firstAuthor" |> NamespacedName

    /// <summary>
    /// A person or organization that takes primary responsibility for a particular activity or endeavor. May be combined with another relator term or code to show the greater importance this person or organization has regarding that particular role. If more than one relator is assigned to a heading, use the Lead relator only if it applies to all the relators
    /// <see href="http://d-nb.info/standards/elementset/gnd#firstComposer"></see></summary>
    let firstComposer =
        Namespaced_IRI.parse _namespace_name "firstComposer" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#forename"></see>
    /// </summary>
    let forename = Namespaced_IRI.parse _namespace_name "forename" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#formOfWorkAndExpression"></see>
    /// </summary>
    let formOfWorkAndExpression =
        Namespaced_IRI.parse _namespace_name "formOfWorkAndExpression" |> NamespacedName

    /// <summary>
    /// A person, family, or organization formerly having legal possession of an item
    /// <see href="http://d-nb.info/standards/elementset/gnd#formerOwner"></see></summary>
    let formerOwner =
        Namespaced_IRI.parse _namespace_name "formerOwner" |> NamespacedName

    /// <summary>
    /// A person, family, or organization that currently owns an item or collection, i.e. has legal possession of a resource
    /// <see href="http://d-nb.info/standards/elementset/gnd#owner"></see></summary>
    let owner = Namespaced_IRI.parse _namespace_name "owner" |> NamespacedName
    /// <summary>
    /// A person, family, or corporate body being a founder of an enterprise, an event, or an ensemble of buildings
    /// <see href="http://d-nb.info/standards/elementset/gnd#founder"></see></summary>
    let founder = Namespaced_IRI.parse _namespace_name "founder" |> NamespacedName

    /// <summary>
    /// This property is equivalent to gndo:functionOrRoleAsLiteral but points to a subject heading instead of giving a literal value.
    /// <see href="http://d-nb.info/standards/elementset/gnd#functionOrRole"></see></summary>
    let functionOrRole =
        Namespaced_IRI.parse _namespace_name "functionOrRole" |> NamespacedName

    /// <summary>
    /// This property is equivalent to gndo:functionOrRole but gives a literal instead of a URI
    /// <see href="http://d-nb.info/standards/elementset/gnd#functionOrRoleAsLiteral"></see></summary>
    let functionOrRoleAsLiteral =
        Namespaced_IRI.parse _namespace_name "functionOrRoleAsLiteral" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#gender"></see>
    /// </summary>
    let gender = Namespaced_IRI.parse _namespace_name "gender" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#geographicAreaCode"></see>
    /// </summary>
    let geographicAreaCode =
        Namespaced_IRI.parse _namespace_name "geographicAreaCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#gndIdentifier"></see>
    /// </summary>
    let gndIdentifier =
        Namespaced_IRI.parse _namespace_name "gndIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#gndSubjectCategory"></see>
    /// </summary>
    let gndSubjectCategory =
        Namespaced_IRI.parse _namespace_name "gndSubjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#hierarchicalSuperior"></see>
    /// </summary>
    let hierarchicalSuperior =
        Namespaced_IRI.parse _namespace_name "hierarchicalSuperior" |> NamespacedName

    /// <summary>
    /// A hierarchically superordinate unit (corporate body, conference, jurisdiction) of the described unit (corporate body, conference, jurisdiction).
    /// <see href="http://d-nb.info/standards/elementset/gnd#hierarchicalSuperiorOfPlaceOrGeographicName"></see></summary>
    let hierarchicalSuperiorOfPlaceOrGeographicName =
        Namespaced_IRI.parse _namespace_name "hierarchicalSuperiorOfPlaceOrGeographicName" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#hierarchicalSuperiorOfTheConferenceOrEvent"></see>
    /// </summary>
    let hierarchicalSuperiorOfTheConferenceOrEvent =
        Namespaced_IRI.parse _namespace_name "hierarchicalSuperiorOfTheConferenceOrEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#hierarchicalSuperiorOfTheCorporateBody"></see>
    /// </summary>
    let hierarchicalSuperiorOfTheCorporateBody =
        Namespaced_IRI.parse _namespace_name "hierarchicalSuperiorOfTheCorporateBody" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#homepage"></see>
    /// </summary>
    let homepage = Namespaced_IRI.parse _namespace_name "homepage" |> NamespacedName

    /// <summary>
    /// A person, family, or organization contributing to a resource by supplementing the primary content with drawings, diagrams, photographs, etc. If the work is primarily the artistic content created by this entity, use artist or photographer
    /// <see href="http://d-nb.info/standards/elementset/gnd#illustratorOrIlluminator"></see></summary>
    let illustratorOrIlluminator =
        Namespaced_IRI.parse _namespace_name "illustratorOrIlluminator" |> NamespacedName

    /// <summary>
    /// A person, family, or corporate body who initiated a work
    /// <see href="http://d-nb.info/standards/elementset/gnd#initiator"></see></summary>
    let initiator = Namespaced_IRI.parse _namespace_name "initiator" |> NamespacedName
    /// <summary>
    /// A musical instrument, a device to perform music with
    /// <see href="http://d-nb.info/standards/elementset/gnd#instrument"></see></summary>
    let instrument = Namespaced_IRI.parse _namespace_name "instrument" |> NamespacedName

    /// <summary>
    /// A performer contributing to a resource by playing a musical instrument
    /// <see href="http://d-nb.info/standards/elementset/gnd#instrumentalist"></see></summary>
    let instrumentalist =
        Namespaced_IRI.parse _namespace_name "instrumentalist" |> NamespacedName

    /// <summary>
    /// A person, family, or organization responsible for creating a new device or process
    /// <see href="http://d-nb.info/standards/elementset/gnd#inventor"></see></summary>
    let inventor = Namespaced_IRI.parse _namespace_name "inventor" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#keyOfTheVersion"></see>
    /// </summary>
    let keyOfTheVersion =
        Namespaced_IRI.parse _namespace_name "keyOfTheVersion" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#keyOfTheWork"></see>
    /// </summary>
    let keyOfTheWork =
        Namespaced_IRI.parse _namespace_name "keyOfTheWork" |> NamespacedName

    /// <summary>
    /// A language used by a person or family or in which a work was written
    /// <see href="http://d-nb.info/standards/elementset/gnd#language"></see></summary>
    let language = Namespaced_IRI.parse _namespace_name "language" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#languageCode"></see>
    /// </summary>
    let languageCode =
        Namespaced_IRI.parse _namespace_name "languageCode" |> NamespacedName

    /// <summary>
    /// An author of a libretto of an opera or other stage work, or an oratorio
    /// <see href="http://d-nb.info/standards/elementset/gnd#librettist"></see></summary>
    let librettist = Namespaced_IRI.parse _namespace_name "librettist" |> NamespacedName

    /// <summary>
    /// The described entity is a realization of the related work
    /// <see href="http://d-nb.info/standards/elementset/gnd#literarySource"></see></summary>
    let literarySource =
        Namespaced_IRI.parse _namespace_name "literarySource" |> NamespacedName

    /// <summary>
    /// A person or organization who prepares the stone or plate for lithographic printing, including a graphic artist creating a design directly on the surface from which printing will be done.
    /// <see href="http://d-nb.info/standards/elementset/gnd#lithographer"></see></summary>
    let lithographer =
        Namespaced_IRI.parse _namespace_name "lithographer" |> NamespacedName

    /// <summary>
    /// A person or organization responsible for printing, duplicating, casting, etc. a resource
    /// <see href="http://d-nb.info/standards/elementset/gnd#manufacturer"></see></summary>
    let manufacturer =
        Namespaced_IRI.parse _namespace_name "manufacturer" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#mediumOfPerformance"></see>
    /// </summary>
    let mediumOfPerformance =
        Namespaced_IRI.parse _namespace_name "mediumOfPerformance" |> NamespacedName

    /// <summary>
    /// A person or organization who performs music or contributes to the musical content of a work when it is not possible or desirable to identify the function more precisely
    /// <see href="http://d-nb.info/standards/elementset/gnd#musician"></see></summary>
    let musician = Namespaced_IRI.parse _namespace_name "musician" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#nameAddition"></see>
    /// </summary>
    let nameAddition =
        Namespaced_IRI.parse _namespace_name "nameAddition" |> NamespacedName

    /// <summary>
    /// A performer contributing to a resource by reading or speaking in order to give an account of an act, occurrence, course of events, etc
    /// <see href="http://d-nb.info/standards/elementset/gnd#narrator"></see></summary>
    let narrator = Namespaced_IRI.parse _namespace_name "narrator" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#northernmostLatitude"></see>
    /// </summary>
    let northernmostLatitude =
        Namespaced_IRI.parse _namespace_name "northernmostLatitude" |> NamespacedName

    /// <summary>
    /// Reason of the entity, e.g. a work or a historic event
    /// 		is the reason of a conference, or a conference is the reason of a work.
    /// <see href="http://d-nb.info/standards/elementset/gnd#occasion"></see></summary>
    let occasion = Namespaced_IRI.parse _namespace_name "occasion" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#occasionOfTheSubjectHeading"></see>
    /// </summary>
    let occasionOfTheSubjectHeading =
        Namespaced_IRI.parse _namespace_name "occasionOfTheSubjectHeading" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#occasionOfTheWork"></see>
    /// </summary>
    let occasionOfTheWork =
        Namespaced_IRI.parse _namespace_name "occasionOfTheWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#oldAuthorityNumber"></see>
    /// </summary>
    let oldAuthorityNumber =
        Namespaced_IRI.parse _namespace_name "oldAuthorityNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#opusNumericDesignationOfMusicalWork"></see>
    /// </summary>
    let opusNumericDesignationOfMusicalWork =
        Namespaced_IRI.parse _namespace_name "opusNumericDesignationOfMusicalWork" |> NamespacedName

    /// <summary>
    /// A person, family, or organization organizing the exhibit, event, conference, etc., which gave rise to a resource
    /// <see href="http://d-nb.info/standards/elementset/gnd#organizerOrHost"></see></summary>
    let organizerOrHost =
        Namespaced_IRI.parse _namespace_name "organizerOrHost" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#otherPlace"></see>
    /// </summary>
    let otherPlace = Namespaced_IRI.parse _namespace_name "otherPlace" |> NamespacedName
    /// <summary>
    /// A person or family who paints
    /// <see href="http://d-nb.info/standards/elementset/gnd#painter"></see></summary>
    let painter = Namespaced_IRI.parse _namespace_name "painter" |> NamespacedName

    /// <summary>
    /// A person’s known period of activity
    /// <see href="http://d-nb.info/standards/elementset/gnd#periodOfActivity"></see></summary>
    let periodOfActivity =
        Namespaced_IRI.parse _namespace_name "periodOfActivity" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#personalName"></see>
    /// </summary>
    let personalName =
        Namespaced_IRI.parse _namespace_name "personalName" |> NamespacedName

    /// <summary>
    /// A person, family, or organization responsible for creating a photographic work
    /// <see href="http://d-nb.info/standards/elementset/gnd#photographer"></see></summary>
    let photographer =
        Namespaced_IRI.parse _namespace_name "photographer" |> NamespacedName

    /// <summary>
    /// A country, state, province, etc., or place where an organization has its headquarters
    /// <see href="http://d-nb.info/standards/elementset/gnd#place"></see></summary>
    let place = Namespaced_IRI.parse _namespace_name "place" |> NamespacedName

    /// <summary>
    /// A person’s or family’s place of activity
    /// <see href="http://d-nb.info/standards/elementset/gnd#placeOfActivity"></see></summary>
    let placeOfActivity =
        Namespaced_IRI.parse _namespace_name "placeOfActivity" |> NamespacedName

    /// <summary>
    /// A person’s place of birth
    /// <see href="http://d-nb.info/standards/elementset/gnd#placeOfBirth"></see></summary>
    let placeOfBirth =
        Namespaced_IRI.parse _namespace_name "placeOfBirth" |> NamespacedName

    /// <summary>
    /// This property is equivalent to gndo:placeOfBirth but gives a literal instead of
    /// 		a reference to a geographic entity
    /// <see href="http://d-nb.info/standards/elementset/gnd#placeOfBirthAsLiteral"></see></summary>
    let placeOfBirthAsLiteral =
        Namespaced_IRI.parse _namespace_name "placeOfBirthAsLiteral" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#placeOfBusiness"></see>
    /// </summary>
    let placeOfBusiness =
        Namespaced_IRI.parse _namespace_name "placeOfBusiness" |> NamespacedName

    /// <summary>
    /// A place where an event such as a conference or a concert took place
    /// <see href="http://d-nb.info/standards/elementset/gnd#placeOfConferenceOrEvent"></see></summary>
    let placeOfConferenceOrEvent =
        Namespaced_IRI.parse _namespace_name "placeOfConferenceOrEvent" |> NamespacedName

    /// <summary>
    /// A place where something is kept
    /// <see href="http://d-nb.info/standards/elementset/gnd#placeOfCustody"></see></summary>
    let placeOfCustody =
        Namespaced_IRI.parse _namespace_name "placeOfCustody" |> NamespacedName

    /// <summary>
    /// A person’s place of death
    /// <see href="http://d-nb.info/standards/elementset/gnd#placeOfDeath"></see></summary>
    let placeOfDeath =
        Namespaced_IRI.parse _namespace_name "placeOfDeath" |> NamespacedName

    /// <summary>
    /// This property is equivalent to gndo:placeOfDeath but gives a literal instead of
    /// 		a reference to a geographic entity
    /// <see href="http://d-nb.info/standards/elementset/gnd#placeOfDeathAsLiteral"></see></summary>
    let placeOfDeathAsLiteral =
        Namespaced_IRI.parse _namespace_name "placeOfDeathAsLiteral" |> NamespacedName

    /// <summary>
    /// A place where a work or thing was found
    /// <see href="http://d-nb.info/standards/elementset/gnd#placeOfDiscovery"></see></summary>
    let placeOfDiscovery =
        Namespaced_IRI.parse _namespace_name "placeOfDiscovery" |> NamespacedName

    /// <summary>
    /// A place where a person or family dwelt in exile (lived in exile)
    /// <see href="http://d-nb.info/standards/elementset/gnd#placeOfExile"></see></summary>
    let placeOfExile =
        Namespaced_IRI.parse _namespace_name "placeOfExile" |> NamespacedName

    /// <summary>
    /// A place where a work or thing was manufactured
    /// <see href="http://d-nb.info/standards/elementset/gnd#placeOfManufacture"></see></summary>
    let placeOfManufacture =
        Namespaced_IRI.parse _namespace_name "placeOfManufacture" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#placeOrGeographicNameIsMember"></see>
    /// </summary>
    let placeOrGeographicNameIsMember =
        Namespaced_IRI.parse _namespace_name "placeOrGeographicNameIsMember" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#playedInstrument"></see>
    /// </summary>
    let playedInstrument =
        Namespaced_IRI.parse _namespace_name "playedInstrument" |> NamespacedName

    /// <summary>
    /// An author of the words of a non-dramatic musical work (e.g. the text of a song), except for oratorios
    /// <see href="http://d-nb.info/standards/elementset/gnd#poet"></see></summary>
    let poet = Namespaced_IRI.parse _namespace_name "poet" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#precedingConferenceOrEvent"></see>
    /// </summary>
    let precedingConferenceOrEvent =
        Namespaced_IRI.parse _namespace_name "precedingConferenceOrEvent" |> NamespacedName

    /// <summary>
    /// A corporate body or a work being the predecessor of another corporate body or work
    /// <see href="http://d-nb.info/standards/elementset/gnd#predecessor"></see></summary>
    let predecessor =
        Namespaced_IRI.parse _namespace_name "predecessor" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#precedingCorporateBody"></see>
    /// </summary>
    let precedingCorporateBody =
        Namespaced_IRI.parse _namespace_name "precedingCorporateBody" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#precedingPlaceOrGeographicName"></see>
    /// </summary>
    let precedingPlaceOrGeographicName =
        Namespaced_IRI.parse _namespace_name "precedingPlaceOrGeographicName" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#precedingSubject"></see>
    /// </summary>
    let precedingSubject =
        Namespaced_IRI.parse _namespace_name "precedingSubject" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#precedingWork"></see>
    /// </summary>
    let precedingWork =
        Namespaced_IRI.parse _namespace_name "precedingWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#preferredName"></see>
    /// </summary>
    let preferredName =
        Namespaced_IRI.parse _namespace_name "preferredName" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#preferredNameEntityForThePerson"></see>
    /// </summary>
    let preferredNameEntityForThePerson =
        Namespaced_IRI.parse _namespace_name "preferredNameEntityForThePerson" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#preferredNameForTheConferenceOrEvent"></see>
    /// </summary>
    let preferredNameForTheConferenceOrEvent =
        Namespaced_IRI.parse _namespace_name "preferredNameForTheConferenceOrEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#preferredNameForTheCorporateBody"></see>
    /// </summary>
    let preferredNameForTheCorporateBody =
        Namespaced_IRI.parse _namespace_name "preferredNameForTheCorporateBody" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#preferredNameForTheFamily"></see>
    /// </summary>
    let preferredNameForTheFamily =
        Namespaced_IRI.parse _namespace_name "preferredNameForTheFamily" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#preferredNameForThePerson"></see>
    /// </summary>
    let preferredNameForThePerson =
        Namespaced_IRI.parse _namespace_name "preferredNameForThePerson" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#preferredNameForThePlaceOrGeographicName"></see>
    /// </summary>
    let preferredNameForThePlaceOrGeographicName =
        Namespaced_IRI.parse _namespace_name "preferredNameForThePlaceOrGeographicName" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#preferredNameForTheSubjectHeading"></see>
    /// </summary>
    let preferredNameForTheSubjectHeading =
        Namespaced_IRI.parse _namespace_name "preferredNameForTheSubjectHeading" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#preferredNameForTheWork"></see>
    /// </summary>
    let preferredNameForTheWork =
        Namespaced_IRI.parse _namespace_name "preferredNameForTheWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#prefix"></see>
    /// </summary>
    let prefix = Namespaced_IRI.parse _namespace_name "prefix" |> NamespacedName
    /// <summary>
    /// A person, family, or organization involved in manufacturing a manifestation of printed text, notated music, etc., from type or plates, such as a book, newspaper, magazine, broadside, score, etc
    /// <see href="http://d-nb.info/standards/elementset/gnd#printer"></see></summary>
    let printer = Namespaced_IRI.parse _namespace_name "printer" |> NamespacedName

    /// <summary>
    /// A profession or occupation practiced by a person or family
    /// <see href="http://d-nb.info/standards/elementset/gnd#professionOrOccupation"></see></summary>
    let professionOrOccupation =
        Namespaced_IRI.parse _namespace_name "professionOrOccupation" |> NamespacedName

    /// <summary>
    /// This property is equivalent to gndo:professionOrOccupation but gives a literal instead of
    /// 		a reference to a subject heading
    /// <see href="http://d-nb.info/standards/elementset/gnd#professionOrOccupationAsLiteral"></see></summary>
    let professionOrOccupationAsLiteral =
        Namespaced_IRI.parse _namespace_name "professionOrOccupationAsLiteral" |> NamespacedName

    /// <summary>
    /// An occupational relationship between a person or family and another person or family
    /// <see href="http://d-nb.info/standards/elementset/gnd#professionalRelationship"></see></summary>
    let professionalRelationship =
        Namespaced_IRI.parse _namespace_name "professionalRelationship" |> NamespacedName

    /// <summary>
    /// Links a person's real identity to an identity under which one or more persons act, e. g. write, compose or create art, but that is not the person's real name (i. e. a pseudonym).
    /// <see href="http://d-nb.info/standards/elementset/gnd#pseudonym"></see></summary>
    let pseudonym = Namespaced_IRI.parse _namespace_name "pseudonym" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#relatedPerson"></see>
    /// </summary>
    let relatedPerson =
        Namespaced_IRI.parse _namespace_name "relatedPerson" |> NamespacedName

    /// <summary>
    /// Links an identity under which one or more persons act, e. g. write, compose or create art, but that is not their real name (i. e. a pseudonym) to their real identity.
    /// <see href="http://d-nb.info/standards/elementset/gnd#realIdentity"></see></summary>
    let realIdentity =
        Namespaced_IRI.parse _namespace_name "realIdentity" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#publication"></see>
    /// </summary>
    let publication =
        Namespaced_IRI.parse _namespace_name "publication" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#relatedConferenceOrEvent"></see>
    /// </summary>
    let relatedConferenceOrEvent =
        Namespaced_IRI.parse _namespace_name "relatedConferenceOrEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#relatedCorporateBody"></see>
    /// </summary>
    let relatedCorporateBody =
        Namespaced_IRI.parse _namespace_name "relatedCorporateBody" |> NamespacedName

    /// <summary>
    /// The connotation scope of the GND entity corresponds to a small part
    ///       to the connotation scope of the assigned DDC class.
    /// <see href="http://d-nb.info/standards/elementset/gnd#relatedDdcWithDegreeOfDeterminacy1"></see></summary>
    let relatedDdcWithDegreeOfDeterminacy1 =
        Namespaced_IRI.parse _namespace_name "relatedDdcWithDegreeOfDeterminacy1" |> NamespacedName

    /// <summary>
    /// The connotation scope of the GND entity is identical or nearly
    ///       identical to the connotation scope of a topic that is logically part of the class but is less
    ///       extensive in scope than the concept represented by the class number.
    /// <see href="http://d-nb.info/standards/elementset/gnd#relatedDdcWithDegreeOfDeterminacy2"></see></summary>
    let relatedDdcWithDegreeOfDeterminacy2 =
        Namespaced_IRI.parse _namespace_name "relatedDdcWithDegreeOfDeterminacy2" |> NamespacedName

    /// <summary>
    /// The connotation scope of the GND entity is identical or nearly
    ///       identical to the connotation scope of a topic that approximates the whole of the assigned DDC
    ///       class. According to DDC terms, topics that are nearly coextensive with the full meaning of a
    ///       class or cover more than half of the content of the class approximate the whole of the DDC
    ///       class.
    /// <see href="http://d-nb.info/standards/elementset/gnd#relatedDdcWithDegreeOfDeterminacy3"></see></summary>
    let relatedDdcWithDegreeOfDeterminacy3 =
        Namespaced_IRI.parse _namespace_name "relatedDdcWithDegreeOfDeterminacy3" |> NamespacedName

    /// <summary>
    /// The connotation scope of the GND entity is identical to the
    ///       connotation scope of the topic emphasized in the DDC class heading.
    /// <see href="http://d-nb.info/standards/elementset/gnd#relatedDdcWithDegreeOfDeterminacy4"></see></summary>
    let relatedDdcWithDegreeOfDeterminacy4 =
        Namespaced_IRI.parse _namespace_name "relatedDdcWithDegreeOfDeterminacy4" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#relatedFamily"></see>
    /// </summary>
    let relatedFamily =
        Namespaced_IRI.parse _namespace_name "relatedFamily" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#relatedPlaceOrGeographicName"></see>
    /// </summary>
    let relatedPlaceOrGeographicName =
        Namespaced_IRI.parse _namespace_name "relatedPlaceOrGeographicName" |> NamespacedName

    /// <summary>
    /// Use relatedSubjectHeading ('subject', not 'subjec') instead
    /// <see href="http://d-nb.info/standards/elementset/gnd#relatedSubjecHeading"></see></summary>
    let relatedSubjecHeading =
        Namespaced_IRI.parse _namespace_name "relatedSubjecHeading" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#relatedSubjectHeading"></see>
    /// </summary>
    let relatedSubjectHeading =
        Namespaced_IRI.parse _namespace_name "relatedSubjectHeading" |> NamespacedName

    /// <summary>
    /// The associative relationship covers associations between pairs of
    ///       concepts that are not related hierarchically, but are semantically or concetually associated
    ///       to such an extent that the link between them needs to be made explicit in the thesaurus.
    /// <see href="http://d-nb.info/standards/elementset/gnd#relatedTerm"></see></summary>
    let relatedTerm =
        Namespaced_IRI.parse _namespace_name "relatedTerm" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#relatedWork"></see>
    /// </summary>
    let relatedWork =
        Namespaced_IRI.parse _namespace_name "relatedWork" |> NamespacedName

    /// <summary>
    /// A person, family, or organization responsible for the set of technical, editorial, and intellectual procedures aimed at compensating for the degradation of an item by bringing it back to a state as close as possible to its original condition
    /// <see href="http://d-nb.info/standards/elementset/gnd#restorer"></see></summary>
    let restorer = Namespaced_IRI.parse _namespace_name "restorer" |> NamespacedName
    /// <summary>
    /// A person or organization who 1) reworks a musical composition, usually for a different medium, or 2) rewrites novels or stories for motion pictures or other audiovisual medium.
    /// <see href="http://d-nb.info/standards/elementset/gnd#revisor"></see></summary>
    let revisor = Namespaced_IRI.parse _namespace_name "revisor" |> NamespacedName

    /// <summary>
    /// An author of a screenplay, script, or scene
    /// <see href="http://d-nb.info/standards/elementset/gnd#screenwriter"></see></summary>
    let screenwriter =
        Namespaced_IRI.parse _namespace_name "screenwriter" |> NamespacedName

    /// <summary>
    /// A scriptorium in a monastery
    /// <see href="http://d-nb.info/standards/elementset/gnd#scriptorium"></see></summary>
    let scriptorium =
        Namespaced_IRI.parse _namespace_name "scriptorium" |> NamespacedName

    /// <summary>
    /// An artist responsible for creating a three-dimensional work by modeling, carving, or similar technique
    /// <see href="http://d-nb.info/standards/elementset/gnd#sculptor"></see></summary>
    let sculptor = Namespaced_IRI.parse _namespace_name "sculptor" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#serialNumericDesignationOfMusicalWork"></see>
    /// </summary>
    let serialNumericDesignationOfMusicalWork =
        Namespaced_IRI.parse _namespace_name "serialNumericDesignationOfMusicalWork" |> NamespacedName

    /// <summary>
    /// A performer contributing to a resource by using his/her/their voice, with or without instrumental accompaniment, to produce music. A singer's performance may or may not include actual words
    /// <see href="http://d-nb.info/standards/elementset/gnd#singer"></see></summary>
    let singer = Namespaced_IRI.parse _namespace_name "singer" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#southernmostLatitude"></see>
    /// </summary>
    let southernmostLatitude =
        Namespaced_IRI.parse _namespace_name "southernmostLatitude" |> NamespacedName

    /// <summary>
    /// Geographic field of activity
    /// <see href="http://d-nb.info/standards/elementset/gnd#spatialAreaOfActivity"></see></summary>
    let spatialAreaOfActivity =
        Namespaced_IRI.parse _namespace_name "spatialAreaOfActivity" |> NamespacedName

    /// <summary>
    /// A person, family, or organization sponsoring some aspect of a resource, e.g., funding research, sponsoring an event
    /// <see href="http://d-nb.info/standards/elementset/gnd#sponsorOrPatron"></see></summary>
    let sponsorOrPatron =
        Namespaced_IRI.parse _namespace_name "sponsorOrPatron" |> NamespacedName

    /// <summary>
    /// A person or organization who writes or develops the framework for an item without being intellectually responsible for its content
    /// <see href="http://d-nb.info/standards/elementset/gnd#subeditor"></see></summary>
    let subeditor = Namespaced_IRI.parse _namespace_name "subeditor" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#succeedingConferenceOrEvent"></see>
    /// </summary>
    let succeedingConferenceOrEvent =
        Namespaced_IRI.parse _namespace_name "succeedingConferenceOrEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#successor"></see>
    /// </summary>
    let successor = Namespaced_IRI.parse _namespace_name "successor" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#succeedingCorporateBody"></see>
    /// </summary>
    let succeedingCorporateBody =
        Namespaced_IRI.parse _namespace_name "succeedingCorporateBody" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#succeedingPlaceOrGeographicName"></see>
    /// </summary>
    let succeedingPlaceOrGeographicName =
        Namespaced_IRI.parse _namespace_name "succeedingPlaceOrGeographicName" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#succeedingSubjectHeading"></see>
    /// </summary>
    let succeedingSubjectHeading =
        Namespaced_IRI.parse _namespace_name "succeedingSubjectHeading" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#succeedingWork"></see>
    /// </summary>
    let succeedingWork =
        Namespaced_IRI.parse _namespace_name "succeedingWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#surname"></see>
    /// </summary>
    let surname = Namespaced_IRI.parse _namespace_name "surname" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#temporaryName"></see>
    /// </summary>
    let temporaryName =
        Namespaced_IRI.parse _namespace_name "temporaryName" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#temporaryNameOfTheConferenceOrEvent"></see>
    /// </summary>
    let temporaryNameOfTheConferenceOrEvent =
        Namespaced_IRI.parse _namespace_name "temporaryNameOfTheConferenceOrEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#temporaryNameOfTheCorporateBody"></see>
    /// </summary>
    let temporaryNameOfTheCorporateBody =
        Namespaced_IRI.parse _namespace_name "temporaryNameOfTheCorporateBody" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#temporaryNameOfThePlaceOrGeographicName"></see>
    /// </summary>
    let temporaryNameOfThePlaceOrGeographicName =
        Namespaced_IRI.parse _namespace_name "temporaryNameOfThePlaceOrGeographicName" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#thematicIndexNumericDesignationOfMusicalWork"></see>
    /// </summary>
    let thematicIndexNumericDesignationOfMusicalWork =
        Namespaced_IRI.parse _namespace_name "thematicIndexNumericDesignationOfMusicalWork" |> NamespacedName

    /// <summary>
    /// A title of nobility held by a person or family.
    /// <see href="http://d-nb.info/standards/elementset/gnd#titleOfNobility"></see></summary>
    let titleOfNobility =
        Namespaced_IRI.parse _namespace_name "titleOfNobility" |> NamespacedName

    /// <summary>
    /// A title of nobility held by a person or family.
    /// 		This property is equivalent to gndo:titleOfNobility
    /// 		but gives a literal instead of a reference to a subject heading.
    /// <see href="http://d-nb.info/standards/elementset/gnd#titleOfNobilityAsLiteral"></see></summary>
    let titleOfNobilityAsLiteral =
        Namespaced_IRI.parse _namespace_name "titleOfNobilityAsLiteral" |> NamespacedName

    /// <summary>
    /// Topic that is related to a corporate body, conference, person, family, subject heading or work.
    /// <see href="http://d-nb.info/standards/elementset/gnd#topic"></see></summary>
    let topic = Namespaced_IRI.parse _namespace_name "topic" |> NamespacedName
    /// <summary>
    /// A person or organization who renders a text from one language into another, or from an older form of a language into the modern form
    /// <see href="http://d-nb.info/standards/elementset/gnd#translator"></see></summary>
    let translator = Namespaced_IRI.parse _namespace_name "translator" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#typeOfCoordinates"></see>
    /// </summary>
    let typeOfCoordinates =
        Namespaced_IRI.parse _namespace_name "typeOfCoordinates" |> NamespacedName

    /// <summary>
    /// Date, expressed as UDK code
    /// <see href="http://d-nb.info/standards/elementset/gnd#udkCode"></see></summary>
    let udkCode = Namespaced_IRI.parse _namespace_name "udkCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#variantName"></see>
    /// </summary>
    let variantName =
        Namespaced_IRI.parse _namespace_name "variantName" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#variantNameEntityForThePerson"></see>
    /// </summary>
    let variantNameEntityForThePerson =
        Namespaced_IRI.parse _namespace_name "variantNameEntityForThePerson" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#variantNameForTheFamily"></see>
    /// </summary>
    let variantNameForTheFamily =
        Namespaced_IRI.parse _namespace_name "variantNameForTheFamily" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#variantNameForThePerson"></see>
    /// </summary>
    let variantNameForThePerson =
        Namespaced_IRI.parse _namespace_name "variantNameForThePerson" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#variantNameForTheSubjectHeading"></see>
    /// </summary>
    let variantNameForTheSubjectHeading =
        Namespaced_IRI.parse _namespace_name "variantNameForTheSubjectHeading" |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#westernmostLongitude"></see>
    /// </summary>
    let westernmostLongitude =
        Namespaced_IRI.parse _namespace_name "westernmostLongitude" |> NamespacedName

    /// <summary>
    /// A person or organization responsible for the commentary or explanatory notes about a text. For the writer of manuscript annotations in a printed book, use Annotator
    /// <see href="http://d-nb.info/standards/elementset/gnd#writerOfAddedCommentary"></see></summary>
    let writerOfAddedCommentary =
        Namespaced_IRI.parse _namespace_name "writerOfAddedCommentary" |> NamespacedName

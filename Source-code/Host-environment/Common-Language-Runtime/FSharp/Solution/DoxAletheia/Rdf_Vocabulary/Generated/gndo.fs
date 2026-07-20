namespace http.d_nb.info.standards.elementset.gnd.hash

open DoxAletheia

module gndo =
    let _namespace_name = "http://d-nb.info/standards/elementset/gnd#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#listMembers"></see>
    /// </summary>
    let listMembers = _prefix "listMembers"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#dnbStaff"></see>
    /// </summary>
    let dnbStaff = _prefix "dnbStaff"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#alexanderHaffner"></see>
    /// </summary>
    let alexanderHaffner = _prefix "alexanderHaffner"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#AdministrativeUnit"></see>
    /// </summary>
    let AdministrativeUnit = _prefix "AdministrativeUnit"
    /// <summary>
    /// Expresses the MARC 21 equivalent for this element in the GND MARC
    ///       format.
    /// <see href="http://d-nb.info/standards/elementset/gnd#marc21equivalent"></see></summary>
    let marc21equivalent = _prefix "marc21equivalent"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#PlaceOrGeographicName"></see>
    /// </summary>
    let PlaceOrGeographicName = _prefix "PlaceOrGeographicName"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#AuthorityResource"></see>
    /// </summary>
    let AuthorityResource = _prefix "AuthorityResource"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#BuildingOrMemorial"></see>
    /// </summary>
    let BuildingOrMemorial = _prefix "BuildingOrMemorial"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#CharactersOrMorphemes"></see>
    /// </summary>
    let CharactersOrMorphemes = _prefix "CharactersOrMorphemes"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#SubjectHeading"></see>
    /// </summary>
    let SubjectHeading = _prefix "SubjectHeading"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#Collection"></see>
    /// </summary>
    let Collection = _prefix "Collection"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#Work"></see>
    /// </summary>
    let Work = _prefix "Work"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#CollectiveManuscript"></see>
    /// </summary>
    let CollectiveManuscript = _prefix "CollectiveManuscript"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#CollectivePseudonym"></see>
    /// </summary>
    let CollectivePseudonym = _prefix "CollectivePseudonym"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#DifferentiatedPerson"></see>
    /// </summary>
    let DifferentiatedPerson = _prefix "DifferentiatedPerson"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#Company"></see>
    /// </summary>
    let Company = _prefix "Company"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#CorporateBody"></see>
    /// </summary>
    let CorporateBody = _prefix "CorporateBody"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#ConferenceOrEvent"></see>
    /// </summary>
    let ConferenceOrEvent = _prefix "ConferenceOrEvent"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#Country"></see>
    /// </summary>
    let Country = _prefix "Country"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#Person"></see>
    /// </summary>
    let Person = _prefix "Person"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#UndifferentiatedPerson"></see>
    /// </summary>
    let UndifferentiatedPerson = _prefix "UndifferentiatedPerson"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#EarlierNameOfThePerson"></see>
    /// </summary>
    let EarlierNameOfThePerson = _prefix "EarlierNameOfThePerson"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#VariantNameOfThePerson"></see>
    /// </summary>
    let VariantNameOfThePerson = _prefix "VariantNameOfThePerson"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#EthnographicName"></see>
    /// </summary>
    let EthnographicName = _prefix "EthnographicName"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#Expression"></see>
    /// </summary>
    let Expression = _prefix "Expression"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#ExtraterrestrialTerritory"></see>
    /// </summary>
    let ExtraterrestrialTerritory = _prefix "ExtraterrestrialTerritory"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#Family"></see>
    /// </summary>
    let Family = _prefix "Family"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#FictiveCorporateBody"></see>
    /// </summary>
    let FictiveCorporateBody = _prefix "FictiveCorporateBody"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#FictivePlace"></see>
    /// </summary>
    let FictivePlace = _prefix "FictivePlace"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#FictiveTerm"></see>
    /// </summary>
    let FictiveTerm = _prefix "FictiveTerm"
    /// <summary>
    /// Use FictiveTerm instead
    /// <see href="http://d-nb.info/standards/elementset/gnd#Fictive_term"></see></summary>
    let Fictive_term = _prefix "Fictive_term"
    /// <summary>
    /// The complete or a fuller form of name of a person, family or corporate body
    /// <see href="http://d-nb.info/standards/elementset/gnd#FullerFormOfNameOfThePerson"></see></summary>
    let FullerFormOfNameOfThePerson = _prefix "FullerFormOfNameOfThePerson"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#Gods"></see>
    /// </summary>
    let Gods = _prefix "Gods"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#GroupOfPersons"></see>
    /// </summary>
    let GroupOfPersons = _prefix "GroupOfPersons"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#HistoricSingleEventOrEra"></see>
    /// </summary>
    let HistoricSingleEventOrEra = _prefix "HistoricSingleEventOrEra"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#Language"></see>
    /// </summary>
    let Language = _prefix "Language"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#LaterNameOfThePerson"></see>
    /// </summary>
    let LaterNameOfThePerson = _prefix "LaterNameOfThePerson"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#LiteraryOrLegendaryCharacter"></see>
    /// </summary>
    let LiteraryOrLegendaryCharacter = _prefix "LiteraryOrLegendaryCharacter"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#Manuscript"></see>
    /// </summary>
    let Manuscript = _prefix "Manuscript"

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#MeansOfTransportWithIndividualName"></see>
    /// </summary>
    let MeansOfTransportWithIndividualName =
        _prefix "MeansOfTransportWithIndividualName"

    /// <summary>
    /// Use gndo:MeansOfTransportWithIndividualName
    /// <see href="http://d-nb.info/standards/elementset/gnd#MeansOfTransportWithIndividual_name"></see></summary>
    let MeansOfTransportWithIndividual_name =
        _prefix "MeansOfTransportWithIndividual_name"

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#MemberState"></see>
    /// </summary>
    let MemberState = _prefix "MemberState"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#MusicalCorporateBody"></see>
    /// </summary>
    let MusicalCorporateBody = _prefix "MusicalCorporateBody"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#MusicalWork"></see>
    /// </summary>
    let MusicalWork = _prefix "MusicalWork"

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#NameOfSmallGeographicUnitLyingWithinAnotherGeographicUnit"></see>
    /// </summary>
    let NameOfSmallGeographicUnitLyingWithinAnotherGeographicUnit =
        _prefix "NameOfSmallGeographicUnitLyingWithinAnotherGeographicUnit"

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#NameOfThePerson"></see>
    /// </summary>
    let NameOfThePerson = _prefix "NameOfThePerson"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#NaturalGeographicUnit"></see>
    /// </summary>
    let NaturalGeographicUnit = _prefix "NaturalGeographicUnit"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#NomenclatureInBiologyOrChemistry"></see>
    /// </summary>
    let NomenclatureInBiologyOrChemistry = _prefix "NomenclatureInBiologyOrChemistry"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#OrganOfCorporateBody"></see>
    /// </summary>
    let OrganOfCorporateBody = _prefix "OrganOfCorporateBody"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#PreferredNameOfThePerson"></see>
    /// </summary>
    let PreferredNameOfThePerson = _prefix "PreferredNameOfThePerson"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#ProductNameOrBrandName"></see>
    /// </summary>
    let ProductNameOrBrandName = _prefix "ProductNameOrBrandName"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#ProjectOrProgram"></see>
    /// </summary>
    let ProjectOrProgram = _prefix "ProjectOrProgram"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#ProvenanceCharacteristic"></see>
    /// </summary>
    let ProvenanceCharacteristic = _prefix "ProvenanceCharacteristic"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#Pseudonym"></see>
    /// </summary>
    let Pseudonym = _prefix "Pseudonym"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#PseudonymNameOfThePerson"></see>
    /// </summary>
    let PseudonymNameOfThePerson = _prefix "PseudonymNameOfThePerson"
    /// <summary>
    /// The person’s real name
    /// <see href="http://d-nb.info/standards/elementset/gnd#RealNameOfThePerson"></see></summary>
    let RealNameOfThePerson = _prefix "RealNameOfThePerson"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#ReligiousAdministrativeUnit"></see>
    /// </summary>
    let ReligiousAdministrativeUnit = _prefix "ReligiousAdministrativeUnit"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#ReligiousCorporateBody"></see>
    /// </summary>
    let ReligiousCorporateBody = _prefix "ReligiousCorporateBody"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#ReligiousTerritory"></see>
    /// </summary>
    let ReligiousTerritory = _prefix "ReligiousTerritory"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#RoyalOrMemberOfARoyalHouse"></see>
    /// </summary>
    let RoyalOrMemberOfARoyalHouse = _prefix "RoyalOrMemberOfARoyalHouse"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#SeriesOfConferenceOrEvent"></see>
    /// </summary>
    let SeriesOfConferenceOrEvent = _prefix "SeriesOfConferenceOrEvent"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#SoftwareProduct"></see>
    /// </summary>
    let SoftwareProduct = _prefix "SoftwareProduct"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#Spirits"></see>
    /// </summary>
    let Spirits = _prefix "Spirits"
    /// <summary>
    /// Use startingOrFinalPointOfADistance (with a minor s) instead
    /// <see href="http://d-nb.info/standards/elementset/gnd#StartingOrFinalPointOfADistance"></see></summary>
    let StartingOrFinalPointOfADistance = _prefix "StartingOrFinalPointOfADistance"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#startingOrFinalPointOfADistance"></see>
    /// </summary>
    let startingOrFinalPointOfADistance = _prefix "startingOrFinalPointOfADistance"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#SubjectHeadingSensoStricto"></see>
    /// </summary>
    let SubjectHeadingSensoStricto = _prefix "SubjectHeadingSensoStricto"

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#TerritorialCorporateBodyOrAdministrativeUnit"></see>
    /// </summary>
    let TerritorialCorporateBodyOrAdministrativeUnit =
        _prefix "TerritorialCorporateBodyOrAdministrativeUnit"

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#VersionOfAMusicalWork"></see>
    /// </summary>
    let VersionOfAMusicalWork = _prefix "VersionOfAMusicalWork"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#WayBorderOrLine"></see>
    /// </summary>
    let WayBorderOrLine = _prefix "WayBorderOrLine"

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#abbreviatedNameForTheConferenceOrEvent"></see>
    /// </summary>
    let abbreviatedNameForTheConferenceOrEvent =
        _prefix "abbreviatedNameForTheConferenceOrEvent"

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#variantNameForTheConferenceOrEvent"></see>
    /// </summary>
    let variantNameForTheConferenceOrEvent =
        _prefix "variantNameForTheConferenceOrEvent"

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#abbreviatedNameForTheCorporateBody"></see>
    /// </summary>
    let abbreviatedNameForTheCorporateBody =
        _prefix "abbreviatedNameForTheCorporateBody"

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#variantNameForTheCorporateBody"></see>
    /// </summary>
    let variantNameForTheCorporateBody = _prefix "variantNameForTheCorporateBody"

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#abbreviatedNameForThePlaceOrGeographicName"></see>
    /// </summary>
    let abbreviatedNameForThePlaceOrGeographicName =
        _prefix "abbreviatedNameForThePlaceOrGeographicName"

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#variantNameForThePlaceOrGeographicName"></see>
    /// </summary>
    let variantNameForThePlaceOrGeographicName =
        _prefix "variantNameForThePlaceOrGeographicName"

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#abbreviatedNameForTheWork"></see>
    /// </summary>
    let abbreviatedNameForTheWork = _prefix "abbreviatedNameForTheWork"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#variantNameForTheWork"></see>
    /// </summary>
    let variantNameForTheWork = _prefix "variantNameForTheWork"
    /// <summary>
    /// An academic degree.
    /// <see href="http://d-nb.info/standards/elementset/gnd#academicDegree"></see></summary>
    let academicDegree = _prefix "academicDegree"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#accordingWork"></see>
    /// </summary>
    let accordingWork = _prefix "accordingWork"
    /// <summary>
    /// An author, artist, etc., relating him/her to a resource for which there is or once was substantial authority for designating that person as author, creator, etc. of the work
    /// <see href="http://d-nb.info/standards/elementset/gnd#accreditedArtist"></see></summary>
    let accreditedArtist = _prefix "accreditedArtist"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#artist"></see>
    /// </summary>
    let artist = _prefix "artist"
    /// <summary>
    /// An author, artist, etc., relating him/her to a resource for which there is or once was substantial authority for designating that person as author, creator, etc. of the work
    /// <see href="http://d-nb.info/standards/elementset/gnd#accreditedAuthor"></see></summary>
    let accreditedAuthor = _prefix "accreditedAuthor"
    /// <summary>
    /// A person, family, or organization responsible for creating a work that is primarily textual in content, regardless of media type (e.g., printed text, spoken word, electronic text, tactile text) or genre (e.g., poems, novels, screenplays, blogs). Use also for persons, etc., creating a new work by paraphrasing, rewriting, or adapting works by another creator such that the modification has substantially changed the nature and content of the original or changed the medium of expression
    /// <see href="http://d-nb.info/standards/elementset/gnd#author"></see></summary>
    let author = _prefix "author"
    /// <summary>
    /// An author, artist, etc., relating him/her to a resource for which there is or once was substantial authority for designating that person as author, creator, etc. of the work
    /// <see href="http://d-nb.info/standards/elementset/gnd#accreditedComposer"></see></summary>
    let accreditedComposer = _prefix "accreditedComposer"
    /// <summary>
    /// A person, family, or organization responsible for creating or contributing to a musical resource by adding music to a work that originally lacked it or supplements it
    /// <see href="http://d-nb.info/standards/elementset/gnd#composer"></see></summary>
    let composer = _prefix "composer"
    /// <summary>
    /// Relationship between a person, family, or corporate body and another person, family, or corporate body which cannot be specified more closely
    /// <see href="http://d-nb.info/standards/elementset/gnd#acquaintanceshipOrFriendship"></see></summary>
    let acquaintanceshipOrFriendship = _prefix "acquaintanceshipOrFriendship"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#memberOfTheFamily"></see>
    /// </summary>
    let memberOfTheFamily = _prefix "memberOfTheFamily"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#addition"></see>
    /// </summary>
    let addition = _prefix "addition"
    /// <summary>
    /// A person, family, or organization to whom the correspondence in a work is addressed.
    /// <see href="http://d-nb.info/standards/elementset/gnd#addressee"></see></summary>
    let addressee = _prefix "addressee"
    /// <summary>
    /// A corporate body associated with a person or group of persons.
    /// <see href="http://d-nb.info/standards/elementset/gnd#affiliation"></see></summary>
    let affiliation = _prefix "affiliation"
    /// <summary>
    /// A corporate body associated with a person or group of persons.
    /// 		This property is equivalent to gndo:affiliation but gives a literal instead of
    /// 		a URI.
    /// <see href="http://d-nb.info/standards/elementset/gnd#affiliationAsLiteral"></see></summary>
    let affiliationAsLiteral = _prefix "affiliationAsLiteral"
    /// <summary>
    /// A person who makes manuscript annotations on an item.
    /// <see href="http://d-nb.info/standards/elementset/gnd#annotator"></see></summary>
    let annotator = _prefix "annotator"
    /// <summary>
    /// A person, family, or organization responsible for creating an
    /// 		architectural design, including a pictorial representation intended to show how a building,
    /// 		etc., will look when completed. It also oversees the construction of structures.
    /// <see href="http://d-nb.info/standards/elementset/gnd#architect"></see></summary>
    let architect = _prefix "architect"
    /// <summary>
    /// A person, family, or organization contributing to a musical
    /// 		work by rewriting the composition for a medium of performance different from that
    /// 		for which the work was originally intended, or modifying the work for the same
    /// 		medium of performance, etc., such that the musical substance of the original
    /// 		composition remains essentially unchanged. For extensive modification that effectively
    /// 		results in the creation of a new musical work, see composer.
    /// <see href="http://d-nb.info/standards/elementset/gnd#arranger"></see></summary>
    let arranger = _prefix "arranger"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#associatedDate"></see>
    /// </summary>
    let associatedDate = _prefix "associatedDate"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#associatedPlace"></see>
    /// </summary>
    let associatedPlace = _prefix "associatedPlace"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#beginningOfPeriod"></see>
    /// </summary>
    let beginningOfPeriod = _prefix "beginningOfPeriod"
    /// <summary>
    /// A person, family, or corporate body being the benefactor of a work, a thing, or a corporate body
    /// <see href="http://d-nb.info/standards/elementset/gnd#benefactor"></see></summary>
    let benefactor = _prefix "benefactor"

    /// <summary>
    /// Summary of the essential biographical, historical, or other
    ///       information about the described entity.
    /// <see href="http://d-nb.info/standards/elementset/gnd#biographicalOrHistoricalInformation"></see></summary>
    let biographicalOrHistoricalInformation =
        _prefix "biographicalOrHistoricalInformation"

    /// <summary>
    /// P1 gnd:superPropertyOf P2 states that P2 is a subproperty of P1. The
    ///       gndo:superPropertyOf property is transitive.
    /// <see href="http://d-nb.info/standards/elementset/gnd#superPropertyOf"></see></summary>
    let superPropertyOf = _prefix "superPropertyOf"
    /// <summary>
    /// A person who binds an item
    /// <see href="http://d-nb.info/standards/elementset/gnd#bookbinder"></see></summary>
    let bookbinder = _prefix "bookbinder"
    /// <summary>
    /// A person or organization involved in manufacturing a manifestation by being responsible for the entire graphic design of a book, including arrangement of type and illustration, choice of materials, and process used
    /// <see href="http://d-nb.info/standards/elementset/gnd#bookdesigner"></see></summary>
    let bookdesigner = _prefix "bookdesigner"
    /// <summary>
    /// Use broader term general instead
    /// <see href="http://d-nb.info/standards/elementset/gnd#broaderTerm"></see></summary>
    let broaderTerm = _prefix "broaderTerm"
    /// <summary>
    /// Broader term
    /// <see href="http://d-nb.info/standards/elementset/gnd#broaderTermGeneral"></see></summary>
    let broaderTermGeneral = _prefix "broaderTermGeneral"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#narrowerTermGeneral"></see>
    /// </summary>
    let narrowerTermGeneral = _prefix "narrowerTermGeneral"
    /// <summary>
    /// The generic relation is a semantic relation between two concepts
    ///       where the intension of one of the concepts includes that of the other concepts and at least
    ///       one additional delimiting characteristic is added.
    /// <see href="http://d-nb.info/standards/elementset/gnd#broaderTermGeneric"></see></summary>
    let broaderTermGeneric = _prefix "broaderTermGeneric"
    /// <summary>
    /// The generic relation is a semantic relation between two concepts
    ///       where the intension of one of the concepts includes that of the other concepts and at least
    ///       one additional delimiting characteristic is added.
    /// <see href="http://d-nb.info/standards/elementset/gnd#narrowerTermGeneric"></see></summary>
    let narrowerTermGeneric = _prefix "narrowerTermGeneric"
    /// <summary>
    /// The instance relationship links a general concept such as a class of
    ///       things or events, and an individual instance oft hat class, which is often represented by a
    ///       proper name.
    /// <see href="http://d-nb.info/standards/elementset/gnd#broaderTermInstantial"></see></summary>
    let broaderTermInstantial = _prefix "broaderTermInstantial"
    /// <summary>
    /// The instance relationship links a general concept such as a class of
    ///       things or events, and an individual instance oft hat class, which is often represented by a
    ///       proper name.
    /// <see href="http://d-nb.info/standards/elementset/gnd#narrowerTermInstantial"></see></summary>
    let narrowerTermInstantial = _prefix "narrowerTermInstantial"
    /// <summary>
    /// The hierarchical whole-part relationship covers a limited range of
    ///       situations in which a part of an entity or system belongs uniquely to a particular possessing
    ///       whole. When applied to persons, this is the relation between a single person (particularly gods)
    /// 	  and hierarchically broader groups of gods and mythologic entities.
    /// <see href="http://d-nb.info/standards/elementset/gnd#broaderTermPartitive"></see></summary>
    let broaderTermPartitive = _prefix "broaderTermPartitive"
    /// <summary>
    /// The hierarchical whole-part relationship covers a limited range of
    ///       situations in which a part of an entity or system belongs uniquely to a particular possessing
    ///       whole. When applied to persons, this is the relation between a single person (particularly gods)
    /// 	  and hierarchically superior groups of gods and mythologic entities.
    /// <see href="http://d-nb.info/standards/elementset/gnd#narrowerTermPartitive"></see></summary>
    let narrowerTermPartitive = _prefix "narrowerTermPartitive"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#broaderTermWithMoreThanOneElement"></see>
    /// </summary>
    let broaderTermWithMoreThanOneElement = _prefix "broaderTermWithMoreThanOneElement"
    /// <summary>
    /// Use gndo:broaderTermGeneral instead
    /// <see href="http://d-nb.info/standards/elementset/gnd#broderTermGeneral"></see></summary>
    let broderTermGeneral = _prefix "broderTermGeneral"
    /// <summary>
    /// A person, family, or corporate body in charge of financing and constructing a building
    /// <see href="http://d-nb.info/standards/elementset/gnd#buildingOwner"></see></summary>
    let buildingOwner = _prefix "buildingOwner"
    /// <summary>
    /// A person, family, or organization responsible for creating a map, atlas, globe, or other cartographic work
    /// <see href="http://d-nb.info/standards/elementset/gnd#cartographer"></see></summary>
    let cartographer = _prefix "cartographer"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#celebratedCorporateBody"></see>
    /// </summary>
    let celebratedCorporateBody = _prefix "celebratedCorporateBody"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#celebratedFamily"></see>
    /// </summary>
    let celebratedFamily = _prefix "celebratedFamily"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#celebratedPerson"></see>
    /// </summary>
    let celebratedPerson = _prefix "celebratedPerson"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#celebratedTopic"></see>
    /// </summary>
    let celebratedTopic = _prefix "celebratedTopic"
    /// <summary>
    /// A significant place for a person or family
    /// <see href="http://d-nb.info/standards/elementset/gnd#characteristicPlace"></see></summary>
    let characteristicPlace = _prefix "characteristicPlace"
    /// <summary>
    /// A person responsible for creating or contributing to a work of movement
    /// <see href="http://d-nb.info/standards/elementset/gnd#choreographer"></see></summary>
    let choreographer = _prefix "choreographer"
    /// <summary>
    /// A person or organization whose work is largely quoted or extracted in works to which he or she did not contribute directly. Such quotations are found particularly in exhibition catalogs, collections of photographs, etc.
    /// <see href="http://d-nb.info/standards/elementset/gnd#citedArtist"></see></summary>
    let citedArtist = _prefix "citedArtist"
    /// <summary>
    /// A person or organization whose work is largely quoted or extracted in works to which he or she did not contribute directly. Such quotations are found particularly in exhibition catalogs, collections of photographs, etc.
    /// <see href="http://d-nb.info/standards/elementset/gnd#citedAuthor"></see></summary>
    let citedAuthor = _prefix "citedAuthor"
    /// <summary>
    /// A person or organization whose work is largely quoted or extracted in works to which he or she did not contribute directly. Such quotations are found particularly in exhibition catalogs, collections of photographs, etc.
    /// <see href="http://d-nb.info/standards/elementset/gnd#citedComposer"></see></summary>
    let citedComposer = _prefix "citedComposer"
    /// <summary>
    /// A curator who brings together items from various sources that are then arranged, described, and cataloged as a collection. A collector is neither the creator of the material nor a person to whom manuscripts in the collection may have been addressed
    /// <see href="http://d-nb.info/standards/elementset/gnd#collector"></see></summary>
    let collector = _prefix "collector"
    /// <summary>
    /// A person, family, or organization responsible for creating a new work (e.g., a bibliography, a directory) through the act of compilation, e.g., selecting, arranging, aggregating, and editing data, information, etc
    /// <see href="http://d-nb.info/standards/elementset/gnd#compiler"></see></summary>
    let compiler = _prefix "compiler"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#complexSeeReferenceSubject"></see>
    /// </summary>
    let complexSeeReferenceSubject = _prefix "complexSeeReferenceSubject"
    /// <summary>
    /// A person or organization permitting the temporary use of a book, manuscript, etc., such as for photocopying or microfilming
    /// <see href="http://d-nb.info/standards/elementset/gnd#conferrer"></see></summary>
    let conferrer = _prefix "conferrer"
    /// <summary>
    /// Use contributingFamily instead.
    /// <see href="http://d-nb.info/standards/elementset/gnd#contributinFamily"></see></summary>
    let contributinFamily = _prefix "contributinFamily"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#contributingFamily"></see>
    /// </summary>
    let contributingFamily = _prefix "contributingFamily"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#contributingCorporateBody"></see>
    /// </summary>
    let contributingCorporateBody = _prefix "contributingCorporateBody"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#contributingPerson"></see>
    /// </summary>
    let contributingPerson = _prefix "contributingPerson"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#contributingPlaceOrGeographicName"></see>
    /// </summary>
    let contributingPlaceOrGeographicName = _prefix "contributingPlaceOrGeographicName"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#coordinates"></see>
    /// </summary>
    let coordinates = _prefix "coordinates"
    /// <summary>
    /// A person or family who is known as scribe or copyist.
    /// <see href="http://d-nb.info/standards/elementset/gnd#copist"></see></summary>
    let copist = _prefix "copist"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#corporateBodyIsMember"></see>
    /// </summary>
    let corporateBodyIsMember = _prefix "corporateBodyIsMember"
    /// <summary>
    /// A person or family being a member of (another) family
    /// <see href="http://d-nb.info/standards/elementset/gnd#member"></see></summary>
    let member_ = _prefix "member"
    /// <summary>
    /// A person or organization who was either the writer or recipient of a letter or other communication
    /// <see href="http://d-nb.info/standards/elementset/gnd#correspondent"></see></summary>
    let correspondent = _prefix "correspondent"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#counting"></see>
    /// </summary>
    let counting = _prefix "counting"
    /// <summary>
    /// A person or organization performing the work, i.e., the name of a person or organization associated with the intellectual content of the work. This category does not include the publisher or personal affiliation, or sponsor except where it is also the corporate author
    /// <see href="http://d-nb.info/standards/elementset/gnd#creator"></see></summary>
    let creator = _prefix "creator"
    /// <summary>
    /// A person, family, or organization conceiving, aggregating, and/or organizing an exhibition, collection, or other item
    /// <see href="http://d-nb.info/standards/elementset/gnd#curator"></see></summary>
    let curator = _prefix "curator"
    /// <summary>
    /// Date of birth and death of a person, years in which a family has been known to exist
    /// <see href="http://d-nb.info/standards/elementset/gnd#dateOfBirth"></see></summary>
    let dateOfBirth = _prefix "dateOfBirth"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#dateOfBirthAndDeath"></see>
    /// </summary>
    let dateOfBirthAndDeath = _prefix "dateOfBirthAndDeath"
    /// <summary>
    /// Date of a conference
    /// <see href="http://d-nb.info/standards/elementset/gnd#dateOfConferenceOrEvent"></see></summary>
    let dateOfConferenceOrEvent = _prefix "dateOfConferenceOrEvent"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#dateOfDeath"></see>
    /// </summary>
    let dateOfDeath = _prefix "dateOfDeath"
    /// <summary>
    /// Date or year in which an object was found (not to be used in connection with persons, families and corporate bodies)
    /// <see href="http://d-nb.info/standards/elementset/gnd#dateOfDiscovery"></see></summary>
    let dateOfDiscovery = _prefix "dateOfDiscovery"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#dateOfEstablishment"></see>
    /// </summary>
    let dateOfEstablishment = _prefix "dateOfEstablishment"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#dateOfEstablishmentAndTermination"></see>
    /// </summary>
    let dateOfEstablishmentAndTermination = _prefix "dateOfEstablishmentAndTermination"
    /// <summary>
    /// Date (year) in which a written historical document was created or a building constructed
    /// <see href="http://d-nb.info/standards/elementset/gnd#dateOfProduction"></see></summary>
    let dateOfProduction = _prefix "dateOfProduction"
    /// <summary>
    /// Date of publication of the first expression of a work
    /// <see href="http://d-nb.info/standards/elementset/gnd#dateOfPublication"></see></summary>
    let dateOfPublication = _prefix "dateOfPublication"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#dateOfTermination"></see>
    /// </summary>
    let dateOfTermination = _prefix "dateOfTermination"
    /// <summary>
    /// A person, family, or organization to whom a resource is dedicated
    /// <see href="http://d-nb.info/standards/elementset/gnd#dedicatee"></see></summary>
    let dedicatee = _prefix "dedicatee"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#definition"></see>
    /// </summary>
    let definition = _prefix "definition"
    /// <summary>
    /// A person, family, or organization responsible for creating a design for an object
    /// <see href="http://d-nb.info/standards/elementset/gnd#designer"></see></summary>
    let designer = _prefix "designer"
    /// <summary>
    /// A person responsible for the general management and supervision of a filmed performance, a radio or television program, etc.
    /// <see href="http://d-nb.info/standards/elementset/gnd#director"></see></summary>
    let director = _prefix "director"
    /// <summary>
    /// A person in charge of photographing a motion picture, who plans the technical aspets of lighting and photographing of scenes, and often assists the director in the choice of angles, camera setups, and lighting moods. He or she may also supervise the further processing of filmed material up to the completion of the work print. Cinematographer is also referred to as director of photography. Do not confuse with videographer
    /// <see href="http://d-nb.info/standards/elementset/gnd#directorOfPhotography"></see></summary>
    let directorOfPhotography = _prefix "directorOfPhotography"
    /// <summary>
    /// A person or organization to which authorship has been dubiously or incorrectly ascribed
    /// <see href="http://d-nb.info/standards/elementset/gnd#doubtfulArtist"></see></summary>
    let doubtfulArtist = _prefix "doubtfulArtist"
    /// <summary>
    /// A person or organization to which authorship has been dubiously or incorrectly ascribed
    /// <see href="http://d-nb.info/standards/elementset/gnd#doubtfulAuthor"></see></summary>
    let doubtfulAuthor = _prefix "doubtfulAuthor"
    /// <summary>
    /// A person or organization to which authorship has been dubiously or incorrectly ascribed
    /// <see href="http://d-nb.info/standards/elementset/gnd#doubtfulComposer"></see></summary>
    let doubtfulComposer = _prefix "doubtfulComposer"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#easternmostLongitude"></see>
    /// </summary>
    let easternmostLongitude = _prefix "easternmostLongitude"
    /// <summary>
    /// A person, family, or organization contributing to a resource by revising or elucidating the content, e.g., adding an introduction, notes, or other critical matter. An editor may also prepare a resource for production, publication, or distribution. For major revisions, adaptations, etc., that substantially change the nature and content of the original work, resulting in a new work, see author
    /// <see href="http://d-nb.info/standards/elementset/gnd#editor"></see></summary>
    let editor = _prefix "editor"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#endOfPeriod"></see>
    /// </summary>
    let endOfPeriod = _prefix "endOfPeriod"
    /// <summary>
    /// A person or organization who cuts letters, figures, etc. on a surface, such as a wooden or metal plate used for printing
    /// <see href="http://d-nb.info/standards/elementset/gnd#engraver"></see></summary>
    let engraver = _prefix "engraver"

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#epithetGenericNameTitleOrTerritory"></see>
    /// </summary>
    let epithetGenericNameTitleOrTerritory =
        _prefix "epithetGenericNameTitleOrTerritory"

    /// <summary>
    /// A person or organization who produces text or images for printing by subjecting metal, glass, or some other surface to acid or the corrosive action of some other substance
    /// <see href="http://d-nb.info/standards/elementset/gnd#etcher"></see></summary>
    let etcher = _prefix "etcher"
    /// <summary>
    /// A person, family, or corporate body in charge of an exhibition.
    /// <see href="http://d-nb.info/standards/elementset/gnd#exhibitor"></see></summary>
    let exhibitor = _prefix "exhibitor"
    /// <summary>
    /// A family relationship between a person or family and another person or family
    /// <see href="http://d-nb.info/standards/elementset/gnd#familialRelationship"></see></summary>
    let familialRelationship = _prefix "familialRelationship"
    /// <summary>
    /// A fictitious person, family, or corporate body ascertained to be the author
    /// <see href="http://d-nb.info/standards/elementset/gnd#fictitiousAuthor"></see></summary>
    let fictitiousAuthor = _prefix "fictitiousAuthor"
    /// <summary>
    /// Field of activity of a person, corporate body, conference or event.
    /// <see href="http://d-nb.info/standards/elementset/gnd#fieldOfActivity"></see></summary>
    let fieldOfActivity = _prefix "fieldOfActivity"
    /// <summary>
    /// A person’s field of study
    /// <see href="http://d-nb.info/standards/elementset/gnd#fieldOfStudy"></see></summary>
    let fieldOfStudy = _prefix "fieldOfStudy"
    /// <summary>
    /// A person or organization that takes primary responsibility for a particular activity or endeavor. May be combined with another relator term or code to show the greater importance this person or organization has regarding that particular role. If more than one relator is assigned to a heading, use the Lead relator only if it applies to all the relators
    /// <see href="http://d-nb.info/standards/elementset/gnd#firstArtist"></see></summary>
    let firstArtist = _prefix "firstArtist"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#firstAuthor"></see>
    /// </summary>
    let firstAuthor = _prefix "firstAuthor"
    /// <summary>
    /// A person or organization that takes primary responsibility for a particular activity or endeavor. May be combined with another relator term or code to show the greater importance this person or organization has regarding that particular role. If more than one relator is assigned to a heading, use the Lead relator only if it applies to all the relators
    /// <see href="http://d-nb.info/standards/elementset/gnd#firstComposer"></see></summary>
    let firstComposer = _prefix "firstComposer"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#forename"></see>
    /// </summary>
    let forename = _prefix "forename"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#formOfWorkAndExpression"></see>
    /// </summary>
    let formOfWorkAndExpression = _prefix "formOfWorkAndExpression"
    /// <summary>
    /// A person, family, or organization formerly having legal possession of an item
    /// <see href="http://d-nb.info/standards/elementset/gnd#formerOwner"></see></summary>
    let formerOwner = _prefix "formerOwner"
    /// <summary>
    /// A person, family, or organization that currently owns an item or collection, i.e. has legal possession of a resource
    /// <see href="http://d-nb.info/standards/elementset/gnd#owner"></see></summary>
    let owner = _prefix "owner"
    /// <summary>
    /// A person, family, or corporate body being a founder of an enterprise, an event, or an ensemble of buildings
    /// <see href="http://d-nb.info/standards/elementset/gnd#founder"></see></summary>
    let founder = _prefix "founder"
    /// <summary>
    /// This property is equivalent to gndo:functionOrRoleAsLiteral but points to a subject heading instead of giving a literal value.
    /// <see href="http://d-nb.info/standards/elementset/gnd#functionOrRole"></see></summary>
    let functionOrRole = _prefix "functionOrRole"
    /// <summary>
    /// This property is equivalent to gndo:functionOrRole but gives a literal instead of a URI
    /// <see href="http://d-nb.info/standards/elementset/gnd#functionOrRoleAsLiteral"></see></summary>
    let functionOrRoleAsLiteral = _prefix "functionOrRoleAsLiteral"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#gender"></see>
    /// </summary>
    let gender = _prefix "gender"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#geographicAreaCode"></see>
    /// </summary>
    let geographicAreaCode = _prefix "geographicAreaCode"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#gndIdentifier"></see>
    /// </summary>
    let gndIdentifier = _prefix "gndIdentifier"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#gndSubjectCategory"></see>
    /// </summary>
    let gndSubjectCategory = _prefix "gndSubjectCategory"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#hierarchicalSuperior"></see>
    /// </summary>
    let hierarchicalSuperior = _prefix "hierarchicalSuperior"

    /// <summary>
    /// A hierarchically superordinate unit (corporate body, conference, jurisdiction) of the described unit (corporate body, conference, jurisdiction).
    /// <see href="http://d-nb.info/standards/elementset/gnd#hierarchicalSuperiorOfPlaceOrGeographicName"></see></summary>
    let hierarchicalSuperiorOfPlaceOrGeographicName =
        _prefix "hierarchicalSuperiorOfPlaceOrGeographicName"

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#hierarchicalSuperiorOfTheConferenceOrEvent"></see>
    /// </summary>
    let hierarchicalSuperiorOfTheConferenceOrEvent =
        _prefix "hierarchicalSuperiorOfTheConferenceOrEvent"

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#hierarchicalSuperiorOfTheCorporateBody"></see>
    /// </summary>
    let hierarchicalSuperiorOfTheCorporateBody =
        _prefix "hierarchicalSuperiorOfTheCorporateBody"

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#homepage"></see>
    /// </summary>
    let homepage = _prefix "homepage"
    /// <summary>
    /// A person, family, or organization contributing to a resource by supplementing the primary content with drawings, diagrams, photographs, etc. If the work is primarily the artistic content created by this entity, use artist or photographer
    /// <see href="http://d-nb.info/standards/elementset/gnd#illustratorOrIlluminator"></see></summary>
    let illustratorOrIlluminator = _prefix "illustratorOrIlluminator"
    /// <summary>
    /// A person, family, or corporate body who initiated a work
    /// <see href="http://d-nb.info/standards/elementset/gnd#initiator"></see></summary>
    let initiator = _prefix "initiator"
    /// <summary>
    /// A musical instrument, a device to perform music with
    /// <see href="http://d-nb.info/standards/elementset/gnd#instrument"></see></summary>
    let instrument = _prefix "instrument"
    /// <summary>
    /// A performer contributing to a resource by playing a musical instrument
    /// <see href="http://d-nb.info/standards/elementset/gnd#instrumentalist"></see></summary>
    let instrumentalist = _prefix "instrumentalist"
    /// <summary>
    /// A person, family, or organization responsible for creating a new device or process
    /// <see href="http://d-nb.info/standards/elementset/gnd#inventor"></see></summary>
    let inventor = _prefix "inventor"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#keyOfTheVersion"></see>
    /// </summary>
    let keyOfTheVersion = _prefix "keyOfTheVersion"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#keyOfTheWork"></see>
    /// </summary>
    let keyOfTheWork = _prefix "keyOfTheWork"
    /// <summary>
    /// A language used by a person or family or in which a work was written
    /// <see href="http://d-nb.info/standards/elementset/gnd#language"></see></summary>
    let language = _prefix "language"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#languageCode"></see>
    /// </summary>
    let languageCode = _prefix "languageCode"
    /// <summary>
    /// An author of a libretto of an opera or other stage work, or an oratorio
    /// <see href="http://d-nb.info/standards/elementset/gnd#librettist"></see></summary>
    let librettist = _prefix "librettist"
    /// <summary>
    /// The described entity is a realization of the related work
    /// <see href="http://d-nb.info/standards/elementset/gnd#literarySource"></see></summary>
    let literarySource = _prefix "literarySource"
    /// <summary>
    /// A person or organization who prepares the stone or plate for lithographic printing, including a graphic artist creating a design directly on the surface from which printing will be done.
    /// <see href="http://d-nb.info/standards/elementset/gnd#lithographer"></see></summary>
    let lithographer = _prefix "lithographer"
    /// <summary>
    /// A person or organization responsible for printing, duplicating, casting, etc. a resource
    /// <see href="http://d-nb.info/standards/elementset/gnd#manufacturer"></see></summary>
    let manufacturer = _prefix "manufacturer"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#mediumOfPerformance"></see>
    /// </summary>
    let mediumOfPerformance = _prefix "mediumOfPerformance"
    /// <summary>
    /// A person or organization who performs music or contributes to the musical content of a work when it is not possible or desirable to identify the function more precisely
    /// <see href="http://d-nb.info/standards/elementset/gnd#musician"></see></summary>
    let musician = _prefix "musician"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#nameAddition"></see>
    /// </summary>
    let nameAddition = _prefix "nameAddition"
    /// <summary>
    /// A performer contributing to a resource by reading or speaking in order to give an account of an act, occurrence, course of events, etc
    /// <see href="http://d-nb.info/standards/elementset/gnd#narrator"></see></summary>
    let narrator = _prefix "narrator"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#northernmostLatitude"></see>
    /// </summary>
    let northernmostLatitude = _prefix "northernmostLatitude"
    /// <summary>
    /// Reason of the entity, e.g. a work or a historic event
    /// 		is the reason of a conference, or a conference is the reason of a work.
    /// <see href="http://d-nb.info/standards/elementset/gnd#occasion"></see></summary>
    let occasion = _prefix "occasion"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#occasionOfTheSubjectHeading"></see>
    /// </summary>
    let occasionOfTheSubjectHeading = _prefix "occasionOfTheSubjectHeading"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#occasionOfTheWork"></see>
    /// </summary>
    let occasionOfTheWork = _prefix "occasionOfTheWork"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#oldAuthorityNumber"></see>
    /// </summary>
    let oldAuthorityNumber = _prefix "oldAuthorityNumber"

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#opusNumericDesignationOfMusicalWork"></see>
    /// </summary>
    let opusNumericDesignationOfMusicalWork =
        _prefix "opusNumericDesignationOfMusicalWork"

    /// <summary>
    /// A person, family, or organization organizing the exhibit, event, conference, etc., which gave rise to a resource
    /// <see href="http://d-nb.info/standards/elementset/gnd#organizerOrHost"></see></summary>
    let organizerOrHost = _prefix "organizerOrHost"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#otherPlace"></see>
    /// </summary>
    let otherPlace = _prefix "otherPlace"
    /// <summary>
    /// A person or family who paints
    /// <see href="http://d-nb.info/standards/elementset/gnd#painter"></see></summary>
    let painter = _prefix "painter"
    /// <summary>
    /// A person’s known period of activity
    /// <see href="http://d-nb.info/standards/elementset/gnd#periodOfActivity"></see></summary>
    let periodOfActivity = _prefix "periodOfActivity"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#personalName"></see>
    /// </summary>
    let personalName = _prefix "personalName"
    /// <summary>
    /// A person, family, or organization responsible for creating a photographic work
    /// <see href="http://d-nb.info/standards/elementset/gnd#photographer"></see></summary>
    let photographer = _prefix "photographer"
    /// <summary>
    /// A country, state, province, etc., or place where an organization has its headquarters
    /// <see href="http://d-nb.info/standards/elementset/gnd#place"></see></summary>
    let place = _prefix "place"
    /// <summary>
    /// A person’s or family’s place of activity
    /// <see href="http://d-nb.info/standards/elementset/gnd#placeOfActivity"></see></summary>
    let placeOfActivity = _prefix "placeOfActivity"
    /// <summary>
    /// A person’s place of birth
    /// <see href="http://d-nb.info/standards/elementset/gnd#placeOfBirth"></see></summary>
    let placeOfBirth = _prefix "placeOfBirth"
    /// <summary>
    /// This property is equivalent to gndo:placeOfBirth but gives a literal instead of
    /// 		a reference to a geographic entity
    /// <see href="http://d-nb.info/standards/elementset/gnd#placeOfBirthAsLiteral"></see></summary>
    let placeOfBirthAsLiteral = _prefix "placeOfBirthAsLiteral"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#placeOfBusiness"></see>
    /// </summary>
    let placeOfBusiness = _prefix "placeOfBusiness"
    /// <summary>
    /// A place where an event such as a conference or a concert took place
    /// <see href="http://d-nb.info/standards/elementset/gnd#placeOfConferenceOrEvent"></see></summary>
    let placeOfConferenceOrEvent = _prefix "placeOfConferenceOrEvent"
    /// <summary>
    /// A place where something is kept
    /// <see href="http://d-nb.info/standards/elementset/gnd#placeOfCustody"></see></summary>
    let placeOfCustody = _prefix "placeOfCustody"
    /// <summary>
    /// A person’s place of death
    /// <see href="http://d-nb.info/standards/elementset/gnd#placeOfDeath"></see></summary>
    let placeOfDeath = _prefix "placeOfDeath"
    /// <summary>
    /// This property is equivalent to gndo:placeOfDeath but gives a literal instead of
    /// 		a reference to a geographic entity
    /// <see href="http://d-nb.info/standards/elementset/gnd#placeOfDeathAsLiteral"></see></summary>
    let placeOfDeathAsLiteral = _prefix "placeOfDeathAsLiteral"
    /// <summary>
    /// A place where a work or thing was found
    /// <see href="http://d-nb.info/standards/elementset/gnd#placeOfDiscovery"></see></summary>
    let placeOfDiscovery = _prefix "placeOfDiscovery"
    /// <summary>
    /// A place where a person or family dwelt in exile (lived in exile)
    /// <see href="http://d-nb.info/standards/elementset/gnd#placeOfExile"></see></summary>
    let placeOfExile = _prefix "placeOfExile"
    /// <summary>
    /// A place where a work or thing was manufactured
    /// <see href="http://d-nb.info/standards/elementset/gnd#placeOfManufacture"></see></summary>
    let placeOfManufacture = _prefix "placeOfManufacture"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#placeOrGeographicNameIsMember"></see>
    /// </summary>
    let placeOrGeographicNameIsMember = _prefix "placeOrGeographicNameIsMember"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#playedInstrument"></see>
    /// </summary>
    let playedInstrument = _prefix "playedInstrument"
    /// <summary>
    /// An author of the words of a non-dramatic musical work (e.g. the text of a song), except for oratorios
    /// <see href="http://d-nb.info/standards/elementset/gnd#poet"></see></summary>
    let poet = _prefix "poet"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#precedingConferenceOrEvent"></see>
    /// </summary>
    let precedingConferenceOrEvent = _prefix "precedingConferenceOrEvent"
    /// <summary>
    /// A corporate body or a work being the predecessor of another corporate body or work
    /// <see href="http://d-nb.info/standards/elementset/gnd#predecessor"></see></summary>
    let predecessor = _prefix "predecessor"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#precedingCorporateBody"></see>
    /// </summary>
    let precedingCorporateBody = _prefix "precedingCorporateBody"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#precedingPlaceOrGeographicName"></see>
    /// </summary>
    let precedingPlaceOrGeographicName = _prefix "precedingPlaceOrGeographicName"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#precedingSubject"></see>
    /// </summary>
    let precedingSubject = _prefix "precedingSubject"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#precedingWork"></see>
    /// </summary>
    let precedingWork = _prefix "precedingWork"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#preferredName"></see>
    /// </summary>
    let preferredName = _prefix "preferredName"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#preferredNameEntityForThePerson"></see>
    /// </summary>
    let preferredNameEntityForThePerson = _prefix "preferredNameEntityForThePerson"

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#preferredNameForTheConferenceOrEvent"></see>
    /// </summary>
    let preferredNameForTheConferenceOrEvent =
        _prefix "preferredNameForTheConferenceOrEvent"

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#preferredNameForTheCorporateBody"></see>
    /// </summary>
    let preferredNameForTheCorporateBody = _prefix "preferredNameForTheCorporateBody"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#preferredNameForTheFamily"></see>
    /// </summary>
    let preferredNameForTheFamily = _prefix "preferredNameForTheFamily"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#preferredNameForThePerson"></see>
    /// </summary>
    let preferredNameForThePerson = _prefix "preferredNameForThePerson"

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#preferredNameForThePlaceOrGeographicName"></see>
    /// </summary>
    let preferredNameForThePlaceOrGeographicName =
        _prefix "preferredNameForThePlaceOrGeographicName"

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#preferredNameForTheSubjectHeading"></see>
    /// </summary>
    let preferredNameForTheSubjectHeading = _prefix "preferredNameForTheSubjectHeading"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#preferredNameForTheWork"></see>
    /// </summary>
    let preferredNameForTheWork = _prefix "preferredNameForTheWork"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#prefix"></see>
    /// </summary>
    let prefix = _prefix "prefix"
    /// <summary>
    /// A person, family, or organization involved in manufacturing a manifestation of printed text, notated music, etc., from type or plates, such as a book, newspaper, magazine, broadside, score, etc
    /// <see href="http://d-nb.info/standards/elementset/gnd#printer"></see></summary>
    let printer = _prefix "printer"
    /// <summary>
    /// A profession or occupation practiced by a person or family
    /// <see href="http://d-nb.info/standards/elementset/gnd#professionOrOccupation"></see></summary>
    let professionOrOccupation = _prefix "professionOrOccupation"
    /// <summary>
    /// This property is equivalent to gndo:professionOrOccupation but gives a literal instead of
    /// 		a reference to a subject heading
    /// <see href="http://d-nb.info/standards/elementset/gnd#professionOrOccupationAsLiteral"></see></summary>
    let professionOrOccupationAsLiteral = _prefix "professionOrOccupationAsLiteral"
    /// <summary>
    /// An occupational relationship between a person or family and another person or family
    /// <see href="http://d-nb.info/standards/elementset/gnd#professionalRelationship"></see></summary>
    let professionalRelationship = _prefix "professionalRelationship"
    /// <summary>
    /// Links a person's real identity to an identity under which one or more persons act, e. g. write, compose or create art, but that is not the person's real name (i. e. a pseudonym).
    /// <see href="http://d-nb.info/standards/elementset/gnd#pseudonym"></see></summary>
    let pseudonym = _prefix "pseudonym"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#relatedPerson"></see>
    /// </summary>
    let relatedPerson = _prefix "relatedPerson"
    /// <summary>
    /// Links an identity under which one or more persons act, e. g. write, compose or create art, but that is not their real name (i. e. a pseudonym) to their real identity.
    /// <see href="http://d-nb.info/standards/elementset/gnd#realIdentity"></see></summary>
    let realIdentity = _prefix "realIdentity"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#publication"></see>
    /// </summary>
    let publication = _prefix "publication"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#relatedConferenceOrEvent"></see>
    /// </summary>
    let relatedConferenceOrEvent = _prefix "relatedConferenceOrEvent"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#relatedCorporateBody"></see>
    /// </summary>
    let relatedCorporateBody = _prefix "relatedCorporateBody"

    /// <summary>
    /// The connotation scope of the GND entity corresponds to a small part
    ///       to the connotation scope of the assigned DDC class.
    /// <see href="http://d-nb.info/standards/elementset/gnd#relatedDdcWithDegreeOfDeterminacy1"></see></summary>
    let relatedDdcWithDegreeOfDeterminacy1 =
        _prefix "relatedDdcWithDegreeOfDeterminacy1"

    /// <summary>
    /// The connotation scope of the GND entity is identical or nearly
    ///       identical to the connotation scope of a topic that is logically part of the class but is less
    ///       extensive in scope than the concept represented by the class number.
    /// <see href="http://d-nb.info/standards/elementset/gnd#relatedDdcWithDegreeOfDeterminacy2"></see></summary>
    let relatedDdcWithDegreeOfDeterminacy2 =
        _prefix "relatedDdcWithDegreeOfDeterminacy2"

    /// <summary>
    /// The connotation scope of the GND entity is identical or nearly
    ///       identical to the connotation scope of a topic that approximates the whole of the assigned DDC
    ///       class. According to DDC terms, topics that are nearly coextensive with the full meaning of a
    ///       class or cover more than half of the content of the class approximate the whole of the DDC
    ///       class.
    /// <see href="http://d-nb.info/standards/elementset/gnd#relatedDdcWithDegreeOfDeterminacy3"></see></summary>
    let relatedDdcWithDegreeOfDeterminacy3 =
        _prefix "relatedDdcWithDegreeOfDeterminacy3"

    /// <summary>
    /// The connotation scope of the GND entity is identical to the
    ///       connotation scope of the topic emphasized in the DDC class heading.
    /// <see href="http://d-nb.info/standards/elementset/gnd#relatedDdcWithDegreeOfDeterminacy4"></see></summary>
    let relatedDdcWithDegreeOfDeterminacy4 =
        _prefix "relatedDdcWithDegreeOfDeterminacy4"

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#relatedFamily"></see>
    /// </summary>
    let relatedFamily = _prefix "relatedFamily"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#relatedPlaceOrGeographicName"></see>
    /// </summary>
    let relatedPlaceOrGeographicName = _prefix "relatedPlaceOrGeographicName"
    /// <summary>
    /// Use relatedSubjectHeading ('subject', not 'subjec') instead
    /// <see href="http://d-nb.info/standards/elementset/gnd#relatedSubjecHeading"></see></summary>
    let relatedSubjecHeading = _prefix "relatedSubjecHeading"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#relatedSubjectHeading"></see>
    /// </summary>
    let relatedSubjectHeading = _prefix "relatedSubjectHeading"
    /// <summary>
    /// The associative relationship covers associations between pairs of
    ///       concepts that are not related hierarchically, but are semantically or concetually associated
    ///       to such an extent that the link between them needs to be made explicit in the thesaurus.
    /// <see href="http://d-nb.info/standards/elementset/gnd#relatedTerm"></see></summary>
    let relatedTerm = _prefix "relatedTerm"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#relatedWork"></see>
    /// </summary>
    let relatedWork = _prefix "relatedWork"
    /// <summary>
    /// A person, family, or organization responsible for the set of technical, editorial, and intellectual procedures aimed at compensating for the degradation of an item by bringing it back to a state as close as possible to its original condition
    /// <see href="http://d-nb.info/standards/elementset/gnd#restorer"></see></summary>
    let restorer = _prefix "restorer"
    /// <summary>
    /// A person or organization who 1) reworks a musical composition, usually for a different medium, or 2) rewrites novels or stories for motion pictures or other audiovisual medium.
    /// <see href="http://d-nb.info/standards/elementset/gnd#revisor"></see></summary>
    let revisor = _prefix "revisor"
    /// <summary>
    /// An author of a screenplay, script, or scene
    /// <see href="http://d-nb.info/standards/elementset/gnd#screenwriter"></see></summary>
    let screenwriter = _prefix "screenwriter"
    /// <summary>
    /// A scriptorium in a monastery
    /// <see href="http://d-nb.info/standards/elementset/gnd#scriptorium"></see></summary>
    let scriptorium = _prefix "scriptorium"
    /// <summary>
    /// An artist responsible for creating a three-dimensional work by modeling, carving, or similar technique
    /// <see href="http://d-nb.info/standards/elementset/gnd#sculptor"></see></summary>
    let sculptor = _prefix "sculptor"

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#serialNumericDesignationOfMusicalWork"></see>
    /// </summary>
    let serialNumericDesignationOfMusicalWork =
        _prefix "serialNumericDesignationOfMusicalWork"

    /// <summary>
    /// A performer contributing to a resource by using his/her/their voice, with or without instrumental accompaniment, to produce music. A singer's performance may or may not include actual words
    /// <see href="http://d-nb.info/standards/elementset/gnd#singer"></see></summary>
    let singer = _prefix "singer"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#southernmostLatitude"></see>
    /// </summary>
    let southernmostLatitude = _prefix "southernmostLatitude"
    /// <summary>
    /// Geographic field of activity
    /// <see href="http://d-nb.info/standards/elementset/gnd#spatialAreaOfActivity"></see></summary>
    let spatialAreaOfActivity = _prefix "spatialAreaOfActivity"
    /// <summary>
    /// A person, family, or organization sponsoring some aspect of a resource, e.g., funding research, sponsoring an event
    /// <see href="http://d-nb.info/standards/elementset/gnd#sponsorOrPatron"></see></summary>
    let sponsorOrPatron = _prefix "sponsorOrPatron"
    /// <summary>
    /// A person or organization who writes or develops the framework for an item without being intellectually responsible for its content
    /// <see href="http://d-nb.info/standards/elementset/gnd#subeditor"></see></summary>
    let subeditor = _prefix "subeditor"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#succeedingConferenceOrEvent"></see>
    /// </summary>
    let succeedingConferenceOrEvent = _prefix "succeedingConferenceOrEvent"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#successor"></see>
    /// </summary>
    let successor = _prefix "successor"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#succeedingCorporateBody"></see>
    /// </summary>
    let succeedingCorporateBody = _prefix "succeedingCorporateBody"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#succeedingPlaceOrGeographicName"></see>
    /// </summary>
    let succeedingPlaceOrGeographicName = _prefix "succeedingPlaceOrGeographicName"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#succeedingSubjectHeading"></see>
    /// </summary>
    let succeedingSubjectHeading = _prefix "succeedingSubjectHeading"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#succeedingWork"></see>
    /// </summary>
    let succeedingWork = _prefix "succeedingWork"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#surname"></see>
    /// </summary>
    let surname = _prefix "surname"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#temporaryName"></see>
    /// </summary>
    let temporaryName = _prefix "temporaryName"

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#temporaryNameOfTheConferenceOrEvent"></see>
    /// </summary>
    let temporaryNameOfTheConferenceOrEvent =
        _prefix "temporaryNameOfTheConferenceOrEvent"

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#temporaryNameOfTheCorporateBody"></see>
    /// </summary>
    let temporaryNameOfTheCorporateBody = _prefix "temporaryNameOfTheCorporateBody"

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#temporaryNameOfThePlaceOrGeographicName"></see>
    /// </summary>
    let temporaryNameOfThePlaceOrGeographicName =
        _prefix "temporaryNameOfThePlaceOrGeographicName"

    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#thematicIndexNumericDesignationOfMusicalWork"></see>
    /// </summary>
    let thematicIndexNumericDesignationOfMusicalWork =
        _prefix "thematicIndexNumericDesignationOfMusicalWork"

    /// <summary>
    /// A title of nobility held by a person or family.
    /// <see href="http://d-nb.info/standards/elementset/gnd#titleOfNobility"></see></summary>
    let titleOfNobility = _prefix "titleOfNobility"
    /// <summary>
    /// A title of nobility held by a person or family.
    /// 		This property is equivalent to gndo:titleOfNobility
    /// 		but gives a literal instead of a reference to a subject heading.
    /// <see href="http://d-nb.info/standards/elementset/gnd#titleOfNobilityAsLiteral"></see></summary>
    let titleOfNobilityAsLiteral = _prefix "titleOfNobilityAsLiteral"
    /// <summary>
    /// Topic that is related to a corporate body, conference, person, family, subject heading or work.
    /// <see href="http://d-nb.info/standards/elementset/gnd#topic"></see></summary>
    let topic = _prefix "topic"
    /// <summary>
    /// A person or organization who renders a text from one language into another, or from an older form of a language into the modern form
    /// <see href="http://d-nb.info/standards/elementset/gnd#translator"></see></summary>
    let translator = _prefix "translator"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#typeOfCoordinates"></see>
    /// </summary>
    let typeOfCoordinates = _prefix "typeOfCoordinates"
    /// <summary>
    /// Date, expressed as UDK code
    /// <see href="http://d-nb.info/standards/elementset/gnd#udkCode"></see></summary>
    let udkCode = _prefix "udkCode"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#variantName"></see>
    /// </summary>
    let variantName = _prefix "variantName"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#variantNameEntityForThePerson"></see>
    /// </summary>
    let variantNameEntityForThePerson = _prefix "variantNameEntityForThePerson"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#variantNameForTheFamily"></see>
    /// </summary>
    let variantNameForTheFamily = _prefix "variantNameForTheFamily"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#variantNameForThePerson"></see>
    /// </summary>
    let variantNameForThePerson = _prefix "variantNameForThePerson"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#variantNameForTheSubjectHeading"></see>
    /// </summary>
    let variantNameForTheSubjectHeading = _prefix "variantNameForTheSubjectHeading"
    /// <summary>
    ///   <see href="http://d-nb.info/standards/elementset/gnd#westernmostLongitude"></see>
    /// </summary>
    let westernmostLongitude = _prefix "westernmostLongitude"
    /// <summary>
    /// A person or organization responsible for the commentary or explanatory notes about a text. For the writer of manuscript annotations in a printed book, use Annotator
    /// <see href="http://d-nb.info/standards/elementset/gnd#writerOfAddedCommentary"></see></summary>
    let writerOfAddedCommentary = _prefix "writerOfAddedCommentary"

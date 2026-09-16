#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module gndo =
    let _prefixId = PrefixId.fromNamespaceLabel "http://d-nb.info/standards/elementset/gnd#" "gndo"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=giv^^xsd:string</para>
    ///   <para>rdfs:label : Verwaltungseinheitrdfs:label : Administrative unit</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#AdministrativeUnit">gndo:AdministrativeUnit</a>
    /// </summary>
    let AdministrativeUnit = _prefixId.prefix "AdministrativeUnit"
    /// <summary>
    ///   <para>rdfs:label : Normdatenressourcerdfs:label : Authority Resource</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#AuthorityResource">gndo:AuthorityResource</a>
    /// </summary>
    let AuthorityResource = _prefixId.prefix "AuthorityResource"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=gib^^xsd:string</para>
    ///   <para>rdfs:label : Bauwerk oder Denkmalrdfs:label : Building or memorial</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#BuildingOrMemorial">gndo:BuildingOrMemorial</a>
    /// </summary>
    let BuildingOrMemorial = _prefixId.prefix "BuildingOrMemorial"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=slz^^xsd:string</para>
    ///   <para>rdfs:label : Buchstaben oder Morphemerdfs:label : Characters or morphemes</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#CharactersOrMorphemes">gndo:CharactersOrMorphemes</a>
    /// </summary>
    let CharactersOrMorphemes = _prefixId.prefix "CharactersOrMorphemes"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=win^^xsd:string</para>
    ///   <para>rdfs:label : Sammlungrdfs:label : Collection</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#Collection">gndo:Collection</a>
    /// </summary>
    let Collection = _prefixId.prefix "Collection"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=wil^^xsd:string</para>
    ///   <para>rdfs:label : Sammelhandschriftrdfs:label : Collective manuscript</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#CollectiveManuscript">gndo:CollectiveManuscript</a>
    /// </summary>
    let CollectiveManuscript = _prefixId.prefix "CollectiveManuscript"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=pis^^xsd:string</para>
    ///   <para>rdfs:label : Sammelpseudonymrdfs:label : Collective pseudonym</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#CollectivePseudonym">gndo:CollectivePseudonym</a>
    /// </summary>
    let CollectivePseudonym = _prefixId.prefix "CollectivePseudonym"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=kif^^xsd:string</para>
    ///   <para>rdfs:label : Firmardfs:label : Company</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#Company">gndo:Company</a>
    /// </summary>
    let Company = _prefixId.prefix "Company"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $b=f^^xsd:stringgndo:marc21equivalent : 079 $v=vie^^xsd:string</para>
    ///   <para>rdfs:label : Konferenz oder Veranstaltungrdfs:label : Conference or Event</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#ConferenceOrEvent">gndo:ConferenceOrEvent</a>
    /// </summary>
    let ConferenceOrEvent = _prefixId.prefix "ConferenceOrEvent"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=kiz^^xsd:stringgndo:marc21equivalent : 079 $b=b^^xsd:string</para>
    ///   <para>rdfs:label : Corporate Bodyrdfs:label : Körperschaft</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#CorporateBody">gndo:CorporateBody</a>
    /// </summary>
    let CorporateBody = _prefixId.prefix "CorporateBody"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=gil^^xsd:string</para>
    ///   <para>rdfs:label : Land oder Staatrdfs:label : Country</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#Country">gndo:Country</a>
    /// </summary>
    let Country = _prefixId.prefix "Country"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $b=p^^xsd:stringgndo:marc21equivalent : 079 $v=piz^^xsd:string</para>
    ///   <para>rdfs:label : Individualisierte Personrdfs:label : Differentiated person</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#DifferentiatedPerson">gndo:DifferentiatedPerson</a>
    /// </summary>
    let DifferentiatedPerson = _prefixId.prefix "DifferentiatedPerson"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 400 $4=nafr^^xsd:string</para>
    ///   <para>rdfs:label : Früherer Name der Personrdfs:label : Earlier name of the person</para>
    ///   <para>rdfs:comment : Der vorliegende abweichende Name ist der frühere Name einer Person,
    /// 		wie beispielsweise der Geburtsname, frühere Ehename usw.</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#EarlierNameOfThePerson">gndo:EarlierNameOfThePerson</a>
    /// </summary>
    let EarlierNameOfThePerson = _prefixId.prefix "EarlierNameOfThePerson"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=sie^^xsd:string</para>
    ///   <para>rdfs:label : Ethnografikumrdfs:label : Ethnographic name</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#EthnographicName">gndo:EthnographicName</a>
    /// </summary>
    let EthnographicName = _prefixId.prefix "EthnographicName"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=wie^^xsd:string</para>
    ///   <para>rdfs:label : Expressionrdfs:label : Expression</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#Expression">gndo:Expression</a>
    /// </summary>
    let Expression = _prefixId.prefix "Expression"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=gix^^xsd:string</para>
    ///   <para>rdfs:label : Extraterrestrikumrdfs:label : Extraterrestrial territory</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#ExtraterrestrialTerritory">gndo:ExtraterrestrialTerritory</a>
    /// </summary>
    let ExtraterrestrialTerritory = _prefixId.prefix "ExtraterrestrialTerritory"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=pif^^xsd:string</para>
    ///   <para>rdfs:label : Familierdfs:label : Family</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#Family">gndo:Family</a>
    /// </summary>
    let Family = _prefixId.prefix "Family"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=kxz^^xsd:string</para>
    ///   <para>rdfs:label : Fiktive Körperschaftrdfs:label : Fictive corporate body</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#FictiveCorporateBody">gndo:FictiveCorporateBody</a>
    /// </summary>
    let FictiveCorporateBody = _prefixId.prefix "FictiveCorporateBody"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=gxz^^xsd:string</para>
    ///   <para>rdfs:label : Fiktiver Ortrdfs:label : Fictive place</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#FictivePlace">gndo:FictivePlace</a>
    /// </summary>
    let FictivePlace = _prefixId.prefix "FictivePlace"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=sxz^^xsd:string</para>
    ///   <para>rdfs:label : Fiktiver Sachbegriffrdfs:label : Fictive term</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#FictiveTerm">gndo:FictiveTerm</a>
    /// </summary>
    let FictiveTerm = _prefixId.prefix "FictiveTerm"
    /// <summary>
    ///   <para>rdfs:label : Fiktiver Sachbegriffrdfs:label : Fictive term</para>
    ///   <para>gndo:marc21equivalent : 079 $v=sxz^^xsd:string</para>
    ///   <para>rdfs:comment : Bitte verwenden Sie FictiveTermrdfs:comment : Use FictiveTerm instead</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#Fictive_term">gndo:Fictive_term</a>
    /// </summary>
    let Fictive_term = _prefixId.prefix "Fictive_term"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 400 $4=navo^^xsd:string</para>
    ///   <para>rdfs:label : Vollständiger Name der Personrdfs:label : Fuller form of the name of the person</para>
    ///   <para>rdfs:comment : Die vorliegende abweichende Namensform ist die vollständig aufgelöste Form des
    /// 		bevorzugten Namens, der abgekürzte Formen enthält.rdfs:comment : The complete or a fuller form of name of a person, family or corporate body</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#FullerFormOfNameOfThePerson">gndo:FullerFormOfNameOfThePerson</a>
    /// </summary>
    let FullerFormOfNameOfThePerson = _prefixId.prefix "FullerFormOfNameOfThePerson"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=pxg^^xsd:string</para>
    ///   <para>rdfs:label : Götterrdfs:label : Gods</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#Gods">gndo:Gods</a>
    /// </summary>
    let Gods = _prefixId.prefix "Gods"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=siu^^xsd:string</para>
    ///   <para>rdfs:label : Personengrupperdfs:label : Group of persons</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#GroupOfPersons">gndo:GroupOfPersons</a>
    /// </summary>
    let GroupOfPersons = _prefixId.prefix "GroupOfPersons"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=sih^^xsd:string</para>
    ///   <para>rdfs:label : Historisches Einzelereignis oder Epocherdfs:label : Historic single event or era</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#HistoricSingleEventOrEra">gndo:HistoricSingleEventOrEra</a>
    /// </summary>
    let HistoricSingleEventOrEra = _prefixId.prefix "HistoricSingleEventOrEra"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=sis^^xsd:string</para>
    ///   <para>rdfs:label : Spracherdfs:label : Language</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#Language">gndo:Language</a>
    /// </summary>
    let Language = _prefixId.prefix "Language"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 400 $4=nasp^^xsd:string</para>
    ///   <para>rdfs:label : Späterer Name der Personrdfs:label : Later name of the person</para>
    ///   <para>rdfs:comment : Die vorliegende abweichende Namensform ist der spätere Name einer Person, wie der
    /// 		Ehename etc., der nicht als bevorzugter Name gewählt wird.</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#LaterNameOfThePerson">gndo:LaterNameOfThePerson</a>
    /// </summary>
    let LaterNameOfThePerson = _prefixId.prefix "LaterNameOfThePerson"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=pxl^^xsd:string</para>
    ///   <para>rdfs:label : Literarische oder Sagengestaltrdfs:label : Literary or legendary character</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#LiteraryOrLegendaryCharacter">gndo:LiteraryOrLegendaryCharacter</a>
    /// </summary>
    let LiteraryOrLegendaryCharacter = _prefixId.prefix "LiteraryOrLegendaryCharacter"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=wis^^xsd:string</para>
    ///   <para>rdfs:label : Schriftdenkmalrdfs:label : Manuscript</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#Manuscript">gndo:Manuscript</a>
    /// </summary>
    let Manuscript = _prefixId.prefix "Manuscript"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=sif^^xsd:string</para>
    ///   <para>rdfs:label : Verkehrsmittel mit Individualnamenrdfs:label : Means of transport with individual name</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#MeansOfTransportWithIndividualName">gndo:MeansOfTransportWithIndividualName</a>
    /// </summary>
    let MeansOfTransportWithIndividualName = _prefixId.prefix "MeansOfTransportWithIndividualName"

    /// <summary>
    ///   <para>rdfs:comment : Use gndo:MeansOfTransportWithIndividualNamerdfs:comment : Bitte verwenden Sie gndo:MeansOfTransportWithIndividualName</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>gndo:marc21equivalent : 079 $v=sif^^xsd:string</para>
    ///   <para>rdfs:label : Means of transport with individual namerdfs:label : Verkehrsmittel mit Individualnamen</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#MeansOfTransportWithIndividual_name">gndo:MeansOfTransportWithIndividual_name</a>
    /// </summary>
    let MeansOfTransportWithIndividual_name = _prefixId.prefix "MeansOfTransportWithIndividual_name"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=gif^^xsd:string</para>
    ///   <para>rdfs:label : Gliedstaatrdfs:label : Member state</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#MemberState">gndo:MemberState</a>
    /// </summary>
    let MemberState = _prefixId.prefix "MemberState"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=kim^^xsd:string</para>
    ///   <para>rdfs:label : Musikalische Körperschaftrdfs:label : Musical corporate body</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#MusicalCorporateBody">gndo:MusicalCorporateBody</a>
    /// </summary>
    let MusicalCorporateBody = _prefixId.prefix "MusicalCorporateBody"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=wim^^xsd:string</para>
    ///   <para>rdfs:label : Werk der Musikrdfs:label : Musical work</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#MusicalWork">gndo:MusicalWork</a>
    /// </summary>
    let MusicalWork = _prefixId.prefix "MusicalWork"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=gio^^xsd:string</para>
    ///   <para>rdfs:label : Kleinräumiges Geografikum innerhalb eines Ortesrdfs:label : Name of small geographic unit lying within another geographic
    ///       unit</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#NameOfSmallGeographicUnitLyingWithinAnotherGeographicUnit">gndo:NameOfSmallGeographicUnitLyingWithinAnotherGeographicUnit</a>
    /// </summary>
    let NameOfSmallGeographicUnitLyingWithinAnotherGeographicUnit = _prefixId.prefix "NameOfSmallGeographicUnitLyingWithinAnotherGeographicUnit"

    /// <summary>
    ///   <para>rdfs:label : Personennamerdfs:label : Name of the person</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#NameOfThePerson">gndo:NameOfThePerson</a>
    /// </summary>
    let NameOfThePerson = _prefixId.prefix "NameOfThePerson"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=gin^^xsd:string</para>
    ///   <para>rdfs:label : Natürlich geografische Einheitrdfs:label : Natural geographic unit</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#NaturalGeographicUnit">gndo:NaturalGeographicUnit</a>
    /// </summary>
    let NaturalGeographicUnit = _prefixId.prefix "NaturalGeographicUnit"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=snz^^xsd:string</para>
    ///   <para>rdfs:label : Nomenklatur Biologie - Chemierdfs:label : Nomenclature in biology or chemistry</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#NomenclatureInBiologyOrChemistry">gndo:NomenclatureInBiologyOrChemistry</a>
    /// </summary>
    let NomenclatureInBiologyOrChemistry = _prefixId.prefix "NomenclatureInBiologyOrChemistry"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=kio^^xsd:string</para>
    ///   <para>rdfs:label : Organ einer Körperschaftrdfs:label : Organ of corporate body</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#OrganOfCorporateBody">gndo:OrganOfCorporateBody</a>
    /// </summary>
    let OrganOfCorporateBody = _prefixId.prefix "OrganOfCorporateBody"
    /// <summary>
    ///   <para>rdfs:label : Personrdfs:label : Person</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#Person">gndo:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $b=g^^xsd:stringgndo:marc21equivalent : 079 $v=giz^^xsd:string</para>
    ///   <para>rdfs:label : Geografikumrdfs:label : Place or geographic name</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#PlaceOrGeographicName">gndo:PlaceOrGeographicName</a>
    /// </summary>
    let PlaceOrGeographicName = _prefixId.prefix "PlaceOrGeographicName"
    /// <summary>
    ///   <para>rdfs:label : Bevorzugter Name der Personrdfs:label : Preferred name of the person</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#PreferredNameOfThePerson">gndo:PreferredNameOfThePerson</a>
    /// </summary>
    let PreferredNameOfThePerson = _prefixId.prefix "PreferredNameOfThePerson"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=sip^^xsd:string</para>
    ///   <para>rdfs:label : Produkt oder Markennamerdfs:label : Product name or brand name</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#ProductNameOrBrandName">gndo:ProductNameOrBrandName</a>
    /// </summary>
    let ProductNameOrBrandName = _prefixId.prefix "ProductNameOrBrandName"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=kip^^xsd:string</para>
    ///   <para>rdfs:label : Projekt oder Programmrdfs:label : Project or program</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#ProjectOrProgram">gndo:ProjectOrProgram</a>
    /// </summary>
    let ProjectOrProgram = _prefixId.prefix "ProjectOrProgram"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=wip^^xsd:string</para>
    ///   <para>rdfs:label : Provenienzmerkmalrdfs:label : Provenance characteristic</para>
    ///   <para>rdfs:comment : Provenienzmerkmale bezeichnen spuren, die
    /// 	Vorbesitzer (Personen und Institutionen) in und auf Büchern, Handschriften
    /// 	oder anderen Artefakten hinterlassen haben. Diese Merkmale kennzeichnen
    /// 	Besitz, Lesespuren oder Zensurabsichten.</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#ProvenanceCharacteristic">gndo:ProvenanceCharacteristic</a>
    /// </summary>
    let ProvenanceCharacteristic = _prefixId.prefix "ProvenanceCharacteristic"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=pip^^xsd:string</para>
    ///   <para>rdfs:label : Pseudonymrdfs:label : Pseudonym</para>
    ///   <para>rdfs:comment : Die vorliegende abweichende Namensform ist der
    /// 			wirkliche Name einer Person, für die als bevorzugter Name ein Pseudonym
    /// 			gewählt wird.</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#Pseudonym">gndo:Pseudonym</a>
    /// </summary>
    let Pseudonym = _prefixId.prefix "Pseudonym"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 400 $4=pseu^^xsd:string</para>
    ///   <para>rdfs:label : Pseudonym der Personrdfs:label : Pseudonym name of the person</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#PseudonymNameOfThePerson">gndo:PseudonymNameOfThePerson</a>
    /// </summary>
    let PseudonymNameOfThePerson = _prefixId.prefix "PseudonymNameOfThePerson"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 400 $4=nawi^^xsd:string</para>
    ///   <para>rdfs:label : Wirklicher Name der Personrdfs:label : Real name of the person</para>
    ///   <para>rdfs:comment : Der wirkliche Name einer Personrdfs:comment : The person’s real name</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#RealNameOfThePerson">gndo:RealNameOfThePerson</a>
    /// </summary>
    let RealNameOfThePerson = _prefixId.prefix "RealNameOfThePerson"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=kiv^^xsd:string</para>
    ///   <para>rdfs:label : Religiöse Verwaltungseinheitrdfs:label : Religious administrative unit</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#ReligiousAdministrativeUnit">gndo:ReligiousAdministrativeUnit</a>
    /// </summary>
    let ReligiousAdministrativeUnit = _prefixId.prefix "ReligiousAdministrativeUnit"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=kir^^xsd:string</para>
    ///   <para>rdfs:label : Religiöse Körperschaftrdfs:label : Religious corporate body</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#ReligiousCorporateBody">gndo:ReligiousCorporateBody</a>
    /// </summary>
    let ReligiousCorporateBody = _prefixId.prefix "ReligiousCorporateBody"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=gir^^xsd:string</para>
    ///   <para>rdfs:label : Religiöses Territoriumrdfs:label : Religious territory</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#ReligiousTerritory">gndo:ReligiousTerritory</a>
    /// </summary>
    let ReligiousTerritory = _prefixId.prefix "ReligiousTerritory"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=pik^^xsd:string</para>
    ///   <para>rdfs:label : Regierender Fürst oder Mitglied eines regierenden
    ///       Fürstenhausesrdfs:label : Royal or member of a royal house</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#RoyalOrMemberOfARoyalHouse">gndo:RoyalOrMemberOfARoyalHouse</a>
    /// </summary>
    let RoyalOrMemberOfARoyalHouse = _prefixId.prefix "RoyalOrMemberOfARoyalHouse"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=vif^^xsd:string</para>
    ///   <para>rdfs:label : Kongressfolge oder Veranstaltungsfolgerdfs:label : Series of conference or event</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#SeriesOfConferenceOrEvent">gndo:SeriesOfConferenceOrEvent</a>
    /// </summary>
    let SeriesOfConferenceOrEvent = _prefixId.prefix "SeriesOfConferenceOrEvent"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=siw^^xsd:string</para>
    ///   <para>rdfs:label : Softwareproduktrdfs:label : Software product</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#SoftwareProduct">gndo:SoftwareProduct</a>
    /// </summary>
    let SoftwareProduct = _prefixId.prefix "SoftwareProduct"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=pxs^^xsd:string</para>
    ///   <para>rdfs:label : Geisterrdfs:label : Spirits</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#Spirits">gndo:Spirits</a>
    /// </summary>
    let Spirits = _prefixId.prefix "Spirits"

    /// <summary>
    ///   <para>rdfs:comment : Bitte verwenden sie startingOrFinalPointOfADistance (mit kleinem s)rdfs:comment : Use startingOrFinalPointOfADistance (with a minor s) instead</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Beginn und Ende einer Streckerdfs:label : Starting or final point of a distance</para>
    ///   <para>gndo:marc21equivalent : 551 $0 $4=punk^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#StartingOrFinalPointOfADistance">gndo:StartingOrFinalPointOfADistance</a>
    /// </summary>
    let StartingOrFinalPointOfADistance = _prefixId.prefix "StartingOrFinalPointOfADistance"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $b=s^^xsd:stringgndo:marc21equivalent : 079 $v=szz^^xsd:string</para>
    ///   <para>rdfs:label : Schlagwortrdfs:label : Subject heading</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#SubjectHeading">gndo:SubjectHeading</a>
    /// </summary>
    let SubjectHeading = _prefixId.prefix "SubjectHeading"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=saz^^xsd:string</para>
    ///   <para>rdfs:label : Schlagwort senso strictordfs:label : Subject heading senso stricto</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#SubjectHeadingSensoStricto">gndo:SubjectHeadingSensoStricto</a>
    /// </summary>
    let SubjectHeadingSensoStricto = _prefixId.prefix "SubjectHeadingSensoStricto"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=gik^^xsd:string</para>
    ///   <para>rdfs:label : Gebietskörperschaft oder Verwaltungseinheitrdfs:label : Territorial corporate body or administrative unit</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#TerritorialCorporateBodyOrAdministrativeUnit">gndo:TerritorialCorporateBodyOrAdministrativeUnit</a>
    /// </summary>
    let TerritorialCorporateBodyOrAdministrativeUnit = _prefixId.prefix "TerritorialCorporateBodyOrAdministrativeUnit"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $b=n^^xsd:string</para>
    ///   <para>rdfs:label : Nicht-individualisierte Personrdfs:label : Undifferentiated person</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#UndifferentiatedPerson">gndo:UndifferentiatedPerson</a>
    /// </summary>
    let UndifferentiatedPerson = _prefixId.prefix "UndifferentiatedPerson"
    /// <summary>
    ///   <para>rdfs:label : Abweichender Name der Personrdfs:label : Variant name of the person</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#VariantNameOfThePerson">gndo:VariantNameOfThePerson</a>
    /// </summary>
    let VariantNameOfThePerson = _prefixId.prefix "VariantNameOfThePerson"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=wif^^xsd:string</para>
    ///   <para>rdfs:label : Fassung eines Werks der Musikrdfs:label : Version of a musical work</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#VersionOfAMusicalWork">gndo:VersionOfAMusicalWork</a>
    /// </summary>
    let VersionOfAMusicalWork = _prefixId.prefix "VersionOfAMusicalWork"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $v=giw^^xsd:string</para>
    ///   <para>rdfs:label : Weg, Grenze oder Linierdfs:label : Way, border or line</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#WayBorderOrLine">gndo:WayBorderOrLine</a>
    /// </summary>
    let WayBorderOrLine = _prefixId.prefix "WayBorderOrLine"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 079 $b=u^^xsd:stringgndo:marc21equivalent : 079 $v=wit^^xsd:string</para>
    ///   <para>rdfs:label : Werkrdfs:label : Work</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#Work">gndo:Work</a>
    /// </summary>
    let Work = _prefixId.prefix "Work"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 411 $a $c $d $e $g $n $4=abku^^xsd:string</para>
    ///   <para>rdfs:label : Abgekürzter Name der Konferenz oder Veranstaltungrdfs:label : Abbreviated name for the conference or event</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#abbreviatedNameForTheConferenceOrEvent">gndo:abbreviatedNameForTheConferenceOrEvent</a>
    /// </summary>
    let abbreviatedNameForTheConferenceOrEvent = _prefixId.prefix "abbreviatedNameForTheConferenceOrEvent"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 410 $a $b $g $n $4=abku^^xsd:string</para>
    ///   <para>rdfs:label : Abgekürzter Name der Körperschaftrdfs:label : Abbreviated name for the corporate body</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#abbreviatedNameForTheCorporateBody">gndo:abbreviatedNameForTheCorporateBody</a>
    /// </summary>
    let abbreviatedNameForTheCorporateBody = _prefixId.prefix "abbreviatedNameForTheCorporateBody"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 451 $a $g $z $4=abku^^xsd:string</para>
    ///   <para>rdfs:label : Abgekürzter Name des Geografikumrdfs:label : Abbreviated name for the place or geographic name</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#abbreviatedNameForThePlaceOrGeographicName">gndo:abbreviatedNameForThePlaceOrGeographicName</a>
    /// </summary>
    let abbreviatedNameForThePlaceOrGeographicName = _prefixId.prefix "abbreviatedNameForThePlaceOrGeographicName"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 430 $a $f $g $m $n $o $p $r $s $4=abku^^xsd:string</para>
    ///   <para>rdfs:label : Abgekürzter Name des Werksrdfs:label : Abbreviated name for the work</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#abbreviatedNameForTheWork">gndo:abbreviatedNameForTheWork</a>
    /// </summary>
    let abbreviatedNameForTheWork = _prefixId.prefix "abbreviatedNameForTheWork"
    /// <summary>
    ///   <para>rdfs:label : Akademischer Gradrdfs:label : Academic degree</para>
    ///   <para>rdfs:comment : Ein Rang, der als Bestätigung für wissenschaftliche Leistungen verliehen wird.rdfs:comment : An academic degree.</para>
    ///   <para>gndo:marc21equivalent : 550 $a $g $4=akad^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#academicDegree">gndo:academicDegree</a>
    /// </summary>
    let academicDegree = _prefixId.prefix "academicDegree"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 530 $0 $4=werk^^xsd:string</para>
    ///   <para>rdfs:label : Zugehöriges Werkrdfs:label : According work</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#accordingWork">gndo:accordingWork</a>
    /// </summary>
    let accordingWork = _prefixId.prefix "accordingWork"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 510 $0 $4=kueg^^xsd:stringgndo:marc21equivalent : 500 $0 $4=kueg^^xsd:string</para>
    ///   <para>rdfs:label : Zugeschriebener Künstlerrdfs:label : Accredited artist</para>
    ///   <para>rdfs:comment : An author, artist, etc., relating him/her to a resource for which there is or once was substantial authority for designating that person as author, creator, etc. of the work</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#accreditedArtist">gndo:accreditedArtist</a>
    /// </summary>
    let accreditedArtist = _prefixId.prefix "accreditedArtist"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 510 $0 $4=autg^^xsd:stringgndo:marc21equivalent : 500 $0 $4=autg^^xsd:string</para>
    ///   <para>rdfs:label : Zugeschriebener Verfasserrdfs:label : Accredited author</para>
    ///   <para>rdfs:comment : An author, artist, etc., relating him/her to a resource for which there is or once was substantial authority for designating that person as author, creator, etc. of the work</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#accreditedAuthor">gndo:accreditedAuthor</a>
    /// </summary>
    let accreditedAuthor = _prefixId.prefix "accreditedAuthor"
    /// <summary>
    ///   <para>rdfs:comment : An author, artist, etc., relating him/her to a resource for which there is or once was substantial authority for designating that person as author, creator, etc. of the work</para>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=komg^^xsd:stringgndo:marc21equivalent : 510 $0 $4=komg^^xsd:string</para>
    ///   <para>rdfs:label : Accredited composerrdfs:label : Zugeschriebener Komponist</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#accreditedComposer">gndo:accreditedComposer</a>
    /// </summary>
    let accreditedComposer = _prefixId.prefix "accreditedComposer"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=beza^^xsd:string</para>
    ///   <para>rdfs:label : Beziehung, Bekanntschaft, Freundschaftrdfs:label : Acquaintanceship or friendship</para>
    ///   <para>rdfs:comment : Relationship between a person, family, or corporate body and another person, family, or corporate body which cannot be specified more closelyrdfs:comment : Person, die mit der beschriebenen Person bekannt ist und nicht
    /// 	in familiärer oder beruflicher Beziehung steht. Für Beziehungen von oder zu Familien
    /// 	wird gndo:memberOfTheFamily verwendet.</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#acquaintanceshipOrFriendship">gndo:acquaintanceshipOrFriendship</a>
    /// </summary>
    let acquaintanceshipOrFriendship = _prefixId.prefix "acquaintanceshipOrFriendship"
    /// <summary>
    ///   <para>rdfs:label : Zusatzrdfs:label : Addition</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>gndo:marc21equivalent : 100 $g^^xsd:stringgndo:marc21equivalent : 400 $g^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#addition">gndo:addition</a>
    /// </summary>
    let addition = _prefixId.prefix "addition"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=adre^^xsd:stringgndo:marc21equivalent : 510 $0 $4=adre^^xsd:string</para>
    ///   <para>rdfs:label : Addresseerdfs:label : Adressat</para>
    ///   <para>rdfs:comment : A person, family, or organization to whom the correspondence in a work is addressed.rdfs:comment : Eine Person, Familie oder Körperschaft, an die eine Korrespondenz adressiert ist.</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#addressee">gndo:addressee</a>
    /// </summary>
    let addressee = _prefixId.prefix "addressee"
    /// <summary>
    ///   <para>rdfs:label : Affiliationrdfs:label : Affiliation</para>
    ///   <para>rdfs:comment : A corporate body associated with a person or group of persons.rdfs:comment : Eine Konferenz oder Veranstaltung, eine Körperschaft oder
    /// 		eine Gebietskörperschaft, zu der eine Person gehört oder der sie durch Anstellung,
    /// 		Mitgliedschaft, kulturelle Identität usw. zugeordnet wird.</para>
    ///   <para>gndo:marc21equivalent : 510 $0 $4=affi^^xsd:stringgndo:marc21equivalent : 551 $0 $4=affi^^xsd:stringgndo:marc21equivalent : 511 $0 $4=affi^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#affiliation">gndo:affiliation</a>
    /// </summary>
    let affiliation = _prefixId.prefix "affiliation"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 510 $a $b $g $n $4=affi^^xsd:stringgndo:marc21equivalent : 551 $a $g $z $4=affi^^xsd:stringgndo:marc21equivalent : 511 $a $c $d $e $g $n $4=affi^^xsd:string</para>
    ///   <para>rdfs:comment : Eine Konferenz oder Veranstaltung, eine Körperschaft oder eine
    /// 		Gebietskörperschaft, zu der eine Person gehört oder der sie durch Anstellung, Mitgliedschaft,
    /// 		kulturelle Identität usw. zugeordnet wird. Diese Property ist äquivalent zu gndo:affiliation,
    /// 		zeigt aber ein Literal statt eines URIs.rdfs:comment : A corporate body associated with a person or group of persons.
    /// 		This property is equivalent to gndo:affiliation but gives a literal instead of
    /// 		a URI.</para>
    ///   <para>rdfs:label : Affiliation (Literal)rdfs:label : Affiliation (Literal)</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#affiliationAsLiteral">gndo:affiliationAsLiteral</a>
    /// </summary>
    let affiliationAsLiteral = _prefixId.prefix "affiliationAsLiteral"
    let alexanderHaffner = _prefixId.prefix "alexanderHaffner"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 510 $0 $4=anno^^xsd:stringgndo:marc21equivalent : 500 $0 $4=anno^^xsd:string</para>
    ///   <para>rdfs:comment : A person who makes manuscript annotations on an item.rdfs:comment : Eine Person, Familie oder Körperschaft, die handschriftlich
    /// 		Anmerkungen in ein spezifisches Exemplar schreibt.</para>
    ///   <para>rdfs:label : Annotatorrdfs:label : Annotator</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#annotator">gndo:annotator</a>
    /// </summary>
    let annotator = _prefixId.prefix "annotator"
    /// <summary>
    ///   <para>rdfs:label : Architektrdfs:label : Architect</para>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=arch^^xsd:stringgndo:marc21equivalent : 510 $0 $4=arch^^xsd:string</para>
    ///   <para>rdfs:comment : Eine Person, Familie oder Körperschaft, die für eine architektonische
    /// 		Gestaltung verantwortlich ist, einschließlich einer bildlichen Darstellung, die zeigt, wie ein
    /// 		Gebäude o. ä. aussieht, wenn es fertig gebaut sein wird.rdfs:comment : A person, family, or organization responsible for creating an
    /// 		architectural design, including a pictorial representation intended to show how a building,
    /// 		etc., will look when completed. It also oversees the construction of structures.</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#architect">gndo:architect</a>
    /// </summary>
    let architect = _prefixId.prefix "architect"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=arra^^xsd:stringgndo:marc21equivalent : 510 $0 $4=arra^^xsd:string</para>
    ///   <para>rdfs:comment : A person, family, or organization contributing to a musical
    /// 		work by rewriting the composition for a medium of performance different from that
    /// 		for which the work was originally intended, or modifying the work for the same
    /// 		medium of performance, etc., such that the musical substance of the original
    /// 		composition remains essentially unchanged. For extensive modification that effectively
    /// 		results in the creation of a new musical work, see composer.rdfs:comment : Eine Person, eine Familie oder eine Körperschaft, die
    /// 		eine Realisierung eines Musikwerkes umschreibt oder modifiziert.</para>
    ///   <para>rdfs:label : Arrangeurrdfs:label : Arranger</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#arranger">gndo:arranger</a>
    /// </summary>
    let arranger = _prefixId.prefix "arranger"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 510 $0 $4=kuen^^xsd:stringgndo:marc21equivalent : 500 $0 $4=kuen^^xsd:string</para>
    ///   <para>rdfs:label : Artistrdfs:label : Künstler</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#artist">gndo:artist</a>
    /// </summary>
    let artist = _prefixId.prefix "artist"
    /// <summary>
    ///   <para>rdfs:label : Assoziierte Zeitrdfs:label : Associated date</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#associatedDate">gndo:associatedDate</a>
    /// </summary>
    let associatedDate = _prefixId.prefix "associatedDate"
    /// <summary>
    ///   <para>rdfs:label : Assoziierter Ortrdfs:label : Associated place</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#associatedPlace">gndo:associatedPlace</a>
    /// </summary>
    let associatedPlace = _prefixId.prefix "associatedPlace"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 510 $0 $4=auta^^xsd:stringgndo:marc21equivalent : 500 $0 $4=auta^^xsd:string</para>
    ///   <para>rdfs:label : Verfasserrdfs:label : Author</para>
    ///   <para>rdfs:comment : A person, family, or organization responsible for creating a work that is primarily textual in content, regardless of media type (e.g., printed text, spoken word, electronic text, tactile text) or genre (e.g., poems, novels, screenplays, blogs). Use also for persons, etc., creating a new work by paraphrasing, rewriting, or adapting works by another creator such that the modification has substantially changed the nature and content of the original or changed the medium of expression</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#author">gndo:author</a>
    /// </summary>
    let author = _prefixId.prefix "author"
    /// <summary>
    ///   <para>rdfs:label : Begin einer Perioderdfs:label : Beginning of a period</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#beginningOfPeriod">gndo:beginningOfPeriod</a>
    /// </summary>
    let beginningOfPeriod = _prefixId.prefix "beginningOfPeriod"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 510 $0 $4=stif^^xsd:stringgndo:marc21equivalent : 500 $0 $4=stif^^xsd:string</para>
    ///   <para>rdfs:comment : A person, family, or corporate body being the benefactor of a work, a thing, or a corporate bodyrdfs:comment : Eine Person, Familie oder Körperschaft, die ein Werk, eine Sache oder eine Körperschaft gestiftet hat</para>
    ///   <para>rdfs:label : Benefactorrdfs:label : Stifter</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#benefactor">gndo:benefactor</a>
    /// </summary>
    let benefactor = _prefixId.prefix "benefactor"

    /// <summary>
    ///   <para>rdfs:comment : Zusammenfassung von wesentlichen biografischen, geschichtlichen oder
    ///       anderen Informationen über die zu beschreibende Entität.rdfs:comment : Summary of the essential biographical, historical, or other
    ///       information about the described entity.</para>
    ///   <para>gndo:marc21equivalent : 678 $b^^xsd:string</para>
    ///   <para>rdfs:label : Biographical or historical informationrdfs:label : Biografische oder historische Angaben</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#biographicalOrHistoricalInformation">gndo:biographicalOrHistoricalInformation</a>
    /// </summary>
    let biographicalOrHistoricalInformation = _prefixId.prefix "biographicalOrHistoricalInformation"

    /// <summary>
    ///   <para>rdfs:label : Bookbinderrdfs:label : Buchbinder</para>
    ///   <para>rdfs:comment : A person who binds an item</para>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=bubi^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#bookbinder">gndo:bookbinder</a>
    /// </summary>
    let bookbinder = _prefixId.prefix "bookbinder"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 510 $0 $4=gest^^xsd:stringgndo:marc21equivalent : 500 $0 $4=gest^^xsd:string</para>
    ///   <para>rdfs:label : Bookdesignerrdfs:label : Buchgestalter</para>
    ///   <para>rdfs:comment : A person or organization involved in manufacturing a manifestation by being responsible for the entire graphic design of a book, including arrangement of type and illustration, choice of materials, and process used</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#bookdesigner">gndo:bookdesigner</a>
    /// </summary>
    let bookdesigner = _prefixId.prefix "bookdesigner"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Oberbegriffrdfs:label : Broader term</para>
    ///   <para>rdfs:comment : Use broader term general insteadrdfs:comment : Bitte verwenden Sie Oberbegriff allgemein</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#broaderTerm">gndo:broaderTerm</a>
    /// </summary>
    let broaderTerm = _prefixId.prefix "broaderTerm"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 550 $0 $4=obal^^xsd:string</para>
    ///   <para>rdfs:label : Oberbegriff allgemeinrdfs:label : Broader term (general)</para>
    ///   <para>rdfs:comment : Broader term</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#broaderTermGeneral">gndo:broaderTermGeneral</a>
    /// </summary>
    let broaderTermGeneral = _prefixId.prefix "broaderTermGeneral"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 550 $0 $4=obge^^xsd:string</para>
    ///   <para>rdfs:label : Oberbegriff generischrdfs:label : Broader term (generic)</para>
    ///   <para>rdfs:comment : The generic relation is a semantic relation between two concepts
    ///       where the intension of one of the concepts includes that of the other concepts and at least
    ///       one additional delimiting characteristic is added.rdfs:comment : Eine generische Relation ist eine hierarchische Relation zwischen
    ///       zwei Begriffen, von denen der untergeordnete Begriff alle Merkmale des übergeordneten Begriffs
    ///       besitzt und zusätzlich noch mindestens ein weiteres Merkmal.</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#broaderTermGeneric">gndo:broaderTermGeneric</a>
    /// </summary>
    let broaderTermGeneric = _prefixId.prefix "broaderTermGeneric"
    /// <summary>
    ///   <para>rdfs:label : Oberbegriff instantiellrdfs:label : Broader term (instantial)</para>
    ///   <para>gndo:marc21equivalent : 550 $0 $4=obin^^xsd:string</para>
    ///   <para>rdfs:comment : Die Instanzbeziehung verbindet ein allgemeines Konzept, etwa eine
    ///       Klasse von Dingen oder Ereignissen mit einem individuellen Exemplar dieser Klasse, das oft
    ///       durch einen Eigennamen repräsentiert wird.rdfs:comment : The instance relationship links a general concept such as a class of
    ///       things or events, and an individual instance oft hat class, which is often represented by a
    ///       proper name.</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#broaderTermInstantial">gndo:broaderTermInstantial</a>
    /// </summary>
    let broaderTermInstantial = _prefixId.prefix "broaderTermInstantial"
    /// <summary>
    ///   <para>rdfs:label : Broader term (partitive)rdfs:label : Oberbegriff partitiv</para>
    ///   <para>rdfs:comment : The hierarchical whole-part relationship covers a limited range of
    ///       situations in which a part of an entity or system belongs uniquely to a particular possessing
    ///       whole. When applied to persons, this is the relation between a single person (particularly gods)
    /// 	  and hierarchically broader groups of gods and mythologic entities.rdfs:comment : Eine partitive Relation ist eine hierarchische
    /// 	Relation zwischen zwei Begriffen, von denen der übergeordnete Begriff
    /// 	(Verbandsbegriff) einem Ganzen entspricht  und der untergeordnete Begriff
    /// 	einen der Bestandteile dieses Ganzen repräsentiert. Bei Personen ist die
    /// 	Relation die Beziehung zwischen einer einzelnen Person (besonders
    /// 	Gottheiten) und übergeordneten Gruppen von Göttern und mythologische Gestalten.</para>
    ///   <para>gndo:marc21equivalent : 551 $0 $4=obpa^^xsd:stringgndo:marc21equivalent : 550 $0 $4=obpa^^xsd:stringgndo:marc21equivalent : 530 $0 $4=obpa^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#broaderTermPartitive">gndo:broaderTermPartitive</a>
    /// </summary>
    let broaderTermPartitive = _prefixId.prefix "broaderTermPartitive"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 550 $0 $4=obmo^^xsd:string</para>
    ///   <para>rdfs:label : Oberbegriff mehrgliedrigrdfs:label : Broader term (with more than one element)</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#broaderTermWithMoreThanOneElement">gndo:broaderTermWithMoreThanOneElement</a>
    /// </summary>
    let broaderTermWithMoreThanOneElement = _prefixId.prefix "broaderTermWithMoreThanOneElement"

    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Oberbegriff allgemeinrdfs:label : Broader term (general)</para>
    ///   <para>rdfs:comment : Use gndo:broaderTermGeneral insteadrdfs:comment : Bitte verwenden Sie gndo:broaderTermGeneral</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#broderTermGeneral">gndo:broderTermGeneral</a>
    /// </summary>
    let broderTermGeneral = _prefixId.prefix "broderTermGeneral"
    /// <summary>
    ///   <para>rdfs:label : Bauherrrdfs:label : Building owner</para>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=bauh^^xsd:string</para>
    ///   <para>rdfs:comment : Person, Familie oder Körperschaft, die einen Bau errichten lässt und finanziert.rdfs:comment : A person, family, or corporate body in charge of financing and constructing a building</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#buildingOwner">gndo:buildingOwner</a>
    /// </summary>
    let buildingOwner = _prefixId.prefix "buildingOwner"
    /// <summary>
    ///   <para>rdfs:label : Kartografrdfs:label : Cartographer</para>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=kart^^xsd:stringgndo:marc21equivalent : 510 $0 $4=kart^^xsd:string</para>
    ///   <para>rdfs:comment : A person, family, or organization responsible for creating a map, atlas, globe, or other cartographic work</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#cartographer">gndo:cartographer</a>
    /// </summary>
    let cartographer = _prefixId.prefix "cartographer"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 510 $0 $4=feie^^xsd:string</para>
    ///   <para>rdfs:label : Gefeierte Körperschaftrdfs:label : Celebrated corporate body</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#celebratedCorporateBody">gndo:celebratedCorporateBody</a>
    /// </summary>
    let celebratedCorporateBody = _prefixId.prefix "celebratedCorporateBody"
    /// <summary>
    ///   <para>rdfs:label : Gefeierte Familierdfs:label : Celebrated family</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#celebratedFamily">gndo:celebratedFamily</a>
    /// </summary>
    let celebratedFamily = _prefixId.prefix "celebratedFamily"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=feie^^xsd:string</para>
    ///   <para>rdfs:label : Gefeierte Personrdfs:label : Celebrated person</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#celebratedPerson">gndo:celebratedPerson</a>
    /// </summary>
    let celebratedPerson = _prefixId.prefix "celebratedPerson"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 550 $0 $4=feie^^xsd:string</para>
    ///   <para>rdfs:label : Gefeiertes Themardfs:label : Celebrated topic</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#celebratedTopic">gndo:celebratedTopic</a>
    /// </summary>
    let celebratedTopic = _prefixId.prefix "celebratedTopic"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 551 $0 $4=ortc^^xsd:string</para>
    ///   <para>rdfs:comment : Ort, der mit einer Familie in Verbindung
    /// 	steht.rdfs:comment : A significant place for a person or family</para>
    ///   <para>rdfs:label : Characteristic placerdfs:label : Charakteristischer Ort</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#characteristicPlace">gndo:characteristicPlace</a>
    /// </summary>
    let characteristicPlace = _prefixId.prefix "characteristicPlace"
    /// <summary>
    ///   <para>rdfs:label : Choreografrdfs:label : Choreographer</para>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=chre^^xsd:stringgndo:marc21equivalent : 510 $0 $4=chre^^xsd:string</para>
    ///   <para>rdfs:comment : A person responsible for creating or contributing to a work of movement</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#choreographer">gndo:choreographer</a>
    /// </summary>
    let choreographer = _prefixId.prefix "choreographer"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=kuez^^xsd:stringgndo:marc21equivalent : 510 $0 $4=kuez^^xsd:string</para>
    ///   <para>rdfs:comment : A person or organization whose work is largely quoted or extracted in works to which he or she did not contribute directly. Such quotations are found particularly in exhibition catalogs, collections of photographs, etc.</para>
    ///   <para>rdfs:label : Cited artistrdfs:label : Zitierter Künstler</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#citedArtist">gndo:citedArtist</a>
    /// </summary>
    let citedArtist = _prefixId.prefix "citedArtist"
    /// <summary>
    ///   <para>rdfs:label : Zitierter Verfasserrdfs:label : Cited author</para>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=autz^^xsd:stringgndo:marc21equivalent : 510 $0 $4=autz^^xsd:string</para>
    ///   <para>rdfs:comment : A person or organization whose work is largely quoted or extracted in works to which he or she did not contribute directly. Such quotations are found particularly in exhibition catalogs, collections of photographs, etc.</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#citedAuthor">gndo:citedAuthor</a>
    /// </summary>
    let citedAuthor = _prefixId.prefix "citedAuthor"
    /// <summary>
    ///   <para>rdfs:label : Zitierter Komponistrdfs:label : Cited composer</para>
    ///   <para>rdfs:comment : A person or organization whose work is largely quoted or extracted in works to which he or she did not contribute directly. Such quotations are found particularly in exhibition catalogs, collections of photographs, etc.</para>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=komz^^xsd:stringgndo:marc21equivalent : 510 $0 $4=komz^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#citedComposer">gndo:citedComposer</a>
    /// </summary>
    let citedComposer = _prefixId.prefix "citedComposer"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=saml^^xsd:stringgndo:marc21equivalent : 510 $0 $4=saml^^xsd:string</para>
    ///   <para>rdfs:label : Sammlerrdfs:label : Collector</para>
    ///   <para>rdfs:comment : A curator who brings together items from various sources that are then arranged, described, and cataloged as a collection. A collector is neither the creator of the material nor a person to whom manuscripts in the collection may have been addressed</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#collector">gndo:collector</a>
    /// </summary>
    let collector = _prefixId.prefix "collector"
    /// <summary>
    ///   <para>rdfs:comment : A person, family, or organization responsible for creating a new work (e.g., a bibliography, a directory) through the act of compilation, e.g., selecting, arranging, aggregating, and editing data, information, etc</para>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=comp^^xsd:string</para>
    ///   <para>rdfs:label : Kompilatorrdfs:label : Compiler</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#compiler">gndo:compiler</a>
    /// </summary>
    let compiler = _prefixId.prefix "compiler"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 260 $0^^xsd:string</para>
    ///   <para>rdfs:label : Relationierter Deskriptorrdfs:label : Complex see reference - subject</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#complexSeeReferenceSubject">gndo:complexSeeReferenceSubject</a>
    /// </summary>
    let complexSeeReferenceSubject = _prefixId.prefix "complexSeeReferenceSubject"
    /// <summary>
    ///   <para>rdfs:comment : A person, family, or organization responsible for creating or contributing to a musical resource by adding music to a work that originally lacked it or supplements it</para>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=koma^^xsd:stringgndo:marc21equivalent : 510 $0 $4=koma^^xsd:string</para>
    ///   <para>rdfs:label : Composerrdfs:label : Komponist</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#composer">gndo:composer</a>
    /// </summary>
    let composer = _prefixId.prefix "composer"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=leih^^xsd:stringgndo:marc21equivalent : 510 $0 $4=leih^^xsd:string</para>
    ///   <para>rdfs:label : Leihgeberrdfs:label : Conferrer</para>
    ///   <para>rdfs:comment : A person or organization permitting the temporary use of a book, manuscript, etc., such as for photocopying or microfilming</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#conferrer">gndo:conferrer</a>
    /// </summary>
    let conferrer = _prefixId.prefix "conferrer"
    /// <summary>
    ///   <para>rdfs:label : Contributing familyrdfs:label : Beteiligte Familie</para>
    ///   <para>rdfs:comment : Use contributingFamily instead.rdfs:comment : Bitte verwenden sie contributingFamily.</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#contributinFamily">gndo:contributinFamily</a>
    /// </summary>
    let contributinFamily = _prefixId.prefix "contributinFamily"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 510 $0 $4=bete^^xsd:string</para>
    ///   <para>rdfs:label : Beteiligte Körperschaftrdfs:label : Contributing corporate body</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#contributingCorporateBody">gndo:contributingCorporateBody</a>
    /// </summary>
    let contributingCorporateBody = _prefixId.prefix "contributingCorporateBody"
    /// <summary>
    ///   <para>rdfs:label : Beteiligte Familierdfs:label : Contributing family</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#contributingFamily">gndo:contributingFamily</a>
    /// </summary>
    let contributingFamily = _prefixId.prefix "contributingFamily"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=bete^^xsd:string</para>
    ///   <para>rdfs:label : Beteiligte Personrdfs:label : Contributing person</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#contributingPerson">gndo:contributingPerson</a>
    /// </summary>
    let contributingPerson = _prefixId.prefix "contributingPerson"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 551 $0 $4=bete^^xsd:string</para>
    ///   <para>rdfs:label : Beteiligtes Geografikumrdfs:label : Contributing place or geographic name</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#contributingPlaceOrGeographicName">gndo:contributingPlaceOrGeographicName</a>
    /// </summary>
    let contributingPlaceOrGeographicName = _prefixId.prefix "contributingPlaceOrGeographicName"

    /// <summary>
    ///   <para>rdfs:label : Koordinatenrdfs:label : Coordinates</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#coordinates">gndo:coordinates</a>
    /// </summary>
    let coordinates = _prefixId.prefix "coordinates"
    /// <summary>
    ///   <para>rdfs:comment : Eine Person oder Familie, die als Kopist oder Schreiber gearbeitet habenrdfs:comment : A person or family who is known as scribe or copyist.</para>
    ///   <para>rdfs:label : Kopistrdfs:label : Copist</para>
    ///   <para>gndo:marc21equivalent : 510 $0 $4=kopi^^xsd:stringgndo:marc21equivalent : 500 $0 $4=kopi^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#copist">gndo:copist</a>
    /// </summary>
    let copist = _prefixId.prefix "copist"
    /// <summary>
    ///   <para>rdfs:label : Körperschaft ist Mitgliedrdfs:label : Corporate body is member</para>
    ///   <para>gndo:marc21equivalent : 551 $0 $4=mitg^^xsd:stringgndo:marc21equivalent : 510 $0 $4=mitg^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#corporateBodyIsMember">gndo:corporateBodyIsMember</a>
    /// </summary>
    let corporateBodyIsMember = _prefixId.prefix "corporateBodyIsMember"
    /// <summary>
    ///   <para>rdfs:comment : Person, die zu der im Datensatz beschriebenen
    /// 	Person oder Körperschaft als Korrespondenzpartner in Beziehung steht.rdfs:comment : A person or organization who was either the writer or recipient of a letter or other communication</para>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=korr^^xsd:stringgndo:marc21equivalent : 510 $0 $4=korr^^xsd:string</para>
    ///   <para>rdfs:label : Correspondentrdfs:label : Korrespondenzpartner</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#correspondent">gndo:correspondent</a>
    /// </summary>
    let correspondent = _prefixId.prefix "correspondent"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 100 $b^^xsd:stringgndo:marc21equivalent : 400 $b^^xsd:string</para>
    ///   <para>rdfs:label : Zählungrdfs:label : Counting</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#counting">gndo:counting</a>
    /// </summary>
    let counting = _prefixId.prefix "counting"
    /// <summary>
    ///   <para>rdfs:label : Creatorrdfs:label : Urheber</para>
    ///   <para>rdfs:comment : A person or organization performing the work, i.e., the name of a person or organization associated with the intellectual content of the work. This category does not include the publisher or personal affiliation, or sponsor except where it is also the corporate author</para>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=urhe^^xsd:stringgndo:marc21equivalent : 510 $0 $4=urhe^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#creator">gndo:creator</a>
    /// </summary>
    let creator = _prefixId.prefix "creator"
    /// <summary>
    ///   <para>rdfs:comment : A person, family, or organization conceiving, aggregating, and/or organizing an exhibition, collection, or other item</para>
    ///   <para>gndo:marc21equivalent : 510 $0 $4=kura^^xsd:stringgndo:marc21equivalent : 500 $0 $4=kura^^xsd:string</para>
    ///   <para>rdfs:label : Kuratorrdfs:label : Curator</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#curator">gndo:curator</a>
    /// </summary>
    let curator = _prefixId.prefix "curator"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 548 $a $4=datx^^xsd:stringgndo:marc21equivalent : 548 $a $4=datl^^xsd:string</para>
    ///   <para>rdfs:label : Geburtsdatumrdfs:label : Date of birth</para>
    ///   <para>rdfs:comment : Geburts- und Sterbejahr einer Person oder die Jahre, in denen eine Familie nachweisbar istrdfs:comment : Date of birth and death of a person, years in which a family has been known to exist</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#dateOfBirth">gndo:dateOfBirth</a>
    /// </summary>
    let dateOfBirth = _prefixId.prefix "dateOfBirth"
    /// <summary>
    ///   <para>rdfs:label : Geburts- und Sterbedatumrdfs:label : Date of birth and death</para>
    ///   <para>gndo:marc21equivalent : 548 $a $4=datx^^xsd:stringgndo:marc21equivalent : 548 $a $4=datl^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#dateOfBirthAndDeath">gndo:dateOfBirthAndDeath</a>
    /// </summary>
    let dateOfBirthAndDeath = _prefixId.prefix "dateOfBirthAndDeath"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 548 $a $4=datv^^xsd:string</para>
    ///   <para>rdfs:label : Date of conference or eventrdfs:label : Veranstalungsdaten</para>
    ///   <para>rdfs:comment : Date of a conferencerdfs:comment : Datum einer Konferenz</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#dateOfConferenceOrEvent">gndo:dateOfConferenceOrEvent</a>
    /// </summary>
    let dateOfConferenceOrEvent = _prefixId.prefix "dateOfConferenceOrEvent"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 548 $a $4=datl^^xsd:stringgndo:marc21equivalent : 548 $a $4=datx^^xsd:string</para>
    ///   <para>rdfs:label : Date of deathrdfs:label : Sterbedatum</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#dateOfDeath">gndo:dateOfDeath</a>
    /// </summary>
    let dateOfDeath = _prefixId.prefix "dateOfDeath"
    /// <summary>
    ///   <para>rdfs:comment : Datum oder Jahr, in dem ein Objekt gefunden wurde
    /// (darf nicht bei Personen, Familien und Körperschaften verwendet werden)
    /// rdfs:comment : Date or year in which an object was found (not to be used in connection with persons, families and corporate bodies)</para>
    ///   <para>rdfs:label : Date of discoveryrdfs:label : Fundjahr</para>
    ///   <para>gndo:marc21equivalent : 548 $a $4=datf^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#dateOfDiscovery">gndo:dateOfDiscovery</a>
    /// </summary>
    let dateOfDiscovery = _prefixId.prefix "dateOfDiscovery"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 548 $a $4=datb^^xsd:string</para>
    ///   <para>rdfs:label : Date of establishmentrdfs:label : Gründungsdatum</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#dateOfEstablishment">gndo:dateOfEstablishment</a>
    /// </summary>
    let dateOfEstablishment = _prefixId.prefix "dateOfEstablishment"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 548 $a $4=datb^^xsd:string</para>
    ///   <para>rdfs:label : Gründungs- und Auflösungsdatumrdfs:label : Date of establishment and termination</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#dateOfEstablishmentAndTermination">gndo:dateOfEstablishmentAndTermination</a>
    /// </summary>
    let dateOfEstablishmentAndTermination = _prefixId.prefix "dateOfEstablishmentAndTermination"

    /// <summary>
    ///   <para>rdfs:comment : Zeitpunkt (Jahr), in dem ein Schriftdenkmal erstellt oder ein Bauwerk errichtet wurde / Entstehungszeitrdfs:comment : Date (year) in which a written historical document was created or a building constructed</para>
    ///   <para>rdfs:label : Date of productionrdfs:label : Erstellungszeit</para>
    ///   <para>gndo:marc21equivalent : 548 $a $4=dats^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#dateOfProduction">gndo:dateOfProduction</a>
    /// </summary>
    let dateOfProduction = _prefixId.prefix "dateOfProduction"
    /// <summary>
    ///   <para>rdfs:comment : Zeitpunkt, zu der die erste Expression eines Werkes veröffentlicht wurderdfs:comment : Date of publication of the first expression of a work</para>
    ///   <para>rdfs:label : Date of publicationrdfs:label : Erscheinungszeit</para>
    ///   <para>gndo:marc21equivalent : 548 $a $4=datj^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#dateOfPublication">gndo:dateOfPublication</a>
    /// </summary>
    let dateOfPublication = _prefixId.prefix "dateOfPublication"
    /// <summary>
    ///   <para>rdfs:label : Auflösungsdatumrdfs:label : Date of termination</para>
    ///   <para>gndo:marc21equivalent : 548 $a $4=datb^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#dateOfTermination">gndo:dateOfTermination</a>
    /// </summary>
    let dateOfTermination = _prefixId.prefix "dateOfTermination"
    /// <summary>
    ///   <para>rdfs:label : Widmungsempfängerrdfs:label : Dedicatee</para>
    ///   <para>rdfs:comment : A person, family, or organization to whom a resource is dedicated</para>
    ///   <para>gndo:marc21equivalent : 510 $0 $4=widm^^xsd:stringgndo:marc21equivalent : 500 $0 $4=widm^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#dedicatee">gndo:dedicatee</a>
    /// </summary>
    let dedicatee = _prefixId.prefix "dedicatee"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 679 $a^^xsd:string</para>
    ///   <para>rdfs:label : Definitionrdfs:label : Definition</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#definition">gndo:definition</a>
    /// </summary>
    let definition = _prefixId.prefix "definition"
    /// <summary>
    ///   <para>rdfs:label : Designerrdfs:label : Designer</para>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=desi^^xsd:stringgndo:marc21equivalent : 510 $0 $4=desi^^xsd:string</para>
    ///   <para>rdfs:comment : A person, family, or organization responsible for creating a design for an object</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#designer">gndo:designer</a>
    /// </summary>
    let designer = _prefixId.prefix "designer"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=regi^^xsd:stringgndo:marc21equivalent : 510 $0 $4=regi^^xsd:string</para>
    ///   <para>rdfs:label : Regisseurrdfs:label : Director</para>
    ///   <para>rdfs:comment : A person responsible for the general management and supervision of a filmed performance, a radio or television program, etc.</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#director">gndo:director</a>
    /// </summary>
    let director = _prefixId.prefix "director"
    /// <summary>
    ///   <para>rdfs:comment : A person in charge of photographing a motion picture, who plans the technical aspets of lighting and photographing of scenes, and often assists the director in the choice of angles, camera setups, and lighting moods. He or she may also supervise the further processing of filmed material up to the completion of the work print. Cinematographer is also referred to as director of photography. Do not confuse with videographer</para>
    ///   <para>gndo:marc21equivalent : 510 $0 $4=kame^^xsd:stringgndo:marc21equivalent : 500 $0 $4=kame^^xsd:string</para>
    ///   <para>rdfs:label : Director of photographyrdfs:label : Verantwortlicher Kameramann</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#directorOfPhotography">gndo:directorOfPhotography</a>
    /// </summary>
    let directorOfPhotography = _prefixId.prefix "directorOfPhotography"
    let dnbStaff = _prefixId.prefix "dnbStaff"
    /// <summary>
    ///   <para>rdfs:label : Angezweifelter Künstlerrdfs:label : Doubtful artist</para>
    ///   <para>gndo:marc21equivalent : 510 $0 $4=kuew^^xsd:stringgndo:marc21equivalent : 500 $0 $4=kuew^^xsd:string</para>
    ///   <para>rdfs:comment : A person or organization to which authorship has been dubiously or incorrectly ascribed</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#doubtfulArtist">gndo:doubtfulArtist</a>
    /// </summary>
    let doubtfulArtist = _prefixId.prefix "doubtfulArtist"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 510 $0 $4=autw^^xsd:stringgndo:marc21equivalent : 500 $0 $4=autw^^xsd:string</para>
    ///   <para>rdfs:comment : A person or organization to which authorship has been dubiously or incorrectly ascribed</para>
    ///   <para>rdfs:label : Doubtful authorrdfs:label : Angezweifelter Verfasser</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#doubtfulAuthor">gndo:doubtfulAuthor</a>
    /// </summary>
    let doubtfulAuthor = _prefixId.prefix "doubtfulAuthor"
    /// <summary>
    ///   <para>rdfs:label : Angezweifelter Komponistrdfs:label : Doubtful composer</para>
    ///   <para>gndo:marc21equivalent : 510 $0 $4=komw^^xsd:stringgndo:marc21equivalent : 500 $0 $4=komw^^xsd:string</para>
    ///   <para>rdfs:comment : A person or organization to which authorship has been dubiously or incorrectly ascribed</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#doubtfulComposer">gndo:doubtfulComposer</a>
    /// </summary>
    let doubtfulComposer = _prefixId.prefix "doubtfulComposer"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 034 $e^^xsd:string</para>
    ///   <para>rdfs:label : Östlichster Längengradrdfs:label : Easternmost longitude</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#easternmostLongitude">gndo:easternmostLongitude</a>
    /// </summary>
    let easternmostLongitude = _prefixId.prefix "easternmostLongitude"
    /// <summary>
    ///   <para>rdfs:label : Herausgeberrdfs:label : Editor</para>
    ///   <para>gndo:marc21equivalent : 510 $0 $4=hrsg^^xsd:stringgndo:marc21equivalent : 500 $0 $4=hrsg^^xsd:string</para>
    ///   <para>rdfs:comment : A person, family, or organization contributing to a resource by revising or elucidating the content, e.g., adding an introduction, notes, or other critical matter. An editor may also prepare a resource for production, publication, or distribution. For major revisions, adaptations, etc., that substantially change the nature and content of the original work, resulting in a new work, see author</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#editor">gndo:editor</a>
    /// </summary>
    let editor = _prefixId.prefix "editor"
    /// <summary>
    ///   <para>rdfs:label : Ende einer Perioderdfs:label : End of a period</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#endOfPeriod">gndo:endOfPeriod</a>
    /// </summary>
    let endOfPeriod = _prefixId.prefix "endOfPeriod"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=grav^^xsd:stringgndo:marc21equivalent : 510 $0 $4=grav^^xsd:string</para>
    ///   <para>rdfs:comment : A person or organization who cuts letters, figures, etc. on a surface, such as a wooden or metal plate used for printing</para>
    ///   <para>rdfs:label : Engraverrdfs:label : Graveur</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#engraver">gndo:engraver</a>
    /// </summary>
    let engraver = _prefixId.prefix "engraver"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 400 $c^^xsd:stringgndo:marc21equivalent : 100 $c^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Epithet, generic name, title or territoryrdfs:label : Beiname, Gattungsname, Titulatur, Territorium</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#epithetGenericNameTitleOrTerritory">gndo:epithetGenericNameTitleOrTerritory</a>
    /// </summary>
    let epithetGenericNameTitleOrTerritory = _prefixId.prefix "epithetGenericNameTitleOrTerritory"

    /// <summary>
    ///   <para>rdfs:label : Etcherrdfs:label : Radierer</para>
    ///   <para>rdfs:comment : A person or organization who produces text or images for printing by subjecting metal, glass, or some other surface to acid or the corrosive action of some other substance</para>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=radi^^xsd:stringgndo:marc21equivalent : 510 $0 $4=radi^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#etcher">gndo:etcher</a>
    /// </summary>
    let etcher = _prefixId.prefix "etcher"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=aust^^xsd:stringgndo:marc21equivalent : 510 $0 $4=aust^^xsd:string</para>
    ///   <para>rdfs:comment : Eine Person, Familie oder Körperschaft, die für eine Ausstellung verantwortlich ist.rdfs:comment : A person, family, or corporate body in charge of an exhibition.</para>
    ///   <para>rdfs:label : Ausstellerrdfs:label : Exhibitor</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#exhibitor">gndo:exhibitor</a>
    /// </summary>
    let exhibitor = _prefixId.prefix "exhibitor"
    /// <summary>
    ///   <para>rdfs:comment : Person, die zu der beschriebenen Person in
    /// 	familiärer bzw. verwandtschaftlicher Beziehung steht. Für Beziehungen von
    /// 	oder zu Familien wird gndo:memberOfTheFamily verwendet.rdfs:comment : A family relationship between a person or family and another person or family</para>
    ///   <para>rdfs:label : Familial relationshiprdfs:label : Familiäre Beziehung</para>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=bezf^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#familialRelationship">gndo:familialRelationship</a>
    /// </summary>
    let familialRelationship = _prefixId.prefix "familialRelationship"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 510 $0 $4=autf^^xsd:stringgndo:marc21equivalent : 500 $0 $4=autf^^xsd:string</para>
    ///   <para>rdfs:comment : Eine fiktive Person, Familie oder Körperschaft, die als Autor gilt.rdfs:comment : A fictitious person, family, or corporate body ascertained to be the author</para>
    ///   <para>rdfs:label : Fiktiver Verfasserrdfs:label : Fictitious author</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#fictitiousAuthor">gndo:fictitiousAuthor</a>
    /// </summary>
    let fictitiousAuthor = _prefixId.prefix "fictitiousAuthor"
    /// <summary>
    ///   <para>rdfs:label : Field of activityrdfs:label : Tätigkeitsbereich</para>
    ///   <para>gndo:marc21equivalent : 550 $0 $4=akti^^xsd:string</para>
    ///   <para>rdfs:comment : Field of activity of a person, corporate body, conference or event.rdfs:comment : Beschäftigungsfeld/Wissensgebiet mit dem sich eine Person, Körperschaft, Konferenz oder Veranstaltung beschäftigt oder beschäftigt hat.</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#fieldOfActivity">gndo:fieldOfActivity</a>
    /// </summary>
    let fieldOfActivity = _prefixId.prefix "fieldOfActivity"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 550 $0 $4=stud^^xsd:string</para>
    ///   <para>rdfs:comment : A person’s field of studyrdfs:comment : Studienfach einer Person.</para>
    ///   <para>rdfs:label : Studienfachrdfs:label : Field of study</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#fieldOfStudy">gndo:fieldOfStudy</a>
    /// </summary>
    let fieldOfStudy = _prefixId.prefix "fieldOfStudy"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=kue1^^xsd:stringgndo:marc21equivalent : 510 $0 $4=kue1^^xsd:string</para>
    ///   <para>rdfs:comment : A person or organization that takes primary responsibility for a particular activity or endeavor. May be combined with another relator term or code to show the greater importance this person or organization has regarding that particular role. If more than one relator is assigned to a heading, use the Lead relator only if it applies to all the relatorsrdfs:comment : Eine Person, Familie oder Körperschaft, die als einziger oder erster Künstler bekannt ist</para>
    ///   <para>rdfs:label : Erster Künstlerrdfs:label : First artist</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#firstArtist">gndo:firstArtist</a>
    /// </summary>
    let firstArtist = _prefixId.prefix "firstArtist"
    /// <summary>
    ///   <para>rdfs:label : Eine Person, Familie oder Körperschaft, die als der einzige
    /// 		oder der erste Autor einer Publikation bekannt ist.rdfs:label : First authorrdfs:label : Erste Verfasserschaftrdfs:label : A person or organization that takes primary responsibility for a
    /// 		particular activity or endeavor. May be combined with another relator term or code to
    /// 		show the greater importance this person or organization has regarding that particular role.
    /// 		If more than one relator is assigned to a heading, use the Lead relator only if it applies
    /// 		to all the relators.</para>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=aut1^^xsd:stringgndo:marc21equivalent : 510 $0 $4=aut1^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#firstAuthor">gndo:firstAuthor</a>
    /// </summary>
    let firstAuthor = _prefixId.prefix "firstAuthor"
    /// <summary>
    ///   <para>rdfs:comment : A person or organization that takes primary responsibility for a particular activity or endeavor. May be combined with another relator term or code to show the greater importance this person or organization has regarding that particular role. If more than one relator is assigned to a heading, use the Lead relator only if it applies to all the relatorsrdfs:comment : Eine Person, Familie oder Körperschaft, die als einziger oder erster Komponist bekannt ist</para>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=kom1^^xsd:stringgndo:marc21equivalent : 510 $0 $4=kom1^^xsd:string</para>
    ///   <para>rdfs:label : First composerrdfs:label : Erster Komponist</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#firstComposer">gndo:firstComposer</a>
    /// </summary>
    let firstComposer = _prefixId.prefix "firstComposer"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 400 $a^^xsd:stringgndo:marc21equivalent : 100 $a^^xsd:string</para>
    ///   <para>rdfs:label : Forenamerdfs:label : Vorname</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#forename">gndo:forename</a>
    /// </summary>
    let forename = _prefixId.prefix "forename"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 380 $0 $2=gnd^^xsd:string</para>
    ///   <para>rdfs:label : Form des Werks und der Expressionrdfs:label : Form of work and expression</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#formOfWorkAndExpression">gndo:formOfWorkAndExpression</a>
    /// </summary>
    let formOfWorkAndExpression = _prefixId.prefix "formOfWorkAndExpression"
    /// <summary>
    ///   <para>rdfs:label : Former ownerrdfs:label : Früherer Besitzer</para>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=befr^^xsd:stringgndo:marc21equivalent : 510 $0 $4=befr^^xsd:string</para>
    ///   <para>rdfs:comment : A person, family, or organization formerly having legal possession of an itemrdfs:comment : Eine Person, eine Familie oder eine Körperschaft, die früher rechtmäßiger Besitzer einer Ressource war.</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#formerOwner">gndo:formerOwner</a>
    /// </summary>
    let formerOwner = _prefixId.prefix "formerOwner"
    /// <summary>
    ///   <para>rdfs:label : Gründerrdfs:label : Founder</para>
    ///   <para>rdfs:comment : A person, family, or corporate body being a founder of an enterprise, an event, or an ensemble of buildingsrdfs:comment : Eine Person, Familie oder Körperschaft, die ein Unternehmen oder Veranstaltung oder Bauensemble gründet</para>
    ///   <para>gndo:marc21equivalent : 510 $0 $4=grue^^xsd:stringgndo:marc21equivalent : 500 $0 $4=grue^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#founder">gndo:founder</a>
    /// </summary>
    let founder = _prefixId.prefix "founder"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 550 $0 $4=funk^^xsd:string</para>
    ///   <para>rdfs:label : Function or rolerdfs:label : Funktion oder Rolle</para>
    ///   <para>rdfs:comment : Diese Property ist äquivalent zu gndo:functionOrRoleAsLiteral, zeigt aber auf ein Schlagwort statt ein Literal auszugeben.rdfs:comment : This property is equivalent to gndo:functionOrRoleAsLiteral but points to a subject heading instead of giving a literal value.</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#functionOrRole">gndo:functionOrRole</a>
    /// </summary>
    let functionOrRole = _prefixId.prefix "functionOrRole"
    /// <summary>
    ///   <para>rdfs:label : Function or role (Literal)rdfs:label : Funktion oder Rolle (Literal)</para>
    ///   <para>rdfs:comment : Diese Property ist äquivalent zu gndo:functionOrRole, zeigt aber ein Literal statt eines URIsrdfs:comment : This property is equivalent to gndo:functionOrRole but gives a literal instead of a URI</para>
    ///   <para>gndo:marc21equivalent : 550 $a $g $4=funk^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#functionOrRoleAsLiteral">gndo:functionOrRoleAsLiteral</a>
    /// </summary>
    let functionOrRoleAsLiteral = _prefixId.prefix "functionOrRoleAsLiteral"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 375 $a^^xsd:string</para>
    ///   <para>rdfs:label : Geschlechtrdfs:label : Gender</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#gender">gndo:gender</a>
    /// </summary>
    let gender = _prefixId.prefix "gender"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 043 $c^^xsd:string</para>
    ///   <para>rdfs:label : Ländercoderdfs:label : Geographic Area Code</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#geographicAreaCode">gndo:geographicAreaCode</a>
    /// </summary>
    let geographicAreaCode = _prefixId.prefix "geographicAreaCode"
    /// <summary>
    ///   <para>rdfs:label : GND-Identifierrdfs:label : GND-Nummer</para>
    ///   <para>gndo:marc21equivalent : 035 $a=(DE-588)...^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#gndIdentifier">gndo:gndIdentifier</a>
    /// </summary>
    let gndIdentifier = _prefixId.prefix "gndIdentifier"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 065 $a $2=sswd^^xsd:string</para>
    ///   <para>rdfs:label : GND-Sachgrupperdfs:label : GND subject category</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#gndSubjectCategory">gndo:gndSubjectCategory</a>
    /// </summary>
    let gndSubjectCategory = _prefixId.prefix "gndSubjectCategory"
    /// <summary>
    ///   <para>rdfs:label : Administrative Überordnungrdfs:label : Hierarchical superior</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#hierarchicalSuperior">gndo:hierarchicalSuperior</a>
    /// </summary>
    let hierarchicalSuperior = _prefixId.prefix "hierarchicalSuperior"

    /// <summary>
    ///   <para>rdfs:label : Hierarchical superior of place or geographic namerdfs:label : Administrative Überordnung des Geografikums</para>
    ///   <para>rdfs:comment : Eine hierarchisch übergeordnete Einheit (Gebietskörperschaft, Körperschaft, Konferenz) der beschriebenen Einheit (Gebietskörperschaft, Körperschaft, Konferenz).rdfs:comment : A hierarchically superordinate unit (corporate body, conference, jurisdiction) of the described unit (corporate body, conference, jurisdiction).</para>
    ///   <para>gndo:marc21equivalent : 551 $0 $4=adue^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#hierarchicalSuperiorOfPlaceOrGeographicName">gndo:hierarchicalSuperiorOfPlaceOrGeographicName</a>
    /// </summary>
    let hierarchicalSuperiorOfPlaceOrGeographicName = _prefixId.prefix "hierarchicalSuperiorOfPlaceOrGeographicName"

    /// <summary>
    ///   <para>rdfs:label : Hierarchical superior of the conference or eventrdfs:label : Administrative Überordnung der Konferenz oder der
    ///       Veranstaltung</para>
    ///   <para>gndo:marc21equivalent : 511 $0 $4=adue^^xsd:stringgndo:marc21equivalent : 510 $0 $4=adue^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#hierarchicalSuperiorOfTheConferenceOrEvent">gndo:hierarchicalSuperiorOfTheConferenceOrEvent</a>
    /// </summary>
    let hierarchicalSuperiorOfTheConferenceOrEvent = _prefixId.prefix "hierarchicalSuperiorOfTheConferenceOrEvent"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 551 $0 $4=adue^^xsd:stringgndo:marc21equivalent : 511 $0 $4=adue^^xsd:stringgndo:marc21equivalent : 510 $0 $4=adue^^xsd:string</para>
    ///   <para>rdfs:label : Administrative Überordnung der Körperschaftrdfs:label : Hierarchical superior of the corporate body</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#hierarchicalSuperiorOfTheCorporateBody">gndo:hierarchicalSuperiorOfTheCorporateBody</a>
    /// </summary>
    let hierarchicalSuperiorOfTheCorporateBody = _prefixId.prefix "hierarchicalSuperiorOfTheCorporateBody"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 670 $u $a=Homepage^^xsd:string</para>
    ///   <para>rdfs:label : Homepagerdfs:label : Homepage</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#homepage">gndo:homepage</a>
    /// </summary>
    let homepage = _prefixId.prefix "homepage"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 510 $0 $4=illu^^xsd:stringgndo:marc21equivalent : 500 $0 $4=illu^^xsd:string</para>
    ///   <para>rdfs:label : Illustrator oder Illuminatorrdfs:label : Illustrator or illuminator</para>
    ///   <para>rdfs:comment : A person, family, or organization contributing to a resource by supplementing the primary content with drawings, diagrams, photographs, etc. If the work is primarily the artistic content created by this entity, use artist or photographer</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#illustratorOrIlluminator">gndo:illustratorOrIlluminator</a>
    /// </summary>
    let illustratorOrIlluminator = _prefixId.prefix "illustratorOrIlluminator"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 510 $0 $4=verr^^xsd:stringgndo:marc21equivalent : 500 $0 $4=verr^^xsd:string</para>
    ///   <para>rdfs:comment : Eine Person, Familie oder Körperschaft, die ein Werk veranlasst hatrdfs:comment : A person, family, or corporate body who initiated a work</para>
    ///   <para>rdfs:label : Veranlasserrdfs:label : Initiator</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#initiator">gndo:initiator</a>
    /// </summary>
    let initiator = _prefixId.prefix "initiator"
    /// <summary>
    ///   <para>rdfs:label : Instrumentrdfs:label : Instrument</para>
    ///   <para>rdfs:comment : Ein Musikinstrumentrdfs:comment : A musical instrument, a device to perform music with</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#instrument">gndo:instrument</a>
    /// </summary>
    let instrument = _prefixId.prefix "instrument"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=istm^^xsd:string</para>
    ///   <para>rdfs:label : Instrumentalmusikerrdfs:label : Instrumentalist</para>
    ///   <para>rdfs:comment : A performer contributing to a resource by playing a musical instrument</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#instrumentalist">gndo:instrumentalist</a>
    /// </summary>
    let instrumentalist = _prefixId.prefix "instrumentalist"
    /// <summary>
    ///   <para>rdfs:label : Inventorrdfs:label : Erfinder</para>
    ///   <para>gndo:marc21equivalent : 510 $0 $4=erfi^^xsd:stringgndo:marc21equivalent : 500 $0 $4=erfi^^xsd:string</para>
    ///   <para>rdfs:comment : A person, family, or organization responsible for creating a new device or process</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#inventor">gndo:inventor</a>
    /// </summary>
    let inventor = _prefixId.prefix "inventor"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 384 1# $a^^xsd:string</para>
    ///   <para>rdfs:label : Tonart der Fassungrdfs:label : Key of the version</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#keyOfTheVersion">gndo:keyOfTheVersion</a>
    /// </summary>
    let keyOfTheVersion = _prefixId.prefix "keyOfTheVersion"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 384 0# $a^^xsd:string</para>
    ///   <para>rdfs:label : Tonart des Werksrdfs:label : Key of the work</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#keyOfTheWork">gndo:keyOfTheWork</a>
    /// </summary>
    let keyOfTheWork = _prefixId.prefix "keyOfTheWork"
    /// <summary>
    ///   <para>rdfs:label : Spracherdfs:label : Language</para>
    ///   <para>rdfs:comment : Sprache, in der ein Werk verfasst wurde oder die eine Person, Familie oder Körperschaft benutzt.rdfs:comment : A language used by a person or family or in which a work was written</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#language">gndo:language</a>
    /// </summary>
    let language = _prefixId.prefix "language"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 377 $a $2=iso639-2b^^xsd:string</para>
    ///   <para>rdfs:label : Sprachencoderdfs:label : Language code</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#languageCode">gndo:languageCode</a>
    /// </summary>
    let languageCode = _prefixId.prefix "languageCode"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=libr^^xsd:stringgndo:marc21equivalent : 510 $0 $4=libr^^xsd:string</para>
    ///   <para>rdfs:comment : An author of a libretto of an opera or other stage work, or an oratorio</para>
    ///   <para>rdfs:label : Librettistrdfs:label : Librettist</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#librettist">gndo:librettist</a>
    /// </summary>
    let librettist = _prefixId.prefix "librettist"
    let listMembers = _prefixId.prefix "listMembers"
    /// <summary>
    ///   <para>rdfs:label : Vorlagerdfs:label : Literary source</para>
    ///   <para>rdfs:comment : The described entity is a realization of the related workrdfs:comment : Die beschriebene Entität ist eine Realisierung des in Beziehung stehenden Werkes</para>
    ///   <para>gndo:marc21equivalent : 530 $0 $4=vorl^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#literarySource">gndo:literarySource</a>
    /// </summary>
    let literarySource = _prefixId.prefix "literarySource"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=lith^^xsd:stringgndo:marc21equivalent : 510 $0 $4=lith^^xsd:string</para>
    ///   <para>rdfs:label : Lithographerrdfs:label : Litograf</para>
    ///   <para>rdfs:comment : A person or organization who prepares the stone or plate for lithographic printing, including a graphic artist creating a design directly on the surface from which printing will be done.</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#lithographer">gndo:lithographer</a>
    /// </summary>
    let lithographer = _prefixId.prefix "lithographer"
    /// <summary>
    ///   <para>rdfs:label : Manufacturerrdfs:label : Hersteller</para>
    ///   <para>rdfs:comment : A person or organization responsible for printing, duplicating, casting, etc. a resource</para>
    ///   <para>gndo:marc21equivalent : 510 $0 $4=hers^^xsd:stringgndo:marc21equivalent : 500 $0 $4=hers^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#manufacturer">gndo:manufacturer</a>
    /// </summary>
    let manufacturer = _prefixId.prefix "manufacturer"
    /// <summary>
    ///   <para>rdfs:label : MARC 21 Entsprechungrdfs:label : MARC 21 equivalent</para>
    ///   <para>rdfs:comment : Gibt die MARC 21 Entsprechung des Elements im GND-MARC-Format
    ///       wieder.rdfs:comment : Expresses the MARC 21 equivalent for this element in the GND MARC
    ///       format.</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#marc21equivalent">gndo:marc21equivalent</a>
    /// </summary>
    let marc21equivalent = _prefixId.prefix "marc21equivalent"
    /// <summary>
    ///   <para>rdfs:label : Besetzung im Musikbereichrdfs:label : Medium of performance</para>
    ///   <para>gndo:marc21equivalent : 550 $0 $4=istr^^xsd:stringgndo:marc21equivalent : 382 $0^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#mediumOfPerformance">gndo:mediumOfPerformance</a>
    /// </summary>
    let mediumOfPerformance = _prefixId.prefix "mediumOfPerformance"
    /// <summary>
    ///   <para>rdfs:label : Mitgliedrdfs:label : Member</para>
    ///   <para>rdfs:comment : Eine Person oder Familie, die Mitglied einer (anderen) Familie istrdfs:comment : A person or family being a member of (another) family</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#member">gndo:member</a>
    /// </summary>
    let member_ = _prefixId.prefix "member"
    /// <summary>
    ///   <para>rdfs:label : Familienmitgliedrdfs:label : Member of the family</para>
    ///   <para>rdfs:comment : Die beschriebene Person (Subjekt) ist ein bedeutendes
    /// 	Mitglied der verknüpften Familie (Objekt). Für Göttergruppen und Gruppen
    /// 	mythologischer Gestalten wird gndo:broaderTermPartitive verwendet.</para>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=mitg^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#memberOfTheFamily">gndo:memberOfTheFamily</a>
    /// </summary>
    let memberOfTheFamily = _prefixId.prefix "memberOfTheFamily"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=musi^^xsd:string</para>
    ///   <para>rdfs:label : Musikerrdfs:label : Musician</para>
    ///   <para>rdfs:comment : A person or organization who performs music or contributes to the musical content of a work when it is not possible or desirable to identify the function more precisely</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#musician">gndo:musician</a>
    /// </summary>
    let musician = _prefixId.prefix "musician"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 100 $g^^xsd:stringgndo:marc21equivalent : 400 $g^^xsd:string</para>
    ///   <para>rdfs:label : Namensusatzrdfs:label : Name addition</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#nameAddition">gndo:nameAddition</a>
    /// </summary>
    let nameAddition = _prefixId.prefix "nameAddition"
    /// <summary>
    ///   <para>rdfs:comment : A performer contributing to a resource by reading or speaking in order to give an account of an act, occurrence, course of events, etc</para>
    ///   <para>rdfs:label : Sprecherrdfs:label : Narrator</para>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=spre^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#narrator">gndo:narrator</a>
    /// </summary>
    let narrator = _prefixId.prefix "narrator"
    /// <summary>
    ///   <para>rdfs:label : Unterbegriff allgemeinrdfs:label : Narrower term (general)</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#narrowerTermGeneral">gndo:narrowerTermGeneral</a>
    /// </summary>
    let narrowerTermGeneral = _prefixId.prefix "narrowerTermGeneral"
    /// <summary>
    ///   <para>rdfs:label : Narrower term (generic)rdfs:label : Unterbegriff generisch</para>
    ///   <para>rdfs:comment : Eine generische Relation ist eine hierarchische Relation zwischen
    ///       zwei Begriffen, von denen der untergeordnete Begriff alle Merkmale des übergeordneten Begriffs
    ///       besitzt und zusätzlich noch mindestens ein weiteres Merkmal.rdfs:comment : The generic relation is a semantic relation between two concepts
    ///       where the intension of one of the concepts includes that of the other concepts and at least
    ///       one additional delimiting characteristic is added.</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#narrowerTermGeneric">gndo:narrowerTermGeneric</a>
    /// </summary>
    let narrowerTermGeneric = _prefixId.prefix "narrowerTermGeneric"
    /// <summary>
    ///   <para>rdfs:label : Narrower term (instantial)rdfs:label : Unterbegriff instantiell</para>
    ///   <para>rdfs:comment : The instance relationship links a general concept such as a class of
    ///       things or events, and an individual instance oft hat class, which is often represented by a
    ///       proper name.rdfs:comment : Die Instanzbeziehung verbindet ein allgemeines Konzept, etwa eine
    ///       Klasse von Dingen oder Ereignissen mit einem individuellen Exemplar dieser Klasse, das oft
    ///       durch einen Eigennamen repräsentiert wird.</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#narrowerTermInstantial">gndo:narrowerTermInstantial</a>
    /// </summary>
    let narrowerTermInstantial = _prefixId.prefix "narrowerTermInstantial"
    /// <summary>
    ///   <para>rdfs:label : Narrower term (partitive)rdfs:label : Unterbegriff partitiv</para>
    ///   <para>rdfs:comment : Eine partitive Relation ist eine hierarchische
    /// 	Relation zwischen zwei Begriffen, von denen der übergeordnete Begriff
    /// 	(Verbandsbegriff) einem Ganzen entspricht und der untergeordnete Begriff
    /// 	einen der Bestandteile dieses Ganzen repräsentiert. Bei Personen ist die
    /// 	Relation die Beziehung zwischen einer einzelnen Person (besonders
    /// 	Gottheiten) und übergeordneten Gruppen von Göttern und mythologische Gestalten.rdfs:comment : The hierarchical whole-part relationship covers a limited range of
    ///       situations in which a part of an entity or system belongs uniquely to a particular possessing
    ///       whole. When applied to persons, this is the relation between a single person (particularly gods)
    /// 	  and hierarchically superior groups of gods and mythologic entities.</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#narrowerTermPartitive">gndo:narrowerTermPartitive</a>
    /// </summary>
    let narrowerTermPartitive = _prefixId.prefix "narrowerTermPartitive"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 034 $f^^xsd:string</para>
    ///   <para>rdfs:label : Nördlichster Breitengradrdfs:label : Northernmost latitude</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#northernmostLatitude">gndo:northernmostLatitude</a>
    /// </summary>
    let northernmostLatitude = _prefixId.prefix "northernmostLatitude"
    /// <summary>
    ///   <para>rdfs:label : Anlassrdfs:label : Occasion</para>
    ///   <para>rdfs:comment : Bewegrund für die vorliegende Entität als Datensatz
    /// 		(z.B. ein Werk oder historisches Einzelereignis als Anlass für eine Konferenz
    /// 		oder ein historisches Einzelereignis oder eine Konferenz als Anlass für ein Werk).rdfs:comment : Reason of the entity, e.g. a work or a historic event
    /// 		is the reason of a conference, or a conference is the reason of a work.</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#occasion">gndo:occasion</a>
    /// </summary>
    let occasion = _prefixId.prefix "occasion"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 550 $0 $4=anla^^xsd:string</para>
    ///   <para>rdfs:label : Anlass des Schlagwortsrdfs:label : Occasion of the subject heading</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#occasionOfTheSubjectHeading">gndo:occasionOfTheSubjectHeading</a>
    /// </summary>
    let occasionOfTheSubjectHeading = _prefixId.prefix "occasionOfTheSubjectHeading"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 530 $0 $4=anla^^xsd:string</para>
    ///   <para>rdfs:label : Anlass des Werkesrdfs:label : Occasion of the work</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#occasionOfTheWork">gndo:occasionOfTheWork</a>
    /// </summary>
    let occasionOfTheWork = _prefixId.prefix "occasionOfTheWork"
    /// <summary>
    ///   <para>rdfs:label : Old authority numberrdfs:label : Alte Normnummer</para>
    ///   <para>gndo:marc21equivalent : 035 $z^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#oldAuthorityNumber">gndo:oldAuthorityNumber</a>
    /// </summary>
    let oldAuthorityNumber = _prefixId.prefix "oldAuthorityNumber"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 383 $b^^xsd:string</para>
    ///   <para>rdfs:label : Opus-Zählung des Musikwerksrdfs:label : Opus numeric designation of musical work</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#opusNumericDesignationOfMusicalWork">gndo:opusNumericDesignationOfMusicalWork</a>
    /// </summary>
    let opusNumericDesignationOfMusicalWork = _prefixId.prefix "opusNumericDesignationOfMusicalWork"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=vera^^xsd:stringgndo:marc21equivalent : 510 $0 $4=vera^^xsd:string</para>
    ///   <para>rdfs:label : Organizer or hostrdfs:label : Veranstalter oder Gastgeber</para>
    ///   <para>rdfs:comment : A person, family, or organization organizing the exhibit, event, conference, etc., which gave rise to a resource</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#organizerOrHost">gndo:organizerOrHost</a>
    /// </summary>
    let organizerOrHost = _prefixId.prefix "organizerOrHost"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 551 $0 $4=ortm^^xsd:string</para>
    ///   <para>rdfs:label : Weiterer Ortrdfs:label : Other place</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#otherPlace">gndo:otherPlace</a>
    /// </summary>
    let otherPlace = _prefixId.prefix "otherPlace"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=besi^^xsd:stringgndo:marc21equivalent : 510 $0 $4=besi^^xsd:string</para>
    ///   <para>rdfs:comment : Eine Person, eine Familie oder eine Körperschaft, die im rechtmäßigen Besitz einer Ressource ist. rdfs:comment : A person, family, or organization that currently owns an item or collection, i.e. has legal possession of a resource</para>
    ///   <para>rdfs:label : Ownerrdfs:label : Besitzer</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#owner">gndo:owner</a>
    /// </summary>
    let owner = _prefixId.prefix "owner"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 510 $0 $4=malr^^xsd:stringgndo:marc21equivalent : 500 $0 $4=malr^^xsd:string</para>
    ///   <para>rdfs:label : Malerrdfs:label : Painter</para>
    ///   <para>rdfs:comment : A person or family who paintsrdfs:comment : Eine Person oder Familie, die malt</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#painter">gndo:painter</a>
    /// </summary>
    let painter = _prefixId.prefix "painter"
    /// <summary>
    ///   <para>rdfs:comment : Exaktes Wirkungsdatum einer Personrdfs:comment : A person’s known period of activity</para>
    ///   <para>rdfs:label : Period of activityrdfs:label : Wirkungsdaten</para>
    ///   <para>gndo:marc21equivalent : 548 $a $4=datw^^xsd:stringgndo:marc21equivalent : 548 $a $4=datz^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#periodOfActivity">gndo:periodOfActivity</a>
    /// </summary>
    let periodOfActivity = _prefixId.prefix "periodOfActivity"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 100 $a^^xsd:stringgndo:marc21equivalent : 400 $a^^xsd:string</para>
    ///   <para>rdfs:label : Persönlicher Namerdfs:label : Personal name</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#personalName">gndo:personalName</a>
    /// </summary>
    let personalName = _prefixId.prefix "personalName"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=foto^^xsd:stringgndo:marc21equivalent : 510 $0 $4=foto^^xsd:string</para>
    ///   <para>rdfs:comment : A person, family, or organization responsible for creating a photographic work</para>
    ///   <para>rdfs:label : Fotografrdfs:label : Photographer</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#photographer">gndo:photographer</a>
    /// </summary>
    let photographer = _prefixId.prefix "photographer"
    /// <summary>
    ///   <para>rdfs:comment : Ein Land, ein Staat, eine Provinz usw. oder ein Ort, an dem/der eine Organisation ihren Hauptsitz hat. rdfs:comment : A country, state, province, etc., or place where an organization has its headquarters</para>
    ///   <para>gndo:marc21equivalent : 551 $0 $4=orta^^xsd:string</para>
    ///   <para>rdfs:label : Placerdfs:label : Ort</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#place">gndo:place</a>
    /// </summary>
    let place = _prefixId.prefix "place"
    /// <summary>
    ///   <para>rdfs:comment : Wirkungsort bzw. Wohnort einer Person.rdfs:comment : A person’s or family’s place of activity</para>
    ///   <para>rdfs:label : Wirkungsortrdfs:label : Place of activity</para>
    ///   <para>gndo:marc21equivalent : 551 $0 $4=ortw^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#placeOfActivity">gndo:placeOfActivity</a>
    /// </summary>
    let placeOfActivity = _prefixId.prefix "placeOfActivity"
    /// <summary>
    ///   <para>rdfs:comment : Geburtsort einer Person.rdfs:comment : A person’s place of birth</para>
    ///   <para>rdfs:label : Place of Birthrdfs:label : Geburtsort</para>
    ///   <para>gndo:marc21equivalent : 551 $0 $4=ortg^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#placeOfBirth">gndo:placeOfBirth</a>
    /// </summary>
    let placeOfBirth = _prefixId.prefix "placeOfBirth"
    /// <summary>
    ///   <para>rdfs:label : Place of Birth (Literal)rdfs:label : Geburtsort (Literal)</para>
    ///   <para>rdfs:comment : This property is equivalent to gndo:placeOfBirth but gives a literal instead of
    /// 		a reference to a geographic entityrdfs:comment : Diese Property ist äquivalent zu gndo:placeOfBirth, zeigt aber ein Literal
    /// 		statt einer Referenz zu einer geografischen Entität</para>
    ///   <para>gndo:marc21equivalent : 551 $a $g $z $4=ortg^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#placeOfBirthAsLiteral">gndo:placeOfBirthAsLiteral</a>
    /// </summary>
    let placeOfBirthAsLiteral = _prefixId.prefix "placeOfBirthAsLiteral"
    /// <summary>
    ///   <para>rdfs:label : Sitzrdfs:label : Place of business</para>
    ///   <para>gndo:marc21equivalent : 551 $0 $4=orta^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#placeOfBusiness">gndo:placeOfBusiness</a>
    /// </summary>
    let placeOfBusiness = _prefixId.prefix "placeOfBusiness"
    /// <summary>
    ///   <para>rdfs:comment : A place where an event such as a conference or a concert took placerdfs:comment : Ort, an dem eine Veranstaltung oder eine Konferenz stattfindet</para>
    ///   <para>rdfs:label : Veranstaltungsortrdfs:label : Place of conference or event</para>
    ///   <para>gndo:marc21equivalent : 551 $0 $4=ortv^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#placeOfConferenceOrEvent">gndo:placeOfConferenceOrEvent</a>
    /// </summary>
    let placeOfConferenceOrEvent = _prefixId.prefix "placeOfConferenceOrEvent"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 551 $0 $4=ortb^^xsd:string</para>
    ///   <para>rdfs:label : Aufbewahrungsortrdfs:label : Place of custody</para>
    ///   <para>rdfs:comment : Der Aufbewahrungsort eines Werkesrdfs:comment : A place where something is kept</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#placeOfCustody">gndo:placeOfCustody</a>
    /// </summary>
    let placeOfCustody = _prefixId.prefix "placeOfCustody"
    /// <summary>
    ///   <para>rdfs:label : Place of deathrdfs:label : Sterbeort</para>
    ///   <para>rdfs:comment : A person’s place of deathrdfs:comment : Sterbeort einer Person.</para>
    ///   <para>gndo:marc21equivalent : 551 $0 $4=orts^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#placeOfDeath">gndo:placeOfDeath</a>
    /// </summary>
    let placeOfDeath = _prefixId.prefix "placeOfDeath"
    /// <summary>
    ///   <para>rdfs:comment : Diese Property ist äquivalent zu gndo:placeOfDeath, zeigt aber ein Literal
    /// 		statt einer Referenz zu einer geografischen Entitätrdfs:comment : This property is equivalent to gndo:placeOfDeath but gives a literal instead of
    /// 		a reference to a geographic entity</para>
    ///   <para>rdfs:label : Place of death (Literal)rdfs:label : Sterbeort (Literal)</para>
    ///   <para>gndo:marc21equivalent : 551 $a $g $z $4=orts^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#placeOfDeathAsLiteral">gndo:placeOfDeathAsLiteral</a>
    /// </summary>
    let placeOfDeathAsLiteral = _prefixId.prefix "placeOfDeathAsLiteral"
    /// <summary>
    ///   <para>rdfs:comment : Der Fundort eines Werksrdfs:comment : A place where a work or thing was found</para>
    ///   <para>rdfs:label : Place of discoveryrdfs:label : Fundort</para>
    ///   <para>gndo:marc21equivalent : 551 $0 $4=ortf^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#placeOfDiscovery">gndo:placeOfDiscovery</a>
    /// </summary>
    let placeOfDiscovery = _prefixId.prefix "placeOfDiscovery"
    /// <summary>
    ///   <para>rdfs:comment : A place where a person or family dwelt in exile (lived in exile)rdfs:comment : Ortschaft, Stadt, Provinz, Staat und/oder Land,
    /// 	in der/dem eine Person oder Familie im Exil lebt(e).</para>
    ///   <para>rdfs:label : Exilortrdfs:label : Place of Exile</para>
    ///   <para>gndo:marc21equivalent : 551 $0 $4=ortx^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#placeOfExile">gndo:placeOfExile</a>
    /// </summary>
    let placeOfExile = _prefixId.prefix "placeOfExile"
    /// <summary>
    ///   <para>rdfs:comment : A place where a work or thing was manufacturedrdfs:comment : Herstellungsort einer Sache oder eines Werks</para>
    ///   <para>gndo:marc21equivalent : 551 $0 $4=orth^^xsd:string</para>
    ///   <para>rdfs:label : Herstellungsortrdfs:label : Place of manufacture</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#placeOfManufacture">gndo:placeOfManufacture</a>
    /// </summary>
    let placeOfManufacture = _prefixId.prefix "placeOfManufacture"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 510 $0 $4=mitg^^xsd:string</para>
    ///   <para>rdfs:label : Geografikum ist Mitgliedrdfs:label : Place or geographic name is member</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#placeOrGeographicNameIsMember">gndo:placeOrGeographicNameIsMember</a>
    /// </summary>
    let placeOrGeographicNameIsMember = _prefixId.prefix "placeOrGeographicNameIsMember"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 550 $0 $4=istr^^xsd:string</para>
    ///   <para>rdfs:label : Gespieltes Instrumentrdfs:label : Played instrument</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#playedInstrument">gndo:playedInstrument</a>
    /// </summary>
    let playedInstrument = _prefixId.prefix "playedInstrument"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=dich^^xsd:stringgndo:marc21equivalent : 510 $0 $4=dich^^xsd:string</para>
    ///   <para>rdfs:label : Poetrdfs:label : Dichter</para>
    ///   <para>rdfs:comment : An author of the words of a non-dramatic musical work (e.g. the text of a song), except for oratorios</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#poet">gndo:poet</a>
    /// </summary>
    let poet = _prefixId.prefix "poet"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 511 $0 $4=vorg^^xsd:string</para>
    ///   <para>rdfs:label : Preceding conference or eventrdfs:label : Vorherige Konferenz oder Veranstaltung</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#precedingConferenceOrEvent">gndo:precedingConferenceOrEvent</a>
    /// </summary>
    let precedingConferenceOrEvent = _prefixId.prefix "precedingConferenceOrEvent"
    /// <summary>
    ///   <para>rdfs:label : Preceding corporate bodyrdfs:label : Vorherige Körperschaft</para>
    ///   <para>gndo:marc21equivalent : 510 $0 $4=vorg^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#precedingCorporateBody">gndo:precedingCorporateBody</a>
    /// </summary>
    let precedingCorporateBody = _prefixId.prefix "precedingCorporateBody"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 551 $0 $4=vorg^^xsd:string</para>
    ///   <para>rdfs:label : Vorheriges Geografikumrdfs:label : Preceding place or geographic name</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#precedingPlaceOrGeographicName">gndo:precedingPlaceOrGeographicName</a>
    /// </summary>
    let precedingPlaceOrGeographicName = _prefixId.prefix "precedingPlaceOrGeographicName"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 550 $0 $4=vorg^^xsd:string</para>
    ///   <para>rdfs:label : Vorheriges Schlagwortrdfs:label : Preceding subject heading</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#precedingSubject">gndo:precedingSubject</a>
    /// </summary>
    let precedingSubject = _prefixId.prefix "precedingSubject"
    /// <summary>
    ///   <para>rdfs:label : Vorheriges Werkrdfs:label : Preceding work</para>
    ///   <para>gndo:marc21equivalent : 530 $0 $4=vorg^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#precedingWork">gndo:precedingWork</a>
    /// </summary>
    let precedingWork = _prefixId.prefix "precedingWork"
    /// <summary>
    ///   <para>rdfs:label : Vorgängerrdfs:label : Predecessor</para>
    ///   <para>rdfs:comment : Eine Körperschaft oder ein Werk, das der Vorgänger einer anderen Körperschaft oder eines anderen Werks istrdfs:comment : A corporate body or a work being the predecessor of another corporate body or work</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#predecessor">gndo:predecessor</a>
    /// </summary>
    let predecessor = _prefixId.prefix "predecessor"
    /// <summary>
    ///   <para>rdfs:label : Bevorzugter Namerdfs:label : Preferred name</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#preferredName">gndo:preferredName</a>
    /// </summary>
    let preferredName = _prefixId.prefix "preferredName"

    /// <summary>
    ///   <para>rdfs:label : Bevorzugte Namensentität der Personrdfs:label : Preferred name entity for the person</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#preferredNameEntityForThePerson">gndo:preferredNameEntityForThePerson</a>
    /// </summary>
    let preferredNameEntityForThePerson = _prefixId.prefix "preferredNameEntityForThePerson"

    /// <summary>
    ///   <para>rdfs:label : Preferred name for the conference or eventrdfs:label : Bevorzugter Name der Konferenz oder Veranstaltung</para>
    ///   <para>gndo:marc21equivalent : 111 $a $c $d $e $n $g^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#preferredNameForTheConferenceOrEvent">gndo:preferredNameForTheConferenceOrEvent</a>
    /// </summary>
    let preferredNameForTheConferenceOrEvent = _prefixId.prefix "preferredNameForTheConferenceOrEvent"

    /// <summary>
    ///   <para>rdfs:label : Preferred name for the corporate bodyrdfs:label : Bevorzugter Name der Körperschaft</para>
    ///   <para>gndo:marc21equivalent : 110 $a $b $g $n^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#preferredNameForTheCorporateBody">gndo:preferredNameForTheCorporateBody</a>
    /// </summary>
    let preferredNameForTheCorporateBody = _prefixId.prefix "preferredNameForTheCorporateBody"

    /// <summary>
    ///   <para>rdfs:label : Bevorzugter Name der Familierdfs:label : Preferred name for the family</para>
    ///   <para>gndo:marc21equivalent : 100 $a $b $c $g^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#preferredNameForTheFamily">gndo:preferredNameForTheFamily</a>
    /// </summary>
    let preferredNameForTheFamily = _prefixId.prefix "preferredNameForTheFamily"
    /// <summary>
    ///   <para>rdfs:label : Preferred name for the personrdfs:label : Bevorzugter Name der Person</para>
    ///   <para>gndo:marc21equivalent : 100 $a $b $c $g^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#preferredNameForThePerson">gndo:preferredNameForThePerson</a>
    /// </summary>
    let preferredNameForThePerson = _prefixId.prefix "preferredNameForThePerson"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 151 $a $g $z^^xsd:string</para>
    ///   <para>rdfs:label : Bevorzugter Name des Geografikumrdfs:label : Preferred name for the place or geographic name</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#preferredNameForThePlaceOrGeographicName">gndo:preferredNameForThePlaceOrGeographicName</a>
    /// </summary>
    let preferredNameForThePlaceOrGeographicName = _prefixId.prefix "preferredNameForThePlaceOrGeographicName"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 150 $a $g^^xsd:string</para>
    ///   <para>rdfs:label : Bevorzugter Name des Schlagwortsrdfs:label : Preferred name for the subject heading</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#preferredNameForTheSubjectHeading">gndo:preferredNameForTheSubjectHeading</a>
    /// </summary>
    let preferredNameForTheSubjectHeading = _prefixId.prefix "preferredNameForTheSubjectHeading"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 130 $a $f $g $m $n $o $p $r $s^^xsd:string</para>
    ///   <para>rdfs:label : Bevorzugter Name des Werksrdfs:label : Preferred name for the work</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#preferredNameForTheWork">gndo:preferredNameForTheWork</a>
    /// </summary>
    let preferredNameForTheWork = _prefixId.prefix "preferredNameForTheWork"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 100 $a^^xsd:stringgndo:marc21equivalent : 400 $a^^xsd:string</para>
    ///   <para>rdfs:label : Präfixrdfs:label : Prefix</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#prefix">gndo:prefix</a>
    /// </summary>
    let prefix = _prefixId.prefix "prefix"
    /// <summary>
    ///   <para>rdfs:comment : A person, family, or organization involved in manufacturing a manifestation of printed text, notated music, etc., from type or plates, such as a book, newspaper, magazine, broadside, score, etc</para>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=druc^^xsd:stringgndo:marc21equivalent : 510 $0 $4=druc^^xsd:string</para>
    ///   <para>rdfs:label : Druckerrdfs:label : Printer</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#printer">gndo:printer</a>
    /// </summary>
    let printer = _prefixId.prefix "printer"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 550 $0 $4=beru^^xsd:stringgndo:marc21equivalent : 550 $0 $4=berc^^xsd:string</para>
    ///   <para>rdfs:comment : Ein Beruf oder eine Tätigkeit, die von einer Person oder Familie ausgeübt wird.rdfs:comment : A profession or occupation practiced by a person or family</para>
    ///   <para>rdfs:label : Beruf oder Beschäftigungrdfs:label : Profession or occupation</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#professionOrOccupation">gndo:professionOrOccupation</a>
    /// </summary>
    let professionOrOccupation = _prefixId.prefix "professionOrOccupation"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 550 $a $g $4=berc^^xsd:stringgndo:marc21equivalent : 550 $a $g $4=beru^^xsd:string</para>
    ///   <para>rdfs:comment : This property is equivalent to gndo:professionOrOccupation but gives a literal instead of
    /// 		a reference to a subject headingrdfs:comment : Berufs- oder Tätigkeitsbezeichnung bzw.
    /// 	Bezeichnung für die Religionszugehörigkeit oder die Weltanschauung einer
    /// 	Person. Diese Property ist äquivalent zu gndo:professionOrOccupation, zeigt aber ein Literal
    /// 		statt einer Referenz zu einem Schlagwort</para>
    ///   <para>rdfs:label : Profession or occupation (Literal)rdfs:label : Beruf oder Beschäftigung (Literal)</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#professionOrOccupationAsLiteral">gndo:professionOrOccupationAsLiteral</a>
    /// </summary>
    let professionOrOccupationAsLiteral = _prefixId.prefix "professionOrOccupationAsLiteral"

    /// <summary>
    ///   <para>rdfs:comment : Eine berufliche Beziehung zwischen einer Person oder Familie und einer anderen Person oder Familie.rdfs:comment : An occupational relationship between a person or family and another person or family</para>
    ///   <para>rdfs:label : Professional relationshiprdfs:label : Berufliche Beziehung</para>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=bezb^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#professionalRelationship">gndo:professionalRelationship</a>
    /// </summary>
    let professionalRelationship = _prefixId.prefix "professionalRelationship"
    /// <summary>
    ///   <para>rdfs:comment : Verknüpft eine echte Identität einer Person mit einer Identität, unter der eine oder mehrere Personen agieren, z. B. schreiben, komponieren oder Kunstwerke schaffen, aber die nicht der wirkliche Name der Person ist (Pseudonym).rdfs:comment : Links a person's real identity to an identity under which one or more persons act, e. g. write, compose or create art, but that is not the person's real name (i. e. a pseudonym).</para>
    ///   <para>rdfs:label : Pseudonymrdfs:label : Pseudonym</para>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=pseu^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#pseudonym">gndo:pseudonym</a>
    /// </summary>
    let pseudonym = _prefixId.prefix "pseudonym"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 692 $a^^xsd:string</para>
    ///   <para>rdfs:label : Titelangaberdfs:label : Publication</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#publication">gndo:publication</a>
    /// </summary>
    let publication = _prefixId.prefix "publication"
    /// <summary>
    ///   <para>rdfs:comment : Verknüpft eine Identität, unter der eine oder mehrere Personen agieren, z. B. schreiben, komponieren oder Kunstwerke schaffen, aber die nicht der wirkliche Name der Person ist (Pseudonym), mit der echten Identität der Person.rdfs:comment : Links an identity under which one or more persons act, e. g. write, compose or create art, but that is not their real name (i. e. a pseudonym) to their real identity.</para>
    ///   <para>rdfs:label : Echte Identitätrdfs:label : Real identity</para>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=nawi^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#realIdentity">gndo:realIdentity</a>
    /// </summary>
    let realIdentity = _prefixId.prefix "realIdentity"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 511 $0 $4=rela^^xsd:string</para>
    ///   <para>rdfs:label : In Beziehung stehende Konferenz oder Veranstaltungrdfs:label : Related conference or event</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#relatedConferenceOrEvent">gndo:relatedConferenceOrEvent</a>
    /// </summary>
    let relatedConferenceOrEvent = _prefixId.prefix "relatedConferenceOrEvent"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 510 $0 $4=rela^^xsd:string</para>
    ///   <para>rdfs:label : In Beziehung stehende Körperschaftrdfs:label : Related Corporate Body</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#relatedCorporateBody">gndo:relatedCorporateBody</a>
    /// </summary>
    let relatedCorporateBody = _prefixId.prefix "relatedCorporateBody"

    /// <summary>
    ///   <para>rdfs:label : In Beziehung stehende Dewey-Dezimalklassifikation mit
    ///       Determiniertheitsgrad 1rdfs:label : Related Dewey Decimal Classification with degree of determinacy
    ///       1</para>
    ///   <para>rdfs:comment : Der Bedeutungsumfang der GND-Entität und der Bedeutungsumfang der
    ///       DDC-Klasse haben eine geringe Schnittmenge.rdfs:comment : The connotation scope of the GND entity corresponds to a small part
    ///       to the connotation scope of the assigned DDC class.</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#relatedDdcWithDegreeOfDeterminacy1">gndo:relatedDdcWithDegreeOfDeterminacy1</a>
    /// </summary>
    let relatedDdcWithDegreeOfDeterminacy1 = _prefixId.prefix "relatedDdcWithDegreeOfDeterminacy1"

    /// <summary>
    ///   <para>rdfs:label : In Beziehung stehende Dewey-Dezimalklassifikation mit
    ///       Determiniertheitsgrad 2rdfs:label : Related Dewey Decimal Classification with degree of determinacy
    ///       2</para>
    ///   <para>rdfs:comment : Die GND-Entität stimmt in seinem Bedeutungsumfang vollständig oder
    ///       weitgehend mit dem Bedeutungsumfang eines Themas überein, das sinngemäß Teil einer DDC-Klasse
    ///       ist, aber einen geringeren inhaltlichen Umfang aufweist als der durch die Notation
    ///       repräsentierte Begriff.rdfs:comment : The connotation scope of the GND entity is identical or nearly
    ///       identical to the connotation scope of a topic that is logically part of the class but is less
    ///       extensive in scope than the concept represented by the class number.</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#relatedDdcWithDegreeOfDeterminacy2">gndo:relatedDdcWithDegreeOfDeterminacy2</a>
    /// </summary>
    let relatedDdcWithDegreeOfDeterminacy2 = _prefixId.prefix "relatedDdcWithDegreeOfDeterminacy2"

    /// <summary>
    ///   <para>rdfs:label : In Beziehung stehende Dewey-Dezimalklassifikation mit
    ///       Determiniertheitsgrad 3rdfs:label : Related Dewey Decimal Classification with degree of determinacy
    ///       3</para>
    ///   <para>rdfs:comment : Die GND-Entität stimmt in seinem Bedeutungsumfang vollständig oder
    ///       weitgehend mit dem Bedeutungsumfang eines Themas überein, das wesentliche Übereinstimmung mit
    ///       der DDC-Klasse aufweist. In der DDC-Terminologie liegt eine wesentliche Übereinstimmung vor,
    ///       wenn ein Thema nahezu koextensiv mit einer DDC-Klasse ist oder mehr als die Hälfte des Inhalts
    ///       einer Klassenbenennung abdeckt.rdfs:comment : The connotation scope of the GND entity is identical or nearly
    ///       identical to the connotation scope of a topic that approximates the whole of the assigned DDC
    ///       class. According to DDC terms, topics that are nearly coextensive with the full meaning of a
    ///       class or cover more than half of the content of the class approximate the whole of the DDC
    ///       class.</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#relatedDdcWithDegreeOfDeterminacy3">gndo:relatedDdcWithDegreeOfDeterminacy3</a>
    /// </summary>
    let relatedDdcWithDegreeOfDeterminacy3 = _prefixId.prefix "relatedDdcWithDegreeOfDeterminacy3"

    /// <summary>
    ///   <para>rdfs:label : In Beziehung stehende Dewey-Dezimalklassifikation mit
    ///       Determiniertheitsgrad 4rdfs:label : Related Dewey Decimal Classification with degree of determinacy
    ///       4</para>
    ///   <para>rdfs:comment : Die GND-Entität stimmt in seinem Bedeutungsumfang vollständig mit
    ///       dem Bedeutungsumfang des in der DDC-Klassenbenennung hervorgehobenen Themas überein, d.h. es
    ///       weist auch denselben fachlichen Kontext wie die DDC-Klasse auf.rdfs:comment : The connotation scope of the GND entity is identical to the
    ///       connotation scope of the topic emphasized in the DDC class heading.</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#relatedDdcWithDegreeOfDeterminacy4">gndo:relatedDdcWithDegreeOfDeterminacy4</a>
    /// </summary>
    let relatedDdcWithDegreeOfDeterminacy4 = _prefixId.prefix "relatedDdcWithDegreeOfDeterminacy4"

    /// <summary>
    ///   <para>rdfs:label : In Beziehung stehende Familierdfs:label : Related family</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#relatedFamily">gndo:relatedFamily</a>
    /// </summary>
    let relatedFamily = _prefixId.prefix "relatedFamily"
    /// <summary>
    ///   <para>rdfs:label : In Beziehung stehende Personrdfs:label : Related person</para>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=rela^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#relatedPerson">gndo:relatedPerson</a>
    /// </summary>
    let relatedPerson = _prefixId.prefix "relatedPerson"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 551 $0 $4=geoa^^xsd:stringgndo:marc21equivalent : 551 $0 $4=rela^^xsd:string</para>
    ///   <para>rdfs:label : In Beziehung stehendes Geografikumrdfs:label : Related place or geographic name</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#relatedPlaceOrGeographicName">gndo:relatedPlaceOrGeographicName</a>
    /// </summary>
    let relatedPlaceOrGeographicName = _prefixId.prefix "relatedPlaceOrGeographicName"
    /// <summary>
    ///   <para>rdfs:label : In Beziehung stehendes Schlagwortrdfs:label : Related subject heading</para>
    ///   <para>rdfs:comment : Use relatedSubjectHeading ('subject', not 'subjec') insteadrdfs:comment : Bitte verwenden sie relatedSubjectHeading (mit 'subject' statt 'subjec')</para>
    ///   <para>gndo:marc21equivalent : 550 $0 $4=rela^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#relatedSubjecHeading">gndo:relatedSubjecHeading</a>
    /// </summary>
    let relatedSubjecHeading = _prefixId.prefix "relatedSubjecHeading"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 550 $0 $4=rela^^xsd:string</para>
    ///   <para>rdfs:label : In Beziehung stehendes Schlagwortrdfs:label : Related subject heading</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#relatedSubjectHeading">gndo:relatedSubjectHeading</a>
    /// </summary>
    let relatedSubjectHeading = _prefixId.prefix "relatedSubjectHeading"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=vbal^^xsd:stringgndo:marc21equivalent : 551 $0 $4=vbal^^xsd:stringgndo:marc21equivalent : 510 $0 $4=vbal^^xsd:stringgndo:marc21equivalent : 511 $0 $4=vbal^^xsd:stringgndo:marc21equivalent : 530 $0 $4=vbal^^xsd:stringgndo:marc21equivalent : 550 $0 $4=vbal^^xsd:string</para>
    ///   <para>rdfs:comment : Eine Assoziationsrelation ist eine zwischen Begriffen als wichtig
    ///       erscheinende Relation, die weder eindeutig hierarchischer Natur ist, noch als äquivalent
    ///       angesehen werden kann. Bei Personen ist dies z. B. die Beziehung zwischen fiktiven
    /// 	  Gestalten und ihrem realem Vorbild. Hierzu gehören auch Beziehungen zwischen Personen
    /// 	  und z. B. Körperschaften, die im Namen einer Person agieren,
    /// 	  Gesellschaften, die zu Ehren einer Person gegründet wurden und
    /// 	  Körperschaften, die sich mit einer Person und ihrem Werk beschäftigen.rdfs:comment : The associative relationship covers associations between pairs of
    ///       concepts that are not related hierarchically, but are semantically or concetually associated
    ///       to such an extent that the link between them needs to be made explicit in the thesaurus. </para>
    ///   <para>rdfs:label : Related Termrdfs:label : Verwandter Begriff</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#relatedTerm">gndo:relatedTerm</a>
    /// </summary>
    let relatedTerm = _prefixId.prefix "relatedTerm"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 530 $0 $4=rela^^xsd:string</para>
    ///   <para>rdfs:label : In Beziehung stehendes Werkrdfs:label : Related work</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#relatedWork">gndo:relatedWork</a>
    /// </summary>
    let relatedWork = _prefixId.prefix "relatedWork"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 510 $0 $4=rest^^xsd:stringgndo:marc21equivalent : 500 $0 $4=rest^^xsd:string</para>
    ///   <para>rdfs:comment : A person, family, or organization responsible for the set of technical, editorial, and intellectual procedures aimed at compensating for the degradation of an item by bringing it back to a state as close as possible to its original condition</para>
    ///   <para>rdfs:label : Restauratorrdfs:label : Restorer</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#restorer">gndo:restorer</a>
    /// </summary>
    let restorer = _prefixId.prefix "restorer"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=bear^^xsd:string</para>
    ///   <para>rdfs:label : Bearbeiterrdfs:label : Revisor</para>
    ///   <para>rdfs:comment : A person or organization who 1) reworks a musical composition, usually for a different medium, or 2) rewrites novels or stories for motion pictures or other audiovisual medium.</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#revisor">gndo:revisor</a>
    /// </summary>
    let revisor = _prefixId.prefix "revisor"
    /// <summary>
    ///   <para>rdfs:label : Drehbuchautorrdfs:label : Screenwriter</para>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=vfrd^^xsd:stringgndo:marc21equivalent : 510 $0 $4=vfrd^^xsd:string</para>
    ///   <para>rdfs:comment : An author of a screenplay, script, or scene</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#screenwriter">gndo:screenwriter</a>
    /// </summary>
    let screenwriter = _prefixId.prefix "screenwriter"
    /// <summary>
    ///   <para>rdfs:label : Skriptoriumrdfs:label : Scriptorium</para>
    ///   <para>rdfs:comment : A scriptorium in a monastery</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#scriptorium">gndo:scriptorium</a>
    /// </summary>
    let scriptorium = _prefixId.prefix "scriptorium"
    /// <summary>
    ///   <para>rdfs:label : Sculptorrdfs:label : Bildhauer</para>
    ///   <para>rdfs:comment : An artist responsible for creating a three-dimensional work by modeling, carving, or similar technique</para>
    ///   <para>gndo:marc21equivalent : 510 $0 $4=bilh^^xsd:stringgndo:marc21equivalent : 500 $0 $4=bilh^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#sculptor">gndo:sculptor</a>
    /// </summary>
    let sculptor = _prefixId.prefix "sculptor"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 383 $a^^xsd:string</para>
    ///   <para>rdfs:label : Fortlaufende Zählung des Musikwerksrdfs:label : Serial numeric designation of musical work</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#serialNumericDesignationOfMusicalWork">gndo:serialNumericDesignationOfMusicalWork</a>
    /// </summary>
    let serialNumericDesignationOfMusicalWork = _prefixId.prefix "serialNumericDesignationOfMusicalWork"

    /// <summary>
    ///   <para>rdfs:comment : A performer contributing to a resource by using his/her/their voice, with or without instrumental accompaniment, to produce music. A singer's performance may or may not include actual words</para>
    ///   <para>gndo:marc21equivalent : 510 $0 $4=saen^^xsd:stringgndo:marc21equivalent : 500 $0 $4=saen^^xsd:string</para>
    ///   <para>rdfs:label : Singerrdfs:label : Sänger</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#singer">gndo:singer</a>
    /// </summary>
    let singer = _prefixId.prefix "singer"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 034 $g^^xsd:string</para>
    ///   <para>rdfs:label : Südlichster Breitengradrdfs:label : Southernmost latitude</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#southernmostLatitude">gndo:southernmostLatitude</a>
    /// </summary>
    let southernmostLatitude = _prefixId.prefix "southernmostLatitude"
    /// <summary>
    ///   <para>rdfs:comment : Geographic field of activityrdfs:comment : Geografischer Wirkungsbereich</para>
    ///   <para>rdfs:label : Geographischer Wirkungsbereichrdfs:label : Spatial area of activity</para>
    ///   <para>gndo:marc21equivalent : 551 $0 $4=geow^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#spatialAreaOfActivity">gndo:spatialAreaOfActivity</a>
    /// </summary>
    let spatialAreaOfActivity = _prefixId.prefix "spatialAreaOfActivity"
    /// <summary>
    ///   <para>rdfs:label : Sponsor or patronrdfs:label : Sponsor oder Mäzen</para>
    ///   <para>gndo:marc21equivalent : 510 $0 $4=spon^^xsd:stringgndo:marc21equivalent : 550 $0 $4=spon^^xsd:stringgndo:marc21equivalent : 500 $0 $4=spon^^xsd:string</para>
    ///   <para>rdfs:comment : A person, family, or organization sponsoring some aspect of a resource, e.g., funding research, sponsoring an event</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#sponsorOrPatron">gndo:sponsorOrPatron</a>
    /// </summary>
    let sponsorOrPatron = _prefixId.prefix "sponsorOrPatron"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 551 $0 $4=punk^^xsd:string</para>
    ///   <para>rdfs:label : Beginn und Ende einer Streckerdfs:label : Starting or final point of a distance</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#startingOrFinalPointOfADistance">gndo:startingOrFinalPointOfADistance</a>
    /// </summary>
    let startingOrFinalPointOfADistance = _prefixId.prefix "startingOrFinalPointOfADistance"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 510 $0 $4=reda^^xsd:stringgndo:marc21equivalent : 500 $0 $4=reda^^xsd:string</para>
    ///   <para>rdfs:comment : A person or organization who writes or develops the framework for an item without being intellectually responsible for its content</para>
    ///   <para>rdfs:label : Redakteurrdfs:label : Subeditor</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#subeditor">gndo:subeditor</a>
    /// </summary>
    let subeditor = _prefixId.prefix "subeditor"
    /// <summary>
    ///   <para>rdfs:label : Nachfolgende Konferenz oder Veranstaltungrdfs:label : Succeeding conference or event</para>
    ///   <para>gndo:marc21equivalent : 511 $0 $4=nach^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#succeedingConferenceOrEvent">gndo:succeedingConferenceOrEvent</a>
    /// </summary>
    let succeedingConferenceOrEvent = _prefixId.prefix "succeedingConferenceOrEvent"
    /// <summary>
    ///   <para>rdfs:label : Nachfolgende Körperschaftrdfs:label : Succeeding corporate body</para>
    ///   <para>gndo:marc21equivalent : 510 $0 $4=nach^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#succeedingCorporateBody">gndo:succeedingCorporateBody</a>
    /// </summary>
    let succeedingCorporateBody = _prefixId.prefix "succeedingCorporateBody"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 551 $0 $4=nach^^xsd:string</para>
    ///   <para>rdfs:label : Nachfolgendes Geografikumrdfs:label : Succeeding place or geographic name</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#succeedingPlaceOrGeographicName">gndo:succeedingPlaceOrGeographicName</a>
    /// </summary>
    let succeedingPlaceOrGeographicName = _prefixId.prefix "succeedingPlaceOrGeographicName"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 550 $0 $4=nach^^xsd:string</para>
    ///   <para>rdfs:label : Nachfolgendes Schlagwortrdfs:label : Succeeding subject heading</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#succeedingSubjectHeading">gndo:succeedingSubjectHeading</a>
    /// </summary>
    let succeedingSubjectHeading = _prefixId.prefix "succeedingSubjectHeading"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 530 $0 $4=nach^^xsd:string</para>
    ///   <para>rdfs:label : Nachfolgendes Werkrdfs:label : Succeeding work</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#succeedingWork">gndo:succeedingWork</a>
    /// </summary>
    let succeedingWork = _prefixId.prefix "succeedingWork"
    /// <summary>
    ///   <para>rdfs:label : Nachfolgerrdfs:label : Successor</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#successor">gndo:successor</a>
    /// </summary>
    let successor = _prefixId.prefix "successor"
    /// <summary>
    ///   <para>rdfs:label : Super-Property vonrdfs:label : Super-property of</para>
    ///   <para>rdfs:comment : P1 gnd:superPropertyOf P2 sagt aus, dass P2 eine Subproperty von P1
    ///       ist. Die gndo:superPropertyOf-Property ist transitiv.rdfs:comment : P1 gnd:superPropertyOf P2 states that P2 is a subproperty of P1. The
    ///       gndo:superPropertyOf property is transitive.</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#superPropertyOf">gndo:superPropertyOf</a>
    /// </summary>
    let superPropertyOf = _prefixId.prefix "superPropertyOf"
    /// <summary>
    ///   <para>rdfs:label : Nachnamerdfs:label : Surname</para>
    ///   <para>gndo:marc21equivalent : 100 $a^^xsd:stringgndo:marc21equivalent : 400 $a^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#surname">gndo:surname</a>
    /// </summary>
    let surname = _prefixId.prefix "surname"
    /// <summary>
    ///   <para>rdfs:label : Zeitweiser Namerdfs:label : Temporary name</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#temporaryName">gndo:temporaryName</a>
    /// </summary>
    let temporaryName = _prefixId.prefix "temporaryName"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 511 $0 $4=nazw^^xsd:string</para>
    ///   <para>rdfs:label : Zeitweiser Name der Konferenz oder Veranstaltungrdfs:label : Temporary name of the conference or event</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#temporaryNameOfTheConferenceOrEvent">gndo:temporaryNameOfTheConferenceOrEvent</a>
    /// </summary>
    let temporaryNameOfTheConferenceOrEvent = _prefixId.prefix "temporaryNameOfTheConferenceOrEvent"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 510 $0 $4=nazw^^xsd:stringgndo:marc21equivalent : 551 $0 $4=nazw^^xsd:string</para>
    ///   <para>rdfs:label : Temporary name of the corporate bodyrdfs:label : Zeitweiser Name der Körperschaft</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#temporaryNameOfTheCorporateBody">gndo:temporaryNameOfTheCorporateBody</a>
    /// </summary>
    let temporaryNameOfTheCorporateBody = _prefixId.prefix "temporaryNameOfTheCorporateBody"

    /// <summary>
    ///   <para>rdfs:label : Zeitweiser Name des Geografikumsrdfs:label : Temporary name of the place or geographic name</para>
    ///   <para>gndo:marc21equivalent : 510 $0 $4=nazw^^xsd:stringgndo:marc21equivalent : 551 $0 $4=nazw^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#temporaryNameOfThePlaceOrGeographicName">gndo:temporaryNameOfThePlaceOrGeographicName</a>
    /// </summary>
    let temporaryNameOfThePlaceOrGeographicName = _prefixId.prefix "temporaryNameOfThePlaceOrGeographicName"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 383 $c^^xsd:string</para>
    ///   <para>rdfs:label : Zählung eines Werksverzeichnisses des Musikwerksrdfs:label : Thematic index numeric designation of musical work</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#thematicIndexNumericDesignationOfMusicalWork">gndo:thematicIndexNumericDesignationOfMusicalWork</a>
    /// </summary>
    let thematicIndexNumericDesignationOfMusicalWork = _prefixId.prefix "thematicIndexNumericDesignationOfMusicalWork"

    /// <summary>
    ///   <para>rdfs:label : Adelstitelrdfs:label : Title of nobility</para>
    ///   <para>gndo:marc21equivalent : 550 $0 $4=adel^^xsd:string</para>
    ///   <para>rdfs:comment : Adelstitel einer Person oder einer Familie.rdfs:comment : A title of nobility held by a person or family.</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#titleOfNobility">gndo:titleOfNobility</a>
    /// </summary>
    let titleOfNobility = _prefixId.prefix "titleOfNobility"
    /// <summary>
    ///   <para>rdfs:label : Adelstitel (Literal)rdfs:label : Title of nobility (Literal)</para>
    ///   <para>rdfs:comment : Adelstitel einer Person oder Adelstitel im Erbtitel
    /// 		einer Familie. Diese Property ist äquivalent zu gndo:titleOfNobility, zeigt
    /// 		aber ein Literal statt einer Referenz zu einem Schlagwort.rdfs:comment : A title of nobility held by a person or family.
    /// 		This property is equivalent to gndo:titleOfNobility
    /// 		but gives a literal instead of a reference to a subject heading.</para>
    ///   <para>gndo:marc21equivalent : 550 $a $g $4=adel^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#titleOfNobilityAsLiteral">gndo:titleOfNobilityAsLiteral</a>
    /// </summary>
    let titleOfNobilityAsLiteral = _prefixId.prefix "titleOfNobilityAsLiteral"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 550 $0 $4=them^^xsd:stringgndo:marc21equivalent : 530 $0 $4=them^^xsd:stringgndo:marc21equivalent : 500 $0 $4=them^^xsd:stringgndo:marc21equivalent : 551 $0 $4=them^^xsd:stringgndo:marc21equivalent : 511 $0 $4=them^^xsd:stringgndo:marc21equivalent : 510 $0 $4=them^^xsd:string</para>
    ///   <para>rdfs:label : Topicrdfs:label : Thema</para>
    ///   <para>rdfs:comment : Topic that is related to a corporate body, conference, person, family, subject heading or work.rdfs:comment : Thema, das mit einer Körperschaft, Konferenz, Person, Familie, Schlagwort oder Werk in Beziehung steht.</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#topic">gndo:topic</a>
    /// </summary>
    let topic = _prefixId.prefix "topic"
    /// <summary>
    ///   <para>rdfs:label : Übersetzerrdfs:label : Translator</para>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=uebe^^xsd:stringgndo:marc21equivalent : 510 $0 $4=uebe^^xsd:string</para>
    ///   <para>rdfs:comment : A person or organization who renders a text from one language into another, or from an older form of a language into the modern form</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#translator">gndo:translator</a>
    /// </summary>
    let translator = _prefixId.prefix "translator"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 034 $9^^xsd:string</para>
    ///   <para>rdfs:label : Koordinatentyprdfs:label : Type of coordinates</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#typeOfCoordinates">gndo:typeOfCoordinates</a>
    /// </summary>
    let typeOfCoordinates = _prefixId.prefix "typeOfCoordinates"
    /// <summary>
    ///   <para>rdfs:comment : Date, expressed as UDK coderdfs:comment : Zeitangabe als UDK-Code</para>
    ///   <para>rdfs:label : UDK-Coderdfs:label : UDK-Code</para>
    ///   <para>gndo:marc21equivalent : 548 $a $4=datu^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#udkCode">gndo:udkCode</a>
    /// </summary>
    let udkCode = _prefixId.prefix "udkCode"
    /// <summary>
    ///   <para>rdfs:label : Varianter Namerdfs:label : Variant name</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#variantName">gndo:variantName</a>
    /// </summary>
    let variantName = _prefixId.prefix "variantName"
    /// <summary>
    ///   <para>rdfs:label : Variante Namensentität der Personrdfs:label : Variant name entity for the person</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#variantNameEntityForThePerson">gndo:variantNameEntityForThePerson</a>
    /// </summary>
    let variantNameEntityForThePerson = _prefixId.prefix "variantNameEntityForThePerson"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 411 $a $c $d $e $g $n^^xsd:string</para>
    ///   <para>rdfs:label : Variant name for the conference or eventrdfs:label : Varianter Name der Konferenz oder Veranstaltung</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#variantNameForTheConferenceOrEvent">gndo:variantNameForTheConferenceOrEvent</a>
    /// </summary>
    let variantNameForTheConferenceOrEvent = _prefixId.prefix "variantNameForTheConferenceOrEvent"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 410 $a $b $g $n^^xsd:string</para>
    ///   <para>rdfs:label : Varianter Name der Körperschaftrdfs:label : Variant name for the corporate body</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#variantNameForTheCorporateBody">gndo:variantNameForTheCorporateBody</a>
    /// </summary>
    let variantNameForTheCorporateBody = _prefixId.prefix "variantNameForTheCorporateBody"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 400 $a $b $c $g^^xsd:string</para>
    ///   <para>rdfs:label : Variant name for the familyrdfs:label : Varianter Name der Familie</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#variantNameForTheFamily">gndo:variantNameForTheFamily</a>
    /// </summary>
    let variantNameForTheFamily = _prefixId.prefix "variantNameForTheFamily"
    /// <summary>
    ///   <para>rdfs:label : Varianter Name der Personrdfs:label : Variant name for the person</para>
    ///   <para>gndo:marc21equivalent : 400 $a $b $c $g^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#variantNameForThePerson">gndo:variantNameForThePerson</a>
    /// </summary>
    let variantNameForThePerson = _prefixId.prefix "variantNameForThePerson"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 451 $a $g $z^^xsd:string</para>
    ///   <para>rdfs:label : Varianter Name des Geografikumrdfs:label : Variant name for the place or geographic name</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#variantNameForThePlaceOrGeographicName">gndo:variantNameForThePlaceOrGeographicName</a>
    /// </summary>
    let variantNameForThePlaceOrGeographicName = _prefixId.prefix "variantNameForThePlaceOrGeographicName"

    /// <summary>
    ///   <para>rdfs:label : Varianter Name des Schlagwortsrdfs:label : Variant name for the subject heading</para>
    ///   <para>gndo:marc21equivalent : 450 $a $g^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#variantNameForTheSubjectHeading">gndo:variantNameForTheSubjectHeading</a>
    /// </summary>
    let variantNameForTheSubjectHeading = _prefixId.prefix "variantNameForTheSubjectHeading"

    /// <summary>
    ///   <para>gndo:marc21equivalent : 430 $a $f $g $m $n $o $p $r $s^^xsd:string</para>
    ///   <para>rdfs:label : Varianter Name des Werksrdfs:label : Variant name for the work</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#variantNameForTheWork">gndo:variantNameForTheWork</a>
    /// </summary>
    let variantNameForTheWork = _prefixId.prefix "variantNameForTheWork"
    /// <summary>
    ///   <para>gndo:marc21equivalent : 034 $d^^xsd:string</para>
    ///   <para>rdfs:label : Westlichster Längengradrdfs:label : Westernmost longitude</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#westernmostLongitude">gndo:westernmostLongitude</a>
    /// </summary>
    let westernmostLongitude = _prefixId.prefix "westernmostLongitude"
    /// <summary>
    ///   <para>rdfs:comment : A person or organization responsible for the commentary or explanatory notes about a text. For the writer of manuscript annotations in a printed book, use Annotator</para>
    ///   <para>rdfs:label : Kommentator (schriftlich)rdfs:label : Writer of added commentary</para>
    ///   <para>gndo:marc21equivalent : 500 $0 $4=komm^^xsd:stringgndo:marc21equivalent : 510 $0 $4=komm^^xsd:string</para>
    ///   <a href="http://d-nb.info/standards/elementset/gnd#writerOfAddedCommentary">gndo:writerOfAddedCommentary</a>
    /// </summary>
    let writerOfAddedCommentary = _prefixId.prefix "writerOfAddedCommentary"

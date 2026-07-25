namespace http.d_nb.info.standards.elementset.gnd.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module gndo =
    let _namespace_iri = Namespace_Iri gndo |> NamespaceIRI
    /// <summary>
    ///   <para>gndo:dnbStaff</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    ///
    /// labels<para>Staff members of the Deutsche Nationalbibliothek</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#dnbStaff">http://d-nb.info/standards/elementset/gnd#dnbStaff</seealso>
    let dnbStaff = Prefixed_Name(gndo, "dnbStaff") |> PrefixedName
    /// <summary>
    ///   <para>gndo:marc21equivalent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Gibt die MARC 21 Entsprechung des Elements im GND-MARC-Format
    ///       wieder.</para>
    ///   <para>Expresses the MARC 21 equivalent for this element in the GND MARC
    ///       format.</para>
    /// labels<para>MARC 21 Entsprechung</para><para>MARC 21 equivalent</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#marc21equivalent">http://d-nb.info/standards/elementset/gnd#marc21equivalent</seealso>
    let marc21equivalent = Prefixed_Name(gndo, "marc21equivalent") |> PrefixedName

    /// <summary>
    ///   <para>gndo:PlaceOrGeographicName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Place or geographic name</para><para>Geografikum</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#PlaceOrGeographicName">http://d-nb.info/standards/elementset/gnd#PlaceOrGeographicName</seealso>
    let PlaceOrGeographicName =
        Prefixed_Name(gndo, "PlaceOrGeographicName") |> PrefixedName

    /// <summary>
    ///   <para>gndo:AuthorityResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Normdatenressource</para><para>Authority Resource</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#AuthorityResource">http://d-nb.info/standards/elementset/gnd#AuthorityResource</seealso>
    let AuthorityResource = Prefixed_Name(gndo, "AuthorityResource") |> PrefixedName

    /// <summary>
    ///   <para>gndo:preferredNameForTheConferenceOrEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Bevorzugter Name der Konferenz oder Veranstaltung</para><para>Preferred name for the conference or event</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#preferredNameForTheConferenceOrEvent">http://d-nb.info/standards/elementset/gnd#preferredNameForTheConferenceOrEvent</seealso>
    let preferredNameForTheConferenceOrEvent =
        Prefixed_Name(gndo, "preferredNameForTheConferenceOrEvent") |> PrefixedName

    /// <summary>
    ///   <para>gndo:preferredNameForTheFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>Preferred name for the family</para><para>Bevorzugter Name der Familie</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#preferredNameForTheFamily">http://d-nb.info/standards/elementset/gnd#preferredNameForTheFamily</seealso>
    let preferredNameForTheFamily =
        Prefixed_Name(gndo, "preferredNameForTheFamily") |> PrefixedName

    /// <summary>
    ///   <para>gndo:listMembers</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    ///
    /// labels<para>Members of the GND ontology mailing list</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#listMembers">http://d-nb.info/standards/elementset/gnd#listMembers</seealso>
    let listMembers = Prefixed_Name(gndo, "listMembers") |> PrefixedName

    /// <summary>
    ///   <para>gndo:SubjectHeadingSensoStricto</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Subject heading senso stricto</para><para>Schlagwort senso stricto</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#SubjectHeadingSensoStricto">http://d-nb.info/standards/elementset/gnd#SubjectHeadingSensoStricto</seealso>
    let SubjectHeadingSensoStricto =
        Prefixed_Name(gndo, "SubjectHeadingSensoStricto") |> PrefixedName

    /// <summary>
    ///   <para>gndo:VersionOfAMusicalWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Fassung eines Werks der Musik</para><para>Version of a musical work</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#VersionOfAMusicalWork">http://d-nb.info/standards/elementset/gnd#VersionOfAMusicalWork</seealso>
    let VersionOfAMusicalWork =
        Prefixed_Name(gndo, "VersionOfAMusicalWork") |> PrefixedName

    /// <summary>
    ///   <para>gndo:WayBorderOrLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Weg, Grenze oder Linie</para><para>Way, border or line</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#WayBorderOrLine">http://d-nb.info/standards/elementset/gnd#WayBorderOrLine</seealso>
    let WayBorderOrLine = Prefixed_Name(gndo, "WayBorderOrLine") |> PrefixedName

    /// <summary>
    ///   <para>gndo:abbreviatedNameForTheConferenceOrEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>Abgekürzter Name der Konferenz oder Veranstaltung</para><para>Abbreviated name for the conference or event</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#abbreviatedNameForTheConferenceOrEvent">http://d-nb.info/standards/elementset/gnd#abbreviatedNameForTheConferenceOrEvent</seealso>
    let abbreviatedNameForTheConferenceOrEvent =
        Prefixed_Name(gndo, "abbreviatedNameForTheConferenceOrEvent") |> PrefixedName

    /// <summary>
    ///   <para>gndo:variantNameForTheConferenceOrEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>Varianter Name der Konferenz oder Veranstaltung</para><para>Variant name for the conference or event</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#variantNameForTheConferenceOrEvent">http://d-nb.info/standards/elementset/gnd#variantNameForTheConferenceOrEvent</seealso>
    let variantNameForTheConferenceOrEvent =
        Prefixed_Name(gndo, "variantNameForTheConferenceOrEvent") |> PrefixedName

    /// <summary>
    ///   <para>gndo:abbreviatedNameForTheCorporateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>Abbreviated name for the corporate body</para><para>Abgekürzter Name der Körperschaft</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#abbreviatedNameForTheCorporateBody">http://d-nb.info/standards/elementset/gnd#abbreviatedNameForTheCorporateBody</seealso>
    let abbreviatedNameForTheCorporateBody =
        Prefixed_Name(gndo, "abbreviatedNameForTheCorporateBody") |> PrefixedName

    /// <summary>
    ///   <para>gndo:variantNameForThePlaceOrGeographicName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Variant name for the place or geographic name</para><para>Varianter Name des Geografikum</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#variantNameForThePlaceOrGeographicName">http://d-nb.info/standards/elementset/gnd#variantNameForThePlaceOrGeographicName</seealso>
    let variantNameForThePlaceOrGeographicName =
        Prefixed_Name(gndo, "variantNameForThePlaceOrGeographicName") |> PrefixedName

    /// <summary>
    ///   <para>gndo:variantNameForTheWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Variant name for the work</para><para>Varianter Name des Werks</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#variantNameForTheWork">http://d-nb.info/standards/elementset/gnd#variantNameForTheWork</seealso>
    let variantNameForTheWork =
        Prefixed_Name(gndo, "variantNameForTheWork") |> PrefixedName

    /// <summary>
    ///   <para>gndo:academicDegree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>An academic degree.</para>
    ///   <para>Ein Rang, der als Bestätigung für wissenschaftliche Leistungen verliehen wird.</para>
    /// labels<para>Akademischer Grad</para><para>Academic degree</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#academicDegree">http://d-nb.info/standards/elementset/gnd#academicDegree</seealso>
    let academicDegree = Prefixed_Name(gndo, "academicDegree") |> PrefixedName
    /// <summary>
    ///   <para>gndo:initiator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A person, family, or corporate body who initiated a work</para>
    ///   <para>Eine Person, Familie oder Körperschaft, die ein Werk veranlasst hat</para>
    /// labels<para>Veranlasser</para><para>Initiator</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#initiator">http://d-nb.info/standards/elementset/gnd#initiator</seealso>
    let initiator = Prefixed_Name(gndo, "initiator") |> PrefixedName
    /// <summary>
    ///   <para>gndo:instrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A musical instrument, a device to perform music with</para>
    ///   <para>Ein Musikinstrument</para>
    /// labels<para>Instrument</para><para>Instrument</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#instrument">http://d-nb.info/standards/elementset/gnd#instrument</seealso>
    let instrument = Prefixed_Name(gndo, "instrument") |> PrefixedName
    /// <summary>
    ///   <para>gndo:instrumentalist</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A performer contributing to a resource by playing a musical instrument</para>
    /// labels<para>Instrumentalmusiker</para><para>Instrumentalist</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#instrumentalist">http://d-nb.info/standards/elementset/gnd#instrumentalist</seealso>
    let instrumentalist = Prefixed_Name(gndo, "instrumentalist") |> PrefixedName
    /// <summary>
    ///   <para>gndo:keyOfTheVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Key of the version</para><para>Tonart der Fassung</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#keyOfTheVersion">http://d-nb.info/standards/elementset/gnd#keyOfTheVersion</seealso>
    let keyOfTheVersion = Prefixed_Name(gndo, "keyOfTheVersion") |> PrefixedName
    /// <summary>
    ///   <para>gndo:keyOfTheWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Tonart des Werks</para><para>Key of the work</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#keyOfTheWork">http://d-nb.info/standards/elementset/gnd#keyOfTheWork</seealso>
    let keyOfTheWork = Prefixed_Name(gndo, "keyOfTheWork") |> PrefixedName
    /// <summary>
    ///   <para>gndo:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Sprache, in der ein Werk verfasst wurde oder die eine Person, Familie oder Körperschaft benutzt.</para>
    ///   <para>A language used by a person or family or in which a work was written</para>
    /// labels<para>Language</para><para>Sprache</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#language">http://d-nb.info/standards/elementset/gnd#language</seealso>
    let language = Prefixed_Name(gndo, "language") |> PrefixedName
    /// <summary>
    ///   <para>gndo:languageCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Language code</para><para>Sprachencode</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#languageCode">http://d-nb.info/standards/elementset/gnd#languageCode</seealso>
    let languageCode = Prefixed_Name(gndo, "languageCode") |> PrefixedName
    /// <summary>
    ///   <para>gndo:librettist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>An author of a libretto of an opera or other stage work, or an oratorio</para>
    /// labels<para>Librettist</para><para>Librettist</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#librettist">http://d-nb.info/standards/elementset/gnd#librettist</seealso>
    let librettist = Prefixed_Name(gndo, "librettist") |> PrefixedName
    /// <summary>
    ///   <para>gndo:literarySource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The described entity is a realization of the related work</para>
    ///   <para>Die beschriebene Entität ist eine Realisierung des in Beziehung stehenden Werkes</para>
    /// labels<para>Literary source</para><para>Vorlage</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#literarySource">http://d-nb.info/standards/elementset/gnd#literarySource</seealso>
    let literarySource = Prefixed_Name(gndo, "literarySource") |> PrefixedName
    /// <summary>
    ///   <para>gndo:lithographer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A person or organization who prepares the stone or plate for lithographic printing, including a graphic artist creating a design directly on the surface from which printing will be done.</para>
    /// labels<para>Lithographer</para><para>Litograf</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#lithographer">http://d-nb.info/standards/elementset/gnd#lithographer</seealso>
    let lithographer = Prefixed_Name(gndo, "lithographer") |> PrefixedName
    /// <summary>
    ///   <para>gndo:manufacturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A person or organization responsible for printing, duplicating, casting, etc. a resource</para>
    /// labels<para>Manufacturer</para><para>Hersteller</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#manufacturer">http://d-nb.info/standards/elementset/gnd#manufacturer</seealso>
    let manufacturer = Prefixed_Name(gndo, "manufacturer") |> PrefixedName
    /// <summary>
    ///   <para>gndo:mediumOfPerformance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Besetzung im Musikbereich</para><para>Medium of performance</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#mediumOfPerformance">http://d-nb.info/standards/elementset/gnd#mediumOfPerformance</seealso>
    let mediumOfPerformance = Prefixed_Name(gndo, "mediumOfPerformance") |> PrefixedName
    /// <summary>
    ///   <para>gndo:musician</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A person or organization who performs music or contributes to the musical content of a work when it is not possible or desirable to identify the function more precisely</para>
    /// labels<para>Musician</para><para>Musiker</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#musician">http://d-nb.info/standards/elementset/gnd#musician</seealso>
    let musician = Prefixed_Name(gndo, "musician") |> PrefixedName
    /// <summary>
    ///   <para>gndo:nameAddition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Name addition</para><para>Namensusatz</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#nameAddition">http://d-nb.info/standards/elementset/gnd#nameAddition</seealso>
    let nameAddition = Prefixed_Name(gndo, "nameAddition") |> PrefixedName
    /// <summary>
    ///   <para>gndo:narrator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A performer contributing to a resource by reading or speaking in order to give an account of an act, occurrence, course of events, etc</para>
    /// labels<para>Narrator</para><para>Sprecher</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#narrator">http://d-nb.info/standards/elementset/gnd#narrator</seealso>
    let narrator = Prefixed_Name(gndo, "narrator") |> PrefixedName

    /// <summary>
    ///   <para>gndo:northernmostLatitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Nördlichster Breitengrad</para><para>Northernmost latitude</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#northernmostLatitude">http://d-nb.info/standards/elementset/gnd#northernmostLatitude</seealso>
    let northernmostLatitude =
        Prefixed_Name(gndo, "northernmostLatitude") |> PrefixedName

    /// <summary>
    ///   <para>gndo:occasion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Bewegrund für die vorliegende Entität als Datensatz
    /// 		(z.B. ein Werk oder historisches Einzelereignis als Anlass für eine Konferenz
    /// 		oder ein historisches Einzelereignis oder eine Konferenz als Anlass für ein Werk).</para>
    ///   <para>Reason of the entity, e.g. a work or a historic event
    /// 		is the reason of a conference, or a conference is the reason of a work.</para>
    /// labels<para>Occasion</para><para>Anlass</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#occasion">http://d-nb.info/standards/elementset/gnd#occasion</seealso>
    let occasion = Prefixed_Name(gndo, "occasion") |> PrefixedName

    /// <summary>
    ///   <para>gndo:occasionOfTheSubjectHeading</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Occasion of the subject heading</para><para>Anlass des Schlagworts</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#occasionOfTheSubjectHeading">http://d-nb.info/standards/elementset/gnd#occasionOfTheSubjectHeading</seealso>
    let occasionOfTheSubjectHeading =
        Prefixed_Name(gndo, "occasionOfTheSubjectHeading") |> PrefixedName

    /// <summary>
    ///   <para>gndo:occasionOfTheWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Occasion of the work</para><para>Anlass des Werkes</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#occasionOfTheWork">http://d-nb.info/standards/elementset/gnd#occasionOfTheWork</seealso>
    let occasionOfTheWork = Prefixed_Name(gndo, "occasionOfTheWork") |> PrefixedName
    /// <summary>
    ///   <para>gndo:oldAuthorityNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Old authority number</para><para>Alte Normnummer</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#oldAuthorityNumber">http://d-nb.info/standards/elementset/gnd#oldAuthorityNumber</seealso>
    let oldAuthorityNumber = Prefixed_Name(gndo, "oldAuthorityNumber") |> PrefixedName

    /// <summary>
    ///   <para>gndo:PreferredNameOfThePerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Preferred name of the person</para><para>Bevorzugter Name der Person</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#PreferredNameOfThePerson">http://d-nb.info/standards/elementset/gnd#PreferredNameOfThePerson</seealso>
    let PreferredNameOfThePerson =
        Prefixed_Name(gndo, "PreferredNameOfThePerson") |> PrefixedName

    /// <summary>
    ///   <para>gndo:ProjectOrProgram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Projekt oder Programm</para><para>Project or program</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#ProjectOrProgram">http://d-nb.info/standards/elementset/gnd#ProjectOrProgram</seealso>
    let ProjectOrProgram = Prefixed_Name(gndo, "ProjectOrProgram") |> PrefixedName
    /// <summary>
    ///   <para>gndo:Pseudonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Die vorliegende abweichende Namensform ist der
    /// 			wirkliche Name einer Person, für die als bevorzugter Name ein Pseudonym
    /// 			gewählt wird.</para>
    /// labels<para>Pseudonym</para><para>Pseudonym</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#Pseudonym">http://d-nb.info/standards/elementset/gnd#Pseudonym</seealso>
    let Pseudonym = Prefixed_Name(gndo, "Pseudonym") |> PrefixedName
    /// <summary>
    ///   <para>gndo:gndIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>GND-Identifier</para><para>GND-Nummer</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#gndIdentifier">http://d-nb.info/standards/elementset/gnd#gndIdentifier</seealso>
    let gndIdentifier = Prefixed_Name(gndo, "gndIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>gndo:AdministrativeUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Administrative unit</para><para>Verwaltungseinheit</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#AdministrativeUnit">http://d-nb.info/standards/elementset/gnd#AdministrativeUnit</seealso>
    let AdministrativeUnit = Prefixed_Name(gndo, "AdministrativeUnit") |> PrefixedName
    /// <summary>
    ///   <para>gndo:BuildingOrMemorial</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Bauwerk oder Denkmal</para><para>Building or memorial</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#BuildingOrMemorial">http://d-nb.info/standards/elementset/gnd#BuildingOrMemorial</seealso>
    let BuildingOrMemorial = Prefixed_Name(gndo, "BuildingOrMemorial") |> PrefixedName

    /// <summary>
    ///   <para>gndo:CharactersOrMorphemes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Buchstaben oder Morpheme</para><para>Characters or morphemes</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#CharactersOrMorphemes">http://d-nb.info/standards/elementset/gnd#CharactersOrMorphemes</seealso>
    let CharactersOrMorphemes =
        Prefixed_Name(gndo, "CharactersOrMorphemes") |> PrefixedName

    /// <summary>
    ///   <para>gndo:MeansOfTransportWithIndividualName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Means of transport with individual name</para><para>Verkehrsmittel mit Individualnamen</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#MeansOfTransportWithIndividualName">http://d-nb.info/standards/elementset/gnd#MeansOfTransportWithIndividualName</seealso>
    let MeansOfTransportWithIndividualName =
        Prefixed_Name(gndo, "MeansOfTransportWithIndividualName") |> PrefixedName

    /// <summary>
    ///   <para>gndo:firstComposer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Eine Person, Familie oder Körperschaft, die als einziger oder erster Komponist bekannt ist</para>
    ///   <para>A person or organization that takes primary responsibility for a particular activity or endeavor. May be combined with another relator term or code to show the greater importance this person or organization has regarding that particular role. If more than one relator is assigned to a heading, use the Lead relator only if it applies to all the relators</para>
    /// labels<para>Erster Komponist</para><para>First composer</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#firstComposer">http://d-nb.info/standards/elementset/gnd#firstComposer</seealso>
    let firstComposer = Prefixed_Name(gndo, "firstComposer") |> PrefixedName

    /// <summary>
    ///   <para>gndo:formOfWorkAndExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Form des Werks und der Expression</para><para>Form of work and expression</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#formOfWorkAndExpression">http://d-nb.info/standards/elementset/gnd#formOfWorkAndExpression</seealso>
    let formOfWorkAndExpression =
        Prefixed_Name(gndo, "formOfWorkAndExpression") |> PrefixedName

    /// <summary>
    ///   <para>gndo:formerOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A person, family, or organization formerly having legal possession of an item</para>
    ///   <para>Eine Person, eine Familie oder eine Körperschaft, die früher rechtmäßiger Besitzer einer Ressource war.</para>
    /// labels<para>Früherer Besitzer</para><para>Former owner</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#formerOwner">http://d-nb.info/standards/elementset/gnd#formerOwner</seealso>
    let formerOwner = Prefixed_Name(gndo, "formerOwner") |> PrefixedName

    /// <summary>
    ///   <para>gndo:variantNameForTheSubjectHeading</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>Variant name for the subject heading</para><para>Varianter Name des Schlagworts</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#variantNameForTheSubjectHeading">http://d-nb.info/standards/elementset/gnd#variantNameForTheSubjectHeading</seealso>
    let variantNameForTheSubjectHeading =
        Prefixed_Name(gndo, "variantNameForTheSubjectHeading") |> PrefixedName

    /// <summary>
    ///   <para>gndo:writerOfAddedCommentary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A person or organization responsible for the commentary or explanatory notes about a text. For the writer of manuscript annotations in a printed book, use Annotator</para>
    /// labels<para>Writer of added commentary</para><para>Kommentator (schriftlich)</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#writerOfAddedCommentary">http://d-nb.info/standards/elementset/gnd#writerOfAddedCommentary</seealso>
    let writerOfAddedCommentary =
        Prefixed_Name(gndo, "writerOfAddedCommentary") |> PrefixedName

    /// <summary>
    ///   <para>gndo:Collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Collection</para><para>Sammlung</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#Collection">http://d-nb.info/standards/elementset/gnd#Collection</seealso>
    let Collection = Prefixed_Name(gndo, "Collection") |> PrefixedName

    /// <summary>
    ///   <para>gndo:westernmostLongitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Westlichster Längengrad</para><para>Westernmost longitude</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#westernmostLongitude">http://d-nb.info/standards/elementset/gnd#westernmostLongitude</seealso>
    let westernmostLongitude =
        Prefixed_Name(gndo, "westernmostLongitude") |> PrefixedName

    /// <summary>
    ///   <para>gndo:SubjectHeading</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Subject heading</para><para>Schlagwort</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#SubjectHeading">http://d-nb.info/standards/elementset/gnd#SubjectHeading</seealso>
    let SubjectHeading = Prefixed_Name(gndo, "SubjectHeading") |> PrefixedName

    /// <summary>
    ///   <para>gndo:variantNameForThePerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Variant name for the person</para><para>Varianter Name der Person</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#variantNameForThePerson">http://d-nb.info/standards/elementset/gnd#variantNameForThePerson</seealso>
    let variantNameForThePerson =
        Prefixed_Name(gndo, "variantNameForThePerson") |> PrefixedName

    /// <summary>
    ///   <para>gndo:CollectiveManuscript</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Collective manuscript</para><para>Sammelhandschrift</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#CollectiveManuscript">http://d-nb.info/standards/elementset/gnd#CollectiveManuscript</seealso>
    let CollectiveManuscript =
        Prefixed_Name(gndo, "CollectiveManuscript") |> PrefixedName

    /// <summary>
    ///   <para>gndo:DifferentiatedPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Individualisierte Person</para><para>Differentiated person</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#DifferentiatedPerson">http://d-nb.info/standards/elementset/gnd#DifferentiatedPerson</seealso>
    let DifferentiatedPerson =
        Prefixed_Name(gndo, "DifferentiatedPerson") |> PrefixedName

    /// <summary>
    ///   <para>gndo:PseudonymNameOfThePerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Pseudonym name of the person</para><para>Pseudonym der Person</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#PseudonymNameOfThePerson">http://d-nb.info/standards/elementset/gnd#PseudonymNameOfThePerson</seealso>
    let PseudonymNameOfThePerson =
        Prefixed_Name(gndo, "PseudonymNameOfThePerson") |> PrefixedName

    /// <summary>
    ///   <para>gndo:ReligiousAdministrativeUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Religious administrative unit</para><para>Religiöse Verwaltungseinheit</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#ReligiousAdministrativeUnit">http://d-nb.info/standards/elementset/gnd#ReligiousAdministrativeUnit</seealso>
    let ReligiousAdministrativeUnit =
        Prefixed_Name(gndo, "ReligiousAdministrativeUnit") |> PrefixedName

    /// <summary>
    ///   <para>gndo:SeriesOfConferenceOrEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Kongressfolge oder Veranstaltungsfolge</para><para>Series of conference or event</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#SeriesOfConferenceOrEvent">http://d-nb.info/standards/elementset/gnd#SeriesOfConferenceOrEvent</seealso>
    let SeriesOfConferenceOrEvent =
        Prefixed_Name(gndo, "SeriesOfConferenceOrEvent") |> PrefixedName

    /// <summary>
    ///   <para>gndo:preferredNameForTheSubjectHeading</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>Preferred name for the subject heading</para><para>Bevorzugter Name des Schlagworts</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#preferredNameForTheSubjectHeading">http://d-nb.info/standards/elementset/gnd#preferredNameForTheSubjectHeading</seealso>
    let preferredNameForTheSubjectHeading =
        Prefixed_Name(gndo, "preferredNameForTheSubjectHeading") |> PrefixedName

    /// <summary>
    ///   <para>gndo:printer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A person, family, or organization involved in manufacturing a manifestation of printed text, notated music, etc., from type or plates, such as a book, newspaper, magazine, broadside, score, etc</para>
    /// labels<para>Drucker</para><para>Printer</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#printer">http://d-nb.info/standards/elementset/gnd#printer</seealso>
    let printer = Prefixed_Name(gndo, "printer") |> PrefixedName

    /// <summary>
    ///   <para>gndo:professionOrOccupation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Ein Beruf oder eine Tätigkeit, die von einer Person oder Familie ausgeübt wird.</para>
    ///   <para>A profession or occupation practiced by a person or family</para>
    /// labels<para>Beruf oder Beschäftigung</para><para>Profession or occupation</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#professionOrOccupation">http://d-nb.info/standards/elementset/gnd#professionOrOccupation</seealso>
    let professionOrOccupation =
        Prefixed_Name(gndo, "professionOrOccupation") |> PrefixedName

    /// <summary>
    ///   <para>gndo:pseudonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Verknüpft eine echte Identität einer Person mit einer Identität, unter der eine oder mehrere Personen agieren, z. B. schreiben, komponieren oder Kunstwerke schaffen, aber die nicht der wirkliche Name der Person ist (Pseudonym).</para>
    ///   <para>Links a person's real identity to an identity under which one or more persons act, e. g. write, compose or create art, but that is not the person's real name (i. e. a pseudonym).</para>
    /// labels<para>Pseudonym</para><para>Pseudonym</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#pseudonym">http://d-nb.info/standards/elementset/gnd#pseudonym</seealso>
    let pseudonym = Prefixed_Name(gndo, "pseudonym") |> PrefixedName
    /// <summary>
    ///   <para>gndo:Work</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Work</para><para>Werk</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#Work">http://d-nb.info/standards/elementset/gnd#Work</seealso>
    let Work = Prefixed_Name(gndo, "Work") |> PrefixedName
    /// <summary>
    ///   <para>gndo:CollectivePseudonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Collective pseudonym</para><para>Sammelpseudonym</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#CollectivePseudonym">http://d-nb.info/standards/elementset/gnd#CollectivePseudonym</seealso>
    let CollectivePseudonym = Prefixed_Name(gndo, "CollectivePseudonym") |> PrefixedName
    /// <summary>
    ///   <para>gndo:gndSubjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>GND subject category</para><para>GND-Sachgruppe</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#gndSubjectCategory">http://d-nb.info/standards/elementset/gnd#gndSubjectCategory</seealso>
    let gndSubjectCategory = Prefixed_Name(gndo, "gndSubjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>gndo:hierarchicalSuperior</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Administrative Überordnung</para><para>Hierarchical superior</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#hierarchicalSuperior">http://d-nb.info/standards/elementset/gnd#hierarchicalSuperior</seealso>
    let hierarchicalSuperior =
        Prefixed_Name(gndo, "hierarchicalSuperior") |> PrefixedName

    /// <summary>
    ///   <para>gndo:hierarchicalSuperiorOfTheCorporateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Hierarchical superior of the corporate body</para><para>Administrative Überordnung der Körperschaft</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#hierarchicalSuperiorOfTheCorporateBody">http://d-nb.info/standards/elementset/gnd#hierarchicalSuperiorOfTheCorporateBody</seealso>
    let hierarchicalSuperiorOfTheCorporateBody =
        Prefixed_Name(gndo, "hierarchicalSuperiorOfTheCorporateBody") |> PrefixedName

    /// <summary>
    ///   <para>gndo:relatedDdcWithDegreeOfDeterminacy4</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Die GND-Entität stimmt in seinem Bedeutungsumfang vollständig mit
    ///       dem Bedeutungsumfang des in der DDC-Klassenbenennung hervorgehobenen Themas überein, d.h. es
    ///       weist auch denselben fachlichen Kontext wie die DDC-Klasse auf.</para>
    ///   <para>The connotation scope of the GND entity is identical to the
    ///       connotation scope of the topic emphasized in the DDC class heading.</para>
    /// labels<para>In Beziehung stehende Dewey-Dezimalklassifikation mit
    ///       Determiniertheitsgrad 4</para><para>Related Dewey Decimal Classification with degree of determinacy
    ///       4</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#relatedDdcWithDegreeOfDeterminacy4">http://d-nb.info/standards/elementset/gnd#relatedDdcWithDegreeOfDeterminacy4</seealso>
    let relatedDdcWithDegreeOfDeterminacy4 =
        Prefixed_Name(gndo, "relatedDdcWithDegreeOfDeterminacy4") |> PrefixedName

    /// <summary>
    ///   <para>gndo:relatedFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>In Beziehung stehende Familie</para><para>Related family</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#relatedFamily">http://d-nb.info/standards/elementset/gnd#relatedFamily</seealso>
    let relatedFamily = Prefixed_Name(gndo, "relatedFamily") |> PrefixedName

    /// <summary>
    ///   <para>gndo:relatedPlaceOrGeographicName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>In Beziehung stehendes Geografikum</para><para>Related place or geographic name</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#relatedPlaceOrGeographicName">http://d-nb.info/standards/elementset/gnd#relatedPlaceOrGeographicName</seealso>
    let relatedPlaceOrGeographicName =
        Prefixed_Name(gndo, "relatedPlaceOrGeographicName") |> PrefixedName

    /// <summary>
    ///   <para>gndo:relatedSubjecHeading</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Bitte verwenden sie relatedSubjectHeading (mit 'subject' statt 'subjec')</para>
    ///   <para>Use relatedSubjectHeading ('subject', not 'subjec') instead</para>
    /// labels<para>In Beziehung stehendes Schlagwort</para><para>Related subject heading</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#relatedSubjecHeading">http://d-nb.info/standards/elementset/gnd#relatedSubjecHeading</seealso>
    let relatedSubjecHeading =
        Prefixed_Name(gndo, "relatedSubjecHeading") |> PrefixedName

    /// <summary>
    ///   <para>gndo:relatedSubjectHeading</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>In Beziehung stehendes Schlagwort</para><para>Related subject heading</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#relatedSubjectHeading">http://d-nb.info/standards/elementset/gnd#relatedSubjectHeading</seealso>
    let relatedSubjectHeading =
        Prefixed_Name(gndo, "relatedSubjectHeading") |> PrefixedName

    /// <summary>
    ///   <para>gndo:relatedTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The associative relationship covers associations between pairs of
    ///       concepts that are not related hierarchically, but are semantically or concetually associated
    ///       to such an extent that the link between them needs to be made explicit in the thesaurus. </para>
    ///   <para>Eine Assoziationsrelation ist eine zwischen Begriffen als wichtig
    ///       erscheinende Relation, die weder eindeutig hierarchischer Natur ist, noch als äquivalent
    ///       angesehen werden kann. Bei Personen ist dies z. B. die Beziehung zwischen fiktiven
    /// 	  Gestalten und ihrem realem Vorbild. Hierzu gehören auch Beziehungen zwischen Personen
    /// 	  und z. B. Körperschaften, die im Namen einer Person agieren,
    /// 	  Gesellschaften, die zu Ehren einer Person gegründet wurden und
    /// 	  Körperschaften, die sich mit einer Person und ihrem Werk beschäftigen.</para>
    /// labels<para>Verwandter Begriff</para><para>Related Term</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#relatedTerm">http://d-nb.info/standards/elementset/gnd#relatedTerm</seealso>
    let relatedTerm = Prefixed_Name(gndo, "relatedTerm") |> PrefixedName
    /// <summary>
    ///   <para>gndo:relatedWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>In Beziehung stehendes Werk</para><para>Related work</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#relatedWork">http://d-nb.info/standards/elementset/gnd#relatedWork</seealso>
    let relatedWork = Prefixed_Name(gndo, "relatedWork") |> PrefixedName
    /// <summary>
    ///   <para>gndo:restorer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A person, family, or organization responsible for the set of technical, editorial, and intellectual procedures aimed at compensating for the degradation of an item by bringing it back to a state as close as possible to its original condition</para>
    /// labels<para>Restaurator</para><para>Restorer</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#restorer">http://d-nb.info/standards/elementset/gnd#restorer</seealso>
    let restorer = Prefixed_Name(gndo, "restorer") |> PrefixedName
    /// <summary>
    ///   <para>gndo:revisor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A person or organization who 1) reworks a musical composition, usually for a different medium, or 2) rewrites novels or stories for motion pictures or other audiovisual medium.</para>
    /// labels<para>Bearbeiter</para><para>Revisor</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#revisor">http://d-nb.info/standards/elementset/gnd#revisor</seealso>
    let revisor = Prefixed_Name(gndo, "revisor") |> PrefixedName
    /// <summary>
    ///   <para>gndo:screenwriter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An author of a screenplay, script, or scene</para>
    /// labels<para>Drehbuchautor</para><para>Screenwriter</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#screenwriter">http://d-nb.info/standards/elementset/gnd#screenwriter</seealso>
    let screenwriter = Prefixed_Name(gndo, "screenwriter") |> PrefixedName
    /// <summary>
    ///   <para>gndo:scriptorium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A scriptorium in a monastery</para>
    /// labels<para>Scriptorium</para><para>Skriptorium</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#scriptorium">http://d-nb.info/standards/elementset/gnd#scriptorium</seealso>
    let scriptorium = Prefixed_Name(gndo, "scriptorium") |> PrefixedName
    /// <summary>
    ///   <para>gndo:sculptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An artist responsible for creating a three-dimensional work by modeling, carving, or similar technique</para>
    /// labels<para>Bildhauer</para><para>Sculptor</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#sculptor">http://d-nb.info/standards/elementset/gnd#sculptor</seealso>
    let sculptor = Prefixed_Name(gndo, "sculptor") |> PrefixedName
    /// <summary>
    ///   <para>gndo:singer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A performer contributing to a resource by using his/her/their voice, with or without instrumental accompaniment, to produce music. A singer's performance may or may not include actual words</para>
    /// labels<para>Sänger</para><para>Singer</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#singer">http://d-nb.info/standards/elementset/gnd#singer</seealso>
    let singer = Prefixed_Name(gndo, "singer") |> PrefixedName

    /// <summary>
    ///   <para>gndo:southernmostLatitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Südlichster Breitengrad</para><para>Southernmost latitude</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#southernmostLatitude">http://d-nb.info/standards/elementset/gnd#southernmostLatitude</seealso>
    let southernmostLatitude =
        Prefixed_Name(gndo, "southernmostLatitude") |> PrefixedName

    /// <summary>
    ///   <para>gndo:spatialAreaOfActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Geografischer Wirkungsbereich</para>
    ///   <para>Geographic field of activity</para>
    /// labels<para>Geographischer Wirkungsbereich</para><para>Spatial area of activity</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#spatialAreaOfActivity">http://d-nb.info/standards/elementset/gnd#spatialAreaOfActivity</seealso>
    let spatialAreaOfActivity =
        Prefixed_Name(gndo, "spatialAreaOfActivity") |> PrefixedName

    /// <summary>
    ///   <para>gndo:sponsorOrPatron</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A person, family, or organization sponsoring some aspect of a resource, e.g., funding research, sponsoring an event</para>
    /// labels<para>Sponsor oder Mäzen</para><para>Sponsor or patron</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#sponsorOrPatron">http://d-nb.info/standards/elementset/gnd#sponsorOrPatron</seealso>
    let sponsorOrPatron = Prefixed_Name(gndo, "sponsorOrPatron") |> PrefixedName
    /// <summary>
    ///   <para>gndo:subeditor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A person or organization who writes or develops the framework for an item without being intellectually responsible for its content</para>
    /// labels<para>Redakteur</para><para>Subeditor</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#subeditor">http://d-nb.info/standards/elementset/gnd#subeditor</seealso>
    let subeditor = Prefixed_Name(gndo, "subeditor") |> PrefixedName

    /// <summary>
    ///   <para>gndo:succeedingConferenceOrEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Nachfolgende Konferenz oder Veranstaltung</para><para>Succeeding conference or event</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#succeedingConferenceOrEvent">http://d-nb.info/standards/elementset/gnd#succeedingConferenceOrEvent</seealso>
    let succeedingConferenceOrEvent =
        Prefixed_Name(gndo, "succeedingConferenceOrEvent") |> PrefixedName

    /// <summary>
    ///   <para>gndo:successor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Nachfolger</para><para>Successor</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#successor">http://d-nb.info/standards/elementset/gnd#successor</seealso>
    let successor = Prefixed_Name(gndo, "successor") |> PrefixedName

    /// <summary>
    ///   <para>gndo:succeedingCorporateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Nachfolgende Körperschaft</para><para>Succeeding corporate body</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#succeedingCorporateBody">http://d-nb.info/standards/elementset/gnd#succeedingCorporateBody</seealso>
    let succeedingCorporateBody =
        Prefixed_Name(gndo, "succeedingCorporateBody") |> PrefixedName

    /// <summary>
    ///   <para>gndo:succeedingPlaceOrGeographicName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Succeeding place or geographic name</para><para>Nachfolgendes Geografikum</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#succeedingPlaceOrGeographicName">http://d-nb.info/standards/elementset/gnd#succeedingPlaceOrGeographicName</seealso>
    let succeedingPlaceOrGeographicName =
        Prefixed_Name(gndo, "succeedingPlaceOrGeographicName") |> PrefixedName

    /// <summary>
    ///   <para>gndo:succeedingSubjectHeading</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Succeeding subject heading</para><para>Nachfolgendes Schlagwort</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#succeedingSubjectHeading">http://d-nb.info/standards/elementset/gnd#succeedingSubjectHeading</seealso>
    let succeedingSubjectHeading =
        Prefixed_Name(gndo, "succeedingSubjectHeading") |> PrefixedName

    /// <summary>
    ///   <para>gndo:succeedingWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Nachfolgendes Werk</para><para>Succeeding work</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#succeedingWork">http://d-nb.info/standards/elementset/gnd#succeedingWork</seealso>
    let succeedingWork = Prefixed_Name(gndo, "succeedingWork") |> PrefixedName
    /// <summary>
    ///   <para>gndo:temporaryName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Zeitweiser Name</para><para>Temporary name</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#temporaryName">http://d-nb.info/standards/elementset/gnd#temporaryName</seealso>
    let temporaryName = Prefixed_Name(gndo, "temporaryName") |> PrefixedName

    /// <summary>
    ///   <para>gndo:temporaryNameOfTheConferenceOrEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Zeitweiser Name der Konferenz oder Veranstaltung</para><para>Temporary name of the conference or event</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#temporaryNameOfTheConferenceOrEvent">http://d-nb.info/standards/elementset/gnd#temporaryNameOfTheConferenceOrEvent</seealso>
    let temporaryNameOfTheConferenceOrEvent =
        Prefixed_Name(gndo, "temporaryNameOfTheConferenceOrEvent") |> PrefixedName

    /// <summary>
    ///   <para>gndo:temporaryNameOfTheCorporateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Temporary name of the corporate body</para><para>Zeitweiser Name der Körperschaft</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#temporaryNameOfTheCorporateBody">http://d-nb.info/standards/elementset/gnd#temporaryNameOfTheCorporateBody</seealso>
    let temporaryNameOfTheCorporateBody =
        Prefixed_Name(gndo, "temporaryNameOfTheCorporateBody") |> PrefixedName

    /// <summary>
    ///   <para>gndo:temporaryNameOfThePlaceOrGeographicName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Temporary name of the place or geographic name</para><para>Zeitweiser Name des Geografikums</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#temporaryNameOfThePlaceOrGeographicName">http://d-nb.info/standards/elementset/gnd#temporaryNameOfThePlaceOrGeographicName</seealso>
    let temporaryNameOfThePlaceOrGeographicName =
        Prefixed_Name(gndo, "temporaryNameOfThePlaceOrGeographicName") |> PrefixedName

    /// <summary>
    ///   <para>gndo:thematicIndexNumericDesignationOfMusicalWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Thematic index numeric designation of musical work</para><para>Zählung eines Werksverzeichnisses des Musikwerks</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#thematicIndexNumericDesignationOfMusicalWork">http://d-nb.info/standards/elementset/gnd#thematicIndexNumericDesignationOfMusicalWork</seealso>
    let thematicIndexNumericDesignationOfMusicalWork =
        Prefixed_Name(gndo, "thematicIndexNumericDesignationOfMusicalWork") |> PrefixedName

    /// <summary>
    ///   <para>gndo:titleOfNobility</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A title of nobility held by a person or family.</para>
    ///   <para>Adelstitel einer Person oder einer Familie.</para>
    /// labels<para>Title of nobility</para><para>Adelstitel</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#titleOfNobility">http://d-nb.info/standards/elementset/gnd#titleOfNobility</seealso>
    let titleOfNobility = Prefixed_Name(gndo, "titleOfNobility") |> PrefixedName
    /// <summary>
    ///   <para>gndo:topic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Thema, das mit einer Körperschaft, Konferenz, Person, Familie, Schlagwort oder Werk in Beziehung steht.</para>
    ///   <para>Topic that is related to a corporate body, conference, person, family, subject heading or work.</para>
    /// labels<para>Topic</para><para>Thema</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#topic">http://d-nb.info/standards/elementset/gnd#topic</seealso>
    let topic = Prefixed_Name(gndo, "topic") |> PrefixedName
    /// <summary>
    ///   <para>gndo:translator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A person or organization who renders a text from one language into another, or from an older form of a language into the modern form</para>
    /// labels<para>Übersetzer</para><para>Translator</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#translator">http://d-nb.info/standards/elementset/gnd#translator</seealso>
    let translator = Prefixed_Name(gndo, "translator") |> PrefixedName
    /// <summary>
    ///   <para>gndo:typeOfCoordinates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Type of coordinates</para><para>Koordinatentyp</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#typeOfCoordinates">http://d-nb.info/standards/elementset/gnd#typeOfCoordinates</seealso>
    let typeOfCoordinates = Prefixed_Name(gndo, "typeOfCoordinates") |> PrefixedName
    /// <summary>
    ///   <para>gndo:udkCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Date, expressed as UDK code</para>
    ///   <para>Zeitangabe als UDK-Code</para>
    /// labels<para>UDK-Code</para><para>UDK-Code</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#udkCode">http://d-nb.info/standards/elementset/gnd#udkCode</seealso>
    let udkCode = Prefixed_Name(gndo, "udkCode") |> PrefixedName
    /// <summary>
    ///   <para>gndo:variantName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Varianter Name</para><para>Variant name</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#variantName">http://d-nb.info/standards/elementset/gnd#variantName</seealso>
    let variantName = Prefixed_Name(gndo, "variantName") |> PrefixedName

    /// <summary>
    ///   <para>gndo:variantNameEntityForThePerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Variant name entity for the person</para><para>Variante Namensentität der Person</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#variantNameEntityForThePerson">http://d-nb.info/standards/elementset/gnd#variantNameEntityForThePerson</seealso>
    let variantNameEntityForThePerson =
        Prefixed_Name(gndo, "variantNameEntityForThePerson") |> PrefixedName

    /// <summary>
    ///   <para>gndo:Company</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Company</para><para>Firma</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#Company">http://d-nb.info/standards/elementset/gnd#Company</seealso>
    let Company = Prefixed_Name(gndo, "Company") |> PrefixedName

    /// <summary>
    ///   <para>gndo:variantNameForTheCorporateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Variant name for the corporate body</para><para>Varianter Name der Körperschaft</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#variantNameForTheCorporateBody">http://d-nb.info/standards/elementset/gnd#variantNameForTheCorporateBody</seealso>
    let variantNameForTheCorporateBody =
        Prefixed_Name(gndo, "variantNameForTheCorporateBody") |> PrefixedName

    /// <summary>
    ///   <para>gndo:abbreviatedNameForTheWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Abbreviated name for the work</para><para>Abgekürzter Name des Werks</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#abbreviatedNameForTheWork">http://d-nb.info/standards/elementset/gnd#abbreviatedNameForTheWork</seealso>
    let abbreviatedNameForTheWork =
        Prefixed_Name(gndo, "abbreviatedNameForTheWork") |> PrefixedName

    /// <summary>
    ///   <para>gndo:accordingWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Zugehöriges Werk</para><para>According work</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#accordingWork">http://d-nb.info/standards/elementset/gnd#accordingWork</seealso>
    let accordingWork = Prefixed_Name(gndo, "accordingWork") |> PrefixedName
    /// <summary>
    ///   <para>gndo:copist</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A person or family who is known as scribe or copyist.</para>
    ///   <para>Eine Person oder Familie, die als Kopist oder Schreiber gearbeitet haben</para>
    /// labels<para>Kopist</para><para>Copist</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#copist">http://d-nb.info/standards/elementset/gnd#copist</seealso>
    let copist = Prefixed_Name(gndo, "copist") |> PrefixedName
    /// <summary>
    ///   <para>gndo:inventor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A person, family, or organization responsible for creating a new device or process</para>
    /// labels<para>Erfinder</para><para>Inventor</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#inventor">http://d-nb.info/standards/elementset/gnd#inventor</seealso>
    let inventor = Prefixed_Name(gndo, "inventor") |> PrefixedName

    /// <summary>
    ///   <para>gndo:ProductNameOrBrandName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Product name or brand name</para><para>Produkt oder Markenname</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#ProductNameOrBrandName">http://d-nb.info/standards/elementset/gnd#ProductNameOrBrandName</seealso>
    let ProductNameOrBrandName =
        Prefixed_Name(gndo, "ProductNameOrBrandName") |> PrefixedName

    /// <summary>
    ///   <para>gndo:ProvenanceCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Provenienzmerkmale bezeichnen spuren, die
    /// 	Vorbesitzer (Personen und Institutionen) in und auf Büchern, Handschriften
    /// 	oder anderen Artefakten hinterlassen haben. Diese Merkmale kennzeichnen
    /// 	Besitz, Lesespuren oder Zensurabsichten.</para>
    /// labels<para>Provenance characteristic</para><para>Provenienzmerkmal</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#ProvenanceCharacteristic">http://d-nb.info/standards/elementset/gnd#ProvenanceCharacteristic</seealso>
    let ProvenanceCharacteristic =
        Prefixed_Name(gndo, "ProvenanceCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>gndo:RealNameOfThePerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Der wirkliche Name einer Person</para>
    ///   <para>The person’s real name</para>
    /// labels<para>Wirklicher Name der Person</para><para>Real name of the person</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#RealNameOfThePerson">http://d-nb.info/standards/elementset/gnd#RealNameOfThePerson</seealso>
    let RealNameOfThePerson = Prefixed_Name(gndo, "RealNameOfThePerson") |> PrefixedName

    /// <summary>
    ///   <para>gndo:ReligiousCorporateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Religious corporate body</para><para>Religiöse Körperschaft</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#ReligiousCorporateBody">http://d-nb.info/standards/elementset/gnd#ReligiousCorporateBody</seealso>
    let ReligiousCorporateBody =
        Prefixed_Name(gndo, "ReligiousCorporateBody") |> PrefixedName

    /// <summary>
    ///   <para>gndo:ReligiousTerritory</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Religiöses Territorium</para><para>Religious territory</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#ReligiousTerritory">http://d-nb.info/standards/elementset/gnd#ReligiousTerritory</seealso>
    let ReligiousTerritory = Prefixed_Name(gndo, "ReligiousTerritory") |> PrefixedName

    /// <summary>
    ///   <para>gndo:RoyalOrMemberOfARoyalHouse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Regierender Fürst oder Mitglied eines regierenden
    ///       Fürstenhauses</para><para>Royal or member of a royal house</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#RoyalOrMemberOfARoyalHouse">http://d-nb.info/standards/elementset/gnd#RoyalOrMemberOfARoyalHouse</seealso>
    let RoyalOrMemberOfARoyalHouse =
        Prefixed_Name(gndo, "RoyalOrMemberOfARoyalHouse") |> PrefixedName

    /// <summary>
    ///   <para>gndo:SoftwareProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Software product</para><para>Softwareprodukt</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#SoftwareProduct">http://d-nb.info/standards/elementset/gnd#SoftwareProduct</seealso>
    let SoftwareProduct = Prefixed_Name(gndo, "SoftwareProduct") |> PrefixedName
    /// <summary>
    ///   <para>gndo:Spirits</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Geister</para><para>Spirits</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#Spirits">http://d-nb.info/standards/elementset/gnd#Spirits</seealso>
    let Spirits = Prefixed_Name(gndo, "Spirits") |> PrefixedName

    /// <summary>
    ///   <para>gndo:StartingOrFinalPointOfADistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Bitte verwenden sie startingOrFinalPointOfADistance (mit kleinem s)</para>
    ///   <para>Use startingOrFinalPointOfADistance (with a minor s) instead</para>
    /// labels<para>Starting or final point of a distance</para><para>Beginn und Ende einer Strecke</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#StartingOrFinalPointOfADistance">http://d-nb.info/standards/elementset/gnd#StartingOrFinalPointOfADistance</seealso>
    let StartingOrFinalPointOfADistance =
        Prefixed_Name(gndo, "StartingOrFinalPointOfADistance") |> PrefixedName

    /// <summary>
    ///   <para>gndo:startingOrFinalPointOfADistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Starting or final point of a distance</para><para>Beginn und Ende einer Strecke</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#startingOrFinalPointOfADistance">http://d-nb.info/standards/elementset/gnd#startingOrFinalPointOfADistance</seealso>
    let startingOrFinalPointOfADistance =
        Prefixed_Name(gndo, "startingOrFinalPointOfADistance") |> PrefixedName

    /// <summary>
    ///   <para>gndo:TerritorialCorporateBodyOrAdministrativeUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Territorial corporate body or administrative unit</para><para>Gebietskörperschaft oder Verwaltungseinheit</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#TerritorialCorporateBodyOrAdministrativeUnit">http://d-nb.info/standards/elementset/gnd#TerritorialCorporateBodyOrAdministrativeUnit</seealso>
    let TerritorialCorporateBodyOrAdministrativeUnit =
        Prefixed_Name(gndo, "TerritorialCorporateBodyOrAdministrativeUnit") |> PrefixedName

    /// <summary>
    ///   <para>gndo:CorporateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Corporate Body</para><para>Körperschaft</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#CorporateBody">http://d-nb.info/standards/elementset/gnd#CorporateBody</seealso>
    let CorporateBody = Prefixed_Name(gndo, "CorporateBody") |> PrefixedName

    /// <summary>
    ///   <para>gndo:hierarchicalSuperiorOfPlaceOrGeographicName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A hierarchically superordinate unit (corporate body, conference, jurisdiction) of the described unit (corporate body, conference, jurisdiction).</para>
    ///   <para>Eine hierarchisch übergeordnete Einheit (Gebietskörperschaft, Körperschaft, Konferenz) der beschriebenen Einheit (Gebietskörperschaft, Körperschaft, Konferenz).</para>
    /// labels<para>Hierarchical superior of place or geographic name</para><para>Administrative Überordnung des Geografikums</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#hierarchicalSuperiorOfPlaceOrGeographicName">http://d-nb.info/standards/elementset/gnd#hierarchicalSuperiorOfPlaceOrGeographicName</seealso>
    let hierarchicalSuperiorOfPlaceOrGeographicName =
        Prefixed_Name(gndo, "hierarchicalSuperiorOfPlaceOrGeographicName") |> PrefixedName

    /// <summary>
    ///   <para>gndo:hierarchicalSuperiorOfTheConferenceOrEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Administrative Überordnung der Konferenz oder der
    ///       Veranstaltung</para><para>Hierarchical superior of the conference or event</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#hierarchicalSuperiorOfTheConferenceOrEvent">http://d-nb.info/standards/elementset/gnd#hierarchicalSuperiorOfTheConferenceOrEvent</seealso>
    let hierarchicalSuperiorOfTheConferenceOrEvent =
        Prefixed_Name(gndo, "hierarchicalSuperiorOfTheConferenceOrEvent") |> PrefixedName

    /// <summary>
    ///   <para>gndo:homepage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Homepage</para><para>Homepage</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#homepage">http://d-nb.info/standards/elementset/gnd#homepage</seealso>
    let homepage = Prefixed_Name(gndo, "homepage") |> PrefixedName

    /// <summary>
    ///   <para>gndo:illustratorOrIlluminator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A person, family, or organization contributing to a resource by supplementing the primary content with drawings, diagrams, photographs, etc. If the work is primarily the artistic content created by this entity, use artist or photographer</para>
    /// labels<para>Illustrator oder Illuminator</para><para>Illustrator or illuminator</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#illustratorOrIlluminator">http://d-nb.info/standards/elementset/gnd#illustratorOrIlluminator</seealso>
    let illustratorOrIlluminator =
        Prefixed_Name(gndo, "illustratorOrIlluminator") |> PrefixedName

    /// <summary>
    ///   <para>gndo:ConferenceOrEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Konferenz oder Veranstaltung</para><para>Conference or Event</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#ConferenceOrEvent">http://d-nb.info/standards/elementset/gnd#ConferenceOrEvent</seealso>
    let ConferenceOrEvent = Prefixed_Name(gndo, "ConferenceOrEvent") |> PrefixedName
    /// <summary>
    ///   <para>gndo:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Person</para><para>Person</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#Person">http://d-nb.info/standards/elementset/gnd#Person</seealso>
    let Person = Prefixed_Name(gndo, "Person") |> PrefixedName

    /// <summary>
    ///   <para>gndo:UndifferentiatedPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Nicht-individualisierte Person</para><para>Undifferentiated person</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#UndifferentiatedPerson">http://d-nb.info/standards/elementset/gnd#UndifferentiatedPerson</seealso>
    let UndifferentiatedPerson =
        Prefixed_Name(gndo, "UndifferentiatedPerson") |> PrefixedName

    /// <summary>
    ///   <para>gndo:EarlierNameOfThePerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Der vorliegende abweichende Name ist der frühere Name einer Person,
    /// 		wie beispielsweise der Geburtsname, frühere Ehename usw.</para>
    /// labels<para>Earlier name of the person</para><para>Früherer Name der Person</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#EarlierNameOfThePerson">http://d-nb.info/standards/elementset/gnd#EarlierNameOfThePerson</seealso>
    let EarlierNameOfThePerson =
        Prefixed_Name(gndo, "EarlierNameOfThePerson") |> PrefixedName

    /// <summary>
    ///   <para>gndo:Expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Expression</para><para>Expression</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#Expression">http://d-nb.info/standards/elementset/gnd#Expression</seealso>
    let Expression = Prefixed_Name(gndo, "Expression") |> PrefixedName
    /// <summary>
    ///   <para>gndo:Family</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Familie</para><para>Family</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#Family">http://d-nb.info/standards/elementset/gnd#Family</seealso>
    let Family = Prefixed_Name(gndo, "Family") |> PrefixedName
    /// <summary>
    ///   <para>gndo:FictivePlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Fictive place</para><para>Fiktiver Ort</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#FictivePlace">http://d-nb.info/standards/elementset/gnd#FictivePlace</seealso>
    let FictivePlace = Prefixed_Name(gndo, "FictivePlace") |> PrefixedName
    /// <summary>
    ///   <para>gndo:Fictive_term</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Bitte verwenden Sie FictiveTerm</para>
    ///   <para>Use FictiveTerm instead</para>
    /// labels<para>Fiktiver Sachbegriff</para><para>Fictive term</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#Fictive_term">http://d-nb.info/standards/elementset/gnd#Fictive_term</seealso>
    let Fictive_term = Prefixed_Name(gndo, "Fictive_term") |> PrefixedName
    /// <summary>
    ///   <para>gndo:Gods</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Götter</para><para>Gods</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#Gods">http://d-nb.info/standards/elementset/gnd#Gods</seealso>
    let Gods = Prefixed_Name(gndo, "Gods") |> PrefixedName

    /// <summary>
    ///   <para>gndo:HistoricSingleEventOrEra</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Historisches Einzelereignis oder Epoche</para><para>Historic single event or era</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#HistoricSingleEventOrEra">http://d-nb.info/standards/elementset/gnd#HistoricSingleEventOrEra</seealso>
    let HistoricSingleEventOrEra =
        Prefixed_Name(gndo, "HistoricSingleEventOrEra") |> PrefixedName

    /// <summary>
    ///   <para>gndo:LaterNameOfThePerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Die vorliegende abweichende Namensform ist der spätere Name einer Person, wie der
    /// 		Ehename etc., der nicht als bevorzugter Name gewählt wird.</para>
    /// labels<para>Späterer Name der Person</para><para>Later name of the person</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#LaterNameOfThePerson">http://d-nb.info/standards/elementset/gnd#LaterNameOfThePerson</seealso>
    let LaterNameOfThePerson =
        Prefixed_Name(gndo, "LaterNameOfThePerson") |> PrefixedName

    /// <summary>
    ///   <para>gndo:LiteraryOrLegendaryCharacter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Literary or legendary character</para><para>Literarische oder Sagengestalt</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#LiteraryOrLegendaryCharacter">http://d-nb.info/standards/elementset/gnd#LiteraryOrLegendaryCharacter</seealso>
    let LiteraryOrLegendaryCharacter =
        Prefixed_Name(gndo, "LiteraryOrLegendaryCharacter") |> PrefixedName

    /// <summary>
    ///   <para>gndo:narrowerTermPartitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Eine partitive Relation ist eine hierarchische
    /// 	Relation zwischen zwei Begriffen, von denen der übergeordnete Begriff
    /// 	(Verbandsbegriff) einem Ganzen entspricht und der untergeordnete Begriff
    /// 	einen der Bestandteile dieses Ganzen repräsentiert. Bei Personen ist die
    /// 	Relation die Beziehung zwischen einer einzelnen Person (besonders
    /// 	Gottheiten) und übergeordneten Gruppen von Göttern und mythologische Gestalten.</para>
    ///   <para>The hierarchical whole-part relationship covers a limited range of
    ///       situations in which a part of an entity or system belongs uniquely to a particular possessing
    ///       whole. When applied to persons, this is the relation between a single person (particularly gods)
    /// 	  and hierarchically superior groups of gods and mythologic entities.</para>
    /// labels<para>Narrower term (partitive)</para><para>Unterbegriff partitiv</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#narrowerTermPartitive">http://d-nb.info/standards/elementset/gnd#narrowerTermPartitive</seealso>
    let narrowerTermPartitive =
        Prefixed_Name(gndo, "narrowerTermPartitive") |> PrefixedName

    /// <summary>
    ///   <para>gndo:broaderTermWithMoreThanOneElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Broader term (with more than one element)</para><para>Oberbegriff mehrgliedrig</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#broaderTermWithMoreThanOneElement">http://d-nb.info/standards/elementset/gnd#broaderTermWithMoreThanOneElement</seealso>
    let broaderTermWithMoreThanOneElement =
        Prefixed_Name(gndo, "broaderTermWithMoreThanOneElement") |> PrefixedName

    /// <summary>
    ///   <para>gndo:broderTermGeneral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Use gndo:broaderTermGeneral instead</para>
    ///   <para>Bitte verwenden Sie gndo:broaderTermGeneral</para>
    /// labels<para>Broader term (general)</para><para>Oberbegriff allgemein</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#broderTermGeneral">http://d-nb.info/standards/elementset/gnd#broderTermGeneral</seealso>
    let broderTermGeneral = Prefixed_Name(gndo, "broderTermGeneral") |> PrefixedName
    /// <summary>
    ///   <para>gndo:buildingOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A person, family, or corporate body in charge of financing and constructing a building</para>
    ///   <para>Person, Familie oder Körperschaft, die einen Bau errichten lässt und finanziert.</para>
    /// labels<para>Building owner</para><para>Bauherr</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#buildingOwner">http://d-nb.info/standards/elementset/gnd#buildingOwner</seealso>
    let buildingOwner = Prefixed_Name(gndo, "buildingOwner") |> PrefixedName
    /// <summary>
    ///   <para>gndo:cartographer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A person, family, or organization responsible for creating a map, atlas, globe, or other cartographic work</para>
    /// labels<para>Cartographer</para><para>Kartograf</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#cartographer">http://d-nb.info/standards/elementset/gnd#cartographer</seealso>
    let cartographer = Prefixed_Name(gndo, "cartographer") |> PrefixedName

    /// <summary>
    ///   <para>gndo:celebratedCorporateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Celebrated corporate body</para><para>Gefeierte Körperschaft</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#celebratedCorporateBody">http://d-nb.info/standards/elementset/gnd#celebratedCorporateBody</seealso>
    let celebratedCorporateBody =
        Prefixed_Name(gndo, "celebratedCorporateBody") |> PrefixedName

    /// <summary>
    ///   <para>gndo:celebratedFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Gefeierte Familie</para><para>Celebrated family</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#celebratedFamily">http://d-nb.info/standards/elementset/gnd#celebratedFamily</seealso>
    let celebratedFamily = Prefixed_Name(gndo, "celebratedFamily") |> PrefixedName
    /// <summary>
    ///   <para>gndo:celebratedPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Celebrated person</para><para>Gefeierte Person</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#celebratedPerson">http://d-nb.info/standards/elementset/gnd#celebratedPerson</seealso>
    let celebratedPerson = Prefixed_Name(gndo, "celebratedPerson") |> PrefixedName
    /// <summary>
    ///   <para>gndo:celebratedTopic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Celebrated topic</para><para>Gefeiertes Thema</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#celebratedTopic">http://d-nb.info/standards/elementset/gnd#celebratedTopic</seealso>
    let celebratedTopic = Prefixed_Name(gndo, "celebratedTopic") |> PrefixedName
    /// <summary>
    ///   <para>gndo:characteristicPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A significant place for a person or family</para>
    ///   <para>Ort, der mit einer Familie in Verbindung
    /// 	steht.</para>
    /// labels<para>Charakteristischer Ort</para><para>Characteristic place</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#characteristicPlace">http://d-nb.info/standards/elementset/gnd#characteristicPlace</seealso>
    let characteristicPlace = Prefixed_Name(gndo, "characteristicPlace") |> PrefixedName
    /// <summary>
    ///   <para>gndo:choreographer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A person responsible for creating or contributing to a work of movement</para>
    /// labels<para>Choreographer</para><para>Choreograf</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#choreographer">http://d-nb.info/standards/elementset/gnd#choreographer</seealso>
    let choreographer = Prefixed_Name(gndo, "choreographer") |> PrefixedName
    /// <summary>
    ///   <para>gndo:citedArtist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A person or organization whose work is largely quoted or extracted in works to which he or she did not contribute directly. Such quotations are found particularly in exhibition catalogs, collections of photographs, etc.</para>
    /// labels<para>Zitierter Künstler</para><para>Cited artist</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#citedArtist">http://d-nb.info/standards/elementset/gnd#citedArtist</seealso>
    let citedArtist = Prefixed_Name(gndo, "citedArtist") |> PrefixedName
    /// <summary>
    ///   <para>gndo:citedAuthor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A person or organization whose work is largely quoted or extracted in works to which he or she did not contribute directly. Such quotations are found particularly in exhibition catalogs, collections of photographs, etc.</para>
    /// labels<para>Zitierter Verfasser</para><para>Cited author</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#citedAuthor">http://d-nb.info/standards/elementset/gnd#citedAuthor</seealso>
    let citedAuthor = Prefixed_Name(gndo, "citedAuthor") |> PrefixedName
    /// <summary>
    ///   <para>gndo:citedComposer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A person or organization whose work is largely quoted or extracted in works to which he or she did not contribute directly. Such quotations are found particularly in exhibition catalogs, collections of photographs, etc.</para>
    /// labels<para>Zitierter Komponist</para><para>Cited composer</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#citedComposer">http://d-nb.info/standards/elementset/gnd#citedComposer</seealso>
    let citedComposer = Prefixed_Name(gndo, "citedComposer") |> PrefixedName
    /// <summary>
    ///   <para>gndo:collector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A curator who brings together items from various sources that are then arranged, described, and cataloged as a collection. A collector is neither the creator of the material nor a person to whom manuscripts in the collection may have been addressed</para>
    /// labels<para>Collector</para><para>Sammler</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#collector">http://d-nb.info/standards/elementset/gnd#collector</seealso>
    let collector = Prefixed_Name(gndo, "collector") |> PrefixedName
    /// <summary>
    ///   <para>gndo:compiler</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A person, family, or organization responsible for creating a new work (e.g., a bibliography, a directory) through the act of compilation, e.g., selecting, arranging, aggregating, and editing data, information, etc</para>
    /// labels<para>Kompilator</para><para>Compiler</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#compiler">http://d-nb.info/standards/elementset/gnd#compiler</seealso>
    let compiler = Prefixed_Name(gndo, "compiler") |> PrefixedName

    /// <summary>
    ///   <para>gndo:complexSeeReferenceSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Complex see reference - subject</para><para>Relationierter Deskriptor</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#complexSeeReferenceSubject">http://d-nb.info/standards/elementset/gnd#complexSeeReferenceSubject</seealso>
    let complexSeeReferenceSubject =
        Prefixed_Name(gndo, "complexSeeReferenceSubject") |> PrefixedName

    /// <summary>
    ///   <para>gndo:conferrer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A person or organization permitting the temporary use of a book, manuscript, etc., such as for photocopying or microfilming</para>
    /// labels<para>Leihgeber</para><para>Conferrer</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#conferrer">http://d-nb.info/standards/elementset/gnd#conferrer</seealso>
    let conferrer = Prefixed_Name(gndo, "conferrer") |> PrefixedName
    /// <summary>
    ///   <para>gndo:contributinFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Bitte verwenden sie contributingFamily.</para>
    ///   <para>Use contributingFamily instead.</para>
    /// labels<para>Contributing family</para><para>Beteiligte Familie</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#contributinFamily">http://d-nb.info/standards/elementset/gnd#contributinFamily</seealso>
    let contributinFamily = Prefixed_Name(gndo, "contributinFamily") |> PrefixedName
    /// <summary>
    ///   <para>gndo:contributingFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Contributing family</para><para>Beteiligte Familie</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#contributingFamily">http://d-nb.info/standards/elementset/gnd#contributingFamily</seealso>
    let contributingFamily = Prefixed_Name(gndo, "contributingFamily") |> PrefixedName

    /// <summary>
    ///   <para>gndo:contributingCorporateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Contributing corporate body</para><para>Beteiligte Körperschaft</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#contributingCorporateBody">http://d-nb.info/standards/elementset/gnd#contributingCorporateBody</seealso>
    let contributingCorporateBody =
        Prefixed_Name(gndo, "contributingCorporateBody") |> PrefixedName

    /// <summary>
    ///   <para>gndo:contributingPlaceOrGeographicName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Contributing place or geographic name</para><para>Beteiligtes Geografikum</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#contributingPlaceOrGeographicName">http://d-nb.info/standards/elementset/gnd#contributingPlaceOrGeographicName</seealso>
    let contributingPlaceOrGeographicName =
        Prefixed_Name(gndo, "contributingPlaceOrGeographicName") |> PrefixedName

    /// <summary>
    ///   <para>gndo:coordinates</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Coordinates</para><para>Koordinaten</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#coordinates">http://d-nb.info/standards/elementset/gnd#coordinates</seealso>
    let coordinates = Prefixed_Name(gndo, "coordinates") |> PrefixedName

    /// <summary>
    ///   <para>gndo:corporateBodyIsMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Körperschaft ist Mitglied</para><para>Corporate body is member</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#corporateBodyIsMember">http://d-nb.info/standards/elementset/gnd#corporateBodyIsMember</seealso>
    let corporateBodyIsMember =
        Prefixed_Name(gndo, "corporateBodyIsMember") |> PrefixedName

    /// <summary>
    ///   <para>gndo:member</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Eine Person oder Familie, die Mitglied einer (anderen) Familie ist</para>
    ///   <para>A person or family being a member of (another) family</para>
    /// labels<para>Mitglied</para><para>Member</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#member">http://d-nb.info/standards/elementset/gnd#member</seealso>
    let member_ = Prefixed_Name(gndo, "member") |> PrefixedName
    /// <summary>
    ///   <para>gndo:correspondent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A person or organization who was either the writer or recipient of a letter or other communication</para>
    ///   <para>Person, die zu der im Datensatz beschriebenen
    /// 	Person oder Körperschaft als Korrespondenzpartner in Beziehung steht.</para>
    /// labels<para>Korrespondenzpartner</para><para>Correspondent</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#correspondent">http://d-nb.info/standards/elementset/gnd#correspondent</seealso>
    let correspondent = Prefixed_Name(gndo, "correspondent") |> PrefixedName
    /// <summary>
    ///   <para>gndo:creator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A person or organization performing the work, i.e., the name of a person or organization associated with the intellectual content of the work. This category does not include the publisher or personal affiliation, or sponsor except where it is also the corporate author</para>
    /// labels<para>Urheber</para><para>Creator</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#creator">http://d-nb.info/standards/elementset/gnd#creator</seealso>
    let creator = Prefixed_Name(gndo, "creator") |> PrefixedName
    /// <summary>
    ///   <para>gndo:curator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A person, family, or organization conceiving, aggregating, and/or organizing an exhibition, collection, or other item</para>
    /// labels<para>Kurator</para><para>Curator</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#curator">http://d-nb.info/standards/elementset/gnd#curator</seealso>
    let curator = Prefixed_Name(gndo, "curator") |> PrefixedName
    /// <summary>
    ///   <para>gndo:dateOfBirth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Geburts- und Sterbejahr einer Person oder die Jahre, in denen eine Familie nachweisbar ist</para>
    ///   <para>Date of birth and death of a person, years in which a family has been known to exist</para>
    /// labels<para>Date of birth</para><para>Geburtsdatum</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#dateOfBirth">http://d-nb.info/standards/elementset/gnd#dateOfBirth</seealso>
    let dateOfBirth = Prefixed_Name(gndo, "dateOfBirth") |> PrefixedName
    /// <summary>
    ///   <para>gndo:dateOfBirthAndDeath</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Geburts- und Sterbedatum</para><para>Date of birth and death</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#dateOfBirthAndDeath">http://d-nb.info/standards/elementset/gnd#dateOfBirthAndDeath</seealso>
    let dateOfBirthAndDeath = Prefixed_Name(gndo, "dateOfBirthAndDeath") |> PrefixedName

    /// <summary>
    ///   <para>gndo:dateOfConferenceOrEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Datum einer Konferenz</para>
    ///   <para>Date of a conference</para>
    /// labels<para>Date of conference or event</para><para>Veranstalungsdaten</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#dateOfConferenceOrEvent">http://d-nb.info/standards/elementset/gnd#dateOfConferenceOrEvent</seealso>
    let dateOfConferenceOrEvent =
        Prefixed_Name(gndo, "dateOfConferenceOrEvent") |> PrefixedName

    /// <summary>
    ///   <para>gndo:dateOfDeath</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Date of death</para><para>Sterbedatum</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#dateOfDeath">http://d-nb.info/standards/elementset/gnd#dateOfDeath</seealso>
    let dateOfDeath = Prefixed_Name(gndo, "dateOfDeath") |> PrefixedName
    /// <summary>
    ///   <para>gndo:dateOfDiscovery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Date or year in which an object was found (not to be used in connection with persons, families and corporate bodies)</para>
    ///   <para>Datum oder Jahr, in dem ein Objekt gefunden wurde
    /// (darf nicht bei Personen, Familien und Körperschaften verwendet werden)
    /// </para>
    /// labels<para>Date of discovery</para><para>Fundjahr</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#dateOfDiscovery">http://d-nb.info/standards/elementset/gnd#dateOfDiscovery</seealso>
    let dateOfDiscovery = Prefixed_Name(gndo, "dateOfDiscovery") |> PrefixedName
    /// <summary>
    ///   <para>gndo:dateOfEstablishment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Date of establishment</para><para>Gründungsdatum</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#dateOfEstablishment">http://d-nb.info/standards/elementset/gnd#dateOfEstablishment</seealso>
    let dateOfEstablishment = Prefixed_Name(gndo, "dateOfEstablishment") |> PrefixedName

    /// <summary>
    ///   <para>gndo:dateOfEstablishmentAndTermination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Date of establishment and termination</para><para>Gründungs- und Auflösungsdatum</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#dateOfEstablishmentAndTermination">http://d-nb.info/standards/elementset/gnd#dateOfEstablishmentAndTermination</seealso>
    let dateOfEstablishmentAndTermination =
        Prefixed_Name(gndo, "dateOfEstablishmentAndTermination") |> PrefixedName

    /// <summary>
    ///   <para>gndo:dateOfProduction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Date (year) in which a written historical document was created or a building constructed</para>
    ///   <para>Zeitpunkt (Jahr), in dem ein Schriftdenkmal erstellt oder ein Bauwerk errichtet wurde / Entstehungszeit</para>
    /// labels<para>Date of production</para><para>Erstellungszeit</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#dateOfProduction">http://d-nb.info/standards/elementset/gnd#dateOfProduction</seealso>
    let dateOfProduction = Prefixed_Name(gndo, "dateOfProduction") |> PrefixedName
    /// <summary>
    ///   <para>gndo:dateOfPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Zeitpunkt, zu der die erste Expression eines Werkes veröffentlicht wurde</para>
    ///   <para>Date of publication of the first expression of a work</para>
    /// labels<para>Date of publication</para><para>Erscheinungszeit</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#dateOfPublication">http://d-nb.info/standards/elementset/gnd#dateOfPublication</seealso>
    let dateOfPublication = Prefixed_Name(gndo, "dateOfPublication") |> PrefixedName
    /// <summary>
    ///   <para>gndo:dedicatee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A person, family, or organization to whom a resource is dedicated</para>
    /// labels<para>Widmungsempfänger</para><para>Dedicatee</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#dedicatee">http://d-nb.info/standards/elementset/gnd#dedicatee</seealso>
    let dedicatee = Prefixed_Name(gndo, "dedicatee") |> PrefixedName
    /// <summary>
    ///   <para>gndo:definition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Definition</para><para>Definition</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#definition">http://d-nb.info/standards/elementset/gnd#definition</seealso>
    let definition = Prefixed_Name(gndo, "definition") |> PrefixedName
    /// <summary>
    ///   <para>gndo:designer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A person, family, or organization responsible for creating a design for an object</para>
    /// labels<para>Designer</para><para>Designer</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#designer">http://d-nb.info/standards/elementset/gnd#designer</seealso>
    let designer = Prefixed_Name(gndo, "designer") |> PrefixedName
    /// <summary>
    ///   <para>gndo:director</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A person responsible for the general management and supervision of a filmed performance, a radio or television program, etc.</para>
    /// labels<para>Regisseur</para><para>Director</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#director">http://d-nb.info/standards/elementset/gnd#director</seealso>
    let director = Prefixed_Name(gndo, "director") |> PrefixedName

    /// <summary>
    ///   <para>gndo:directorOfPhotography</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A person in charge of photographing a motion picture, who plans the technical aspets of lighting and photographing of scenes, and often assists the director in the choice of angles, camera setups, and lighting moods. He or she may also supervise the further processing of filmed material up to the completion of the work print. Cinematographer is also referred to as director of photography. Do not confuse with videographer</para>
    /// labels<para>Verantwortlicher Kameramann</para><para>Director of photography</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#directorOfPhotography">http://d-nb.info/standards/elementset/gnd#directorOfPhotography</seealso>
    let directorOfPhotography =
        Prefixed_Name(gndo, "directorOfPhotography") |> PrefixedName

    /// <summary>
    ///   <para>gndo:doubtfulArtist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A person or organization to which authorship has been dubiously or incorrectly ascribed</para>
    /// labels<para>Angezweifelter Künstler</para><para>Doubtful artist</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#doubtfulArtist">http://d-nb.info/standards/elementset/gnd#doubtfulArtist</seealso>
    let doubtfulArtist = Prefixed_Name(gndo, "doubtfulArtist") |> PrefixedName
    /// <summary>
    ///   <para>gndo:doubtfulAuthor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A person or organization to which authorship has been dubiously or incorrectly ascribed</para>
    /// labels<para>Angezweifelter Verfasser</para><para>Doubtful author</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#doubtfulAuthor">http://d-nb.info/standards/elementset/gnd#doubtfulAuthor</seealso>
    let doubtfulAuthor = Prefixed_Name(gndo, "doubtfulAuthor") |> PrefixedName
    /// <summary>
    ///   <para>gndo:doubtfulComposer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A person or organization to which authorship has been dubiously or incorrectly ascribed</para>
    /// labels<para>Angezweifelter Komponist</para><para>Doubtful composer</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#doubtfulComposer">http://d-nb.info/standards/elementset/gnd#doubtfulComposer</seealso>
    let doubtfulComposer = Prefixed_Name(gndo, "doubtfulComposer") |> PrefixedName

    /// <summary>
    ///   <para>gndo:easternmostLongitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Östlichster Längengrad</para><para>Easternmost longitude</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#easternmostLongitude">http://d-nb.info/standards/elementset/gnd#easternmostLongitude</seealso>
    let easternmostLongitude =
        Prefixed_Name(gndo, "easternmostLongitude") |> PrefixedName

    /// <summary>
    ///   <para>gndo:editor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A person, family, or organization contributing to a resource by revising or elucidating the content, e.g., adding an introduction, notes, or other critical matter. An editor may also prepare a resource for production, publication, or distribution. For major revisions, adaptations, etc., that substantially change the nature and content of the original work, resulting in a new work, see author</para>
    /// labels<para>Herausgeber</para><para>Editor</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#editor">http://d-nb.info/standards/elementset/gnd#editor</seealso>
    let editor = Prefixed_Name(gndo, "editor") |> PrefixedName
    /// <summary>
    ///   <para>gndo:endOfPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Ende einer Periode</para><para>End of a period</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#endOfPeriod">http://d-nb.info/standards/elementset/gnd#endOfPeriod</seealso>
    let endOfPeriod = Prefixed_Name(gndo, "endOfPeriod") |> PrefixedName
    /// <summary>
    ///   <para>gndo:engraver</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A person or organization who cuts letters, figures, etc. on a surface, such as a wooden or metal plate used for printing</para>
    /// labels<para>Engraver</para><para>Graveur</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#engraver">http://d-nb.info/standards/elementset/gnd#engraver</seealso>
    let engraver = Prefixed_Name(gndo, "engraver") |> PrefixedName

    /// <summary>
    ///   <para>gndo:epithetGenericNameTitleOrTerritory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Beiname, Gattungsname, Titulatur, Territorium</para><para>Epithet, generic name, title or territory</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#epithetGenericNameTitleOrTerritory">http://d-nb.info/standards/elementset/gnd#epithetGenericNameTitleOrTerritory</seealso>
    let epithetGenericNameTitleOrTerritory =
        Prefixed_Name(gndo, "epithetGenericNameTitleOrTerritory") |> PrefixedName

    /// <summary>
    ///   <para>gndo:etcher</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A person or organization who produces text or images for printing by subjecting metal, glass, or some other surface to acid or the corrosive action of some other substance</para>
    /// labels<para>Radierer</para><para>Etcher</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#etcher">http://d-nb.info/standards/elementset/gnd#etcher</seealso>
    let etcher = Prefixed_Name(gndo, "etcher") |> PrefixedName
    /// <summary>
    ///   <para>gndo:exhibitor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Eine Person, Familie oder Körperschaft, die für eine Ausstellung verantwortlich ist.</para>
    ///   <para>A person, family, or corporate body in charge of an exhibition.</para>
    /// labels<para>Aussteller</para><para>Exhibitor</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#exhibitor">http://d-nb.info/standards/elementset/gnd#exhibitor</seealso>
    let exhibitor = Prefixed_Name(gndo, "exhibitor") |> PrefixedName

    /// <summary>
    ///   <para>gndo:familialRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Person, die zu der beschriebenen Person in
    /// 	familiärer bzw. verwandtschaftlicher Beziehung steht. Für Beziehungen von
    /// 	oder zu Familien wird gndo:memberOfTheFamily verwendet.</para>
    ///   <para>A family relationship between a person or family and another person or family</para>
    /// labels<para>Familial relationship</para><para>Familiäre Beziehung</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#familialRelationship">http://d-nb.info/standards/elementset/gnd#familialRelationship</seealso>
    let familialRelationship =
        Prefixed_Name(gndo, "familialRelationship") |> PrefixedName

    /// <summary>
    ///   <para>gndo:Country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Land oder Staat</para><para>Country</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#Country">http://d-nb.info/standards/elementset/gnd#Country</seealso>
    let Country = Prefixed_Name(gndo, "Country") |> PrefixedName
    /// <summary>
    ///   <para>gndo:composer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A person, family, or organization responsible for creating or contributing to a musical resource by adding music to a work that originally lacked it or supplements it</para>
    /// labels<para>Komponist</para><para>Composer</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#composer">http://d-nb.info/standards/elementset/gnd#composer</seealso>
    let composer = Prefixed_Name(gndo, "composer") |> PrefixedName
    /// <summary>
    ///   <para>gndo:memberOfTheFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Die beschriebene Person (Subjekt) ist ein bedeutendes
    /// 	Mitglied der verknüpften Familie (Objekt). Für Göttergruppen und Gruppen
    /// 	mythologischer Gestalten wird gndo:broaderTermPartitive verwendet.</para>
    /// labels<para>Member of the family</para><para>Familienmitglied</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#memberOfTheFamily">http://d-nb.info/standards/elementset/gnd#memberOfTheFamily</seealso>
    let memberOfTheFamily = Prefixed_Name(gndo, "memberOfTheFamily") |> PrefixedName
    /// <summary>
    ///   <para>gndo:addition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Addition</para><para>Zusatz</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#addition">http://d-nb.info/standards/elementset/gnd#addition</seealso>
    let addition = Prefixed_Name(gndo, "addition") |> PrefixedName
    /// <summary>
    ///   <para>gndo:addressee</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Eine Person, Familie oder Körperschaft, an die eine Korrespondenz adressiert ist.</para>
    ///   <para>A person, family, or organization to whom the correspondence in a work is addressed.</para>
    /// labels<para>Addressee</para><para>Adressat</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#addressee">http://d-nb.info/standards/elementset/gnd#addressee</seealso>
    let addressee = Prefixed_Name(gndo, "addressee") |> PrefixedName
    /// <summary>
    ///   <para>gndo:affiliation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A corporate body associated with a person or group of persons.</para>
    ///   <para>Eine Konferenz oder Veranstaltung, eine Körperschaft oder
    /// 		eine Gebietskörperschaft, zu der eine Person gehört oder der sie durch Anstellung,
    /// 		Mitgliedschaft, kulturelle Identität usw. zugeordnet wird.</para>
    /// labels<para>Affiliation</para><para>Affiliation</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#affiliation">http://d-nb.info/standards/elementset/gnd#affiliation</seealso>
    let affiliation = Prefixed_Name(gndo, "affiliation") |> PrefixedName
    /// <summary>
    ///   <para>gndo:annotator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Eine Person, Familie oder Körperschaft, die handschriftlich
    /// 		Anmerkungen in ein spezifisches Exemplar schreibt.</para>
    ///   <para>A person who makes manuscript annotations on an item.</para>
    /// labels<para>Annotator</para><para>Annotator</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#annotator">http://d-nb.info/standards/elementset/gnd#annotator</seealso>
    let annotator = Prefixed_Name(gndo, "annotator") |> PrefixedName
    /// <summary>
    ///   <para>gndo:arranger</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A person, family, or organization contributing to a musical
    /// 		work by rewriting the composition for a medium of performance different from that
    /// 		for which the work was originally intended, or modifying the work for the same
    /// 		medium of performance, etc., such that the musical substance of the original
    /// 		composition remains essentially unchanged. For extensive modification that effectively
    /// 		results in the creation of a new musical work, see composer.</para>
    ///   <para>Eine Person, eine Familie oder eine Körperschaft, die
    /// 		eine Realisierung eines Musikwerkes umschreibt oder modifiziert.</para>
    /// labels<para>Arrangeur</para><para>Arranger</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#arranger">http://d-nb.info/standards/elementset/gnd#arranger</seealso>
    let arranger = Prefixed_Name(gndo, "arranger") |> PrefixedName
    /// <summary>
    ///   <para>gndo:associatedDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Assoziierte Zeit</para><para>Associated date</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#associatedDate">http://d-nb.info/standards/elementset/gnd#associatedDate</seealso>
    let associatedDate = Prefixed_Name(gndo, "associatedDate") |> PrefixedName
    /// <summary>
    ///   <para>gndo:benefactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Eine Person, Familie oder Körperschaft, die ein Werk, eine Sache oder eine Körperschaft gestiftet hat</para>
    ///   <para>A person, family, or corporate body being the benefactor of a work, a thing, or a corporate body</para>
    /// labels<para>Benefactor</para><para>Stifter</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#benefactor">http://d-nb.info/standards/elementset/gnd#benefactor</seealso>
    let benefactor = Prefixed_Name(gndo, "benefactor") |> PrefixedName

    /// <summary>
    ///   <para>gndo:biographicalOrHistoricalInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Zusammenfassung von wesentlichen biografischen, geschichtlichen oder
    ///       anderen Informationen über die zu beschreibende Entität.</para>
    ///   <para>Summary of the essential biographical, historical, or other
    ///       information about the described entity.</para>
    /// labels<para>Biographical or historical information</para><para>Biografische oder historische Angaben</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#biographicalOrHistoricalInformation">http://d-nb.info/standards/elementset/gnd#biographicalOrHistoricalInformation</seealso>
    let biographicalOrHistoricalInformation =
        Prefixed_Name(gndo, "biographicalOrHistoricalInformation") |> PrefixedName

    /// <summary>
    ///   <para>gndo:superPropertyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>P1 gnd:superPropertyOf P2 states that P2 is a subproperty of P1. The
    ///       gndo:superPropertyOf property is transitive.</para>
    ///   <para>P1 gnd:superPropertyOf P2 sagt aus, dass P2 eine Subproperty von P1
    ///       ist. Die gndo:superPropertyOf-Property ist transitiv.</para>
    /// labels<para>Super-Property von</para><para>Super-property of</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#superPropertyOf">http://d-nb.info/standards/elementset/gnd#superPropertyOf</seealso>
    let superPropertyOf = Prefixed_Name(gndo, "superPropertyOf") |> PrefixedName
    /// <summary>
    ///   <para>gndo:bookbinder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A person who binds an item</para>
    /// labels<para>Buchbinder</para><para>Bookbinder</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#bookbinder">http://d-nb.info/standards/elementset/gnd#bookbinder</seealso>
    let bookbinder = Prefixed_Name(gndo, "bookbinder") |> PrefixedName
    /// <summary>
    ///   <para>gndo:bookdesigner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A person or organization involved in manufacturing a manifestation by being responsible for the entire graphic design of a book, including arrangement of type and illustration, choice of materials, and process used</para>
    /// labels<para>Buchgestalter</para><para>Bookdesigner</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#bookdesigner">http://d-nb.info/standards/elementset/gnd#bookdesigner</seealso>
    let bookdesigner = Prefixed_Name(gndo, "bookdesigner") |> PrefixedName
    /// <summary>
    ///   <para>gndo:broaderTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Bitte verwenden Sie Oberbegriff allgemein</para>
    ///   <para>Use broader term general instead</para>
    /// labels<para>Broader term</para><para>Oberbegriff</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#broaderTerm">http://d-nb.info/standards/elementset/gnd#broaderTerm</seealso>
    let broaderTerm = Prefixed_Name(gndo, "broaderTerm") |> PrefixedName
    /// <summary>
    ///   <para>gndo:broaderTermGeneral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Broader term</para>
    /// labels<para>Broader term (general)</para><para>Oberbegriff allgemein</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#broaderTermGeneral">http://d-nb.info/standards/elementset/gnd#broaderTermGeneral</seealso>
    let broaderTermGeneral = Prefixed_Name(gndo, "broaderTermGeneral") |> PrefixedName
    /// <summary>
    ///   <para>gndo:narrowerTermGeneral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Narrower term (general)</para><para>Unterbegriff allgemein</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#narrowerTermGeneral">http://d-nb.info/standards/elementset/gnd#narrowerTermGeneral</seealso>
    let narrowerTermGeneral = Prefixed_Name(gndo, "narrowerTermGeneral") |> PrefixedName
    /// <summary>
    ///   <para>gndo:broaderTermGeneric</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The generic relation is a semantic relation between two concepts
    ///       where the intension of one of the concepts includes that of the other concepts and at least
    ///       one additional delimiting characteristic is added.</para>
    ///   <para>Eine generische Relation ist eine hierarchische Relation zwischen
    ///       zwei Begriffen, von denen der untergeordnete Begriff alle Merkmale des übergeordneten Begriffs
    ///       besitzt und zusätzlich noch mindestens ein weiteres Merkmal.</para>
    /// labels<para>Broader term (generic)</para><para>Oberbegriff generisch</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#broaderTermGeneric">http://d-nb.info/standards/elementset/gnd#broaderTermGeneric</seealso>
    let broaderTermGeneric = Prefixed_Name(gndo, "broaderTermGeneric") |> PrefixedName
    /// <summary>
    ///   <para>gndo:narrowerTermGeneric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The generic relation is a semantic relation between two concepts
    ///       where the intension of one of the concepts includes that of the other concepts and at least
    ///       one additional delimiting characteristic is added.</para>
    ///   <para>Eine generische Relation ist eine hierarchische Relation zwischen
    ///       zwei Begriffen, von denen der untergeordnete Begriff alle Merkmale des übergeordneten Begriffs
    ///       besitzt und zusätzlich noch mindestens ein weiteres Merkmal.</para>
    /// labels<para>Narrower term (generic)</para><para>Unterbegriff generisch</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#narrowerTermGeneric">http://d-nb.info/standards/elementset/gnd#narrowerTermGeneric</seealso>
    let narrowerTermGeneric = Prefixed_Name(gndo, "narrowerTermGeneric") |> PrefixedName

    /// <summary>
    ///   <para>gndo:broaderTermInstantial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The instance relationship links a general concept such as a class of
    ///       things or events, and an individual instance oft hat class, which is often represented by a
    ///       proper name.</para>
    ///   <para>Die Instanzbeziehung verbindet ein allgemeines Konzept, etwa eine
    ///       Klasse von Dingen oder Ereignissen mit einem individuellen Exemplar dieser Klasse, das oft
    ///       durch einen Eigennamen repräsentiert wird.</para>
    /// labels<para>Broader term (instantial)</para><para>Oberbegriff instantiell</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#broaderTermInstantial">http://d-nb.info/standards/elementset/gnd#broaderTermInstantial</seealso>
    let broaderTermInstantial =
        Prefixed_Name(gndo, "broaderTermInstantial") |> PrefixedName

    /// <summary>
    ///   <para>gndo:narrowerTermInstantial</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Die Instanzbeziehung verbindet ein allgemeines Konzept, etwa eine
    ///       Klasse von Dingen oder Ereignissen mit einem individuellen Exemplar dieser Klasse, das oft
    ///       durch einen Eigennamen repräsentiert wird.</para>
    ///   <para>The instance relationship links a general concept such as a class of
    ///       things or events, and an individual instance oft hat class, which is often represented by a
    ///       proper name.</para>
    /// labels<para>Narrower term (instantial)</para><para>Unterbegriff instantiell</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#narrowerTermInstantial">http://d-nb.info/standards/elementset/gnd#narrowerTermInstantial</seealso>
    let narrowerTermInstantial =
        Prefixed_Name(gndo, "narrowerTermInstantial") |> PrefixedName

    /// <summary>
    ///   <para>gndo:broaderTermPartitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Eine partitive Relation ist eine hierarchische
    /// 	Relation zwischen zwei Begriffen, von denen der übergeordnete Begriff
    /// 	(Verbandsbegriff) einem Ganzen entspricht  und der untergeordnete Begriff
    /// 	einen der Bestandteile dieses Ganzen repräsentiert. Bei Personen ist die
    /// 	Relation die Beziehung zwischen einer einzelnen Person (besonders
    /// 	Gottheiten) und übergeordneten Gruppen von Göttern und mythologische Gestalten.</para>
    ///   <para>The hierarchical whole-part relationship covers a limited range of
    ///       situations in which a part of an entity or system belongs uniquely to a particular possessing
    ///       whole. When applied to persons, this is the relation between a single person (particularly gods)
    /// 	  and hierarchically broader groups of gods and mythologic entities.</para>
    /// labels<para>Broader term (partitive)</para><para>Oberbegriff partitiv</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#broaderTermPartitive">http://d-nb.info/standards/elementset/gnd#broaderTermPartitive</seealso>
    let broaderTermPartitive =
        Prefixed_Name(gndo, "broaderTermPartitive") |> PrefixedName

    /// <summary>
    ///   <para>gndo:periodOfActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Exaktes Wirkungsdatum einer Person</para>
    ///   <para>A person’s known period of activity</para>
    /// labels<para>Period of activity</para><para>Wirkungsdaten</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#periodOfActivity">http://d-nb.info/standards/elementset/gnd#periodOfActivity</seealso>
    let periodOfActivity = Prefixed_Name(gndo, "periodOfActivity") |> PrefixedName
    /// <summary>
    ///   <para>gndo:personalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Persönlicher Name</para><para>Personal name</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#personalName">http://d-nb.info/standards/elementset/gnd#personalName</seealso>
    let personalName = Prefixed_Name(gndo, "personalName") |> PrefixedName
    /// <summary>
    ///   <para>gndo:photographer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A person, family, or organization responsible for creating a photographic work</para>
    /// labels<para>Photographer</para><para>Fotograf</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#photographer">http://d-nb.info/standards/elementset/gnd#photographer</seealso>
    let photographer = Prefixed_Name(gndo, "photographer") |> PrefixedName
    /// <summary>
    ///   <para>gndo:place</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Ein Land, ein Staat, eine Provinz usw. oder ein Ort, an dem/der eine Organisation ihren Hauptsitz hat. </para>
    ///   <para>A country, state, province, etc., or place where an organization has its headquarters</para>
    /// labels<para>Place</para><para>Ort</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#place">http://d-nb.info/standards/elementset/gnd#place</seealso>
    let place = Prefixed_Name(gndo, "place") |> PrefixedName
    /// <summary>
    ///   <para>gndo:placeOfActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A person’s or family’s place of activity</para>
    ///   <para>Wirkungsort bzw. Wohnort einer Person.</para>
    /// labels<para>Place of activity</para><para>Wirkungsort</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#placeOfActivity">http://d-nb.info/standards/elementset/gnd#placeOfActivity</seealso>
    let placeOfActivity = Prefixed_Name(gndo, "placeOfActivity") |> PrefixedName
    /// <summary>
    ///   <para>gndo:placeOfBirth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Geburtsort einer Person.</para>
    ///   <para>A person’s place of birth</para>
    /// labels<para>Place of Birth</para><para>Geburtsort</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#placeOfBirth">http://d-nb.info/standards/elementset/gnd#placeOfBirth</seealso>
    let placeOfBirth = Prefixed_Name(gndo, "placeOfBirth") |> PrefixedName

    /// <summary>
    ///   <para>gndo:placeOfBirthAsLiteral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Diese Property ist äquivalent zu gndo:placeOfBirth, zeigt aber ein Literal
    /// 		statt einer Referenz zu einer geografischen Entität</para>
    ///   <para>This property is equivalent to gndo:placeOfBirth but gives a literal instead of
    /// 		a reference to a geographic entity</para>
    /// labels<para>Place of Birth (Literal)</para><para>Geburtsort (Literal)</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#placeOfBirthAsLiteral">http://d-nb.info/standards/elementset/gnd#placeOfBirthAsLiteral</seealso>
    let placeOfBirthAsLiteral =
        Prefixed_Name(gndo, "placeOfBirthAsLiteral") |> PrefixedName

    /// <summary>
    ///   <para>gndo:placeOfBusiness</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Place of business</para><para>Sitz</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#placeOfBusiness">http://d-nb.info/standards/elementset/gnd#placeOfBusiness</seealso>
    let placeOfBusiness = Prefixed_Name(gndo, "placeOfBusiness") |> PrefixedName

    /// <summary>
    ///   <para>gndo:placeOfConferenceOrEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Ort, an dem eine Veranstaltung oder eine Konferenz stattfindet</para>
    ///   <para>A place where an event such as a conference or a concert took place</para>
    /// labels<para>Place of conference or event</para><para>Veranstaltungsort</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#placeOfConferenceOrEvent">http://d-nb.info/standards/elementset/gnd#placeOfConferenceOrEvent</seealso>
    let placeOfConferenceOrEvent =
        Prefixed_Name(gndo, "placeOfConferenceOrEvent") |> PrefixedName

    /// <summary>
    ///   <para>gndo:placeOfCustody</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A place where something is kept</para>
    ///   <para>Der Aufbewahrungsort eines Werkes</para>
    /// labels<para>Place of custody</para><para>Aufbewahrungsort</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#placeOfCustody">http://d-nb.info/standards/elementset/gnd#placeOfCustody</seealso>
    let placeOfCustody = Prefixed_Name(gndo, "placeOfCustody") |> PrefixedName
    /// <summary>
    ///   <para>gndo:placeOfDeath</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A person’s place of death</para>
    ///   <para>Sterbeort einer Person.</para>
    /// labels<para>Place of death</para><para>Sterbeort</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#placeOfDeath">http://d-nb.info/standards/elementset/gnd#placeOfDeath</seealso>
    let placeOfDeath = Prefixed_Name(gndo, "placeOfDeath") |> PrefixedName

    /// <summary>
    ///   <para>gndo:placeOfDeathAsLiteral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Diese Property ist äquivalent zu gndo:placeOfDeath, zeigt aber ein Literal
    /// 		statt einer Referenz zu einer geografischen Entität</para>
    ///   <para>This property is equivalent to gndo:placeOfDeath but gives a literal instead of
    /// 		a reference to a geographic entity</para>
    /// labels<para>Place of death (Literal)</para><para>Sterbeort (Literal)</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#placeOfDeathAsLiteral">http://d-nb.info/standards/elementset/gnd#placeOfDeathAsLiteral</seealso>
    let placeOfDeathAsLiteral =
        Prefixed_Name(gndo, "placeOfDeathAsLiteral") |> PrefixedName

    /// <summary>
    ///   <para>gndo:placeOfDiscovery</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A place where a work or thing was found</para>
    ///   <para>Der Fundort eines Werks</para>
    /// labels<para>Place of discovery</para><para>Fundort</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#placeOfDiscovery">http://d-nb.info/standards/elementset/gnd#placeOfDiscovery</seealso>
    let placeOfDiscovery = Prefixed_Name(gndo, "placeOfDiscovery") |> PrefixedName
    /// <summary>
    ///   <para>gndo:placeOfExile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A place where a person or family dwelt in exile (lived in exile)</para>
    ///   <para>Ortschaft, Stadt, Provinz, Staat und/oder Land,
    /// 	in der/dem eine Person oder Familie im Exil lebt(e).</para>
    /// labels<para>Place of Exile</para><para>Exilort</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#placeOfExile">http://d-nb.info/standards/elementset/gnd#placeOfExile</seealso>
    let placeOfExile = Prefixed_Name(gndo, "placeOfExile") |> PrefixedName
    /// <summary>
    ///   <para>gndo:placeOfManufacture</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A place where a work or thing was manufactured</para>
    ///   <para>Herstellungsort einer Sache oder eines Werks</para>
    /// labels<para>Place of manufacture</para><para>Herstellungsort</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#placeOfManufacture">http://d-nb.info/standards/elementset/gnd#placeOfManufacture</seealso>
    let placeOfManufacture = Prefixed_Name(gndo, "placeOfManufacture") |> PrefixedName

    /// <summary>
    ///   <para>gndo:placeOrGeographicNameIsMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Place or geographic name is member</para><para>Geografikum ist Mitglied</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#placeOrGeographicNameIsMember">http://d-nb.info/standards/elementset/gnd#placeOrGeographicNameIsMember</seealso>
    let placeOrGeographicNameIsMember =
        Prefixed_Name(gndo, "placeOrGeographicNameIsMember") |> PrefixedName

    /// <summary>
    ///   <para>gndo:playedInstrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Gespieltes Instrument</para><para>Played instrument</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#playedInstrument">http://d-nb.info/standards/elementset/gnd#playedInstrument</seealso>
    let playedInstrument = Prefixed_Name(gndo, "playedInstrument") |> PrefixedName
    /// <summary>
    ///   <para>gndo:poet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>An author of the words of a non-dramatic musical work (e.g. the text of a song), except for oratorios</para>
    /// labels<para>Dichter</para><para>Poet</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#poet">http://d-nb.info/standards/elementset/gnd#poet</seealso>
    let poet = Prefixed_Name(gndo, "poet") |> PrefixedName

    /// <summary>
    ///   <para>gndo:precedingConferenceOrEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Vorherige Konferenz oder Veranstaltung</para><para>Preceding conference or event</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#precedingConferenceOrEvent">http://d-nb.info/standards/elementset/gnd#precedingConferenceOrEvent</seealso>
    let precedingConferenceOrEvent =
        Prefixed_Name(gndo, "precedingConferenceOrEvent") |> PrefixedName

    /// <summary>
    ///   <para>gndo:predecessor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A corporate body or a work being the predecessor of another corporate body or work</para>
    ///   <para>Eine Körperschaft oder ein Werk, das der Vorgänger einer anderen Körperschaft oder eines anderen Werks ist</para>
    /// labels<para>Predecessor</para><para>Vorgänger</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#predecessor">http://d-nb.info/standards/elementset/gnd#predecessor</seealso>
    let predecessor = Prefixed_Name(gndo, "predecessor") |> PrefixedName

    /// <summary>
    ///   <para>gndo:abbreviatedNameForThePlaceOrGeographicName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Abbreviated name for the place or geographic name</para><para>Abgekürzter Name des Geografikum</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#abbreviatedNameForThePlaceOrGeographicName">http://d-nb.info/standards/elementset/gnd#abbreviatedNameForThePlaceOrGeographicName</seealso>
    let abbreviatedNameForThePlaceOrGeographicName =
        Prefixed_Name(gndo, "abbreviatedNameForThePlaceOrGeographicName") |> PrefixedName

    /// <summary>
    ///   <para>gndo:accreditedArtist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>An author, artist, etc., relating him/her to a resource for which there is or once was substantial authority for designating that person as author, creator, etc. of the work</para>
    /// labels<para>Zugeschriebener Künstler</para><para>Accredited artist</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#accreditedArtist">http://d-nb.info/standards/elementset/gnd#accreditedArtist</seealso>
    let accreditedArtist = Prefixed_Name(gndo, "accreditedArtist") |> PrefixedName
    /// <summary>
    ///   <para>gndo:artist</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Künstler</para><para>Artist</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#artist">http://d-nb.info/standards/elementset/gnd#artist</seealso>
    let artist = Prefixed_Name(gndo, "artist") |> PrefixedName
    /// <summary>
    ///   <para>gndo:accreditedAuthor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>An author, artist, etc., relating him/her to a resource for which there is or once was substantial authority for designating that person as author, creator, etc. of the work</para>
    /// labels<para>Zugeschriebener Verfasser</para><para>Accredited author</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#accreditedAuthor">http://d-nb.info/standards/elementset/gnd#accreditedAuthor</seealso>
    let accreditedAuthor = Prefixed_Name(gndo, "accreditedAuthor") |> PrefixedName
    /// <summary>
    ///   <para>gndo:author</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A person, family, or organization responsible for creating a work that is primarily textual in content, regardless of media type (e.g., printed text, spoken word, electronic text, tactile text) or genre (e.g., poems, novels, screenplays, blogs). Use also for persons, etc., creating a new work by paraphrasing, rewriting, or adapting works by another creator such that the modification has substantially changed the nature and content of the original or changed the medium of expression</para>
    /// labels<para>Verfasser</para><para>Author</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#author">http://d-nb.info/standards/elementset/gnd#author</seealso>
    let author = Prefixed_Name(gndo, "author") |> PrefixedName
    /// <summary>
    ///   <para>gndo:accreditedComposer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An author, artist, etc., relating him/her to a resource for which there is or once was substantial authority for designating that person as author, creator, etc. of the work</para>
    /// labels<para>Zugeschriebener Komponist</para><para>Accredited composer</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#accreditedComposer">http://d-nb.info/standards/elementset/gnd#accreditedComposer</seealso>
    let accreditedComposer = Prefixed_Name(gndo, "accreditedComposer") |> PrefixedName
    /// <summary>
    ///   <para>gndo:counting</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Counting</para><para>Zählung</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#counting">http://d-nb.info/standards/elementset/gnd#counting</seealso>
    let counting = Prefixed_Name(gndo, "counting") |> PrefixedName
    /// <summary>
    ///   <para>gndo:contributingPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Contributing person</para><para>Beteiligte Person</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#contributingPerson">http://d-nb.info/standards/elementset/gnd#contributingPerson</seealso>
    let contributingPerson = Prefixed_Name(gndo, "contributingPerson") |> PrefixedName
    /// <summary>
    ///   <para>gndo:EthnographicName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Ethnographic name</para><para>Ethnografikum</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#EthnographicName">http://d-nb.info/standards/elementset/gnd#EthnographicName</seealso>
    let EthnographicName = Prefixed_Name(gndo, "EthnographicName") |> PrefixedName

    /// <summary>
    ///   <para>gndo:ExtraterrestrialTerritory</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Extraterrestrial territory</para><para>Extraterrestrikum</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#ExtraterrestrialTerritory">http://d-nb.info/standards/elementset/gnd#ExtraterrestrialTerritory</seealso>
    let ExtraterrestrialTerritory =
        Prefixed_Name(gndo, "ExtraterrestrialTerritory") |> PrefixedName

    /// <summary>
    ///   <para>gndo:affiliationAsLiteral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A corporate body associated with a person or group of persons.
    /// 		This property is equivalent to gndo:affiliation but gives a literal instead of
    /// 		a URI.</para>
    ///   <para>Eine Konferenz oder Veranstaltung, eine Körperschaft oder eine
    /// 		Gebietskörperschaft, zu der eine Person gehört oder der sie durch Anstellung, Mitgliedschaft,
    /// 		kulturelle Identität usw. zugeordnet wird. Diese Property ist äquivalent zu gndo:affiliation,
    /// 		zeigt aber ein Literal statt eines URIs.</para>
    /// labels<para>Affiliation (Literal)</para><para>Affiliation (Literal)</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#affiliationAsLiteral">http://d-nb.info/standards/elementset/gnd#affiliationAsLiteral</seealso>
    let affiliationAsLiteral =
        Prefixed_Name(gndo, "affiliationAsLiteral") |> PrefixedName

    /// <summary>
    ///   <para>gndo:architect</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Eine Person, Familie oder Körperschaft, die für eine architektonische
    /// 		Gestaltung verantwortlich ist, einschließlich einer bildlichen Darstellung, die zeigt, wie ein
    /// 		Gebäude o. ä. aussieht, wenn es fertig gebaut sein wird.</para>
    ///   <para>A person, family, or organization responsible for creating an
    /// 		architectural design, including a pictorial representation intended to show how a building,
    /// 		etc., will look when completed. It also oversees the construction of structures.</para>
    /// labels<para>Architekt</para><para>Architect</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#architect">http://d-nb.info/standards/elementset/gnd#architect</seealso>
    let architect = Prefixed_Name(gndo, "architect") |> PrefixedName
    /// <summary>
    ///   <para>gndo:dateOfTermination</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Date of termination</para><para>Auflösungsdatum</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#dateOfTermination">http://d-nb.info/standards/elementset/gnd#dateOfTermination</seealso>
    let dateOfTermination = Prefixed_Name(gndo, "dateOfTermination") |> PrefixedName

    /// <summary>
    ///   <para>gndo:serialNumericDesignationOfMusicalWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Serial numeric designation of musical work</para><para>Fortlaufende Zählung des Musikwerks</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#serialNumericDesignationOfMusicalWork">http://d-nb.info/standards/elementset/gnd#serialNumericDesignationOfMusicalWork</seealso>
    let serialNumericDesignationOfMusicalWork =
        Prefixed_Name(gndo, "serialNumericDesignationOfMusicalWork") |> PrefixedName

    /// <summary>
    ///   <para>gndo:FictiveCorporateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Fictive corporate body</para><para>Fiktive Körperschaft</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#FictiveCorporateBody">http://d-nb.info/standards/elementset/gnd#FictiveCorporateBody</seealso>
    let FictiveCorporateBody =
        Prefixed_Name(gndo, "FictiveCorporateBody") |> PrefixedName

    /// <summary>
    ///   <para>gndo:FictiveTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Fiktiver Sachbegriff</para><para>Fictive term</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#FictiveTerm">http://d-nb.info/standards/elementset/gnd#FictiveTerm</seealso>
    let FictiveTerm = Prefixed_Name(gndo, "FictiveTerm") |> PrefixedName

    /// <summary>
    ///   <para>gndo:FullerFormOfNameOfThePerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Die vorliegende abweichende Namensform ist die vollständig aufgelöste Form des
    /// 		bevorzugten Namens, der abgekürzte Formen enthält.</para>
    ///   <para>The complete or a fuller form of name of a person, family or corporate body</para>
    /// labels<para>Fuller form of the name of the person</para><para>Vollständiger Name der Person</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#FullerFormOfNameOfThePerson">http://d-nb.info/standards/elementset/gnd#FullerFormOfNameOfThePerson</seealso>
    let FullerFormOfNameOfThePerson =
        Prefixed_Name(gndo, "FullerFormOfNameOfThePerson") |> PrefixedName

    /// <summary>
    ///   <para>gndo:opusNumericDesignationOfMusicalWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Opus numeric designation of musical work</para><para>Opus-Zählung des Musikwerks</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#opusNumericDesignationOfMusicalWork">http://d-nb.info/standards/elementset/gnd#opusNumericDesignationOfMusicalWork</seealso>
    let opusNumericDesignationOfMusicalWork =
        Prefixed_Name(gndo, "opusNumericDesignationOfMusicalWork") |> PrefixedName

    /// <summary>
    ///   <para>gndo:otherPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Weiterer Ort</para><para>Other place</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#otherPlace">http://d-nb.info/standards/elementset/gnd#otherPlace</seealso>
    let otherPlace = Prefixed_Name(gndo, "otherPlace") |> PrefixedName
    /// <summary>
    ///   <para>gndo:painter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A person or family who paints</para>
    ///   <para>Eine Person oder Familie, die malt</para>
    /// labels<para>Painter</para><para>Maler</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#painter">http://d-nb.info/standards/elementset/gnd#painter</seealso>
    let painter = Prefixed_Name(gndo, "painter") |> PrefixedName

    /// <summary>
    ///   <para>gndo:titleOfNobilityAsLiteral</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Adelstitel einer Person oder Adelstitel im Erbtitel
    /// 		einer Familie. Diese Property ist äquivalent zu gndo:titleOfNobility, zeigt
    /// 		aber ein Literal statt einer Referenz zu einem Schlagwort.</para>
    ///   <para>A title of nobility held by a person or family.
    /// 		This property is equivalent to gndo:titleOfNobility
    /// 		but gives a literal instead of a reference to a subject heading.</para>
    /// labels<para>Title of nobility (Literal)</para><para>Adelstitel (Literal)</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#titleOfNobilityAsLiteral">http://d-nb.info/standards/elementset/gnd#titleOfNobilityAsLiteral</seealso>
    let titleOfNobilityAsLiteral =
        Prefixed_Name(gndo, "titleOfNobilityAsLiteral") |> PrefixedName

    /// <summary>
    ///   <para>gndo:associatedPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Assoziierter Ort</para><para>Associated place</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#associatedPlace">http://d-nb.info/standards/elementset/gnd#associatedPlace</seealso>
    let associatedPlace = Prefixed_Name(gndo, "associatedPlace") |> PrefixedName
    /// <summary>
    ///   <para>gndo:beginningOfPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Beginning of a period</para><para>Begin einer Periode</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#beginningOfPeriod">http://d-nb.info/standards/elementset/gnd#beginningOfPeriod</seealso>
    let beginningOfPeriod = Prefixed_Name(gndo, "beginningOfPeriod") |> PrefixedName
    /// <summary>
    ///   <para>gndo:GroupOfPersons</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Group of persons</para><para>Personengruppe</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#GroupOfPersons">http://d-nb.info/standards/elementset/gnd#GroupOfPersons</seealso>
    let GroupOfPersons = Prefixed_Name(gndo, "GroupOfPersons") |> PrefixedName
    /// <summary>
    ///   <para>gndo:Language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Language</para><para>Sprache</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#Language">http://d-nb.info/standards/elementset/gnd#Language</seealso>
    let Language = Prefixed_Name(gndo, "Language") |> PrefixedName
    /// <summary>
    ///   <para>gndo:fictitiousAuthor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Eine fiktive Person, Familie oder Körperschaft, die als Autor gilt.</para>
    ///   <para>A fictitious person, family, or corporate body ascertained to be the author</para>
    /// labels<para>Fiktiver Verfasser</para><para>Fictitious author</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#fictitiousAuthor">http://d-nb.info/standards/elementset/gnd#fictitiousAuthor</seealso>
    let fictitiousAuthor = Prefixed_Name(gndo, "fictitiousAuthor") |> PrefixedName
    /// <summary>
    ///   <para>gndo:fieldOfActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Beschäftigungsfeld/Wissensgebiet mit dem sich eine Person, Körperschaft, Konferenz oder Veranstaltung beschäftigt oder beschäftigt hat.</para>
    ///   <para>Field of activity of a person, corporate body, conference or event.</para>
    /// labels<para>Field of activity</para><para>Tätigkeitsbereich</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#fieldOfActivity">http://d-nb.info/standards/elementset/gnd#fieldOfActivity</seealso>
    let fieldOfActivity = Prefixed_Name(gndo, "fieldOfActivity") |> PrefixedName
    /// <summary>
    ///   <para>gndo:fieldOfStudy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Studienfach einer Person.</para>
    ///   <para>A person’s field of study</para>
    /// labels<para>Field of study</para><para>Studienfach</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#fieldOfStudy">http://d-nb.info/standards/elementset/gnd#fieldOfStudy</seealso>
    let fieldOfStudy = Prefixed_Name(gndo, "fieldOfStudy") |> PrefixedName
    /// <summary>
    ///   <para>gndo:firstAuthor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>A person or organization that takes primary responsibility for a
    /// 		particular activity or endeavor. May be combined with another relator term or code to
    /// 		show the greater importance this person or organization has regarding that particular role.
    /// 		If more than one relator is assigned to a heading, use the Lead relator only if it applies
    /// 		to all the relators.</para><para>Eine Person, Familie oder Körperschaft, die als der einzige
    /// 		oder der erste Autor einer Publikation bekannt ist.</para><para>Erste Verfasserschaft</para><para>First author</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#firstAuthor">http://d-nb.info/standards/elementset/gnd#firstAuthor</seealso>
    let firstAuthor = Prefixed_Name(gndo, "firstAuthor") |> PrefixedName
    /// <summary>
    ///   <para>gndo:organizerOrHost</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A person, family, or organization organizing the exhibit, event, conference, etc., which gave rise to a resource</para>
    /// labels<para>Veranstalter oder Gastgeber</para><para>Organizer or host</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#organizerOrHost">http://d-nb.info/standards/elementset/gnd#organizerOrHost</seealso>
    let organizerOrHost = Prefixed_Name(gndo, "organizerOrHost") |> PrefixedName
    /// <summary>
    ///   <para>gndo:surname</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Nachname</para><para>Surname</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#surname">http://d-nb.info/standards/elementset/gnd#surname</seealso>
    let surname = Prefixed_Name(gndo, "surname") |> PrefixedName
    /// <summary>
    ///   <para>gndo:firstArtist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A person or organization that takes primary responsibility for a particular activity or endeavor. May be combined with another relator term or code to show the greater importance this person or organization has regarding that particular role. If more than one relator is assigned to a heading, use the Lead relator only if it applies to all the relators</para>
    ///   <para>Eine Person, Familie oder Körperschaft, die als einziger oder erster Künstler bekannt ist</para>
    /// labels<para>Erster Künstler</para><para>First artist</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#firstArtist">http://d-nb.info/standards/elementset/gnd#firstArtist</seealso>
    let firstArtist = Prefixed_Name(gndo, "firstArtist") |> PrefixedName
    /// <summary>
    ///   <para>gndo:Manuscript</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Schriftdenkmal</para><para>Manuscript</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#Manuscript">http://d-nb.info/standards/elementset/gnd#Manuscript</seealso>
    let Manuscript = Prefixed_Name(gndo, "Manuscript") |> PrefixedName

    /// <summary>
    ///   <para>gndo:variantNameForTheFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>Variant name for the family</para><para>Varianter Name der Familie</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#variantNameForTheFamily">http://d-nb.info/standards/elementset/gnd#variantNameForTheFamily</seealso>
    let variantNameForTheFamily =
        Prefixed_Name(gndo, "variantNameForTheFamily") |> PrefixedName

    /// <summary>
    ///   <para>gndo:MemberState</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Member state</para><para>Gliedstaat</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#MemberState">http://d-nb.info/standards/elementset/gnd#MemberState</seealso>
    let MemberState = Prefixed_Name(gndo, "MemberState") |> PrefixedName

    /// <summary>
    ///   <para>gndo:MusicalCorporateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Musikalische Körperschaft</para><para>Musical corporate body</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#MusicalCorporateBody">http://d-nb.info/standards/elementset/gnd#MusicalCorporateBody</seealso>
    let MusicalCorporateBody =
        Prefixed_Name(gndo, "MusicalCorporateBody") |> PrefixedName

    /// <summary>
    ///   <para>gndo:MusicalWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Werk der Musik</para><para>Musical work</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#MusicalWork">http://d-nb.info/standards/elementset/gnd#MusicalWork</seealso>
    let MusicalWork = Prefixed_Name(gndo, "MusicalWork") |> PrefixedName
    /// <summary>
    ///   <para>gndo:NameOfThePerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Name of the person</para><para>Personenname</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#NameOfThePerson">http://d-nb.info/standards/elementset/gnd#NameOfThePerson</seealso>
    let NameOfThePerson = Prefixed_Name(gndo, "NameOfThePerson") |> PrefixedName
    /// <summary>
    ///   <para>gndo:founder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A person, family, or corporate body being a founder of an enterprise, an event, or an ensemble of buildings</para>
    ///   <para>Eine Person, Familie oder Körperschaft, die ein Unternehmen oder Veranstaltung oder Bauensemble gründet</para>
    /// labels<para>Gründer</para><para>Founder</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#founder">http://d-nb.info/standards/elementset/gnd#founder</seealso>
    let founder = Prefixed_Name(gndo, "founder") |> PrefixedName

    /// <summary>
    ///   <para>gndo:precedingCorporateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Preceding corporate body</para><para>Vorherige Körperschaft</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#precedingCorporateBody">http://d-nb.info/standards/elementset/gnd#precedingCorporateBody</seealso>
    let precedingCorporateBody =
        Prefixed_Name(gndo, "precedingCorporateBody") |> PrefixedName

    /// <summary>
    ///   <para>gndo:precedingPlaceOrGeographicName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Preceding place or geographic name</para><para>Vorheriges Geografikum</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#precedingPlaceOrGeographicName">http://d-nb.info/standards/elementset/gnd#precedingPlaceOrGeographicName</seealso>
    let precedingPlaceOrGeographicName =
        Prefixed_Name(gndo, "precedingPlaceOrGeographicName") |> PrefixedName

    /// <summary>
    ///   <para>gndo:MeansOfTransportWithIndividual_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Use gndo:MeansOfTransportWithIndividualName</para>
    ///   <para>Bitte verwenden Sie gndo:MeansOfTransportWithIndividualName</para>
    /// labels<para>Means of transport with individual name</para><para>Verkehrsmittel mit Individualnamen</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#MeansOfTransportWithIndividual_name">http://d-nb.info/standards/elementset/gnd#MeansOfTransportWithIndividual_name</seealso>
    let MeansOfTransportWithIndividual_name =
        Prefixed_Name(gndo, "MeansOfTransportWithIndividual_name") |> PrefixedName

    /// <summary>
    ///   <para>gndo:forename</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Forename</para><para>Vorname</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#forename">http://d-nb.info/standards/elementset/gnd#forename</seealso>
    let forename = Prefixed_Name(gndo, "forename") |> PrefixedName
    /// <summary>
    ///   <para>gndo:owner</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A person, family, or organization that currently owns an item or collection, i.e. has legal possession of a resource</para>
    ///   <para>Eine Person, eine Familie oder eine Körperschaft, die im rechtmäßigen Besitz einer Ressource ist. </para>
    /// labels<para>Besitzer</para><para>Owner</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#owner">http://d-nb.info/standards/elementset/gnd#owner</seealso>
    let owner = Prefixed_Name(gndo, "owner") |> PrefixedName
    /// <summary>
    ///   <para>gndo:functionOrRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is equivalent to gndo:functionOrRoleAsLiteral but points to a subject heading instead of giving a literal value.</para>
    ///   <para>Diese Property ist äquivalent zu gndo:functionOrRoleAsLiteral, zeigt aber auf ein Schlagwort statt ein Literal auszugeben.</para>
    /// labels<para>Funktion oder Rolle</para><para>Function or role</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#functionOrRole">http://d-nb.info/standards/elementset/gnd#functionOrRole</seealso>
    let functionOrRole = Prefixed_Name(gndo, "functionOrRole") |> PrefixedName

    /// <summary>
    ///   <para>gndo:functionOrRoleAsLiteral</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property is equivalent to gndo:functionOrRole but gives a literal instead of a URI</para>
    ///   <para>Diese Property ist äquivalent zu gndo:functionOrRole, zeigt aber ein Literal statt eines URIs</para>
    /// labels<para>Funktion oder Rolle (Literal)</para><para>Function or role (Literal)</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#functionOrRoleAsLiteral">http://d-nb.info/standards/elementset/gnd#functionOrRoleAsLiteral</seealso>
    let functionOrRoleAsLiteral =
        Prefixed_Name(gndo, "functionOrRoleAsLiteral") |> PrefixedName

    /// <summary>
    ///   <para>gndo:gender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Geschlecht</para><para>Gender</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#gender">http://d-nb.info/standards/elementset/gnd#gender</seealso>
    let gender = Prefixed_Name(gndo, "gender") |> PrefixedName
    /// <summary>
    ///   <para>gndo:geographicAreaCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Geographic Area Code</para><para>Ländercode</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#geographicAreaCode">http://d-nb.info/standards/elementset/gnd#geographicAreaCode</seealso>
    let geographicAreaCode = Prefixed_Name(gndo, "geographicAreaCode") |> PrefixedName
    /// <summary>
    ///   <para>gndo:precedingSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Preceding subject heading</para><para>Vorheriges Schlagwort</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#precedingSubject">http://d-nb.info/standards/elementset/gnd#precedingSubject</seealso>
    let precedingSubject = Prefixed_Name(gndo, "precedingSubject") |> PrefixedName
    /// <summary>
    ///   <para>gndo:precedingWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Vorheriges Werk</para><para>Preceding work</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#precedingWork">http://d-nb.info/standards/elementset/gnd#precedingWork</seealso>
    let precedingWork = Prefixed_Name(gndo, "precedingWork") |> PrefixedName
    /// <summary>
    ///   <para>gndo:preferredName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Bevorzugter Name</para><para>Preferred name</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#preferredName">http://d-nb.info/standards/elementset/gnd#preferredName</seealso>
    let preferredName = Prefixed_Name(gndo, "preferredName") |> PrefixedName

    /// <summary>
    ///   <para>gndo:preferredNameEntityForThePerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Preferred name entity for the person</para><para>Bevorzugte Namensentität der Person</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#preferredNameEntityForThePerson">http://d-nb.info/standards/elementset/gnd#preferredNameEntityForThePerson</seealso>
    let preferredNameEntityForThePerson =
        Prefixed_Name(gndo, "preferredNameEntityForThePerson") |> PrefixedName

    /// <summary>
    ///   <para>gndo:preferredNameForTheCorporateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Preferred name for the corporate body</para><para>Bevorzugter Name der Körperschaft</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#preferredNameForTheCorporateBody">http://d-nb.info/standards/elementset/gnd#preferredNameForTheCorporateBody</seealso>
    let preferredNameForTheCorporateBody =
        Prefixed_Name(gndo, "preferredNameForTheCorporateBody") |> PrefixedName

    /// <summary>
    ///   <para>gndo:preferredNameForThePerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>Preferred name for the person</para><para>Bevorzugter Name der Person</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#preferredNameForThePerson">http://d-nb.info/standards/elementset/gnd#preferredNameForThePerson</seealso>
    let preferredNameForThePerson =
        Prefixed_Name(gndo, "preferredNameForThePerson") |> PrefixedName

    /// <summary>
    ///   <para>gndo:preferredNameForThePlaceOrGeographicName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>Preferred name for the place or geographic name</para><para>Bevorzugter Name des Geografikum</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#preferredNameForThePlaceOrGeographicName">http://d-nb.info/standards/elementset/gnd#preferredNameForThePlaceOrGeographicName</seealso>
    let preferredNameForThePlaceOrGeographicName =
        Prefixed_Name(gndo, "preferredNameForThePlaceOrGeographicName") |> PrefixedName

    /// <summary>
    ///   <para>gndo:preferredNameForTheWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>Preferred name for the work</para><para>Bevorzugter Name des Werks</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#preferredNameForTheWork">http://d-nb.info/standards/elementset/gnd#preferredNameForTheWork</seealso>
    let preferredNameForTheWork =
        Prefixed_Name(gndo, "preferredNameForTheWork") |> PrefixedName

    /// <summary>
    ///   <para>gndo:prefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Präfix</para><para>Prefix</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#prefix">http://d-nb.info/standards/elementset/gnd#prefix</seealso>
    let prefix = Prefixed_Name(gndo, "prefix") |> PrefixedName

    /// <summary>
    ///   <para>gndo:professionOrOccupationAsLiteral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Berufs- oder Tätigkeitsbezeichnung bzw.
    /// 	Bezeichnung für die Religionszugehörigkeit oder die Weltanschauung einer
    /// 	Person. Diese Property ist äquivalent zu gndo:professionOrOccupation, zeigt aber ein Literal
    /// 		statt einer Referenz zu einem Schlagwort</para>
    ///   <para>This property is equivalent to gndo:professionOrOccupation but gives a literal instead of
    /// 		a reference to a subject heading</para>
    /// labels<para>Beruf oder Beschäftigung (Literal)</para><para>Profession or occupation (Literal)</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#professionOrOccupationAsLiteral">http://d-nb.info/standards/elementset/gnd#professionOrOccupationAsLiteral</seealso>
    let professionOrOccupationAsLiteral =
        Prefixed_Name(gndo, "professionOrOccupationAsLiteral") |> PrefixedName

    /// <summary>
    ///   <para>gndo:professionalRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Eine berufliche Beziehung zwischen einer Person oder Familie und einer anderen Person oder Familie.</para>
    ///   <para>An occupational relationship between a person or family and another person or family</para>
    /// labels<para>Professional relationship</para><para>Berufliche Beziehung</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#professionalRelationship">http://d-nb.info/standards/elementset/gnd#professionalRelationship</seealso>
    let professionalRelationship =
        Prefixed_Name(gndo, "professionalRelationship") |> PrefixedName

    /// <summary>
    ///   <para>gndo:relatedPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>In Beziehung stehende Person</para><para>Related person</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#relatedPerson">http://d-nb.info/standards/elementset/gnd#relatedPerson</seealso>
    let relatedPerson = Prefixed_Name(gndo, "relatedPerson") |> PrefixedName
    /// <summary>
    ///   <para>gndo:realIdentity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Verknüpft eine Identität, unter der eine oder mehrere Personen agieren, z. B. schreiben, komponieren oder Kunstwerke schaffen, aber die nicht der wirkliche Name der Person ist (Pseudonym), mit der echten Identität der Person.</para>
    ///   <para>Links an identity under which one or more persons act, e. g. write, compose or create art, but that is not their real name (i. e. a pseudonym) to their real identity.</para>
    /// labels<para>Echte Identität</para><para>Real identity</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#realIdentity">http://d-nb.info/standards/elementset/gnd#realIdentity</seealso>
    let realIdentity = Prefixed_Name(gndo, "realIdentity") |> PrefixedName
    /// <summary>
    ///   <para>gndo:publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Titelangabe</para><para>Publication</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#publication">http://d-nb.info/standards/elementset/gnd#publication</seealso>
    let publication = Prefixed_Name(gndo, "publication") |> PrefixedName

    /// <summary>
    ///   <para>gndo:relatedConferenceOrEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>In Beziehung stehende Konferenz oder Veranstaltung</para><para>Related conference or event</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#relatedConferenceOrEvent">http://d-nb.info/standards/elementset/gnd#relatedConferenceOrEvent</seealso>
    let relatedConferenceOrEvent =
        Prefixed_Name(gndo, "relatedConferenceOrEvent") |> PrefixedName

    /// <summary>
    ///   <para>gndo:relatedCorporateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>In Beziehung stehende Körperschaft</para><para>Related Corporate Body</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#relatedCorporateBody">http://d-nb.info/standards/elementset/gnd#relatedCorporateBody</seealso>
    let relatedCorporateBody =
        Prefixed_Name(gndo, "relatedCorporateBody") |> PrefixedName

    /// <summary>
    ///   <para>gndo:relatedDdcWithDegreeOfDeterminacy1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Der Bedeutungsumfang der GND-Entität und der Bedeutungsumfang der
    ///       DDC-Klasse haben eine geringe Schnittmenge.</para>
    ///   <para>The connotation scope of the GND entity corresponds to a small part
    ///       to the connotation scope of the assigned DDC class.</para>
    /// labels<para>In Beziehung stehende Dewey-Dezimalklassifikation mit
    ///       Determiniertheitsgrad 1</para><para>Related Dewey Decimal Classification with degree of determinacy
    ///       1</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#relatedDdcWithDegreeOfDeterminacy1">http://d-nb.info/standards/elementset/gnd#relatedDdcWithDegreeOfDeterminacy1</seealso>
    let relatedDdcWithDegreeOfDeterminacy1 =
        Prefixed_Name(gndo, "relatedDdcWithDegreeOfDeterminacy1") |> PrefixedName

    /// <summary>
    ///   <para>gndo:relatedDdcWithDegreeOfDeterminacy2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The connotation scope of the GND entity is identical or nearly
    ///       identical to the connotation scope of a topic that is logically part of the class but is less
    ///       extensive in scope than the concept represented by the class number.</para>
    ///   <para>Die GND-Entität stimmt in seinem Bedeutungsumfang vollständig oder
    ///       weitgehend mit dem Bedeutungsumfang eines Themas überein, das sinngemäß Teil einer DDC-Klasse
    ///       ist, aber einen geringeren inhaltlichen Umfang aufweist als der durch die Notation
    ///       repräsentierte Begriff.</para>
    /// labels<para>In Beziehung stehende Dewey-Dezimalklassifikation mit
    ///       Determiniertheitsgrad 2</para><para>Related Dewey Decimal Classification with degree of determinacy
    ///       2</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#relatedDdcWithDegreeOfDeterminacy2">http://d-nb.info/standards/elementset/gnd#relatedDdcWithDegreeOfDeterminacy2</seealso>
    let relatedDdcWithDegreeOfDeterminacy2 =
        Prefixed_Name(gndo, "relatedDdcWithDegreeOfDeterminacy2") |> PrefixedName

    /// <summary>
    ///   <para>gndo:relatedDdcWithDegreeOfDeterminacy3</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The connotation scope of the GND entity is identical or nearly
    ///       identical to the connotation scope of a topic that approximates the whole of the assigned DDC
    ///       class. According to DDC terms, topics that are nearly coextensive with the full meaning of a
    ///       class or cover more than half of the content of the class approximate the whole of the DDC
    ///       class.</para>
    ///   <para>Die GND-Entität stimmt in seinem Bedeutungsumfang vollständig oder
    ///       weitgehend mit dem Bedeutungsumfang eines Themas überein, das wesentliche Übereinstimmung mit
    ///       der DDC-Klasse aufweist. In der DDC-Terminologie liegt eine wesentliche Übereinstimmung vor,
    ///       wenn ein Thema nahezu koextensiv mit einer DDC-Klasse ist oder mehr als die Hälfte des Inhalts
    ///       einer Klassenbenennung abdeckt.</para>
    /// labels<para>In Beziehung stehende Dewey-Dezimalklassifikation mit
    ///       Determiniertheitsgrad 3</para><para>Related Dewey Decimal Classification with degree of determinacy
    ///       3</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#relatedDdcWithDegreeOfDeterminacy3">http://d-nb.info/standards/elementset/gnd#relatedDdcWithDegreeOfDeterminacy3</seealso>
    let relatedDdcWithDegreeOfDeterminacy3 =
        Prefixed_Name(gndo, "relatedDdcWithDegreeOfDeterminacy3") |> PrefixedName

    /// <summary>
    ///   <para>gndo:NameOfSmallGeographicUnitLyingWithinAnotherGeographicUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Name of small geographic unit lying within another geographic
    ///       unit</para><para>Kleinräumiges Geografikum innerhalb eines Ortes</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#NameOfSmallGeographicUnitLyingWithinAnotherGeographicUnit">http://d-nb.info/standards/elementset/gnd#NameOfSmallGeographicUnitLyingWithinAnotherGeographicUnit</seealso>
    let NameOfSmallGeographicUnitLyingWithinAnotherGeographicUnit =
        Prefixed_Name(gndo, "NameOfSmallGeographicUnitLyingWithinAnotherGeographicUnit") |> PrefixedName

    /// <summary>
    ///   <para>gndo:NaturalGeographicUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Natürlich geografische Einheit</para><para>Natural geographic unit</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#NaturalGeographicUnit">http://d-nb.info/standards/elementset/gnd#NaturalGeographicUnit</seealso>
    let NaturalGeographicUnit =
        Prefixed_Name(gndo, "NaturalGeographicUnit") |> PrefixedName

    /// <summary>
    ///   <para>gndo:NomenclatureInBiologyOrChemistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Nomenclature in biology or chemistry</para><para>Nomenklatur Biologie - Chemie</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#NomenclatureInBiologyOrChemistry">http://d-nb.info/standards/elementset/gnd#NomenclatureInBiologyOrChemistry</seealso>
    let NomenclatureInBiologyOrChemistry =
        Prefixed_Name(gndo, "NomenclatureInBiologyOrChemistry") |> PrefixedName

    /// <summary>
    ///   <para>gndo:OrganOfCorporateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Organ einer Körperschaft</para><para>Organ of corporate body</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#OrganOfCorporateBody">http://d-nb.info/standards/elementset/gnd#OrganOfCorporateBody</seealso>
    let OrganOfCorporateBody =
        Prefixed_Name(gndo, "OrganOfCorporateBody") |> PrefixedName

    /// <summary>
    ///   <para>gndo:</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:Ontology</para>
    ///   <para>
    /// 	Changes from 2018-10-16 to 2019-02-12
    /// 	Removed the axiom that all main classes are disjoint
    /// 	Removed all owl:PropertyChains that have a owl:DatatypeProperty as their last chain link
    /// 	- #affiliationAsLiteral
    /// 	- #functionOrRoleAsLiteral
    /// 	- #placeOfBirthAsLiteral
    /// 	- #placeOfDeathAsLiteral
    /// 	- #professionOrOccupationAsLiteral
    /// 	- #titleOfNobilityAsLiteral
    ///
    /// 	Changes from 2018-05-15
    /// 	Minor corrections at some labels
    /// 	Added alignments to AgRelOn:
    /// 		gndo:relatedPerson rdfs:subPropertyOf agrelon:relatedAgent
    /// 		gndo:relatedFamily rdfs:subPropertyOf agrelon:relatedAgent
    /// 		gndo:relatedCorporateBody rdfs:subPropertyOf agrelon:relatedAgent
    /// 		gndo:memberOfTheFamily rdfs:subPropertyOf agrelon:isMemberOf
    /// 		gndo:dateOfBirth rdfs:subPropertyOf agrelon:hasBeginDate
    /// 		gndo:dateOfEstablishment rdfs:subPropertyOf agrelon:hasBeginDate
    /// 		gndo:dateOfDeath rdfs:subPropertyOf agrelon:hasEndDate
    /// 		gndo:dateOfTermination rdfs:subPropertyOf agrelon:hasEndDate
    ///
    /// 	Changes from 2018-01-16
    ///     Minor corrections to
    ///     http://d-nb.info/standards/elementset/gnd#topic
    ///     http://d-nb.info/standards/elementset/gnd#fieldOfActivity
    ///     http://d-nb.info/standards/elementset/gnd#narrowerTermGeneric
    ///
    ///     Changes from 2017-09-12
    ///
    /// 	Added new classes
    ///
    /// 	http://d-nb.info/standards/elementset/gnd#Company
    /// 	http://d-nb.info/standards/elementset/gnd#MusicalCorporateBody
    /// 	http://d-nb.info/standards/elementset/gnd#ReligiousCorporateBody
    /// 	http://d-nb.info/standards/elementset/gnd#ReligiousAdministrativeUnit
    ///
    /// 	Changes from 2017-01-17
    ///
    /// 	Added new Annotation Properties:
    ///
    /// 	http://d-nb.info/standards/elementset/gnd#abbreviatedNameForTheCorporateBody
    /// 	http://d-nb.info/standards/elementset/gnd#abbreviatedNameForTheConferenceOrEvent
    /// 	http://d-nb.info/standards/elementset/gnd#abbreviatedNameForThePlaceOrGeographicName
    /// 	http://d-nb.info/standards/elementset/gnd#abbreviatedNameForTheWork
    ///
    ///
    /// 	Changes from 2016-01-12
    ///
    /// 	Created new ObjectProperty #relatedSubjectHeading and deprecated ObjectProperty #relatedSubjecHeading
    ///     All Properties named #preferredName* or #variantName are now instances of owl:AnnotationProperty instead of owl:DatatypeProperty
    ///
    /// 	Changes from 2015-10-01
    /// 	Updated MARC 21-equivalent changing $9 to $g in following properties:
    /// 	http://d-nb.info/standards/elementset/gnd#addition
    /// 	http://d-nb.info/standards/elementset/gnd#nameAddition
    /// 	http://d-nb.info/standards/elementset/gnd#preferredNameForTheConferenceOrEvent
    /// 	http://d-nb.info/standards/elementset/gnd#preferredNameForTheCorporateBody
    /// 	http://d-nb.info/standards/elementset/gnd#preferredNameForTheFamily
    /// 	http://d-nb.info/standards/elementset/gnd#preferredNameForThePerson
    /// 	http://d-nb.info/standards/elementset/gnd#preferredNameForThePlaceOrGeographicName
    /// 	http://d-nb.info/standards/elementset/gnd#preferredNameForTheSubjectHeading
    /// 	http://d-nb.info/standards/elementset/gnd#preferredNameForTheWork
    /// 	http://d-nb.info/standards/elementset/gnd#variantNameForTheConferenceOrEvent
    /// 	http://d-nb.info/standards/elementset/gnd#variantNameForTheCorporateBody
    /// 	http://d-nb.info/standards/elementset/gnd#variantNameForTheFamily
    /// 	http://d-nb.info/standards/elementset/gnd#variantNameForThePerson
    /// 	http://d-nb.info/standards/elementset/gnd#variantNameForThePlaceOrGeographicName
    /// 	http://d-nb.info/standards/elementset/gnd#variantNameForTheSubjectHeading
    /// 	http://d-nb.info/standards/elementset/gnd#variantNameForTheWork
    /// 	http://d-nb.info/standards/elementset/gnd#affiliationAsLiteral
    /// 	http://d-nb.info/standards/elementset/gnd#academicDegree
    /// 	http://d-nb.info/standards/elementset/gnd#professionOrOccupationAsLiteral
    /// 	http://d-nb.info/standards/elementset/gnd#titleOfNobilityAsLiteral
    /// 	http://d-nb.info/standards/elementset/gnd#functionOrRoleAsLiteral
    /// 	http://d-nb.info/standards/elementset/gnd#placeOfBirthAsLiteral
    /// 	http://d-nb.info/standards/elementset/gnd#placeOfDeathAsLiteral
    ///
    ///
    ///
    /// 	Changes from 2015-05-19
    /// 	Correction of English comment and MARC 21 equivalent in gndo:titleOfNobilityAsLiteral
    ///
    /// 	Changes from 2015-01-13
    /// 	http://d-nb.info/standards/elementset/gnd#periodOfActivity is now a owl:DatatypeProperty
    /// 	gndo:homepage is now an owl:ObjectProperty (adaption to actual usage)
    /// 	removed owl:ontologyIRI (nonexistent property...)
    /// 	Corrected relation between http://d-nb.info/standards/elementset/gnd#periodOfActivity and http://www.w3.org/2000/01/rdf-schema#label from owl:subClassOf to owl:subPropertyOf
    /// 	Corrected typo in gndo:surname
    /// 	Deprecated class gndo:MeansOfTransportWithIndividual_name (change due to naming convention)
    /// 	Introduced class gndo:MeansOfTransportWithIndividualName
    /// 	Introduced new datatype property gndo:functionOrRoleAsLiteral
    /// 	Introduced new object property gndo:narrowerTermGeneral
    /// 	Introduced new object property gndo:narrowerTermGeneric
    /// 	Introduced new object property gndo:narrowerTermInstantial
    /// 	Introduced new object property gndo:narrowerTermPartitive
    ///
    /// 	Changes from 2014-09-16
    /// 	Deprecated http://d-nb.info/standards/elementset/gnd#Fictive_term
    /// 	Introduced http://d-nb.info/standards/elementset/gnd#FictiveTerm in order to keep naming consistent
    /// 	Changed rdfs:type to rdf:type in http://d-nb.info/standards/elementset/gnd#correspondent
    /// 	http://d-nb.info/standards/elementset/gnd#preferredNameEntityForThePerson and http://d-nb.info/standards/elementset/gnd#variantNameEntityForThePerson are now owl:ObjectProperties
    /// 	http://d-nb.info/standards/elementset/gnd#titleOfNobility is now an owl:ObjectProperty
    /// 	Introduced new owl:DatatypeProperty http://d-nb.info/standards/elementset/gnd#titleOfNobilityAsLiteral
    /// 	http://d-nb.info/standards/elementset/gnd#preferredName is now an owl:subPropertyOf rdfs:label
    ///
    ///
    /// 	Changes from 2014-05-15:
    /// 	Updated RDA-Mappings to reflect new RDA namespaces
    ///
    /// 	Changes from 2014-01-15:
    /// 	Corrected MARC 21 equivalent and rdfs:range in http://d-nb.info/standards/elementset/gnd#academicDegree
    /// 	Updated labels to distinguish datatype properties from similar object properties: http://d-nb.info/standards/elementset/gnd#affiliationAsLiteral, http://d-nb.info/standards/elementset/gnd#placeOfBirthAsLiteral, http://d-nb.info/standards/elementset/gnd#placeOfDeathAsLiteral, http://d-nb.info/standards/elementset/gnd#professionOrOccupationAsLiteral
    /// 	Marked http://d-nb.info/standards/elementset/gnd#correspondent as owl:symmetricProperty
    /// 	Deprecated http://d-nb.info/standards/elementset/gnd#broderTermGeneral (misspelled term name in URI)
    /// 	Introduced http://d-nb.info/standards/elementset/gnd#broaderTermGeneral (correctly spelled name in URI)
    /// 	Corrected alignment to skos:broader: added to http://d-nb.info/standards/elementset/gnd#broaderTermGeneral, removed from http://d-nb.info/standards/elementset/gnd#broderTermGeneric (skos:broader)
    ///
    /// 	Changes from 2012-06-30
    /// 	Added rdfs:isDefinedBy everywhere
    /// 	Added alignments:
    /// 		http://d-nb.info/standards/elementset/gnd#variantNameForTheSubjectHeading (skos:altLabel)
    /// 		http://d-nb.info/standards/elementset/gnd#preferredNameForTheSubjectHeading (skos:prefLabel)
    /// 		http://d-nb.info/standards/elementset/gnd#SubjectHeading (skos:Concept)
    /// 		http://d-nb.info/standards/elementset/gnd#broaderTermGeneric (skos:broader)
    /// 	Hierarchy of broader/narrower term changed
    /// 		gndo:broaderTerm is deprecated
    /// 		gndo:broaderTermGeneral is now top level hierarche of broader/narrower
    /// 		Following Properties are now subproperties of gndo:broaderTermGeneral:
    /// 			gndo:broaderTermGeneric
    /// 			gndo:broaderTermInstantial
    /// 			gndo:broaderTermPartitive
    /// 			gndo:broaderTermWithMoreThanOneElement
    /// 	Fixed incorrect supertype for gndo:definition. gndo:definition is now a subproperty
    /// 	of dct:definition, not of foaf:depiction
    /// 	Deprecated gndo:StartingOrFinalPointOfADistance (with a capital S)
    /// 	Introduced gndo:startingOrFinalPointOfADistance (with a minor s)
    ///
    /// 	Specified that gndo:relatedTerm is also a owl:SymmetricProperty
    /// 	Deprecated the property #addition
    /// 	Deprecated the property #epithetGenericNameTitleOrTerritory
    /// 	Added new Datatype property #nameAddition
    ///
    /// 	Introduced new class hierarchy for NameOfThePerson
    /// 	gndo:NameOfThePerson (existing class)
    /// 		gndo:PreferredNameOfThePerson (new class)
    /// 		gndo:VariantNameOfThePerson (new class)
    /// 			gndo:EarlierNameOfThePerson (new class)
    /// 			gndo:LaterNameOfThePerson (new class)
    /// 			gndo:FullerFormOfNameOfThePerson (new class)
    /// 			gndo:RealNameOfThePerson (new class)
    /// 			gndo:PseudonymNameOfTheperson (new class)
    ///
    /// </para>
    /// </remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#">http://d-nb.info/standards/elementset/gnd#</seealso>
    let _prefix_iri = Prefixed_Name(gndo, "") |> PrefixedName
    /// <summary>
    ///   <para>gndo:alexanderHaffner</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    ///
    /// labels<para>Alexander Haffner</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#alexanderHaffner">http://d-nb.info/standards/elementset/gnd#alexanderHaffner</seealso>
    let alexanderHaffner = Prefixed_Name(gndo, "alexanderHaffner") |> PrefixedName

    /// <summary>
    ///   <para>gndo:VariantNameOfThePerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Abweichender Name der Person</para><para>Variant name of the person</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#VariantNameOfThePerson">http://d-nb.info/standards/elementset/gnd#VariantNameOfThePerson</seealso>
    let VariantNameOfThePerson =
        Prefixed_Name(gndo, "VariantNameOfThePerson") |> PrefixedName

    /// <summary>
    ///   <para>gndo:acquaintanceshipOrFriendship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Relationship between a person, family, or corporate body and another person, family, or corporate body which cannot be specified more closely</para>
    ///   <para>Person, die mit der beschriebenen Person bekannt ist und nicht
    /// 	in familiärer oder beruflicher Beziehung steht. Für Beziehungen von oder zu Familien
    /// 	wird gndo:memberOfTheFamily verwendet.</para>
    /// labels<para>Beziehung, Bekanntschaft, Freundschaft</para><para>Acquaintanceship or friendship</para></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/gnd#acquaintanceshipOrFriendship">http://d-nb.info/standards/elementset/gnd#acquaintanceshipOrFriendship</seealso>
    let acquaintanceshipOrFriendship =
        Prefixed_Name(gndo, "acquaintanceshipOrFriendship") |> PrefixedName

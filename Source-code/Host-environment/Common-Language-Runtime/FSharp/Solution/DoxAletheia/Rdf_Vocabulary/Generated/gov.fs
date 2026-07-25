namespace http.gov.genealogy.net.ontology.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module gov =
    let _namespace_iri = Namespace_Iri gov |> NamespaceIRI
    /// <summary>
    ///   <para>gov:isReplacedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///
    /// labels<para>object is deprecated and has been replaced by</para><para>Objekt wurde ersetzt durch</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#isReplacedBy">http://gov.genealogy.net/ontology.owl#isReplacedBy</seealso>
    let isReplacedBy = Prefixed_Name(gov, "isReplacedBy") |> PrefixedName
    /// <summary>
    ///   <para>gov:latitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>geographische Breite</para><para>latitute</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#latitude">http://gov.genealogy.net/ontology.owl#latitude</seealso>
    let latitude = Prefixed_Name(gov, "latitude") |> PrefixedName
    /// <summary>
    ///   <para>gov:longitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>geographische Länge</para><para>longitude</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#longitude">http://gov.genealogy.net/ontology.owl#longitude</seealso>
    let longitude = Prefixed_Name(gov, "longitude") |> PrefixedName
    /// <summary>
    ///   <para>gov:GovItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#GovItem">http://gov.genealogy.net/ontology.owl#GovItem</seealso>
    let GovItem = Prefixed_Name(gov, "GovItem") |> PrefixedName
    /// <summary>
    ///   <para>gov:noteText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Text der Notiz</para><para>note text</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#noteText">http://gov.genealogy.net/ontology.owl#noteText</seealso>
    let noteText = Prefixed_Name(gov, "noteText") |> PrefixedName
    /// <summary>
    ///   <para>gov:source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>source citation</para><para>Quellenangabe</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#source">http://gov.genealogy.net/ontology.owl#source</seealso>
    let source = Prefixed_Name(gov, "source") |> PrefixedName
    /// <summary>
    ///   <para>gov:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>object type</para><para>Objekttyp</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#type">http://gov.genealogy.net/ontology.owl#type</seealso>
    let type_ = Prefixed_Name(gov, "type") |> PrefixedName
    /// <summary>
    ///   <para>gov:typeName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Name des Typs</para><para>type's name</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#typeName">http://gov.genealogy.net/ontology.owl#typeName</seealso>
    let typeName = Prefixed_Name(gov, "typeName") |> PrefixedName
    /// <summary>
    ///   <para>gov:Type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>type</para><para>Typ</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#Type">http://gov.genealogy.net/ontology.owl#Type</seealso>
    let Type = Prefixed_Name(gov, "Type") |> PrefixedName
    /// <summary>
    ///   <para>gov:note</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Notiz</para><para>note</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#note">http://gov.genealogy.net/ontology.owl#note</seealso>
    let note = Prefixed_Name(gov, "note") |> PrefixedName
    /// <summary>
    ///   <para>gov:position</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>geographische Position</para><para>geographic position</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#position">http://gov.genealogy.net/ontology.owl#position</seealso>
    let position = Prefixed_Name(gov, "position") |> PrefixedName
    /// <summary>
    ///   <para>gov:GovObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Objekt (Wohnplatz oder Verwaltungseinheit)</para><para>object (settlement or administrative unit)</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#GovObject">http://gov.genealogy.net/ontology.owl#GovObject</seealso>
    let GovObject = Prefixed_Name(gov, "GovObject") |> PrefixedName
    /// <summary>
    ///   <para>gov:Position</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>geographische Position</para><para>geographic position</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#Position">http://gov.genealogy.net/ontology.owl#Position</seealso>
    let Position = Prefixed_Name(gov, "Position") |> PrefixedName
    /// <summary>
    ///   <para>gov:sourceNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Notiz zur Quellenangabe</para><para>note to the source</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#sourceNote">http://gov.genealogy.net/ontology.owl#sourceNote</seealso>
    let sourceNote = Prefixed_Name(gov, "sourceNote") |> PrefixedName
    /// <summary>
    ///   <para>gov:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>value</para><para>Wert</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#value">http://gov.genealogy.net/ontology.owl#value</seealso>
    let value = Prefixed_Name(gov, "value") |> PrefixedName
    /// <summary>
    ///   <para>gov:Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Eigenschaft</para><para>property</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#Property">http://gov.genealogy.net/ontology.owl#Property</seealso>
    let Property = Prefixed_Name(gov, "Property") |> PrefixedName
    /// <summary>
    ///   <para>gov:Relation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Beziehung zwischen zwei Objekten</para><para>relationship between two objects</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#Relation">http://gov.genealogy.net/ontology.owl#Relation</seealso>
    let Relation = Prefixed_Name(gov, "Relation") |> PrefixedName
    /// <summary>
    ///   <para>gov:PropertyForObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Eigenschaft für ein Objekt</para><para>property of an object</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#PropertyForObject">http://gov.genealogy.net/ontology.owl#PropertyForObject</seealso>
    let PropertyForObject = Prefixed_Name(gov, "PropertyForObject") |> PrefixedName
    /// <summary>
    ///   <para>gov:Source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>source</para><para>Quelle</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#Source">http://gov.genealogy.net/ontology.owl#Source</seealso>
    let Source = Prefixed_Name(gov, "Source") |> PrefixedName
    /// <summary>
    ///   <para>gov:PropertyForSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Eigenschaft für eine Quelle</para><para>property of a source</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#PropertyForSource">http://gov.genealogy.net/ontology.owl#PropertyForSource</seealso>
    let PropertyForSource = Prefixed_Name(gov, "PropertyForSource") |> PrefixedName
    /// <summary>
    ///   <para>gov:PropertyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Eigenschaft 'Objekttyp'</para><para>property 'object type'</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#PropertyType">http://gov.genealogy.net/ontology.owl#PropertyType</seealso>
    let PropertyType = Prefixed_Name(gov, "PropertyType") |> PrefixedName
    /// <summary>
    ///   <para>gov:Timespan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>time span</para><para>Zeitraum</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#Timespan">http://gov.genealogy.net/ontology.owl#Timespan</seealso>
    let Timespan = Prefixed_Name(gov, "Timespan") |> PrefixedName
    /// <summary>
    ///   <para>gov:PropertyName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Eigenschaft 'Name'</para><para>property 'name'</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#PropertyName">http://gov.genealogy.net/ontology.owl#PropertyName</seealso>
    let PropertyName = Prefixed_Name(gov, "PropertyName") |> PrefixedName
    /// <summary>
    ///   <para>gov:SourceReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>source citation</para><para>Quellenangabe</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#SourceReference">http://gov.genealogy.net/ontology.owl#SourceReference</seealso>
    let SourceReference = Prefixed_Name(gov, "SourceReference") |> PrefixedName
    /// <summary>
    ///   <para>gov:begin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Beginn</para><para>begin</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#begin">http://gov.genealogy.net/ontology.owl#begin</seealso>
    let begin_ = Prefixed_Name(gov, "begin") |> PrefixedName

    /// <summary>
    ///   <para>gov:containsInformationAbout</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>die Quelle enthält Informationen über diese Objekte</para><para>the source contains information about these objects</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#containsInformationAbout">http://gov.genealogy.net/ontology.owl#containsInformationAbout</seealso>
    let containsInformationAbout =
        Prefixed_Name(gov, "containsInformationAbout") |> PrefixedName

    /// <summary>
    ///   <para>gov:relation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>allgemeine Beziehung</para><para>generic relation</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#relation">http://gov.genealogy.net/ontology.owl#relation</seealso>
    let relation = Prefixed_Name(gov, "relation") |> PrefixedName
    /// <summary>
    ///   <para>gov:end</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Ende</para><para>end</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#end">http://gov.genealogy.net/ontology.owl#end</seealso>
    let end_ = Prefixed_Name(gov, "end") |> PrefixedName
    /// <summary>
    ///   <para>gov:property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>allgemeine Eigenschaft</para><para>generic property</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#property">http://gov.genealogy.net/ontology.owl#property</seealso>
    let property = Prefixed_Name(gov, "property") |> PrefixedName
    /// <summary>
    ///   <para>gov:hasAuthor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>name of the publication's author</para><para>Name des Autors der Publikation</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#hasAuthor">http://gov.genealogy.net/ontology.owl#hasAuthor</seealso>
    let hasAuthor = Prefixed_Name(gov, "hasAuthor") |> PrefixedName
    /// <summary>
    ///   <para>gov:hasISBN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>International Standard Book Number (ISBN)</para><para>International Standard Book Number (ISBN)</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#hasISBN">http://gov.genealogy.net/ontology.owl#hasISBN</seealso>
    let hasISBN = Prefixed_Name(gov, "hasISBN") |> PrefixedName
    /// <summary>
    ///   <para>gov:hasMunicipalityId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Gemeindeschlüssel</para><para>municipality code</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#hasMunicipalityId">http://gov.genealogy.net/ontology.owl#hasMunicipalityId</seealso>
    let hasMunicipalityId = Prefixed_Name(gov, "hasMunicipalityId") |> PrefixedName
    /// <summary>
    ///   <para>gov:hasPopulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Einwohnerzahl</para><para>population</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#hasPopulation">http://gov.genealogy.net/ontology.owl#hasPopulation</seealso>
    let hasPopulation = Prefixed_Name(gov, "hasPopulation") |> PrefixedName
    /// <summary>
    ///   <para>gov:hasTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Title</para><para>title</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#hasTitle">http://gov.genealogy.net/ontology.owl#hasTitle</seealso>
    let hasTitle = Prefixed_Name(gov, "hasTitle") |> PrefixedName
    /// <summary>
    ///   <para>gov:hasURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>web site</para><para>Webseite</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#hasURL">http://gov.genealogy.net/ontology.owl#hasURL</seealso>
    let hasURL = Prefixed_Name(gov, "hasURL") |> PrefixedName
    /// <summary>
    ///   <para>gov:hasWNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"W number" (identification for former German municipalities)</para><para>"W-Nummer" (Hilfspostleitzahl)</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#hasWNumber">http://gov.genealogy.net/ontology.owl#hasWNumber</seealso>
    let hasWNumber = Prefixed_Name(gov, "hasWNumber") |> PrefixedName
    /// <summary>
    ///   <para>gov:hasDenomination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>denomination</para><para>Konfession</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#hasDenomination">http://gov.genealogy.net/ontology.owl#hasDenomination</seealso>
    let hasDenomination = Prefixed_Name(gov, "hasDenomination") |> PrefixedName
    /// <summary>
    ///   <para>gov:hasArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Fläche (in m²)</para><para>area (in m²)</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#hasArea">http://gov.genealogy.net/ontology.owl#hasArea</seealso>
    let hasArea = Prefixed_Name(gov, "hasArea") |> PrefixedName
    /// <summary>
    ///   <para>gov:hasHouseholds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Anzahl der Haushalte</para><para>number of households</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#hasHouseholds">http://gov.genealogy.net/ontology.owl#hasHouseholds</seealso>
    let hasHouseholds = Prefixed_Name(gov, "hasHouseholds") |> PrefixedName
    /// <summary>
    ///   <para>gov:hasName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>name</para><para>Name</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#hasName">http://gov.genealogy.net/ontology.owl#hasName</seealso>
    let hasName = Prefixed_Name(gov, "hasName") |> PrefixedName
    /// <summary>
    ///   <para>gov:hasPostalCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Postleitzahl</para><para>postal code</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#hasPostalCode">http://gov.genealogy.net/ontology.owl#hasPostalCode</seealso>
    let hasPostalCode = Prefixed_Name(gov, "hasPostalCode") |> PrefixedName
    /// <summary>
    ///   <para>gov:hasSubtitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Untertitel</para><para>subtitle</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#hasSubtitle">http://gov.genealogy.net/ontology.owl#hasSubtitle</seealso>
    let hasSubtitle = Prefixed_Name(gov, "hasSubtitle") |> PrefixedName
    /// <summary>
    ///   <para>gov:hasType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>object type</para><para>Objekttyp</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#hasType">http://gov.genealogy.net/ontology.owl#hasType</seealso>
    let hasType = Prefixed_Name(gov, "hasType") |> PrefixedName
    /// <summary>
    ///   <para>gov:height</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Höhe über dem Meeresspiegel in Metern</para><para>altitude in meters</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#height">http://gov.genealogy.net/ontology.owl#height</seealso>
    let height = Prefixed_Name(gov, "height") |> PrefixedName
    /// <summary>
    ///   <para>gov:isPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ist Teil von</para><para>is part of</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#isPartOf">http://gov.genealogy.net/ontology.owl#isPartOf</seealso>
    let isPartOf = Prefixed_Name(gov, "isPartOf") |> PrefixedName
    /// <summary>
    ///   <para>gov:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>language (ISO-639-2)</para><para>Sprache (ISO-639-2)</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#language">http://gov.genealogy.net/ontology.owl#language</seealso>
    let language = Prefixed_Name(gov, "language") |> PrefixedName
    /// <summary>
    ///   <para>gov:isLocatedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>building is located in</para><para>Gebäude steht in</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#isLocatedIn">http://gov.genealogy.net/ontology.owl#isLocatedIn</seealso>
    let isLocatedIn = Prefixed_Name(gov, "isLocatedIn") |> PrefixedName
    /// <summary>
    ///   <para>gov:lastModification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Datum des letzten Änderung</para><para>date of last modification</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#lastModification">http://gov.genealogy.net/ontology.owl#lastModification</seealso>
    let lastModification = Prefixed_Name(gov, "lastModification") |> PrefixedName
    /// <summary>
    ///   <para>gov:Note</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Notiz</para><para>note</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#Note">http://gov.genealogy.net/ontology.owl#Note</seealso>
    let Note = Prefixed_Name(gov, "Note") |> PrefixedName
    /// <summary>
    ///   <para>gov:ref</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>reference</para><para>Referenz</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#ref">http://gov.genealogy.net/ontology.owl#ref</seealso>
    let ref = Prefixed_Name(gov, "ref") |> PrefixedName
    /// <summary>
    ///   <para>gov:represents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Beispiele: 1) eine Kirche als sichtbares Gebäude repräsentiert eine Kirchengemeinde, 2) eine
    ///     Stadt repräsentiert als Hauptstadt ein Land</para>
    ///   <para>examples: 1) a church as a visible building represents a parish 2) a town represents a country
    ///     as its capital</para>
    /// labels<para>Objekt repräsentiert ein anderes Objekt</para><para>object represents another object</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#represents">http://gov.genealogy.net/ontology.owl#represents</seealso>
    let represents = Prefixed_Name(gov, "represents") |> PrefixedName
    /// <summary>
    ///   <para>gov:sourceRef</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Quelle</para><para>source</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#sourceRef">http://gov.genealogy.net/ontology.owl#sourceRef</seealso>
    let sourceRef = Prefixed_Name(gov, "sourceRef") |> PrefixedName
    /// <summary>
    ///   <para>gov:time</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Zeitdauer, zu der die Information gültig war oder die Beziehung bestand</para>
    ///   <para>time period in which the statement was correct or there was relation
    ///     relationship.</para>
    /// labels<para>Gültigkeitsdauer</para><para>lifetime</para></remarks>
    /// <seealso href="http://gov.genealogy.net/ontology.owl#time">http://gov.genealogy.net/ontology.owl#time</seealso>
    let time = Prefixed_Name(gov, "time") |> PrefixedName

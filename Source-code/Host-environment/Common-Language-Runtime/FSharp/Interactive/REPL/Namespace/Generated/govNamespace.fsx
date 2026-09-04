#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module gov =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://gov.genealogy.net/ontology.owl#" "gov"

    let GovItem = _prefixId.prefix "GovItem"
    /// <summary>
    ///   <para>rdfs:label : Objekt (Wohnplatz oder Verwaltungseinheit)rdfs:label : object (settlement or administrative unit)</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#GovObject">gov:GovObject</a>
    /// </summary>
    let GovObject = _prefixId.prefix "GovObject"
    /// <summary>
    ///   <para>rdfs:label : Notizrdfs:label : note</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#Note">gov:Note</a>
    /// </summary>
    let Note = _prefixId.prefix "Note"
    /// <summary>
    ///   <para>rdfs:label : geographische Positionrdfs:label : geographic position</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#Position">gov:Position</a>
    /// </summary>
    let Position = _prefixId.prefix "Position"
    /// <summary>
    ///   <para>rdfs:label : Eigenschaftrdfs:label : property</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#Property">gov:Property</a>
    /// </summary>
    let Property = _prefixId.prefix "Property"
    /// <summary>
    ///   <para>rdfs:label : Eigenschaft für ein Objektrdfs:label : property of an object</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#PropertyForObject">gov:PropertyForObject</a>
    /// </summary>
    let PropertyForObject = _prefixId.prefix "PropertyForObject"
    /// <summary>
    ///   <para>rdfs:label : Eigenschaft für eine Quellerdfs:label : property of a source</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#PropertyForSource">gov:PropertyForSource</a>
    /// </summary>
    let PropertyForSource = _prefixId.prefix "PropertyForSource"
    /// <summary>
    ///   <para>rdfs:label : Eigenschaft 'Name'rdfs:label : property 'name'</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#PropertyName">gov:PropertyName</a>
    /// </summary>
    let PropertyName = _prefixId.prefix "PropertyName"
    /// <summary>
    ///   <para>rdfs:label : Eigenschaft 'Objekttyp'rdfs:label : property 'object type'</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#PropertyType">gov:PropertyType</a>
    /// </summary>
    let PropertyType = _prefixId.prefix "PropertyType"
    /// <summary>
    ///   <para>rdfs:label : Beziehung zwischen zwei Objektenrdfs:label : relationship between two objects</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#Relation">gov:Relation</a>
    /// </summary>
    let Relation = _prefixId.prefix "Relation"
    /// <summary>
    ///   <para>rdfs:label : Quellerdfs:label : source</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#Source">gov:Source</a>
    /// </summary>
    let Source = _prefixId.prefix "Source"
    /// <summary>
    ///   <para>rdfs:label : Quellenangaberdfs:label : source citation</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#SourceReference">gov:SourceReference</a>
    /// </summary>
    let SourceReference = _prefixId.prefix "SourceReference"
    /// <summary>
    ///   <para>rdfs:label : Zeitraumrdfs:label : time span</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#Timespan">gov:Timespan</a>
    /// </summary>
    let Timespan = _prefixId.prefix "Timespan"
    /// <summary>
    ///   <para>rdfs:label : Typrdfs:label : type</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#Type">gov:Type</a>
    /// </summary>
    let Type = _prefixId.prefix "Type"
    /// <summary>
    ///   <para>rdfs:label : Beginnrdfs:label : begin</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#begin">gov:begin</a>
    /// </summary>
    let begin_ = _prefixId.prefix "begin"
    /// <summary>
    ///   <para>rdfs:label : die Quelle enthält Informationen über diese Objekterdfs:label : the source contains information about these objects</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#containsInformationAbout">gov:containsInformationAbout</a>
    /// </summary>
    let containsInformationAbout = _prefixId.prefix "containsInformationAbout"
    /// <summary>
    ///   <para>rdfs:label : Enderdfs:label : end</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#end">gov:end</a>
    /// </summary>
    let end_ = _prefixId.prefix "end"
    /// <summary>
    ///   <para>rdfs:label : Fläche (in m²)rdfs:label : area (in m²)</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#hasArea">gov:hasArea</a>
    /// </summary>
    let hasArea = _prefixId.prefix "hasArea"
    /// <summary>
    ///   <para>rdfs:label : Name des Autors der Publikationrdfs:label : name of the publication's author</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#hasAuthor">gov:hasAuthor</a>
    /// </summary>
    let hasAuthor = _prefixId.prefix "hasAuthor"
    /// <summary>
    ///   <para>rdfs:label : Konfessionrdfs:label : denomination</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#hasDenomination">gov:hasDenomination</a>
    /// </summary>
    let hasDenomination = _prefixId.prefix "hasDenomination"
    /// <summary>
    ///   <para>rdfs:label : Anzahl der Haushalterdfs:label : number of households</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#hasHouseholds">gov:hasHouseholds</a>
    /// </summary>
    let hasHouseholds = _prefixId.prefix "hasHouseholds"
    /// <summary>
    ///   <para>rdfs:label : International Standard Book Number (ISBN)rdfs:label : International Standard Book Number (ISBN)</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#hasISBN">gov:hasISBN</a>
    /// </summary>
    let hasISBN = _prefixId.prefix "hasISBN"
    /// <summary>
    ///   <para>rdfs:label : Gemeindeschlüsselrdfs:label : municipality code</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#hasMunicipalityId">gov:hasMunicipalityId</a>
    /// </summary>
    let hasMunicipalityId = _prefixId.prefix "hasMunicipalityId"
    /// <summary>
    ///   <para>rdfs:label : Namerdfs:label : name</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#hasName">gov:hasName</a>
    /// </summary>
    let hasName = _prefixId.prefix "hasName"
    /// <summary>
    ///   <para>rdfs:label : Einwohnerzahlrdfs:label : population</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#hasPopulation">gov:hasPopulation</a>
    /// </summary>
    let hasPopulation = _prefixId.prefix "hasPopulation"
    /// <summary>
    ///   <para>rdfs:label : Postleitzahlrdfs:label : postal code</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#hasPostalCode">gov:hasPostalCode</a>
    /// </summary>
    let hasPostalCode = _prefixId.prefix "hasPostalCode"
    /// <summary>
    ///   <para>rdfs:label : Untertitelrdfs:label : subtitle</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#hasSubtitle">gov:hasSubtitle</a>
    /// </summary>
    let hasSubtitle = _prefixId.prefix "hasSubtitle"
    /// <summary>
    ///   <para>rdfs:label : Titlerdfs:label : title</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#hasTitle">gov:hasTitle</a>
    /// </summary>
    let hasTitle = _prefixId.prefix "hasTitle"
    /// <summary>
    ///   <para>rdfs:label : Objekttyprdfs:label : object type</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#hasType">gov:hasType</a>
    /// </summary>
    let hasType = _prefixId.prefix "hasType"
    /// <summary>
    ///   <para>rdfs:label : Webseiterdfs:label : web site</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#hasURL">gov:hasURL</a>
    /// </summary>
    let hasURL = _prefixId.prefix "hasURL"
    /// <summary>
    ///   <para>rdfs:label : "W-Nummer" (Hilfspostleitzahl)rdfs:label : "W number" (identification for former German municipalities)</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#hasWNumber">gov:hasWNumber</a>
    /// </summary>
    let hasWNumber = _prefixId.prefix "hasWNumber"
    /// <summary>
    ///   <para>rdfs:label : Höhe über dem Meeresspiegel in Meternrdfs:label : altitude in meters</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#height">gov:height</a>
    /// </summary>
    let height = _prefixId.prefix "height"
    /// <summary>
    ///   <para>rdfs:label : Gebäude steht inrdfs:label : building is located in</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#isLocatedIn">gov:isLocatedIn</a>
    /// </summary>
    let isLocatedIn = _prefixId.prefix "isLocatedIn"
    /// <summary>
    ///   <para>rdfs:label : ist Teil vonrdfs:label : is part of</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#isPartOf">gov:isPartOf</a>
    /// </summary>
    let isPartOf = _prefixId.prefix "isPartOf"
    /// <summary>
    ///   <para>rdfs:label : Objekt wurde ersetzt durchrdfs:label : object is deprecated and has been replaced by</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#isReplacedBy">gov:isReplacedBy</a>
    /// </summary>
    let isReplacedBy = _prefixId.prefix "isReplacedBy"
    /// <summary>
    ///   <para>rdfs:label : Sprache (ISO-639-2)rdfs:label : language (ISO-639-2)</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#language">gov:language</a>
    /// </summary>
    let language = _prefixId.prefix "language"
    /// <summary>
    ///   <para>rdfs:label : Datum des letzten Änderungrdfs:label : date of last modification</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#lastModification">gov:lastModification</a>
    /// </summary>
    let lastModification = _prefixId.prefix "lastModification"
    /// <summary>
    ///   <para>rdfs:label : geographische Breiterdfs:label : latitute</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#latitude">gov:latitude</a>
    /// </summary>
    let latitude = _prefixId.prefix "latitude"
    /// <summary>
    ///   <para>rdfs:label : geographische Längerdfs:label : longitude</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#longitude">gov:longitude</a>
    /// </summary>
    let longitude = _prefixId.prefix "longitude"
    /// <summary>
    ///   <para>rdfs:label : Notizrdfs:label : note</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#note">gov:note</a>
    /// </summary>
    let note = _prefixId.prefix "note"
    /// <summary>
    ///   <para>rdfs:label : Text der Notizrdfs:label : note text</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#noteText">gov:noteText</a>
    /// </summary>
    let noteText = _prefixId.prefix "noteText"
    /// <summary>
    ///   <para>rdfs:label : geographische Positionrdfs:label : geographic position</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#position">gov:position</a>
    /// </summary>
    let position = _prefixId.prefix "position"
    /// <summary>
    ///   <para>rdfs:label : allgemeine Eigenschaftrdfs:label : generic property</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#property">gov:property</a>
    /// </summary>
    let property = _prefixId.prefix "property"
    /// <summary>
    ///   <para>rdfs:label : Referenzrdfs:label : reference</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#ref">gov:ref</a>
    /// </summary>
    let ref = _prefixId.prefix "ref"
    /// <summary>
    ///   <para>rdfs:label : allgemeine Beziehungrdfs:label : generic relation</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#relation">gov:relation</a>
    /// </summary>
    let relation = _prefixId.prefix "relation"
    /// <summary>
    ///   <para>rdfs:label : Objekt repräsentiert ein anderes Objektrdfs:label : object represents another object</para>
    ///   <para>rdfs:comment : Beispiele: 1) eine Kirche als sichtbares Gebäude repräsentiert eine Kirchengemeinde, 2) eine
    ///     Stadt repräsentiert als Hauptstadt ein Landrdfs:comment : examples: 1) a church as a visible building represents a parish 2) a town represents a country
    ///     as its capital</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#represents">gov:represents</a>
    /// </summary>
    let represents = _prefixId.prefix "represents"
    /// <summary>
    ///   <para>rdfs:label : Quellenangaberdfs:label : source citation</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#source">gov:source</a>
    /// </summary>
    let source = _prefixId.prefix "source"
    /// <summary>
    ///   <para>rdfs:label : Notiz zur Quellenangaberdfs:label : note to the source</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#sourceNote">gov:sourceNote</a>
    /// </summary>
    let sourceNote = _prefixId.prefix "sourceNote"
    /// <summary>
    ///   <para>rdfs:label : Quellerdfs:label : source</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#sourceRef">gov:sourceRef</a>
    /// </summary>
    let sourceRef = _prefixId.prefix "sourceRef"
    /// <summary>
    ///   <para>rdfs:label : Gültigkeitsdauerrdfs:label : lifetime</para>
    ///   <para>rdfs:comment : Zeitdauer, zu der die Information gültig war oder die Beziehung bestandrdfs:comment : time period in which the statement was correct or there was relation
    ///     relationship.</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#time">gov:time</a>
    /// </summary>
    let time = _prefixId.prefix "time"
    /// <summary>
    ///   <para>rdfs:label : Objekttyprdfs:label : object type</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#type">gov:type</a>
    /// </summary>
    let type_ = _prefixId.prefix "type"
    /// <summary>
    ///   <para>rdfs:label : Name des Typsrdfs:label : type's name</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#typeName">gov:typeName</a>
    /// </summary>
    let typeName = _prefixId.prefix "typeName"
    /// <summary>
    ///   <para>rdfs:label : Wertrdfs:label : value</para>
    ///   <a href="http://gov.genealogy.net/ontology.owl#value">gov:value</a>
    /// </summary>
    let value = _prefixId.prefix "value"

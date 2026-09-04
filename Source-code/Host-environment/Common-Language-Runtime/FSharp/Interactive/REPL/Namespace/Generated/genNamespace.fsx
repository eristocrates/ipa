#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module gen =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/gen/0.1#" "gen"
    let _namespaceIri = _prefixId.prefix ""
    let Assertion = _prefixId.prefix "Assertion"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Family</para>
    ///   <para>rdfs:comment : Though it is preferred to represent families by describing the relationships between its members
    /// 		(parent-child, husband-wife, etc.) this class can be used to represent a group of people who are
    /// 		considered to be a family unit.</para>
    ///   <a href="http://purl.org/gen/0.1#Family">gen:Family</a>
    /// </summary>
    let Family = _prefixId.prefix "Family"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Family Tree</para>
    ///   <para>rdfs:comment : This container class should be populated with individual people, families, or other records
    /// 		that constitute a single 'family tree'. It is intended to help users in management of their
    /// 		genealogical data.</para>
    ///   <a href="http://purl.org/gen/0.1#FamilyTree">gen:FamilyTree</a>
    /// </summary>
    let FamilyTree = _prefixId.prefix "FamilyTree"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : FOAF Name</para>
    ///   <para>rdfs:comment : A name class aiming for maximum compatibility with FOAF. Individuals in this class are intended
    /// 		to be described using foaf's name properties, namely foaf:name, foaf:givenName, and
    /// 		foaf:familyName.</para>
    ///   <a href="http://purl.org/gen/0.1#FoafName">gen:FoafName</a>
    /// </summary>
    let FoafName = _prefixId.prefix "FoafName"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Grave Inscription</para>
    ///   <para>rdfs:comment : A grave inscription, such as on a tomb or headstone.</para>
    ///   <a href="http://purl.org/gen/0.1#GraveInscription">gen:GraveInscription</a>
    /// </summary>
    let GraveInscription = _prefixId.prefix "GraveInscription"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Microfiche</para>
    ///   <para>rdfs:comment : 'A microfiche is a flat film 105 x 148 mm in size, that is ISO A6.' (Wikipedia:Microform)</para>
    ///   <a href="http://purl.org/gen/0.1#Microfiche">gen:Microfiche</a>
    /// </summary>
    let Microfiche = _prefixId.prefix "Microfiche"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Microfilm</para>
    ///   <para>rdfs:comment : A microfilm reel</para>
    ///   <a href="http://purl.org/gen/0.1#Microfilm">gen:Microfilm</a>
    /// </summary>
    let Microfilm = _prefixId.prefix "Microfilm"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Microform</para>
    ///   <para>rdfs:comment : The general class of microform media, defined by Wikipedia as 'any forms, either films or paper,
    /// 		containing microreproductions of documents for transmission, storage, reading, and printing.'</para>
    ///   <a href="http://purl.org/gen/0.1#Microform">gen:Microform</a>
    /// </summary>
    let Microform = _prefixId.prefix "Microform"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Monumental Inscription</para>
    ///   <para>rdfs:comment : The general class of monumental inscriptions, defined by Wikipedia as 'an inscription, typically
    /// 		carved in stone, on a grave marker, cenotaph, memorial plaque, church monument or other memorial.'</para>
    ///   <a href="http://purl.org/gen/0.1#MonumentalInscription">gen:MonumentalInscription</a>
    /// </summary>
    let MonumentalInscription = _prefixId.prefix "MonumentalInscription"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Name</para>
    ///   <para>rdfs:comment : A personal name. Names are a class of their own to facilitate associating multiple names with
    /// 		the same individual, and to allow different types of names or ways of representing them.</para>
    ///   <a href="http://purl.org/gen/0.1#Name">gen:Name</a>
    /// </summary>
    let Name = _prefixId.prefix "Name"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Place</para>
    ///   <para>rdfs:comment : A geolocated position</para>
    ///   <a href="http://purl.org/gen/0.1#Place">gen:Place</a>
    /// </summary>
    let Place = _prefixId.prefix "Place"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Time</para>
    ///   <para>rdfs:comment : A moment in time or a span of time</para>
    ///   <a href="http://purl.org/gen/0.1#Time">gen:Time</a>
    /// </summary>
    let Time = _prefixId.prefix "Time"
    /// <summary>
    ///   <para>rdfs:label : birth</para>
    ///   <para>rdfs:comment : Specifies a person's birth event.</para>
    ///   <a href="http://purl.org/gen/0.1#birth">gen:birth</a>
    /// </summary>
    let birth = _prefixId.prefix "birth"
    let birthFather = _prefixId.prefix "birthFather"
    let birthMother = _prefixId.prefix "birthMother"
    let birthParent = _prefixId.prefix "birthParent"
    /// <summary>
    ///   <para>rdfs:label : child</para>
    ///   <para>rdfs:comment : A child in a family.</para>
    ///   <a href="http://purl.org/gen/0.1#child">gen:child</a>
    /// </summary>
    let child = _prefixId.prefix "child"
    /// <summary>
    ///   <para>rdfs:label : death</para>
    ///   <para>rdfs:comment : Specifies a person's death event.</para>
    ///   <a href="http://purl.org/gen/0.1#death">gen:death</a>
    /// </summary>
    let death = _prefixId.prefix "death"
    let deceased = _prefixId.prefix "deceased"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : familyMember^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates a member of a Family^^xsd:string</para>
    ///   <a href="http://purl.org/gen/0.1#familyMember">gen:familyMember</a>
    /// </summary>
    let familyMember = _prefixId.prefix "familyMember"
    /// <summary>
    ///   <para>rdfs:label : father</para>
    ///   <para>rdfs:comment : A father of a family.</para>
    ///   <a href="http://purl.org/gen/0.1#father">gen:father</a>
    /// </summary>
    let father = _prefixId.prefix "father"
    /// <summary>
    ///   <para>rdfs:label : lifeEvent</para>
    ///   <para>rdfs:comment : The lifeEvent property is a slight variation on bio:event in which the domain is foaf:Person rather than foaf:Agent, since genealogy is about people.</para>
    ///   <a href="http://purl.org/gen/0.1#lifeEvent">gen:lifeEvent</a>
    /// </summary>
    let lifeEvent = _prefixId.prefix "lifeEvent"
    /// <summary>
    ///   <para>rdfs:label : mother</para>
    ///   <para>rdfs:comment : A mother of a family.</para>
    ///   <a href="http://purl.org/gen/0.1#mother">gen:mother</a>
    /// </summary>
    let mother = _prefixId.prefix "mother"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : name</para>
    ///   <para>rdfs:comment : A person's name.</para>
    ///   <a href="http://purl.org/gen/0.1#name">gen:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    let newborn = _prefixId.prefix "newborn"
    /// <summary>
    ///   <para>rdfs:label : parent</para>
    ///   <para>rdfs:comment : A parent in a family.</para>
    ///   <a href="http://purl.org/gen/0.1#parent">gen:parent</a>
    /// </summary>
    let parent = _prefixId.prefix "parent"
    /// <summary>
    ///   <para>rdfs:label : participant</para>
    ///   <para>rdfs:comment : Adapts bio:agent by having a range of foaf:Person rather than foaf:Agent.</para>
    ///   <a href="http://purl.org/gen/0.1#participant">gen:participant</a>
    /// </summary>
    let participant = _prefixId.prefix "participant"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Source</para>
    ///   <para>rdfs:comment : A source justifying some assertion or claim of fact. The range is deliberately left as general as possible
    /// 		(owl:Thing) because of the unsettled state of bibliographic vocabularies. My recommendation is to use
    /// 		bibo:Document and its associated vocabulary, though frbr:Work seems reasonable, too. Surely there are
    /// 		many other options---hopefully a clear standard emerges in the future.</para>
    ///   <a href="http://purl.org/gen/0.1#source">gen:source</a>
    /// </summary>
    let source = _prefixId.prefix "source"
    let spouse = _prefixId.prefix "spouse"
    /// <summary>
    ///   <para>rdfs:label : stepFather</para>
    ///   <para>rdfs:comment : A step-father of a family.</para>
    ///   <a href="http://purl.org/gen/0.1#stepFather">gen:stepFather</a>
    /// </summary>
    let stepFather = _prefixId.prefix "stepFather"
    /// <summary>
    ///   <para>rdfs:label : stepMother</para>
    ///   <para>rdfs:comment : A step-mother of a family.</para>
    ///   <a href="http://purl.org/gen/0.1#stepMother">gen:stepMother</a>
    /// </summary>
    let stepMother = _prefixId.prefix "stepMother"
    /// <summary>
    ///   <para>rdfs:label : stepParent</para>
    ///   <para>rdfs:comment : A step-parent of a family.</para>
    ///   <a href="http://purl.org/gen/0.1#stepParent">gen:stepParent</a>
    /// </summary>
    let stepParent = _prefixId.prefix "stepParent"
    let subAssertion = _prefixId.prefix "subAssertion"

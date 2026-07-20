namespace http.purl.org.gen._0._1.hash

open DoxAletheia

module gen =
    let _namespace_name = "http://purl.org/gen/0.1#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/gen/0.1#Assertion"></see>
    /// </summary>
    let Assertion = _prefix "Assertion"
    /// <summary>
    /// Though it is preferred to represent families by describing the relationships between its members
    /// 		(parent-child, husband-wife, etc.) this class can be used to represent a group of people who are
    /// 		considered to be a family unit.
    /// <see href="http://purl.org/gen/0.1#Family"></see></summary>
    let Family = _prefix "Family"
    /// <summary>
    /// This container class should be populated with individual people, families, or other records
    /// 		that constitute a single 'family tree'. It is intended to help users in management of their
    /// 		genealogical data.
    /// <see href="http://purl.org/gen/0.1#FamilyTree"></see></summary>
    let FamilyTree = _prefix "FamilyTree"
    /// <summary>
    /// A name class aiming for maximum compatibility with FOAF. Individuals in this class are intended
    /// 		to be described using foaf's name properties, namely foaf:name, foaf:givenName, and
    /// 		foaf:familyName.
    /// <see href="http://purl.org/gen/0.1#FoafName"></see></summary>
    let FoafName = _prefix "FoafName"
    /// <summary>
    /// A personal name. Names are a class of their own to facilitate associating multiple names with
    /// 		the same individual, and to allow different types of names or ways of representing them.
    /// <see href="http://purl.org/gen/0.1#Name"></see></summary>
    let Name = _prefix "Name"
    /// <summary>
    /// A grave inscription, such as on a tomb or headstone.
    /// <see href="http://purl.org/gen/0.1#GraveInscription"></see></summary>
    let GraveInscription = _prefix "GraveInscription"
    /// <summary>
    /// The general class of monumental inscriptions, defined by Wikipedia as 'an inscription, typically
    /// 		carved in stone, on a grave marker, cenotaph, memorial plaque, church monument or other memorial.'
    /// <see href="http://purl.org/gen/0.1#MonumentalInscription"></see></summary>
    let MonumentalInscription = _prefix "MonumentalInscription"
    /// <summary>
    /// 'A microfiche is a flat film 105 x 148 mm in size, that is ISO A6.' (Wikipedia:Microform)
    /// <see href="http://purl.org/gen/0.1#Microfiche"></see></summary>
    let Microfiche = _prefix "Microfiche"
    /// <summary>
    /// The general class of microform media, defined by Wikipedia as 'any forms, either films or paper,
    /// 		containing microreproductions of documents for transmission, storage, reading, and printing.'
    /// <see href="http://purl.org/gen/0.1#Microform"></see></summary>
    let Microform = _prefix "Microform"
    /// <summary>
    /// A microfilm reel
    /// <see href="http://purl.org/gen/0.1#Microfilm"></see></summary>
    let Microfilm = _prefix "Microfilm"
    /// <summary>
    /// A geolocated position
    /// <see href="http://purl.org/gen/0.1#Place"></see></summary>
    let Place = _prefix "Place"
    /// <summary>
    /// A moment in time or a span of time
    /// <see href="http://purl.org/gen/0.1#Time"></see></summary>
    let Time = _prefix "Time"
    /// <summary>
    /// Specifies a person's birth event.
    /// <see href="http://purl.org/gen/0.1#birth"></see></summary>
    let birth = _prefix "birth"
    /// <summary>
    /// The lifeEvent property is a slight variation on bio:event in which the domain is foaf:Person rather than foaf:Agent, since genealogy is about people.
    /// <see href="http://purl.org/gen/0.1#lifeEvent"></see></summary>
    let lifeEvent = _prefix "lifeEvent"
    /// <summary>
    ///   <see href="http://purl.org/gen/0.1#newborn"></see>
    /// </summary>
    let newborn = _prefix "newborn"
    /// <summary>
    ///   <see href="http://purl.org/gen/0.1#birthFather"></see>
    /// </summary>
    let birthFather = _prefix "birthFather"
    /// <summary>
    ///   <see href="http://purl.org/gen/0.1#birthParent"></see>
    /// </summary>
    let birthParent = _prefix "birthParent"
    /// <summary>
    ///   <see href="http://purl.org/gen/0.1#birthMother"></see>
    /// </summary>
    let birthMother = _prefix "birthMother"
    /// <summary>
    /// Adapts bio:agent by having a range of foaf:Person rather than foaf:Agent.
    /// <see href="http://purl.org/gen/0.1#participant"></see></summary>
    let participant = _prefix "participant"
    /// <summary>
    /// A child in a family.
    /// <see href="http://purl.org/gen/0.1#child"></see></summary>
    let child = _prefix "child"
    /// <summary>
    /// Indicates a member of a Family
    /// <see href="http://purl.org/gen/0.1#familyMember"></see></summary>
    let familyMember = _prefix "familyMember"
    /// <summary>
    /// Specifies a person's death event.
    /// <see href="http://purl.org/gen/0.1#death"></see></summary>
    let death = _prefix "death"
    /// <summary>
    ///   <see href="http://purl.org/gen/0.1#deceased"></see>
    /// </summary>
    let deceased = _prefix "deceased"
    /// <summary>
    /// A father of a family.
    /// <see href="http://purl.org/gen/0.1#father"></see></summary>
    let father = _prefix "father"
    /// <summary>
    /// A parent in a family.
    /// <see href="http://purl.org/gen/0.1#parent"></see></summary>
    let parent = _prefix "parent"
    /// <summary>
    /// A mother of a family.
    /// <see href="http://purl.org/gen/0.1#mother"></see></summary>
    let mother = _prefix "mother"
    /// <summary>
    /// A person's name.
    /// <see href="http://purl.org/gen/0.1#name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// A source justifying some assertion or claim of fact. The range is deliberately left as general as possible
    /// 		(owl:Thing) because of the unsettled state of bibliographic vocabularies. My recommendation is to use
    /// 		bibo:Document and its associated vocabulary, though frbr:Work seems reasonable, too. Surely there are
    /// 		many other options---hopefully a clear standard emerges in the future.
    /// <see href="http://purl.org/gen/0.1#source"></see></summary>
    let source = _prefix "source"
    /// <summary>
    ///   <see href="http://purl.org/gen/0.1#spouse"></see>
    /// </summary>
    let spouse = _prefix "spouse"
    /// <summary>
    /// A step-father of a family.
    /// <see href="http://purl.org/gen/0.1#stepFather"></see></summary>
    let stepFather = _prefix "stepFather"
    /// <summary>
    /// A step-parent of a family.
    /// <see href="http://purl.org/gen/0.1#stepParent"></see></summary>
    let stepParent = _prefix "stepParent"
    /// <summary>
    /// A step-mother of a family.
    /// <see href="http://purl.org/gen/0.1#stepMother"></see></summary>
    let stepMother = _prefix "stepMother"
    /// <summary>
    ///   <see href="http://purl.org/gen/0.1#subAssertion"></see>
    /// </summary>
    let subAssertion = _prefix "subAssertion"

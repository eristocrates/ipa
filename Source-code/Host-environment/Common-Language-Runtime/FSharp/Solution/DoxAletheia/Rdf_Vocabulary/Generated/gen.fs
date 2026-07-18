namespace http.purl.org.gen._0._1.hash

open DoxAletheia.Rdf_Vocabulary

module gen =
    let _namespace_name = "http://purl.org/gen/0.1#"
    /// <summary>
    ///   <see href="http://purl.org/gen/0.1#Assertion"></see>
    /// </summary>
    let Assertion = Namespaced_IRI.parse _namespace_name "Assertion" |> NamespacedName
    /// <summary>
    /// Though it is preferred to represent families by describing the relationships between its members
    /// 		(parent-child, husband-wife, etc.) this class can be used to represent a group of people who are
    /// 		considered to be a family unit.
    /// <see href="http://purl.org/gen/0.1#Family"></see></summary>
    let Family = Namespaced_IRI.parse _namespace_name "Family" |> NamespacedName
    /// <summary>
    /// This container class should be populated with individual people, families, or other records
    /// 		that constitute a single 'family tree'. It is intended to help users in management of their
    /// 		genealogical data.
    /// <see href="http://purl.org/gen/0.1#FamilyTree"></see></summary>
    let FamilyTree = Namespaced_IRI.parse _namespace_name "FamilyTree" |> NamespacedName
    /// <summary>
    /// A name class aiming for maximum compatibility with FOAF. Individuals in this class are intended
    /// 		to be described using foaf's name properties, namely foaf:name, foaf:givenName, and
    /// 		foaf:familyName.
    /// <see href="http://purl.org/gen/0.1#FoafName"></see></summary>
    let FoafName = Namespaced_IRI.parse _namespace_name "FoafName" |> NamespacedName
    /// <summary>
    /// A personal name. Names are a class of their own to facilitate associating multiple names with
    /// 		the same individual, and to allow different types of names or ways of representing them.
    /// <see href="http://purl.org/gen/0.1#Name"></see></summary>
    let Name = Namespaced_IRI.parse _namespace_name "Name" |> NamespacedName

    /// <summary>
    /// A grave inscription, such as on a tomb or headstone.
    /// <see href="http://purl.org/gen/0.1#GraveInscription"></see></summary>
    let GraveInscription =
        Namespaced_IRI.parse _namespace_name "GraveInscription" |> NamespacedName

    /// <summary>
    /// The general class of monumental inscriptions, defined by Wikipedia as 'an inscription, typically
    /// 		carved in stone, on a grave marker, cenotaph, memorial plaque, church monument or other memorial.'
    /// <see href="http://purl.org/gen/0.1#MonumentalInscription"></see></summary>
    let MonumentalInscription =
        Namespaced_IRI.parse _namespace_name "MonumentalInscription" |> NamespacedName

    /// <summary>
    /// 'A microfiche is a flat film 105 x 148 mm in size, that is ISO A6.' (Wikipedia:Microform)
    /// <see href="http://purl.org/gen/0.1#Microfiche"></see></summary>
    let Microfiche = Namespaced_IRI.parse _namespace_name "Microfiche" |> NamespacedName
    /// <summary>
    /// The general class of microform media, defined by Wikipedia as 'any forms, either films or paper,
    /// 		containing microreproductions of documents for transmission, storage, reading, and printing.'
    /// <see href="http://purl.org/gen/0.1#Microform"></see></summary>
    let Microform = Namespaced_IRI.parse _namespace_name "Microform" |> NamespacedName
    /// <summary>
    /// A microfilm reel
    /// <see href="http://purl.org/gen/0.1#Microfilm"></see></summary>
    let Microfilm = Namespaced_IRI.parse _namespace_name "Microfilm" |> NamespacedName
    /// <summary>
    /// A geolocated position
    /// <see href="http://purl.org/gen/0.1#Place"></see></summary>
    let Place = Namespaced_IRI.parse _namespace_name "Place" |> NamespacedName
    /// <summary>
    /// A moment in time or a span of time
    /// <see href="http://purl.org/gen/0.1#Time"></see></summary>
    let Time = Namespaced_IRI.parse _namespace_name "Time" |> NamespacedName
    /// <summary>
    /// Specifies a person's birth event.
    /// <see href="http://purl.org/gen/0.1#birth"></see></summary>
    let birth = Namespaced_IRI.parse _namespace_name "birth" |> NamespacedName
    /// <summary>
    /// The lifeEvent property is a slight variation on bio:event in which the domain is foaf:Person rather than foaf:Agent, since genealogy is about people.
    /// <see href="http://purl.org/gen/0.1#lifeEvent"></see></summary>
    let lifeEvent = Namespaced_IRI.parse _namespace_name "lifeEvent" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/gen/0.1#newborn"></see>
    /// </summary>
    let newborn = Namespaced_IRI.parse _namespace_name "newborn" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/gen/0.1#birthFather"></see>
    /// </summary>
    let birthFather =
        Namespaced_IRI.parse _namespace_name "birthFather" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/gen/0.1#birthParent"></see>
    /// </summary>
    let birthParent =
        Namespaced_IRI.parse _namespace_name "birthParent" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/gen/0.1#birthMother"></see>
    /// </summary>
    let birthMother =
        Namespaced_IRI.parse _namespace_name "birthMother" |> NamespacedName

    /// <summary>
    /// Adapts bio:agent by having a range of foaf:Person rather than foaf:Agent.
    /// <see href="http://purl.org/gen/0.1#participant"></see></summary>
    let participant =
        Namespaced_IRI.parse _namespace_name "participant" |> NamespacedName

    /// <summary>
    /// A child in a family.
    /// <see href="http://purl.org/gen/0.1#child"></see></summary>
    let child = Namespaced_IRI.parse _namespace_name "child" |> NamespacedName

    /// <summary>
    /// Indicates a member of a Family
    /// <see href="http://purl.org/gen/0.1#familyMember"></see></summary>
    let familyMember =
        Namespaced_IRI.parse _namespace_name "familyMember" |> NamespacedName

    /// <summary>
    /// Specifies a person's death event.
    /// <see href="http://purl.org/gen/0.1#death"></see></summary>
    let death = Namespaced_IRI.parse _namespace_name "death" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/gen/0.1#deceased"></see>
    /// </summary>
    let deceased = Namespaced_IRI.parse _namespace_name "deceased" |> NamespacedName
    /// <summary>
    /// A father of a family.
    /// <see href="http://purl.org/gen/0.1#father"></see></summary>
    let father = Namespaced_IRI.parse _namespace_name "father" |> NamespacedName
    /// <summary>
    /// A parent in a family.
    /// <see href="http://purl.org/gen/0.1#parent"></see></summary>
    let parent = Namespaced_IRI.parse _namespace_name "parent" |> NamespacedName
    /// <summary>
    /// A mother of a family.
    /// <see href="http://purl.org/gen/0.1#mother"></see></summary>
    let mother = Namespaced_IRI.parse _namespace_name "mother" |> NamespacedName
    /// <summary>
    /// A person's name.
    /// <see href="http://purl.org/gen/0.1#name"></see></summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName
    /// <summary>
    /// A source justifying some assertion or claim of fact. The range is deliberately left as general as possible
    /// 		(owl:Thing) because of the unsettled state of bibliographic vocabularies. My recommendation is to use
    /// 		bibo:Document and its associated vocabulary, though frbr:Work seems reasonable, too. Surely there are
    /// 		many other options---hopefully a clear standard emerges in the future.
    /// <see href="http://purl.org/gen/0.1#source"></see></summary>
    let source = Namespaced_IRI.parse _namespace_name "source" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/gen/0.1#spouse"></see>
    /// </summary>
    let spouse = Namespaced_IRI.parse _namespace_name "spouse" |> NamespacedName
    /// <summary>
    /// A step-father of a family.
    /// <see href="http://purl.org/gen/0.1#stepFather"></see></summary>
    let stepFather = Namespaced_IRI.parse _namespace_name "stepFather" |> NamespacedName
    /// <summary>
    /// A step-parent of a family.
    /// <see href="http://purl.org/gen/0.1#stepParent"></see></summary>
    let stepParent = Namespaced_IRI.parse _namespace_name "stepParent" |> NamespacedName
    /// <summary>
    /// A step-mother of a family.
    /// <see href="http://purl.org/gen/0.1#stepMother"></see></summary>
    let stepMother = Namespaced_IRI.parse _namespace_name "stepMother" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/gen/0.1#subAssertion"></see>
    /// </summary>
    let subAssertion =
        Namespaced_IRI.parse _namespace_name "subAssertion" |> NamespacedName

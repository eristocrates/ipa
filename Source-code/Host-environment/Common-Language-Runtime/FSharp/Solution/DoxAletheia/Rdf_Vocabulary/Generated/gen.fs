namespace http.purl.org.gen._0._1.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module gen =
    let _namespace_iri = Namespace_Iri gen |> NamespaceIRI
    /// <summary>
    ///   <para>gen:Assertion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/gen/0.1#Assertion">http://purl.org/gen/0.1#Assertion</seealso>
    let Assertion = Prefixed_Name(gen, "Assertion") |> PrefixedName
    /// <summary>
    ///   <para>gen:FamilyTree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This container class should be populated with individual people, families, or other records
    /// 		that constitute a single 'family tree'. It is intended to help users in management of their
    /// 		genealogical data.</para>
    /// labels<para>Family Tree</para></remarks>
    /// <seealso href="http://purl.org/gen/0.1#FamilyTree">http://purl.org/gen/0.1#FamilyTree</seealso>
    let FamilyTree = Prefixed_Name(gen, "FamilyTree") |> PrefixedName
    /// <summary>
    ///   <para>gen:Name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A personal name. Names are a class of their own to facilitate associating multiple names with
    /// 		the same individual, and to allow different types of names or ways of representing them.</para>
    /// labels<para>Name</para></remarks>
    /// <seealso href="http://purl.org/gen/0.1#Name">http://purl.org/gen/0.1#Name</seealso>
    let Name = Prefixed_Name(gen, "Name") |> PrefixedName
    /// <summary>
    ///   <para>gen:GraveInscription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A grave inscription, such as on a tomb or headstone.</para>
    /// labels<para>Grave Inscription</para></remarks>
    /// <seealso href="http://purl.org/gen/0.1#GraveInscription">http://purl.org/gen/0.1#GraveInscription</seealso>
    let GraveInscription = Prefixed_Name(gen, "GraveInscription") |> PrefixedName

    /// <summary>
    ///   <para>gen:MonumentalInscription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The general class of monumental inscriptions, defined by Wikipedia as 'an inscription, typically
    /// 		carved in stone, on a grave marker, cenotaph, memorial plaque, church monument or other memorial.'</para>
    /// labels<para>Monumental Inscription</para></remarks>
    /// <seealso href="http://purl.org/gen/0.1#MonumentalInscription">http://purl.org/gen/0.1#MonumentalInscription</seealso>
    let MonumentalInscription =
        Prefixed_Name(gen, "MonumentalInscription") |> PrefixedName

    /// <summary>
    ///   <para>gen:Time</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A moment in time or a span of time</para>
    /// labels<para>Time</para></remarks>
    /// <seealso href="http://purl.org/gen/0.1#Time">http://purl.org/gen/0.1#Time</seealso>
    let Time = Prefixed_Name(gen, "Time") |> PrefixedName
    /// <summary>
    ///   <para>gen:lifeEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The lifeEvent property is a slight variation on bio:event in which the domain is foaf:Person rather than foaf:Agent, since genealogy is about people.</para>
    /// labels<para>lifeEvent</para></remarks>
    /// <seealso href="http://purl.org/gen/0.1#lifeEvent">http://purl.org/gen/0.1#lifeEvent</seealso>
    let lifeEvent = Prefixed_Name(gen, "lifeEvent") |> PrefixedName
    /// <summary>
    ///   <para>gen:spouse</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://purl.org/gen/0.1#spouse">http://purl.org/gen/0.1#spouse</seealso>
    let spouse = Prefixed_Name(gen, "spouse") |> PrefixedName
    /// <summary>
    ///   <para>gen:stepParent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A step-parent of a family.</para>
    /// labels<para>stepParent</para></remarks>
    /// <seealso href="http://purl.org/gen/0.1#stepParent">http://purl.org/gen/0.1#stepParent</seealso>
    let stepParent = Prefixed_Name(gen, "stepParent") |> PrefixedName
    /// <summary>
    ///   <para>gen:stepMother</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A step-mother of a family.</para>
    /// labels<para>stepMother</para></remarks>
    /// <seealso href="http://purl.org/gen/0.1#stepMother">http://purl.org/gen/0.1#stepMother</seealso>
    let stepMother = Prefixed_Name(gen, "stepMother") |> PrefixedName
    /// <summary>
    ///   <para>gen:subAssertion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://purl.org/gen/0.1#subAssertion">http://purl.org/gen/0.1#subAssertion</seealso>
    let subAssertion = Prefixed_Name(gen, "subAssertion") |> PrefixedName
    /// <summary>
    ///   <para>gen:FoafName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A name class aiming for maximum compatibility with FOAF. Individuals in this class are intended
    /// 		to be described using foaf's name properties, namely foaf:name, foaf:givenName, and
    /// 		foaf:familyName.</para>
    /// labels<para>FOAF Name</para></remarks>
    /// <seealso href="http://purl.org/gen/0.1#FoafName">http://purl.org/gen/0.1#FoafName</seealso>
    let FoafName = Prefixed_Name(gen, "FoafName") |> PrefixedName
    /// <summary>
    ///   <para>gen:Microform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The general class of microform media, defined by Wikipedia as 'any forms, either films or paper,
    /// 		containing microreproductions of documents for transmission, storage, reading, and printing.'</para>
    /// labels<para>Microform</para></remarks>
    /// <seealso href="http://purl.org/gen/0.1#Microform">http://purl.org/gen/0.1#Microform</seealso>
    let Microform = Prefixed_Name(gen, "Microform") |> PrefixedName
    /// <summary>
    ///   <para>gen:Place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A geolocated position</para>
    /// labels<para>Place</para></remarks>
    /// <seealso href="http://purl.org/gen/0.1#Place">http://purl.org/gen/0.1#Place</seealso>
    let Place = Prefixed_Name(gen, "Place") |> PrefixedName
    /// <summary>
    ///   <para>gen:Microfilm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A microfilm reel</para>
    /// labels<para>Microfilm</para></remarks>
    /// <seealso href="http://purl.org/gen/0.1#Microfilm">http://purl.org/gen/0.1#Microfilm</seealso>
    let Microfilm = Prefixed_Name(gen, "Microfilm") |> PrefixedName
    /// <summary>
    ///   <para>gen:Microfiche</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>'A microfiche is a flat film 105 x 148 mm in size, that is ISO A6.' (Wikipedia:Microform)</para>
    /// labels<para>Microfiche</para></remarks>
    /// <seealso href="http://purl.org/gen/0.1#Microfiche">http://purl.org/gen/0.1#Microfiche</seealso>
    let Microfiche = Prefixed_Name(gen, "Microfiche") |> PrefixedName
    /// <summary>
    ///   <para>gen:birth</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies a person's birth event.</para>
    /// labels<para>birth</para></remarks>
    /// <seealso href="http://purl.org/gen/0.1#birth">http://purl.org/gen/0.1#birth</seealso>
    let birth = Prefixed_Name(gen, "birth") |> PrefixedName
    /// <summary>
    ///   <para>gen:birthFather</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://purl.org/gen/0.1#birthFather">http://purl.org/gen/0.1#birthFather</seealso>
    let birthFather = Prefixed_Name(gen, "birthFather") |> PrefixedName
    /// <summary>
    ///   <para>gen:birthMother</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://purl.org/gen/0.1#birthMother">http://purl.org/gen/0.1#birthMother</seealso>
    let birthMother = Prefixed_Name(gen, "birthMother") |> PrefixedName
    /// <summary>
    ///   <para>gen:participant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Adapts bio:agent by having a range of foaf:Person rather than foaf:Agent.</para>
    /// labels<para>participant</para></remarks>
    /// <seealso href="http://purl.org/gen/0.1#participant">http://purl.org/gen/0.1#participant</seealso>
    let participant = Prefixed_Name(gen, "participant") |> PrefixedName
    /// <summary>
    ///   <para>gen:newborn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://purl.org/gen/0.1#newborn">http://purl.org/gen/0.1#newborn</seealso>
    let newborn = Prefixed_Name(gen, "newborn") |> PrefixedName
    /// <summary>
    ///   <para>gen:birthParent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://purl.org/gen/0.1#birthParent">http://purl.org/gen/0.1#birthParent</seealso>
    let birthParent = Prefixed_Name(gen, "birthParent") |> PrefixedName
    /// <summary>
    ///   <para>gen:child</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A child in a family.</para>
    /// labels<para>child</para></remarks>
    /// <seealso href="http://purl.org/gen/0.1#child">http://purl.org/gen/0.1#child</seealso>
    let child = Prefixed_Name(gen, "child") |> PrefixedName
    /// <summary>
    ///   <para>gen:familyMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a member of a Family</para>
    /// labels<para>familyMember</para></remarks>
    /// <seealso href="http://purl.org/gen/0.1#familyMember">http://purl.org/gen/0.1#familyMember</seealso>
    let familyMember = Prefixed_Name(gen, "familyMember") |> PrefixedName
    /// <summary>
    ///   <para>gen:death</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies a person's death event.</para>
    /// labels<para>death</para></remarks>
    /// <seealso href="http://purl.org/gen/0.1#death">http://purl.org/gen/0.1#death</seealso>
    let death = Prefixed_Name(gen, "death") |> PrefixedName
    /// <summary>
    ///   <para>gen:deceased</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://purl.org/gen/0.1#deceased">http://purl.org/gen/0.1#deceased</seealso>
    let deceased = Prefixed_Name(gen, "deceased") |> PrefixedName
    /// <summary>
    ///   <para>gen:father</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A father of a family.</para>
    /// labels<para>father</para></remarks>
    /// <seealso href="http://purl.org/gen/0.1#father">http://purl.org/gen/0.1#father</seealso>
    let father = Prefixed_Name(gen, "father") |> PrefixedName
    /// <summary>
    ///   <para>gen:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A person's name.</para>
    /// labels<para>name</para></remarks>
    /// <seealso href="http://purl.org/gen/0.1#name">http://purl.org/gen/0.1#name</seealso>
    let name = Prefixed_Name(gen, "name") |> PrefixedName
    /// <summary>
    ///   <para>gen:mother</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A mother of a family.</para>
    /// labels<para>mother</para></remarks>
    /// <seealso href="http://purl.org/gen/0.1#mother">http://purl.org/gen/0.1#mother</seealso>
    let mother = Prefixed_Name(gen, "mother") |> PrefixedName
    /// <summary>
    ///   <para>gen:parent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A parent in a family.</para>
    /// labels<para>parent</para></remarks>
    /// <seealso href="http://purl.org/gen/0.1#parent">http://purl.org/gen/0.1#parent</seealso>
    let parent = Prefixed_Name(gen, "parent") |> PrefixedName
    /// <summary>
    ///   <para>gen:source</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A source justifying some assertion or claim of fact. The range is deliberately left as general as possible
    /// 		(owl:Thing) because of the unsettled state of bibliographic vocabularies. My recommendation is to use
    /// 		bibo:Document and its associated vocabulary, though frbr:Work seems reasonable, too. Surely there are
    /// 		many other options---hopefully a clear standard emerges in the future.</para>
    /// labels<para>Source</para></remarks>
    /// <seealso href="http://purl.org/gen/0.1#source">http://purl.org/gen/0.1#source</seealso>
    let source = Prefixed_Name(gen, "source") |> PrefixedName
    /// <summary>
    ///   <para>gen:stepFather</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A step-father of a family.</para>
    /// labels<para>stepFather</para></remarks>
    /// <seealso href="http://purl.org/gen/0.1#stepFather">http://purl.org/gen/0.1#stepFather</seealso>
    let stepFather = Prefixed_Name(gen, "stepFather") |> PrefixedName
    /// <summary>
    ///   <para>gen:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/gen/0.1#">http://purl.org/gen/0.1#</seealso>
    let _prefix_iri = Prefixed_Name(gen, "") |> PrefixedName
    /// <summary>
    ///   <para>gen:Family</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Though it is preferred to represent families by describing the relationships between its members
    /// 		(parent-child, husband-wife, etc.) this class can be used to represent a group of people who are
    /// 		considered to be a family unit.</para>
    /// labels<para>Family</para></remarks>
    /// <seealso href="http://purl.org/gen/0.1#Family">http://purl.org/gen/0.1#Family</seealso>
    let Family = Prefixed_Name(gen, "Family") |> PrefixedName

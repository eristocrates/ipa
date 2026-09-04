#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module lawd =
    let _prefixId = PrefixId.fromNamespaceLabel "http://lawd.info/ontology/" "lawd"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : An Agent is an abstract entity which has agency or is considered capable of acting in some way. Current subclasses include Deities and Persons.</para>
    ///   <a href="http://lawd.info/ontology/Agent">lawd:Agent</a>
    /// </summary>
    let Agent = _prefixId.prefix "Agent"
    /// <summary>
    ///   <para>rdfs:comment : A Written Work that collects together more than one Written Work.
    ///       Manuscripts are often AssembledWorks.</para>
    ///   <a href="http://lawd.info/ontology/AssembledWork">lawd:AssembledWork</a>
    /// </summary>
    let AssembledWork = _prefixId.prefix "AssembledWork"
    /// <summary>
    ///   <para>rdfs:comment : An Attestation models a piece of evidence for something in a text (e.g. the mention of a person in a document). Typically it is the conjunction of a Citation and an entity like a name or person.</para>
    ///   <a href="http://lawd.info/ontology/Attestation">lawd:Attestation</a>
    /// </summary>
    let Attestation = _prefixId.prefix "Attestation"
    /// <summary>
    ///   <para>rdfs:comment : A Citation models a bibliographic reference as a resource.</para>
    ///   <a href="http://lawd.info/ontology/Citation">lawd:Citation</a>
    /// </summary>
    let Citation = _prefixId.prefix "Citation"
    /// <summary>
    ///   <para>rdfs:comment : (Experimental) Part of a collation of witnesses to a text.^^xsd:string</para>
    ///   <a href="http://lawd.info/ontology/CollationItem">lawd:CollationItem</a>
    /// </summary>
    let CollationItem = _prefixId.prefix "CollationItem"
    /// <summary>
    ///   <para>rdfs:comment : A Conceptual Work groups together one or more Written Works which
    ///       have the same intellectual source. E.g. The Iliad, as opposed to a particular manuscript witness or edition of the Iliad.</para>
    ///   <a href="http://lawd.info/ontology/ConceptualWork">lawd:ConceptualWork</a>
    /// </summary>
    let ConceptualWork = _prefixId.prefix "ConceptualWork"
    /// <summary>
    ///   <para>rdfs:comment : Any divine Agent.^^xsd:string</para>
    ///   <a href="http://lawd.info/ontology/Deity">lawd:Deity</a>
    /// </summary>
    let Deity = _prefixId.prefix "Deity"
    /// <summary>
    ///   <para>rdfs:comment : A published (whether officially or not) Written Work that relies on
    ///       one or more Written Works as sources</para>
    ///   <a href="http://lawd.info/ontology/Edition">lawd:Edition</a>
    /// </summary>
    let Edition = _prefixId.prefix "Edition"
    let EditorialComment = _prefixId.prefix "EditorialComment"
    /// <summary>
    ///   <para>rdfs:comment : Superclass for types of evidence that support assertions.</para>
    ///   <a href="http://lawd.info/ontology/EvidentiaryItem">lawd:EvidentiaryItem</a>
    /// </summary>
    let EvidentiaryItem = _prefixId.prefix "EvidentiaryItem"
    /// <summary>
    ///   <para>rdfs:comment : A portion of a Written Work in a distinct hand. Written Works may
    ///       consist of one or more hands.</para>
    ///   <a href="http://lawd.info/ontology/Hand">lawd:Hand</a>
    /// </summary>
    let Hand = _prefixId.prefix "Hand"
    /// <summary>
    ///   <para>rdfs:comment : Class for non-human, non-divine Agents, e.g. Polyphemus or Medusa.^^xsd:string</para>
    ///   <a href="http://lawd.info/ontology/MythologicalCreature">lawd:MythologicalCreature</a>
    /// </summary>
    let MythologicalCreature = _prefixId.prefix "MythologicalCreature"
    /// <summary>
    ///   <para>rdfs:comment : A name is a resource providing a name for some thing. It may be specialized with subclasses like PersonalName or PlaceName</para>
    ///   <a href="http://lawd.info/ontology/Name">lawd:Name</a>
    /// </summary>
    let Name = _prefixId.prefix "Name"
    /// <summary>
    ///   <para>rdfs:comment : Any person, whether historical, mythological, or fictional^^xsd:string</para>
    ///   <a href="http://lawd.info/ontology/Person">lawd:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>rdfs:comment : A name belonging to a lawd:Person</para>
    ///   <a href="http://lawd.info/ontology/PersonalName">lawd:PersonalName</a>
    /// </summary>
    let PersonalName = _prefixId.prefix "PersonalName"
    /// <summary>
    ///   <para>rdfs:comment : Any conceivable place, such as a town, a mountain, or the site of a building.</para>
    ///   <a href="http://lawd.info/ontology/Place">lawd:Place</a>
    /// </summary>
    let Place = _prefixId.prefix "Place"
    /// <summary>
    ///   <para>rdfs:comment : The name of a lawd:Place</para>
    ///   <a href="http://lawd.info/ontology/PlaceName">lawd:PlaceName</a>
    /// </summary>
    let PlaceName = _prefixId.prefix "PlaceName"
    /// <summary>
    ///   <para>rdfs:comment : (Experimental) The superclass for members of the readingScheme concept scheme. A Reading is a word, phrase, or larger chunk of text from a witness (or any observation of variance concerning the text, such as an omission or interpolation).</para>
    ///   <a href="http://lawd.info/ontology/Reading">lawd:Reading</a>
    /// </summary>
    let Reading = _prefixId.prefix "Reading"
    let Reference = _prefixId.prefix "Reference"
    /// <summary>
    ///   <para>rdfs:comment : An ordered collection that maps Written Works used as sources for an
    ///       Edition to symbols used to represent them in the context of that Edition.</para>
    ///   <a href="http://lawd.info/ontology/Sigla">lawd:Sigla</a>
    /// </summary>
    let Sigla = _prefixId.prefix "Sigla"
    /// <summary>
    ///   <para>rdfs:comment : A Siglum represents a witness (a Written Work of some kind) and
    ///       associates it with a symbol used to represent that work in the context of an
    ///       Edition.</para>
    ///   <a href="http://lawd.info/ontology/Siglum">lawd:Siglum</a>
    /// </summary>
    let Siglum = _prefixId.prefix "Siglum"
    /// <summary>
    ///   <para>rdfs:comment : A Written Work that translates one or more other Written Works that embody the same Conceptual Work.</para>
    ///   <a href="http://lawd.info/ontology/Translation">lawd:Translation</a>
    /// </summary>
    let Translation = _prefixId.prefix "Translation"
    /// <summary>
    ///   <para>rdfs:comment : A written work, whether extant or not. May be considered to embody a Conceptual Work.</para>
    ///   <a href="http://lawd.info/ontology/WrittenWork">lawd:WrittenWork</a>
    /// </summary>
    let WrittenWork = _prefixId.prefix "WrittenWork"
    /// <summary>
    ///   <para>rdfs:comment : A label representing an abbreviated form of a name or title, e.g. of
    ///       an author or work. E.g. Homer -&gt; Hom.; Odyssey -&gt; Od.;</para>
    ///   <a href="http://lawd.info/ontology/abbreviation">lawd:abbreviation</a>
    /// </summary>
    let abbreviation = _prefixId.prefix "abbreviation"
    let addition = _prefixId.prefix "addition"
    let agreement = _prefixId.prefix "agreement"
    let collation = _prefixId.prefix "collation"
    let conjecture = _prefixId.prefix "conjecture"
    /// <summary>
    ///   <para>rdfs:comment : Indicates that a piece of evidence (any subclass of lawd:EvidentiaryItem) is joined to another—for example because they co-occur.</para>
    ///   <a href="http://lawd.info/ontology/conjunctOf">lawd:conjunctOf</a>
    /// </summary>
    let conjunctOf = _prefixId.prefix "conjunctOf"
    let correction = _prefixId.prefix "correction"
    let deletion = _prefixId.prefix "deletion"
    /// <summary>
    ///   <para>rdfs:comment : The relationship between a Written Work and the abstract Conceptual Work it embodies. For example, the OCT text of Homer's Iliad's relationship to the idea of Homer's Iliad.</para>
    ///   <a href="http://lawd.info/ontology/embodies">lawd:embodies</a>
    /// </summary>
    let embodies = _prefixId.prefix "embodies"
    /// <summary>
    ///   <para>rdfs:comment : The place where an artifact was discovered.</para>
    ///   <a href="http://lawd.info/ontology/foundAt">lawd:foundAt</a>
    /// </summary>
    let foundAt = _prefixId.prefix "foundAt"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a lawd:Attestation providing evidence for a name, etc.</para>
    ///   <a href="http://lawd.info/ontology/hasAttestation">lawd:hasAttestation</a>
    /// </summary>
    let hasAttestation = _prefixId.prefix "hasAttestation"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a Citation that contains the source for a lawd:Attestation</para>
    ///   <a href="http://lawd.info/ontology/hasCitation">lawd:hasCitation</a>
    /// </summary>
    let hasCitation = _prefixId.prefix "hasCitation"
    /// <summary>
    ///   <para>rdfs:comment : Indicates that (e.g.) a Person or Place has a lawd:Name that is the range of the property.</para>
    ///   <a href="http://lawd.info/ontology/hasName">lawd:hasName</a>
    /// </summary>
    let hasName = _prefixId.prefix "hasName"
    let interpolation = _prefixId.prefix "interpolation"
    let intervention = _prefixId.prefix "intervention"
    let omission = _prefixId.prefix "omission"
    /// <summary>
    ///   <para>rdfs:comment : The place where an artifact originated.</para>
    ///   <a href="http://lawd.info/ontology/origin">lawd:origin</a>
    /// </summary>
    let origin = _prefixId.prefix "origin"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the primary form of a lawd:Name</para>
    ///   <a href="http://lawd.info/ontology/primaryForm">lawd:primaryForm</a>
    /// </summary>
    let primaryForm = _prefixId.prefix "primaryForm"
    let readingScheme = _prefixId.prefix "readingScheme"
    let readingType = _prefixId.prefix "readingType"
    let representedBy = _prefixId.prefix "representedBy"
    /// <summary>
    ///   <para>rdfs:comment : Describes the relationship between a Citation or Siglum and the
    ///       Written Work it indicates.</para>
    ///   <a href="http://lawd.info/ontology/represents">lawd:represents</a>
    /// </summary>
    let represents = _prefixId.prefix "represents"
    /// <summary>
    ///   <para>rdfs:comment : Connects a work of any type to the person, group, or insitution
    ///       responsible for the creation of the work.</para>
    ///   <a href="http://lawd.info/ontology/responsibleAgent">lawd:responsibleAgent</a>
    /// </summary>
    let responsibleAgent = _prefixId.prefix "responsibleAgent"
    /// <summary>
    ///   <para>rdfs:comment : Connects any kind of author or creator to the work he/she/it is
    ///       responsible for creating. The author may be anonymous or fictional.</para>
    ///   <a href="http://lawd.info/ontology/responsibleFor">lawd:responsibleFor</a>
    /// </summary>
    let responsibleFor = _prefixId.prefix "responsibleFor"
    let transposition = _prefixId.prefix "transposition"
    let uncertainReading = _prefixId.prefix "uncertainReading"
    let variant = _prefixId.prefix "variant"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a variant form of a lawd:Name</para>
    ///   <a href="http://lawd.info/ontology/variantForm">lawd:variantForm</a>
    /// </summary>
    let variantForm = _prefixId.prefix "variantForm"
    /// <summary>
    ///   <para>rdfs:comment : Generic location relation.</para>
    ///   <a href="http://lawd.info/ontology/where">lawd:where</a>
    /// </summary>
    let where = _prefixId.prefix "where"
    /// <summary>
    ///   <para>rdfs:comment : (Experimental) Connects an item in a collation to the witness it derives from.</para>
    ///   <a href="http://lawd.info/ontology/witness">lawd:witness</a>
    /// </summary>
    let witness = _prefixId.prefix "witness"

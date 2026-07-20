namespace http.lawd.info.ontology.slash

open DoxAletheia

module lawd =
    let _namespace_name = "http://lawd.info/ontology/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Any person, whether historical, mythological, or fictional
    /// <see href="http://lawd.info/ontology/Person"></see></summary>
    let Person = _prefix "Person"
    /// <summary>
    /// Any conceivable place, such as a town, a mountain, or the site of a building.
    /// <see href="http://lawd.info/ontology/Place"></see></summary>
    let Place = _prefix "Place"
    /// <summary>
    /// A written work, whether extant or not. May be considered to embody a Conceptual Work.
    /// <see href="http://lawd.info/ontology/WrittenWork"></see></summary>
    let WrittenWork = _prefix "WrittenWork"
    /// <summary>
    ///   <see href="http://lawd.info/ontology/1.0/"></see>
    /// </summary>
    let ``_1.0/`` = _prefix "1.0/"
    /// <summary>
    /// An Agent is an abstract entity which has agency or is considered capable of acting in some way. Current subclasses include Deities and Persons.
    /// <see href="http://lawd.info/ontology/Agent"></see></summary>
    let Agent = _prefix "Agent"
    /// <summary>
    /// A Written Work that collects together more than one Written Work.
    ///       Manuscripts are often AssembledWorks.
    /// <see href="http://lawd.info/ontology/AssembledWork"></see></summary>
    let AssembledWork = _prefix "AssembledWork"
    /// <summary>
    /// An Attestation models a piece of evidence for something in a text (e.g. the mention of a person in a document). Typically it is the conjunction of a Citation and an entity like a name or person.
    /// <see href="http://lawd.info/ontology/Attestation"></see></summary>
    let Attestation = _prefix "Attestation"
    /// <summary>
    /// Superclass for types of evidence that support assertions.
    /// <see href="http://lawd.info/ontology/EvidentiaryItem"></see></summary>
    let EvidentiaryItem = _prefix "EvidentiaryItem"
    /// <summary>
    /// A Citation models a bibliographic reference as a resource.
    /// <see href="http://lawd.info/ontology/Citation"></see></summary>
    let Citation = _prefix "Citation"
    /// <summary>
    /// (Experimental) Part of a collation of witnesses to a text.
    /// <see href="http://lawd.info/ontology/CollationItem"></see></summary>
    let CollationItem = _prefix "CollationItem"
    /// <summary>
    /// A Conceptual Work groups together one or more Written Works which
    ///       have the same intellectual source. E.g. The Iliad, as opposed to a particular manuscript witness or edition of the Iliad.
    /// <see href="http://lawd.info/ontology/ConceptualWork"></see></summary>
    let ConceptualWork = _prefix "ConceptualWork"
    /// <summary>
    /// Any divine Agent.
    /// <see href="http://lawd.info/ontology/Deity"></see></summary>
    let Deity = _prefix "Deity"
    /// <summary>
    /// A published (whether officially or not) Written Work that relies on
    ///       one or more Written Works as sources
    /// <see href="http://lawd.info/ontology/Edition"></see></summary>
    let Edition = _prefix "Edition"
    /// <summary>
    ///   <see href="http://lawd.info/ontology/EditorialComment"></see>
    /// </summary>
    let EditorialComment = _prefix "EditorialComment"
    /// <summary>
    /// A portion of a Written Work in a distinct hand. Written Works may
    ///       consist of one or more hands.
    /// <see href="http://lawd.info/ontology/Hand"></see></summary>
    let Hand = _prefix "Hand"
    /// <summary>
    /// Class for non-human, non-divine Agents, e.g. Polyphemus or Medusa.
    /// <see href="http://lawd.info/ontology/MythologicalCreature"></see></summary>
    let MythologicalCreature = _prefix "MythologicalCreature"
    /// <summary>
    /// A name is a resource providing a name for some thing. It may be specialized with subclasses like PersonalName or PlaceName
    /// <see href="http://lawd.info/ontology/Name"></see></summary>
    let Name = _prefix "Name"
    /// <summary>
    /// A name belonging to a lawd:Person
    /// <see href="http://lawd.info/ontology/PersonalName"></see></summary>
    let PersonalName = _prefix "PersonalName"
    /// <summary>
    /// The name of a lawd:Place
    /// <see href="http://lawd.info/ontology/PlaceName"></see></summary>
    let PlaceName = _prefix "PlaceName"
    /// <summary>
    /// (Experimental) The superclass for members of the readingScheme concept scheme. A Reading is a word, phrase, or larger chunk of text from a witness (or any observation of variance concerning the text, such as an omission or interpolation).
    /// <see href="http://lawd.info/ontology/Reading"></see></summary>
    let Reading = _prefix "Reading"
    /// <summary>
    ///   <see href="http://lawd.info/ontology/Reference"></see>
    /// </summary>
    let Reference = _prefix "Reference"
    /// <summary>
    /// An ordered collection that maps Written Works used as sources for an
    ///       Edition to symbols used to represent them in the context of that Edition.
    /// <see href="http://lawd.info/ontology/Sigla"></see></summary>
    let Sigla = _prefix "Sigla"
    /// <summary>
    /// A Siglum represents a witness (a Written Work of some kind) and
    ///       associates it with a symbol used to represent that work in the context of an
    ///       Edition.
    /// <see href="http://lawd.info/ontology/Siglum"></see></summary>
    let Siglum = _prefix "Siglum"
    /// <summary>
    /// A Written Work that translates one or more other Written Works that embody the same Conceptual Work.
    /// <see href="http://lawd.info/ontology/Translation"></see></summary>
    let Translation = _prefix "Translation"
    /// <summary>
    /// A label representing an abbreviated form of a name or title, e.g. of
    ///       an author or work. E.g. Homer -&gt; Hom.; Odyssey -&gt; Od.;
    /// <see href="http://lawd.info/ontology/abbreviation"></see></summary>
    let abbreviation = _prefix "abbreviation"
    /// <summary>
    ///   <see href="http://lawd.info/ontology/addition"></see>
    /// </summary>
    let addition = _prefix "addition"
    /// <summary>
    ///   <see href="http://lawd.info/ontology/variant"></see>
    /// </summary>
    let variant = _prefix "variant"
    /// <summary>
    /// (Experimental) The SKOS scheme for classifying types of lawd:Reading.
    /// <see href="http://lawd.info/ontology/readingScheme"></see></summary>
    let readingScheme = _prefix "readingScheme"
    /// <summary>
    ///   <see href="http://lawd.info/ontology/agreement"></see>
    /// </summary>
    let agreement = _prefix "agreement"
    /// <summary>
    /// a Motivation that represents the addition of a critical apparatus
    ///       comment upon a text
    /// <see href="http://lawd.info/ontology/collation"></see></summary>
    let collation = _prefix "collation"
    /// <summary>
    ///   <see href="http://lawd.info/ontology/conjecture"></see>
    /// </summary>
    let conjecture = _prefix "conjecture"
    /// <summary>
    /// Indicates that a piece of evidence (any subclass of lawd:EvidentiaryItem) is joined to another—for example because they co-occur.
    /// <see href="http://lawd.info/ontology/conjunctOf"></see></summary>
    let conjunctOf = _prefix "conjunctOf"
    /// <summary>
    ///   <see href="http://lawd.info/ontology/correction"></see>
    /// </summary>
    let correction = _prefix "correction"
    /// <summary>
    ///   <see href="http://lawd.info/ontology/intervention"></see>
    /// </summary>
    let intervention = _prefix "intervention"
    /// <summary>
    ///   <see href="http://lawd.info/ontology/deletion"></see>
    /// </summary>
    let deletion = _prefix "deletion"
    /// <summary>
    /// The relationship between a Written Work and the abstract Conceptual Work it embodies. For example, the OCT text of Homer's Iliad's relationship to the idea of Homer's Iliad.
    /// <see href="http://lawd.info/ontology/embodies"></see></summary>
    let embodies = _prefix "embodies"
    /// <summary>
    /// The place where an artifact was discovered.
    /// <see href="http://lawd.info/ontology/foundAt"></see></summary>
    let foundAt = _prefix "foundAt"
    /// <summary>
    /// Generic location relation.
    /// <see href="http://lawd.info/ontology/where"></see></summary>
    let where = _prefix "where"
    /// <summary>
    /// Indicates a lawd:Attestation providing evidence for a name, etc.
    /// <see href="http://lawd.info/ontology/hasAttestation"></see></summary>
    let hasAttestation = _prefix "hasAttestation"
    /// <summary>
    /// Indicates a Citation that contains the source for a lawd:Attestation
    /// <see href="http://lawd.info/ontology/hasCitation"></see></summary>
    let hasCitation = _prefix "hasCitation"
    /// <summary>
    /// Indicates that (e.g.) a Person or Place has a lawd:Name that is the range of the property.
    /// <see href="http://lawd.info/ontology/hasName"></see></summary>
    let hasName = _prefix "hasName"
    /// <summary>
    ///   <see href="http://lawd.info/ontology/interpolation"></see>
    /// </summary>
    let interpolation = _prefix "interpolation"
    /// <summary>
    ///   <see href="http://lawd.info/ontology/omission"></see>
    /// </summary>
    let omission = _prefix "omission"
    /// <summary>
    /// The place where an artifact originated.
    /// <see href="http://lawd.info/ontology/origin"></see></summary>
    let origin = _prefix "origin"
    /// <summary>
    /// Indicates the primary form of a lawd:Name
    /// <see href="http://lawd.info/ontology/primaryForm"></see></summary>
    let primaryForm = _prefix "primaryForm"
    /// <summary>
    ///   <see href="http://lawd.info/ontology/readingType"></see>
    /// </summary>
    let readingType = _prefix "readingType"
    /// <summary>
    ///   <see href="http://lawd.info/ontology/representedBy"></see>
    /// </summary>
    let representedBy = _prefix "representedBy"
    /// <summary>
    /// Describes the relationship between a Citation or Siglum and the
    ///       Written Work it indicates.
    /// <see href="http://lawd.info/ontology/represents"></see></summary>
    let represents = _prefix "represents"
    /// <summary>
    /// Connects a work of any type to the person, group, or insitution
    ///       responsible for the creation of the work.
    /// <see href="http://lawd.info/ontology/responsibleAgent"></see></summary>
    let responsibleAgent = _prefix "responsibleAgent"
    /// <summary>
    /// Connects any kind of author or creator to the work he/she/it is
    ///       responsible for creating. The author may be anonymous or fictional.
    /// <see href="http://lawd.info/ontology/responsibleFor"></see></summary>
    let responsibleFor = _prefix "responsibleFor"
    /// <summary>
    ///   <see href="http://lawd.info/ontology/transposition"></see>
    /// </summary>
    let transposition = _prefix "transposition"
    /// <summary>
    ///   <see href="http://lawd.info/ontology/uncertainReading"></see>
    /// </summary>
    let uncertainReading = _prefix "uncertainReading"
    /// <summary>
    /// Indicates a variant form of a lawd:Name
    /// <see href="http://lawd.info/ontology/variantForm"></see></summary>
    let variantForm = _prefix "variantForm"
    /// <summary>
    /// (Experimental) Connects an item in a collation to the witness it derives from.
    /// <see href="http://lawd.info/ontology/witness"></see></summary>
    let witness = _prefix "witness"

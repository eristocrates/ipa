namespace http.lawd.info.ontology.slash

open DoxAletheia.Rdf_Vocabulary

module lawd =
    let _namespace_name = "http://lawd.info/ontology/"
    /// <summary>
    /// Any person, whether historical, mythological, or fictional
    /// <see href="http://lawd.info/ontology/Person"></see></summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName
    /// <summary>
    /// Any conceivable place, such as a town, a mountain, or the site of a building.
    /// <see href="http://lawd.info/ontology/Place"></see></summary>
    let Place = Namespaced_IRI.parse _namespace_name "Place" |> NamespacedName

    /// <summary>
    /// A written work, whether extant or not. May be considered to embody a Conceptual Work.
    /// <see href="http://lawd.info/ontology/WrittenWork"></see></summary>
    let WrittenWork =
        Namespaced_IRI.parse _namespace_name "WrittenWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://lawd.info/ontology/1.0/"></see>
    /// </summary>
    let ``_1.0/`` = Namespaced_IRI.parse _namespace_name "1.0/" |> NamespacedName
    /// <summary>
    /// An Agent is an abstract entity which has agency or is considered capable of acting in some way. Current subclasses include Deities and Persons.
    /// <see href="http://lawd.info/ontology/Agent"></see></summary>
    let Agent = Namespaced_IRI.parse _namespace_name "Agent" |> NamespacedName

    /// <summary>
    /// A Written Work that collects together more than one Written Work.
    ///       Manuscripts are often AssembledWorks.
    /// <see href="http://lawd.info/ontology/AssembledWork"></see></summary>
    let AssembledWork =
        Namespaced_IRI.parse _namespace_name "AssembledWork" |> NamespacedName

    /// <summary>
    /// An Attestation models a piece of evidence for something in a text (e.g. the mention of a person in a document). Typically it is the conjunction of a Citation and an entity like a name or person.
    /// <see href="http://lawd.info/ontology/Attestation"></see></summary>
    let Attestation =
        Namespaced_IRI.parse _namespace_name "Attestation" |> NamespacedName

    /// <summary>
    /// Superclass for types of evidence that support assertions.
    /// <see href="http://lawd.info/ontology/EvidentiaryItem"></see></summary>
    let EvidentiaryItem =
        Namespaced_IRI.parse _namespace_name "EvidentiaryItem" |> NamespacedName

    /// <summary>
    /// A Citation models a bibliographic reference as a resource.
    /// <see href="http://lawd.info/ontology/Citation"></see></summary>
    let Citation = Namespaced_IRI.parse _namespace_name "Citation" |> NamespacedName

    /// <summary>
    /// (Experimental) Part of a collation of witnesses to a text.
    /// <see href="http://lawd.info/ontology/CollationItem"></see></summary>
    let CollationItem =
        Namespaced_IRI.parse _namespace_name "CollationItem" |> NamespacedName

    /// <summary>
    /// A Conceptual Work groups together one or more Written Works which
    ///       have the same intellectual source. E.g. The Iliad, as opposed to a particular manuscript witness or edition of the Iliad.
    /// <see href="http://lawd.info/ontology/ConceptualWork"></see></summary>
    let ConceptualWork =
        Namespaced_IRI.parse _namespace_name "ConceptualWork" |> NamespacedName

    /// <summary>
    /// Any divine Agent.
    /// <see href="http://lawd.info/ontology/Deity"></see></summary>
    let Deity = Namespaced_IRI.parse _namespace_name "Deity" |> NamespacedName
    /// <summary>
    /// A published (whether officially or not) Written Work that relies on
    ///       one or more Written Works as sources
    /// <see href="http://lawd.info/ontology/Edition"></see></summary>
    let Edition = Namespaced_IRI.parse _namespace_name "Edition" |> NamespacedName

    /// <summary>
    ///   <see href="http://lawd.info/ontology/EditorialComment"></see>
    /// </summary>
    let EditorialComment =
        Namespaced_IRI.parse _namespace_name "EditorialComment" |> NamespacedName

    /// <summary>
    /// A portion of a Written Work in a distinct hand. Written Works may
    ///       consist of one or more hands.
    /// <see href="http://lawd.info/ontology/Hand"></see></summary>
    let Hand = Namespaced_IRI.parse _namespace_name "Hand" |> NamespacedName

    /// <summary>
    /// Class for non-human, non-divine Agents, e.g. Polyphemus or Medusa.
    /// <see href="http://lawd.info/ontology/MythologicalCreature"></see></summary>
    let MythologicalCreature =
        Namespaced_IRI.parse _namespace_name "MythologicalCreature" |> NamespacedName

    /// <summary>
    /// A name is a resource providing a name for some thing. It may be specialized with subclasses like PersonalName or PlaceName
    /// <see href="http://lawd.info/ontology/Name"></see></summary>
    let Name = Namespaced_IRI.parse _namespace_name "Name" |> NamespacedName

    /// <summary>
    /// A name belonging to a lawd:Person
    /// <see href="http://lawd.info/ontology/PersonalName"></see></summary>
    let PersonalName =
        Namespaced_IRI.parse _namespace_name "PersonalName" |> NamespacedName

    /// <summary>
    /// The name of a lawd:Place
    /// <see href="http://lawd.info/ontology/PlaceName"></see></summary>
    let PlaceName = Namespaced_IRI.parse _namespace_name "PlaceName" |> NamespacedName
    /// <summary>
    /// (Experimental) The superclass for members of the readingScheme concept scheme. A Reading is a word, phrase, or larger chunk of text from a witness (or any observation of variance concerning the text, such as an omission or interpolation).
    /// <see href="http://lawd.info/ontology/Reading"></see></summary>
    let Reading = Namespaced_IRI.parse _namespace_name "Reading" |> NamespacedName
    /// <summary>
    ///   <see href="http://lawd.info/ontology/Reference"></see>
    /// </summary>
    let Reference = Namespaced_IRI.parse _namespace_name "Reference" |> NamespacedName
    /// <summary>
    /// An ordered collection that maps Written Works used as sources for an
    ///       Edition to symbols used to represent them in the context of that Edition.
    /// <see href="http://lawd.info/ontology/Sigla"></see></summary>
    let Sigla = Namespaced_IRI.parse _namespace_name "Sigla" |> NamespacedName
    /// <summary>
    /// A Siglum represents a witness (a Written Work of some kind) and
    ///       associates it with a symbol used to represent that work in the context of an
    ///       Edition.
    /// <see href="http://lawd.info/ontology/Siglum"></see></summary>
    let Siglum = Namespaced_IRI.parse _namespace_name "Siglum" |> NamespacedName

    /// <summary>
    /// A Written Work that translates one or more other Written Works that embody the same Conceptual Work.
    /// <see href="http://lawd.info/ontology/Translation"></see></summary>
    let Translation =
        Namespaced_IRI.parse _namespace_name "Translation" |> NamespacedName

    /// <summary>
    /// A label representing an abbreviated form of a name or title, e.g. of
    ///       an author or work. E.g. Homer -&gt; Hom.; Odyssey -&gt; Od.;
    /// <see href="http://lawd.info/ontology/abbreviation"></see></summary>
    let abbreviation =
        Namespaced_IRI.parse _namespace_name "abbreviation" |> NamespacedName

    /// <summary>
    ///   <see href="http://lawd.info/ontology/addition"></see>
    /// </summary>
    let addition = Namespaced_IRI.parse _namespace_name "addition" |> NamespacedName
    /// <summary>
    ///   <see href="http://lawd.info/ontology/variant"></see>
    /// </summary>
    let variant = Namespaced_IRI.parse _namespace_name "variant" |> NamespacedName

    /// <summary>
    /// (Experimental) The SKOS scheme for classifying types of lawd:Reading.
    /// <see href="http://lawd.info/ontology/readingScheme"></see></summary>
    let readingScheme =
        Namespaced_IRI.parse _namespace_name "readingScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://lawd.info/ontology/agreement"></see>
    /// </summary>
    let agreement = Namespaced_IRI.parse _namespace_name "agreement" |> NamespacedName
    /// <summary>
    /// a Motivation that represents the addition of a critical apparatus
    ///       comment upon a text
    /// <see href="http://lawd.info/ontology/collation"></see></summary>
    let collation = Namespaced_IRI.parse _namespace_name "collation" |> NamespacedName
    /// <summary>
    ///   <see href="http://lawd.info/ontology/conjecture"></see>
    /// </summary>
    let conjecture = Namespaced_IRI.parse _namespace_name "conjecture" |> NamespacedName
    /// <summary>
    /// Indicates that a piece of evidence (any subclass of lawd:EvidentiaryItem) is joined to another—for example because they co-occur.
    /// <see href="http://lawd.info/ontology/conjunctOf"></see></summary>
    let conjunctOf = Namespaced_IRI.parse _namespace_name "conjunctOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://lawd.info/ontology/correction"></see>
    /// </summary>
    let correction = Namespaced_IRI.parse _namespace_name "correction" |> NamespacedName

    /// <summary>
    ///   <see href="http://lawd.info/ontology/intervention"></see>
    /// </summary>
    let intervention =
        Namespaced_IRI.parse _namespace_name "intervention" |> NamespacedName

    /// <summary>
    ///   <see href="http://lawd.info/ontology/deletion"></see>
    /// </summary>
    let deletion = Namespaced_IRI.parse _namespace_name "deletion" |> NamespacedName
    /// <summary>
    /// The relationship between a Written Work and the abstract Conceptual Work it embodies. For example, the OCT text of Homer's Iliad's relationship to the idea of Homer's Iliad.
    /// <see href="http://lawd.info/ontology/embodies"></see></summary>
    let embodies = Namespaced_IRI.parse _namespace_name "embodies" |> NamespacedName
    /// <summary>
    /// The place where an artifact was discovered.
    /// <see href="http://lawd.info/ontology/foundAt"></see></summary>
    let foundAt = Namespaced_IRI.parse _namespace_name "foundAt" |> NamespacedName
    /// <summary>
    /// Generic location relation.
    /// <see href="http://lawd.info/ontology/where"></see></summary>
    let where = Namespaced_IRI.parse _namespace_name "where" |> NamespacedName

    /// <summary>
    /// Indicates a lawd:Attestation providing evidence for a name, etc.
    /// <see href="http://lawd.info/ontology/hasAttestation"></see></summary>
    let hasAttestation =
        Namespaced_IRI.parse _namespace_name "hasAttestation" |> NamespacedName

    /// <summary>
    /// Indicates a Citation that contains the source for a lawd:Attestation
    /// <see href="http://lawd.info/ontology/hasCitation"></see></summary>
    let hasCitation =
        Namespaced_IRI.parse _namespace_name "hasCitation" |> NamespacedName

    /// <summary>
    /// Indicates that (e.g.) a Person or Place has a lawd:Name that is the range of the property.
    /// <see href="http://lawd.info/ontology/hasName"></see></summary>
    let hasName = Namespaced_IRI.parse _namespace_name "hasName" |> NamespacedName

    /// <summary>
    ///   <see href="http://lawd.info/ontology/interpolation"></see>
    /// </summary>
    let interpolation =
        Namespaced_IRI.parse _namespace_name "interpolation" |> NamespacedName

    /// <summary>
    ///   <see href="http://lawd.info/ontology/omission"></see>
    /// </summary>
    let omission = Namespaced_IRI.parse _namespace_name "omission" |> NamespacedName
    /// <summary>
    /// The place where an artifact originated.
    /// <see href="http://lawd.info/ontology/origin"></see></summary>
    let origin = Namespaced_IRI.parse _namespace_name "origin" |> NamespacedName

    /// <summary>
    /// Indicates the primary form of a lawd:Name
    /// <see href="http://lawd.info/ontology/primaryForm"></see></summary>
    let primaryForm =
        Namespaced_IRI.parse _namespace_name "primaryForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://lawd.info/ontology/readingType"></see>
    /// </summary>
    let readingType =
        Namespaced_IRI.parse _namespace_name "readingType" |> NamespacedName

    /// <summary>
    ///   <see href="http://lawd.info/ontology/representedBy"></see>
    /// </summary>
    let representedBy =
        Namespaced_IRI.parse _namespace_name "representedBy" |> NamespacedName

    /// <summary>
    /// Describes the relationship between a Citation or Siglum and the
    ///       Written Work it indicates.
    /// <see href="http://lawd.info/ontology/represents"></see></summary>
    let represents = Namespaced_IRI.parse _namespace_name "represents" |> NamespacedName

    /// <summary>
    /// Connects a work of any type to the person, group, or insitution
    ///       responsible for the creation of the work.
    /// <see href="http://lawd.info/ontology/responsibleAgent"></see></summary>
    let responsibleAgent =
        Namespaced_IRI.parse _namespace_name "responsibleAgent" |> NamespacedName

    /// <summary>
    /// Connects any kind of author or creator to the work he/she/it is
    ///       responsible for creating. The author may be anonymous or fictional.
    /// <see href="http://lawd.info/ontology/responsibleFor"></see></summary>
    let responsibleFor =
        Namespaced_IRI.parse _namespace_name "responsibleFor" |> NamespacedName

    /// <summary>
    ///   <see href="http://lawd.info/ontology/transposition"></see>
    /// </summary>
    let transposition =
        Namespaced_IRI.parse _namespace_name "transposition" |> NamespacedName

    /// <summary>
    ///   <see href="http://lawd.info/ontology/uncertainReading"></see>
    /// </summary>
    let uncertainReading =
        Namespaced_IRI.parse _namespace_name "uncertainReading" |> NamespacedName

    /// <summary>
    /// Indicates a variant form of a lawd:Name
    /// <see href="http://lawd.info/ontology/variantForm"></see></summary>
    let variantForm =
        Namespaced_IRI.parse _namespace_name "variantForm" |> NamespacedName

    /// <summary>
    /// (Experimental) Connects an item in a collation to the witness it derives from.
    /// <see href="http://lawd.info/ontology/witness"></see></summary>
    let witness = Namespaced_IRI.parse _namespace_name "witness" |> NamespacedName

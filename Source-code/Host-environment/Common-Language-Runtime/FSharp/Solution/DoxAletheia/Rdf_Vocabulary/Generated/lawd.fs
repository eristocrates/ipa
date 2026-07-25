namespace http.lawd.info.ontology.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module lawd =
    let _namespace_iri = Namespace_Iri lawd |> NamespaceIRI
    /// <summary>
    ///   <para>lawd:</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/">http://lawd.info/ontology/</seealso>
    let _prefix_iri = Prefixed_Name(lawd, "") |> PrefixedName
    /// <summary>
    ///   <para>lawd:Edition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A published (whether officially or not) Written Work that relies on
    ///       one or more Written Works as sources</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/Edition">http://lawd.info/ontology/Edition</seealso>
    let Edition = Prefixed_Name(lawd, "Edition") |> PrefixedName
    /// <summary>
    ///   <para>lawd:Hand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A portion of a Written Work in a distinct hand. Written Works may
    ///       consist of one or more hands.</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/Hand">http://lawd.info/ontology/Hand</seealso>
    let Hand = Prefixed_Name(lawd, "Hand") |> PrefixedName
    /// <summary>
    ///   <para>lawd:PersonalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A name belonging to a lawd:Person</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/PersonalName">http://lawd.info/ontology/PersonalName</seealso>
    let PersonalName = Prefixed_Name(lawd, "PersonalName") |> PrefixedName
    /// <summary>
    ///   <para>lawd:Reading</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>(Experimental) The superclass for members of the readingScheme concept scheme. A Reading is a word, phrase, or larger chunk of text from a witness (or any observation of variance concerning the text, such as an omission or interpolation).</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/Reading">http://lawd.info/ontology/Reading</seealso>
    let Reading = Prefixed_Name(lawd, "Reading") |> PrefixedName
    /// <summary>
    ///   <para>lawd:Reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/Reference">http://lawd.info/ontology/Reference</seealso>
    let Reference = Prefixed_Name(lawd, "Reference") |> PrefixedName
    /// <summary>
    ///   <para>lawd:Sigla</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An ordered collection that maps Written Works used as sources for an
    ///       Edition to symbols used to represent them in the context of that Edition.</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/Sigla">http://lawd.info/ontology/Sigla</seealso>
    let Sigla = Prefixed_Name(lawd, "Sigla") |> PrefixedName
    /// <summary>
    ///   <para>lawd:readingScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>(Experimental) The SKOS scheme for classifying types of lawd:Reading.</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/readingScheme">http://lawd.info/ontology/readingScheme</seealso>
    let readingScheme = Prefixed_Name(lawd, "readingScheme") |> PrefixedName
    /// <summary>
    ///   <para>lawd:Place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any conceivable place, such as a town, a mountain, or the site of a building.</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/Place">http://lawd.info/ontology/Place</seealso>
    let Place = Prefixed_Name(lawd, "Place") |> PrefixedName

    /// <summary>
    ///   <para>lawd:MythologicalCreature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class for non-human, non-divine Agents, e.g. Polyphemus or Medusa.</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/MythologicalCreature">http://lawd.info/ontology/MythologicalCreature</seealso>
    let MythologicalCreature =
        Prefixed_Name(lawd, "MythologicalCreature") |> PrefixedName

    /// <summary>
    ///   <para>lawd:PlaceName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The name of a lawd:Place</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/PlaceName">http://lawd.info/ontology/PlaceName</seealso>
    let PlaceName = Prefixed_Name(lawd, "PlaceName") |> PrefixedName
    /// <summary>
    ///   <para>lawd:Translation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Written Work that translates one or more other Written Works that embody the same Conceptual Work.</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/Translation">http://lawd.info/ontology/Translation</seealso>
    let Translation = Prefixed_Name(lawd, "Translation") |> PrefixedName
    /// <summary>
    ///   <para>lawd:abbreviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A label representing an abbreviated form of a name or title, e.g. of
    ///       an author or work. E.g. Homer -&gt; Hom.; Odyssey -&gt; Od.;</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/abbreviation">http://lawd.info/ontology/abbreviation</seealso>
    let abbreviation = Prefixed_Name(lawd, "abbreviation") |> PrefixedName
    /// <summary>
    ///   <para>lawd:agreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>lawd:Reading</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/agreement">http://lawd.info/ontology/agreement</seealso>
    let agreement = Prefixed_Name(lawd, "agreement") |> PrefixedName
    /// <summary>
    ///   <para>lawd:collation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>oa:Motivation</para>
    ///   <para>a Motivation that represents the addition of a critical apparatus
    ///       comment upon a text</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/collation">http://lawd.info/ontology/collation</seealso>
    let collation = Prefixed_Name(lawd, "collation") |> PrefixedName
    /// <summary>
    ///   <para>lawd:conjecture</para>
    /// </summary>
    /// <remarks>
    ///   <para>lawd:Reading</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/conjecture">http://lawd.info/ontology/conjecture</seealso>
    let conjecture = Prefixed_Name(lawd, "conjecture") |> PrefixedName
    /// <summary>
    ///   <para>lawd:conjunctOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>Indicates that a piece of evidence (any subclass of lawd:EvidentiaryItem) is joined to another—for example because they co-occur.</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/conjunctOf">http://lawd.info/ontology/conjunctOf</seealso>
    let conjunctOf = Prefixed_Name(lawd, "conjunctOf") |> PrefixedName
    /// <summary>
    ///   <para>lawd:intervention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lawd:Reading</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/intervention">http://lawd.info/ontology/intervention</seealso>
    let intervention = Prefixed_Name(lawd, "intervention") |> PrefixedName
    /// <summary>
    ///   <para>lawd:deletion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lawd:Reading</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/deletion">http://lawd.info/ontology/deletion</seealso>
    let deletion = Prefixed_Name(lawd, "deletion") |> PrefixedName
    /// <summary>
    ///   <para>lawd:Attestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An Attestation models a piece of evidence for something in a text (e.g. the mention of a person in a document). Typically it is the conjunction of a Citation and an entity like a name or person.</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/Attestation">http://lawd.info/ontology/Attestation</seealso>
    let Attestation = Prefixed_Name(lawd, "Attestation") |> PrefixedName
    /// <summary>
    ///   <para>lawd:1.0/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lawd.info/ontology/1.0/">http://lawd.info/ontology/1.0/</seealso>
    let ``_1.0/`` = Prefixed_Name(lawd, "1.0/") |> PrefixedName
    /// <summary>
    ///   <para>lawd:AssembledWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Written Work that collects together more than one Written Work.
    ///       Manuscripts are often AssembledWorks.</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/AssembledWork">http://lawd.info/ontology/AssembledWork</seealso>
    let AssembledWork = Prefixed_Name(lawd, "AssembledWork") |> PrefixedName
    /// <summary>
    ///   <para>lawd:Deity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any divine Agent.</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/Deity">http://lawd.info/ontology/Deity</seealso>
    let Deity = Prefixed_Name(lawd, "Deity") |> PrefixedName
    /// <summary>
    ///   <para>lawd:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An Agent is an abstract entity which has agency or is considered capable of acting in some way. Current subclasses include Deities and Persons.</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/Agent">http://lawd.info/ontology/Agent</seealso>
    let Agent = Prefixed_Name(lawd, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>lawd:Citation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Citation models a bibliographic reference as a resource.</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/Citation">http://lawd.info/ontology/Citation</seealso>
    let Citation = Prefixed_Name(lawd, "Citation") |> PrefixedName
    /// <summary>
    ///   <para>lawd:CollationItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>(Experimental) Part of a collation of witnesses to a text.</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/CollationItem">http://lawd.info/ontology/CollationItem</seealso>
    let CollationItem = Prefixed_Name(lawd, "CollationItem") |> PrefixedName
    /// <summary>
    ///   <para>lawd:origin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The place where an artifact originated.</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/origin">http://lawd.info/ontology/origin</seealso>
    let origin = Prefixed_Name(lawd, "origin") |> PrefixedName
    /// <summary>
    ///   <para>lawd:representedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/representedBy">http://lawd.info/ontology/representedBy</seealso>
    let representedBy = Prefixed_Name(lawd, "representedBy") |> PrefixedName
    /// <summary>
    ///   <para>lawd:EvidentiaryItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Superclass for types of evidence that support assertions.</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/EvidentiaryItem">http://lawd.info/ontology/EvidentiaryItem</seealso>
    let EvidentiaryItem = Prefixed_Name(lawd, "EvidentiaryItem") |> PrefixedName
    /// <summary>
    ///   <para>lawd:ConceptualWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Conceptual Work groups together one or more Written Works which
    ///       have the same intellectual source. E.g. The Iliad, as opposed to a particular manuscript witness or edition of the Iliad.</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/ConceptualWork">http://lawd.info/ontology/ConceptualWork</seealso>
    let ConceptualWork = Prefixed_Name(lawd, "ConceptualWork") |> PrefixedName
    /// <summary>
    ///   <para>lawd:EditorialComment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/EditorialComment">http://lawd.info/ontology/EditorialComment</seealso>
    let EditorialComment = Prefixed_Name(lawd, "EditorialComment") |> PrefixedName
    /// <summary>
    ///   <para>lawd:Name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A name is a resource providing a name for some thing. It may be specialized with subclasses like PersonalName or PlaceName</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/Name">http://lawd.info/ontology/Name</seealso>
    let Name = Prefixed_Name(lawd, "Name") |> PrefixedName
    /// <summary>
    ///   <para>lawd:Siglum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Siglum represents a witness (a Written Work of some kind) and
    ///       associates it with a symbol used to represent that work in the context of an
    ///       Edition.</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/Siglum">http://lawd.info/ontology/Siglum</seealso>
    let Siglum = Prefixed_Name(lawd, "Siglum") |> PrefixedName
    /// <summary>
    ///   <para>lawd:variant</para>
    /// </summary>
    /// <remarks>
    ///   <para>lawd:Reading</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/variant">http://lawd.info/ontology/variant</seealso>
    let variant = Prefixed_Name(lawd, "variant") |> PrefixedName
    /// <summary>
    ///   <para>lawd:correction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lawd:Reading</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/correction">http://lawd.info/ontology/correction</seealso>
    let correction = Prefixed_Name(lawd, "correction") |> PrefixedName
    /// <summary>
    ///   <para>lawd:embodies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The relationship between a Written Work and the abstract Conceptual Work it embodies. For example, the OCT text of Homer's Iliad's relationship to the idea of Homer's Iliad.</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/embodies">http://lawd.info/ontology/embodies</seealso>
    let embodies = Prefixed_Name(lawd, "embodies") |> PrefixedName
    /// <summary>
    ///   <para>lawd:foundAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The place where an artifact was discovered.</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/foundAt">http://lawd.info/ontology/foundAt</seealso>
    let foundAt = Prefixed_Name(lawd, "foundAt") |> PrefixedName
    /// <summary>
    ///   <para>lawd:where</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Generic location relation.</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/where">http://lawd.info/ontology/where</seealso>
    let where = Prefixed_Name(lawd, "where") |> PrefixedName
    /// <summary>
    ///   <para>lawd:hasCitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates a Citation that contains the source for a lawd:Attestation</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/hasCitation">http://lawd.info/ontology/hasCitation</seealso>
    let hasCitation = Prefixed_Name(lawd, "hasCitation") |> PrefixedName
    /// <summary>
    ///   <para>lawd:interpolation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lawd:Reading</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/interpolation">http://lawd.info/ontology/interpolation</seealso>
    let interpolation = Prefixed_Name(lawd, "interpolation") |> PrefixedName
    /// <summary>
    ///   <para>lawd:hasAttestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates a lawd:Attestation providing evidence for a name, etc.</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/hasAttestation">http://lawd.info/ontology/hasAttestation</seealso>
    let hasAttestation = Prefixed_Name(lawd, "hasAttestation") |> PrefixedName
    /// <summary>
    ///   <para>lawd:hasName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that (e.g.) a Person or Place has a lawd:Name that is the range of the property.</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/hasName">http://lawd.info/ontology/hasName</seealso>
    let hasName = Prefixed_Name(lawd, "hasName") |> PrefixedName
    /// <summary>
    ///   <para>lawd:omission</para>
    /// </summary>
    /// <remarks>
    ///   <para>lawd:Reading</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/omission">http://lawd.info/ontology/omission</seealso>
    let omission = Prefixed_Name(lawd, "omission") |> PrefixedName
    /// <summary>
    ///   <para>lawd:primaryForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates the primary form of a lawd:Name</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/primaryForm">http://lawd.info/ontology/primaryForm</seealso>
    let primaryForm = Prefixed_Name(lawd, "primaryForm") |> PrefixedName
    /// <summary>
    ///   <para>lawd:readingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/readingType">http://lawd.info/ontology/readingType</seealso>
    let readingType = Prefixed_Name(lawd, "readingType") |> PrefixedName
    /// <summary>
    ///   <para>lawd:responsibleAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Connects a work of any type to the person, group, or insitution
    ///       responsible for the creation of the work.</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/responsibleAgent">http://lawd.info/ontology/responsibleAgent</seealso>
    let responsibleAgent = Prefixed_Name(lawd, "responsibleAgent") |> PrefixedName
    /// <summary>
    ///   <para>lawd:responsibleFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Connects any kind of author or creator to the work he/she/it is
    ///       responsible for creating. The author may be anonymous or fictional.</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/responsibleFor">http://lawd.info/ontology/responsibleFor</seealso>
    let responsibleFor = Prefixed_Name(lawd, "responsibleFor") |> PrefixedName
    /// <summary>
    ///   <para>lawd:transposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>lawd:Reading</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/transposition">http://lawd.info/ontology/transposition</seealso>
    let transposition = Prefixed_Name(lawd, "transposition") |> PrefixedName
    /// <summary>
    ///   <para>lawd:variantForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates a variant form of a lawd:Name</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/variantForm">http://lawd.info/ontology/variantForm</seealso>
    let variantForm = Prefixed_Name(lawd, "variantForm") |> PrefixedName
    /// <summary>
    ///   <para>lawd:represents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the relationship between a Citation or Siglum and the
    ///       Written Work it indicates.</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/represents">http://lawd.info/ontology/represents</seealso>
    let represents = Prefixed_Name(lawd, "represents") |> PrefixedName
    /// <summary>
    ///   <para>lawd:uncertainReading</para>
    /// </summary>
    /// <remarks>
    ///   <para>lawd:Reading</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/uncertainReading">http://lawd.info/ontology/uncertainReading</seealso>
    let uncertainReading = Prefixed_Name(lawd, "uncertainReading") |> PrefixedName
    /// <summary>
    ///   <para>lawd:witness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>(Experimental) Connects an item in a collation to the witness it derives from.</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/witness">http://lawd.info/ontology/witness</seealso>
    let witness = Prefixed_Name(lawd, "witness") |> PrefixedName
    /// <summary>
    ///   <para>lawd:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any person, whether historical, mythological, or fictional</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/Person">http://lawd.info/ontology/Person</seealso>
    let Person = Prefixed_Name(lawd, "Person") |> PrefixedName
    /// <summary>
    ///   <para>lawd:WrittenWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A written work, whether extant or not. May be considered to embody a Conceptual Work.</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/WrittenWork">http://lawd.info/ontology/WrittenWork</seealso>
    let WrittenWork = Prefixed_Name(lawd, "WrittenWork") |> PrefixedName
    /// <summary>
    ///   <para>lawd:addition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lawd:Reading</para>
    /// </remarks>
    /// <seealso href="http://lawd.info/ontology/addition">http://lawd.info/ontology/addition</seealso>
    let addition = Prefixed_Name(lawd, "addition") |> PrefixedName

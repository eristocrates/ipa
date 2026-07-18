namespace http.onto.dm2e.eu.schemas.dm2e.slash

open DoxAletheia.Rdf_Vocabulary

module dm2e =
    let _namespace_name = "http://onto.dm2e.eu/schemas/dm2e/"
    /// <summary>
    /// The collection of CHOs as provided by a data provider.
    /// <see href="http://onto.dm2e.eu/schemas/dm2e/Collection"></see></summary>
    let Collection = Namespaced_IRI.parse _namespace_name "Collection" |> NamespacedName

    /// <summary>
    /// The dataset that contains the RDF statements provided in via this data resource.
    /// <see href="http://onto.dm2e.eu/schemas/dm2e/DataResource"></see></summary>
    let DataResource =
        Namespaced_IRI.parse _namespace_name "DataResource" |> NamespacedName

    /// <summary>
    /// ProvidedCHO of type document. Unlike foaf:Document, dm2e:Document refers to a physical document.
    /// <see href="http://onto.dm2e.eu/schemas/dm2e/Document"></see></summary>
    let Document = Namespaced_IRI.parse _namespace_name "Document" |> NamespacedName
    /// <summary>
    /// Archival Item.
    /// <see href="http://onto.dm2e.eu/schemas/dm2e/File"></see></summary>
    let File = Namespaced_IRI.parse _namespace_name "File" |> NamespacedName
    /// <summary>
    /// A physical fragment of a document, e.g. a collection of pages of a manuscript.
    /// <see href="http://onto.dm2e.eu/schemas/dm2e/Fragment"></see></summary>
    let Fragment = Namespaced_IRI.parse _namespace_name "Fragment" |> NamespacedName
    /// <summary>
    /// ProvidedCHO of type manuscript, e.g. Wittgensteins brown book. Not equivalent to bibo:Manuscript. Not equivalent to bibo:Manuscript.
    /// <see href="http://onto.dm2e.eu/schemas/dm2e/Manuscript"></see></summary>
    let Manuscript = Namespaced_IRI.parse _namespace_name "Manuscript" |> NamespacedName
    /// <summary>
    /// One side of a sheet of paper. Can be part of another CHO, e.g. dm2e:Manuscript.
    /// <see href="http://onto.dm2e.eu/schemas/dm2e/Page"></see></summary>
    let Page = Namespaced_IRI.parse _namespace_name "Page" |> NamespacedName
    /// <summary>
    /// ProvidedCHO of type paragraph. Can be part of another (textual) CHO, e.g. dm2e:Manuscript.
    /// <see href="http://onto.dm2e.eu/schemas/dm2e/Paragraph"></see></summary>
    let Paragraph = Namespaced_IRI.parse _namespace_name "Paragraph" |> NamespacedName
    /// <summary>
    /// ProvidedCHO of type photo.
    /// <see href="http://onto.dm2e.eu/schemas/dm2e/Photo"></see></summary>
    let Photo = Namespaced_IRI.parse _namespace_name "Photo" |> NamespacedName
    /// <summary>
    /// ProvidedCHO of type poster. Basically any piece of printed paper (often on a large sheet) that can be attached to a wall. dm2e:Poster does also include, but is not restricted to, conference posters.
    /// <see href="http://onto.dm2e.eu/schemas/dm2e/Poster"></see></summary>
    let Poster = Namespaced_IRI.parse _namespace_name "Poster" |> NamespacedName
    /// <summary>
    /// A non-physical piece of work of an agent, e.g. the theoretical concept of a manuscript.
    /// <see href="http://onto.dm2e.eu/schemas/dm2e/Work"></see></summary>
    let Work = Namespaced_IRI.parse _namespace_name "Work" |> NamespacedName
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/artist"></see>
    /// </summary>
    let artist = Namespaced_IRI.parse _namespace_name "artist" |> NamespacedName
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/callNumber"></see>
    /// </summary>
    let callNumber = Namespaced_IRI.parse _namespace_name "callNumber" |> NamespacedName
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/composer"></see>
    /// </summary>
    let composer = Namespaced_IRI.parse _namespace_name "composer" |> NamespacedName
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/copyist"></see>
    /// </summary>
    let copyist = Namespaced_IRI.parse _namespace_name "copyist" |> NamespacedName
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/cover"></see>
    /// </summary>
    let cover = Namespaced_IRI.parse _namespace_name "cover" |> NamespacedName

    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/displayLevel"></see>
    /// </summary>
    let displayLevel =
        Namespaced_IRI.parse _namespace_name "displayLevel" |> NamespacedName

    /// <summary>
    /// Final words of a manuscript. A language tag in ISO 639-2 should be added to the Literal.
    /// <see href="http://onto.dm2e.eu/schemas/dm2e/explicit"></see></summary>
    let explicit = Namespaced_IRI.parse _namespace_name "explicit" |> NamespacedName
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/genre"></see>
    /// </summary>
    let genre = Namespaced_IRI.parse _namespace_name "genre" |> NamespacedName

    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/hasAnnotatableVersionAt"></see>
    /// </summary>
    let hasAnnotatableVersionAt =
        Namespaced_IRI.parse _namespace_name "hasAnnotatableVersionAt" |> NamespacedName

    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/holdingInstitution"></see>
    /// </summary>
    let holdingInstitution =
        Namespaced_IRI.parse _namespace_name "holdingInstitution" |> NamespacedName

    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/honoree"></see>
    /// </summary>
    let honoree = Namespaced_IRI.parse _namespace_name "honoree" |> NamespacedName

    /// <summary>
    /// Generic description of illustrations in the CHO.
    /// <see href="http://onto.dm2e.eu/schemas/dm2e/illustration"></see></summary>
    let illustration =
        Namespaced_IRI.parse _namespace_name "illustration" |> NamespacedName

    /// <summary>
    /// Opening words of a manuscript. A language tag in ISO 639-2 should be added to the Literal.
    /// <see href="http://onto.dm2e.eu/schemas/dm2e/incipit"></see></summary>
    let incipit = Namespaced_IRI.parse _namespace_name "incipit" |> NamespacedName

    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/levelOfHierarchy"></see>
    /// </summary>
    let levelOfHierarchy =
        Namespaced_IRI.parse _namespace_name "levelOfHierarchy" |> NamespacedName

    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/mentioned"></see>
    /// </summary>
    let mentioned = Namespaced_IRI.parse _namespace_name "mentioned" |> NamespacedName

    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/modeOfAcquisition"></see>
    /// </summary>
    let modeOfAcquisition =
        Namespaced_IRI.parse _namespace_name "modeOfAcquisition" |> NamespacedName

    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/owner"></see>
    /// </summary>
    let owner = Namespaced_IRI.parse _namespace_name "owner" |> NamespacedName

    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/pageDimension"></see>
    /// </summary>
    let pageDimension =
        Namespaced_IRI.parse _namespace_name "pageDimension" |> NamespacedName

    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/painter"></see>
    /// </summary>
    let painter = Namespaced_IRI.parse _namespace_name "painter" |> NamespacedName
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/portrayed"></see>
    /// </summary>
    let portrayed = Namespaced_IRI.parse _namespace_name "portrayed" |> NamespacedName

    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/previousOwner"></see>
    /// </summary>
    let previousOwner =
        Namespaced_IRI.parse _namespace_name "previousOwner" |> NamespacedName

    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/principal"></see>
    /// </summary>
    let principal = Namespaced_IRI.parse _namespace_name "principal" |> NamespacedName
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/printedAt"></see>
    /// </summary>
    let printedAt = Namespaced_IRI.parse _namespace_name "printedAt" |> NamespacedName

    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/publishedAt"></see>
    /// </summary>
    let publishedAt =
        Namespaced_IRI.parse _namespace_name "publishedAt" |> NamespacedName

    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/refersTo"></see>
    /// </summary>
    let refersTo = Namespaced_IRI.parse _namespace_name "refersTo" |> NamespacedName
    /// <summary>
    /// This property describes the dm2e-specific usage of the resource.
    /// <see href="http://onto.dm2e.eu/schemas/dm2e/scopeNote"></see></summary>
    let scopeNote = Namespaced_IRI.parse _namespace_name "scopeNote" |> NamespacedName

    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/shelfmarkLocation"></see>
    /// </summary>
    let shelfmarkLocation =
        Namespaced_IRI.parse _namespace_name "shelfmarkLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/sponsor"></see>
    /// </summary>
    let sponsor = Namespaced_IRI.parse _namespace_name "sponsor" |> NamespacedName
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/subtitle"></see>
    /// </summary>
    let subtitle = Namespaced_IRI.parse _namespace_name "subtitle" |> NamespacedName
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/support"></see>
    /// </summary>
    let support = Namespaced_IRI.parse _namespace_name "support" |> NamespacedName
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/watermark"></see>
    /// </summary>
    let watermark = Namespaced_IRI.parse _namespace_name "watermark" |> NamespacedName
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/writer"></see>
    /// </summary>
    let writer = Namespaced_IRI.parse _namespace_name "writer" |> NamespacedName

    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/writtenAreaDimension"></see>
    /// </summary>
    let writtenAreaDimension =
        Namespaced_IRI.parse _namespace_name "writtenAreaDimension" |> NamespacedName

    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/writtenAt"></see>
    /// </summary>
    let writtenAt = Namespaced_IRI.parse _namespace_name "writtenAt" |> NamespacedName

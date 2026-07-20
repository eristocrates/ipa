namespace http.onto.dm2e.eu.schemas.dm2e.slash

open DoxAletheia

module dm2e =
    let _namespace_name = "http://onto.dm2e.eu/schemas/dm2e/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The collection of CHOs as provided by a data provider.
    /// <see href="http://onto.dm2e.eu/schemas/dm2e/Collection"></see></summary>
    let Collection = _prefix "Collection"
    /// <summary>
    /// The dataset that contains the RDF statements provided in via this data resource.
    /// <see href="http://onto.dm2e.eu/schemas/dm2e/DataResource"></see></summary>
    let DataResource = _prefix "DataResource"
    /// <summary>
    /// ProvidedCHO of type document. Unlike foaf:Document, dm2e:Document refers to a physical document.
    /// <see href="http://onto.dm2e.eu/schemas/dm2e/Document"></see></summary>
    let Document = _prefix "Document"
    /// <summary>
    /// Archival Item.
    /// <see href="http://onto.dm2e.eu/schemas/dm2e/File"></see></summary>
    let File = _prefix "File"
    /// <summary>
    /// A physical fragment of a document, e.g. a collection of pages of a manuscript.
    /// <see href="http://onto.dm2e.eu/schemas/dm2e/Fragment"></see></summary>
    let Fragment = _prefix "Fragment"
    /// <summary>
    /// ProvidedCHO of type manuscript, e.g. Wittgensteins brown book. Not equivalent to bibo:Manuscript. Not equivalent to bibo:Manuscript.
    /// <see href="http://onto.dm2e.eu/schemas/dm2e/Manuscript"></see></summary>
    let Manuscript = _prefix "Manuscript"
    /// <summary>
    /// One side of a sheet of paper. Can be part of another CHO, e.g. dm2e:Manuscript.
    /// <see href="http://onto.dm2e.eu/schemas/dm2e/Page"></see></summary>
    let Page = _prefix "Page"
    /// <summary>
    /// ProvidedCHO of type paragraph. Can be part of another (textual) CHO, e.g. dm2e:Manuscript.
    /// <see href="http://onto.dm2e.eu/schemas/dm2e/Paragraph"></see></summary>
    let Paragraph = _prefix "Paragraph"
    /// <summary>
    /// ProvidedCHO of type photo.
    /// <see href="http://onto.dm2e.eu/schemas/dm2e/Photo"></see></summary>
    let Photo = _prefix "Photo"
    /// <summary>
    /// ProvidedCHO of type poster. Basically any piece of printed paper (often on a large sheet) that can be attached to a wall. dm2e:Poster does also include, but is not restricted to, conference posters.
    /// <see href="http://onto.dm2e.eu/schemas/dm2e/Poster"></see></summary>
    let Poster = _prefix "Poster"
    /// <summary>
    /// A non-physical piece of work of an agent, e.g. the theoretical concept of a manuscript.
    /// <see href="http://onto.dm2e.eu/schemas/dm2e/Work"></see></summary>
    let Work = _prefix "Work"
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/artist"></see>
    /// </summary>
    let artist = _prefix "artist"
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/callNumber"></see>
    /// </summary>
    let callNumber = _prefix "callNumber"
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/composer"></see>
    /// </summary>
    let composer = _prefix "composer"
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/copyist"></see>
    /// </summary>
    let copyist = _prefix "copyist"
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/cover"></see>
    /// </summary>
    let cover = _prefix "cover"
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/displayLevel"></see>
    /// </summary>
    let displayLevel = _prefix "displayLevel"
    /// <summary>
    /// Final words of a manuscript. A language tag in ISO 639-2 should be added to the Literal.
    /// <see href="http://onto.dm2e.eu/schemas/dm2e/explicit"></see></summary>
    let explicit = _prefix "explicit"
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/genre"></see>
    /// </summary>
    let genre = _prefix "genre"
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/hasAnnotatableVersionAt"></see>
    /// </summary>
    let hasAnnotatableVersionAt = _prefix "hasAnnotatableVersionAt"
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/holdingInstitution"></see>
    /// </summary>
    let holdingInstitution = _prefix "holdingInstitution"
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/honoree"></see>
    /// </summary>
    let honoree = _prefix "honoree"
    /// <summary>
    /// Generic description of illustrations in the CHO.
    /// <see href="http://onto.dm2e.eu/schemas/dm2e/illustration"></see></summary>
    let illustration = _prefix "illustration"
    /// <summary>
    /// Opening words of a manuscript. A language tag in ISO 639-2 should be added to the Literal.
    /// <see href="http://onto.dm2e.eu/schemas/dm2e/incipit"></see></summary>
    let incipit = _prefix "incipit"
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/levelOfHierarchy"></see>
    /// </summary>
    let levelOfHierarchy = _prefix "levelOfHierarchy"
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/mentioned"></see>
    /// </summary>
    let mentioned = _prefix "mentioned"
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/modeOfAcquisition"></see>
    /// </summary>
    let modeOfAcquisition = _prefix "modeOfAcquisition"
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/owner"></see>
    /// </summary>
    let owner = _prefix "owner"
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/pageDimension"></see>
    /// </summary>
    let pageDimension = _prefix "pageDimension"
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/painter"></see>
    /// </summary>
    let painter = _prefix "painter"
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/portrayed"></see>
    /// </summary>
    let portrayed = _prefix "portrayed"
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/previousOwner"></see>
    /// </summary>
    let previousOwner = _prefix "previousOwner"
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/principal"></see>
    /// </summary>
    let principal = _prefix "principal"
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/printedAt"></see>
    /// </summary>
    let printedAt = _prefix "printedAt"
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/publishedAt"></see>
    /// </summary>
    let publishedAt = _prefix "publishedAt"
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/refersTo"></see>
    /// </summary>
    let refersTo = _prefix "refersTo"
    /// <summary>
    /// This property describes the dm2e-specific usage of the resource.
    /// <see href="http://onto.dm2e.eu/schemas/dm2e/scopeNote"></see></summary>
    let scopeNote = _prefix "scopeNote"
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/shelfmarkLocation"></see>
    /// </summary>
    let shelfmarkLocation = _prefix "shelfmarkLocation"
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/sponsor"></see>
    /// </summary>
    let sponsor = _prefix "sponsor"
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/subtitle"></see>
    /// </summary>
    let subtitle = _prefix "subtitle"
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/support"></see>
    /// </summary>
    let support = _prefix "support"
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/watermark"></see>
    /// </summary>
    let watermark = _prefix "watermark"
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/writer"></see>
    /// </summary>
    let writer = _prefix "writer"
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/writtenAreaDimension"></see>
    /// </summary>
    let writtenAreaDimension = _prefix "writtenAreaDimension"
    /// <summary>
    ///   <see href="http://onto.dm2e.eu/schemas/dm2e/writtenAt"></see>
    /// </summary>
    let writtenAt = _prefix "writtenAt"

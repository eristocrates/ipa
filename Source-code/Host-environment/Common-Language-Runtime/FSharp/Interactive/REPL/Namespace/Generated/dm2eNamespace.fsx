#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dm2e =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://onto.dm2e.eu/schemas/dm2e/" "dm2e"

    /// <summary>
    ///   <para>rdfs:label : Collection^^xsd:string</para>
    ///   <para>rdfs:comment : The collection of CHOs as provided by a data provider.^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/Collection">dm2e:Collection</a>
    /// </summary>
    let Collection = _prefixId.prefix "Collection"
    /// <summary>
    ///   <para>rdfs:label : DataResource^^xsd:string</para>
    ///   <para>rdfs:comment : The dataset that contains the RDF statements provided in via this data resource.^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/DataResource">dm2e:DataResource</a>
    /// </summary>
    let DataResource = _prefixId.prefix "DataResource"
    /// <summary>
    ///   <para>rdfs:label : Document^^xsd:string</para>
    ///   <para>rdfs:comment : ProvidedCHO of type document. Unlike foaf:Document, dm2e:Document refers to a physical document.^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/Document">dm2e:Document</a>
    /// </summary>
    let Document = _prefixId.prefix "Document"
    /// <summary>
    ///   <para>rdfs:label : File^^xsd:string</para>
    ///   <para>rdfs:comment : Archival Item.^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/File">dm2e:File</a>
    /// </summary>
    let File = _prefixId.prefix "File"
    /// <summary>
    ///   <para>rdfs:label : Fragment^^xsd:string</para>
    ///   <para>rdfs:comment : A physical fragment of a document, e.g. a collection of pages of a manuscript.^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/Fragment">dm2e:Fragment</a>
    /// </summary>
    let Fragment = _prefixId.prefix "Fragment"
    /// <summary>
    ///   <para>rdfs:label : Manuscript^^xsd:string</para>
    ///   <para>rdfs:comment : ProvidedCHO of type manuscript, e.g. Wittgensteins brown book. Not equivalent to bibo:Manuscript. Not equivalent to bibo:Manuscript.^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/Manuscript">dm2e:Manuscript</a>
    /// </summary>
    let Manuscript = _prefixId.prefix "Manuscript"
    /// <summary>
    ///   <para>rdfs:label : Page^^xsd:string</para>
    ///   <para>rdfs:comment : One side of a sheet of paper. Can be part of another CHO, e.g. dm2e:Manuscript.^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/Page">dm2e:Page</a>
    /// </summary>
    let Page = _prefixId.prefix "Page"
    /// <summary>
    ///   <para>rdfs:label : Paragraph^^xsd:string</para>
    ///   <para>rdfs:comment : ProvidedCHO of type paragraph. Can be part of another (textual) CHO, e.g. dm2e:Manuscript.^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/Paragraph">dm2e:Paragraph</a>
    /// </summary>
    let Paragraph = _prefixId.prefix "Paragraph"
    /// <summary>
    ///   <para>rdfs:label : Photo^^xsd:string</para>
    ///   <para>rdfs:comment : ProvidedCHO of type photo.^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/Photo">dm2e:Photo</a>
    /// </summary>
    let Photo = _prefixId.prefix "Photo"
    /// <summary>
    ///   <para>rdfs:label : Poster^^xsd:string</para>
    ///   <para>rdfs:comment : ProvidedCHO of type poster. Basically any piece of printed paper (often on a large sheet) that can be attached to a wall. dm2e:Poster does also include, but is not restricted to, conference posters.^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/Poster">dm2e:Poster</a>
    /// </summary>
    let Poster = _prefixId.prefix "Poster"
    /// <summary>
    ///   <para>rdfs:label : Work^^xsd:string</para>
    ///   <para>rdfs:comment : A non-physical piece of work of an agent, e.g. the theoretical concept of a manuscript.^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/Work">dm2e:Work</a>
    /// </summary>
    let Work = _prefixId.prefix "Work"
    /// <summary>
    ///   <para>rdfs:label : artist^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/artist">dm2e:artist</a>
    /// </summary>
    let artist = _prefixId.prefix "artist"
    /// <summary>
    ///   <para>rdfs:label : callNumber^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/callNumber">dm2e:callNumber</a>
    /// </summary>
    let callNumber = _prefixId.prefix "callNumber"
    /// <summary>
    ///   <para>rdfs:label : composer^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/composer">dm2e:composer</a>
    /// </summary>
    let composer = _prefixId.prefix "composer"
    /// <summary>
    ///   <para>rdfs:label : copyist^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/copyist">dm2e:copyist</a>
    /// </summary>
    let copyist = _prefixId.prefix "copyist"
    /// <summary>
    ///   <para>rdfs:label : cover^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/cover">dm2e:cover</a>
    /// </summary>
    let cover = _prefixId.prefix "cover"
    /// <summary>
    ///   <para>rdfs:label : displayLevel^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/displayLevel">dm2e:displayLevel</a>
    /// </summary>
    let displayLevel = _prefixId.prefix "displayLevel"
    /// <summary>
    ///   <para>rdfs:label : explicit^^xsd:string</para>
    ///   <para>rdfs:comment : Final words of a manuscript. A language tag in ISO 639-2 should be added to the Literal.^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/explicit">dm2e:explicit</a>
    /// </summary>
    let explicit = _prefixId.prefix "explicit"
    /// <summary>
    ///   <para>rdfs:label : genre^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/genre">dm2e:genre</a>
    /// </summary>
    let genre = _prefixId.prefix "genre"
    /// <summary>
    ///   <para>rdfs:label : hasAnnotatableVersionAt^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/hasAnnotatableVersionAt">dm2e:hasAnnotatableVersionAt</a>
    /// </summary>
    let hasAnnotatableVersionAt = _prefixId.prefix "hasAnnotatableVersionAt"
    /// <summary>
    ///   <para>rdfs:label : holdingInstitution^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/holdingInstitution">dm2e:holdingInstitution</a>
    /// </summary>
    let holdingInstitution = _prefixId.prefix "holdingInstitution"
    /// <summary>
    ///   <para>rdfs:label : honoree^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/honoree">dm2e:honoree</a>
    /// </summary>
    let honoree = _prefixId.prefix "honoree"
    /// <summary>
    ///   <para>rdfs:label : illustration^^xsd:string</para>
    ///   <para>rdfs:comment : Generic description of illustrations in the CHO.^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/illustration">dm2e:illustration</a>
    /// </summary>
    let illustration = _prefixId.prefix "illustration"
    /// <summary>
    ///   <para>rdfs:label : incipit^^xsd:string</para>
    ///   <para>rdfs:comment : Opening words of a manuscript. A language tag in ISO 639-2 should be added to the Literal.^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/incipit">dm2e:incipit</a>
    /// </summary>
    let incipit = _prefixId.prefix "incipit"
    /// <summary>
    ///   <para>rdfs:label : levelOfHierarchy^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/levelOfHierarchy">dm2e:levelOfHierarchy</a>
    /// </summary>
    let levelOfHierarchy = _prefixId.prefix "levelOfHierarchy"
    /// <summary>
    ///   <para>rdfs:label : mentioned^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/mentioned">dm2e:mentioned</a>
    /// </summary>
    let mentioned = _prefixId.prefix "mentioned"
    /// <summary>
    ///   <para>rdfs:label : modeOfAcquisition^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/modeOfAcquisition">dm2e:modeOfAcquisition</a>
    /// </summary>
    let modeOfAcquisition = _prefixId.prefix "modeOfAcquisition"
    /// <summary>
    ///   <para>rdfs:label : owner^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/owner">dm2e:owner</a>
    /// </summary>
    let owner = _prefixId.prefix "owner"
    /// <summary>
    ///   <para>rdfs:label : page dimension^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/pageDimension">dm2e:pageDimension</a>
    /// </summary>
    let pageDimension = _prefixId.prefix "pageDimension"
    /// <summary>
    ///   <para>rdfs:label : painter^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/painter">dm2e:painter</a>
    /// </summary>
    let painter = _prefixId.prefix "painter"
    /// <summary>
    ///   <para>rdfs:label : portrayed^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/portrayed">dm2e:portrayed</a>
    /// </summary>
    let portrayed = _prefixId.prefix "portrayed"
    /// <summary>
    ///   <para>rdfs:label : previous owner^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/previousOwner">dm2e:previousOwner</a>
    /// </summary>
    let previousOwner = _prefixId.prefix "previousOwner"
    /// <summary>
    ///   <para>rdfs:label : principal^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/principal">dm2e:principal</a>
    /// </summary>
    let principal = _prefixId.prefix "principal"
    /// <summary>
    ///   <para>rdfs:label : printed at^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/printedAt">dm2e:printedAt</a>
    /// </summary>
    let printedAt = _prefixId.prefix "printedAt"
    /// <summary>
    ///   <para>rdfs:label : published at^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/publishedAt">dm2e:publishedAt</a>
    /// </summary>
    let publishedAt = _prefixId.prefix "publishedAt"
    /// <summary>
    ///   <para>rdfs:label : refers to^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/refersTo">dm2e:refersTo</a>
    /// </summary>
    let refersTo = _prefixId.prefix "refersTo"
    /// <summary>
    ///   <para>rdfs:label : scopeNote^^xsd:string</para>
    ///   <para>rdfs:comment : This property describes the dm2e-specific usage of the resource.^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/scopeNote">dm2e:scopeNote</a>
    /// </summary>
    let scopeNote = _prefixId.prefix "scopeNote"
    /// <summary>
    ///   <para>rdfs:label : shelfmarkLocation^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/shelfmarkLocation">dm2e:shelfmarkLocation</a>
    /// </summary>
    let shelfmarkLocation = _prefixId.prefix "shelfmarkLocation"
    /// <summary>
    ///   <para>rdfs:label : sponsor^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/sponsor">dm2e:sponsor</a>
    /// </summary>
    let sponsor = _prefixId.prefix "sponsor"
    /// <summary>
    ///   <para>rdfs:label : subtitle^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/subtitle">dm2e:subtitle</a>
    /// </summary>
    let subtitle = _prefixId.prefix "subtitle"
    /// <summary>
    ///   <para>rdfs:label : support^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/support">dm2e:support</a>
    /// </summary>
    let support = _prefixId.prefix "support"
    /// <summary>
    ///   <para>rdfs:label : watermark^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/watermark">dm2e:watermark</a>
    /// </summary>
    let watermark = _prefixId.prefix "watermark"
    /// <summary>
    ///   <para>rdfs:label : writer^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/writer">dm2e:writer</a>
    /// </summary>
    let writer = _prefixId.prefix "writer"
    /// <summary>
    ///   <para>rdfs:label : written area dimension^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/writtenAreaDimension">dm2e:writtenAreaDimension</a>
    /// </summary>
    let writtenAreaDimension = _prefixId.prefix "writtenAreaDimension"
    /// <summary>
    ///   <para>rdfs:label : written at^^xsd:string</para>
    ///   <a href="http://onto.dm2e.eu/schemas/dm2e/writtenAt">dm2e:writtenAt</a>
    /// </summary>
    let writtenAt = _prefixId.prefix "writtenAt"

namespace http.onto.dm2e.eu.schemas.dm2e.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dm2e =
    let _namespace_iri = Namespace_Iri dm2e |> NamespaceIRI
    /// <summary>
    ///   <para>dm2e:Collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"The collection of CHOs as provided by a data provider."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Collection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/Collection">http://onto.dm2e.eu/schemas/dm2e/Collection</seealso>
    let Collection = Prefixed_Name(dm2e, "Collection") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:DataResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"The dataset that contains the RDF statements provided in via this data resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DataResource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/DataResource">http://onto.dm2e.eu/schemas/dm2e/DataResource</seealso>
    let DataResource = Prefixed_Name(dm2e, "DataResource") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:Document</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"ProvidedCHO of type document. Unlike foaf:Document, dm2e:Document refers to a physical document."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/Document">http://onto.dm2e.eu/schemas/dm2e/Document</seealso>
    let Document = Prefixed_Name(dm2e, "Document") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:File</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Archival Item."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"File"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/File">http://onto.dm2e.eu/schemas/dm2e/File</seealso>
    let File = Prefixed_Name(dm2e, "File") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:Fragment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A physical fragment of a document, e.g. a collection of pages of a manuscript."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fragment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/Fragment">http://onto.dm2e.eu/schemas/dm2e/Fragment</seealso>
    let Fragment = Prefixed_Name(dm2e, "Fragment") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:Manuscript</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"ProvidedCHO of type manuscript, e.g. Wittgensteins brown book. Not equivalent to bibo:Manuscript. Not equivalent to bibo:Manuscript."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Manuscript"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/Manuscript">http://onto.dm2e.eu/schemas/dm2e/Manuscript</seealso>
    let Manuscript = Prefixed_Name(dm2e, "Manuscript") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:Page</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"One side of a sheet of paper. Can be part of another CHO, e.g. dm2e:Manuscript."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Page"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/Page">http://onto.dm2e.eu/schemas/dm2e/Page</seealso>
    let Page = Prefixed_Name(dm2e, "Page") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:Paragraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"ProvidedCHO of type paragraph. Can be part of another (textual) CHO, e.g. dm2e:Manuscript."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Paragraph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/Paragraph">http://onto.dm2e.eu/schemas/dm2e/Paragraph</seealso>
    let Paragraph = Prefixed_Name(dm2e, "Paragraph") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:Photo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"ProvidedCHO of type photo."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Photo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/Photo">http://onto.dm2e.eu/schemas/dm2e/Photo</seealso>
    let Photo = Prefixed_Name(dm2e, "Photo") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:Poster</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"ProvidedCHO of type poster. Basically any piece of printed paper (often on a large sheet) that can be attached to a wall. dm2e:Poster does also include, but is not restricted to, conference posters."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Poster"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/Poster">http://onto.dm2e.eu/schemas/dm2e/Poster</seealso>
    let Poster = Prefixed_Name(dm2e, "Poster") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:Work</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A non-physical piece of work of an agent, e.g. the theoretical concept of a manuscript."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Work"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/Work">http://onto.dm2e.eu/schemas/dm2e/Work</seealso>
    let Work = Prefixed_Name(dm2e, "Work") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:artist</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"artist"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/artist">http://onto.dm2e.eu/schemas/dm2e/artist</seealso>
    let artist = Prefixed_Name(dm2e, "artist") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:callNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"callNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/callNumber">http://onto.dm2e.eu/schemas/dm2e/callNumber</seealso>
    let callNumber = Prefixed_Name(dm2e, "callNumber") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:composer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"composer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/composer">http://onto.dm2e.eu/schemas/dm2e/composer</seealso>
    let composer = Prefixed_Name(dm2e, "composer") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:copyist</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"copyist"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/copyist">http://onto.dm2e.eu/schemas/dm2e/copyist</seealso>
    let copyist = Prefixed_Name(dm2e, "copyist") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:cover</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"cover"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/cover">http://onto.dm2e.eu/schemas/dm2e/cover</seealso>
    let cover = Prefixed_Name(dm2e, "cover") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:displayLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"displayLevel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/displayLevel">http://onto.dm2e.eu/schemas/dm2e/displayLevel</seealso>
    let displayLevel = Prefixed_Name(dm2e, "displayLevel") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:explicit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Final words of a manuscript. A language tag in ISO 639-2 should be added to the Literal."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"explicit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/explicit">http://onto.dm2e.eu/schemas/dm2e/explicit</seealso>
    let explicit = Prefixed_Name(dm2e, "explicit") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:genre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"genre"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/genre">http://onto.dm2e.eu/schemas/dm2e/genre</seealso>
    let genre = Prefixed_Name(dm2e, "genre") |> PrefixedName

    /// <summary>
    ///   <para>dm2e:hasAnnotatableVersionAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"hasAnnotatableVersionAt"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/hasAnnotatableVersionAt">http://onto.dm2e.eu/schemas/dm2e/hasAnnotatableVersionAt</seealso>
    let hasAnnotatableVersionAt =
        Prefixed_Name(dm2e, "hasAnnotatableVersionAt") |> PrefixedName

    /// <summary>
    ///   <para>dm2e:holdingInstitution</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"holdingInstitution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/holdingInstitution">http://onto.dm2e.eu/schemas/dm2e/holdingInstitution</seealso>
    let holdingInstitution = Prefixed_Name(dm2e, "holdingInstitution") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:honoree</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"honoree"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/honoree">http://onto.dm2e.eu/schemas/dm2e/honoree</seealso>
    let honoree = Prefixed_Name(dm2e, "honoree") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:illustration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Generic description of illustrations in the CHO."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"illustration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/illustration">http://onto.dm2e.eu/schemas/dm2e/illustration</seealso>
    let illustration = Prefixed_Name(dm2e, "illustration") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:incipit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Opening words of a manuscript. A language tag in ISO 639-2 should be added to the Literal."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"incipit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/incipit">http://onto.dm2e.eu/schemas/dm2e/incipit</seealso>
    let incipit = Prefixed_Name(dm2e, "incipit") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:levelOfHierarchy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"levelOfHierarchy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/levelOfHierarchy">http://onto.dm2e.eu/schemas/dm2e/levelOfHierarchy</seealso>
    let levelOfHierarchy = Prefixed_Name(dm2e, "levelOfHierarchy") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:mentioned</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"mentioned"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/mentioned">http://onto.dm2e.eu/schemas/dm2e/mentioned</seealso>
    let mentioned = Prefixed_Name(dm2e, "mentioned") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:modeOfAcquisition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"modeOfAcquisition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/modeOfAcquisition">http://onto.dm2e.eu/schemas/dm2e/modeOfAcquisition</seealso>
    let modeOfAcquisition = Prefixed_Name(dm2e, "modeOfAcquisition") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:owner</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"owner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/owner">http://onto.dm2e.eu/schemas/dm2e/owner</seealso>
    let owner = Prefixed_Name(dm2e, "owner") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:pageDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"page dimension"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/pageDimension">http://onto.dm2e.eu/schemas/dm2e/pageDimension</seealso>
    let pageDimension = Prefixed_Name(dm2e, "pageDimension") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:painter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"painter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/painter">http://onto.dm2e.eu/schemas/dm2e/painter</seealso>
    let painter = Prefixed_Name(dm2e, "painter") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:portrayed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"portrayed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/portrayed">http://onto.dm2e.eu/schemas/dm2e/portrayed</seealso>
    let portrayed = Prefixed_Name(dm2e, "portrayed") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:previousOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"previous owner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/previousOwner">http://onto.dm2e.eu/schemas/dm2e/previousOwner</seealso>
    let previousOwner = Prefixed_Name(dm2e, "previousOwner") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:principal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"principal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/principal">http://onto.dm2e.eu/schemas/dm2e/principal</seealso>
    let principal = Prefixed_Name(dm2e, "principal") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:printedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"printed at"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/printedAt">http://onto.dm2e.eu/schemas/dm2e/printedAt</seealso>
    let printedAt = Prefixed_Name(dm2e, "printedAt") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:publishedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"published at"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/publishedAt">http://onto.dm2e.eu/schemas/dm2e/publishedAt</seealso>
    let publishedAt = Prefixed_Name(dm2e, "publishedAt") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:refersTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"refers to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/refersTo">http://onto.dm2e.eu/schemas/dm2e/refersTo</seealso>
    let refersTo = Prefixed_Name(dm2e, "refersTo") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:scopeNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This property describes the dm2e-specific usage of the resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"scopeNote"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/scopeNote">http://onto.dm2e.eu/schemas/dm2e/scopeNote</seealso>
    let scopeNote = Prefixed_Name(dm2e, "scopeNote") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:shelfmarkLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"shelfmarkLocation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/shelfmarkLocation">http://onto.dm2e.eu/schemas/dm2e/shelfmarkLocation</seealso>
    let shelfmarkLocation = Prefixed_Name(dm2e, "shelfmarkLocation") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:sponsor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"sponsor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/sponsor">http://onto.dm2e.eu/schemas/dm2e/sponsor</seealso>
    let sponsor = Prefixed_Name(dm2e, "sponsor") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:subtitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"subtitle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/subtitle">http://onto.dm2e.eu/schemas/dm2e/subtitle</seealso>
    let subtitle = Prefixed_Name(dm2e, "subtitle") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:support</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"support"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/support">http://onto.dm2e.eu/schemas/dm2e/support</seealso>
    let support = Prefixed_Name(dm2e, "support") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:watermark</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"watermark"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/watermark">http://onto.dm2e.eu/schemas/dm2e/watermark</seealso>
    let watermark = Prefixed_Name(dm2e, "watermark") |> PrefixedName
    /// <summary>
    ///   <para>dm2e:writer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"writer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/writer">http://onto.dm2e.eu/schemas/dm2e/writer</seealso>
    let writer = Prefixed_Name(dm2e, "writer") |> PrefixedName

    /// <summary>
    ///   <para>dm2e:writtenAreaDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"written area dimension"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/writtenAreaDimension">http://onto.dm2e.eu/schemas/dm2e/writtenAreaDimension</seealso>
    let writtenAreaDimension =
        Prefixed_Name(dm2e, "writtenAreaDimension") |> PrefixedName

    /// <summary>
    ///   <para>dm2e:writtenAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"written at"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://onto.dm2e.eu/schemas/dm2e/writtenAt">http://onto.dm2e.eu/schemas/dm2e/writtenAt</seealso>
    let writtenAt = Prefixed_Name(dm2e, "writtenAt") |> PrefixedName

namespace http.purl.org.dc.terms.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dcterms =
    let _namespace_iri = Namespace_Iri dcterms |> NamespaceIRI
    /// <summary>
    ///   <para>dcterms:modified</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Date on which the resource was changed.</para>
    /// labels<para>Date Modified</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/modified">http://purl.org/dc/terms/modified</seealso>
    let modified = Prefixed_Name(dcterms, "modified") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A name given to the resource.</para>
    /// labels<para>Title</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/title">http://purl.org/dc/terms/title</seealso>
    let title = Prefixed_Name(dcterms, "title") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:AgentClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A group of agents.</para>
    /// labels<para>Agent Class</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/AgentClass">http://purl.org/dc/terms/AgentClass</seealso>
    let AgentClass = Prefixed_Name(dcterms, "AgentClass") |> PrefixedName

    /// <summary>
    ///   <para>dcterms:BibliographicResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A book, article, or other documentary resource.</para>
    /// labels<para>Bibliographic Resource</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/BibliographicResource">http://purl.org/dc/terms/BibliographicResource</seealso>
    let BibliographicResource =
        Prefixed_Name(dcterms, "BibliographicResource") |> PrefixedName

    /// <summary>
    ///   <para>dcterms:URI</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>The set of identifiers constructed according to the generic syntax for Uniform Resource Identifiers as specified by the Internet Engineering Task Force.</para>
    /// labels<para>URI</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/URI">http://purl.org/dc/terms/URI</seealso>
    let URI = Prefixed_Name(dcterms, "URI") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:W3CDTF</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>The set of dates and times constructed according to the W3C Date and Time Formats Specification.</para>
    /// labels<para>W3C-DTF</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/W3CDTF">http://purl.org/dc/terms/W3CDTF</seealso>
    let W3CDTF = Prefixed_Name(dcterms, "W3CDTF") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:accrualMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The method by which items are added to a collection.</para>
    /// labels<para>Accrual Method</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/accrualMethod">http://purl.org/dc/terms/accrualMethod</seealso>
    let accrualMethod = Prefixed_Name(dcterms, "accrualMethod") |> PrefixedName

    /// <summary>
    ///   <para>dcterms:accrualPeriodicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The frequency with which items are added to a collection.</para>
    /// labels<para>Accrual Periodicity</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/accrualPeriodicity">http://purl.org/dc/terms/accrualPeriodicity</seealso>
    let accrualPeriodicity =
        Prefixed_Name(dcterms, "accrualPeriodicity") |> PrefixedName

    /// <summary>
    ///   <para>dcterms:publisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An entity responsible for making the resource available.</para>
    /// labels<para>Publisher</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/publisher">http://purl.org/dc/terms/publisher</seealso>
    let publisher = Prefixed_Name(dcterms, "publisher") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:hasVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A related resource that is a version, edition, or adaptation of the described resource.</para>
    /// labels<para>Has Version</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/hasVersion">http://purl.org/dc/terms/hasVersion</seealso>
    let hasVersion = Prefixed_Name(dcterms, "hasVersion") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:TGN</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>The set of places specified by the Getty Thesaurus of Geographic Names.</para>
    /// labels<para>TGN</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/TGN">http://purl.org/dc/terms/TGN</seealso>
    let TGN = Prefixed_Name(dcterms, "TGN") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:UDC</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>The set of conceptual resources specified by the Universal Decimal Classification.</para>
    /// labels<para>UDC</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/UDC">http://purl.org/dc/terms/UDC</seealso>
    let UDC = Prefixed_Name(dcterms, "UDC") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:abstract</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A summary of the resource.</para>
    /// labels<para>Abstract</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/abstract">http://purl.org/dc/terms/abstract</seealso>
    let abstract_ = Prefixed_Name(dcterms, "abstract") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:accessRights</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Information about who can access the resource or an indication of its security status.</para>
    /// labels<para>Access Rights</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/accessRights">http://purl.org/dc/terms/accessRights</seealso>
    let accessRights = Prefixed_Name(dcterms, "accessRights") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:accrualPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The policy governing the addition of items to a collection.</para>
    /// labels<para>Accrual Policy</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/accrualPolicy">http://purl.org/dc/terms/accrualPolicy</seealso>
    let accrualPolicy = Prefixed_Name(dcterms, "accrualPolicy") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:date</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A point or period of time associated with an event in the lifecycle of the resource.</para>
    /// labels<para>Date</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/date">http://purl.org/dc/terms/date</seealso>
    let date = Prefixed_Name(dcterms, "date") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An unambiguous reference to the resource within a given context.</para>
    /// labels<para>Identifier</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/identifier">http://purl.org/dc/terms/identifier</seealso>
    let identifier = Prefixed_Name(dcterms, "identifier") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:conformsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An established standard to which the described resource conforms.</para>
    /// labels<para>Conforms To</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/conformsTo">http://purl.org/dc/terms/conformsTo</seealso>
    let conformsTo = Prefixed_Name(dcterms, "conformsTo") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:relation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A related resource.</para>
    /// labels<para>Relation</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/relation">http://purl.org/dc/terms/relation</seealso>
    let relation = Prefixed_Name(dcterms, "relation") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:contributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An entity responsible for making contributions to the resource.</para>
    /// labels<para>Contributor</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/contributor">http://purl.org/dc/terms/contributor</seealso>
    let contributor = Prefixed_Name(dcterms, "contributor") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:created</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Date of creation of the resource.</para>
    /// labels<para>Date Created</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/created">http://purl.org/dc/terms/created</seealso>
    let created = Prefixed_Name(dcterms, "created") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:creator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An entity primarily responsible for making the resource.</para>
    /// labels<para>Creator</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/creator">http://purl.org/dc/terms/creator</seealso>
    let creator = Prefixed_Name(dcterms, "creator") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An account of the resource.</para>
    /// labels<para>Description</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/description">http://purl.org/dc/terms/description</seealso>
    let description = Prefixed_Name(dcterms, "description") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:NLM</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>The set of conceptual resources specified by the National Library of Medicine Classification.</para>
    /// labels<para>NLM</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/NLM">http://purl.org/dc/terms/NLM</seealso>
    let NLM = Prefixed_Name(dcterms, "NLM") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:extent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The size or duration of the resource.</para>
    /// labels<para>Extent</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/extent">http://purl.org/dc/terms/extent</seealso>
    let extent = Prefixed_Name(dcterms, "extent") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:format</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The file format, physical medium, or dimensions of the resource.</para>
    /// labels<para>Format</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/format">http://purl.org/dc/terms/format</seealso>
    let format = Prefixed_Name(dcterms, "format") |> PrefixedName

    /// <summary>
    ///   <para>dcterms:instructionalMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A process, used to engender knowledge, attitudes and skills, that the described resource is designed to support.</para>
    /// labels<para>Instructional Method</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/instructionalMethod">http://purl.org/dc/terms/instructionalMethod</seealso>
    let instructionalMethod =
        Prefixed_Name(dcterms, "instructionalMethod") |> PrefixedName

    /// <summary>
    ///   <para>dcterms:isPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A related resource in which the described resource is physically or logically included.</para>
    /// labels<para>Is Part Of</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/isPartOf">http://purl.org/dc/terms/isPartOf</seealso>
    let isPartOf = Prefixed_Name(dcterms, "isPartOf") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:isReplacedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A related resource that supplants, displaces, or supersedes the described resource.</para>
    /// labels<para>Is Replaced By</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/isReplacedBy">http://purl.org/dc/terms/isReplacedBy</seealso>
    let isReplacedBy = Prefixed_Name(dcterms, "isReplacedBy") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:isVersionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A related resource of which the described resource is a version, edition, or adaptation.</para>
    /// labels<para>Is Version Of</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/isVersionOf">http://purl.org/dc/terms/isVersionOf</seealso>
    let isVersionOf = Prefixed_Name(dcterms, "isVersionOf") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:mediator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An entity that mediates access to the resource and for whom the resource is intended or useful.</para>
    /// labels<para>Mediator</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/mediator">http://purl.org/dc/terms/mediator</seealso>
    let mediator = Prefixed_Name(dcterms, "mediator") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:medium</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The material or physical carrier of the resource.</para>
    /// labels<para>Medium</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/medium">http://purl.org/dc/terms/medium</seealso>
    let medium = Prefixed_Name(dcterms, "medium") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:coverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The spatial or temporal topic of the resource, the spatial applicability of the resource, or the jurisdiction under which the resource is relevant.</para>
    /// labels<para>Coverage</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/coverage">http://purl.org/dc/terms/coverage</seealso>
    let coverage = Prefixed_Name(dcterms, "coverage") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:dateAccepted</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Date of acceptance of the resource.</para>
    /// labels<para>Date Accepted</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/dateAccepted">http://purl.org/dc/terms/dateAccepted</seealso>
    let dateAccepted = Prefixed_Name(dcterms, "dateAccepted") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:dateCopyrighted</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Date of copyright.</para>
    /// labels<para>Date Copyrighted</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/dateCopyrighted">http://purl.org/dc/terms/dateCopyrighted</seealso>
    let dateCopyrighted = Prefixed_Name(dcterms, "dateCopyrighted") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:educationLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A class of entity, defined in terms of progression through an educational or training context, for which the described resource is intended.</para>
    /// labels<para>Audience Education Level</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/educationLevel">http://purl.org/dc/terms/educationLevel</seealso>
    let educationLevel = Prefixed_Name(dcterms, "educationLevel") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:hasFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A related resource that is substantially the same as the pre-existing described resource, but in another format.</para>
    /// labels<para>Has Format</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/hasFormat">http://purl.org/dc/terms/hasFormat</seealso>
    let hasFormat = Prefixed_Name(dcterms, "hasFormat") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:hasPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A related resource that is included either physically or logically in the described resource.</para>
    /// labels<para>Has Part</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/hasPart">http://purl.org/dc/terms/hasPart</seealso>
    let hasPart = Prefixed_Name(dcterms, "hasPart") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:isReferencedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A related resource that references, cites, or otherwise points to the described resource.</para>
    /// labels<para>Is Referenced By</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/isReferencedBy">http://purl.org/dc/terms/isReferencedBy</seealso>
    let isReferencedBy = Prefixed_Name(dcterms, "isReferencedBy") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:Box</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>The set of regions in space defined by their geographic coordinates according to the DCMI Box Encoding Scheme.</para>
    /// labels<para>DCMI Box</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/Box">http://purl.org/dc/terms/Box</seealso>
    let Box = Prefixed_Name(dcterms, "Box") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:dateSubmitted</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Date of submission of the resource.</para>
    /// labels<para>Date Submitted</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/dateSubmitted">http://purl.org/dc/terms/dateSubmitted</seealso>
    let dateSubmitted = Prefixed_Name(dcterms, "dateSubmitted") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:rights</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Information about rights held in and over the resource.</para>
    /// labels<para>Rights</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/rights">http://purl.org/dc/terms/rights</seealso>
    let rights = Prefixed_Name(dcterms, "rights") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:alternative</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An alternative name for the resource.</para>
    /// labels<para>Alternative Title</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/alternative">http://purl.org/dc/terms/alternative</seealso>
    let alternative = Prefixed_Name(dcterms, "alternative") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:audience</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A class of entity for whom the resource is intended or useful.</para>
    /// labels<para>Audience</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/audience">http://purl.org/dc/terms/audience</seealso>
    let audience = Prefixed_Name(dcterms, "audience") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:available</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Date (often a range) that the resource became or will become available.</para>
    /// labels<para>Date Available</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/available">http://purl.org/dc/terms/available</seealso>
    let available = Prefixed_Name(dcterms, "available") |> PrefixedName

    /// <summary>
    ///   <para>dcterms:bibliographicCitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A bibliographic reference for the resource.</para>
    /// labels<para>Bibliographic Citation</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/bibliographicCitation">http://purl.org/dc/terms/bibliographicCitation</seealso>
    let bibliographicCitation =
        Prefixed_Name(dcterms, "bibliographicCitation") |> PrefixedName

    /// <summary>
    ///   <para>dcterms:DCMIType</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>The set of classes specified by the DCMI Type Vocabulary, used to categorize the nature or genre of the resource.</para>
    /// labels<para>DCMI Type Vocabulary</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/DCMIType">http://purl.org/dc/terms/DCMIType</seealso>
    let DCMIType = Prefixed_Name(dcterms, "DCMIType") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:FileFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A digital resource format.</para>
    /// labels<para>File Format</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/FileFormat">http://purl.org/dc/terms/FileFormat</seealso>
    let FileFormat = Prefixed_Name(dcterms, "FileFormat") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:DDC</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>The set of conceptual resources specified by the Dewey Decimal Classification.</para>
    /// labels<para>DDC</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/DDC">http://purl.org/dc/terms/DDC</seealso>
    let DDC = Prefixed_Name(dcterms, "DDC") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:Frequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A rate at which something recurs.</para>
    /// labels<para>Frequency</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/Frequency">http://purl.org/dc/terms/Frequency</seealso>
    let Frequency = Prefixed_Name(dcterms, "Frequency") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:references</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A related resource that is referenced, cited, or otherwise pointed to by the described resource.</para>
    /// labels<para>References</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/references">http://purl.org/dc/terms/references</seealso>
    let references = Prefixed_Name(dcterms, "references") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:replaces</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A related resource that is supplanted, displaced, or superseded by the described resource.</para>
    /// labels<para>Replaces</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/replaces">http://purl.org/dc/terms/replaces</seealso>
    let replaces = Prefixed_Name(dcterms, "replaces") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:isFormatOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A related resource that is substantially the same as the described resource, but in another format.</para>
    /// labels<para>Is Format Of</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/isFormatOf">http://purl.org/dc/terms/isFormatOf</seealso>
    let isFormatOf = Prefixed_Name(dcterms, "isFormatOf") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:isRequiredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A related resource that requires the described resource to support its function, delivery, or coherence.</para>
    /// labels<para>Is Required By</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/isRequiredBy">http://purl.org/dc/terms/isRequiredBy</seealso>
    let isRequiredBy = Prefixed_Name(dcterms, "isRequiredBy") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A language of the resource.</para>
    /// labels<para>Language</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/language">http://purl.org/dc/terms/language</seealso>
    let language = Prefixed_Name(dcterms, "language") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:license</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A legal document giving official permission to do something with the resource.</para>
    /// labels<para>License</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/license">http://purl.org/dc/terms/license</seealso>
    let license = Prefixed_Name(dcterms, "license") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:provenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A statement of any changes in ownership and custody of the resource since its creation that are significant for its authenticity, integrity, and interpretation.</para>
    /// labels<para>Provenance</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/provenance">http://purl.org/dc/terms/provenance</seealso>
    let provenance = Prefixed_Name(dcterms, "provenance") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:requires</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A related resource that is required by the described resource to support its function, delivery, or coherence.</para>
    /// labels<para>Requires</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/requires">http://purl.org/dc/terms/requires</seealso>
    let requires = Prefixed_Name(dcterms, "requires") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:source</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A related resource from which the described resource is derived.</para>
    /// labels<para>Source</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/source">http://purl.org/dc/terms/source</seealso>
    let source = Prefixed_Name(dcterms, "source") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:spatial</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Spatial characteristics of the resource.</para>
    /// labels<para>Spatial Coverage</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/spatial">http://purl.org/dc/terms/spatial</seealso>
    let spatial = Prefixed_Name(dcterms, "spatial") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:temporal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Temporal characteristics of the resource.</para>
    /// labels<para>Temporal Coverage</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/temporal">http://purl.org/dc/terms/temporal</seealso>
    let temporal = Prefixed_Name(dcterms, "temporal") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:MediaType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A file format or physical medium.</para>
    /// labels<para>Media Type</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/MediaType">http://purl.org/dc/terms/MediaType</seealso>
    let MediaType = Prefixed_Name(dcterms, "MediaType") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:rightsHolder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A person or organization owning or managing rights over the resource.</para>
    /// labels<para>Rights Holder</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/rightsHolder">http://purl.org/dc/terms/rightsHolder</seealso>
    let rightsHolder = Prefixed_Name(dcterms, "rightsHolder") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The topic of the resource.</para>
    /// labels<para>Subject</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/subject">http://purl.org/dc/terms/subject</seealso>
    let subject = Prefixed_Name(dcterms, "subject") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:IMT</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>The set of media types specified by the Internet Assigned Numbers Authority.</para>
    /// labels<para>IMT</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/IMT">http://purl.org/dc/terms/IMT</seealso>
    let IMT = Prefixed_Name(dcterms, "IMT") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:ISO639-3</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>The set of three-letter codes listed in ISO 639-3 for the representation of names of languages.</para>
    /// labels<para>ISO 639-3</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/ISO639-3">http://purl.org/dc/terms/ISO639-3</seealso>
    let ISO639_3 = Prefixed_Name(dcterms, "ISO639-3") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:Jurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The extent or range of judicial, law enforcement, or other authority.</para>
    /// labels<para>Jurisdiction</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/Jurisdiction">http://purl.org/dc/terms/Jurisdiction</seealso>
    let Jurisdiction = Prefixed_Name(dcterms, "Jurisdiction") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:LicenseDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A legal document giving official permission to do something with a Resource.</para>
    /// labels<para>License Document</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/LicenseDocument">http://purl.org/dc/terms/LicenseDocument</seealso>
    let LicenseDocument = Prefixed_Name(dcterms, "LicenseDocument") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A spatial region or named place.</para>
    /// labels<para>Location</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/Location">http://purl.org/dc/terms/Location</seealso>
    let Location = Prefixed_Name(dcterms, "Location") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:tableOfContents</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A list of subunits of the resource.</para>
    /// labels<para>Table Of Contents</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/tableOfContents">http://purl.org/dc/terms/tableOfContents</seealso>
    let tableOfContents = Prefixed_Name(dcterms, "tableOfContents") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The nature or genre of the resource.</para>
    /// labels<para>Type</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/type">http://purl.org/dc/terms/type</seealso>
    let type_ = Prefixed_Name(dcterms, "type") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:valid</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Date (often a range) of validity of a resource.</para>
    /// labels<para>Date Valid</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/valid">http://purl.org/dc/terms/valid</seealso>
    let valid = Prefixed_Name(dcterms, "valid") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:LCSH</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>The set of labeled concepts specified by the Library of Congress Subject Headings.</para>
    /// labels<para>LCSH</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/LCSH">http://purl.org/dc/terms/LCSH</seealso>
    let LCSH = Prefixed_Name(dcterms, "LCSH") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:MESH</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>The set of labeled concepts specified by the Medical Subject Headings.</para>
    /// labels<para>MeSH</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/MESH">http://purl.org/dc/terms/MESH</seealso>
    let MESH = Prefixed_Name(dcterms, "MESH") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:MediaTypeOrExtent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A media type or extent.</para>
    /// labels<para>Media Type or Extent</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/MediaTypeOrExtent">http://purl.org/dc/terms/MediaTypeOrExtent</seealso>
    let MediaTypeOrExtent = Prefixed_Name(dcterms, "MediaTypeOrExtent") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:MethodOfAccrual</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A method by which resources are added to a collection.</para>
    /// labels<para>Method of Accrual</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/MethodOfAccrual">http://purl.org/dc/terms/MethodOfAccrual</seealso>
    let MethodOfAccrual = Prefixed_Name(dcterms, "MethodOfAccrual") |> PrefixedName

    /// <summary>
    ///   <para>dcterms:MethodOfInstruction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A process that is used to engender knowledge, attitudes, and skills.</para>
    /// labels<para>Method of Instruction</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/MethodOfInstruction">http://purl.org/dc/terms/MethodOfInstruction</seealso>
    let MethodOfInstruction =
        Prefixed_Name(dcterms, "MethodOfInstruction") |> PrefixedName

    /// <summary>
    ///   <para>dcterms:PeriodOfTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An interval of time that is named or defined by its start and end dates.</para>
    /// labels<para>Period of Time</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/PeriodOfTime">http://purl.org/dc/terms/PeriodOfTime</seealso>
    let PeriodOfTime = Prefixed_Name(dcterms, "PeriodOfTime") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:Period</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>The set of time intervals defined by their limits according to the DCMI Period Encoding Scheme.</para>
    /// labels<para>DCMI Period</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/Period">http://purl.org/dc/terms/Period</seealso>
    let Period = Prefixed_Name(dcterms, "Period") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:PhysicalMedium</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A physical material or carrier.</para>
    /// labels<para>Physical Medium</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/PhysicalMedium">http://purl.org/dc/terms/PhysicalMedium</seealso>
    let PhysicalMedium = Prefixed_Name(dcterms, "PhysicalMedium") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:PhysicalResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A material thing.</para>
    /// labels<para>Physical Resource</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/PhysicalResource">http://purl.org/dc/terms/PhysicalResource</seealso>
    let PhysicalResource = Prefixed_Name(dcterms, "PhysicalResource") |> PrefixedName

    /// <summary>
    ///   <para>dcterms:ProvenanceStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A statement of any changes in ownership and custody of a resource since its creation that are significant for its authenticity, integrity, and interpretation.</para>
    /// labels<para>Provenance Statement</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/ProvenanceStatement">http://purl.org/dc/terms/ProvenanceStatement</seealso>
    let ProvenanceStatement =
        Prefixed_Name(dcterms, "ProvenanceStatement") |> PrefixedName

    /// <summary>
    ///   <para>dcterms:RFC1766</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>The set of tags, constructed according to RFC 1766, for the identification of languages.</para>
    /// labels<para>RFC 1766</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/RFC1766">http://purl.org/dc/terms/RFC1766</seealso>
    let RFC1766 = Prefixed_Name(dcterms, "RFC1766") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:RFC3066</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>The set of tags constructed according to RFC 3066 for the identification of languages.</para>
    /// labels<para>RFC 3066</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/RFC3066">http://purl.org/dc/terms/RFC3066</seealso>
    let RFC3066 = Prefixed_Name(dcterms, "RFC3066") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:RFC5646</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>The set of tags constructed according to RFC 5646 for the identification of languages.</para>
    /// labels<para>RFC 5646</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/RFC5646">http://purl.org/dc/terms/RFC5646</seealso>
    let RFC5646 = Prefixed_Name(dcterms, "RFC5646") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:Point</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>The set of points in space defined by their geographic coordinates according to the DCMI Point Encoding Scheme.</para>
    /// labels<para>DCMI Point</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/Point">http://purl.org/dc/terms/Point</seealso>
    let Point = Prefixed_Name(dcterms, "Point") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:Policy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A plan or course of action by an authority, intended to influence and determine decisions, actions, and other matters.</para>
    /// labels<para>Policy</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/Policy">http://purl.org/dc/terms/Policy</seealso>
    let Policy = Prefixed_Name(dcterms, "Policy") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:RFC4646</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>The set of tags constructed according to RFC 4646 for the identification of languages.</para>
    /// labels<para>RFC 4646</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/RFC4646">http://purl.org/dc/terms/RFC4646</seealso>
    let RFC4646 = Prefixed_Name(dcterms, "RFC4646") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:SizeOrDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A dimension or extent, or a time taken to play or execute.</para>
    /// labels<para>Size or Duration</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/SizeOrDuration">http://purl.org/dc/terms/SizeOrDuration</seealso>
    let SizeOrDuration = Prefixed_Name(dcterms, "SizeOrDuration") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:Standard</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A basis for comparison; a reference point against which other things can be evaluated.</para>
    /// labels<para>Standard</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/Standard">http://purl.org/dc/terms/Standard</seealso>
    let Standard = Prefixed_Name(dcterms, "Standard") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/dc/terms/">http://purl.org/dc/terms/</seealso>
    let _prefix_iri = Prefixed_Name(dcterms, "") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:AgentClass</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A resource that acts or has the power to act.</para>
    /// labels<para>Agent</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/Agent">http://purl.org/dc/terms/Agent</seealso>
    let Agent = Prefixed_Name(dcterms, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:issued</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Date of formal issuance (e.g., publication) of the resource.</para>
    /// labels<para>Date Issued</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/issued">http://purl.org/dc/terms/issued</seealso>
    let issued = Prefixed_Name(dcterms, "issued") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:ISO3166</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>The set of codes listed in ISO 3166-1 for the representation of names of countries.</para>
    /// labels<para>ISO 3166</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/ISO3166">http://purl.org/dc/terms/ISO3166</seealso>
    let ISO3166 = Prefixed_Name(dcterms, "ISO3166") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:ISO639-2</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>The three-letter alphabetic codes listed in ISO639-2 for the representation of names of languages.</para>
    /// labels<para>ISO 639-2</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/ISO639-2">http://purl.org/dc/terms/ISO639-2</seealso>
    let ISO639_2 = Prefixed_Name(dcterms, "ISO639-2") |> PrefixedName

    /// <summary>
    ///   <para>dcterms:LocationPeriodOrJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A location, period of time, or jurisdiction.</para>
    /// labels<para>Location, Period, or Jurisdiction</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/LocationPeriodOrJurisdiction">http://purl.org/dc/terms/LocationPeriodOrJurisdiction</seealso>
    let LocationPeriodOrJurisdiction =
        Prefixed_Name(dcterms, "LocationPeriodOrJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>dcterms:LCC</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>The set of conceptual resources specified by the Library of Congress Classification.</para>
    /// labels<para>LCC</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/LCC">http://purl.org/dc/terms/LCC</seealso>
    let LCC = Prefixed_Name(dcterms, "LCC") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:RightsStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A statement about the intellectual property rights (IPR) held in or over a Resource, a legal document giving official permission to do something with a resource, or a statement about access rights.</para>
    /// labels<para>Rights Statement</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/RightsStatement">http://purl.org/dc/terms/RightsStatement</seealso>
    let RightsStatement = Prefixed_Name(dcterms, "RightsStatement") |> PrefixedName
    /// <summary>
    ///   <para>dcterms:LinguisticSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A system of signs, symbols, sounds, gestures, or rules used in communication.</para>
    /// labels<para>Linguistic System</para></remarks>
    /// <seealso href="http://purl.org/dc/terms/LinguisticSystem">http://purl.org/dc/terms/LinguisticSystem</seealso>
    let LinguisticSystem = Prefixed_Name(dcterms, "LinguisticSystem") |> PrefixedName

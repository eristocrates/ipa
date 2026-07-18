namespace http.purl.org.dc.terms.slash

open DoxAletheia.Rdf_Vocabulary

module dcterms =
    let _namespace_name = "http://purl.org/dc/terms/"
    /// <summary>
    /// Date on which the resource was changed.
    /// <see href="http://purl.org/dc/terms/modified"></see></summary>
    let modified = Namespaced_IRI.parse _namespace_name "modified" |> NamespacedName
    /// <summary>
    /// An entity responsible for making the resource available.
    /// <see href="http://purl.org/dc/terms/publisher"></see></summary>
    let publisher = Namespaced_IRI.parse _namespace_name "publisher" |> NamespacedName
    /// <summary>
    /// A name given to the resource.
    /// <see href="http://purl.org/dc/terms/title"></see></summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName
    /// <summary>
    /// A resource that acts or has the power to act.
    /// <see href="http://purl.org/dc/terms/Agent"></see></summary>
    let Agent = Namespaced_IRI.parse _namespace_name "Agent" |> NamespacedName

    /// <summary>
    /// An account of the resource.
    /// <see href="http://purl.org/dc/terms/description"></see></summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    /// A related resource that is a version, edition, or adaptation of the described resource.
    /// <see href="http://purl.org/dc/terms/hasVersion"></see></summary>
    let hasVersion = Namespaced_IRI.parse _namespace_name "hasVersion" |> NamespacedName
    /// <summary>
    /// Date of formal issuance (e.g., publication) of the resource.
    /// <see href="http://purl.org/dc/terms/issued"></see></summary>
    let issued = Namespaced_IRI.parse _namespace_name "issued" |> NamespacedName
    /// <summary>
    /// A group of agents.
    /// <see href="http://purl.org/dc/terms/AgentClass"></see></summary>
    let AgentClass = Namespaced_IRI.parse _namespace_name "AgentClass" |> NamespacedName

    /// <summary>
    /// A book, article, or other documentary resource.
    /// <see href="http://purl.org/dc/terms/BibliographicResource"></see></summary>
    let BibliographicResource =
        Namespaced_IRI.parse _namespace_name "BibliographicResource" |> NamespacedName

    /// <summary>
    /// The set of regions in space defined by their geographic coordinates according to the DCMI Box Encoding Scheme.
    /// <see href="http://purl.org/dc/terms/Box"></see></summary>
    let Box = Namespaced_IRI.parse _namespace_name "Box" |> NamespacedName
    /// <summary>
    /// The set of classes specified by the DCMI Type Vocabulary, used to categorize the nature or genre of the resource.
    /// <see href="http://purl.org/dc/terms/DCMIType"></see></summary>
    let DCMIType = Namespaced_IRI.parse _namespace_name "DCMIType" |> NamespacedName
    /// <summary>
    /// The set of conceptual resources specified by the Dewey Decimal Classification.
    /// <see href="http://purl.org/dc/terms/DDC"></see></summary>
    let DDC = Namespaced_IRI.parse _namespace_name "DDC" |> NamespacedName
    /// <summary>
    /// A digital resource format.
    /// <see href="http://purl.org/dc/terms/FileFormat"></see></summary>
    let FileFormat = Namespaced_IRI.parse _namespace_name "FileFormat" |> NamespacedName
    /// <summary>
    /// A file format or physical medium.
    /// <see href="http://purl.org/dc/terms/MediaType"></see></summary>
    let MediaType = Namespaced_IRI.parse _namespace_name "MediaType" |> NamespacedName
    /// <summary>
    /// A rate at which something recurs.
    /// <see href="http://purl.org/dc/terms/Frequency"></see></summary>
    let Frequency = Namespaced_IRI.parse _namespace_name "Frequency" |> NamespacedName
    /// <summary>
    /// The set of media types specified by the Internet Assigned Numbers Authority.
    /// <see href="http://purl.org/dc/terms/IMT"></see></summary>
    let IMT = Namespaced_IRI.parse _namespace_name "IMT" |> NamespacedName
    /// <summary>
    /// The set of codes listed in ISO 3166-1 for the representation of names of countries.
    /// <see href="http://purl.org/dc/terms/ISO3166"></see></summary>
    let ISO3166 = Namespaced_IRI.parse _namespace_name "ISO3166" |> NamespacedName
    /// <summary>
    /// The three-letter alphabetic codes listed in ISO639-2 for the representation of names of languages.
    /// <see href="http://purl.org/dc/terms/ISO639-2"></see></summary>
    let ``ISO639-2`` = Namespaced_IRI.parse _namespace_name "ISO639-2" |> NamespacedName
    /// <summary>
    /// The set of three-letter codes listed in ISO 639-3 for the representation of names of languages.
    /// <see href="http://purl.org/dc/terms/ISO639-3"></see></summary>
    let ``ISO639-3`` = Namespaced_IRI.parse _namespace_name "ISO639-3" |> NamespacedName

    /// <summary>
    /// The extent or range of judicial, law enforcement, or other authority.
    /// <see href="http://purl.org/dc/terms/Jurisdiction"></see></summary>
    let Jurisdiction =
        Namespaced_IRI.parse _namespace_name "Jurisdiction" |> NamespacedName

    /// <summary>
    /// A location, period of time, or jurisdiction.
    /// <see href="http://purl.org/dc/terms/LocationPeriodOrJurisdiction"></see></summary>
    let LocationPeriodOrJurisdiction =
        Namespaced_IRI.parse _namespace_name "LocationPeriodOrJurisdiction" |> NamespacedName

    /// <summary>
    /// The set of conceptual resources specified by the Library of Congress Classification.
    /// <see href="http://purl.org/dc/terms/LCC"></see></summary>
    let LCC = Namespaced_IRI.parse _namespace_name "LCC" |> NamespacedName
    /// <summary>
    /// The set of labeled concepts specified by the Library of Congress Subject Headings.
    /// <see href="http://purl.org/dc/terms/LCSH"></see></summary>
    let LCSH = Namespaced_IRI.parse _namespace_name "LCSH" |> NamespacedName

    /// <summary>
    /// A legal document giving official permission to do something with a Resource.
    /// <see href="http://purl.org/dc/terms/LicenseDocument"></see></summary>
    let LicenseDocument =
        Namespaced_IRI.parse _namespace_name "LicenseDocument" |> NamespacedName

    /// <summary>
    /// A statement about the intellectual property rights (IPR) held in or over a Resource, a legal document giving official permission to do something with a resource, or a statement about access rights.
    /// <see href="http://purl.org/dc/terms/RightsStatement"></see></summary>
    let RightsStatement =
        Namespaced_IRI.parse _namespace_name "RightsStatement" |> NamespacedName

    /// <summary>
    /// A system of signs, symbols, sounds, gestures, or rules used in communication.
    /// <see href="http://purl.org/dc/terms/LinguisticSystem"></see></summary>
    let LinguisticSystem =
        Namespaced_IRI.parse _namespace_name "LinguisticSystem" |> NamespacedName

    /// <summary>
    /// A spatial region or named place.
    /// <see href="http://purl.org/dc/terms/Location"></see></summary>
    let Location = Namespaced_IRI.parse _namespace_name "Location" |> NamespacedName
    /// <summary>
    /// The set of labeled concepts specified by the Medical Subject Headings.
    /// <see href="http://purl.org/dc/terms/MESH"></see></summary>
    let MESH = Namespaced_IRI.parse _namespace_name "MESH" |> NamespacedName

    /// <summary>
    /// A media type or extent.
    /// <see href="http://purl.org/dc/terms/MediaTypeOrExtent"></see></summary>
    let MediaTypeOrExtent =
        Namespaced_IRI.parse _namespace_name "MediaTypeOrExtent" |> NamespacedName

    /// <summary>
    /// A method by which resources are added to a collection.
    /// <see href="http://purl.org/dc/terms/MethodOfAccrual"></see></summary>
    let MethodOfAccrual =
        Namespaced_IRI.parse _namespace_name "MethodOfAccrual" |> NamespacedName

    /// <summary>
    /// A process that is used to engender knowledge, attitudes, and skills.
    /// <see href="http://purl.org/dc/terms/MethodOfInstruction"></see></summary>
    let MethodOfInstruction =
        Namespaced_IRI.parse _namespace_name "MethodOfInstruction" |> NamespacedName

    /// <summary>
    /// The set of conceptual resources specified by the National Library of Medicine Classification.
    /// <see href="http://purl.org/dc/terms/NLM"></see></summary>
    let NLM = Namespaced_IRI.parse _namespace_name "NLM" |> NamespacedName
    /// <summary>
    /// The set of time intervals defined by their limits according to the DCMI Period Encoding Scheme.
    /// <see href="http://purl.org/dc/terms/Period"></see></summary>
    let Period = Namespaced_IRI.parse _namespace_name "Period" |> NamespacedName

    /// <summary>
    /// An interval of time that is named or defined by its start and end dates.
    /// <see href="http://purl.org/dc/terms/PeriodOfTime"></see></summary>
    let PeriodOfTime =
        Namespaced_IRI.parse _namespace_name "PeriodOfTime" |> NamespacedName

    /// <summary>
    /// A physical material or carrier.
    /// <see href="http://purl.org/dc/terms/PhysicalMedium"></see></summary>
    let PhysicalMedium =
        Namespaced_IRI.parse _namespace_name "PhysicalMedium" |> NamespacedName

    /// <summary>
    /// A material thing.
    /// <see href="http://purl.org/dc/terms/PhysicalResource"></see></summary>
    let PhysicalResource =
        Namespaced_IRI.parse _namespace_name "PhysicalResource" |> NamespacedName

    /// <summary>
    /// The set of points in space defined by their geographic coordinates according to the DCMI Point Encoding Scheme.
    /// <see href="http://purl.org/dc/terms/Point"></see></summary>
    let Point = Namespaced_IRI.parse _namespace_name "Point" |> NamespacedName
    /// <summary>
    /// A plan or course of action by an authority, intended to influence and determine decisions, actions, and other matters.
    /// <see href="http://purl.org/dc/terms/Policy"></see></summary>
    let Policy = Namespaced_IRI.parse _namespace_name "Policy" |> NamespacedName

    /// <summary>
    /// A statement of any changes in ownership and custody of a resource since its creation that are significant for its authenticity, integrity, and interpretation.
    /// <see href="http://purl.org/dc/terms/ProvenanceStatement"></see></summary>
    let ProvenanceStatement =
        Namespaced_IRI.parse _namespace_name "ProvenanceStatement" |> NamespacedName

    /// <summary>
    /// The set of tags, constructed according to RFC 1766, for the identification of languages.
    /// <see href="http://purl.org/dc/terms/RFC1766"></see></summary>
    let RFC1766 = Namespaced_IRI.parse _namespace_name "RFC1766" |> NamespacedName
    /// <summary>
    /// The set of tags constructed according to RFC 3066 for the identification of languages.
    /// <see href="http://purl.org/dc/terms/RFC3066"></see></summary>
    let RFC3066 = Namespaced_IRI.parse _namespace_name "RFC3066" |> NamespacedName
    /// <summary>
    /// The set of tags constructed according to RFC 4646 for the identification of languages.
    /// <see href="http://purl.org/dc/terms/RFC4646"></see></summary>
    let RFC4646 = Namespaced_IRI.parse _namespace_name "RFC4646" |> NamespacedName
    /// <summary>
    /// The set of tags constructed according to RFC 5646 for the identification of languages.
    /// <see href="http://purl.org/dc/terms/RFC5646"></see></summary>
    let RFC5646 = Namespaced_IRI.parse _namespace_name "RFC5646" |> NamespacedName

    /// <summary>
    /// A dimension or extent, or a time taken to play or execute.
    /// <see href="http://purl.org/dc/terms/SizeOrDuration"></see></summary>
    let SizeOrDuration =
        Namespaced_IRI.parse _namespace_name "SizeOrDuration" |> NamespacedName

    /// <summary>
    /// A basis for comparison; a reference point against which other things can be evaluated.
    /// <see href="http://purl.org/dc/terms/Standard"></see></summary>
    let Standard = Namespaced_IRI.parse _namespace_name "Standard" |> NamespacedName
    /// <summary>
    /// The set of places specified by the Getty Thesaurus of Geographic Names.
    /// <see href="http://purl.org/dc/terms/TGN"></see></summary>
    let TGN = Namespaced_IRI.parse _namespace_name "TGN" |> NamespacedName
    /// <summary>
    /// The set of conceptual resources specified by the Universal Decimal Classification.
    /// <see href="http://purl.org/dc/terms/UDC"></see></summary>
    let UDC = Namespaced_IRI.parse _namespace_name "UDC" |> NamespacedName
    /// <summary>
    /// The set of identifiers constructed according to the generic syntax for Uniform Resource Identifiers as specified by the Internet Engineering Task Force.
    /// <see href="http://purl.org/dc/terms/URI"></see></summary>
    let URI = Namespaced_IRI.parse _namespace_name "URI" |> NamespacedName
    /// <summary>
    /// The set of dates and times constructed according to the W3C Date and Time Formats Specification.
    /// <see href="http://purl.org/dc/terms/W3CDTF"></see></summary>
    let W3CDTF = Namespaced_IRI.parse _namespace_name "W3CDTF" |> NamespacedName
    /// <summary>
    /// A summary of the resource.
    /// <see href="http://purl.org/dc/terms/abstract"></see></summary>
    let abstract_ = Namespaced_IRI.parse _namespace_name "abstract" |> NamespacedName

    /// <summary>
    /// Information about who can access the resource or an indication of its security status.
    /// <see href="http://purl.org/dc/terms/accessRights"></see></summary>
    let accessRights =
        Namespaced_IRI.parse _namespace_name "accessRights" |> NamespacedName

    /// <summary>
    /// Information about rights held in and over the resource.
    /// <see href="http://purl.org/dc/terms/rights"></see></summary>
    let rights = Namespaced_IRI.parse _namespace_name "rights" |> NamespacedName

    /// <summary>
    /// The method by which items are added to a collection.
    /// <see href="http://purl.org/dc/terms/accrualMethod"></see></summary>
    let accrualMethod =
        Namespaced_IRI.parse _namespace_name "accrualMethod" |> NamespacedName

    /// <summary>
    /// The frequency with which items are added to a collection.
    /// <see href="http://purl.org/dc/terms/accrualPeriodicity"></see></summary>
    let accrualPeriodicity =
        Namespaced_IRI.parse _namespace_name "accrualPeriodicity" |> NamespacedName

    /// <summary>
    /// The policy governing the addition of items to a collection.
    /// <see href="http://purl.org/dc/terms/accrualPolicy"></see></summary>
    let accrualPolicy =
        Namespaced_IRI.parse _namespace_name "accrualPolicy" |> NamespacedName

    /// <summary>
    /// An alternative name for the resource.
    /// <see href="http://purl.org/dc/terms/alternative"></see></summary>
    let alternative =
        Namespaced_IRI.parse _namespace_name "alternative" |> NamespacedName

    /// <summary>
    /// A class of entity for whom the resource is intended or useful.
    /// <see href="http://purl.org/dc/terms/audience"></see></summary>
    let audience = Namespaced_IRI.parse _namespace_name "audience" |> NamespacedName
    /// <summary>
    /// Date (often a range) that the resource became or will become available.
    /// <see href="http://purl.org/dc/terms/available"></see></summary>
    let available = Namespaced_IRI.parse _namespace_name "available" |> NamespacedName
    /// <summary>
    /// A point or period of time associated with an event in the lifecycle of the resource.
    /// <see href="http://purl.org/dc/terms/date"></see></summary>
    let date = Namespaced_IRI.parse _namespace_name "date" |> NamespacedName

    /// <summary>
    /// A bibliographic reference for the resource.
    /// <see href="http://purl.org/dc/terms/bibliographicCitation"></see></summary>
    let bibliographicCitation =
        Namespaced_IRI.parse _namespace_name "bibliographicCitation" |> NamespacedName

    /// <summary>
    /// An unambiguous reference to the resource within a given context.
    /// <see href="http://purl.org/dc/terms/identifier"></see></summary>
    let identifier = Namespaced_IRI.parse _namespace_name "identifier" |> NamespacedName
    /// <summary>
    /// An established standard to which the described resource conforms.
    /// <see href="http://purl.org/dc/terms/conformsTo"></see></summary>
    let conformsTo = Namespaced_IRI.parse _namespace_name "conformsTo" |> NamespacedName
    /// <summary>
    /// A related resource.
    /// <see href="http://purl.org/dc/terms/relation"></see></summary>
    let relation = Namespaced_IRI.parse _namespace_name "relation" |> NamespacedName

    /// <summary>
    /// An entity responsible for making contributions to the resource.
    /// <see href="http://purl.org/dc/terms/contributor"></see></summary>
    let contributor =
        Namespaced_IRI.parse _namespace_name "contributor" |> NamespacedName

    /// <summary>
    /// The spatial or temporal topic of the resource, the spatial applicability of the resource, or the jurisdiction under which the resource is relevant.
    /// <see href="http://purl.org/dc/terms/coverage"></see></summary>
    let coverage = Namespaced_IRI.parse _namespace_name "coverage" |> NamespacedName
    /// <summary>
    /// Date of creation of the resource.
    /// <see href="http://purl.org/dc/terms/created"></see></summary>
    let created = Namespaced_IRI.parse _namespace_name "created" |> NamespacedName
    /// <summary>
    /// An entity primarily responsible for making the resource.
    /// <see href="http://purl.org/dc/terms/creator"></see></summary>
    let creator = Namespaced_IRI.parse _namespace_name "creator" |> NamespacedName

    /// <summary>
    /// Date of acceptance of the resource.
    /// <see href="http://purl.org/dc/terms/dateAccepted"></see></summary>
    let dateAccepted =
        Namespaced_IRI.parse _namespace_name "dateAccepted" |> NamespacedName

    /// <summary>
    /// Date of copyright.
    /// <see href="http://purl.org/dc/terms/dateCopyrighted"></see></summary>
    let dateCopyrighted =
        Namespaced_IRI.parse _namespace_name "dateCopyrighted" |> NamespacedName

    /// <summary>
    /// Date of submission of the resource.
    /// <see href="http://purl.org/dc/terms/dateSubmitted"></see></summary>
    let dateSubmitted =
        Namespaced_IRI.parse _namespace_name "dateSubmitted" |> NamespacedName

    /// <summary>
    /// A class of entity, defined in terms of progression through an educational or training context, for which the described resource is intended.
    /// <see href="http://purl.org/dc/terms/educationLevel"></see></summary>
    let educationLevel =
        Namespaced_IRI.parse _namespace_name "educationLevel" |> NamespacedName

    /// <summary>
    /// The size or duration of the resource.
    /// <see href="http://purl.org/dc/terms/extent"></see></summary>
    let extent = Namespaced_IRI.parse _namespace_name "extent" |> NamespacedName
    /// <summary>
    /// The file format, physical medium, or dimensions of the resource.
    /// <see href="http://purl.org/dc/terms/format"></see></summary>
    let format = Namespaced_IRI.parse _namespace_name "format" |> NamespacedName
    /// <summary>
    /// A related resource that is substantially the same as the pre-existing described resource, but in another format.
    /// <see href="http://purl.org/dc/terms/hasFormat"></see></summary>
    let hasFormat = Namespaced_IRI.parse _namespace_name "hasFormat" |> NamespacedName
    /// <summary>
    /// A related resource that is included either physically or logically in the described resource.
    /// <see href="http://purl.org/dc/terms/hasPart"></see></summary>
    let hasPart = Namespaced_IRI.parse _namespace_name "hasPart" |> NamespacedName

    /// <summary>
    /// A process, used to engender knowledge, attitudes and skills, that the described resource is designed to support.
    /// <see href="http://purl.org/dc/terms/instructionalMethod"></see></summary>
    let instructionalMethod =
        Namespaced_IRI.parse _namespace_name "instructionalMethod" |> NamespacedName

    /// <summary>
    /// A related resource that is substantially the same as the described resource, but in another format.
    /// <see href="http://purl.org/dc/terms/isFormatOf"></see></summary>
    let isFormatOf = Namespaced_IRI.parse _namespace_name "isFormatOf" |> NamespacedName
    /// <summary>
    /// A related resource in which the described resource is physically or logically included.
    /// <see href="http://purl.org/dc/terms/isPartOf"></see></summary>
    let isPartOf = Namespaced_IRI.parse _namespace_name "isPartOf" |> NamespacedName

    /// <summary>
    /// A related resource that references, cites, or otherwise points to the described resource.
    /// <see href="http://purl.org/dc/terms/isReferencedBy"></see></summary>
    let isReferencedBy =
        Namespaced_IRI.parse _namespace_name "isReferencedBy" |> NamespacedName

    /// <summary>
    /// A related resource that supplants, displaces, or supersedes the described resource.
    /// <see href="http://purl.org/dc/terms/isReplacedBy"></see></summary>
    let isReplacedBy =
        Namespaced_IRI.parse _namespace_name "isReplacedBy" |> NamespacedName

    /// <summary>
    /// A related resource that requires the described resource to support its function, delivery, or coherence.
    /// <see href="http://purl.org/dc/terms/isRequiredBy"></see></summary>
    let isRequiredBy =
        Namespaced_IRI.parse _namespace_name "isRequiredBy" |> NamespacedName

    /// <summary>
    /// A related resource of which the described resource is a version, edition, or adaptation.
    /// <see href="http://purl.org/dc/terms/isVersionOf"></see></summary>
    let isVersionOf =
        Namespaced_IRI.parse _namespace_name "isVersionOf" |> NamespacedName

    /// <summary>
    /// A language of the resource.
    /// <see href="http://purl.org/dc/terms/language"></see></summary>
    let language = Namespaced_IRI.parse _namespace_name "language" |> NamespacedName
    /// <summary>
    /// A legal document giving official permission to do something with the resource.
    /// <see href="http://purl.org/dc/terms/license"></see></summary>
    let license = Namespaced_IRI.parse _namespace_name "license" |> NamespacedName
    /// <summary>
    /// An entity that mediates access to the resource and for whom the resource is intended or useful.
    /// <see href="http://purl.org/dc/terms/mediator"></see></summary>
    let mediator = Namespaced_IRI.parse _namespace_name "mediator" |> NamespacedName
    /// <summary>
    /// The material or physical carrier of the resource.
    /// <see href="http://purl.org/dc/terms/medium"></see></summary>
    let medium = Namespaced_IRI.parse _namespace_name "medium" |> NamespacedName
    /// <summary>
    /// A statement of any changes in ownership and custody of the resource since its creation that are significant for its authenticity, integrity, and interpretation.
    /// <see href="http://purl.org/dc/terms/provenance"></see></summary>
    let provenance = Namespaced_IRI.parse _namespace_name "provenance" |> NamespacedName
    /// <summary>
    /// A related resource that is referenced, cited, or otherwise pointed to by the described resource.
    /// <see href="http://purl.org/dc/terms/references"></see></summary>
    let references = Namespaced_IRI.parse _namespace_name "references" |> NamespacedName
    /// <summary>
    /// A related resource that is supplanted, displaced, or superseded by the described resource.
    /// <see href="http://purl.org/dc/terms/replaces"></see></summary>
    let replaces = Namespaced_IRI.parse _namespace_name "replaces" |> NamespacedName
    /// <summary>
    /// A related resource that is required by the described resource to support its function, delivery, or coherence.
    /// <see href="http://purl.org/dc/terms/requires"></see></summary>
    let requires = Namespaced_IRI.parse _namespace_name "requires" |> NamespacedName

    /// <summary>
    /// A person or organization owning or managing rights over the resource.
    /// <see href="http://purl.org/dc/terms/rightsHolder"></see></summary>
    let rightsHolder =
        Namespaced_IRI.parse _namespace_name "rightsHolder" |> NamespacedName

    /// <summary>
    /// A related resource from which the described resource is derived.
    /// <see href="http://purl.org/dc/terms/source"></see></summary>
    let source = Namespaced_IRI.parse _namespace_name "source" |> NamespacedName
    /// <summary>
    /// Spatial characteristics of the resource.
    /// <see href="http://purl.org/dc/terms/spatial"></see></summary>
    let spatial = Namespaced_IRI.parse _namespace_name "spatial" |> NamespacedName
    /// <summary>
    /// The topic of the resource.
    /// <see href="http://purl.org/dc/terms/subject"></see></summary>
    let subject = Namespaced_IRI.parse _namespace_name "subject" |> NamespacedName

    /// <summary>
    /// A list of subunits of the resource.
    /// <see href="http://purl.org/dc/terms/tableOfContents"></see></summary>
    let tableOfContents =
        Namespaced_IRI.parse _namespace_name "tableOfContents" |> NamespacedName

    /// <summary>
    /// Temporal characteristics of the resource.
    /// <see href="http://purl.org/dc/terms/temporal"></see></summary>
    let temporal = Namespaced_IRI.parse _namespace_name "temporal" |> NamespacedName
    /// <summary>
    /// The nature or genre of the resource.
    /// <see href="http://purl.org/dc/terms/type"></see></summary>
    let type_ = Namespaced_IRI.parse _namespace_name "type" |> NamespacedName
    /// <summary>
    /// Date (often a range) of validity of a resource.
    /// <see href="http://purl.org/dc/terms/valid"></see></summary>
    let valid = Namespaced_IRI.parse _namespace_name "valid" |> NamespacedName

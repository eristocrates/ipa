namespace http.purl.org.dc.terms.slash

open DoxAletheia

module dcterms =
    let _namespace_name = "http://purl.org/dc/terms/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Date on which the resource was changed.
    /// <see href="http://purl.org/dc/terms/modified"></see></summary>
    let modified = _prefix "modified"
    /// <summary>
    /// An entity responsible for making the resource available.
    /// <see href="http://purl.org/dc/terms/publisher"></see></summary>
    let publisher = _prefix "publisher"
    /// <summary>
    /// A name given to the resource.
    /// <see href="http://purl.org/dc/terms/title"></see></summary>
    let title = _prefix "title"
    /// <summary>
    /// A resource that acts or has the power to act.
    /// <see href="http://purl.org/dc/terms/Agent"></see></summary>
    let Agent = _prefix "Agent"
    /// <summary>
    /// An account of the resource.
    /// <see href="http://purl.org/dc/terms/description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// A related resource that is a version, edition, or adaptation of the described resource.
    /// <see href="http://purl.org/dc/terms/hasVersion"></see></summary>
    let hasVersion = _prefix "hasVersion"
    /// <summary>
    /// Date of formal issuance (e.g., publication) of the resource.
    /// <see href="http://purl.org/dc/terms/issued"></see></summary>
    let issued = _prefix "issued"
    /// <summary>
    /// A group of agents.
    /// <see href="http://purl.org/dc/terms/AgentClass"></see></summary>
    let AgentClass = _prefix "AgentClass"
    /// <summary>
    /// A book, article, or other documentary resource.
    /// <see href="http://purl.org/dc/terms/BibliographicResource"></see></summary>
    let BibliographicResource = _prefix "BibliographicResource"
    /// <summary>
    /// The set of regions in space defined by their geographic coordinates according to the DCMI Box Encoding Scheme.
    /// <see href="http://purl.org/dc/terms/Box"></see></summary>
    let Box = _prefix "Box"
    /// <summary>
    /// The set of classes specified by the DCMI Type Vocabulary, used to categorize the nature or genre of the resource.
    /// <see href="http://purl.org/dc/terms/DCMIType"></see></summary>
    let DCMIType = _prefix "DCMIType"
    /// <summary>
    /// The set of conceptual resources specified by the Dewey Decimal Classification.
    /// <see href="http://purl.org/dc/terms/DDC"></see></summary>
    let DDC = _prefix "DDC"
    /// <summary>
    /// A digital resource format.
    /// <see href="http://purl.org/dc/terms/FileFormat"></see></summary>
    let FileFormat = _prefix "FileFormat"
    /// <summary>
    /// A file format or physical medium.
    /// <see href="http://purl.org/dc/terms/MediaType"></see></summary>
    let MediaType = _prefix "MediaType"
    /// <summary>
    /// A rate at which something recurs.
    /// <see href="http://purl.org/dc/terms/Frequency"></see></summary>
    let Frequency = _prefix "Frequency"
    /// <summary>
    /// The set of media types specified by the Internet Assigned Numbers Authority.
    /// <see href="http://purl.org/dc/terms/IMT"></see></summary>
    let IMT = _prefix "IMT"
    /// <summary>
    /// The set of codes listed in ISO 3166-1 for the representation of names of countries.
    /// <see href="http://purl.org/dc/terms/ISO3166"></see></summary>
    let ISO3166 = _prefix "ISO3166"
    /// <summary>
    /// The three-letter alphabetic codes listed in ISO639-2 for the representation of names of languages.
    /// <see href="http://purl.org/dc/terms/ISO639-2"></see></summary>
    let ``ISO639-2`` = _prefix "ISO639-2"
    /// <summary>
    /// The set of three-letter codes listed in ISO 639-3 for the representation of names of languages.
    /// <see href="http://purl.org/dc/terms/ISO639-3"></see></summary>
    let ``ISO639-3`` = _prefix "ISO639-3"
    /// <summary>
    /// The extent or range of judicial, law enforcement, or other authority.
    /// <see href="http://purl.org/dc/terms/Jurisdiction"></see></summary>
    let Jurisdiction = _prefix "Jurisdiction"
    /// <summary>
    /// A location, period of time, or jurisdiction.
    /// <see href="http://purl.org/dc/terms/LocationPeriodOrJurisdiction"></see></summary>
    let LocationPeriodOrJurisdiction = _prefix "LocationPeriodOrJurisdiction"
    /// <summary>
    /// The set of conceptual resources specified by the Library of Congress Classification.
    /// <see href="http://purl.org/dc/terms/LCC"></see></summary>
    let LCC = _prefix "LCC"
    /// <summary>
    /// The set of labeled concepts specified by the Library of Congress Subject Headings.
    /// <see href="http://purl.org/dc/terms/LCSH"></see></summary>
    let LCSH = _prefix "LCSH"
    /// <summary>
    /// A legal document giving official permission to do something with a Resource.
    /// <see href="http://purl.org/dc/terms/LicenseDocument"></see></summary>
    let LicenseDocument = _prefix "LicenseDocument"
    /// <summary>
    /// A statement about the intellectual property rights (IPR) held in or over a Resource, a legal document giving official permission to do something with a resource, or a statement about access rights.
    /// <see href="http://purl.org/dc/terms/RightsStatement"></see></summary>
    let RightsStatement = _prefix "RightsStatement"
    /// <summary>
    /// A system of signs, symbols, sounds, gestures, or rules used in communication.
    /// <see href="http://purl.org/dc/terms/LinguisticSystem"></see></summary>
    let LinguisticSystem = _prefix "LinguisticSystem"
    /// <summary>
    /// A spatial region or named place.
    /// <see href="http://purl.org/dc/terms/Location"></see></summary>
    let Location = _prefix "Location"
    /// <summary>
    /// The set of labeled concepts specified by the Medical Subject Headings.
    /// <see href="http://purl.org/dc/terms/MESH"></see></summary>
    let MESH = _prefix "MESH"
    /// <summary>
    /// A media type or extent.
    /// <see href="http://purl.org/dc/terms/MediaTypeOrExtent"></see></summary>
    let MediaTypeOrExtent = _prefix "MediaTypeOrExtent"
    /// <summary>
    /// A method by which resources are added to a collection.
    /// <see href="http://purl.org/dc/terms/MethodOfAccrual"></see></summary>
    let MethodOfAccrual = _prefix "MethodOfAccrual"
    /// <summary>
    /// A process that is used to engender knowledge, attitudes, and skills.
    /// <see href="http://purl.org/dc/terms/MethodOfInstruction"></see></summary>
    let MethodOfInstruction = _prefix "MethodOfInstruction"
    /// <summary>
    /// The set of conceptual resources specified by the National Library of Medicine Classification.
    /// <see href="http://purl.org/dc/terms/NLM"></see></summary>
    let NLM = _prefix "NLM"
    /// <summary>
    /// The set of time intervals defined by their limits according to the DCMI Period Encoding Scheme.
    /// <see href="http://purl.org/dc/terms/Period"></see></summary>
    let Period = _prefix "Period"
    /// <summary>
    /// An interval of time that is named or defined by its start and end dates.
    /// <see href="http://purl.org/dc/terms/PeriodOfTime"></see></summary>
    let PeriodOfTime = _prefix "PeriodOfTime"
    /// <summary>
    /// A physical material or carrier.
    /// <see href="http://purl.org/dc/terms/PhysicalMedium"></see></summary>
    let PhysicalMedium = _prefix "PhysicalMedium"
    /// <summary>
    /// A material thing.
    /// <see href="http://purl.org/dc/terms/PhysicalResource"></see></summary>
    let PhysicalResource = _prefix "PhysicalResource"
    /// <summary>
    /// The set of points in space defined by their geographic coordinates according to the DCMI Point Encoding Scheme.
    /// <see href="http://purl.org/dc/terms/Point"></see></summary>
    let Point = _prefix "Point"
    /// <summary>
    /// A plan or course of action by an authority, intended to influence and determine decisions, actions, and other matters.
    /// <see href="http://purl.org/dc/terms/Policy"></see></summary>
    let Policy = _prefix "Policy"
    /// <summary>
    /// A statement of any changes in ownership and custody of a resource since its creation that are significant for its authenticity, integrity, and interpretation.
    /// <see href="http://purl.org/dc/terms/ProvenanceStatement"></see></summary>
    let ProvenanceStatement = _prefix "ProvenanceStatement"
    /// <summary>
    /// The set of tags, constructed according to RFC 1766, for the identification of languages.
    /// <see href="http://purl.org/dc/terms/RFC1766"></see></summary>
    let RFC1766 = _prefix "RFC1766"
    /// <summary>
    /// The set of tags constructed according to RFC 3066 for the identification of languages.
    /// <see href="http://purl.org/dc/terms/RFC3066"></see></summary>
    let RFC3066 = _prefix "RFC3066"
    /// <summary>
    /// The set of tags constructed according to RFC 4646 for the identification of languages.
    /// <see href="http://purl.org/dc/terms/RFC4646"></see></summary>
    let RFC4646 = _prefix "RFC4646"
    /// <summary>
    /// The set of tags constructed according to RFC 5646 for the identification of languages.
    /// <see href="http://purl.org/dc/terms/RFC5646"></see></summary>
    let RFC5646 = _prefix "RFC5646"
    /// <summary>
    /// A dimension or extent, or a time taken to play or execute.
    /// <see href="http://purl.org/dc/terms/SizeOrDuration"></see></summary>
    let SizeOrDuration = _prefix "SizeOrDuration"
    /// <summary>
    /// A basis for comparison; a reference point against which other things can be evaluated.
    /// <see href="http://purl.org/dc/terms/Standard"></see></summary>
    let Standard = _prefix "Standard"
    /// <summary>
    /// The set of places specified by the Getty Thesaurus of Geographic Names.
    /// <see href="http://purl.org/dc/terms/TGN"></see></summary>
    let TGN = _prefix "TGN"
    /// <summary>
    /// The set of conceptual resources specified by the Universal Decimal Classification.
    /// <see href="http://purl.org/dc/terms/UDC"></see></summary>
    let UDC = _prefix "UDC"
    /// <summary>
    /// The set of identifiers constructed according to the generic syntax for Uniform Resource Identifiers as specified by the Internet Engineering Task Force.
    /// <see href="http://purl.org/dc/terms/URI"></see></summary>
    let URI = _prefix "URI"
    /// <summary>
    /// The set of dates and times constructed according to the W3C Date and Time Formats Specification.
    /// <see href="http://purl.org/dc/terms/W3CDTF"></see></summary>
    let W3CDTF = _prefix "W3CDTF"
    /// <summary>
    /// A summary of the resource.
    /// <see href="http://purl.org/dc/terms/abstract"></see></summary>
    let abstract_ = _prefix "abstract"
    /// <summary>
    /// Information about who can access the resource or an indication of its security status.
    /// <see href="http://purl.org/dc/terms/accessRights"></see></summary>
    let accessRights = _prefix "accessRights"
    /// <summary>
    /// Information about rights held in and over the resource.
    /// <see href="http://purl.org/dc/terms/rights"></see></summary>
    let rights = _prefix "rights"
    /// <summary>
    /// The method by which items are added to a collection.
    /// <see href="http://purl.org/dc/terms/accrualMethod"></see></summary>
    let accrualMethod = _prefix "accrualMethod"
    /// <summary>
    /// The frequency with which items are added to a collection.
    /// <see href="http://purl.org/dc/terms/accrualPeriodicity"></see></summary>
    let accrualPeriodicity = _prefix "accrualPeriodicity"
    /// <summary>
    /// The policy governing the addition of items to a collection.
    /// <see href="http://purl.org/dc/terms/accrualPolicy"></see></summary>
    let accrualPolicy = _prefix "accrualPolicy"
    /// <summary>
    /// An alternative name for the resource.
    /// <see href="http://purl.org/dc/terms/alternative"></see></summary>
    let alternative = _prefix "alternative"
    /// <summary>
    /// A class of entity for whom the resource is intended or useful.
    /// <see href="http://purl.org/dc/terms/audience"></see></summary>
    let audience = _prefix "audience"
    /// <summary>
    /// Date (often a range) that the resource became or will become available.
    /// <see href="http://purl.org/dc/terms/available"></see></summary>
    let available = _prefix "available"
    /// <summary>
    /// A point or period of time associated with an event in the lifecycle of the resource.
    /// <see href="http://purl.org/dc/terms/date"></see></summary>
    let date = _prefix "date"
    /// <summary>
    /// A bibliographic reference for the resource.
    /// <see href="http://purl.org/dc/terms/bibliographicCitation"></see></summary>
    let bibliographicCitation = _prefix "bibliographicCitation"
    /// <summary>
    /// An unambiguous reference to the resource within a given context.
    /// <see href="http://purl.org/dc/terms/identifier"></see></summary>
    let identifier = _prefix "identifier"
    /// <summary>
    /// An established standard to which the described resource conforms.
    /// <see href="http://purl.org/dc/terms/conformsTo"></see></summary>
    let conformsTo = _prefix "conformsTo"
    /// <summary>
    /// A related resource.
    /// <see href="http://purl.org/dc/terms/relation"></see></summary>
    let relation = _prefix "relation"
    /// <summary>
    /// An entity responsible for making contributions to the resource.
    /// <see href="http://purl.org/dc/terms/contributor"></see></summary>
    let contributor = _prefix "contributor"
    /// <summary>
    /// The spatial or temporal topic of the resource, the spatial applicability of the resource, or the jurisdiction under which the resource is relevant.
    /// <see href="http://purl.org/dc/terms/coverage"></see></summary>
    let coverage = _prefix "coverage"
    /// <summary>
    /// Date of creation of the resource.
    /// <see href="http://purl.org/dc/terms/created"></see></summary>
    let created = _prefix "created"
    /// <summary>
    /// An entity primarily responsible for making the resource.
    /// <see href="http://purl.org/dc/terms/creator"></see></summary>
    let creator = _prefix "creator"
    /// <summary>
    /// Date of acceptance of the resource.
    /// <see href="http://purl.org/dc/terms/dateAccepted"></see></summary>
    let dateAccepted = _prefix "dateAccepted"
    /// <summary>
    /// Date of copyright.
    /// <see href="http://purl.org/dc/terms/dateCopyrighted"></see></summary>
    let dateCopyrighted = _prefix "dateCopyrighted"
    /// <summary>
    /// Date of submission of the resource.
    /// <see href="http://purl.org/dc/terms/dateSubmitted"></see></summary>
    let dateSubmitted = _prefix "dateSubmitted"
    /// <summary>
    /// A class of entity, defined in terms of progression through an educational or training context, for which the described resource is intended.
    /// <see href="http://purl.org/dc/terms/educationLevel"></see></summary>
    let educationLevel = _prefix "educationLevel"
    /// <summary>
    /// The size or duration of the resource.
    /// <see href="http://purl.org/dc/terms/extent"></see></summary>
    let extent = _prefix "extent"
    /// <summary>
    /// The file format, physical medium, or dimensions of the resource.
    /// <see href="http://purl.org/dc/terms/format"></see></summary>
    let format = _prefix "format"
    /// <summary>
    /// A related resource that is substantially the same as the pre-existing described resource, but in another format.
    /// <see href="http://purl.org/dc/terms/hasFormat"></see></summary>
    let hasFormat = _prefix "hasFormat"
    /// <summary>
    /// A related resource that is included either physically or logically in the described resource.
    /// <see href="http://purl.org/dc/terms/hasPart"></see></summary>
    let hasPart = _prefix "hasPart"
    /// <summary>
    /// A process, used to engender knowledge, attitudes and skills, that the described resource is designed to support.
    /// <see href="http://purl.org/dc/terms/instructionalMethod"></see></summary>
    let instructionalMethod = _prefix "instructionalMethod"
    /// <summary>
    /// A related resource that is substantially the same as the described resource, but in another format.
    /// <see href="http://purl.org/dc/terms/isFormatOf"></see></summary>
    let isFormatOf = _prefix "isFormatOf"
    /// <summary>
    /// A related resource in which the described resource is physically or logically included.
    /// <see href="http://purl.org/dc/terms/isPartOf"></see></summary>
    let isPartOf = _prefix "isPartOf"
    /// <summary>
    /// A related resource that references, cites, or otherwise points to the described resource.
    /// <see href="http://purl.org/dc/terms/isReferencedBy"></see></summary>
    let isReferencedBy = _prefix "isReferencedBy"
    /// <summary>
    /// A related resource that supplants, displaces, or supersedes the described resource.
    /// <see href="http://purl.org/dc/terms/isReplacedBy"></see></summary>
    let isReplacedBy = _prefix "isReplacedBy"
    /// <summary>
    /// A related resource that requires the described resource to support its function, delivery, or coherence.
    /// <see href="http://purl.org/dc/terms/isRequiredBy"></see></summary>
    let isRequiredBy = _prefix "isRequiredBy"
    /// <summary>
    /// A related resource of which the described resource is a version, edition, or adaptation.
    /// <see href="http://purl.org/dc/terms/isVersionOf"></see></summary>
    let isVersionOf = _prefix "isVersionOf"
    /// <summary>
    /// A language of the resource.
    /// <see href="http://purl.org/dc/terms/language"></see></summary>
    let language = _prefix "language"
    /// <summary>
    /// A legal document giving official permission to do something with the resource.
    /// <see href="http://purl.org/dc/terms/license"></see></summary>
    let license = _prefix "license"
    /// <summary>
    /// An entity that mediates access to the resource and for whom the resource is intended or useful.
    /// <see href="http://purl.org/dc/terms/mediator"></see></summary>
    let mediator = _prefix "mediator"
    /// <summary>
    /// The material or physical carrier of the resource.
    /// <see href="http://purl.org/dc/terms/medium"></see></summary>
    let medium = _prefix "medium"
    /// <summary>
    /// A statement of any changes in ownership and custody of the resource since its creation that are significant for its authenticity, integrity, and interpretation.
    /// <see href="http://purl.org/dc/terms/provenance"></see></summary>
    let provenance = _prefix "provenance"
    /// <summary>
    /// A related resource that is referenced, cited, or otherwise pointed to by the described resource.
    /// <see href="http://purl.org/dc/terms/references"></see></summary>
    let references = _prefix "references"
    /// <summary>
    /// A related resource that is supplanted, displaced, or superseded by the described resource.
    /// <see href="http://purl.org/dc/terms/replaces"></see></summary>
    let replaces = _prefix "replaces"
    /// <summary>
    /// A related resource that is required by the described resource to support its function, delivery, or coherence.
    /// <see href="http://purl.org/dc/terms/requires"></see></summary>
    let requires = _prefix "requires"
    /// <summary>
    /// A person or organization owning or managing rights over the resource.
    /// <see href="http://purl.org/dc/terms/rightsHolder"></see></summary>
    let rightsHolder = _prefix "rightsHolder"
    /// <summary>
    /// A related resource from which the described resource is derived.
    /// <see href="http://purl.org/dc/terms/source"></see></summary>
    let source = _prefix "source"
    /// <summary>
    /// Spatial characteristics of the resource.
    /// <see href="http://purl.org/dc/terms/spatial"></see></summary>
    let spatial = _prefix "spatial"
    /// <summary>
    /// The topic of the resource.
    /// <see href="http://purl.org/dc/terms/subject"></see></summary>
    let subject = _prefix "subject"
    /// <summary>
    /// A list of subunits of the resource.
    /// <see href="http://purl.org/dc/terms/tableOfContents"></see></summary>
    let tableOfContents = _prefix "tableOfContents"
    /// <summary>
    /// Temporal characteristics of the resource.
    /// <see href="http://purl.org/dc/terms/temporal"></see></summary>
    let temporal = _prefix "temporal"
    /// <summary>
    /// The nature or genre of the resource.
    /// <see href="http://purl.org/dc/terms/type"></see></summary>
    let type_ = _prefix "type"
    /// <summary>
    /// Date (often a range) of validity of a resource.
    /// <see href="http://purl.org/dc/terms/valid"></see></summary>
    let valid = _prefix "valid"

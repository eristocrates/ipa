#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dcterms =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/dc/terms/" "dcterms"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A resource that acts or has the power to act.</para>
    ///   <para>rdfs:label : Agent</para>
    ///   <a href="http://purl.org/dc/terms/Agent">dcterms:Agent</a>
    /// </summary>
    let Agent = _prefixId.prefix "Agent"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A group of agents.</para>
    ///   <para>rdfs:label : Agent Class</para>
    ///   <a href="http://purl.org/dc/terms/AgentClass">dcterms:AgentClass</a>
    /// </summary>
    let AgentClass = _prefixId.prefix "AgentClass"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A book, article, or other documentary resource.</para>
    ///   <para>rdfs:label : Bibliographic Resource</para>
    ///   <a href="http://purl.org/dc/terms/BibliographicResource">dcterms:BibliographicResource</a>
    /// </summary>
    let BibliographicResource = _prefixId.prefix "BibliographicResource"
    let Box = _prefixId.prefix "Box"
    let DCMIType = _prefixId.prefix "DCMIType"
    let DDC = _prefixId.prefix "DDC"
    let Extent = _prefixId.prefix "Extent"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A digital resource format.</para>
    ///   <para>rdfs:label : File Format</para>
    ///   <a href="http://purl.org/dc/terms/FileFormat">dcterms:FileFormat</a>
    /// </summary>
    let FileFormat = _prefixId.prefix "FileFormat"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A rate at which something recurs.</para>
    ///   <para>rdfs:label : Frequency</para>
    ///   <a href="http://purl.org/dc/terms/Frequency">dcterms:Frequency</a>
    /// </summary>
    let Frequency = _prefixId.prefix "Frequency"
    let IMT = _prefixId.prefix "IMT"
    let ISO3166 = _prefixId.prefix "ISO3166"
    let ISO639_2 = _prefixId.prefix "ISO639-2"
    let ISO639_3 = _prefixId.prefix "ISO639-3"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : The extent or range of judicial, law enforcement, or other authority.</para>
    ///   <para>rdfs:label : Jurisdiction</para>
    ///   <a href="http://purl.org/dc/terms/Jurisdiction">dcterms:Jurisdiction</a>
    /// </summary>
    let Jurisdiction = _prefixId.prefix "Jurisdiction"
    let LCC = _prefixId.prefix "LCC"
    let LCSH = _prefixId.prefix "LCSH"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A legal document giving official permission to do something with a resource.</para>
    ///   <para>rdfs:label : License Document</para>
    ///   <a href="http://purl.org/dc/terms/LicenseDocument">dcterms:LicenseDocument</a>
    /// </summary>
    let LicenseDocument = _prefixId.prefix "LicenseDocument"
    /// <summary>
    ///   <para>dcterms:description : Written, spoken, sign, and computer languages are linguistic systems.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A system of signs, symbols, sounds, gestures, or rules used in communication.</para>
    ///   <para>rdfs:label : Linguistic System</para>
    ///   <a href="http://purl.org/dc/terms/LinguisticSystem">dcterms:LinguisticSystem</a>
    /// </summary>
    let LinguisticSystem = _prefixId.prefix "LinguisticSystem"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A spatial region or named place.</para>
    ///   <para>rdfs:label : Location</para>
    ///   <a href="http://purl.org/dc/terms/Location">dcterms:Location</a>
    /// </summary>
    let Location = _prefixId.prefix "Location"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A location, period of time, or jurisdiction.</para>
    ///   <para>rdfs:label : Location, Period, or Jurisdiction</para>
    ///   <a href="http://purl.org/dc/terms/LocationPeriodOrJurisdiction">dcterms:LocationPeriodOrJurisdiction</a>
    /// </summary>
    let LocationPeriodOrJurisdiction = _prefixId.prefix "LocationPeriodOrJurisdiction"
    let MESH = _prefixId.prefix "MESH"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A file format or physical medium.</para>
    ///   <para>rdfs:label : Media Type</para>
    ///   <a href="http://purl.org/dc/terms/MediaType">dcterms:MediaType</a>
    /// </summary>
    let MediaType = _prefixId.prefix "MediaType"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A media type or extent.</para>
    ///   <para>rdfs:label : Media Type or Extent</para>
    ///   <a href="http://purl.org/dc/terms/MediaTypeOrExtent">dcterms:MediaTypeOrExtent</a>
    /// </summary>
    let MediaTypeOrExtent = _prefixId.prefix "MediaTypeOrExtent"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A method by which resources are added to a collection.</para>
    ///   <para>rdfs:label : Method of Accrual</para>
    ///   <a href="http://purl.org/dc/terms/MethodOfAccrual">dcterms:MethodOfAccrual</a>
    /// </summary>
    let MethodOfAccrual = _prefixId.prefix "MethodOfAccrual"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A process that is used to engender knowledge, attitudes, and skills.</para>
    ///   <para>rdfs:label : Method of Instruction</para>
    ///   <a href="http://purl.org/dc/terms/MethodOfInstruction">dcterms:MethodOfInstruction</a>
    /// </summary>
    let MethodOfInstruction = _prefixId.prefix "MethodOfInstruction"
    let NLM = _prefixId.prefix "NLM"
    let Period = _prefixId.prefix "Period"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : An interval of time that is named or defined by its start and end dates.</para>
    ///   <para>rdfs:label : Period of Time</para>
    ///   <a href="http://purl.org/dc/terms/PeriodOfTime">dcterms:PeriodOfTime</a>
    /// </summary>
    let PeriodOfTime = _prefixId.prefix "PeriodOfTime"
    /// <summary>
    ///   <para>dcterms:description : Examples include paper, canvas, or DVD.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A physical material or carrier.</para>
    ///   <para>rdfs:label : Physical Medium</para>
    ///   <a href="http://purl.org/dc/terms/PhysicalMedium">dcterms:PhysicalMedium</a>
    /// </summary>
    let PhysicalMedium = _prefixId.prefix "PhysicalMedium"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A material thing.</para>
    ///   <para>rdfs:label : Physical Resource</para>
    ///   <a href="http://purl.org/dc/terms/PhysicalResource">dcterms:PhysicalResource</a>
    /// </summary>
    let PhysicalResource = _prefixId.prefix "PhysicalResource"
    let Point = _prefixId.prefix "Point"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A plan or course of action by an authority, intended to influence and determine decisions, actions, and other matters.</para>
    ///   <para>rdfs:label : Policy</para>
    ///   <a href="http://purl.org/dc/terms/Policy">dcterms:Policy</a>
    /// </summary>
    let Policy = _prefixId.prefix "Policy"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : Any changes in ownership and custody of a resource since its creation that are significant for its authenticity, integrity, and interpretation.</para>
    ///   <para>rdfs:label : Provenance Statement</para>
    ///   <a href="http://purl.org/dc/terms/ProvenanceStatement">dcterms:ProvenanceStatement</a>
    /// </summary>
    let ProvenanceStatement = _prefixId.prefix "ProvenanceStatement"
    let RFC1766 = _prefixId.prefix "RFC1766"
    let RFC3066 = _prefixId.prefix "RFC3066"
    let RFC4646 = _prefixId.prefix "RFC4646"
    let RFC5646 = _prefixId.prefix "RFC5646"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A statement about the intellectual property rights (IPR) held in or over a resource, a legal document giving official permission to do something with a resource, or a statement about access rights.</para>
    ///   <para>rdfs:label : Rights Statement</para>
    ///   <a href="http://purl.org/dc/terms/RightsStatement">dcterms:RightsStatement</a>
    /// </summary>
    let RightsStatement = _prefixId.prefix "RightsStatement"
    /// <summary>
    ///   <para>dcterms:description : Examples include a number of pages, a specification of length, width, and breadth, or a period in hours, minutes, and seconds.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A dimension or extent, or a time taken to play or execute.</para>
    ///   <para>rdfs:label : Size or Duration</para>
    ///   <a href="http://purl.org/dc/terms/SizeOrDuration">dcterms:SizeOrDuration</a>
    /// </summary>
    let SizeOrDuration = _prefixId.prefix "SizeOrDuration"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A reference point against which other things can be evaluated or compared.</para>
    ///   <para>rdfs:label : Standard</para>
    ///   <a href="http://purl.org/dc/terms/Standard">dcterms:Standard</a>
    /// </summary>
    let Standard = _prefixId.prefix "Standard"
    let TGN = _prefixId.prefix "TGN"
    let UDC = _prefixId.prefix "UDC"
    let URI = _prefixId.prefix "URI"
    let W3CDTF = _prefixId.prefix "W3CDTF"
    /// <summary>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : A summary of the resource.</para>
    ///   <para>rdfs:label : Abstract</para>
    ///   <a href="http://purl.org/dc/terms/abstract">dcterms:abstract</a>
    /// </summary>
    let abstract_ = _prefixId.prefix "abstract"
    /// <summary>
    ///   <para>dcterms:description : Access Rights may include information regarding access or restrictions based on privacy, security, or other policies.</para>
    ///   <para>dcterms:issued : 2003-02-15^^xsd:date</para>
    ///   <para>rdfs:comment : Information about who access the resource or an indication of its security status.</para>
    ///   <para>rdfs:label : Access Rights</para>
    ///   <a href="http://purl.org/dc/terms/accessRights">dcterms:accessRights</a>
    /// </summary>
    let accessRights = _prefixId.prefix "accessRights"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to use a value from the Collection Description Accrual Method Vocabulary [[DCMI-ACCRUALMETHOD](https://dublincore.org/groups/collections/accrual-method/)].</para>
    ///   <para>dcterms:issued : 2005-06-13^^xsd:date</para>
    ///   <para>rdfs:comment : The method by which items are added to a collection.</para>
    ///   <para>rdfs:label : Accrual Method</para>
    ///   <a href="http://purl.org/dc/terms/accrualMethod">dcterms:accrualMethod</a>
    /// </summary>
    let accrualMethod = _prefixId.prefix "accrualMethod"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to use a value from the Collection Description Frequency Vocabulary [[DCMI-COLLFREQ](https://dublincore.org/groups/collections/frequency/)].</para>
    ///   <para>dcterms:issued : 2005-06-13^^xsd:date</para>
    ///   <para>rdfs:comment : The frequency with which items are added to a collection.</para>
    ///   <para>rdfs:label : Accrual Periodicity</para>
    ///   <a href="http://purl.org/dc/terms/accrualPeriodicity">dcterms:accrualPeriodicity</a>
    /// </summary>
    let accrualPeriodicity = _prefixId.prefix "accrualPeriodicity"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to use a value from the Collection Description Accrual Policy Vocabulary [[DCMI-ACCRUALPOLICY](https://dublincore.org/groups/collections/accrual-policy/)].</para>
    ///   <para>dcterms:issued : 2005-06-13^^xsd:date</para>
    ///   <para>rdfs:comment : The policy governing the addition of items to a collection.</para>
    ///   <para>rdfs:label : Accrual Policy</para>
    ///   <a href="http://purl.org/dc/terms/accrualPolicy">dcterms:accrualPolicy</a>
    /// </summary>
    let accrualPolicy = _prefixId.prefix "accrualPolicy"
    /// <summary>
    ///   <para>dcterms:description : The distinction between titles and alternative titles is application-specific.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : An alternative name for the resource.</para>
    ///   <para>rdfs:label : Alternative Title</para>
    ///   <a href="http://purl.org/dc/terms/alternative">dcterms:alternative</a>
    /// </summary>
    let alternative = _prefixId.prefix "alternative"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to use this property with non-literal values from a vocabulary of audience types.</para>
    ///   <para>dcterms:issued : 2001-05-21^^xsd:date</para>
    ///   <para>rdfs:comment : A class of agents for whom the resource is intended or useful.</para>
    ///   <para>rdfs:label : Audience</para>
    ///   <a href="http://purl.org/dc/terms/audience">dcterms:audience</a>
    /// </summary>
    let audience = _prefixId.prefix "audience"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to describe the date, date/time, or period of time as recommended for the property Date, of which this is a subproperty.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : Date that the resource became or will become available.</para>
    ///   <para>rdfs:label : Date Available</para>
    ///   <a href="http://purl.org/dc/terms/available">dcterms:available</a>
    /// </summary>
    let available = _prefixId.prefix "available"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to include sufficient bibliographic detail to identify the resource as unambiguously as possible.</para>
    ///   <para>dcterms:issued : 2003-02-15^^xsd:date</para>
    ///   <para>rdfs:comment : A bibliographic reference for the resource.</para>
    ///   <para>rdfs:label : Bibliographic Citation</para>
    ///   <a href="http://purl.org/dc/terms/bibliographicCitation">dcterms:bibliographicCitation</a>
    /// </summary>
    let bibliographicCitation = _prefixId.prefix "bibliographicCitation"
    /// <summary>
    ///   <para>dcterms:issued : 2001-05-21^^xsd:date</para>
    ///   <para>rdfs:comment : An established standard to which the described resource conforms.</para>
    ///   <para>rdfs:label : Conforms To</para>
    ///   <a href="http://purl.org/dc/terms/conformsTo">dcterms:conformsTo</a>
    /// </summary>
    let conformsTo = _prefixId.prefix "conformsTo"
    /// <summary>
    ///   <para>dcterms:description : The guidelines for using names of persons or organizations as creators apply to contributors.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : An entity responsible for making contributions to the resource.</para>
    ///   <para>rdfs:label : Contributor</para>
    ///   <a href="http://purl.org/dc/terms/contributor">dcterms:contributor</a>
    /// </summary>
    let contributor = _prefixId.prefix "contributor"
    /// <summary>
    ///   <para>dcterms:description : Spatial topic and spatial applicability may be a named place or a location specified by its geographic coordinates. Temporal topic may be a named period, date, or date range. A jurisdiction may be a named administrative entity or a geographic place to which the resource applies. Recommended practice is to use a controlled vocabulary such as the Getty Thesaurus of Geographic Names [[TGN](https://www.getty.edu/research/tools/vocabulary/tgn/index.html)]. Where appropriate, named places or time periods may be used in preference to numeric identifiers such as sets of coordinates or date ranges.  Because coverage is so broadly defined, it is preferable to use the more specific subproperties Temporal Coverage and Spatial Coverage.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : The spatial or temporal topic of the resource, spatial applicability of the resource, or jurisdiction under which the resource is relevant.</para>
    ///   <para>rdfs:label : Coverage</para>
    ///   <a href="http://purl.org/dc/terms/coverage">dcterms:coverage</a>
    /// </summary>
    let coverage = _prefixId.prefix "coverage"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to describe the date, date/time, or period of time as recommended for the property Date, of which this is a subproperty.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : Date of creation of the resource.</para>
    ///   <para>rdfs:label : Date Created</para>
    ///   <a href="http://purl.org/dc/terms/created">dcterms:created</a>
    /// </summary>
    let created = _prefixId.prefix "created"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to identify the creator with a URI.  If this is not possible or feasible, a literal value that identifies the creator may be provided.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : An entity responsible for making the resource.</para>
    ///   <para>rdfs:label : Creator</para>
    ///   <a href="http://purl.org/dc/terms/creator">dcterms:creator</a>
    /// </summary>
    let creator = _prefixId.prefix "creator"
    /// <summary>
    ///   <para>dcterms:description : Date may be used to express temporal information at any level of granularity.  Recommended practice is to express the date, date/time, or period of time according to ISO 8601-1 [[ISO 8601-1](https://www.iso.org/iso-8601-date-and-time-format.html)] or a published profile of the ISO standard, such as the W3C Note on Date and Time Formats [[W3CDTF](https://www.w3.org/TR/NOTE-datetime)] or the Extended Date/Time Format Specification [[EDTF](http://www.loc.gov/standards/datetime/)].  If the full date is unknown, month and year (YYYY-MM) or just year (YYYY) may be used. Date ranges may be specified using ISO 8601 period of time specification in which start and end dates are separated by a '/' (slash) character.  Either the start or end date may be missing.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A point or period of time associated with an event in the lifecycle of the resource.</para>
    ///   <para>rdfs:label : Date</para>
    ///   <a href="http://purl.org/dc/terms/date">dcterms:date</a>
    /// </summary>
    let date = _prefixId.prefix "date"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to describe the date, date/time, or period of time as recommended for the property Date, of which this is a subproperty.  Examples of resources to which a date of acceptance may be relevant are a thesis (accepted by a university department) or an article (accepted by a journal).</para>
    ///   <para>dcterms:issued : 2002-07-13^^xsd:date</para>
    ///   <para>rdfs:comment : Date of acceptance of the resource.</para>
    ///   <para>rdfs:label : Date Accepted</para>
    ///   <a href="http://purl.org/dc/terms/dateAccepted">dcterms:dateAccepted</a>
    /// </summary>
    let dateAccepted = _prefixId.prefix "dateAccepted"
    /// <summary>
    ///   <para>dcterms:description : Typically a year.  Recommended practice is to describe the date, date/time, or period of time as recommended for the property Date, of which this is a subproperty.</para>
    ///   <para>dcterms:issued : 2002-07-13^^xsd:date</para>
    ///   <para>rdfs:comment : Date of copyright of the resource.</para>
    ///   <para>rdfs:label : Date Copyrighted</para>
    ///   <a href="http://purl.org/dc/terms/dateCopyrighted">dcterms:dateCopyrighted</a>
    /// </summary>
    let dateCopyrighted = _prefixId.prefix "dateCopyrighted"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to describe the date, date/time, or period of time as recommended for the property Date, of which this is a subproperty.  Examples of resources to which a 'Date Submitted' may be relevant include a thesis (submitted to a university department) or an article (submitted to a journal).</para>
    ///   <para>dcterms:issued : 2002-07-13^^xsd:date</para>
    ///   <para>rdfs:comment : Date of submission of the resource.</para>
    ///   <para>rdfs:label : Date Submitted</para>
    ///   <a href="http://purl.org/dc/terms/dateSubmitted">dcterms:dateSubmitted</a>
    /// </summary>
    let dateSubmitted = _prefixId.prefix "dateSubmitted"
    /// <summary>
    ///   <para>dcterms:description : Description may include but is not limited to: an abstract, a table of contents, a graphical representation, or a free-text account of the resource.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : An account of the resource.</para>
    ///   <para>rdfs:label : Description</para>
    ///   <a href="http://purl.org/dc/terms/description">dcterms:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>dcterms:issued : 2002-07-13^^xsd:date</para>
    ///   <para>rdfs:comment : A class of agents, defined in terms of progression through an educational or training context, for which the described resource is intended.</para>
    ///   <para>rdfs:label : Audience Education Level</para>
    ///   <a href="http://purl.org/dc/terms/educationLevel">dcterms:educationLevel</a>
    /// </summary>
    let educationLevel = _prefixId.prefix "educationLevel"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to specify the file size in megabytes and duration in ISO 8601 format.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : The size or duration of the resource.</para>
    ///   <para>rdfs:label : Extent</para>
    ///   <a href="http://purl.org/dc/terms/extent">dcterms:extent</a>
    /// </summary>
    let extent = _prefixId.prefix "extent"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to use a controlled vocabulary where available. For example, for file formats one could use the list of Internet Media Types [[MIME](https://www.iana.org/assignments/media-types/media-types.xhtml)].  Examples of dimensions include size and duration.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : The file format, physical medium, or dimensions of the resource.</para>
    ///   <para>rdfs:label : Format</para>
    ///   <a href="http://purl.org/dc/terms/format">dcterms:format</a>
    /// </summary>
    let format = _prefixId.prefix "format"
    /// <summary>
    ///   <para>dcterms:description : This property is intended to be used with non-literal values. This property is an inverse property of Is Format Of.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : A related resource that is substantially the same as the pre-existing described resource, but in another format.</para>
    ///   <para>rdfs:label : Has Format</para>
    ///   <a href="http://purl.org/dc/terms/hasFormat">dcterms:hasFormat</a>
    /// </summary>
    let hasFormat = _prefixId.prefix "hasFormat"
    /// <summary>
    ///   <para>dcterms:description : This property is intended to be used with non-literal values. This property is an inverse property of Is Part Of.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : A related resource that is included either physically or logically in the described resource.</para>
    ///   <para>rdfs:label : Has Part</para>
    ///   <a href="http://purl.org/dc/terms/hasPart">dcterms:hasPart</a>
    /// </summary>
    let hasPart = _prefixId.prefix "hasPart"
    /// <summary>
    ///   <para>dcterms:description : Changes in version imply substantive changes in content rather than differences in format. This property is intended to be used with non-literal values. This property is an inverse property of Is Version Of.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : A related resource that is a version, edition, or adaptation of the described resource.</para>
    ///   <para>rdfs:label : Has Version</para>
    ///   <a href="http://purl.org/dc/terms/hasVersion">dcterms:hasVersion</a>
    /// </summary>
    let hasVersion = _prefixId.prefix "hasVersion"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to identify the resource by means of a string conforming to an identification system. Examples include International Standard Book Number (ISBN), Digital Object Identifier (DOI), and Uniform Resource Name (URN).  Persistent identifiers should be provided as HTTP URIs.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : An unambiguous reference to the resource within a given context.</para>
    ///   <para>rdfs:label : Identifier</para>
    ///   <a href="http://purl.org/dc/terms/identifier">dcterms:identifier</a>
    /// </summary>
    let identifier = _prefixId.prefix "identifier"
    /// <summary>
    ///   <para>dcterms:description : Instructional Method typically includes ways of presenting instructional materials or conducting instructional activities, patterns of learner-to-learner and learner-to-instructor interactions, and mechanisms by which group and individual levels of learning are measured.  Instructional methods include all aspects of the instruction and learning processes from planning and implementation through evaluation and feedback.</para>
    ///   <para>dcterms:issued : 2005-06-13^^xsd:date</para>
    ///   <para>rdfs:comment : A process, used to engender knowledge, attitudes and skills, that the described resource is designed to support.</para>
    ///   <para>rdfs:label : Instructional Method</para>
    ///   <a href="http://purl.org/dc/terms/instructionalMethod">dcterms:instructionalMethod</a>
    /// </summary>
    let instructionalMethod = _prefixId.prefix "instructionalMethod"
    /// <summary>
    ///   <para>dcterms:description : This property is intended to be used with non-literal values. This property is an inverse property of Has Format.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : A pre-existing related resource that is substantially the same as the described resource, but in another format.</para>
    ///   <para>rdfs:label : Is Format Of</para>
    ///   <a href="http://purl.org/dc/terms/isFormatOf">dcterms:isFormatOf</a>
    /// </summary>
    let isFormatOf = _prefixId.prefix "isFormatOf"
    /// <summary>
    ///   <para>dcterms:description : This property is intended to be used with non-literal values. This property is an inverse property of Has Part.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : A related resource in which the described resource is physically or logically included.</para>
    ///   <para>rdfs:label : Is Part Of</para>
    ///   <a href="http://purl.org/dc/terms/isPartOf">dcterms:isPartOf</a>
    /// </summary>
    let isPartOf = _prefixId.prefix "isPartOf"
    /// <summary>
    ///   <para>dcterms:description : This property is intended to be used with non-literal values. This property is an inverse property of References.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : A related resource that references, cites, or otherwise points to the described resource.</para>
    ///   <para>rdfs:label : Is Referenced By</para>
    ///   <a href="http://purl.org/dc/terms/isReferencedBy">dcterms:isReferencedBy</a>
    /// </summary>
    let isReferencedBy = _prefixId.prefix "isReferencedBy"
    /// <summary>
    ///   <para>dcterms:description : This property is intended to be used with non-literal values. This property is an inverse property of Replaces.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : A related resource that supplants, displaces, or supersedes the described resource.</para>
    ///   <para>rdfs:label : Is Replaced By</para>
    ///   <a href="http://purl.org/dc/terms/isReplacedBy">dcterms:isReplacedBy</a>
    /// </summary>
    let isReplacedBy = _prefixId.prefix "isReplacedBy"
    /// <summary>
    ///   <para>dcterms:description : This property is intended to be used with non-literal values. This property is an inverse property of Requires.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : A related resource that requires the described resource to support its function, delivery, or coherence.</para>
    ///   <para>rdfs:label : Is Required By</para>
    ///   <a href="http://purl.org/dc/terms/isRequiredBy">dcterms:isRequiredBy</a>
    /// </summary>
    let isRequiredBy = _prefixId.prefix "isRequiredBy"
    /// <summary>
    ///   <para>dcterms:description : Changes in version imply substantive changes in content rather than differences in format. This property is intended to be used with non-literal values. This property is an inverse property of Has Version.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : A related resource of which the described resource is a version, edition, or adaptation.</para>
    ///   <para>rdfs:label : Is Version Of</para>
    ///   <a href="http://purl.org/dc/terms/isVersionOf">dcterms:isVersionOf</a>
    /// </summary>
    let isVersionOf = _prefixId.prefix "isVersionOf"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to describe the date, date/time, or period of time as recommended for the property Date, of which this is a subproperty.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : Date of formal issuance of the resource.</para>
    ///   <para>rdfs:label : Date Issued</para>
    ///   <a href="http://purl.org/dc/terms/issued">dcterms:issued</a>
    /// </summary>
    let issued = _prefixId.prefix "issued"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to use either a non-literal value representing a language from a controlled vocabulary such as ISO 639-2 or ISO 639-3, or a literal value consisting of an IETF Best Current Practice 47 [[IETF-BCP47](https://tools.ietf.org/html/bcp47)] language tag.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A language of the resource.</para>
    ///   <para>rdfs:label : Language</para>
    ///   <a href="http://purl.org/dc/terms/language">dcterms:language</a>
    /// </summary>
    let language = _prefixId.prefix "language"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to identify the license document with a URI. If this is not possible or feasible, a literal value that identifies the license may be provided.</para>
    ///   <para>dcterms:issued : 2004-06-14^^xsd:date</para>
    ///   <para>rdfs:comment : A legal document giving official permission to do something with the resource.</para>
    ///   <para>rdfs:label : License</para>
    ///   <a href="http://purl.org/dc/terms/license">dcterms:license</a>
    /// </summary>
    let license = _prefixId.prefix "license"
    /// <summary>
    ///   <para>dcterms:description : In an educational context, a mediator might be a parent, teacher, teaching assistant, or care-giver.</para>
    ///   <para>dcterms:issued : 2001-05-21^^xsd:date</para>
    ///   <para>rdfs:comment : An entity that mediates access to the resource.</para>
    ///   <para>rdfs:label : Mediator</para>
    ///   <a href="http://purl.org/dc/terms/mediator">dcterms:mediator</a>
    /// </summary>
    let mediator = _prefixId.prefix "mediator"
    /// <summary>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : The material or physical carrier of the resource.</para>
    ///   <para>rdfs:label : Medium</para>
    ///   <a href="http://purl.org/dc/terms/medium">dcterms:medium</a>
    /// </summary>
    let medium = _prefixId.prefix "medium"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to describe the date, date/time, or period of time as recommended for the property Date, of which this is a subproperty.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : Date on which the resource was changed.</para>
    ///   <para>rdfs:label : Date Modified</para>
    ///   <a href="http://purl.org/dc/terms/modified">dcterms:modified</a>
    /// </summary>
    let modified = _prefixId.prefix "modified"
    /// <summary>
    ///   <para>dcterms:description : The statement may include a description of any changes successive custodians made to the resource.</para>
    ///   <para>dcterms:issued : 2004-09-20^^xsd:date</para>
    ///   <para>rdfs:comment : A statement of any changes in ownership and custody of the resource since its creation that are significant for its authenticity, integrity, and interpretation.</para>
    ///   <para>rdfs:label : Provenance</para>
    ///   <a href="http://purl.org/dc/terms/provenance">dcterms:provenance</a>
    /// </summary>
    let provenance = _prefixId.prefix "provenance"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : An entity responsible for making the resource available.</para>
    ///   <para>rdfs:label : Publisher</para>
    ///   <a href="http://purl.org/dc/terms/publisher">dcterms:publisher</a>
    /// </summary>
    let publisher = _prefixId.prefix "publisher"
    /// <summary>
    ///   <para>dcterms:description : This property is intended to be used with non-literal values. This property is an inverse property of Is Referenced By.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : A related resource that is referenced, cited, or otherwise pointed to by the described resource.</para>
    ///   <para>rdfs:label : References</para>
    ///   <a href="http://purl.org/dc/terms/references">dcterms:references</a>
    /// </summary>
    let references = _prefixId.prefix "references"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to identify the related resource by means of a URI.  If this is not possible or feasible, a string conforming to a formal identification system may be provided.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A related resource.</para>
    ///   <para>rdfs:label : Relation</para>
    ///   <a href="http://purl.org/dc/terms/relation">dcterms:relation</a>
    /// </summary>
    let relation = _prefixId.prefix "relation"
    /// <summary>
    ///   <para>dcterms:description : This property is intended to be used with non-literal values. This property is an inverse property of Is Replaced By.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : A related resource that is supplanted, displaced, or superseded by the described resource.</para>
    ///   <para>rdfs:label : Replaces</para>
    ///   <a href="http://purl.org/dc/terms/replaces">dcterms:replaces</a>
    /// </summary>
    let replaces = _prefixId.prefix "replaces"
    /// <summary>
    ///   <para>dcterms:description : This property is intended to be used with non-literal values. This property is an inverse property of Is Required By.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : A related resource that is required by the described resource to support its function, delivery, or coherence.</para>
    ///   <para>rdfs:label : Requires</para>
    ///   <a href="http://purl.org/dc/terms/requires">dcterms:requires</a>
    /// </summary>
    let requires = _prefixId.prefix "requires"
    /// <summary>
    ///   <para>dcterms:description : Typically, rights information includes a statement about various property rights associated with the resource, including intellectual property rights.  Recommended practice is to refer to a rights statement with a URI.  If this is not possible or feasible, a literal value (name, label, or short text) may be provided.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : Information about rights held in and over the resource.</para>
    ///   <para>rdfs:label : Rights</para>
    ///   <a href="http://purl.org/dc/terms/rights">dcterms:rights</a>
    /// </summary>
    let rights = _prefixId.prefix "rights"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to refer to the rights holder with a URI. If this is not possible or feasible, a literal value that identifies the rights holder may be provided.</para>
    ///   <para>dcterms:issued : 2004-06-14^^xsd:date</para>
    ///   <para>rdfs:comment : A person or organization owning or managing rights over the resource.</para>
    ///   <para>rdfs:label : Rights Holder</para>
    ///   <a href="http://purl.org/dc/terms/rightsHolder">dcterms:rightsHolder</a>
    /// </summary>
    let rightsHolder = _prefixId.prefix "rightsHolder"
    /// <summary>
    ///   <para>dcterms:description : This property is intended to be used with non-literal values. The described resource may be derived from the related resource in whole or in part. Best practice is to identify the related resource by means of a URI or a string conforming to a formal identification system.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A related resource from which the described resource is derived.</para>
    ///   <para>rdfs:label : Source</para>
    ///   <a href="http://purl.org/dc/terms/source">dcterms:source</a>
    /// </summary>
    let source = _prefixId.prefix "source"
    /// <summary>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : Spatial characteristics of the resource.</para>
    ///   <para>rdfs:label : Spatial Coverage</para>
    ///   <a href="http://purl.org/dc/terms/spatial">dcterms:spatial</a>
    /// </summary>
    let spatial = _prefixId.prefix "spatial"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to refer to the subject with a URI. If this is not possible or feasible, a literal value that identifies the subject may be provided. Both should preferably refer to a subject in a controlled vocabulary.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A topic of the resource.</para>
    ///   <para>rdfs:label : Subject</para>
    ///   <a href="http://purl.org/dc/terms/subject">dcterms:subject</a>
    /// </summary>
    let subject = _prefixId.prefix "subject"
    /// <summary>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : A list of subunits of the resource.</para>
    ///   <para>rdfs:label : Table Of Contents</para>
    ///   <a href="http://purl.org/dc/terms/tableOfContents">dcterms:tableOfContents</a>
    /// </summary>
    let tableOfContents = _prefixId.prefix "tableOfContents"
    /// <summary>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : Temporal characteristics of the resource.</para>
    ///   <para>rdfs:label : Temporal Coverage</para>
    ///   <a href="http://purl.org/dc/terms/temporal">dcterms:temporal</a>
    /// </summary>
    let temporal = _prefixId.prefix "temporal"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A name given to the resource.</para>
    ///   <para>rdfs:label : Title</para>
    ///   <a href="http://purl.org/dc/terms/title">dcterms:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to use a controlled vocabulary such as the DCMI Type Vocabulary [[DCMI-TYPE](http://dublincore.org/documents/dcmi-type-vocabulary/)]. To describe the file format, physical medium, or dimensions of the resource, use the property Format.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : The nature or genre of the resource.</para>
    ///   <para>rdfs:label : Type</para>
    ///   <a href="http://purl.org/dc/terms/type">dcterms:type</a>
    /// </summary>
    let type_ = _prefixId.prefix "type"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to describe the date, date/time, or period of time as recommended for the property Date, of which this is a subproperty.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : Date (often a range) of validity of a resource.</para>
    ///   <para>rdfs:label : Date Valid</para>
    ///   <a href="http://purl.org/dc/terms/valid">dcterms:valid</a>
    /// </summary>
    let valid = _prefixId.prefix "valid"

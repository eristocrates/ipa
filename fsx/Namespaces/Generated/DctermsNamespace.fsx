#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dcterms =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/dc/terms/" "dcterms"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Agent</para>
    ///   <para>rdfs:comment : A resource that acts or has the power to act.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:description : Examples of Agent include person, organization, and software agent.</para>
    ///   <a href="http://purl.org/dc/terms/Agent">dcterms:Agent</a>
    /// </summary>
    let Agent = _prefixId.prefix "Agent"
    /// <summary>
    ///   <para>rdfs:label : Agent Class</para>
    ///   <para>rdfs:comment : A group of agents.</para>
    ///   <para>dcterms:modified : 2012-06-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:description : Examples of Agent Class include groups seen as classes, such as students, women, charities, lecturers.</para>
    ///   <a href="http://purl.org/dc/terms/AgentClass">dcterms:AgentClass</a>
    /// </summary>
    let AgentClass = _prefixId.prefix "AgentClass"
    /// <summary>
    ///   <para>rdfs:label : Bibliographic Resource</para>
    ///   <para>rdfs:comment : A book, article, or other documentary resource.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/BibliographicResource">dcterms:BibliographicResource</a>
    /// </summary>
    let BibliographicResource = _prefixId.prefix "BibliographicResource"
    let Box = _prefixId.prefix "Box"
    let DCMIType = _prefixId.prefix "DCMIType"
    let DDC = _prefixId.prefix "DDC"
    /// <summary>
    ///   <para>rdfs:label : File Format</para>
    ///   <para>rdfs:comment : A digital resource format.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:description : Examples include the formats defined by the list of Internet Media Types.</para>
    ///   <a href="http://purl.org/dc/terms/FileFormat">dcterms:FileFormat</a>
    /// </summary>
    let FileFormat = _prefixId.prefix "FileFormat"
    /// <summary>
    ///   <para>rdfs:label : Frequency</para>
    ///   <para>rdfs:comment : A rate at which something recurs.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/Frequency">dcterms:Frequency</a>
    /// </summary>
    let Frequency = _prefixId.prefix "Frequency"
    let IMT = _prefixId.prefix "IMT"
    let ISO3166 = _prefixId.prefix "ISO3166"
    let ISO639_2 = _prefixId.prefix "ISO639-2"
    let ISO639_3 = _prefixId.prefix "ISO639-3"
    /// <summary>
    ///   <para>rdfs:label : Jurisdiction</para>
    ///   <para>rdfs:comment : The extent or range of judicial, law enforcement, or other authority.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/Jurisdiction">dcterms:Jurisdiction</a>
    /// </summary>
    let Jurisdiction = _prefixId.prefix "Jurisdiction"
    let LCC = _prefixId.prefix "LCC"
    let LCSH = _prefixId.prefix "LCSH"
    /// <summary>
    ///   <para>rdfs:label : License Document</para>
    ///   <para>rdfs:comment : A legal document giving official permission to do something with a Resource.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/LicenseDocument">dcterms:LicenseDocument</a>
    /// </summary>
    let LicenseDocument = _prefixId.prefix "LicenseDocument"
    /// <summary>
    ///   <para>rdfs:label : Linguistic System</para>
    ///   <para>rdfs:comment : A system of signs, symbols, sounds, gestures, or rules used in communication.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:description : Examples include written, spoken, sign, and computer languages.</para>
    ///   <a href="http://purl.org/dc/terms/LinguisticSystem">dcterms:LinguisticSystem</a>
    /// </summary>
    let LinguisticSystem = _prefixId.prefix "LinguisticSystem"
    /// <summary>
    ///   <para>rdfs:label : Location</para>
    ///   <para>rdfs:comment : A spatial region or named place.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/Location">dcterms:Location</a>
    /// </summary>
    let Location = _prefixId.prefix "Location"
    /// <summary>
    ///   <para>rdfs:label : Location, Period, or Jurisdiction</para>
    ///   <para>rdfs:comment : A location, period of time, or jurisdiction.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/LocationPeriodOrJurisdiction">dcterms:LocationPeriodOrJurisdiction</a>
    /// </summary>
    let LocationPeriodOrJurisdiction = _prefixId.prefix "LocationPeriodOrJurisdiction"
    let MESH = _prefixId.prefix "MESH"
    /// <summary>
    ///   <para>rdfs:label : Media Type</para>
    ///   <para>rdfs:comment : A file format or physical medium.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/MediaType">dcterms:MediaType</a>
    /// </summary>
    let MediaType = _prefixId.prefix "MediaType"
    /// <summary>
    ///   <para>rdfs:label : Media Type or Extent</para>
    ///   <para>rdfs:comment : A media type or extent.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/MediaTypeOrExtent">dcterms:MediaTypeOrExtent</a>
    /// </summary>
    let MediaTypeOrExtent = _prefixId.prefix "MediaTypeOrExtent"
    /// <summary>
    ///   <para>rdfs:label : Method of Accrual</para>
    ///   <para>rdfs:comment : A method by which resources are added to a collection.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/MethodOfAccrual">dcterms:MethodOfAccrual</a>
    /// </summary>
    let MethodOfAccrual = _prefixId.prefix "MethodOfAccrual"
    /// <summary>
    ///   <para>rdfs:label : Method of Instruction</para>
    ///   <para>rdfs:comment : A process that is used to engender knowledge, attitudes, and skills.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/MethodOfInstruction">dcterms:MethodOfInstruction</a>
    /// </summary>
    let MethodOfInstruction = _prefixId.prefix "MethodOfInstruction"
    let NLM = _prefixId.prefix "NLM"
    let Period = _prefixId.prefix "Period"
    /// <summary>
    ///   <para>rdfs:label : Period of Time</para>
    ///   <para>rdfs:comment : An interval of time that is named or defined by its start and end dates.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/PeriodOfTime">dcterms:PeriodOfTime</a>
    /// </summary>
    let PeriodOfTime = _prefixId.prefix "PeriodOfTime"
    /// <summary>
    ///   <para>rdfs:label : Physical Medium</para>
    ///   <para>rdfs:comment : A physical material or carrier.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:description : Examples include paper, canvas, or DVD.</para>
    ///   <a href="http://purl.org/dc/terms/PhysicalMedium">dcterms:PhysicalMedium</a>
    /// </summary>
    let PhysicalMedium = _prefixId.prefix "PhysicalMedium"
    /// <summary>
    ///   <para>rdfs:label : Physical Resource</para>
    ///   <para>rdfs:comment : A material thing.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/PhysicalResource">dcterms:PhysicalResource</a>
    /// </summary>
    let PhysicalResource = _prefixId.prefix "PhysicalResource"
    let Point = _prefixId.prefix "Point"
    /// <summary>
    ///   <para>rdfs:label : Policy</para>
    ///   <para>rdfs:comment : A plan or course of action by an authority, intended to influence and determine decisions, actions, and other matters.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/Policy">dcterms:Policy</a>
    /// </summary>
    let Policy = _prefixId.prefix "Policy"
    /// <summary>
    ///   <para>rdfs:label : Provenance Statement</para>
    ///   <para>rdfs:comment : A statement of any changes in ownership and custody of a resource since its creation that are significant for its authenticity, integrity, and interpretation.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/ProvenanceStatement">dcterms:ProvenanceStatement</a>
    /// </summary>
    let ProvenanceStatement = _prefixId.prefix "ProvenanceStatement"
    let RFC1766 = _prefixId.prefix "RFC1766"
    let RFC3066 = _prefixId.prefix "RFC3066"
    let RFC4646 = _prefixId.prefix "RFC4646"
    let RFC5646 = _prefixId.prefix "RFC5646"
    /// <summary>
    ///   <para>rdfs:label : Rights Statement</para>
    ///   <para>rdfs:comment : A statement about the intellectual property rights (IPR) held in or over a Resource, a legal document giving official permission to do something with a resource, or a statement about access rights.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/RightsStatement">dcterms:RightsStatement</a>
    /// </summary>
    let RightsStatement = _prefixId.prefix "RightsStatement"
    /// <summary>
    ///   <para>rdfs:label : Size or Duration</para>
    ///   <para>rdfs:comment : A dimension or extent, or a time taken to play or execute.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:description : Examples include a number of pages, a specification of length, width, and breadth, or a period in hours, minutes, and seconds.</para>
    ///   <a href="http://purl.org/dc/terms/SizeOrDuration">dcterms:SizeOrDuration</a>
    /// </summary>
    let SizeOrDuration = _prefixId.prefix "SizeOrDuration"
    /// <summary>
    ///   <para>rdfs:label : Standard</para>
    ///   <para>rdfs:comment : A basis for comparison; a reference point against which other things can be evaluated.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/Standard">dcterms:Standard</a>
    /// </summary>
    let Standard = _prefixId.prefix "Standard"
    let TGN = _prefixId.prefix "TGN"
    let UDC = _prefixId.prefix "UDC"
    let URI = _prefixId.prefix "URI"
    let W3CDTF = _prefixId.prefix "W3CDTF"
    /// <summary>
    ///   <para>rdfs:label : Abstract</para>
    ///   <para>rdfs:comment : A summary of the resource.</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/abstract">dcterms:abstract</a>
    /// </summary>
    let abstract_ = _prefixId.prefix "abstract"
    /// <summary>
    ///   <para>rdfs:label : Access Rights</para>
    ///   <para>dcterms:issued : 2003-02-15^^xsd:date</para>
    ///   <para>rdfs:comment : Information about who can access the resource or an indication of its security status.</para>
    ///   <para>dcterms:description : Access Rights may include information regarding access or restrictions based on privacy, security, or other policies.</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/accessRights">dcterms:accessRights</a>
    /// </summary>
    let accessRights = _prefixId.prefix "accessRights"
    /// <summary>
    ///   <para>rdfs:label : Accrual Method</para>
    ///   <para>rdfs:comment : The method by which items are added to a collection.</para>
    ///   <para>dcterms:modified : 2010-10-11^^xsd:date</para>
    ///   <para>dcterms:issued : 2005-06-13^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/accrualMethod">dcterms:accrualMethod</a>
    /// </summary>
    let accrualMethod = _prefixId.prefix "accrualMethod"
    /// <summary>
    ///   <para>rdfs:label : Accrual Periodicity</para>
    ///   <para>rdfs:comment : The frequency with which items are added to a collection.</para>
    ///   <para>dcterms:modified : 2010-10-11^^xsd:date</para>
    ///   <para>dcterms:issued : 2005-06-13^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/accrualPeriodicity">dcterms:accrualPeriodicity</a>
    /// </summary>
    let accrualPeriodicity = _prefixId.prefix "accrualPeriodicity"
    /// <summary>
    ///   <para>rdfs:label : Accrual Policy</para>
    ///   <para>rdfs:comment : The policy governing the addition of items to a collection.</para>
    ///   <para>dcterms:modified : 2010-10-11^^xsd:date</para>
    ///   <para>dcterms:issued : 2005-06-13^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/accrualPolicy">dcterms:accrualPolicy</a>
    /// </summary>
    let accrualPolicy = _prefixId.prefix "accrualPolicy"
    /// <summary>
    ///   <para>rdfs:label : Alternative Title</para>
    ///   <para>dcterms:modified : 2010-10-11^^xsd:date</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>dcterms:description : The distinction between titles and alternative titles is application-specific.</para>
    ///   <para>rdfs:comment : An alternative name for the resource.</para>
    ///   <a href="http://purl.org/dc/terms/alternative">dcterms:alternative</a>
    /// </summary>
    let alternative = _prefixId.prefix "alternative"
    /// <summary>
    ///   <para>rdfs:label : Audience</para>
    ///   <para>rdfs:comment : A class of entity for whom the resource is intended or useful.</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2001-05-21^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/audience">dcterms:audience</a>
    /// </summary>
    let audience = _prefixId.prefix "audience"
    /// <summary>
    ///   <para>rdfs:comment : Date (often a range) that the resource became or will become available.</para>
    ///   <para>rdfs:label : Date Available</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/available">dcterms:available</a>
    /// </summary>
    let available = _prefixId.prefix "available"
    /// <summary>
    ///   <para>dcterms:description : Recommended practice is to include sufficient bibliographic detail to identify the resource as unambiguously as possible.</para>
    ///   <para>rdfs:comment : A bibliographic reference for the resource.</para>
    ///   <para>dcterms:issued : 2003-02-15^^xsd:date</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:label : Bibliographic Citation</para>
    ///   <a href="http://purl.org/dc/terms/bibliographicCitation">dcterms:bibliographicCitation</a>
    /// </summary>
    let bibliographicCitation = _prefixId.prefix "bibliographicCitation"
    /// <summary>
    ///   <para>dcterms:issued : 2001-05-21^^xsd:date</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : An established standard to which the described resource conforms.</para>
    ///   <para>rdfs:label : Conforms To</para>
    ///   <a href="http://purl.org/dc/terms/conformsTo">dcterms:conformsTo</a>
    /// </summary>
    let conformsTo = _prefixId.prefix "conformsTo"
    /// <summary>
    ///   <para>rdfs:comment : An entity responsible for making contributions to the resource.</para>
    ///   <para>dcterms:description : Examples of a Contributor include a person, an organization, or a service.</para>
    ///   <para>rdfs:label : Contributor</para>
    ///   <para>dcterms:modified : 2010-10-11^^xsd:date</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/contributor">dcterms:contributor</a>
    /// </summary>
    let contributor = _prefixId.prefix "contributor"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : The spatial or temporal topic of the resource, the spatial applicability of the resource, or the jurisdiction under which the resource is relevant.</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:description : Spatial topic and spatial applicability may be a named place or a location specified by its geographic coordinates. Temporal topic may be a named period, date, or date range. A jurisdiction may be a named administrative entity or a geographic place to which the resource applies. Recommended best practice is to use a controlled vocabulary such as the Thesaurus of Geographic Names [TGN]. Where appropriate, named places or time periods can be used in preference to numeric identifiers such as sets of coordinates or date ranges.</para>
    ///   <para>rdfs:label : Coverage</para>
    ///   <a href="http://purl.org/dc/terms/coverage">dcterms:coverage</a>
    /// </summary>
    let coverage = _prefixId.prefix "coverage"
    /// <summary>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : Date of creation of the resource.</para>
    ///   <para>rdfs:label : Date Created</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/created">dcterms:created</a>
    /// </summary>
    let created = _prefixId.prefix "created"
    /// <summary>
    ///   <para>dcterms:modified : 2010-10-11^^xsd:date</para>
    ///   <para>rdfs:comment : An entity primarily responsible for making the resource.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:label : Creator</para>
    ///   <para>dcterms:description : Examples of a Creator include a person, an organization, or a service.</para>
    ///   <a href="http://purl.org/dc/terms/creator">dcterms:creator</a>
    /// </summary>
    let creator = _prefixId.prefix "creator"
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A point or period of time associated with an event in the lifecycle of the resource.</para>
    ///   <para>dcterms:description : Date may be used to express temporal information at any level of granularity.  Recommended best practice is to use an encoding scheme, such as the W3CDTF profile of ISO 8601 [W3CDTF].</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:label : Date</para>
    ///   <a href="http://purl.org/dc/terms/date">dcterms:date</a>
    /// </summary>
    let date = _prefixId.prefix "date"
    /// <summary>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : Date of acceptance of the resource.</para>
    ///   <para>rdfs:label : Date Accepted</para>
    ///   <para>dcterms:description : Examples of resources to which a Date Accepted may be relevant are a thesis (accepted by a university department) or an article (accepted by a journal).</para>
    ///   <para>dcterms:issued : 2002-07-13^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/dateAccepted">dcterms:dateAccepted</a>
    /// </summary>
    let dateAccepted = _prefixId.prefix "dateAccepted"
    /// <summary>
    ///   <para>rdfs:label : Date Copyrighted</para>
    ///   <para>rdfs:comment : Date of copyright.</para>
    ///   <para>dcterms:issued : 2002-07-13^^xsd:date</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/dateCopyrighted">dcterms:dateCopyrighted</a>
    /// </summary>
    let dateCopyrighted = _prefixId.prefix "dateCopyrighted"
    /// <summary>
    ///   <para>rdfs:label : Date Submitted</para>
    ///   <para>rdfs:comment : Date of submission of the resource.</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2002-07-13^^xsd:date</para>
    ///   <para>dcterms:description : Examples of resources to which a Date Submitted may be relevant are a thesis (submitted to a university department) or an article (submitted to a journal).</para>
    ///   <a href="http://purl.org/dc/terms/dateSubmitted">dcterms:dateSubmitted</a>
    /// </summary>
    let dateSubmitted = _prefixId.prefix "dateSubmitted"
    /// <summary>
    ///   <para>rdfs:label : Description</para>
    ///   <para>rdfs:comment : An account of the resource.</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:description : Description may include but is not limited to: an abstract, a table of contents, a graphical representation, or a free-text account of the resource.</para>
    ///   <a href="http://purl.org/dc/terms/description">dcterms:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:label : Audience Education Level</para>
    ///   <para>rdfs:comment : A class of entity, defined in terms of progression through an educational or training context, for which the described resource is intended.</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2002-07-13^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/educationLevel">dcterms:educationLevel</a>
    /// </summary>
    let educationLevel = _prefixId.prefix "educationLevel"
    /// <summary>
    ///   <para>rdfs:comment : The size or duration of the resource.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:label : Extent</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/extent">dcterms:extent</a>
    /// </summary>
    let extent = _prefixId.prefix "extent"
    /// <summary>
    ///   <para>dcterms:description : Examples of dimensions include size and duration. Recommended best practice is to use a controlled vocabulary such as the list of Internet Media Types [MIME].</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : The file format, physical medium, or dimensions of the resource.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:label : Format</para>
    ///   <a href="http://purl.org/dc/terms/format">dcterms:format</a>
    /// </summary>
    let format = _prefixId.prefix "format"
    /// <summary>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A related resource that is substantially the same as the pre-existing described resource, but in another format.</para>
    ///   <para>rdfs:label : Has Format</para>
    ///   <para>skos:note : This term is intended to be used with non-literal values as defined in the DCMI Abstract Model (http://dublincore.org/documents/abstract-model/).  As of December 2007, the DCMI Usage Board is seeking a way to express this intention with a formal range declaration.</para>
    ///   <a href="http://purl.org/dc/terms/hasFormat">dcterms:hasFormat</a>
    /// </summary>
    let hasFormat = _prefixId.prefix "hasFormat"
    /// <summary>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : A related resource that is included either physically or logically in the described resource.</para>
    ///   <para>skos:note : This term is intended to be used with non-literal values as defined in the DCMI Abstract Model (http://dublincore.org/documents/abstract-model/).  As of December 2007, the DCMI Usage Board is seeking a way to express this intention with a formal range declaration.</para>
    ///   <para>rdfs:label : Has Part</para>
    ///   <a href="http://purl.org/dc/terms/hasPart">dcterms:hasPart</a>
    /// </summary>
    let hasPart = _prefixId.prefix "hasPart"
    /// <summary>
    ///   <para>rdfs:label : Has Version</para>
    ///   <para>rdfs:comment : A related resource that is a version, edition, or adaptation of the described resource.</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>skos:note : This term is intended to be used with non-literal values as defined in the DCMI Abstract Model (http://dublincore.org/documents/abstract-model/).  As of December 2007, the DCMI Usage Board is seeking a way to express this intention with a formal range declaration.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/hasVersion">dcterms:hasVersion</a>
    /// </summary>
    let hasVersion = _prefixId.prefix "hasVersion"
    /// <summary>
    ///   <para>rdfs:label : Identifier</para>
    ///   <para>dcterms:description : Recommended best practice is to identify the resource by means of a string conforming to a formal identification system. </para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : An unambiguous reference to the resource within a given context.</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/identifier">dcterms:identifier</a>
    /// </summary>
    let identifier = _prefixId.prefix "identifier"
    /// <summary>
    ///   <para>rdfs:label : Instructional Method</para>
    ///   <para>rdfs:comment : A process, used to engender knowledge, attitudes and skills, that the described resource is designed to support.</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2005-06-13^^xsd:date</para>
    ///   <para>dcterms:description : Instructional Method will typically include ways of presenting instructional materials or conducting instructional activities, patterns of learner-to-learner and learner-to-instructor interactions, and mechanisms by which group and individual levels of learning are measured.  Instructional methods include all aspects of the instruction and learning processes from planning and implementation through evaluation and feedback.</para>
    ///   <a href="http://purl.org/dc/terms/instructionalMethod">dcterms:instructionalMethod</a>
    /// </summary>
    let instructionalMethod = _prefixId.prefix "instructionalMethod"
    /// <summary>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>skos:note : This term is intended to be used with non-literal values as defined in the DCMI Abstract Model (http://dublincore.org/documents/abstract-model/).  As of December 2007, the DCMI Usage Board is seeking a way to express this intention with a formal range declaration.</para>
    ///   <para>rdfs:label : Is Format Of</para>
    ///   <para>rdfs:comment : A related resource that is substantially the same as the described resource, but in another format.</para>
    ///   <a href="http://purl.org/dc/terms/isFormatOf">dcterms:isFormatOf</a>
    /// </summary>
    let isFormatOf = _prefixId.prefix "isFormatOf"
    /// <summary>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:label : Is Part Of</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>skos:note : This term is intended to be used with non-literal values as defined in the DCMI Abstract Model (http://dublincore.org/documents/abstract-model/).  As of December 2007, the DCMI Usage Board is seeking a way to express this intention with a formal range declaration.</para>
    ///   <para>rdfs:comment : A related resource in which the described resource is physically or logically included.</para>
    ///   <a href="http://purl.org/dc/terms/isPartOf">dcterms:isPartOf</a>
    /// </summary>
    let isPartOf = _prefixId.prefix "isPartOf"
    /// <summary>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>skos:note : This term is intended to be used with non-literal values as defined in the DCMI Abstract Model (http://dublincore.org/documents/abstract-model/).  As of December 2007, the DCMI Usage Board is seeking a way to express this intention with a formal range declaration.</para>
    ///   <para>rdfs:comment : A related resource that references, cites, or otherwise points to the described resource.</para>
    ///   <para>rdfs:label : Is Referenced By</para>
    ///   <a href="http://purl.org/dc/terms/isReferencedBy">dcterms:isReferencedBy</a>
    /// </summary>
    let isReferencedBy = _prefixId.prefix "isReferencedBy"
    /// <summary>
    ///   <para>skos:note : This term is intended to be used with non-literal values as defined in the DCMI Abstract Model (http://dublincore.org/documents/abstract-model/).  As of December 2007, the DCMI Usage Board is seeking a way to express this intention with a formal range declaration.</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:label : Is Replaced By</para>
    ///   <para>rdfs:comment : A related resource that supplants, displaces, or supersedes the described resource.</para>
    ///   <a href="http://purl.org/dc/terms/isReplacedBy">dcterms:isReplacedBy</a>
    /// </summary>
    let isReplacedBy = _prefixId.prefix "isReplacedBy"
    /// <summary>
    ///   <para>rdfs:comment : A related resource that requires the described resource to support its function, delivery, or coherence.</para>
    ///   <para>rdfs:label : Is Required By</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>skos:note : This term is intended to be used with non-literal values as defined in the DCMI Abstract Model (http://dublincore.org/documents/abstract-model/).  As of December 2007, the DCMI Usage Board is seeking a way to express this intention with a formal range declaration.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/isRequiredBy">dcterms:isRequiredBy</a>
    /// </summary>
    let isRequiredBy = _prefixId.prefix "isRequiredBy"
    /// <summary>
    ///   <para>skos:note : This term is intended to be used with non-literal values as defined in the DCMI Abstract Model (http://dublincore.org/documents/abstract-model/).  As of December 2007, the DCMI Usage Board is seeking a way to express this intention with a formal range declaration.</para>
    ///   <para>rdfs:label : Is Version Of</para>
    ///   <para>rdfs:comment : A related resource of which the described resource is a version, edition, or adaptation.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>dcterms:description : Changes in version imply substantive changes in content rather than differences in format.</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/isVersionOf">dcterms:isVersionOf</a>
    /// </summary>
    let isVersionOf = _prefixId.prefix "isVersionOf"
    /// <summary>
    ///   <para>rdfs:label : Date Issued</para>
    ///   <para>rdfs:comment : Date of formal issuance (e.g., publication) of the resource.</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/issued">dcterms:issued</a>
    /// </summary>
    let issued = _prefixId.prefix "issued"
    /// <summary>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:label : Language</para>
    ///   <para>dcterms:description : Recommended best practice is to use a controlled vocabulary such as RFC 4646 [RFC4646].</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A language of the resource.</para>
    ///   <a href="http://purl.org/dc/terms/language">dcterms:language</a>
    /// </summary>
    let language = _prefixId.prefix "language"
    /// <summary>
    ///   <para>rdfs:comment : A legal document giving official permission to do something with the resource.</para>
    ///   <para>dcterms:issued : 2004-06-14^^xsd:date</para>
    ///   <para>rdfs:label : License</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/license">dcterms:license</a>
    /// </summary>
    let license = _prefixId.prefix "license"
    /// <summary>
    ///   <para>rdfs:label : Mediator</para>
    ///   <para>dcterms:issued : 2001-05-21^^xsd:date</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : An entity that mediates access to the resource and for whom the resource is intended or useful.</para>
    ///   <para>dcterms:description : In an educational context, a mediator might be a parent, teacher, teaching assistant, or care-giver.</para>
    ///   <a href="http://purl.org/dc/terms/mediator">dcterms:mediator</a>
    /// </summary>
    let mediator = _prefixId.prefix "mediator"
    /// <summary>
    ///   <para>rdfs:comment : The material or physical carrier of the resource.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:label : Medium</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/medium">dcterms:medium</a>
    /// </summary>
    let medium = _prefixId.prefix "medium"
    /// <summary>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:label : Date Modified</para>
    ///   <para>rdfs:comment : Date on which the resource was changed.</para>
    ///   <a href="http://purl.org/dc/terms/modified">dcterms:modified</a>
    /// </summary>
    let modified = _prefixId.prefix "modified"
    /// <summary>
    ///   <para>rdfs:label : Provenance</para>
    ///   <para>rdfs:comment : A statement of any changes in ownership and custody of the resource since its creation that are significant for its authenticity, integrity, and interpretation.</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2004-09-20^^xsd:date</para>
    ///   <para>dcterms:description : The statement may include a description of any changes successive custodians made to the resource.</para>
    ///   <a href="http://purl.org/dc/terms/provenance">dcterms:provenance</a>
    /// </summary>
    let provenance = _prefixId.prefix "provenance"
    /// <summary>
    ///   <para>dcterms:modified : 2010-10-11^^xsd:date</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : An entity responsible for making the resource available.</para>
    ///   <para>rdfs:label : Publisher</para>
    ///   <para>dcterms:description : Examples of a Publisher include a person, an organization, or a service.</para>
    ///   <a href="http://purl.org/dc/terms/publisher">dcterms:publisher</a>
    /// </summary>
    let publisher = _prefixId.prefix "publisher"
    /// <summary>
    ///   <para>skos:note : This term is intended to be used with non-literal values as defined in the DCMI Abstract Model (http://dublincore.org/documents/abstract-model/).  As of December 2007, the DCMI Usage Board is seeking a way to express this intention with a formal range declaration.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:label : References</para>
    ///   <para>rdfs:comment : A related resource that is referenced, cited, or otherwise pointed to by the described resource.</para>
    ///   <a href="http://purl.org/dc/terms/references">dcterms:references</a>
    /// </summary>
    let references = _prefixId.prefix "references"
    /// <summary>
    ///   <para>skos:note : This term is intended to be used with non-literal values as defined in the DCMI Abstract Model (http://dublincore.org/documents/abstract-model/).  As of December 2007, the DCMI Usage Board is seeking a way to express this intention with a formal range declaration.</para>
    ///   <para>rdfs:comment : A related resource.</para>
    ///   <para>dcterms:description : Recommended best practice is to identify the related resource by means of a string conforming to a formal identification system. </para>
    ///   <para>rdfs:label : Relation</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/relation">dcterms:relation</a>
    /// </summary>
    let relation = _prefixId.prefix "relation"
    /// <summary>
    ///   <para>skos:note : This term is intended to be used with non-literal values as defined in the DCMI Abstract Model (http://dublincore.org/documents/abstract-model/).  As of December 2007, the DCMI Usage Board is seeking a way to express this intention with a formal range declaration.</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A related resource that is supplanted, displaced, or superseded by the described resource.</para>
    ///   <para>rdfs:label : Replaces</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/replaces">dcterms:replaces</a>
    /// </summary>
    let replaces = _prefixId.prefix "replaces"
    /// <summary>
    ///   <para>rdfs:comment : A related resource that is required by the described resource to support its function, delivery, or coherence.</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:label : Requires</para>
    ///   <para>skos:note : This term is intended to be used with non-literal values as defined in the DCMI Abstract Model (http://dublincore.org/documents/abstract-model/).  As of December 2007, the DCMI Usage Board is seeking a way to express this intention with a formal range declaration.</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/requires">dcterms:requires</a>
    /// </summary>
    let requires = _prefixId.prefix "requires"
    /// <summary>
    ///   <para>rdfs:label : Rights</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:description : Typically, rights information includes a statement about various property rights associated with the resource, including intellectual property rights.</para>
    ///   <para>rdfs:comment : Information about rights held in and over the resource.</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/rights">dcterms:rights</a>
    /// </summary>
    let rights = _prefixId.prefix "rights"
    /// <summary>
    ///   <para>rdfs:label : Rights Holder</para>
    ///   <para>rdfs:comment : A person or organization owning or managing rights over the resource.</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2004-06-14^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/rightsHolder">dcterms:rightsHolder</a>
    /// </summary>
    let rightsHolder = _prefixId.prefix "rightsHolder"
    /// <summary>
    ///   <para>dcterms:description : The described resource may be derived from the related resource in whole or in part. Recommended best practice is to identify the related resource by means of a string conforming to a formal identification system.</para>
    ///   <para>skos:note : This term is intended to be used with non-literal values as defined in the DCMI Abstract Model (http://dublincore.org/documents/abstract-model/).  As of December 2007, the DCMI Usage Board is seeking a way to express this intention with a formal range declaration.</para>
    ///   <para>rdfs:comment : A related resource from which the described resource is derived.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:label : Source</para>
    ///   <a href="http://purl.org/dc/terms/source">dcterms:source</a>
    /// </summary>
    let source = _prefixId.prefix "source"
    /// <summary>
    ///   <para>rdfs:comment : Spatial characteristics of the resource.</para>
    ///   <para>rdfs:label : Spatial Coverage</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/spatial">dcterms:spatial</a>
    /// </summary>
    let spatial = _prefixId.prefix "spatial"
    /// <summary>
    ///   <para>dcterms:modified : 2012-06-14^^xsd:date</para>
    ///   <para>dcterms:description : Typically, the subject will be represented using keywords, key phrases, or classification codes. Recommended best practice is to use a controlled vocabulary.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>skos:note : This term is intended to be used with non-literal values as defined in the DCMI Abstract Model (http://dublincore.org/documents/abstract-model/).  As of December 2007, the DCMI Usage Board is seeking a way to express this intention with a formal range declaration.</para>
    ///   <para>rdfs:comment : The topic of the resource.</para>
    ///   <para>rdfs:label : Subject</para>
    ///   <a href="http://purl.org/dc/terms/subject">dcterms:subject</a>
    /// </summary>
    let subject = _prefixId.prefix "subject"
    /// <summary>
    ///   <para>rdfs:label : Table Of Contents</para>
    ///   <para>rdfs:comment : A list of subunits of the resource.</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/tableOfContents">dcterms:tableOfContents</a>
    /// </summary>
    let tableOfContents = _prefixId.prefix "tableOfContents"
    /// <summary>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : Temporal characteristics of the resource.</para>
    ///   <para>rdfs:label : Temporal Coverage</para>
    ///   <a href="http://purl.org/dc/terms/temporal">dcterms:temporal</a>
    /// </summary>
    let temporal = _prefixId.prefix "temporal"
    /// <summary>
    ///   <para>rdfs:label : Title</para>
    ///   <para>rdfs:comment : A name given to the resource.</para>
    ///   <para>dcterms:modified : 2010-10-11^^xsd:date</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/title">dcterms:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>rdfs:label : Type</para>
    ///   <para>dcterms:description : Recommended best practice is to use a controlled vocabulary such as the DCMI Type Vocabulary [DCMITYPE]. To describe the file format, physical medium, or dimensions of the resource, use the Format element.</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : The nature or genre of the resource.</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <a href="http://purl.org/dc/terms/type">dcterms:type</a>
    /// </summary>
    let type_ = _prefixId.prefix "type"
    /// <summary>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>rdfs:comment : Date (often a range) of validity of a resource.</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:label : Date Valid</para>
    ///   <a href="http://purl.org/dc/terms/valid">dcterms:valid</a>
    /// </summary>
    let valid = _prefixId.prefix "valid"

#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module locah =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://data.archiveshub.ac.uk/def/" "locah"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>skos:prefLabel : Archival Resource</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Archival Resource</para>
    ///   <para>rdfs:comment : Recorded information in any form or medium, created or received and maintained, by an organization or person(s) in the transaction of business or the conduct of affairs, and maintained for its long-term research value. An archival resource may be an individual item, such as a letter or photograph, or (more commonly) some aggregation of such items managed and described as a unit.</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/ArchivalResource">locah:ArchivalResource</a>
    /// </summary>
    let ArchivalResource = _prefixId.prefix "ArchivalResource"
    /// <summary>
    ///   <para>skos:prefLabel : Biographical History</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Biographical History</para>
    ///   <para>rdfs:comment : A narrative or chronology that places archival materials in context by providing information about their creator(s). A finding aid may contain several such narratives or chronologies pertaining to different archival materials and their creators.</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/BiographicalHistory">locah:BiographicalHistory</a>
    /// </summary>
    let BiographicalHistory = _prefixId.prefix "BiographicalHistory"
    /// <summary>
    ///   <para>skos:prefLabel : Creation</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Creation</para>
    ///   <para>rdfs:comment : An event that resulted in the creation or accumulation of an archival resource.</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/Creation">locah:Creation</a>
    /// </summary>
    let Creation = _prefixId.prefix "Creation"
    /// <summary>
    ///   <para>skos:prefLabel : EAD Document</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : EAD Document</para>
    ///   <para>rdfs:comment : A document conforming to the Encoded Archival Description standard.</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/EAD">locah:EAD</a>
    /// </summary>
    let EAD = _prefixId.prefix "EAD"
    /// <summary>
    ///   <para>skos:prefLabel : Extent</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Extent</para>
    ///   <para>rdfs:comment : The size of an archival resource.</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/Extent">locah:Extent</a>
    /// </summary>
    let Extent = _prefixId.prefix "Extent"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : A group of people affiliated by consanguinity, affinity, or co-residence.</para>
    ///   <para>skos:prefLabel : Family</para>
    ///   <para>rdfs:label : Family</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/Family">locah:Family</a>
    /// </summary>
    let Family = _prefixId.prefix "Family"
    /// <summary>
    ///   <para>skos:prefLabel : Finding Aid</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Finding Aid</para>
    ///   <para>rdfs:comment : A document describing an archival resource.</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/FindingAid">locah:FindingAid</a>
    /// </summary>
    let FindingAid = _prefixId.prefix "FindingAid"
    /// <summary>
    ///   <para>skos:prefLabel : Floruit</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Floruit</para>
    ///   <para>rdfs:comment : An event corresponding to the activity of an agent.</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/Floruit">locah:Floruit</a>
    /// </summary>
    let Floruit = _prefixId.prefix "Floruit"
    /// <summary>
    ///   <para>skos:prefLabel : Function</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Function</para>
    ///   <para>rdfs:comment : A sphere of activity or process.</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/Function">locah:Function</a>
    /// </summary>
    let Function = _prefixId.prefix "Function"
    /// <summary>
    ///   <para>skos:prefLabel : Genre or Form</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Genre or Form</para>
    ///   <para>rdfs:comment : A category of archival material, defined either by style or technique of intellectual content, order of information or object function, or physical characteristics.</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/GenreForm">locah:GenreForm</a>
    /// </summary>
    let GenreForm = _prefixId.prefix "GenreForm"
    /// <summary>
    ///   <para>skos:prefLabel : Level</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Level</para>
    ///   <para>rdfs:comment : An indicator of the part of an archival collection constituted by an archival resource, whether it is the whole collection or a sub-section of it.</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/Level">locah:Level</a>
    /// </summary>
    let Level = _prefixId.prefix "Level"
    /// <summary>
    ///   <para>skos:prefLabel : Repository</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Repository</para>
    ///   <para>rdfs:comment : An institution or agency responsible for providing access to archival materials.</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/Repository">locah:Repository</a>
    /// </summary>
    let Repository = _prefixId.prefix "Repository"
    /// <summary>
    ///   <para>skos:prefLabel : Access Provided By</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Access Provided By</para>
    ///   <para>rdfs:comment : An agent that provides access to the resource.</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/accessProvidedBy">locah:accessProvidedBy</a>
    /// </summary>
    let accessProvidedBy = _prefixId.prefix "accessProvidedBy"
    /// <summary>
    ///   <para>skos:prefLabel : Access Restrictions</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Access Restrictions</para>
    ///   <para>rdfs:comment : Access Restrictions</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/accessRestrictions">locah:accessRestrictions</a>
    /// </summary>
    let accessRestrictions = _prefixId.prefix "accessRestrictions"
    /// <summary>
    ///   <para>skos:prefLabel : Accruals</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Accruals</para>
    ///   <para>rdfs:comment : Accruals</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/accruals">locah:accruals</a>
    /// </summary>
    let accruals = _prefixId.prefix "accruals"
    /// <summary>
    ///   <para>skos:prefLabel : Acquisitions</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Acquisitions</para>
    ///   <para>rdfs:comment : Acquisitions</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/acquisitions">locah:acquisitions</a>
    /// </summary>
    let acquisitions = _prefixId.prefix "acquisitions"
    /// <summary>
    ///   <para>skos:prefLabel : Administers</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Administers</para>
    ///   <para>rdfs:comment : A resource which the agent manages.</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/administers">locah:administers</a>
    /// </summary>
    let administers = _prefixId.prefix "administers"
    /// <summary>
    ///   <para>skos:prefLabel : Alternate Forms Available</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Alternate Forms Available</para>
    ///   <para>rdfs:comment : Alternate Forms Available</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/alternateFormsAvailable">locah:alternateFormsAvailable</a>
    /// </summary>
    let alternateFormsAvailable = _prefixId.prefix "alternateFormsAvailable"
    /// <summary>
    ///   <para>skos:prefLabel : Appraisal</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Appraisal</para>
    ///   <para>rdfs:comment : Appraisal</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/appraisal">locah:appraisal</a>
    /// </summary>
    let appraisal = _prefixId.prefix "appraisal"
    /// <summary>
    ///   <para>skos:prefLabel : Archival Box</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Archival Box</para>
    ///   <para>rdfs:comment : A number of archival boxes</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/archbox">locah:archbox</a>
    /// </summary>
    let archbox = _prefixId.prefix "archbox"
    /// <summary>
    ///   <para>skos:prefLabel : Associated With</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Associated With</para>
    ///   <para>rdfs:comment : A concept adjudged by a cataloguer to have an association with an archival resource which they consider useful for the purposes of discovering that resource.</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/associatedWith">locah:associatedWith</a>
    /// </summary>
    let associatedWith = _prefixId.prefix "associatedWith"
    /// <summary>
    ///   <para>skos:prefLabel : Bibliography</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Bibliography</para>
    ///   <para>rdfs:comment : Bibliography</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/bibliography">locah:bibliography</a>
    /// </summary>
    let bibliography = _prefixId.prefix "bibliography"
    /// <summary>
    ///   <para>skos:prefLabel : Body</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Body</para>
    ///   <para>rdfs:comment : A literal representation of the content of the document.</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/body">locah:body</a>
    /// </summary>
    let body = _prefixId.prefix "body"
    /// <summary>
    ///   <para>skos:prefLabel : Country Code</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Country Code</para>
    ///   <para>rdfs:comment : The ISO 3166-1 code for the country of the repository.</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/countryCode">locah:countryCode</a>
    /// </summary>
    let countryCode = _prefixId.prefix "countryCode"
    /// <summary>
    ///   <para>skos:prefLabel : Cubic Metre</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Cubic Metre</para>
    ///   <para>rdfs:comment : A number of cubic metres</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/cubicmetre">locah:cubicmetre</a>
    /// </summary>
    let cubicmetre = _prefixId.prefix "cubicmetre"
    /// <summary>
    ///   <para>skos:prefLabel : Custodial History</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Custodial History</para>
    ///   <para>rdfs:comment : Custodial History</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/custodialHistory">locah:custodialHistory</a>
    /// </summary>
    let custodialHistory = _prefixId.prefix "custodialHistory"
    /// <summary>
    ///   <para>skos:prefLabel : Date of Birth</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Date of Birth</para>
    ///   <para>rdfs:comment : The date of birth of the person.</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/dateBirth">locah:dateBirth</a>
    /// </summary>
    let dateBirth = _prefixId.prefix "dateBirth"
    /// <summary>
    ///   <para>skos:prefLabel : Date created or accumulated</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Date created or accumulated</para>
    ///   <para>rdfs:comment : The date, represented as a typed literal, of a time interval during which the archival resource was created or accumulated.</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/dateCreatedAccumulated">locah:dateCreatedAccumulated</a>
    /// </summary>
    let dateCreatedAccumulated = _prefixId.prefix "dateCreatedAccumulated"
    /// <summary>
    ///   <para>skos:prefLabel : Date created or accumulated (end)</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Date created or accumulated (end)</para>
    ///   <para>rdfs:comment : The end date, represented as a typed literal, of a time interval during which the archival resource was created or accumulated.</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/dateCreatedAccumulatedEnd">locah:dateCreatedAccumulatedEnd</a>
    /// </summary>
    let dateCreatedAccumulatedEnd = _prefixId.prefix "dateCreatedAccumulatedEnd"
    /// <summary>
    ///   <para>skos:prefLabel : Date created or accumulated (start)</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Date created or accumulated (start)</para>
    ///   <para>rdfs:comment : The start date, represented as a typed literal, of a time interval during which the archival resource was created or accumulated.</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/dateCreatedAccumulatedStart">locah:dateCreatedAccumulatedStart</a>
    /// </summary>
    let dateCreatedAccumulatedStart = _prefixId.prefix "dateCreatedAccumulatedStart"
    /// <summary>
    ///   <para>skos:prefLabel : Date created or accumulated</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Date created or accumulated</para>
    ///   <para>rdfs:comment : The date, represented as a string, of a time interval during which the archival resource was created or accumulated.</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/dateCreatedAccumulatedString">locah:dateCreatedAccumulatedString</a>
    /// </summary>
    let dateCreatedAccumulatedString = _prefixId.prefix "dateCreatedAccumulatedString"
    /// <summary>
    ///   <para>skos:prefLabel : Date of Death</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Date of Death</para>
    ///   <para>rdfs:comment : The date of death of the person.</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/dateDeath">locah:dateDeath</a>
    /// </summary>
    let dateDeath = _prefixId.prefix "dateDeath"
    /// <summary>
    ///   <para>skos:prefLabel : Dates</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Dates</para>
    ///   <para>rdfs:comment : Dates</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/dates">locah:dates</a>
    /// </summary>
    let dates = _prefixId.prefix "dates"
    /// <summary>
    ///   <para>skos:prefLabel : Encoded As</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Encoded As</para>
    ///   <para>rdfs:comment : An EAD document that is an encoding of the archival finding aid.</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/encodedAs">locah:encodedAs</a>
    /// </summary>
    let encodedAs = _prefixId.prefix "encodedAs"
    /// <summary>
    ///   <para>skos:prefLabel : Encoding Of</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Encoding Of</para>
    ///   <para>rdfs:comment : An archival finding aid of which the EAD document is an encoding.</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/encodingOf">locah:encodingOf</a>
    /// </summary>
    let encodingOf = _prefixId.prefix "encodingOf"
    /// <summary>
    ///   <para>skos:prefLabel : Envelope</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Envelope</para>
    ///   <para>rdfs:comment : A number of envelopes</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/envelope">locah:envelope</a>
    /// </summary>
    let envelope = _prefixId.prefix "envelope"
    /// <summary>
    ///   <para>skos:prefLabel : Epithet</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Epithet</para>
    ///   <para>rdfs:comment : Epithet</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/epithet">locah:epithet</a>
    /// </summary>
    let epithet = _prefixId.prefix "epithet"
    /// <summary>
    ///   <para>skos:prefLabel : Extent</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Extent</para>
    ///   <para>rdfs:comment : The size of the archival resource.</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/extent">locah:extent</a>
    /// </summary>
    let extent = _prefixId.prefix "extent"
    /// <summary>
    ///   <para>skos:prefLabel : File</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : File</para>
    ///   <para>rdfs:comment : A number of files</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/file">locah:file</a>
    /// </summary>
    let file = _prefixId.prefix "file"
    /// <summary>
    ///   <para>skos:prefLabel : Folder</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Folder</para>
    ///   <para>rdfs:comment : A number of folders</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/folder">locah:folder</a>
    /// </summary>
    let folder = _prefixId.prefix "folder"
    /// <summary>
    ///   <para>skos:prefLabel : Forename</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Forename</para>
    ///   <para>rdfs:comment : The forename of a person who is the focus of the concept</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/forename">locah:forename</a>
    /// </summary>
    let forename = _prefixId.prefix "forename"
    /// <summary>
    ///   <para>skos:prefLabel : Has Biographical History</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Has Biographical History</para>
    ///   <para>rdfs:comment : A narrative or chronology that places archival materials in context by providing information about their creator(s).</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/hasBiographicalHistory">locah:hasBiographicalHistory</a>
    /// </summary>
    let hasBiographicalHistory = _prefixId.prefix "hasBiographicalHistory"
    /// <summary>
    ///   <para>skos:prefLabel : Is Administered By</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Is Administered By</para>
    ///   <para>rdfs:comment : An agent that manages the resource.</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/isAdministeredBy">locah:isAdministeredBy</a>
    /// </summary>
    let isAdministeredBy = _prefixId.prefix "isAdministeredBy"
    /// <summary>
    ///   <para>skos:prefLabel : Is Biographical History For</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Is Biographical History For</para>
    ///   <para>rdfs:comment : An archival resource that the narrative or chronology places in context by providing information about their creator(s).</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/isBiographicalHistoryFor">locah:isBiographicalHistoryFor</a>
    /// </summary>
    let isBiographicalHistoryFor = _prefixId.prefix "isBiographicalHistoryFor"
    /// <summary>
    ///   <para>skos:prefLabel : Is Maintenance Agency Of</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Is Maintenance Agency Of</para>
    ///   <para>rdfs:comment : An archival finding aid for which the repository is responsible for the maintenance.</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/isMaintenanceAgencyOf">locah:isMaintenanceAgencyOf</a>
    /// </summary>
    let isMaintenanceAgencyOf = _prefixId.prefix "isMaintenanceAgencyOf"
    /// <summary>
    ///   <para>rdfs:label : Is Origination Of</para>
    ///   <para>skos:prefLabel : Is Origination Of</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : An archival resource for which the agent is responsible for the creation or accumulation.</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/isOriginationOf">locah:isOriginationOf</a>
    /// </summary>
    let isOriginationOf = _prefixId.prefix "isOriginationOf"
    /// <summary>
    ///   <para>skos:prefLabel : Is Publisher Of</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Is Publisher Of</para>
    ///   <para>rdfs:comment : A resource which the agent makes available.</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/isPublisherOf">locah:isPublisherOf</a>
    /// </summary>
    let isPublisherOf = _prefixId.prefix "isPublisherOf"
    /// <summary>
    ///   <para>skos:prefLabel : Is Represented By</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Is Represented By</para>
    ///   <para>rdfs:comment : A resource which represents the archival resource, such as an image of a text page, a transcription of text, an audio or video clip, or an aggregation of such resources.rdfs:comment : An archival resourcce represented by the resource.</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/isRepresentedBy">locah:isRepresentedBy</a>
    /// </summary>
    let isRepresentedBy = _prefixId.prefix "isRepresentedBy"
    /// <summary>
    ///   <para>skos:prefLabel : Item</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Item</para>
    ///   <para>rdfs:comment : A number of items</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/item">locah:item</a>
    /// </summary>
    let item = _prefixId.prefix "item"
    /// <summary>
    ///   <para>skos:prefLabel : Level</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Level</para>
    ///   <para>rdfs:comment : An indicator of the part of an archival collection constituted by an archival resource.</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/level">locah:level</a>
    /// </summary>
    let level = _prefixId.prefix "level"
    /// <summary>
    ///   <para>skos:prefLabel : Location</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Location</para>
    ///   <para>rdfs:comment : Location</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/location">locah:location</a>
    /// </summary>
    let location = _prefixId.prefix "location"
    /// <summary>
    ///   <para>skos:prefLabel : Location of Originals</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Location of Originals</para>
    ///   <para>rdfs:comment : Location of Originals</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/locationOfOriginals">locah:locationOfOriginals</a>
    /// </summary>
    let locationOfOriginals = _prefixId.prefix "locationOfOriginals"
    /// <summary>
    ///   <para>skos:prefLabel : Maintenance Agency</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Maintenance Agency</para>
    ///   <para>rdfs:comment : A repository responsible for the maintenance of the archival finding aid.</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/maintenanceAgency">locah:maintenanceAgency</a>
    /// </summary>
    let maintenanceAgency = _prefixId.prefix "maintenanceAgency"
    /// <summary>
    ///   <para>skos:prefLabel : Maintenance Agency Code</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Maintenance Agency Code</para>
    ///   <para>rdfs:comment : The ISO 15511 code for the repository.</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/maintenanceAgencyCode">locah:maintenanceAgencyCode</a>
    /// </summary>
    let maintenanceAgencyCode = _prefixId.prefix "maintenanceAgencyCode"
    /// <summary>
    ///   <para>skos:prefLabel : Members</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Members</para>
    ///   <para>rdfs:comment : Members</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/members">locah:members</a>
    /// </summary>
    let members = _prefixId.prefix "members"
    /// <summary>
    ///   <para>skos:prefLabel : Metre</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Metre</para>
    ///   <para>rdfs:comment : A number of metres</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/metre">locah:metre</a>
    /// </summary>
    let metre = _prefixId.prefix "metre"
    /// <summary>
    ///   <para>skos:prefLabel : Name</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Name</para>
    ///   <para>rdfs:comment : Name</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/name">locah:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>skos:prefLabel : Note</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Note</para>
    ///   <para>rdfs:comment : Note</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/note">locah:note</a>
    /// </summary>
    let note = _prefixId.prefix "note"
    /// <summary>
    ///   <para>rdfs:comment : An agent responsible for the creation or accumulation of the archival resource.</para>
    ///   <para>skos:prefLabel : Origination</para>
    ///   <para>rdfs:label : Origination</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/origination">locah:origination</a>
    /// </summary>
    let origination = _prefixId.prefix "origination"
    /// <summary>
    ///   <para>skos:prefLabel : Other</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Other</para>
    ///   <para>rdfs:comment : Other</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/other">locah:other</a>
    /// </summary>
    let other = _prefixId.prefix "other"
    /// <summary>
    ///   <para>skos:prefLabel : Other Finding Aids</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Other Finding Aids</para>
    ///   <para>rdfs:comment : Other Finding Aids</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/otherFindingAids">locah:otherFindingAids</a>
    /// </summary>
    let otherFindingAids = _prefixId.prefix "otherFindingAids"
    /// <summary>
    ///   <para>skos:prefLabel : Page</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Page</para>
    ///   <para>rdfs:comment : A number of pages</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/page">locah:page</a>
    /// </summary>
    let page = _prefixId.prefix "page"
    /// <summary>
    ///   <para>skos:prefLabel : Paper</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Paper</para>
    ///   <para>rdfs:comment : A number of papers</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/paper">locah:paper</a>
    /// </summary>
    let paper = _prefixId.prefix "paper"
    /// <summary>
    ///   <para>skos:prefLabel : Physical and Technical Requirements</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Physical and Technical Requirements</para>
    ///   <para>rdfs:comment : Physical and Technical Requirements</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/physicalTechnicalRequirements">locah:physicalTechnicalRequirements</a>
    /// </summary>
    let physicalTechnicalRequirements = _prefixId.prefix "physicalTechnicalRequirements"
    /// <summary>
    ///   <para>skos:prefLabel : Processing</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Processing</para>
    ///   <para>rdfs:comment : Processing</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/processing">locah:processing</a>
    /// </summary>
    let processing = _prefixId.prefix "processing"
    /// <summary>
    ///   <para>skos:prefLabel : Provides Access To</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Provides Access To</para>
    ///   <para>rdfs:comment : A resource to which the agent provides access.</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/providesAccessTo">locah:providesAccessTo</a>
    /// </summary>
    let providesAccessTo = _prefixId.prefix "providesAccessTo"
    /// <summary>
    ///   <para>skos:prefLabel : Related Material</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Related Material</para>
    ///   <para>rdfs:comment : Related Material</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/relatedMaterial">locah:relatedMaterial</a>
    /// </summary>
    let relatedMaterial = _prefixId.prefix "relatedMaterial"
    /// <summary>
    ///   <para>skos:prefLabel : Scope and Content</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Scope and Content</para>
    ///   <para>rdfs:comment : Scope and Content</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/scopecontent">locah:scopecontent</a>
    /// </summary>
    let scopecontent = _prefixId.prefix "scopecontent"
    /// <summary>
    ///   <para>skos:prefLabel : Surname</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Surname</para>
    ///   <para>rdfs:comment : The surname of a person who is the focus of the concept</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/surname">locah:surname</a>
    /// </summary>
    let surname = _prefixId.prefix "surname"
    /// <summary>
    ///   <para>skos:prefLabel : Title</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Title</para>
    ///   <para>rdfs:comment : The title of a person who is the focus of the concept</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/title">locah:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>skos:prefLabel : Use Restrictions</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Use Restrictions</para>
    ///   <para>rdfs:comment : Use Restrictions</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/useRestrictions">locah:useRestrictions</a>
    /// </summary>
    let useRestrictions = _prefixId.prefix "useRestrictions"
    /// <summary>
    ///   <para>skos:prefLabel : Volume</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Volume</para>
    ///   <para>rdfs:comment : A number of volumes</para>
    ///   <a href="http://data.archiveshub.ac.uk/def/volume">locah:volume</a>
    /// </summary>
    let volume = _prefixId.prefix "volume"

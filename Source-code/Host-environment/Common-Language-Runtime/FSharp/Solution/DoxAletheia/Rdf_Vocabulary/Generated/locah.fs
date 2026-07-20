namespace http.data.archiveshub.ac.uk.def.slash

open DoxAletheia

module locah =
    let _namespace_name = "http://data.archiveshub.ac.uk/def/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Recorded information in any form or medium, created or received and maintained, by an organization or person(s) in the transaction of business or the conduct of affairs, and maintained for its long-term research value. An archival resource may be an individual item, such as a letter or photograph, or (more commonly) some aggregation of such items managed and described as a unit.
    /// <see href="http://data.archiveshub.ac.uk/def/ArchivalResource"></see></summary>
    let ArchivalResource = _prefix "ArchivalResource"
    /// <summary>
    /// A narrative or chronology that places archival materials in context by providing information about their creator(s). A finding aid may contain several such narratives or chronologies pertaining to different archival materials and their creators.
    /// <see href="http://data.archiveshub.ac.uk/def/BiographicalHistory"></see></summary>
    let BiographicalHistory = _prefix "BiographicalHistory"
    /// <summary>
    /// An event that resulted in the creation or accumulation of an archival resource.
    /// <see href="http://data.archiveshub.ac.uk/def/Creation"></see></summary>
    let Creation = _prefix "Creation"
    /// <summary>
    /// A document conforming to the Encoded Archival Description standard.
    /// <see href="http://data.archiveshub.ac.uk/def/EAD"></see></summary>
    let EAD = _prefix "EAD"
    /// <summary>
    /// The size of an archival resource.
    /// <see href="http://data.archiveshub.ac.uk/def/Extent"></see></summary>
    let Extent = _prefix "Extent"
    /// <summary>
    /// A group of people affiliated by consanguinity, affinity, or co-residence.
    /// <see href="http://data.archiveshub.ac.uk/def/Family"></see></summary>
    let Family = _prefix "Family"
    /// <summary>
    /// A document describing an archival resource.
    /// <see href="http://data.archiveshub.ac.uk/def/FindingAid"></see></summary>
    let FindingAid = _prefix "FindingAid"
    /// <summary>
    /// An event corresponding to the activity of an agent.
    /// <see href="http://data.archiveshub.ac.uk/def/Floruit"></see></summary>
    let Floruit = _prefix "Floruit"
    /// <summary>
    /// A sphere of activity or process.
    /// <see href="http://data.archiveshub.ac.uk/def/Function"></see></summary>
    let Function = _prefix "Function"
    /// <summary>
    /// A category of archival material, defined either by style or technique of intellectual content, order of information or object function, or physical characteristics.
    /// <see href="http://data.archiveshub.ac.uk/def/GenreForm"></see></summary>
    let GenreForm = _prefix "GenreForm"
    /// <summary>
    /// An indicator of the part of an archival collection constituted by an archival resource, whether it is the whole collection or a sub-section of it.
    /// <see href="http://data.archiveshub.ac.uk/def/Level"></see></summary>
    let Level = _prefix "Level"
    /// <summary>
    /// An institution or agency responsible for providing access to archival materials.
    /// <see href="http://data.archiveshub.ac.uk/def/Repository"></see></summary>
    let Repository = _prefix "Repository"
    /// <summary>
    /// An agent that provides access to the resource.
    /// <see href="http://data.archiveshub.ac.uk/def/accessProvidedBy"></see></summary>
    let accessProvidedBy = _prefix "accessProvidedBy"
    /// <summary>
    /// A resource to which the agent provides access.
    /// <see href="http://data.archiveshub.ac.uk/def/providesAccessTo"></see></summary>
    let providesAccessTo = _prefix "providesAccessTo"
    /// <summary>
    /// Access Restrictions
    /// <see href="http://data.archiveshub.ac.uk/def/accessRestrictions"></see></summary>
    let accessRestrictions = _prefix "accessRestrictions"
    /// <summary>
    /// Accruals
    /// <see href="http://data.archiveshub.ac.uk/def/accruals"></see></summary>
    let accruals = _prefix "accruals"
    /// <summary>
    /// Acquisitions
    /// <see href="http://data.archiveshub.ac.uk/def/acquisitions"></see></summary>
    let acquisitions = _prefix "acquisitions"
    /// <summary>
    /// A resource which the agent manages.
    /// <see href="http://data.archiveshub.ac.uk/def/administers"></see></summary>
    let administers = _prefix "administers"
    /// <summary>
    /// An agent that manages the resource.
    /// <see href="http://data.archiveshub.ac.uk/def/isAdministeredBy"></see></summary>
    let isAdministeredBy = _prefix "isAdministeredBy"
    /// <summary>
    /// Alternate Forms Available
    /// <see href="http://data.archiveshub.ac.uk/def/alternateFormsAvailable"></see></summary>
    let alternateFormsAvailable = _prefix "alternateFormsAvailable"
    /// <summary>
    /// Appraisal
    /// <see href="http://data.archiveshub.ac.uk/def/appraisal"></see></summary>
    let appraisal = _prefix "appraisal"
    /// <summary>
    /// A number of archival boxes
    /// <see href="http://data.archiveshub.ac.uk/def/archbox"></see></summary>
    let archbox = _prefix "archbox"
    /// <summary>
    /// A concept adjudged by a cataloguer to have an association with an archival resource which they consider useful for the purposes of discovering that resource.
    /// <see href="http://data.archiveshub.ac.uk/def/associatedWith"></see></summary>
    let associatedWith = _prefix "associatedWith"
    /// <summary>
    /// Bibliography
    /// <see href="http://data.archiveshub.ac.uk/def/bibliography"></see></summary>
    let bibliography = _prefix "bibliography"
    /// <summary>
    /// A literal representation of the content of the document.
    /// <see href="http://data.archiveshub.ac.uk/def/body"></see></summary>
    let body = _prefix "body"
    /// <summary>
    /// The ISO 3166-1 code for the country of the repository.
    /// <see href="http://data.archiveshub.ac.uk/def/countryCode"></see></summary>
    let countryCode = _prefix "countryCode"
    /// <summary>
    /// A number of cubic metres
    /// <see href="http://data.archiveshub.ac.uk/def/cubicmetre"></see></summary>
    let cubicmetre = _prefix "cubicmetre"
    /// <summary>
    /// Custodial History
    /// <see href="http://data.archiveshub.ac.uk/def/custodialHistory"></see></summary>
    let custodialHistory = _prefix "custodialHistory"
    /// <summary>
    /// The date of birth of the person.
    /// <see href="http://data.archiveshub.ac.uk/def/dateBirth"></see></summary>
    let dateBirth = _prefix "dateBirth"
    /// <summary>
    /// The date, represented as a typed literal, of a time interval during which the archival resource was created or accumulated.
    /// <see href="http://data.archiveshub.ac.uk/def/dateCreatedAccumulated"></see></summary>
    let dateCreatedAccumulated = _prefix "dateCreatedAccumulated"
    /// <summary>
    /// The end date, represented as a typed literal, of a time interval during which the archival resource was created or accumulated.
    /// <see href="http://data.archiveshub.ac.uk/def/dateCreatedAccumulatedEnd"></see></summary>
    let dateCreatedAccumulatedEnd = _prefix "dateCreatedAccumulatedEnd"
    /// <summary>
    /// The start date, represented as a typed literal, of a time interval during which the archival resource was created or accumulated.
    /// <see href="http://data.archiveshub.ac.uk/def/dateCreatedAccumulatedStart"></see></summary>
    let dateCreatedAccumulatedStart = _prefix "dateCreatedAccumulatedStart"
    /// <summary>
    /// The date, represented as a string, of a time interval during which the archival resource was created or accumulated.
    /// <see href="http://data.archiveshub.ac.uk/def/dateCreatedAccumulatedString"></see></summary>
    let dateCreatedAccumulatedString = _prefix "dateCreatedAccumulatedString"
    /// <summary>
    /// The date of death of the person.
    /// <see href="http://data.archiveshub.ac.uk/def/dateDeath"></see></summary>
    let dateDeath = _prefix "dateDeath"
    /// <summary>
    /// Dates
    /// <see href="http://data.archiveshub.ac.uk/def/dates"></see></summary>
    let dates = _prefix "dates"
    /// <summary>
    /// An EAD document that is an encoding of the archival finding aid.
    /// <see href="http://data.archiveshub.ac.uk/def/encodedAs"></see></summary>
    let encodedAs = _prefix "encodedAs"
    /// <summary>
    /// An archival finding aid of which the EAD document is an encoding.
    /// <see href="http://data.archiveshub.ac.uk/def/encodingOf"></see></summary>
    let encodingOf = _prefix "encodingOf"
    /// <summary>
    /// A number of envelopes
    /// <see href="http://data.archiveshub.ac.uk/def/envelope"></see></summary>
    let envelope = _prefix "envelope"
    /// <summary>
    /// Epithet
    /// <see href="http://data.archiveshub.ac.uk/def/epithet"></see></summary>
    let epithet = _prefix "epithet"
    /// <summary>
    /// The size of the archival resource.
    /// <see href="http://data.archiveshub.ac.uk/def/extent"></see></summary>
    let extent = _prefix "extent"
    /// <summary>
    /// A number of files
    /// <see href="http://data.archiveshub.ac.uk/def/file"></see></summary>
    let file = _prefix "file"
    /// <summary>
    /// A number of folders
    /// <see href="http://data.archiveshub.ac.uk/def/folder"></see></summary>
    let folder = _prefix "folder"
    /// <summary>
    /// The forename of a person who is the focus of the concept
    /// <see href="http://data.archiveshub.ac.uk/def/forename"></see></summary>
    let forename = _prefix "forename"
    /// <summary>
    /// A narrative or chronology that places archival materials in context by providing information about their creator(s).
    /// <see href="http://data.archiveshub.ac.uk/def/hasBiographicalHistory"></see></summary>
    let hasBiographicalHistory = _prefix "hasBiographicalHistory"
    /// <summary>
    /// An archival resource that the narrative or chronology places in context by providing information about their creator(s).
    /// <see href="http://data.archiveshub.ac.uk/def/isBiographicalHistoryFor"></see></summary>
    let isBiographicalHistoryFor = _prefix "isBiographicalHistoryFor"
    /// <summary>
    /// An archival finding aid for which the repository is responsible for the maintenance.
    /// <see href="http://data.archiveshub.ac.uk/def/isMaintenanceAgencyOf"></see></summary>
    let isMaintenanceAgencyOf = _prefix "isMaintenanceAgencyOf"
    /// <summary>
    /// A repository responsible for the maintenance of the archival finding aid.
    /// <see href="http://data.archiveshub.ac.uk/def/maintenanceAgency"></see></summary>
    let maintenanceAgency = _prefix "maintenanceAgency"
    /// <summary>
    /// An archival resource for which the agent is responsible for the creation or accumulation.
    /// <see href="http://data.archiveshub.ac.uk/def/isOriginationOf"></see></summary>
    let isOriginationOf = _prefix "isOriginationOf"
    /// <summary>
    /// An agent responsible for the creation or accumulation of the archival resource.
    /// <see href="http://data.archiveshub.ac.uk/def/origination"></see></summary>
    let origination = _prefix "origination"
    /// <summary>
    /// A resource which the agent makes available.
    /// <see href="http://data.archiveshub.ac.uk/def/isPublisherOf"></see></summary>
    let isPublisherOf = _prefix "isPublisherOf"
    /// <summary>
    /// A resource which represents the archival resource, such as an image of a text page, a transcription of text, an audio or video clip, or an aggregation of such resources.
    /// An archival resourcce represented by the resource.
    /// <see href="http://data.archiveshub.ac.uk/def/isRepresentedBy"></see></summary>
    let isRepresentedBy = _prefix "isRepresentedBy"
    /// <summary>
    /// A number of items
    /// <see href="http://data.archiveshub.ac.uk/def/item"></see></summary>
    let item = _prefix "item"
    /// <summary>
    /// An indicator of the part of an archival collection constituted by an archival resource.
    /// <see href="http://data.archiveshub.ac.uk/def/level"></see></summary>
    let level = _prefix "level"
    /// <summary>
    /// Location
    /// <see href="http://data.archiveshub.ac.uk/def/location"></see></summary>
    let location = _prefix "location"
    /// <summary>
    /// Location of Originals
    /// <see href="http://data.archiveshub.ac.uk/def/locationOfOriginals"></see></summary>
    let locationOfOriginals = _prefix "locationOfOriginals"
    /// <summary>
    /// The ISO 15511 code for the repository.
    /// <see href="http://data.archiveshub.ac.uk/def/maintenanceAgencyCode"></see></summary>
    let maintenanceAgencyCode = _prefix "maintenanceAgencyCode"
    /// <summary>
    /// Members
    /// <see href="http://data.archiveshub.ac.uk/def/members"></see></summary>
    let members = _prefix "members"
    /// <summary>
    /// A number of metres
    /// <see href="http://data.archiveshub.ac.uk/def/metre"></see></summary>
    let metre = _prefix "metre"
    /// <summary>
    /// Name
    /// <see href="http://data.archiveshub.ac.uk/def/name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// Note
    /// <see href="http://data.archiveshub.ac.uk/def/note"></see></summary>
    let note = _prefix "note"
    /// <summary>
    /// Other
    /// <see href="http://data.archiveshub.ac.uk/def/other"></see></summary>
    let other = _prefix "other"
    /// <summary>
    /// Other Finding Aids
    /// <see href="http://data.archiveshub.ac.uk/def/otherFindingAids"></see></summary>
    let otherFindingAids = _prefix "otherFindingAids"
    /// <summary>
    /// A number of pages
    /// <see href="http://data.archiveshub.ac.uk/def/page"></see></summary>
    let page = _prefix "page"
    /// <summary>
    /// A number of papers
    /// <see href="http://data.archiveshub.ac.uk/def/paper"></see></summary>
    let paper = _prefix "paper"
    /// <summary>
    /// Physical and Technical Requirements
    /// <see href="http://data.archiveshub.ac.uk/def/physicalTechnicalRequirements"></see></summary>
    let physicalTechnicalRequirements = _prefix "physicalTechnicalRequirements"
    /// <summary>
    /// Processing
    /// <see href="http://data.archiveshub.ac.uk/def/processing"></see></summary>
    let processing = _prefix "processing"
    /// <summary>
    /// Related Material
    /// <see href="http://data.archiveshub.ac.uk/def/relatedMaterial"></see></summary>
    let relatedMaterial = _prefix "relatedMaterial"
    /// <summary>
    /// Scope and Content
    /// <see href="http://data.archiveshub.ac.uk/def/scopecontent"></see></summary>
    let scopecontent = _prefix "scopecontent"
    /// <summary>
    /// The surname of a person who is the focus of the concept
    /// <see href="http://data.archiveshub.ac.uk/def/surname"></see></summary>
    let surname = _prefix "surname"
    /// <summary>
    /// The title of a person who is the focus of the concept
    /// <see href="http://data.archiveshub.ac.uk/def/title"></see></summary>
    let title = _prefix "title"
    /// <summary>
    /// Use Restrictions
    /// <see href="http://data.archiveshub.ac.uk/def/useRestrictions"></see></summary>
    let useRestrictions = _prefix "useRestrictions"
    /// <summary>
    /// A number of volumes
    /// <see href="http://data.archiveshub.ac.uk/def/volume"></see></summary>
    let volume = _prefix "volume"

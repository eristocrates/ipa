namespace http.data.archiveshub.ac.uk.def.slash

open DoxAletheia.Rdf_Vocabulary

module locah =
    let _namespace_name = "http://data.archiveshub.ac.uk/def/"

    /// <summary>
    /// Recorded information in any form or medium, created or received and maintained, by an organization or person(s) in the transaction of business or the conduct of affairs, and maintained for its long-term research value. An archival resource may be an individual item, such as a letter or photograph, or (more commonly) some aggregation of such items managed and described as a unit.
    /// <see href="http://data.archiveshub.ac.uk/def/ArchivalResource"></see></summary>
    let ArchivalResource =
        Namespaced_IRI.parse _namespace_name "ArchivalResource" |> NamespacedName

    /// <summary>
    /// A narrative or chronology that places archival materials in context by providing information about their creator(s). A finding aid may contain several such narratives or chronologies pertaining to different archival materials and their creators.
    /// <see href="http://data.archiveshub.ac.uk/def/BiographicalHistory"></see></summary>
    let BiographicalHistory =
        Namespaced_IRI.parse _namespace_name "BiographicalHistory" |> NamespacedName

    /// <summary>
    /// An event that resulted in the creation or accumulation of an archival resource.
    /// <see href="http://data.archiveshub.ac.uk/def/Creation"></see></summary>
    let Creation = Namespaced_IRI.parse _namespace_name "Creation" |> NamespacedName
    /// <summary>
    /// A document conforming to the Encoded Archival Description standard.
    /// <see href="http://data.archiveshub.ac.uk/def/EAD"></see></summary>
    let EAD = Namespaced_IRI.parse _namespace_name "EAD" |> NamespacedName
    /// <summary>
    /// The size of an archival resource.
    /// <see href="http://data.archiveshub.ac.uk/def/Extent"></see></summary>
    let Extent = Namespaced_IRI.parse _namespace_name "Extent" |> NamespacedName
    /// <summary>
    /// A group of people affiliated by consanguinity, affinity, or co-residence.
    /// <see href="http://data.archiveshub.ac.uk/def/Family"></see></summary>
    let Family = Namespaced_IRI.parse _namespace_name "Family" |> NamespacedName
    /// <summary>
    /// A document describing an archival resource.
    /// <see href="http://data.archiveshub.ac.uk/def/FindingAid"></see></summary>
    let FindingAid = Namespaced_IRI.parse _namespace_name "FindingAid" |> NamespacedName
    /// <summary>
    /// An event corresponding to the activity of an agent.
    /// <see href="http://data.archiveshub.ac.uk/def/Floruit"></see></summary>
    let Floruit = Namespaced_IRI.parse _namespace_name "Floruit" |> NamespacedName
    /// <summary>
    /// A sphere of activity or process.
    /// <see href="http://data.archiveshub.ac.uk/def/Function"></see></summary>
    let Function = Namespaced_IRI.parse _namespace_name "Function" |> NamespacedName
    /// <summary>
    /// A category of archival material, defined either by style or technique of intellectual content, order of information or object function, or physical characteristics.
    /// <see href="http://data.archiveshub.ac.uk/def/GenreForm"></see></summary>
    let GenreForm = Namespaced_IRI.parse _namespace_name "GenreForm" |> NamespacedName
    /// <summary>
    /// An indicator of the part of an archival collection constituted by an archival resource, whether it is the whole collection or a sub-section of it.
    /// <see href="http://data.archiveshub.ac.uk/def/Level"></see></summary>
    let Level = Namespaced_IRI.parse _namespace_name "Level" |> NamespacedName
    /// <summary>
    /// An institution or agency responsible for providing access to archival materials.
    /// <see href="http://data.archiveshub.ac.uk/def/Repository"></see></summary>
    let Repository = Namespaced_IRI.parse _namespace_name "Repository" |> NamespacedName

    /// <summary>
    /// An agent that provides access to the resource.
    /// <see href="http://data.archiveshub.ac.uk/def/accessProvidedBy"></see></summary>
    let accessProvidedBy =
        Namespaced_IRI.parse _namespace_name "accessProvidedBy" |> NamespacedName

    /// <summary>
    /// A resource to which the agent provides access.
    /// <see href="http://data.archiveshub.ac.uk/def/providesAccessTo"></see></summary>
    let providesAccessTo =
        Namespaced_IRI.parse _namespace_name "providesAccessTo" |> NamespacedName

    /// <summary>
    /// Access Restrictions
    /// <see href="http://data.archiveshub.ac.uk/def/accessRestrictions"></see></summary>
    let accessRestrictions =
        Namespaced_IRI.parse _namespace_name "accessRestrictions" |> NamespacedName

    /// <summary>
    /// Accruals
    /// <see href="http://data.archiveshub.ac.uk/def/accruals"></see></summary>
    let accruals = Namespaced_IRI.parse _namespace_name "accruals" |> NamespacedName

    /// <summary>
    /// Acquisitions
    /// <see href="http://data.archiveshub.ac.uk/def/acquisitions"></see></summary>
    let acquisitions =
        Namespaced_IRI.parse _namespace_name "acquisitions" |> NamespacedName

    /// <summary>
    /// A resource which the agent manages.
    /// <see href="http://data.archiveshub.ac.uk/def/administers"></see></summary>
    let administers =
        Namespaced_IRI.parse _namespace_name "administers" |> NamespacedName

    /// <summary>
    /// An agent that manages the resource.
    /// <see href="http://data.archiveshub.ac.uk/def/isAdministeredBy"></see></summary>
    let isAdministeredBy =
        Namespaced_IRI.parse _namespace_name "isAdministeredBy" |> NamespacedName

    /// <summary>
    /// Alternate Forms Available
    /// <see href="http://data.archiveshub.ac.uk/def/alternateFormsAvailable"></see></summary>
    let alternateFormsAvailable =
        Namespaced_IRI.parse _namespace_name "alternateFormsAvailable" |> NamespacedName

    /// <summary>
    /// Appraisal
    /// <see href="http://data.archiveshub.ac.uk/def/appraisal"></see></summary>
    let appraisal = Namespaced_IRI.parse _namespace_name "appraisal" |> NamespacedName
    /// <summary>
    /// A number of archival boxes
    /// <see href="http://data.archiveshub.ac.uk/def/archbox"></see></summary>
    let archbox = Namespaced_IRI.parse _namespace_name "archbox" |> NamespacedName

    /// <summary>
    /// A concept adjudged by a cataloguer to have an association with an archival resource which they consider useful for the purposes of discovering that resource.
    /// <see href="http://data.archiveshub.ac.uk/def/associatedWith"></see></summary>
    let associatedWith =
        Namespaced_IRI.parse _namespace_name "associatedWith" |> NamespacedName

    /// <summary>
    /// Bibliography
    /// <see href="http://data.archiveshub.ac.uk/def/bibliography"></see></summary>
    let bibliography =
        Namespaced_IRI.parse _namespace_name "bibliography" |> NamespacedName

    /// <summary>
    /// A literal representation of the content of the document.
    /// <see href="http://data.archiveshub.ac.uk/def/body"></see></summary>
    let body = Namespaced_IRI.parse _namespace_name "body" |> NamespacedName

    /// <summary>
    /// The ISO 3166-1 code for the country of the repository.
    /// <see href="http://data.archiveshub.ac.uk/def/countryCode"></see></summary>
    let countryCode =
        Namespaced_IRI.parse _namespace_name "countryCode" |> NamespacedName

    /// <summary>
    /// A number of cubic metres
    /// <see href="http://data.archiveshub.ac.uk/def/cubicmetre"></see></summary>
    let cubicmetre = Namespaced_IRI.parse _namespace_name "cubicmetre" |> NamespacedName

    /// <summary>
    /// Custodial History
    /// <see href="http://data.archiveshub.ac.uk/def/custodialHistory"></see></summary>
    let custodialHistory =
        Namespaced_IRI.parse _namespace_name "custodialHistory" |> NamespacedName

    /// <summary>
    /// The date of birth of the person.
    /// <see href="http://data.archiveshub.ac.uk/def/dateBirth"></see></summary>
    let dateBirth = Namespaced_IRI.parse _namespace_name "dateBirth" |> NamespacedName

    /// <summary>
    /// The date, represented as a typed literal, of a time interval during which the archival resource was created or accumulated.
    /// <see href="http://data.archiveshub.ac.uk/def/dateCreatedAccumulated"></see></summary>
    let dateCreatedAccumulated =
        Namespaced_IRI.parse _namespace_name "dateCreatedAccumulated" |> NamespacedName

    /// <summary>
    /// The end date, represented as a typed literal, of a time interval during which the archival resource was created or accumulated.
    /// <see href="http://data.archiveshub.ac.uk/def/dateCreatedAccumulatedEnd"></see></summary>
    let dateCreatedAccumulatedEnd =
        Namespaced_IRI.parse _namespace_name "dateCreatedAccumulatedEnd" |> NamespacedName

    /// <summary>
    /// The start date, represented as a typed literal, of a time interval during which the archival resource was created or accumulated.
    /// <see href="http://data.archiveshub.ac.uk/def/dateCreatedAccumulatedStart"></see></summary>
    let dateCreatedAccumulatedStart =
        Namespaced_IRI.parse _namespace_name "dateCreatedAccumulatedStart" |> NamespacedName

    /// <summary>
    /// The date, represented as a string, of a time interval during which the archival resource was created or accumulated.
    /// <see href="http://data.archiveshub.ac.uk/def/dateCreatedAccumulatedString"></see></summary>
    let dateCreatedAccumulatedString =
        Namespaced_IRI.parse _namespace_name "dateCreatedAccumulatedString" |> NamespacedName

    /// <summary>
    /// The date of death of the person.
    /// <see href="http://data.archiveshub.ac.uk/def/dateDeath"></see></summary>
    let dateDeath = Namespaced_IRI.parse _namespace_name "dateDeath" |> NamespacedName
    /// <summary>
    /// Dates
    /// <see href="http://data.archiveshub.ac.uk/def/dates"></see></summary>
    let dates = Namespaced_IRI.parse _namespace_name "dates" |> NamespacedName
    /// <summary>
    /// An EAD document that is an encoding of the archival finding aid.
    /// <see href="http://data.archiveshub.ac.uk/def/encodedAs"></see></summary>
    let encodedAs = Namespaced_IRI.parse _namespace_name "encodedAs" |> NamespacedName
    /// <summary>
    /// An archival finding aid of which the EAD document is an encoding.
    /// <see href="http://data.archiveshub.ac.uk/def/encodingOf"></see></summary>
    let encodingOf = Namespaced_IRI.parse _namespace_name "encodingOf" |> NamespacedName
    /// <summary>
    /// A number of envelopes
    /// <see href="http://data.archiveshub.ac.uk/def/envelope"></see></summary>
    let envelope = Namespaced_IRI.parse _namespace_name "envelope" |> NamespacedName
    /// <summary>
    /// Epithet
    /// <see href="http://data.archiveshub.ac.uk/def/epithet"></see></summary>
    let epithet = Namespaced_IRI.parse _namespace_name "epithet" |> NamespacedName
    /// <summary>
    /// The size of the archival resource.
    /// <see href="http://data.archiveshub.ac.uk/def/extent"></see></summary>
    let extent = Namespaced_IRI.parse _namespace_name "extent" |> NamespacedName
    /// <summary>
    /// A number of files
    /// <see href="http://data.archiveshub.ac.uk/def/file"></see></summary>
    let file = Namespaced_IRI.parse _namespace_name "file" |> NamespacedName
    /// <summary>
    /// A number of folders
    /// <see href="http://data.archiveshub.ac.uk/def/folder"></see></summary>
    let folder = Namespaced_IRI.parse _namespace_name "folder" |> NamespacedName
    /// <summary>
    /// The forename of a person who is the focus of the concept
    /// <see href="http://data.archiveshub.ac.uk/def/forename"></see></summary>
    let forename = Namespaced_IRI.parse _namespace_name "forename" |> NamespacedName

    /// <summary>
    /// A narrative or chronology that places archival materials in context by providing information about their creator(s).
    /// <see href="http://data.archiveshub.ac.uk/def/hasBiographicalHistory"></see></summary>
    let hasBiographicalHistory =
        Namespaced_IRI.parse _namespace_name "hasBiographicalHistory" |> NamespacedName

    /// <summary>
    /// An archival resource that the narrative or chronology places in context by providing information about their creator(s).
    /// <see href="http://data.archiveshub.ac.uk/def/isBiographicalHistoryFor"></see></summary>
    let isBiographicalHistoryFor =
        Namespaced_IRI.parse _namespace_name "isBiographicalHistoryFor" |> NamespacedName

    /// <summary>
    /// An archival finding aid for which the repository is responsible for the maintenance.
    /// <see href="http://data.archiveshub.ac.uk/def/isMaintenanceAgencyOf"></see></summary>
    let isMaintenanceAgencyOf =
        Namespaced_IRI.parse _namespace_name "isMaintenanceAgencyOf" |> NamespacedName

    /// <summary>
    /// A repository responsible for the maintenance of the archival finding aid.
    /// <see href="http://data.archiveshub.ac.uk/def/maintenanceAgency"></see></summary>
    let maintenanceAgency =
        Namespaced_IRI.parse _namespace_name "maintenanceAgency" |> NamespacedName

    /// <summary>
    /// An archival resource for which the agent is responsible for the creation or accumulation.
    /// <see href="http://data.archiveshub.ac.uk/def/isOriginationOf"></see></summary>
    let isOriginationOf =
        Namespaced_IRI.parse _namespace_name "isOriginationOf" |> NamespacedName

    /// <summary>
    /// An agent responsible for the creation or accumulation of the archival resource.
    /// <see href="http://data.archiveshub.ac.uk/def/origination"></see></summary>
    let origination =
        Namespaced_IRI.parse _namespace_name "origination" |> NamespacedName

    /// <summary>
    /// A resource which the agent makes available.
    /// <see href="http://data.archiveshub.ac.uk/def/isPublisherOf"></see></summary>
    let isPublisherOf =
        Namespaced_IRI.parse _namespace_name "isPublisherOf" |> NamespacedName

    /// <summary>
    /// A resource which represents the archival resource, such as an image of a text page, a transcription of text, an audio or video clip, or an aggregation of such resources.
    /// An archival resourcce represented by the resource.
    /// <see href="http://data.archiveshub.ac.uk/def/isRepresentedBy"></see></summary>
    let isRepresentedBy =
        Namespaced_IRI.parse _namespace_name "isRepresentedBy" |> NamespacedName

    /// <summary>
    /// A number of items
    /// <see href="http://data.archiveshub.ac.uk/def/item"></see></summary>
    let item = Namespaced_IRI.parse _namespace_name "item" |> NamespacedName
    /// <summary>
    /// An indicator of the part of an archival collection constituted by an archival resource.
    /// <see href="http://data.archiveshub.ac.uk/def/level"></see></summary>
    let level = Namespaced_IRI.parse _namespace_name "level" |> NamespacedName
    /// <summary>
    /// Location
    /// <see href="http://data.archiveshub.ac.uk/def/location"></see></summary>
    let location = Namespaced_IRI.parse _namespace_name "location" |> NamespacedName

    /// <summary>
    /// Location of Originals
    /// <see href="http://data.archiveshub.ac.uk/def/locationOfOriginals"></see></summary>
    let locationOfOriginals =
        Namespaced_IRI.parse _namespace_name "locationOfOriginals" |> NamespacedName

    /// <summary>
    /// The ISO 15511 code for the repository.
    /// <see href="http://data.archiveshub.ac.uk/def/maintenanceAgencyCode"></see></summary>
    let maintenanceAgencyCode =
        Namespaced_IRI.parse _namespace_name "maintenanceAgencyCode" |> NamespacedName

    /// <summary>
    /// Members
    /// <see href="http://data.archiveshub.ac.uk/def/members"></see></summary>
    let members = Namespaced_IRI.parse _namespace_name "members" |> NamespacedName
    /// <summary>
    /// A number of metres
    /// <see href="http://data.archiveshub.ac.uk/def/metre"></see></summary>
    let metre = Namespaced_IRI.parse _namespace_name "metre" |> NamespacedName
    /// <summary>
    /// Name
    /// <see href="http://data.archiveshub.ac.uk/def/name"></see></summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName
    /// <summary>
    /// Note
    /// <see href="http://data.archiveshub.ac.uk/def/note"></see></summary>
    let note = Namespaced_IRI.parse _namespace_name "note" |> NamespacedName
    /// <summary>
    /// Other
    /// <see href="http://data.archiveshub.ac.uk/def/other"></see></summary>
    let other = Namespaced_IRI.parse _namespace_name "other" |> NamespacedName

    /// <summary>
    /// Other Finding Aids
    /// <see href="http://data.archiveshub.ac.uk/def/otherFindingAids"></see></summary>
    let otherFindingAids =
        Namespaced_IRI.parse _namespace_name "otherFindingAids" |> NamespacedName

    /// <summary>
    /// A number of pages
    /// <see href="http://data.archiveshub.ac.uk/def/page"></see></summary>
    let page = Namespaced_IRI.parse _namespace_name "page" |> NamespacedName
    /// <summary>
    /// A number of papers
    /// <see href="http://data.archiveshub.ac.uk/def/paper"></see></summary>
    let paper = Namespaced_IRI.parse _namespace_name "paper" |> NamespacedName

    /// <summary>
    /// Physical and Technical Requirements
    /// <see href="http://data.archiveshub.ac.uk/def/physicalTechnicalRequirements"></see></summary>
    let physicalTechnicalRequirements =
        Namespaced_IRI.parse _namespace_name "physicalTechnicalRequirements" |> NamespacedName

    /// <summary>
    /// Processing
    /// <see href="http://data.archiveshub.ac.uk/def/processing"></see></summary>
    let processing = Namespaced_IRI.parse _namespace_name "processing" |> NamespacedName

    /// <summary>
    /// Related Material
    /// <see href="http://data.archiveshub.ac.uk/def/relatedMaterial"></see></summary>
    let relatedMaterial =
        Namespaced_IRI.parse _namespace_name "relatedMaterial" |> NamespacedName

    /// <summary>
    /// Scope and Content
    /// <see href="http://data.archiveshub.ac.uk/def/scopecontent"></see></summary>
    let scopecontent =
        Namespaced_IRI.parse _namespace_name "scopecontent" |> NamespacedName

    /// <summary>
    /// The surname of a person who is the focus of the concept
    /// <see href="http://data.archiveshub.ac.uk/def/surname"></see></summary>
    let surname = Namespaced_IRI.parse _namespace_name "surname" |> NamespacedName
    /// <summary>
    /// The title of a person who is the focus of the concept
    /// <see href="http://data.archiveshub.ac.uk/def/title"></see></summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName

    /// <summary>
    /// Use Restrictions
    /// <see href="http://data.archiveshub.ac.uk/def/useRestrictions"></see></summary>
    let useRestrictions =
        Namespaced_IRI.parse _namespace_name "useRestrictions" |> NamespacedName

    /// <summary>
    /// A number of volumes
    /// <see href="http://data.archiveshub.ac.uk/def/volume"></see></summary>
    let volume = Namespaced_IRI.parse _namespace_name "volume" |> NamespacedName

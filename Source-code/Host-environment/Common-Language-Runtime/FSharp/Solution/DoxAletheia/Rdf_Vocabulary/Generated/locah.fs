namespace http.data.archiveshub.ac.uk.def.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module locah =
    let _namespace_iri = Namespace_Iri locah |> NamespaceIRI

    /// <summary>
    ///   <para>locah:BiographicalHistory</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A narrative or chronology that places archival materials in context by providing information about their creator(s). A finding aid may contain several such narratives or chronologies pertaining to different archival materials and their creators.</para>
    /// labels<para>Biographical History</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/BiographicalHistory">http://data.archiveshub.ac.uk/def/BiographicalHistory</seealso>
    let BiographicalHistory =
        Prefixed_Name(locah, "BiographicalHistory") |> PrefixedName

    /// <summary>
    ///   <para>locah:Extent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The size of an archival resource.</para>
    /// labels<para>Extent</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/Extent">http://data.archiveshub.ac.uk/def/Extent</seealso>
    let Extent = Prefixed_Name(locah, "Extent") |> PrefixedName
    /// <summary>
    ///   <para>locah:extent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The size of the archival resource.</para>
    /// labels<para>Extent</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/extent">http://data.archiveshub.ac.uk/def/extent</seealso>
    let extent = Prefixed_Name(locah, "extent") |> PrefixedName
    /// <summary>
    ///   <para>locah:folder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A number of folders</para>
    /// labels<para>Folder</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/folder">http://data.archiveshub.ac.uk/def/folder</seealso>
    let folder = Prefixed_Name(locah, "folder") |> PrefixedName
    /// <summary>
    ///   <para>locah:Creation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An event that resulted in the creation or accumulation of an archival resource.</para>
    /// labels<para>Creation</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/Creation">http://data.archiveshub.ac.uk/def/Creation</seealso>
    let Creation = Prefixed_Name(locah, "Creation") |> PrefixedName
    /// <summary>
    ///   <para>locah:Family</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A group of people affiliated by consanguinity, affinity, or co-residence.</para>
    /// labels<para>Family</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/Family">http://data.archiveshub.ac.uk/def/Family</seealso>
    let Family = Prefixed_Name(locah, "Family") |> PrefixedName
    /// <summary>
    ///   <para>locah:FindingAid</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A document describing an archival resource.</para>
    /// labels<para>Finding Aid</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/FindingAid">http://data.archiveshub.ac.uk/def/FindingAid</seealso>
    let FindingAid = Prefixed_Name(locah, "FindingAid") |> PrefixedName
    /// <summary>
    ///   <para>locah:isPublisherOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A resource which the agent makes available.</para>
    /// labels<para>Is Publisher Of</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/isPublisherOf">http://data.archiveshub.ac.uk/def/isPublisherOf</seealso>
    let isPublisherOf = Prefixed_Name(locah, "isPublisherOf") |> PrefixedName
    /// <summary>
    ///   <para>locah:item</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A number of items</para>
    /// labels<para>Item</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/item">http://data.archiveshub.ac.uk/def/item</seealso>
    let item = Prefixed_Name(locah, "item") |> PrefixedName
    /// <summary>
    ///   <para>locah:location</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Location</para>
    /// labels<para>Location</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/location">http://data.archiveshub.ac.uk/def/location</seealso>
    let location = Prefixed_Name(locah, "location") |> PrefixedName

    /// <summary>
    ///   <para>locah:locationOfOriginals</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Location of Originals</para>
    /// labels<para>Location of Originals</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/locationOfOriginals">http://data.archiveshub.ac.uk/def/locationOfOriginals</seealso>
    let locationOfOriginals =
        Prefixed_Name(locah, "locationOfOriginals") |> PrefixedName

    /// <summary>
    ///   <para>locah:members</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Members</para>
    /// labels<para>Members</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/members">http://data.archiveshub.ac.uk/def/members</seealso>
    let members = Prefixed_Name(locah, "members") |> PrefixedName
    /// <summary>
    ///   <para>locah:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Name</para>
    /// labels<para>Name</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/name">http://data.archiveshub.ac.uk/def/name</seealso>
    let name = Prefixed_Name(locah, "name") |> PrefixedName
    /// <summary>
    ///   <para>locah:other</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Other</para>
    /// labels<para>Other</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/other">http://data.archiveshub.ac.uk/def/other</seealso>
    let other = Prefixed_Name(locah, "other") |> PrefixedName
    /// <summary>
    ///   <para>locah:otherFindingAids</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Other Finding Aids</para>
    /// labels<para>Other Finding Aids</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/otherFindingAids">http://data.archiveshub.ac.uk/def/otherFindingAids</seealso>
    let otherFindingAids = Prefixed_Name(locah, "otherFindingAids") |> PrefixedName
    /// <summary>
    ///   <para>locah:page</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A number of pages</para>
    /// labels<para>Page</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/page">http://data.archiveshub.ac.uk/def/page</seealso>
    let page = Prefixed_Name(locah, "page") |> PrefixedName
    /// <summary>
    ///   <para>locah:paper</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A number of papers</para>
    /// labels<para>Paper</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/paper">http://data.archiveshub.ac.uk/def/paper</seealso>
    let paper = Prefixed_Name(locah, "paper") |> PrefixedName

    /// <summary>
    ///   <para>locah:physicalTechnicalRequirements</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Physical and Technical Requirements</para>
    /// labels<para>Physical and Technical Requirements</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/physicalTechnicalRequirements">http://data.archiveshub.ac.uk/def/physicalTechnicalRequirements</seealso>
    let physicalTechnicalRequirements =
        Prefixed_Name(locah, "physicalTechnicalRequirements") |> PrefixedName

    /// <summary>
    ///   <para>locah:relatedMaterial</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Related Material</para>
    /// labels<para>Related Material</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/relatedMaterial">http://data.archiveshub.ac.uk/def/relatedMaterial</seealso>
    let relatedMaterial = Prefixed_Name(locah, "relatedMaterial") |> PrefixedName
    /// <summary>
    ///   <para>locah:surname</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The surname of a person who is the focus of the concept</para>
    /// labels<para>Surname</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/surname">http://data.archiveshub.ac.uk/def/surname</seealso>
    let surname = Prefixed_Name(locah, "surname") |> PrefixedName
    /// <summary>
    ///   <para>locah:useRestrictions</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Use Restrictions</para>
    /// labels<para>Use Restrictions</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/useRestrictions">http://data.archiveshub.ac.uk/def/useRestrictions</seealso>
    let useRestrictions = Prefixed_Name(locah, "useRestrictions") |> PrefixedName
    /// <summary>
    ///   <para>locah:volume</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A number of volumes</para>
    /// labels<para>Volume</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/volume">http://data.archiveshub.ac.uk/def/volume</seealso>
    let volume = Prefixed_Name(locah, "volume") |> PrefixedName
    /// <summary>
    ///   <para>locah:EAD</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A document conforming to the Encoded Archival Description standard.</para>
    /// labels<para>EAD Document</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/EAD">http://data.archiveshub.ac.uk/def/EAD</seealso>
    let EAD = Prefixed_Name(locah, "EAD") |> PrefixedName
    /// <summary>
    ///   <para>locah:isOriginationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An archival resource for which the agent is responsible for the creation or accumulation.</para>
    /// labels<para>Is Origination Of</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/isOriginationOf">http://data.archiveshub.ac.uk/def/isOriginationOf</seealso>
    let isOriginationOf = Prefixed_Name(locah, "isOriginationOf") |> PrefixedName
    /// <summary>
    ///   <para>locah:Floruit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An event corresponding to the activity of an agent.</para>
    /// labels<para>Floruit</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/Floruit">http://data.archiveshub.ac.uk/def/Floruit</seealso>
    let Floruit = Prefixed_Name(locah, "Floruit") |> PrefixedName
    /// <summary>
    ///   <para>locah:GenreForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A category of archival material, defined either by style or technique of intellectual content, order of information or object function, or physical characteristics.</para>
    /// labels<para>Genre or Form</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/GenreForm">http://data.archiveshub.ac.uk/def/GenreForm</seealso>
    let GenreForm = Prefixed_Name(locah, "GenreForm") |> PrefixedName
    /// <summary>
    ///   <para>locah:Function</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A sphere of activity or process.</para>
    /// labels<para>Function</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/Function">http://data.archiveshub.ac.uk/def/Function</seealso>
    let Function = Prefixed_Name(locah, "Function") |> PrefixedName
    /// <summary>
    ///   <para>locah:Repository</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An institution or agency responsible for providing access to archival materials.</para>
    /// labels<para>Repository</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/Repository">http://data.archiveshub.ac.uk/def/Repository</seealso>
    let Repository = Prefixed_Name(locah, "Repository") |> PrefixedName
    /// <summary>
    ///   <para>locah:accessProvidedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An agent that provides access to the resource.</para>
    /// labels<para>Access Provided By</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/accessProvidedBy">http://data.archiveshub.ac.uk/def/accessProvidedBy</seealso>
    let accessProvidedBy = Prefixed_Name(locah, "accessProvidedBy") |> PrefixedName
    /// <summary>
    ///   <para>locah:accruals</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Accruals</para>
    /// labels<para>Accruals</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/accruals">http://data.archiveshub.ac.uk/def/accruals</seealso>
    let accruals = Prefixed_Name(locah, "accruals") |> PrefixedName
    /// <summary>
    ///   <para>locah:level</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An indicator of the part of an archival collection constituted by an archival resource.</para>
    /// labels<para>Level</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/level">http://data.archiveshub.ac.uk/def/level</seealso>
    let level = Prefixed_Name(locah, "level") |> PrefixedName

    /// <summary>
    ///   <para>locah:maintenanceAgencyCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ISO 15511 code for the repository.</para>
    /// labels<para>Maintenance Agency Code</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/maintenanceAgencyCode">http://data.archiveshub.ac.uk/def/maintenanceAgencyCode</seealso>
    let maintenanceAgencyCode =
        Prefixed_Name(locah, "maintenanceAgencyCode") |> PrefixedName

    /// <summary>
    ///   <para>locah:metre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A number of metres</para>
    /// labels<para>Metre</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/metre">http://data.archiveshub.ac.uk/def/metre</seealso>
    let metre = Prefixed_Name(locah, "metre") |> PrefixedName
    /// <summary>
    ///   <para>locah:note</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Note</para>
    /// labels<para>Note</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/note">http://data.archiveshub.ac.uk/def/note</seealso>
    let note = Prefixed_Name(locah, "note") |> PrefixedName
    /// <summary>
    ///   <para>locah:Level</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An indicator of the part of an archival collection constituted by an archival resource, whether it is the whole collection or a sub-section of it.</para>
    /// labels<para>Level</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/Level">http://data.archiveshub.ac.uk/def/Level</seealso>
    let Level = Prefixed_Name(locah, "Level") |> PrefixedName
    /// <summary>
    ///   <para>locah:processing</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Processing</para>
    /// labels<para>Processing</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/processing">http://data.archiveshub.ac.uk/def/processing</seealso>
    let processing = Prefixed_Name(locah, "processing") |> PrefixedName
    /// <summary>
    ///   <para>locah:scopecontent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Scope and Content</para>
    /// labels<para>Scope and Content</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/scopecontent">http://data.archiveshub.ac.uk/def/scopecontent</seealso>
    let scopecontent = Prefixed_Name(locah, "scopecontent") |> PrefixedName
    /// <summary>
    ///   <para>locah:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The title of a person who is the focus of the concept</para>
    /// labels<para>Title</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/title">http://data.archiveshub.ac.uk/def/title</seealso>
    let title = Prefixed_Name(locah, "title") |> PrefixedName
    /// <summary>
    ///   <para>locah:accessRestrictions</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Access Restrictions</para>
    /// labels<para>Access Restrictions</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/accessRestrictions">http://data.archiveshub.ac.uk/def/accessRestrictions</seealso>
    let accessRestrictions = Prefixed_Name(locah, "accessRestrictions") |> PrefixedName
    /// <summary>
    ///   <para>locah:providesAccessTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A resource to which the agent provides access.</para>
    /// labels<para>Provides Access To</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/providesAccessTo">http://data.archiveshub.ac.uk/def/providesAccessTo</seealso>
    let providesAccessTo = Prefixed_Name(locah, "providesAccessTo") |> PrefixedName
    /// <summary>
    ///   <para>locah:administers</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A resource which the agent manages.</para>
    /// labels<para>Administers</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/administers">http://data.archiveshub.ac.uk/def/administers</seealso>
    let administers = Prefixed_Name(locah, "administers") |> PrefixedName
    /// <summary>
    ///   <para>locah:isAdministeredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An agent that manages the resource.</para>
    /// labels<para>Is Administered By</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/isAdministeredBy">http://data.archiveshub.ac.uk/def/isAdministeredBy</seealso>
    let isAdministeredBy = Prefixed_Name(locah, "isAdministeredBy") |> PrefixedName

    /// <summary>
    ///   <para>locah:alternateFormsAvailable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Alternate Forms Available</para>
    /// labels<para>Alternate Forms Available</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/alternateFormsAvailable">http://data.archiveshub.ac.uk/def/alternateFormsAvailable</seealso>
    let alternateFormsAvailable =
        Prefixed_Name(locah, "alternateFormsAvailable") |> PrefixedName

    /// <summary>
    ///   <para>locah:archbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A number of archival boxes</para>
    /// labels<para>Archival Box</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/archbox">http://data.archiveshub.ac.uk/def/archbox</seealso>
    let archbox = Prefixed_Name(locah, "archbox") |> PrefixedName
    /// <summary>
    ///   <para>locah:associatedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A concept adjudged by a cataloguer to have an association with an archival resource which they consider useful for the purposes of discovering that resource.</para>
    /// labels<para>Associated With</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/associatedWith">http://data.archiveshub.ac.uk/def/associatedWith</seealso>
    let associatedWith = Prefixed_Name(locah, "associatedWith") |> PrefixedName
    /// <summary>
    ///   <para>locah:body</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A literal representation of the content of the document.</para>
    /// labels<para>Body</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/body">http://data.archiveshub.ac.uk/def/body</seealso>
    let body = Prefixed_Name(locah, "body") |> PrefixedName
    /// <summary>
    ///   <para>locah:countryCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ISO 3166-1 code for the country of the repository.</para>
    /// labels<para>Country Code</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/countryCode">http://data.archiveshub.ac.uk/def/countryCode</seealso>
    let countryCode = Prefixed_Name(locah, "countryCode") |> PrefixedName
    /// <summary>
    ///   <para>locah:cubicmetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A number of cubic metres</para>
    /// labels<para>Cubic Metre</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/cubicmetre">http://data.archiveshub.ac.uk/def/cubicmetre</seealso>
    let cubicmetre = Prefixed_Name(locah, "cubicmetre") |> PrefixedName
    /// <summary>
    ///   <para>locah:custodialHistory</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Custodial History</para>
    /// labels<para>Custodial History</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/custodialHistory">http://data.archiveshub.ac.uk/def/custodialHistory</seealso>
    let custodialHistory = Prefixed_Name(locah, "custodialHistory") |> PrefixedName

    /// <summary>
    ///   <para>locah:dateCreatedAccumulatedEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The end date, represented as a typed literal, of a time interval during which the archival resource was created or accumulated.</para>
    /// labels<para>Date created or accumulated (end)</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/dateCreatedAccumulatedEnd">http://data.archiveshub.ac.uk/def/dateCreatedAccumulatedEnd</seealso>
    let dateCreatedAccumulatedEnd =
        Prefixed_Name(locah, "dateCreatedAccumulatedEnd") |> PrefixedName

    /// <summary>
    ///   <para>locah:dateCreatedAccumulatedString</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date, represented as a string, of a time interval during which the archival resource was created or accumulated.</para>
    /// labels<para>Date created or accumulated</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/dateCreatedAccumulatedString">http://data.archiveshub.ac.uk/def/dateCreatedAccumulatedString</seealso>
    let dateCreatedAccumulatedString =
        Prefixed_Name(locah, "dateCreatedAccumulatedString") |> PrefixedName

    /// <summary>
    ///   <para>locah:acquisitions</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Acquisitions</para>
    /// labels<para>Acquisitions</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/acquisitions">http://data.archiveshub.ac.uk/def/acquisitions</seealso>
    let acquisitions = Prefixed_Name(locah, "acquisitions") |> PrefixedName
    /// <summary>
    ///   <para>locah:appraisal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Appraisal</para>
    /// labels<para>Appraisal</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/appraisal">http://data.archiveshub.ac.uk/def/appraisal</seealso>
    let appraisal = Prefixed_Name(locah, "appraisal") |> PrefixedName
    /// <summary>
    ///   <para>locah:bibliography</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Bibliography</para>
    /// labels<para>Bibliography</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/bibliography">http://data.archiveshub.ac.uk/def/bibliography</seealso>
    let bibliography = Prefixed_Name(locah, "bibliography") |> PrefixedName
    /// <summary>
    ///   <para>locah:dateBirth</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date of birth of the person.</para>
    /// labels<para>Date of Birth</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/dateBirth">http://data.archiveshub.ac.uk/def/dateBirth</seealso>
    let dateBirth = Prefixed_Name(locah, "dateBirth") |> PrefixedName

    /// <summary>
    ///   <para>locah:dateCreatedAccumulatedStart</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The start date, represented as a typed literal, of a time interval during which the archival resource was created or accumulated.</para>
    /// labels<para>Date created or accumulated (start)</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/dateCreatedAccumulatedStart">http://data.archiveshub.ac.uk/def/dateCreatedAccumulatedStart</seealso>
    let dateCreatedAccumulatedStart =
        Prefixed_Name(locah, "dateCreatedAccumulatedStart") |> PrefixedName

    /// <summary>
    ///   <para>locah:dates</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Dates</para>
    /// labels<para>Dates</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/dates">http://data.archiveshub.ac.uk/def/dates</seealso>
    let dates = Prefixed_Name(locah, "dates") |> PrefixedName
    /// <summary>
    ///   <para>locah:encodingOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An archival finding aid of which the EAD document is an encoding.</para>
    /// labels<para>Encoding Of</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/encodingOf">http://data.archiveshub.ac.uk/def/encodingOf</seealso>
    let encodingOf = Prefixed_Name(locah, "encodingOf") |> PrefixedName
    /// <summary>
    ///   <para>locah:envelope</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A number of envelopes</para>
    /// labels<para>Envelope</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/envelope">http://data.archiveshub.ac.uk/def/envelope</seealso>
    let envelope = Prefixed_Name(locah, "envelope") |> PrefixedName
    /// <summary>
    ///   <para>locah:epithet</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Epithet</para>
    /// labels<para>Epithet</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/epithet">http://data.archiveshub.ac.uk/def/epithet</seealso>
    let epithet = Prefixed_Name(locah, "epithet") |> PrefixedName
    /// <summary>
    ///   <para>locah:file</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A number of files</para>
    /// labels<para>File</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/file">http://data.archiveshub.ac.uk/def/file</seealso>
    let file = Prefixed_Name(locah, "file") |> PrefixedName
    /// <summary>
    ///   <para>locah:forename</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The forename of a person who is the focus of the concept</para>
    /// labels<para>Forename</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/forename">http://data.archiveshub.ac.uk/def/forename</seealso>
    let forename = Prefixed_Name(locah, "forename") |> PrefixedName

    /// <summary>
    ///   <para>locah:dateCreatedAccumulated</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date, represented as a typed literal, of a time interval during which the archival resource was created or accumulated.</para>
    /// labels<para>Date created or accumulated</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/dateCreatedAccumulated">http://data.archiveshub.ac.uk/def/dateCreatedAccumulated</seealso>
    let dateCreatedAccumulated =
        Prefixed_Name(locah, "dateCreatedAccumulated") |> PrefixedName

    /// <summary>
    ///   <para>locah:dateDeath</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date of death of the person.</para>
    /// labels<para>Date of Death</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/dateDeath">http://data.archiveshub.ac.uk/def/dateDeath</seealso>
    let dateDeath = Prefixed_Name(locah, "dateDeath") |> PrefixedName
    /// <summary>
    ///   <para>locah:encodedAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An EAD document that is an encoding of the archival finding aid.</para>
    /// labels<para>Encoded As</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/encodedAs">http://data.archiveshub.ac.uk/def/encodedAs</seealso>
    let encodedAs = Prefixed_Name(locah, "encodedAs") |> PrefixedName

    /// <summary>
    ///   <para>locah:hasBiographicalHistory</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A narrative or chronology that places archival materials in context by providing information about their creator(s).</para>
    /// labels<para>Has Biographical History</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/hasBiographicalHistory">http://data.archiveshub.ac.uk/def/hasBiographicalHistory</seealso>
    let hasBiographicalHistory =
        Prefixed_Name(locah, "hasBiographicalHistory") |> PrefixedName

    /// <summary>
    ///   <para>locah:isBiographicalHistoryFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An archival resource that the narrative or chronology places in context by providing information about their creator(s).</para>
    /// labels<para>Is Biographical History For</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/isBiographicalHistoryFor">http://data.archiveshub.ac.uk/def/isBiographicalHistoryFor</seealso>
    let isBiographicalHistoryFor =
        Prefixed_Name(locah, "isBiographicalHistoryFor") |> PrefixedName

    /// <summary>
    ///   <para>locah:isMaintenanceAgencyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An archival finding aid for which the repository is responsible for the maintenance.</para>
    /// labels<para>Is Maintenance Agency Of</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/isMaintenanceAgencyOf">http://data.archiveshub.ac.uk/def/isMaintenanceAgencyOf</seealso>
    let isMaintenanceAgencyOf =
        Prefixed_Name(locah, "isMaintenanceAgencyOf") |> PrefixedName

    /// <summary>
    ///   <para>locah:maintenanceAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A repository responsible for the maintenance of the archival finding aid.</para>
    /// labels<para>Maintenance Agency</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/maintenanceAgency">http://data.archiveshub.ac.uk/def/maintenanceAgency</seealso>
    let maintenanceAgency = Prefixed_Name(locah, "maintenanceAgency") |> PrefixedName
    /// <summary>
    ///   <para>locah:origination</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An agent responsible for the creation or accumulation of the archival resource.</para>
    /// labels<para>Origination</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/origination">http://data.archiveshub.ac.uk/def/origination</seealso>
    let origination = Prefixed_Name(locah, "origination") |> PrefixedName
    /// <summary>
    ///   <para>locah:isRepresentedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A resource which represents the archival resource, such as an image of a text page, a transcription of text, an audio or video clip, or an aggregation of such resources.</para>
    ///   <para>An archival resourcce represented by the resource.</para>
    /// labels<para>Is Represented By</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/isRepresentedBy">http://data.archiveshub.ac.uk/def/isRepresentedBy</seealso>
    let isRepresentedBy = Prefixed_Name(locah, "isRepresentedBy") |> PrefixedName
    /// <summary>
    ///   <para>locah:</para>
    /// </summary>
    /// <remarks>
    ///   <para>The LOCAH RDF Vocabulary</para>
    /// labels<para>The LOCAH RDF Vocabulary</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/">http://data.archiveshub.ac.uk/def/</seealso>
    let _prefix_iri = Prefixed_Name(locah, "") |> PrefixedName
    /// <summary>
    ///   <para>locah:ArchivalResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Recorded information in any form or medium, created or received and maintained, by an organization or person(s) in the transaction of business or the conduct of affairs, and maintained for its long-term research value. An archival resource may be an individual item, such as a letter or photograph, or (more commonly) some aggregation of such items managed and described as a unit.</para>
    /// labels<para>Archival Resource</para></remarks>
    /// <seealso href="http://data.archiveshub.ac.uk/def/ArchivalResource">http://data.archiveshub.ac.uk/def/ArchivalResource</seealso>
    let ArchivalResource = Prefixed_Name(locah, "ArchivalResource") |> PrefixedName

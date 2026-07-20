namespace http.www.loc.gov.mads.rdf.v1.hash

open DoxAletheia

module madsrdf =
    let _namespace_name = "http://www.loc.gov/mads/rdf/v1#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#Address"></see>
    /// </summary>
    let Address = _prefix "Address"
    /// <summary>
    /// A resource that describes an individual's affiliation with an
    ///       organization or group, such as the nature of the affiliation and the active
    ///       dates.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Affiliation"></see></summary>
    let Affiliation = _prefix "Affiliation"
    /// <summary>
    /// Describes a resource whose
    ///       label is a non-jurisdictional geographic entity.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Area"></see></summary>
    let Area = _prefix "Area"
    /// <summary>
    /// Describes a resource whose label represents a geographic place or
    ///       feature, especially when a more precise geographic determination (City, Country, Region, etc.)
    ///       cannot be made.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Geographic"></see></summary>
    let Geographic = _prefix "Geographic"
    /// <summary>
    /// A concept with a controlled
    ///       label.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Authority"></see></summary>
    let Authority = _prefix "Authority"
    /// <summary>
    /// A resource whose label is the alternate form of an Authority or
    ///       Deprecated Authority.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Variant"></see></summary>
    let Variant = _prefix "Variant"
    /// <summary>
    /// MADS Scheme is an organizational unit that describes a knowledge
    ///       organization system. It aggregates madsrdf:Authority descriptions and/or
    ///       madsrdf:MADSCollection resources included in the knowledge organization system. Including a
    ///       madsrdf:MADSCollection within a madsrdf:MADSScheme should be done with care; when a
    ///       madsrdf:MADSCollection is part of a madsrdf:MADSScheme, then any madsrdf:Authority within that
    ///       madsrdf:MADSCollection is effectively also in the madsrdf:MADSScheme.
    /// <see href="http://www.loc.gov/mads/rdf/v1#MADSScheme"></see></summary>
    let MADSScheme = _prefix "MADSScheme"
    /// <summary>
    /// A madsrdf:Collection is an
    ///       organizational unit, members of which will have some form of intellectually unifying theme but
    ///       not to the extent that it defines an independent knowledge organization system. It aggregates
    ///       madsrdf:Authority descriptions or other madsrdf:MADSCollection resources.
    /// <see href="http://www.loc.gov/mads/rdf/v1#MADSCollection"></see></summary>
    let MADSCollection = _prefix "MADSCollection"
    /// <summary>
    /// A former
    ///       Authority.
    /// <see href="http://www.loc.gov/mads/rdf/v1#DeprecatedAuthority"></see></summary>
    let DeprecatedAuthority = _prefix "DeprecatedAuthority"
    /// <summary>
    /// Describes a resource whose
    ///       label is an inhabited place incorporated as a city, town, etc.
    /// <see href="http://www.loc.gov/mads/rdf/v1#City"></see></summary>
    let City = _prefix "City"
    /// <summary>
    /// Describes a resource whose
    ///       label is a smaller unit within a populated place, e.g., a neighborhood, park, or
    ///       street.
    /// <see href="http://www.loc.gov/mads/rdf/v1#CitySection"></see></summary>
    let CitySection = _prefix "CitySection"
    /// <summary>
    /// The label of a madsrdf:ComplexSubject is the concatenation of labels
    ///       from two or more madsrdf:SimpleType descriptions, except that the combination of
    ///       madsrdf:SimpleType labels for the madsrdf:ComplexSubject does not meet the conditions to be
    ///       the label of a madsrdf:NameTitle resource or madsrdf:HierarchicalGeographic
    ///       resource.
    /// <see href="http://www.loc.gov/mads/rdf/v1#ComplexSubject"></see></summary>
    let ComplexSubject = _prefix "ComplexSubject"
    /// <summary>
    /// madsrdf:ComplexType is a resource whose label is the concatenation
    ///       of labels from two or more Authority descriptions or two or more Variant descriptions or some
    ///       combination of Authority and Variant descriptions, each of a
    ///       madsrdf:SimpleType.
    /// <see href="http://www.loc.gov/mads/rdf/v1#ComplexType"></see></summary>
    let ComplexType = _prefix "ComplexType"
    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#MADSType"></see>
    /// </summary>
    let MADSType = _prefix "MADSType"
    /// <summary>
    /// A madsrdf:HierarchicalGeographic indicates that its label is the
    ///       concatenation of labels from a sequence of madsrdf:Geographic types taken from one of the
    ///       madsrdf:Geographic sub-classes such as madsrdf:City, madsrdf:Country, madsrdf:State,
    ///       madsrdf:Region, madsrdf:Area, etc. The madsrdf:Geographic resources that constitute the
    ///       madsrdf:HierarchicalGeographic should have a broader to narrower hierarchical relationship
    ///       between them.
    /// <see href="http://www.loc.gov/mads/rdf/v1#HierarchicalGeographic"></see></summary>
    let HierarchicalGeographic = _prefix "HierarchicalGeographic"
    /// <summary>
    /// The label of a madsrdf:NameTitle resource is the concatenation of a
    ///       label of a madsrdf:Name description and the label of a madsrdf:Title description. Both
    ///       description types (madsrdf:Name and madsrdf:Title) are of madsrdf:SimpleType
    ///       types.
    /// <see href="http://www.loc.gov/mads/rdf/v1#NameTitle"></see></summary>
    let NameTitle = _prefix "NameTitle"
    /// <summary>
    /// madsrdf:SimpleType is a resource with a label constituting a single
    ///       word or phrase.
    /// <see href="http://www.loc.gov/mads/rdf/v1#SimpleType"></see></summary>
    let SimpleType = _prefix "SimpleType"
    /// <summary>
    /// madsrdf:componentList
    ///       organizes the madsrdf:SimpleType resources whose labels are represented in the label of the
    ///       associated madsrdf:ComplexType resource.
    /// <see href="http://www.loc.gov/mads/rdf/v1#componentList"></see></summary>
    let componentList = _prefix "componentList"
    /// <summary>
    /// Describes a resource whose
    ///       label represents a conference name.
    /// <see href="http://www.loc.gov/mads/rdf/v1#ConferenceName"></see></summary>
    let ConferenceName = _prefix "ConferenceName"
    /// <summary>
    /// Describes a resource whose label represents a name, especially when
    ///       a more precise Name type (madsrdf:ConferenceName, masdrdf:FamilyName, etc.) cannot be
    ///       identified.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Name"></see></summary>
    let Name = _prefix "Name"
    /// <summary>
    /// Describes a resource whose
    ///       label is one of seven large landmasses on Earth. These are: Asia, Africa, Europe, North
    ///       America, South America, Australia, and Antarctica.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Continent"></see></summary>
    let Continent = _prefix "Continent"
    /// <summary>
    /// Describes a resource whose
    ///       label is the name of a corporate entity, which may include political or ecclesiastical
    ///       entities.
    /// <see href="http://www.loc.gov/mads/rdf/v1#CorporateName"></see></summary>
    let CorporateName = _prefix "CorporateName"
    /// <summary>
    /// Describes a resource whose
    ///       label is a country, i.e. a political entity considered a country.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Country"></see></summary>
    let Country = _prefix "Country"
    /// <summary>
    /// Describes a resource whose
    ///       label is the largest local administrative unit, e.g. Warwickshire, in a country, e.g.
    ///       England.
    /// <see href="http://www.loc.gov/mads/rdf/v1#County"></see></summary>
    let County = _prefix "County"
    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#DateNameElement"></see>
    /// </summary>
    let DateNameElement = _prefix "DateNameElement"
    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#NameElement"></see>
    /// </summary>
    let NameElement = _prefix "NameElement"
    /// <summary>
    /// madsrdf:Element types
    ///       describe the various parts of labels.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Element"></see></summary>
    let Element = _prefix "Element"
    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#elementValue"></see>
    /// </summary>
    let elementValue = _prefix "elementValue"
    /// <summary>
    /// Describes a resource whose
    ///       label is any extraterrestrial entity or space, including a solar system, a galaxy, a star
    ///       system, and a planet, including a geographic feature of an individual planet.
    /// <see href="http://www.loc.gov/mads/rdf/v1#ExtraterrestrialArea"></see></summary>
    let ExtraterrestrialArea = _prefix "ExtraterrestrialArea"
    /// <summary>
    /// Describes a resource whose
    ///       label represents a family name.
    /// <see href="http://www.loc.gov/mads/rdf/v1#FamilyName"></see></summary>
    let FamilyName = _prefix "FamilyName"
    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#FamilyNameElement"></see>
    /// </summary>
    let FamilyNameElement = _prefix "FamilyNameElement"
    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#FullNameElement"></see>
    /// </summary>
    let FullNameElement = _prefix "FullNameElement"
    /// <summary>
    /// Describes a resource whose label is a genre or form term. Genre
    ///       terms for textual materials designate specific kinds of materials distinguished by the style
    ///       or technique of their intellectual contents; for example, biographies, catechisms, essays,
    ///       hymns, or reviews. Form terms designate historically and functionally specific kinds of
    ///       materials as distinguished by an examination of their physical character, characteristics of
    ///       their intellectual content, or the order of information within them; for example, daybooks,
    ///       diaries, directories, journals, memoranda, questionnaires, syllabi, or time sheets. In the
    ///       context of graphic materials, genre headings denote categories of material distinguished by
    ///       vantage point, intended purpose, characteristics of the creator, publication status, or method
    ///       of representation.
    /// <see href="http://www.loc.gov/mads/rdf/v1#GenreForm"></see></summary>
    let GenreForm = _prefix "GenreForm"
    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#GenreFormElement"></see>
    /// </summary>
    let GenreFormElement = _prefix "GenreFormElement"
    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#GeographicElement"></see>
    /// </summary>
    let GeographicElement = _prefix "GeographicElement"
    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#GivenNameElement"></see>
    /// </summary>
    let GivenNameElement = _prefix "GivenNameElement"
    /// <summary>
    /// A madsrdf:Identifier
    ///       resource describes an identifier by associating the identifier value with its type. To be used
    ///       to record identifiers for a resource in the absence of URIs.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Identifier"></see></summary>
    let Identifier = _prefix "Identifier"
    /// <summary>
    /// Describes a resource whose
    ///       label is a tract of land surrounded by water and smaller than a continent but is not itself a
    ///       separate country.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Island"></see></summary>
    let Island = _prefix "Island"
    /// <summary>
    /// Describes a resource whose label represents a
    ///       language.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Language"></see></summary>
    let Language = _prefix "Language"
    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#LanguageElement"></see>
    /// </summary>
    let LanguageElement = _prefix "LanguageElement"
    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#MainTitleElement"></see>
    /// </summary>
    let MainTitleElement = _prefix "MainTitleElement"
    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#TitleElement"></see>
    /// </summary>
    let TitleElement = _prefix "TitleElement"
    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#NonSortElement"></see>
    /// </summary>
    let NonSortElement = _prefix "NonSortElement"
    /// <summary>
    /// Describes a resource whose
    ///       label represents an occcupation.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Occupation"></see></summary>
    let Occupation = _prefix "Occupation"
    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#PartNameElement"></see>
    /// </summary>
    let PartNameElement = _prefix "PartNameElement"
    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#PartNumberElement"></see>
    /// </summary>
    let PartNumberElement = _prefix "PartNumberElement"
    /// <summary>
    /// Describes a resource whose
    ///       label represents a personal name.
    /// <see href="http://www.loc.gov/mads/rdf/v1#PersonalName"></see></summary>
    let PersonalName = _prefix "PersonalName"
    /// <summary>
    /// Describes a resource whose
    ///       label is a first order political division, e.g. Ontario, within a country, e.g. Canada.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Province"></see></summary>
    let Province = _prefix "Province"
    /// <summary>
    /// A madsrdf:RWO is an
    ///       abstract entity and identifies a Real World Object (RWO) identified by the label of a
    ///       madsrdf:Authority or madsrdf:DeprecatedAuthority.
    /// <see href="http://www.loc.gov/mads/rdf/v1#RWO"></see></summary>
    let RWO = _prefix "RWO"
    /// <summary>
    /// Describes a resource whose
    ///       label is an area that has the status of a jurisdiction, usually incorporating more than one
    ///       first level jurisdiction.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Region"></see></summary>
    let Region = _prefix "Region"
    /// <summary>
    /// A resource that represents
    ///       the source of information about another resource. madsrdf:Source is a type of
    ///       citation.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Source"></see></summary>
    let Source = _prefix "Source"
    /// <summary>
    /// Describes a resource whose
    ///       label is a first order political division, e.g. Montana, within a country, e.g.
    ///       U.S.
    /// <see href="http://www.loc.gov/mads/rdf/v1#State"></see></summary>
    let State = _prefix "State"
    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#SubTitleElement"></see>
    /// </summary>
    let SubTitleElement = _prefix "SubTitleElement"
    /// <summary>
    /// Describes a resource whose
    ///       label represents a time-based notion.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Temporal"></see></summary>
    let Temporal = _prefix "Temporal"
    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#TemporalElement"></see>
    /// </summary>
    let TemporalElement = _prefix "TemporalElement"
    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#TermsOfAddressNameElement"></see>
    /// </summary>
    let TermsOfAddressNameElement = _prefix "TermsOfAddressNameElement"
    /// <summary>
    /// Describes a resource whose
    ///       label is a geographical area belonging to or under the jurisdiction of a governmental
    ///       authority.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Territory"></see></summary>
    let Territory = _prefix "Territory"
    /// <summary>
    /// Describes a resource whose
    ///       label represents a title.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Title"></see></summary>
    let Title = _prefix "Title"
    /// <summary>
    /// Describes a resource whose
    ///       label represents a topic.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Topic"></see></summary>
    let Topic = _prefix "Topic"
    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#TopicElement"></see>
    /// </summary>
    let TopicElement = _prefix "TopicElement"
    /// <summary>
    /// Latest date in a period of activity.
    ///
    /// <see href="http://www.loc.gov/mads/rdf/v1#activityEndDate"></see></summary>
    let activityEndDate = _prefix "activityEndDate"
    /// <summary>
    /// Earliest date in a period of activity.
    ///
    /// <see href="http://www.loc.gov/mads/rdf/v1#activityStartDate"></see></summary>
    let activityStartDate = _prefix "activityStartDate"
    /// <summary>
    /// This relates an Authority or Variant to its administrative metadata,
    ///       which is, minimimally, a Class defined outside of the MADS/RDF namespace. The RecordInfo Class
    ///       from the RecordInfo ontology is recommended.
    /// <see href="http://www.loc.gov/mads/rdf/v1#adminMetadata"></see></summary>
    let adminMetadata = _prefix "adminMetadata"
    /// <summary>
    /// The date an individual
    ///       ceased to be affiliated with an organization.
    /// <see href="http://www.loc.gov/mads/rdf/v1#affiliationEnd"></see></summary>
    let affiliationEnd = _prefix "affiliationEnd"
    /// <summary>
    /// The date an individual
    ///       established an affiliation with an organization.
    /// <see href="http://www.loc.gov/mads/rdf/v1#affiliationStart"></see></summary>
    let affiliationStart = _prefix "affiliationStart"
    /// <summary>
    /// Language that a person,
    ///       organization, or family uses for publication, communication, etc., or in which a work is
    ///       expressed.
    /// <see href="http://www.loc.gov/mads/rdf/v1#associatedLanguage"></see></summary>
    let associatedLanguage = _prefix "associatedLanguage"
    /// <summary>
    /// A town, city, province,
    ///       state, and/or country associated with persons, corporate bodies, families, works, and
    ///       expressions.
    /// <see href="http://www.loc.gov/mads/rdf/v1#associatedLocale"></see></summary>
    let associatedLocale = _prefix "associatedLocale"
    /// <summary>
    /// A lexical string representing a controlled, curated label for the
    ///       Authority.
    /// <see href="http://www.loc.gov/mads/rdf/v1#authoritativeLabel"></see></summary>
    let authoritativeLabel = _prefix "authoritativeLabel"
    /// <summary>
    /// The year a person was born.
    ///       Date of birth may also include the month and day of the person’s birth. (RDA
    ///       9.3.2.1)
    /// <see href="http://www.loc.gov/mads/rdf/v1#birthDate"></see></summary>
    let birthDate = _prefix "birthDate"
    /// <summary>
    /// The town, city, province,
    ///       state, and/or country in which a person was born.
    /// <see href="http://www.loc.gov/mads/rdf/v1#birthPlace"></see></summary>
    let birthPlace = _prefix "birthPlace"
    /// <summary>
    /// A note detailing a modification to an Authority or
    ///       Variant.
    /// <see href="http://www.loc.gov/mads/rdf/v1#changeNote"></see></summary>
    let changeNote = _prefix "changeNote"
    /// <summary>
    /// A note about the
    ///       resource.
    /// <see href="http://www.loc.gov/mads/rdf/v1#note"></see></summary>
    let note = _prefix "note"
    /// <summary>
    /// A note about how the madsrdf:Source relates to the resource about
    ///       which the madsrdf:Source is the information source.
    /// <see href="http://www.loc.gov/mads/rdf/v1#citationNote"></see></summary>
    let citationNote = _prefix "citationNote"
    /// <summary>
    /// The cited resource.
    /// <see href="http://www.loc.gov/mads/rdf/v1#citationSource"></see></summary>
    let citationSource = _prefix "citationSource"
    /// <summary>
    /// Should use a standard term - such as 'found' or 'not found' - to
    ///       indicate whether the cited resource yielded information about the resource related to the
    ///       madsrdf:Source.
    /// <see href="http://www.loc.gov/mads/rdf/v1#citationStatus"></see></summary>
    let citationStatus = _prefix "citationStatus"
    /// <summary>
    /// The city component of an address.
    /// <see href="http://www.loc.gov/mads/rdf/v1#city"></see></summary>
    let city = _prefix "city"
    /// <summary>
    /// The classification code associated with a
    ///       madsrdf:Authority.
    /// <see href="http://www.loc.gov/mads/rdf/v1#classification"></see></summary>
    let classification = _prefix "classification"
    /// <summary>
    /// A code is a string of
    ///       characters associated with a the authoritative or deprecated label. It may record an
    ///       historical notation once used to uniquely identify a concept.
    /// <see href="http://www.loc.gov/mads/rdf/v1#code"></see></summary>
    let code = _prefix "code"
    /// <summary>
    /// Country associated with an
    ///       address.
    /// <see href="http://www.loc.gov/mads/rdf/v1#country"></see></summary>
    let country = _prefix "country"
    /// <summary>
    /// Ending date of the date range for which the beginning date is recorded in madsrdf:creationDateStart.
    /// <see href="http://www.loc.gov/mads/rdf/v1#creationDateEnd"></see></summary>
    let creationDateEnd = _prefix "creationDateEnd"
    /// <summary>
    /// For a work, earliest date (normally the year) associated with a work; that date may be the date the work was created or first published or released. For an expression, the earliest date (normally the year) associated with an expression; that date may be the date of the earliest known manifestation of that expression. In both cases the date may be the starting date of a range or a single date.
    /// <see href="http://www.loc.gov/mads/rdf/v1#creationDateStart"></see></summary>
    let creationDateStart = _prefix "creationDateStart"
    /// <summary>
    /// The year a person died.
    ///       Date of death may also include the month and day of the person’s death. (RDA
    ///       9.3.3.1)
    /// <see href="http://www.loc.gov/mads/rdf/v1#deathDate"></see></summary>
    let deathDate = _prefix "deathDate"
    /// <summary>
    /// The town, city, province,
    ///       state, and/or country in which a person died.
    /// <see href="http://www.loc.gov/mads/rdf/v1#deathPlace"></see></summary>
    let deathPlace = _prefix "deathPlace"
    /// <summary>
    /// An explanation of the meaning of an Authority, DeprecatedAuthority,
    ///       or Variant description.
    /// <see href="http://www.loc.gov/mads/rdf/v1#definitionNote"></see></summary>
    let definitionNote = _prefix "definitionNote"
    /// <summary>
    /// A note pertaining to the
    ///       deletion of a resource.
    /// <see href="http://www.loc.gov/mads/rdf/v1#deletionNote"></see></summary>
    let deletionNote = _prefix "deletionNote"
    /// <summary>
    /// A label once considered
    ///       authoritative (controlled and curated) but which is no longer.
    /// <see href="http://www.loc.gov/mads/rdf/v1#deprecatedLabel"></see></summary>
    let deprecatedLabel = _prefix "deprecatedLabel"
    /// <summary>
    /// A note pertaining to the
    ///       management of the label associated with the resource.
    /// <see href="http://www.loc.gov/mads/rdf/v1#editorialNote"></see></summary>
    let editorialNote = _prefix "editorialNote"
    /// <summary>
    /// The madsrdf:elementList property is used to organize the various
    ///       parts of labels.
    /// <see href="http://www.loc.gov/mads/rdf/v1#elementList"></see></summary>
    let elementList = _prefix "elementList"
    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#email"></see>
    /// </summary>
    let email = _prefix "email"
    /// <summary>
    /// Any attribute that serves
    ///       to characterize a person, family or corporate body or that may be needed for differentiation
    ///       from other persons. families or corporate bodies and for which separate content designation is
    ///       not already defined.Or
    /// <see href="http://www.loc.gov/mads/rdf/v1#entityDescriptor"></see></summary>
    let entityDescriptor = _prefix "entityDescriptor"
    /// <summary>
    /// The year a corporate body was established. Date of establishment may also include the month and day of the corporate body’s establishment.
    ///
    /// <see href="http://www.loc.gov/mads/rdf/v1#establishDate"></see></summary>
    let establishDate = _prefix "establishDate"
    /// <summary>
    /// A example of how the
    ///       resource might be used.
    /// <see href="http://www.loc.gov/mads/rdf/v1#exampleNote"></see></summary>
    let exampleNote = _prefix "exampleNote"
    /// <summary>
    /// The second address line, if
    ///       needed.
    /// <see href="http://www.loc.gov/mads/rdf/v1#extendedAddress"></see></summary>
    let extendedAddress = _prefix "extendedAddress"
    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#extension"></see>
    /// </summary>
    let extension = _prefix "extension"
    /// <summary>
    /// Fax number
    /// <see href="http://www.loc.gov/mads/rdf/v1#fax"></see></summary>
    let fax = _prefix "fax"
    /// <summary>
    /// The field of activity
    ///       associated with an individual.
    /// <see href="http://www.loc.gov/mads/rdf/v1#fieldOfActivity"></see></summary>
    let fieldOfActivity = _prefix "fieldOfActivity"
    /// <summary>
    /// Full form of name needed to
    ///       distinguish a person from another person with the same preferred name.
    /// <see href="http://www.loc.gov/mads/rdf/v1#fullerName"></see></summary>
    let fullerName = _prefix "fullerName"
    /// <summary>
    /// The gender with which a
    ///       person identifies.
    /// <see href="http://www.loc.gov/mads/rdf/v1#gender"></see></summary>
    let gender = _prefix "gender"
    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#hasAbbreviationVariant"></see>
    /// </summary>
    let hasAbbreviationVariant = _prefix "hasAbbreviationVariant"
    /// <summary>
    /// Associates a Variant with an Authority or Deprecrated Authority.
    ///       Unless the variant type can be more specifically identified, use 'hasVariant.'
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasVariant"></see></summary>
    let hasVariant = _prefix "hasVariant"
    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#hasAcronymVariant"></see>
    /// </summary>
    let hasAcronymVariant = _prefix "hasAcronymVariant"
    /// <summary>
    /// Property to associate an
    ///       individual, such as a foaf:Agent, to a group or organization with which an individual is or
    ///       has been affiliated.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasAffiliation"></see></summary>
    let hasAffiliation = _prefix "hasAffiliation"
    /// <summary>
    /// The address of the group or
    ///       organization with which an individual is associated.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasAffiliationAddress"></see></summary>
    let hasAffiliationAddress = _prefix "hasAffiliationAddress"
    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#hasBroaderAuthority"></see>
    /// </summary>
    let hasBroaderAuthority = _prefix "hasBroaderAuthority"
    /// <summary>
    /// Unless the relationship can be more specifically identified, use
    ///       'hasRelatedAuthority.'
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasRelatedAuthority"></see></summary>
    let hasRelatedAuthority = _prefix "hasRelatedAuthority"
    /// <summary>
    /// Creates a direct
    ///       relationship between an Authority and one that is more narrowly defined.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasNarrowerAuthority"></see></summary>
    let hasNarrowerAuthority = _prefix "hasNarrowerAuthority"
    /// <summary>
    /// Creates a direct
    ///       relationship between an Authority and a more broadly defined Authority from a different MADS
    ///       Scheme.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasBroaderExternalAuthority"></see></summary>
    let hasBroaderExternalAuthority = _prefix "hasBroaderExternalAuthority"
    /// <summary>
    /// A term that specifies a characteristic that differentiates a work or expression from another one.
    ///
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasChararacteristic"></see></summary>
    let hasChararacteristic = _prefix "hasChararacteristic"
    /// <summary>
    /// Records a relationship
    ///       between an Authority and one that is closely related from a different MADS
    ///       Scheme.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasCloseExternalAuthority"></see></summary>
    let hasCloseExternalAuthority = _prefix "hasCloseExternalAuthority"
    /// <summary>
    /// Establishes a relationship
    ///       between a CorporateName Authority and one of the same that is more broadly
    ///       defined.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasCorporateParentAuthority"></see></summary>
    let hasCorporateParentAuthority = _prefix "hasCorporateParentAuthority"
    /// <summary>
    /// Establishes a relationship
    ///       between a CorporateName Authority and one of the same that is more narrowly
    ///       defined.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasCorporateSubsidiaryAuthority"></see></summary>
    let hasCorporateSubsidiaryAuthority = _prefix "hasCorporateSubsidiaryAuthority"
    /// <summary>
    /// Used to reference a resource that was an earlier form. This is
    ///       Related type='earlier' in MADS XML.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasEarlierEstablishedForm"></see></summary>
    let hasEarlierEstablishedForm = _prefix "hasEarlierEstablishedForm"
    /// <summary>
    /// Denotes a relationship
    ///       between an Authority and/or DeprecatedAuthority. The relationship may or may or may not be
    ///       reciprocated and there is no certainty that the related resource will further illuminate the
    ///       original resource.
    /// <see href="http://www.loc.gov/mads/rdf/v1#see"></see></summary>
    let see = _prefix "see"
    /// <summary>
    /// Use to reference the later form of a resource. This is Related
    ///       type='later' in MADS XML.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasLaterEstablishedForm"></see></summary>
    let hasLaterEstablishedForm = _prefix "hasLaterEstablishedForm"
    /// <summary>
    /// Records a relationship
    ///       between an Authority and one to which it matches exactly but from a different MADS
    ///       Scheme.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasExactExternalAuthority"></see></summary>
    let hasExactExternalAuthority = _prefix "hasExactExternalAuthority"
    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#hasExpansionVariant"></see>
    /// </summary>
    let hasExpansionVariant = _prefix "hasExpansionVariant"
    /// <summary>
    /// Use for variants that are searchable, but not necessarily for
    ///       display.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasHiddenVariant"></see></summary>
    let hasHiddenVariant = _prefix "hasHiddenVariant"
    /// <summary>
    /// Associates a resource with
    ///       a madsrdf:Identifier.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasIdentifier"></see></summary>
    let hasIdentifier = _prefix "hasIdentifier"
    /// <summary>
    /// Associates an Authority or other Collection with a
    ///       madsrdf:MADSCollection.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasMADSCollectionMember"></see></summary>
    let hasMADSCollectionMember = _prefix "hasMADSCollectionMember"
    /// <summary>
    /// Associates a Collection with a madsrdf:Authority or another
    ///       madsrdf:MADSCollection.
    /// <see href="http://www.loc.gov/mads/rdf/v1#isMemberOfMADSCollection"></see></summary>
    let isMemberOfMADSCollection = _prefix "isMemberOfMADSCollection"
    /// <summary>
    /// Associates an Authority or Collection with a
    ///       madsrdf:MADSScheme.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasMADSSchemeMember"></see></summary>
    let hasMADSSchemeMember = _prefix "hasMADSSchemeMember"
    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#isMemberOfMADSScheme"></see>
    /// </summary>
    let isMemberOfMADSScheme = _prefix "isMemberOfMADSScheme"
    /// <summary>
    /// Creates a direct
    ///       relationship between an Authority and a more narrowly defined Authority from a different MADS
    ///       Scheme.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasNarrowerExternalAuthority"></see></summary>
    let hasNarrowerExternalAuthority = _prefix "hasNarrowerExternalAuthority"
    /// <summary>
    /// Establishes a relationship between two Authority resources. It is
    ///       reciprocal, so the relationship must be shared. This is Related type='equivalent' in MADS
    ///       XML.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasReciprocalAuthority"></see></summary>
    let hasReciprocalAuthority = _prefix "hasReciprocalAuthority"
    /// <summary>
    /// Establishes a relationship
    ///       between an Authority and one from a different MADS Scheme. It is reciprocal, so the
    ///       relationship must be shared.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasReciprocalExternalAuthority"></see></summary>
    let hasReciprocalExternalAuthority = _prefix "hasReciprocalExternalAuthority"
    /// <summary>
    /// Associates a resource description with its Source.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasSource"></see></summary>
    let hasSource = _prefix "hasSource"
    /// <summary>
    /// Identifies an Authority
    ///       that is at the top of the hierarchy of authorities within the MADS Scheme.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasTopMemberOfMADSScheme"></see></summary>
    let hasTopMemberOfMADSScheme = _prefix "hasTopMemberOfMADSScheme"
    /// <summary>
    /// A Variant whose label
    ///       represents a translation of that of the authoritative label.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasTranslationVariant"></see></summary>
    let hasTranslationVariant = _prefix "hasTranslationVariant"
    /// <summary>
    /// A label entered for
    ///       discovery purposes but not shown.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hiddenLabel"></see></summary>
    let hiddenLabel = _prefix "hiddenLabel"
    /// <summary>
    /// A note pertaining to the
    ///       history of the resource.
    /// <see href="http://www.loc.gov/mads/rdf/v1#historyNote"></see></summary>
    let historyNote = _prefix "historyNote"
    /// <summary>
    /// Designation indicative of
    ///       royalty, nobility, or ecclesiastical rank or office, or a term of address for a person of
    ///       religious vocation.
    /// <see href="http://www.loc.gov/mads/rdf/v1#honoraryTitle"></see></summary>
    let honoraryTitle = _prefix "honoraryTitle"
    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#hours"></see>
    /// </summary>
    let hours = _prefix "hours"
    /// <summary>
    /// The scheme associated with
    ///       the identifier. For example, "LCCN" would be used when the Identifier Value (madsrdf:idValue)
    ///       is a LC Control Number.
    /// <see href="http://www.loc.gov/mads/rdf/v1#idScheme"></see></summary>
    let idScheme = _prefix "idScheme"
    /// <summary>
    /// The value of the identifier
    ///       conforming to the Identifier Scheme syntax.
    /// <see href="http://www.loc.gov/mads/rdf/v1#idValue"></see></summary>
    let idValue = _prefix "idValue"
    /// <summary>
    /// Associates a
    ///       madsrdf:Authority with the Real World Object that is the subject of the authority's
    ///       label.
    /// <see href="http://www.loc.gov/mads/rdf/v1#identifiesRWO"></see></summary>
    let identifiesRWO = _prefix "identifiesRWO"
    /// <summary>
    /// Associates a Real World
    ///       Object with its Authority description.
    /// <see href="http://www.loc.gov/mads/rdf/v1#isIdentifiedByAuthority"></see></summary>
    let isIdentifiedByAuthority = _prefix "isIdentifiedByAuthority"
    /// <summary>
    /// Identifies a MADS Scheme in
    ///       which the Authority is at the top of the hierarchy.
    /// <see href="http://www.loc.gov/mads/rdf/v1#isTopMemberOfMADSScheme"></see></summary>
    let isTopMemberOfMADSScheme = _prefix "isTopMemberOfMADSScheme"
    /// <summary>
    /// Records the individual's
    ///       role or position in the organization with which the individual is affiliated. A "job title"
    ///       might be appropriate.
    /// <see href="http://www.loc.gov/mads/rdf/v1#natureOfAffiliation"></see></summary>
    let natureOfAffiliation = _prefix "natureOfAffiliation"
    /// <summary>
    /// A profession or occupation
    ///       in which the person works or has worked.
    /// <see href="http://www.loc.gov/mads/rdf/v1#occupation"></see></summary>
    let occupation = _prefix "occupation"
    /// <summary>
    /// The group or organization
    ///       with which an individual is associated.
    /// <see href="http://www.loc.gov/mads/rdf/v1#organization"></see></summary>
    let organization = _prefix "organization"
    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#phone"></see>
    /// </summary>
    let phone = _prefix "phone"
    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#postcode"></see>
    /// </summary>
    let postcode = _prefix "postcode"
    /// <summary>
    /// A well-known individual who
    ///       is a member of the family.
    /// <see href="http://www.loc.gov/mads/rdf/v1#prominentFamilyMember"></see></summary>
    let prominentFamilyMember = _prefix "prominentFamilyMember"
    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#scopeNote"></see>
    /// </summary>
    let scopeNote = _prefix "scopeNote"
    /// <summary>
    /// The state associated with
    ///       an address.
    /// <see href="http://www.loc.gov/mads/rdf/v1#state"></see></summary>
    let state = _prefix "state"
    /// <summary>
    /// First line of address. For
    ///       second line, use madsrdf:extendedAddress.
    /// <see href="http://www.loc.gov/mads/rdf/v1#streetAddress"></see></summary>
    let streetAddress = _prefix "streetAddress"
    /// <summary>
    /// The year a corporate body was terminated. Date of termination may also include the month and day of the corporate body’s termination.
    ///
    /// <see href="http://www.loc.gov/mads/rdf/v1#terminateDate"></see></summary>
    let terminateDate = _prefix "terminateDate"
    /// <summary>
    /// "Use [This Resource] For."
    ///       Traditional "USE FOR" reference.
    /// <see href="http://www.loc.gov/mads/rdf/v1#useFor"></see></summary>
    let useFor = _prefix "useFor"
    /// <summary>
    /// "Use [This Other Resource]
    ///       Instead." Traditional "USE" reference.
    /// <see href="http://www.loc.gov/mads/rdf/v1#useInstead"></see></summary>
    let useInstead = _prefix "useInstead"
    /// <summary>
    /// The lexical, variant form
    ///       of an authoritative label.
    /// <see href="http://www.loc.gov/mads/rdf/v1#variantLabel"></see></summary>
    let variantLabel = _prefix "variantLabel"
    /// <summary>
    /// The country or other territorial jurisdiction from which a work originated.
    /// <see href="http://www.loc.gov/mads/rdf/v1#workOrigin"></see></summary>
    let workOrigin = _prefix "workOrigin"

namespace http.www.loc.gov.mads.rdf.v1.hash

open DoxAletheia.Rdf_Vocabulary

module madsrdf =
    let _namespace_name = "http://www.loc.gov/mads/rdf/v1#"
    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#Address"></see>
    /// </summary>
    let Address = Namespaced_IRI.parse _namespace_name "Address" |> NamespacedName

    /// <summary>
    /// A resource that describes an individual's affiliation with an
    ///       organization or group, such as the nature of the affiliation and the active
    ///       dates.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Affiliation"></see></summary>
    let Affiliation =
        Namespaced_IRI.parse _namespace_name "Affiliation" |> NamespacedName

    /// <summary>
    /// Describes a resource whose
    ///       label is a non-jurisdictional geographic entity.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Area"></see></summary>
    let Area = Namespaced_IRI.parse _namespace_name "Area" |> NamespacedName
    /// <summary>
    /// Describes a resource whose label represents a geographic place or
    ///       feature, especially when a more precise geographic determination (City, Country, Region, etc.)
    ///       cannot be made.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Geographic"></see></summary>
    let Geographic = Namespaced_IRI.parse _namespace_name "Geographic" |> NamespacedName
    /// <summary>
    /// A concept with a controlled
    ///       label.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Authority"></see></summary>
    let Authority = Namespaced_IRI.parse _namespace_name "Authority" |> NamespacedName
    /// <summary>
    /// A resource whose label is the alternate form of an Authority or
    ///       Deprecated Authority.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Variant"></see></summary>
    let Variant = Namespaced_IRI.parse _namespace_name "Variant" |> NamespacedName
    /// <summary>
    /// MADS Scheme is an organizational unit that describes a knowledge
    ///       organization system. It aggregates madsrdf:Authority descriptions and/or
    ///       madsrdf:MADSCollection resources included in the knowledge organization system. Including a
    ///       madsrdf:MADSCollection within a madsrdf:MADSScheme should be done with care; when a
    ///       madsrdf:MADSCollection is part of a madsrdf:MADSScheme, then any madsrdf:Authority within that
    ///       madsrdf:MADSCollection is effectively also in the madsrdf:MADSScheme.
    /// <see href="http://www.loc.gov/mads/rdf/v1#MADSScheme"></see></summary>
    let MADSScheme = Namespaced_IRI.parse _namespace_name "MADSScheme" |> NamespacedName

    /// <summary>
    /// A madsrdf:Collection is an
    ///       organizational unit, members of which will have some form of intellectually unifying theme but
    ///       not to the extent that it defines an independent knowledge organization system. It aggregates
    ///       madsrdf:Authority descriptions or other madsrdf:MADSCollection resources.
    /// <see href="http://www.loc.gov/mads/rdf/v1#MADSCollection"></see></summary>
    let MADSCollection =
        Namespaced_IRI.parse _namespace_name "MADSCollection" |> NamespacedName

    /// <summary>
    /// A former
    ///       Authority.
    /// <see href="http://www.loc.gov/mads/rdf/v1#DeprecatedAuthority"></see></summary>
    let DeprecatedAuthority =
        Namespaced_IRI.parse _namespace_name "DeprecatedAuthority" |> NamespacedName

    /// <summary>
    /// Describes a resource whose
    ///       label is an inhabited place incorporated as a city, town, etc.
    /// <see href="http://www.loc.gov/mads/rdf/v1#City"></see></summary>
    let City = Namespaced_IRI.parse _namespace_name "City" |> NamespacedName

    /// <summary>
    /// Describes a resource whose
    ///       label is a smaller unit within a populated place, e.g., a neighborhood, park, or
    ///       street.
    /// <see href="http://www.loc.gov/mads/rdf/v1#CitySection"></see></summary>
    let CitySection =
        Namespaced_IRI.parse _namespace_name "CitySection" |> NamespacedName

    /// <summary>
    /// The label of a madsrdf:ComplexSubject is the concatenation of labels
    ///       from two or more madsrdf:SimpleType descriptions, except that the combination of
    ///       madsrdf:SimpleType labels for the madsrdf:ComplexSubject does not meet the conditions to be
    ///       the label of a madsrdf:NameTitle resource or madsrdf:HierarchicalGeographic
    ///       resource.
    /// <see href="http://www.loc.gov/mads/rdf/v1#ComplexSubject"></see></summary>
    let ComplexSubject =
        Namespaced_IRI.parse _namespace_name "ComplexSubject" |> NamespacedName

    /// <summary>
    /// madsrdf:ComplexType is a resource whose label is the concatenation
    ///       of labels from two or more Authority descriptions or two or more Variant descriptions or some
    ///       combination of Authority and Variant descriptions, each of a
    ///       madsrdf:SimpleType.
    /// <see href="http://www.loc.gov/mads/rdf/v1#ComplexType"></see></summary>
    let ComplexType =
        Namespaced_IRI.parse _namespace_name "ComplexType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#MADSType"></see>
    /// </summary>
    let MADSType = Namespaced_IRI.parse _namespace_name "MADSType" |> NamespacedName

    /// <summary>
    /// A madsrdf:HierarchicalGeographic indicates that its label is the
    ///       concatenation of labels from a sequence of madsrdf:Geographic types taken from one of the
    ///       madsrdf:Geographic sub-classes such as madsrdf:City, madsrdf:Country, madsrdf:State,
    ///       madsrdf:Region, madsrdf:Area, etc. The madsrdf:Geographic resources that constitute the
    ///       madsrdf:HierarchicalGeographic should have a broader to narrower hierarchical relationship
    ///       between them.
    /// <see href="http://www.loc.gov/mads/rdf/v1#HierarchicalGeographic"></see></summary>
    let HierarchicalGeographic =
        Namespaced_IRI.parse _namespace_name "HierarchicalGeographic" |> NamespacedName

    /// <summary>
    /// The label of a madsrdf:NameTitle resource is the concatenation of a
    ///       label of a madsrdf:Name description and the label of a madsrdf:Title description. Both
    ///       description types (madsrdf:Name and madsrdf:Title) are of madsrdf:SimpleType
    ///       types.
    /// <see href="http://www.loc.gov/mads/rdf/v1#NameTitle"></see></summary>
    let NameTitle = Namespaced_IRI.parse _namespace_name "NameTitle" |> NamespacedName
    /// <summary>
    /// madsrdf:SimpleType is a resource with a label constituting a single
    ///       word or phrase.
    /// <see href="http://www.loc.gov/mads/rdf/v1#SimpleType"></see></summary>
    let SimpleType = Namespaced_IRI.parse _namespace_name "SimpleType" |> NamespacedName

    /// <summary>
    /// madsrdf:componentList
    ///       organizes the madsrdf:SimpleType resources whose labels are represented in the label of the
    ///       associated madsrdf:ComplexType resource.
    /// <see href="http://www.loc.gov/mads/rdf/v1#componentList"></see></summary>
    let componentList =
        Namespaced_IRI.parse _namespace_name "componentList" |> NamespacedName

    /// <summary>
    /// Describes a resource whose
    ///       label represents a conference name.
    /// <see href="http://www.loc.gov/mads/rdf/v1#ConferenceName"></see></summary>
    let ConferenceName =
        Namespaced_IRI.parse _namespace_name "ConferenceName" |> NamespacedName

    /// <summary>
    /// Describes a resource whose label represents a name, especially when
    ///       a more precise Name type (madsrdf:ConferenceName, masdrdf:FamilyName, etc.) cannot be
    ///       identified.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Name"></see></summary>
    let Name = Namespaced_IRI.parse _namespace_name "Name" |> NamespacedName
    /// <summary>
    /// Describes a resource whose
    ///       label is one of seven large landmasses on Earth. These are: Asia, Africa, Europe, North
    ///       America, South America, Australia, and Antarctica.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Continent"></see></summary>
    let Continent = Namespaced_IRI.parse _namespace_name "Continent" |> NamespacedName

    /// <summary>
    /// Describes a resource whose
    ///       label is the name of a corporate entity, which may include political or ecclesiastical
    ///       entities.
    /// <see href="http://www.loc.gov/mads/rdf/v1#CorporateName"></see></summary>
    let CorporateName =
        Namespaced_IRI.parse _namespace_name "CorporateName" |> NamespacedName

    /// <summary>
    /// Describes a resource whose
    ///       label is a country, i.e. a political entity considered a country.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Country"></see></summary>
    let Country = Namespaced_IRI.parse _namespace_name "Country" |> NamespacedName
    /// <summary>
    /// Describes a resource whose
    ///       label is the largest local administrative unit, e.g. Warwickshire, in a country, e.g.
    ///       England.
    /// <see href="http://www.loc.gov/mads/rdf/v1#County"></see></summary>
    let County = Namespaced_IRI.parse _namespace_name "County" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#DateNameElement"></see>
    /// </summary>
    let DateNameElement =
        Namespaced_IRI.parse _namespace_name "DateNameElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#NameElement"></see>
    /// </summary>
    let NameElement =
        Namespaced_IRI.parse _namespace_name "NameElement" |> NamespacedName

    /// <summary>
    /// madsrdf:Element types
    ///       describe the various parts of labels.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Element"></see></summary>
    let Element = Namespaced_IRI.parse _namespace_name "Element" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#elementValue"></see>
    /// </summary>
    let elementValue =
        Namespaced_IRI.parse _namespace_name "elementValue" |> NamespacedName

    /// <summary>
    /// Describes a resource whose
    ///       label is any extraterrestrial entity or space, including a solar system, a galaxy, a star
    ///       system, and a planet, including a geographic feature of an individual planet.
    /// <see href="http://www.loc.gov/mads/rdf/v1#ExtraterrestrialArea"></see></summary>
    let ExtraterrestrialArea =
        Namespaced_IRI.parse _namespace_name "ExtraterrestrialArea" |> NamespacedName

    /// <summary>
    /// Describes a resource whose
    ///       label represents a family name.
    /// <see href="http://www.loc.gov/mads/rdf/v1#FamilyName"></see></summary>
    let FamilyName = Namespaced_IRI.parse _namespace_name "FamilyName" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#FamilyNameElement"></see>
    /// </summary>
    let FamilyNameElement =
        Namespaced_IRI.parse _namespace_name "FamilyNameElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#FullNameElement"></see>
    /// </summary>
    let FullNameElement =
        Namespaced_IRI.parse _namespace_name "FullNameElement" |> NamespacedName

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
    let GenreForm = Namespaced_IRI.parse _namespace_name "GenreForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#GenreFormElement"></see>
    /// </summary>
    let GenreFormElement =
        Namespaced_IRI.parse _namespace_name "GenreFormElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#GeographicElement"></see>
    /// </summary>
    let GeographicElement =
        Namespaced_IRI.parse _namespace_name "GeographicElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#GivenNameElement"></see>
    /// </summary>
    let GivenNameElement =
        Namespaced_IRI.parse _namespace_name "GivenNameElement" |> NamespacedName

    /// <summary>
    /// A madsrdf:Identifier
    ///       resource describes an identifier by associating the identifier value with its type. To be used
    ///       to record identifiers for a resource in the absence of URIs.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Identifier"></see></summary>
    let Identifier = Namespaced_IRI.parse _namespace_name "Identifier" |> NamespacedName
    /// <summary>
    /// Describes a resource whose
    ///       label is a tract of land surrounded by water and smaller than a continent but is not itself a
    ///       separate country.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Island"></see></summary>
    let Island = Namespaced_IRI.parse _namespace_name "Island" |> NamespacedName
    /// <summary>
    /// Describes a resource whose label represents a
    ///       language.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Language"></see></summary>
    let Language = Namespaced_IRI.parse _namespace_name "Language" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#LanguageElement"></see>
    /// </summary>
    let LanguageElement =
        Namespaced_IRI.parse _namespace_name "LanguageElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#MainTitleElement"></see>
    /// </summary>
    let MainTitleElement =
        Namespaced_IRI.parse _namespace_name "MainTitleElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#TitleElement"></see>
    /// </summary>
    let TitleElement =
        Namespaced_IRI.parse _namespace_name "TitleElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#NonSortElement"></see>
    /// </summary>
    let NonSortElement =
        Namespaced_IRI.parse _namespace_name "NonSortElement" |> NamespacedName

    /// <summary>
    /// Describes a resource whose
    ///       label represents an occcupation.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Occupation"></see></summary>
    let Occupation = Namespaced_IRI.parse _namespace_name "Occupation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#PartNameElement"></see>
    /// </summary>
    let PartNameElement =
        Namespaced_IRI.parse _namespace_name "PartNameElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#PartNumberElement"></see>
    /// </summary>
    let PartNumberElement =
        Namespaced_IRI.parse _namespace_name "PartNumberElement" |> NamespacedName

    /// <summary>
    /// Describes a resource whose
    ///       label represents a personal name.
    /// <see href="http://www.loc.gov/mads/rdf/v1#PersonalName"></see></summary>
    let PersonalName =
        Namespaced_IRI.parse _namespace_name "PersonalName" |> NamespacedName

    /// <summary>
    /// Describes a resource whose
    ///       label is a first order political division, e.g. Ontario, within a country, e.g. Canada.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Province"></see></summary>
    let Province = Namespaced_IRI.parse _namespace_name "Province" |> NamespacedName
    /// <summary>
    /// A madsrdf:RWO is an
    ///       abstract entity and identifies a Real World Object (RWO) identified by the label of a
    ///       madsrdf:Authority or madsrdf:DeprecatedAuthority.
    /// <see href="http://www.loc.gov/mads/rdf/v1#RWO"></see></summary>
    let RWO = Namespaced_IRI.parse _namespace_name "RWO" |> NamespacedName
    /// <summary>
    /// Describes a resource whose
    ///       label is an area that has the status of a jurisdiction, usually incorporating more than one
    ///       first level jurisdiction.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Region"></see></summary>
    let Region = Namespaced_IRI.parse _namespace_name "Region" |> NamespacedName
    /// <summary>
    /// A resource that represents
    ///       the source of information about another resource. madsrdf:Source is a type of
    ///       citation.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Source"></see></summary>
    let Source = Namespaced_IRI.parse _namespace_name "Source" |> NamespacedName
    /// <summary>
    /// Describes a resource whose
    ///       label is a first order political division, e.g. Montana, within a country, e.g.
    ///       U.S.
    /// <see href="http://www.loc.gov/mads/rdf/v1#State"></see></summary>
    let State = Namespaced_IRI.parse _namespace_name "State" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#SubTitleElement"></see>
    /// </summary>
    let SubTitleElement =
        Namespaced_IRI.parse _namespace_name "SubTitleElement" |> NamespacedName

    /// <summary>
    /// Describes a resource whose
    ///       label represents a time-based notion.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Temporal"></see></summary>
    let Temporal = Namespaced_IRI.parse _namespace_name "Temporal" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#TemporalElement"></see>
    /// </summary>
    let TemporalElement =
        Namespaced_IRI.parse _namespace_name "TemporalElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#TermsOfAddressNameElement"></see>
    /// </summary>
    let TermsOfAddressNameElement =
        Namespaced_IRI.parse _namespace_name "TermsOfAddressNameElement" |> NamespacedName

    /// <summary>
    /// Describes a resource whose
    ///       label is a geographical area belonging to or under the jurisdiction of a governmental
    ///       authority.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Territory"></see></summary>
    let Territory = Namespaced_IRI.parse _namespace_name "Territory" |> NamespacedName
    /// <summary>
    /// Describes a resource whose
    ///       label represents a title.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Title"></see></summary>
    let Title = Namespaced_IRI.parse _namespace_name "Title" |> NamespacedName
    /// <summary>
    /// Describes a resource whose
    ///       label represents a topic.
    /// <see href="http://www.loc.gov/mads/rdf/v1#Topic"></see></summary>
    let Topic = Namespaced_IRI.parse _namespace_name "Topic" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#TopicElement"></see>
    /// </summary>
    let TopicElement =
        Namespaced_IRI.parse _namespace_name "TopicElement" |> NamespacedName

    /// <summary>
    /// Latest date in a period of activity.
    ///
    /// <see href="http://www.loc.gov/mads/rdf/v1#activityEndDate"></see></summary>
    let activityEndDate =
        Namespaced_IRI.parse _namespace_name "activityEndDate" |> NamespacedName

    /// <summary>
    /// Earliest date in a period of activity.
    ///
    /// <see href="http://www.loc.gov/mads/rdf/v1#activityStartDate"></see></summary>
    let activityStartDate =
        Namespaced_IRI.parse _namespace_name "activityStartDate" |> NamespacedName

    /// <summary>
    /// This relates an Authority or Variant to its administrative metadata,
    ///       which is, minimimally, a Class defined outside of the MADS/RDF namespace. The RecordInfo Class
    ///       from the RecordInfo ontology is recommended.
    /// <see href="http://www.loc.gov/mads/rdf/v1#adminMetadata"></see></summary>
    let adminMetadata =
        Namespaced_IRI.parse _namespace_name "adminMetadata" |> NamespacedName

    /// <summary>
    /// The date an individual
    ///       ceased to be affiliated with an organization.
    /// <see href="http://www.loc.gov/mads/rdf/v1#affiliationEnd"></see></summary>
    let affiliationEnd =
        Namespaced_IRI.parse _namespace_name "affiliationEnd" |> NamespacedName

    /// <summary>
    /// The date an individual
    ///       established an affiliation with an organization.
    /// <see href="http://www.loc.gov/mads/rdf/v1#affiliationStart"></see></summary>
    let affiliationStart =
        Namespaced_IRI.parse _namespace_name "affiliationStart" |> NamespacedName

    /// <summary>
    /// Language that a person,
    ///       organization, or family uses for publication, communication, etc., or in which a work is
    ///       expressed.
    /// <see href="http://www.loc.gov/mads/rdf/v1#associatedLanguage"></see></summary>
    let associatedLanguage =
        Namespaced_IRI.parse _namespace_name "associatedLanguage" |> NamespacedName

    /// <summary>
    /// A town, city, province,
    ///       state, and/or country associated with persons, corporate bodies, families, works, and
    ///       expressions.
    /// <see href="http://www.loc.gov/mads/rdf/v1#associatedLocale"></see></summary>
    let associatedLocale =
        Namespaced_IRI.parse _namespace_name "associatedLocale" |> NamespacedName

    /// <summary>
    /// A lexical string representing a controlled, curated label for the
    ///       Authority.
    /// <see href="http://www.loc.gov/mads/rdf/v1#authoritativeLabel"></see></summary>
    let authoritativeLabel =
        Namespaced_IRI.parse _namespace_name "authoritativeLabel" |> NamespacedName

    /// <summary>
    /// The year a person was born.
    ///       Date of birth may also include the month and day of the person’s birth. (RDA
    ///       9.3.2.1)
    /// <see href="http://www.loc.gov/mads/rdf/v1#birthDate"></see></summary>
    let birthDate = Namespaced_IRI.parse _namespace_name "birthDate" |> NamespacedName
    /// <summary>
    /// The town, city, province,
    ///       state, and/or country in which a person was born.
    /// <see href="http://www.loc.gov/mads/rdf/v1#birthPlace"></see></summary>
    let birthPlace = Namespaced_IRI.parse _namespace_name "birthPlace" |> NamespacedName
    /// <summary>
    /// A note detailing a modification to an Authority or
    ///       Variant.
    /// <see href="http://www.loc.gov/mads/rdf/v1#changeNote"></see></summary>
    let changeNote = Namespaced_IRI.parse _namespace_name "changeNote" |> NamespacedName
    /// <summary>
    /// A note about the
    ///       resource.
    /// <see href="http://www.loc.gov/mads/rdf/v1#note"></see></summary>
    let note = Namespaced_IRI.parse _namespace_name "note" |> NamespacedName

    /// <summary>
    /// A note about how the madsrdf:Source relates to the resource about
    ///       which the madsrdf:Source is the information source.
    /// <see href="http://www.loc.gov/mads/rdf/v1#citationNote"></see></summary>
    let citationNote =
        Namespaced_IRI.parse _namespace_name "citationNote" |> NamespacedName

    /// <summary>
    /// The cited resource.
    /// <see href="http://www.loc.gov/mads/rdf/v1#citationSource"></see></summary>
    let citationSource =
        Namespaced_IRI.parse _namespace_name "citationSource" |> NamespacedName

    /// <summary>
    /// Should use a standard term - such as 'found' or 'not found' - to
    ///       indicate whether the cited resource yielded information about the resource related to the
    ///       madsrdf:Source.
    /// <see href="http://www.loc.gov/mads/rdf/v1#citationStatus"></see></summary>
    let citationStatus =
        Namespaced_IRI.parse _namespace_name "citationStatus" |> NamespacedName

    /// <summary>
    /// The city component of an address.
    /// <see href="http://www.loc.gov/mads/rdf/v1#city"></see></summary>
    let city = Namespaced_IRI.parse _namespace_name "city" |> NamespacedName

    /// <summary>
    /// The classification code associated with a
    ///       madsrdf:Authority.
    /// <see href="http://www.loc.gov/mads/rdf/v1#classification"></see></summary>
    let classification =
        Namespaced_IRI.parse _namespace_name "classification" |> NamespacedName

    /// <summary>
    /// A code is a string of
    ///       characters associated with a the authoritative or deprecated label. It may record an
    ///       historical notation once used to uniquely identify a concept.
    /// <see href="http://www.loc.gov/mads/rdf/v1#code"></see></summary>
    let code = Namespaced_IRI.parse _namespace_name "code" |> NamespacedName
    /// <summary>
    /// Country associated with an
    ///       address.
    /// <see href="http://www.loc.gov/mads/rdf/v1#country"></see></summary>
    let country = Namespaced_IRI.parse _namespace_name "country" |> NamespacedName

    /// <summary>
    /// Ending date of the date range for which the beginning date is recorded in madsrdf:creationDateStart.
    /// <see href="http://www.loc.gov/mads/rdf/v1#creationDateEnd"></see></summary>
    let creationDateEnd =
        Namespaced_IRI.parse _namespace_name "creationDateEnd" |> NamespacedName

    /// <summary>
    /// For a work, earliest date (normally the year) associated with a work; that date may be the date the work was created or first published or released. For an expression, the earliest date (normally the year) associated with an expression; that date may be the date of the earliest known manifestation of that expression. In both cases the date may be the starting date of a range or a single date.
    /// <see href="http://www.loc.gov/mads/rdf/v1#creationDateStart"></see></summary>
    let creationDateStart =
        Namespaced_IRI.parse _namespace_name "creationDateStart" |> NamespacedName

    /// <summary>
    /// The year a person died.
    ///       Date of death may also include the month and day of the person’s death. (RDA
    ///       9.3.3.1)
    /// <see href="http://www.loc.gov/mads/rdf/v1#deathDate"></see></summary>
    let deathDate = Namespaced_IRI.parse _namespace_name "deathDate" |> NamespacedName
    /// <summary>
    /// The town, city, province,
    ///       state, and/or country in which a person died.
    /// <see href="http://www.loc.gov/mads/rdf/v1#deathPlace"></see></summary>
    let deathPlace = Namespaced_IRI.parse _namespace_name "deathPlace" |> NamespacedName

    /// <summary>
    /// An explanation of the meaning of an Authority, DeprecatedAuthority,
    ///       or Variant description.
    /// <see href="http://www.loc.gov/mads/rdf/v1#definitionNote"></see></summary>
    let definitionNote =
        Namespaced_IRI.parse _namespace_name "definitionNote" |> NamespacedName

    /// <summary>
    /// A note pertaining to the
    ///       deletion of a resource.
    /// <see href="http://www.loc.gov/mads/rdf/v1#deletionNote"></see></summary>
    let deletionNote =
        Namespaced_IRI.parse _namespace_name "deletionNote" |> NamespacedName

    /// <summary>
    /// A label once considered
    ///       authoritative (controlled and curated) but which is no longer.
    /// <see href="http://www.loc.gov/mads/rdf/v1#deprecatedLabel"></see></summary>
    let deprecatedLabel =
        Namespaced_IRI.parse _namespace_name "deprecatedLabel" |> NamespacedName

    /// <summary>
    /// A note pertaining to the
    ///       management of the label associated with the resource.
    /// <see href="http://www.loc.gov/mads/rdf/v1#editorialNote"></see></summary>
    let editorialNote =
        Namespaced_IRI.parse _namespace_name "editorialNote" |> NamespacedName

    /// <summary>
    /// The madsrdf:elementList property is used to organize the various
    ///       parts of labels.
    /// <see href="http://www.loc.gov/mads/rdf/v1#elementList"></see></summary>
    let elementList =
        Namespaced_IRI.parse _namespace_name "elementList" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#email"></see>
    /// </summary>
    let email = Namespaced_IRI.parse _namespace_name "email" |> NamespacedName

    /// <summary>
    /// Any attribute that serves
    ///       to characterize a person, family or corporate body or that may be needed for differentiation
    ///       from other persons. families or corporate bodies and for which separate content designation is
    ///       not already defined.Or
    /// <see href="http://www.loc.gov/mads/rdf/v1#entityDescriptor"></see></summary>
    let entityDescriptor =
        Namespaced_IRI.parse _namespace_name "entityDescriptor" |> NamespacedName

    /// <summary>
    /// The year a corporate body was established. Date of establishment may also include the month and day of the corporate body’s establishment.
    ///
    /// <see href="http://www.loc.gov/mads/rdf/v1#establishDate"></see></summary>
    let establishDate =
        Namespaced_IRI.parse _namespace_name "establishDate" |> NamespacedName

    /// <summary>
    /// A example of how the
    ///       resource might be used.
    /// <see href="http://www.loc.gov/mads/rdf/v1#exampleNote"></see></summary>
    let exampleNote =
        Namespaced_IRI.parse _namespace_name "exampleNote" |> NamespacedName

    /// <summary>
    /// The second address line, if
    ///       needed.
    /// <see href="http://www.loc.gov/mads/rdf/v1#extendedAddress"></see></summary>
    let extendedAddress =
        Namespaced_IRI.parse _namespace_name "extendedAddress" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#extension"></see>
    /// </summary>
    let extension = Namespaced_IRI.parse _namespace_name "extension" |> NamespacedName
    /// <summary>
    /// Fax number
    /// <see href="http://www.loc.gov/mads/rdf/v1#fax"></see></summary>
    let fax = Namespaced_IRI.parse _namespace_name "fax" |> NamespacedName

    /// <summary>
    /// The field of activity
    ///       associated with an individual.
    /// <see href="http://www.loc.gov/mads/rdf/v1#fieldOfActivity"></see></summary>
    let fieldOfActivity =
        Namespaced_IRI.parse _namespace_name "fieldOfActivity" |> NamespacedName

    /// <summary>
    /// Full form of name needed to
    ///       distinguish a person from another person with the same preferred name.
    /// <see href="http://www.loc.gov/mads/rdf/v1#fullerName"></see></summary>
    let fullerName = Namespaced_IRI.parse _namespace_name "fullerName" |> NamespacedName
    /// <summary>
    /// The gender with which a
    ///       person identifies.
    /// <see href="http://www.loc.gov/mads/rdf/v1#gender"></see></summary>
    let gender = Namespaced_IRI.parse _namespace_name "gender" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#hasAbbreviationVariant"></see>
    /// </summary>
    let hasAbbreviationVariant =
        Namespaced_IRI.parse _namespace_name "hasAbbreviationVariant" |> NamespacedName

    /// <summary>
    /// Associates a Variant with an Authority or Deprecrated Authority.
    ///       Unless the variant type can be more specifically identified, use 'hasVariant.'
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasVariant"></see></summary>
    let hasVariant = Namespaced_IRI.parse _namespace_name "hasVariant" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#hasAcronymVariant"></see>
    /// </summary>
    let hasAcronymVariant =
        Namespaced_IRI.parse _namespace_name "hasAcronymVariant" |> NamespacedName

    /// <summary>
    /// Property to associate an
    ///       individual, such as a foaf:Agent, to a group or organization with which an individual is or
    ///       has been affiliated.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasAffiliation"></see></summary>
    let hasAffiliation =
        Namespaced_IRI.parse _namespace_name "hasAffiliation" |> NamespacedName

    /// <summary>
    /// The address of the group or
    ///       organization with which an individual is associated.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasAffiliationAddress"></see></summary>
    let hasAffiliationAddress =
        Namespaced_IRI.parse _namespace_name "hasAffiliationAddress" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#hasBroaderAuthority"></see>
    /// </summary>
    let hasBroaderAuthority =
        Namespaced_IRI.parse _namespace_name "hasBroaderAuthority" |> NamespacedName

    /// <summary>
    /// Unless the relationship can be more specifically identified, use
    ///       'hasRelatedAuthority.'
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasRelatedAuthority"></see></summary>
    let hasRelatedAuthority =
        Namespaced_IRI.parse _namespace_name "hasRelatedAuthority" |> NamespacedName

    /// <summary>
    /// Creates a direct
    ///       relationship between an Authority and one that is more narrowly defined.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasNarrowerAuthority"></see></summary>
    let hasNarrowerAuthority =
        Namespaced_IRI.parse _namespace_name "hasNarrowerAuthority" |> NamespacedName

    /// <summary>
    /// Creates a direct
    ///       relationship between an Authority and a more broadly defined Authority from a different MADS
    ///       Scheme.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasBroaderExternalAuthority"></see></summary>
    let hasBroaderExternalAuthority =
        Namespaced_IRI.parse _namespace_name "hasBroaderExternalAuthority" |> NamespacedName

    /// <summary>
    /// A term that specifies a characteristic that differentiates a work or expression from another one.
    ///
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasChararacteristic"></see></summary>
    let hasChararacteristic =
        Namespaced_IRI.parse _namespace_name "hasChararacteristic" |> NamespacedName

    /// <summary>
    /// Records a relationship
    ///       between an Authority and one that is closely related from a different MADS
    ///       Scheme.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasCloseExternalAuthority"></see></summary>
    let hasCloseExternalAuthority =
        Namespaced_IRI.parse _namespace_name "hasCloseExternalAuthority" |> NamespacedName

    /// <summary>
    /// Establishes a relationship
    ///       between a CorporateName Authority and one of the same that is more broadly
    ///       defined.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasCorporateParentAuthority"></see></summary>
    let hasCorporateParentAuthority =
        Namespaced_IRI.parse _namespace_name "hasCorporateParentAuthority" |> NamespacedName

    /// <summary>
    /// Establishes a relationship
    ///       between a CorporateName Authority and one of the same that is more narrowly
    ///       defined.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasCorporateSubsidiaryAuthority"></see></summary>
    let hasCorporateSubsidiaryAuthority =
        Namespaced_IRI.parse _namespace_name "hasCorporateSubsidiaryAuthority" |> NamespacedName

    /// <summary>
    /// Used to reference a resource that was an earlier form. This is
    ///       Related type='earlier' in MADS XML.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasEarlierEstablishedForm"></see></summary>
    let hasEarlierEstablishedForm =
        Namespaced_IRI.parse _namespace_name "hasEarlierEstablishedForm" |> NamespacedName

    /// <summary>
    /// Denotes a relationship
    ///       between an Authority and/or DeprecatedAuthority. The relationship may or may or may not be
    ///       reciprocated and there is no certainty that the related resource will further illuminate the
    ///       original resource.
    /// <see href="http://www.loc.gov/mads/rdf/v1#see"></see></summary>
    let see = Namespaced_IRI.parse _namespace_name "see" |> NamespacedName

    /// <summary>
    /// Use to reference the later form of a resource. This is Related
    ///       type='later' in MADS XML.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasLaterEstablishedForm"></see></summary>
    let hasLaterEstablishedForm =
        Namespaced_IRI.parse _namespace_name "hasLaterEstablishedForm" |> NamespacedName

    /// <summary>
    /// Records a relationship
    ///       between an Authority and one to which it matches exactly but from a different MADS
    ///       Scheme.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasExactExternalAuthority"></see></summary>
    let hasExactExternalAuthority =
        Namespaced_IRI.parse _namespace_name "hasExactExternalAuthority" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#hasExpansionVariant"></see>
    /// </summary>
    let hasExpansionVariant =
        Namespaced_IRI.parse _namespace_name "hasExpansionVariant" |> NamespacedName

    /// <summary>
    /// Use for variants that are searchable, but not necessarily for
    ///       display.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasHiddenVariant"></see></summary>
    let hasHiddenVariant =
        Namespaced_IRI.parse _namespace_name "hasHiddenVariant" |> NamespacedName

    /// <summary>
    /// Associates a resource with
    ///       a madsrdf:Identifier.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasIdentifier"></see></summary>
    let hasIdentifier =
        Namespaced_IRI.parse _namespace_name "hasIdentifier" |> NamespacedName

    /// <summary>
    /// Associates an Authority or other Collection with a
    ///       madsrdf:MADSCollection.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasMADSCollectionMember"></see></summary>
    let hasMADSCollectionMember =
        Namespaced_IRI.parse _namespace_name "hasMADSCollectionMember" |> NamespacedName

    /// <summary>
    /// Associates a Collection with a madsrdf:Authority or another
    ///       madsrdf:MADSCollection.
    /// <see href="http://www.loc.gov/mads/rdf/v1#isMemberOfMADSCollection"></see></summary>
    let isMemberOfMADSCollection =
        Namespaced_IRI.parse _namespace_name "isMemberOfMADSCollection" |> NamespacedName

    /// <summary>
    /// Associates an Authority or Collection with a
    ///       madsrdf:MADSScheme.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasMADSSchemeMember"></see></summary>
    let hasMADSSchemeMember =
        Namespaced_IRI.parse _namespace_name "hasMADSSchemeMember" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#isMemberOfMADSScheme"></see>
    /// </summary>
    let isMemberOfMADSScheme =
        Namespaced_IRI.parse _namespace_name "isMemberOfMADSScheme" |> NamespacedName

    /// <summary>
    /// Creates a direct
    ///       relationship between an Authority and a more narrowly defined Authority from a different MADS
    ///       Scheme.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasNarrowerExternalAuthority"></see></summary>
    let hasNarrowerExternalAuthority =
        Namespaced_IRI.parse _namespace_name "hasNarrowerExternalAuthority" |> NamespacedName

    /// <summary>
    /// Establishes a relationship between two Authority resources. It is
    ///       reciprocal, so the relationship must be shared. This is Related type='equivalent' in MADS
    ///       XML.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasReciprocalAuthority"></see></summary>
    let hasReciprocalAuthority =
        Namespaced_IRI.parse _namespace_name "hasReciprocalAuthority" |> NamespacedName

    /// <summary>
    /// Establishes a relationship
    ///       between an Authority and one from a different MADS Scheme. It is reciprocal, so the
    ///       relationship must be shared.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasReciprocalExternalAuthority"></see></summary>
    let hasReciprocalExternalAuthority =
        Namespaced_IRI.parse _namespace_name "hasReciprocalExternalAuthority" |> NamespacedName

    /// <summary>
    /// Associates a resource description with its Source.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasSource"></see></summary>
    let hasSource = Namespaced_IRI.parse _namespace_name "hasSource" |> NamespacedName

    /// <summary>
    /// Identifies an Authority
    ///       that is at the top of the hierarchy of authorities within the MADS Scheme.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasTopMemberOfMADSScheme"></see></summary>
    let hasTopMemberOfMADSScheme =
        Namespaced_IRI.parse _namespace_name "hasTopMemberOfMADSScheme" |> NamespacedName

    /// <summary>
    /// A Variant whose label
    ///       represents a translation of that of the authoritative label.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hasTranslationVariant"></see></summary>
    let hasTranslationVariant =
        Namespaced_IRI.parse _namespace_name "hasTranslationVariant" |> NamespacedName

    /// <summary>
    /// A label entered for
    ///       discovery purposes but not shown.
    /// <see href="http://www.loc.gov/mads/rdf/v1#hiddenLabel"></see></summary>
    let hiddenLabel =
        Namespaced_IRI.parse _namespace_name "hiddenLabel" |> NamespacedName

    /// <summary>
    /// A note pertaining to the
    ///       history of the resource.
    /// <see href="http://www.loc.gov/mads/rdf/v1#historyNote"></see></summary>
    let historyNote =
        Namespaced_IRI.parse _namespace_name "historyNote" |> NamespacedName

    /// <summary>
    /// Designation indicative of
    ///       royalty, nobility, or ecclesiastical rank or office, or a term of address for a person of
    ///       religious vocation.
    /// <see href="http://www.loc.gov/mads/rdf/v1#honoraryTitle"></see></summary>
    let honoraryTitle =
        Namespaced_IRI.parse _namespace_name "honoraryTitle" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#hours"></see>
    /// </summary>
    let hours = Namespaced_IRI.parse _namespace_name "hours" |> NamespacedName
    /// <summary>
    /// The scheme associated with
    ///       the identifier. For example, "LCCN" would be used when the Identifier Value (madsrdf:idValue)
    ///       is a LC Control Number.
    /// <see href="http://www.loc.gov/mads/rdf/v1#idScheme"></see></summary>
    let idScheme = Namespaced_IRI.parse _namespace_name "idScheme" |> NamespacedName
    /// <summary>
    /// The value of the identifier
    ///       conforming to the Identifier Scheme syntax.
    /// <see href="http://www.loc.gov/mads/rdf/v1#idValue"></see></summary>
    let idValue = Namespaced_IRI.parse _namespace_name "idValue" |> NamespacedName

    /// <summary>
    /// Associates a
    ///       madsrdf:Authority with the Real World Object that is the subject of the authority's
    ///       label.
    /// <see href="http://www.loc.gov/mads/rdf/v1#identifiesRWO"></see></summary>
    let identifiesRWO =
        Namespaced_IRI.parse _namespace_name "identifiesRWO" |> NamespacedName

    /// <summary>
    /// Associates a Real World
    ///       Object with its Authority description.
    /// <see href="http://www.loc.gov/mads/rdf/v1#isIdentifiedByAuthority"></see></summary>
    let isIdentifiedByAuthority =
        Namespaced_IRI.parse _namespace_name "isIdentifiedByAuthority" |> NamespacedName

    /// <summary>
    /// Identifies a MADS Scheme in
    ///       which the Authority is at the top of the hierarchy.
    /// <see href="http://www.loc.gov/mads/rdf/v1#isTopMemberOfMADSScheme"></see></summary>
    let isTopMemberOfMADSScheme =
        Namespaced_IRI.parse _namespace_name "isTopMemberOfMADSScheme" |> NamespacedName

    /// <summary>
    /// Records the individual's
    ///       role or position in the organization with which the individual is affiliated. A "job title"
    ///       might be appropriate.
    /// <see href="http://www.loc.gov/mads/rdf/v1#natureOfAffiliation"></see></summary>
    let natureOfAffiliation =
        Namespaced_IRI.parse _namespace_name "natureOfAffiliation" |> NamespacedName

    /// <summary>
    /// A profession or occupation
    ///       in which the person works or has worked.
    /// <see href="http://www.loc.gov/mads/rdf/v1#occupation"></see></summary>
    let occupation = Namespaced_IRI.parse _namespace_name "occupation" |> NamespacedName

    /// <summary>
    /// The group or organization
    ///       with which an individual is associated.
    /// <see href="http://www.loc.gov/mads/rdf/v1#organization"></see></summary>
    let organization =
        Namespaced_IRI.parse _namespace_name "organization" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#phone"></see>
    /// </summary>
    let phone = Namespaced_IRI.parse _namespace_name "phone" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#postcode"></see>
    /// </summary>
    let postcode = Namespaced_IRI.parse _namespace_name "postcode" |> NamespacedName

    /// <summary>
    /// A well-known individual who
    ///       is a member of the family.
    /// <see href="http://www.loc.gov/mads/rdf/v1#prominentFamilyMember"></see></summary>
    let prominentFamilyMember =
        Namespaced_IRI.parse _namespace_name "prominentFamilyMember" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loc.gov/mads/rdf/v1#scopeNote"></see>
    /// </summary>
    let scopeNote = Namespaced_IRI.parse _namespace_name "scopeNote" |> NamespacedName
    /// <summary>
    /// The state associated with
    ///       an address.
    /// <see href="http://www.loc.gov/mads/rdf/v1#state"></see></summary>
    let state = Namespaced_IRI.parse _namespace_name "state" |> NamespacedName

    /// <summary>
    /// First line of address. For
    ///       second line, use madsrdf:extendedAddress.
    /// <see href="http://www.loc.gov/mads/rdf/v1#streetAddress"></see></summary>
    let streetAddress =
        Namespaced_IRI.parse _namespace_name "streetAddress" |> NamespacedName

    /// <summary>
    /// The year a corporate body was terminated. Date of termination may also include the month and day of the corporate body’s termination.
    ///
    /// <see href="http://www.loc.gov/mads/rdf/v1#terminateDate"></see></summary>
    let terminateDate =
        Namespaced_IRI.parse _namespace_name "terminateDate" |> NamespacedName

    /// <summary>
    /// "Use [This Resource] For."
    ///       Traditional "USE FOR" reference.
    /// <see href="http://www.loc.gov/mads/rdf/v1#useFor"></see></summary>
    let useFor = Namespaced_IRI.parse _namespace_name "useFor" |> NamespacedName
    /// <summary>
    /// "Use [This Other Resource]
    ///       Instead." Traditional "USE" reference.
    /// <see href="http://www.loc.gov/mads/rdf/v1#useInstead"></see></summary>
    let useInstead = Namespaced_IRI.parse _namespace_name "useInstead" |> NamespacedName

    /// <summary>
    /// The lexical, variant form
    ///       of an authoritative label.
    /// <see href="http://www.loc.gov/mads/rdf/v1#variantLabel"></see></summary>
    let variantLabel =
        Namespaced_IRI.parse _namespace_name "variantLabel" |> NamespacedName

    /// <summary>
    /// The country or other territorial jurisdiction from which a work originated.
    /// <see href="http://www.loc.gov/mads/rdf/v1#workOrigin"></see></summary>
    let workOrigin = Namespaced_IRI.parse _namespace_name "workOrigin" |> NamespacedName

#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module mads =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.loc.gov/mads/rdf/v1#" "mads"
    /// <summary>
    ///   <para>rdfs:label : Address</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#Address">mads:Address</a>
    /// </summary>
    let Address = _prefixId.prefix "Address"
    /// <summary>
    ///   <para>rdfs:label : Affiliation</para>
    ///   <para>rdfs:comment : A resource that describes an individual's affiliation with an
    ///       organization or group, such as the nature of the affiliation and the active
    ///       dates.</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#Affiliation">mads:Affiliation</a>
    /// </summary>
    let Affiliation = _prefixId.prefix "Affiliation"
    /// <summary>
    ///   <para>rdfs:label : Area Type</para>
    ///   <para>rdfs:comment : Describes a resource whose
    ///       label is a non-jurisdictional geographic entity.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#Area">mads:Area</a>
    /// </summary>
    let Area = _prefixId.prefix "Area"
    /// <summary>
    ///   <para>rdfs:label : Authority</para>
    ///   <para>rdfs:comment : A concept with a controlled
    ///       label.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#Authority">mads:Authority</a>
    /// </summary>
    let Authority = _prefixId.prefix "Authority"
    /// <summary>
    ///   <para>rdfs:label : City Type</para>
    ///   <para>rdfs:comment : Describes a resource whose
    ///       label is an inhabited place incorporated as a city, town, etc.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#City">mads:City</a>
    /// </summary>
    let City = _prefixId.prefix "City"
    /// <summary>
    ///   <para>rdfs:label : City Section Type</para>
    ///   <para>rdfs:comment : Describes a resource whose
    ///       label is a smaller unit within a populated place, e.g., a neighborhood, park, or
    ///       street.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#CitySection">mads:CitySection</a>
    /// </summary>
    let CitySection = _prefixId.prefix "CitySection"
    /// <summary>
    ///   <para>rdfs:label : Complex Subject Type</para>
    ///   <para>rdfs:comment : The label of a madsrdf:ComplexSubject is the concatenation of labels
    ///       from two or more madsrdf:SimpleType descriptions, except that the combination of
    ///       madsrdf:SimpleType labels for the madsrdf:ComplexSubject does not meet the conditions to be
    ///       the label of a madsrdf:NameTitle resource or madsrdf:HierarchicalGeographic
    ///       resource.</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#ComplexSubject">mads:ComplexSubject</a>
    /// </summary>
    let ComplexSubject = _prefixId.prefix "ComplexSubject"
    /// <summary>
    ///   <para>rdfs:label : Complex Type</para>
    ///   <para>rdfs:comment : madsrdf:ComplexType is a resource whose label is the concatenation
    ///       of labels from two or more Authority descriptions or two or more Variant descriptions or some
    ///       combination of Authority and Variant descriptions, each of a
    ///       madsrdf:SimpleType.</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#ComplexType">mads:ComplexType</a>
    /// </summary>
    let ComplexType = _prefixId.prefix "ComplexType"
    /// <summary>
    ///   <para>rdfs:label : Conference Name Type</para>
    ///   <para>rdfs:comment : Describes a resource whose
    ///       label represents a conference name.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#ConferenceName">mads:ConferenceName</a>
    /// </summary>
    let ConferenceName = _prefixId.prefix "ConferenceName"
    /// <summary>
    ///   <para>rdfs:label : Continent Type</para>
    ///   <para>rdfs:comment : Describes a resource whose
    ///       label is one of seven large landmasses on Earth. These are: Asia, Africa, Europe, North
    ///       America, South America, Australia, and Antarctica.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#Continent">mads:Continent</a>
    /// </summary>
    let Continent = _prefixId.prefix "Continent"
    /// <summary>
    ///   <para>rdfs:label : Corporate Name Type</para>
    ///   <para>rdfs:comment : Describes a resource whose
    ///       label is the name of a corporate entity, which may include political or ecclesiastical
    ///       entities.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#CorporateName">mads:CorporateName</a>
    /// </summary>
    let CorporateName = _prefixId.prefix "CorporateName"
    /// <summary>
    ///   <para>rdfs:label : Country Type</para>
    ///   <para>rdfs:comment : Describes a resource whose
    ///       label is a country, i.e. a political entity considered a country. ^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#Country">mads:Country</a>
    /// </summary>
    let Country = _prefixId.prefix "Country"
    /// <summary>
    ///   <para>rdfs:label : County Type</para>
    ///   <para>rdfs:comment : Describes a resource whose
    ///       label is the largest local administrative unit, e.g. Warwickshire, in a country, e.g.
    ///       England.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#County">mads:County</a>
    /// </summary>
    let County = _prefixId.prefix "County"
    /// <summary>
    ///   <para>rdfs:label : Date Name
    ///       Element^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#DateNameElement">mads:DateNameElement</a>
    /// </summary>
    let DateNameElement = _prefixId.prefix "DateNameElement"
    /// <summary>
    ///   <para>rdfs:label : Deprecated
    ///       Authority^^xsd:string</para>
    ///   <para>rdfs:comment : A former
    ///       Authority.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#DeprecatedAuthority">mads:DeprecatedAuthority</a>
    /// </summary>
    let DeprecatedAuthority = _prefixId.prefix "DeprecatedAuthority"
    /// <summary>
    ///   <para>rdfs:label : Element</para>
    ///   <para>rdfs:comment : madsrdf:Element types
    ///       describe the various parts of labels.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#Element">mads:Element</a>
    /// </summary>
    let Element = _prefixId.prefix "Element"
    /// <summary>
    ///   <para>rdfs:label : Extraterrestrial Area Type</para>
    ///   <para>rdfs:comment : Describes a resource whose
    ///       label is any extraterrestrial entity or space, including a solar system, a galaxy, a star
    ///       system, and a planet, including a geographic feature of an individual planet.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#ExtraterrestrialArea">mads:ExtraterrestrialArea</a>
    /// </summary>
    let ExtraterrestrialArea = _prefixId.prefix "ExtraterrestrialArea"
    /// <summary>
    ///   <para>rdfs:label : Family Name Type</para>
    ///   <para>rdfs:comment : Describes a resource whose
    ///       label represents a family name.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#FamilyName">mads:FamilyName</a>
    /// </summary>
    let FamilyName = _prefixId.prefix "FamilyName"
    /// <summary>
    ///   <para>rdfs:label : Family Name
    ///       Element^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#FamilyNameElement">mads:FamilyNameElement</a>
    /// </summary>
    let FamilyNameElement = _prefixId.prefix "FamilyNameElement"
    /// <summary>
    ///   <para>rdfs:label : Fullname Element^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#FullNameElement">mads:FullNameElement</a>
    /// </summary>
    let FullNameElement = _prefixId.prefix "FullNameElement"
    /// <summary>
    ///   <para>rdfs:label : Genre/Form Type</para>
    ///   <para>rdfs:comment : Describes a resource whose label is a genre or form term. Genre
    ///       terms for textual materials designate specific kinds of materials distinguished by the style
    ///       or technique of their intellectual contents; for example, biographies, catechisms, essays,
    ///       hymns, or reviews. Form terms designate historically and functionally specific kinds of
    ///       materials as distinguished by an examination of their physical character, characteristics of
    ///       their intellectual content, or the order of information within them; for example, daybooks,
    ///       diaries, directories, journals, memoranda, questionnaires, syllabi, or time sheets. In the
    ///       context of graphic materials, genre headings denote categories of material distinguished by
    ///       vantage point, intended purpose, characteristics of the creator, publication status, or method
    ///       of representation.</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#GenreForm">mads:GenreForm</a>
    /// </summary>
    let GenreForm = _prefixId.prefix "GenreForm"
    /// <summary>
    ///   <para>rdfs:label : Genre/Form Element</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#GenreFormElement">mads:GenreFormElement</a>
    /// </summary>
    let GenreFormElement = _prefixId.prefix "GenreFormElement"
    /// <summary>
    ///   <para>rdfs:label : Geographic Authority</para>
    ///   <para>rdfs:comment : Describes a resource whose label represents a geographic place or
    ///       feature, especially when a more precise geographic determination (City, Country, Region, etc.)
    ///       cannot be made.</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#Geographic">mads:Geographic</a>
    /// </summary>
    let Geographic = _prefixId.prefix "Geographic"
    /// <summary>
    ///   <para>rdfs:label : Geographic Element</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#GeographicElement">mads:GeographicElement</a>
    /// </summary>
    let GeographicElement = _prefixId.prefix "GeographicElement"
    /// <summary>
    ///   <para>rdfs:label : Given Name
    ///       Element^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#GivenNameElement">mads:GivenNameElement</a>
    /// </summary>
    let GivenNameElement = _prefixId.prefix "GivenNameElement"
    /// <summary>
    ///   <para>rdfs:label : Hierarchical Geographic Type</para>
    ///   <para>rdfs:comment : A madsrdf:HierarchicalGeographic indicates that its label is the
    ///       concatenation of labels from a sequence of madsrdf:Geographic types taken from one of the
    ///       madsrdf:Geographic sub-classes such as madsrdf:City, madsrdf:Country, madsrdf:State,
    ///       madsrdf:Region, madsrdf:Area, etc. The madsrdf:Geographic resources that constitute the
    ///       madsrdf:HierarchicalGeographic should have a broader to narrower hierarchical relationship
    ///       between them.</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#HierarchicalGeographic">mads:HierarchicalGeographic</a>
    /// </summary>
    let HierarchicalGeographic = _prefixId.prefix "HierarchicalGeographic"
    /// <summary>
    ///   <para>rdfs:label : Other Identifier^^xsd:string</para>
    ///   <para>rdfs:comment : A madsrdf:Identifier
    ///       resource describes an identifier by associating the identifier value with its type. To be used
    ///       to record identifiers for a resource in the absence of URIs.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#Identifier">mads:Identifier</a>
    /// </summary>
    let Identifier = _prefixId.prefix "Identifier"
    /// <summary>
    ///   <para>rdfs:label : Island Type</para>
    ///   <para>rdfs:comment : Describes a resource whose
    ///       label is a tract of land surrounded by water and smaller than a continent but is not itself a
    ///       separate country. ^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#Island">mads:Island</a>
    /// </summary>
    let Island = _prefixId.prefix "Island"
    /// <summary>
    ///   <para>rdfs:label : Language Type</para>
    ///   <para>rdfs:comment : Describes a resource whose label represents a
    ///       language.</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#Language">mads:Language</a>
    /// </summary>
    let Language = _prefixId.prefix "Language"
    /// <summary>
    ///   <para>rdfs:label : Language Element^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#LanguageElement">mads:LanguageElement</a>
    /// </summary>
    let LanguageElement = _prefixId.prefix "LanguageElement"
    /// <summary>
    ///   <para>rdfs:label : MADS Collection^^xsd:string</para>
    ///   <para>rdfs:comment : A madsrdf:Collection is an
    ///       organizational unit, members of which will have some form of intellectually unifying theme but
    ///       not to the extent that it defines an independent knowledge organization system. It aggregates
    ///       madsrdf:Authority descriptions or other madsrdf:MADSCollection resources.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#MADSCollection">mads:MADSCollection</a>
    /// </summary>
    let MADSCollection = _prefixId.prefix "MADSCollection"
    /// <summary>
    ///   <para>rdfs:label : MADS Scheme</para>
    ///   <para>rdfs:comment : MADS Scheme is an organizational unit that describes a knowledge
    ///       organization system. It aggregates madsrdf:Authority descriptions and/or
    ///       madsrdf:MADSCollection resources included in the knowledge organization system. Including a
    ///       madsrdf:MADSCollection within a madsrdf:MADSScheme should be done with care; when a
    ///       madsrdf:MADSCollection is part of a madsrdf:MADSScheme, then any madsrdf:Authority within that
    ///       madsrdf:MADSCollection is effectively also in the madsrdf:MADSScheme.</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#MADSScheme">mads:MADSScheme</a>
    /// </summary>
    let MADSScheme = _prefixId.prefix "MADSScheme"
    /// <summary>
    ///   <para>rdfs:label : MADS Type^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#MADSType">mads:MADSType</a>
    /// </summary>
    let MADSType = _prefixId.prefix "MADSType"
    /// <summary>
    ///   <para>rdfs:label : Main Title
    ///       Element^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#MainTitleElement">mads:MainTitleElement</a>
    /// </summary>
    let MainTitleElement = _prefixId.prefix "MainTitleElement"
    /// <summary>
    ///   <para>rdfs:label : Name Type</para>
    ///   <para>rdfs:comment : Describes a resource whose label represents a name, especially when
    ///       a more precise Name type (madsrdf:ConferenceName, masdrdf:FamilyName, etc.) cannot be
    ///       identified.</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#Name">mads:Name</a>
    /// </summary>
    let Name = _prefixId.prefix "Name"
    /// <summary>
    ///   <para>rdfs:label : Name Element</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#NameElement">mads:NameElement</a>
    /// </summary>
    let NameElement = _prefixId.prefix "NameElement"
    /// <summary>
    ///   <para>rdfs:label : Name/Title Type</para>
    ///   <para>rdfs:comment : The label of a madsrdf:NameTitle resource is the concatenation of a
    ///       label of a madsrdf:Name description and the label of a madsrdf:Title description. Both
    ///       description types (madsrdf:Name and madsrdf:Title) are of madsrdf:SimpleType
    ///       types.</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#NameTitle">mads:NameTitle</a>
    /// </summary>
    let NameTitle = _prefixId.prefix "NameTitle"
    /// <summary>
    ///   <para>rdfs:label : Non-sort Element^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#NonSortElement">mads:NonSortElement</a>
    /// </summary>
    let NonSortElement = _prefixId.prefix "NonSortElement"
    /// <summary>
    ///   <para>rdfs:label : Occupation Type</para>
    ///   <para>rdfs:comment : Describes a resource whose
    ///       label represents an occcupation.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#Occupation">mads:Occupation</a>
    /// </summary>
    let Occupation = _prefixId.prefix "Occupation"
    /// <summary>
    ///   <para>rdfs:label : Part Name
    ///       Element^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#PartNameElement">mads:PartNameElement</a>
    /// </summary>
    let PartNameElement = _prefixId.prefix "PartNameElement"
    /// <summary>
    ///   <para>rdfs:label : Part Number
    ///       Element^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#PartNumberElement">mads:PartNumberElement</a>
    /// </summary>
    let PartNumberElement = _prefixId.prefix "PartNumberElement"
    /// <summary>
    ///   <para>rdfs:label : Personal Name Type</para>
    ///   <para>rdfs:comment : Describes a resource whose
    ///       label represents a personal name.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#PersonalName">mads:PersonalName</a>
    /// </summary>
    let PersonalName = _prefixId.prefix "PersonalName"
    /// <summary>
    ///   <para>rdfs:label : Province Type</para>
    ///   <para>rdfs:comment : Describes a resource whose
    ///       label is a first order political division, e.g. Ontario, within a country, e.g. Canada. ^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#Province">mads:Province</a>
    /// </summary>
    let Province = _prefixId.prefix "Province"
    /// <summary>
    ///   <para>rdfs:label : Real World
    ///       Object^^xsd:string</para>
    ///   <para>rdfs:comment : A madsrdf:RWO is an
    ///       abstract entity and identifies a Real World Object (RWO) identified by the label of a
    ///       madsrdf:Authority or madsrdf:DeprecatedAuthority.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#RWO">mads:RWO</a>
    /// </summary>
    let RWO = _prefixId.prefix "RWO"
    /// <summary>
    ///   <para>rdfs:label : Region Type</para>
    ///   <para>rdfs:comment : Describes a resource whose
    ///       label is an area that has the status of a jurisdiction, usually incorporating more than one
    ///       first level jurisdiction. ^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#Region">mads:Region</a>
    /// </summary>
    let Region = _prefixId.prefix "Region"
    /// <summary>
    ///   <para>rdfs:label : Simple Type</para>
    ///   <para>rdfs:comment : madsrdf:SimpleType is a resource with a label constituting a single
    ///       word or phrase.</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#SimpleType">mads:SimpleType</a>
    /// </summary>
    let SimpleType = _prefixId.prefix "SimpleType"
    /// <summary>
    ///   <para>rdfs:label : Source^^xsd:string</para>
    ///   <para>rdfs:comment : A resource that represents
    ///       the source of information about another resource. madsrdf:Source is a type of
    ///       citation.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#Source">mads:Source</a>
    /// </summary>
    let Source = _prefixId.prefix "Source"
    /// <summary>
    ///   <para>rdfs:label : State Type</para>
    ///   <para>rdfs:comment : Describes a resource whose
    ///       label is a first order political division, e.g. Montana, within a country, e.g.
    ///       U.S.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#State">mads:State</a>
    /// </summary>
    let State = _prefixId.prefix "State"
    /// <summary>
    ///   <para>rdfs:label : Subtitle Element^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#SubTitleElement">mads:SubTitleElement</a>
    /// </summary>
    let SubTitleElement = _prefixId.prefix "SubTitleElement"
    /// <summary>
    ///   <para>rdfs:label : Temporal Type</para>
    ///   <para>rdfs:comment : Describes a resource whose
    ///       label represents a time-based notion.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#Temporal">mads:Temporal</a>
    /// </summary>
    let Temporal = _prefixId.prefix "Temporal"
    /// <summary>
    ///   <para>rdfs:label : Temporal Element^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#TemporalElement">mads:TemporalElement</a>
    /// </summary>
    let TemporalElement = _prefixId.prefix "TemporalElement"
    /// <summary>
    ///   <para>rdfs:label : Terms of Address
    ///       Element^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#TermsOfAddressNameElement">mads:TermsOfAddressNameElement</a>
    /// </summary>
    let TermsOfAddressNameElement = _prefixId.prefix "TermsOfAddressNameElement"
    /// <summary>
    ///   <para>rdfs:label : Territory Type</para>
    ///   <para>rdfs:comment : Describes a resource whose
    ///       label is a geographical area belonging to or under the jurisdiction of a governmental
    ///       authority. ^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#Territory">mads:Territory</a>
    /// </summary>
    let Territory = _prefixId.prefix "Territory"
    /// <summary>
    ///   <para>rdfs:label : Title Type</para>
    ///   <para>rdfs:comment : Describes a resource whose
    ///       label represents a title.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#Title">mads:Title</a>
    /// </summary>
    let Title = _prefixId.prefix "Title"
    /// <summary>
    ///   <para>rdfs:label : Title Element</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#TitleElement">mads:TitleElement</a>
    /// </summary>
    let TitleElement = _prefixId.prefix "TitleElement"
    /// <summary>
    ///   <para>rdfs:label : Topic Type</para>
    ///   <para>rdfs:comment : Describes a resource whose
    ///       label represents a topic.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#Topic">mads:Topic</a>
    /// </summary>
    let Topic = _prefixId.prefix "Topic"
    /// <summary>
    ///   <para>rdfs:label : Topic Element</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#TopicElement">mads:TopicElement</a>
    /// </summary>
    let TopicElement = _prefixId.prefix "TopicElement"
    /// <summary>
    ///   <para>rdfs:label : Variant</para>
    ///   <para>rdfs:comment : A resource whose label is the alternate form of an Authority or
    ///       Deprecated Authority.</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#Variant">mads:Variant</a>
    /// </summary>
    let Variant = _prefixId.prefix "Variant"
    /// <summary>
    ///   <para>rdfs:label : Activity End^^xsd:string</para>
    ///   <para>rdfs:comment : Latest date in a period of activity.
    ///     ^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#activityEndDate">mads:activityEndDate</a>
    /// </summary>
    let activityEndDate = _prefixId.prefix "activityEndDate"
    /// <summary>
    ///   <para>rdfs:label : Activity Start^^xsd:string</para>
    ///   <para>rdfs:comment : Earliest date in a period of activity.
    ///     ^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#activityStartDate">mads:activityStartDate</a>
    /// </summary>
    let activityStartDate = _prefixId.prefix "activityStartDate"
    /// <summary>
    ///   <para>rdfs:label : Administrative Metadata</para>
    ///   <para>rdfs:comment : This relates an Authority or Variant to its administrative metadata,
    ///       which is, minimimally, a Class defined outside of the MADS/RDF namespace. The RecordInfo Class
    ///       from the RecordInfo ontology is recommended.</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#adminMetadata">mads:adminMetadata</a>
    /// </summary>
    let adminMetadata = _prefixId.prefix "adminMetadata"
    /// <summary>
    ///   <para>rdfs:label : Affiliation
    ///       Ended^^xsd:string</para>
    ///   <para>rdfs:comment : The date an individual
    ///       ceased to be affiliated with an organization.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#affiliationEnd">mads:affiliationEnd</a>
    /// </summary>
    let affiliationEnd = _prefixId.prefix "affiliationEnd"
    /// <summary>
    ///   <para>rdfs:label : Affiliation
    ///       Started^^xsd:string</para>
    ///   <para>rdfs:comment : The date an individual
    ///       established an affiliation with an organization.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#affiliationStart">mads:affiliationStart</a>
    /// </summary>
    let affiliationStart = _prefixId.prefix "affiliationStart"
    /// <summary>
    ///   <para>rdfs:label : Associated
    ///       Language^^xsd:string</para>
    ///   <para>rdfs:comment : Language that a person,
    ///       organization, or family uses for publication, communication, etc., or in which a work is
    ///       expressed. ^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#associatedLanguage">mads:associatedLanguage</a>
    /// </summary>
    let associatedLanguage = _prefixId.prefix "associatedLanguage"
    /// <summary>
    ///   <para>rdfs:label : Associated Locale^^xsd:string</para>
    ///   <para>rdfs:comment : A town, city, province,
    ///       state, and/or country associated with persons, corporate bodies, families, works, and
    ///       expressions.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#associatedLocale">mads:associatedLocale</a>
    /// </summary>
    let associatedLocale = _prefixId.prefix "associatedLocale"
    /// <summary>
    ///   <para>rdfs:label : Authoritative Label</para>
    ///   <para>rdfs:comment : A lexical string representing a controlled, curated label for the
    ///       Authority.</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#authoritativeLabel">mads:authoritativeLabel</a>
    /// </summary>
    let authoritativeLabel = _prefixId.prefix "authoritativeLabel"
    /// <summary>
    ///   <para>rdfs:label : Birth Date^^xsd:string</para>
    ///   <para>rdfs:comment : The year a person was born.
    ///       Date of birth may also include the month and day of the person’s birth. (RDA
    ///       9.3.2.1)^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#birthDate">mads:birthDate</a>
    /// </summary>
    let birthDate = _prefixId.prefix "birthDate"
    /// <summary>
    ///   <para>rdfs:label : Place of Birth^^xsd:string</para>
    ///   <para>rdfs:comment : The town, city, province,
    ///       state, and/or country in which a person was born.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#birthPlace">mads:birthPlace</a>
    /// </summary>
    let birthPlace = _prefixId.prefix "birthPlace"
    /// <summary>
    ///   <para>rdfs:label : Change Note</para>
    ///   <para>rdfs:comment : A note detailing a modification to an Authority or
    ///       Variant.</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#changeNote">mads:changeNote</a>
    /// </summary>
    let changeNote = _prefixId.prefix "changeNote"
    /// <summary>
    ///   <para>rdfs:label : Citation Note</para>
    ///   <para>rdfs:comment : A note about how the madsrdf:Source relates to the resource about
    ///       which the madsrdf:Source is the information source.</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#citationNote">mads:citationNote</a>
    /// </summary>
    let citationNote = _prefixId.prefix "citationNote"
    /// <summary>
    ///   <para>rdfs:label : Citation Source</para>
    ///   <para>rdfs:comment : The cited resource.</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#citationSource">mads:citationSource</a>
    /// </summary>
    let citationSource = _prefixId.prefix "citationSource"
    /// <summary>
    ///   <para>rdfs:label : Citation Status</para>
    ///   <para>rdfs:comment : Should use a standard term - such as 'found' or 'not found' - to
    ///       indicate whether the cited resource yielded information about the resource related to the
    ///       madsrdf:Source.</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#citationStatus">mads:citationStatus</a>
    /// </summary>
    let citationStatus = _prefixId.prefix "citationStatus"
    /// <summary>
    ///   <para>rdfs:label : City</para>
    ///   <para>rdfs:comment : The city component of an address.</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#city">mads:city</a>
    /// </summary>
    let city = _prefixId.prefix "city"
    /// <summary>
    ///   <para>rdfs:label : Classification</para>
    ///   <para>rdfs:comment : The classification code associated with a
    ///       madsrdf:Authority.</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#classification">mads:classification</a>
    /// </summary>
    let classification = _prefixId.prefix "classification"
    /// <summary>
    ///   <para>rdfs:label : Code^^xsd:string</para>
    ///   <para>rdfs:comment : A code is a string of
    ///       characters associated with a the authoritative or deprecated label. It may record an
    ///       historical notation once used to uniquely identify a concept.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#code">mads:code</a>
    /// </summary>
    let code = _prefixId.prefix "code"
    /// <summary>
    ///   <para>rdfs:label : Component List^^xsd:string</para>
    ///   <para>rdfs:comment : madsrdf:componentList
    ///       organizes the madsrdf:SimpleType resources whose labels are represented in the label of the
    ///       associated madsrdf:ComplexType resource.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#componentList">mads:componentList</a>
    /// </summary>
    let componentList = _prefixId.prefix "componentList"
    /// <summary>
    ///   <para>rdfs:label : Country^^xsd:string</para>
    ///   <para>rdfs:comment : Country associated with an
    ///       address.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#country">mads:country</a>
    /// </summary>
    let country = _prefixId.prefix "country"
    /// <summary>
    ///   <para>rdfs:label : ^^xsd:string</para>
    ///   <para>rdfs:comment : Ending date of the date range for which the beginning date is recorded in madsrdf:creationDateStart.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#creationDateEnd">mads:creationDateEnd</a>
    /// </summary>
    let creationDateEnd = _prefixId.prefix "creationDateEnd"
    /// <summary>
    ///   <para>rdfs:label : Work begun^^xsd:string</para>
    ///   <para>rdfs:comment : For a work, earliest date (normally the year) associated with a work; that date may be the date the work was created or first published or released. For an expression, the earliest date (normally the year) associated with an expression; that date may be the date of the earliest known manifestation of that expression. In both cases the date may be the starting date of a range or a single date.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#creationDateStart">mads:creationDateStart</a>
    /// </summary>
    let creationDateStart = _prefixId.prefix "creationDateStart"
    /// <summary>
    ///   <para>rdfs:label : Death Date^^xsd:string</para>
    ///   <para>rdfs:comment : The year a person died.
    ///       Date of death may also include the month and day of the person’s death. (RDA
    ///       9.3.3.1)^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#deathDate">mads:deathDate</a>
    /// </summary>
    let deathDate = _prefixId.prefix "deathDate"
    /// <summary>
    ///   <para>rdfs:label : Place of Death^^xsd:string</para>
    ///   <para>rdfs:comment : The town, city, province,
    ///       state, and/or country in which a person died.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#deathPlace">mads:deathPlace</a>
    /// </summary>
    let deathPlace = _prefixId.prefix "deathPlace"
    /// <summary>
    ///   <para>rdfs:label : Definition Note</para>
    ///   <para>rdfs:comment : An explanation of the meaning of an Authority, DeprecatedAuthority,
    ///       or Variant description.</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#definitionNote">mads:definitionNote</a>
    /// </summary>
    let definitionNote = _prefixId.prefix "definitionNote"
    /// <summary>
    ///   <para>rdfs:label : Deletion Note^^xsd:string</para>
    ///   <para>rdfs:comment : A note pertaining to the
    ///       deletion of a resource.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#deletionNote">mads:deletionNote</a>
    /// </summary>
    let deletionNote = _prefixId.prefix "deletionNote"
    /// <summary>
    ///   <para>rdfs:label : Deprecated Label^^xsd:string</para>
    ///   <para>rdfs:comment : A label once considered
    ///       authoritative (controlled and curated) but which is no longer.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#deprecatedLabel">mads:deprecatedLabel</a>
    /// </summary>
    let deprecatedLabel = _prefixId.prefix "deprecatedLabel"
    /// <summary>
    ///   <para>rdfs:label : Editorial Note^^xsd:string</para>
    ///   <para>rdfs:comment : A note pertaining to the
    ///       management of the label associated with the resource.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#editorialNote">mads:editorialNote</a>
    /// </summary>
    let editorialNote = _prefixId.prefix "editorialNote"
    /// <summary>
    ///   <para>rdfs:label : Element List^^xsd:string</para>
    ///   <para>rdfs:comment : The madsrdf:elementList property is used to organize the various
    ///       parts of labels.</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#elementList">mads:elementList</a>
    /// </summary>
    let elementList = _prefixId.prefix "elementList"
    /// <summary>
    ///   <para>rdfs:label : Element Value^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#elementValue">mads:elementValue</a>
    /// </summary>
    let elementValue = _prefixId.prefix "elementValue"
    /// <summary>
    ///   <para>rdfs:label : Email^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#email">mads:email</a>
    /// </summary>
    let email = _prefixId.prefix "email"
    /// <summary>
    ///   <para>rdfs:label : Entity
    ///       Descriptor^^xsd:string</para>
    ///   <para>rdfs:comment : Any attribute that serves
    ///       to characterize a person, family or corporate body or that may be needed for differentiation
    ///       from other persons. families or corporate bodies and for which separate content designation is
    ///       not already defined.Or ^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#entityDescriptor">mads:entityDescriptor</a>
    /// </summary>
    let entityDescriptor = _prefixId.prefix "entityDescriptor"
    /// <summary>
    ///   <para>rdfs:label : Established^^xsd:string</para>
    ///   <para>rdfs:comment : The year a corporate body was established. Date of establishment may also include the month and day of the corporate body’s establishment.
    ///     ^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#establishDate">mads:establishDate</a>
    /// </summary>
    let establishDate = _prefixId.prefix "establishDate"
    /// <summary>
    ///   <para>rdfs:label : Example Note^^xsd:string</para>
    ///   <para>rdfs:comment : A example of how the
    ///       resource might be used.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#exampleNote">mads:exampleNote</a>
    /// </summary>
    let exampleNote = _prefixId.prefix "exampleNote"
    /// <summary>
    ///   <para>rdfs:label : Extended Address^^xsd:string</para>
    ///   <para>rdfs:comment : The second address line, if
    ///       needed.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#extendedAddress">mads:extendedAddress</a>
    /// </summary>
    let extendedAddress = _prefixId.prefix "extendedAddress"
    /// <summary>
    ///   <para>rdfs:label : Extension^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#extension">mads:extension</a>
    /// </summary>
    let extension = _prefixId.prefix "extension"
    /// <summary>
    ///   <para>rdfs:label : Fax^^xsd:string</para>
    ///   <para>rdfs:comment : Fax number^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#fax">mads:fax</a>
    /// </summary>
    let fax = _prefixId.prefix "fax"
    /// <summary>
    ///   <para>rdfs:label : Field of
    ///       Activity^^xsd:string</para>
    ///   <para>rdfs:comment : The field of activity
    ///       associated with an individual.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#fieldOfActivity">mads:fieldOfActivity</a>
    /// </summary>
    let fieldOfActivity = _prefixId.prefix "fieldOfActivity"
    /// <summary>
    ///   <para>rdfs:label : Fuller Name^^xsd:string</para>
    ///   <para>rdfs:comment : Full form of name needed to
    ///       distinguish a person from another person with the same preferred name.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#fullerName">mads:fullerName</a>
    /// </summary>
    let fullerName = _prefixId.prefix "fullerName"
    /// <summary>
    ///   <para>rdfs:label : Gender^^xsd:string</para>
    ///   <para>rdfs:comment : The gender with which a
    ///       person identifies. ^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#gender">mads:gender</a>
    /// </summary>
    let gender = _prefixId.prefix "gender"
    /// <summary>
    ///   <para>rdfs:label : Has Abbreviation
    ///       Variant^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#hasAbbreviationVariant">mads:hasAbbreviationVariant</a>
    /// </summary>
    let hasAbbreviationVariant = _prefixId.prefix "hasAbbreviationVariant"
    /// <summary>
    ///   <para>rdfs:label : Has Acronym
    ///       Variant^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#hasAcronymVariant">mads:hasAcronymVariant</a>
    /// </summary>
    let hasAcronymVariant = _prefixId.prefix "hasAcronymVariant"
    /// <summary>
    ///   <para>rdfs:label : Has Affiliation^^xsd:string</para>
    ///   <para>rdfs:comment : Property to associate an
    ///       individual, such as a foaf:Agent, to a group or organization with which an individual is or
    ///       has been affiliated.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#hasAffiliation">mads:hasAffiliation</a>
    /// </summary>
    let hasAffiliation = _prefixId.prefix "hasAffiliation"
    /// <summary>
    ///   <para>rdfs:label : Has Affiliation
    ///       Address^^xsd:string</para>
    ///   <para>rdfs:comment : The address of the group or
    ///       organization with which an individual is associated.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#hasAffiliationAddress">mads:hasAffiliationAddress</a>
    /// </summary>
    let hasAffiliationAddress = _prefixId.prefix "hasAffiliationAddress"
    /// <summary>
    ///   <para>rdfs:label : Has Broader
    ///       Authority^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#hasBroaderAuthority">mads:hasBroaderAuthority</a>
    /// </summary>
    let hasBroaderAuthority = _prefixId.prefix "hasBroaderAuthority"
    /// <summary>
    ///   <para>rdfs:label : Has Broader External
    ///       Authority^^xsd:string</para>
    ///   <para>rdfs:comment : Creates a direct
    ///       relationship between an Authority and a more broadly defined Authority from a different MADS
    ///       Scheme.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#hasBroaderExternalAuthority">mads:hasBroaderExternalAuthority</a>
    /// </summary>
    let hasBroaderExternalAuthority = _prefixId.prefix "hasBroaderExternalAuthority"
    /// <summary>
    ///   <para>rdfs:label : Other characteristic^^xsd:string</para>
    ///   <para>rdfs:comment : A term that specifies a characteristic that differentiates a work or expression from another one.
    ///     ^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#hasChararacteristic">mads:hasChararacteristic</a>
    /// </summary>
    let hasChararacteristic = _prefixId.prefix "hasChararacteristic"
    /// <summary>
    ///   <para>rdfs:label : Has Close External
    ///       Authority^^xsd:string</para>
    ///   <para>rdfs:comment : Records a relationship
    ///       between an Authority and one that is closely related from a different MADS
    ///       Scheme.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#hasCloseExternalAuthority">mads:hasCloseExternalAuthority</a>
    /// </summary>
    let hasCloseExternalAuthority = _prefixId.prefix "hasCloseExternalAuthority"
    /// <summary>
    ///   <para>rdfs:label : Has Parent
    ///       Organization^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes a relationship
    ///       between a CorporateName Authority and one of the same that is more broadly
    ///       defined.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#hasCorporateParentAuthority">mads:hasCorporateParentAuthority</a>
    /// </summary>
    let hasCorporateParentAuthority = _prefixId.prefix "hasCorporateParentAuthority"

    /// <summary>
    ///   <para>rdfs:label : Is Parent Organization
    ///       Of^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes a relationship
    ///       between a CorporateName Authority and one of the same that is more narrowly
    ///       defined.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#hasCorporateSubsidiaryAuthority">mads:hasCorporateSubsidiaryAuthority</a>
    /// </summary>
    let hasCorporateSubsidiaryAuthority =
        _prefixId.prefix "hasCorporateSubsidiaryAuthority"

    /// <summary>
    ///   <para>rdfs:label : Has Earlier Established
    ///       Form^^xsd:string</para>
    ///   <para>rdfs:comment : Used to reference a resource that was an earlier form. This is
    ///       Related type='earlier' in MADS XML.</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#hasEarlierEstablishedForm">mads:hasEarlierEstablishedForm</a>
    /// </summary>
    let hasEarlierEstablishedForm = _prefixId.prefix "hasEarlierEstablishedForm"
    /// <summary>
    ///   <para>rdfs:label : Has Exact External
    ///       Authority^^xsd:string</para>
    ///   <para>rdfs:comment : Records a relationship
    ///       between an Authority and one to which it matches exactly but from a different MADS
    ///       Scheme.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#hasExactExternalAuthority">mads:hasExactExternalAuthority</a>
    /// </summary>
    let hasExactExternalAuthority = _prefixId.prefix "hasExactExternalAuthority"
    /// <summary>
    ///   <para>rdfs:label : Has Expansion
    ///       Variant^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#hasExpansionVariant">mads:hasExpansionVariant</a>
    /// </summary>
    let hasExpansionVariant = _prefixId.prefix "hasExpansionVariant"
    /// <summary>
    ///   <para>rdfs:label : Has Hidden Variant</para>
    ///   <para>rdfs:comment : Use for variants that are searchable, but not necessarily for
    ///       display.</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#hasHiddenVariant">mads:hasHiddenVariant</a>
    /// </summary>
    let hasHiddenVariant = _prefixId.prefix "hasHiddenVariant"
    /// <summary>
    ///   <para>rdfs:label : Has Identifier^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a resource with
    ///       a madsrdf:Identifier.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#hasIdentifier">mads:hasIdentifier</a>
    /// </summary>
    let hasIdentifier = _prefixId.prefix "hasIdentifier"
    /// <summary>
    ///   <para>rdfs:label : Has Later Established
    ///       Form^^xsd:string</para>
    ///   <para>rdfs:comment : Use to reference the later form of a resource. This is Related
    ///       type='later' in MADS XML.</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#hasLaterEstablishedForm">mads:hasLaterEstablishedForm</a>
    /// </summary>
    let hasLaterEstablishedForm = _prefixId.prefix "hasLaterEstablishedForm"
    /// <summary>
    ///   <para>rdfs:label : Has MADSCollection Member</para>
    ///   <para>rdfs:comment : Associates an Authority or other Collection with a
    ///       madsrdf:MADSCollection.</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#hasMADSCollectionMember">mads:hasMADSCollectionMember</a>
    /// </summary>
    let hasMADSCollectionMember = _prefixId.prefix "hasMADSCollectionMember"
    /// <summary>
    ///   <para>rdfs:label : Has MADS Scheme
    ///       Member^^xsd:string</para>
    ///   <para>rdfs:comment : Associates an Authority or Collection with a
    ///       madsrdf:MADSScheme.</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#hasMADSSchemeMember">mads:hasMADSSchemeMember</a>
    /// </summary>
    let hasMADSSchemeMember = _prefixId.prefix "hasMADSSchemeMember"
    /// <summary>
    ///   <para>rdfs:label : Has Narrower
    ///       Authority^^xsd:string</para>
    ///   <para>rdfs:comment : Creates a direct
    ///       relationship between an Authority and one that is more narrowly defined.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#hasNarrowerAuthority">mads:hasNarrowerAuthority</a>
    /// </summary>
    let hasNarrowerAuthority = _prefixId.prefix "hasNarrowerAuthority"
    /// <summary>
    ///   <para>rdfs:label : Has Narrower External
    ///       Authority^^xsd:string</para>
    ///   <para>rdfs:comment : Creates a direct
    ///       relationship between an Authority and a more narrowly defined Authority from a different MADS
    ///       Scheme.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#hasNarrowerExternalAuthority">mads:hasNarrowerExternalAuthority</a>
    /// </summary>
    let hasNarrowerExternalAuthority = _prefixId.prefix "hasNarrowerExternalAuthority"
    /// <summary>
    ///   <para>rdfs:label : Has Reciprocal
    ///       Authority^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes a relationship between two Authority resources. It is
    ///       reciprocal, so the relationship must be shared. This is Related type='equivalent' in MADS
    ///       XML.</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#hasReciprocalAuthority">mads:hasReciprocalAuthority</a>
    /// </summary>
    let hasReciprocalAuthority = _prefixId.prefix "hasReciprocalAuthority"

    /// <summary>
    ///   <para>rdfs:label : Has Reciprocal External
    ///       Authority^^xsd:string</para>
    ///   <para>rdfs:comment : Establishes a relationship
    ///       between an Authority and one from a different MADS Scheme. It is reciprocal, so the
    ///       relationship must be shared.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#hasReciprocalExternalAuthority">mads:hasReciprocalExternalAuthority</a>
    /// </summary>
    let hasReciprocalExternalAuthority =
        _prefixId.prefix "hasReciprocalExternalAuthority"

    /// <summary>
    ///   <para>rdfs:label : Has Related Authority</para>
    ///   <para>rdfs:comment : Unless the relationship can be more specifically identified, use
    ///       'hasRelatedAuthority.'</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#hasRelatedAuthority">mads:hasRelatedAuthority</a>
    /// </summary>
    let hasRelatedAuthority = _prefixId.prefix "hasRelatedAuthority"
    /// <summary>
    ///   <para>rdfs:label : Has Source^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a resource description with its Source.</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#hasSource">mads:hasSource</a>
    /// </summary>
    let hasSource = _prefixId.prefix "hasSource"
    /// <summary>
    ///   <para>rdfs:label : Has Top Member of MADS
    ///       Scheme^^xsd:string</para>
    ///   <para>rdfs:comment : Identifies an Authority
    ///       that is at the top of the hierarchy of authorities within the MADS Scheme.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#hasTopMemberOfMADSScheme">mads:hasTopMemberOfMADSScheme</a>
    /// </summary>
    let hasTopMemberOfMADSScheme = _prefixId.prefix "hasTopMemberOfMADSScheme"
    /// <summary>
    ///   <para>rdfs:label : Has Translation
    ///       Variant^^xsd:string</para>
    ///   <para>rdfs:comment : A Variant whose label
    ///       represents a translation of that of the authoritative label.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#hasTranslationVariant">mads:hasTranslationVariant</a>
    /// </summary>
    let hasTranslationVariant = _prefixId.prefix "hasTranslationVariant"
    /// <summary>
    ///   <para>rdfs:label : Has Variant^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a Variant with an Authority or Deprecrated Authority.
    ///       Unless the variant type can be more specifically identified, use 'hasVariant.'</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#hasVariant">mads:hasVariant</a>
    /// </summary>
    let hasVariant = _prefixId.prefix "hasVariant"
    /// <summary>
    ///   <para>rdfs:label : Hidden Label^^xsd:string</para>
    ///   <para>rdfs:comment : A label entered for
    ///       discovery purposes but not shown.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#hiddenLabel">mads:hiddenLabel</a>
    /// </summary>
    let hiddenLabel = _prefixId.prefix "hiddenLabel"
    /// <summary>
    ///   <para>rdfs:label : History Note^^xsd:string</para>
    ///   <para>rdfs:comment : A note pertaining to the
    ///       history of the resource.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#historyNote">mads:historyNote</a>
    /// </summary>
    let historyNote = _prefixId.prefix "historyNote"
    /// <summary>
    ///   <para>rdfs:label : Honorary Title^^xsd:string</para>
    ///   <para>rdfs:comment : Designation indicative of
    ///       royalty, nobility, or ecclesiastical rank or office, or a term of address for a person of
    ///       religious vocation.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#honoraryTitle">mads:honoraryTitle</a>
    /// </summary>
    let honoraryTitle = _prefixId.prefix "honoraryTitle"
    /// <summary>
    ///   <para>rdfs:label : Hours^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#hours">mads:hours</a>
    /// </summary>
    let hours = _prefixId.prefix "hours"
    /// <summary>
    ///   <para>rdfs:label : Identifier
    ///       Scheme^^xsd:string</para>
    ///   <para>rdfs:comment : The scheme associated with
    ///       the identifier. For example, "LCCN" would be used when the Identifier Value (madsrdf:idValue)
    ///       is a LC Control Number.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#idScheme">mads:idScheme</a>
    /// </summary>
    let idScheme = _prefixId.prefix "idScheme"
    /// <summary>
    ///   <para>rdfs:label : Identifier Value^^xsd:string</para>
    ///   <para>rdfs:comment : The value of the identifier
    ///       conforming to the Identifier Scheme syntax.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#idValue">mads:idValue</a>
    /// </summary>
    let idValue = _prefixId.prefix "idValue"
    /// <summary>
    ///   <para>rdfs:label : Identifies RWO^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a
    ///       madsrdf:Authority with the Real World Object that is the subject of the authority's
    ///       label.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#identifiesRWO">mads:identifiesRWO</a>
    /// </summary>
    let identifiesRWO = _prefixId.prefix "identifiesRWO"
    /// <summary>
    ///   <para>rdfs:label : Is Identified By
    ///       Authority^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a Real World
    ///       Object with its Authority description.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#isIdentifiedByAuthority">mads:isIdentifiedByAuthority</a>
    /// </summary>
    let isIdentifiedByAuthority = _prefixId.prefix "isIdentifiedByAuthority"
    /// <summary>
    ///   <para>rdfs:label : Is Member Of MADSCollection</para>
    ///   <para>rdfs:comment : Associates a Collection with a madsrdf:Authority or another
    ///       madsrdf:MADSCollection.</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#isMemberOfMADSCollection">mads:isMemberOfMADSCollection</a>
    /// </summary>
    let isMemberOfMADSCollection = _prefixId.prefix "isMemberOfMADSCollection"
    /// <summary>
    ///   <para>rdfs:label : Is Member of MADS
    ///       Scheme^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#isMemberOfMADSScheme">mads:isMemberOfMADSScheme</a>
    /// </summary>
    let isMemberOfMADSScheme = _prefixId.prefix "isMemberOfMADSScheme"
    /// <summary>
    ///   <para>rdfs:label : Is Top Member of MADS
    ///       Scheme^^xsd:string</para>
    ///   <para>rdfs:comment : Identifies a MADS Scheme in
    ///       which the Authority is at the top of the hierarchy.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#isTopMemberOfMADSScheme">mads:isTopMemberOfMADSScheme</a>
    /// </summary>
    let isTopMemberOfMADSScheme = _prefixId.prefix "isTopMemberOfMADSScheme"
    /// <summary>
    ///   <para>rdfs:label : Nature of
    ///       Affiliation^^xsd:string</para>
    ///   <para>rdfs:comment : Records the individual's
    ///       role or position in the organization with which the individual is affiliated. A "job title"
    ///       might be appropriate.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#natureOfAffiliation">mads:natureOfAffiliation</a>
    /// </summary>
    let natureOfAffiliation = _prefixId.prefix "natureOfAffiliation"
    /// <summary>
    ///   <para>rdfs:label : Note^^xsd:string</para>
    ///   <para>rdfs:comment : A note about the
    ///       resource.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#note">mads:note</a>
    /// </summary>
    let note = _prefixId.prefix "note"
    /// <summary>
    ///   <para>rdfs:label : Occupation^^xsd:string</para>
    ///   <para>rdfs:comment : A profession or occupation
    ///       in which the person works or has worked.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#occupation">mads:occupation</a>
    /// </summary>
    let occupation = _prefixId.prefix "occupation"
    /// <summary>
    ///   <para>rdfs:label : Organization or
    ///       Group^^xsd:string</para>
    ///   <para>rdfs:comment : The group or organization
    ///       with which an individual is associated.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#organization">mads:organization</a>
    /// </summary>
    let organization = _prefixId.prefix "organization"
    /// <summary>
    ///   <para>rdfs:label : Phone^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#phone">mads:phone</a>
    /// </summary>
    let phone = _prefixId.prefix "phone"
    /// <summary>
    ///   <para>rdfs:label : Post Code / Zip
    ///       Code^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#postcode">mads:postcode</a>
    /// </summary>
    let postcode = _prefixId.prefix "postcode"
    /// <summary>
    ///   <para>rdfs:label : Prominent Family
    ///       Member^^xsd:string</para>
    ///   <para>rdfs:comment : A well-known individual who
    ///       is a member of the family.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#prominentFamilyMember">mads:prominentFamilyMember</a>
    /// </summary>
    let prominentFamilyMember = _prefixId.prefix "prominentFamilyMember"
    /// <summary>
    ///   <para>rdfs:label : Scope Note^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#scopeNote">mads:scopeNote</a>
    /// </summary>
    let scopeNote = _prefixId.prefix "scopeNote"
    /// <summary>
    ///   <para>rdfs:label : See Also^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes a relationship
    ///       between an Authority and/or DeprecatedAuthority. The relationship may or may or may not be
    ///       reciprocated and there is no certainty that the related resource will further illuminate the
    ///       original resource.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#see">mads:see</a>
    /// </summary>
    let see = _prefixId.prefix "see"
    /// <summary>
    ///   <para>rdfs:label : State^^xsd:string</para>
    ///   <para>rdfs:comment : The state associated with
    ///       an address.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#state">mads:state</a>
    /// </summary>
    let state = _prefixId.prefix "state"
    /// <summary>
    ///   <para>rdfs:label : Street Address^^xsd:string</para>
    ///   <para>rdfs:comment : First line of address. For
    ///       second line, use madsrdf:extendedAddress.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#streetAddress">mads:streetAddress</a>
    /// </summary>
    let streetAddress = _prefixId.prefix "streetAddress"
    /// <summary>
    ///   <para>rdfs:label : Terminated^^xsd:string</para>
    ///   <para>rdfs:comment : The year a corporate body was terminated. Date of termination may also include the month and day of the corporate body’s termination.
    ///     ^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#terminateDate">mads:terminateDate</a>
    /// </summary>
    let terminateDate = _prefixId.prefix "terminateDate"
    /// <summary>
    ///   <para>rdfs:label : Use For^^xsd:string</para>
    ///   <para>rdfs:comment : "Use [This Resource] For."
    ///       Traditional "USE FOR" reference.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#useFor">mads:useFor</a>
    /// </summary>
    let useFor = _prefixId.prefix "useFor"
    /// <summary>
    ///   <para>rdfs:label : Use Instead^^xsd:string</para>
    ///   <para>rdfs:comment : "Use [This Other Resource]
    ///       Instead." Traditional "USE" reference.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#useInstead">mads:useInstead</a>
    /// </summary>
    let useInstead = _prefixId.prefix "useInstead"
    /// <summary>
    ///   <para>rdfs:label : Variant Label^^xsd:string</para>
    ///   <para>rdfs:comment : The lexical, variant form
    ///       of an authoritative label.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#variantLabel">mads:variantLabel</a>
    /// </summary>
    let variantLabel = _prefixId.prefix "variantLabel"
    /// <summary>
    ///   <para>rdfs:label : Work locale^^xsd:string</para>
    ///   <para>rdfs:comment : The country or other territorial jurisdiction from which a work originated.^^xsd:string</para>
    ///   <a href="http://www.loc.gov/mads/rdf/v1#workOrigin">mads:workOrigin</a>
    /// </summary>
    let workOrigin = _prefixId.prefix "workOrigin"

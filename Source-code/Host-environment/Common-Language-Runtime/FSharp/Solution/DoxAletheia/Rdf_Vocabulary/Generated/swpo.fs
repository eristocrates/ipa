namespace http.sw_portal.deri.org.ontologies.swportal.hash

open DoxAletheia

module swpo =
    let _namespace_name = "http://sw-portal.deri.org/ontologies/swportal#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// This class comprises all kinds of publications which contain other publications, such as journal, proceedings, series, etc. An instance of PublicationContainer has an editor.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#PublicationContainer"></see></summary>
    let PublicationContainer = _prefix "PublicationContainer"
    /// <summary>
    ///   <see href="http://sw-portal.deri.org/ontologies/swportal#hasNote"></see>
    /// </summary>
    let hasNote = _prefix "hasNote"
    /// <summary>
    /// This class is the super-class for any kind of news item.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#NewsItem"></see></summary>
    let NewsItem = _prefix "NewsItem"
    /// <summary>
    /// Publications are both individual documents and collections of documents such as series, journals, etc.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#Publication"></see></summary>
    let Publication = _prefix "Publication"
    /// <summary>
    /// The title of the publication (book, article, ...) or publication container (series, journal).
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#hasTitle"></see></summary>
    let hasTitle = _prefix "hasTitle"
    /// <summary>
    /// This class represents administrative staff.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#AdministrativeStaff"></see></summary>
    let AdministrativeStaff = _prefix "AdministrativeStaff"
    /// <summary>
    /// This is an adhoc solution for creating and ordered group of Agents, e.g. an authorlist.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#AgentSequence"></see></summary>
    let AgentSequence = _prefix "AgentSequence"
    /// <summary>
    /// An article from a journal or magazine.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#Article"></see></summary>
    let Article = _prefix "Article"
    /// <summary>
    /// A book with an explicit publisher. NOTES: - Either &lt;link&gt;authors&lt;/link&gt; or &lt;link&gt;editedBy&lt;/link&gt; must be given - Either &lt;link&gt;volume&lt;/link&gt; or &lt;link&gt;number&lt;/link&gt; may be given.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#Book"></see></summary>
    let Book = _prefix "Book"
    /// <summary>
    /// The instances of this class comprise all publications which have a specific publication date. If a publication P is contained within an &lt;link&gt;PublicationContainer&lt;/link&gt;, and this container has a publication date, than P is not an &lt;link&gt;IndividualPublication&lt;/link&gt;. Example: an &lt;link&gt;Inbook&lt;/link&gt; publication is not an &lt;link&gt;IndividualPublication&lt;/link&gt;, because its publication date can be inferred from the &lt;link&gt;Book&lt;/link&gt; which contains it.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#IndividualPublication"></see></summary>
    let IndividualPublication = _prefix "IndividualPublication"
    /// <summary>
    /// A work that is printed and bound, but without a named publisher or sponsoring institution.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#Booklet"></see></summary>
    let Booklet = _prefix "Booklet"
    /// <summary>
    /// This class defines geopraphical bodies that are cities.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#City"></see></summary>
    let City = _prefix "City"
    /// <summary>
    /// This class defines geopraphical bodies that can be contained in regions.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#SubRegion"></see></summary>
    let SubRegion = _prefix "SubRegion"
    /// <summary>
    /// This class represents all kinds of administrative staff that is related to clerical support. Examples are secretaries, accountants, etc.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#ClericalStaff"></see></summary>
    let ClericalStaff = _prefix "ClericalStaff"
    /// <summary>
    /// A Cluster is a kind of group which focuses on a research area and typically is part of a research institute or university.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#Cluster"></see></summary>
    let Cluster = _prefix "Cluster"
    /// <summary>
    /// This class represents all kinds of companies. Currently only publishers and software developers are modelled.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#Company"></see></summary>
    let Company = _prefix "Company"
    /// <summary>
    /// This class represents an organization with a formal legal status. We introduce this class as a subclass of &lt;link&gt;foaf:Organization&lt;/link&gt; and &lt;link&gt;foaf:Group&lt;/link&gt;, because we consider an organization as a kind of group.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#Organization"></see></summary>
    let Organization = _prefix "Organization"
    /// <summary>
    /// This class represents all kinds of conferences in the academic domain.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#Conference"></see></summary>
    let Conference = _prefix "Conference"
    /// <summary>
    /// This class represents events relevant for the area of teaching, research, business, i.e. conferences, presentations, tutorials, workshops and lectures.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#Event"></see></summary>
    let Event = _prefix "Event"
    /// <summary>
    /// This class defines geopraphical bodies that are continents.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#Continent"></see></summary>
    let Continent = _prefix "Continent"
    /// <summary>
    /// This class is the superclass for all classes defining geographical locations. The approach for this subontology is to have a hierarchy of location classes, such that instances of the classes further down in the hierarchy can be contained in instances of the classes higher up in the hierarchy. On each level, there exist two sister classes: class L defines a certain type of location, while class SubL defines locations which can be contained in instances of L. SubL then defines a property inL, to express which instance of L an instance of SubL is contained in. E.g. for a class Continent, there exists a class SubContinent. All children of SubContinent (either direct or transitive) define locations that can be contained in a continent, such as countries, regions, cities, etc. By virtue of inheritance, all these location classes then have a property inContinent, to express that they are contained in some continent. In a simpler, flat structure, inContinent would have to be defined explicitly for all kinds of locations that can be contained in a continent.
    /// The intepretation of the inL predicates should be as follows: if, for a particular instance K, inL has a value, this value is valid. If inL has no value, the value of inL in the next location K is contained in valid, and so forth. E.g. an instance "Hawaii" has the value "Oceania" defined for &lt;link&gt;inContinent&lt;/link&gt; and "USA" for &lt;link&gt;inCountry&lt;/link&gt;. "Delaware" has no value for inContinent. "USA" has the value "North America" for &lt;link&gt;inContinent&lt;/link&gt;. The interpretation would be that "Hawaii" is located in "Oceania", while "Delaware" is located in "North America".
    /// We are aware of the fact that this approach is idealized and can therefore conflict with reality in some situations. E.g., the exact borders of continents are not always defined (there are contradicting opinions on where exactly Europe begins or ends). Countries could be contained in more than one continent (Turkey belongs to both Europe and Asia). However, we think that these situations are marginal and have little or no impact on the intended use of this ontology.
    /// We think that this recursive modelling of locations is at the same time simple and powerful enough to capture all necessary aspects of the concept of location for a domain such as an SWPortal. While the SubL classes might appear to be somewhat artificial, they are actually not. They are just an abstraction for geographical entities that are (under normal circumstances) smaller than entities of type L. As such, they are no more abstract than, say, the concept of an agent.
    ///
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#Location"></see></summary>
    let Location = _prefix "Location"
    /// <summary>
    /// This class defines geopraphical bodies that are countries.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#Country"></see></summary>
    let Country = _prefix "Country"
    /// <summary>
    /// This class defines geopraphical bodies that can be contained in continents.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#SubContinent"></see></summary>
    let SubContinent = _prefix "SubContinent"
    /// <summary>
    /// A document which is produced as part of a project. Deliverables are not formally published. NOTE: This concept was not derived from any of the BibTex types, but considered useful anyway.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#Deliverable"></see></summary>
    let Deliverable = _prefix "Deliverable"
    /// <summary>
    /// A document which does have an author and title, but hasn't been formally published.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#Unpublished"></see></summary>
    let Unpublished = _prefix "Unpublished"
    /// <summary>
    /// A part of a Book, which may be a chapter (or section or whatever) and/or a range of pages. Because the BibTex types inCollection and inBook are very similiar, we decided to keep the ontology as simple as possible and merge them both into &lt;link&gt;Inbook&lt;/link&gt;.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#Inbook"></see></summary>
    let Inbook = _prefix "Inbook"
    /// <summary>
    /// An initiative is a group which has specific aims. It differs from &lt;link&gt;foaf:Project&lt;/link&gt; in that it normally doesn’t have any funding. Often, its duration is longer.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#Initiative"></see></summary>
    let Initiative = _prefix "Initiative"
    /// <summary>
    /// As &lt;link&gt;foaf:Project&lt;/link&gt;, &lt;link&gt;Initiative&lt;/link&gt; and &lt;link&gt;WorkingGroup&lt;/link&gt; differ from Cluster in having a specific duration, we comprise these there temporal groups in this class which represents all kinds of temporary groups.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#TemporaryGroup"></see></summary>
    let TemporaryGroup = _prefix "TemporaryGroup"
    /// <summary>
    /// An article in a conference proceedings (i.e. Proceedings).
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#Inproceedings"></see></summary>
    let Inproceedings = _prefix "Inproceedings"
    /// <summary>
    /// A scientific journal or magazine. The instances of this class are not individual issues or voulumes of a journal, but the journal as such.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#Journal"></see></summary>
    let Journal = _prefix "Journal"
    /// <summary>
    /// This class represents lectures with an educational purpose, e.g within a university.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#Lecture"></see></summary>
    let Lecture = _prefix "Lecture"
    /// <summary>
    /// This class represents the management staff.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#ManagementStaff"></see></summary>
    let ManagementStaff = _prefix "ManagementStaff"
    /// <summary>
    /// A thesis written to receive a Master degree.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#MasterThesis"></see></summary>
    let MasterThesis = _prefix "MasterThesis"
    /// <summary>
    /// Any kind of thesis produced to receive some sort of university degree.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#Thesis"></see></summary>
    let Thesis = _prefix "Thesis"
    /// <summary>
    /// Some sort of publication which doesn't fit into any of the other concepts.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#Misc"></see></summary>
    let Misc = _prefix "Misc"
    /// <summary>
    /// A thesis written to receive a PhD degree.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#PhDThesis"></see></summary>
    let PhDThesis = _prefix "PhDThesis"
    /// <summary>
    /// Instances of this class represent exact postal addresses. Note that either &lt;link&gt;postbox&lt;/link&gt; of &lt;link&gt;streetAddress&lt;/link&gt; should be given.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#PostalAddress"></see></summary>
    let PostalAddress = _prefix "PostalAddress"
    /// <summary>
    /// This class defines geopraphical bodies that can be contained in cities.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#SubCity"></see></summary>
    let SubCity = _prefix "SubCity"
    /// <summary>
    /// This class represents all kinds of presentations.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#Presentation"></see></summary>
    let Presentation = _prefix "Presentation"
    /// <summary>
    /// The proceedings of a conference.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#Proceedings"></see></summary>
    let Proceedings = _prefix "Proceedings"
    /// <summary>
    /// This class models companies that publish documents.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#PublishingCompany"></see></summary>
    let PublishingCompany = _prefix "PublishingCompany"
    /// <summary>
    /// This class defines geopraphical bodies that are regions, with the intended meaning "sub-division of a country".
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#Region"></see></summary>
    let Region = _prefix "Region"
    /// <summary>
    /// This class defines geopraphical bodies that can be contained in countries.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#SubCountry"></see></summary>
    let SubCountry = _prefix "SubCountry"
    /// <summary>
    /// This class represents research institutes. These organizations have special research areas.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#ResearchInstitute"></see></summary>
    let ResearchInstitute = _prefix "ResearchInstitute"
    /// <summary>
    /// This class represents all kinds of researchers who are not students.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#ResearchStaff"></see></summary>
    let ResearchStaff = _prefix "ResearchStaff"
    /// <summary>
    /// This class represents all kinds of persons who are researchers. Each has a research area.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#Researcher"></see></summary>
    let Researcher = _prefix "Researcher"
    /// <summary>
    /// A series or set of books.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#Series"></see></summary>
    let Series = _prefix "Series"
    /// <summary>
    /// This class models companies that develop software and sell it.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#SoftwareCompany"></see></summary>
    let SoftwareCompany = _prefix "SoftwareCompany"
    /// <summary>
    /// This class represents all kinds of researchers who are students.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#Student"></see></summary>
    let Student = _prefix "Student"
    /// <summary>
    /// This class represents all kinds of administrative staff that is employed for technical issues. Examples are system administrators, hardware specialists, etc.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#TechnicalStaff"></see></summary>
    let TechnicalStaff = _prefix "TechnicalStaff"
    /// <summary>
    /// A report published by a school or other organization, usually numbered within a series (&lt;link&gt;Series&lt;/link&gt;). This concept has been merged from BibTex's techreport and manual types, since both are described very similiar.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#Techreport"></see></summary>
    let Techreport = _prefix "Techreport"
    /// <summary>
    /// This class represents any kind of software tool. At the moment, this class is clearly underspecified.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#Tool"></see></summary>
    let Tool = _prefix "Tool"
    /// <summary>
    /// All research topics inherit from this concept. This should serve as a plugin point for the research topic ontology.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#Topic"></see></summary>
    let Topic = _prefix "Topic"
    /// <summary>
    /// This class represents all kinds of tutorials.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#Tutorial"></see></summary>
    let Tutorial = _prefix "Tutorial"
    /// <summary>
    /// This class represents universities. We decided to introduce two different classes to distinguish between universities and independent research institutes. The main difference is actually the different kinds of independence. In contrast to a university, a research institute is independent from the rigorous bureaucracy of the mainly state-run universities. On the other hand, a university is independent from the economy and the financial support of companies. Thus, the kind of research an independent research institute practises is generally more application-oriented.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#University"></see></summary>
    let University = _prefix "University"
    /// <summary>
    /// An individual volume of some &lt;link&gt;Journal&lt;/link&gt;.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#Volume"></see></summary>
    let Volume = _prefix "Volume"
    /// <summary>
    /// A work package is a subdivision of a project. It stands in a part-of relationship to &lt;link&gt;foaf:Project&lt;/link&gt;.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#WorkPackage"></see></summary>
    let WorkPackage = _prefix "WorkPackage"
    /// <summary>
    /// A working group is similar to &lt;link&gt;Initiative&lt;/link&gt;. We might unify two classes into one in the future.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#WorkingGroup"></see></summary>
    let WorkingGroup = _prefix "WorkingGroup"
    /// <summary>
    /// This class represents all kinds of workshops
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#Workshop"></see></summary>
    let Workshop = _prefix "Workshop"
    /// <summary>
    /// The first &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#agent_1"></see></summary>
    let agent_1 = _prefix "agent_1"
    /// <summary>
    /// The tenth &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#agent_10"></see></summary>
    let agent_10 = _prefix "agent_10"
    /// <summary>
    /// The second &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#agent_2"></see></summary>
    let agent_2 = _prefix "agent_2"
    /// <summary>
    /// The third &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#agent_3"></see></summary>
    let agent_3 = _prefix "agent_3"
    /// <summary>
    /// The fourth &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#agent_4"></see></summary>
    let agent_4 = _prefix "agent_4"
    /// <summary>
    /// The fifth &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#agent_5"></see></summary>
    let agent_5 = _prefix "agent_5"
    /// <summary>
    /// The sixth &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#agent_6"></see></summary>
    let agent_6 = _prefix "agent_6"
    /// <summary>
    /// The seventh &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#agent_7"></see></summary>
    let agent_7 = _prefix "agent_7"
    /// <summary>
    /// The eigth &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#agent_8"></see></summary>
    let agent_8 = _prefix "agent_8"
    /// <summary>
    /// The ninth &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#agent_9"></see></summary>
    let agent_9 = _prefix "agent_9"
    /// <summary>
    /// The school where a thesis was written.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#atSchool"></see></summary>
    let atSchool = _prefix "atSchool"
    /// <summary>
    /// Defines what project a workpackage belongs to.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#belongsToProject"></see></summary>
    let belongsToProject = _prefix "belongsToProject"
    /// <summary>
    /// The work packages of a project.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#hasWorkpackages"></see></summary>
    let hasWorkpackages = _prefix "hasWorkpackages"
    /// <summary>
    /// The &lt;link&gt;Book&lt;/link&gt; in which an Inbook is contained.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#containedInBook"></see></summary>
    let containedInBook = _prefix "containedInBook"
    /// <summary>
    /// The chapters or similar which a book contains.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#containsChapters"></see></summary>
    let containsChapters = _prefix "containsChapters"
    /// <summary>
    /// The journal or magazine which contains this article.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#containedInJournal"></see></summary>
    let containedInJournal = _prefix "containedInJournal"
    /// <summary>
    /// The articles or papers which a journal containes.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#containsArticles"></see></summary>
    let containsArticles = _prefix "containsArticles"
    /// <summary>
    /// The proceedings some paper or similar is contained in.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#containedInProceedings"></see></summary>
    let containedInProceedings = _prefix "containedInProceedings"
    /// <summary>
    /// The papers or similar which a proceedings contains.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#containsPapers"></see></summary>
    let containsPapers = _prefix "containsPapers"
    /// <summary>
    /// The deliverables for this project. The inverse is &lt;link&gt;forProject&lt;/link&gt;.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#deliverables"></see></summary>
    let deliverables = _prefix "deliverables"
    /// <summary>
    /// The project for which this deliverable is produced. The inverse is &lt;link&gt;deliverables&lt;/link&gt;.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#forProject"></see></summary>
    let forProject = _prefix "forProject"
    /// <summary>
    /// The &lt;link&gt;foaf:Agent&lt;/link&gt; this project is driven by. This is inverse to &lt;link&gt;foaf:currentProject&lt;/link&gt;. NOTE: How do we deal with the relation between drivenBy and &lt;link&gt;foaf:pastProject&lt;/link&gt;?
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#drivenBy"></see></summary>
    let drivenBy = _prefix "drivenBy"
    /// <summary>
    ///   <see href="http://sw-portal.deri.org/ontologies/swportal#editedBy"></see>
    /// </summary>
    let editedBy = _prefix "editedBy"
    /// <summary>
    /// The organization that sponsors a conference or that publishes a manual or techreport.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#fromOrganization"></see></summary>
    let fromOrganization = _prefix "fromOrganization"
    /// <summary>
    /// This property relates an agent to the presentations it gives. The inverse property is &lt;link&gt;presenter&lt;/link&gt;.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#givesPresentations"></see></summary>
    let givesPresentations = _prefix "givesPresentations"
    /// <summary>
    /// The presenter of a presentation.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#hasPresenter"></see></summary>
    let hasPresenter = _prefix "hasPresenter"
    /// <summary>
    /// This property relates an agent to the tutorials it gives. The inverse property is &lt;link&gt;tutoredBy&lt;/link&gt;.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#givesTutorials"></see></summary>
    let givesTutorials = _prefix "givesTutorials"
    /// <summary>
    /// The tutors of a tutorial.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#hasTutor"></see></summary>
    let hasTutor = _prefix "hasTutor"
    /// <summary>
    /// This property relates an agent to its address.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#hasAddress"></see></summary>
    let hasAddress = _prefix "hasAddress"
    /// <summary>
    /// The author or authors of a document. For multiple authors, use either an instance of &lt;link&gt;foaf:Group&lt;/link&gt;, or multiple values.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#hasAuthors"></see></summary>
    let hasAuthors = _prefix "hasAuthors"
    /// <summary>
    /// The duration of a temporary group.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#hasDuration"></see></summary>
    let hasDuration = _prefix "hasDuration"
    /// <summary>
    /// The ending date some event.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#hasEnddate"></see></summary>
    let hasEnddate = _prefix "hasEnddate"
    /// <summary>
    /// The time when some event ends.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#hasEndtime"></see></summary>
    let hasEndtime = _prefix "hasEndtime"
    /// <summary>
    /// The faxnumber of some &lt;link&gt;foaf:Agent&lt;/link&gt;.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#hasFax"></see></summary>
    let hasFax = _prefix "hasFax"
    /// <summary>
    /// The goal a group aims at. NOTE: &lt;link&gt;foaf:theme&lt;/link&gt; provides a similar functionality.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#hasGoal"></see></summary>
    let hasGoal = _prefix "hasGoal"
    /// <summary>
    /// The fields of interest of a person.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#hasInterests"></see></summary>
    let hasInterests = _prefix "hasInterests"
    /// <summary>
    /// This property defines the leader of an organization, i.e. its director, chairman, etc.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#hasLeader"></see></summary>
    let hasLeader = _prefix "hasLeader"
    /// <summary>
    /// The agent who is giving the lecture.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#hasLecturer"></see></summary>
    let hasLecturer = _prefix "hasLecturer"
    /// <summary>
    /// The &lt;link&gt;Location&lt;/link&gt; of an &lt;link&gt;Event&lt;/link&gt;.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#hasLocation"></see></summary>
    let hasLocation = _prefix "hasLocation"
    /// <summary>
    /// The number of a journal, magazine, techreport, or of a work in a series. An issue of a journal or magazine is usually identified by its volume and number; the organization that issues a technical report usually gives it a number; and sometimes books are given numbers in a numbered series. Deliverables for a project may also be given numbers.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#hasNumber"></see></summary>
    let hasNumber = _prefix "hasNumber"
    /// <summary>
    /// The PO-Box of some &lt;link&gt;PostalAddress&lt;/link&gt;.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#hasPostbox"></see></summary>
    let hasPostbox = _prefix "hasPostbox"
    /// <summary>
    /// The presentations that are offered during the course of an event.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#hasPresenations"></see></summary>
    let hasPresenations = _prefix "hasPresenations"
    /// <summary>
    /// The date of publication of some publication or software. Bibtex defines year and month. These are here combined to publicationDate.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#hasPublicationDate"></see></summary>
    let hasPublicationDate = _prefix "hasPublicationDate"
    /// <summary>
    /// The areas of research some research institute is involved in.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#hasResearchAreas"></see></summary>
    let hasResearchAreas = _prefix "hasResearchAreas"
    /// <summary>
    /// The starting date some event.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#hasStartdate"></see></summary>
    let hasStartdate = _prefix "hasStartdate"
    /// <summary>
    /// The time when some event starts.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#hasStarttime"></see></summary>
    let hasStarttime = _prefix "hasStarttime"
    /// <summary>
    /// The street address part of an &lt;link&gt;PostalAddress&lt;/link&gt;. Can have multiple lines.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#hasStreetAddress"></see></summary>
    let hasStreetAddress = _prefix "hasStreetAddress"
    /// <summary>
    /// The tasks of a member of the administrative staff.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#hasTasks"></see></summary>
    let hasTasks = _prefix "hasTasks"
    /// <summary>
    /// The tutorials that are offered during the course of an event.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#hasTutorials"></see></summary>
    let hasTutorials = _prefix "hasTutorials"
    /// <summary>
    /// The &lt;link&gt;Volume&lt;/link&gt;s of this journal.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#hasVolumes"></see></summary>
    let hasVolumes = _prefix "hasVolumes"
    /// <summary>
    /// The &lt;link&gt;Journal&lt;/link&gt; this volume belongs to.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#ofJournal"></see></summary>
    let ofJournal = _prefix "ofJournal"
    /// <summary>
    /// The zipcode of some &lt;link&gt;PostalAddress&lt;/link&gt; (if applicable). This is simply a string with no prescribed syntax.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#hasZipcode"></see></summary>
    let hasZipcode = _prefix "hasZipcode"
    /// <summary>
    /// How something strange has been published.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#howPublished"></see></summary>
    let howPublished = _prefix "howPublished"
    /// <summary>
    /// The &lt;link&gt;City&lt;/link&gt; in which some &lt;link&gt;SubCity&lt;/link&gt; is contained.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#inCity"></see></summary>
    let inCity = _prefix "inCity"
    /// <summary>
    /// The &lt;link&gt;Continent&lt;/link&gt; in which some &lt;link&gt;SubContinent&lt;/link&gt; is contained.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#inContinent"></see></summary>
    let inContinent = _prefix "inContinent"
    /// <summary>
    /// The &lt;link&gt;Country&lt;/link&gt; in which some &lt;link&gt;SubCountry&lt;/link&gt; is contained.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#inCountry"></see></summary>
    let inCountry = _prefix "inCountry"
    /// <summary>
    /// The &lt;link&gt;Region&lt;/link&gt; in which some &lt;link&gt;SubRegion&lt;/link&gt; is contained.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#inRegion"></see></summary>
    let inRegion = _prefix "inRegion"
    /// <summary>
    /// The instance of &lt;link&gt;Series&lt;/link&gt; in which this document was published.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#inSeries"></see></summary>
    let inSeries = _prefix "inSeries"
    /// <summary>
    /// The chapter (or section or whatever) number which this &lt;link&gt;Inbook&lt;/link&gt; represents.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#isChapter"></see></summary>
    let isChapter = _prefix "isChapter"
    /// <summary>
    /// The edition of a book---for example, ``Second''. This should be an ordinal, and should have the first letter capitalized, as shown here; the standard styles convert to lower case when necessary.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#isEdition"></see></summary>
    let isEdition = _prefix "isEdition"
    /// <summary>
    /// The version number of a document or tool.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#isVersion"></see></summary>
    let isVersion = _prefix "isVersion"
    /// <summary>
    /// The volume of a journal or a multi-volume book.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#isVolume"></see></summary>
    let isVolume = _prefix "isVolume"
    /// <summary>
    /// This property defines the products of a company.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#makesProducts"></see></summary>
    let makesProducts = _prefix "makesProducts"
    /// <summary>
    /// One or more page numbers or range of numbers, such as 42--111 or 7,41,73--97 or 43+ (the `+' in this last example indicates pages following that don't form a simple range). To make it easier to maintain Scribe-compatible databases, the standard styles convert a single dash (as in 7-33) to the double dash used in TeX to denote number ranges (as in 7--33).
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#onPages"></see></summary>
    let onPages = _prefix "onPages"
    /// <summary>
    /// The organizers of an event. At least one agent has to organize an event. The inverse property is &lt;link&gt;organizes&lt;/link&gt;.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#organizedby"></see></summary>
    let organizedby = _prefix "organizedby"
    /// <summary>
    /// This property relates an agent to the events it organizes. The inverse property is &lt;link&gt;organizedBy&lt;/link&gt;.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#organizes"></see></summary>
    let organizes = _prefix "organizes"
    /// <summary>
    /// The instance of &lt;link&gt;Publisher&lt;/link&gt; which published this document.
    /// <see href="http://sw-portal.deri.org/ontologies/swportal#publishedBy"></see></summary>
    let publishedBy = _prefix "publishedBy"

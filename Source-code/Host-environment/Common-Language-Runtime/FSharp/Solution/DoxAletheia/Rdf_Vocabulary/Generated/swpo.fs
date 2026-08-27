namespace http.sw_portal.deri.org.ontologies.swportal.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swpo =
    let _namespace_iri = Namespace_Iri swpo |> NamespaceIRI
    /// <summary>
    ///   <para>swpo:AdministrativeStaff</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents administrative staff."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Administrative Staff"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#AdministrativeStaff">http://sw-portal.deri.org/ontologies/swportal#AdministrativeStaff</seealso>
    let AdministrativeStaff = Prefixed_Name(swpo, "AdministrativeStaff") |> PrefixedName
    /// <summary>
    ///   <para>swpo:AgentSequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This is an adhoc solution for creating and ordered group of Agents, e.g. an authorlist."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#AgentSequence">http://sw-portal.deri.org/ontologies/swportal#AgentSequence</seealso>
    let AgentSequence = Prefixed_Name(swpo, "AgentSequence") |> PrefixedName
    /// <summary>
    ///   <para>swpo:Article</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An article from a journal or magazine."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Article"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#Article">http://sw-portal.deri.org/ontologies/swportal#Article</seealso>
    let Article = Prefixed_Name(swpo, "Article") |> PrefixedName
    /// <summary>
    ///   <para>swpo:Book</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A book with an explicit publisher. NOTES: - Either &lt;link&gt;authors&lt;/link&gt; or &lt;link&gt;editedBy&lt;/link&gt; must be given - Either &lt;link&gt;volume&lt;/link&gt; or &lt;link&gt;number&lt;/link&gt; may be given."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Book"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#Book">http://sw-portal.deri.org/ontologies/swportal#Book</seealso>
    let Book = Prefixed_Name(swpo, "Book") |> PrefixedName
    /// <summary>
    ///   <para>swpo:Booklet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A work that is printed and bound, but without a named publisher or sponsoring institution."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Booklet"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#Booklet">http://sw-portal.deri.org/ontologies/swportal#Booklet</seealso>
    let Booklet = Prefixed_Name(swpo, "Booklet") |> PrefixedName
    /// <summary>
    ///   <para>swpo:City</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class defines geopraphical bodies that are cities."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"City"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#City">http://sw-portal.deri.org/ontologies/swportal#City</seealso>
    let City = Prefixed_Name(swpo, "City") |> PrefixedName
    /// <summary>
    ///   <para>swpo:ClericalStaff</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents all kinds of administrative staff that is related to clerical support. Examples are secretaries, accountants, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>""</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#ClericalStaff">http://sw-portal.deri.org/ontologies/swportal#ClericalStaff</seealso>
    let ClericalStaff = Prefixed_Name(swpo, "ClericalStaff") |> PrefixedName
    /// <summary>
    ///   <para>swpo:Cluster</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Cluster is a kind of group which focuses on a research area and typically is part of a research institute or university."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cluster"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#Cluster">http://sw-portal.deri.org/ontologies/swportal#Cluster</seealso>
    let Cluster = Prefixed_Name(swpo, "Cluster") |> PrefixedName
    /// <summary>
    ///   <para>swpo:Company</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents all kinds of companies. Currently only publishers and software developers are modelled."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Company"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#Company">http://sw-portal.deri.org/ontologies/swportal#Company</seealso>
    let Company = Prefixed_Name(swpo, "Company") |> PrefixedName
    /// <summary>
    ///   <para>swpo:Conference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents all kinds of conferences in the academic domain."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Conference"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#Conference">http://sw-portal.deri.org/ontologies/swportal#Conference</seealso>
    let Conference = Prefixed_Name(swpo, "Conference") |> PrefixedName
    /// <summary>
    ///   <para>swpo:Continent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class defines geopraphical bodies that are continents."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Continent"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#Continent">http://sw-portal.deri.org/ontologies/swportal#Continent</seealso>
    let Continent = Prefixed_Name(swpo, "Continent") |> PrefixedName
    /// <summary>
    ///   <para>swpo:Country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class defines geopraphical bodies that are countries."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Country"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#Country">http://sw-portal.deri.org/ontologies/swportal#Country</seealso>
    let Country = Prefixed_Name(swpo, "Country") |> PrefixedName
    /// <summary>
    ///   <para>swpo:Deliverable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document which is produced as part of a project. Deliverables are not formally published. NOTE: This concept was not derived from any of the BibTex types, but considered useful anyway."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Deliverable"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#Deliverable">http://sw-portal.deri.org/ontologies/swportal#Deliverable</seealso>
    let Deliverable = Prefixed_Name(swpo, "Deliverable") |> PrefixedName
    /// <summary>
    ///   <para>swpo:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents events relevant for the area of teaching, research, business, i.e. conferences, presentations, tutorials, workshops and lectures."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Event"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#Event">http://sw-portal.deri.org/ontologies/swportal#Event</seealso>
    let Event = Prefixed_Name(swpo, "Event") |> PrefixedName
    /// <summary>
    ///   <para>swpo:Inbook</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A part of a Book, which may be a chapter (or section or whatever) and/or a range of pages. Because the BibTex types inCollection and inBook are very similiar, we decided to keep the ontology as simple as possible and merge them both into &lt;link&gt;Inbook&lt;/link&gt;."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Inbook"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#Inbook">http://sw-portal.deri.org/ontologies/swportal#Inbook</seealso>
    let Inbook = Prefixed_Name(swpo, "Inbook") |> PrefixedName

    /// <summary>
    ///   <para>swpo:IndividualPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The instances of this class comprise all publications which have a specific publication date. If a publication P is contained within an &lt;link&gt;PublicationContainer&lt;/link&gt;, and this container has a publication date, than P is not an &lt;link&gt;IndividualPublication&lt;/link&gt;. Example: an &lt;link&gt;Inbook&lt;/link&gt; publication is not an &lt;link&gt;IndividualPublication&lt;/link&gt;, because its publication date can be inferred from the &lt;link&gt;Book&lt;/link&gt; which contains it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dated Publication"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#IndividualPublication">http://sw-portal.deri.org/ontologies/swportal#IndividualPublication</seealso>
    let IndividualPublication =
        Prefixed_Name(swpo, "IndividualPublication") |> PrefixedName

    /// <summary>
    ///   <para>swpo:Initiative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An initiative is a group which has specific aims. It differs from &lt;link&gt;foaf:Project&lt;/link&gt; in that it normally doesn’t have any funding. Often, its duration is longer."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Initiative"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#Initiative">http://sw-portal.deri.org/ontologies/swportal#Initiative</seealso>
    let Initiative = Prefixed_Name(swpo, "Initiative") |> PrefixedName
    /// <summary>
    ///   <para>swpo:Inproceedings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An article in a conference proceedings (i.e. Proceedings)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Inproceedings"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#Inproceedings">http://sw-portal.deri.org/ontologies/swportal#Inproceedings</seealso>
    let Inproceedings = Prefixed_Name(swpo, "Inproceedings") |> PrefixedName
    /// <summary>
    ///   <para>swpo:Journal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A scientific journal or magazine. The instances of this class are not individual issues or voulumes of a journal, but the journal as such."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Journal"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#Journal">http://sw-portal.deri.org/ontologies/swportal#Journal</seealso>
    let Journal = Prefixed_Name(swpo, "Journal") |> PrefixedName
    /// <summary>
    ///   <para>swpo:Lecture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents lectures with an educational purpose, e.g within a university."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Lecture"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#Lecture">http://sw-portal.deri.org/ontologies/swportal#Lecture</seealso>
    let Lecture = Prefixed_Name(swpo, "Lecture") |> PrefixedName
    /// <summary>
    ///   <para>swpo:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class is the superclass for all classes defining geographical locations. The approach for this subontology is to have a hierarchy of location classes, such that instances of the classes further down in the hierarchy can be contained in instances of the classes higher up in the hierarchy. On each level, there exist two sister classes: class L defines a certain type of location, while class SubL defines locations which can be contained in instances of L. SubL then defines a property inL, to express which instance of L an instance of SubL is contained in. E.g. for a class Continent, there exists a class SubContinent. All children of SubContinent (either direct or transitive) define locations that can be contained in a continent, such as countries, regions, cities, etc. By virtue of inheritance, all these location classes then have a property inContinent, to express that they are contained in some continent. In a simpler, flat structure, inContinent would have to be defined explicitly for all kinds of locations that can be contained in a continent.
    /// The intepretation of the inL predicates should be as follows: if, for a particular instance K, inL has a value, this value is valid. If inL has no value, the value of inL in the next location K is contained in valid, and so forth. E.g. an instance "Hawaii" has the value "Oceania" defined for &lt;link&gt;inContinent&lt;/link&gt; and "USA" for &lt;link&gt;inCountry&lt;/link&gt;. "Delaware" has no value for inContinent. "USA" has the value "North America" for &lt;link&gt;inContinent&lt;/link&gt;. The interpretation would be that "Hawaii" is located in "Oceania", while "Delaware" is located in "North America".
    /// We are aware of the fact that this approach is idealized and can therefore conflict with reality in some situations. E.g., the exact borders of continents are not always defined (there are contradicting opinions on where exactly Europe begins or ends). Countries could be contained in more than one continent (Turkey belongs to both Europe and Asia). However, we think that these situations are marginal and have little or no impact on the intended use of this ontology.
    /// We think that this recursive modelling of locations is at the same time simple and powerful enough to capture all necessary aspects of the concept of location for a domain such as an SWPortal. While the SubL classes might appear to be somewhat artificial, they are actually not. They are just an abstraction for geographical entities that are (under normal circumstances) smaller than entities of type L. As such, they are no more abstract than, say, the concept of an agent.
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Location"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#Location">http://sw-portal.deri.org/ontologies/swportal#Location</seealso>
    let Location = Prefixed_Name(swpo, "Location") |> PrefixedName
    /// <summary>
    ///   <para>swpo:ManagementStaff</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the management staff."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Management Staff"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#ManagementStaff">http://sw-portal.deri.org/ontologies/swportal#ManagementStaff</seealso>
    let ManagementStaff = Prefixed_Name(swpo, "ManagementStaff") |> PrefixedName
    /// <summary>
    ///   <para>swpo:MasterThesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A thesis written to receive a Master degree."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Master Thesis"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#MasterThesis">http://sw-portal.deri.org/ontologies/swportal#MasterThesis</seealso>
    let MasterThesis = Prefixed_Name(swpo, "MasterThesis") |> PrefixedName
    /// <summary>
    ///   <para>swpo:Misc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Some sort of publication which doesn't fit into any of the other concepts."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Misc"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#Misc">http://sw-portal.deri.org/ontologies/swportal#Misc</seealso>
    let Misc = Prefixed_Name(swpo, "Misc") |> PrefixedName
    /// <summary>
    ///   <para>swpo:NewsItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class is the super-class for any kind of news item."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"News Item"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#NewsItem">http://sw-portal.deri.org/ontologies/swportal#NewsItem</seealso>
    let NewsItem = Prefixed_Name(swpo, "NewsItem") |> PrefixedName
    /// <summary>
    ///   <para>swpo:Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents an organization with a formal legal status. We introduce this class as a subclass of &lt;link&gt;foaf:Organization&lt;/link&gt; and &lt;link&gt;foaf:Group&lt;/link&gt;, because we consider an organization as a kind of group."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Organization"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#Organization">http://sw-portal.deri.org/ontologies/swportal#Organization</seealso>
    let Organization = Prefixed_Name(swpo, "Organization") |> PrefixedName
    /// <summary>
    ///   <para>swpo:PhDThesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A thesis written to receive a PhD degree."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PhD Thesis"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#PhDThesis">http://sw-portal.deri.org/ontologies/swportal#PhDThesis</seealso>
    let PhDThesis = Prefixed_Name(swpo, "PhDThesis") |> PrefixedName
    /// <summary>
    ///   <para>swpo:PostalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Instances of this class represent exact postal addresses. Note that either &lt;link&gt;postbox&lt;/link&gt; of &lt;link&gt;streetAddress&lt;/link&gt; should be given."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Postal Address"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#PostalAddress">http://sw-portal.deri.org/ontologies/swportal#PostalAddress</seealso>
    let PostalAddress = Prefixed_Name(swpo, "PostalAddress") |> PrefixedName
    /// <summary>
    ///   <para>swpo:Presentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents all kinds of presentations."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Presentation"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#Presentation">http://sw-portal.deri.org/ontologies/swportal#Presentation</seealso>
    let Presentation = Prefixed_Name(swpo, "Presentation") |> PrefixedName
    /// <summary>
    ///   <para>swpo:Proceedings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The proceedings of a conference."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Proceedings"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#Proceedings">http://sw-portal.deri.org/ontologies/swportal#Proceedings</seealso>
    let Proceedings = Prefixed_Name(swpo, "Proceedings") |> PrefixedName
    /// <summary>
    ///   <para>swpo:Publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Publications are both individual documents and collections of documents such as series, journals, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Publication"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#Publication">http://sw-portal.deri.org/ontologies/swportal#Publication</seealso>
    let Publication = Prefixed_Name(swpo, "Publication") |> PrefixedName

    /// <summary>
    ///   <para>swpo:PublicationContainer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class comprises all kinds of publications which contain other publications, such as journal, proceedings, series, etc. An instance of PublicationContainer has an editor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Publication Container"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#PublicationContainer">http://sw-portal.deri.org/ontologies/swportal#PublicationContainer</seealso>
    let PublicationContainer =
        Prefixed_Name(swpo, "PublicationContainer") |> PrefixedName

    /// <summary>
    ///   <para>swpo:PublishingCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class models companies that publish documents."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Publishing Company"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#PublishingCompany">http://sw-portal.deri.org/ontologies/swportal#PublishingCompany</seealso>
    let PublishingCompany = Prefixed_Name(swpo, "PublishingCompany") |> PrefixedName
    /// <summary>
    ///   <para>swpo:Region</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class defines geopraphical bodies that are regions, with the intended meaning "sub-division of a country"."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Region"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#Region">http://sw-portal.deri.org/ontologies/swportal#Region</seealso>
    let Region = Prefixed_Name(swpo, "Region") |> PrefixedName
    /// <summary>
    ///   <para>swpo:ResearchInstitute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents research institutes. These organizations have special research areas."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Research Institute"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#ResearchInstitute">http://sw-portal.deri.org/ontologies/swportal#ResearchInstitute</seealso>
    let ResearchInstitute = Prefixed_Name(swpo, "ResearchInstitute") |> PrefixedName
    /// <summary>
    ///   <para>swpo:ResearchStaff</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents all kinds of researchers who are not students."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Research Staff"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#ResearchStaff">http://sw-portal.deri.org/ontologies/swportal#ResearchStaff</seealso>
    let ResearchStaff = Prefixed_Name(swpo, "ResearchStaff") |> PrefixedName
    /// <summary>
    ///   <para>swpo:Researcher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents all kinds of persons who are researchers. Each has a research area."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Researcher"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#Researcher">http://sw-portal.deri.org/ontologies/swportal#Researcher</seealso>
    let Researcher = Prefixed_Name(swpo, "Researcher") |> PrefixedName
    /// <summary>
    ///   <para>swpo:Series</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A series or set of books."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Series"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#Series">http://sw-portal.deri.org/ontologies/swportal#Series</seealso>
    let Series = Prefixed_Name(swpo, "Series") |> PrefixedName
    /// <summary>
    ///   <para>swpo:SoftwareCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class models companies that develop software and sell it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Software Company"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#SoftwareCompany">http://sw-portal.deri.org/ontologies/swportal#SoftwareCompany</seealso>
    let SoftwareCompany = Prefixed_Name(swpo, "SoftwareCompany") |> PrefixedName
    /// <summary>
    ///   <para>swpo:Student</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents all kinds of researchers who are students."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Student"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#Student">http://sw-portal.deri.org/ontologies/swportal#Student</seealso>
    let Student = Prefixed_Name(swpo, "Student") |> PrefixedName
    /// <summary>
    ///   <para>swpo:SubCity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class defines geopraphical bodies that can be contained in cities."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sub-City"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#SubCity">http://sw-portal.deri.org/ontologies/swportal#SubCity</seealso>
    let SubCity = Prefixed_Name(swpo, "SubCity") |> PrefixedName
    /// <summary>
    ///   <para>swpo:SubContinent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class defines geopraphical bodies that can be contained in continents."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sub-Continent"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#SubContinent">http://sw-portal.deri.org/ontologies/swportal#SubContinent</seealso>
    let SubContinent = Prefixed_Name(swpo, "SubContinent") |> PrefixedName
    /// <summary>
    ///   <para>swpo:SubCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class defines geopraphical bodies that can be contained in countries."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sub-Country"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#SubCountry">http://sw-portal.deri.org/ontologies/swportal#SubCountry</seealso>
    let SubCountry = Prefixed_Name(swpo, "SubCountry") |> PrefixedName
    /// <summary>
    ///   <para>swpo:SubRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class defines geopraphical bodies that can be contained in regions."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sub-Region"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#SubRegion">http://sw-portal.deri.org/ontologies/swportal#SubRegion</seealso>
    let SubRegion = Prefixed_Name(swpo, "SubRegion") |> PrefixedName
    /// <summary>
    ///   <para>swpo:TechnicalStaff</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents all kinds of administrative staff that is employed for technical issues. Examples are system administrators, hardware specialists, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>""</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#TechnicalStaff">http://sw-portal.deri.org/ontologies/swportal#TechnicalStaff</seealso>
    let TechnicalStaff = Prefixed_Name(swpo, "TechnicalStaff") |> PrefixedName
    /// <summary>
    ///   <para>swpo:Techreport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A report published by a school or other organization, usually numbered within a series (&lt;link&gt;Series&lt;/link&gt;). This concept has been merged from BibTex's techreport and manual types, since both are described very similiar."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Techreport"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#Techreport">http://sw-portal.deri.org/ontologies/swportal#Techreport</seealso>
    let Techreport = Prefixed_Name(swpo, "Techreport") |> PrefixedName
    /// <summary>
    ///   <para>swpo:TemporaryGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"As &lt;link&gt;foaf:Project&lt;/link&gt;, &lt;link&gt;Initiative&lt;/link&gt; and &lt;link&gt;WorkingGroup&lt;/link&gt; differ from Cluster in having a specific duration, we comprise these there temporal groups in this class which represents all kinds of temporary groups."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Temporary Group"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#TemporaryGroup">http://sw-portal.deri.org/ontologies/swportal#TemporaryGroup</seealso>
    let TemporaryGroup = Prefixed_Name(swpo, "TemporaryGroup") |> PrefixedName
    /// <summary>
    ///   <para>swpo:Thesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any kind of thesis produced to receive some sort of university degree."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Thesis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#Thesis">http://sw-portal.deri.org/ontologies/swportal#Thesis</seealso>
    let Thesis = Prefixed_Name(swpo, "Thesis") |> PrefixedName
    /// <summary>
    ///   <para>swpo:Tool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents any kind of software tool. At the moment, this class is clearly underspecified."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Tool"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#Tool">http://sw-portal.deri.org/ontologies/swportal#Tool</seealso>
    let Tool = Prefixed_Name(swpo, "Tool") |> PrefixedName
    /// <summary>
    ///   <para>swpo:Topic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"All research topics inherit from this concept. This should serve as a plugin point for the research topic ontology."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Topic"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#Topic">http://sw-portal.deri.org/ontologies/swportal#Topic</seealso>
    let Topic = Prefixed_Name(swpo, "Topic") |> PrefixedName
    /// <summary>
    ///   <para>swpo:Tutorial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents all kinds of tutorials."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Tutorial"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#Tutorial">http://sw-portal.deri.org/ontologies/swportal#Tutorial</seealso>
    let Tutorial = Prefixed_Name(swpo, "Tutorial") |> PrefixedName
    /// <summary>
    ///   <para>swpo:University</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents universities. We decided to introduce two different classes to distinguish between universities and independent research institutes. The main difference is actually the different kinds of independence. In contrast to a university, a research institute is independent from the rigorous bureaucracy of the mainly state-run universities. On the other hand, a university is independent from the economy and the financial support of companies. Thus, the kind of research an independent research institute practises is generally more application-oriented."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"University"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#University">http://sw-portal.deri.org/ontologies/swportal#University</seealso>
    let University = Prefixed_Name(swpo, "University") |> PrefixedName
    /// <summary>
    ///   <para>swpo:Unpublished</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document which does have an author and title, but hasn't been formally published."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Unpublished"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#Unpublished">http://sw-portal.deri.org/ontologies/swportal#Unpublished</seealso>
    let Unpublished = Prefixed_Name(swpo, "Unpublished") |> PrefixedName
    /// <summary>
    ///   <para>swpo:Volume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An individual volume of some &lt;link&gt;Journal&lt;/link&gt;."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#Volume">http://sw-portal.deri.org/ontologies/swportal#Volume</seealso>
    let Volume = Prefixed_Name(swpo, "Volume") |> PrefixedName
    /// <summary>
    ///   <para>swpo:WorkPackage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A work package is a subdivision of a project. It stands in a part-of relationship to &lt;link&gt;foaf:Project&lt;/link&gt;."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Work Package"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#WorkPackage">http://sw-portal.deri.org/ontologies/swportal#WorkPackage</seealso>
    let WorkPackage = Prefixed_Name(swpo, "WorkPackage") |> PrefixedName
    /// <summary>
    ///   <para>swpo:WorkingGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A working group is similar to &lt;link&gt;Initiative&lt;/link&gt;. We might unify two classes into one in the future."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Working Group"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#WorkingGroup">http://sw-portal.deri.org/ontologies/swportal#WorkingGroup</seealso>
    let WorkingGroup = Prefixed_Name(swpo, "WorkingGroup") |> PrefixedName
    /// <summary>
    ///   <para>swpo:Workshop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents all kinds of workshops"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Workshop"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#Workshop">http://sw-portal.deri.org/ontologies/swportal#Workshop</seealso>
    let Workshop = Prefixed_Name(swpo, "Workshop") |> PrefixedName
    /// <summary>
    ///   <para>swpo:agent_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The first &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"First"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#agent_1">http://sw-portal.deri.org/ontologies/swportal#agent_1</seealso>
    let agent_1 = Prefixed_Name(swpo, "agent_1") |> PrefixedName
    /// <summary>
    ///   <para>swpo:agent_10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The tenth &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Tenth"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#agent_10">http://sw-portal.deri.org/ontologies/swportal#agent_10</seealso>
    let agent_10 = Prefixed_Name(swpo, "agent_10") |> PrefixedName
    /// <summary>
    ///   <para>swpo:agent_2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The second &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Second"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#agent_2">http://sw-portal.deri.org/ontologies/swportal#agent_2</seealso>
    let agent_2 = Prefixed_Name(swpo, "agent_2") |> PrefixedName
    /// <summary>
    ///   <para>swpo:agent_3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The third &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Third"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#agent_3">http://sw-portal.deri.org/ontologies/swportal#agent_3</seealso>
    let agent_3 = Prefixed_Name(swpo, "agent_3") |> PrefixedName
    /// <summary>
    ///   <para>swpo:agent_4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The fourth &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fourth"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#agent_4">http://sw-portal.deri.org/ontologies/swportal#agent_4</seealso>
    let agent_4 = Prefixed_Name(swpo, "agent_4") |> PrefixedName
    /// <summary>
    ///   <para>swpo:agent_5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The fifth &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fifth"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#agent_5">http://sw-portal.deri.org/ontologies/swportal#agent_5</seealso>
    let agent_5 = Prefixed_Name(swpo, "agent_5") |> PrefixedName
    /// <summary>
    ///   <para>swpo:agent_6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The sixth &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sixth"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#agent_6">http://sw-portal.deri.org/ontologies/swportal#agent_6</seealso>
    let agent_6 = Prefixed_Name(swpo, "agent_6") |> PrefixedName
    /// <summary>
    ///   <para>swpo:agent_7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The seventh &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Seventh"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#agent_7">http://sw-portal.deri.org/ontologies/swportal#agent_7</seealso>
    let agent_7 = Prefixed_Name(swpo, "agent_7") |> PrefixedName
    /// <summary>
    ///   <para>swpo:agent_8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The eigth &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Eigth"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#agent_8">http://sw-portal.deri.org/ontologies/swportal#agent_8</seealso>
    let agent_8 = Prefixed_Name(swpo, "agent_8") |> PrefixedName
    /// <summary>
    ///   <para>swpo:agent_9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The ninth &lt;link&gt;foaf:Agent&lt;/link&gt; in an &lt;link&gt;AgentSequence&lt;/link&gt;."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ninth"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#agent_9">http://sw-portal.deri.org/ontologies/swportal#agent_9</seealso>
    let agent_9 = Prefixed_Name(swpo, "agent_9") |> PrefixedName
    /// <summary>
    ///   <para>swpo:atSchool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The school where a thesis was written."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"At School"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#atSchool">http://sw-portal.deri.org/ontologies/swportal#atSchool</seealso>
    let atSchool = Prefixed_Name(swpo, "atSchool") |> PrefixedName
    /// <summary>
    ///   <para>swpo:belongsToProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Defines what project a workpackage belongs to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Belongs to Project"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#belongsToProject">http://sw-portal.deri.org/ontologies/swportal#belongsToProject</seealso>
    let belongsToProject = Prefixed_Name(swpo, "belongsToProject") |> PrefixedName
    /// <summary>
    ///   <para>swpo:containedInBook</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The &lt;link&gt;Book&lt;/link&gt; in which an Inbook is contained."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Contained in Book"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#containedInBook">http://sw-portal.deri.org/ontologies/swportal#containedInBook</seealso>
    let containedInBook = Prefixed_Name(swpo, "containedInBook") |> PrefixedName
    /// <summary>
    ///   <para>swpo:containedInJournal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The journal or magazine which contains this article."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Contained in Journal"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#containedInJournal">http://sw-portal.deri.org/ontologies/swportal#containedInJournal</seealso>
    let containedInJournal = Prefixed_Name(swpo, "containedInJournal") |> PrefixedName

    /// <summary>
    ///   <para>swpo:containedInProceedings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The proceedings some paper or similar is contained in."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Contained in Proceedings"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#containedInProceedings">http://sw-portal.deri.org/ontologies/swportal#containedInProceedings</seealso>
    let containedInProceedings =
        Prefixed_Name(swpo, "containedInProceedings") |> PrefixedName

    /// <summary>
    ///   <para>swpo:containsArticles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>"The articles or papers which a journal containes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Contains Articles"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#containsArticles">http://sw-portal.deri.org/ontologies/swportal#containsArticles</seealso>
    let containsArticles = Prefixed_Name(swpo, "containsArticles") |> PrefixedName
    /// <summary>
    ///   <para>swpo:containsChapters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The chapters or similar which a book contains."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Contains Chapters"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#containsChapters">http://sw-portal.deri.org/ontologies/swportal#containsChapters</seealso>
    let containsChapters = Prefixed_Name(swpo, "containsChapters") |> PrefixedName
    /// <summary>
    ///   <para>swpo:containsPapers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The papers or similar which a proceedings contains."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Contains Papers"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#containsPapers">http://sw-portal.deri.org/ontologies/swportal#containsPapers</seealso>
    let containsPapers = Prefixed_Name(swpo, "containsPapers") |> PrefixedName
    /// <summary>
    ///   <para>swpo:deliverables</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The deliverables for this project. The inverse is &lt;link&gt;forProject&lt;/link&gt;."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Deliverables"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#deliverables">http://sw-portal.deri.org/ontologies/swportal#deliverables</seealso>
    let deliverables = Prefixed_Name(swpo, "deliverables") |> PrefixedName
    /// <summary>
    ///   <para>swpo:drivenBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The &lt;link&gt;foaf:Agent&lt;/link&gt; this project is driven by. This is inverse to &lt;link&gt;foaf:currentProject&lt;/link&gt;. NOTE: How do we deal with the relation between drivenBy and &lt;link&gt;foaf:pastProject&lt;/link&gt;?"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Driven by"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#drivenBy">http://sw-portal.deri.org/ontologies/swportal#drivenBy</seealso>
    let drivenBy = Prefixed_Name(swpo, "drivenBy") |> PrefixedName
    /// <summary>
    ///   <para>swpo:editedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"Edited by"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#editedBy">http://sw-portal.deri.org/ontologies/swportal#editedBy</seealso>
    let editedBy = Prefixed_Name(swpo, "editedBy") |> PrefixedName
    /// <summary>
    ///   <para>swpo:forProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The project for which this deliverable is produced. The inverse is &lt;link&gt;deliverables&lt;/link&gt;."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"For Project"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#forProject">http://sw-portal.deri.org/ontologies/swportal#forProject</seealso>
    let forProject = Prefixed_Name(swpo, "forProject") |> PrefixedName
    /// <summary>
    ///   <para>swpo:fromOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The organization that sponsors a conference or that publishes a manual or techreport."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"From Organization"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#fromOrganization">http://sw-portal.deri.org/ontologies/swportal#fromOrganization</seealso>
    let fromOrganization = Prefixed_Name(swpo, "fromOrganization") |> PrefixedName
    /// <summary>
    ///   <para>swpo:givesPresentations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates an agent to the presentations it gives. The inverse property is &lt;link&gt;presenter&lt;/link&gt;."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Gives Presentations"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#givesPresentations">http://sw-portal.deri.org/ontologies/swportal#givesPresentations</seealso>
    let givesPresentations = Prefixed_Name(swpo, "givesPresentations") |> PrefixedName
    /// <summary>
    ///   <para>swpo:givesTutorials</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates an agent to the tutorials it gives. The inverse property is &lt;link&gt;tutoredBy&lt;/link&gt;."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Gives Tutorials"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#givesTutorials">http://sw-portal.deri.org/ontologies/swportal#givesTutorials</seealso>
    let givesTutorials = Prefixed_Name(swpo, "givesTutorials") |> PrefixedName
    /// <summary>
    ///   <para>swpo:hasAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates an agent to its address."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Address"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#hasAddress">http://sw-portal.deri.org/ontologies/swportal#hasAddress</seealso>
    let hasAddress = Prefixed_Name(swpo, "hasAddress") |> PrefixedName
    /// <summary>
    ///   <para>swpo:hasAuthors</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The author or authors of a document. For multiple authors, use either an instance of &lt;link&gt;foaf:Group&lt;/link&gt;, or multiple values."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Authors"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#hasAuthors">http://sw-portal.deri.org/ontologies/swportal#hasAuthors</seealso>
    let hasAuthors = Prefixed_Name(swpo, "hasAuthors") |> PrefixedName
    /// <summary>
    ///   <para>swpo:hasDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The duration of a temporary group."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Duration"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#hasDuration">http://sw-portal.deri.org/ontologies/swportal#hasDuration</seealso>
    let hasDuration = Prefixed_Name(swpo, "hasDuration") |> PrefixedName
    /// <summary>
    ///   <para>swpo:hasEnddate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The ending date some event. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Enddate"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#hasEnddate">http://sw-portal.deri.org/ontologies/swportal#hasEnddate</seealso>
    let hasEnddate = Prefixed_Name(swpo, "hasEnddate") |> PrefixedName
    /// <summary>
    ///   <para>swpo:hasEndtime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The time when some event ends. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Endtime"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#hasEndtime">http://sw-portal.deri.org/ontologies/swportal#hasEndtime</seealso>
    let hasEndtime = Prefixed_Name(swpo, "hasEndtime") |> PrefixedName
    /// <summary>
    ///   <para>swpo:hasFax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The faxnumber of some &lt;link&gt;foaf:Agent&lt;/link&gt;."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fax"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#hasFax">http://sw-portal.deri.org/ontologies/swportal#hasFax</seealso>
    let hasFax = Prefixed_Name(swpo, "hasFax") |> PrefixedName
    /// <summary>
    ///   <para>swpo:hasGoal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The goal a group aims at. NOTE: &lt;link&gt;foaf:theme&lt;/link&gt; provides a similar functionality."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Goal"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#hasGoal">http://sw-portal.deri.org/ontologies/swportal#hasGoal</seealso>
    let hasGoal = Prefixed_Name(swpo, "hasGoal") |> PrefixedName
    /// <summary>
    ///   <para>swpo:hasInterests</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The fields of interest of a person. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Interests"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#hasInterests">http://sw-portal.deri.org/ontologies/swportal#hasInterests</seealso>
    let hasInterests = Prefixed_Name(swpo, "hasInterests") |> PrefixedName
    /// <summary>
    ///   <para>swpo:hasLeader</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property defines the leader of an organization, i.e. its director, chairman, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Leader"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#hasLeader">http://sw-portal.deri.org/ontologies/swportal#hasLeader</seealso>
    let hasLeader = Prefixed_Name(swpo, "hasLeader") |> PrefixedName
    /// <summary>
    ///   <para>swpo:hasLecturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The agent who is giving the lecture."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Lecturer"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#hasLecturer">http://sw-portal.deri.org/ontologies/swportal#hasLecturer</seealso>
    let hasLecturer = Prefixed_Name(swpo, "hasLecturer") |> PrefixedName
    /// <summary>
    ///   <para>swpo:hasLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The &lt;link&gt;Location&lt;/link&gt; of an &lt;link&gt;Event&lt;/link&gt;."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Location"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#hasLocation">http://sw-portal.deri.org/ontologies/swportal#hasLocation</seealso>
    let hasLocation = Prefixed_Name(swpo, "hasLocation") |> PrefixedName
    /// <summary>
    ///   <para>swpo:hasNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"Note"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#hasNote">http://sw-portal.deri.org/ontologies/swportal#hasNote</seealso>
    let hasNote = Prefixed_Name(swpo, "hasNote") |> PrefixedName
    /// <summary>
    ///   <para>swpo:hasNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The number of a journal, magazine, techreport, or of a work in a series. An issue of a journal or magazine is usually identified by its volume and number; the organization that issues a technical report usually gives it a number; and sometimes books are given numbers in a numbered series. Deliverables for a project may also be given numbers."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Number"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#hasNumber">http://sw-portal.deri.org/ontologies/swportal#hasNumber</seealso>
    let hasNumber = Prefixed_Name(swpo, "hasNumber") |> PrefixedName
    /// <summary>
    ///   <para>swpo:hasPostbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The PO-Box of some &lt;link&gt;PostalAddress&lt;/link&gt;."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"POBox"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#hasPostbox">http://sw-portal.deri.org/ontologies/swportal#hasPostbox</seealso>
    let hasPostbox = Prefixed_Name(swpo, "hasPostbox") |> PrefixedName
    /// <summary>
    ///   <para>swpo:hasPresenations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The presentations that are offered during the course of an event."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Presentations"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#hasPresenations">http://sw-portal.deri.org/ontologies/swportal#hasPresenations</seealso>
    let hasPresenations = Prefixed_Name(swpo, "hasPresenations") |> PrefixedName
    /// <summary>
    ///   <para>swpo:hasPresenter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The presenter of a presentation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Presenter"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#hasPresenter">http://sw-portal.deri.org/ontologies/swportal#hasPresenter</seealso>
    let hasPresenter = Prefixed_Name(swpo, "hasPresenter") |> PrefixedName
    /// <summary>
    ///   <para>swpo:hasPublicationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The date of publication of some publication or software. Bibtex defines year and month. These are here combined to publicationDate."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Publication Date"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#hasPublicationDate">http://sw-portal.deri.org/ontologies/swportal#hasPublicationDate</seealso>
    let hasPublicationDate = Prefixed_Name(swpo, "hasPublicationDate") |> PrefixedName
    /// <summary>
    ///   <para>swpo:hasResearchAreas</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The areas of research some research institute is involved in. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Research Areas"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#hasResearchAreas">http://sw-portal.deri.org/ontologies/swportal#hasResearchAreas</seealso>
    let hasResearchAreas = Prefixed_Name(swpo, "hasResearchAreas") |> PrefixedName
    /// <summary>
    ///   <para>swpo:hasStartdate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The starting date some event."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Starting Date"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#hasStartdate">http://sw-portal.deri.org/ontologies/swportal#hasStartdate</seealso>
    let hasStartdate = Prefixed_Name(swpo, "hasStartdate") |> PrefixedName
    /// <summary>
    ///   <para>swpo:hasStarttime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The time when some event starts."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Starting Time"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#hasStarttime">http://sw-portal.deri.org/ontologies/swportal#hasStarttime</seealso>
    let hasStarttime = Prefixed_Name(swpo, "hasStarttime") |> PrefixedName
    /// <summary>
    ///   <para>swpo:hasStreetAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The street address part of an &lt;link&gt;PostalAddress&lt;/link&gt;. Can have multiple lines."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Street"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#hasStreetAddress">http://sw-portal.deri.org/ontologies/swportal#hasStreetAddress</seealso>
    let hasStreetAddress = Prefixed_Name(swpo, "hasStreetAddress") |> PrefixedName
    /// <summary>
    ///   <para>swpo:hasTasks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The tasks of a member of the administrative staff."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Tasks"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#hasTasks">http://sw-portal.deri.org/ontologies/swportal#hasTasks</seealso>
    let hasTasks = Prefixed_Name(swpo, "hasTasks") |> PrefixedName
    /// <summary>
    ///   <para>swpo:hasTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The title of the publication (book, article, ...) or publication container (series, journal)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Title"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#hasTitle">http://sw-portal.deri.org/ontologies/swportal#hasTitle</seealso>
    let hasTitle = Prefixed_Name(swpo, "hasTitle") |> PrefixedName
    /// <summary>
    ///   <para>swpo:hasTutor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The tutors of a tutorial."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Tutor"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#hasTutor">http://sw-portal.deri.org/ontologies/swportal#hasTutor</seealso>
    let hasTutor = Prefixed_Name(swpo, "hasTutor") |> PrefixedName
    /// <summary>
    ///   <para>swpo:hasTutorials</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The tutorials that are offered during the course of an event."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Tutorials"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#hasTutorials">http://sw-portal.deri.org/ontologies/swportal#hasTutorials</seealso>
    let hasTutorials = Prefixed_Name(swpo, "hasTutorials") |> PrefixedName
    /// <summary>
    ///   <para>swpo:hasVolumes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The &lt;link&gt;Volume&lt;/link&gt;s of this journal."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#hasVolumes">http://sw-portal.deri.org/ontologies/swportal#hasVolumes</seealso>
    let hasVolumes = Prefixed_Name(swpo, "hasVolumes") |> PrefixedName
    /// <summary>
    ///   <para>swpo:hasWorkpackages</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The work packages of a project."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Workpackages"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#hasWorkpackages">http://sw-portal.deri.org/ontologies/swportal#hasWorkpackages</seealso>
    let hasWorkpackages = Prefixed_Name(swpo, "hasWorkpackages") |> PrefixedName
    /// <summary>
    ///   <para>swpo:hasZipcode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The zipcode of some &lt;link&gt;PostalAddress&lt;/link&gt; (if applicable). This is simply a string with no prescribed syntax."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#hasZipcode">http://sw-portal.deri.org/ontologies/swportal#hasZipcode</seealso>
    let hasZipcode = Prefixed_Name(swpo, "hasZipcode") |> PrefixedName
    /// <summary>
    ///   <para>swpo:howPublished</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"How something strange has been published."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"How Published"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#howPublished">http://sw-portal.deri.org/ontologies/swportal#howPublished</seealso>
    let howPublished = Prefixed_Name(swpo, "howPublished") |> PrefixedName
    /// <summary>
    ///   <para>swpo:inCity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The &lt;link&gt;City&lt;/link&gt; in which some &lt;link&gt;SubCity&lt;/link&gt; is contained."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"In City"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#inCity">http://sw-portal.deri.org/ontologies/swportal#inCity</seealso>
    let inCity = Prefixed_Name(swpo, "inCity") |> PrefixedName
    /// <summary>
    ///   <para>swpo:inContinent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The &lt;link&gt;Continent&lt;/link&gt; in which some &lt;link&gt;SubContinent&lt;/link&gt; is contained."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"In Continent"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#inContinent">http://sw-portal.deri.org/ontologies/swportal#inContinent</seealso>
    let inContinent = Prefixed_Name(swpo, "inContinent") |> PrefixedName
    /// <summary>
    ///   <para>swpo:inCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The &lt;link&gt;Country&lt;/link&gt; in which some &lt;link&gt;SubCountry&lt;/link&gt; is contained."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"In Country"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#inCountry">http://sw-portal.deri.org/ontologies/swportal#inCountry</seealso>
    let inCountry = Prefixed_Name(swpo, "inCountry") |> PrefixedName
    /// <summary>
    ///   <para>swpo:inRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The &lt;link&gt;Region&lt;/link&gt; in which some &lt;link&gt;SubRegion&lt;/link&gt; is contained."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"In Region"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#inRegion">http://sw-portal.deri.org/ontologies/swportal#inRegion</seealso>
    let inRegion = Prefixed_Name(swpo, "inRegion") |> PrefixedName
    /// <summary>
    ///   <para>swpo:inSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The instance of &lt;link&gt;Series&lt;/link&gt; in which this document was published."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"In Series"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#inSeries">http://sw-portal.deri.org/ontologies/swportal#inSeries</seealso>
    let inSeries = Prefixed_Name(swpo, "inSeries") |> PrefixedName
    /// <summary>
    ///   <para>swpo:isChapter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The chapter (or section or whatever) number which this &lt;link&gt;Inbook&lt;/link&gt; represents."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Chapter"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#isChapter">http://sw-portal.deri.org/ontologies/swportal#isChapter</seealso>
    let isChapter = Prefixed_Name(swpo, "isChapter") |> PrefixedName
    /// <summary>
    ///   <para>swpo:isEdition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The edition of a book---for example, ``Second''. This should be an ordinal, and should have the first letter capitalized, as shown here; the standard styles convert to lower case when necessary."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Edition"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#isEdition">http://sw-portal.deri.org/ontologies/swportal#isEdition</seealso>
    let isEdition = Prefixed_Name(swpo, "isEdition") |> PrefixedName
    /// <summary>
    ///   <para>swpo:isVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The version number of a document or tool."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Version"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#isVersion">http://sw-portal.deri.org/ontologies/swportal#isVersion</seealso>
    let isVersion = Prefixed_Name(swpo, "isVersion") |> PrefixedName
    /// <summary>
    ///   <para>swpo:isVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The volume of a journal or a multi-volume book."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Volume"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#isVolume">http://sw-portal.deri.org/ontologies/swportal#isVolume</seealso>
    let isVolume = Prefixed_Name(swpo, "isVolume") |> PrefixedName
    /// <summary>
    ///   <para>swpo:makesProducts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property defines the products of a company."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Products"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#makesProducts">http://sw-portal.deri.org/ontologies/swportal#makesProducts</seealso>
    let makesProducts = Prefixed_Name(swpo, "makesProducts") |> PrefixedName
    /// <summary>
    ///   <para>swpo:ofJournal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The &lt;link&gt;Journal&lt;/link&gt; this volume belongs to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#ofJournal">http://sw-portal.deri.org/ontologies/swportal#ofJournal</seealso>
    let ofJournal = Prefixed_Name(swpo, "ofJournal") |> PrefixedName
    /// <summary>
    ///   <para>swpo:onPages</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"One or more page numbers or range of numbers, such as 42--111 or 7,41,73--97 or 43+ (the `+' in this last example indicates pages following that don't form a simple range). To make it easier to maintain Scribe-compatible databases, the standard styles convert a single dash (as in 7-33) to the double dash used in TeX to denote number ranges (as in 7--33)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Pages"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#onPages">http://sw-portal.deri.org/ontologies/swportal#onPages</seealso>
    let onPages = Prefixed_Name(swpo, "onPages") |> PrefixedName
    /// <summary>
    ///   <para>swpo:organizedby</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The organizers of an event. At least one agent has to organize an event. The inverse property is &lt;link&gt;organizes&lt;/link&gt;."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Organized by"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#organizedby">http://sw-portal.deri.org/ontologies/swportal#organizedby</seealso>
    let organizedby = Prefixed_Name(swpo, "organizedby") |> PrefixedName
    /// <summary>
    ///   <para>swpo:organizes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates an agent to the events it organizes. The inverse property is &lt;link&gt;organizedBy&lt;/link&gt;."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Organizes"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#organizes">http://sw-portal.deri.org/ontologies/swportal#organizes</seealso>
    let organizes = Prefixed_Name(swpo, "organizes") |> PrefixedName
    /// <summary>
    ///   <para>swpo:publishedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The instance of &lt;link&gt;Publisher&lt;/link&gt; which published this document."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Publisher"</para></remarks>
    /// <seealso href="http://sw-portal.deri.org/ontologies/swportal#publishedBy">http://sw-portal.deri.org/ontologies/swportal#publishedBy</seealso>
    let publishedBy = Prefixed_Name(swpo, "publishedBy") |> PrefixedName

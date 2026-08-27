namespace http.xmlns.com.foaf._0._1.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module foaf =
    let _namespace_iri = Namespace_Iri foaf |> NamespaceIRI
    /// <summary>
    ///   <para>foaf:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"FOAF (Friend of a Friend)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/">http://xmlns.com/foaf/0.1/</seealso>
    let _prefix_iri = Prefixed_Name(foaf, "") |> PrefixedName
    /// <summary>
    ///   <para>foaf:#Group</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/#Group">http://xmlns.com/foaf/0.1/#Group</seealso>
    let ``_#Group`` = Prefixed_Name(foaf, "#Group") |> PrefixedName
    /// <summary>
    ///   <para>foaf:#Organization</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/#Organization">http://xmlns.com/foaf/0.1/#Organization</seealso>
    let ``_#Organization`` = Prefixed_Name(foaf, "#Organization") |> PrefixedName
    /// <summary>
    ///   <para>foaf:#Person</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/#Person">http://xmlns.com/foaf/0.1/#Person</seealso>
    let ``_#Person`` = Prefixed_Name(foaf, "#Person") |> PrefixedName
    /// <summary>
    ///   <para>foaf:#firstName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The first name of a person."</para>
    /// </remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/#firstName">http://xmlns.com/foaf/0.1/#firstName</seealso>
    let ``_#firstName`` = Prefixed_Name(foaf, "#firstName") |> PrefixedName
    /// <summary>
    ///   <para>foaf:#lastName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The last name of a person."</para>
    /// </remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/#lastName">http://xmlns.com/foaf/0.1/#lastName</seealso>
    let ``_#lastName`` = Prefixed_Name(foaf, "#lastName") |> PrefixedName
    /// <summary>
    ///   <para>foaf:#mbox</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/#mbox">http://xmlns.com/foaf/0.1/#mbox</seealso>
    let ``_#mbox`` = Prefixed_Name(foaf, "#mbox") |> PrefixedName
    /// <summary>
    ///   <para>foaf:#member</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>"A creative Team is composed by several ideator"</para>
    /// </remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/#member">http://xmlns.com/foaf/0.1/#member</seealso>
    let ``_#member`` = Prefixed_Name(foaf, "#member") |> PrefixedName
    /// <summary>
    ///   <para>foaf:#name</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/#name">http://xmlns.com/foaf/0.1/#name</seealso>
    let ``_#name`` = Prefixed_Name(foaf, "#name") |> PrefixedName
    /// <summary>
    ///   <para>foaf:#term_Person</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/#term_Person">http://xmlns.com/foaf/0.1/#term_Person</seealso>
    let ``_#term_Person`` = Prefixed_Name(foaf, "#term_Person") |> PrefixedName
    /// <summary>
    ///   <para>foaf:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"An abstract class defining any kind of agents, such as a person, a group, an organization or a software agent."</para>
    ///   <para>"exchanged foaf:Agent by prov:Agent to fulfill range definition of prov:agent property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A person or Organisation."</para>
    ///   <para>"An agent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"DEPRECATED An agent (eg. person, group, software or physical artifact)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"An agent (human or not)"</para>
    ///   <para>"An agent (eg. person, group, software or physical artifact)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Un agente (humano o no)"</para>
    ///   <para>"An agent (eg. person, group, software or physical artifact).
    ///
    /// Agent characteristics used by ESCO:
    /// - The (full and formal) name of the agent (required) - see http://xmlns.com/foaf/0.1/name
    /// - The short name or nickname of the agent (optional) - see http://xmlns.com/foaf/0.1/nick
    /// - The phone number(s) of the agent (optional) - see http://xmlns.com/foaf/0.1/phone
    /// - The home page of the agent (optional) - see http://xmlns.com/foaf/0.1/homepage
    /// - The e-mail of the agent (optional) - see http://xmlns.com/foaf/0.1/mbox
    ///
    /// Some Agent may represent groups. Group members are listed using http://xmlns.com/foaf/0.1/member
    /// "</para>
    ///   <para>""An agent (e.g. person, group, software or physical artifact)."  NOTE: We adopted this concept partially from the FOAF ontology. However, in our ontology the agent concept does not comprise the subclasses software and physical artifact. We decided to introduce this main concept in order to make the range of e.g. the attribute authors of a publication more general."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"An agent."</para>
    ///   <para>"A resource that acts or has the power to act. Example of Agents include person and organization."</para>
    ///   <para>"An agent (eg. person, group, software or physical artifact)."</para>
    /// labels<para>"Agente"</para><para>"Agent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"agent"</para><para>"Agent (foaf)"</para><para>"Agent"</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/Agent">http://xmlns.com/foaf/0.1/Agent</seealso>
    let Agent = Prefixed_Name(foaf, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>foaf:Document</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"An abstract class defining any kinds of publishing work."</para>
    ///   <para>"A document."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Similar to the Agent concept, we have again decided to include a concept from the popular FOAF ontology. The FOAF Vocabulary Specification currently defines Document in a very loose way: "The &lt;link&gt;foaf:Document&lt;/link&gt; class represents those things which are, broadly conceived, 'documents'. ... We do not (currently) distinguish between physical and electronic documents, or between copies of a work and the abstraction those copies embody."
    /// The intended use of this concept within the SWPortal ontology is to subsume everything that contains some sort of information and has been produced by some &lt;link&gt;foaf:Agent&lt;/link&gt; An instance of Document can either refer to an electronic or physical thing, as long as it is adressable by means of a URI. Examples are a book written, or a picture taken by a person, but also a log file generated by a machine."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The Document class represents those things which are, broadly conceived, 'documents'."</para>
    ///   <para>"A document."</para>
    /// labels<para>"Document"</para><para>"Documento"</para><para>"document"</para><para>"Document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/Document">http://xmlns.com/foaf/0.1/Document</seealso>
    let Document = Prefixed_Name(foaf, "Document") |> PrefixedName
    /// <summary>
    ///   <para>foaf:Group</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A class of Agents."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A class of Agents.
    /// Group members are listed using http://xmlns.com/foaf/0.1/member"</para>
    ///   <para>"Remove foaf:Group, use prov:Organization instead"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A group of Agents."</para>
    ///   <para>"DEPRECATED A class of Agents."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>""A class of Agents. The foaf:Group classs represents a collection of individual agents (and may itself play the role of a &lt;link&gt;foaf:Agent&lt;/link&gt;, i.e. something that can perform actions).""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Group"</para><para>"Group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/Group">http://xmlns.com/foaf/0.1/Group</seealso>
    let Group = Prefixed_Name(foaf, "Group") |> PrefixedName
    /// <summary>
    ///   <para>foaf:Image</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"An image."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The class Image is a sub-class of Document corresponding to those documents which are images."</para>
    ///   <para>"An image."</para>
    /// labels<para>"Image"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Image"</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/Image">http://xmlns.com/foaf/0.1/Image</seealso>
    let Image = Prefixed_Name(foaf, "Image") |> PrefixedName
    /// <summary>
    ///   <para>foaf:LabelProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A foaf:LabelProperty is any RDF property with texual values that serve as labels."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Label Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/LabelProperty">http://xmlns.com/foaf/0.1/LabelProperty</seealso>
    let LabelProperty = Prefixed_Name(foaf, "LabelProperty") |> PrefixedName
    /// <summary>
    ///   <para>foaf:OnlineAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"An online account."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Online Account"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/OnlineAccount">http://xmlns.com/foaf/0.1/OnlineAccount</seealso>
    let OnlineAccount = Prefixed_Name(foaf, "OnlineAccount") |> PrefixedName
    /// <summary>
    ///   <para>foaf:OnlineChatAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"An online chat account."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Online Chat Account"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/OnlineChatAccount">http://xmlns.com/foaf/0.1/OnlineChatAccount</seealso>
    let OnlineChatAccount = Prefixed_Name(foaf, "OnlineChatAccount") |> PrefixedName

    /// <summary>
    ///   <para>foaf:OnlineEcommerceAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"An online e-commerce account."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Online E-commerce Account"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/OnlineEcommerceAccount">http://xmlns.com/foaf/0.1/OnlineEcommerceAccount</seealso>
    let OnlineEcommerceAccount =
        Prefixed_Name(foaf, "OnlineEcommerceAccount") |> PrefixedName

    /// <summary>
    ///   <para>foaf:OnlineGamingAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"An online gaming account."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Online Gaming Account"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/OnlineGamingAccount">http://xmlns.com/foaf/0.1/OnlineGamingAccount</seealso>
    let OnlineGamingAccount = Prefixed_Name(foaf, "OnlineGamingAccount") |> PrefixedName
    /// <summary>
    ///   <para>foaf:Oranization</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/Oranization">http://xmlns.com/foaf/0.1/Oranization</seealso>
    let Oranization = Prefixed_Name(foaf, "Oranization") |> PrefixedName
    /// <summary>
    ///   <para>foaf:Organisation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/Organisation">http://xmlns.com/foaf/0.1/Organisation</seealso>
    let Organisation = Prefixed_Name(foaf, "Organisation") |> PrefixedName
    /// <summary>
    ///   <para>foaf:Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Used for any kind of organization such as a library or a company, both Institution and Department."</para>
    ///   <para>"Organization the person belongs to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Replace foaf:Organization by prov:Organization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>""The foaf:Organization class represents a kind of foaf:Agent corresponding to social institutions such as companies, societies, etc." As we consider an organization to be a group as well, we introduced a subclass &lt;link&gt;Organization&lt;/link&gt; as a subclass of both &lt;link&gt;foaf:Organization&lt;/link&gt; and &lt;link&gt;foaf:Group&lt;/link&gt;. We added &lt;link&gt;foaf:Organization&lt;/link&gt; to facilitate FOAF based agents to query our ontology."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"An organization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"An agent belonging to some social institutions such as companies, associations etc, that has a collective goal."</para>
    ///   <para>"An organization."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"An organization."</para>
    ///   <para>"An organisation (business, corporation, federation, etc.) or moral agent (gvernment body)."</para>
    ///   <para>"DEPRECATED An organization."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Organización"</para><para>"Organization"</para><para>""</para><para>"Organization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Organisation"</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/Organization">http://xmlns.com/foaf/0.1/Organization</seealso>
    let Organization = Prefixed_Name(foaf, "Organization") |> PrefixedName
    /// <summary>
    ///   <para>foaf:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"La clase Persona representa gente, con la condición de que sean personas, con independencia de que estén vivas o muertas, o reales o imaginarias. Es una subclase de Agent"</para>
    ///   <para>"Replace foaf:Person by prov:Person"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A person"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Una persona"</para>
    ///   <para>"A person"</para>
    ///   <para>"Person who makes this ontology."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"It represents a single individual of any age and having any type of characteristics."</para>
    ///   <para>"A person."</para>
    ///   <para>"The Person class represents people. Something is a Person if it is a person. We don't nitpic about whether they're alive, dead, real, or imaginary. The Person class is a sub-class of the Agent class, since all people are considered agents in FOAF"</para>
    ///   <para>"The person class represent people whatever his state"</para>
    ///   <para>"A human."</para>
    ///   <para>"A person."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>""A person. The foaf:Person class represents people. Something is a foaf:Person if it is a person. We don't nitpick about whether they're alive, dead, real or imaginary.""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"DEPRECATED A person."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Personne"</para><para>"Person"</para><para>"Person"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Persona"</para><para>"person"</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/Person">http://xmlns.com/foaf/0.1/Person</seealso>
    let Person = Prefixed_Name(foaf, "Person") |> PrefixedName

    /// <summary>
    ///   <para>foaf:PersonalProfileDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A personal profile RDF document."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PersonalProfileDocument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/PersonalProfileDocument">http://xmlns.com/foaf/0.1/PersonalProfileDocument</seealso>
    let PersonalProfileDocument =
        Prefixed_Name(foaf, "PersonalProfileDocument") |> PrefixedName

    /// <summary>
    ///   <para>foaf:Post</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Post with the beginning and ending dates"</para>
    ///   <para>"Puesto con las fechas de inicio y fin"</para>
    /// labels<para>"Puesto"</para><para>"Post"</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/Post">http://xmlns.com/foaf/0.1/Post</seealso>
    let Post = Prefixed_Name(foaf, "Post") |> PrefixedName
    /// <summary>
    ///   <para>foaf:Project</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"In FRAPO, a project is an administrative entity that enables an endeavour such as a research investigation.  A project relates to the administrative aspects of undertaking an endeavour, including the funding obtained, the people employed, and the management of the project in terms of deadlines and deliverables.  In contrast, an endeavour such as a research investigation relate to the academic and practical aspects of undertaking that endeavour - thus for a research investigation: the research itself, including the hypotheses being investigated, the experiments being undertaken, the data being gathered and analysed, the interpretations being drawn from the data, and the results obtained."</para>
    ///   <para>"A project (a collective endeavour of some kind)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>""A project (a collective endeavour of some kind)." Within the context of the SWPortal Ontology we specify &lt;link&gt;foaf:Project&lt;/link&gt; as such: A project is an endeavour of a group which has a specific aim. As a project can also be individualized and can publish documents and the like, we model it as a subclass of foaf:Agent. It has members and inherits all properties of &lt;link&gt;foaf:Agent&lt;/link&gt; and &lt;link&gt;foaf:Group&lt;/link&gt;. Also, projects are usually funded."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A project (a collective endeavour of some kind)."</para>
    /// labels<para>"Project2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Project"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Project"</para><para>"project"</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/Project">http://xmlns.com/foaf/0.1/Project</seealso>
    let Project = Prefixed_Name(foaf, "Project") |> PrefixedName
    /// <summary>
    ///   <para>foaf:account</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates an account held by this agent."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"account"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/account">http://xmlns.com/foaf/0.1/account</seealso>
    let account = Prefixed_Name(foaf, "account") |> PrefixedName
    /// <summary>
    ///   <para>foaf:accountName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates the name (identifier) associated with this online account."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"account name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/accountName">http://xmlns.com/foaf/0.1/accountName</seealso>
    let accountName = Prefixed_Name(foaf, "accountName") |> PrefixedName

    /// <summary>
    ///   <para>foaf:accountServiceHomepage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates a homepage of the service provide for this online account."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"account service homepage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/accountServiceHomepage">http://xmlns.com/foaf/0.1/accountServiceHomepage</seealso>
    let accountServiceHomepage =
        Prefixed_Name(foaf, "accountServiceHomepage") |> PrefixedName

    /// <summary>
    ///   <para>foaf:affiliation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/affiliation">http://xmlns.com/foaf/0.1/affiliation</seealso>
    let affiliation = Prefixed_Name(foaf, "affiliation") |> PrefixedName
    /// <summary>
    ///   <para>foaf:age</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"A person's age, usually expressed in years, represented as an integer."</para>
    ///   <para>"The age of the person."</para>
    ///   <para>"The age in years of some agent."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"age"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Age"</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/age">http://xmlns.com/foaf/0.1/age</seealso>
    let age = Prefixed_Name(foaf, "age") |> PrefixedName
    /// <summary>
    ///   <para>foaf:aimChatID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>"An AIM chat ID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AIM chat ID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/aimChatID">http://xmlns.com/foaf/0.1/aimChatID</seealso>
    let aimChatID = Prefixed_Name(foaf, "aimChatID") |> PrefixedName
    /// <summary>
    ///   <para>foaf:based_near</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A location that something is based near, for some broadly human notion of near."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"based near"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/based_near">http://xmlns.com/foaf/0.1/based_near</seealso>
    let based_near = Prefixed_Name(foaf, "based_near") |> PrefixedName
    /// <summary>
    ///   <para>foaf:birthday</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The birthday of this Agent, represented in mm-dd string form, eg. '12-31'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"birthday"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/birthday">http://xmlns.com/foaf/0.1/birthday</seealso>
    let birthday = Prefixed_Name(foaf, "birthday") |> PrefixedName
    /// <summary>
    ///   <para>foaf:currentProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>""A current project this person works on." NOTE: FOAF defines the range as &lt;link&gt;foaf:Person&lt;/link&gt; - we decided to change this to the more general &lt;link&gt;foaf:Agent&lt;/link&gt;, since other types of Agents (e.g. a company) can also have projects.
    /// We have also defined an inverse for this property (see &lt;link&gt;drivenBy&lt;/link&gt;)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A current project this person works on."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"current project"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Current Project"</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/currentProject">http://xmlns.com/foaf/0.1/currentProject</seealso>
    let currentProject = Prefixed_Name(foaf, "currentProject") |> PrefixedName
    /// <summary>
    ///   <para>foaf:depiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"A depiction of some thing."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A depiction of some thing."</para>
    /// labels<para>"depiction"</para><para>"depiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/depiction">http://xmlns.com/foaf/0.1/depiction</seealso>
    let depiction = Prefixed_Name(foaf, "depiction") |> PrefixedName
    /// <summary>
    ///   <para>foaf:depicts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A thing depicted in this representation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The depiction property is a relationship between a thing and an Image that depicts it. As such it is an inverse of the depicts relationship."</para>
    /// labels<para>"depicts"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"depicts"</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/depicts">http://xmlns.com/foaf/0.1/depicts</seealso>
    let depicts = Prefixed_Name(foaf, "depicts") |> PrefixedName
    /// <summary>
    ///   <para>foaf:dnaChecksum</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A checksum for the DNA of some thing. Joke."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DNA checksum"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/dnaChecksum">http://xmlns.com/foaf/0.1/dnaChecksum</seealso>
    let dnaChecksum = Prefixed_Name(foaf, "dnaChecksum") |> PrefixedName
    /// <summary>
    ///   <para>foaf:document</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/document">http://xmlns.com/foaf/0.1/document</seealso>
    let document = Prefixed_Name(foaf, "document") |> PrefixedName
    /// <summary>
    ///   <para>foaf:familyName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Apellidos"</para>
    ///   <para>"The foaf:familyName property fully represents the Person Core Vocabulary term of family name"</para>
    ///   <para>"The family name of some person."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"familienaam"</para><para>"familyName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"family name"</para><para>"Apellidos"</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/familyName">http://xmlns.com/foaf/0.1/familyName</seealso>
    let familyName = Prefixed_Name(foaf, "familyName") |> PrefixedName
    /// <summary>
    ///   <para>foaf:family_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The family name of some person."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"family_name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/family_name">http://xmlns.com/foaf/0.1/family_name</seealso>
    let family_name = Prefixed_Name(foaf, "family_name") |> PrefixedName
    /// <summary>
    ///   <para>foaf:firstName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>""The first name of a person." NOTE: the naming substructure of foaf is currently quite unstable."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"the first name of a user."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The first name of a person."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"El primer nombre de una persona"</para>
    ///   <para>"The first name of a person."</para>
    ///   <para>"The first name of the person."</para>
    /// labels<para>"First Name"</para><para>"first name"</para><para>"first name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"firstName"</para><para>"firstName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Primer nombre"</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/firstName">http://xmlns.com/foaf/0.1/firstName</seealso>
    let firstName = Prefixed_Name(foaf, "firstName") |> PrefixedName
    /// <summary>
    ///   <para>foaf:firstname</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/firstname">http://xmlns.com/foaf/0.1/firstname</seealso>
    let firstname = Prefixed_Name(foaf, "firstname") |> PrefixedName
    /// <summary>
    ///   <para>foaf:focus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The underlying or 'focal' entity associated with some SKOS-described concept."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"focus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/focus">http://xmlns.com/foaf/0.1/focus</seealso>
    let focus = Prefixed_Name(foaf, "focus") |> PrefixedName
    /// <summary>
    ///   <para>foaf:fundedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"An organization funding a project or person."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"An organization funding a project or person."</para>
    /// labels<para>"funded by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"funded by"</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/fundedBy">http://xmlns.com/foaf/0.1/fundedBy</seealso>
    let fundedBy = Prefixed_Name(foaf, "fundedBy") |> PrefixedName
    /// <summary>
    ///   <para>foaf:geekcode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A textual geekcode for this person, see http://www.geekcode.com/geek.html"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"geekcode"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/geekcode">http://xmlns.com/foaf/0.1/geekcode</seealso>
    let geekcode = Prefixed_Name(foaf, "geekcode") |> PrefixedName
    /// <summary>
    ///   <para>foaf:gender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The gender of this Agent (typically but not necessarily 'male' or 'female')."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The gender of a person. It is typically but not necessarily 'male' or 'female'."</para>
    ///   <para>"the gender of a user, reused from foaf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"gender"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Gender"</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/gender">http://xmlns.com/foaf/0.1/gender</seealso>
    let gender = Prefixed_Name(foaf, "gender") |> PrefixedName
    /// <summary>
    ///   <para>foaf:givenName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"El nombre dado a una persona"</para>
    ///   <para>"The given name of some person."</para>
    ///   <para>"Nombre persona"</para>
    ///   <para>"The foaf:givenName property fully represents the Person Core Vocabulary term of given name"</para>
    ///   <para>"The given name of some person."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Given name"</para><para>"Given name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Nombre persona"</para><para>"gegeven naam"</para><para>"Otro nombre"</para><para>"given name"</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/givenName">http://xmlns.com/foaf/0.1/givenName</seealso>
    let givenName = Prefixed_Name(foaf, "givenName") |> PrefixedName
    /// <summary>
    ///   <para>foaf:givenname</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The given name of some person."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Given name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/givenname">http://xmlns.com/foaf/0.1/givenname</seealso>
    let givenname = Prefixed_Name(foaf, "givenname") |> PrefixedName
    /// <summary>
    ///   <para>foaf:holdsAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates an account held by this agent."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"account"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/holdsAccount">http://xmlns.com/foaf/0.1/holdsAccount</seealso>
    let holdsAccount = Prefixed_Name(foaf, "holdsAccount") |> PrefixedName
    /// <summary>
    ///   <para>foaf:homepage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This axiom needed so that Protege loads DCAT2 without errors."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A homepage"</para>
    ///   <para>"A homepage for some thing."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A homepage for some thing."</para>
    ///   <para>"FOAF already defines a perfectly good way to indicate a homepage."</para>
    ///   <para>"Página web"</para>
    /// labels<para>"Página web"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"homepage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"homepage"</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/homepage">http://xmlns.com/foaf/0.1/homepage</seealso>
    let homepage = Prefixed_Name(foaf, "homepage") |> PrefixedName
    /// <summary>
    ///   <para>foaf:icqChatID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>"An ICQ chat ID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ICQ chat ID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/icqChatID">http://xmlns.com/foaf/0.1/icqChatID</seealso>
    let icqChatID = Prefixed_Name(foaf, "icqChatID") |> PrefixedName
    /// <summary>
    ///   <para>foaf:image</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/image">http://xmlns.com/foaf/0.1/image</seealso>
    let image = Prefixed_Name(foaf, "image") |> PrefixedName
    /// <summary>
    ///   <para>foaf:img</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An image that can be used to represent some thing (ie. those depictions which are particularly representative of something, eg. one's photo on a homepage)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Url de la imagen"</para>
    ///   <para>"Animage to represent something."</para>
    /// labels<para>"Image"</para><para>"image"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Imagen de usuario"</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/img">http://xmlns.com/foaf/0.1/img</seealso>
    let img = Prefixed_Name(foaf, "img") |> PrefixedName
    /// <summary>
    ///   <para>foaf:index.rdf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/index.rdf">http://xmlns.com/foaf/0.1/index.rdf</seealso>
    let ``index.rdf`` = Prefixed_Name(foaf, "index.rdf") |> PrefixedName
    /// <summary>
    ///   <para>foaf:interest</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A page about a topic of interest to this person."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"interest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/interest">http://xmlns.com/foaf/0.1/interest</seealso>
    let interest = Prefixed_Name(foaf, "interest") |> PrefixedName
    /// <summary>
    ///   <para>foaf:isPrimaryTopicOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A document that this thing is the primary topic of."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A document that this thing is the primary topic of."</para>
    /// labels<para>"foaf:isPrimaryTopicOf"</para><para>"is primary topic of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"is primary topic of"</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/isPrimaryTopicOf">http://xmlns.com/foaf/0.1/isPrimaryTopicOf</seealso>
    let isPrimaryTopicOf = Prefixed_Name(foaf, "isPrimaryTopicOf") |> PrefixedName
    /// <summary>
    ///   <para>foaf:jabberID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A jabber ID for something."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"jabber ID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/jabberID">http://xmlns.com/foaf/0.1/jabberID</seealso>
    let jabberID = Prefixed_Name(foaf, "jabberID") |> PrefixedName
    /// <summary>
    ///   <para>foaf:knows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>""A person known by this person (indicating some level of reciprocated interaction between the parties).""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A person known by this person (indicating some level of reciprocated interaction between the parties)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"knows"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"knows"</para><para>"Knows"</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/knows">http://xmlns.com/foaf/0.1/knows</seealso>
    let knows = Prefixed_Name(foaf, "knows") |> PrefixedName
    /// <summary>
    ///   <para>foaf:lastName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The last name of a person."</para>
    ///   <para>"the last name of a person.
    /// Reused from foaf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The last name of the person."</para>
    ///   <para>"The last name of a person."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Last Name"</para><para>"last name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"lastName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"last name"</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/lastName">http://xmlns.com/foaf/0.1/lastName</seealso>
    let lastName = Prefixed_Name(foaf, "lastName") |> PrefixedName
    /// <summary>
    ///   <para>foaf:lastname</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/lastname">http://xmlns.com/foaf/0.1/lastname</seealso>
    let lastname = Prefixed_Name(foaf, "lastname") |> PrefixedName
    /// <summary>
    ///   <para>foaf:logo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"A logo representing some thing."</para>
    ///   <para>"A logo representing some thing."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"logo"</para><para>"logo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/logo">http://xmlns.com/foaf/0.1/logo</seealso>
    let logo = Prefixed_Name(foaf, "logo") |> PrefixedName
    /// <summary>
    ///   <para>foaf:made</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:Class</para>
    ///   <para>""Something that was made by this agent." In the context of the SWPortal ontology, this could e.g. be an &lt;link&gt;Tool&lt;/link&gt;."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Something that was made by this agent."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"made"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Made"</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/made">http://xmlns.com/foaf/0.1/made</seealso>
    let made = Prefixed_Name(foaf, "made") |> PrefixedName
    /// <summary>
    ///   <para>foaf:maker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"An agent that  made this thing."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"An agent that made this thing."</para>
    /// labels<para>"maker"</para><para>"maker"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/maker">http://xmlns.com/foaf/0.1/maker</seealso>
    let maker = Prefixed_Name(foaf, "maker") |> PrefixedName
    /// <summary>
    ///   <para>foaf:mbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A  personal mailbox, ie. an Internet mailbox associated with exactly one owner, the first owner of this mailbox. This is a 'static inverse functional property', in that  there is (across time and change) at most one individual that ever has any particular value for foaf:mbox."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A personal mailbox, ie. an Internet mailbox associated with exactly one owner, the first owner of this mailbox. This is a 'static inverse functional property', in that   there is (across time and change) at most one individual that ever has any particular value for foaf:mbox."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>""A personal mailbox, i.e. an internet mailbox associated with exactly one owner, the first owner of this mailbox. This is a 'static inverse functional property', in that there is (across time and change) at most one individual that ever has any particular value for &lt;link&gt;foaf:mbox&lt;/link&gt;." Because we switched over to OWL Lite– ,we don’t have functional properties anymore. However, we recommend to the users of this ontology to apply this property like it is described in the FOAF specification."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A personal mailbox, ie. an Internet mailbox associated with exactly one owner, the first owner of this mailbox. This is a 'static inverse functional property', in that  there is (across time and change) at most one individual that ever has any particular value for foaf:mbox.
    ///
    /// The used URI format is according http://tools.ietf.org/html/rfc6068: "mailto:...@...""</para>
    ///   <para>"Correo electrónico"</para>
    ///   <para>"A personal mailbox, ie. an Internet mailbox associated with exactly one owner, the first owner of this mailbox. This is a 'static inverse functional property', in that there is (across time and change) at most one individual that ever has any particular value for foaf:mbox."</para>
    /// labels<para>"personal mailbox"</para><para>"Email"</para><para>"personal mailbox"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Correo electrónico"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/mbox">http://xmlns.com/foaf/0.1/mbox</seealso>
    let mbox = Prefixed_Name(foaf, "mbox") |> PrefixedName
    /// <summary>
    ///   <para>foaf:mbox_sha1sum</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The sha1sum of the URI of an Internet mailbox associated with exactly one owner, the  first owner of the mailbox."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"sha1sum of a personal mailbox URI name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/mbox_sha1sum">http://xmlns.com/foaf/0.1/mbox_sha1sum</seealso>
    let mbox_sha1sum = Prefixed_Name(foaf, "mbox_sha1sum") |> PrefixedName
    /// <summary>
    ///   <para>foaf:member</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"To identify an Agent member of a Group."</para>
    ///   <para>""Indicates a member of a Group." This property relates a set of agents to a group. These are the members of that group."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Indicates a member of a Group"</para>
    ///   <para>"Indicates a member of a Group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"member"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Miembro"</para><para>"member"</para><para>"Group member"</para><para>"Member"</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/member">http://xmlns.com/foaf/0.1/member</seealso>
    let member_ = Prefixed_Name(foaf, "member") |> PrefixedName
    /// <summary>
    ///   <para>foaf:membershipClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates the class of individuals that are a member of a Group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"membershipClass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/membershipClass">http://xmlns.com/foaf/0.1/membershipClass</seealso>
    let membershipClass = Prefixed_Name(foaf, "membershipClass") |> PrefixedName
    /// <summary>
    ///   <para>foaf:msnChatID</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An MSN chat ID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MSN chat ID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/msnChatID">http://xmlns.com/foaf/0.1/msnChatID</seealso>
    let msnChatID = Prefixed_Name(foaf, "msnChatID") |> PrefixedName
    /// <summary>
    ///   <para>foaf:myersBriggs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A Myers Briggs (MBTI) personality classification."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"myersBriggs"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/myersBriggs">http://xmlns.com/foaf/0.1/myersBriggs</seealso>
    let myersBriggs = Prefixed_Name(foaf, "myersBriggs") |> PrefixedName
    /// <summary>
    ///   <para>foaf:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""The name of some thing.""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A name for some thing."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The foaf:name property fully represents the Person Core Vocabulary term of full name"</para>
    ///   <para>"To name an Agent."</para>
    ///   <para>"Nombre y apellidos de la persona"</para>
    ///   <para>"A name for an agent."</para>
    ///   <para>"The name for some thing."</para>
    ///   <para>"A name for some thing."</para>
    /// labels<para>"Name"</para><para>"foaf:name"</para><para>"naam"</para><para>"Complete Name"</para><para>"Nombre completo"</para><para>"name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"name"</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/name">http://xmlns.com/foaf/0.1/name</seealso>
    let name = Prefixed_Name(foaf, "name") |> PrefixedName
    /// <summary>
    ///   <para>foaf:nick</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"A short informal nickname characterising an agent (includes login identifiers, IRC and other chat nicknames)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A short informal nickname characterising an agent (includes login identifiers, IRC and other chat nicknames)."</para>
    /// labels<para>"nickname"</para><para>"nickname"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/nick">http://xmlns.com/foaf/0.1/nick</seealso>
    let nick = Prefixed_Name(foaf, "nick") |> PrefixedName
    /// <summary>
    ///   <para>foaf:null</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/null">http://xmlns.com/foaf/0.1/null</seealso>
    let null_ = Prefixed_Name(foaf, "null") |> PrefixedName
    /// <summary>
    ///   <para>foaf:openid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"An OpenID for an Agent."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"openid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/openid">http://xmlns.com/foaf/0.1/openid</seealso>
    let openid = Prefixed_Name(foaf, "openid") |> PrefixedName
    /// <summary>
    ///   <para>foaf:organization</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/organization">http://xmlns.com/foaf/0.1/organization</seealso>
    let organization = Prefixed_Name(foaf, "organization") |> PrefixedName
    /// <summary>
    ///   <para>foaf:page</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdfs:Property</para>
    ///   <para>"A page or document about this thing."</para>
    ///   <para>"A page or document about this thing."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"This property holds the URL of the drug information page on the Macedonian Drug Bureau website."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"page"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"page"</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/page">http://xmlns.com/foaf/0.1/page</seealso>
    let page = Prefixed_Name(foaf, "page") |> PrefixedName
    /// <summary>
    ///   <para>foaf:pastProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A project this person has previously worked on."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>""A project this person has previously worked on." NOTE: foaf defines the range as &lt;link&gt;foaf:Person&lt;/link&gt; - we decided to change this to the more general &lt;link&gt;foaf:Agent&lt;/link&gt;, since other types of Agents (e.g. a company) can also have projects."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"past project"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Past Project"</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/pastProject">http://xmlns.com/foaf/0.1/pastProject</seealso>
    let pastProject = Prefixed_Name(foaf, "pastProject") |> PrefixedName
    /// <summary>
    ///   <para>foaf:person</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"all types of people such as politicians, athletes, historic figures, contributors in programmes e.t.c."</para>
    /// labels<para>"Person"</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/person">http://xmlns.com/foaf/0.1/person</seealso>
    let person = Prefixed_Name(foaf, "person") |> PrefixedName
    /// <summary>
    ///   <para>foaf:phone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>""The foaf:phone of something is a phone, typically identified using the tel: URI  scheme." The tel: URI scheme is defined in http://www.ietf.org/rfc/rfc2806.txt."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A phone, specified using fully qualified tel: URI scheme "tel:+##...##" - see http://www.ietf.org/rfc/rfc2806.txt."</para>
    ///   <para>"Teléfono"</para>
    ///   <para>"A phone,  specified using fully qualified tel: URI scheme (refs: http://www.w3.org/Addressing/schemes.html#tel)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Teléfono"</para><para>"Telephone"</para><para>"phone"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"phone"</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/phone">http://xmlns.com/foaf/0.1/phone</seealso>
    let phone = Prefixed_Name(foaf, "phone") |> PrefixedName
    /// <summary>
    ///   <para>foaf:plan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A .plan comment, in the tradition of finger and '.plan' files."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"plan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/plan">http://xmlns.com/foaf/0.1/plan</seealso>
    let plan = Prefixed_Name(foaf, "plan") |> PrefixedName
    /// <summary>
    ///   <para>foaf:primaryTopic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The primary topic of some page or document."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A page or document about this thing."</para>
    ///   <para>"This axiom needed so that Protege loads DCAT2 without errors."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"primary topic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"primary topic"</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/primaryTopic">http://xmlns.com/foaf/0.1/primaryTopic</seealso>
    let primaryTopic = Prefixed_Name(foaf, "primaryTopic") |> PrefixedName
    /// <summary>
    ///   <para>foaf:primaryTopicOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Property</para>
    /// </remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/primaryTopicOf">http://xmlns.com/foaf/0.1/primaryTopicOf</seealso>
    let primaryTopicOf = Prefixed_Name(foaf, "primaryTopicOf") |> PrefixedName
    /// <summary>
    ///   <para>foaf:publications</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A link to the publications of this person."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>""A link to the publications of this person." This property relates an agent to its publications. NOTE: foaf defines the range as &lt;link&gt;foaf:Person&lt;/link&gt; - we decided to change this to the more general &lt;link&gt;foaf:Agent&lt;/link&gt;, since other types of Agents (e.g. a company) can also have publications (with no specific human authors)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"publications"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Publications"</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/publications">http://xmlns.com/foaf/0.1/publications</seealso>
    let publications = Prefixed_Name(foaf, "publications") |> PrefixedName
    /// <summary>
    ///   <para>foaf:schoolHomepage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A homepage of a school attended by the person."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"schoolHomepage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/schoolHomepage">http://xmlns.com/foaf/0.1/schoolHomepage</seealso>
    let schoolHomepage = Prefixed_Name(foaf, "schoolHomepage") |> PrefixedName
    /// <summary>
    ///   <para>foaf:sha1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A sha1sum hash, in hex."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"sha1sum (hex)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/sha1">http://xmlns.com/foaf/0.1/sha1</seealso>
    let sha1 = Prefixed_Name(foaf, "sha1") |> PrefixedName
    /// <summary>
    ///   <para>foaf:skypeID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A Skype ID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Skype ID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/skypeID">http://xmlns.com/foaf/0.1/skypeID</seealso>
    let skypeID = Prefixed_Name(foaf, "skypeID") |> PrefixedName
    /// <summary>
    ///   <para>foaf:status</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A string expressing what the user is happy for the general public (normally) to know about their current activity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/status">http://xmlns.com/foaf/0.1/status</seealso>
    let status = Prefixed_Name(foaf, "status") |> PrefixedName
    /// <summary>
    ///   <para>foaf:surname</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>""The surname of a person." NOTE: the naming substructure of foaf is currently quite unstable."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The surname of some person."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Surname"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Surname"</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/surname">http://xmlns.com/foaf/0.1/surname</seealso>
    let surname = Prefixed_Name(foaf, "surname") |> PrefixedName
    /// <summary>
    ///   <para>foaf:theme</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A theme."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>""A theme. The foaf:theme property is rarely used and under-specified. The intention was to use it to characterise interest / themes associated with projects and groups. Further work is need to meet these goals." NOTE: This property is only listed for comparison with goal."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Theme"</para><para>"theme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/theme">http://xmlns.com/foaf/0.1/theme</seealso>
    let theme = Prefixed_Name(foaf, "theme") |> PrefixedName
    /// <summary>
    ///   <para>foaf:thumbnail</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A derived thumbnail image."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"thumbnail"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/thumbnail">http://xmlns.com/foaf/0.1/thumbnail</seealso>
    let thumbnail = Prefixed_Name(foaf, "thumbnail") |> PrefixedName
    /// <summary>
    ///   <para>foaf:tipjar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A tipjar document for this agent, describing means for payment and reward."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"tipjar"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/tipjar">http://xmlns.com/foaf/0.1/tipjar</seealso>
    let tipjar = Prefixed_Name(foaf, "tipjar") |> PrefixedName
    /// <summary>
    ///   <para>foaf:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Title (Mr, Mrs, Ms, Dr. etc)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"title"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/title">http://xmlns.com/foaf/0.1/title</seealso>
    let title = Prefixed_Name(foaf, "title") |> PrefixedName
    /// <summary>
    ///   <para>foaf:topic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""A topic of some page or document. The &lt;link&gt;foaf:topic&lt;/link&gt; property relates a document to a thing that the document is about. As such it is an inverse to the foaf:page property, which relates a thing to a document about that thing.""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A topic of some page or document."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A topic of some page or document."</para>
    /// labels<para>"topic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"topic"</para><para>"Topic"</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/topic">http://xmlns.com/foaf/0.1/topic</seealso>
    let topic = Prefixed_Name(foaf, "topic") |> PrefixedName
    /// <summary>
    ///   <para>foaf:topic_interest</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A thing of interest to this person."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"topic_interest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/topic_interest">http://xmlns.com/foaf/0.1/topic_interest</seealso>
    let topic_interest = Prefixed_Name(foaf, "topic_interest") |> PrefixedName
    /// <summary>
    ///   <para>foaf:weblog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>"A weblog of some thing (whether person, group, company etc.)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"weblog"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/weblog">http://xmlns.com/foaf/0.1/weblog</seealso>
    let weblog = Prefixed_Name(foaf, "weblog") |> PrefixedName
    /// <summary>
    ///   <para>foaf:workInfoHomepage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A work info homepage of some person; a page about their work for some organization."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"work info homepage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/workInfoHomepage">http://xmlns.com/foaf/0.1/workInfoHomepage</seealso>
    let workInfoHomepage = Prefixed_Name(foaf, "workInfoHomepage") |> PrefixedName
    /// <summary>
    ///   <para>foaf:workplaceHomepage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A workplace homepage of some person; the homepage of an organization they work for."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"workplace homepage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/workplaceHomepage">http://xmlns.com/foaf/0.1/workplaceHomepage</seealso>
    let workplaceHomepage = Prefixed_Name(foaf, "workplaceHomepage") |> PrefixedName
    /// <summary>
    ///   <para>foaf:yahooChatID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>"A Yahoo chat ID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Yahoo chat ID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/yahooChatID">http://xmlns.com/foaf/0.1/yahooChatID</seealso>
    let yahooChatID = Prefixed_Name(foaf, "yahooChatID") |> PrefixedName

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
    /// </remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/">http://xmlns.com/foaf/0.1/</seealso>
    let _prefix_iri = Prefixed_Name(foaf, "") |> PrefixedName
    /// <summary>
    ///   <para>foaf:Document</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A document.</para>
    /// labels<para>Document</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/Document">http://xmlns.com/foaf/0.1/Document</seealso>
    let Document = Prefixed_Name(foaf, "Document") |> PrefixedName
    /// <summary>
    ///   <para>foaf:Group</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A class of Agents.</para>
    /// labels<para>Group</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/Group">http://xmlns.com/foaf/0.1/Group</seealso>
    let Group = Prefixed_Name(foaf, "Group") |> PrefixedName
    /// <summary>
    ///   <para>foaf:gender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The gender of this Agent (typically but not necessarily 'male' or 'female').</para>
    /// labels<para>gender</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/gender">http://xmlns.com/foaf/0.1/gender</seealso>
    let gender = Prefixed_Name(foaf, "gender") |> PrefixedName
    /// <summary>
    ///   <para>foaf:holdsAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates an account held by this agent.</para>
    /// labels<para>account</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/holdsAccount">http://xmlns.com/foaf/0.1/holdsAccount</seealso>
    let holdsAccount = Prefixed_Name(foaf, "holdsAccount") |> PrefixedName
    /// <summary>
    ///   <para>foaf:homepage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A homepage for some thing.</para>
    /// labels<para>homepage</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/homepage">http://xmlns.com/foaf/0.1/homepage</seealso>
    let homepage = Prefixed_Name(foaf, "homepage") |> PrefixedName
    /// <summary>
    ///   <para>foaf:icqChatID</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>An ICQ chat ID</para>
    /// labels<para>ICQ chat ID</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/icqChatID">http://xmlns.com/foaf/0.1/icqChatID</seealso>
    let icqChatID = Prefixed_Name(foaf, "icqChatID") |> PrefixedName
    /// <summary>
    ///   <para>foaf:img</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>An image that can be used to represent some thing (ie. those depictions which are particularly representative of something, eg. one's photo on a homepage).</para>
    /// labels<para>image</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/img">http://xmlns.com/foaf/0.1/img</seealso>
    let img = Prefixed_Name(foaf, "img") |> PrefixedName
    /// <summary>
    ///   <para>foaf:primaryTopic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The primary topic of some page or document.</para>
    /// labels<para>primary topic</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/primaryTopic">http://xmlns.com/foaf/0.1/primaryTopic</seealso>
    let primaryTopic = Prefixed_Name(foaf, "primaryTopic") |> PrefixedName
    /// <summary>
    ///   <para>foaf:jabberID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A jabber ID for something.</para>
    /// labels<para>jabber ID</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/jabberID">http://xmlns.com/foaf/0.1/jabberID</seealso>
    let jabberID = Prefixed_Name(foaf, "jabberID") |> PrefixedName
    /// <summary>
    ///   <para>foaf:knows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A person known by this person (indicating some level of reciprocated interaction between the parties).</para>
    /// labels<para>knows</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/knows">http://xmlns.com/foaf/0.1/knows</seealso>
    let knows = Prefixed_Name(foaf, "knows") |> PrefixedName
    /// <summary>
    ///   <para>foaf:lastName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The last name of a person.</para>
    /// labels<para>lastName</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/lastName">http://xmlns.com/foaf/0.1/lastName</seealso>
    let lastName = Prefixed_Name(foaf, "lastName") |> PrefixedName
    /// <summary>
    ///   <para>foaf:logo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A logo representing some thing.</para>
    /// labels<para>logo</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/logo">http://xmlns.com/foaf/0.1/logo</seealso>
    let logo = Prefixed_Name(foaf, "logo") |> PrefixedName
    /// <summary>
    ///   <para>foaf:made</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Something that was made by this agent.</para>
    /// labels<para>made</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/made">http://xmlns.com/foaf/0.1/made</seealso>
    let made = Prefixed_Name(foaf, "made") |> PrefixedName
    /// <summary>
    ///   <para>foaf:maker</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An agent that  made this thing.</para>
    /// labels<para>maker</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/maker">http://xmlns.com/foaf/0.1/maker</seealso>
    let maker = Prefixed_Name(foaf, "maker") |> PrefixedName
    /// <summary>
    ///   <para>foaf:mbox_sha1sum</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The sha1sum of the URI of an Internet mailbox associated with exactly one owner, the  first owner of the mailbox.</para>
    /// labels<para>sha1sum of a personal mailbox URI name</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/mbox_sha1sum">http://xmlns.com/foaf/0.1/mbox_sha1sum</seealso>
    let mbox_sha1sum = Prefixed_Name(foaf, "mbox_sha1sum") |> PrefixedName
    /// <summary>
    ///   <para>foaf:membershipClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>Indicates the class of individuals that are a member of a Group</para>
    /// labels<para>membershipClass</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/membershipClass">http://xmlns.com/foaf/0.1/membershipClass</seealso>
    let membershipClass = Prefixed_Name(foaf, "membershipClass") |> PrefixedName
    /// <summary>
    ///   <para>foaf:myersBriggs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A Myers Briggs (MBTI) personality classification.</para>
    /// labels<para>myersBriggs</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/myersBriggs">http://xmlns.com/foaf/0.1/myersBriggs</seealso>
    let myersBriggs = Prefixed_Name(foaf, "myersBriggs") |> PrefixedName
    /// <summary>
    ///   <para>foaf:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A name for some thing.</para>
    /// labels<para>name</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/name">http://xmlns.com/foaf/0.1/name</seealso>
    let name = Prefixed_Name(foaf, "name") |> PrefixedName
    /// <summary>
    ///   <para>foaf:openid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>An OpenID for an Agent.</para>
    /// labels<para>openid</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/openid">http://xmlns.com/foaf/0.1/openid</seealso>
    let openid = Prefixed_Name(foaf, "openid") |> PrefixedName
    /// <summary>
    ///   <para>foaf:topic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A topic of some page or document.</para>
    /// labels<para>topic</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/topic">http://xmlns.com/foaf/0.1/topic</seealso>
    let topic = Prefixed_Name(foaf, "topic") |> PrefixedName
    /// <summary>
    ///   <para>foaf:pastProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A project this person has previously worked on.</para>
    /// labels<para>past project</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/pastProject">http://xmlns.com/foaf/0.1/pastProject</seealso>
    let pastProject = Prefixed_Name(foaf, "pastProject") |> PrefixedName
    /// <summary>
    ///   <para>foaf:plan</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A .plan comment, in the tradition of finger and '.plan' files.</para>
    /// labels<para>plan</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/plan">http://xmlns.com/foaf/0.1/plan</seealso>
    let plan = Prefixed_Name(foaf, "plan") |> PrefixedName
    /// <summary>
    ///   <para>foaf:publications</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A link to the publications of this person.</para>
    /// labels<para>publications</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/publications">http://xmlns.com/foaf/0.1/publications</seealso>
    let publications = Prefixed_Name(foaf, "publications") |> PrefixedName
    /// <summary>
    ///   <para>foaf:sha1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A sha1sum hash, in hex.</para>
    /// labels<para>sha1sum (hex)</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/sha1">http://xmlns.com/foaf/0.1/sha1</seealso>
    let sha1 = Prefixed_Name(foaf, "sha1") |> PrefixedName
    /// <summary>
    ///   <para>foaf:skypeID</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A Skype ID</para>
    /// labels<para>Skype ID</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/skypeID">http://xmlns.com/foaf/0.1/skypeID</seealso>
    let skypeID = Prefixed_Name(foaf, "skypeID") |> PrefixedName
    /// <summary>
    ///   <para>foaf:surname</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The surname of some person.</para>
    /// labels<para>Surname</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/surname">http://xmlns.com/foaf/0.1/surname</seealso>
    let surname = Prefixed_Name(foaf, "surname") |> PrefixedName
    /// <summary>
    ///   <para>foaf:theme</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A theme.</para>
    /// labels<para>theme</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/theme">http://xmlns.com/foaf/0.1/theme</seealso>
    let theme = Prefixed_Name(foaf, "theme") |> PrefixedName
    /// <summary>
    ///   <para>foaf:tipjar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A tipjar document for this agent, describing means for payment and reward.</para>
    /// labels<para>tipjar</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/tipjar">http://xmlns.com/foaf/0.1/tipjar</seealso>
    let tipjar = Prefixed_Name(foaf, "tipjar") |> PrefixedName
    /// <summary>
    ///   <para>foaf:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Title (Mr, Mrs, Ms, Dr. etc)</para>
    /// labels<para>title</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/title">http://xmlns.com/foaf/0.1/title</seealso>
    let title = Prefixed_Name(foaf, "title") |> PrefixedName
    /// <summary>
    ///   <para>foaf:topic_interest</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A thing of interest to this person.</para>
    /// labels<para>topic_interest</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/topic_interest">http://xmlns.com/foaf/0.1/topic_interest</seealso>
    let topic_interest = Prefixed_Name(foaf, "topic_interest") |> PrefixedName
    /// <summary>
    ///   <para>foaf:weblog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>A weblog of some thing (whether person, group, company etc.).</para>
    /// labels<para>weblog</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/weblog">http://xmlns.com/foaf/0.1/weblog</seealso>
    let weblog = Prefixed_Name(foaf, "weblog") |> PrefixedName
    /// <summary>
    ///   <para>foaf:workInfoHomepage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A work info homepage of some person; a page about their work for some organization.</para>
    /// labels<para>work info homepage</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/workInfoHomepage">http://xmlns.com/foaf/0.1/workInfoHomepage</seealso>
    let workInfoHomepage = Prefixed_Name(foaf, "workInfoHomepage") |> PrefixedName
    /// <summary>
    ///   <para>foaf:workplaceHomepage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A workplace homepage of some person; the homepage of an organization they work for.</para>
    /// labels<para>workplace homepage</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/workplaceHomepage">http://xmlns.com/foaf/0.1/workplaceHomepage</seealso>
    let workplaceHomepage = Prefixed_Name(foaf, "workplaceHomepage") |> PrefixedName
    /// <summary>
    ///   <para>foaf:yahooChatID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A Yahoo chat ID</para>
    /// labels<para>Yahoo chat ID</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/yahooChatID">http://xmlns.com/foaf/0.1/yahooChatID</seealso>
    let yahooChatID = Prefixed_Name(foaf, "yahooChatID") |> PrefixedName

    /// <summary>
    ///   <para>foaf:accountServiceHomepage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates a homepage of the service provide for this online account.</para>
    /// labels<para>account service homepage</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/accountServiceHomepage">http://xmlns.com/foaf/0.1/accountServiceHomepage</seealso>
    let accountServiceHomepage =
        Prefixed_Name(foaf, "accountServiceHomepage") |> PrefixedName

    /// <summary>
    ///   <para>foaf:aimChatID</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An AIM chat ID</para>
    /// labels<para>AIM chat ID</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/aimChatID">http://xmlns.com/foaf/0.1/aimChatID</seealso>
    let aimChatID = Prefixed_Name(foaf, "aimChatID") |> PrefixedName
    /// <summary>
    ///   <para>foaf:nick</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A short informal nickname characterising an agent (includes login identifiers, IRC and other chat nicknames).</para>
    /// labels<para>nickname</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/nick">http://xmlns.com/foaf/0.1/nick</seealso>
    let nick = Prefixed_Name(foaf, "nick") |> PrefixedName
    /// <summary>
    ///   <para>foaf:Project</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A project (a collective endeavour of some kind).</para>
    /// labels<para>Project</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/Project">http://xmlns.com/foaf/0.1/Project</seealso>
    let Project = Prefixed_Name(foaf, "Project") |> PrefixedName
    /// <summary>
    ///   <para>foaf:Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>An organization.</para>
    /// labels<para>Organization</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/Organization">http://xmlns.com/foaf/0.1/Organization</seealso>
    let Organization = Prefixed_Name(foaf, "Organization") |> PrefixedName
    /// <summary>
    ///   <para>foaf:page</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A page or document about this thing.</para>
    /// labels<para>page</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/page">http://xmlns.com/foaf/0.1/page</seealso>
    let page = Prefixed_Name(foaf, "page") |> PrefixedName
    /// <summary>
    ///   <para>foaf:Image</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>An image.</para>
    /// labels<para>Image</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/Image">http://xmlns.com/foaf/0.1/Image</seealso>
    let Image = Prefixed_Name(foaf, "Image") |> PrefixedName
    /// <summary>
    ///   <para>foaf:OnlineAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>An online account.</para>
    /// labels<para>Online Account</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/OnlineAccount">http://xmlns.com/foaf/0.1/OnlineAccount</seealso>
    let OnlineAccount = Prefixed_Name(foaf, "OnlineAccount") |> PrefixedName
    /// <summary>
    ///   <para>foaf:OnlineChatAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>An online chat account.</para>
    /// labels<para>Online Chat Account</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/OnlineChatAccount">http://xmlns.com/foaf/0.1/OnlineChatAccount</seealso>
    let OnlineChatAccount = Prefixed_Name(foaf, "OnlineChatAccount") |> PrefixedName

    /// <summary>
    ///   <para>foaf:OnlineEcommerceAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>An online e-commerce account.</para>
    /// labels<para>Online E-commerce Account</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/OnlineEcommerceAccount">http://xmlns.com/foaf/0.1/OnlineEcommerceAccount</seealso>
    let OnlineEcommerceAccount =
        Prefixed_Name(foaf, "OnlineEcommerceAccount") |> PrefixedName

    /// <summary>
    ///   <para>foaf:OnlineGamingAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>An online gaming account.</para>
    /// labels<para>Online Gaming Account</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/OnlineGamingAccount">http://xmlns.com/foaf/0.1/OnlineGamingAccount</seealso>
    let OnlineGamingAccount = Prefixed_Name(foaf, "OnlineGamingAccount") |> PrefixedName
    /// <summary>
    ///   <para>foaf:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A person.</para>
    /// labels<para>Person</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/Person">http://xmlns.com/foaf/0.1/Person</seealso>
    let Person = Prefixed_Name(foaf, "Person") |> PrefixedName
    /// <summary>
    ///   <para>foaf:account</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates an account held by this agent.</para>
    /// labels<para>account</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/account">http://xmlns.com/foaf/0.1/account</seealso>
    let account = Prefixed_Name(foaf, "account") |> PrefixedName
    /// <summary>
    ///   <para>foaf:phone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A phone,  specified using fully qualified tel: URI scheme (refs: http://www.w3.org/Addressing/schemes.html#tel).</para>
    /// labels<para>phone</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/phone">http://xmlns.com/foaf/0.1/phone</seealso>
    let phone = Prefixed_Name(foaf, "phone") |> PrefixedName
    /// <summary>
    ///   <para>foaf:LabelProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A foaf:LabelProperty is any RDF property with texual values that serve as labels.</para>
    /// labels<para>Label Property</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/LabelProperty">http://xmlns.com/foaf/0.1/LabelProperty</seealso>
    let LabelProperty = Prefixed_Name(foaf, "LabelProperty") |> PrefixedName
    /// <summary>
    ///   <para>foaf:mbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A  personal mailbox, ie. an Internet mailbox associated with exactly one owner, the first owner of this mailbox. This is a 'static inverse functional property', in that  there is (across time and change) at most one individual that ever has any particular value for foaf:mbox.</para>
    /// labels<para>personal mailbox</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/mbox">http://xmlns.com/foaf/0.1/mbox</seealso>
    let mbox = Prefixed_Name(foaf, "mbox") |> PrefixedName
    /// <summary>
    ///   <para>foaf:member</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates a member of a Group</para>
    /// labels<para>member</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/member">http://xmlns.com/foaf/0.1/member</seealso>
    let member_ = Prefixed_Name(foaf, "member") |> PrefixedName
    /// <summary>
    ///   <para>foaf:msnChatID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An MSN chat ID</para>
    /// labels<para>MSN chat ID</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/msnChatID">http://xmlns.com/foaf/0.1/msnChatID</seealso>
    let msnChatID = Prefixed_Name(foaf, "msnChatID") |> PrefixedName
    /// <summary>
    ///   <para>foaf:interest</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A page about a topic of interest to this person.</para>
    /// labels<para>interest</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/interest">http://xmlns.com/foaf/0.1/interest</seealso>
    let interest = Prefixed_Name(foaf, "interest") |> PrefixedName

    /// <summary>
    ///   <para>foaf:PersonalProfileDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A personal profile RDF document.</para>
    /// labels<para>PersonalProfileDocument</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/PersonalProfileDocument">http://xmlns.com/foaf/0.1/PersonalProfileDocument</seealso>
    let PersonalProfileDocument =
        Prefixed_Name(foaf, "PersonalProfileDocument") |> PrefixedName

    /// <summary>
    ///   <para>foaf:age</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The age in years of some agent.</para>
    /// labels<para>age</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/age">http://xmlns.com/foaf/0.1/age</seealso>
    let age = Prefixed_Name(foaf, "age") |> PrefixedName
    /// <summary>
    ///   <para>foaf:accountName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates the name (identifier) associated with this online account.</para>
    /// labels<para>account name</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/accountName">http://xmlns.com/foaf/0.1/accountName</seealso>
    let accountName = Prefixed_Name(foaf, "accountName") |> PrefixedName
    /// <summary>
    ///   <para>foaf:thumbnail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A derived thumbnail image.</para>
    /// labels<para>thumbnail</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/thumbnail">http://xmlns.com/foaf/0.1/thumbnail</seealso>
    let thumbnail = Prefixed_Name(foaf, "thumbnail") |> PrefixedName
    /// <summary>
    ///   <para>foaf:schoolHomepage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A homepage of a school attended by the person.</para>
    /// labels<para>schoolHomepage</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/schoolHomepage">http://xmlns.com/foaf/0.1/schoolHomepage</seealso>
    let schoolHomepage = Prefixed_Name(foaf, "schoolHomepage") |> PrefixedName
    /// <summary>
    ///   <para>foaf:status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A string expressing what the user is happy for the general public (normally) to know about their current activity.</para>
    /// labels<para>status</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/status">http://xmlns.com/foaf/0.1/status</seealso>
    let status = Prefixed_Name(foaf, "status") |> PrefixedName
    /// <summary>
    ///   <para>foaf:based_near</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A location that something is based near, for some broadly human notion of near.</para>
    /// labels<para>based near</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/based_near">http://xmlns.com/foaf/0.1/based_near</seealso>
    let based_near = Prefixed_Name(foaf, "based_near") |> PrefixedName
    /// <summary>
    ///   <para>foaf:currentProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A current project this person works on.</para>
    /// labels<para>current project</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/currentProject">http://xmlns.com/foaf/0.1/currentProject</seealso>
    let currentProject = Prefixed_Name(foaf, "currentProject") |> PrefixedName
    /// <summary>
    ///   <para>foaf:birthday</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The birthday of this Agent, represented in mm-dd string form, eg. '12-31'.</para>
    /// labels<para>birthday</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/birthday">http://xmlns.com/foaf/0.1/birthday</seealso>
    let birthday = Prefixed_Name(foaf, "birthday") |> PrefixedName
    /// <summary>
    ///   <para>foaf:depiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A depiction of some thing.</para>
    /// labels<para>depiction</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/depiction">http://xmlns.com/foaf/0.1/depiction</seealso>
    let depiction = Prefixed_Name(foaf, "depiction") |> PrefixedName
    /// <summary>
    ///   <para>foaf:depicts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A thing depicted in this representation.</para>
    /// labels<para>depicts</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/depicts">http://xmlns.com/foaf/0.1/depicts</seealso>
    let depicts = Prefixed_Name(foaf, "depicts") |> PrefixedName
    /// <summary>
    ///   <para>foaf:dnaChecksum</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A checksum for the DNA of some thing. Joke.</para>
    /// labels<para>DNA checksum</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/dnaChecksum">http://xmlns.com/foaf/0.1/dnaChecksum</seealso>
    let dnaChecksum = Prefixed_Name(foaf, "dnaChecksum") |> PrefixedName
    /// <summary>
    ///   <para>foaf:familyName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The family name of some person.</para>
    /// labels<para>familyName</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/familyName">http://xmlns.com/foaf/0.1/familyName</seealso>
    let familyName = Prefixed_Name(foaf, "familyName") |> PrefixedName
    /// <summary>
    ///   <para>foaf:family_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The family name of some person.</para>
    /// labels<para>family_name</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/family_name">http://xmlns.com/foaf/0.1/family_name</seealso>
    let family_name = Prefixed_Name(foaf, "family_name") |> PrefixedName
    /// <summary>
    ///   <para>foaf:focus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The underlying or 'focal' entity associated with some SKOS-described concept.</para>
    /// labels<para>focus</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/focus">http://xmlns.com/foaf/0.1/focus</seealso>
    let focus = Prefixed_Name(foaf, "focus") |> PrefixedName
    /// <summary>
    ///   <para>foaf:firstName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The first name of a person.</para>
    /// labels<para>firstName</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/firstName">http://xmlns.com/foaf/0.1/firstName</seealso>
    let firstName = Prefixed_Name(foaf, "firstName") |> PrefixedName
    /// <summary>
    ///   <para>foaf:fundedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>An organization funding a project or person.</para>
    /// labels<para>funded by</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/fundedBy">http://xmlns.com/foaf/0.1/fundedBy</seealso>
    let fundedBy = Prefixed_Name(foaf, "fundedBy") |> PrefixedName
    /// <summary>
    ///   <para>foaf:geekcode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A textual geekcode for this person, see http://www.geekcode.com/geek.html</para>
    /// labels<para>geekcode</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/geekcode">http://xmlns.com/foaf/0.1/geekcode</seealso>
    let geekcode = Prefixed_Name(foaf, "geekcode") |> PrefixedName
    /// <summary>
    ///   <para>foaf:givenName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The given name of some person.</para>
    /// labels<para>Given name</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/givenName">http://xmlns.com/foaf/0.1/givenName</seealso>
    let givenName = Prefixed_Name(foaf, "givenName") |> PrefixedName
    /// <summary>
    ///   <para>foaf:givenname</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The given name of some person.</para>
    /// labels<para>Given name</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/givenname">http://xmlns.com/foaf/0.1/givenname</seealso>
    let givenname = Prefixed_Name(foaf, "givenname") |> PrefixedName
    /// <summary>
    ///   <para>foaf:isPrimaryTopicOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>A document that this thing is the primary topic of.</para>
    /// labels<para>is primary topic of</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/isPrimaryTopicOf">http://xmlns.com/foaf/0.1/isPrimaryTopicOf</seealso>
    let isPrimaryTopicOf = Prefixed_Name(foaf, "isPrimaryTopicOf") |> PrefixedName
    /// <summary>
    ///   <para>foaf:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>An agent (eg. person, group, software or physical artifact).</para>
    /// labels<para>Agent</para></remarks>
    /// <seealso href="http://xmlns.com/foaf/0.1/Agent">http://xmlns.com/foaf/0.1/Agent</seealso>
    let Agent = Prefixed_Name(foaf, "Agent") |> PrefixedName

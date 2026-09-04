#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module foaf =
    let _prefixId = PrefixId.fromNamespaceLabel "http://xmlns.com/foaf/0.1/" "foaf"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : An agent (eg. person, group, software or physical artifact).^^xsd:string</para>
    ///   <para>rdfs:label : Agent^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/Agent">foaf:Agent</a>
    /// </summary>
    let Agent = _prefixId.prefix "Agent"
    /// <summary>
    ///   <para>rdfs:comment : A document.^^xsd:string</para>
    ///   <para>rdfs:label : Document^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/Document">foaf:Document</a>
    /// </summary>
    let Document = _prefixId.prefix "Document"
    /// <summary>
    ///   <para>rdfs:comment : A class of Agents.^^xsd:string</para>
    ///   <para>rdfs:label : Group^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/Group">foaf:Group</a>
    /// </summary>
    let Group = _prefixId.prefix "Group"
    /// <summary>
    ///   <para>rdfs:comment : An image.^^xsd:string</para>
    ///   <para>rdfs:label : Image^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/Image">foaf:Image</a>
    /// </summary>
    let Image = _prefixId.prefix "Image"
    /// <summary>
    ///   <para>rdfs:comment : A foaf:LabelProperty is any RDF property with texual values that serve as labels.^^xsd:string</para>
    ///   <para>rdfs:label : Label Property^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/LabelProperty">foaf:LabelProperty</a>
    /// </summary>
    let LabelProperty = _prefixId.prefix "LabelProperty"
    /// <summary>
    ///   <para>rdfs:comment : An online account.^^xsd:string</para>
    ///   <para>rdfs:label : Online Account^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/OnlineAccount">foaf:OnlineAccount</a>
    /// </summary>
    let OnlineAccount = _prefixId.prefix "OnlineAccount"
    /// <summary>
    ///   <para>rdfs:comment : An online chat account.^^xsd:string</para>
    ///   <para>rdfs:label : Online Chat Account^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/OnlineChatAccount">foaf:OnlineChatAccount</a>
    /// </summary>
    let OnlineChatAccount = _prefixId.prefix "OnlineChatAccount"
    /// <summary>
    ///   <para>rdfs:comment : An online e-commerce account.^^xsd:string</para>
    ///   <para>rdfs:label : Online E-commerce Account^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/OnlineEcommerceAccount">foaf:OnlineEcommerceAccount</a>
    /// </summary>
    let OnlineEcommerceAccount = _prefixId.prefix "OnlineEcommerceAccount"
    /// <summary>
    ///   <para>rdfs:comment : An online gaming account.^^xsd:string</para>
    ///   <para>rdfs:label : Online Gaming Account^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/OnlineGamingAccount">foaf:OnlineGamingAccount</a>
    /// </summary>
    let OnlineGamingAccount = _prefixId.prefix "OnlineGamingAccount"
    /// <summary>
    ///   <para>rdfs:comment : An organization.^^xsd:string</para>
    ///   <para>rdfs:label : Organization^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/Organization">foaf:Organization</a>
    /// </summary>
    let Organization = _prefixId.prefix "Organization"
    /// <summary>
    ///   <para>rdfs:comment : A person.^^xsd:string</para>
    ///   <para>rdfs:label : Person^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/Person">foaf:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>rdfs:comment : A personal profile RDF document.^^xsd:string</para>
    ///   <para>rdfs:label : PersonalProfileDocument^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/PersonalProfileDocument">foaf:PersonalProfileDocument</a>
    /// </summary>
    let PersonalProfileDocument = _prefixId.prefix "PersonalProfileDocument"
    /// <summary>
    ///   <para>rdfs:comment : A project (a collective endeavour of some kind).^^xsd:string</para>
    ///   <para>rdfs:label : Project^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/Project">foaf:Project</a>
    /// </summary>
    let Project = _prefixId.prefix "Project"
    /// <summary>
    ///   <para>rdfs:comment : Indicates an account held by this agent.^^xsd:string</para>
    ///   <para>rdfs:label : account^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/account">foaf:account</a>
    /// </summary>
    let account = _prefixId.prefix "account"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name (identifier) associated with this online account.^^xsd:string</para>
    ///   <para>rdfs:label : account name^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/accountName">foaf:accountName</a>
    /// </summary>
    let accountName = _prefixId.prefix "accountName"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a homepage of the service provide for this online account.^^xsd:string</para>
    ///   <para>rdfs:label : account service homepage^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/accountServiceHomepage">foaf:accountServiceHomepage</a>
    /// </summary>
    let accountServiceHomepage = _prefixId.prefix "accountServiceHomepage"
    /// <summary>
    ///   <para>rdfs:comment : The age in years of some agent.^^xsd:string</para>
    ///   <para>rdfs:label : age^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/age">foaf:age</a>
    /// </summary>
    let age = _prefixId.prefix "age"
    /// <summary>
    ///   <para>rdfs:comment : An AIM chat ID^^xsd:string</para>
    ///   <para>rdfs:label : AIM chat ID^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/aimChatID">foaf:aimChatID</a>
    /// </summary>
    let aimChatID = _prefixId.prefix "aimChatID"
    /// <summary>
    ///   <para>rdfs:comment : A location that something is based near, for some broadly human notion of near.^^xsd:string</para>
    ///   <para>rdfs:label : based near^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/based_near">foaf:based_near</a>
    /// </summary>
    let based_near = _prefixId.prefix "based_near"
    /// <summary>
    ///   <para>rdfs:comment : The birthday of this Agent, represented in mm-dd string form, eg. '12-31'.^^xsd:string</para>
    ///   <para>rdfs:label : birthday^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/birthday">foaf:birthday</a>
    /// </summary>
    let birthday = _prefixId.prefix "birthday"
    /// <summary>
    ///   <para>rdfs:comment : A current project this person works on.^^xsd:string</para>
    ///   <para>rdfs:label : current project^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/currentProject">foaf:currentProject</a>
    /// </summary>
    let currentProject = _prefixId.prefix "currentProject"
    /// <summary>
    ///   <para>rdfs:comment : A depiction of some thing.^^xsd:string</para>
    ///   <para>rdfs:label : depiction^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/depiction">foaf:depiction</a>
    /// </summary>
    let depiction = _prefixId.prefix "depiction"
    /// <summary>
    ///   <para>rdfs:comment : A thing depicted in this representation.^^xsd:string</para>
    ///   <para>rdfs:label : depicts^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/depicts">foaf:depicts</a>
    /// </summary>
    let depicts = _prefixId.prefix "depicts"
    /// <summary>
    ///   <para>rdfs:comment : A checksum for the DNA of some thing. Joke.^^xsd:string</para>
    ///   <para>rdfs:label : DNA checksum^^xsd:string</para>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/dnaChecksum">foaf:dnaChecksum</a>
    /// </summary>
    let dnaChecksum = _prefixId.prefix "dnaChecksum"
    /// <summary>
    ///   <para>rdfs:comment : The family name of some person.^^xsd:string</para>
    ///   <para>rdfs:label : familyName^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/familyName">foaf:familyName</a>
    /// </summary>
    let familyName = _prefixId.prefix "familyName"
    /// <summary>
    ///   <para>rdfs:comment : The family name of some person.^^xsd:string</para>
    ///   <para>rdfs:label : family_name^^xsd:string</para>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/family_name">foaf:family_name</a>
    /// </summary>
    let family_name = _prefixId.prefix "family_name"
    /// <summary>
    ///   <para>rdfs:comment : The first name of a person.^^xsd:string</para>
    ///   <para>rdfs:label : firstName^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/firstName">foaf:firstName</a>
    /// </summary>
    let firstName = _prefixId.prefix "firstName"
    /// <summary>
    ///   <para>rdfs:comment : The underlying or 'focal' entity associated with some SKOS-described concept.^^xsd:string</para>
    ///   <para>rdfs:label : focus^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/focus">foaf:focus</a>
    /// </summary>
    let focus = _prefixId.prefix "focus"
    /// <summary>
    ///   <para>rdfs:comment : An organization funding a project or person.^^xsd:string</para>
    ///   <para>rdfs:label : funded by^^xsd:string</para>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/fundedBy">foaf:fundedBy</a>
    /// </summary>
    let fundedBy = _prefixId.prefix "fundedBy"
    /// <summary>
    ///   <para>rdfs:comment : A textual geekcode for this person, see http://www.geekcode.com/geek.html^^xsd:string</para>
    ///   <para>rdfs:label : geekcode^^xsd:string</para>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/geekcode">foaf:geekcode</a>
    /// </summary>
    let geekcode = _prefixId.prefix "geekcode"
    /// <summary>
    ///   <para>rdfs:comment : The gender of this Agent (typically but not necessarily 'male' or 'female').^^xsd:string</para>
    ///   <para>rdfs:label : gender^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/gender">foaf:gender</a>
    /// </summary>
    let gender = _prefixId.prefix "gender"
    /// <summary>
    ///   <para>rdfs:comment : The given name of some person.^^xsd:string</para>
    ///   <para>rdfs:label : Given name^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/givenName">foaf:givenName</a>
    /// </summary>
    let givenName = _prefixId.prefix "givenName"
    /// <summary>
    ///   <para>rdfs:comment : The given name of some person.^^xsd:string</para>
    ///   <para>rdfs:label : Given name^^xsd:string</para>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/givenname">foaf:givenname</a>
    /// </summary>
    let givenname = _prefixId.prefix "givenname"
    /// <summary>
    ///   <para>rdfs:comment : Indicates an account held by this agent.^^xsd:string</para>
    ///   <para>rdfs:label : account^^xsd:string</para>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/holdsAccount">foaf:holdsAccount</a>
    /// </summary>
    let holdsAccount = _prefixId.prefix "holdsAccount"
    /// <summary>
    ///   <para>rdfs:comment : A homepage for some thing.^^xsd:string</para>
    ///   <para>rdfs:label : homepage^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/homepage">foaf:homepage</a>
    /// </summary>
    let homepage = _prefixId.prefix "homepage"
    /// <summary>
    ///   <para>rdfs:comment : An ICQ chat ID^^xsd:string</para>
    ///   <para>rdfs:label : ICQ chat ID^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/icqChatID">foaf:icqChatID</a>
    /// </summary>
    let icqChatID = _prefixId.prefix "icqChatID"
    /// <summary>
    ///   <para>rdfs:comment : An image that can be used to represent some thing (ie. those depictions which are particularly representative of something, eg. one's photo on a homepage).^^xsd:string</para>
    ///   <para>rdfs:label : image^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/img">foaf:img</a>
    /// </summary>
    let img = _prefixId.prefix "img"
    /// <summary>
    ///   <para>rdfs:comment : A page about a topic of interest to this person.^^xsd:string</para>
    ///   <para>rdfs:label : interest^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/interest">foaf:interest</a>
    /// </summary>
    let interest = _prefixId.prefix "interest"
    /// <summary>
    ///   <para>rdfs:comment : A document that this thing is the primary topic of.^^xsd:string</para>
    ///   <para>rdfs:label : is primary topic of^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/isPrimaryTopicOf">foaf:isPrimaryTopicOf</a>
    /// </summary>
    let isPrimaryTopicOf = _prefixId.prefix "isPrimaryTopicOf"
    /// <summary>
    ///   <para>rdfs:comment : A jabber ID for something.^^xsd:string</para>
    ///   <para>rdfs:label : jabber ID^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/jabberID">foaf:jabberID</a>
    /// </summary>
    let jabberID = _prefixId.prefix "jabberID"
    /// <summary>
    ///   <para>rdfs:comment : A person known by this person (indicating some level of reciprocated interaction between the parties).^^xsd:string</para>
    ///   <para>rdfs:label : knows^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/knows">foaf:knows</a>
    /// </summary>
    let knows = _prefixId.prefix "knows"
    /// <summary>
    ///   <para>rdfs:comment : The last name of a person.^^xsd:string</para>
    ///   <para>rdfs:label : lastName^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/lastName">foaf:lastName</a>
    /// </summary>
    let lastName = _prefixId.prefix "lastName"
    /// <summary>
    ///   <para>rdfs:comment : A logo representing some thing.^^xsd:string</para>
    ///   <para>rdfs:label : logo^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/logo">foaf:logo</a>
    /// </summary>
    let logo = _prefixId.prefix "logo"
    /// <summary>
    ///   <para>rdfs:comment : Something that was made by this agent.^^xsd:string</para>
    ///   <para>rdfs:label : made^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/made">foaf:made</a>
    /// </summary>
    let made = _prefixId.prefix "made"
    /// <summary>
    ///   <para>rdfs:comment : An agent that made this thing.^^xsd:string</para>
    ///   <para>rdfs:label : maker^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/maker">foaf:maker</a>
    /// </summary>
    let maker = _prefixId.prefix "maker"
    /// <summary>
    ///   <para>rdfs:comment : A personal mailbox, ie. an Internet mailbox associated with exactly one owner, the first owner of this mailbox. This is a 'static inverse functional property', in that there is (across time and change) at most one individual that ever has any particular value for foaf:mbox.^^xsd:string</para>
    ///   <para>rdfs:label : personal mailbox^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/mbox">foaf:mbox</a>
    /// </summary>
    let mbox = _prefixId.prefix "mbox"
    /// <summary>
    ///   <para>rdfs:comment : The sha1sum of the URI of an Internet mailbox associated with exactly one owner, the first owner of the mailbox.^^xsd:string</para>
    ///   <para>rdfs:label : sha1sum of a personal mailbox URI name^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/mbox_sha1sum">foaf:mbox_sha1sum</a>
    /// </summary>
    let mbox_sha1sum = _prefixId.prefix "mbox_sha1sum"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a member of a Group^^xsd:string</para>
    ///   <para>rdfs:label : member^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/member">foaf:member</a>
    /// </summary>
    let member_ = _prefixId.prefix "member"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the class of individuals that are a member of a Group^^xsd:string</para>
    ///   <para>rdfs:label : membershipClass^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/membershipClass">foaf:membershipClass</a>
    /// </summary>
    let membershipClass = _prefixId.prefix "membershipClass"
    /// <summary>
    ///   <para>rdfs:comment : An MSN chat ID^^xsd:string</para>
    ///   <para>rdfs:label : MSN chat ID^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/msnChatID">foaf:msnChatID</a>
    /// </summary>
    let msnChatID = _prefixId.prefix "msnChatID"
    /// <summary>
    ///   <para>rdfs:comment : A Myers Briggs (MBTI) personality classification.^^xsd:string</para>
    ///   <para>rdfs:label : myersBriggs^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/myersBriggs">foaf:myersBriggs</a>
    /// </summary>
    let myersBriggs = _prefixId.prefix "myersBriggs"
    /// <summary>
    ///   <para>rdfs:comment : A name for some thing.^^xsd:string</para>
    ///   <para>rdfs:label : name^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/name">foaf:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>rdfs:comment : A short informal nickname characterising an agent (includes login identifiers, IRC and other chat nicknames).^^xsd:string</para>
    ///   <para>rdfs:label : nickname^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/nick">foaf:nick</a>
    /// </summary>
    let nick = _prefixId.prefix "nick"
    /// <summary>
    ///   <para>rdfs:comment : An OpenID for an Agent.^^xsd:string</para>
    ///   <para>rdfs:label : openid^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/openid">foaf:openid</a>
    /// </summary>
    let openid = _prefixId.prefix "openid"
    /// <summary>
    ///   <para>rdfs:comment : A page or document about this thing.^^xsd:string</para>
    ///   <para>rdfs:label : page^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/page">foaf:page</a>
    /// </summary>
    let page = _prefixId.prefix "page"
    /// <summary>
    ///   <para>rdfs:comment : A project this person has previously worked on.^^xsd:string</para>
    ///   <para>rdfs:label : past project^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/pastProject">foaf:pastProject</a>
    /// </summary>
    let pastProject = _prefixId.prefix "pastProject"
    /// <summary>
    ///   <para>rdfs:comment : A phone, specified using fully qualified tel: URI scheme (refs: http://www.w3.org/Addressing/schemes.html#tel).^^xsd:string</para>
    ///   <para>rdfs:label : phone^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/phone">foaf:phone</a>
    /// </summary>
    let phone = _prefixId.prefix "phone"
    /// <summary>
    ///   <para>rdfs:comment : A .plan comment, in the tradition of finger and '.plan' files.^^xsd:string</para>
    ///   <para>rdfs:label : plan^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/plan">foaf:plan</a>
    /// </summary>
    let plan = _prefixId.prefix "plan"
    /// <summary>
    ///   <para>rdfs:comment : The primary topic of some page or document.^^xsd:string</para>
    ///   <para>rdfs:label : primary topic^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/primaryTopic">foaf:primaryTopic</a>
    /// </summary>
    let primaryTopic = _prefixId.prefix "primaryTopic"
    /// <summary>
    ///   <para>rdfs:comment : A link to the publications of this person.^^xsd:string</para>
    ///   <para>rdfs:label : publications^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/publications">foaf:publications</a>
    /// </summary>
    let publications = _prefixId.prefix "publications"
    /// <summary>
    ///   <para>rdfs:comment : A homepage of a school attended by the person.^^xsd:string</para>
    ///   <para>rdfs:label : schoolHomepage^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/schoolHomepage">foaf:schoolHomepage</a>
    /// </summary>
    let schoolHomepage = _prefixId.prefix "schoolHomepage"
    /// <summary>
    ///   <para>rdfs:comment : A sha1sum hash, in hex.^^xsd:string</para>
    ///   <para>rdfs:label : sha1sum (hex)^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/sha1">foaf:sha1</a>
    /// </summary>
    let sha1 = _prefixId.prefix "sha1"
    /// <summary>
    ///   <para>rdfs:comment : A Skype ID^^xsd:string</para>
    ///   <para>rdfs:label : Skype ID^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/skypeID">foaf:skypeID</a>
    /// </summary>
    let skypeID = _prefixId.prefix "skypeID"
    /// <summary>
    ///   <para>rdfs:comment : A string expressing what the user is happy for the general public (normally) to know about their current activity.^^xsd:string</para>
    ///   <para>rdfs:label : status^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/status">foaf:status</a>
    /// </summary>
    let status = _prefixId.prefix "status"
    /// <summary>
    ///   <para>rdfs:comment : The surname of some person.^^xsd:string</para>
    ///   <para>rdfs:label : Surname^^xsd:string</para>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/surname">foaf:surname</a>
    /// </summary>
    let surname = _prefixId.prefix "surname"
    /// <summary>
    ///   <para>rdfs:comment : A theme.^^xsd:string</para>
    ///   <para>rdfs:label : theme^^xsd:string</para>
    ///   <para>vs:term_status : archaic^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/theme">foaf:theme</a>
    /// </summary>
    let theme = _prefixId.prefix "theme"
    /// <summary>
    ///   <para>rdfs:comment : A derived thumbnail image.^^xsd:string</para>
    ///   <para>rdfs:label : thumbnail^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/thumbnail">foaf:thumbnail</a>
    /// </summary>
    let thumbnail = _prefixId.prefix "thumbnail"
    /// <summary>
    ///   <para>rdfs:comment : A tipjar document for this agent, describing means for payment and reward.^^xsd:string</para>
    ///   <para>rdfs:label : tipjar^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/tipjar">foaf:tipjar</a>
    /// </summary>
    let tipjar = _prefixId.prefix "tipjar"
    /// <summary>
    ///   <para>rdfs:comment : Title (Mr, Mrs, Ms, Dr. etc)^^xsd:string</para>
    ///   <para>rdfs:label : title^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/title">foaf:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>rdfs:comment : A topic of some page or document.^^xsd:string</para>
    ///   <para>rdfs:label : topic^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/topic">foaf:topic</a>
    /// </summary>
    let topic = _prefixId.prefix "topic"
    /// <summary>
    ///   <para>rdfs:comment : A thing of interest to this person.^^xsd:string</para>
    ///   <para>rdfs:label : topic_interest^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/topic_interest">foaf:topic_interest</a>
    /// </summary>
    let topic_interest = _prefixId.prefix "topic_interest"
    /// <summary>
    ///   <para>rdfs:comment : A weblog of some thing (whether person, group, company etc.).^^xsd:string</para>
    ///   <para>rdfs:label : weblog^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/weblog">foaf:weblog</a>
    /// </summary>
    let weblog = _prefixId.prefix "weblog"
    /// <summary>
    ///   <para>rdfs:comment : A work info homepage of some person; a page about their work for some organization.^^xsd:string</para>
    ///   <para>rdfs:label : work info homepage^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/workInfoHomepage">foaf:workInfoHomepage</a>
    /// </summary>
    let workInfoHomepage = _prefixId.prefix "workInfoHomepage"
    /// <summary>
    ///   <para>rdfs:comment : A workplace homepage of some person; the homepage of an organization they work for.^^xsd:string</para>
    ///   <para>rdfs:label : workplace homepage^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/workplaceHomepage">foaf:workplaceHomepage</a>
    /// </summary>
    let workplaceHomepage = _prefixId.prefix "workplaceHomepage"
    /// <summary>
    ///   <para>rdfs:comment : A Yahoo chat ID^^xsd:string</para>
    ///   <para>rdfs:label : Yahoo chat ID^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://xmlns.com/foaf/0.1/yahooChatID">foaf:yahooChatID</a>
    /// </summary>
    let yahooChatID = _prefixId.prefix "yahooChatID"

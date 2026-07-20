namespace http.xmlns.com.foaf._0._1.slash

open DoxAletheia

module foaf =
    let _namespace_name = "http://xmlns.com/foaf/0.1/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An agent (eg. person, group, software or physical artifact).
    /// <see href="http://xmlns.com/foaf/0.1/Agent"></see></summary>
    let Agent = _prefix "Agent"
    /// <summary>
    /// A document.
    /// <see href="http://xmlns.com/foaf/0.1/Document"></see></summary>
    let Document = _prefix "Document"
    /// <summary>
    /// A project (a collective endeavour of some kind).
    /// <see href="http://xmlns.com/foaf/0.1/Project"></see></summary>
    let Project = _prefix "Project"
    /// <summary>
    /// An organization.
    /// <see href="http://xmlns.com/foaf/0.1/Organization"></see></summary>
    let Organization = _prefix "Organization"
    /// <summary>
    /// A class of Agents.
    /// <see href="http://xmlns.com/foaf/0.1/Group"></see></summary>
    let Group = _prefix "Group"
    /// <summary>
    /// An image.
    /// <see href="http://xmlns.com/foaf/0.1/Image"></see></summary>
    let Image = _prefix "Image"
    /// <summary>
    /// A foaf:LabelProperty is any RDF property with texual values that serve as labels.
    /// <see href="http://xmlns.com/foaf/0.1/LabelProperty"></see></summary>
    let LabelProperty = _prefix "LabelProperty"
    /// <summary>
    /// An online account.
    /// <see href="http://xmlns.com/foaf/0.1/OnlineAccount"></see></summary>
    let OnlineAccount = _prefix "OnlineAccount"
    /// <summary>
    /// An online chat account.
    /// <see href="http://xmlns.com/foaf/0.1/OnlineChatAccount"></see></summary>
    let OnlineChatAccount = _prefix "OnlineChatAccount"
    /// <summary>
    /// An online e-commerce account.
    /// <see href="http://xmlns.com/foaf/0.1/OnlineEcommerceAccount"></see></summary>
    let OnlineEcommerceAccount = _prefix "OnlineEcommerceAccount"
    /// <summary>
    /// An online gaming account.
    /// <see href="http://xmlns.com/foaf/0.1/OnlineGamingAccount"></see></summary>
    let OnlineGamingAccount = _prefix "OnlineGamingAccount"
    /// <summary>
    /// A person.
    /// <see href="http://xmlns.com/foaf/0.1/Person"></see></summary>
    let Person = _prefix "Person"
    /// <summary>
    /// A personal profile RDF document.
    /// <see href="http://xmlns.com/foaf/0.1/PersonalProfileDocument"></see></summary>
    let PersonalProfileDocument = _prefix "PersonalProfileDocument"
    /// <summary>
    /// Indicates an account held by this agent.
    /// <see href="http://xmlns.com/foaf/0.1/account"></see></summary>
    let account = _prefix "account"
    /// <summary>
    /// Indicates the name (identifier) associated with this online account.
    /// <see href="http://xmlns.com/foaf/0.1/accountName"></see></summary>
    let accountName = _prefix "accountName"
    /// <summary>
    /// Indicates a homepage of the service provide for this online account.
    /// <see href="http://xmlns.com/foaf/0.1/accountServiceHomepage"></see></summary>
    let accountServiceHomepage = _prefix "accountServiceHomepage"
    /// <summary>
    /// The age in years of some agent.
    /// <see href="http://xmlns.com/foaf/0.1/age"></see></summary>
    let age = _prefix "age"
    /// <summary>
    /// An AIM chat ID
    /// <see href="http://xmlns.com/foaf/0.1/aimChatID"></see></summary>
    let aimChatID = _prefix "aimChatID"
    /// <summary>
    /// A short informal nickname characterising an agent (includes login identifiers, IRC and other chat nicknames).
    /// <see href="http://xmlns.com/foaf/0.1/nick"></see></summary>
    let nick = _prefix "nick"
    /// <summary>
    /// A location that something is based near, for some broadly human notion of near.
    /// <see href="http://xmlns.com/foaf/0.1/based_near"></see></summary>
    let based_near = _prefix "based_near"
    /// <summary>
    /// The birthday of this Agent, represented in mm-dd string form, eg. '12-31'.
    /// <see href="http://xmlns.com/foaf/0.1/birthday"></see></summary>
    let birthday = _prefix "birthday"
    /// <summary>
    /// A current project this person works on.
    /// <see href="http://xmlns.com/foaf/0.1/currentProject"></see></summary>
    let currentProject = _prefix "currentProject"
    /// <summary>
    /// A depiction of some thing.
    /// <see href="http://xmlns.com/foaf/0.1/depiction"></see></summary>
    let depiction = _prefix "depiction"
    /// <summary>
    /// A thing depicted in this representation.
    /// <see href="http://xmlns.com/foaf/0.1/depicts"></see></summary>
    let depicts = _prefix "depicts"
    /// <summary>
    /// A checksum for the DNA of some thing. Joke.
    /// <see href="http://xmlns.com/foaf/0.1/dnaChecksum"></see></summary>
    let dnaChecksum = _prefix "dnaChecksum"
    /// <summary>
    /// The family name of some person.
    /// <see href="http://xmlns.com/foaf/0.1/familyName"></see></summary>
    let familyName = _prefix "familyName"
    /// <summary>
    /// The family name of some person.
    /// <see href="http://xmlns.com/foaf/0.1/family_name"></see></summary>
    let family_name = _prefix "family_name"
    /// <summary>
    /// The first name of a person.
    /// <see href="http://xmlns.com/foaf/0.1/firstName"></see></summary>
    let firstName = _prefix "firstName"
    /// <summary>
    /// The underlying or 'focal' entity associated with some SKOS-described concept.
    /// <see href="http://xmlns.com/foaf/0.1/focus"></see></summary>
    let focus = _prefix "focus"
    /// <summary>
    /// An organization funding a project or person.
    /// <see href="http://xmlns.com/foaf/0.1/fundedBy"></see></summary>
    let fundedBy = _prefix "fundedBy"
    /// <summary>
    /// A textual geekcode for this person, see http://www.geekcode.com/geek.html
    /// <see href="http://xmlns.com/foaf/0.1/geekcode"></see></summary>
    let geekcode = _prefix "geekcode"
    /// <summary>
    /// The gender of this Agent (typically but not necessarily 'male' or 'female').
    /// <see href="http://xmlns.com/foaf/0.1/gender"></see></summary>
    let gender = _prefix "gender"
    /// <summary>
    /// The given name of some person.
    /// <see href="http://xmlns.com/foaf/0.1/givenName"></see></summary>
    let givenName = _prefix "givenName"
    /// <summary>
    /// The given name of some person.
    /// <see href="http://xmlns.com/foaf/0.1/givenname"></see></summary>
    let givenname = _prefix "givenname"
    /// <summary>
    /// Indicates an account held by this agent.
    /// <see href="http://xmlns.com/foaf/0.1/holdsAccount"></see></summary>
    let holdsAccount = _prefix "holdsAccount"
    /// <summary>
    /// A homepage for some thing.
    /// <see href="http://xmlns.com/foaf/0.1/homepage"></see></summary>
    let homepage = _prefix "homepage"
    /// <summary>
    /// A page or document about this thing.
    /// <see href="http://xmlns.com/foaf/0.1/page"></see></summary>
    let page = _prefix "page"
    /// <summary>
    /// A document that this thing is the primary topic of.
    /// <see href="http://xmlns.com/foaf/0.1/isPrimaryTopicOf"></see></summary>
    let isPrimaryTopicOf = _prefix "isPrimaryTopicOf"
    /// <summary>
    /// An ICQ chat ID
    /// <see href="http://xmlns.com/foaf/0.1/icqChatID"></see></summary>
    let icqChatID = _prefix "icqChatID"
    /// <summary>
    /// An image that can be used to represent some thing (ie. those depictions which are particularly representative of something, eg. one's photo on a homepage).
    /// <see href="http://xmlns.com/foaf/0.1/img"></see></summary>
    let img = _prefix "img"
    /// <summary>
    /// A page about a topic of interest to this person.
    /// <see href="http://xmlns.com/foaf/0.1/interest"></see></summary>
    let interest = _prefix "interest"
    /// <summary>
    /// The primary topic of some page or document.
    /// <see href="http://xmlns.com/foaf/0.1/primaryTopic"></see></summary>
    let primaryTopic = _prefix "primaryTopic"
    /// <summary>
    /// A jabber ID for something.
    /// <see href="http://xmlns.com/foaf/0.1/jabberID"></see></summary>
    let jabberID = _prefix "jabberID"
    /// <summary>
    /// A person known by this person (indicating some level of reciprocated interaction between the parties).
    /// <see href="http://xmlns.com/foaf/0.1/knows"></see></summary>
    let knows = _prefix "knows"
    /// <summary>
    /// The last name of a person.
    /// <see href="http://xmlns.com/foaf/0.1/lastName"></see></summary>
    let lastName = _prefix "lastName"
    /// <summary>
    /// A logo representing some thing.
    /// <see href="http://xmlns.com/foaf/0.1/logo"></see></summary>
    let logo = _prefix "logo"
    /// <summary>
    /// Something that was made by this agent.
    /// <see href="http://xmlns.com/foaf/0.1/made"></see></summary>
    let made = _prefix "made"
    /// <summary>
    /// An agent that  made this thing.
    /// <see href="http://xmlns.com/foaf/0.1/maker"></see></summary>
    let maker = _prefix "maker"
    /// <summary>
    /// A  personal mailbox, ie. an Internet mailbox associated with exactly one owner, the first owner of this mailbox. This is a 'static inverse functional property', in that  there is (across time and change) at most one individual that ever has any particular value for foaf:mbox.
    /// <see href="http://xmlns.com/foaf/0.1/mbox"></see></summary>
    let mbox = _prefix "mbox"
    /// <summary>
    /// The sha1sum of the URI of an Internet mailbox associated with exactly one owner, the  first owner of the mailbox.
    /// <see href="http://xmlns.com/foaf/0.1/mbox_sha1sum"></see></summary>
    let mbox_sha1sum = _prefix "mbox_sha1sum"
    /// <summary>
    /// Indicates a member of a Group
    /// <see href="http://xmlns.com/foaf/0.1/member"></see></summary>
    let member_ = _prefix "member"
    /// <summary>
    /// Indicates the class of individuals that are a member of a Group
    /// <see href="http://xmlns.com/foaf/0.1/membershipClass"></see></summary>
    let membershipClass = _prefix "membershipClass"
    /// <summary>
    /// An MSN chat ID
    /// <see href="http://xmlns.com/foaf/0.1/msnChatID"></see></summary>
    let msnChatID = _prefix "msnChatID"
    /// <summary>
    /// A Myers Briggs (MBTI) personality classification.
    /// <see href="http://xmlns.com/foaf/0.1/myersBriggs"></see></summary>
    let myersBriggs = _prefix "myersBriggs"
    /// <summary>
    /// A name for some thing.
    /// <see href="http://xmlns.com/foaf/0.1/name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// An OpenID for an Agent.
    /// <see href="http://xmlns.com/foaf/0.1/openid"></see></summary>
    let openid = _prefix "openid"
    /// <summary>
    /// A topic of some page or document.
    /// <see href="http://xmlns.com/foaf/0.1/topic"></see></summary>
    let topic = _prefix "topic"
    /// <summary>
    /// A project this person has previously worked on.
    /// <see href="http://xmlns.com/foaf/0.1/pastProject"></see></summary>
    let pastProject = _prefix "pastProject"
    /// <summary>
    /// A phone,  specified using fully qualified tel: URI scheme (refs: http://www.w3.org/Addressing/schemes.html#tel).
    /// <see href="http://xmlns.com/foaf/0.1/phone"></see></summary>
    let phone = _prefix "phone"
    /// <summary>
    /// A .plan comment, in the tradition of finger and '.plan' files.
    /// <see href="http://xmlns.com/foaf/0.1/plan"></see></summary>
    let plan = _prefix "plan"
    /// <summary>
    /// A link to the publications of this person.
    /// <see href="http://xmlns.com/foaf/0.1/publications"></see></summary>
    let publications = _prefix "publications"
    /// <summary>
    /// A homepage of a school attended by the person.
    /// <see href="http://xmlns.com/foaf/0.1/schoolHomepage"></see></summary>
    let schoolHomepage = _prefix "schoolHomepage"
    /// <summary>
    /// A sha1sum hash, in hex.
    /// <see href="http://xmlns.com/foaf/0.1/sha1"></see></summary>
    let sha1 = _prefix "sha1"
    /// <summary>
    /// A Skype ID
    /// <see href="http://xmlns.com/foaf/0.1/skypeID"></see></summary>
    let skypeID = _prefix "skypeID"
    /// <summary>
    /// A string expressing what the user is happy for the general public (normally) to know about their current activity.
    /// <see href="http://xmlns.com/foaf/0.1/status"></see></summary>
    let status = _prefix "status"
    /// <summary>
    /// The surname of some person.
    /// <see href="http://xmlns.com/foaf/0.1/surname"></see></summary>
    let surname = _prefix "surname"
    /// <summary>
    /// A theme.
    /// <see href="http://xmlns.com/foaf/0.1/theme"></see></summary>
    let theme = _prefix "theme"
    /// <summary>
    /// A derived thumbnail image.
    /// <see href="http://xmlns.com/foaf/0.1/thumbnail"></see></summary>
    let thumbnail = _prefix "thumbnail"
    /// <summary>
    /// A tipjar document for this agent, describing means for payment and reward.
    /// <see href="http://xmlns.com/foaf/0.1/tipjar"></see></summary>
    let tipjar = _prefix "tipjar"
    /// <summary>
    /// Title (Mr, Mrs, Ms, Dr. etc)
    /// <see href="http://xmlns.com/foaf/0.1/title"></see></summary>
    let title = _prefix "title"
    /// <summary>
    /// A thing of interest to this person.
    /// <see href="http://xmlns.com/foaf/0.1/topic_interest"></see></summary>
    let topic_interest = _prefix "topic_interest"
    /// <summary>
    /// A weblog of some thing (whether person, group, company etc.).
    /// <see href="http://xmlns.com/foaf/0.1/weblog"></see></summary>
    let weblog = _prefix "weblog"
    /// <summary>
    /// A work info homepage of some person; a page about their work for some organization.
    /// <see href="http://xmlns.com/foaf/0.1/workInfoHomepage"></see></summary>
    let workInfoHomepage = _prefix "workInfoHomepage"
    /// <summary>
    /// A workplace homepage of some person; the homepage of an organization they work for.
    /// <see href="http://xmlns.com/foaf/0.1/workplaceHomepage"></see></summary>
    let workplaceHomepage = _prefix "workplaceHomepage"
    /// <summary>
    /// A Yahoo chat ID
    /// <see href="http://xmlns.com/foaf/0.1/yahooChatID"></see></summary>
    let yahooChatID = _prefix "yahooChatID"

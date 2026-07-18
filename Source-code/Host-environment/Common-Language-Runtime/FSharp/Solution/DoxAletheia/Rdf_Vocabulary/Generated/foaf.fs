namespace http.xmlns.com.foaf._0._1.slash

open DoxAletheia.Rdf_Vocabulary

module foaf =
    let _namespace_name = "http://xmlns.com/foaf/0.1/"
    /// <summary>
    /// An agent (eg. person, group, software or physical artifact).
    /// <see href="http://xmlns.com/foaf/0.1/Agent"></see></summary>
    let Agent = Namespaced_IRI.parse _namespace_name "Agent" |> NamespacedName
    /// <summary>
    /// A document.
    /// <see href="http://xmlns.com/foaf/0.1/Document"></see></summary>
    let Document = Namespaced_IRI.parse _namespace_name "Document" |> NamespacedName
    /// <summary>
    /// A project (a collective endeavour of some kind).
    /// <see href="http://xmlns.com/foaf/0.1/Project"></see></summary>
    let Project = Namespaced_IRI.parse _namespace_name "Project" |> NamespacedName

    /// <summary>
    /// An organization.
    /// <see href="http://xmlns.com/foaf/0.1/Organization"></see></summary>
    let Organization =
        Namespaced_IRI.parse _namespace_name "Organization" |> NamespacedName

    /// <summary>
    /// A class of Agents.
    /// <see href="http://xmlns.com/foaf/0.1/Group"></see></summary>
    let Group = Namespaced_IRI.parse _namespace_name "Group" |> NamespacedName
    /// <summary>
    /// An image.
    /// <see href="http://xmlns.com/foaf/0.1/Image"></see></summary>
    let Image = Namespaced_IRI.parse _namespace_name "Image" |> NamespacedName

    /// <summary>
    /// A foaf:LabelProperty is any RDF property with texual values that serve as labels.
    /// <see href="http://xmlns.com/foaf/0.1/LabelProperty"></see></summary>
    let LabelProperty =
        Namespaced_IRI.parse _namespace_name "LabelProperty" |> NamespacedName

    /// <summary>
    /// An online account.
    /// <see href="http://xmlns.com/foaf/0.1/OnlineAccount"></see></summary>
    let OnlineAccount =
        Namespaced_IRI.parse _namespace_name "OnlineAccount" |> NamespacedName

    /// <summary>
    /// An online chat account.
    /// <see href="http://xmlns.com/foaf/0.1/OnlineChatAccount"></see></summary>
    let OnlineChatAccount =
        Namespaced_IRI.parse _namespace_name "OnlineChatAccount" |> NamespacedName

    /// <summary>
    /// An online e-commerce account.
    /// <see href="http://xmlns.com/foaf/0.1/OnlineEcommerceAccount"></see></summary>
    let OnlineEcommerceAccount =
        Namespaced_IRI.parse _namespace_name "OnlineEcommerceAccount" |> NamespacedName

    /// <summary>
    /// An online gaming account.
    /// <see href="http://xmlns.com/foaf/0.1/OnlineGamingAccount"></see></summary>
    let OnlineGamingAccount =
        Namespaced_IRI.parse _namespace_name "OnlineGamingAccount" |> NamespacedName

    /// <summary>
    /// A person.
    /// <see href="http://xmlns.com/foaf/0.1/Person"></see></summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName

    /// <summary>
    /// A personal profile RDF document.
    /// <see href="http://xmlns.com/foaf/0.1/PersonalProfileDocument"></see></summary>
    let PersonalProfileDocument =
        Namespaced_IRI.parse _namespace_name "PersonalProfileDocument" |> NamespacedName

    /// <summary>
    /// Indicates an account held by this agent.
    /// <see href="http://xmlns.com/foaf/0.1/account"></see></summary>
    let account = Namespaced_IRI.parse _namespace_name "account" |> NamespacedName

    /// <summary>
    /// Indicates the name (identifier) associated with this online account.
    /// <see href="http://xmlns.com/foaf/0.1/accountName"></see></summary>
    let accountName =
        Namespaced_IRI.parse _namespace_name "accountName" |> NamespacedName

    /// <summary>
    /// Indicates a homepage of the service provide for this online account.
    /// <see href="http://xmlns.com/foaf/0.1/accountServiceHomepage"></see></summary>
    let accountServiceHomepage =
        Namespaced_IRI.parse _namespace_name "accountServiceHomepage" |> NamespacedName

    /// <summary>
    /// The age in years of some agent.
    /// <see href="http://xmlns.com/foaf/0.1/age"></see></summary>
    let age = Namespaced_IRI.parse _namespace_name "age" |> NamespacedName
    /// <summary>
    /// An AIM chat ID
    /// <see href="http://xmlns.com/foaf/0.1/aimChatID"></see></summary>
    let aimChatID = Namespaced_IRI.parse _namespace_name "aimChatID" |> NamespacedName
    /// <summary>
    /// A short informal nickname characterising an agent (includes login identifiers, IRC and other chat nicknames).
    /// <see href="http://xmlns.com/foaf/0.1/nick"></see></summary>
    let nick = Namespaced_IRI.parse _namespace_name "nick" |> NamespacedName
    /// <summary>
    /// A location that something is based near, for some broadly human notion of near.
    /// <see href="http://xmlns.com/foaf/0.1/based_near"></see></summary>
    let based_near = Namespaced_IRI.parse _namespace_name "based_near" |> NamespacedName
    /// <summary>
    /// The birthday of this Agent, represented in mm-dd string form, eg. '12-31'.
    /// <see href="http://xmlns.com/foaf/0.1/birthday"></see></summary>
    let birthday = Namespaced_IRI.parse _namespace_name "birthday" |> NamespacedName

    /// <summary>
    /// A current project this person works on.
    /// <see href="http://xmlns.com/foaf/0.1/currentProject"></see></summary>
    let currentProject =
        Namespaced_IRI.parse _namespace_name "currentProject" |> NamespacedName

    /// <summary>
    /// A depiction of some thing.
    /// <see href="http://xmlns.com/foaf/0.1/depiction"></see></summary>
    let depiction = Namespaced_IRI.parse _namespace_name "depiction" |> NamespacedName
    /// <summary>
    /// A thing depicted in this representation.
    /// <see href="http://xmlns.com/foaf/0.1/depicts"></see></summary>
    let depicts = Namespaced_IRI.parse _namespace_name "depicts" |> NamespacedName

    /// <summary>
    /// A checksum for the DNA of some thing. Joke.
    /// <see href="http://xmlns.com/foaf/0.1/dnaChecksum"></see></summary>
    let dnaChecksum =
        Namespaced_IRI.parse _namespace_name "dnaChecksum" |> NamespacedName

    /// <summary>
    /// The family name of some person.
    /// <see href="http://xmlns.com/foaf/0.1/familyName"></see></summary>
    let familyName = Namespaced_IRI.parse _namespace_name "familyName" |> NamespacedName

    /// <summary>
    /// The family name of some person.
    /// <see href="http://xmlns.com/foaf/0.1/family_name"></see></summary>
    let family_name =
        Namespaced_IRI.parse _namespace_name "family_name" |> NamespacedName

    /// <summary>
    /// The first name of a person.
    /// <see href="http://xmlns.com/foaf/0.1/firstName"></see></summary>
    let firstName = Namespaced_IRI.parse _namespace_name "firstName" |> NamespacedName
    /// <summary>
    /// The underlying or 'focal' entity associated with some SKOS-described concept.
    /// <see href="http://xmlns.com/foaf/0.1/focus"></see></summary>
    let focus = Namespaced_IRI.parse _namespace_name "focus" |> NamespacedName
    /// <summary>
    /// An organization funding a project or person.
    /// <see href="http://xmlns.com/foaf/0.1/fundedBy"></see></summary>
    let fundedBy = Namespaced_IRI.parse _namespace_name "fundedBy" |> NamespacedName
    /// <summary>
    /// A textual geekcode for this person, see http://www.geekcode.com/geek.html
    /// <see href="http://xmlns.com/foaf/0.1/geekcode"></see></summary>
    let geekcode = Namespaced_IRI.parse _namespace_name "geekcode" |> NamespacedName
    /// <summary>
    /// The gender of this Agent (typically but not necessarily 'male' or 'female').
    /// <see href="http://xmlns.com/foaf/0.1/gender"></see></summary>
    let gender = Namespaced_IRI.parse _namespace_name "gender" |> NamespacedName
    /// <summary>
    /// The given name of some person.
    /// <see href="http://xmlns.com/foaf/0.1/givenName"></see></summary>
    let givenName = Namespaced_IRI.parse _namespace_name "givenName" |> NamespacedName
    /// <summary>
    /// The given name of some person.
    /// <see href="http://xmlns.com/foaf/0.1/givenname"></see></summary>
    let givenname = Namespaced_IRI.parse _namespace_name "givenname" |> NamespacedName

    /// <summary>
    /// Indicates an account held by this agent.
    /// <see href="http://xmlns.com/foaf/0.1/holdsAccount"></see></summary>
    let holdsAccount =
        Namespaced_IRI.parse _namespace_name "holdsAccount" |> NamespacedName

    /// <summary>
    /// A homepage for some thing.
    /// <see href="http://xmlns.com/foaf/0.1/homepage"></see></summary>
    let homepage = Namespaced_IRI.parse _namespace_name "homepage" |> NamespacedName
    /// <summary>
    /// A page or document about this thing.
    /// <see href="http://xmlns.com/foaf/0.1/page"></see></summary>
    let page = Namespaced_IRI.parse _namespace_name "page" |> NamespacedName

    /// <summary>
    /// A document that this thing is the primary topic of.
    /// <see href="http://xmlns.com/foaf/0.1/isPrimaryTopicOf"></see></summary>
    let isPrimaryTopicOf =
        Namespaced_IRI.parse _namespace_name "isPrimaryTopicOf" |> NamespacedName

    /// <summary>
    /// An ICQ chat ID
    /// <see href="http://xmlns.com/foaf/0.1/icqChatID"></see></summary>
    let icqChatID = Namespaced_IRI.parse _namespace_name "icqChatID" |> NamespacedName
    /// <summary>
    /// An image that can be used to represent some thing (ie. those depictions which are particularly representative of something, eg. one's photo on a homepage).
    /// <see href="http://xmlns.com/foaf/0.1/img"></see></summary>
    let img = Namespaced_IRI.parse _namespace_name "img" |> NamespacedName
    /// <summary>
    /// A page about a topic of interest to this person.
    /// <see href="http://xmlns.com/foaf/0.1/interest"></see></summary>
    let interest = Namespaced_IRI.parse _namespace_name "interest" |> NamespacedName

    /// <summary>
    /// The primary topic of some page or document.
    /// <see href="http://xmlns.com/foaf/0.1/primaryTopic"></see></summary>
    let primaryTopic =
        Namespaced_IRI.parse _namespace_name "primaryTopic" |> NamespacedName

    /// <summary>
    /// A jabber ID for something.
    /// <see href="http://xmlns.com/foaf/0.1/jabberID"></see></summary>
    let jabberID = Namespaced_IRI.parse _namespace_name "jabberID" |> NamespacedName
    /// <summary>
    /// A person known by this person (indicating some level of reciprocated interaction between the parties).
    /// <see href="http://xmlns.com/foaf/0.1/knows"></see></summary>
    let knows = Namespaced_IRI.parse _namespace_name "knows" |> NamespacedName
    /// <summary>
    /// The last name of a person.
    /// <see href="http://xmlns.com/foaf/0.1/lastName"></see></summary>
    let lastName = Namespaced_IRI.parse _namespace_name "lastName" |> NamespacedName
    /// <summary>
    /// A logo representing some thing.
    /// <see href="http://xmlns.com/foaf/0.1/logo"></see></summary>
    let logo = Namespaced_IRI.parse _namespace_name "logo" |> NamespacedName
    /// <summary>
    /// Something that was made by this agent.
    /// <see href="http://xmlns.com/foaf/0.1/made"></see></summary>
    let made = Namespaced_IRI.parse _namespace_name "made" |> NamespacedName
    /// <summary>
    /// An agent that  made this thing.
    /// <see href="http://xmlns.com/foaf/0.1/maker"></see></summary>
    let maker = Namespaced_IRI.parse _namespace_name "maker" |> NamespacedName
    /// <summary>
    /// A  personal mailbox, ie. an Internet mailbox associated with exactly one owner, the first owner of this mailbox. This is a 'static inverse functional property', in that  there is (across time and change) at most one individual that ever has any particular value for foaf:mbox.
    /// <see href="http://xmlns.com/foaf/0.1/mbox"></see></summary>
    let mbox = Namespaced_IRI.parse _namespace_name "mbox" |> NamespacedName

    /// <summary>
    /// The sha1sum of the URI of an Internet mailbox associated with exactly one owner, the  first owner of the mailbox.
    /// <see href="http://xmlns.com/foaf/0.1/mbox_sha1sum"></see></summary>
    let mbox_sha1sum =
        Namespaced_IRI.parse _namespace_name "mbox_sha1sum" |> NamespacedName

    /// <summary>
    /// Indicates a member of a Group
    /// <see href="http://xmlns.com/foaf/0.1/member"></see></summary>
    let member_ = Namespaced_IRI.parse _namespace_name "member" |> NamespacedName

    /// <summary>
    /// Indicates the class of individuals that are a member of a Group
    /// <see href="http://xmlns.com/foaf/0.1/membershipClass"></see></summary>
    let membershipClass =
        Namespaced_IRI.parse _namespace_name "membershipClass" |> NamespacedName

    /// <summary>
    /// An MSN chat ID
    /// <see href="http://xmlns.com/foaf/0.1/msnChatID"></see></summary>
    let msnChatID = Namespaced_IRI.parse _namespace_name "msnChatID" |> NamespacedName

    /// <summary>
    /// A Myers Briggs (MBTI) personality classification.
    /// <see href="http://xmlns.com/foaf/0.1/myersBriggs"></see></summary>
    let myersBriggs =
        Namespaced_IRI.parse _namespace_name "myersBriggs" |> NamespacedName

    /// <summary>
    /// A name for some thing.
    /// <see href="http://xmlns.com/foaf/0.1/name"></see></summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName
    /// <summary>
    /// An OpenID for an Agent.
    /// <see href="http://xmlns.com/foaf/0.1/openid"></see></summary>
    let openid = Namespaced_IRI.parse _namespace_name "openid" |> NamespacedName
    /// <summary>
    /// A topic of some page or document.
    /// <see href="http://xmlns.com/foaf/0.1/topic"></see></summary>
    let topic = Namespaced_IRI.parse _namespace_name "topic" |> NamespacedName

    /// <summary>
    /// A project this person has previously worked on.
    /// <see href="http://xmlns.com/foaf/0.1/pastProject"></see></summary>
    let pastProject =
        Namespaced_IRI.parse _namespace_name "pastProject" |> NamespacedName

    /// <summary>
    /// A phone,  specified using fully qualified tel: URI scheme (refs: http://www.w3.org/Addressing/schemes.html#tel).
    /// <see href="http://xmlns.com/foaf/0.1/phone"></see></summary>
    let phone = Namespaced_IRI.parse _namespace_name "phone" |> NamespacedName
    /// <summary>
    /// A .plan comment, in the tradition of finger and '.plan' files.
    /// <see href="http://xmlns.com/foaf/0.1/plan"></see></summary>
    let plan = Namespaced_IRI.parse _namespace_name "plan" |> NamespacedName

    /// <summary>
    /// A link to the publications of this person.
    /// <see href="http://xmlns.com/foaf/0.1/publications"></see></summary>
    let publications =
        Namespaced_IRI.parse _namespace_name "publications" |> NamespacedName

    /// <summary>
    /// A homepage of a school attended by the person.
    /// <see href="http://xmlns.com/foaf/0.1/schoolHomepage"></see></summary>
    let schoolHomepage =
        Namespaced_IRI.parse _namespace_name "schoolHomepage" |> NamespacedName

    /// <summary>
    /// A sha1sum hash, in hex.
    /// <see href="http://xmlns.com/foaf/0.1/sha1"></see></summary>
    let sha1 = Namespaced_IRI.parse _namespace_name "sha1" |> NamespacedName
    /// <summary>
    /// A Skype ID
    /// <see href="http://xmlns.com/foaf/0.1/skypeID"></see></summary>
    let skypeID = Namespaced_IRI.parse _namespace_name "skypeID" |> NamespacedName
    /// <summary>
    /// A string expressing what the user is happy for the general public (normally) to know about their current activity.
    /// <see href="http://xmlns.com/foaf/0.1/status"></see></summary>
    let status = Namespaced_IRI.parse _namespace_name "status" |> NamespacedName
    /// <summary>
    /// The surname of some person.
    /// <see href="http://xmlns.com/foaf/0.1/surname"></see></summary>
    let surname = Namespaced_IRI.parse _namespace_name "surname" |> NamespacedName
    /// <summary>
    /// A theme.
    /// <see href="http://xmlns.com/foaf/0.1/theme"></see></summary>
    let theme = Namespaced_IRI.parse _namespace_name "theme" |> NamespacedName
    /// <summary>
    /// A derived thumbnail image.
    /// <see href="http://xmlns.com/foaf/0.1/thumbnail"></see></summary>
    let thumbnail = Namespaced_IRI.parse _namespace_name "thumbnail" |> NamespacedName
    /// <summary>
    /// A tipjar document for this agent, describing means for payment and reward.
    /// <see href="http://xmlns.com/foaf/0.1/tipjar"></see></summary>
    let tipjar = Namespaced_IRI.parse _namespace_name "tipjar" |> NamespacedName
    /// <summary>
    /// Title (Mr, Mrs, Ms, Dr. etc)
    /// <see href="http://xmlns.com/foaf/0.1/title"></see></summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName

    /// <summary>
    /// A thing of interest to this person.
    /// <see href="http://xmlns.com/foaf/0.1/topic_interest"></see></summary>
    let topic_interest =
        Namespaced_IRI.parse _namespace_name "topic_interest" |> NamespacedName

    /// <summary>
    /// A weblog of some thing (whether person, group, company etc.).
    /// <see href="http://xmlns.com/foaf/0.1/weblog"></see></summary>
    let weblog = Namespaced_IRI.parse _namespace_name "weblog" |> NamespacedName

    /// <summary>
    /// A work info homepage of some person; a page about their work for some organization.
    /// <see href="http://xmlns.com/foaf/0.1/workInfoHomepage"></see></summary>
    let workInfoHomepage =
        Namespaced_IRI.parse _namespace_name "workInfoHomepage" |> NamespacedName

    /// <summary>
    /// A workplace homepage of some person; the homepage of an organization they work for.
    /// <see href="http://xmlns.com/foaf/0.1/workplaceHomepage"></see></summary>
    let workplaceHomepage =
        Namespaced_IRI.parse _namespace_name "workplaceHomepage" |> NamespacedName

    /// <summary>
    /// A Yahoo chat ID
    /// <see href="http://xmlns.com/foaf/0.1/yahooChatID"></see></summary>
    let yahooChatID =
        Namespaced_IRI.parse _namespace_name "yahooChatID" |> NamespacedName

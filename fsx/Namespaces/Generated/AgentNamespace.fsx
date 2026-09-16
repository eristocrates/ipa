#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module agent =
    let _prefixId = PrefixId.fromNamespaceLabel "http://eulersharp.sourceforge.net/2003/03swap/agent#" "agent"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : ability</para>
    ///   <para>skos:definition : Being able to do something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#Ability">agent:Ability</a>
    /// </summary>
    let Ability = _prefixId.prefix "Ability"
    /// <summary>
    ///   <para>rdfs:label : ancestry</para>
    ///   <para>skos:definition : An ascendant group of any kind of something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#Ancestry">agent:Ancestry</a>
    /// </summary>
    let Ancestry = _prefixId.prefix "Ancestry"
    /// <summary>
    ///   <para>rdfs:label : ascendant</para>
    ///   <para>skos:definition : An earlier form in appearance, function, or general character of something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#Ascendant">agent:Ascendant</a>
    /// </summary>
    let Ascendant = _prefixId.prefix "Ascendant"
    /// <summary>
    ///   <para>rdfs:label : authenticator</para>
    ///   <para>skos:definition : Role of an agent authenticating something.^^xsd:string</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#Authenticator">agent:Authenticator</a>
    /// </summary>
    let Authenticator = _prefixId.prefix "Authenticator"
    /// <summary>
    ///   <para>rdfs:label : child</para>
    ///   <para>skos:definition : A first grade descendant of something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#Child">agent:Child</a>
    /// </summary>
    let Child = _prefixId.prefix "Child"
    /// <summary>
    ///   <para>rdfs:label : community</para>
    ///   <para>skos:definition : Group of agents of which the members have something in common.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#Community">agent:Community</a>
    /// </summary>
    let Community = _prefixId.prefix "Community"
    /// <summary>
    ///   <para>rdfs:label : completor</para>
    ///   <para>skos:definition : Role of an agent completing something.^^xsd:string</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#Completor">agent:Completor</a>
    /// </summary>
    let Completor = _prefixId.prefix "Completor"
    /// <summary>
    ///   <para>rdfs:label : creator</para>
    ///   <para>skos:definition : Role of an agent creating something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#Creator">agent:Creator</a>
    /// </summary>
    let Creator = _prefixId.prefix "Creator"
    /// <summary>
    ///   <para>rdfs:label : deprecator</para>
    ///   <para>skos:definition : Role of agent marking a digital document as obsolete to warn against its use so that it may be phased out (www.thefreedictionary.com).</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#Deprecator">agent:Deprecator</a>
    /// </summary>
    let Deprecator = _prefixId.prefix "Deprecator"
    /// <summary>
    ///   <para>rdfs:label : descendant</para>
    ///   <para>skos:definition : Something deriving in appearance, function, or general character from an earlier form.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#Descendant">agent:Descendant</a>
    /// </summary>
    let Descendant = _prefixId.prefix "Descendant"
    /// <summary>
    ///   <para>rdfs:label : donor</para>
    ///   <para>skos:definition : Role of an agent giving something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#Donor">agent:Donor</a>
    /// </summary>
    let Donor = _prefixId.prefix "Donor"
    /// <summary>
    ///   <para>rdfs:label : drug substance</para>
    ///   <para>skos:definition : Substance, when absorbed into an organism, alters its functioning.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#DrugSubstance">agent:DrugSubstance</a>
    /// </summary>
    let DrugSubstance = _prefixId.prefix "DrugSubstance"
    /// <summary>
    ///   <para>rdfs:label : evaluator</para>
    ///   <para>skos:definition : Role of an agent evaluating something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#Evaluator">agent:Evaluator</a>
    /// </summary>
    let Evaluator = _prefixId.prefix "Evaluator"
    /// <summary>
    ///   <para>rdfs:label : examinator</para>
    ///   <para>skos:definition : Role of an agent examining something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#Examinator">agent:Examinator</a>
    /// </summary>
    let Examinator = _prefixId.prefix "Examinator"
    /// <summary>
    ///   <para>rdfs:label : group of agents</para>
    ///   <para>skos:definition : Group of agents.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#Group">agent:Group</a>
    /// </summary>
    let Group = _prefixId.prefix "Group"
    /// <summary>
    ///   <para>rdfs:label : group role</para>
    ///   <para>skos:definition : Specific function of a group.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#GroupRole">agent:GroupRole</a>
    /// </summary>
    let GroupRole = _prefixId.prefix "GroupRole"
    /// <summary>
    ///   <para>rdfs:label : legal authenticator</para>
    ///   <para>skos:definition : Role of an agent legally authenticating something.^^xsd:string</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#LegalAuthenticator">agent:LegalAuthenticator</a>
    /// </summary>
    let LegalAuthenticator = _prefixId.prefix "LegalAuthenticator"
    /// <summary>
    ///   <para>rdfs:label : machine</para>
    ///   <para>skos:definition : A device using energy to perform an action.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#Machine">agent:Machine</a>
    /// </summary>
    let Machine = _prefixId.prefix "Machine"
    /// <summary>
    ///   <para>rdfs:label : machine role</para>
    ///   <para>skos:definition : Specific function of a machine.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#MachineRole">agent:MachineRole</a>
    /// </summary>
    let MachineRole = _prefixId.prefix "MachineRole"
    /// <summary>
    ///   <para>rdfs:label : marital status</para>
    ///   <para>skos:definition : the social and/or juridical status of being married or unmarried. </para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#MaritalStatus">agent:MaritalStatus</a>
    /// </summary>
    let MaritalStatus = _prefixId.prefix "MaritalStatus"
    /// <summary>
    ///   <para>rdfs:label : messenger</para>
    ///   <para>skos:definition : Role of an agent sending a message.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#Messenger">agent:Messenger</a>
    /// </summary>
    let Messenger = _prefixId.prefix "Messenger"
    /// <summary>
    ///   <para>rdfs:label : modifier</para>
    ///   <para>skos:definition : Role of an agent changing something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#Modifier">agent:Modifier</a>
    /// </summary>
    let Modifier = _prefixId.prefix "Modifier"
    /// <summary>
    ///   <para>rdfs:label : monitor</para>
    ///   <para>skos:definition : Role of an agent observing something to detect something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#Monitor">agent:Monitor</a>
    /// </summary>
    let Monitor = _prefixId.prefix "Monitor"
    /// <summary>
    ///   <para>rdfs:label : offspring</para>
    ///   <para>skos:definition : A descendant group of any kind of something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#Offspring">agent:Offspring</a>
    /// </summary>
    let Offspring = _prefixId.prefix "Offspring"
    /// <summary>
    ///   <para>rdfs:label : organization role</para>
    ///   <para>skos:definition : Specific function of an organization.</para>
    ///   <para>skos:note : An organization can be a legal person.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#OrganizationRole">agent:OrganizationRole</a>
    /// </summary>
    let OrganizationRole = _prefixId.prefix "OrganizationRole"
    /// <summary>
    ///   <para>rdfs:label : parent</para>
    ///   <para>skos:definition : A first grade ascendant of something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#Parent">agent:Parent</a>
    /// </summary>
    let Parent = _prefixId.prefix "Parent"
    /// <summary>
    ///   <para>rdfs:label : purposive agent</para>
    ///   <para>skos:definition : Agent having preference of some state of the environment and acting to try to achieve most preferred state.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#PurposiveAgent">agent:PurposiveAgent</a>
    /// </summary>
    let PurposiveAgent = _prefixId.prefix "PurposiveAgent"
    /// <summary>
    ///   <para>rdfs:label : recipient</para>
    ///   <para>skos:definition : Role of an agent receiving something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#Recipient">agent:Recipient</a>
    /// </summary>
    let Recipient = _prefixId.prefix "Recipient"
    /// <summary>
    ///   <para>rdfs:label : role</para>
    ///   <para>skos:definition : Specific function of an agent.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#Role">agent:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>rdfs:label : sender</para>
    ///   <para>skos:definition : Role of agent sending something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#Sender">agent:Sender</a>
    /// </summary>
    let Sender = _prefixId.prefix "Sender"
    /// <summary>
    ///   <para>rdfs:label : sponsor</para>
    ///   <para>skos:definition : Role of an agent sponsoring something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#Sponsor">agent:Sponsor</a>
    /// </summary>
    let Sponsor = _prefixId.prefix "Sponsor"
    /// <summary>
    ///   <para>rdfs:label : submittor</para>
    ///   <para>skos:definition : Role of an agent submitting something.^^xsd:string</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#Submittor">agent:Submittor</a>
    /// </summary>
    let Submittor = _prefixId.prefix "Submittor"
    /// <summary>
    ///   <para>rdfs:label : user</para>
    ///   <para>skos:definition : Role of putting something into service or applying for a purpose.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#User">agent:User</a>
    /// </summary>
    let User = _prefixId.prefix "User"
    /// <summary>
    ///   <para>rdfs:label : user credential</para>
    ///   <para>skos:definition : Convincible information as input to get user access, e.g. to a digital multiuser computer system.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#UserCredential">agent:UserCredential</a>
    /// </summary>
    let UserCredential = _prefixId.prefix "UserCredential"
    /// <summary>
    ///   <para>rdfs:label : validator</para>
    ///   <para>skos:definition : Role of an agent validating something.^^xsd:string</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#Validator">agent:Validator</a>
    /// </summary>
    let Validator = _prefixId.prefix "Validator"
    /// <summary>
    ///   <para>rdfs:label : weighing device</para>
    ///   <para>skos:definition : Device to measure the weight of a physical resource.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#WeighingDevice">agent:WeighingDevice</a>
    /// </summary>
    let WeighingDevice = _prefixId.prefix "WeighingDevice"
    /// <summary>
    ///   <para>skos:definition : Specifying an agent having an ability.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#abilityOf">agent:abilityOf</a>
    /// </summary>
    let abilityOf = _prefixId.prefix "abilityOf"
    /// <summary>
    ///   <para>skos:definition : Specifying an agent acting after another agent in a same action.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#actsAfter">agent:actsAfter</a>
    /// </summary>
    let actsAfter = _prefixId.prefix "actsAfter"
    /// <summary>
    ///   <para>skos:definition : Specifying an agent acting before another agent in a same action.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#actsBefore">agent:actsBefore</a>
    /// </summary>
    let actsBefore = _prefixId.prefix "actsBefore"
    /// <summary>
    ///   <para>skos:definition : Specifying an action an agent is involved in.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#actsIn">agent:actsIn</a>
    /// </summary>
    let actsIn = _prefixId.prefix "actsIn"
    /// <summary>
    ///   <para>skos:definition : Specifying credentials an agent uses to authenticate.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#authenticatesWith">agent:authenticatesWith</a>
    /// </summary>
    let authenticatesWith = _prefixId.prefix "authenticatesWith"
    /// <summary>
    ///   <para>skos:definition : Specifying an ability of an agent.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasAbility">agent:hasAbility</a>
    /// </summary>
    let hasAbility = _prefixId.prefix "hasAbility"
    /// <summary>
    ///   <para>skos:definition : Specifying an agent involved in an action.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasAgent">agent:hasAgent</a>
    /// </summary>
    let hasAgent = _prefixId.prefix "hasAgent"
    /// <summary>
    ///   <para>skos:definition : Specifying a ascendant group of a descendant.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasAncestry">agent:hasAncestry</a>
    /// </summary>
    let hasAncestry = _prefixId.prefix "hasAncestry"
    /// <summary>
    ///   <para>skos:definition : Specifying any ascendant of a descendant.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasAscendant">agent:hasAscendant</a>
    /// </summary>
    let hasAscendant = _prefixId.prefix "hasAscendant"
    /// <summary>
    ///   <para>skos:definition : Specifying a first grade descendant of something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasChild">agent:hasChild</a>
    /// </summary>
    let hasChild = _prefixId.prefix "hasChild"
    /// <summary>
    ///   <para>skos:definition : Specifying any descendant of an ascendant.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasDescendant">agent:hasDescendant</a>
    /// </summary>
    let hasDescendant = _prefixId.prefix "hasDescendant"
    /// <summary>
    ///   <para>skos:definition : Specifying a donor in a transfer of something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasDonor">agent:hasDonor</a>
    /// </summary>
    let hasDonor = _prefixId.prefix "hasDonor"
    /// <summary>
    ///   <para>rdfs:label : has marital status</para>
    ///   <para>skos:definition : Speciafying an agent having the social and/or juridical status of being married or unmarried. </para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasMaritalStatus">agent:hasMaritalStatus</a>
    /// </summary>
    let hasMaritalStatus = _prefixId.prefix "hasMaritalStatus"
    /// <summary>
    ///   <para>skos:definition : Specifying a descendant group of an ascendant.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasOffspring">agent:hasOffspring</a>
    /// </summary>
    let hasOffspring = _prefixId.prefix "hasOffspring"
    /// <summary>
    ///   <para>skos:definition : Specifying a first grade ascendant of something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasParent">agent:hasParent</a>
    /// </summary>
    let hasParent = _prefixId.prefix "hasParent"
    /// <summary>
    ///   <para>skos:definition : Specifying a password of a user to access e.g. a multiuser computer system.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasPassword">agent:hasPassword</a>
    /// </summary>
    let hasPassword = _prefixId.prefix "hasPassword"
    /// <summary>
    ///   <para>skos:definition : Specifying a role played in an action.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasPlayedRole">agent:hasPlayedRole</a>
    /// </summary>
    let hasPlayedRole = _prefixId.prefix "hasPlayedRole"
    /// <summary>
    ///   <para>skos:definition : Specifying a recipient in a transfer of something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasRecipient">agent:hasRecipient</a>
    /// </summary>
    let hasRecipient = _prefixId.prefix "hasRecipient"
    /// <summary>
    ///   <para>skos:definition : Specifying a place wherein an agent with a certain role resides and can be contacted.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasResidence">agent:hasResidence</a>
    /// </summary>
    let hasResidence = _prefixId.prefix "hasResidence"
    /// <summary>
    ///   <para>rdfs:label : has a spouse</para>
    ///   <para>skos:definition : Specifying an agent having a partner (gender neutral) in a marriage, civil union, domestic partnership or common-law marriage.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasSpouse">agent:hasSpouse</a>
    /// </summary>
    let hasSpouse = _prefixId.prefix "hasSpouse"
    /// <summary>
    ///   <para>skos:definition : Specifying credentials of a user to access e.g. a multiuser computer system.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasUserCredential">agent:hasUserCredential</a>
    /// </summary>
    let hasUserCredential = _prefixId.prefix "hasUserCredential"
    let hasUsername = _prefixId.prefix "hasUsername"
    /// <summary>
    ///   <para>skos:definition : Specifying an agent interacting with another agent in a sense that it changes the outcome of the action compared to one with the other agent alone.</para>
    ///   <para>skos:note : Not limited to direct interaction between 2 agents.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#interactsWith">agent:interactsWith</a>
    /// </summary>
    let interactsWith = _prefixId.prefix "interactsWith"
    /// <summary>
    ///   <para>skos:definition : Specifying something for which user credentials are needed to authenticate.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#isAuthenticationObjectFor">agent:isAuthenticationObjectFor</a>
    /// </summary>
    let isAuthenticationObjectFor = _prefixId.prefix "isAuthenticationObjectFor"
    /// <summary>
    ///   <para>skos:definition : Specifying a group an agent is a member of.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#memberOf">agent:memberOf</a>
    /// </summary>
    let memberOf = _prefixId.prefix "memberOf"
    /// <summary>
    ///   <para>skos:definition : Specifying a role an agent plays.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#playsRole">agent:playsRole</a>
    /// </summary>
    let playsRole = _prefixId.prefix "playsRole"
    /// <summary>
    ///   <para>skos:definition : Specifying a transfer for a recipient of something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#recipientIn">agent:recipientIn</a>
    /// </summary>
    let recipientIn = _prefixId.prefix "recipientIn"
    /// <summary>
    ///   <para>skos:definition : Specifying an agent playing a role.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#rolePlayedBy">agent:rolePlayedBy</a>
    /// </summary>
    let rolePlayedBy = _prefixId.prefix "rolePlayedBy"
    /// <summary>
    ///   <para>skos:definition : Specifying an action a role is played in.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#rolePlayedIn">agent:rolePlayedIn</a>
    /// </summary>
    let rolePlayedIn = _prefixId.prefix "rolePlayedIn"
    /// <summary>
    ///   <para>skos:definition : Specifying something weighed by a device.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/agent#weighs">agent:weighs</a>
    /// </summary>
    let weighs = _prefixId.prefix "weighs"

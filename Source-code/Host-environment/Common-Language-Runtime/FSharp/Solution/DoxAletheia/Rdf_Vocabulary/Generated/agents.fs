namespace http.eulersharp.sourceforge.net._2003._03swap.agent.hash

open DoxAletheia

module agents =
    let _namespace_name = "http://eulersharp.sourceforge.net/2003/03swap/agent#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#Ability"></see>
    /// </summary>
    let Ability = _prefix "Ability"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#Ancestry"></see>
    /// </summary>
    let Ancestry = _prefix "Ancestry"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#Group"></see>
    /// </summary>
    let Group = _prefix "Group"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#Ascendant"></see>
    /// </summary>
    let Ascendant = _prefix "Ascendant"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasDescendant"></see>
    /// </summary>
    let hasDescendant = _prefix "hasDescendant"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#Authenticator"></see>
    /// </summary>
    let Authenticator = _prefix "Authenticator"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#Role"></see>
    /// </summary>
    let Role = _prefix "Role"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#rolePlayedIn"></see>
    /// </summary>
    let rolePlayedIn = _prefix "rolePlayedIn"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#Child"></see>
    /// </summary>
    let Child = _prefix "Child"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#Descendant"></see>
    /// </summary>
    let Descendant = _prefix "Descendant"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasParent"></see>
    /// </summary>
    let hasParent = _prefix "hasParent"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#Community"></see>
    /// </summary>
    let Community = _prefix "Community"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#Completor"></see>
    /// </summary>
    let Completor = _prefix "Completor"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#Creator"></see>
    /// </summary>
    let Creator = _prefix "Creator"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#Deprecator"></see>
    /// </summary>
    let Deprecator = _prefix "Deprecator"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasAscendant"></see>
    /// </summary>
    let hasAscendant = _prefix "hasAscendant"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#Donor"></see>
    /// </summary>
    let Donor = _prefix "Donor"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#DrugSubstance"></see>
    /// </summary>
    let DrugSubstance = _prefix "DrugSubstance"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#Evaluator"></see>
    /// </summary>
    let Evaluator = _prefix "Evaluator"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#Examinator"></see>
    /// </summary>
    let Examinator = _prefix "Examinator"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#rolePlayedBy"></see>
    /// </summary>
    let rolePlayedBy = _prefix "rolePlayedBy"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#actsIn"></see>
    /// </summary>
    let actsIn = _prefix "actsIn"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#GroupRole"></see>
    /// </summary>
    let GroupRole = _prefix "GroupRole"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#LegalAuthenticator"></see>
    /// </summary>
    let LegalAuthenticator = _prefix "LegalAuthenticator"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#Machine"></see>
    /// </summary>
    let Machine = _prefix "Machine"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#MachineRole"></see>
    /// </summary>
    let MachineRole = _prefix "MachineRole"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#MaritalStatus"></see>
    /// </summary>
    let MaritalStatus = _prefix "MaritalStatus"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#Messenger"></see>
    /// </summary>
    let Messenger = _prefix "Messenger"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#Sender"></see>
    /// </summary>
    let Sender = _prefix "Sender"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#Modifier"></see>
    /// </summary>
    let Modifier = _prefix "Modifier"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#Monitor"></see>
    /// </summary>
    let Monitor = _prefix "Monitor"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#Offspring"></see>
    /// </summary>
    let Offspring = _prefix "Offspring"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#OrganizationRole"></see>
    /// </summary>
    let OrganizationRole = _prefix "OrganizationRole"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#Parent"></see>
    /// </summary>
    let Parent = _prefix "Parent"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasChild"></see>
    /// </summary>
    let hasChild = _prefix "hasChild"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#PurposiveAgent"></see>
    /// </summary>
    let PurposiveAgent = _prefix "PurposiveAgent"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#Recipient"></see>
    /// </summary>
    let Recipient = _prefix "Recipient"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#Sponsor"></see>
    /// </summary>
    let Sponsor = _prefix "Sponsor"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#Submittor"></see>
    /// </summary>
    let Submittor = _prefix "Submittor"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#User"></see>
    /// </summary>
    let User = _prefix "User"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#UserCredential"></see>
    /// </summary>
    let UserCredential = _prefix "UserCredential"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#Validator"></see>
    /// </summary>
    let Validator = _prefix "Validator"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#WeighingDevice"></see>
    /// </summary>
    let WeighingDevice = _prefix "WeighingDevice"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#abilityOf"></see>
    /// </summary>
    let abilityOf = _prefix "abilityOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasAbility"></see>
    /// </summary>
    let hasAbility = _prefix "hasAbility"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#actsAfter"></see>
    /// </summary>
    let actsAfter = _prefix "actsAfter"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasAgent"></see>
    /// </summary>
    let hasAgent = _prefix "hasAgent"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#actsBefore"></see>
    /// </summary>
    let actsBefore = _prefix "actsBefore"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#authenticatesWith"></see>
    /// </summary>
    let authenticatesWith = _prefix "authenticatesWith"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#playsRole"></see>
    /// </summary>
    let playsRole = _prefix "playsRole"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasAncestry"></see>
    /// </summary>
    let hasAncestry = _prefix "hasAncestry"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasDonor"></see>
    /// </summary>
    let hasDonor = _prefix "hasDonor"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasMaritalStatus"></see>
    /// </summary>
    let hasMaritalStatus = _prefix "hasMaritalStatus"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasOffspring"></see>
    /// </summary>
    let hasOffspring = _prefix "hasOffspring"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasPassword"></see>
    /// </summary>
    let hasPassword = _prefix "hasPassword"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasPlayedRole"></see>
    /// </summary>
    let hasPlayedRole = _prefix "hasPlayedRole"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasRecipient"></see>
    /// </summary>
    let hasRecipient = _prefix "hasRecipient"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasResidence"></see>
    /// </summary>
    let hasResidence = _prefix "hasResidence"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasSpouse"></see>
    /// </summary>
    let hasSpouse = _prefix "hasSpouse"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasUserCredential"></see>
    /// </summary>
    let hasUserCredential = _prefix "hasUserCredential"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasUsername"></see>
    /// </summary>
    let hasUsername = _prefix "hasUsername"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#interactsWith"></see>
    /// </summary>
    let interactsWith = _prefix "interactsWith"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#isAuthenticationObjectFor"></see>
    /// </summary>
    let isAuthenticationObjectFor = _prefix "isAuthenticationObjectFor"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#memberOf"></see>
    /// </summary>
    let memberOf = _prefix "memberOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#recipientIn"></see>
    /// </summary>
    let recipientIn = _prefix "recipientIn"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/agent#weighs"></see>
    /// </summary>
    let weighs = _prefix "weighs"

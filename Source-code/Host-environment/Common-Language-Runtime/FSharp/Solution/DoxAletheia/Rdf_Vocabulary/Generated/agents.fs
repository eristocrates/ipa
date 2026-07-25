namespace http.eulersharp.sourceforge.net._2003._03swap.agent.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module agents =
    let _namespace_iri = Namespace_Iri agents |> NamespaceIRI
    /// <summary>
    ///   <para>agents:hasDescendant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasDescendant">http://eulersharp.sourceforge.net/2003/03swap/agent#hasDescendant</seealso>
    let hasDescendant = Prefixed_Name(agents, "hasDescendant") |> PrefixedName
    /// <summary>
    ///   <para>agents:Child</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>child</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#Child">http://eulersharp.sourceforge.net/2003/03swap/agent#Child</seealso>
    let Child = Prefixed_Name(agents, "Child") |> PrefixedName
    /// <summary>
    ///   <para>agents:Descendant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>descendant</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#Descendant">http://eulersharp.sourceforge.net/2003/03swap/agent#Descendant</seealso>
    let Descendant = Prefixed_Name(agents, "Descendant") |> PrefixedName
    /// <summary>
    ///   <para>agents:Community</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>community</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#Community">http://eulersharp.sourceforge.net/2003/03swap/agent#Community</seealso>
    let Community = Prefixed_Name(agents, "Community") |> PrefixedName
    /// <summary>
    ///   <para>agents:Creator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>creator</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#Creator">http://eulersharp.sourceforge.net/2003/03swap/agent#Creator</seealso>
    let Creator = Prefixed_Name(agents, "Creator") |> PrefixedName
    /// <summary>
    ///   <para>agents:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>role</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#Role">http://eulersharp.sourceforge.net/2003/03swap/agent#Role</seealso>
    let Role = Prefixed_Name(agents, "Role") |> PrefixedName
    /// <summary>
    ///   <para>agents:hasParent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasParent">http://eulersharp.sourceforge.net/2003/03swap/agent#hasParent</seealso>
    let hasParent = Prefixed_Name(agents, "hasParent") |> PrefixedName
    /// <summary>
    ///   <para>agents:Completor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>completor</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#Completor">http://eulersharp.sourceforge.net/2003/03swap/agent#Completor</seealso>
    let Completor = Prefixed_Name(agents, "Completor") |> PrefixedName
    /// <summary>
    ///   <para>agents:Deprecator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>deprecator</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#Deprecator">http://eulersharp.sourceforge.net/2003/03swap/agent#Deprecator</seealso>
    let Deprecator = Prefixed_Name(agents, "Deprecator") |> PrefixedName
    /// <summary>
    ///   <para>agents:Messenger</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>messenger</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#Messenger">http://eulersharp.sourceforge.net/2003/03swap/agent#Messenger</seealso>
    let Messenger = Prefixed_Name(agents, "Messenger") |> PrefixedName
    /// <summary>
    ///   <para>agents:Modifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>modifier</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#Modifier">http://eulersharp.sourceforge.net/2003/03swap/agent#Modifier</seealso>
    let Modifier = Prefixed_Name(agents, "Modifier") |> PrefixedName
    /// <summary>
    ///   <para>agents:Monitor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>monitor</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#Monitor">http://eulersharp.sourceforge.net/2003/03swap/agent#Monitor</seealso>
    let Monitor = Prefixed_Name(agents, "Monitor") |> PrefixedName
    /// <summary>
    ///   <para>agents:Offspring</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>offspring</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#Offspring">http://eulersharp.sourceforge.net/2003/03swap/agent#Offspring</seealso>
    let Offspring = Prefixed_Name(agents, "Offspring") |> PrefixedName
    /// <summary>
    ///   <para>agents:hasAscendant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasAscendant">http://eulersharp.sourceforge.net/2003/03swap/agent#hasAscendant</seealso>
    let hasAscendant = Prefixed_Name(agents, "hasAscendant") |> PrefixedName
    /// <summary>
    ///   <para>agents:Donor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>donor</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#Donor">http://eulersharp.sourceforge.net/2003/03swap/agent#Donor</seealso>
    let Donor = Prefixed_Name(agents, "Donor") |> PrefixedName
    /// <summary>
    ///   <para>agents:Parent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>parent</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#Parent">http://eulersharp.sourceforge.net/2003/03swap/agent#Parent</seealso>
    let Parent = Prefixed_Name(agents, "Parent") |> PrefixedName
    /// <summary>
    ///   <para>agents:DrugSubstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>drug substance</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#DrugSubstance">http://eulersharp.sourceforge.net/2003/03swap/agent#DrugSubstance</seealso>
    let DrugSubstance = Prefixed_Name(agents, "DrugSubstance") |> PrefixedName
    /// <summary>
    ///   <para>agents:Evaluator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>evaluator</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#Evaluator">http://eulersharp.sourceforge.net/2003/03swap/agent#Evaluator</seealso>
    let Evaluator = Prefixed_Name(agents, "Evaluator") |> PrefixedName
    /// <summary>
    ///   <para>agents:Examinator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>examinator</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#Examinator">http://eulersharp.sourceforge.net/2003/03swap/agent#Examinator</seealso>
    let Examinator = Prefixed_Name(agents, "Examinator") |> PrefixedName
    /// <summary>
    ///   <para>agents:actsIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#actsIn">http://eulersharp.sourceforge.net/2003/03swap/agent#actsIn</seealso>
    let actsIn = Prefixed_Name(agents, "actsIn") |> PrefixedName
    /// <summary>
    ///   <para>agents:rolePlayedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#rolePlayedBy">http://eulersharp.sourceforge.net/2003/03swap/agent#rolePlayedBy</seealso>
    let rolePlayedBy = Prefixed_Name(agents, "rolePlayedBy") |> PrefixedName
    /// <summary>
    ///   <para>agents:Machine</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>machine</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#Machine">http://eulersharp.sourceforge.net/2003/03swap/agent#Machine</seealso>
    let Machine = Prefixed_Name(agents, "Machine") |> PrefixedName
    /// <summary>
    ///   <para>agents:GroupRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>group role</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#GroupRole">http://eulersharp.sourceforge.net/2003/03swap/agent#GroupRole</seealso>
    let GroupRole = Prefixed_Name(agents, "GroupRole") |> PrefixedName
    /// <summary>
    ///   <para>agents:MachineRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>machine role</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#MachineRole">http://eulersharp.sourceforge.net/2003/03swap/agent#MachineRole</seealso>
    let MachineRole = Prefixed_Name(agents, "MachineRole") |> PrefixedName
    /// <summary>
    ///   <para>agents:hasPlayedRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasPlayedRole">http://eulersharp.sourceforge.net/2003/03swap/agent#hasPlayedRole</seealso>
    let hasPlayedRole = Prefixed_Name(agents, "hasPlayedRole") |> PrefixedName
    /// <summary>
    ///   <para>agents:LegalAuthenticator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>legal authenticator</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#LegalAuthenticator">http://eulersharp.sourceforge.net/2003/03swap/agent#LegalAuthenticator</seealso>
    let LegalAuthenticator = Prefixed_Name(agents, "LegalAuthenticator") |> PrefixedName
    /// <summary>
    ///   <para>agents:hasUsername</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasUsername">http://eulersharp.sourceforge.net/2003/03swap/agent#hasUsername</seealso>
    let hasUsername = Prefixed_Name(agents, "hasUsername") |> PrefixedName
    /// <summary>
    ///   <para>agents:recipientIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#recipientIn">http://eulersharp.sourceforge.net/2003/03swap/agent#recipientIn</seealso>
    let recipientIn = Prefixed_Name(agents, "recipientIn") |> PrefixedName
    /// <summary>
    ///   <para>agents:Sender</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>sender</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#Sender">http://eulersharp.sourceforge.net/2003/03swap/agent#Sender</seealso>
    let Sender = Prefixed_Name(agents, "Sender") |> PrefixedName
    /// <summary>
    ///   <para>agents:OrganizationRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>organization role</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#OrganizationRole">http://eulersharp.sourceforge.net/2003/03swap/agent#OrganizationRole</seealso>
    let OrganizationRole = Prefixed_Name(agents, "OrganizationRole") |> PrefixedName
    /// <summary>
    ///   <para>agents:hasChild</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasChild">http://eulersharp.sourceforge.net/2003/03swap/agent#hasChild</seealso>
    let hasChild = Prefixed_Name(agents, "hasChild") |> PrefixedName
    /// <summary>
    ///   <para>agents:Submittor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>submittor</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#Submittor">http://eulersharp.sourceforge.net/2003/03swap/agent#Submittor</seealso>
    let Submittor = Prefixed_Name(agents, "Submittor") |> PrefixedName
    /// <summary>
    ///   <para>agents:User</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>user</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#User">http://eulersharp.sourceforge.net/2003/03swap/agent#User</seealso>
    let User = Prefixed_Name(agents, "User") |> PrefixedName
    /// <summary>
    ///   <para>agents:Validator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>validator</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#Validator">http://eulersharp.sourceforge.net/2003/03swap/agent#Validator</seealso>
    let Validator = Prefixed_Name(agents, "Validator") |> PrefixedName
    /// <summary>
    ///   <para>agents:WeighingDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>weighing device</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#WeighingDevice">http://eulersharp.sourceforge.net/2003/03swap/agent#WeighingDevice</seealso>
    let WeighingDevice = Prefixed_Name(agents, "WeighingDevice") |> PrefixedName
    /// <summary>
    ///   <para>agents:hasAbility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasAbility">http://eulersharp.sourceforge.net/2003/03swap/agent#hasAbility</seealso>
    let hasAbility = Prefixed_Name(agents, "hasAbility") |> PrefixedName
    /// <summary>
    ///   <para>agents:actsBefore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#actsBefore">http://eulersharp.sourceforge.net/2003/03swap/agent#actsBefore</seealso>
    let actsBefore = Prefixed_Name(agents, "actsBefore") |> PrefixedName
    /// <summary>
    ///   <para>agents:authenticatesWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#authenticatesWith">http://eulersharp.sourceforge.net/2003/03swap/agent#authenticatesWith</seealso>
    let authenticatesWith = Prefixed_Name(agents, "authenticatesWith") |> PrefixedName
    /// <summary>
    ///   <para>agents:playsRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#playsRole">http://eulersharp.sourceforge.net/2003/03swap/agent#playsRole</seealso>
    let playsRole = Prefixed_Name(agents, "playsRole") |> PrefixedName
    /// <summary>
    ///   <para>agents:MaritalStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>marital status</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#MaritalStatus">http://eulersharp.sourceforge.net/2003/03swap/agent#MaritalStatus</seealso>
    let MaritalStatus = Prefixed_Name(agents, "MaritalStatus") |> PrefixedName
    /// <summary>
    ///   <para>agents:PurposiveAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>purposive agent</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#PurposiveAgent">http://eulersharp.sourceforge.net/2003/03swap/agent#PurposiveAgent</seealso>
    let PurposiveAgent = Prefixed_Name(agents, "PurposiveAgent") |> PrefixedName
    /// <summary>
    ///   <para>agents:Sponsor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>sponsor</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#Sponsor">http://eulersharp.sourceforge.net/2003/03swap/agent#Sponsor</seealso>
    let Sponsor = Prefixed_Name(agents, "Sponsor") |> PrefixedName
    /// <summary>
    ///   <para>agents:UserCredential</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>user credential</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#UserCredential">http://eulersharp.sourceforge.net/2003/03swap/agent#UserCredential</seealso>
    let UserCredential = Prefixed_Name(agents, "UserCredential") |> PrefixedName
    /// <summary>
    ///   <para>agents:abilityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#abilityOf">http://eulersharp.sourceforge.net/2003/03swap/agent#abilityOf</seealso>
    let abilityOf = Prefixed_Name(agents, "abilityOf") |> PrefixedName
    /// <summary>
    ///   <para>agents:actsAfter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#actsAfter">http://eulersharp.sourceforge.net/2003/03swap/agent#actsAfter</seealso>
    let actsAfter = Prefixed_Name(agents, "actsAfter") |> PrefixedName
    /// <summary>
    ///   <para>agents:Recipient</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>recipient</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#Recipient">http://eulersharp.sourceforge.net/2003/03swap/agent#Recipient</seealso>
    let Recipient = Prefixed_Name(agents, "Recipient") |> PrefixedName
    /// <summary>
    ///   <para>agents:hasAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasAgent">http://eulersharp.sourceforge.net/2003/03swap/agent#hasAgent</seealso>
    let hasAgent = Prefixed_Name(agents, "hasAgent") |> PrefixedName
    /// <summary>
    ///   <para>agents:hasAncestry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasAncestry">http://eulersharp.sourceforge.net/2003/03swap/agent#hasAncestry</seealso>
    let hasAncestry = Prefixed_Name(agents, "hasAncestry") |> PrefixedName
    /// <summary>
    ///   <para>agents:hasMaritalStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has marital status</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasMaritalStatus">http://eulersharp.sourceforge.net/2003/03swap/agent#hasMaritalStatus</seealso>
    let hasMaritalStatus = Prefixed_Name(agents, "hasMaritalStatus") |> PrefixedName
    /// <summary>
    ///   <para>agents:hasDonor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasDonor">http://eulersharp.sourceforge.net/2003/03swap/agent#hasDonor</seealso>
    let hasDonor = Prefixed_Name(agents, "hasDonor") |> PrefixedName
    /// <summary>
    ///   <para>agents:Ability</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>ability</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#Ability">http://eulersharp.sourceforge.net/2003/03swap/agent#Ability</seealso>
    let Ability = Prefixed_Name(agents, "Ability") |> PrefixedName
    /// <summary>
    ///   <para>agents:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#">http://eulersharp.sourceforge.net/2003/03swap/agent#</seealso>
    let _prefix_iri = Prefixed_Name(agents, "") |> PrefixedName
    /// <summary>
    ///   <para>agents:Ancestry</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>ancestry</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#Ancestry">http://eulersharp.sourceforge.net/2003/03swap/agent#Ancestry</seealso>
    let Ancestry = Prefixed_Name(agents, "Ancestry") |> PrefixedName
    /// <summary>
    ///   <para>agents:Group</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>group of agents</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#Group">http://eulersharp.sourceforge.net/2003/03swap/agent#Group</seealso>
    let Group = Prefixed_Name(agents, "Group") |> PrefixedName
    /// <summary>
    ///   <para>agents:Ascendant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>ascendant</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#Ascendant">http://eulersharp.sourceforge.net/2003/03swap/agent#Ascendant</seealso>
    let Ascendant = Prefixed_Name(agents, "Ascendant") |> PrefixedName
    /// <summary>
    ///   <para>agents:Authenticator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>authenticator</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#Authenticator">http://eulersharp.sourceforge.net/2003/03swap/agent#Authenticator</seealso>
    let Authenticator = Prefixed_Name(agents, "Authenticator") |> PrefixedName
    /// <summary>
    ///   <para>agents:rolePlayedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#rolePlayedIn">http://eulersharp.sourceforge.net/2003/03swap/agent#rolePlayedIn</seealso>
    let rolePlayedIn = Prefixed_Name(agents, "rolePlayedIn") |> PrefixedName
    /// <summary>
    ///   <para>agents:hasOffspring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasOffspring">http://eulersharp.sourceforge.net/2003/03swap/agent#hasOffspring</seealso>
    let hasOffspring = Prefixed_Name(agents, "hasOffspring") |> PrefixedName
    /// <summary>
    ///   <para>agents:hasPassword</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasPassword">http://eulersharp.sourceforge.net/2003/03swap/agent#hasPassword</seealso>
    let hasPassword = Prefixed_Name(agents, "hasPassword") |> PrefixedName
    /// <summary>
    ///   <para>agents:hasRecipient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasRecipient">http://eulersharp.sourceforge.net/2003/03swap/agent#hasRecipient</seealso>
    let hasRecipient = Prefixed_Name(agents, "hasRecipient") |> PrefixedName
    /// <summary>
    ///   <para>agents:hasResidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasResidence">http://eulersharp.sourceforge.net/2003/03swap/agent#hasResidence</seealso>
    let hasResidence = Prefixed_Name(agents, "hasResidence") |> PrefixedName
    /// <summary>
    ///   <para>agents:hasSpouse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has a spouse</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasSpouse">http://eulersharp.sourceforge.net/2003/03swap/agent#hasSpouse</seealso>
    let hasSpouse = Prefixed_Name(agents, "hasSpouse") |> PrefixedName
    /// <summary>
    ///   <para>agents:hasUserCredential</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#hasUserCredential">http://eulersharp.sourceforge.net/2003/03swap/agent#hasUserCredential</seealso>
    let hasUserCredential = Prefixed_Name(agents, "hasUserCredential") |> PrefixedName
    /// <summary>
    ///   <para>agents:interactsWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#interactsWith">http://eulersharp.sourceforge.net/2003/03swap/agent#interactsWith</seealso>
    let interactsWith = Prefixed_Name(agents, "interactsWith") |> PrefixedName

    /// <summary>
    ///   <para>agents:isAuthenticationObjectFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#isAuthenticationObjectFor">http://eulersharp.sourceforge.net/2003/03swap/agent#isAuthenticationObjectFor</seealso>
    let isAuthenticationObjectFor =
        Prefixed_Name(agents, "isAuthenticationObjectFor") |> PrefixedName

    /// <summary>
    ///   <para>agents:memberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#memberOf">http://eulersharp.sourceforge.net/2003/03swap/agent#memberOf</seealso>
    let memberOf = Prefixed_Name(agents, "memberOf") |> PrefixedName
    /// <summary>
    ///   <para>agents:weighs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/agent#weighs">http://eulersharp.sourceforge.net/2003/03swap/agent#weighs</seealso>
    let weighs = Prefixed_Name(agents, "weighs") |> PrefixedName

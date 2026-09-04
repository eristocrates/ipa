#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module odrl =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/odrl/2/" "odrl"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Action</para>
    ///   <para>skos:note : Actions may be allowed by Permissions, disallowed by Prohibitions, or made mandatory by Duties.</para>
    ///   <para>skos:definition : An operation on an Asset.</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/Action">odrl:Action</a>
    /// </summary>
    let Action = _prefixId.prefix "Action"
    /// <summary>
    ///   <para>skos:definition : A Policy that grants the assignee a Rule over an Asset from an assigner.</para>
    ///   <para>rdfs:label : Agreement</para>
    ///   <para>skos:note : An Agreement Policy MUST contain at least one Permission or Prohibition rule, a Party with Assigner function, and a Party with Assignee function (in the same Permission or Prohibition). The Agreement Policy will grant the terms of the Policy from the Assigner to the Assignee.</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/Agreement">odrl:Agreement</a>
    /// </summary>
    let Agreement = _prefixId.prefix "Agreement"
    let All = _prefixId.prefix "All"
    let All2ndConnections = _prefixId.prefix "All2ndConnections"
    let AllConnections = _prefixId.prefix "AllConnections"
    let AllGroups = _prefixId.prefix "AllGroups"
    /// <summary>
    ///   <para>skos:definition : A Policy that asserts a Rule over an Asset from parties.</para>
    ///   <para>skos:scopeNote : Non-Normative</para>
    ///   <para>rdfs:label : Assertion</para>
    ///   <para>skos:note : For example, a party (an assignee or assigner) can claim what terms they have over an Asset. An Assertion Policy does not grant such permissions/prohibitions but only asserts the parties claims. An Assetion Policy  MUST contain a target Asset, a Party with any functional role, and at least one of a Permission or Prohibition rule.</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/Assertion">odrl:Assertion</a>
    /// </summary>
    let Assertion = _prefixId.prefix "Assertion"
    /// <summary>
    ///   <para>skos:note : The Asset entity can be any form of identifiable resource, such as data/information, content/media, applications, or services. Furthermore, it can be used to represent other Asset entities that are needed to undertake the Policy expression, such as with the Duty entity. To describe more details about the Asset, it is recommended to use Dublin Core [[dcterms]] elements or other content metadata.</para>
    ///   <para>skos:definition : A resource or a collection of resources that are the subject of a Rule.</para>
    ///   <para>rdfs:label : Asset</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/Asset">odrl:Asset</a>
    /// </summary>
    let Asset = _prefixId.prefix "Asset"
    /// <summary>
    ///   <para>skos:definition : An Asset that is collection of individual resources</para>
    ///   <para>rdfs:label : Asset Collection</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/AssetCollection">odrl:AssetCollection</a>
    /// </summary>
    let AssetCollection = _prefixId.prefix "AssetCollection"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>skos:note : Instances of the AssetScope class represent the terms for the scope property of Assets.</para>
    ///   <para>skos:definition : Scopes for Asset Scope expressions.</para>
    ///   <para>rdfs:label : Asset Scope</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/AssetScope">odrl:AssetScope</a>
    /// </summary>
    let AssetScope = _prefixId.prefix "AssetScope"
    /// <summary>
    ///   <para>rdfs:label : Conflict Strategy Preference</para>
    ///   <para>skos:note : Instances of ConflictTerm describe strategies for resolving conflicts.</para>
    ///   <para>skos:definition : Used to establish strategies to resolve conflicts that arise from the merging of Policies or conflicts between Permissions and Prohibitions in the same Policy.</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/ConflictTerm">odrl:ConflictTerm</a>
    /// </summary>
    let ConflictTerm = _prefixId.prefix "ConflictTerm"
    /// <summary>
    ///   <para>skos:definition : A boolean expression that refines the semantics of an Action and Party/Asset Collection or declare the conditions applicable to a Rule.</para>
    ///   <para>rdfs:label : Constraint</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/Constraint">odrl:Constraint</a>
    /// </summary>
    let Constraint = _prefixId.prefix "Constraint"
    /// <summary>
    ///   <para>skos:definition : The obligation to perform an Action</para>
    ///   <para>rdfs:label : Duty</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/Duty">odrl:Duty</a>
    /// </summary>
    let Duty = _prefixId.prefix "Duty"
    let Group = _prefixId.prefix "Group"
    let Individual = _prefixId.prefix "Individual"
    /// <summary>
    ///   <para>skos:note : Instances of the LeftOperand class are used as the leftOperand of a Constraint.</para>
    ///   <para>skos:definition : Left operand for a constraint expression.</para>
    ///   <para>rdfs:label : Left Operand</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/LeftOperand">odrl:LeftOperand</a>
    /// </summary>
    let LeftOperand = _prefixId.prefix "LeftOperand"
    /// <summary>
    ///   <para>skos:definition : A logical expression that refines the semantics of an Action and Party/Asset Collection or declare the conditions applicable to a Rule.</para>
    ///   <para>rdfs:label : Logical Constraint</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/LogicalConstraint">odrl:LogicalConstraint</a>
    /// </summary>
    let LogicalConstraint = _prefixId.prefix "LogicalConstraint"
    /// <summary>
    ///   <para>skos:definition : A Policy that proposes a Rule over an Asset from an assigner.</para>
    ///   <para>rdfs:label : Offer</para>
    ///   <para>skos:note : An Offer Policy MUST contain at least one Permission or Prohibition rule and a Party with Assigner function (in the same Permission or Prohibition). The Offer Policy MAY contain a Party with Assignee function, but MUST not grant any privileges to that Party.</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/Offer">odrl:Offer</a>
    /// </summary>
    let Offer = _prefixId.prefix "Offer"
    /// <summary>
    ///   <para>skos:note : Instances of the Operator class representing relational operators.</para>
    ///   <para>skos:definition : Operator for constraint expression.</para>
    ///   <para>rdfs:label : Operator</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/Operator">odrl:Operator</a>
    /// </summary>
    let Operator = _prefixId.prefix "Operator"
    /// <summary>
    ///   <para>skos:note : The Party entity could be a person, group of people, organisation, or agent. An agent is a person or thing that takes an active role or produces a specified effect. To describe more details about the Party, it is recommended to use W3C vCard Ontology [[vcard-rdf]] or FOAF Vocabulary [[foaf]].</para>
    ///   <para>skos:definition : An entity or a collection of entities that undertake Roles in a Rule.</para>
    ///   <para>rdfs:label : Party</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/Party">odrl:Party</a>
    /// </summary>
    let Party = _prefixId.prefix "Party"
    /// <summary>
    ///   <para>skos:definition : A Party that is a group of individual entities</para>
    ///   <para>rdfs:label : Party Collection</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/PartyCollection">odrl:PartyCollection</a>
    /// </summary>
    let PartyCollection = _prefixId.prefix "PartyCollection"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>skos:note : Instances of the PartyScope class represent the terms for the scope property of Parties.</para>
    ///   <para>skos:definition : Scopes for Party Scope expressions.</para>
    ///   <para>rdfs:label : Party Scope</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/PartyScope">odrl:PartyScope</a>
    /// </summary>
    let PartyScope = _prefixId.prefix "PartyScope"
    /// <summary>
    ///   <para>skos:definition : The ability to perform an Action over an Asset.</para>
    ///   <para>rdfs:label : Permission</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/Permission">odrl:Permission</a>
    /// </summary>
    let Permission = _prefixId.prefix "Permission"
    /// <summary>
    ///   <para>skos:note : A Policy may contain multiple Rules.</para>
    ///   <para>skos:definition : A non-empty group of Permissions and/or Prohibitions.</para>
    ///   <para>rdfs:label : Policy</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/Policy">odrl:Policy</a>
    /// </summary>
    let Policy = _prefixId.prefix "Policy"
    /// <summary>
    ///   <para>skos:note : A Privacy Policy  MUST contain a target Asset, a Party with Assigner  is, a Party with Assignee function, and at least one of a Permission or Prohibition rule that MUST include a Duty. The target Asset SHOULD contain or relate to personal information about the Assignee. The Duty MUST describe obligations on the Assigner about managing the Asset. The Assignee is being granted the terms of the Privacy policy from the Assigner.</para>
    ///   <para>skos:scopeNote : Non-Normative</para>
    ///   <para>skos:definition : A Policy that expresses a Rule over an Asset containing personal information.</para>
    ///   <para>rdfs:label : Privacy Policy</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/Privacy">odrl:Privacy</a>
    /// </summary>
    let Privacy = _prefixId.prefix "Privacy"
    /// <summary>
    ///   <para>skos:definition : The inability to perform an Action over an Asset.</para>
    ///   <para>rdfs:label : Prohibition</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/Prohibition">odrl:Prohibition</a>
    /// </summary>
    let Prohibition = _prefixId.prefix "Prohibition"
    /// <summary>
    ///   <para>rdfs:label : Request</para>
    ///   <para>skos:note : A Request Policy  MUST contain a target Asset, a Party with Assignee function, and at least one of a Permission or Prohibition rule. The Request MAY also contain the Party with Assigner function if this is known. No privileges are granted to any Party.</para>
    ///   <para>skos:definition : A Policy that proposes a Rule over an Asset from an assignee.</para>
    ///   <para>skos:scopeNote : Non-Normative</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/Request">odrl:Request</a>
    /// </summary>
    let Request = _prefixId.prefix "Request"
    /// <summary>
    ///   <para>skos:note : Instances of the RightOperand class are used as the rightOperand of a Constraint.</para>
    ///   <para>skos:definition : Right operand for constraint expression.</para>
    ///   <para>rdfs:label : Right Operand</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/RightOperand">odrl:RightOperand</a>
    /// </summary>
    let RightOperand = _prefixId.prefix "RightOperand"
    /// <summary>
    ///   <para>skos:note : Rule is an abstract concept.</para>
    ///   <para>skos:definition : An abstract concept that represents the common characteristics of Permissions, Prohibitions, and Duties.</para>
    ///   <para>rdfs:label : Rule</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/Rule">odrl:Rule</a>
    /// </summary>
    let Rule = _prefixId.prefix "Rule"
    /// <summary>
    ///   <para>rdfs:label : Set</para>
    ///   <para>skos:note : A Set Policy MUST contain a target Asset, and at least one Rule. A Set Policy is the default Policy subclass. The Set is aimed at scenarios where there is an open criteria for the semantics of the policy expressions and typically refined by other systems/profiles that process the information at a later time. No privileges are granted to any Party (if defined).</para>
    ///   <para>skos:definition : A Policy that expresses a Rule over an Asset.</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/Set">odrl:Set</a>
    /// </summary>
    let Set = _prefixId.prefix "Set"
    /// <summary>
    ///   <para>skos:note : A Ticket Policy MUST contain a target Asset and at least one of a Permission or Prohibition rule.  The Ticket MAY contain the Party with Assigner function and MUST NOT contain an Assignee. The Ticket Policy will grant the terms of the Policy to the holder of that Ticket. The holder of the Ticket MAY remain unknown or MAY have to be identified at some later stage.</para>
    ///   <para>rdfs:label : Ticket</para>
    ///   <para>skos:definition : A Policy that grants the holder a Rule over an Asset from an assigner.</para>
    ///   <para>skos:scopeNote : Non-Normative</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/Ticket">odrl:Ticket</a>
    /// </summary>
    let Ticket = _prefixId.prefix "Ticket"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Undefined Term</para>
    ///   <para>skos:note : Instances of UndefinedTerm describe strategies for processing unsupported actions.</para>
    ///   <para>skos:definition : Is used to indicate how to support Actions that are not part of any vocabulary or profile in the policy expression system.</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/UndefinedTerm">odrl:UndefinedTerm</a>
    /// </summary>
    let UndefinedTerm = _prefixId.prefix "UndefinedTerm"
    let absolutePosition = _prefixId.prefix "absolutePosition"
    let absoluteSize = _prefixId.prefix "absoluteSize"
    let absoluteSpatialPosition = _prefixId.prefix "absoluteSpatialPosition"
    let absoluteTemporalPosition = _prefixId.prefix "absoluteTemporalPosition"
    let acceptTracking = _prefixId.prefix "acceptTracking"
    /// <summary>
    ///   <para>skos:definition : The operation relating to the Asset for which the Rule is being subjected.</para>
    ///   <para>rdfs:label : Has Action</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/action">odrl:action</a>
    /// </summary>
    let action = _prefixId.prefix "action"
    let adHocShare = _prefixId.prefix "adHocShare"
    let aggregate = _prefixId.prefix "aggregate"
    /// <summary>
    ///   <para>rdfs:label : And</para>
    ///   <para>skos:note : This property MUST only be used for Logical Constraints, and the list of operand values MUST be Constraint instances.</para>
    ///   <para>skos:definition : The relation is satisfied when all of the Constraints are satisfied.</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/and">odrl:and</a>
    /// </summary>
    let and_ = _prefixId.prefix "and"
    /// <summary>
    ///   <para>skos:note : This property MUST only be used for Logical Constraints, and the list of operand values MUST be Constraint instances. The order of the list MUST be preserved. The andSequence operator is an example where there may be temporal conditional requirements between the operands. This may lead to situations where the outcome is unresolvable, such as deadlock if one of the Constraints is unable to be satisfied. ODRL Processing systems SHOULD plan for these scenarios and implement mechanisms to resolve them.</para>
    ///   <para>skos:definition : The relation is satisfied when each of the Constraints are satisfied in the order specified.</para>
    ///   <para>rdfs:label : And Sequence</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/andSequence">odrl:andSequence</a>
    /// </summary>
    let andSequence = _prefixId.prefix "andSequence"
    let annotate = _prefixId.prefix "annotate"
    let anonymize = _prefixId.prefix "anonymize"
    let append = _prefixId.prefix "append"
    let appendTo = _prefixId.prefix "appendTo"
    let archive = _prefixId.prefix "archive"
    /// <summary>
    ///   <para>skos:definition : The Party is the recipient of the Rule.</para>
    ///   <para>rdfs:label : Assignee</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/assignee">odrl:assignee</a>
    /// </summary>
    let assignee = _prefixId.prefix "assignee"
    /// <summary>
    ///   <para>skos:note : When assigneeOf has been asserted between a metadata expression and an ODRL Policy, the Party being identified MUST be inferred to undertake the assignee functional role of all the Rules of that Policy.</para>
    ///   <para>skos:definition : Identifies an ODRL Policy for which the identified Party undertakes the assignee functional role.</para>
    ///   <para>rdfs:label : Assignee Of</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/assigneeOf">odrl:assigneeOf</a>
    /// </summary>
    let assigneeOf = _prefixId.prefix "assigneeOf"
    /// <summary>
    ///   <para>skos:definition : The Party is the issuer of the Rule.</para>
    ///   <para>rdfs:label : Assigner</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/assigner">odrl:assigner</a>
    /// </summary>
    let assigner = _prefixId.prefix "assigner"
    /// <summary>
    ///   <para>skos:note : When assignerOf has been asserted between a metadata expression and an ODRL Policy, the Party being identified MUST be inferred to undertake the assigner functional role of all the Rules of that Policy.</para>
    ///   <para>skos:definition : Identifies an ODRL Policy for which the identified Party undertakes the assigner functional role.</para>
    ///   <para>rdfs:label : Assigner Of</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/assignerOf">odrl:assignerOf</a>
    /// </summary>
    let assignerOf = _prefixId.prefix "assignerOf"
    let attachPolicy = _prefixId.prefix "attachPolicy"
    let attachSource = _prefixId.prefix "attachSource"
    let attribute = _prefixId.prefix "attribute"
    /// <summary>
    ///   <para>skos:scopeNote : Non-Normative</para>
    ///   <para>skos:note : Maybe specified as part of the attribute action.</para>
    ///   <para>skos:definition : The Party to be attributed.</para>
    ///   <para>rdfs:label : Attributed Party</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/attributedParty">odrl:attributedParty</a>
    /// </summary>
    let attributedParty = _prefixId.prefix "attributedParty"
    /// <summary>
    ///   <para>skos:scopeNote : Non-Normative</para>
    ///   <para>skos:note : Maybe specified as part of the attribute action.</para>
    ///   <para>skos:definition : The Party who undertakes the attribution.</para>
    ///   <para>rdfs:label : Attributing Party</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/attributingParty">odrl:attributingParty</a>
    /// </summary>
    let attributingParty = _prefixId.prefix "attributingParty"
    let commercialize = _prefixId.prefix "commercialize"
    let compensate = _prefixId.prefix "compensate"
    /// <summary>
    ///   <para>skos:scopeNote : Non-Normative</para>
    ///   <para>skos:note : Maybe specified as part of the compensate duty action.</para>
    ///   <para>skos:definition : The Party is the recipient of the compensation.</para>
    ///   <para>rdfs:label : Compensated Party</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/compensatedParty">odrl:compensatedParty</a>
    /// </summary>
    let compensatedParty = _prefixId.prefix "compensatedParty"
    /// <summary>
    ///   <para>skos:scopeNote : Non-Normative</para>
    ///   <para>skos:note : Maybe specified as part of the compensate duty action.</para>
    ///   <para>skos:definition : The Party that is the provider of the compensation.</para>
    ///   <para>rdfs:label : Compensating Party</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/compensatingParty">odrl:compensatingParty</a>
    /// </summary>
    let compensatingParty = _prefixId.prefix "compensatingParty"
    let concurrentUse = _prefixId.prefix "concurrentUse"
    /// <summary>
    ///   <para>skos:note : If no strategy is specified, the default is invalid.</para>
    ///   <para>skos:definition : The conflict-resolution strategy for a Policy.</para>
    ///   <para>rdfs:label : Handle Policy Conflicts</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/conflict">odrl:conflict</a>
    /// </summary>
    let conflict = _prefixId.prefix "conflict"
    /// <summary>
    ///   <para>skos:scopeNote : Non-Normative</para>
    ///   <para>skos:note : Maybe specified as part of the obtainConsent action.</para>
    ///   <para>skos:definition : The Party who obtains the consent.</para>
    ///   <para>rdfs:label : Consented Party</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/consentedParty">odrl:consentedParty</a>
    /// </summary>
    let consentedParty = _prefixId.prefix "consentedParty"
    /// <summary>
    ///   <para>skos:scopeNote : Non-Normative</para>
    ///   <para>skos:note : Maybe specified as part of the obtainConsent action.</para>
    ///   <para>skos:definition : The Party to obtain consent from.</para>
    ///   <para>rdfs:label : Consenting Party</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/consentingParty">odrl:consentingParty</a>
    /// </summary>
    let consentingParty = _prefixId.prefix "consentingParty"
    /// <summary>
    ///   <para>rdfs:label : Consequence</para>
    ///   <para>skos:note : The consequence property is utilised to express the repercussions of not fulfilling an agreed Policy obligation or duty for a Permission. If either of these fails to be fulfilled, then this will result in the consequence Duty also becoming a new requirement, meaning that the original obligation or duty, as well as the consequence Duty must all be fulfilled</para>
    ///   <para>skos:definition : Relates a Duty to another Duty, the latter being a consequence of not fulfilling the former.</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/consequence">odrl:consequence</a>
    /// </summary>
    let consequence = _prefixId.prefix "consequence"
    /// <summary>
    ///   <para>skos:note : Constraints on Rules are used to determine if a rule is Active or not. Example: the Permission rule is only active during the year 2018.</para>
    ///   <para>skos:definition : Constraint applied to a Rule</para>
    ///   <para>rdfs:label : Has Constraint</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/constraint">odrl:constraint</a>
    /// </summary>
    let constraint_ = _prefixId.prefix "constraint"
    /// <summary>
    ///   <para>skos:scopeNote : Non-Normative</para>
    ///   <para>skos:definition : The Party who is being contracted.</para>
    ///   <para>rdfs:label : Contracted Party</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/contractedParty">odrl:contractedParty</a>
    /// </summary>
    let contractedParty = _prefixId.prefix "contractedParty"
    /// <summary>
    ///   <para>skos:scopeNote : Non-Normative</para>
    ///   <para>skos:definition : The Party who is offering the contract.</para>
    ///   <para>rdfs:label : Contracting Party</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/contractingParty">odrl:contractingParty</a>
    /// </summary>
    let contractingParty = _prefixId.prefix "contractingParty"
    let copy = _prefixId.prefix "copy"
    let core = _prefixId.prefix "core"
    let count = _prefixId.prefix "count"
    /// <summary>
    ///   <para>skos:note : In RDF encodings, use of the rdf:datatype MUST be used. In JSON-LD encoding, the use of @type MUST be used.</para>
    ///   <para>skos:definition : The datatype of the value of the rightOperand or rightOperandReference of a Constraint.</para>
    ///   <para>rdfs:label : Datatype</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/dataType">odrl:dataType</a>
    /// </summary>
    let dataType = _prefixId.prefix "dataType"
    let dateTime = _prefixId.prefix "dateTime"
    let delayPeriod = _prefixId.prefix "delayPeriod"
    let delete = _prefixId.prefix "delete"
    let deliveryChannel = _prefixId.prefix "deliveryChannel"
    let derive = _prefixId.prefix "derive"
    let device = _prefixId.prefix "device"
    let digitize = _prefixId.prefix "digitize"
    let display = _prefixId.prefix "display"
    let distribute = _prefixId.prefix "distribute"
    /// <summary>
    ///   <para>skos:note : A Duty is a pre-condition which must be fulfilled in order to receive the Permission.</para>
    ///   <para>skos:definition : Relates an individual Duty to a Permission.</para>
    ///   <para>rdfs:label : Has Duty</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/duty">odrl:duty</a>
    /// </summary>
    let duty = _prefixId.prefix "duty"
    let elapsedTime = _prefixId.prefix "elapsedTime"
    let ensureExclusivity = _prefixId.prefix "ensureExclusivity"
    let eq = _prefixId.prefix "eq"
    let event_ = _prefixId.prefix "event"
    let execute = _prefixId.prefix "execute"
    let export = _prefixId.prefix "export"
    let extract = _prefixId.prefix "extract"
    let extractChar = _prefixId.prefix "extractChar"
    let extractPage = _prefixId.prefix "extractPage"
    let extractWord = _prefixId.prefix "extractWord"
    /// <summary>
    ///   <para>skos:note : The parent property to sub-properties that express explicit failure contexts.</para>
    ///   <para>skos:definition : Failure is an abstract property that defines the violation (or unmet) relationship between Rules.</para>
    ///   <para>rdfs:label : Failure</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/failure">odrl:failure</a>
    /// </summary>
    let failure = _prefixId.prefix "failure"
    let fileFormat = _prefixId.prefix "fileFormat"
    /// <summary>
    ///   <para>skos:definition : Function is an abstract property whose sub-properties define the functional roles which may be fulfilled by a party in relation to a Rule.</para>
    ///   <para>rdfs:label : Function</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/function">odrl:function</a>
    /// </summary>
    let function_ = _prefixId.prefix "function"
    let give = _prefixId.prefix "give"
    let grantUse = _prefixId.prefix "grantUse"
    let gt = _prefixId.prefix "gt"
    let gteq = _prefixId.prefix "gteq"
    let hasPart = _prefixId.prefix "hasPart"
    /// <summary>
    ///   <para>skos:note : The Asset being identified MUST be inferred to be the target Asset of all of the Rules of the Policy.</para>
    ///   <para>skos:definition : Identifies an ODRL Policy for which the identified Asset is the target Asset to all the Rules.</para>
    ///   <para>rdfs:label : Target Policy</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/hasPolicy">odrl:hasPolicy</a>
    /// </summary>
    let hasPolicy = _prefixId.prefix "hasPolicy"
    let ignore = _prefixId.prefix "ignore"
    /// <summary>
    ///   <para>skos:note : The property asserts that an instance of Action entails that the other instance of Action is not prohibited.</para>
    ///   <para>skos:definition : An Action asserts that another Action is not prohibited to enable its operational semantics.</para>
    ///   <para>rdfs:label : Implies</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/implies">odrl:implies</a>
    /// </summary>
    let implies = _prefixId.prefix "implies"
    let include_ = _prefixId.prefix "include"
    /// <summary>
    ///   <para>rdfs:label : Included In</para>
    ///   <para>skos:definition : An Action transitively asserts that another Action that encompasses its operational semantics.</para>
    ///   <para>skos:note : The purpose is to explicitly assert that the semantics of the referenced instance of an other Action encompasses (includes) the semantics of this instance of Action. The includedIn property is transitive, and as such, the Actions form ancestor relationships.</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/includedIn">odrl:includedIn</a>
    /// </summary>
    let includedIn = _prefixId.prefix "includedIn"
    let index = _prefixId.prefix "index"
    let industry = _prefixId.prefix "industry"
    let inform = _prefixId.prefix "inform"
    /// <summary>
    ///   <para>skos:scopeNote : Non-Normative</para>
    ///   <para>skos:note : Maybe specified as part of the inform action.</para>
    ///   <para>skos:definition : The Party to be informed of all uses.</para>
    ///   <para>rdfs:label : Informed Party</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/informedParty">odrl:informedParty</a>
    /// </summary>
    let informedParty = _prefixId.prefix "informedParty"
    /// <summary>
    ///   <para>skos:scopeNote : Non-Normative</para>
    ///   <para>skos:note : Maybe specified as part of the inform action.</para>
    ///   <para>skos:definition : The Party who provides the inform use data.</para>
    ///   <para>rdfs:label : Informing Party</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/informingParty">odrl:informingParty</a>
    /// </summary>
    let informingParty = _prefixId.prefix "informingParty"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>skos:note : A boolean value.</para>
    ///   <para>skos:definition : Indicates if the Policy entity can be inherited.</para>
    ///   <para>rdfs:label : Inheritance Allowed</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/inheritAllowed">odrl:inheritAllowed</a>
    /// </summary>
    let inheritAllowed = _prefixId.prefix "inheritAllowed"
    /// <summary>
    ///   <para>skos:note : The child policy will inherit Rules from the parent policy</para>
    ///   <para>skos:definition : Relates a (child) policy to another (parent) policy from which terms are inherited.</para>
    ///   <para>rdfs:label : Inherits From</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/inheritFrom">odrl:inheritFrom</a>
    /// </summary>
    let inheritFrom = _prefixId.prefix "inheritFrom"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>skos:note : For example, this may indicate the business scenario, such as subscription, or prior arrangements between the parties (that are not machine representable).</para>
    ///   <para>skos:definition : Indentifies the type of inheritance.</para>
    ///   <para>rdfs:label : Inherit Relation</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/inheritRelation">odrl:inheritRelation</a>
    /// </summary>
    let inheritRelation = _prefixId.prefix "inheritRelation"
    let install = _prefixId.prefix "install"
    let invalid = _prefixId.prefix "invalid"
    let isA = _prefixId.prefix "isA"
    let isAllOf = _prefixId.prefix "isAllOf"
    let isAnyOf = _prefixId.prefix "isAnyOf"
    let isNoneOf = _prefixId.prefix "isNoneOf"
    let isPartOf = _prefixId.prefix "isPartOf"
    let language = _prefixId.prefix "language"
    let lease = _prefixId.prefix "lease"
    /// <summary>
    ///   <para>skos:definition : The left operand in a constraint expression.</para>
    ///   <para>rdfs:label : Has Left Operand</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/leftOperand">odrl:leftOperand</a>
    /// </summary>
    let leftOperand = _prefixId.prefix "leftOperand"
    let lend = _prefixId.prefix "lend"
    let license = _prefixId.prefix "license"
    let lt = _prefixId.prefix "lt"
    let lteq = _prefixId.prefix "lteq"
    let media = _prefixId.prefix "media"
    let meteredTime = _prefixId.prefix "meteredTime"
    let modify = _prefixId.prefix "modify"
    let move = _prefixId.prefix "move"
    let neq = _prefixId.prefix "neq"
    let nextPolicy = _prefixId.prefix "nextPolicy"
    /// <summary>
    ///   <para>skos:note : The Duty is a requirement which must be fulfilled.</para>
    ///   <para>skos:definition : Relates an individual Duty to a Policy.</para>
    ///   <para>rdfs:label : Obligation</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/obligation">odrl:obligation</a>
    /// </summary>
    let obligation = _prefixId.prefix "obligation"
    let obtainConsent = _prefixId.prefix "obtainConsent"
    /// <summary>
    ///   <para>skos:note : Sub-properties of operand are used for Logical Constraints.</para>
    ///   <para>skos:definition : Operand is an abstract property for a logical relationship.</para>
    ///   <para>rdfs:label : Operand</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/operand">odrl:operand</a>
    /// </summary>
    let operand = _prefixId.prefix "operand"
    /// <summary>
    ///   <para>skos:definition : The operator function applied to operands of a Constraint</para>
    ///   <para>rdfs:label : Has Operator</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/operator">odrl:operator</a>
    /// </summary>
    let operator = _prefixId.prefix "operator"
    /// <summary>
    ///   <para>skos:note : This property MUST only be used for Logical Constraints, and the list of operand values MUST be Constraint instances.</para>
    ///   <para>rdfs:label : Or</para>
    ///   <para>skos:definition : The relation is satisfied when at least one of the Constraints is satisfied.</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/or">odrl:or</a>
    /// </summary>
    let or_ = _prefixId.prefix "or"
    /// <summary>
    ///   <para>rdfs:label : Output</para>
    ///   <para>skos:scopeNote : Non-Normative</para>
    ///   <para>skos:definition : The output property specifies the Asset which is created from the output of the Action.</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/output">odrl:output</a>
    /// </summary>
    let output = _prefixId.prefix "output"
    /// <summary>
    ///   <para>skos:definition : Identifies an Asset/PartyCollection that the Asset/Party is a member of.</para>
    ///   <para>rdfs:label : Part Of</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/partOf">odrl:partOf</a>
    /// </summary>
    let partOf = _prefixId.prefix "partOf"
    let pay = _prefixId.prefix "pay"
    let payAmount = _prefixId.prefix "payAmount"
    /// <summary>
    ///   <para>skos:scopeNote : Non-Normative</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>skos:definition : The Party is the recipient of the payment.</para>
    ///   <para>rdfs:label : Payee Party</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/payeeParty">odrl:payeeParty</a>
    /// </summary>
    let payeeParty = _prefixId.prefix "payeeParty"
    let percentage = _prefixId.prefix "percentage"
    let perm = _prefixId.prefix "perm"
    /// <summary>
    ///   <para>skos:definition : Relates an individual Permission to a Policy.</para>
    ///   <para>rdfs:label : Has Permission</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/permission">odrl:permission</a>
    /// </summary>
    let permission = _prefixId.prefix "permission"
    let play = _prefixId.prefix "play"
    let policyUsage = _prefixId.prefix "policyUsage"
    let present = _prefixId.prefix "present"
    let preview = _prefixId.prefix "preview"
    let print = _prefixId.prefix "print"
    let product = _prefixId.prefix "product"
    /// <summary>
    ///   <para>skos:note : The profile property is mandatory if the Policy is using an ODRL Profile.</para>
    ///   <para>skos:definition : The identifier(s) of an ODRL Profile that the Policy conforms to.</para>
    ///   <para>rdfs:label : Profile</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/profile">odrl:profile</a>
    /// </summary>
    let profile = _prefixId.prefix "profile"
    let prohibit = _prefixId.prefix "prohibit"
    /// <summary>
    ///   <para>skos:definition : Relates an individual Prohibition to a Policy.</para>
    ///   <para>rdfs:label : Has Prohibition</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/prohibition">odrl:prohibition</a>
    /// </summary>
    let prohibition = _prefixId.prefix "prohibition"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>skos:note : This original term and URI from the OMA specification should be used: http://www.openmobilealliance.com/oma-dd/proximity .</para>
    ///   <para>skos:definition : An value indicating the closeness or nearness.</para>
    ///   <para>rdfs:label : proximity</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/proximity">odrl:proximity</a>
    /// </summary>
    let proximity = _prefixId.prefix "proximity"
    let purpose = _prefixId.prefix "purpose"
    let read = _prefixId.prefix "read"
    let recipient = _prefixId.prefix "recipient"
    /// <summary>
    ///   <para>skos:note : Example: the Action print is only permitted on 50% of the asset.</para>
    ///   <para>skos:definition : Constraint used to refine the semantics of an Action, or Party/Asset Collection</para>
    ///   <para>rdfs:label : Refinement</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/refinement">odrl:refinement</a>
    /// </summary>
    let refinement = _prefixId.prefix "refinement"
    /// <summary>
    ///   <para>skos:note : Sub-properties of relation are used to define the nature of that link.</para>
    ///   <para>skos:definition : Relation is an abstract property which creates an explicit link between an Action and an Asset.</para>
    ///   <para>rdfs:label : Relation</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/relation">odrl:relation</a>
    /// </summary>
    let relation = _prefixId.prefix "relation"
    let relativePosition = _prefixId.prefix "relativePosition"
    let relativeSize = _prefixId.prefix "relativeSize"
    let relativeSpatialPosition = _prefixId.prefix "relativeSpatialPosition"
    let relativeTemporalPosition = _prefixId.prefix "relativeTemporalPosition"
    /// <summary>
    ///   <para>rdfs:label : Remedy</para>
    ///   <para>skos:definition : Relates an individual remedy Duty to a Prohibition.</para>
    ///   <para>skos:note : The remedy property expresses an agreed Duty that must be fulfilled in case that a Prohibition has been violated by being exercised.</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/remedy">odrl:remedy</a>
    /// </summary>
    let remedy = _prefixId.prefix "remedy"
    let reproduce = _prefixId.prefix "reproduce"
    let resolution = _prefixId.prefix "resolution"
    let reviewPolicy = _prefixId.prefix "reviewPolicy"
    /// <summary>
    ///   <para>skos:note : When used with set-based operators, a list of values may be used.</para>
    ///   <para>skos:definition : The value of the right operand in a constraint expression.</para>
    ///   <para>rdfs:label : Has Right Operand</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/rightOperand">odrl:rightOperand</a>
    /// </summary>
    let rightOperand = _prefixId.prefix "rightOperand"
    /// <summary>
    ///   <para>skos:note : An IRI that MUST be dereferenced to obtain the actual right operand value. When used with set-based operators, a list of IRIs may be used</para>
    ///   <para>skos:definition : A reference to a web resource providing the value for the right operand of a Constraint.</para>
    ///   <para>rdfs:label : Has Right Operand Reference</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/rightOperandReference">odrl:rightOperandReference</a>
    /// </summary>
    let rightOperandReference = _prefixId.prefix "rightOperandReference"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>skos:note : Used to define scopes for Assets and Parties.</para>
    ///   <para>skos:definition : The identifier of a scope that provides context to the extent of the entity.</para>
    ///   <para>rdfs:label : Scope</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/scope">odrl:scope</a>
    /// </summary>
    let scope = _prefixId.prefix "scope"
    let secondaryUse = _prefixId.prefix "secondaryUse"
    let sell = _prefixId.prefix "sell"
    let share = _prefixId.prefix "share"
    let shareAlike = _prefixId.prefix "shareAlike"
    /// <summary>
    ///   <para>skos:note : Used by AssetCollection and PartyCollection when constraints are applied.</para>
    ///   <para>skos:definition : Reference to a Asset/PartyCollection</para>
    ///   <para>rdfs:label : Source</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/source">odrl:source</a>
    /// </summary>
    let source = _prefixId.prefix "source"
    let spatial = _prefixId.prefix "spatial"
    let spatialCoordinates = _prefixId.prefix "spatialCoordinates"
    /// <summary>
    ///   <para>skos:definition : the value generated from the leftOperand action or a value related to the leftOperand set as the reference for the comparison.</para>
    ///   <para>rdfs:label : Status</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/status">odrl:status</a>
    /// </summary>
    let status = _prefixId.prefix "status"
    let stream = _prefixId.prefix "stream"
    let support = _prefixId.prefix "support"
    let synchronize = _prefixId.prefix "synchronize"
    let system = _prefixId.prefix "system"
    let systemDevice = _prefixId.prefix "systemDevice"
    /// <summary>
    ///   <para>skos:definition : The target property indicates the Asset that is the primary subject to which the Rule action directly applies.</para>
    ///   <para>rdfs:label : Target</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/target">odrl:target</a>
    /// </summary>
    let target = _prefixId.prefix "target"
    let textToSpeech = _prefixId.prefix "textToSpeech"
    let timeInterval = _prefixId.prefix "timeInterval"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>skos:note : This original term and URI from the OMA specification should be used: http://www.openmobilealliance.com/oma-dd/timed-count .</para>
    ///   <para>skos:definition : The number of seconds after which timed metering use of the asset begins.</para>
    ///   <para>rdfs:label : Timed Count</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/timedCount">odrl:timedCount</a>
    /// </summary>
    let timedCount = _prefixId.prefix "timedCount"
    /// <summary>
    ///   <para>skos:scopeNote : Non-Normative</para>
    ///   <para>skos:note : May be specified as part of the acceptTracking action.</para>
    ///   <para>skos:definition : The Party whose usage is being tracked.</para>
    ///   <para>rdfs:label : Tracked Party</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/trackedParty">odrl:trackedParty</a>
    /// </summary>
    let trackedParty = _prefixId.prefix "trackedParty"
    /// <summary>
    ///   <para>skos:scopeNote : Non-Normative</para>
    ///   <para>skos:note : May be specified as part of the acceptTracking action.</para>
    ///   <para>skos:definition : The Party who is tracking usage.</para>
    ///   <para>rdfs:label : Tracking Party</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/trackingParty">odrl:trackingParty</a>
    /// </summary>
    let trackingParty = _prefixId.prefix "trackingParty"
    let transfer = _prefixId.prefix "transfer"
    let transform = _prefixId.prefix "transform"
    let translate = _prefixId.prefix "translate"
    /// <summary>
    ///   <para>skos:note : Used by the Policy, Rule, Asset, Party, Constraint, and Logical Constraint Classes.</para>
    ///   <para>skos:definition : An unambiguous identifier</para>
    ///   <para>rdfs:label : Unique Identifier</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/uid">odrl:uid</a>
    /// </summary>
    let uid = _prefixId.prefix "uid"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>skos:note : If no strategy is specified, the default is invalid.</para>
    ///   <para>skos:definition : Relates the strategy used for handling undefined actions to a Policy.</para>
    ///   <para>rdfs:label : Handle Undefined Term</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/undefined">odrl:undefined</a>
    /// </summary>
    let undefined = _prefixId.prefix "undefined"
    let uninstall = _prefixId.prefix "uninstall"
    /// <summary>
    ///   <para>skos:definition : The unit of measurement of the value of the rightOperand or rightOperandReference of a Constraint.</para>
    ///   <para>rdfs:label : Unit</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/unit">odrl:unit</a>
    /// </summary>
    let unit = _prefixId.prefix "unit"
    let unitOfCount = _prefixId.prefix "unitOfCount"
    let use_ = _prefixId.prefix "use"
    let version = _prefixId.prefix "version"
    let virtualLocation = _prefixId.prefix "virtualLocation"
    let watermark = _prefixId.prefix "watermark"
    let write = _prefixId.prefix "write"
    let writeTo = _prefixId.prefix "writeTo"
    /// <summary>
    ///   <para>skos:note : This property MUST only be used for Logical Constraints, and the list of operand values MUST be Constraint instances.</para>
    ///   <para>rdfs:label : Only One</para>
    ///   <para>skos:definition : The relation is satisfied when only one, and not more, of the Constaints is satisfied</para>
    ///   <a href="http://www.w3.org/ns/odrl/2/xone">odrl:xone</a>
    /// </summary>
    let xone = _prefixId.prefix "xone"

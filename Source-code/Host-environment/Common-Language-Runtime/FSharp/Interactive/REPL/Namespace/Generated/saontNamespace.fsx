#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module saont =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/sao#" "saont"
    /// <summary>
    ///   <para>rdfs:label : Accountability Plan^^xsd:string</para>
    ///   <para>rdfs:comment : A plan which describes a specification of the information that should be collected, so as to support accountability of systems.^^xsd:string</para>
    ///   <a href="https://w3id.org/sao#AccountabilityPlan">saont:AccountabilityPlan</a>
    /// </summary>
    let AccountabilityPlan = _prefixId.prefix "AccountabilityPlan"
    /// <summary>
    ///   <para>rdfs:label : Accountable Action^^xsd:string</para>
    ///   <para>rdfs:comment : A planned step which is deemed to be important for accountability purposes and produces AccountableResult.^^xsd:string</para>
    ///   <a href="https://w3id.org/sao#AccountableAction">saont:AccountableAction</a>
    /// </summary>
    let AccountableAction = _prefixId.prefix "AccountableAction"
    /// <summary>
    ///   <para>rdfs:label : Accountable Agent^^xsd:string</para>
    ///   <para>rdfs:comment : An agent (typically a human)  that can be held accountable for his/her actions.^^xsd:string</para>
    ///   <a href="https://w3id.org/sao#AccountableAgent">saont:AccountableAgent</a>
    /// </summary>
    let AccountableAgent = _prefixId.prefix "AccountableAgent"
    /// <summary>
    ///   <para>rdfs:label : Accountable Object^^xsd:string</para>
    ///   <para>rdfs:comment : An accountable object models an abstract representation of a thing that should be documented for accountability. This may reference the whole system, its logical part, or associated process.  For example, a larger system may be described as a group of sub-systems or a single system may be broken down into a number of layers/components (e.g., a decision logic layer).^^xsd:string</para>
    ///   <a href="https://w3id.org/sao#AccountableObject">saont:AccountableObject</a>
    /// </summary>
    let AccountableObject = _prefixId.prefix "AccountableObject"
    /// <summary>
    ///   <para>rdfs:label : Accountable Result^^xsd:string</para>
    ///   <para>rdfs:comment : An output variable which is produced by an Accountable Action, for example,  a decision made by a human or a specification produced by a team. The variable is part of the accountability plan and has a corresponding InformationRealization collection in the execution trace.^^xsd:string</para>
    ///   <a href="https://w3id.org/sao#AccountableResult">saont:AccountableResult</a>
    /// </summary>
    let AccountableResult = _prefixId.prefix "AccountableResult"
    /// <summary>
    ///   <para>rdfs:label : Information Element^^xsd:string</para>
    ///   <para>rdfs:comment : A member of the collection of type Information Realization. Information Realizations may have multiple Information Elements.  Information Element describes in more detail a specific type of information contained by the Information Realization collection.^^xsd:string</para>
    ///   <a href="https://w3id.org/sao#InformationElement">saont:InformationElement</a>
    /// </summary>
    let InformationElement = _prefixId.prefix "InformationElement"
    /// <summary>
    ///   <para>rdfs:label : Information Realization^^xsd:string</para>
    ///   <para>rdfs:comment : A collection of pieces of information (InformationElements) which corresponds to a variable of type  AccountableResult. The collection represents the actual piece of provenance information documenting a specific AccountableResult during a single plan execution.^^xsd:string</para>
    ///   <a href="https://w3id.org/sao#InformationRealization">saont:InformationRealization</a>
    /// </summary>
    let InformationRealization = _prefixId.prefix "InformationRealization"
    /// <summary>
    ///   <para>rdfs:label : System^^xsd:string</para>
    ///   <para>rdfs:comment : A system that the collected accountability information is about.^^xsd:string</para>
    ///   <a href="https://w3id.org/sao#System">saont:System</a>
    /// </summary>
    let System = _prefixId.prefix "System"
    /// <summary>
    ///   <para>rdfs:label : has accountable agent^^xsd:string</para>
    ///   <para>rdfs:comment : Inverse of is accountable for^^xsd:string</para>
    ///   <a href="https://w3id.org/sao#hasAccountableAgent">saont:hasAccountableAgent</a>
    /// </summary>
    let hasAccountableAgent = _prefixId.prefix "hasAccountableAgent"
    /// <summary>
    ///   <para>rdfs:label : has related accountable result^^xsd:string</para>
    ///   <a href="https://w3id.org/sao#hasRelatedAccountableResult">saont:hasRelatedAccountableResult</a>
    /// </summary>
    let hasRelatedAccountableResult = _prefixId.prefix "hasRelatedAccountableResult"
    /// <summary>
    ///   <para>rdfs:label : has specified accountability plan^^xsd:string</para>
    ///   <para>rdfs:comment : Inverse of specified for system.^^xsd:string</para>
    ///   <a href="https://w3id.org/sao#hasSpecifiedAccountabiltyPlan">saont:hasSpecifiedAccountabiltyPlan</a>
    /// </summary>
    let hasSpecifiedAccountabiltyPlan = _prefixId.prefix "hasSpecifiedAccountabiltyPlan"
    /// <summary>
    ///   <para>rdfs:label : impacts^^xsd:string</para>
    ///   <para>rdfs:comment : A relation which describes that an accountable object have some effect on the system's accountability.^^xsd:string</para>
    ///   <a href="https://w3id.org/sao#impacts">saont:impacts</a>
    /// </summary>
    let impacts = _prefixId.prefix "impacts"
    /// <summary>
    ///   <para>rdfs:label : is accountable for^^xsd:string</para>
    ///   <para>rdfs:comment : A relation that links accountable agents to entities they are accountable for.^^xsd:string</para>
    ///   <a href="https://w3id.org/sao#isAccountableFor">saont:isAccountableFor</a>
    /// </summary>
    let isAccountableFor = _prefixId.prefix "isAccountableFor"
    /// <summary>
    ///   <para>rdfs:label : is impacted by^^xsd:string</para>
    ///   <para>rdfs:comment : Inverse of impacts.^^xsd:string</para>
    ///   <a href="https://w3id.org/sao#isImpactedBy">saont:isImpactedBy</a>
    /// </summary>
    let isImpactedBy = _prefixId.prefix "isImpactedBy"
    /// <summary>
    ///   <para>rdfs:label : relates to accountable object^^xsd:string</para>
    ///   <para>rdfs:comment : A relation which describes the information described by an accountable result relates to an accountable object.^^xsd:string</para>
    ///   <a href="https://w3id.org/sao#relatesToAccountableObject">saont:relatesToAccountableObject</a>
    /// </summary>
    let relatesToAccountableObject = _prefixId.prefix "relatesToAccountableObject"
    /// <summary>
    ///   <para>rdfs:label : specified for system^^xsd:string</para>
    ///   <para>rdfs:comment : A relation that links the accountability plan to the system it was specified for.^^xsd:string</para>
    ///   <a href="https://w3id.org/sao#specifiedForSystem">saont:specifiedForSystem</a>
    /// </summary>
    let specifiedForSystem = _prefixId.prefix "specifiedForSystem"

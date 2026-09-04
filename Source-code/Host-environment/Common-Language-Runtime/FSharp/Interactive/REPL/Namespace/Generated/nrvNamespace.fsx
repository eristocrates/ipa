#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module nrv =
    let _prefixId = PrefixId.fromNamespaceLabel "http://ns.inria.fr/nrv#" "nrv"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : achievement</para>
    ///   <para>rdfs:comment : an obligation for which achieving the content at least once is enough to fulfil it.</para>
    ///   <a href="http://ns.inria.fr/nrv#Achievement">nrv:Achievement</a>
    /// </summary>
    let Achievement = _prefixId.prefix "Achievement"
    /// <summary>
    ///   <para>rdfs:label : co-occurant punctual requirement</para>
    ///   <para>rdfs:comment : TODO.</para>
    ///   <a href="http://ns.inria.fr/nrv#CoOccurantPunctual">nrv:CoOccurantPunctual</a>
    /// </summary>
    let CoOccurantPunctual = _prefixId.prefix "CoOccurantPunctual"
    /// <summary>
    ///   <para>rdfs:label : compensable requirement</para>
    ///   <para>rdfs:comment : a requirement that can be compensated.</para>
    ///   <a href="http://ns.inria.fr/nrv#CompensableRequirement">nrv:CompensableRequirement</a>
    /// </summary>
    let CompensableRequirement = _prefixId.prefix "CompensableRequirement"
    /// <summary>
    ///   <para>rdfs:label : compensated requirement</para>
    ///   <para>rdfs:comment : a requirement violated in a state of affairs and compensated in that same state of affairs.</para>
    ///   <a href="http://ns.inria.fr/nrv#CompensatedRequirement">nrv:CompensatedRequirement</a>
    /// </summary>
    let CompensatedRequirement = _prefixId.prefix "CompensatedRequirement"
    /// <summary>
    ///   <para>rdfs:label : compensation</para>
    ///   <para>rdfs:comment : a set of penalties or sanctions imposed on the violator ; fulfilling them makes amends for the violation.</para>
    ///   <a href="http://ns.inria.fr/nrv#Compensation">nrv:Compensation</a>
    /// </summary>
    let Compensation = _prefixId.prefix "Compensation"
    /// <summary>
    ///   <para>rdfs:label : compliant requirement</para>
    ///   <para>rdfs:comment : a requirement being compliant with a state of affairs.</para>
    ///   <a href="http://ns.inria.fr/nrv#CompliantRequirement">nrv:CompliantRequirement</a>
    /// </summary>
    let CompliantRequirement = _prefixId.prefix "CompliantRequirement"
    /// <summary>
    ///   <para>rdfs:label : maintenance</para>
    ///   <para>rdfs:comment : an obligation that needs to be obeyed for the whole duration within the interval in which it is in force.</para>
    ///   <a href="http://ns.inria.fr/nrv#Maintenance">nrv:Maintenance</a>
    /// </summary>
    let Maintenance = _prefixId.prefix "Maintenance"
    /// <summary>
    ///   <para>rdfs:label : non co-occurant punctual requirement</para>
    ///   <para>rdfs:comment : TODO.</para>
    ///   <a href="http://ns.inria.fr/nrv#NonCoOccurantPunctual">nrv:NonCoOccurantPunctual</a>
    /// </summary>
    let NonCoOccurantPunctual = _prefixId.prefix "NonCoOccurantPunctual"
    /// <summary>
    ///   <para>rdfs:label : non compensable requirement</para>
    ///   <para>rdfs:comment : a requirement that cannot be compensated.</para>
    ///   <a href="http://ns.inria.fr/nrv#NonCompensableRequirement">nrv:NonCompensableRequirement</a>
    /// </summary>
    let NonCompensableRequirement = _prefixId.prefix "NonCompensableRequirement"
    /// <summary>
    ///   <para>rdfs:label : non perdurant requirement</para>
    ///   <para>rdfs:comment : achievement requirement that does not persist after being violated.</para>
    ///   <a href="http://ns.inria.fr/nrv#NonPerdurantAchievement">nrv:NonPerdurantAchievement</a>
    /// </summary>
    let NonPerdurantAchievement = _prefixId.prefix "NonPerdurantAchievement"
    /// <summary>
    ///   <para>rdfs:label : non persistent requirement</para>
    ///   <para>rdfs:comment : a requirement that is in force at a particular time point only or for the instance it is in force.</para>
    ///   <a href="http://ns.inria.fr/nrv#NonPersistentRequirement">nrv:NonPersistentRequirement</a>
    /// </summary>
    let NonPersistentRequirement = _prefixId.prefix "NonPersistentRequirement"
    /// <summary>
    ///   <para>rdfs:label : non preemptive achievement requirement</para>
    ///   <para>rdfs:comment : an achievement requirement that cannot be fulfilled even before it is actually in force.</para>
    ///   <a href="http://ns.inria.fr/nrv#NonPreemptiveAchievement">nrv:NonPreemptiveAchievement</a>
    /// </summary>
    let NonPreemptiveAchievement = _prefixId.prefix "NonPreemptiveAchievement"
    /// <summary>
    ///   <para>rdfs:label : non violable requirement</para>
    ///   <para>rdfs:comment : a requirement that cannot be violated.</para>
    ///   <a href="http://ns.inria.fr/nrv#NonViolableRequirement">nrv:NonViolableRequirement</a>
    /// </summary>
    let NonViolableRequirement = _prefixId.prefix "NonViolableRequirement"
    /// <summary>
    ///   <para>rdfs:label : Normative Requirement</para>
    ///   <para>rdfs:comment : a requirement implying, creating, or prescribing a norm.</para>
    ///   <a href="http://ns.inria.fr/nrv#NormativeRequirement">nrv:NormativeRequirement</a>
    /// </summary>
    let NormativeRequirement = _prefixId.prefix "NormativeRequirement"
    /// <summary>
    ///   <para>rdfs:label : perdurant achievement requirement</para>
    ///   <para>rdfs:comment : achievement requirement that persists after being violated.</para>
    ///   <a href="http://ns.inria.fr/nrv#PerdurantAchievement">nrv:PerdurantAchievement</a>
    /// </summary>
    let PerdurantAchievement = _prefixId.prefix "PerdurantAchievement"
    /// <summary>
    ///   <para>rdfs:label : persistent requirement</para>
    ///   <para>rdfs:comment : a requirement that needs to be obeyed for the whole duration within the interval in which it is in force.</para>
    ///   <a href="http://ns.inria.fr/nrv#PersistentRequirement">nrv:PersistentRequirement</a>
    /// </summary>
    let PersistentRequirement = _prefixId.prefix "PersistentRequirement"
    /// <summary>
    ///   <para>rdfs:label : preemptive achievement requirement</para>
    ///   <para>rdfs:comment : an achievement requirement that can be fulfilled even before it is actually in force.</para>
    ///   <a href="http://ns.inria.fr/nrv#PreemptiveAchievement">nrv:PreemptiveAchievement</a>
    /// </summary>
    let PreemptiveAchievement = _prefixId.prefix "PreemptiveAchievement"
    /// <summary>
    ///   <para>rdfs:label : punctual</para>
    ///   <para>rdfs:comment : an obligation for which the contents must be immediately achieved.</para>
    ///   <a href="http://ns.inria.fr/nrv#Punctual">nrv:Punctual</a>
    /// </summary>
    let Punctual = _prefixId.prefix "Punctual"
    /// <summary>
    ///   <para>rdfs:label : violable requirement</para>
    ///   <para>rdfs:comment : a requirement that can be violated.</para>
    ///   <a href="http://ns.inria.fr/nrv#ViolableRequirement">nrv:ViolableRequirement</a>
    /// </summary>
    let ViolableRequirement = _prefixId.prefix "ViolableRequirement"
    /// <summary>
    ///   <para>rdfs:label : violated requirement</para>
    ///   <para>rdfs:comment : a requirement violated by a state of affairs.</para>
    ///   <a href="http://ns.inria.fr/nrv#ViolatedRequirement">nrv:ViolatedRequirement</a>
    /// </summary>
    let ViolatedRequirement = _prefixId.prefix "ViolatedRequirement"
    /// <summary>
    ///   <para>rdfs:label : has for compensation</para>
    ///   <para>rdfs:comment : links a compensable requirement to a compensation.</para>
    ///   <a href="http://ns.inria.fr/nrv#hasCompensation">nrv:hasCompensation</a>
    /// </summary>
    let hasCompensation = _prefixId.prefix "hasCompensation"
    /// <summary>
    ///   <para>rdfs:label : has for compliance</para>
    ///   <para>rdfs:comment : links a violable requirement to compliance.</para>
    ///   <a href="http://ns.inria.fr/nrv#hasCompliance">nrv:hasCompliance</a>
    /// </summary>
    let hasCompliance = _prefixId.prefix "hasCompliance"
    /// <summary>
    ///   <para>rdfs:label : has for violation</para>
    ///   <para>rdfs:comment : links a violable requirement to a violation.</para>
    ///   <a href="http://ns.inria.fr/nrv#hasViolation">nrv:hasViolation</a>
    /// </summary>
    let hasViolation = _prefixId.prefix "hasViolation"

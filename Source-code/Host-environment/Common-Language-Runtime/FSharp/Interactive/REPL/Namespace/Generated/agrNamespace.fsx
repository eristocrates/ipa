#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module agr =
    let _prefixId = PrefixId.fromNamespaceLabel "http://promsns.org/def/agr#" "agr"
    /// <summary>
    ///   <para>rdfs:label : Agreement</para>
    ///   <para>rdfs:comment : A description of a set of required actions by particular agents. All the required actions are detailed in Requirements class objects that this is a Collection of so the Agreement is just a container</para>
    ///   <a href="http://promsns.org/def/agr#Agreement">agr:Agreement</a>
    /// </summary>
    let Agreement = _prefixId.prefix "Agreement"
    let MAY = _prefixId.prefix "MAY"
    let MUST = _prefixId.prefix "MUST"
    let MUST_NOT = _prefixId.prefix "MUST_NOT"
    let OPTIONAL = _prefixId.prefix "OPTIONAL"
    let RECOMMENDED = _prefixId.prefix "RECOMMENDED"
    let REQUIRED = _prefixId.prefix "REQUIRED"
    /// <summary>
    ///   <para>rdfs:label : Requirement</para>
    ///   <para>rdfs:comment : This class is analagous to the Creative Commons ontology formerly available. According to CC, a Requirement is "an action that may or may not be requested of you". In this ontology, it is only "an action that may be requested of you"</para>
    ///   <a href="http://promsns.org/def/agr#Requirement">agr:Requirement</a>
    /// </summary>
    let Requirement = _prefixId.prefix "Requirement"
    /// <summary>
    ///   <para>rdfs:label : Requirement Level</para>
    ///   <para>rdfs:comment : An RequirementLevel is the level at which an Agreement complels the Agents it affects to action. The initial instances of Imperative are taken from RFC2119.</para>
    ///   <a href="http://promsns.org/def/agr#RequirementLevel">agr:RequirementLevel</a>
    /// </summary>
    let RequirementLevel = _prefixId.prefix "RequirementLevel"
    /// <summary>
    ///   <para>rdfs:label : Requirement Resolution</para>
    ///   <para>rdfs:comment : An action that resolves requirements</para>
    ///   <a href="http://promsns.org/def/agr#RequirementResolution">agr:RequirementResolution</a>
    /// </summary>
    let RequirementResolution = _prefixId.prefix "RequirementResolution"
    let SHALL = _prefixId.prefix "SHALL"
    let SHALL_NOT = _prefixId.prefix "SHALL_NOT"
    let SHOULD = _prefixId.prefix "SHOULD"
    let SHOULD_NOT = _prefixId.prefix "SHOULD_NOT"
    /// <summary>
    ///   <para>rdfs:label : has scope</para>
    ///   <para>rdfs:comment : This property is the union (group) of all Agents indicated as being within the scope of an Agreement by the hasWithinScope property.</para>
    ///   <a href="http://promsns.org/def/agr#hasScope">agr:hasScope</a>
    /// </summary>
    let hasScope = _prefixId.prefix "hasScope"
    /// <summary>
    ///   <para>rdfs:label : has within scope</para>
    ///   <para>rdfs:comment : This property indicates an Agent affected by an Agreement. It is likely that the Agent will be a group (foaf:Group) or an Organization (org:Organisation) rather than an individual person and certainly not a machine Agent. Individual Agents indicated as being affected by an Agreement via this property collectively make a group, formal or informal, that can be indicated as being the entire scope group of an Agreement via hasScopeOf property of it.</para>
    ///   <a href="http://promsns.org/def/agr#hasWithinScope">agr:hasWithinScope</a>
    /// </summary>
    let hasWithinScope = _prefixId.prefix "hasWithinScope"
    /// <summary>
    ///   <para>rdfs:label : requirement level</para>
    ///   <para>rdfs:comment : a Requirement has a requirementLevel of a RequirementLevel</para>
    ///   <a href="http://promsns.org/def/agr#requirementLevel">agr:requirementLevel</a>
    /// </summary>
    let requirementLevel = _prefixId.prefix "requirementLevel"
    let requirementOf = _prefixId.prefix "requirementOf"
    /// <summary>
    ///   <para>rdfs:label : requires</para>
    ///   <para>rdfs:comment : An Agreement requires a Requirement</para>
    ///   <a href="http://promsns.org/def/agr#requires">agr:requires</a>
    /// </summary>
    let requires = _prefixId.prefix "requires"
    let satisfiedBy = _prefixId.prefix "satisfiedBy"
    /// <summary>
    ///   <para>rdfs:label : satisfies</para>
    ///   <para>rdfs:comment : a Requirement Resolution satisfies a Requirement</para>
    ///   <a href="http://promsns.org/def/agr#satisfies">agr:satisfies</a>
    /// </summary>
    let satisfies = _prefixId.prefix "satisfies"
    /// <summary>
    ///   <para>rdfs:label : scope of</para>
    ///   <para>rdfs:comment : inverse of hasScopeOf</para>
    ///   <a href="http://promsns.org/def/agr#scopeOf">agr:scopeOf</a>
    /// </summary>
    let scopeOf = _prefixId.prefix "scopeOf"
    /// <summary>
    ///   <para>rdfs:label : within scope</para>
    ///   <para>rdfs:comment : inverse of hasWithinScope</para>
    ///   <a href="http://promsns.org/def/agr#withinScopeOf">agr:withinScopeOf</a>
    /// </summary>
    let withinScopeOf = _prefixId.prefix "withinScopeOf"

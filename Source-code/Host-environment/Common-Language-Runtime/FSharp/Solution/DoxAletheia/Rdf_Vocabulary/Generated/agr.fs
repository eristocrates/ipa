namespace http.promsns.org.def.agr.hash

open DoxAletheia

module agr =
    let _namespace_name = "http://promsns.org/def/agr#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A description of a set of required actions by particular agents. All the required actions are detailed in Requirements class objects that this is a Collection of so the Agreement is just a container
    /// <see href="http://promsns.org/def/agr#Agreement"></see></summary>
    let Agreement = _prefix "Agreement"
    /// <summary>
    /// An Agreement requires a Requirement
    /// <see href="http://promsns.org/def/agr#requires"></see></summary>
    let requires = _prefix "requires"
    /// <summary>
    ///   <see href="http://promsns.org/def/agr#MAY"></see>
    /// </summary>
    let MAY = _prefix "MAY"
    /// <summary>
    /// An RequirementLevel is the level at which an Agreement complels the Agents it affects to action. The initial instances of Imperative are taken from RFC2119.
    /// <see href="http://promsns.org/def/agr#RequirementLevel"></see></summary>
    let RequirementLevel = _prefix "RequirementLevel"
    /// <summary>
    ///   <see href="http://promsns.org/def/agr#MUST"></see>
    /// </summary>
    let MUST = _prefix "MUST"
    /// <summary>
    ///   <see href="http://promsns.org/def/agr#MUST_NOT"></see>
    /// </summary>
    let MUST_NOT = _prefix "MUST_NOT"
    /// <summary>
    ///   <see href="http://promsns.org/def/agr#OPTIONAL"></see>
    /// </summary>
    let OPTIONAL = _prefix "OPTIONAL"
    /// <summary>
    ///   <see href="http://promsns.org/def/agr#RECOMMENDED"></see>
    /// </summary>
    let RECOMMENDED = _prefix "RECOMMENDED"
    /// <summary>
    ///   <see href="http://promsns.org/def/agr#REQUIRED"></see>
    /// </summary>
    let REQUIRED = _prefix "REQUIRED"
    /// <summary>
    /// This class is analagous to the Creative Commons ontology formerly available. According to CC, a Requirement is "an action that may or may not be requested of you". In this ontology, it is only "an action that may be requested of you"
    /// <see href="http://promsns.org/def/agr#Requirement"></see></summary>
    let Requirement = _prefix "Requirement"
    /// <summary>
    /// a Requirement has a requirementLevel of a RequirementLevel
    /// <see href="http://promsns.org/def/agr#requirementLevel"></see></summary>
    let requirementLevel = _prefix "requirementLevel"
    /// <summary>
    /// An action that resolves requirements
    /// <see href="http://promsns.org/def/agr#RequirementResolution"></see></summary>
    let RequirementResolution = _prefix "RequirementResolution"
    /// <summary>
    /// a Requirement Resolution satisfies a Requirement
    /// <see href="http://promsns.org/def/agr#satisfies"></see></summary>
    let satisfies = _prefix "satisfies"
    /// <summary>
    ///   <see href="http://promsns.org/def/agr#SHALL"></see>
    /// </summary>
    let SHALL = _prefix "SHALL"
    /// <summary>
    ///   <see href="http://promsns.org/def/agr#SHALL_NOT"></see>
    /// </summary>
    let SHALL_NOT = _prefix "SHALL_NOT"
    /// <summary>
    ///   <see href="http://promsns.org/def/agr#SHOULD"></see>
    /// </summary>
    let SHOULD = _prefix "SHOULD"
    /// <summary>
    ///   <see href="http://promsns.org/def/agr#SHOULD_NOT"></see>
    /// </summary>
    let SHOULD_NOT = _prefix "SHOULD_NOT"
    /// <summary>
    /// This property is the union (group) of all Agents indicated as being within the scope of an Agreement by the hasWithinScope property.
    /// <see href="http://promsns.org/def/agr#hasScope"></see></summary>
    let hasScope = _prefix "hasScope"
    /// <summary>
    /// inverse of hasScopeOf
    /// <see href="http://promsns.org/def/agr#scopeOf"></see></summary>
    let scopeOf = _prefix "scopeOf"
    /// <summary>
    /// This property indicates an Agent affected by an Agreement. It is likely that the Agent will be a group (foaf:Group) or an Organization (org:Organisation) rather than an individual person and certainly not a machine Agent. Individual Agents indicated as being affected by an Agreement via this property collectively make a group, formal or informal, that can be indicated as being the entire scope group of an Agreement via hasScopeOf property of it.
    /// <see href="http://promsns.org/def/agr#hasWithinScope"></see></summary>
    let hasWithinScope = _prefix "hasWithinScope"
    /// <summary>
    /// inverse of hasWithinScope
    /// <see href="http://promsns.org/def/agr#withinScopeOf"></see></summary>
    let withinScopeOf = _prefix "withinScopeOf"
    /// <summary>
    /// A Requirement is a requirementOf an Agreement
    /// <see href="http://promsns.org/def/agr#requirementOf"></see></summary>
    let requirementOf = _prefix "requirementOf"
    /// <summary>
    /// inverse of satisfies
    /// <see href="http://promsns.org/def/agr#satisfiedBy"></see></summary>
    let satisfiedBy = _prefix "satisfiedBy"

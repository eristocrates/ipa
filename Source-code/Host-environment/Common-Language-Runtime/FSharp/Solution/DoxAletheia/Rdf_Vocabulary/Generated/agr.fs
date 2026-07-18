namespace http.promsns.org.def.agr.hash

open DoxAletheia.Rdf_Vocabulary

module agr =
    let _namespace_name = "http://promsns.org/def/agr#"
    /// <summary>
    /// A description of a set of required actions by particular agents. All the required actions are detailed in Requirements class objects that this is a Collection of so the Agreement is just a container
    /// <see href="http://promsns.org/def/agr#Agreement"></see></summary>
    let Agreement = Namespaced_IRI.parse _namespace_name "Agreement" |> NamespacedName
    /// <summary>
    /// An Agreement requires a Requirement
    /// <see href="http://promsns.org/def/agr#requires"></see></summary>
    let requires = Namespaced_IRI.parse _namespace_name "requires" |> NamespacedName
    /// <summary>
    ///   <see href="http://promsns.org/def/agr#MAY"></see>
    /// </summary>
    let MAY = Namespaced_IRI.parse _namespace_name "MAY" |> NamespacedName

    /// <summary>
    /// An RequirementLevel is the level at which an Agreement complels the Agents it affects to action. The initial instances of Imperative are taken from RFC2119.
    /// <see href="http://promsns.org/def/agr#RequirementLevel"></see></summary>
    let RequirementLevel =
        Namespaced_IRI.parse _namespace_name "RequirementLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://promsns.org/def/agr#MUST"></see>
    /// </summary>
    let MUST = Namespaced_IRI.parse _namespace_name "MUST" |> NamespacedName
    /// <summary>
    ///   <see href="http://promsns.org/def/agr#MUST_NOT"></see>
    /// </summary>
    let MUST_NOT = Namespaced_IRI.parse _namespace_name "MUST_NOT" |> NamespacedName
    /// <summary>
    ///   <see href="http://promsns.org/def/agr#OPTIONAL"></see>
    /// </summary>
    let OPTIONAL = Namespaced_IRI.parse _namespace_name "OPTIONAL" |> NamespacedName

    /// <summary>
    ///   <see href="http://promsns.org/def/agr#RECOMMENDED"></see>
    /// </summary>
    let RECOMMENDED =
        Namespaced_IRI.parse _namespace_name "RECOMMENDED" |> NamespacedName

    /// <summary>
    ///   <see href="http://promsns.org/def/agr#REQUIRED"></see>
    /// </summary>
    let REQUIRED = Namespaced_IRI.parse _namespace_name "REQUIRED" |> NamespacedName

    /// <summary>
    /// This class is analagous to the Creative Commons ontology formerly available. According to CC, a Requirement is "an action that may or may not be requested of you". In this ontology, it is only "an action that may be requested of you"
    /// <see href="http://promsns.org/def/agr#Requirement"></see></summary>
    let Requirement =
        Namespaced_IRI.parse _namespace_name "Requirement" |> NamespacedName

    /// <summary>
    /// a Requirement has a requirementLevel of a RequirementLevel
    /// <see href="http://promsns.org/def/agr#requirementLevel"></see></summary>
    let requirementLevel =
        Namespaced_IRI.parse _namespace_name "requirementLevel" |> NamespacedName

    /// <summary>
    /// An action that resolves requirements
    /// <see href="http://promsns.org/def/agr#RequirementResolution"></see></summary>
    let RequirementResolution =
        Namespaced_IRI.parse _namespace_name "RequirementResolution" |> NamespacedName

    /// <summary>
    /// a Requirement Resolution satisfies a Requirement
    /// <see href="http://promsns.org/def/agr#satisfies"></see></summary>
    let satisfies = Namespaced_IRI.parse _namespace_name "satisfies" |> NamespacedName
    /// <summary>
    ///   <see href="http://promsns.org/def/agr#SHALL"></see>
    /// </summary>
    let SHALL = Namespaced_IRI.parse _namespace_name "SHALL" |> NamespacedName
    /// <summary>
    ///   <see href="http://promsns.org/def/agr#SHALL_NOT"></see>
    /// </summary>
    let SHALL_NOT = Namespaced_IRI.parse _namespace_name "SHALL_NOT" |> NamespacedName
    /// <summary>
    ///   <see href="http://promsns.org/def/agr#SHOULD"></see>
    /// </summary>
    let SHOULD = Namespaced_IRI.parse _namespace_name "SHOULD" |> NamespacedName
    /// <summary>
    ///   <see href="http://promsns.org/def/agr#SHOULD_NOT"></see>
    /// </summary>
    let SHOULD_NOT = Namespaced_IRI.parse _namespace_name "SHOULD_NOT" |> NamespacedName
    /// <summary>
    /// This property is the union (group) of all Agents indicated as being within the scope of an Agreement by the hasWithinScope property.
    /// <see href="http://promsns.org/def/agr#hasScope"></see></summary>
    let hasScope = Namespaced_IRI.parse _namespace_name "hasScope" |> NamespacedName
    /// <summary>
    /// inverse of hasScopeOf
    /// <see href="http://promsns.org/def/agr#scopeOf"></see></summary>
    let scopeOf = Namespaced_IRI.parse _namespace_name "scopeOf" |> NamespacedName

    /// <summary>
    /// This property indicates an Agent affected by an Agreement. It is likely that the Agent will be a group (foaf:Group) or an Organization (org:Organisation) rather than an individual person and certainly not a machine Agent. Individual Agents indicated as being affected by an Agreement via this property collectively make a group, formal or informal, that can be indicated as being the entire scope group of an Agreement via hasScopeOf property of it.
    /// <see href="http://promsns.org/def/agr#hasWithinScope"></see></summary>
    let hasWithinScope =
        Namespaced_IRI.parse _namespace_name "hasWithinScope" |> NamespacedName

    /// <summary>
    /// inverse of hasWithinScope
    /// <see href="http://promsns.org/def/agr#withinScopeOf"></see></summary>
    let withinScopeOf =
        Namespaced_IRI.parse _namespace_name "withinScopeOf" |> NamespacedName

    /// <summary>
    /// A Requirement is a requirementOf an Agreement
    /// <see href="http://promsns.org/def/agr#requirementOf"></see></summary>
    let requirementOf =
        Namespaced_IRI.parse _namespace_name "requirementOf" |> NamespacedName

    /// <summary>
    /// inverse of satisfies
    /// <see href="http://promsns.org/def/agr#satisfiedBy"></see></summary>
    let satisfiedBy =
        Namespaced_IRI.parse _namespace_name "satisfiedBy" |> NamespacedName

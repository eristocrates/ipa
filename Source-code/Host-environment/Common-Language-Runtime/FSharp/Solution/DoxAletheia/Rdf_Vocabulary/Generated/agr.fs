namespace http.promsns.org.def.agr.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module agr =
    let _namespace_iri = Namespace_Iri agr |> NamespaceIRI
    /// <summary>
    ///   <para>agr:Agreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A description of a set of required actions by particular agents. All the required actions are detailed in Requirements class objects that this is a Collection of so the Agreement is just a container"</para>
    /// labels<para>"Agreement"</para></remarks>
    /// <seealso href="http://promsns.org/def/agr#Agreement">http://promsns.org/def/agr#Agreement</seealso>
    let Agreement = Prefixed_Name(agr, "Agreement") |> PrefixedName
    /// <summary>
    ///   <para>agr:MAY</para>
    /// </summary>
    /// <remarks>
    ///   <para>agr:RequirementLevel</para>
    ///
    /// labels<para>"MAY"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://promsns.org/def/agr#MAY">http://promsns.org/def/agr#MAY</seealso>
    let MAY = Prefixed_Name(agr, "MAY") |> PrefixedName
    /// <summary>
    ///   <para>agr:MUST</para>
    /// </summary>
    /// <remarks>
    ///   <para>agr:RequirementLevel</para>
    ///
    /// labels<para>"MUST"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://promsns.org/def/agr#MUST">http://promsns.org/def/agr#MUST</seealso>
    let MUST = Prefixed_Name(agr, "MUST") |> PrefixedName
    /// <summary>
    ///   <para>agr:MUST_NOT</para>
    /// </summary>
    /// <remarks>
    ///   <para>agr:RequirementLevel</para>
    ///
    /// labels<para>"MUST NOT"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://promsns.org/def/agr#MUST_NOT">http://promsns.org/def/agr#MUST_NOT</seealso>
    let MUST_NOT = Prefixed_Name(agr, "MUST_NOT") |> PrefixedName
    /// <summary>
    ///   <para>agr:OPTIONAL</para>
    /// </summary>
    /// <remarks>
    ///   <para>agr:RequirementLevel</para>
    ///
    /// labels<para>"OPTIONAL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://promsns.org/def/agr#OPTIONAL">http://promsns.org/def/agr#OPTIONAL</seealso>
    let OPTIONAL = Prefixed_Name(agr, "OPTIONAL") |> PrefixedName
    /// <summary>
    ///   <para>agr:RECOMMENDED</para>
    /// </summary>
    /// <remarks>
    ///   <para>agr:RequirementLevel</para>
    ///
    /// labels<para>"RECOMMENDED"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://promsns.org/def/agr#RECOMMENDED">http://promsns.org/def/agr#RECOMMENDED</seealso>
    let RECOMMENDED = Prefixed_Name(agr, "RECOMMENDED") |> PrefixedName
    /// <summary>
    ///   <para>agr:REQUIRED</para>
    /// </summary>
    /// <remarks>
    ///   <para>agr:RequirementLevel</para>
    ///
    /// labels<para>"REQUIRED"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://promsns.org/def/agr#REQUIRED">http://promsns.org/def/agr#REQUIRED</seealso>
    let REQUIRED = Prefixed_Name(agr, "REQUIRED") |> PrefixedName
    /// <summary>
    ///   <para>agr:Requirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class is analagous to the Creative Commons ontology formerly available. According to CC, a Requirement is "an action that may or may not be requested of you". In this ontology, it is only "an action that may be requested of you""</para>
    /// labels<para>"Requirement"</para></remarks>
    /// <seealso href="http://promsns.org/def/agr#Requirement">http://promsns.org/def/agr#Requirement</seealso>
    let Requirement = Prefixed_Name(agr, "Requirement") |> PrefixedName
    /// <summary>
    ///   <para>agr:RequirementLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An RequirementLevel is the level at which an Agreement complels the Agents it affects to action. The initial instances of Imperative are taken from RFC2119."</para>
    /// labels<para>"Requirement Level"</para></remarks>
    /// <seealso href="http://promsns.org/def/agr#RequirementLevel">http://promsns.org/def/agr#RequirementLevel</seealso>
    let RequirementLevel = Prefixed_Name(agr, "RequirementLevel") |> PrefixedName

    /// <summary>
    ///   <para>agr:RequirementResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An action that resolves requirements"</para>
    /// labels<para>"Requirement Resolution"</para></remarks>
    /// <seealso href="http://promsns.org/def/agr#RequirementResolution">http://promsns.org/def/agr#RequirementResolution</seealso>
    let RequirementResolution =
        Prefixed_Name(agr, "RequirementResolution") |> PrefixedName

    /// <summary>
    ///   <para>agr:SHALL</para>
    /// </summary>
    /// <remarks>
    ///   <para>agr:RequirementLevel</para>
    ///
    /// labels<para>"SHALL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://promsns.org/def/agr#SHALL">http://promsns.org/def/agr#SHALL</seealso>
    let SHALL = Prefixed_Name(agr, "SHALL") |> PrefixedName
    /// <summary>
    ///   <para>agr:SHALL_NOT</para>
    /// </summary>
    /// <remarks>
    ///   <para>agr:RequirementLevel</para>
    ///
    /// labels<para>"SHALL NOT"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://promsns.org/def/agr#SHALL_NOT">http://promsns.org/def/agr#SHALL_NOT</seealso>
    let SHALL_NOT = Prefixed_Name(agr, "SHALL_NOT") |> PrefixedName
    /// <summary>
    ///   <para>agr:SHOULD</para>
    /// </summary>
    /// <remarks>
    ///   <para>agr:RequirementLevel</para>
    ///
    /// labels<para>"SHOULD"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://promsns.org/def/agr#SHOULD">http://promsns.org/def/agr#SHOULD</seealso>
    let SHOULD = Prefixed_Name(agr, "SHOULD") |> PrefixedName
    /// <summary>
    ///   <para>agr:SHOULD_NOT</para>
    /// </summary>
    /// <remarks>
    ///   <para>agr:RequirementLevel</para>
    ///
    /// labels<para>"SHOULD NOT"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://promsns.org/def/agr#SHOULD_NOT">http://promsns.org/def/agr#SHOULD_NOT</seealso>
    let SHOULD_NOT = Prefixed_Name(agr, "SHOULD_NOT") |> PrefixedName
    /// <summary>
    ///   <para>agr:hasScope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is the union (group) of all Agents indicated as being within the scope of an Agreement by the hasWithinScope property."</para>
    /// labels<para>"has scope"</para></remarks>
    /// <seealso href="http://promsns.org/def/agr#hasScope">http://promsns.org/def/agr#hasScope</seealso>
    let hasScope = Prefixed_Name(agr, "hasScope") |> PrefixedName
    /// <summary>
    ///   <para>agr:hasWithinScope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property indicates an Agent affected by an Agreement. It is likely that the Agent will be a group (foaf:Group) or an Organization (org:Organisation) rather than an individual person and certainly not a machine Agent. Individual Agents indicated as being affected by an Agreement via this property collectively make a group, formal or informal, that can be indicated as being the entire scope group of an Agreement via hasScopeOf property of it."</para>
    /// labels<para>"has within scope"</para></remarks>
    /// <seealso href="http://promsns.org/def/agr#hasWithinScope">http://promsns.org/def/agr#hasWithinScope</seealso>
    let hasWithinScope = Prefixed_Name(agr, "hasWithinScope") |> PrefixedName
    /// <summary>
    ///   <para>agr:requirementLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"a Requirement has a requirementLevel of a RequirementLevel"</para>
    /// labels<para>"requirement level"</para></remarks>
    /// <seealso href="http://promsns.org/def/agr#requirementLevel">http://promsns.org/def/agr#requirementLevel</seealso>
    let requirementLevel = Prefixed_Name(agr, "requirementLevel") |> PrefixedName
    /// <summary>
    ///   <para>agr:requirementOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>"A Requirement is a requirementOf an Agreement"</para>
    /// labels<para>"requirement of"</para></remarks>
    /// <seealso href="http://promsns.org/def/agr#requirementOf">http://promsns.org/def/agr#requirementOf</seealso>
    let requirementOf = Prefixed_Name(agr, "requirementOf") |> PrefixedName
    /// <summary>
    ///   <para>agr:requires</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An Agreement requires a Requirement"</para>
    /// labels<para>"requires"</para></remarks>
    /// <seealso href="http://promsns.org/def/agr#requires">http://promsns.org/def/agr#requires</seealso>
    let requires = Prefixed_Name(agr, "requires") |> PrefixedName
    /// <summary>
    ///   <para>agr:satisfiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>"inverse of satisfies"</para>
    /// labels<para>"satisfied by"</para></remarks>
    /// <seealso href="http://promsns.org/def/agr#satisfiedBy">http://promsns.org/def/agr#satisfiedBy</seealso>
    let satisfiedBy = Prefixed_Name(agr, "satisfiedBy") |> PrefixedName
    /// <summary>
    ///   <para>agr:satisfies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"a Requirement Resolution satisfies a Requirement"</para>
    /// labels<para>"satisfies"</para></remarks>
    /// <seealso href="http://promsns.org/def/agr#satisfies">http://promsns.org/def/agr#satisfies</seealso>
    let satisfies = Prefixed_Name(agr, "satisfies") |> PrefixedName
    /// <summary>
    ///   <para>agr:scopeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"inverse of hasScopeOf"</para>
    /// labels<para>"scope of"</para></remarks>
    /// <seealso href="http://promsns.org/def/agr#scopeOf">http://promsns.org/def/agr#scopeOf</seealso>
    let scopeOf = Prefixed_Name(agr, "scopeOf") |> PrefixedName
    /// <summary>
    ///   <para>agr:withinScopeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"inverse of hasWithinScope"</para>
    /// labels<para>"within scope"</para></remarks>
    /// <seealso href="http://promsns.org/def/agr#withinScopeOf">http://promsns.org/def/agr#withinScopeOf</seealso>
    let withinScopeOf = Prefixed_Name(agr, "withinScopeOf") |> PrefixedName

namespace http.purl.org.wai.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module wai =
    let _namespace_iri = Namespace_Iri wai |> NamespaceIRI
    /// <summary>
    ///   <para>wai:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/wai#">http://purl.org/wai#</seealso>
    let _prefix_iri = Prefixed_Name(wai, "") |> PrefixedName
    /// <summary>
    ///   <para>wai:Context</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Contexts are similar to situations or state of affairs providing interpretation coordinates for profiles. In the most simple case, these coordinates are just geographical/spatial or temporal coordinates. WAI does not impose a fixed definition of context. It is deliberately wide in order to enable third-parties the adequation of the meaning of context according to their modeling needs and requirements."</para>
    /// labels<para>"Context"</para></remarks>
    /// <seealso href="http://purl.org/wai#Context">http://purl.org/wai#Context</seealso>
    let Context = Prefixed_Name(wai, "Context") |> PrefixedName
    /// <summary>
    ///   <para>wai:Profile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A profile represents a particular person playing a given role. In the literature it is also known as a "qua-individual". WAI extends the meaning of profile to capture "person-as-role", "person-at-context" and "person-in-community"."</para>
    /// labels<para>"Profile"</para></remarks>
    /// <seealso href="http://purl.org/wai#Profile">http://purl.org/wai#Profile</seealso>
    let Profile = Prefixed_Name(wai, "Profile") |> PrefixedName
    /// <summary>
    ///   <para>wai:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A property that can be predicated of a person. In WAI ontology, roles are reified as first order individuals and relations between roles and players are expressed by means of the wai:plays property. WAI does not impose any subclassification of roles. The concept is open to be refined according to domain or application requirements."</para>
    /// labels<para>"Role"</para></remarks>
    /// <seealso href="http://purl.org/wai#Role">http://purl.org/wai#Role</seealso>
    let Role = Prefixed_Name(wai, "Role") |> PrefixedName
    /// <summary>
    ///   <para>wai:atContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property enables to relate a profile with a given context (geographical, temporal, spatial, social, etc.)."</para>
    /// labels<para>"at context"</para></remarks>
    /// <seealso href="http://purl.org/wai#atContext">http://purl.org/wai#atContext</seealso>
    let atContext = Prefixed_Name(wai, "atContext") |> PrefixedName
    /// <summary>
    ///   <para>wai:isActive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property allows to specify which is the user profile that is active,
    /// given a interaction between two applications."</para>
    /// labels<para>"is active"</para></remarks>
    /// <seealso href="http://purl.org/wai#isActive">http://purl.org/wai#isActive</seealso>
    let isActive = Prefixed_Name(wai, "isActive") |> PrefixedName
    /// <summary>
    ///   <para>wai:participates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property encodes the participation relation between profiles and the communities they are member of."</para>
    /// labels<para>"participates"</para></remarks>
    /// <seealso href="http://purl.org/wai#participates">http://purl.org/wai#participates</seealso>
    let participates = Prefixed_Name(wai, "participates") |> PrefixedName
    /// <summary>
    ///   <para>wai:personalizes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A role is personalized by means of a profile, which wrap the role in the identity of the person behind the profile."</para>
    /// labels<para>"personalizes"</para></remarks>
    /// <seealso href="http://purl.org/wai#personalizes">http://purl.org/wai#personalizes</seealso>
    let personalizes = Prefixed_Name(wai, "personalizes") |> PrefixedName
    /// <summary>
    ///   <para>wai:plays</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates roles and their players, who can be any foaf:Agent (a person, a group, etc.)"</para>
    /// labels<para>"plays"</para></remarks>
    /// <seealso href="http://purl.org/wai#plays">http://purl.org/wai#plays</seealso>
    let plays = Prefixed_Name(wai, "plays") |> PrefixedName
    /// <summary>
    ///   <para>wai:profiles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates people and the featured profiles."</para>
    /// labels<para>"profiles"</para></remarks>
    /// <seealso href="http://purl.org/wai#profiles">http://purl.org/wai#profiles</seealso>
    let profiles = Prefixed_Name(wai, "profiles") |> PrefixedName
    /// <summary>
    ///   <para>wai:requires</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates roles and their requisites, i.e. other roles."</para>
    /// labels<para>"requires"</para></remarks>
    /// <seealso href="http://purl.org/wai#requires">http://purl.org/wai#requires</seealso>
    let requires = Prefixed_Name(wai, "requires") |> PrefixedName
    /// <summary>
    ///   <para>wai:specializes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property allows to express hierarchies of roles, through of role specialization: if role A specializes role B, and B specializes C, then role A specializes role C."</para>
    /// labels<para>"specializes"</para></remarks>
    /// <seealso href="http://purl.org/wai#specializes">http://purl.org/wai#specializes</seealso>
    let specializes = Prefixed_Name(wai, "specializes") |> PrefixedName

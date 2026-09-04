#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module wai =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/wai#" "wai"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Context</para>
    ///   <para>rdfs:comment : Contexts are similar to situations or state of affairs providing interpretation coordinates for profiles. In the most simple case, these coordinates are just geographical/spatial or temporal coordinates. WAI does not impose a fixed definition of context. It is deliberately wide in order to enable third-parties the adequation of the meaning of context according to their modeling needs and requirements.</para>
    ///   <a href="http://purl.org/wai#Context">wai:Context</a>
    /// </summary>
    let Context = _prefixId.prefix "Context"
    /// <summary>
    ///   <para>rdfs:label : Profile</para>
    ///   <para>rdfs:comment : A profile represents a particular person playing a given role. In the literature it is also known as a "qua-individual". WAI extends the meaning of profile to capture "person-as-role", "person-at-context" and "person-in-community".</para>
    ///   <a href="http://purl.org/wai#Profile">wai:Profile</a>
    /// </summary>
    let Profile = _prefixId.prefix "Profile"
    /// <summary>
    ///   <para>rdfs:label : Role</para>
    ///   <para>rdfs:comment : A property that can be predicated of a person. In WAI ontology, roles are reified as first order individuals and relations between roles and players are expressed by means of the wai:plays property. WAI does not impose any subclassification of roles. The concept is open to be refined according to domain or application requirements.</para>
    ///   <a href="http://purl.org/wai#Role">wai:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>rdfs:label : at context</para>
    ///   <para>rdfs:comment : This property enables to relate a profile with a given context (geographical, temporal, spatial, social, etc.).</para>
    ///   <a href="http://purl.org/wai#atContext">wai:atContext</a>
    /// </summary>
    let atContext = _prefixId.prefix "atContext"
    /// <summary>
    ///   <para>rdfs:label : is active</para>
    ///   <para>rdfs:comment : This property allows to specify which is the user profile that is active,
    /// given a interaction between two applications.</para>
    ///   <a href="http://purl.org/wai#isActive">wai:isActive</a>
    /// </summary>
    let isActive = _prefixId.prefix "isActive"
    /// <summary>
    ///   <para>rdfs:label : participates</para>
    ///   <para>rdfs:comment : This property encodes the participation relation between profiles and the communities they are member of.</para>
    ///   <a href="http://purl.org/wai#participates">wai:participates</a>
    /// </summary>
    let participates = _prefixId.prefix "participates"
    /// <summary>
    ///   <para>rdfs:label : personalizes</para>
    ///   <para>rdfs:comment : A role is personalized by means of a profile, which wrap the role in the identity of the person behind the profile.</para>
    ///   <a href="http://purl.org/wai#personalizes">wai:personalizes</a>
    /// </summary>
    let personalizes = _prefixId.prefix "personalizes"
    /// <summary>
    ///   <para>rdfs:label : plays</para>
    ///   <para>rdfs:comment : This property relates roles and their players, who can be any foaf:Agent (a person, a group, etc.)</para>
    ///   <a href="http://purl.org/wai#plays">wai:plays</a>
    /// </summary>
    let plays = _prefixId.prefix "plays"
    /// <summary>
    ///   <para>rdfs:label : profiles</para>
    ///   <para>rdfs:comment : This property relates people and the featured profiles.</para>
    ///   <a href="http://purl.org/wai#profiles">wai:profiles</a>
    /// </summary>
    let profiles = _prefixId.prefix "profiles"
    /// <summary>
    ///   <para>rdfs:label : requires</para>
    ///   <para>rdfs:comment : This property relates roles and their requisites, i.e. other roles.</para>
    ///   <a href="http://purl.org/wai#requires">wai:requires</a>
    /// </summary>
    let requires = _prefixId.prefix "requires"
    /// <summary>
    ///   <para>rdfs:label : specializes</para>
    ///   <para>rdfs:comment : This property allows to express hierarchies of roles, through of role specialization: if role A specializes role B, and B specializes C, then role A specializes role C.</para>
    ///   <a href="http://purl.org/wai#specializes">wai:specializes</a>
    /// </summary>
    let specializes = _prefixId.prefix "specializes"

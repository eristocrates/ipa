#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module prof =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/dx/prof/" "prof"
    let ``_1.0`` = _prefixId.prefix "1.0"
    /// <summary>
    ///   <para>skos:definition : A named set of constraints on one or more identified base specifications or other profiles, including the identification of any implementing subclasses of datatypes, semantic interpretations, vocabularies, options and parameters of those base specifications necessary to accomplish a particular function.
    ///
    /// This definition includes what are often called "application profiles", "metadata application profiles", or "metadata profiles".</para>
    ///   <para>rdfs:label : Profile^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/dx/prof/Profile">prof:Profile</a>
    /// </summary>
    let Profile = _prefixId.prefix "Profile"
    /// <summary>
    ///   <para>skos:usageNote : Can be use to indicate the formalism (via dct:format) and any adherence to a dct:Standard (via dct:conformsTo) to allow for machine mediation as well as its purpose via relation to a ResourceRole (via hasRole)</para>
    ///   <para>skos:definition : A resource that defines an aspect - a particular part or feature - of a Profile</para>
    ///   <para>rdfs:label : Resource Descriptor</para>
    ///   <a href="http://www.w3.org/ns/dx/prof/ResourceDescriptor">prof:ResourceDescriptor</a>
    /// </summary>
    let ResourceDescriptor = _prefixId.prefix "ResourceDescriptor"
    /// <summary>
    ///   <para>skos:usageNote : Specific terms must come from a vocabulary</para>
    ///   <para>skos:definition : The role that an Resource plays</para>
    ///   <para>rdfs:label : Resource Role^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/dx/prof/ResourceRole">prof:ResourceRole</a>
    /// </summary>
    let ResourceRole = _prefixId.prefix "ResourceRole"
    /// <summary>
    ///   <para>skos:usageNote : </para>
    ///   <para>rdfs:label : has artifact^^xsd:string</para>
    ///   <para>skos:definition : The URL of a downloadable file with particulars such as its format and role indicated by a Resource Descriptor</para>
    ///   <a href="http://www.w3.org/ns/dx/prof/hasArtifact">prof:hasArtifact</a>
    /// </summary>
    let hasArtifact = _prefixId.prefix "hasArtifact"
    /// <summary>
    ///   <para>skos:usageNote : This property is analogous to dcat:distribution however the domain is not necessarily dcat:Dataset. dcat:Dataset and prof:Profile are not disjoint, so it is up to implementations to decide if these are equivalent properties</para>
    ///   <para>rdfs:label : has resource</para>
    ///   <para>skos:definition : A resource which describes the nature of an artifact and the role it plays in relation to a profile</para>
    ///   <a href="http://www.w3.org/ns/dx/prof/hasResource">prof:hasResource</a>
    /// </summary>
    let hasResource = _prefixId.prefix "hasResource"
    /// <summary>
    ///   <para>rdfs:label : has role^^xsd:string</para>
    ///   <para>skos:definition : The function of the described artifactresource in the expression of the Profile, such as a specification, guidance documentation, SHACL file etc.</para>
    ///   <para>skos:usageNote : A set of common roles are defined by the Profiles Vocabulary. These are not exhaustive or disjoint, and may be extended for situations where finer grained description of purpose is necessary. A resource may perform multiple roles</para>
    ///   <a href="http://www.w3.org/ns/dx/prof/hasRole">prof:hasRole</a>
    /// </summary>
    let hasRole = _prefixId.prefix "hasRole"
    /// <summary>
    ///   <para>rdfs:label : has token^^xsd:string</para>
    ///   <para>skos:usageNote : A simple lexical form of identifier that may be accepted in some circumstances, such as API arguments to reference this profile. This is a â€œpreferred termâ€, since alternative identifiers may be declared and used by any implementation</para>
    ///   <para>skos:definition : A preferred alternative identifier for the Profile</para>
    ///   <a href="http://www.w3.org/ns/dx/prof/hasToken">prof:hasToken</a>
    /// </summary>
    let hasToken = _prefixId.prefix "hasToken"
    /// <summary>
    ///   <para>rdfs:label : is inherited from^^xsd:string</para>
    ///   <para>skos:usageNote : This property is created for the convenience of clients. When profile describers wish to allow clients to discover all resources relevant to a Profile without having to navigating an inheritance hierarchy of prof:profileOf relations, this predicate may be used to directly associate inherited Profile Descriptors with the Profile. If this property is present, it should be used consistently and all relevant resources a client may need to utilise the profile should be present and described using this predicate</para>
    ///   <para>skos:definition : This property indicates a Resource Descriptor described by this Profileâ€™s base specification that is to be considered a Resource Descriptor for this Profile also</para>
    ///   <a href="http://www.w3.org/ns/dx/prof/isInheritedFrom">prof:isInheritedFrom</a>
    /// </summary>
    let isInheritedFrom = _prefixId.prefix "isInheritedFrom"
    /// <summary>
    ///   <para>rdfs:label : is profile of^^xsd:string</para>
    ///   <para>skos:definition : A Profile is a profile of a dct:Standard (or a Base Specification or another Profile)</para>
    ///   <para>skos:usageNote : A Profile may define constraints on the usage of one or more specifications. All constraints of these specifications are inherited, in the sense that an object conforming to a profile conforms to all the constraints specified the targets of prof:isProfileOf relations. This property is optional, allowing any specification to be declared at the root of a profile hierarchy using the Profile class</para>
    ///   <a href="http://www.w3.org/ns/dx/prof/isProfileOf">prof:isProfileOf</a>
    /// </summary>
    let isProfileOf = _prefixId.prefix "isProfileOf"
    /// <summary>
    ///   <para>skos:usageNote : This is a convenience predicate that may be used to declare all specifications (including profiles) that the subject profile requires an information resource to conform to. This avoids forcing clients to traverse a profile hierarchy to find all conformance implications and available resources. If present all such relationships should be present so a client can safely avoid hierarchy traversal</para>
    ///   <para>rdfs:label : is transitive profile of^^xsd:string</para>
    ///   <para>skos:definition : A base specification an Profile conforms to</para>
    ///   <a href="http://www.w3.org/ns/dx/prof/isTransitiveProfileOf">prof:isTransitiveProfileOf</a>
    /// </summary>
    let isTransitiveProfileOf = _prefixId.prefix "isTransitiveProfileOf"

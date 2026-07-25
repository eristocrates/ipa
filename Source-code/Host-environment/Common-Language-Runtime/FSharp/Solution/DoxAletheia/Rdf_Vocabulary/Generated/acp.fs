namespace http.www.w3.org.ns.solid.acp.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module acp =
    let _namespace_iri = Namespace_Iri acp |> NamespaceIRI
    /// <summary>
    ///   <para>acp:AccessControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>All Access Controls controlling member resources access via the acp:memberAccessControl property MUST be included in the set of Access Controls linked as acp:accessControl in the effective authorization graph of a resource.</para>
    /// labels<para>Access Control</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/acp#AccessControl">http://www.w3.org/ns/solid/acp#AccessControl</seealso>
    let AccessControl = Prefixed_Name(acp, "AccessControl") |> PrefixedName
    /// <summary>
    ///   <para>acp:AuthenticatedAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Authenticated Agent</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/acp#AuthenticatedAgent">http://www.w3.org/ns/solid/acp#AuthenticatedAgent</seealso>
    let AuthenticatedAgent = Prefixed_Name(acp, "AuthenticatedAgent") |> PrefixedName
    /// <summary>
    ///   <para>acp:CreatorAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Creator Agent</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/acp#CreatorAgent">http://www.w3.org/ns/solid/acp#CreatorAgent</seealso>
    let CreatorAgent = Prefixed_Name(acp, "CreatorAgent") |> PrefixedName
    /// <summary>
    ///   <para>acp:Matcher</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Matcher MUST be satisfied if and only if: it defines at least one attribute; and, at least one value of each defined attribute matches the Context. ACP engines MUST match the context attributes defined by this specification according to IRI equality and literal term equality.
    ///
    /// ACP implementations supporting sub-properties of acp:attribute other than the ones defined by ACP SHOULD also define and implement corresponding matching algorithms.</para>
    /// labels<para>Matcher</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/acp#Matcher">http://www.w3.org/ns/solid/acp#Matcher</seealso>
    let Matcher = Prefixed_Name(acp, "Matcher") |> PrefixedName
    /// <summary>
    ///   <para>acp:AccessMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Access Mode</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/acp#AccessMode">http://www.w3.org/ns/solid/acp#AccessMode</seealso>
    let AccessMode = Prefixed_Name(acp, "AccessMode") |> PrefixedName
    /// <summary>
    ///   <para>acp:memberAccessControl</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>member access control</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/acp#memberAccessControl">http://www.w3.org/ns/solid/acp#memberAccessControl</seealso>
    let memberAccessControl = Prefixed_Name(acp, "memberAccessControl") |> PrefixedName
    /// <summary>
    ///   <para>acp:owner</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>owner</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/acp#owner">http://www.w3.org/ns/solid/acp#owner</seealso>
    let owner = Prefixed_Name(acp, "owner") |> PrefixedName
    /// <summary>
    ///   <para>acp:accessControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>access control</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/acp#accessControl">http://www.w3.org/ns/solid/acp#accessControl</seealso>
    let accessControl = Prefixed_Name(acp, "accessControl") |> PrefixedName
    /// <summary>
    ///   <para>acp:allOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>all of</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/acp#allOf">http://www.w3.org/ns/solid/acp#allOf</seealso>
    let allOf = Prefixed_Name(acp, "allOf") |> PrefixedName
    /// <summary>
    ///   <para>acp:anyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>any of</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/acp#anyOf">http://www.w3.org/ns/solid/acp#anyOf</seealso>
    let anyOf = Prefixed_Name(acp, "anyOf") |> PrefixedName
    /// <summary>
    ///   <para>acp:client</para>
    /// </summary>
    /// <remarks>
    ///   <para>In a Matcher, client attributes define a set of clients, at least one of which MUST match the Context for the Matcher to be satisfied. </para>
    /// labels<para>client</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/acp#client">http://www.w3.org/ns/solid/acp#client</seealso>
    let client = Prefixed_Name(acp, "client") |> PrefixedName
    /// <summary>
    ///   <para>acp:attribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Sub-properties of acp:attribute can be created to fit the specific access control requirements of applications.</para>
    /// labels<para>attribute</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/acp#attribute">http://www.w3.org/ns/solid/acp#attribute</seealso>
    let attribute = Prefixed_Name(acp, "attribute") |> PrefixedName
    /// <summary>
    ///   <para>acp:apply</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>apply</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/acp#apply">http://www.w3.org/ns/solid/acp#apply</seealso>
    let apply = Prefixed_Name(acp, "apply") |> PrefixedName
    /// <summary>
    ///   <para>acp:creator</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>creator</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/acp#creator">http://www.w3.org/ns/solid/acp#creator</seealso>
    let creator = Prefixed_Name(acp, "creator") |> PrefixedName
    /// <summary>
    ///   <para>acp:grant</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>grant</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/acp#grant">http://www.w3.org/ns/solid/acp#grant</seealso>
    let grant = Prefixed_Name(acp, "grant") |> PrefixedName
    /// <summary>
    ///   <para>acp:mode</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>mode</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/acp#mode">http://www.w3.org/ns/solid/acp#mode</seealso>
    let mode = Prefixed_Name(acp, "mode") |> PrefixedName
    /// <summary>
    ///   <para>acp:deny</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>deny</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/acp#deny">http://www.w3.org/ns/solid/acp#deny</seealso>
    let deny = Prefixed_Name(acp, "deny") |> PrefixedName
    /// <summary>
    ///   <para>acp:issuer</para>
    /// </summary>
    /// <remarks>
    ///   <para>In a Matcher, issuer attributes define a set of issuers, at least one of which MUST match the Context for the Matcher to be satisfied.</para>
    /// labels<para>issuer</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/acp#issuer">http://www.w3.org/ns/solid/acp#issuer</seealso>
    let issuer = Prefixed_Name(acp, "issuer") |> PrefixedName
    /// <summary>
    ///   <para>acp:noneOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>none of</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/acp#noneOf">http://www.w3.org/ns/solid/acp#noneOf</seealso>
    let noneOf = Prefixed_Name(acp, "noneOf") |> PrefixedName
    /// <summary>
    ///   <para>acp:target</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>target</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/acp#target">http://www.w3.org/ns/solid/acp#target</seealso>
    let target = Prefixed_Name(acp, "target") |> PrefixedName
    /// <summary>
    ///   <para>acp:vc</para>
    /// </summary>
    /// <remarks>
    ///   <para>In a Matcher, vc attributes define a set of types of Verifiable Credentials (VC), at least one of which MUST match the Context for the Matcher to be satisfied. A VC type present in the Context MUST be a valid VC presented as part of the resource access request.</para>
    /// labels<para>vc</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/acp#vc">http://www.w3.org/ns/solid/acp#vc</seealso>
    let vc = Prefixed_Name(acp, "vc") |> PrefixedName
    /// <summary>
    ///   <para>acp:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>Access Control Policy Language (ACP)</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/acp#">http://www.w3.org/ns/solid/acp#</seealso>
    let _prefix_iri = Prefixed_Name(acp, "") |> PrefixedName

    /// <summary>
    ///   <para>acp:AccessControlResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Both the acp:resource property and its inverse acp:accessControlResource MUST be taken into account in determining the Access Control Resources controlling access to resources.</para>
    /// labels<para>Access Control Resource</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/acp#AccessControlResource">http://www.w3.org/ns/solid/acp#AccessControlResource</seealso>
    let AccessControlResource =
        Prefixed_Name(acp, "AccessControlResource") |> PrefixedName

    /// <summary>
    ///   <para>acp:AccessGrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Access Grant</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/acp#AccessGrant">http://www.w3.org/ns/solid/acp#AccessGrant</seealso>
    let AccessGrant = Prefixed_Name(acp, "AccessGrant") |> PrefixedName

    /// <summary>
    ///   <para>acp:AlwaysSatisfiedRestriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Always Satisfied Restriction</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/acp#AlwaysSatisfiedRestriction">http://www.w3.org/ns/solid/acp#AlwaysSatisfiedRestriction</seealso>
    let AlwaysSatisfiedRestriction =
        Prefixed_Name(acp, "AlwaysSatisfiedRestriction") |> PrefixedName

    /// <summary>
    ///   <para>acp:Context</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Context</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/acp#Context">http://www.w3.org/ns/solid/acp#Context</seealso>
    let Context = Prefixed_Name(acp, "Context") |> PrefixedName
    /// <summary>
    ///   <para>acp:OwnerAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Owner Agent</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/acp#OwnerAgent">http://www.w3.org/ns/solid/acp#OwnerAgent</seealso>
    let OwnerAgent = Prefixed_Name(acp, "OwnerAgent") |> PrefixedName
    /// <summary>
    ///   <para>acp:Policy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An ACP engine MUST grant exactly those Access Modes allowed by Effective Policies. Effective Policies are the Policies controlling access to a resource. A Policy MUST control access to a resource if: it is applied by an Access Control of an ACR of the resource; or, it is applied by a member Access Control of an ACR of an ancestor of the resource.
    ///
    /// An Access Mode MUST be granted if and only if in the set of Effective Policies controlling access to it: a satisfied policy allows the Access Mode; and, no satisfied policy denies it.
    ///
    /// A Policy MUST be satisfied if and only if: it references at least one Matcher via an acp:allOf or acp:anyOf property; and, all of its acp:allOf Matchers are satisfied; and, at least one of its acp:anyOf Matchers is satisfied; and, none of its acp:noneOf Matchers are satisfied.</para>
    /// labels<para>Access Policy</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/acp#Policy">http://www.w3.org/ns/solid/acp#Policy</seealso>
    let Policy = Prefixed_Name(acp, "Policy") |> PrefixedName
    /// <summary>
    ///   <para>acp:PublicAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>acp:AlwaysSatisfiedRestriction</para>
    ///
    /// labels<para>Public Agent</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/acp#PublicAgent">http://www.w3.org/ns/solid/acp#PublicAgent</seealso>
    let PublicAgent = Prefixed_Name(acp, "PublicAgent") |> PrefixedName
    /// <summary>
    ///   <para>acp:PublicClient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>acp:AlwaysSatisfiedRestriction</para>
    ///
    /// labels<para>Public Client</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/acp#PublicClient">http://www.w3.org/ns/solid/acp#PublicClient</seealso>
    let PublicClient = Prefixed_Name(acp, "PublicClient") |> PrefixedName
    /// <summary>
    ///   <para>acp:PublicIssuer</para>
    /// </summary>
    /// <remarks>
    ///   <para>acp:AlwaysSatisfiedRestriction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Public Issuer</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/acp#PublicIssuer">http://www.w3.org/ns/solid/acp#PublicIssuer</seealso>
    let PublicIssuer = Prefixed_Name(acp, "PublicIssuer") |> PrefixedName

    /// <summary>
    ///   <para>acp:accessControlResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>access control resource</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/acp#accessControlResource">http://www.w3.org/ns/solid/acp#accessControlResource</seealso>
    let accessControlResource =
        Prefixed_Name(acp, "accessControlResource") |> PrefixedName

    /// <summary>
    ///   <para>acp:resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>resource</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/acp#resource">http://www.w3.org/ns/solid/acp#resource</seealso>
    let resource = Prefixed_Name(acp, "resource") |> PrefixedName
    /// <summary>
    ///   <para>acp:agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>In a Matcher, agent attributes define a set of agents, at least one of which MUST match the Context for the Matcher to be satisfied.</para>
    /// labels<para>agent</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/acp#agent">http://www.w3.org/ns/solid/acp#agent</seealso>
    let agent = Prefixed_Name(acp, "agent") |> PrefixedName
    /// <summary>
    ///   <para>acp:allow</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>allow</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/acp#allow">http://www.w3.org/ns/solid/acp#allow</seealso>
    let allow = Prefixed_Name(acp, "allow") |> PrefixedName
    /// <summary>
    ///   <para>acp:context</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>context</para></remarks>
    /// <seealso href="http://www.w3.org/ns/solid/acp#context">http://www.w3.org/ns/solid/acp#context</seealso>
    let context = Prefixed_Name(acp, "context") |> PrefixedName

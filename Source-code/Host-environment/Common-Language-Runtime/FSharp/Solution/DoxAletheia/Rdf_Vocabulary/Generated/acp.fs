namespace http.www.w3.org.ns.solid.acp.hash

open DoxAletheia.Rdf_Vocabulary

module acp =
    let _namespace_name = "http://www.w3.org/ns/solid/acp#"

    /// <summary>
    /// All Access Controls controlling member resources access via the acp:memberAccessControl property MUST be included in the set of Access Controls linked as acp:accessControl in the effective authorization graph of a resource.
    /// <see href="http://www.w3.org/ns/solid/acp#AccessControl"></see></summary>
    let AccessControl =
        Namespaced_IRI.parse _namespace_name "AccessControl" |> NamespacedName

    /// <summary>
    /// Both the acp:resource property and its inverse acp:accessControlResource MUST be taken into account in determining the Access Control Resources controlling access to resources.
    /// <see href="http://www.w3.org/ns/solid/acp#AccessControlResource"></see></summary>
    let AccessControlResource =
        Namespaced_IRI.parse _namespace_name "AccessControlResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#AccessGrant"></see>
    /// </summary>
    let AccessGrant =
        Namespaced_IRI.parse _namespace_name "AccessGrant" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#AccessMode"></see>
    /// </summary>
    let AccessMode = Namespaced_IRI.parse _namespace_name "AccessMode" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#AlwaysSatisfiedRestriction"></see>
    /// </summary>
    let AlwaysSatisfiedRestriction =
        Namespaced_IRI.parse _namespace_name "AlwaysSatisfiedRestriction" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#AuthenticatedAgent"></see>
    /// </summary>
    let AuthenticatedAgent =
        Namespaced_IRI.parse _namespace_name "AuthenticatedAgent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#Context"></see>
    /// </summary>
    let Context = Namespaced_IRI.parse _namespace_name "Context" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#CreatorAgent"></see>
    /// </summary>
    let CreatorAgent =
        Namespaced_IRI.parse _namespace_name "CreatorAgent" |> NamespacedName

    /// <summary>
    /// A Matcher MUST be satisfied if and only if: it defines at least one attribute; and, at least one value of each defined attribute matches the Context. ACP engines MUST match the context attributes defined by this specification according to IRI equality and literal term equality.
    ///
    /// ACP implementations supporting sub-properties of acp:attribute other than the ones defined by ACP SHOULD also define and implement corresponding matching algorithms.
    /// <see href="http://www.w3.org/ns/solid/acp#Matcher"></see></summary>
    let Matcher = Namespaced_IRI.parse _namespace_name "Matcher" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#OwnerAgent"></see>
    /// </summary>
    let OwnerAgent = Namespaced_IRI.parse _namespace_name "OwnerAgent" |> NamespacedName
    /// <summary>
    /// An ACP engine MUST grant exactly those Access Modes allowed by Effective Policies. Effective Policies are the Policies controlling access to a resource. A Policy MUST control access to a resource if: it is applied by an Access Control of an ACR of the resource; or, it is applied by a member Access Control of an ACR of an ancestor of the resource.
    ///
    /// An Access Mode MUST be granted if and only if in the set of Effective Policies controlling access to it: a satisfied policy allows the Access Mode; and, no satisfied policy denies it.
    ///
    /// A Policy MUST be satisfied if and only if: it references at least one Matcher via an acp:allOf or acp:anyOf property; and, all of its acp:allOf Matchers are satisfied; and, at least one of its acp:anyOf Matchers is satisfied; and, none of its acp:noneOf Matchers are satisfied.
    /// <see href="http://www.w3.org/ns/solid/acp#Policy"></see></summary>
    let Policy = Namespaced_IRI.parse _namespace_name "Policy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#PublicAgent"></see>
    /// </summary>
    let PublicAgent =
        Namespaced_IRI.parse _namespace_name "PublicAgent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#PublicClient"></see>
    /// </summary>
    let PublicClient =
        Namespaced_IRI.parse _namespace_name "PublicClient" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#PublicIssuer"></see>
    /// </summary>
    let PublicIssuer =
        Namespaced_IRI.parse _namespace_name "PublicIssuer" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#accessControl"></see>
    /// </summary>
    let accessControl =
        Namespaced_IRI.parse _namespace_name "accessControl" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#accessControlResource"></see>
    /// </summary>
    let accessControlResource =
        Namespaced_IRI.parse _namespace_name "accessControlResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#resource"></see>
    /// </summary>
    let resource = Namespaced_IRI.parse _namespace_name "resource" |> NamespacedName
    /// <summary>
    /// In a Matcher, agent attributes define a set of agents, at least one of which MUST match the Context for the Matcher to be satisfied.
    /// <see href="http://www.w3.org/ns/solid/acp#agent"></see></summary>
    let agent = Namespaced_IRI.parse _namespace_name "agent" |> NamespacedName
    /// <summary>
    /// Sub-properties of acp:attribute can be created to fit the specific access control requirements of applications.
    /// <see href="http://www.w3.org/ns/solid/acp#attribute"></see></summary>
    let attribute = Namespaced_IRI.parse _namespace_name "attribute" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#allOf"></see>
    /// </summary>
    let allOf = Namespaced_IRI.parse _namespace_name "allOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#allow"></see>
    /// </summary>
    let allow = Namespaced_IRI.parse _namespace_name "allow" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#anyOf"></see>
    /// </summary>
    let anyOf = Namespaced_IRI.parse _namespace_name "anyOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#apply"></see>
    /// </summary>
    let apply = Namespaced_IRI.parse _namespace_name "apply" |> NamespacedName
    /// <summary>
    /// In a Matcher, client attributes define a set of clients, at least one of which MUST match the Context for the Matcher to be satisfied.
    /// <see href="http://www.w3.org/ns/solid/acp#client"></see></summary>
    let client = Namespaced_IRI.parse _namespace_name "client" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#context"></see>
    /// </summary>
    let context = Namespaced_IRI.parse _namespace_name "context" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#creator"></see>
    /// </summary>
    let creator = Namespaced_IRI.parse _namespace_name "creator" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#deny"></see>
    /// </summary>
    let deny = Namespaced_IRI.parse _namespace_name "deny" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#grant"></see>
    /// </summary>
    let grant = Namespaced_IRI.parse _namespace_name "grant" |> NamespacedName
    /// <summary>
    /// In a Matcher, issuer attributes define a set of issuers, at least one of which MUST match the Context for the Matcher to be satisfied.
    /// <see href="http://www.w3.org/ns/solid/acp#issuer"></see></summary>
    let issuer = Namespaced_IRI.parse _namespace_name "issuer" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#memberAccessControl"></see>
    /// </summary>
    let memberAccessControl =
        Namespaced_IRI.parse _namespace_name "memberAccessControl" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#mode"></see>
    /// </summary>
    let mode = Namespaced_IRI.parse _namespace_name "mode" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#noneOf"></see>
    /// </summary>
    let noneOf = Namespaced_IRI.parse _namespace_name "noneOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#owner"></see>
    /// </summary>
    let owner = Namespaced_IRI.parse _namespace_name "owner" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#target"></see>
    /// </summary>
    let target = Namespaced_IRI.parse _namespace_name "target" |> NamespacedName
    /// <summary>
    /// In a Matcher, vc attributes define a set of types of Verifiable Credentials (VC), at least one of which MUST match the Context for the Matcher to be satisfied. A VC type present in the Context MUST be a valid VC presented as part of the resource access request.
    /// <see href="http://www.w3.org/ns/solid/acp#vc"></see></summary>
    let vc = Namespaced_IRI.parse _namespace_name "vc" |> NamespacedName

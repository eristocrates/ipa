namespace http.www.w3.org.ns.solid.acp.hash

open DoxAletheia

module acp =
    let _namespace_name = "http://www.w3.org/ns/solid/acp#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// All Access Controls controlling member resources access via the acp:memberAccessControl property MUST be included in the set of Access Controls linked as acp:accessControl in the effective authorization graph of a resource.
    /// <see href="http://www.w3.org/ns/solid/acp#AccessControl"></see></summary>
    let AccessControl = _prefix "AccessControl"
    /// <summary>
    /// Both the acp:resource property and its inverse acp:accessControlResource MUST be taken into account in determining the Access Control Resources controlling access to resources.
    /// <see href="http://www.w3.org/ns/solid/acp#AccessControlResource"></see></summary>
    let AccessControlResource = _prefix "AccessControlResource"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#AccessGrant"></see>
    /// </summary>
    let AccessGrant = _prefix "AccessGrant"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#AccessMode"></see>
    /// </summary>
    let AccessMode = _prefix "AccessMode"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#AlwaysSatisfiedRestriction"></see>
    /// </summary>
    let AlwaysSatisfiedRestriction = _prefix "AlwaysSatisfiedRestriction"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#AuthenticatedAgent"></see>
    /// </summary>
    let AuthenticatedAgent = _prefix "AuthenticatedAgent"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#Context"></see>
    /// </summary>
    let Context = _prefix "Context"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#CreatorAgent"></see>
    /// </summary>
    let CreatorAgent = _prefix "CreatorAgent"
    /// <summary>
    /// A Matcher MUST be satisfied if and only if: it defines at least one attribute; and, at least one value of each defined attribute matches the Context. ACP engines MUST match the context attributes defined by this specification according to IRI equality and literal term equality.
    ///
    /// ACP implementations supporting sub-properties of acp:attribute other than the ones defined by ACP SHOULD also define and implement corresponding matching algorithms.
    /// <see href="http://www.w3.org/ns/solid/acp#Matcher"></see></summary>
    let Matcher = _prefix "Matcher"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#OwnerAgent"></see>
    /// </summary>
    let OwnerAgent = _prefix "OwnerAgent"
    /// <summary>
    /// An ACP engine MUST grant exactly those Access Modes allowed by Effective Policies. Effective Policies are the Policies controlling access to a resource. A Policy MUST control access to a resource if: it is applied by an Access Control of an ACR of the resource; or, it is applied by a member Access Control of an ACR of an ancestor of the resource.
    ///
    /// An Access Mode MUST be granted if and only if in the set of Effective Policies controlling access to it: a satisfied policy allows the Access Mode; and, no satisfied policy denies it.
    ///
    /// A Policy MUST be satisfied if and only if: it references at least one Matcher via an acp:allOf or acp:anyOf property; and, all of its acp:allOf Matchers are satisfied; and, at least one of its acp:anyOf Matchers is satisfied; and, none of its acp:noneOf Matchers are satisfied.
    /// <see href="http://www.w3.org/ns/solid/acp#Policy"></see></summary>
    let Policy = _prefix "Policy"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#PublicAgent"></see>
    /// </summary>
    let PublicAgent = _prefix "PublicAgent"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#PublicClient"></see>
    /// </summary>
    let PublicClient = _prefix "PublicClient"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#PublicIssuer"></see>
    /// </summary>
    let PublicIssuer = _prefix "PublicIssuer"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#accessControl"></see>
    /// </summary>
    let accessControl = _prefix "accessControl"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#accessControlResource"></see>
    /// </summary>
    let accessControlResource = _prefix "accessControlResource"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#resource"></see>
    /// </summary>
    let resource = _prefix "resource"
    /// <summary>
    /// In a Matcher, agent attributes define a set of agents, at least one of which MUST match the Context for the Matcher to be satisfied.
    /// <see href="http://www.w3.org/ns/solid/acp#agent"></see></summary>
    let agent = _prefix "agent"
    /// <summary>
    /// Sub-properties of acp:attribute can be created to fit the specific access control requirements of applications.
    /// <see href="http://www.w3.org/ns/solid/acp#attribute"></see></summary>
    let attribute = _prefix "attribute"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#allOf"></see>
    /// </summary>
    let allOf = _prefix "allOf"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#allow"></see>
    /// </summary>
    let allow = _prefix "allow"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#anyOf"></see>
    /// </summary>
    let anyOf = _prefix "anyOf"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#apply"></see>
    /// </summary>
    let apply = _prefix "apply"
    /// <summary>
    /// In a Matcher, client attributes define a set of clients, at least one of which MUST match the Context for the Matcher to be satisfied.
    /// <see href="http://www.w3.org/ns/solid/acp#client"></see></summary>
    let client = _prefix "client"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#context"></see>
    /// </summary>
    let context = _prefix "context"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#creator"></see>
    /// </summary>
    let creator = _prefix "creator"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#deny"></see>
    /// </summary>
    let deny = _prefix "deny"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#grant"></see>
    /// </summary>
    let grant = _prefix "grant"
    /// <summary>
    /// In a Matcher, issuer attributes define a set of issuers, at least one of which MUST match the Context for the Matcher to be satisfied.
    /// <see href="http://www.w3.org/ns/solid/acp#issuer"></see></summary>
    let issuer = _prefix "issuer"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#memberAccessControl"></see>
    /// </summary>
    let memberAccessControl = _prefix "memberAccessControl"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#mode"></see>
    /// </summary>
    let mode = _prefix "mode"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#noneOf"></see>
    /// </summary>
    let noneOf = _prefix "noneOf"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#owner"></see>
    /// </summary>
    let owner = _prefix "owner"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/solid/acp#target"></see>
    /// </summary>
    let target = _prefix "target"
    /// <summary>
    /// In a Matcher, vc attributes define a set of types of Verifiable Credentials (VC), at least one of which MUST match the Context for the Matcher to be satisfied. A VC type present in the Context MUST be a valid VC presented as part of the resource access request.
    /// <see href="http://www.w3.org/ns/solid/acp#vc"></see></summary>
    let vc = _prefix "vc"

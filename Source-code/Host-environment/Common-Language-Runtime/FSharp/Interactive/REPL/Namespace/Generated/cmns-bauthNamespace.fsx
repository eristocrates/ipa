#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``cmns-bauth`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/BusinessAuthorizations/" "cmns-bauth"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : authorisationrdfs:label : authorization</para>
    ///   <para>skos:definition : situation in which a party authorizes someone to act on their behalf or to have specific capabilities under certain conditions for some period of time^^xsd:string</para>
    ///   <para>skos:prefLabel : authorization^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/BusinessAuthorizations/Authorization">cmns-bauth:Authorization</a>
    /// </summary>
    let Authorization = _prefixId.prefix "Authorization"
    /// <summary>
    ///   <para>rdfs:label : authorised partyrdfs:label : authorized party</para>
    ///   <para>skos:definition : party that has been given the ability to act on behalf of another party or to have specified capabilities under some set of guidelines for some period of time^^xsd:string</para>
    ///   <para>skos:prefLabel : authorized party^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/BusinessAuthorizations/AuthorizedParty">cmns-bauth:AuthorizedParty</a>
    /// </summary>
    let AuthorizedParty = _prefixId.prefix "AuthorizedParty"
    /// <summary>
    ///   <para>rdfs:label : authorising partyrdfs:label : authorizing party</para>
    ///   <para>skos:definition : party that delegates some role, authority, or control to another party^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/BusinessAuthorizations/AuthorizingParty">cmns-bauth:AuthorizingParty</a>
    /// </summary>
    let AuthorizingParty = _prefixId.prefix "AuthorizingParty"
    /// <summary>
    ///   <para>rdfs:label : legally delegated authority^^xsd:string</para>
    ///   <para>skos:definition : authorized party empowered with some level of legal control and corresponding responsibility^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/BusinessAuthorizations/LegallyDelegatedAuthority">cmns-bauth:LegallyDelegatedAuthority</a>
    /// </summary>
    let LegallyDelegatedAuthority = _prefixId.prefix "LegallyDelegatedAuthority"
    /// <summary>
    ///   <para>rdfs:label : responsible party^^xsd:string</para>
    ///   <para>skos:definition : legal person acting in a role that has some formal responsibility^^xsd:string</para>
    ///   <para>skos:example : party with a fiduciary responsibility such as a signatory, an examiner, registrar, obligor, payee, etc.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/BusinessAuthorizations/ResponsibleParty">cmns-bauth:ResponsibleParty</a>
    /// </summary>
    let ResponsibleParty = _prefixId.prefix "ResponsibleParty"
    /// <summary>
    ///   <para>rdfs:label : authorizes^^xsd:string</para>
    ///   <para>skos:definition : endorses, enables, empowers, or gives permission to^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/BusinessAuthorizations/authorizes">cmns-bauth:authorizes</a>
    /// </summary>
    let authorizes = _prefixId.prefix "authorizes"
    /// <summary>
    ///   <para>rdfs:label : authorizes directly^^xsd:string</para>
    ///   <para>skos:definition : endorses, enables, empowers, or gives permission directly to^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/BusinessAuthorizations/authorizesDirectly">cmns-bauth:authorizesDirectly</a>
    /// </summary>
    let authorizesDirectly = _prefixId.prefix "authorizesDirectly"
    /// <summary>
    ///   <para>rdfs:label : authorizes through^^xsd:string</para>
    ///   <para>skos:definition : indicates the situation that facilitates designation of an authorized party by the authorizing party for some purpose^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/BusinessAuthorizations/authorizesThrough">cmns-bauth:authorizesThrough</a>
    /// </summary>
    let authorizesThrough = _prefixId.prefix "authorizesThrough"
    /// <summary>
    ///   <para>rdfs:label : delegates control to^^xsd:string</para>
    ///   <para>skos:definition : indicates a party to which the authorizing party has delegated some authority or control^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/BusinessAuthorizations/delegatesControlTo">cmns-bauth:delegatesControlTo</a>
    /// </summary>
    let delegatesControlTo = _prefixId.prefix "delegatesControlTo"
    /// <summary>
    ///   <para>rdfs:label : has authorization^^xsd:string</para>
    ///   <para>skos:definition : relates something to a specific authorization that is applicable to it in some context^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/BusinessAuthorizations/hasAuthorization">cmns-bauth:hasAuthorization</a>
    /// </summary>
    let hasAuthorization = _prefixId.prefix "hasAuthorization"
    /// <summary>
    ///   <para>rdfs:label : has authorized party^^xsd:string</para>
    ///   <para>skos:definition : indicates the party (role) that is endorsed, enabled, empowered, or otherwise permitted to do something in the situation^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/BusinessAuthorizations/hasAuthorizedParty">cmns-bauth:hasAuthorizedParty</a>
    /// </summary>
    let hasAuthorizedParty = _prefixId.prefix "hasAuthorizedParty"
    /// <summary>
    ///   <para>rdfs:label : has authorizee^^xsd:string</para>
    ///   <para>skos:definition : indicates the legal person that is endorsed, enabled, empowered, or otherwise permitted to do something in the situation^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/BusinessAuthorizations/hasAuthorizee">cmns-bauth:hasAuthorizee</a>
    /// </summary>
    let hasAuthorizee = _prefixId.prefix "hasAuthorizee"
    /// <summary>
    ///   <para>rdfs:label : has authorizing party^^xsd:string</para>
    ///   <para>skos:definition : indicates the party (role) that endorses, enables, empowers, or gives permission in the situation^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/BusinessAuthorizations/hasAuthorizingParty">cmns-bauth:hasAuthorizingParty</a>
    /// </summary>
    let hasAuthorizingParty = _prefixId.prefix "hasAuthorizingParty"
    /// <summary>
    ///   <para>rdfs:label : has authorizor^^xsd:string</para>
    ///   <para>skos:definition : indicates the legal person that endorses, enables, empowers, or gives permission in the situation^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/BusinessAuthorizations/hasAuthorizor">cmns-bauth:hasAuthorizor</a>
    /// </summary>
    let hasAuthorizor = _prefixId.prefix "hasAuthorizor"
    /// <summary>
    ///   <para>rdfs:label : has delegated control of^^xsd:string</para>
    ///   <para>skos:definition : indicates something or some party that is controlled via delegation^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/BusinessAuthorizations/hasDelegatedControlOf">cmns-bauth:hasDelegatedControlOf</a>
    /// </summary>
    let hasDelegatedControlOf = _prefixId.prefix "hasDelegatedControlOf"
    /// <summary>
    ///   <para>rdfs:label : has responsible party^^xsd:string</para>
    ///   <para>skos:definition : identifies a party that has some assignment, commitment or obligation with respect to some situation or organization^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/BusinessAuthorizations/hasResponsibleParty">cmns-bauth:hasResponsibleParty</a>
    /// </summary>
    let hasResponsibleParty = _prefixId.prefix "hasResponsibleParty"
    /// <summary>
    ///   <para>rdfs:label : is authorized by^^xsd:string</para>
    ///   <para>skos:definition : is endorsed, enabled, empowered, or otherwise permitted by^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/BusinessAuthorizations/isAuthorizedBy">cmns-bauth:isAuthorizedBy</a>
    /// </summary>
    let isAuthorizedBy = _prefixId.prefix "isAuthorizedBy"
    /// <summary>
    ///   <para>rdfs:label : is authorized through^^xsd:string</para>
    ///   <para>skos:definition : indicates the situation that facilitates endorsement of the authorized party for some purpose^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/BusinessAuthorizations/isAuthorizedThrough">cmns-bauth:isAuthorizedThrough</a>
    /// </summary>
    let isAuthorizedThrough = _prefixId.prefix "isAuthorizedThrough"
    /// <summary>
    ///   <para>rdfs:label : is authorizee in^^xsd:string</para>
    ///   <para>skos:definition : indicates the situation that facilitates designation of the legal person as an authorized party for some purpose^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/BusinessAuthorizations/isAuthorizeeIn">cmns-bauth:isAuthorizeeIn</a>
    /// </summary>
    let isAuthorizeeIn = _prefixId.prefix "isAuthorizeeIn"
    /// <summary>
    ///   <para>rdfs:label : is authorizor in^^xsd:string</para>
    ///   <para>skos:definition : indicates the situation that facilitates designation of an authorized party by the legal person for some purpose^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/BusinessAuthorizations/isAuthorizorIn">cmns-bauth:isAuthorizorIn</a>
    /// </summary>
    let isAuthorizorIn = _prefixId.prefix "isAuthorizorIn"
    /// <summary>
    ///   <para>rdfs:label : is directly authorized by^^xsd:string</para>
    ///   <para>skos:definition : is directly endorsed, enabled, empowered, or otherwise permitted by^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/BusinessAuthorizations/isDirectlyAuthorizedBy">cmns-bauth:isDirectlyAuthorizedBy</a>
    /// </summary>
    let isDirectlyAuthorizedBy = _prefixId.prefix "isDirectlyAuthorizedBy"

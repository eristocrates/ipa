#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module omnfed =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://open-multinet.info/ontology/omn-federation#" "omnfed"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Federation</para>
    ///   <a href="http://open-multinet.info/ontology/omn-federation#Federation">omnfed:Federation</a>
    /// </summary>
    let Federation = _prefixId.prefix "Federation"
    /// <summary>
    ///   <para>rdfs:label : member of a federation</para>
    ///   <a href="http://open-multinet.info/ontology/omn-federation#FederationMember">omnfed:FederationMember</a>
    /// </summary>
    let FederationMember = _prefixId.prefix "FederationMember"
    /// <summary>
    ///   <para>rdfs:label : Infrastructure</para>
    ///   <para>rdfs:comment : an infrastructure such as a testbed or cloud facilityrdfs:comment : Example: FUESCO Playground</para>
    ///   <a href="http://open-multinet.info/ontology/omn-federation#Infrastructure">omnfed:Infrastructure</a>
    /// </summary>
    let Infrastructure = _prefixId.prefix "Infrastructure"
    /// <summary>
    ///   <para>rdfs:label : administers</para>
    ///   <para>rdfs:comment : an organization (e.g. a federation member) administers its own infrastructure</para>
    ///   <a href="http://open-multinet.info/ontology/omn-federation#administers">omnfed:administers</a>
    /// </summary>
    let administers = _prefixId.prefix "administers"
    /// <summary>
    ///   <para>rdfs:label : has federation member</para>
    ///   <para>rdfs:comment : a federation can have an organization as a member</para>
    ///   <a href="http://open-multinet.info/ontology/omn-federation#hasFederationMember">omnfed:hasFederationMember</a>
    /// </summary>
    let hasFederationMember = _prefixId.prefix "hasFederationMember"
    /// <summary>
    ///   <para>rdfs:label : is administered by</para>
    ///   <para>rdfs:comment : an infrastructure can be administered by an organization (e.g. a federation member)</para>
    ///   <a href="http://open-multinet.info/ontology/omn-federation#isAdministeredBy">omnfed:isAdministeredBy</a>
    /// </summary>
    let isAdministeredBy = _prefixId.prefix "isAdministeredBy"
    /// <summary>
    ///   <para>rdfs:label : is part of federation</para>
    ///   <para>rdfs:comment : an organization can be part of a federation</para>
    ///   <a href="http://open-multinet.info/ontology/omn-federation#partOfFederation">omnfed:partOfFederation</a>
    /// </summary>
    let partOfFederation = _prefixId.prefix "partOfFederation"

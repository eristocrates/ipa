#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module snarm =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://rdf.myexperiment.org/ontologies/snarm/" "snarm"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Access^^xsd:string</para>
    ///   <para>rdfs:comment : The Unrestricted Access to an AccessType^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/snarm/Access">snarm:Access</a>
    /// </summary>
    let Access = _prefixId.prefix "Access"
    /// <summary>
    ///   <para>rdfs:label : AccessType^^xsd:string</para>
    ///   <para>rdfs:comment : The AccessType that is being giving, e.g. view, edit, download, etc.^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/snarm/AccessType">snarm:AccessType</a>
    /// </summary>
    let AccessType = _prefixId.prefix "AccessType"
    /// <summary>
    ///   <para>rdfs:label : Accesser^^xsd:string</para>
    ///   <para>rdfs:comment : The Accesser that is getting access^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/snarm/Accesser">snarm:Accesser</a>
    /// </summary>
    let Accesser = _prefixId.prefix "Accesser"
    /// <summary>
    ///   <para>rdfs:label : Policy^^xsd:string</para>
    ///   <para>rdfs:comment : A Policy for the access rights to an object for users in the social network^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/snarm/Policy">snarm:Policy</a>
    /// </summary>
    let Policy = _prefixId.prefix "Policy"
    /// <summary>
    ///   <para>rdfs:label : RestrictedAccess^^xsd:string</para>
    ///   <para>rdfs:comment : The restricted Access to an AccessType^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/snarm/RestrictedAccess">snarm:RestrictedAccess</a>
    /// </summary>
    let RestrictedAccess = _prefixId.prefix "RestrictedAccess"
    /// <summary>
    ///   <para>rdfs:label : has-access^^xsd:string</para>
    ///   <para>rdfs:comment : An Access that a Policy provides^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/snarm/has-access">snarm:has-access</a>
    /// </summary>
    let has_access = _prefixId.prefix "has-access"
    /// <summary>
    ///   <para>rdfs:label : has-access-type^^xsd:string</para>
    ///   <para>rdfs:comment : The AccessType an Access provides^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/snarm/has-access-type">snarm:has-access-type</a>
    /// </summary>
    let has_access_type = _prefixId.prefix "has-access-type"
    /// <summary>
    ///   <para>rdfs:label : has-accesser^^xsd:string</para>
    ///   <para>rdfs:comment : An Accesser that a Mode provides access to^^xsd:string</para>
    ///   <a href="http://rdf.myexperiment.org/ontologies/snarm/has-accesser">snarm:has-accesser</a>
    /// </summary>
    let has_accesser = _prefixId.prefix "has-accesser"

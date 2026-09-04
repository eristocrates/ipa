#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module odapp =
    let _prefixId = PrefixId.fromNamespaceLabel "http://vocab.deri.ie/odapp#" "odapp"
    /// <summary>
    ///   <para>rdfs:label : application type^^xsd:string</para>
    ///   <para>rdfs:comment : describes the type of the application (e.g. mobile app, desktop app, etc...)^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/odapp#AppType">odapp:AppType</a>
    /// </summary>
    let AppType = _prefixId.prefix "AppType"
    let ``DERI%2C%20NUI%20Galway`` = _prefixId.prefix "DERI%2C%20NUI%20Galway"
    /// <summary>
    ///   <para>rdfs:label : free application^^xsd:string</para>
    ///   <para>rdfs:comment : a free application^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/odapp#FreeApp">odapp:FreeApp</a>
    /// </summary>
    let FreeApp = _prefixId.prefix "FreeApp"
    /// <summary>
    ///   <para>rdfs:label : paid application^^xsd:string</para>
    ///   <para>rdfs:comment : a paid application^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/odapp#PaidApp">odapp:PaidApp</a>
    /// </summary>
    let PaidApp = _prefixId.prefix "PaidApp"
    /// <summary>
    ///   <para>rdfs:label : application price^^xsd:string</para>
    ///   <para>rdfs:comment : An application price^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/odapp#Price">odapp:Price</a>
    /// </summary>
    let Price = _prefixId.prefix "Price"
    /// <summary>
    ///   <para>rdfs:label : application type^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/odapp#appType">odapp:appType</a>
    /// </summary>
    let appType = _prefixId.prefix "appType"
    let deilee = _prefixId.prefix "deilee"
    let fadmaa = _prefixId.prefix "fadmaa"
    let gofshu = _prefixId.prefix "gofshu"
    let niklou = _prefixId.prefix "niklou"
    /// <summary>
    ///   <para>rdfs:label : application price^^xsd:string</para>
    ///   <para>rdfs:comment : relationship between the admssw:SoftwareRelease and odap:Price^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/odapp#price">odapp:price</a>
    /// </summary>
    let price = _prefixId.prefix "price"
    let rdf = _prefixId.prefix "rdf"
    let ttl = _prefixId.prefix "ttl"
    /// <summary>
    ///   <para>rdfs:label : uses dataset^^xsd:string</para>
    ///   <para>rdfs:comment : describes a dataset that is used by the application^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/odapp#uses">odapp:uses</a>
    /// </summary>
    let uses = _prefixId.prefix "uses"

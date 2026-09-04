#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module c4n =
    let _prefixId = PrefixId.fromNamespaceLabel "http://vocab.deri.ie/c4n#" "c4n"
    /// <summary>
    ///   <para>rdfs:label : a call^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/c4n#Call">c4n:Call</a>
    /// </summary>
    let Call = _prefixId.prefix "Call"
    /// <summary>
    ///   <para>rdfs:label : a condition^^xsd:string</para>
    ///   <para>rdfs:comment : a condition under which the call event has to be understood^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/c4n#Condition">c4n:Condition</a>
    /// </summary>
    let Condition = _prefixId.prefix "Condition"
    /// <summary>
    ///   <para>rdfs:label : a deadline^^xsd:string</para>
    ///   <para>rdfs:comment : a temporal condition that must be met to comply the call^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/c4n#Deadline">c4n:Deadline</a>
    /// </summary>
    let Deadline = _prefixId.prefix "Deadline"
    /// <summary>
    ///   <para>rdfs:label : an event^^xsd:string</para>
    ///   <para>rdfs:comment : an event a call refers to^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/c4n#Event">c4n:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>rdfs:label : the issuer of the call^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/c4n#Issuer">c4n:Issuer</a>
    /// </summary>
    let Issuer = _prefixId.prefix "Issuer"
    let LiDRC = _prefixId.prefix "LiDRC"
    let ``Michael%20Hausenblas`` = _prefixId.prefix "Michael%20Hausenblas"
    /// <summary>
    ///   <para>rdfs:label : a spatial scope^^xsd:string</para>
    ///   <para>rdfs:comment : a geographic condition that must be met to comply the call^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/c4n#SpatialScope">c4n:SpatialScope</a>
    /// </summary>
    let SpatialScope = _prefixId.prefix "SpatialScope"
    /// <summary>
    ///   <para>rdfs:label : must meet condition^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/c4n#condition">c4n:condition</a>
    /// </summary>
    let condition = _prefixId.prefix "condition"
    /// <summary>
    ///   <para>rdfs:label : for^^xsd:string</para>
    ///   <para>rdfs:comment : restricts the call to a certain event^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/c4n#for">c4n:for</a>
    /// </summary>
    let for_ = _prefixId.prefix "for"
    /// <summary>
    ///   <para>rdfs:label : issues^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/c4n#issues">c4n:issues</a>
    /// </summary>
    let issues = _prefixId.prefix "issues"
    let rdf = _prefixId.prefix "rdf"
    let ttl = _prefixId.prefix "ttl"

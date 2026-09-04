#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module service =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/ontology/service#" "service"

    /// <summary>
    ///   <para>rdfs:label : Service</para>
    ///   <a href="http://purl.org/ontology/service#Service">service:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    /// <summary>
    ///   <para>rdfs:label : ServiceConsumer</para>
    ///   <a href="http://purl.org/ontology/service#ServiceConsumer">service:ServiceConsumer</a>
    /// </summary>
    let ServiceConsumer = _prefixId.prefix "ServiceConsumer"
    /// <summary>
    ///   <para>rdfs:label : ServiceLimitation</para>
    ///   <a href="http://purl.org/ontology/service#ServiceLimitation">service:ServiceLimitation</a>
    /// </summary>
    let ServiceLimitation = _prefixId.prefix "ServiceLimitation"
    /// <summary>
    ///   <para>rdfs:label : ServiceProvider</para>
    ///   <a href="http://purl.org/ontology/service#ServiceProvider">service:ServiceProvider</a>
    /// </summary>
    let ServiceProvider = _prefixId.prefix "ServiceProvider"
    /// <summary>
    ///   <para>rdfs:label : consumedBy</para>
    ///   <a href="http://purl.org/ontology/service#consumedBy">service:consumedBy</a>
    /// </summary>
    let consumedBy = _prefixId.prefix "consumedBy"
    /// <summary>
    ///   <para>rdfs:label : consumes</para>
    ///   <a href="http://purl.org/ontology/service#consumes">service:consumes</a>
    /// </summary>
    let consumes = _prefixId.prefix "consumes"
    /// <summary>
    ///   <para>rdfs:label : delay</para>
    ///   <a href="http://purl.org/ontology/service#delay">service:delay</a>
    /// </summary>
    let delay = _prefixId.prefix "delay"
    /// <summary>
    ///   <para>rdfs:label : limitedBy</para>
    ///   <a href="http://purl.org/ontology/service#limitedBy">service:limitedBy</a>
    /// </summary>
    let limitedBy = _prefixId.prefix "limitedBy"
    /// <summary>
    ///   <para>rdfs:label : limits</para>
    ///   <a href="http://purl.org/ontology/service#limits">service:limits</a>
    /// </summary>
    let limits = _prefixId.prefix "limits"
    /// <summary>
    ///   <para>rdfs:label : providedBy</para>
    ///   <a href="http://purl.org/ontology/service#providedBy">service:providedBy</a>
    /// </summary>
    let providedBy = _prefixId.prefix "providedBy"
    /// <summary>
    ///   <para>rdfs:label : provides</para>
    ///   <a href="http://purl.org/ontology/service#provides">service:provides</a>
    /// </summary>
    let provides = _prefixId.prefix "provides"
    /// <summary>
    ///   <para>rdfs:label : queue</para>
    ///   <a href="http://purl.org/ontology/service#queue">service:queue</a>
    /// </summary>
    let queue = _prefixId.prefix "queue"

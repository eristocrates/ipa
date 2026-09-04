#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module wo =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/ontology/wo/core#" "wo"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Scale</para>
    ///   <para>rdfs:comment : A concept for describing scales for weights.</para>
    ///   <a href="http://purl.org/ontology/wo/core#Scale">wo:Scale</a>
    /// </summary>
    let Scale = _prefixId.prefix "Scale"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : Weight</para>
    ///   <para>rdfs:comment : A weight class to enable timestamped (etc.) weights.</para>
    ///   <a href="http://purl.org/ontology/wo/core#Weight">wo:Weight</a>
    /// </summary>
    let Weight = _prefixId.prefix "Weight"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:comment : A maximum weight of a scale.</para>
    ///   <para>rdfs:label : has max weight</para>
    ///   <a href="http://purl.org/ontology/wo/core#max_weight">wo:max_weight</a>
    /// </summary>
    let max_weight = _prefixId.prefix "max_weight"
    /// <summary>
    ///   <para>rdfs:comment : A minimum weight of a scale.</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : has min weight</para>
    ///   <a href="http://purl.org/ontology/wo/core#min_weight">wo:min_weight</a>
    /// </summary>
    let min_weight = _prefixId.prefix "min_weight"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : has scale</para>
    ///   <para>rdfs:comment : A scale for the weighting of some relation.</para>
    ///   <a href="http://purl.org/ontology/wo/core#scale">wo:scale</a>
    /// </summary>
    let scale = _prefixId.prefix "scale"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : has step size</para>
    ///   <para>rdfs:comment : A predefined step size for weight of a specific scale.</para>
    ///   <a href="http://purl.org/ontology/wo/core#step_size">wo:step_size</a>
    /// </summary>
    let step_size = _prefixId.prefix "step_size"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : has weight</para>
    ///   <para>rdfs:comment : The weight on some relation, e.g. a interest in a topic, or of an interest that is valid for a specific period of time or was raised up in a specific period of time.</para>
    ///   <a href="http://purl.org/ontology/wo/core#weight">wo:weight</a>
    /// </summary>
    let weight = _prefixId.prefix "weight"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has weight value</para>
    ///   <para>rdfs:comment : The specific value of a weight.</para>
    ///   <a href="http://purl.org/ontology/wo/core#weight_value">wo:weight_value</a>
    /// </summary>
    let weight_value = _prefixId.prefix "weight_value"

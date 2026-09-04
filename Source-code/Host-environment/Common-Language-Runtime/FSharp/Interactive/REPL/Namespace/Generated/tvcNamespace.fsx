#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module tvc =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.essepuntato.it/2012/04/tvc/" "tvc"

    /// <summary>
    ///   <para>dce:description : Having the role "graduate student" in a specific time (e.g., now) and context (e.g., "University of Bologna").</para>
    ///   <para>rdfs:label : value in time</para>
    ///   <para>rdfs:comment : It defines a particular kind of time-indexed situation that represents a hub linking the entity having a particular value, the value itself and the temporal and contextual extents from which the entity-value relationship depends.</para>
    ///   <a href="http://www.essepuntato.it/2012/04/tvc/ValueInTime">tvc:ValueInTime</a>
    /// </summary>
    let ValueInTime = _prefixId.prefix "ValueInTime"
    /// <summary>
    ///   <para>rdfs:comment : It specifies the particular temporal instant or time period in which the situation takes place.</para>
    ///   <para>rdfs:label : at time^^xsd:string</para>
    ///   <a href="http://www.essepuntato.it/2012/04/tvc/atTime">tvc:atTime</a>
    /// </summary>
    let atTime = _prefixId.prefix "atTime"
    /// <summary>
    ///   <para>rdfs:comment : It links an entity (e.g., a Person) to a particular ValueInTime situation;</para>
    ///   <para>rdfs:label : has value</para>
    ///   <a href="http://www.essepuntato.it/2012/04/tvc/hasValue">tvc:hasValue</a>
    /// </summary>
    let hasValue = _prefixId.prefix "hasValue"
    /// <summary>
    ///   <para>rdfs:comment : It holds the value had by the entity taking part to the situation.</para>
    ///   <para>rdfs:label : with value</para>
    ///   <a href="http://www.essepuntato.it/2012/04/tvc/withValue">tvc:withValue</a>
    /// </summary>
    let withValue = _prefixId.prefix "withValue"
    /// <summary>
    ///   <para>rdfs:comment : It links to the specific context within which the fact of the entity having the value is relevant.</para>
    ///   <para>rdfs:label : within context</para>
    ///   <a href="http://www.essepuntato.it/2012/04/tvc/withinContext">tvc:withinContext</a>
    /// </summary>
    let withinContext = _prefixId.prefix "withinContext"

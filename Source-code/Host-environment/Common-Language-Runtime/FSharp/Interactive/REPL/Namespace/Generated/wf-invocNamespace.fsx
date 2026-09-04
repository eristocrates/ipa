#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``wf-invoc`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/net/wf-invocation#" "wf-invoc"

    /// <summary>
    ///   <para>rdfs:comment : Specialization of p-plan:Step in order to be able to assert domain specific properties. A wf-invoc:Step refers to those p-plan:Steps related to the scientific workflow invocation.</para>
    ///   <para>rdfs:label : Step</para>
    ///   <a href="http://purl.org/net/wf-invocation#Step">wf-invoc:Step</a>
    /// </summary>
    let Step = _prefixId.prefix "Step"
    /// <summary>
    ///   <para>rdfs:comment : Specialization of p-plan:Variable in order to be able to assert specific properties. A wf-invoc:Variable refers to those p-plan:Variables related to the scientific workflow invocation.</para>
    ///   <para>rdfs:label : Variable</para>
    ///   <a href="http://purl.org/net/wf-invocation#Variable">wf-invoc:Variable</a>
    /// </summary>
    let Variable = _prefixId.prefix "Variable"
    let hasCodeBinding = _prefixId.prefix "hasCodeBinding"
    /// <summary>
    ///   <para>rdfs:comment : Data property used to link a wf-invoc:Step with any particular metadata that will be used in the execution of the Step (e.g., environment requirements, memory, etc.)</para>
    ///   <para>rdfs:label : has Custom Data</para>
    ///   <a href="http://purl.org/net/wf-invocation#hasCustomData">wf-invoc:hasCustomData</a>
    /// </summary>
    let hasCustomData = _prefixId.prefix "hasCustomData"
    /// <summary>
    ///   <para>rdfs:comment : Data property used to bind a wf-invoc:Variable with the path or URL where the data is available for the execution.</para>
    ///   <para>rdfs:label : has Data Binding</para>
    ///   <a href="http://purl.org/net/wf-invocation#hasDataBinding">wf-invoc:hasDataBinding</a>
    /// </summary>
    let hasDataBinding = _prefixId.prefix "hasDataBinding"
    /// <summary>
    ///   <para>rdfs:comment : Data property used to link a wf-invoc:Step with the Literal representing the invocation line of the current Step.</para>
    ///   <para>rdfs:label : has Invocation Line</para>
    ///   <a href="http://purl.org/net/wf-invocation#hasInvocationLine">wf-invoc:hasInvocationLine</a>
    /// </summary>
    let hasInvocationLine = _prefixId.prefix "hasInvocationLine"

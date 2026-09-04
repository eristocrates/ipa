#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module psh =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://ns.inria.fr/probabilistic-shacl/" "psh"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : The class of probabilistic validation summary</para>
    ///   <para>rdfs:label : Validation summary</para>
    ///   <a href="http://ns.inria.fr/probabilistic-shacl/ValidationSummary">psh:ValidationSummary</a>
    /// </summary>
    let ValidationSummary = _prefixId.prefix "ValidationSummary"
    /// <summary>
    ///   <para>rdfs:comment : The shape concerned by the results of the probabilistic validation</para>
    ///   <para>rdfs:label : focus shape</para>
    ///   <a href="http://ns.inria.fr/probabilistic-shacl/focusShape">psh:focusShape</a>
    /// </summary>
    let focusShape = _prefixId.prefix "focusShape"
    /// <summary>
    ///   <para>rdfs:comment : Specifies the representativeness of the current shape</para>
    ///   <para>rdfs:label : generality</para>
    ///   <a href="http://ns.inria.fr/probabilistic-shacl/generality">psh:generality</a>
    /// </summary>
    let generality = _prefixId.prefix "generality"
    /// <summary>
    ///   <para>rdfs:comment : Specifies the likelihood to observe the number of exceptions among the RDF triples tested (i.e. referenceCardinality)</para>
    ///   <para>rdfs:label : likelihood</para>
    ///   <a href="http://ns.inria.fr/probabilistic-shacl/likelihood">psh:likelihood</a>
    /// </summary>
    let likelihood = _prefixId.prefix "likelihood"
    /// <summary>
    ///   <para>rdfs:comment : Specifies the number of nodes that confirm the current shape</para>
    ///   <para>rdfs:label : number of confirmation</para>
    ///   <a href="http://ns.inria.fr/probabilistic-shacl/numConfirmation">psh:numConfirmation</a>
    /// </summary>
    let numConfirmation = _prefixId.prefix "numConfirmation"
    /// <summary>
    ///   <para>rdfs:comment : Specifies the number of nodes that contradict the current shape</para>
    ///   <para>rdfs:label : number of violation</para>
    ///   <a href="http://ns.inria.fr/probabilistic-shacl/numViolation">psh:numViolation</a>
    /// </summary>
    let numViolation = _prefixId.prefix "numViolation"
    /// <summary>
    ///   <para>rdfs:comment : Specifies the number of RDF triples tested during the validation of the current shape</para>
    ///   <para>rdfs:label : reference cardinality</para>
    ///   <a href="http://ns.inria.fr/probabilistic-shacl/referenceCardinality">psh:referenceCardinality</a>
    /// </summary>
    let referenceCardinality = _prefixId.prefix "referenceCardinality"
    /// <summary>
    ///   <para>rdfs:comment : The probabilistic validation results contained in a validation report.</para>
    ///   <para>rdfs:label : summary</para>
    ///   <a href="http://ns.inria.fr/probabilistic-shacl/summary">psh:summary</a>
    /// </summary>
    let summary = _prefixId.prefix "summary"

#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module munc =
    let _prefixId = PrefixId.fromNamespaceLabel "http://ns.inria.fr/munc#" "munc"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : The metadata associated to a Sentence in a certain World (Context).</para>
    ///   <para>rdfs:label : Meta</para>
    ///   <a href="http://ns.inria.fr/munc#Meta">munc:Meta</a>
    /// </summary>
    let Meta = _prefixId.prefix "Meta"
    /// <summary>
    ///   <para>rdfs:comment : The Sentence (Triple, Graph, Graph Pattern) to which Meta is associated in a specific World.</para>
    ///   <para>rdfs:label : Sentence</para>
    ///   <a href="http://ns.inria.fr/munc#Sentence">munc:Sentence</a>
    /// </summary>
    let Sentence = _prefixId.prefix "Sentence"
    /// <summary>
    ///   <para>rdfs:comment : Individuals of this class are LDScript functions enabling translating uncertainty information from one approach to another.</para>
    ///   <para>rdfs:label : Translation Function</para>
    ///   <a href="http://ns.inria.fr/munc#TranslationFunction">munc:TranslationFunction</a>
    /// </summary>
    let TranslationFunction = _prefixId.prefix "TranslationFunction"
    /// <summary>
    ///   <para>rdfs:comment : A subclass of Meta, it enables annotating the Sentence associated to the metadata with uncertainty information.</para>
    ///   <para>rdfs:label : Uncertainty</para>
    ///   <a href="http://ns.inria.fr/munc#Uncertainty">munc:Uncertainty</a>
    /// </summary>
    let Uncertainty = _prefixId.prefix "Uncertainty"
    /// <summary>
    ///   <para>rdfs:comment : Individuals of this class represent uncertainty approaches, which are detailed in the appendix A.</para>
    ///   <para>rdfs:label : Uncertainty Approach</para>
    ///   <a href="http://ns.inria.fr/munc#UncertaintyApproach">munc:UncertaintyApproach</a>
    /// </summary>
    let UncertaintyApproach = _prefixId.prefix "UncertaintyApproach"
    /// <summary>
    ///   <para>rdfs:comment : The Calculus to apply on the Values of a defined Uncertainty Feature.</para>
    ///   <para>rdfs:label : Uncertainty Operation</para>
    ///   <a href="http://ns.inria.fr/munc#UncertaintyOperation">munc:UncertaintyOperation</a>
    /// </summary>
    let UncertaintyOperation = _prefixId.prefix "UncertaintyOperation"
    /// <summary>
    ///   <para>rdfs:comment : For each Uncertainty Feature, exists (when declared) a corresponding value.</para>
    ///   <para>rdfs:label : Uncertainty Value</para>
    ///   <a href="http://ns.inria.fr/munc#UncertaintyValue">munc:UncertaintyValue</a>
    /// </summary>
    let UncertaintyValue = _prefixId.prefix "UncertaintyValue"
    /// <summary>
    ///   <para>rdfs:comment : The context (Graph, Default Graph, etc.) in which the Sentence is associated to Meta. This is used generally by datastores which are unable to represent named graphs.</para>
    ///   <para>rdfs:label : World</para>
    ///   <a href="http://ns.inria.fr/munc#World">munc:World</a>
    /// </summary>
    let World = _prefixId.prefix "World"
    let hasFullTranslation = _prefixId.prefix "hasFullTranslation"
    /// <summary>
    ///   <para>rdfs:label : hasIdealTranslation</para>
    ///   <a href="http://ns.inria.fr/munc#hasIdealTranslation">munc:hasIdealTranslation</a>
    /// </summary>
    let hasIdealTranslation = _prefixId.prefix "hasIdealTranslation"
    /// <summary>
    ///   <para>rdfs:label : hasMeta</para>
    ///   <a href="http://ns.inria.fr/munc#hasMeta">munc:hasMeta</a>
    /// </summary>
    let hasMeta = _prefixId.prefix "hasMeta"
    /// <summary>
    ///   <para>rdfs:label : hasTranslation</para>
    ///   <a href="http://ns.inria.fr/munc#hasTranslation">munc:hasTranslation</a>
    /// </summary>
    let hasTranslation = _prefixId.prefix "hasTranslation"
    /// <summary>
    ///   <para>rdfs:label : hasUncertaintyApproach</para>
    ///   <a href="http://ns.inria.fr/munc#hasUncertaintyApproach">munc:hasUncertaintyApproach</a>
    /// </summary>
    let hasUncertaintyApproach = _prefixId.prefix "hasUncertaintyApproach"
    /// <summary>
    ///   <para>rdfs:label : hasUncertaintyFeature</para>
    ///   <a href="http://ns.inria.fr/munc#hasUncertaintyFeature">munc:hasUncertaintyFeature</a>
    /// </summary>
    let hasUncertaintyFeature = _prefixId.prefix "hasUncertaintyFeature"
    /// <summary>
    ///   <para>rdfs:label : hasUncertaintyOperator</para>
    ///   <a href="http://ns.inria.fr/munc#hasUncertaintyOperator">munc:hasUncertaintyOperator</a>
    /// </summary>
    let hasUncertaintyOperator = _prefixId.prefix "hasUncertaintyOperator"
    /// <summary>
    ///   <para>rdfs:label : statedIn</para>
    ///   <a href="http://ns.inria.fr/munc#statedIn">munc:statedIn</a>
    /// </summary>
    let statedIn = _prefixId.prefix "statedIn"
    /// <summary>
    ///   <para>rdfs:label : translateFrom</para>
    ///   <a href="http://ns.inria.fr/munc#translateFrom">munc:translateFrom</a>
    /// </summary>
    let translateFrom = _prefixId.prefix "translateFrom"
    /// <summary>
    ///   <para>rdfs:label : translateFrom</para>
    ///   <a href="http://ns.inria.fr/munc#translateTo">munc:translateTo</a>
    /// </summary>
    let translateTo = _prefixId.prefix "translateTo"
    /// <summary>
    ///   <para>rdfs:comment : Each Uncertainty approach has some features, which can be metrics or measures to compare, infer or reason over to have a decision about knowledge.</para>
    ///   <para>rdfs:label : uncertaintyFeature</para>
    ///   <a href="http://ns.inria.fr/munc#uncertaintyFeature">munc:uncertaintyFeature</a>
    /// </summary>
    let uncertaintyFeature = _prefixId.prefix "uncertaintyFeature"
    /// <summary>
    ///   <para>rdfs:comment : Each Uncertainty approach has its own logic to reason over metadata, This class defines the methods that can be applied over Uncertainty Values. Such logic is the same used in reasoners and inference engines.</para>
    ///   <para>rdfs:label : uncertaintyOperator</para>
    ///   <a href="http://ns.inria.fr/munc#uncertaintyOperator">munc:uncertaintyOperator</a>
    /// </summary>
    let uncertaintyOperator = _prefixId.prefix "uncertaintyOperator"

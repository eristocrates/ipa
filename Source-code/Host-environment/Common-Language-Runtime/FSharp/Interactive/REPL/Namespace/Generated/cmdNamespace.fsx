#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cmd =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/cmd#" "cmd"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Analysis Element</para>
    ///   <para>rdfs:comment : Node of the tree structure to classify requirements.</para>
    ///   <a href="https://w3id.org/cmd#AnalysisElement">cmd:AnalysisElement</a>
    /// </summary>
    let AnalysisElement = _prefixId.prefix "AnalysisElement"
    /// <summary>
    ///   <para>rdfs:label : Implementation</para>
    ///   <para>rdfs:comment : An implementation describing a procedure and/or an executable document. Can either be expressed in a query language, or be refering to an executable file, or be precisly describing the procedure.</para>
    ///   <a href="https://w3id.org/cmd#Implementation">cmd:Implementation</a>
    /// </summary>
    let Implementation = _prefixId.prefix "Implementation"
    /// <summary>
    ///   <para>rdfs:label : Requirement</para>
    ///   <para>rdfs:comment : Node of the tree structure representing a given metric to evaluate a concrete element.</para>
    ///   <a href="https://w3id.org/cmd#Requirement">cmd:Requirement</a>
    /// </summary>
    let Requirement = _prefixId.prefix "Requirement"
    /// <summary>
    ///   <para>rdfs:label : TSoR: Tree-Structure of Requirements</para>
    ///   <para>rdfs:comment : Defines a compound measure with a set of requirements as well as a structuration of these requirements through the use of analysis elements.</para>
    ///   <a href="https://w3id.org/cmd#TSoR">cmd:TSoR</a>
    /// </summary>
    let TSoR = _prefixId.prefix "TSoR"
    /// <summary>
    ///   <para>rdfs:label : aggregation function</para>
    ///   <para>rdfs:comment : Definition of a function expressing how to compute a unique global score based on the result obtained on each requirements and their weight.</para>
    ///   <a href="https://w3id.org/cmd#aggregFunction">cmd:aggregFunction</a>
    /// </summary>
    let aggregFunction = _prefixId.prefix "aggregFunction"
    /// <summary>
    ///   <para>rdfs:label : expects</para>
    ///   <para>rdfs:comment : Associate a requirement with an analysis element: an analysis element expects a requirement.</para>
    ///   <a href="https://w3id.org/cmd#expects">cmd:expects</a>
    /// </summary>
    let expects = _prefixId.prefix "expects"
    /// <summary>
    ///   <para>rdfs:label : hasContent</para>
    ///   <para>rdfs:comment : A node of a TSoR has as content a given concept or metric.</para>
    ///   <a href="https://w3id.org/cmd#hasContent">cmd:hasContent</a>
    /// </summary>
    let hasContent = _prefixId.prefix "hasContent"
    /// <summary>
    ///   <para>rdfs:label : has root</para>
    ///   <para>rdfs:comment : The TSoR has a given root among the analysis element.</para>
    ///   <a href="https://w3id.org/cmd#hasRoot">cmd:hasRoot</a>
    /// </summary>
    let hasRoot = _prefixId.prefix "hasRoot"
    /// <summary>
    ///   <para>rdfs:label : is followed by</para>
    ///   <para>rdfs:comment : An implementation is followed by another implementation if the the second complement the first one.</para>
    ///   <a href="https://w3id.org/cmd#isFollowedBy">cmd:isFollowedBy</a>
    /// </summary>
    let isFollowedBy = _prefixId.prefix "isFollowedBy"
    /// <summary>
    ///   <para>rdfs:label : is implemented by</para>
    ///   <para>rdfs:comment : A requirement is implemented by an implementation.</para>
    ///   <a href="https://w3id.org/cmd#isImplementedBy">cmd:isImplementedBy</a>
    /// </summary>
    let isImplementedBy = _prefixId.prefix "isImplementedBy"
    /// <summary>
    ///   <para>rdfs:label : is specified by</para>
    ///   <para>rdfs:comment : Structures analysis elements through this relation. An analysis element is specified by one or more other analysis elements that detail the analysis.</para>
    ///   <a href="https://w3id.org/cmd#isSpecifiedBy">cmd:isSpecifiedBy</a>
    /// </summary>
    let isSpecifiedBy = _prefixId.prefix "isSpecifiedBy"
    /// <summary>
    ///   <para>rdfs:label : weight</para>
    ///   <para>rdfs:comment : Number representing the relative importance of one node (analysis element or requirement) of a TSoR compared to its siblings.</para>
    ///   <a href="https://w3id.org/cmd#weight">cmd:weight</a>
    /// </summary>
    let weight = _prefixId.prefix "weight"

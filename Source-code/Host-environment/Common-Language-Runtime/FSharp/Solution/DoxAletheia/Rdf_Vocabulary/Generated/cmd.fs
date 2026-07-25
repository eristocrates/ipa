namespace https.w3id.org.cmd.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cmd =
    let _namespace_iri = Namespace_Iri cmd |> NamespaceIRI
    /// <summary>
    ///   <para>cmd:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>This document is a vocabulary to describe compound measures, i.e. measures with several metric or item that are organized with serveral dimensions. The description of such a measure relies on a Tree-Structure of Requirement (TSoR): a set of requirements structured hierarchicaly with analysis element. A TSoR represents the main measure. Several information may be added to explicitely indicate how the overall score on the measure should be calculated based on the hierarchy, relative importance of the node of the hierarchy and an aggregation function. The measure can be described completely and unambiguously from the organisation to the requirements and the implementation.</para>
    /// labels<para>Compound Measure Description</para></remarks>
    /// <seealso href="https://w3id.org/cmd#">https://w3id.org/cmd#</seealso>
    let _prefix_iri = Prefixed_Name(cmd, "") |> PrefixedName
    /// <summary>
    ///   <para>cmd:hasRoot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The TSoR has a given root among the analysis element.</para>
    /// labels<para>has root</para></remarks>
    /// <seealso href="https://w3id.org/cmd#hasRoot">https://w3id.org/cmd#hasRoot</seealso>
    let hasRoot = Prefixed_Name(cmd, "hasRoot") |> PrefixedName
    /// <summary>
    ///   <para>cmd:isImplementedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A requirement is implemented by an implementation.</para>
    /// labels<para>is implemented by</para></remarks>
    /// <seealso href="https://w3id.org/cmd#isImplementedBy">https://w3id.org/cmd#isImplementedBy</seealso>
    let isImplementedBy = Prefixed_Name(cmd, "isImplementedBy") |> PrefixedName
    /// <summary>
    ///   <para>cmd:weight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Number representing the relative importance of one node (analysis element or requirement) of a TSoR compared to its siblings.</para>
    /// labels<para>weight</para></remarks>
    /// <seealso href="https://w3id.org/cmd#weight">https://w3id.org/cmd#weight</seealso>
    let weight = Prefixed_Name(cmd, "weight") |> PrefixedName
    /// <summary>
    ///   <para>cmd:Implementation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An implementation describing a procedure and/or an executable document. Can either be expressed in a query language, or be refering to an executable file, or be precisly describing the procedure.</para>
    /// labels<para>Implementation</para></remarks>
    /// <seealso href="https://w3id.org/cmd#Implementation">https://w3id.org/cmd#Implementation</seealso>
    let Implementation = Prefixed_Name(cmd, "Implementation") |> PrefixedName
    /// <summary>
    ///   <para>cmd:Requirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Node of the tree structure representing a given metric to evaluate a concrete element.</para>
    /// labels<para>Requirement</para></remarks>
    /// <seealso href="https://w3id.org/cmd#Requirement">https://w3id.org/cmd#Requirement</seealso>
    let Requirement = Prefixed_Name(cmd, "Requirement") |> PrefixedName
    /// <summary>
    ///   <para>cmd:TSoR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Defines a compound measure with a set of requirements as well as a structuration of these requirements through the use of analysis elements.</para>
    /// labels<para>TSoR: Tree-Structure of Requirements</para></remarks>
    /// <seealso href="https://w3id.org/cmd#TSoR">https://w3id.org/cmd#TSoR</seealso>
    let TSoR = Prefixed_Name(cmd, "TSoR") |> PrefixedName
    /// <summary>
    ///   <para>cmd:expects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associate a requirement with an analysis element: an analysis element expects a requirement.</para>
    /// labels<para>expects</para></remarks>
    /// <seealso href="https://w3id.org/cmd#expects">https://w3id.org/cmd#expects</seealso>
    let expects = Prefixed_Name(cmd, "expects") |> PrefixedName
    /// <summary>
    ///   <para>cmd:aggregFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Definition of a function expressing how to compute a unique global score based on the result obtained on each requirements and their weight.</para>
    /// labels<para>aggregation function</para></remarks>
    /// <seealso href="https://w3id.org/cmd#aggregFunction">https://w3id.org/cmd#aggregFunction</seealso>
    let aggregFunction = Prefixed_Name(cmd, "aggregFunction") |> PrefixedName
    /// <summary>
    ///   <para>cmd:hasContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A node of a TSoR has as content a given concept or metric.</para>
    /// labels<para>hasContent</para></remarks>
    /// <seealso href="https://w3id.org/cmd#hasContent">https://w3id.org/cmd#hasContent</seealso>
    let hasContent = Prefixed_Name(cmd, "hasContent") |> PrefixedName
    /// <summary>
    ///   <para>cmd:isFollowedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An implementation is followed by another implementation if the the second complement the first one.</para>
    /// labels<para>is followed by</para></remarks>
    /// <seealso href="https://w3id.org/cmd#isFollowedBy">https://w3id.org/cmd#isFollowedBy</seealso>
    let isFollowedBy = Prefixed_Name(cmd, "isFollowedBy") |> PrefixedName
    /// <summary>
    ///   <para>cmd:isSpecifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Structures analysis elements through this relation. An analysis element is specified by one or more other analysis elements that detail the analysis.</para>
    /// labels<para>is specified by</para></remarks>
    /// <seealso href="https://w3id.org/cmd#isSpecifiedBy">https://w3id.org/cmd#isSpecifiedBy</seealso>
    let isSpecifiedBy = Prefixed_Name(cmd, "isSpecifiedBy") |> PrefixedName
    /// <summary>
    ///   <para>cmd:AnalysisElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Node of the tree structure to classify requirements.</para>
    /// labels<para>Analysis Element</para></remarks>
    /// <seealso href="https://w3id.org/cmd#AnalysisElement">https://w3id.org/cmd#AnalysisElement</seealso>
    let AnalysisElement = Prefixed_Name(cmd, "AnalysisElement") |> PrefixedName

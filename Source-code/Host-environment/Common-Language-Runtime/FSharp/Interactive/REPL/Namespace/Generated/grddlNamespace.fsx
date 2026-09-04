#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module grddl =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.w3.org/2003/g/data-view#" "grddl"

    /// <summary>
    ///   <para>rdfs:comment : A resource which has the property that all of its essential characteristics can be conveyed in a message^^xsd:string</para>
    ///   <para>rdfs:label : InformationResource^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/g/data-view#InformationResource">grddl:InformationResource</a>
    /// </summary>
    let InformationResource = _prefixId.prefix "InformationResource"
    /// <summary>
    ///   <para>rdfs:comment : a
    ///     set of RDF triples^^xsd:string</para>
    ///   <para>rdfs:label : RDFGraph^^xsd:stringrdfs:label : RDF graphs^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/g/data-view#RDFGraph">grddl:RDFGraph</a>
    /// </summary>
    let RDFGraph = _prefixId.prefix "RDFGraph"
    /// <summary>
    ///   <para>rdfs:comment : the root of the tree in the XPath data
    ///     model^^xsd:string</para>
    ///   <para>rdfs:label : XML document root nodes^^xsd:stringrdfs:label : RootNode^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/g/data-view#RootNode">grddl:RootNode</a>
    /// </summary>
    let RootNode = _prefixId.prefix "RootNode"
    /// <summary>
    ///   <para>rdfs:comment : an InformationResource that specifies
    ///     a transformation from a set of XML documents to RDF graphs^^xsd:string</para>
    ///   <para>rdfs:label : Transformation^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/g/data-view#Transformation">grddl:Transformation</a>
    /// </summary>
    let Transformation = _prefixId.prefix "Transformation"
    /// <summary>
    ///   <para>rdfs:comment : a FunctionalProperty that relates
    ///     XML document root nodes to
    ///     RDF graphs^^xsd:string</para>
    ///   <para>rdfs:label : TransformationProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/g/data-view#TransformationProperty">grddl:TransformationProperty</a>
    /// </summary>
    let TransformationProperty = _prefixId.prefix "TransformationProperty"
    let danc = _prefixId.prefix "danc"
    let grddl_wg = _prefixId.prefix "grddl-wg"
    let grddlProject = _prefixId.prefix "grddlProject"
    /// <summary>
    ///   <para>rdfs:comment : relates a namespace to a transformation for
    ///     all documents in that namespace^^xsd:string</para>
    ///   <para>rdfs:label : namespaceTransformation^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/g/data-view#namespaceTransformation">grddl:namespaceTransformation</a>
    /// </summary>
    let namespaceTransformation = _prefixId.prefix "namespaceTransformation"
    /// <summary>
    ///   <para>rdfs:comment : relates a profile document to a
    ///     transformation for all documents bearing that profile^^xsd:string</para>
    ///   <para>rdfs:label : profileTransformation^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/g/data-view#profileTransformation">grddl:profileTransformation</a>
    /// </summary>
    let profileTransformation = _prefixId.prefix "profileTransformation"
    /// <summary>
    ///   <para>rdfs:comment : an
    ///     RDF graph obtained from an information resource by directly
    ///     parsing a representation in the standard RDF/XML syntax or
    ///     indirectly by parsing some other dialect using a transformation
    ///     nominated by the document^^xsd:string</para>
    ///   <para>rdfs:label : result^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/g/data-view#result">grddl:result</a>
    /// </summary>
    let result = _prefixId.prefix "result"
    /// <summary>
    ///   <para>rdfs:comment : relates a source document to a
    ///     transformation, usually represented in XSLT, that relates the source document syntax
    ///     to the RDF graph syntax^^xsd:string</para>
    ///   <para>rdfs:label : transformation^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/g/data-view#transformation">grddl:transformation</a>
    /// </summary>
    let transformation = _prefixId.prefix "transformation"
    let transformationProperty = _prefixId.prefix "transformationProperty"

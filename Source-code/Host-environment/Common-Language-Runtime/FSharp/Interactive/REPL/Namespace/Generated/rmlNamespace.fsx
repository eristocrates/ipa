#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module rml =
    let _prefixId = PrefixId.fromNamespaceLabel "http://w3id.org/rml/" "rml"
    let CSV = _prefixId.prefix "CSV"
    /// <summary>
    ///   <para>rdfs:label : compression class^^xsd:string</para>
    ///   <para>rdfs:comment : Represents file compression schemes.</para>
    ///   <a href="http://w3id.org/rml/Compression">rml-io:Compression</a>
    /// </summary>
    let Compression = _prefixId.prefix "Compression"
    /// <summary>
    ///   <para>rdfs:label : Encoding class^^xsd:string</para>
    ///   <para>rdfs:comment : Represents encoding formats.</para>
    ///   <a href="http://w3id.org/rml/Encoding">rml-io:Encoding</a>
    /// </summary>
    let Encoding = _prefixId.prefix "Encoding"
    let JSONPath = _prefixId.prefix "JSONPath"
    /// <summary>
    ///   <para>rdfs:label : Logical Source^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes a logical source.</para>
    ///   <a href="http://w3id.org/rml/LogicalSource">rml-io:LogicalSource</a>
    /// </summary>
    let LogicalSource = _prefixId.prefix "LogicalSource"
    /// <summary>
    ///   <para>rdfs:label : LogicalTarget^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes a logical target.</para>
    ///   <a href="http://w3id.org/rml/LogicalTarget">rml-io:LogicalTarget</a>
    /// </summary>
    let LogicalTarget = _prefixId.prefix "LogicalTarget"
    /// <summary>
    ///   <para>rdfs:label : Namespace^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes a namespace</para>
    ///   <a href="http://w3id.org/rml/Namespace">rml-io:Namespace</a>
    /// </summary>
    let Namespace = _prefixId.prefix "Namespace"
    /// <summary>
    ///   <para>rdfs:label : Reference Formulation^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes a Reference Formulation.</para>
    ///   <a href="http://w3id.org/rml/ReferenceFormulation">rml-io:ReferenceFormulation</a>
    /// </summary>
    let ReferenceFormulation = _prefixId.prefix "ReferenceFormulation"
    let SQL2008 = _prefixId.prefix "SQL2008"
    /// <summary>
    ///   <para>rdfs:label : Source^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes a source.</para>
    ///   <a href="http://w3id.org/rml/Source">rml-io:Source</a>
    /// </summary>
    let Source = _prefixId.prefix "Source"
    /// <summary>
    ///   <para>rdfs:label : Target^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes a target.</para>
    ///   <a href="http://w3id.org/rml/Target">rml-io:Target</a>
    /// </summary>
    let Target = _prefixId.prefix "Target"
    let UTF_16 = _prefixId.prefix "UTF-16"
    let UTF_8 = _prefixId.prefix "UTF-8"
    let XPath = _prefixId.prefix "XPath"
    /// <summary>
    ///   <para>rdfs:label : XPath Reference Formulation^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes a XPath Reference Formulation.</para>
    ///   <a href="http://w3id.org/rml/XPathReferenceFormulation">rml-io:XPathReferenceFormulation</a>
    /// </summary>
    let XPathReferenceFormulation = _prefixId.prefix "XPathReferenceFormulation"
    /// <summary>
    ///   <para>rdfs:label : compression^^xsd:string</para>
    ///   <para>rdfs:comment : Defines the compression format of a Source or Target.</para>
    ///   <a href="http://w3id.org/rml/compression">rml-io:compression</a>
    /// </summary>
    let compression = _prefixId.prefix "compression"
    /// <summary>
    ///   <para>rdfs:label : encoding^^xsd:string</para>
    ///   <para>rdfs:comment : Defines the encoding format of a Source or Target.</para>
    ///   <a href="http://w3id.org/rml/encoding">rml-io:encoding</a>
    /// </summary>
    let encoding = _prefixId.prefix "encoding"
    let gzip = _prefixId.prefix "gzip"
    let io = _prefixId.prefix "io"
    /// <summary>
    ///   <para>rdfs:label : iterator^^xsd:string</para>
    ///   <para>rdfs:comment : An expression qualified according to the reference formulation specified for pointing to an extract of the source data. </para>
    ///   <a href="http://w3id.org/rml/iterator">rml-io:iterator</a>
    /// </summary>
    let iterator = _prefixId.prefix "iterator"
    /// <summary>
    ///   <para>rdfs:label : namespace^^xsd:string</para>
    ///   <para>rdfs:comment : A namespace for describing a XPath reference formulation.</para>
    ///   <a href="http://w3id.org/rml/namespace">rml-io:namespace</a>
    /// </summary>
    let namespace_ = _prefixId.prefix "namespace"
    /// <summary>
    ///   <para>rdfs:label : namespace prefix^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the prefix of a namespace.</para>
    ///   <a href="http://w3id.org/rml/namespacePrefix">rml-io:namespacePrefix</a>
    /// </summary>
    let namespacePrefix = _prefixId.prefix "namespacePrefix"
    /// <summary>
    ///   <para>rdfs:label : namespace URL^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the URL of a namespace.</para>
    ///   <a href="http://w3id.org/rml/namespaceURL">rml-io:namespaceURL</a>
    /// </summary>
    let namespaceURL = _prefixId.prefix "namespaceURL"
    let none = _prefixId.prefix "none"
    /// <summary>
    ///   <para>rdfs:label : null^^xsd:string</para>
    ///   <para>rdfs:comment : Describes which data values inside the source should be considered as NULL.</para>
    ///   <a href="http://w3id.org/rml/null">rml-io:null</a>
    /// </summary>
    let null_ = _prefixId.prefix "null"
    /// <summary>
    ///   <para>rdfs:label : query^^xsd:string</para>
    ///   <para>rdfs:comment : Defines which query should be applied on the source during access</para>
    ///   <a href="http://w3id.org/rml/query">rml-io:query</a>
    /// </summary>
    let query = _prefixId.prefix "query"
    /// <summary>
    ///   <para>rdfs:label : reference formulation^^xsd:string</para>
    ///   <para>rdfs:comment : The reference formulation used to refer to extracts of the source data. </para>
    ///   <a href="http://w3id.org/rml/referenceFormulation">rml-io:referenceFormulation</a>
    /// </summary>
    let referenceFormulation = _prefixId.prefix "referenceFormulation"
    /// <summary>
    ///   <para>rdfs:label : serialization^^xsd:string</para>
    ///   <para>rdfs:comment : Defines the serialization to generate the target output.</para>
    ///   <a href="http://w3id.org/rml/serialization">rml-io:serialization</a>
    /// </summary>
    let serialization = _prefixId.prefix "serialization"
    /// <summary>
    ///   <para>rdfs:label : source^^xsd:string</para>
    ///   <para>rdfs:comment : Defines the source that describe the input data.</para>
    ///   <a href="http://w3id.org/rml/source">rml-io:source</a>
    /// </summary>
    let source = _prefixId.prefix "source"
    /// <summary>
    ///   <para>rdfs:label : target^^xsd:string</para>
    ///   <para>rdfs:comment : Defines the target that describe the output data.</para>
    ///   <a href="http://w3id.org/rml/target">rml-io:target</a>
    /// </summary>
    let target = _prefixId.prefix "target"
    let targzip = _prefixId.prefix "targzip"
    let tarxz = _prefixId.prefix "tarxz"
    let zip = _prefixId.prefix "zip"

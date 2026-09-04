#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module rdf =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.w3.org/1999/02/22-rdf-syntax-ns#" "rdf"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Alt^^xsd:string</para>
    ///   <para>rdfs:comment : The class of containers of alternatives.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Alt">rdf:Alt</a>
    /// </summary>
    let Alt = _prefixId.prefix "Alt"
    /// <summary>
    ///   <para>rdfs:label : Bag^^xsd:string</para>
    ///   <para>rdfs:comment : The class of unordered containers.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Bag">rdf:Bag</a>
    /// </summary>
    let Bag = _prefixId.prefix "Bag"
    /// <summary>
    ///   <para>rdfs:label : CompoundLiteral^^xsd:string</para>
    ///   <para>rdfs:comment : A class representing a compound literal.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#CompoundLiteral">rdf:CompoundLiteral</a>
    /// </summary>
    let CompoundLiteral = _prefixId.prefix "CompoundLiteral"
    let HTML = _prefixId.prefix "HTML"
    let JSON = _prefixId.prefix "JSON"
    /// <summary>
    ///   <para>rdfs:label : List^^xsd:string</para>
    ///   <para>rdfs:comment : The class of RDF Lists.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#List">rdf:List</a>
    /// </summary>
    let List = _prefixId.prefix "List"
    let PlainLiteral = _prefixId.prefix "PlainLiteral"
    /// <summary>
    ///   <para>rdfs:label : Property^^xsd:string</para>
    ///   <para>rdfs:comment : The class of RDF properties.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Property">rdf:Property</a>
    /// </summary>
    let Property = _prefixId.prefix "Property"
    /// <summary>
    ///   <para>rdfs:label : Seq^^xsd:string</para>
    ///   <para>rdfs:comment : The class of ordered containers.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Seq">rdf:Seq</a>
    /// </summary>
    let Seq = _prefixId.prefix "Seq"
    /// <summary>
    ///   <para>rdfs:label : Statement^^xsd:string</para>
    ///   <para>rdfs:comment : The class of RDF statements.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Statement">rdf:Statement</a>
    /// </summary>
    let Statement = _prefixId.prefix "Statement"
    let XMLLiteral = _prefixId.prefix "XMLLiteral"
    /// <summary>
    ///   <para>rdfs:label : direction^^xsd:string</para>
    ///   <para>rdfs:comment : The base direction component of a CompoundLiteral.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#direction">rdf:direction</a>
    /// </summary>
    let direction = _prefixId.prefix "direction"
    /// <summary>
    ///   <para>rdfs:label : first^^xsd:string</para>
    ///   <para>rdfs:comment : The first item in the subject RDF list.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#first">rdf:first</a>
    /// </summary>
    let first = _prefixId.prefix "first"
    let langString = _prefixId.prefix "langString"
    /// <summary>
    ///   <para>rdfs:label : language^^xsd:string</para>
    ///   <para>rdfs:comment : The language component of a CompoundLiteral.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#language">rdf:language</a>
    /// </summary>
    let language = _prefixId.prefix "language"
    let nil = _prefixId.prefix "nil"
    /// <summary>
    ///   <para>rdfs:label : object^^xsd:string</para>
    ///   <para>rdfs:comment : The object of the subject RDF statement.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#object">rdf:object</a>
    /// </summary>
    let object = _prefixId.prefix "object"
    /// <summary>
    ///   <para>rdfs:label : predicate^^xsd:string</para>
    ///   <para>rdfs:comment : The predicate of the subject RDF statement.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#predicate">rdf:predicate</a>
    /// </summary>
    let predicate = _prefixId.prefix "predicate"
    /// <summary>
    ///   <para>rdfs:label : rest^^xsd:string</para>
    ///   <para>rdfs:comment : The rest of the subject RDF list after the first item.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#rest">rdf:rest</a>
    /// </summary>
    let rest = _prefixId.prefix "rest"
    /// <summary>
    ///   <para>rdfs:label : subject^^xsd:string</para>
    ///   <para>rdfs:comment : The subject of the subject RDF statement.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#subject">rdf:subject</a>
    /// </summary>
    let subject = _prefixId.prefix "subject"
    /// <summary>
    ///   <para>rdfs:label : type^^xsd:string</para>
    ///   <para>rdfs:comment : The subject is an instance of a class.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#type">rdf:type</a>
    /// </summary>
    let type_ = _prefixId.prefix "type"
    /// <summary>
    ///   <para>rdfs:label : value^^xsd:string</para>
    ///   <para>rdfs:comment : Idiomatic property used for structured values.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/02/22-rdf-syntax-ns#value">rdf:value</a>
    /// </summary>
    let value = _prefixId.prefix "value"

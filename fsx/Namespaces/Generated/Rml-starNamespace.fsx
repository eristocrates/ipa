#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``rml-star`` =
    let _prefixId = PrefixId.fromNamespaceLabel "http://w3id.org/rml/" "rml-star"
    /// <summary>
    ///   <para>rdfs:label : Asserted Triples Map^^xsd:string</para>
    ///   <para>rdfs:comment : A type of Triples Map that is quoted and asserted in the resulting graph.</para>
    ///   <a href="http://w3id.org/rml/AssertedTriplesMap">rml-star:AssertedTriplesMap</a>
    /// </summary>
    let AssertedTriplesMap = _prefixId.prefix "AssertedTriplesMap"
    /// <summary>
    ///   <para>rdfs:label : Non Asserted Triples Map^^xsd:string</para>
    ///   <para>rdfs:comment : A type of Triples Map that is quoted but not asserted in the resulting graph</para>
    ///   <a href="http://w3id.org/rml/NonAssertedTriplesMap">rml-star:NonAssertedTriplesMap</a>
    /// </summary>
    let NonAssertedTriplesMap = _prefixId.prefix "NonAssertedTriplesMap"
    /// <summary>
    ///   <para>rdfs:label : Star Map^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a star map able to generate RDF-star triples.</para>
    ///   <a href="http://w3id.org/rml/StarMap">rml-star:StarMap</a>
    /// </summary>
    let StarMap = _prefixId.prefix "StarMap"
    let TriplesMap = _prefixId.prefix "TriplesMap"
    /// <summary>
    ///   <para>rdfs:label : quoted triples map^^xsd:string</para>
    ///   <para>rdfs:comment : An quoted TriplesMap element to generate a RDF-star triple as subject or object or another triple from a logical source record.</para>
    ///   <a href="http://w3id.org/rml/quotedTriplesMap">rml-star:quotedTriplesMap</a>
    /// </summary>
    let quotedTriplesMap = _prefixId.prefix "quotedTriplesMap"
    let star = _prefixId.prefix "star"

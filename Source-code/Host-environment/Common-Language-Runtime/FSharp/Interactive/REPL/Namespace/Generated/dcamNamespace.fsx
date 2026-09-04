#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dcam =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/dc/dcam/" "dcam"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : An enumerated set of resources.</para>
    ///   <para>rdfs:label : Vocabulary Encoding Scheme</para>
    ///   <a href="http://purl.org/dc/dcam/VocabularyEncodingScheme">dcam:VocabularyEncodingScheme</a>
    /// </summary>
    let VocabularyEncodingScheme = _prefixId.prefix "VocabularyEncodingScheme"
    /// <summary>
    ///   <para>dcterms:modified : 2010-10-11^^xsd:date</para>
    ///   <para>dcterms:issued : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:comment : A relationship between a resource and a vocabulary encoding scheme which indicates that the resource is a member of a set.</para>
    ///   <para>rdfs:label : Member Of</para>
    ///   <a href="http://purl.org/dc/dcam/memberOf">dcam:memberOf</a>
    /// </summary>
    let memberOf = _prefixId.prefix "memberOf"

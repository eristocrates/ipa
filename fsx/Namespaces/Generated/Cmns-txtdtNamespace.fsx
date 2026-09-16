#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``cmns-txtdt`` =
    let _prefixId = PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/TextDatatype/" "cmns-txtdt"

    let _namespaceIri = _prefixId.prefix ""
    let Text = _prefixId.prefix "Text"
    /// <summary>
    ///   <para>rdfs:label : has text value^^xsd:string</para>
    ///   <para>skos:definition : provides a string value for something, with or without a language tag^^xsd:string</para>
    ///   <para>skos:note : Note that although the intended range for this property is Text, we have left the range undefined so that it can be used with tools that do not support rdf:langString.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/TextDatatype/hasTextValue">cmns-txtdt:hasTextValue</a>
    /// </summary>
    let hasTextValue = _prefixId.prefix "hasTextValue"

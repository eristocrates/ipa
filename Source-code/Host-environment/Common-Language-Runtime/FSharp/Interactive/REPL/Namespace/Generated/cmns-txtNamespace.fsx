#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``cmns-txt`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/TextDatatype/" "cmns-txt"

    let _namespaceIri = _prefixId.prefix ""
    let Text = _prefixId.prefix "Text"
    /// <summary>
    ///   <para>rdfs:label : has text value^^xsd:string</para>
    ///   <para>skos:definition : provides a string value for something, with or without a language tag^^xsd:string</para>
    ///   <para>skos:note : Note that although the intended range for this property is Text, we have left the range undefined so that it can be used with tools that do not support rdf:langString.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/TextDatatype/hasTextValue">cmns-txt:hasTextValue</a>
    /// </summary>
    let hasTextValue = _prefixId.prefix "hasTextValue"

#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module infor =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.ontologydesignpatterns.org/cp/owl/informationrealization.owl#" "infor"

    /// <summary>
    ///   <para>rdfs:comment : A piece of information, such as a musical composition, a text, a word, a picture, independently from how it is concretely realized.^^xsd:string</para>
    ///   <para>rdfs:label : Information object</para>
    ///   <a href="http://www.ontologydesignpatterns.org/cp/owl/informationrealization.owl#InformationObject">infor:InformationObject</a>
    /// </summary>
    let InformationObject = _prefixId.prefix "InformationObject"
    /// <summary>
    ///   <para>rdfs:comment : A concrete realization of an information object, e.g. the written document containing the text of a law.^^xsd:string</para>
    ///   <para>rdfs:label : Information realization</para>
    ///   <a href="http://www.ontologydesignpatterns.org/cp/owl/informationrealization.owl#InformationRealization">infor:InformationRealization</a>
    /// </summary>
    let InformationRealization = _prefixId.prefix "InformationRealization"
    /// <summary>
    ///   <para>rdfs:comment : A relation between an information realization and an information object, e.g. the paper copy of the Italian Constitution realizes the text of the Constitution.^^xsd:string</para>
    ///   <para>rdfs:label : is realized by</para>
    ///   <a href="http://www.ontologydesignpatterns.org/cp/owl/informationrealization.owl#isRealizedBy">infor:isRealizedBy</a>
    /// </summary>
    let isRealizedBy = _prefixId.prefix "isRealizedBy"
    /// <summary>
    ///   <para>rdfs:comment : A relation between an information realization and an information object, e.g. the paper copy of the Italian Constitution realizes the text of the Constitution.^^xsd:string</para>
    ///   <para>rdfs:label : realizes</para>
    ///   <a href="http://www.ontologydesignpatterns.org/cp/owl/informationrealization.owl#realizes">infor:realizes</a>
    /// </summary>
    let realizes = _prefixId.prefix "realizes"

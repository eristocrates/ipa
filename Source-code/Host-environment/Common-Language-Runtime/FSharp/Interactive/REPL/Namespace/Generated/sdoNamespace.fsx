#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module sdo =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://salt.semanticauthoring.org/ontologies/sdo#" "sdo"

    /// <summary>
    ///   <para>rdfs:label : Figure^^xsd:string</para>
    ///   <a href="http://salt.semanticauthoring.org/ontologies/sdo#Figure">sdo:Figure</a>
    /// </summary>
    let Figure = _prefixId.prefix "Figure"
    /// <summary>
    ///   <para>rdfs:label : Paragraph^^xsd:string</para>
    ///   <a href="http://salt.semanticauthoring.org/ontologies/sdo#Paragraph">sdo:Paragraph</a>
    /// </summary>
    let Paragraph = _prefixId.prefix "Paragraph"
    /// <summary>
    ///   <para>rdfs:label : Publication^^xsd:string</para>
    ///   <a href="http://salt.semanticauthoring.org/ontologies/sdo#Publication">sdo:Publication</a>
    /// </summary>
    let Publication = _prefixId.prefix "Publication"
    /// <summary>
    ///   <para>rdfs:label : Revision^^xsd:string</para>
    ///   <a href="http://salt.semanticauthoring.org/ontologies/sdo#Revision">sdo:Revision</a>
    /// </summary>
    let Revision = _prefixId.prefix "Revision"
    /// <summary>
    ///   <para>rdfs:label : Section^^xsd:string</para>
    ///   <a href="http://salt.semanticauthoring.org/ontologies/sdo#Section">sdo:Section</a>
    /// </summary>
    let Section = _prefixId.prefix "Section"
    /// <summary>
    ///   <para>rdfs:label : Sentence^^xsd:string</para>
    ///   <a href="http://salt.semanticauthoring.org/ontologies/sdo#Sentence">sdo:Sentence</a>
    /// </summary>
    let Sentence = _prefixId.prefix "Sentence"
    /// <summary>
    ///   <para>rdfs:label : Table^^xsd:string</para>
    ///   <a href="http://salt.semanticauthoring.org/ontologies/sdo#Table">sdo:Table</a>
    /// </summary>
    let Table = _prefixId.prefix "Table"
    /// <summary>
    ///   <para>rdfs:label : TextChunk^^xsd:string</para>
    ///   <a href="http://salt.semanticauthoring.org/ontologies/sdo#TextChunk">sdo:TextChunk</a>
    /// </summary>
    let TextChunk = _prefixId.prefix "TextChunk"
    /// <summary>
    ///   <para>rdfs:label : hasAnnotation^^xsd:string</para>
    ///   <a href="http://salt.semanticauthoring.org/ontologies/sdo#hasAnnotation">sdo:hasAnnotation</a>
    /// </summary>
    let hasAnnotation = _prefixId.prefix "hasAnnotation"
    /// <summary>
    ///   <para>rdfs:label : hasCaption^^xsd:string</para>
    ///   <a href="http://salt.semanticauthoring.org/ontologies/sdo#hasCaption">sdo:hasCaption</a>
    /// </summary>
    let hasCaption = _prefixId.prefix "hasCaption"
    /// <summary>
    ///   <para>rdfs:label : hasEndPointer^^xsd:string</para>
    ///   <a href="http://salt.semanticauthoring.org/ontologies/sdo#hasEndPointer">sdo:hasEndPointer</a>
    /// </summary>
    let hasEndPointer = _prefixId.prefix "hasEndPointer"
    /// <summary>
    ///   <para>rdfs:label : hasFigure^^xsd:string</para>
    ///   <a href="http://salt.semanticauthoring.org/ontologies/sdo#hasFigure">sdo:hasFigure</a>
    /// </summary>
    let hasFigure = _prefixId.prefix "hasFigure"
    /// <summary>
    ///   <para>rdfs:label : hasOrderNumber^^xsd:string</para>
    ///   <a href="http://salt.semanticauthoring.org/ontologies/sdo#hasOrderNumber">sdo:hasOrderNumber</a>
    /// </summary>
    let hasOrderNumber = _prefixId.prefix "hasOrderNumber"
    /// <summary>
    ///   <para>rdfs:label : hasParagraph^^xsd:string</para>
    ///   <a href="http://salt.semanticauthoring.org/ontologies/sdo#hasParagraph">sdo:hasParagraph</a>
    /// </summary>
    let hasParagraph = _prefixId.prefix "hasParagraph"
    /// <summary>
    ///   <para>rdfs:label : hasRevision^^xsd:string</para>
    ///   <a href="http://salt.semanticauthoring.org/ontologies/sdo#hasRevision">sdo:hasRevision</a>
    /// </summary>
    let hasRevision = _prefixId.prefix "hasRevision"
    /// <summary>
    ///   <para>rdfs:label : hasSALTVersion^^xsd:string</para>
    ///   <a href="http://salt.semanticauthoring.org/ontologies/sdo#hasSALTVersion">sdo:hasSALTVersion</a>
    /// </summary>
    let hasSALTVersion = _prefixId.prefix "hasSALTVersion"
    /// <summary>
    ///   <para>rdfs:label : hasSection^^xsd:string</para>
    ///   <a href="http://salt.semanticauthoring.org/ontologies/sdo#hasSection">sdo:hasSection</a>
    /// </summary>
    let hasSection = _prefixId.prefix "hasSection"
    /// <summary>
    ///   <para>rdfs:label : hasSectionTitle^^xsd:string</para>
    ///   <a href="http://salt.semanticauthoring.org/ontologies/sdo#hasSectionTitle">sdo:hasSectionTitle</a>
    /// </summary>
    let hasSectionTitle = _prefixId.prefix "hasSectionTitle"
    /// <summary>
    ///   <para>rdfs:label : hasSentence^^xsd:string</para>
    ///   <a href="http://salt.semanticauthoring.org/ontologies/sdo#hasSentence">sdo:hasSentence</a>
    /// </summary>
    let hasSentence = _prefixId.prefix "hasSentence"
    /// <summary>
    ///   <para>rdfs:label : hasStartPointer^^xsd:string</para>
    ///   <a href="http://salt.semanticauthoring.org/ontologies/sdo#hasStartPointer">sdo:hasStartPointer</a>
    /// </summary>
    let hasStartPointer = _prefixId.prefix "hasStartPointer"
    /// <summary>
    ///   <para>rdfs:label : hasSubSection^^xsd:string</para>
    ///   <a href="http://salt.semanticauthoring.org/ontologies/sdo#hasSubSection">sdo:hasSubSection</a>
    /// </summary>
    let hasSubSection = _prefixId.prefix "hasSubSection"
    /// <summary>
    ///   <para>rdfs:label : hasTable^^xsd:string</para>
    ///   <a href="http://salt.semanticauthoring.org/ontologies/sdo#hasTable">sdo:hasTable</a>
    /// </summary>
    let hasTable = _prefixId.prefix "hasTable"
    /// <summary>
    ///   <para>rdfs:label : hasTextChunk^^xsd:string</para>
    ///   <a href="http://salt.semanticauthoring.org/ontologies/sdo#hasTextChunk">sdo:hasTextChunk</a>
    /// </summary>
    let hasTextChunk = _prefixId.prefix "hasTextChunk"

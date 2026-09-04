#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module li =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#" "li"

    /// <summary>
    ///   <para>skos:notation : LI_Lineage^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Lineage^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#Lineage">li:Lineage</a>
    /// </summary>
    let Lineage = _prefixId.prefix "Lineage"
    /// <summary>
    ///   <para>rdfs:label : Process step^^xsd:string</para>
    ///   <para>skos:notation : LI_ProcessStep^^h2o:ISOClassName</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#ProcessStep">li:ProcessStep</a>
    /// </summary>
    let ProcessStep = _prefixId.prefix "ProcessStep"
    /// <summary>
    ///   <para>rdfs:label : Source^^xsd:string</para>
    ///   <para>skos:notation : LI_Source^^h2o:ISOClassName</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#Source">li:Source</a>
    /// </summary>
    let Source = _prefixId.prefix "Source"
    /// <summary>
    ///   <para>rdfs:label : date time^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#dateTime">li:dateTime</a>
    /// </summary>
    let dateTime = _prefixId.prefix "dateTime"
    /// <summary>
    ///   <para>rdfs:label : description^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#description">li:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:label : process step^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#processStep">li:processStep</a>
    /// </summary>
    let processStep = _prefixId.prefix "processStep"
    /// <summary>
    ///   <para>rdfs:label : processor^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#processor">li:processor</a>
    /// </summary>
    let processor = _prefixId.prefix "processor"
    /// <summary>
    ///   <para>rdfs:label : rationale^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#rationale">li:rationale</a>
    /// </summary>
    let rationale = _prefixId.prefix "rationale"
    /// <summary>
    ///   <para>rdfs:label : scale denominator^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#scaleDenominator">li:scaleDenominator</a>
    /// </summary>
    let scaleDenominator = _prefixId.prefix "scaleDenominator"
    /// <summary>
    ///   <para>rdfs:label : source^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#source">li:source</a>
    /// </summary>
    let source = _prefixId.prefix "source"
    /// <summary>
    ///   <para>rdfs:label : source citation^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#sourceCitation">li:sourceCitation</a>
    /// </summary>
    let sourceCitation = _prefixId.prefix "sourceCitation"
    /// <summary>
    ///   <para>rdfs:label : source extent^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#sourceExtent">li:sourceExtent</a>
    /// </summary>
    let sourceExtent = _prefixId.prefix "sourceExtent"
    /// <summary>
    ///   <para>rdfs:label : source reference system^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#sourceReferenceSystem">li:sourceReferenceSystem</a>
    /// </summary>
    let sourceReferenceSystem = _prefixId.prefix "sourceReferenceSystem"
    /// <summary>
    ///   <para>rdfs:label : source step^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#sourceStep">li:sourceStep</a>
    /// </summary>
    let sourceStep = _prefixId.prefix "sourceStep"
    /// <summary>
    ///   <para>rdfs:label : statement^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#statement">li:statement</a>
    /// </summary>
    let statement = _prefixId.prefix "statement"

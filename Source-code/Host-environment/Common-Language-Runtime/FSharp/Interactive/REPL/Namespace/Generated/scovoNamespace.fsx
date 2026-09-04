#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module scovo =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/NET/scovo#" "scovo"
    /// <summary>
    ///   <para>rdfs:label : Dataset^^xsd:string</para>
    ///   <para>rdfs:comment : a statistical dataset^^xsd:string</para>
    ///   <a href="http://purl.org/NET/scovo#Dataset">scovo:Dataset</a>
    /// </summary>
    let Dataset = _prefixId.prefix "Dataset"
    /// <summary>
    ///   <para>rdfs:label : Dimension^^xsd:string</para>
    ///   <para>rdfs:comment : a dimension of a statistical data item^^xsd:string</para>
    ///   <a href="http://purl.org/NET/scovo#Dimension">scovo:Dimension</a>
    /// </summary>
    let Dimension = _prefixId.prefix "Dimension"
    /// <summary>
    ///   <para>rdfs:label : Item^^xsd:string</para>
    ///   <para>rdfs:comment : a statistical data item^^xsd:string</para>
    ///   <a href="http://purl.org/NET/scovo#Item">scovo:Item</a>
    /// </summary>
    let Item = _prefixId.prefix "Item"
    /// <summary>
    ///   <para>rdfs:label : belongs to dataset^^xsd:string</para>
    ///   <a href="http://purl.org/NET/scovo#dataset">scovo:dataset</a>
    /// </summary>
    let dataset = _prefixId.prefix "dataset"
    /// <summary>
    ///   <para>rdfs:label : is the dataset of^^xsd:string</para>
    ///   <a href="http://purl.org/NET/scovo#datasetOf">scovo:datasetOf</a>
    /// </summary>
    let datasetOf = _prefixId.prefix "datasetOf"
    /// <summary>
    ///   <para>rdfs:label : has a dimension^^xsd:string</para>
    ///   <a href="http://purl.org/NET/scovo#dimension">scovo:dimension</a>
    /// </summary>
    let dimension = _prefixId.prefix "dimension"
    /// <summary>
    ///   <para>rdfs:label : has a maximum range value^^xsd:string</para>
    ///   <a href="http://purl.org/NET/scovo#max">scovo:max</a>
    /// </summary>
    let max = _prefixId.prefix "max"
    /// <summary>
    ///   <para>rdfs:label : has a minimum range value^^xsd:string</para>
    ///   <a href="http://purl.org/NET/scovo#min">scovo:min</a>
    /// </summary>
    let min = _prefixId.prefix "min"

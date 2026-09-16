#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dcat =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/dcat#" "dcat"
    /// <summary>
    ///   <para>rdfs:label : Catalog^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/dcat#Catalog">dcat:Catalog</a>
    /// </summary>
    let Catalog = _prefixId.prefix "Catalog"
    /// <summary>
    ///   <para>rdfs:label : Data Service^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/dcat#DataService">dcat:DataService</a>
    /// </summary>
    let DataService = _prefixId.prefix "DataService"
    /// <summary>
    ///   <para>rdfs:label : Dataset^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/dcat#Dataset">dcat:Dataset</a>
    /// </summary>
    let Dataset = _prefixId.prefix "Dataset"
    /// <summary>
    ///   <para>rdfs:label : Distribution^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/dcat#Distribution">dcat:Distribution</a>
    /// </summary>
    let Distribution = _prefixId.prefix "Distribution"
    /// <summary>
    ///   <para>rdfs:label : access service^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/dcat#accessService">dcat:accessService</a>
    /// </summary>
    let accessService = _prefixId.prefix "accessService"
    /// <summary>
    ///   <para>rdfs:label : access url^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/dcat#accessURL">dcat:accessURL</a>
    /// </summary>
    let accessURL = _prefixId.prefix "accessURL"
    /// <summary>
    ///   <para>rdfs:label : catalog^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/dcat#catalog">dcat:catalog</a>
    /// </summary>
    let catalog = _prefixId.prefix "catalog"
    /// <summary>
    ///   <para>rdfs:label : dataset^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/dcat#dataset">dcat:dataset</a>
    /// </summary>
    let dataset = _prefixId.prefix "dataset"
    /// <summary>
    ///   <para>rdfs:label : distribution^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/dcat#distribution">dcat:distribution</a>
    /// </summary>
    let distribution = _prefixId.prefix "distribution"
    /// <summary>
    ///   <para>rdfs:label : endpoint url^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/dcat#endpointURL">dcat:endpointURL</a>
    /// </summary>
    let endpointURL = _prefixId.prefix "endpointURL"
    /// <summary>
    ///   <para>rdfs:label : keyword^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/dcat#keyword">dcat:keyword</a>
    /// </summary>
    let keyword = _prefixId.prefix "keyword"
    /// <summary>
    ///   <para>rdfs:label : media type^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/dcat#mediaType">dcat:mediaType</a>
    /// </summary>
    let mediaType = _prefixId.prefix "mediaType"
    /// <summary>
    ///   <para>rdfs:label : serves dataset^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/dcat#servesDataset">dcat:servesDataset</a>
    /// </summary>
    let servesDataset = _prefixId.prefix "servesDataset"
    /// <summary>
    ///   <para>rdfs:label : service^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/dcat#service">dcat:service</a>
    /// </summary>
    let service = _prefixId.prefix "service"
    /// <summary>
    ///   <para>rdfs:label : theme^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/dcat#theme">dcat:theme</a>
    /// </summary>
    let theme = _prefixId.prefix "theme"
    /// <summary>
    ///   <para>rdfs:label : theme taxonomy^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/dcat#themeTaxonomy">dcat:themeTaxonomy</a>
    /// </summary>
    let themeTaxonomy = _prefixId.prefix "themeTaxonomy"

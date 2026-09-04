#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module sto =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/i40/sto#" "sto"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>dcterms:description : Represents the possible industry domains</para>
    ///   <para>rdfs:label : Industry Domain^^xsd:string</para>
    ///   <a href="https://w3id.org/i40/sto#IndustryDomain">sto:IndustryDomain</a>
    /// </summary>
    let IndustryDomain = _prefixId.prefix "IndustryDomain"
    /// <summary>
    ///   <para>dcterms:description : Define the standards organizations that develop and publish specific standards related to the industry 4.0</para>
    ///   <para>rdfs:label : Standard Developing Organization^^xsd:string</para>
    ///   <a href="https://w3id.org/i40/sto#SDO">sto:SDO</a>
    /// </summary>
    let SDO = _prefixId.prefix "SDO"
    /// <summary>
    ///   <para>dcterms:description : Defines the standards in use on the Industry 4.0</para>
    ///   <para>rdfs:label : Standard^^xsd:string</para>
    ///   <a href="https://w3id.org/i40/sto#Standard">sto:Standard</a>
    /// </summary>
    let Standard = _prefixId.prefix "Standard"
    /// <summary>
    ///   <para>dcterms:description : Abbreviated  name of the organization</para>
    ///   <para>rdfs:label : Abbreviated name^^xsd:string</para>
    ///   <a href="https://w3id.org/i40/sto#abbreviation">sto:abbreviation</a>
    /// </summary>
    let abbreviation = _prefixId.prefix "abbreviation"
    /// <summary>
    ///   <para>dcterms:description : Abbreviated  name of the organization</para>
    ///   <para>rdfs:label : Formation Date</para>
    ///   <a href="https://w3id.org/i40/sto#formationDate">sto:formationDate</a>
    /// </summary>
    let formationDate = _prefixId.prefix "formationDate"
    /// <summary>
    ///   <para>dcterms:description : Instance's DBpedia Resource</para>
    ///   <para>rdfs:label : Has DBpedia resource^^xsd:string</para>
    ///   <a href="https://w3id.org/i40/sto#hasDBpediaResource">sto:hasDBpediaResource</a>
    /// </summary>
    let hasDBpediaResource = _prefixId.prefix "hasDBpediaResource"
    /// <summary>
    ///   <para>dcterms:description : Instance's Official Website</para>
    ///   <para>rdfs:label : Has Official website^^xsd:string</para>
    ///   <a href="https://w3id.org/i40/sto#hasOfficialWebsite">sto:hasOfficialWebsite</a>
    /// </summary>
    let hasOfficialWebsite = _prefixId.prefix "hasOfficialWebsite"
    /// <summary>
    ///   <para>dcterms:description : Tag commonly used to refer to the standard </para>
    ///   <para>rdfs:label : Has Tag^^xsd:string</para>
    ///   <a href="https://w3id.org/i40/sto#hasTag">sto:hasTag</a>
    /// </summary>
    let hasTag = _prefixId.prefix "hasTag"
    /// <summary>
    ///   <para>dcterms:description : Instance's Wikidata Entry</para>
    ///   <para>rdfs:label : Has Wikidata entity^^xsd:string</para>
    ///   <a href="https://w3id.org/i40/sto#hasWikidataEntity">sto:hasWikidataEntity</a>
    /// </summary>
    let hasWikidataEntity = _prefixId.prefix "hasWikidataEntity"
    /// <summary>
    ///   <para>dcterms:description : Instance's Wikipedia article</para>
    ///   <para>rdfs:label : Has Wikipedia article^^xsd:string</para>
    ///   <a href="https://w3id.org/i40/sto#hasWikipediaArticle">sto:hasWikipediaArticle</a>
    /// </summary>
    let hasWikipediaArticle = _prefixId.prefix "hasWikipediaArticle"
    /// <summary>
    ///   <para>dcterms:description : License under which a standard is published</para>
    ///   <para>rdfs:label : License^^xsd:string</para>
    ///   <a href="https://w3id.org/i40/sto#license">sto:license</a>
    /// </summary>
    let license = _prefixId.prefix "license"
    /// <summary>
    ///   <para>dcterms:description : A motivation for the creation of the standard</para>
    ///   <para>rdfs:label : motivation^^xsd:string</para>
    ///   <a href="https://w3id.org/i40/sto#motivation">sto:motivation</a>
    /// </summary>
    let motivation = _prefixId.prefix "motivation"
    /// <summary>
    ///   <para>dcterms:description : Name of the Organization</para>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/i40/sto#name">sto:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>dcterms:description : Norm under which the standard is published</para>
    ///   <para>rdfs:label : Norm^^xsd:string</para>
    ///   <a href="https://w3id.org/i40/sto#norm">sto:norm</a>
    /// </summary>
    let norm = _prefixId.prefix "norm"
    /// <summary>
    ///   <para>dcterms:description : A standard published by this organization</para>
    ///   <para>rdfs:label : Published^^xsd:string</para>
    ///   <a href="https://w3id.org/i40/sto#published">sto:published</a>
    /// </summary>
    let published = _prefixId.prefix "published"
    /// <summary>
    ///   <para>dcterms:description : The organization that published this Standard</para>
    ///   <para>rdfs:label : Publisher^^xsd:string</para>
    ///   <a href="https://w3id.org/i40/sto#publisher">sto:publisher</a>
    /// </summary>
    let publisher = _prefixId.prefix "publisher"
    /// <summary>
    ///   <para>dcterms:description : Property through to associate the standards with the RAMI level in which they are applicable</para>
    ///   <para>rdfs:label : RAMI Hierarchy Level</para>
    ///   <a href="https://w3id.org/i40/sto#ramiHierarchyLevel">sto:ramiHierarchyLevel</a>
    /// </summary>
    let ramiHierarchyLevel = _prefixId.prefix "ramiHierarchyLevel"
    /// <summary>
    ///   <para>dcterms:description : Both Standards are related</para>
    ///   <para>rdfs:label : Related to^^xsd:string</para>
    ///   <a href="https://w3id.org/i40/sto#relatedTo">sto:relatedTo</a>
    /// </summary>
    let relatedTo = _prefixId.prefix "relatedTo"
    /// <summary>
    ///   <para>dcterms:description : Property through which relate the standards with industry domains</para>
    ///   <para>rdfs:label : Scope</para>
    ///   <a href="https://w3id.org/i40/sto#scope">sto:scope</a>
    /// </summary>
    let scope = _prefixId.prefix "scope"

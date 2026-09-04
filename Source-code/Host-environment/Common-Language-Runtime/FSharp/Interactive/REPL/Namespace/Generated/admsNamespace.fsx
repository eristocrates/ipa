#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module adms =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/adms#" "adms"
    /// <summary>
    ///   <para>rdfs:label : Asset</para>
    ///   <para>rdfs:comment : An Asset is an abstract entity that reflects the intellectual content of the asset and represents those characteristics of the asset that are independent of its physical embodiment. This abstract entity combines the FRBR entities work (a distinct intellectual or artistic creation) and expression (the intellectual or artistic realization of a work). Assets can be versioned. Every time the intellectual content of an asset changes, the result is considered to be a new asset that can be linked to previous and next versions of the Asset. The physical embodiment of an Asset is called an Asset Distribution. A particular Asset may have zero or more Asset Distributions..</para>
    ///   <para>dcterms:identifier : adms:Asset^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/adms#Asset">adms:Asset</a>
    /// </summary>
    let Asset = _prefixId.prefix "Asset"
    /// <summary>
    ///   <para>rdfs:label : Asset Distribution</para>
    ///   <para>rdfs:comment : An Asset Distribution represents a particular physical embodiment of an Asset, which is an example of the FRBR entity manifestation (the physical embodiment of an expression of a work). An Asset Distribution is typically a downloadable computer file (but in principle it could also be a paper document) that implements the intellectual content of an Asset. A particular Asset Distribution is associated with one and only one Asset, while all Distributions of an Asset share the same intellectual content in different physical formats. Asset Distributions themselves are not versioned.</para>
    ///   <para>dcterms:identifier : adms:AssetDistribution^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/adms#AssetDistribution">adms:AssetDistribution</a>
    /// </summary>
    let AssetDistribution = _prefixId.prefix "AssetDistribution"
    /// <summary>
    ///   <para>rdfs:label : Asset Repository</para>
    ///   <para>rdfs:comment : An Asset Repository is a system or service that provides facilities for storage and maintenance of descriptions of Assets and Asset Distributions, and functionality that allows users to search and access these descriptions. An Asset Repository will typically contain descriptions of several Assets and related Asset Distributions.</para>
    ///   <para>dcterms:identifier : adms:AssetRepository^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/adms#AssetRepository">adms:AssetRepository</a>
    /// </summary>
    let AssetRepository = _prefixId.prefix "AssetRepository"
    /// <summary>
    ///   <para>rdfs:label : Identifier</para>
    ///   <para>rdfs:comment : This class is based on the UN/CEFACT Identifier complex type defined in See Section 5.8 of Core Components Data Type Catalogue Version 3.1 (http://www.unece.org/fileadmin/DAM/cefact/codesfortrade/CCTS/CCTS-DTCatalogueVersion3p1.pdf) In RDF this is expressed using the following properties: - the content string should be provided using skos:notation, datatyped with the identifier scheme (inclduing the version number if appropriate); - use dcterms:creator to link to a class describing the agency that manages the identifier scheme or adms:schemaAgency to provide the name as a literal. Although not part of the ADMS conceptual model, it may be useful to provide further properties to the Identifier class such as dcterms:created to provide the date on which the identifier was issued.^^rdf:XMLLiteral</para>
    ///   <para>dcterms:identifier : adms:Identifier^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/adms#Identifier">adms:Identifier</a>
    /// </summary>
    let Identifier = _prefixId.prefix "Identifier"
    /// <summary>
    ///   <para>rdfs:label : identifier</para>
    ///   <para>rdfs:comment : adms:identifier is used to link any resource to an instance of adms:Identifier which is its range. N.B. it is not appropriate to use dcterms:identifer to link to the Identifier class as its range is rdfs:Literal. ADMS uses this to provide any identifier for the Asset.</para>
    ///   <para>dcterms:identifier : adms:identifier^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/adms#identifier">adms:identifier</a>
    /// </summary>
    let identifier = _prefixId.prefix "identifier"
    /// <summary>
    ///   <para>rdfs:label : included asset</para>
    ///   <para>rdfs:comment : Links to an Asset that is contained in the Asset being described, e.g. when there are several vocabularies defined in a single document.</para>
    ///   <para>dcterms:identifier : adms:includedAsset^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/adms#includedAsset">adms:includedAsset</a>
    /// </summary>
    let includedAsset = _prefixId.prefix "includedAsset"
    /// <summary>
    ///   <para>rdfs:label : interoperability level</para>
    ///   <para>rdfs:comment : Links an Asset to its adms:InteroperabilityLevel. Since this is encoded using skos:Concept, that is the defined range for this property.</para>
    ///   <para>dcterms:identifier : adms:interoperabilityLevel^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/adms#interoperabilityLevel">adms:interoperabilityLevel</a>
    /// </summary>
    let interoperabilityLevel = _prefixId.prefix "interoperabilityLevel"
    /// <summary>
    ///   <para>rdfs:label : last</para>
    ///   <para>rdfs:comment : A link to the current or latest version of the Asset.</para>
    ///   <para>dcterms:identifier : adms:last^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/adms#last">adms:last</a>
    /// </summary>
    let last = _prefixId.prefix "last"
    /// <summary>
    ///   <para>rdfs:label : next</para>
    ///   <para>rdfs:comment : A link to the next version of the Asset.</para>
    ///   <para>dcterms:identifier : adms:next^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/adms#next">adms:next</a>
    /// </summary>
    let next = _prefixId.prefix "next"
    /// <summary>
    ///   <para>rdfs:label : prev</para>
    ///   <para>rdfs:comment : A link to the previous version of the Asset.</para>
    ///   <para>dcterms:identifier : adms:prev^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/adms#prev">adms:prev</a>
    /// </summary>
    let prev = _prefixId.prefix "prev"
    /// <summary>
    ///   <para>rdfs:label : representation technique</para>
    ///   <para>rdfs:comment : Links an adms:AssetDistribution to a skos:Concept that is its adms:RepresentationTechnique.</para>
    ///   <para>dcterms:identifier : adms:representationTechnique^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/adms#representationTechnique">adms:representationTechnique</a>
    /// </summary>
    let representationTechnique = _prefixId.prefix "representationTechnique"
    /// <summary>
    ///   <para>rdfs:label : sample</para>
    ///   <para>rdfs:comment : Links to a sample of an Asset (which is itself an Asset).</para>
    ///   <para>dcterms:identifier : adms:sample^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/adms#sample">adms:sample</a>
    /// </summary>
    let sample = _prefixId.prefix "sample"
    /// <summary>
    ///   <para>rdfs:label : scheme agency</para>
    ///   <para>rdfs:comment : The name of the agency responsible for issuing the identifier</para>
    ///   <para>dcterms:identifier : adms:schemeAgency^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/adms#schemeAgency">adms:schemeAgency</a>
    /// </summary>
    let schemeAgency = _prefixId.prefix "schemeAgency"
    /// <summary>
    ///   <para>rdfs:label : status</para>
    ///   <para>rdfs:comment : Links to the status of the Asset or Asset Distribution in the context of a particular workflow process. Since Status is defined using a skos:Concept, that is the defined range for this property.^^rdf:XMLLiteral</para>
    ///   <para>dcterms:identifier : adms:status^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/adms#status">adms:status</a>
    /// </summary>
    let status = _prefixId.prefix "status"
    /// <summary>
    ///   <para>rdfs:label : supported schema</para>
    ///   <para>rdfs:comment : A schema according to which the Asset Repository can provide data about its content, e.g. ADMS</para>
    ///   <para>dcterms:identifier : adms:supportedSchema^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/adms#supportedSchema">adms:supportedSchema</a>
    /// </summary>
    let supportedSchema = _prefixId.prefix "supportedSchema"
    /// <summary>
    ///   <para>rdfs:label : translation</para>
    ///   <para>rdfs:comment : Links Assets that are translations of each other.</para>
    ///   <para>dcterms:identifier : adms:translation^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/adms#translation">adms:translation</a>
    /// </summary>
    let translation = _prefixId.prefix "translation"
    /// <summary>
    ///   <para>rdfs:label : version info</para>
    ///   <para>rdfs:comment : A description of changes between this version and the previous version of the Asset.</para>
    ///   <para>dcterms:identifier : adms:versionNotes^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/adms#versionNotes">adms:versionNotes</a>
    /// </summary>
    let versionNotes = _prefixId.prefix "versionNotes"

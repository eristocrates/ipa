namespace http.www.w3.org.ns.adms.hash

open DoxAletheia

module adms =
    let _namespace_name = "http://www.w3.org/ns/adms#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An Asset is an abstract entity that reflects the intellectual content of the asset and represents those characteristics of the asset that are independent of its physical embodiment. This abstract entity combines the FRBR entities work (a distinct intellectual or artistic creation) and expression (the intellectual or artistic realization of a work). Assets can be versioned. Every time the intellectual content of an asset changes, the result is considered to be a new asset that can be linked to previous and next versions of the Asset. The physical embodiment of an Asset is called an Asset Distribution. A particular Asset may have zero or more Asset Distributions..
    /// <see href="http://www.w3.org/ns/adms#Asset"></see></summary>
    let Asset = _prefix "Asset"
    /// <summary>
    /// An Asset Distribution represents a particular physical embodiment of an Asset, which is an example of the FRBR entity manifestation (the physical embodiment of an expression of a work). An Asset Distribution is typically a downloadable computer file (but in principle it could also be a paper document) that implements the intellectual content of an Asset. A particular Asset Distribution is associated with one and only one Asset, while all Distributions of an Asset share the same intellectual content in different physical formats. Asset Distributions themselves are not versioned.
    /// <see href="http://www.w3.org/ns/adms#AssetDistribution"></see></summary>
    let AssetDistribution = _prefix "AssetDistribution"
    /// <summary>
    /// An Asset Repository is a system or service that provides facilities for storage and maintenance of descriptions of Assets and Asset Distributions, and functionality that allows users to search and access these descriptions. An Asset Repository will typically contain descriptions of several Assets and related Asset Distributions.
    /// <see href="http://www.w3.org/ns/adms#AssetRepository"></see></summary>
    let AssetRepository = _prefix "AssetRepository"
    /// <summary>
    /// This class is based on the UN/CEFACT Identifier complex type defined in See Section 5.8 of Core Components Data Type Catalogue Version 3.1 (http://www.unece.org/fileadmin/DAM/cefact/codesfortrade/CCTS/CCTS-DTCatalogueVersion3p1.pdf) In RDF this is expressed using the following properties: - the content string should be provided using skos:notation, datatyped with the identifier scheme (inclduing the version number if appropriate); - use dcterms:creator to link to a class describing the agency that manages the identifier scheme or adms:schemaAgency to provide the name as a literal. Although not part of the ADMS conceptual model, it may be useful to provide further properties to the Identifier class such as dcterms:created to provide the date on which the identifier was issued.
    /// <see href="http://www.w3.org/ns/adms#Identifier"></see></summary>
    let Identifier = _prefix "Identifier"
    /// <summary>
    /// adms:identifier is used to link any resource to an instance of adms:Identifier which is its range. N.B. it is not appropriate to use dcterms:identifer to link to the Identifier class as its range is rdfs:Literal. ADMS uses this to provide any identifier for the Asset.
    /// <see href="http://www.w3.org/ns/adms#identifier"></see></summary>
    let identifier = _prefix "identifier"
    /// <summary>
    /// Links to an Asset that is contained in the Asset being described, e.g. when there are several vocabularies defined in a single document.
    /// <see href="http://www.w3.org/ns/adms#includedAsset"></see></summary>
    let includedAsset = _prefix "includedAsset"
    /// <summary>
    /// Links an Asset to its adms:InteroperabilityLevel. Since this is encoded using skos:Concept, that is the defined range for this property.
    /// <see href="http://www.w3.org/ns/adms#interoperabilityLevel"></see></summary>
    let interoperabilityLevel = _prefix "interoperabilityLevel"
    /// <summary>
    /// A link to the current or latest version of the Asset.
    /// <see href="http://www.w3.org/ns/adms#last"></see></summary>
    let last = _prefix "last"
    /// <summary>
    /// A link to the next version of the Asset.
    /// <see href="http://www.w3.org/ns/adms#next"></see></summary>
    let next = _prefix "next"
    /// <summary>
    /// A link to the previous version of the Asset.
    /// <see href="http://www.w3.org/ns/adms#prev"></see></summary>
    let prev = _prefix "prev"
    /// <summary>
    /// Links an adms:AssetDistribution to a skos:Concept that is its adms:RepresentationTechnique.
    /// <see href="http://www.w3.org/ns/adms#representationTechnique"></see></summary>
    let representationTechnique = _prefix "representationTechnique"
    /// <summary>
    /// Links to a sample of an Asset (which is itself an Asset).
    /// <see href="http://www.w3.org/ns/adms#sample"></see></summary>
    let sample = _prefix "sample"
    /// <summary>
    /// The name of the agency responsible for issuing the identifier
    /// <see href="http://www.w3.org/ns/adms#schemeAgency"></see></summary>
    let schemeAgency = _prefix "schemeAgency"
    /// <summary>
    /// Links to the status of the Asset or Asset Distribution in the context of a particular workflow process. Since Status is defined using a skos:Concept, that is the defined range for this property.
    /// <see href="http://www.w3.org/ns/adms#status"></see></summary>
    let status = _prefix "status"
    /// <summary>
    /// A schema according to which the Asset Repository can provide data about its content, e.g. ADMS
    /// <see href="http://www.w3.org/ns/adms#supportedSchema"></see></summary>
    let supportedSchema = _prefix "supportedSchema"
    /// <summary>
    /// Links Assets that are translations of each other.
    /// <see href="http://www.w3.org/ns/adms#translation"></see></summary>
    let translation = _prefix "translation"
    /// <summary>
    /// A description of changes between this version and the previous version of the Asset.
    /// <see href="http://www.w3.org/ns/adms#versionNotes"></see></summary>
    let versionNotes = _prefix "versionNotes"

namespace http.www.w3.org.ns.adms.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module adms =
    let _namespace_iri = Namespace_Iri adms |> NamespaceIRI

    /// <summary>
    ///   <para>adms:representationTechnique</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an adms:AssetDistribution to a skos:Concept that is its adms:RepresentationTechnique.</para>
    /// labels<para>representation technique</para></remarks>
    /// <seealso href="http://www.w3.org/ns/adms#representationTechnique">http://www.w3.org/ns/adms#representationTechnique</seealso>
    let representationTechnique =
        Prefixed_Name(adms, "representationTechnique") |> PrefixedName

    /// <summary>
    ///   <para>adms:AssetRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An Asset Repository is a system or service that provides facilities for storage and maintenance of descriptions of Assets and Asset Distributions, and functionality that allows users to search and access these descriptions. An Asset Repository will typically contain descriptions of several Assets and related Asset Distributions.</para>
    /// labels<para>Asset Repository</para></remarks>
    /// <seealso href="http://www.w3.org/ns/adms#AssetRepository">http://www.w3.org/ns/adms#AssetRepository</seealso>
    let AssetRepository = Prefixed_Name(adms, "AssetRepository") |> PrefixedName
    /// <summary>
    ///   <para>adms:Identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class is based on the UN/CEFACT Identifier complex type defined in See Section 5.8 of Core Components Data Type Catalogue Version 3.1 (http://www.unece.org/fileadmin/DAM/cefact/codesfortrade/CCTS/CCTS-DTCatalogueVersion3p1.pdf) In RDF this is expressed using the following properties: - the content string should be provided using skos:notation, datatyped with the identifier scheme (inclduing the version number if appropriate); - use dcterms:creator to link to a class describing the agency that manages the identifier scheme or adms:schemaAgency to provide the name as a literal. Although not part of the ADMS conceptual model, it may be useful to provide further properties to the Identifier class such as dcterms:created to provide the date on which the identifier was issued.</para>
    /// labels<para>Identifier</para></remarks>
    /// <seealso href="http://www.w3.org/ns/adms#Identifier">http://www.w3.org/ns/adms#Identifier</seealso>
    let Identifier = Prefixed_Name(adms, "Identifier") |> PrefixedName
    /// <summary>
    ///   <para>adms:includedAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Links to an Asset that is contained in the Asset being described, e.g. when there are several vocabularies defined in a single document.</para>
    /// labels<para>included asset</para></remarks>
    /// <seealso href="http://www.w3.org/ns/adms#includedAsset">http://www.w3.org/ns/adms#includedAsset</seealso>
    let includedAsset = Prefixed_Name(adms, "includedAsset") |> PrefixedName

    /// <summary>
    ///   <para>adms:interoperabilityLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Links an Asset to its adms:InteroperabilityLevel. Since this is encoded using skos:Concept, that is the defined range for this property.</para>
    /// labels<para>interoperability level</para></remarks>
    /// <seealso href="http://www.w3.org/ns/adms#interoperabilityLevel">http://www.w3.org/ns/adms#interoperabilityLevel</seealso>
    let interoperabilityLevel =
        Prefixed_Name(adms, "interoperabilityLevel") |> PrefixedName

    /// <summary>
    ///   <para>adms:Asset</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An Asset is an abstract entity that reflects the intellectual content of the asset and represents those characteristics of the asset that are independent of its physical embodiment. This abstract entity combines the FRBR entities work (a distinct intellectual or artistic creation) and expression (the intellectual or artistic realization of a work). Assets can be versioned. Every time the intellectual content of an asset changes, the result is considered to be a new asset that can be linked to previous and next versions of the Asset. The physical embodiment of an Asset is called an Asset Distribution. A particular Asset may have zero or more Asset Distributions..</para>
    /// labels<para>Asset</para></remarks>
    /// <seealso href="http://www.w3.org/ns/adms#Asset">http://www.w3.org/ns/adms#Asset</seealso>
    let Asset = Prefixed_Name(adms, "Asset") |> PrefixedName
    /// <summary>
    ///   <para>adms:AssetDistribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An Asset Distribution represents a particular physical embodiment of an Asset, which is an example of the FRBR entity manifestation (the physical embodiment of an expression of a work). An Asset Distribution is typically a downloadable computer file (but in principle it could also be a paper document) that implements the intellectual content of an Asset. A particular Asset Distribution is associated with one and only one Asset, while all Distributions of an Asset share the same intellectual content in different physical formats. Asset Distributions themselves are not versioned.</para>
    /// labels<para>Asset Distribution</para></remarks>
    /// <seealso href="http://www.w3.org/ns/adms#AssetDistribution">http://www.w3.org/ns/adms#AssetDistribution</seealso>
    let AssetDistribution = Prefixed_Name(adms, "AssetDistribution") |> PrefixedName
    /// <summary>
    ///   <para>adms:identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>adms:identifier is used to link any resource to an instance of adms:Identifier which is its range. N.B. it is not appropriate to use dcterms:identifer to link to the Identifier class as its range is rdfs:Literal. ADMS uses this to provide any identifier for the Asset.</para>
    /// labels<para>identifier</para></remarks>
    /// <seealso href="http://www.w3.org/ns/adms#identifier">http://www.w3.org/ns/adms#identifier</seealso>
    let identifier = Prefixed_Name(adms, "identifier") |> PrefixedName
    /// <summary>
    ///   <para>adms:sample</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links to a sample of an Asset (which is itself an Asset).</para>
    /// labels<para>sample</para></remarks>
    /// <seealso href="http://www.w3.org/ns/adms#sample">http://www.w3.org/ns/adms#sample</seealso>
    let sample = Prefixed_Name(adms, "sample") |> PrefixedName
    /// <summary>
    ///   <para>adms:status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Links to the status of the Asset or Asset Distribution in the context of a particular workflow process. Since Status is defined using a skos:Concept, that is the defined range for this property.</para>
    /// labels<para>status</para></remarks>
    /// <seealso href="http://www.w3.org/ns/adms#status">http://www.w3.org/ns/adms#status</seealso>
    let status = Prefixed_Name(adms, "status") |> PrefixedName
    /// <summary>
    ///   <para>adms:supportedSchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A schema according to which the Asset Repository can provide data about its content, e.g. ADMS</para>
    /// labels<para>supported schema</para></remarks>
    /// <seealso href="http://www.w3.org/ns/adms#supportedSchema">http://www.w3.org/ns/adms#supportedSchema</seealso>
    let supportedSchema = Prefixed_Name(adms, "supportedSchema") |> PrefixedName
    /// <summary>
    ///   <para>adms:versionNotes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A description of changes between this version and the previous version of the Asset.</para>
    /// labels<para>version info</para></remarks>
    /// <seealso href="http://www.w3.org/ns/adms#versionNotes">http://www.w3.org/ns/adms#versionNotes</seealso>
    let versionNotes = Prefixed_Name(adms, "versionNotes") |> PrefixedName
    /// <summary>
    ///   <para>adms:translation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Links Assets that are translations of each other.</para>
    /// labels<para>translation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/adms#translation">http://www.w3.org/ns/adms#translation</seealso>
    let translation = Prefixed_Name(adms, "translation") |> PrefixedName
    /// <summary>
    ///   <para>adms:last</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A link to the current or latest version of the Asset.</para>
    /// labels<para>last</para></remarks>
    /// <seealso href="http://www.w3.org/ns/adms#last">http://www.w3.org/ns/adms#last</seealso>
    let last = Prefixed_Name(adms, "last") |> PrefixedName
    /// <summary>
    ///   <para>adms:next</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A link to the next version of the Asset.</para>
    /// labels<para>next</para></remarks>
    /// <seealso href="http://www.w3.org/ns/adms#next">http://www.w3.org/ns/adms#next</seealso>
    let next = Prefixed_Name(adms, "next") |> PrefixedName
    /// <summary>
    ///   <para>adms:prev</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A link to the previous version of the Asset.</para>
    /// labels<para>prev</para></remarks>
    /// <seealso href="http://www.w3.org/ns/adms#prev">http://www.w3.org/ns/adms#prev</seealso>
    let prev = Prefixed_Name(adms, "prev") |> PrefixedName
    /// <summary>
    ///   <para>adms:schemeAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The name of the agency responsible for issuing the identifier</para>
    /// labels<para>scheme agency</para></remarks>
    /// <seealso href="http://www.w3.org/ns/adms#schemeAgency">http://www.w3.org/ns/adms#schemeAgency</seealso>
    let schemeAgency = Prefixed_Name(adms, "schemeAgency") |> PrefixedName

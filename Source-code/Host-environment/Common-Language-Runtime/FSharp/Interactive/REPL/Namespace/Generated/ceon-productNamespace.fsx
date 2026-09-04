#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``ceon-product`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://w3id.org/CEON/ontology/product/" "ceon-product"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Assembly Location^^xsd:string</para>
    ///   <para>rdfs:comment : The location where a physical object is assembled.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/AssemblyLocation">ceon-product:AssemblyLocation</a>
    /// </summary>
    let AssemblyLocation = _prefixId.prefix "AssemblyLocation"
    /// <summary>
    ///   <para>rdfs:label : Compliance^^xsd:string</para>
    ///   <para>rdfs:comment : Represents that something is compliant with some standard or has a received a certain certification.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/Compliance">ceon-product:Compliance</a>
    /// </summary>
    let Compliance = _prefixId.prefix "Compliance"
    /// <summary>
    ///   <para>rdfs:label : Composition^^xsd:string</para>
    ///   <para>rdfs:comment : A relation that represents a composing relation.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/Composition">ceon-product:Composition</a>
    /// </summary>
    let Composition = _prefixId.prefix "Composition"
    /// <summary>
    ///   <para>rdfs:label : ISO Compliance^^xsd:string</para>
    ///   <para>rdfs:comment : ISO compliance is a compliance issuing thay sth (e.g., organization's structure, business operations, practices or policies) follows a specific ISO standard.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/ISOCompliance">ceon-product:ISOCompliance</a>
    /// </summary>
    let ISOCompliance = _prefixId.prefix "ISOCompliance"
    /// <summary>
    ///   <para>rdfs:label : Item^^xsd:string</para>
    ///   <para>rdfs:comment : An item is a physical object put into a market for sale, i.e. corresponding to an individual of a product. The item can be a thing that grows naturally or produced through some chemical or manufacturing processes.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/Item">ceon-product:Item</a>
    /// </summary>
    let Item = _prefixId.prefix "Item"
    /// <summary>
    ///   <para>rdfs:label : Manufacture Location^^xsd:string</para>
    ///   <para>rdfs:comment : The location where a physical object is manufactured.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/ManufactureLocation">ceon-product:ManufactureLocation</a>
    /// </summary>
    let ManufactureLocation = _prefixId.prefix "ManufactureLocation"
    /// <summary>
    ///   <para>rdfs:label : Matter composition^^xsd:string</para>
    ///   <para>rdfs:comment : A product composition is the composed information of a product in terms of a specific component, in which such a component is also a matter.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/MatterComposition">ceon-product:MatterComposition</a>
    /// </summary>
    let MatterComposition = _prefixId.prefix "MatterComposition"
    /// <summary>
    ///   <para>rdfs:label : Origin Location^^xsd:string</para>
    ///   <para>rdfs:comment : The origin location of a physical object^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/OriginLocation">ceon-product:OriginLocation</a>
    /// </summary>
    let OriginLocation = _prefixId.prefix "OriginLocation"
    /// <summary>
    ///   <para>rdfs:comment : Physical-based object designed for or utilized with a purpose. A product can be, for example: goods of any type; hardware (e.g. engine mechanical part, spare parts, consumables); electrical or electronic hardware devices or components (e.g. computers, communication equipment and sensors); processed materials (e.g. lubricant, cement).^^xsd:stringrdfs:comment : Represents the common sense notion of a product, i.e. the abstract notion of a product type, which is a model that is used for manufacturing items of that product.^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : ISO 59004:2024 -3.2.2 product^^xsd:string</para>
    ///   <para>rdfs:label : Product^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/Product">ceon-product:Product</a>
    /// </summary>
    let Product = _prefixId.prefix "Product"
    /// <summary>
    ///   <para>rdfs:label : Product composition^^xsd:string</para>
    ///   <para>rdfs:comment : A product composition is the composed information of a product in terms of a specific component, in which such a component is also a product.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/ProductComposition">ceon-product:ProductComposition</a>
    /// </summary>
    let ProductComposition = _prefixId.prefix "ProductComposition"
    /// <summary>
    ///   <para>rdfs:label : Product Object Composition^^xsd:string</para>
    ///   <para>rdfs:comment : A product object composition is the composed information of a product object in terms of a specific component, in which such a component is also a product object.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/ProductObjectComposition">ceon-product:ProductObjectComposition</a>
    /// </summary>
    let ProductObjectComposition = _prefixId.prefix "ProductObjectComposition"
    /// <summary>
    ///   <para>rdfs:label : Production Location^^xsd:string</para>
    ///   <para>rdfs:comment : The production location of a physical object^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/ProductionLocation">ceon-product:ProductionLocation</a>
    /// </summary>
    let ProductionLocation = _prefixId.prefix "ProductionLocation"
    let REACH = _prefixId.prefix "REACH"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://environment.ec.europa.eu/topics/chemicals/reach-regulation_en^^xsd:string</para>
    ///   <para>rdfs:label : REACH Compliance^^xsd:string</para>
    ///   <para>rdfs:comment : REACH (Regulation on the registration, evaluation, authorisation and restriction of chemicals) compliance is a compliance issueing that the REACH regulation is satisfied.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/REACHCompliance">ceon-product:REACHCompliance</a>
    /// </summary>
    let REACHCompliance = _prefixId.prefix "REACHCompliance"
    /// <summary>
    ///   <para>rdfs:label : Regulation^^xsd:string</para>
    ///   <para>rdfs:comment : The rules or restrictions made or maintained by authorities.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/Regulation">ceon-product:Regulation</a>
    /// </summary>
    let Regulation = _prefixId.prefix "Regulation"
    let RoHS = _prefixId.prefix "RoHS"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://environment.ec.europa.eu/topics/waste-and-recycling/rohs-directive_en^^xsd:string</para>
    ///   <para>rdfs:label : RoHS Compliance^^xsd:string</para>
    ///   <para>rdfs:comment : RoHS (Restriction of Hazardous Substances in Electrical and Electronic Equipment) compliance is a compliance issuing that RoHS objectives are satisfied.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/RoHSCompliance">ceon-product:RoHSCompliance</a>
    /// </summary>
    let RoHSCompliance = _prefixId.prefix "RoHSCompliance"
    /// <summary>
    ///   <para>rdfs:label : Solution^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : ISO 59004:2024 - 3.2.1 solution^^xsd:string</para>
    ///   <para>rdfs:comment : Product or service, or a combination thereof, that fulfils a need of an interested party.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/Solution">ceon-product:Solution</a>
    /// </summary>
    let Solution = _prefixId.prefix "Solution"
    /// <summary>
    ///   <para>rdfs:label : Supplier Location^^xsd:string</para>
    ///   <para>rdfs:comment : The location of supplier of a product or item.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/SupplierLocation">ceon-product:SupplierLocation</a>
    /// </summary>
    let SupplierLocation = _prefixId.prefix "SupplierLocation"
    /// <summary>
    ///   <para>rdfs:label : associated with matter^^xsd:string</para>
    ///   <para>rdfs:comment : associatedWithMatter intends to represent the matter to which a matter compopsition information regards to.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/associatedWithMatter">ceon-product:associatedWithMatter</a>
    /// </summary>
    let associatedWithMatter = _prefixId.prefix "associatedWithMatter"
    /// <summary>
    ///   <para>rdfs:label : associated with product model^^xsd:string</para>
    ///   <para>rdfs:comment : associatedWithProductModel intends to represent the product model to which a product compopsition information regards to.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/associatedWithProductModel">ceon-product:associatedWithProductModel</a>
    /// </summary>
    let associatedWithProductModel = _prefixId.prefix "associatedWithProductModel"
    /// <summary>
    ///   <para>rdfs:label : associated with product object^^xsd:string</para>
    ///   <para>rdfs:comment : associatedWithProductObject intends to represent the item (product object) to which a product object compopsition information regards to.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/associatedWithProductObject">ceon-product:associatedWithProductObject</a>
    /// </summary>
    let associatedWithProductObject = _prefixId.prefix "associatedWithProductObject"
    /// <summary>
    ///   <para>rdfs:label : batch of products^^xsd:string</para>
    ///   <para>rdfs:comment : batchOfProduct intends to represent what is the model product of a batch of objects.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/batchOfProduct">ceon-product:batchOfProduct</a>
    /// </summary>
    let batchOfProduct = _prefixId.prefix "batchOfProduct"
    /// <summary>
    ///   <para>rdfs:label : compliance with^^xsd:string</para>
    ///   <para>rdfs:comment : Represents what the compliance is compliant with (e.g. a standard or regulation).^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/complianceWith">ceon-product:complianceWith</a>
    /// </summary>
    let complianceWith = _prefixId.prefix "complianceWith"
    /// <summary>
    ///   <para>rdfs:label : composition of^^xsd:string</para>
    ///   <para>rdfs:comment : Represents what the composition is a composition of (i.e., the product, the product object or matter that is broken down into its components).^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/compositionOf">ceon-product:compositionOf</a>
    /// </summary>
    let compositionOf = _prefixId.prefix "compositionOf"
    /// <summary>
    ///   <para>rdfs:label : composition quantity^^xsd:string</para>
    ///   <para>rdfs:comment : compositionQuantity represents the quantity of elements of a composition.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/compositionQuantity">ceon-product:compositionQuantity</a>
    /// </summary>
    let compositionQuantity = _prefixId.prefix "compositionQuantity"
    /// <summary>
    ///   <para>rdfs:label : Country of assembly^^xsd:string</para>
    ///   <para>rdfs:comment : Used to represent the country of assembly of a product or product object (item).^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/countryOfAssembly">ceon-product:countryOfAssembly</a>
    /// </summary>
    let countryOfAssembly = _prefixId.prefix "countryOfAssembly"
    /// <summary>
    ///   <para>rdfs:label : Country of manufacture^^xsd:string</para>
    ///   <para>rdfs:comment : Used to represent the country of manufacture of a product or product object (item).^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/countryOfManufacture">ceon-product:countryOfManufacture</a>
    /// </summary>
    let countryOfManufacture = _prefixId.prefix "countryOfManufacture"
    /// <summary>
    ///   <para>rdfs:label : Country of origin^^xsd:string</para>
    ///   <para>rdfs:comment : Used to represent the country of origin of a product or product object (item).^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/countryOfOrigin">ceon-product:countryOfOrigin</a>
    /// </summary>
    let countryOfOrigin = _prefixId.prefix "countryOfOrigin"
    /// <summary>
    ///   <para>rdfs:label : Country of production^^xsd:string</para>
    ///   <para>rdfs:comment : Used to represent the country of production of a product or product object (item).^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/countryOfProduction">ceon-product:countryOfProduction</a>
    /// </summary>
    let countryOfProduction = _prefixId.prefix "countryOfProduction"
    /// <summary>
    ///   <para>rdfs:label : has assembly location^^xsd:string</para>
    ///   <para>rdfs:comment : Used to represent the location of assembly of a product or product object (item).^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/hasAssemblyLocation">ceon-product:hasAssemblyLocation</a>
    /// </summary>
    let hasAssemblyLocation = _prefixId.prefix "hasAssemblyLocation"
    /// <summary>
    ///   <para>rdfs:label : has brand^^xsd:string</para>
    ///   <para>rdfs:comment : The brand name of a product.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/hasBrand">ceon-product:hasBrand</a>
    /// </summary>
    let hasBrand = _prefixId.prefix "hasBrand"
    /// <summary>
    ///   <para>rdfs:label : has certificate^^xsd:string</para>
    ///   <para>rdfs:comment : Link to the the certificate that certifies the compliance^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/hasCertificate">ceon-product:hasCertificate</a>
    /// </summary>
    let hasCertificate = _prefixId.prefix "hasCertificate"
    /// <summary>
    ///   <para>rdfs:label : has compliance^^xsd:string</para>
    ///   <para>rdfs:comment : Used to link something (e.g., product or process) to a compliance.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/hasCompliance">ceon-product:hasCompliance</a>
    /// </summary>
    let hasCompliance = _prefixId.prefix "hasCompliance"
    /// <summary>
    ///   <para>rdfs:label : has composition^^xsd:string</para>
    ///   <para>rdfs:comment : hasComposition intends to represent that a product model or physical object can have compostition information.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/hasComposition">ceon-product:hasComposition</a>
    /// </summary>
    let hasComposition = _prefixId.prefix "hasComposition"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://www.gs1.org/standards/id-keys/gtin^^xsd:string</para>
    ///   <para>rdfs:label : Global Trade Item Number (GTIN)^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/hasGlobalTradeItemNumber">ceon-product:hasGlobalTradeItemNumber</a>
    /// </summary>
    let hasGlobalTradeItemNumber = _prefixId.prefix "hasGlobalTradeItemNumber"
    /// <summary>
    ///   <para>rdfs:label : has manufacture location^^xsd:string</para>
    ///   <para>rdfs:comment : Used to represent the location of manufacturer of a product or product object (item).^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/hasManufacturerLocation">ceon-product:hasManufacturerLocation</a>
    /// </summary>
    let hasManufacturerLocation = _prefixId.prefix "hasManufacturerLocation"
    /// <summary>
    ///   <para>rdfs:label : has origin location^^xsd:string</para>
    ///   <para>rdfs:comment : Used to represent the location of origin of a product or product object (item).^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/hasOriginLocation">ceon-product:hasOriginLocation</a>
    /// </summary>
    let hasOriginLocation = _prefixId.prefix "hasOriginLocation"
    /// <summary>
    ///   <para>rdfs:label : has product component^^xsd:string</para>
    ///   <para>rdfs:comment : hasProductComponent intends to represent that a product can have other product components.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/hasProductComponent">ceon-product:hasProductComponent</a>
    /// </summary>
    let hasProductComponent = _prefixId.prefix "hasProductComponent"
    /// <summary>
    ///   <para>rdfs:label : product name^^xsd:string</para>
    ///   <para>rdfs:comment : The name of a product.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/hasProductName">ceon-product:hasProductName</a>
    /// </summary>
    let hasProductName = _prefixId.prefix "hasProductName"
    /// <summary>
    ///   <para>rdfs:label : has product object component^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/hasProductObjectComponent">ceon-product:hasProductObjectComponent</a>
    /// </summary>
    let hasProductObjectComponent = _prefixId.prefix "hasProductObjectComponent"
    /// <summary>
    ///   <para>rdfs:label : modelled by^^xsd:string</para>
    ///   <para>rdfs:comment : modelledBy intends to represent that product objects follow particular product models.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/modelledBy">ceon-product:modelledBy</a>
    /// </summary>
    let modelledBy = _prefixId.prefix "modelledBy"
    /// <summary>
    ///   <para>rdfs:label : production site^^xsd:string</para>
    ///   <para>rdfs:comment : The name of a production site location^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/product/productionSite">ceon-product:productionSite</a>
    /// </summary>
    let productionSite = _prefixId.prefix "productionSite"

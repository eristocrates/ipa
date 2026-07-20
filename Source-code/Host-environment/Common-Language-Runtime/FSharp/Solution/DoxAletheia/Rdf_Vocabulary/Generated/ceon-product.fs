namespace http.w3id.org.CEON.ontology.product.slash

open DoxAletheia

module ceon_product =
    let _namespace_name = "http://w3id.org/CEON/ontology/product/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/product/0.5/"></see>
    /// </summary>
    let ``_0.5/`` = _prefix "0.5/"
    /// <summary>
    /// The location where a physical object is assembled.
    /// <see href="http://w3id.org/CEON/ontology/product/AssemblyLocation"></see></summary>
    let AssemblyLocation = _prefix "AssemblyLocation"
    /// <summary>
    /// Used to represent the country of assembly of a product or product object (item).
    /// <see href="http://w3id.org/CEON/ontology/product/countryOfAssembly"></see></summary>
    let countryOfAssembly = _prefix "countryOfAssembly"
    /// <summary>
    /// Represents that something is compliant with some standard or has a received a certain certification.
    /// <see href="http://w3id.org/CEON/ontology/product/Compliance"></see></summary>
    let Compliance = _prefix "Compliance"
    /// <summary>
    /// A relation that represents a composing relation.
    /// <see href="http://w3id.org/CEON/ontology/product/Composition"></see></summary>
    let Composition = _prefix "Composition"
    /// <summary>
    /// ISO compliance is a compliance issuing thay sth (e.g., organization's structure, business operations, practices or policies) follows a specific ISO standard.
    /// <see href="http://w3id.org/CEON/ontology/product/ISOCompliance"></see></summary>
    let ISOCompliance = _prefix "ISOCompliance"
    /// <summary>
    /// An item is a physical object put into a market for sale, i.e. corresponding to an individual of a product. The item can be a thing that grows naturally or produced through some chemical or manufacturing processes.
    /// <see href="http://w3id.org/CEON/ontology/product/Item"></see></summary>
    let Item = _prefix "Item"
    /// <summary>
    /// modelledBy intends to represent that product objects follow particular product models.
    /// <see href="http://w3id.org/CEON/ontology/product/modelledBy"></see></summary>
    let modelledBy = _prefix "modelledBy"
    /// <summary>
    /// Physical-based object designed for or utilized with a purpose. A product can be, for example: goods of any type; hardware (e.g. engine mechanical part, spare parts, consumables); electrical or electronic hardware devices or components (e.g. computers, communication equipment and sensors); processed materials (e.g. lubricant, cement).
    /// Represents the common sense notion of a product, i.e. the abstract notion of a product type, which is a model that is used for manufacturing items of that product.
    /// <see href="http://w3id.org/CEON/ontology/product/Product"></see></summary>
    let Product = _prefix "Product"
    /// <summary>
    /// The location where a physical object is manufactured.
    /// <see href="http://w3id.org/CEON/ontology/product/ManufactureLocation"></see></summary>
    let ManufactureLocation = _prefix "ManufactureLocation"
    /// <summary>
    /// Used to represent the country of manufacture of a product or product object (item).
    /// <see href="http://w3id.org/CEON/ontology/product/countryOfManufacture"></see></summary>
    let countryOfManufacture = _prefix "countryOfManufacture"
    /// <summary>
    /// A product composition is the composed information of a product in terms of a specific component, in which such a component is also a matter.
    /// <see href="http://w3id.org/CEON/ontology/product/MatterComposition"></see></summary>
    let MatterComposition = _prefix "MatterComposition"
    /// <summary>
    /// associatedWithMatter intends to represent the matter to which a matter compopsition information regards to.
    /// <see href="http://w3id.org/CEON/ontology/product/associatedWithMatter"></see></summary>
    let associatedWithMatter = _prefix "associatedWithMatter"
    /// <summary>
    /// The origin location of a physical object
    /// <see href="http://w3id.org/CEON/ontology/product/OriginLocation"></see></summary>
    let OriginLocation = _prefix "OriginLocation"
    /// <summary>
    /// Used to represent the country of origin of a product or product object (item).
    /// <see href="http://w3id.org/CEON/ontology/product/countryOfOrigin"></see></summary>
    let countryOfOrigin = _prefix "countryOfOrigin"
    /// <summary>
    /// A product composition is the composed information of a product in terms of a specific component, in which such a component is also a product.
    /// <see href="http://w3id.org/CEON/ontology/product/ProductComposition"></see></summary>
    let ProductComposition = _prefix "ProductComposition"
    /// <summary>
    /// hasComposition intends to represent that a product model or physical object can have compostition information.
    /// <see href="http://w3id.org/CEON/ontology/product/hasComposition"></see></summary>
    let hasComposition = _prefix "hasComposition"
    /// <summary>
    /// Used to represent the location of assembly of a product or product object (item).
    /// <see href="http://w3id.org/CEON/ontology/product/hasAssemblyLocation"></see></summary>
    let hasAssemblyLocation = _prefix "hasAssemblyLocation"
    /// <summary>
    /// Used to represent the location of origin of a product or product object (item).
    /// <see href="http://w3id.org/CEON/ontology/product/hasOriginLocation"></see></summary>
    let hasOriginLocation = _prefix "hasOriginLocation"
    /// <summary>
    /// Product or service, or a combination thereof, that fulfils a need of an interested party.
    /// <see href="http://w3id.org/CEON/ontology/product/Solution"></see></summary>
    let Solution = _prefix "Solution"
    /// <summary>
    /// Used to represent the location of manufacturer of a product or product object (item).
    /// <see href="http://w3id.org/CEON/ontology/product/hasManufacturerLocation"></see></summary>
    let hasManufacturerLocation = _prefix "hasManufacturerLocation"
    /// <summary>
    /// associatedWithProductModel intends to represent the product model to which a product compopsition information regards to.
    /// <see href="http://w3id.org/CEON/ontology/product/associatedWithProductModel"></see></summary>
    let associatedWithProductModel = _prefix "associatedWithProductModel"
    /// <summary>
    /// A product object composition is the composed information of a product object in terms of a specific component, in which such a component is also a product object.
    /// <see href="http://w3id.org/CEON/ontology/product/ProductObjectComposition"></see></summary>
    let ProductObjectComposition = _prefix "ProductObjectComposition"
    /// <summary>
    /// associatedWithProductObject intends to represent the item (product object) to which a product object compopsition information regards to.
    /// <see href="http://w3id.org/CEON/ontology/product/associatedWithProductObject"></see></summary>
    let associatedWithProductObject = _prefix "associatedWithProductObject"
    /// <summary>
    /// The production location of a physical object
    /// <see href="http://w3id.org/CEON/ontology/product/ProductionLocation"></see></summary>
    let ProductionLocation = _prefix "ProductionLocation"
    /// <summary>
    /// Used to represent the country of production of a product or product object (item).
    /// <see href="http://w3id.org/CEON/ontology/product/countryOfProduction"></see></summary>
    let countryOfProduction = _prefix "countryOfProduction"
    /// <summary>
    /// The name of a production site location
    /// <see href="http://w3id.org/CEON/ontology/product/productionSite"></see></summary>
    let productionSite = _prefix "productionSite"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/product/REACH"></see>
    /// </summary>
    let REACH = _prefix "REACH"
    /// <summary>
    /// The rules or restrictions made or maintained by authorities.
    /// <see href="http://w3id.org/CEON/ontology/product/Regulation"></see></summary>
    let Regulation = _prefix "Regulation"
    /// <summary>
    /// REACH (Regulation on the registration, evaluation, authorisation and restriction of chemicals) compliance is a compliance issueing that the REACH regulation is satisfied.
    /// <see href="http://w3id.org/CEON/ontology/product/REACHCompliance"></see></summary>
    let REACHCompliance = _prefix "REACHCompliance"
    /// <summary>
    /// Represents what the compliance is compliant with (e.g. a standard or regulation).
    /// <see href="http://w3id.org/CEON/ontology/product/complianceWith"></see></summary>
    let complianceWith = _prefix "complianceWith"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/product/RoHS"></see>
    /// </summary>
    let RoHS = _prefix "RoHS"
    /// <summary>
    /// RoHS (Restriction of Hazardous Substances in Electrical and Electronic Equipment) compliance is a compliance issuing that RoHS objectives are satisfied.
    /// <see href="http://w3id.org/CEON/ontology/product/RoHSCompliance"></see></summary>
    let RoHSCompliance = _prefix "RoHSCompliance"
    /// <summary>
    /// The location of supplier of a product or item.
    /// <see href="http://w3id.org/CEON/ontology/product/SupplierLocation"></see></summary>
    let SupplierLocation = _prefix "SupplierLocation"
    /// <summary>
    /// batchOfProduct intends to represent what is the model product of a batch of objects.
    /// <see href="http://w3id.org/CEON/ontology/product/batchOfProduct"></see></summary>
    let batchOfProduct = _prefix "batchOfProduct"
    /// <summary>
    /// Represents what the composition is a composition of (i.e., the product, the product object or matter that is broken down into its components).
    /// <see href="http://w3id.org/CEON/ontology/product/compositionOf"></see></summary>
    let compositionOf = _prefix "compositionOf"
    /// <summary>
    /// compositionQuantity represents the quantity of elements of a composition.
    /// <see href="http://w3id.org/CEON/ontology/product/compositionQuantity"></see></summary>
    let compositionQuantity = _prefix "compositionQuantity"
    /// <summary>
    /// The brand name of a product.
    /// <see href="http://w3id.org/CEON/ontology/product/hasBrand"></see></summary>
    let hasBrand = _prefix "hasBrand"
    /// <summary>
    /// Link to the the certificate that certifies the compliance
    /// <see href="http://w3id.org/CEON/ontology/product/hasCertificate"></see></summary>
    let hasCertificate = _prefix "hasCertificate"
    /// <summary>
    /// Used to link something (e.g., product or process) to a compliance.
    /// <see href="http://w3id.org/CEON/ontology/product/hasCompliance"></see></summary>
    let hasCompliance = _prefix "hasCompliance"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/product/hasGlobalTradeItemNumber"></see>
    /// </summary>
    let hasGlobalTradeItemNumber = _prefix "hasGlobalTradeItemNumber"
    /// <summary>
    /// hasProductComponent intends to represent that a product can have other product components.
    /// <see href="http://w3id.org/CEON/ontology/product/hasProductComponent"></see></summary>
    let hasProductComponent = _prefix "hasProductComponent"
    /// <summary>
    /// The name of a product.
    /// <see href="http://w3id.org/CEON/ontology/product/hasProductName"></see></summary>
    let hasProductName = _prefix "hasProductName"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/product/hasProductObjectComponent"></see>
    /// </summary>
    let hasProductObjectComponent = _prefix "hasProductObjectComponent"

namespace http.w3id.org.CEON.ontology.product.slash

open DoxAletheia.Rdf_Vocabulary

module ceon_product =
    let _namespace_name = "http://w3id.org/CEON/ontology/product/"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/product/0.5/"></see>
    /// </summary>
    let ``_0.5/`` = Namespaced_IRI.parse _namespace_name "0.5/" |> NamespacedName

    /// <summary>
    /// The location where a physical object is assembled.
    /// <see href="http://w3id.org/CEON/ontology/product/AssemblyLocation"></see></summary>
    let AssemblyLocation =
        Namespaced_IRI.parse _namespace_name "AssemblyLocation" |> NamespacedName

    /// <summary>
    /// Used to represent the country of assembly of a product or product object (item).
    /// <see href="http://w3id.org/CEON/ontology/product/countryOfAssembly"></see></summary>
    let countryOfAssembly =
        Namespaced_IRI.parse _namespace_name "countryOfAssembly" |> NamespacedName

    /// <summary>
    /// Represents that something is compliant with some standard or has a received a certain certification.
    /// <see href="http://w3id.org/CEON/ontology/product/Compliance"></see></summary>
    let Compliance = Namespaced_IRI.parse _namespace_name "Compliance" |> NamespacedName

    /// <summary>
    /// A relation that represents a composing relation.
    /// <see href="http://w3id.org/CEON/ontology/product/Composition"></see></summary>
    let Composition =
        Namespaced_IRI.parse _namespace_name "Composition" |> NamespacedName

    /// <summary>
    /// ISO compliance is a compliance issuing thay sth (e.g., organization's structure, business operations, practices or policies) follows a specific ISO standard.
    /// <see href="http://w3id.org/CEON/ontology/product/ISOCompliance"></see></summary>
    let ISOCompliance =
        Namespaced_IRI.parse _namespace_name "ISOCompliance" |> NamespacedName

    /// <summary>
    /// An item is a physical object put into a market for sale, i.e. corresponding to an individual of a product. The item can be a thing that grows naturally or produced through some chemical or manufacturing processes.
    /// <see href="http://w3id.org/CEON/ontology/product/Item"></see></summary>
    let Item = Namespaced_IRI.parse _namespace_name "Item" |> NamespacedName
    /// <summary>
    /// modelledBy intends to represent that product objects follow particular product models.
    /// <see href="http://w3id.org/CEON/ontology/product/modelledBy"></see></summary>
    let modelledBy = Namespaced_IRI.parse _namespace_name "modelledBy" |> NamespacedName
    /// <summary>
    /// Physical-based object designed for or utilized with a purpose. A product can be, for example: goods of any type; hardware (e.g. engine mechanical part, spare parts, consumables); electrical or electronic hardware devices or components (e.g. computers, communication equipment and sensors); processed materials (e.g. lubricant, cement).
    /// Represents the common sense notion of a product, i.e. the abstract notion of a product type, which is a model that is used for manufacturing items of that product.
    /// <see href="http://w3id.org/CEON/ontology/product/Product"></see></summary>
    let Product = Namespaced_IRI.parse _namespace_name "Product" |> NamespacedName

    /// <summary>
    /// The location where a physical object is manufactured.
    /// <see href="http://w3id.org/CEON/ontology/product/ManufactureLocation"></see></summary>
    let ManufactureLocation =
        Namespaced_IRI.parse _namespace_name "ManufactureLocation" |> NamespacedName

    /// <summary>
    /// Used to represent the country of manufacture of a product or product object (item).
    /// <see href="http://w3id.org/CEON/ontology/product/countryOfManufacture"></see></summary>
    let countryOfManufacture =
        Namespaced_IRI.parse _namespace_name "countryOfManufacture" |> NamespacedName

    /// <summary>
    /// A product composition is the composed information of a product in terms of a specific component, in which such a component is also a matter.
    /// <see href="http://w3id.org/CEON/ontology/product/MatterComposition"></see></summary>
    let MatterComposition =
        Namespaced_IRI.parse _namespace_name "MatterComposition" |> NamespacedName

    /// <summary>
    /// associatedWithMatter intends to represent the matter to which a matter compopsition information regards to.
    /// <see href="http://w3id.org/CEON/ontology/product/associatedWithMatter"></see></summary>
    let associatedWithMatter =
        Namespaced_IRI.parse _namespace_name "associatedWithMatter" |> NamespacedName

    /// <summary>
    /// The origin location of a physical object
    /// <see href="http://w3id.org/CEON/ontology/product/OriginLocation"></see></summary>
    let OriginLocation =
        Namespaced_IRI.parse _namespace_name "OriginLocation" |> NamespacedName

    /// <summary>
    /// Used to represent the country of origin of a product or product object (item).
    /// <see href="http://w3id.org/CEON/ontology/product/countryOfOrigin"></see></summary>
    let countryOfOrigin =
        Namespaced_IRI.parse _namespace_name "countryOfOrigin" |> NamespacedName

    /// <summary>
    /// A product composition is the composed information of a product in terms of a specific component, in which such a component is also a product.
    /// <see href="http://w3id.org/CEON/ontology/product/ProductComposition"></see></summary>
    let ProductComposition =
        Namespaced_IRI.parse _namespace_name "ProductComposition" |> NamespacedName

    /// <summary>
    /// hasComposition intends to represent that a product model or physical object can have compostition information.
    /// <see href="http://w3id.org/CEON/ontology/product/hasComposition"></see></summary>
    let hasComposition =
        Namespaced_IRI.parse _namespace_name "hasComposition" |> NamespacedName

    /// <summary>
    /// Used to represent the location of assembly of a product or product object (item).
    /// <see href="http://w3id.org/CEON/ontology/product/hasAssemblyLocation"></see></summary>
    let hasAssemblyLocation =
        Namespaced_IRI.parse _namespace_name "hasAssemblyLocation" |> NamespacedName

    /// <summary>
    /// Used to represent the location of origin of a product or product object (item).
    /// <see href="http://w3id.org/CEON/ontology/product/hasOriginLocation"></see></summary>
    let hasOriginLocation =
        Namespaced_IRI.parse _namespace_name "hasOriginLocation" |> NamespacedName

    /// <summary>
    /// Product or service, or a combination thereof, that fulfils a need of an interested party.
    /// <see href="http://w3id.org/CEON/ontology/product/Solution"></see></summary>
    let Solution = Namespaced_IRI.parse _namespace_name "Solution" |> NamespacedName

    /// <summary>
    /// Used to represent the location of manufacturer of a product or product object (item).
    /// <see href="http://w3id.org/CEON/ontology/product/hasManufacturerLocation"></see></summary>
    let hasManufacturerLocation =
        Namespaced_IRI.parse _namespace_name "hasManufacturerLocation" |> NamespacedName

    /// <summary>
    /// associatedWithProductModel intends to represent the product model to which a product compopsition information regards to.
    /// <see href="http://w3id.org/CEON/ontology/product/associatedWithProductModel"></see></summary>
    let associatedWithProductModel =
        Namespaced_IRI.parse _namespace_name "associatedWithProductModel" |> NamespacedName

    /// <summary>
    /// A product object composition is the composed information of a product object in terms of a specific component, in which such a component is also a product object.
    /// <see href="http://w3id.org/CEON/ontology/product/ProductObjectComposition"></see></summary>
    let ProductObjectComposition =
        Namespaced_IRI.parse _namespace_name "ProductObjectComposition" |> NamespacedName

    /// <summary>
    /// associatedWithProductObject intends to represent the item (product object) to which a product object compopsition information regards to.
    /// <see href="http://w3id.org/CEON/ontology/product/associatedWithProductObject"></see></summary>
    let associatedWithProductObject =
        Namespaced_IRI.parse _namespace_name "associatedWithProductObject" |> NamespacedName

    /// <summary>
    /// The production location of a physical object
    /// <see href="http://w3id.org/CEON/ontology/product/ProductionLocation"></see></summary>
    let ProductionLocation =
        Namespaced_IRI.parse _namespace_name "ProductionLocation" |> NamespacedName

    /// <summary>
    /// Used to represent the country of production of a product or product object (item).
    /// <see href="http://w3id.org/CEON/ontology/product/countryOfProduction"></see></summary>
    let countryOfProduction =
        Namespaced_IRI.parse _namespace_name "countryOfProduction" |> NamespacedName

    /// <summary>
    /// The name of a production site location
    /// <see href="http://w3id.org/CEON/ontology/product/productionSite"></see></summary>
    let productionSite =
        Namespaced_IRI.parse _namespace_name "productionSite" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/product/REACH"></see>
    /// </summary>
    let REACH = Namespaced_IRI.parse _namespace_name "REACH" |> NamespacedName
    /// <summary>
    /// The rules or restrictions made or maintained by authorities.
    /// <see href="http://w3id.org/CEON/ontology/product/Regulation"></see></summary>
    let Regulation = Namespaced_IRI.parse _namespace_name "Regulation" |> NamespacedName

    /// <summary>
    /// REACH (Regulation on the registration, evaluation, authorisation and restriction of chemicals) compliance is a compliance issueing that the REACH regulation is satisfied.
    /// <see href="http://w3id.org/CEON/ontology/product/REACHCompliance"></see></summary>
    let REACHCompliance =
        Namespaced_IRI.parse _namespace_name "REACHCompliance" |> NamespacedName

    /// <summary>
    /// Represents what the compliance is compliant with (e.g. a standard or regulation).
    /// <see href="http://w3id.org/CEON/ontology/product/complianceWith"></see></summary>
    let complianceWith =
        Namespaced_IRI.parse _namespace_name "complianceWith" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/product/RoHS"></see>
    /// </summary>
    let RoHS = Namespaced_IRI.parse _namespace_name "RoHS" |> NamespacedName

    /// <summary>
    /// RoHS (Restriction of Hazardous Substances in Electrical and Electronic Equipment) compliance is a compliance issuing that RoHS objectives are satisfied.
    /// <see href="http://w3id.org/CEON/ontology/product/RoHSCompliance"></see></summary>
    let RoHSCompliance =
        Namespaced_IRI.parse _namespace_name "RoHSCompliance" |> NamespacedName

    /// <summary>
    /// The location of supplier of a product or item.
    /// <see href="http://w3id.org/CEON/ontology/product/SupplierLocation"></see></summary>
    let SupplierLocation =
        Namespaced_IRI.parse _namespace_name "SupplierLocation" |> NamespacedName

    /// <summary>
    /// batchOfProduct intends to represent what is the model product of a batch of objects.
    /// <see href="http://w3id.org/CEON/ontology/product/batchOfProduct"></see></summary>
    let batchOfProduct =
        Namespaced_IRI.parse _namespace_name "batchOfProduct" |> NamespacedName

    /// <summary>
    /// Represents what the composition is a composition of (i.e., the product, the product object or matter that is broken down into its components).
    /// <see href="http://w3id.org/CEON/ontology/product/compositionOf"></see></summary>
    let compositionOf =
        Namespaced_IRI.parse _namespace_name "compositionOf" |> NamespacedName

    /// <summary>
    /// compositionQuantity represents the quantity of elements of a composition.
    /// <see href="http://w3id.org/CEON/ontology/product/compositionQuantity"></see></summary>
    let compositionQuantity =
        Namespaced_IRI.parse _namespace_name "compositionQuantity" |> NamespacedName

    /// <summary>
    /// The brand name of a product.
    /// <see href="http://w3id.org/CEON/ontology/product/hasBrand"></see></summary>
    let hasBrand = Namespaced_IRI.parse _namespace_name "hasBrand" |> NamespacedName

    /// <summary>
    /// Link to the the certificate that certifies the compliance
    /// <see href="http://w3id.org/CEON/ontology/product/hasCertificate"></see></summary>
    let hasCertificate =
        Namespaced_IRI.parse _namespace_name "hasCertificate" |> NamespacedName

    /// <summary>
    /// Used to link something (e.g., product or process) to a compliance.
    /// <see href="http://w3id.org/CEON/ontology/product/hasCompliance"></see></summary>
    let hasCompliance =
        Namespaced_IRI.parse _namespace_name "hasCompliance" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/product/hasGlobalTradeItemNumber"></see>
    /// </summary>
    let hasGlobalTradeItemNumber =
        Namespaced_IRI.parse _namespace_name "hasGlobalTradeItemNumber" |> NamespacedName

    /// <summary>
    /// hasProductComponent intends to represent that a product can have other product components.
    /// <see href="http://w3id.org/CEON/ontology/product/hasProductComponent"></see></summary>
    let hasProductComponent =
        Namespaced_IRI.parse _namespace_name "hasProductComponent" |> NamespacedName

    /// <summary>
    /// The name of a product.
    /// <see href="http://w3id.org/CEON/ontology/product/hasProductName"></see></summary>
    let hasProductName =
        Namespaced_IRI.parse _namespace_name "hasProductName" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/product/hasProductObjectComponent"></see>
    /// </summary>
    let hasProductObjectComponent =
        Namespaced_IRI.parse _namespace_name "hasProductObjectComponent" |> NamespacedName

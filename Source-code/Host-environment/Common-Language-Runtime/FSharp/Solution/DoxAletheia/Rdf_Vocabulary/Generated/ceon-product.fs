namespace http.w3id.org.CEON.ontology.product.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ceon_product =
    let _namespace_iri = Namespace_Iri ceon_product |> NamespaceIRI
    /// <summary>
    ///   <para>ceon:ontology/product/</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/">http://w3id.org/CEON/ontology/product/</seealso>
    let _prefix_iri = Prefixed_Name(ceon_product, "") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/product/0.5/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/0.5/">http://w3id.org/CEON/ontology/product/0.5/</seealso>
    let ``_0.5/`` = Prefixed_Name(ceon_product, "0.5/") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/product/AssemblyLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The location where a physical object is assembled."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Assembly Location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/AssemblyLocation">http://w3id.org/CEON/ontology/product/AssemblyLocation</seealso>
    let AssemblyLocation =
        Prefixed_Name(ceon_product, "AssemblyLocation") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/product/Compliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents that something is compliant with some standard or has a received a certain certification."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Compliance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/Compliance">http://w3id.org/CEON/ontology/product/Compliance</seealso>
    let Compliance = Prefixed_Name(ceon_product, "Compliance") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/product/Composition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A relation that represents a composing relation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Composition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/Composition">http://w3id.org/CEON/ontology/product/Composition</seealso>
    let Composition = Prefixed_Name(ceon_product, "Composition") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/product/ISOCompliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ISO compliance is a compliance issuing thay sth (e.g., organization's structure, business operations, practices or policies) follows a specific ISO standard."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ISO Compliance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/ISOCompliance">http://w3id.org/CEON/ontology/product/ISOCompliance</seealso>
    let ISOCompliance = Prefixed_Name(ceon_product, "ISOCompliance") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/product/Item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An item is a physical object put into a market for sale, i.e. corresponding to an individual of a product. The item can be a thing that grows naturally or produced through some chemical or manufacturing processes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Item"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/Item">http://w3id.org/CEON/ontology/product/Item</seealso>
    let Item = Prefixed_Name(ceon_product, "Item") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/product/ManufactureLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The location where a physical object is manufactured."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Manufacture Location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/ManufactureLocation">http://w3id.org/CEON/ontology/product/ManufactureLocation</seealso>
    let ManufactureLocation =
        Prefixed_Name(ceon_product, "ManufactureLocation") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/product/MatterComposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A product composition is the composed information of a product in terms of a specific component, in which such a component is also a matter."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Matter composition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/MatterComposition">http://w3id.org/CEON/ontology/product/MatterComposition</seealso>
    let MatterComposition =
        Prefixed_Name(ceon_product, "MatterComposition") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/product/OriginLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The origin location of a physical object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Origin Location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/OriginLocation">http://w3id.org/CEON/ontology/product/OriginLocation</seealso>
    let OriginLocation = Prefixed_Name(ceon_product, "OriginLocation") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/product/Product</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the common sense notion of a product, i.e. the abstract notion of a product type, which is a model that is used for manufacturing items of that product."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Physical-based object designed for or utilized with a purpose. A product can be, for example: goods of any type; hardware (e.g. engine mechanical part, spare parts, consumables); electrical or electronic hardware devices or components (e.g. computers, communication equipment and sensors); processed materials (e.g. lubricant, cement)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Product"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/Product">http://w3id.org/CEON/ontology/product/Product</seealso>
    let Product = Prefixed_Name(ceon_product, "Product") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/product/ProductComposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A product composition is the composed information of a product in terms of a specific component, in which such a component is also a product."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Product composition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/ProductComposition">http://w3id.org/CEON/ontology/product/ProductComposition</seealso>
    let ProductComposition =
        Prefixed_Name(ceon_product, "ProductComposition") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/product/ProductObjectComposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A product object composition is the composed information of a product object in terms of a specific component, in which such a component is also a product object."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Product Object Composition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/ProductObjectComposition">http://w3id.org/CEON/ontology/product/ProductObjectComposition</seealso>
    let ProductObjectComposition =
        Prefixed_Name(ceon_product, "ProductObjectComposition") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/product/ProductionLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The production location of a physical object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Production Location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/ProductionLocation">http://w3id.org/CEON/ontology/product/ProductionLocation</seealso>
    let ProductionLocation =
        Prefixed_Name(ceon_product, "ProductionLocation") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/product/REACH</para>
    /// </summary>
    /// <remarks>
    ///   <para>ceon:ontology/product/Regulation</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/REACH">http://w3id.org/CEON/ontology/product/REACH</seealso>
    let REACH = Prefixed_Name(ceon_product, "REACH") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/product/REACHCompliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"REACH (Regulation on the registration, evaluation, authorisation and restriction of chemicals) compliance is a compliance issueing that the REACH regulation is satisfied."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"REACH Compliance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/REACHCompliance">http://w3id.org/CEON/ontology/product/REACHCompliance</seealso>
    let REACHCompliance = Prefixed_Name(ceon_product, "REACHCompliance") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/product/Regulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The rules or restrictions made or maintained by authorities."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Regulation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/Regulation">http://w3id.org/CEON/ontology/product/Regulation</seealso>
    let Regulation = Prefixed_Name(ceon_product, "Regulation") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/product/RoHS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ceon:ontology/product/Regulation</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/RoHS">http://w3id.org/CEON/ontology/product/RoHS</seealso>
    let RoHS = Prefixed_Name(ceon_product, "RoHS") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/product/RoHSCompliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"RoHS (Restriction of Hazardous Substances in Electrical and Electronic Equipment) compliance is a compliance issuing that RoHS objectives are satisfied."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"RoHS Compliance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/RoHSCompliance">http://w3id.org/CEON/ontology/product/RoHSCompliance</seealso>
    let RoHSCompliance = Prefixed_Name(ceon_product, "RoHSCompliance") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/product/Solution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Product or service, or a combination thereof, that fulfils a need of an interested party."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Solution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/Solution">http://w3id.org/CEON/ontology/product/Solution</seealso>
    let Solution = Prefixed_Name(ceon_product, "Solution") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/product/SupplierLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The location of supplier of a product or item."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Supplier Location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/SupplierLocation">http://w3id.org/CEON/ontology/product/SupplierLocation</seealso>
    let SupplierLocation =
        Prefixed_Name(ceon_product, "SupplierLocation") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/product/associatedWithMatter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"associatedWithMatter intends to represent the matter to which a matter compopsition information regards to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"associated with matter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/associatedWithMatter">http://w3id.org/CEON/ontology/product/associatedWithMatter</seealso>
    let associatedWithMatter =
        Prefixed_Name(ceon_product, "associatedWithMatter") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/product/associatedWithProductModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"associatedWithProductModel intends to represent the product model to which a product compopsition information regards to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"associated with product model"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/associatedWithProductModel">http://w3id.org/CEON/ontology/product/associatedWithProductModel</seealso>
    let associatedWithProductModel =
        Prefixed_Name(ceon_product, "associatedWithProductModel") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/product/associatedWithProductObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"associatedWithProductObject intends to represent the item (product object) to which a product object compopsition information regards to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"associated with product object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/associatedWithProductObject">http://w3id.org/CEON/ontology/product/associatedWithProductObject</seealso>
    let associatedWithProductObject =
        Prefixed_Name(ceon_product, "associatedWithProductObject") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/product/batchOfProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"batchOfProduct intends to represent what is the model product of a batch of objects."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"batch of products"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/batchOfProduct">http://w3id.org/CEON/ontology/product/batchOfProduct</seealso>
    let batchOfProduct = Prefixed_Name(ceon_product, "batchOfProduct") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/product/complianceWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Represents what the compliance is compliant with (e.g. a standard or regulation)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"compliance with"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/complianceWith">http://w3id.org/CEON/ontology/product/complianceWith</seealso>
    let complianceWith = Prefixed_Name(ceon_product, "complianceWith") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/product/compositionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Represents what the composition is a composition of (i.e., the product, the product object or matter that is broken down into its components)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"composition of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/compositionOf">http://w3id.org/CEON/ontology/product/compositionOf</seealso>
    let compositionOf = Prefixed_Name(ceon_product, "compositionOf") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/product/compositionQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"compositionQuantity represents the quantity of elements of a composition."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"composition quantity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/compositionQuantity">http://w3id.org/CEON/ontology/product/compositionQuantity</seealso>
    let compositionQuantity =
        Prefixed_Name(ceon_product, "compositionQuantity") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/product/countryOfAssembly</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Used to represent the country of assembly of a product or product object (item)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Country of assembly"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/countryOfAssembly">http://w3id.org/CEON/ontology/product/countryOfAssembly</seealso>
    let countryOfAssembly =
        Prefixed_Name(ceon_product, "countryOfAssembly") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/product/countryOfManufacture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Used to represent the country of manufacture of a product or product object (item)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Country of manufacture"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/countryOfManufacture">http://w3id.org/CEON/ontology/product/countryOfManufacture</seealso>
    let countryOfManufacture =
        Prefixed_Name(ceon_product, "countryOfManufacture") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/product/countryOfOrigin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Used to represent the country of origin of a product or product object (item)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Country of origin"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/countryOfOrigin">http://w3id.org/CEON/ontology/product/countryOfOrigin</seealso>
    let countryOfOrigin = Prefixed_Name(ceon_product, "countryOfOrigin") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/product/countryOfProduction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Used to represent the country of production of a product or product object (item)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Country of production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/countryOfProduction">http://w3id.org/CEON/ontology/product/countryOfProduction</seealso>
    let countryOfProduction =
        Prefixed_Name(ceon_product, "countryOfProduction") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/product/hasAssemblyLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Used to represent the location of assembly of a product or product object (item)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has assembly location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/hasAssemblyLocation">http://w3id.org/CEON/ontology/product/hasAssemblyLocation</seealso>
    let hasAssemblyLocation =
        Prefixed_Name(ceon_product, "hasAssemblyLocation") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/product/hasBrand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The brand name of a product."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has brand"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/hasBrand">http://w3id.org/CEON/ontology/product/hasBrand</seealso>
    let hasBrand = Prefixed_Name(ceon_product, "hasBrand") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/product/hasCertificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Link to the the certificate that certifies the compliance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has certificate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/hasCertificate">http://w3id.org/CEON/ontology/product/hasCertificate</seealso>
    let hasCertificate = Prefixed_Name(ceon_product, "hasCertificate") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/product/hasCompliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Used to link something (e.g., product or process) to a compliance."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has compliance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/hasCompliance">http://w3id.org/CEON/ontology/product/hasCompliance</seealso>
    let hasCompliance = Prefixed_Name(ceon_product, "hasCompliance") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/product/hasComposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"hasComposition intends to represent that a product model or physical object can have compostition information."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has composition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/hasComposition">http://w3id.org/CEON/ontology/product/hasComposition</seealso>
    let hasComposition = Prefixed_Name(ceon_product, "hasComposition") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/product/hasGlobalTradeItemNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Global Trade Item Number (GTIN)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/hasGlobalTradeItemNumber">http://w3id.org/CEON/ontology/product/hasGlobalTradeItemNumber</seealso>
    let hasGlobalTradeItemNumber =
        Prefixed_Name(ceon_product, "hasGlobalTradeItemNumber") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/product/hasManufacturerLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Used to represent the location of manufacturer of a product or product object (item)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has manufacture location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/hasManufacturerLocation">http://w3id.org/CEON/ontology/product/hasManufacturerLocation</seealso>
    let hasManufacturerLocation =
        Prefixed_Name(ceon_product, "hasManufacturerLocation") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/product/hasOriginLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Used to represent the location of origin of a product or product object (item)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has origin location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/hasOriginLocation">http://w3id.org/CEON/ontology/product/hasOriginLocation</seealso>
    let hasOriginLocation =
        Prefixed_Name(ceon_product, "hasOriginLocation") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/product/hasProductComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"hasProductComponent intends to represent that a product can have other product components."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has product component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/hasProductComponent">http://w3id.org/CEON/ontology/product/hasProductComponent</seealso>
    let hasProductComponent =
        Prefixed_Name(ceon_product, "hasProductComponent") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/product/hasProductName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The name of a product."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"product name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/hasProductName">http://w3id.org/CEON/ontology/product/hasProductName</seealso>
    let hasProductName = Prefixed_Name(ceon_product, "hasProductName") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/product/hasProductObjectComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has product object component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/hasProductObjectComponent">http://w3id.org/CEON/ontology/product/hasProductObjectComponent</seealso>
    let hasProductObjectComponent =
        Prefixed_Name(ceon_product, "hasProductObjectComponent") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/product/modelledBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"modelledBy intends to represent that product objects follow particular product models."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"modelled by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/modelledBy">http://w3id.org/CEON/ontology/product/modelledBy</seealso>
    let modelledBy = Prefixed_Name(ceon_product, "modelledBy") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/product/productionSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The name of a production site location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"production site"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/product/productionSite">http://w3id.org/CEON/ontology/product/productionSite</seealso>
    let productionSite = Prefixed_Name(ceon_product, "productionSite") |> PrefixedName

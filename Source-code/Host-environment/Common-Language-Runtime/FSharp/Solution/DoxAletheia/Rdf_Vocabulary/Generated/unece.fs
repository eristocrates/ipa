namespace http.unece.org.vocab.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module unece =
    let _namespace_iri = Namespace_Iri unece |> NamespaceIRI
    /// <summary>
    ///   <para>unece:AmountType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#AmountType">http://unece.org/vocab#AmountType</seealso>
    let AmountType = Prefixed_Name(unece, "AmountType") |> PrefixedName

    /// <summary>
    ///   <para>unece:ApplicableCertificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#ApplicableCertificate">http://unece.org/vocab#ApplicableCertificate</seealso>
    let ApplicableCertificate =
        Prefixed_Name(unece, "ApplicableCertificate") |> PrefixedName

    /// <summary>
    ///   <para>unece:BillingAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#BillingAddress">http://unece.org/vocab#BillingAddress</seealso>
    let BillingAddress = Prefixed_Name(unece, "BillingAddress") |> PrefixedName
    /// <summary>
    ///   <para>unece:BrandName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#BrandName">http://unece.org/vocab#BrandName</seealso>
    let BrandName = Prefixed_Name(unece, "BrandName") |> PrefixedName

    /// <summary>
    ///   <para>unece:CertificateIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#CertificateIdentifier">http://unece.org/vocab#CertificateIdentifier</seealso>
    let CertificateIdentifier =
        Prefixed_Name(unece, "CertificateIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>unece:Country</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#Country">http://unece.org/vocab#Country</seealso>
    let Country = Prefixed_Name(unece, "Country") |> PrefixedName
    /// <summary>
    ///   <para>unece:DespatchLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#DespatchLocation">http://unece.org/vocab#DespatchLocation</seealso>
    let DespatchLocation = Prefixed_Name(unece, "DespatchLocation") |> PrefixedName

    /// <summary>
    ///   <para>unece:EffectiveEndDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#EffectiveEndDateTime">http://unece.org/vocab#EffectiveEndDateTime</seealso>
    let EffectiveEndDateTime =
        Prefixed_Name(unece, "EffectiveEndDateTime") |> PrefixedName

    /// <summary>
    ///   <para>unece:ElectronicDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#ElectronicDocument">http://unece.org/vocab#ElectronicDocument</seealso>
    let ElectronicDocument = Prefixed_Name(unece, "ElectronicDocument") |> PrefixedName
    /// <summary>
    ///   <para>unece:FinancialCard</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#FinancialCard">http://unece.org/vocab#FinancialCard</seealso>
    let FinancialCard = Prefixed_Name(unece, "FinancialCard") |> PrefixedName

    /// <summary>
    ///   <para>unece:GeographicalCoordinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#GeographicalCoordinate">http://unece.org/vocab#GeographicalCoordinate</seealso>
    let GeographicalCoordinate =
        Prefixed_Name(unece, "GeographicalCoordinate") |> PrefixedName

    /// <summary>
    ///   <para>unece:IncludedConsignmentItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#IncludedConsignmentItem">http://unece.org/vocab#IncludedConsignmentItem</seealso>
    let IncludedConsignmentItem =
        Prefixed_Name(unece, "IncludedConsignmentItem") |> PrefixedName

    /// <summary>
    ///   <para>unece:InspectionDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#InspectionDateTime">http://unece.org/vocab#InspectionDateTime</seealso>
    let InspectionDateTime = Prefixed_Name(unece, "InspectionDateTime") |> PrefixedName
    /// <summary>
    ///   <para>unece:Invoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#Invoice">http://unece.org/vocab#Invoice</seealso>
    let Invoice = Prefixed_Name(unece, "Invoice") |> PrefixedName
    /// <summary>
    ///   <para>unece:LineItemIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#LineItemIdentifier">http://unece.org/vocab#LineItemIdentifier</seealso>
    let LineItemIdentifier = Prefixed_Name(unece, "LineItemIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>unece:LineTradeAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#LineTradeAgreement">http://unece.org/vocab#LineTradeAgreement</seealso>
    let LineTradeAgreement = Prefixed_Name(unece, "LineTradeAgreement") |> PrefixedName
    /// <summary>
    ///   <para>unece:ModelName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#ModelName">http://unece.org/vocab#ModelName</seealso>
    let ModelName = Prefixed_Name(unece, "ModelName") |> PrefixedName
    /// <summary>
    ///   <para>unece:Offer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#Offer">http://unece.org/vocab#Offer</seealso>
    let Offer = Prefixed_Name(unece, "Offer") |> PrefixedName
    /// <summary>
    ///   <para>unece:Order</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#Order">http://unece.org/vocab#Order</seealso>
    let Order = Prefixed_Name(unece, "Order") |> PrefixedName
    /// <summary>
    ///   <para>unece:OrderDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#OrderDate">http://unece.org/vocab#OrderDate</seealso>
    let OrderDate = Prefixed_Name(unece, "OrderDate") |> PrefixedName
    /// <summary>
    ///   <para>unece:OrderIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#OrderIdentifier">http://unece.org/vocab#OrderIdentifier</seealso>
    let OrderIdentifier = Prefixed_Name(unece, "OrderIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>unece:PaymentDueDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#PaymentDueDate">http://unece.org/vocab#PaymentDueDate</seealso>
    let PaymentDueDate = Prefixed_Name(unece, "PaymentDueDate") |> PrefixedName
    /// <summary>
    ///   <para>unece:PaymentMeans</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#PaymentMeans">http://unece.org/vocab#PaymentMeans</seealso>
    let PaymentMeans = Prefixed_Name(unece, "PaymentMeans") |> PrefixedName
    /// <summary>
    ///   <para>unece:PaymentMeansID</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#PaymentMeansID">http://unece.org/vocab#PaymentMeansID</seealso>
    let PaymentMeansID = Prefixed_Name(unece, "PaymentMeansID") |> PrefixedName
    /// <summary>
    ///   <para>unece:PriceTypeCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#PriceTypeCode">http://unece.org/vocab#PriceTypeCode</seealso>
    let PriceTypeCode = Prefixed_Name(unece, "PriceTypeCode") |> PrefixedName
    /// <summary>
    ///   <para>unece:ProcessingCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#ProcessingCountry">http://unece.org/vocab#ProcessingCountry</seealso>
    let ProcessingCountry = Prefixed_Name(unece, "ProcessingCountry") |> PrefixedName

    /// <summary>
    ///   <para>unece:ProductAvailabilityDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#ProductAvailabilityDate">http://unece.org/vocab#ProductAvailabilityDate</seealso>
    let ProductAvailabilityDate =
        Prefixed_Name(unece, "ProductAvailabilityDate") |> PrefixedName

    /// <summary>
    ///   <para>unece:ProductionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#ProductionDate">http://unece.org/vocab#ProductionDate</seealso>
    let ProductionDate = Prefixed_Name(unece, "ProductionDate") |> PrefixedName
    /// <summary>
    ///   <para>unece:PromotionalMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#PromotionalMessage">http://unece.org/vocab#PromotionalMessage</seealso>
    let PromotionalMessage = Prefixed_Name(unece, "PromotionalMessage") |> PrefixedName
    /// <summary>
    ///   <para>unece:ReferencedOrder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#ReferencedOrder">http://unece.org/vocab#ReferencedOrder</seealso>
    let ReferencedOrder = Prefixed_Name(unece, "ReferencedOrder") |> PrefixedName
    /// <summary>
    ///   <para>unece:RelatedProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#RelatedProduct">http://unece.org/vocab#RelatedProduct</seealso>
    let RelatedProduct = Prefixed_Name(unece, "RelatedProduct") |> PrefixedName

    /// <summary>
    ///   <para>unece:RequestForQuotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#RequestForQuotation">http://unece.org/vocab#RequestForQuotation</seealso>
    let RequestForQuotation =
        Prefixed_Name(unece, "RequestForQuotation") |> PrefixedName

    /// <summary>
    ///   <para>unece:Seller</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#Seller">http://unece.org/vocab#Seller</seealso>
    let Seller = Prefixed_Name(unece, "Seller") |> PrefixedName
    /// <summary>
    ///   <para>unece:SerialId</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#SerialId">http://unece.org/vocab#SerialId</seealso>
    let SerialId = Prefixed_Name(unece, "SerialId") |> PrefixedName
    /// <summary>
    ///   <para>unece:ServiceProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#ServiceProvider">http://unece.org/vocab#ServiceProvider</seealso>
    let ServiceProvider = Prefixed_Name(unece, "ServiceProvider") |> PrefixedName
    /// <summary>
    ///   <para>unece:ShipToAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#ShipToAddress">http://unece.org/vocab#ShipToAddress</seealso>
    let ShipToAddress = Prefixed_Name(unece, "ShipToAddress") |> PrefixedName

    /// <summary>
    ///   <para>unece:SpecifiedCertificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#SpecifiedCertificate">http://unece.org/vocab#SpecifiedCertificate</seealso>
    let SpecifiedCertificate =
        Prefixed_Name(unece, "SpecifiedCertificate") |> PrefixedName

    /// <summary>
    ///   <para>unece:SpecifiedTradeProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#SpecifiedTradeProduct">http://unece.org/vocab#SpecifiedTradeProduct</seealso>
    let SpecifiedTradeProduct =
        Prefixed_Name(unece, "SpecifiedTradeProduct") |> PrefixedName

    /// <summary>
    ///   <para>unece:SubstituteProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#SubstituteProduct">http://unece.org/vocab#SubstituteProduct</seealso>
    let SubstituteProduct = Prefixed_Name(unece, "SubstituteProduct") |> PrefixedName
    /// <summary>
    ///   <para>unece:TradeAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#TradeAddress">http://unece.org/vocab#TradeAddress</seealso>
    let TradeAddress = Prefixed_Name(unece, "TradeAddress") |> PrefixedName
    /// <summary>
    ///   <para>unece:TradeProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#TradeProduct">http://unece.org/vocab#TradeProduct</seealso>
    let TradeProduct = Prefixed_Name(unece, "TradeProduct") |> PrefixedName
    /// <summary>
    ///   <para>unece:TransportMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#TransportMethod">http://unece.org/vocab#TransportMethod</seealso>
    let TransportMethod = Prefixed_Name(unece, "TransportMethod") |> PrefixedName
    /// <summary>
    ///   <para>unece:billingPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#billingPeriod">http://unece.org/vocab#billingPeriod</seealso>
    let billingPeriod = Prefixed_Name(unece, "billingPeriod") |> PrefixedName
    /// <summary>
    ///   <para>unece:brandName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#brandName">http://unece.org/vocab#brandName</seealso>
    let brandName = Prefixed_Name(unece, "brandName") |> PrefixedName
    /// <summary>
    ///   <para>unece:colourDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#colourDescription">http://unece.org/vocab#colourDescription</seealso>
    let colourDescription = Prefixed_Name(unece, "colourDescription") |> PrefixedName
    /// <summary>
    ///   <para>unece:dUNSId</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#dUNSId">http://unece.org/vocab#dUNSId</seealso>
    let dUNSId = Prefixed_Name(unece, "dUNSId") |> PrefixedName

    /// <summary>
    ///   <para>unece:finalAssemblyCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#finalAssemblyCountry">http://unece.org/vocab#finalAssemblyCountry</seealso>
    let finalAssemblyCountry =
        Prefixed_Name(unece, "finalAssemblyCountry") |> PrefixedName

    /// <summary>
    ///   <para>unece:gLNId</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#gLNId">http://unece.org/vocab#gLNId</seealso>
    let gLNId = Prefixed_Name(unece, "gLNId") |> PrefixedName
    /// <summary>
    ///   <para>unece:gTINId</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#gTINId">http://unece.org/vocab#gTINId</seealso>
    let gTINId = Prefixed_Name(unece, "gTINId") |> PrefixedName

    /// <summary>
    ///   <para>unece:logoReferencedDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#logoReferencedDocument">http://unece.org/vocab#logoReferencedDocument</seealso>
    let logoReferencedDocument =
        Prefixed_Name(unece, "logoReferencedDocument") |> PrefixedName

    /// <summary>
    ///   <para>unece:manufacturerAssignedId</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#manufacturerAssignedId">http://unece.org/vocab#manufacturerAssignedId</seealso>
    let manufacturerAssignedId =
        Prefixed_Name(unece, "manufacturerAssignedId") |> PrefixedName

    /// <summary>
    ///   <para>unece:manufacturerParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#manufacturerParty">http://unece.org/vocab#manufacturerParty</seealso>
    let manufacturerParty = Prefixed_Name(unece, "manufacturerParty") |> PrefixedName
    /// <summary>
    ///   <para>unece:nSNId</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#nSNId">http://unece.org/vocab#nSNId</seealso>
    let nSNId = Prefixed_Name(unece, "nSNId") |> PrefixedName
    /// <summary>
    ///   <para>unece:orderQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#orderQuantity">http://unece.org/vocab#orderQuantity</seealso>
    let orderQuantity = Prefixed_Name(unece, "orderQuantity") |> PrefixedName
    /// <summary>
    ///   <para>unece:originCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#originCountry">http://unece.org/vocab#originCountry</seealso>
    let originCountry = Prefixed_Name(unece, "originCountry") |> PrefixedName
    /// <summary>
    ///   <para>unece:postOfficeBox</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#postOfficeBox">http://unece.org/vocab#postOfficeBox</seealso>
    let postOfficeBox = Prefixed_Name(unece, "postOfficeBox") |> PrefixedName
    /// <summary>
    ///   <para>unece:postcodeCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#postcodeCode">http://unece.org/vocab#postcodeCode</seealso>
    let postcodeCode = Prefixed_Name(unece, "postcodeCode") |> PrefixedName

    /// <summary>
    ///   <para>unece:printDesignDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#printDesignDescription">http://unece.org/vocab#printDesignDescription</seealso>
    let printDesignDescription =
        Prefixed_Name(unece, "printDesignDescription") |> PrefixedName

    /// <summary>
    ///   <para>unece:sellerAssignedId</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#sellerAssignedId">http://unece.org/vocab#sellerAssignedId</seealso>
    let sellerAssignedId = Prefixed_Name(unece, "sellerAssignedId") |> PrefixedName
    /// <summary>
    ///   <para>unece:sizeDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#sizeDescription">http://unece.org/vocab#sizeDescription</seealso>
    let sizeDescription = Prefixed_Name(unece, "sizeDescription") |> PrefixedName
    /// <summary>
    ///   <para>unece:variantId</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://unece.org/vocab#variantId">http://unece.org/vocab#variantId</seealso>
    let variantId = Prefixed_Name(unece, "variantId") |> PrefixedName

namespace https.spec.edmcouncil.org.fibo.ontology.FND.ProductsAndServices.ProductsAndServices.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_pas_pas =
    let _namespace_iri = Namespace_Iri fibo_fnd_pas_pas |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-pas-pas:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Products and Services Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_pas_pas, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-pas-pas:Buyer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"buyer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Buyer">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Buyer</seealso>
    let Buyer = Prefixed_Name(fibo_fnd_pas_pas, "Buyer") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-pas-pas:Client</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"client"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Client">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Client</seealso>
    let Client = Prefixed_Name(fibo_fnd_pas_pas, "Client") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-pas-pas:ClientIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"client identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/ClientIdentifier">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/ClientIdentifier</seealso>
    let ClientIdentifier =
        Prefixed_Name(fibo_fnd_pas_pas, "ClientIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-pas-pas:Commodity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"commodity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Commodity">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Commodity</seealso>
    let Commodity = Prefixed_Name(fibo_fnd_pas_pas, "Commodity") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-pas-pas:Consumer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"consumer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Consumer">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Consumer</seealso>
    let Consumer = Prefixed_Name(fibo_fnd_pas_pas, "Consumer") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-pas-pas:ContractualProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contractual product"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/ContractualProduct">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/ContractualProduct</seealso>
    let ContractualProduct =
        Prefixed_Name(fibo_fnd_pas_pas, "ContractualProduct") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-pas-pas:ContractualTemplateProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contractual template product"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/ContractualTemplateProduct">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/ContractualTemplateProduct</seealso>
    let ContractualTemplateProduct =
        Prefixed_Name(fibo_fnd_pas_pas, "ContractualTemplateProduct") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-pas-pas:CustomProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"custom product"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/CustomProduct">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/CustomProduct</seealso>
    let CustomProduct = Prefixed_Name(fibo_fnd_pas_pas, "CustomProduct") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-pas-pas:Customer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"customer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Customer">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Customer</seealso>
    let Customer = Prefixed_Name(fibo_fnd_pas_pas, "Customer") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-pas-pas:CustomerIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"customer identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/CustomerIdentifier">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/CustomerIdentifier</seealso>
    let CustomerIdentifier =
        Prefixed_Name(fibo_fnd_pas_pas, "CustomerIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-pas-pas:Good</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"good"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Good">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Good</seealso>
    let Good = Prefixed_Name(fibo_fnd_pas_pas, "Good") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-pas-pas:NegotiableCommodity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"negotiable commodity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/NegotiableCommodity">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/NegotiableCommodity</seealso>
    let NegotiableCommodity =
        Prefixed_Name(fibo_fnd_pas_pas, "NegotiableCommodity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-pas-pas:OffTheShelfProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"off-the-shelf product"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/OffTheShelfProduct">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/OffTheShelfProduct</seealso>
    let OffTheShelfProduct =
        Prefixed_Name(fibo_fnd_pas_pas, "OffTheShelfProduct") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-pas-pas:Offer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Offer">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Offer</seealso>
    let Offer = Prefixed_Name(fibo_fnd_pas_pas, "Offer") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-pas-pas:Price</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Price">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Price</seealso>
    let Price = Prefixed_Name(fibo_fnd_pas_pas, "Price") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-pas-pas:Producer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"producer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Producer">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Producer</seealso>
    let Producer = Prefixed_Name(fibo_fnd_pas_pas, "Producer") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-pas-pas:Product</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"product"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Product">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Product</seealso>
    let Product = Prefixed_Name(fibo_fnd_pas_pas, "Product") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-pas-pas:ProductIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"product identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/ProductIdentifier">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/ProductIdentifier</seealso>
    let ProductIdentifier =
        Prefixed_Name(fibo_fnd_pas_pas, "ProductIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-pas-pas:Sale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sale"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Sale">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Sale</seealso>
    let Sale = Prefixed_Name(fibo_fnd_pas_pas, "Sale") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-pas-pas:Seller</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"seller"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Seller">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Seller</seealso>
    let Seller = Prefixed_Name(fibo_fnd_pas_pas, "Seller") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-pas-pas:ServiceAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"service agreement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/ServiceAgreement">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/ServiceAgreement</seealso>
    let ServiceAgreement =
        Prefixed_Name(fibo_fnd_pas_pas, "ServiceAgreement") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-pas-pas:Supplier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"supplier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Supplier">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Supplier</seealso>
    let Supplier = Prefixed_Name(fibo_fnd_pas_pas, "Supplier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-pas-pas:TransactionConfirmation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"transaction confirmation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/TransactionConfirmation">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/TransactionConfirmation</seealso>
    let TransactionConfirmation =
        Prefixed_Name(fibo_fnd_pas_pas, "TransactionConfirmation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-pas-pas:TransactionEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"transaction event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/TransactionEvent">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/TransactionEvent</seealso>
    let TransactionEvent =
        Prefixed_Name(fibo_fnd_pas_pas, "TransactionEvent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-pas-pas:buys</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"buys"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/buys">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/buys</seealso>
    let buys = Prefixed_Name(fibo_fnd_pas_pas, "buys") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-pas-pas:buysFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"buys from"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/buysFrom">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/buysFrom</seealso>
    let buysFrom = Prefixed_Name(fibo_fnd_pas_pas, "buysFrom") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-pas-pas:hasBuyer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has buyer"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/hasBuyer">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/hasBuyer</seealso>
    let hasBuyer = Prefixed_Name(fibo_fnd_pas_pas, "hasBuyer") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-pas-pas:hasProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/hasProduct">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/hasProduct</seealso>
    let hasProduct = Prefixed_Name(fibo_fnd_pas_pas, "hasProduct") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-pas-pas:hasSeller</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has seller"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/hasSeller">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/hasSeller</seealso>
    let hasSeller = Prefixed_Name(fibo_fnd_pas_pas, "hasSeller") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-pas-pas:hasServiceArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/hasServiceArea">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/hasServiceArea</seealso>
    let hasServiceArea =
        Prefixed_Name(fibo_fnd_pas_pas, "hasServiceArea") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-pas-pas:hasSupplier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/hasSupplier">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/hasSupplier</seealso>
    let hasSupplier = Prefixed_Name(fibo_fnd_pas_pas, "hasSupplier") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-pas-pas:isOfferedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/isOfferedBy">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/isOfferedBy</seealso>
    let isOfferedBy = Prefixed_Name(fibo_fnd_pas_pas, "isOfferedBy") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-pas-pas:isProductOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/isProductOf">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/isProductOf</seealso>
    let isProductOf = Prefixed_Name(fibo_fnd_pas_pas, "isProductOf") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-pas-pas:isProvisionedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is provisioned by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/isProvisionedBy">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/isProvisionedBy</seealso>
    let isProvisionedBy =
        Prefixed_Name(fibo_fnd_pas_pas, "isProvisionedBy") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-pas-pas:isSuppliedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is supplied by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/isSuppliedBy">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/isSuppliedBy</seealso>
    let isSuppliedBy = Prefixed_Name(fibo_fnd_pas_pas, "isSuppliedBy") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-pas-pas:offers</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/offers">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/offers</seealso>
    let offers = Prefixed_Name(fibo_fnd_pas_pas, "offers") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-pas-pas:provisions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"provisions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/provisions">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/provisions</seealso>
    let provisions = Prefixed_Name(fibo_fnd_pas_pas, "provisions") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-pas-pas:sells</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"sells"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/sells">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/sells</seealso>
    let sells = Prefixed_Name(fibo_fnd_pas_pas, "sells") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-pas-pas:sellsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"sells to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/sellsTo">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/sellsTo</seealso>
    let sellsTo = Prefixed_Name(fibo_fnd_pas_pas, "sellsTo") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-pas-pas:supplies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"supplies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/supplies">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/supplies</seealso>
    let supplies = Prefixed_Name(fibo_fnd_pas_pas, "supplies") |> PrefixedName

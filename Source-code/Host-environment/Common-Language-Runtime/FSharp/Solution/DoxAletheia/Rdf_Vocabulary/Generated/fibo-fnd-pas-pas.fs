namespace https.spec.edmcouncil.org.fibo.ontology.FND.ProductsAndServices.ProductsAndServices.slash

open DoxAletheia

module fibo_fnd_pas_pas =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/NegotiableCommodity"></see>
    /// </summary>
    let NegotiableCommodity = _prefix "NegotiableCommodity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Buyer"></see>
    /// </summary>
    let Buyer = _prefix "Buyer"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/buys"></see>
    /// </summary>
    let buys = _prefix "buys"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Product"></see>
    /// </summary>
    let Product = _prefix "Product"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Client"></see>
    /// </summary>
    let Client = _prefix "Client"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/ServiceAgreement"></see>
    /// </summary>
    let ServiceAgreement = _prefix "ServiceAgreement"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/ClientIdentifier"></see>
    /// </summary>
    let ClientIdentifier = _prefix "ClientIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Commodity"></see>
    /// </summary>
    let Commodity = _prefix "Commodity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Good"></see>
    /// </summary>
    let Good = _prefix "Good"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Consumer"></see>
    /// </summary>
    let Consumer = _prefix "Consumer"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/ContractualProduct"></see>
    /// </summary>
    let ContractualProduct = _prefix "ContractualProduct"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/ContractualTemplateProduct"></see>
    /// </summary>
    let ContractualTemplateProduct = _prefix "ContractualTemplateProduct"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/OffTheShelfProduct"></see>
    /// </summary>
    let OffTheShelfProduct = _prefix "OffTheShelfProduct"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/CustomProduct"></see>
    /// </summary>
    let CustomProduct = _prefix "CustomProduct"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Customer"></see>
    /// </summary>
    let Customer = _prefix "Customer"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/buysFrom"></see>
    /// </summary>
    let buysFrom = _prefix "buysFrom"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Supplier"></see>
    /// </summary>
    let Supplier = _prefix "Supplier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/CustomerIdentifier"></see>
    /// </summary>
    let CustomerIdentifier = _prefix "CustomerIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Producer"></see>
    /// </summary>
    let Producer = _prefix "Producer"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/ProductIdentifier"></see>
    /// </summary>
    let ProductIdentifier = _prefix "ProductIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Sale"></see>
    /// </summary>
    let Sale = _prefix "Sale"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/TransactionEvent"></see>
    /// </summary>
    let TransactionEvent = _prefix "TransactionEvent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/hasBuyer"></see>
    /// </summary>
    let hasBuyer = _prefix "hasBuyer"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/hasSeller"></see>
    /// </summary>
    let hasSeller = _prefix "hasSeller"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Seller"></see>
    /// </summary>
    let Seller = _prefix "Seller"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/sells"></see>
    /// </summary>
    let sells = _prefix "sells"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/supplies"></see>
    /// </summary>
    let supplies = _prefix "supplies"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/TransactionConfirmation"></see>
    /// </summary>
    let TransactionConfirmation = _prefix "TransactionConfirmation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/isProvisionedBy"></see>
    /// </summary>
    let isProvisionedBy = _prefix "isProvisionedBy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/provisions"></see>
    /// </summary>
    let provisions = _prefix "provisions"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/isSuppliedBy"></see>
    /// </summary>
    let isSuppliedBy = _prefix "isSuppliedBy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/sellsTo"></see>
    /// </summary>
    let sellsTo = _prefix "sellsTo"

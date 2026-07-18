namespace https.spec.edmcouncil.org.fibo.ontology.FND.ProductsAndServices.ProductsAndServices.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_pas_pas =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/NegotiableCommodity"></see>
    /// </summary>
    let NegotiableCommodity =
        Namespaced_IRI.parse _namespace_name "NegotiableCommodity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Buyer"></see>
    /// </summary>
    let Buyer = Namespaced_IRI.parse _namespace_name "Buyer" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/buys"></see>
    /// </summary>
    let buys = Namespaced_IRI.parse _namespace_name "buys" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Product"></see>
    /// </summary>
    let Product = Namespaced_IRI.parse _namespace_name "Product" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Client"></see>
    /// </summary>
    let Client = Namespaced_IRI.parse _namespace_name "Client" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/ServiceAgreement"></see>
    /// </summary>
    let ServiceAgreement =
        Namespaced_IRI.parse _namespace_name "ServiceAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/ClientIdentifier"></see>
    /// </summary>
    let ClientIdentifier =
        Namespaced_IRI.parse _namespace_name "ClientIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Commodity"></see>
    /// </summary>
    let Commodity = Namespaced_IRI.parse _namespace_name "Commodity" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Good"></see>
    /// </summary>
    let Good = Namespaced_IRI.parse _namespace_name "Good" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Consumer"></see>
    /// </summary>
    let Consumer = Namespaced_IRI.parse _namespace_name "Consumer" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/ContractualProduct"></see>
    /// </summary>
    let ContractualProduct =
        Namespaced_IRI.parse _namespace_name "ContractualProduct" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/ContractualTemplateProduct"></see>
    /// </summary>
    let ContractualTemplateProduct =
        Namespaced_IRI.parse _namespace_name "ContractualTemplateProduct" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/OffTheShelfProduct"></see>
    /// </summary>
    let OffTheShelfProduct =
        Namespaced_IRI.parse _namespace_name "OffTheShelfProduct" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/CustomProduct"></see>
    /// </summary>
    let CustomProduct =
        Namespaced_IRI.parse _namespace_name "CustomProduct" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Customer"></see>
    /// </summary>
    let Customer = Namespaced_IRI.parse _namespace_name "Customer" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/buysFrom"></see>
    /// </summary>
    let buysFrom = Namespaced_IRI.parse _namespace_name "buysFrom" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Supplier"></see>
    /// </summary>
    let Supplier = Namespaced_IRI.parse _namespace_name "Supplier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/CustomerIdentifier"></see>
    /// </summary>
    let CustomerIdentifier =
        Namespaced_IRI.parse _namespace_name "CustomerIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Producer"></see>
    /// </summary>
    let Producer = Namespaced_IRI.parse _namespace_name "Producer" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/ProductIdentifier"></see>
    /// </summary>
    let ProductIdentifier =
        Namespaced_IRI.parse _namespace_name "ProductIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Sale"></see>
    /// </summary>
    let Sale = Namespaced_IRI.parse _namespace_name "Sale" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/TransactionEvent"></see>
    /// </summary>
    let TransactionEvent =
        Namespaced_IRI.parse _namespace_name "TransactionEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/hasBuyer"></see>
    /// </summary>
    let hasBuyer = Namespaced_IRI.parse _namespace_name "hasBuyer" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/hasSeller"></see>
    /// </summary>
    let hasSeller = Namespaced_IRI.parse _namespace_name "hasSeller" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Seller"></see>
    /// </summary>
    let Seller = Namespaced_IRI.parse _namespace_name "Seller" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/sells"></see>
    /// </summary>
    let sells = Namespaced_IRI.parse _namespace_name "sells" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/supplies"></see>
    /// </summary>
    let supplies = Namespaced_IRI.parse _namespace_name "supplies" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/TransactionConfirmation"></see>
    /// </summary>
    let TransactionConfirmation =
        Namespaced_IRI.parse _namespace_name "TransactionConfirmation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/isProvisionedBy"></see>
    /// </summary>
    let isProvisionedBy =
        Namespaced_IRI.parse _namespace_name "isProvisionedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/provisions"></see>
    /// </summary>
    let provisions = Namespaced_IRI.parse _namespace_name "provisions" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/isSuppliedBy"></see>
    /// </summary>
    let isSuppliedBy =
        Namespaced_IRI.parse _namespace_name "isSuppliedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/sellsTo"></see>
    /// </summary>
    let sellsTo = Namespaced_IRI.parse _namespace_name "sellsTo" |> NamespacedName

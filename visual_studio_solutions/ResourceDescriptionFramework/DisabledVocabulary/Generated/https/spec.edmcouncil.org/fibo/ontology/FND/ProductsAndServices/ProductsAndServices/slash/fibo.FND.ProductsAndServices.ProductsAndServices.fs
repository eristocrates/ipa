namespace Fibo.FND.ProductsAndServices.ProductsAndServices.Namespace
module ProductsAndServices =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/FND/ProductsAndServices/ProductsAndServices.rdf") (Some @"fibo.FND.ProductsAndServices.ProductsAndServices") None
    let Buyer = {_prefixID with _localName = "Buyer"}
    let Client = {_prefixID with _localName = "Client"}
    let ClientIdentifier = {_prefixID with _localName = "ClientIdentifier"}
    let Commodity = {_prefixID with _localName = "Commodity"}
    let Consumer = {_prefixID with _localName = "Consumer"}
    let ContractualProduct = {_prefixID with _localName = "ContractualProduct"}
    let ContractualTemplateProduct = {_prefixID with _localName = "ContractualTemplateProduct"}
    let CustomProduct = {_prefixID with _localName = "CustomProduct"}
    let Customer = {_prefixID with _localName = "Customer"}
    let CustomerIdentifier = {_prefixID with _localName = "CustomerIdentifier"}
    let Good = {_prefixID with _localName = "Good"}
    let NegotiableCommodity = {_prefixID with _localName = "NegotiableCommodity"}
    let OffTheShelfProduct = {_prefixID with _localName = "OffTheShelfProduct"}
    let Producer = {_prefixID with _localName = "Producer"}
    let Product = {_prefixID with _localName = "Product"}
    let ProductIdentifier = {_prefixID with _localName = "ProductIdentifier"}
    let Sale = {_prefixID with _localName = "Sale"}
    let Seller = {_prefixID with _localName = "Seller"}
    let ServiceAgreement = {_prefixID with _localName = "ServiceAgreement"}
    let Supplier = {_prefixID with _localName = "Supplier"}
    let TransactionConfirmation = {_prefixID with _localName = "TransactionConfirmation"}
    let TransactionEvent = {_prefixID with _localName = "TransactionEvent"}
    let buys = {_prefixID with _localName = "buys"}
    let buysFrom = {_prefixID with _localName = "buysFrom"}
    let hasBuyer = {_prefixID with _localName = "hasBuyer"}
    let hasSeller = {_prefixID with _localName = "hasSeller"}
    let isProvisionedBy = {_prefixID with _localName = "isProvisionedBy"}
    let isSuppliedBy = {_prefixID with _localName = "isSuppliedBy"}
    let provisions = {_prefixID with _localName = "provisions"}
    let sells = {_prefixID with _localName = "sells"}
    let sellsTo = {_prefixID with _localName = "sellsTo"}
    let supplies = {_prefixID with _localName = "supplies"}
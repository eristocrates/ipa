#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fnd-pas-pas`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/" "fibo-fnd-pas-pas"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : buyer^^xsd:string</para>
    ///   <para>skos:definition : party that purchases something in exchange for money or other consideration under a contract of sale^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A buyer is the party that acquires, or agrees to acquire, ownership (in case of goods), or benefit or usage (in case of rights or services), something in the context of a sale, and may or may not be an end user of the product, good, service, or right.^^xsd:string</para>
    ///   <para>cmns-av:synonym : buyer^^xsd:stringcmns-av:synonym : purchaser^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Buyer">fibo-fnd-pas-pas:Buyer</a>
    /// </summary>
    let Buyer = _prefixId.prefix "Buyer"
    /// <summary>
    ///   <para>rdfs:label : client^^xsd:string</para>
    ///   <para>skos:definition : party that purchases professional services from, or has a formal relationship to purchase services from another party^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Client">fibo-fnd-pas-pas:Client</a>
    /// </summary>
    let Client = _prefixId.prefix "Client"
    /// <summary>
    ///   <para>rdfs:label : client identifier^^xsd:string</para>
    ///   <para>skos:definition : sequence of characters uniquely identifying a client within the context of some organization^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/ClientIdentifier">fibo-fnd-pas-pas:ClientIdentifier</a>
    /// </summary>
    let ClientIdentifier = _prefixId.prefix "ClientIdentifier"
    /// <summary>
    ///   <para>rdfs:label : commodity^^xsd:string</para>
    ///   <para>skos:definition : material resource used in commerce that is interchangeable with other commodities of the same type^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Commodities are most often used as inputs in the production of other goods or services. The quality of a given commodity may differ slightly, but it is essentially uniform across producers.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Commodity">fibo-fnd-pas-pas:Commodity</a>
    /// </summary>
    let Commodity = _prefixId.prefix "Commodity"
    /// <summary>
    ///   <para>rdfs:label : consumer^^xsd:string</para>
    ///   <para>skos:definition : party that utilizes economic goods or services, typically for personal, family, or household purposes^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The general notion of a consumer includes an end user, and is not limited to a purchaser, in the distribution chain of a good or service^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Consumer">fibo-fnd-pas-pas:Consumer</a>
    /// </summary>
    let Consumer = _prefixId.prefix "Consumer"
    /// <summary>
    ///   <para>rdfs:label : contractual product^^xsd:string</para>
    ///   <para>skos:definition : product that takes the form of an agreement^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : This represents the case where the product itself is a contract, such as a life insurance policy or financial instrument, rather than a product or service whose terms of use, license to use, or terms of service are specified in a product.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/ContractualProduct">fibo-fnd-pas-pas:ContractualProduct</a>
    /// </summary>
    let ContractualProduct = _prefixId.prefix "ContractualProduct"
    /// <summary>
    ///   <para>rdfs:label : contractual template product^^xsd:string</para>
    ///   <para>skos:definition : contractual product that is finalized through specification of values for parameters defined in a template^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/ContractualTemplateProduct">fibo-fnd-pas-pas:ContractualTemplateProduct</a>
    /// </summary>
    let ContractualTemplateProduct = _prefixId.prefix "ContractualTemplateProduct"
    /// <summary>
    ///   <para>rdfs:label : custom product^^xsd:string</para>
    ///   <para>skos:definition : product that is made to order, commissioned based on a customer's specifications^^xsd:string</para>
    ///   <para>cmns-av:synonym : bespoke product^^xsd:stringcmns-av:synonym : custom-made product^^xsd:stringcmns-av:synonym : made to order product^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/CustomProduct">fibo-fnd-pas-pas:CustomProduct</a>
    /// </summary>
    let CustomProduct = _prefixId.prefix "CustomProduct"
    /// <summary>
    ///   <para>rdfs:label : customer^^xsd:string</para>
    ///   <para>skos:definition : party that receives or consumes products (goods or services) and has the ability to choose between different products and suppliers^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Customer">fibo-fnd-pas-pas:Customer</a>
    /// </summary>
    let Customer = _prefixId.prefix "Customer"
    /// <summary>
    ///   <para>rdfs:label : customer identifier^^xsd:string</para>
    ///   <para>skos:definition : sequence of characters uniquely identifying a customer within the context of some organization^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/CustomerIdentifier">fibo-fnd-pas-pas:CustomerIdentifier</a>
    /// </summary>
    let CustomerIdentifier = _prefixId.prefix "CustomerIdentifier"
    /// <summary>
    ///   <para>rdfs:label : good^^xsd:string</para>
    ///   <para>skos:definition : physical, produced item over which ownership rights can be established, whose ownership can be passed from one party to another by engaging in transactions, and that is not money or real estate^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://data.oecd.org/trade/trade-in-goods.htm^^xsd:anyURIcmns-av:adaptedFrom : https://www.law.cornell.edu/ucc/9/9-102#goods^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : An inherently useful and relatively scarce tangible item produced from agricultural, construction, manufacturing, or mining activities. Off-the-shelf products, including off-the-shelf software products and customization of software products, are generally considered to be goods. Energy, such as electricity, is also considered to be a good from a legal perspective, and meets the criteria of being manufactured or produced via some process, including but not limited to a mining process. According to the UN Convention On Contract For The International Sale Of Goods, the term 'good' does not include (1) items bought for personal use, (2) items bought at an auction or foreclosure sale, (3) aircraft or ocean-going vessels.^^xsd:stringcmns-av:explanatoryNote : From the Universal Commercial Code (UCC) in the United States, the term 'good' includes (i) fixtures, (ii) standing timber that is to be cut and removed under a conveyance or contract for sale, (iii) the unborn young of animals, (iv) crops grown, growing, or to be grown, even if the crops are produced on trees, vines, or bushes, and (v) manufactured homes. The term also includes a computer program embedded in goods and any supporting information provided in connection with a transaction relating to the program if (i) the program is associated with the goods in such a manner that it customarily is considered part of the goods, or (ii) by becoming the owner of the goods, a person acquires a right to use the program in connection with the goods. The term does not include a computer program embedded in goods that consist solely of the medium in which the program is embedded. The term also does not include accounts, chattel paper, commercial tort claims, deposit accounts, documents, general intangibles, instruments, investment property, letter-of-credit rights, letters of credit, money, or oil, gas, or other minerals before extraction.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Good">fibo-fnd-pas-pas:Good</a>
    /// </summary>
    let Good = _prefixId.prefix "Good"
    /// <summary>
    ///   <para>rdfs:label : negotiable commodity^^xsd:string</para>
    ///   <para>skos:definition : commodity that can be bought or sold in some marketplace^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/NegotiableCommodity">fibo-fnd-pas-pas:NegotiableCommodity</a>
    /// </summary>
    let NegotiableCommodity = _prefixId.prefix "NegotiableCommodity"
    /// <summary>
    ///   <para>rdfs:label : off-the-shelf product^^xsd:string</para>
    ///   <para>skos:definition : product that is readily available from merchandise in stock, or can be quickly and easily configured to order, not specially designed or custom-made^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : COTS product^^xsd:string</para>
    ///   <para>cmns-av:synonym : commercial off-the-shelf product^^xsd:stringcmns-av:synonym : commercially available off-the-shelf product^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/OffTheShelfProduct">fibo-fnd-pas-pas:OffTheShelfProduct</a>
    /// </summary>
    let OffTheShelfProduct = _prefixId.prefix "OffTheShelfProduct"
    /// <summary>
    ///   <para>rdfs:label : producer^^xsd:string</para>
    ///   <para>skos:definition : grower, maker, fabricator, or manufacturer of some product or other good^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Producer">fibo-fnd-pas-pas:Producer</a>
    /// </summary>
    let Producer = _prefixId.prefix "Producer"
    /// <summary>
    ///   <para>rdfs:label : product^^xsd:string</para>
    ///   <para>skos:definition : commercially distributed good that is (1) tangible property, (2) the output or result of a fabrication, manufacturing, or production process, or (3) something that passes through a distribution channel before being consumed or used.^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Financial products include contracts that are developed via a financial service-specific process, such as a life insurance policy, demand deposit account or financial instrument, for example. Leases and rentals are similar in that they are initiated via some contractual development process, wherein the product is the right to use something for some period of time.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Product">fibo-fnd-pas-pas:Product</a>
    /// </summary>
    let Product = _prefixId.prefix "Product"
    /// <summary>
    ///   <para>rdfs:label : product identifier^^xsd:string</para>
    ///   <para>skos:definition : sequence of characters uniquely identifying a product in some context^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/ProductIdentifier">fibo-fnd-pas-pas:ProductIdentifier</a>
    /// </summary>
    let ProductIdentifier = _prefixId.prefix "ProductIdentifier"
    /// <summary>
    ///   <para>rdfs:label : sale^^xsd:string</para>
    ///   <para>skos:definition : exchange of goods or services for money^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Sale">fibo-fnd-pas-pas:Sale</a>
    /// </summary>
    let Sale = _prefixId.prefix "Sale"
    /// <summary>
    ///   <para>rdfs:label : seller^^xsd:string</para>
    ///   <para>skos:definition : party that makes, offers or contracts to make a sale to an actual or potential buyer^^xsd:string</para>
    ///   <para>cmns-av:synonym : purveyor^^xsd:stringcmns-av:synonym : vendor^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Seller">fibo-fnd-pas-pas:Seller</a>
    /// </summary>
    let Seller = _prefixId.prefix "Seller"
    /// <summary>
    ///   <para>rdfs:label : service agreement^^xsd:string</para>
    ///   <para>skos:definition : written contract between a client and service provider whereby the service provider supplies some service in the form of time, effort, and/or expertise in exchange for compensation^^xsd:string</para>
    ///   <para>cmns-av:synonym : service contract^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/ServiceAgreement">fibo-fnd-pas-pas:ServiceAgreement</a>
    /// </summary>
    let ServiceAgreement = _prefixId.prefix "ServiceAgreement"
    /// <summary>
    ///   <para>rdfs:label : supplier^^xsd:string</para>
    ///   <para>skos:definition : party that provides goods or services that some party wants or needs, especially over a long period of time^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A supplier may be distinguished from a contractor or subcontractor, who commonly adds specialized input to deliverables.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/Supplier">fibo-fnd-pas-pas:Supplier</a>
    /// </summary>
    let Supplier = _prefixId.prefix "Supplier"
    /// <summary>
    ///   <para>rdfs:label : transaction confirmation^^xsd:string</para>
    ///   <para>skos:definition : written communication from a seller or service provider reciting the relevant details of a transaction^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/TransactionConfirmation">fibo-fnd-pas-pas:TransactionConfirmation</a>
    /// </summary>
    let TransactionConfirmation = _prefixId.prefix "TransactionConfirmation"
    /// <summary>
    ///   <para>rdfs:label : transaction event^^xsd:string</para>
    ///   <para>skos:definition : any sale, assignment, lease, license, loan, advance, contribution, or other transfer of any interest in or right to use any property (tangible or intangible) or money, however that transaction is effected, and regardless of whether the terms of the transaction are formally documented^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/TransactionEvent">fibo-fnd-pas-pas:TransactionEvent</a>
    /// </summary>
    let TransactionEvent = _prefixId.prefix "TransactionEvent"
    /// <summary>
    ///   <para>rdfs:label : buys^^xsd:string</para>
    ///   <para>skos:definition : links a party in the role of purchaser to something that they have purchased or plan to purchase^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/buys">fibo-fnd-pas-pas:buys</a>
    /// </summary>
    let buys = _prefixId.prefix "buys"
    /// <summary>
    ///   <para>rdfs:label : buys from^^xsd:string</para>
    ///   <para>skos:definition : links a party in the role of purchaser to a party from which they have made or are planning to make a purchase^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/buysFrom">fibo-fnd-pas-pas:buysFrom</a>
    /// </summary>
    let buysFrom = _prefixId.prefix "buysFrom"
    /// <summary>
    ///   <para>rdfs:label : has buyer</para>
    ///   <para>skos:definition : indicates the purchasing party in the context of a sales transaction^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/hasBuyer">fibo-fnd-pas-pas:hasBuyer</a>
    /// </summary>
    let hasBuyer = _prefixId.prefix "hasBuyer"
    /// <summary>
    ///   <para>rdfs:label : has seller</para>
    ///   <para>skos:definition : indicates the vendor in the context of a sales transaction^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/hasSeller">fibo-fnd-pas-pas:hasSeller</a>
    /// </summary>
    let hasSeller = _prefixId.prefix "hasSeller"
    /// <summary>
    ///   <para>rdfs:label : is provisioned by^^xsd:string</para>
    ///   <para>skos:definition : identifies the service provider that provisions the service or facility^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/isProvisionedBy">fibo-fnd-pas-pas:isProvisionedBy</a>
    /// </summary>
    let isProvisionedBy = _prefixId.prefix "isProvisionedBy"
    /// <summary>
    ///   <para>rdfs:label : is supplied by^^xsd:string</para>
    ///   <para>skos:definition : identifies the party (supplier, vendor, distributor, etc.) that makes a product available^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/isSuppliedBy">fibo-fnd-pas-pas:isSuppliedBy</a>
    /// </summary>
    let isSuppliedBy = _prefixId.prefix "isSuppliedBy"
    /// <summary>
    ///   <para>rdfs:label : provisions^^xsd:string</para>
    ///   <para>skos:definition : customizes, provides, or outfits something required for use in delivering a service^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/provisions">fibo-fnd-pas-pas:provisions</a>
    /// </summary>
    let provisions = _prefixId.prefix "provisions"
    /// <summary>
    ///   <para>rdfs:label : sells^^xsd:string</para>
    ///   <para>skos:definition : links a party in the role of broker, dealer, vendor, or merchandiser to something that they make available for sale^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/sells">fibo-fnd-pas-pas:sells</a>
    /// </summary>
    let sells = _prefixId.prefix "sells"
    /// <summary>
    ///   <para>rdfs:label : sells to^^xsd:string</para>
    ///   <para>skos:definition : links a party in the role of broker, dealer, vendor, or merchandiser to a purchaser or potential purchasing party^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/sellsTo">fibo-fnd-pas-pas:sellsTo</a>
    /// </summary>
    let sellsTo = _prefixId.prefix "sellsTo"
    /// <summary>
    ///   <para>rdfs:label : supplies^^xsd:string</para>
    ///   <para>skos:definition : links a party in the role of outfitter, provisioner, distributor, etc. to something that they provide^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/supplies">fibo-fnd-pas-pas:supplies</a>
    /// </summary>
    let supplies = _prefixId.prefix "supplies"

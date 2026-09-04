#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module pc =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/procurement/public-contracts#" "pc"

    /// <summary>
    ///   <para>rdfs:comment : Class for description of criteria combination used for tender evaluationrdfs:comment : Třída pro popis kombinace kritérií pro posuzování nabídek zájemců o zakázku</para>
    ///   <para>rdfs:label : Combination of contract award criteriardfs:label : Kombinace kritérií pro hodnocení dodaných nabídek</para>
    ///   <a href="http://purl.org/procurement/public-contracts#AwardCriteriaCombination">pc:AwardCriteriaCombination</a>
    /// </summary>
    let AwardCriteriaCombination = _prefixId.prefix "AwardCriteriaCombination"
    /// <summary>
    ///   <para>rdfs:comment : An instance of this class is an abstract information entity about a public contract. It consists of all currently known information about a contract, e.g., a contracting authority, services or supplies which shall be purchased, and contract conditions (e.g., important dates, expected price, etc.). It also informs about tenders received from particular bidders and about an accepted tender. If the contract has already been realized it also informs about an actual price of realization, etc.rdfs:comment : Instance této třídy je abstraktní informační entitou o veřejné zakázce. Obsahuje všechny aktuálně známé informace o zakázce, tj. např. o zadavateli veřejné zakázky, službách či dodávkách, které ve veřejné zakázce nakupuje, a o podmínkách nákupu (termíny, očekávané ceny, atd.). Dále obsahuje informace o nabídkách od zájemců o zakázku a o vybrané nabídce. Pokud již byla zakázka realizována, obsahuje i informace o skutečné ceně za realizaci apod.</para>
    ///   <para>rdfs:label : Public contractrdfs:label : Veřejná zakázka</para>
    ///   <a href="http://purl.org/procurement/public-contracts#Contract">pc:Contract</a>
    /// </summary>
    let Contract = _prefixId.prefix "Contract"
    /// <summary>
    ///   <para>rdfs:comment : Class for description of one criterion and its weightrdfs:comment : Třída pro popis jednoho kritéria a jeho váhy.</para>
    ///   <para>rdfs:label : Contract award weighted criterionrdfs:label : Vážené kritérium pro udělení zakázky</para>
    ///   <a href="http://purl.org/procurement/public-contracts#CriterionWeighting">pc:CriterionWeighting</a>
    /// </summary>
    let CriterionWeighting = _prefixId.prefix "CriterionWeighting"
    /// <summary>
    ///   <para>rdfs:comment : Class for decribing a framework agreementrdfs:comment : Třída pro popis rámcové smlouvy</para>
    ///   <para>rdfs:label : Framework agreementrdfs:label : Rámcová smlouva</para>
    ///   <a href="http://purl.org/procurement/public-contracts#FrameworkAgreement">pc:FrameworkAgreement</a>
    /// </summary>
    let FrameworkAgreement = _prefixId.prefix "FrameworkAgreement"
    /// <summary>
    ///   <para>rdfs:comment : Basic class for decribing a tender submitted by a bidderrdfs:comment : Základní třída pro popis nabídky zájemce o zakázku</para>
    ///   <para>rdfs:label : Tenderrdfs:label : Nabídka</para>
    ///   <a href="http://purl.org/procurement/public-contracts#Tender">pc:Tender</a>
    /// </summary>
    let Tender = _prefixId.prefix "Tender"
    /// <summary>
    ///   <para>rdfs:comment : Otevírání nabídek zaslaných pro veřejnou zakázkurdfs:comment : Opening of tenders submitted for a public contract</para>
    ///   <para>rdfs:label : Otevírání nabídekrdfs:label : Tenders' opening</para>
    ///   <a href="http://purl.org/procurement/public-contracts#TendersOpening">pc:TendersOpening</a>
    /// </summary>
    let TendersOpening = _prefixId.prefix "TendersOpening"
    let actualEndDate = _prefixId.prefix "actualEndDate"
    let actualPrice = _prefixId.prefix "actualPrice"
    /// <summary>
    ///   <para>rdfs:comment : CPV (Common Procurement Vocabulary) code describing an additional object of a public contract. Cardinality 0..*rdfs:comment : CPV (Common Procurement Vocabulary) kód popisující doplňující předmět veřejné zakázky. Kardinalita 0..*</para>
    ///   <para>rdfs:label : Additional object of contractrdfs:label : Další předmět zakázky</para>
    ///   <a href="http://purl.org/procurement/public-contracts#additionalObject">pc:additionalObject</a>
    /// </summary>
    let additionalObject = _prefixId.prefix "additionalObject"
    let agreedPrice = _prefixId.prefix "agreedPrice"
    /// <summary>
    ///   <para>rdfs:comment : Property for attachment of documents containing the agreement between supplier and contractor. Cardinality 0..*rdfs:comment : Vlastnost pro připojení dokumentů obsahujících smlouvy na veřejnou zakázku uzavřené mezi zadavatelem a dodavatelem. Kardinalita 0..*</para>
    ///   <para>rdfs:label : Contract agreementrdfs:label : Smlouva na veřejnou zakázku</para>
    ///   <a href="http://purl.org/procurement/public-contracts#agreement">pc:agreement</a>
    /// </summary>
    let agreement = _prefixId.prefix "agreement"
    /// <summary>
    ///   <para>rdfs:comment : Property for attachment of other documents. For attachment of contract specification use pc:specification. For attachment of contract agreement use pc:agreement. Cardinality 0..*rdfs:comment : Vlastnost pro připojení ostatních příloh. Zadávací dokumentaci připojte pomocí pc:specification, smlouvu pomocí pc:agreement. Kardinalita 0..*</para>
    ///   <para>rdfs:label : Contract attachmentrdfs:label : Příloha k zakázce</para>
    ///   <a href="http://purl.org/procurement/public-contracts#attachment">pc:attachment</a>
    /// </summary>
    let attachment = _prefixId.prefix "attachment"
    let authorityKind = _prefixId.prefix "authorityKind"
    let awardCriteriaCombination = _prefixId.prefix "awardCriteriaCombination"
    /// <summary>
    ///   <para>rdfs:comment : Property for setting a criterion for tender evaluation. Cardinality 0..*rdfs:comment : Vlastnost pro nastavení jednoho kritéria pro hodnocení nabídek zájemců o zakázku. Kardinalita 0..*</para>
    ///   <para>rdfs:label : Vergabekriterienrdfs:label : Critères d'attributionrdfs:label : Kritérium pro zadání zakázky.rdfs:label : Criterion for contract award.</para>
    ///   <a href="http://purl.org/procurement/public-contracts#awardCriterion">pc:awardCriterion</a>
    /// </summary>
    let awardCriterion = _prefixId.prefix "awardCriterion"
    let awardDate = _prefixId.prefix "awardDate"
    let awardedTender = _prefixId.prefix "awardedTender"
    /// <summary>
    ///   <para>rdfs:comment : Property for bidder submitting the tender. Cardinality 0..1rdfs:comment : Vlastnost pro zájemce o zakázku podávajícího nabídku. Kardinalita 0..1</para>
    ///   <para>rdfs:label : Tender bidderrdfs:label : Zájemce o zakázku</para>
    ///   <a href="http://purl.org/procurement/public-contracts#bidder">pc:bidder</a>
    /// </summary>
    let bidder = _prefixId.prefix "bidder"
    /// <summary>
    ///   <para>rdfs:comment : Property for contact information for a person or place responsible for a communication with the public and bidders. If there are more contact places or persons (e.g., for collecting documentation to the public contract), there is a separate contact for each person. Cardinality 0..*rdfs:comment : Vlastnost pro kontaktní údaje na místo nebo osobu určenou pro komunikaci s veřejností a zájemci o zakázku. Pokud je kontaktních míst či osob více (např. pro vyzvednutí dokumentace k veřejné zakázce), je pro každou uveden samostatný kontakt. Kardinalita 0..*</para>
    ///   <para>rdfs:label : Contact personrdfs:label : Kontaktní osoba</para>
    ///   <a href="http://purl.org/procurement/public-contracts#contact">pc:contact</a>
    /// </summary>
    let contact = _prefixId.prefix "contact"
    /// <summary>
    ///   <para>rdfs:comment : Veřejná zakázka, pro níž jsou otevírány nabídkyrdfs:comment : Public contract, for which tenders are opened</para>
    ///   <para>rdfs:label : Veřejná zakázkardfs:label : Public contract</para>
    ///   <a href="http://purl.org/procurement/public-contracts#contract">pc:contract</a>
    /// </summary>
    let contract = _prefixId.prefix "contract"
    /// <summary>
    ///   <para>rdfs:comment : Abstract property for price of public contractrdfs:comment : Abstraktní vlastnost pro cenu přiřazené k veřejné zakázce</para>
    ///   <para>rdfs:label : Pricerdfs:label : Cena</para>
    ///   <a href="http://purl.org/procurement/public-contracts#contractPrice">pc:contractPrice</a>
    /// </summary>
    let contractPrice = _prefixId.prefix "contractPrice"
    let contractingAuthority = _prefixId.prefix "contractingAuthority"
    let criterionWeight = _prefixId.prefix "criterionWeight"
    let documentationPrice = _prefixId.prefix "documentationPrice"
    let documentationRequestDeadline = _prefixId.prefix "documentationRequestDeadline"
    let duration = _prefixId.prefix "duration"
    let estimatedEndDate = _prefixId.prefix "estimatedEndDate"
    let estimatedPrice = _prefixId.prefix "estimatedPrice"
    let expectedNumberOfOperators = _prefixId.prefix "expectedNumberOfOperators"
    /// <summary>
    ///   <para>rdfs:comment : Property for a framework agreement on which base a public contract was issued. Cardinality 0..1rdfs:comment : Vlastnost pro rámcovou smlouvu, na jejímž základě byla veřejná zakázka zadána. Kardinalita 0..1</para>
    ///   <para>rdfs:label : On the base of a framework agreementrdfs:label : Na základě rámcové smlouvy</para>
    ///   <a href="http://purl.org/procurement/public-contracts#frameworkAgreement">pc:frameworkAgreement</a>
    /// </summary>
    let frameworkAgreement = _prefixId.prefix "frameworkAgreement"
    /// <summary>
    ///   <para>rdfs:comment : An item inquired by a public contract. It can be a combination of several products or services which can be expressed using properties of gr:Offering. Cardinality 0..*rdfs:comment : Položka poptávaná v rámci veřejné zakázky. Může být kombinací několika produktů či služeb, což lze vyjádřit pomocí vlastností gr:Offering. Kardinalita 0..*</para>
    ///   <a href="http://purl.org/procurement/public-contracts#item">pc:item</a>
    /// </summary>
    let item = _prefixId.prefix "item"
    let kind = _prefixId.prefix "kind"
    /// <summary>
    ///   <para>rdfs:comment : Place of delivery of contracted product or performance of contracted service. Cardinality 0..*rdfs:comment : Místo, kde dojde k dodání produktu nebo plnění služby nasmlouvané ve veřejné zakázce. Kardinalita 0..*</para>
    ///   <para>rdfs:label : Place of contract's realizationrdfs:label : Místo uskutečnění zakázky</para>
    ///   <a href="http://purl.org/procurement/public-contracts#location">pc:location</a>
    /// </summary>
    let location = _prefixId.prefix "location"
    /// <summary>
    ///   <para>rdfs:comment : Property for specifying contract lot. When contract is too big, it is split to lots by contracting authority. Bidders then tender each lot separately. For each lot the authority awards a separate tender. The contract itself has no tenders. Cardinality 0..*rdfs:comment : Vlastnost pro specifikaci části zakázky. Zakázku rozděluje na části zadavatel, pokud je zakázka přiliš velká. Zájemci o zakázku podávají nabídky na každou část odděleně a pro každou část zakázky je vybrán samostatný dodavatel. Pro samotnou zakázku nabídky nejsou podávány. Kardinalita 0..*</para>
    ///   <para>rdfs:label : Contract lotrdfs:label : Část zakázky</para>
    ///   <a href="http://purl.org/procurement/public-contracts#lot">pc:lot</a>
    /// </summary>
    let lot = _prefixId.prefix "lot"
    let mainActivity = _prefixId.prefix "mainActivity"
    let mainObject = _prefixId.prefix "mainObject"
    let numberOfTenders = _prefixId.prefix "numberOfTenders"
    let offeredPrice = _prefixId.prefix "offeredPrice"
    /// <summary>
    ///   <para>rdfs:comment : Contract award on behalf of other contracting authorities. Cardinality 0..*rdfs:comment : Zadání zakázky jménem jiných zadavatelů. Kardinalita 0..*</para>
    ///   <para>rdfs:label : On behalf ofrdfs:label : Jménem</para>
    ///   <a href="http://purl.org/procurement/public-contracts#onBehalfOf">pc:onBehalfOf</a>
    /// </summary>
    let onBehalfOf = _prefixId.prefix "onBehalfOf"
    let procedureType = _prefixId.prefix "procedureType"
    let profile = _prefixId.prefix "profile"
    /// <summary>
    ///   <para>rdfs:comment : Property for attachment of documents containing the contract specification. Cardinality 0..*rdfs:comment : Vlastnost pro připojení dokumentů obsahujících zadávací dokumentaci veřejné zakázky. Kardinalita 0..*</para>
    ///   <para>rdfs:label : Contract specificationrdfs:label : Zadávací dokumentace zakázky</para>
    ///   <a href="http://purl.org/procurement/public-contracts#specification">pc:specification</a>
    /// </summary>
    let specification = _prefixId.prefix "specification"
    let startDate = _prefixId.prefix "startDate"
    /// <summary>
    ///   <para>rdfs:comment : Property for used tender subsidy. Cardinality 0..*rdfs:comment : Vlastnost pro dotaci použitou pro zakázku. Kardinalita 0..*</para>
    ///   <para>rdfs:label : Subsidy supplemented for contractrdfs:label : Dotace použitá pro zakázku</para>
    ///   <a href="http://purl.org/procurement/public-contracts#subsidy">pc:subsidy</a>
    /// </summary>
    let subsidy = _prefixId.prefix "subsidy"
    /// <summary>
    ///   <para>rdfs:comment : Property for a tender submitted by a bidder. Cardinality 0..*rdfs:comment : Vlastnost pro nabídku zájemce o zakázku. Kardinalita 0..*</para>
    ///   <para>rdfs:label : Tenderrdfs:label : Nabídka</para>
    ///   <a href="http://purl.org/procurement/public-contracts#tender">pc:tender</a>
    /// </summary>
    let tender = _prefixId.prefix "tender"
    let tenderDeadline = _prefixId.prefix "tenderDeadline"
    let tenderMaintenanceDuration = _prefixId.prefix "tenderMaintenanceDuration"
    let weightedCriterion = _prefixId.prefix "weightedCriterion"

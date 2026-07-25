namespace http.purl.org.procurement.public_contracts.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pco =
    let _namespace_iri = Namespace_Iri pco |> NamespaceIRI

    /// <summary>
    ///   <para>pco:AwardCriteriaCombination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class for description of criteria combination used for tender evaluation</para>
    ///   <para>Třída pro popis kombinace kritérií pro posuzování nabídek zájemců o zakázku</para>
    /// labels<para>Kombinace kritérií pro hodnocení dodaných nabídek</para><para>Combination of contract award criteria</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#AwardCriteriaCombination">http://purl.org/procurement/public-contracts#AwardCriteriaCombination</seealso>
    let AwardCriteriaCombination =
        Prefixed_Name(pco, "AwardCriteriaCombination") |> PrefixedName

    /// <summary>
    ///   <para>pco:Contract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An instance of this class is an abstract information entity about a public contract. It consists of all currently known information about a contract, e.g., a contracting authority, services or supplies which shall be purchased, and contract conditions (e.g., important dates, expected price, etc.). It also informs about tenders received from particular bidders and about an accepted tender. If the contract has already been realized it also informs about an actual price of realization, etc.</para>
    ///   <para>Instance této třídy je abstraktní informační entitou o veřejné zakázce. Obsahuje všechny aktuálně známé informace o zakázce, tj. např. o zadavateli veřejné zakázky, službách či dodávkách, které ve veřejné zakázce nakupuje, a o podmínkách nákupu (termíny, očekávané ceny, atd.). Dále obsahuje informace o nabídkách od zájemců o zakázku a o vybrané nabídce. Pokud již byla zakázka realizována, obsahuje i informace o skutečné ceně za realizaci apod.</para>
    /// labels<para>Veřejná zakázka</para><para>Public contract</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#Contract">http://purl.org/procurement/public-contracts#Contract</seealso>
    let Contract = Prefixed_Name(pco, "Contract") |> PrefixedName
    /// <summary>
    ///   <para>pco:CriterionWeighting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Třída pro popis jednoho kritéria a jeho váhy.</para>
    ///   <para>Class for description of one criterion and its weight</para>
    /// labels<para>Vážené kritérium pro udělení zakázky</para><para>Contract award weighted criterion</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#CriterionWeighting">http://purl.org/procurement/public-contracts#CriterionWeighting</seealso>
    let CriterionWeighting = Prefixed_Name(pco, "CriterionWeighting") |> PrefixedName
    /// <summary>
    ///   <para>pco:FrameworkAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class for decribing a framework agreement</para>
    ///   <para>Třída pro popis rámcové smlouvy</para>
    /// labels<para>Framework agreement</para><para>Rámcová smlouva</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#FrameworkAgreement">http://purl.org/procurement/public-contracts#FrameworkAgreement</seealso>
    let FrameworkAgreement = Prefixed_Name(pco, "FrameworkAgreement") |> PrefixedName
    /// <summary>
    ///   <para>pco:Tender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Basic class for decribing a tender submitted by a bidder</para>
    ///   <para>Základní třída pro popis nabídky zájemce o zakázku</para>
    /// labels<para>Nabídka</para><para>Tender</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#Tender">http://purl.org/procurement/public-contracts#Tender</seealso>
    let Tender = Prefixed_Name(pco, "Tender") |> PrefixedName
    /// <summary>
    ///   <para>pco:TendersOpening</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Opening of tenders submitted for a public contract</para>
    ///   <para>Otevírání nabídek zaslaných pro veřejnou zakázku</para>
    /// labels<para>Otevírání nabídek</para><para>Tenders' opening</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#TendersOpening">http://purl.org/procurement/public-contracts#TendersOpening</seealso>
    let TendersOpening = Prefixed_Name(pco, "TendersOpening") |> PrefixedName
    /// <summary>
    ///   <para>pco:actualEndDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Vlastnost pro skutečné datum konce realizace zakázky. Kardinalita 0..1</para>
    ///   <para>Property for actual end date of public contract's realization. Cardinality 0..1</para>
    /// labels<para>Actual end date of contract realization</para><para>Skutečné datum konce realizace zakázky</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#actualEndDate">http://purl.org/procurement/public-contracts#actualEndDate</seealso>
    let actualEndDate = Prefixed_Name(pco, "actualEndDate") |> PrefixedName
    /// <summary>
    ///   <para>pco:actualPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Vlastnost pro skutečnou cenu zaplacenou za zakázku. Kardinalita 0..1</para>
    ///   <para>Property for actual price of the public contract. Cardinality 0..1</para>
    /// labels<para>Actual price after contract realization</para><para>Skutečná cena po realizaci zakázky</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#actualPrice">http://purl.org/procurement/public-contracts#actualPrice</seealso>
    let actualPrice = Prefixed_Name(pco, "actualPrice") |> PrefixedName
    /// <summary>
    ///   <para>pco:contractPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Abstract property for price of public contract</para>
    ///   <para>Abstraktní vlastnost pro cenu přiřazené k veřejné zakázce</para>
    /// labels<para>Price</para><para>Cena</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#contractPrice">http://purl.org/procurement/public-contracts#contractPrice</seealso>
    let contractPrice = Prefixed_Name(pco, "contractPrice") |> PrefixedName
    /// <summary>
    ///   <para>pco:additionalObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>CPV (Common Procurement Vocabulary) kód popisující doplňující předmět veřejné zakázky. Kardinalita 0..*</para>
    ///   <para>CPV (Common Procurement Vocabulary) code describing an additional object of a public contract. Cardinality 0..*</para>
    /// labels<para>Additional object of contract</para><para>Další předmět zakázky</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#additionalObject">http://purl.org/procurement/public-contracts#additionalObject</seealso>
    let additionalObject = Prefixed_Name(pco, "additionalObject") |> PrefixedName
    /// <summary>
    ///   <para>pco:agreedPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Vlastnost pro cenu napsanou na smlouvě s dodavatelem. Kardinalita 0..1</para>
    ///   <para>Property for a price stated on the contract with the supplier. Cardinality 0..1</para>
    /// labels<para>Smluvní cena</para><para>Agreed price</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#agreedPrice">http://purl.org/procurement/public-contracts#agreedPrice</seealso>
    let agreedPrice = Prefixed_Name(pco, "agreedPrice") |> PrefixedName
    /// <summary>
    ///   <para>pco:agreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Property for attachment of documents containing the agreement between supplier and contractor. Cardinality 0..*</para>
    ///   <para>Vlastnost pro připojení dokumentů obsahujících smlouvy na veřejnou zakázku uzavřené mezi zadavatelem a dodavatelem. Kardinalita 0..*</para>
    /// labels<para>Smlouva na veřejnou zakázku</para><para>Contract agreement</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#agreement">http://purl.org/procurement/public-contracts#agreement</seealso>
    let agreement = Prefixed_Name(pco, "agreement") |> PrefixedName
    /// <summary>
    ///   <para>pco:attachment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Property for attachment of other documents. For attachment of contract specification use pc:specification. For attachment of contract agreement use pc:agreement. Cardinality 0..*</para>
    ///   <para>Vlastnost pro připojení ostatních příloh. Zadávací dokumentaci připojte pomocí pc:specification, smlouvu pomocí pc:agreement. Kardinalita 0..*</para>
    /// labels<para>Contract attachment</para><para>Příloha k zakázce</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#attachment">http://purl.org/procurement/public-contracts#attachment</seealso>
    let attachment = Prefixed_Name(pco, "attachment") |> PrefixedName
    /// <summary>
    ///   <para>pco:authorityKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:CodedProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Property for a kind of a contracting authority. Only a predefined SKOS concept can be used. Cardinality 0..1</para>
    ///   <para>Vlastnost pro druh zadavatele. Lze použít pouze jeden z předdefinovaných SKOS konceptů. Kardinalita 0..1</para>
    /// labels<para>Kind of contracting authority</para><para>Druh zadavatele</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#authorityKind">http://purl.org/procurement/public-contracts#authorityKind</seealso>
    let authorityKind = Prefixed_Name(pco, "authorityKind") |> PrefixedName

    /// <summary>
    ///   <para>pco:awardCriteriaCombination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Property for criteria combination for tender evaluation. Cardinality 0..1</para>
    ///   <para>Vlastnost pro nastavení kombinace kritérií pro hodnocení nabídek zájemců o zakázku. Kardinalita 0..1</para>
    /// labels<para>Kombinace kritérií pro hodnocení nabídek zájemců o zakázku.</para><para>Criteria combination for tender evaluation.</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#awardCriteriaCombination">http://purl.org/procurement/public-contracts#awardCriteriaCombination</seealso>
    let awardCriteriaCombination =
        Prefixed_Name(pco, "awardCriteriaCombination") |> PrefixedName

    /// <summary>
    ///   <para>pco:awardCriterion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Vlastnost pro nastavení jednoho kritéria pro hodnocení nabídek zájemců o zakázku. Kardinalita 0..*</para>
    ///   <para>Property for setting a criterion for tender evaluation. Cardinality 0..*</para>
    /// labels<para>Criterion for contract award.</para><para>Kritérium pro zadání zakázky.</para><para>Critères d'attribution</para><para>Vergabekriterien</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#awardCriterion">http://purl.org/procurement/public-contracts#awardCriterion</seealso>
    let awardCriterion = Prefixed_Name(pco, "awardCriterion") |> PrefixedName
    /// <summary>
    ///   <para>pco:awardDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Vlastnost pro datum přidělení zakázky dodavateli. Kardinalita 0..1</para>
    ///   <para>Property for date of contract award to a bidder. Cardinality 0..1</para>
    /// labels<para>Datum přidělení zakázky</para><para>Date of contract award</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#awardDate">http://purl.org/procurement/public-contracts#awardDate</seealso>
    let awardDate = Prefixed_Name(pco, "awardDate") |> PrefixedName
    /// <summary>
    ///   <para>pco:awardedTender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Vlastnost pro vítěznou nabídku zájemce o zakázku. Kardinalita 0..1</para>
    ///   <para>Property for awarded tender submitted by a bidder. Cardinality 0..1</para>
    /// labels<para>Vybraná nabídka</para><para>Awarded tender</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#awardedTender">http://purl.org/procurement/public-contracts#awardedTender</seealso>
    let awardedTender = Prefixed_Name(pco, "awardedTender") |> PrefixedName
    /// <summary>
    ///   <para>pco:tender</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Vlastnost pro nabídku zájemce o zakázku. Kardinalita 0..*</para>
    ///   <para>Property for a tender submitted by a bidder. Cardinality 0..*</para>
    /// labels<para>Nabídka</para><para>Tender</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#tender">http://purl.org/procurement/public-contracts#tender</seealso>
    let tender = Prefixed_Name(pco, "tender") |> PrefixedName
    /// <summary>
    ///   <para>pco:bidder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Vlastnost pro zájemce o zakázku podávajícího nabídku. Kardinalita 0..1</para>
    ///   <para>Property for bidder submitting the tender. Cardinality 0..1</para>
    /// labels<para>Zájemce o zakázku</para><para>Tender bidder</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#bidder">http://purl.org/procurement/public-contracts#bidder</seealso>
    let bidder = Prefixed_Name(pco, "bidder") |> PrefixedName
    /// <summary>
    ///   <para>pco:contact</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Vlastnost pro kontaktní údaje na místo nebo osobu určenou pro komunikaci s veřejností a zájemci o zakázku. Pokud je kontaktních míst či osob více (např. pro vyzvednutí dokumentace k veřejné zakázce), je pro každou uveden samostatný kontakt. Kardinalita 0..*</para>
    ///   <para>Property for contact information for a person or place responsible for a communication with the public and bidders. If there are more contact places or persons (e.g., for collecting documentation to the public contract), there is a separate contact for each person. Cardinality 0..*</para>
    /// labels<para>Kontaktní osoba</para><para>Contact person</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#contact">http://purl.org/procurement/public-contracts#contact</seealso>
    let contact = Prefixed_Name(pco, "contact") |> PrefixedName
    /// <summary>
    ///   <para>pco:contract</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Veřejná zakázka, pro níž jsou otevírány nabídky</para>
    ///   <para>Public contract, for which tenders are opened</para>
    /// labels<para>Public contract</para><para>Veřejná zakázka</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#contract">http://purl.org/procurement/public-contracts#contract</seealso>
    let contract = Prefixed_Name(pco, "contract") |> PrefixedName

    /// <summary>
    ///   <para>pco:contractingAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Instituce, která vypisuje veřejnou zakázku, přijímá nabídky a vybírá vhodného dodavatele na základě pravidel stanovených zakázkou. Kardinalita 0..1</para>
    ///   <para>Institution which issues a public contract, receives tenders to the contract and chooses a suitable supplier on the base of the conditions given by the contract. Cardinality 0..1</para>
    /// labels<para>Contracting authority</para><para>Zadavatel</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#contractingAuthority">http://purl.org/procurement/public-contracts#contractingAuthority</seealso>
    let contractingAuthority =
        Prefixed_Name(pco, "contractingAuthority") |> PrefixedName

    /// <summary>
    ///   <para>pco:criterionWeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Vlastnost pro specifikaci váhy kritéria pro hodnocení nabídky. Kardinalita 0..1</para>
    ///   <para>Property for criterion weight for tender evaluation. Cardinality 0..1</para>
    /// labels<para>Váha kritéria pro výběr dodavatele zakázky</para><para>Contract award criterion weight</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#criterionWeight">http://purl.org/procurement/public-contracts#criterionWeight</seealso>
    let criterionWeight = Prefixed_Name(pco, "criterionWeight") |> PrefixedName
    /// <summary>
    ///   <para>pco:documentationPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Vlastnost pro cenu zadávací dokumentace k zakázce. Kardinalita 0..1</para>
    ///   <para>Property for price of documentation for public contract. Cardinality 0..1</para>
    /// labels<para>Price of documentation for public contract</para><para>Cena zadávací dokumentace k zakázce</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#documentationPrice">http://purl.org/procurement/public-contracts#documentationPrice</seealso>
    let documentationPrice = Prefixed_Name(pco, "documentationPrice") |> PrefixedName

    /// <summary>
    ///   <para>pco:documentationRequestDeadline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Property for time limit for receipt of requests for documentation. Cardinality 0..1</para>
    ///   <para>Vlastnost pro lhůtu pro vyžádání dokumentace k veřejné zakázce. Kardinalita 0..1</para>
    /// labels<para>Time-limit for receipt of requests for documentation</para><para>Lhůta pro vyžádání dokumentace k veřejné zakázce</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#documentationRequestDeadline">http://purl.org/procurement/public-contracts#documentationRequestDeadline</seealso>
    let documentationRequestDeadline =
        Prefixed_Name(pco, "documentationRequestDeadline") |> PrefixedName

    /// <summary>
    ///   <para>pco:duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Vlastnost pro dobu trvání zakázky. Doba trvání může být uvedena ve dnech, měsících, letech apod. Kardinalita 0..1</para>
    ///   <para>Property for duration of contract. The duration may be described in days, months, years, etc. Cardinality 0..1</para>
    /// labels<para>Duration of contract</para><para>Doba trvání zakázky</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#duration">http://purl.org/procurement/public-contracts#duration</seealso>
    let duration = Prefixed_Name(pco, "duration") |> PrefixedName
    /// <summary>
    ///   <para>pco:estimatedEndDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Vlastnost pro očekávané datum konce realizace zakázky. Kardinalita 0..1</para>
    ///   <para>Property for estimated end date of public contract realization. Cardinality 0..1</para>
    /// labels<para>Očekávané datum konce realizace zakázky</para><para>Estimated end date of contract</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#estimatedEndDate">http://purl.org/procurement/public-contracts#estimatedEndDate</seealso>
    let estimatedEndDate = Prefixed_Name(pco, "estimatedEndDate") |> PrefixedName
    /// <summary>
    ///   <para>pco:estimatedPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Vlastnost pro odhadovanou cenu veřejné zakázky. Může jít o přesně odhadovanou částku nebo interval. Kardinalita 0..1</para>
    ///   <para>Property for estimated price of public contract. It can be an exact estimation or an interval. Cardinality 0..1</para>
    /// labels<para>Odhadovaná cena zakázky</para><para>Exact estimated price</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#estimatedPrice">http://purl.org/procurement/public-contracts#estimatedPrice</seealso>
    let estimatedPrice = Prefixed_Name(pco, "estimatedPrice") |> PrefixedName

    /// <summary>
    ///   <para>pco:expectedNumberOfOperators</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Očekávaný počet účastníků rámcové smlouvy. Kardinalita 0..1</para>
    ///   <para>Expected number of operators of framework agreement. Cardinality 0..1</para>
    /// labels<para>Expected number of operators of framework agreement</para><para>Očekávaný počet účastníků rámcové smlouvy</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#expectedNumberOfOperators">http://purl.org/procurement/public-contracts#expectedNumberOfOperators</seealso>
    let expectedNumberOfOperators =
        Prefixed_Name(pco, "expectedNumberOfOperators") |> PrefixedName

    /// <summary>
    ///   <para>pco:frameworkAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Vlastnost pro rámcovou smlouvu, na jejímž základě byla veřejná zakázka zadána. Kardinalita 0..1</para>
    ///   <para>Property for a framework agreement on which base a public contract was issued. Cardinality 0..1</para>
    /// labels<para>On the base of a framework agreement</para><para>Na základě rámcové smlouvy</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#frameworkAgreement">http://purl.org/procurement/public-contracts#frameworkAgreement</seealso>
    let frameworkAgreement = Prefixed_Name(pco, "frameworkAgreement") |> PrefixedName
    /// <summary>
    ///   <para>pco:item</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An item inquired by a public contract. It can be a combination of several products or services which can be expressed using properties of gr:Offering. Cardinality 0..*</para>
    ///   <para>Položka poptávaná v rámci veřejné zakázky. Může být kombinací několika produktů či služeb, což lze vyjádřit pomocí vlastností gr:Offering. Kardinalita 0..*</para>
    /// </remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#item">http://purl.org/procurement/public-contracts#item</seealso>
    let item = Prefixed_Name(pco, "item") |> PrefixedName
    /// <summary>
    ///   <para>pco:kind</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:CodedProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Kategorie veřejné zakázky specifikuje základní zaměření veřejné zakázky na stavební práce, dodávku zboží nebo služby. Lze použít pouze jeden z předdefinovaných SKOS konceptů. Kardinalita 0..1</para>
    ///   <para>Kind of a public contract specifies a basic focus of the contract on works, supplies or services. Only a predefined SKOS concept can be used. Cardinality 0..1</para>
    /// labels<para>Kategorie zakázky</para><para>Contract kind</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#kind">http://purl.org/procurement/public-contracts#kind</seealso>
    let kind = Prefixed_Name(pco, "kind") |> PrefixedName
    /// <summary>
    ///   <para>pco:location</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Místo, kde dojde k dodání produktu nebo plnění služby nasmlouvané ve veřejné zakázce. Kardinalita 0..*</para>
    ///   <para>Place of delivery of contracted product or performance of contracted service. Cardinality 0..*</para>
    /// labels<para>Place of contract's realization</para><para>Místo uskutečnění zakázky</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#location">http://purl.org/procurement/public-contracts#location</seealso>
    let location = Prefixed_Name(pco, "location") |> PrefixedName
    /// <summary>
    ///   <para>pco:lot</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Property for specifying contract lot. When contract is too big, it is split to lots by contracting authority. Bidders then tender each lot separately. For each lot the authority awards a separate tender. The contract itself has no tenders. Cardinality 0..*</para>
    ///   <para>Vlastnost pro specifikaci části zakázky. Zakázku rozděluje na části zadavatel, pokud je zakázka přiliš velká. Zájemci o zakázku podávají nabídky na každou část odděleně a pro každou část zakázky je vybrán samostatný dodavatel. Pro samotnou zakázku nabídky nejsou podávány. Kardinalita 0..*</para>
    /// labels<para>Contract lot</para><para>Část zakázky</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#lot">http://purl.org/procurement/public-contracts#lot</seealso>
    let lot = Prefixed_Name(pco, "lot") |> PrefixedName
    /// <summary>
    ///   <para>pco:mainActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:CodedProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Property for main activity of contracting authority. Only a predefined SKOS concept can be used. Cardinality 0..1</para>
    ///   <para>Vlastnost pro hlavní aktivitu zadavatele. Lze použít pouze jeden z předdefinovaných SKOS konceptů. Kardinalita 0..1</para>
    /// labels<para>Hlavní aktivita</para><para>Hlavní aktivita</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#mainActivity">http://purl.org/procurement/public-contracts#mainActivity</seealso>
    let mainActivity = Prefixed_Name(pco, "mainActivity") |> PrefixedName
    /// <summary>
    ///   <para>pco:mainObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>CPV (Common Procurement Vocabulary) code describing the main object of a public contract. Cardinality 0..1</para>
    ///   <para>CPV (Common Procurement Vocabulary) kód popisující hlavní předmět veřejné zakázky. Kardinalita 0..1</para>
    /// labels<para>Main object of contract</para><para>Hlavní předmět zakázky</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#mainObject">http://purl.org/procurement/public-contracts#mainObject</seealso>
    let mainObject = Prefixed_Name(pco, "mainObject") |> PrefixedName
    /// <summary>
    ///   <para>pco:numberOfTenders</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Property for number of tenders received. Cardinality 0..1</para>
    ///   <para>Vlastnost pro počet obdržených nabídek. Kardinalita 0..1</para>
    /// labels<para>Number of tenders received</para><para>Počet obdržených nabídek</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#numberOfTenders">http://purl.org/procurement/public-contracts#numberOfTenders</seealso>
    let numberOfTenders = Prefixed_Name(pco, "numberOfTenders") |> PrefixedName
    /// <summary>
    ///   <para>pco:offeredPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Property for price offered by supplier. Cardinality 0..1</para>
    ///   <para>Vlastnost pro cenu nabídnutou zájemcem o zakázku. Kardinalita 0..1</para>
    /// labels<para>Nabídnutá cena v nabídce</para><para>Offered price in tender</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#offeredPrice">http://purl.org/procurement/public-contracts#offeredPrice</seealso>
    let offeredPrice = Prefixed_Name(pco, "offeredPrice") |> PrefixedName
    /// <summary>
    ///   <para>pco:onBehalfOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Zadání zakázky jménem jiných zadavatelů. Kardinalita 0..*</para>
    ///   <para>Contract award on behalf of other contracting authorities. Cardinality 0..*</para>
    /// labels<para>On behalf of</para><para>Jménem</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#onBehalfOf">http://purl.org/procurement/public-contracts#onBehalfOf</seealso>
    let onBehalfOf = Prefixed_Name(pco, "onBehalfOf") |> PrefixedName
    /// <summary>
    ///   <para>pco:procedureType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>qb:CodedProperty</para>
    ///   <para>Druh řízení veřejné zakázky specifikuje proceduru, podle které je zakázka uveřejňována a podle které je vybírán dodavatel. Lze použít pouze jednu z předdefinovaných hodnot. Kardinalita 0..1</para>
    ///   <para>Type of procedure of a public contract specifies a procedure which is applied to publish information about the contract and choose a supplier. Only a predefined value can be used. Cardinality 0..1</para>
    /// labels<para>Procedure type</para><para>Druh řízení</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#procedureType">http://purl.org/procurement/public-contracts#procedureType</seealso>
    let procedureType = Prefixed_Name(pco, "procedureType") |> PrefixedName
    /// <summary>
    ///   <para>pco:profile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>Vlastnost pro internetovou adresu profilové stránky zadavatele veřejných zakázek (URL). Kardinalita 0..1</para>
    ///   <para>Property for the internet address of the profile of contracting authority (URL). Cardinality 0..1</para>
    /// labels<para>Profile web site of contracting authority</para><para>Profilová stránka zadavatele</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#profile">http://purl.org/procurement/public-contracts#profile</seealso>
    let profile = Prefixed_Name(pco, "profile") |> PrefixedName
    /// <summary>
    ///   <para>pco:specification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Property for attachment of documents containing the contract specification. Cardinality 0..*</para>
    ///   <para>Vlastnost pro připojení dokumentů obsahujících zadávací dokumentaci veřejné zakázky. Kardinalita 0..*</para>
    /// labels<para>Zadávací dokumentace zakázky</para><para>Contract specification</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#specification">http://purl.org/procurement/public-contracts#specification</seealso>
    let specification = Prefixed_Name(pco, "specification") |> PrefixedName
    /// <summary>
    ///   <para>pco:startDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Property for start date of public contract realization coming from the contract's text. Cardinality 0..1</para>
    ///   <para>Vlastnost pro datum začátku realizace zakázky, které je uvedené ve smlouvě. Kardinalita 0..1</para>
    /// labels<para>Datum začátku realizace zakázky</para><para>Start date of contract</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#startDate">http://purl.org/procurement/public-contracts#startDate</seealso>
    let startDate = Prefixed_Name(pco, "startDate") |> PrefixedName
    /// <summary>
    ///   <para>pco:subsidy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Vlastnost pro dotaci použitou pro zakázku. Kardinalita 0..*</para>
    ///   <para>Property for used tender subsidy. Cardinality 0..*</para>
    /// labels<para>Subsidy supplemented for contract</para><para>Dotace použitá pro zakázku</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#subsidy">http://purl.org/procurement/public-contracts#subsidy</seealso>
    let subsidy = Prefixed_Name(pco, "subsidy") |> PrefixedName
    /// <summary>
    ///   <para>pco:tenderDeadline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Property for time limit for receipt of tenders or requests to participate. Cardinality 0..1</para>
    ///   <para>Vlastnost pro lhůtu pro doručení nabídek nebo přijetí žádostí o účast. Kardinalita 0..1</para>
    /// labels<para>Time-limit for receipt of tenders or requests to participate</para><para>Lhůta pro doručení nabídek nebo přijetí žádostí o účast</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#tenderDeadline">http://purl.org/procurement/public-contracts#tenderDeadline</seealso>
    let tenderDeadline = Prefixed_Name(pco, "tenderDeadline") |> PrefixedName

    /// <summary>
    ///   <para>pco:tenderMaintenanceDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Property for expressing minimum time frame during which the tenderer must maintain the tender. The duration may be described in days, months, years, etc. Cardinality 0..1</para>
    ///   <para>Vlastnost pro vyjádření minimální doby, po kterou je uchazeč svou nabídkou vázán. Doba trvání může být uvedena ve dnech, měsících, letech apod. Kardinalita 0..1</para>
    /// labels<para>Duration of tender validity</para><para>Doba trvání nabídky</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#tenderMaintenanceDuration">http://purl.org/procurement/public-contracts#tenderMaintenanceDuration</seealso>
    let tenderMaintenanceDuration =
        Prefixed_Name(pco, "tenderMaintenanceDuration") |> PrefixedName

    /// <summary>
    ///   <para>pco:weightedCriterion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Vlastnost pro připojení kritéria, které je váženo. Kardinalita 0..1</para>
    ///   <para>Property for attaching criterion that is weighted. Cardinality 0..1</para>
    /// labels<para>Weighted criterion</para><para>Vážené kritérium</para></remarks>
    /// <seealso href="http://purl.org/procurement/public-contracts#weightedCriterion">http://purl.org/procurement/public-contracts#weightedCriterion</seealso>
    let weightedCriterion = Prefixed_Name(pco, "weightedCriterion") |> PrefixedName

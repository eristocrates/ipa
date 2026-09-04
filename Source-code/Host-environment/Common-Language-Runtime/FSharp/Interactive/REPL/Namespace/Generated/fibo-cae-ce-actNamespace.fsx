#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-cae-ce-act`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/" "fibo-cae-ce-act"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : action</para>
    ///   <para>skos:definition : event announced, initiated or carried out by an organization that affects a legal entity or the securities it issues and may have a material impact on that entity's stakeholders, such as shareholders and creditors</para>
    ///   <para>skos:example : Actions that impact an entity may be initiated by an issuer, exchange, regulator, creditor, or other third party.</para>
    ///   <para>cmns-av:explanatoryNote : Actions initiated by an issuer are typically approved by that company's board of directors and authorized by their shareholders.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/Action">fibo-cae-ce-act:Action</a>
    /// </summary>
    let Action = _prefixId.prefix "Action"
    /// <summary>
    ///   <para>rdfs:label : action classification scheme^^xsd:string</para>
    ///   <para>skos:definition : scheme for classifying the kinds of actions and events that may be announced, initiated or carried out by an organization that affects a legal entity or the securities it issues^^xsd:string</para>
    ///   <para>cmns-av:usageNote : The set of corporate actions and income events included herein are a subset of those specified in a combination of ISO 15022 Securities - Scheme for Messages (Data Field Dictionary) and the GLEIF LEI-related corporate actions. Other schemes that are specific to a custodian, depository, or regulatory agency may also be important, and should take a similar approach with respect to classification.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/ActionClassificationScheme">fibo-cae-ce-act:ActionClassificationScheme</a>
    /// </summary>
    let ActionClassificationScheme = _prefixId.prefix "ActionClassificationScheme"
    /// <summary>
    ///   <para>rdfs:label : action classifier</para>
    ///   <para>skos:definition : classifier that distinguishes the kinds of actions and events that may be announced, initiated or carried out by an organization that affects a legal entity or the securities it issues, such as income-oriented events</para>
    ///   <para>cmns-av:explanatoryNote : ISO 15022 classifies events as impacting income vs. others. Other classification schemes distinguish between actions that return profits to shareholders, actions that are designed to influence the share price, and actions involving a change in structure to the issuer organization.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/ActionClassifier">fibo-cae-ce-act:ActionClassifier</a>
    /// </summary>
    let ActionClassifier = _prefixId.prefix "ActionClassifier"
    /// <summary>
    ///   <para>rdfs:label : action status</para>
    ///   <para>skos:definition : state of some action at some point in time</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/ActionStatus">fibo-cae-ce-act:ActionStatus</a>
    /// </summary>
    let ActionStatus = _prefixId.prefix "ActionStatus"
    /// <summary>
    ///   <para>rdfs:label : business strategy classifier</para>
    ///   <para>skos:definition : classifier of corporate actions that involve improving liquidity or changing the overall structure of the organization through diversification, combining and closing parts of the business, etc, to increase long-term profitability</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/BusinessStrategyClassifier">fibo-cae-ce-act:BusinessStrategyClassifier</a>
    /// </summary>
    let BusinessStrategyClassifier = _prefixId.prefix "BusinessStrategyClassifier"
    /// <summary>
    ///   <para>rdfs:label : change action</para>
    ///   <para>skos:definition : corporate action to disseminate information regarding a change further described in the corporate action details</para>
    ///   <para>cmns-av:explanatoryNote : Generic changes may include a change in the terms of an issue, change in the identification of a security, change of board lot, change from global to definitive, etc.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/ChangeAction">fibo-cae-ce-act:ChangeAction</a>
    /// </summary>
    let ChangeAction = _prefixId.prefix "ChangeAction"
    /// <summary>
    ///   <para>rdfs:label : class action</para>
    ///   <para>skos:definition : corporate action involving a situation where interested parties seek restitution for financial loss</para>
    ///   <para>cmns-av:explanatoryNote : The security holder may be offered the opportunity to join a class action proceeding and would need to respond with an instruction.</para>
    ///   <para>cmns-av:synonym : proposed settlement</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/ClassAction">fibo-cae-ce-act:ClassAction</a>
    /// </summary>
    let ClassAction = _prefixId.prefix "ClassAction"
    /// <summary>
    ///   <para>rdfs:label : consent solicitation</para>
    ///   <para>skos:definition : corporate action that is a procedure that aims to obtain consent of holder to a proposal by the issuer or a third party without convening a meeting</para>
    ///   <para>skos:example : For example, consent to change the terms of a bond.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/ConsentSolicitation">fibo-cae-ce-act:ConsentSolicitation</a>
    /// </summary>
    let ConsentSolicitation = _prefixId.prefix "ConsentSolicitation"
    /// <summary>
    ///   <para>rdfs:label : corporate action</para>
    ///   <para>skos:definition : action carried out by or specifically relating to a legal entity that may affect the securities it issues and may have a material impact on its stakeholders, such as shareholders and creditors</para>
    ///   <para>skos:example : Examples of corporate actions include share issues, stock splits, consolidation, dividends, mergers and acquisitions, rights issues, spin-offs, and the inception of court actions.</para>
    ///   <para>cmns-av:explanatoryNote : Corporate actions are typically approved by a company's board of directors and authorized by the shareholders.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/CorporateAction">fibo-cae-ce-act:CorporateAction</a>
    /// </summary>
    let CorporateAction = _prefixId.prefix "CorporateAction"
    /// <summary>
    ///   <para>rdfs:label : disclosure action</para>
    ///   <para>skos:definition : corporate action involving a request for holders or beneficial owners to disclose their name, location and holdings of any issue to the issuer</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/DisclosureAction">fibo-cae-ce-act:DisclosureAction</a>
    /// </summary>
    let DisclosureAction = _prefixId.prefix "DisclosureAction"
    /// <summary>
    ///   <para>rdfs:label : divestiture</para>
    ///   <para>skos:definition : corporate action involving the sales of subsidiary business interests or investments</para>
    ///   <para>skos:note : Divestiture is an action or process involving the sale, spinoff, or liquidation of business assets, including product lines, services, subsidiaries, business property, or even an entire business. Companies may pursue a divestment strategy to refocus on their core business, in response to the operating environment in their industry, to raise capital, or to release underperforming assets.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/Divestiture">fibo-cae-ce-act:Divestiture</a>
    /// </summary>
    let Divestiture = _prefixId.prefix "Divestiture"
    /// <summary>
    ///   <para>rdfs:label : income-oriented classifier</para>
    ///   <para>skos:definition : classifier of corporate actions that impacts income to shareholders</para>
    ///   <para>cmns-av:explanatoryNote : Cash dividends are a classic example where a public company declares a dividend to be paid on each outstanding share. Bonus is another case where the shareholder is rewarded. In a stricter sense, the bonus issue should not impact the share price but in reality, in rare cases, it does and results in an overall increase in value.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/IncomeOrientedClassifier">fibo-cae-ce-act:IncomeOrientedClassifier</a>
    /// </summary>
    let IncomeOrientedClassifier = _prefixId.prefix "IncomeOrientedClassifier"
    /// <summary>
    ///   <para>rdfs:label : legal form change</para>
    ///   <para>skos:definition : corporate action indicating a modification of the legal form of the organization</para>
    ///   <para>skos:example : In the United States it is common for companies established as Subchapter S Corporations (S-Corp), typically early stage companies, to modify their structure to become full-fledged Subchapter C Corporations (C-Corp) to facilitate outside fundraising, mergers, acquisitions, and public offerings. Other common form changes include migration from sole proprietorships to more formally registered organizations (e.g., LLC, S-Corp, C-Corp, etc.)</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/LegalFormChange">fibo-cae-ce-act:LegalFormChange</a>
    /// </summary>
    let LegalFormChange = _prefixId.prefix "LegalFormChange"
    /// <summary>
    ///   <para>rdfs:label : liquidation</para>
    ///   <para>skos:definition : corporate action related to winding up a business, including but not limited to distribution of cash, assets, or both</para>
    ///   <para>cmns-av:explanatoryNote : Debt may be paid in order of priority based on preferred claims to assets specified by a security, for example.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/Liquidation">fibo-cae-ce-act:Liquidation</a>
    /// </summary>
    let Liquidation = _prefixId.prefix "Liquidation"
    /// <summary>
    ///   <para>rdfs:label : mandatory corporate action</para>
    ///   <para>skos:definition : action initiated by the board of directors of a corporation that affects all shareholders</para>
    ///   <para>skos:example : Examples of mandatory corporate actions include cash dividends, stock splits, mergers, pre-refunding, return of capital, bonus issue, asset ID change, and spin-offs.</para>
    ///   <para>cmns-av:explanatoryNote : Mandatory means mandatory participation by all shareholders, however the shareholder is not required to do anything.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/MandatoryCorporateAction">fibo-cae-ce-act:MandatoryCorporateAction</a>
    /// </summary>
    let MandatoryCorporateAction = _prefixId.prefix "MandatoryCorporateAction"

    /// <summary>
    ///   <para>rdfs:label : mandatory with choice corporate action</para>
    ///   <para>skos:definition : mandatory corporate action where shareholders are given an opportunity to choose among several options</para>
    ///   <para>cmns-av:explanatoryNote : In case a shareholder does not submit the election, the default option will be applied.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/MandatoryWithChoiceCorporateAction">fibo-cae-ce-act:MandatoryWithChoiceCorporateAction</a>
    /// </summary>
    let MandatoryWithChoiceCorporateAction =
        _prefixId.prefix "MandatoryWithChoiceCorporateAction"

    /// <summary>
    ///   <para>rdfs:label : market action</para>
    ///   <para>skos:definition : action that is initiated by a market, such as a securities exchange, that affects a legal entity or the securities it issues and may have a material impact on that entity's stakeholders, such as shareholders and creditors</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/MarketAction">fibo-cae-ce-act:MarketAction</a>
    /// </summary>
    let MarketAction = _prefixId.prefix "MarketAction"
    /// <summary>
    ///   <para>rdfs:label : merger / acquisition</para>
    ///   <para>skos:definition : corporate action involving the consolidation of legal entities or assets</para>
    ///   <para>cmns-av:explanatoryNote : Such consolidation may be accomplished via financial transactions such as mergers, acquisitions, consolidations, tender offers, purchase of assets, and management acquisitions.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/MergerAcquisition">fibo-cae-ce-act:MergerAcquisition</a>
    /// </summary>
    let MergerAcquisition = _prefixId.prefix "MergerAcquisition"
    /// <summary>
    ///   <para>rdfs:label : notification</para>
    ///   <para>skos:definition : corporate action involving information provided by the issuer having no accounting/financial impact on the holder</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/Notification">fibo-cae-ce-act:Notification</a>
    /// </summary>
    let Notification = _prefixId.prefix "Notification"
    /// <summary>
    ///   <para>rdfs:label : organization address change</para>
    ///   <para>skos:definition : information action that provides details of address changes for a legal entity</para>
    ///   <para>skos:note : Address changes may impact securities master data management, including but not limited to where shares are registered and by whom.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/OrganizationAddressChange">fibo-cae-ce-act:OrganizationAddressChange</a>
    /// </summary>
    let OrganizationAddressChange = _prefixId.prefix "OrganizationAddressChange"
    /// <summary>
    ///   <para>rdfs:label : organization name change</para>
    ///   <para>skos:definition : information action that provides details of name changes for a legal entity</para>
    ///   <para>skos:note : Name changes may include legal name changes as well as 'doing business as', and other operational names for an organization.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/OrganizationNameChange">fibo-cae-ce-act:OrganizationNameChange</a>
    /// </summary>
    let OrganizationNameChange = _prefixId.prefix "OrganizationNameChange"
    /// <summary>
    ///   <para>rdfs:label : priority issue</para>
    ///   <para>skos:definition : corporate action that is a public offer where, due to a limited amount of securities available, priority is given to existing shareholders</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/PriorityIssue">fibo-cae-ce-act:PriorityIssue</a>
    /// </summary>
    let PriorityIssue = _prefixId.prefix "PriorityIssue"
    /// <summary>
    ///   <para>rdfs:label : regulatory action</para>
    ///   <para>skos:definition : action initiated by a regulatory agency that affects a legal entity or the securities it issues and may have a material impact on that entity's stakeholders, such as shareholders and creditors</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/RegulatoryAction">fibo-cae-ce-act:RegulatoryAction</a>
    /// </summary>
    let RegulatoryAction = _prefixId.prefix "RegulatoryAction"
    /// <summary>
    ///   <para>rdfs:label : spin off</para>
    ///   <para>skos:definition : corporate action involving the distribution of subsidiary stock to the shareholders of the parent company without a surrender of shares</para>
    ///   <para>cmns-av:explanatoryNote : Spin-off represents a form of divestiture usually resulting in an independent company or in an existing company. Examples include demerger, distribution, and unbundling.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/SpinOff">fibo-cae-ce-act:SpinOff</a>
    /// </summary>
    let SpinOff = _prefixId.prefix "SpinOff"
    /// <summary>
    ///   <para>rdfs:label : voluntary corporate action</para>
    ///   <para>skos:definition : event in which the shareholders elect to participate and must respond in order for the issuer to process the action</para>
    ///   <para>skos:example : An example of a voluntary corporate action is a tender offer, in which the issuer may request shareholders to tender their shares at a predetermined price.</para>
    ///   <para>cmns-av:explanatoryNote : Shareholders send responses to the issuer's agents, and the issuer will send the proceeds of the action to those shareholders who elect to participate.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/VoluntaryCorporateAction">fibo-cae-ce-act:VoluntaryCorporateAction</a>
    /// </summary>
    let VoluntaryCorporateAction = _prefixId.prefix "VoluntaryCorporateAction"

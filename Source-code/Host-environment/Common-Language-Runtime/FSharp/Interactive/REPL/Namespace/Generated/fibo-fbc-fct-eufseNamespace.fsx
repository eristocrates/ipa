#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fbc-fct-eufse`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/" "fibo-fbc-fct-eufse"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : CRD credit institution^^xsd:string</para>
    ///   <para>skos:definition : an undertaking whose business is to receive deposits or other repayable funds from the public and to grant credits for its own account as defined by the European Banking Authority (EBA)^^xsd:string</para>
    ///   <para>fibo-fnd-utl-av:definitionOrigin : http://www.eba.europa.eu/risk-analysis-and-data/credit-institutions-register^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/CRDCreditInstitution">fibo-fbc-fct-eufse:CRDCreditInstitution</a>
    /// </summary>
    let CRDCreditInstitution = _prefixId.prefix "CRDCreditInstitution"
    /// <summary>
    ///   <para>rdfs:label : credit institution^^xsd:string</para>
    ///   <para>skos:definition : an undertaking the business of which is to take deposits or other repayable funds from the public and to grant credits for its own account, and to which authorisation has been granted to operate within the European Union and European Economic Area countries (EEA)^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://eur-lex.europa.eu/legal-content/EN/TXT/PDF/?uri=CELEX:32013R0575&amp;from=EN#page=18^^xsd:anyURIcmns-av:adaptedFrom : http://www.eba.europa.eu/risk-analysis-and-data/credit-institutions-register^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/CreditInstitution">fibo-fbc-fct-eufse:CreditInstitution</a>
    /// </summary>
    let CreditInstitution = _prefixId.prefix "CreditInstitution"

    /// <summary>
    ///   <para>rdfs:label : credit institution / investment firm^^xsd:string</para>
    ///   <para>skos:definition : classification specific to European financial institutions that designates them as credit institutions / investment firms as defined by the European Banking Authority (EBA)^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://eur-lex.europa.eu/legal-content/EN/TXT/PDF/?uri=CELEX:32013R0575&amp;from=EN#page=18^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/CreditInstitutionInvestmentFirm">fibo-fbc-fct-eufse:CreditInstitutionInvestmentFirm</a>
    /// </summary>
    let CreditInstitutionInvestmentFirm =
        _prefixId.prefix "CreditInstitutionInvestmentFirm"

    /// <summary>
    ///   <para>rdfs:label : European Economic Area branch^^xsd:string</para>
    ///   <para>skos:definition : a branch of a credit institution authorised in another European Economic Area (EEA) country that has the right to passport its activities^^xsd:string</para>
    ///   <para>fibo-fnd-utl-av:definitionOrigin : http://www.eba.europa.eu/risk-analysis-and-data/credit-institutions-register^^xsd:anyURI</para>
    ///   <para>cmns-av:synonym : EEA branch^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/EuropeanEconomicAreaBranch">fibo-fbc-fct-eufse:EuropeanEconomicAreaBranch</a>
    /// </summary>
    let EuropeanEconomicAreaBranch = _prefixId.prefix "EuropeanEconomicAreaBranch"
    /// <summary>
    ///   <para>rdfs:label : investment firm^^xsd:string</para>
    ///   <para>skos:definition : any legal person whose regular occupation or business is the provision of one or more investment services to third parties and/or the performance of one or more investment activities on a professional basis^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://eur-lex.europa.eu/legal-content/EN/TXT/PDF/?uri=CELEX:32004L0039&amp;from=en#page=9^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/InvestmentFirm">fibo-fbc-fct-eufse:InvestmentFirm</a>
    /// </summary>
    let InvestmentFirm = _prefixId.prefix "InvestmentFirm"
    /// <summary>
    ///   <para>rdfs:label : local firm^^xsd:string</para>
    ///   <para>skos:definition : a firm dealing for its own account on markets in financial futures or options or other derivatives and on cash markets for the sole purpose of hedging positions on derivatives markets, or dealing for the accounts of other members of those markets and being guaranteed by clearing members of the same markets, where responsibility for ensuring the performance of contracts entered into by such a firm is assumed by clearing members of the same markets^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://eur-lex.europa.eu/legal-content/EN/TXT/PDF/?uri=CELEX:32013R0575&amp;from=EN#page=18^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/LocalFirm">fibo-fbc-fct-eufse:LocalFirm</a>
    /// </summary>
    let LocalFirm = _prefixId.prefix "LocalFirm"
    /// <summary>
    ///   <para>rdfs:label : non European Economic Area branch^^xsd:string</para>
    ///   <para>skos:definition : a branch of a credit institution whose Head Office is in a third country^^xsd:string</para>
    ///   <para>fibo-fnd-utl-av:definitionOrigin : http://www.eba.europa.eu/risk-analysis-and-data/credit-institutions-register^^xsd:anyURI</para>
    ///   <para>cmns-av:synonym : non-EEA branch^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/NonEuropeanEconomicAreaBranch">fibo-fbc-fct-eufse:NonEuropeanEconomicAreaBranch</a>
    /// </summary>
    let NonEuropeanEconomicAreaBranch = _prefixId.prefix "NonEuropeanEconomicAreaBranch"
    /// <summary>
    ///   <para>rdfs:label : payment institution^^xsd:string</para>
    ///   <para>skos:definition : a legal person that has been granted authorisation in accordance with Article 10 to provide and execute payment services throughout the European community^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://eur-lex.europa.eu/legal-content/EN/TXT/PDF/?uri=CELEX:32007L0064&amp;from=EN#page=18^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/PaymentInstitution">fibo-fbc-fct-eufse:PaymentInstitution</a>
    /// </summary>
    let PaymentInstitution = _prefixId.prefix "PaymentInstitution"

#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fnd-arr-asmt`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/" "fibo-fnd-arr-asmt"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : appraisal^^xsd:string</para>
    ///   <para>skos:definition : written estimate of the market value of something as of some point in time, typically provided by a qualified appraiser^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/Appraisal">fibo-fnd-arr-asmt:Appraisal</a>
    /// </summary>
    let Appraisal = _prefixId.prefix "Appraisal"
    /// <summary>
    ///   <para>rdfs:label : appraised value^^xsd:string</para>
    ///   <para>skos:definition : estimated value of some asset as of a given point in time^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/AppraisedValue">fibo-fnd-arr-asmt:AppraisedValue</a>
    /// </summary>
    let AppraisedValue = _prefixId.prefix "AppraisedValue"
    /// <summary>
    ///   <para>rdfs:label : appraiser^^xsd:string</para>
    ///   <para>skos:definition : party that evaluates or estimates the nature, quality, ability, or value of someone or something^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/Appraiser">fibo-fnd-arr-asmt:Appraiser</a>
    /// </summary>
    let Appraiser = _prefixId.prefix "Appraiser"
    /// <summary>
    ///   <para>rdfs:label : assessment activity^^xsd:string</para>
    ///   <para>skos:definition : activity involving the evaluation or estimation of the nature, quality, ability, or value of someone or something^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/AssessmentActivity">fibo-fnd-arr-asmt:AssessmentActivity</a>
    /// </summary>
    let AssessmentActivity = _prefixId.prefix "AssessmentActivity"
    /// <summary>
    ///   <para>rdfs:label : assessment event^^xsd:string</para>
    ///   <para>skos:definition : event involving the evaluation or estimation of the nature, quality, or ability of someone or something^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/AssessmentEvent">fibo-fnd-arr-asmt:AssessmentEvent</a>
    /// </summary>
    let AssessmentEvent = _prefixId.prefix "AssessmentEvent"
    /// <summary>
    ///   <para>rdfs:label : assessment report^^xsd:string</para>
    ///   <para>skos:definition : report that includes an opinion, judgement, appraisal, or view about something and typically the methodology and raw inputs used to arrive at that opinion^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/AssessmentReport">fibo-fnd-arr-asmt:AssessmentReport</a>
    /// </summary>
    let AssessmentReport = _prefixId.prefix "AssessmentReport"
    /// <summary>
    ///   <para>rdfs:label : expected value^^xsd:string</para>
    ///   <para>skos:definition : theoretical value that is anticipated based on a model or hypothesis^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Expected values are often calculated using probability distributions. Note that they can be qualitative, however, such as certain ratings.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/ExpectedValue">fibo-fnd-arr-asmt:ExpectedValue</a>
    /// </summary>
    let ExpectedValue = _prefixId.prefix "ExpectedValue"
    /// <summary>
    ///   <para>rdfs:label : fair value^^xsd:string</para>
    ///   <para>skos:definition : price that would be received to sell an asset, or paid to transfer a liability, in an orderly transaction between market participants at the measurement date^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO/TS 55010:2024(en), Asset management - Guidance on the alignment of financial and non-financial functions in asset management^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/FairValue">fibo-fnd-arr-asmt:FairValue</a>
    /// </summary>
    let FairValue = _prefixId.prefix "FairValue"
    /// <summary>
    ///   <para>rdfs:label : market value^^xsd:string</para>
    ///   <para>skos:definition : price an asset would sell for in the market^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/MarketValue">fibo-fnd-arr-asmt:MarketValue</a>
    /// </summary>
    let MarketValue = _prefixId.prefix "MarketValue"
    /// <summary>
    ///   <para>rdfs:label : observed value^^xsd:string</para>
    ///   <para>skos:definition : value that is an actual data point collected from an experiment, survey, or observation^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/ObservedValue">fibo-fnd-arr-asmt:ObservedValue</a>
    /// </summary>
    let ObservedValue = _prefixId.prefix "ObservedValue"
    /// <summary>
    ///   <para>rdfs:label : opinion^^xsd:string</para>
    ///   <para>skos:definition : judgement, appraisal, or view about something^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/Opinion">fibo-fnd-arr-asmt:Opinion</a>
    /// </summary>
    let Opinion = _prefixId.prefix "Opinion"
    /// <summary>
    ///   <para>rdfs:label : present value^^xsd:string</para>
    ///   <para>skos:definition : value of an asset today, which may be calculated from reference data and may based on its expected future value^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/PresentValue">fibo-fnd-arr-asmt:PresentValue</a>
    /// </summary>
    let PresentValue = _prefixId.prefix "PresentValue"
    /// <summary>
    ///   <para>rdfs:label : qualitative value^^xsd:string</para>
    ///   <para>skos:definition : value that has less precision or accuracy than a value determined via quantitative methods and which is usually expressed in codes rather than actual numbers^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO/IEC 5207:2024(en), Information technology - Data usage - Terminology and use cases^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Qualitative values may follow nominal or ordinal scales, and may be expressed as enumerations.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/QualitativeValue">fibo-fnd-arr-asmt:QualitativeValue</a>
    /// </summary>
    let QualitativeValue = _prefixId.prefix "QualitativeValue"
    /// <summary>
    ///   <para>rdfs:label : quantitative value^^xsd:string</para>
    ///   <para>skos:definition : value determined via quantitative methods, expressed as a numerical value in appropriate units^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/QuantitativeValue">fibo-fnd-arr-asmt:QuantitativeValue</a>
    /// </summary>
    let QuantitativeValue = _prefixId.prefix "QuantitativeValue"
    /// <summary>
    ///   <para>rdfs:label : reference value^^xsd:string</para>
    ///   <para>skos:definition : value for something discernible for which evidence can be obtained^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Derivatives, such as certain exotics, can be based on values ascribed to virtually anything, including weather. Typically, however, a reference value refers to something that can be readily observed in the marketplace, such as a quoted rate (e.g., interest rate, exchange rate), index value, commodity price, stock price, economic indicator, or something similar as of some point in time.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/ReferenceValue">fibo-fnd-arr-asmt:ReferenceValue</a>
    /// </summary>
    let ReferenceValue = _prefixId.prefix "ReferenceValue"
    /// <summary>
    ///   <para>rdfs:label : valuation method</para>
    ///   <para>skos:definition : method used to determine the present or expected worth of an asset</para>
    ///   <para>cmns-av:explanatoryNote : Asset valuation is the process of determining the fair market or present value of assets, using book values, absolute valuation models like discounted cash flow analysis, option pricing models or comparables. Such assets include investments in marketable securities such as stocks, bonds and options; tangible assets like buildings and equipment; or intangible assets such as brands, patents and trademarks.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/ValuationMethod">fibo-fnd-arr-asmt:ValuationMethod</a>
    /// </summary>
    let ValuationMethod = _prefixId.prefix "ValuationMethod"
    /// <summary>
    ///   <para>rdfs:label : value^^xsd:string</para>
    ///   <para>skos:definition : perceived worth of something, such as a product, service, or asset to a company, customer, or stakeholder^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The concept of business value encompasses several dimensions, including:
    /// - Customer Value: The benefits that a customer derives from a product or service, measured against the cost of obtaining it. This includes factors like quality, performance, convenience, and price.
    /// - Economic Value: The financial benefits that a company gains from its assets, investments, or operations. This can be calculated through metrics like revenue, profit, return on investment (ROI), and cost savings.
    /// - Market Value: The price at which an asset or company can be bought or sold in the open market. This reflects the collective assessment of investors and market participants.
    /// - Shareholder Value: The financial returns that shareholders receive from owning a company's stock, including dividends and capital gains.
    /// - Brand Value: The premium that customers are willing to pay for a product or service due to the brand's reputation, recognition, and loyalty.
    ///
    /// Overall, value in business is about creating and capturing benefits that meet the needs and expectations of various stakeholders, from customers to investors.^^xsd:string</para>
    ///   <para>cmns-av:synonym : business value^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/Value">fibo-fnd-arr-asmt:Value</a>
    /// </summary>
    let Value = _prefixId.prefix "Value"
    /// <summary>
    ///   <para>rdfs:label : value assessment^^xsd:string</para>
    ///   <para>skos:definition : assessment event to estimate the value of something^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Note that an appraiser in this context may be a licensed appraiser, such as a real estate appraiser or auction house, or a calculation agent, depending on the circumstances.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/ValueAssessment">fibo-fnd-arr-asmt:ValueAssessment</a>
    /// </summary>
    let ValueAssessment = _prefixId.prefix "ValueAssessment"
    /// <summary>
    ///   <para>rdfs:label : applies methodology^^xsd:string</para>
    ///   <para>skos:definition : indicates the strategy used for the purposes of determining the fair market or present value of something^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/appliesMethodology">fibo-fnd-arr-asmt:appliesMethodology</a>
    /// </summary>
    let appliesMethodology = _prefixId.prefix "appliesMethodology"
    /// <summary>
    ///   <para>rdfs:label : estimates value at^^xsd:string</para>
    ///   <para>skos:definition : provides an approximate value of some asset as of some point in time^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/estimatesValueAt">fibo-fnd-arr-asmt:estimatesValueAt</a>
    /// </summary>
    let estimatesValueAt = _prefixId.prefix "estimatesValueAt"
    /// <summary>
    ///   <para>rdfs:label : has appraiser^^xsd:string</para>
    ///   <para>skos:definition : relates an assessment or report to an agent that conducts the assessment^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/hasAppraiser">fibo-fnd-arr-asmt:hasAppraiser</a>
    /// </summary>
    let hasAppraiser = _prefixId.prefix "hasAppraiser"
    /// <summary>
    ///   <para>rdfs:label : has date of assessment</para>
    ///   <para>skos:definition : date on which an assessment process was completed</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/hasDateOfAssessment">fibo-fnd-arr-asmt:hasDateOfAssessment</a>
    /// </summary>
    let hasDateOfAssessment = _prefixId.prefix "hasDateOfAssessment"
    /// <summary>
    ///   <para>rdfs:label : has estimated value^^xsd:string</para>
    ///   <para>skos:definition : relates something to its estimated value^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/hasEstimatedValue">fibo-fnd-arr-asmt:hasEstimatedValue</a>
    /// </summary>
    let hasEstimatedValue = _prefixId.prefix "hasEstimatedValue"
    /// <summary>
    ///   <para>rdfs:label : is estimated value of^^xsd:string</para>
    ///   <para>skos:definition : relates an appraised value to the asset of interest as of the date of the assessment^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/isEstimatedValueOf">fibo-fnd-arr-asmt:isEstimatedValueOf</a>
    /// </summary>
    let isEstimatedValueOf = _prefixId.prefix "isEstimatedValueOf"

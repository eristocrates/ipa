namespace https.spec.edmcouncil.org.fibo.ontology.FND.Arrangements.Assessments.slash

open DoxAletheia

module fibo_fnd_arr_asmt =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/Appraisal"></see>
    /// </summary>
    let Appraisal = _prefix "Appraisal"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/AssessmentReport"></see>
    /// </summary>
    let AssessmentReport = _prefix "AssessmentReport"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/Appraiser"></see>
    /// </summary>
    let Appraiser = _prefix "Appraiser"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/estimatesValueAt"></see>
    /// </summary>
    let estimatesValueAt = _prefix "estimatesValueAt"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/AppraisedValue"></see>
    /// </summary>
    let AppraisedValue = _prefix "AppraisedValue"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/MarketValue"></see>
    /// </summary>
    let MarketValue = _prefix "MarketValue"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/AssessmentActivity"></see>
    /// </summary>
    let AssessmentActivity = _prefix "AssessmentActivity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/AssessmentEvent"></see>
    /// </summary>
    let AssessmentEvent = _prefix "AssessmentEvent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/Opinion"></see>
    /// </summary>
    let Opinion = _prefix "Opinion"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/ExpectedValue"></see>
    /// </summary>
    let ExpectedValue = _prefix "ExpectedValue"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/Value"></see>
    /// </summary>
    let Value = _prefix "Value"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/ObservedValue"></see>
    /// </summary>
    let ObservedValue = _prefix "ObservedValue"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/FairValue"></see>
    /// </summary>
    let FairValue = _prefix "FairValue"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/QuantitativeValue"></see>
    /// </summary>
    let QuantitativeValue = _prefix "QuantitativeValue"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/PresentValue"></see>
    /// </summary>
    let PresentValue = _prefix "PresentValue"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/QualitativeValue"></see>
    /// </summary>
    let QualitativeValue = _prefix "QualitativeValue"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/ReferenceValue"></see>
    /// </summary>
    let ReferenceValue = _prefix "ReferenceValue"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/ValuationMethod"></see>
    /// </summary>
    let ValuationMethod = _prefix "ValuationMethod"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/ValueAssessment"></see>
    /// </summary>
    let ValueAssessment = _prefix "ValueAssessment"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/appliesMethodology"></see>
    /// </summary>
    let appliesMethodology = _prefix "appliesMethodology"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/hasAppraiser"></see>
    /// </summary>
    let hasAppraiser = _prefix "hasAppraiser"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/hasDateOfAssessment"></see>
    /// </summary>
    let hasDateOfAssessment = _prefix "hasDateOfAssessment"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/hasEstimatedValue"></see>
    /// </summary>
    let hasEstimatedValue = _prefix "hasEstimatedValue"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/isEstimatedValueOf"></see>
    /// </summary>
    let isEstimatedValueOf = _prefix "isEstimatedValueOf"

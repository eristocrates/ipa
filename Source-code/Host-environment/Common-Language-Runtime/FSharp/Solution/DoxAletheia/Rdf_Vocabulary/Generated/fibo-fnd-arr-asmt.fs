namespace https.spec.edmcouncil.org.fibo.ontology.FND.Arrangements.Assessments.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_arr_asmt =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/Appraisal"></see>
    /// </summary>
    let Appraisal = Namespaced_IRI.parse _namespace_name "Appraisal" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/AssessmentReport"></see>
    /// </summary>
    let AssessmentReport =
        Namespaced_IRI.parse _namespace_name "AssessmentReport" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/Appraiser"></see>
    /// </summary>
    let Appraiser = Namespaced_IRI.parse _namespace_name "Appraiser" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/estimatesValueAt"></see>
    /// </summary>
    let estimatesValueAt =
        Namespaced_IRI.parse _namespace_name "estimatesValueAt" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/AppraisedValue"></see>
    /// </summary>
    let AppraisedValue =
        Namespaced_IRI.parse _namespace_name "AppraisedValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/MarketValue"></see>
    /// </summary>
    let MarketValue =
        Namespaced_IRI.parse _namespace_name "MarketValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/AssessmentActivity"></see>
    /// </summary>
    let AssessmentActivity =
        Namespaced_IRI.parse _namespace_name "AssessmentActivity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/AssessmentEvent"></see>
    /// </summary>
    let AssessmentEvent =
        Namespaced_IRI.parse _namespace_name "AssessmentEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/Opinion"></see>
    /// </summary>
    let Opinion = Namespaced_IRI.parse _namespace_name "Opinion" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/ExpectedValue"></see>
    /// </summary>
    let ExpectedValue =
        Namespaced_IRI.parse _namespace_name "ExpectedValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/Value"></see>
    /// </summary>
    let Value = Namespaced_IRI.parse _namespace_name "Value" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/ObservedValue"></see>
    /// </summary>
    let ObservedValue =
        Namespaced_IRI.parse _namespace_name "ObservedValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/FairValue"></see>
    /// </summary>
    let FairValue = Namespaced_IRI.parse _namespace_name "FairValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/QuantitativeValue"></see>
    /// </summary>
    let QuantitativeValue =
        Namespaced_IRI.parse _namespace_name "QuantitativeValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/PresentValue"></see>
    /// </summary>
    let PresentValue =
        Namespaced_IRI.parse _namespace_name "PresentValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/QualitativeValue"></see>
    /// </summary>
    let QualitativeValue =
        Namespaced_IRI.parse _namespace_name "QualitativeValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/ReferenceValue"></see>
    /// </summary>
    let ReferenceValue =
        Namespaced_IRI.parse _namespace_name "ReferenceValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/ValuationMethod"></see>
    /// </summary>
    let ValuationMethod =
        Namespaced_IRI.parse _namespace_name "ValuationMethod" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/ValueAssessment"></see>
    /// </summary>
    let ValueAssessment =
        Namespaced_IRI.parse _namespace_name "ValueAssessment" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/appliesMethodology"></see>
    /// </summary>
    let appliesMethodology =
        Namespaced_IRI.parse _namespace_name "appliesMethodology" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/hasAppraiser"></see>
    /// </summary>
    let hasAppraiser =
        Namespaced_IRI.parse _namespace_name "hasAppraiser" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/hasDateOfAssessment"></see>
    /// </summary>
    let hasDateOfAssessment =
        Namespaced_IRI.parse _namespace_name "hasDateOfAssessment" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/hasEstimatedValue"></see>
    /// </summary>
    let hasEstimatedValue =
        Namespaced_IRI.parse _namespace_name "hasEstimatedValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/isEstimatedValueOf"></see>
    /// </summary>
    let isEstimatedValueOf =
        Namespaced_IRI.parse _namespace_name "isEstimatedValueOf" |> NamespacedName

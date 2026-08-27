namespace https.spec.edmcouncil.org.fibo.ontology.FND.Arrangements.Assessments.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_arr_asmt =
    let _namespace_iri = Namespace_Iri fibo_fnd_arr_asmt |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-arr-asmt:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Assessments Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_arr_asmt, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-arr-asmt:Appraisal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"appraisal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/Appraisal">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/Appraisal</seealso>
    let Appraisal = Prefixed_Name(fibo_fnd_arr_asmt, "Appraisal") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-asmt:AppraisedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"appraised value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/AppraisedValue">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/AppraisedValue</seealso>
    let AppraisedValue =
        Prefixed_Name(fibo_fnd_arr_asmt, "AppraisedValue") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-asmt:Appraiser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"appraiser"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/Appraiser">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/Appraiser</seealso>
    let Appraiser = Prefixed_Name(fibo_fnd_arr_asmt, "Appraiser") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-asmt:AssessmentActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"assessment activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/AssessmentActivity">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/AssessmentActivity</seealso>
    let AssessmentActivity =
        Prefixed_Name(fibo_fnd_arr_asmt, "AssessmentActivity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-asmt:AssessmentEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"assessment event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/AssessmentEvent">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/AssessmentEvent</seealso>
    let AssessmentEvent =
        Prefixed_Name(fibo_fnd_arr_asmt, "AssessmentEvent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-asmt:AssessmentReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"assessment report"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/AssessmentReport">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/AssessmentReport</seealso>
    let AssessmentReport =
        Prefixed_Name(fibo_fnd_arr_asmt, "AssessmentReport") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-asmt:ExpectedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"expected value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/ExpectedValue">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/ExpectedValue</seealso>
    let ExpectedValue =
        Prefixed_Name(fibo_fnd_arr_asmt, "ExpectedValue") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-asmt:FairValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fair value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/FairValue">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/FairValue</seealso>
    let FairValue = Prefixed_Name(fibo_fnd_arr_asmt, "FairValue") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-arr-asmt:MarketValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"market value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/MarketValue">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/MarketValue</seealso>
    let MarketValue = Prefixed_Name(fibo_fnd_arr_asmt, "MarketValue") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-asmt:ObservedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"observed value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/ObservedValue">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/ObservedValue</seealso>
    let ObservedValue =
        Prefixed_Name(fibo_fnd_arr_asmt, "ObservedValue") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-asmt:Opinion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"opinion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/Opinion">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/Opinion</seealso>
    let Opinion = Prefixed_Name(fibo_fnd_arr_asmt, "Opinion") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-arr-asmt:PresentValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"present value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/PresentValue">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/PresentValue</seealso>
    let PresentValue = Prefixed_Name(fibo_fnd_arr_asmt, "PresentValue") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-asmt:QualitativeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"qualitative value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/QualitativeValue">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/QualitativeValue</seealso>
    let QualitativeValue =
        Prefixed_Name(fibo_fnd_arr_asmt, "QualitativeValue") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-asmt:QuantitativeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"quantitative value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/QuantitativeValue">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/QuantitativeValue</seealso>
    let QuantitativeValue =
        Prefixed_Name(fibo_fnd_arr_asmt, "QuantitativeValue") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-asmt:ReferenceValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"reference value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/ReferenceValue">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/ReferenceValue</seealso>
    let ReferenceValue =
        Prefixed_Name(fibo_fnd_arr_asmt, "ReferenceValue") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-asmt:ValuationMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"valuation method"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/ValuationMethod">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/ValuationMethod</seealso>
    let ValuationMethod =
        Prefixed_Name(fibo_fnd_arr_asmt, "ValuationMethod") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-asmt:Value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/Value">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/Value</seealso>
    let Value = Prefixed_Name(fibo_fnd_arr_asmt, "Value") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-asmt:ValueAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"value assessment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/ValueAssessment">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/ValueAssessment</seealso>
    let ValueAssessment =
        Prefixed_Name(fibo_fnd_arr_asmt, "ValueAssessment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-asmt:appliesMethodology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"applies methodology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/appliesMethodology">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/appliesMethodology</seealso>
    let appliesMethodology =
        Prefixed_Name(fibo_fnd_arr_asmt, "appliesMethodology") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-asmt:estimatesValueAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"estimates value at"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/estimatesValueAt">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/estimatesValueAt</seealso>
    let estimatesValueAt =
        Prefixed_Name(fibo_fnd_arr_asmt, "estimatesValueAt") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-asmt:hasAppraiser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has appraiser"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/hasAppraiser">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/hasAppraiser</seealso>
    let hasAppraiser = Prefixed_Name(fibo_fnd_arr_asmt, "hasAppraiser") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-asmt:hasDateOfAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has date of assessment"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/hasDateOfAssessment">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/hasDateOfAssessment</seealso>
    let hasDateOfAssessment =
        Prefixed_Name(fibo_fnd_arr_asmt, "hasDateOfAssessment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-asmt:hasEstimatedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has estimated value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/hasEstimatedValue">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/hasEstimatedValue</seealso>
    let hasEstimatedValue =
        Prefixed_Name(fibo_fnd_arr_asmt, "hasEstimatedValue") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-asmt:isEstimatedValueOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is estimated value of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/isEstimatedValueOf">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/isEstimatedValueOf</seealso>
    let isEstimatedValueOf =
        Prefixed_Name(fibo_fnd_arr_asmt, "isEstimatedValueOf") |> PrefixedName

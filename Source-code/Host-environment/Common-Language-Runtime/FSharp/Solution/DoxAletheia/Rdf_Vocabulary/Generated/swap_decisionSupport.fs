namespace http.eulersharp.sourceforge.net._2003._03swap.decisionSupport.hash

open DoxAletheia.Rdf_Vocabulary

module swap_decisionSupport =
    let _namespace_name =
        "http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#"

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#Belief"></see>
    /// </summary>
    let Belief = Namespaced_IRI.parse _namespace_name "Belief" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#ClinicalObservablesResultFormula"></see>
    /// </summary>
    let ClinicalObservablesResultFormula =
        Namespaced_IRI.parse _namespace_name "ClinicalObservablesResultFormula" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#ObservablesResultFormula"></see>
    /// </summary>
    let ObservablesResultFormula =
        Namespaced_IRI.parse _namespace_name "ObservablesResultFormula" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#ClinicalRequest"></see>
    /// </summary>
    let ClinicalRequest =
        Namespaced_IRI.parse _namespace_name "ClinicalRequest" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#Request"></see>
    /// </summary>
    let Request = Namespaced_IRI.parse _namespace_name "Request" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#hasObservablesResultFormula"></see>
    /// </summary>
    let hasObservablesResultFormula =
        Namespaced_IRI.parse _namespace_name "hasObservablesResultFormula" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#PatientStateResultFormula"></see>
    /// </summary>
    let PatientStateResultFormula =
        Namespaced_IRI.parse _namespace_name "PatientStateResultFormula" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#StateResultFormula"></see>
    /// </summary>
    let StateResultFormula =
        Namespaced_IRI.parse _namespace_name "StateResultFormula" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#ResultFormula"></see>
    /// </summary>
    let ResultFormula =
        Namespaced_IRI.parse _namespace_name "ResultFormula" |> NamespacedName

    /// <summary>
    /// E.g. ([quant:hasValue 9.660533530762310e-001]) decisionsupport:beliefIn i:Lomefloxacin_400mg_PO_UID_3D.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#beliefIn"></see></summary>
    let beliefIn = Namespaced_IRI.parse _namespace_name "beliefIn" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#hasBelief"></see>
    /// </summary>
    let hasBelief = Namespaced_IRI.parse _namespace_name "hasBelief" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#hasPatientStateResultFormula"></see>
    /// </summary>
    let hasPatientStateResultFormula =
        Namespaced_IRI.parse _namespace_name "hasPatientStateResultFormula" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#hasResultFormula"></see>
    /// </summary>
    let hasResultFormula =
        Namespaced_IRI.parse _namespace_name "hasResultFormula" |> NamespacedName

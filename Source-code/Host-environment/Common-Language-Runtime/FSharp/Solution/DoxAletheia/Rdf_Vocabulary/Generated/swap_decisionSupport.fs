namespace http.eulersharp.sourceforge.net._2003._03swap.decisionSupport.hash

open DoxAletheia

module swap_decisionSupport =
    let _namespace_name =
        "http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#Belief"></see>
    /// </summary>
    let Belief = _prefix "Belief"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#ClinicalObservablesResultFormula"></see>
    /// </summary>
    let ClinicalObservablesResultFormula = _prefix "ClinicalObservablesResultFormula"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#ObservablesResultFormula"></see>
    /// </summary>
    let ObservablesResultFormula = _prefix "ObservablesResultFormula"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#ClinicalRequest"></see>
    /// </summary>
    let ClinicalRequest = _prefix "ClinicalRequest"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#Request"></see>
    /// </summary>
    let Request = _prefix "Request"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#hasObservablesResultFormula"></see>
    /// </summary>
    let hasObservablesResultFormula = _prefix "hasObservablesResultFormula"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#PatientStateResultFormula"></see>
    /// </summary>
    let PatientStateResultFormula = _prefix "PatientStateResultFormula"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#StateResultFormula"></see>
    /// </summary>
    let StateResultFormula = _prefix "StateResultFormula"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#ResultFormula"></see>
    /// </summary>
    let ResultFormula = _prefix "ResultFormula"
    /// <summary>
    /// E.g. ([quant:hasValue 9.660533530762310e-001]) decisionsupport:beliefIn i:Lomefloxacin_400mg_PO_UID_3D.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#beliefIn"></see></summary>
    let beliefIn = _prefix "beliefIn"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#hasBelief"></see>
    /// </summary>
    let hasBelief = _prefix "hasBelief"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#hasPatientStateResultFormula"></see>
    /// </summary>
    let hasPatientStateResultFormula = _prefix "hasPatientStateResultFormula"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#hasResultFormula"></see>
    /// </summary>
    let hasResultFormula = _prefix "hasResultFormula"

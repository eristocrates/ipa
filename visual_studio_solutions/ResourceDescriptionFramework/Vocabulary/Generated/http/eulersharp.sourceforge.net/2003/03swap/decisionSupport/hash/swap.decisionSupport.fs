namespace Swap.decisionSupport.Namespace
module decisionSupport =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#" (Some "http://eulersharp.sourceforge.net/2003/03swap/decisionSupport") (Some "swap.decisionSupport") None
    let Belief = {_prefixID with _localName = "Belief"}
    let ClinicalObservablesResultFormula = {_prefixID with _localName = "ClinicalObservablesResultFormula"}
    let ClinicalRequest = {_prefixID with _localName = "ClinicalRequest"}
    let ObservablesResultFormula = {_prefixID with _localName = "ObservablesResultFormula"}
    let PatientStateResultFormula = {_prefixID with _localName = "PatientStateResultFormula"}
    let Request = {_prefixID with _localName = "Request"}
    let ResultFormula = {_prefixID with _localName = "ResultFormula"}
    let StateResultFormula = {_prefixID with _localName = "StateResultFormula"}
    let beliefIn = {_prefixID with _localName = "beliefIn"}
    let hasBelief = {_prefixID with _localName = "hasBelief"}
    let hasObservablesResultFormula = {_prefixID with _localName = "hasObservablesResultFormula"}
    let hasPatientStateResultFormula = {_prefixID with _localName = "hasPatientStateResultFormula"}
    let hasResultFormula = {_prefixID with _localName = "hasResultFormula"}
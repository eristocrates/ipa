namespace http.linkedscience.org.lsc.ns.hash

open DoxAletheia

module lsc =
    let _namespace_name = "http://linkedscience.org/lsc/ns#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Conclusion is made by research.
    /// <see href="http://linkedscience.org/lsc/ns#Conclusion"></see></summary>
    let Conclusion = _prefix "Conclusion"
    /// <summary>
    /// Any kind of data.
    /// <see href="http://linkedscience.org/lsc/ns#Data"></see></summary>
    let Data = _prefix "Data"
    /// <summary>
    /// Any kind of hypothesis.
    /// <see href="http://linkedscience.org/lsc/ns#Hypothesis"></see></summary>
    let Hypothesis = _prefix "Hypothesis"
    /// <summary>
    /// Prediction made by a hypothesis.
    /// <see href="http://linkedscience.org/lsc/ns#Prediction"></see></summary>
    let Prediction = _prefix "Prediction"
    /// <summary>
    /// Any kind of publication eg. scientific paper, book, journal publication.
    /// <see href="http://linkedscience.org/lsc/ns#Publication"></see></summary>
    let Publication = _prefix "Publication"
    /// <summary>
    /// Any kind of research.
    /// <see href="http://linkedscience.org/lsc/ns#Research"></see></summary>
    let Research = _prefix "Research"
    /// <summary>
    /// A researcher that conducts research.
    /// <see href="http://linkedscience.org/lsc/ns#Researcher"></see></summary>
    let Researcher = _prefix "Researcher"
    /// <summary>
    /// A research confirms a hypothesis.
    /// <see href="http://linkedscience.org/lsc/ns#confirms"></see></summary>
    let confirms = _prefix "confirms"
    /// <summary>
    /// Describes the relation between a research and the data produced in it.
    /// <see href="http://linkedscience.org/lsc/ns#dataProduced"></see></summary>
    let dataProduced = _prefix "dataProduced"
    /// <summary>
    /// Describes the relation between a research and the data used to conduct it.
    /// <see href="http://linkedscience.org/lsc/ns#dataUsed"></see></summary>
    let dataUsed = _prefix "dataUsed"
    /// <summary>
    /// A research falsifies a hypothesis.
    /// <see href="http://linkedscience.org/lsc/ns#falsifies"></see></summary>
    let falsifies = _prefix "falsifies"
    /// <summary>
    /// Abstract property to define the region a research refers to.
    /// <see href="http://linkedscience.org/lsc/ns#isAboutRegion"></see></summary>
    let isAboutRegion = _prefix "isAboutRegion"
    /// <summary>
    /// Abstract property to relate a research to the time period it refers.
    /// <see href="http://linkedscience.org/lsc/ns#isAboutTime"></see></summary>
    let isAboutTime = _prefix "isAboutTime"
    /// <summary>
    /// Abstract property to express the relation between the hypothesis and the evidence of a research.
    /// <see href="http://linkedscience.org/lsc/ns#isSupprtedBy"></see></summary>
    let isSupprtedBy = _prefix "isSupprtedBy"
    /// <summary>
    ///   <see href="http://linkedscience.org/lsc/ns#isSupportedBy"></see>
    /// </summary>
    let isSupportedBy = _prefix "isSupportedBy"
    /// <summary>
    /// A hypothesis makes a prediction.
    /// <see href="http://linkedscience.org/lsc/ns#makes"></see></summary>
    let makes = _prefix "makes"
    /// <summary>
    /// A method used in a research.
    /// <see href="http://linkedscience.org/lsc/ns#methodUsed"></see></summary>
    let methodUsed = _prefix "methodUsed"
    /// <summary>
    ///   <see href="http://linkedscience.org/lsc/ns#Method"></see>
    /// </summary>
    let Method = _prefix "Method"
    /// <summary>
    /// A researcher participates in some research.
    /// <see href="http://linkedscience.org/lsc/ns#participatesIn"></see></summary>
    let participatesIn = _prefix "participatesIn"
    /// <summary>
    /// A research produces a conclusion.
    /// <see href="http://linkedscience.org/lsc/ns#produces"></see></summary>
    let produces = _prefix "produces"
    /// <summary>
    /// Abstract property to relate a research to the publications it is reported in.
    /// <see href="http://linkedscience.org/lsc/ns#reportedIn"></see></summary>
    let reportedIn = _prefix "reportedIn"
    /// <summary>
    /// Abstract property to report the research of a publication.
    /// <see href="http://linkedscience.org/lsc/ns#reports"></see></summary>
    let reports = _prefix "reports"
    /// <summary>
    /// A research tests a hypothesis.
    /// <see href="http://linkedscience.org/lsc/ns#tests"></see></summary>
    let tests = _prefix "tests"
    /// <summary>
    /// Abstract property to relate a publication to the time it was accepted.
    /// <see href="http://linkedscience.org/lsc/ns#timeAccepted"></see></summary>
    let timeAccepted = _prefix "timeAccepted"
    /// <summary>
    /// Abstract property to relate a publication to the time it was revised.
    /// <see href="http://linkedscience.org/lsc/ns#timeRevised"></see></summary>
    let timeRevised = _prefix "timeRevised"
    /// <summary>
    /// Abstract property to relate a publication to the time it was submitted.
    /// <see href="http://linkedscience.org/lsc/ns#timeSubmitted"></see></summary>
    let timeSubmitted = _prefix "timeSubmitted"

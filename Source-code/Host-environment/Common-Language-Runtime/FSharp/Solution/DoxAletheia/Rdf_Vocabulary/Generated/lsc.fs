namespace http.linkedscience.org.lsc.ns.hash

open DoxAletheia.Rdf_Vocabulary

module lsc =
    let _namespace_name = "http://linkedscience.org/lsc/ns#"
    /// <summary>
    /// Conclusion is made by research.
    /// <see href="http://linkedscience.org/lsc/ns#Conclusion"></see></summary>
    let Conclusion = Namespaced_IRI.parse _namespace_name "Conclusion" |> NamespacedName
    /// <summary>
    /// Any kind of data.
    /// <see href="http://linkedscience.org/lsc/ns#Data"></see></summary>
    let Data = Namespaced_IRI.parse _namespace_name "Data" |> NamespacedName
    /// <summary>
    /// Any kind of hypothesis.
    /// <see href="http://linkedscience.org/lsc/ns#Hypothesis"></see></summary>
    let Hypothesis = Namespaced_IRI.parse _namespace_name "Hypothesis" |> NamespacedName
    /// <summary>
    /// Prediction made by a hypothesis.
    /// <see href="http://linkedscience.org/lsc/ns#Prediction"></see></summary>
    let Prediction = Namespaced_IRI.parse _namespace_name "Prediction" |> NamespacedName

    /// <summary>
    /// Any kind of publication eg. scientific paper, book, journal publication.
    /// <see href="http://linkedscience.org/lsc/ns#Publication"></see></summary>
    let Publication =
        Namespaced_IRI.parse _namespace_name "Publication" |> NamespacedName

    /// <summary>
    /// Any kind of research.
    /// <see href="http://linkedscience.org/lsc/ns#Research"></see></summary>
    let Research = Namespaced_IRI.parse _namespace_name "Research" |> NamespacedName
    /// <summary>
    /// A researcher that conducts research.
    /// <see href="http://linkedscience.org/lsc/ns#Researcher"></see></summary>
    let Researcher = Namespaced_IRI.parse _namespace_name "Researcher" |> NamespacedName
    /// <summary>
    /// A research confirms a hypothesis.
    /// <see href="http://linkedscience.org/lsc/ns#confirms"></see></summary>
    let confirms = Namespaced_IRI.parse _namespace_name "confirms" |> NamespacedName

    /// <summary>
    /// Describes the relation between a research and the data produced in it.
    /// <see href="http://linkedscience.org/lsc/ns#dataProduced"></see></summary>
    let dataProduced =
        Namespaced_IRI.parse _namespace_name "dataProduced" |> NamespacedName

    /// <summary>
    /// Describes the relation between a research and the data used to conduct it.
    /// <see href="http://linkedscience.org/lsc/ns#dataUsed"></see></summary>
    let dataUsed = Namespaced_IRI.parse _namespace_name "dataUsed" |> NamespacedName
    /// <summary>
    /// A research falsifies a hypothesis.
    /// <see href="http://linkedscience.org/lsc/ns#falsifies"></see></summary>
    let falsifies = Namespaced_IRI.parse _namespace_name "falsifies" |> NamespacedName

    /// <summary>
    /// Abstract property to define the region a research refers to.
    /// <see href="http://linkedscience.org/lsc/ns#isAboutRegion"></see></summary>
    let isAboutRegion =
        Namespaced_IRI.parse _namespace_name "isAboutRegion" |> NamespacedName

    /// <summary>
    /// Abstract property to relate a research to the time period it refers.
    /// <see href="http://linkedscience.org/lsc/ns#isAboutTime"></see></summary>
    let isAboutTime =
        Namespaced_IRI.parse _namespace_name "isAboutTime" |> NamespacedName

    /// <summary>
    /// Abstract property to express the relation between the hypothesis and the evidence of a research.
    /// <see href="http://linkedscience.org/lsc/ns#isSupprtedBy"></see></summary>
    let isSupprtedBy =
        Namespaced_IRI.parse _namespace_name "isSupprtedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedscience.org/lsc/ns#isSupportedBy"></see>
    /// </summary>
    let isSupportedBy =
        Namespaced_IRI.parse _namespace_name "isSupportedBy" |> NamespacedName

    /// <summary>
    /// A hypothesis makes a prediction.
    /// <see href="http://linkedscience.org/lsc/ns#makes"></see></summary>
    let makes = Namespaced_IRI.parse _namespace_name "makes" |> NamespacedName
    /// <summary>
    /// A method used in a research.
    /// <see href="http://linkedscience.org/lsc/ns#methodUsed"></see></summary>
    let methodUsed = Namespaced_IRI.parse _namespace_name "methodUsed" |> NamespacedName
    /// <summary>
    ///   <see href="http://linkedscience.org/lsc/ns#Method"></see>
    /// </summary>
    let Method = Namespaced_IRI.parse _namespace_name "Method" |> NamespacedName

    /// <summary>
    /// A researcher participates in some research.
    /// <see href="http://linkedscience.org/lsc/ns#participatesIn"></see></summary>
    let participatesIn =
        Namespaced_IRI.parse _namespace_name "participatesIn" |> NamespacedName

    /// <summary>
    /// A research produces a conclusion.
    /// <see href="http://linkedscience.org/lsc/ns#produces"></see></summary>
    let produces = Namespaced_IRI.parse _namespace_name "produces" |> NamespacedName
    /// <summary>
    /// Abstract property to relate a research to the publications it is reported in.
    /// <see href="http://linkedscience.org/lsc/ns#reportedIn"></see></summary>
    let reportedIn = Namespaced_IRI.parse _namespace_name "reportedIn" |> NamespacedName
    /// <summary>
    /// Abstract property to report the research of a publication.
    /// <see href="http://linkedscience.org/lsc/ns#reports"></see></summary>
    let reports = Namespaced_IRI.parse _namespace_name "reports" |> NamespacedName
    /// <summary>
    /// A research tests a hypothesis.
    /// <see href="http://linkedscience.org/lsc/ns#tests"></see></summary>
    let tests = Namespaced_IRI.parse _namespace_name "tests" |> NamespacedName

    /// <summary>
    /// Abstract property to relate a publication to the time it was accepted.
    /// <see href="http://linkedscience.org/lsc/ns#timeAccepted"></see></summary>
    let timeAccepted =
        Namespaced_IRI.parse _namespace_name "timeAccepted" |> NamespacedName

    /// <summary>
    /// Abstract property to relate a publication to the time it was revised.
    /// <see href="http://linkedscience.org/lsc/ns#timeRevised"></see></summary>
    let timeRevised =
        Namespaced_IRI.parse _namespace_name "timeRevised" |> NamespacedName

    /// <summary>
    /// Abstract property to relate a publication to the time it was submitted.
    /// <see href="http://linkedscience.org/lsc/ns#timeSubmitted"></see></summary>
    let timeSubmitted =
        Namespaced_IRI.parse _namespace_name "timeSubmitted" |> NamespacedName

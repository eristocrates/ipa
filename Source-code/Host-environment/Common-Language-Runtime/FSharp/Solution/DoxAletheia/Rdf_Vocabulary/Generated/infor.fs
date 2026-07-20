namespace http.www.ontologydesignpatterns.org.cp.owl.informationrealization.owl.hash

open DoxAletheia

module infor =
    let _namespace_name =
        "http://www.ontologydesignpatterns.org/cp/owl/informationrealization.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A piece of information, such as a musical composition, a text, a word, a picture, independently from how it is concretely realized.
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/informationrealization.owl#InformationObject"></see></summary>
    let InformationObject = _prefix "InformationObject"
    /// <summary>
    /// A concrete realization of an information object, e.g. the written document containing the text of a law.
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/informationrealization.owl#InformationRealization"></see></summary>
    let InformationRealization = _prefix "InformationRealization"
    /// <summary>
    /// A relation between an information realization and an information object, e.g. the paper copy of the Italian Constitution realizes the text of the Constitution.
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/informationrealization.owl#isRealizedBy"></see></summary>
    let isRealizedBy = _prefix "isRealizedBy"
    /// <summary>
    /// A relation between an information realization and an information object, e.g. the paper copy of the Italian Constitution realizes the text of the Constitution.
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/informationrealization.owl#realizes"></see></summary>
    let realizes = _prefix "realizes"

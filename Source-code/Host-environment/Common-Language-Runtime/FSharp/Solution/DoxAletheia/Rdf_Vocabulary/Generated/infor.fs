namespace http.www.ontologydesignpatterns.org.cp.owl.informationrealization.owl.hash

open DoxAletheia.Rdf_Vocabulary

module infor =
    let _namespace_name =
        "http://www.ontologydesignpatterns.org/cp/owl/informationrealization.owl#"

    /// <summary>
    /// A piece of information, such as a musical composition, a text, a word, a picture, independently from how it is concretely realized.
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/informationrealization.owl#InformationObject"></see></summary>
    let InformationObject =
        Namespaced_IRI.parse _namespace_name "InformationObject" |> NamespacedName

    /// <summary>
    /// A concrete realization of an information object, e.g. the written document containing the text of a law.
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/informationrealization.owl#InformationRealization"></see></summary>
    let InformationRealization =
        Namespaced_IRI.parse _namespace_name "InformationRealization" |> NamespacedName

    /// <summary>
    /// A relation between an information realization and an information object, e.g. the paper copy of the Italian Constitution realizes the text of the Constitution.
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/informationrealization.owl#isRealizedBy"></see></summary>
    let isRealizedBy =
        Namespaced_IRI.parse _namespace_name "isRealizedBy" |> NamespacedName

    /// <summary>
    /// A relation between an information realization and an information object, e.g. the paper copy of the Italian Constitution realizes the text of the Constitution.
    /// <see href="http://www.ontologydesignpatterns.org/cp/owl/informationrealization.owl#realizes"></see></summary>
    let realizes = Namespaced_IRI.parse _namespace_name "realizes" |> NamespacedName

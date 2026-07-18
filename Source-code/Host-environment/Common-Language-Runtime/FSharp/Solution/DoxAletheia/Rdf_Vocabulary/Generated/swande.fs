namespace http.purl.org.swan._2._0.discourse_elements.slash

open DoxAletheia.Rdf_Vocabulary

module swande =
    let _namespace_name = "http://purl.org/swan/2.0/discourse-elements/"
    /// <summary>
    /// A claim is a research statement that is
    ///     	accepted by the author/curator as reasonable. Unlike a hypothesis, its author/curator
    ///     	does not consider it provisional, but proven.
    /// <see href="http://purl.org/swan/2.0/discourse-elements/Claim"></see></summary>
    let Claim = Namespaced_IRI.parse _namespace_name "Claim" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/discourse-elements/ResearchStatement"></see>
    /// </summary>
    let ResearchStatement =
        Namespaced_IRI.parse _namespace_name "ResearchStatement" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/discourse-elements/DiscourseElement"></see>
    /// </summary>
    let DiscourseElement =
        Namespaced_IRI.parse _namespace_name "DiscourseElement" |> NamespacedName

    /// <summary>
    /// A hypothesis is a statement proposing one or
    ///     	more ideas, which has a provisional nature
    /// <see href="http://purl.org/swan/2.0/discourse-elements/Hypothesis"></see></summary>
    let Hypothesis = Namespaced_IRI.parse _namespace_name "Hypothesis" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/discourse-elements/Question"></see>
    /// </summary>
    let Question = Namespaced_IRI.parse _namespace_name "Question" |> NamespacedName

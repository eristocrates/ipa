namespace http.purl.org.swan._2._0.discourse_elements.slash

open DoxAletheia

module swande =
    let _namespace_name = "http://purl.org/swan/2.0/discourse-elements/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A claim is a research statement that is
    ///     	accepted by the author/curator as reasonable. Unlike a hypothesis, its author/curator
    ///     	does not consider it provisional, but proven.
    /// <see href="http://purl.org/swan/2.0/discourse-elements/Claim"></see></summary>
    let Claim = _prefix "Claim"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/discourse-elements/ResearchStatement"></see>
    /// </summary>
    let ResearchStatement = _prefix "ResearchStatement"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/discourse-elements/DiscourseElement"></see>
    /// </summary>
    let DiscourseElement = _prefix "DiscourseElement"
    /// <summary>
    /// A hypothesis is a statement proposing one or
    ///     	more ideas, which has a provisional nature
    /// <see href="http://purl.org/swan/2.0/discourse-elements/Hypothesis"></see></summary>
    let Hypothesis = _prefix "Hypothesis"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/discourse-elements/Question"></see>
    /// </summary>
    let Question = _prefix "Question"

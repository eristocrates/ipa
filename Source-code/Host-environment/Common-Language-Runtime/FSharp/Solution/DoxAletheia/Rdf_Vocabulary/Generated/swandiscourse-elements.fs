namespace http.purl.org.swan._2._0.discourse_elements.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swandiscourse_elements =
    let _namespace_iri = Namespace_Iri swandiscourse_elements |> NamespaceIRI
    /// <summary>
    ///   <para>swan:discourse-elements/</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Discourse elements vocabulary v. 3"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-elements/">http://purl.org/swan/2.0/discourse-elements/</seealso>
    let _prefix_iri = Prefixed_Name(swandiscourse_elements, "") |> PrefixedName
    /// <summary>
    ///   <para>swan:discourse-elements/Claim</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A claim is a research statement that is
    ///     	accepted by the author/curator as reasonable. Unlike a hypothesis, its author/curator
    ///     	does not consider it provisional, but proven."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"swande: Claim"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-elements/Claim">http://purl.org/swan/2.0/discourse-elements/Claim</seealso>
    let Claim = Prefixed_Name(swandiscourse_elements, "Claim") |> PrefixedName

    /// <summary>
    ///   <para>swan:discourse-elements/DiscourseElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"swande: Discourse Element"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-elements/DiscourseElement">http://purl.org/swan/2.0/discourse-elements/DiscourseElement</seealso>
    let DiscourseElement =
        Prefixed_Name(swandiscourse_elements, "DiscourseElement") |> PrefixedName

    /// <summary>
    ///   <para>swan:discourse-elements/Hypothesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A hypothesis is a statement proposing one or
    ///     	more ideas, which has a provisional nature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"swande: Hypothesis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-elements/Hypothesis">http://purl.org/swan/2.0/discourse-elements/Hypothesis</seealso>
    let Hypothesis = Prefixed_Name(swandiscourse_elements, "Hypothesis") |> PrefixedName
    /// <summary>
    ///   <para>swan:discourse-elements/Question</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"swande: Research Question"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-elements/Question">http://purl.org/swan/2.0/discourse-elements/Question</seealso>
    let Question = Prefixed_Name(swandiscourse_elements, "Question") |> PrefixedName

    /// <summary>
    ///   <para>swan:discourse-elements/ResearchStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"swande: Research Statement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-elements/ResearchStatement">http://purl.org/swan/2.0/discourse-elements/ResearchStatement</seealso>
    let ResearchStatement =
        Prefixed_Name(swandiscourse_elements, "ResearchStatement") |> PrefixedName

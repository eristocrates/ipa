namespace http.promsns.org.def._do.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dprov =
    let _namespace_iri = Namespace_Iri dprov |> NamespaceIRI
    /// <summary>
    ///   <para>dprov:OptionSelection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Option Selection is a process (prov:Activity) through which a decision-making Agent selects something.
    ///
    /// At least two Option Selection Activities, possibly more, must be run in parrallel by an Agent and at least one must yield an outcome in order for a Question to be answered.</para>
    /// labels<para>OptionSelection</para><para>Wybór opcji</para></remarks>
    /// <seealso href="http://promsns.org/def/do#OptionSelection">http://promsns.org/def/do#OptionSelection</seealso>
    let OptionSelection = Prefixed_Name(dprov, "OptionSelection") |> PrefixedName
    /// <summary>
    ///   <para>dprov:DecisionMaker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>nsprov:Role</para>
    /// </remarks>
    /// <seealso href="http://promsns.org/def/do#DecisionMaker">http://promsns.org/def/do#DecisionMaker</seealso>
    let DecisionMaker = Prefixed_Name(dprov, "DecisionMaker") |> PrefixedName
    /// <summary>
    ///   <para>dprov:Answer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A recorded answer to a Question</para>
    /// labels<para>Answer</para></remarks>
    /// <seealso href="http://promsns.org/def/do#Answer">http://promsns.org/def/do#Answer</seealso>
    let Answer = Prefixed_Name(dprov, "Answer") |> PrefixedName
    /// <summary>
    ///   <para>dprov:Question</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A recorded question</para>
    /// labels<para>Question</para></remarks>
    /// <seealso href="http://promsns.org/def/do#Question">http://promsns.org/def/do#Question</seealso>
    let Question = Prefixed_Name(dprov, "Question") |> PrefixedName
    /// <summary>
    ///   <para>dprov:DecisionMaking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A temporal event in which decision processes are undertaken, such as initiating sub-questions for the question to be answered, consideration of options etc.</para>
    /// labels<para>Decision Making</para></remarks>
    /// <seealso href="http://promsns.org/def/do#DecisionMaking">http://promsns.org/def/do#DecisionMaking</seealso>
    let DecisionMaking = Prefixed_Name(dprov, "DecisionMaking") |> PrefixedName
    /// <summary>
    ///   <para>dprov:Decision_making</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://promsns.org/def/do#Decision_making">http://promsns.org/def/do#Decision_making</seealso>
    let Decision_making = Prefixed_Name(dprov, "Decision_making") |> PrefixedName
    /// <summary>
    ///   <para>dprov:Requirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Requirements require something from an OptionSelection Activity. They indicate their requirement with a set (a class) of objects. They are then satisified by the presense of an onject within that class. Multiple Requirements can be intersected to require very specific OptionSelection outcomes.</para>
    /// labels<para>Requirement</para></remarks>
    /// <seealso href="http://promsns.org/def/do#Requirement">http://promsns.org/def/do#Requirement</seealso>
    let Requirement = Prefixed_Name(dprov, "Requirement") |> PrefixedName

namespace https.privatealpha.com.ontology.ibis._1.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module paibis =
    let _namespace_iri = Namespace_Iri paibis |> NamespaceIRI
    /// <summary>
    ///   <para>paibis:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"This document specifies a vocabulary for describing an IBIS (issue-based information system)."</para>
    /// labels<para>"IBIS"</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/ibis/1#">https://privatealpha.com/ontology/ibis/1#</seealso>
    let _prefix_iri = Prefixed_Name(paibis, "") |> PrefixedName
    /// <summary>
    ///   <para>paibis:Argument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Argument is a type of Issue that explicitly supports or refutes a Position."</para>
    /// labels<para>"Argument"</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/ibis/1#Argument">https://privatealpha.com/ontology/ibis/1#Argument</seealso>
    let Argument = Prefixed_Name(paibis, "Argument") |> PrefixedName
    /// <summary>
    ///   <para>paibis:Invariant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Issue or Position can be marked Invariant to denote that it has been deemed outside of the influence of the Agents in the system, i.e., something to be steered around."</para>
    /// labels<para>"Invariant"</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/ibis/1#Invariant">https://privatealpha.com/ontology/ibis/1#Invariant</seealso>
    let Invariant = Prefixed_Name(paibis, "Invariant") |> PrefixedName
    /// <summary>
    ///   <para>paibis:Issue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Issue is a state of affairs, claimed by one or more Agents to either be a misfit itself, or affecting some other Issue or Position."</para>
    /// labels<para>"Issue"</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/ibis/1#Issue">https://privatealpha.com/ontology/ibis/1#Issue</seealso>
    let Issue = Prefixed_Name(paibis, "Issue") |> PrefixedName
    /// <summary>
    ///   <para>paibis:Network</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A network of issues, positions, and arguments."</para>
    /// labels<para>"Network"</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/ibis/1#Network">https://privatealpha.com/ontology/ibis/1#Network</seealso>
    let Network = Prefixed_Name(paibis, "Network") |> PrefixedName
    /// <summary>
    ///   <para>paibis:Position</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Position asserts a moral, ethical, pragmatic, or similar kind of assertion, typically identifying what, if anything, should be done about an Issue."</para>
    /// labels<para>"Position"</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/ibis/1#Position">https://privatealpha.com/ontology/ibis/1#Position</seealso>
    let Position = Prefixed_Name(paibis, "Position") |> PrefixedName
    /// <summary>
    ///   <para>paibis:concerns</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The subject is an issue concerning the object, which can be any resource."</para>
    /// labels<para>"concerns"</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/ibis/1#concerns">https://privatealpha.com/ontology/ibis/1#concerns</seealso>
    let concerns = Prefixed_Name(paibis, "concerns") |> PrefixedName
    /// <summary>
    ///   <para>paibis:endorsed-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A concept can be endorsed by an Agent without said Agent having mentioned or advanced it initially, and without any additional comment."</para>
    /// labels<para>"endorsed by"</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/ibis/1#endorsed-by">https://privatealpha.com/ontology/ibis/1#endorsed-by</seealso>
    let endorsed_by = Prefixed_Name(paibis, "endorsed-by") |> PrefixedName
    /// <summary>
    ///   <para>paibis:endorses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An Agent can endorse a concept without having initially mentioned or advanced it, and without any additional comment."</para>
    /// labels<para>"endorses"</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/ibis/1#endorses">https://privatealpha.com/ontology/ibis/1#endorses</seealso>
    let endorses = Prefixed_Name(paibis, "endorses") |> PrefixedName
    /// <summary>
    ///   <para>paibis:generalizes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The subject is a more generic form of the object."</para>
    /// labels<para>"generalizes"</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/ibis/1#generalizes">https://privatealpha.com/ontology/ibis/1#generalizes</seealso>
    let generalizes = Prefixed_Name(paibis, "generalizes") |> PrefixedName
    /// <summary>
    ///   <para>paibis:opposed-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates a subject position opposed by an object argument."</para>
    /// labels<para>"opposed by"</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/ibis/1#opposed-by">https://privatealpha.com/ontology/ibis/1#opposed-by</seealso>
    let opposed_by = Prefixed_Name(paibis, "opposed-by") |> PrefixedName
    /// <summary>
    ///   <para>paibis:opposes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates a subject argument that opposes an object position."</para>
    /// labels<para>"opposes"</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/ibis/1#opposes">https://privatealpha.com/ontology/ibis/1#opposes</seealso>
    let opposes = Prefixed_Name(paibis, "opposes") |> PrefixedName
    /// <summary>
    ///   <para>paibis:questioned-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates a belief called into question by an issue."</para>
    /// labels<para>"questioned by"</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/ibis/1#questioned-by">https://privatealpha.com/ontology/ibis/1#questioned-by</seealso>
    let questioned_by = Prefixed_Name(paibis, "questioned-by") |> PrefixedName
    /// <summary>
    ///   <para>paibis:questions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates an issue that raises doubt on a belief."</para>
    /// labels<para>"questions"</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/ibis/1#questions">https://privatealpha.com/ontology/ibis/1#questions</seealso>
    let questions = Prefixed_Name(paibis, "questions") |> PrefixedName
    /// <summary>
    ///   <para>paibis:replaced-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates when a concept is replaced by another concept of the same type."</para>
    /// labels<para>"replaced by"</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/ibis/1#replaced-by">https://privatealpha.com/ontology/ibis/1#replaced-by</seealso>
    let replaced_by = Prefixed_Name(paibis, "replaced-by") |> PrefixedName
    /// <summary>
    ///   <para>paibis:replaces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates when a concept replaces another concept of the same type."</para>
    /// labels<para>"replaces"</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/ibis/1#replaces">https://privatealpha.com/ontology/ibis/1#replaces</seealso>
    let replaces = Prefixed_Name(paibis, "replaces") |> PrefixedName
    /// <summary>
    ///   <para>paibis:responds-to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates an issue to which the subject position responds."</para>
    /// labels<para>"responds to"</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/ibis/1#responds-to">https://privatealpha.com/ontology/ibis/1#responds-to</seealso>
    let responds_to = Prefixed_Name(paibis, "responds-to") |> PrefixedName
    /// <summary>
    ///   <para>paibis:response</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates a position that responds to the subject issue."</para>
    /// labels<para>"response"</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/ibis/1#response">https://privatealpha.com/ontology/ibis/1#response</seealso>
    let response = Prefixed_Name(paibis, "response") |> PrefixedName
    /// <summary>
    ///   <para>paibis:specializes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The subject is a more specific form of the object."</para>
    /// labels<para>"specializes"</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/ibis/1#specializes">https://privatealpha.com/ontology/ibis/1#specializes</seealso>
    let specializes = Prefixed_Name(paibis, "specializes") |> PrefixedName
    /// <summary>
    ///   <para>paibis:suggested-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates when the subject issue is suggested by the object belief."</para>
    /// labels<para>"suggested by"</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/ibis/1#suggested-by">https://privatealpha.com/ontology/ibis/1#suggested-by</seealso>
    let suggested_by = Prefixed_Name(paibis, "suggested-by") |> PrefixedName
    /// <summary>
    ///   <para>paibis:suggests</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates when the subject belief suggests the object issue."</para>
    /// labels<para>"suggests"</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/ibis/1#suggests">https://privatealpha.com/ontology/ibis/1#suggests</seealso>
    let suggests = Prefixed_Name(paibis, "suggests") |> PrefixedName
    /// <summary>
    ///   <para>paibis:supported-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates a subject position supported by an object argument."</para>
    /// labels<para>"supported by"</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/ibis/1#supported-by">https://privatealpha.com/ontology/ibis/1#supported-by</seealso>
    let supported_by = Prefixed_Name(paibis, "supported-by") |> PrefixedName
    /// <summary>
    ///   <para>paibis:supports</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates a subject argument that supports an object position."</para>
    /// labels<para>"supports"</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/ibis/1#supports">https://privatealpha.com/ontology/ibis/1#supports</seealso>
    let supports = Prefixed_Name(paibis, "supports") |> PrefixedName

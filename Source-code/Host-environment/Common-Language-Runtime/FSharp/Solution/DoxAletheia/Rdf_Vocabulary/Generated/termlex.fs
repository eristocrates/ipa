namespace https.termlex.oeg.fi.upm.es.termlex.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module termlex =
    let _namespace_iri = Namespace_Iri termlex |> NamespaceIRI
    /// <summary>
    ///   <para>termlex:1</para>
    /// </summary>
    /// <remarks>
    ///   <para>termlex:ReliabilityCode</para>
    /// </remarks>
    /// <seealso href="https://termlex.oeg.fi.upm.es/termlex#1">https://termlex.oeg.fi.upm.es/termlex#1</seealso>
    let _1 = Prefixed_Name(termlex, "1") |> PrefixedName
    /// <summary>
    ///   <para>termlex:2</para>
    /// </summary>
    /// <remarks>
    ///   <para>termlex:ReliabilityCode</para>
    /// </remarks>
    /// <seealso href="https://termlex.oeg.fi.upm.es/termlex#2">https://termlex.oeg.fi.upm.es/termlex#2</seealso>
    let _2 = Prefixed_Name(termlex, "2") |> PrefixedName
    /// <summary>
    ///   <para>termlex:3</para>
    /// </summary>
    /// <remarks>
    ///   <para>termlex:ReliabilityCode</para>
    /// </remarks>
    /// <seealso href="https://termlex.oeg.fi.upm.es/termlex#3">https://termlex.oeg.fi.upm.es/termlex#3</seealso>
    let _3 = Prefixed_Name(termlex, "3") |> PrefixedName
    /// <summary>
    ///   <para>termlex:4</para>
    /// </summary>
    /// <remarks>
    ///   <para>termlex:ReliabilityCode</para>
    /// </remarks>
    /// <seealso href="https://termlex.oeg.fi.upm.es/termlex#4">https://termlex.oeg.fi.upm.es/termlex#4</seealso>
    let _4 = Prefixed_Name(termlex, "4") |> PrefixedName
    /// <summary>
    ///   <para>termlex:5</para>
    /// </summary>
    /// <remarks>
    ///   <para>termlex:ReliabilityCode</para>
    /// </remarks>
    /// <seealso href="https://termlex.oeg.fi.upm.es/termlex#5">https://termlex.oeg.fi.upm.es/termlex#5</seealso>
    let _5 = Prefixed_Name(termlex, "5") |> PrefixedName
    /// <summary>
    ///   <para>termlex:Definition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Definition class represents the description of a resource, may it be a concept, a term or any other entity. Additional information can be attached to it, such as the source and authorship of the definition."</para>
    /// labels<para>"Definition"</para></remarks>
    /// <seealso href="https://termlex.oeg.fi.upm.es/termlex#Definition">https://termlex.oeg.fi.upm.es/termlex#Definition</seealso>
    let Definition = Prefixed_Name(termlex, "Definition") |> PrefixedName
    /// <summary>
    ///   <para>termlex:Note</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Note class represents additional information given about a resource, may it be a concept, a term or any other entity. Oher data can be attached to it, such as the source and authorship of the note."</para>
    /// labels<para>"Note"</para></remarks>
    /// <seealso href="https://termlex.oeg.fi.upm.es/termlex#Note">https://termlex.oeg.fi.upm.es/termlex#Note</seealso>
    let Note = Prefixed_Name(termlex, "Note") |> PrefixedName
    /// <summary>
    ///   <para>termlex:ReliabilityCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The ReliabilityCode class represents the trustworthiness degree of a determined resource, may it be a concept, a term or any other entity. This class points at a fixed set of values, from 1 to 5, for standardisation purposes.
    /// "</para>
    /// labels<para>"Reliability Code"</para></remarks>
    /// <seealso href="https://termlex.oeg.fi.upm.es/termlex#ReliabilityCode">https://termlex.oeg.fi.upm.es/termlex#ReliabilityCode</seealso>
    let ReliabilityCode = Prefixed_Name(termlex, "ReliabilityCode") |> PrefixedName
    /// <summary>
    ///   <para>termlex:Source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Source class represents the provenance information of an element, may it be the authorship, notes or other sources."</para>
    /// labels<para>"Source"</para></remarks>
    /// <seealso href="https://termlex.oeg.fi.upm.es/termlex#Source">https://termlex.oeg.fi.upm.es/termlex#Source</seealso>
    let Source = Prefixed_Name(termlex, "Source") |> PrefixedName

    /// <summary>
    ///   <para>termlex:TerminologicalConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The TerminologicalConcept class represents a mental abstraction, concept or unit of thought that embodies the meaning of one or more lexical entries, that refer to the same lexical sense, thus, belong to the same area of epertise."</para>
    /// labels<para>"Terminological Concept"</para></remarks>
    /// <seealso href="https://termlex.oeg.fi.upm.es/termlex#TerminologicalConcept">https://termlex.oeg.fi.upm.es/termlex#TerminologicalConcept</seealso>
    let TerminologicalConcept =
        Prefixed_Name(termlex, "TerminologicalConcept") |> PrefixedName

    /// <summary>
    ///   <para>termlex:Usage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Usage class represents usage notes, advices or indications regarding the lexical sense of a given terminological concept. "</para>
    /// labels<para>"Usage"</para></remarks>
    /// <seealso href="https://termlex.oeg.fi.upm.es/termlex#Usage">https://termlex.oeg.fi.upm.es/termlex#Usage</seealso>
    let Usage = Prefixed_Name(termlex, "Usage") |> PrefixedName
    /// <summary>
    ///   <para>termlex:concept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The concept property relates an ontological entity to a terminological concept that represents the corresponding meaning."</para>
    /// labels<para>"concept"</para></remarks>
    /// <seealso href="https://termlex.oeg.fi.upm.es/termlex#concept">https://termlex.oeg.fi.upm.es/termlex#concept</seealso>
    let concept = Prefixed_Name(termlex, "concept") |> PrefixedName
    /// <summary>
    ///   <para>termlex:evokes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The evokes property relates a lexical entry to the terminological concepts it evokes."</para>
    /// labels<para>"evokes"</para></remarks>
    /// <seealso href="https://termlex.oeg.fi.upm.es/termlex#evokes">https://termlex.oeg.fi.upm.es/termlex#evokes</seealso>
    let evokes = Prefixed_Name(termlex, "evokes") |> PrefixedName
    /// <summary>
    ///   <para>termlex:isConceptOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The isConceptOf property relates the meaning of a Terminological Concept by linking it to a particular ontological meaning."</para>
    /// labels<para>"is concept of"</para></remarks>
    /// <seealso href="https://termlex.oeg.fi.upm.es/termlex#isConceptOf">https://termlex.oeg.fi.upm.es/termlex#isConceptOf</seealso>
    let isConceptOf = Prefixed_Name(termlex, "isConceptOf") |> PrefixedName
    /// <summary>
    ///   <para>termlex:isEvokedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The isEvokedBy property relates a terminological concept to one of the lexical entries that evoke it."</para>
    /// labels<para>"is evoked by"</para></remarks>
    /// <seealso href="https://termlex.oeg.fi.upm.es/termlex#isEvokedBy">https://termlex.oeg.fi.upm.es/termlex#isEvokedBy</seealso>
    let isEvokedBy = Prefixed_Name(termlex, "isEvokedBy") |> PrefixedName

    /// <summary>
    ///   <para>termlex:isLexicalizedSenseOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The isLexicalizedSense property relates a lexical sense to a unique corresponding terminological concept."</para>
    /// labels<para>"is lexicalized sense of"</para></remarks>
    /// <seealso href="https://termlex.oeg.fi.upm.es/termlex#isLexicalizedSenseOf">https://termlex.oeg.fi.upm.es/termlex#isLexicalizedSenseOf</seealso>
    let isLexicalizedSenseOf =
        Prefixed_Name(termlex, "isLexicalizedSenseOf") |> PrefixedName

    /// <summary>
    ///   <para>termlex:lexicalizedSense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The lexicalizedSense property relates a terminological concept to a unique corresponding lexical sense."</para>
    /// labels<para>"lexicalized sense"</para></remarks>
    /// <seealso href="https://termlex.oeg.fi.upm.es/termlex#lexicalizedSense">https://termlex.oeg.fi.upm.es/termlex#lexicalizedSense</seealso>
    let lexicalizedSense = Prefixed_Name(termlex, "lexicalizedSense") |> PrefixedName
    /// <summary>
    ///   <para>termlex:reliabilityCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The reliabilityCode property relates a lexical sense to the the reliability code class."</para>
    /// labels<para>"Reliability Code"</para></remarks>
    /// <seealso href="https://termlex.oeg.fi.upm.es/termlex#reliabilityCode">https://termlex.oeg.fi.upm.es/termlex#reliabilityCode</seealso>
    let reliabilityCode = Prefixed_Name(termlex, "reliabilityCode") |> PrefixedName

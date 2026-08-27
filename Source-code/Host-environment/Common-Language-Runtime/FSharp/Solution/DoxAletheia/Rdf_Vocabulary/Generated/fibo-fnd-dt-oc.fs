namespace https.spec.edmcouncil.org.fibo.ontology.FND.DatesAndTimes.Occurrences.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_dt_oc =
    let _namespace_iri = Namespace_Iri fibo_fnd_dt_oc |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-dt-oc:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Occurrences Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_dt_oc, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-dt-oc:Calculation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"calculation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/Calculation">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/Calculation</seealso>
    let Calculation = Prefixed_Name(fibo_fnd_dt_oc, "Calculation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-oc:CalculationEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"calculation event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/CalculationEvent">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/CalculationEvent</seealso>
    let CalculationEvent =
        Prefixed_Name(fibo_fnd_dt_oc, "CalculationEvent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-oc:Occurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"occurrence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/Occurrence">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/Occurrence</seealso>
    let Occurrence = Prefixed_Name(fibo_fnd_dt_oc, "Occurrence") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-oc:OccurrenceBasedDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"occurrence-based date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/OccurrenceBasedDate">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/OccurrenceBasedDate</seealso>
    let OccurrenceBasedDate =
        Prefixed_Name(fibo_fnd_dt_oc, "OccurrenceBasedDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-oc:OccurrenceKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"occurrence kind"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/OccurrenceKind">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/OccurrenceKind</seealso>
    let OccurrenceKind = Prefixed_Name(fibo_fnd_dt_oc, "OccurrenceKind") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-dt-oc:hasEventDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has event date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/hasEventDate">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/hasEventDate</seealso>
    let hasEventDate = Prefixed_Name(fibo_fnd_dt_oc, "hasEventDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-oc:hasEventDateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has event date value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/hasEventDateValue">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/hasEventDateValue</seealso>
    let hasEventDateValue =
        Prefixed_Name(fibo_fnd_dt_oc, "hasEventDateValue") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-oc:hasInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has input"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/hasInput">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/hasInput</seealso>
    let hasInput = Prefixed_Name(fibo_fnd_dt_oc, "hasInput") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-dt-oc:hasOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has occurrence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/hasOccurrence">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/hasOccurrence</seealso>
    let hasOccurrence = Prefixed_Name(fibo_fnd_dt_oc, "hasOccurrence") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-dt-oc:hasOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has output"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/hasOutput">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/hasOutput</seealso>
    let hasOutput = Prefixed_Name(fibo_fnd_dt_oc, "hasOutput") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-dt-oc:isInputTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is input to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/isInputTo">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/isInputTo</seealso>
    let isInputTo = Prefixed_Name(fibo_fnd_dt_oc, "isInputTo") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-dt-oc:isOutputFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is output from"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/isOutputFrom">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/isOutputFrom</seealso>
    let isOutputFrom = Prefixed_Name(fibo_fnd_dt_oc, "isOutputFrom") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-dt-oc:isTriggeredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is triggered by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/isTriggeredBy">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/isTriggeredBy</seealso>
    let isTriggeredBy = Prefixed_Name(fibo_fnd_dt_oc, "isTriggeredBy") |> PrefixedName

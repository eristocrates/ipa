namespace https.spec.edmcouncil.org.fibo.ontology.FND.DatesAndTimes.Occurrences.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_dt_oc =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/hasOccurrence"></see>
    /// </summary>
    let hasOccurrence =
        Namespaced_IRI.parse _namespace_name "hasOccurrence" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/Occurrence"></see>
    /// </summary>
    let Occurrence = Namespaced_IRI.parse _namespace_name "Occurrence" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/OccurrenceKind"></see>
    /// </summary>
    let OccurrenceKind =
        Namespaced_IRI.parse _namespace_name "OccurrenceKind" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/OccurrenceBasedDate"></see>
    /// </summary>
    let OccurrenceBasedDate =
        Namespaced_IRI.parse _namespace_name "OccurrenceBasedDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/Calculation"></see>
    /// </summary>
    let Calculation =
        Namespaced_IRI.parse _namespace_name "Calculation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/CalculationEvent"></see>
    /// </summary>
    let CalculationEvent =
        Namespaced_IRI.parse _namespace_name "CalculationEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/hasEventDate"></see>
    /// </summary>
    let hasEventDate =
        Namespaced_IRI.parse _namespace_name "hasEventDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/hasEventDateValue"></see>
    /// </summary>
    let hasEventDateValue =
        Namespaced_IRI.parse _namespace_name "hasEventDateValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/isTriggeredBy"></see>
    /// </summary>
    let isTriggeredBy =
        Namespaced_IRI.parse _namespace_name "isTriggeredBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/hasInput"></see>
    /// </summary>
    let hasInput = Namespaced_IRI.parse _namespace_name "hasInput" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/isInputTo"></see>
    /// </summary>
    let isInputTo = Namespaced_IRI.parse _namespace_name "isInputTo" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/hasOutput"></see>
    /// </summary>
    let hasOutput = Namespaced_IRI.parse _namespace_name "hasOutput" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/isOutputFrom"></see>
    /// </summary>
    let isOutputFrom =
        Namespaced_IRI.parse _namespace_name "isOutputFrom" |> NamespacedName

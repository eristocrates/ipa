namespace https.spec.edmcouncil.org.fibo.ontology.FND.DatesAndTimes.Occurrences.slash

open DoxAletheia

module fibo_fnd_dt_oc =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/hasOccurrence"></see>
    /// </summary>
    let hasOccurrence = _prefix "hasOccurrence"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/Occurrence"></see>
    /// </summary>
    let Occurrence = _prefix "Occurrence"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/OccurrenceKind"></see>
    /// </summary>
    let OccurrenceKind = _prefix "OccurrenceKind"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/OccurrenceBasedDate"></see>
    /// </summary>
    let OccurrenceBasedDate = _prefix "OccurrenceBasedDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/Calculation"></see>
    /// </summary>
    let Calculation = _prefix "Calculation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/CalculationEvent"></see>
    /// </summary>
    let CalculationEvent = _prefix "CalculationEvent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/hasEventDate"></see>
    /// </summary>
    let hasEventDate = _prefix "hasEventDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/hasEventDateValue"></see>
    /// </summary>
    let hasEventDateValue = _prefix "hasEventDateValue"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/isTriggeredBy"></see>
    /// </summary>
    let isTriggeredBy = _prefix "isTriggeredBy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/hasInput"></see>
    /// </summary>
    let hasInput = _prefix "hasInput"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/isInputTo"></see>
    /// </summary>
    let isInputTo = _prefix "isInputTo"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/hasOutput"></see>
    /// </summary>
    let hasOutput = _prefix "hasOutput"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/isOutputFrom"></see>
    /// </summary>
    let isOutputFrom = _prefix "isOutputFrom"

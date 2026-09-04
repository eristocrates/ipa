#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fnd-dt-oc`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/" "fibo-fnd-dt-oc"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : calculation^^xsd:string</para>
    ///   <para>skos:definition : actual execution of some computation, computational process, or operation that was scheduled or triggered by something^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/Calculation">fibo-fnd-dt-oc:Calculation</a>
    /// </summary>
    let Calculation = _prefixId.prefix "Calculation"
    /// <summary>
    ///   <para>rdfs:label : calculation event^^xsd:string</para>
    ///   <para>skos:definition : kind of event that is either scheduled or triggered by something, such as a related financial event, that causes a calculation to be performed^^xsd:string</para>
    ///   <para>skos:note : A calculation event may be prescriptive, that occurs within a specified period, or ad hoc.^^xsd:stringskos:note : A calculation event related to a debt instrument might be a rate reset event, calculation of interest subsequent to a rate change, an amortization calculation, calculation of interest and/or recalculation of principal due to a late payment, etc. A calculation event related to an investment might involve the adjustment of the number of shares owned, such as a redemption or dividend related event.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/CalculationEvent">fibo-fnd-dt-oc:CalculationEvent</a>
    /// </summary>
    let CalculationEvent = _prefixId.prefix "CalculationEvent"
    /// <summary>
    ///   <para>rdfs:label : occurrence^^xsd:string</para>
    ///   <para>skos:definition : happening of an OccurrenceKind, i.e., an event^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Each occurrence has a date time stamp, which identifies when the event occurred, and, optionally, a location (possibly virtual), that identifies where the occurrence happened.^^xsd:string</para>
    ///   <para>cmns-av:synonym : event^^xsd:string</para>
    ///   <para>cmns-av:usageNote : In order for other ontologies to accept FinancialDates without committing to the particular notions of 'Occurrence' and 'OccurrenceKind' that is modeled here, all aspects of Occurrences are captured in this ontology.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/Occurrence">fibo-fnd-dt-oc:Occurrence</a>
    /// </summary>
    let Occurrence = _prefixId.prefix "Occurrence"
    /// <summary>
    ///   <para>rdfs:label : occurrence-based date^^xsd:string</para>
    ///   <para>skos:definition : calculated date that is defined with respect to the occurrence of some occurrence kind^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The 'hasDateValue' property of an OccurrenceBasedDate is not set until the Occurrence happens. The 'triggeredBy' property relates an OccurrenceBasedDate to the OccurrenceKind that gives the meaning of the OccurrenceBasedDate.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/OccurrenceBasedDate">fibo-fnd-dt-oc:OccurrenceBasedDate</a>
    /// </summary>
    let OccurrenceBasedDate = _prefixId.prefix "OccurrenceBasedDate"
    /// <summary>
    ///   <para>rdfs:label : occurrence kind^^xsd:string</para>
    ///   <para>skos:definition : classifier that specifies the general nature of an occurrence (event)^^xsd:string</para>
    ///   <para>skos:example : loan origination^^xsd:stringskos:example : trade settlement^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : As types (or categories) of events, OccurenceKinds do not happen; OccurenceKinds describe Occurrences which happen and exemplify an OccurenceKind. As occurrences are things that actually happen, they have an actual date where as OccurenceKinds do not have an actual date.^^xsd:string</para>
    ///   <para>cmns-av:usageNote : In order for other ontologies to accept FinancialDates without committing to the particular notions of 'Occurrence' and 'OccurrenceKind' that is modeled here, all aspects of Occurrences are captured in this ontolog^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/OccurrenceKind">fibo-fnd-dt-oc:OccurrenceKind</a>
    /// </summary>
    let OccurrenceKind = _prefixId.prefix "OccurrenceKind"
    /// <summary>
    ///   <para>rdfs:label : has event date^^xsd:string</para>
    ///   <para>skos:definition : identifies a date associated with an event (occurrence)^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/hasEventDate">fibo-fnd-dt-oc:hasEventDate</a>
    /// </summary>
    let hasEventDate = _prefixId.prefix "hasEventDate"
    /// <summary>
    ///   <para>rdfs:label : has event date value^^xsd:string</para>
    ///   <para>skos:definition : identifies a date or date and time value associated with an event (occurrence)^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/hasEventDateValue">fibo-fnd-dt-oc:hasEventDateValue</a>
    /// </summary>
    let hasEventDateValue = _prefixId.prefix "hasEventDateValue"
    /// <summary>
    ///   <para>rdfs:label : has input^^xsd:string</para>
    ///   <para>skos:definition : relates something (e.g. an occurrence) to something that is used as an input to some activity or process^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/hasInput">fibo-fnd-dt-oc:hasInput</a>
    /// </summary>
    let hasInput = _prefixId.prefix "hasInput"
    /// <summary>
    ///   <para>rdfs:label : has occurrence^^xsd:string</para>
    ///   <para>skos:definition : identifies events of a given occurrence kind, typically as they occur in a schedule^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/hasOccurrence">fibo-fnd-dt-oc:hasOccurrence</a>
    /// </summary>
    let hasOccurrence = _prefixId.prefix "hasOccurrence"
    /// <summary>
    ///   <para>rdfs:label : has output^^xsd:string</para>
    ///   <para>skos:definition : relates something (e.g. an occurrence) to something that is the result of some activity or process^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/hasOutput">fibo-fnd-dt-oc:hasOutput</a>
    /// </summary>
    let hasOutput = _prefixId.prefix "hasOutput"
    /// <summary>
    ///   <para>rdfs:label : is input to^^xsd:string</para>
    ///   <para>skos:definition : indicates a precondition, requirement, or other contribution (e.g., data) to some activity, process, system, report, analysis, etc.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/isInputTo">fibo-fnd-dt-oc:isInputTo</a>
    /// </summary>
    let isInputTo = _prefixId.prefix "isInputTo"
    /// <summary>
    ///   <para>rdfs:label : is output from^^xsd:string</para>
    ///   <para>skos:definition : indicates post condition or other product of some activity, process, system, report, analysis, etc.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/isOutputFrom">fibo-fnd-dt-oc:isOutputFrom</a>
    /// </summary>
    let isOutputFrom = _prefixId.prefix "isOutputFrom"
    /// <summary>
    ///   <para>rdfs:label : is triggered by^^xsd:string</para>
    ///   <para>skos:definition : is activated or initiated by^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : An OccurrenceBasedDate is triggered by an Occurrence that exemplifies the OccurrenceKind.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/isTriggeredBy">fibo-fnd-dt-oc:isTriggeredBy</a>
    /// </summary>
    let isTriggeredBy = _prefixId.prefix "isTriggeredBy"

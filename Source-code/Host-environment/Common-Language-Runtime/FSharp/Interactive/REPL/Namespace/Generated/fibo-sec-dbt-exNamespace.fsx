#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-sec-dbt-ex`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/" "fibo-sec-dbt-ex"

    let _namespaceIri = _prefixId.prefix ""
    let AmericanExerciseConvention = _prefixId.prefix "AmericanExerciseConvention"
    /// <summary>
    ///   <para>rdfs:label : American exercise terms</para>
    ///   <para>skos:definition : exercise terms that stipulate that an option may be exercised on or before the date of expiration</para>
    ///   <para>cmns-av:explanatoryNote : Under certain circumstances, early exercise may be advantageous to the option holder.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/AmericanExerciseTerms">fibo-sec-dbt-ex:AmericanExerciseTerms</a>
    /// </summary>
    let AmericanExerciseTerms = _prefixId.prefix "AmericanExerciseTerms"
    let BermudanExerciseConvention = _prefixId.prefix "BermudanExerciseConvention"
    /// <summary>
    ///   <para>rdfs:label : Bermudan exercise terms</para>
    ///   <para>skos:definition : exercise terms that stipulate that an option may only be exercised on predetermined dates within some exercise window, often on one day each month or at the date of expiration</para>
    ///   <para>cmns-av:explanatoryNote : The Bermuda option is named as such because its exercise dates are more flexible than European options and less flexible than American options. Thus, it is in the middle, just like Bermuda is between Europe and America. Bermuda options are also referred to as Mid-Atlantic, Quasi American, or Semi-American options.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/BermudanExerciseTerms">fibo-sec-dbt-ex:BermudanExerciseTerms</a>
    /// </summary>
    let BermudanExerciseTerms = _prefixId.prefix "BermudanExerciseTerms"
    let CanaryExerciseConvention = _prefixId.prefix "CanaryExerciseConvention"
    /// <summary>
    ///   <para>rdfs:label : canary exercise terms</para>
    ///   <para>skos:definition : exercise terms that stipulate that an option may only be exercised on predetermined dates until the first step is reached, but not after that point</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/CanaryExerciseTerms">fibo-sec-dbt-ex:CanaryExerciseTerms</a>
    /// </summary>
    let CanaryExerciseTerms = _prefixId.prefix "CanaryExerciseTerms"
    let EuropeanExerciseConvention = _prefixId.prefix "EuropeanExerciseConvention"
    /// <summary>
    ///   <para>rdfs:label : European exercise terms</para>
    ///   <para>skos:definition : exercise terms that stipulate that an option may only be exercised at the date of expiration</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/EuropeanExerciseTerms">fibo-sec-dbt-ex:EuropeanExerciseTerms</a>
    /// </summary>
    let EuropeanExerciseTerms = _prefixId.prefix "EuropeanExerciseTerms"
    /// <summary>
    ///   <para>rdfs:label : exercise convention</para>
    ///   <para>skos:definition : convention that determines when the holder or future holder of an option can implement the rights defined in the option</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/ExerciseConvention">fibo-sec-dbt-ex:ExerciseConvention</a>
    /// </summary>
    let ExerciseConvention = _prefixId.prefix "ExerciseConvention"
    /// <summary>
    ///   <para>rdfs:label : exercise terms</para>
    ///   <para>skos:definition : contract terms specific to the conditions, conventions and other stipulations related to the exercise of an option or entitlement</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/ExerciseTerms">fibo-sec-dbt-ex:ExerciseTerms</a>
    /// </summary>
    let ExerciseTerms = _prefixId.prefix "ExerciseTerms"
    /// <summary>
    ///   <para>rdfs:label : has exercise date</para>
    ///   <para>skos:definition : indicates a date on which an option may be exercised as specified in the terms of the contract</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/hasExerciseDate">fibo-sec-dbt-ex:hasExerciseDate</a>
    /// </summary>
    let hasExerciseDate = _prefixId.prefix "hasExerciseDate"
    /// <summary>
    ///   <para>rdfs:label : has exercise terms</para>
    ///   <para>skos:definition : links a derivative, such as an option or entitlement, to any exercise terms that are specified therein</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/hasExerciseTerms">fibo-sec-dbt-ex:hasExerciseTerms</a>
    /// </summary>
    let hasExerciseTerms = _prefixId.prefix "hasExerciseTerms"
    /// <summary>
    ///   <para>rdfs:label : has exercise window</para>
    ///   <para>skos:definition : indicates a period of time during which the option may be exercised as specified in the terms of the contract</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/hasExerciseWindow">fibo-sec-dbt-ex:hasExerciseWindow</a>
    /// </summary>
    let hasExerciseWindow = _prefixId.prefix "hasExerciseWindow"

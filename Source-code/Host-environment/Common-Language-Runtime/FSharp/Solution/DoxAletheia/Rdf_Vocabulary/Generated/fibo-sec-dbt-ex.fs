namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Debt.ExerciseConventions.slash

open DoxAletheia

module fibo_sec_dbt_ex =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/AmericanExerciseConvention"></see>
    /// </summary>
    let AmericanExerciseConvention = _prefix "AmericanExerciseConvention"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/ExerciseConvention"></see>
    /// </summary>
    let ExerciseConvention = _prefix "ExerciseConvention"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/AmericanExerciseTerms"></see>
    /// </summary>
    let AmericanExerciseTerms = _prefix "AmericanExerciseTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/ExerciseTerms"></see>
    /// </summary>
    let ExerciseTerms = _prefix "ExerciseTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/BermudanExerciseTerms"></see>
    /// </summary>
    let BermudanExerciseTerms = _prefix "BermudanExerciseTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/EuropeanExerciseTerms"></see>
    /// </summary>
    let EuropeanExerciseTerms = _prefix "EuropeanExerciseTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/BermudanExerciseConvention"></see>
    /// </summary>
    let BermudanExerciseConvention = _prefix "BermudanExerciseConvention"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/hasExerciseDate"></see>
    /// </summary>
    let hasExerciseDate = _prefix "hasExerciseDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/hasExerciseWindow"></see>
    /// </summary>
    let hasExerciseWindow = _prefix "hasExerciseWindow"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/CanaryExerciseConvention"></see>
    /// </summary>
    let CanaryExerciseConvention = _prefix "CanaryExerciseConvention"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/CanaryExerciseTerms"></see>
    /// </summary>
    let CanaryExerciseTerms = _prefix "CanaryExerciseTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/EuropeanExerciseConvention"></see>
    /// </summary>
    let EuropeanExerciseConvention = _prefix "EuropeanExerciseConvention"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/hasExerciseTerms"></see>
    /// </summary>
    let hasExerciseTerms = _prefix "hasExerciseTerms"

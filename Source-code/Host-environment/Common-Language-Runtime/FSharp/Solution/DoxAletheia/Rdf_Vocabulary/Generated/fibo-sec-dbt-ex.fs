namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Debt.ExerciseConventions.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_sec_dbt_ex =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/AmericanExerciseConvention"></see>
    /// </summary>
    let AmericanExerciseConvention =
        Namespaced_IRI.parse _namespace_name "AmericanExerciseConvention" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/ExerciseConvention"></see>
    /// </summary>
    let ExerciseConvention =
        Namespaced_IRI.parse _namespace_name "ExerciseConvention" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/AmericanExerciseTerms"></see>
    /// </summary>
    let AmericanExerciseTerms =
        Namespaced_IRI.parse _namespace_name "AmericanExerciseTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/ExerciseTerms"></see>
    /// </summary>
    let ExerciseTerms =
        Namespaced_IRI.parse _namespace_name "ExerciseTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/BermudanExerciseTerms"></see>
    /// </summary>
    let BermudanExerciseTerms =
        Namespaced_IRI.parse _namespace_name "BermudanExerciseTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/EuropeanExerciseTerms"></see>
    /// </summary>
    let EuropeanExerciseTerms =
        Namespaced_IRI.parse _namespace_name "EuropeanExerciseTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/BermudanExerciseConvention"></see>
    /// </summary>
    let BermudanExerciseConvention =
        Namespaced_IRI.parse _namespace_name "BermudanExerciseConvention" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/hasExerciseDate"></see>
    /// </summary>
    let hasExerciseDate =
        Namespaced_IRI.parse _namespace_name "hasExerciseDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/hasExerciseWindow"></see>
    /// </summary>
    let hasExerciseWindow =
        Namespaced_IRI.parse _namespace_name "hasExerciseWindow" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/CanaryExerciseConvention"></see>
    /// </summary>
    let CanaryExerciseConvention =
        Namespaced_IRI.parse _namespace_name "CanaryExerciseConvention" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/CanaryExerciseTerms"></see>
    /// </summary>
    let CanaryExerciseTerms =
        Namespaced_IRI.parse _namespace_name "CanaryExerciseTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/EuropeanExerciseConvention"></see>
    /// </summary>
    let EuropeanExerciseConvention =
        Namespaced_IRI.parse _namespace_name "EuropeanExerciseConvention" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/hasExerciseTerms"></see>
    /// </summary>
    let hasExerciseTerms =
        Namespaced_IRI.parse _namespace_name "hasExerciseTerms" |> NamespacedName

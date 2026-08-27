namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Debt.ExerciseConventions.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_sec_dbt_ex =
    let _namespace_iri = Namespace_Iri fibo_sec_dbt_ex |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-sec-dbt-ex:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Exercise Conventions Ontology"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_sec_dbt_ex, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-ex:AmericanExerciseConvention</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-sec-dbt-ex:ExerciseConvention</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"American exercise convention"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/AmericanExerciseConvention">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/AmericanExerciseConvention</seealso>
    let AmericanExerciseConvention =
        Prefixed_Name(fibo_sec_dbt_ex, "AmericanExerciseConvention") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-ex:AmericanExerciseTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"American exercise terms"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/AmericanExerciseTerms">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/AmericanExerciseTerms</seealso>
    let AmericanExerciseTerms =
        Prefixed_Name(fibo_sec_dbt_ex, "AmericanExerciseTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-ex:BermudanExerciseConvention</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-sec-dbt-ex:ExerciseConvention</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Bermudan exercise convention"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/BermudanExerciseConvention">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/BermudanExerciseConvention</seealso>
    let BermudanExerciseConvention =
        Prefixed_Name(fibo_sec_dbt_ex, "BermudanExerciseConvention") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-ex:BermudanExerciseTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Bermudan exercise terms"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/BermudanExerciseTerms">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/BermudanExerciseTerms</seealso>
    let BermudanExerciseTerms =
        Prefixed_Name(fibo_sec_dbt_ex, "BermudanExerciseTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-ex:CanaryExerciseConvention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-sec-dbt-ex:ExerciseConvention</para>
    ///
    /// labels<para>"canary exercise convention"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/CanaryExerciseConvention">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/CanaryExerciseConvention</seealso>
    let CanaryExerciseConvention =
        Prefixed_Name(fibo_sec_dbt_ex, "CanaryExerciseConvention") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-ex:CanaryExerciseTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"canary exercise terms"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/CanaryExerciseTerms">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/CanaryExerciseTerms</seealso>
    let CanaryExerciseTerms =
        Prefixed_Name(fibo_sec_dbt_ex, "CanaryExerciseTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-ex:EuropeanExerciseConvention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-sec-dbt-ex:ExerciseConvention</para>
    ///
    /// labels<para>"European exercise convention"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/EuropeanExerciseConvention">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/EuropeanExerciseConvention</seealso>
    let EuropeanExerciseConvention =
        Prefixed_Name(fibo_sec_dbt_ex, "EuropeanExerciseConvention") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-ex:EuropeanExerciseTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"European exercise terms"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/EuropeanExerciseTerms">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/EuropeanExerciseTerms</seealso>
    let EuropeanExerciseTerms =
        Prefixed_Name(fibo_sec_dbt_ex, "EuropeanExerciseTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-ex:ExerciseConvention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"exercise convention"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/ExerciseConvention">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/ExerciseConvention</seealso>
    let ExerciseConvention =
        Prefixed_Name(fibo_sec_dbt_ex, "ExerciseConvention") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-ex:ExerciseTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"exercise terms"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/ExerciseTerms">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/ExerciseTerms</seealso>
    let ExerciseTerms = Prefixed_Name(fibo_sec_dbt_ex, "ExerciseTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-ex:hasExerciseDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has exercise date"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/hasExerciseDate">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/hasExerciseDate</seealso>
    let hasExerciseDate =
        Prefixed_Name(fibo_sec_dbt_ex, "hasExerciseDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-ex:hasExerciseTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has exercise terms"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/hasExerciseTerms">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/hasExerciseTerms</seealso>
    let hasExerciseTerms =
        Prefixed_Name(fibo_sec_dbt_ex, "hasExerciseTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-ex:hasExerciseWindow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has exercise window"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/hasExerciseWindow">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/hasExerciseWindow</seealso>
    let hasExerciseWindow =
        Prefixed_Name(fibo_sec_dbt_ex, "hasExerciseWindow") |> PrefixedName

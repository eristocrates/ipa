namespace Fibo.SEC.Debt.ExerciseConventions.Namespace
module ExerciseConventions =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/SEC/Debt/ExerciseConventions.rdf") (Some @"fibo.SEC.Debt.ExerciseConventions") None
    let AmericanExerciseConvention = {_prefixID with _localName = "AmericanExerciseConvention"}
    let AmericanExerciseTerms = {_prefixID with _localName = "AmericanExerciseTerms"}
    let BermudanExerciseConvention = {_prefixID with _localName = "BermudanExerciseConvention"}
    let BermudanExerciseTerms = {_prefixID with _localName = "BermudanExerciseTerms"}
    let CanaryExerciseConvention = {_prefixID with _localName = "CanaryExerciseConvention"}
    let CanaryExerciseTerms = {_prefixID with _localName = "CanaryExerciseTerms"}
    let EuropeanExerciseConvention = {_prefixID with _localName = "EuropeanExerciseConvention"}
    let EuropeanExerciseTerms = {_prefixID with _localName = "EuropeanExerciseTerms"}
    let ExerciseConvention = {_prefixID with _localName = "ExerciseConvention"}
    let ExerciseTerms = {_prefixID with _localName = "ExerciseTerms"}
    let hasExerciseDate = {_prefixID with _localName = "hasExerciseDate"}
    let hasExerciseTerms = {_prefixID with _localName = "hasExerciseTerms"}
    let hasExerciseWindow = {_prefixID with _localName = "hasExerciseWindow"}
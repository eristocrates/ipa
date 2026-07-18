namespace http.www.essepuntato.it._2013._03.cito_functions.slash

open DoxAletheia.Rdf_Vocabulary

module citof =
    let _namespace_name = "http://www.essepuntato.it/2013/03/cito-functions/"

    /// <summary>
    /// A class defining the set of citation types having a negative rhetorical function.
    /// <see href="http://www.essepuntato.it/2013/03/cito-functions/NegativeRhetoricalFunction"></see></summary>
    let NegativeRhetoricalFunction =
        Namespaced_IRI.parse _namespace_name "NegativeRhetoricalFunction" |> NamespacedName

    /// <summary>
    /// A class defining the set of citation types having a neutral rhetorical function.
    /// <see href="http://www.essepuntato.it/2013/03/cito-functions/NeutralRhetoricalFunction"></see></summary>
    let NeutralRhetoricalFunction =
        Namespaced_IRI.parse _namespace_name "NeutralRhetoricalFunction" |> NamespacedName

    /// <summary>
    /// A class defining the set of citation types having a positive rhetorical function.
    /// <see href="http://www.essepuntato.it/2013/03/cito-functions/PositiveRhetoricalFunction"></see></summary>
    let PositiveRhetoricalFunction =
        Namespaced_IRI.parse _namespace_name "PositiveRhetoricalFunction" |> NamespacedName

    /// <summary>
    /// A class defining the set of citation types having a particular rhetorical function.
    /// <see href="http://www.essepuntato.it/2013/03/cito-functions/RhetoricalFunction"></see></summary>
    let RhetoricalFunction =
        Namespaced_IRI.parse _namespace_name "RhetoricalFunction" |> NamespacedName

    /// <summary>
    /// A class defining the set of citation types having a factual function.
    /// <see href="http://www.essepuntato.it/2013/03/cito-functions/FactualFunction"></see></summary>
    let FactualFunction =
        Namespaced_IRI.parse _namespace_name "FactualFunction" |> NamespacedName

    /// <summary>
    /// A class defining the set of citation types having a particular function.
    /// <see href="http://www.essepuntato.it/2013/03/cito-functions/CitationFunction"></see></summary>
    let CitationFunction =
        Namespaced_IRI.parse _namespace_name "CitationFunction" |> NamespacedName

namespace http.www.essepuntato.it._2013._03.cito_functions.slash

open DoxAletheia

module citof =
    let _namespace_name = "http://www.essepuntato.it/2013/03/cito-functions/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A class defining the set of citation types having a negative rhetorical function.
    /// <see href="http://www.essepuntato.it/2013/03/cito-functions/NegativeRhetoricalFunction"></see></summary>
    let NegativeRhetoricalFunction = _prefix "NegativeRhetoricalFunction"
    /// <summary>
    /// A class defining the set of citation types having a neutral rhetorical function.
    /// <see href="http://www.essepuntato.it/2013/03/cito-functions/NeutralRhetoricalFunction"></see></summary>
    let NeutralRhetoricalFunction = _prefix "NeutralRhetoricalFunction"
    /// <summary>
    /// A class defining the set of citation types having a positive rhetorical function.
    /// <see href="http://www.essepuntato.it/2013/03/cito-functions/PositiveRhetoricalFunction"></see></summary>
    let PositiveRhetoricalFunction = _prefix "PositiveRhetoricalFunction"
    /// <summary>
    /// A class defining the set of citation types having a particular rhetorical function.
    /// <see href="http://www.essepuntato.it/2013/03/cito-functions/RhetoricalFunction"></see></summary>
    let RhetoricalFunction = _prefix "RhetoricalFunction"
    /// <summary>
    /// A class defining the set of citation types having a factual function.
    /// <see href="http://www.essepuntato.it/2013/03/cito-functions/FactualFunction"></see></summary>
    let FactualFunction = _prefix "FactualFunction"
    /// <summary>
    /// A class defining the set of citation types having a particular function.
    /// <see href="http://www.essepuntato.it/2013/03/cito-functions/CitationFunction"></see></summary>
    let CitationFunction = _prefix "CitationFunction"

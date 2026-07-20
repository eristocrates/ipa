namespace http.www.essepuntato.it._2012._04.tvc.slash

open DoxAletheia

module tvc =
    let _namespace_name = "http://www.essepuntato.it/2012/04/tvc/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// It specifies the particular temporal instant or time period in which the situation takes place.
    /// <see href="http://www.essepuntato.it/2012/04/tvc/atTime"></see></summary>
    let atTime = _prefix "atTime"
    /// <summary>
    /// It defines a particular kind of time-indexed situation that represents a hub linking the entity having a particular value, the value itself and the temporal and contextual extents from which the entity-value relationship depends.
    /// <see href="http://www.essepuntato.it/2012/04/tvc/ValueInTime"></see></summary>
    let ValueInTime = _prefix "ValueInTime"
    /// <summary>
    /// It holds the value had by the entity taking part to the situation.
    /// <see href="http://www.essepuntato.it/2012/04/tvc/withValue"></see></summary>
    let withValue = _prefix "withValue"
    /// <summary>
    /// It links to the specific context within which the fact of the entity having the value is relevant.
    /// <see href="http://www.essepuntato.it/2012/04/tvc/withinContext"></see></summary>
    let withinContext = _prefix "withinContext"
    /// <summary>
    /// It links an entity (e.g., a Person) to a particular ValueInTime situation;
    /// <see href="http://www.essepuntato.it/2012/04/tvc/hasValue"></see></summary>
    let hasValue = _prefix "hasValue"

namespace http.purl.org.reco.hash

open DoxAletheia

module reco =
    let _namespace_name = "http://purl.org/reco#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/reco#reco.owl"></see>
    /// </summary>
    let ``reco.owl`` = _prefix "reco.owl"
    /// <summary>
    /// Groups of preferences representing users' requests at a given context or situation.
    /// <see href="http://purl.org/reco#Demand"></see></summary>
    let Demand = _prefix "Demand"
    /// <summary>
    /// A datatype constraint based on boolean operators.
    /// <see href="http://purl.org/reco#Filter"></see></summary>
    let Filter = _prefix "Filter"
    /// <summary>
    /// Boolean operations on data values: string comparisons, numerical intervales and (in)equality. Operators are reused from the X-path specification to ensure interoperability.
    /// <see href="http://purl.org/reco#Operator"></see></summary>
    let Operator = _prefix "Operator"
    /// <summary>
    /// Patterns are reifications of constraints, which are conditions about the desired or preferred attributes of the resources. A constraint ranges over a set of individuals. RECO considers several kind of constraint expressions: (1) conjunction of constraints: "music from the sixties"; (2) disjunction of constraints: "music or films"; (3) composition of constraints: "cars with powerful engines"; (4) datatype constraints based on boolean operators: "released before 1980".
    /// <see href="http://purl.org/reco#Pattern"></see></summary>
    let Pattern = _prefix "Pattern"
    /// <summary>
    /// A preference is a qualitative description of the desired attributes that resources must ideally satisfy in order to be of interest for a user. A preference is described by a set of constraints.
    /// <see href="http://purl.org/reco#Preference"></see></summary>
    let Preference = _prefix "Preference"
    /// <summary>
    /// A rating is a quantitative measurement of the "appealingness" of a particular item to a user.
    /// <see href="http://purl.org/reco#Rating"></see></summary>
    let Rating = _prefix "Rating"
    /// <summary>
    /// A property that relates a preference with its main pattern.
    /// <see href="http://purl.org/reco#about"></see></summary>
    let about = _prefix "about"
    /// <summary>
    /// This property relates a rating with the person having carried out it.
    /// <see href="http://purl.org/reco#assignedBy"></see></summary>
    let assignedBy = _prefix "assignedBy"
    /// <summary>
    /// This property relates a demand with a particular preference P. The items that fulfill the constraints of P are excluded from the set of results calculated for this demand.
    /// <see href="http://purl.org/reco#excludedPreference"></see></summary>
    let excludedPreference = _prefix "excludedPreference"
    /// <summary>
    /// This property relates a demand with the set of preferences that defines its matchmaking conditions.
    /// <see href="http://purl.org/reco#preference"></see></summary>
    let preference = _prefix "preference"
    /// <summary>
    /// A property that relates a pattern with a constraint of the value of a datatype property. For instance, "less than 180 cms height" or "released before 1980".
    /// <see href="http://purl.org/reco#filter"></see></summary>
    let filter = _prefix "filter"
    /// <summary>
    /// This property relates a person with a preference.
    /// <see href="http://purl.org/reco#holds"></see></summary>
    let holds = _prefix "holds"
    /// <summary>
    /// A property that relates a filter to the operator restraining the value of a datatype property.
    /// <see href="http://purl.org/reco#operator"></see></summary>
    let operator = _prefix "operator"
    /// <summary>
    /// This property relates a demand to a preference P. The items that fulfill the constraints of P increase or decline their utility value according to the utility of P.
    /// <see href="http://purl.org/reco#optionalPreference"></see></summary>
    let optionalPreference = _prefix "optionalPreference"
    /// <summary>
    /// This property relates a rating with the resource assessed. Notice that this property has an open range (rdfs:Resource), therefore ratings can be applied to anything, including preferences themselves.
    /// <see href="http://purl.org/reco#rates"></see></summary>
    let rates = _prefix "rates"
    /// <summary>
    /// This property relates a demand with a preference P. The items fulfilling the constraints of P must be included in the final set of results for this demand.
    /// <see href="http://purl.org/reco#requiredPreference"></see></summary>
    let requiredPreference = _prefix "requiredPreference"
    /// <summary>
    /// A property which reifies a disjunction of constraints.
    /// <see href="http://purl.org/reco#union"></see></summary>
    let union = _prefix "union"
    /// <summary>
    /// This property captures the utility value of a rating. The utility in RECO is measured in the real interval [-1,1]. In practice, other discrete scales can be also used to measure users' opinions on resources, such as the Likert scale.
    /// <see href="http://purl.org/reco#utility"></see></summary>
    let utility = _prefix "utility"

namespace http.purl.org.qb4olap.cubes.hash

open DoxAletheia.Rdf_Vocabulary

module qb4o =
    let _namespace_name = "http://purl.org/qb4olap/cubes#"

    /// <summary>
    /// Class that represents aggregate functions that are applied to compute measure aggregate values
    /// <see href="http://purl.org/qb4olap/cubes#AggregateFunction"></see></summary>
    let AggregateFunction =
        Namespaced_IRI.parse _namespace_name "AggregateFunction" |> NamespacedName

    /// <summary>
    /// Returns the arithmetic mean of a set of numeric values.
    /// <see href="http://purl.org/qb4olap/cubes#Avg"></see></summary>
    let Avg = Namespaced_IRI.parse _namespace_name "Avg" |> NamespacedName

    /// <summary>
    /// Class that represents different cardinalities restrictions. These may be applied to  hierarchy steps or to the relationship between facts and dimension levels
    /// <see href="http://purl.org/qb4olap/cubes#Cardinality"></see></summary>
    let Cardinality =
        Namespaced_IRI.parse _namespace_name "Cardinality" |> NamespacedName

    /// <summary>
    /// Returns the number of elements in a set of elements (the cardinality of the set).
    /// <see href="http://purl.org/qb4olap/cubes#Count"></see></summary>
    let Count = Namespaced_IRI.parse _namespace_name "Count" |> NamespacedName
    /// <summary>
    /// The class of components which represent the hierarchies of a dimension
    /// <see href="http://purl.org/qb4olap/cubes#Hierarchy"></see></summary>
    let Hierarchy = Namespaced_IRI.parse _namespace_name "Hierarchy" |> NamespacedName

    /// <summary>
    /// Class that represents a pair of levels (childLevel, parentLevel) in a dimension hierarchy
    /// <see href="http://purl.org/qb4olap/cubes#HierarchyStep"></see></summary>
    let HierarchyStep =
        Namespaced_IRI.parse _namespace_name "HierarchyStep" |> NamespacedName

    /// <summary>
    /// The class of properties that represent level attributes
    /// <see href="http://purl.org/qb4olap/cubes#LevelAttribute"></see></summary>
    let LevelAttribute =
        Namespaced_IRI.parse _namespace_name "LevelAttribute" |> NamespacedName

    /// <summary>
    /// The class of components which represent the members of a level
    /// <see href="http://purl.org/qb4olap/cubes#LevelMember"></see></summary>
    let LevelMember =
        Namespaced_IRI.parse _namespace_name "LevelMember" |> NamespacedName

    /// <summary>
    /// The class of components which represent the levels of a hierarchy
    /// <see href="http://purl.org/qb4olap/cubes#LevelProperty"></see></summary>
    let LevelProperty =
        Namespaced_IRI.parse _namespace_name "LevelProperty" |> NamespacedName

    /// <summary>
    /// Represents N-M cardinality constraint
    /// <see href="http://purl.org/qb4olap/cubes#ManyToMany"></see></summary>
    let ManyToMany = Namespaced_IRI.parse _namespace_name "ManyToMany" |> NamespacedName
    /// <summary>
    /// Represents N-1 cardinality constraint
    /// <see href="http://purl.org/qb4olap/cubes#ManyToOne"></see></summary>
    let ManyToOne = Namespaced_IRI.parse _namespace_name "ManyToOne" |> NamespacedName
    /// <summary>
    /// Returns the maximum element in a set of elements, where a partial order is defined.
    /// <see href="http://purl.org/qb4olap/cubes#Max"></see></summary>
    let Max = Namespaced_IRI.parse _namespace_name "Max" |> NamespacedName
    /// <summary>
    /// Returns the minimum element in a set of elements, where a partial order is defined.
    /// <see href="http://purl.org/qb4olap/cubes#Min"></see></summary>
    let Min = Namespaced_IRI.parse _namespace_name "Min" |> NamespacedName
    /// <summary>
    /// Represents 1-N cardinality constraint
    /// <see href="http://purl.org/qb4olap/cubes#OneToMany"></see></summary>
    let OneToMany = Namespaced_IRI.parse _namespace_name "OneToMany" |> NamespacedName
    /// <summary>
    /// Represents 1-1 cardinality constraint
    /// <see href="http://purl.org/qb4olap/cubes#OneToOne"></see></summary>
    let OneToOne = Namespaced_IRI.parse _namespace_name "OneToOne" |> NamespacedName

    /// <summary>
    /// The class of properties which represent the rollup relationships.
    /// <see href="http://purl.org/qb4olap/cubes#RollupProperty"></see></summary>
    let RollupProperty =
        Namespaced_IRI.parse _namespace_name "RollupProperty" |> NamespacedName

    /// <summary>
    /// Returns the numeric value obtained by adding a set of numeric values.
    /// <see href="http://purl.org/qb4olap/cubes#Sum"></see></summary>
    let Sum = Namespaced_IRI.parse _namespace_name "Sum" |> NamespacedName

    /// <summary>
    /// An alternative to qb:componentProperty which makes explicit that the component is an aggregate function
    /// <see href="http://purl.org/qb4olap/cubes#aggregateFunction"></see></summary>
    let aggregateFunction =
        Namespaced_IRI.parse _namespace_name "aggregateFunction" |> NamespacedName

    /// <summary>
    /// An alternative to qb:componentProperty which allows to specify a cardinality constraint in fact-level relationship
    /// <see href="http://purl.org/qb4olap/cubes#cardinality"></see></summary>
    let cardinality =
        Namespaced_IRI.parse _namespace_name "cardinality" |> NamespacedName

    /// <summary>
    /// Child level property in a HierarchyStep
    /// <see href="http://purl.org/qb4olap/cubes#childLevel"></see></summary>
    let childLevel = Namespaced_IRI.parse _namespace_name "childLevel" |> NamespacedName

    /// <summary>
    /// Indicates the attributes in an level
    /// <see href="http://purl.org/qb4olap/cubes#hasAttribute"></see></summary>
    let hasAttribute =
        Namespaced_IRI.parse _namespace_name "hasAttribute" |> NamespacedName

    /// <summary>
    /// Indicates the hierarchies that compose the dimension
    /// <see href="http://purl.org/qb4olap/cubes#hasHierarchy"></see></summary>
    let hasHierarchy =
        Namespaced_IRI.parse _namespace_name "hasHierarchy" |> NamespacedName

    /// <summary>
    /// Indicates the attribute that identifies level members. Necessary to automatize ROLAP to QB4OLAP
    /// <see href="http://purl.org/qb4olap/cubes#hasID"></see></summary>
    let hasID = Namespaced_IRI.parse _namespace_name "hasID" |> NamespacedName
    /// <summary>
    /// Indicates the levels that compose the hierarchy
    /// <see href="http://purl.org/qb4olap/cubes#hasLevel"></see></summary>
    let hasLevel = Namespaced_IRI.parse _namespace_name "hasLevel" |> NamespacedName

    /// <summary>
    /// Indicates to which dimension the hierarchy belongs
    /// <see href="http://purl.org/qb4olap/cubes#inDimension"></see></summary>
    let inDimension =
        Namespaced_IRI.parse _namespace_name "inDimension" |> NamespacedName

    /// <summary>
    /// Indicates to which hierarchy a hierarchy step (pair of levels) belongs
    /// <see href="http://purl.org/qb4olap/cubes#inHierarchy"></see></summary>
    let inHierarchy =
        Namespaced_IRI.parse _namespace_name "inHierarchy" |> NamespacedName

    /// <summary>
    /// Indicates to which level the level attribute belongs
    /// <see href="http://purl.org/qb4olap/cubes#inLevel"></see></summary>
    let inLevel = Namespaced_IRI.parse _namespace_name "inLevel" |> NamespacedName
    /// <summary>
    /// Indicates to which cube a cuboid corresponds
    /// <see href="http://purl.org/qb4olap/cubes#isCuboidOf"></see></summary>
    let isCuboidOf = Namespaced_IRI.parse _namespace_name "isCuboidOf" |> NamespacedName
    /// <summary>
    /// An alternative to qb:componentProperty which makes explicit that the component is a level
    /// <see href="http://purl.org/qb4olap/cubes#level"></see></summary>
    let level = Namespaced_IRI.parse _namespace_name "level" |> NamespacedName
    /// <summary>
    /// Indicates the level to which the level member belongs
    /// <see href="http://purl.org/qb4olap/cubes#memberOf"></see></summary>
    let memberOf = Namespaced_IRI.parse _namespace_name "memberOf" |> NamespacedName

    /// <summary>
    /// Parent level property in a HierarchyStep
    /// <see href="http://purl.org/qb4olap/cubes#parentLevel"></see></summary>
    let parentLevel =
        Namespaced_IRI.parse _namespace_name "parentLevel" |> NamespacedName

    /// <summary>
    /// A property which allows to specify a cardinality constraint in a parent-child relationship
    /// <see href="http://purl.org/qb4olap/cubes#pcCardinality"></see></summary>
    let pcCardinality =
        Namespaced_IRI.parse _namespace_name "pcCardinality" |> NamespacedName

    /// <summary>
    /// A property which allows to specify the predicate that implements the rollup relationship in a hierarchy step.
    /// <see href="http://purl.org/qb4olap/cubes#rollup"></see></summary>
    let rollup = Namespaced_IRI.parse _namespace_name "rollup" |> NamespacedName

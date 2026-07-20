namespace http.purl.org.qb4olap.cubes.hash

open DoxAletheia

module qb4o =
    let _namespace_name = "http://purl.org/qb4olap/cubes#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Class that represents aggregate functions that are applied to compute measure aggregate values
    /// <see href="http://purl.org/qb4olap/cubes#AggregateFunction"></see></summary>
    let AggregateFunction = _prefix "AggregateFunction"
    /// <summary>
    /// Returns the arithmetic mean of a set of numeric values.
    /// <see href="http://purl.org/qb4olap/cubes#Avg"></see></summary>
    let Avg = _prefix "Avg"
    /// <summary>
    /// Class that represents different cardinalities restrictions. These may be applied to  hierarchy steps or to the relationship between facts and dimension levels
    /// <see href="http://purl.org/qb4olap/cubes#Cardinality"></see></summary>
    let Cardinality = _prefix "Cardinality"
    /// <summary>
    /// Returns the number of elements in a set of elements (the cardinality of the set).
    /// <see href="http://purl.org/qb4olap/cubes#Count"></see></summary>
    let Count = _prefix "Count"
    /// <summary>
    /// The class of components which represent the hierarchies of a dimension
    /// <see href="http://purl.org/qb4olap/cubes#Hierarchy"></see></summary>
    let Hierarchy = _prefix "Hierarchy"
    /// <summary>
    /// Class that represents a pair of levels (childLevel, parentLevel) in a dimension hierarchy
    /// <see href="http://purl.org/qb4olap/cubes#HierarchyStep"></see></summary>
    let HierarchyStep = _prefix "HierarchyStep"
    /// <summary>
    /// The class of properties that represent level attributes
    /// <see href="http://purl.org/qb4olap/cubes#LevelAttribute"></see></summary>
    let LevelAttribute = _prefix "LevelAttribute"
    /// <summary>
    /// The class of components which represent the members of a level
    /// <see href="http://purl.org/qb4olap/cubes#LevelMember"></see></summary>
    let LevelMember = _prefix "LevelMember"
    /// <summary>
    /// The class of components which represent the levels of a hierarchy
    /// <see href="http://purl.org/qb4olap/cubes#LevelProperty"></see></summary>
    let LevelProperty = _prefix "LevelProperty"
    /// <summary>
    /// Represents N-M cardinality constraint
    /// <see href="http://purl.org/qb4olap/cubes#ManyToMany"></see></summary>
    let ManyToMany = _prefix "ManyToMany"
    /// <summary>
    /// Represents N-1 cardinality constraint
    /// <see href="http://purl.org/qb4olap/cubes#ManyToOne"></see></summary>
    let ManyToOne = _prefix "ManyToOne"
    /// <summary>
    /// Returns the maximum element in a set of elements, where a partial order is defined.
    /// <see href="http://purl.org/qb4olap/cubes#Max"></see></summary>
    let Max = _prefix "Max"
    /// <summary>
    /// Returns the minimum element in a set of elements, where a partial order is defined.
    /// <see href="http://purl.org/qb4olap/cubes#Min"></see></summary>
    let Min = _prefix "Min"
    /// <summary>
    /// Represents 1-N cardinality constraint
    /// <see href="http://purl.org/qb4olap/cubes#OneToMany"></see></summary>
    let OneToMany = _prefix "OneToMany"
    /// <summary>
    /// Represents 1-1 cardinality constraint
    /// <see href="http://purl.org/qb4olap/cubes#OneToOne"></see></summary>
    let OneToOne = _prefix "OneToOne"
    /// <summary>
    /// The class of properties which represent the rollup relationships.
    /// <see href="http://purl.org/qb4olap/cubes#RollupProperty"></see></summary>
    let RollupProperty = _prefix "RollupProperty"
    /// <summary>
    /// Returns the numeric value obtained by adding a set of numeric values.
    /// <see href="http://purl.org/qb4olap/cubes#Sum"></see></summary>
    let Sum = _prefix "Sum"
    /// <summary>
    /// An alternative to qb:componentProperty which makes explicit that the component is an aggregate function
    /// <see href="http://purl.org/qb4olap/cubes#aggregateFunction"></see></summary>
    let aggregateFunction = _prefix "aggregateFunction"
    /// <summary>
    /// An alternative to qb:componentProperty which allows to specify a cardinality constraint in fact-level relationship
    /// <see href="http://purl.org/qb4olap/cubes#cardinality"></see></summary>
    let cardinality = _prefix "cardinality"
    /// <summary>
    /// Child level property in a HierarchyStep
    /// <see href="http://purl.org/qb4olap/cubes#childLevel"></see></summary>
    let childLevel = _prefix "childLevel"
    /// <summary>
    /// Indicates the attributes in an level
    /// <see href="http://purl.org/qb4olap/cubes#hasAttribute"></see></summary>
    let hasAttribute = _prefix "hasAttribute"
    /// <summary>
    /// Indicates the hierarchies that compose the dimension
    /// <see href="http://purl.org/qb4olap/cubes#hasHierarchy"></see></summary>
    let hasHierarchy = _prefix "hasHierarchy"
    /// <summary>
    /// Indicates the attribute that identifies level members. Necessary to automatize ROLAP to QB4OLAP
    /// <see href="http://purl.org/qb4olap/cubes#hasID"></see></summary>
    let hasID = _prefix "hasID"
    /// <summary>
    /// Indicates the levels that compose the hierarchy
    /// <see href="http://purl.org/qb4olap/cubes#hasLevel"></see></summary>
    let hasLevel = _prefix "hasLevel"
    /// <summary>
    /// Indicates to which dimension the hierarchy belongs
    /// <see href="http://purl.org/qb4olap/cubes#inDimension"></see></summary>
    let inDimension = _prefix "inDimension"
    /// <summary>
    /// Indicates to which hierarchy a hierarchy step (pair of levels) belongs
    /// <see href="http://purl.org/qb4olap/cubes#inHierarchy"></see></summary>
    let inHierarchy = _prefix "inHierarchy"
    /// <summary>
    /// Indicates to which level the level attribute belongs
    /// <see href="http://purl.org/qb4olap/cubes#inLevel"></see></summary>
    let inLevel = _prefix "inLevel"
    /// <summary>
    /// Indicates to which cube a cuboid corresponds
    /// <see href="http://purl.org/qb4olap/cubes#isCuboidOf"></see></summary>
    let isCuboidOf = _prefix "isCuboidOf"
    /// <summary>
    /// An alternative to qb:componentProperty which makes explicit that the component is a level
    /// <see href="http://purl.org/qb4olap/cubes#level"></see></summary>
    let level = _prefix "level"
    /// <summary>
    /// Indicates the level to which the level member belongs
    /// <see href="http://purl.org/qb4olap/cubes#memberOf"></see></summary>
    let memberOf = _prefix "memberOf"
    /// <summary>
    /// Parent level property in a HierarchyStep
    /// <see href="http://purl.org/qb4olap/cubes#parentLevel"></see></summary>
    let parentLevel = _prefix "parentLevel"
    /// <summary>
    /// A property which allows to specify a cardinality constraint in a parent-child relationship
    /// <see href="http://purl.org/qb4olap/cubes#pcCardinality"></see></summary>
    let pcCardinality = _prefix "pcCardinality"
    /// <summary>
    /// A property which allows to specify the predicate that implements the rollup relationship in a hierarchy step.
    /// <see href="http://purl.org/qb4olap/cubes#rollup"></see></summary>
    let rollup = _prefix "rollup"

namespace http.purl.org.qb4olap.cubes.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module qb4olap =
    let _namespace_iri = Namespace_Iri qb4olap |> NamespaceIRI
    /// <summary>
    ///   <para>qb4olap:Hierarchy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of components which represent the hierarchies of a dimension</para>
    /// labels<para>Hierarchy</para></remarks>
    /// <seealso href="http://purl.org/qb4olap/cubes#Hierarchy">http://purl.org/qb4olap/cubes#Hierarchy</seealso>
    let Hierarchy = Prefixed_Name(qb4olap, "Hierarchy") |> PrefixedName
    /// <summary>
    ///   <para>qb4olap:HierarchyStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Class that represents a pair of levels (childLevel, parentLevel) in a dimension hierarchy</para>
    /// labels<para>hierarchy step</para></remarks>
    /// <seealso href="http://purl.org/qb4olap/cubes#HierarchyStep">http://purl.org/qb4olap/cubes#HierarchyStep</seealso>
    let HierarchyStep = Prefixed_Name(qb4olap, "HierarchyStep") |> PrefixedName
    /// <summary>
    ///   <para>qb4olap:LevelProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of components which represent the levels of a hierarchy</para>
    /// labels<para>Level property</para></remarks>
    /// <seealso href="http://purl.org/qb4olap/cubes#LevelProperty">http://purl.org/qb4olap/cubes#LevelProperty</seealso>
    let LevelProperty = Prefixed_Name(qb4olap, "LevelProperty") |> PrefixedName
    /// <summary>
    ///   <para>qb4olap:OneToMany</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb4olap:Cardinality</para>
    ///   <para>Represents 1-N cardinality constraint</para>
    /// labels<para>1-N cardinality</para></remarks>
    /// <seealso href="http://purl.org/qb4olap/cubes#OneToMany">http://purl.org/qb4olap/cubes#OneToMany</seealso>
    let OneToMany = Prefixed_Name(qb4olap, "OneToMany") |> PrefixedName
    /// <summary>
    ///   <para>qb4olap:AggregateFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Class that represents aggregate functions that are applied to compute measure aggregate values</para>
    /// labels<para>Aggregate function</para></remarks>
    /// <seealso href="http://purl.org/qb4olap/cubes#AggregateFunction">http://purl.org/qb4olap/cubes#AggregateFunction</seealso>
    let AggregateFunction = Prefixed_Name(qb4olap, "AggregateFunction") |> PrefixedName
    /// <summary>
    ///   <para>qb4olap:Avg</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb4olap:AggregateFunction</para>
    ///   <para>Returns the arithmetic mean of a set of numeric values.</para>
    /// labels<para>AVG</para></remarks>
    /// <seealso href="http://purl.org/qb4olap/cubes#Avg">http://purl.org/qb4olap/cubes#Avg</seealso>
    let Avg = Prefixed_Name(qb4olap, "Avg") |> PrefixedName
    /// <summary>
    ///   <para>qb4olap:childLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Child level property in a HierarchyStep</para>
    /// labels<para>child level</para></remarks>
    /// <seealso href="http://purl.org/qb4olap/cubes#childLevel">http://purl.org/qb4olap/cubes#childLevel</seealso>
    let childLevel = Prefixed_Name(qb4olap, "childLevel") |> PrefixedName
    /// <summary>
    ///   <para>qb4olap:hasHierarchy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the hierarchies that compose the dimension</para>
    /// labels<para>set of hierarchies in a dimensoin</para></remarks>
    /// <seealso href="http://purl.org/qb4olap/cubes#hasHierarchy">http://purl.org/qb4olap/cubes#hasHierarchy</seealso>
    let hasHierarchy = Prefixed_Name(qb4olap, "hasHierarchy") |> PrefixedName
    /// <summary>
    ///   <para>qb4olap:hasID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the attribute that identifies level members. Necessary to automatize ROLAP to QB4OLAP</para>
    /// labels<para>Level has ID attribute</para></remarks>
    /// <seealso href="http://purl.org/qb4olap/cubes#hasID">http://purl.org/qb4olap/cubes#hasID</seealso>
    let hasID = Prefixed_Name(qb4olap, "hasID") |> PrefixedName
    /// <summary>
    ///   <para>qb4olap:inDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates to which dimension the hierarchy belongs</para>
    /// labels<para>hierarchy belongs to dimension</para></remarks>
    /// <seealso href="http://purl.org/qb4olap/cubes#inDimension">http://purl.org/qb4olap/cubes#inDimension</seealso>
    let inDimension = Prefixed_Name(qb4olap, "inDimension") |> PrefixedName
    /// <summary>
    ///   <para>qb4olap:inLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates to which level the level attribute belongs</para>
    /// labels<para>level attribute in level</para></remarks>
    /// <seealso href="http://purl.org/qb4olap/cubes#inLevel">http://purl.org/qb4olap/cubes#inLevel</seealso>
    let inLevel = Prefixed_Name(qb4olap, "inLevel") |> PrefixedName
    /// <summary>
    ///   <para>qb4olap:memberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the level to which the level member belongs</para>
    /// labels<para>level member is member of level</para></remarks>
    /// <seealso href="http://purl.org/qb4olap/cubes#memberOf">http://purl.org/qb4olap/cubes#memberOf</seealso>
    let memberOf = Prefixed_Name(qb4olap, "memberOf") |> PrefixedName
    /// <summary>
    ///   <para>qb4olap:parentLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Parent level property in a HierarchyStep</para>
    /// labels<para>parent level</para></remarks>
    /// <seealso href="http://purl.org/qb4olap/cubes#parentLevel">http://purl.org/qb4olap/cubes#parentLevel</seealso>
    let parentLevel = Prefixed_Name(qb4olap, "parentLevel") |> PrefixedName
    /// <summary>
    ///   <para>qb4olap:rollup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A property which allows to specify the predicate that implements the rollup relationship in a hierarchy step.</para>
    /// labels<para>rollup function</para></remarks>
    /// <seealso href="http://purl.org/qb4olap/cubes#rollup">http://purl.org/qb4olap/cubes#rollup</seealso>
    let rollup = Prefixed_Name(qb4olap, "rollup") |> PrefixedName
    /// <summary>
    ///   <para>qb4olap:Cardinality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Class that represents different cardinalities restrictions. These may be applied to  hierarchy steps or to the relationship between facts and dimension levels</para>
    /// labels<para>Cardinality</para></remarks>
    /// <seealso href="http://purl.org/qb4olap/cubes#Cardinality">http://purl.org/qb4olap/cubes#Cardinality</seealso>
    let Cardinality = Prefixed_Name(qb4olap, "Cardinality") |> PrefixedName
    /// <summary>
    ///   <para>qb4olap:level</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An alternative to qb:componentProperty which makes explicit that the component is a level</para>
    /// labels<para>level</para></remarks>
    /// <seealso href="http://purl.org/qb4olap/cubes#level">http://purl.org/qb4olap/cubes#level</seealso>
    let level = Prefixed_Name(qb4olap, "level") |> PrefixedName
    /// <summary>
    ///   <para>qb4olap:pcCardinality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A property which allows to specify a cardinality constraint in a parent-child relationship</para>
    /// labels<para>cardinality constraint</para><para>cardinality</para></remarks>
    /// <seealso href="http://purl.org/qb4olap/cubes#pcCardinality">http://purl.org/qb4olap/cubes#pcCardinality</seealso>
    let pcCardinality = Prefixed_Name(qb4olap, "pcCardinality") |> PrefixedName
    /// <summary>
    ///   <para>qb4olap:Count</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb4olap:AggregateFunction</para>
    ///   <para>Returns the number of elements in a set of elements (the cardinality of the set).</para>
    /// labels<para>COUNT</para></remarks>
    /// <seealso href="http://purl.org/qb4olap/cubes#Count">http://purl.org/qb4olap/cubes#Count</seealso>
    let Count = Prefixed_Name(qb4olap, "Count") |> PrefixedName
    /// <summary>
    ///   <para>qb4olap:LevelAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>The class of properties that represent level attributes</para>
    /// labels<para>Level attribute</para></remarks>
    /// <seealso href="http://purl.org/qb4olap/cubes#LevelAttribute">http://purl.org/qb4olap/cubes#LevelAttribute</seealso>
    let LevelAttribute = Prefixed_Name(qb4olap, "LevelAttribute") |> PrefixedName
    /// <summary>
    ///   <para>qb4olap:ManyToMany</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb4olap:Cardinality</para>
    ///   <para>Represents N-M cardinality constraint</para>
    /// labels<para>N-M cardinality</para></remarks>
    /// <seealso href="http://purl.org/qb4olap/cubes#ManyToMany">http://purl.org/qb4olap/cubes#ManyToMany</seealso>
    let ManyToMany = Prefixed_Name(qb4olap, "ManyToMany") |> PrefixedName
    /// <summary>
    ///   <para>qb4olap:Max</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb4olap:AggregateFunction</para>
    ///   <para>Returns the maximum element in a set of elements, where a partial order is defined.</para>
    /// labels<para>MAX</para></remarks>
    /// <seealso href="http://purl.org/qb4olap/cubes#Max">http://purl.org/qb4olap/cubes#Max</seealso>
    let Max = Prefixed_Name(qb4olap, "Max") |> PrefixedName
    /// <summary>
    ///   <para>qb4olap:RollupProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of properties which represent the rollup relationships.</para>
    /// labels<para>Rollup property</para></remarks>
    /// <seealso href="http://purl.org/qb4olap/cubes#RollupProperty">http://purl.org/qb4olap/cubes#RollupProperty</seealso>
    let RollupProperty = Prefixed_Name(qb4olap, "RollupProperty") |> PrefixedName
    /// <summary>
    ///   <para>qb4olap:hasLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the levels that compose the hierarchy</para>
    /// labels<para>set of levels in hierarchy</para></remarks>
    /// <seealso href="http://purl.org/qb4olap/cubes#hasLevel">http://purl.org/qb4olap/cubes#hasLevel</seealso>
    let hasLevel = Prefixed_Name(qb4olap, "hasLevel") |> PrefixedName
    /// <summary>
    ///   <para>qb4olap:inHierarchy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates to which hierarchy a hierarchy step (pair of levels) belongs</para>
    /// labels<para>hierarchy step belongs to hierarchy</para></remarks>
    /// <seealso href="http://purl.org/qb4olap/cubes#inHierarchy">http://purl.org/qb4olap/cubes#inHierarchy</seealso>
    let inHierarchy = Prefixed_Name(qb4olap, "inHierarchy") |> PrefixedName
    /// <summary>
    ///   <para>qb4olap:isCuboidOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates to which cube a cuboid corresponds</para>
    /// labels<para>is cuboid of</para></remarks>
    /// <seealso href="http://purl.org/qb4olap/cubes#isCuboidOf">http://purl.org/qb4olap/cubes#isCuboidOf</seealso>
    let isCuboidOf = Prefixed_Name(qb4olap, "isCuboidOf") |> PrefixedName
    /// <summary>
    ///   <para>qb4olap:LevelMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of components which represent the members of a level</para>
    /// labels<para>Level member</para></remarks>
    /// <seealso href="http://purl.org/qb4olap/cubes#LevelMember">http://purl.org/qb4olap/cubes#LevelMember</seealso>
    let LevelMember = Prefixed_Name(qb4olap, "LevelMember") |> PrefixedName
    /// <summary>
    ///   <para>qb4olap:ManyToOne</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb4olap:Cardinality</para>
    ///   <para>Represents N-1 cardinality constraint</para>
    /// labels<para>N-1 cardinality</para></remarks>
    /// <seealso href="http://purl.org/qb4olap/cubes#ManyToOne">http://purl.org/qb4olap/cubes#ManyToOne</seealso>
    let ManyToOne = Prefixed_Name(qb4olap, "ManyToOne") |> PrefixedName
    /// <summary>
    ///   <para>qb4olap:Min</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb4olap:AggregateFunction</para>
    ///   <para>Returns the minimum element in a set of elements, where a partial order is defined.</para>
    /// labels<para>MIN</para></remarks>
    /// <seealso href="http://purl.org/qb4olap/cubes#Min">http://purl.org/qb4olap/cubes#Min</seealso>
    let Min = Prefixed_Name(qb4olap, "Min") |> PrefixedName
    /// <summary>
    ///   <para>qb4olap:OneToOne</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb4olap:Cardinality</para>
    ///   <para>Represents 1-1 cardinality constraint</para>
    /// labels<para>1_1 cardinality</para></remarks>
    /// <seealso href="http://purl.org/qb4olap/cubes#OneToOne">http://purl.org/qb4olap/cubes#OneToOne</seealso>
    let OneToOne = Prefixed_Name(qb4olap, "OneToOne") |> PrefixedName
    /// <summary>
    ///   <para>qb4olap:Sum</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb4olap:AggregateFunction</para>
    ///   <para>Returns the numeric value obtained by adding a set of numeric values.</para>
    /// labels<para>SUM</para></remarks>
    /// <seealso href="http://purl.org/qb4olap/cubes#Sum">http://purl.org/qb4olap/cubes#Sum</seealso>
    let Sum = Prefixed_Name(qb4olap, "Sum") |> PrefixedName
    /// <summary>
    ///   <para>qb4olap:aggregateFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An alternative to qb:componentProperty which makes explicit that the component is an aggregate function</para>
    /// labels<para>aggregate function</para></remarks>
    /// <seealso href="http://purl.org/qb4olap/cubes#aggregateFunction">http://purl.org/qb4olap/cubes#aggregateFunction</seealso>
    let aggregateFunction = Prefixed_Name(qb4olap, "aggregateFunction") |> PrefixedName
    /// <summary>
    ///   <para>qb4olap:cardinality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An alternative to qb:componentProperty which allows to specify a cardinality constraint in fact-level relationship</para>
    /// labels<para>cardinality constraint</para><para>cardinality</para></remarks>
    /// <seealso href="http://purl.org/qb4olap/cubes#cardinality">http://purl.org/qb4olap/cubes#cardinality</seealso>
    let cardinality = Prefixed_Name(qb4olap, "cardinality") |> PrefixedName
    /// <summary>
    ///   <para>qb4olap:hasAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the attributes in an level</para>
    /// labels<para>Level has attribute</para></remarks>
    /// <seealso href="http://purl.org/qb4olap/cubes#hasAttribute">http://purl.org/qb4olap/cubes#hasAttribute</seealso>
    let hasAttribute = Prefixed_Name(qb4olap, "hasAttribute") |> PrefixedName

#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module qb4o =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/qb4olap/cubes#" "qb4o"
    /// <summary>
    ///   <para>rdfs:comment : Class that represents aggregate functions that are applied to compute measure aggregate values</para>
    ///   <para>rdfs:label : Aggregate function</para>
    ///   <a href="http://purl.org/qb4olap/cubes#AggregateFunction">qb4o:AggregateFunction</a>
    /// </summary>
    let AggregateFunction = _prefixId.prefix "AggregateFunction"
    let Avg = _prefixId.prefix "Avg"
    /// <summary>
    ///   <para>rdfs:comment : Class that represents different cardinalities restrictions. These may be applied to  hierarchy steps or to the relationship between facts and dimension levels</para>
    ///   <para>rdfs:label : Cardinality</para>
    ///   <a href="http://purl.org/qb4olap/cubes#Cardinality">qb4o:Cardinality</a>
    /// </summary>
    let Cardinality = _prefixId.prefix "Cardinality"
    let Count = _prefixId.prefix "Count"
    /// <summary>
    ///   <para>rdfs:comment : The class of components which represent the hierarchies of a dimension</para>
    ///   <para>rdfs:label : Hierarchy</para>
    ///   <a href="http://purl.org/qb4olap/cubes#Hierarchy">qb4o:Hierarchy</a>
    /// </summary>
    let Hierarchy = _prefixId.prefix "Hierarchy"
    /// <summary>
    ///   <para>rdfs:comment : Class that represents a pair of levels (childLevel, parentLevel) in a dimension hierarchy</para>
    ///   <para>rdfs:label : hierarchy step</para>
    ///   <a href="http://purl.org/qb4olap/cubes#HierarchyStep">qb4o:HierarchyStep</a>
    /// </summary>
    let HierarchyStep = _prefixId.prefix "HierarchyStep"
    /// <summary>
    ///   <para>rdfs:comment : The class of properties that represent level attributes</para>
    ///   <para>rdfs:label : Level attribute^^xsd:string</para>
    ///   <a href="http://purl.org/qb4olap/cubes#LevelAttribute">qb4o:LevelAttribute</a>
    /// </summary>
    let LevelAttribute = _prefixId.prefix "LevelAttribute"
    /// <summary>
    ///   <para>rdfs:comment : The class of components which represent the members of a level</para>
    ///   <para>rdfs:label : Level member</para>
    ///   <a href="http://purl.org/qb4olap/cubes#LevelMember">qb4o:LevelMember</a>
    /// </summary>
    let LevelMember = _prefixId.prefix "LevelMember"
    /// <summary>
    ///   <para>rdfs:comment : The class of components which represent the levels of a hierarchy</para>
    ///   <para>rdfs:label : Level property</para>
    ///   <a href="http://purl.org/qb4olap/cubes#LevelProperty">qb4o:LevelProperty</a>
    /// </summary>
    let LevelProperty = _prefixId.prefix "LevelProperty"
    let ManyToMany = _prefixId.prefix "ManyToMany"
    let ManyToOne = _prefixId.prefix "ManyToOne"
    let Max = _prefixId.prefix "Max"
    let Min = _prefixId.prefix "Min"
    let OneToMany = _prefixId.prefix "OneToMany"
    let OneToOne = _prefixId.prefix "OneToOne"
    /// <summary>
    ///   <para>rdfs:comment : The class of properties which represent the rollup relationships.</para>
    ///   <para>rdfs:label : Rollup property</para>
    ///   <a href="http://purl.org/qb4olap/cubes#RollupProperty">qb4o:RollupProperty</a>
    /// </summary>
    let RollupProperty = _prefixId.prefix "RollupProperty"
    let Sum = _prefixId.prefix "Sum"
    /// <summary>
    ///   <para>rdfs:comment : An alternative to qb:componentProperty which makes explicit that the component is an aggregate function</para>
    ///   <para>rdfs:label : aggregate function</para>
    ///   <a href="http://purl.org/qb4olap/cubes#aggregateFunction">qb4o:aggregateFunction</a>
    /// </summary>
    let aggregateFunction = _prefixId.prefix "aggregateFunction"
    /// <summary>
    ///   <para>rdfs:comment : An alternative to qb:componentProperty which allows to specify a cardinality constraint in fact-level relationship</para>
    ///   <para>rdfs:label : cardinality constraintrdfs:label : cardinality</para>
    ///   <a href="http://purl.org/qb4olap/cubes#cardinality">qb4o:cardinality</a>
    /// </summary>
    let cardinality = _prefixId.prefix "cardinality"
    /// <summary>
    ///   <para>rdfs:comment : Child level property in a HierarchyStep</para>
    ///   <para>rdfs:label : child level</para>
    ///   <a href="http://purl.org/qb4olap/cubes#childLevel">qb4o:childLevel</a>
    /// </summary>
    let childLevel = _prefixId.prefix "childLevel"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the attributes in an level</para>
    ///   <para>rdfs:label : Level has attribute</para>
    ///   <a href="http://purl.org/qb4olap/cubes#hasAttribute">qb4o:hasAttribute</a>
    /// </summary>
    let hasAttribute = _prefixId.prefix "hasAttribute"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the hierarchies that compose the dimension</para>
    ///   <para>rdfs:label : set of hierarchies in a dimensoin</para>
    ///   <a href="http://purl.org/qb4olap/cubes#hasHierarchy">qb4o:hasHierarchy</a>
    /// </summary>
    let hasHierarchy = _prefixId.prefix "hasHierarchy"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the attribute that identifies level members. Necessary to automatize ROLAP to QB4OLAP</para>
    ///   <para>rdfs:label : Level has ID attribute</para>
    ///   <a href="http://purl.org/qb4olap/cubes#hasID">qb4o:hasID</a>
    /// </summary>
    let hasID = _prefixId.prefix "hasID"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the levels that compose the hierarchy</para>
    ///   <para>rdfs:label : set of levels in hierarchy</para>
    ///   <a href="http://purl.org/qb4olap/cubes#hasLevel">qb4o:hasLevel</a>
    /// </summary>
    let hasLevel = _prefixId.prefix "hasLevel"
    /// <summary>
    ///   <para>rdfs:comment : Indicates to which dimension the hierarchy belongs</para>
    ///   <para>rdfs:label : hierarchy belongs to dimension</para>
    ///   <a href="http://purl.org/qb4olap/cubes#inDimension">qb4o:inDimension</a>
    /// </summary>
    let inDimension = _prefixId.prefix "inDimension"
    /// <summary>
    ///   <para>rdfs:comment : Indicates to which hierarchy a hierarchy step (pair of levels) belongs</para>
    ///   <para>rdfs:label : hierarchy step belongs to hierarchy</para>
    ///   <a href="http://purl.org/qb4olap/cubes#inHierarchy">qb4o:inHierarchy</a>
    /// </summary>
    let inHierarchy = _prefixId.prefix "inHierarchy"
    /// <summary>
    ///   <para>rdfs:comment : Indicates to which level the level attribute belongs</para>
    ///   <para>rdfs:label : level attribute in level</para>
    ///   <a href="http://purl.org/qb4olap/cubes#inLevel">qb4o:inLevel</a>
    /// </summary>
    let inLevel = _prefixId.prefix "inLevel"
    /// <summary>
    ///   <para>rdfs:comment : Indicates to which cube a cuboid corresponds</para>
    ///   <para>rdfs:label : is cuboid of</para>
    ///   <a href="http://purl.org/qb4olap/cubes#isCuboidOf">qb4o:isCuboidOf</a>
    /// </summary>
    let isCuboidOf = _prefixId.prefix "isCuboidOf"
    /// <summary>
    ///   <para>rdfs:comment : An alternative to qb:componentProperty which makes explicit that the component is a level</para>
    ///   <para>rdfs:label : level</para>
    ///   <a href="http://purl.org/qb4olap/cubes#level">qb4o:level</a>
    /// </summary>
    let level = _prefixId.prefix "level"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the level to which the level member belongs</para>
    ///   <para>rdfs:label : level member is member of level</para>
    ///   <a href="http://purl.org/qb4olap/cubes#memberOf">qb4o:memberOf</a>
    /// </summary>
    let memberOf = _prefixId.prefix "memberOf"
    /// <summary>
    ///   <para>rdfs:comment : Parent level property in a HierarchyStep</para>
    ///   <para>rdfs:label : parent level</para>
    ///   <a href="http://purl.org/qb4olap/cubes#parentLevel">qb4o:parentLevel</a>
    /// </summary>
    let parentLevel = _prefixId.prefix "parentLevel"
    /// <summary>
    ///   <para>rdfs:comment : A property which allows to specify a cardinality constraint in a parent-child relationship</para>
    ///   <para>rdfs:label : cardinality constraintrdfs:label : cardinality</para>
    ///   <a href="http://purl.org/qb4olap/cubes#pcCardinality">qb4o:pcCardinality</a>
    /// </summary>
    let pcCardinality = _prefixId.prefix "pcCardinality"
    /// <summary>
    ///   <para>rdfs:comment : A property which allows to specify the predicate that implements the rollup relationship in a hierarchy step.</para>
    ///   <para>rdfs:label : rollup function</para>
    ///   <a href="http://purl.org/qb4olap/cubes#rollup">qb4o:rollup</a>
    /// </summary>
    let rollup = _prefixId.prefix "rollup"

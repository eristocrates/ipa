#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module qb =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/linked-data/cube#" "qb"
    /// <summary>
    ///   <para>rdfs:comment : Abstract superclass for everything that can have attributes and dimensions</para>
    ///   <para>rdfs:label : Attachable (abstract)</para>
    ///   <a href="http://purl.org/linked-data/cube#Attachable">qb:Attachable</a>
    /// </summary>
    let Attachable = _prefixId.prefix "Attachable"
    /// <summary>
    ///   <para>rdfs:comment : The class of components which represent attributes of observations in the cube, e.g. unit of measurement</para>
    ///   <para>rdfs:label : Attribute property</para>
    ///   <a href="http://purl.org/linked-data/cube#AttributeProperty">qb:AttributeProperty</a>
    /// </summary>
    let AttributeProperty = _prefixId.prefix "AttributeProperty"
    /// <summary>
    ///   <para>rdfs:comment : Superclass of all coded ComponentProperties</para>
    ///   <para>rdfs:label : Coded property</para>
    ///   <a href="http://purl.org/linked-data/cube#CodedProperty">qb:CodedProperty</a>
    /// </summary>
    let CodedProperty = _prefixId.prefix "CodedProperty"
    /// <summary>
    ///   <para>rdfs:comment : Abstract super-property of all properties representing dimensions, attributes or measures</para>
    ///   <para>rdfs:label : Component property (abstract)</para>
    ///   <a href="http://purl.org/linked-data/cube#ComponentProperty">qb:ComponentProperty</a>
    /// </summary>
    let ComponentProperty = _prefixId.prefix "ComponentProperty"
    /// <summary>
    ///   <para>rdfs:comment : Abstract class of things which reference one or more ComponentProperties</para>
    ///   <para>rdfs:label : Component set</para>
    ///   <a href="http://purl.org/linked-data/cube#ComponentSet">qb:ComponentSet</a>
    /// </summary>
    let ComponentSet = _prefixId.prefix "ComponentSet"
    /// <summary>
    ///   <para>rdfs:comment : Used to define properties of a component (attribute, dimension etc) which are specific to its usage in a DSD.</para>
    ///   <para>rdfs:label : Component specification</para>
    ///   <a href="http://purl.org/linked-data/cube#ComponentSpecification">qb:ComponentSpecification</a>
    /// </summary>
    let ComponentSpecification = _prefixId.prefix "ComponentSpecification"
    /// <summary>
    ///   <para>rdfs:comment : Represents a collection of observations, possibly organized into various slices, conforming to some common dimensional structure.</para>
    ///   <para>rdfs:label : Data set</para>
    ///   <a href="http://purl.org/linked-data/cube#DataSet">qb:DataSet</a>
    /// </summary>
    let DataSet = _prefixId.prefix "DataSet"
    /// <summary>
    ///   <para>rdfs:comment : Defines the structure of a DataSet or slice</para>
    ///   <para>rdfs:label : Data structure definition</para>
    ///   <a href="http://purl.org/linked-data/cube#DataStructureDefinition">qb:DataStructureDefinition</a>
    /// </summary>
    let DataStructureDefinition = _prefixId.prefix "DataStructureDefinition"
    /// <summary>
    ///   <para>rdfs:comment : The class of components which represent the dimensions of the cube</para>
    ///   <para>rdfs:label : Dimension property</para>
    ///   <a href="http://purl.org/linked-data/cube#DimensionProperty">qb:DimensionProperty</a>
    /// </summary>
    let DimensionProperty = _prefixId.prefix "DimensionProperty"
    /// <summary>
    ///   <para>rdfs:comment : Represents a generalized hierarchy of concepts which can be used for coding. The hierarchy is defined by one or more roots together with a property which relates concepts in the hierarchy to thier child concept .  The same concepts may be members of multiple hierarchies provided that different qb:parentChildProperty values are used for each hierarchy.</para>
    ///   <para>rdfs:label : Hierarchical Code List</para>
    ///   <a href="http://purl.org/linked-data/cube#HierarchicalCodeList">qb:HierarchicalCodeList</a>
    /// </summary>
    let HierarchicalCodeList = _prefixId.prefix "HierarchicalCodeList"
    /// <summary>
    ///   <para>rdfs:comment : The class of components which represent the measured value of the phenomenon being observed</para>
    ///   <para>rdfs:label : Measure property</para>
    ///   <a href="http://purl.org/linked-data/cube#MeasureProperty">qb:MeasureProperty</a>
    /// </summary>
    let MeasureProperty = _prefixId.prefix "MeasureProperty"
    /// <summary>
    ///   <para>rdfs:comment : A single observation in the cube, may have one or more associated measured values</para>
    ///   <para>rdfs:label : Observation</para>
    ///   <a href="http://purl.org/linked-data/cube#Observation">qb:Observation</a>
    /// </summary>
    let Observation = _prefixId.prefix "Observation"
    /// <summary>
    ///   <para>rdfs:comment : A, possibly arbitrary, group of observations.</para>
    ///   <para>rdfs:label : Observation Group</para>
    ///   <a href="http://purl.org/linked-data/cube#ObservationGroup">qb:ObservationGroup</a>
    /// </summary>
    let ObservationGroup = _prefixId.prefix "ObservationGroup"
    /// <summary>
    ///   <para>rdfs:comment : Denotes a subset of a DataSet defined by fixing a subset of the dimensional values, component properties on the Slice</para>
    ///   <para>rdfs:label : Slice</para>
    ///   <a href="http://purl.org/linked-data/cube#Slice">qb:Slice</a>
    /// </summary>
    let Slice = _prefixId.prefix "Slice"
    /// <summary>
    ///   <para>rdfs:comment : Denotes a subset of the component properties of a DataSet which are fixed in the corresponding slices</para>
    ///   <para>rdfs:label : Slice key</para>
    ///   <a href="http://purl.org/linked-data/cube#SliceKey">qb:SliceKey</a>
    /// </summary>
    let SliceKey = _prefixId.prefix "SliceKey"
    /// <summary>
    ///   <para>rdfs:comment : An alternative to qb:componentProperty which makes explicit that the component is a attribute</para>
    ///   <para>rdfs:label : attribute</para>
    ///   <a href="http://purl.org/linked-data/cube#attribute">qb:attribute</a>
    /// </summary>
    let attribute = _prefixId.prefix "attribute"
    /// <summary>
    ///   <para>rdfs:comment : gives the code list associated with a CodedProperty</para>
    ///   <para>rdfs:label : code list</para>
    ///   <a href="http://purl.org/linked-data/cube#codeList">qb:codeList</a>
    /// </summary>
    let codeList = _prefixId.prefix "codeList"
    /// <summary>
    ///   <para>rdfs:comment : indicates a component specification which is included in the structure of the dataset</para>
    ///   <para>rdfs:label : component specification</para>
    ///   <a href="http://purl.org/linked-data/cube#component">qb:component</a>
    /// </summary>
    let component_ = _prefixId.prefix "component"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the level at which the component property should be attached, this might an qb:DataSet, qb:Slice or qb:Observation, or a qb:MeasureProperty.</para>
    ///   <para>rdfs:label : component attachment</para>
    ///   <a href="http://purl.org/linked-data/cube#componentAttachment">qb:componentAttachment</a>
    /// </summary>
    let componentAttachment = _prefixId.prefix "componentAttachment"
    /// <summary>
    ///   <para>rdfs:comment : indicates a ComponentProperty (i.e. attribute/dimension) expected on a DataSet, or a dimension fixed in a SliceKey</para>
    ///   <para>rdfs:label : component</para>
    ///   <a href="http://purl.org/linked-data/cube#componentProperty">qb:componentProperty</a>
    /// </summary>
    let componentProperty = _prefixId.prefix "componentProperty"
    /// <summary>
    ///   <para>rdfs:comment : Indicates whether a component property is required (true) or optional (false) in the context of a DSD. Only applicable
    ///     to components correspond to an attribute. Defaults to false (optional).</para>
    ///   <para>rdfs:label : component required</para>
    ///   <a href="http://purl.org/linked-data/cube#componentRequired">qb:componentRequired</a>
    /// </summary>
    let componentRequired = _prefixId.prefix "componentRequired"
    /// <summary>
    ///   <para>rdfs:comment : gives the concept which is being measured or indicated by a ComponentProperty</para>
    ///   <para>rdfs:label : concept</para>
    ///   <a href="http://purl.org/linked-data/cube#concept">qb:concept</a>
    /// </summary>
    let concept = _prefixId.prefix "concept"
    /// <summary>
    ///   <para>rdfs:comment : indicates the data set of which this observation is a part</para>
    ///   <para>rdfs:label : data set</para>
    ///   <a href="http://purl.org/linked-data/cube#dataSet">qb:dataSet</a>
    /// </summary>
    let dataSet = _prefixId.prefix "dataSet"
    /// <summary>
    ///   <para>rdfs:comment : An alternative to qb:componentProperty which makes explicit that the component is a dimension</para>
    ///   <para>rdfs:label : dimension</para>
    ///   <a href="http://purl.org/linked-data/cube#dimension">qb:dimension</a>
    /// </summary>
    let dimension = _prefixId.prefix "dimension"
    /// <summary>
    ///   <para>rdfs:comment : Specifies a root of the hierarchy. A hierarchy may have multiple roots but must have at least one.</para>
    ///   <a href="http://purl.org/linked-data/cube#hierarchyRoot">qb:hierarchyRoot</a>
    /// </summary>
    let hierarchyRoot = _prefixId.prefix "hierarchyRoot"
    /// <summary>
    ///   <para>rdfs:comment : An alternative to qb:componentProperty which makes explicit that the component is a measure</para>
    ///   <para>rdfs:label : measure</para>
    ///   <a href="http://purl.org/linked-data/cube#measure">qb:measure</a>
    /// </summary>
    let measure = _prefixId.prefix "measure"
    /// <summary>
    ///   <para>rdfs:comment : An alternative to qb:componentProperty which makes explicit that the component is a measure dimension</para>
    ///   <para>rdfs:label : measure dimension</para>
    ///   <a href="http://purl.org/linked-data/cube#measureDimension">qb:measureDimension</a>
    /// </summary>
    let measureDimension = _prefixId.prefix "measureDimension"
    /// <summary>
    ///   <para>rdfs:comment : Generic measure dimension, the value of this dimension indicates which measure (from the set of measures in the DSD) is being given by the obsValue (or other primary measure)</para>
    ///   <para>rdfs:label : measure type</para>
    ///   <a href="http://purl.org/linked-data/cube#measureType">qb:measureType</a>
    /// </summary>
    let measureType = _prefixId.prefix "measureType"
    /// <summary>
    ///   <para>rdfs:comment : indicates a observation contained within this slice of the data set</para>
    ///   <para>rdfs:label : observation</para>
    ///   <a href="http://purl.org/linked-data/cube#observation">qb:observation</a>
    /// </summary>
    let observation = _prefixId.prefix "observation"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a group of observations. The domain of this property is left open so that a group may be attached to different resources and need not be restricted to a single DataSet</para>
    ///   <para>rdfs:label : observation group</para>
    ///   <a href="http://purl.org/linked-data/cube#observationGroup">qb:observationGroup</a>
    /// </summary>
    let observationGroup = _prefixId.prefix "observationGroup"
    /// <summary>
    ///   <para>rdfs:comment : indicates a priority order for the components of sets with this structure, used to guide presentations - lower order numbers come before higher numbers, un-numbered components come last</para>
    ///   <para>rdfs:label : order</para>
    ///   <a href="http://purl.org/linked-data/cube#order">qb:order</a>
    /// </summary>
    let order = _prefixId.prefix "order"
    /// <summary>
    ///   <para>rdfs:comment : Specifies a property which relates a parent concept in the hierarchy to a child concept.</para>
    ///   <para>rdfs:label : parent-child property</para>
    ///   <a href="http://purl.org/linked-data/cube#parentChildProperty">qb:parentChildProperty</a>
    /// </summary>
    let parentChildProperty = _prefixId.prefix "parentChildProperty"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a subset of a DataSet defined by fixing a subset of the dimensional values</para>
    ///   <para>rdfs:label : slice</para>
    ///   <a href="http://purl.org/linked-data/cube#slice">qb:slice</a>
    /// </summary>
    let slice = _prefixId.prefix "slice"
    /// <summary>
    ///   <para>rdfs:comment : indicates a slice key which is used for slices in this dataset</para>
    ///   <para>rdfs:label : slice key</para>
    ///   <a href="http://purl.org/linked-data/cube#sliceKey">qb:sliceKey</a>
    /// </summary>
    let sliceKey = _prefixId.prefix "sliceKey"
    /// <summary>
    ///   <para>rdfs:comment : indicates the sub-key corresponding to this slice</para>
    ///   <para>rdfs:label : slice structure</para>
    ///   <a href="http://purl.org/linked-data/cube#sliceStructure">qb:sliceStructure</a>
    /// </summary>
    let sliceStructure = _prefixId.prefix "sliceStructure"
    /// <summary>
    ///   <para>rdfs:comment : indicates the structure to which this data set conforms</para>
    ///   <para>rdfs:label : structure</para>
    ///   <a href="http://purl.org/linked-data/cube#structure">qb:structure</a>
    /// </summary>
    let structure = _prefixId.prefix "structure"

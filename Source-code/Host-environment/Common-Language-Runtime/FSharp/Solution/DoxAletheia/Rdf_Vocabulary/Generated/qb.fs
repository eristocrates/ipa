namespace http.purl.org.linked_data.cube.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module qb =
    let _namespace_iri = Namespace_Iri qb |> NamespaceIRI
    /// <summary>
    ///   <para>qb:Attachable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Abstract superclass for everything that can have attributes and dimensions</para>
    /// labels<para>Attachable (abstract)</para></remarks>
    /// <seealso href="http://purl.org/linked-data/cube#Attachable">http://purl.org/linked-data/cube#Attachable</seealso>
    let Attachable = Prefixed_Name(qb, "Attachable") |> PrefixedName
    /// <summary>
    ///   <para>qb:ObservationGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A, possibly arbitrary, group of observations.</para>
    /// labels<para>Observation Group</para></remarks>
    /// <seealso href="http://purl.org/linked-data/cube#ObservationGroup">http://purl.org/linked-data/cube#ObservationGroup</seealso>
    let ObservationGroup = Prefixed_Name(qb, "ObservationGroup") |> PrefixedName
    /// <summary>
    ///   <para>qb:SliceKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Denotes a subset of the component properties of a DataSet which are fixed in the corresponding slices</para>
    /// labels<para>Slice key</para></remarks>
    /// <seealso href="http://purl.org/linked-data/cube#SliceKey">http://purl.org/linked-data/cube#SliceKey</seealso>
    let SliceKey = Prefixed_Name(qb, "SliceKey") |> PrefixedName
    /// <summary>
    ///   <para>qb:componentProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>indicates a ComponentProperty (i.e. attribute/dimension) expected on a DataSet, or a dimension fixed in a SliceKey</para>
    /// labels<para>component</para></remarks>
    /// <seealso href="http://purl.org/linked-data/cube#componentProperty">http://purl.org/linked-data/cube#componentProperty</seealso>
    let componentProperty = Prefixed_Name(qb, "componentProperty") |> PrefixedName
    /// <summary>
    ///   <para>qb:codeList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>gives the code list associated with a CodedProperty</para>
    /// labels<para>code list</para></remarks>
    /// <seealso href="http://purl.org/linked-data/cube#codeList">http://purl.org/linked-data/cube#codeList</seealso>
    let codeList = Prefixed_Name(qb, "codeList") |> PrefixedName
    /// <summary>
    ///   <para>qb:component</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>indicates a component specification which is included in the structure of the dataset</para>
    /// labels<para>component specification</para></remarks>
    /// <seealso href="http://purl.org/linked-data/cube#component">http://purl.org/linked-data/cube#component</seealso>
    let component_ = Prefixed_Name(qb, "component") |> PrefixedName
    /// <summary>
    ///   <para>qb:componentAttachment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the level at which the component property should be attached, this might an qb:DataSet, qb:Slice or qb:Observation, or a qb:MeasureProperty.</para>
    /// labels<para>component attachment</para></remarks>
    /// <seealso href="http://purl.org/linked-data/cube#componentAttachment">http://purl.org/linked-data/cube#componentAttachment</seealso>
    let componentAttachment = Prefixed_Name(qb, "componentAttachment") |> PrefixedName
    /// <summary>
    ///   <para>qb:AttributeProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>The class of components which represent attributes of observations in the cube, e.g. unit of measurement</para>
    /// labels<para>Attribute property</para></remarks>
    /// <seealso href="http://purl.org/linked-data/cube#AttributeProperty">http://purl.org/linked-data/cube#AttributeProperty</seealso>
    let AttributeProperty = Prefixed_Name(qb, "AttributeProperty") |> PrefixedName
    /// <summary>
    ///   <para>qb:MeasureProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of components which represent the measured value of the phenomenon being observed</para>
    /// labels<para>Measure property</para></remarks>
    /// <seealso href="http://purl.org/linked-data/cube#MeasureProperty">http://purl.org/linked-data/cube#MeasureProperty</seealso>
    let MeasureProperty = Prefixed_Name(qb, "MeasureProperty") |> PrefixedName
    /// <summary>
    ///   <para>qb:attribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An alternative to qb:componentProperty which makes explicit that the component is a attribute</para>
    /// labels<para>attribute</para></remarks>
    /// <seealso href="http://purl.org/linked-data/cube#attribute">http://purl.org/linked-data/cube#attribute</seealso>
    let attribute = Prefixed_Name(qb, "attribute") |> PrefixedName

    /// <summary>
    ///   <para>qb:ComponentSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Used to define properties of a component (attribute, dimension etc) which are specific to its usage in a DSD.</para>
    /// labels<para>Component specification</para></remarks>
    /// <seealso href="http://purl.org/linked-data/cube#ComponentSpecification">http://purl.org/linked-data/cube#ComponentSpecification</seealso>
    let ComponentSpecification =
        Prefixed_Name(qb, "ComponentSpecification") |> PrefixedName

    /// <summary>
    ///   <para>qb:HierarchicalCodeList</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Represents a generalized hierarchy of concepts which can be used for coding. The hierarchy is defined by one or more roots together with a property which relates concepts in the hierarchy to thier child concept .  The same concepts may be members of multiple hierarchies provided that different qb:parentChildProperty values are used for each hierarchy.</para>
    /// labels<para>Hierarchical Code List</para></remarks>
    /// <seealso href="http://purl.org/linked-data/cube#HierarchicalCodeList">http://purl.org/linked-data/cube#HierarchicalCodeList</seealso>
    let HierarchicalCodeList = Prefixed_Name(qb, "HierarchicalCodeList") |> PrefixedName
    /// <summary>
    ///   <para>qb:Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A single observation in the cube, may have one or more associated measured values</para>
    /// labels<para>Observation</para></remarks>
    /// <seealso href="http://purl.org/linked-data/cube#Observation">http://purl.org/linked-data/cube#Observation</seealso>
    let Observation = Prefixed_Name(qb, "Observation") |> PrefixedName
    /// <summary>
    ///   <para>qb:Slice</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Denotes a subset of a DataSet defined by fixing a subset of the dimensional values, component properties on the Slice</para>
    /// labels<para>Slice</para></remarks>
    /// <seealso href="http://purl.org/linked-data/cube#Slice">http://purl.org/linked-data/cube#Slice</seealso>
    let Slice = Prefixed_Name(qb, "Slice") |> PrefixedName
    /// <summary>
    ///   <para>qb:CodedProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Superclass of all coded ComponentProperties</para>
    /// labels<para>Coded property</para></remarks>
    /// <seealso href="http://purl.org/linked-data/cube#CodedProperty">http://purl.org/linked-data/cube#CodedProperty</seealso>
    let CodedProperty = Prefixed_Name(qb, "CodedProperty") |> PrefixedName
    /// <summary>
    ///   <para>qb:measure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>An alternative to qb:componentProperty which makes explicit that the component is a measure</para>
    /// labels<para>measure</para></remarks>
    /// <seealso href="http://purl.org/linked-data/cube#measure">http://purl.org/linked-data/cube#measure</seealso>
    let measure = Prefixed_Name(qb, "measure") |> PrefixedName
    /// <summary>
    ///   <para>qb:ComponentSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Abstract class of things which reference one or more ComponentProperties</para>
    /// labels<para>Component set</para></remarks>
    /// <seealso href="http://purl.org/linked-data/cube#ComponentSet">http://purl.org/linked-data/cube#ComponentSet</seealso>
    let ComponentSet = Prefixed_Name(qb, "ComponentSet") |> PrefixedName
    /// <summary>
    ///   <para>qb:DataSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Represents a collection of observations, possibly organized into various slices, conforming to some common dimensional structure.</para>
    /// labels<para>Data set</para></remarks>
    /// <seealso href="http://purl.org/linked-data/cube#DataSet">http://purl.org/linked-data/cube#DataSet</seealso>
    let DataSet = Prefixed_Name(qb, "DataSet") |> PrefixedName

    /// <summary>
    ///   <para>qb:DataStructureDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Defines the structure of a DataSet or slice</para>
    /// labels<para>Data structure definition</para></remarks>
    /// <seealso href="http://purl.org/linked-data/cube#DataStructureDefinition">http://purl.org/linked-data/cube#DataStructureDefinition</seealso>
    let DataStructureDefinition =
        Prefixed_Name(qb, "DataStructureDefinition") |> PrefixedName

    /// <summary>
    ///   <para>qb:DimensionProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of components which represent the dimensions of the cube</para>
    /// labels<para>Dimension property</para></remarks>
    /// <seealso href="http://purl.org/linked-data/cube#DimensionProperty">http://purl.org/linked-data/cube#DimensionProperty</seealso>
    let DimensionProperty = Prefixed_Name(qb, "DimensionProperty") |> PrefixedName
    /// <summary>
    ///   <para>qb:componentRequired</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates whether a component property is required (true) or optional (false) in the context of a DSD. Only applicable
    ///     to components correspond to an attribute. Defaults to false (optional).</para>
    /// labels<para>component required</para></remarks>
    /// <seealso href="http://purl.org/linked-data/cube#componentRequired">http://purl.org/linked-data/cube#componentRequired</seealso>
    let componentRequired = Prefixed_Name(qb, "componentRequired") |> PrefixedName
    /// <summary>
    ///   <para>qb:concept</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>gives the concept which is being measured or indicated by a ComponentProperty</para>
    /// labels<para>concept</para></remarks>
    /// <seealso href="http://purl.org/linked-data/cube#concept">http://purl.org/linked-data/cube#concept</seealso>
    let concept = Prefixed_Name(qb, "concept") |> PrefixedName
    /// <summary>
    ///   <para>qb:dataSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>indicates the data set of which this observation is a part</para>
    /// labels<para>data set</para></remarks>
    /// <seealso href="http://purl.org/linked-data/cube#dataSet">http://purl.org/linked-data/cube#dataSet</seealso>
    let dataSet = Prefixed_Name(qb, "dataSet") |> PrefixedName
    /// <summary>
    ///   <para>qb:hierarchyRoot</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies a root of the hierarchy. A hierarchy may have multiple roots but must have at least one.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/cube#hierarchyRoot">http://purl.org/linked-data/cube#hierarchyRoot</seealso>
    let hierarchyRoot = Prefixed_Name(qb, "hierarchyRoot") |> PrefixedName
    /// <summary>
    ///   <para>qb:dimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An alternative to qb:componentProperty which makes explicit that the component is a dimension</para>
    /// labels<para>dimension</para></remarks>
    /// <seealso href="http://purl.org/linked-data/cube#dimension">http://purl.org/linked-data/cube#dimension</seealso>
    let dimension = Prefixed_Name(qb, "dimension") |> PrefixedName
    /// <summary>
    ///   <para>qb:measureDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An alternative to qb:componentProperty which makes explicit that the component is a measure dimension</para>
    /// labels<para>measure dimension</para></remarks>
    /// <seealso href="http://purl.org/linked-data/cube#measureDimension">http://purl.org/linked-data/cube#measureDimension</seealso>
    let measureDimension = Prefixed_Name(qb, "measureDimension") |> PrefixedName
    /// <summary>
    ///   <para>qb:measureType</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:DimensionProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Generic measure dimension, the value of this dimension indicates which measure (from the set of measures in the DSD) is being given by the obsValue (or other primary measure)</para>
    /// labels<para>measure type</para></remarks>
    /// <seealso href="http://purl.org/linked-data/cube#measureType">http://purl.org/linked-data/cube#measureType</seealso>
    let measureType = Prefixed_Name(qb, "measureType") |> PrefixedName
    /// <summary>
    ///   <para>qb:observationGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates a group of observations. The domain of this property is left open so that a group may be attached to different resources and need not be restricted to a single DataSet</para>
    /// labels<para>observation group</para></remarks>
    /// <seealso href="http://purl.org/linked-data/cube#observationGroup">http://purl.org/linked-data/cube#observationGroup</seealso>
    let observationGroup = Prefixed_Name(qb, "observationGroup") |> PrefixedName
    /// <summary>
    ///   <para>qb:order</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>indicates a priority order for the components of sets with this structure, used to guide presentations - lower order numbers come before higher numbers, un-numbered components come last</para>
    /// labels<para>order</para></remarks>
    /// <seealso href="http://purl.org/linked-data/cube#order">http://purl.org/linked-data/cube#order</seealso>
    let order = Prefixed_Name(qb, "order") |> PrefixedName
    /// <summary>
    ///   <para>qb:slice</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates a subset of a DataSet defined by fixing a subset of the dimensional values</para>
    /// labels<para>slice</para></remarks>
    /// <seealso href="http://purl.org/linked-data/cube#slice">http://purl.org/linked-data/cube#slice</seealso>
    let slice = Prefixed_Name(qb, "slice") |> PrefixedName
    /// <summary>
    ///   <para>qb:observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>indicates a observation contained within this slice of the data set</para>
    /// labels<para>observation</para></remarks>
    /// <seealso href="http://purl.org/linked-data/cube#observation">http://purl.org/linked-data/cube#observation</seealso>
    let observation = Prefixed_Name(qb, "observation") |> PrefixedName
    /// <summary>
    ///   <para>qb:parentChildProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies a property which relates a parent concept in the hierarchy to a child concept.</para>
    /// labels<para>parent-child property</para></remarks>
    /// <seealso href="http://purl.org/linked-data/cube#parentChildProperty">http://purl.org/linked-data/cube#parentChildProperty</seealso>
    let parentChildProperty = Prefixed_Name(qb, "parentChildProperty") |> PrefixedName
    /// <summary>
    ///   <para>qb:sliceKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>indicates a slice key which is used for slices in this dataset</para>
    /// labels<para>slice key</para></remarks>
    /// <seealso href="http://purl.org/linked-data/cube#sliceKey">http://purl.org/linked-data/cube#sliceKey</seealso>
    let sliceKey = Prefixed_Name(qb, "sliceKey") |> PrefixedName
    /// <summary>
    ///   <para>qb:sliceStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>indicates the sub-key corresponding to this slice</para>
    /// labels<para>slice structure</para></remarks>
    /// <seealso href="http://purl.org/linked-data/cube#sliceStructure">http://purl.org/linked-data/cube#sliceStructure</seealso>
    let sliceStructure = Prefixed_Name(qb, "sliceStructure") |> PrefixedName
    /// <summary>
    ///   <para>qb:structure</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>indicates the structure to which this data set conforms</para>
    /// labels<para>structure</para></remarks>
    /// <seealso href="http://purl.org/linked-data/cube#structure">http://purl.org/linked-data/cube#structure</seealso>
    let structure = Prefixed_Name(qb, "structure") |> PrefixedName
    /// <summary>
    ///   <para>qb:ComponentProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Abstract super-property of all properties representing dimensions, attributes or measures</para>
    /// labels<para>Component property (abstract)</para></remarks>
    /// <seealso href="http://purl.org/linked-data/cube#ComponentProperty">http://purl.org/linked-data/cube#ComponentProperty</seealso>
    let ComponentProperty = Prefixed_Name(qb, "ComponentProperty") |> PrefixedName

namespace http.purl.org.linked_data.cube.hash

open DoxAletheia

module qb =
    let _namespace_name = "http://purl.org/linked-data/cube#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Abstract superclass for everything that can have attributes and dimensions
    /// <see href="http://purl.org/linked-data/cube#Attachable"></see></summary>
    let Attachable = _prefix "Attachable"
    /// <summary>
    /// The class of components which represent attributes of observations in the cube, e.g. unit of measurement
    /// <see href="http://purl.org/linked-data/cube#AttributeProperty"></see></summary>
    let AttributeProperty = _prefix "AttributeProperty"
    /// <summary>
    /// Abstract super-property of all properties representing dimensions, attributes or measures
    /// <see href="http://purl.org/linked-data/cube#ComponentProperty"></see></summary>
    let ComponentProperty = _prefix "ComponentProperty"
    /// <summary>
    /// The class of components which represent the measured value of the phenomenon being observed
    /// <see href="http://purl.org/linked-data/cube#MeasureProperty"></see></summary>
    let MeasureProperty = _prefix "MeasureProperty"
    /// <summary>
    /// Superclass of all coded ComponentProperties
    /// <see href="http://purl.org/linked-data/cube#CodedProperty"></see></summary>
    let CodedProperty = _prefix "CodedProperty"
    /// <summary>
    /// Abstract class of things which reference one or more ComponentProperties
    /// <see href="http://purl.org/linked-data/cube#ComponentSet"></see></summary>
    let ComponentSet = _prefix "ComponentSet"
    /// <summary>
    /// Used to define properties of a component (attribute, dimension etc) which are specific to its usage in a DSD.
    /// <see href="http://purl.org/linked-data/cube#ComponentSpecification"></see></summary>
    let ComponentSpecification = _prefix "ComponentSpecification"
    /// <summary>
    /// Represents a collection of observations, possibly organized into various slices, conforming to some common dimensional structure.
    /// <see href="http://purl.org/linked-data/cube#DataSet"></see></summary>
    let DataSet = _prefix "DataSet"
    /// <summary>
    /// Defines the structure of a DataSet or slice
    /// <see href="http://purl.org/linked-data/cube#DataStructureDefinition"></see></summary>
    let DataStructureDefinition = _prefix "DataStructureDefinition"
    /// <summary>
    /// The class of components which represent the dimensions of the cube
    /// <see href="http://purl.org/linked-data/cube#DimensionProperty"></see></summary>
    let DimensionProperty = _prefix "DimensionProperty"
    /// <summary>
    /// Represents a generalized hierarchy of concepts which can be used for coding. The hierarchy is defined by one or more roots together with a property which relates concepts in the hierarchy to thier child concept .  The same concepts may be members of multiple hierarchies provided that different qb:parentChildProperty values are used for each hierarchy.
    /// <see href="http://purl.org/linked-data/cube#HierarchicalCodeList"></see></summary>
    let HierarchicalCodeList = _prefix "HierarchicalCodeList"
    /// <summary>
    /// A single observation in the cube, may have one or more associated measured values
    /// <see href="http://purl.org/linked-data/cube#Observation"></see></summary>
    let Observation = _prefix "Observation"
    /// <summary>
    /// A, possibly arbitrary, group of observations.
    /// <see href="http://purl.org/linked-data/cube#ObservationGroup"></see></summary>
    let ObservationGroup = _prefix "ObservationGroup"
    /// <summary>
    /// Denotes a subset of a DataSet defined by fixing a subset of the dimensional values, component properties on the Slice
    /// <see href="http://purl.org/linked-data/cube#Slice"></see></summary>
    let Slice = _prefix "Slice"
    /// <summary>
    /// Denotes a subset of the component properties of a DataSet which are fixed in the corresponding slices
    /// <see href="http://purl.org/linked-data/cube#SliceKey"></see></summary>
    let SliceKey = _prefix "SliceKey"
    /// <summary>
    /// An alternative to qb:componentProperty which makes explicit that the component is a attribute
    /// <see href="http://purl.org/linked-data/cube#attribute"></see></summary>
    let attribute = _prefix "attribute"
    /// <summary>
    /// indicates a ComponentProperty (i.e. attribute/dimension) expected on a DataSet, or a dimension fixed in a SliceKey
    /// <see href="http://purl.org/linked-data/cube#componentProperty"></see></summary>
    let componentProperty = _prefix "componentProperty"
    /// <summary>
    /// gives the code list associated with a CodedProperty
    /// <see href="http://purl.org/linked-data/cube#codeList"></see></summary>
    let codeList = _prefix "codeList"
    /// <summary>
    /// indicates a component specification which is included in the structure of the dataset
    /// <see href="http://purl.org/linked-data/cube#component"></see></summary>
    let component_ = _prefix "component"
    /// <summary>
    /// Indicates the level at which the component property should be attached, this might an qb:DataSet, qb:Slice or qb:Observation, or a qb:MeasureProperty.
    /// <see href="http://purl.org/linked-data/cube#componentAttachment"></see></summary>
    let componentAttachment = _prefix "componentAttachment"
    /// <summary>
    /// Indicates whether a component property is required (true) or optional (false) in the context of a DSD. Only applicable
    ///     to components correspond to an attribute. Defaults to false (optional).
    /// <see href="http://purl.org/linked-data/cube#componentRequired"></see></summary>
    let componentRequired = _prefix "componentRequired"
    /// <summary>
    /// gives the concept which is being measured or indicated by a ComponentProperty
    /// <see href="http://purl.org/linked-data/cube#concept"></see></summary>
    let concept = _prefix "concept"
    /// <summary>
    /// indicates the data set of which this observation is a part
    /// <see href="http://purl.org/linked-data/cube#dataSet"></see></summary>
    let dataSet = _prefix "dataSet"
    /// <summary>
    /// An alternative to qb:componentProperty which makes explicit that the component is a dimension
    /// <see href="http://purl.org/linked-data/cube#dimension"></see></summary>
    let dimension = _prefix "dimension"
    /// <summary>
    /// Specifies a root of the hierarchy. A hierarchy may have multiple roots but must have at least one.
    /// <see href="http://purl.org/linked-data/cube#hierarchyRoot"></see></summary>
    let hierarchyRoot = _prefix "hierarchyRoot"
    /// <summary>
    /// An alternative to qb:componentProperty which makes explicit that the component is a measure
    /// <see href="http://purl.org/linked-data/cube#measure"></see></summary>
    let measure = _prefix "measure"
    /// <summary>
    /// An alternative to qb:componentProperty which makes explicit that the component is a measure dimension
    /// <see href="http://purl.org/linked-data/cube#measureDimension"></see></summary>
    let measureDimension = _prefix "measureDimension"
    /// <summary>
    /// Generic measure dimension, the value of this dimension indicates which measure (from the set of measures in the DSD) is being given by the obsValue (or other primary measure)
    /// <see href="http://purl.org/linked-data/cube#measureType"></see></summary>
    let measureType = _prefix "measureType"
    /// <summary>
    /// indicates a observation contained within this slice of the data set
    /// <see href="http://purl.org/linked-data/cube#observation"></see></summary>
    let observation = _prefix "observation"
    /// <summary>
    /// Indicates a group of observations. The domain of this property is left open so that a group may be attached to different resources and need not be restricted to a single DataSet
    /// <see href="http://purl.org/linked-data/cube#observationGroup"></see></summary>
    let observationGroup = _prefix "observationGroup"
    /// <summary>
    /// indicates a priority order for the components of sets with this structure, used to guide presentations - lower order numbers come before higher numbers, un-numbered components come last
    /// <see href="http://purl.org/linked-data/cube#order"></see></summary>
    let order = _prefix "order"
    /// <summary>
    /// Specifies a property which relates a parent concept in the hierarchy to a child concept.
    /// <see href="http://purl.org/linked-data/cube#parentChildProperty"></see></summary>
    let parentChildProperty = _prefix "parentChildProperty"
    /// <summary>
    /// Indicates a subset of a DataSet defined by fixing a subset of the dimensional values
    /// <see href="http://purl.org/linked-data/cube#slice"></see></summary>
    let slice = _prefix "slice"
    /// <summary>
    /// indicates a slice key which is used for slices in this dataset
    /// <see href="http://purl.org/linked-data/cube#sliceKey"></see></summary>
    let sliceKey = _prefix "sliceKey"
    /// <summary>
    /// indicates the sub-key corresponding to this slice
    /// <see href="http://purl.org/linked-data/cube#sliceStructure"></see></summary>
    let sliceStructure = _prefix "sliceStructure"
    /// <summary>
    /// indicates the structure to which this data set conforms
    /// <see href="http://purl.org/linked-data/cube#structure"></see></summary>
    let structure = _prefix "structure"

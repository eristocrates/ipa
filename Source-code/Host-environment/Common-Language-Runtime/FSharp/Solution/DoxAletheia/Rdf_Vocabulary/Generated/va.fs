namespace http.code_research.eu.ontology.visual_analytics.hash

open DoxAletheia

module va =
    let _namespace_name = "http://code-research.eu/ontology/visual-analytics#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Is a line segment that is part of a chart in which the position along the line corresponds to a numeric or categorical value.
    /// <see href="http://code-research.eu/ontology/visual-analytics#Axis"></see></summary>
    let Axis = _prefix "Axis"
    /// <summary>
    /// Represents a visual dimension of a chart.
    /// <see href="http://code-research.eu/ontology/visual-analytics#VisualChannel"></see></summary>
    let VisualChannel = _prefix "VisualChannel"
    /// <summary>
    /// Is the graphical representation of numerical or qualitative data.
    /// <see href="http://code-research.eu/ontology/visual-analytics#Chart"></see></summary>
    let Chart = _prefix "Chart"
    /// <summary>
    /// Represents which name a chart has.
    /// <see href="http://code-research.eu/ontology/visual-analytics#hasChartName"></see></summary>
    let hasChartName = _prefix "hasChartName"
    /// <summary>
    /// Represents the name of a chart.
    /// <see href="http://code-research.eu/ontology/visual-analytics#ChartName"></see></summary>
    let ChartName = _prefix "ChartName"
    /// <summary>
    /// Represents which visual channel a chart has.
    /// <see href="http://code-research.eu/ontology/visual-analytics#hasVisualChannel"></see></summary>
    let hasVisualChannel = _prefix "hasVisualChannel"
    /// <summary>
    ///   <see href="http://code-research.eu/ontology/visual-analytics#supportedDimension"></see>
    /// </summary>
    let supportedDimension = _prefix "supportedDimension"
    /// <summary>
    /// Denotes how many dimensions can be visualize by a chart.
    /// <see href="http://code-research.eu/ontology/visual-analytics#SupportedDimension"></see></summary>
    let SupportedDimension = _prefix "SupportedDimension"
    /// <summary>
    /// Represents a visual dimension of a chart.
    /// <see href="http://code-research.eu/ontology/visual-analytics#Color"></see></summary>
    let Color = _prefix "Color"
    /// <summary>
    /// Represents a mapping for a particular chart.
    /// <see href="http://code-research.eu/ontology/visual-analytics#ComponentMapping"></see></summary>
    let ComponentMapping = _prefix "ComponentMapping"
    /// <summary>
    /// Displays a particular mapping of a RDF Data Cube.
    /// <see href="http://code-research.eu/ontology/visual-analytics#hasComponentMapping"></see></summary>
    let hasComponentMapping = _prefix "hasComponentMapping"
    /// <summary>
    ///   <see href="http://code-research.eu/ontology/visual-analytics#representsChart"></see>
    /// </summary>
    let representsChart = _prefix "representsChart"
    /// <summary>
    ///   <see href="http://code-research.eu/ontology/visual-analytics#MappedChartName"></see>
    /// </summary>
    let MappedChartName = _prefix "MappedChartName"
    /// <summary>
    /// Represents a collection of one or more charts that visualize the same Data Cube.
    /// <see href="http://code-research.eu/ontology/visual-analytics#Dashboard"></see></summary>
    let Dashboard = _prefix "Dashboard"
    /// <summary>
    /// Data type identifies a type of data represented in chart’s visual channel.
    /// <see href="http://code-research.eu/ontology/visual-analytics#DataType"></see></summary>
    let DataType = _prefix "DataType"
    /// <summary>
    /// Denotes that a visual channel must be specified.
    /// <see href="http://code-research.eu/ontology/visual-analytics#Mandatory"></see></summary>
    let Mandatory = _prefix "Mandatory"
    /// <summary>
    /// Persistence denotes whether a visual channel is permanently present in the chart and must be specified or it might be defined if needed.
    /// <see href="http://code-research.eu/ontology/visual-analytics#Persistence"></see></summary>
    let Persistence = _prefix "Persistence"
    /// <summary>
    /// This class contains all mappings created for an RDF Data Cube.
    /// <see href="http://code-research.eu/ontology/visual-analytics#Mapping"></see></summary>
    let Mapping = _prefix "Mapping"
    /// <summary>
    /// Denotes that a visual channel can set at multiple times.
    /// <see href="http://code-research.eu/ontology/visual-analytics#Multiplicity"></see></summary>
    let Multiplicity = _prefix "Multiplicity"
    /// <summary>
    /// Occurrence denotes whether a visual channel can be set only one times or multiple times.
    /// <see href="http://code-research.eu/ontology/visual-analytics#Occurrence"></see></summary>
    let Occurrence = _prefix "Occurrence"
    /// <summary>
    /// Denotes that a visual channel can only set at one times.
    /// <see href="http://code-research.eu/ontology/visual-analytics#One"></see></summary>
    let One = _prefix "One"
    /// <summary>
    /// Denotes that a visual channel must be specified.
    /// <see href="http://code-research.eu/ontology/visual-analytics#Optional"></see></summary>
    let Optional = _prefix "Optional"
    /// <summary>
    /// Represents a visual dimension of a chart.
    /// <see href="http://code-research.eu/ontology/visual-analytics#Size"></see></summary>
    let Size = _prefix "Size"
    /// <summary>
    /// Represents a visual dimension of a chart.
    /// <see href="http://code-research.eu/ontology/visual-analytics#Symbol"></see></summary>
    let Symbol = _prefix "Symbol"
    /// <summary>
    /// Defines which data type a visual channel has.
    /// <see href="http://code-research.eu/ontology/visual-analytics#hasDataType"></see></summary>
    let hasDataType = _prefix "hasDataType"
    /// <summary>
    /// Denotes whether a visual channel can be set only at one times or multiple times.
    /// <see href="http://code-research.eu/ontology/visual-analytics#hasOccurrence"></see></summary>
    let hasOccurrence = _prefix "hasOccurrence"
    /// <summary>
    ///   <see href="http://code-research.eu/ontology/visual-analytics#Occurence"></see>
    /// </summary>
    let Occurence = _prefix "Occurence"
    /// <summary>
    /// Denotes which visual channel of a chart must be specified or might be defined if needed.
    /// <see href="http://code-research.eu/ontology/visual-analytics#hasPersistence"></see></summary>
    let hasPersistence = _prefix "hasPersistence"
    /// <summary>
    /// This class can be used as a fallback for nominal dimensions. It should be avoided in favor of more specific dimension properties.
    /// <see href="http://code-research.eu/ontology/visual-analytics#cubeDimensionNominal"></see></summary>
    let cubeDimensionNominal = _prefix "cubeDimensionNominal"
    /// <summary>
    /// Displays the mappings for a RDF Data Cube.
    /// <see href="http://code-research.eu/ontology/visual-analytics#getMapping"></see></summary>
    let getMapping = _prefix "getMapping"
    /// <summary>
    ///   <see href="http://code-research.eu/ontology/visual-analytics#RDFDataCube"></see>
    /// </summary>
    let RDFDataCube = _prefix "RDFDataCube"
    /// <summary>
    ///   <see href="http://code-research.eu/ontology/visual-analytics#Mappig"></see>
    /// </summary>
    let Mappig = _prefix "Mappig"
    /// <summary>
    /// Represents the component (dimension,measure) of a RDF Data Cube, which has been mapped.
    /// <see href="http://code-research.eu/ontology/visual-analytics#representsCubeProperty"></see></summary>
    let representsCubeProperty = _prefix "representsCubeProperty"
    /// <summary>
    /// Defines the unit measure of a visual channel.
    /// <see href="http://code-research.eu/ontology/visual-analytics#unit"></see></summary>
    let unit = _prefix "unit"
    /// <summary>
    /// Links a Visual Analytics Dashboard with a Data Cube or Data Slice
    /// <see href="http://code-research.eu/ontology/visual-analytics#visualizes"></see></summary>
    let visualizes = _prefix "visualizes"
    /// <summary>
    ///   <see href="http://code-research.eu/ontology/visual-analytics#hasComponentsMapping"></see>
    /// </summary>
    let hasComponentsMapping = _prefix "hasComponentsMapping"

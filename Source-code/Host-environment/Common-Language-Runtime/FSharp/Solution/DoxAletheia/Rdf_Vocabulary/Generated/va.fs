namespace http.code_research.eu.ontology.visual_analytics.hash

open DoxAletheia.Rdf_Vocabulary

module va =
    let _namespace_name = "http://code-research.eu/ontology/visual-analytics#"
    /// <summary>
    /// Is a line segment that is part of a chart in which the position along the line corresponds to a numeric or categorical value.
    /// <see href="http://code-research.eu/ontology/visual-analytics#Axis"></see></summary>
    let Axis = Namespaced_IRI.parse _namespace_name "Axis" |> NamespacedName

    /// <summary>
    /// Represents a visual dimension of a chart.
    /// <see href="http://code-research.eu/ontology/visual-analytics#VisualChannel"></see></summary>
    let VisualChannel =
        Namespaced_IRI.parse _namespace_name "VisualChannel" |> NamespacedName

    /// <summary>
    /// Is the graphical representation of numerical or qualitative data.
    /// <see href="http://code-research.eu/ontology/visual-analytics#Chart"></see></summary>
    let Chart = Namespaced_IRI.parse _namespace_name "Chart" |> NamespacedName

    /// <summary>
    /// Represents which name a chart has.
    /// <see href="http://code-research.eu/ontology/visual-analytics#hasChartName"></see></summary>
    let hasChartName =
        Namespaced_IRI.parse _namespace_name "hasChartName" |> NamespacedName

    /// <summary>
    /// Represents the name of a chart.
    /// <see href="http://code-research.eu/ontology/visual-analytics#ChartName"></see></summary>
    let ChartName = Namespaced_IRI.parse _namespace_name "ChartName" |> NamespacedName

    /// <summary>
    /// Represents which visual channel a chart has.
    /// <see href="http://code-research.eu/ontology/visual-analytics#hasVisualChannel"></see></summary>
    let hasVisualChannel =
        Namespaced_IRI.parse _namespace_name "hasVisualChannel" |> NamespacedName

    /// <summary>
    ///   <see href="http://code-research.eu/ontology/visual-analytics#supportedDimension"></see>
    /// </summary>
    let supportedDimension =
        Namespaced_IRI.parse _namespace_name "supportedDimension" |> NamespacedName

    /// <summary>
    /// Denotes how many dimensions can be visualize by a chart.
    /// <see href="http://code-research.eu/ontology/visual-analytics#SupportedDimension"></see></summary>
    let SupportedDimension =
        Namespaced_IRI.parse _namespace_name "SupportedDimension" |> NamespacedName

    /// <summary>
    /// Represents a visual dimension of a chart.
    /// <see href="http://code-research.eu/ontology/visual-analytics#Color"></see></summary>
    let Color = Namespaced_IRI.parse _namespace_name "Color" |> NamespacedName

    /// <summary>
    /// Represents a mapping for a particular chart.
    /// <see href="http://code-research.eu/ontology/visual-analytics#ComponentMapping"></see></summary>
    let ComponentMapping =
        Namespaced_IRI.parse _namespace_name "ComponentMapping" |> NamespacedName

    /// <summary>
    /// Displays a particular mapping of a RDF Data Cube.
    /// <see href="http://code-research.eu/ontology/visual-analytics#hasComponentMapping"></see></summary>
    let hasComponentMapping =
        Namespaced_IRI.parse _namespace_name "hasComponentMapping" |> NamespacedName

    /// <summary>
    ///   <see href="http://code-research.eu/ontology/visual-analytics#representsChart"></see>
    /// </summary>
    let representsChart =
        Namespaced_IRI.parse _namespace_name "representsChart" |> NamespacedName

    /// <summary>
    ///   <see href="http://code-research.eu/ontology/visual-analytics#MappedChartName"></see>
    /// </summary>
    let MappedChartName =
        Namespaced_IRI.parse _namespace_name "MappedChartName" |> NamespacedName

    /// <summary>
    /// Represents a collection of one or more charts that visualize the same Data Cube.
    /// <see href="http://code-research.eu/ontology/visual-analytics#Dashboard"></see></summary>
    let Dashboard = Namespaced_IRI.parse _namespace_name "Dashboard" |> NamespacedName
    /// <summary>
    /// Data type identifies a type of data represented in chart’s visual channel.
    /// <see href="http://code-research.eu/ontology/visual-analytics#DataType"></see></summary>
    let DataType = Namespaced_IRI.parse _namespace_name "DataType" |> NamespacedName
    /// <summary>
    /// Denotes that a visual channel must be specified.
    /// <see href="http://code-research.eu/ontology/visual-analytics#Mandatory"></see></summary>
    let Mandatory = Namespaced_IRI.parse _namespace_name "Mandatory" |> NamespacedName

    /// <summary>
    /// Persistence denotes whether a visual channel is permanently present in the chart and must be specified or it might be defined if needed.
    /// <see href="http://code-research.eu/ontology/visual-analytics#Persistence"></see></summary>
    let Persistence =
        Namespaced_IRI.parse _namespace_name "Persistence" |> NamespacedName

    /// <summary>
    /// This class contains all mappings created for an RDF Data Cube.
    /// <see href="http://code-research.eu/ontology/visual-analytics#Mapping"></see></summary>
    let Mapping = Namespaced_IRI.parse _namespace_name "Mapping" |> NamespacedName

    /// <summary>
    /// Denotes that a visual channel can set at multiple times.
    /// <see href="http://code-research.eu/ontology/visual-analytics#Multiplicity"></see></summary>
    let Multiplicity =
        Namespaced_IRI.parse _namespace_name "Multiplicity" |> NamespacedName

    /// <summary>
    /// Occurrence denotes whether a visual channel can be set only one times or multiple times.
    /// <see href="http://code-research.eu/ontology/visual-analytics#Occurrence"></see></summary>
    let Occurrence = Namespaced_IRI.parse _namespace_name "Occurrence" |> NamespacedName
    /// <summary>
    /// Denotes that a visual channel can only set at one times.
    /// <see href="http://code-research.eu/ontology/visual-analytics#One"></see></summary>
    let One = Namespaced_IRI.parse _namespace_name "One" |> NamespacedName
    /// <summary>
    /// Denotes that a visual channel must be specified.
    /// <see href="http://code-research.eu/ontology/visual-analytics#Optional"></see></summary>
    let Optional = Namespaced_IRI.parse _namespace_name "Optional" |> NamespacedName
    /// <summary>
    /// Represents a visual dimension of a chart.
    /// <see href="http://code-research.eu/ontology/visual-analytics#Size"></see></summary>
    let Size = Namespaced_IRI.parse _namespace_name "Size" |> NamespacedName
    /// <summary>
    /// Represents a visual dimension of a chart.
    /// <see href="http://code-research.eu/ontology/visual-analytics#Symbol"></see></summary>
    let Symbol = Namespaced_IRI.parse _namespace_name "Symbol" |> NamespacedName

    /// <summary>
    /// Defines which data type a visual channel has.
    /// <see href="http://code-research.eu/ontology/visual-analytics#hasDataType"></see></summary>
    let hasDataType =
        Namespaced_IRI.parse _namespace_name "hasDataType" |> NamespacedName

    /// <summary>
    /// Denotes whether a visual channel can be set only at one times or multiple times.
    /// <see href="http://code-research.eu/ontology/visual-analytics#hasOccurrence"></see></summary>
    let hasOccurrence =
        Namespaced_IRI.parse _namespace_name "hasOccurrence" |> NamespacedName

    /// <summary>
    ///   <see href="http://code-research.eu/ontology/visual-analytics#Occurence"></see>
    /// </summary>
    let Occurence = Namespaced_IRI.parse _namespace_name "Occurence" |> NamespacedName

    /// <summary>
    /// Denotes which visual channel of a chart must be specified or might be defined if needed.
    /// <see href="http://code-research.eu/ontology/visual-analytics#hasPersistence"></see></summary>
    let hasPersistence =
        Namespaced_IRI.parse _namespace_name "hasPersistence" |> NamespacedName

    /// <summary>
    /// This class can be used as a fallback for nominal dimensions. It should be avoided in favor of more specific dimension properties.
    /// <see href="http://code-research.eu/ontology/visual-analytics#cubeDimensionNominal"></see></summary>
    let cubeDimensionNominal =
        Namespaced_IRI.parse _namespace_name "cubeDimensionNominal" |> NamespacedName

    /// <summary>
    /// Displays the mappings for a RDF Data Cube.
    /// <see href="http://code-research.eu/ontology/visual-analytics#getMapping"></see></summary>
    let getMapping = Namespaced_IRI.parse _namespace_name "getMapping" |> NamespacedName

    /// <summary>
    ///   <see href="http://code-research.eu/ontology/visual-analytics#RDFDataCube"></see>
    /// </summary>
    let RDFDataCube =
        Namespaced_IRI.parse _namespace_name "RDFDataCube" |> NamespacedName

    /// <summary>
    ///   <see href="http://code-research.eu/ontology/visual-analytics#Mappig"></see>
    /// </summary>
    let Mappig = Namespaced_IRI.parse _namespace_name "Mappig" |> NamespacedName

    /// <summary>
    /// Represents the component (dimension,measure) of a RDF Data Cube, which has been mapped.
    /// <see href="http://code-research.eu/ontology/visual-analytics#representsCubeProperty"></see></summary>
    let representsCubeProperty =
        Namespaced_IRI.parse _namespace_name "representsCubeProperty" |> NamespacedName

    /// <summary>
    /// Defines the unit measure of a visual channel.
    /// <see href="http://code-research.eu/ontology/visual-analytics#unit"></see></summary>
    let unit = Namespaced_IRI.parse _namespace_name "unit" |> NamespacedName
    /// <summary>
    /// Links a Visual Analytics Dashboard with a Data Cube or Data Slice
    /// <see href="http://code-research.eu/ontology/visual-analytics#visualizes"></see></summary>
    let visualizes = Namespaced_IRI.parse _namespace_name "visualizes" |> NamespacedName

    /// <summary>
    ///   <see href="http://code-research.eu/ontology/visual-analytics#hasComponentsMapping"></see>
    /// </summary>
    let hasComponentsMapping =
        Namespaced_IRI.parse _namespace_name "hasComponentsMapping" |> NamespacedName

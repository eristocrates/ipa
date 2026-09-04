#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module va =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://code-research.eu/ontology/visual-analytics#" "va"

    /// <summary>
    ///   <para>rdfs:comment : Is a line segment that is part of a chart in which the position along the line corresponds to a numeric or categorical value. </para>
    ///   <para>rdfs:label : Axis</para>
    ///   <a href="http://code-research.eu/ontology/visual-analytics#Axis">va:Axis</a>
    /// </summary>
    let Axis = _prefixId.prefix "Axis"
    /// <summary>
    ///   <para>rdfs:comment : Is the graphical representation of numerical or qualitative data.</para>
    ///   <para>rdfs:label : Chart</para>
    ///   <a href="http://code-research.eu/ontology/visual-analytics#Chart">va:Chart</a>
    /// </summary>
    let Chart = _prefixId.prefix "Chart"
    /// <summary>
    ///   <para>rdfs:comment : Represents the name of a chart.</para>
    ///   <para>rdfs:label : Chart Name</para>
    ///   <a href="http://code-research.eu/ontology/visual-analytics#ChartName">va:ChartName</a>
    /// </summary>
    let ChartName = _prefixId.prefix "ChartName"
    /// <summary>
    ///   <para>rdfs:comment : Represents a visual dimension of a chart.</para>
    ///   <para>rdfs:label : Color</para>
    ///   <a href="http://code-research.eu/ontology/visual-analytics#Color">va:Color</a>
    /// </summary>
    let Color = _prefixId.prefix "Color"
    /// <summary>
    ///   <para>rdfs:comment : Represents a mapping for a particular chart.</para>
    ///   <para>rdfs:label : Component mapping</para>
    ///   <a href="http://code-research.eu/ontology/visual-analytics#ComponentMapping">va:ComponentMapping</a>
    /// </summary>
    let ComponentMapping = _prefixId.prefix "ComponentMapping"
    /// <summary>
    ///   <para>rdfs:comment : Represents a collection of one or more charts that visualize the same Data Cube.</para>
    ///   <para>rdfs:label : Dashboard</para>
    ///   <a href="http://code-research.eu/ontology/visual-analytics#Dashboard">va:Dashboard</a>
    /// </summary>
    let Dashboard = _prefixId.prefix "Dashboard"
    /// <summary>
    ///   <para>rdfs:comment : Data type identifies a type of data represented in chart’s visual channel.</para>
    ///   <para>rdfs:label : Data type</para>
    ///   <a href="http://code-research.eu/ontology/visual-analytics#DataType">va:DataType</a>
    /// </summary>
    let DataType = _prefixId.prefix "DataType"
    /// <summary>
    ///   <para>rdfs:comment : Denotes that a visual channel must be specified.</para>
    ///   <para>rdfs:label : Mandatory Persistence </para>
    ///   <a href="http://code-research.eu/ontology/visual-analytics#Mandatory">va:Mandatory</a>
    /// </summary>
    let Mandatory = _prefixId.prefix "Mandatory"
    let MappedChartName = _prefixId.prefix "MappedChartName"
    let Mappig = _prefixId.prefix "Mappig"
    /// <summary>
    ///   <para>rdfs:comment : This class contains all mappings created for an RDF Data Cube.</para>
    ///   <para>rdfs:label : Mapping</para>
    ///   <a href="http://code-research.eu/ontology/visual-analytics#Mapping">va:Mapping</a>
    /// </summary>
    let Mapping = _prefixId.prefix "Mapping"
    /// <summary>
    ///   <para>rdfs:comment : Denotes that a visual channel can set at multiple times.</para>
    ///   <para>rdfs:label : Occurence multiplicity</para>
    ///   <a href="http://code-research.eu/ontology/visual-analytics#Multiplicity">va:Multiplicity</a>
    /// </summary>
    let Multiplicity = _prefixId.prefix "Multiplicity"
    let Occurence = _prefixId.prefix "Occurence"
    /// <summary>
    ///   <para>rdfs:comment : Occurrence denotes whether a visual channel can be set only one times or multiple times.</para>
    ///   <para>rdfs:label : Occurrence</para>
    ///   <a href="http://code-research.eu/ontology/visual-analytics#Occurrence">va:Occurrence</a>
    /// </summary>
    let Occurrence = _prefixId.prefix "Occurrence"
    /// <summary>
    ///   <para>rdfs:comment : Denotes that a visual channel can only set at one times.</para>
    ///   <para>rdfs:label : Occurence one</para>
    ///   <a href="http://code-research.eu/ontology/visual-analytics#One">va:One</a>
    /// </summary>
    let One = _prefixId.prefix "One"
    /// <summary>
    ///   <para>rdfs:comment : Denotes that a visual channel must be specified.</para>
    ///   <para>rdfs:label : Optional Persistence</para>
    ///   <a href="http://code-research.eu/ontology/visual-analytics#Optional">va:Optional</a>
    /// </summary>
    let Optional = _prefixId.prefix "Optional"
    /// <summary>
    ///   <para>rdfs:comment : Persistence denotes whether a visual channel is permanently present in the chart and must be specified or it might be defined if needed.</para>
    ///   <para>rdfs:label : Persistence</para>
    ///   <a href="http://code-research.eu/ontology/visual-analytics#Persistence">va:Persistence</a>
    /// </summary>
    let Persistence = _prefixId.prefix "Persistence"
    let RDFDataCube = _prefixId.prefix "RDFDataCube"
    /// <summary>
    ///   <para>rdfs:comment : Represents a visual dimension of a chart.</para>
    ///   <para>rdfs:label : Size</para>
    ///   <a href="http://code-research.eu/ontology/visual-analytics#Size">va:Size</a>
    /// </summary>
    let Size = _prefixId.prefix "Size"
    /// <summary>
    ///   <para>rdfs:comment : Denotes how many dimensions can be visualize by a chart.</para>
    ///   <para>rdfs:label : Supported dimension</para>
    ///   <a href="http://code-research.eu/ontology/visual-analytics#SupportedDimension">va:SupportedDimension</a>
    /// </summary>
    let SupportedDimension = _prefixId.prefix "SupportedDimension"
    /// <summary>
    ///   <para>rdfs:comment : Represents a visual dimension of a chart.</para>
    ///   <para>rdfs:label : Symbol</para>
    ///   <a href="http://code-research.eu/ontology/visual-analytics#Symbol">va:Symbol</a>
    /// </summary>
    let Symbol = _prefixId.prefix "Symbol"
    /// <summary>
    ///   <para>rdfs:comment : Represents a visual dimension of a chart.</para>
    ///   <para>rdfs:label : Visual channel</para>
    ///   <a href="http://code-research.eu/ontology/visual-analytics#VisualChannel">va:VisualChannel</a>
    /// </summary>
    let VisualChannel = _prefixId.prefix "VisualChannel"
    /// <summary>
    ///   <para>rdfs:comment : This class can be used as a fallback for nominal dimensions. It should be avoided in favor of more specific dimension properties.^^xsd:string</para>
    ///   <para>rdfs:label : Nominal cube dimension^^xsd:string</para>
    ///   <a href="http://code-research.eu/ontology/visual-analytics#cubeDimensionNominal">va:cubeDimensionNominal</a>
    /// </summary>
    let cubeDimensionNominal = _prefixId.prefix "cubeDimensionNominal"
    /// <summary>
    ///   <para>rdfs:comment : Displays the mappings for a RDF Data Cube.</para>
    ///   <para>rdfs:label : Get Mapping</para>
    ///   <a href="http://code-research.eu/ontology/visual-analytics#getMapping">va:getMapping</a>
    /// </summary>
    let getMapping = _prefixId.prefix "getMapping"
    /// <summary>
    ///   <para>rdfs:comment : Represents which name a chart has.</para>
    ///   <para>rdfs:label : Has chart label</para>
    ///   <a href="http://code-research.eu/ontology/visual-analytics#hasChartName">va:hasChartName</a>
    /// </summary>
    let hasChartName = _prefixId.prefix "hasChartName"
    /// <summary>
    ///   <para>rdfs:comment : Displays a particular mapping of a RDF Data Cube.</para>
    ///   <para>rdfs:label : Has components mapping</para>
    ///   <a href="http://code-research.eu/ontology/visual-analytics#hasComponentMapping">va:hasComponentMapping</a>
    /// </summary>
    let hasComponentMapping = _prefixId.prefix "hasComponentMapping"
    let hasComponentsMapping = _prefixId.prefix "hasComponentsMapping"
    /// <summary>
    ///   <para>rdfs:comment : Defines which data type a visual channel has.</para>
    ///   <para>rdfs:label : Has data type</para>
    ///   <a href="http://code-research.eu/ontology/visual-analytics#hasDataType">va:hasDataType</a>
    /// </summary>
    let hasDataType = _prefixId.prefix "hasDataType"
    /// <summary>
    ///   <para>rdfs:comment : Denotes whether a visual channel can be set only at one times or multiple times.</para>
    ///   <para>rdfs:label : Has occurrrence</para>
    ///   <a href="http://code-research.eu/ontology/visual-analytics#hasOccurrence">va:hasOccurrence</a>
    /// </summary>
    let hasOccurrence = _prefixId.prefix "hasOccurrence"
    /// <summary>
    ///   <para>rdfs:comment : Denotes which visual channel of a chart must be specified or might be defined if needed.</para>
    ///   <para>rdfs:label : Has persistence</para>
    ///   <a href="http://code-research.eu/ontology/visual-analytics#hasPersistence">va:hasPersistence</a>
    /// </summary>
    let hasPersistence = _prefixId.prefix "hasPersistence"
    /// <summary>
    ///   <para>rdfs:comment : Represents which visual channel a chart has.</para>
    ///   <para>rdfs:label : Has visual channel</para>
    ///   <a href="http://code-research.eu/ontology/visual-analytics#hasVisualChannel">va:hasVisualChannel</a>
    /// </summary>
    let hasVisualChannel = _prefixId.prefix "hasVisualChannel"
    let representsChart = _prefixId.prefix "representsChart"
    /// <summary>
    ///   <para>rdfs:comment : Represents the component (dimension,measure) of a RDF Data Cube, which has been mapped.</para>
    ///   <para>rdfs:label : Represents chart</para>
    ///   <a href="http://code-research.eu/ontology/visual-analytics#representsCubeProperty">va:representsCubeProperty</a>
    /// </summary>
    let representsCubeProperty = _prefixId.prefix "representsCubeProperty"
    let supportedDimension = _prefixId.prefix "supportedDimension"
    /// <summary>
    ///   <para>rdfs:comment : Defines the unit measure of a visual channel.</para>
    ///   <para>rdfs:label : Unit</para>
    ///   <a href="http://code-research.eu/ontology/visual-analytics#unit">va:unit</a>
    /// </summary>
    let unit = _prefixId.prefix "unit"
    /// <summary>
    ///   <para>rdfs:comment : Links a Visual Analytics Dashboard with a Data Cube or Data Slice</para>
    ///   <para>rdfs:label : visualizes</para>
    ///   <a href="http://code-research.eu/ontology/visual-analytics#visualizes">va:visualizes</a>
    /// </summary>
    let visualizes = _prefixId.prefix "visualizes"

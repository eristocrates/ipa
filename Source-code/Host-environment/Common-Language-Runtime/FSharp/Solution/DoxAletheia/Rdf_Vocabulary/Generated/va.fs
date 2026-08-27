namespace http.code_research.eu.ontology.visual_analytics.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module va =
    let _namespace_iri = Namespace_Iri va |> NamespaceIRI
    /// <summary>
    ///   <para>va:Axis</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Is a line segment that is part of a chart in which the position along the line corresponds to a numeric or categorical value. "</para>
    /// labels<para>"Axis"</para></remarks>
    /// <seealso href="http://code-research.eu/ontology/visual-analytics#Axis">http://code-research.eu/ontology/visual-analytics#Axis</seealso>
    let Axis = Prefixed_Name(va, "Axis") |> PrefixedName
    /// <summary>
    ///   <para>va:Chart</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Is the graphical representation of numerical or qualitative data."</para>
    /// labels<para>"Chart"</para></remarks>
    /// <seealso href="http://code-research.eu/ontology/visual-analytics#Chart">http://code-research.eu/ontology/visual-analytics#Chart</seealso>
    let Chart = Prefixed_Name(va, "Chart") |> PrefixedName
    /// <summary>
    ///   <para>va:ChartName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents the name of a chart."</para>
    /// labels<para>"Chart Name"</para></remarks>
    /// <seealso href="http://code-research.eu/ontology/visual-analytics#ChartName">http://code-research.eu/ontology/visual-analytics#ChartName</seealso>
    let ChartName = Prefixed_Name(va, "ChartName") |> PrefixedName
    /// <summary>
    ///   <para>va:Color</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a visual dimension of a chart."</para>
    /// labels<para>"Color"</para></remarks>
    /// <seealso href="http://code-research.eu/ontology/visual-analytics#Color">http://code-research.eu/ontology/visual-analytics#Color</seealso>
    let Color = Prefixed_Name(va, "Color") |> PrefixedName
    /// <summary>
    ///   <para>va:ComponentMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents a mapping for a particular chart."</para>
    /// labels<para>"Component mapping"</para></remarks>
    /// <seealso href="http://code-research.eu/ontology/visual-analytics#ComponentMapping">http://code-research.eu/ontology/visual-analytics#ComponentMapping</seealso>
    let ComponentMapping = Prefixed_Name(va, "ComponentMapping") |> PrefixedName
    /// <summary>
    ///   <para>va:Dashboard</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a collection of one or more charts that visualize the same Data Cube."</para>
    /// labels<para>"Dashboard"</para></remarks>
    /// <seealso href="http://code-research.eu/ontology/visual-analytics#Dashboard">http://code-research.eu/ontology/visual-analytics#Dashboard</seealso>
    let Dashboard = Prefixed_Name(va, "Dashboard") |> PrefixedName
    /// <summary>
    ///   <para>va:DataType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Data type identifies a type of data represented in chart’s visual channel."</para>
    /// labels<para>"Data type"</para></remarks>
    /// <seealso href="http://code-research.eu/ontology/visual-analytics#DataType">http://code-research.eu/ontology/visual-analytics#DataType</seealso>
    let DataType = Prefixed_Name(va, "DataType") |> PrefixedName
    /// <summary>
    ///   <para>va:Mandatory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Denotes that a visual channel must be specified."</para>
    /// labels<para>"Mandatory Persistence "</para></remarks>
    /// <seealso href="http://code-research.eu/ontology/visual-analytics#Mandatory">http://code-research.eu/ontology/visual-analytics#Mandatory</seealso>
    let Mandatory = Prefixed_Name(va, "Mandatory") |> PrefixedName
    /// <summary>
    ///   <para>va:MappedChartName</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://code-research.eu/ontology/visual-analytics#MappedChartName">http://code-research.eu/ontology/visual-analytics#MappedChartName</seealso>
    let MappedChartName = Prefixed_Name(va, "MappedChartName") |> PrefixedName
    /// <summary>
    ///   <para>va:Mappig</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://code-research.eu/ontology/visual-analytics#Mappig">http://code-research.eu/ontology/visual-analytics#Mappig</seealso>
    let Mappig = Prefixed_Name(va, "Mappig") |> PrefixedName
    /// <summary>
    ///   <para>va:Mapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"This class contains all mappings created for an RDF Data Cube."</para>
    /// labels<para>"Mapping"</para></remarks>
    /// <seealso href="http://code-research.eu/ontology/visual-analytics#Mapping">http://code-research.eu/ontology/visual-analytics#Mapping</seealso>
    let Mapping = Prefixed_Name(va, "Mapping") |> PrefixedName
    /// <summary>
    ///   <para>va:Multiplicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Denotes that a visual channel can set at multiple times."</para>
    /// labels<para>"Occurence multiplicity"</para></remarks>
    /// <seealso href="http://code-research.eu/ontology/visual-analytics#Multiplicity">http://code-research.eu/ontology/visual-analytics#Multiplicity</seealso>
    let Multiplicity = Prefixed_Name(va, "Multiplicity") |> PrefixedName
    /// <summary>
    ///   <para>va:Occurence</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://code-research.eu/ontology/visual-analytics#Occurence">http://code-research.eu/ontology/visual-analytics#Occurence</seealso>
    let Occurence = Prefixed_Name(va, "Occurence") |> PrefixedName
    /// <summary>
    ///   <para>va:Occurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Occurrence denotes whether a visual channel can be set only one times or multiple times."</para>
    /// labels<para>"Occurrence"</para></remarks>
    /// <seealso href="http://code-research.eu/ontology/visual-analytics#Occurrence">http://code-research.eu/ontology/visual-analytics#Occurrence</seealso>
    let Occurrence = Prefixed_Name(va, "Occurrence") |> PrefixedName
    /// <summary>
    ///   <para>va:One</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Denotes that a visual channel can only set at one times."</para>
    /// labels<para>"Occurence one"</para></remarks>
    /// <seealso href="http://code-research.eu/ontology/visual-analytics#One">http://code-research.eu/ontology/visual-analytics#One</seealso>
    let One = Prefixed_Name(va, "One") |> PrefixedName
    /// <summary>
    ///   <para>va:Optional</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Denotes that a visual channel must be specified."</para>
    /// labels<para>"Optional Persistence"</para></remarks>
    /// <seealso href="http://code-research.eu/ontology/visual-analytics#Optional">http://code-research.eu/ontology/visual-analytics#Optional</seealso>
    let Optional = Prefixed_Name(va, "Optional") |> PrefixedName
    /// <summary>
    ///   <para>va:Persistence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Persistence denotes whether a visual channel is permanently present in the chart and must be specified or it might be defined if needed."</para>
    /// labels<para>"Persistence"</para></remarks>
    /// <seealso href="http://code-research.eu/ontology/visual-analytics#Persistence">http://code-research.eu/ontology/visual-analytics#Persistence</seealso>
    let Persistence = Prefixed_Name(va, "Persistence") |> PrefixedName
    /// <summary>
    ///   <para>va:RDFDataCube</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://code-research.eu/ontology/visual-analytics#RDFDataCube">http://code-research.eu/ontology/visual-analytics#RDFDataCube</seealso>
    let RDFDataCube = Prefixed_Name(va, "RDFDataCube") |> PrefixedName
    /// <summary>
    ///   <para>va:Size</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a visual dimension of a chart."</para>
    /// labels<para>"Size"</para></remarks>
    /// <seealso href="http://code-research.eu/ontology/visual-analytics#Size">http://code-research.eu/ontology/visual-analytics#Size</seealso>
    let Size = Prefixed_Name(va, "Size") |> PrefixedName
    /// <summary>
    ///   <para>va:SupportedDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Denotes how many dimensions can be visualize by a chart."</para>
    /// labels<para>"Supported dimension"</para></remarks>
    /// <seealso href="http://code-research.eu/ontology/visual-analytics#SupportedDimension">http://code-research.eu/ontology/visual-analytics#SupportedDimension</seealso>
    let SupportedDimension = Prefixed_Name(va, "SupportedDimension") |> PrefixedName
    /// <summary>
    ///   <para>va:Symbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a visual dimension of a chart."</para>
    /// labels<para>"Symbol"</para></remarks>
    /// <seealso href="http://code-research.eu/ontology/visual-analytics#Symbol">http://code-research.eu/ontology/visual-analytics#Symbol</seealso>
    let Symbol = Prefixed_Name(va, "Symbol") |> PrefixedName
    /// <summary>
    ///   <para>va:VisualChannel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a visual dimension of a chart."</para>
    /// labels<para>"Visual channel"</para></remarks>
    /// <seealso href="http://code-research.eu/ontology/visual-analytics#VisualChannel">http://code-research.eu/ontology/visual-analytics#VisualChannel</seealso>
    let VisualChannel = Prefixed_Name(va, "VisualChannel") |> PrefixedName
    /// <summary>
    ///   <para>va:cubeDimensionNominal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>qb:DimensionProperty</para>
    ///   <para>"This class can be used as a fallback for nominal dimensions. It should be avoided in favor of more specific dimension properties."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Nominal cube dimension"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://code-research.eu/ontology/visual-analytics#cubeDimensionNominal">http://code-research.eu/ontology/visual-analytics#cubeDimensionNominal</seealso>
    let cubeDimensionNominal = Prefixed_Name(va, "cubeDimensionNominal") |> PrefixedName
    /// <summary>
    ///   <para>va:getMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Displays the mappings for a RDF Data Cube."</para>
    /// labels<para>"Get Mapping"</para></remarks>
    /// <seealso href="http://code-research.eu/ontology/visual-analytics#getMapping">http://code-research.eu/ontology/visual-analytics#getMapping</seealso>
    let getMapping = Prefixed_Name(va, "getMapping") |> PrefixedName
    /// <summary>
    ///   <para>va:hasChartName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Represents which name a chart has."</para>
    /// labels<para>"Has chart label"</para></remarks>
    /// <seealso href="http://code-research.eu/ontology/visual-analytics#hasChartName">http://code-research.eu/ontology/visual-analytics#hasChartName</seealso>
    let hasChartName = Prefixed_Name(va, "hasChartName") |> PrefixedName
    /// <summary>
    ///   <para>va:hasComponentMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Displays a particular mapping of a RDF Data Cube."</para>
    /// labels<para>"Has components mapping"</para></remarks>
    /// <seealso href="http://code-research.eu/ontology/visual-analytics#hasComponentMapping">http://code-research.eu/ontology/visual-analytics#hasComponentMapping</seealso>
    let hasComponentMapping = Prefixed_Name(va, "hasComponentMapping") |> PrefixedName
    /// <summary>
    ///   <para>va:hasComponentsMapping</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://code-research.eu/ontology/visual-analytics#hasComponentsMapping">http://code-research.eu/ontology/visual-analytics#hasComponentsMapping</seealso>
    let hasComponentsMapping = Prefixed_Name(va, "hasComponentsMapping") |> PrefixedName
    /// <summary>
    ///   <para>va:hasDataType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Defines which data type a visual channel has."</para>
    /// labels<para>"Has data type"</para></remarks>
    /// <seealso href="http://code-research.eu/ontology/visual-analytics#hasDataType">http://code-research.eu/ontology/visual-analytics#hasDataType</seealso>
    let hasDataType = Prefixed_Name(va, "hasDataType") |> PrefixedName
    /// <summary>
    ///   <para>va:hasOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Denotes whether a visual channel can be set only at one times or multiple times."</para>
    /// labels<para>"Has occurrrence"</para></remarks>
    /// <seealso href="http://code-research.eu/ontology/visual-analytics#hasOccurrence">http://code-research.eu/ontology/visual-analytics#hasOccurrence</seealso>
    let hasOccurrence = Prefixed_Name(va, "hasOccurrence") |> PrefixedName
    /// <summary>
    ///   <para>va:hasPersistence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Denotes which visual channel of a chart must be specified or might be defined if needed."</para>
    /// labels<para>"Has persistence"</para></remarks>
    /// <seealso href="http://code-research.eu/ontology/visual-analytics#hasPersistence">http://code-research.eu/ontology/visual-analytics#hasPersistence</seealso>
    let hasPersistence = Prefixed_Name(va, "hasPersistence") |> PrefixedName
    /// <summary>
    ///   <para>va:hasVisualChannel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Represents which visual channel a chart has."</para>
    /// labels<para>"Has visual channel"</para></remarks>
    /// <seealso href="http://code-research.eu/ontology/visual-analytics#hasVisualChannel">http://code-research.eu/ontology/visual-analytics#hasVisualChannel</seealso>
    let hasVisualChannel = Prefixed_Name(va, "hasVisualChannel") |> PrefixedName
    /// <summary>
    ///   <para>va:representsChart</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://code-research.eu/ontology/visual-analytics#representsChart">http://code-research.eu/ontology/visual-analytics#representsChart</seealso>
    let representsChart = Prefixed_Name(va, "representsChart") |> PrefixedName

    /// <summary>
    ///   <para>va:representsCubeProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Represents the component (dimension,measure) of a RDF Data Cube, which has been mapped."</para>
    /// labels<para>"Represents chart"</para></remarks>
    /// <seealso href="http://code-research.eu/ontology/visual-analytics#representsCubeProperty">http://code-research.eu/ontology/visual-analytics#representsCubeProperty</seealso>
    let representsCubeProperty =
        Prefixed_Name(va, "representsCubeProperty") |> PrefixedName

    /// <summary>
    ///   <para>va:supportedDimension</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://code-research.eu/ontology/visual-analytics#supportedDimension">http://code-research.eu/ontology/visual-analytics#supportedDimension</seealso>
    let supportedDimension = Prefixed_Name(va, "supportedDimension") |> PrefixedName
    /// <summary>
    ///   <para>va:unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Defines the unit measure of a visual channel."</para>
    /// labels<para>"Unit"</para></remarks>
    /// <seealso href="http://code-research.eu/ontology/visual-analytics#unit">http://code-research.eu/ontology/visual-analytics#unit</seealso>
    let unit = Prefixed_Name(va, "unit") |> PrefixedName
    /// <summary>
    ///   <para>va:visualizes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a Visual Analytics Dashboard with a Data Cube or Data Slice"</para>
    /// labels<para>"visualizes"</para></remarks>
    /// <seealso href="http://code-research.eu/ontology/visual-analytics#visualizes">http://code-research.eu/ontology/visual-analytics#visualizes</seealso>
    let visualizes = Prefixed_Name(va, "visualizes") |> PrefixedName

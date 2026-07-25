namespace http.purl.org.linked_data.sdmx.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sdmx =
    let _namespace_iri = Namespace_Iri sdmx |> NamespaceIRI
    /// <summary>
    ///   <para>sdmx:Concept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Denotes an SDMX concept, used in the particular SDMX terminological sense, which is in principle narrower than skos:Concept</para>
    /// labels<para>concept</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx#Concept">http://purl.org/linked-data/sdmx#Concept</seealso>
    let Concept = Prefixed_Name(sdmx, "Concept") |> PrefixedName
    /// <summary>
    ///   <para>sdmx:CountRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>concept for a dimension or attribute that plays the role of an identifier where the identifier is taken from a known system of counts (e.g. the Nth current dataset update for a given day)</para>
    /// labels<para>Count property</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx#CountRole">http://purl.org/linked-data/sdmx#CountRole</seealso>
    let CountRole = Prefixed_Name(sdmx, "CountRole") |> PrefixedName
    /// <summary>
    ///   <para>sdmx:CodeList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Concept scheme</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx#CodeList">http://purl.org/linked-data/sdmx#CodeList</seealso>
    let CodeList = Prefixed_Name(sdmx, "CodeList") |> PrefixedName
    /// <summary>
    ///   <para>sdmx:EntityRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>concept for a dimension or attribute that plays the role of the DataAttribute subject to whom the data refers (e.g. the reporting agent for primary reporting, the country for secondary reporting)</para>
    /// labels<para>Entity property</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx#EntityRole">http://purl.org/linked-data/sdmx#EntityRole</seealso>
    let EntityRole = Prefixed_Name(sdmx, "EntityRole") |> PrefixedName
    /// <summary>
    ///   <para>sdmx:FrequencyRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>concept for a dimension or attribute that plays the role of frequency</para>
    /// labels<para>Frequency property</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx#FrequencyRole">http://purl.org/linked-data/sdmx#FrequencyRole</seealso>
    let FrequencyRole = Prefixed_Name(sdmx, "FrequencyRole") |> PrefixedName
    /// <summary>
    ///   <para>sdmx:IdentityRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>concept for a dimension or attribute that plays the role of an identifier which is taken from a known scheme of identifiers.</para>
    /// labels<para>Identity property</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx#IdentityRole">http://purl.org/linked-data/sdmx#IdentityRole</seealso>
    let IdentityRole = Prefixed_Name(sdmx, "IdentityRole") |> PrefixedName
    /// <summary>
    ///   <para>sdmx:PrimaryMeasureRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>concept for a measure that plays the role of the observation in a time series</para>
    /// labels<para>Primary measure property</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx#PrimaryMeasureRole">http://purl.org/linked-data/sdmx#PrimaryMeasureRole</seealso>
    let PrimaryMeasureRole = Prefixed_Name(sdmx, "PrimaryMeasureRole") |> PrefixedName
    /// <summary>
    ///   <para>sdmx:ConceptRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Abstract superclass of classes denoting statistical roles which be played by concepts</para>
    /// labels<para>Concept role (abstract)</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx#ConceptRole">http://purl.org/linked-data/sdmx#ConceptRole</seealso>
    let ConceptRole = Prefixed_Name(sdmx, "ConceptRole") |> PrefixedName

    /// <summary>
    ///   <para>sdmx:DataStructureDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A specialization of qb:DataStructureDefinition which additional constraints: if there are multiple measures then a MeasureDimensionProperty must be included in the DSD</para>
    /// labels<para>Data Structure Definition</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx#DataStructureDefinition">http://purl.org/linked-data/sdmx#DataStructureDefinition</seealso>
    let DataStructureDefinition =
        Prefixed_Name(sdmx, "DataStructureDefinition") |> PrefixedName

    /// <summary>
    ///   <para>sdmx:NonObsTimeRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>concept for a dimension or attribute that plays the role of a date/time identifier in the KeyFamily which is not related to the time of the observation</para>
    /// labels<para>Non-observation time property</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx#NonObsTimeRole">http://purl.org/linked-data/sdmx#NonObsTimeRole</seealso>
    let NonObsTimeRole = Prefixed_Name(sdmx, "NonObsTimeRole") |> PrefixedName
    /// <summary>
    ///   <para>sdmx:MeasureTypeRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>concept for a dimension that plays the role of identifying a type of measure</para>
    /// labels<para>Measure type property</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx#MeasureTypeRole">http://purl.org/linked-data/sdmx#MeasureTypeRole</seealso>
    let MeasureTypeRole = Prefixed_Name(sdmx, "MeasureTypeRole") |> PrefixedName
    /// <summary>
    ///   <para>sdmx:TimeRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>concept for a dimension that specifies the time of the observation of the primaryMeasure</para>
    /// labels<para>Time property</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx#TimeRole">http://purl.org/linked-data/sdmx#TimeRole</seealso>
    let TimeRole = Prefixed_Name(sdmx, "TimeRole") |> PrefixedName
    /// <summary>
    ///   <para>sdmx:primaryMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates an additional component used as the primary measure within the SDMX data. In the case of multi-measure data sets the RDF representation uses the specific measure rather than a subsuming overall measure. This property records the subsuming primary measure (typically sdmx-measure:obsValue) to enable round tripping of this information.</para>
    /// labels<para>primary measure</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx#primaryMeasure">http://purl.org/linked-data/sdmx#primaryMeasure</seealso>
    let primaryMeasure = Prefixed_Name(sdmx, "primaryMeasure") |> PrefixedName
    /// <summary>
    ///   <para>sdmx:measureTypeConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx:ConceptRole</para>
    ///   <para>sdmx:MeasureTypeRole</para>
    ///   <para>skos:Concept</para>
    ///   <para>The concept corresponding to the generic measure type dimension which indicates which measure is being denoted by the primary measure on an observation</para>
    /// labels<para>measureType</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx#measureTypeConcept">http://purl.org/linked-data/sdmx#measureTypeConcept</seealso>
    let measureTypeConcept = Prefixed_Name(sdmx, "measureTypeConcept") |> PrefixedName

#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module sdmx =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/linked-data/sdmx#" "sdmx"

    /// <summary>
    ///   <para>rdfs:label : Concept scheme</para>
    ///   <a href="http://purl.org/linked-data/sdmx#CodeList">sdmx:CodeList</a>
    /// </summary>
    let CodeList = _prefixId.prefix "CodeList"
    /// <summary>
    ///   <para>rdfs:comment : Denotes an SDMX concept, used in the particular SDMX terminological sense, which is in principle narrower than skos:Concept^^xsd:string</para>
    ///   <para>rdfs:label : concept</para>
    ///   <a href="http://purl.org/linked-data/sdmx#Concept">sdmx:Concept</a>
    /// </summary>
    let Concept = _prefixId.prefix "Concept"
    /// <summary>
    ///   <para>rdfs:comment : Abstract superclass of classes denoting statistical roles which be played by concepts</para>
    ///   <para>rdfs:label : Concept role (abstract)</para>
    ///   <a href="http://purl.org/linked-data/sdmx#ConceptRole">sdmx:ConceptRole</a>
    /// </summary>
    let ConceptRole = _prefixId.prefix "ConceptRole"
    /// <summary>
    ///   <para>rdfs:comment : concept for a dimension or attribute that plays the role of an identifier where the identifier is taken from a known system of counts (e.g. the Nth current dataset update for a given day)</para>
    ///   <para>rdfs:label : Count property</para>
    ///   <a href="http://purl.org/linked-data/sdmx#CountRole">sdmx:CountRole</a>
    /// </summary>
    let CountRole = _prefixId.prefix "CountRole"
    /// <summary>
    ///   <para>rdfs:comment : A specialization of qb:DataStructureDefinition which additional constraints: if there are multiple measures then a MeasureDimensionProperty must be included in the DSD</para>
    ///   <para>rdfs:label : Data Structure Definition</para>
    ///   <a href="http://purl.org/linked-data/sdmx#DataStructureDefinition">sdmx:DataStructureDefinition</a>
    /// </summary>
    let DataStructureDefinition = _prefixId.prefix "DataStructureDefinition"
    /// <summary>
    ///   <para>rdfs:comment : concept for a dimension or attribute that plays the role of the DataAttribute subject to whom the data refers (e.g. the reporting agent for primary reporting, the country for secondary reporting)</para>
    ///   <para>rdfs:label : Entity property</para>
    ///   <a href="http://purl.org/linked-data/sdmx#EntityRole">sdmx:EntityRole</a>
    /// </summary>
    let EntityRole = _prefixId.prefix "EntityRole"
    /// <summary>
    ///   <para>rdfs:comment : concept for a dimension or attribute that plays the role of frequency</para>
    ///   <para>rdfs:label : Frequency property</para>
    ///   <a href="http://purl.org/linked-data/sdmx#FrequencyRole">sdmx:FrequencyRole</a>
    /// </summary>
    let FrequencyRole = _prefixId.prefix "FrequencyRole"
    /// <summary>
    ///   <para>rdfs:comment : concept for a dimension or attribute that plays the role of an identifier which is taken from a known scheme of identifiers.</para>
    ///   <para>rdfs:label : Identity property</para>
    ///   <a href="http://purl.org/linked-data/sdmx#IdentityRole">sdmx:IdentityRole</a>
    /// </summary>
    let IdentityRole = _prefixId.prefix "IdentityRole"
    /// <summary>
    ///   <para>rdfs:comment : concept for a dimension that plays the role of identifying a type of measure</para>
    ///   <para>rdfs:label : Measure type property</para>
    ///   <a href="http://purl.org/linked-data/sdmx#MeasureTypeRole">sdmx:MeasureTypeRole</a>
    /// </summary>
    let MeasureTypeRole = _prefixId.prefix "MeasureTypeRole"
    /// <summary>
    ///   <para>rdfs:comment : concept for a dimension or attribute that plays the role of a date/time identifier in the KeyFamily which is not related to the time of the observation</para>
    ///   <para>rdfs:label : Non-observation time property</para>
    ///   <a href="http://purl.org/linked-data/sdmx#NonObsTimeRole">sdmx:NonObsTimeRole</a>
    /// </summary>
    let NonObsTimeRole = _prefixId.prefix "NonObsTimeRole"
    /// <summary>
    ///   <para>rdfs:comment : concept for a measure that plays the role of the observation in a time series</para>
    ///   <para>rdfs:label : Primary measure property</para>
    ///   <a href="http://purl.org/linked-data/sdmx#PrimaryMeasureRole">sdmx:PrimaryMeasureRole</a>
    /// </summary>
    let PrimaryMeasureRole = _prefixId.prefix "PrimaryMeasureRole"
    /// <summary>
    ///   <para>rdfs:comment : concept for a dimension that specifies the time of the observation of the primaryMeasure</para>
    ///   <para>rdfs:label : Time property</para>
    ///   <a href="http://purl.org/linked-data/sdmx#TimeRole">sdmx:TimeRole</a>
    /// </summary>
    let TimeRole = _prefixId.prefix "TimeRole"
    let measureTypeConcept = _prefixId.prefix "measureTypeConcept"
    /// <summary>
    ///   <para>rdfs:comment : Indicates an additional component used as the primary measure within the SDMX data. In the case of multi-measure data sets the RDF representation uses the specific measure rather than a subsuming overall measure. This property records the subsuming primary measure (typically sdmx-measure:obsValue) to enable round tripping of this information.</para>
    ///   <para>rdfs:label : primary measure</para>
    ///   <a href="http://purl.org/linked-data/sdmx#primaryMeasure">sdmx:primaryMeasure</a>
    /// </summary>
    let primaryMeasure = _prefixId.prefix "primaryMeasure"

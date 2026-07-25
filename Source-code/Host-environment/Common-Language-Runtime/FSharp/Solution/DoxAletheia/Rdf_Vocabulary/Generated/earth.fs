namespace http.linked.earth.ontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module earth =
    let _namespace_iri = Namespace_Iri earth |> NamespaceIRI
    /// <summary>
    ///   <para>earth:Archive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The medium in which the response of a sensor to environmental forcing is recorded (e.g., marine sediments, ice core, lake sediments, speleothems). Sensu Evans et al. (2013)</para>
    /// labels<para>Archive</para></remarks>
    /// <seealso href="http://linked.earth/ontology#Archive">http://linked.earth/ontology#Archive</seealso>
    let Archive = Prefixed_Name(earth, "Archive") |> PrefixedName
    /// <summary>
    ///   <para>earth:DistributionTable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Table that contains the probability on the inferred variables</para>
    /// labels<para>DistributionTable</para></remarks>
    /// <seealso href="http://linked.earth/ontology#DistributionTable">http://linked.earth/ontology#DistributionTable</seealso>
    let DistributionTable = Prefixed_Name(earth, "DistributionTable") |> PrefixedName
    /// <summary>
    ///   <para>earth:hasDOI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>As Digital Object Identifier for a given resource. For example: "oi:10.1191/095968301673881493"</para>
    /// labels<para>hasDOI</para></remarks>
    /// <seealso href="http://linked.earth/ontology#hasDOI">http://linked.earth/ontology#hasDOI</seealso>
    let hasDOI = Prefixed_Name(earth, "hasDOI") |> PrefixedName
    /// <summary>
    ///   <para>earth:Model</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any system that is at least partially isomorphic to some target system and used to derive information about the structure and/or dynamics of the target system.</para>
    /// labels<para>Model</para></remarks>
    /// <seealso href="http://linked.earth/ontology#Model">http://linked.earth/ontology#Model</seealso>
    let Model = Prefixed_Name(earth, "Model") |> PrefixedName
    /// <summary>
    ///   <para>earth:ChronData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Data pertaining to chronological information</para>
    /// labels<para>CrhonData</para></remarks>
    /// <seealso href="http://linked.earth/ontology#ChronData">http://linked.earth/ontology#ChronData</seealso>
    let ChronData = Prefixed_Name(earth, "ChronData") |> PrefixedName
    /// <summary>
    ///   <para>earth:DataTable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A set of Variables organized in columns</para>
    /// labels<para>DataTable</para></remarks>
    /// <seealso href="http://linked.earth/ontology#DataTable">http://linked.earth/ontology#DataTable</seealso>
    let DataTable = Prefixed_Name(earth, "DataTable") |> PrefixedName

    /// <summary>
    ///   <para>earth:ClimateInterpretation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A suite of metadata that describe how a variable is interpreted to reflect past environmental variability</para>
    /// labels<para>ClimateInterpretation</para></remarks>
    /// <seealso href="http://linked.earth/ontology#ClimateInterpretation">http://linked.earth/ontology#ClimateInterpretation</seealso>
    let ClimateInterpretation =
        Prefixed_Name(earth, "ClimateInterpretation") |> PrefixedName

    /// <summary>
    ///   <para>earth:citation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Sentence indicating how a paper should be published</para>
    /// labels<para>citation</para></remarks>
    /// <seealso href="http://linked.earth/ontology#citation">http://linked.earth/ontology#citation</seealso>
    let citation = Prefixed_Name(earth, "citation") |> PrefixedName
    /// <summary>
    ///   <para>earth:datasetDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date when the dataset was published. </para>
    /// labels<para>datasetDate</para></remarks>
    /// <seealso href="http://linked.earth/ontology#datasetDate">http://linked.earth/ontology#datasetDate</seealso>
    let datasetDate = Prefixed_Name(earth, "datasetDate") |> PrefixedName
    /// <summary>
    ///   <para>earth:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The description of a resource. This property may be used to provide further details on instrument descriptions, uncertainty description,etc.</para>
    /// labels<para>description</para></remarks>
    /// <seealso href="http://linked.earth/ontology#description">http://linked.earth/ontology#description</seealso>
    let description = Prefixed_Name(earth, "description") |> PrefixedName
    /// <summary>
    ///   <para>earth:email</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>email of an author or contributor</para>
    /// labels<para>email</para></remarks>
    /// <seealso href="http://linked.earth/ontology#email">http://linked.earth/ontology#email</seealso>
    let email = Prefixed_Name(earth, "email") |> PrefixedName
    /// <summary>
    ///   <para>earth:foundInTable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that indicated the table where the described data can be found</para>
    /// labels<para>foundInTable</para></remarks>
    /// <seealso href="http://linked.earth/ontology#foundInTable">http://linked.earth/ontology#foundInTable</seealso>
    let foundInTable = Prefixed_Name(earth, "foundInTable") |> PrefixedName

    /// <summary>
    ///   <para>earth:foundInEnsembleTable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that indicates that the data or variable described was found in an ensemble table</para>
    /// labels<para>foundInEnsembleTable</para></remarks>
    /// <seealso href="http://linked.earth/ontology#foundInEnsembleTable">http://linked.earth/ontology#foundInEnsembleTable</seealso>
    let foundInEnsembleTable =
        Prefixed_Name(earth, "foundInEnsembleTable") |> PrefixedName

    /// <summary>
    ///   <para>earth:foundInSummaryTable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Property that indicates that the describer data or variable was found in a summary table</para>
    /// labels<para>foundInSummaryTable</para></remarks>
    /// <seealso href="http://linked.earth/ontology#foundInSummaryTable">http://linked.earth/ontology#foundInSummaryTable</seealso>
    let foundInSummaryTable =
        Prefixed_Name(earth, "foundInSummaryTable") |> PrefixedName

    /// <summary>
    ///   <para>earth:fundedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that indicated the funding which made the dataset possible</para>
    /// labels<para>fundedBy</para></remarks>
    /// <seealso href="http://linked.earth/ontology#fundedBy">http://linked.earth/ontology#fundedBy</seealso>
    let fundedBy = Prefixed_Name(earth, "fundedBy") |> PrefixedName
    /// <summary>
    ///   <para>earth:fundingAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The agency that funded the development of the Dataset</para>
    /// labels<para>fundingAgency</para></remarks>
    /// <seealso href="http://linked.earth/ontology#fundingAgency">http://linked.earth/ontology#fundingAgency</seealso>
    let fundingAgency = Prefixed_Name(earth, "fundingAgency") |> PrefixedName
    /// <summary>
    ///   <para>earth:grantNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The grant number associated with the development of the Dataset?</para>
    /// labels<para>grantNumber</para></remarks>
    /// <seealso href="http://linked.earth/ontology#grantNumber">http://linked.earth/ontology#grantNumber</seealso>
    let grantNumber = Prefixed_Name(earth, "grantNumber") |> PrefixedName
    /// <summary>
    ///   <para>earth:hasCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>What is the mathematical formulation that describes the Model?</para>
    /// labels<para>hasCode</para></remarks>
    /// <seealso href="http://linked.earth/ontology#hasCode">http://linked.earth/ontology#hasCode</seealso>
    let hasCode = Prefixed_Name(earth, "hasCode") |> PrefixedName

    /// <summary>
    ///   <para>earth:hasExecutionCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The execution command needed to run the script or software</para>
    /// labels<para>hasExecutionCommand</para></remarks>
    /// <seealso href="http://linked.earth/ontology#hasExecutionCommand">http://linked.earth/ontology#hasExecutionCommand</seealso>
    let hasExecutionCommand =
        Prefixed_Name(earth, "hasExecutionCommand") |> PrefixedName

    /// <summary>
    ///   <para>earth:hasExecutionEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Execution environment of the code</para>
    /// labels<para>hasExecutionEnvironment</para></remarks>
    /// <seealso href="http://linked.earth/ontology#hasExecutionEnvironment">http://linked.earth/ontology#hasExecutionEnvironment</seealso>
    let hasExecutionEnvironment =
        Prefixed_Name(earth, "hasExecutionEnvironment") |> PrefixedName

    /// <summary>
    ///   <para>earth:hasID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>ID for a variable in a table</para>
    /// labels<para>hasID</para></remarks>
    /// <seealso href="http://linked.earth/ontology#hasID">http://linked.earth/ontology#hasID</seealso>
    let hasID = Prefixed_Name(earth, "hasID") |> PrefixedName
    /// <summary>
    ///   <para>earth:hasISBN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Identifier used commonly to refer to publications.</para>
    /// labels<para>hasISBN</para></remarks>
    /// <seealso href="http://linked.earth/ontology#hasISBN">http://linked.earth/ontology#hasISBN</seealso>
    let hasISBN = Prefixed_Name(earth, "hasISBN") |> PrefixedName
    /// <summary>
    ///   <para>earth:hasISSN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>8-digit code used to udentify publications</para>
    /// labels<para>hasISSN</para></remarks>
    /// <seealso href="http://linked.earth/ontology#hasISSN">http://linked.earth/ontology#hasISSN</seealso>
    let hasISSN = Prefixed_Name(earth, "hasISSN") |> PrefixedName
    /// <summary>
    ///   <para>earth:hasMissingValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates how the missing values are flagged in a dataset</para>
    /// labels<para>hasMissingValue</para></remarks>
    /// <seealso href="http://linked.earth/ontology#hasMissingValue">http://linked.earth/ontology#hasMissingValue</seealso>
    let hasMissingValue = Prefixed_Name(earth, "hasMissingValue") |> PrefixedName
    /// <summary>
    ///   <para>earth:ArchiveModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A simplified description of how the sensor either creates or emplaces the signal into the archive. sensu Evans et al. 2013.</para>
    /// labels<para>ArchiveModel</para></remarks>
    /// <seealso href="http://linked.earth/ontology#ArchiveModel">http://linked.earth/ontology#ArchiveModel</seealso>
    let ArchiveModel = Prefixed_Name(earth, "ArchiveModel") |> PrefixedName
    /// <summary>
    ///   <para>earth:ChronDataTable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>DataTable containing the Chronology Variables</para>
    /// labels<para>ChronDataTable</para></remarks>
    /// <seealso href="http://linked.earth/ontology#ChronDataTable">http://linked.earth/ontology#ChronDataTable</seealso>
    let ChronDataTable = Prefixed_Name(earth, "ChronDataTable") |> PrefixedName
    /// <summary>
    ///   <para>earth:Proxy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>a measured variable used to infer the value of a variable of interest</para>
    /// labels<para>Proxy</para></remarks>
    /// <seealso href="http://linked.earth/ontology#Proxy">http://linked.earth/ontology#Proxy</seealso>
    let Proxy = Prefixed_Name(earth, "Proxy") |> PrefixedName
    /// <summary>
    ///   <para>earth:ChronModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Model used to obtain the chronology</para>
    /// labels<para>ChronModel</para></remarks>
    /// <seealso href="http://linked.earth/ontology#ChronModel">http://linked.earth/ontology#ChronModel</seealso>
    let ChronModel = Prefixed_Name(earth, "ChronModel") |> PrefixedName
    /// <summary>
    ///   <para>earth:EnsembleTable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Table containing possible series of age models or proxy variability</para>
    /// labels<para>EnsembleTable</para></remarks>
    /// <seealso href="http://linked.earth/ontology#EnsembleTable">http://linked.earth/ontology#EnsembleTable</seealso>
    let EnsembleTable = Prefixed_Name(earth, "EnsembleTable") |> PrefixedName
    /// <summary>
    ///   <para>earth:hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A column of values for the variable. The literal can be in the form of a vector of values (for instance d18O PaleoObservations),  a vector of strings (for instance different paleoArchiveNames),  a matrix or both</para>
    /// labels<para>hasValue</para></remarks>
    /// <seealso href="http://linked.earth/ontology#hasValue">http://linked.earth/ontology#hasValue</seealso>
    let hasValue = Prefixed_Name(earth, "hasValue") |> PrefixedName
    /// <summary>
    ///   <para>earth:hasPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>What are the components of the ProxySystemModel?</para>
    /// labels<para>hasPart</para></remarks>
    /// <seealso href="http://linked.earth/ontology#hasPart">http://linked.earth/ontology#hasPart</seealso>
    let hasPart = Prefixed_Name(earth, "hasPart") |> PrefixedName
    /// <summary>
    ///   <para>earth:hasUnits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>units in which a resource is measured The resource can be a Variable, an Observation, a Resolution, or an Uncertainty</para>
    /// labels<para>hasUnits</para></remarks>
    /// <seealso href="http://linked.earth/ontology#hasUnits">http://linked.earth/ontology#hasUnits</seealso>
    let hasUnits = Prefixed_Name(earth, "hasUnits") |> PrefixedName
    /// <summary>
    ///   <para>earth:PaleoDataTable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>DataTable containig PaleoData Variables</para>
    /// labels<para>PaleoDataTable</para></remarks>
    /// <seealso href="http://linked.earth/ontology#PaleoDataTable">http://linked.earth/ontology#PaleoDataTable</seealso>
    let PaleoDataTable = Prefixed_Name(earth, "PaleoDataTable") |> PrefixedName
    /// <summary>
    ///   <para>earth:Instrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A tool or implement used to produce MeasuredVariables</para>
    /// labels<para>Instrument</para></remarks>
    /// <seealso href="http://linked.earth/ontology#Instrument">http://linked.earth/ontology#Instrument</seealso>
    let Instrument = Prefixed_Name(earth, "Instrument") |> PrefixedName
    /// <summary>
    ///   <para>earth:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The geographic data and metadata for the dataset</para>
    /// labels<para>Location</para></remarks>
    /// <seealso href="http://linked.earth/ontology#Location">http://linked.earth/ontology#Location</seealso>
    let Location = Prefixed_Name(earth, "Location") |> PrefixedName
    /// <summary>
    ///   <para>earth:ClimateProxy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Climate observations prior to the instrumental era are necessarily indirect. These observations are made on climate proxies in various geological (e.g. lake or marine sediments, living or fossil coral reefs, cave deposits), glaciological (ice cores or snow pits) or biological (trees) archives. Many types of measurements can be made on each archives, each sensing a different aspect of the environment (sometimes, several aspects at once). A paleoclimate dataset is a set of observations made on an archive.</para>
    /// labels<para>ClimateProxy</para></remarks>
    /// <seealso href="http://linked.earth/ontology#ClimateProxy">http://linked.earth/ontology#ClimateProxy</seealso>
    let ClimateProxy = Prefixed_Name(earth, "ClimateProxy") |> PrefixedName
    /// <summary>
    ///   <para>earth:Dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A structured collection of related information, including - but not limited to - geographical, chronological, and measured or modeled paleoenvironmental data</para>
    /// labels<para>Dataset</para></remarks>
    /// <seealso href="http://linked.earth/ontology#Dataset">http://linked.earth/ontology#Dataset</seealso>
    let Dataset = Prefixed_Name(earth, "Dataset") |> PrefixedName
    /// <summary>
    ///   <para>earth:Funding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A source of funding for the creation of the Dataset</para>
    /// labels<para>Funding</para></remarks>
    /// <seealso href="http://linked.earth/ontology#Funding">http://linked.earth/ontology#Funding</seealso>
    let Funding = Prefixed_Name(earth, "Funding") |> PrefixedName
    /// <summary>
    ///   <para>earth:PaleoModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Model describing how the measuredVariables are transformed into inferredVariables</para>
    /// labels<para>PaleoModel</para></remarks>
    /// <seealso href="http://linked.earth/ontology#PaleoModel">http://linked.earth/ontology#PaleoModel</seealso>
    let PaleoModel = Prefixed_Name(earth, "PaleoModel") |> PrefixedName
    /// <summary>
    ///   <para>earth:ProxySystemModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>In the Evans et al. (2013) framework, this is the combination of sensor, archive and observation models . "A generalized proxy system model encapuslates a simplified representation of prior physical, chemical, biological, and/or geological understanding of the ways in which environmental variation ultimately results in the observations used to retrieve paleoclimatic information."</para>
    /// labels<para>ProxySystemModel</para></remarks>
    /// <seealso href="http://linked.earth/ontology#ProxySystemModel">http://linked.earth/ontology#ProxySystemModel</seealso>
    let ProxySystemModel = Prefixed_Name(earth, "ProxySystemModel") |> PrefixedName
    /// <summary>
    ///   <para>earth:SoftwareCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A script that describes the model, in any programming language (e.g., Excel, Matlab, Python, R)</para>
    /// labels<para>SoftwareCode</para></remarks>
    /// <seealso href="http://linked.earth/ontology#SoftwareCode">http://linked.earth/ontology#SoftwareCode</seealso>
    let SoftwareCode = Prefixed_Name(earth, "SoftwareCode") |> PrefixedName
    /// <summary>
    ///   <para>earth:UncertaintyModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A formalization of the way the uncertainty is accounted for</para>
    /// labels<para>UndertaintyModel</para></remarks>
    /// <seealso href="http://linked.earth/ontology#UncertaintyModel">http://linked.earth/ontology#UncertaintyModel</seealso>
    let UncertaintyModel = Prefixed_Name(earth, "UncertaintyModel") |> PrefixedName
    /// <summary>
    ///   <para>earth:InferredVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Is the variable inferred from a measured variable?</para>
    /// labels<para>InferredVariable</para></remarks>
    /// <seealso href="http://linked.earth/ontology#InferredVariable">http://linked.earth/ontology#InferredVariable</seealso>
    let InferredVariable = Prefixed_Name(earth, "InferredVariable") |> PrefixedName
    /// <summary>
    ///   <para>earth:MeasuredVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Is the variable measured with an instrument?</para>
    /// labels<para>MeasuredVariable</para></remarks>
    /// <seealso href="http://linked.earth/ontology#MeasuredVariable">http://linked.earth/ontology#MeasuredVariable</seealso>
    let MeasuredVariable = Prefixed_Name(earth, "MeasuredVariable") |> PrefixedName
    /// <summary>
    ///   <para>earth:method</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Method used to obtain the information from the resource</para>
    /// labels<para>method</para></remarks>
    /// <seealso href="http://linked.earth/ontology#method">http://linked.earth/ontology#method</seealso>
    let method = Prefixed_Name(earth, "method") |> PrefixedName
    /// <summary>
    ///   <para>earth:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Name of the described resource</para>
    /// labels<para>name</para></remarks>
    /// <seealso href="http://linked.earth/ontology#name">http://linked.earth/ontology#name</seealso>
    let name = Prefixed_Name(earth, "name") |> PrefixedName
    /// <summary>
    ///   <para>earth:orcidNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The ORCID number of the Person</para>
    /// labels<para>orcidNumber</para></remarks>
    /// <seealso href="http://linked.earth/ontology#orcidNumber">http://linked.earth/ontology#orcidNumber</seealso>
    let orcidNumber = Prefixed_Name(earth, "orcidNumber") |> PrefixedName

    /// <summary>
    ///   <para>earth:principalInvestigator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Who is the PrincipalInvestigator of the Funding grant?</para>
    /// labels<para>principalInvestigator</para></remarks>
    /// <seealso href="http://linked.earth/ontology#principalInvestigator">http://linked.earth/ontology#principalInvestigator</seealso>
    let principalInvestigator =
        Prefixed_Name(earth, "principalInvestigator") |> PrefixedName

    /// <summary>
    ///   <para>earth:seasonality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>fluctuating or restricted according to the season or time of year</para>
    /// labels<para>seasonality</para></remarks>
    /// <seealso href="http://linked.earth/ontology#seasonality">http://linked.earth/ontology#seasonality</seealso>
    let seasonality = Prefixed_Name(earth, "seasonality") |> PrefixedName
    /// <summary>
    ///   <para>earth:volume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The volume number in which the publication appeared.</para>
    /// labels<para>volume</para></remarks>
    /// <seealso href="http://linked.earth/ontology#volume">http://linked.earth/ontology#volume</seealso>
    let volume = Prefixed_Name(earth, "volume") |> PrefixedName
    /// <summary>
    ///   <para>earth:includesVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>What are the Variables included in the DataTable?</para>
    /// labels<para>includesVariable</para></remarks>
    /// <seealso href="http://linked.earth/ontology#includesVariable">http://linked.earth/ontology#includesVariable</seealso>
    let includesVariable = Prefixed_Name(earth, "includesVariable") |> PrefixedName

    /// <summary>
    ///   <para>earth:interpretationReferences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the basis by which the proxy variable is interpreted in terms of climate. </para>
    /// labels<para>interpretationReferences</para></remarks>
    /// <seealso href="http://linked.earth/ontology#interpretationReferences">http://linked.earth/ontology#interpretationReferences</seealso>
    let interpretationReferences =
        Prefixed_Name(earth, "interpretationReferences") |> PrefixedName

    /// <summary>
    ///   <para>earth:journal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Property that indicated the journal in which the publication has been published</para>
    /// labels<para>journal</para></remarks>
    /// <seealso href="http://linked.earth/ontology#journal">http://linked.earth/ontology#journal</seealso>
    let journal = Prefixed_Name(earth, "journal") |> PrefixedName
    /// <summary>
    ///   <para>earth:Variable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Quantities which can be measured or inferred independently in an experiment</para>
    /// labels<para>Variable</para></remarks>
    /// <seealso href="http://linked.earth/ontology#Variable">http://linked.earth/ontology#Variable</seealso>
    let Variable = Prefixed_Name(earth, "Variable") |> PrefixedName
    /// <summary>
    ///   <para>earth:InorganicSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An inorganic senso like.karst system, catchment basin, etc.</para>
    /// labels<para>InorganicSensor</para></remarks>
    /// <seealso href="http://linked.earth/ontology#InorganicSensor">http://linked.earth/ontology#InorganicSensor</seealso>
    let InorganicSensor = Prefixed_Name(earth, "InorganicSensor") |> PrefixedName
    /// <summary>
    ///   <para>earth:Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The sensor comprises physical, chemical and/or biological components that react to environmental conditions (e.g, foraminifera, coral polyps, cave, catchment basin). sensu Evans et al. (2013)</para>
    /// labels<para>Sensor</para></remarks>
    /// <seealso href="http://linked.earth/ontology#Sensor">http://linked.earth/ontology#Sensor</seealso>
    let Sensor = Prefixed_Name(earth, "Sensor") |> PrefixedName
    /// <summary>
    ///   <para>earth:IntegrationTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The integration time of the Archive or the Sensor</para>
    /// labels<para>IntegrationTime</para></remarks>
    /// <seealso href="http://linked.earth/ontology#IntegrationTime">http://linked.earth/ontology#IntegrationTime</seealso>
    let IntegrationTime = Prefixed_Name(earth, "IntegrationTime") |> PrefixedName
    /// <summary>
    ///   <para>earth:SensorModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A formalization of the behavior of the sensor in response to environmental forcing. Sensu Evans et al. 2013.</para>
    /// labels<para>SensorModel</para></remarks>
    /// <seealso href="http://linked.earth/ontology#SensorModel">http://linked.earth/ontology#SensorModel</seealso>
    let SensorModel = Prefixed_Name(earth, "SensorModel") |> PrefixedName
    /// <summary>
    ///   <para>earth:warnings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Warnings of the variable or dataset being annotated</para>
    /// labels<para>warnings</para></remarks>
    /// <seealso href="http://linked.earth/ontology#warnings">http://linked.earth/ontology#warnings</seealso>
    let warnings = Prefixed_Name(earth, "warnings") |> PrefixedName
    /// <summary>
    ///   <para>earth:OrganicSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An organic sensor (e.g., foraminifera, tree, corals...)</para>
    /// labels<para>OrganicSensor</para></remarks>
    /// <seealso href="http://linked.earth/ontology#OrganicSensor">http://linked.earth/ontology#OrganicSensor</seealso>
    let OrganicSensor = Prefixed_Name(earth, "OrganicSensor") |> PrefixedName

    /// <summary>
    ///   <para>earth:IsotopeInterpretation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A suite of metadata that describe how a MeasuredVariable with instance Isotope is interpreted to reflect past variability, including environmental variability</para>
    /// labels<para>IsotopeInterpretation</para></remarks>
    /// <seealso href="http://linked.earth/ontology#IsotopeInterpretation">http://linked.earth/ontology#IsotopeInterpretation</seealso>
    let IsotopeInterpretation =
        Prefixed_Name(earth, "IsotopeInterpretation") |> PrefixedName

    /// <summary>
    ///   <para>earth:MeasurementTable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Table that contains the measuredVariables made on the Archive</para>
    /// labels<para>MeasurementTable</para></remarks>
    /// <seealso href="http://linked.earth/ontology#MeasurementTable">http://linked.earth/ontology#MeasurementTable</seealso>
    let MeasurementTable = Prefixed_Name(earth, "MeasurementTable") |> PrefixedName

    /// <summary>
    ///   <para>earth:NonPeerReviewedPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A publication that has not undergone a formal review process; for instance, a Dataset attached to a dissertation.</para>
    /// labels<para>NonPeerReviewedPublication</para></remarks>
    /// <seealso href="http://linked.earth/ontology#NonPeerReviewedPublication">http://linked.earth/ontology#NonPeerReviewedPublication</seealso>
    let NonPeerReviewedPublication =
        Prefixed_Name(earth, "NonPeerReviewedPublication") |> PrefixedName

    /// <summary>
    ///   <para>earth:PeerReviewedPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A publication that has undergone a formal peer-reviewed process.</para>
    /// labels<para>PeerReviewedPublication</para></remarks>
    /// <seealso href="http://linked.earth/ontology#PeerReviewedPublication">http://linked.earth/ontology#PeerReviewedPublication</seealso>
    let PeerReviewedPublication =
        Prefixed_Name(earth, "PeerReviewedPublication") |> PrefixedName

    /// <summary>
    ///   <para>earth:Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The measurements made on the archives, whether chemical (e.g., Mg/Ca, d18O, TEX86, Sr/Ca....), physical (e.g. density, layer thickness) or biological (e.g. species abundance). Evans et al. (2013). Observations are MeasuredVariables</para>
    /// labels<para>Observation</para></remarks>
    /// <seealso href="http://linked.earth/ontology#Observation">http://linked.earth/ontology#Observation</seealso>
    let Observation = Prefixed_Name(earth, "Observation") |> PrefixedName
    /// <summary>
    ///   <para>earth:publicationYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Year when the publication was published. The literal is a numeric value in the format yyyy</para>
    /// labels<para>publicationYear</para></remarks>
    /// <seealso href="http://linked.earth/ontology#publicationYear">http://linked.earth/ontology#publicationYear</seealso>
    let publicationYear = Prefixed_Name(earth, "publicationYear") |> PrefixedName
    /// <summary>
    ///   <para>earth:Publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A document that serves as reference for a Dataset or its components</para>
    /// labels<para>Publication</para></remarks>
    /// <seealso href="http://linked.earth/ontology#Publication">http://linked.earth/ontology#Publication</seealso>
    let Publication = Prefixed_Name(earth, "Publication") |> PrefixedName
    /// <summary>
    ///   <para>earth:PaleoData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Data pertaining to past environmental variability</para>
    /// labels<para>PaleoData</para></remarks>
    /// <seealso href="http://linked.earth/ontology#PaleoData">http://linked.earth/ontology#PaleoData</seealso>
    let PaleoData = Prefixed_Name(earth, "PaleoData") |> PrefixedName
    /// <summary>
    ///   <para>earth:ObservationModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The simplified representation of the way in which observations are made on the archive. sensu Evans et al. 2013.</para>
    /// labels<para>ObservationModel</para></remarks>
    /// <seealso href="http://linked.earth/ontology#ObservationModel">http://linked.earth/ontology#ObservationModel</seealso>
    let ObservationModel = Prefixed_Name(earth, "ObservationModel") |> PrefixedName
    /// <summary>
    ///   <para>earth:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A person that has participated directly or indirectly in the authoring or contribution of any resources in  Linked Earth.</para>
    /// labels<para>Person</para></remarks>
    /// <seealso href="http://linked.earth/ontology#Person">http://linked.earth/ontology#Person</seealso>
    let Person = Prefixed_Name(earth, "Person") |> PrefixedName
    /// <summary>
    ///   <para>earth:Resolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Refers to the distance (physical or temporal) between each point on the archive. May or May not be related to sampling. Value with units</para>
    /// labels<para>Resolution</para></remarks>
    /// <seealso href="http://linked.earth/ontology#Resolution">http://linked.earth/ontology#Resolution</seealso>
    let Resolution = Prefixed_Name(earth, "Resolution") |> PrefixedName
    /// <summary>
    ///   <para>earth:Uncertainty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A state of incomplete knowledge that can result from a lack of information or from disagreement about what is known or  even knowable. Uncertainty may come from many sources, from imprecision in the data to ambigously defined concepts or terminology, or uncertain projections of human bahavior. Uncertainty can be represented by quantitative measures (e.g., probability density function) or by qualitative statement (e.g., reflecting the judgement of a team of experts. Sensu IPCC AR5</para>
    /// labels<para>Uncertainty</para></remarks>
    /// <seealso href="http://linked.earth/ontology#Uncertainty">http://linked.earth/ontology#Uncertainty</seealso>
    let Uncertainty = Prefixed_Name(earth, "Uncertainty") |> PrefixedName
    /// <summary>
    ///   <para>earth:calibratedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that indicates how the measured variable was calibrated</para>
    /// labels<para>calibratedFrom</para></remarks>
    /// <seealso href="http://linked.earth/ontology#calibratedFrom">http://linked.earth/ontology#calibratedFrom</seealso>
    let calibratedFrom = Prefixed_Name(earth, "calibratedFrom") |> PrefixedName
    /// <summary>
    ///   <para>earth:SummaryTable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Table containing relevant statistics from the ensemble table</para><para>SummaryTable</para></remarks>
    /// <seealso href="http://linked.earth/ontology#SummaryTable">http://linked.earth/ontology#SummaryTable</seealso>
    let SummaryTable = Prefixed_Name(earth, "SummaryTable") |> PrefixedName
    /// <summary>
    ///   <para>earth:author</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Author of the resource</para>
    /// labels<para>author</para></remarks>
    /// <seealso href="http://linked.earth/ontology#author">http://linked.earth/ontology#author</seealso>
    let author = Prefixed_Name(earth, "author") |> PrefixedName
    /// <summary>
    ///   <para>earth:basedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>How are the data obtained?</para>
    /// labels<para>basedOn</para></remarks>
    /// <seealso href="http://linked.earth/ontology#basedOn">http://linked.earth/ontology#basedOn</seealso>
    let basedOn = Prefixed_Name(earth, "basedOn") |> PrefixedName

    /// <summary>
    ///   <para>earth:calibrationReferences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The publication that describes the calibration. The string should follow the model set in the publication class</para>
    /// labels<para>calibrationReferences</para></remarks>
    /// <seealso href="http://linked.earth/ontology#calibrationReferences">http://linked.earth/ontology#calibrationReferences</seealso>
    let calibrationReferences =
        Prefixed_Name(earth, "calibrationReferences") |> PrefixedName

    /// <summary>
    ///   <para>earth:archivedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>How was the climate or chronological information encoded into the Archive?</para>
    /// labels<para>archivedIn</para></remarks>
    /// <seealso href="http://linked.earth/ontology#archivedIn">http://linked.earth/ontology#archivedIn</seealso>
    let archivedIn = Prefixed_Name(earth, "archivedIn") |> PrefixedName
    /// <summary>
    ///   <para>earth:book</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Book in which the publication was published</para>
    /// labels<para>book</para></remarks>
    /// <seealso href="http://linked.earth/ontology#book">http://linked.earth/ontology#book</seealso>
    let book = Prefixed_Name(earth, "book") |> PrefixedName
    /// <summary>
    ///   <para>earth:calibratedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>How was the variable calibrated to represent climate or chronology?</para>
    /// labels<para>calibratedWith</para></remarks>
    /// <seealso href="http://linked.earth/ontology#calibratedWith">http://linked.earth/ontology#calibratedWith</seealso>
    let calibratedWith = Prefixed_Name(earth, "calibratedWith") |> PrefixedName
    /// <summary>
    ///   <para>earth:chronModeledBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>How was the chron data modeled?</para>
    /// labels<para>chronModeledBy</para></remarks>
    /// <seealso href="http://linked.earth/ontology#chronModeledBy">http://linked.earth/ontology#chronModeledBy</seealso>
    let chronModeledBy = Prefixed_Name(earth, "chronModeledBy") |> PrefixedName
    /// <summary>
    ///   <para>earth:collectedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Where was the data in the dataset collected from? Generally, this is the site where the archive was collected. </para>
    /// labels<para>collectedFrom</para></remarks>
    /// <seealso href="http://linked.earth/ontology#collectedFrom">http://linked.earth/ontology#collectedFrom</seealso>
    let collectedFrom = Prefixed_Name(earth, "collectedFrom") |> PrefixedName
    /// <summary>
    ///   <para>earth:modeledBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>How was the process modeled?</para>
    /// labels<para>modeledBy</para></remarks>
    /// <seealso href="http://linked.earth/ontology#modeledBy">http://linked.earth/ontology#modeledBy</seealso>
    let modeledBy = Prefixed_Name(earth, "modeledBy") |> PrefixedName
    /// <summary>
    ///   <para>earth:contributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Contributor of the resource (dataset, publication, etc.)</para>
    /// labels<para>contributor</para></remarks>
    /// <seealso href="http://linked.earth/ontology#contributor">http://linked.earth/ontology#contributor</seealso>
    let contributor = Prefixed_Name(earth, "contributor") |> PrefixedName
    /// <summary>
    ///   <para>earth:datasetVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The version of the dataset. It should follow the x.y.z notation where x refers to changes in metadata and data following a publication (for instance, the creation of a new age model using a different code), y refers to changes to the data following a publication (for instance, adding data further back in time without changing the model underlying the interpretation), and z refers to changes not associated with a publication (for instance, typos).</para>
    /// labels<para>datasetVersion</para></remarks>
    /// <seealso href="http://linked.earth/ontology#datasetVersion">http://linked.earth/ontology#datasetVersion</seealso>
    let datasetVersion = Prefixed_Name(earth, "datasetVersion") |> PrefixedName
    /// <summary>
    ///   <para>earth:detail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Answers the "of what" question for a Variable.</para>
    /// labels<para>detail</para></remarks>
    /// <seealso href="http://linked.earth/ontology#detail">http://linked.earth/ontology#detail</seealso>
    let detail = Prefixed_Name(earth, "detail") |> PrefixedName

    /// <summary>
    ///   <para>earth:foundInDistributionTable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Property that indicates that a variable or data is found in a distribution table</para>
    /// labels<para>foundInDistributionTable</para></remarks>
    /// <seealso href="http://linked.earth/ontology#foundInDistributionTable">http://linked.earth/ontology#foundInDistributionTable</seealso>
    let foundInDistributionTable =
        Prefixed_Name(earth, "foundInDistributionTable") |> PrefixedName

    /// <summary>
    ///   <para>earth:equation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The mathematical statement used to describe the model.</para>
    /// labels<para>equation</para></remarks>
    /// <seealso href="http://linked.earth/ontology#equation">http://linked.earth/ontology#equation</seealso>
    let equation = Prefixed_Name(earth, "equation") |> PrefixedName

    /// <summary>
    ///   <para>earth:foundInMeasurementTable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that indicates that a variable was found in a measurement table</para>
    /// labels<para>foundInMeasurementTable</para></remarks>
    /// <seealso href="http://linked.earth/ontology#foundInMeasurementTable">http://linked.earth/ontology#foundInMeasurementTable</seealso>
    let foundInMeasurementTable =
        Prefixed_Name(earth, "foundInMeasurementTable") |> PrefixedName

    /// <summary>
    ///   <para>earth:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The Linked Earth Ontology aims to provide a common vocabulary for annotating paleoclimatology data</para>
    /// </remarks>
    /// <seealso href="http://linked.earth/ontology#">http://linked.earth/ontology#</seealso>
    let _prefix_iri = Prefixed_Name(earth, "") |> PrefixedName
    /// <summary>
    ///   <para>earth:CalibrationModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Metadata about how the variable was calibrated to reflect an environmental variable</para>
    /// labels<para>CalibrationModel</para></remarks>
    /// <seealso href="http://linked.earth/ontology#CalibrationModel">http://linked.earth/ontology#CalibrationModel</seealso>
    let CalibrationModel = Prefixed_Name(earth, "CalibrationModel") |> PrefixedName
    /// <summary>
    ///   <para>earth:Data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An aggregation of DataTables and supporting information regarging the paleoenvironmental and/or chronological interpretation </para>
    /// labels<para>Data</para></remarks>
    /// <seealso href="http://linked.earth/ontology#Data">http://linked.earth/ontology#Data</seealso>
    let Data = Prefixed_Name(earth, "Data") |> PrefixedName
    /// <summary>
    ///   <para>earth:ChronProxy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The data and metadata associated with how the chronology information was obtained.</para>
    /// labels<para>ChronProxy</para></remarks>
    /// <seealso href="http://linked.earth/ontology#ChronProxy">http://linked.earth/ontology#ChronProxy</seealso>
    let ChronProxy = Prefixed_Name(earth, "ChronProxy") |> PrefixedName
    /// <summary>
    ///   <para>earth:Interpretation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A suite of metadata that describe how a variable is interpreted to reflect past variability, including environmental variability</para>
    /// labels<para>Interpretation</para></remarks>
    /// <seealso href="http://linked.earth/ontology#Interpretation">http://linked.earth/ontology#Interpretation</seealso>
    let Interpretation = Prefixed_Name(earth, "Interpretation") |> PrefixedName
    /// <summary>
    ///   <para>earth:fundingCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Country which awarded the funding for the dataset</para>
    /// labels<para>fundingCountry</para></remarks>
    /// <seealso href="http://linked.earth/ontology#fundingCountry">http://linked.earth/ontology#fundingCountry</seealso>
    let fundingCountry = Prefixed_Name(earth, "fundingCountry") |> PrefixedName
    /// <summary>
    ///   <para>earth:hasFileName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Name of the CSV file containing the data table</para>
    /// labels<para>hasFileName</para></remarks>
    /// <seealso href="http://linked.earth/ontology#hasFileName">http://linked.earth/ontology#hasFileName</seealso>
    let hasFileName = Prefixed_Name(earth, "hasFileName") |> PrefixedName
    /// <summary>
    ///   <para>earth:hasLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A downloadable link of a resource</para>
    /// labels<para>hasLink</para></remarks>
    /// <seealso href="http://linked.earth/ontology#hasLink">http://linked.earth/ontology#hasLink</seealso>
    let hasLink = Prefixed_Name(earth, "hasLink") |> PrefixedName
    /// <summary>
    ///   <para>earth:hasRank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Describes the importance of the ClimateInterpretation. For instance, d18Ocalcite is influenced by both temperature and d18Osw. If temperature is the dominant influence, then its rank is 1.</para>
    /// labels<para>hasRank</para></remarks>
    /// <seealso href="http://linked.earth/ontology#hasRank">http://linked.earth/ontology#hasRank</seealso>
    let hasRank = Prefixed_Name(earth, "hasRank") |> PrefixedName
    /// <summary>
    ///   <para>earth:hasResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>What is the Resolution of the Archive?</para>
    /// labels<para>hasResolution</para></remarks>
    /// <seealso href="http://linked.earth/ontology#hasResolution">http://linked.earth/ontology#hasResolution</seealso>
    let hasResolution = Prefixed_Name(earth, "hasResolution") |> PrefixedName
    /// <summary>
    ///   <para>earth:hasUncertainty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>What is the Uncertainty associated with the Observations, Model, and Calibration?</para>
    /// labels<para>hasUncertainty</para></remarks>
    /// <seealso href="http://linked.earth/ontology#hasUncertainty">http://linked.earth/ontology#hasUncertainty</seealso>
    let hasUncertainty = Prefixed_Name(earth, "hasUncertainty") |> PrefixedName
    /// <summary>
    ///   <para>earth:includesChronData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Pointer to the chron data included in the dataset</para>
    /// labels<para>includesChronData</para></remarks>
    /// <seealso href="http://linked.earth/ontology#includesChronData">http://linked.earth/ontology#includesChronData</seealso>
    let includesChronData = Prefixed_Name(earth, "includesChronData") |> PrefixedName
    /// <summary>
    ///   <para>earth:includesData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>What are the paleoenvironmental and chronological Data included in the Dataset?</para>
    /// labels<para>includesData</para></remarks>
    /// <seealso href="http://linked.earth/ontology#includesData">http://linked.earth/ontology#includesData</seealso>
    let includesData = Prefixed_Name(earth, "includesData") |> PrefixedName
    /// <summary>
    ///   <para>earth:includesPaleoData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The paleo data included as part of a dataset</para>
    /// labels<para>includesPaleoData</para></remarks>
    /// <seealso href="http://linked.earth/ontology#includesPaleoData">http://linked.earth/ontology#includesPaleoData</seealso>
    let includesPaleoData = Prefixed_Name(earth, "includesPaleoData") |> PrefixedName
    /// <summary>
    ///   <para>earth:inferredFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>From which measured variable is the current inferred variable obtained?</para>
    /// labels<para>inferredFrom</para></remarks>
    /// <seealso href="http://linked.earth/ontology#inferredFrom">http://linked.earth/ontology#inferredFrom</seealso>
    let inferredFrom = Prefixed_Name(earth, "inferredFrom") |> PrefixedName

    /// <summary>
    ///   <para>earth:interpretationDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Describes whether the interpreted environmental variable increases (positive) or decreases (negative) as the paleoDataVariableValue increases. The literal is a string , either "positive" or "negative"</para>
    /// labels<para>interpretationDirection</para></remarks>
    /// <seealso href="http://linked.earth/ontology#interpretationDirection">http://linked.earth/ontology#interpretationDirection</seealso>
    let interpretationDirection =
        Prefixed_Name(earth, "interpretationDirection") |> PrefixedName

    /// <summary>
    ///   <para>earth:interpretedAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>how is the variable interpreted?</para>
    /// labels<para>interpretedAs</para></remarks>
    /// <seealso href="http://linked.earth/ontology#interpretedAs">http://linked.earth/ontology#interpretedAs</seealso>
    let interpretedAs = Prefixed_Name(earth, "interpretedAs") |> PrefixedName
    /// <summary>
    ///   <para>earth:isLocal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Whether the influence on the MeasuredVariable (and therefore the Interpretation) is local or far-field. The literal is a string.</para>
    /// labels<para>isLocal</para></remarks>
    /// <seealso href="http://linked.earth/ontology#isLocal">http://linked.earth/ontology#isLocal</seealso>
    let isLocal = Prefixed_Name(earth, "isLocal") |> PrefixedName
    /// <summary>
    ///   <para>earth:issue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The issue number for the publication</para>
    /// labels<para>issue</para></remarks>
    /// <seealso href="http://linked.earth/ontology#issue">http://linked.earth/ontology#issue</seealso>
    let issue = Prefixed_Name(earth, "issue") |> PrefixedName
    /// <summary>
    ///   <para>earth:measuredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>What Instrument was used to obtain the MeasuredVariables and Observations?</para>
    /// labels<para>measuredBy</para></remarks>
    /// <seealso href="http://linked.earth/ontology#measuredBy">http://linked.earth/ontology#measuredBy</seealso>
    let measuredBy = Prefixed_Name(earth, "measuredBy") |> PrefixedName
    /// <summary>
    ///   <para>earth:measuredOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>On what Archive were the Observations measured on?</para>
    /// labels<para>measuredOn</para></remarks>
    /// <seealso href="http://linked.earth/ontology#measuredOn">http://linked.earth/ontology#measuredOn</seealso>
    let measuredOn = Prefixed_Name(earth, "measuredOn") |> PrefixedName
    /// <summary>
    ///   <para>earth:modelReferences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The publication that describes the model. </para>
    /// labels<para>modelReferences</para></remarks>
    /// <seealso href="http://linked.earth/ontology#modelReferences">http://linked.earth/ontology#modelReferences</seealso>
    let modelReferences = Prefixed_Name(earth, "modelReferences") |> PrefixedName
    /// <summary>
    ///   <para>earth:notes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Notes regarding the cells in the DataTable</para>
    /// labels<para>notes</para></remarks>
    /// <seealso href="http://linked.earth/ontology#notes">http://linked.earth/ontology#notes</seealso>
    let notes = Prefixed_Name(earth, "notes") |> PrefixedName
    /// <summary>
    ///   <para>earth:observedAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>What Observations were made?</para>
    /// labels<para>observedAs</para></remarks>
    /// <seealso href="http://linked.earth/ontology#observedAs">http://linked.earth/ontology#observedAs</seealso>
    let observedAs = Prefixed_Name(earth, "observedAs") |> PrefixedName
    /// <summary>
    ///   <para>earth:pages</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The page range for the article.</para>
    /// labels<para>pages</para></remarks>
    /// <seealso href="http://linked.earth/ontology#pages">http://linked.earth/ontology#pages</seealso>
    let pages = Prefixed_Name(earth, "pages") |> PrefixedName
    /// <summary>
    ///   <para>earth:paleoModeledBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>How was the paleoData modeled?</para>
    /// labels<para>paleoModeledBy</para></remarks>
    /// <seealso href="http://linked.earth/ontology#paleoModeledBy">http://linked.earth/ontology#paleoModeledBy</seealso>
    let paleoModeledBy = Prefixed_Name(earth, "paleoModeledBy") |> PrefixedName
    /// <summary>
    ///   <para>earth:publishedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Where was the Dataset published? Property that relates a dataset to the publication where it was published.</para>
    /// labels<para>publishedIn</para></remarks>
    /// <seealso href="http://linked.earth/ontology#publishedIn">http://linked.earth/ontology#publishedIn</seealso>
    let publishedIn = Prefixed_Name(earth, "publishedIn") |> PrefixedName
    /// <summary>
    ///   <para>earth:relevantQuote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Relevant summary or preferably quotation from the referenced Publication</para>
    /// labels<para>relevantQuote</para></remarks>
    /// <seealso href="http://linked.earth/ontology#relevantQuote">http://linked.earth/ontology#relevantQuote</seealso>
    let relevantQuote = Prefixed_Name(earth, "relevantQuote") |> PrefixedName
    /// <summary>
    ///   <para>earth:sensingWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>How does the proxy system senses the environment?</para>
    /// labels<para>sensingWith</para></remarks>
    /// <seealso href="http://linked.earth/ontology#sensingWith">http://linked.earth/ontology#sensingWith</seealso>
    let sensingWith = Prefixed_Name(earth, "sensingWith") |> PrefixedName
    /// <summary>
    ///   <para>earth:sensorGenus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The Genus of the sensor</para>
    /// labels<para>sensorGenus</para></remarks>
    /// <seealso href="http://linked.earth/ontology#sensorGenus">http://linked.earth/ontology#sensorGenus</seealso>
    let sensorGenus = Prefixed_Name(earth, "sensorGenus") |> PrefixedName
    /// <summary>
    ///   <para>earth:sensorSpecies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The species of the sensor</para>
    /// labels<para>sensorSpecies</para></remarks>
    /// <seealso href="http://linked.earth/ontology#sensorSpecies">http://linked.earth/ontology#sensorSpecies</seealso>
    let sensorSpecies = Prefixed_Name(earth, "sensorSpecies") |> PrefixedName
    /// <summary>
    ///   <para>earth:standard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The standard against which the observations are reported (for instance, VSMOW or VPDB)</para>
    /// labels<para>standard</para></remarks>
    /// <seealso href="http://linked.earth/ontology#standard">http://linked.earth/ontology#standard</seealso>
    let standard = Prefixed_Name(earth, "standard") |> PrefixedName
    /// <summary>
    ///   <para>earth:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Title of a publication</para>
    /// labels<para>title</para></remarks>
    /// <seealso href="http://linked.earth/ontology#title">http://linked.earth/ontology#title</seealso>
    let title = Prefixed_Name(earth, "title") |> PrefixedName
    /// <summary>
    ///   <para>earth:uncertaintyLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Quantile or number of standard deviations along a probability distribution of a Variable.</para>
    /// labels<para>uncertaintyLevel</para></remarks>
    /// <seealso href="http://linked.earth/ontology#uncertaintyLevel">http://linked.earth/ontology#uncertaintyLevel</seealso>
    let uncertaintyLevel = Prefixed_Name(earth, "uncertaintyLevel") |> PrefixedName

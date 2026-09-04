#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module sdont =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/okn/o/sd#" "sdont"
    /// <summary>
    ///   <para>rdfs:label : Catalog identifier</para>
    ///   <para>rdfs:comment : Class to identify that a parameter is a catalog identifier. The rationale for this type of parameter is that in some cases datasets may be downloaded in the software component itself, rather than exposed as an input</para>
    ///   <a href="https://w3id.org/okn/o/sd#CatalogIdentifier">sdont:CatalogIdentifier</a>
    /// </summary>
    let CatalogIdentifier = _prefixId.prefix "CatalogIdentifier"
    /// <summary>
    ///   <para>rdfs:label : Configuration Setup</para>
    ///   <para>rdfs:comment : Special type of configuration in which some of the inputs or parameters are associated to files or values. A configuration may be associated to multiple setups to facilitate its execution.</para>
    ///   <a href="https://w3id.org/okn/o/sd#ConfigurationSetup">sdont:ConfigurationSetup</a>
    /// </summary>
    let ConfigurationSetup = _prefixId.prefix "ConfigurationSetup"
    /// <summary>
    ///   <para>rdfs:label : Constraint</para>
    ///   <para>rdfs:comment : Data constraints of a configuration</para>
    ///   <a href="https://w3id.org/okn/o/sd#Constraint">sdont:Constraint</a>
    /// </summary>
    let Constraint = _prefixId.prefix "Constraint"
    /// <summary>
    ///   <para>rdfs:label : Data Transformation</para>
    ///   <para>rdfs:comment : Class that represents a software for performing data transformation.</para>
    ///   <a href="https://w3id.org/okn/o/sd#DataTransformation">sdont:DataTransformation</a>
    /// </summary>
    let DataTransformation = _prefixId.prefix "DataTransformation"
    /// <summary>
    ///   <para>rdfs:label : Data Transformation Setup</para>
    ///   <para>rdfs:comment : Special type of data transformation where the inputs and parameters have some pre-selected values. For example, they may point to a particular dataset URL to be used in the transformation</para>
    ///   <a href="https://w3id.org/okn/o/sd#DataTransformationSetup">sdont:DataTransformationSetup</a>
    /// </summary>
    let DataTransformationSetup = _prefixId.prefix "DataTransformationSetup"
    /// <summary>
    ///   <para>rdfs:label : Dataset Specification</para>
    ///   <para>rdfs:comment : Class designed to describe a type of input or output used or produced by a model. For example, Topoflow has several inputs. One of them is a text file with precipitation values. The representation of this input is an instance of a dataset specification.</para>
    ///   <a href="https://w3id.org/okn/o/sd#DatasetSpecification">sdont:DatasetSpecification</a>
    /// </summary>
    let DatasetSpecification = _prefixId.prefix "DatasetSpecification"
    /// <summary>
    ///   <para>rdfs:label : Funding Information</para>
    ///   <para>rdfs:comment : A class to represent the funding information of a software project</para>
    ///   <a href="https://w3id.org/okn/o/sd#FundingInformation">sdont:FundingInformation</a>
    /// </summary>
    let FundingInformation = _prefixId.prefix "FundingInformation"
    /// <summary>
    ///   <para>rdfs:label : Image</para>
    ///   <para>rdfs:comment : An image (e.g. tiff file) is a type of dataset specification used to define certain inputs of models like soil, crops, etc.</para>
    ///   <a href="https://w3id.org/okn/o/sd#Image">sdont:Image</a>
    /// </summary>
    let Image = _prefixId.prefix "Image"
    /// <summary>
    ///   <para>rdfs:label : Numerical Index</para>
    ///   <para>rdfs:comment : A number (such as a ratio) derived from a series of observations and used as an indicator or measure (https://www.merriam-webster.com/dictionary/index)</para>
    ///   <a href="https://w3id.org/okn/o/sd#NumericalIndex">sdont:NumericalIndex</a>
    /// </summary>
    let NumericalIndex = _prefixId.prefix "NumericalIndex"
    /// <summary>
    ///   <para>rdfs:label : Organization</para>
    ///   <para>rdfs:comment : An organized body of people with a particular purpose</para>
    ///   <a href="https://w3id.org/okn/o/sd#Organization">sdont:Organization</a>
    /// </summary>
    let Organization = _prefixId.prefix "Organization"
    /// <summary>
    ///   <para>rdfs:label : Parameter</para>
    ///   <para>rdfs:comment : A parameter of the model.</para>
    ///   <a href="https://w3id.org/okn/o/sd#Parameter">sdont:Parameter</a>
    /// </summary>
    let Parameter = _prefixId.prefix "Parameter"
    /// <summary>
    ///   <para>rdfs:label : Person</para>
    ///   <para>rdfs:comment : A human being (individual)</para>
    ///   <a href="https://w3id.org/okn/o/sd#Person">sdont:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>rdfs:label : Sample Collection</para>
    ///   <para>rdfs:comment : A collection of resources that are used as sample for running a sfoware component multiple times</para>
    ///   <a href="https://w3id.org/okn/o/sd#SampleCollection">sdont:SampleCollection</a>
    /// </summary>
    let SampleCollection = _prefixId.prefix "SampleCollection"
    /// <summary>
    ///   <para>rdfs:label : Sample Execution</para>
    ///   <para>rdfs:comment : A sample execution of a given software</para>
    ///   <a href="https://w3id.org/okn/o/sd#SampleExecution">sdont:SampleExecution</a>
    /// </summary>
    let SampleExecution = _prefixId.prefix "SampleExecution"
    /// <summary>
    ///   <para>rdfs:label : Sample Resource</para>
    ///   <para>rdfs:comment : A sample resource associated with a software</para>
    ///   <a href="https://w3id.org/okn/o/sd#SampleResource">sdont:SampleResource</a>
    /// </summary>
    let SampleResource = _prefixId.prefix "SampleResource"
    /// <summary>
    ///   <para>rdfs:label : Software</para>
    ///   <para>rdfs:comment : The set of instructions that indicate a machine how to work. In this ontology software is a general concept which acts as a superclass for software versions, docker images, data transformations, etc.</para>
    ///   <a href="https://w3id.org/okn/o/sd#Software">sdont:Software</a>
    /// </summary>
    let Software = _prefixId.prefix "Software"
    /// <summary>
    ///   <para>rdfs:label : Software Configuration</para>
    ///   <para>rdfs:comment : A software configuration represents a particular way of invoking a function of a software component. A software configuration exposes the precise inputs and outputs that are used for that function. Multiple software configurations may be associated to a software component. A software configuration facilitates the encapsulation of software, and it can be used to represent components of scientific workflows.</para>
    ///   <a href="https://w3id.org/okn/o/sd#SoftwareConfiguration">sdont:SoftwareConfiguration</a>
    /// </summary>
    let SoftwareConfiguration = _prefixId.prefix "SoftwareConfiguration"
    /// <summary>
    ///   <para>rdfs:label : Software Image</para>
    ///   <para>rdfs:comment : An image that virtualizes the functionality of a given software. For example, a Docker container.</para>
    ///   <a href="https://w3id.org/okn/o/sd#SoftwareImage">sdont:SoftwareImage</a>
    /// </summary>
    let SoftwareImage = _prefixId.prefix "SoftwareImage"
    /// <summary>
    ///   <para>rdfs:label : Software Version</para>
    ///   <para>rdfs:comment : A software version is a specificf type of software that represents a particular set of functionalities. New functionalities and error fixes may occur between software versions</para>
    ///   <a href="https://w3id.org/okn/o/sd#SoftwareVersion">sdont:SoftwareVersion</a>
    /// </summary>
    let SoftwareVersion = _prefixId.prefix "SoftwareVersion"
    /// <summary>
    ///   <para>rdfs:label : Source Code</para>
    ///   <para>rdfs:comment : Class representing the characteristics of the code associated with a  software component</para>
    ///   <a href="https://w3id.org/okn/o/sd#SourceCode">sdont:SourceCode</a>
    /// </summary>
    let SourceCode = _prefixId.prefix "SourceCode"
    /// <summary>
    ///   <para>rdfs:label : Standard Variable</para>
    ///   <para>rdfs:comment : A standard variable, necessary to refer to all the variable using the same nomenclature in a domain ontology. For example, a standard variable may be a SVO variable (http://www.geoscienceontology.org/geo-upper#Variable)</para>
    ///   <a href="https://w3id.org/okn/o/sd#StandardVariable">sdont:StandardVariable</a>
    /// </summary>
    let StandardVariable = _prefixId.prefix "StandardVariable"
    /// <summary>
    ///   <para>rdfs:label : Unit</para>
    ///   <para>rdfs:comment : Class designed to distinguish the different types of units that are available in variables from datasets or parameters</para>
    ///   <a href="https://w3id.org/okn/o/sd#Unit">sdont:Unit</a>
    /// </summary>
    let Unit = _prefixId.prefix "Unit"
    /// <summary>
    ///   <para>rdfs:label : Variable</para>
    ///   <para>rdfs:comment : A symbol that represents a quanity in a dataset or dataset specification</para>
    ///   <a href="https://w3id.org/okn/o/sd#Variable">sdont:Variable</a>
    /// </summary>
    let Variable = _prefixId.prefix "Variable"
    /// <summary>
    ///   <para>rdfs:label : Variable presentation</para>
    ///   <para>rdfs:comment : Concept used to represent an instantiation of a variable in an input/output dataset. For example, a model A may use an input file with temperature expressed in Farenheit (variablePresentation1), while a model B may produce an output with temperature in Celsius (variablePresentation2). Both variable presentations refer to the concept of temperature.</para>
    ///   <a href="https://w3id.org/okn/o/sd#VariablePresentation">sdont:VariablePresentation</a>
    /// </summary>
    let VariablePresentation = _prefixId.prefix "VariablePresentation"
    /// <summary>
    ///   <para>rdfs:label : Visualization</para>
    ///   <para>rdfs:comment : Class to represent any type of visualization related to a software. For example, a dynamic HTML page, a video, etc.</para>
    ///   <a href="https://w3id.org/okn/o/sd#Visualization">sdont:Visualization</a>
    /// </summary>
    let Visualization = _prefixId.prefix "Visualization"
    /// <summary>
    ///   <para>rdfs:label : adjustable parameter</para>
    ///   <para>rdfs:comment : Parameter that can be adjusted in a configuration setup</para>
    ///   <a href="https://w3id.org/okn/o/sd#adjustableParameter">sdont:adjustableParameter</a>
    /// </summary>
    let adjustableParameter = _prefixId.prefix "adjustableParameter"
    /// <summary>
    ///   <para>rdfs:label : adjusts variable</para>
    ///   <para>rdfs:comment : Property that links parameter with the variable they adjust. This property can be used when parameters quantify variables without directly representing them. For example, a "fertilizer percentage adjustment" parameter can quantify a "fertilizer price" variable</para>
    ///   <a href="https://w3id.org/okn/o/sd#adjustsVariable">sdont:adjustsVariable</a>
    /// </summary>
    let adjustsVariable = _prefixId.prefix "adjustsVariable"
    /// <summary>
    ///   <para>rdfs:label : author</para>
    ///   <para>rdfs:comment : The creator of a software component</para>
    ///   <a href="https://w3id.org/okn/o/sd#author">sdont:author</a>
    /// </summary>
    let author = _prefixId.prefix "author"
    /// <summary>
    ///   <para>rdfs:label : available in registry</para>
    ///   <para>rdfs:comment : Property that indicates in which registry the software image being described can be found. For example, https://hub.docker.com</para>
    ///   <a href="https://w3id.org/okn/o/sd#availableInRegistry">sdont:availableInRegistry</a>
    /// </summary>
    let availableInRegistry = _prefixId.prefix "availableInRegistry"
    /// <summary>
    ///   <para>rdfs:label : citation</para>
    ///   <para>rdfs:comment : How to cite this software</para>
    ///   <a href="https://w3id.org/okn/o/sd#citation">sdont:citation</a>
    /// </summary>
    let citation = _prefixId.prefix "citation"
    /// <summary>
    ///   <para>rdfs:label : code repository</para>
    ///   <para>rdfs:comment : URL to the code repository of a software component</para>
    ///   <a href="https://w3id.org/okn/o/sd#codeRepository">sdont:codeRepository</a>
    /// </summary>
    let codeRepository = _prefixId.prefix "codeRepository"

    /// <summary>
    ///   <para>rdfs:label : compatible visualization software^^xsd:string</para>
    ///   <para>rdfs:comment : Property that links a software component to other useful software that canbe used to visualize its outputs</para>
    ///   <a href="https://w3id.org/okn/o/sd#compatibleVisualizationSoftware">sdont:compatibleVisualizationSoftware</a>
    /// </summary>
    let compatibleVisualizationSoftware =
        _prefixId.prefix "compatibleVisualizationSoftware"

    /// <summary>
    ///   <para>rdfs:label : contributor</para>
    ///   <para>rdfs:comment : Contributor to a software component</para>
    ///   <a href="https://w3id.org/okn/o/sd#contributor">sdont:contributor</a>
    /// </summary>
    let contributor = _prefixId.prefix "contributor"
    /// <summary>
    ///   <para>rdfs:label : copyright holder</para>
    ///   <para>rdfs:comment : Copyright holder for a software component</para>
    ///   <a href="https://w3id.org/okn/o/sd#copyrightHolder">sdont:copyrightHolder</a>
    /// </summary>
    let copyrightHolder = _prefixId.prefix "copyrightHolder"
    /// <summary>
    ///   <para>rdfs:label : copyright year</para>
    ///   <para>rdfs:comment : Year in which the software component was copyrighted</para>
    ///   <a href="https://w3id.org/okn/o/sd#copyrightYear">sdont:copyrightYear</a>
    /// </summary>
    let copyrightYear = _prefixId.prefix "copyrightYear"
    /// <summary>
    ///   <para>rdfs:label : data catalog identifier</para>
    ///   <para>rdfs:comment : An identifier for resources with metadata entries in a data catalog</para>
    ///   <a href="https://w3id.org/okn/o/sd#dataCatalogIdentifier">sdont:dataCatalogIdentifier</a>
    /// </summary>
    let dataCatalogIdentifier = _prefixId.prefix "dataCatalogIdentifier"
    /// <summary>
    ///   <para>rdfs:label : date created</para>
    ///   <para>rdfs:comment : Date when a software component was created</para>
    ///   <a href="https://w3id.org/okn/o/sd#dateCreated">sdont:dateCreated</a>
    /// </summary>
    let dateCreated = _prefixId.prefix "dateCreated"
    /// <summary>
    ///   <para>rdfs:label : date published</para>
    ///   <para>rdfs:comment : Date when a software component was published</para>
    ///   <a href="https://w3id.org/okn/o/sd#datePublished">sdont:datePublished</a>
    /// </summary>
    let datePublished = _prefixId.prefix "datePublished"
    /// <summary>
    ///   <para>rdfs:label : description</para>
    ///   <para>rdfs:comment : A description of a resource</para>
    ///   <a href="https://w3id.org/okn/o/sd#description">sdont:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:label : doi</para>
    ///   <para>rdfs:comment : Digital Object Identifier associated with a software component</para>
    ///   <a href="https://w3id.org/okn/o/sd#doi">sdont:doi</a>
    /// </summary>
    let doi = _prefixId.prefix "doi"
    /// <summary>
    ///   <para>rdfs:label : email</para>
    ///   <para>rdfs:comment : Email of a person</para>
    ///   <a href="https://w3id.org/okn/o/sd#email">sdont:email</a>
    /// </summary>
    let email = _prefixId.prefix "email"
    /// <summary>
    ///   <para>rdfs:label : funding grant</para>
    ///   <para>rdfs:comment : Grant number used for funding</para>
    ///   <a href="https://w3id.org/okn/o/sd#fundingGrant">sdont:fundingGrant</a>
    /// </summary>
    let fundingGrant = _prefixId.prefix "fundingGrant"
    /// <summary>
    ///   <para>rdfs:label : funding source</para>
    ///   <para>rdfs:comment : Link to the organization funding a software component</para>
    ///   <a href="https://w3id.org/okn/o/sd#fundingSource">sdont:fundingSource</a>
    /// </summary>
    let fundingSource = _prefixId.prefix "fundingSource"
    /// <summary>
    ///   <para>rdfs:label : had primary source</para>
    ///   <para>rdfs:comment : Property to identify the original source of the information of the annotated resource. It could be a web page, an organization, a person, some experiment notes, etc.</para>
    ///   <a href="https://w3id.org/okn/o/sd#hadPrimarySource">sdont:hadPrimarySource</a>
    /// </summary>
    let hadPrimarySource = _prefixId.prefix "hadPrimarySource"
    /// <summary>
    ///   <para>rdfs:label : has accepted values</para>
    ///   <para>rdfs:comment : Property that constraints which values are accepted for a parameter. For example, the name of a crop can only be "Maize" or "Sorghum"</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasAcceptedValues">sdont:hasAcceptedValues</a>
    /// </summary>
    let hasAcceptedValues = _prefixId.prefix "hasAcceptedValues"
    /// <summary>
    ///   <para>rdfs:label : has acknowledgements</para>
    ///   <para>rdfs:comment : String with the people, organizations and other contributors acknowledged by the authors.</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasAcknowledgements">sdont:hasAcknowledgements</a>
    /// </summary>
    let hasAcknowledgements = _prefixId.prefix "hasAcknowledgements"
    /// <summary>
    ///   <para>rdfs:label : has assumption</para>
    ///   <para>rdfs:comment : Assumptions of a software, e.g. the solver being used for a particular model, the source of the data (e.g., all data must have a given resolution), etc.</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasAssumption">sdont:hasAssumption</a>
    /// </summary>
    let hasAssumption = _prefixId.prefix "hasAssumption"
    /// <summary>
    ///   <para>rdfs:label : has build file</para>
    ///   <para>rdfs:comment : A file (e.g., Dockerfile) with executable instructions indicating how a Software Image or a Software component is built</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasBuildFile">sdont:hasBuildFile</a>
    /// </summary>
    let hasBuildFile = _prefixId.prefix "hasBuildFile"
    /// <summary>
    ///   <para>rdfs:label : has code of conduct</para>
    ///   <para>rdfs:comment : Property linking the software component to the code of conduct to be followed by potential contributors. The range of this property may be a strin or a URI to the target file.</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasCodeOfConduct">sdont:hasCodeOfConduct</a>
    /// </summary>
    let hasCodeOfConduct = _prefixId.prefix "hasCodeOfConduct"
    /// <summary>
    ///   <para>rdfs:label : has component location</para>
    ///   <para>rdfs:comment : Location of the aggregation of all the files needed to execute the component. Usually a zip file including the run script and support scripts, including specification files</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasComponentLocation">sdont:hasComponentLocation</a>
    /// </summary>
    let hasComponentLocation = _prefixId.prefix "hasComponentLocation"
    /// <summary>
    ///   <para>rdfs:label : has configuration</para>
    ///   <para>rdfs:comment : Property that links a model to one of its configurations. A model may have multiple configurations, each of which is unique in terms of the inputs and outputs it uses.</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasConfiguration">sdont:hasConfiguration</a>
    /// </summary>
    let hasConfiguration = _prefixId.prefix "hasConfiguration"
    /// <summary>
    ///   <para>rdfs:label : has constraint</para>
    ///   <para>rdfs:comment : Constraint or rule associated to a  variable or software configuration. For example: "This model accepts only monthly data", or "all inputs of this model configuration must share the same location". More structured restrictions, such as Jena rules or SWRL rules may also be captured with this property</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasConstraint">sdont:hasConstraint</a>
    /// </summary>
    let hasConstraint = _prefixId.prefix "hasConstraint"
    /// <summary>
    ///   <para>rdfs:label : has contact person</para>
    ///   <para>rdfs:comment : Contact person responsible for a software component</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasContactPerson">sdont:hasContactPerson</a>
    /// </summary>
    let hasContactPerson = _prefixId.prefix "hasContactPerson"
    /// <summary>
    ///   <para>rdfs:label : has data transformation</para>
    ///   <para>rdfs:comment : Property that associates an input/output with their corresponding data transformation.</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasDataTransformation">sdont:hasDataTransformation</a>
    /// </summary>
    let hasDataTransformation = _prefixId.prefix "hasDataTransformation"
    /// <summary>
    ///   <para>rdfs:label : has data transformation setup</para>
    ///   <para>rdfs:comment : Property to link an input/output dataset to the specific data transformation (with URLs</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasDataTransformationSetup">sdont:hasDataTransformationSetup</a>
    /// </summary>
    let hasDataTransformationSetup = _prefixId.prefix "hasDataTransformationSetup"
    /// <summary>
    ///   <para>rdfs:label : has data type</para>
    ///   <para>rdfs:comment : Property that indicates the data type of a parameter</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasDataType">sdont:hasDataType</a>
    /// </summary>
    let hasDataType = _prefixId.prefix "hasDataType"
    /// <summary>
    ///   <para>rdfs:label : has default value</para>
    ///   <para>rdfs:comment : Default accepted value of a variable presentation (or a parameter)</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasDefaultValue">sdont:hasDefaultValue</a>
    /// </summary>
    let hasDefaultValue = _prefixId.prefix "hasDefaultValue"
    /// <summary>
    ///   <para>rdfs:label : has dimensionality</para>
    ///   <para>rdfs:comment : Property to indicate dimensionality of the input or output of a dataset specification</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasDimensionality">sdont:hasDimensionality</a>
    /// </summary>
    let hasDimensionality = _prefixId.prefix "hasDimensionality"
    /// <summary>
    ///   <para>rdfs:label : has documentation</para>
    ///   <para>rdfs:comment : Pointer to the documentation of the model</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasDocumentation">sdont:hasDocumentation</a>
    /// </summary>
    let hasDocumentation = _prefixId.prefix "hasDocumentation"
    /// <summary>
    ///   <para>rdfs:label : has download instructions</para>
    ///   <para>rdfs:comment : Instructions needed to download a software component. The difference with `hasDownloadURL` is that this property captures the human readable instructions required to download software. For example, sometimes an authentication is needed, users need to fill in a form, etc.</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasDownloadInstructions">sdont:hasDownloadInstructions</a>
    /// </summary>
    let hasDownloadInstructions = _prefixId.prefix "hasDownloadInstructions"
    /// <summary>
    ///   <para>rdfs:label : has download URL</para>
    ///   <para>rdfs:comment : Download URL where to obtain the source/executable of the software</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasDownloadURL">sdont:hasDownloadURL</a>
    /// </summary>
    let hasDownloadURL = _prefixId.prefix "hasDownloadURL"
    /// <summary>
    ///   <para>rdfs:label : has example</para>
    ///   <para>rdfs:comment : An example explaining a scenario where the software component was used in plain language.</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasExample">sdont:hasExample</a>
    /// </summary>
    let hasExample = _prefixId.prefix "hasExample"
    /// <summary>
    ///   <para>rdfs:label : has executable instructions</para>
    ///   <para>rdfs:comment : Instructions that indicate how a software component should be executed. The difference with `hasExecutionCommand` is that the execution instructions aim to be human-readable, and have explanations between the different commands and instructions</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasExecutableInstructions">sdont:hasExecutableInstructions</a>
    /// </summary>
    let hasExecutableInstructions = _prefixId.prefix "hasExecutableInstructions"
    /// <summary>
    ///   <para>rdfs:label : has executable notebook</para>
    ///   <para>rdfs:comment : Property that links a software component with an executable notebook (e.g., Jupyter notebook) that illustrates how to use it in an executable manner.</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasExecutableNotebook">sdont:hasExecutableNotebook</a>
    /// </summary>
    let hasExecutableNotebook = _prefixId.prefix "hasExecutableNotebook"
    /// <summary>
    ///   <para>rdfs:label : has execution command</para>
    ///   <para>rdfs:comment : Execution instructions on how to run the image</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasExecutionCommand">sdont:hasExecutionCommand</a>
    /// </summary>
    let hasExecutionCommand = _prefixId.prefix "hasExecutionCommand"
    /// <summary>
    ///   <para>rdfs:label : has FAQ</para>
    ///   <para>rdfs:comment : Frequently asked questions about a software</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasFAQ">sdont:hasFAQ</a>
    /// </summary>
    let hasFAQ = _prefixId.prefix "hasFAQ"
    /// <summary>
    ///   <para>rdfs:label : has file structure</para>
    ///   <para>rdfs:comment : Relates a dataset specification to the data structure definition</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasFileStructure">sdont:hasFileStructure</a>
    /// </summary>
    let hasFileStructure = _prefixId.prefix "hasFileStructure"
    /// <summary>
    ///   <para>rdfs:label : has fixed resource</para>
    ///   <para>rdfs:comment : Property that links a parameter or an input to a fixed value. For example, in a given configuration a parameter with the planting date for a model could be fixed to avoid the user changing it for that region.</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasFixedResource">sdont:hasFixedResource</a>
    /// </summary>
    let hasFixedResource = _prefixId.prefix "hasFixedResource"
    /// <summary>
    ///   <para>rdfs:label : has fixed value</para>
    ///   <para>rdfs:comment : Value of a parameter in a software setup.</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasFixedValue">sdont:hasFixedValue</a>
    /// </summary>
    let hasFixedValue = _prefixId.prefix "hasFixedValue"
    /// <summary>
    ///   <para>rdfs:label : has format</para>
    ///   <para>rdfs:comment : Format followed by a file. For example, txt, nc, etc.</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasFormat">sdont:hasFormat</a>
    /// </summary>
    let hasFormat = _prefixId.prefix "hasFormat"
    /// <summary>
    ///   <para>rdfs:label : has funding information</para>
    ///   <para>rdfs:comment : Property that links a software project to its funding information</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasFunding">sdont:hasFunding</a>
    /// </summary>
    let hasFunding = _prefixId.prefix "hasFunding"

    /// <summary>
    ///   <para>rdfs:label : has implementation script location</para>
    ///   <para>rdfs:comment : Property that points to the main runnable script for the current function</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasImplementationScriptLocation">sdont:hasImplementationScriptLocation</a>
    /// </summary>
    let hasImplementationScriptLocation =
        _prefixId.prefix "hasImplementationScriptLocation"

    /// <summary>
    ///   <para>rdfs:label : has input</para>
    ///   <para>rdfs:comment : Property that links a model configuration to the input types expected by it.</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasInput">sdont:hasInput</a>
    /// </summary>
    let hasInput = _prefixId.prefix "hasInput"
    /// <summary>
    ///   <para>rdfs:label : has installation instructions</para>
    ///   <para>rdfs:comment : Instructions required to install this particular piece of software. Installation instructions usually are available in a human-readable manner.</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasInstallationInstructions">sdont:hasInstallationInstructions</a>
    /// </summary>
    let hasInstallationInstructions = _prefixId.prefix "hasInstallationInstructions"
    /// <summary>
    ///   <para>rdfs:label : has long name</para>
    ///   <para>rdfs:comment : Properties that relate the variable representation to its long name. The long name is useful for context (e.g., precipitation is less ambiguous than P) but not as precise as the standard name.</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasLongName">sdont:hasLongName</a>
    /// </summary>
    let hasLongName = _prefixId.prefix "hasLongName"
    /// <summary>
    ///   <para>rdfs:label : has maximum accepted value</para>
    ///   <para>rdfs:comment : Maximum accepted value of a variable presentation (or a parameter)</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasMaximumAcceptedValue">sdont:hasMaximumAcceptedValue</a>
    /// </summary>
    let hasMaximumAcceptedValue = _prefixId.prefix "hasMaximumAcceptedValue"
    /// <summary>
    ///   <para>rdfs:label : has minimum accepted value</para>
    ///   <para>rdfs:comment : Minimum accepted value of a variable presentation (or a parameter)</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasMinimumAcceptedValue">sdont:hasMinimumAcceptedValue</a>
    /// </summary>
    let hasMinimumAcceptedValue = _prefixId.prefix "hasMinimumAcceptedValue"
    /// <summary>
    ///   <para>rdfs:label : has output</para>
    ///   <para>rdfs:comment : Property that expresses what are the outputs of a model</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasOutput">sdont:hasOutput</a>
    /// </summary>
    let hasOutput = _prefixId.prefix "hasOutput"
    /// <summary>
    ///   <para>rdfs:label : has parameter</para>
    ///   <para>rdfs:comment : Property that indicates the parameters of a model configuration</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasParameter">sdont:hasParameter</a>
    /// </summary>
    let hasParameter = _prefixId.prefix "hasParameter"
    /// <summary>
    ///   <para>rdfs:label : has part</para>
    ///   <para>rdfs:comment : Property designed to reference the elements included in a sample collection.</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasPart">sdont:hasPart</a>
    /// </summary>
    let hasPart = _prefixId.prefix "hasPart"
    /// <summary>
    ///   <para>rdfs:label : has presentation</para>
    ///   <para>rdfs:comment : Property that links an instance of a dataset (or a dataset specification) to the presentation of a variable contained (or expected to be contained) on it.</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasPresentation">sdont:hasPresentation</a>
    /// </summary>
    let hasPresentation = _prefixId.prefix "hasPresentation"
    /// <summary>
    ///   <para>rdfs:label : has purpose</para>
    ///   <para>rdfs:comment : Objective or main functionality that can be achieved by running this software</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasPurpose">sdont:hasPurpose</a>
    /// </summary>
    let hasPurpose = _prefixId.prefix "hasPurpose"
    /// <summary>
    ///   <para>rdfs:label : has rule</para>
    ///   <para>rdfs:comment : Rule that defines this constraint</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasRule">sdont:hasRule</a>
    /// </summary>
    let hasRule = _prefixId.prefix "hasRule"
    /// <summary>
    ///   <para>rdfs:label : has sample execution</para>
    ///   <para>rdfs:comment : Property pointing to a sample execution of a software configuration</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasSampleExecution">sdont:hasSampleExecution</a>
    /// </summary>
    let hasSampleExecution = _prefixId.prefix "hasSampleExecution"
    /// <summary>
    ///   <para>rdfs:label : has sample result</para>
    ///   <para>rdfs:comment : Property designed to link a software configuration to a sample resource resulting from its execution^^xsd:string</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasSampleResult">sdont:hasSampleResult</a>
    /// </summary>
    let hasSampleResult = _prefixId.prefix "hasSampleResult"
    /// <summary>
    ///   <para>rdfs:label : has sample visualization</para>
    ///   <para>rdfs:comment : A typical sample visualization of the software outputs</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasSampleVisualization">sdont:hasSampleVisualization</a>
    /// </summary>
    let hasSampleVisualization = _prefixId.prefix "hasSampleVisualization"
    /// <summary>
    ///   <para>rdfs:label : has setup</para>
    ///   <para>rdfs:comment : Property used to define configurations with some fixed resources and values. The rationale of this property is to allow predefined configurations</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasSetup">sdont:hasSetup</a>
    /// </summary>
    let hasSetup = _prefixId.prefix "hasSetup"
    /// <summary>
    ///   <para>rdfs:label : has short name</para>
    ///   <para>rdfs:comment : A short name (e.g., temperature) capturing the high-level concept of the variable</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasShortName">sdont:hasShortName</a>
    /// </summary>
    let hasShortName = _prefixId.prefix "hasShortName"
    /// <summary>
    ///   <para>rdfs:label : has software image</para>
    ///   <para>rdfs:comment : Function to link a function with its corresponding container</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasSoftwareImage">sdont:hasSoftwareImage</a>
    /// </summary>
    let hasSoftwareImage = _prefixId.prefix "hasSoftwareImage"
    /// <summary>
    ///   <para>rdfs:label : has source code</para>
    ///   <para>rdfs:comment : Property designed to link a software with its software source code (which may reside in a code repository such as GitHub)</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasSourceCode">sdont:hasSourceCode</a>
    /// </summary>
    let hasSourceCode = _prefixId.prefix "hasSourceCode"
    /// <summary>
    ///   <para>rdfs:label : has standard variable</para>
    ///   <para>rdfs:comment : the standard name of a variable</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasStandardVariable">sdont:hasStandardVariable</a>
    /// </summary>
    let hasStandardVariable = _prefixId.prefix "hasStandardVariable"
    /// <summary>
    ///   <para>rdfs:label : has step size</para>
    ///   <para>rdfs:comment : Property that determines what are the increments (step size) that are commonly used to vary a parameter. This is commonly used for automatically setting up software tests. For example, if I want to set up a model and try 30 reasonable values on a parameter, I may use the default value and the step size to create the appropriate increments. If the step size is 0.1 and the default value is 0, then I will will be able to create setups: 0, 0.1, 0.2...2.9,3</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasStepSize">sdont:hasStepSize</a>
    /// </summary>
    let hasStepSize = _prefixId.prefix "hasStepSize"
    /// <summary>
    ///   <para>rdfs:label : has support script location</para>
    ///   <para>rdfs:comment : Property that links to the location of scripts that may be used from the main runnable script.</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasSupportScriptLocation">sdont:hasSupportScriptLocation</a>
    /// </summary>
    let hasSupportScriptLocation = _prefixId.prefix "hasSupportScriptLocation"
    /// <summary>
    ///   <para>rdfs:label : has typical data source</para>
    ///   <para>rdfs:comment : Typical data sources that are used by a software component</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasTypicalDataSource">sdont:hasTypicalDataSource</a>
    /// </summary>
    let hasTypicalDataSource = _prefixId.prefix "hasTypicalDataSource"
    /// <summary>
    ///   <para>rdfs:label : has usage notes</para>
    ///   <para>rdfs:comment : Property that describes the usage considerations of a particular software. These notes capture the rationale of for that software configuration, along with an explanation for sample inputs, things to consider when running the model with data, etc.</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasUsageNotes">sdont:hasUsageNotes</a>
    /// </summary>
    let hasUsageNotes = _prefixId.prefix "hasUsageNotes"
    /// <summary>
    ///   <para>rdfs:label : has variable</para>
    ///   <para>rdfs:comment : Property that links a rule and the variable that will test it</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasVariable">sdont:hasVariable</a>
    /// </summary>
    let hasVariable = _prefixId.prefix "hasVariable"
    /// <summary>
    ///   <para>rdfs:label : has software version</para>
    ///   <para>rdfs:comment : Property designed to link a software component with its corresponding versions</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasVersion">sdont:hasVersion</a>
    /// </summary>
    let hasVersion = _prefixId.prefix "hasVersion"
    /// <summary>
    ///   <para>rdfs:label : has version id</para>
    ///   <para>rdfs:comment : Identifier of the version of this software</para>
    ///   <a href="https://w3id.org/okn/o/sd#hasVersionId">sdont:hasVersionId</a>
    /// </summary>
    let hasVersionId = _prefixId.prefix "hasVersionId"
    /// <summary>
    ///   <para>rdfs:label : identifier</para>
    ///   <para>rdfs:comment : Identifier of the resource being described</para>
    ///   <a href="https://w3id.org/okn/o/sd#identifier">sdont:identifier</a>
    /// </summary>
    let identifier = _prefixId.prefix "identifier"
    /// <summary>
    ///   <para>rdfs:label : is transformed from</para>
    ///   <para>rdfs:comment : Property that links a dataset specification from a model configuration or setup to the output from a target data transformation. This occurs when a data transformation produces several outputs, but only one of them is the one needed for a model</para>
    ///   <a href="https://w3id.org/okn/o/sd#isTransformedFrom">sdont:isTransformedFrom</a>
    /// </summary>
    let isTransformedFrom = _prefixId.prefix "isTransformedFrom"
    /// <summary>
    ///   <para>rdfs:label : issue tracker</para>
    ///   <para>rdfs:comment : Pointer to the issue tracker of a software component</para>
    ///   <a href="https://w3id.org/okn/o/sd#issueTracker">sdont:issueTracker</a>
    /// </summary>
    let issueTracker = _prefixId.prefix "issueTracker"
    /// <summary>
    ///   <para>rdfs:label : keywords</para>
    ///   <para>rdfs:comment : Keywords associated with a software component</para>
    ///   <a href="https://w3id.org/okn/o/sd#keywords">sdont:keywords</a>
    /// </summary>
    let keywords = _prefixId.prefix "keywords"
    /// <summary>
    ///   <para>rdfs:label : license</para>
    ///   <para>rdfs:comment : License of a software component or its source code</para>
    ///   <a href="https://w3id.org/okn/o/sd#license">sdont:license</a>
    /// </summary>
    let license = _prefixId.prefix "license"
    /// <summary>
    ///   <para>rdfs:label : logo</para>
    ///   <para>rdfs:comment : Property that links to the image used as logo for a software component</para>
    ///   <a href="https://w3id.org/okn/o/sd#logo">sdont:logo</a>
    /// </summary>
    let logo = _prefixId.prefix "logo"
    /// <summary>
    ///   <para>rdfs:label : memory requirements</para>
    ///   <para>rdfs:comment : Memory requirements of a software</para>
    ///   <a href="https://w3id.org/okn/o/sd#memoryRequirements">sdont:memoryRequirements</a>
    /// </summary>
    let memoryRequirements = _prefixId.prefix "memoryRequirements"
    /// <summary>
    ///   <para>rdfs:label : name</para>
    ///   <para>rdfs:comment : Name of the resource</para>
    ///   <a href="https://w3id.org/okn/o/sd#name">sdont:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>rdfs:label : operating systems</para>
    ///   <para>rdfs:comment : Operating systems under which a software component can operate</para>
    ///   <a href="https://w3id.org/okn/o/sd#operatingSystems">sdont:operatingSystems</a>
    /// </summary>
    let operatingSystems = _prefixId.prefix "operatingSystems"
    /// <summary>
    ///   <para>rdfs:label : part of dataset</para>
    ///   <para>rdfs:comment : Associates a presentation with a dataset where the presentation occurs</para>
    ///   <a href="https://w3id.org/okn/o/sd#partOfDataset">sdont:partOfDataset</a>
    /// </summary>
    let partOfDataset = _prefixId.prefix "partOfDataset"
    /// <summary>
    ///   <para>rdfs:label : path location</para>
    ///   <para>rdfs:comment : Property that indicates the relative path of an input or output with respect to the folder structure of the executable.
    ///
    /// For example, let's assume we have an input that has to exist in the folder `/datasets` or the executable will not work. This property ensures that this knowledge is captured for a given software component execution.
    ///
    /// In this case the property would capture this as follows:
    ///
    /// ```
    /// :input_prep a sd:DatasetSpecification .
    /// :input_prep rdfs:label "precipitation file" .
    /// :input_precip sd:pathLocation "/datasets/".
    /// ```</para>
    ///   <a href="https://w3id.org/okn/o/sd#pathLocation">sdont:pathLocation</a>
    /// </summary>
    let pathLocation = _prefixId.prefix "pathLocation"
    /// <summary>
    ///   <para>rdfs:label : position</para>
    ///   <para>rdfs:comment : Position of the parameter or input/output in the model configuration. This property is needed to know how to organize the I/O of the component on execution</para>
    ///   <a href="https://w3id.org/okn/o/sd#position">sdont:position</a>
    /// </summary>
    let position = _prefixId.prefix "position"
    /// <summary>
    ///   <para>rdfs:label : processor requirements</para>
    ///   <para>rdfs:comment : Processor requirements of a software component</para>
    ///   <a href="https://w3id.org/okn/o/sd#processorRequirements">sdont:processorRequirements</a>
    /// </summary>
    let processorRequirements = _prefixId.prefix "processorRequirements"
    /// <summary>
    ///   <para>rdfs:label : programming language</para>
    ///   <para>rdfs:comment : Language used to code a software component</para>
    ///   <a href="https://w3id.org/okn/o/sd#programmingLanguage">sdont:programmingLanguage</a>
    /// </summary>
    let programmingLanguage = _prefixId.prefix "programmingLanguage"
    /// <summary>
    ///   <para>rdfs:label : publisher</para>
    ///   <para>rdfs:comment : Publisher organization or person responsible for a software component</para>
    ///   <a href="https://w3id.org/okn/o/sd#publisher">sdont:publisher</a>
    /// </summary>
    let publisher = _prefixId.prefix "publisher"
    /// <summary>
    ///   <para>rdfs:label : readme</para>
    ///   <para>rdfs:comment : URl to the readme file of a software component</para>
    ///   <a href="https://w3id.org/okn/o/sd#readme">sdont:readme</a>
    /// </summary>
    let readme = _prefixId.prefix "readme"
    /// <summary>
    ///   <para>rdfs:label : recommended increment</para>
    ///   <para>rdfs:comment : Value that represents how a parameter should be incremented on each iteration of a software component execution. This value is important when preparing execution ensembles automatically, e.g., simulating crop production varying the parameter "fertilizer amount" in increments of 10%.</para>
    ///   <a href="https://w3id.org/okn/o/sd#recommendedIncrement">sdont:recommendedIncrement</a>
    /// </summary>
    let recommendedIncrement = _prefixId.prefix "recommendedIncrement"
    /// <summary>
    ///   <para>rdfs:label : reference publication</para>
    ///   <para>rdfs:comment : Main publication to cite for this software component</para>
    ///   <a href="https://w3id.org/okn/o/sd#referencePublication">sdont:referencePublication</a>
    /// </summary>
    let referencePublication = _prefixId.prefix "referencePublication"
    /// <summary>
    ///   <para>rdfs:label : screenshot</para>
    ///   <para>rdfs:comment : Image illustrating a snapshot of the target software</para>
    ///   <a href="https://w3id.org/okn/o/sd#screenshot">sdont:screenshot</a>
    /// </summary>
    let screenshot = _prefixId.prefix "screenshot"
    /// <summary>
    ///   <para>rdfs:label : short description^^xsd:string</para>
    ///   <para>rdfs:comment : A summarized description of the resource</para>
    ///   <a href="https://w3id.org/okn/o/sd#shortDescription">sdont:shortDescription</a>
    /// </summary>
    let shortDescription = _prefixId.prefix "shortDescription"
    /// <summary>
    ///   <para>rdfs:label : software requirements</para>
    ///   <para>rdfs:comment : Software requirements needed to install a software component</para>
    ///   <a href="https://w3id.org/okn/o/sd#softwareRequirements">sdont:softwareRequirements</a>
    /// </summary>
    let softwareRequirements = _prefixId.prefix "softwareRequirements"
    /// <summary>
    ///   <para>rdfs:label : status</para>
    ///   <para>rdfs:comment : Data property to indicate the status of a configuration setups. For example, to indicate that a setup has been executed in a platform, that the setup should notbe shown to users (it's an auxiliary setup), etc.</para>
    ///   <a href="https://w3id.org/okn/o/sd#status">sdont:status</a>
    /// </summary>
    let status = _prefixId.prefix "status"
    /// <summary>
    ///   <para>rdfs:label : support details</para>
    ///   <para>rdfs:comment : Property to link details, such as mailing lists in case a contact person is not provided</para>
    ///   <a href="https://w3id.org/okn/o/sd#supportDetails">sdont:supportDetails</a>
    /// </summary>
    let supportDetails = _prefixId.prefix "supportDetails"
    /// <summary>
    ///   <para>rdfs:label : tag</para>
    ///   <para>rdfs:comment : Tag used to annotate a version or a software configuration. This annotation is useful to show which version is the latest, or which version is deprecated. Supported tags are: "latest", "deprecated"</para>
    ///   <a href="https://w3id.org/okn/o/sd#tag">sdont:tag</a>
    /// </summary>
    let tag = _prefixId.prefix "tag"
    /// <summary>
    ///   <para>rdfs:label : useful for calculating index^^xsd:string</para>
    ///   <para>rdfs:comment : Property that indicates that a software component (or any of its outputs) can be used to calculate a particular index. The rationale for this property is that indices are usually calculated by applying post-processing steps to the outputs of a software component.</para>
    ///   <a href="https://w3id.org/okn/o/sd#usefulForCalculatingIndex">sdont:usefulForCalculatingIndex</a>
    /// </summary>
    let usefulForCalculatingIndex = _prefixId.prefix "usefulForCalculatingIndex"
    /// <summary>
    ///   <para>rdfs:label : uses unit</para>
    ///   <para>rdfs:comment : Property used to link a variable presentation or time interval to the unit they are represented in</para>
    ///   <a href="https://w3id.org/okn/o/sd#usesUnit">sdont:usesUnit</a>
    /// </summary>
    let usesUnit = _prefixId.prefix "usesUnit"
    /// <summary>
    ///   <para>rdfs:label : value</para>
    ///   <para>rdfs:comment : Value associated to the described entity</para>
    ///   <a href="https://w3id.org/okn/o/sd#value">sdont:value</a>
    /// </summary>
    let value = _prefixId.prefix "value"
    /// <summary>
    ///   <para>rdfs:label : was derived from setup</para>
    ///   <para>rdfs:comment : Property that links a setup to a previous version of that setup. This property is needed (for example) when creating snapshots of setups.</para>
    ///   <a href="https://w3id.org/okn/o/sd#wasDerivedFromSetup">sdont:wasDerivedFromSetup</a>
    /// </summary>
    let wasDerivedFromSetup = _prefixId.prefix "wasDerivedFromSetup"
    /// <summary>
    ///   <para>rdfs:label : was derived from software</para>
    ///   <para>rdfs:comment : Property that identifies the software used to create a visualization</para>
    ///   <a href="https://w3id.org/okn/o/sd#wasDerivedFromSoftware">sdont:wasDerivedFromSoftware</a>
    /// </summary>
    let wasDerivedFromSoftware = _prefixId.prefix "wasDerivedFromSoftware"
    /// <summary>
    ///   <para>rdfs:label : website</para>
    ///   <para>rdfs:comment : Website of the software</para>
    ///   <a href="https://w3id.org/okn/o/sd#website">sdont:website</a>
    /// </summary>
    let website = _prefixId.prefix "website"

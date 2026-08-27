namespace https.w3id.org.okn.o.sd.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sdont =
    let _namespace_iri = Namespace_Iri sdont |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:okn/o/sd#CatalogIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class to identify that a parameter is a catalog identifier. The rationale for this type of parameter is that in some cases datasets may be downloaded in the software component itself, rather than exposed as an input"</para>
    /// labels<para>"Catalog identifier"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#CatalogIdentifier">https://w3id.org/okn/o/sd#CatalogIdentifier</seealso>
    let CatalogIdentifier = Prefixed_Name(sdont, "CatalogIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#ConfigurationSetup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Special type of configuration in which some of the inputs or parameters are associated to files or values. A configuration may be associated to multiple setups to facilitate its execution."</para>
    /// labels<para>"Configuration Setup"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#ConfigurationSetup">https://w3id.org/okn/o/sd#ConfigurationSetup</seealso>
    let ConfigurationSetup = Prefixed_Name(sdont, "ConfigurationSetup") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#Constraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Data constraints of a configuration"</para>
    /// labels<para>"Constraint"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#Constraint">https://w3id.org/okn/o/sd#Constraint</seealso>
    let Constraint = Prefixed_Name(sdont, "Constraint") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#DataTransformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents a software for performing data transformation."</para>
    /// labels<para>"Data Transformation"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#DataTransformation">https://w3id.org/okn/o/sd#DataTransformation</seealso>
    let DataTransformation = Prefixed_Name(sdont, "DataTransformation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#DataTransformationSetup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Special type of data transformation where the inputs and parameters have some pre-selected values. For example, they may point to a particular dataset URL to be used in the transformation"</para>
    /// labels<para>"Data Transformation Setup"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#DataTransformationSetup">https://w3id.org/okn/o/sd#DataTransformationSetup</seealso>
    let DataTransformationSetup =
        Prefixed_Name(sdont, "DataTransformationSetup") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#DatasetSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class designed to describe a type of input or output used or produced by a model. For example, Topoflow has several inputs. One of them is a text file with precipitation values. The representation of this input is an instance of a dataset specification."</para>
    /// labels<para>"Dataset Specification"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#DatasetSpecification">https://w3id.org/okn/o/sd#DatasetSpecification</seealso>
    let DatasetSpecification =
        Prefixed_Name(sdont, "DatasetSpecification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#FundingInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A class to represent the funding information of a software project"</para>
    /// labels<para>"Funding Information"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#FundingInformation">https://w3id.org/okn/o/sd#FundingInformation</seealso>
    let FundingInformation = Prefixed_Name(sdont, "FundingInformation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#Image</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An image (e.g. tiff file) is a type of dataset specification used to define certain inputs of models like soil, crops, etc."</para>
    /// labels<para>"Image"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#Image">https://w3id.org/okn/o/sd#Image</seealso>
    let Image = Prefixed_Name(sdont, "Image") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#NumericalIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A number (such as a ratio) derived from a series of observations and used as an indicator or measure (https://www.merriam-webster.com/dictionary/index)"</para>
    /// labels<para>"Numerical Index"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#NumericalIndex">https://w3id.org/okn/o/sd#NumericalIndex</seealso>
    let NumericalIndex = Prefixed_Name(sdont, "NumericalIndex") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An organized body of people with a particular purpose"</para>
    /// labels<para>"Organization"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#Organization">https://w3id.org/okn/o/sd#Organization</seealso>
    let Organization = Prefixed_Name(sdont, "Organization") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#Parameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A parameter of the model."</para>
    /// labels<para>"Parameter"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#Parameter">https://w3id.org/okn/o/sd#Parameter</seealso>
    let Parameter = Prefixed_Name(sdont, "Parameter") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A human being (individual)"</para>
    /// labels<para>"Person"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#Person">https://w3id.org/okn/o/sd#Person</seealso>
    let Person = Prefixed_Name(sdont, "Person") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#SampleCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collection of resources that are used as sample for running a sfoware component multiple times"</para>
    /// labels<para>"Sample Collection"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#SampleCollection">https://w3id.org/okn/o/sd#SampleCollection</seealso>
    let SampleCollection = Prefixed_Name(sdont, "SampleCollection") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#SampleExecution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sample execution of a given software"</para>
    /// labels<para>"Sample Execution"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#SampleExecution">https://w3id.org/okn/o/sd#SampleExecution</seealso>
    let SampleExecution = Prefixed_Name(sdont, "SampleExecution") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#SampleResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sample resource associated with a software"</para>
    /// labels<para>"Sample Resource"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#SampleResource">https://w3id.org/okn/o/sd#SampleResource</seealso>
    let SampleResource = Prefixed_Name(sdont, "SampleResource") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#Software</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The set of instructions that indicate a machine how to work. In this ontology software is a general concept which acts as a superclass for software versions, docker images, data transformations, etc."</para>
    /// labels<para>"Software"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#Software">https://w3id.org/okn/o/sd#Software</seealso>
    let Software = Prefixed_Name(sdont, "Software") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#SoftwareConfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A software configuration represents a particular way of invoking a function of a software component. A software configuration exposes the precise inputs and outputs that are used for that function. Multiple software configurations may be associated to a software component. A software configuration facilitates the encapsulation of software, and it can be used to represent components of scientific workflows."</para>
    /// labels<para>"Software Configuration"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#SoftwareConfiguration">https://w3id.org/okn/o/sd#SoftwareConfiguration</seealso>
    let SoftwareConfiguration =
        Prefixed_Name(sdont, "SoftwareConfiguration") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#SoftwareImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An image that virtualizes the functionality of a given software. For example, a Docker container."</para>
    /// labels<para>"Software Image"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#SoftwareImage">https://w3id.org/okn/o/sd#SoftwareImage</seealso>
    let SoftwareImage = Prefixed_Name(sdont, "SoftwareImage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#SoftwareVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A software version is a specificf type of software that represents a particular set of functionalities. New functionalities and error fixes may occur between software versions"</para>
    /// labels<para>"Software Version"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#SoftwareVersion">https://w3id.org/okn/o/sd#SoftwareVersion</seealso>
    let SoftwareVersion = Prefixed_Name(sdont, "SoftwareVersion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#SourceCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class representing the characteristics of the code associated with a  software component"</para>
    /// labels<para>"Source Code"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#SourceCode">https://w3id.org/okn/o/sd#SourceCode</seealso>
    let SourceCode = Prefixed_Name(sdont, "SourceCode") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#StandardVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A standard variable, necessary to refer to all the variable using the same nomenclature in a domain ontology. For example, a standard variable may be a SVO variable (http://www.geoscienceontology.org/geo-upper#Variable)"</para>
    /// labels<para>"Standard Variable"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#StandardVariable">https://w3id.org/okn/o/sd#StandardVariable</seealso>
    let StandardVariable = Prefixed_Name(sdont, "StandardVariable") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#Unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class designed to distinguish the different types of units that are available in variables from datasets or parameters"</para>
    /// labels<para>"Unit"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#Unit">https://w3id.org/okn/o/sd#Unit</seealso>
    let Unit = Prefixed_Name(sdont, "Unit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#Variable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A symbol that represents a quanity in a dataset or dataset specification"</para>
    /// labels<para>"Variable"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#Variable">https://w3id.org/okn/o/sd#Variable</seealso>
    let Variable = Prefixed_Name(sdont, "Variable") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#VariablePresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Concept used to represent an instantiation of a variable in an input/output dataset. For example, a model A may use an input file with temperature expressed in Farenheit (variablePresentation1), while a model B may produce an output with temperature in Celsius (variablePresentation2). Both variable presentations refer to the concept of temperature."</para>
    /// labels<para>"Variable presentation"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#VariablePresentation">https://w3id.org/okn/o/sd#VariablePresentation</seealso>
    let VariablePresentation =
        Prefixed_Name(sdont, "VariablePresentation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#Visualization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class to represent any type of visualization related to a software. For example, a dynamic HTML page, a video, etc."</para>
    /// labels<para>"Visualization"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#Visualization">https://w3id.org/okn/o/sd#Visualization</seealso>
    let Visualization = Prefixed_Name(sdont, "Visualization") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#adjustableParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Parameter that can be adjusted in a configuration setup"</para>
    /// labels<para>"adjustable parameter"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#adjustableParameter">https://w3id.org/okn/o/sd#adjustableParameter</seealso>
    let adjustableParameter =
        Prefixed_Name(sdont, "adjustableParameter") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#adjustsVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Property that links parameter with the variable they adjust. This property can be used when parameters quantify variables without directly representing them. For example, a "fertilizer percentage adjustment" parameter can quantify a "fertilizer price" variable"</para>
    /// labels<para>"adjusts variable"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#adjustsVariable">https://w3id.org/okn/o/sd#adjustsVariable</seealso>
    let adjustsVariable = Prefixed_Name(sdont, "adjustsVariable") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#author</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The creator of a software component"</para>
    /// labels<para>"author"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#author">https://w3id.org/okn/o/sd#author</seealso>
    let author = Prefixed_Name(sdont, "author") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#availableInRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Property that indicates in which registry the software image being described can be found. For example, https://hub.docker.com"</para>
    /// labels<para>"available in registry"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#availableInRegistry">https://w3id.org/okn/o/sd#availableInRegistry</seealso>
    let availableInRegistry =
        Prefixed_Name(sdont, "availableInRegistry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#citation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"How to cite this software"</para>
    /// labels<para>"citation"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#citation">https://w3id.org/okn/o/sd#citation</seealso>
    let citation = Prefixed_Name(sdont, "citation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#codeRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"URL to the code repository of a software component"</para>
    /// labels<para>"code repository"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#codeRepository">https://w3id.org/okn/o/sd#codeRepository</seealso>
    let codeRepository = Prefixed_Name(sdont, "codeRepository") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#compatibleVisualizationSoftware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property that links a software component to other useful software that canbe used to visualize its outputs"</para>
    /// labels<para>"compatible visualization software"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#compatibleVisualizationSoftware">https://w3id.org/okn/o/sd#compatibleVisualizationSoftware</seealso>
    let compatibleVisualizationSoftware =
        Prefixed_Name(sdont, "compatibleVisualizationSoftware") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#contributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Contributor to a software component"</para>
    /// labels<para>"contributor"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#contributor">https://w3id.org/okn/o/sd#contributor</seealso>
    let contributor = Prefixed_Name(sdont, "contributor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#copyrightHolder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Copyright holder for a software component"</para>
    /// labels<para>"copyright holder"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#copyrightHolder">https://w3id.org/okn/o/sd#copyrightHolder</seealso>
    let copyrightHolder = Prefixed_Name(sdont, "copyrightHolder") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#copyrightYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Year in which the software component was copyrighted"</para>
    /// labels<para>"copyright year"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#copyrightYear">https://w3id.org/okn/o/sd#copyrightYear</seealso>
    let copyrightYear = Prefixed_Name(sdont, "copyrightYear") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#dataCatalogIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An identifier for resources with metadata entries in a data catalog"</para>
    /// labels<para>"data catalog identifier"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#dataCatalogIdentifier">https://w3id.org/okn/o/sd#dataCatalogIdentifier</seealso>
    let dataCatalogIdentifier =
        Prefixed_Name(sdont, "dataCatalogIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#dateCreated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Date when a software component was created"</para>
    /// labels<para>"date created"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#dateCreated">https://w3id.org/okn/o/sd#dateCreated</seealso>
    let dateCreated = Prefixed_Name(sdont, "dateCreated") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#datePublished</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Date when a software component was published"</para>
    /// labels<para>"date published"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#datePublished">https://w3id.org/okn/o/sd#datePublished</seealso>
    let datePublished = Prefixed_Name(sdont, "datePublished") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A description of a resource"</para>
    /// labels<para>"description"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#description">https://w3id.org/okn/o/sd#description</seealso>
    let description = Prefixed_Name(sdont, "description") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#doi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Digital Object Identifier associated with a software component"</para>
    /// labels<para>"doi"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#doi">https://w3id.org/okn/o/sd#doi</seealso>
    let doi = Prefixed_Name(sdont, "doi") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#email</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Email of a person"</para>
    /// labels<para>"email"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#email">https://w3id.org/okn/o/sd#email</seealso>
    let email = Prefixed_Name(sdont, "email") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#fundingGrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Grant number used for funding"</para>
    /// labels<para>"funding grant"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#fundingGrant">https://w3id.org/okn/o/sd#fundingGrant</seealso>
    let fundingGrant = Prefixed_Name(sdont, "fundingGrant") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#fundingSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Link to the organization funding a software component"</para>
    /// labels<para>"funding source"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#fundingSource">https://w3id.org/okn/o/sd#fundingSource</seealso>
    let fundingSource = Prefixed_Name(sdont, "fundingSource") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#hadPrimarySource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Property to identify the original source of the information of the annotated resource. It could be a web page, an organization, a person, some experiment notes, etc."</para>
    /// labels<para>"had primary source"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hadPrimarySource">https://w3id.org/okn/o/sd#hadPrimarySource</seealso>
    let hadPrimarySource = Prefixed_Name(sdont, "hadPrimarySource") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#hasAcceptedValues</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Property that constraints which values are accepted for a parameter. For example, the name of a crop can only be "Maize" or "Sorghum""</para>
    /// labels<para>"has accepted values"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasAcceptedValues">https://w3id.org/okn/o/sd#hasAcceptedValues</seealso>
    let hasAcceptedValues = Prefixed_Name(sdont, "hasAcceptedValues") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#hasAcknowledgements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"String with the people, organizations and other contributors acknowledged by the authors."</para>
    /// labels<para>"has acknowledgements"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasAcknowledgements">https://w3id.org/okn/o/sd#hasAcknowledgements</seealso>
    let hasAcknowledgements =
        Prefixed_Name(sdont, "hasAcknowledgements") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#hasAssumption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Assumptions of a software, e.g. the solver being used for a particular model, the source of the data (e.g., all data must have a given resolution), etc."</para>
    /// labels<para>"has assumption"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasAssumption">https://w3id.org/okn/o/sd#hasAssumption</seealso>
    let hasAssumption = Prefixed_Name(sdont, "hasAssumption") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#hasBuildFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A file (e.g., Dockerfile) with executable instructions indicating how a Software Image or a Software component is built"</para>
    /// labels<para>"has build file"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasBuildFile">https://w3id.org/okn/o/sd#hasBuildFile</seealso>
    let hasBuildFile = Prefixed_Name(sdont, "hasBuildFile") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#hasCodeOfConduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"Property linking the software component to the code of conduct to be followed by potential contributors. The range of this property may be a strin or a URI to the target file."</para>
    /// labels<para>"has code of conduct"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasCodeOfConduct">https://w3id.org/okn/o/sd#hasCodeOfConduct</seealso>
    let hasCodeOfConduct = Prefixed_Name(sdont, "hasCodeOfConduct") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#hasComponentLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Location of the aggregation of all the files needed to execute the component. Usually a zip file including the run script and support scripts, including specification files"</para>
    /// labels<para>"has component location"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasComponentLocation">https://w3id.org/okn/o/sd#hasComponentLocation</seealso>
    let hasComponentLocation =
        Prefixed_Name(sdont, "hasComponentLocation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#hasConfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property that links a model to one of its configurations. A model may have multiple configurations, each of which is unique in terms of the inputs and outputs it uses."</para>
    /// labels<para>"has configuration"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasConfiguration">https://w3id.org/okn/o/sd#hasConfiguration</seealso>
    let hasConfiguration = Prefixed_Name(sdont, "hasConfiguration") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#hasConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Constraint or rule associated to a  variable or software configuration. For example: "This model accepts only monthly data", or "all inputs of this model configuration must share the same location". More structured restrictions, such as Jena rules or SWRL rules may also be captured with this property"</para>
    /// labels<para>"has constraint"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasConstraint">https://w3id.org/okn/o/sd#hasConstraint</seealso>
    let hasConstraint = Prefixed_Name(sdont, "hasConstraint") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#hasContactPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Contact person responsible for a software component"</para>
    /// labels<para>"has contact person"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasContactPerson">https://w3id.org/okn/o/sd#hasContactPerson</seealso>
    let hasContactPerson = Prefixed_Name(sdont, "hasContactPerson") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#hasDataTransformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property that associates an input/output with their corresponding data transformation."</para>
    /// labels<para>"has data transformation"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasDataTransformation">https://w3id.org/okn/o/sd#hasDataTransformation</seealso>
    let hasDataTransformation =
        Prefixed_Name(sdont, "hasDataTransformation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#hasDataTransformationSetup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property to link an input/output dataset to the specific data transformation (with URLs"</para>
    /// labels<para>"has data transformation setup"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasDataTransformationSetup">https://w3id.org/okn/o/sd#hasDataTransformationSetup</seealso>
    let hasDataTransformationSetup =
        Prefixed_Name(sdont, "hasDataTransformationSetup") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#hasDataType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Property that indicates the data type of a parameter"</para>
    /// labels<para>"has data type"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasDataType">https://w3id.org/okn/o/sd#hasDataType</seealso>
    let hasDataType = Prefixed_Name(sdont, "hasDataType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#hasDefaultValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Default accepted value of a variable presentation (or a parameter)"</para>
    /// labels<para>"has default value"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasDefaultValue">https://w3id.org/okn/o/sd#hasDefaultValue</seealso>
    let hasDefaultValue = Prefixed_Name(sdont, "hasDefaultValue") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#hasDimensionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Property to indicate dimensionality of the input or output of a dataset specification"</para>
    /// labels<para>"has dimensionality"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasDimensionality">https://w3id.org/okn/o/sd#hasDimensionality</seealso>
    let hasDimensionality = Prefixed_Name(sdont, "hasDimensionality") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#hasDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Pointer to the documentation of the model"</para>
    /// labels<para>"has documentation"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasDocumentation">https://w3id.org/okn/o/sd#hasDocumentation</seealso>
    let hasDocumentation = Prefixed_Name(sdont, "hasDocumentation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#hasDownloadInstructions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Instructions needed to download a software component. The difference with `hasDownloadURL` is that this property captures the human readable instructions required to download software. For example, sometimes an authentication is needed, users need to fill in a form, etc."</para>
    /// labels<para>"has download instructions"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasDownloadInstructions">https://w3id.org/okn/o/sd#hasDownloadInstructions</seealso>
    let hasDownloadInstructions =
        Prefixed_Name(sdont, "hasDownloadInstructions") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#hasDownloadURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Download URL where to obtain the source/executable of the software"</para>
    /// labels<para>"has download URL"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasDownloadURL">https://w3id.org/okn/o/sd#hasDownloadURL</seealso>
    let hasDownloadURL = Prefixed_Name(sdont, "hasDownloadURL") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#hasExample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An example explaining a scenario where the software component was used in plain language."</para>
    /// labels<para>"has example"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasExample">https://w3id.org/okn/o/sd#hasExample</seealso>
    let hasExample = Prefixed_Name(sdont, "hasExample") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#hasExecutableInstructions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Instructions that indicate how a software component should be executed. The difference with `hasExecutionCommand` is that the execution instructions aim to be human-readable, and have explanations between the different commands and instructions"</para>
    /// labels<para>"has executable instructions"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasExecutableInstructions">https://w3id.org/okn/o/sd#hasExecutableInstructions</seealso>
    let hasExecutableInstructions =
        Prefixed_Name(sdont, "hasExecutableInstructions") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#hasExecutableNotebook</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Property that links a software component with an executable notebook (e.g., Jupyter notebook) that illustrates how to use it in an executable manner."</para>
    /// labels<para>"has executable notebook"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasExecutableNotebook">https://w3id.org/okn/o/sd#hasExecutableNotebook</seealso>
    let hasExecutableNotebook =
        Prefixed_Name(sdont, "hasExecutableNotebook") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#hasExecutionCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Execution instructions on how to run the image"</para>
    /// labels<para>"has execution command"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasExecutionCommand">https://w3id.org/okn/o/sd#hasExecutionCommand</seealso>
    let hasExecutionCommand =
        Prefixed_Name(sdont, "hasExecutionCommand") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#hasFAQ</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Frequently asked questions about a software"</para>
    /// labels<para>"has FAQ"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasFAQ">https://w3id.org/okn/o/sd#hasFAQ</seealso>
    let hasFAQ = Prefixed_Name(sdont, "hasFAQ") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#hasFileStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Relates a dataset specification to the data structure definition"</para>
    /// labels<para>"has file structure"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasFileStructure">https://w3id.org/okn/o/sd#hasFileStructure</seealso>
    let hasFileStructure = Prefixed_Name(sdont, "hasFileStructure") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#hasFixedResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property that links a parameter or an input to a fixed value. For example, in a given configuration a parameter with the planting date for a model could be fixed to avoid the user changing it for that region."</para>
    /// labels<para>"has fixed resource"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasFixedResource">https://w3id.org/okn/o/sd#hasFixedResource</seealso>
    let hasFixedResource = Prefixed_Name(sdont, "hasFixedResource") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#hasFixedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"Value of a parameter in a software setup."</para>
    /// labels<para>"has fixed value"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasFixedValue">https://w3id.org/okn/o/sd#hasFixedValue</seealso>
    let hasFixedValue = Prefixed_Name(sdont, "hasFixedValue") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#hasFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Format followed by a file. For example, txt, nc, etc."</para>
    /// labels<para>"has format"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasFormat">https://w3id.org/okn/o/sd#hasFormat</seealso>
    let hasFormat = Prefixed_Name(sdont, "hasFormat") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#hasFunding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property that links a software project to its funding information"</para>
    /// labels<para>"has funding information"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasFunding">https://w3id.org/okn/o/sd#hasFunding</seealso>
    let hasFunding = Prefixed_Name(sdont, "hasFunding") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#hasImplementationScriptLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Property that points to the main runnable script for the current function"</para>
    /// labels<para>"has implementation script location"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasImplementationScriptLocation">https://w3id.org/okn/o/sd#hasImplementationScriptLocation</seealso>
    let hasImplementationScriptLocation =
        Prefixed_Name(sdont, "hasImplementationScriptLocation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#hasInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property that links a model configuration to the input types expected by it."</para>
    /// labels<para>"has input"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasInput">https://w3id.org/okn/o/sd#hasInput</seealso>
    let hasInput = Prefixed_Name(sdont, "hasInput") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#hasInstallationInstructions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Instructions required to install this particular piece of software. Installation instructions usually are available in a human-readable manner."</para>
    /// labels<para>"has installation instructions"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasInstallationInstructions">https://w3id.org/okn/o/sd#hasInstallationInstructions</seealso>
    let hasInstallationInstructions =
        Prefixed_Name(sdont, "hasInstallationInstructions") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#hasLongName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Properties that relate the variable representation to its long name. The long name is useful for context (e.g., precipitation is less ambiguous than P) but not as precise as the standard name."</para>
    /// labels<para>"has long name"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasLongName">https://w3id.org/okn/o/sd#hasLongName</seealso>
    let hasLongName = Prefixed_Name(sdont, "hasLongName") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#hasMaximumAcceptedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"Maximum accepted value of a variable presentation (or a parameter)"</para>
    /// labels<para>"has maximum accepted value"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasMaximumAcceptedValue">https://w3id.org/okn/o/sd#hasMaximumAcceptedValue</seealso>
    let hasMaximumAcceptedValue =
        Prefixed_Name(sdont, "hasMaximumAcceptedValue") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#hasMinimumAcceptedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Minimum accepted value of a variable presentation (or a parameter)"</para>
    /// labels<para>"has minimum accepted value"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasMinimumAcceptedValue">https://w3id.org/okn/o/sd#hasMinimumAcceptedValue</seealso>
    let hasMinimumAcceptedValue =
        Prefixed_Name(sdont, "hasMinimumAcceptedValue") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#hasOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property that expresses what are the outputs of a model"</para>
    /// labels<para>"has output"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasOutput">https://w3id.org/okn/o/sd#hasOutput</seealso>
    let hasOutput = Prefixed_Name(sdont, "hasOutput") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#hasParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property that indicates the parameters of a model configuration"</para>
    /// labels<para>"has parameter"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasParameter">https://w3id.org/okn/o/sd#hasParameter</seealso>
    let hasParameter = Prefixed_Name(sdont, "hasParameter") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#hasPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property designed to reference the elements included in a sample collection."</para>
    /// labels<para>"has part"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasPart">https://w3id.org/okn/o/sd#hasPart</seealso>
    let hasPart = Prefixed_Name(sdont, "hasPart") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#hasPresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property that links an instance of a dataset (or a dataset specification) to the presentation of a variable contained (or expected to be contained) on it."</para>
    /// labels<para>"has presentation"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasPresentation">https://w3id.org/okn/o/sd#hasPresentation</seealso>
    let hasPresentation = Prefixed_Name(sdont, "hasPresentation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#hasPurpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Objective or main functionality that can be achieved by running this software"</para>
    /// labels<para>"has purpose"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasPurpose">https://w3id.org/okn/o/sd#hasPurpose</seealso>
    let hasPurpose = Prefixed_Name(sdont, "hasPurpose") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#hasRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Rule that defines this constraint"</para>
    /// labels<para>"has rule"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasRule">https://w3id.org/okn/o/sd#hasRule</seealso>
    let hasRule = Prefixed_Name(sdont, "hasRule") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#hasSampleExecution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property pointing to a sample execution of a software configuration"</para>
    /// labels<para>"has sample execution"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasSampleExecution">https://w3id.org/okn/o/sd#hasSampleExecution</seealso>
    let hasSampleExecution = Prefixed_Name(sdont, "hasSampleExecution") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#hasSampleResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property designed to link a software configuration to a sample resource resulting from its execution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has sample result"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasSampleResult">https://w3id.org/okn/o/sd#hasSampleResult</seealso>
    let hasSampleResult = Prefixed_Name(sdont, "hasSampleResult") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#hasSampleVisualization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A typical sample visualization of the software outputs"</para>
    /// labels<para>"has sample visualization"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasSampleVisualization">https://w3id.org/okn/o/sd#hasSampleVisualization</seealso>
    let hasSampleVisualization =
        Prefixed_Name(sdont, "hasSampleVisualization") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#hasSetup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property used to define configurations with some fixed resources and values. The rationale of this property is to allow predefined configurations"</para>
    /// labels<para>"has setup"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasSetup">https://w3id.org/okn/o/sd#hasSetup</seealso>
    let hasSetup = Prefixed_Name(sdont, "hasSetup") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#hasShortName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A short name (e.g., temperature) capturing the high-level concept of the variable"</para>
    /// labels<para>"has short name"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasShortName">https://w3id.org/okn/o/sd#hasShortName</seealso>
    let hasShortName = Prefixed_Name(sdont, "hasShortName") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#hasSoftwareImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Function to link a function with its corresponding container"</para>
    /// labels<para>"has software image"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasSoftwareImage">https://w3id.org/okn/o/sd#hasSoftwareImage</seealso>
    let hasSoftwareImage = Prefixed_Name(sdont, "hasSoftwareImage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#hasSourceCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Property designed to link a software with its software source code (which may reside in a code repository such as GitHub)"</para>
    /// labels<para>"has source code"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasSourceCode">https://w3id.org/okn/o/sd#hasSourceCode</seealso>
    let hasSourceCode = Prefixed_Name(sdont, "hasSourceCode") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#hasStandardVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"the standard name of a variable"</para>
    /// labels<para>"has standard variable"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasStandardVariable">https://w3id.org/okn/o/sd#hasStandardVariable</seealso>
    let hasStandardVariable =
        Prefixed_Name(sdont, "hasStandardVariable") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#hasStepSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Property that determines what are the increments (step size) that are commonly used to vary a parameter. This is commonly used for automatically setting up software tests. For example, if I want to set up a model and try 30 reasonable values on a parameter, I may use the default value and the step size to create the appropriate increments. If the step size is 0.1 and the default value is 0, then I will will be able to create setups: 0, 0.1, 0.2...2.9,3"</para>
    /// labels<para>"has step size"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasStepSize">https://w3id.org/okn/o/sd#hasStepSize</seealso>
    let hasStepSize = Prefixed_Name(sdont, "hasStepSize") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#hasSupportScriptLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Property that links to the location of scripts that may be used from the main runnable script."</para>
    /// labels<para>"has support script location"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasSupportScriptLocation">https://w3id.org/okn/o/sd#hasSupportScriptLocation</seealso>
    let hasSupportScriptLocation =
        Prefixed_Name(sdont, "hasSupportScriptLocation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#hasTypicalDataSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Typical data sources that are used by a software component"</para>
    /// labels<para>"has typical data source"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasTypicalDataSource">https://w3id.org/okn/o/sd#hasTypicalDataSource</seealso>
    let hasTypicalDataSource =
        Prefixed_Name(sdont, "hasTypicalDataSource") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#hasUsageNotes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Property that describes the usage considerations of a particular software. These notes capture the rationale of for that software configuration, along with an explanation for sample inputs, things to consider when running the model with data, etc."</para>
    /// labels<para>"has usage notes"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasUsageNotes">https://w3id.org/okn/o/sd#hasUsageNotes</seealso>
    let hasUsageNotes = Prefixed_Name(sdont, "hasUsageNotes") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#hasVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property that links a rule and the variable that will test it"</para>
    /// labels<para>"has variable"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasVariable">https://w3id.org/okn/o/sd#hasVariable</seealso>
    let hasVariable = Prefixed_Name(sdont, "hasVariable") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#hasVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property designed to link a software component with its corresponding versions"</para>
    /// labels<para>"has software version"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasVersion">https://w3id.org/okn/o/sd#hasVersion</seealso>
    let hasVersion = Prefixed_Name(sdont, "hasVersion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#hasVersionId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Identifier of the version of this software"</para>
    /// labels<para>"has version id"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#hasVersionId">https://w3id.org/okn/o/sd#hasVersionId</seealso>
    let hasVersionId = Prefixed_Name(sdont, "hasVersionId") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Identifier of the resource being described"</para>
    /// labels<para>"identifier"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#identifier">https://w3id.org/okn/o/sd#identifier</seealso>
    let identifier = Prefixed_Name(sdont, "identifier") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#isTransformedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property that links a dataset specification from a model configuration or setup to the output from a target data transformation. This occurs when a data transformation produces several outputs, but only one of them is the one needed for a model"</para>
    /// labels<para>"is transformed from"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#isTransformedFrom">https://w3id.org/okn/o/sd#isTransformedFrom</seealso>
    let isTransformedFrom = Prefixed_Name(sdont, "isTransformedFrom") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#issueTracker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Pointer to the issue tracker of a software component"</para>
    /// labels<para>"issue tracker"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#issueTracker">https://w3id.org/okn/o/sd#issueTracker</seealso>
    let issueTracker = Prefixed_Name(sdont, "issueTracker") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#keywords</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Keywords associated with a software component"</para>
    /// labels<para>"keywords"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#keywords">https://w3id.org/okn/o/sd#keywords</seealso>
    let keywords = Prefixed_Name(sdont, "keywords") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#license</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"License of a software component or its source code"</para>
    /// labels<para>"license"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#license">https://w3id.org/okn/o/sd#license</seealso>
    let license = Prefixed_Name(sdont, "license") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#logo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property that links to the image used as logo for a software component"</para>
    /// labels<para>"logo"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#logo">https://w3id.org/okn/o/sd#logo</seealso>
    let logo = Prefixed_Name(sdont, "logo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#memoryRequirements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Memory requirements of a software"</para>
    /// labels<para>"memory requirements"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#memoryRequirements">https://w3id.org/okn/o/sd#memoryRequirements</seealso>
    let memoryRequirements = Prefixed_Name(sdont, "memoryRequirements") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Name of the resource"</para>
    /// labels<para>"name"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#name">https://w3id.org/okn/o/sd#name</seealso>
    let name = Prefixed_Name(sdont, "name") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#operatingSystems</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Operating systems under which a software component can operate"</para>
    /// labels<para>"operating systems"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#operatingSystems">https://w3id.org/okn/o/sd#operatingSystems</seealso>
    let operatingSystems = Prefixed_Name(sdont, "operatingSystems") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#partOfDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associates a presentation with a dataset where the presentation occurs"</para>
    /// labels<para>"part of dataset"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#partOfDataset">https://w3id.org/okn/o/sd#partOfDataset</seealso>
    let partOfDataset = Prefixed_Name(sdont, "partOfDataset") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#pathLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Property that indicates the relative path of an input or output with respect to the folder structure of the executable.
    ///
    /// For example, let's assume we have an input that has to exist in the folder `/datasets` or the executable will not work. This property ensures that this knowledge is captured for a given software component execution.
    ///
    /// In this case the property would capture this as follows:
    ///
    /// ```
    /// :input_prep a sd:DatasetSpecification .
    /// :input_prep rdfs:label "precipitation file" .
    /// :input_precip sd:pathLocation "/datasets/".
    /// ```"</para>
    /// labels<para>"path location"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#pathLocation">https://w3id.org/okn/o/sd#pathLocation</seealso>
    let pathLocation = Prefixed_Name(sdont, "pathLocation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#position</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Position of the parameter or input/output in the model configuration. This property is needed to know how to organize the I/O of the component on execution"</para>
    /// labels<para>"position"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#position">https://w3id.org/okn/o/sd#position</seealso>
    let position = Prefixed_Name(sdont, "position") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#processorRequirements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Processor requirements of a software component"</para>
    /// labels<para>"processor requirements"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#processorRequirements">https://w3id.org/okn/o/sd#processorRequirements</seealso>
    let processorRequirements =
        Prefixed_Name(sdont, "processorRequirements") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#programmingLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Language used to code a software component"</para>
    /// labels<para>"programming language"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#programmingLanguage">https://w3id.org/okn/o/sd#programmingLanguage</seealso>
    let programmingLanguage =
        Prefixed_Name(sdont, "programmingLanguage") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#publisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Publisher organization or person responsible for a software component"</para>
    /// labels<para>"publisher"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#publisher">https://w3id.org/okn/o/sd#publisher</seealso>
    let publisher = Prefixed_Name(sdont, "publisher") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#readme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"URl to the readme file of a software component"</para>
    /// labels<para>"readme"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#readme">https://w3id.org/okn/o/sd#readme</seealso>
    let readme = Prefixed_Name(sdont, "readme") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#recommendedIncrement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Value that represents how a parameter should be incremented on each iteration of a software component execution. This value is important when preparing execution ensembles automatically, e.g., simulating crop production varying the parameter "fertilizer amount" in increments of 10%."</para>
    /// labels<para>"recommended increment"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#recommendedIncrement">https://w3id.org/okn/o/sd#recommendedIncrement</seealso>
    let recommendedIncrement =
        Prefixed_Name(sdont, "recommendedIncrement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#referencePublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Main publication to cite for this software component"</para>
    /// labels<para>"reference publication"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#referencePublication">https://w3id.org/okn/o/sd#referencePublication</seealso>
    let referencePublication =
        Prefixed_Name(sdont, "referencePublication") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#screenshot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Image illustrating a snapshot of the target software"</para>
    /// labels<para>"screenshot"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#screenshot">https://w3id.org/okn/o/sd#screenshot</seealso>
    let screenshot = Prefixed_Name(sdont, "screenshot") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#shortDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A summarized description of the resource"</para>
    /// labels<para>"short description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#shortDescription">https://w3id.org/okn/o/sd#shortDescription</seealso>
    let shortDescription = Prefixed_Name(sdont, "shortDescription") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#softwareRequirements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Software requirements needed to install a software component"</para>
    /// labels<para>"software requirements"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#softwareRequirements">https://w3id.org/okn/o/sd#softwareRequirements</seealso>
    let softwareRequirements =
        Prefixed_Name(sdont, "softwareRequirements") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Data property to indicate the status of a configuration setups. For example, to indicate that a setup has been executed in a platform, that the setup should notbe shown to users (it's an auxiliary setup), etc."</para>
    /// labels<para>"status"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#status">https://w3id.org/okn/o/sd#status</seealso>
    let status = Prefixed_Name(sdont, "status") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#supportDetails</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Property to link details, such as mailing lists in case a contact person is not provided"</para>
    /// labels<para>"support details"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#supportDetails">https://w3id.org/okn/o/sd#supportDetails</seealso>
    let supportDetails = Prefixed_Name(sdont, "supportDetails") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#tag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Tag used to annotate a version or a software configuration. This annotation is useful to show which version is the latest, or which version is deprecated. Supported tags are: "latest", "deprecated""</para>
    /// labels<para>"tag"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#tag">https://w3id.org/okn/o/sd#tag</seealso>
    let tag = Prefixed_Name(sdont, "tag") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#usefulForCalculatingIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property that indicates that a software component (or any of its outputs) can be used to calculate a particular index. The rationale for this property is that indices are usually calculated by applying post-processing steps to the outputs of a software component."</para>
    /// labels<para>"useful for calculating index"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#usefulForCalculatingIndex">https://w3id.org/okn/o/sd#usefulForCalculatingIndex</seealso>
    let usefulForCalculatingIndex =
        Prefixed_Name(sdont, "usefulForCalculatingIndex") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#usesUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Property used to link a variable presentation or time interval to the unit they are represented in"</para>
    /// labels<para>"uses unit"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#usesUnit">https://w3id.org/okn/o/sd#usesUnit</seealso>
    let usesUnit = Prefixed_Name(sdont, "usesUnit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:okn/o/sd#value</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Value associated to the described entity"</para>
    /// labels<para>"value"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#value">https://w3id.org/okn/o/sd#value</seealso>
    let value = Prefixed_Name(sdont, "value") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#wasDerivedFromSetup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property that links a setup to a previous version of that setup. This property is needed (for example) when creating snapshots of setups."</para>
    /// labels<para>"was derived from setup"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#wasDerivedFromSetup">https://w3id.org/okn/o/sd#wasDerivedFromSetup</seealso>
    let wasDerivedFromSetup =
        Prefixed_Name(sdont, "wasDerivedFromSetup") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#wasDerivedFromSoftware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property that identifies the software used to create a visualization"</para>
    /// labels<para>"was derived from software"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#wasDerivedFromSoftware">https://w3id.org/okn/o/sd#wasDerivedFromSoftware</seealso>
    let wasDerivedFromSoftware =
        Prefixed_Name(sdont, "wasDerivedFromSoftware") |> PrefixedName

    /// <summary>
    ///   <para>w3id:okn/o/sd#website</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Website of the software"</para>
    /// labels<para>"website"</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sd#website">https://w3id.org/okn/o/sd#website</seealso>
    let website = Prefixed_Name(sdont, "website") |> PrefixedName

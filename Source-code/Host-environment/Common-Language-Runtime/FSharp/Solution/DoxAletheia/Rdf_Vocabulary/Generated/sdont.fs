namespace https.w3id.org.okn.o.sd.hash

open DoxAletheia.Rdf_Vocabulary

module sdont =
    let _namespace_name = "https://w3id.org/okn/o/sd#"
    /// <summary>
    /// The set of instructions that indicate a machine how to work. In this ontology software is a general concept which acts as a superclass for software versions, docker images, data transformations, etc.
    /// <see href="https://w3id.org/okn/o/sd#Software"></see></summary>
    let Software = Namespaced_IRI.parse _namespace_name "Software" |> NamespacedName

    /// <summary>
    /// Class to identify that a parameter is a catalog identifier. The rationale for this type of parameter is that in some cases datasets may be downloaded in the software component itself, rather than exposed as an input
    /// <see href="https://w3id.org/okn/o/sd#CatalogIdentifier"></see></summary>
    let CatalogIdentifier =
        Namespaced_IRI.parse _namespace_name "CatalogIdentifier" |> NamespacedName

    /// <summary>
    /// A parameter of the model.
    /// <see href="https://w3id.org/okn/o/sd#Parameter"></see></summary>
    let Parameter = Namespaced_IRI.parse _namespace_name "Parameter" |> NamespacedName

    /// <summary>
    /// Special type of configuration in which some of the inputs or parameters are associated to files or values. A configuration may be associated to multiple setups to facilitate its execution.
    /// <see href="https://w3id.org/okn/o/sd#ConfigurationSetup"></see></summary>
    let ConfigurationSetup =
        Namespaced_IRI.parse _namespace_name "ConfigurationSetup" |> NamespacedName

    /// <summary>
    /// A software configuration represents a particular way of invoking a function of a software component. A software configuration exposes the precise inputs and outputs that are used for that function. Multiple software configurations may be associated to a software component. A software configuration facilitates the encapsulation of software, and it can be used to represent components of scientific workflows.
    /// <see href="https://w3id.org/okn/o/sd#SoftwareConfiguration"></see></summary>
    let SoftwareConfiguration =
        Namespaced_IRI.parse _namespace_name "SoftwareConfiguration" |> NamespacedName

    /// <summary>
    /// Data constraints of a configuration
    /// <see href="https://w3id.org/okn/o/sd#Constraint"></see></summary>
    let Constraint = Namespaced_IRI.parse _namespace_name "Constraint" |> NamespacedName

    /// <summary>
    /// Class that represents a software for performing data transformation.
    /// <see href="https://w3id.org/okn/o/sd#DataTransformation"></see></summary>
    let DataTransformation =
        Namespaced_IRI.parse _namespace_name "DataTransformation" |> NamespacedName

    /// <summary>
    /// Special type of data transformation where the inputs and parameters have some pre-selected values. For example, they may point to a particular dataset URL to be used in the transformation
    /// <see href="https://w3id.org/okn/o/sd#DataTransformationSetup"></see></summary>
    let DataTransformationSetup =
        Namespaced_IRI.parse _namespace_name "DataTransformationSetup" |> NamespacedName

    /// <summary>
    /// Class designed to describe a type of input or output used or produced by a model. For example, Topoflow has several inputs. One of them is a text file with precipitation values. The representation of this input is an instance of a dataset specification.
    /// <see href="https://w3id.org/okn/o/sd#DatasetSpecification"></see></summary>
    let DatasetSpecification =
        Namespaced_IRI.parse _namespace_name "DatasetSpecification" |> NamespacedName

    /// <summary>
    /// A class to represent the funding information of a software project
    /// <see href="https://w3id.org/okn/o/sd#FundingInformation"></see></summary>
    let FundingInformation =
        Namespaced_IRI.parse _namespace_name "FundingInformation" |> NamespacedName

    /// <summary>
    /// An image (e.g. tiff file) is a type of dataset specification used to define certain inputs of models like soil, crops, etc.
    /// <see href="https://w3id.org/okn/o/sd#Image"></see></summary>
    let Image = Namespaced_IRI.parse _namespace_name "Image" |> NamespacedName

    /// <summary>
    /// A number (such as a ratio) derived from a series of observations and used as an indicator or measure (https://www.merriam-webster.com/dictionary/index)
    /// <see href="https://w3id.org/okn/o/sd#NumericalIndex"></see></summary>
    let NumericalIndex =
        Namespaced_IRI.parse _namespace_name "NumericalIndex" |> NamespacedName

    /// <summary>
    /// A symbol that represents a quanity in a dataset or dataset specification
    /// <see href="https://w3id.org/okn/o/sd#Variable"></see></summary>
    let Variable = Namespaced_IRI.parse _namespace_name "Variable" |> NamespacedName

    /// <summary>
    /// An organized body of people with a particular purpose
    /// <see href="https://w3id.org/okn/o/sd#Organization"></see></summary>
    let Organization =
        Namespaced_IRI.parse _namespace_name "Organization" |> NamespacedName

    /// <summary>
    /// A human being (individual)
    /// <see href="https://w3id.org/okn/o/sd#Person"></see></summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName

    /// <summary>
    /// A collection of resources that are used as sample for running a sfoware component multiple times
    /// <see href="https://w3id.org/okn/o/sd#SampleCollection"></see></summary>
    let SampleCollection =
        Namespaced_IRI.parse _namespace_name "SampleCollection" |> NamespacedName

    /// <summary>
    /// A sample resource associated with a software
    /// <see href="https://w3id.org/okn/o/sd#SampleResource"></see></summary>
    let SampleResource =
        Namespaced_IRI.parse _namespace_name "SampleResource" |> NamespacedName

    /// <summary>
    /// A sample execution of a given software
    /// <see href="https://w3id.org/okn/o/sd#SampleExecution"></see></summary>
    let SampleExecution =
        Namespaced_IRI.parse _namespace_name "SampleExecution" |> NamespacedName

    /// <summary>
    /// An image that virtualizes the functionality of a given software. For example, a Docker container.
    /// <see href="https://w3id.org/okn/o/sd#SoftwareImage"></see></summary>
    let SoftwareImage =
        Namespaced_IRI.parse _namespace_name "SoftwareImage" |> NamespacedName

    /// <summary>
    /// A software version is a specificf type of software that represents a particular set of functionalities. New functionalities and error fixes may occur between software versions
    /// <see href="https://w3id.org/okn/o/sd#SoftwareVersion"></see></summary>
    let SoftwareVersion =
        Namespaced_IRI.parse _namespace_name "SoftwareVersion" |> NamespacedName

    /// <summary>
    /// Class representing the characteristics of the code associated with a  software component
    /// <see href="https://w3id.org/okn/o/sd#SourceCode"></see></summary>
    let SourceCode = Namespaced_IRI.parse _namespace_name "SourceCode" |> NamespacedName

    /// <summary>
    /// A standard variable, necessary to refer to all the variable using the same nomenclature in a domain ontology. For example, a standard variable may be a SVO variable (http://www.geoscienceontology.org/geo-upper#Variable)
    /// <see href="https://w3id.org/okn/o/sd#StandardVariable"></see></summary>
    let StandardVariable =
        Namespaced_IRI.parse _namespace_name "StandardVariable" |> NamespacedName

    /// <summary>
    /// Class designed to distinguish the different types of units that are available in variables from datasets or parameters
    /// <see href="https://w3id.org/okn/o/sd#Unit"></see></summary>
    let Unit = Namespaced_IRI.parse _namespace_name "Unit" |> NamespacedName

    /// <summary>
    /// Concept used to represent an instantiation of a variable in an input/output dataset. For example, a model A may use an input file with temperature expressed in Farenheit (variablePresentation1), while a model B may produce an output with temperature in Celsius (variablePresentation2). Both variable presentations refer to the concept of temperature.
    /// <see href="https://w3id.org/okn/o/sd#VariablePresentation"></see></summary>
    let VariablePresentation =
        Namespaced_IRI.parse _namespace_name "VariablePresentation" |> NamespacedName

    /// <summary>
    /// Class to represent any type of visualization related to a software. For example, a dynamic HTML page, a video, etc.
    /// <see href="https://w3id.org/okn/o/sd#Visualization"></see></summary>
    let Visualization =
        Namespaced_IRI.parse _namespace_name "Visualization" |> NamespacedName

    /// <summary>
    /// Parameter that can be adjusted in a configuration setup
    /// <see href="https://w3id.org/okn/o/sd#adjustableParameter"></see></summary>
    let adjustableParameter =
        Namespaced_IRI.parse _namespace_name "adjustableParameter" |> NamespacedName

    /// <summary>
    /// Property that links parameter with the variable they adjust. This property can be used when parameters quantify variables without directly representing them. For example, a "fertilizer percentage adjustment" parameter can quantify a "fertilizer price" variable
    /// <see href="https://w3id.org/okn/o/sd#adjustsVariable"></see></summary>
    let adjustsVariable =
        Namespaced_IRI.parse _namespace_name "adjustsVariable" |> NamespacedName

    /// <summary>
    /// The creator of a software component
    /// <see href="https://w3id.org/okn/o/sd#author"></see></summary>
    let author = Namespaced_IRI.parse _namespace_name "author" |> NamespacedName

    /// <summary>
    /// Property that indicates in which registry the software image being described can be found. For example, https://hub.docker.com
    /// <see href="https://w3id.org/okn/o/sd#availableInRegistry"></see></summary>
    let availableInRegistry =
        Namespaced_IRI.parse _namespace_name "availableInRegistry" |> NamespacedName

    /// <summary>
    /// How to cite this software
    /// <see href="https://w3id.org/okn/o/sd#citation"></see></summary>
    let citation = Namespaced_IRI.parse _namespace_name "citation" |> NamespacedName

    /// <summary>
    /// URL to the code repository of a software component
    /// <see href="https://w3id.org/okn/o/sd#codeRepository"></see></summary>
    let codeRepository =
        Namespaced_IRI.parse _namespace_name "codeRepository" |> NamespacedName

    /// <summary>
    /// Property that links a software component to other useful software that canbe used to visualize its outputs
    /// <see href="https://w3id.org/okn/o/sd#compatibleVisualizationSoftware"></see></summary>
    let compatibleVisualizationSoftware =
        Namespaced_IRI.parse _namespace_name "compatibleVisualizationSoftware" |> NamespacedName

    /// <summary>
    /// Contributor to a software component
    /// <see href="https://w3id.org/okn/o/sd#contributor"></see></summary>
    let contributor =
        Namespaced_IRI.parse _namespace_name "contributor" |> NamespacedName

    /// <summary>
    /// Copyright holder for a software component
    /// <see href="https://w3id.org/okn/o/sd#copyrightHolder"></see></summary>
    let copyrightHolder =
        Namespaced_IRI.parse _namespace_name "copyrightHolder" |> NamespacedName

    /// <summary>
    /// Year in which the software component was copyrighted
    /// <see href="https://w3id.org/okn/o/sd#copyrightYear"></see></summary>
    let copyrightYear =
        Namespaced_IRI.parse _namespace_name "copyrightYear" |> NamespacedName

    /// <summary>
    /// An identifier for resources with metadata entries in a data catalog
    /// <see href="https://w3id.org/okn/o/sd#dataCatalogIdentifier"></see></summary>
    let dataCatalogIdentifier =
        Namespaced_IRI.parse _namespace_name "dataCatalogIdentifier" |> NamespacedName

    /// <summary>
    /// Date when a software component was created
    /// <see href="https://w3id.org/okn/o/sd#dateCreated"></see></summary>
    let dateCreated =
        Namespaced_IRI.parse _namespace_name "dateCreated" |> NamespacedName

    /// <summary>
    /// Date when a software component was published
    /// <see href="https://w3id.org/okn/o/sd#datePublished"></see></summary>
    let datePublished =
        Namespaced_IRI.parse _namespace_name "datePublished" |> NamespacedName

    /// <summary>
    /// A description of a resource
    /// <see href="https://w3id.org/okn/o/sd#description"></see></summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    /// Digital Object Identifier associated with a software component
    /// <see href="https://w3id.org/okn/o/sd#doi"></see></summary>
    let doi = Namespaced_IRI.parse _namespace_name "doi" |> NamespacedName
    /// <summary>
    /// Identifier of the resource being described
    /// <see href="https://w3id.org/okn/o/sd#identifier"></see></summary>
    let identifier = Namespaced_IRI.parse _namespace_name "identifier" |> NamespacedName
    /// <summary>
    /// Email of a person
    /// <see href="https://w3id.org/okn/o/sd#email"></see></summary>
    let email = Namespaced_IRI.parse _namespace_name "email" |> NamespacedName

    /// <summary>
    /// Grant number used for funding
    /// <see href="https://w3id.org/okn/o/sd#fundingGrant"></see></summary>
    let fundingGrant =
        Namespaced_IRI.parse _namespace_name "fundingGrant" |> NamespacedName

    /// <summary>
    /// Link to the organization funding a software component
    /// <see href="https://w3id.org/okn/o/sd#fundingSource"></see></summary>
    let fundingSource =
        Namespaced_IRI.parse _namespace_name "fundingSource" |> NamespacedName

    /// <summary>
    /// Property to identify the original source of the information of the annotated resource. It could be a web page, an organization, a person, some experiment notes, etc.
    /// <see href="https://w3id.org/okn/o/sd#hadPrimarySource"></see></summary>
    let hadPrimarySource =
        Namespaced_IRI.parse _namespace_name "hadPrimarySource" |> NamespacedName

    /// <summary>
    /// Property that constraints which values are accepted for a parameter. For example, the name of a crop can only be "Maize" or "Sorghum"
    /// <see href="https://w3id.org/okn/o/sd#hasAcceptedValues"></see></summary>
    let hasAcceptedValues =
        Namespaced_IRI.parse _namespace_name "hasAcceptedValues" |> NamespacedName

    /// <summary>
    /// String with the people, organizations and other contributors acknowledged by the authors.
    /// <see href="https://w3id.org/okn/o/sd#hasAcknowledgements"></see></summary>
    let hasAcknowledgements =
        Namespaced_IRI.parse _namespace_name "hasAcknowledgements" |> NamespacedName

    /// <summary>
    /// Assumptions of a software, e.g. the solver being used for a particular model, the source of the data (e.g., all data must have a given resolution), etc.
    /// <see href="https://w3id.org/okn/o/sd#hasAssumption"></see></summary>
    let hasAssumption =
        Namespaced_IRI.parse _namespace_name "hasAssumption" |> NamespacedName

    /// <summary>
    /// A file (e.g., Dockerfile) with executable instructions indicating how a Software Image or a Software component is built
    /// <see href="https://w3id.org/okn/o/sd#hasBuildFile"></see></summary>
    let hasBuildFile =
        Namespaced_IRI.parse _namespace_name "hasBuildFile" |> NamespacedName

    /// <summary>
    /// Property linking the software component to the code of conduct to be followed by potential contributors. The range of this property may be a strin or a URI to the target file.
    /// <see href="https://w3id.org/okn/o/sd#hasCodeOfConduct"></see></summary>
    let hasCodeOfConduct =
        Namespaced_IRI.parse _namespace_name "hasCodeOfConduct" |> NamespacedName

    /// <summary>
    /// Location of the aggregation of all the files needed to execute the component. Usually a zip file including the run script and support scripts, including specification files
    /// <see href="https://w3id.org/okn/o/sd#hasComponentLocation"></see></summary>
    let hasComponentLocation =
        Namespaced_IRI.parse _namespace_name "hasComponentLocation" |> NamespacedName

    /// <summary>
    /// Property that links a model to one of its configurations. A model may have multiple configurations, each of which is unique in terms of the inputs and outputs it uses.
    /// <see href="https://w3id.org/okn/o/sd#hasConfiguration"></see></summary>
    let hasConfiguration =
        Namespaced_IRI.parse _namespace_name "hasConfiguration" |> NamespacedName

    /// <summary>
    /// Constraint or rule associated to a  variable or software configuration. For example: "This model accepts only monthly data", or "all inputs of this model configuration must share the same location". More structured restrictions, such as Jena rules or SWRL rules may also be captured with this property
    /// <see href="https://w3id.org/okn/o/sd#hasConstraint"></see></summary>
    let hasConstraint =
        Namespaced_IRI.parse _namespace_name "hasConstraint" |> NamespacedName

    /// <summary>
    /// Contact person responsible for a software component
    /// <see href="https://w3id.org/okn/o/sd#hasContactPerson"></see></summary>
    let hasContactPerson =
        Namespaced_IRI.parse _namespace_name "hasContactPerson" |> NamespacedName

    /// <summary>
    /// Property that associates an input/output with their corresponding data transformation.
    /// <see href="https://w3id.org/okn/o/sd#hasDataTransformation"></see></summary>
    let hasDataTransformation =
        Namespaced_IRI.parse _namespace_name "hasDataTransformation" |> NamespacedName

    /// <summary>
    /// Property to link an input/output dataset to the specific data transformation (with URLs
    /// <see href="https://w3id.org/okn/o/sd#hasDataTransformationSetup"></see></summary>
    let hasDataTransformationSetup =
        Namespaced_IRI.parse _namespace_name "hasDataTransformationSetup" |> NamespacedName

    /// <summary>
    /// Property that indicates the data type of a parameter
    /// <see href="https://w3id.org/okn/o/sd#hasDataType"></see></summary>
    let hasDataType =
        Namespaced_IRI.parse _namespace_name "hasDataType" |> NamespacedName

    /// <summary>
    /// Default accepted value of a variable presentation (or a parameter)
    /// <see href="https://w3id.org/okn/o/sd#hasDefaultValue"></see></summary>
    let hasDefaultValue =
        Namespaced_IRI.parse _namespace_name "hasDefaultValue" |> NamespacedName

    /// <summary>
    /// Property to indicate dimensionality of the input or output of a dataset specification
    /// <see href="https://w3id.org/okn/o/sd#hasDimensionality"></see></summary>
    let hasDimensionality =
        Namespaced_IRI.parse _namespace_name "hasDimensionality" |> NamespacedName

    /// <summary>
    /// Pointer to the documentation of the model
    /// <see href="https://w3id.org/okn/o/sd#hasDocumentation"></see></summary>
    let hasDocumentation =
        Namespaced_IRI.parse _namespace_name "hasDocumentation" |> NamespacedName

    /// <summary>
    /// Instructions needed to download a software component. The difference with `hasDownloadURL` is that this property captures the human readable instructions required to download software. For example, sometimes an authentication is needed, users need to fill in a form, etc.
    /// <see href="https://w3id.org/okn/o/sd#hasDownloadInstructions"></see></summary>
    let hasDownloadInstructions =
        Namespaced_IRI.parse _namespace_name "hasDownloadInstructions" |> NamespacedName

    /// <summary>
    /// Download URL where to obtain the source/executable of the software
    /// <see href="https://w3id.org/okn/o/sd#hasDownloadURL"></see></summary>
    let hasDownloadURL =
        Namespaced_IRI.parse _namespace_name "hasDownloadURL" |> NamespacedName

    /// <summary>
    /// An example explaining a scenario where the software component was used in plain language.
    /// <see href="https://w3id.org/okn/o/sd#hasExample"></see></summary>
    let hasExample = Namespaced_IRI.parse _namespace_name "hasExample" |> NamespacedName

    /// <summary>
    /// Instructions that indicate how a software component should be executed. The difference with `hasExecutionCommand` is that the execution instructions aim to be human-readable, and have explanations between the different commands and instructions
    /// <see href="https://w3id.org/okn/o/sd#hasExecutableInstructions"></see></summary>
    let hasExecutableInstructions =
        Namespaced_IRI.parse _namespace_name "hasExecutableInstructions" |> NamespacedName

    /// <summary>
    /// Property that links a software component with an executable notebook (e.g., Jupyter notebook) that illustrates how to use it in an executable manner.
    /// <see href="https://w3id.org/okn/o/sd#hasExecutableNotebook"></see></summary>
    let hasExecutableNotebook =
        Namespaced_IRI.parse _namespace_name "hasExecutableNotebook" |> NamespacedName

    /// <summary>
    /// Execution instructions on how to run the image
    /// <see href="https://w3id.org/okn/o/sd#hasExecutionCommand"></see></summary>
    let hasExecutionCommand =
        Namespaced_IRI.parse _namespace_name "hasExecutionCommand" |> NamespacedName

    /// <summary>
    /// Frequently asked questions about a software
    /// <see href="https://w3id.org/okn/o/sd#hasFAQ"></see></summary>
    let hasFAQ = Namespaced_IRI.parse _namespace_name "hasFAQ" |> NamespacedName

    /// <summary>
    /// Relates a dataset specification to the data structure definition
    /// <see href="https://w3id.org/okn/o/sd#hasFileStructure"></see></summary>
    let hasFileStructure =
        Namespaced_IRI.parse _namespace_name "hasFileStructure" |> NamespacedName

    /// <summary>
    /// Property that links a parameter or an input to a fixed value. For example, in a given configuration a parameter with the planting date for a model could be fixed to avoid the user changing it for that region.
    /// <see href="https://w3id.org/okn/o/sd#hasFixedResource"></see></summary>
    let hasFixedResource =
        Namespaced_IRI.parse _namespace_name "hasFixedResource" |> NamespacedName

    /// <summary>
    /// Value of a parameter in a software setup.
    /// <see href="https://w3id.org/okn/o/sd#hasFixedValue"></see></summary>
    let hasFixedValue =
        Namespaced_IRI.parse _namespace_name "hasFixedValue" |> NamespacedName

    /// <summary>
    /// Format followed by a file. For example, txt, nc, etc.
    /// <see href="https://w3id.org/okn/o/sd#hasFormat"></see></summary>
    let hasFormat = Namespaced_IRI.parse _namespace_name "hasFormat" |> NamespacedName
    /// <summary>
    /// Property that links a software project to its funding information
    /// <see href="https://w3id.org/okn/o/sd#hasFunding"></see></summary>
    let hasFunding = Namespaced_IRI.parse _namespace_name "hasFunding" |> NamespacedName

    /// <summary>
    /// Property that points to the main runnable script for the current function
    /// <see href="https://w3id.org/okn/o/sd#hasImplementationScriptLocation"></see></summary>
    let hasImplementationScriptLocation =
        Namespaced_IRI.parse _namespace_name "hasImplementationScriptLocation" |> NamespacedName

    /// <summary>
    /// Property that links a model configuration to the input types expected by it.
    /// <see href="https://w3id.org/okn/o/sd#hasInput"></see></summary>
    let hasInput = Namespaced_IRI.parse _namespace_name "hasInput" |> NamespacedName

    /// <summary>
    /// Instructions required to install this particular piece of software. Installation instructions usually are available in a human-readable manner.
    /// <see href="https://w3id.org/okn/o/sd#hasInstallationInstructions"></see></summary>
    let hasInstallationInstructions =
        Namespaced_IRI.parse _namespace_name "hasInstallationInstructions" |> NamespacedName

    /// <summary>
    /// Properties that relate the variable representation to its long name. The long name is useful for context (e.g., precipitation is less ambiguous than P) but not as precise as the standard name.
    /// <see href="https://w3id.org/okn/o/sd#hasLongName"></see></summary>
    let hasLongName =
        Namespaced_IRI.parse _namespace_name "hasLongName" |> NamespacedName

    /// <summary>
    /// Maximum accepted value of a variable presentation (or a parameter)
    /// <see href="https://w3id.org/okn/o/sd#hasMaximumAcceptedValue"></see></summary>
    let hasMaximumAcceptedValue =
        Namespaced_IRI.parse _namespace_name "hasMaximumAcceptedValue" |> NamespacedName

    /// <summary>
    /// Minimum accepted value of a variable presentation (or a parameter)
    /// <see href="https://w3id.org/okn/o/sd#hasMinimumAcceptedValue"></see></summary>
    let hasMinimumAcceptedValue =
        Namespaced_IRI.parse _namespace_name "hasMinimumAcceptedValue" |> NamespacedName

    /// <summary>
    /// Property that expresses what are the outputs of a model
    /// <see href="https://w3id.org/okn/o/sd#hasOutput"></see></summary>
    let hasOutput = Namespaced_IRI.parse _namespace_name "hasOutput" |> NamespacedName

    /// <summary>
    /// Property that indicates the parameters of a model configuration
    /// <see href="https://w3id.org/okn/o/sd#hasParameter"></see></summary>
    let hasParameter =
        Namespaced_IRI.parse _namespace_name "hasParameter" |> NamespacedName

    /// <summary>
    /// Property designed to reference the elements included in a sample collection.
    /// <see href="https://w3id.org/okn/o/sd#hasPart"></see></summary>
    let hasPart = Namespaced_IRI.parse _namespace_name "hasPart" |> NamespacedName

    /// <summary>
    /// Property that links an instance of a dataset (or a dataset specification) to the presentation of a variable contained (or expected to be contained) on it.
    /// <see href="https://w3id.org/okn/o/sd#hasPresentation"></see></summary>
    let hasPresentation =
        Namespaced_IRI.parse _namespace_name "hasPresentation" |> NamespacedName

    /// <summary>
    /// Associates a presentation with a dataset where the presentation occurs
    /// <see href="https://w3id.org/okn/o/sd#partOfDataset"></see></summary>
    let partOfDataset =
        Namespaced_IRI.parse _namespace_name "partOfDataset" |> NamespacedName

    /// <summary>
    /// Objective or main functionality that can be achieved by running this software
    /// <see href="https://w3id.org/okn/o/sd#hasPurpose"></see></summary>
    let hasPurpose = Namespaced_IRI.parse _namespace_name "hasPurpose" |> NamespacedName
    /// <summary>
    /// Rule that defines this constraint
    /// <see href="https://w3id.org/okn/o/sd#hasRule"></see></summary>
    let hasRule = Namespaced_IRI.parse _namespace_name "hasRule" |> NamespacedName

    /// <summary>
    /// Property pointing to a sample execution of a software configuration
    /// <see href="https://w3id.org/okn/o/sd#hasSampleExecution"></see></summary>
    let hasSampleExecution =
        Namespaced_IRI.parse _namespace_name "hasSampleExecution" |> NamespacedName

    /// <summary>
    /// Property designed to link a software configuration to a sample resource resulting from its execution
    /// <see href="https://w3id.org/okn/o/sd#hasSampleResult"></see></summary>
    let hasSampleResult =
        Namespaced_IRI.parse _namespace_name "hasSampleResult" |> NamespacedName

    /// <summary>
    /// A typical sample visualization of the software outputs
    /// <see href="https://w3id.org/okn/o/sd#hasSampleVisualization"></see></summary>
    let hasSampleVisualization =
        Namespaced_IRI.parse _namespace_name "hasSampleVisualization" |> NamespacedName

    /// <summary>
    /// Property used to define configurations with some fixed resources and values. The rationale of this property is to allow predefined configurations
    /// <see href="https://w3id.org/okn/o/sd#hasSetup"></see></summary>
    let hasSetup = Namespaced_IRI.parse _namespace_name "hasSetup" |> NamespacedName

    /// <summary>
    /// A short name (e.g., temperature) capturing the high-level concept of the variable
    /// <see href="https://w3id.org/okn/o/sd#hasShortName"></see></summary>
    let hasShortName =
        Namespaced_IRI.parse _namespace_name "hasShortName" |> NamespacedName

    /// <summary>
    /// Function to link a function with its corresponding container
    /// <see href="https://w3id.org/okn/o/sd#hasSoftwareImage"></see></summary>
    let hasSoftwareImage =
        Namespaced_IRI.parse _namespace_name "hasSoftwareImage" |> NamespacedName

    /// <summary>
    /// Property designed to link a software with its software source code (which may reside in a code repository such as GitHub)
    /// <see href="https://w3id.org/okn/o/sd#hasSourceCode"></see></summary>
    let hasSourceCode =
        Namespaced_IRI.parse _namespace_name "hasSourceCode" |> NamespacedName

    /// <summary>
    /// the standard name of a variable
    /// <see href="https://w3id.org/okn/o/sd#hasStandardVariable"></see></summary>
    let hasStandardVariable =
        Namespaced_IRI.parse _namespace_name "hasStandardVariable" |> NamespacedName

    /// <summary>
    /// Property that determines what are the increments (step size) that are commonly used to vary a parameter. This is commonly used for automatically setting up software tests. For example, if I want to set up a model and try 30 reasonable values on a parameter, I may use the default value and the step size to create the appropriate increments. If the step size is 0.1 and the default value is 0, then I will will be able to create setups: 0, 0.1, 0.2...2.9,3
    /// <see href="https://w3id.org/okn/o/sd#hasStepSize"></see></summary>
    let hasStepSize =
        Namespaced_IRI.parse _namespace_name "hasStepSize" |> NamespacedName

    /// <summary>
    /// Property that links to the location of scripts that may be used from the main runnable script.
    /// <see href="https://w3id.org/okn/o/sd#hasSupportScriptLocation"></see></summary>
    let hasSupportScriptLocation =
        Namespaced_IRI.parse _namespace_name "hasSupportScriptLocation" |> NamespacedName

    /// <summary>
    /// Typical data sources that are used by a software component
    /// <see href="https://w3id.org/okn/o/sd#hasTypicalDataSource"></see></summary>
    let hasTypicalDataSource =
        Namespaced_IRI.parse _namespace_name "hasTypicalDataSource" |> NamespacedName

    /// <summary>
    /// Property that describes the usage considerations of a particular software. These notes capture the rationale of for that software configuration, along with an explanation for sample inputs, things to consider when running the model with data, etc.
    /// <see href="https://w3id.org/okn/o/sd#hasUsageNotes"></see></summary>
    let hasUsageNotes =
        Namespaced_IRI.parse _namespace_name "hasUsageNotes" |> NamespacedName

    /// <summary>
    /// Property that links a rule and the variable that will test it
    /// <see href="https://w3id.org/okn/o/sd#hasVariable"></see></summary>
    let hasVariable =
        Namespaced_IRI.parse _namespace_name "hasVariable" |> NamespacedName

    /// <summary>
    /// Property designed to link a software component with its corresponding versions
    /// <see href="https://w3id.org/okn/o/sd#hasVersion"></see></summary>
    let hasVersion = Namespaced_IRI.parse _namespace_name "hasVersion" |> NamespacedName

    /// <summary>
    /// Identifier of the version of this software
    /// <see href="https://w3id.org/okn/o/sd#hasVersionId"></see></summary>
    let hasVersionId =
        Namespaced_IRI.parse _namespace_name "hasVersionId" |> NamespacedName

    /// <summary>
    /// Property that links a dataset specification from a model configuration or setup to the output from a target data transformation. This occurs when a data transformation produces several outputs, but only one of them is the one needed for a model
    /// <see href="https://w3id.org/okn/o/sd#isTransformedFrom"></see></summary>
    let isTransformedFrom =
        Namespaced_IRI.parse _namespace_name "isTransformedFrom" |> NamespacedName

    /// <summary>
    /// Pointer to the issue tracker of a software component
    /// <see href="https://w3id.org/okn/o/sd#issueTracker"></see></summary>
    let issueTracker =
        Namespaced_IRI.parse _namespace_name "issueTracker" |> NamespacedName

    /// <summary>
    /// Keywords associated with a software component
    /// <see href="https://w3id.org/okn/o/sd#keywords"></see></summary>
    let keywords = Namespaced_IRI.parse _namespace_name "keywords" |> NamespacedName
    /// <summary>
    /// License of a software component or its source code
    /// <see href="https://w3id.org/okn/o/sd#license"></see></summary>
    let license = Namespaced_IRI.parse _namespace_name "license" |> NamespacedName
    /// <summary>
    /// Property that links to the image used as logo for a software component
    /// <see href="https://w3id.org/okn/o/sd#logo"></see></summary>
    let logo = Namespaced_IRI.parse _namespace_name "logo" |> NamespacedName

    /// <summary>
    /// Memory requirements of a software
    /// <see href="https://w3id.org/okn/o/sd#memoryRequirements"></see></summary>
    let memoryRequirements =
        Namespaced_IRI.parse _namespace_name "memoryRequirements" |> NamespacedName

    /// <summary>
    /// Name of the resource
    /// <see href="https://w3id.org/okn/o/sd#name"></see></summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName

    /// <summary>
    /// Operating systems under which a software component can operate
    /// <see href="https://w3id.org/okn/o/sd#operatingSystems"></see></summary>
    let operatingSystems =
        Namespaced_IRI.parse _namespace_name "operatingSystems" |> NamespacedName

    /// <summary>
    /// Property that indicates the relative path of an input or output with respect to the folder structure of the executable.
    ///
    /// For example, let's assume we have an input that has to exist in the folder `/datasets` or the executable will not work. This property ensures that this knowledge is captured for a given software component execution.
    ///
    /// In this case the property would capture this as follows:
    ///
    /// ```
    /// :input_prep a sd:DatasetSpecification .
    /// :input_prep rdfs:label "precipitation file" .
    /// :input_precip sd:pathLocation "/datasets/".
    /// ```
    /// <see href="https://w3id.org/okn/o/sd#pathLocation"></see></summary>
    let pathLocation =
        Namespaced_IRI.parse _namespace_name "pathLocation" |> NamespacedName

    /// <summary>
    /// Position of the parameter or input/output in the model configuration. This property is needed to know how to organize the I/O of the component on execution
    /// <see href="https://w3id.org/okn/o/sd#position"></see></summary>
    let position = Namespaced_IRI.parse _namespace_name "position" |> NamespacedName

    /// <summary>
    /// Processor requirements of a software component
    /// <see href="https://w3id.org/okn/o/sd#processorRequirements"></see></summary>
    let processorRequirements =
        Namespaced_IRI.parse _namespace_name "processorRequirements" |> NamespacedName

    /// <summary>
    /// Language used to code a software component
    /// <see href="https://w3id.org/okn/o/sd#programmingLanguage"></see></summary>
    let programmingLanguage =
        Namespaced_IRI.parse _namespace_name "programmingLanguage" |> NamespacedName

    /// <summary>
    /// Publisher organization or person responsible for a software component
    /// <see href="https://w3id.org/okn/o/sd#publisher"></see></summary>
    let publisher = Namespaced_IRI.parse _namespace_name "publisher" |> NamespacedName
    /// <summary>
    /// URl to the readme file of a software component
    /// <see href="https://w3id.org/okn/o/sd#readme"></see></summary>
    let readme = Namespaced_IRI.parse _namespace_name "readme" |> NamespacedName

    /// <summary>
    /// Value that represents how a parameter should be incremented on each iteration of a software component execution. This value is important when preparing execution ensembles automatically, e.g., simulating crop production varying the parameter "fertilizer amount" in increments of 10%.
    /// <see href="https://w3id.org/okn/o/sd#recommendedIncrement"></see></summary>
    let recommendedIncrement =
        Namespaced_IRI.parse _namespace_name "recommendedIncrement" |> NamespacedName

    /// <summary>
    /// Main publication to cite for this software component
    /// <see href="https://w3id.org/okn/o/sd#referencePublication"></see></summary>
    let referencePublication =
        Namespaced_IRI.parse _namespace_name "referencePublication" |> NamespacedName

    /// <summary>
    /// Image illustrating a snapshot of the target software
    /// <see href="https://w3id.org/okn/o/sd#screenshot"></see></summary>
    let screenshot = Namespaced_IRI.parse _namespace_name "screenshot" |> NamespacedName

    /// <summary>
    /// A summarized description of the resource
    /// <see href="https://w3id.org/okn/o/sd#shortDescription"></see></summary>
    let shortDescription =
        Namespaced_IRI.parse _namespace_name "shortDescription" |> NamespacedName

    /// <summary>
    /// Software requirements needed to install a software component
    /// <see href="https://w3id.org/okn/o/sd#softwareRequirements"></see></summary>
    let softwareRequirements =
        Namespaced_IRI.parse _namespace_name "softwareRequirements" |> NamespacedName

    /// <summary>
    /// Data property to indicate the status of a configuration setups. For example, to indicate that a setup has been executed in a platform, that the setup should notbe shown to users (it's an auxiliary setup), etc.
    /// <see href="https://w3id.org/okn/o/sd#status"></see></summary>
    let status = Namespaced_IRI.parse _namespace_name "status" |> NamespacedName

    /// <summary>
    /// Property to link details, such as mailing lists in case a contact person is not provided
    /// <see href="https://w3id.org/okn/o/sd#supportDetails"></see></summary>
    let supportDetails =
        Namespaced_IRI.parse _namespace_name "supportDetails" |> NamespacedName

    /// <summary>
    /// Tag used to annotate a version or a software configuration. This annotation is useful to show which version is the latest, or which version is deprecated. Supported tags are: "latest", "deprecated"
    /// <see href="https://w3id.org/okn/o/sd#tag"></see></summary>
    let tag = Namespaced_IRI.parse _namespace_name "tag" |> NamespacedName

    /// <summary>
    /// Property that indicates that a software component (or any of its outputs) can be used to calculate a particular index. The rationale for this property is that indices are usually calculated by applying post-processing steps to the outputs of a software component.
    /// <see href="https://w3id.org/okn/o/sd#usefulForCalculatingIndex"></see></summary>
    let usefulForCalculatingIndex =
        Namespaced_IRI.parse _namespace_name "usefulForCalculatingIndex" |> NamespacedName

    /// <summary>
    /// Property used to link a variable presentation or time interval to the unit they are represented in
    /// <see href="https://w3id.org/okn/o/sd#usesUnit"></see></summary>
    let usesUnit = Namespaced_IRI.parse _namespace_name "usesUnit" |> NamespacedName
    /// <summary>
    /// Value associated to the described entity
    /// <see href="https://w3id.org/okn/o/sd#value"></see></summary>
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName

    /// <summary>
    /// Property that links a setup to a previous version of that setup. This property is needed (for example) when creating snapshots of setups.
    /// <see href="https://w3id.org/okn/o/sd#wasDerivedFromSetup"></see></summary>
    let wasDerivedFromSetup =
        Namespaced_IRI.parse _namespace_name "wasDerivedFromSetup" |> NamespacedName

    /// <summary>
    /// Property that identifies the software used to create a visualization
    /// <see href="https://w3id.org/okn/o/sd#wasDerivedFromSoftware"></see></summary>
    let wasDerivedFromSoftware =
        Namespaced_IRI.parse _namespace_name "wasDerivedFromSoftware" |> NamespacedName

    /// <summary>
    /// Website of the software
    /// <see href="https://w3id.org/okn/o/sd#website"></see></summary>
    let website = Namespaced_IRI.parse _namespace_name "website" |> NamespacedName

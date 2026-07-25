namespace http.www.w3.org.ns.mls.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module mls =
    let _namespace_iri = Namespace_Iri mls |> NamespaceIRI
    /// <summary>
    ///   <para>mls:InformationEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/mls#InformationEntity">http://www.w3.org/ns/mls#InformationEntity</seealso>
    let InformationEntity = Prefixed_Name(mls, "InformationEntity") |> PrefixedName
    /// <summary>
    ///   <para>mls:Quality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/mls#Quality">http://www.w3.org/ns/mls#Quality</seealso>
    let Quality = Prefixed_Name(mls, "Quality") |> PrefixedName
    /// <summary>
    ///   <para>mls:EvaluationProcedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>EvaluationProcedure is a technique to evaluate machine learning models. Examples are cross-validation and leave-one-out.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/mls#EvaluationProcedure">http://www.w3.org/ns/mls#EvaluationProcedure</seealso>
    let EvaluationProcedure = Prefixed_Name(mls, "EvaluationProcedure") |> PrefixedName

    /// <summary>
    ///   <para>mls:EvaluationSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>EvaluationProcedure is a technique to evaluate machine learning models. Examples are cross-validation and leave-one-out.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/mls#EvaluationSpecification">http://www.w3.org/ns/mls#EvaluationSpecification</seealso>
    let EvaluationSpecification =
        Prefixed_Name(mls, "EvaluationSpecification") |> PrefixedName

    /// <summary>
    ///   <para>mls:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/mls#">http://www.w3.org/ns/mls#</seealso>
    let _prefix_iri = Prefixed_Name(mls, "") |> PrefixedName
    /// <summary>
    ///   <para>mls:hasQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between entities and their various characteristics.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/mls#hasQuality">http://www.w3.org/ns/mls#hasQuality</seealso>
    let hasQuality = Prefixed_Name(mls, "hasQuality") |> PrefixedName
    /// <summary>
    ///   <para>mls:Dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/mls#Dataset">http://www.w3.org/ns/mls#Dataset</seealso>
    let Dataset = Prefixed_Name(mls, "Dataset") |> PrefixedName

    /// <summary>
    ///   <para>mls:DatasetCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/mls#DatasetCharacteristic">http://www.w3.org/ns/mls#DatasetCharacteristic</seealso>
    let DatasetCharacteristic =
        Prefixed_Name(mls, "DatasetCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>mls:Task</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Task is a formal description of a process that needs to be completed (e.g. based on inputs and outputs). A Task is any piece of work that needs to be addressed in the data mining process. In ML Schema, it is defined based on data.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/mls#Task">http://www.w3.org/ns/mls#Task</seealso>
    let Task = Prefixed_Name(mls, "Task") |> PrefixedName
    /// <summary>
    ///   <para>mls:Process</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Process</para></remarks>
    /// <seealso href="http://www.w3.org/ns/mls#Process">http://www.w3.org/ns/mls#Process</seealso>
    let Process = Prefixed_Name(mls, "Process") |> PrefixedName
    /// <summary>
    ///   <para>mls:Feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/mls#Feature">http://www.w3.org/ns/mls#Feature</seealso>
    let Feature = Prefixed_Name(mls, "Feature") |> PrefixedName
    /// <summary>
    ///   <para>mls:hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/mls#hasValue">http://www.w3.org/ns/mls#hasValue</seealso>
    let hasValue = Prefixed_Name(mls, "hasValue") |> PrefixedName
    /// <summary>
    ///   <para>mls:Implementation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Implementation is an executable implementation of a machine learning algorithm, a script, or a workflow. It is versioned, and sometimes belongs to a library (e.g. WEKA).</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/mls#Implementation">http://www.w3.org/ns/mls#Implementation</seealso>
    let Implementation = Prefixed_Name(mls, "Implementation") |> PrefixedName
    /// <summary>
    ///   <para>mls:Algorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The algorithm regardless software implementation.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/mls#Algorithm">http://www.w3.org/ns/mls#Algorithm</seealso>
    let Algorithm = Prefixed_Name(mls, "Algorithm") |> PrefixedName
    /// <summary>
    ///   <para>mls:DataCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>DataCharacteristic is a distinguishing quality or property that distinguish one data from another.
    /// Such characteristics are often statistical ones (e.g., the number of instances
    /// or the number of features of a data set). They may be also informationtheoretic measures (e.g., class entropy of a categorical data set) or geometric measures of data complexity (e.g., the highest discriminatory power of any single feature in the data set).</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/mls#DataCharacteristic">http://www.w3.org/ns/mls#DataCharacteristic</seealso>
    let DataCharacteristic = Prefixed_Name(mls, "DataCharacteristic") |> PrefixedName
    /// <summary>
    ///   <para>mls:Data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Data is a data item composed of data examples and it may be of a various level of granularity and complexity.
    /// With regard to granularity, it can be a whole dataset (for instance, one main table and possibly other tables), or only a single table, or only a feature (e.g., a column of a table), or only an instance (e.g., row of a table), or a single feature-value pair.
    /// With regard to complexity, data examples are characterized by their datatype, which may be arbitrarily complex (e.g., instead of a table it can be an arbitrary graph).</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/mls#Data">http://www.w3.org/ns/mls#Data</seealso>
    let Data = Prefixed_Name(mls, "Data") |> PrefixedName
    /// <summary>
    ///   <para>mls:EvaluationMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>EvaluationMeasure is a measure to assess the performance of the model generated by the process that realizes the task. Examples are predictive accuracy or f-measure.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/mls#EvaluationMeasure">http://www.w3.org/ns/mls#EvaluationMeasure</seealso>
    let EvaluationMeasure = Prefixed_Name(mls, "EvaluationMeasure") |> PrefixedName
    /// <summary>
    ///   <para>mls:hasPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation which represents a part-whole relationship holding between an entity and its part.</para>
    /// labels<para>hasPart</para></remarks>
    /// <seealso href="http://www.w3.org/ns/mls#hasPart">http://www.w3.org/ns/mls#hasPart</seealso>
    let hasPart = Prefixed_Name(mls, "hasPart") |> PrefixedName
    /// <summary>
    ///   <para>mls:Experiment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Experiment is a collection of runs.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/mls#Experiment">http://www.w3.org/ns/mls#Experiment</seealso>
    let Experiment = Prefixed_Name(mls, "Experiment") |> PrefixedName
    /// <summary>
    ///   <para>mls:HyperParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Hyperparameter is a prior parameter of an implementation, i.e., a parameter which is set before its execution (e.g. C, the complexity parameter, in weka.SMO).</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/mls#HyperParameter">http://www.w3.org/ns/mls#HyperParameter</seealso>
    let HyperParameter = Prefixed_Name(mls, "HyperParameter") |> PrefixedName
    /// <summary>
    ///   <para>mls:defines</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/mls#defines">http://www.w3.org/ns/mls#defines</seealso>
    let defines = Prefixed_Name(mls, "defines") |> PrefixedName
    /// <summary>
    ///   <para>mls:Run</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Run is an execution of an implementation on a machine (computer). It is limited in time (has a start and end point), can be successful or failed.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/mls#Run">http://www.w3.org/ns/mls#Run</seealso>
    let Run = Prefixed_Name(mls, "Run") |> PrefixedName

    /// <summary>
    ///   <para>mls:FeatureCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/mls#FeatureCharacteristic">http://www.w3.org/ns/mls#FeatureCharacteristic</seealso>
    let FeatureCharacteristic =
        Prefixed_Name(mls, "FeatureCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>mls:HyperParameterSetting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>HyperParameterSetting is an entity which connects a hyperparameter and its value that is being set before an implementation execution.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/mls#HyperParameterSetting">http://www.w3.org/ns/mls#HyperParameterSetting</seealso>
    let HyperParameterSetting =
        Prefixed_Name(mls, "HyperParameterSetting") |> PrefixedName

    /// <summary>
    ///   <para>mls:specifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between an entity and the information content entity that specifies it.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/mls#specifiedBy">http://www.w3.org/ns/mls#specifiedBy</seealso>
    let specifiedBy = Prefixed_Name(mls, "specifiedBy") |> PrefixedName
    /// <summary>
    ///   <para>mls:implements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between an information entity and a specification that it conforms to.</para>
    /// labels<para>implements</para></remarks>
    /// <seealso href="http://www.w3.org/ns/mls#implements">http://www.w3.org/ns/mls#implements</seealso>
    let implements = Prefixed_Name(mls, "implements") |> PrefixedName
    /// <summary>
    ///   <para>mls:hasHyperParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between an implementation of a machine learning algorithm and its hyperparameter.</para>
    /// labels<para>hasHyperParameter</para></remarks>
    /// <seealso href="http://www.w3.org/ns/mls#hasHyperParameter">http://www.w3.org/ns/mls#hasHyperParameter</seealso>
    let hasHyperParameter = Prefixed_Name(mls, "hasHyperParameter") |> PrefixedName

    /// <summary>
    ///   <para>mls:ImplementationCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>ImplementationCharacteristic is a distinguishing quality or property that distinguish one implementation from another.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/mls#ImplementationCharacteristic">http://www.w3.org/ns/mls#ImplementationCharacteristic</seealso>
    let ImplementationCharacteristic =
        Prefixed_Name(mls, "ImplementationCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>mls:Model</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Model is a generalization of a set of training data able to predict values for unseen instances. It is an output from an execution of a data mining algorithm implementation. Models have a dual nature. They can be treated as data structures and as such represented, stored and manipulated. On the other hand, they act as functions and are executed, taking as input data examples and giving as output the result of applying the function to a data example. Models can also be divided into global or local ones. A global model has global coverage of a data set, i.e., it generalizes the whole data set. A local model, such as a pattern set, is a set of local hypotheses, i.e. each applies to a limited region of the data set.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/mls#Model">http://www.w3.org/ns/mls#Model</seealso>
    let Model = Prefixed_Name(mls, "Model") |> PrefixedName
    /// <summary>
    ///   <para>mls:ModelCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>ModelCharacteristic is a distinguishing quality or property that distinguish one model from another. An example model characetristic may be interpretabilty or a complexity of the model.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/mls#ModelCharacteristic">http://www.w3.org/ns/mls#ModelCharacteristic</seealso>
    let ModelCharacteristic = Prefixed_Name(mls, "ModelCharacteristic") |> PrefixedName
    /// <summary>
    ///   <para>mls:realizes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between a run and an algorithm, where the run realizes specifications formulated by the algorithm.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/mls#realizes">http://www.w3.org/ns/mls#realizes</seealso>
    let realizes = Prefixed_Name(mls, "realizes") |> PrefixedName
    /// <summary>
    ///   <para>mls:hasInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between a run and data that is taken as input to the run.</para>
    /// labels<para>hasInput</para></remarks>
    /// <seealso href="http://www.w3.org/ns/mls#hasInput">http://www.w3.org/ns/mls#hasInput</seealso>
    let hasInput = Prefixed_Name(mls, "hasInput") |> PrefixedName
    /// <summary>
    ///   <para>mls:Software</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Software is implemented computer programs, procedures, scripts or rules with associated documentation, possibly constituting an organized environment, stored in read/write memory for the purpose of being executed within a computer system.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/mls#Software">http://www.w3.org/ns/mls#Software</seealso>
    let Software = Prefixed_Name(mls, "Software") |> PrefixedName
    /// <summary>
    ///   <para>mls:Study</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Study is a collection of runs that belong together to do some kind of analysis on its results. This analysis can be general or very specific (e.g. a hypothesis test). Can be linked to files, data, that belong to it.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/mls#Study">http://www.w3.org/ns/mls#Study</seealso>
    let Study = Prefixed_Name(mls, "Study") |> PrefixedName
    /// <summary>
    ///   <para>mls:ModelEvaluation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>ModelEvaluation is a setting of a value of the performance measure  specified by the evaluation specification. It connects a measure specification with its value.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/mls#ModelEvaluation">http://www.w3.org/ns/mls#ModelEvaluation</seealso>
    let ModelEvaluation = Prefixed_Name(mls, "ModelEvaluation") |> PrefixedName
    /// <summary>
    ///   <para>mls:hasOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between a run and either a model or model evaluation that is produced on it’s output.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/mls#hasOutput">http://www.w3.org/ns/mls#hasOutput</seealso>
    let hasOutput = Prefixed_Name(mls, "hasOutput") |> PrefixedName
    /// <summary>
    ///   <para>mls:executes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between a run and an implemantation that is being executed during the run.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/mls#executes">http://www.w3.org/ns/mls#executes</seealso>
    let executes = Prefixed_Name(mls, "executes") |> PrefixedName
    /// <summary>
    ///   <para>mls:achieves</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between a run and a task, where the run achieves specifications formulated by the task.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/mls#achieves">http://www.w3.org/ns/mls#achieves</seealso>
    let achieves = Prefixed_Name(mls, "achieves") |> PrefixedName
    /// <summary>
    ///   <para>mls:definedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between a task and either the data or an evaluation specification pertinent to this task.</para>
    /// labels<para>definedOn</para></remarks>
    /// <seealso href="http://www.w3.org/ns/mls#definedOn">http://www.w3.org/ns/mls#definedOn</seealso>
    let definedOn = Prefixed_Name(mls, "definedOn") |> PrefixedName

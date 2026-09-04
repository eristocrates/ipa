#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module limo =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/limo-ontology/limo#" "limo"

    /// <summary>
    ///   <para>rdfs:comment : Describes a file that can be imported in a particular platform such as R or SAS and execute the model. This could also be a PMML-XML file.^^xsd:string</para>
    ///   <para>rdfs:label : limo:File^^xsd:string</para>
    ///   <a href="http://purl.org/limo-ontology/limo#File">limo:File</a>
    /// </summary>
    let File = _prefixId.prefix "File"

    let ``Information%20Systems%20Lab%20%28ISLab%29`` =
        _prefixId.prefix "Information%20Systems%20Lab%20%28ISLab%29"

    /// <summary>
    ///   <para>rdfs:comment : Describes a statistical or data mining method used for creating a model. We assume that this class uses a set of predefined concepts such as linear regression, logistic regression, markov models, support vector machine, random forest, neural networks etc.^^xsd:string</para>
    ///   <para>rdfs:label : limo:Method^^xsd:string</para>
    ///   <a href="http://purl.org/limo-ontology/limo#Method">limo:Method</a>
    /// </summary>
    let Method = _prefixId.prefix "Method"
    /// <summary>
    ///   <para>rdfs:comment : The actual predictive model that is described by the vocabulary.^^xsd:string</para>
    ///   <para>rdfs:label : limo:Model^^xsd:string</para>
    ///   <a href="http://purl.org/limo-ontology/limo#Model">limo:Model</a>
    /// </summary>
    let Model = _prefixId.prefix "Model"
    /// <summary>
    ///   <para>rdfs:comment : Describes the predictive power of a model.^^xsd:string</para>
    ///   <para>rdfs:label : limo:Power^^xsd:string</para>
    ///   <a href="http://purl.org/limo-ontology/limo#Power">limo:Power</a>
    /// </summary>
    let Power = _prefixId.prefix "Power"
    /// <summary>
    ///   <para>rdfs:comment : Represents the variables that are included in the predictive model.^^xsd:string</para>
    ///   <para>rdfs:label : limo:Variable^^xsd:string</para>
    ///   <a href="http://purl.org/limo-ontology/limo#Variable">limo:Variable</a>
    /// </summary>
    let Variable = _prefixId.prefix "Variable"
    /// <summary>
    ///   <para>rdfs:comment : The URL that the file can be accessed from.^^xsd:string</para>
    ///   <para>rdfs:label : limo:accessURL^^xsd:string</para>
    ///   <a href="http://purl.org/limo-ontology/limo#accessURL">limo:accessURL</a>
    /// </summary>
    let accessURL = _prefixId.prefix "accessURL"
    let akarm = _prefixId.prefix "akarm"
    /// <summary>
    ///   <para>rdfs:comment : Explicitly denotes that the predictive power of a model has been evaluated against the power of another model.^^xsd:string</para>
    ///   <para>rdfs:label : limo:baseline^^xsd:string</para>
    ///   <a href="http://purl.org/limo-ontology/limo#baseline">limo:baseline</a>
    /// </summary>
    let baseline = _prefixId.prefix "baseline"
    /// <summary>
    ///   <para>rdfs:comment : The person or organization that actually builds the model.^^xsd:string</para>
    ///   <para>rdfs:label : dct:creator^^xsd:string</para>
    ///   <a href="http://purl.org/limo-ontology/limo#creator">limo:creator</a>
    /// </summary>
    let creator = _prefixId.prefix "creator"
    /// <summary>
    ///   <para>rdfs:comment : Connects a model to the dataset that contains the actual data that have been used for the development of the model.^^xsd:string</para>
    ///   <para>rdfs:label : limo:data^^xsd:string</para>
    ///   <a href="http://purl.org/limo-ontology/limo#data">limo:data</a>
    /// </summary>
    let data = _prefixId.prefix "data"
    let ekal = _prefixId.prefix "ekal"
    /// <summary>
    ///   <para>rdfs:comment : Connects a model to the dataset that represents its evaluation data.^^xsd:string</para>
    ///   <para>rdfs:label : limo:evaluationData^^xsd:string</para>
    ///   <a href="http://purl.org/limo-ontology/limo#evaluationData">limo:evaluationData</a>
    /// </summary>
    let evaluationData = _prefixId.prefix "evaluationData"
    /// <summary>
    ///   <para>rdfs:comment : Is used to infer the predictive power of the model. The evaluation methods include out-of-sample evaluation with statistics such as Predicted Residual Sums of Squares, Root Mean Square Error or cross-validation techniques.^^xsd:stringrdfs:comment : mpla mpla^^xsd:string</para>
    ///   <para>rdfs:label : limo:evaluationMethod^^xsd:string</para>
    ///   <a href="http://purl.org/limo-ontology/limo#evaluationMethod">limo:evaluationMethod</a>
    /// </summary>
    let evaluationMethod = _prefixId.prefix "evaluationMethod"
    /// <summary>
    ///   <para>rdfs:comment : Connects a model with a relative file.^^xsd:string</para>
    ///   <para>rdfs:label : limo:file^^xsd:string</para>
    ///   <a href="http://purl.org/limo-ontology/limo#file">limo:file</a>
    /// </summary>
    let file = _prefixId.prefix "file"
    let kat = _prefixId.prefix "kat"
    /// <summary>
    ///   <para>rdfs:comment : Connects a model with its statistical or data mining method.^^xsd:string</para>
    ///   <para>rdfs:label : limo:method^^xsd:string</para>
    ///   <a href="http://purl.org/limo-ontology/limo#method">limo:method</a>
    /// </summary>
    let method = _prefixId.prefix "method"
    /// <summary>
    ///   <para>rdfs:comment : Describes the main categories of the model that can be developed, namely classification, regression, clustering and dimension reduction.^^xsd:string</para>
    ///   <para>rdfs:label : limo:modelType^^xsd:string</para>
    ///   <a href="http://purl.org/limo-ontology/limo#modelType">limo:modelType</a>
    /// </summary>
    let modelType = _prefixId.prefix "modelType"
    /// <summary>
    ///   <para>rdfs:comment : The actual value that the evaluation method produces.^^xsd:stringrdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : limo:outcome^^xsd:string</para>
    ///   <a href="http://purl.org/limo-ontology/limo#outcome">limo:outcome</a>
    /// </summary>
    let outcome = _prefixId.prefix "outcome"
    /// <summary>
    ///   <para>rdfs:comment : Connects a model to its predictive power.^^xsd:string</para>
    ///   <para>rdfs:label : limo:power^^xsd:string</para>
    ///   <a href="http://purl.org/limo-ontology/limo#power">limo:power</a>
    /// </summary>
    let power = _prefixId.prefix "power"
    /// <summary>
    ///   <para>rdfs:comment : Connects a model with the bibliographic resource it is published.^^xsd:string</para>
    ///   <para>rdfs:label : limo:publishedIn^^xsd:string</para>
    ///   <a href="http://purl.org/limo-ontology/limo#publishedIn">limo:publishedIn</a>
    /// </summary>
    let publishedIn = _prefixId.prefix "publishedIn"
    /// <summary>
    ///   <para>rdfs:comment : Connects a model with it's dataset.^^xsd:string</para>
    ///   <para>rdfs:label : limo:rawData^^xsd:string</para>
    ///   <a href="http://purl.org/limo-ontology/limo#rawData">limo:rawData</a>
    /// </summary>
    let rawData = _prefixId.prefix "rawData"
    let rdf = _prefixId.prefix "rdf"
    /// <summary>
    ///   <para>rdfs:comment : Dexcribes the spatial dimension of the model. The spatial dimension is derived from the actual data that has been employed.^^xsd:string</para>
    ///   <para>rdfs:label : limo:spatial^^xsd:string</para>
    ///   <a href="http://purl.org/limo-ontology/limo#spatial">limo:spatial</a>
    /// </summary>
    let spatial = _prefixId.prefix "spatial"
    let tambouris = _prefixId.prefix "tambouris"
    /// <summary>
    ///   <para>rdfs:comment : Describes the time period that the model covers. The time period reflects the period that is described in the actual data that have been used for the development of the model.^^xsd:string</para>
    ///   <para>rdfs:label : limo:temporal^^xsd:string</para>
    ///   <a href="http://purl.org/limo-ontology/limo#temporal">limo:temporal</a>
    /// </summary>
    let temporal = _prefixId.prefix "temporal"
    /// <summary>
    ///   <para>rdfs:comment : Connects a variable to its concept theme.^^xsd:string</para>
    ///   <para>rdfs:label : limo:theme^^xsd:string</para>
    ///   <a href="http://purl.org/limo-ontology/limo#theme">limo:theme</a>
    /// </summary>
    let theme = _prefixId.prefix "theme"
    /// <summary>
    ///   <para>rdfs:comment : Connects a model to a qb:DataSet that represents data that was used for the training of the model.^^xsd:string</para>
    ///   <para>rdfs:label : limo:trainingData^^xsd:string</para>
    ///   <a href="http://purl.org/limo-ontology/limo#trainingData">limo:trainingData</a>
    /// </summary>
    let trainingData = _prefixId.prefix "trainingData"
    let ttl = _prefixId.prefix "ttl"
    /// <summary>
    ///   <para>rdfs:comment : Denotes whether the variable is the response of the model or one of the predictors.^^xsd:string</para>
    ///   <para>rdfs:label : limo:usageType^^xsd:string</para>
    ///   <a href="http://purl.org/limo-ontology/limo#usageType">limo:usageType</a>
    /// </summary>
    let usageType = _prefixId.prefix "usageType"
    /// <summary>
    ///   <para>rdfs:comment : Connects a model to a qb:DataSet that represents data that was used for the validation of the model.^^xsd:string</para>
    ///   <para>rdfs:label : limo:validationData^^xsd:string</para>
    ///   <a href="http://purl.org/limo-ontology/limo#validationData">limo:validationData</a>
    /// </summary>
    let validationData = _prefixId.prefix "validationData"
    /// <summary>
    ///   <para>rdfs:comment : Connects a model to one of its variables.^^xsd:string</para>
    ///   <para>rdfs:label : limo:variable^^xsd:string</para>
    ///   <a href="http://purl.org/limo-ontology/limo#variable">limo:variable</a>
    /// </summary>
    let variable = _prefixId.prefix "variable"
    /// <summary>
    ///   <para>rdfs:comment : Denotes whether the variable is continuous, categorical or ordinal.^^xsd:string</para>
    ///   <para>rdfs:label : limo:variableType^^xsd:string</para>
    ///   <a href="http://purl.org/limo-ontology/limo#variableType">limo:variableType</a>
    /// </summary>
    let variableType = _prefixId.prefix "variableType"

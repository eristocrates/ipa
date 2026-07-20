namespace http.purl.org.limo_ontology.limo.hash

open DoxAletheia

module limo =
    let _namespace_name = "http://purl.org/limo-ontology/limo#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The actual predictive model that is described by the vocabulary.
    /// <see href="http://purl.org/limo-ontology/limo#Model"></see></summary>
    let Model = _prefix "Model"
    /// <summary>
    /// Represents the variables that are included in the predictive model.
    /// <see href="http://purl.org/limo-ontology/limo#Variable"></see></summary>
    let Variable = _prefix "Variable"
    /// <summary>
    /// Describes a file that can be imported in a particular platform such as R or SAS and execute the model. This could also be a PMML-XML file.
    /// <see href="http://purl.org/limo-ontology/limo#File"></see></summary>
    let File = _prefix "File"

    /// <summary>
    ///   <see href="http://purl.org/limo-ontology/limo#Information%20Systems%20Lab%20%28ISLab%29"></see>
    /// </summary>
    let ``Information%20Systems%20Lab%20%28ISLab%29`` =
        _prefix "Information%20Systems%20Lab%20%28ISLab%29"

    /// <summary>
    ///   <see href="http://purl.org/limo-ontology/limo#tambouris"></see>
    /// </summary>
    let tambouris = _prefix "tambouris"
    /// <summary>
    ///   <see href="http://purl.org/limo-ontology/limo#kat"></see>
    /// </summary>
    let kat = _prefix "kat"
    /// <summary>
    ///   <see href="http://purl.org/limo-ontology/limo#ekal"></see>
    /// </summary>
    let ekal = _prefix "ekal"
    /// <summary>
    ///   <see href="http://purl.org/limo-ontology/limo#akarm"></see>
    /// </summary>
    let akarm = _prefix "akarm"
    /// <summary>
    /// Describes a statistical or data mining method used for creating a model. We assume that this class uses a set of predefined concepts such as linear regression, logistic regression, markov models, support vector machine, random forest, neural networks etc.
    /// <see href="http://purl.org/limo-ontology/limo#Method"></see></summary>
    let Method = _prefix "Method"
    /// <summary>
    /// Describes the predictive power of a model.
    /// <see href="http://purl.org/limo-ontology/limo#Power"></see></summary>
    let Power = _prefix "Power"
    /// <summary>
    /// The URL that the file can be accessed from.
    /// <see href="http://purl.org/limo-ontology/limo#accessURL"></see></summary>
    let accessURL = _prefix "accessURL"
    /// <summary>
    /// Explicitly denotes that the predictive power of a model has been evaluated against the power of another model.
    /// <see href="http://purl.org/limo-ontology/limo#baseline"></see></summary>
    let baseline = _prefix "baseline"
    /// <summary>
    /// The person or organization that actually builds the model.
    /// <see href="http://purl.org/limo-ontology/limo#creator"></see></summary>
    let creator = _prefix "creator"
    /// <summary>
    /// Connects a model to the dataset that contains the actual data that have been used for the development of the model.
    /// <see href="http://purl.org/limo-ontology/limo#data"></see></summary>
    let data = _prefix "data"
    /// <summary>
    /// Connects a model to the dataset that represents its evaluation data.
    /// <see href="http://purl.org/limo-ontology/limo#evaluationData"></see></summary>
    let evaluationData = _prefix "evaluationData"
    /// <summary>
    /// Is used to infer the predictive power of the model. The evaluation methods include out-of-sample evaluation with statistics such as Predicted Residual Sums of Squares, Root Mean Square Error or cross-validation techniques.
    /// mpla mpla
    /// <see href="http://purl.org/limo-ontology/limo#evaluationMethod"></see></summary>
    let evaluationMethod = _prefix "evaluationMethod"
    /// <summary>
    /// Connects a model with a relative file.
    /// <see href="http://purl.org/limo-ontology/limo#file"></see></summary>
    let file = _prefix "file"
    /// <summary>
    /// Connects a model with its statistical or data mining method.
    /// <see href="http://purl.org/limo-ontology/limo#method"></see></summary>
    let method = _prefix "method"
    /// <summary>
    /// Describes the main categories of the model that can be developed, namely classification, regression, clustering and dimension reduction.
    /// <see href="http://purl.org/limo-ontology/limo#modelType"></see></summary>
    let modelType = _prefix "modelType"
    /// <summary>
    /// The actual value that the evaluation method produces.
    ///
    /// <see href="http://purl.org/limo-ontology/limo#outcome"></see></summary>
    let outcome = _prefix "outcome"
    /// <summary>
    /// Connects a model to its predictive power.
    /// <see href="http://purl.org/limo-ontology/limo#power"></see></summary>
    let power = _prefix "power"
    /// <summary>
    /// Connects a model with the bibliographic resource it is published.
    /// <see href="http://purl.org/limo-ontology/limo#publishedIn"></see></summary>
    let publishedIn = _prefix "publishedIn"
    /// <summary>
    /// Connects a model with it's dataset.
    /// <see href="http://purl.org/limo-ontology/limo#rawData"></see></summary>
    let rawData = _prefix "rawData"
    /// <summary>
    ///   <see href="http://purl.org/limo-ontology/limo#rdf"></see>
    /// </summary>
    let rdf = _prefix "rdf"
    /// <summary>
    /// Dexcribes the spatial dimension of the model. The spatial dimension is derived from the actual data that has been employed.
    /// <see href="http://purl.org/limo-ontology/limo#spatial"></see></summary>
    let spatial = _prefix "spatial"
    /// <summary>
    /// Describes the time period that the model covers. The time period reflects the period that is described in the actual data that have been used for the development of the model.
    /// <see href="http://purl.org/limo-ontology/limo#temporal"></see></summary>
    let temporal = _prefix "temporal"
    /// <summary>
    /// Connects a variable to its concept theme.
    /// <see href="http://purl.org/limo-ontology/limo#theme"></see></summary>
    let theme = _prefix "theme"
    /// <summary>
    /// Connects a model to a qb:DataSet that represents data that was used for the training of the model.
    /// <see href="http://purl.org/limo-ontology/limo#trainingData"></see></summary>
    let trainingData = _prefix "trainingData"
    /// <summary>
    ///   <see href="http://purl.org/limo-ontology/limo#ttl"></see>
    /// </summary>
    let ttl = _prefix "ttl"
    /// <summary>
    /// Denotes whether the variable is the response of the model or one of the predictors.
    /// <see href="http://purl.org/limo-ontology/limo#usageType"></see></summary>
    let usageType = _prefix "usageType"
    /// <summary>
    /// Connects a model to a qb:DataSet that represents data that was used for the validation of the model.
    /// <see href="http://purl.org/limo-ontology/limo#validationData"></see></summary>
    let validationData = _prefix "validationData"
    /// <summary>
    /// Connects a model to one of its variables.
    /// <see href="http://purl.org/limo-ontology/limo#variable"></see></summary>
    let variable = _prefix "variable"
    /// <summary>
    /// Denotes whether the variable is continuous, categorical or ordinal.
    /// <see href="http://purl.org/limo-ontology/limo#variableType"></see></summary>
    let variableType = _prefix "variableType"

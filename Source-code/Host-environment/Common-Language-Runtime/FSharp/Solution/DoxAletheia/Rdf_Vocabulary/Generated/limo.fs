namespace http.purl.org.limo_ontology.limo.hash

open DoxAletheia.Rdf_Vocabulary

module limo =
    let _namespace_name = "http://purl.org/limo-ontology/limo#"
    /// <summary>
    /// The actual predictive model that is described by the vocabulary.
    /// <see href="http://purl.org/limo-ontology/limo#Model"></see></summary>
    let Model = Namespaced_IRI.parse _namespace_name "Model" |> NamespacedName
    /// <summary>
    /// Represents the variables that are included in the predictive model.
    /// <see href="http://purl.org/limo-ontology/limo#Variable"></see></summary>
    let Variable = Namespaced_IRI.parse _namespace_name "Variable" |> NamespacedName
    /// <summary>
    /// Describes a file that can be imported in a particular platform such as R or SAS and execute the model. This could also be a PMML-XML file.
    /// <see href="http://purl.org/limo-ontology/limo#File"></see></summary>
    let File = Namespaced_IRI.parse _namespace_name "File" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/limo-ontology/limo#Information%20Systems%20Lab%20%28ISLab%29"></see>
    /// </summary>
    let ``Information%20Systems%20Lab%20%28ISLab%29`` =
        Namespaced_IRI.parse _namespace_name "Information%20Systems%20Lab%20%28ISLab%29" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/limo-ontology/limo#tambouris"></see>
    /// </summary>
    let tambouris = Namespaced_IRI.parse _namespace_name "tambouris" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/limo-ontology/limo#kat"></see>
    /// </summary>
    let kat = Namespaced_IRI.parse _namespace_name "kat" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/limo-ontology/limo#ekal"></see>
    /// </summary>
    let ekal = Namespaced_IRI.parse _namespace_name "ekal" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/limo-ontology/limo#akarm"></see>
    /// </summary>
    let akarm = Namespaced_IRI.parse _namespace_name "akarm" |> NamespacedName
    /// <summary>
    /// Describes a statistical or data mining method used for creating a model. We assume that this class uses a set of predefined concepts such as linear regression, logistic regression, markov models, support vector machine, random forest, neural networks etc.
    /// <see href="http://purl.org/limo-ontology/limo#Method"></see></summary>
    let Method = Namespaced_IRI.parse _namespace_name "Method" |> NamespacedName
    /// <summary>
    /// Describes the predictive power of a model.
    /// <see href="http://purl.org/limo-ontology/limo#Power"></see></summary>
    let Power = Namespaced_IRI.parse _namespace_name "Power" |> NamespacedName
    /// <summary>
    /// The URL that the file can be accessed from.
    /// <see href="http://purl.org/limo-ontology/limo#accessURL"></see></summary>
    let accessURL = Namespaced_IRI.parse _namespace_name "accessURL" |> NamespacedName
    /// <summary>
    /// Explicitly denotes that the predictive power of a model has been evaluated against the power of another model.
    /// <see href="http://purl.org/limo-ontology/limo#baseline"></see></summary>
    let baseline = Namespaced_IRI.parse _namespace_name "baseline" |> NamespacedName
    /// <summary>
    /// The person or organization that actually builds the model.
    /// <see href="http://purl.org/limo-ontology/limo#creator"></see></summary>
    let creator = Namespaced_IRI.parse _namespace_name "creator" |> NamespacedName
    /// <summary>
    /// Connects a model to the dataset that contains the actual data that have been used for the development of the model.
    /// <see href="http://purl.org/limo-ontology/limo#data"></see></summary>
    let data = Namespaced_IRI.parse _namespace_name "data" |> NamespacedName

    /// <summary>
    /// Connects a model to the dataset that represents its evaluation data.
    /// <see href="http://purl.org/limo-ontology/limo#evaluationData"></see></summary>
    let evaluationData =
        Namespaced_IRI.parse _namespace_name "evaluationData" |> NamespacedName

    /// <summary>
    /// Is used to infer the predictive power of the model. The evaluation methods include out-of-sample evaluation with statistics such as Predicted Residual Sums of Squares, Root Mean Square Error or cross-validation techniques.
    /// mpla mpla
    /// <see href="http://purl.org/limo-ontology/limo#evaluationMethod"></see></summary>
    let evaluationMethod =
        Namespaced_IRI.parse _namespace_name "evaluationMethod" |> NamespacedName

    /// <summary>
    /// Connects a model with a relative file.
    /// <see href="http://purl.org/limo-ontology/limo#file"></see></summary>
    let file = Namespaced_IRI.parse _namespace_name "file" |> NamespacedName
    /// <summary>
    /// Connects a model with its statistical or data mining method.
    /// <see href="http://purl.org/limo-ontology/limo#method"></see></summary>
    let method = Namespaced_IRI.parse _namespace_name "method" |> NamespacedName
    /// <summary>
    /// Describes the main categories of the model that can be developed, namely classification, regression, clustering and dimension reduction.
    /// <see href="http://purl.org/limo-ontology/limo#modelType"></see></summary>
    let modelType = Namespaced_IRI.parse _namespace_name "modelType" |> NamespacedName
    /// <summary>
    /// The actual value that the evaluation method produces.
    ///
    /// <see href="http://purl.org/limo-ontology/limo#outcome"></see></summary>
    let outcome = Namespaced_IRI.parse _namespace_name "outcome" |> NamespacedName
    /// <summary>
    /// Connects a model to its predictive power.
    /// <see href="http://purl.org/limo-ontology/limo#power"></see></summary>
    let power = Namespaced_IRI.parse _namespace_name "power" |> NamespacedName

    /// <summary>
    /// Connects a model with the bibliographic resource it is published.
    /// <see href="http://purl.org/limo-ontology/limo#publishedIn"></see></summary>
    let publishedIn =
        Namespaced_IRI.parse _namespace_name "publishedIn" |> NamespacedName

    /// <summary>
    /// Connects a model with it's dataset.
    /// <see href="http://purl.org/limo-ontology/limo#rawData"></see></summary>
    let rawData = Namespaced_IRI.parse _namespace_name "rawData" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/limo-ontology/limo#rdf"></see>
    /// </summary>
    let rdf = Namespaced_IRI.parse _namespace_name "rdf" |> NamespacedName
    /// <summary>
    /// Dexcribes the spatial dimension of the model. The spatial dimension is derived from the actual data that has been employed.
    /// <see href="http://purl.org/limo-ontology/limo#spatial"></see></summary>
    let spatial = Namespaced_IRI.parse _namespace_name "spatial" |> NamespacedName
    /// <summary>
    /// Describes the time period that the model covers. The time period reflects the period that is described in the actual data that have been used for the development of the model.
    /// <see href="http://purl.org/limo-ontology/limo#temporal"></see></summary>
    let temporal = Namespaced_IRI.parse _namespace_name "temporal" |> NamespacedName
    /// <summary>
    /// Connects a variable to its concept theme.
    /// <see href="http://purl.org/limo-ontology/limo#theme"></see></summary>
    let theme = Namespaced_IRI.parse _namespace_name "theme" |> NamespacedName

    /// <summary>
    /// Connects a model to a qb:DataSet that represents data that was used for the training of the model.
    /// <see href="http://purl.org/limo-ontology/limo#trainingData"></see></summary>
    let trainingData =
        Namespaced_IRI.parse _namespace_name "trainingData" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/limo-ontology/limo#ttl"></see>
    /// </summary>
    let ttl = Namespaced_IRI.parse _namespace_name "ttl" |> NamespacedName
    /// <summary>
    /// Denotes whether the variable is the response of the model or one of the predictors.
    /// <see href="http://purl.org/limo-ontology/limo#usageType"></see></summary>
    let usageType = Namespaced_IRI.parse _namespace_name "usageType" |> NamespacedName

    /// <summary>
    /// Connects a model to a qb:DataSet that represents data that was used for the validation of the model.
    /// <see href="http://purl.org/limo-ontology/limo#validationData"></see></summary>
    let validationData =
        Namespaced_IRI.parse _namespace_name "validationData" |> NamespacedName

    /// <summary>
    /// Connects a model to one of its variables.
    /// <see href="http://purl.org/limo-ontology/limo#variable"></see></summary>
    let variable = Namespaced_IRI.parse _namespace_name "variable" |> NamespacedName

    /// <summary>
    /// Denotes whether the variable is continuous, categorical or ordinal.
    /// <see href="http://purl.org/limo-ontology/limo#variableType"></see></summary>
    let variableType =
        Namespaced_IRI.parse _namespace_name "variableType" |> NamespacedName

namespace http.linked.opendata.cz.ontology.ldvm.slash

open DoxAletheia.Rdf_Vocabulary

module ldvm =
    let _namespace_name = "http://linked.opendata.cz/ontology/ldvm/"

    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/AnalyzerInstance"></see>
    /// </summary>
    let AnalyzerInstance =
        Namespaced_IRI.parse _namespace_name "AnalyzerInstance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/AnalyzerTemplate"></see>
    /// </summary>
    let AnalyzerTemplate =
        Namespaced_IRI.parse _namespace_name "AnalyzerTemplate" |> NamespacedName

    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/ComponentConfiguration"></see>
    /// </summary>
    let ComponentConfiguration =
        Namespaced_IRI.parse _namespace_name "ComponentConfiguration" |> NamespacedName

    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/ComponentInstance"></see>
    /// </summary>
    let ComponentInstance =
        Namespaced_IRI.parse _namespace_name "ComponentInstance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/ComponentTemplate"></see>
    /// </summary>
    let ComponentTemplate =
        Namespaced_IRI.parse _namespace_name "ComponentTemplate" |> NamespacedName

    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/DataPortInstance"></see>
    /// </summary>
    let DataPortInstance =
        Namespaced_IRI.parse _namespace_name "DataPortInstance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/DataPortTemplate"></see>
    /// </summary>
    let DataPortTemplate =
        Namespaced_IRI.parse _namespace_name "DataPortTemplate" |> NamespacedName

    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/DataSourceInstance"></see>
    /// </summary>
    let DataSourceInstance =
        Namespaced_IRI.parse _namespace_name "DataSourceInstance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/DataSourceTemplate"></see>
    /// </summary>
    let DataSourceTemplate =
        Namespaced_IRI.parse _namespace_name "DataSourceTemplate" |> NamespacedName

    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/Descriptor"></see>
    /// </summary>
    let Descriptor = Namespaced_IRI.parse _namespace_name "Descriptor" |> NamespacedName
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/Feature"></see>
    /// </summary>
    let Feature = Namespaced_IRI.parse _namespace_name "Feature" |> NamespacedName

    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/InputDataPortTemplate"></see>
    /// </summary>
    let InputDataPortTemplate =
        Namespaced_IRI.parse _namespace_name "InputDataPortTemplate" |> NamespacedName

    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/MandatoryFeature"></see>
    /// </summary>
    let MandatoryFeature =
        Namespaced_IRI.parse _namespace_name "MandatoryFeature" |> NamespacedName

    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/OptionalFeature"></see>
    /// </summary>
    let OptionalFeature =
        Namespaced_IRI.parse _namespace_name "OptionalFeature" |> NamespacedName

    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/OutputDataPortTemplate"></see>
    /// </summary>
    let OutputDataPortTemplate =
        Namespaced_IRI.parse _namespace_name "OutputDataPortTemplate" |> NamespacedName

    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/Pipeline"></see>
    /// </summary>
    let Pipeline = Namespaced_IRI.parse _namespace_name "Pipeline" |> NamespacedName

    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/TransformerInstance"></see>
    /// </summary>
    let TransformerInstance =
        Namespaced_IRI.parse _namespace_name "TransformerInstance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/TransformerTemplate"></see>
    /// </summary>
    let TransformerTemplate =
        Namespaced_IRI.parse _namespace_name "TransformerTemplate" |> NamespacedName

    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/VisualizerInstance"></see>
    /// </summary>
    let VisualizerInstance =
        Namespaced_IRI.parse _namespace_name "VisualizerInstance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/VisualizerTemplate"></see>
    /// </summary>
    let VisualizerTemplate =
        Namespaced_IRI.parse _namespace_name "VisualizerTemplate" |> NamespacedName

    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/appliesTo"></see>
    /// </summary>
    let appliesTo = Namespaced_IRI.parse _namespace_name "appliesTo" |> NamespacedName
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/boundTo"></see>
    /// </summary>
    let boundTo = Namespaced_IRI.parse _namespace_name "boundTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/componentConfigurationInstance"></see>
    /// </summary>
    let componentConfigurationInstance =
        Namespaced_IRI.parse _namespace_name "componentConfigurationInstance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/componentConfigurationTemplate"></see>
    /// </summary>
    let componentConfigurationTemplate =
        Namespaced_IRI.parse _namespace_name "componentConfigurationTemplate" |> NamespacedName

    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/configurationSPARQL"></see>
    /// </summary>
    let configurationSPARQL =
        Namespaced_IRI.parse _namespace_name "configurationSPARQL" |> NamespacedName

    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/dataportInstanceOf"></see>
    /// </summary>
    let dataportInstanceOf =
        Namespaced_IRI.parse _namespace_name "dataportInstanceOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/descriptor"></see>
    /// </summary>
    let descriptor = Namespaced_IRI.parse _namespace_name "descriptor" |> NamespacedName
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/feature"></see>
    /// </summary>
    let feature = Namespaced_IRI.parse _namespace_name "feature" |> NamespacedName

    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/inputInstance"></see>
    /// </summary>
    let inputInstance =
        Namespaced_IRI.parse _namespace_name "inputInstance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/inputTemplate"></see>
    /// </summary>
    let inputTemplate =
        Namespaced_IRI.parse _namespace_name "inputTemplate" |> NamespacedName

    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/instanceOf"></see>
    /// </summary>
    let instanceOf = Namespaced_IRI.parse _namespace_name "instanceOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/member"></see>
    /// </summary>
    let member_ = Namespaced_IRI.parse _namespace_name "member" |> NamespacedName

    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/nestedBoundTo"></see>
    /// </summary>
    let nestedBoundTo =
        Namespaced_IRI.parse _namespace_name "nestedBoundTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/nestedPipeline"></see>
    /// </summary>
    let nestedPipeline =
        Namespaced_IRI.parse _namespace_name "nestedPipeline" |> NamespacedName

    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/outputDataSample"></see>
    /// </summary>
    let outputDataSample =
        Namespaced_IRI.parse _namespace_name "outputDataSample" |> NamespacedName

    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/outputInstance"></see>
    /// </summary>
    let outputInstance =
        Namespaced_IRI.parse _namespace_name "outputInstance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/outputTemplate"></see>
    /// </summary>
    let outputTemplate =
        Namespaced_IRI.parse _namespace_name "outputTemplate" |> NamespacedName

    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/query"></see>
    /// </summary>
    let query = Namespaced_IRI.parse _namespace_name "query" |> NamespacedName

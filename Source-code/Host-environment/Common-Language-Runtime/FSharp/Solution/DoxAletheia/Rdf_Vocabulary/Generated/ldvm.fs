namespace http.linked.opendata.cz.ontology.ldvm.slash

open DoxAletheia

module ldvm =
    let _namespace_name = "http://linked.opendata.cz/ontology/ldvm/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/AnalyzerInstance"></see>
    /// </summary>
    let AnalyzerInstance = _prefix "AnalyzerInstance"
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/AnalyzerTemplate"></see>
    /// </summary>
    let AnalyzerTemplate = _prefix "AnalyzerTemplate"
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/ComponentConfiguration"></see>
    /// </summary>
    let ComponentConfiguration = _prefix "ComponentConfiguration"
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/ComponentInstance"></see>
    /// </summary>
    let ComponentInstance = _prefix "ComponentInstance"
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/ComponentTemplate"></see>
    /// </summary>
    let ComponentTemplate = _prefix "ComponentTemplate"
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/DataPortInstance"></see>
    /// </summary>
    let DataPortInstance = _prefix "DataPortInstance"
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/DataPortTemplate"></see>
    /// </summary>
    let DataPortTemplate = _prefix "DataPortTemplate"
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/DataSourceInstance"></see>
    /// </summary>
    let DataSourceInstance = _prefix "DataSourceInstance"
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/DataSourceTemplate"></see>
    /// </summary>
    let DataSourceTemplate = _prefix "DataSourceTemplate"
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/Descriptor"></see>
    /// </summary>
    let Descriptor = _prefix "Descriptor"
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/Feature"></see>
    /// </summary>
    let Feature = _prefix "Feature"
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/InputDataPortTemplate"></see>
    /// </summary>
    let InputDataPortTemplate = _prefix "InputDataPortTemplate"
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/MandatoryFeature"></see>
    /// </summary>
    let MandatoryFeature = _prefix "MandatoryFeature"
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/OptionalFeature"></see>
    /// </summary>
    let OptionalFeature = _prefix "OptionalFeature"
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/OutputDataPortTemplate"></see>
    /// </summary>
    let OutputDataPortTemplate = _prefix "OutputDataPortTemplate"
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/Pipeline"></see>
    /// </summary>
    let Pipeline = _prefix "Pipeline"
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/TransformerInstance"></see>
    /// </summary>
    let TransformerInstance = _prefix "TransformerInstance"
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/TransformerTemplate"></see>
    /// </summary>
    let TransformerTemplate = _prefix "TransformerTemplate"
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/VisualizerInstance"></see>
    /// </summary>
    let VisualizerInstance = _prefix "VisualizerInstance"
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/VisualizerTemplate"></see>
    /// </summary>
    let VisualizerTemplate = _prefix "VisualizerTemplate"
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/appliesTo"></see>
    /// </summary>
    let appliesTo = _prefix "appliesTo"
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/boundTo"></see>
    /// </summary>
    let boundTo = _prefix "boundTo"
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/componentConfigurationInstance"></see>
    /// </summary>
    let componentConfigurationInstance = _prefix "componentConfigurationInstance"
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/componentConfigurationTemplate"></see>
    /// </summary>
    let componentConfigurationTemplate = _prefix "componentConfigurationTemplate"
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/configurationSPARQL"></see>
    /// </summary>
    let configurationSPARQL = _prefix "configurationSPARQL"
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/dataportInstanceOf"></see>
    /// </summary>
    let dataportInstanceOf = _prefix "dataportInstanceOf"
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/descriptor"></see>
    /// </summary>
    let descriptor = _prefix "descriptor"
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/feature"></see>
    /// </summary>
    let feature = _prefix "feature"
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/inputInstance"></see>
    /// </summary>
    let inputInstance = _prefix "inputInstance"
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/inputTemplate"></see>
    /// </summary>
    let inputTemplate = _prefix "inputTemplate"
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/instanceOf"></see>
    /// </summary>
    let instanceOf = _prefix "instanceOf"
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/member"></see>
    /// </summary>
    let member_ = _prefix "member"
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/nestedBoundTo"></see>
    /// </summary>
    let nestedBoundTo = _prefix "nestedBoundTo"
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/nestedPipeline"></see>
    /// </summary>
    let nestedPipeline = _prefix "nestedPipeline"
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/outputDataSample"></see>
    /// </summary>
    let outputDataSample = _prefix "outputDataSample"
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/outputInstance"></see>
    /// </summary>
    let outputInstance = _prefix "outputInstance"
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/outputTemplate"></see>
    /// </summary>
    let outputTemplate = _prefix "outputTemplate"
    /// <summary>
    ///   <see href="http://linked.opendata.cz/ontology/ldvm/query"></see>
    /// </summary>
    let query = _prefix "query"

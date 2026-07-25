namespace http.linked.opendata.cz.ontology.ldvm.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ldvm =
    let _namespace_iri = Namespace_Iri ldvm |> NamespaceIRI
    /// <summary>
    ///   <para>ldvm:AnalyzerTemplate</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/AnalyzerTemplate">http://linked.opendata.cz/ontology/ldvm/AnalyzerTemplate</seealso>
    let AnalyzerTemplate = Prefixed_Name(ldvm, "AnalyzerTemplate") |> PrefixedName

    /// <summary>
    ///   <para>ldvm:ComponentConfiguration</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/ComponentConfiguration">http://linked.opendata.cz/ontology/ldvm/ComponentConfiguration</seealso>
    let ComponentConfiguration =
        Prefixed_Name(ldvm, "ComponentConfiguration") |> PrefixedName

    /// <summary>
    ///   <para>ldvm:DataSourceTemplate</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/DataSourceTemplate">http://linked.opendata.cz/ontology/ldvm/DataSourceTemplate</seealso>
    let DataSourceTemplate = Prefixed_Name(ldvm, "DataSourceTemplate") |> PrefixedName
    /// <summary>
    ///   <para>ldvm:Descriptor</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/Descriptor">http://linked.opendata.cz/ontology/ldvm/Descriptor</seealso>
    let Descriptor = Prefixed_Name(ldvm, "Descriptor") |> PrefixedName
    /// <summary>
    ///   <para>ldvm:Feature</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/Feature">http://linked.opendata.cz/ontology/ldvm/Feature</seealso>
    let Feature = Prefixed_Name(ldvm, "Feature") |> PrefixedName

    /// <summary>
    ///   <para>ldvm:InputDataPortTemplate</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/InputDataPortTemplate">http://linked.opendata.cz/ontology/ldvm/InputDataPortTemplate</seealso>
    let InputDataPortTemplate =
        Prefixed_Name(ldvm, "InputDataPortTemplate") |> PrefixedName

    /// <summary>
    ///   <para>ldvm:appliesTo</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/appliesTo">http://linked.opendata.cz/ontology/ldvm/appliesTo</seealso>
    let appliesTo = Prefixed_Name(ldvm, "appliesTo") |> PrefixedName
    /// <summary>
    ///   <para>ldvm:boundTo</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/boundTo">http://linked.opendata.cz/ontology/ldvm/boundTo</seealso>
    let boundTo = Prefixed_Name(ldvm, "boundTo") |> PrefixedName

    /// <summary>
    ///   <para>ldvm:componentConfigurationInstance</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/componentConfigurationInstance">http://linked.opendata.cz/ontology/ldvm/componentConfigurationInstance</seealso>
    let componentConfigurationInstance =
        Prefixed_Name(ldvm, "componentConfigurationInstance") |> PrefixedName

    /// <summary>
    ///   <para>ldvm:componentConfigurationTemplate</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/componentConfigurationTemplate">http://linked.opendata.cz/ontology/ldvm/componentConfigurationTemplate</seealso>
    let componentConfigurationTemplate =
        Prefixed_Name(ldvm, "componentConfigurationTemplate") |> PrefixedName

    /// <summary>
    ///   <para>ldvm:ComponentInstance</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/ComponentInstance">http://linked.opendata.cz/ontology/ldvm/ComponentInstance</seealso>
    let ComponentInstance = Prefixed_Name(ldvm, "ComponentInstance") |> PrefixedName
    /// <summary>
    ///   <para>ldvm:MandatoryFeature</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/MandatoryFeature">http://linked.opendata.cz/ontology/ldvm/MandatoryFeature</seealso>
    let MandatoryFeature = Prefixed_Name(ldvm, "MandatoryFeature") |> PrefixedName
    /// <summary>
    ///   <para>ldvm:TransformerTemplate</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/TransformerTemplate">http://linked.opendata.cz/ontology/ldvm/TransformerTemplate</seealso>
    let TransformerTemplate = Prefixed_Name(ldvm, "TransformerTemplate") |> PrefixedName
    /// <summary>
    ///   <para>ldvm:configurationSPARQL</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/configurationSPARQL">http://linked.opendata.cz/ontology/ldvm/configurationSPARQL</seealso>
    let configurationSPARQL = Prefixed_Name(ldvm, "configurationSPARQL") |> PrefixedName
    /// <summary>
    ///   <para>ldvm:inputInstance</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/inputInstance">http://linked.opendata.cz/ontology/ldvm/inputInstance</seealso>
    let inputInstance = Prefixed_Name(ldvm, "inputInstance") |> PrefixedName
    /// <summary>
    ///   <para>ldvm:instanceOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/instanceOf">http://linked.opendata.cz/ontology/ldvm/instanceOf</seealso>
    let instanceOf = Prefixed_Name(ldvm, "instanceOf") |> PrefixedName
    /// <summary>
    ///   <para>ldvm:outputDataSample</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/outputDataSample">http://linked.opendata.cz/ontology/ldvm/outputDataSample</seealso>
    let outputDataSample = Prefixed_Name(ldvm, "outputDataSample") |> PrefixedName
    /// <summary>
    ///   <para>ldvm:outputInstance</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/outputInstance">http://linked.opendata.cz/ontology/ldvm/outputInstance</seealso>
    let outputInstance = Prefixed_Name(ldvm, "outputInstance") |> PrefixedName
    /// <summary>
    ///   <para>ldvm:DataPortTemplate</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/DataPortTemplate">http://linked.opendata.cz/ontology/ldvm/DataPortTemplate</seealso>
    let DataPortTemplate = Prefixed_Name(ldvm, "DataPortTemplate") |> PrefixedName
    /// <summary>
    ///   <para>ldvm:Pipeline</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/Pipeline">http://linked.opendata.cz/ontology/ldvm/Pipeline</seealso>
    let Pipeline = Prefixed_Name(ldvm, "Pipeline") |> PrefixedName
    /// <summary>
    ///   <para>ldvm:VisualizerInstance</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/VisualizerInstance">http://linked.opendata.cz/ontology/ldvm/VisualizerInstance</seealso>
    let VisualizerInstance = Prefixed_Name(ldvm, "VisualizerInstance") |> PrefixedName
    /// <summary>
    ///   <para>ldvm:dataportInstanceOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/dataportInstanceOf">http://linked.opendata.cz/ontology/ldvm/dataportInstanceOf</seealso>
    let dataportInstanceOf = Prefixed_Name(ldvm, "dataportInstanceOf") |> PrefixedName
    /// <summary>
    ///   <para>ldvm:inputTemplate</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/inputTemplate">http://linked.opendata.cz/ontology/ldvm/inputTemplate</seealso>
    let inputTemplate = Prefixed_Name(ldvm, "inputTemplate") |> PrefixedName
    /// <summary>
    ///   <para>ldvm:outputTemplate</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/outputTemplate">http://linked.opendata.cz/ontology/ldvm/outputTemplate</seealso>
    let outputTemplate = Prefixed_Name(ldvm, "outputTemplate") |> PrefixedName

    /// <summary>
    ///   <para>ldvm:OutputDataPortTemplate</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/OutputDataPortTemplate">http://linked.opendata.cz/ontology/ldvm/OutputDataPortTemplate</seealso>
    let OutputDataPortTemplate =
        Prefixed_Name(ldvm, "OutputDataPortTemplate") |> PrefixedName

    /// <summary>
    ///   <para>ldvm:nestedPipeline</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/nestedPipeline">http://linked.opendata.cz/ontology/ldvm/nestedPipeline</seealso>
    let nestedPipeline = Prefixed_Name(ldvm, "nestedPipeline") |> PrefixedName
    /// <summary>
    ///   <para>ldvm:query</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/query">http://linked.opendata.cz/ontology/ldvm/query</seealso>
    let query = Prefixed_Name(ldvm, "query") |> PrefixedName
    /// <summary>
    ///   <para>ldvm:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>voaf:Vocabulary</para>
    /// </remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/">http://linked.opendata.cz/ontology/ldvm/</seealso>
    let _prefix_iri = Prefixed_Name(ldvm, "") |> PrefixedName
    /// <summary>
    ///   <para>ldvm:AnalyzerInstance</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/AnalyzerInstance">http://linked.opendata.cz/ontology/ldvm/AnalyzerInstance</seealso>
    let AnalyzerInstance = Prefixed_Name(ldvm, "AnalyzerInstance") |> PrefixedName
    /// <summary>
    ///   <para>ldvm:ComponentTemplate</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/ComponentTemplate">http://linked.opendata.cz/ontology/ldvm/ComponentTemplate</seealso>
    let ComponentTemplate = Prefixed_Name(ldvm, "ComponentTemplate") |> PrefixedName
    /// <summary>
    ///   <para>ldvm:DataPortInstance</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/DataPortInstance">http://linked.opendata.cz/ontology/ldvm/DataPortInstance</seealso>
    let DataPortInstance = Prefixed_Name(ldvm, "DataPortInstance") |> PrefixedName
    /// <summary>
    ///   <para>ldvm:DataSourceInstance</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/DataSourceInstance">http://linked.opendata.cz/ontology/ldvm/DataSourceInstance</seealso>
    let DataSourceInstance = Prefixed_Name(ldvm, "DataSourceInstance") |> PrefixedName
    /// <summary>
    ///   <para>ldvm:OptionalFeature</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/OptionalFeature">http://linked.opendata.cz/ontology/ldvm/OptionalFeature</seealso>
    let OptionalFeature = Prefixed_Name(ldvm, "OptionalFeature") |> PrefixedName
    /// <summary>
    ///   <para>ldvm:TransformerInstance</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/TransformerInstance">http://linked.opendata.cz/ontology/ldvm/TransformerInstance</seealso>
    let TransformerInstance = Prefixed_Name(ldvm, "TransformerInstance") |> PrefixedName
    /// <summary>
    ///   <para>ldvm:VisualizerTemplate</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/VisualizerTemplate">http://linked.opendata.cz/ontology/ldvm/VisualizerTemplate</seealso>
    let VisualizerTemplate = Prefixed_Name(ldvm, "VisualizerTemplate") |> PrefixedName
    /// <summary>
    ///   <para>ldvm:descriptor</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/descriptor">http://linked.opendata.cz/ontology/ldvm/descriptor</seealso>
    let descriptor = Prefixed_Name(ldvm, "descriptor") |> PrefixedName
    /// <summary>
    ///   <para>ldvm:feature</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/feature">http://linked.opendata.cz/ontology/ldvm/feature</seealso>
    let feature = Prefixed_Name(ldvm, "feature") |> PrefixedName
    /// <summary>
    ///   <para>ldvm:member</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/member">http://linked.opendata.cz/ontology/ldvm/member</seealso>
    let member_ = Prefixed_Name(ldvm, "member") |> PrefixedName
    /// <summary>
    ///   <para>ldvm:nestedBoundTo</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linked.opendata.cz/ontology/ldvm/nestedBoundTo">http://linked.opendata.cz/ontology/ldvm/nestedBoundTo</seealso>
    let nestedBoundTo = Prefixed_Name(ldvm, "nestedBoundTo") |> PrefixedName

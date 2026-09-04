#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ldvm =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://linked.opendata.cz/ontology/ldvm/" "ldvm"

    let _namespaceIri = _prefixId.prefix ""
    let AnalyzerInstance = _prefixId.prefix "AnalyzerInstance"
    let AnalyzerTemplate = _prefixId.prefix "AnalyzerTemplate"
    let ComponentConfiguration = _prefixId.prefix "ComponentConfiguration"
    let ComponentInstance = _prefixId.prefix "ComponentInstance"
    let ComponentTemplate = _prefixId.prefix "ComponentTemplate"
    let DataPortInstance = _prefixId.prefix "DataPortInstance"
    let DataPortTemplate = _prefixId.prefix "DataPortTemplate"
    let DataSourceInstance = _prefixId.prefix "DataSourceInstance"
    let DataSourceTemplate = _prefixId.prefix "DataSourceTemplate"
    let Descriptor = _prefixId.prefix "Descriptor"
    let Feature = _prefixId.prefix "Feature"
    let InputDataPortTemplate = _prefixId.prefix "InputDataPortTemplate"
    let MandatoryFeature = _prefixId.prefix "MandatoryFeature"
    let OptionalFeature = _prefixId.prefix "OptionalFeature"
    let OutputDataPortTemplate = _prefixId.prefix "OutputDataPortTemplate"
    let Pipeline = _prefixId.prefix "Pipeline"
    let TransformerInstance = _prefixId.prefix "TransformerInstance"
    let TransformerTemplate = _prefixId.prefix "TransformerTemplate"
    let VisualizerInstance = _prefixId.prefix "VisualizerInstance"
    let VisualizerTemplate = _prefixId.prefix "VisualizerTemplate"
    let appliesTo = _prefixId.prefix "appliesTo"
    let boundTo = _prefixId.prefix "boundTo"

    let componentConfigurationInstance =
        _prefixId.prefix "componentConfigurationInstance"

    let componentConfigurationTemplate =
        _prefixId.prefix "componentConfigurationTemplate"

    let configurationSPARQL = _prefixId.prefix "configurationSPARQL"
    let dataportInstanceOf = _prefixId.prefix "dataportInstanceOf"
    let descriptor = _prefixId.prefix "descriptor"
    let feature = _prefixId.prefix "feature"
    let inputInstance = _prefixId.prefix "inputInstance"
    let inputTemplate = _prefixId.prefix "inputTemplate"
    let instanceOf = _prefixId.prefix "instanceOf"
    let member_ = _prefixId.prefix "member"
    let nestedBoundTo = _prefixId.prefix "nestedBoundTo"
    let nestedPipeline = _prefixId.prefix "nestedPipeline"
    let outputDataSample = _prefixId.prefix "outputDataSample"
    let outputInstance = _prefixId.prefix "outputInstance"
    let outputTemplate = _prefixId.prefix "outputTemplate"
    let query = _prefixId.prefix "query"

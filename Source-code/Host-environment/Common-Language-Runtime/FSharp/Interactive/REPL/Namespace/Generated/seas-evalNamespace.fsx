#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``seas-eval`` =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/seas/" "seas-eval"
    let _namespaceIri = _prefixId.prefix ""
    let FeatureOfInterest = _prefixId.prefix "FeatureOfInterest"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Forecast</para>
    ///   <para>rdfs:comment : A Forecast is the execution of some Forecasting procedure by some Forecaster.</para>
    ///   <a href="https://w3id.org/seas/Forecast">seas-qudt:Forecast</a>
    /// </summary>
    let Forecast = _prefixId.prefix "Forecast"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Forecaster</para>
    ///   <para>rdfs:comment : A Forecaster implements some Forecasting procedure, and may generate forecasts.</para>
    ///   <a href="https://w3id.org/seas/Forecaster">seas-qudt:Forecaster</a>
    /// </summary>
    let Forecaster = _prefixId.prefix "Forecaster"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Forecasting</para>
    ///   <para>rdfs:comment : Forecasting is the procedure of forecasting the state of a property.</para>
    ///   <a href="https://w3id.org/seas/Forecasting">seas-qudt:Forecasting</a>
    /// </summary>
    let Forecasting = _prefixId.prefix "Forecasting"
    let ForecastingOntology = _prefixId.prefix "ForecastingOntology"
    let ``ForecastingOntology_1.0`` = _prefixId.prefix "ForecastingOntology-1.0"
    let ``ForecastingOntology_1.1`` = _prefixId.prefix "ForecastingOntology-1.1"
    let Property = _prefixId.prefix "Property"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : forecasts</para>
    ///   <para>rdfs:comment : Links an Forecasting, Forecaster, or Forecast, to the feature of interest a property of which it forecasts.
    ///
    /// If `x` forecasts a property, then it also forecasts the feature of interest of this property:
    ///
    /// ```
    /// seas:forecastsProperty &lt; seas:forecasts o seas:isPropertyOf .
    /// ```
    ///
    /// If a forecasting forecasts a feature of interest, then any Forecaster that implements this forecasting also forecasts this feature of interest, and any Forecast that used this forecasting also forecasts this feature of interest. Furthermore, if a Forecaster forecasts a feature of interest, then any Forecast executed by this Forecaster also forecasts this feature of interest:
    ///
    /// ```
    /// seas:forecasts &lt; pep:usedProcedure o seas:forecasts .
    /// seas:forecasts &lt; pep:usedProcedure o seas:forecasts .
    /// seas:forecasts &lt; pep:madeBy o seas:forecasts .
    /// ```
    /// </para>
    ///   <a href="https://w3id.org/seas/forecasts">seas-qudt:forecasts</a>
    /// </summary>
    let forecasts = _prefixId.prefix "forecasts"
    /// <summary>
    ///   <para>rdfs:comment : Links an Forecasting, Forecaster, or Forecast, to the property it forecasts.
    ///
    /// If a forecasting forecasts a property, then any Forecaster that implements this forecasting also forecasts this property, and any Forecast that used this forecasting also forecasts this property. Furthermore, if a Forecaster forecasts a property, then any Forecast executed by this Forecaster also forecasts this property:
    ///
    /// ```
    /// seas:forecastsProperty &lt; pep:implements o seas:forecastsProperty .
    /// seas:forecastsProperty &lt; pep:usedProcedure o seas:forecastsProperty .
    /// seas:forecastsProperty &lt; pep:madeBy o seas:forecastsProperty .
    /// ```</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : forecasts property</para>
    ///   <a href="https://w3id.org/seas/forecastsProperty">seas-qudt:forecastsProperty</a>
    /// </summary>
    let forecastsProperty = _prefixId.prefix "forecastsProperty"

namespace http.meta.icos_cp.eu.ontologies.cpmeta.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cpmeta =
    let _namespace_iri = Namespace_Iri cpmeta |> NamespaceIRI
    /// <summary>
    ///   <para>cpmeta:FluxnetStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>FLUXNET station</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/FluxnetStation">http://meta.icos-cp.eu/ontologies/cpmeta/FluxnetStation</seealso>
    let FluxnetStation = Prefixed_Name(cpmeta, "FluxnetStation") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasFunding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has funding</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasFunding">http://meta.icos-cp.eu/ontologies/cpmeta/hasFunding</seealso>
    let hasFunding = Prefixed_Name(cpmeta, "hasFunding") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:DataAcquisition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/DataAcquisition">http://meta.icos-cp.eu/ontologies/cpmeta/DataAcquisition</seealso>
    let DataAcquisition = Prefixed_Name(cpmeta, "DataAcquisition") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:etcRawTimeSerMultiZip</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:ObjectFormat</para>
    ///
    /// labels<para>Multi-file zip archive with ETC raw time series</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/etcRawTimeSerMultiZip">http://meta.icos-cp.eu/ontologies/cpmeta/etcRawTimeSerMultiZip</seealso>
    let etcRawTimeSerMultiZip =
        Prefixed_Name(cpmeta, "etcRawTimeSerMultiZip") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:excel</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:ObjectFormat</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Microsoft Excel (of unspecified structure)</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/excel">http://meta.icos-cp.eu/ontologies/cpmeta/excel</seealso>
    let excel = Prefixed_Name(cpmeta, "excel") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:funderIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>funder identifier</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/funderIdentifier">http://meta.icos-cp.eu/ontologies/cpmeta/funderIdentifier</seealso>
    let funderIdentifier = Prefixed_Name(cpmeta, "funderIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:hasActualColumnNames</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Contains a JSON array with actual column names</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasActualColumnNames">http://meta.icos-cp.eu/ontologies/cpmeta/hasActualColumnNames</seealso>
    let hasActualColumnNames =
        Prefixed_Name(cpmeta, "hasActualColumnNames") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:hasActualVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasActualVariable">http://meta.icos-cp.eu/ontologies/cpmeta/hasActualVariable</seealso>
    let hasActualVariable = Prefixed_Name(cpmeta, "hasActualVariable") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:hasAncillaryDataValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>parent property for ancillary value properties whose values are plain literals (not from vocabularies)</para>
    /// labels<para>ancillary data value</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasAncillaryDataValue">http://meta.icos-cp.eu/ontologies/cpmeta/hasAncillaryDataValue</seealso>
    let hasAncillaryDataValue =
        Prefixed_Name(cpmeta, "hasAncillaryDataValue") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:hasAncillaryObjectValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>parent property for ancillary value properties whose values come from controlled vocabularies</para>
    /// labels<para>ancillary object value</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasAncillaryObjectValue">http://meta.icos-cp.eu/ontologies/cpmeta/hasAncillaryObjectValue</seealso>
    let hasAncillaryObjectValue =
        Prefixed_Name(cpmeta, "hasAncillaryObjectValue") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:hasCitationString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>a synthetic property; the RDF triples with it as a predicate are to be created by business-logic-based inference, not inserted into the triple store explicitly</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasCitationString">http://meta.icos-cp.eu/ontologies/cpmeta/hasCitationString</seealso>
    let hasCitationString = Prefixed_Name(cpmeta, "hasCitationString") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:isOptionalColumn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/isOptionalColumn">http://meta.icos-cp.eu/ontologies/cpmeta/isOptionalColumn</seealso>
    let isOptionalColumn = Prefixed_Name(cpmeta, "isOptionalColumn") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:isQualityFlagFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is a quality flag for</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/isQualityFlagFor">http://meta.icos-cp.eu/ontologies/cpmeta/isQualityFlagFor</seealso>
    let isQualityFlagFor = Prefixed_Name(cpmeta, "isQualityFlagFor") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:isRegexColumn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/isRegexColumn">http://meta.icos-cp.eu/ontologies/cpmeta/isRegexColumn</seealso>
    let isRegexColumn = Prefixed_Name(cpmeta, "isRegexColumn") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:isRegexVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/isRegexVariable">http://meta.icos-cp.eu/ontologies/cpmeta/isRegexVariable</seealso>
    let isRegexVariable = Prefixed_Name(cpmeta, "isRegexVariable") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:iso8601dateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:ValueFormat</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Internally represented as int64 milliseconds since Unix epoch.</para>
    /// labels<para>Date-and-time stamp in ISO-8601 format</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/iso8601dateTime">http://meta.icos-cp.eu/ontologies/cpmeta/iso8601dateTime</seealso>
    let iso8601dateTime = Prefixed_Name(cpmeta, "iso8601dateTime") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:belongsToTheNetworkOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>belongs to thematic center</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/belongsToTheNetworkOf">http://meta.icos-cp.eu/ontologies/cpmeta/belongsToTheNetworkOf</seealso>
    let belongsToTheNetworkOf =
        Prefixed_Name(cpmeta, "belongsToTheNetworkOf") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:hasWesternBound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>western bound</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasWesternBound">http://meta.icos-cp.eu/ontologies/cpmeta/hasWesternBound</seealso>
    let hasWesternBound = Prefixed_Name(cpmeta, "hasWesternBound") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasKeywords</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>String representing a comma-separated list of keywords</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasKeywords">http://meta.icos-cp.eu/ontologies/cpmeta/hasKeywords</seealso>
    let hasKeywords = Prefixed_Name(cpmeta, "hasKeywords") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:isNextVersionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/isNextVersionOf">http://meta.icos-cp.eu/ontologies/cpmeta/isNextVersionOf</seealso>
    let isNextVersionOf = Prefixed_Name(cpmeta, "isNextVersionOf") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:asciiEtcHalfHourlyProductTimeSer</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:ObjectFormat</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The first two columns are expected to be the beginning and the end of the averaging period in yyyyMMddHHmm format (no DST)</para>
    /// labels<para>ICOS ETC half-hourly product CSV</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/asciiEtcHalfHourlyProductTimeSer">http://meta.icos-cp.eu/ontologies/cpmeta/asciiEtcHalfHourlyProductTimeSer</seealso>
    let asciiEtcHalfHourlyProductTimeSer =
        Prefixed_Name(cpmeta, "asciiEtcHalfHourlyProductTimeSer") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:asciiEtcTimeSer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:ObjectFormat</para>
    ///
    /// labels<para>Time series in ICOS Sweden format</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/asciiEtcTimeSer">http://meta.icos-cp.eu/ontologies/cpmeta/asciiEtcTimeSer</seealso>
    let asciiEtcTimeSer = Prefixed_Name(cpmeta, "asciiEtcTimeSer") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasStartDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>start date</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasStartDate">http://meta.icos-cp.eu/ontologies/cpmeta/hasStartDate</seealso>
    let hasStartDate = Prefixed_Name(cpmeta, "hasStartDate") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasStationClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Station Class</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasStationClass">http://meta.icos-cp.eu/ontologies/cpmeta/hasStationClass</seealso>
    let hasStationClass = Prefixed_Name(cpmeta, "hasStationClass") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:hasTemporalResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasTemporalResolution">http://meta.icos-cp.eu/ontologies/cpmeta/hasTemporalResolution</seealso>
    let hasTemporalResolution =
        Prefixed_Name(cpmeta, "hasTemporalResolution") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:hasUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>unit of measurement</para>
    /// labels<para>unit</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasUnit">http://meta.icos-cp.eu/ontologies/cpmeta/hasUnit</seealso>
    let hasUnit = Prefixed_Name(cpmeta, "hasUnit") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:IcosStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>ICOS station</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/IcosStation">http://meta.icos-cp.eu/ontologies/cpmeta/IcosStation</seealso>
    let IcosStation = Prefixed_Name(cpmeta, "IcosStation") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:AncillaryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>contains the ancillary value(s), submission date, and optional information date</para>
    /// labels<para>Ancillary Entry</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/AncillaryEntry">http://meta.icos-cp.eu/ontologies/cpmeta/AncillaryEntry</seealso>
    let AncillaryEntry = Prefixed_Name(cpmeta, "AncillaryEntry") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasFunder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>funder</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasFunder">http://meta.icos-cp.eu/ontologies/cpmeta/hasFunder</seealso>
    let hasFunder = Prefixed_Name(cpmeta, "hasFunder") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:IngosStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>InGOS station</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/IngosStation">http://meta.icos-cp.eu/ontologies/cpmeta/IngosStation</seealso>
    let IngosStation = Prefixed_Name(cpmeta, "IngosStation") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:Instrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/Instrument">http://meta.icos-cp.eu/ontologies/cpmeta/Instrument</seealso>
    let Instrument = Prefixed_Name(cpmeta, "Instrument") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:hasHideFromSearchPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasHideFromSearchPolicy">http://meta.icos-cp.eu/ontologies/cpmeta/hasHideFromSearchPolicy</seealso>
    let hasHideFromSearchPolicy =
        Prefixed_Name(cpmeta, "hasHideFromSearchPolicy") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:hasPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasPolicy">http://meta.icos-cp.eu/ontologies/cpmeta/hasPolicy</seealso>
    let hasPolicy = Prefixed_Name(cpmeta, "hasPolicy") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:hasInstrumentComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasInstrumentComponent">http://meta.icos-cp.eu/ontologies/cpmeta/hasInstrumentComponent</seealso>
    let hasInstrumentComponent =
        Prefixed_Name(cpmeta, "hasInstrumentComponent") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:hasKeyword</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A "virtual" property, created for keyword search in SPARQL. A multi-value counterpart of cpmeta:hasKeywords, which contains a string with comma-separated list of keywords.</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasKeyword">http://meta.icos-cp.eu/ontologies/cpmeta/hasKeyword</seealso>
    let hasKeyword = Prefixed_Name(cpmeta, "hasKeyword") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasLabelingDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>the date when the station was approved by ICOS and got labelled as an ICOS station</para>
    /// labels<para>labelling date</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasLabelingDate">http://meta.icos-cp.eu/ontologies/cpmeta/hasLabelingDate</seealso>
    let hasLabelingDate = Prefixed_Name(cpmeta, "hasLabelingDate") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasMarkerIcon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>URL link to an icon that can be used by web apps to show e.g. locations of stations</para>
    /// labels<para>has marker icon</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasMarkerIcon">http://meta.icos-cp.eu/ontologies/cpmeta/hasMarkerIcon</seealso>
    let hasMarkerIcon = Prefixed_Name(cpmeta, "hasMarkerIcon") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:hasMeanAnnualPrecip</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>measured in mm</para>
    /// labels<para>mean annual precipitation</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasMeanAnnualPrecip">http://meta.icos-cp.eu/ontologies/cpmeta/hasMeanAnnualPrecip</seealso>
    let hasMeanAnnualPrecip =
        Prefixed_Name(cpmeta, "hasMeanAnnualPrecip") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:hasMeanAnnualRadiation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>measured in W m-2</para>
    /// labels<para>mean annual radiation</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasMeanAnnualRadiation">http://meta.icos-cp.eu/ontologies/cpmeta/hasMeanAnnualRadiation</seealso>
    let hasMeanAnnualRadiation =
        Prefixed_Name(cpmeta, "hasMeanAnnualRadiation") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:hasMeanAnnualTemp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>measured in °C</para>
    /// labels<para>mean annual temperature</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasMeanAnnualTemp">http://meta.icos-cp.eu/ontologies/cpmeta/hasMeanAnnualTemp</seealso>
    let hasMeanAnnualTemp = Prefixed_Name(cpmeta, "hasMeanAnnualTemp") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasMinValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasMinValue">http://meta.icos-cp.eu/ontologies/cpmeta/hasMinValue</seealso>
    let hasMinValue = Prefixed_Name(cpmeta, "hasMinValue") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasNumberOfRows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>number of rows</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasNumberOfRows">http://meta.icos-cp.eu/ontologies/cpmeta/hasNumberOfRows</seealso>
    let hasNumberOfRows = Prefixed_Name(cpmeta, "hasNumberOfRows") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:hasOperationalPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>operational period</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasOperationalPeriod">http://meta.icos-cp.eu/ontologies/cpmeta/hasOperationalPeriod</seealso>
    let hasOperationalPeriod =
        Prefixed_Name(cpmeta, "hasOperationalPeriod") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:hasOrcidId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Orcid ID</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasOrcidId">http://meta.icos-cp.eu/ontologies/cpmeta/hasOrcidId</seealso>
    let hasOrcidId = Prefixed_Name(cpmeta, "hasOrcidId") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasStringId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>umbrella property for organizing id-related properties</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasStringId">http://meta.icos-cp.eu/ontologies/cpmeta/hasStringId</seealso>
    let hasStringId = Prefixed_Name(cpmeta, "hasStringId") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasOtcId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasOtcId">http://meta.icos-cp.eu/ontologies/cpmeta/hasOtcId</seealso>
    let hasOtcId = Prefixed_Name(cpmeta, "hasOtcId") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:hasResponsibleOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>responsible organization</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasResponsibleOrganization">http://meta.icos-cp.eu/ontologies/cpmeta/hasResponsibleOrganization</seealso>
    let hasResponsibleOrganization =
        Prefixed_Name(cpmeta, "hasResponsibleOrganization") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:hasSamplingHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasSamplingHeight">http://meta.icos-cp.eu/ontologies/cpmeta/hasSamplingHeight</seealso>
    let hasSamplingHeight = Prefixed_Name(cpmeta, "hasSamplingHeight") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasSha256sum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>SHA-256 hashsum</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasSha256sum">http://meta.icos-cp.eu/ontologies/cpmeta/hasSha256sum</seealso>
    let hasSha256sum = Prefixed_Name(cpmeta, "hasSha256sum") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasSizeInBytes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasSizeInBytes">http://meta.icos-cp.eu/ontologies/cpmeta/hasSizeInBytes</seealso>
    let hasSizeInBytes = Prefixed_Name(cpmeta, "hasSizeInBytes") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:hasSkipPidMintingPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasSkipPidMintingPolicy">http://meta.icos-cp.eu/ontologies/cpmeta/hasSkipPidMintingPolicy</seealso>
    let hasSkipPidMintingPolicy =
        Prefixed_Name(cpmeta, "hasSkipPidMintingPolicy") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:hasSkipStoragePolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasSkipStoragePolicy">http://meta.icos-cp.eu/ontologies/cpmeta/hasSkipStoragePolicy</seealso>
    let hasSkipStoragePolicy =
        Prefixed_Name(cpmeta, "hasSkipStoragePolicy") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>voaf:Vocabulary</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/">http://meta.icos-cp.eu/ontologies/cpmeta/</seealso>
    let _prefix_iri = Prefixed_Name(cpmeta, "") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:AS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Atmospheric station</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/AS">http://meta.icos-cp.eu/ontologies/cpmeta/AS</seealso>
    let AS = Prefixed_Name(cpmeta, "AS") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:SpatialCoverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Spatial Coverage</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/SpatialCoverage">http://meta.icos-cp.eu/ontologies/cpmeta/SpatialCoverage</seealso>
    let SpatialCoverage = Prefixed_Name(cpmeta, "SpatialCoverage") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasNorthernBound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>northern bound</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasNorthernBound">http://meta.icos-cp.eu/ontologies/cpmeta/hasNorthernBound</seealso>
    let hasNorthernBound = Prefixed_Name(cpmeta, "hasNorthernBound") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:atOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>at organization</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/atOrganization">http://meta.icos-cp.eu/ontologies/cpmeta/atOrganization</seealso>
    let atOrganization = Prefixed_Name(cpmeta, "atOrganization") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:ObjectEncoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/ObjectEncoding">http://meta.icos-cp.eu/ontologies/cpmeta/ObjectEncoding</seealso>
    let ObjectEncoding = Prefixed_Name(cpmeta, "ObjectEncoding") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasEmail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>E-mail</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasEmail">http://meta.icos-cp.eu/ontologies/cpmeta/hasEmail</seealso>
    let hasEmail = Prefixed_Name(cpmeta, "hasEmail") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasLastName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>last name</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasLastName">http://meta.icos-cp.eu/ontologies/cpmeta/hasLastName</seealso>
    let hasLastName = Prefixed_Name(cpmeta, "hasLastName") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:Project</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/Project">http://meta.icos-cp.eu/ontologies/cpmeta/Project</seealso>
    let Project = Prefixed_Name(cpmeta, "Project") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:QuantityKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The kind of physical quantity, for example volume, length, concentration. Can be basic or derived, standard or non-standard. Implies an associated physical quantity dimension but does not have a fixed unit of measurement.</para>
    /// labels<para>Quantity Kind</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/QuantityKind">http://meta.icos-cp.eu/ontologies/cpmeta/QuantityKind</seealso>
    let QuantityKind = Prefixed_Name(cpmeta, "QuantityKind") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:SimpleDataObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/SimpleDataObject">http://meta.icos-cp.eu/ontologies/cpmeta/SimpleDataObject</seealso>
    let SimpleDataObject = Prefixed_Name(cpmeta, "SimpleDataObject") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:SpatialDataObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/SpatialDataObject">http://meta.icos-cp.eu/ontologies/cpmeta/SpatialDataObject</seealso>
    let SpatialDataObject = Prefixed_Name(cpmeta, "SpatialDataObject") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:SimpleObjectSpec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Simple Object specification</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/SimpleObjectSpec">http://meta.icos-cp.eu/ontologies/cpmeta/SimpleObjectSpec</seealso>
    let SimpleObjectSpec = Prefixed_Name(cpmeta, "SimpleObjectSpec") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:hasDocumentationUri</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>documentation link</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasDocumentationUri">http://meta.icos-cp.eu/ontologies/cpmeta/hasDocumentationUri</seealso>
    let hasDocumentationUri =
        Prefixed_Name(cpmeta, "hasDocumentationUri") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:hasDoi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasDoi">http://meta.icos-cp.eu/ontologies/cpmeta/hasDoi</seealso>
    let hasDoi = Prefixed_Name(cpmeta, "hasDoi") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasElevation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Elevation above sea level in meters</para>
    /// labels<para>Elevation</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasElevation">http://meta.icos-cp.eu/ontologies/cpmeta/hasElevation</seealso>
    let hasElevation = Prefixed_Name(cpmeta, "hasElevation") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:koppen_Dwd</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:ClimateZone</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dwd">http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dwd</seealso>
    let koppen_Dwd = Prefixed_Name(cpmeta, "koppen_Dwd") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:koppen_EF</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:ClimateZone</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_EF">http://meta.icos-cp.eu/ontologies/cpmeta/koppen_EF</seealso>
    let koppen_EF = Prefixed_Name(cpmeta, "koppen_EF") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:koppen_ET</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:ClimateZone</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_ET">http://meta.icos-cp.eu/ontologies/cpmeta/koppen_ET</seealso>
    let koppen_ET = Prefixed_Name(cpmeta, "koppen_ET") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:locatedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>located at</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/locatedAt">http://meta.icos-cp.eu/ontologies/cpmeta/locatedAt</seealso>
    let locatedAt = Prefixed_Name(cpmeta, "locatedAt") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:netcdf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:ObjectFormat</para>
    ///
    /// labels<para>NetCDF (spatial)</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/netcdf">http://meta.icos-cp.eu/ontologies/cpmeta/netcdf</seealso>
    let netcdf = Prefixed_Name(cpmeta, "netcdf") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:netcdfTimeSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:ObjectFormat</para>
    ///
    /// labels<para>NetCDF (time series)</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/netcdfTimeSeries">http://meta.icos-cp.eu/ontologies/cpmeta/netcdfTimeSeries</seealso>
    let netcdfTimeSeries = Prefixed_Name(cpmeta, "netcdfTimeSeries") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:otcRawData</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:ObjectFormat</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>ICOS OTC Raw Data</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/otcRawData">http://meta.icos-cp.eu/ontologies/cpmeta/otcRawData</seealso>
    let otcRawData = Prefixed_Name(cpmeta, "otcRawData") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:plainFileEncoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:ObjectEncoding</para>
    ///
    /// labels<para>plain file</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/plainFileEncoding">http://meta.icos-cp.eu/ontologies/cpmeta/plainFileEncoding</seealso>
    let plainFileEncoding = Prefixed_Name(cpmeta, "plainFileEncoding") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:string</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:ValueFormat</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/string">http://meta.icos-cp.eu/ontologies/cpmeta/string</seealso>
    let string = Prefixed_Name(cpmeta, "string") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:wasHostedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/wasHostedBy">http://meta.icos-cp.eu/ontologies/cpmeta/wasHostedBy</seealso>
    let wasHostedBy = Prefixed_Name(cpmeta, "wasHostedBy") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:wasPerformedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>instrument used to perform data acquisition</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/wasPerformedWith">http://meta.icos-cp.eu/ontologies/cpmeta/wasPerformedWith</seealso>
    let wasPerformedWith = Prefixed_Name(cpmeta, "wasPerformedWith") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:zipEncoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:ObjectEncoding</para>
    ///
    /// labels<para>zip</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/zipEncoding">http://meta.icos-cp.eu/ontologies/cpmeta/zipEncoding</seealso>
    let zipEncoding = Prefixed_Name(cpmeta, "zipEncoding") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasVendor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasVendor">http://meta.icos-cp.eu/ontologies/cpmeta/hasVendor</seealso>
    let hasVendor = Prefixed_Name(cpmeta, "hasVendor") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:LatLonBox</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/LatLonBox">http://meta.icos-cp.eu/ontologies/cpmeta/LatLonBox</seealso>
    let LatLonBox = Prefixed_Name(cpmeta, "LatLonBox") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:AncillaryDatum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/AncillaryDatum">http://meta.icos-cp.eu/ontologies/cpmeta/AncillaryDatum</seealso>
    let AncillaryDatum = Prefixed_Name(cpmeta, "AncillaryDatum") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:containsDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>contains dataset</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/containsDataset">http://meta.icos-cp.eu/ontologies/cpmeta/containsDataset</seealso>
    let containsDataset = Prefixed_Name(cpmeta, "containsDataset") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasMaxValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasMaxValue">http://meta.icos-cp.eu/ontologies/cpmeta/hasMaxValue</seealso>
    let hasMaxValue = Prefixed_Name(cpmeta, "hasMaxValue") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has membership</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasMembership">http://meta.icos-cp.eu/ontologies/cpmeta/hasMembership</seealso>
    let hasMembership = Prefixed_Name(cpmeta, "hasMembership") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:ObjectFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/ObjectFormat">http://meta.icos-cp.eu/ontologies/cpmeta/ObjectFormat</seealso>
    let ObjectFormat = Prefixed_Name(cpmeta, "ObjectFormat") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasFirstName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>first name</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasFirstName">http://meta.icos-cp.eu/ontologies/cpmeta/hasFirstName</seealso>
    let hasFirstName = Prefixed_Name(cpmeta, "hasFirstName") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:Position</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Position</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/Position">http://meta.icos-cp.eu/ontologies/cpmeta/Position</seealso>
    let Position = Prefixed_Name(cpmeta, "Position") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasLongitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Decimal degrees in WGS84/GRS80</para>
    /// labels<para>Longitude</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasLongitude">http://meta.icos-cp.eu/ontologies/cpmeta/hasLongitude</seealso>
    let hasLongitude = Prefixed_Name(cpmeta, "hasLongitude") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:AncillaryValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>the class of ancillary values coming from controlled vocabularies</para>
    /// labels<para>Ancillary Value</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/AncillaryValue">http://meta.icos-cp.eu/ontologies/cpmeta/AncillaryValue</seealso>
    let AncillaryValue = Prefixed_Name(cpmeta, "AncillaryValue") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:AtmoStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>ATMO station</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/AtmoStation">http://meta.icos-cp.eu/ontologies/cpmeta/AtmoStation</seealso>
    let AtmoStation = Prefixed_Name(cpmeta, "AtmoStation") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:Station</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/Station">http://meta.icos-cp.eu/ontologies/cpmeta/Station</seealso>
    let Station = Prefixed_Name(cpmeta, "Station") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/Organization">http://meta.icos-cp.eu/ontologies/cpmeta/Organization</seealso>
    let Organization = Prefixed_Name(cpmeta, "Organization") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:Collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/Collection">http://meta.icos-cp.eu/ontologies/cpmeta/Collection</seealso>
    let Collection = Prefixed_Name(cpmeta, "Collection") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:binEtcRawTimeSer</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:ObjectFormat</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Raw binary ETC station data</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/binEtcRawTimeSer">http://meta.icos-cp.eu/ontologies/cpmeta/binEtcRawTimeSer</seealso>
    let binEtcRawTimeSer = Prefixed_Name(cpmeta, "binEtcRawTimeSer") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:bmpChar</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:ValueFormat</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>a character from the basic multilingual plane</para>
    /// labels<para>UTF-16 character</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/bmpChar">http://meta.icos-cp.eu/ontologies/cpmeta/bmpChar</seealso>
    let bmpChar = Prefixed_Name(cpmeta, "bmpChar") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Country</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/country">http://meta.icos-cp.eu/ontologies/cpmeta/country</seealso>
    let country = Prefixed_Name(cpmeta, "country") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:csvWithIso8601tsFirstCol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:ObjectFormat</para>
    ///
    /// labels<para>CSV with ISO8601 timestamp as first column</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/csvWithIso8601tsFirstCol">http://meta.icos-cp.eu/ontologies/cpmeta/csvWithIso8601tsFirstCol</seealso>
    let csvWithIso8601tsFirstCol =
        Prefixed_Name(cpmeta, "csvWithIso8601tsFirstCol") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:etcDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:ValueFormat</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>d/m/yyyy</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/etcDate">http://meta.icos-cp.eu/ontologies/cpmeta/etcDate</seealso>
    let etcDate = Prefixed_Name(cpmeta, "etcDate") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:float32</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:ValueFormat</para>
    ///
    /// labels<para>32-bit floating point value</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/float32">http://meta.icos-cp.eu/ontologies/cpmeta/float32</seealso>
    let float32 = Prefixed_Name(cpmeta, "float32") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:float64</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:ValueFormat</para>
    ///
    /// labels<para>64-bit floating point value</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/float64">http://meta.icos-cp.eu/ontologies/cpmeta/float64</seealso>
    let float64 = Prefixed_Name(cpmeta, "float64") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:funderIdentifierType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>funder identifier type</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/funderIdentifierType">http://meta.icos-cp.eu/ontologies/cpmeta/funderIdentifierType</seealso>
    let funderIdentifierType =
        Prefixed_Name(cpmeta, "funderIdentifierType") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:gzipEncoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:ObjectEncoding</para>
    ///
    /// labels<para>gzip</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/gzipEncoding">http://meta.icos-cp.eu/ontologies/cpmeta/gzipEncoding</seealso>
    let gzipEncoding = Prefixed_Name(cpmeta, "gzipEncoding") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasAncillaryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>ancillary entry associated with a station</para>
    /// labels<para>ancillary entry</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasAncillaryEntry">http://meta.icos-cp.eu/ontologies/cpmeta/hasAncillaryEntry</seealso>
    let hasAncillaryEntry = Prefixed_Name(cpmeta, "hasAncillaryEntry") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:hasAssociatedPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>associated publication</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasAssociatedPublication">http://meta.icos-cp.eu/ontologies/cpmeta/hasAssociatedPublication</seealso>
    let hasAssociatedPublication =
        Prefixed_Name(cpmeta, "hasAssociatedPublication") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:hasAtcId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasAtcId">http://meta.icos-cp.eu/ontologies/cpmeta/hasAtcId</seealso>
    let hasAtcId = Prefixed_Name(cpmeta, "hasAtcId") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasTcId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasTcId">http://meta.icos-cp.eu/ontologies/cpmeta/hasTcId</seealso>
    let hasTcId = Prefixed_Name(cpmeta, "hasTcId") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:hasAttributionWeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>to be used for determining the order of names in citation strings</para>
    /// labels<para>attribution weight</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasAttributionWeight">http://meta.icos-cp.eu/ontologies/cpmeta/hasAttributionWeight</seealso>
    let hasAttributionWeight =
        Prefixed_Name(cpmeta, "hasAttributionWeight") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:hasClimateZone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>climate zone</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasClimateZone">http://meta.icos-cp.eu/ontologies/cpmeta/hasClimateZone</seealso>
    let hasClimateZone = Prefixed_Name(cpmeta, "hasClimateZone") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has variable</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasVariable">http://meta.icos-cp.eu/ontologies/cpmeta/hasVariable</seealso>
    let hasVariable = Prefixed_Name(cpmeta, "hasVariable") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasDepiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has depiction</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasDepiction">http://meta.icos-cp.eu/ontologies/cpmeta/hasDepiction</seealso>
    let hasDepiction = Prefixed_Name(cpmeta, "hasDepiction") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:hasDocumentationObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has documentation</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasDocumentationObject">http://meta.icos-cp.eu/ontologies/cpmeta/hasDocumentationObject</seealso>
    let hasDocumentationObject =
        Prefixed_Name(cpmeta, "hasDocumentationObject") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:koppen_BSk</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:ClimateZone</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_BSk">http://meta.icos-cp.eu/ontologies/cpmeta/koppen_BSk</seealso>
    let koppen_BSk = Prefixed_Name(cpmeta, "koppen_BSk") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:koppen_BWh</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:ClimateZone</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_BWh">http://meta.icos-cp.eu/ontologies/cpmeta/koppen_BWh</seealso>
    let koppen_BWh = Prefixed_Name(cpmeta, "koppen_BWh") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:koppen_BWk</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:ClimateZone</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_BWk">http://meta.icos-cp.eu/ontologies/cpmeta/koppen_BWk</seealso>
    let koppen_BWk = Prefixed_Name(cpmeta, "koppen_BWk") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:koppen_Cfa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:ClimateZone</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Cfa">http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Cfa</seealso>
    let koppen_Cfa = Prefixed_Name(cpmeta, "koppen_Cfa") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:koppen_Cfb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:ClimateZone</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Cfb">http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Cfb</seealso>
    let koppen_Cfb = Prefixed_Name(cpmeta, "koppen_Cfb") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:koppen_Cfc</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:ClimateZone</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Cfc">http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Cfc</seealso>
    let koppen_Cfc = Prefixed_Name(cpmeta, "koppen_Cfc") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:koppen_Csa</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:ClimateZone</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Csa">http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Csa</seealso>
    let koppen_Csa = Prefixed_Name(cpmeta, "koppen_Csa") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:koppen_Csb</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:ClimateZone</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Csb">http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Csb</seealso>
    let koppen_Csb = Prefixed_Name(cpmeta, "koppen_Csb") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:koppen_Dfc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:ClimateZone</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dfc">http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dfc</seealso>
    let koppen_Dfc = Prefixed_Name(cpmeta, "koppen_Dfc") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:koppen_Dfd</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:ClimateZone</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dfd">http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dfd</seealso>
    let koppen_Dfd = Prefixed_Name(cpmeta, "koppen_Dfd") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:koppen_Dsa</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:ClimateZone</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dsa">http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dsa</seealso>
    let koppen_Dsa = Prefixed_Name(cpmeta, "koppen_Dsa") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:koppen_Dsb</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:ClimateZone</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dsb">http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dsb</seealso>
    let koppen_Dsb = Prefixed_Name(cpmeta, "koppen_Dsb") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:koppen_Dsc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:ClimateZone</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dsc">http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dsc</seealso>
    let koppen_Dsc = Prefixed_Name(cpmeta, "koppen_Dsc") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:koppen_Dsd</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:ClimateZone</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dsd">http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dsd</seealso>
    let koppen_Dsd = Prefixed_Name(cpmeta, "koppen_Dsd") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:koppen_Dwa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:ClimateZone</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dwa">http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dwa</seealso>
    let koppen_Dwa = Prefixed_Name(cpmeta, "koppen_Dwa") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:koppen_Dwb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:ClimateZone</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dwb">http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dwb</seealso>
    let koppen_Dwb = Prefixed_Name(cpmeta, "koppen_Dwb") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasQuantityKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>quantity kind</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasQuantityKind">http://meta.icos-cp.eu/ontologies/cpmeta/hasQuantityKind</seealso>
    let hasQuantityKind = Prefixed_Name(cpmeta, "hasQuantityKind") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasSamplingPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasSamplingPoint">http://meta.icos-cp.eu/ontologies/cpmeta/hasSamplingPoint</seealso>
    let hasSamplingPoint = Prefixed_Name(cpmeta, "hasSamplingPoint") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:CentralFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Central Facility</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/CentralFacility">http://meta.icos-cp.eu/ontologies/cpmeta/CentralFacility</seealso>
    let CentralFacility = Prefixed_Name(cpmeta, "CentralFacility") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:ThematicCenter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Thematic Center</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/ThematicCenter">http://meta.icos-cp.eu/ontologies/cpmeta/ThematicCenter</seealso>
    let ThematicCenter = Prefixed_Name(cpmeta, "ThematicCenter") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasColumn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has column</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasColumn">http://meta.icos-cp.eu/ontologies/cpmeta/hasColumn</seealso>
    let hasColumn = Prefixed_Name(cpmeta, "hasColumn") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:ValueType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Domain-specific meaning of the values</para>
    /// labels<para>Value Type</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/ValueType">http://meta.icos-cp.eu/ontologies/cpmeta/ValueType</seealso>
    let ValueType = Prefixed_Name(cpmeta, "ValueType") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:asciiAtcProductTimeSer</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:ObjectFormat</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Semicolon-separated ASCII, with #-prefixed multi-line header</para>
    /// labels<para>ICOS ATC time series</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/asciiAtcProductTimeSer">http://meta.icos-cp.eu/ontologies/cpmeta/asciiAtcProductTimeSer</seealso>
    let asciiAtcProductTimeSer =
        Prefixed_Name(cpmeta, "asciiAtcProductTimeSer") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:hasGoodFlagValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasGoodFlagValue">http://meta.icos-cp.eu/ontologies/cpmeta/hasGoodFlagValue</seealso>
    let hasGoodFlagValue = Prefixed_Name(cpmeta, "hasGoodFlagValue") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:asciiAtcTimeSer</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:ObjectFormat</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>ICOS ATC Raw time series</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/asciiAtcTimeSer">http://meta.icos-cp.eu/ontologies/cpmeta/asciiAtcTimeSer</seealso>
    let asciiAtcTimeSer = Prefixed_Name(cpmeta, "asciiAtcTimeSer") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:etcLocalDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:ValueFormat</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Local dateTime timestamp without any daylight savings time adjustments, that is, local winter time.</para>
    /// labels<para>yyyyMMddHHmm (no DST) (ICOS ETC)</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/etcLocalDateTime">http://meta.icos-cp.eu/ontologies/cpmeta/etcLocalDateTime</seealso>
    let etcLocalDateTime = Prefixed_Name(cpmeta, "etcLocalDateTime") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:asciiOtcProductCsv</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:ObjectFormat</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Single-line comment, first column is UTC ISO-8601 timestamp, NaN for missing values, comma-separated.</para>
    /// labels<para>ICOS OTC time series</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/asciiOtcProductCsv">http://meta.icos-cp.eu/ontologies/cpmeta/asciiOtcProductCsv</seealso>
    let asciiOtcProductCsv = Prefixed_Name(cpmeta, "asciiOtcProductCsv") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:asciiWdcggTimeSer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:ObjectFormat</para>
    ///
    /// labels<para>WDCGG gas mole fraction time series</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/asciiWdcggTimeSer">http://meta.icos-cp.eu/ontologies/cpmeta/asciiWdcggTimeSer</seealso>
    let asciiWdcggTimeSer = Prefixed_Name(cpmeta, "asciiWdcggTimeSer") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:ClimateZone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Climate Zone</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/ClimateZone">http://meta.icos-cp.eu/ontologies/cpmeta/ClimateZone</seealso>
    let ClimateZone = Prefixed_Name(cpmeta, "ClimateZone") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:DataObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/DataObject">http://meta.icos-cp.eu/ontologies/cpmeta/DataObject</seealso>
    let DataObject = Prefixed_Name(cpmeta, "DataObject") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:awardNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>award number</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/awardNumber">http://meta.icos-cp.eu/ontologies/cpmeta/awardNumber</seealso>
    let awardNumber = Prefixed_Name(cpmeta, "awardNumber") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:awardTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>award title</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/awardTitle">http://meta.icos-cp.eu/ontologies/cpmeta/awardTitle</seealso>
    let awardTitle = Prefixed_Name(cpmeta, "awardTitle") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasTimeZoneOffset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>offset of local timezone from UTC</para>
    /// labels<para>time zone offset</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasTimeZoneOffset">http://meta.icos-cp.eu/ontologies/cpmeta/hasTimeZoneOffset</seealso>
    let hasTimeZoneOffset = Prefixed_Name(cpmeta, "hasTimeZoneOffset") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasVariableName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A "virtual" property only used to define a variable in SPARQL, to support variable-name search. Is a multi-valued counterpart of cpmeta:hasActualColumnNames (for SimpleDataObjects), which contains a JSON array. Also, used to indicate variable name that a sensor is measuring (via Deployment).</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasVariableName">http://meta.icos-cp.eu/ontologies/cpmeta/hasVariableName</seealso>
    let hasVariableName = Prefixed_Name(cpmeta, "hasVariableName") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasWigosId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>WIGOS ID</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasWigosId">http://meta.icos-cp.eu/ontologies/cpmeta/hasWigosId</seealso>
    let hasWigosId = Prefixed_Name(cpmeta, "hasWigosId") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:icosLicence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dcterms:LicenseDocument</para>
    ///
    /// labels<para>ICOS CCBY4 Data Licence</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/icosLicence">http://meta.icos-cp.eu/ontologies/cpmeta/icosLicence</seealso>
    let icosLicence = Prefixed_Name(cpmeta, "icosLicence") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:igbp_BSV</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:EcosystemType</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_BSV">http://meta.icos-cp.eu/ontologies/cpmeta/igbp_BSV</seealso>
    let igbp_BSV = Prefixed_Name(cpmeta, "igbp_BSV") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:igbp_CVM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:EcosystemType</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_CVM">http://meta.icos-cp.eu/ontologies/cpmeta/igbp_CVM</seealso>
    let igbp_CVM = Prefixed_Name(cpmeta, "igbp_CVM") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:igbp_DBF</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:EcosystemType</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_DBF">http://meta.icos-cp.eu/ontologies/cpmeta/igbp_DBF</seealso>
    let igbp_DBF = Prefixed_Name(cpmeta, "igbp_DBF") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:igbp_DNF</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:EcosystemType</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_DNF">http://meta.icos-cp.eu/ontologies/cpmeta/igbp_DNF</seealso>
    let igbp_DNF = Prefixed_Name(cpmeta, "igbp_DNF") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:igbp_EBF</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:EcosystemType</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_EBF">http://meta.icos-cp.eu/ontologies/cpmeta/igbp_EBF</seealso>
    let igbp_EBF = Prefixed_Name(cpmeta, "igbp_EBF") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:igbp_OSH</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:EcosystemType</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_OSH">http://meta.icos-cp.eu/ontologies/cpmeta/igbp_OSH</seealso>
    let igbp_OSH = Prefixed_Name(cpmeta, "igbp_OSH") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:igbp_SAV</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:EcosystemType</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_SAV">http://meta.icos-cp.eu/ontologies/cpmeta/igbp_SAV</seealso>
    let igbp_SAV = Prefixed_Name(cpmeta, "igbp_SAV") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:igbp_SNO</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:EcosystemType</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_SNO">http://meta.icos-cp.eu/ontologies/cpmeta/igbp_SNO</seealso>
    let igbp_SNO = Prefixed_Name(cpmeta, "igbp_SNO") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:igbp_URB</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:EcosystemType</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_URB">http://meta.icos-cp.eu/ontologies/cpmeta/igbp_URB</seealso>
    let igbp_URB = Prefixed_Name(cpmeta, "igbp_URB") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:impliesDefaultLicence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>implies default licence</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/impliesDefaultLicence">http://meta.icos-cp.eu/ontologies/cpmeta/impliesDefaultLicence</seealso>
    let impliesDefaultLicence =
        Prefixed_Name(cpmeta, "impliesDefaultLicence") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:broaderEcosystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>more general ecosystem</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/broaderEcosystem">http://meta.icos-cp.eu/ontologies/cpmeta/broaderEcosystem</seealso>
    let broaderEcosystem = Prefixed_Name(cpmeta, "broaderEcosystem") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:asciiEtcRawTimeSer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:ObjectFormat</para>
    ///
    /// labels<para>Raw ASCII ETC station data</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/asciiEtcRawTimeSer">http://meta.icos-cp.eu/ontologies/cpmeta/asciiEtcRawTimeSer</seealso>
    let asciiEtcRawTimeSer = Prefixed_Name(cpmeta, "asciiEtcRawTimeSer") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:asciiOtcSocatTimeSer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:ObjectFormat</para>
    ///
    /// labels<para>Data in OTC/SOCAT TSV format</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/asciiOtcSocatTimeSer">http://meta.icos-cp.eu/ontologies/cpmeta/asciiOtcSocatTimeSer</seealso>
    let asciiOtcSocatTimeSer =
        Prefixed_Name(cpmeta, "asciiOtcSocatTimeSer") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:fundingInfoProp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/fundingInfoProp">http://meta.icos-cp.eu/ontologies/cpmeta/fundingInfoProp</seealso>
    let fundingInfoProp = Prefixed_Name(cpmeta, "fundingInfoProp") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:awardURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>award URI</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/awardURI">http://meta.icos-cp.eu/ontologies/cpmeta/awardURI</seealso>
    let awardURI = Prefixed_Name(cpmeta, "awardURI") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:hasStationSpecificParam</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasStationSpecificParam">http://meta.icos-cp.eu/ontologies/cpmeta/hasStationSpecificParam</seealso>
    let hasStationSpecificParam =
        Prefixed_Name(cpmeta, "hasStationSpecificParam") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:igbp_CRO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:EcosystemType</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_CRO">http://meta.icos-cp.eu/ontologies/cpmeta/igbp_CRO</seealso>
    let igbp_CRO = Prefixed_Name(cpmeta, "igbp_CRO") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:igbp_CSH</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:EcosystemType</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_CSH">http://meta.icos-cp.eu/ontologies/cpmeta/igbp_CSH</seealso>
    let igbp_CSH = Prefixed_Name(cpmeta, "igbp_CSH") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:igbp_GRA</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:EcosystemType</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_GRA">http://meta.icos-cp.eu/ontologies/cpmeta/igbp_GRA</seealso>
    let igbp_GRA = Prefixed_Name(cpmeta, "igbp_GRA") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:igbp_MF</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:EcosystemType</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_MF">http://meta.icos-cp.eu/ontologies/cpmeta/igbp_MF</seealso>
    let igbp_MF = Prefixed_Name(cpmeta, "igbp_MF") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:igbp_WET</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:EcosystemType</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_WET">http://meta.icos-cp.eu/ontologies/cpmeta/igbp_WET</seealso>
    let igbp_WET = Prefixed_Name(cpmeta, "igbp_WET") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:igbp_WSA</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:EcosystemType</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_WSA">http://meta.icos-cp.eu/ontologies/cpmeta/igbp_WSA</seealso>
    let igbp_WSA = Prefixed_Name(cpmeta, "igbp_WSA") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:ingosRar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:ObjectFormat</para>
    ///
    /// labels<para>RAR archive with InGoS time series results</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/ingosRar">http://meta.icos-cp.eu/ontologies/cpmeta/ingosRar</seealso>
    let ingosRar = Prefixed_Name(cpmeta, "ingosRar") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:igbp_ENF</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:EcosystemType</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_ENF">http://meta.icos-cp.eu/ontologies/cpmeta/igbp_ENF</seealso>
    let igbp_ENF = Prefixed_Name(cpmeta, "igbp_ENF") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:igbp_WAT</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:EcosystemType</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/igbp_WAT">http://meta.icos-cp.eu/ontologies/cpmeta/igbp_WAT</seealso>
    let igbp_WAT = Prefixed_Name(cpmeta, "igbp_WAT") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:image</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:ObjectFormat</para>
    ///
    /// labels<para>Image of an unspecified format</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/image">http://meta.icos-cp.eu/ontologies/cpmeta/image</seealso>
    let image = Prefixed_Name(cpmeta, "image") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasObjectSpec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>has specification</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasObjectSpec">http://meta.icos-cp.eu/ontologies/cpmeta/hasObjectSpec</seealso>
    let hasObjectSpec = Prefixed_Name(cpmeta, "hasObjectSpec") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:DataObjectSpec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Data Object specification</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/DataObjectSpec">http://meta.icos-cp.eu/ontologies/cpmeta/DataObjectSpec</seealso>
    let DataObjectSpec = Prefixed_Name(cpmeta, "DataObjectSpec") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasEncoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>data stream encoding, e.g. zip, gzip, plain file</para>
    /// labels<para>encoding</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasEncoding">http://meta.icos-cp.eu/ontologies/cpmeta/hasEncoding</seealso>
    let hasEncoding = Prefixed_Name(cpmeta, "hasEncoding") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>format of the Data Object; will be used to determine the machinery for processing it</para>
    /// labels<para>format</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasFormat">http://meta.icos-cp.eu/ontologies/cpmeta/hasFormat</seealso>
    let hasFormat = Prefixed_Name(cpmeta, "hasFormat") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:DataObjectSpecifyingThing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/DataObjectSpecifyingThing">http://meta.icos-cp.eu/ontologies/cpmeta/DataObjectSpecifyingThing</seealso>
    let DataObjectSpecifyingThing =
        Prefixed_Name(cpmeta, "DataObjectSpecifyingThing") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:DataTheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Data Theme</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/DataTheme">http://meta.icos-cp.eu/ontologies/cpmeta/DataTheme</seealso>
    let DataTheme = Prefixed_Name(cpmeta, "DataTheme") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasIcon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>URL link to SVG icon to be used in user interfaces</para>
    /// labels<para>has icon</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasIcon">http://meta.icos-cp.eu/ontologies/cpmeta/hasIcon</seealso>
    let hasIcon = Prefixed_Name(cpmeta, "hasIcon") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:StaticObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/StaticObject">http://meta.icos-cp.eu/ontologies/cpmeta/StaticObject</seealso>
    let StaticObject = Prefixed_Name(cpmeta, "StaticObject") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasDataTheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has data theme</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasDataTheme">http://meta.icos-cp.eu/ontologies/cpmeta/hasDataTheme</seealso>
    let hasDataTheme = Prefixed_Name(cpmeta, "hasDataTheme") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:isoLikeLocalDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:ValueFormat</para>
    ///   <para>May use space instead of 'T' for separator</para>
    /// labels<para>ISO-like local dateTime</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/isoLikeLocalDateTime">http://meta.icos-cp.eu/ontologies/cpmeta/isoLikeLocalDateTime</seealso>
    let isoLikeLocalDateTime =
        Prefixed_Name(cpmeta, "isoLikeLocalDateTime") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:koppen_Am</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:ClimateZone</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Am">http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Am</seealso>
    let koppen_Am = Prefixed_Name(cpmeta, "koppen_Am") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:hasAssociatedProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>associated with project</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasAssociatedProject">http://meta.icos-cp.eu/ontologies/cpmeta/hasAssociatedProject</seealso>
    let hasAssociatedProject =
        Prefixed_Name(cpmeta, "hasAssociatedProject") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:hasExtraRoleInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>extra role info</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasExtraRoleInfo">http://meta.icos-cp.eu/ontologies/cpmeta/hasExtraRoleInfo</seealso>
    let hasExtraRoleInfo = Prefixed_Name(cpmeta, "hasExtraRoleInfo") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:isOptionalVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/isOptionalVariable">http://meta.icos-cp.eu/ontologies/cpmeta/isOptionalVariable</seealso>
    let isOptionalVariable = Prefixed_Name(cpmeta, "isOptionalVariable") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:iso8601date</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:ValueFormat</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Date in ISO-8601 format</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/iso8601date">http://meta.icos-cp.eu/ontologies/cpmeta/iso8601date</seealso>
    let iso8601date = Prefixed_Name(cpmeta, "iso8601date") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:iso8601timeOfDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:ValueFormat</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>[h]h:mm[:ss]</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/iso8601timeOfDay">http://meta.icos-cp.eu/ontologies/cpmeta/iso8601timeOfDay</seealso>
    let iso8601timeOfDay = Prefixed_Name(cpmeta, "iso8601timeOfDay") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:koppen_Af</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:ClimateZone</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Af">http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Af</seealso>
    let koppen_Af = Prefixed_Name(cpmeta, "koppen_Af") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:koppen_Aw_As</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:ClimateZone</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Aw_As">http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Aw_As</seealso>
    let koppen_Aw_As = Prefixed_Name(cpmeta, "koppen_Aw_As") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:koppen_BSh</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:ClimateZone</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_BSh">http://meta.icos-cp.eu/ontologies/cpmeta/koppen_BSh</seealso>
    let koppen_BSh = Prefixed_Name(cpmeta, "koppen_BSh") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:koppen_Csc</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:ClimateZone</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Csc">http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Csc</seealso>
    let koppen_Csc = Prefixed_Name(cpmeta, "koppen_Csc") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:koppen_Cwa</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:ClimateZone</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Cwa">http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Cwa</seealso>
    let koppen_Cwa = Prefixed_Name(cpmeta, "koppen_Cwa") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:koppen_Cwc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:ClimateZone</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Cwc">http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Cwc</seealso>
    let koppen_Cwc = Prefixed_Name(cpmeta, "koppen_Cwc") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:koppen_Dfa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:ClimateZone</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dfa">http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dfa</seealso>
    let koppen_Dfa = Prefixed_Name(cpmeta, "koppen_Dfa") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:int32</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:ValueFormat</para>
    ///
    /// labels<para>32-bit integer value</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/int32">http://meta.icos-cp.eu/ontologies/cpmeta/int32</seealso>
    let int32 = Prefixed_Name(cpmeta, "int32") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasDataLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Data level according to ICOS classification. Does not imply the data are official ICOS data.</para>
    /// labels<para>data level</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasDataLevel">http://meta.icos-cp.eu/ontologies/cpmeta/hasDataLevel</seealso>
    let hasDataLevel = Prefixed_Name(cpmeta, "hasDataLevel") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:wasPerformedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/wasPerformedBy">http://meta.icos-cp.eu/ontologies/cpmeta/wasPerformedBy</seealso>
    let wasPerformedBy = Prefixed_Name(cpmeta, "wasPerformedBy") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:koppen_Cwb</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:ClimateZone</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Cwb">http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Cwb</seealso>
    let koppen_Cwb = Prefixed_Name(cpmeta, "koppen_Cwb") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:koppen_Dfb</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:ClimateZone</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dfb">http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dfb</seealso>
    let koppen_Dfb = Prefixed_Name(cpmeta, "koppen_Dfb") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:DataProduction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/DataProduction">http://meta.icos-cp.eu/ontologies/cpmeta/DataProduction</seealso>
    let DataProduction = Prefixed_Name(cpmeta, "DataProduction") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:latlongs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/latlongs">http://meta.icos-cp.eu/ontologies/cpmeta/latlongs</seealso>
    let latlongs = Prefixed_Name(cpmeta, "latlongs") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasEndDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>end date</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasEndDate">http://meta.icos-cp.eu/ontologies/cpmeta/hasEndDate</seealso>
    let hasEndDate = Prefixed_Name(cpmeta, "hasEndDate") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasEtcId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasEtcId">http://meta.icos-cp.eu/ontologies/cpmeta/hasEtcId</seealso>
    let hasEtcId = Prefixed_Name(cpmeta, "hasEtcId") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:hasFormatSpecificMetadata</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>used for WDCGG data, may be retired in the future</para>
    ///   <para>parent property for concrete format-specific metadata properties</para>
    /// labels<para>format-specific metadata</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasFormatSpecificMetadata">http://meta.icos-cp.eu/ontologies/cpmeta/hasFormatSpecificMetadata</seealso>
    let hasFormatSpecificMetadata =
        Prefixed_Name(cpmeta, "hasFormatSpecificMetadata") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:DataSubmission</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/DataSubmission">http://meta.icos-cp.eu/ontologies/cpmeta/DataSubmission</seealso>
    let DataSubmission = Prefixed_Name(cpmeta, "DataSubmission") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:DatasetColumn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Dataset column</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/DatasetColumn">http://meta.icos-cp.eu/ontologies/cpmeta/DatasetColumn</seealso>
    let DatasetColumn = Prefixed_Name(cpmeta, "DatasetColumn") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasValueType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>value type</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasValueType">http://meta.icos-cp.eu/ontologies/cpmeta/hasValueType</seealso>
    let hasValueType = Prefixed_Name(cpmeta, "hasValueType") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasColumnTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>column title</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasColumnTitle">http://meta.icos-cp.eu/ontologies/cpmeta/hasColumnTitle</seealso>
    let hasColumnTitle = Prefixed_Name(cpmeta, "hasColumnTitle") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:DatasetVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Dataset variable</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/DatasetVariable">http://meta.icos-cp.eu/ontologies/cpmeta/DatasetVariable</seealso>
    let DatasetVariable = Prefixed_Name(cpmeta, "DatasetVariable") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasVariableTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>variable title</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasVariableTitle">http://meta.icos-cp.eu/ontologies/cpmeta/hasVariableTitle</seealso>
    let hasVariableTitle = Prefixed_Name(cpmeta, "hasVariableTitle") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:wasPerformedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>was performed at</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/wasPerformedAt">http://meta.icos-cp.eu/ontologies/cpmeta/wasPerformedAt</seealso>
    let wasPerformedAt = Prefixed_Name(cpmeta, "wasPerformedAt") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:zipArchive</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:ObjectFormat</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Arbitrary ZIP archive</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/zipArchive">http://meta.icos-cp.eu/ontologies/cpmeta/zipArchive</seealso>
    let zipArchive = Prefixed_Name(cpmeta, "zipArchive") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:koppen_Dwc</para>
    /// </summary>
    /// <remarks>
    ///   <para>cpmeta:ClimateZone</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dwc">http://meta.icos-cp.eu/ontologies/cpmeta/koppen_Dwc</seealso>
    let koppen_Dwc = Prefixed_Name(cpmeta, "koppen_Dwc") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:multiImageZip</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cpmeta:ObjectFormat</para>
    ///
    /// labels<para>Uncompressed zip archive with images</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/multiImageZip">http://meta.icos-cp.eu/ontologies/cpmeta/multiImageZip</seealso>
    let multiImageZip = Prefixed_Name(cpmeta, "multiImageZip") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:operatesOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>operates on</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/operatesOn">http://meta.icos-cp.eu/ontologies/cpmeta/operatesOn</seealso>
    let operatesOn = Prefixed_Name(cpmeta, "operatesOn") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:wasParticipatedInBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/wasParticipatedInBy">http://meta.icos-cp.eu/ontologies/cpmeta/wasParticipatedInBy</seealso>
    let wasParticipatedInBy =
        Prefixed_Name(cpmeta, "wasParticipatedInBy") |> PrefixedName

    /// <summary>
    ///   <para>cpmeta:hasValueFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>value format</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasValueFormat">http://meta.icos-cp.eu/ontologies/cpmeta/hasValueFormat</seealso>
    let hasValueFormat = Prefixed_Name(cpmeta, "hasValueFormat") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:DocumentObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/DocumentObject">http://meta.icos-cp.eu/ontologies/cpmeta/DocumentObject</seealso>
    let DocumentObject = Prefixed_Name(cpmeta, "DocumentObject") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:DatasetSpec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Dataset Specification</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/DatasetSpec">http://meta.icos-cp.eu/ontologies/cpmeta/DatasetSpec</seealso>
    let DatasetSpec = Prefixed_Name(cpmeta, "DatasetSpec") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:ES</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Ecosystem station</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/ES">http://meta.icos-cp.eu/ontologies/cpmeta/ES</seealso>
    let ES = Prefixed_Name(cpmeta, "ES") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:EcosystemType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Ecosystem Type</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/EcosystemType">http://meta.icos-cp.eu/ontologies/cpmeta/EcosystemType</seealso>
    let EcosystemType = Prefixed_Name(cpmeta, "EcosystemType") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:Funder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/Funder">http://meta.icos-cp.eu/ontologies/cpmeta/Funder</seealso>
    let Funder = Prefixed_Name(cpmeta, "Funder") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:Funding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/Funding">http://meta.icos-cp.eu/ontologies/cpmeta/Funding</seealso>
    let Funding = Prefixed_Name(cpmeta, "Funding") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:countryCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>ISO 3166-1 alpha-2 country code</para>
    /// labels<para>country code</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/countryCode">http://meta.icos-cp.eu/ontologies/cpmeta/countryCode</seealso>
    let countryCode = Prefixed_Name(cpmeta, "countryCode") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasInstrumentOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasInstrumentOwner">http://meta.icos-cp.eu/ontologies/cpmeta/hasInstrumentOwner</seealso>
    let hasInstrumentOwner = Prefixed_Name(cpmeta, "hasInstrumentOwner") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>instrument model</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasModel">http://meta.icos-cp.eu/ontologies/cpmeta/hasModel</seealso>
    let hasModel = Prefixed_Name(cpmeta, "hasModel") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasSerialNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>serial number</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasSerialNumber">http://meta.icos-cp.eu/ontologies/cpmeta/hasSerialNumber</seealso>
    let hasSerialNumber = Prefixed_Name(cpmeta, "hasSerialNumber") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasEasternBound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>eastern bound</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasEasternBound">http://meta.icos-cp.eu/ontologies/cpmeta/hasEasternBound</seealso>
    let hasEasternBound = Prefixed_Name(cpmeta, "hasEasternBound") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasSouthernBound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>southern bound</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasSouthernBound">http://meta.icos-cp.eu/ontologies/cpmeta/hasSouthernBound</seealso>
    let hasSouthernBound = Prefixed_Name(cpmeta, "hasSouthernBound") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:Membership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Membership</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/Membership">http://meta.icos-cp.eu/ontologies/cpmeta/Membership</seealso>
    let Membership = Prefixed_Name(cpmeta, "Membership") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>has role</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasRole">http://meta.icos-cp.eu/ontologies/cpmeta/hasRole</seealso>
    let hasRole = Prefixed_Name(cpmeta, "hasRole") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:NeonStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>NEON station</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/NeonStation">http://meta.icos-cp.eu/ontologies/cpmeta/NeonStation</seealso>
    let NeonStation = Prefixed_Name(cpmeta, "NeonStation") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:OS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Oceanic station</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/OS">http://meta.icos-cp.eu/ontologies/cpmeta/OS</seealso>
    let OS = Prefixed_Name(cpmeta, "OS") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Name</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasName">http://meta.icos-cp.eu/ontologies/cpmeta/hasName</seealso>
    let hasName = Prefixed_Name(cpmeta, "hasName") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/Person">http://meta.icos-cp.eu/ontologies/cpmeta/Person</seealso>
    let Person = Prefixed_Name(cpmeta, "Person") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasLatitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Decimal degrees in WGS84/GRS80</para>
    /// labels<para>Latitude</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasLatitude">http://meta.icos-cp.eu/ontologies/cpmeta/hasLatitude</seealso>
    let hasLatitude = Prefixed_Name(cpmeta, "hasLatitude") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/Role">http://meta.icos-cp.eu/ontologies/cpmeta/Role</seealso>
    let Role = Prefixed_Name(cpmeta, "Role") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:SailDrone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Sail Drone</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/SailDrone">http://meta.icos-cp.eu/ontologies/cpmeta/SailDrone</seealso>
    let SailDrone = Prefixed_Name(cpmeta, "SailDrone") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:wasAcquiredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>was acquired by</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/wasAcquiredBy">http://meta.icos-cp.eu/ontologies/cpmeta/wasAcquiredBy</seealso>
    let wasAcquiredBy = Prefixed_Name(cpmeta, "wasAcquiredBy") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:TabularDatasetSpec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Tabular Dataset Specification</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/TabularDatasetSpec">http://meta.icos-cp.eu/ontologies/cpmeta/TabularDatasetSpec</seealso>
    let TabularDatasetSpec = Prefixed_Name(cpmeta, "TabularDatasetSpec") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:Site</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Physical research site</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/Site">http://meta.icos-cp.eu/ontologies/cpmeta/Site</seealso>
    let Site = Prefixed_Name(cpmeta, "Site") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasEcosystemType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ecosystem type</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasEcosystemType">http://meta.icos-cp.eu/ontologies/cpmeta/hasEcosystemType</seealso>
    let hasEcosystemType = Prefixed_Name(cpmeta, "hasEcosystemType") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasSpatialCoverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>spatial coverage</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasSpatialCoverage">http://meta.icos-cp.eu/ontologies/cpmeta/hasSpatialCoverage</seealso>
    let hasSpatialCoverage = Prefixed_Name(cpmeta, "hasSpatialCoverage") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:wasProducedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>was produced by</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/wasProducedBy">http://meta.icos-cp.eu/ontologies/cpmeta/wasProducedBy</seealso>
    let wasProducedBy = Prefixed_Name(cpmeta, "wasProducedBy") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasEndTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>end time</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasEndTime">http://meta.icos-cp.eu/ontologies/cpmeta/hasEndTime</seealso>
    let hasEndTime = Prefixed_Name(cpmeta, "hasEndTime") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasStartTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>start time</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasStartTime">http://meta.icos-cp.eu/ontologies/cpmeta/hasStartTime</seealso>
    let hasStartTime = Prefixed_Name(cpmeta, "hasStartTime") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:wasSubmittedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>was submitted by</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/wasSubmittedBy">http://meta.icos-cp.eu/ontologies/cpmeta/wasSubmittedBy</seealso>
    let wasSubmittedBy = Prefixed_Name(cpmeta, "wasSubmittedBy") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:hasStationId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Station ID</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/hasStationId">http://meta.icos-cp.eu/ontologies/cpmeta/hasStationId</seealso>
    let hasStationId = Prefixed_Name(cpmeta, "hasStationId") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:StringVocabulary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/StringVocabulary">http://meta.icos-cp.eu/ontologies/cpmeta/StringVocabulary</seealso>
    let StringVocabulary = Prefixed_Name(cpmeta, "StringVocabulary") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:containsString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/containsString">http://meta.icos-cp.eu/ontologies/cpmeta/containsString</seealso>
    let containsString = Prefixed_Name(cpmeta, "containsString") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:ValueFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/ValueFormat">http://meta.icos-cp.eu/ontologies/cpmeta/ValueFormat</seealso>
    let ValueFormat = Prefixed_Name(cpmeta, "ValueFormat") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:VariableInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/VariableInfo">http://meta.icos-cp.eu/ontologies/cpmeta/VariableInfo</seealso>
    let VariableInfo = Prefixed_Name(cpmeta, "VariableInfo") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:WdcggStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>WDCGG station</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/WdcggStation">http://meta.icos-cp.eu/ontologies/cpmeta/WdcggStation</seealso>
    let WdcggStation = Prefixed_Name(cpmeta, "WdcggStation") |> PrefixedName
    /// <summary>
    ///   <para>cpmeta:asGeoJSON</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>GeoJSON representation</para></remarks>
    /// <seealso href="http://meta.icos-cp.eu/ontologies/cpmeta/asGeoJSON">http://meta.icos-cp.eu/ontologies/cpmeta/asGeoJSON</seealso>
    let asGeoJSON = Prefixed_Name(cpmeta, "asGeoJSON") |> PrefixedName

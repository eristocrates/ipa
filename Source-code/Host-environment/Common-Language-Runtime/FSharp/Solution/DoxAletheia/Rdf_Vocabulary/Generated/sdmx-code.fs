namespace http.purl.org.linked_data.sdmx._2009.code.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sdmx_code =
    let _namespace_iri = Namespace_Iri sdmx_code |> NamespaceIRI
    /// <summary>
    ///   <para>sdmx-code:Area</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>": This code list provides code values for geographical areas, defined as areas included within the borders of a country, region, group of countries, etc."</para>
    /// labels<para>"Code list for providing values to concepts such as 'Reference area' and/or 'Counterpart area' - codelist class"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#Area">http://purl.org/linked-data/sdmx/2009/code#Area</seealso>
    let Area = Prefixed_Name(sdmx_code, "Area") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:ConfStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"this code list provides coded information about the sensitivity and confidentiality status of the data."</para>
    /// labels<para>"code list for Confidentiality Status (CONF_STATUS) - codelist class"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#ConfStatus">http://purl.org/linked-data/sdmx/2009/code#ConfStatus</seealso>
    let ConfStatus = Prefixed_Name(sdmx_code, "ConfStatus") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:Currency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"This code list provides code values for currencies."</para>
    /// labels<para>"code list for Currency (CURRENCY) - codelist class"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#Currency">http://purl.org/linked-data/sdmx/2009/code#Currency</seealso>
    let Currency = Prefixed_Name(sdmx_code, "Currency") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:Decimals</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"It provides a list of values showing the number of decimal digits used in the data."</para>
    /// labels<para>"Code list for Decimals (DECIMALS) - codelist class"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#Decimals">http://purl.org/linked-data/sdmx/2009/code#Decimals</seealso>
    let Decimals = Prefixed_Name(sdmx_code, "Decimals") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:Freq</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"It provides a list of values indicating the "frequency" of the data (e.g. monthly) and, thus, indirectly, also implying the type of "time reference" that could be used for identifying the data with respect time."</para>
    /// labels<para>"Code list for Frequency (FREQ) - codelist class"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#Freq">http://purl.org/linked-data/sdmx/2009/code#Freq</seealso>
    let Freq = Prefixed_Name(sdmx_code, "Freq") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:ObsStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"This code list provides coded information about the "status" of an observation (with respect events such as the ones reflected in the codes composing the code list)."</para>
    /// labels<para>"Observation status - codelist class"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#ObsStatus">http://purl.org/linked-data/sdmx/2009/code#ObsStatus</seealso>
    let ObsStatus = Prefixed_Name(sdmx_code, "ObsStatus") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:Sex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"This  code list provides the gender."</para>
    /// labels<para>"Code list for Sex (SEX) - codelist class"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#Sex">http://purl.org/linked-data/sdmx/2009/code#Sex</seealso>
    let Sex = Prefixed_Name(sdmx_code, "Sex") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:TimeFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"These codes (based on the ISO 8601 standard) indicate the type of time references used in the data. The numeric codes below (203, 102,...,702) are used only in the SDMX-EDI messages; and the alphanumeric codes (P1D...PT1M) only in the SDMX-ML messages."</para>
    /// labels<para>"Code list for the Time Format as written in the SDMX-EDI and SDMX-ML messages - codelist class"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#TimeFormat">http://purl.org/linked-data/sdmx/2009/code#TimeFormat</seealso>
    let TimeFormat = Prefixed_Name(sdmx_code, "TimeFormat") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:UnitMult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"it provides code values for indicating the magnitude in the units of measurements."</para>
    /// labels<para>"code list for the Unit Multiplier (UNIT_MULT) - codelist class"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#UnitMult">http://purl.org/linked-data/sdmx/2009/code#UnitMult</seealso>
    let UnitMult = Prefixed_Name(sdmx_code, "UnitMult") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:area</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx:CodeList</para>
    ///   <para>skos:ConceptScheme</para>
    ///
    /// labels<para>"Code list for providing values to concepts such as 'Reference area' and/or 'Counterpart area' - codelist scheme"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#area">http://purl.org/linked-data/sdmx/2009/code#area</seealso>
    let area = Prefixed_Name(sdmx_code, "area") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:confStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx:CodeList</para>
    ///   <para>skos:ConceptScheme</para>
    ///
    /// labels<para>"code list for Confidentiality Status (CONF_STATUS) - codelist scheme"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#confStatus">http://purl.org/linked-data/sdmx/2009/code#confStatus</seealso>
    let confStatus = Prefixed_Name(sdmx_code, "confStatus") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:confStatus-C</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx:Concept</para>
    ///   <para>sdmx-code:ConfStatus</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#confStatus-C">http://purl.org/linked-data/sdmx/2009/code#confStatus-C</seealso>
    let confStatus_C = Prefixed_Name(sdmx_code, "confStatus-C") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:confStatus-D</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx:Concept</para>
    ///   <para>sdmx-code:ConfStatus</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#confStatus-D">http://purl.org/linked-data/sdmx/2009/code#confStatus-D</seealso>
    let confStatus_D = Prefixed_Name(sdmx_code, "confStatus-D") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:confStatus-F</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx-code:ConfStatus</para>
    ///   <para>sdmx:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#confStatus-F">http://purl.org/linked-data/sdmx/2009/code#confStatus-F</seealso>
    let confStatus_F = Prefixed_Name(sdmx_code, "confStatus-F") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:confStatus-N</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx-code:ConfStatus</para>
    ///   <para>sdmx:Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#confStatus-N">http://purl.org/linked-data/sdmx/2009/code#confStatus-N</seealso>
    let confStatus_N = Prefixed_Name(sdmx_code, "confStatus-N") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:confStatus-S</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx:Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx-code:ConfStatus</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#confStatus-S">http://purl.org/linked-data/sdmx/2009/code#confStatus-S</seealso>
    let confStatus_S = Prefixed_Name(sdmx_code, "confStatus-S") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:currency</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>sdmx:CodeList</para>
    ///
    /// labels<para>"code list for Currency (CURRENCY) - codelist scheme"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#currency">http://purl.org/linked-data/sdmx/2009/code#currency</seealso>
    let currency = Prefixed_Name(sdmx_code, "currency") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:decimals</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx:CodeList</para>
    ///   <para>skos:ConceptScheme</para>
    ///
    /// labels<para>"Code list for Decimals (DECIMALS) - codelist scheme"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#decimals">http://purl.org/linked-data/sdmx/2009/code#decimals</seealso>
    let decimals = Prefixed_Name(sdmx_code, "decimals") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:decimals-0</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx:Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx-code:Decimals</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#decimals-0">http://purl.org/linked-data/sdmx/2009/code#decimals-0</seealso>
    let decimals_0 = Prefixed_Name(sdmx_code, "decimals-0") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:decimals-1</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx-code:Decimals</para>
    ///   <para>sdmx:Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#decimals-1">http://purl.org/linked-data/sdmx/2009/code#decimals-1</seealso>
    let decimals_1 = Prefixed_Name(sdmx_code, "decimals-1") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:decimals-2</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx:Concept</para>
    ///   <para>sdmx-code:Decimals</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#decimals-2">http://purl.org/linked-data/sdmx/2009/code#decimals-2</seealso>
    let decimals_2 = Prefixed_Name(sdmx_code, "decimals-2") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:decimals-3</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx:Concept</para>
    ///   <para>sdmx-code:Decimals</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#decimals-3">http://purl.org/linked-data/sdmx/2009/code#decimals-3</seealso>
    let decimals_3 = Prefixed_Name(sdmx_code, "decimals-3") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:decimals-4</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx-code:Decimals</para>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#decimals-4">http://purl.org/linked-data/sdmx/2009/code#decimals-4</seealso>
    let decimals_4 = Prefixed_Name(sdmx_code, "decimals-4") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:decimals-5</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx:Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx-code:Decimals</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#decimals-5">http://purl.org/linked-data/sdmx/2009/code#decimals-5</seealso>
    let decimals_5 = Prefixed_Name(sdmx_code, "decimals-5") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:decimals-6</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx-code:Decimals</para>
    ///   <para>sdmx:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#decimals-6">http://purl.org/linked-data/sdmx/2009/code#decimals-6</seealso>
    let decimals_6 = Prefixed_Name(sdmx_code, "decimals-6") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:decimals-7</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx:Concept</para>
    ///   <para>sdmx-code:Decimals</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#decimals-7">http://purl.org/linked-data/sdmx/2009/code#decimals-7</seealso>
    let decimals_7 = Prefixed_Name(sdmx_code, "decimals-7") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:decimals-8</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx-code:Decimals</para>
    ///   <para>sdmx:Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#decimals-8">http://purl.org/linked-data/sdmx/2009/code#decimals-8</seealso>
    let decimals_8 = Prefixed_Name(sdmx_code, "decimals-8") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:decimals-9</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx:Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx-code:Decimals</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#decimals-9">http://purl.org/linked-data/sdmx/2009/code#decimals-9</seealso>
    let decimals_9 = Prefixed_Name(sdmx_code, "decimals-9") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:freq</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>sdmx:CodeList</para>
    ///
    /// labels<para>"Code list for Frequency (FREQ) - codelist scheme"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#freq">http://purl.org/linked-data/sdmx/2009/code#freq</seealso>
    let freq = Prefixed_Name(sdmx_code, "freq") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:freq-A</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx-code:Freq</para>
    ///   <para>sdmx:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#freq-A">http://purl.org/linked-data/sdmx/2009/code#freq-A</seealso>
    let freq_A = Prefixed_Name(sdmx_code, "freq-A") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:freq-B</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx-code:Freq</para>
    ///   <para>sdmx:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#freq-B">http://purl.org/linked-data/sdmx/2009/code#freq-B</seealso>
    let freq_B = Prefixed_Name(sdmx_code, "freq-B") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:freq-D</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx:Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx-code:Freq</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#freq-D">http://purl.org/linked-data/sdmx/2009/code#freq-D</seealso>
    let freq_D = Prefixed_Name(sdmx_code, "freq-D") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:freq-M</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx:Concept</para>
    ///   <para>sdmx-code:Freq</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#freq-M">http://purl.org/linked-data/sdmx/2009/code#freq-M</seealso>
    let freq_M = Prefixed_Name(sdmx_code, "freq-M") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:freq-N</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx-code:Freq</para>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#freq-N">http://purl.org/linked-data/sdmx/2009/code#freq-N</seealso>
    let freq_N = Prefixed_Name(sdmx_code, "freq-N") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:freq-Q</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx:Concept</para>
    ///   <para>sdmx-code:Freq</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#freq-Q">http://purl.org/linked-data/sdmx/2009/code#freq-Q</seealso>
    let freq_Q = Prefixed_Name(sdmx_code, "freq-Q") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:freq-S</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx-code:Freq</para>
    ///   <para>sdmx:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#freq-S">http://purl.org/linked-data/sdmx/2009/code#freq-S</seealso>
    let freq_S = Prefixed_Name(sdmx_code, "freq-S") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:freq-W</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx:Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx-code:Freq</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#freq-W">http://purl.org/linked-data/sdmx/2009/code#freq-W</seealso>
    let freq_W = Prefixed_Name(sdmx_code, "freq-W") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:obsStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>sdmx:CodeList</para>
    ///
    /// labels<para>"Observation status - codelist scheme"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#obsStatus">http://purl.org/linked-data/sdmx/2009/code#obsStatus</seealso>
    let obsStatus = Prefixed_Name(sdmx_code, "obsStatus") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:obsStatus-A</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx:Concept</para>
    ///   <para>sdmx-code:ObsStatus</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#obsStatus-A">http://purl.org/linked-data/sdmx/2009/code#obsStatus-A</seealso>
    let obsStatus_A = Prefixed_Name(sdmx_code, "obsStatus-A") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:obsStatus-B</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx:Concept</para>
    ///   <para>sdmx-code:ObsStatus</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#obsStatus-B">http://purl.org/linked-data/sdmx/2009/code#obsStatus-B</seealso>
    let obsStatus_B = Prefixed_Name(sdmx_code, "obsStatus-B") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:obsStatus-E</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx-code:ObsStatus</para>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#obsStatus-E">http://purl.org/linked-data/sdmx/2009/code#obsStatus-E</seealso>
    let obsStatus_E = Prefixed_Name(sdmx_code, "obsStatus-E") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:obsStatus-F</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx:Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx-code:ObsStatus</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#obsStatus-F">http://purl.org/linked-data/sdmx/2009/code#obsStatus-F</seealso>
    let obsStatus_F = Prefixed_Name(sdmx_code, "obsStatus-F") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:obsStatus-I</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx:Concept</para>
    ///   <para>sdmx-code:ObsStatus</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#obsStatus-I">http://purl.org/linked-data/sdmx/2009/code#obsStatus-I</seealso>
    let obsStatus_I = Prefixed_Name(sdmx_code, "obsStatus-I") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:obsStatus-M</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx:Concept</para>
    ///   <para>sdmx-code:ObsStatus</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#obsStatus-M">http://purl.org/linked-data/sdmx/2009/code#obsStatus-M</seealso>
    let obsStatus_M = Prefixed_Name(sdmx_code, "obsStatus-M") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:obsStatus-P</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx-code:ObsStatus</para>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#obsStatus-P">http://purl.org/linked-data/sdmx/2009/code#obsStatus-P</seealso>
    let obsStatus_P = Prefixed_Name(sdmx_code, "obsStatus-P") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:obsStatus-S</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx:Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx-code:ObsStatus</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#obsStatus-S">http://purl.org/linked-data/sdmx/2009/code#obsStatus-S</seealso>
    let obsStatus_S = Prefixed_Name(sdmx_code, "obsStatus-S") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:sex</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx:CodeList</para>
    ///   <para>skos:ConceptScheme</para>
    ///
    /// labels<para>"Code list for Sex (SEX) - codelist scheme"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#sex">http://purl.org/linked-data/sdmx/2009/code#sex</seealso>
    let sex = Prefixed_Name(sdmx_code, "sex") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:sex-F</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx-code:Sex</para>
    ///   <para>sdmx:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#sex-F">http://purl.org/linked-data/sdmx/2009/code#sex-F</seealso>
    let sex_F = Prefixed_Name(sdmx_code, "sex-F") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:sex-M</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx-code:Sex</para>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#sex-M">http://purl.org/linked-data/sdmx/2009/code#sex-M</seealso>
    let sex_M = Prefixed_Name(sdmx_code, "sex-M") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:sex-N</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx-code:Sex</para>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#sex-N">http://purl.org/linked-data/sdmx/2009/code#sex-N</seealso>
    let sex_N = Prefixed_Name(sdmx_code, "sex-N") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:sex-T</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx:Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx-code:Sex</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#sex-T">http://purl.org/linked-data/sdmx/2009/code#sex-T</seealso>
    let sex_T = Prefixed_Name(sdmx_code, "sex-T") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:sex-U</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx:Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx-code:Sex</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#sex-U">http://purl.org/linked-data/sdmx/2009/code#sex-U</seealso>
    let sex_U = Prefixed_Name(sdmx_code, "sex-U") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:timeFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>sdmx:CodeList</para>
    ///
    /// labels<para>"Code list for the Time Format as written in the SDMX-EDI and SDMX-ML messages - codelist scheme"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#timeFormat">http://purl.org/linked-data/sdmx/2009/code#timeFormat</seealso>
    let timeFormat = Prefixed_Name(sdmx_code, "timeFormat") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:timeFormat-102</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx-code:TimeFormat</para>
    ///   <para>sdmx:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-102">http://purl.org/linked-data/sdmx/2009/code#timeFormat-102</seealso>
    let timeFormat_102 = Prefixed_Name(sdmx_code, "timeFormat-102") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:timeFormat-203</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx-code:TimeFormat</para>
    ///   <para>sdmx:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-203">http://purl.org/linked-data/sdmx/2009/code#timeFormat-203</seealso>
    let timeFormat_203 = Prefixed_Name(sdmx_code, "timeFormat-203") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:timeFormat-602</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx:Concept</para>
    ///   <para>sdmx-code:TimeFormat</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-602">http://purl.org/linked-data/sdmx/2009/code#timeFormat-602</seealso>
    let timeFormat_602 = Prefixed_Name(sdmx_code, "timeFormat-602") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:timeFormat-604</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx-code:TimeFormat</para>
    ///   <para>sdmx:Concept</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-604">http://purl.org/linked-data/sdmx/2009/code#timeFormat-604</seealso>
    let timeFormat_604 = Prefixed_Name(sdmx_code, "timeFormat-604") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:timeFormat-608</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx-code:TimeFormat</para>
    ///   <para>sdmx:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-608">http://purl.org/linked-data/sdmx/2009/code#timeFormat-608</seealso>
    let timeFormat_608 = Prefixed_Name(sdmx_code, "timeFormat-608") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:timeFormat-610</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx-code:TimeFormat</para>
    ///   <para>sdmx:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-610">http://purl.org/linked-data/sdmx/2009/code#timeFormat-610</seealso>
    let timeFormat_610 = Prefixed_Name(sdmx_code, "timeFormat-610") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:timeFormat-616</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx-code:TimeFormat</para>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-616">http://purl.org/linked-data/sdmx/2009/code#timeFormat-616</seealso>
    let timeFormat_616 = Prefixed_Name(sdmx_code, "timeFormat-616") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:timeFormat-702</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx:Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx-code:TimeFormat</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-702">http://purl.org/linked-data/sdmx/2009/code#timeFormat-702</seealso>
    let timeFormat_702 = Prefixed_Name(sdmx_code, "timeFormat-702") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:timeFormat-704</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx:Concept</para>
    ///   <para>sdmx-code:TimeFormat</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-704">http://purl.org/linked-data/sdmx/2009/code#timeFormat-704</seealso>
    let timeFormat_704 = Prefixed_Name(sdmx_code, "timeFormat-704") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:timeFormat-708</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx-code:TimeFormat</para>
    ///   <para>sdmx:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-708">http://purl.org/linked-data/sdmx/2009/code#timeFormat-708</seealso>
    let timeFormat_708 = Prefixed_Name(sdmx_code, "timeFormat-708") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:timeFormat-710</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx-code:TimeFormat</para>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-710">http://purl.org/linked-data/sdmx/2009/code#timeFormat-710</seealso>
    let timeFormat_710 = Prefixed_Name(sdmx_code, "timeFormat-710") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:timeFormat-711</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx-code:TimeFormat</para>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-711">http://purl.org/linked-data/sdmx/2009/code#timeFormat-711</seealso>
    let timeFormat_711 = Prefixed_Name(sdmx_code, "timeFormat-711") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:timeFormat-716</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx:Concept</para>
    ///   <para>sdmx-code:TimeFormat</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-716">http://purl.org/linked-data/sdmx/2009/code#timeFormat-716</seealso>
    let timeFormat_716 = Prefixed_Name(sdmx_code, "timeFormat-716") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:timeFormat-719</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx:Concept</para>
    ///   <para>sdmx-code:TimeFormat</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-719">http://purl.org/linked-data/sdmx/2009/code#timeFormat-719</seealso>
    let timeFormat_719 = Prefixed_Name(sdmx_code, "timeFormat-719") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:timeFormat-P1D</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx:Concept</para>
    ///   <para>sdmx-code:TimeFormat</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-P1D">http://purl.org/linked-data/sdmx/2009/code#timeFormat-P1D</seealso>
    let timeFormat_P1D = Prefixed_Name(sdmx_code, "timeFormat-P1D") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:timeFormat-P1M</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx:Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx-code:TimeFormat</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-P1M">http://purl.org/linked-data/sdmx/2009/code#timeFormat-P1M</seealso>
    let timeFormat_P1M = Prefixed_Name(sdmx_code, "timeFormat-P1M") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:timeFormat-P1Y</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx-code:TimeFormat</para>
    ///   <para>sdmx:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-P1Y">http://purl.org/linked-data/sdmx/2009/code#timeFormat-P1Y</seealso>
    let timeFormat_P1Y = Prefixed_Name(sdmx_code, "timeFormat-P1Y") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:timeFormat-P3M</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx:Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx-code:TimeFormat</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-P3M">http://purl.org/linked-data/sdmx/2009/code#timeFormat-P3M</seealso>
    let timeFormat_P3M = Prefixed_Name(sdmx_code, "timeFormat-P3M") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:timeFormat-P6M</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx:Concept</para>
    ///   <para>sdmx-code:TimeFormat</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-P6M">http://purl.org/linked-data/sdmx/2009/code#timeFormat-P6M</seealso>
    let timeFormat_P6M = Prefixed_Name(sdmx_code, "timeFormat-P6M") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:timeFormat-P7D</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx:Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx-code:TimeFormat</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-P7D">http://purl.org/linked-data/sdmx/2009/code#timeFormat-P7D</seealso>
    let timeFormat_P7D = Prefixed_Name(sdmx_code, "timeFormat-P7D") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:timeFormat-PT1M</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx:Concept</para>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx-code:TimeFormat</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#timeFormat-PT1M">http://purl.org/linked-data/sdmx/2009/code#timeFormat-PT1M</seealso>
    let timeFormat_PT1M = Prefixed_Name(sdmx_code, "timeFormat-PT1M") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:unitMult</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx:CodeList</para>
    ///   <para>skos:ConceptScheme</para>
    ///
    /// labels<para>"code list for the Unit Multiplier (UNIT_MULT) - codelist scheme"</para></remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#unitMult">http://purl.org/linked-data/sdmx/2009/code#unitMult</seealso>
    let unitMult = Prefixed_Name(sdmx_code, "unitMult") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:unitMult-0</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx-code:UnitMult</para>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#unitMult-0">http://purl.org/linked-data/sdmx/2009/code#unitMult-0</seealso>
    let unitMult_0 = Prefixed_Name(sdmx_code, "unitMult-0") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:unitMult-1</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx:Concept</para>
    ///   <para>sdmx-code:UnitMult</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#unitMult-1">http://purl.org/linked-data/sdmx/2009/code#unitMult-1</seealso>
    let unitMult_1 = Prefixed_Name(sdmx_code, "unitMult-1") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:unitMult-12</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx-code:UnitMult</para>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#unitMult-12">http://purl.org/linked-data/sdmx/2009/code#unitMult-12</seealso>
    let unitMult_12 = Prefixed_Name(sdmx_code, "unitMult-12") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:unitMult-15</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx-code:UnitMult</para>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#unitMult-15">http://purl.org/linked-data/sdmx/2009/code#unitMult-15</seealso>
    let unitMult_15 = Prefixed_Name(sdmx_code, "unitMult-15") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:unitMult-2</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx:Concept</para>
    ///   <para>sdmx-code:UnitMult</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#unitMult-2">http://purl.org/linked-data/sdmx/2009/code#unitMult-2</seealso>
    let unitMult_2 = Prefixed_Name(sdmx_code, "unitMult-2") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:unitMult-3</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx-code:UnitMult</para>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#unitMult-3">http://purl.org/linked-data/sdmx/2009/code#unitMult-3</seealso>
    let unitMult_3 = Prefixed_Name(sdmx_code, "unitMult-3") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:unitMult-4</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx-code:UnitMult</para>
    ///   <para>sdmx:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#unitMult-4">http://purl.org/linked-data/sdmx/2009/code#unitMult-4</seealso>
    let unitMult_4 = Prefixed_Name(sdmx_code, "unitMult-4") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:unitMult-6</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx:Concept</para>
    ///   <para>sdmx-code:UnitMult</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#unitMult-6">http://purl.org/linked-data/sdmx/2009/code#unitMult-6</seealso>
    let unitMult_6 = Prefixed_Name(sdmx_code, "unitMult-6") |> PrefixedName
    /// <summary>
    ///   <para>sdmx-code:unitMult-9</para>
    /// </summary>
    /// <remarks>
    ///   <para>sdmx-code:UnitMult</para>
    ///   <para>skos:Concept</para>
    ///   <para>sdmx:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/linked-data/sdmx/2009/code#unitMult-9">http://purl.org/linked-data/sdmx/2009/code#unitMult-9</seealso>
    let unitMult_9 = Prefixed_Name(sdmx_code, "unitMult-9") |> PrefixedName

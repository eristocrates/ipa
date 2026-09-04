#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``sdmx-code`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/linked-data/sdmx/2009/code#" "sdmx-code"

    /// <summary>
    ///   <para>rdfs:comment : : This code list provides code values for geographical areas, defined as areas included within the borders of a country, region, group of countries, etc.</para>
    ///   <para>rdfs:label : Code list for providing values to concepts such as 'Reference area' and/or 'Counterpart area' - codelist class</para>
    ///   <a href="http://purl.org/linked-data/sdmx/2009/code#Area">sdmx-code:Area</a>
    /// </summary>
    let Area = _prefixId.prefix "Area"
    /// <summary>
    ///   <para>rdfs:comment : this code list provides coded information about the sensitivity and confidentiality status of the data.</para>
    ///   <para>rdfs:label : code list for Confidentiality Status (CONF_STATUS) - codelist class</para>
    ///   <a href="http://purl.org/linked-data/sdmx/2009/code#ConfStatus">sdmx-code:ConfStatus</a>
    /// </summary>
    let ConfStatus = _prefixId.prefix "ConfStatus"
    /// <summary>
    ///   <para>rdfs:comment : This code list provides code values for currencies.</para>
    ///   <para>rdfs:label : code list for Currency (CURRENCY) - codelist class</para>
    ///   <a href="http://purl.org/linked-data/sdmx/2009/code#Currency">sdmx-code:Currency</a>
    /// </summary>
    let Currency = _prefixId.prefix "Currency"
    /// <summary>
    ///   <para>rdfs:comment : It provides a list of values showing the number of decimal digits used in the data.</para>
    ///   <para>rdfs:label : Code list for Decimals (DECIMALS) - codelist class</para>
    ///   <a href="http://purl.org/linked-data/sdmx/2009/code#Decimals">sdmx-code:Decimals</a>
    /// </summary>
    let Decimals = _prefixId.prefix "Decimals"
    /// <summary>
    ///   <para>rdfs:comment : It provides a list of values indicating the "frequency" of the data (e.g. monthly) and, thus, indirectly, also implying the type of "time reference" that could be used for identifying the data with respect time.</para>
    ///   <para>rdfs:label : Code list for Frequency (FREQ) - codelist class</para>
    ///   <a href="http://purl.org/linked-data/sdmx/2009/code#Freq">sdmx-code:Freq</a>
    /// </summary>
    let Freq = _prefixId.prefix "Freq"
    /// <summary>
    ///   <para>rdfs:comment : This code list provides coded information about the "status" of an observation (with respect events such as the ones reflected in the codes composing the code list).</para>
    ///   <para>rdfs:label : Observation status - codelist class</para>
    ///   <a href="http://purl.org/linked-data/sdmx/2009/code#ObsStatus">sdmx-code:ObsStatus</a>
    /// </summary>
    let ObsStatus = _prefixId.prefix "ObsStatus"
    /// <summary>
    ///   <para>rdfs:comment : This  code list provides the gender.</para>
    ///   <para>rdfs:label : Code list for Sex (SEX) - codelist class</para>
    ///   <a href="http://purl.org/linked-data/sdmx/2009/code#Sex">sdmx-code:Sex</a>
    /// </summary>
    let Sex = _prefixId.prefix "Sex"
    /// <summary>
    ///   <para>rdfs:comment : These codes (based on the ISO 8601 standard) indicate the type of time references used in the data. The numeric codes below (203, 102,...,702) are used only in the SDMX-EDI messages; and the alphanumeric codes (P1D...PT1M) only in the SDMX-ML messages.</para>
    ///   <para>rdfs:label : Code list for the Time Format as written in the SDMX-EDI and SDMX-ML messages - codelist class</para>
    ///   <a href="http://purl.org/linked-data/sdmx/2009/code#TimeFormat">sdmx-code:TimeFormat</a>
    /// </summary>
    let TimeFormat = _prefixId.prefix "TimeFormat"
    /// <summary>
    ///   <para>rdfs:comment : it provides code values for indicating the magnitude in the units of measurements.</para>
    ///   <para>rdfs:label : code list for the Unit Multiplier (UNIT_MULT) - codelist class</para>
    ///   <a href="http://purl.org/linked-data/sdmx/2009/code#UnitMult">sdmx-code:UnitMult</a>
    /// </summary>
    let UnitMult = _prefixId.prefix "UnitMult"
    let area = _prefixId.prefix "area"
    let confStatus = _prefixId.prefix "confStatus"
    let confStatus_C = _prefixId.prefix "confStatus-C"
    let confStatus_D = _prefixId.prefix "confStatus-D"
    let confStatus_F = _prefixId.prefix "confStatus-F"
    let confStatus_N = _prefixId.prefix "confStatus-N"
    let confStatus_S = _prefixId.prefix "confStatus-S"
    let currency = _prefixId.prefix "currency"
    let decimals = _prefixId.prefix "decimals"
    let decimals_0 = _prefixId.prefix "decimals-0"
    let decimals_1 = _prefixId.prefix "decimals-1"
    let decimals_2 = _prefixId.prefix "decimals-2"
    let decimals_3 = _prefixId.prefix "decimals-3"
    let decimals_4 = _prefixId.prefix "decimals-4"
    let decimals_5 = _prefixId.prefix "decimals-5"
    let decimals_6 = _prefixId.prefix "decimals-6"
    let decimals_7 = _prefixId.prefix "decimals-7"
    let decimals_8 = _prefixId.prefix "decimals-8"
    let decimals_9 = _prefixId.prefix "decimals-9"
    let freq = _prefixId.prefix "freq"
    let freq_A = _prefixId.prefix "freq-A"
    let freq_B = _prefixId.prefix "freq-B"
    let freq_D = _prefixId.prefix "freq-D"
    let freq_M = _prefixId.prefix "freq-M"
    let freq_N = _prefixId.prefix "freq-N"
    let freq_Q = _prefixId.prefix "freq-Q"
    let freq_S = _prefixId.prefix "freq-S"
    let freq_W = _prefixId.prefix "freq-W"
    let obsStatus = _prefixId.prefix "obsStatus"
    let obsStatus_A = _prefixId.prefix "obsStatus-A"
    let obsStatus_B = _prefixId.prefix "obsStatus-B"
    let obsStatus_E = _prefixId.prefix "obsStatus-E"
    let obsStatus_F = _prefixId.prefix "obsStatus-F"
    let obsStatus_I = _prefixId.prefix "obsStatus-I"
    let obsStatus_M = _prefixId.prefix "obsStatus-M"
    let obsStatus_P = _prefixId.prefix "obsStatus-P"
    let obsStatus_S = _prefixId.prefix "obsStatus-S"
    let sex = _prefixId.prefix "sex"
    let sex_F = _prefixId.prefix "sex-F"
    let sex_M = _prefixId.prefix "sex-M"
    let sex_N = _prefixId.prefix "sex-N"
    let sex_T = _prefixId.prefix "sex-T"
    let sex_U = _prefixId.prefix "sex-U"
    let timeFormat = _prefixId.prefix "timeFormat"
    let timeFormat_102 = _prefixId.prefix "timeFormat-102"
    let timeFormat_203 = _prefixId.prefix "timeFormat-203"
    let timeFormat_602 = _prefixId.prefix "timeFormat-602"
    let timeFormat_604 = _prefixId.prefix "timeFormat-604"
    let timeFormat_608 = _prefixId.prefix "timeFormat-608"
    let timeFormat_610 = _prefixId.prefix "timeFormat-610"
    let timeFormat_616 = _prefixId.prefix "timeFormat-616"
    let timeFormat_702 = _prefixId.prefix "timeFormat-702"
    let timeFormat_704 = _prefixId.prefix "timeFormat-704"
    let timeFormat_708 = _prefixId.prefix "timeFormat-708"
    let timeFormat_710 = _prefixId.prefix "timeFormat-710"
    let timeFormat_711 = _prefixId.prefix "timeFormat-711"
    let timeFormat_716 = _prefixId.prefix "timeFormat-716"
    let timeFormat_719 = _prefixId.prefix "timeFormat-719"
    let timeFormat_P1D = _prefixId.prefix "timeFormat-P1D"
    let timeFormat_P1M = _prefixId.prefix "timeFormat-P1M"
    let timeFormat_P1Y = _prefixId.prefix "timeFormat-P1Y"
    let timeFormat_P3M = _prefixId.prefix "timeFormat-P3M"
    let timeFormat_P6M = _prefixId.prefix "timeFormat-P6M"
    let timeFormat_P7D = _prefixId.prefix "timeFormat-P7D"
    let timeFormat_PT1M = _prefixId.prefix "timeFormat-PT1M"
    let unitMult = _prefixId.prefix "unitMult"
    let unitMult_0 = _prefixId.prefix "unitMult-0"
    let unitMult_1 = _prefixId.prefix "unitMult-1"
    let unitMult_12 = _prefixId.prefix "unitMult-12"
    let unitMult_15 = _prefixId.prefix "unitMult-15"
    let unitMult_2 = _prefixId.prefix "unitMult-2"
    let unitMult_3 = _prefixId.prefix "unitMult-3"
    let unitMult_4 = _prefixId.prefix "unitMult-4"
    let unitMult_6 = _prefixId.prefix "unitMult-6"
    let unitMult_9 = _prefixId.prefix "unitMult-9"

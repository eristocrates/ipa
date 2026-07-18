namespace http.aims.fao.org.aos.geopolitical.owl.hash

open DoxAletheia.Rdf_Vocabulary

module geop =
    let _namespace_name = "http://aims.fao.org/aos/geopolitical.owl#"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#AMU"></see>
    /// </summary>
    let AMU = Namespaced_IRI.parse _namespace_name "AMU" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#codeFAOTERM"></see>
    /// </summary>
    let codeFAOTERM =
        Namespaced_IRI.parse _namespace_name "codeFAOTERM" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#hasMember"></see>
    /// </summary>
    let hasMember = Namespaced_IRI.parse _namespace_name "hasMember" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Mauritania"></see>
    /// </summary>
    let Mauritania = Namespaced_IRI.parse _namespace_name "Mauritania" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Tunisia"></see>
    /// </summary>
    let Tunisia = Namespaced_IRI.parse _namespace_name "Tunisia" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Libya"></see>
    /// </summary>
    let Libya = Namespaced_IRI.parse _namespace_name "Libya" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Algeria"></see>
    /// </summary>
    let Algeria = Namespaced_IRI.parse _namespace_name "Algeria" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Morocco"></see>
    /// </summary>
    let Morocco = Namespaced_IRI.parse _namespace_name "Morocco" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameListEN"></see>
    /// </summary>
    let nameListEN = Namespaced_IRI.parse _namespace_name "nameListEN" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameListES"></see>
    /// </summary>
    let nameListES = Namespaced_IRI.parse _namespace_name "nameListES" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameListFR"></see>
    /// </summary>
    let nameListFR = Namespaced_IRI.parse _namespace_name "nameListFR" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameOfficialAR"></see>
    /// </summary>
    let nameOfficialAR =
        Namespaced_IRI.parse _namespace_name "nameOfficialAR" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameOfficialEN"></see>
    /// </summary>
    let nameOfficialEN =
        Namespaced_IRI.parse _namespace_name "nameOfficialEN" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameOfficialES"></see>
    /// </summary>
    let nameOfficialES =
        Namespaced_IRI.parse _namespace_name "nameOfficialES" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameOfficialFR"></see>
    /// </summary>
    let nameOfficialFR =
        Namespaced_IRI.parse _namespace_name "nameOfficialFR" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameOfficialRU"></see>
    /// </summary>
    let nameOfficialRU =
        Namespaced_IRI.parse _namespace_name "nameOfficialRU" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameOfficialZH"></see>
    /// </summary>
    let nameOfficialZH =
        Namespaced_IRI.parse _namespace_name "nameOfficialZH" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameShortEN"></see>
    /// </summary>
    let nameShortEN =
        Namespaced_IRI.parse _namespace_name "nameShortEN" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameShortES"></see>
    /// </summary>
    let nameShortES =
        Namespaced_IRI.parse _namespace_name "nameShortES" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameShortFR"></see>
    /// </summary>
    let nameShortFR =
        Namespaced_IRI.parse _namespace_name "nameShortFR" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#sourceCreator"></see>
    /// </summary>
    let sourceCreator =
        Namespaced_IRI.parse _namespace_name "sourceCreator" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#sourceIdentifier"></see>
    /// </summary>
    let sourceIdentifier =
        Namespaced_IRI.parse _namespace_name "sourceIdentifier" |> NamespacedName

    /// <summary>
    /// The value of the datatype property *validSince* associated to a particular area (territory or group) indicates the area's  first year of validity.  The geopolitical ontology traces back historic changes only until 1985, therefore, if an area has a validSince = 1985, this indicates that the area is/was valid since 1985 or before.
    /// <see href="http://aims.fao.org/aos/geopolitical.owl#validSince"></see></summary>
    let validSince = Namespaced_IRI.parse _namespace_name "validSince" |> NamespacedName
    /// <summary>
    /// The value of the datatype property *validUntil* associated to a particular area (territory or group) indicates the area's last year of validity. In case the area is currently valid, this value is set by default to 9999.
    ///
    /// <see href="http://aims.fao.org/aos/geopolitical.owl#validUntil"></see></summary>
    let validUntil = Namespaced_IRI.parse _namespace_name "validUntil" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#economic_region"></see>
    /// </summary>
    let economic_region =
        Namespaced_IRI.parse _namespace_name "economic_region" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Afghanistan"></see>
    /// </summary>
    let Afghanistan =
        Namespaced_IRI.parse _namespace_name "Afghanistan" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#GDPNotes"></see>
    /// </summary>
    let GDPNotes = Namespaced_IRI.parse _namespace_name "GDPNotes" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#GDPTotalInCurrentPrices"></see>
    /// </summary>
    let GDPTotalInCurrentPrices =
        Namespaced_IRI.parse _namespace_name "GDPTotalInCurrentPrices" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#GDPUnit"></see>
    /// </summary>
    let GDPUnit = Namespaced_IRI.parse _namespace_name "GDPUnit" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#GDPYear"></see>
    /// </summary>
    let GDPYear = Namespaced_IRI.parse _namespace_name "GDPYear" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#HDINotes"></see>
    /// </summary>
    let HDINotes = Namespaced_IRI.parse _namespace_name "HDINotes" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#HDITotal"></see>
    /// </summary>
    let HDITotal = Namespaced_IRI.parse _namespace_name "HDITotal" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#HDIYear"></see>
    /// </summary>
    let HDIYear = Namespaced_IRI.parse _namespace_name "HDIYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#agriculturalAreaNotes"></see>
    /// </summary>
    let agriculturalAreaNotes =
        Namespaced_IRI.parse _namespace_name "agriculturalAreaNotes" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#agriculturalAreaTotal"></see>
    /// </summary>
    let agriculturalAreaTotal =
        Namespaced_IRI.parse _namespace_name "agriculturalAreaTotal" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#agriculturalAreaUnit"></see>
    /// </summary>
    let agriculturalAreaUnit =
        Namespaced_IRI.parse _namespace_name "agriculturalAreaUnit" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#agriculturalAreaYear"></see>
    /// </summary>
    let agriculturalAreaYear =
        Namespaced_IRI.parse _namespace_name "agriculturalAreaYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#codeAGROVOC"></see>
    /// </summary>
    let codeAGROVOC =
        Namespaced_IRI.parse _namespace_name "codeAGROVOC" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#codeCurrency"></see>
    /// </summary>
    let codeCurrency =
        Namespaced_IRI.parse _namespace_name "codeCurrency" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#codeDBPediaID"></see>
    /// </summary>
    let codeDBPediaID =
        Namespaced_IRI.parse _namespace_name "codeDBPediaID" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#codeFAOSTAT"></see>
    /// </summary>
    let codeFAOSTAT =
        Namespaced_IRI.parse _namespace_name "codeFAOSTAT" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#codeGAUL"></see>
    /// </summary>
    let codeGAUL = Namespaced_IRI.parse _namespace_name "codeGAUL" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#codeISO2"></see>
    /// </summary>
    let codeISO2 = Namespaced_IRI.parse _namespace_name "codeISO2" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#codeISO3"></see>
    /// </summary>
    let codeISO3 = Namespaced_IRI.parse _namespace_name "codeISO3" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#codeUN"></see>
    /// </summary>
    let codeUN = Namespaced_IRI.parse _namespace_name "codeUN" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#codeUNDP"></see>
    /// </summary>
    let codeUNDP = Namespaced_IRI.parse _namespace_name "codeUNDP" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#countryAreaNotes"></see>
    /// </summary>
    let countryAreaNotes =
        Namespaced_IRI.parse _namespace_name "countryAreaNotes" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#countryAreaTotal"></see>
    /// </summary>
    let countryAreaTotal =
        Namespaced_IRI.parse _namespace_name "countryAreaTotal" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#countryAreaUnit"></see>
    /// </summary>
    let countryAreaUnit =
        Namespaced_IRI.parse _namespace_name "countryAreaUnit" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#countryAreaYear"></see>
    /// </summary>
    let countryAreaYear =
        Namespaced_IRI.parse _namespace_name "countryAreaYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#hasBorderWith"></see>
    /// </summary>
    let hasBorderWith =
        Namespaced_IRI.parse _namespace_name "hasBorderWith" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Iran_Islamic_Rep_of_"></see>
    /// </summary>
    let Iran_Islamic_Rep_of_ =
        Namespaced_IRI.parse _namespace_name "Iran_Islamic_Rep_of_" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Tajikistan"></see>
    /// </summary>
    let Tajikistan = Namespaced_IRI.parse _namespace_name "Tajikistan" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#China"></see>
    /// </summary>
    let China = Namespaced_IRI.parse _namespace_name "China" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Turkmenistan"></see>
    /// </summary>
    let Turkmenistan =
        Namespaced_IRI.parse _namespace_name "Turkmenistan" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Uzbekistan"></see>
    /// </summary>
    let Uzbekistan = Namespaced_IRI.parse _namespace_name "Uzbekistan" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Pakistan"></see>
    /// </summary>
    let Pakistan = Namespaced_IRI.parse _namespace_name "Pakistan" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#hasMaxLatitude"></see>
    /// </summary>
    let hasMaxLatitude =
        Namespaced_IRI.parse _namespace_name "hasMaxLatitude" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#hasMaxLongitude"></see>
    /// </summary>
    let hasMaxLongitude =
        Namespaced_IRI.parse _namespace_name "hasMaxLongitude" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#hasMinLatitude"></see>
    /// </summary>
    let hasMinLatitude =
        Namespaced_IRI.parse _namespace_name "hasMinLatitude" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#hasMinLongitude"></see>
    /// </summary>
    let hasMinLongitude =
        Namespaced_IRI.parse _namespace_name "hasMinLongitude" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#isInGroup"></see>
    /// </summary>
    let isInGroup = Namespaced_IRI.parse _namespace_name "isInGroup" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#LLDC"></see>
    /// </summary>
    let LLDC = Namespaced_IRI.parse _namespace_name "LLDC" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#FAO_2006"></see>
    /// </summary>
    let FAO_2006 = Namespaced_IRI.parse _namespace_name "FAO_2006" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Asia"></see>
    /// </summary>
    let Asia = Namespaced_IRI.parse _namespace_name "Asia" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#FAO"></see>
    /// </summary>
    let FAO = Namespaced_IRI.parse _namespace_name "FAO" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#ECO"></see>
    /// </summary>
    let ECO = Namespaced_IRI.parse _namespace_name "ECO" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#LDC_2010"></see>
    /// </summary>
    let LDC_2010 = Namespaced_IRI.parse _namespace_name "LDC_2010" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#LIFDC_2005"></see>
    /// </summary>
    let LIFDC_2005 = Namespaced_IRI.parse _namespace_name "LIFDC_2005" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#LDC_1993"></see>
    /// </summary>
    let LDC_1993 = Namespaced_IRI.parse _namespace_name "LDC_1993" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#LIFDC_2008"></see>
    /// </summary>
    let LIFDC_2008 = Namespaced_IRI.parse _namespace_name "LIFDC_2008" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#LDC"></see>
    /// </summary>
    let LDC = Namespaced_IRI.parse _namespace_name "LDC" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#southern_Asia"></see>
    /// </summary>
    let southern_Asia =
        Namespaced_IRI.parse _namespace_name "southern_Asia" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#LIFDC_2010"></see>
    /// </summary>
    let LIFDC_2010 = Namespaced_IRI.parse _namespace_name "LIFDC_2010" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#World"></see>
    /// </summary>
    let World = Namespaced_IRI.parse _namespace_name "World" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#SAARC"></see>
    /// </summary>
    let SAARC = Namespaced_IRI.parse _namespace_name "SAARC" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#LIFDC_2009"></see>
    /// </summary>
    let LIFDC_2009 = Namespaced_IRI.parse _namespace_name "LIFDC_2009" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#LIFDC"></see>
    /// </summary>
    let LIFDC = Namespaced_IRI.parse _namespace_name "LIFDC" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#landAreaNotes"></see>
    /// </summary>
    let landAreaNotes =
        Namespaced_IRI.parse _namespace_name "landAreaNotes" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#landAreaTotal"></see>
    /// </summary>
    let landAreaTotal =
        Namespaced_IRI.parse _namespace_name "landAreaTotal" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#landAreaUnit"></see>
    /// </summary>
    let landAreaUnit =
        Namespaced_IRI.parse _namespace_name "landAreaUnit" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#landAreaYear"></see>
    /// </summary>
    let landAreaYear =
        Namespaced_IRI.parse _namespace_name "landAreaYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameCurrencyAR"></see>
    /// </summary>
    let nameCurrencyAR =
        Namespaced_IRI.parse _namespace_name "nameCurrencyAR" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameCurrencyEN"></see>
    /// </summary>
    let nameCurrencyEN =
        Namespaced_IRI.parse _namespace_name "nameCurrencyEN" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameCurrencyES"></see>
    /// </summary>
    let nameCurrencyES =
        Namespaced_IRI.parse _namespace_name "nameCurrencyES" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameCurrencyFR"></see>
    /// </summary>
    let nameCurrencyFR =
        Namespaced_IRI.parse _namespace_name "nameCurrencyFR" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameCurrencyIT"></see>
    /// </summary>
    let nameCurrencyIT =
        Namespaced_IRI.parse _namespace_name "nameCurrencyIT" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameCurrencyRU"></see>
    /// </summary>
    let nameCurrencyRU =
        Namespaced_IRI.parse _namespace_name "nameCurrencyRU" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameCurrencyZH"></see>
    /// </summary>
    let nameCurrencyZH =
        Namespaced_IRI.parse _namespace_name "nameCurrencyZH" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameListAR"></see>
    /// </summary>
    let nameListAR = Namespaced_IRI.parse _namespace_name "nameListAR" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameListIT"></see>
    /// </summary>
    let nameListIT = Namespaced_IRI.parse _namespace_name "nameListIT" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameListRU"></see>
    /// </summary>
    let nameListRU = Namespaced_IRI.parse _namespace_name "nameListRU" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameListZH"></see>
    /// </summary>
    let nameListZH = Namespaced_IRI.parse _namespace_name "nameListZH" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameOfficialIT"></see>
    /// </summary>
    let nameOfficialIT =
        Namespaced_IRI.parse _namespace_name "nameOfficialIT" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameShortAR"></see>
    /// </summary>
    let nameShortAR =
        Namespaced_IRI.parse _namespace_name "nameShortAR" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameShortIT"></see>
    /// </summary>
    let nameShortIT =
        Namespaced_IRI.parse _namespace_name "nameShortIT" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameShortRU"></see>
    /// </summary>
    let nameShortRU =
        Namespaced_IRI.parse _namespace_name "nameShortRU" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameShortZH"></see>
    /// </summary>
    let nameShortZH =
        Namespaced_IRI.parse _namespace_name "nameShortZH" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nationalityAR"></see>
    /// </summary>
    let nationalityAR =
        Namespaced_IRI.parse _namespace_name "nationalityAR" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nationalityEN"></see>
    /// </summary>
    let nationalityEN =
        Namespaced_IRI.parse _namespace_name "nationalityEN" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nationalityES"></see>
    /// </summary>
    let nationalityES =
        Namespaced_IRI.parse _namespace_name "nationalityES" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nationalityFR"></see>
    /// </summary>
    let nationalityFR =
        Namespaced_IRI.parse _namespace_name "nationalityFR" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nationalityIT"></see>
    /// </summary>
    let nationalityIT =
        Namespaced_IRI.parse _namespace_name "nationalityIT" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nationalityRU"></see>
    /// </summary>
    let nationalityRU =
        Namespaced_IRI.parse _namespace_name "nationalityRU" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nationalityZH"></see>
    /// </summary>
    let nationalityZH =
        Namespaced_IRI.parse _namespace_name "nationalityZH" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#populationNotes"></see>
    /// </summary>
    let populationNotes =
        Namespaced_IRI.parse _namespace_name "populationNotes" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#populationTotal"></see>
    /// </summary>
    let populationTotal =
        Namespaced_IRI.parse _namespace_name "populationTotal" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#populationUnit"></see>
    /// </summary>
    let populationUnit =
        Namespaced_IRI.parse _namespace_name "populationUnit" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#populationYear"></see>
    /// </summary>
    let populationYear =
        Namespaced_IRI.parse _namespace_name "populationYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#self_governing"></see>
    /// </summary>
    let self_governing =
        Namespaced_IRI.parse _namespace_name "self_governing" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Africa"></see>
    /// </summary>
    let Africa = Namespaced_IRI.parse _namespace_name "Africa" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Cote_d_Ivoire"></see>
    /// </summary>
    let Cote_d_Ivoire =
        Namespaced_IRI.parse _namespace_name "Cote_d_Ivoire" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Sudan_the"></see>
    /// </summary>
    let Sudan_the = Namespaced_IRI.parse _namespace_name "Sudan_the" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Eritrea"></see>
    /// </summary>
    let Eritrea = Namespaced_IRI.parse _namespace_name "Eritrea" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Lesotho"></see>
    /// </summary>
    let Lesotho = Namespaced_IRI.parse _namespace_name "Lesotho" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Chad"></see>
    /// </summary>
    let Chad = Namespaced_IRI.parse _namespace_name "Chad" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Malawi"></see>
    /// </summary>
    let Malawi = Namespaced_IRI.parse _namespace_name "Malawi" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Guinea"></see>
    /// </summary>
    let Guinea = Namespaced_IRI.parse _namespace_name "Guinea" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#South_Africa"></see>
    /// </summary>
    let South_Africa =
        Namespaced_IRI.parse _namespace_name "South_Africa" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Ghana"></see>
    /// </summary>
    let Ghana = Namespaced_IRI.parse _namespace_name "Ghana" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Democratic_Republic_of_the_Congo"></see>
    /// </summary>
    let Democratic_Republic_of_the_Congo =
        Namespaced_IRI.parse _namespace_name "Democratic_Republic_of_the_Congo" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Somalia"></see>
    /// </summary>
    let Somalia = Namespaced_IRI.parse _namespace_name "Somalia" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Seychelles"></see>
    /// </summary>
    let Seychelles = Namespaced_IRI.parse _namespace_name "Seychelles" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Central_African_Republic_the"></see>
    /// </summary>
    let Central_African_Republic_the =
        Namespaced_IRI.parse _namespace_name "Central_African_Republic_the" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Cameroon"></see>
    /// </summary>
    let Cameroon = Namespaced_IRI.parse _namespace_name "Cameroon" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Ethiopia"></see>
    /// </summary>
    let Ethiopia = Namespaced_IRI.parse _namespace_name "Ethiopia" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Mozambique"></see>
    /// </summary>
    let Mozambique = Namespaced_IRI.parse _namespace_name "Mozambique" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Benin"></see>
    /// </summary>
    let Benin = Namespaced_IRI.parse _namespace_name "Benin" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Kenya"></see>
    /// </summary>
    let Kenya = Namespaced_IRI.parse _namespace_name "Kenya" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Sierra_Leone"></see>
    /// </summary>
    let Sierra_Leone =
        Namespaced_IRI.parse _namespace_name "Sierra_Leone" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Burundi"></see>
    /// </summary>
    let Burundi = Namespaced_IRI.parse _namespace_name "Burundi" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Liberia"></see>
    /// </summary>
    let Liberia = Namespaced_IRI.parse _namespace_name "Liberia" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Angola"></see>
    /// </summary>
    let Angola = Namespaced_IRI.parse _namespace_name "Angola" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Nigeria"></see>
    /// </summary>
    let Nigeria = Namespaced_IRI.parse _namespace_name "Nigeria" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Cape_Verde"></see>
    /// </summary>
    let Cape_Verde = Namespaced_IRI.parse _namespace_name "Cape_Verde" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Mauritius"></see>
    /// </summary>
    let Mauritius = Namespaced_IRI.parse _namespace_name "Mauritius" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Uganda"></see>
    /// </summary>
    let Uganda = Namespaced_IRI.parse _namespace_name "Uganda" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Equatorial_Guinea"></see>
    /// </summary>
    let Equatorial_Guinea =
        Namespaced_IRI.parse _namespace_name "Equatorial_Guinea" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Djibouti"></see>
    /// </summary>
    let Djibouti = Namespaced_IRI.parse _namespace_name "Djibouti" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Gabon"></see>
    /// </summary>
    let Gabon = Namespaced_IRI.parse _namespace_name "Gabon" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Rwanda"></see>
    /// </summary>
    let Rwanda = Namespaced_IRI.parse _namespace_name "Rwanda" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Egypt"></see>
    /// </summary>
    let Egypt = Namespaced_IRI.parse _namespace_name "Egypt" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Gambia__the"></see>
    /// </summary>
    let Gambia__the =
        Namespaced_IRI.parse _namespace_name "Gambia__the" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Guinea-Bissau"></see>
    /// </summary>
    let ``Guinea-Bissau`` =
        Namespaced_IRI.parse _namespace_name "Guinea-Bissau" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Zambia"></see>
    /// </summary>
    let Zambia = Namespaced_IRI.parse _namespace_name "Zambia" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Zimbabwe"></see>
    /// </summary>
    let Zimbabwe = Namespaced_IRI.parse _namespace_name "Zimbabwe" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Burkina_Faso"></see>
    /// </summary>
    let Burkina_Faso =
        Namespaced_IRI.parse _namespace_name "Burkina_Faso" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Comoros_the"></see>
    /// </summary>
    let Comoros_the =
        Namespaced_IRI.parse _namespace_name "Comoros_the" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Senegal"></see>
    /// </summary>
    let Senegal = Namespaced_IRI.parse _namespace_name "Senegal" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Togo"></see>
    /// </summary>
    let Togo = Namespaced_IRI.parse _namespace_name "Togo" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Mali"></see>
    /// </summary>
    let Mali = Namespaced_IRI.parse _namespace_name "Mali" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Namibia"></see>
    /// </summary>
    let Namibia = Namespaced_IRI.parse _namespace_name "Namibia" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#South_Sudan"></see>
    /// </summary>
    let South_Sudan =
        Namespaced_IRI.parse _namespace_name "South_Sudan" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Congo_the"></see>
    /// </summary>
    let Congo_the = Namespaced_IRI.parse _namespace_name "Congo_the" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#United_Republic_of_Tanzania__the"></see>
    /// </summary>
    let United_Republic_of_Tanzania__the =
        Namespaced_IRI.parse _namespace_name "United_Republic_of_Tanzania__the" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Botswana"></see>
    /// </summary>
    let Botswana = Namespaced_IRI.parse _namespace_name "Botswana" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Sao_Tome_and_Principe"></see>
    /// </summary>
    let Sao_Tome_and_Principe =
        Namespaced_IRI.parse _namespace_name "Sao_Tome_and_Principe" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Madagascar"></see>
    /// </summary>
    let Madagascar = Namespaced_IRI.parse _namespace_name "Madagascar" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Swaziland"></see>
    /// </summary>
    let Swaziland = Namespaced_IRI.parse _namespace_name "Swaziland" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Niger_the"></see>
    /// </summary>
    let Niger_the = Namespaced_IRI.parse _namespace_name "Niger_the" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#geographical_region"></see>
    /// </summary>
    let geographical_region =
        Namespaced_IRI.parse _namespace_name "geographical_region" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Albania"></see>
    /// </summary>
    let Albania = Namespaced_IRI.parse _namespace_name "Albania" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Serbia"></see>
    /// </summary>
    let Serbia = Namespaced_IRI.parse _namespace_name "Serbia" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Greece"></see>
    /// </summary>
    let Greece = Namespaced_IRI.parse _namespace_name "Greece" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Montenegro"></see>
    /// </summary>
    let Montenegro = Namespaced_IRI.parse _namespace_name "Montenegro" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#The_former_Yugoslav_Republic_of_Macedonia"></see>
    /// </summary>
    let The_former_Yugoslav_Republic_of_Macedonia =
        Namespaced_IRI.parse _namespace_name "The_former_Yugoslav_Republic_of_Macedonia" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Europe"></see>
    /// </summary>
    let Europe = Namespaced_IRI.parse _namespace_name "Europe" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#southern_Europe"></see>
    /// </summary>
    let southern_Europe =
        Namespaced_IRI.parse _namespace_name "southern_Europe" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#northern_Africa"></see>
    /// </summary>
    let northern_Africa =
        Namespaced_IRI.parse _namespace_name "northern_Africa" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#American_Samoa"></see>
    /// </summary>
    let American_Samoa =
        Namespaced_IRI.parse _namespace_name "American_Samoa" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#isAdministeredBy"></see>
    /// </summary>
    let isAdministeredBy =
        Namespaced_IRI.parse _namespace_name "isAdministeredBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#United_States_of_America"></see>
    /// </summary>
    let United_States_of_America =
        Namespaced_IRI.parse _namespace_name "United_States_of_America" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#SIDS"></see>
    /// </summary>
    let SIDS = Namespaced_IRI.parse _namespace_name "SIDS" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#non_self_governing"></see>
    /// </summary>
    let non_self_governing =
        Namespaced_IRI.parse _namespace_name "non_self_governing" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Americas"></see>
    /// </summary>
    let Americas = Namespaced_IRI.parse _namespace_name "Americas" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Honduras"></see>
    /// </summary>
    let Honduras = Namespaced_IRI.parse _namespace_name "Honduras" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Chile"></see>
    /// </summary>
    let Chile = Namespaced_IRI.parse _namespace_name "Chile" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Ecuador"></see>
    /// </summary>
    let Ecuador = Namespaced_IRI.parse _namespace_name "Ecuador" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Dominican_Republic_the"></see>
    /// </summary>
    let Dominican_Republic_the =
        Namespaced_IRI.parse _namespace_name "Dominican_Republic_the" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Antigua_and_Barbuda"></see>
    /// </summary>
    let Antigua_and_Barbuda =
        Namespaced_IRI.parse _namespace_name "Antigua_and_Barbuda" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Bolivia"></see>
    /// </summary>
    let Bolivia = Namespaced_IRI.parse _namespace_name "Bolivia" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Haiti"></see>
    /// </summary>
    let Haiti = Namespaced_IRI.parse _namespace_name "Haiti" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Saint_Kitts_and_Nevis"></see>
    /// </summary>
    let Saint_Kitts_and_Nevis =
        Namespaced_IRI.parse _namespace_name "Saint_Kitts_and_Nevis" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Paraguay"></see>
    /// </summary>
    let Paraguay = Namespaced_IRI.parse _namespace_name "Paraguay" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Grenada"></see>
    /// </summary>
    let Grenada = Namespaced_IRI.parse _namespace_name "Grenada" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Jamaica"></see>
    /// </summary>
    let Jamaica = Namespaced_IRI.parse _namespace_name "Jamaica" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Belize"></see>
    /// </summary>
    let Belize = Namespaced_IRI.parse _namespace_name "Belize" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Guatemala"></see>
    /// </summary>
    let Guatemala = Namespaced_IRI.parse _namespace_name "Guatemala" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Suriname"></see>
    /// </summary>
    let Suriname = Namespaced_IRI.parse _namespace_name "Suriname" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Barbados"></see>
    /// </summary>
    let Barbados = Namespaced_IRI.parse _namespace_name "Barbados" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Saint_Vincent_and_the_Grenadines"></see>
    /// </summary>
    let Saint_Vincent_and_the_Grenadines =
        Namespaced_IRI.parse _namespace_name "Saint_Vincent_and_the_Grenadines" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Venezuela"></see>
    /// </summary>
    let Venezuela = Namespaced_IRI.parse _namespace_name "Venezuela" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Saint_Lucia"></see>
    /// </summary>
    let Saint_Lucia =
        Namespaced_IRI.parse _namespace_name "Saint_Lucia" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Guyana"></see>
    /// </summary>
    let Guyana = Namespaced_IRI.parse _namespace_name "Guyana" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Panama"></see>
    /// </summary>
    let Panama = Namespaced_IRI.parse _namespace_name "Panama" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Nicaragua"></see>
    /// </summary>
    let Nicaragua = Namespaced_IRI.parse _namespace_name "Nicaragua" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Brazil"></see>
    /// </summary>
    let Brazil = Namespaced_IRI.parse _namespace_name "Brazil" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Dominica"></see>
    /// </summary>
    let Dominica = Namespaced_IRI.parse _namespace_name "Dominica" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Cuba"></see>
    /// </summary>
    let Cuba = Namespaced_IRI.parse _namespace_name "Cuba" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Canada"></see>
    /// </summary>
    let Canada = Namespaced_IRI.parse _namespace_name "Canada" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Mexico"></see>
    /// </summary>
    let Mexico = Namespaced_IRI.parse _namespace_name "Mexico" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Uruguay"></see>
    /// </summary>
    let Uruguay = Namespaced_IRI.parse _namespace_name "Uruguay" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Costa_Rica"></see>
    /// </summary>
    let Costa_Rica = Namespaced_IRI.parse _namespace_name "Costa_Rica" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Bahamas_the"></see>
    /// </summary>
    let Bahamas_the =
        Namespaced_IRI.parse _namespace_name "Bahamas_the" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Colombia"></see>
    /// </summary>
    let Colombia = Namespaced_IRI.parse _namespace_name "Colombia" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Peru"></see>
    /// </summary>
    let Peru = Namespaced_IRI.parse _namespace_name "Peru" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Trinidad_and_Tobago"></see>
    /// </summary>
    let Trinidad_and_Tobago =
        Namespaced_IRI.parse _namespace_name "Trinidad_and_Tobago" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#El_Salvador"></see>
    /// </summary>
    let El_Salvador =
        Namespaced_IRI.parse _namespace_name "El_Salvador" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Argentina"></see>
    /// </summary>
    let Argentina = Namespaced_IRI.parse _namespace_name "Argentina" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Andorra"></see>
    /// </summary>
    let Andorra = Namespaced_IRI.parse _namespace_name "Andorra" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Spain"></see>
    /// </summary>
    let Spain = Namespaced_IRI.parse _namespace_name "Spain" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#France"></see>
    /// </summary>
    let France = Namespaced_IRI.parse _namespace_name "France" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#middle_Africa"></see>
    /// </summary>
    let middle_Africa =
        Namespaced_IRI.parse _namespace_name "middle_Africa" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#SADC"></see>
    /// </summary>
    let SADC = Namespaced_IRI.parse _namespace_name "SADC" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#CEEAC"></see>
    /// </summary>
    let CEEAC = Namespaced_IRI.parse _namespace_name "CEEAC" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Anguilla"></see>
    /// </summary>
    let Anguilla = Namespaced_IRI.parse _namespace_name "Anguilla" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#United_Kingdom_of_Great_Britain_and_Northern_Ireland__the"></see>
    /// </summary>
    let United_Kingdom_of_Great_Britain_and_Northern_Ireland__the =
        Namespaced_IRI.parse _namespace_name "United_Kingdom_of_Great_Britain_and_Northern_Ireland__the" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Antarctica"></see>
    /// </summary>
    let Antarctica = Namespaced_IRI.parse _namespace_name "Antarctica" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#other"></see>
    /// </summary>
    let other = Namespaced_IRI.parse _namespace_name "other" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#CARIFORUM"></see>
    /// </summary>
    let CARIFORUM = Namespaced_IRI.parse _namespace_name "CARIFORUM" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Caribbean"></see>
    /// </summary>
    let Caribbean = Namespaced_IRI.parse _namespace_name "Caribbean" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#CARICOM"></see>
    /// </summary>
    let CARICOM = Namespaced_IRI.parse _namespace_name "CARICOM" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#CARICOM_1985"></see>
    /// </summary>
    let CARICOM_1985 =
        Namespaced_IRI.parse _namespace_name "CARICOM_1985" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#South_America"></see>
    /// </summary>
    let South_America =
        Namespaced_IRI.parse _namespace_name "South_America" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#MERCOSUR_1991"></see>
    /// </summary>
    let MERCOSUR_1991 =
        Namespaced_IRI.parse _namespace_name "MERCOSUR_1991" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#MERCOSUR"></see>
    /// </summary>
    let MERCOSUR = Namespaced_IRI.parse _namespace_name "MERCOSUR" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Armenia"></see>
    /// </summary>
    let Armenia = Namespaced_IRI.parse _namespace_name "Armenia" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Turkey"></see>
    /// </summary>
    let Turkey = Namespaced_IRI.parse _namespace_name "Turkey" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Georgia"></see>
    /// </summary>
    let Georgia = Namespaced_IRI.parse _namespace_name "Georgia" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Azerbaijan"></see>
    /// </summary>
    let Azerbaijan = Namespaced_IRI.parse _namespace_name "Azerbaijan" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#western_Asia"></see>
    /// </summary>
    let western_Asia =
        Namespaced_IRI.parse _namespace_name "western_Asia" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#isSuccessorOf"></see>
    /// </summary>
    let isSuccessorOf =
        Namespaced_IRI.parse _namespace_name "isSuccessorOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Union_of_Soviet_Socialist_Republic_the"></see>
    /// </summary>
    let Union_of_Soviet_Socialist_Republic_the =
        Namespaced_IRI.parse _namespace_name "Union_of_Soviet_Socialist_Republic_the" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Aruba"></see>
    /// </summary>
    let Aruba = Namespaced_IRI.parse _namespace_name "Aruba" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Netherlands_the"></see>
    /// </summary>
    let Netherlands_the =
        Namespaced_IRI.parse _namespace_name "Netherlands_the" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Netherlands_Antilles"></see>
    /// </summary>
    let Netherlands_Antilles =
        Namespaced_IRI.parse _namespace_name "Netherlands_Antilles" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Qatar"></see>
    /// </summary>
    let Qatar = Namespaced_IRI.parse _namespace_name "Qatar" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Oman"></see>
    /// </summary>
    let Oman = Namespaced_IRI.parse _namespace_name "Oman" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Nepal"></see>
    /// </summary>
    let Nepal = Namespaced_IRI.parse _namespace_name "Nepal" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Kazakhstan"></see>
    /// </summary>
    let Kazakhstan = Namespaced_IRI.parse _namespace_name "Kazakhstan" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Viet_Nam"></see>
    /// </summary>
    let Viet_Nam = Namespaced_IRI.parse _namespace_name "Viet_Nam" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Israel"></see>
    /// </summary>
    let Israel = Namespaced_IRI.parse _namespace_name "Israel" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Cyprus"></see>
    /// </summary>
    let Cyprus = Namespaced_IRI.parse _namespace_name "Cyprus" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Myanmar"></see>
    /// </summary>
    let Myanmar = Namespaced_IRI.parse _namespace_name "Myanmar" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#United_Arab_Emirates__the"></see>
    /// </summary>
    let United_Arab_Emirates__the =
        Namespaced_IRI.parse _namespace_name "United_Arab_Emirates__the" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Sri_Lanka"></see>
    /// </summary>
    let Sri_Lanka = Namespaced_IRI.parse _namespace_name "Sri_Lanka" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Yemen"></see>
    /// </summary>
    let Yemen = Namespaced_IRI.parse _namespace_name "Yemen" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Democratic_People_s_Republic_of_Korea_the"></see>
    /// </summary>
    let Democratic_People_s_Republic_of_Korea_the =
        Namespaced_IRI.parse _namespace_name "Democratic_People_s_Republic_of_Korea_the" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Bangladesh"></see>
    /// </summary>
    let Bangladesh = Namespaced_IRI.parse _namespace_name "Bangladesh" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Kyrgyzstan"></see>
    /// </summary>
    let Kyrgyzstan = Namespaced_IRI.parse _namespace_name "Kyrgyzstan" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Bahrain"></see>
    /// </summary>
    let Bahrain = Namespaced_IRI.parse _namespace_name "Bahrain" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Mongolia"></see>
    /// </summary>
    let Mongolia = Namespaced_IRI.parse _namespace_name "Mongolia" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Syrian_Arab_Republic_the"></see>
    /// </summary>
    let Syrian_Arab_Republic_the =
        Namespaced_IRI.parse _namespace_name "Syrian_Arab_Republic_the" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Iraq"></see>
    /// </summary>
    let Iraq = Namespaced_IRI.parse _namespace_name "Iraq" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Maldives"></see>
    /// </summary>
    let Maldives = Namespaced_IRI.parse _namespace_name "Maldives" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#India"></see>
    /// </summary>
    let India = Namespaced_IRI.parse _namespace_name "India" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Indonesia"></see>
    /// </summary>
    let Indonesia = Namespaced_IRI.parse _namespace_name "Indonesia" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Malaysia"></see>
    /// </summary>
    let Malaysia = Namespaced_IRI.parse _namespace_name "Malaysia" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Jordan"></see>
    /// </summary>
    let Jordan = Namespaced_IRI.parse _namespace_name "Jordan" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Republic_of_Korea__the"></see>
    /// </summary>
    let Republic_of_Korea__the =
        Namespaced_IRI.parse _namespace_name "Republic_of_Korea__the" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Lao_People_s_Democratic_Republic__the"></see>
    /// </summary>
    let Lao_People_s_Democratic_Republic__the =
        Namespaced_IRI.parse _namespace_name "Lao_People_s_Democratic_Republic__the" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Brunei_Darussalam"></see>
    /// </summary>
    let Brunei_Darussalam =
        Namespaced_IRI.parse _namespace_name "Brunei_Darussalam" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Lebanon"></see>
    /// </summary>
    let Lebanon = Namespaced_IRI.parse _namespace_name "Lebanon" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Bhutan"></see>
    /// </summary>
    let Bhutan = Namespaced_IRI.parse _namespace_name "Bhutan" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Saudi_Arabia"></see>
    /// </summary>
    let Saudi_Arabia =
        Namespaced_IRI.parse _namespace_name "Saudi_Arabia" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Cambodia"></see>
    /// </summary>
    let Cambodia = Namespaced_IRI.parse _namespace_name "Cambodia" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Timor-Leste"></see>
    /// </summary>
    let ``Timor-Leste`` =
        Namespaced_IRI.parse _namespace_name "Timor-Leste" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Philippines__the"></see>
    /// </summary>
    let Philippines__the =
        Namespaced_IRI.parse _namespace_name "Philippines__the" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Kuwait"></see>
    /// </summary>
    let Kuwait = Namespaced_IRI.parse _namespace_name "Kuwait" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Thailand"></see>
    /// </summary>
    let Thailand = Namespaced_IRI.parse _namespace_name "Thailand" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Japan"></see>
    /// </summary>
    let Japan = Namespaced_IRI.parse _namespace_name "Japan" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Singapore"></see>
    /// </summary>
    let Singapore = Namespaced_IRI.parse _namespace_name "Singapore" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Australia"></see>
    /// </summary>
    let Australia = Namespaced_IRI.parse _namespace_name "Australia" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#PIF"></see>
    /// </summary>
    let PIF = Namespaced_IRI.parse _namespace_name "PIF" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Oceania"></see>
    /// </summary>
    let Oceania = Namespaced_IRI.parse _namespace_name "Oceania" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Australia_and_New_Zealand"></see>
    /// </summary>
    let Australia_and_New_Zealand =
        Namespaced_IRI.parse _namespace_name "Australia_and_New_Zealand" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#New_Zealand"></see>
    /// </summary>
    let New_Zealand =
        Namespaced_IRI.parse _namespace_name "New_Zealand" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Austria"></see>
    /// </summary>
    let Austria = Namespaced_IRI.parse _namespace_name "Austria" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Slovakia"></see>
    /// </summary>
    let Slovakia = Namespaced_IRI.parse _namespace_name "Slovakia" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Liechtenstein"></see>
    /// </summary>
    let Liechtenstein =
        Namespaced_IRI.parse _namespace_name "Liechtenstein" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Hungary"></see>
    /// </summary>
    let Hungary = Namespaced_IRI.parse _namespace_name "Hungary" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Czech_Republic_the"></see>
    /// </summary>
    let Czech_Republic_the =
        Namespaced_IRI.parse _namespace_name "Czech_Republic_the" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Germany"></see>
    /// </summary>
    let Germany = Namespaced_IRI.parse _namespace_name "Germany" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Slovenia"></see>
    /// </summary>
    let Slovenia = Namespaced_IRI.parse _namespace_name "Slovenia" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Switzerland"></see>
    /// </summary>
    let Switzerland =
        Namespaced_IRI.parse _namespace_name "Switzerland" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Italy"></see>
    /// </summary>
    let Italy = Namespaced_IRI.parse _namespace_name "Italy" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#EU"></see>
    /// </summary>
    let EU = Namespaced_IRI.parse _namespace_name "EU" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#western_Europe"></see>
    /// </summary>
    let western_Europe =
        Namespaced_IRI.parse _namespace_name "western_Europe" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Russian_Federation__the"></see>
    /// </summary>
    let Russian_Federation__the =
        Namespaced_IRI.parse _namespace_name "Russian_Federation__the" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#CCASG"></see>
    /// </summary>
    let CCASG = Namespaced_IRI.parse _namespace_name "CCASG" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#SAARC_1985"></see>
    /// </summary>
    let SAARC_1985 = Namespaced_IRI.parse _namespace_name "SAARC_1985" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#NFIDC"></see>
    /// </summary>
    let NFIDC = Namespaced_IRI.parse _namespace_name "NFIDC" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Belarus"></see>
    /// </summary>
    let Belarus = Namespaced_IRI.parse _namespace_name "Belarus" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Poland"></see>
    /// </summary>
    let Poland = Namespaced_IRI.parse _namespace_name "Poland" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Lithuania"></see>
    /// </summary>
    let Lithuania = Namespaced_IRI.parse _namespace_name "Lithuania" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Ukraine"></see>
    /// </summary>
    let Ukraine = Namespaced_IRI.parse _namespace_name "Ukraine" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Latvia"></see>
    /// </summary>
    let Latvia = Namespaced_IRI.parse _namespace_name "Latvia" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#eastern_Europe"></see>
    /// </summary>
    let eastern_Europe =
        Namespaced_IRI.parse _namespace_name "eastern_Europe" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Belgium"></see>
    /// </summary>
    let Belgium = Namespaced_IRI.parse _namespace_name "Belgium" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Luxembourg"></see>
    /// </summary>
    let Luxembourg = Namespaced_IRI.parse _namespace_name "Luxembourg" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#CAC"></see>
    /// </summary>
    let CAC = Namespaced_IRI.parse _namespace_name "CAC" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#central_America"></see>
    /// </summary>
    let central_America =
        Namespaced_IRI.parse _namespace_name "central_America" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#ECOWAS"></see>
    /// </summary>
    let ECOWAS = Namespaced_IRI.parse _namespace_name "ECOWAS" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#ECOWAS_1985"></see>
    /// </summary>
    let ECOWAS_1985 =
        Namespaced_IRI.parse _namespace_name "ECOWAS_1985" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#UEMOA"></see>
    /// </summary>
    let UEMOA = Namespaced_IRI.parse _namespace_name "UEMOA" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#CEN_SAD"></see>
    /// </summary>
    let CEN_SAD = Namespaced_IRI.parse _namespace_name "CEN_SAD" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#western_Africa"></see>
    /// </summary>
    let western_Africa =
        Namespaced_IRI.parse _namespace_name "western_Africa" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Bermuda"></see>
    /// </summary>
    let Bermuda = Namespaced_IRI.parse _namespace_name "Bermuda" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#CAN"></see>
    /// </summary>
    let CAN = Namespaced_IRI.parse _namespace_name "CAN" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Bonaire_Sint_Eustatius_and_Saba"></see>
    /// </summary>
    let Bonaire_Sint_Eustatius_and_Saba =
        Namespaced_IRI.parse _namespace_name "Bonaire_Sint_Eustatius_and_Saba" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Bosnia_and_Herzegovina"></see>
    /// </summary>
    let Bosnia_and_Herzegovina =
        Namespaced_IRI.parse _namespace_name "Bosnia_and_Herzegovina" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Croatia"></see>
    /// </summary>
    let Croatia = Namespaced_IRI.parse _namespace_name "Croatia" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Socialist_Federal_Republic_of_Yugoslavia_the"></see>
    /// </summary>
    let Socialist_Federal_Republic_of_Yugoslavia_the =
        Namespaced_IRI.parse _namespace_name "Socialist_Federal_Republic_of_Yugoslavia_the" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#southern_Africa"></see>
    /// </summary>
    let southern_Africa =
        Namespaced_IRI.parse _namespace_name "southern_Africa" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#French_Guiana"></see>
    /// </summary>
    let French_Guiana =
        Namespaced_IRI.parse _namespace_name "French_Guiana" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#British_Virgin_Islands"></see>
    /// </summary>
    let British_Virgin_Islands =
        Namespaced_IRI.parse _namespace_name "British_Virgin_Islands" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#south-eastern_Asia"></see>
    /// </summary>
    let ``south-eastern_Asia`` =
        Namespaced_IRI.parse _namespace_name "south-eastern_Asia" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Bulgaria"></see>
    /// </summary>
    let Bulgaria = Namespaced_IRI.parse _namespace_name "Bulgaria" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Romania"></see>
    /// </summary>
    let Romania = Namespaced_IRI.parse _namespace_name "Romania" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#CEN_SAD_1998"></see>
    /// </summary>
    let CEN_SAD_1998 =
        Namespaced_IRI.parse _namespace_name "CEN_SAD_1998" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#eastern_Africa"></see>
    /// </summary>
    let eastern_Africa =
        Namespaced_IRI.parse _namespace_name "eastern_Africa" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#COMESA_1994"></see>
    /// </summary>
    let COMESA_1994 =
        Namespaced_IRI.parse _namespace_name "COMESA_1994" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#COMESA"></see>
    /// </summary>
    let COMESA = Namespaced_IRI.parse _namespace_name "COMESA" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#sourceModified"></see>
    /// </summary>
    let sourceModified =
        Namespaced_IRI.parse _namespace_name "sourceModified" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#CAEU"></see>
    /// </summary>
    let CAEU = Namespaced_IRI.parse _namespace_name "CAEU" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#isPredecessorOf"></see>
    /// </summary>
    let isPredecessorOf =
        Namespaced_IRI.parse _namespace_name "isPredecessorOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#CEMAC"></see>
    /// </summary>
    let CEMAC = Namespaced_IRI.parse _namespace_name "CEMAC" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Libyan_Arab_Jamahiriya__the"></see>
    /// </summary>
    let Libyan_Arab_Jamahiriya__the =
        Namespaced_IRI.parse _namespace_name "Libyan_Arab_Jamahiriya__the" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#PTA"></see>
    /// </summary>
    let PTA = Namespaced_IRI.parse _namespace_name "PTA" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#northern_America"></see>
    /// </summary>
    let northern_America =
        Namespaced_IRI.parse _namespace_name "northern_America" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Cayman_Islands"></see>
    /// </summary>
    let Cayman_Islands =
        Namespaced_IRI.parse _namespace_name "Cayman_Islands" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#eastern_Asia"></see>
    /// </summary>
    let eastern_Asia =
        Namespaced_IRI.parse _namespace_name "eastern_Asia" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Cook_Islands_the"></see>
    /// </summary>
    let Cook_Islands_the =
        Namespaced_IRI.parse _namespace_name "Cook_Islands_the" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#PIF_1985"></see>
    /// </summary>
    let PIF_1985 = Namespaced_IRI.parse _namespace_name "PIF_1985" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Polynesia"></see>
    /// </summary>
    let Polynesia = Namespaced_IRI.parse _namespace_name "Polynesia" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Curacao"></see>
    /// </summary>
    let Curacao = Namespaced_IRI.parse _namespace_name "Curacao" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Czechoslovakia"></see>
    /// </summary>
    let Czechoslovakia =
        Namespaced_IRI.parse _namespace_name "Czechoslovakia" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Zaire"></see>
    /// </summary>
    let Zaire = Namespaced_IRI.parse _namespace_name "Zaire" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Democratic_Yemen"></see>
    /// </summary>
    let Democratic_Yemen =
        Namespaced_IRI.parse _namespace_name "Democratic_Yemen" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Denmark"></see>
    /// </summary>
    let Denmark = Namespaced_IRI.parse _namespace_name "Denmark" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#northern_Europe"></see>
    /// </summary>
    let northern_Europe =
        Namespaced_IRI.parse _namespace_name "northern_Europe" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#IGAD"></see>
    /// </summary>
    let IGAD = Namespaced_IRI.parse _namespace_name "IGAD" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#IGADD"></see>
    /// </summary>
    let IGADD = Namespaced_IRI.parse _namespace_name "IGADD" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Finland"></see>
    /// </summary>
    let Finland = Namespaced_IRI.parse _namespace_name "Finland" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Sweden"></see>
    /// </summary>
    let Sweden = Namespaced_IRI.parse _namespace_name "Sweden" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Ireland"></see>
    /// </summary>
    let Ireland = Namespaced_IRI.parse _namespace_name "Ireland" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Estonia"></see>
    /// </summary>
    let Estonia = Namespaced_IRI.parse _namespace_name "Estonia" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Portugal"></see>
    /// </summary>
    let Portugal = Namespaced_IRI.parse _namespace_name "Portugal" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Malta"></see>
    /// </summary>
    let Malta = Namespaced_IRI.parse _namespace_name "Malta" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Ethiopia_1993"></see>
    /// </summary>
    let Ethiopia_1993 =
        Namespaced_IRI.parse _namespace_name "Ethiopia_1993" |> NamespacedName

    /// <summary>
    /// associate member of FAO
    /// <see href="http://aims.fao.org/aos/geopolitical.owl#Faroe_Islands"></see></summary>
    let Faroe_Islands =
        Namespaced_IRI.parse _namespace_name "Faroe_Islands" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Republic_of_Moldova"></see>
    /// </summary>
    let Republic_of_Moldova =
        Namespaced_IRI.parse _namespace_name "Republic_of_Moldova" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#San_Marino"></see>
    /// </summary>
    let San_Marino = Namespaced_IRI.parse _namespace_name "San_Marino" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Monaco"></see>
    /// </summary>
    let Monaco = Namespaced_IRI.parse _namespace_name "Monaco" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Norway"></see>
    /// </summary>
    let Norway = Namespaced_IRI.parse _namespace_name "Norway" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Holy_See"></see>
    /// </summary>
    let Holy_See = Namespaced_IRI.parse _namespace_name "Holy_See" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Iceland"></see>
    /// </summary>
    let Iceland = Namespaced_IRI.parse _namespace_name "Iceland" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Kiribati"></see>
    /// </summary>
    let Kiribati = Namespaced_IRI.parse _namespace_name "Kiribati" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Samoa"></see>
    /// </summary>
    let Samoa = Namespaced_IRI.parse _namespace_name "Samoa" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Palau"></see>
    /// </summary>
    let Palau = Namespaced_IRI.parse _namespace_name "Palau" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Tonga"></see>
    /// </summary>
    let Tonga = Namespaced_IRI.parse _namespace_name "Tonga" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Fiji"></see>
    /// </summary>
    let Fiji = Namespaced_IRI.parse _namespace_name "Fiji" |> NamespacedName
    /// <summary>
    /// associate member of FAO
    /// <see href="http://aims.fao.org/aos/geopolitical.owl#Tokelau"></see></summary>
    let Tokelau = Namespaced_IRI.parse _namespace_name "Tokelau" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Micronesia__Fed_States_of_"></see>
    /// </summary>
    let Micronesia__Fed_States_of_ =
        Namespaced_IRI.parse _namespace_name "Micronesia__Fed_States_of_" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Tuvalu"></see>
    /// </summary>
    let Tuvalu = Namespaced_IRI.parse _namespace_name "Tuvalu" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Solomon_Islands"></see>
    /// </summary>
    let Solomon_Islands =
        Namespaced_IRI.parse _namespace_name "Solomon_Islands" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Vanuatu"></see>
    /// </summary>
    let Vanuatu = Namespaced_IRI.parse _namespace_name "Vanuatu" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Papua_New_Guinea"></see>
    /// </summary>
    let Papua_New_Guinea =
        Namespaced_IRI.parse _namespace_name "Papua_New_Guinea" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Niue"></see>
    /// </summary>
    let Niue = Namespaced_IRI.parse _namespace_name "Niue" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Marshall_Islands__the"></see>
    /// </summary>
    let Marshall_Islands__the =
        Namespaced_IRI.parse _namespace_name "Marshall_Islands__the" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Nauru"></see>
    /// </summary>
    let Nauru = Namespaced_IRI.parse _namespace_name "Nauru" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#FAO_2007"></see>
    /// </summary>
    let FAO_2007 = Namespaced_IRI.parse _namespace_name "FAO_2007" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#organization"></see>
    /// </summary>
    let organization =
        Namespaced_IRI.parse _namespace_name "organization" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Falkland_Is"></see>
    /// </summary>
    let Falkland_Is =
        Namespaced_IRI.parse _namespace_name "Falkland_Is" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Federal_Republic_of_Germany_the"></see>
    /// </summary>
    let Federal_Republic_of_Germany_the =
        Namespaced_IRI.parse _namespace_name "Federal_Republic_of_Germany_the" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Melanesia"></see>
    /// </summary>
    let Melanesia = Namespaced_IRI.parse _namespace_name "Melanesia" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#French_Polynesia"></see>
    /// </summary>
    let French_Polynesia =
        Namespaced_IRI.parse _namespace_name "French_Polynesia" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#GDP"></see>
    /// </summary>
    let GDP = Namespaced_IRI.parse _namespace_name "GDP" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#hasStatistics"></see>
    /// </summary>
    let hasStatistics =
        Namespaced_IRI.parse _namespace_name "hasStatistics" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#German_Democratic_Republic_the"></see>
    /// </summary>
    let German_Democratic_Republic_the =
        Namespaced_IRI.parse _namespace_name "German_Democratic_Republic_the" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Gibraltar"></see>
    /// </summary>
    let Gibraltar = Namespaced_IRI.parse _namespace_name "Gibraltar" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Guadeloupe"></see>
    /// </summary>
    let Guadeloupe = Namespaced_IRI.parse _namespace_name "Guadeloupe" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Guam"></see>
    /// </summary>
    let Guam = Namespaced_IRI.parse _namespace_name "Guam" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#HDI"></see>
    /// </summary>
    let HDI = Namespaced_IRI.parse _namespace_name "HDI" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#HDIUnit"></see>
    /// </summary>
    let HDIUnit = Namespaced_IRI.parse _namespace_name "HDIUnit" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#central_Asia"></see>
    /// </summary>
    let central_Asia =
        Namespaced_IRI.parse _namespace_name "central_Asia" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Micronesia"></see>
    /// </summary>
    let Micronesia = Namespaced_IRI.parse _namespace_name "Micronesia" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#special_group"></see>
    /// </summary>
    let special_group =
        Namespaced_IRI.parse _namespace_name "special_group" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Martinique"></see>
    /// </summary>
    let Martinique = Namespaced_IRI.parse _namespace_name "Martinique" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Serbia_and_Montenegro"></see>
    /// </summary>
    let Serbia_and_Montenegro =
        Namespaced_IRI.parse _namespace_name "Serbia_and_Montenegro" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Montserrat"></see>
    /// </summary>
    let Montserrat = Namespaced_IRI.parse _namespace_name "Montserrat" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#NFIDC_2010"></see>
    /// </summary>
    let NFIDC_2010 = Namespaced_IRI.parse _namespace_name "NFIDC_2010" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Sint_Maarten"></see>
    /// </summary>
    let Sint_Maarten =
        Namespaced_IRI.parse _namespace_name "Sint_Maarten" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#New_Caledonia"></see>
    /// </summary>
    let New_Caledonia =
        Namespaced_IRI.parse _namespace_name "New_Caledonia" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Puerto_Rico"></see>
    /// </summary>
    let Puerto_Rico =
        Namespaced_IRI.parse _namespace_name "Puerto_Rico" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Reunion"></see>
    /// </summary>
    let Reunion = Namespaced_IRI.parse _namespace_name "Reunion" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#United_States_Virgin_Islands"></see>
    /// </summary>
    let United_States_Virgin_Islands =
        Namespaced_IRI.parse _namespace_name "United_States_Virgin_Islands" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Saint-Martin"></see>
    /// </summary>
    let ``Saint-Martin`` =
        Namespaced_IRI.parse _namespace_name "Saint-Martin" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Saint_Barthelemy"></see>
    /// </summary>
    let Saint_Barthelemy =
        Namespaced_IRI.parse _namespace_name "Saint_Barthelemy" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Saint_Helena"></see>
    /// </summary>
    let Saint_Helena =
        Namespaced_IRI.parse _namespace_name "Saint_Helena" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Saint_Pierre_and_Miquelon"></see>
    /// </summary>
    let Saint_Pierre_and_Miquelon =
        Namespaced_IRI.parse _namespace_name "Saint_Pierre_and_Miquelon" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Yugoslavia"></see>
    /// </summary>
    let Yugoslavia = Namespaced_IRI.parse _namespace_name "Yugoslavia" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Sudan_the_1956"></see>
    /// </summary>
    let Sudan_the_1956 =
        Namespaced_IRI.parse _namespace_name "Sudan_the_1956" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Turks_and_Caicos_Islands"></see>
    /// </summary>
    let Turks_and_Caicos_Islands =
        Namespaced_IRI.parse _namespace_name "Turks_and_Caicos_Islands" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Wallis_and_Futuna_Is"></see>
    /// </summary>
    let Wallis_and_Futuna_Is =
        Namespaced_IRI.parse _namespace_name "Wallis_and_Futuna_Is" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Yemen_1990"></see>
    /// </summary>
    let Yemen_1990 = Namespaced_IRI.parse _namespace_name "Yemen_1990" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#agriculturalArea"></see>
    /// </summary>
    let agriculturalArea =
        Namespaced_IRI.parse _namespace_name "agriculturalArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#area"></see>
    /// </summary>
    let area = Namespaced_IRI.parse _namespace_name "area" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#hasCode"></see>
    /// </summary>
    let hasCode = Namespaced_IRI.parse _namespace_name "hasCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#hasCurrency"></see>
    /// </summary>
    let hasCurrency =
        Namespaced_IRI.parse _namespace_name "hasCurrency" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#countryArea"></see>
    /// </summary>
    let countryArea =
        Namespaced_IRI.parse _namespace_name "countryArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#disputed"></see>
    /// </summary>
    let disputed = Namespaced_IRI.parse _namespace_name "disputed" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#territory"></see>
    /// </summary>
    let territory = Namespaced_IRI.parse _namespace_name "territory" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#group"></see>
    /// </summary>
    let group = Namespaced_IRI.parse _namespace_name "group" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#hasCoordinate"></see>
    /// </summary>
    let hasCoordinate =
        Namespaced_IRI.parse _namespace_name "hasCoordinate" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#hasListName"></see>
    /// </summary>
    let hasListName =
        Namespaced_IRI.parse _namespace_name "hasListName" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#hasNationality"></see>
    /// </summary>
    let hasNationality =
        Namespaced_IRI.parse _namespace_name "hasNationality" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#hasOfficialName"></see>
    /// </summary>
    let hasOfficialName =
        Namespaced_IRI.parse _namespace_name "hasOfficialName" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#hasShortName"></see>
    /// </summary>
    let hasShortName =
        Namespaced_IRI.parse _namespace_name "hasShortName" |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#landArea"></see>
    /// </summary>
    let landArea = Namespaced_IRI.parse _namespace_name "landArea" |> NamespacedName
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#population"></see>
    /// </summary>
    let population = Namespaced_IRI.parse _namespace_name "population" |> NamespacedName

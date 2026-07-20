namespace http.aims.fao.org.aos.geopolitical.owl.hash

open DoxAletheia

module geop =
    let _namespace_name = "http://aims.fao.org/aos/geopolitical.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#AMU"></see>
    /// </summary>
    let AMU = _prefix "AMU"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#codeFAOTERM"></see>
    /// </summary>
    let codeFAOTERM = _prefix "codeFAOTERM"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#hasMember"></see>
    /// </summary>
    let hasMember = _prefix "hasMember"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Mauritania"></see>
    /// </summary>
    let Mauritania = _prefix "Mauritania"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Tunisia"></see>
    /// </summary>
    let Tunisia = _prefix "Tunisia"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Libya"></see>
    /// </summary>
    let Libya = _prefix "Libya"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Algeria"></see>
    /// </summary>
    let Algeria = _prefix "Algeria"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Morocco"></see>
    /// </summary>
    let Morocco = _prefix "Morocco"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameListEN"></see>
    /// </summary>
    let nameListEN = _prefix "nameListEN"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameListES"></see>
    /// </summary>
    let nameListES = _prefix "nameListES"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameListFR"></see>
    /// </summary>
    let nameListFR = _prefix "nameListFR"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameOfficialAR"></see>
    /// </summary>
    let nameOfficialAR = _prefix "nameOfficialAR"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameOfficialEN"></see>
    /// </summary>
    let nameOfficialEN = _prefix "nameOfficialEN"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameOfficialES"></see>
    /// </summary>
    let nameOfficialES = _prefix "nameOfficialES"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameOfficialFR"></see>
    /// </summary>
    let nameOfficialFR = _prefix "nameOfficialFR"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameOfficialRU"></see>
    /// </summary>
    let nameOfficialRU = _prefix "nameOfficialRU"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameOfficialZH"></see>
    /// </summary>
    let nameOfficialZH = _prefix "nameOfficialZH"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameShortEN"></see>
    /// </summary>
    let nameShortEN = _prefix "nameShortEN"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameShortES"></see>
    /// </summary>
    let nameShortES = _prefix "nameShortES"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameShortFR"></see>
    /// </summary>
    let nameShortFR = _prefix "nameShortFR"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#sourceCreator"></see>
    /// </summary>
    let sourceCreator = _prefix "sourceCreator"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#sourceIdentifier"></see>
    /// </summary>
    let sourceIdentifier = _prefix "sourceIdentifier"
    /// <summary>
    /// The value of the datatype property *validSince* associated to a particular area (territory or group) indicates the area's  first year of validity.  The geopolitical ontology traces back historic changes only until 1985, therefore, if an area has a validSince = 1985, this indicates that the area is/was valid since 1985 or before.
    /// <see href="http://aims.fao.org/aos/geopolitical.owl#validSince"></see></summary>
    let validSince = _prefix "validSince"
    /// <summary>
    /// The value of the datatype property *validUntil* associated to a particular area (territory or group) indicates the area's last year of validity. In case the area is currently valid, this value is set by default to 9999.
    ///
    /// <see href="http://aims.fao.org/aos/geopolitical.owl#validUntil"></see></summary>
    let validUntil = _prefix "validUntil"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#economic_region"></see>
    /// </summary>
    let economic_region = _prefix "economic_region"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Afghanistan"></see>
    /// </summary>
    let Afghanistan = _prefix "Afghanistan"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#GDPNotes"></see>
    /// </summary>
    let GDPNotes = _prefix "GDPNotes"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#GDPTotalInCurrentPrices"></see>
    /// </summary>
    let GDPTotalInCurrentPrices = _prefix "GDPTotalInCurrentPrices"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#GDPUnit"></see>
    /// </summary>
    let GDPUnit = _prefix "GDPUnit"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#GDPYear"></see>
    /// </summary>
    let GDPYear = _prefix "GDPYear"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#HDINotes"></see>
    /// </summary>
    let HDINotes = _prefix "HDINotes"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#HDITotal"></see>
    /// </summary>
    let HDITotal = _prefix "HDITotal"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#HDIYear"></see>
    /// </summary>
    let HDIYear = _prefix "HDIYear"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#agriculturalAreaNotes"></see>
    /// </summary>
    let agriculturalAreaNotes = _prefix "agriculturalAreaNotes"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#agriculturalAreaTotal"></see>
    /// </summary>
    let agriculturalAreaTotal = _prefix "agriculturalAreaTotal"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#agriculturalAreaUnit"></see>
    /// </summary>
    let agriculturalAreaUnit = _prefix "agriculturalAreaUnit"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#agriculturalAreaYear"></see>
    /// </summary>
    let agriculturalAreaYear = _prefix "agriculturalAreaYear"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#codeAGROVOC"></see>
    /// </summary>
    let codeAGROVOC = _prefix "codeAGROVOC"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#codeCurrency"></see>
    /// </summary>
    let codeCurrency = _prefix "codeCurrency"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#codeDBPediaID"></see>
    /// </summary>
    let codeDBPediaID = _prefix "codeDBPediaID"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#codeFAOSTAT"></see>
    /// </summary>
    let codeFAOSTAT = _prefix "codeFAOSTAT"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#codeGAUL"></see>
    /// </summary>
    let codeGAUL = _prefix "codeGAUL"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#codeISO2"></see>
    /// </summary>
    let codeISO2 = _prefix "codeISO2"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#codeISO3"></see>
    /// </summary>
    let codeISO3 = _prefix "codeISO3"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#codeUN"></see>
    /// </summary>
    let codeUN = _prefix "codeUN"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#codeUNDP"></see>
    /// </summary>
    let codeUNDP = _prefix "codeUNDP"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#countryAreaNotes"></see>
    /// </summary>
    let countryAreaNotes = _prefix "countryAreaNotes"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#countryAreaTotal"></see>
    /// </summary>
    let countryAreaTotal = _prefix "countryAreaTotal"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#countryAreaUnit"></see>
    /// </summary>
    let countryAreaUnit = _prefix "countryAreaUnit"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#countryAreaYear"></see>
    /// </summary>
    let countryAreaYear = _prefix "countryAreaYear"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#hasBorderWith"></see>
    /// </summary>
    let hasBorderWith = _prefix "hasBorderWith"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Iran_Islamic_Rep_of_"></see>
    /// </summary>
    let Iran_Islamic_Rep_of_ = _prefix "Iran_Islamic_Rep_of_"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Tajikistan"></see>
    /// </summary>
    let Tajikistan = _prefix "Tajikistan"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#China"></see>
    /// </summary>
    let China = _prefix "China"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Turkmenistan"></see>
    /// </summary>
    let Turkmenistan = _prefix "Turkmenistan"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Uzbekistan"></see>
    /// </summary>
    let Uzbekistan = _prefix "Uzbekistan"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Pakistan"></see>
    /// </summary>
    let Pakistan = _prefix "Pakistan"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#hasMaxLatitude"></see>
    /// </summary>
    let hasMaxLatitude = _prefix "hasMaxLatitude"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#hasMaxLongitude"></see>
    /// </summary>
    let hasMaxLongitude = _prefix "hasMaxLongitude"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#hasMinLatitude"></see>
    /// </summary>
    let hasMinLatitude = _prefix "hasMinLatitude"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#hasMinLongitude"></see>
    /// </summary>
    let hasMinLongitude = _prefix "hasMinLongitude"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#isInGroup"></see>
    /// </summary>
    let isInGroup = _prefix "isInGroup"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#LLDC"></see>
    /// </summary>
    let LLDC = _prefix "LLDC"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#FAO_2006"></see>
    /// </summary>
    let FAO_2006 = _prefix "FAO_2006"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Asia"></see>
    /// </summary>
    let Asia = _prefix "Asia"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#FAO"></see>
    /// </summary>
    let FAO = _prefix "FAO"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#ECO"></see>
    /// </summary>
    let ECO = _prefix "ECO"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#LDC_2010"></see>
    /// </summary>
    let LDC_2010 = _prefix "LDC_2010"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#LIFDC_2005"></see>
    /// </summary>
    let LIFDC_2005 = _prefix "LIFDC_2005"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#LDC_1993"></see>
    /// </summary>
    let LDC_1993 = _prefix "LDC_1993"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#LIFDC_2008"></see>
    /// </summary>
    let LIFDC_2008 = _prefix "LIFDC_2008"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#LDC"></see>
    /// </summary>
    let LDC = _prefix "LDC"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#southern_Asia"></see>
    /// </summary>
    let southern_Asia = _prefix "southern_Asia"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#LIFDC_2010"></see>
    /// </summary>
    let LIFDC_2010 = _prefix "LIFDC_2010"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#World"></see>
    /// </summary>
    let World = _prefix "World"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#SAARC"></see>
    /// </summary>
    let SAARC = _prefix "SAARC"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#LIFDC_2009"></see>
    /// </summary>
    let LIFDC_2009 = _prefix "LIFDC_2009"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#LIFDC"></see>
    /// </summary>
    let LIFDC = _prefix "LIFDC"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#landAreaNotes"></see>
    /// </summary>
    let landAreaNotes = _prefix "landAreaNotes"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#landAreaTotal"></see>
    /// </summary>
    let landAreaTotal = _prefix "landAreaTotal"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#landAreaUnit"></see>
    /// </summary>
    let landAreaUnit = _prefix "landAreaUnit"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#landAreaYear"></see>
    /// </summary>
    let landAreaYear = _prefix "landAreaYear"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameCurrencyAR"></see>
    /// </summary>
    let nameCurrencyAR = _prefix "nameCurrencyAR"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameCurrencyEN"></see>
    /// </summary>
    let nameCurrencyEN = _prefix "nameCurrencyEN"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameCurrencyES"></see>
    /// </summary>
    let nameCurrencyES = _prefix "nameCurrencyES"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameCurrencyFR"></see>
    /// </summary>
    let nameCurrencyFR = _prefix "nameCurrencyFR"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameCurrencyIT"></see>
    /// </summary>
    let nameCurrencyIT = _prefix "nameCurrencyIT"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameCurrencyRU"></see>
    /// </summary>
    let nameCurrencyRU = _prefix "nameCurrencyRU"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameCurrencyZH"></see>
    /// </summary>
    let nameCurrencyZH = _prefix "nameCurrencyZH"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameListAR"></see>
    /// </summary>
    let nameListAR = _prefix "nameListAR"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameListIT"></see>
    /// </summary>
    let nameListIT = _prefix "nameListIT"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameListRU"></see>
    /// </summary>
    let nameListRU = _prefix "nameListRU"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameListZH"></see>
    /// </summary>
    let nameListZH = _prefix "nameListZH"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameOfficialIT"></see>
    /// </summary>
    let nameOfficialIT = _prefix "nameOfficialIT"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameShortAR"></see>
    /// </summary>
    let nameShortAR = _prefix "nameShortAR"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameShortIT"></see>
    /// </summary>
    let nameShortIT = _prefix "nameShortIT"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameShortRU"></see>
    /// </summary>
    let nameShortRU = _prefix "nameShortRU"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nameShortZH"></see>
    /// </summary>
    let nameShortZH = _prefix "nameShortZH"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nationalityAR"></see>
    /// </summary>
    let nationalityAR = _prefix "nationalityAR"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nationalityEN"></see>
    /// </summary>
    let nationalityEN = _prefix "nationalityEN"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nationalityES"></see>
    /// </summary>
    let nationalityES = _prefix "nationalityES"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nationalityFR"></see>
    /// </summary>
    let nationalityFR = _prefix "nationalityFR"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nationalityIT"></see>
    /// </summary>
    let nationalityIT = _prefix "nationalityIT"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nationalityRU"></see>
    /// </summary>
    let nationalityRU = _prefix "nationalityRU"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#nationalityZH"></see>
    /// </summary>
    let nationalityZH = _prefix "nationalityZH"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#populationNotes"></see>
    /// </summary>
    let populationNotes = _prefix "populationNotes"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#populationTotal"></see>
    /// </summary>
    let populationTotal = _prefix "populationTotal"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#populationUnit"></see>
    /// </summary>
    let populationUnit = _prefix "populationUnit"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#populationYear"></see>
    /// </summary>
    let populationYear = _prefix "populationYear"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#self_governing"></see>
    /// </summary>
    let self_governing = _prefix "self_governing"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Africa"></see>
    /// </summary>
    let Africa = _prefix "Africa"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Cote_d_Ivoire"></see>
    /// </summary>
    let Cote_d_Ivoire = _prefix "Cote_d_Ivoire"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Sudan_the"></see>
    /// </summary>
    let Sudan_the = _prefix "Sudan_the"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Eritrea"></see>
    /// </summary>
    let Eritrea = _prefix "Eritrea"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Lesotho"></see>
    /// </summary>
    let Lesotho = _prefix "Lesotho"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Chad"></see>
    /// </summary>
    let Chad = _prefix "Chad"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Malawi"></see>
    /// </summary>
    let Malawi = _prefix "Malawi"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Guinea"></see>
    /// </summary>
    let Guinea = _prefix "Guinea"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#South_Africa"></see>
    /// </summary>
    let South_Africa = _prefix "South_Africa"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Ghana"></see>
    /// </summary>
    let Ghana = _prefix "Ghana"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Democratic_Republic_of_the_Congo"></see>
    /// </summary>
    let Democratic_Republic_of_the_Congo = _prefix "Democratic_Republic_of_the_Congo"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Somalia"></see>
    /// </summary>
    let Somalia = _prefix "Somalia"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Seychelles"></see>
    /// </summary>
    let Seychelles = _prefix "Seychelles"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Central_African_Republic_the"></see>
    /// </summary>
    let Central_African_Republic_the = _prefix "Central_African_Republic_the"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Cameroon"></see>
    /// </summary>
    let Cameroon = _prefix "Cameroon"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Ethiopia"></see>
    /// </summary>
    let Ethiopia = _prefix "Ethiopia"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Mozambique"></see>
    /// </summary>
    let Mozambique = _prefix "Mozambique"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Benin"></see>
    /// </summary>
    let Benin = _prefix "Benin"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Kenya"></see>
    /// </summary>
    let Kenya = _prefix "Kenya"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Sierra_Leone"></see>
    /// </summary>
    let Sierra_Leone = _prefix "Sierra_Leone"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Burundi"></see>
    /// </summary>
    let Burundi = _prefix "Burundi"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Liberia"></see>
    /// </summary>
    let Liberia = _prefix "Liberia"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Angola"></see>
    /// </summary>
    let Angola = _prefix "Angola"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Nigeria"></see>
    /// </summary>
    let Nigeria = _prefix "Nigeria"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Cape_Verde"></see>
    /// </summary>
    let Cape_Verde = _prefix "Cape_Verde"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Mauritius"></see>
    /// </summary>
    let Mauritius = _prefix "Mauritius"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Uganda"></see>
    /// </summary>
    let Uganda = _prefix "Uganda"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Equatorial_Guinea"></see>
    /// </summary>
    let Equatorial_Guinea = _prefix "Equatorial_Guinea"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Djibouti"></see>
    /// </summary>
    let Djibouti = _prefix "Djibouti"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Gabon"></see>
    /// </summary>
    let Gabon = _prefix "Gabon"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Rwanda"></see>
    /// </summary>
    let Rwanda = _prefix "Rwanda"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Egypt"></see>
    /// </summary>
    let Egypt = _prefix "Egypt"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Gambia__the"></see>
    /// </summary>
    let Gambia__the = _prefix "Gambia__the"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Guinea-Bissau"></see>
    /// </summary>
    let ``Guinea-Bissau`` = _prefix "Guinea-Bissau"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Zambia"></see>
    /// </summary>
    let Zambia = _prefix "Zambia"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Zimbabwe"></see>
    /// </summary>
    let Zimbabwe = _prefix "Zimbabwe"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Burkina_Faso"></see>
    /// </summary>
    let Burkina_Faso = _prefix "Burkina_Faso"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Comoros_the"></see>
    /// </summary>
    let Comoros_the = _prefix "Comoros_the"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Senegal"></see>
    /// </summary>
    let Senegal = _prefix "Senegal"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Togo"></see>
    /// </summary>
    let Togo = _prefix "Togo"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Mali"></see>
    /// </summary>
    let Mali = _prefix "Mali"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Namibia"></see>
    /// </summary>
    let Namibia = _prefix "Namibia"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#South_Sudan"></see>
    /// </summary>
    let South_Sudan = _prefix "South_Sudan"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Congo_the"></see>
    /// </summary>
    let Congo_the = _prefix "Congo_the"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#United_Republic_of_Tanzania__the"></see>
    /// </summary>
    let United_Republic_of_Tanzania__the = _prefix "United_Republic_of_Tanzania__the"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Botswana"></see>
    /// </summary>
    let Botswana = _prefix "Botswana"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Sao_Tome_and_Principe"></see>
    /// </summary>
    let Sao_Tome_and_Principe = _prefix "Sao_Tome_and_Principe"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Madagascar"></see>
    /// </summary>
    let Madagascar = _prefix "Madagascar"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Swaziland"></see>
    /// </summary>
    let Swaziland = _prefix "Swaziland"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Niger_the"></see>
    /// </summary>
    let Niger_the = _prefix "Niger_the"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#geographical_region"></see>
    /// </summary>
    let geographical_region = _prefix "geographical_region"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Albania"></see>
    /// </summary>
    let Albania = _prefix "Albania"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Serbia"></see>
    /// </summary>
    let Serbia = _prefix "Serbia"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Greece"></see>
    /// </summary>
    let Greece = _prefix "Greece"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Montenegro"></see>
    /// </summary>
    let Montenegro = _prefix "Montenegro"

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#The_former_Yugoslav_Republic_of_Macedonia"></see>
    /// </summary>
    let The_former_Yugoslav_Republic_of_Macedonia =
        _prefix "The_former_Yugoslav_Republic_of_Macedonia"

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Europe"></see>
    /// </summary>
    let Europe = _prefix "Europe"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#southern_Europe"></see>
    /// </summary>
    let southern_Europe = _prefix "southern_Europe"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#northern_Africa"></see>
    /// </summary>
    let northern_Africa = _prefix "northern_Africa"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#American_Samoa"></see>
    /// </summary>
    let American_Samoa = _prefix "American_Samoa"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#isAdministeredBy"></see>
    /// </summary>
    let isAdministeredBy = _prefix "isAdministeredBy"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#United_States_of_America"></see>
    /// </summary>
    let United_States_of_America = _prefix "United_States_of_America"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#SIDS"></see>
    /// </summary>
    let SIDS = _prefix "SIDS"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#non_self_governing"></see>
    /// </summary>
    let non_self_governing = _prefix "non_self_governing"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Americas"></see>
    /// </summary>
    let Americas = _prefix "Americas"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Honduras"></see>
    /// </summary>
    let Honduras = _prefix "Honduras"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Chile"></see>
    /// </summary>
    let Chile = _prefix "Chile"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Ecuador"></see>
    /// </summary>
    let Ecuador = _prefix "Ecuador"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Dominican_Republic_the"></see>
    /// </summary>
    let Dominican_Republic_the = _prefix "Dominican_Republic_the"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Antigua_and_Barbuda"></see>
    /// </summary>
    let Antigua_and_Barbuda = _prefix "Antigua_and_Barbuda"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Bolivia"></see>
    /// </summary>
    let Bolivia = _prefix "Bolivia"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Haiti"></see>
    /// </summary>
    let Haiti = _prefix "Haiti"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Saint_Kitts_and_Nevis"></see>
    /// </summary>
    let Saint_Kitts_and_Nevis = _prefix "Saint_Kitts_and_Nevis"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Paraguay"></see>
    /// </summary>
    let Paraguay = _prefix "Paraguay"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Grenada"></see>
    /// </summary>
    let Grenada = _prefix "Grenada"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Jamaica"></see>
    /// </summary>
    let Jamaica = _prefix "Jamaica"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Belize"></see>
    /// </summary>
    let Belize = _prefix "Belize"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Guatemala"></see>
    /// </summary>
    let Guatemala = _prefix "Guatemala"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Suriname"></see>
    /// </summary>
    let Suriname = _prefix "Suriname"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Barbados"></see>
    /// </summary>
    let Barbados = _prefix "Barbados"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Saint_Vincent_and_the_Grenadines"></see>
    /// </summary>
    let Saint_Vincent_and_the_Grenadines = _prefix "Saint_Vincent_and_the_Grenadines"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Venezuela"></see>
    /// </summary>
    let Venezuela = _prefix "Venezuela"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Saint_Lucia"></see>
    /// </summary>
    let Saint_Lucia = _prefix "Saint_Lucia"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Guyana"></see>
    /// </summary>
    let Guyana = _prefix "Guyana"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Panama"></see>
    /// </summary>
    let Panama = _prefix "Panama"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Nicaragua"></see>
    /// </summary>
    let Nicaragua = _prefix "Nicaragua"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Brazil"></see>
    /// </summary>
    let Brazil = _prefix "Brazil"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Dominica"></see>
    /// </summary>
    let Dominica = _prefix "Dominica"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Cuba"></see>
    /// </summary>
    let Cuba = _prefix "Cuba"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Canada"></see>
    /// </summary>
    let Canada = _prefix "Canada"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Mexico"></see>
    /// </summary>
    let Mexico = _prefix "Mexico"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Uruguay"></see>
    /// </summary>
    let Uruguay = _prefix "Uruguay"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Costa_Rica"></see>
    /// </summary>
    let Costa_Rica = _prefix "Costa_Rica"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Bahamas_the"></see>
    /// </summary>
    let Bahamas_the = _prefix "Bahamas_the"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Colombia"></see>
    /// </summary>
    let Colombia = _prefix "Colombia"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Peru"></see>
    /// </summary>
    let Peru = _prefix "Peru"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Trinidad_and_Tobago"></see>
    /// </summary>
    let Trinidad_and_Tobago = _prefix "Trinidad_and_Tobago"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#El_Salvador"></see>
    /// </summary>
    let El_Salvador = _prefix "El_Salvador"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Argentina"></see>
    /// </summary>
    let Argentina = _prefix "Argentina"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Andorra"></see>
    /// </summary>
    let Andorra = _prefix "Andorra"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Spain"></see>
    /// </summary>
    let Spain = _prefix "Spain"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#France"></see>
    /// </summary>
    let France = _prefix "France"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#middle_Africa"></see>
    /// </summary>
    let middle_Africa = _prefix "middle_Africa"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#SADC"></see>
    /// </summary>
    let SADC = _prefix "SADC"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#CEEAC"></see>
    /// </summary>
    let CEEAC = _prefix "CEEAC"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Anguilla"></see>
    /// </summary>
    let Anguilla = _prefix "Anguilla"

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#United_Kingdom_of_Great_Britain_and_Northern_Ireland__the"></see>
    /// </summary>
    let United_Kingdom_of_Great_Britain_and_Northern_Ireland__the =
        _prefix "United_Kingdom_of_Great_Britain_and_Northern_Ireland__the"

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Antarctica"></see>
    /// </summary>
    let Antarctica = _prefix "Antarctica"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#other"></see>
    /// </summary>
    let other = _prefix "other"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#CARIFORUM"></see>
    /// </summary>
    let CARIFORUM = _prefix "CARIFORUM"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Caribbean"></see>
    /// </summary>
    let Caribbean = _prefix "Caribbean"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#CARICOM"></see>
    /// </summary>
    let CARICOM = _prefix "CARICOM"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#CARICOM_1985"></see>
    /// </summary>
    let CARICOM_1985 = _prefix "CARICOM_1985"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#South_America"></see>
    /// </summary>
    let South_America = _prefix "South_America"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#MERCOSUR_1991"></see>
    /// </summary>
    let MERCOSUR_1991 = _prefix "MERCOSUR_1991"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#MERCOSUR"></see>
    /// </summary>
    let MERCOSUR = _prefix "MERCOSUR"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Armenia"></see>
    /// </summary>
    let Armenia = _prefix "Armenia"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Turkey"></see>
    /// </summary>
    let Turkey = _prefix "Turkey"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Georgia"></see>
    /// </summary>
    let Georgia = _prefix "Georgia"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Azerbaijan"></see>
    /// </summary>
    let Azerbaijan = _prefix "Azerbaijan"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#western_Asia"></see>
    /// </summary>
    let western_Asia = _prefix "western_Asia"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#isSuccessorOf"></see>
    /// </summary>
    let isSuccessorOf = _prefix "isSuccessorOf"

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Union_of_Soviet_Socialist_Republic_the"></see>
    /// </summary>
    let Union_of_Soviet_Socialist_Republic_the =
        _prefix "Union_of_Soviet_Socialist_Republic_the"

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Aruba"></see>
    /// </summary>
    let Aruba = _prefix "Aruba"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Netherlands_the"></see>
    /// </summary>
    let Netherlands_the = _prefix "Netherlands_the"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Netherlands_Antilles"></see>
    /// </summary>
    let Netherlands_Antilles = _prefix "Netherlands_Antilles"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Qatar"></see>
    /// </summary>
    let Qatar = _prefix "Qatar"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Oman"></see>
    /// </summary>
    let Oman = _prefix "Oman"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Nepal"></see>
    /// </summary>
    let Nepal = _prefix "Nepal"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Kazakhstan"></see>
    /// </summary>
    let Kazakhstan = _prefix "Kazakhstan"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Viet_Nam"></see>
    /// </summary>
    let Viet_Nam = _prefix "Viet_Nam"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Israel"></see>
    /// </summary>
    let Israel = _prefix "Israel"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Cyprus"></see>
    /// </summary>
    let Cyprus = _prefix "Cyprus"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Myanmar"></see>
    /// </summary>
    let Myanmar = _prefix "Myanmar"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#United_Arab_Emirates__the"></see>
    /// </summary>
    let United_Arab_Emirates__the = _prefix "United_Arab_Emirates__the"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Sri_Lanka"></see>
    /// </summary>
    let Sri_Lanka = _prefix "Sri_Lanka"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Yemen"></see>
    /// </summary>
    let Yemen = _prefix "Yemen"

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Democratic_People_s_Republic_of_Korea_the"></see>
    /// </summary>
    let Democratic_People_s_Republic_of_Korea_the =
        _prefix "Democratic_People_s_Republic_of_Korea_the"

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Bangladesh"></see>
    /// </summary>
    let Bangladesh = _prefix "Bangladesh"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Kyrgyzstan"></see>
    /// </summary>
    let Kyrgyzstan = _prefix "Kyrgyzstan"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Bahrain"></see>
    /// </summary>
    let Bahrain = _prefix "Bahrain"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Mongolia"></see>
    /// </summary>
    let Mongolia = _prefix "Mongolia"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Syrian_Arab_Republic_the"></see>
    /// </summary>
    let Syrian_Arab_Republic_the = _prefix "Syrian_Arab_Republic_the"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Iraq"></see>
    /// </summary>
    let Iraq = _prefix "Iraq"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Maldives"></see>
    /// </summary>
    let Maldives = _prefix "Maldives"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#India"></see>
    /// </summary>
    let India = _prefix "India"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Indonesia"></see>
    /// </summary>
    let Indonesia = _prefix "Indonesia"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Malaysia"></see>
    /// </summary>
    let Malaysia = _prefix "Malaysia"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Jordan"></see>
    /// </summary>
    let Jordan = _prefix "Jordan"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Republic_of_Korea__the"></see>
    /// </summary>
    let Republic_of_Korea__the = _prefix "Republic_of_Korea__the"

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Lao_People_s_Democratic_Republic__the"></see>
    /// </summary>
    let Lao_People_s_Democratic_Republic__the =
        _prefix "Lao_People_s_Democratic_Republic__the"

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Brunei_Darussalam"></see>
    /// </summary>
    let Brunei_Darussalam = _prefix "Brunei_Darussalam"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Lebanon"></see>
    /// </summary>
    let Lebanon = _prefix "Lebanon"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Bhutan"></see>
    /// </summary>
    let Bhutan = _prefix "Bhutan"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Saudi_Arabia"></see>
    /// </summary>
    let Saudi_Arabia = _prefix "Saudi_Arabia"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Cambodia"></see>
    /// </summary>
    let Cambodia = _prefix "Cambodia"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Timor-Leste"></see>
    /// </summary>
    let ``Timor-Leste`` = _prefix "Timor-Leste"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Philippines__the"></see>
    /// </summary>
    let Philippines__the = _prefix "Philippines__the"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Kuwait"></see>
    /// </summary>
    let Kuwait = _prefix "Kuwait"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Thailand"></see>
    /// </summary>
    let Thailand = _prefix "Thailand"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Japan"></see>
    /// </summary>
    let Japan = _prefix "Japan"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Singapore"></see>
    /// </summary>
    let Singapore = _prefix "Singapore"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Australia"></see>
    /// </summary>
    let Australia = _prefix "Australia"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#PIF"></see>
    /// </summary>
    let PIF = _prefix "PIF"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Oceania"></see>
    /// </summary>
    let Oceania = _prefix "Oceania"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Australia_and_New_Zealand"></see>
    /// </summary>
    let Australia_and_New_Zealand = _prefix "Australia_and_New_Zealand"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#New_Zealand"></see>
    /// </summary>
    let New_Zealand = _prefix "New_Zealand"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Austria"></see>
    /// </summary>
    let Austria = _prefix "Austria"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Slovakia"></see>
    /// </summary>
    let Slovakia = _prefix "Slovakia"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Liechtenstein"></see>
    /// </summary>
    let Liechtenstein = _prefix "Liechtenstein"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Hungary"></see>
    /// </summary>
    let Hungary = _prefix "Hungary"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Czech_Republic_the"></see>
    /// </summary>
    let Czech_Republic_the = _prefix "Czech_Republic_the"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Germany"></see>
    /// </summary>
    let Germany = _prefix "Germany"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Slovenia"></see>
    /// </summary>
    let Slovenia = _prefix "Slovenia"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Switzerland"></see>
    /// </summary>
    let Switzerland = _prefix "Switzerland"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Italy"></see>
    /// </summary>
    let Italy = _prefix "Italy"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#EU"></see>
    /// </summary>
    let EU = _prefix "EU"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#western_Europe"></see>
    /// </summary>
    let western_Europe = _prefix "western_Europe"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Russian_Federation__the"></see>
    /// </summary>
    let Russian_Federation__the = _prefix "Russian_Federation__the"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#CCASG"></see>
    /// </summary>
    let CCASG = _prefix "CCASG"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#SAARC_1985"></see>
    /// </summary>
    let SAARC_1985 = _prefix "SAARC_1985"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#NFIDC"></see>
    /// </summary>
    let NFIDC = _prefix "NFIDC"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Belarus"></see>
    /// </summary>
    let Belarus = _prefix "Belarus"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Poland"></see>
    /// </summary>
    let Poland = _prefix "Poland"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Lithuania"></see>
    /// </summary>
    let Lithuania = _prefix "Lithuania"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Ukraine"></see>
    /// </summary>
    let Ukraine = _prefix "Ukraine"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Latvia"></see>
    /// </summary>
    let Latvia = _prefix "Latvia"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#eastern_Europe"></see>
    /// </summary>
    let eastern_Europe = _prefix "eastern_Europe"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Belgium"></see>
    /// </summary>
    let Belgium = _prefix "Belgium"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Luxembourg"></see>
    /// </summary>
    let Luxembourg = _prefix "Luxembourg"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#CAC"></see>
    /// </summary>
    let CAC = _prefix "CAC"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#central_America"></see>
    /// </summary>
    let central_America = _prefix "central_America"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#ECOWAS"></see>
    /// </summary>
    let ECOWAS = _prefix "ECOWAS"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#ECOWAS_1985"></see>
    /// </summary>
    let ECOWAS_1985 = _prefix "ECOWAS_1985"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#UEMOA"></see>
    /// </summary>
    let UEMOA = _prefix "UEMOA"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#CEN_SAD"></see>
    /// </summary>
    let CEN_SAD = _prefix "CEN_SAD"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#western_Africa"></see>
    /// </summary>
    let western_Africa = _prefix "western_Africa"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Bermuda"></see>
    /// </summary>
    let Bermuda = _prefix "Bermuda"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#CAN"></see>
    /// </summary>
    let CAN = _prefix "CAN"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Bonaire_Sint_Eustatius_and_Saba"></see>
    /// </summary>
    let Bonaire_Sint_Eustatius_and_Saba = _prefix "Bonaire_Sint_Eustatius_and_Saba"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Bosnia_and_Herzegovina"></see>
    /// </summary>
    let Bosnia_and_Herzegovina = _prefix "Bosnia_and_Herzegovina"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Croatia"></see>
    /// </summary>
    let Croatia = _prefix "Croatia"

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Socialist_Federal_Republic_of_Yugoslavia_the"></see>
    /// </summary>
    let Socialist_Federal_Republic_of_Yugoslavia_the =
        _prefix "Socialist_Federal_Republic_of_Yugoslavia_the"

    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#southern_Africa"></see>
    /// </summary>
    let southern_Africa = _prefix "southern_Africa"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#French_Guiana"></see>
    /// </summary>
    let French_Guiana = _prefix "French_Guiana"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#British_Virgin_Islands"></see>
    /// </summary>
    let British_Virgin_Islands = _prefix "British_Virgin_Islands"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#south-eastern_Asia"></see>
    /// </summary>
    let ``south-eastern_Asia`` = _prefix "south-eastern_Asia"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Bulgaria"></see>
    /// </summary>
    let Bulgaria = _prefix "Bulgaria"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Romania"></see>
    /// </summary>
    let Romania = _prefix "Romania"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#CEN_SAD_1998"></see>
    /// </summary>
    let CEN_SAD_1998 = _prefix "CEN_SAD_1998"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#eastern_Africa"></see>
    /// </summary>
    let eastern_Africa = _prefix "eastern_Africa"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#COMESA_1994"></see>
    /// </summary>
    let COMESA_1994 = _prefix "COMESA_1994"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#COMESA"></see>
    /// </summary>
    let COMESA = _prefix "COMESA"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#sourceModified"></see>
    /// </summary>
    let sourceModified = _prefix "sourceModified"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#CAEU"></see>
    /// </summary>
    let CAEU = _prefix "CAEU"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#isPredecessorOf"></see>
    /// </summary>
    let isPredecessorOf = _prefix "isPredecessorOf"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#CEMAC"></see>
    /// </summary>
    let CEMAC = _prefix "CEMAC"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Libyan_Arab_Jamahiriya__the"></see>
    /// </summary>
    let Libyan_Arab_Jamahiriya__the = _prefix "Libyan_Arab_Jamahiriya__the"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#PTA"></see>
    /// </summary>
    let PTA = _prefix "PTA"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#northern_America"></see>
    /// </summary>
    let northern_America = _prefix "northern_America"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Cayman_Islands"></see>
    /// </summary>
    let Cayman_Islands = _prefix "Cayman_Islands"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#eastern_Asia"></see>
    /// </summary>
    let eastern_Asia = _prefix "eastern_Asia"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Cook_Islands_the"></see>
    /// </summary>
    let Cook_Islands_the = _prefix "Cook_Islands_the"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#PIF_1985"></see>
    /// </summary>
    let PIF_1985 = _prefix "PIF_1985"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Polynesia"></see>
    /// </summary>
    let Polynesia = _prefix "Polynesia"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Curacao"></see>
    /// </summary>
    let Curacao = _prefix "Curacao"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Czechoslovakia"></see>
    /// </summary>
    let Czechoslovakia = _prefix "Czechoslovakia"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Zaire"></see>
    /// </summary>
    let Zaire = _prefix "Zaire"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Democratic_Yemen"></see>
    /// </summary>
    let Democratic_Yemen = _prefix "Democratic_Yemen"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Denmark"></see>
    /// </summary>
    let Denmark = _prefix "Denmark"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#northern_Europe"></see>
    /// </summary>
    let northern_Europe = _prefix "northern_Europe"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#IGAD"></see>
    /// </summary>
    let IGAD = _prefix "IGAD"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#IGADD"></see>
    /// </summary>
    let IGADD = _prefix "IGADD"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Finland"></see>
    /// </summary>
    let Finland = _prefix "Finland"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Sweden"></see>
    /// </summary>
    let Sweden = _prefix "Sweden"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Ireland"></see>
    /// </summary>
    let Ireland = _prefix "Ireland"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Estonia"></see>
    /// </summary>
    let Estonia = _prefix "Estonia"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Portugal"></see>
    /// </summary>
    let Portugal = _prefix "Portugal"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Malta"></see>
    /// </summary>
    let Malta = _prefix "Malta"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Ethiopia_1993"></see>
    /// </summary>
    let Ethiopia_1993 = _prefix "Ethiopia_1993"
    /// <summary>
    /// associate member of FAO
    /// <see href="http://aims.fao.org/aos/geopolitical.owl#Faroe_Islands"></see></summary>
    let Faroe_Islands = _prefix "Faroe_Islands"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Republic_of_Moldova"></see>
    /// </summary>
    let Republic_of_Moldova = _prefix "Republic_of_Moldova"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#San_Marino"></see>
    /// </summary>
    let San_Marino = _prefix "San_Marino"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Monaco"></see>
    /// </summary>
    let Monaco = _prefix "Monaco"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Norway"></see>
    /// </summary>
    let Norway = _prefix "Norway"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Holy_See"></see>
    /// </summary>
    let Holy_See = _prefix "Holy_See"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Iceland"></see>
    /// </summary>
    let Iceland = _prefix "Iceland"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Kiribati"></see>
    /// </summary>
    let Kiribati = _prefix "Kiribati"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Samoa"></see>
    /// </summary>
    let Samoa = _prefix "Samoa"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Palau"></see>
    /// </summary>
    let Palau = _prefix "Palau"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Tonga"></see>
    /// </summary>
    let Tonga = _prefix "Tonga"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Fiji"></see>
    /// </summary>
    let Fiji = _prefix "Fiji"
    /// <summary>
    /// associate member of FAO
    /// <see href="http://aims.fao.org/aos/geopolitical.owl#Tokelau"></see></summary>
    let Tokelau = _prefix "Tokelau"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Micronesia__Fed_States_of_"></see>
    /// </summary>
    let Micronesia__Fed_States_of_ = _prefix "Micronesia__Fed_States_of_"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Tuvalu"></see>
    /// </summary>
    let Tuvalu = _prefix "Tuvalu"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Solomon_Islands"></see>
    /// </summary>
    let Solomon_Islands = _prefix "Solomon_Islands"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Vanuatu"></see>
    /// </summary>
    let Vanuatu = _prefix "Vanuatu"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Papua_New_Guinea"></see>
    /// </summary>
    let Papua_New_Guinea = _prefix "Papua_New_Guinea"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Niue"></see>
    /// </summary>
    let Niue = _prefix "Niue"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Marshall_Islands__the"></see>
    /// </summary>
    let Marshall_Islands__the = _prefix "Marshall_Islands__the"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Nauru"></see>
    /// </summary>
    let Nauru = _prefix "Nauru"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#FAO_2007"></see>
    /// </summary>
    let FAO_2007 = _prefix "FAO_2007"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#organization"></see>
    /// </summary>
    let organization = _prefix "organization"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Falkland_Is"></see>
    /// </summary>
    let Falkland_Is = _prefix "Falkland_Is"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Federal_Republic_of_Germany_the"></see>
    /// </summary>
    let Federal_Republic_of_Germany_the = _prefix "Federal_Republic_of_Germany_the"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Melanesia"></see>
    /// </summary>
    let Melanesia = _prefix "Melanesia"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#French_Polynesia"></see>
    /// </summary>
    let French_Polynesia = _prefix "French_Polynesia"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#GDP"></see>
    /// </summary>
    let GDP = _prefix "GDP"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#hasStatistics"></see>
    /// </summary>
    let hasStatistics = _prefix "hasStatistics"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#German_Democratic_Republic_the"></see>
    /// </summary>
    let German_Democratic_Republic_the = _prefix "German_Democratic_Republic_the"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Gibraltar"></see>
    /// </summary>
    let Gibraltar = _prefix "Gibraltar"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Guadeloupe"></see>
    /// </summary>
    let Guadeloupe = _prefix "Guadeloupe"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Guam"></see>
    /// </summary>
    let Guam = _prefix "Guam"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#HDI"></see>
    /// </summary>
    let HDI = _prefix "HDI"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#HDIUnit"></see>
    /// </summary>
    let HDIUnit = _prefix "HDIUnit"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#central_Asia"></see>
    /// </summary>
    let central_Asia = _prefix "central_Asia"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Micronesia"></see>
    /// </summary>
    let Micronesia = _prefix "Micronesia"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#special_group"></see>
    /// </summary>
    let special_group = _prefix "special_group"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Martinique"></see>
    /// </summary>
    let Martinique = _prefix "Martinique"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Serbia_and_Montenegro"></see>
    /// </summary>
    let Serbia_and_Montenegro = _prefix "Serbia_and_Montenegro"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Montserrat"></see>
    /// </summary>
    let Montserrat = _prefix "Montserrat"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#NFIDC_2010"></see>
    /// </summary>
    let NFIDC_2010 = _prefix "NFIDC_2010"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Sint_Maarten"></see>
    /// </summary>
    let Sint_Maarten = _prefix "Sint_Maarten"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#New_Caledonia"></see>
    /// </summary>
    let New_Caledonia = _prefix "New_Caledonia"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Puerto_Rico"></see>
    /// </summary>
    let Puerto_Rico = _prefix "Puerto_Rico"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Reunion"></see>
    /// </summary>
    let Reunion = _prefix "Reunion"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#United_States_Virgin_Islands"></see>
    /// </summary>
    let United_States_Virgin_Islands = _prefix "United_States_Virgin_Islands"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Saint-Martin"></see>
    /// </summary>
    let ``Saint-Martin`` = _prefix "Saint-Martin"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Saint_Barthelemy"></see>
    /// </summary>
    let Saint_Barthelemy = _prefix "Saint_Barthelemy"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Saint_Helena"></see>
    /// </summary>
    let Saint_Helena = _prefix "Saint_Helena"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Saint_Pierre_and_Miquelon"></see>
    /// </summary>
    let Saint_Pierre_and_Miquelon = _prefix "Saint_Pierre_and_Miquelon"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Yugoslavia"></see>
    /// </summary>
    let Yugoslavia = _prefix "Yugoslavia"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Sudan_the_1956"></see>
    /// </summary>
    let Sudan_the_1956 = _prefix "Sudan_the_1956"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Turks_and_Caicos_Islands"></see>
    /// </summary>
    let Turks_and_Caicos_Islands = _prefix "Turks_and_Caicos_Islands"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Wallis_and_Futuna_Is"></see>
    /// </summary>
    let Wallis_and_Futuna_Is = _prefix "Wallis_and_Futuna_Is"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#Yemen_1990"></see>
    /// </summary>
    let Yemen_1990 = _prefix "Yemen_1990"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#agriculturalArea"></see>
    /// </summary>
    let agriculturalArea = _prefix "agriculturalArea"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#area"></see>
    /// </summary>
    let area = _prefix "area"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#hasCode"></see>
    /// </summary>
    let hasCode = _prefix "hasCode"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#hasCurrency"></see>
    /// </summary>
    let hasCurrency = _prefix "hasCurrency"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#countryArea"></see>
    /// </summary>
    let countryArea = _prefix "countryArea"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#disputed"></see>
    /// </summary>
    let disputed = _prefix "disputed"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#territory"></see>
    /// </summary>
    let territory = _prefix "territory"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#group"></see>
    /// </summary>
    let group = _prefix "group"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#hasCoordinate"></see>
    /// </summary>
    let hasCoordinate = _prefix "hasCoordinate"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#hasListName"></see>
    /// </summary>
    let hasListName = _prefix "hasListName"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#hasNationality"></see>
    /// </summary>
    let hasNationality = _prefix "hasNationality"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#hasOfficialName"></see>
    /// </summary>
    let hasOfficialName = _prefix "hasOfficialName"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#hasShortName"></see>
    /// </summary>
    let hasShortName = _prefix "hasShortName"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#landArea"></see>
    /// </summary>
    let landArea = _prefix "landArea"
    /// <summary>
    ///   <see href="http://aims.fao.org/aos/geopolitical.owl#population"></see>
    /// </summary>
    let population = _prefix "population"

#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module geop =
    let _prefixId = PrefixId.fromNamespaceLabel "http://aims.fao.org/aos/geopolitical.owl#" "geop"

    let AMU = _prefixId.prefix "AMU"
    let Afghanistan = _prefixId.prefix "Afghanistan"
    let Africa = _prefixId.prefix "Africa"
    let Albania = _prefixId.prefix "Albania"
    let Algeria = _prefixId.prefix "Algeria"
    let American_Samoa = _prefixId.prefix "American_Samoa"
    let Americas = _prefixId.prefix "Americas"
    let Andorra = _prefixId.prefix "Andorra"
    let Angola = _prefixId.prefix "Angola"
    let Anguilla = _prefixId.prefix "Anguilla"
    let Antarctica = _prefixId.prefix "Antarctica"
    let Antigua_and_Barbuda = _prefixId.prefix "Antigua_and_Barbuda"
    let Argentina = _prefixId.prefix "Argentina"
    let Armenia = _prefixId.prefix "Armenia"
    let Aruba = _prefixId.prefix "Aruba"
    let Asia = _prefixId.prefix "Asia"
    let Australia = _prefixId.prefix "Australia"
    let Australia_and_New_Zealand = _prefixId.prefix "Australia_and_New_Zealand"
    let Austria = _prefixId.prefix "Austria"
    let Azerbaijan = _prefixId.prefix "Azerbaijan"
    let Bahamas_the = _prefixId.prefix "Bahamas_the"
    let Bahrain = _prefixId.prefix "Bahrain"
    let Bangladesh = _prefixId.prefix "Bangladesh"
    let Barbados = _prefixId.prefix "Barbados"
    let Belarus = _prefixId.prefix "Belarus"
    let Belgium = _prefixId.prefix "Belgium"
    let Belize = _prefixId.prefix "Belize"
    let Benin = _prefixId.prefix "Benin"
    let Bermuda = _prefixId.prefix "Bermuda"
    let Bhutan = _prefixId.prefix "Bhutan"
    let Bolivia = _prefixId.prefix "Bolivia"

    let Bonaire_Sint_Eustatius_and_Saba = _prefixId.prefix "Bonaire_Sint_Eustatius_and_Saba"

    let Bosnia_and_Herzegovina = _prefixId.prefix "Bosnia_and_Herzegovina"
    let Botswana = _prefixId.prefix "Botswana"
    let Brazil = _prefixId.prefix "Brazil"
    let British_Virgin_Islands = _prefixId.prefix "British_Virgin_Islands"
    let Brunei_Darussalam = _prefixId.prefix "Brunei_Darussalam"
    let Bulgaria = _prefixId.prefix "Bulgaria"
    let Burkina_Faso = _prefixId.prefix "Burkina_Faso"
    let Burundi = _prefixId.prefix "Burundi"
    let CAC = _prefixId.prefix "CAC"
    let CAEU = _prefixId.prefix "CAEU"
    let CAN = _prefixId.prefix "CAN"
    let CARICOM = _prefixId.prefix "CARICOM"
    let CARICOM_1985 = _prefixId.prefix "CARICOM_1985"
    let CARIFORUM = _prefixId.prefix "CARIFORUM"
    let CCASG = _prefixId.prefix "CCASG"
    let CEEAC = _prefixId.prefix "CEEAC"
    let CEMAC = _prefixId.prefix "CEMAC"
    let CEN_SAD = _prefixId.prefix "CEN_SAD"
    let CEN_SAD_1998 = _prefixId.prefix "CEN_SAD_1998"
    let COMESA = _prefixId.prefix "COMESA"
    let COMESA_1994 = _prefixId.prefix "COMESA_1994"
    let Cambodia = _prefixId.prefix "Cambodia"
    let Cameroon = _prefixId.prefix "Cameroon"
    let Canada = _prefixId.prefix "Canada"
    let Cape_Verde = _prefixId.prefix "Cape_Verde"
    let Caribbean = _prefixId.prefix "Caribbean"
    let Cayman_Islands = _prefixId.prefix "Cayman_Islands"
    let Central_African_Republic_the = _prefixId.prefix "Central_African_Republic_the"
    let Chad = _prefixId.prefix "Chad"
    let Chile = _prefixId.prefix "Chile"
    let China = _prefixId.prefix "China"
    let Colombia = _prefixId.prefix "Colombia"
    let Comoros_the = _prefixId.prefix "Comoros_the"
    let Congo_the = _prefixId.prefix "Congo_the"
    let Cook_Islands_the = _prefixId.prefix "Cook_Islands_the"
    let Costa_Rica = _prefixId.prefix "Costa_Rica"
    let Cote_d_Ivoire = _prefixId.prefix "Cote_d_Ivoire"
    let Croatia = _prefixId.prefix "Croatia"
    let Cuba = _prefixId.prefix "Cuba"
    let Curacao = _prefixId.prefix "Curacao"
    let Cyprus = _prefixId.prefix "Cyprus"
    let Czech_Republic_the = _prefixId.prefix "Czech_Republic_the"
    let Czechoslovakia = _prefixId.prefix "Czechoslovakia"

    let Democratic_People_s_Republic_of_Korea_the = _prefixId.prefix "Democratic_People_s_Republic_of_Korea_the"

    let Democratic_Republic_of_the_Congo = _prefixId.prefix "Democratic_Republic_of_the_Congo"

    let Democratic_Yemen = _prefixId.prefix "Democratic_Yemen"
    let Denmark = _prefixId.prefix "Denmark"
    let Djibouti = _prefixId.prefix "Djibouti"
    let Dominica = _prefixId.prefix "Dominica"
    let Dominican_Republic_the = _prefixId.prefix "Dominican_Republic_the"
    let ECO = _prefixId.prefix "ECO"
    let ECOWAS = _prefixId.prefix "ECOWAS"
    let ECOWAS_1985 = _prefixId.prefix "ECOWAS_1985"
    let EU = _prefixId.prefix "EU"
    let Ecuador = _prefixId.prefix "Ecuador"
    let Egypt = _prefixId.prefix "Egypt"
    let El_Salvador = _prefixId.prefix "El_Salvador"
    let Equatorial_Guinea = _prefixId.prefix "Equatorial_Guinea"
    let Eritrea = _prefixId.prefix "Eritrea"
    let Estonia = _prefixId.prefix "Estonia"
    let Ethiopia = _prefixId.prefix "Ethiopia"
    let Ethiopia_1993 = _prefixId.prefix "Ethiopia_1993"
    let Europe = _prefixId.prefix "Europe"
    let FAO = _prefixId.prefix "FAO"
    let FAO_2006 = _prefixId.prefix "FAO_2006"
    let FAO_2007 = _prefixId.prefix "FAO_2007"
    let Falkland_Is = _prefixId.prefix "Falkland_Is"
    let Faroe_Islands = _prefixId.prefix "Faroe_Islands"

    let Federal_Republic_of_Germany_the = _prefixId.prefix "Federal_Republic_of_Germany_the"

    let Fiji = _prefixId.prefix "Fiji"
    let Finland = _prefixId.prefix "Finland"
    let France = _prefixId.prefix "France"
    let French_Guiana = _prefixId.prefix "French_Guiana"
    let French_Polynesia = _prefixId.prefix "French_Polynesia"
    /// <summary>
    ///   <para>geop:sourceIdentifier : http://data.albankaldawli.org/indicator/NY.GDP.MKTP.CDgeop:sourceIdentifier : http://donnees.banquemondiale.org/indicateur/NY.GDP.MKTP.CDgeop:sourceIdentifier : ttp://datos.bancomundial.org/indicador/NY.GDP.MKTP.CDgeop:sourceIdentifier : http://data.worldbank.org/indicator/NY.GDP.MKTP.CDgeop:sourceIdentifier : http://data.worldbank.org/indicator/NY.GDP.MKTP.CD^^xsd:string</para>
    ///   <para>dcterms:source : World Bank http://data.worldbank.org/indicator/NY.GDP.MKTP.CD^^xsd:string</para>
    ///   <para>dcterms:description : GDP at purchaser's prices is the sum of gross value added by all resident producers in the economy plus any product taxes and minus any subsidies not included in the value of the products. It is calculated without making deductions for depreciation of fabricated assets or for depletion and degradation of natural resources. Data are in current U.S. dollars. Dollar figures for GDP are converted from domestic currencies using single year official exchange rates. For a few countries where the official exchange rate does not reflect the rate effectively applied to actual foreign exchange transactions, an alternative conversion factor is used. Source: World Bank national accounts data, and OECD National Accounts data files. http://data.worldbank.org/indicator/NY.GDP.MKTP.CD^^xsd:string</para>
    ///   <para>geop:sourceModified : 2010-12-16^^xsd:string</para>
    ///   <para>geop:sourceCreator : World Bank^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#GDP">geop:GDP</a>
    /// </summary>
    let GDP = _prefixId.prefix "GDP"
    let GDPNotes = _prefixId.prefix "GDPNotes"
    let GDPTotalInCurrentPrices = _prefixId.prefix "GDPTotalInCurrentPrices"
    let GDPUnit = _prefixId.prefix "GDPUnit"
    let GDPYear = _prefixId.prefix "GDPYear"
    let Gabon = _prefixId.prefix "Gabon"
    let Gambia__the = _prefixId.prefix "Gambia__the"
    let Georgia = _prefixId.prefix "Georgia"

    let German_Democratic_Republic_the = _prefixId.prefix "German_Democratic_Republic_the"

    let Germany = _prefixId.prefix "Germany"
    let Ghana = _prefixId.prefix "Ghana"
    let Gibraltar = _prefixId.prefix "Gibraltar"
    let Greece = _prefixId.prefix "Greece"
    let Grenada = _prefixId.prefix "Grenada"
    let Guadeloupe = _prefixId.prefix "Guadeloupe"
    let Guam = _prefixId.prefix "Guam"
    let Guatemala = _prefixId.prefix "Guatemala"
    let Guinea = _prefixId.prefix "Guinea"
    let Guinea_Bissau = _prefixId.prefix "Guinea-Bissau"
    let Guyana = _prefixId.prefix "Guyana"
    /// <summary>
    ///   <para>geop:sourceModified : 2010-11-04^^xsd:string</para>
    ///   <para>geop:sourceCreator : UNDP - HDRO^^xsd:string</para>
    ///   <para>geop:sourceIdentifier : http://hdr.undp.org/en/statistics/hdi/ ^^xsd:stringgeop:sourceIdentifier : http://hdr.undp.org/en/statistics/hdi/ geop:sourceIdentifier : http://hdr.undp.org/es/estadisticas/idh/geop:sourceIdentifier : http://hdr.undp.org/fr/statistiques/idh/</para>
    ///   <para>dcterms:source : UNDP - HDRO http://hdrstats.undp.org/en/indicators/49806.html^^xsd:string</para>
    ///   <para>dcterms:description :  composite index measuring average achievement in three basic dimensions of human development—a long and healthy life, knowledge and a decent standard of living. Source: Calculated based on data from UNDESA (2009d), Barro and Lee (2010), UNESCO Institute for Statistics (2010b), World Bank (2010b) and IMF(2010a) . http://hdrstats.undp.org/en/indicators/49806.html^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#HDI">geop:HDI</a>
    /// </summary>
    let HDI = _prefixId.prefix "HDI"
    let HDINotes = _prefixId.prefix "HDINotes"
    let HDITotal = _prefixId.prefix "HDITotal"
    let HDIUnit = _prefixId.prefix "HDIUnit"
    let HDIYear = _prefixId.prefix "HDIYear"
    let Haiti = _prefixId.prefix "Haiti"
    let Holy_See = _prefixId.prefix "Holy_See"
    let Honduras = _prefixId.prefix "Honduras"
    let Hungary = _prefixId.prefix "Hungary"
    let IGAD = _prefixId.prefix "IGAD"
    let IGADD = _prefixId.prefix "IGADD"
    let Iceland = _prefixId.prefix "Iceland"
    let India = _prefixId.prefix "India"
    let Indonesia = _prefixId.prefix "Indonesia"
    let Iran_Islamic_Rep_of_ = _prefixId.prefix "Iran_Islamic_Rep_of_"
    let Iraq = _prefixId.prefix "Iraq"
    let Ireland = _prefixId.prefix "Ireland"
    let Israel = _prefixId.prefix "Israel"
    let Italy = _prefixId.prefix "Italy"
    let Jamaica = _prefixId.prefix "Jamaica"
    let Japan = _prefixId.prefix "Japan"
    let Jordan = _prefixId.prefix "Jordan"
    let Kazakhstan = _prefixId.prefix "Kazakhstan"
    let Kenya = _prefixId.prefix "Kenya"
    let Kiribati = _prefixId.prefix "Kiribati"
    let Kuwait = _prefixId.prefix "Kuwait"
    let Kyrgyzstan = _prefixId.prefix "Kyrgyzstan"
    let LDC = _prefixId.prefix "LDC"
    let LDC_1993 = _prefixId.prefix "LDC_1993"
    let LDC_2010 = _prefixId.prefix "LDC_2010"
    let LIFDC = _prefixId.prefix "LIFDC"
    let LIFDC_2005 = _prefixId.prefix "LIFDC_2005"
    let LIFDC_2008 = _prefixId.prefix "LIFDC_2008"
    let LIFDC_2009 = _prefixId.prefix "LIFDC_2009"
    let LIFDC_2010 = _prefixId.prefix "LIFDC_2010"
    let LLDC = _prefixId.prefix "LLDC"

    let Lao_People_s_Democratic_Republic__the = _prefixId.prefix "Lao_People_s_Democratic_Republic__the"

    let Latvia = _prefixId.prefix "Latvia"
    let Lebanon = _prefixId.prefix "Lebanon"
    let Lesotho = _prefixId.prefix "Lesotho"
    let Liberia = _prefixId.prefix "Liberia"
    let Libya = _prefixId.prefix "Libya"
    let Libyan_Arab_Jamahiriya__the = _prefixId.prefix "Libyan_Arab_Jamahiriya__the"
    let Liechtenstein = _prefixId.prefix "Liechtenstein"
    let Lithuania = _prefixId.prefix "Lithuania"
    let Luxembourg = _prefixId.prefix "Luxembourg"
    let MERCOSUR = _prefixId.prefix "MERCOSUR"
    let MERCOSUR_1991 = _prefixId.prefix "MERCOSUR_1991"
    let Madagascar = _prefixId.prefix "Madagascar"
    let Malawi = _prefixId.prefix "Malawi"
    let Malaysia = _prefixId.prefix "Malaysia"
    let Maldives = _prefixId.prefix "Maldives"
    let Mali = _prefixId.prefix "Mali"
    let Malta = _prefixId.prefix "Malta"
    let Marshall_Islands__the = _prefixId.prefix "Marshall_Islands__the"
    let Martinique = _prefixId.prefix "Martinique"
    let Mauritania = _prefixId.prefix "Mauritania"
    let Mauritius = _prefixId.prefix "Mauritius"
    let Melanesia = _prefixId.prefix "Melanesia"
    let Mexico = _prefixId.prefix "Mexico"
    let Micronesia = _prefixId.prefix "Micronesia"
    let Micronesia__Fed_States_of_ = _prefixId.prefix "Micronesia__Fed_States_of_"
    let Monaco = _prefixId.prefix "Monaco"
    let Mongolia = _prefixId.prefix "Mongolia"
    let Montenegro = _prefixId.prefix "Montenegro"
    let Montserrat = _prefixId.prefix "Montserrat"
    let Morocco = _prefixId.prefix "Morocco"
    let Mozambique = _prefixId.prefix "Mozambique"
    let Myanmar = _prefixId.prefix "Myanmar"
    let NFIDC = _prefixId.prefix "NFIDC"
    let NFIDC_2010 = _prefixId.prefix "NFIDC_2010"
    let Namibia = _prefixId.prefix "Namibia"
    let Nauru = _prefixId.prefix "Nauru"
    let Nepal = _prefixId.prefix "Nepal"
    let Netherlands_Antilles = _prefixId.prefix "Netherlands_Antilles"
    let Netherlands_the = _prefixId.prefix "Netherlands_the"
    let New_Caledonia = _prefixId.prefix "New_Caledonia"
    let New_Zealand = _prefixId.prefix "New_Zealand"
    let Nicaragua = _prefixId.prefix "Nicaragua"
    let Niger_the = _prefixId.prefix "Niger_the"
    let Nigeria = _prefixId.prefix "Nigeria"
    let Niue = _prefixId.prefix "Niue"
    let Norway = _prefixId.prefix "Norway"
    let Oceania = _prefixId.prefix "Oceania"
    let Oman = _prefixId.prefix "Oman"
    let PIF = _prefixId.prefix "PIF"
    let PIF_1985 = _prefixId.prefix "PIF_1985"
    let PTA = _prefixId.prefix "PTA"
    let Pakistan = _prefixId.prefix "Pakistan"
    let Palau = _prefixId.prefix "Palau"
    let Panama = _prefixId.prefix "Panama"
    let Papua_New_Guinea = _prefixId.prefix "Papua_New_Guinea"
    let Paraguay = _prefixId.prefix "Paraguay"
    let Peru = _prefixId.prefix "Peru"
    let Philippines__the = _prefixId.prefix "Philippines__the"
    let Poland = _prefixId.prefix "Poland"
    let Polynesia = _prefixId.prefix "Polynesia"
    let Portugal = _prefixId.prefix "Portugal"
    let Puerto_Rico = _prefixId.prefix "Puerto_Rico"
    let Qatar = _prefixId.prefix "Qatar"
    let Republic_of_Korea__the = _prefixId.prefix "Republic_of_Korea__the"
    let Republic_of_Moldova = _prefixId.prefix "Republic_of_Moldova"
    let Reunion = _prefixId.prefix "Reunion"
    let Romania = _prefixId.prefix "Romania"
    let Russian_Federation__the = _prefixId.prefix "Russian_Federation__the"
    let Rwanda = _prefixId.prefix "Rwanda"
    let SAARC = _prefixId.prefix "SAARC"
    let SAARC_1985 = _prefixId.prefix "SAARC_1985"
    let SADC = _prefixId.prefix "SADC"
    let SIDS = _prefixId.prefix "SIDS"
    let Saint_Martin = _prefixId.prefix "Saint-Martin"
    let Saint_Barthelemy = _prefixId.prefix "Saint_Barthelemy"
    let Saint_Helena = _prefixId.prefix "Saint_Helena"
    let Saint_Kitts_and_Nevis = _prefixId.prefix "Saint_Kitts_and_Nevis"
    let Saint_Lucia = _prefixId.prefix "Saint_Lucia"
    let Saint_Pierre_and_Miquelon = _prefixId.prefix "Saint_Pierre_and_Miquelon"

    let Saint_Vincent_and_the_Grenadines = _prefixId.prefix "Saint_Vincent_and_the_Grenadines"

    let Samoa = _prefixId.prefix "Samoa"
    let San_Marino = _prefixId.prefix "San_Marino"
    let Sao_Tome_and_Principe = _prefixId.prefix "Sao_Tome_and_Principe"
    let Saudi_Arabia = _prefixId.prefix "Saudi_Arabia"
    let Senegal = _prefixId.prefix "Senegal"
    let Serbia = _prefixId.prefix "Serbia"
    let Serbia_and_Montenegro = _prefixId.prefix "Serbia_and_Montenegro"
    let Seychelles = _prefixId.prefix "Seychelles"
    let Sierra_Leone = _prefixId.prefix "Sierra_Leone"
    let Singapore = _prefixId.prefix "Singapore"
    let Sint_Maarten = _prefixId.prefix "Sint_Maarten"
    let Slovakia = _prefixId.prefix "Slovakia"
    let Slovenia = _prefixId.prefix "Slovenia"

    let Socialist_Federal_Republic_of_Yugoslavia_the = _prefixId.prefix "Socialist_Federal_Republic_of_Yugoslavia_the"

    let Solomon_Islands = _prefixId.prefix "Solomon_Islands"
    let Somalia = _prefixId.prefix "Somalia"
    let South_Africa = _prefixId.prefix "South_Africa"
    let South_America = _prefixId.prefix "South_America"
    let South_Sudan = _prefixId.prefix "South_Sudan"
    let Spain = _prefixId.prefix "Spain"
    let Sri_Lanka = _prefixId.prefix "Sri_Lanka"
    let Sudan_the = _prefixId.prefix "Sudan_the"
    let Sudan_the_1956 = _prefixId.prefix "Sudan_the_1956"
    let Suriname = _prefixId.prefix "Suriname"
    let Swaziland = _prefixId.prefix "Swaziland"
    let Sweden = _prefixId.prefix "Sweden"
    let Switzerland = _prefixId.prefix "Switzerland"
    let Syrian_Arab_Republic_the = _prefixId.prefix "Syrian_Arab_Republic_the"
    let Tajikistan = _prefixId.prefix "Tajikistan"
    let Thailand = _prefixId.prefix "Thailand"

    let The_former_Yugoslav_Republic_of_Macedonia = _prefixId.prefix "The_former_Yugoslav_Republic_of_Macedonia"

    let Timor_Leste = _prefixId.prefix "Timor-Leste"
    let Togo = _prefixId.prefix "Togo"
    let Tokelau = _prefixId.prefix "Tokelau"
    let Tonga = _prefixId.prefix "Tonga"
    let Trinidad_and_Tobago = _prefixId.prefix "Trinidad_and_Tobago"
    let Tunisia = _prefixId.prefix "Tunisia"
    let Turkey = _prefixId.prefix "Turkey"
    let Turkmenistan = _prefixId.prefix "Turkmenistan"
    let Turks_and_Caicos_Islands = _prefixId.prefix "Turks_and_Caicos_Islands"
    let Tuvalu = _prefixId.prefix "Tuvalu"
    let UEMOA = _prefixId.prefix "UEMOA"
    let Uganda = _prefixId.prefix "Uganda"
    let Ukraine = _prefixId.prefix "Ukraine"

    let Union_of_Soviet_Socialist_Republic_the = _prefixId.prefix "Union_of_Soviet_Socialist_Republic_the"

    let United_Arab_Emirates__the = _prefixId.prefix "United_Arab_Emirates__the"

    let United_Kingdom_of_Great_Britain_and_Northern_Ireland__the = _prefixId.prefix "United_Kingdom_of_Great_Britain_and_Northern_Ireland__the"

    let United_Republic_of_Tanzania__the = _prefixId.prefix "United_Republic_of_Tanzania__the"

    let United_States_Virgin_Islands = _prefixId.prefix "United_States_Virgin_Islands"
    let United_States_of_America = _prefixId.prefix "United_States_of_America"
    let Uruguay = _prefixId.prefix "Uruguay"
    let Uzbekistan = _prefixId.prefix "Uzbekistan"
    let Vanuatu = _prefixId.prefix "Vanuatu"
    let Venezuela = _prefixId.prefix "Venezuela"
    let Viet_Nam = _prefixId.prefix "Viet_Nam"
    let Wallis_and_Futuna_Is = _prefixId.prefix "Wallis_and_Futuna_Is"
    let World = _prefixId.prefix "World"
    let Yemen = _prefixId.prefix "Yemen"
    let Yemen_1990 = _prefixId.prefix "Yemen_1990"
    let Yugoslavia = _prefixId.prefix "Yugoslavia"
    let Zaire = _prefixId.prefix "Zaire"
    let Zambia = _prefixId.prefix "Zambia"
    let Zimbabwe = _prefixId.prefix "Zimbabwe"
    /// <summary>
    ///   <para>geop:sourceIdentifier : http://faostat.fao.org/DesktopDefault.aspx?PageID=377&amp;lang=en#ancorgeop:sourceIdentifier : http://faostat.fao.org/DesktopDefault.aspx?PageID=377&amp;lang=en#ancor^^xsd:stringgeop:sourceIdentifier : http://faostat.fao.org/DesktopDefault.aspx?PageID=377&amp;lang=fr#ancorgeop:sourceIdentifier : http://faostat.fao.org/DesktopDefault.aspx?PageID=377&amp;lang=es#ancor</para>
    ///   <para>geop:sourceCreator : FAOSTAT^^xsd:string</para>
    ///   <para>dcterms:source : FAOSTAT http://faostat.fao.org/DesktopDefault.aspx?PageID=377&amp;lang=en#ancor^^xsd:string</para>
    ///   <para>geop:sourceModified : 2010-07-21^^xsd:string</para>
    ///   <para>dcterms:description : Agricultural area, this category is the sum of areas under a) arable land - land under temporary agricultural crops (multiple-cropped areas are counted only once), temporary meadows for mowing or pasture, land under market and kitchen gardens and land temporarily fallow (less than five years). The abandoned land resulting from shifting cultivation is not included in this category. Data for “Arable land” are not meant to indicate the amount of land that is potentially cultivable; (b) permanent crops - land cultivated with long-term crops which do not have to be replanted for several years (such as cocoa and coffee); land under trees and shrubs producing flowers, such as roses and jasmine; and nurseries (except those for forest trees, which should be classified under "forest"); and (c) permanent meadows and pastures - land used permanently (five years or more) to grow herbaceous forage crops, either cultivated or growing wild (wild prairie or grazing land). Data are expressed in 1000 hectares. http://faostat.fao.org/site/375/default.aspx ^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#agriculturalArea">geop:agriculturalArea</a>
    /// </summary>
    let agriculturalArea = _prefixId.prefix "agriculturalArea"
    let agriculturalAreaNotes = _prefixId.prefix "agriculturalAreaNotes"
    let agriculturalAreaTotal = _prefixId.prefix "agriculturalAreaTotal"
    let agriculturalAreaUnit = _prefixId.prefix "agriculturalAreaUnit"
    let agriculturalAreaYear = _prefixId.prefix "agriculturalAreaYear"
    let area = _prefixId.prefix "area"
    let central_America = _prefixId.prefix "central_America"
    let central_Asia = _prefixId.prefix "central_Asia"
    /// <summary>
    ///   <para>geop:sourceCreator : AGROVOC^^xsd:string</para>
    ///   <para>geop:sourceIdentifier : http://aims.fao.org/fr/website/Search-AGROVOC/subgeop:sourceIdentifier : http://aims.fao.org/zh-hans/website/Search-AGROVOC/subgeop:sourceIdentifier : http://aims.fao.org/ar/website/Search-AGROVOC/subgeop:sourceIdentifier : http://aims.fao.org/es/website/Search-AGROVOC/subgeop:sourceIdentifier : http://aims.fao.org/website/Search-AGROVOC/sub</para>
    ///   <para>dcterms:source : AGROVOC http://aims.fao.org/website/Search-AGROVOC/sub^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#codeAGROVOC">geop:codeAGROVOC</a>
    /// </summary>
    let codeAGROVOC = _prefixId.prefix "codeAGROVOC"
    /// <summary>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/termportal/en/^^xsd:stringgeop:sourceIdentifier : http://www.fao.org/termportal/contr/ar/geop:sourceIdentifier : http://www.fao.org/termportal/contr/es/geop:sourceIdentifier : http://www.fao.org/termportal/contr/en/geop:sourceIdentifier : http://www.fao.org/termportal/contr/fr/geop:sourceIdentifier : http://www.fao.org/termportal/contr/zh/</para>
    ///   <para>geop:sourceCreator : FAO terminology^^xsd:string</para>
    ///   <para>geop:sourceModified : 2010-06-24^^xsd:string</para>
    ///   <para>dcterms:source : FAO terminology http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#codeCurrency">geop:codeCurrency</a>
    /// </summary>
    let codeCurrency = _prefixId.prefix "codeCurrency"
    /// <summary>
    ///   <para>dcterms:source : DBpedia http://dbpedia.org/About^^xsd:string</para>
    ///   <para>geop:sourceModified : 2010-04-28^^xsd:string</para>
    ///   <para>geop:sourceIdentifier : http://dbpedia.org/About</para>
    ///   <para>geop:sourceCreator : DBpedia^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#codeDBPediaID">geop:codeDBPediaID</a>
    /// </summary>
    let codeDBPediaID = _prefixId.prefix "codeDBPediaID"
    /// <summary>
    ///   <para>dcterms:source : FAOSTAT http://faostat.fao.org^^xsd:string</para>
    ///   <para>geop:sourceIdentifier : http://faostat.fao.orggeop:sourceIdentifier : http://faostat.fao.org/default.aspx?lang=esgeop:sourceIdentifier : http://faostat.fao.org/default.aspx?lang=fr</para>
    ///   <para>geop:sourceCreator : FAOSTAT^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#codeFAOSTAT">geop:codeFAOSTAT</a>
    /// </summary>
    let codeFAOSTAT = _prefixId.prefix "codeFAOSTAT"
    /// <summary>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/termportal/contr/ar/geop:sourceIdentifier : http://www.fao.org/termportal/contr/fr/geop:sourceIdentifier : http://www.fao.org/termportal/contr/zh/geop:sourceIdentifier : http://www.fao.org/termportal/contr/en/geop:sourceIdentifier : http://www.fao.org/termportal/en/^^xsd:stringgeop:sourceIdentifier : http://www.fao.org/termportal/contr/es/</para>
    ///   <para>dcterms:source : FAO terminology http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <para>geop:sourceCreator : FAO terminology^^xsd:string</para>
    ///   <para>geop:sourceModified : 2010-06-24^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#codeFAOTERM">geop:codeFAOTERM</a>
    /// </summary>
    let codeFAOTERM = _prefixId.prefix "codeFAOTERM"
    /// <summary>
    ///   <para>dcterms:source : Global Administrative Unit Layers http://www.fao.org/geonetwork/srv/en/metadata.show?id=12691^^xsd:string</para>
    ///   <para>geop:sourceModified : 2008-12-10^^xsd:string</para>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/geonetwork/srv/en/metadata.show?id=12691^^xsd:string</para>
    ///   <para>geop:sourceCreator : Global Administrative Unit Layers^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#codeGAUL">geop:codeGAUL</a>
    /// </summary>
    let codeGAUL = _prefixId.prefix "codeGAUL"
    /// <summary>
    ///   <para>dcterms:source : ISO 3166-1 http://www.iso.org/iso/country_codes/iso_3166_code_lists.htm^^xsd:string</para>
    ///   <para>geop:sourceIdentifier : http://www.iso.org/iso/country_codes/iso_3166_code_lists.htm^^xsd:string</para>
    ///   <para>geop:sourceCreator : ISO 3166-1^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#codeISO2">geop:codeISO2</a>
    /// </summary>
    let codeISO2 = _prefixId.prefix "codeISO2"
    /// <summary>
    ///   <para>dcterms:source : United Nations Statistics Division http://unstats.un.org/unsd/methods/m49/m49alpha.htm^^xsd:string</para>
    ///   <para>geop:sourceModified : 2010-04-01^^xsd:string</para>
    ///   <para>geop:sourceIdentifier : http://unstats.un.org/unsd/methods/m49/m49alpha.htmgeop:sourceIdentifier : http://unstats.un.org/unsd/methods/m49/m49alphaf.htm</para>
    ///   <para>geop:sourceCreator : United Nations Statistics Division^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#codeISO3">geop:codeISO3</a>
    /// </summary>
    let codeISO3 = _prefixId.prefix "codeISO3"
    /// <summary>
    ///   <para>dcterms:source : United Nations Statistics Division http://unstats.un.org/unsd/methods/m49/m49alpha.htm^^xsd:string</para>
    ///   <para>geop:sourceModified : 2010-04-01^^xsd:string</para>
    ///   <para>geop:sourceIdentifier : http://unstats.un.org/unsd/methods/m49/m49alpha.htmgeop:sourceIdentifier : http://unstats.un.org/unsd/methods/m49/m49alphaf.htm</para>
    ///   <para>geop:sourceCreator : United Nations Statistics Division^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#codeUN">geop:codeUN</a>
    /// </summary>
    let codeUN = _prefixId.prefix "codeUN"
    let codeUNDP = _prefixId.prefix "codeUNDP"
    /// <summary>
    ///   <para>geop:sourceIdentifier : http://faostat.fao.org/DesktopDefault.aspx?PageID=377&amp;lang=fr#ancorgeop:sourceIdentifier : http://faostat.fao.org/DesktopDefault.aspx?PageID=377&amp;lang=es#ancorgeop:sourceIdentifier : http://faostat.fao.org/DesktopDefault.aspx?PageID=377&amp;lang=en#ancorgeop:sourceIdentifier : http://faostat.fao.org/DesktopDefault.aspx?PageID=377&amp;lang=en#ancor^^xsd:string</para>
    ///   <para>geop:sourceModified : 2011-07-21^^xsd:string</para>
    ///   <para>dcterms:description : Country area, area of the country including area under inland water bodies, but excluding offshore territorial waters. Possible variations in the data may be due to updating and revisions of the country data and not necessarily to any change of area. Data are expressed in 1000 hectares. http://faostat.fao.org/site/375/default.aspx ^^xsd:string</para>
    ///   <para>dcterms:source : FAOSTAT http://faostat.fao.org/DesktopDefault.aspx?PageID=377&amp;lang=en#ancor^^xsd:string</para>
    ///   <para>geop:sourceCreator : FAOSTAT^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#countryArea">geop:countryArea</a>
    /// </summary>
    let countryArea = _prefixId.prefix "countryArea"
    let countryAreaNotes = _prefixId.prefix "countryAreaNotes"
    let countryAreaTotal = _prefixId.prefix "countryAreaTotal"
    let countryAreaUnit = _prefixId.prefix "countryAreaUnit"
    let countryAreaYear = _prefixId.prefix "countryAreaYear"
    let disputed = _prefixId.prefix "disputed"
    let eastern_Africa = _prefixId.prefix "eastern_Africa"
    let eastern_Asia = _prefixId.prefix "eastern_Asia"
    let eastern_Europe = _prefixId.prefix "eastern_Europe"
    let economic_region = _prefixId.prefix "economic_region"
    /// <summary>
    ///   <para>geop:sourceCreator : United Nations statistics department^^xsd:string</para>
    ///   <para>geop:sourceIdentifier : http://unstats.un.org/unsd/methods/m49/m49regin.htm^^xsd:stringgeop:sourceIdentifier : http://unstats.un.org/unsd/methods/m49/m49regnf.htm</para>
    ///   <para>geop:sourceModified : 2010-04-01^^xsd:string</para>
    ///   <para>dcterms:source : United Nations statistics department http://unstats.un.org/unsd/methods/m49/m49regin.htm^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#geographical_region">geop:geographical_region</a>
    /// </summary>
    let geographical_region = _prefixId.prefix "geographical_region"
    let group = _prefixId.prefix "group"
    /// <summary>
    ///   <para>dcterms:source : United Nations cartographic maps http://www.un.org/Depts/Cartographic/map/profile/world00.pdf^^xsd:string</para>
    ///   <para>geop:sourceModified : 2010-05-01^^xsd:string</para>
    ///   <para>geop:sourceIdentifier : http://www.un.org/Depts/Cartographic/map/profile/world00.pdf^^xsd:string</para>
    ///   <para>geop:sourceCreator : United Nations cartographic maps^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#hasBorderWith">geop:hasBorderWith</a>
    /// </summary>
    let hasBorderWith = _prefixId.prefix "hasBorderWith"
    let hasCode = _prefixId.prefix "hasCode"
    let hasCoordinate = _prefixId.prefix "hasCoordinate"
    let hasCurrency = _prefixId.prefix "hasCurrency"
    let hasListName = _prefixId.prefix "hasListName"
    let hasMaxLatitude = _prefixId.prefix "hasMaxLatitude"
    let hasMaxLongitude = _prefixId.prefix "hasMaxLongitude"
    let hasMember = _prefixId.prefix "hasMember"
    let hasMinLatitude = _prefixId.prefix "hasMinLatitude"
    let hasMinLongitude = _prefixId.prefix "hasMinLongitude"
    let hasNationality = _prefixId.prefix "hasNationality"
    let hasOfficialName = _prefixId.prefix "hasOfficialName"
    let hasShortName = _prefixId.prefix "hasShortName"
    let hasStatistics = _prefixId.prefix "hasStatistics"
    /// <summary>
    ///   <para>dcterms:source : United Nations cartographic maps http://www.un.org/Depts/Cartographic/map/profile/world00.pdf^^xsd:string</para>
    ///   <para>geop:sourceModified : 2010-05-01^^xsd:string</para>
    ///   <para>geop:sourceIdentifier : http://www.un.org/Depts/Cartographic/map/profile/world00.pdf</para>
    ///   <para>geop:sourceCreator : United Nations cartographic maps^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#isAdministeredBy">geop:isAdministeredBy</a>
    /// </summary>
    let isAdministeredBy = _prefixId.prefix "isAdministeredBy"
    let isInGroup = _prefixId.prefix "isInGroup"
    /// <summary>
    ///   <para>geop:sourceIdentifier : http://unstats.un.org/unsd/methods/m49/m49chgef.htmgeop:sourceIdentifier : http://unstats.un.org/unsd/methods/m49/m49chang.htm</para>
    ///   <para>geop:sourceCreator : United Nations Statistics Division^^xsd:string</para>
    ///   <para>geop:sourceModified : 2010-04-15^^xsd:string</para>
    ///   <para>dcterms:source : United Nations Statistics Division http://unstats.un.org/unsd/methods/m49/m49chang.htm^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#isPredecessorOf">geop:isPredecessorOf</a>
    /// </summary>
    let isPredecessorOf = _prefixId.prefix "isPredecessorOf"
    /// <summary>
    ///   <para>geop:sourceCreator : United Nations Statistics Division^^xsd:string</para>
    ///   <para>dcterms:source : United Nations Statistics Division http://unstats.un.org/unsd/methods/m49/m49chang.htm^^xsd:string</para>
    ///   <para>geop:sourceIdentifier : http://unstats.un.org/unsd/methods/m49/m49chang.htmgeop:sourceIdentifier : http://unstats.un.org/unsd/methods/m49/m49chgef.htm</para>
    ///   <para>geop:sourceModified : 2010-04-15^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#isSuccessorOf">geop:isSuccessorOf</a>
    /// </summary>
    let isSuccessorOf = _prefixId.prefix "isSuccessorOf"
    /// <summary>
    ///   <para>geop:sourceCreator : FAOSTAT^^xsd:string</para>
    ///   <para>geop:sourceModified : 2011-07-21^^xsd:string</para>
    ///   <para>dcterms:source : FAOSTAT http://faostat.fao.org/DesktopDefault.aspx?PageID=377&amp;lang=en#ancor^^xsd:string</para>
    ///   <para>geop:sourceIdentifier : http://faostat.fao.org/DesktopDefault.aspx?PageID=377&amp;lang=en#ancorgeop:sourceIdentifier : http://faostat.fao.org/DesktopDefault.aspx?PageID=377&amp;lang=en#ancor^^xsd:stringgeop:sourceIdentifier : http://faostat.fao.org/DesktopDefault.aspx?PageID=377&amp;lang=es#ancorgeop:sourceIdentifier : http://faostat.fao.org/DesktopDefault.aspx?PageID=377&amp;lang=fr#ancor</para>
    ///   <para>dcterms:description : Land area is the total area of the country excluding area under inland water bodies. Possible variations in the data may be due to updating and revisions of the country data and not necessarily to any change of area. Data are expressed in 1 000 hectares. http://faostat.fao.org/site/375/default.aspx ^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#landArea">geop:landArea</a>
    /// </summary>
    let landArea = _prefixId.prefix "landArea"
    let landAreaNotes = _prefixId.prefix "landAreaNotes"
    let landAreaTotal = _prefixId.prefix "landAreaTotal"
    let landAreaUnit = _prefixId.prefix "landAreaUnit"
    let landAreaYear = _prefixId.prefix "landAreaYear"
    let middle_Africa = _prefixId.prefix "middle_Africa"
    /// <summary>
    ///   <para>geop:sourceModified : 2010-06-24^^xsd:string</para>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/termportal/contr/fr/geop:sourceIdentifier : http://www.fao.org/termportal/contr/es/geop:sourceIdentifier : http://www.fao.org/termportal/contr/zh/geop:sourceIdentifier : http://www.fao.org/termportal/en/^^xsd:stringgeop:sourceIdentifier : http://www.fao.org/termportal/contr/en/geop:sourceIdentifier : http://www.fao.org/termportal/contr/ar/</para>
    ///   <para>dcterms:source : FAO terminology http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <para>geop:sourceCreator : FAO terminology^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#nameCurrencyAR">geop:nameCurrencyAR</a>
    /// </summary>
    let nameCurrencyAR = _prefixId.prefix "nameCurrencyAR"
    /// <summary>
    ///   <para>dcterms:source : FAO terminology http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/termportal/contr/es/geop:sourceIdentifier : http://www.fao.org/termportal/contr/en/geop:sourceIdentifier : http://www.fao.org/termportal/contr/zh/geop:sourceIdentifier : http://www.fao.org/termportal/contr/ar/geop:sourceIdentifier : http://www.fao.org/termportal/en/^^xsd:stringgeop:sourceIdentifier : http://www.fao.org/termportal/contr/fr/</para>
    ///   <para>geop:sourceCreator : FAO terminology^^xsd:string</para>
    ///   <para>geop:sourceModified : 2010-06-24^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#nameCurrencyEN">geop:nameCurrencyEN</a>
    /// </summary>
    let nameCurrencyEN = _prefixId.prefix "nameCurrencyEN"
    /// <summary>
    ///   <para>geop:sourceModified : 2010-06-24^^xsd:string</para>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/termportal/contr/fr/geop:sourceIdentifier : http://www.fao.org/termportal/contr/en/geop:sourceIdentifier : http://www.fao.org/termportal/contr/es/geop:sourceIdentifier : http://www.fao.org/termportal/en/^^xsd:stringgeop:sourceIdentifier : http://www.fao.org/termportal/contr/zh/geop:sourceIdentifier : http://www.fao.org/termportal/contr/ar/</para>
    ///   <para>dcterms:source : FAO terminology http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <para>geop:sourceCreator : FAO terminology^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#nameCurrencyES">geop:nameCurrencyES</a>
    /// </summary>
    let nameCurrencyES = _prefixId.prefix "nameCurrencyES"
    /// <summary>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/termportal/contr/zh/geop:sourceIdentifier : http://www.fao.org/termportal/contr/es/geop:sourceIdentifier : http://www.fao.org/termportal/contr/ar/geop:sourceIdentifier : http://www.fao.org/termportal/en/^^xsd:stringgeop:sourceIdentifier : http://www.fao.org/termportal/contr/fr/geop:sourceIdentifier : http://www.fao.org/termportal/contr/en/</para>
    ///   <para>geop:sourceCreator : FAO terminology^^xsd:string</para>
    ///   <para>dcterms:source : FAO terminology http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <para>geop:sourceModified : 2010-06-24^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#nameCurrencyFR">geop:nameCurrencyFR</a>
    /// </summary>
    let nameCurrencyFR = _prefixId.prefix "nameCurrencyFR"
    /// <summary>
    ///   <para>dcterms:source : FAO terminology http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <para>geop:sourceModified : 2010-06-24^^xsd:string</para>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/termportal/contr/es/geop:sourceIdentifier : http://www.fao.org/termportal/contr/fr/geop:sourceIdentifier : http://www.fao.org/termportal/contr/zh/geop:sourceIdentifier : http://www.fao.org/termportal/contr/en/geop:sourceIdentifier : http://www.fao.org/termportal/en/^^xsd:stringgeop:sourceIdentifier : http://www.fao.org/termportal/contr/ar/</para>
    ///   <para>geop:sourceCreator : FAO terminology^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#nameCurrencyIT">geop:nameCurrencyIT</a>
    /// </summary>
    let nameCurrencyIT = _prefixId.prefix "nameCurrencyIT"
    /// <summary>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/termportal/contr/es/geop:sourceIdentifier : http://www.fao.org/termportal/contr/zh/geop:sourceIdentifier : http://www.fao.org/termportal/contr/fr/geop:sourceIdentifier : http://www.fao.org/termportal/contr/ar/geop:sourceIdentifier : http://www.fao.org/termportal/en/^^xsd:stringgeop:sourceIdentifier : http://www.fao.org/termportal/contr/en/</para>
    ///   <para>geop:sourceModified : 2010-06-24^^xsd:string</para>
    ///   <para>geop:sourceCreator : FAO terminology^^xsd:string</para>
    ///   <para>dcterms:source : FAO terminology http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#nameCurrencyRU">geop:nameCurrencyRU</a>
    /// </summary>
    let nameCurrencyRU = _prefixId.prefix "nameCurrencyRU"
    /// <summary>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/termportal/contr/ar/geop:sourceIdentifier : http://www.fao.org/termportal/contr/fr/geop:sourceIdentifier : http://www.fao.org/termportal/contr/es/geop:sourceIdentifier : http://www.fao.org/termportal/contr/zh/geop:sourceIdentifier : http://www.fao.org/termportal/contr/en/geop:sourceIdentifier : http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <para>dcterms:source : FAO terminology http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <para>geop:sourceModified : 2010-06-24^^xsd:string</para>
    ///   <para>geop:sourceCreator : FAO terminology^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#nameCurrencyZH">geop:nameCurrencyZH</a>
    /// </summary>
    let nameCurrencyZH = _prefixId.prefix "nameCurrencyZH"
    /// <summary>
    ///   <para>geop:sourceCreator : FAO terminology^^xsd:string</para>
    ///   <para>geop:sourceModified : 2010-06-24^^xsd:string</para>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/termportal/en/^^xsd:stringgeop:sourceIdentifier : http://www.fao.org/termportal/contr/en/geop:sourceIdentifier : http://www.fao.org/termportal/contr/ar/geop:sourceIdentifier : http://www.fao.org/termportal/contr/es/geop:sourceIdentifier : http://www.fao.org/termportal/contr/zh/geop:sourceIdentifier : http://www.fao.org/termportal/contr/fr/</para>
    ///   <para>dcterms:source : FAO terminology http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#nameListAR">geop:nameListAR</a>
    /// </summary>
    let nameListAR = _prefixId.prefix "nameListAR"
    /// <summary>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/termportal/contr/es/geop:sourceIdentifier : http://www.fao.org/termportal/contr/zh/geop:sourceIdentifier : http://www.fao.org/termportal/contr/en/geop:sourceIdentifier : http://www.fao.org/termportal/contr/ar/geop:sourceIdentifier : http://www.fao.org/termportal/en/^^xsd:stringgeop:sourceIdentifier : http://www.fao.org/termportal/contr/fr/</para>
    ///   <para>geop:sourceCreator : FAO terminology^^xsd:string</para>
    ///   <para>geop:sourceModified : 2010-06-24^^xsd:string</para>
    ///   <para>dcterms:source : FAO terminology http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#nameListEN">geop:nameListEN</a>
    /// </summary>
    let nameListEN = _prefixId.prefix "nameListEN"
    /// <summary>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/termportal/contr/ar/geop:sourceIdentifier : http://www.fao.org/termportal/contr/es/geop:sourceIdentifier : http://www.fao.org/termportal/contr/zh/geop:sourceIdentifier : http://www.fao.org/termportal/contr/en/geop:sourceIdentifier : http://www.fao.org/termportal/en/^^xsd:stringgeop:sourceIdentifier : http://www.fao.org/termportal/contr/fr/</para>
    ///   <para>dcterms:source : FAO terminology http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <para>geop:sourceCreator : FAO terminology^^xsd:string</para>
    ///   <para>geop:sourceModified : 2010-06-24^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#nameListES">geop:nameListES</a>
    /// </summary>
    let nameListES = _prefixId.prefix "nameListES"
    /// <summary>
    ///   <para>dcterms:source : FAO terminology http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/termportal/en/^^xsd:stringgeop:sourceIdentifier : http://www.fao.org/termportal/contr/ar/geop:sourceIdentifier : http://www.fao.org/termportal/contr/fr/geop:sourceIdentifier : http://www.fao.org/termportal/contr/es/geop:sourceIdentifier : http://www.fao.org/termportal/contr/en/geop:sourceIdentifier : http://www.fao.org/termportal/contr/zh/</para>
    ///   <para>geop:sourceModified : 2010-06-24^^xsd:string</para>
    ///   <para>geop:sourceCreator : FAO terminology^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#nameListFR">geop:nameListFR</a>
    /// </summary>
    let nameListFR = _prefixId.prefix "nameListFR"
    /// <summary>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/termportal/en/^^xsd:stringgeop:sourceIdentifier : http://www.fao.org/termportal/contr/fr/geop:sourceIdentifier : http://www.fao.org/termportal/contr/es/geop:sourceIdentifier : http://www.fao.org/termportal/contr/ar/geop:sourceIdentifier : http://www.fao.org/termportal/contr/en/geop:sourceIdentifier : http://www.fao.org/termportal/contr/zh/</para>
    ///   <para>dcterms:source : FAO terminology http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <para>geop:sourceCreator : FAO terminology^^xsd:string</para>
    ///   <para>geop:sourceModified : 2010-06-24^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#nameListIT">geop:nameListIT</a>
    /// </summary>
    let nameListIT = _prefixId.prefix "nameListIT"
    /// <summary>
    ///   <para>geop:sourceModified : 2010-06-24^^xsd:string</para>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/termportal/en/^^xsd:stringgeop:sourceIdentifier : http://www.fao.org/termportal/contr/ar/geop:sourceIdentifier : http://www.fao.org/termportal/contr/en/geop:sourceIdentifier : http://www.fao.org/termportal/contr/es/geop:sourceIdentifier : http://www.fao.org/termportal/contr/fr/geop:sourceIdentifier : http://www.fao.org/termportal/contr/zh/</para>
    ///   <para>geop:sourceCreator : FAO terminology^^xsd:string</para>
    ///   <para>dcterms:source : FAO terminology http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#nameListRU">geop:nameListRU</a>
    /// </summary>
    let nameListRU = _prefixId.prefix "nameListRU"
    /// <summary>
    ///   <para>dcterms:source : FAO terminology http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/termportal/contr/ar/geop:sourceIdentifier : http://www.fao.org/termportal/en/^^xsd:stringgeop:sourceIdentifier : http://www.fao.org/termportal/contr/fr/geop:sourceIdentifier : http://www.fao.org/termportal/contr/en/geop:sourceIdentifier : http://www.fao.org/termportal/contr/zh/geop:sourceIdentifier : http://www.fao.org/termportal/contr/es/</para>
    ///   <para>geop:sourceCreator : FAO terminology^^xsd:string</para>
    ///   <para>geop:sourceModified : 2010-06-24^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#nameListZH">geop:nameListZH</a>
    /// </summary>
    let nameListZH = _prefixId.prefix "nameListZH"
    /// <summary>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/termportal/contr/fr/geop:sourceIdentifier : http://www.fao.org/termportal/contr/es/geop:sourceIdentifier : http://www.fao.org/termportal/contr/ar/geop:sourceIdentifier : http://www.fao.org/termportal/en/^^xsd:stringgeop:sourceIdentifier : http://www.fao.org/termportal/contr/en/geop:sourceIdentifier : http://www.fao.org/termportal/contr/zh/</para>
    ///   <para>geop:sourceCreator : FAO terminology^^xsd:string</para>
    ///   <para>dcterms:source : FAO terminology http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <para>geop:sourceModified : 2010-06-24^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#nameOfficialAR">geop:nameOfficialAR</a>
    /// </summary>
    let nameOfficialAR = _prefixId.prefix "nameOfficialAR"
    /// <summary>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/termportal/contr/ar/geop:sourceIdentifier : http://www.fao.org/termportal/en/^^xsd:stringgeop:sourceIdentifier : http://www.fao.org/termportal/contr/en/geop:sourceIdentifier : http://www.fao.org/termportal/contr/es/geop:sourceIdentifier : http://www.fao.org/termportal/contr/fr/geop:sourceIdentifier : http://www.fao.org/termportal/contr/zh/</para>
    ///   <para>dcterms:source : FAO terminology http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <para>geop:sourceModified : 2010-06-24^^xsd:string</para>
    ///   <para>geop:sourceCreator : FAO terminology^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#nameOfficialEN">geop:nameOfficialEN</a>
    /// </summary>
    let nameOfficialEN = _prefixId.prefix "nameOfficialEN"
    /// <summary>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/termportal/contr/es/geop:sourceIdentifier : http://www.fao.org/termportal/contr/fr/geop:sourceIdentifier : http://www.fao.org/termportal/contr/en/geop:sourceIdentifier : http://www.fao.org/termportal/contr/ar/geop:sourceIdentifier : http://www.fao.org/termportal/contr/zh/geop:sourceIdentifier : http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <para>geop:sourceCreator : FAO terminology^^xsd:string</para>
    ///   <para>dcterms:source : FAO terminology http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <para>geop:sourceModified : 2010-06-24^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#nameOfficialES">geop:nameOfficialES</a>
    /// </summary>
    let nameOfficialES = _prefixId.prefix "nameOfficialES"
    /// <summary>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/termportal/en/^^xsd:stringgeop:sourceIdentifier : http://www.fao.org/termportal/contr/es/geop:sourceIdentifier : http://www.fao.org/termportal/contr/zh/geop:sourceIdentifier : http://www.fao.org/termportal/contr/ar/geop:sourceIdentifier : http://www.fao.org/termportal/contr/en/geop:sourceIdentifier : http://www.fao.org/termportal/contr/fr/</para>
    ///   <para>geop:sourceModified : 2010-06-24^^xsd:string</para>
    ///   <para>dcterms:source : FAO terminology http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <para>geop:sourceCreator : FAO terminology^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#nameOfficialFR">geop:nameOfficialFR</a>
    /// </summary>
    let nameOfficialFR = _prefixId.prefix "nameOfficialFR"
    /// <summary>
    ///   <para>geop:sourceModified : 2010-06-24^^xsd:string</para>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/termportal/en/^^xsd:stringgeop:sourceIdentifier : http://www.fao.org/termportal/contr/en/geop:sourceIdentifier : http://www.fao.org/termportal/contr/fr/geop:sourceIdentifier : http://www.fao.org/termportal/contr/zh/geop:sourceIdentifier : http://www.fao.org/termportal/contr/es/geop:sourceIdentifier : http://www.fao.org/termportal/contr/ar/</para>
    ///   <para>geop:sourceCreator : FAO terminology^^xsd:string</para>
    ///   <para>dcterms:source : FAO terminology http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#nameOfficialIT">geop:nameOfficialIT</a>
    /// </summary>
    let nameOfficialIT = _prefixId.prefix "nameOfficialIT"
    /// <summary>
    ///   <para>dcterms:source : FAO terminology http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/termportal/contr/zh/geop:sourceIdentifier : http://www.fao.org/termportal/en/^^xsd:stringgeop:sourceIdentifier : http://www.fao.org/termportal/contr/en/geop:sourceIdentifier : http://www.fao.org/termportal/contr/fr/geop:sourceIdentifier : http://www.fao.org/termportal/contr/es/geop:sourceIdentifier : http://www.fao.org/termportal/contr/ar/</para>
    ///   <para>geop:sourceCreator : FAO terminology^^xsd:string</para>
    ///   <para>geop:sourceModified : 2010-06-24^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#nameOfficialRU">geop:nameOfficialRU</a>
    /// </summary>
    let nameOfficialRU = _prefixId.prefix "nameOfficialRU"
    /// <summary>
    ///   <para>geop:sourceModified : 2010-06-24^^xsd:string</para>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/termportal/contr/ar/geop:sourceIdentifier : http://www.fao.org/termportal/contr/fr/geop:sourceIdentifier : http://www.fao.org/termportal/contr/es/geop:sourceIdentifier : http://www.fao.org/termportal/contr/zh/geop:sourceIdentifier : http://www.fao.org/termportal/en/^^xsd:stringgeop:sourceIdentifier : http://www.fao.org/termportal/contr/en/</para>
    ///   <para>geop:sourceCreator : FAO terminology^^xsd:string</para>
    ///   <para>dcterms:source : FAO terminology http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#nameOfficialZH">geop:nameOfficialZH</a>
    /// </summary>
    let nameOfficialZH = _prefixId.prefix "nameOfficialZH"
    /// <summary>
    ///   <para>dcterms:source : FAO terminology http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/termportal/contr/es/geop:sourceIdentifier : http://www.fao.org/termportal/contr/ar/geop:sourceIdentifier : http://www.fao.org/termportal/contr/en/geop:sourceIdentifier : http://www.fao.org/termportal/en/^^xsd:stringgeop:sourceIdentifier : http://www.fao.org/termportal/contr/zh/geop:sourceIdentifier : http://www.fao.org/termportal/contr/fr/</para>
    ///   <para>geop:sourceCreator : FAO terminology^^xsd:string</para>
    ///   <para>geop:sourceModified : 2010-06-24^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#nameShortAR">geop:nameShortAR</a>
    /// </summary>
    let nameShortAR = _prefixId.prefix "nameShortAR"
    /// <summary>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/termportal/contr/fr/geop:sourceIdentifier : http://www.fao.org/termportal/contr/es/geop:sourceIdentifier : http://www.fao.org/termportal/contr/ar/geop:sourceIdentifier : http://www.fao.org/termportal/contr/en/geop:sourceIdentifier : http://www.fao.org/termportal/contr/zh/geop:sourceIdentifier : http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <para>geop:sourceCreator : FAO terminology^^xsd:string</para>
    ///   <para>dcterms:source : FAO terminology http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <para>geop:sourceModified : 2010-06-24^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#nameShortEN">geop:nameShortEN</a>
    /// </summary>
    let nameShortEN = _prefixId.prefix "nameShortEN"
    /// <summary>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/termportal/contr/fr/geop:sourceIdentifier : http://www.fao.org/termportal/en/^^xsd:stringgeop:sourceIdentifier : http://www.fao.org/termportal/contr/en/geop:sourceIdentifier : http://www.fao.org/termportal/contr/es/geop:sourceIdentifier : http://www.fao.org/termportal/contr/zh/geop:sourceIdentifier : http://www.fao.org/termportal/contr/ar/</para>
    ///   <para>geop:sourceCreator : FAO terminology^^xsd:string</para>
    ///   <para>dcterms:source : FAO terminology http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <para>geop:sourceModified : 2010-06-24^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#nameShortES">geop:nameShortES</a>
    /// </summary>
    let nameShortES = _prefixId.prefix "nameShortES"
    /// <summary>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/termportal/contr/fr/geop:sourceIdentifier : http://www.fao.org/termportal/contr/es/geop:sourceIdentifier : http://www.fao.org/termportal/contr/ar/geop:sourceIdentifier : http://www.fao.org/termportal/contr/en/geop:sourceIdentifier : http://www.fao.org/termportal/contr/zh/geop:sourceIdentifier : http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <para>geop:sourceCreator : FAO terminology^^xsd:string</para>
    ///   <para>geop:sourceModified : 2010-06-24^^xsd:string</para>
    ///   <para>dcterms:source : FAO terminology http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#nameShortFR">geop:nameShortFR</a>
    /// </summary>
    let nameShortFR = _prefixId.prefix "nameShortFR"
    /// <summary>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/termportal/contr/zh/geop:sourceIdentifier : http://www.fao.org/termportal/en/^^xsd:stringgeop:sourceIdentifier : http://www.fao.org/termportal/contr/ar/geop:sourceIdentifier : http://www.fao.org/termportal/contr/en/geop:sourceIdentifier : http://www.fao.org/termportal/contr/fr/geop:sourceIdentifier : http://www.fao.org/termportal/contr/es/</para>
    ///   <para>geop:sourceCreator : FAO terminology^^xsd:string</para>
    ///   <para>geop:sourceModified : 2010-06-24^^xsd:string</para>
    ///   <para>dcterms:source : FAO terminology http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#nameShortIT">geop:nameShortIT</a>
    /// </summary>
    let nameShortIT = _prefixId.prefix "nameShortIT"
    /// <summary>
    ///   <para>geop:sourceModified : 2010-06-24^^xsd:string</para>
    ///   <para>geop:sourceCreator : FAO terminology^^xsd:string</para>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/termportal/contr/zh/geop:sourceIdentifier : http://www.fao.org/termportal/contr/fr/geop:sourceIdentifier : http://www.fao.org/termportal/contr/en/geop:sourceIdentifier : http://www.fao.org/termportal/en/^^xsd:stringgeop:sourceIdentifier : http://www.fao.org/termportal/contr/ar/geop:sourceIdentifier : http://www.fao.org/termportal/contr/es/</para>
    ///   <para>dcterms:source : FAO terminology http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#nameShortRU">geop:nameShortRU</a>
    /// </summary>
    let nameShortRU = _prefixId.prefix "nameShortRU"
    /// <summary>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/termportal/contr/zh/geop:sourceIdentifier : http://www.fao.org/termportal/contr/es/geop:sourceIdentifier : http://www.fao.org/termportal/contr/ar/geop:sourceIdentifier : http://www.fao.org/termportal/contr/fr/geop:sourceIdentifier : http://www.fao.org/termportal/contr/en/geop:sourceIdentifier : http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <para>geop:sourceCreator : FAO terminology^^xsd:string</para>
    ///   <para>dcterms:source : FAO terminology http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <para>geop:sourceModified : 2010-06-24^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#nameShortZH">geop:nameShortZH</a>
    /// </summary>
    let nameShortZH = _prefixId.prefix "nameShortZH"
    /// <summary>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/termportal/contr/zh/geop:sourceIdentifier : http://www.fao.org/termportal/contr/en/geop:sourceIdentifier : http://www.fao.org/termportal/contr/fr/geop:sourceIdentifier : http://www.fao.org/termportal/contr/es/geop:sourceIdentifier : http://www.fao.org/termportal/en/^^xsd:stringgeop:sourceIdentifier : http://www.fao.org/termportal/contr/ar/</para>
    ///   <para>dcterms:source : FAO terminology http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <para>geop:sourceCreator : FAO terminology^^xsd:string</para>
    ///   <para>geop:sourceModified : 2010-06-24^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#nationalityAR">geop:nationalityAR</a>
    /// </summary>
    let nationalityAR = _prefixId.prefix "nationalityAR"
    /// <summary>
    ///   <para>dcterms:source : FAO terminology http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/termportal/en/^^xsd:stringgeop:sourceIdentifier : http://www.fao.org/termportal/contr/fr/geop:sourceIdentifier : http://www.fao.org/termportal/contr/en/geop:sourceIdentifier : http://www.fao.org/termportal/contr/zh/geop:sourceIdentifier : http://www.fao.org/termportal/contr/ar/geop:sourceIdentifier : http://www.fao.org/termportal/contr/es/</para>
    ///   <para>geop:sourceCreator : FAO terminology^^xsd:string</para>
    ///   <para>geop:sourceModified : 2010-06-24^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#nationalityEN">geop:nationalityEN</a>
    /// </summary>
    let nationalityEN = _prefixId.prefix "nationalityEN"
    /// <summary>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/termportal/contr/en/geop:sourceIdentifier : http://www.fao.org/termportal/contr/es/geop:sourceIdentifier : http://www.fao.org/termportal/contr/fr/geop:sourceIdentifier : http://www.fao.org/termportal/contr/ar/geop:sourceIdentifier : http://www.fao.org/termportal/contr/zh/geop:sourceIdentifier : http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <para>dcterms:source : FAO terminology http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <para>geop:sourceCreator : FAO terminology^^xsd:string</para>
    ///   <para>geop:sourceModified : 2010-06-24^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#nationalityES">geop:nationalityES</a>
    /// </summary>
    let nationalityES = _prefixId.prefix "nationalityES"
    /// <summary>
    ///   <para>geop:sourceCreator : FAO terminology^^xsd:string</para>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/termportal/contr/es/geop:sourceIdentifier : http://www.fao.org/termportal/contr/zh/geop:sourceIdentifier : http://www.fao.org/termportal/contr/ar/geop:sourceIdentifier : http://www.fao.org/termportal/en/^^xsd:stringgeop:sourceIdentifier : http://www.fao.org/termportal/contr/en/geop:sourceIdentifier : http://www.fao.org/termportal/contr/fr/</para>
    ///   <para>dcterms:source : FAO terminology http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <para>geop:sourceModified : 2010-06-24^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#nationalityFR">geop:nationalityFR</a>
    /// </summary>
    let nationalityFR = _prefixId.prefix "nationalityFR"
    /// <summary>
    ///   <para>geop:sourceCreator : FAO terminology^^xsd:string</para>
    ///   <para>geop:sourceModified : 2010-06-24^^xsd:string</para>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/termportal/contr/es/geop:sourceIdentifier : http://www.fao.org/termportal/en/^^xsd:stringgeop:sourceIdentifier : http://www.fao.org/termportal/contr/en/geop:sourceIdentifier : http://www.fao.org/termportal/contr/fr/geop:sourceIdentifier : http://www.fao.org/termportal/contr/ar/geop:sourceIdentifier : http://www.fao.org/termportal/contr/zh/</para>
    ///   <para>dcterms:source : FAO terminology http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#nationalityIT">geop:nationalityIT</a>
    /// </summary>
    let nationalityIT = _prefixId.prefix "nationalityIT"
    /// <summary>
    ///   <para>geop:sourceCreator : FAO terminology^^xsd:string</para>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/termportal/contr/ar/geop:sourceIdentifier : http://www.fao.org/termportal/contr/en/geop:sourceIdentifier : http://www.fao.org/termportal/contr/es/geop:sourceIdentifier : http://www.fao.org/termportal/contr/fr/geop:sourceIdentifier : http://www.fao.org/termportal/en/^^xsd:stringgeop:sourceIdentifier : http://www.fao.org/termportal/contr/zh/</para>
    ///   <para>dcterms:source : FAO terminology http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <para>geop:sourceModified : 2010-06-24^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#nationalityRU">geop:nationalityRU</a>
    /// </summary>
    let nationalityRU = _prefixId.prefix "nationalityRU"
    /// <summary>
    ///   <para>geop:sourceIdentifier : http://www.fao.org/termportal/contr/fr/geop:sourceIdentifier : http://www.fao.org/termportal/contr/es/geop:sourceIdentifier : http://www.fao.org/termportal/contr/en/geop:sourceIdentifier : http://www.fao.org/termportal/en/^^xsd:stringgeop:sourceIdentifier : http://www.fao.org/termportal/contr/ar/geop:sourceIdentifier : http://www.fao.org/termportal/contr/zh/</para>
    ///   <para>geop:sourceCreator : FAO terminology^^xsd:string</para>
    ///   <para>geop:sourceModified : 2010-06-24^^xsd:string</para>
    ///   <para>dcterms:source : FAO terminology http://www.fao.org/termportal/en/^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#nationalityZH">geop:nationalityZH</a>
    /// </summary>
    let nationalityZH = _prefixId.prefix "nationalityZH"
    /// <summary>
    ///   <para>geop:sourceModified : 2010-05-01^^xsd:string</para>
    ///   <para>geop:sourceCreator : UN Cartographic Section, Department of Field Support^^xsd:string</para>
    ///   <para>geop:sourceIdentifier : http://www.un.org/Depts/Cartographic/map/profile/world00.pdf^^xsd:string</para>
    ///   <para>dcterms:source : UN Cartographic Section, Department of Field Support http://www.un.org/Depts/Cartographic/map/profile/world00.pdf^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#non_self_governing">geop:non_self_governing</a>
    /// </summary>
    let non_self_governing = _prefixId.prefix "non_self_governing"
    let northern_Africa = _prefixId.prefix "northern_Africa"
    let northern_America = _prefixId.prefix "northern_America"
    let northern_Europe = _prefixId.prefix "northern_Europe"
    let organization = _prefixId.prefix "organization"
    let other = _prefixId.prefix "other"
    /// <summary>
    ///   <para>geop:sourceIdentifier : http://faostat.fao.org/DesktopDefault.aspx?PageID=550&amp;lang=en#ancorgeop:sourceIdentifier : http://faostat.fao.org/DesktopDefault.aspx?PageID=550&amp;lang=en#ancor^^xsd:stringgeop:sourceIdentifier : http://faostat.fao.org/DesktopDefault.aspx?PageID=550&amp;lang=es#ancorgeop:sourceIdentifier : http://faostat.fao.org/DesktopDefault.aspx?PageID=550&amp;lang=fr#ancor</para>
    ///   <para>geop:sourceModified : 2012-01-18^^xsd:string</para>
    ///   <para>dcterms:description : The total population usually refers to the present-in-area (de facto) population which includes all persons physically present within the present geographical boundaries of countries at the mid-point of the reference period.  http://faostat.fao.org/site/375/default.aspx^^xsd:string</para>
    ///   <para>geop:sourceCreator : FAOSTAT^^xsd:string</para>
    ///   <para>dcterms:source : FAOSTAT http://faostat.fao.org/site/550/default.aspx^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#population">geop:population</a>
    /// </summary>
    let population = _prefixId.prefix "population"
    let populationNotes = _prefixId.prefix "populationNotes"
    let populationTotal = _prefixId.prefix "populationTotal"
    let populationUnit = _prefixId.prefix "populationUnit"
    let populationYear = _prefixId.prefix "populationYear"
    /// <summary>
    ///   <para>dcterms:source : United Nations Map Library http://www.un.org/depts/dhl/maplib/countinfo.htm^^xsd:string</para>
    ///   <para>geop:sourceModified : 2010-09-08^^xsd:string</para>
    ///   <para>geop:sourceIdentifier : http://www.un.org/depts/dhl/maplib/countinfo.htm</para>
    ///   <para>geop:sourceCreator : United Nations Map Library^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#self_governing">geop:self_governing</a>
    /// </summary>
    let self_governing = _prefixId.prefix "self_governing"
    let sourceCreator = _prefixId.prefix "sourceCreator"
    let sourceIdentifier = _prefixId.prefix "sourceIdentifier"
    let sourceModified = _prefixId.prefix "sourceModified"
    let south_eastern_Asia = _prefixId.prefix "south-eastern_Asia"
    let southern_Africa = _prefixId.prefix "southern_Africa"
    let southern_Asia = _prefixId.prefix "southern_Asia"
    let southern_Europe = _prefixId.prefix "southern_Europe"
    let special_group = _prefixId.prefix "special_group"
    let territory = _prefixId.prefix "territory"
    /// <summary>
    ///   <para>rdfs:comment : The value of the datatype property *validSince* associated to a particular area (territory or group) indicates the area's  first year of validity.  The geopolitical ontology traces back historic changes only until 1985, therefore, if an area has a validSince = 1985, this indicates that the area is/was valid since 1985 or before.       ^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#validSince">geop:validSince</a>
    /// </summary>
    let validSince = _prefixId.prefix "validSince"
    /// <summary>
    ///   <para>rdfs:comment : The value of the datatype property *validUntil* associated to a particular area (territory or group) indicates the area's last year of validity. In case the area is currently valid, this value is set by default to 9999.
    ///       ^^xsd:string</para>
    ///   <a href="http://aims.fao.org/aos/geopolitical.owl#validUntil">geop:validUntil</a>
    /// </summary>
    let validUntil = _prefixId.prefix "validUntil"
    let western_Africa = _prefixId.prefix "western_Africa"
    let western_Asia = _prefixId.prefix "western_Asia"
    let western_Europe = _prefixId.prefix "western_Europe"

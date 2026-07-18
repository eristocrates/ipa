namespace http.www.geonames.org.ontology.hash

open DoxAletheia.Rdf_Vocabulary

module geonames =
    let _namespace_name = "http://www.geonames.org/ontology#"

    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#Marc-Wick"></see>
    /// </summary>
    let ``Marc-Wick`` =
        Namespaced_IRI.parse _namespace_name "Marc-Wick" |> NamespacedName

    /// <summary>
    /// country, state, region ...
    /// <see href="http://www.geonames.org/ontology#A"></see></summary>
    let A = Namespaced_IRI.parse _namespace_name "A" |> NamespacedName
    /// <summary>
    /// A class of features.
    /// <see href="http://www.geonames.org/ontology#Class"></see></summary>
    let Class = Namespaced_IRI.parse _namespace_name "Class" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.ADM1"></see>
    /// </summary>
    let ``A.ADM1`` = Namespaced_IRI.parse _namespace_name "A.ADM1" |> NamespacedName
    /// <summary>
    /// A feature code.
    /// <see href="http://www.geonames.org/ontology#Code"></see></summary>
    let Code = Namespaced_IRI.parse _namespace_name "Code" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.ADM1H"></see>
    /// </summary>
    let ``A.ADM1H`` = Namespaced_IRI.parse _namespace_name "A.ADM1H" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.ADM2"></see>
    /// </summary>
    let ``A.ADM2`` = Namespaced_IRI.parse _namespace_name "A.ADM2" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.ADM2H"></see>
    /// </summary>
    let ``A.ADM2H`` = Namespaced_IRI.parse _namespace_name "A.ADM2H" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.ADM3"></see>
    /// </summary>
    let ``A.ADM3`` = Namespaced_IRI.parse _namespace_name "A.ADM3" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.ADM3H"></see>
    /// </summary>
    let ``A.ADM3H`` = Namespaced_IRI.parse _namespace_name "A.ADM3H" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.ADM4"></see>
    /// </summary>
    let ``A.ADM4`` = Namespaced_IRI.parse _namespace_name "A.ADM4" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.ADM4H"></see>
    /// </summary>
    let ``A.ADM4H`` = Namespaced_IRI.parse _namespace_name "A.ADM4H" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.ADM5"></see>
    /// </summary>
    let ``A.ADM5`` = Namespaced_IRI.parse _namespace_name "A.ADM5" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.ADMD"></see>
    /// </summary>
    let ``A.ADMD`` = Namespaced_IRI.parse _namespace_name "A.ADMD" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.ADMH"></see>
    /// </summary>
    let ``A.ADMH`` = Namespaced_IRI.parse _namespace_name "A.ADMH" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.LTER"></see>
    /// </summary>
    let ``A.LTER`` = Namespaced_IRI.parse _namespace_name "A.LTER" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.PCL"></see>
    /// </summary>
    let ``A.PCL`` = Namespaced_IRI.parse _namespace_name "A.PCL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.PCLD"></see>
    /// </summary>
    let ``A.PCLD`` = Namespaced_IRI.parse _namespace_name "A.PCLD" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.PCLF"></see>
    /// </summary>
    let ``A.PCLF`` = Namespaced_IRI.parse _namespace_name "A.PCLF" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.PCLH"></see>
    /// </summary>
    let ``A.PCLH`` = Namespaced_IRI.parse _namespace_name "A.PCLH" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.PCLI"></see>
    /// </summary>
    let ``A.PCLI`` = Namespaced_IRI.parse _namespace_name "A.PCLI" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.PCLIX"></see>
    /// </summary>
    let ``A.PCLIX`` = Namespaced_IRI.parse _namespace_name "A.PCLIX" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.PCLS"></see>
    /// </summary>
    let ``A.PCLS`` = Namespaced_IRI.parse _namespace_name "A.PCLS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.PPCLH"></see>
    /// </summary>
    let ``A.PPCLH`` = Namespaced_IRI.parse _namespace_name "A.PPCLH" |> NamespacedName
    /// <summary>
    /// city, village,...
    /// <see href="http://www.geonames.org/ontology#P"></see></summary>
    let P = Namespaced_IRI.parse _namespace_name "P" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.PPLH"></see>
    /// </summary>
    let ``A.PPLH`` = Namespaced_IRI.parse _namespace_name "A.PPLH" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.PRSH"></see>
    /// </summary>
    let ``A.PRSH`` = Namespaced_IRI.parse _namespace_name "A.PRSH" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.TERR"></see>
    /// </summary>
    let ``A.TERR`` = Namespaced_IRI.parse _namespace_name "A.TERR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.ZN"></see>
    /// </summary>
    let ``A.ZN`` = Namespaced_IRI.parse _namespace_name "A.ZN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.ZNB"></see>
    /// </summary>
    let ``A.ZNB`` = Namespaced_IRI.parse _namespace_name "A.ZNB" |> NamespacedName
    /// <summary>
    /// A geographical feature
    /// <see href="http://www.geonames.org/ontology#Feature"></see></summary>
    let Feature = Namespaced_IRI.parse _namespace_name "Feature" |> NamespacedName

    /// <summary>
    /// A feature described in geonames database, uniquely defined by its geonames identifier
    /// <see href="http://www.geonames.org/ontology#GeonamesFeature"></see></summary>
    let GeonamesFeature =
        Namespaced_IRI.parse _namespace_name "GeonamesFeature" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#population"></see>
    /// </summary>
    let population = Namespaced_IRI.parse _namespace_name "population" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#geonamesID"></see>
    /// </summary>
    let geonamesID = Namespaced_IRI.parse _namespace_name "geonamesID" |> NamespacedName
    /// <summary>
    /// The main international name of a feature. The value has no xml:lang tag.
    /// <see href="http://www.geonames.org/ontology#name"></see></summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName

    /// <summary>
    /// The main category of the feature, as defined in geonames taxonomy.
    /// <see href="http://www.geonames.org/ontology#featureClass"></see></summary>
    let featureClass =
        Namespaced_IRI.parse _namespace_name "featureClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#parentADM1"></see>
    /// </summary>
    let parentADM1 = Namespaced_IRI.parse _namespace_name "parentADM1" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#parentADM3"></see>
    /// </summary>
    let parentADM3 = Namespaced_IRI.parse _namespace_name "parentADM3" |> NamespacedName

    /// <summary>
    /// The countryCode value for a Geoname Feature is equal to the countryCode value of the parentCountry value.
    /// A two letters country code in the ISO 3166 list
    /// <see href="http://www.geonames.org/ontology#countryCode"></see></summary>
    let countryCode =
        Namespaced_IRI.parse _namespace_name "countryCode" |> NamespacedName

    /// <summary>
    /// Type of the feature, as defined in geonames taxonomy.
    /// <see href="http://www.geonames.org/ontology#featureCode"></see></summary>
    let featureCode =
        Namespaced_IRI.parse _namespace_name "featureCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#parentADM2"></see>
    /// </summary>
    let parentADM2 = Namespaced_IRI.parse _namespace_name "parentADM2" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#parentADM4"></see>
    /// </summary>
    let parentADM4 = Namespaced_IRI.parse _namespace_name "parentADM4" |> NamespacedName
    /// <summary>
    /// stream, lake, ...
    /// <see href="http://www.geonames.org/ontology#H"></see></summary>
    let H = Namespaced_IRI.parse _namespace_name "H" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.AIRS"></see>
    /// </summary>
    let ``H.AIRS`` = Namespaced_IRI.parse _namespace_name "H.AIRS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.ANCH"></see>
    /// </summary>
    let ``H.ANCH`` = Namespaced_IRI.parse _namespace_name "H.ANCH" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.BAY"></see>
    /// </summary>
    let ``H.BAY`` = Namespaced_IRI.parse _namespace_name "H.BAY" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.BAYS"></see>
    /// </summary>
    let ``H.BAYS`` = Namespaced_IRI.parse _namespace_name "H.BAYS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.BGHT"></see>
    /// </summary>
    let ``H.BGHT`` = Namespaced_IRI.parse _namespace_name "H.BGHT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.BNK"></see>
    /// </summary>
    let ``H.BNK`` = Namespaced_IRI.parse _namespace_name "H.BNK" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.BNKR"></see>
    /// </summary>
    let ``H.BNKR`` = Namespaced_IRI.parse _namespace_name "H.BNKR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.BNKX"></see>
    /// </summary>
    let ``H.BNKX`` = Namespaced_IRI.parse _namespace_name "H.BNKX" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.BOG"></see>
    /// </summary>
    let ``H.BOG`` = Namespaced_IRI.parse _namespace_name "H.BOG" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.CAPG"></see>
    /// </summary>
    let ``H.CAPG`` = Namespaced_IRI.parse _namespace_name "H.CAPG" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.CHN"></see>
    /// </summary>
    let ``H.CHN`` = Namespaced_IRI.parse _namespace_name "H.CHN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.CHNL"></see>
    /// </summary>
    let ``H.CHNL`` = Namespaced_IRI.parse _namespace_name "H.CHNL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.CHNM"></see>
    /// </summary>
    let ``H.CHNM`` = Namespaced_IRI.parse _namespace_name "H.CHNM" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.CHNN"></see>
    /// </summary>
    let ``H.CHNN`` = Namespaced_IRI.parse _namespace_name "H.CHNN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.CNFL"></see>
    /// </summary>
    let ``H.CNFL`` = Namespaced_IRI.parse _namespace_name "H.CNFL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.CNL"></see>
    /// </summary>
    let ``H.CNL`` = Namespaced_IRI.parse _namespace_name "H.CNL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.CNLA"></see>
    /// </summary>
    let ``H.CNLA`` = Namespaced_IRI.parse _namespace_name "H.CNLA" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.CNLB"></see>
    /// </summary>
    let ``H.CNLB`` = Namespaced_IRI.parse _namespace_name "H.CNLB" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.CNLD"></see>
    /// </summary>
    let ``H.CNLD`` = Namespaced_IRI.parse _namespace_name "H.CNLD" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.CNLI"></see>
    /// </summary>
    let ``H.CNLI`` = Namespaced_IRI.parse _namespace_name "H.CNLI" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.CNLN"></see>
    /// </summary>
    let ``H.CNLN`` = Namespaced_IRI.parse _namespace_name "H.CNLN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.CNLQ"></see>
    /// </summary>
    let ``H.CNLQ`` = Namespaced_IRI.parse _namespace_name "H.CNLQ" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.CNLSB"></see>
    /// </summary>
    let ``H.CNLSB`` = Namespaced_IRI.parse _namespace_name "H.CNLSB" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.CNLX"></see>
    /// </summary>
    let ``H.CNLX`` = Namespaced_IRI.parse _namespace_name "H.CNLX" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.COVE"></see>
    /// </summary>
    let ``H.COVE`` = Namespaced_IRI.parse _namespace_name "H.COVE" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.CRKT"></see>
    /// </summary>
    let ``H.CRKT`` = Namespaced_IRI.parse _namespace_name "H.CRKT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.CRNT"></see>
    /// </summary>
    let ``H.CRNT`` = Namespaced_IRI.parse _namespace_name "H.CRNT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.CUTF"></see>
    /// </summary>
    let ``H.CUTF`` = Namespaced_IRI.parse _namespace_name "H.CUTF" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.DCK"></see>
    /// </summary>
    let ``H.DCK`` = Namespaced_IRI.parse _namespace_name "H.DCK" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.DCKB"></see>
    /// </summary>
    let ``H.DCKB`` = Namespaced_IRI.parse _namespace_name "H.DCKB" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.DOMG"></see>
    /// </summary>
    let ``H.DOMG`` = Namespaced_IRI.parse _namespace_name "H.DOMG" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.DPRG"></see>
    /// </summary>
    let ``H.DPRG`` = Namespaced_IRI.parse _namespace_name "H.DPRG" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.DTCH"></see>
    /// </summary>
    let ``H.DTCH`` = Namespaced_IRI.parse _namespace_name "H.DTCH" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.DTCHD"></see>
    /// </summary>
    let ``H.DTCHD`` = Namespaced_IRI.parse _namespace_name "H.DTCHD" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.DTCHI"></see>
    /// </summary>
    let ``H.DTCHI`` = Namespaced_IRI.parse _namespace_name "H.DTCHI" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.DTCHM"></see>
    /// </summary>
    let ``H.DTCHM`` = Namespaced_IRI.parse _namespace_name "H.DTCHM" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.ESTY"></see>
    /// </summary>
    let ``H.ESTY`` = Namespaced_IRI.parse _namespace_name "H.ESTY" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.FISH"></see>
    /// </summary>
    let ``H.FISH`` = Namespaced_IRI.parse _namespace_name "H.FISH" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.FJD"></see>
    /// </summary>
    let ``H.FJD`` = Namespaced_IRI.parse _namespace_name "H.FJD" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.FJDS"></see>
    /// </summary>
    let ``H.FJDS`` = Namespaced_IRI.parse _namespace_name "H.FJDS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.FLLS"></see>
    /// </summary>
    let ``H.FLLS`` = Namespaced_IRI.parse _namespace_name "H.FLLS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.FLLSX"></see>
    /// </summary>
    let ``H.FLLSX`` = Namespaced_IRI.parse _namespace_name "H.FLLSX" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.FLTM"></see>
    /// </summary>
    let ``H.FLTM`` = Namespaced_IRI.parse _namespace_name "H.FLTM" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.FLTT"></see>
    /// </summary>
    let ``H.FLTT`` = Namespaced_IRI.parse _namespace_name "H.FLTT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.GLCR"></see>
    /// </summary>
    let ``H.GLCR`` = Namespaced_IRI.parse _namespace_name "H.GLCR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.GULF"></see>
    /// </summary>
    let ``H.GULF`` = Namespaced_IRI.parse _namespace_name "H.GULF" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.GYSR"></see>
    /// </summary>
    let ``H.GYSR`` = Namespaced_IRI.parse _namespace_name "H.GYSR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.HBR"></see>
    /// </summary>
    let ``H.HBR`` = Namespaced_IRI.parse _namespace_name "H.HBR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.HBRX"></see>
    /// </summary>
    let ``H.HBRX`` = Namespaced_IRI.parse _namespace_name "H.HBRX" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.INLT"></see>
    /// </summary>
    let ``H.INLT`` = Namespaced_IRI.parse _namespace_name "H.INLT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.INLTQ"></see>
    /// </summary>
    let ``H.INLTQ`` = Namespaced_IRI.parse _namespace_name "H.INLTQ" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.LBED"></see>
    /// </summary>
    let ``H.LBED`` = Namespaced_IRI.parse _namespace_name "H.LBED" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.LGN"></see>
    /// </summary>
    let ``H.LGN`` = Namespaced_IRI.parse _namespace_name "H.LGN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.LGNS"></see>
    /// </summary>
    let ``H.LGNS`` = Namespaced_IRI.parse _namespace_name "H.LGNS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.LGNX"></see>
    /// </summary>
    let ``H.LGNX`` = Namespaced_IRI.parse _namespace_name "H.LGNX" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.LK"></see>
    /// </summary>
    let ``H.LK`` = Namespaced_IRI.parse _namespace_name "H.LK" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.LKC"></see>
    /// </summary>
    let ``H.LKC`` = Namespaced_IRI.parse _namespace_name "H.LKC" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.LKI"></see>
    /// </summary>
    let ``H.LKI`` = Namespaced_IRI.parse _namespace_name "H.LKI" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.LKN"></see>
    /// </summary>
    let ``H.LKN`` = Namespaced_IRI.parse _namespace_name "H.LKN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.LKNI"></see>
    /// </summary>
    let ``H.LKNI`` = Namespaced_IRI.parse _namespace_name "H.LKNI" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.LKO"></see>
    /// </summary>
    let ``H.LKO`` = Namespaced_IRI.parse _namespace_name "H.LKO" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.LKOI"></see>
    /// </summary>
    let ``H.LKOI`` = Namespaced_IRI.parse _namespace_name "H.LKOI" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.LKS"></see>
    /// </summary>
    let ``H.LKS`` = Namespaced_IRI.parse _namespace_name "H.LKS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.LKSB"></see>
    /// </summary>
    let ``H.LKSB`` = Namespaced_IRI.parse _namespace_name "H.LKSB" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.LKSC"></see>
    /// </summary>
    let ``H.LKSC`` = Namespaced_IRI.parse _namespace_name "H.LKSC" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.LKSI"></see>
    /// </summary>
    let ``H.LKSI`` = Namespaced_IRI.parse _namespace_name "H.LKSI" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.LKSN"></see>
    /// </summary>
    let ``H.LKSN`` = Namespaced_IRI.parse _namespace_name "H.LKSN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.LKSNI"></see>
    /// </summary>
    let ``H.LKSNI`` = Namespaced_IRI.parse _namespace_name "H.LKSNI" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.LKX"></see>
    /// </summary>
    let ``H.LKX`` = Namespaced_IRI.parse _namespace_name "H.LKX" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.MFGN"></see>
    /// </summary>
    let ``H.MFGN`` = Namespaced_IRI.parse _namespace_name "H.MFGN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.MGV"></see>
    /// </summary>
    let ``H.MGV`` = Namespaced_IRI.parse _namespace_name "H.MGV" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.MOOR"></see>
    /// </summary>
    let ``H.MOOR`` = Namespaced_IRI.parse _namespace_name "H.MOOR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.MRSH"></see>
    /// </summary>
    let ``H.MRSH`` = Namespaced_IRI.parse _namespace_name "H.MRSH" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.MRSHN"></see>
    /// </summary>
    let ``H.MRSHN`` = Namespaced_IRI.parse _namespace_name "H.MRSHN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.NRWS"></see>
    /// </summary>
    let ``H.NRWS`` = Namespaced_IRI.parse _namespace_name "H.NRWS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.OCN"></see>
    /// </summary>
    let ``H.OCN`` = Namespaced_IRI.parse _namespace_name "H.OCN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.OVF"></see>
    /// </summary>
    let ``H.OVF`` = Namespaced_IRI.parse _namespace_name "H.OVF" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.PND"></see>
    /// </summary>
    let ``H.PND`` = Namespaced_IRI.parse _namespace_name "H.PND" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.PNDI"></see>
    /// </summary>
    let ``H.PNDI`` = Namespaced_IRI.parse _namespace_name "H.PNDI" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.PNDN"></see>
    /// </summary>
    let ``H.PNDN`` = Namespaced_IRI.parse _namespace_name "H.PNDN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.PNDNI"></see>
    /// </summary>
    let ``H.PNDNI`` = Namespaced_IRI.parse _namespace_name "H.PNDNI" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.PNDS"></see>
    /// </summary>
    let ``H.PNDS`` = Namespaced_IRI.parse _namespace_name "H.PNDS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.PNDSF"></see>
    /// </summary>
    let ``H.PNDSF`` = Namespaced_IRI.parse _namespace_name "H.PNDSF" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.PNDSI"></see>
    /// </summary>
    let ``H.PNDSI`` = Namespaced_IRI.parse _namespace_name "H.PNDSI" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.PNDSN"></see>
    /// </summary>
    let ``H.PNDSN`` = Namespaced_IRI.parse _namespace_name "H.PNDSN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.POOL"></see>
    /// </summary>
    let ``H.POOL`` = Namespaced_IRI.parse _namespace_name "H.POOL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.POOLI"></see>
    /// </summary>
    let ``H.POOLI`` = Namespaced_IRI.parse _namespace_name "H.POOLI" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.RCH"></see>
    /// </summary>
    let ``H.RCH`` = Namespaced_IRI.parse _namespace_name "H.RCH" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.RDGG"></see>
    /// </summary>
    let ``H.RDGG`` = Namespaced_IRI.parse _namespace_name "H.RDGG" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.RDST"></see>
    /// </summary>
    let ``H.RDST`` = Namespaced_IRI.parse _namespace_name "H.RDST" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.RF"></see>
    /// </summary>
    let ``H.RF`` = Namespaced_IRI.parse _namespace_name "H.RF" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.RFC"></see>
    /// </summary>
    let ``H.RFC`` = Namespaced_IRI.parse _namespace_name "H.RFC" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.RFX"></see>
    /// </summary>
    let ``H.RFX`` = Namespaced_IRI.parse _namespace_name "H.RFX" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.RPDS"></see>
    /// </summary>
    let ``H.RPDS`` = Namespaced_IRI.parse _namespace_name "H.RPDS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.RSV"></see>
    /// </summary>
    let ``H.RSV`` = Namespaced_IRI.parse _namespace_name "H.RSV" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.RSVI"></see>
    /// </summary>
    let ``H.RSVI`` = Namespaced_IRI.parse _namespace_name "H.RSVI" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.RSVT"></see>
    /// </summary>
    let ``H.RSVT`` = Namespaced_IRI.parse _namespace_name "H.RSVT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.RVN"></see>
    /// </summary>
    let ``H.RVN`` = Namespaced_IRI.parse _namespace_name "H.RVN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.SBKH"></see>
    /// </summary>
    let ``H.SBKH`` = Namespaced_IRI.parse _namespace_name "H.SBKH" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.SD"></see>
    /// </summary>
    let ``H.SD`` = Namespaced_IRI.parse _namespace_name "H.SD" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.SEA"></see>
    /// </summary>
    let ``H.SEA`` = Namespaced_IRI.parse _namespace_name "H.SEA" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.SHOL"></see>
    /// </summary>
    let ``H.SHOL`` = Namespaced_IRI.parse _namespace_name "H.SHOL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.SILL"></see>
    /// </summary>
    let ``H.SILL`` = Namespaced_IRI.parse _namespace_name "H.SILL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.SPNG"></see>
    /// </summary>
    let ``H.SPNG`` = Namespaced_IRI.parse _namespace_name "H.SPNG" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.SPNS"></see>
    /// </summary>
    let ``H.SPNS`` = Namespaced_IRI.parse _namespace_name "H.SPNS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.SPNT"></see>
    /// </summary>
    let ``H.SPNT`` = Namespaced_IRI.parse _namespace_name "H.SPNT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.STM"></see>
    /// </summary>
    let ``H.STM`` = Namespaced_IRI.parse _namespace_name "H.STM" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.STMA"></see>
    /// </summary>
    let ``H.STMA`` = Namespaced_IRI.parse _namespace_name "H.STMA" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.STMB"></see>
    /// </summary>
    let ``H.STMB`` = Namespaced_IRI.parse _namespace_name "H.STMB" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.STMC"></see>
    /// </summary>
    let ``H.STMC`` = Namespaced_IRI.parse _namespace_name "H.STMC" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.STMD"></see>
    /// </summary>
    let ``H.STMD`` = Namespaced_IRI.parse _namespace_name "H.STMD" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.STMH"></see>
    /// </summary>
    let ``H.STMH`` = Namespaced_IRI.parse _namespace_name "H.STMH" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.STMI"></see>
    /// </summary>
    let ``H.STMI`` = Namespaced_IRI.parse _namespace_name "H.STMI" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.STMIX"></see>
    /// </summary>
    let ``H.STMIX`` = Namespaced_IRI.parse _namespace_name "H.STMIX" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.STMM"></see>
    /// </summary>
    let ``H.STMM`` = Namespaced_IRI.parse _namespace_name "H.STMM" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.STMQ"></see>
    /// </summary>
    let ``H.STMQ`` = Namespaced_IRI.parse _namespace_name "H.STMQ" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.STMS"></see>
    /// </summary>
    let ``H.STMS`` = Namespaced_IRI.parse _namespace_name "H.STMS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.STMSB"></see>
    /// </summary>
    let ``H.STMSB`` = Namespaced_IRI.parse _namespace_name "H.STMSB" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.STMX"></see>
    /// </summary>
    let ``H.STMX`` = Namespaced_IRI.parse _namespace_name "H.STMX" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.STRT"></see>
    /// </summary>
    let ``H.STRT`` = Namespaced_IRI.parse _namespace_name "H.STRT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.SWMP"></see>
    /// </summary>
    let ``H.SWMP`` = Namespaced_IRI.parse _namespace_name "H.SWMP" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.SYSI"></see>
    /// </summary>
    let ``H.SYSI`` = Namespaced_IRI.parse _namespace_name "H.SYSI" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.TNLC"></see>
    /// </summary>
    let ``H.TNLC`` = Namespaced_IRI.parse _namespace_name "H.TNLC" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.WAD"></see>
    /// </summary>
    let ``H.WAD`` = Namespaced_IRI.parse _namespace_name "H.WAD" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.WADB"></see>
    /// </summary>
    let ``H.WADB`` = Namespaced_IRI.parse _namespace_name "H.WADB" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.WADJ"></see>
    /// </summary>
    let ``H.WADJ`` = Namespaced_IRI.parse _namespace_name "H.WADJ" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.WADM"></see>
    /// </summary>
    let ``H.WADM`` = Namespaced_IRI.parse _namespace_name "H.WADM" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.WADS"></see>
    /// </summary>
    let ``H.WADS`` = Namespaced_IRI.parse _namespace_name "H.WADS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.WADX"></see>
    /// </summary>
    let ``H.WADX`` = Namespaced_IRI.parse _namespace_name "H.WADX" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.WHRL"></see>
    /// </summary>
    let ``H.WHRL`` = Namespaced_IRI.parse _namespace_name "H.WHRL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.WLL"></see>
    /// </summary>
    let ``H.WLL`` = Namespaced_IRI.parse _namespace_name "H.WLL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.WLLQ"></see>
    /// </summary>
    let ``H.WLLQ`` = Namespaced_IRI.parse _namespace_name "H.WLLQ" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.WLLS"></see>
    /// </summary>
    let ``H.WLLS`` = Namespaced_IRI.parse _namespace_name "H.WLLS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.WTLD"></see>
    /// </summary>
    let ``H.WTLD`` = Namespaced_IRI.parse _namespace_name "H.WTLD" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.WTLDI"></see>
    /// </summary>
    let ``H.WTLDI`` = Namespaced_IRI.parse _namespace_name "H.WTLDI" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.WTRC"></see>
    /// </summary>
    let ``H.WTRC`` = Namespaced_IRI.parse _namespace_name "H.WTRC" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.WTRH"></see>
    /// </summary>
    let ``H.WTRH`` = Namespaced_IRI.parse _namespace_name "H.WTRH" |> NamespacedName
    /// <summary>
    /// parks,area, ...
    /// <see href="http://www.geonames.org/ontology#L"></see></summary>
    let L = Namespaced_IRI.parse _namespace_name "L" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.AGRC"></see>
    /// </summary>
    let ``L.AGRC`` = Namespaced_IRI.parse _namespace_name "L.AGRC" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.AMUS"></see>
    /// </summary>
    let ``L.AMUS`` = Namespaced_IRI.parse _namespace_name "L.AMUS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.AREA"></see>
    /// </summary>
    let ``L.AREA`` = Namespaced_IRI.parse _namespace_name "L.AREA" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.BSND"></see>
    /// </summary>
    let ``L.BSND`` = Namespaced_IRI.parse _namespace_name "L.BSND" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.BSNP"></see>
    /// </summary>
    let ``L.BSNP`` = Namespaced_IRI.parse _namespace_name "L.BSNP" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.BTL"></see>
    /// </summary>
    let ``L.BTL`` = Namespaced_IRI.parse _namespace_name "L.BTL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.CLG"></see>
    /// </summary>
    let ``L.CLG`` = Namespaced_IRI.parse _namespace_name "L.CLG" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.CMN"></see>
    /// </summary>
    let ``L.CMN`` = Namespaced_IRI.parse _namespace_name "L.CMN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.CNS"></see>
    /// </summary>
    let ``L.CNS`` = Namespaced_IRI.parse _namespace_name "L.CNS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.COLF"></see>
    /// </summary>
    let ``L.COLF`` = Namespaced_IRI.parse _namespace_name "L.COLF" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.CONT"></see>
    /// </summary>
    let ``L.CONT`` = Namespaced_IRI.parse _namespace_name "L.CONT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.CST"></see>
    /// </summary>
    let ``L.CST`` = Namespaced_IRI.parse _namespace_name "L.CST" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.CTRB"></see>
    /// </summary>
    let ``L.CTRB`` = Namespaced_IRI.parse _namespace_name "L.CTRB" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.DEVH"></see>
    /// </summary>
    let ``L.DEVH`` = Namespaced_IRI.parse _namespace_name "L.DEVH" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.FLD"></see>
    /// </summary>
    let ``L.FLD`` = Namespaced_IRI.parse _namespace_name "L.FLD" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.FLDI"></see>
    /// </summary>
    let ``L.FLDI`` = Namespaced_IRI.parse _namespace_name "L.FLDI" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.GASF"></see>
    /// </summary>
    let ``L.GASF`` = Namespaced_IRI.parse _namespace_name "L.GASF" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.GRAZ"></see>
    /// </summary>
    let ``L.GRAZ`` = Namespaced_IRI.parse _namespace_name "L.GRAZ" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.GVL"></see>
    /// </summary>
    let ``L.GVL`` = Namespaced_IRI.parse _namespace_name "L.GVL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.INDS"></see>
    /// </summary>
    let ``L.INDS`` = Namespaced_IRI.parse _namespace_name "L.INDS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.LAND"></see>
    /// </summary>
    let ``L.LAND`` = Namespaced_IRI.parse _namespace_name "L.LAND" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.LCTY"></see>
    /// </summary>
    let ``L.LCTY`` = Namespaced_IRI.parse _namespace_name "L.LCTY" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.MILB"></see>
    /// </summary>
    let ``L.MILB`` = Namespaced_IRI.parse _namespace_name "L.MILB" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.MNA"></see>
    /// </summary>
    let ``L.MNA`` = Namespaced_IRI.parse _namespace_name "L.MNA" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.MVA"></see>
    /// </summary>
    let ``L.MVA`` = Namespaced_IRI.parse _namespace_name "L.MVA" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.NVB"></see>
    /// </summary>
    let ``L.NVB`` = Namespaced_IRI.parse _namespace_name "L.NVB" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.OAS"></see>
    /// </summary>
    let ``L.OAS`` = Namespaced_IRI.parse _namespace_name "L.OAS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.OILF"></see>
    /// </summary>
    let ``L.OILF`` = Namespaced_IRI.parse _namespace_name "L.OILF" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.PEAT"></see>
    /// </summary>
    let ``L.PEAT`` = Namespaced_IRI.parse _namespace_name "L.PEAT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.PRK"></see>
    /// </summary>
    let ``L.PRK`` = Namespaced_IRI.parse _namespace_name "L.PRK" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.PRT"></see>
    /// </summary>
    let ``L.PRT`` = Namespaced_IRI.parse _namespace_name "L.PRT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.QCKS"></see>
    /// </summary>
    let ``L.QCKS`` = Namespaced_IRI.parse _namespace_name "L.QCKS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.REP"></see>
    /// </summary>
    let ``L.REP`` = Namespaced_IRI.parse _namespace_name "L.REP" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.RES"></see>
    /// </summary>
    let ``L.RES`` = Namespaced_IRI.parse _namespace_name "L.RES" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.RESA"></see>
    /// </summary>
    let ``L.RESA`` = Namespaced_IRI.parse _namespace_name "L.RESA" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.RESF"></see>
    /// </summary>
    let ``L.RESF`` = Namespaced_IRI.parse _namespace_name "L.RESF" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.RESH"></see>
    /// </summary>
    let ``L.RESH`` = Namespaced_IRI.parse _namespace_name "L.RESH" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.RESN"></see>
    /// </summary>
    let ``L.RESN`` = Namespaced_IRI.parse _namespace_name "L.RESN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.RESP"></see>
    /// </summary>
    let ``L.RESP`` = Namespaced_IRI.parse _namespace_name "L.RESP" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.RESV"></see>
    /// </summary>
    let ``L.RESV`` = Namespaced_IRI.parse _namespace_name "L.RESV" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.RESW"></see>
    /// </summary>
    let ``L.RESW`` = Namespaced_IRI.parse _namespace_name "L.RESW" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.RGN"></see>
    /// </summary>
    let ``L.RGN`` = Namespaced_IRI.parse _namespace_name "L.RGN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.RGNE"></see>
    /// </summary>
    let ``L.RGNE`` = Namespaced_IRI.parse _namespace_name "L.RGNE" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.RGNH"></see>
    /// </summary>
    let ``L.RGNH`` = Namespaced_IRI.parse _namespace_name "L.RGNH" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.RGNL"></see>
    /// </summary>
    let ``L.RGNL`` = Namespaced_IRI.parse _namespace_name "L.RGNL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.RNGA"></see>
    /// </summary>
    let ``L.RNGA`` = Namespaced_IRI.parse _namespace_name "L.RNGA" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.SALT"></see>
    /// </summary>
    let ``L.SALT`` = Namespaced_IRI.parse _namespace_name "L.SALT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.SNOW"></see>
    /// </summary>
    let ``L.SNOW`` = Namespaced_IRI.parse _namespace_name "L.SNOW" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.TRB"></see>
    /// </summary>
    let ``L.TRB`` = Namespaced_IRI.parse _namespace_name "L.TRB" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.ZZZZZ"></see>
    /// </summary>
    let ``L.ZZZZZ`` = Namespaced_IRI.parse _namespace_name "L.ZZZZZ" |> NamespacedName
    /// <summary>
    /// A Web page displaying a map
    /// <see href="http://www.geonames.org/ontology#Map"></see></summary>
    let Map = Namespaced_IRI.parse _namespace_name "Map" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#P.PPL"></see>
    /// </summary>
    let ``P.PPL`` = Namespaced_IRI.parse _namespace_name "P.PPL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#P.PPLA"></see>
    /// </summary>
    let ``P.PPLA`` = Namespaced_IRI.parse _namespace_name "P.PPLA" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#P.PPLA2"></see>
    /// </summary>
    let ``P.PPLA2`` = Namespaced_IRI.parse _namespace_name "P.PPLA2" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#P.PPLA3"></see>
    /// </summary>
    let ``P.PPLA3`` = Namespaced_IRI.parse _namespace_name "P.PPLA3" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#P.PPLA4"></see>
    /// </summary>
    let ``P.PPLA4`` = Namespaced_IRI.parse _namespace_name "P.PPLA4" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#P.PPLC"></see>
    /// </summary>
    let ``P.PPLC`` = Namespaced_IRI.parse _namespace_name "P.PPLC" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#P.PPLF"></see>
    /// </summary>
    let ``P.PPLF`` = Namespaced_IRI.parse _namespace_name "P.PPLF" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#P.PPLG"></see>
    /// </summary>
    let ``P.PPLG`` = Namespaced_IRI.parse _namespace_name "P.PPLG" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#P.PPLL"></see>
    /// </summary>
    let ``P.PPLL`` = Namespaced_IRI.parse _namespace_name "P.PPLL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#P.PPLQ"></see>
    /// </summary>
    let ``P.PPLQ`` = Namespaced_IRI.parse _namespace_name "P.PPLQ" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#P.PPLR"></see>
    /// </summary>
    let ``P.PPLR`` = Namespaced_IRI.parse _namespace_name "P.PPLR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#P.PPLS"></see>
    /// </summary>
    let ``P.PPLS`` = Namespaced_IRI.parse _namespace_name "P.PPLS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#P.PPLW"></see>
    /// </summary>
    let ``P.PPLW`` = Namespaced_IRI.parse _namespace_name "P.PPLW" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#P.PPLX"></see>
    /// </summary>
    let ``P.PPLX`` = Namespaced_IRI.parse _namespace_name "P.PPLX" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#P.STLMT"></see>
    /// </summary>
    let ``P.STLMT`` = Namespaced_IRI.parse _namespace_name "P.STLMT" |> NamespacedName
    /// <summary>
    /// road, railroad, ...
    /// <see href="http://www.geonames.org/ontology#R"></see></summary>
    let R = Namespaced_IRI.parse _namespace_name "R" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.CSWY"></see>
    /// </summary>
    let ``R.CSWY`` = Namespaced_IRI.parse _namespace_name "R.CSWY" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.CSWYQ"></see>
    /// </summary>
    let ``R.CSWYQ`` = Namespaced_IRI.parse _namespace_name "R.CSWYQ" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.OILP"></see>
    /// </summary>
    let ``R.OILP`` = Namespaced_IRI.parse _namespace_name "R.OILP" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.PRMN"></see>
    /// </summary>
    let ``R.PRMN`` = Namespaced_IRI.parse _namespace_name "R.PRMN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.PTGE"></see>
    /// </summary>
    let ``R.PTGE`` = Namespaced_IRI.parse _namespace_name "R.PTGE" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.RD"></see>
    /// </summary>
    let ``R.RD`` = Namespaced_IRI.parse _namespace_name "R.RD" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.RDA"></see>
    /// </summary>
    let ``R.RDA`` = Namespaced_IRI.parse _namespace_name "R.RDA" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.RDB"></see>
    /// </summary>
    let ``R.RDB`` = Namespaced_IRI.parse _namespace_name "R.RDB" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.RDCUT"></see>
    /// </summary>
    let ``R.RDCUT`` = Namespaced_IRI.parse _namespace_name "R.RDCUT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.RDJCT"></see>
    /// </summary>
    let ``R.RDJCT`` = Namespaced_IRI.parse _namespace_name "R.RDJCT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.RJCT"></see>
    /// </summary>
    let ``R.RJCT`` = Namespaced_IRI.parse _namespace_name "R.RJCT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.RR"></see>
    /// </summary>
    let ``R.RR`` = Namespaced_IRI.parse _namespace_name "R.RR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.RRQ"></see>
    /// </summary>
    let ``R.RRQ`` = Namespaced_IRI.parse _namespace_name "R.RRQ" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.RTE"></see>
    /// </summary>
    let ``R.RTE`` = Namespaced_IRI.parse _namespace_name "R.RTE" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.RYD"></see>
    /// </summary>
    let ``R.RYD`` = Namespaced_IRI.parse _namespace_name "R.RYD" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.ST"></see>
    /// </summary>
    let ``R.ST`` = Namespaced_IRI.parse _namespace_name "R.ST" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.STKR"></see>
    /// </summary>
    let ``R.STKR`` = Namespaced_IRI.parse _namespace_name "R.STKR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.TNL"></see>
    /// </summary>
    let ``R.TNL`` = Namespaced_IRI.parse _namespace_name "R.TNL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.TNLN"></see>
    /// </summary>
    let ``R.TNLN`` = Namespaced_IRI.parse _namespace_name "R.TNLN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.TNLRD"></see>
    /// </summary>
    let ``R.TNLRD`` = Namespaced_IRI.parse _namespace_name "R.TNLRD" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.TNLRR"></see>
    /// </summary>
    let ``R.TNLRR`` = Namespaced_IRI.parse _namespace_name "R.TNLRR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.TNLS"></see>
    /// </summary>
    let ``R.TNLS`` = Namespaced_IRI.parse _namespace_name "R.TNLS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.TRL"></see>
    /// </summary>
    let ``R.TRL`` = Namespaced_IRI.parse _namespace_name "R.TRL" |> NamespacedName
    /// <summary>
    /// A Document containing RDF description of one or several features.
    /// <see href="http://www.geonames.org/ontology#RDFData"></see></summary>
    let RDFData = Namespaced_IRI.parse _namespace_name "RDFData" |> NamespacedName
    /// <summary>
    /// spot, building, farm, ...
    /// <see href="http://www.geonames.org/ontology#S"></see></summary>
    let S = Namespaced_IRI.parse _namespace_name "S" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ADMF"></see>
    /// </summary>
    let ``S.ADMF`` = Namespaced_IRI.parse _namespace_name "S.ADMF" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.AGRF"></see>
    /// </summary>
    let ``S.AGRF`` = Namespaced_IRI.parse _namespace_name "S.AGRF" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.AIRB"></see>
    /// </summary>
    let ``S.AIRB`` = Namespaced_IRI.parse _namespace_name "S.AIRB" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.AIRF"></see>
    /// </summary>
    let ``S.AIRF`` = Namespaced_IRI.parse _namespace_name "S.AIRF" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.AIRH"></see>
    /// </summary>
    let ``S.AIRH`` = Namespaced_IRI.parse _namespace_name "S.AIRH" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.AIRP"></see>
    /// </summary>
    let ``S.AIRP`` = Namespaced_IRI.parse _namespace_name "S.AIRP" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.AIRQ"></see>
    /// </summary>
    let ``S.AIRQ`` = Namespaced_IRI.parse _namespace_name "S.AIRQ" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.AMTH"></see>
    /// </summary>
    let ``S.AMTH`` = Namespaced_IRI.parse _namespace_name "S.AMTH" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ANS"></see>
    /// </summary>
    let ``S.ANS`` = Namespaced_IRI.parse _namespace_name "S.ANS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.AQC"></see>
    /// </summary>
    let ``S.AQC`` = Namespaced_IRI.parse _namespace_name "S.AQC" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ARCH"></see>
    /// </summary>
    let ``S.ARCH`` = Namespaced_IRI.parse _namespace_name "S.ARCH" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ASTR"></see>
    /// </summary>
    let ``S.ASTR`` = Namespaced_IRI.parse _namespace_name "S.ASTR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ASYL"></see>
    /// </summary>
    let ``S.ASYL`` = Namespaced_IRI.parse _namespace_name "S.ASYL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ATHF"></see>
    /// </summary>
    let ``S.ATHF`` = Namespaced_IRI.parse _namespace_name "S.ATHF" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ATM"></see>
    /// </summary>
    let ``S.ATM`` = Namespaced_IRI.parse _namespace_name "S.ATM" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.BANK"></see>
    /// </summary>
    let ``S.BANK`` = Namespaced_IRI.parse _namespace_name "S.BANK" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.BCN"></see>
    /// </summary>
    let ``S.BCN`` = Namespaced_IRI.parse _namespace_name "S.BCN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.BDG"></see>
    /// </summary>
    let ``S.BDG`` = Namespaced_IRI.parse _namespace_name "S.BDG" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.BDGQ"></see>
    /// </summary>
    let ``S.BDGQ`` = Namespaced_IRI.parse _namespace_name "S.BDGQ" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.BLDG"></see>
    /// </summary>
    let ``S.BLDG`` = Namespaced_IRI.parse _namespace_name "S.BLDG" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.BLDO"></see>
    /// </summary>
    let ``S.BLDO`` = Namespaced_IRI.parse _namespace_name "S.BLDO" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.BP"></see>
    /// </summary>
    let ``S.BP`` = Namespaced_IRI.parse _namespace_name "S.BP" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.BRKS"></see>
    /// </summary>
    let ``S.BRKS`` = Namespaced_IRI.parse _namespace_name "S.BRKS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.BRKW"></see>
    /// </summary>
    let ``S.BRKW`` = Namespaced_IRI.parse _namespace_name "S.BRKW" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.BSTN"></see>
    /// </summary>
    let ``S.BSTN`` = Namespaced_IRI.parse _namespace_name "S.BSTN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.BTYD"></see>
    /// </summary>
    let ``S.BTYD`` = Namespaced_IRI.parse _namespace_name "S.BTYD" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.BUR"></see>
    /// </summary>
    let ``S.BUR`` = Namespaced_IRI.parse _namespace_name "S.BUR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.BUSTN"></see>
    /// </summary>
    let ``S.BUSTN`` = Namespaced_IRI.parse _namespace_name "S.BUSTN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.BUSTP"></see>
    /// </summary>
    let ``S.BUSTP`` = Namespaced_IRI.parse _namespace_name "S.BUSTP" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CARN"></see>
    /// </summary>
    let ``S.CARN`` = Namespaced_IRI.parse _namespace_name "S.CARN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CAVE"></see>
    /// </summary>
    let ``S.CAVE`` = Namespaced_IRI.parse _namespace_name "S.CAVE" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CCL"></see>
    /// </summary>
    let ``S.CCL`` = Namespaced_IRI.parse _namespace_name "S.CCL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CH"></see>
    /// </summary>
    let ``S.CH`` = Namespaced_IRI.parse _namespace_name "S.CH" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CMP"></see>
    /// </summary>
    let ``S.CMP`` = Namespaced_IRI.parse _namespace_name "S.CMP" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CMPL"></see>
    /// </summary>
    let ``S.CMPL`` = Namespaced_IRI.parse _namespace_name "S.CMPL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CMPLA"></see>
    /// </summary>
    let ``S.CMPLA`` = Namespaced_IRI.parse _namespace_name "S.CMPLA" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CMPMN"></see>
    /// </summary>
    let ``S.CMPMN`` = Namespaced_IRI.parse _namespace_name "S.CMPMN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CMPO"></see>
    /// </summary>
    let ``S.CMPO`` = Namespaced_IRI.parse _namespace_name "S.CMPO" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CMPQ"></see>
    /// </summary>
    let ``S.CMPQ`` = Namespaced_IRI.parse _namespace_name "S.CMPQ" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CMPRF"></see>
    /// </summary>
    let ``S.CMPRF`` = Namespaced_IRI.parse _namespace_name "S.CMPRF" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CMTY"></see>
    /// </summary>
    let ``S.CMTY`` = Namespaced_IRI.parse _namespace_name "S.CMTY" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.COMC"></see>
    /// </summary>
    let ``S.COMC`` = Namespaced_IRI.parse _namespace_name "S.COMC" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CRRL"></see>
    /// </summary>
    let ``S.CRRL`` = Namespaced_IRI.parse _namespace_name "S.CRRL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CSNO"></see>
    /// </summary>
    let ``S.CSNO`` = Namespaced_IRI.parse _namespace_name "S.CSNO" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CSTL"></see>
    /// </summary>
    let ``S.CSTL`` = Namespaced_IRI.parse _namespace_name "S.CSTL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CSTM"></see>
    /// </summary>
    let ``S.CSTM`` = Namespaced_IRI.parse _namespace_name "S.CSTM" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CTHSE"></see>
    /// </summary>
    let ``S.CTHSE`` = Namespaced_IRI.parse _namespace_name "S.CTHSE" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CTRA"></see>
    /// </summary>
    let ``S.CTRA`` = Namespaced_IRI.parse _namespace_name "S.CTRA" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CTRCM"></see>
    /// </summary>
    let ``S.CTRCM`` = Namespaced_IRI.parse _namespace_name "S.CTRCM" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CTRF"></see>
    /// </summary>
    let ``S.CTRF`` = Namespaced_IRI.parse _namespace_name "S.CTRF" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CTRM"></see>
    /// </summary>
    let ``S.CTRM`` = Namespaced_IRI.parse _namespace_name "S.CTRM" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CTRR"></see>
    /// </summary>
    let ``S.CTRR`` = Namespaced_IRI.parse _namespace_name "S.CTRR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CTRS"></see>
    /// </summary>
    let ``S.CTRS`` = Namespaced_IRI.parse _namespace_name "S.CTRS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CVNT"></see>
    /// </summary>
    let ``S.CVNT`` = Namespaced_IRI.parse _namespace_name "S.CVNT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.DAM"></see>
    /// </summary>
    let ``S.DAM`` = Namespaced_IRI.parse _namespace_name "S.DAM" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.DAMQ"></see>
    /// </summary>
    let ``S.DAMQ`` = Namespaced_IRI.parse _namespace_name "S.DAMQ" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.DAMSB"></see>
    /// </summary>
    let ``S.DAMSB`` = Namespaced_IRI.parse _namespace_name "S.DAMSB" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.DARY"></see>
    /// </summary>
    let ``S.DARY`` = Namespaced_IRI.parse _namespace_name "S.DARY" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.DCKD"></see>
    /// </summary>
    let ``S.DCKD`` = Namespaced_IRI.parse _namespace_name "S.DCKD" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.DCKY"></see>
    /// </summary>
    let ``S.DCKY`` = Namespaced_IRI.parse _namespace_name "S.DCKY" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.DIKE"></see>
    /// </summary>
    let ``S.DIKE`` = Namespaced_IRI.parse _namespace_name "S.DIKE" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.DIP"></see>
    /// </summary>
    let ``S.DIP`` = Namespaced_IRI.parse _namespace_name "S.DIP" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.DPOF"></see>
    /// </summary>
    let ``S.DPOF`` = Namespaced_IRI.parse _namespace_name "S.DPOF" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.EST"></see>
    /// </summary>
    let ``S.EST`` = Namespaced_IRI.parse _namespace_name "S.EST" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ESTB"></see>
    /// </summary>
    let ``S.ESTB`` = Namespaced_IRI.parse _namespace_name "S.ESTB" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ESTC"></see>
    /// </summary>
    let ``S.ESTC`` = Namespaced_IRI.parse _namespace_name "S.ESTC" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ESTO"></see>
    /// </summary>
    let ``S.ESTO`` = Namespaced_IRI.parse _namespace_name "S.ESTO" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ESTR"></see>
    /// </summary>
    let ``S.ESTR`` = Namespaced_IRI.parse _namespace_name "S.ESTR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ESTSG"></see>
    /// </summary>
    let ``S.ESTSG`` = Namespaced_IRI.parse _namespace_name "S.ESTSG" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ESTSL"></see>
    /// </summary>
    let ``S.ESTSL`` = Namespaced_IRI.parse _namespace_name "S.ESTSL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ESTT"></see>
    /// </summary>
    let ``S.ESTT`` = Namespaced_IRI.parse _namespace_name "S.ESTT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ESTX"></see>
    /// </summary>
    let ``S.ESTX`` = Namespaced_IRI.parse _namespace_name "S.ESTX" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.FCL"></see>
    /// </summary>
    let ``S.FCL`` = Namespaced_IRI.parse _namespace_name "S.FCL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.FNDY"></see>
    /// </summary>
    let ``S.FNDY`` = Namespaced_IRI.parse _namespace_name "S.FNDY" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.FRM"></see>
    /// </summary>
    let ``S.FRM`` = Namespaced_IRI.parse _namespace_name "S.FRM" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.FRMQ"></see>
    /// </summary>
    let ``S.FRMQ`` = Namespaced_IRI.parse _namespace_name "S.FRMQ" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.FRMS"></see>
    /// </summary>
    let ``S.FRMS`` = Namespaced_IRI.parse _namespace_name "S.FRMS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.FRMT"></see>
    /// </summary>
    let ``S.FRMT`` = Namespaced_IRI.parse _namespace_name "S.FRMT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.FT"></see>
    /// </summary>
    let ``S.FT`` = Namespaced_IRI.parse _namespace_name "S.FT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.FY"></see>
    /// </summary>
    let ``S.FY`` = Namespaced_IRI.parse _namespace_name "S.FY" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.GATE"></see>
    /// </summary>
    let ``S.GATE`` = Namespaced_IRI.parse _namespace_name "S.GATE" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.GDN"></see>
    /// </summary>
    let ``S.GDN`` = Namespaced_IRI.parse _namespace_name "S.GDN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.GHAT"></see>
    /// </summary>
    let ``S.GHAT`` = Namespaced_IRI.parse _namespace_name "S.GHAT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.GHSE"></see>
    /// </summary>
    let ``S.GHSE`` = Namespaced_IRI.parse _namespace_name "S.GHSE" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.GOSP"></see>
    /// </summary>
    let ``S.GOSP`` = Namespaced_IRI.parse _namespace_name "S.GOSP" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.GOVL"></see>
    /// </summary>
    let ``S.GOVL`` = Namespaced_IRI.parse _namespace_name "S.GOVL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.GRVE"></see>
    /// </summary>
    let ``S.GRVE`` = Namespaced_IRI.parse _namespace_name "S.GRVE" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.HERM"></see>
    /// </summary>
    let ``S.HERM`` = Namespaced_IRI.parse _namespace_name "S.HERM" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.HLT"></see>
    /// </summary>
    let ``S.HLT`` = Namespaced_IRI.parse _namespace_name "S.HLT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.HMSD"></see>
    /// </summary>
    let ``S.HMSD`` = Namespaced_IRI.parse _namespace_name "S.HMSD" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.HSE"></see>
    /// </summary>
    let ``S.HSE`` = Namespaced_IRI.parse _namespace_name "S.HSE" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.HSEC"></see>
    /// </summary>
    let ``S.HSEC`` = Namespaced_IRI.parse _namespace_name "S.HSEC" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.HSP"></see>
    /// </summary>
    let ``S.HSP`` = Namespaced_IRI.parse _namespace_name "S.HSP" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.HSPC"></see>
    /// </summary>
    let ``S.HSPC`` = Namespaced_IRI.parse _namespace_name "S.HSPC" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.HSPD"></see>
    /// </summary>
    let ``S.HSPD`` = Namespaced_IRI.parse _namespace_name "S.HSPD" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.HSPL"></see>
    /// </summary>
    let ``S.HSPL`` = Namespaced_IRI.parse _namespace_name "S.HSPL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.HSTS"></see>
    /// </summary>
    let ``S.HSTS`` = Namespaced_IRI.parse _namespace_name "S.HSTS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.HTL"></see>
    /// </summary>
    let ``S.HTL`` = Namespaced_IRI.parse _namespace_name "S.HTL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.HUT"></see>
    /// </summary>
    let ``S.HUT`` = Namespaced_IRI.parse _namespace_name "S.HUT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.HUTS"></see>
    /// </summary>
    let ``S.HUTS`` = Namespaced_IRI.parse _namespace_name "S.HUTS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.INSM"></see>
    /// </summary>
    let ``S.INSM`` = Namespaced_IRI.parse _namespace_name "S.INSM" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ITTR"></see>
    /// </summary>
    let ``S.ITTR`` = Namespaced_IRI.parse _namespace_name "S.ITTR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.JTY"></see>
    /// </summary>
    let ``S.JTY`` = Namespaced_IRI.parse _namespace_name "S.JTY" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.LDNG"></see>
    /// </summary>
    let ``S.LDNG`` = Namespaced_IRI.parse _namespace_name "S.LDNG" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.LEPC"></see>
    /// </summary>
    let ``S.LEPC`` = Namespaced_IRI.parse _namespace_name "S.LEPC" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.LIBR"></see>
    /// </summary>
    let ``S.LIBR`` = Namespaced_IRI.parse _namespace_name "S.LIBR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.LNDF"></see>
    /// </summary>
    let ``S.LNDF`` = Namespaced_IRI.parse _namespace_name "S.LNDF" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.LOCK"></see>
    /// </summary>
    let ``S.LOCK`` = Namespaced_IRI.parse _namespace_name "S.LOCK" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.LTHSE"></see>
    /// </summary>
    let ``S.LTHSE`` = Namespaced_IRI.parse _namespace_name "S.LTHSE" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MALL"></see>
    /// </summary>
    let ``S.MALL`` = Namespaced_IRI.parse _namespace_name "S.MALL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MAR"></see>
    /// </summary>
    let ``S.MAR`` = Namespaced_IRI.parse _namespace_name "S.MAR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MFG"></see>
    /// </summary>
    let ``S.MFG`` = Namespaced_IRI.parse _namespace_name "S.MFG" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MFGB"></see>
    /// </summary>
    let ``S.MFGB`` = Namespaced_IRI.parse _namespace_name "S.MFGB" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MFGC"></see>
    /// </summary>
    let ``S.MFGC`` = Namespaced_IRI.parse _namespace_name "S.MFGC" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MFGCU"></see>
    /// </summary>
    let ``S.MFGCU`` = Namespaced_IRI.parse _namespace_name "S.MFGCU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MFGLM"></see>
    /// </summary>
    let ``S.MFGLM`` = Namespaced_IRI.parse _namespace_name "S.MFGLM" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MFGM"></see>
    /// </summary>
    let ``S.MFGM`` = Namespaced_IRI.parse _namespace_name "S.MFGM" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MFGPH"></see>
    /// </summary>
    let ``S.MFGPH`` = Namespaced_IRI.parse _namespace_name "S.MFGPH" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MFGQ"></see>
    /// </summary>
    let ``S.MFGQ`` = Namespaced_IRI.parse _namespace_name "S.MFGQ" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MFGSG"></see>
    /// </summary>
    let ``S.MFGSG`` = Namespaced_IRI.parse _namespace_name "S.MFGSG" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MKT"></see>
    /// </summary>
    let ``S.MKT`` = Namespaced_IRI.parse _namespace_name "S.MKT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ML"></see>
    /// </summary>
    let ``S.ML`` = Namespaced_IRI.parse _namespace_name "S.ML" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MLM"></see>
    /// </summary>
    let ``S.MLM`` = Namespaced_IRI.parse _namespace_name "S.MLM" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MLO"></see>
    /// </summary>
    let ``S.MLO`` = Namespaced_IRI.parse _namespace_name "S.MLO" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MLSG"></see>
    /// </summary>
    let ``S.MLSG`` = Namespaced_IRI.parse _namespace_name "S.MLSG" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MLSGQ"></see>
    /// </summary>
    let ``S.MLSGQ`` = Namespaced_IRI.parse _namespace_name "S.MLSGQ" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MLSW"></see>
    /// </summary>
    let ``S.MLSW`` = Namespaced_IRI.parse _namespace_name "S.MLSW" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MLWND"></see>
    /// </summary>
    let ``S.MLWND`` = Namespaced_IRI.parse _namespace_name "S.MLWND" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MLWTR"></see>
    /// </summary>
    let ``S.MLWTR`` = Namespaced_IRI.parse _namespace_name "S.MLWTR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MN"></see>
    /// </summary>
    let ``S.MN`` = Namespaced_IRI.parse _namespace_name "S.MN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MNAU"></see>
    /// </summary>
    let ``S.MNAU`` = Namespaced_IRI.parse _namespace_name "S.MNAU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MNC"></see>
    /// </summary>
    let ``S.MNC`` = Namespaced_IRI.parse _namespace_name "S.MNC" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MNCR"></see>
    /// </summary>
    let ``S.MNCR`` = Namespaced_IRI.parse _namespace_name "S.MNCR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MNCU"></see>
    /// </summary>
    let ``S.MNCU`` = Namespaced_IRI.parse _namespace_name "S.MNCU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MNDT"></see>
    /// </summary>
    let ``S.MNDT`` = Namespaced_IRI.parse _namespace_name "S.MNDT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MNFE"></see>
    /// </summary>
    let ``S.MNFE`` = Namespaced_IRI.parse _namespace_name "S.MNFE" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MNMT"></see>
    /// </summary>
    let ``S.MNMT`` = Namespaced_IRI.parse _namespace_name "S.MNMT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MNN"></see>
    /// </summary>
    let ``S.MNN`` = Namespaced_IRI.parse _namespace_name "S.MNN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MNNI"></see>
    /// </summary>
    let ``S.MNNI`` = Namespaced_IRI.parse _namespace_name "S.MNNI" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MNPB"></see>
    /// </summary>
    let ``S.MNPB`` = Namespaced_IRI.parse _namespace_name "S.MNPB" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MNPL"></see>
    /// </summary>
    let ``S.MNPL`` = Namespaced_IRI.parse _namespace_name "S.MNPL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MNQ"></see>
    /// </summary>
    let ``S.MNQ`` = Namespaced_IRI.parse _namespace_name "S.MNQ" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MNQR"></see>
    /// </summary>
    let ``S.MNQR`` = Namespaced_IRI.parse _namespace_name "S.MNQR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MNSN"></see>
    /// </summary>
    let ``S.MNSN`` = Namespaced_IRI.parse _namespace_name "S.MNSN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MOLE"></see>
    /// </summary>
    let ``S.MOLE`` = Namespaced_IRI.parse _namespace_name "S.MOLE" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MSQE"></see>
    /// </summary>
    let ``S.MSQE`` = Namespaced_IRI.parse _namespace_name "S.MSQE" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MSSN"></see>
    /// </summary>
    let ``S.MSSN`` = Namespaced_IRI.parse _namespace_name "S.MSSN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MSSNQ"></see>
    /// </summary>
    let ``S.MSSNQ`` = Namespaced_IRI.parse _namespace_name "S.MSSNQ" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MSTY"></see>
    /// </summary>
    let ``S.MSTY`` = Namespaced_IRI.parse _namespace_name "S.MSTY" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MTRO"></see>
    /// </summary>
    let ``S.MTRO`` = Namespaced_IRI.parse _namespace_name "S.MTRO" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MUS"></see>
    /// </summary>
    let ``S.MUS`` = Namespaced_IRI.parse _namespace_name "S.MUS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.NOV"></see>
    /// </summary>
    let ``S.NOV`` = Namespaced_IRI.parse _namespace_name "S.NOV" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.NSY"></see>
    /// </summary>
    let ``S.NSY`` = Namespaced_IRI.parse _namespace_name "S.NSY" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.OBPT"></see>
    /// </summary>
    let ``S.OBPT`` = Namespaced_IRI.parse _namespace_name "S.OBPT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.OBS"></see>
    /// </summary>
    let ``S.OBS`` = Namespaced_IRI.parse _namespace_name "S.OBS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.OBSR"></see>
    /// </summary>
    let ``S.OBSR`` = Namespaced_IRI.parse _namespace_name "S.OBSR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.OILJ"></see>
    /// </summary>
    let ``S.OILJ`` = Namespaced_IRI.parse _namespace_name "S.OILJ" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.OILQ"></see>
    /// </summary>
    let ``S.OILQ`` = Namespaced_IRI.parse _namespace_name "S.OILQ" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.OILR"></see>
    /// </summary>
    let ``S.OILR`` = Namespaced_IRI.parse _namespace_name "S.OILR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.OILT"></see>
    /// </summary>
    let ``S.OILT`` = Namespaced_IRI.parse _namespace_name "S.OILT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.OILW"></see>
    /// </summary>
    let ``S.OILW`` = Namespaced_IRI.parse _namespace_name "S.OILW" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.OPRA"></see>
    /// </summary>
    let ``S.OPRA`` = Namespaced_IRI.parse _namespace_name "S.OPRA" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PAL"></see>
    /// </summary>
    let ``S.PAL`` = Namespaced_IRI.parse _namespace_name "S.PAL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PGDA"></see>
    /// </summary>
    let ``S.PGDA`` = Namespaced_IRI.parse _namespace_name "S.PGDA" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PIER"></see>
    /// </summary>
    let ``S.PIER`` = Namespaced_IRI.parse _namespace_name "S.PIER" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PKLT"></see>
    /// </summary>
    let ``S.PKLT`` = Namespaced_IRI.parse _namespace_name "S.PKLT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PMPO"></see>
    /// </summary>
    let ``S.PMPO`` = Namespaced_IRI.parse _namespace_name "S.PMPO" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PMPW"></see>
    /// </summary>
    let ``S.PMPW`` = Namespaced_IRI.parse _namespace_name "S.PMPW" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PO"></see>
    /// </summary>
    let ``S.PO`` = Namespaced_IRI.parse _namespace_name "S.PO" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PP"></see>
    /// </summary>
    let ``S.PP`` = Namespaced_IRI.parse _namespace_name "S.PP" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PPQ"></see>
    /// </summary>
    let ``S.PPQ`` = Namespaced_IRI.parse _namespace_name "S.PPQ" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PRKGT"></see>
    /// </summary>
    let ``S.PRKGT`` = Namespaced_IRI.parse _namespace_name "S.PRKGT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PRKHQ"></see>
    /// </summary>
    let ``S.PRKHQ`` = Namespaced_IRI.parse _namespace_name "S.PRKHQ" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PRN"></see>
    /// </summary>
    let ``S.PRN`` = Namespaced_IRI.parse _namespace_name "S.PRN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PRNJ"></see>
    /// </summary>
    let ``S.PRNJ`` = Namespaced_IRI.parse _namespace_name "S.PRNJ" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PRNQ"></see>
    /// </summary>
    let ``S.PRNQ`` = Namespaced_IRI.parse _namespace_name "S.PRNQ" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PS"></see>
    /// </summary>
    let ``S.PS`` = Namespaced_IRI.parse _namespace_name "S.PS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PSH"></see>
    /// </summary>
    let ``S.PSH`` = Namespaced_IRI.parse _namespace_name "S.PSH" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PSTB"></see>
    /// </summary>
    let ``S.PSTB`` = Namespaced_IRI.parse _namespace_name "S.PSTB" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PSTC"></see>
    /// </summary>
    let ``S.PSTC`` = Namespaced_IRI.parse _namespace_name "S.PSTC" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PSTP"></see>
    /// </summary>
    let ``S.PSTP`` = Namespaced_IRI.parse _namespace_name "S.PSTP" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PYR"></see>
    /// </summary>
    let ``S.PYR`` = Namespaced_IRI.parse _namespace_name "S.PYR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PYRS"></see>
    /// </summary>
    let ``S.PYRS`` = Namespaced_IRI.parse _namespace_name "S.PYRS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.QUAY"></see>
    /// </summary>
    let ``S.QUAY`` = Namespaced_IRI.parse _namespace_name "S.QUAY" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.RDCR"></see>
    /// </summary>
    let ``S.RDCR`` = Namespaced_IRI.parse _namespace_name "S.RDCR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.RECG"></see>
    /// </summary>
    let ``S.RECG`` = Namespaced_IRI.parse _namespace_name "S.RECG" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.RECR"></see>
    /// </summary>
    let ``S.RECR`` = Namespaced_IRI.parse _namespace_name "S.RECR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.REST"></see>
    /// </summary>
    let ``S.REST`` = Namespaced_IRI.parse _namespace_name "S.REST" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.RET"></see>
    /// </summary>
    let ``S.RET`` = Namespaced_IRI.parse _namespace_name "S.RET" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.RHSE"></see>
    /// </summary>
    let ``S.RHSE`` = Namespaced_IRI.parse _namespace_name "S.RHSE" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.RKRY"></see>
    /// </summary>
    let ``S.RKRY`` = Namespaced_IRI.parse _namespace_name "S.RKRY" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.RLG"></see>
    /// </summary>
    let ``S.RLG`` = Namespaced_IRI.parse _namespace_name "S.RLG" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.RLGR"></see>
    /// </summary>
    let ``S.RLGR`` = Namespaced_IRI.parse _namespace_name "S.RLGR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.RNCH"></see>
    /// </summary>
    let ``S.RNCH`` = Namespaced_IRI.parse _namespace_name "S.RNCH" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.RSD"></see>
    /// </summary>
    let ``S.RSD`` = Namespaced_IRI.parse _namespace_name "S.RSD" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.RSGNL"></see>
    /// </summary>
    let ``S.RSGNL`` = Namespaced_IRI.parse _namespace_name "S.RSGNL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.RSRT"></see>
    /// </summary>
    let ``S.RSRT`` = Namespaced_IRI.parse _namespace_name "S.RSRT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.RSTN"></see>
    /// </summary>
    let ``S.RSTN`` = Namespaced_IRI.parse _namespace_name "S.RSTN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.RSTNQ"></see>
    /// </summary>
    let ``S.RSTNQ`` = Namespaced_IRI.parse _namespace_name "S.RSTNQ" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.RSTP"></see>
    /// </summary>
    let ``S.RSTP`` = Namespaced_IRI.parse _namespace_name "S.RSTP" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.RSTPQ"></see>
    /// </summary>
    let ``S.RSTPQ`` = Namespaced_IRI.parse _namespace_name "S.RSTPQ" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.RUIN"></see>
    /// </summary>
    let ``S.RUIN`` = Namespaced_IRI.parse _namespace_name "S.RUIN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.SCH"></see>
    /// </summary>
    let ``S.SCH`` = Namespaced_IRI.parse _namespace_name "S.SCH" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.SCHA"></see>
    /// </summary>
    let ``S.SCHA`` = Namespaced_IRI.parse _namespace_name "S.SCHA" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.SCHC"></see>
    /// </summary>
    let ``S.SCHC`` = Namespaced_IRI.parse _namespace_name "S.SCHC" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.SCHD"></see>
    /// </summary>
    let ``S.SCHD`` = Namespaced_IRI.parse _namespace_name "S.SCHD" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.SCHL"></see>
    /// </summary>
    let ``S.SCHL`` = Namespaced_IRI.parse _namespace_name "S.SCHL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.SCHM"></see>
    /// </summary>
    let ``S.SCHM`` = Namespaced_IRI.parse _namespace_name "S.SCHM" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.SCHN"></see>
    /// </summary>
    let ``S.SCHN`` = Namespaced_IRI.parse _namespace_name "S.SCHN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.SCHT"></see>
    /// </summary>
    let ``S.SCHT`` = Namespaced_IRI.parse _namespace_name "S.SCHT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.SECP"></see>
    /// </summary>
    let ``S.SECP`` = Namespaced_IRI.parse _namespace_name "S.SECP" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.SHPF"></see>
    /// </summary>
    let ``S.SHPF`` = Namespaced_IRI.parse _namespace_name "S.SHPF" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.SHRN"></see>
    /// </summary>
    let ``S.SHRN`` = Namespaced_IRI.parse _namespace_name "S.SHRN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.SHSE"></see>
    /// </summary>
    let ``S.SHSE`` = Namespaced_IRI.parse _namespace_name "S.SHSE" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.SLCE"></see>
    /// </summary>
    let ``S.SLCE`` = Namespaced_IRI.parse _namespace_name "S.SLCE" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.SNTR"></see>
    /// </summary>
    let ``S.SNTR`` = Namespaced_IRI.parse _namespace_name "S.SNTR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.SPA"></see>
    /// </summary>
    let ``S.SPA`` = Namespaced_IRI.parse _namespace_name "S.SPA" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.SPLY"></see>
    /// </summary>
    let ``S.SPLY`` = Namespaced_IRI.parse _namespace_name "S.SPLY" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.SQR"></see>
    /// </summary>
    let ``S.SQR`` = Namespaced_IRI.parse _namespace_name "S.SQR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.STBL"></see>
    /// </summary>
    let ``S.STBL`` = Namespaced_IRI.parse _namespace_name "S.STBL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.STDM"></see>
    /// </summary>
    let ``S.STDM`` = Namespaced_IRI.parse _namespace_name "S.STDM" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.STNB"></see>
    /// </summary>
    let ``S.STNB`` = Namespaced_IRI.parse _namespace_name "S.STNB" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.STNC"></see>
    /// </summary>
    let ``S.STNC`` = Namespaced_IRI.parse _namespace_name "S.STNC" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.STNE"></see>
    /// </summary>
    let ``S.STNE`` = Namespaced_IRI.parse _namespace_name "S.STNE" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.STNF"></see>
    /// </summary>
    let ``S.STNF`` = Namespaced_IRI.parse _namespace_name "S.STNF" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.STNI"></see>
    /// </summary>
    let ``S.STNI`` = Namespaced_IRI.parse _namespace_name "S.STNI" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.STNM"></see>
    /// </summary>
    let ``S.STNM`` = Namespaced_IRI.parse _namespace_name "S.STNM" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.STNR"></see>
    /// </summary>
    let ``S.STNR`` = Namespaced_IRI.parse _namespace_name "S.STNR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.STNS"></see>
    /// </summary>
    let ``S.STNS`` = Namespaced_IRI.parse _namespace_name "S.STNS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.STNW"></see>
    /// </summary>
    let ``S.STNW`` = Namespaced_IRI.parse _namespace_name "S.STNW" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.STPS"></see>
    /// </summary>
    let ``S.STPS`` = Namespaced_IRI.parse _namespace_name "S.STPS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.SWT"></see>
    /// </summary>
    let ``S.SWT`` = Namespaced_IRI.parse _namespace_name "S.SWT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.THTR"></see>
    /// </summary>
    let ``S.THTR`` = Namespaced_IRI.parse _namespace_name "S.THTR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.TMB"></see>
    /// </summary>
    let ``S.TMB`` = Namespaced_IRI.parse _namespace_name "S.TMB" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.TMPL"></see>
    /// </summary>
    let ``S.TMPL`` = Namespaced_IRI.parse _namespace_name "S.TMPL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.TNKD"></see>
    /// </summary>
    let ``S.TNKD`` = Namespaced_IRI.parse _namespace_name "S.TNKD" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.TOWR"></see>
    /// </summary>
    let ``S.TOWR`` = Namespaced_IRI.parse _namespace_name "S.TOWR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.TRANT"></see>
    /// </summary>
    let ``S.TRANT`` = Namespaced_IRI.parse _namespace_name "S.TRANT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.TRIG"></see>
    /// </summary>
    let ``S.TRIG`` = Namespaced_IRI.parse _namespace_name "S.TRIG" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.TRMO"></see>
    /// </summary>
    let ``S.TRMO`` = Namespaced_IRI.parse _namespace_name "S.TRMO" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.TWO"></see>
    /// </summary>
    let ``S.TWO`` = Namespaced_IRI.parse _namespace_name "S.TWO" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.UNIO"></see>
    /// </summary>
    let ``S.UNIO`` = Namespaced_IRI.parse _namespace_name "S.UNIO" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.UNIP"></see>
    /// </summary>
    let ``S.UNIP`` = Namespaced_IRI.parse _namespace_name "S.UNIP" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.UNIV"></see>
    /// </summary>
    let ``S.UNIV`` = Namespaced_IRI.parse _namespace_name "S.UNIV" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.USGE"></see>
    /// </summary>
    let ``S.USGE`` = Namespaced_IRI.parse _namespace_name "S.USGE" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.VETF"></see>
    /// </summary>
    let ``S.VETF`` = Namespaced_IRI.parse _namespace_name "S.VETF" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.WALL"></see>
    /// </summary>
    let ``S.WALL`` = Namespaced_IRI.parse _namespace_name "S.WALL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.WALLA"></see>
    /// </summary>
    let ``S.WALLA`` = Namespaced_IRI.parse _namespace_name "S.WALLA" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.WEIR"></see>
    /// </summary>
    let ``S.WEIR`` = Namespaced_IRI.parse _namespace_name "S.WEIR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.WHRF"></see>
    /// </summary>
    let ``S.WHRF`` = Namespaced_IRI.parse _namespace_name "S.WHRF" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.WRCK"></see>
    /// </summary>
    let ``S.WRCK`` = Namespaced_IRI.parse _namespace_name "S.WRCK" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.WTRW"></see>
    /// </summary>
    let ``S.WTRW`` = Namespaced_IRI.parse _namespace_name "S.WTRW" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ZNF"></see>
    /// </summary>
    let ``S.ZNF`` = Namespaced_IRI.parse _namespace_name "S.ZNF" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ZOO"></see>
    /// </summary>
    let ``S.ZOO`` = Namespaced_IRI.parse _namespace_name "S.ZOO" |> NamespacedName
    /// <summary>
    /// mountain, hill, rock, ...
    /// <see href="http://www.geonames.org/ontology#T"></see></summary>
    let T = Namespaced_IRI.parse _namespace_name "T" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.ASPH"></see>
    /// </summary>
    let ``T.ASPH`` = Namespaced_IRI.parse _namespace_name "T.ASPH" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.ATOL"></see>
    /// </summary>
    let ``T.ATOL`` = Namespaced_IRI.parse _namespace_name "T.ATOL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.BAR"></see>
    /// </summary>
    let ``T.BAR`` = Namespaced_IRI.parse _namespace_name "T.BAR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.BCH"></see>
    /// </summary>
    let ``T.BCH`` = Namespaced_IRI.parse _namespace_name "T.BCH" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.BCHS"></see>
    /// </summary>
    let ``T.BCHS`` = Namespaced_IRI.parse _namespace_name "T.BCHS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.BDLD"></see>
    /// </summary>
    let ``T.BDLD`` = Namespaced_IRI.parse _namespace_name "T.BDLD" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.BLDR"></see>
    /// </summary>
    let ``T.BLDR`` = Namespaced_IRI.parse _namespace_name "T.BLDR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.BLHL"></see>
    /// </summary>
    let ``T.BLHL`` = Namespaced_IRI.parse _namespace_name "T.BLHL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.BLOW"></see>
    /// </summary>
    let ``T.BLOW`` = Namespaced_IRI.parse _namespace_name "T.BLOW" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.BNCH"></see>
    /// </summary>
    let ``T.BNCH`` = Namespaced_IRI.parse _namespace_name "T.BNCH" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.BUTE"></see>
    /// </summary>
    let ``T.BUTE`` = Namespaced_IRI.parse _namespace_name "T.BUTE" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.CAPE"></see>
    /// </summary>
    let ``T.CAPE`` = Namespaced_IRI.parse _namespace_name "T.CAPE" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.CFT"></see>
    /// </summary>
    let ``T.CFT`` = Namespaced_IRI.parse _namespace_name "T.CFT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.CLDA"></see>
    /// </summary>
    let ``T.CLDA`` = Namespaced_IRI.parse _namespace_name "T.CLDA" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.CLF"></see>
    /// </summary>
    let ``T.CLF`` = Namespaced_IRI.parse _namespace_name "T.CLF" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.CNYN"></see>
    /// </summary>
    let ``T.CNYN`` = Namespaced_IRI.parse _namespace_name "T.CNYN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.CONE"></see>
    /// </summary>
    let ``T.CONE`` = Namespaced_IRI.parse _namespace_name "T.CONE" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.CRDR"></see>
    /// </summary>
    let ``T.CRDR`` = Namespaced_IRI.parse _namespace_name "T.CRDR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.CRQ"></see>
    /// </summary>
    let ``T.CRQ`` = Namespaced_IRI.parse _namespace_name "T.CRQ" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.CRQS"></see>
    /// </summary>
    let ``T.CRQS`` = Namespaced_IRI.parse _namespace_name "T.CRQS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.CRTR"></see>
    /// </summary>
    let ``T.CRTR`` = Namespaced_IRI.parse _namespace_name "T.CRTR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.CUET"></see>
    /// </summary>
    let ``T.CUET`` = Namespaced_IRI.parse _namespace_name "T.CUET" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.DLTA"></see>
    /// </summary>
    let ``T.DLTA`` = Namespaced_IRI.parse _namespace_name "T.DLTA" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.DPR"></see>
    /// </summary>
    let ``T.DPR`` = Namespaced_IRI.parse _namespace_name "T.DPR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.DSRT"></see>
    /// </summary>
    let ``T.DSRT`` = Namespaced_IRI.parse _namespace_name "T.DSRT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.DUNE"></see>
    /// </summary>
    let ``T.DUNE`` = Namespaced_IRI.parse _namespace_name "T.DUNE" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.DVD"></see>
    /// </summary>
    let ``T.DVD`` = Namespaced_IRI.parse _namespace_name "T.DVD" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.ERG"></see>
    /// </summary>
    let ``T.ERG`` = Namespaced_IRI.parse _namespace_name "T.ERG" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.FAN"></see>
    /// </summary>
    let ``T.FAN`` = Namespaced_IRI.parse _namespace_name "T.FAN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.FORD"></see>
    /// </summary>
    let ``T.FORD`` = Namespaced_IRI.parse _namespace_name "T.FORD" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.FSR"></see>
    /// </summary>
    let ``T.FSR`` = Namespaced_IRI.parse _namespace_name "T.FSR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.GAP"></see>
    /// </summary>
    let ``T.GAP`` = Namespaced_IRI.parse _namespace_name "T.GAP" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.GRGE"></see>
    /// </summary>
    let ``T.GRGE`` = Namespaced_IRI.parse _namespace_name "T.GRGE" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.HDLD"></see>
    /// </summary>
    let ``T.HDLD`` = Namespaced_IRI.parse _namespace_name "T.HDLD" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.HLL"></see>
    /// </summary>
    let ``T.HLL`` = Namespaced_IRI.parse _namespace_name "T.HLL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.HLLS"></see>
    /// </summary>
    let ``T.HLLS`` = Namespaced_IRI.parse _namespace_name "T.HLLS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.HMCK"></see>
    /// </summary>
    let ``T.HMCK`` = Namespaced_IRI.parse _namespace_name "T.HMCK" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.HMDA"></see>
    /// </summary>
    let ``T.HMDA`` = Namespaced_IRI.parse _namespace_name "T.HMDA" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.INTF"></see>
    /// </summary>
    let ``T.INTF`` = Namespaced_IRI.parse _namespace_name "T.INTF" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.ISL"></see>
    /// </summary>
    let ``T.ISL`` = Namespaced_IRI.parse _namespace_name "T.ISL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.ISLET"></see>
    /// </summary>
    let ``T.ISLET`` = Namespaced_IRI.parse _namespace_name "T.ISLET" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.ISLF"></see>
    /// </summary>
    let ``T.ISLF`` = Namespaced_IRI.parse _namespace_name "T.ISLF" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.ISLM"></see>
    /// </summary>
    let ``T.ISLM`` = Namespaced_IRI.parse _namespace_name "T.ISLM" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.ISLS"></see>
    /// </summary>
    let ``T.ISLS`` = Namespaced_IRI.parse _namespace_name "T.ISLS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.ISLT"></see>
    /// </summary>
    let ``T.ISLT`` = Namespaced_IRI.parse _namespace_name "T.ISLT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.ISLX"></see>
    /// </summary>
    let ``T.ISLX`` = Namespaced_IRI.parse _namespace_name "T.ISLX" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.ISTH"></see>
    /// </summary>
    let ``T.ISTH`` = Namespaced_IRI.parse _namespace_name "T.ISTH" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.KRST"></see>
    /// </summary>
    let ``T.KRST`` = Namespaced_IRI.parse _namespace_name "T.KRST" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.LAVA"></see>
    /// </summary>
    let ``T.LAVA`` = Namespaced_IRI.parse _namespace_name "T.LAVA" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.LEV"></see>
    /// </summary>
    let ``T.LEV`` = Namespaced_IRI.parse _namespace_name "T.LEV" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.MESA"></see>
    /// </summary>
    let ``T.MESA`` = Namespaced_IRI.parse _namespace_name "T.MESA" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.MND"></see>
    /// </summary>
    let ``T.MND`` = Namespaced_IRI.parse _namespace_name "T.MND" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.MRN"></see>
    /// </summary>
    let ``T.MRN`` = Namespaced_IRI.parse _namespace_name "T.MRN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.MT"></see>
    /// </summary>
    let ``T.MT`` = Namespaced_IRI.parse _namespace_name "T.MT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.MTS"></see>
    /// </summary>
    let ``T.MTS`` = Namespaced_IRI.parse _namespace_name "T.MTS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.NKM"></see>
    /// </summary>
    let ``T.NKM`` = Namespaced_IRI.parse _namespace_name "T.NKM" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.NTK"></see>
    /// </summary>
    let ``T.NTK`` = Namespaced_IRI.parse _namespace_name "T.NTK" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.NTKS"></see>
    /// </summary>
    let ``T.NTKS`` = Namespaced_IRI.parse _namespace_name "T.NTKS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.PAN"></see>
    /// </summary>
    let ``T.PAN`` = Namespaced_IRI.parse _namespace_name "T.PAN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.PANS"></see>
    /// </summary>
    let ``T.PANS`` = Namespaced_IRI.parse _namespace_name "T.PANS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.PASS"></see>
    /// </summary>
    let ``T.PASS`` = Namespaced_IRI.parse _namespace_name "T.PASS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.PEN"></see>
    /// </summary>
    let ``T.PEN`` = Namespaced_IRI.parse _namespace_name "T.PEN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.PENX"></see>
    /// </summary>
    let ``T.PENX`` = Namespaced_IRI.parse _namespace_name "T.PENX" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.PK"></see>
    /// </summary>
    let ``T.PK`` = Namespaced_IRI.parse _namespace_name "T.PK" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.PKS"></see>
    /// </summary>
    let ``T.PKS`` = Namespaced_IRI.parse _namespace_name "T.PKS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.PLAT"></see>
    /// </summary>
    let ``T.PLAT`` = Namespaced_IRI.parse _namespace_name "T.PLAT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.PLATX"></see>
    /// </summary>
    let ``T.PLATX`` = Namespaced_IRI.parse _namespace_name "T.PLATX" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.PLDR"></see>
    /// </summary>
    let ``T.PLDR`` = Namespaced_IRI.parse _namespace_name "T.PLDR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.PLN"></see>
    /// </summary>
    let ``T.PLN`` = Namespaced_IRI.parse _namespace_name "T.PLN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.PLNX"></see>
    /// </summary>
    let ``T.PLNX`` = Namespaced_IRI.parse _namespace_name "T.PLNX" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.PROM"></see>
    /// </summary>
    let ``T.PROM`` = Namespaced_IRI.parse _namespace_name "T.PROM" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.PT"></see>
    /// </summary>
    let ``T.PT`` = Namespaced_IRI.parse _namespace_name "T.PT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.PTS"></see>
    /// </summary>
    let ``T.PTS`` = Namespaced_IRI.parse _namespace_name "T.PTS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.RDGB"></see>
    /// </summary>
    let ``T.RDGB`` = Namespaced_IRI.parse _namespace_name "T.RDGB" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.RDGE"></see>
    /// </summary>
    let ``T.RDGE`` = Namespaced_IRI.parse _namespace_name "T.RDGE" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.REG"></see>
    /// </summary>
    let ``T.REG`` = Namespaced_IRI.parse _namespace_name "T.REG" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.RK"></see>
    /// </summary>
    let ``T.RK`` = Namespaced_IRI.parse _namespace_name "T.RK" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.RKFL"></see>
    /// </summary>
    let ``T.RKFL`` = Namespaced_IRI.parse _namespace_name "T.RKFL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.RKS"></see>
    /// </summary>
    let ``T.RKS`` = Namespaced_IRI.parse _namespace_name "T.RKS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.SAND"></see>
    /// </summary>
    let ``T.SAND`` = Namespaced_IRI.parse _namespace_name "T.SAND" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.SBED"></see>
    /// </summary>
    let ``T.SBED`` = Namespaced_IRI.parse _namespace_name "T.SBED" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.SCRP"></see>
    /// </summary>
    let ``T.SCRP`` = Namespaced_IRI.parse _namespace_name "T.SCRP" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.SDL"></see>
    /// </summary>
    let ``T.SDL`` = Namespaced_IRI.parse _namespace_name "T.SDL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.SHOR"></see>
    /// </summary>
    let ``T.SHOR`` = Namespaced_IRI.parse _namespace_name "T.SHOR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.SINK"></see>
    /// </summary>
    let ``T.SINK`` = Namespaced_IRI.parse _namespace_name "T.SINK" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.SLID"></see>
    /// </summary>
    let ``T.SLID`` = Namespaced_IRI.parse _namespace_name "T.SLID" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.SLP"></see>
    /// </summary>
    let ``T.SLP`` = Namespaced_IRI.parse _namespace_name "T.SLP" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.SPIT"></see>
    /// </summary>
    let ``T.SPIT`` = Namespaced_IRI.parse _namespace_name "T.SPIT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.SPUR"></see>
    /// </summary>
    let ``T.SPUR`` = Namespaced_IRI.parse _namespace_name "T.SPUR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.TAL"></see>
    /// </summary>
    let ``T.TAL`` = Namespaced_IRI.parse _namespace_name "T.TAL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.TRGD"></see>
    /// </summary>
    let ``T.TRGD`` = Namespaced_IRI.parse _namespace_name "T.TRGD" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.TRR"></see>
    /// </summary>
    let ``T.TRR`` = Namespaced_IRI.parse _namespace_name "T.TRR" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.UPLD"></see>
    /// </summary>
    let ``T.UPLD`` = Namespaced_IRI.parse _namespace_name "T.UPLD" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.VAL"></see>
    /// </summary>
    let ``T.VAL`` = Namespaced_IRI.parse _namespace_name "T.VAL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.VALG"></see>
    /// </summary>
    let ``T.VALG`` = Namespaced_IRI.parse _namespace_name "T.VALG" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.VALS"></see>
    /// </summary>
    let ``T.VALS`` = Namespaced_IRI.parse _namespace_name "T.VALS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.VALX"></see>
    /// </summary>
    let ``T.VALX`` = Namespaced_IRI.parse _namespace_name "T.VALX" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.VLC"></see>
    /// </summary>
    let ``T.VLC`` = Namespaced_IRI.parse _namespace_name "T.VLC" |> NamespacedName
    /// <summary>
    /// undersea
    /// <see href="http://www.geonames.org/ontology#U"></see></summary>
    let U = Namespaced_IRI.parse _namespace_name "U" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.APNU"></see>
    /// </summary>
    let ``U.APNU`` = Namespaced_IRI.parse _namespace_name "U.APNU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.ARCU"></see>
    /// </summary>
    let ``U.ARCU`` = Namespaced_IRI.parse _namespace_name "U.ARCU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.ARRU"></see>
    /// </summary>
    let ``U.ARRU`` = Namespaced_IRI.parse _namespace_name "U.ARRU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.BDLU"></see>
    /// </summary>
    let ``U.BDLU`` = Namespaced_IRI.parse _namespace_name "U.BDLU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.BKSU"></see>
    /// </summary>
    let ``U.BKSU`` = Namespaced_IRI.parse _namespace_name "U.BKSU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.BNCU"></see>
    /// </summary>
    let ``U.BNCU`` = Namespaced_IRI.parse _namespace_name "U.BNCU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.BNKU"></see>
    /// </summary>
    let ``U.BNKU`` = Namespaced_IRI.parse _namespace_name "U.BNKU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.BSNU"></see>
    /// </summary>
    let ``U.BSNU`` = Namespaced_IRI.parse _namespace_name "U.BSNU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.CDAU"></see>
    /// </summary>
    let ``U.CDAU`` = Namespaced_IRI.parse _namespace_name "U.CDAU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.CNSU"></see>
    /// </summary>
    let ``U.CNSU`` = Namespaced_IRI.parse _namespace_name "U.CNSU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.CNYU"></see>
    /// </summary>
    let ``U.CNYU`` = Namespaced_IRI.parse _namespace_name "U.CNYU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.CRSU"></see>
    /// </summary>
    let ``U.CRSU`` = Namespaced_IRI.parse _namespace_name "U.CRSU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.DEPU"></see>
    /// </summary>
    let ``U.DEPU`` = Namespaced_IRI.parse _namespace_name "U.DEPU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.EDGU"></see>
    /// </summary>
    let ``U.EDGU`` = Namespaced_IRI.parse _namespace_name "U.EDGU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.ESCU"></see>
    /// </summary>
    let ``U.ESCU`` = Namespaced_IRI.parse _namespace_name "U.ESCU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.FANU"></see>
    /// </summary>
    let ``U.FANU`` = Namespaced_IRI.parse _namespace_name "U.FANU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.FLTU"></see>
    /// </summary>
    let ``U.FLTU`` = Namespaced_IRI.parse _namespace_name "U.FLTU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.FRKU"></see>
    /// </summary>
    let ``U.FRKU`` = Namespaced_IRI.parse _namespace_name "U.FRKU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.FRSU"></see>
    /// </summary>
    let ``U.FRSU`` = Namespaced_IRI.parse _namespace_name "U.FRSU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.FRZU"></see>
    /// </summary>
    let ``U.FRZU`` = Namespaced_IRI.parse _namespace_name "U.FRZU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.FURU"></see>
    /// </summary>
    let ``U.FURU`` = Namespaced_IRI.parse _namespace_name "U.FURU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.GAPU"></see>
    /// </summary>
    let ``U.GAPU`` = Namespaced_IRI.parse _namespace_name "U.GAPU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.GLYU"></see>
    /// </summary>
    let ``U.GLYU`` = Namespaced_IRI.parse _namespace_name "U.GLYU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.HLLU"></see>
    /// </summary>
    let ``U.HLLU`` = Namespaced_IRI.parse _namespace_name "U.HLLU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.HLSU"></see>
    /// </summary>
    let ``U.HLSU`` = Namespaced_IRI.parse _namespace_name "U.HLSU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.HOLU"></see>
    /// </summary>
    let ``U.HOLU`` = Namespaced_IRI.parse _namespace_name "U.HOLU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.KNLU"></see>
    /// </summary>
    let ``U.KNLU`` = Namespaced_IRI.parse _namespace_name "U.KNLU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.KNSU"></see>
    /// </summary>
    let ``U.KNSU`` = Namespaced_IRI.parse _namespace_name "U.KNSU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.LDGU"></see>
    /// </summary>
    let ``U.LDGU`` = Namespaced_IRI.parse _namespace_name "U.LDGU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.LEVU"></see>
    /// </summary>
    let ``U.LEVU`` = Namespaced_IRI.parse _namespace_name "U.LEVU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.MDVU"></see>
    /// </summary>
    let ``U.MDVU`` = Namespaced_IRI.parse _namespace_name "U.MDVU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.MESU"></see>
    /// </summary>
    let ``U.MESU`` = Namespaced_IRI.parse _namespace_name "U.MESU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.MNDU"></see>
    /// </summary>
    let ``U.MNDU`` = Namespaced_IRI.parse _namespace_name "U.MNDU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.MOTU"></see>
    /// </summary>
    let ``U.MOTU`` = Namespaced_IRI.parse _namespace_name "U.MOTU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.MTSU"></see>
    /// </summary>
    let ``U.MTSU`` = Namespaced_IRI.parse _namespace_name "U.MTSU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.MTU"></see>
    /// </summary>
    let ``U.MTU`` = Namespaced_IRI.parse _namespace_name "U.MTU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.PKSU"></see>
    /// </summary>
    let ``U.PKSU`` = Namespaced_IRI.parse _namespace_name "U.PKSU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.PKU"></see>
    /// </summary>
    let ``U.PKU`` = Namespaced_IRI.parse _namespace_name "U.PKU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.PLFU"></see>
    /// </summary>
    let ``U.PLFU`` = Namespaced_IRI.parse _namespace_name "U.PLFU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.PLNU"></see>
    /// </summary>
    let ``U.PLNU`` = Namespaced_IRI.parse _namespace_name "U.PLNU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.PLTU"></see>
    /// </summary>
    let ``U.PLTU`` = Namespaced_IRI.parse _namespace_name "U.PLTU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.PNLU"></see>
    /// </summary>
    let ``U.PNLU`` = Namespaced_IRI.parse _namespace_name "U.PNLU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.PRVU"></see>
    /// </summary>
    let ``U.PRVU`` = Namespaced_IRI.parse _namespace_name "U.PRVU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.RAVU"></see>
    /// </summary>
    let ``U.RAVU`` = Namespaced_IRI.parse _namespace_name "U.RAVU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.RDGU"></see>
    /// </summary>
    let ``U.RDGU`` = Namespaced_IRI.parse _namespace_name "U.RDGU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.RDSU"></see>
    /// </summary>
    let ``U.RDSU`` = Namespaced_IRI.parse _namespace_name "U.RDSU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.RFSU"></see>
    /// </summary>
    let ``U.RFSU`` = Namespaced_IRI.parse _namespace_name "U.RFSU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.RFU"></see>
    /// </summary>
    let ``U.RFU`` = Namespaced_IRI.parse _namespace_name "U.RFU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.RISU"></see>
    /// </summary>
    let ``U.RISU`` = Namespaced_IRI.parse _namespace_name "U.RISU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.RMPU"></see>
    /// </summary>
    let ``U.RMPU`` = Namespaced_IRI.parse _namespace_name "U.RMPU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.RNGU"></see>
    /// </summary>
    let ``U.RNGU`` = Namespaced_IRI.parse _namespace_name "U.RNGU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.SCNU"></see>
    /// </summary>
    let ``U.SCNU`` = Namespaced_IRI.parse _namespace_name "U.SCNU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.SCSU"></see>
    /// </summary>
    let ``U.SCSU`` = Namespaced_IRI.parse _namespace_name "U.SCSU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.SDLU"></see>
    /// </summary>
    let ``U.SDLU`` = Namespaced_IRI.parse _namespace_name "U.SDLU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.SHFU"></see>
    /// </summary>
    let ``U.SHFU`` = Namespaced_IRI.parse _namespace_name "U.SHFU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.SHLU"></see>
    /// </summary>
    let ``U.SHLU`` = Namespaced_IRI.parse _namespace_name "U.SHLU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.SHSU"></see>
    /// </summary>
    let ``U.SHSU`` = Namespaced_IRI.parse _namespace_name "U.SHSU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.SHVU"></see>
    /// </summary>
    let ``U.SHVU`` = Namespaced_IRI.parse _namespace_name "U.SHVU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.SILU"></see>
    /// </summary>
    let ``U.SILU`` = Namespaced_IRI.parse _namespace_name "U.SILU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.SLPU"></see>
    /// </summary>
    let ``U.SLPU`` = Namespaced_IRI.parse _namespace_name "U.SLPU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.SMSU"></see>
    /// </summary>
    let ``U.SMSU`` = Namespaced_IRI.parse _namespace_name "U.SMSU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.SMU"></see>
    /// </summary>
    let ``U.SMU`` = Namespaced_IRI.parse _namespace_name "U.SMU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.SPRU"></see>
    /// </summary>
    let ``U.SPRU`` = Namespaced_IRI.parse _namespace_name "U.SPRU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.TERU"></see>
    /// </summary>
    let ``U.TERU`` = Namespaced_IRI.parse _namespace_name "U.TERU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.TMSU"></see>
    /// </summary>
    let ``U.TMSU`` = Namespaced_IRI.parse _namespace_name "U.TMSU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.TMTU"></see>
    /// </summary>
    let ``U.TMTU`` = Namespaced_IRI.parse _namespace_name "U.TMTU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.TNGU"></see>
    /// </summary>
    let ``U.TNGU`` = Namespaced_IRI.parse _namespace_name "U.TNGU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.TRGU"></see>
    /// </summary>
    let ``U.TRGU`` = Namespaced_IRI.parse _namespace_name "U.TRGU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.TRNU"></see>
    /// </summary>
    let ``U.TRNU`` = Namespaced_IRI.parse _namespace_name "U.TRNU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.VALU"></see>
    /// </summary>
    let ``U.VALU`` = Namespaced_IRI.parse _namespace_name "U.VALU" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.VLSU"></see>
    /// </summary>
    let ``U.VLSU`` = Namespaced_IRI.parse _namespace_name "U.VLSU" |> NamespacedName
    /// <summary>
    /// forest, heath, ...
    /// <see href="http://www.geonames.org/ontology#V"></see></summary>
    let V = Namespaced_IRI.parse _namespace_name "V" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#V.BUSH"></see>
    /// </summary>
    let ``V.BUSH`` = Namespaced_IRI.parse _namespace_name "V.BUSH" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#V.CULT"></see>
    /// </summary>
    let ``V.CULT`` = Namespaced_IRI.parse _namespace_name "V.CULT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#V.FRST"></see>
    /// </summary>
    let ``V.FRST`` = Namespaced_IRI.parse _namespace_name "V.FRST" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#V.FRSTF"></see>
    /// </summary>
    let ``V.FRSTF`` = Namespaced_IRI.parse _namespace_name "V.FRSTF" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#V.GRSLD"></see>
    /// </summary>
    let ``V.GRSLD`` = Namespaced_IRI.parse _namespace_name "V.GRSLD" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#V.GRVC"></see>
    /// </summary>
    let ``V.GRVC`` = Namespaced_IRI.parse _namespace_name "V.GRVC" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#V.GRVO"></see>
    /// </summary>
    let ``V.GRVO`` = Namespaced_IRI.parse _namespace_name "V.GRVO" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#V.GRVP"></see>
    /// </summary>
    let ``V.GRVP`` = Namespaced_IRI.parse _namespace_name "V.GRVP" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#V.GRVPN"></see>
    /// </summary>
    let ``V.GRVPN`` = Namespaced_IRI.parse _namespace_name "V.GRVPN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#V.HTH"></see>
    /// </summary>
    let ``V.HTH`` = Namespaced_IRI.parse _namespace_name "V.HTH" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#V.MDW"></see>
    /// </summary>
    let ``V.MDW`` = Namespaced_IRI.parse _namespace_name "V.MDW" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#V.OCH"></see>
    /// </summary>
    let ``V.OCH`` = Namespaced_IRI.parse _namespace_name "V.OCH" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#V.SCRB"></see>
    /// </summary>
    let ``V.SCRB`` = Namespaced_IRI.parse _namespace_name "V.SCRB" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#V.TREE"></see>
    /// </summary>
    let ``V.TREE`` = Namespaced_IRI.parse _namespace_name "V.TREE" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#V.TUND"></see>
    /// </summary>
    let ``V.TUND`` = Namespaced_IRI.parse _namespace_name "V.TUND" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#V.VIN"></see>
    /// </summary>
    let ``V.VIN`` = Namespaced_IRI.parse _namespace_name "V.VIN" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#V.VINS"></see>
    /// </summary>
    let ``V.VINS`` = Namespaced_IRI.parse _namespace_name "V.VINS" |> NamespacedName

    /// <summary>
    /// A Wikipedia article
    /// <see href="http://www.geonames.org/ontology#WikipediaArticle"></see></summary>
    let WikipediaArticle =
        Namespaced_IRI.parse _namespace_name "WikipediaArticle" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#alternateName"></see>
    /// </summary>
    let alternateName =
        Namespaced_IRI.parse _namespace_name "alternateName" |> NamespacedName

    /// <summary>
    /// Links to an RDF document containing the descriptions of children features
    /// <see href="http://www.geonames.org/ontology#childrenFeatures"></see></summary>
    let childrenFeatures =
        Namespaced_IRI.parse _namespace_name "childrenFeatures" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#colloquialName"></see>
    /// </summary>
    let colloquialName =
        Namespaced_IRI.parse _namespace_name "colloquialName" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#historicalName"></see>
    /// </summary>
    let historicalName =
        Namespaced_IRI.parse _namespace_name "historicalName" |> NamespacedName

    /// <summary>
    /// Indicates that the subject resource is located in the object feature
    /// <see href="http://www.geonames.org/ontology#locatedIn"></see></summary>
    let locatedIn = Namespaced_IRI.parse _namespace_name "locatedIn" |> NamespacedName

    /// <summary>
    /// A geonames map centered on the feature.
    /// <see href="http://www.geonames.org/ontology#locationMap"></see></summary>
    let locationMap =
        Namespaced_IRI.parse _namespace_name "locationMap" |> NamespacedName

    /// <summary>
    /// A feature close to the reference feature
    /// <see href="http://www.geonames.org/ontology#nearby"></see></summary>
    let nearby = Namespaced_IRI.parse _namespace_name "nearby" |> NamespacedName

    /// <summary>
    /// Links to an RDF document containing the descriptions of nearby features
    /// <see href="http://www.geonames.org/ontology#nearbyFeatures"></see></summary>
    let nearbyFeatures =
        Namespaced_IRI.parse _namespace_name "nearbyFeatures" |> NamespacedName

    /// <summary>
    /// A feature sharing a common boarder with the reference feature
    /// <see href="http://www.geonames.org/ontology#neighbour"></see></summary>
    let neighbour = Namespaced_IRI.parse _namespace_name "neighbour" |> NamespacedName

    /// <summary>
    /// Links to an RDF document containing the descriptions of neighbouring features. Applies when the feature has definite boarders.
    /// <see href="http://www.geonames.org/ontology#neighbouringFeatures"></see></summary>
    let neighbouringFeatures =
        Namespaced_IRI.parse _namespace_name "neighbouringFeatures" |> NamespacedName

    /// <summary>
    /// A name in an official local language
    /// <see href="http://www.geonames.org/ontology#officialName"></see></summary>
    let officialName =
        Namespaced_IRI.parse _namespace_name "officialName" |> NamespacedName

    /// <summary>
    /// A feature parent of the current one, in either administrative or physical subdivision.
    /// <see href="http://www.geonames.org/ontology#parentFeature"></see></summary>
    let parentFeature =
        Namespaced_IRI.parse _namespace_name "parentFeature" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#parentCountry"></see>
    /// </summary>
    let parentCountry =
        Namespaced_IRI.parse _namespace_name "parentCountry" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#postalCode"></see>
    /// </summary>
    let postalCode = Namespaced_IRI.parse _namespace_name "postalCode" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#shortName"></see>
    /// </summary>
    let shortName = Namespaced_IRI.parse _namespace_name "shortName" |> NamespacedName

    /// <summary>
    /// A Wikipedia article of which subject is the resource.
    /// <see href="http://www.geonames.org/ontology#wikipediaArticle"></see></summary>
    let wikipediaArticle =
        Namespaced_IRI.parse _namespace_name "wikipediaArticle" |> NamespacedName

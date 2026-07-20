namespace http.www.geonames.org.ontology.hash

open DoxAletheia

module geonames =
    let _namespace_name = "http://www.geonames.org/ontology#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#Marc-Wick"></see>
    /// </summary>
    let ``Marc-Wick`` = _prefix "Marc-Wick"
    /// <summary>
    /// country, state, region ...
    /// <see href="http://www.geonames.org/ontology#A"></see></summary>
    let A = _prefix "A"
    /// <summary>
    /// A class of features.
    /// <see href="http://www.geonames.org/ontology#Class"></see></summary>
    let Class = _prefix "Class"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.ADM1"></see>
    /// </summary>
    let ``A.ADM1`` = _prefix "A.ADM1"
    /// <summary>
    /// A feature code.
    /// <see href="http://www.geonames.org/ontology#Code"></see></summary>
    let Code = _prefix "Code"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.ADM1H"></see>
    /// </summary>
    let ``A.ADM1H`` = _prefix "A.ADM1H"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.ADM2"></see>
    /// </summary>
    let ``A.ADM2`` = _prefix "A.ADM2"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.ADM2H"></see>
    /// </summary>
    let ``A.ADM2H`` = _prefix "A.ADM2H"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.ADM3"></see>
    /// </summary>
    let ``A.ADM3`` = _prefix "A.ADM3"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.ADM3H"></see>
    /// </summary>
    let ``A.ADM3H`` = _prefix "A.ADM3H"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.ADM4"></see>
    /// </summary>
    let ``A.ADM4`` = _prefix "A.ADM4"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.ADM4H"></see>
    /// </summary>
    let ``A.ADM4H`` = _prefix "A.ADM4H"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.ADM5"></see>
    /// </summary>
    let ``A.ADM5`` = _prefix "A.ADM5"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.ADMD"></see>
    /// </summary>
    let ``A.ADMD`` = _prefix "A.ADMD"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.ADMH"></see>
    /// </summary>
    let ``A.ADMH`` = _prefix "A.ADMH"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.LTER"></see>
    /// </summary>
    let ``A.LTER`` = _prefix "A.LTER"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.PCL"></see>
    /// </summary>
    let ``A.PCL`` = _prefix "A.PCL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.PCLD"></see>
    /// </summary>
    let ``A.PCLD`` = _prefix "A.PCLD"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.PCLF"></see>
    /// </summary>
    let ``A.PCLF`` = _prefix "A.PCLF"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.PCLH"></see>
    /// </summary>
    let ``A.PCLH`` = _prefix "A.PCLH"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.PCLI"></see>
    /// </summary>
    let ``A.PCLI`` = _prefix "A.PCLI"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.PCLIX"></see>
    /// </summary>
    let ``A.PCLIX`` = _prefix "A.PCLIX"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.PCLS"></see>
    /// </summary>
    let ``A.PCLS`` = _prefix "A.PCLS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.PPCLH"></see>
    /// </summary>
    let ``A.PPCLH`` = _prefix "A.PPCLH"
    /// <summary>
    /// city, village,...
    /// <see href="http://www.geonames.org/ontology#P"></see></summary>
    let P = _prefix "P"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.PPLH"></see>
    /// </summary>
    let ``A.PPLH`` = _prefix "A.PPLH"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.PRSH"></see>
    /// </summary>
    let ``A.PRSH`` = _prefix "A.PRSH"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.TERR"></see>
    /// </summary>
    let ``A.TERR`` = _prefix "A.TERR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.ZN"></see>
    /// </summary>
    let ``A.ZN`` = _prefix "A.ZN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#A.ZNB"></see>
    /// </summary>
    let ``A.ZNB`` = _prefix "A.ZNB"
    /// <summary>
    /// A geographical feature
    /// <see href="http://www.geonames.org/ontology#Feature"></see></summary>
    let Feature = _prefix "Feature"
    /// <summary>
    /// A feature described in geonames database, uniquely defined by its geonames identifier
    /// <see href="http://www.geonames.org/ontology#GeonamesFeature"></see></summary>
    let GeonamesFeature = _prefix "GeonamesFeature"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#population"></see>
    /// </summary>
    let population = _prefix "population"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#geonamesID"></see>
    /// </summary>
    let geonamesID = _prefix "geonamesID"
    /// <summary>
    /// The main international name of a feature. The value has no xml:lang tag.
    /// <see href="http://www.geonames.org/ontology#name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// The main category of the feature, as defined in geonames taxonomy.
    /// <see href="http://www.geonames.org/ontology#featureClass"></see></summary>
    let featureClass = _prefix "featureClass"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#parentADM1"></see>
    /// </summary>
    let parentADM1 = _prefix "parentADM1"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#parentADM3"></see>
    /// </summary>
    let parentADM3 = _prefix "parentADM3"
    /// <summary>
    /// The countryCode value for a Geoname Feature is equal to the countryCode value of the parentCountry value.
    /// A two letters country code in the ISO 3166 list
    /// <see href="http://www.geonames.org/ontology#countryCode"></see></summary>
    let countryCode = _prefix "countryCode"
    /// <summary>
    /// Type of the feature, as defined in geonames taxonomy.
    /// <see href="http://www.geonames.org/ontology#featureCode"></see></summary>
    let featureCode = _prefix "featureCode"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#parentADM2"></see>
    /// </summary>
    let parentADM2 = _prefix "parentADM2"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#parentADM4"></see>
    /// </summary>
    let parentADM4 = _prefix "parentADM4"
    /// <summary>
    /// stream, lake, ...
    /// <see href="http://www.geonames.org/ontology#H"></see></summary>
    let H = _prefix "H"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.AIRS"></see>
    /// </summary>
    let ``H.AIRS`` = _prefix "H.AIRS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.ANCH"></see>
    /// </summary>
    let ``H.ANCH`` = _prefix "H.ANCH"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.BAY"></see>
    /// </summary>
    let ``H.BAY`` = _prefix "H.BAY"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.BAYS"></see>
    /// </summary>
    let ``H.BAYS`` = _prefix "H.BAYS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.BGHT"></see>
    /// </summary>
    let ``H.BGHT`` = _prefix "H.BGHT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.BNK"></see>
    /// </summary>
    let ``H.BNK`` = _prefix "H.BNK"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.BNKR"></see>
    /// </summary>
    let ``H.BNKR`` = _prefix "H.BNKR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.BNKX"></see>
    /// </summary>
    let ``H.BNKX`` = _prefix "H.BNKX"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.BOG"></see>
    /// </summary>
    let ``H.BOG`` = _prefix "H.BOG"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.CAPG"></see>
    /// </summary>
    let ``H.CAPG`` = _prefix "H.CAPG"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.CHN"></see>
    /// </summary>
    let ``H.CHN`` = _prefix "H.CHN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.CHNL"></see>
    /// </summary>
    let ``H.CHNL`` = _prefix "H.CHNL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.CHNM"></see>
    /// </summary>
    let ``H.CHNM`` = _prefix "H.CHNM"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.CHNN"></see>
    /// </summary>
    let ``H.CHNN`` = _prefix "H.CHNN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.CNFL"></see>
    /// </summary>
    let ``H.CNFL`` = _prefix "H.CNFL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.CNL"></see>
    /// </summary>
    let ``H.CNL`` = _prefix "H.CNL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.CNLA"></see>
    /// </summary>
    let ``H.CNLA`` = _prefix "H.CNLA"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.CNLB"></see>
    /// </summary>
    let ``H.CNLB`` = _prefix "H.CNLB"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.CNLD"></see>
    /// </summary>
    let ``H.CNLD`` = _prefix "H.CNLD"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.CNLI"></see>
    /// </summary>
    let ``H.CNLI`` = _prefix "H.CNLI"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.CNLN"></see>
    /// </summary>
    let ``H.CNLN`` = _prefix "H.CNLN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.CNLQ"></see>
    /// </summary>
    let ``H.CNLQ`` = _prefix "H.CNLQ"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.CNLSB"></see>
    /// </summary>
    let ``H.CNLSB`` = _prefix "H.CNLSB"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.CNLX"></see>
    /// </summary>
    let ``H.CNLX`` = _prefix "H.CNLX"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.COVE"></see>
    /// </summary>
    let ``H.COVE`` = _prefix "H.COVE"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.CRKT"></see>
    /// </summary>
    let ``H.CRKT`` = _prefix "H.CRKT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.CRNT"></see>
    /// </summary>
    let ``H.CRNT`` = _prefix "H.CRNT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.CUTF"></see>
    /// </summary>
    let ``H.CUTF`` = _prefix "H.CUTF"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.DCK"></see>
    /// </summary>
    let ``H.DCK`` = _prefix "H.DCK"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.DCKB"></see>
    /// </summary>
    let ``H.DCKB`` = _prefix "H.DCKB"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.DOMG"></see>
    /// </summary>
    let ``H.DOMG`` = _prefix "H.DOMG"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.DPRG"></see>
    /// </summary>
    let ``H.DPRG`` = _prefix "H.DPRG"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.DTCH"></see>
    /// </summary>
    let ``H.DTCH`` = _prefix "H.DTCH"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.DTCHD"></see>
    /// </summary>
    let ``H.DTCHD`` = _prefix "H.DTCHD"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.DTCHI"></see>
    /// </summary>
    let ``H.DTCHI`` = _prefix "H.DTCHI"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.DTCHM"></see>
    /// </summary>
    let ``H.DTCHM`` = _prefix "H.DTCHM"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.ESTY"></see>
    /// </summary>
    let ``H.ESTY`` = _prefix "H.ESTY"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.FISH"></see>
    /// </summary>
    let ``H.FISH`` = _prefix "H.FISH"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.FJD"></see>
    /// </summary>
    let ``H.FJD`` = _prefix "H.FJD"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.FJDS"></see>
    /// </summary>
    let ``H.FJDS`` = _prefix "H.FJDS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.FLLS"></see>
    /// </summary>
    let ``H.FLLS`` = _prefix "H.FLLS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.FLLSX"></see>
    /// </summary>
    let ``H.FLLSX`` = _prefix "H.FLLSX"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.FLTM"></see>
    /// </summary>
    let ``H.FLTM`` = _prefix "H.FLTM"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.FLTT"></see>
    /// </summary>
    let ``H.FLTT`` = _prefix "H.FLTT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.GLCR"></see>
    /// </summary>
    let ``H.GLCR`` = _prefix "H.GLCR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.GULF"></see>
    /// </summary>
    let ``H.GULF`` = _prefix "H.GULF"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.GYSR"></see>
    /// </summary>
    let ``H.GYSR`` = _prefix "H.GYSR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.HBR"></see>
    /// </summary>
    let ``H.HBR`` = _prefix "H.HBR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.HBRX"></see>
    /// </summary>
    let ``H.HBRX`` = _prefix "H.HBRX"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.INLT"></see>
    /// </summary>
    let ``H.INLT`` = _prefix "H.INLT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.INLTQ"></see>
    /// </summary>
    let ``H.INLTQ`` = _prefix "H.INLTQ"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.LBED"></see>
    /// </summary>
    let ``H.LBED`` = _prefix "H.LBED"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.LGN"></see>
    /// </summary>
    let ``H.LGN`` = _prefix "H.LGN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.LGNS"></see>
    /// </summary>
    let ``H.LGNS`` = _prefix "H.LGNS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.LGNX"></see>
    /// </summary>
    let ``H.LGNX`` = _prefix "H.LGNX"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.LK"></see>
    /// </summary>
    let ``H.LK`` = _prefix "H.LK"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.LKC"></see>
    /// </summary>
    let ``H.LKC`` = _prefix "H.LKC"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.LKI"></see>
    /// </summary>
    let ``H.LKI`` = _prefix "H.LKI"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.LKN"></see>
    /// </summary>
    let ``H.LKN`` = _prefix "H.LKN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.LKNI"></see>
    /// </summary>
    let ``H.LKNI`` = _prefix "H.LKNI"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.LKO"></see>
    /// </summary>
    let ``H.LKO`` = _prefix "H.LKO"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.LKOI"></see>
    /// </summary>
    let ``H.LKOI`` = _prefix "H.LKOI"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.LKS"></see>
    /// </summary>
    let ``H.LKS`` = _prefix "H.LKS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.LKSB"></see>
    /// </summary>
    let ``H.LKSB`` = _prefix "H.LKSB"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.LKSC"></see>
    /// </summary>
    let ``H.LKSC`` = _prefix "H.LKSC"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.LKSI"></see>
    /// </summary>
    let ``H.LKSI`` = _prefix "H.LKSI"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.LKSN"></see>
    /// </summary>
    let ``H.LKSN`` = _prefix "H.LKSN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.LKSNI"></see>
    /// </summary>
    let ``H.LKSNI`` = _prefix "H.LKSNI"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.LKX"></see>
    /// </summary>
    let ``H.LKX`` = _prefix "H.LKX"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.MFGN"></see>
    /// </summary>
    let ``H.MFGN`` = _prefix "H.MFGN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.MGV"></see>
    /// </summary>
    let ``H.MGV`` = _prefix "H.MGV"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.MOOR"></see>
    /// </summary>
    let ``H.MOOR`` = _prefix "H.MOOR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.MRSH"></see>
    /// </summary>
    let ``H.MRSH`` = _prefix "H.MRSH"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.MRSHN"></see>
    /// </summary>
    let ``H.MRSHN`` = _prefix "H.MRSHN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.NRWS"></see>
    /// </summary>
    let ``H.NRWS`` = _prefix "H.NRWS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.OCN"></see>
    /// </summary>
    let ``H.OCN`` = _prefix "H.OCN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.OVF"></see>
    /// </summary>
    let ``H.OVF`` = _prefix "H.OVF"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.PND"></see>
    /// </summary>
    let ``H.PND`` = _prefix "H.PND"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.PNDI"></see>
    /// </summary>
    let ``H.PNDI`` = _prefix "H.PNDI"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.PNDN"></see>
    /// </summary>
    let ``H.PNDN`` = _prefix "H.PNDN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.PNDNI"></see>
    /// </summary>
    let ``H.PNDNI`` = _prefix "H.PNDNI"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.PNDS"></see>
    /// </summary>
    let ``H.PNDS`` = _prefix "H.PNDS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.PNDSF"></see>
    /// </summary>
    let ``H.PNDSF`` = _prefix "H.PNDSF"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.PNDSI"></see>
    /// </summary>
    let ``H.PNDSI`` = _prefix "H.PNDSI"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.PNDSN"></see>
    /// </summary>
    let ``H.PNDSN`` = _prefix "H.PNDSN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.POOL"></see>
    /// </summary>
    let ``H.POOL`` = _prefix "H.POOL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.POOLI"></see>
    /// </summary>
    let ``H.POOLI`` = _prefix "H.POOLI"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.RCH"></see>
    /// </summary>
    let ``H.RCH`` = _prefix "H.RCH"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.RDGG"></see>
    /// </summary>
    let ``H.RDGG`` = _prefix "H.RDGG"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.RDST"></see>
    /// </summary>
    let ``H.RDST`` = _prefix "H.RDST"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.RF"></see>
    /// </summary>
    let ``H.RF`` = _prefix "H.RF"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.RFC"></see>
    /// </summary>
    let ``H.RFC`` = _prefix "H.RFC"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.RFX"></see>
    /// </summary>
    let ``H.RFX`` = _prefix "H.RFX"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.RPDS"></see>
    /// </summary>
    let ``H.RPDS`` = _prefix "H.RPDS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.RSV"></see>
    /// </summary>
    let ``H.RSV`` = _prefix "H.RSV"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.RSVI"></see>
    /// </summary>
    let ``H.RSVI`` = _prefix "H.RSVI"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.RSVT"></see>
    /// </summary>
    let ``H.RSVT`` = _prefix "H.RSVT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.RVN"></see>
    /// </summary>
    let ``H.RVN`` = _prefix "H.RVN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.SBKH"></see>
    /// </summary>
    let ``H.SBKH`` = _prefix "H.SBKH"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.SD"></see>
    /// </summary>
    let ``H.SD`` = _prefix "H.SD"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.SEA"></see>
    /// </summary>
    let ``H.SEA`` = _prefix "H.SEA"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.SHOL"></see>
    /// </summary>
    let ``H.SHOL`` = _prefix "H.SHOL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.SILL"></see>
    /// </summary>
    let ``H.SILL`` = _prefix "H.SILL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.SPNG"></see>
    /// </summary>
    let ``H.SPNG`` = _prefix "H.SPNG"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.SPNS"></see>
    /// </summary>
    let ``H.SPNS`` = _prefix "H.SPNS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.SPNT"></see>
    /// </summary>
    let ``H.SPNT`` = _prefix "H.SPNT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.STM"></see>
    /// </summary>
    let ``H.STM`` = _prefix "H.STM"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.STMA"></see>
    /// </summary>
    let ``H.STMA`` = _prefix "H.STMA"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.STMB"></see>
    /// </summary>
    let ``H.STMB`` = _prefix "H.STMB"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.STMC"></see>
    /// </summary>
    let ``H.STMC`` = _prefix "H.STMC"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.STMD"></see>
    /// </summary>
    let ``H.STMD`` = _prefix "H.STMD"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.STMH"></see>
    /// </summary>
    let ``H.STMH`` = _prefix "H.STMH"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.STMI"></see>
    /// </summary>
    let ``H.STMI`` = _prefix "H.STMI"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.STMIX"></see>
    /// </summary>
    let ``H.STMIX`` = _prefix "H.STMIX"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.STMM"></see>
    /// </summary>
    let ``H.STMM`` = _prefix "H.STMM"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.STMQ"></see>
    /// </summary>
    let ``H.STMQ`` = _prefix "H.STMQ"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.STMS"></see>
    /// </summary>
    let ``H.STMS`` = _prefix "H.STMS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.STMSB"></see>
    /// </summary>
    let ``H.STMSB`` = _prefix "H.STMSB"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.STMX"></see>
    /// </summary>
    let ``H.STMX`` = _prefix "H.STMX"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.STRT"></see>
    /// </summary>
    let ``H.STRT`` = _prefix "H.STRT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.SWMP"></see>
    /// </summary>
    let ``H.SWMP`` = _prefix "H.SWMP"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.SYSI"></see>
    /// </summary>
    let ``H.SYSI`` = _prefix "H.SYSI"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.TNLC"></see>
    /// </summary>
    let ``H.TNLC`` = _prefix "H.TNLC"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.WAD"></see>
    /// </summary>
    let ``H.WAD`` = _prefix "H.WAD"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.WADB"></see>
    /// </summary>
    let ``H.WADB`` = _prefix "H.WADB"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.WADJ"></see>
    /// </summary>
    let ``H.WADJ`` = _prefix "H.WADJ"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.WADM"></see>
    /// </summary>
    let ``H.WADM`` = _prefix "H.WADM"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.WADS"></see>
    /// </summary>
    let ``H.WADS`` = _prefix "H.WADS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.WADX"></see>
    /// </summary>
    let ``H.WADX`` = _prefix "H.WADX"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.WHRL"></see>
    /// </summary>
    let ``H.WHRL`` = _prefix "H.WHRL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.WLL"></see>
    /// </summary>
    let ``H.WLL`` = _prefix "H.WLL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.WLLQ"></see>
    /// </summary>
    let ``H.WLLQ`` = _prefix "H.WLLQ"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.WLLS"></see>
    /// </summary>
    let ``H.WLLS`` = _prefix "H.WLLS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.WTLD"></see>
    /// </summary>
    let ``H.WTLD`` = _prefix "H.WTLD"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.WTLDI"></see>
    /// </summary>
    let ``H.WTLDI`` = _prefix "H.WTLDI"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.WTRC"></see>
    /// </summary>
    let ``H.WTRC`` = _prefix "H.WTRC"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#H.WTRH"></see>
    /// </summary>
    let ``H.WTRH`` = _prefix "H.WTRH"
    /// <summary>
    /// parks,area, ...
    /// <see href="http://www.geonames.org/ontology#L"></see></summary>
    let L = _prefix "L"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.AGRC"></see>
    /// </summary>
    let ``L.AGRC`` = _prefix "L.AGRC"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.AMUS"></see>
    /// </summary>
    let ``L.AMUS`` = _prefix "L.AMUS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.AREA"></see>
    /// </summary>
    let ``L.AREA`` = _prefix "L.AREA"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.BSND"></see>
    /// </summary>
    let ``L.BSND`` = _prefix "L.BSND"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.BSNP"></see>
    /// </summary>
    let ``L.BSNP`` = _prefix "L.BSNP"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.BTL"></see>
    /// </summary>
    let ``L.BTL`` = _prefix "L.BTL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.CLG"></see>
    /// </summary>
    let ``L.CLG`` = _prefix "L.CLG"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.CMN"></see>
    /// </summary>
    let ``L.CMN`` = _prefix "L.CMN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.CNS"></see>
    /// </summary>
    let ``L.CNS`` = _prefix "L.CNS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.COLF"></see>
    /// </summary>
    let ``L.COLF`` = _prefix "L.COLF"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.CONT"></see>
    /// </summary>
    let ``L.CONT`` = _prefix "L.CONT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.CST"></see>
    /// </summary>
    let ``L.CST`` = _prefix "L.CST"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.CTRB"></see>
    /// </summary>
    let ``L.CTRB`` = _prefix "L.CTRB"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.DEVH"></see>
    /// </summary>
    let ``L.DEVH`` = _prefix "L.DEVH"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.FLD"></see>
    /// </summary>
    let ``L.FLD`` = _prefix "L.FLD"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.FLDI"></see>
    /// </summary>
    let ``L.FLDI`` = _prefix "L.FLDI"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.GASF"></see>
    /// </summary>
    let ``L.GASF`` = _prefix "L.GASF"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.GRAZ"></see>
    /// </summary>
    let ``L.GRAZ`` = _prefix "L.GRAZ"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.GVL"></see>
    /// </summary>
    let ``L.GVL`` = _prefix "L.GVL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.INDS"></see>
    /// </summary>
    let ``L.INDS`` = _prefix "L.INDS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.LAND"></see>
    /// </summary>
    let ``L.LAND`` = _prefix "L.LAND"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.LCTY"></see>
    /// </summary>
    let ``L.LCTY`` = _prefix "L.LCTY"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.MILB"></see>
    /// </summary>
    let ``L.MILB`` = _prefix "L.MILB"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.MNA"></see>
    /// </summary>
    let ``L.MNA`` = _prefix "L.MNA"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.MVA"></see>
    /// </summary>
    let ``L.MVA`` = _prefix "L.MVA"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.NVB"></see>
    /// </summary>
    let ``L.NVB`` = _prefix "L.NVB"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.OAS"></see>
    /// </summary>
    let ``L.OAS`` = _prefix "L.OAS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.OILF"></see>
    /// </summary>
    let ``L.OILF`` = _prefix "L.OILF"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.PEAT"></see>
    /// </summary>
    let ``L.PEAT`` = _prefix "L.PEAT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.PRK"></see>
    /// </summary>
    let ``L.PRK`` = _prefix "L.PRK"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.PRT"></see>
    /// </summary>
    let ``L.PRT`` = _prefix "L.PRT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.QCKS"></see>
    /// </summary>
    let ``L.QCKS`` = _prefix "L.QCKS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.REP"></see>
    /// </summary>
    let ``L.REP`` = _prefix "L.REP"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.RES"></see>
    /// </summary>
    let ``L.RES`` = _prefix "L.RES"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.RESA"></see>
    /// </summary>
    let ``L.RESA`` = _prefix "L.RESA"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.RESF"></see>
    /// </summary>
    let ``L.RESF`` = _prefix "L.RESF"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.RESH"></see>
    /// </summary>
    let ``L.RESH`` = _prefix "L.RESH"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.RESN"></see>
    /// </summary>
    let ``L.RESN`` = _prefix "L.RESN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.RESP"></see>
    /// </summary>
    let ``L.RESP`` = _prefix "L.RESP"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.RESV"></see>
    /// </summary>
    let ``L.RESV`` = _prefix "L.RESV"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.RESW"></see>
    /// </summary>
    let ``L.RESW`` = _prefix "L.RESW"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.RGN"></see>
    /// </summary>
    let ``L.RGN`` = _prefix "L.RGN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.RGNE"></see>
    /// </summary>
    let ``L.RGNE`` = _prefix "L.RGNE"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.RGNH"></see>
    /// </summary>
    let ``L.RGNH`` = _prefix "L.RGNH"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.RGNL"></see>
    /// </summary>
    let ``L.RGNL`` = _prefix "L.RGNL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.RNGA"></see>
    /// </summary>
    let ``L.RNGA`` = _prefix "L.RNGA"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.SALT"></see>
    /// </summary>
    let ``L.SALT`` = _prefix "L.SALT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.SNOW"></see>
    /// </summary>
    let ``L.SNOW`` = _prefix "L.SNOW"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.TRB"></see>
    /// </summary>
    let ``L.TRB`` = _prefix "L.TRB"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#L.ZZZZZ"></see>
    /// </summary>
    let ``L.ZZZZZ`` = _prefix "L.ZZZZZ"
    /// <summary>
    /// A Web page displaying a map
    /// <see href="http://www.geonames.org/ontology#Map"></see></summary>
    let Map = _prefix "Map"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#P.PPL"></see>
    /// </summary>
    let ``P.PPL`` = _prefix "P.PPL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#P.PPLA"></see>
    /// </summary>
    let ``P.PPLA`` = _prefix "P.PPLA"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#P.PPLA2"></see>
    /// </summary>
    let ``P.PPLA2`` = _prefix "P.PPLA2"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#P.PPLA3"></see>
    /// </summary>
    let ``P.PPLA3`` = _prefix "P.PPLA3"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#P.PPLA4"></see>
    /// </summary>
    let ``P.PPLA4`` = _prefix "P.PPLA4"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#P.PPLC"></see>
    /// </summary>
    let ``P.PPLC`` = _prefix "P.PPLC"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#P.PPLF"></see>
    /// </summary>
    let ``P.PPLF`` = _prefix "P.PPLF"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#P.PPLG"></see>
    /// </summary>
    let ``P.PPLG`` = _prefix "P.PPLG"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#P.PPLL"></see>
    /// </summary>
    let ``P.PPLL`` = _prefix "P.PPLL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#P.PPLQ"></see>
    /// </summary>
    let ``P.PPLQ`` = _prefix "P.PPLQ"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#P.PPLR"></see>
    /// </summary>
    let ``P.PPLR`` = _prefix "P.PPLR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#P.PPLS"></see>
    /// </summary>
    let ``P.PPLS`` = _prefix "P.PPLS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#P.PPLW"></see>
    /// </summary>
    let ``P.PPLW`` = _prefix "P.PPLW"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#P.PPLX"></see>
    /// </summary>
    let ``P.PPLX`` = _prefix "P.PPLX"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#P.STLMT"></see>
    /// </summary>
    let ``P.STLMT`` = _prefix "P.STLMT"
    /// <summary>
    /// road, railroad, ...
    /// <see href="http://www.geonames.org/ontology#R"></see></summary>
    let R = _prefix "R"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.CSWY"></see>
    /// </summary>
    let ``R.CSWY`` = _prefix "R.CSWY"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.CSWYQ"></see>
    /// </summary>
    let ``R.CSWYQ`` = _prefix "R.CSWYQ"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.OILP"></see>
    /// </summary>
    let ``R.OILP`` = _prefix "R.OILP"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.PRMN"></see>
    /// </summary>
    let ``R.PRMN`` = _prefix "R.PRMN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.PTGE"></see>
    /// </summary>
    let ``R.PTGE`` = _prefix "R.PTGE"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.RD"></see>
    /// </summary>
    let ``R.RD`` = _prefix "R.RD"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.RDA"></see>
    /// </summary>
    let ``R.RDA`` = _prefix "R.RDA"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.RDB"></see>
    /// </summary>
    let ``R.RDB`` = _prefix "R.RDB"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.RDCUT"></see>
    /// </summary>
    let ``R.RDCUT`` = _prefix "R.RDCUT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.RDJCT"></see>
    /// </summary>
    let ``R.RDJCT`` = _prefix "R.RDJCT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.RJCT"></see>
    /// </summary>
    let ``R.RJCT`` = _prefix "R.RJCT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.RR"></see>
    /// </summary>
    let ``R.RR`` = _prefix "R.RR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.RRQ"></see>
    /// </summary>
    let ``R.RRQ`` = _prefix "R.RRQ"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.RTE"></see>
    /// </summary>
    let ``R.RTE`` = _prefix "R.RTE"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.RYD"></see>
    /// </summary>
    let ``R.RYD`` = _prefix "R.RYD"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.ST"></see>
    /// </summary>
    let ``R.ST`` = _prefix "R.ST"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.STKR"></see>
    /// </summary>
    let ``R.STKR`` = _prefix "R.STKR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.TNL"></see>
    /// </summary>
    let ``R.TNL`` = _prefix "R.TNL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.TNLN"></see>
    /// </summary>
    let ``R.TNLN`` = _prefix "R.TNLN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.TNLRD"></see>
    /// </summary>
    let ``R.TNLRD`` = _prefix "R.TNLRD"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.TNLRR"></see>
    /// </summary>
    let ``R.TNLRR`` = _prefix "R.TNLRR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.TNLS"></see>
    /// </summary>
    let ``R.TNLS`` = _prefix "R.TNLS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#R.TRL"></see>
    /// </summary>
    let ``R.TRL`` = _prefix "R.TRL"
    /// <summary>
    /// A Document containing RDF description of one or several features.
    /// <see href="http://www.geonames.org/ontology#RDFData"></see></summary>
    let RDFData = _prefix "RDFData"
    /// <summary>
    /// spot, building, farm, ...
    /// <see href="http://www.geonames.org/ontology#S"></see></summary>
    let S = _prefix "S"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ADMF"></see>
    /// </summary>
    let ``S.ADMF`` = _prefix "S.ADMF"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.AGRF"></see>
    /// </summary>
    let ``S.AGRF`` = _prefix "S.AGRF"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.AIRB"></see>
    /// </summary>
    let ``S.AIRB`` = _prefix "S.AIRB"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.AIRF"></see>
    /// </summary>
    let ``S.AIRF`` = _prefix "S.AIRF"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.AIRH"></see>
    /// </summary>
    let ``S.AIRH`` = _prefix "S.AIRH"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.AIRP"></see>
    /// </summary>
    let ``S.AIRP`` = _prefix "S.AIRP"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.AIRQ"></see>
    /// </summary>
    let ``S.AIRQ`` = _prefix "S.AIRQ"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.AMTH"></see>
    /// </summary>
    let ``S.AMTH`` = _prefix "S.AMTH"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ANS"></see>
    /// </summary>
    let ``S.ANS`` = _prefix "S.ANS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.AQC"></see>
    /// </summary>
    let ``S.AQC`` = _prefix "S.AQC"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ARCH"></see>
    /// </summary>
    let ``S.ARCH`` = _prefix "S.ARCH"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ASTR"></see>
    /// </summary>
    let ``S.ASTR`` = _prefix "S.ASTR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ASYL"></see>
    /// </summary>
    let ``S.ASYL`` = _prefix "S.ASYL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ATHF"></see>
    /// </summary>
    let ``S.ATHF`` = _prefix "S.ATHF"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ATM"></see>
    /// </summary>
    let ``S.ATM`` = _prefix "S.ATM"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.BANK"></see>
    /// </summary>
    let ``S.BANK`` = _prefix "S.BANK"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.BCN"></see>
    /// </summary>
    let ``S.BCN`` = _prefix "S.BCN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.BDG"></see>
    /// </summary>
    let ``S.BDG`` = _prefix "S.BDG"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.BDGQ"></see>
    /// </summary>
    let ``S.BDGQ`` = _prefix "S.BDGQ"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.BLDG"></see>
    /// </summary>
    let ``S.BLDG`` = _prefix "S.BLDG"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.BLDO"></see>
    /// </summary>
    let ``S.BLDO`` = _prefix "S.BLDO"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.BP"></see>
    /// </summary>
    let ``S.BP`` = _prefix "S.BP"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.BRKS"></see>
    /// </summary>
    let ``S.BRKS`` = _prefix "S.BRKS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.BRKW"></see>
    /// </summary>
    let ``S.BRKW`` = _prefix "S.BRKW"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.BSTN"></see>
    /// </summary>
    let ``S.BSTN`` = _prefix "S.BSTN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.BTYD"></see>
    /// </summary>
    let ``S.BTYD`` = _prefix "S.BTYD"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.BUR"></see>
    /// </summary>
    let ``S.BUR`` = _prefix "S.BUR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.BUSTN"></see>
    /// </summary>
    let ``S.BUSTN`` = _prefix "S.BUSTN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.BUSTP"></see>
    /// </summary>
    let ``S.BUSTP`` = _prefix "S.BUSTP"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CARN"></see>
    /// </summary>
    let ``S.CARN`` = _prefix "S.CARN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CAVE"></see>
    /// </summary>
    let ``S.CAVE`` = _prefix "S.CAVE"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CCL"></see>
    /// </summary>
    let ``S.CCL`` = _prefix "S.CCL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CH"></see>
    /// </summary>
    let ``S.CH`` = _prefix "S.CH"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CMP"></see>
    /// </summary>
    let ``S.CMP`` = _prefix "S.CMP"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CMPL"></see>
    /// </summary>
    let ``S.CMPL`` = _prefix "S.CMPL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CMPLA"></see>
    /// </summary>
    let ``S.CMPLA`` = _prefix "S.CMPLA"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CMPMN"></see>
    /// </summary>
    let ``S.CMPMN`` = _prefix "S.CMPMN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CMPO"></see>
    /// </summary>
    let ``S.CMPO`` = _prefix "S.CMPO"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CMPQ"></see>
    /// </summary>
    let ``S.CMPQ`` = _prefix "S.CMPQ"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CMPRF"></see>
    /// </summary>
    let ``S.CMPRF`` = _prefix "S.CMPRF"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CMTY"></see>
    /// </summary>
    let ``S.CMTY`` = _prefix "S.CMTY"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.COMC"></see>
    /// </summary>
    let ``S.COMC`` = _prefix "S.COMC"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CRRL"></see>
    /// </summary>
    let ``S.CRRL`` = _prefix "S.CRRL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CSNO"></see>
    /// </summary>
    let ``S.CSNO`` = _prefix "S.CSNO"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CSTL"></see>
    /// </summary>
    let ``S.CSTL`` = _prefix "S.CSTL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CSTM"></see>
    /// </summary>
    let ``S.CSTM`` = _prefix "S.CSTM"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CTHSE"></see>
    /// </summary>
    let ``S.CTHSE`` = _prefix "S.CTHSE"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CTRA"></see>
    /// </summary>
    let ``S.CTRA`` = _prefix "S.CTRA"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CTRCM"></see>
    /// </summary>
    let ``S.CTRCM`` = _prefix "S.CTRCM"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CTRF"></see>
    /// </summary>
    let ``S.CTRF`` = _prefix "S.CTRF"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CTRM"></see>
    /// </summary>
    let ``S.CTRM`` = _prefix "S.CTRM"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CTRR"></see>
    /// </summary>
    let ``S.CTRR`` = _prefix "S.CTRR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CTRS"></see>
    /// </summary>
    let ``S.CTRS`` = _prefix "S.CTRS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.CVNT"></see>
    /// </summary>
    let ``S.CVNT`` = _prefix "S.CVNT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.DAM"></see>
    /// </summary>
    let ``S.DAM`` = _prefix "S.DAM"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.DAMQ"></see>
    /// </summary>
    let ``S.DAMQ`` = _prefix "S.DAMQ"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.DAMSB"></see>
    /// </summary>
    let ``S.DAMSB`` = _prefix "S.DAMSB"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.DARY"></see>
    /// </summary>
    let ``S.DARY`` = _prefix "S.DARY"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.DCKD"></see>
    /// </summary>
    let ``S.DCKD`` = _prefix "S.DCKD"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.DCKY"></see>
    /// </summary>
    let ``S.DCKY`` = _prefix "S.DCKY"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.DIKE"></see>
    /// </summary>
    let ``S.DIKE`` = _prefix "S.DIKE"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.DIP"></see>
    /// </summary>
    let ``S.DIP`` = _prefix "S.DIP"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.DPOF"></see>
    /// </summary>
    let ``S.DPOF`` = _prefix "S.DPOF"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.EST"></see>
    /// </summary>
    let ``S.EST`` = _prefix "S.EST"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ESTB"></see>
    /// </summary>
    let ``S.ESTB`` = _prefix "S.ESTB"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ESTC"></see>
    /// </summary>
    let ``S.ESTC`` = _prefix "S.ESTC"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ESTO"></see>
    /// </summary>
    let ``S.ESTO`` = _prefix "S.ESTO"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ESTR"></see>
    /// </summary>
    let ``S.ESTR`` = _prefix "S.ESTR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ESTSG"></see>
    /// </summary>
    let ``S.ESTSG`` = _prefix "S.ESTSG"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ESTSL"></see>
    /// </summary>
    let ``S.ESTSL`` = _prefix "S.ESTSL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ESTT"></see>
    /// </summary>
    let ``S.ESTT`` = _prefix "S.ESTT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ESTX"></see>
    /// </summary>
    let ``S.ESTX`` = _prefix "S.ESTX"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.FCL"></see>
    /// </summary>
    let ``S.FCL`` = _prefix "S.FCL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.FNDY"></see>
    /// </summary>
    let ``S.FNDY`` = _prefix "S.FNDY"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.FRM"></see>
    /// </summary>
    let ``S.FRM`` = _prefix "S.FRM"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.FRMQ"></see>
    /// </summary>
    let ``S.FRMQ`` = _prefix "S.FRMQ"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.FRMS"></see>
    /// </summary>
    let ``S.FRMS`` = _prefix "S.FRMS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.FRMT"></see>
    /// </summary>
    let ``S.FRMT`` = _prefix "S.FRMT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.FT"></see>
    /// </summary>
    let ``S.FT`` = _prefix "S.FT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.FY"></see>
    /// </summary>
    let ``S.FY`` = _prefix "S.FY"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.GATE"></see>
    /// </summary>
    let ``S.GATE`` = _prefix "S.GATE"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.GDN"></see>
    /// </summary>
    let ``S.GDN`` = _prefix "S.GDN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.GHAT"></see>
    /// </summary>
    let ``S.GHAT`` = _prefix "S.GHAT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.GHSE"></see>
    /// </summary>
    let ``S.GHSE`` = _prefix "S.GHSE"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.GOSP"></see>
    /// </summary>
    let ``S.GOSP`` = _prefix "S.GOSP"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.GOVL"></see>
    /// </summary>
    let ``S.GOVL`` = _prefix "S.GOVL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.GRVE"></see>
    /// </summary>
    let ``S.GRVE`` = _prefix "S.GRVE"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.HERM"></see>
    /// </summary>
    let ``S.HERM`` = _prefix "S.HERM"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.HLT"></see>
    /// </summary>
    let ``S.HLT`` = _prefix "S.HLT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.HMSD"></see>
    /// </summary>
    let ``S.HMSD`` = _prefix "S.HMSD"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.HSE"></see>
    /// </summary>
    let ``S.HSE`` = _prefix "S.HSE"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.HSEC"></see>
    /// </summary>
    let ``S.HSEC`` = _prefix "S.HSEC"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.HSP"></see>
    /// </summary>
    let ``S.HSP`` = _prefix "S.HSP"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.HSPC"></see>
    /// </summary>
    let ``S.HSPC`` = _prefix "S.HSPC"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.HSPD"></see>
    /// </summary>
    let ``S.HSPD`` = _prefix "S.HSPD"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.HSPL"></see>
    /// </summary>
    let ``S.HSPL`` = _prefix "S.HSPL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.HSTS"></see>
    /// </summary>
    let ``S.HSTS`` = _prefix "S.HSTS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.HTL"></see>
    /// </summary>
    let ``S.HTL`` = _prefix "S.HTL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.HUT"></see>
    /// </summary>
    let ``S.HUT`` = _prefix "S.HUT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.HUTS"></see>
    /// </summary>
    let ``S.HUTS`` = _prefix "S.HUTS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.INSM"></see>
    /// </summary>
    let ``S.INSM`` = _prefix "S.INSM"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ITTR"></see>
    /// </summary>
    let ``S.ITTR`` = _prefix "S.ITTR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.JTY"></see>
    /// </summary>
    let ``S.JTY`` = _prefix "S.JTY"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.LDNG"></see>
    /// </summary>
    let ``S.LDNG`` = _prefix "S.LDNG"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.LEPC"></see>
    /// </summary>
    let ``S.LEPC`` = _prefix "S.LEPC"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.LIBR"></see>
    /// </summary>
    let ``S.LIBR`` = _prefix "S.LIBR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.LNDF"></see>
    /// </summary>
    let ``S.LNDF`` = _prefix "S.LNDF"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.LOCK"></see>
    /// </summary>
    let ``S.LOCK`` = _prefix "S.LOCK"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.LTHSE"></see>
    /// </summary>
    let ``S.LTHSE`` = _prefix "S.LTHSE"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MALL"></see>
    /// </summary>
    let ``S.MALL`` = _prefix "S.MALL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MAR"></see>
    /// </summary>
    let ``S.MAR`` = _prefix "S.MAR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MFG"></see>
    /// </summary>
    let ``S.MFG`` = _prefix "S.MFG"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MFGB"></see>
    /// </summary>
    let ``S.MFGB`` = _prefix "S.MFGB"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MFGC"></see>
    /// </summary>
    let ``S.MFGC`` = _prefix "S.MFGC"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MFGCU"></see>
    /// </summary>
    let ``S.MFGCU`` = _prefix "S.MFGCU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MFGLM"></see>
    /// </summary>
    let ``S.MFGLM`` = _prefix "S.MFGLM"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MFGM"></see>
    /// </summary>
    let ``S.MFGM`` = _prefix "S.MFGM"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MFGPH"></see>
    /// </summary>
    let ``S.MFGPH`` = _prefix "S.MFGPH"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MFGQ"></see>
    /// </summary>
    let ``S.MFGQ`` = _prefix "S.MFGQ"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MFGSG"></see>
    /// </summary>
    let ``S.MFGSG`` = _prefix "S.MFGSG"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MKT"></see>
    /// </summary>
    let ``S.MKT`` = _prefix "S.MKT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ML"></see>
    /// </summary>
    let ``S.ML`` = _prefix "S.ML"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MLM"></see>
    /// </summary>
    let ``S.MLM`` = _prefix "S.MLM"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MLO"></see>
    /// </summary>
    let ``S.MLO`` = _prefix "S.MLO"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MLSG"></see>
    /// </summary>
    let ``S.MLSG`` = _prefix "S.MLSG"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MLSGQ"></see>
    /// </summary>
    let ``S.MLSGQ`` = _prefix "S.MLSGQ"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MLSW"></see>
    /// </summary>
    let ``S.MLSW`` = _prefix "S.MLSW"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MLWND"></see>
    /// </summary>
    let ``S.MLWND`` = _prefix "S.MLWND"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MLWTR"></see>
    /// </summary>
    let ``S.MLWTR`` = _prefix "S.MLWTR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MN"></see>
    /// </summary>
    let ``S.MN`` = _prefix "S.MN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MNAU"></see>
    /// </summary>
    let ``S.MNAU`` = _prefix "S.MNAU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MNC"></see>
    /// </summary>
    let ``S.MNC`` = _prefix "S.MNC"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MNCR"></see>
    /// </summary>
    let ``S.MNCR`` = _prefix "S.MNCR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MNCU"></see>
    /// </summary>
    let ``S.MNCU`` = _prefix "S.MNCU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MNDT"></see>
    /// </summary>
    let ``S.MNDT`` = _prefix "S.MNDT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MNFE"></see>
    /// </summary>
    let ``S.MNFE`` = _prefix "S.MNFE"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MNMT"></see>
    /// </summary>
    let ``S.MNMT`` = _prefix "S.MNMT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MNN"></see>
    /// </summary>
    let ``S.MNN`` = _prefix "S.MNN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MNNI"></see>
    /// </summary>
    let ``S.MNNI`` = _prefix "S.MNNI"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MNPB"></see>
    /// </summary>
    let ``S.MNPB`` = _prefix "S.MNPB"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MNPL"></see>
    /// </summary>
    let ``S.MNPL`` = _prefix "S.MNPL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MNQ"></see>
    /// </summary>
    let ``S.MNQ`` = _prefix "S.MNQ"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MNQR"></see>
    /// </summary>
    let ``S.MNQR`` = _prefix "S.MNQR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MNSN"></see>
    /// </summary>
    let ``S.MNSN`` = _prefix "S.MNSN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MOLE"></see>
    /// </summary>
    let ``S.MOLE`` = _prefix "S.MOLE"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MSQE"></see>
    /// </summary>
    let ``S.MSQE`` = _prefix "S.MSQE"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MSSN"></see>
    /// </summary>
    let ``S.MSSN`` = _prefix "S.MSSN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MSSNQ"></see>
    /// </summary>
    let ``S.MSSNQ`` = _prefix "S.MSSNQ"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MSTY"></see>
    /// </summary>
    let ``S.MSTY`` = _prefix "S.MSTY"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MTRO"></see>
    /// </summary>
    let ``S.MTRO`` = _prefix "S.MTRO"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.MUS"></see>
    /// </summary>
    let ``S.MUS`` = _prefix "S.MUS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.NOV"></see>
    /// </summary>
    let ``S.NOV`` = _prefix "S.NOV"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.NSY"></see>
    /// </summary>
    let ``S.NSY`` = _prefix "S.NSY"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.OBPT"></see>
    /// </summary>
    let ``S.OBPT`` = _prefix "S.OBPT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.OBS"></see>
    /// </summary>
    let ``S.OBS`` = _prefix "S.OBS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.OBSR"></see>
    /// </summary>
    let ``S.OBSR`` = _prefix "S.OBSR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.OILJ"></see>
    /// </summary>
    let ``S.OILJ`` = _prefix "S.OILJ"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.OILQ"></see>
    /// </summary>
    let ``S.OILQ`` = _prefix "S.OILQ"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.OILR"></see>
    /// </summary>
    let ``S.OILR`` = _prefix "S.OILR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.OILT"></see>
    /// </summary>
    let ``S.OILT`` = _prefix "S.OILT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.OILW"></see>
    /// </summary>
    let ``S.OILW`` = _prefix "S.OILW"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.OPRA"></see>
    /// </summary>
    let ``S.OPRA`` = _prefix "S.OPRA"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PAL"></see>
    /// </summary>
    let ``S.PAL`` = _prefix "S.PAL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PGDA"></see>
    /// </summary>
    let ``S.PGDA`` = _prefix "S.PGDA"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PIER"></see>
    /// </summary>
    let ``S.PIER`` = _prefix "S.PIER"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PKLT"></see>
    /// </summary>
    let ``S.PKLT`` = _prefix "S.PKLT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PMPO"></see>
    /// </summary>
    let ``S.PMPO`` = _prefix "S.PMPO"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PMPW"></see>
    /// </summary>
    let ``S.PMPW`` = _prefix "S.PMPW"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PO"></see>
    /// </summary>
    let ``S.PO`` = _prefix "S.PO"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PP"></see>
    /// </summary>
    let ``S.PP`` = _prefix "S.PP"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PPQ"></see>
    /// </summary>
    let ``S.PPQ`` = _prefix "S.PPQ"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PRKGT"></see>
    /// </summary>
    let ``S.PRKGT`` = _prefix "S.PRKGT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PRKHQ"></see>
    /// </summary>
    let ``S.PRKHQ`` = _prefix "S.PRKHQ"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PRN"></see>
    /// </summary>
    let ``S.PRN`` = _prefix "S.PRN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PRNJ"></see>
    /// </summary>
    let ``S.PRNJ`` = _prefix "S.PRNJ"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PRNQ"></see>
    /// </summary>
    let ``S.PRNQ`` = _prefix "S.PRNQ"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PS"></see>
    /// </summary>
    let ``S.PS`` = _prefix "S.PS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PSH"></see>
    /// </summary>
    let ``S.PSH`` = _prefix "S.PSH"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PSTB"></see>
    /// </summary>
    let ``S.PSTB`` = _prefix "S.PSTB"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PSTC"></see>
    /// </summary>
    let ``S.PSTC`` = _prefix "S.PSTC"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PSTP"></see>
    /// </summary>
    let ``S.PSTP`` = _prefix "S.PSTP"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PYR"></see>
    /// </summary>
    let ``S.PYR`` = _prefix "S.PYR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.PYRS"></see>
    /// </summary>
    let ``S.PYRS`` = _prefix "S.PYRS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.QUAY"></see>
    /// </summary>
    let ``S.QUAY`` = _prefix "S.QUAY"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.RDCR"></see>
    /// </summary>
    let ``S.RDCR`` = _prefix "S.RDCR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.RECG"></see>
    /// </summary>
    let ``S.RECG`` = _prefix "S.RECG"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.RECR"></see>
    /// </summary>
    let ``S.RECR`` = _prefix "S.RECR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.REST"></see>
    /// </summary>
    let ``S.REST`` = _prefix "S.REST"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.RET"></see>
    /// </summary>
    let ``S.RET`` = _prefix "S.RET"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.RHSE"></see>
    /// </summary>
    let ``S.RHSE`` = _prefix "S.RHSE"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.RKRY"></see>
    /// </summary>
    let ``S.RKRY`` = _prefix "S.RKRY"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.RLG"></see>
    /// </summary>
    let ``S.RLG`` = _prefix "S.RLG"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.RLGR"></see>
    /// </summary>
    let ``S.RLGR`` = _prefix "S.RLGR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.RNCH"></see>
    /// </summary>
    let ``S.RNCH`` = _prefix "S.RNCH"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.RSD"></see>
    /// </summary>
    let ``S.RSD`` = _prefix "S.RSD"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.RSGNL"></see>
    /// </summary>
    let ``S.RSGNL`` = _prefix "S.RSGNL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.RSRT"></see>
    /// </summary>
    let ``S.RSRT`` = _prefix "S.RSRT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.RSTN"></see>
    /// </summary>
    let ``S.RSTN`` = _prefix "S.RSTN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.RSTNQ"></see>
    /// </summary>
    let ``S.RSTNQ`` = _prefix "S.RSTNQ"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.RSTP"></see>
    /// </summary>
    let ``S.RSTP`` = _prefix "S.RSTP"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.RSTPQ"></see>
    /// </summary>
    let ``S.RSTPQ`` = _prefix "S.RSTPQ"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.RUIN"></see>
    /// </summary>
    let ``S.RUIN`` = _prefix "S.RUIN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.SCH"></see>
    /// </summary>
    let ``S.SCH`` = _prefix "S.SCH"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.SCHA"></see>
    /// </summary>
    let ``S.SCHA`` = _prefix "S.SCHA"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.SCHC"></see>
    /// </summary>
    let ``S.SCHC`` = _prefix "S.SCHC"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.SCHD"></see>
    /// </summary>
    let ``S.SCHD`` = _prefix "S.SCHD"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.SCHL"></see>
    /// </summary>
    let ``S.SCHL`` = _prefix "S.SCHL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.SCHM"></see>
    /// </summary>
    let ``S.SCHM`` = _prefix "S.SCHM"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.SCHN"></see>
    /// </summary>
    let ``S.SCHN`` = _prefix "S.SCHN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.SCHT"></see>
    /// </summary>
    let ``S.SCHT`` = _prefix "S.SCHT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.SECP"></see>
    /// </summary>
    let ``S.SECP`` = _prefix "S.SECP"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.SHPF"></see>
    /// </summary>
    let ``S.SHPF`` = _prefix "S.SHPF"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.SHRN"></see>
    /// </summary>
    let ``S.SHRN`` = _prefix "S.SHRN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.SHSE"></see>
    /// </summary>
    let ``S.SHSE`` = _prefix "S.SHSE"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.SLCE"></see>
    /// </summary>
    let ``S.SLCE`` = _prefix "S.SLCE"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.SNTR"></see>
    /// </summary>
    let ``S.SNTR`` = _prefix "S.SNTR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.SPA"></see>
    /// </summary>
    let ``S.SPA`` = _prefix "S.SPA"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.SPLY"></see>
    /// </summary>
    let ``S.SPLY`` = _prefix "S.SPLY"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.SQR"></see>
    /// </summary>
    let ``S.SQR`` = _prefix "S.SQR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.STBL"></see>
    /// </summary>
    let ``S.STBL`` = _prefix "S.STBL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.STDM"></see>
    /// </summary>
    let ``S.STDM`` = _prefix "S.STDM"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.STNB"></see>
    /// </summary>
    let ``S.STNB`` = _prefix "S.STNB"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.STNC"></see>
    /// </summary>
    let ``S.STNC`` = _prefix "S.STNC"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.STNE"></see>
    /// </summary>
    let ``S.STNE`` = _prefix "S.STNE"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.STNF"></see>
    /// </summary>
    let ``S.STNF`` = _prefix "S.STNF"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.STNI"></see>
    /// </summary>
    let ``S.STNI`` = _prefix "S.STNI"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.STNM"></see>
    /// </summary>
    let ``S.STNM`` = _prefix "S.STNM"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.STNR"></see>
    /// </summary>
    let ``S.STNR`` = _prefix "S.STNR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.STNS"></see>
    /// </summary>
    let ``S.STNS`` = _prefix "S.STNS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.STNW"></see>
    /// </summary>
    let ``S.STNW`` = _prefix "S.STNW"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.STPS"></see>
    /// </summary>
    let ``S.STPS`` = _prefix "S.STPS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.SWT"></see>
    /// </summary>
    let ``S.SWT`` = _prefix "S.SWT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.THTR"></see>
    /// </summary>
    let ``S.THTR`` = _prefix "S.THTR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.TMB"></see>
    /// </summary>
    let ``S.TMB`` = _prefix "S.TMB"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.TMPL"></see>
    /// </summary>
    let ``S.TMPL`` = _prefix "S.TMPL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.TNKD"></see>
    /// </summary>
    let ``S.TNKD`` = _prefix "S.TNKD"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.TOWR"></see>
    /// </summary>
    let ``S.TOWR`` = _prefix "S.TOWR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.TRANT"></see>
    /// </summary>
    let ``S.TRANT`` = _prefix "S.TRANT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.TRIG"></see>
    /// </summary>
    let ``S.TRIG`` = _prefix "S.TRIG"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.TRMO"></see>
    /// </summary>
    let ``S.TRMO`` = _prefix "S.TRMO"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.TWO"></see>
    /// </summary>
    let ``S.TWO`` = _prefix "S.TWO"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.UNIO"></see>
    /// </summary>
    let ``S.UNIO`` = _prefix "S.UNIO"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.UNIP"></see>
    /// </summary>
    let ``S.UNIP`` = _prefix "S.UNIP"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.UNIV"></see>
    /// </summary>
    let ``S.UNIV`` = _prefix "S.UNIV"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.USGE"></see>
    /// </summary>
    let ``S.USGE`` = _prefix "S.USGE"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.VETF"></see>
    /// </summary>
    let ``S.VETF`` = _prefix "S.VETF"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.WALL"></see>
    /// </summary>
    let ``S.WALL`` = _prefix "S.WALL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.WALLA"></see>
    /// </summary>
    let ``S.WALLA`` = _prefix "S.WALLA"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.WEIR"></see>
    /// </summary>
    let ``S.WEIR`` = _prefix "S.WEIR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.WHRF"></see>
    /// </summary>
    let ``S.WHRF`` = _prefix "S.WHRF"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.WRCK"></see>
    /// </summary>
    let ``S.WRCK`` = _prefix "S.WRCK"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.WTRW"></see>
    /// </summary>
    let ``S.WTRW`` = _prefix "S.WTRW"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ZNF"></see>
    /// </summary>
    let ``S.ZNF`` = _prefix "S.ZNF"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#S.ZOO"></see>
    /// </summary>
    let ``S.ZOO`` = _prefix "S.ZOO"
    /// <summary>
    /// mountain, hill, rock, ...
    /// <see href="http://www.geonames.org/ontology#T"></see></summary>
    let T = _prefix "T"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.ASPH"></see>
    /// </summary>
    let ``T.ASPH`` = _prefix "T.ASPH"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.ATOL"></see>
    /// </summary>
    let ``T.ATOL`` = _prefix "T.ATOL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.BAR"></see>
    /// </summary>
    let ``T.BAR`` = _prefix "T.BAR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.BCH"></see>
    /// </summary>
    let ``T.BCH`` = _prefix "T.BCH"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.BCHS"></see>
    /// </summary>
    let ``T.BCHS`` = _prefix "T.BCHS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.BDLD"></see>
    /// </summary>
    let ``T.BDLD`` = _prefix "T.BDLD"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.BLDR"></see>
    /// </summary>
    let ``T.BLDR`` = _prefix "T.BLDR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.BLHL"></see>
    /// </summary>
    let ``T.BLHL`` = _prefix "T.BLHL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.BLOW"></see>
    /// </summary>
    let ``T.BLOW`` = _prefix "T.BLOW"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.BNCH"></see>
    /// </summary>
    let ``T.BNCH`` = _prefix "T.BNCH"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.BUTE"></see>
    /// </summary>
    let ``T.BUTE`` = _prefix "T.BUTE"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.CAPE"></see>
    /// </summary>
    let ``T.CAPE`` = _prefix "T.CAPE"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.CFT"></see>
    /// </summary>
    let ``T.CFT`` = _prefix "T.CFT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.CLDA"></see>
    /// </summary>
    let ``T.CLDA`` = _prefix "T.CLDA"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.CLF"></see>
    /// </summary>
    let ``T.CLF`` = _prefix "T.CLF"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.CNYN"></see>
    /// </summary>
    let ``T.CNYN`` = _prefix "T.CNYN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.CONE"></see>
    /// </summary>
    let ``T.CONE`` = _prefix "T.CONE"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.CRDR"></see>
    /// </summary>
    let ``T.CRDR`` = _prefix "T.CRDR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.CRQ"></see>
    /// </summary>
    let ``T.CRQ`` = _prefix "T.CRQ"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.CRQS"></see>
    /// </summary>
    let ``T.CRQS`` = _prefix "T.CRQS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.CRTR"></see>
    /// </summary>
    let ``T.CRTR`` = _prefix "T.CRTR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.CUET"></see>
    /// </summary>
    let ``T.CUET`` = _prefix "T.CUET"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.DLTA"></see>
    /// </summary>
    let ``T.DLTA`` = _prefix "T.DLTA"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.DPR"></see>
    /// </summary>
    let ``T.DPR`` = _prefix "T.DPR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.DSRT"></see>
    /// </summary>
    let ``T.DSRT`` = _prefix "T.DSRT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.DUNE"></see>
    /// </summary>
    let ``T.DUNE`` = _prefix "T.DUNE"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.DVD"></see>
    /// </summary>
    let ``T.DVD`` = _prefix "T.DVD"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.ERG"></see>
    /// </summary>
    let ``T.ERG`` = _prefix "T.ERG"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.FAN"></see>
    /// </summary>
    let ``T.FAN`` = _prefix "T.FAN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.FORD"></see>
    /// </summary>
    let ``T.FORD`` = _prefix "T.FORD"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.FSR"></see>
    /// </summary>
    let ``T.FSR`` = _prefix "T.FSR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.GAP"></see>
    /// </summary>
    let ``T.GAP`` = _prefix "T.GAP"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.GRGE"></see>
    /// </summary>
    let ``T.GRGE`` = _prefix "T.GRGE"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.HDLD"></see>
    /// </summary>
    let ``T.HDLD`` = _prefix "T.HDLD"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.HLL"></see>
    /// </summary>
    let ``T.HLL`` = _prefix "T.HLL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.HLLS"></see>
    /// </summary>
    let ``T.HLLS`` = _prefix "T.HLLS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.HMCK"></see>
    /// </summary>
    let ``T.HMCK`` = _prefix "T.HMCK"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.HMDA"></see>
    /// </summary>
    let ``T.HMDA`` = _prefix "T.HMDA"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.INTF"></see>
    /// </summary>
    let ``T.INTF`` = _prefix "T.INTF"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.ISL"></see>
    /// </summary>
    let ``T.ISL`` = _prefix "T.ISL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.ISLET"></see>
    /// </summary>
    let ``T.ISLET`` = _prefix "T.ISLET"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.ISLF"></see>
    /// </summary>
    let ``T.ISLF`` = _prefix "T.ISLF"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.ISLM"></see>
    /// </summary>
    let ``T.ISLM`` = _prefix "T.ISLM"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.ISLS"></see>
    /// </summary>
    let ``T.ISLS`` = _prefix "T.ISLS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.ISLT"></see>
    /// </summary>
    let ``T.ISLT`` = _prefix "T.ISLT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.ISLX"></see>
    /// </summary>
    let ``T.ISLX`` = _prefix "T.ISLX"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.ISTH"></see>
    /// </summary>
    let ``T.ISTH`` = _prefix "T.ISTH"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.KRST"></see>
    /// </summary>
    let ``T.KRST`` = _prefix "T.KRST"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.LAVA"></see>
    /// </summary>
    let ``T.LAVA`` = _prefix "T.LAVA"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.LEV"></see>
    /// </summary>
    let ``T.LEV`` = _prefix "T.LEV"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.MESA"></see>
    /// </summary>
    let ``T.MESA`` = _prefix "T.MESA"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.MND"></see>
    /// </summary>
    let ``T.MND`` = _prefix "T.MND"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.MRN"></see>
    /// </summary>
    let ``T.MRN`` = _prefix "T.MRN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.MT"></see>
    /// </summary>
    let ``T.MT`` = _prefix "T.MT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.MTS"></see>
    /// </summary>
    let ``T.MTS`` = _prefix "T.MTS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.NKM"></see>
    /// </summary>
    let ``T.NKM`` = _prefix "T.NKM"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.NTK"></see>
    /// </summary>
    let ``T.NTK`` = _prefix "T.NTK"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.NTKS"></see>
    /// </summary>
    let ``T.NTKS`` = _prefix "T.NTKS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.PAN"></see>
    /// </summary>
    let ``T.PAN`` = _prefix "T.PAN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.PANS"></see>
    /// </summary>
    let ``T.PANS`` = _prefix "T.PANS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.PASS"></see>
    /// </summary>
    let ``T.PASS`` = _prefix "T.PASS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.PEN"></see>
    /// </summary>
    let ``T.PEN`` = _prefix "T.PEN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.PENX"></see>
    /// </summary>
    let ``T.PENX`` = _prefix "T.PENX"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.PK"></see>
    /// </summary>
    let ``T.PK`` = _prefix "T.PK"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.PKS"></see>
    /// </summary>
    let ``T.PKS`` = _prefix "T.PKS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.PLAT"></see>
    /// </summary>
    let ``T.PLAT`` = _prefix "T.PLAT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.PLATX"></see>
    /// </summary>
    let ``T.PLATX`` = _prefix "T.PLATX"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.PLDR"></see>
    /// </summary>
    let ``T.PLDR`` = _prefix "T.PLDR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.PLN"></see>
    /// </summary>
    let ``T.PLN`` = _prefix "T.PLN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.PLNX"></see>
    /// </summary>
    let ``T.PLNX`` = _prefix "T.PLNX"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.PROM"></see>
    /// </summary>
    let ``T.PROM`` = _prefix "T.PROM"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.PT"></see>
    /// </summary>
    let ``T.PT`` = _prefix "T.PT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.PTS"></see>
    /// </summary>
    let ``T.PTS`` = _prefix "T.PTS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.RDGB"></see>
    /// </summary>
    let ``T.RDGB`` = _prefix "T.RDGB"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.RDGE"></see>
    /// </summary>
    let ``T.RDGE`` = _prefix "T.RDGE"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.REG"></see>
    /// </summary>
    let ``T.REG`` = _prefix "T.REG"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.RK"></see>
    /// </summary>
    let ``T.RK`` = _prefix "T.RK"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.RKFL"></see>
    /// </summary>
    let ``T.RKFL`` = _prefix "T.RKFL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.RKS"></see>
    /// </summary>
    let ``T.RKS`` = _prefix "T.RKS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.SAND"></see>
    /// </summary>
    let ``T.SAND`` = _prefix "T.SAND"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.SBED"></see>
    /// </summary>
    let ``T.SBED`` = _prefix "T.SBED"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.SCRP"></see>
    /// </summary>
    let ``T.SCRP`` = _prefix "T.SCRP"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.SDL"></see>
    /// </summary>
    let ``T.SDL`` = _prefix "T.SDL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.SHOR"></see>
    /// </summary>
    let ``T.SHOR`` = _prefix "T.SHOR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.SINK"></see>
    /// </summary>
    let ``T.SINK`` = _prefix "T.SINK"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.SLID"></see>
    /// </summary>
    let ``T.SLID`` = _prefix "T.SLID"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.SLP"></see>
    /// </summary>
    let ``T.SLP`` = _prefix "T.SLP"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.SPIT"></see>
    /// </summary>
    let ``T.SPIT`` = _prefix "T.SPIT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.SPUR"></see>
    /// </summary>
    let ``T.SPUR`` = _prefix "T.SPUR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.TAL"></see>
    /// </summary>
    let ``T.TAL`` = _prefix "T.TAL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.TRGD"></see>
    /// </summary>
    let ``T.TRGD`` = _prefix "T.TRGD"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.TRR"></see>
    /// </summary>
    let ``T.TRR`` = _prefix "T.TRR"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.UPLD"></see>
    /// </summary>
    let ``T.UPLD`` = _prefix "T.UPLD"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.VAL"></see>
    /// </summary>
    let ``T.VAL`` = _prefix "T.VAL"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.VALG"></see>
    /// </summary>
    let ``T.VALG`` = _prefix "T.VALG"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.VALS"></see>
    /// </summary>
    let ``T.VALS`` = _prefix "T.VALS"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.VALX"></see>
    /// </summary>
    let ``T.VALX`` = _prefix "T.VALX"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#T.VLC"></see>
    /// </summary>
    let ``T.VLC`` = _prefix "T.VLC"
    /// <summary>
    /// undersea
    /// <see href="http://www.geonames.org/ontology#U"></see></summary>
    let U = _prefix "U"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.APNU"></see>
    /// </summary>
    let ``U.APNU`` = _prefix "U.APNU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.ARCU"></see>
    /// </summary>
    let ``U.ARCU`` = _prefix "U.ARCU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.ARRU"></see>
    /// </summary>
    let ``U.ARRU`` = _prefix "U.ARRU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.BDLU"></see>
    /// </summary>
    let ``U.BDLU`` = _prefix "U.BDLU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.BKSU"></see>
    /// </summary>
    let ``U.BKSU`` = _prefix "U.BKSU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.BNCU"></see>
    /// </summary>
    let ``U.BNCU`` = _prefix "U.BNCU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.BNKU"></see>
    /// </summary>
    let ``U.BNKU`` = _prefix "U.BNKU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.BSNU"></see>
    /// </summary>
    let ``U.BSNU`` = _prefix "U.BSNU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.CDAU"></see>
    /// </summary>
    let ``U.CDAU`` = _prefix "U.CDAU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.CNSU"></see>
    /// </summary>
    let ``U.CNSU`` = _prefix "U.CNSU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.CNYU"></see>
    /// </summary>
    let ``U.CNYU`` = _prefix "U.CNYU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.CRSU"></see>
    /// </summary>
    let ``U.CRSU`` = _prefix "U.CRSU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.DEPU"></see>
    /// </summary>
    let ``U.DEPU`` = _prefix "U.DEPU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.EDGU"></see>
    /// </summary>
    let ``U.EDGU`` = _prefix "U.EDGU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.ESCU"></see>
    /// </summary>
    let ``U.ESCU`` = _prefix "U.ESCU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.FANU"></see>
    /// </summary>
    let ``U.FANU`` = _prefix "U.FANU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.FLTU"></see>
    /// </summary>
    let ``U.FLTU`` = _prefix "U.FLTU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.FRKU"></see>
    /// </summary>
    let ``U.FRKU`` = _prefix "U.FRKU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.FRSU"></see>
    /// </summary>
    let ``U.FRSU`` = _prefix "U.FRSU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.FRZU"></see>
    /// </summary>
    let ``U.FRZU`` = _prefix "U.FRZU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.FURU"></see>
    /// </summary>
    let ``U.FURU`` = _prefix "U.FURU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.GAPU"></see>
    /// </summary>
    let ``U.GAPU`` = _prefix "U.GAPU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.GLYU"></see>
    /// </summary>
    let ``U.GLYU`` = _prefix "U.GLYU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.HLLU"></see>
    /// </summary>
    let ``U.HLLU`` = _prefix "U.HLLU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.HLSU"></see>
    /// </summary>
    let ``U.HLSU`` = _prefix "U.HLSU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.HOLU"></see>
    /// </summary>
    let ``U.HOLU`` = _prefix "U.HOLU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.KNLU"></see>
    /// </summary>
    let ``U.KNLU`` = _prefix "U.KNLU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.KNSU"></see>
    /// </summary>
    let ``U.KNSU`` = _prefix "U.KNSU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.LDGU"></see>
    /// </summary>
    let ``U.LDGU`` = _prefix "U.LDGU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.LEVU"></see>
    /// </summary>
    let ``U.LEVU`` = _prefix "U.LEVU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.MDVU"></see>
    /// </summary>
    let ``U.MDVU`` = _prefix "U.MDVU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.MESU"></see>
    /// </summary>
    let ``U.MESU`` = _prefix "U.MESU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.MNDU"></see>
    /// </summary>
    let ``U.MNDU`` = _prefix "U.MNDU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.MOTU"></see>
    /// </summary>
    let ``U.MOTU`` = _prefix "U.MOTU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.MTSU"></see>
    /// </summary>
    let ``U.MTSU`` = _prefix "U.MTSU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.MTU"></see>
    /// </summary>
    let ``U.MTU`` = _prefix "U.MTU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.PKSU"></see>
    /// </summary>
    let ``U.PKSU`` = _prefix "U.PKSU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.PKU"></see>
    /// </summary>
    let ``U.PKU`` = _prefix "U.PKU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.PLFU"></see>
    /// </summary>
    let ``U.PLFU`` = _prefix "U.PLFU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.PLNU"></see>
    /// </summary>
    let ``U.PLNU`` = _prefix "U.PLNU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.PLTU"></see>
    /// </summary>
    let ``U.PLTU`` = _prefix "U.PLTU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.PNLU"></see>
    /// </summary>
    let ``U.PNLU`` = _prefix "U.PNLU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.PRVU"></see>
    /// </summary>
    let ``U.PRVU`` = _prefix "U.PRVU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.RAVU"></see>
    /// </summary>
    let ``U.RAVU`` = _prefix "U.RAVU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.RDGU"></see>
    /// </summary>
    let ``U.RDGU`` = _prefix "U.RDGU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.RDSU"></see>
    /// </summary>
    let ``U.RDSU`` = _prefix "U.RDSU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.RFSU"></see>
    /// </summary>
    let ``U.RFSU`` = _prefix "U.RFSU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.RFU"></see>
    /// </summary>
    let ``U.RFU`` = _prefix "U.RFU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.RISU"></see>
    /// </summary>
    let ``U.RISU`` = _prefix "U.RISU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.RMPU"></see>
    /// </summary>
    let ``U.RMPU`` = _prefix "U.RMPU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.RNGU"></see>
    /// </summary>
    let ``U.RNGU`` = _prefix "U.RNGU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.SCNU"></see>
    /// </summary>
    let ``U.SCNU`` = _prefix "U.SCNU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.SCSU"></see>
    /// </summary>
    let ``U.SCSU`` = _prefix "U.SCSU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.SDLU"></see>
    /// </summary>
    let ``U.SDLU`` = _prefix "U.SDLU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.SHFU"></see>
    /// </summary>
    let ``U.SHFU`` = _prefix "U.SHFU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.SHLU"></see>
    /// </summary>
    let ``U.SHLU`` = _prefix "U.SHLU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.SHSU"></see>
    /// </summary>
    let ``U.SHSU`` = _prefix "U.SHSU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.SHVU"></see>
    /// </summary>
    let ``U.SHVU`` = _prefix "U.SHVU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.SILU"></see>
    /// </summary>
    let ``U.SILU`` = _prefix "U.SILU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.SLPU"></see>
    /// </summary>
    let ``U.SLPU`` = _prefix "U.SLPU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.SMSU"></see>
    /// </summary>
    let ``U.SMSU`` = _prefix "U.SMSU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.SMU"></see>
    /// </summary>
    let ``U.SMU`` = _prefix "U.SMU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.SPRU"></see>
    /// </summary>
    let ``U.SPRU`` = _prefix "U.SPRU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.TERU"></see>
    /// </summary>
    let ``U.TERU`` = _prefix "U.TERU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.TMSU"></see>
    /// </summary>
    let ``U.TMSU`` = _prefix "U.TMSU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.TMTU"></see>
    /// </summary>
    let ``U.TMTU`` = _prefix "U.TMTU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.TNGU"></see>
    /// </summary>
    let ``U.TNGU`` = _prefix "U.TNGU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.TRGU"></see>
    /// </summary>
    let ``U.TRGU`` = _prefix "U.TRGU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.TRNU"></see>
    /// </summary>
    let ``U.TRNU`` = _prefix "U.TRNU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.VALU"></see>
    /// </summary>
    let ``U.VALU`` = _prefix "U.VALU"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#U.VLSU"></see>
    /// </summary>
    let ``U.VLSU`` = _prefix "U.VLSU"
    /// <summary>
    /// forest, heath, ...
    /// <see href="http://www.geonames.org/ontology#V"></see></summary>
    let V = _prefix "V"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#V.BUSH"></see>
    /// </summary>
    let ``V.BUSH`` = _prefix "V.BUSH"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#V.CULT"></see>
    /// </summary>
    let ``V.CULT`` = _prefix "V.CULT"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#V.FRST"></see>
    /// </summary>
    let ``V.FRST`` = _prefix "V.FRST"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#V.FRSTF"></see>
    /// </summary>
    let ``V.FRSTF`` = _prefix "V.FRSTF"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#V.GRSLD"></see>
    /// </summary>
    let ``V.GRSLD`` = _prefix "V.GRSLD"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#V.GRVC"></see>
    /// </summary>
    let ``V.GRVC`` = _prefix "V.GRVC"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#V.GRVO"></see>
    /// </summary>
    let ``V.GRVO`` = _prefix "V.GRVO"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#V.GRVP"></see>
    /// </summary>
    let ``V.GRVP`` = _prefix "V.GRVP"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#V.GRVPN"></see>
    /// </summary>
    let ``V.GRVPN`` = _prefix "V.GRVPN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#V.HTH"></see>
    /// </summary>
    let ``V.HTH`` = _prefix "V.HTH"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#V.MDW"></see>
    /// </summary>
    let ``V.MDW`` = _prefix "V.MDW"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#V.OCH"></see>
    /// </summary>
    let ``V.OCH`` = _prefix "V.OCH"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#V.SCRB"></see>
    /// </summary>
    let ``V.SCRB`` = _prefix "V.SCRB"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#V.TREE"></see>
    /// </summary>
    let ``V.TREE`` = _prefix "V.TREE"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#V.TUND"></see>
    /// </summary>
    let ``V.TUND`` = _prefix "V.TUND"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#V.VIN"></see>
    /// </summary>
    let ``V.VIN`` = _prefix "V.VIN"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#V.VINS"></see>
    /// </summary>
    let ``V.VINS`` = _prefix "V.VINS"
    /// <summary>
    /// A Wikipedia article
    /// <see href="http://www.geonames.org/ontology#WikipediaArticle"></see></summary>
    let WikipediaArticle = _prefix "WikipediaArticle"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#alternateName"></see>
    /// </summary>
    let alternateName = _prefix "alternateName"
    /// <summary>
    /// Links to an RDF document containing the descriptions of children features
    /// <see href="http://www.geonames.org/ontology#childrenFeatures"></see></summary>
    let childrenFeatures = _prefix "childrenFeatures"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#colloquialName"></see>
    /// </summary>
    let colloquialName = _prefix "colloquialName"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#historicalName"></see>
    /// </summary>
    let historicalName = _prefix "historicalName"
    /// <summary>
    /// Indicates that the subject resource is located in the object feature
    /// <see href="http://www.geonames.org/ontology#locatedIn"></see></summary>
    let locatedIn = _prefix "locatedIn"
    /// <summary>
    /// A geonames map centered on the feature.
    /// <see href="http://www.geonames.org/ontology#locationMap"></see></summary>
    let locationMap = _prefix "locationMap"
    /// <summary>
    /// A feature close to the reference feature
    /// <see href="http://www.geonames.org/ontology#nearby"></see></summary>
    let nearby = _prefix "nearby"
    /// <summary>
    /// Links to an RDF document containing the descriptions of nearby features
    /// <see href="http://www.geonames.org/ontology#nearbyFeatures"></see></summary>
    let nearbyFeatures = _prefix "nearbyFeatures"
    /// <summary>
    /// A feature sharing a common boarder with the reference feature
    /// <see href="http://www.geonames.org/ontology#neighbour"></see></summary>
    let neighbour = _prefix "neighbour"
    /// <summary>
    /// Links to an RDF document containing the descriptions of neighbouring features. Applies when the feature has definite boarders.
    /// <see href="http://www.geonames.org/ontology#neighbouringFeatures"></see></summary>
    let neighbouringFeatures = _prefix "neighbouringFeatures"
    /// <summary>
    /// A name in an official local language
    /// <see href="http://www.geonames.org/ontology#officialName"></see></summary>
    let officialName = _prefix "officialName"
    /// <summary>
    /// A feature parent of the current one, in either administrative or physical subdivision.
    /// <see href="http://www.geonames.org/ontology#parentFeature"></see></summary>
    let parentFeature = _prefix "parentFeature"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#parentCountry"></see>
    /// </summary>
    let parentCountry = _prefix "parentCountry"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#postalCode"></see>
    /// </summary>
    let postalCode = _prefix "postalCode"
    /// <summary>
    ///   <see href="http://www.geonames.org/ontology#shortName"></see>
    /// </summary>
    let shortName = _prefix "shortName"
    /// <summary>
    /// A Wikipedia article of which subject is the resource.
    /// <see href="http://www.geonames.org/ontology#wikipediaArticle"></see></summary>
    let wikipediaArticle = _prefix "wikipediaArticle"

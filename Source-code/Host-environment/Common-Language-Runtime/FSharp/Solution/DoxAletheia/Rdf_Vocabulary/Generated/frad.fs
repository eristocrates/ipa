namespace http.iflastandards.info.ns.fr.frad.slash

open DoxAletheia

module frad =
    let _namespace_name = "http://iflastandards.info/ns/fr/frad/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Description is modified from: Guidelines for authority records and references / revised by the Working Group on GARE Revision. Second edition.  München : K.G. Saur, 2001.
    /// <see href="http://iflastandards.info/ns/fr/frad/C1001"></see></summary>
    let C1001 = _prefix "C1001"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/C1002"></see>
    /// </summary>
    let C1002 = _prefix "C1002"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/C1010"></see>
    /// </summary>
    let C1010 = _prefix "C1010"
    /// <summary>
    /// Description is modified from that in Functional requirements for bibliographic records : final report, by the IFLA Study Group on the Functional Requirements for Bibliographic Records, published by K.G. Saur, 1998.
    /// <see href="http://iflastandards.info/ns/fr/frad/C1003"></see></summary>
    let C1003 = _prefix "C1003"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/C1006"></see>
    /// </summary>
    let C1006 = _prefix "C1006"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/C1007"></see>
    /// </summary>
    let C1007 = _prefix "C1007"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/C1008"></see>
    /// </summary>
    let C1008 = _prefix "C1008"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/C1009"></see>
    /// </summary>
    let C1009 = _prefix "C1009"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/C1011"></see>
    /// </summary>
    let C1011 = _prefix "C1011"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/C1012"></see>
    /// </summary>
    let C1012 = _prefix "C1012"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/C1013"></see>
    /// </summary>
    let C1013 = _prefix "C1013"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/C1014"></see>
    /// </summary>
    let C1014 = _prefix "C1014"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P2001"></see>
    /// </summary>
    let P2001 = _prefix "P2001"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P2002"></see>
    /// </summary>
    let P2002 = _prefix "P2002"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3020"></see>
    /// </summary>
    let P3020 = _prefix "P3020"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3019"></see>
    /// </summary>
    let P3019 = _prefix "P3019"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P2003"></see>
    /// </summary>
    let P2003 = _prefix "P2003"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P2004"></see>
    /// </summary>
    let P2004 = _prefix "P2004"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P2005"></see>
    /// </summary>
    let P2005 = _prefix "P2005"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P2006"></see>
    /// </summary>
    let P2006 = _prefix "P2006"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P2007"></see>
    /// </summary>
    let P2007 = _prefix "P2007"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P2008"></see>
    /// </summary>
    let P2008 = _prefix "P2008"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P2009"></see>
    /// </summary>
    let P2009 = _prefix "P2009"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P2010"></see>
    /// </summary>
    let P2010 = _prefix "P2010"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P2011"></see>
    /// </summary>
    let P2011 = _prefix "P2011"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P2012"></see>
    /// </summary>
    let P2012 = _prefix "P2012"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3021"></see>
    /// </summary>
    let P3021 = _prefix "P3021"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P2013"></see>
    /// </summary>
    let P2013 = _prefix "P2013"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P2014"></see>
    /// </summary>
    let P2014 = _prefix "P2014"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P2015"></see>
    /// </summary>
    let P2015 = _prefix "P2015"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P2016"></see>
    /// </summary>
    let P2016 = _prefix "P2016"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P2017"></see>
    /// </summary>
    let P2017 = _prefix "P2017"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P2018"></see>
    /// </summary>
    let P2018 = _prefix "P2018"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P2019"></see>
    /// </summary>
    let P2019 = _prefix "P2019"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P2020"></see>
    /// </summary>
    let P2020 = _prefix "P2020"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P2028"></see>
    /// </summary>
    let P2028 = _prefix "P2028"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P2021"></see>
    /// </summary>
    let P2021 = _prefix "P2021"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P2022"></see>
    /// </summary>
    let P2022 = _prefix "P2022"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P2023"></see>
    /// </summary>
    let P2023 = _prefix "P2023"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P2024"></see>
    /// </summary>
    let P2024 = _prefix "P2024"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P2025"></see>
    /// </summary>
    let P2025 = _prefix "P2025"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P2026"></see>
    /// </summary>
    let P2026 = _prefix "P2026"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P2027"></see>
    /// </summary>
    let P2027 = _prefix "P2027"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P2029"></see>
    /// </summary>
    let P2029 = _prefix "P2029"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P2030"></see>
    /// </summary>
    let P2030 = _prefix "P2030"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P2031"></see>
    /// </summary>
    let P2031 = _prefix "P2031"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P2032"></see>
    /// </summary>
    let P2032 = _prefix "P2032"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P2033"></see>
    /// </summary>
    let P2033 = _prefix "P2033"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P2034"></see>
    /// </summary>
    let P2034 = _prefix "P2034"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P2035"></see>
    /// </summary>
    let P2035 = _prefix "P2035"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P2036"></see>
    /// </summary>
    let P2036 = _prefix "P2036"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P2037"></see>
    /// </summary>
    let P2037 = _prefix "P2037"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3001"></see>
    /// </summary>
    let P3001 = _prefix "P3001"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3002"></see>
    /// </summary>
    let P3002 = _prefix "P3002"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3003"></see>
    /// </summary>
    let P3003 = _prefix "P3003"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3004"></see>
    /// </summary>
    let P3004 = _prefix "P3004"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3005"></see>
    /// </summary>
    let P3005 = _prefix "P3005"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3006"></see>
    /// </summary>
    let P3006 = _prefix "P3006"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3007"></see>
    /// </summary>
    let P3007 = _prefix "P3007"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3017"></see>
    /// </summary>
    let P3017 = _prefix "P3017"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3009"></see>
    /// </summary>
    let P3009 = _prefix "P3009"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4018"></see>
    /// </summary>
    let P4018 = _prefix "P4018"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3008"></see>
    /// </summary>
    let P3008 = _prefix "P3008"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3010"></see>
    /// </summary>
    let P3010 = _prefix "P3010"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3011"></see>
    /// </summary>
    let P3011 = _prefix "P3011"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3012"></see>
    /// </summary>
    let P3012 = _prefix "P3012"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3013"></see>
    /// </summary>
    let P3013 = _prefix "P3013"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3014"></see>
    /// </summary>
    let P3014 = _prefix "P3014"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3015"></see>
    /// </summary>
    let P3015 = _prefix "P3015"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3016"></see>
    /// </summary>
    let P3016 = _prefix "P3016"
    /// <summary>
    /// Sometimes referred to as a "qualifier".
    /// <see href="http://iflastandards.info/ns/fr/frad/P3018"></see></summary>
    let P3018 = _prefix "P3018"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3022"></see>
    /// </summary>
    let P3022 = _prefix "P3022"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3023"></see>
    /// </summary>
    let P3023 = _prefix "P3023"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3024"></see>
    /// </summary>
    let P3024 = _prefix "P3024"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3025"></see>
    /// </summary>
    let P3025 = _prefix "P3025"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3026"></see>
    /// </summary>
    let P3026 = _prefix "P3026"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3027"></see>
    /// </summary>
    let P3027 = _prefix "P3027"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3028"></see>
    /// </summary>
    let P3028 = _prefix "P3028"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3029"></see>
    /// </summary>
    let P3029 = _prefix "P3029"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3030"></see>
    /// </summary>
    let P3030 = _prefix "P3030"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3032"></see>
    /// </summary>
    let P3032 = _prefix "P3032"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3033"></see>
    /// </summary>
    let P3033 = _prefix "P3033"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3035"></see>
    /// </summary>
    let P3035 = _prefix "P3035"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3037"></see>
    /// </summary>
    let P3037 = _prefix "P3037"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3039"></see>
    /// </summary>
    let P3039 = _prefix "P3039"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3034"></see>
    /// </summary>
    let P3034 = _prefix "P3034"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3036"></see>
    /// </summary>
    let P3036 = _prefix "P3036"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3038"></see>
    /// </summary>
    let P3038 = _prefix "P3038"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3031"></see>
    /// </summary>
    let P3031 = _prefix "P3031"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3040"></see>
    /// </summary>
    let P3040 = _prefix "P3040"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3042"></see>
    /// </summary>
    let P3042 = _prefix "P3042"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3041"></see>
    /// </summary>
    let P3041 = _prefix "P3041"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3043"></see>
    /// </summary>
    let P3043 = _prefix "P3043"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3045"></see>
    /// </summary>
    let P3045 = _prefix "P3045"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3046"></see>
    /// </summary>
    let P3046 = _prefix "P3046"
    /// <summary>
    /// Scope note not present in original documentation; added to clarify semantic difference with "is part (item)" property (http://iflastandards.info/ns/fr/frbr/frbrer/P2092).
    /// <see href="http://iflastandards.info/ns/fr/frad/P3047"></see></summary>
    let P3047 = _prefix "P3047"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3048"></see>
    /// </summary>
    let P3048 = _prefix "P3048"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3049"></see>
    /// </summary>
    let P3049 = _prefix "P3049"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3050"></see>
    /// </summary>
    let P3050 = _prefix "P3050"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3051"></see>
    /// </summary>
    let P3051 = _prefix "P3051"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P3052"></see>
    /// </summary>
    let P3052 = _prefix "P3052"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4001"></see>
    /// </summary>
    let P4001 = _prefix "P4001"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4003"></see>
    /// </summary>
    let P4003 = _prefix "P4003"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4002"></see>
    /// </summary>
    let P4002 = _prefix "P4002"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4004"></see>
    /// </summary>
    let P4004 = _prefix "P4004"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4005"></see>
    /// </summary>
    let P4005 = _prefix "P4005"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4006"></see>
    /// </summary>
    let P4006 = _prefix "P4006"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4007"></see>
    /// </summary>
    let P4007 = _prefix "P4007"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4008"></see>
    /// </summary>
    let P4008 = _prefix "P4008"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4009"></see>
    /// </summary>
    let P4009 = _prefix "P4009"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4010"></see>
    /// </summary>
    let P4010 = _prefix "P4010"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4011"></see>
    /// </summary>
    let P4011 = _prefix "P4011"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4012"></see>
    /// </summary>
    let P4012 = _prefix "P4012"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4013"></see>
    /// </summary>
    let P4013 = _prefix "P4013"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4014"></see>
    /// </summary>
    let P4014 = _prefix "P4014"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4015"></see>
    /// </summary>
    let P4015 = _prefix "P4015"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4016"></see>
    /// </summary>
    let P4016 = _prefix "P4016"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/1003"></see>
    /// </summary>
    let _1003 = _prefix "1003"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4017"></see>
    /// </summary>
    let P4017 = _prefix "P4017"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4019"></see>
    /// </summary>
    let P4019 = _prefix "P4019"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4021"></see>
    /// </summary>
    let P4021 = _prefix "P4021"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4022"></see>
    /// </summary>
    let P4022 = _prefix "P4022"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4024"></see>
    /// </summary>
    let P4024 = _prefix "P4024"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4025"></see>
    /// </summary>
    let P4025 = _prefix "P4025"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4026"></see>
    /// </summary>
    let P4026 = _prefix "P4026"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4032"></see>
    /// </summary>
    let P4032 = _prefix "P4032"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4027"></see>
    /// </summary>
    let P4027 = _prefix "P4027"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4028"></see>
    /// </summary>
    let P4028 = _prefix "P4028"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4029"></see>
    /// </summary>
    let P4029 = _prefix "P4029"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4030"></see>
    /// </summary>
    let P4030 = _prefix "P4030"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4031"></see>
    /// </summary>
    let P4031 = _prefix "P4031"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4033"></see>
    /// </summary>
    let P4033 = _prefix "P4033"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4034"></see>
    /// </summary>
    let P4034 = _prefix "P4034"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4035"></see>
    /// </summary>
    let P4035 = _prefix "P4035"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4036"></see>
    /// </summary>
    let P4036 = _prefix "P4036"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4037"></see>
    /// </summary>
    let P4037 = _prefix "P4037"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4040"></see>
    /// </summary>
    let P4040 = _prefix "P4040"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4038"></see>
    /// </summary>
    let P4038 = _prefix "P4038"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4039"></see>
    /// </summary>
    let P4039 = _prefix "P4039"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4041"></see>
    /// </summary>
    let P4041 = _prefix "P4041"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4042"></see>
    /// </summary>
    let P4042 = _prefix "P4042"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4043"></see>
    /// </summary>
    let P4043 = _prefix "P4043"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4044"></see>
    /// </summary>
    let P4044 = _prefix "P4044"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4045"></see>
    /// </summary>
    let P4045 = _prefix "P4045"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4046"></see>
    /// </summary>
    let P4046 = _prefix "P4046"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4047"></see>
    /// </summary>
    let P4047 = _prefix "P4047"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4048"></see>
    /// </summary>
    let P4048 = _prefix "P4048"
    /// <summary>
    ///   <see href="http://iflastandards.info/ns/fr/frad/P4049"></see>
    /// </summary>
    let P4049 = _prefix "P4049"

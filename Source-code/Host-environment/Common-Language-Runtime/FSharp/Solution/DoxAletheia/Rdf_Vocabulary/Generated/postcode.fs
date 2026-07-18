namespace http.data.ordnancesurvey.co.uk.ontology.postcode.slash

open DoxAletheia.Rdf_Vocabulary

module postcode =
    let _namespace_name = "http://data.ordnancesurvey.co.uk/ontology/postcode/"
    /// <summary>
    /// NHS health authority code
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/postcode/LH"></see></summary>
    let LH = Namespaced_IRI.parse _namespace_name "LH" |> NamespacedName
    /// <summary>
    /// English Strategic Health Authority or Scottish Health Board in which Code-Point Open location coordinate falls.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/postcode/nhsHA"></see></summary>
    let nhsHA = Namespaced_IRI.parse _namespace_name "nhsHA" |> NamespacedName
    /// <summary>
    /// Positional Quality Indicator (see http://www.ordnancesurvey.co.uk/oswebsite/products/codepoint/pdf/cpuserguide.pdf)
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/postcode/PQ"></see></summary>
    let PQ = Namespaced_IRI.parse _namespace_name "PQ" |> NamespacedName

    /// <summary>
    /// Indicates the source of the data indicator used and, hence, the quality of the
    /// coordinates provided for each record. It is determined by the best available
    /// data in ADDRESS-POINT.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/postcode/positionalQualityIndicator"></see></summary>
    let positionalQualityIndicator =
        Namespaced_IRI.parse _namespace_name "positionalQualityIndicator" |> NamespacedName

    /// <summary>
    /// The importance of checking the Positional Quality Indicator (PQI), to establish Code-Point Open location coordinate (CPLC) positional quality, cannot be overemphasised.
    ///
    /// It indicates the positional accuracy of the Code-Point Open coordinates. There are seven PQI values for the positional quality of CPLCs. The order shown indicates the level of quality associated with the PQI; PQ10 is the most accurate and PQ90 the least. The PQI assigned to the CPLC will depend on the coordinates available in ADDRESS-POINT to generate the CPLC. If the ADDRESS-POINT PQI is PQ3, the best it can be, then the Code-Point Open PQI will be PQ10.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/postcode/PositionalQualityIndicator"></see></summary>
    let PositionalQualityIndicator =
        Namespaced_IRI.parse _namespace_name "PositionalQualityIndicator" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ordnancesurvey.co.uk/ontology/postcode/PostCodeType"></see>
    /// </summary>
    let PostCodeType =
        Namespaced_IRI.parse _namespace_name "PostCodeType" |> NamespacedName

    /// <summary>
    /// An area given a unique alphabetic coding by Royal Mail to facilitate the delivering of mail. The area is identified by one or two alpha characters at the start of the full postcode, the letters being derived from a town, city or district falling within the postcode area. There are, at present, 120 postcode areas in Great Britain, for example, SO for Southampton, MK for Milton Keynes, B for Birmingham or W for London West. The postcode area code constitutes the first part of the outward code.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/postcode/PostcodeArea"></see></summary>
    let PostcodeArea =
        Namespaced_IRI.parse _namespace_name "PostcodeArea" |> NamespacedName

    /// <summary>
    /// A sub-area of the postcode area, specified by the character sub-string within the first half of a full postcode, which may be numeric, alphabetic or alphanumeric; for example, 42 from MK42 6GH or 1A from W1A 4WW. There are approximately 2 800 postcode districts in Great Britain.
    /// NOTE: there are certain non-geographic districts. In these instances, a district code is allocated to cover all large users in the postcode area.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/postcode/PostcodeDistrict"></see></summary>
    let PostcodeDistrict =
        Namespaced_IRI.parse _namespace_name "PostcodeDistrict" |> NamespacedName

    /// <summary>
    /// A sub-area of a postcode district, whose area is identified by the number third from the end of a full postcode. There are approximately 9000 postcode sectors in Great Britain. An example of a postcode sector code is 3, from GU12 3DH.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/postcode/PostcodeSector"></see></summary>
    let PostcodeSector =
        Namespaced_IRI.parse _namespace_name "PostcodeSector" |> NamespacedName

    /// <summary>
    /// An area covered by a particular postcode. Postcodes are an alphanumeric abbreviated form of address. Postcode units are unique references and identify an average of 15 addresses. In some cases, where an address receives a substantial amount of mail, a postcode will apply to only one address (a large-user postcode). The maximum number of addresses in a postcode is 100.
    ///
    /// A sub-area of a postcode sector, indicated by the two letters of the inward postcode, which identifies one or more small-user postcode delivery points or an individual large-user postcode. There are approximately 1.7 million postcode units in the UK.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/postcode/PostcodeUnit"></see></summary>
    let PostcodeUnit =
        Namespaced_IRI.parse _namespace_name "PostcodeUnit" |> NamespacedName

    /// <summary>
    /// NHS regional health authority code
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/postcode/RH"></see></summary>
    let RH = Namespaced_IRI.parse _namespace_name "RH" |> NamespacedName

    /// <summary>
    /// English Pan Strategic Health Authority in which Code-Point Open location coordinate falls.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/postcode/nhsRegionalHA"></see></summary>
    let nhsRegionalHA =
        Namespaced_IRI.parse _namespace_name "nhsRegionalHA" |> NamespacedName

    /// <summary>
    /// The country that the Code-Point Open location coordinate lies in.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/postcode/country"></see></summary>
    let country = Namespaced_IRI.parse _namespace_name "country" |> NamespacedName
    /// <summary>
    /// County in which Code-Point Open location coordinate falls.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/postcode/county"></see></summary>
    let county = Namespaced_IRI.parse _namespace_name "county" |> NamespacedName
    /// <summary>
    /// Unitary Authority, Metropolitan and Non- Metropolitan District, London
    /// Borough or Scottish Council Area in which Code-Point Open location coordinate falls.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/postcode/district"></see></summary>
    let district = Namespaced_IRI.parse _namespace_name "district" |> NamespacedName
    /// <summary>
    /// This property lets you relate an object to its PostcodeUnit.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/postcode/postcode"></see></summary>
    let postcode = Namespaced_IRI.parse _namespace_name "postcode" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ordnancesurvey.co.uk/ontology/postcode/pqi"></see>
    /// </summary>
    let pqi = Namespaced_IRI.parse _namespace_name "pqi" |> NamespacedName
    /// <summary>
    /// Within the building of the matched address closest to the postcode mean determined automatically by Ordnance Survey.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/postcode/pqi/10"></see></summary>
    let ``pqi/10`` = Namespaced_IRI.parse _namespace_name "pqi/10" |> NamespacedName
    /// <summary>
    /// As above, but determined by visual inspection by NRS.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/postcode/pqi/20"></see></summary>
    let ``pqi/20`` = Namespaced_IRI.parse _namespace_name "pqi/20" |> NamespacedName
    /// <summary>
    /// Approximate to within 50 m of true position (postcodes relating to developing sites may be within 100 m of true position).
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/postcode/pqi/30"></see></summary>
    let ``pqi/30`` = Namespaced_IRI.parse _namespace_name "pqi/30" |> NamespacedName
    /// <summary>
    /// The mean of the positions of addresses previously matched in ADDRESS-POINT but that have subsequently been deleted or recoded (very rarely used).
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/postcode/pqi/40"></see></summary>
    let ``pqi/40`` = Namespaced_IRI.parse _namespace_name "pqi/40" |> NamespacedName
    /// <summary>
    /// Estimated position based on surrounding postcode coordinates, usually to 100m resolution, but 10 m in Scotland.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/postcode/pqi/50"></see></summary>
    let ``pqi/50`` = Namespaced_IRI.parse _namespace_name "pqi/50" |> NamespacedName
    /// <summary>
    /// Postcode sector mean (direct copy from ADDRESS-POINT).
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/postcode/pqi/60"></see></summary>
    let ``pqi/60`` = Namespaced_IRI.parse _namespace_name "pqi/60" |> NamespacedName
    /// <summary>
    /// No coordinates available.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/postcode/pqi/90"></see></summary>
    let ``pqi/90`` = Namespaced_IRI.parse _namespace_name "pqi/90" |> NamespacedName
    /// <summary>
    /// Electoral Ward or Division in which Code-Point Open location coordinate falls.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/postcode/ward"></see></summary>
    let ward = Namespaced_IRI.parse _namespace_name "ward" |> NamespacedName

namespace http.data.ordnancesurvey.co.uk.ontology.postcode.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ospost =
    let _namespace_iri = Namespace_Iri ospost |> NamespaceIRI
    /// <summary>
    ///   <para>ospost:LH</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>NHS health authority code</para>
    /// labels<para>LH</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/postcode/LH">http://data.ordnancesurvey.co.uk/ontology/postcode/LH</seealso>
    let LH = Prefixed_Name(ospost, "LH") |> PrefixedName
    /// <summary>
    ///   <para>ospost:PostCodeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Postcode Type</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/postcode/PostCodeType">http://data.ordnancesurvey.co.uk/ontology/postcode/PostCodeType</seealso>
    let PostCodeType = Prefixed_Name(ospost, "PostCodeType") |> PrefixedName
    /// <summary>
    ///   <para>ospost:PostcodeDistrict</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A sub-area of the postcode area, specified by the character sub-string within the first half of a full postcode, which may be numeric, alphabetic or alphanumeric; for example, 42 from MK42 6GH or 1A from W1A 4WW. There are approximately 2 800 postcode districts in Great Britain.
    /// NOTE: there are certain non-geographic districts. In these instances, a district code is allocated to cover all large users in the postcode area.</para>
    /// labels<para>Postcode District</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/postcode/PostcodeDistrict">http://data.ordnancesurvey.co.uk/ontology/postcode/PostcodeDistrict</seealso>
    let PostcodeDistrict = Prefixed_Name(ospost, "PostcodeDistrict") |> PrefixedName
    /// <summary>
    ///   <para>ospost:county</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>County in which Code-Point Open location coordinate falls.</para>
    /// labels<para>county</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/postcode/county">http://data.ordnancesurvey.co.uk/ontology/postcode/county</seealso>
    let county = Prefixed_Name(ospost, "county") |> PrefixedName
    /// <summary>
    ///   <para>ospost:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>An ontology describing the postcode geography in Great Britain.</para>
    /// labels<para>Postcode Ontology</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/postcode/">http://data.ordnancesurvey.co.uk/ontology/postcode/</seealso>
    let _prefix_iri = Prefixed_Name(ospost, "") |> PrefixedName
    /// <summary>
    ///   <para>ospost:PQ</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Positional Quality Indicator (see http://www.ordnancesurvey.co.uk/oswebsite/products/codepoint/pdf/cpuserguide.pdf)</para>
    /// labels<para>PQ</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/postcode/PQ">http://data.ordnancesurvey.co.uk/ontology/postcode/PQ</seealso>
    let PQ = Prefixed_Name(ospost, "PQ") |> PrefixedName
    /// <summary>
    ///   <para>ospost:PostcodeArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An area given a unique alphabetic coding by Royal Mail to facilitate the delivering of mail. The area is identified by one or two alpha characters at the start of the full postcode, the letters being derived from a town, city or district falling within the postcode area. There are, at present, 120 postcode areas in Great Britain, for example, SO for Southampton, MK for Milton Keynes, B for Birmingham or W for London West. The postcode area code constitutes the first part of the outward code.</para>
    /// labels<para>Postcode Area</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/postcode/PostcodeArea">http://data.ordnancesurvey.co.uk/ontology/postcode/PostcodeArea</seealso>
    let PostcodeArea = Prefixed_Name(ospost, "PostcodeArea") |> PrefixedName
    /// <summary>
    ///   <para>ospost:nhsHA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>English Strategic Health Authority or Scottish Health Board in which Code-Point Open location coordinate falls.</para>
    /// labels<para>NHS Health Authority</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/postcode/nhsHA">http://data.ordnancesurvey.co.uk/ontology/postcode/nhsHA</seealso>
    let nhsHA = Prefixed_Name(ospost, "nhsHA") |> PrefixedName
    /// <summary>
    ///   <para>ospost:RH</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>NHS regional health authority code</para>
    /// labels<para>RH</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/postcode/RH">http://data.ordnancesurvey.co.uk/ontology/postcode/RH</seealso>
    let RH = Prefixed_Name(ospost, "RH") |> PrefixedName
    /// <summary>
    ///   <para>ospost:PostcodeUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An area covered by a particular postcode. Postcodes are an alphanumeric abbreviated form of address. Postcode units are unique references and identify an average of 15 addresses. In some cases, where an address receives a substantial amount of mail, a postcode will apply to only one address (a large-user postcode). The maximum number of addresses in a postcode is 100.
    ///
    /// A sub-area of a postcode sector, indicated by the two letters of the inward postcode, which identifies one or more small-user postcode delivery points or an individual large-user postcode. There are approximately 1.7 million postcode units in the UK.</para>
    /// labels<para>Postcode Unit</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/postcode/PostcodeUnit">http://data.ordnancesurvey.co.uk/ontology/postcode/PostcodeUnit</seealso>
    let PostcodeUnit = Prefixed_Name(ospost, "PostcodeUnit") |> PrefixedName
    /// <summary>
    ///   <para>ospost:country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The country that the Code-Point Open location coordinate lies in.</para>
    /// labels<para>country</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/postcode/country">http://data.ordnancesurvey.co.uk/ontology/postcode/country</seealso>
    let country = Prefixed_Name(ospost, "country") |> PrefixedName
    /// <summary>
    ///   <para>ospost:nhsRegionalHA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>English Pan Strategic Health Authority in which Code-Point Open location coordinate falls.</para>
    /// labels<para>NHS Regional Health Authority</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/postcode/nhsRegionalHA">http://data.ordnancesurvey.co.uk/ontology/postcode/nhsRegionalHA</seealso>
    let nhsRegionalHA = Prefixed_Name(ospost, "nhsRegionalHA") |> PrefixedName
    /// <summary>
    ///   <para>ospost:district</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Unitary Authority, Metropolitan and Non- Metropolitan District, London
    /// Borough or Scottish Council Area in which Code-Point Open location coordinate falls.</para>
    /// labels<para>district</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/postcode/district">http://data.ordnancesurvey.co.uk/ontology/postcode/district</seealso>
    let district = Prefixed_Name(ospost, "district") |> PrefixedName
    /// <summary>
    ///   <para>ospost:postcode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property lets you relate an object to its PostcodeUnit. </para>
    /// labels<para>postcode</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/postcode/postcode">http://data.ordnancesurvey.co.uk/ontology/postcode/postcode</seealso>
    let postcode = Prefixed_Name(ospost, "postcode") |> PrefixedName
    /// <summary>
    ///   <para>ospost:pqi/10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Within the building of the matched address closest to the postcode mean determined automatically by Ordnance Survey.</para>
    /// labels<para>10</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/postcode/pqi/10">http://data.ordnancesurvey.co.uk/ontology/postcode/pqi/10</seealso>
    let ``pqi/10`` = Prefixed_Name(ospost, "pqi/10") |> PrefixedName
    /// <summary>
    ///   <para>ospost:pqi/20</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>As above, but determined by visual inspection by NRS.</para>
    /// labels<para>20</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/postcode/pqi/20">http://data.ordnancesurvey.co.uk/ontology/postcode/pqi/20</seealso>
    let ``pqi/20`` = Prefixed_Name(ospost, "pqi/20") |> PrefixedName
    /// <summary>
    ///   <para>ospost:pqi/30</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Approximate to within 50 m of true position (postcodes relating to developing sites may be within 100 m of true position).</para>
    /// labels<para>30</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/postcode/pqi/30">http://data.ordnancesurvey.co.uk/ontology/postcode/pqi/30</seealso>
    let ``pqi/30`` = Prefixed_Name(ospost, "pqi/30") |> PrefixedName
    /// <summary>
    ///   <para>ospost:pqi/40</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The mean of the positions of addresses previously matched in ADDRESS-POINT but that have subsequently been deleted or recoded (very rarely used).</para>
    /// labels<para>40</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/postcode/pqi/40">http://data.ordnancesurvey.co.uk/ontology/postcode/pqi/40</seealso>
    let ``pqi/40`` = Prefixed_Name(ospost, "pqi/40") |> PrefixedName
    /// <summary>
    ///   <para>ospost:pqi/90</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>No coordinates available.</para>
    /// labels<para>90</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/postcode/pqi/90">http://data.ordnancesurvey.co.uk/ontology/postcode/pqi/90</seealso>
    let ``pqi/90`` = Prefixed_Name(ospost, "pqi/90") |> PrefixedName
    /// <summary>
    ///   <para>ospost:ward</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Electoral Ward or Division in which Code-Point Open location coordinate falls.</para>
    /// labels<para>ward</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/postcode/ward">http://data.ordnancesurvey.co.uk/ontology/postcode/ward</seealso>
    let ward = Prefixed_Name(ospost, "ward") |> PrefixedName
    /// <summary>
    ///   <para>ospost:pqi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Positional Quality Indicator Concept Scheme</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/postcode/pqi">http://data.ordnancesurvey.co.uk/ontology/postcode/pqi</seealso>
    let pqi = Prefixed_Name(ospost, "pqi") |> PrefixedName
    /// <summary>
    ///   <para>ospost:pqi/50</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Estimated position based on surrounding postcode coordinates, usually to 100m resolution, but 10 m in Scotland.</para>
    /// labels<para>50</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/postcode/pqi/50">http://data.ordnancesurvey.co.uk/ontology/postcode/pqi/50</seealso>
    let ``pqi/50`` = Prefixed_Name(ospost, "pqi/50") |> PrefixedName
    /// <summary>
    ///   <para>ospost:pqi/60</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Postcode sector mean (direct copy from ADDRESS-POINT).</para>
    /// labels<para>60</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/postcode/pqi/60">http://data.ordnancesurvey.co.uk/ontology/postcode/pqi/60</seealso>
    let ``pqi/60`` = Prefixed_Name(ospost, "pqi/60") |> PrefixedName

    /// <summary>
    ///   <para>ospost:positionalQualityIndicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the source of the data indicator used and, hence, the quality of the
    /// coordinates provided for each record. It is determined by the best available
    /// data in ADDRESS-POINT.</para>
    /// labels<para>Positional Quality Indicator</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/postcode/positionalQualityIndicator">http://data.ordnancesurvey.co.uk/ontology/postcode/positionalQualityIndicator</seealso>
    let positionalQualityIndicator =
        Prefixed_Name(ospost, "positionalQualityIndicator") |> PrefixedName

    /// <summary>
    ///   <para>ospost:PositionalQualityIndicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The importance of checking the Positional Quality Indicator (PQI), to establish Code-Point Open location coordinate (CPLC) positional quality, cannot be overemphasised.
    ///
    /// It indicates the positional accuracy of the Code-Point Open coordinates. There are seven PQI values for the positional quality of CPLCs. The order shown indicates the level of quality associated with the PQI; PQ10 is the most accurate and PQ90 the least. The PQI assigned to the CPLC will depend on the coordinates available in ADDRESS-POINT to generate the CPLC. If the ADDRESS-POINT PQI is PQ3, the best it can be, then the Code-Point Open PQI will be PQ10.</para>
    /// labels<para>Positional Quality Indicator</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/postcode/PositionalQualityIndicator">http://data.ordnancesurvey.co.uk/ontology/postcode/PositionalQualityIndicator</seealso>
    let PositionalQualityIndicator =
        Prefixed_Name(ospost, "PositionalQualityIndicator") |> PrefixedName

    /// <summary>
    ///   <para>ospost:PostcodeSector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A sub-area of a postcode district, whose area is identified by the number third from the end of a full postcode. There are approximately 9000 postcode sectors in Great Britain. An example of a postcode sector code is 3, from GU12 3DH.</para>
    /// labels<para>Postcode Sector</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/postcode/PostcodeSector">http://data.ordnancesurvey.co.uk/ontology/postcode/PostcodeSector</seealso>
    let PostcodeSector = Prefixed_Name(ospost, "PostcodeSector") |> PrefixedName

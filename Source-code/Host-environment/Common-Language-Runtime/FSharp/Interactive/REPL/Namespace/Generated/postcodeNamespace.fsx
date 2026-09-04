#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module postcode =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://data.ordnancesurvey.co.uk/ontology/postcode/" "postcode"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : LH^^xsd:string</para>
    ///   <para>rdfs:comment : NHS health authority code^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/postcode/LH">postcode:LH</a>
    /// </summary>
    let LH = _prefixId.prefix "LH"
    /// <summary>
    ///   <para>rdfs:label : PQ^^xsd:string</para>
    ///   <para>rdfs:comment : Positional Quality Indicator (see http://www.ordnancesurvey.co.uk/oswebsite/products/codepoint/pdf/cpuserguide.pdf)^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/postcode/PQ">postcode:PQ</a>
    /// </summary>
    let PQ = _prefixId.prefix "PQ"
    /// <summary>
    ///   <para>rdfs:label : Positional Quality Indicator^^xsd:string</para>
    ///   <para>rdfs:comment : The importance of checking the Positional Quality Indicator (PQI), to establish Code-Point Open location coordinate (CPLC) positional quality, cannot be overemphasised.
    ///
    /// It indicates the positional accuracy of the Code-Point Open coordinates. There are seven PQI values for the positional quality of CPLCs. The order shown indicates the level of quality associated with the PQI; PQ10 is the most accurate and PQ90 the least. The PQI assigned to the CPLC will depend on the coordinates available in ADDRESS-POINT to generate the CPLC. If the ADDRESS-POINT PQI is PQ3, the best it can be, then the Code-Point Open PQI will be PQ10.^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/postcode/PositionalQualityIndicator">postcode:PositionalQualityIndicator</a>
    /// </summary>
    let PositionalQualityIndicator = _prefixId.prefix "PositionalQualityIndicator"
    /// <summary>
    ///   <para>rdfs:label : Postcode Type^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/postcode/PostCodeType">postcode:PostCodeType</a>
    /// </summary>
    let PostCodeType = _prefixId.prefix "PostCodeType"
    /// <summary>
    ///   <para>rdfs:label : Postcode Area^^xsd:string</para>
    ///   <para>rdfs:comment : An area given a unique alphabetic coding by Royal Mail to facilitate the delivering of mail. The area is identified by one or two alpha characters at the start of the full postcode, the letters being derived from a town, city or district falling within the postcode area. There are, at present, 120 postcode areas in Great Britain, for example, SO for Southampton, MK for Milton Keynes, B for Birmingham or W for London West. The postcode area code constitutes the first part of the outward code.^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/postcode/PostcodeArea">postcode:PostcodeArea</a>
    /// </summary>
    let PostcodeArea = _prefixId.prefix "PostcodeArea"
    /// <summary>
    ///   <para>rdfs:label : Postcode District^^xsd:string</para>
    ///   <para>rdfs:comment : A sub-area of the postcode area, specified by the character sub-string within the first half of a full postcode, which may be numeric, alphabetic or alphanumeric; for example, 42 from MK42 6GH or 1A from W1A 4WW. There are approximately 2 800 postcode districts in Great Britain.
    /// NOTE: there are certain non-geographic districts. In these instances, a district code is allocated to cover all large users in the postcode area.^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/postcode/PostcodeDistrict">postcode:PostcodeDistrict</a>
    /// </summary>
    let PostcodeDistrict = _prefixId.prefix "PostcodeDistrict"
    /// <summary>
    ///   <para>rdfs:label : Postcode Sector^^xsd:string</para>
    ///   <para>rdfs:comment : A sub-area of a postcode district, whose area is identified by the number third from the end of a full postcode. There are approximately 9000 postcode sectors in Great Britain. An example of a postcode sector code is 3, from GU12 3DH.^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/postcode/PostcodeSector">postcode:PostcodeSector</a>
    /// </summary>
    let PostcodeSector = _prefixId.prefix "PostcodeSector"
    /// <summary>
    ///   <para>rdfs:label : Postcode Unit^^xsd:string</para>
    ///   <para>rdfs:comment : An area covered by a particular postcode. Postcodes are an alphanumeric abbreviated form of address. Postcode units are unique references and identify an average of 15 addresses. In some cases, where an address receives a substantial amount of mail, a postcode will apply to only one address (a large-user postcode). The maximum number of addresses in a postcode is 100.
    ///
    /// A sub-area of a postcode sector, indicated by the two letters of the inward postcode, which identifies one or more small-user postcode delivery points or an individual large-user postcode. There are approximately 1.7 million postcode units in the UK.^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/postcode/PostcodeUnit">postcode:PostcodeUnit</a>
    /// </summary>
    let PostcodeUnit = _prefixId.prefix "PostcodeUnit"
    /// <summary>
    ///   <para>rdfs:label : RH^^xsd:string</para>
    ///   <para>rdfs:comment : NHS regional health authority code^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/postcode/RH">postcode:RH</a>
    /// </summary>
    let RH = _prefixId.prefix "RH"
    /// <summary>
    ///   <para>rdfs:label : country^^xsd:string</para>
    ///   <para>rdfs:comment : The country that the Code-Point Open location coordinate lies in.^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/postcode/country">postcode:country</a>
    /// </summary>
    let country = _prefixId.prefix "country"
    /// <summary>
    ///   <para>rdfs:label : county^^xsd:string</para>
    ///   <para>rdfs:comment : County in which Code-Point Open location coordinate falls.^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/postcode/county">postcode:county</a>
    /// </summary>
    let county = _prefixId.prefix "county"
    /// <summary>
    ///   <para>rdfs:label : district^^xsd:string</para>
    ///   <para>rdfs:comment : Unitary Authority, Metropolitan and Non- Metropolitan District, London
    /// Borough or Scottish Council Area in which Code-Point Open location coordinate falls.^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/postcode/district">postcode:district</a>
    /// </summary>
    let district = _prefixId.prefix "district"
    /// <summary>
    ///   <para>rdfs:label : NHS Health Authority^^xsd:string</para>
    ///   <para>rdfs:comment : English Strategic Health Authority or Scottish Health Board in which Code-Point Open location coordinate falls.^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/postcode/nhsHA">postcode:nhsHA</a>
    /// </summary>
    let nhsHA = _prefixId.prefix "nhsHA"
    /// <summary>
    ///   <para>rdfs:label : NHS Regional Health Authority^^xsd:string</para>
    ///   <para>rdfs:comment : English Pan Strategic Health Authority in which Code-Point Open location coordinate falls.^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/postcode/nhsRegionalHA">postcode:nhsRegionalHA</a>
    /// </summary>
    let nhsRegionalHA = _prefixId.prefix "nhsRegionalHA"
    /// <summary>
    ///   <para>rdfs:label : Positional Quality Indicator^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the source of the data indicator used and, hence, the quality of the
    /// coordinates provided for each record. It is determined by the best available
    /// data in ADDRESS-POINT.^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/postcode/positionalQualityIndicator">postcode:positionalQualityIndicator</a>
    /// </summary>
    let positionalQualityIndicator = _prefixId.prefix "positionalQualityIndicator"
    /// <summary>
    ///   <para>rdfs:label : postcode^^xsd:string</para>
    ///   <para>rdfs:comment : This property lets you relate an object to its PostcodeUnit. ^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/postcode/postcode">postcode:postcode</a>
    /// </summary>
    let postcode = _prefixId.prefix "postcode"
    let pqi = _prefixId.prefix "pqi"
    /// <summary>
    ///   <para>rdfs:label : ward^^xsd:string</para>
    ///   <para>rdfs:comment : Electoral Ward or Division in which Code-Point Open location coordinate falls.^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/postcode/ward">postcode:ward</a>
    /// </summary>
    let ward = _prefixId.prefix "ward"

namespace http.rdfs.co.juso.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module juso =
    let _namespace_iri = Namespace_Iri juso |> NamespaceIRI
    /// <summary>
    ///   <para>juso:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdfs.co/juso/">http://rdfs.co/juso/</seealso>
    let _prefix_iri = Prefixed_Name(juso, "") |> PrefixedName
    /// <summary>
    ///   <para>juso:0.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:Ontology</para>
    ///   <para>adms:SemanticAsset</para>
    ///   <para>ccrel:Work</para>
    ///   <para>"
    ///     &lt;div&gt;
    ///       The master version of this vocabulary is maintained in &lt;a
    ///       href="https://github.com/listinc/juso-ontology"&gt;the GitHub repository&lt;/a&gt;
    ///       so others can contribute edits and improvements.
    ///     &lt;/div&gt;
    ///     "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"
    ///     Most of the descriptions given here are from Wikipedia or from the related
    ///     ontologies and vocabularies.
    ///     "</para>
    ///   <para>"
    ///     &lt;pre&gt;&lt;code&gt;_:YangyongBldg a juso:Feature ;
    ///   juso:name "Yangyong Building"@en , "양용빌딩"@ko ;
    ///   juso:geometry &amp;lt;http://geohash.org/wydjrzg6ece9&amp;gt; .
    ///
    /// _:LiSTInc a juso:SpatialThing , foaf:Organization ;
    ///   juso:name "LiST Inc."@en , "주식회사 리스트"@ko ;
    ///   juso:within _:YangyongBldg ;
    ///   juso:historical_address [
    ///     a juso:Address ;
    ///     juso:full_address
    ///       "대한민국 서울특별시 영등포구 당산동 121-17 양용빌딩 9층 150-040"@ko ,
    ///       "9th Floor, Yangyong Building, 121-17, Dangsan-dong, Yeongdeungpo-gu, Seoul, 150-040, South Korea"@en ;
    ///     juso:country &amp;lt;http://sws.geonames.org/1835841/&amp;gt; ;
    ///     juso:first_level_administrative_division &amp;lt;http://sws.geonames.org/1835847/&amp;gt; ;
    ///     juso:second_level_administrative_division &amp;lt;http://sws.geonames.org/1832536/&amp;gt; ;
    ///     juso:third_level_administrative_division &amp;lt;http://sws.geonames.org/8692617/&amp;gt; ;
    ///     juso:locator _:YangyongBldg ;
    ///     juso:locator_address "9층"@ko , "9th Floor"@en ;
    ///     juso:postal_code [
    ///       a juso:PostalCode ;
    ///       rdf:value "150-040"
    ///     ]
    ///   ] ;
    ///   juso:address [
    ///     a juso:Address ;
    ///     juso:full_address
    ///       "대한민국 서울특별시 영등포구 버드나루로19길 3 (당산동) 양용빌딩 9층 07229"@ko ,
    ///       "9th Floor, Yangyong Building, 3, Beodeunaru-ro 19-gil, Yeongdeungpo-gu, Seoul, 07229, South Korea"@en ;
    ///     juso:country &amp;lt;http://sws.geonames.org/1835841/&amp;gt; ;
    ///     juso:first_level_administrative_division &amp;lt;http://sws.geonames.org/1835847/&amp;gt; ;
    ///     juso:second_level_administrative_division &amp;lt;http://sws.geonames.org/1832536/&amp;gt; ;
    ///     juso:third_level_administrative_division &amp;lt;http://sws.geonames.org/8692617/&amp;gt; ;
    ///     juso:thoroughfare [
    ///       a juso:Street ;
    ///       juso:name "Beodeunaru-ro 19-gil"@en , "버드나루로19길"@ko ;
    ///       juso:parent &amp;lt;http://sws.geonames.org/8692617/&amp;gt;
    ///     ] ;
    ///     juso:thoroughfare_address "3" ;
    ///     juso:locator _:YangyongBldg ;
    ///     juso:locator_address "9층"@ko , "9th Floor"@en ;
    ///     juso:postal_code [
    ///       a juso:PostalCode ;
    ///       rdf:value "07229"
    ///     ]
    ///   ] .&lt;/code&gt;&lt;/pre&gt;
    ///     "^^&lt;http://www.w3.org/1999/02/22-rdf-syntax-ns#XMLLiteral&gt;</para>
    ///   <para>"
    ///     There is an extension to this ontology with some country-specific terms for
    ///     &lt;a href="http://rdfs.co/juso/kr/"&gt;South Korea&lt;/a&gt;.
    ///     "</para>
    /// labels<para>"LiST Inc."</para></remarks>
    /// <seealso href="http://rdfs.co/juso/0.1">http://rdfs.co/juso/0.1</seealso>
    let ``_0.1`` = Prefixed_Name(juso, "0.1") |> PrefixedName
    /// <summary>
    ///   <para>juso:0.1.2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdfs.co/juso/0.1.2">http://rdfs.co/juso/0.1.2</seealso>
    let ``_0.1.2`` = Prefixed_Name(juso, "0.1.2") |> PrefixedName
    /// <summary>
    ///   <para>juso:0.1/html</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:MediaType</para>
    ///
    /// labels<para>"HTML"</para></remarks>
    /// <seealso href="http://rdfs.co/juso/0.1/html">http://rdfs.co/juso/0.1/html</seealso>
    let ``_0.1/html`` = Prefixed_Name(juso, "0.1/html") |> PrefixedName
    /// <summary>
    ///   <para>juso:0.1/rdf</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:MediaType</para>
    ///
    /// labels<para>"RDF/XML"</para></remarks>
    /// <seealso href="http://rdfs.co/juso/0.1/rdf">http://rdfs.co/juso/0.1/rdf</seealso>
    let ``_0.1/rdf`` = Prefixed_Name(juso, "0.1/rdf") |> PrefixedName
    /// <summary>
    ///   <para>juso:0.1/ttl</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:MediaType</para>
    ///
    /// labels<para>"Turtle"</para></remarks>
    /// <seealso href="http://rdfs.co/juso/0.1/ttl">http://rdfs.co/juso/0.1/ttl</seealso>
    let ``_0.1/ttl`` = Prefixed_Name(juso, "0.1/ttl") |> PrefixedName
    /// <summary>
    ///   <para>juso:Address</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/Address">http://rdfs.co/juso/Address</seealso>
    let Address = Prefixed_Name(juso, "Address") |> PrefixedName
    /// <summary>
    ///   <para>juso:AddressGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Bag</para>
    ///   <para>"
    ///     These classes and properties are used to describe addresses.
    ///     "</para>
    /// labels<para>"Address Terms"</para></remarks>
    /// <seealso href="http://rdfs.co/juso/AddressGroup">http://rdfs.co/juso/AddressGroup</seealso>
    let AddressGroup = Prefixed_Name(juso, "AddressGroup") |> PrefixedName

    /// <summary>
    ///   <para>juso:AdministrativeDivision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/AdministrativeDivision">http://rdfs.co/juso/AdministrativeDivision</seealso>
    let AdministrativeDivision =
        Prefixed_Name(juso, "AdministrativeDivision") |> PrefixedName

    /// <summary>
    ///   <para>juso:Borough</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdfs.co/juso/Borough">http://rdfs.co/juso/Borough</seealso>
    let Borough = Prefixed_Name(juso, "Borough") |> PrefixedName
    /// <summary>
    ///   <para>juso:CapitalDistrict</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/CapitalDistrict">http://rdfs.co/juso/CapitalDistrict</seealso>
    let CapitalDistrict = Prefixed_Name(juso, "CapitalDistrict") |> PrefixedName
    /// <summary>
    ///   <para>juso:City</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/City">http://rdfs.co/juso/City</seealso>
    let City = Prefixed_Name(juso, "City") |> PrefixedName

    /// <summary>
    ///   <para>juso:ConsolidatedCityCounty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/ConsolidatedCityCounty">http://rdfs.co/juso/ConsolidatedCityCounty</seealso>
    let ConsolidatedCityCounty =
        Prefixed_Name(juso, "ConsolidatedCityCounty") |> PrefixedName

    /// <summary>
    ///   <para>juso:CoreGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Bag</para>
    ///   <para>"
    ///     These classes and properties form the core of Juso Ontology. They describe
    ///     fundamental characteristics of geography in relatively broad terms.
    ///     "</para>
    /// labels<para>"Core Terms"</para></remarks>
    /// <seealso href="http://rdfs.co/juso/CoreGroup">http://rdfs.co/juso/CoreGroup</seealso>
    let CoreGroup = Prefixed_Name(juso, "CoreGroup") |> PrefixedName
    /// <summary>
    ///   <para>juso:Country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/Country">http://rdfs.co/juso/Country</seealso>
    let Country = Prefixed_Name(juso, "Country") |> PrefixedName
    /// <summary>
    ///   <para>juso:County</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/County">http://rdfs.co/juso/County</seealso>
    let County = Prefixed_Name(juso, "County") |> PrefixedName
    /// <summary>
    ///   <para>juso:District</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/District">http://rdfs.co/juso/District</seealso>
    let District = Prefixed_Name(juso, "District") |> PrefixedName
    /// <summary>
    ///   <para>juso:Feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/Feature">http://rdfs.co/juso/Feature</seealso>
    let Feature = Prefixed_Name(juso, "Feature") |> PrefixedName
    /// <summary>
    ///   <para>juso:FederatedState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/FederatedState">http://rdfs.co/juso/FederatedState</seealso>
    let FederatedState = Prefixed_Name(juso, "FederatedState") |> PrefixedName

    /// <summary>
    ///   <para>juso:FifthLevelAdministrativeDivision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/FifthLevelAdministrativeDivision">http://rdfs.co/juso/FifthLevelAdministrativeDivision</seealso>
    let FifthLevelAdministrativeDivision =
        Prefixed_Name(juso, "FifthLevelAdministrativeDivision") |> PrefixedName

    /// <summary>
    ///   <para>juso:FirstLevelAdministrativeDivision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/FirstLevelAdministrativeDivision">http://rdfs.co/juso/FirstLevelAdministrativeDivision</seealso>
    let FirstLevelAdministrativeDivision =
        Prefixed_Name(juso, "FirstLevelAdministrativeDivision") |> PrefixedName

    /// <summary>
    ///   <para>juso:FourthLevelAdministrativeDivision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/FourthLevelAdministrativeDivision">http://rdfs.co/juso/FourthLevelAdministrativeDivision</seealso>
    let FourthLevelAdministrativeDivision =
        Prefixed_Name(juso, "FourthLevelAdministrativeDivision") |> PrefixedName

    /// <summary>
    ///   <para>juso:Geometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/Geometry">http://rdfs.co/juso/Geometry</seealso>
    let Geometry = Prefixed_Name(juso, "Geometry") |> PrefixedName
    /// <summary>
    ///   <para>juso:Hamlet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/Hamlet">http://rdfs.co/juso/Hamlet</seealso>
    let Hamlet = Prefixed_Name(juso, "Hamlet") |> PrefixedName
    /// <summary>
    ///   <para>juso:Municipality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/Municipality">http://rdfs.co/juso/Municipality</seealso>
    let Municipality = Prefixed_Name(juso, "Municipality") |> PrefixedName
    /// <summary>
    ///   <para>juso:Neighborhood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/Neighborhood">http://rdfs.co/juso/Neighborhood</seealso>
    let Neighborhood = Prefixed_Name(juso, "Neighborhood") |> PrefixedName
    /// <summary>
    ///   <para>juso:Parish</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/Parish">http://rdfs.co/juso/Parish</seealso>
    let Parish = Prefixed_Name(juso, "Parish") |> PrefixedName
    /// <summary>
    ///   <para>juso:PoliticalDivision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/PoliticalDivision">http://rdfs.co/juso/PoliticalDivision</seealso>
    let PoliticalDivision = Prefixed_Name(juso, "PoliticalDivision") |> PrefixedName

    /// <summary>
    ///   <para>juso:PoliticalDivisionGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Bag</para>
    ///   <para>"
    ///     These classes and properties are used to describe political and
    ///     administrative divisions.
    ///     "</para>
    /// labels<para>"Political Division Terms"</para></remarks>
    /// <seealso href="http://rdfs.co/juso/PoliticalDivisionGroup">http://rdfs.co/juso/PoliticalDivisionGroup</seealso>
    let PoliticalDivisionGroup =
        Prefixed_Name(juso, "PoliticalDivisionGroup") |> PrefixedName

    /// <summary>
    ///   <para>juso:PostalCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/PostalCode">http://rdfs.co/juso/PostalCode</seealso>
    let PostalCode = Prefixed_Name(juso, "PostalCode") |> PrefixedName
    /// <summary>
    ///   <para>juso:Province</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/Province">http://rdfs.co/juso/Province</seealso>
    let Province = Prefixed_Name(juso, "Province") |> PrefixedName

    /// <summary>
    ///   <para>juso:SecondLevelAdministrativeDivision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/SecondLevelAdministrativeDivision">http://rdfs.co/juso/SecondLevelAdministrativeDivision</seealso>
    let SecondLevelAdministrativeDivision =
        Prefixed_Name(juso, "SecondLevelAdministrativeDivision") |> PrefixedName

    /// <summary>
    ///   <para>juso:SpatialThing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/SpatialThing">http://rdfs.co/juso/SpatialThing</seealso>
    let SpatialThing = Prefixed_Name(juso, "SpatialThing") |> PrefixedName
    /// <summary>
    ///   <para>juso:Street</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/Street">http://rdfs.co/juso/Street</seealso>
    let Street = Prefixed_Name(juso, "Street") |> PrefixedName

    /// <summary>
    ///   <para>juso:ThirdLevelAdministrativeDivision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/ThirdLevelAdministrativeDivision">http://rdfs.co/juso/ThirdLevelAdministrativeDivision</seealso>
    let ThirdLevelAdministrativeDivision =
        Prefixed_Name(juso, "ThirdLevelAdministrativeDivision") |> PrefixedName

    /// <summary>
    ///   <para>juso:Thoroughfare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/Thoroughfare">http://rdfs.co/juso/Thoroughfare</seealso>
    let Thoroughfare = Prefixed_Name(juso, "Thoroughfare") |> PrefixedName
    /// <summary>
    ///   <para>juso:Town</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/Town">http://rdfs.co/juso/Town</seealso>
    let Town = Prefixed_Name(juso, "Town") |> PrefixedName
    /// <summary>
    ///   <para>juso:Township</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/Township">http://rdfs.co/juso/Township</seealso>
    let Township = Prefixed_Name(juso, "Township") |> PrefixedName
    /// <summary>
    ///   <para>juso:Village</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/Village">http://rdfs.co/juso/Village</seealso>
    let Village = Prefixed_Name(juso, "Village") |> PrefixedName
    /// <summary>
    ///   <para>juso:address</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/address">http://rdfs.co/juso/address</seealso>
    let address = Prefixed_Name(juso, "address") |> PrefixedName
    /// <summary>
    ///   <para>juso:country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/country">http://rdfs.co/juso/country</seealso>
    let country = Prefixed_Name(juso, "country") |> PrefixedName
    /// <summary>
    ///   <para>juso:endonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/endonym">http://rdfs.co/juso/endonym</seealso>
    let endonym = Prefixed_Name(juso, "endonym") |> PrefixedName
    /// <summary>
    ///   <para>juso:exonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/exonym">http://rdfs.co/juso/exonym</seealso>
    let exonym = Prefixed_Name(juso, "exonym") |> PrefixedName

    /// <summary>
    ///   <para>juso:fifth_level_administrative_division</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/fifth_level_administrative_division">http://rdfs.co/juso/fifth_level_administrative_division</seealso>
    let fifth_level_administrative_division =
        Prefixed_Name(juso, "fifth_level_administrative_division") |> PrefixedName

    /// <summary>
    ///   <para>juso:first_level_administrative_division</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/first_level_administrative_division">http://rdfs.co/juso/first_level_administrative_division</seealso>
    let first_level_administrative_division =
        Prefixed_Name(juso, "first_level_administrative_division") |> PrefixedName

    /// <summary>
    ///   <para>juso:fourth_level_administrative_division</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/fourth_level_administrative_division">http://rdfs.co/juso/fourth_level_administrative_division</seealso>
    let fourth_level_administrative_division =
        Prefixed_Name(juso, "fourth_level_administrative_division") |> PrefixedName

    /// <summary>
    ///   <para>juso:full_address</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/full_address">http://rdfs.co/juso/full_address</seealso>
    let full_address = Prefixed_Name(juso, "full_address") |> PrefixedName
    /// <summary>
    ///   <para>juso:geometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/geometry">http://rdfs.co/juso/geometry</seealso>
    let geometry = Prefixed_Name(juso, "geometry") |> PrefixedName
    /// <summary>
    ///   <para>juso:historical_address</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/historical_address">http://rdfs.co/juso/historical_address</seealso>
    let historical_address = Prefixed_Name(juso, "historical_address") |> PrefixedName
    /// <summary>
    ///   <para>juso:locator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/locator">http://rdfs.co/juso/locator</seealso>
    let locator = Prefixed_Name(juso, "locator") |> PrefixedName
    /// <summary>
    ///   <para>juso:locator_address</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/locator_address">http://rdfs.co/juso/locator_address</seealso>
    let locator_address = Prefixed_Name(juso, "locator_address") |> PrefixedName
    /// <summary>
    ///   <para>juso:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/name">http://rdfs.co/juso/name</seealso>
    let name = Prefixed_Name(juso, "name") |> PrefixedName
    /// <summary>
    ///   <para>juso:parent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/parent">http://rdfs.co/juso/parent</seealso>
    let parent = Prefixed_Name(juso, "parent") |> PrefixedName
    /// <summary>
    ///   <para>juso:po_box</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdfs.co/juso/po_box">http://rdfs.co/juso/po_box</seealso>
    let po_box = Prefixed_Name(juso, "po_box") |> PrefixedName
    /// <summary>
    ///   <para>juso:political_division</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/political_division">http://rdfs.co/juso/political_division</seealso>
    let political_division = Prefixed_Name(juso, "political_division") |> PrefixedName
    /// <summary>
    ///   <para>juso:post_office_box</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/post_office_box">http://rdfs.co/juso/post_office_box</seealso>
    let post_office_box = Prefixed_Name(juso, "post_office_box") |> PrefixedName
    /// <summary>
    ///   <para>juso:postal_code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/postal_code">http://rdfs.co/juso/postal_code</seealso>
    let postal_code = Prefixed_Name(juso, "postal_code") |> PrefixedName

    /// <summary>
    ///   <para>juso:second_level_administrative_division</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/second_level_administrative_division">http://rdfs.co/juso/second_level_administrative_division</seealso>
    let second_level_administrative_division =
        Prefixed_Name(juso, "second_level_administrative_division") |> PrefixedName

    /// <summary>
    ///   <para>juso:third_level_administrative_division</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/third_level_administrative_division">http://rdfs.co/juso/third_level_administrative_division</seealso>
    let third_level_administrative_division =
        Prefixed_Name(juso, "third_level_administrative_division") |> PrefixedName

    /// <summary>
    ///   <para>juso:thoroughfare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/thoroughfare">http://rdfs.co/juso/thoroughfare</seealso>
    let thoroughfare = Prefixed_Name(juso, "thoroughfare") |> PrefixedName

    /// <summary>
    ///   <para>juso:thoroughfare_address</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/thoroughfare_address">http://rdfs.co/juso/thoroughfare_address</seealso>
    let thoroughfare_address =
        Prefixed_Name(juso, "thoroughfare_address") |> PrefixedName

    /// <summary>
    ///   <para>juso:within</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="http://rdfs.co/juso/within">http://rdfs.co/juso/within</seealso>
    let within = Prefixed_Name(juso, "within") |> PrefixedName

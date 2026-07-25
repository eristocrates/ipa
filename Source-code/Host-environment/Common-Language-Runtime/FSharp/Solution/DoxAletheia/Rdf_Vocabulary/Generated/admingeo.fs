namespace http.data.ordnancesurvey.co.uk.ontology.admingeo.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module admingeo =
    let _namespace_iri = Namespace_Iri admingeo |> NamespaceIRI

    /// <summary>
    ///   <para>admingeo:GreaterLondonAuthorityAssemblyConstituency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Greater London Authority (GLA) Assembly constituencies are used to elect members to the London Assembly, which is part of the GLA.</para>
    /// labels<para>Greater London Authority Assembly Constituency</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/GreaterLondonAuthorityAssemblyConstituency">http://data.ordnancesurvey.co.uk/ontology/admingeo/GreaterLondonAuthorityAssemblyConstituency</seealso>
    let GreaterLondonAuthorityAssemblyConstituency =
        Prefixed_Name(admingeo, "GreaterLondonAuthorityAssemblyConstituency") |> PrefixedName

    /// <summary>
    ///   <para>admingeo:hasAreaCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This code describing the area type</para>
    /// labels<para>has area code</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/hasAreaCode">http://data.ordnancesurvey.co.uk/ontology/admingeo/hasAreaCode</seealso>
    let hasAreaCode = Prefixed_Name(admingeo, "hasAreaCode") |> PrefixedName
    /// <summary>
    ///   <para>admingeo:hasUnitID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A unique ID for the region</para>
    /// labels<para>has unit ID</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/hasUnitID">http://data.ordnancesurvey.co.uk/ontology/admingeo/hasUnitID</seealso>
    let hasUnitID = Prefixed_Name(admingeo, "hasUnitID") |> PrefixedName

    /// <summary>
    ///   <para>admingeo:WelshAssemblyConstituency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The  Welsh Assembly constituencies are used to elect members to the National Assembly for Wales (NAW).</para>
    /// labels<para>Welsh Assembly Constituency</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/WelshAssemblyConstituency">http://data.ordnancesurvey.co.uk/ontology/admingeo/WelshAssemblyConstituency</seealso>
    let WelshAssemblyConstituency =
        Prefixed_Name(admingeo, "WelshAssemblyConstituency") |> PrefixedName

    /// <summary>
    ///   <para>admingeo:ScottishParliamentElectoralRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Scottish parliamentary electoral regions are used for the proportional component of the elections to the Scottish Parliament. They are made up of groups of Scottish parliamentary constituencies.</para>
    /// labels<para>Scottish Parliament Electoral Region</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/ScottishParliamentElectoralRegion">http://data.ordnancesurvey.co.uk/ontology/admingeo/ScottishParliamentElectoralRegion</seealso>
    let ScottishParliamentElectoralRegion =
        Prefixed_Name(admingeo, "ScottishParliamentElectoralRegion") |> PrefixedName

    /// <summary>
    ///   <para>admingeo:LondonBoroughWard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>London Borough Ward</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/LondonBoroughWard">http://data.ordnancesurvey.co.uk/ontology/admingeo/LondonBoroughWard</seealso>
    let LondonBoroughWard = Prefixed_Name(admingeo, "LondonBoroughWard") |> PrefixedName

    /// <summary>
    ///   <para>admingeo:WestminsterConstituency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Westminster parliamentary constituencies are used to elect members to the UK Parliament in Westminster, London.</para>
    /// labels<para>Westminster Constituency</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/WestminsterConstituency">http://data.ordnancesurvey.co.uk/ontology/admingeo/WestminsterConstituency</seealso>
    let WestminsterConstituency =
        Prefixed_Name(admingeo, "WestminsterConstituency") |> PrefixedName

    /// <summary>
    ///   <para>admingeo:GreaterLondonAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The area covered by the Greater London Authority (GLA). The GLA is the body responsible for strategic citywide government for London, and consists of the Mayor of London and the London Assembly. The remit of the GLA covers the Greater London area.</para>
    /// labels<para>Greater London Authority</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/GreaterLondonAuthority">http://data.ordnancesurvey.co.uk/ontology/admingeo/GreaterLondonAuthority</seealso>
    let GreaterLondonAuthority =
        Prefixed_Name(admingeo, "GreaterLondonAuthority") |> PrefixedName

    /// <summary>
    ///   <para>admingeo:Constituency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Constituencies are used to elect members to legislatures.</para>
    /// labels<para>Constituency</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/Constituency">http://data.ordnancesurvey.co.uk/ontology/admingeo/Constituency</seealso>
    let Constituency = Prefixed_Name(admingeo, "Constituency") |> PrefixedName
    /// <summary>
    ///   <para>admingeo:County</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Counties were formerly administrative units across the whole UK. Due to various administrative restructurings however then the only administrative areas still referred to as counties are the non-metropolitan (shire) counties of England. The English metropolitan counties, although no longer administrative units, are also used for statistical purposes.</para>
    /// labels<para>County</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/County">http://data.ordnancesurvey.co.uk/ontology/admingeo/County</seealso>
    let County = Prefixed_Name(admingeo, "County") |> PrefixedName

    /// <summary>
    ///   <para>admingeo:MetropolitanDistrict</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Metropolitan districts are subdivisions of the 6 metropolitan county areas of England. Since the abolition of the metropolitan county councils in 1986 the metropolitan district councils have been unitary administrations.</para>
    /// labels<para>Metropolitan District</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/MetropolitanDistrict">http://data.ordnancesurvey.co.uk/ontology/admingeo/MetropolitanDistrict</seealso>
    let MetropolitanDistrict =
        Prefixed_Name(admingeo, "MetropolitanDistrict") |> PrefixedName

    /// <summary>
    ///   <para>admingeo:UnitaryAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Unitary authorities (UAs) are areas with a single tier of local government (as opposed to the two-tier county:district structure).</para>
    /// labels<para>Unitary Authority</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/UnitaryAuthority">http://data.ordnancesurvey.co.uk/ontology/admingeo/UnitaryAuthority</seealso>
    let UnitaryAuthority = Prefixed_Name(admingeo, "UnitaryAuthority") |> PrefixedName

    /// <summary>
    ///   <para>admingeo:CountyElectoralDivision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Apart from the special cases of the Isles of Scilly and the Greater London Authority (GLA), the English county councils are the only type of local authority in the UK which does not use standard electoral wards/divisions for electing councillors. Instead they use their own larger units, which are confusingly also termed electoral divisions. These county electoral divisions must be confined within district boundaries, but need not be based on whole electoral wards. Like electoral wards/divisions, county electoral divisions are defined by the Boundary Committee for England (BCFE).</para>
    /// labels<para>County Electoral Division</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/CountyElectoralDivision">http://data.ordnancesurvey.co.uk/ontology/admingeo/CountyElectoralDivision</seealso>
    let CountyElectoralDivision =
        Prefixed_Name(admingeo, "CountyElectoralDivision") |> PrefixedName

    /// <summary>
    ///   <para>admingeo:UnitaryAuthorityElectoralDivision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Electoral wards/divisions are the base unit of UK administrative geography such that all higher units are built up from them. They are also used as a base unit for many other geographies such as parliamentary constituencies and Primary Care Trusts (PCTs). Electoral wards are found across Scotland, Northern Ireland and most of England, whereas the equivalents in Wales and the Isle of Wight are known as electoral divisions.</para>
    /// labels<para>Unitary Authority Electoral Division</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/UnitaryAuthorityElectoralDivision">http://data.ordnancesurvey.co.uk/ontology/admingeo/UnitaryAuthorityElectoralDivision</seealso>
    let UnitaryAuthorityElectoralDivision =
        Prefixed_Name(admingeo, "UnitaryAuthorityElectoralDivision") |> PrefixedName

    /// <summary>
    ///   <para>admingeo:DistrictWard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>District Ward</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/DistrictWard">http://data.ordnancesurvey.co.uk/ontology/admingeo/DistrictWard</seealso>
    let DistrictWard = Prefixed_Name(admingeo, "DistrictWard") |> PrefixedName

    /// <summary>
    ///   <para>admingeo:UnitaryAuthorityWard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Unitary Authority Ward</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/UnitaryAuthorityWard">http://data.ordnancesurvey.co.uk/ontology/admingeo/UnitaryAuthorityWard</seealso>
    let UnitaryAuthorityWard =
        Prefixed_Name(admingeo, "UnitaryAuthorityWard") |> PrefixedName

    /// <summary>
    ///   <para>admingeo:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>An ontology describing the administrative and voting area geography of Great Britain</para>
    /// labels<para>The administrative geography and civil voting area ontology</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/">http://data.ordnancesurvey.co.uk/ontology/admingeo/</seealso>
    let _prefix_iri = Prefixed_Name(admingeo, "") |> PrefixedName
    /// <summary>
    ///   <para>admingeo:Ward</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Electoral wards/divisions are the base unit of UK administrative geography such that all higher units are built up from them. They are also used as a base unit for many other geographies such as parliamentary constituencies and Primary Care Trusts (PCTs). Electoral wards are found across Scotland, Northern Ireland and most of England, whereas the equivalents in Wales and the Isle of Wight are known as electoral divisions.</para>
    /// labels<para>Ward</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/Ward">http://data.ordnancesurvey.co.uk/ontology/admingeo/Ward</seealso>
    let Ward = Prefixed_Name(admingeo, "Ward") |> PrefixedName

    /// <summary>
    ///   <para>admingeo:MetropolitanDistrictWard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Metropolitan District Ward</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/MetropolitanDistrictWard">http://data.ordnancesurvey.co.uk/ontology/admingeo/MetropolitanDistrictWard</seealso>
    let MetropolitanDistrictWard =
        Prefixed_Name(admingeo, "MetropolitanDistrictWard") |> PrefixedName

    /// <summary>
    ///   <para>admingeo:Borough</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Borough</para>
    /// </remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/Borough">http://data.ordnancesurvey.co.uk/ontology/admingeo/Borough</seealso>
    let Borough = Prefixed_Name(admingeo, "Borough") |> PrefixedName

    /// <summary>
    ///   <para>admingeo:WelshAssemblyElectoralRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Welsh Assembly electoral regions are used for the proportional component of the elections to the National Assembly for Wales (NAW). They are made up of groups of Welsh Assembly constituencies.</para>
    /// labels<para>Welsh Assembly Electoral Region</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/WelshAssemblyElectoralRegion">http://data.ordnancesurvey.co.uk/ontology/admingeo/WelshAssemblyElectoralRegion</seealso>
    let WelshAssemblyElectoralRegion =
        Prefixed_Name(admingeo, "WelshAssemblyElectoralRegion") |> PrefixedName

    /// <summary>
    ///   <para>admingeo:CivilAdministrativeArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Civil Administrative Area</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/CivilAdministrativeArea">http://data.ordnancesurvey.co.uk/ontology/admingeo/CivilAdministrativeArea</seealso>
    let CivilAdministrativeArea =
        Prefixed_Name(admingeo, "CivilAdministrativeArea") |> PrefixedName

    /// <summary>
    ///   <para>admingeo:EuropeanRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>European Regions correspond to Scotland, Wales and the nine Government Office Regions of England. The nine Government Office Regions (GORs) are the primary statistical subdivisions of England and also the areas in which the Government Offices for the Regions fulfil their role. Each GOR covers a number of local authorities.</para>
    /// labels<para>European Region</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/EuropeanRegion">http://data.ordnancesurvey.co.uk/ontology/admingeo/EuropeanRegion</seealso>
    let EuropeanRegion = Prefixed_Name(admingeo, "EuropeanRegion") |> PrefixedName
    /// <summary>
    ///   <para>admingeo:inCounty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>this relates districts, parish, county electoral divisions and wards to their containing counties</para>
    /// labels<para>in county</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/inCounty">http://data.ordnancesurvey.co.uk/ontology/admingeo/inCounty</seealso>
    let inCounty = Prefixed_Name(admingeo, "inCounty") |> PrefixedName
    /// <summary>
    ///   <para>admingeo:inDistrict</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>this relates parishes, wards and unitary electoral divisions to their containing districts</para>
    /// labels<para>in district</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/inDistrict">http://data.ordnancesurvey.co.uk/ontology/admingeo/inDistrict</seealso>
    let inDistrict = Prefixed_Name(admingeo, "inDistrict") |> PrefixedName
    /// <summary>
    ///   <para>admingeo:hasCensusCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>These code area unique system of referencing for administrative units. These codes are allocated by the Office of National Statistics (ONS) for England and Wales, and by the General Register Office for Scotland (GROS) for Scottish Areas.</para>
    /// labels<para>has census code</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/hasCensusCode">http://data.ordnancesurvey.co.uk/ontology/admingeo/hasCensusCode</seealso>
    let hasCensusCode = Prefixed_Name(admingeo, "hasCensusCode") |> PrefixedName
    /// <summary>
    ///   <para>admingeo:district</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>this relates counties and european regions to the districts, unitary authorites, metropolitan districts and London boroughs they contain.</para>
    /// labels<para>district</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/district">http://data.ordnancesurvey.co.uk/ontology/admingeo/district</seealso>
    let district = Prefixed_Name(admingeo, "district") |> PrefixedName
    /// <summary>
    ///   <para>admingeo:ward</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>this relates an administrative regions to the wards and unitary electoral divisions contained within that region</para>
    /// labels<para>ward</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/ward">http://data.ordnancesurvey.co.uk/ontology/admingeo/ward</seealso>
    let ward = Prefixed_Name(admingeo, "ward") |> PrefixedName

    /// <summary>
    ///   <para>admingeo:westminsterConstituency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>this relates European regions to the Westminster constituencies contains within those regions</para>
    /// labels<para>westminster constituency</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/westminsterConstituency">http://data.ordnancesurvey.co.uk/ontology/admingeo/westminsterConstituency</seealso>
    let westminsterConstituency =
        Prefixed_Name(admingeo, "westminsterConstituency") |> PrefixedName

    /// <summary>
    ///   <para>admingeo:constituency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>this relates European regions, Scottish Parliament Electoral Regions and Welsh Assembly Electoral Regions to their consistuencies.</para>
    /// labels<para>constituency</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/constituency">http://data.ordnancesurvey.co.uk/ontology/admingeo/constituency</seealso>
    let constituency = Prefixed_Name(admingeo, "constituency") |> PrefixedName
    /// <summary>
    ///   <para>admingeo:inRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>this relates Greater London Authority Assembly Constituencies, Scottish Parliament Constituenices and Welsh AssemblyConstituencies to their containing regions.</para>
    /// labels<para>in region</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/inRegion">http://data.ordnancesurvey.co.uk/ontology/admingeo/inRegion</seealso>
    let inRegion = Prefixed_Name(admingeo, "inRegion") |> PrefixedName
    /// <summary>
    ///   <para>admingeo:county</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/county">http://data.ordnancesurvey.co.uk/ontology/admingeo/county</seealso>
    let county = Prefixed_Name(admingeo, "county") |> PrefixedName
    /// <summary>
    ///   <para>admingeo:gssCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Office for National Statistics (ONS) have reconfigured their GSS coding structure
    /// (providing a unique system of referencing for administrative units) to a new 9 character
    /// alpha numeric format,replacing the current alpha numeric format (up to 6 characters).This
    /// change has now been implemented in this October 2010 release of Boundary-Line.
    ///
    /// However,the new GSS Coding and Naming policy for some statistical geographies will be implemented
    /// on 1 January 2011. From this date, where new codes have been allocated they should be used in all
    /// exchanges of statistics and published outputs that normally include codes.
    ///
    /// The following types of unit are coded where they have been made available by ONS:
    /// Counties, Districts, Wards/Electoral Divisions, London Boroughs, Unitary Authorities, GLA's,
    /// Parish/Communities, Euro Regions, Welsh Assembly Const and Electoral Regions,
    /// Scottish Parliamentary Const and Electoral Regions, Westminster Const.</para>
    /// labels<para>GSS</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/gssCode">http://data.ordnancesurvey.co.uk/ontology/admingeo/gssCode</seealso>
    let gssCode = Prefixed_Name(admingeo, "gssCode") |> PrefixedName
    /// <summary>
    ///   <para>admingeo:hasOfficialName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has official name</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/hasOfficialName">http://data.ordnancesurvey.co.uk/ontology/admingeo/hasOfficialName</seealso>
    let hasOfficialName = Prefixed_Name(admingeo, "hasOfficialName") |> PrefixedName
    /// <summary>
    ///   <para>admingeo:parish</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>this relates various administrative areas to the parishes they contain</para>
    /// labels<para>parish</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/parish">http://data.ordnancesurvey.co.uk/ontology/admingeo/parish</seealso>
    let parish = Prefixed_Name(admingeo, "parish") |> PrefixedName

    /// <summary>
    ///   <para>admingeo:scottishParliamentElectoralRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/scottishParliamentElectoralRegion">http://data.ordnancesurvey.co.uk/ontology/admingeo/scottishParliamentElectoralRegion</seealso>
    let scottishParliamentElectoralRegion =
        Prefixed_Name(admingeo, "scottishParliamentElectoralRegion") |> PrefixedName

    /// <summary>
    ///   <para>admingeo:welshAssemblyElectoralRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/welshAssemblyElectoralRegion">http://data.ordnancesurvey.co.uk/ontology/admingeo/welshAssemblyElectoralRegion</seealso>
    let welshAssemblyElectoralRegion =
        Prefixed_Name(admingeo, "welshAssemblyElectoralRegion") |> PrefixedName

    /// <summary>
    ///   <para>admingeo:inEuropeanRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>this relates various administrative and civil voting areas to their containing European region</para>
    /// labels<para>in European region</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/inEuropeanRegion">http://data.ordnancesurvey.co.uk/ontology/admingeo/inEuropeanRegion</seealso>
    let inEuropeanRegion = Prefixed_Name(admingeo, "inEuropeanRegion") |> PrefixedName
    /// <summary>
    ///   <para>admingeo:CivilVotingArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Civil Voting Area</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/CivilVotingArea">http://data.ordnancesurvey.co.uk/ontology/admingeo/CivilVotingArea</seealso>
    let CivilVotingArea = Prefixed_Name(admingeo, "CivilVotingArea") |> PrefixedName

    /// <summary>
    ///   <para>admingeo:ScottishParliamentConstituency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Scottish parliamentary constituencies are used to elect members to the Scottish Parliament.</para>
    /// labels<para>Scottish Parliament Constituency</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/ScottishParliamentConstituency">http://data.ordnancesurvey.co.uk/ontology/admingeo/ScottishParliamentConstituency</seealso>
    let ScottishParliamentConstituency =
        Prefixed_Name(admingeo, "ScottishParliamentConstituency") |> PrefixedName

    /// <summary>
    ///   <para>admingeo:CivilParish</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Parishes are subdivisions of local authorities in many parts of England, and their councils are the most local level of government. Unlike electoral wards/divisions however, parishes are not found in all parts of England. The Welsh equivalents are communities. Note that the full term for administrative parishes is &amp;apos;civil parishes&amp;apos;, to distinguish them from the ecclesiastical parishes which are found in all parts of the UK.</para>
    /// labels<para>Civil Parish</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/CivilParish">http://data.ordnancesurvey.co.uk/ontology/admingeo/CivilParish</seealso>
    let CivilParish = Prefixed_Name(admingeo, "CivilParish") |> PrefixedName
    /// <summary>
    ///   <para>admingeo:Community</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Welsh equivalent of Civil Parish.</para>
    /// labels<para>Community</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/Community">http://data.ordnancesurvey.co.uk/ontology/admingeo/Community</seealso>
    let Community = Prefixed_Name(admingeo, "Community") |> PrefixedName
    /// <summary>
    ///   <para>admingeo:District</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Districts are local administrative units and have at various times been used in all four countries of the UK. The only current references to districts however are found in metropolitan and non-metropolitan districts in England, and district council areas in Northern Ireland.</para>
    /// labels<para>District</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/District">http://data.ordnancesurvey.co.uk/ontology/admingeo/District</seealso>
    let District = Prefixed_Name(admingeo, "District") |> PrefixedName
    /// <summary>
    ///   <para>admingeo:LondonBorough</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The London boroughs are the local government areas within Greater London. The borough councils are unitary administrations with a status similar to metropolitan districts, but will also be affected by any policies implemented by the Greater London Authority (GLA).</para>
    /// labels<para>London Borough</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/admingeo/LondonBorough">http://data.ordnancesurvey.co.uk/ontology/admingeo/LondonBorough</seealso>
    let LondonBorough = Prefixed_Name(admingeo, "LondonBorough") |> PrefixedName

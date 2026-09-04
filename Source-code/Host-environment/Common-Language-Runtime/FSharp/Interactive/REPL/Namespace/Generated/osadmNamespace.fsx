#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module osadm =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://data.ordnancesurvey.co.uk/ontology/admingeo/" "osadm"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : Borough</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/Borough">osadm:Borough</a>
    /// </summary>
    let Borough = _prefixId.prefix "Borough"
    /// <summary>
    ///   <para>rdfs:label : Civil Administrative Area^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/CivilAdministrativeArea">osadm:CivilAdministrativeArea</a>
    /// </summary>
    let CivilAdministrativeArea = _prefixId.prefix "CivilAdministrativeArea"
    /// <summary>
    ///   <para>rdfs:comment : Parishes are subdivisions of local authorities in many parts of England, and their councils are the most local level of government. Unlike electoral wards/divisions however, parishes are not found in all parts of England. The Welsh equivalents are communities. Note that the full term for administrative parishes is &amp;apos;civil parishes&amp;apos;, to distinguish them from the ecclesiastical parishes which are found in all parts of the UK.</para>
    ///   <para>rdfs:label : Civil Parish</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/CivilParish">osadm:CivilParish</a>
    /// </summary>
    let CivilParish = _prefixId.prefix "CivilParish"
    /// <summary>
    ///   <para>rdfs:label : Civil Voting Area^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/CivilVotingArea">osadm:CivilVotingArea</a>
    /// </summary>
    let CivilVotingArea = _prefixId.prefix "CivilVotingArea"
    /// <summary>
    ///   <para>rdfs:label : Community</para>
    ///   <para>rdfs:comment : The Welsh equivalent of Civil Parish.</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/Community">osadm:Community</a>
    /// </summary>
    let Community = _prefixId.prefix "Community"
    /// <summary>
    ///   <para>rdfs:comment : Constituencies are used to elect members to legislatures.^^xsd:string</para>
    ///   <para>rdfs:label : Constituency^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/Constituency">osadm:Constituency</a>
    /// </summary>
    let Constituency = _prefixId.prefix "Constituency"
    /// <summary>
    ///   <para>rdfs:comment : Counties were formerly administrative units across the whole UK. Due to various administrative restructurings however then the only administrative areas still referred to as counties are the non-metropolitan (shire) counties of England. The English metropolitan counties, although no longer administrative units, are also used for statistical purposes.</para>
    ///   <para>rdfs:label : County</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/County">osadm:County</a>
    /// </summary>
    let County = _prefixId.prefix "County"
    /// <summary>
    ///   <para>rdfs:comment : Apart from the special cases of the Isles of Scilly and the Greater London Authority (GLA), the English county councils are the only type of local authority in the UK which does not use standard electoral wards/divisions for electing councillors. Instead they use their own larger units, which are confusingly also termed electoral divisions. These county electoral divisions must be confined within district boundaries, but need not be based on whole electoral wards. Like electoral wards/divisions, county electoral divisions are defined by the Boundary Committee for England (BCFE).</para>
    ///   <para>rdfs:label : County Electoral Division</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/CountyElectoralDivision">osadm:CountyElectoralDivision</a>
    /// </summary>
    let CountyElectoralDivision = _prefixId.prefix "CountyElectoralDivision"
    /// <summary>
    ///   <para>rdfs:label : District</para>
    ///   <para>rdfs:comment : Districts are local administrative units and have at various times been used in all four countries of the UK. The only current references to districts however are found in metropolitan and non-metropolitan districts in England, and district council areas in Northern Ireland.</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/District">osadm:District</a>
    /// </summary>
    let District = _prefixId.prefix "District"
    /// <summary>
    ///   <para>rdfs:label : District Ward</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/DistrictWard">osadm:DistrictWard</a>
    /// </summary>
    let DistrictWard = _prefixId.prefix "DistrictWard"
    /// <summary>
    ///   <para>rdfs:comment : European Regions correspond to Scotland, Wales and the nine Government Office Regions of England. The nine Government Office Regions (GORs) are the primary statistical subdivisions of England and also the areas in which the Government Offices for the Regions fulfil their role. Each GOR covers a number of local authorities.^^xsd:string</para>
    ///   <para>rdfs:label : European Region^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/EuropeanRegion">osadm:EuropeanRegion</a>
    /// </summary>
    let EuropeanRegion = _prefixId.prefix "EuropeanRegion"
    /// <summary>
    ///   <para>rdfs:label : Greater London Authority</para>
    ///   <para>rdfs:comment : The area covered by the Greater London Authority (GLA). The GLA is the body responsible for strategic citywide government for London, and consists of the Mayor of London and the London Assembly. The remit of the GLA covers the Greater London area.</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/GreaterLondonAuthority">osadm:GreaterLondonAuthority</a>
    /// </summary>
    let GreaterLondonAuthority = _prefixId.prefix "GreaterLondonAuthority"

    /// <summary>
    ///   <para>rdfs:comment : Greater London Authority (GLA) Assembly constituencies are used to elect members to the London Assembly, which is part of the GLA.</para>
    ///   <para>rdfs:label : Greater London Authority Assembly Constituency</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/GreaterLondonAuthorityAssemblyConstituency">osadm:GreaterLondonAuthorityAssemblyConstituency</a>
    /// </summary>
    let GreaterLondonAuthorityAssemblyConstituency =
        _prefixId.prefix "GreaterLondonAuthorityAssemblyConstituency"

    /// <summary>
    ///   <para>rdfs:label : London Borough</para>
    ///   <para>rdfs:comment : The London boroughs are the local government areas within Greater London. The borough councils are unitary administrations with a status similar to metropolitan districts, but will also be affected by any policies implemented by the Greater London Authority (GLA).^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/LondonBorough">osadm:LondonBorough</a>
    /// </summary>
    let LondonBorough = _prefixId.prefix "LondonBorough"
    /// <summary>
    ///   <para>rdfs:label : London Borough Ward</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/LondonBoroughWard">osadm:LondonBoroughWard</a>
    /// </summary>
    let LondonBoroughWard = _prefixId.prefix "LondonBoroughWard"
    /// <summary>
    ///   <para>rdfs:label : Metropolitan District</para>
    ///   <para>rdfs:comment : Metropolitan districts are subdivisions of the 6 metropolitan county areas of England. Since the abolition of the metropolitan county councils in 1986 the metropolitan district councils have been unitary administrations.</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/MetropolitanDistrict">osadm:MetropolitanDistrict</a>
    /// </summary>
    let MetropolitanDistrict = _prefixId.prefix "MetropolitanDistrict"
    /// <summary>
    ///   <para>rdfs:label : Metropolitan District Ward</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/MetropolitanDistrictWard">osadm:MetropolitanDistrictWard</a>
    /// </summary>
    let MetropolitanDistrictWard = _prefixId.prefix "MetropolitanDistrictWard"

    /// <summary>
    ///   <para>rdfs:comment : The Scottish parliamentary constituencies are used to elect members to the Scottish Parliament.</para>
    ///   <para>rdfs:label : Scottish Parliament Constituency</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/ScottishParliamentConstituency">osadm:ScottishParliamentConstituency</a>
    /// </summary>
    let ScottishParliamentConstituency =
        _prefixId.prefix "ScottishParliamentConstituency"

    /// <summary>
    ///   <para>rdfs:comment : The Scottish parliamentary electoral regions are used for the proportional component of the elections to the Scottish Parliament. They are made up of groups of Scottish parliamentary constituencies.</para>
    ///   <para>rdfs:label : Scottish Parliament Electoral Region</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/ScottishParliamentElectoralRegion">osadm:ScottishParliamentElectoralRegion</a>
    /// </summary>
    let ScottishParliamentElectoralRegion =
        _prefixId.prefix "ScottishParliamentElectoralRegion"

    /// <summary>
    ///   <para>rdfs:label : Unitary Authority^^xsd:string</para>
    ///   <para>rdfs:comment : Unitary authorities (UAs) are areas with a single tier of local government (as opposed to the two-tier county:district structure).</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/UnitaryAuthority">osadm:UnitaryAuthority</a>
    /// </summary>
    let UnitaryAuthority = _prefixId.prefix "UnitaryAuthority"

    /// <summary>
    ///   <para>rdfs:comment : Electoral wards/divisions are the base unit of UK administrative geography such that all higher units are built up from them. They are also used as a base unit for many other geographies such as parliamentary constituencies and Primary Care Trusts (PCTs). Electoral wards are found across Scotland, Northern Ireland and most of England, whereas the equivalents in Wales and the Isle of Wight are known as electoral divisions.^^xsd:string</para>
    ///   <para>rdfs:label : Unitary Authority Electoral Division^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/UnitaryAuthorityElectoralDivision">osadm:UnitaryAuthorityElectoralDivision</a>
    /// </summary>
    let UnitaryAuthorityElectoralDivision =
        _prefixId.prefix "UnitaryAuthorityElectoralDivision"

    /// <summary>
    ///   <para>rdfs:label : Unitary Authority Ward</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/UnitaryAuthorityWard">osadm:UnitaryAuthorityWard</a>
    /// </summary>
    let UnitaryAuthorityWard = _prefixId.prefix "UnitaryAuthorityWard"
    /// <summary>
    ///   <para>rdfs:comment : Electoral wards/divisions are the base unit of UK administrative geography such that all higher units are built up from them. They are also used as a base unit for many other geographies such as parliamentary constituencies and Primary Care Trusts (PCTs). Electoral wards are found across Scotland, Northern Ireland and most of England, whereas the equivalents in Wales and the Isle of Wight are known as electoral divisions.</para>
    ///   <para>rdfs:label : Ward</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/Ward">osadm:Ward</a>
    /// </summary>
    let Ward = _prefixId.prefix "Ward"
    /// <summary>
    ///   <para>rdfs:comment : The  Welsh Assembly constituencies are used to elect members to the National Assembly for Wales (NAW).</para>
    ///   <para>rdfs:label : Welsh Assembly Constituency</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/WelshAssemblyConstituency">osadm:WelshAssemblyConstituency</a>
    /// </summary>
    let WelshAssemblyConstituency = _prefixId.prefix "WelshAssemblyConstituency"
    /// <summary>
    ///   <para>rdfs:comment : The Welsh Assembly electoral regions are used for the proportional component of the elections to the National Assembly for Wales (NAW). They are made up of groups of Welsh Assembly constituencies.</para>
    ///   <para>rdfs:label : Welsh Assembly Electoral Region</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/WelshAssemblyElectoralRegion">osadm:WelshAssemblyElectoralRegion</a>
    /// </summary>
    let WelshAssemblyElectoralRegion = _prefixId.prefix "WelshAssemblyElectoralRegion"
    /// <summary>
    ///   <para>rdfs:comment : Westminster parliamentary constituencies are used to elect members to the UK Parliament in Westminster, London.</para>
    ///   <para>rdfs:label : Westminster Constituency</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/WestminsterConstituency">osadm:WestminsterConstituency</a>
    /// </summary>
    let WestminsterConstituency = _prefixId.prefix "WestminsterConstituency"
    /// <summary>
    ///   <para>rdfs:comment : this relates European regions, Scottish Parliament Electoral Regions and Welsh Assembly Electoral Regions to their consistuencies.^^xsd:string</para>
    ///   <para>rdfs:label : constituency^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/constituency">osadm:constituency</a>
    /// </summary>
    let constituency = _prefixId.prefix "constituency"
    let county = _prefixId.prefix "county"
    /// <summary>
    ///   <para>rdfs:comment : this relates counties and european regions to the districts, unitary authorites, metropolitan districts and London boroughs they contain.^^xsd:string</para>
    ///   <para>rdfs:label : district^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/district">osadm:district</a>
    /// </summary>
    let district = _prefixId.prefix "district"
    /// <summary>
    ///   <para>rdfs:comment : Office for National Statistics (ONS) have reconfigured their GSS coding structure
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
    /// Scottish Parliamentary Const and Electoral Regions, Westminster Const.^^xsd:string</para>
    ///   <para>rdfs:label : GSS^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/gssCode">osadm:gssCode</a>
    /// </summary>
    let gssCode = _prefixId.prefix "gssCode"
    /// <summary>
    ///   <para>rdfs:comment : This code describing the area type^^xsd:string</para>
    ///   <para>rdfs:label : has area code^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/hasAreaCode">osadm:hasAreaCode</a>
    /// </summary>
    let hasAreaCode = _prefixId.prefix "hasAreaCode"
    /// <summary>
    ///   <para>rdfs:comment : These code area unique system of referencing for administrative units. These codes are allocated by the Office of National Statistics (ONS) for England and Wales, and by the General Register Office for Scotland (GROS) for Scottish Areas.^^xsd:string</para>
    ///   <para>rdfs:label : has census code^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/hasCensusCode">osadm:hasCensusCode</a>
    /// </summary>
    let hasCensusCode = _prefixId.prefix "hasCensusCode"
    /// <summary>
    ///   <para>rdfs:label : has official name^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/hasOfficialName">osadm:hasOfficialName</a>
    /// </summary>
    let hasOfficialName = _prefixId.prefix "hasOfficialName"
    /// <summary>
    ///   <para>rdfs:comment : A unique ID for the region^^xsd:string</para>
    ///   <para>rdfs:label : has unit ID^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/hasUnitID">osadm:hasUnitID</a>
    /// </summary>
    let hasUnitID = _prefixId.prefix "hasUnitID"
    /// <summary>
    ///   <para>rdfs:comment : this relates districts, parish, county electoral divisions and wards to their containing counties^^xsd:string</para>
    ///   <para>rdfs:label : in county^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/inCounty">osadm:inCounty</a>
    /// </summary>
    let inCounty = _prefixId.prefix "inCounty"
    /// <summary>
    ///   <para>rdfs:comment : this relates parishes, wards and unitary electoral divisions to their containing districts^^xsd:string</para>
    ///   <para>rdfs:label : in district^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/inDistrict">osadm:inDistrict</a>
    /// </summary>
    let inDistrict = _prefixId.prefix "inDistrict"
    /// <summary>
    ///   <para>rdfs:comment : this relates various administrative and civil voting areas to their containing European region^^xsd:string</para>
    ///   <para>rdfs:label : in European region^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/inEuropeanRegion">osadm:inEuropeanRegion</a>
    /// </summary>
    let inEuropeanRegion = _prefixId.prefix "inEuropeanRegion"
    /// <summary>
    ///   <para>rdfs:comment : this relates Greater London Authority Assembly Constituencies, Scottish Parliament Constituenices and Welsh AssemblyConstituencies to their containing regions.^^xsd:string</para>
    ///   <para>rdfs:label : in region^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/inRegion">osadm:inRegion</a>
    /// </summary>
    let inRegion = _prefixId.prefix "inRegion"
    /// <summary>
    ///   <para>rdfs:comment : this relates various administrative areas to the parishes they contain^^xsd:string</para>
    ///   <para>rdfs:label : parish^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/parish">osadm:parish</a>
    /// </summary>
    let parish = _prefixId.prefix "parish"

    let scottishParliamentElectoralRegion =
        _prefixId.prefix "scottishParliamentElectoralRegion"

    /// <summary>
    ///   <para>rdfs:comment : this relates an administrative regions to the wards and unitary electoral divisions contained within that region^^xsd:string</para>
    ///   <para>rdfs:label : ward^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/ward">osadm:ward</a>
    /// </summary>
    let ward = _prefixId.prefix "ward"
    let welshAssemblyElectoralRegion = _prefixId.prefix "welshAssemblyElectoralRegion"
    /// <summary>
    ///   <para>rdfs:comment : this relates European regions to the Westminster constituencies contains within those regions^^xsd:string</para>
    ///   <para>rdfs:label : westminster constituency^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/admingeo/westminsterConstituency">osadm:westminsterConstituency</a>
    /// </summary>
    let westminsterConstituency = _prefixId.prefix "westminsterConstituency"

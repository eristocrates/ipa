namespace http.data.ordnancesurvey.co.uk.ontology.admingeo.slash

open DoxAletheia

module admingeo =
    let _namespace_name = "http://data.ordnancesurvey.co.uk/ontology/admingeo/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Greater London Authority (GLA) Assembly constituencies are used to elect members to the London Assembly, which is part of the GLA.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/GreaterLondonAuthorityAssemblyConstituency"></see></summary>
    let GreaterLondonAuthorityAssemblyConstituency =
        _prefix "GreaterLondonAuthorityAssemblyConstituency"

    /// <summary>
    /// The Scottish parliamentary constituencies are used to elect members to the Scottish Parliament.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/ScottishParliamentConstituency"></see></summary>
    let ScottishParliamentConstituency = _prefix "ScottishParliamentConstituency"
    /// <summary>
    /// The  Welsh Assembly constituencies are used to elect members to the National Assembly for Wales (NAW).
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/WelshAssemblyConstituency"></see></summary>
    let WelshAssemblyConstituency = _prefix "WelshAssemblyConstituency"
    /// <summary>
    /// Westminster parliamentary constituencies are used to elect members to the UK Parliament in Westminster, London.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/WestminsterConstituency"></see></summary>
    let WestminsterConstituency = _prefix "WestminsterConstituency"
    /// <summary>
    /// Parishes are subdivisions of local authorities in many parts of England, and their councils are the most local level of government. Unlike electoral wards/divisions however, parishes are not found in all parts of England. The Welsh equivalents are communities. Note that the full term for administrative parishes is &amp;apos;civil parishes&amp;apos;, to distinguish them from the ecclesiastical parishes which are found in all parts of the UK.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/CivilParish"></see></summary>
    let CivilParish = _prefix "CivilParish"
    /// <summary>
    /// The Welsh equivalent of Civil Parish.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/Community"></see></summary>
    let Community = _prefix "Community"
    /// <summary>
    /// Counties were formerly administrative units across the whole UK. Due to various administrative restructurings however then the only administrative areas still referred to as counties are the non-metropolitan (shire) counties of England. The English metropolitan counties, although no longer administrative units, are also used for statistical purposes.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/County"></see></summary>
    let County = _prefix "County"
    /// <summary>
    /// Districts are local administrative units and have at various times been used in all four countries of the UK. The only current references to districts however are found in metropolitan and non-metropolitan districts in England, and district council areas in Northern Ireland.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/District"></see></summary>
    let District = _prefix "District"
    /// <summary>
    /// The area covered by the Greater London Authority (GLA). The GLA is the body responsible for strategic citywide government for London, and consists of the Mayor of London and the London Assembly. The remit of the GLA covers the Greater London area.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/GreaterLondonAuthority"></see></summary>
    let GreaterLondonAuthority = _prefix "GreaterLondonAuthority"
    /// <summary>
    /// The London boroughs are the local government areas within Greater London. The borough councils are unitary administrations with a status similar to metropolitan districts, but will also be affected by any policies implemented by the Greater London Authority (GLA).
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/LondonBorough"></see></summary>
    let LondonBorough = _prefix "LondonBorough"
    /// <summary>
    /// Metropolitan districts are subdivisions of the 6 metropolitan county areas of England. Since the abolition of the metropolitan county councils in 1986 the metropolitan district councils have been unitary administrations.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/MetropolitanDistrict"></see></summary>
    let MetropolitanDistrict = _prefix "MetropolitanDistrict"
    /// <summary>
    /// Unitary authorities (UAs) are areas with a single tier of local government (as opposed to the two-tier county:district structure).
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/UnitaryAuthority"></see></summary>
    let UnitaryAuthority = _prefix "UnitaryAuthority"
    /// <summary>
    /// Constituencies are used to elect members to legislatures.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/Constituency"></see></summary>
    let Constituency = _prefix "Constituency"
    /// <summary>
    /// Apart from the special cases of the Isles of Scilly and the Greater London Authority (GLA), the English county councils are the only type of local authority in the UK which does not use standard electoral wards/divisions for electing councillors. Instead they use their own larger units, which are confusingly also termed electoral divisions. These county electoral divisions must be confined within district boundaries, but need not be based on whole electoral wards. Like electoral wards/divisions, county electoral divisions are defined by the Boundary Committee for England (BCFE).
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/CountyElectoralDivision"></see></summary>
    let CountyElectoralDivision = _prefix "CountyElectoralDivision"
    /// <summary>
    /// The Scottish parliamentary electoral regions are used for the proportional component of the elections to the Scottish Parliament. They are made up of groups of Scottish parliamentary constituencies.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/ScottishParliamentElectoralRegion"></see></summary>
    let ScottishParliamentElectoralRegion = _prefix "ScottishParliamentElectoralRegion"
    /// <summary>
    /// Electoral wards/divisions are the base unit of UK administrative geography such that all higher units are built up from them. They are also used as a base unit for many other geographies such as parliamentary constituencies and Primary Care Trusts (PCTs). Electoral wards are found across Scotland, Northern Ireland and most of England, whereas the equivalents in Wales and the Isle of Wight are known as electoral divisions.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/UnitaryAuthorityElectoralDivision"></see></summary>
    let UnitaryAuthorityElectoralDivision = _prefix "UnitaryAuthorityElectoralDivision"
    /// <summary>
    /// Electoral wards/divisions are the base unit of UK administrative geography such that all higher units are built up from them. They are also used as a base unit for many other geographies such as parliamentary constituencies and Primary Care Trusts (PCTs). Electoral wards are found across Scotland, Northern Ireland and most of England, whereas the equivalents in Wales and the Isle of Wight are known as electoral divisions.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/Ward"></see></summary>
    let Ward = _prefix "Ward"
    /// <summary>
    /// The Welsh Assembly electoral regions are used for the proportional component of the elections to the National Assembly for Wales (NAW). They are made up of groups of Welsh Assembly constituencies.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/WelshAssemblyElectoralRegion"></see></summary>
    let WelshAssemblyElectoralRegion = _prefix "WelshAssemblyElectoralRegion"
    /// <summary>
    ///   <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/DistrictWard"></see>
    /// </summary>
    let DistrictWard = _prefix "DistrictWard"
    /// <summary>
    ///   <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/LondonBoroughWard"></see>
    /// </summary>
    let LondonBoroughWard = _prefix "LondonBoroughWard"
    /// <summary>
    ///   <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/MetropolitanDistrictWard"></see>
    /// </summary>
    let MetropolitanDistrictWard = _prefix "MetropolitanDistrictWard"
    /// <summary>
    ///   <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/UnitaryAuthorityWard"></see>
    /// </summary>
    let UnitaryAuthorityWard = _prefix "UnitaryAuthorityWard"
    /// <summary>
    /// Borough
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/Borough"></see></summary>
    let Borough = _prefix "Borough"
    /// <summary>
    ///   <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/CivilAdministrativeArea"></see>
    /// </summary>
    let CivilAdministrativeArea = _prefix "CivilAdministrativeArea"
    /// <summary>
    /// European Regions correspond to Scotland, Wales and the nine Government Office Regions of England. The nine Government Office Regions (GORs) are the primary statistical subdivisions of England and also the areas in which the Government Offices for the Regions fulfil their role. Each GOR covers a number of local authorities.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/EuropeanRegion"></see></summary>
    let EuropeanRegion = _prefix "EuropeanRegion"
    /// <summary>
    /// this relates various administrative and civil voting areas to their containing European region
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/inEuropeanRegion"></see></summary>
    let inEuropeanRegion = _prefix "inEuropeanRegion"
    /// <summary>
    ///   <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/CivilVotingArea"></see>
    /// </summary>
    let CivilVotingArea = _prefix "CivilVotingArea"
    /// <summary>
    /// this relates districts, parish, county electoral divisions and wards to their containing counties
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/inCounty"></see></summary>
    let inCounty = _prefix "inCounty"
    /// <summary>
    /// this relates parishes, wards and unitary electoral divisions to their containing districts
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/inDistrict"></see></summary>
    let inDistrict = _prefix "inDistrict"
    /// <summary>
    /// These code area unique system of referencing for administrative units. These codes are allocated by the Office of National Statistics (ONS) for England and Wales, and by the General Register Office for Scotland (GROS) for Scottish Areas.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/hasCensusCode"></see></summary>
    let hasCensusCode = _prefix "hasCensusCode"
    /// <summary>
    /// This code describing the area type
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/hasAreaCode"></see></summary>
    let hasAreaCode = _prefix "hasAreaCode"
    /// <summary>
    /// A unique ID for the region
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/hasUnitID"></see></summary>
    let hasUnitID = _prefix "hasUnitID"
    /// <summary>
    /// this relates counties and european regions to the districts, unitary authorites, metropolitan districts and London boroughs they contain.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/district"></see></summary>
    let district = _prefix "district"
    /// <summary>
    /// this relates an administrative regions to the wards and unitary electoral divisions contained within that region
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/ward"></see></summary>
    let ward = _prefix "ward"
    /// <summary>
    /// this relates European regions to the Westminster constituencies contains within those regions
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/westminsterConstituency"></see></summary>
    let westminsterConstituency = _prefix "westminsterConstituency"
    /// <summary>
    /// this relates European regions, Scottish Parliament Electoral Regions and Welsh Assembly Electoral Regions to their consistuencies.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/constituency"></see></summary>
    let constituency = _prefix "constituency"
    /// <summary>
    /// this relates Greater London Authority Assembly Constituencies, Scottish Parliament Constituenices and Welsh AssemblyConstituencies to their containing regions.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/inRegion"></see></summary>
    let inRegion = _prefix "inRegion"
    /// <summary>
    ///   <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/county"></see>
    /// </summary>
    let county = _prefix "county"
    /// <summary>
    /// Office for National Statistics (ONS) have reconfigured their GSS coding structure
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
    /// Scottish Parliamentary Const and Electoral Regions, Westminster Const.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/gssCode"></see></summary>
    let gssCode = _prefix "gssCode"
    /// <summary>
    ///   <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/hasOfficialName"></see>
    /// </summary>
    let hasOfficialName = _prefix "hasOfficialName"
    /// <summary>
    /// this relates various administrative areas to the parishes they contain
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/parish"></see></summary>
    let parish = _prefix "parish"
    /// <summary>
    ///   <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/scottishParliamentElectoralRegion"></see>
    /// </summary>
    let scottishParliamentElectoralRegion = _prefix "scottishParliamentElectoralRegion"
    /// <summary>
    ///   <see href="http://data.ordnancesurvey.co.uk/ontology/admingeo/welshAssemblyElectoralRegion"></see>
    /// </summary>
    let welshAssemblyElectoralRegion = _prefix "welshAssemblyElectoralRegion"

#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module geof =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#" "geof"

    /// <summary>
    ///   <para>rdfs:label : Administrative Region^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Administrative_Region">geof:Administrative_Region</a>
    /// </summary>
    let Administrative_Region = _prefixId.prefix "Administrative_Region"
    /// <summary>
    ///   <para>rdfs:label : Administrative Subdivision^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Administrative_Subdivision">geof:Administrative_Subdivision</a>
    /// </summary>
    let Administrative_Subdivision = _prefixId.prefix "Administrative_Subdivision"
    /// <summary>
    ///   <para>rdfs:label : Area^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Area">geof:Area</a>
    /// </summary>
    let Area = _prefixId.prefix "Area"
    /// <summary>
    ///   <para>rdfs:label : Autonomous Community^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Autonomous_Community">geof:Autonomous_Community</a>
    /// </summary>
    let Autonomous_Community = _prefixId.prefix "Autonomous_Community"
    /// <summary>
    ///   <para>rdfs:label : Autonomous Municipality^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Autonomous_Municipality">geof:Autonomous_Municipality</a>
    /// </summary>
    let Autonomous_Municipality = _prefixId.prefix "Autonomous_Municipality"
    /// <summary>
    ///   <para>rdfs:label : Autonomous Region^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Autonomous_Region">geof:Autonomous_Region</a>
    /// </summary>
    let Autonomous_Region = _prefixId.prefix "Autonomous_Region"
    let Building = _prefixId.prefix "Building"
    /// <summary>
    ///   <para>rdfs:label : Canton^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Canton">geof:Canton</a>
    /// </summary>
    let Canton = _prefixId.prefix "Canton"
    /// <summary>
    ///   <para>rdfs:label : Capital City^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Capital_City">geof:Capital_City</a>
    /// </summary>
    let Capital_City = _prefixId.prefix "Capital_City"
    /// <summary>
    ///   <para>rdfs:label : Capital Municipality^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Capital_Municipality">geof:Capital_Municipality</a>
    /// </summary>
    let Capital_Municipality = _prefixId.prefix "Capital_Municipality"
    /// <summary>
    ///   <para>rdfs:label : Capital Territory^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Capital_Territory">geof:Capital_Territory</a>
    /// </summary>
    let Capital_Territory = _prefixId.prefix "Capital_Territory"
    /// <summary>
    ///   <para>rdfs:label : City^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#City">geof:City</a>
    /// </summary>
    let City = _prefixId.prefix "City"
    /// <summary>
    ///   <para>rdfs:label : Constitutional Province^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Constitutional_Province">geof:Constitutional_Province</a>
    /// </summary>
    let Constitutional_Province = _prefixId.prefix "Constitutional_Province"
    let CoordinateOrigin = _prefixId.prefix "CoordinateOrigin"
    let Country = _prefixId.prefix "Country"
    /// <summary>
    ///   <para>rdfs:label : County^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#County">geof:County</a>
    /// </summary>
    let County = _prefixId.prefix "County"
    /// <summary>
    ///   <para>rdfs:label : Department^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Department">geof:Department</a>
    /// </summary>
    let Department = _prefixId.prefix "Department"
    /// <summary>
    ///   <para>rdfs:label : District^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#District">geof:District</a>
    /// </summary>
    let District = _prefixId.prefix "District"
    /// <summary>
    ///   <para>rdfs:label : Division^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Division">geof:Division</a>
    /// </summary>
    let Division = _prefixId.prefix "Division"
    /// <summary>
    ///   <para>rdfs:label : Economic Prefecture^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Economic_Prefecture">geof:Economic_Prefecture</a>
    /// </summary>
    let Economic_Prefecture = _prefixId.prefix "Economic_Prefecture"
    /// <summary>
    ///   <para>rdfs:label : Emirate^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Emirate">geof:Emirate</a>
    /// </summary>
    let Emirate = _prefixId.prefix "Emirate"
    /// <summary>
    ///   <para>rdfs:label : Federal Dependencies^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Federal_Dependencies">geof:Federal_Dependencies</a>
    /// </summary>
    let Federal_Dependencies = _prefixId.prefix "Federal_Dependencies"
    /// <summary>
    ///   <para>rdfs:label : Federal District^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Federal_District">geof:Federal_District</a>
    /// </summary>
    let Federal_District = _prefixId.prefix "Federal_District"
    /// <summary>
    ///   <para>rdfs:label : Federal Status City^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Federal_Status_City">geof:Federal_Status_City</a>
    /// </summary>
    let Federal_Status_City = _prefixId.prefix "Federal_Status_City"
    /// <summary>
    ///   <para>rdfs:label : Federal Territory^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Federal_Territory">geof:Federal_Territory</a>
    /// </summary>
    let Federal_Territory = _prefixId.prefix "Federal_Territory"
    /// <summary>
    ///   <para>rdfs:comment : cities, countries, admin units, and continents are subclasses of GeographicFeature^^xsd:string</para>
    ///   <para>rdfs:label : GeographicFeature^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#GeographicFeature">geof:GeographicFeature</a>
    /// </summary>
    let GeographicFeature = _prefixId.prefix "GeographicFeature"
    /// <summary>
    ///   <para>rdfs:label : Governorate^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Governorate">geof:Governorate</a>
    /// </summary>
    let Governorate = _prefixId.prefix "Governorate"
    /// <summary>
    ///   <para>rdfs:label : Independent Town^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Independent_Town">geof:Independent_Town</a>
    /// </summary>
    let Independent_Town = _prefixId.prefix "Independent_Town"
    /// <summary>
    ///   <para>rdfs:label : Intendancy^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Intendancy">geof:Intendancy</a>
    /// </summary>
    let Intendancy = _prefixId.prefix "Intendancy"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Linestring^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Linestring">geof:Linestring</a>
    /// </summary>
    let Linestring = _prefixId.prefix "Linestring"
    /// <summary>
    ///   <para>rdfs:comment : a collection of polylines^^xsd:string</para>
    ///   <para>rdfs:label : MultiLinestring^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#MultiLinestring">geof:MultiLinestring</a>
    /// </summary>
    let MultiLinestring = _prefixId.prefix "MultiLinestring"
    /// <summary>
    ///   <para>rdfs:comment : a collection of points^^xsd:string</para>
    ///   <para>rdfs:label : MultiPoint^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#MultiPoint">geof:MultiPoint</a>
    /// </summary>
    let MultiPoint = _prefixId.prefix "MultiPoint"
    /// <summary>
    ///   <para>rdfs:comment : a collection of polygons^^xsd:string</para>
    ///   <para>rdfs:label : MultiPolygon^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#MultiPolygon">geof:MultiPolygon</a>
    /// </summary>
    let MultiPolygon = _prefixId.prefix "MultiPolygon"
    /// <summary>
    ///   <para>rdfs:label : Municipality^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Municipality">geof:Municipality</a>
    /// </summary>
    let Municipality = _prefixId.prefix "Municipality"
    /// <summary>
    ///   <para>rdfs:label : National District^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#National_District">geof:National_District</a>
    /// </summary>
    let National_District = _prefixId.prefix "National_District"
    /// <summary>
    ///   <para>rdfs:label : National Territory^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#National_Territory">geof:National_Territory</a>
    /// </summary>
    let National_Territory = _prefixId.prefix "National_Territory"
    /// <summary>
    ///   <para>rdfs:label : Pakistan-administered^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Pakistan-administered">geof:Pakistan-administered</a>
    /// </summary>
    let Pakistan_administered = _prefixId.prefix "Pakistan-administered"
    /// <summary>
    ///   <para>rdfs:label : Parish^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Parish">geof:Parish</a>
    /// </summary>
    let Parish = _prefixId.prefix "Parish"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Point^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Point">geof:Point</a>
    /// </summary>
    let Point = _prefixId.prefix "Point"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Polygon^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Polygon">geof:Polygon</a>
    /// </summary>
    let Polygon = _prefixId.prefix "Polygon"
    /// <summary>
    ///   <para>rdfs:label : Prefecture^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Prefecture">geof:Prefecture</a>
    /// </summary>
    let Prefecture = _prefixId.prefix "Prefecture"
    /// <summary>
    ///   <para>rdfs:label : Province^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Province">geof:Province</a>
    /// </summary>
    let Province = _prefixId.prefix "Province"
    /// <summary>
    ///   <para>rdfs:label : Region^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Region">geof:Region</a>
    /// </summary>
    let Region = _prefixId.prefix "Region"
    /// <summary>
    ///   <para>rdfs:label : Republic^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Republic">geof:Republic</a>
    /// </summary>
    let Republic = _prefixId.prefix "Republic"
    /// <summary>
    ///   <para>rdfs:comment : A spatial description is a class of spatial descriptors used to describe the
    /// 	spatial shape of a SpatialThing in terms of coordinates^^xsd:string</para>
    ///   <para>rdfs:label : SpatialDescription^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#SpatialDescription">geof:SpatialDescription</a>
    /// </summary>
    let SpatialDescription = _prefixId.prefix "SpatialDescription"
    /// <summary>
    ///   <para>rdfs:comment : A spatial thing is the simplest thing that has some spatial characteristics^^xsd:string</para>
    ///   <para>rdfs:label : SpatialThing^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#SpatialThing">geof:SpatialThing</a>
    /// </summary>
    let SpatialThing = _prefixId.prefix "SpatialThing"
    /// <summary>
    ///   <para>rdfs:label : Special City^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Special_City">geof:Special_City</a>
    /// </summary>
    let Special_City = _prefixId.prefix "Special_City"
    /// <summary>
    ///   <para>rdfs:label : Special District^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Special_District">geof:Special_District</a>
    /// </summary>
    let Special_District = _prefixId.prefix "Special_District"
    /// <summary>
    ///   <para>rdfs:label : Special Municipality^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Special_Municipality">geof:Special_Municipality</a>
    /// </summary>
    let Special_Municipality = _prefixId.prefix "Special_Municipality"
    /// <summary>
    ///   <para>rdfs:label : Special Region^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Special_Region">geof:Special_Region</a>
    /// </summary>
    let Special_Region = _prefixId.prefix "Special_Region"
    /// <summary>
    ///   <para>rdfs:label : State^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#State">geof:State</a>
    /// </summary>
    let State = _prefixId.prefix "State"
    /// <summary>
    ///   <para>rdfs:label : Territory^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Territory">geof:Territory</a>
    /// </summary>
    let Territory = _prefixId.prefix "Territory"
    /// <summary>
    ///   <para>rdfs:label : Town^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Town">geof:Town</a>
    /// </summary>
    let Town = _prefixId.prefix "Town"
    /// <summary>
    ///   <para>rdfs:label : Union Territory^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Union_Territory">geof:Union_Territory</a>
    /// </summary>
    let Union_Territory = _prefixId.prefix "Union_Territory"
    /// <summary>
    ///   <para>rdfs:label : Zone^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Zone">geof:Zone</a>
    /// </summary>
    let Zone = _prefixId.prefix "Zone"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : admin_name^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#admin_name">geof:admin_name</a>
    /// </summary>
    let admin_name = _prefixId.prefix "admin_name"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : city_name^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#city_name">geof:city_name</a>
    /// </summary>
    let city_name = _prefixId.prefix "city_name"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : cntry_name^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#cntry_name">geof:cntry_name</a>
    /// </summary>
    let cntry_name = _prefixId.prefix "cntry_name"
    let coordinates = _prefixId.prefix "coordinates"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : curr_code^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#curr_code">geof:curr_code</a>
    /// </summary>
    let curr_code = _prefixId.prefix "curr_code"
    /// <summary>
    ///   <para>rdfs:comment : Type of currency in country^^xsd:string</para>
    ///   <para>rdfs:label : curry_type^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#curr_type">geof:curr_type</a>
    /// </summary>
    let curr_type = _prefixId.prefix "curr_type"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : fips_admin^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#fips_admin">geof:fips_admin</a>
    /// </summary>
    let fips_admin = _prefixId.prefix "fips_admin"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : fips_cntry^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#fips_cntry">geof:fips_cntry</a>
    /// </summary>
    let fips_cntry = _prefixId.prefix "fips_cntry"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : gmi_admin^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#gmi_admin">geof:gmi_admin</a>
    /// </summary>
    let gmi_admin = _prefixId.prefix "gmi_admin"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : gmi_cntry^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#gmi_cntry">geof:gmi_cntry</a>
    /// </summary>
    let gmi_cntry = _prefixId.prefix "gmi_cntry"
    let hasCoordinateSystem = _prefixId.prefix "hasCoordinateSystem"
    /// <summary>
    ///   <para>rdfs:comment : hasSpatialLocation defines the qualitative location of some spatial thing^^xsd:string</para>
    ///   <para>rdfs:label : hasSpatialLocation^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#hasSpatialLocation">geof:hasSpatialLocation</a>
    /// </summary>
    let hasSpatialLocation = _prefixId.prefix "hasSpatialLocation"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : ISO_2DIGIT^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#iso_2digit">geof:iso_2digit</a>
    /// </summary>
    let iso_2digit = _prefixId.prefix "iso_2digit"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : ISO_3DIGIT^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#iso_3digit">geof:iso_3digit</a>
    /// </summary>
    let iso_3digit = _prefixId.prefix "iso_3digit"
    /// <summary>
    ///   <para>rdfs:comment : Population of the administrative unit^^xsd:string</para>
    ///   <para>rdfs:label : pop_admin^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#pop_admin">geof:pop_admin</a>
    /// </summary>
    let pop_admin = _prefixId.prefix "pop_admin"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : pop_class^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#pop_class">geof:pop_class</a>
    /// </summary>
    let pop_class = _prefixId.prefix "pop_class"
    /// <summary>
    ///   <para>rdfs:comment : Population of the country^^xsd:string</para>
    ///   <para>rdfs:label : pop_admin^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#pop_cntry">geof:pop_cntry</a>
    /// </summary>
    let pop_cntry = _prefixId.prefix "pop_cntry"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : pop_rank^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#pop_rank">geof:pop_rank</a>
    /// </summary>
    let pop_rank = _prefixId.prefix "pop_rank"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : port_id^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#port_id">geof:port_id</a>
    /// </summary>
    let port_id = _prefixId.prefix "port_id"
    /// <summary>
    ///   <para>rdfs:comment : The property shape associates a geographic feature with a Spatial Description defined by a blank node^^xsd:string</para>
    ///   <para>rdfs:label : shape^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#shape">geof:shape</a>
    /// </summary>
    let shape = _prefixId.prefix "shape"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : sovereign^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#sovereign">geof:sovereign</a>
    /// </summary>
    let sovereign = _prefixId.prefix "sovereign"
    /// <summary>
    ///   <para>rdfs:comment : Area in square kilometers^^xsd:string</para>
    ///   <para>rdfs:label : sqkm^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#sqkm">geof:sqkm</a>
    /// </summary>
    let sqkm = _prefixId.prefix "sqkm"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : status^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#status">geof:status</a>
    /// </summary>
    let status = _prefixId.prefix "status"
    /// <summary>
    ///   <para>rdfs:comment : Type of administrative unit in language of country^^xsd:string</para>
    ///   <para>rdfs:label : type_loc^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#type_loc">geof:type_loc</a>
    /// </summary>
    let type_loc = _prefixId.prefix "type_loc"
    /// <summary>
    ///   <para>rdfs:comment : xyCoordinates define the x,y location of a spatial thing.  They must be ordered as "x,y x,y x,y ..."^^xsd:string</para>
    ///   <para>rdfs:label : coordinates^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#xyCoordinates">geof:xyCoordinates</a>
    /// </summary>
    let xyCoordinates = _prefixId.prefix "xyCoordinates"
    /// <summary>
    ///   <para>rdfs:comment : xyCoordinates define the x,y,z location of a spatial thing.  They must be ordered as "x,y,z x,y,z x,y,z..."^^xsd:string</para>
    ///   <para>rdfs:label : coordinates^^xsd:string</para>
    ///   <a href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#xyzCoordinates">geof:xyzCoordinates</a>
    /// </summary>
    let xyzCoordinates = _prefixId.prefix "xyzCoordinates"

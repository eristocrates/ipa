namespace http.www.mindswap.org._2003.owl.geo.geoFeatures20040307.owl.hash

open DoxAletheia

module geof =
    let _namespace_name =
        "http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// cities, countries, admin units, and continents are subclasses of GeographicFeature
    /// <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#GeographicFeature"></see></summary>
    let GeographicFeature = _prefix "GeographicFeature"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Administrative_Region"></see>
    /// </summary>
    let Administrative_Region = _prefix "Administrative_Region"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Administrative_Subdivision"></see>
    /// </summary>
    let Administrative_Subdivision = _prefix "Administrative_Subdivision"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Area"></see>
    /// </summary>
    let Area = _prefix "Area"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Autonomous_Community"></see>
    /// </summary>
    let Autonomous_Community = _prefix "Autonomous_Community"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Autonomous_Municipality"></see>
    /// </summary>
    let Autonomous_Municipality = _prefix "Autonomous_Municipality"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Autonomous_Region"></see>
    /// </summary>
    let Autonomous_Region = _prefix "Autonomous_Region"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Building"></see>
    /// </summary>
    let Building = _prefix "Building"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Canton"></see>
    /// </summary>
    let Canton = _prefix "Canton"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Capital_City"></see>
    /// </summary>
    let Capital_City = _prefix "Capital_City"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Capital_Municipality"></see>
    /// </summary>
    let Capital_Municipality = _prefix "Capital_Municipality"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Capital_Territory"></see>
    /// </summary>
    let Capital_Territory = _prefix "Capital_Territory"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#City"></see>
    /// </summary>
    let City = _prefix "City"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Constitutional_Province"></see>
    /// </summary>
    let Constitutional_Province = _prefix "Constitutional_Province"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#County"></see>
    /// </summary>
    let County = _prefix "County"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Department"></see>
    /// </summary>
    let Department = _prefix "Department"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#District"></see>
    /// </summary>
    let District = _prefix "District"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Division"></see>
    /// </summary>
    let Division = _prefix "Division"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Economic_Prefecture"></see>
    /// </summary>
    let Economic_Prefecture = _prefix "Economic_Prefecture"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Emirate"></see>
    /// </summary>
    let Emirate = _prefix "Emirate"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Federal_Dependencies"></see>
    /// </summary>
    let Federal_Dependencies = _prefix "Federal_Dependencies"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Federal_District"></see>
    /// </summary>
    let Federal_District = _prefix "Federal_District"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Federal_Status_City"></see>
    /// </summary>
    let Federal_Status_City = _prefix "Federal_Status_City"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Federal_Territory"></see>
    /// </summary>
    let Federal_Territory = _prefix "Federal_Territory"
    /// <summary>
    /// A spatial thing is the simplest thing that has some spatial characteristics
    /// <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#SpatialThing"></see></summary>
    let SpatialThing = _prefix "SpatialThing"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Governorate"></see>
    /// </summary>
    let Governorate = _prefix "Governorate"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Independent_Town"></see>
    /// </summary>
    let Independent_Town = _prefix "Independent_Town"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Intendancy"></see>
    /// </summary>
    let Intendancy = _prefix "Intendancy"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Linestring"></see>
    /// </summary>
    let Linestring = _prefix "Linestring"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#coordinates"></see>
    /// </summary>
    let coordinates = _prefix "coordinates"
    /// <summary>
    /// A spatial description is a class of spatial descriptors used to describe the
    /// 	spatial shape of a SpatialThing in terms of coordinates
    /// <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#SpatialDescription"></see></summary>
    let SpatialDescription = _prefix "SpatialDescription"
    /// <summary>
    /// a collection of polylines
    /// <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#MultiLinestring"></see></summary>
    let MultiLinestring = _prefix "MultiLinestring"
    /// <summary>
    /// a collection of points
    /// <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#MultiPoint"></see></summary>
    let MultiPoint = _prefix "MultiPoint"
    /// <summary>
    /// a collection of polygons
    /// <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#MultiPolygon"></see></summary>
    let MultiPolygon = _prefix "MultiPolygon"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Municipality"></see>
    /// </summary>
    let Municipality = _prefix "Municipality"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#National_District"></see>
    /// </summary>
    let National_District = _prefix "National_District"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#National_Territory"></see>
    /// </summary>
    let National_Territory = _prefix "National_Territory"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Pakistan-administered"></see>
    /// </summary>
    let ``Pakistan-administered`` = _prefix "Pakistan-administered"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Parish"></see>
    /// </summary>
    let Parish = _prefix "Parish"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Point"></see>
    /// </summary>
    let Point = _prefix "Point"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Polygon"></see>
    /// </summary>
    let Polygon = _prefix "Polygon"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Prefecture"></see>
    /// </summary>
    let Prefecture = _prefix "Prefecture"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Province"></see>
    /// </summary>
    let Province = _prefix "Province"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Region"></see>
    /// </summary>
    let Region = _prefix "Region"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Republic"></see>
    /// </summary>
    let Republic = _prefix "Republic"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#hasCoordinateSystem"></see>
    /// </summary>
    let hasCoordinateSystem = _prefix "hasCoordinateSystem"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Special_City"></see>
    /// </summary>
    let Special_City = _prefix "Special_City"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Special_District"></see>
    /// </summary>
    let Special_District = _prefix "Special_District"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Special_Municipality"></see>
    /// </summary>
    let Special_Municipality = _prefix "Special_Municipality"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Special_Region"></see>
    /// </summary>
    let Special_Region = _prefix "Special_Region"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#State"></see>
    /// </summary>
    let State = _prefix "State"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Territory"></see>
    /// </summary>
    let Territory = _prefix "Territory"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Town"></see>
    /// </summary>
    let Town = _prefix "Town"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Union_Territory"></see>
    /// </summary>
    let Union_Territory = _prefix "Union_Territory"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Zone"></see>
    /// </summary>
    let Zone = _prefix "Zone"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#admin_name"></see>
    /// </summary>
    let admin_name = _prefix "admin_name"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#city_name"></see>
    /// </summary>
    let city_name = _prefix "city_name"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#cntry_name"></see>
    /// </summary>
    let cntry_name = _prefix "cntry_name"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#curr_code"></see>
    /// </summary>
    let curr_code = _prefix "curr_code"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Country"></see>
    /// </summary>
    let Country = _prefix "Country"
    /// <summary>
    /// Type of currency in country
    /// <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#curr_type"></see></summary>
    let curr_type = _prefix "curr_type"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#fips_admin"></see>
    /// </summary>
    let fips_admin = _prefix "fips_admin"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#fips_cntry"></see>
    /// </summary>
    let fips_cntry = _prefix "fips_cntry"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#gmi_admin"></see>
    /// </summary>
    let gmi_admin = _prefix "gmi_admin"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#gmi_cntry"></see>
    /// </summary>
    let gmi_cntry = _prefix "gmi_cntry"
    /// <summary>
    /// hasSpatialLocation defines the qualitative location of some spatial thing
    /// <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#hasSpatialLocation"></see></summary>
    let hasSpatialLocation = _prefix "hasSpatialLocation"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#iso_2digit"></see>
    /// </summary>
    let iso_2digit = _prefix "iso_2digit"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#iso_3digit"></see>
    /// </summary>
    let iso_3digit = _prefix "iso_3digit"
    /// <summary>
    /// Population of the administrative unit
    /// <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#pop_admin"></see></summary>
    let pop_admin = _prefix "pop_admin"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#pop_class"></see>
    /// </summary>
    let pop_class = _prefix "pop_class"
    /// <summary>
    /// Population of the country
    /// <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#pop_cntry"></see></summary>
    let pop_cntry = _prefix "pop_cntry"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#pop_rank"></see>
    /// </summary>
    let pop_rank = _prefix "pop_rank"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#port_id"></see>
    /// </summary>
    let port_id = _prefix "port_id"
    /// <summary>
    /// The property shape associates a geographic feature with a Spatial Description defined by a blank node
    /// <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#shape"></see></summary>
    let shape = _prefix "shape"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#sovereign"></see>
    /// </summary>
    let sovereign = _prefix "sovereign"
    /// <summary>
    /// Area in square kilometers
    /// <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#sqkm"></see></summary>
    let sqkm = _prefix "sqkm"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#status"></see>
    /// </summary>
    let status = _prefix "status"
    /// <summary>
    /// Type of administrative unit in language of country
    /// <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#type_loc"></see></summary>
    let type_loc = _prefix "type_loc"
    /// <summary>
    /// xyCoordinates define the x,y location of a spatial thing.  They must be ordered as "x,y x,y x,y ..."
    /// <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#xyCoordinates"></see></summary>
    let xyCoordinates = _prefix "xyCoordinates"
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#CoordinateOrigin"></see>
    /// </summary>
    let CoordinateOrigin = _prefix "CoordinateOrigin"
    /// <summary>
    /// xyCoordinates define the x,y,z location of a spatial thing.  They must be ordered as "x,y,z x,y,z x,y,z..."
    /// <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#xyzCoordinates"></see></summary>
    let xyzCoordinates = _prefix "xyzCoordinates"

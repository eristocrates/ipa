namespace http.www.mindswap.org._2003.owl.geo.geoFeatures20040307.owl.hash

open DoxAletheia.Rdf_Vocabulary

module geof =
    let _namespace_name =
        "http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#"

    /// <summary>
    /// cities, countries, admin units, and continents are subclasses of GeographicFeature
    /// <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#GeographicFeature"></see></summary>
    let GeographicFeature =
        Namespaced_IRI.parse _namespace_name "GeographicFeature" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Administrative_Region"></see>
    /// </summary>
    let Administrative_Region =
        Namespaced_IRI.parse _namespace_name "Administrative_Region" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Administrative_Subdivision"></see>
    /// </summary>
    let Administrative_Subdivision =
        Namespaced_IRI.parse _namespace_name "Administrative_Subdivision" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Area"></see>
    /// </summary>
    let Area = Namespaced_IRI.parse _namespace_name "Area" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Autonomous_Community"></see>
    /// </summary>
    let Autonomous_Community =
        Namespaced_IRI.parse _namespace_name "Autonomous_Community" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Autonomous_Municipality"></see>
    /// </summary>
    let Autonomous_Municipality =
        Namespaced_IRI.parse _namespace_name "Autonomous_Municipality" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Autonomous_Region"></see>
    /// </summary>
    let Autonomous_Region =
        Namespaced_IRI.parse _namespace_name "Autonomous_Region" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Building"></see>
    /// </summary>
    let Building = Namespaced_IRI.parse _namespace_name "Building" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Canton"></see>
    /// </summary>
    let Canton = Namespaced_IRI.parse _namespace_name "Canton" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Capital_City"></see>
    /// </summary>
    let Capital_City =
        Namespaced_IRI.parse _namespace_name "Capital_City" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Capital_Municipality"></see>
    /// </summary>
    let Capital_Municipality =
        Namespaced_IRI.parse _namespace_name "Capital_Municipality" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Capital_Territory"></see>
    /// </summary>
    let Capital_Territory =
        Namespaced_IRI.parse _namespace_name "Capital_Territory" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#City"></see>
    /// </summary>
    let City = Namespaced_IRI.parse _namespace_name "City" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Constitutional_Province"></see>
    /// </summary>
    let Constitutional_Province =
        Namespaced_IRI.parse _namespace_name "Constitutional_Province" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#County"></see>
    /// </summary>
    let County = Namespaced_IRI.parse _namespace_name "County" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Department"></see>
    /// </summary>
    let Department = Namespaced_IRI.parse _namespace_name "Department" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#District"></see>
    /// </summary>
    let District = Namespaced_IRI.parse _namespace_name "District" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Division"></see>
    /// </summary>
    let Division = Namespaced_IRI.parse _namespace_name "Division" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Economic_Prefecture"></see>
    /// </summary>
    let Economic_Prefecture =
        Namespaced_IRI.parse _namespace_name "Economic_Prefecture" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Emirate"></see>
    /// </summary>
    let Emirate = Namespaced_IRI.parse _namespace_name "Emirate" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Federal_Dependencies"></see>
    /// </summary>
    let Federal_Dependencies =
        Namespaced_IRI.parse _namespace_name "Federal_Dependencies" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Federal_District"></see>
    /// </summary>
    let Federal_District =
        Namespaced_IRI.parse _namespace_name "Federal_District" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Federal_Status_City"></see>
    /// </summary>
    let Federal_Status_City =
        Namespaced_IRI.parse _namespace_name "Federal_Status_City" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Federal_Territory"></see>
    /// </summary>
    let Federal_Territory =
        Namespaced_IRI.parse _namespace_name "Federal_Territory" |> NamespacedName

    /// <summary>
    /// A spatial thing is the simplest thing that has some spatial characteristics
    /// <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#SpatialThing"></see></summary>
    let SpatialThing =
        Namespaced_IRI.parse _namespace_name "SpatialThing" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Governorate"></see>
    /// </summary>
    let Governorate =
        Namespaced_IRI.parse _namespace_name "Governorate" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Independent_Town"></see>
    /// </summary>
    let Independent_Town =
        Namespaced_IRI.parse _namespace_name "Independent_Town" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Intendancy"></see>
    /// </summary>
    let Intendancy = Namespaced_IRI.parse _namespace_name "Intendancy" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Linestring"></see>
    /// </summary>
    let Linestring = Namespaced_IRI.parse _namespace_name "Linestring" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#coordinates"></see>
    /// </summary>
    let coordinates =
        Namespaced_IRI.parse _namespace_name "coordinates" |> NamespacedName

    /// <summary>
    /// A spatial description is a class of spatial descriptors used to describe the
    /// 	spatial shape of a SpatialThing in terms of coordinates
    /// <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#SpatialDescription"></see></summary>
    let SpatialDescription =
        Namespaced_IRI.parse _namespace_name "SpatialDescription" |> NamespacedName

    /// <summary>
    /// a collection of polylines
    /// <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#MultiLinestring"></see></summary>
    let MultiLinestring =
        Namespaced_IRI.parse _namespace_name "MultiLinestring" |> NamespacedName

    /// <summary>
    /// a collection of points
    /// <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#MultiPoint"></see></summary>
    let MultiPoint = Namespaced_IRI.parse _namespace_name "MultiPoint" |> NamespacedName

    /// <summary>
    /// a collection of polygons
    /// <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#MultiPolygon"></see></summary>
    let MultiPolygon =
        Namespaced_IRI.parse _namespace_name "MultiPolygon" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Municipality"></see>
    /// </summary>
    let Municipality =
        Namespaced_IRI.parse _namespace_name "Municipality" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#National_District"></see>
    /// </summary>
    let National_District =
        Namespaced_IRI.parse _namespace_name "National_District" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#National_Territory"></see>
    /// </summary>
    let National_Territory =
        Namespaced_IRI.parse _namespace_name "National_Territory" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Pakistan-administered"></see>
    /// </summary>
    let ``Pakistan-administered`` =
        Namespaced_IRI.parse _namespace_name "Pakistan-administered" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Parish"></see>
    /// </summary>
    let Parish = Namespaced_IRI.parse _namespace_name "Parish" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Point"></see>
    /// </summary>
    let Point = Namespaced_IRI.parse _namespace_name "Point" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Polygon"></see>
    /// </summary>
    let Polygon = Namespaced_IRI.parse _namespace_name "Polygon" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Prefecture"></see>
    /// </summary>
    let Prefecture = Namespaced_IRI.parse _namespace_name "Prefecture" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Province"></see>
    /// </summary>
    let Province = Namespaced_IRI.parse _namespace_name "Province" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Region"></see>
    /// </summary>
    let Region = Namespaced_IRI.parse _namespace_name "Region" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Republic"></see>
    /// </summary>
    let Republic = Namespaced_IRI.parse _namespace_name "Republic" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#hasCoordinateSystem"></see>
    /// </summary>
    let hasCoordinateSystem =
        Namespaced_IRI.parse _namespace_name "hasCoordinateSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Special_City"></see>
    /// </summary>
    let Special_City =
        Namespaced_IRI.parse _namespace_name "Special_City" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Special_District"></see>
    /// </summary>
    let Special_District =
        Namespaced_IRI.parse _namespace_name "Special_District" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Special_Municipality"></see>
    /// </summary>
    let Special_Municipality =
        Namespaced_IRI.parse _namespace_name "Special_Municipality" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Special_Region"></see>
    /// </summary>
    let Special_Region =
        Namespaced_IRI.parse _namespace_name "Special_Region" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#State"></see>
    /// </summary>
    let State = Namespaced_IRI.parse _namespace_name "State" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Territory"></see>
    /// </summary>
    let Territory = Namespaced_IRI.parse _namespace_name "Territory" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Town"></see>
    /// </summary>
    let Town = Namespaced_IRI.parse _namespace_name "Town" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Union_Territory"></see>
    /// </summary>
    let Union_Territory =
        Namespaced_IRI.parse _namespace_name "Union_Territory" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Zone"></see>
    /// </summary>
    let Zone = Namespaced_IRI.parse _namespace_name "Zone" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#admin_name"></see>
    /// </summary>
    let admin_name = Namespaced_IRI.parse _namespace_name "admin_name" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#city_name"></see>
    /// </summary>
    let city_name = Namespaced_IRI.parse _namespace_name "city_name" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#cntry_name"></see>
    /// </summary>
    let cntry_name = Namespaced_IRI.parse _namespace_name "cntry_name" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#curr_code"></see>
    /// </summary>
    let curr_code = Namespaced_IRI.parse _namespace_name "curr_code" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#Country"></see>
    /// </summary>
    let Country = Namespaced_IRI.parse _namespace_name "Country" |> NamespacedName
    /// <summary>
    /// Type of currency in country
    /// <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#curr_type"></see></summary>
    let curr_type = Namespaced_IRI.parse _namespace_name "curr_type" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#fips_admin"></see>
    /// </summary>
    let fips_admin = Namespaced_IRI.parse _namespace_name "fips_admin" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#fips_cntry"></see>
    /// </summary>
    let fips_cntry = Namespaced_IRI.parse _namespace_name "fips_cntry" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#gmi_admin"></see>
    /// </summary>
    let gmi_admin = Namespaced_IRI.parse _namespace_name "gmi_admin" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#gmi_cntry"></see>
    /// </summary>
    let gmi_cntry = Namespaced_IRI.parse _namespace_name "gmi_cntry" |> NamespacedName

    /// <summary>
    /// hasSpatialLocation defines the qualitative location of some spatial thing
    /// <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#hasSpatialLocation"></see></summary>
    let hasSpatialLocation =
        Namespaced_IRI.parse _namespace_name "hasSpatialLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#iso_2digit"></see>
    /// </summary>
    let iso_2digit = Namespaced_IRI.parse _namespace_name "iso_2digit" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#iso_3digit"></see>
    /// </summary>
    let iso_3digit = Namespaced_IRI.parse _namespace_name "iso_3digit" |> NamespacedName
    /// <summary>
    /// Population of the administrative unit
    /// <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#pop_admin"></see></summary>
    let pop_admin = Namespaced_IRI.parse _namespace_name "pop_admin" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#pop_class"></see>
    /// </summary>
    let pop_class = Namespaced_IRI.parse _namespace_name "pop_class" |> NamespacedName
    /// <summary>
    /// Population of the country
    /// <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#pop_cntry"></see></summary>
    let pop_cntry = Namespaced_IRI.parse _namespace_name "pop_cntry" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#pop_rank"></see>
    /// </summary>
    let pop_rank = Namespaced_IRI.parse _namespace_name "pop_rank" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#port_id"></see>
    /// </summary>
    let port_id = Namespaced_IRI.parse _namespace_name "port_id" |> NamespacedName
    /// <summary>
    /// The property shape associates a geographic feature with a Spatial Description defined by a blank node
    /// <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#shape"></see></summary>
    let shape = Namespaced_IRI.parse _namespace_name "shape" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#sovereign"></see>
    /// </summary>
    let sovereign = Namespaced_IRI.parse _namespace_name "sovereign" |> NamespacedName
    /// <summary>
    /// Area in square kilometers
    /// <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#sqkm"></see></summary>
    let sqkm = Namespaced_IRI.parse _namespace_name "sqkm" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#status"></see>
    /// </summary>
    let status = Namespaced_IRI.parse _namespace_name "status" |> NamespacedName
    /// <summary>
    /// Type of administrative unit in language of country
    /// <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#type_loc"></see></summary>
    let type_loc = Namespaced_IRI.parse _namespace_name "type_loc" |> NamespacedName

    /// <summary>
    /// xyCoordinates define the x,y location of a spatial thing.  They must be ordered as "x,y x,y x,y ..."
    /// <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#xyCoordinates"></see></summary>
    let xyCoordinates =
        Namespaced_IRI.parse _namespace_name "xyCoordinates" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#CoordinateOrigin"></see>
    /// </summary>
    let CoordinateOrigin =
        Namespaced_IRI.parse _namespace_name "CoordinateOrigin" |> NamespacedName

    /// <summary>
    /// xyCoordinates define the x,y,z location of a spatial thing.  They must be ordered as "x,y,z x,y,z x,y,z..."
    /// <see href="http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#xyzCoordinates"></see></summary>
    let xyzCoordinates =
        Namespaced_IRI.parse _namespace_name "xyzCoordinates" |> NamespacedName

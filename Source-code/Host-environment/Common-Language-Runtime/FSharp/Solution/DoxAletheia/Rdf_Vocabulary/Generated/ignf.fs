namespace http.data.ign.fr.def.ignf.hash

open DoxAletheia

module ignf =
    let _namespace_name = "http://data.ign.fr/def/ignf#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Ordered list of coordinates system axes.
    /// <see href="http://data.ign.fr/def/ignf#AxesList"></see></summary>
    let AxesList = _prefix "AxesList"
    /// <summary>
    /// Axis composing a coordinate system and used to specify one given coordinate in a coordinate tuple describing the position of a point. Cf. ISO 19111:2007:2007-07, part 9.3, table 27 and annex B.2.2.
    /// <see href="http://data.ign.fr/def/ignf#CoordinateSystemAxis"></see></summary>
    let CoordinateSystemAxis = _prefix "CoordinateSystemAxis"
    /// <summary>
    /// Depending on the spatial dimension of coordinates (1D, 2D, 3D), this piece of metadata is used for specifying the elements of definition associated to a given set of coordinates: its datum, its ellipsoid, its prime meridian, the type of coordinates (geocentric, geographic, projected,...), the coordinates units of measure, when appropriate the cartographic projection used, the vertical coordinate reference system. Definition translated from: http://geodesie.ign.fr/index.php?page=glossaire. Cf. ISO 19111:2007:2007-07, part 8.2, table 4 and annex B.1.
    /// <see href="http://data.ign.fr/def/ignf#CRS"></see></summary>
    let CRS = _prefix "CRS"
    /// <summary>
    /// Geographic area or time interval in which the referring object is valid. Cf. ISO 19111:2007:2007-07, tables 4, 33 and 42, attribute domainOfValidity.
    /// <see href="http://data.ign.fr/def/ignf#domainOfValidity"></see></summary>
    let domainOfValidity = _prefix "domainOfValidity"
    /// <summary>
    /// Geographic area or time interval in which the referring object is valid. Cf. ISO 19115-1:2014:2014-04, part 6.6.1 and table B.15 line 335.
    /// <see href="http://data.ign.fr/def/ignf#Extent"></see></summary>
    let Extent = _prefix "Extent"
    /// <summary>
    /// Set of axes that spans a given coordinate space and of mathematical rules for specifying how coordinates are to be assigned to points. Cf. ISO 19111:2007:2007-07, part 9.2, table 17 and annex B.2.
    /// <see href="http://data.ign.fr/def/ignf#CoordinateSystem"></see></summary>
    let CoordinateSystem = _prefix "CoordinateSystem"
    /// <summary>
    /// Coordinate system which gives the position of points relative to n mutually perpendicular axes. Cf. ISO 19111:2007:2007-07, tables 15 and 18.
    /// <see href="http://data.ign.fr/def/ignf#CartesianCS"></see></summary>
    let CartesianCS = _prefix "CartesianCS"
    /// <summary>
    /// Coordinate reference system associated with a geodetic datum. Cf. ISO 19111:2007:2007-07, part 8.2.2.a, table 10 and annex B.1.2.1.a.
    /// <see href="http://data.ign.fr/def/ignf#GeodeticCRS"></see></summary>
    let GeodeticCRS = _prefix "GeodeticCRS"
    /// <summary>
    /// Coordinate reference system using at least two independent single coordinate reference systems. Cf. ISO 19111:2007:2007-07, parts 8.2.3.c, 8.2.4, table 6 and annex B.1.2.4.
    /// <see href="http://data.ign.fr/def/ignf#CompoundCRS"></see></summary>
    let CompoundCRS = _prefix "CompoundCRS"
    /// <summary>
    /// Indicates the single coordinate reference systems used by a compound coordinate reference system. Cf. ISO 19111:2007:2007-07, table 6, association role componentReferenceSystem.
    /// <see href="http://data.ign.fr/def/ignf#includesSingleCRS"></see></summary>
    let includesSingleCRS = _prefix "includesSingleCRS"
    /// <summary>
    /// Ordered list of single coordinate reference systems.
    /// <see href="http://data.ign.fr/def/ignf#SingleCRSList"></see></summary>
    let SingleCRSList = _prefix "SingleCRSList"
    /// <summary>
    /// Coordinate operation in which both coordinate reference systems are based on the same datum. Cf. ISO 19111:2007:2007-07, table 45 and annex B.4.2.
    /// <see href="http://data.ign.fr/def/ignf#Conversion"></see></summary>
    let Conversion = _prefix "Conversion"
    /// <summary>
    /// A non concatenated coordinate operation. Cf. ISO 19111:2007:2007-07, table 43.
    /// <see href="http://data.ign.fr/def/ignf#SingleOperation"></see></summary>
    let SingleOperation = _prefix "SingleOperation"
    /// <summary>
    /// Mathematical operation on coordinates, based on one-to-one relationship, that changes coordinates from one coordinate reference system to another. Cf. ISO 19111:2007:2007-07, part 11.1, table 42 and annex B.4.
    /// <see href="http://data.ign.fr/def/ignf#CoordinateOperation"></see></summary>
    let CoordinateOperation = _prefix "CoordinateOperation"
    /// <summary>
    /// An axis used by some ellipsoidal or cartesian coordinate system. Cf. ISO 19111:2007:2007-07, table 17, association role axis.
    /// <see href="http://data.ign.fr/def/ignf#axis"></see></summary>
    let axis = _prefix "axis"
    /// <summary>
    /// Parameter or set of parameters that define the position of the origin, the scale and the orientation of a coordinate system. Cf. ISO 19111:2007:2007-07, part 10.1, table 33 and annex B.3.
    /// <see href="http://data.ign.fr/def/ignf#Datum"></see></summary>
    let Datum = _prefix "Datum"
    /// <summary>
    /// Surface formed by the rotation of an ellipse about its minor axis, defined by a semi-major axis and a flattening parameter and fairly geocentric. NB : It is a mathematical model of the geoid, i.e. the Earth without its relief. Many geodetic ellipsoids exist. Cf. ISO 19111:2007:2007-07, part 10.2.2, table 36 and annex B.3.2.3.
    /// <see href="http://data.ign.fr/def/ignf#Ellipsoid"></see></summary>
    let Ellipsoid = _prefix "Ellipsoid"
    /// <summary>
    /// Indicates the length of the semi major axis of an ellipsoid. Cf. ISO 19111:2007:2007-07, table 36, attribute length of semi-major axis.
    /// <see href="http://data.ign.fr/def/ignf#semiMajorAxis"></see></summary>
    let semiMajorAxis = _prefix "semiMajorAxis"
    /// <summary>
    /// Indicates the length of the semi minor axis of an ellipsoid. Cf. ISO 19111:2007:2007-07, table 37, attribute length of semi-minor axis.
    /// <see href="http://data.ign.fr/def/ignf#semiMinorAxis"></see></summary>
    let semiMinorAxis = _prefix "semiMinorAxis"
    /// <summary>
    /// Indicates the inverse flattening value of an ellipsoid, expressed as a number or a ratio (percentage rate, parts per million, etc.). Cf. ISO 19111:2007:2007-07, table 37, attribute inverse flattening
    /// <see href="http://data.ign.fr/def/ignf#inverseFlattening"></see></summary>
    let inverseFlattening = _prefix "inverseFlattening"
    /// <summary>
    /// Indicates whether the ellipsoid is a sphere. Cf. ISO 19111:2007:2007-07, table 37, attribute ellipsoid=sphere indicator.
    /// <see href="http://data.ign.fr/def/ignf#isSphere"></see></summary>
    let isSphere = _prefix "isSphere"
    /// <summary>
    /// Coordinate system which gives the position is specified by geodetic latitude, geodetic longitude and (in the three-dimensional case) ellipsoidal height. Cf. ISO 19111:2007:2007-07, tables 15 and 20.
    /// <see href="http://data.ign.fr/def/ignf#EllipsoidalCS"></see></summary>
    let EllipsoidalCS = _prefix "EllipsoidalCS"
    /// <summary>
    /// The datum used by a single coordinate reference system. Cf. ISO 19111:2007:2007-07, table 5, named association DefiningDatum.
    /// <see href="http://data.ign.fr/def/ignf#datum"></see></summary>
    let datum = _prefix "datum"
    /// <summary>
    /// Datum describing the relation of a two- or three-dimensional coordinate system to the Earth. Cf. ISO 19111:2007:2007-07, part 10.2, table 34 and annex B.3.2.
    /// <see href="http://data.ign.fr/def/ignf#GeodeticDatum"></see></summary>
    let GeodeticDatum = _prefix "GeodeticDatum"
    /// <summary>
    /// Coordinate reference system consisting of one coordinate system and one datum. Cf. ISO 19111:2007:2007-07, table 5.
    /// <see href="http://data.ign.fr/def/ignf#SingleCRS"></see></summary>
    let SingleCRS = _prefix "SingleCRS"
    /// <summary>
    /// The ellipsoid used by a geodetic datum. Cf. ISO 19111:2007:2007-07, table 34, association role ellipsoid.
    /// <see href="http://data.ign.fr/def/ignf#ellipsoid"></see></summary>
    let ellipsoid = _prefix "ellipsoid"
    /// <summary>
    /// The prime meridian used by a geodetic datum. Cf. ISO 19111:2007:2007-07, table 34, association role primeMeridian.
    /// <see href="http://data.ign.fr/def/ignf#primeMeridian"></see></summary>
    let primeMeridian = _prefix "primeMeridian"
    /// <summary>
    /// Meridian from which the longitudes of other meridians are quantified. Cf. ISO 19111:2007:2007-07, part 10.2.1, table 35 and annex B.3.2.2.
    /// <see href="http://data.ign.fr/def/ignf#PrimeMeridian"></see></summary>
    let PrimeMeridian = _prefix "PrimeMeridian"
    /// <summary>
    /// Box bounding an area of interest. Cf. ISO 19115-1:2014:2014-04, part 6.6.1 and table B.15.1 line 344.
    /// <see href="http://data.ign.fr/def/ignf#GeographicBoundingBox"></see></summary>
    let GeographicBoundingBox = _prefix "GeographicBoundingBox"
    /// <summary>
    /// Indicates the west bound longitude of a bounding box. Cf. ISO 19115-1:2014:2014-04, part 6.6.1 and table B.15.1 line 345.
    /// <see href="http://data.ign.fr/def/ignf#westBoundLongitude"></see></summary>
    let westBoundLongitude = _prefix "westBoundLongitude"
    /// <summary>
    /// Indicates the east bound longitude of a bounding box. Cf. ISO 19115-1:2014:2014-04, part 6.6.1 and table B.15.1 line 346.
    /// <see href="http://data.ign.fr/def/ignf#eastBoundLongitude"></see></summary>
    let eastBoundLongitude = _prefix "eastBoundLongitude"
    /// <summary>
    /// Indicates the south bound latitude of a bounding box. Cf. ISO 19115-1:2014:2014-04, part 6.6.1 and table B.15.1 line 347.
    /// <see href="http://data.ign.fr/def/ignf#southBoundLatitude"></see></summary>
    let southBoundLatitude = _prefix "southBoundLatitude"
    /// <summary>
    /// Indicates the north bound longitude of a bounding box. Cf. ISO 19115-1:2014:2014-04, part 6.6.1 and table B.15.1 line 348.
    /// <see href="http://data.ign.fr/def/ignf#northBoundLatitude"></see></summary>
    let northBoundLatitude = _prefix "northBoundLatitude"
    /// <summary>
    /// The method (algorithm or procedure) used to perform the coordinate operation. Cf. ISO 19111:2007:2007-07, table 48 and annex B.4.5.
    /// <see href="http://data.ign.fr/def/ignf#OperationMethod"></see></summary>
    let OperationMethod = _prefix "OperationMethod"
    /// <summary>
    /// Parameter used by a method to perform some coordinate operation. Cf. ISO 19111:2007:2007-07, table 52 and annex B.4.5.
    /// <see href="http://data.ign.fr/def/ignf#OperationParameter"></see></summary>
    let OperationParameter = _prefix "OperationParameter"
    /// <summary>
    /// Value of a parameter used by a method to perform some coordinate operation. Cf. ISO 19111:2007:2007-07, table 55.
    /// <see href="http://data.ign.fr/def/ignf#OperationParameterValue"></see></summary>
    let OperationParameterValue = _prefix "OperationParameterValue"
    /// <summary>
    /// Coordinate reference system derived from a two-dimensional geodetic coordinate reference system by applying a map projection. Cf. ISO 19111:2007:2007-07, part 8.2.3.b, table 11 and annex B.1.2.3.
    /// <see href="http://data.ign.fr/def/ignf#ProjectedCRS"></see></summary>
    let ProjectedCRS = _prefix "ProjectedCRS"
    /// <summary>
    /// The geodetic coordinate reference system on which a projected coordinate reference system is based. Cf. ISO 19111:2007:2007-07, table 11, association role baseCRS.
    /// <see href="http://data.ign.fr/def/ignf#baseCRS"></see></summary>
    let baseCRS = _prefix "baseCRS"
    /// <summary>
    /// The coordinate system used by a coordinate reference system. Cf. ISO 19111:2007:2007-07, table 5, named association CoordinateSystem.
    /// <see href="http://data.ign.fr/def/ignf#coordinateSystem"></see></summary>
    let coordinateSystem = _prefix "coordinateSystem"
    /// <summary>
    /// Coordinate operation in which the two coordinate reference systems are based on different datums. Cf. ISO 19111:2007:2007-07, table 44.
    /// <see href="http://data.ign.fr/def/ignf#Transformation"></see></summary>
    let Transformation = _prefix "Transformation"
    /// <summary>
    /// One-dimensional coordinate reference system associated with a vertical datum and used for recording heights or depths.Ellipsoidal heights are not captured in a vertical coordinate reference system but as part of a 3D coordinates tuple defined in a geodetic 3D coordinate reference system. Cf. ISO 19111:2007:2007-07, parts 8.2.2.b, table 14 and annex B.1.2.1.b.
    /// <see href="http://data.ign.fr/def/ignf#VerticalCRS"></see></summary>
    let VerticalCRS = _prefix "VerticalCRS"
    /// <summary>
    /// Datum describing the relation of gravity-related heights or depths to the Earth. Cf. ISO 19111:2007:2007-07, table 41 and annex B.3.3.
    /// <see href="http://data.ign.fr/def/ignf#VerticalDatum"></see></summary>
    let VerticalDatum = _prefix "VerticalDatum"
    /// <summary>
    /// One-dimensional coordinate system used for gravity related height or depth measurements. Cf. ISO 19111:2007:2007-07, tables 15 and 25.
    /// <see href="http://data.ign.fr/def/ignf#VerticalCS"></see></summary>
    let VerticalCS = _prefix "VerticalCS"
    /// <summary>
    /// The abbreviation used to identify an axis. Cf. ISO 19111:2007:2007-07, table 27, attribute coordinate system axis abbreviation.
    /// <see href="http://data.ign.fr/def/ignf#axisAbbrev"></see></summary>
    let axisAbbrev = _prefix "axisAbbrev"
    /// <summary>
    /// The direction of an axis. Cf. ISO 19111:2007:2007-07, table 27, attribute coordinate system axis direction.
    /// <see href="http://data.ign.fr/def/ignf#axisDirection"></see></summary>
    let axisDirection = _prefix "axisDirection"
    /// <summary>
    /// The cartesian coordinate system used by some geodetic or projected coordinate reference system. Cf. ISO 19111:2007:2007-07, tables 10 et 11, association roles coordinateSystem.
    /// <see href="http://data.ign.fr/def/ignf#cartesianCS"></see></summary>
    let cartesianCS = _prefix "cartesianCS"
    /// <summary>
    /// Rule or authority for a code, name, term or category.
    /// <see href="http://data.ign.fr/def/ignf#codeSpace"></see></summary>
    let codeSpace = _prefix "codeSpace"
    /// <summary>
    /// The conversion used to define a projected coordinate reference system. Cf. ISO 19111:2007:2007-07, table 7, named association Definition.
    /// <see href="http://data.ign.fr/def/ignf#conversion"></see></summary>
    let conversion = _prefix "conversion"
    /// <summary>
    /// The ellipsoidal coordinate system used by a geodetic coordinate reference system. Cf. ISO 19111:2007:2007-07, table 10, named association CoordinateSystem.
    /// <see href="http://data.ign.fr/def/ignf#ellipsoidalCS"></see></summary>
    let ellipsoidalCS = _prefix "ellipsoidalCS"
    /// <summary>
    /// The EPSG identifier of the resource.
    /// <see href="http://data.ign.fr/def/ignf#epsgID"></see></summary>
    let epsgID = _prefix "epsgID"
    /// <summary>
    /// The geodetic datum used by a geodetic coordinate reference system. Cf. ISO 19111:2007:2007-07, table 10, named association DefiningDatum.
    /// <see href="http://data.ign.fr/def/ignf#geodeticDatum"></see></summary>
    let geodeticDatum = _prefix "geodeticDatum"
    /// <summary>
    /// The geographic bounding box used for defining a domain of validity. Cf. ISO 19115-1:2014:2014-04, part 6.6.1 and table B.15 line 337.
    /// <see href="http://data.ign.fr/def/ignf#geographicElement"></see></summary>
    let geographicElement = _prefix "geographicElement"
    /// <summary>
    /// Indicates the longitude from Greenwich meridian. Cf. ISO 19111:2007:2007-07, table 35, attribute prime meridian Greenwich longitude.
    /// <see href="http://data.ign.fr/def/ignf#greenwichLongitude"></see></summary>
    let greenwichLongitude = _prefix "greenwichLongitude"
    /// <summary>
    /// The formula used by a method to perform an operation on coordinates. Cf. ISO 19111:2007:2007-07, table 48, attribute coordinate operation method formula reference.
    /// <see href="http://data.ign.fr/def/ignf#methodFormula"></see></summary>
    let methodFormula = _prefix "methodFormula"
    /// <summary>
    /// The version of an operation performed on coordinates. Cf. ISO 19111:2007:2007-07, table 42, attribute coordinate operation version.
    /// <see href="http://data.ign.fr/def/ignf#operationVersion"></see></summary>
    let operationVersion = _prefix "operationVersion"
    /// <summary>
    /// The parameter associated to a given value. Cf. ISO 19111:2007:2007-07, table 55, association role parameter.
    /// <see href="http://data.ign.fr/def/ignf#parameter"></see></summary>
    let parameter = _prefix "parameter"
    /// <summary>
    /// The scope of the referring object. Cf. ISO 19111:2007:2007-07, tables 4, 33 et 42, attribute scope.
    /// <see href="http://data.ign.fr/def/ignf#scope"></see></summary>
    let scope = _prefix "scope"
    /// <summary>
    /// The coordinate reference system associated to the data used as input of a given operation. Cf. ISO 19111:2007:2007-07, table 42, named association Source.
    /// <see href="http://data.ign.fr/def/ignf#sourceCRS"></see></summary>
    let sourceCRS = _prefix "sourceCRS"
    /// <summary>
    /// The dimension of the coordinate reference system associated with the data used as input of an operation. Cf. ISO 19111:2007:2007-07, table 48, attribute dimension of source CRS.
    /// <see href="http://data.ign.fr/def/ignf#sourceDimension"></see></summary>
    let sourceDimension = _prefix "sourceDimension"
    /// <summary>
    /// The coordinate reference system associated to the data obtained as output of a given operation. Cf. ISO 19111:2007:2007-07, table 42, named association Target.
    /// <see href="http://data.ign.fr/def/ignf#targetCRS"></see></summary>
    let targetCRS = _prefix "targetCRS"
    /// <summary>
    /// The dimension of the coordinate reference system associated with the data obtained as output of an operation. Cf. ISO 19111:2007:2007-07, table 48, attribute dimension of target CRS.
    /// <see href="http://data.ign.fr/def/ignf#targetDimension"></see></summary>
    let targetDimension = _prefix "targetDimension"
    /// <summary>
    /// The method used by an operation on coordinates. Cf. ISO 19111:2007:2007-07, table 43, association role method.
    /// <see href="http://data.ign.fr/def/ignf#usesMethod"></see></summary>
    let usesMethod = _prefix "usesMethod"
    /// <summary>
    /// A parameter used by a method to perform an operation on coordinates. Cf. ISO 19111:2007:2007-07, table 48, association role parameter.
    /// <see href="http://data.ign.fr/def/ignf#usesParameter"></see></summary>
    let usesParameter = _prefix "usesParameter"
    /// <summary>
    /// A value used by an operation on coordinates. Cf. ISO 19111:2007:2007-07, table 43, association role parameterValue.
    /// <see href="http://data.ign.fr/def/ignf#usesValue"></see></summary>
    let usesValue = _prefix "usesValue"
    /// <summary>
    /// The vertical coordinate system used by a vertical coordinate reference system. Cf. ISO 19111:2007:2007-07, table 14, named association CoordinateSystem.
    /// <see href="http://data.ign.fr/def/ignf#verticalCS"></see></summary>
    let verticalCS = _prefix "verticalCS"
    /// <summary>
    /// The vertical datum used by a vertical coordinate reference system. Cf. ISO 19111:2007:2007-07, table 14, named association DefiningDatum.
    /// <see href="http://data.ign.fr/def/ignf#verticalDatum"></see></summary>
    let verticalDatum = _prefix "verticalDatum"

#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ignf =
    let _prefixId = PrefixId.fromNamespaceLabel "http://data.ign.fr/def/ignf#" "ignf"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Liste d'axesrdfs:label : List of axes</para>
    ///   <para>rdfs:comment : Ordered list of coordinates system axes.rdfs:comment : Liste ordonnée d'axes de systèmes de coordonnées.</para>
    ///   <a href="http://data.ign.fr/def/ignf#AxesList">ignf:AxesList</a>
    /// </summary>
    let AxesList = _prefixId.prefix "AxesList"
    /// <summary>
    ///   <para>rdfs:comment : Depending on the spatial dimension of coordinates (1D, 2D, 3D), this piece of metadata is used for specifying the elements of definition associated to a given set of coordinates: its datum, its ellipsoid, its prime meridian, the type of coordinates (geocentric, geographic, projected,...), the coordinates units of measure, when appropriate the cartographic projection used, the vertical coordinate reference system. Definition translated from: http://geodesie.ign.fr/index.php?page=glossaire. Cf. ISO 19111:2007:2007-07, part 8.2, table 4 and annex B.1.rdfs:comment : Métadonnées permettant de préciser, selon la dimension spatiale des coordonnées 1D, 2D ou 3D, les éléments de définition associés au jeu de coordonnées: le système de référence terrestre, l'ellipsoïde géodésique, le méridien origine, le type de coordonnées (cartésiennes géocentriques, planes, géographiques,...), les unités dans lesquelles sont exprimées les coordonnées, la projection cartographique, le référentiel altimétrique(http://geodesie.ign.fr/index.php?page=glossaire). Cf. ISO 19111:2007:2007-07, partie 8.2, tableau 4 et annexe B.1.</para>
    ///   <para>rdfs:label : Système de coordonnées de référencerdfs:label : Coordinate reference system (CRS)</para>
    ///   <a href="http://data.ign.fr/def/ignf#CRS">ignf:CRS</a>
    /// </summary>
    let CRS = _prefixId.prefix "CRS"
    /// <summary>
    ///   <para>rdfs:comment : Coordinate system which gives the position of points relative to n mutually perpendicular axes. Cf. ISO 19111:2007:2007-07, tables 15 and 18.rdfs:comment : Système de coordonnées donnant la position des points relativement à n axes perpendiculaires deux à deux. Cf. ISO 19111:2007:2007-07, tableaux 15 et 18.</para>
    ///   <para>rdfs:label : Système cartésien de coordonnéesrdfs:label : Cartesian coordinate system</para>
    ///   <a href="http://data.ign.fr/def/ignf#CartesianCS">ignf:CartesianCS</a>
    /// </summary>
    let CartesianCS = _prefixId.prefix "CartesianCS"
    /// <summary>
    ///   <para>rdfs:label : Système de coordonnées de référence combinérdfs:label : Compound coordinate reference system</para>
    ///   <para>rdfs:comment : Système de coordonnées de référence utilisant au moins deux systèmes de coordonnées de référence simples indépendants. Cf. ISO 19111:2007:2007-07, parties 8.2.3.c, 8.2.4, tableau 6 et annexe B.1.2.4.rdfs:comment : Coordinate reference system using at least two independent single coordinate reference systems. Cf. ISO 19111:2007:2007-07, parts 8.2.3.c, 8.2.4, table 6 and annex B.1.2.4.</para>
    ///   <a href="http://data.ign.fr/def/ignf#CompoundCRS">ignf:CompoundCRS</a>
    /// </summary>
    let CompoundCRS = _prefixId.prefix "CompoundCRS"
    /// <summary>
    ///   <para>rdfs:comment : Coordinate operation in which both coordinate reference systems are based on the same datum. Cf. ISO 19111:2007:2007-07, table 45 and annex B.4.2.rdfs:comment : Opération sur les coordonnées dans laquelle les deux systèmes de coordonnées de référence sont basés sur le même référentiel (ex: projection cartographique). Cf. ISO 19111:2007:2007-07, tableau 45 et annexe B.4.2.</para>
    ///   <para>rdfs:label : Conversionrdfs:label : Conversion</para>
    ///   <a href="http://data.ign.fr/def/ignf#Conversion">ignf:Conversion</a>
    /// </summary>
    let Conversion = _prefixId.prefix "Conversion"
    /// <summary>
    ///   <para>rdfs:comment : Mathematical operation on coordinates, based on one-to-one relationship, that changes coordinates from one coordinate reference system to another. Cf. ISO 19111:2007:2007-07, part 11.1, table 42 and annex B.4.rdfs:comment : Opération mathématique sur des coordonnées, basée sur une relation 1:1, qui change ces coordonnées d'une système de coordonnées de référence à un autre. Cf. ISO 19111:2007:2007-07, partie 11.1, tableau 42 et annexe B.4.</para>
    ///   <para>rdfs:label : Opération sur les coordonnéesrdfs:label : Coordinate operation</para>
    ///   <a href="http://data.ign.fr/def/ignf#CoordinateOperation">ignf:CoordinateOperation</a>
    /// </summary>
    let CoordinateOperation = _prefixId.prefix "CoordinateOperation"
    /// <summary>
    ///   <para>rdfs:comment : Set of axes that spans a given coordinate space and of mathematical rules for specifying how coordinates are to be assigned to points. Cf. ISO 19111:2007:2007-07, part 9.2, table 17 and annex B.2.rdfs:comment : Ensemble d'axes couvrant un espace de coordonnées, et de règles mathématiques permettant l'affectation de coordonnées à un point. Cf. ISO 19111:2007:2007-07, partie 9.2, tableau 17 et annexe B.2.</para>
    ///   <para>rdfs:label : Système de coordonnéesrdfs:label : Coordinate system</para>
    ///   <a href="http://data.ign.fr/def/ignf#CoordinateSystem">ignf:CoordinateSystem</a>
    /// </summary>
    let CoordinateSystem = _prefixId.prefix "CoordinateSystem"
    /// <summary>
    ///   <para>rdfs:comment : Axis composing a coordinate system and used to specify one given coordinate in a coordinate tuple describing the position of a point. Cf. ISO 19111:2007:2007-07, part 9.3, table 27 and annex B.2.2.rdfs:comment : Axe par rapport auquel une coordonnée d'un point est spécifiée dans un système de coordonnées. Cf. ISO 19111:2007:2007-07, partie 9.3, tableau 27 et annexe B.2.2.</para>
    ///   <para>rdfs:label : Axerdfs:label : Axis</para>
    ///   <a href="http://data.ign.fr/def/ignf#CoordinateSystemAxis">ignf:CoordinateSystemAxis</a>
    /// </summary>
    let CoordinateSystemAxis = _prefixId.prefix "CoordinateSystemAxis"
    /// <summary>
    ///   <para>rdfs:comment : Parameter or set of parameters that define the position of the origin, the scale and the orientation of a coordinate system. Cf. ISO 19111:2007:2007-07, part 10.1, table 33 and annex B.3.rdfs:comment : Paramètre ou ensemble de paramètres définissant la position de l'origine, l'échelle et l'orientation d'un système de coordonnées. Cf. ISO 19111:2007:2007-07, partie 10.1, tableau 33 et annexe B.3.</para>
    ///   <para>rdfs:label : Référentielrdfs:label : Datum</para>
    ///   <a href="http://data.ign.fr/def/ignf#Datum">ignf:Datum</a>
    /// </summary>
    let Datum = _prefixId.prefix "Datum"
    /// <summary>
    ///   <para>rdfs:comment : Surface formed by the rotation of an ellipse about its minor axis, defined by a semi-major axis and a flattening parameter and fairly geocentric. NB : It is a mathematical model of the geoid, i.e. the Earth without its relief. Many geodetic ellipsoids exist. Cf. ISO 19111:2007:2007-07, part 10.2.2, table 36 and annex B.3.2.3.rdfs:comment : Surface de révolution engendrée par une ellipse tournant autour de son petit axe, définie par le rayon équatorial et un paramètre d'aplatissement, et sensiblement géocentrique. Note : Il s'agit d'un modèle mathématique du géoïde, c'est-à-dire de la Terre débarrassée de son relief. Il existe de nombreux ellipsoïdes géodésiques. Cf. ISO 19111:2007:2007-07, partie 10.2.2, tableau 36 et annexe B.3.2.3.</para>
    ///   <para>rdfs:label : Ellipsoïderdfs:label : Ellipsoid</para>
    ///   <a href="http://data.ign.fr/def/ignf#Ellipsoid">ignf:Ellipsoid</a>
    /// </summary>
    let Ellipsoid = _prefixId.prefix "Ellipsoid"
    /// <summary>
    ///   <para>rdfs:comment : Coordinate system which gives the position is specified by geodetic latitude, geodetic longitude and (in the three-dimensional case) ellipsoidal height. Cf. ISO 19111:2007:2007-07, tables 15 and 20.rdfs:comment : Système de coordonnées dans lequel la position est spécifiée par la latitude géodésique, la longitude géodésique et (dans le cas tridimensionnel) la hauteur ellipsoïdale. Cf. ISO 19111:2007:2007-07, tableaux 15 et 20.</para>
    ///   <para>rdfs:label : Système de coordonnées ellipsoïdalrdfs:label : Ellipsoidal coordinate system</para>
    ///   <a href="http://data.ign.fr/def/ignf#EllipsoidalCS">ignf:EllipsoidalCS</a>
    /// </summary>
    let EllipsoidalCS = _prefixId.prefix "EllipsoidalCS"
    /// <summary>
    ///   <para>rdfs:comment : Geographic area or time interval in which the referring object is valid. Cf. ISO 19115-1:2014:2014-04, part 6.6.1 and table B.15 line 335.rdfs:comment : Zone géographique ou intervalle de temps dans lequel la référence est valide. Cf. ISO 19115-1:2014:2014-04, partie 6.6.1 et tableau B.15 ligne 335.</para>
    ///   <para>rdfs:label : Étenduerdfs:label : Extent</para>
    ///   <a href="http://data.ign.fr/def/ignf#Extent">ignf:Extent</a>
    /// </summary>
    let Extent = _prefixId.prefix "Extent"
    /// <summary>
    ///   <para>rdfs:comment : Coordinate reference system associated with a geodetic datum. Cf. ISO 19111:2007:2007-07, part 8.2.2.a, table 10 and annex B.1.2.1.a.rdfs:comment : Système de coordonnées de référence associé à un référentiel géodésique. Cf. ISO 19111:2007:2007-07, partie 8.2.2.a, tableau 10 et annexe B.1.2.1.a.</para>
    ///   <para>rdfs:label : Système de coordonnées de référence geodésiquerdfs:label : Geodetic coordinate reference system</para>
    ///   <a href="http://data.ign.fr/def/ignf#GeodeticCRS">ignf:GeodeticCRS</a>
    /// </summary>
    let GeodeticCRS = _prefixId.prefix "GeodeticCRS"
    /// <summary>
    ///   <para>rdfs:comment : Datum describing the relation of a two- or three-dimensional coordinate system to the Earth. Cf. ISO 19111:2007:2007-07, part 10.2, table 34 and annex B.3.2.rdfs:comment : Référentiel décrivant la relation entre un système de coordonnées à deux ou trois dimensions et la Terre. Cf. ISO 19111:2007:2007-07, partie 10.2, tableau 34 et annexe B.3.2.</para>
    ///   <para>rdfs:label : Référentiel géodésiquerdfs:label : Geodetic datum</para>
    ///   <a href="http://data.ign.fr/def/ignf#GeodeticDatum">ignf:GeodeticDatum</a>
    /// </summary>
    let GeodeticDatum = _prefixId.prefix "GeodeticDatum"
    /// <summary>
    ///   <para>rdfs:comment : Box bounding an area of interest. Cf. ISO 19115-1:2014:2014-04, part 6.6.1 and table B.15.1 line 344.rdfs:comment : Cadre délimitant une zone d'intérêt. Cf. ISO 19115-1:2014:2014-04, partie 6.6.1 et tableau B.15.1 ligne 344.</para>
    ///   <para>rdfs:label : Cadre englobant géographiquerdfs:label : Geographic bounding box</para>
    ///   <a href="http://data.ign.fr/def/ignf#GeographicBoundingBox">ignf:GeographicBoundingBox</a>
    /// </summary>
    let GeographicBoundingBox = _prefixId.prefix "GeographicBoundingBox"
    /// <summary>
    ///   <para>rdfs:comment : The method (algorithm or procedure) used to perform the coordinate operation. Cf. ISO 19111:2007:2007-07, table 48 and annex B.4.5.rdfs:comment : Méthode utilisée pour faire une opération sur des coordonnées. Cf. ISO 19111:2007:2007-07, tableau 48 et annexe B.4.5.</para>
    ///   <para>rdfs:label : Méthoderdfs:label : Operation method</para>
    ///   <a href="http://data.ign.fr/def/ignf#OperationMethod">ignf:OperationMethod</a>
    /// </summary>
    let OperationMethod = _prefixId.prefix "OperationMethod"
    /// <summary>
    ///   <para>rdfs:comment : Parameter used by a method to perform some coordinate operation. Cf. ISO 19111:2007:2007-07, table 52 and annex B.4.5.rdfs:comment : Paramètre utilisé par une méthode pour faire une opération sur des coordonnées. Cf. ISO 19111:2007:2007-07, tableau 52 et annexe B.4.5.</para>
    ///   <para>rdfs:label : Paramètrerdfs:label : Operation parameter</para>
    ///   <a href="http://data.ign.fr/def/ignf#OperationParameter">ignf:OperationParameter</a>
    /// </summary>
    let OperationParameter = _prefixId.prefix "OperationParameter"
    /// <summary>
    ///   <para>rdfs:comment : Value of a parameter used by a method to perform some coordinate operation. Cf. ISO 19111:2007:2007-07, table 55.rdfs:comment : Valeur d'un paramètre utilisé par une méthode pour faire une opération sur des coordonnées. Cf. ISO 19111:2007:2007-07, tableau 55.</para>
    ///   <para>rdfs:label : Valeur de paramètrerdfs:label : Operation parameter value</para>
    ///   <a href="http://data.ign.fr/def/ignf#OperationParameterValue">ignf:OperationParameterValue</a>
    /// </summary>
    let OperationParameterValue = _prefixId.prefix "OperationParameterValue"
    /// <summary>
    ///   <para>rdfs:comment : Meridian from which the longitudes of other meridians are quantified. Cf. ISO 19111:2007:2007-07, part 10.2.1, table 35 and annex B.3.2.2.rdfs:comment : Méridien à partir duquel les longitudes d'autres méridiens sont mesurées. Cf. ISO 19111:2007:2007-07, partie 10.2.1, tableau 35 et annexe B.3.2.2.</para>
    ///   <para>rdfs:label : Méridien originerdfs:label : Prime meridian</para>
    ///   <a href="http://data.ign.fr/def/ignf#PrimeMeridian">ignf:PrimeMeridian</a>
    /// </summary>
    let PrimeMeridian = _prefixId.prefix "PrimeMeridian"
    /// <summary>
    ///   <para>rdfs:comment : Coordinate reference system derived from a two-dimensional geodetic coordinate reference system by applying a map projection. Cf. ISO 19111:2007:2007-07, part 8.2.3.b, table 11 and annex B.1.2.3.rdfs:comment : Système de coordonnées de référence dérivé par projection cartographique d'un système de coordonnées de référence bidimentionnel. Cf. ISO 19111:2007:2007-07, partie 8.2.3.b, tableau 11 et annexe B.1.2.3.</para>
    ///   <para>rdfs:label : Système de coordonnées de référence projetérdfs:label : Projected coordinate reference system</para>
    ///   <a href="http://data.ign.fr/def/ignf#ProjectedCRS">ignf:ProjectedCRS</a>
    /// </summary>
    let ProjectedCRS = _prefixId.prefix "ProjectedCRS"
    /// <summary>
    ///   <para>rdfs:comment : Coordinate reference system consisting of one coordinate system and one datum. Cf. ISO 19111:2007:2007-07, table 5.rdfs:comment : Système de coordonnées de référence composé d'un système de coordonnées et d'un référentiel. Cf. ISO 19111:2007:2007-07 tableau 5.</para>
    ///   <para>rdfs:label : Système de coordonnées de référence simplerdfs:label : Single coordinate reference system</para>
    ///   <a href="http://data.ign.fr/def/ignf#SingleCRS">ignf:SingleCRS</a>
    /// </summary>
    let SingleCRS = _prefixId.prefix "SingleCRS"
    /// <summary>
    ///   <para>rdfs:label : Liste de systèmes de coordonnées de référence simplesrdfs:label : List of single coordinate reference systems</para>
    ///   <para>rdfs:comment : Ordered list of single coordinate reference systems.rdfs:comment : Liste ordonnée de systèmes de coordonnées de référence simples.</para>
    ///   <a href="http://data.ign.fr/def/ignf#SingleCRSList">ignf:SingleCRSList</a>
    /// </summary>
    let SingleCRSList = _prefixId.prefix "SingleCRSList"
    /// <summary>
    ///   <para>rdfs:comment : A non concatenated coordinate operation. Cf. ISO 19111:2007:2007-07, table 43.rdfs:comment : Opération non concaténée sur des coordonnées. Cf. ISO 19111:2007:2007-07, tableau 43.</para>
    ///   <para>rdfs:label : Opération simple sur les coordonnéesrdfs:label : Single coordinate operation</para>
    ///   <a href="http://data.ign.fr/def/ignf#SingleOperation">ignf:SingleOperation</a>
    /// </summary>
    let SingleOperation = _prefixId.prefix "SingleOperation"
    /// <summary>
    ///   <para>rdfs:comment : Coordinate operation in which the two coordinate reference systems are based on different datums. Cf. ISO 19111:2007:2007-07, table 44.rdfs:comment : Opération sur les coordonnées dans laquelle les deux systèmes de coordonnées de référence sont basés sur des référentiels distincts. Cf. ISO 19111:2007:2007-07, tableau 44.</para>
    ///   <para>rdfs:label : Transformationrdfs:label : Transformation</para>
    ///   <a href="http://data.ign.fr/def/ignf#Transformation">ignf:Transformation</a>
    /// </summary>
    let Transformation = _prefixId.prefix "Transformation"
    /// <summary>
    ///   <para>rdfs:comment : One-dimensional coordinate reference system associated with a vertical datum and used for recording heights or depths.Ellipsoidal heights are not captured in a vertical coordinate reference system but as part of a 3D coordinates tuple defined in a geodetic 3D coordinate reference system. Cf. ISO 19111:2007:2007-07, parts 8.2.2.b, table 14 and annex B.1.2.1.b.rdfs:comment : Système de coordonnées de référence à une dimension, associé à un référentiel vertical, et utilisé pour enregistrer des hauteurs ou des profondeurs. Les hauteurs ellipsoïdales ne sont pas enregistrées à l'aide d'un système de coordonnées de référence vertical, mais au sein d'un tuple de coordonnées 3D défini dans un système de coordonnées de référence géodésique 3D. Cf. ISO 19111:2007:2007-07, parties 8.2.2.b, tableau 14 et annexe B.1.2.1.b.</para>
    ///   <para>rdfs:label : Système de coordonnées de référence verticalrdfs:label : Vertical coordinate reference system</para>
    ///   <a href="http://data.ign.fr/def/ignf#VerticalCRS">ignf:VerticalCRS</a>
    /// </summary>
    let VerticalCRS = _prefixId.prefix "VerticalCRS"
    /// <summary>
    ///   <para>rdfs:comment : One-dimensional coordinate system used for gravity related height or depth measurements. Cf. ISO 19111:2007:2007-07, tables 15 and 25.rdfs:comment : Système de coordonnées à une dimension utilisé pour les mesures de hauteur ou de profondeur relatives à la gravité. Cf. ISO 19111:2007:2007-07, tableaux 15 et 25.</para>
    ///   <para>rdfs:label : Système de coordonnées verticalrdfs:label : Vertical coordinate system</para>
    ///   <a href="http://data.ign.fr/def/ignf#VerticalCS">ignf:VerticalCS</a>
    /// </summary>
    let VerticalCS = _prefixId.prefix "VerticalCS"
    /// <summary>
    ///   <para>rdfs:comment : Datum describing the relation of gravity-related heights or depths to the Earth. Cf. ISO 19111:2007:2007-07, table 41 and annex B.3.3.rdfs:comment : Référentiel décrivant la relation entre les hauteurs ou les profondeurs relatives à la gravité et la Terre. Cf. ISO 19111:2007:2007-07, tableau 41 et annexe B.3.3.</para>
    ///   <para>rdfs:label : Référentiel verticalrdfs:label : Vertical datum</para>
    ///   <a href="http://data.ign.fr/def/ignf#VerticalDatum">ignf:VerticalDatum</a>
    /// </summary>
    let VerticalDatum = _prefixId.prefix "VerticalDatum"
    /// <summary>
    ///   <para>rdfs:comment : An axis used by some ellipsoidal or cartesian coordinate system. Cf. ISO 19111:2007:2007-07, table 17, association role axis.rdfs:comment : Désigne un axe utilisé par un système de coordonnées ellipsoïdal ou cartésien. Cf. ISO 19111:2007:2007-07, tableau 17, rôle d'association axis.</para>
    ///   <para>rdfs:label : utilise l'axerdfs:label : uses axis</para>
    ///   <a href="http://data.ign.fr/def/ignf#axis">ignf:axis</a>
    /// </summary>
    let axis = _prefixId.prefix "axis"
    /// <summary>
    ///   <para>rdfs:comment : The abbreviation used to identify an axis. Cf. ISO 19111:2007:2007-07, table 27, attribute coordinate system axis abbreviation.rdfs:comment : Désigne l'abréviation utilisée pour désigner l'axe. Cf. ISO 19111:2007:2007-07, tableau 27, attribut abréviation de l'axe du système de coordonnées.</para>
    ///   <para>rdfs:label : abréviation utilisée pour désigner l'axerdfs:label : axis abbreviation</para>
    ///   <a href="http://data.ign.fr/def/ignf#axisAbbrev">ignf:axisAbbrev</a>
    /// </summary>
    let axisAbbrev = _prefixId.prefix "axisAbbrev"
    /// <summary>
    ///   <para>rdfs:comment : The direction of an axis. Cf. ISO 19111:2007:2007-07, table 27, attribute coordinate system axis direction.rdfs:comment : Désigne la direction de l'axe. Cf. ISO 19111:2007:2007-07, tableau 27, attribut direction de l'axe du système de coordonnées.</para>
    ///   <para>rdfs:label : direction de l'axerdfs:label : axis direction</para>
    ///   <a href="http://data.ign.fr/def/ignf#axisDirection">ignf:axisDirection</a>
    /// </summary>
    let axisDirection = _prefixId.prefix "axisDirection"
    /// <summary>
    ///   <para>rdfs:comment : The geodetic coordinate reference system on which a projected coordinate reference system is based. Cf. ISO 19111:2007:2007-07, table 11, association role baseCRS.rdfs:comment : Désigne le système de coordonnées de référence géodésique sur lequel repose un système de coordonnées de référence projeté. Cf. ISO 19111:2007:2007-07, tableau 11, rôle d'association baseCRS.</para>
    ///   <para>rdfs:label : système de coordonnées de référence de baserdfs:label : base coordinate reference system</para>
    ///   <a href="http://data.ign.fr/def/ignf#baseCRS">ignf:baseCRS</a>
    /// </summary>
    let baseCRS = _prefixId.prefix "baseCRS"
    /// <summary>
    ///   <para>rdfs:comment : The cartesian coordinate system used by some geodetic or projected coordinate reference system. Cf. ISO 19111:2007:2007-07, tables 10 et 11, association roles coordinateSystem.rdfs:comment : Désigne le système de coordonnées cartésien utilisé par un système de coordonnées de référence géodésique ou projeté. Cf. ISO 19111:2007:2007-07, tableaux 10 et 11, association nommée CoordinateSystem.</para>
    ///   <para>rdfs:label : utilise le système de coordonnées cartesienrdfs:label : uses cartesian coordinate system</para>
    ///   <a href="http://data.ign.fr/def/ignf#cartesianCS">ignf:cartesianCS</a>
    /// </summary>
    let cartesianCS = _prefixId.prefix "cartesianCS"
    /// <summary>
    ///   <para>rdfs:comment : Rule or authority for a code, name, term or category.rdfs:comment : Désigne la règle ou l'autorité dont résulte la valeur de la référence.</para>
    ///   <para>rdfs:label : espace de codagerdfs:label : code space</para>
    ///   <a href="http://data.ign.fr/def/ignf#codeSpace">ignf:codeSpace</a>
    /// </summary>
    let codeSpace = _prefixId.prefix "codeSpace"
    /// <summary>
    ///   <para>rdfs:comment : The conversion used to define a projected coordinate reference system. Cf. ISO 19111:2007:2007-07, table 7, named association Definition.rdfs:comment : Désigne la conversion utilisée pour définir un système de coordonnées de référence projeté. Cf. ISO 19111:2007:2007-07, tableau 7, association nommée Definition.</para>
    ///   <para>rdfs:label : défini par conversionrdfs:label : defined by conversion</para>
    ///   <a href="http://data.ign.fr/def/ignf#conversion">ignf:conversion</a>
    /// </summary>
    let conversion = _prefixId.prefix "conversion"
    /// <summary>
    ///   <para>rdfs:comment : The coordinate system used by a coordinate reference system. Cf. ISO 19111:2007:2007-07, table 5, named association CoordinateSystem.rdfs:comment : Désigne le système de coordonnées utilisé par un système de coordonnées de référence. Cf. ISO 19111:2007:2007-07, tableau 5, association nommée CoordinateSystem.</para>
    ///   <para>rdfs:label : utilise le système de coordonnéesrdfs:label : uses coordinate system</para>
    ///   <a href="http://data.ign.fr/def/ignf#coordinateSystem">ignf:coordinateSystem</a>
    /// </summary>
    let coordinateSystem = _prefixId.prefix "coordinateSystem"
    /// <summary>
    ///   <para>rdfs:comment : The datum used by a single coordinate reference system. Cf. ISO 19111:2007:2007-07, table 5, named association DefiningDatum.rdfs:comment : Désigne le référentiel utilisé par un système de coordonnées de référence simple. Cf. ISO 19111:2007:2007-07, tableau 5, association nommée DefiningDatum.</para>
    ///   <para>rdfs:label : utilise le référentielrdfs:label : uses datum</para>
    ///   <a href="http://data.ign.fr/def/ignf#datum">ignf:datum</a>
    /// </summary>
    let datum = _prefixId.prefix "datum"
    /// <summary>
    ///   <para>rdfs:comment : Geographic area or time interval in which the referring object is valid. Cf. ISO 19111:2007:2007-07, tables 4, 33 and 42, attribute domainOfValidity.rdfs:comment : Zone ou intervalle de temps dans lequel l'objet de référence est valide. Cf. ISO 19111:2007:2007-07, tableaux 4, 33 et 42, attribut domainOfValidity.</para>
    ///   <para>rdfs:label : domaine de validitérdfs:label : domain of validity</para>
    ///   <a href="http://data.ign.fr/def/ignf#domainOfValidity">ignf:domainOfValidity</a>
    /// </summary>
    let domainOfValidity = _prefixId.prefix "domainOfValidity"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the east bound longitude of a bounding box. Cf. ISO 19115-1:2014:2014-04, part 6.6.1 and table B.15.1 line 346.rdfs:comment : Désigne la longitude est maximale du cadre englobant. Cf. ISO 19115-1:2014:2014-04, partie 6.6.1 et tableau B.15.1 ligne 346.</para>
    ///   <para>rdfs:label : longitude est maximalerdfs:label : east bound longitude</para>
    ///   <a href="http://data.ign.fr/def/ignf#eastBoundLongitude">ignf:eastBoundLongitude</a>
    /// </summary>
    let eastBoundLongitude = _prefixId.prefix "eastBoundLongitude"
    /// <summary>
    ///   <para>rdfs:comment : The ellipsoid used by a geodetic datum. Cf. ISO 19111:2007:2007-07, table 34, association role ellipsoid.rdfs:comment : Désigne l'ellipsoïde utilisé par un référentiel géodésique. Cf. ISO 19111:2007:2007-07, tableau 34, rôle d'association ellipsoid.</para>
    ///   <para>rdfs:label : utilise l'ellipsoïderdfs:label : uses ellipsoid</para>
    ///   <a href="http://data.ign.fr/def/ignf#ellipsoid">ignf:ellipsoid</a>
    /// </summary>
    let ellipsoid = _prefixId.prefix "ellipsoid"
    /// <summary>
    ///   <para>rdfs:comment : The ellipsoidal coordinate system used by a geodetic coordinate reference system. Cf. ISO 19111:2007:2007-07, table 10, named association CoordinateSystem.rdfs:comment : Désigne le système de coordonnées ellipsoïdal utilisé par un système de coordonnées de référence géodésique. Cf. ISO 19111:2007:2007-07, tableau 10, association nommée CoordinateSystem.</para>
    ///   <para>rdfs:label : utilise le système de coordonnées ellipsoïdalrdfs:label : uses ellipsoidal coordinate system</para>
    ///   <a href="http://data.ign.fr/def/ignf#ellipsoidalCS">ignf:ellipsoidalCS</a>
    /// </summary>
    let ellipsoidalCS = _prefixId.prefix "ellipsoidalCS"
    /// <summary>
    ///   <para>rdfs:comment : The EPSG identifier of the resource.rdfs:comment : Indique l'identifiant EPSG de la ressource.</para>
    ///   <para>rdfs:label : identifiant epsgrdfs:label : espg identifier</para>
    ///   <a href="http://data.ign.fr/def/ignf#epsgID">ignf:epsgID</a>
    /// </summary>
    let epsgID = _prefixId.prefix "epsgID"
    /// <summary>
    ///   <para>rdfs:comment : The geodetic datum used by a geodetic coordinate reference system. Cf. ISO 19111:2007:2007-07, table 10, named association DefiningDatum.rdfs:comment : Désigne le référentiel géodésique utilisé par un système de coordonnées de référence géodésique. Cf. ISO 19111:2007:2007-07, tableau 10, association nommée DefiningDatum.</para>
    ///   <para>rdfs:label : utilise le référentiel géodésiquerdfs:label : uses geodetic datum</para>
    ///   <a href="http://data.ign.fr/def/ignf#geodeticDatum">ignf:geodeticDatum</a>
    /// </summary>
    let geodeticDatum = _prefixId.prefix "geodeticDatum"
    /// <summary>
    ///   <para>rdfs:comment : The geographic bounding box used for defining a domain of validity. Cf. ISO 19115-1:2014:2014-04, part 6.6.1 and table B.15 line 337.rdfs:comment : Désigne le cadre englobant géographique d'une région de validité. Cf. ISO 19115-1:2014:2014-04, partie 6.6.1 et tableau B.15 ligne 337.</para>
    ///   <para>rdfs:label : élément géographiquerdfs:label : geographic element</para>
    ///   <a href="http://data.ign.fr/def/ignf#geographicElement">ignf:geographicElement</a>
    /// </summary>
    let geographicElement = _prefixId.prefix "geographicElement"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the longitude from Greenwich meridian. Cf. ISO 19111:2007:2007-07, table 35, attribute prime meridian Greenwich longitude.rdfs:comment : Désigne la longitude par rapport au méridien de Greenwich. Cf. ISO 19111:2007:2007-07, tableau 35, attribut longitude du méridien d'origine.</para>
    ///   <para>rdfs:label : longitude par rapport à Greenwichrdfs:label : greenwich longitude</para>
    ///   <a href="http://data.ign.fr/def/ignf#greenwichLongitude">ignf:greenwichLongitude</a>
    /// </summary>
    let greenwichLongitude = _prefixId.prefix "greenwichLongitude"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the single coordinate reference systems used by a compound coordinate reference system. Cf. ISO 19111:2007:2007-07, table 6, association role componentReferenceSystem.rdfs:comment : Désigne les systèmes de coordonnées de référence simples qui composent un système de coordonnées de référence composé. Cf. ISO 19111:2007:2007-07, tableau 6, rôle d'association componentReferenceSystem.</para>
    ///   <para>rdfs:label : inclut des systèmes de coordonnées de référence simplesrdfs:label : includes some single coordinate reference systems</para>
    ///   <a href="http://data.ign.fr/def/ignf#includesSingleCRS">ignf:includesSingleCRS</a>
    /// </summary>
    let includesSingleCRS = _prefixId.prefix "includesSingleCRS"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the inverse flattening value of an ellipsoid, expressed as a number or a ratio (percentage rate, parts per million, etc.). Cf. ISO 19111:2007:2007-07, table 37, attribute inverse flatteningrdfs:comment : Désigne la valeur d'aplatissement inverse d'un ellipsoïde, exprimée sous la forme d'un nombre ou d'un ratio (pourcentage, parties par million, etc.). Cf. ISO 19111:2007:2007-07, tableau 37, attribut aplatissement inverse.</para>
    ///   <para>rdfs:label : aplatissement inverserdfs:label : inverse flattening</para>
    ///   <a href="http://data.ign.fr/def/ignf#inverseFlattening">ignf:inverseFlattening</a>
    /// </summary>
    let inverseFlattening = _prefixId.prefix "inverseFlattening"
    /// <summary>
    ///   <para>rdfs:comment : Indicates whether the ellipsoid is a sphere. Cf. ISO 19111:2007:2007-07, table 37, attribute ellipsoid=sphere indicator.rdfs:comment : Indique si l'ellipsoïde est une sphère. Cf. ISO 19111:2007:2007-07, tableau 37, attribut indicateur ellipsoïde=sphère.</para>
    ///   <para>rdfs:label : est une sphèrerdfs:label : is sphere</para>
    ///   <a href="http://data.ign.fr/def/ignf#isSphere">ignf:isSphere</a>
    /// </summary>
    let isSphere = _prefixId.prefix "isSphere"
    /// <summary>
    ///   <para>rdfs:comment : The formula used by a method to perform an operation on coordinates. Cf. ISO 19111:2007:2007-07, table 48, attribute coordinate operation method formula reference.rdfs:comment : Indique la formule utilisée par une méthode pour faire opération sur des coordonnées. Cf. ISO 19111:2007:2007-07, tableau 48, attribut référence de formule de la méthode d'opération sur les coordonnées.</para>
    ///   <para>rdfs:label : formule de la méthoderdfs:label : method formula</para>
    ///   <a href="http://data.ign.fr/def/ignf#methodFormula">ignf:methodFormula</a>
    /// </summary>
    let methodFormula = _prefixId.prefix "methodFormula"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the north bound longitude of a bounding box. Cf. ISO 19115-1:2014:2014-04, part 6.6.1 and table B.15.1 line 348.rdfs:comment : Désigne la latitude nord maximale du cadre englobant. Cf. ISO 19115-1:2014:2014-04, partie 6.6.1 et tableau B.15.1 ligne 348.</para>
    ///   <para>rdfs:label : latitude nord maximalerdfs:label : north bound longitude</para>
    ///   <a href="http://data.ign.fr/def/ignf#northBoundLatitude">ignf:northBoundLatitude</a>
    /// </summary>
    let northBoundLatitude = _prefixId.prefix "northBoundLatitude"
    /// <summary>
    ///   <para>rdfs:comment : The version of an operation performed on coordinates. Cf. ISO 19111:2007:2007-07, table 42, attribute coordinate operation version.rdfs:comment : Indique la version d'une opération appliquée sur des coordonnées. Cf. ISO 19111:2007:2007-07, tableau 42, attribut version de l'opération sur les coordonnées.</para>
    ///   <para>rdfs:label : version de l'opérationrdfs:label : operation version</para>
    ///   <a href="http://data.ign.fr/def/ignf#operationVersion">ignf:operationVersion</a>
    /// </summary>
    let operationVersion = _prefixId.prefix "operationVersion"
    /// <summary>
    ///   <para>rdfs:comment : The parameter associated to a given value. Cf. ISO 19111:2007:2007-07, table 55, association role parameter.rdfs:comment : Désigne le paramètre auquel est associée une valeur. Cf. ISO 19111:2007:2007-07, tableau 55, rôle d'association parameter.</para>
    ///   <para>rdfs:label : paramètrerdfs:label : parameter</para>
    ///   <a href="http://data.ign.fr/def/ignf#parameter">ignf:parameter</a>
    /// </summary>
    let parameter = _prefixId.prefix "parameter"
    /// <summary>
    ///   <para>rdfs:comment : The prime meridian used by a geodetic datum. Cf. ISO 19111:2007:2007-07, table 34, association role primeMeridian.rdfs:comment : Désigne le méridien origine d'un référentiel géodésique. Cf. ISO 19111:2007:2007-07, tableau 34, rôle d'association primeMeridian.</para>
    ///   <para>rdfs:label : utilise le méridien originerdfs:label : uses prime meridian</para>
    ///   <a href="http://data.ign.fr/def/ignf#primeMeridian">ignf:primeMeridian</a>
    /// </summary>
    let primeMeridian = _prefixId.prefix "primeMeridian"
    /// <summary>
    ///   <para>rdfs:comment : The scope of the referring object. Cf. ISO 19111:2007:2007-07, tables 4, 33 et 42, attribute scope.rdfs:comment : Désigne la portée de la référence. Cf. ISO 19111:2007:2007-07, tableaux 4, 33 et 42, attribut scope.</para>
    ///   <para>rdfs:label : portéerdfs:label : scope</para>
    ///   <a href="http://data.ign.fr/def/ignf#scope">ignf:scope</a>
    /// </summary>
    let scope = _prefixId.prefix "scope"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the length of the semi major axis of an ellipsoid. Cf. ISO 19111:2007:2007-07, table 36, attribute length of semi-major axis.rdfs:comment : Désigne la longueur du demi grand axe d'un ellipsoïde. Cf. ISO 19111:2007:2007-07, tableau 36, attribut longueur du demi-grand axe.</para>
    ///   <para>rdfs:label : demi grand axerdfs:label : semi major axis</para>
    ///   <a href="http://data.ign.fr/def/ignf#semiMajorAxis">ignf:semiMajorAxis</a>
    /// </summary>
    let semiMajorAxis = _prefixId.prefix "semiMajorAxis"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the length of the semi minor axis of an ellipsoid. Cf. ISO 19111:2007:2007-07, table 37, attribute length of semi-minor axis.rdfs:comment : Désigne la longueur du demi petit axe d'un ellipsoïde. Cf. ISO 19111:2007:2007-07, tableau 37, attribut longueur du demi-petit axe.</para>
    ///   <para>rdfs:label : demi petit axerdfs:label : semi minor axis</para>
    ///   <a href="http://data.ign.fr/def/ignf#semiMinorAxis">ignf:semiMinorAxis</a>
    /// </summary>
    let semiMinorAxis = _prefixId.prefix "semiMinorAxis"
    /// <summary>
    ///   <para>rdfs:comment : The coordinate reference system associated to the data used as input of a given operation. Cf. ISO 19111:2007:2007-07, table 42, named association Source.rdfs:comment : Désigne le système de coordonnées de référence des données en entrée d'une opération. Cf. ISO 19111:2007:2007-07, tableau 42, association nommée Source.</para>
    ///   <para>rdfs:label : système de coordonnées de référence sourcerdfs:label : source coordinate reference system</para>
    ///   <a href="http://data.ign.fr/def/ignf#sourceCRS">ignf:sourceCRS</a>
    /// </summary>
    let sourceCRS = _prefixId.prefix "sourceCRS"
    /// <summary>
    ///   <para>rdfs:comment : The dimension of the coordinate reference system associated with the data used as input of an operation. Cf. ISO 19111:2007:2007-07, table 48, attribute dimension of source CRS.rdfs:comment : Indique la dimension du système de coordonnées de référence des données en entrée d'une opération. Cf. ISO 19111:2007:2007-07, tableau 48, attribut dimension du système de coordonnées de référence source.</para>
    ///   <para>rdfs:label : dimension du système de coordonnées de référence sourcerdfs:label : source coordinate reference system dimension</para>
    ///   <a href="http://data.ign.fr/def/ignf#sourceDimension">ignf:sourceDimension</a>
    /// </summary>
    let sourceDimension = _prefixId.prefix "sourceDimension"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the south bound latitude of a bounding box. Cf. ISO 19115-1:2014:2014-04, part 6.6.1 and table B.15.1 line 347.rdfs:comment : Désigne la latitude sud minimale du cadre englobant. Cf. ISO 19115-1:2014:2014-04, partie 6.6.1 et tableau B.15.1 ligne 347.</para>
    ///   <para>rdfs:label : latitude sud minimalerdfs:label : south bound latitude</para>
    ///   <a href="http://data.ign.fr/def/ignf#southBoundLatitude">ignf:southBoundLatitude</a>
    /// </summary>
    let southBoundLatitude = _prefixId.prefix "southBoundLatitude"
    /// <summary>
    ///   <para>rdfs:comment : The coordinate reference system associated to the data obtained as output of a given operation. Cf. ISO 19111:2007:2007-07, table 42, named association Target.rdfs:comment : Désigne le système de coordonnées de référence des données en sortie d'une opération. Cf. ISO 19111:2007:2007-07, tableau 42, association nommée Target.</para>
    ///   <para>rdfs:label : système de coordonnées de référence ciblerdfs:label : target coordinate reference system</para>
    ///   <a href="http://data.ign.fr/def/ignf#targetCRS">ignf:targetCRS</a>
    /// </summary>
    let targetCRS = _prefixId.prefix "targetCRS"
    /// <summary>
    ///   <para>rdfs:comment : The dimension of the coordinate reference system associated with the data obtained as output of an operation. Cf. ISO 19111:2007:2007-07, table 48, attribute dimension of target CRS.rdfs:comment : Indique la dimension du système de coordonnées de référence des données en sortie d'une opération. Cf. ISO 19111:2007:2007-07, tableau 48, attribut dimension du système de coordonnées de référence cible.</para>
    ///   <para>rdfs:label : dimension du système de coordonnées de référence ciblerdfs:label : target coordinate reference system dimension</para>
    ///   <a href="http://data.ign.fr/def/ignf#targetDimension">ignf:targetDimension</a>
    /// </summary>
    let targetDimension = _prefixId.prefix "targetDimension"
    /// <summary>
    ///   <para>rdfs:comment : The method used by an operation on coordinates. Cf. ISO 19111:2007:2007-07, table 43, association role method.rdfs:comment : Désigne la méthode utilisée par une opération sur des coordonnées. Cf. ISO 19111:2007:2007-07, tableau 43, rôle d'association method.</para>
    ///   <para>rdfs:label : utilise la méthoderdfs:label : uses method</para>
    ///   <a href="http://data.ign.fr/def/ignf#usesMethod">ignf:usesMethod</a>
    /// </summary>
    let usesMethod = _prefixId.prefix "usesMethod"
    /// <summary>
    ///   <para>rdfs:comment : A parameter used by a method to perform an operation on coordinates. Cf. ISO 19111:2007:2007-07, table 48, association role parameter.rdfs:comment : Désigne un paramètre utilisé par une méthode pour faire une opération sur des coordonnées. Cf. ISO 19111:2007:2007-07, tableau 48, rôle d'association parameter.</para>
    ///   <para>rdfs:label : utilise le paramètrerdfs:label : uses parameter</para>
    ///   <a href="http://data.ign.fr/def/ignf#usesParameter">ignf:usesParameter</a>
    /// </summary>
    let usesParameter = _prefixId.prefix "usesParameter"
    /// <summary>
    ///   <para>rdfs:comment : A value used by an operation on coordinates. Cf. ISO 19111:2007:2007-07, table 43, association role parameterValue.rdfs:comment : Désigne une valeur utilisée par une opération sur des coordonnées. Cf. ISO 19111:2007:2007-07, tableau 43, rôle d'association parameterValue.</para>
    ///   <para>rdfs:label : utilise la valeurrdfs:label : uses value</para>
    ///   <a href="http://data.ign.fr/def/ignf#usesValue">ignf:usesValue</a>
    /// </summary>
    let usesValue = _prefixId.prefix "usesValue"
    /// <summary>
    ///   <para>rdfs:comment : The vertical coordinate system used by a vertical coordinate reference system. Cf. ISO 19111:2007:2007-07, table 14, named association CoordinateSystem.rdfs:comment : Désigne le système de coordonnées vertical utilisé par un système de coordonnées de référence vertical. Cf. ISO 19111:2007:2007-07, tableau 14, association nommée CoordinateSystem.</para>
    ///   <para>rdfs:label : utilise le système vertical de coordonnéesrdfs:label : uses vertical coordinate system</para>
    ///   <a href="http://data.ign.fr/def/ignf#verticalCS">ignf:verticalCS</a>
    /// </summary>
    let verticalCS = _prefixId.prefix "verticalCS"
    /// <summary>
    ///   <para>rdfs:comment : The vertical datum used by a vertical coordinate reference system. Cf. ISO 19111:2007:2007-07, table 14, named association DefiningDatum.rdfs:comment : Désigne le référentiel vertical utilisé par un système de coordonnées de référence vertical. Cf. ISO 19111:2007:2007-07, tableau 14, association nommée DefiningDatum.</para>
    ///   <para>rdfs:label : utilise le référentiel verticalrdfs:label : uses vertical datum</para>
    ///   <a href="http://data.ign.fr/def/ignf#verticalDatum">ignf:verticalDatum</a>
    /// </summary>
    let verticalDatum = _prefixId.prefix "verticalDatum"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the west bound longitude of a bounding box. Cf. ISO 19115-1:2014:2014-04, part 6.6.1 and table B.15.1 line 345.rdfs:comment : Désigne la longitude ouest minimale du cadre englobant. Cf. ISO 19115-1:2014:2014-04, partie 6.6.1 et tableau B.15.1 ligne 345.</para>
    ///   <para>rdfs:label : longitude ouest minimalerdfs:label : west bound longitude</para>
    ///   <a href="http://data.ign.fr/def/ignf#westBoundLongitude">ignf:westBoundLongitude</a>
    /// </summary>
    let westBoundLongitude = _prefixId.prefix "westBoundLongitude"

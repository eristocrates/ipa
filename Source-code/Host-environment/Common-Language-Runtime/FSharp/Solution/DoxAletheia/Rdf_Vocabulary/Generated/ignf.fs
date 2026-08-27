namespace http.data.ign.fr.def.ignf.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ignf =
    let _namespace_iri = Namespace_Iri ignf |> NamespaceIRI
    /// <summary>
    ///   <para>ignf:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#">http://data.ign.fr/def/ignf#</seealso>
    let _prefix_iri = Prefixed_Name(ignf, "") |> PrefixedName
    /// <summary>
    ///   <para>ignf:AxesList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Liste ordonnée d'axes de systèmes de coordonnées."</para>
    ///   <para>"Ordered list of coordinates system axes."</para>
    /// labels<para>"List of axes"</para><para>"Liste d'axes"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#AxesList">http://data.ign.fr/def/ignf#AxesList</seealso>
    let AxesList = Prefixed_Name(ignf, "AxesList") |> PrefixedName
    /// <summary>
    ///   <para>ignf:CRS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Métadonnées permettant de préciser, selon la dimension spatiale des coordonnées 1D, 2D ou 3D, les éléments de définition associés au jeu de coordonnées: le système de référence terrestre, l'ellipsoïde géodésique, le méridien origine, le type de coordonnées (cartésiennes géocentriques, planes, géographiques,...), les unités dans lesquelles sont exprimées les coordonnées, la projection cartographique, le référentiel altimétrique(http://geodesie.ign.fr/index.php?page=glossaire). Cf. ISO 19111:2007:2007-07, partie 8.2, tableau 4 et annexe B.1."</para>
    ///   <para>"Depending on the spatial dimension of coordinates (1D, 2D, 3D), this piece of metadata is used for specifying the elements of definition associated to a given set of coordinates: its datum, its ellipsoid, its prime meridian, the type of coordinates (geocentric, geographic, projected,...), the coordinates units of measure, when appropriate the cartographic projection used, the vertical coordinate reference system. Definition translated from: http://geodesie.ign.fr/index.php?page=glossaire. Cf. ISO 19111:2007:2007-07, part 8.2, table 4 and annex B.1."</para>
    /// labels<para>"Système de coordonnées de référence"</para><para>"Coordinate reference system (CRS)"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#CRS">http://data.ign.fr/def/ignf#CRS</seealso>
    let CRS = Prefixed_Name(ignf, "CRS") |> PrefixedName
    /// <summary>
    ///   <para>ignf:CartesianCS</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Coordinate system which gives the position of points relative to n mutually perpendicular axes. Cf. ISO 19111:2007:2007-07, tables 15 and 18."</para>
    ///   <para>"Système de coordonnées donnant la position des points relativement à n axes perpendiculaires deux à deux. Cf. ISO 19111:2007:2007-07, tableaux 15 et 18."</para>
    /// labels<para>"Système cartésien de coordonnées"</para><para>"Cartesian coordinate system"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#CartesianCS">http://data.ign.fr/def/ignf#CartesianCS</seealso>
    let CartesianCS = Prefixed_Name(ignf, "CartesianCS") |> PrefixedName
    /// <summary>
    ///   <para>ignf:CompoundCRS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Coordinate reference system using at least two independent single coordinate reference systems. Cf. ISO 19111:2007:2007-07, parts 8.2.3.c, 8.2.4, table 6 and annex B.1.2.4."</para>
    ///   <para>"Système de coordonnées de référence utilisant au moins deux systèmes de coordonnées de référence simples indépendants. Cf. ISO 19111:2007:2007-07, parties 8.2.3.c, 8.2.4, tableau 6 et annexe B.1.2.4."</para>
    /// labels<para>"Système de coordonnées de référence combiné"</para><para>"Compound coordinate reference system"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#CompoundCRS">http://data.ign.fr/def/ignf#CompoundCRS</seealso>
    let CompoundCRS = Prefixed_Name(ignf, "CompoundCRS") |> PrefixedName
    /// <summary>
    ///   <para>ignf:Conversion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Opération sur les coordonnées dans laquelle les deux systèmes de coordonnées de référence sont basés sur le même référentiel (ex: projection cartographique). Cf. ISO 19111:2007:2007-07, tableau 45 et annexe B.4.2."</para>
    ///   <para>"Coordinate operation in which both coordinate reference systems are based on the same datum. Cf. ISO 19111:2007:2007-07, table 45 and annex B.4.2."</para>
    /// labels<para>"Conversion"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#Conversion">http://data.ign.fr/def/ignf#Conversion</seealso>
    let Conversion = Prefixed_Name(ignf, "Conversion") |> PrefixedName
    /// <summary>
    ///   <para>ignf:CoordinateOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Opération mathématique sur des coordonnées, basée sur une relation 1:1, qui change ces coordonnées d'une système de coordonnées de référence à un autre. Cf. ISO 19111:2007:2007-07, partie 11.1, tableau 42 et annexe B.4."</para>
    ///   <para>"Mathematical operation on coordinates, based on one-to-one relationship, that changes coordinates from one coordinate reference system to another. Cf. ISO 19111:2007:2007-07, part 11.1, table 42 and annex B.4."</para>
    /// labels<para>"Opération sur les coordonnées"</para><para>"Coordinate operation"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#CoordinateOperation">http://data.ign.fr/def/ignf#CoordinateOperation</seealso>
    let CoordinateOperation = Prefixed_Name(ignf, "CoordinateOperation") |> PrefixedName
    /// <summary>
    ///   <para>ignf:CoordinateSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Ensemble d'axes couvrant un espace de coordonnées, et de règles mathématiques permettant l'affectation de coordonnées à un point. Cf. ISO 19111:2007:2007-07, partie 9.2, tableau 17 et annexe B.2."</para>
    ///   <para>"Set of axes that spans a given coordinate space and of mathematical rules for specifying how coordinates are to be assigned to points. Cf. ISO 19111:2007:2007-07, part 9.2, table 17 and annex B.2."</para>
    /// labels<para>"Système de coordonnées"</para><para>"Coordinate system"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#CoordinateSystem">http://data.ign.fr/def/ignf#CoordinateSystem</seealso>
    let CoordinateSystem = Prefixed_Name(ignf, "CoordinateSystem") |> PrefixedName

    /// <summary>
    ///   <para>ignf:CoordinateSystemAxis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Axe par rapport auquel une coordonnée d'un point est spécifiée dans un système de coordonnées. Cf. ISO 19111:2007:2007-07, partie 9.3, tableau 27 et annexe B.2.2."</para>
    ///   <para>"Axis composing a coordinate system and used to specify one given coordinate in a coordinate tuple describing the position of a point. Cf. ISO 19111:2007:2007-07, part 9.3, table 27 and annex B.2.2."</para>
    /// labels<para>"Axe"</para><para>"Axis"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#CoordinateSystemAxis">http://data.ign.fr/def/ignf#CoordinateSystemAxis</seealso>
    let CoordinateSystemAxis =
        Prefixed_Name(ignf, "CoordinateSystemAxis") |> PrefixedName

    /// <summary>
    ///   <para>ignf:CoordinatesSystem</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#CoordinatesSystem">http://data.ign.fr/def/ignf#CoordinatesSystem</seealso>
    let CoordinatesSystem = Prefixed_Name(ignf, "CoordinatesSystem") |> PrefixedName
    /// <summary>
    ///   <para>ignf:Datum</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Paramètre ou ensemble de paramètres définissant la position de l'origine, l'échelle et l'orientation d'un système de coordonnées. Cf. ISO 19111:2007:2007-07, partie 10.1, tableau 33 et annexe B.3."</para>
    ///   <para>"Parameter or set of parameters that define the position of the origin, the scale and the orientation of a coordinate system. Cf. ISO 19111:2007:2007-07, part 10.1, table 33 and annex B.3."</para>
    /// labels<para>"Datum"</para><para>"Référentiel"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#Datum">http://data.ign.fr/def/ignf#Datum</seealso>
    let Datum = Prefixed_Name(ignf, "Datum") |> PrefixedName
    /// <summary>
    ///   <para>ignf:Ellipsoid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Surface formed by the rotation of an ellipse about its minor axis, defined by a semi-major axis and a flattening parameter and fairly geocentric. NB : It is a mathematical model of the geoid, i.e. the Earth without its relief. Many geodetic ellipsoids exist. Cf. ISO 19111:2007:2007-07, part 10.2.2, table 36 and annex B.3.2.3."</para>
    ///   <para>"Surface de révolution engendrée par une ellipse tournant autour de son petit axe, définie par le rayon équatorial et un paramètre d'aplatissement, et sensiblement géocentrique. Note : Il s'agit d'un modèle mathématique du géoïde, c'est-à-dire de la Terre débarrassée de son relief. Il existe de nombreux ellipsoïdes géodésiques. Cf. ISO 19111:2007:2007-07, partie 10.2.2, tableau 36 et annexe B.3.2.3."</para>
    /// labels<para>"Ellipsoid"</para><para>"Ellipsoïde"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#Ellipsoid">http://data.ign.fr/def/ignf#Ellipsoid</seealso>
    let Ellipsoid = Prefixed_Name(ignf, "Ellipsoid") |> PrefixedName
    /// <summary>
    ///   <para>ignf:EllipsoidalCS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Système de coordonnées dans lequel la position est spécifiée par la latitude géodésique, la longitude géodésique et (dans le cas tridimensionnel) la hauteur ellipsoïdale. Cf. ISO 19111:2007:2007-07, tableaux 15 et 20."</para>
    ///   <para>"Coordinate system which gives the position is specified by geodetic latitude, geodetic longitude and (in the three-dimensional case) ellipsoidal height. Cf. ISO 19111:2007:2007-07, tables 15 and 20."</para>
    /// labels<para>"Système de coordonnées ellipsoïdal"</para><para>"Ellipsoidal coordinate system"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#EllipsoidalCS">http://data.ign.fr/def/ignf#EllipsoidalCS</seealso>
    let EllipsoidalCS = Prefixed_Name(ignf, "EllipsoidalCS") |> PrefixedName
    /// <summary>
    ///   <para>ignf:Extent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Zone géographique ou intervalle de temps dans lequel la référence est valide. Cf. ISO 19115-1:2014:2014-04, partie 6.6.1 et tableau B.15 ligne 335."</para>
    ///   <para>"Geographic area or time interval in which the referring object is valid. Cf. ISO 19115-1:2014:2014-04, part 6.6.1 and table B.15 line 335."</para>
    /// labels<para>"Étendue"</para><para>"Extent"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#Extent">http://data.ign.fr/def/ignf#Extent</seealso>
    let Extent = Prefixed_Name(ignf, "Extent") |> PrefixedName
    /// <summary>
    ///   <para>ignf:GeodeticCRS</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Coordinate reference system associated with a geodetic datum. Cf. ISO 19111:2007:2007-07, part 8.2.2.a, table 10 and annex B.1.2.1.a."</para>
    ///   <para>"Système de coordonnées de référence associé à un référentiel géodésique. Cf. ISO 19111:2007:2007-07, partie 8.2.2.a, tableau 10 et annexe B.1.2.1.a."</para>
    /// labels<para>"Geodetic coordinate reference system"</para><para>"Système de coordonnées de référence geodésique"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#GeodeticCRS">http://data.ign.fr/def/ignf#GeodeticCRS</seealso>
    let GeodeticCRS = Prefixed_Name(ignf, "GeodeticCRS") |> PrefixedName
    /// <summary>
    ///   <para>ignf:GeodeticDatum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Datum describing the relation of a two- or three-dimensional coordinate system to the Earth. Cf. ISO 19111:2007:2007-07, part 10.2, table 34 and annex B.3.2."</para>
    ///   <para>"Référentiel décrivant la relation entre un système de coordonnées à deux ou trois dimensions et la Terre. Cf. ISO 19111:2007:2007-07, partie 10.2, tableau 34 et annexe B.3.2."</para>
    /// labels<para>"Geodetic datum"</para><para>"Référentiel géodésique"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#GeodeticDatum">http://data.ign.fr/def/ignf#GeodeticDatum</seealso>
    let GeodeticDatum = Prefixed_Name(ignf, "GeodeticDatum") |> PrefixedName

    /// <summary>
    ///   <para>ignf:GeographicBoundingBox</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Box bounding an area of interest. Cf. ISO 19115-1:2014:2014-04, part 6.6.1 and table B.15.1 line 344."</para>
    ///   <para>"Cadre délimitant une zone d'intérêt. Cf. ISO 19115-1:2014:2014-04, partie 6.6.1 et tableau B.15.1 ligne 344."</para>
    /// labels<para>"Cadre englobant géographique"</para><para>"Geographic bounding box"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#GeographicBoundingBox">http://data.ign.fr/def/ignf#GeographicBoundingBox</seealso>
    let GeographicBoundingBox =
        Prefixed_Name(ignf, "GeographicBoundingBox") |> PrefixedName

    /// <summary>
    ///   <para>ignf:OperationMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Méthode utilisée pour faire une opération sur des coordonnées. Cf. ISO 19111:2007:2007-07, tableau 48 et annexe B.4.5."</para>
    ///   <para>"The method (algorithm or procedure) used to perform the coordinate operation. Cf. ISO 19111:2007:2007-07, table 48 and annex B.4.5."</para>
    /// labels<para>"Méthode"</para><para>"Operation method"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#OperationMethod">http://data.ign.fr/def/ignf#OperationMethod</seealso>
    let OperationMethod = Prefixed_Name(ignf, "OperationMethod") |> PrefixedName
    /// <summary>
    ///   <para>ignf:OperationParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Parameter used by a method to perform some coordinate operation. Cf. ISO 19111:2007:2007-07, table 52 and annex B.4.5."</para>
    ///   <para>"Paramètre utilisé par une méthode pour faire une opération sur des coordonnées. Cf. ISO 19111:2007:2007-07, tableau 52 et annexe B.4.5."</para>
    /// labels<para>"Paramètre"</para><para>"Operation parameter"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#OperationParameter">http://data.ign.fr/def/ignf#OperationParameter</seealso>
    let OperationParameter = Prefixed_Name(ignf, "OperationParameter") |> PrefixedName

    /// <summary>
    ///   <para>ignf:OperationParameterValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Valeur d'un paramètre utilisé par une méthode pour faire une opération sur des coordonnées. Cf. ISO 19111:2007:2007-07, tableau 55."</para>
    ///   <para>"Value of a parameter used by a method to perform some coordinate operation. Cf. ISO 19111:2007:2007-07, table 55."</para>
    /// labels<para>"Valeur de paramètre"</para><para>"Operation parameter value"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#OperationParameterValue">http://data.ign.fr/def/ignf#OperationParameterValue</seealso>
    let OperationParameterValue =
        Prefixed_Name(ignf, "OperationParameterValue") |> PrefixedName

    /// <summary>
    ///   <para>ignf:PrimeMeridian</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Meridian from which the longitudes of other meridians are quantified. Cf. ISO 19111:2007:2007-07, part 10.2.1, table 35 and annex B.3.2.2."</para>
    ///   <para>"Méridien à partir duquel les longitudes d'autres méridiens sont mesurées. Cf. ISO 19111:2007:2007-07, partie 10.2.1, tableau 35 et annexe B.3.2.2."</para>
    /// labels<para>"Méridien origine"</para><para>"Prime meridian"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#PrimeMeridian">http://data.ign.fr/def/ignf#PrimeMeridian</seealso>
    let PrimeMeridian = Prefixed_Name(ignf, "PrimeMeridian") |> PrefixedName
    /// <summary>
    ///   <para>ignf:ProjectedCRS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Coordinate reference system derived from a two-dimensional geodetic coordinate reference system by applying a map projection. Cf. ISO 19111:2007:2007-07, part 8.2.3.b, table 11 and annex B.1.2.3."</para>
    ///   <para>"Système de coordonnées de référence dérivé par projection cartographique d'un système de coordonnées de référence bidimentionnel. Cf. ISO 19111:2007:2007-07, partie 8.2.3.b, tableau 11 et annexe B.1.2.3."</para>
    /// labels<para>"Projected coordinate reference system"</para><para>"Système de coordonnées de référence projeté"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#ProjectedCRS">http://data.ign.fr/def/ignf#ProjectedCRS</seealso>
    let ProjectedCRS = Prefixed_Name(ignf, "ProjectedCRS") |> PrefixedName
    /// <summary>
    ///   <para>ignf:SingleCRS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Système de coordonnées de référence composé d'un système de coordonnées et d'un référentiel. Cf. ISO 19111:2007:2007-07 tableau 5."</para>
    ///   <para>"Coordinate reference system consisting of one coordinate system and one datum. Cf. ISO 19111:2007:2007-07, table 5."</para>
    /// labels<para>"Single coordinate reference system"</para><para>"Système de coordonnées de référence simple"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#SingleCRS">http://data.ign.fr/def/ignf#SingleCRS</seealso>
    let SingleCRS = Prefixed_Name(ignf, "SingleCRS") |> PrefixedName
    /// <summary>
    ///   <para>ignf:SingleCRSList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Liste ordonnée de systèmes de coordonnées de référence simples."</para>
    ///   <para>"Ordered list of single coordinate reference systems."</para>
    /// labels<para>"List of single coordinate reference systems"</para><para>"Liste de systèmes de coordonnées de référence simples"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#SingleCRSList">http://data.ign.fr/def/ignf#SingleCRSList</seealso>
    let SingleCRSList = Prefixed_Name(ignf, "SingleCRSList") |> PrefixedName
    /// <summary>
    ///   <para>ignf:SingleOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Opération non concaténée sur des coordonnées. Cf. ISO 19111:2007:2007-07, tableau 43."</para>
    ///   <para>"A non concatenated coordinate operation. Cf. ISO 19111:2007:2007-07, table 43."</para>
    /// labels<para>"Single coordinate operation"</para><para>"Opération simple sur les coordonnées"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#SingleOperation">http://data.ign.fr/def/ignf#SingleOperation</seealso>
    let SingleOperation = Prefixed_Name(ignf, "SingleOperation") |> PrefixedName
    /// <summary>
    ///   <para>ignf:Transformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Coordinate operation in which the two coordinate reference systems are based on different datums. Cf. ISO 19111:2007:2007-07, table 44."</para>
    ///   <para>"Opération sur les coordonnées dans laquelle les deux systèmes de coordonnées de référence sont basés sur des référentiels distincts. Cf. ISO 19111:2007:2007-07, tableau 44."</para>
    /// labels<para>"Transformation"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#Transformation">http://data.ign.fr/def/ignf#Transformation</seealso>
    let Transformation = Prefixed_Name(ignf, "Transformation") |> PrefixedName
    /// <summary>
    ///   <para>ignf:VerticalCRS</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Système de coordonnées de référence à une dimension, associé à un référentiel vertical, et utilisé pour enregistrer des hauteurs ou des profondeurs. Les hauteurs ellipsoïdales ne sont pas enregistrées à l'aide d'un système de coordonnées de référence vertical, mais au sein d'un tuple de coordonnées 3D défini dans un système de coordonnées de référence géodésique 3D. Cf. ISO 19111:2007:2007-07, parties 8.2.2.b, tableau 14 et annexe B.1.2.1.b."</para>
    ///   <para>"One-dimensional coordinate reference system associated with a vertical datum and used for recording heights or depths.Ellipsoidal heights are not captured in a vertical coordinate reference system but as part of a 3D coordinates tuple defined in a geodetic 3D coordinate reference system. Cf. ISO 19111:2007:2007-07, parts 8.2.2.b, table 14 and annex B.1.2.1.b."</para>
    /// labels<para>"Vertical coordinate reference system"</para><para>"Système de coordonnées de référence vertical"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#VerticalCRS">http://data.ign.fr/def/ignf#VerticalCRS</seealso>
    let VerticalCRS = Prefixed_Name(ignf, "VerticalCRS") |> PrefixedName
    /// <summary>
    ///   <para>ignf:VerticalCS</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Système de coordonnées à une dimension utilisé pour les mesures de hauteur ou de profondeur relatives à la gravité. Cf. ISO 19111:2007:2007-07, tableaux 15 et 25."</para>
    ///   <para>"One-dimensional coordinate system used for gravity related height or depth measurements. Cf. ISO 19111:2007:2007-07, tables 15 and 25."</para>
    /// labels<para>"Vertical coordinate system"</para><para>"Système de coordonnées vertical"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#VerticalCS">http://data.ign.fr/def/ignf#VerticalCS</seealso>
    let VerticalCS = Prefixed_Name(ignf, "VerticalCS") |> PrefixedName
    /// <summary>
    ///   <para>ignf:VerticalDatum</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Datum describing the relation of gravity-related heights or depths to the Earth. Cf. ISO 19111:2007:2007-07, table 41 and annex B.3.3."</para>
    ///   <para>"Référentiel décrivant la relation entre les hauteurs ou les profondeurs relatives à la gravité et la Terre. Cf. ISO 19111:2007:2007-07, tableau 41 et annexe B.3.3."</para>
    /// labels<para>"Vertical datum"</para><para>"Référentiel vertical"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#VerticalDatum">http://data.ign.fr/def/ignf#VerticalDatum</seealso>
    let VerticalDatum = Prefixed_Name(ignf, "VerticalDatum") |> PrefixedName
    /// <summary>
    ///   <para>ignf:axis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Désigne un axe utilisé par un système de coordonnées ellipsoïdal ou cartésien. Cf. ISO 19111:2007:2007-07, tableau 17, rôle d'association axis."</para>
    ///   <para>"An axis used by some ellipsoidal or cartesian coordinate system. Cf. ISO 19111:2007:2007-07, table 17, association role axis."</para>
    /// labels<para>"utilise l'axe"</para><para>"uses axis"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#axis">http://data.ign.fr/def/ignf#axis</seealso>
    let axis = Prefixed_Name(ignf, "axis") |> PrefixedName
    /// <summary>
    ///   <para>ignf:axisAbbrev</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Désigne l'abréviation utilisée pour désigner l'axe. Cf. ISO 19111:2007:2007-07, tableau 27, attribut abréviation de l'axe du système de coordonnées."</para>
    ///   <para>"The abbreviation used to identify an axis. Cf. ISO 19111:2007:2007-07, table 27, attribute coordinate system axis abbreviation."</para>
    /// labels<para>"abréviation utilisée pour désigner l'axe"</para><para>"axis abbreviation"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#axisAbbrev">http://data.ign.fr/def/ignf#axisAbbrev</seealso>
    let axisAbbrev = Prefixed_Name(ignf, "axisAbbrev") |> PrefixedName
    /// <summary>
    ///   <para>ignf:axisDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The direction of an axis. Cf. ISO 19111:2007:2007-07, table 27, attribute coordinate system axis direction."</para>
    ///   <para>"Désigne la direction de l'axe. Cf. ISO 19111:2007:2007-07, tableau 27, attribut direction de l'axe du système de coordonnées."</para>
    /// labels<para>"direction de l'axe"</para><para>"axis direction"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#axisDirection">http://data.ign.fr/def/ignf#axisDirection</seealso>
    let axisDirection = Prefixed_Name(ignf, "axisDirection") |> PrefixedName
    /// <summary>
    ///   <para>ignf:baseCRS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Désigne le système de coordonnées de référence géodésique sur lequel repose un système de coordonnées de référence projeté. Cf. ISO 19111:2007:2007-07, tableau 11, rôle d'association baseCRS."</para>
    ///   <para>"The geodetic coordinate reference system on which a projected coordinate reference system is based. Cf. ISO 19111:2007:2007-07, table 11, association role baseCRS."</para>
    /// labels<para>"système de coordonnées de référence de base"</para><para>"base coordinate reference system"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#baseCRS">http://data.ign.fr/def/ignf#baseCRS</seealso>
    let baseCRS = Prefixed_Name(ignf, "baseCRS") |> PrefixedName
    /// <summary>
    ///   <para>ignf:cartesianCS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The cartesian coordinate system used by some geodetic or projected coordinate reference system. Cf. ISO 19111:2007:2007-07, tables 10 et 11, association roles coordinateSystem."</para>
    ///   <para>"Désigne le système de coordonnées cartésien utilisé par un système de coordonnées de référence géodésique ou projeté. Cf. ISO 19111:2007:2007-07, tableaux 10 et 11, association nommée CoordinateSystem."</para>
    /// labels<para>"utilise le système de coordonnées cartesien"</para><para>"uses cartesian coordinate system"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#cartesianCS">http://data.ign.fr/def/ignf#cartesianCS</seealso>
    let cartesianCS = Prefixed_Name(ignf, "cartesianCS") |> PrefixedName
    /// <summary>
    ///   <para>ignf:codeSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Désigne la règle ou l'autorité dont résulte la valeur de la référence."</para>
    ///   <para>"Rule or authority for a code, name, term or category."</para>
    /// labels<para>"espace de codage"</para><para>"code space"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#codeSpace">http://data.ign.fr/def/ignf#codeSpace</seealso>
    let codeSpace = Prefixed_Name(ignf, "codeSpace") |> PrefixedName
    /// <summary>
    ///   <para>ignf:conversion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The conversion used to define a projected coordinate reference system. Cf. ISO 19111:2007:2007-07, table 7, named association Definition."</para>
    ///   <para>"Désigne la conversion utilisée pour définir un système de coordonnées de référence projeté. Cf. ISO 19111:2007:2007-07, tableau 7, association nommée Definition."</para>
    /// labels<para>"defined by conversion"</para><para>"défini par conversion"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#conversion">http://data.ign.fr/def/ignf#conversion</seealso>
    let conversion = Prefixed_Name(ignf, "conversion") |> PrefixedName
    /// <summary>
    ///   <para>ignf:coordinateSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Désigne le système de coordonnées utilisé par un système de coordonnées de référence. Cf. ISO 19111:2007:2007-07, tableau 5, association nommée CoordinateSystem."</para>
    ///   <para>"The coordinate system used by a coordinate reference system. Cf. ISO 19111:2007:2007-07, table 5, named association CoordinateSystem."</para>
    /// labels<para>"utilise le système de coordonnées"</para><para>"uses coordinate system"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#coordinateSystem">http://data.ign.fr/def/ignf#coordinateSystem</seealso>
    let coordinateSystem = Prefixed_Name(ignf, "coordinateSystem") |> PrefixedName
    /// <summary>
    ///   <para>ignf:datum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Désigne le référentiel utilisé par un système de coordonnées de référence simple. Cf. ISO 19111:2007:2007-07, tableau 5, association nommée DefiningDatum."</para>
    ///   <para>"The datum used by a single coordinate reference system. Cf. ISO 19111:2007:2007-07, table 5, named association DefiningDatum."</para>
    /// labels<para>"uses datum"</para><para>"utilise le référentiel"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#datum">http://data.ign.fr/def/ignf#datum</seealso>
    let datum = Prefixed_Name(ignf, "datum") |> PrefixedName
    /// <summary>
    ///   <para>ignf:domainOfValidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Zone ou intervalle de temps dans lequel l'objet de référence est valide. Cf. ISO 19111:2007:2007-07, tableaux 4, 33 et 42, attribut domainOfValidity."</para>
    ///   <para>"Geographic area or time interval in which the referring object is valid. Cf. ISO 19111:2007:2007-07, tables 4, 33 and 42, attribute domainOfValidity."</para>
    /// labels<para>"domaine de validité"</para><para>"domain of validity"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#domainOfValidity">http://data.ign.fr/def/ignf#domainOfValidity</seealso>
    let domainOfValidity = Prefixed_Name(ignf, "domainOfValidity") |> PrefixedName
    /// <summary>
    ///   <para>ignf:eastBoundLongitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates the east bound longitude of a bounding box. Cf. ISO 19115-1:2014:2014-04, part 6.6.1 and table B.15.1 line 346."</para>
    ///   <para>"Désigne la longitude est maximale du cadre englobant. Cf. ISO 19115-1:2014:2014-04, partie 6.6.1 et tableau B.15.1 ligne 346."</para>
    /// labels<para>"east bound longitude"</para><para>"longitude est maximale"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#eastBoundLongitude">http://data.ign.fr/def/ignf#eastBoundLongitude</seealso>
    let eastBoundLongitude = Prefixed_Name(ignf, "eastBoundLongitude") |> PrefixedName
    /// <summary>
    ///   <para>ignf:ellipsoid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The ellipsoid used by a geodetic datum. Cf. ISO 19111:2007:2007-07, table 34, association role ellipsoid."</para>
    ///   <para>"Désigne l'ellipsoïde utilisé par un référentiel géodésique. Cf. ISO 19111:2007:2007-07, tableau 34, rôle d'association ellipsoid."</para>
    /// labels<para>"uses ellipsoid"</para><para>"utilise l'ellipsoïde"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#ellipsoid">http://data.ign.fr/def/ignf#ellipsoid</seealso>
    let ellipsoid = Prefixed_Name(ignf, "ellipsoid") |> PrefixedName
    /// <summary>
    ///   <para>ignf:ellipsoidalCS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The ellipsoidal coordinate system used by a geodetic coordinate reference system. Cf. ISO 19111:2007:2007-07, table 10, named association CoordinateSystem."</para>
    ///   <para>"Désigne le système de coordonnées ellipsoïdal utilisé par un système de coordonnées de référence géodésique. Cf. ISO 19111:2007:2007-07, tableau 10, association nommée CoordinateSystem."</para>
    /// labels<para>"utilise le système de coordonnées ellipsoïdal"</para><para>"uses ellipsoidal coordinate system"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#ellipsoidalCS">http://data.ign.fr/def/ignf#ellipsoidalCS</seealso>
    let ellipsoidalCS = Prefixed_Name(ignf, "ellipsoidalCS") |> PrefixedName
    /// <summary>
    ///   <para>ignf:epsgID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indique l'identifiant EPSG de la ressource."</para>
    ///   <para>"The EPSG identifier of the resource."</para>
    /// labels<para>"identifiant epsg"</para><para>"espg identifier"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#epsgID">http://data.ign.fr/def/ignf#epsgID</seealso>
    let epsgID = Prefixed_Name(ignf, "epsgID") |> PrefixedName
    /// <summary>
    ///   <para>ignf:geodeticDatum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Désigne le référentiel géodésique utilisé par un système de coordonnées de référence géodésique. Cf. ISO 19111:2007:2007-07, tableau 10, association nommée DefiningDatum."</para>
    ///   <para>"The geodetic datum used by a geodetic coordinate reference system. Cf. ISO 19111:2007:2007-07, table 10, named association DefiningDatum."</para>
    /// labels<para>"utilise le référentiel géodésique"</para><para>"uses geodetic datum"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#geodeticDatum">http://data.ign.fr/def/ignf#geodeticDatum</seealso>
    let geodeticDatum = Prefixed_Name(ignf, "geodeticDatum") |> PrefixedName
    /// <summary>
    ///   <para>ignf:geographicElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Désigne le cadre englobant géographique d'une région de validité. Cf. ISO 19115-1:2014:2014-04, partie 6.6.1 et tableau B.15 ligne 337."</para>
    ///   <para>"The geographic bounding box used for defining a domain of validity. Cf. ISO 19115-1:2014:2014-04, part 6.6.1 and table B.15 line 337."</para>
    /// labels<para>"élément géographique"</para><para>"geographic element"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#geographicElement">http://data.ign.fr/def/ignf#geographicElement</seealso>
    let geographicElement = Prefixed_Name(ignf, "geographicElement") |> PrefixedName
    /// <summary>
    ///   <para>ignf:greenwichLongitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Désigne la longitude par rapport au méridien de Greenwich. Cf. ISO 19111:2007:2007-07, tableau 35, attribut longitude du méridien d'origine."</para>
    ///   <para>"Indicates the longitude from Greenwich meridian. Cf. ISO 19111:2007:2007-07, table 35, attribute prime meridian Greenwich longitude."</para>
    /// labels<para>"longitude par rapport à Greenwich"</para><para>"greenwich longitude"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#greenwichLongitude">http://data.ign.fr/def/ignf#greenwichLongitude</seealso>
    let greenwichLongitude = Prefixed_Name(ignf, "greenwichLongitude") |> PrefixedName
    /// <summary>
    ///   <para>ignf:includesSingleCRS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Désigne les systèmes de coordonnées de référence simples qui composent un système de coordonnées de référence composé. Cf. ISO 19111:2007:2007-07, tableau 6, rôle d'association componentReferenceSystem."</para>
    ///   <para>"Indicates the single coordinate reference systems used by a compound coordinate reference system. Cf. ISO 19111:2007:2007-07, table 6, association role componentReferenceSystem."</para>
    /// labels<para>"inclut des systèmes de coordonnées de référence simples"</para><para>"includes some single coordinate reference systems"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#includesSingleCRS">http://data.ign.fr/def/ignf#includesSingleCRS</seealso>
    let includesSingleCRS = Prefixed_Name(ignf, "includesSingleCRS") |> PrefixedName
    /// <summary>
    ///   <para>ignf:inverseFlattening</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates the inverse flattening value of an ellipsoid, expressed as a number or a ratio (percentage rate, parts per million, etc.). Cf. ISO 19111:2007:2007-07, table 37, attribute inverse flattening"</para>
    ///   <para>"Désigne la valeur d'aplatissement inverse d'un ellipsoïde, exprimée sous la forme d'un nombre ou d'un ratio (pourcentage, parties par million, etc.). Cf. ISO 19111:2007:2007-07, tableau 37, attribut aplatissement inverse."</para>
    /// labels<para>"aplatissement inverse"</para><para>"inverse flattening"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#inverseFlattening">http://data.ign.fr/def/ignf#inverseFlattening</seealso>
    let inverseFlattening = Prefixed_Name(ignf, "inverseFlattening") |> PrefixedName
    /// <summary>
    ///   <para>ignf:isSphere</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates whether the ellipsoid is a sphere. Cf. ISO 19111:2007:2007-07, table 37, attribute ellipsoid=sphere indicator."</para>
    ///   <para>"Indique si l'ellipsoïde est une sphère. Cf. ISO 19111:2007:2007-07, tableau 37, attribut indicateur ellipsoïde=sphère."</para>
    /// labels<para>"is sphere"</para><para>"est une sphère"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#isSphere">http://data.ign.fr/def/ignf#isSphere</seealso>
    let isSphere = Prefixed_Name(ignf, "isSphere") |> PrefixedName
    /// <summary>
    ///   <para>ignf:methodFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The formula used by a method to perform an operation on coordinates. Cf. ISO 19111:2007:2007-07, table 48, attribute coordinate operation method formula reference."</para>
    ///   <para>"Indique la formule utilisée par une méthode pour faire opération sur des coordonnées. Cf. ISO 19111:2007:2007-07, tableau 48, attribut référence de formule de la méthode d'opération sur les coordonnées."</para>
    /// labels<para>"method formula"</para><para>"formule de la méthode"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#methodFormula">http://data.ign.fr/def/ignf#methodFormula</seealso>
    let methodFormula = Prefixed_Name(ignf, "methodFormula") |> PrefixedName
    /// <summary>
    ///   <para>ignf:northBoundLatitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates the north bound longitude of a bounding box. Cf. ISO 19115-1:2014:2014-04, part 6.6.1 and table B.15.1 line 348."</para>
    ///   <para>"Désigne la latitude nord maximale du cadre englobant. Cf. ISO 19115-1:2014:2014-04, partie 6.6.1 et tableau B.15.1 ligne 348."</para>
    /// labels<para>"latitude nord maximale"</para><para>"north bound longitude"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#northBoundLatitude">http://data.ign.fr/def/ignf#northBoundLatitude</seealso>
    let northBoundLatitude = Prefixed_Name(ignf, "northBoundLatitude") |> PrefixedName
    /// <summary>
    ///   <para>ignf:operationVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The version of an operation performed on coordinates. Cf. ISO 19111:2007:2007-07, table 42, attribute coordinate operation version."</para>
    ///   <para>"Indique la version d'une opération appliquée sur des coordonnées. Cf. ISO 19111:2007:2007-07, tableau 42, attribut version de l'opération sur les coordonnées."</para>
    /// labels<para>"operation version"</para><para>"version de l'opération"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#operationVersion">http://data.ign.fr/def/ignf#operationVersion</seealso>
    let operationVersion = Prefixed_Name(ignf, "operationVersion") |> PrefixedName
    /// <summary>
    ///   <para>ignf:parameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The parameter associated to a given value. Cf. ISO 19111:2007:2007-07, table 55, association role parameter."</para>
    ///   <para>"Désigne le paramètre auquel est associée une valeur. Cf. ISO 19111:2007:2007-07, tableau 55, rôle d'association parameter."</para>
    /// labels<para>"paramètre"</para><para>"parameter"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#parameter">http://data.ign.fr/def/ignf#parameter</seealso>
    let parameter = Prefixed_Name(ignf, "parameter") |> PrefixedName
    /// <summary>
    ///   <para>ignf:primeMeridian</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Désigne le méridien origine d'un référentiel géodésique. Cf. ISO 19111:2007:2007-07, tableau 34, rôle d'association primeMeridian."</para>
    ///   <para>"The prime meridian used by a geodetic datum. Cf. ISO 19111:2007:2007-07, table 34, association role primeMeridian."</para>
    /// labels<para>"uses prime meridian"</para><para>"utilise le méridien origine"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#primeMeridian">http://data.ign.fr/def/ignf#primeMeridian</seealso>
    let primeMeridian = Prefixed_Name(ignf, "primeMeridian") |> PrefixedName
    /// <summary>
    ///   <para>ignf:scope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The scope of the referring object. Cf. ISO 19111:2007:2007-07, tables 4, 33 et 42, attribute scope."</para>
    ///   <para>"Désigne la portée de la référence. Cf. ISO 19111:2007:2007-07, tableaux 4, 33 et 42, attribut scope."</para>
    /// labels<para>"portée"</para><para>"scope"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#scope">http://data.ign.fr/def/ignf#scope</seealso>
    let scope = Prefixed_Name(ignf, "scope") |> PrefixedName
    /// <summary>
    ///   <para>ignf:semiMajorAxis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Désigne la longueur du demi grand axe d'un ellipsoïde. Cf. ISO 19111:2007:2007-07, tableau 36, attribut longueur du demi-grand axe."</para>
    ///   <para>"Indicates the length of the semi major axis of an ellipsoid. Cf. ISO 19111:2007:2007-07, table 36, attribute length of semi-major axis."</para>
    /// labels<para>"semi major axis"</para><para>"demi grand axe"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#semiMajorAxis">http://data.ign.fr/def/ignf#semiMajorAxis</seealso>
    let semiMajorAxis = Prefixed_Name(ignf, "semiMajorAxis") |> PrefixedName
    /// <summary>
    ///   <para>ignf:semiMinorAxis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Désigne la longueur du demi petit axe d'un ellipsoïde. Cf. ISO 19111:2007:2007-07, tableau 37, attribut longueur du demi-petit axe."</para>
    ///   <para>"Indicates the length of the semi minor axis of an ellipsoid. Cf. ISO 19111:2007:2007-07, table 37, attribute length of semi-minor axis."</para>
    /// labels<para>"semi minor axis"</para><para>"demi petit axe"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#semiMinorAxis">http://data.ign.fr/def/ignf#semiMinorAxis</seealso>
    let semiMinorAxis = Prefixed_Name(ignf, "semiMinorAxis") |> PrefixedName
    /// <summary>
    ///   <para>ignf:sourceCRS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Désigne le système de coordonnées de référence des données en entrée d'une opération. Cf. ISO 19111:2007:2007-07, tableau 42, association nommée Source."</para>
    ///   <para>"The coordinate reference system associated to the data used as input of a given operation. Cf. ISO 19111:2007:2007-07, table 42, named association Source."</para>
    /// labels<para>"système de coordonnées de référence source"</para><para>"source coordinate reference system"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#sourceCRS">http://data.ign.fr/def/ignf#sourceCRS</seealso>
    let sourceCRS = Prefixed_Name(ignf, "sourceCRS") |> PrefixedName
    /// <summary>
    ///   <para>ignf:sourceDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The dimension of the coordinate reference system associated with the data used as input of an operation. Cf. ISO 19111:2007:2007-07, table 48, attribute dimension of source CRS."</para>
    ///   <para>"Indique la dimension du système de coordonnées de référence des données en entrée d'une opération. Cf. ISO 19111:2007:2007-07, tableau 48, attribut dimension du système de coordonnées de référence source."</para>
    /// labels<para>"source coordinate reference system dimension"</para><para>"dimension du système de coordonnées de référence source"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#sourceDimension">http://data.ign.fr/def/ignf#sourceDimension</seealso>
    let sourceDimension = Prefixed_Name(ignf, "sourceDimension") |> PrefixedName
    /// <summary>
    ///   <para>ignf:southBoundLatitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates the south bound latitude of a bounding box. Cf. ISO 19115-1:2014:2014-04, part 6.6.1 and table B.15.1 line 347."</para>
    ///   <para>"Désigne la latitude sud minimale du cadre englobant. Cf. ISO 19115-1:2014:2014-04, partie 6.6.1 et tableau B.15.1 ligne 347."</para>
    /// labels<para>"latitude sud minimale"</para><para>"south bound latitude"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#southBoundLatitude">http://data.ign.fr/def/ignf#southBoundLatitude</seealso>
    let southBoundLatitude = Prefixed_Name(ignf, "southBoundLatitude") |> PrefixedName
    /// <summary>
    ///   <para>ignf:targetCRS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The coordinate reference system associated to the data obtained as output of a given operation. Cf. ISO 19111:2007:2007-07, table 42, named association Target."</para>
    ///   <para>"Désigne le système de coordonnées de référence des données en sortie d'une opération. Cf. ISO 19111:2007:2007-07, tableau 42, association nommée Target."</para>
    /// labels<para>"système de coordonnées de référence cible"</para><para>"target coordinate reference system"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#targetCRS">http://data.ign.fr/def/ignf#targetCRS</seealso>
    let targetCRS = Prefixed_Name(ignf, "targetCRS") |> PrefixedName
    /// <summary>
    ///   <para>ignf:targetDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indique la dimension du système de coordonnées de référence des données en sortie d'une opération. Cf. ISO 19111:2007:2007-07, tableau 48, attribut dimension du système de coordonnées de référence cible."</para>
    ///   <para>"The dimension of the coordinate reference system associated with the data obtained as output of an operation. Cf. ISO 19111:2007:2007-07, table 48, attribute dimension of target CRS."</para>
    /// labels<para>"dimension du système de coordonnées de référence cible"</para><para>"target coordinate reference system dimension"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#targetDimension">http://data.ign.fr/def/ignf#targetDimension</seealso>
    let targetDimension = Prefixed_Name(ignf, "targetDimension") |> PrefixedName
    /// <summary>
    ///   <para>ignf:usesMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The method used by an operation on coordinates. Cf. ISO 19111:2007:2007-07, table 43, association role method."</para>
    ///   <para>"Désigne la méthode utilisée par une opération sur des coordonnées. Cf. ISO 19111:2007:2007-07, tableau 43, rôle d'association method."</para>
    /// labels<para>"utilise la méthode"</para><para>"uses method"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#usesMethod">http://data.ign.fr/def/ignf#usesMethod</seealso>
    let usesMethod = Prefixed_Name(ignf, "usesMethod") |> PrefixedName
    /// <summary>
    ///   <para>ignf:usesParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Désigne un paramètre utilisé par une méthode pour faire une opération sur des coordonnées. Cf. ISO 19111:2007:2007-07, tableau 48, rôle d'association parameter."</para>
    ///   <para>"A parameter used by a method to perform an operation on coordinates. Cf. ISO 19111:2007:2007-07, table 48, association role parameter."</para>
    /// labels<para>"uses parameter"</para><para>"utilise le paramètre"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#usesParameter">http://data.ign.fr/def/ignf#usesParameter</seealso>
    let usesParameter = Prefixed_Name(ignf, "usesParameter") |> PrefixedName
    /// <summary>
    ///   <para>ignf:usesValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A value used by an operation on coordinates. Cf. ISO 19111:2007:2007-07, table 43, association role parameterValue."</para>
    ///   <para>"Désigne une valeur utilisée par une opération sur des coordonnées. Cf. ISO 19111:2007:2007-07, tableau 43, rôle d'association parameterValue."</para>
    /// labels<para>"uses value"</para><para>"utilise la valeur"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#usesValue">http://data.ign.fr/def/ignf#usesValue</seealso>
    let usesValue = Prefixed_Name(ignf, "usesValue") |> PrefixedName
    /// <summary>
    ///   <para>ignf:verticalCS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Désigne le système de coordonnées vertical utilisé par un système de coordonnées de référence vertical. Cf. ISO 19111:2007:2007-07, tableau 14, association nommée CoordinateSystem."</para>
    ///   <para>"The vertical coordinate system used by a vertical coordinate reference system. Cf. ISO 19111:2007:2007-07, table 14, named association CoordinateSystem."</para>
    /// labels<para>"uses vertical coordinate system"</para><para>"utilise le système vertical de coordonnées"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#verticalCS">http://data.ign.fr/def/ignf#verticalCS</seealso>
    let verticalCS = Prefixed_Name(ignf, "verticalCS") |> PrefixedName
    /// <summary>
    ///   <para>ignf:verticalDatum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Désigne le référentiel vertical utilisé par un système de coordonnées de référence vertical. Cf. ISO 19111:2007:2007-07, tableau 14, association nommée DefiningDatum."</para>
    ///   <para>"The vertical datum used by a vertical coordinate reference system. Cf. ISO 19111:2007:2007-07, table 14, named association DefiningDatum."</para>
    /// labels<para>"utilise le référentiel vertical"</para><para>"uses vertical datum"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#verticalDatum">http://data.ign.fr/def/ignf#verticalDatum</seealso>
    let verticalDatum = Prefixed_Name(ignf, "verticalDatum") |> PrefixedName
    /// <summary>
    ///   <para>ignf:westBoundLongitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Désigne la longitude ouest minimale du cadre englobant. Cf. ISO 19115-1:2014:2014-04, partie 6.6.1 et tableau B.15.1 ligne 345."</para>
    ///   <para>"Indicates the west bound longitude of a bounding box. Cf. ISO 19115-1:2014:2014-04, part 6.6.1 and table B.15.1 line 345."</para>
    /// labels<para>"west bound longitude"</para><para>"longitude ouest minimale"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/ignf#westBoundLongitude">http://data.ign.fr/def/ignf#westBoundLongitude</seealso>
    let westBoundLongitude = Prefixed_Name(ignf, "westBoundLongitude") |> PrefixedName

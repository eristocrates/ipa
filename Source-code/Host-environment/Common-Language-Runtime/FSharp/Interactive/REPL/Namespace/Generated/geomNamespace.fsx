#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module geom =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://data.ign.fr/def/geometrie#" "geom"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Courberdfs:label : Curve</para>
    ///   <para>rdfs:comment : Primitive géométrique représentant une courbe. Elle n'est pas instanciable. Ses spécialisations sont instanciées sous la forme d'une liste ordonnée de points associée à une fonction d'interpolation.</para>
    ///   <a href="http://data.ign.fr/def/geometrie#Curve">geom:Curve</a>
    /// </summary>
    let Curve = _prefixId.prefix "Curve"
    /// <summary>
    ///   <para>rdfs:label : Enveloperdfs:label : Enveloppe</para>
    ///   <para>rdfs:comment : Primitive géométrique représentant l'enveloppe minimale d'une géométrie. Une enveloppe est représentée par deux points: son coin de coordonnées maximales et son coin de coordonnées minimales.</para>
    ///   <a href="http://data.ign.fr/def/geometrie#Envelope">geom:Envelope</a>
    /// </summary>
    let Envelope = _prefixId.prefix "Envelope"
    /// <summary>
    ///   <para>rdfs:label : Géométrierdfs:label : Geometry</para>
    ///   <para>rdfs:comment : Primitive géométrique non instanciable, racine de l'ontologie des primitives géométriques. Une géométrie est associée à un système de coordonnées et un seul.</para>
    ///   <a href="http://data.ign.fr/def/geometrie#Geometry">geom:Geometry</a>
    /// </summary>
    let Geometry = _prefixId.prefix "Geometry"
    /// <summary>
    ///   <para>rdfs:label : Collection de géométriesrdfs:label : Geometry collection</para>
    ///   <para>rdfs:comment : Collection comprenant un ou plusieurs objets géométriques, sans structure interne. Tous les éléments d'une collection de géométries sont définis dans le même système de coordonnées.</para>
    ///   <a href="http://data.ign.fr/def/geometrie#GeometryCollection">geom:GeometryCollection</a>
    /// </summary>
    let GeometryCollection = _prefixId.prefix "GeometryCollection"
    /// <summary>
    ///   <para>rdfs:label : Lignerdfs:label : Line</para>
    ///   <para>rdfs:comment : Primitive géométrique spécialisant la primitive Polyligne et composée de seulement deux points.</para>
    ///   <a href="http://data.ign.fr/def/geometrie#Line">geom:Line</a>
    /// </summary>
    let Line = _prefixId.prefix "Line"
    /// <summary>
    ///   <para>rdfs:label : Line stringrdfs:label : Polyligne</para>
    ///   <para>rdfs:comment : Primitive géométrique spécialisant la primitive abstraite curve. Ses points sont reliés par une fonction d'interpolation linéaire. Chaque paire de points successifs constitue donc un segment de ligne droite.</para>
    ///   <a href="http://data.ign.fr/def/geometrie#LineString">geom:LineString</a>
    /// </summary>
    let LineString = _prefixId.prefix "LineString"
    /// <summary>
    ///   <para>rdfs:label : Anneaurdfs:label : Linear ring</para>
    ///   <para>rdfs:comment : Primitive géométrique spécialisant la primitive Polyligne. C'est une courbe simple et fermée.</para>
    ///   <a href="http://data.ign.fr/def/geometrie#LinearRing">geom:LinearRing</a>
    /// </summary>
    let LinearRing = _prefixId.prefix "LinearRing"
    /// <summary>
    ///   <para>rdfs:label : Multi curverdfs:label : Multicourbe</para>
    ///   <para>rdfs:comment : Collection d'objets géométriques de type Courbe. Cette primitive n'est pas instanciable: elle définit des propriétés pour ses sous-classes.</para>
    ///   <a href="http://data.ign.fr/def/geometrie#MultiCurve">geom:MultiCurve</a>
    /// </summary>
    let MultiCurve = _prefixId.prefix "MultiCurve"
    /// <summary>
    ///   <para>rdfs:label : Multi line stringrdfs:label : Multipolyligne</para>
    ///   <para>rdfs:comment : Collection d'objets géométriques de type Polyligne. C'est une MultiCourbe dont tous les éléments sont des Polylignes.</para>
    ///   <a href="http://data.ign.fr/def/geometrie#MultiLineString">geom:MultiLineString</a>
    /// </summary>
    let MultiLineString = _prefixId.prefix "MultiLineString"
    /// <summary>
    ///   <para>rdfs:label : Multi pointrdfs:label : Multipoint</para>
    ///   <para>rdfs:comment : Collection d'objets géométriques de type Point, non connectés et non ordonnés. Un multipoint est dit simple si tous ses points sont différents (i.e. ont des coordonnées différentes).</para>
    ///   <a href="http://data.ign.fr/def/geometrie#MultiPoint">geom:MultiPoint</a>
    /// </summary>
    let MultiPoint = _prefixId.prefix "MultiPoint"
    /// <summary>
    ///   <para>rdfs:label : Multi polygonrdfs:label : Multipolygone</para>
    ///   <para>rdfs:comment : Collection d'objets géométriques de type Polygone. C'est une MultiSurface dont tous les éléments sont des Polygones.</para>
    ///   <a href="http://data.ign.fr/def/geometrie#MultiPolygon">geom:MultiPolygon</a>
    /// </summary>
    let MultiPolygon = _prefixId.prefix "MultiPolygon"
    /// <summary>
    ///   <para>rdfs:label : Multi surfacerdfs:label : Multisurface</para>
    ///   <para>rdfs:comment : Collection d'objets géométriques de type Surface. Cette primitive n'est pas instanciable: elle définit des propriétés pour ses sous classes.</para>
    ///   <a href="http://data.ign.fr/def/geometrie#MultiSurface">geom:MultiSurface</a>
    /// </summary>
    let MultiSurface = _prefixId.prefix "MultiSurface"
    /// <summary>
    ///   <para>rdfs:label : Pointrdfs:label : Point</para>
    ///   <para>rdfs:comment : Primitive géométrique permettant de représenter une position géographique. Cette position est représentée via des coordonnées X et Y exprimées dans un système de coordonnées donné. Si le système de coordonnées associé au point le permet, ce dernier peut également avoir des coordonnées Z et M.</para>
    ///   <a href="http://data.ign.fr/def/geometrie#Point">geom:Point</a>
    /// </summary>
    let Point = _prefixId.prefix "Point"
    /// <summary>
    ///   <para>rdfs:label : List of pointsrdfs:label : Liste de points</para>
    ///   <para>rdfs:comment : Liste de points.</para>
    ///   <a href="http://data.ign.fr/def/geometrie#PointsList">geom:PointsList</a>
    /// </summary>
    let PointsList = _prefixId.prefix "PointsList"
    /// <summary>
    ///   <para>rdfs:label : Polygonrdfs:label : Polygone</para>
    ///   <para>rdfs:comment : Primitive géométrique spécialisant la primitive Surface. C'est une surface plane définie par une frontière extérieure et zéro ou plusieurs frontières intérieures. Chaque frontière intérieure définit un trou dans le polygone.</para>
    ///   <a href="http://data.ign.fr/def/geometrie#Polygon">geom:Polygon</a>
    /// </summary>
    let Polygon = _prefixId.prefix "Polygon"
    /// <summary>
    ///   <para>rdfs:label : Surfacerdfs:label : Surface</para>
    ///   <para>rdfs:comment : Primitive géométrique représentant localement une image continue d'une région d'un plan. Elle n'est pas instanciable. Le contour d'une surface est un ensemble de courbes fermées correspondant à ses frontières.</para>
    ///   <a href="http://data.ign.fr/def/geometrie#Surface">geom:Surface</a>
    /// </summary>
    let Surface = _prefixId.prefix "Surface"
    /// <summary>
    ///   <para>rdfs:label : frontièrerdfs:label : boundary</para>
    ///   <para>rdfs:comment : Relie un polygone à un anneau décrivant sa frontière.</para>
    ///   <a href="http://data.ign.fr/def/geometrie#boundary">geom:boundary</a>
    /// </summary>
    let boundary = _prefixId.prefix "boundary"
    /// <summary>
    ///   <para>rdfs:label : centroidrdfs:label : centroïde</para>
    ///   <para>rdfs:comment : Centroide d'une géométrie</para>
    ///   <a href="http://data.ign.fr/def/geometrie#centroid">geom:centroid</a>
    /// </summary>
    let centroid = _prefixId.prefix "centroid"
    /// <summary>
    ///   <para>rdfs:label : mrdfs:label : m</para>
    ///   <para>rdfs:comment : L'interprétation des coordonnées d'un point dépend du système de coordonnées de référence associé à ce point. La coordonnées M d'un point représente une mesure.</para>
    ///   <a href="http://data.ign.fr/def/geometrie#coordM">geom:coordM</a>
    /// </summary>
    let coordM = _prefixId.prefix "coordM"
    /// <summary>
    ///   <para>rdfs:label : xrdfs:label : x</para>
    ///   <para>rdfs:comment : L'interprétation des coordonnées d'un point dépend du système de coordonnées de référence associé à ce point. La propriété coordX désigne la coordonnée définie par rapport au premier axe du système de coordonnées.</para>
    ///   <a href="http://data.ign.fr/def/geometrie#coordX">geom:coordX</a>
    /// </summary>
    let coordX = _prefixId.prefix "coordX"
    /// <summary>
    ///   <para>rdfs:label : yrdfs:label : y</para>
    ///   <para>rdfs:comment : L'interprétation des coordonnées d'un point dépend du système de coordonnées de référence associé à ce point. La propriété coordY désigne la coordonnée définie par rapport au deuxième axe du système de coordonnées.</para>
    ///   <a href="http://data.ign.fr/def/geometrie#coordY">geom:coordY</a>
    /// </summary>
    let coordY = _prefixId.prefix "coordY"
    /// <summary>
    ///   <para>rdfs:label : zrdfs:label : z</para>
    ///   <para>rdfs:comment : L'interprétation des coordonnées d'un point dépend du système de coordonnées de référence associé à ce point. La propriété coordZ désigne la coordonnée définie par rapport au troisième axe du système de coordonnées. La coordonnées Z d'un point représente typiquement, mais pas nécessairement, l'altitude ou la hauteur de ce point.</para>
    ///   <a href="http://data.ign.fr/def/geometrie#coordZ">geom:coordZ</a>
    /// </summary>
    let coordZ = _prefixId.prefix "coordZ"
    /// <summary>
    ///   <para>rdfs:label : coordinate reference systemrdfs:label : système de coordonnées</para>
    ///   <para>rdfs:comment : Système de coordonnées associé à une primitive géométrique.</para>
    ///   <a href="http://data.ign.fr/def/geometrie#crs">geom:crs</a>
    /// </summary>
    let crs = _prefixId.prefix "crs"
    /// <summary>
    ///   <para>rdfs:label : enveloperdfs:label : enveloppe</para>
    ///   <para>rdfs:comment : Rectangle englobant minimal d'une géométrie</para>
    ///   <a href="http://data.ign.fr/def/geometrie#envelope">geom:envelope</a>
    /// </summary>
    let envelope = _prefixId.prefix "envelope"
    /// <summary>
    ///   <para>rdfs:label : extérieurrdfs:label : exterior</para>
    ///   <para>rdfs:comment : Relie un polygone à un anneau décrivant le contour extérieur de sa surface.</para>
    ///   <a href="http://data.ign.fr/def/geometrie#exterior">geom:exterior</a>
    /// </summary>
    let exterior = _prefixId.prefix "exterior"
    /// <summary>
    ///   <para>rdfs:label : first and lastrdfs:label : premier et dernier</para>
    ///   <para>rdfs:comment : Désigne le point servant de point initial et de point final à une liste circulaire de points.</para>
    ///   <a href="http://data.ign.fr/def/geometrie#firstAndLast">geom:firstAndLast</a>
    /// </summary>
    let firstAndLast = _prefixId.prefix "firstAndLast"
    /// <summary>
    ///   <para>rdfs:label : a pour géométrierdfs:label : has geometry</para>
    ///   <para>rdfs:comment : Primitive géométrique associée à un objet pour représenter sa localisation et éventuellement sa forme.</para>
    ///   <a href="http://data.ign.fr/def/geometrie#geometry">geom:geometry</a>
    /// </summary>
    let geometry = _prefixId.prefix "geometry"
    /// <summary>
    ///   <para>rdfs:label : intérieurrdfs:label : interior</para>
    ///   <para>rdfs:comment : Relie un polygone à un anneau décrivant un trou dans sa surface.</para>
    ///   <a href="http://data.ign.fr/def/geometrie#interior">geom:interior</a>
    /// </summary>
    let interior = _prefixId.prefix "interior"
    /// <summary>
    ///   <para>rdfs:label : polyligne membrerdfs:label : line string member</para>
    ///   <para>rdfs:comment : Relie une géométrie de type MultiLineString aux linestrings qui la composent.</para>
    ///   <a href="http://data.ign.fr/def/geometrie#lineStringMember">geom:lineStringMember</a>
    /// </summary>
    let lineStringMember = _prefixId.prefix "lineStringMember"
    /// <summary>
    ///   <para>rdfs:label : lower cornerrdfs:label : coin inférieur</para>
    ///   <para>rdfs:comment : Coin d'une enveloppe correspondant aux valeurs de X et Y les moins élevées.</para>
    ///   <a href="http://data.ign.fr/def/geometrie#lowerCorner">geom:lowerCorner</a>
    /// </summary>
    let lowerCorner = _prefixId.prefix "lowerCorner"
    /// <summary>
    ///   <para>rdfs:label : point membrerdfs:label : point member</para>
    ///   <para>rdfs:comment : Relie une géométrie de type MultiPoint aux points qui la composent.</para>
    ///   <a href="http://data.ign.fr/def/geometrie#pointMember">geom:pointMember</a>
    /// </summary>
    let pointMember = _prefixId.prefix "pointMember"
    /// <summary>
    ///   <para>rdfs:label : pointsrdfs:label : points</para>
    ///   <para>rdfs:comment : La liste ordonnée des points consitutant une géométrie de type Curve.</para>
    ///   <a href="http://data.ign.fr/def/geometrie#points">geom:points</a>
    /// </summary>
    let points = _prefixId.prefix "points"
    /// <summary>
    ///   <para>rdfs:label : polygone membrerdfs:label : polygon member</para>
    ///   <para>rdfs:comment : Relie une géométrie de type MultiPolygon aux polygones qui la composent.</para>
    ///   <a href="http://data.ign.fr/def/geometrie#polygonMember">geom:polygonMember</a>
    /// </summary>
    let polygonMember = _prefixId.prefix "polygonMember"
    /// <summary>
    ///   <para>rdfs:label : upper cornerrdfs:label : coin supérieur</para>
    ///   <para>rdfs:comment : Coin d'une enveloppe correspondant aux valeurs de X et Y les plus élevées.</para>
    ///   <a href="http://data.ign.fr/def/geometrie#upperCorner">geom:upperCorner</a>
    /// </summary>
    let upperCorner = _prefixId.prefix "upperCorner"

namespace http.data.ign.fr.def.geometrie.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module geom =
    let _namespace_iri = Namespace_Iri geom |> NamespaceIRI
    /// <summary>
    ///   <para>geom:Curve</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Primitive géométrique représentant une courbe. Elle n'est pas instanciable. Ses spécialisations sont instanciées sous la forme d'une liste ordonnée de points associée à une fonction d'interpolation.</para>
    /// labels<para>Courbe</para><para>Curve</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geometrie#Curve">http://data.ign.fr/def/geometrie#Curve</seealso>
    let Curve = Prefixed_Name(geom, "Curve") |> PrefixedName
    /// <summary>
    ///   <para>geom:Geometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Primitive géométrique non instanciable, racine de l'ontologie des primitives géométriques. Une géométrie est associée à un système de coordonnées et un seul.</para>
    /// labels<para>Géométrie</para><para>Geometry</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geometrie#Geometry">http://data.ign.fr/def/geometrie#Geometry</seealso>
    let Geometry = Prefixed_Name(geom, "Geometry") |> PrefixedName
    /// <summary>
    ///   <para>geom:Point</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Primitive géométrique permettant de représenter une position géographique. Cette position est représentée via des coordonnées X et Y exprimées dans un système de coordonnées donné. Si le système de coordonnées associé au point le permet, ce dernier peut également avoir des coordonnées Z et M.</para>
    /// labels<para>Point</para><para>Point</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geometrie#Point">http://data.ign.fr/def/geometrie#Point</seealso>
    let Point = Prefixed_Name(geom, "Point") |> PrefixedName
    /// <summary>
    ///   <para>geom:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.ign.fr/def/geometrie#">http://data.ign.fr/def/geometrie#</seealso>
    let _prefix_iri = Prefixed_Name(geom, "") |> PrefixedName
    /// <summary>
    ///   <para>geom:Envelope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Primitive géométrique représentant l'enveloppe minimale d'une géométrie. Une enveloppe est représentée par deux points: son coin de coordonnées maximales et son coin de coordonnées minimales.</para>
    /// labels<para>Enveloppe</para><para>Envelope</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geometrie#Envelope">http://data.ign.fr/def/geometrie#Envelope</seealso>
    let Envelope = Prefixed_Name(geom, "Envelope") |> PrefixedName
    /// <summary>
    ///   <para>geom:upperCorner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Coin d'une enveloppe correspondant aux valeurs de X et Y les plus élevées.</para>
    /// labels<para>coin supérieur</para><para>upper corner</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geometrie#upperCorner">http://data.ign.fr/def/geometrie#upperCorner</seealso>
    let upperCorner = Prefixed_Name(geom, "upperCorner") |> PrefixedName
    /// <summary>
    ///   <para>geom:lowerCorner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Coin d'une enveloppe correspondant aux valeurs de X et Y les moins élevées.</para>
    /// labels<para>coin inférieur</para><para>lower corner</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geometrie#lowerCorner">http://data.ign.fr/def/geometrie#lowerCorner</seealso>
    let lowerCorner = Prefixed_Name(geom, "lowerCorner") |> PrefixedName
    /// <summary>
    ///   <para>geom:crs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Système de coordonnées associé à une primitive géométrique.</para>
    /// labels<para>coordinate reference system</para><para>système de coordonnées</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geometrie#crs">http://data.ign.fr/def/geometrie#crs</seealso>
    let crs = Prefixed_Name(geom, "crs") |> PrefixedName
    /// <summary>
    ///   <para>geom:Line</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Primitive géométrique spécialisant la primitive Polyligne et composée de seulement deux points.</para>
    /// labels<para>Ligne</para><para>Line</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geometrie#Line">http://data.ign.fr/def/geometrie#Line</seealso>
    let Line = Prefixed_Name(geom, "Line") |> PrefixedName
    /// <summary>
    ///   <para>geom:LineString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Primitive géométrique spécialisant la primitive abstraite curve. Ses points sont reliés par une fonction d'interpolation linéaire. Chaque paire de points successifs constitue donc un segment de ligne droite.</para>
    /// labels<para>Line string</para><para>Polyligne</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geometrie#LineString">http://data.ign.fr/def/geometrie#LineString</seealso>
    let LineString = Prefixed_Name(geom, "LineString") |> PrefixedName
    /// <summary>
    ///   <para>geom:GeometryCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Collection comprenant un ou plusieurs objets géométriques, sans structure interne. Tous les éléments d'une collection de géométries sont définis dans le même système de coordonnées.</para>
    /// labels<para>Collection de géométries</para><para>Geometry collection</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geometrie#GeometryCollection">http://data.ign.fr/def/geometrie#GeometryCollection</seealso>
    let GeometryCollection = Prefixed_Name(geom, "GeometryCollection") |> PrefixedName
    /// <summary>
    ///   <para>geom:PointsList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Liste de points.</para>
    /// labels<para>Liste de points</para><para>List of points</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geometrie#PointsList">http://data.ign.fr/def/geometrie#PointsList</seealso>
    let PointsList = Prefixed_Name(geom, "PointsList") |> PrefixedName
    /// <summary>
    ///   <para>geom:points</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>La liste ordonnée des points consitutant une géométrie de type Curve.</para>
    /// labels<para>points</para><para>points</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geometrie#points">http://data.ign.fr/def/geometrie#points</seealso>
    let points = Prefixed_Name(geom, "points") |> PrefixedName
    /// <summary>
    ///   <para>geom:firstAndLast</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Désigne le point servant de point initial et de point final à une liste circulaire de points.</para>
    /// labels<para>premier et dernier</para><para>first and last</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geometrie#firstAndLast">http://data.ign.fr/def/geometrie#firstAndLast</seealso>
    let firstAndLast = Prefixed_Name(geom, "firstAndLast") |> PrefixedName
    /// <summary>
    ///   <para>geom:lineStringMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relie une géométrie de type MultiLineString aux linestrings qui la composent.</para>
    /// labels<para>line string member</para><para>polyligne membre</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geometrie#lineStringMember">http://data.ign.fr/def/geometrie#lineStringMember</seealso>
    let lineStringMember = Prefixed_Name(geom, "lineStringMember") |> PrefixedName
    /// <summary>
    ///   <para>geom:MultiSurface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Collection d'objets géométriques de type Surface. Cette primitive n'est pas instanciable: elle définit des propriétés pour ses sous classes.</para>
    /// labels<para>Multi surface</para><para>Multisurface</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geometrie#MultiSurface">http://data.ign.fr/def/geometrie#MultiSurface</seealso>
    let MultiSurface = Prefixed_Name(geom, "MultiSurface") |> PrefixedName
    /// <summary>
    ///   <para>geom:coordZ</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>L'interprétation des coordonnées d'un point dépend du système de coordonnées de référence associé à ce point. La propriété coordZ désigne la coordonnée définie par rapport au troisième axe du système de coordonnées. La coordonnées Z d'un point représente typiquement, mais pas nécessairement, l'altitude ou la hauteur de ce point.</para>
    /// labels<para>z</para><para>z</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geometrie#coordZ">http://data.ign.fr/def/geometrie#coordZ</seealso>
    let coordZ = Prefixed_Name(geom, "coordZ") |> PrefixedName
    /// <summary>
    ///   <para>geom:LinearRing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Primitive géométrique spécialisant la primitive Polyligne. C'est une courbe simple et fermée.</para>
    /// labels<para>Linear ring</para><para>Anneau</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geometrie#LinearRing">http://data.ign.fr/def/geometrie#LinearRing</seealso>
    let LinearRing = Prefixed_Name(geom, "LinearRing") |> PrefixedName
    /// <summary>
    ///   <para>geom:MultiPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Collection d'objets géométriques de type Point, non connectés et non ordonnés. Un multipoint est dit simple si tous ses points sont différents (i.e. ont des coordonnées différentes).</para>
    /// labels<para>Multi point</para><para>Multipoint</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geometrie#MultiPoint">http://data.ign.fr/def/geometrie#MultiPoint</seealso>
    let MultiPoint = Prefixed_Name(geom, "MultiPoint") |> PrefixedName
    /// <summary>
    ///   <para>geom:MultiPolygon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Collection d'objets géométriques de type Polygone. C'est une MultiSurface dont tous les éléments sont des Polygones.</para>
    /// labels<para>Multipolygone</para><para>Multi polygon</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geometrie#MultiPolygon">http://data.ign.fr/def/geometrie#MultiPolygon</seealso>
    let MultiPolygon = Prefixed_Name(geom, "MultiPolygon") |> PrefixedName
    /// <summary>
    ///   <para>geom:polygonMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relie une géométrie de type MultiPolygon aux polygones qui la composent.</para>
    /// labels<para>polygone membre</para><para>polygon member</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geometrie#polygonMember">http://data.ign.fr/def/geometrie#polygonMember</seealso>
    let polygonMember = Prefixed_Name(geom, "polygonMember") |> PrefixedName
    /// <summary>
    ///   <para>geom:coordY</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>L'interprétation des coordonnées d'un point dépend du système de coordonnées de référence associé à ce point. La propriété coordY désigne la coordonnée définie par rapport au deuxième axe du système de coordonnées.</para>
    /// labels<para>y</para><para>y</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geometrie#coordY">http://data.ign.fr/def/geometrie#coordY</seealso>
    let coordY = Prefixed_Name(geom, "coordY") |> PrefixedName
    /// <summary>
    ///   <para>geom:coordX</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>L'interprétation des coordonnées d'un point dépend du système de coordonnées de référence associé à ce point. La propriété coordX désigne la coordonnée définie par rapport au premier axe du système de coordonnées.</para>
    /// labels<para>x</para><para>x</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geometrie#coordX">http://data.ign.fr/def/geometrie#coordX</seealso>
    let coordX = Prefixed_Name(geom, "coordX") |> PrefixedName
    /// <summary>
    ///   <para>geom:coordM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>L'interprétation des coordonnées d'un point dépend du système de coordonnées de référence associé à ce point. La coordonnées M d'un point représente une mesure.</para>
    /// labels<para>m</para><para>m</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geometrie#coordM">http://data.ign.fr/def/geometrie#coordM</seealso>
    let coordM = Prefixed_Name(geom, "coordM") |> PrefixedName
    /// <summary>
    ///   <para>geom:exterior</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relie un polygone à un anneau décrivant le contour extérieur de sa surface.</para>
    /// labels<para>extérieur</para><para>exterior</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geometrie#exterior">http://data.ign.fr/def/geometrie#exterior</seealso>
    let exterior = Prefixed_Name(geom, "exterior") |> PrefixedName
    /// <summary>
    ///   <para>geom:boundary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relie un polygone à un anneau décrivant sa frontière.</para>
    /// labels<para>frontière</para><para>boundary</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geometrie#boundary">http://data.ign.fr/def/geometrie#boundary</seealso>
    let boundary = Prefixed_Name(geom, "boundary") |> PrefixedName
    /// <summary>
    ///   <para>geom:geometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Primitive géométrique associée à un objet pour représenter sa localisation et éventuellement sa forme.</para>
    /// labels<para>a pour géométrie</para><para>has geometry</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geometrie#geometry">http://data.ign.fr/def/geometrie#geometry</seealso>
    let geometry = Prefixed_Name(geom, "geometry") |> PrefixedName
    /// <summary>
    ///   <para>geom:MultiCurve</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Collection d'objets géométriques de type Courbe. Cette primitive n'est pas instanciable: elle définit des propriétés pour ses sous-classes.</para>
    /// labels<para>Multicourbe</para><para>Multi curve</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geometrie#MultiCurve">http://data.ign.fr/def/geometrie#MultiCurve</seealso>
    let MultiCurve = Prefixed_Name(geom, "MultiCurve") |> PrefixedName
    /// <summary>
    ///   <para>geom:MultiLineString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Collection d'objets géométriques de type Polyligne. C'est une MultiCourbe dont tous les éléments sont des Polylignes.</para>
    /// labels<para>Multi line string</para><para>Multipolyligne</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geometrie#MultiLineString">http://data.ign.fr/def/geometrie#MultiLineString</seealso>
    let MultiLineString = Prefixed_Name(geom, "MultiLineString") |> PrefixedName
    /// <summary>
    ///   <para>geom:pointMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relie une géométrie de type MultiPoint aux points qui la composent.</para>
    /// labels<para>point member</para><para>point membre</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geometrie#pointMember">http://data.ign.fr/def/geometrie#pointMember</seealso>
    let pointMember = Prefixed_Name(geom, "pointMember") |> PrefixedName
    /// <summary>
    ///   <para>geom:Polygon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Primitive géométrique spécialisant la primitive Surface. C'est une surface plane définie par une frontière extérieure et zéro ou plusieurs frontières intérieures. Chaque frontière intérieure définit un trou dans le polygone.</para>
    /// labels<para>Polygone</para><para>Polygon</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geometrie#Polygon">http://data.ign.fr/def/geometrie#Polygon</seealso>
    let Polygon = Prefixed_Name(geom, "Polygon") |> PrefixedName
    /// <summary>
    ///   <para>geom:interior</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relie un polygone à un anneau décrivant un trou dans sa surface.</para>
    /// labels<para>intérieur</para><para>interior</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geometrie#interior">http://data.ign.fr/def/geometrie#interior</seealso>
    let interior = Prefixed_Name(geom, "interior") |> PrefixedName
    /// <summary>
    ///   <para>geom:Surface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Primitive géométrique représentant localement une image continue d'une région d'un plan. Elle n'est pas instanciable. Le contour d'une surface est un ensemble de courbes fermées correspondant à ses frontières.</para>
    /// labels<para>Surface</para><para>Surface</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geometrie#Surface">http://data.ign.fr/def/geometrie#Surface</seealso>
    let Surface = Prefixed_Name(geom, "Surface") |> PrefixedName
    /// <summary>
    ///   <para>geom:centroid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Centroide d'une géométrie</para>
    /// labels<para>centroïde</para><para>centroid</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geometrie#centroid">http://data.ign.fr/def/geometrie#centroid</seealso>
    let centroid = Prefixed_Name(geom, "centroid") |> PrefixedName
    /// <summary>
    ///   <para>geom:envelope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Rectangle englobant minimal d'une géométrie</para>
    /// labels<para>enveloppe</para><para>envelope</para></remarks>
    /// <seealso href="http://data.ign.fr/def/geometrie#envelope">http://data.ign.fr/def/geometrie#envelope</seealso>
    let envelope = Prefixed_Name(geom, "envelope") |> PrefixedName

#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module arp =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.arpenteur.org/ontology/Arpenteur.owl#" "arp"

    /// <summary>
    ///   <para>rdfs:label : alcyonacea</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#Alcyonacea">arp:Alcyonacea</a>
    /// </summary>
    let Alcyonacea = _prefixId.prefix "Alcyonacea"
    /// <summary>
    ///   <para>rdfs:label : amphorae</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#Amphorae">arp:Amphorae</a>
    /// </summary>
    let Amphorae = _prefixId.prefix "Amphorae"
    /// <summary>
    ///   <para>rdfs:label : archaeology</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#Archaeology">arp:Archaeology</a>
    /// </summary>
    let Archaeology = _prefixId.prefix "Archaeology"
    /// <summary>
    ///   <para>rdfs:label : Architecture</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#Architecture">arp:Architecture</a>
    /// </summary>
    let Architecture = _prefixId.prefix "Architecture"
    /// <summary>
    ///   <para>rdfs:label : Functional Areardfs:label : Area Funzionale</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#AreaFunzionale">arp:AreaFunzionale</a>
    /// </summary>
    let AreaFunzionale = _prefixId.prefix "AreaFunzionale"
    /// <summary>
    ///   <para>rdfs:label : artifact</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#Artifact">arp:Artifact</a>
    /// </summary>
    let Artifact = _prefixId.prefix "Artifact"
    /// <summary>
    ///   <para>rdfs:label : Attivitardfs:label : Activities</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#Attivita">arp:Attivita</a>
    /// </summary>
    let Attivita = _prefixId.prefix "Attivita"
    /// <summary>
    ///   <para>rdfs:label : block</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#Bloc">arp:Bloc</a>
    /// </summary>
    let Bloc = _prefixId.prefix "Bloc"
    /// <summary>
    ///   <para>rdfs:label : bounding box</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#BoundingBox">arp:BoundingBox</a>
    /// </summary>
    let BoundingBox = _prefixId.prefix "BoundingBox"
    /// <summary>
    ///   <para>rdfs:label : brick</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#Brique">arp:Brique</a>
    /// </summary>
    let Brique = _prefixId.prefix "Brique"
    /// <summary>
    ///   <para>rdfs:label : bundle model</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#BundleModel">arp:BundleModel</a>
    /// </summary>
    let BundleModel = _prefixId.prefix "BundleModel"
    /// <summary>
    ///   <para>rdfs:label : camera</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#Camera">arp:Camera</a>
    /// </summary>
    let Camera = _prefixId.prefix "Camera"
    /// <summary>
    ///   <para>rdfs:label : camera manager</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#CameraManager">arp:CameraManager</a>
    /// </summary>
    let CameraManager = _prefixId.prefix "CameraManager"
    /// <summary>
    ///   <para>rdfs:label : cassettonerdfs:label : ceiling boxrdfs:label : caisson du plafond</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#Cassettone">arp:Cassettone</a>
    /// </summary>
    let Cassettone = _prefixId.prefix "Cassettone"
    /// <summary>
    ///   <para>rdfs:label : Architectural Complexrdfs:label : complesso architettonico</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#ComplessoArchitettonico">arp:ComplessoArchitettonico</a>
    /// </summary>
    let ComplessoArchitettonico = _prefixId.prefix "ComplessoArchitettonico"
    /// <summary>
    ///   <para>rdfs:label : constraint manager</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#ConstraintManager">arp:ConstraintManager</a>
    /// </summary>
    let ConstraintManager = _prefixId.prefix "ConstraintManager"
    /// <summary>
    ///   <para>rdfs:label : control point</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#ControlPoint">arp:ControlPoint</a>
    /// </summary>
    let ControlPoint = _prefixId.prefix "ControlPoint"
    /// <summary>
    ///   <para>rdfs:label : coralliidae</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#Coralliidae">arp:Coralliidae</a>
    /// </summary>
    let Coralliidae = _prefixId.prefix "Coralliidae"
    /// <summary>
    ///   <para>rdfs:label : corallium rubrum</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#CoralliumRubrum">arp:CoralliumRubrum</a>
    /// </summary>
    let CoralliumRubrum = _prefixId.prefix "CoralliumRubrum"
    /// <summary>
    ///   <para>rdfs:label : corpo di fabbricardfs:label : factory body</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#CorpoDiFabbrica">arp:CorpoDiFabbrica</a>
    /// </summary>
    let CorpoDiFabbrica = _prefixId.prefix "CorpoDiFabbrica"
    /// <summary>
    ///   <para>rdfs:label : digital camera</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#DigitalCamera">arp:DigitalCamera</a>
    /// </summary>
    let DigitalCamera = _prefixId.prefix "DigitalCamera"
    /// <summary>
    ///   <para>rdfs:label : dolia (dolium)</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#Dolia">arp:Dolia</a>
    /// </summary>
    let Dolia = _prefixId.prefix "Dolia"
    /// <summary>
    ///   <para>rdfs:label : cover element</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#ElementDeCouverture">arp:ElementDeCouverture</a>
    /// </summary>
    let ElementDeCouverture = _prefixId.prefix "ElementDeCouverture"
    /// <summary>
    ///   <para>rdfs:label : element of parement</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#ElementDeParement">arp:ElementDeParement</a>
    /// </summary>
    let ElementDeParement = _prefixId.prefix "ElementDeParement"
    /// <summary>
    ///   <para>rdfs:label : elemento stratigraficordfs:label : stratigraphic element</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#ElementoStratigrafico">arp:ElementoStratigrafico</a>
    /// </summary>
    let ElementoStratigrafico = _prefixId.prefix "ElementoStratigrafico"
    /// <summary>
    ///   <para>rdfs:label : film based camera</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#FilmBasedCamera">arp:FilmBasedCamera</a>
    /// </summary>
    let FilmBasedCamera = _prefixId.prefix "FilmBasedCamera"
    /// <summary>
    ///   <para>rdfs:label : generic manager</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#GenericManager">arp:GenericManager</a>
    /// </summary>
    let GenericManager = _prefixId.prefix "GenericManager"
    /// <summary>
    ///   <para>rdfs:label : geometry</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#Geometry">arp:Geometry</a>
    /// </summary>
    let Geometry = _prefixId.prefix "Geometry"
    /// <summary>
    ///   <para>rdfs:label : grinding stone</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#GrindingStone">arp:GrindingStone</a>
    /// </summary>
    let GrindingStone = _prefixId.prefix "GrindingStone"
    /// <summary>
    ///   <para>rdfs:label : interface colored point</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#IColoredPoint">arp:IColoredPoint</a>
    /// </summary>
    let IColoredPoint = _prefixId.prefix "IColoredPoint"
    /// <summary>
    ///   <para>rdfs:label : interface fixed point</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#IFixedPoint">arp:IFixedPoint</a>
    /// </summary>
    let IFixedPoint = _prefixId.prefix "IFixedPoint"
    /// <summary>
    ///   <para>rdfs:label : interface identified object</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#IIdentifiedObject">arp:IIdentifiedObject</a>
    /// </summary>
    let IIdentifiedObject = _prefixId.prefix "IIdentifiedObject"
    /// <summary>
    ///   <para>rdfs:label : interface point</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#IPoint">arp:IPoint</a>
    /// </summary>
    let IPoint = _prefixId.prefix "IPoint"
    /// <summary>
    ///   <para>rdfs:label : interface point 2D</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#IPoint2D">arp:IPoint2D</a>
    /// </summary>
    let IPoint2D = _prefixId.prefix "IPoint2D"
    /// <summary>
    ///   <para>rdfs:label : interface point 3D</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#IPoint3D">arp:IPoint3D</a>
    /// </summary>
    let IPoint3D = _prefixId.prefix "IPoint3D"
    /// <summary>
    ///   <para>rdfs:label : image point</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#ImagePoint">arp:ImagePoint</a>
    /// </summary>
    let ImagePoint = _prefixId.prefix "ImagePoint"
    /// <summary>
    ///   <para>rdfs:label : image point manager</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#ImagePointManager">arp:ImagePointManager</a>
    /// </summary>
    let ImagePointManager = _prefixId.prefix "ImagePointManager"
    let ManagerCA = _prefixId.prefix "ManagerCA"
    /// <summary>
    ///   <para>rdfs:label : mathematica object</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#MathematicalObject">arp:MathematicalObject</a>
    /// </summary>
    let MathematicalObject = _prefixId.prefix "MathematicalObject"
    /// <summary>
    ///   <para>rdfs:label : matrix</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#Matrix">arp:Matrix</a>
    /// </summary>
    let Matrix = _prefixId.prefix "Matrix"
    /// <summary>
    ///   <para>rdfs:label : measurable</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#Measurable">arp:Measurable</a>
    /// </summary>
    let Measurable = _prefixId.prefix "Measurable"
    /// <summary>
    ///   <para>rdfs:label : measured point manager</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#MeasuredPointManager">arp:MeasuredPointManager</a>
    /// </summary>
    let MeasuredPointManager = _prefixId.prefix "MeasuredPointManager"
    /// <summary>
    ///   <para>rdfs:label : photogrammetric model</para>
    ///   <para>rdfs:comment : This is a photogrammetric model. It contains a set of oriented photograph and a set of 3D points which are at least visible on two oriented photographs.^^xsd:string</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#Model">arp:Model</a>
    /// </summary>
    let Model = _prefixId.prefix "Model"
    /// <summary>
    ///   <para>rdfs:label : nautical archaeology</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#NauticalArchaeology">arp:NauticalArchaeology</a>
    /// </summary>
    let NauticalArchaeology = _prefixId.prefix "NauticalArchaeology"
    /// <summary>
    ///   <para>rdfs:label : Olla (e)</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#Ollae">arp:Ollae</a>
    /// </summary>
    let Ollae = _prefixId.prefix "Ollae"
    /// <summary>
    ///   <para>rdfs:label : petra data</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#PetraData">arp:PetraData</a>
    /// </summary>
    let PetraData = _prefixId.prefix "PetraData"
    /// <summary>
    ///   <para>rdfs:label : photo manager</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#PhotoManager">arp:PhotoManager</a>
    /// </summary>
    let PhotoManager = _prefixId.prefix "PhotoManager"
    /// <summary>
    ///   <para>rdfs:label : photogrammetry</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#Photogrammetry">arp:Photogrammetry</a>
    /// </summary>
    let Photogrammetry = _prefixId.prefix "Photogrammetry"
    /// <summary>
    ///   <para>rdfs:label : photograph</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#Photograph">arp:Photograph</a>
    /// </summary>
    let Photograph = _prefixId.prefix "Photograph"
    /// <summary>
    ///   <para>rdfs:label : point 2D manager</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#Point2DManager">arp:Point2DManager</a>
    /// </summary>
    let Point2DManager = _prefixId.prefix "Point2DManager"
    /// <summary>
    ///   <para>rdfs:label : point 3D manager</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#Point3DManager">arp:Point3DManager</a>
    /// </summary>
    let Point3DManager = _prefixId.prefix "Point3DManager"
    /// <summary>
    ///   <para>rdfs:label : point manager</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#PointManager">arp:PointManager</a>
    /// </summary>
    let PointManager = _prefixId.prefix "PointManager"
    /// <summary>
    ///   <para>rdfs:label : point 3D</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#Point_3D">arp:Point_3D</a>
    /// </summary>
    let Point_3D = _prefixId.prefix "Point_3D"
    /// <summary>
    ///   <para>rdfs:label : prospettordfs:label : prospectus</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#Prospetto">arp:Prospetto</a>
    /// </summary>
    let Prospetto = _prefixId.prefix "Prospetto"
    /// <summary>
    ///   <para>rdfs:label : prospetto generalerdfs:label : general prospectus</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#ProspettoGenerale">arp:ProspettoGenerale</a>
    /// </summary>
    let ProspettoGenerale = _prefixId.prefix "ProspettoGenerale"
    /// <summary>
    ///   <para>rdfs:label : prospetto particolarerdfs:label : particular prospectus</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#ProspettoParticolare">arp:ProspettoParticolare</a>
    /// </summary>
    let ProspettoParticolare = _prefixId.prefix "ProspettoParticolare"
    /// <summary>
    ///   <para>rdfs:label : radial decentring distortion</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#RadialDecenteringDistortion">arp:RadialDecenteringDistortion</a>
    /// </summary>
    let RadialDecenteringDistortion = _prefixId.prefix "RadialDecenteringDistortion"
    /// <summary>
    ///   <para>rdfs:label : transport recipient</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#RecipientTransport">arp:RecipientTransport</a>
    /// </summary>
    let RecipientTransport = _prefixId.prefix "RecipientTransport"
    /// <summary>
    ///   <para>rdfs:label : rotation matrix</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#RotationMatrix">arp:RotationMatrix</a>
    /// </summary>
    let RotationMatrix = _prefixId.prefix "RotationMatrix"
    /// <summary>
    ///   <para>rdfs:label : siti listrdfs:label : city list</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#SitiList">arp:SitiList</a>
    /// </summary>
    let SitiList = _prefixId.prefix "SitiList"
    /// <summary>
    ///   <para>rdfs:label : sitordfs:label : city</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#Sito">arp:Sito</a>
    /// </summary>
    let Sito = _prefixId.prefix "Sito"
    /// <summary>
    ///   <para>rdfs:label : spatial localization</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#SpatialLocalization">arp:SpatialLocalization</a>
    /// </summary>
    let SpatialLocalization = _prefixId.prefix "SpatialLocalization"
    /// <summary>
    ///   <para>rdfs:label : spatial object</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#SpatialObject">arp:SpatialObject</a>
    /// </summary>
    let SpatialObject = _prefixId.prefix "SpatialObject"
    /// <summary>
    ///   <para>rdfs:label : stone tool</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#StoneTool">arp:StoneTool</a>
    /// </summary>
    let StoneTool = _prefixId.prefix "StoneTool"
    /// <summary>
    ///   <para>rdfs:label : Subergorgia</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#Subergorgia">arp:Subergorgia</a>
    /// </summary>
    let Subergorgia = _prefixId.prefix "Subergorgia"
    /// <summary>
    ///   <para>rdfs:label : transformation 3D</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#Transformation3D">arp:Transformation3D</a>
    /// </summary>
    let Transformation3D = _prefixId.prefix "Transformation3D"
    /// <summary>
    ///   <para>rdfs:label : triangle manager</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#TriangleManager">arp:TriangleManager</a>
    /// </summary>
    let TriangleManager = _prefixId.prefix "TriangleManager"
    /// <summary>
    ///   <para>rdfs:label : tuilerdfs:label : tile</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#Tuile">arp:Tuile</a>
    /// </summary>
    let Tuile = _prefixId.prefix "Tuile"
    /// <summary>
    ///   <para>rdfs:label : tuile ronderdfs:label : round tile</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#TuileRonde">arp:TuileRonde</a>
    /// </summary>
    let TuileRonde = _prefixId.prefix "TuileRonde"
    /// <summary>
    ///   <para>rdfs:label : unita archeologicardfs:label : archaeological unit</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#UnitaArcheologica">arp:UnitaArcheologica</a>
    /// </summary>
    let UnitaArcheologica = _prefixId.prefix "UnitaArcheologica"
    /// <summary>
    ///   <para>rdfs:label : unita funzionalerdfs:label : functional unit</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#UnitaFunzionale">arp:UnitaFunzionale</a>
    /// </summary>
    let UnitaFunzionale = _prefixId.prefix "UnitaFunzionale"
    /// <summary>
    ///   <para>rdfs:label : unita stratigraficardfs:label : stratigrafical unit</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#UnitaStratigrafica">arp:UnitaStratigrafica</a>
    /// </summary>
    let UnitaStratigrafica = _prefixId.prefix "UnitaStratigrafica"
    /// <summary>
    ///   <para>rdfs:label : unita stratigrafica muralerdfs:label : mural stratigrafical unit</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#UnitaStratigraficaMurale">arp:UnitaStratigraficaMurale</a>
    /// </summary>
    let UnitaStratigraficaMurale = _prefixId.prefix "UnitaStratigraficaMurale"
    /// <summary>
    ///   <para>rdfs:label : unita topograficardfs:label : mural stratigrafical unit</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#UnitaTopografica">arp:UnitaTopografica</a>
    /// </summary>
    let UnitaTopografica = _prefixId.prefix "UnitaTopografica"
    /// <summary>
    ///   <para>rdfs:label : zoology</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#Zoology">arp:Zoology</a>
    /// </summary>
    let Zoology = _prefixId.prefix "Zoology"
    /// <summary>
    ///   <para>rdfs:label : belong to a mural stratigraphic unit</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#belongToUSM">arp:belongToUSM</a>
    /// </summary>
    let belongToUSM = _prefixId.prefix "belongToUSM"
    /// <summary>
    ///   <para>rdfs:label : has a set of 3D points</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasASetOf3DPoint">arp:hasASetOf3DPoint</a>
    /// </summary>
    let hasASetOf3DPoint = _prefixId.prefix "hasASetOf3DPoint"
    /// <summary>
    ///   <para>rdfs:label : has a set of 3D point with observations</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasASetOf3DPointWithObs">arp:hasASetOf3DPointWithObs</a>
    /// </summary>
    let hasASetOf3DPointWithObs = _prefixId.prefix "hasASetOf3DPointWithObs"
    /// <summary>
    ///   <para>rdfs:label : has a set of architectural complexes</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasASetOfCA">arp:hasASetOfCA</a>
    /// </summary>
    let hasASetOfCA = _prefixId.prefix "hasASetOfCA"
    /// <summary>
    ///   <para>rdfs:label : has a set of factory bodies</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasASetOfCF">arp:hasASetOfCF</a>
    /// </summary>
    let hasASetOfCF = _prefixId.prefix "hasASetOfCF"
    /// <summary>
    ///   <para>rdfs:label : has a set of camera</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasASetOfCamera">arp:hasASetOfCamera</a>
    /// </summary>
    let hasASetOfCamera = _prefixId.prefix "hasASetOfCamera"
    /// <summary>
    ///   <para>rdfs:label : has a set of observations</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasASetOfObservation">arp:hasASetOfObservation</a>
    /// </summary>
    let hasASetOfObservation = _prefixId.prefix "hasASetOfObservation"
    /// <summary>
    ///   <para>rdfs:label : has a set of particular prospectuses</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasASetOfPP">arp:hasASetOfPP</a>
    /// </summary>
    let hasASetOfPP = _prefixId.prefix "hasASetOfPP"
    /// <summary>
    ///   <para>rdfs:label : has a set of city</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasASetOfSiti">arp:hasASetOfSiti</a>
    /// </summary>
    let hasASetOfSiti = _prefixId.prefix "hasASetOfSiti"
    /// <summary>
    ///   <para>rdfs:label : has a set of cities</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasASetOfSito">arp:hasASetOfSito</a>
    /// </summary>
    let hasASetOfSito = _prefixId.prefix "hasASetOfSito"
    /// <summary>
    ///   <para>rdfs:label : has a set of stratigrafic units</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasASetOfUS">arp:hasASetOfUS</a>
    /// </summary>
    let hasASetOfUS = _prefixId.prefix "hasASetOfUS"
    /// <summary>
    ///   <para>rdfs:label : has a set of topographic units</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasASetOfUT">arp:hasASetOfUT</a>
    /// </summary>
    let hasASetOfUT = _prefixId.prefix "hasASetOfUT"
    /// <summary>
    ///   <para>rdfs:label : has belly diameter</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasBellyDiameter">arp:hasBellyDiameter</a>
    /// </summary>
    let hasBellyDiameter = _prefixId.prefix "hasBellyDiameter"
    /// <summary>
    ///   <para>rdfs:label : has bounding box</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasBoundingBox">arp:hasBoundingBox</a>
    /// </summary>
    let hasBoundingBox = _prefixId.prefix "hasBoundingBox"
    /// <summary>
    ///   <para>rdfs:label : has architectural complex</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasCA">arp:hasCA</a>
    /// </summary>
    let hasCA = _prefixId.prefix "hasCA"
    /// <summary>
    ///   <para>rdfs:label : has factory body</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasCF">arp:hasCF</a>
    /// </summary>
    let hasCF = _prefixId.prefix "hasCF"
    /// <summary>
    ///   <para>rdfs:label : has camera</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasCamera">arp:hasCamera</a>
    /// </summary>
    let hasCamera = _prefixId.prefix "hasCamera"
    /// <summary>
    ///   <para>rdfs:label : has a camera manager</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasCameraManager">arp:hasCameraManager</a>
    /// </summary>
    let hasCameraManager = _prefixId.prefix "hasCameraManager"
    /// <summary>
    ///   <para>rdfs:label : has center</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasCenter">arp:hasCenter</a>
    /// </summary>
    let hasCenter = _prefixId.prefix "hasCenter"
    /// <summary>
    ///   <para>rdfs:label : has radial distortion coefficient K1</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasCoef_K1">arp:hasCoef_K1</a>
    /// </summary>
    let hasCoef_K1 = _prefixId.prefix "hasCoef_K1"
    /// <summary>
    ///   <para>rdfs:label : has radial distortion coefficient K2</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasCoef_K2">arp:hasCoef_K2</a>
    /// </summary>
    let hasCoef_K2 = _prefixId.prefix "hasCoef_K2"
    /// <summary>
    ///   <para>rdfs:label : has radial distortion coefficient K3</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasCoef_K3">arp:hasCoef_K3</a>
    /// </summary>
    let hasCoef_K3 = _prefixId.prefix "hasCoef_K3"
    /// <summary>
    ///   <para>rdfs:label : has radial distortion coefficient K4</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasCoef_K4">arp:hasCoef_K4</a>
    /// </summary>
    let hasCoef_K4 = _prefixId.prefix "hasCoef_K4"
    /// <summary>
    ///   <para>rdfs:label : has decentring distortion coefficient P1</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasCoef_P1">arp:hasCoef_P1</a>
    /// </summary>
    let hasCoef_P1 = _prefixId.prefix "hasCoef_P1"
    /// <summary>
    ///   <para>rdfs:label : has decentring distortion coefficient P2</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasCoef_P2">arp:hasCoef_P2</a>
    /// </summary>
    let hasCoef_P2 = _prefixId.prefix "hasCoef_P2"
    /// <summary>
    ///   <para>rdfs:label : has color B</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasColor_B">arp:hasColor_B</a>
    /// </summary>
    let hasColor_B = _prefixId.prefix "hasColor_B"
    /// <summary>
    ///   <para>rdfs:label : has color G</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasColor_G">arp:hasColor_G</a>
    /// </summary>
    let hasColor_G = _prefixId.prefix "hasColor_G"
    /// <summary>
    ///   <para>rdfs:label : has color R</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasColor_R">arp:hasColor_R</a>
    /// </summary>
    let hasColor_R = _prefixId.prefix "hasColor_R"
    /// <summary>
    ///   <para>rdfs:label : has comment</para>
    ///   <para>rdfs:comment : manual evaluation of the Percent of necrosed part in a colony^^xsd:string</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasComment">arp:hasComment</a>
    /// </summary>
    let hasComment = _prefixId.prefix "hasComment"
    /// <summary>
    ///   <para>rdfs:label : has correlation coefficient</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasCorrelationCoef">arp:hasCorrelationCoef</a>
    /// </summary>
    let hasCorrelationCoef = _prefixId.prefix "hasCorrelationCoef"
    /// <summary>
    ///   <para>rdfs:label : has data</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasData">arp:hasData</a>
    /// </summary>
    let hasData = _prefixId.prefix "hasData"
    /// <summary>
    ///   <para>rdfs:label : has definition</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasDefinition">arp:hasDefinition</a>
    /// </summary>
    let hasDefinition = _prefixId.prefix "hasDefinition"
    /// <summary>
    ///   <para>rdfs:label : has description</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasDescription">arp:hasDescription</a>
    /// </summary>
    let hasDescription = _prefixId.prefix "hasDescription"
    /// <summary>
    ///   <para>rdfs:label : has diameter</para>
    ///   <para>rdfs:comment : Should be max Diameter^^xsd:string</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasDiameter">arp:hasDiameter</a>
    /// </summary>
    let hasDiameter = _prefixId.prefix "hasDiameter"
    /// <summary>
    ///   <para>rdfs:label : has diameter neck</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasDiameterNeck">arp:hasDiameterNeck</a>
    /// </summary>
    let hasDiameterNeck = _prefixId.prefix "hasDiameterNeck"
    /// <summary>
    ///   <para>rdfs:label : has diameter support</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasDiameterSupport">arp:hasDiameterSupport</a>
    /// </summary>
    let hasDiameterSupport = _prefixId.prefix "hasDiameterSupport"
    /// <summary>
    ///   <para>rdfs:label : has direttore</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasDirettore">arp:hasDirettore</a>
    /// </summary>
    let hasDirettore = _prefixId.prefix "hasDirettore"
    /// <summary>
    ///   <para>rdfs:label : has distance handles</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasDistanceHandles">arp:hasDistanceHandles</a>
    /// </summary>
    let hasDistanceHandles = _prefixId.prefix "hasDistanceHandles"
    /// <summary>
    ///   <para>rdfs:label : has distortion</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasDistortion">arp:hasDistortion</a>
    /// </summary>
    let hasDistortion = _prefixId.prefix "hasDistortion"
    /// <summary>
    ///   <para>rdfs:label : has extrude depth</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasExtrudeDepth">arp:hasExtrudeDepth</a>
    /// </summary>
    let hasExtrudeDepth = _prefixId.prefix "hasExtrudeDepth"
    /// <summary>
    ///   <para>rdfs:label : has extruded data 1</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasExtrudedData1">arp:hasExtrudedData1</a>
    /// </summary>
    let hasExtrudedData1 = _prefixId.prefix "hasExtrudedData1"
    /// <summary>
    ///   <para>rdfs:label : has extruded data 2</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasExtrudedData2">arp:hasExtrudedData2</a>
    /// </summary>
    let hasExtrudedData2 = _prefixId.prefix "hasExtrudedData2"
    /// <summary>
    ///   <para>rdfs:label : has extruded point 1 X</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasExtrudedPt1X">arp:hasExtrudedPt1X</a>
    /// </summary>
    let hasExtrudedPt1X = _prefixId.prefix "hasExtrudedPt1X"
    /// <summary>
    ///   <para>rdfs:label : has extruded point 1 Y</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasExtrudedPt1Y">arp:hasExtrudedPt1Y</a>
    /// </summary>
    let hasExtrudedPt1Y = _prefixId.prefix "hasExtrudedPt1Y"
    /// <summary>
    ///   <para>rdfs:label : has extruded point 1 Z</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasExtrudedPt1Z">arp:hasExtrudedPt1Z</a>
    /// </summary>
    let hasExtrudedPt1Z = _prefixId.prefix "hasExtrudedPt1Z"
    /// <summary>
    ///   <para>rdfs:label : has extruded point 2 X</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasExtrudedPt2X">arp:hasExtrudedPt2X</a>
    /// </summary>
    let hasExtrudedPt2X = _prefixId.prefix "hasExtrudedPt2X"
    /// <summary>
    ///   <para>rdfs:label : has extruded point 2 Y</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasExtrudedPt2Y">arp:hasExtrudedPt2Y</a>
    /// </summary>
    let hasExtrudedPt2Y = _prefixId.prefix "hasExtrudedPt2Y"
    /// <summary>
    ///   <para>rdfs:label : has extruded point 2 Z</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasExtrudedPt2Z">arp:hasExtrudedPt2Z</a>
    /// </summary>
    let hasExtrudedPt2Z = _prefixId.prefix "hasExtrudedPt2Z"
    /// <summary>
    ///   <para>rdfs:label : has finitura (finish) </para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasFinitura">arp:hasFinitura</a>
    /// </summary>
    let hasFinitura = _prefixId.prefix "hasFinitura"
    /// <summary>
    ///   <para>rdfs:label : has focal lenth</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasFocalLength">arp:hasFocalLength</a>
    /// </summary>
    let hasFocalLength = _prefixId.prefix "hasFocalLength"
    /// <summary>
    ///   <para>rdfs:label : has foot diameter</para>
    ///   <para>rdfs:comment : manual evaluation of the Percent of necrosed part in a colony^^xsd:string</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasFootDiameter">arp:hasFootDiameter</a>
    /// </summary>
    let hasFootDiameter = _prefixId.prefix "hasFootDiameter"
    /// <summary>
    ///   <para>rdfs:label : has correlation coefficient</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasFrameHeigthInPixel">arp:hasFrameHeigthInPixel</a>
    /// </summary>
    let hasFrameHeigthInPixel = _prefixId.prefix "hasFrameHeigthInPixel"
    /// <summary>
    ///   <para>rdfs:label : has frame height in mm</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasFrameHeigthInmm">arp:hasFrameHeigthInmm</a>
    /// </summary>
    let hasFrameHeigthInmm = _prefixId.prefix "hasFrameHeigthInmm"
    /// <summary>
    ///   <para>rdfs:label : has frame widht in pixel</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasFrameWidthInPixel">arp:hasFrameWidthInPixel</a>
    /// </summary>
    let hasFrameWidthInPixel = _prefixId.prefix "hasFrameWidthInPixel"
    /// <summary>
    ///   <para>rdfs:label : has frame width in mm</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasFrameWidthInmm">arp:hasFrameWidthInmm</a>
    /// </summary>
    let hasFrameWidthInmm = _prefixId.prefix "hasFrameWidthInmm"
    /// <summary>
    ///   <para>rdfs:label : has full file name</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasFullFileName">arp:hasFullFileName</a>
    /// </summary>
    let hasFullFileName = _prefixId.prefix "hasFullFileName"
    /// <summary>
    ///   <para>rdfs:label : has handles width</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasHandlesWidth">arp:hasHandlesWidth</a>
    /// </summary>
    let hasHandlesWidth = _prefixId.prefix "hasHandlesWidth"
    /// <summary>
    ///   <para>rdfs:label : has height</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasHeight">arp:hasHeight</a>
    /// </summary>
    let hasHeight = _prefixId.prefix "hasHeight"
    /// <summary>
    ///   <para>rdfs:label : has height lips</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasHeightLips">arp:hasHeightLips</a>
    /// </summary>
    let hasHeightLips = _prefixId.prefix "hasHeightLips"
    /// <summary>
    ///   <para>rdfs:label : has id</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasId">arp:hasId</a>
    /// </summary>
    let hasId = _prefixId.prefix "hasId"
    /// <summary>
    ///   <para>rdfs:label : has idn</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasIdn">arp:hasIdn</a>
    /// </summary>
    let hasIdn = _prefixId.prefix "hasIdn"
    /// <summary>
    ///   <para>rdfs:label : has an image point manager</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasImagePointManager">arp:hasImagePointManager</a>
    /// </summary>
    let hasImagePointManager = _prefixId.prefix "hasImagePointManager"
    /// <summary>
    ///   <para>rdfs:label : has internal volume</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasInternalVolume">arp:hasInternalVolume</a>
    /// </summary>
    let hasInternalVolume = _prefixId.prefix "hasInternalVolume"
    /// <summary>
    ///   <para>rdfs:label : has lavorazione (processing)</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasLavorazione">arp:hasLavorazione</a>
    /// </summary>
    let hasLavorazione = _prefixId.prefix "hasLavorazione"
    /// <summary>
    ///   <para>rdfs:label : has length</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasLength">arp:hasLength</a>
    /// </summary>
    let hasLength = _prefixId.prefix "hasLength"
    /// <summary>
    ///   <para>rdfs:label : has litotipo</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasLitotipo">arp:hasLitotipo</a>
    /// </summary>
    let hasLitotipo = _prefixId.prefix "hasLitotipo"
    /// <summary>
    ///   <para>rdfs:label : has mass</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasMass">arp:hasMass</a>
    /// </summary>
    let hasMass = _prefixId.prefix "hasMass"
    /// <summary>
    ///   <para>rdfs:label : has maximum diameter</para>
    ///   <para>rdfs:comment : Should be Diameter^^xsd:string</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasMaxDiameter">arp:hasMaxDiameter</a>
    /// </summary>
    let hasMaxDiameter = _prefixId.prefix "hasMaxDiameter"
    /// <summary>
    ///   <para>rdfs:label : has measured point manager</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasMeasuredPointManager">arp:hasMeasuredPointManager</a>
    /// </summary>
    let hasMeasuredPointManager = _prefixId.prefix "hasMeasuredPointManager"
    /// <summary>
    ///   <para>rdfs:label : has name</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasName">arp:hasName</a>
    /// </summary>
    let hasName = _prefixId.prefix "hasName"
    /// <summary>
    ///   <para>rdfs:label : has branch number</para>
    ///   <para>rdfs:comment : manual evaluation of the Percent of necrosed part in a colony^^xsd:string</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasNbBranch">arp:hasNbBranch</a>
    /// </summary>
    let hasNbBranch = _prefixId.prefix "hasNbBranch"
    /// <summary>
    ///   <para>rdfs:label : has normalized diameter max position</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasNormalizedDiamMaxPos">arp:hasNormalizedDiamMaxPos</a>
    /// </summary>
    let hasNormalizedDiamMaxPos = _prefixId.prefix "hasNormalizedDiamMaxPos"
    /// <summary>
    ///   <para>rdfs:label : has observation</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasObservation">arp:hasObservation</a>
    /// </summary>
    let hasObservation = _prefixId.prefix "hasObservation"
    /// <summary>
    ///   <para>rdfs:label : has PPX</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasPPX">arp:hasPPX</a>
    /// </summary>
    let hasPPX = _prefixId.prefix "hasPPX"
    /// <summary>
    ///   <para>rdfs:label : has PPY</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasPPY">arp:hasPPY</a>
    /// </summary>
    let hasPPY = _prefixId.prefix "hasPPY"
    /// <summary>
    ///   <para>rdfs:label : has percent necrose</para>
    ///   <para>rdfs:comment : manual evaluation of the Percent of necrosed part in a colony^^xsd:string</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasPercentNecrose">arp:hasPercentNecrose</a>
    /// </summary>
    let hasPercentNecrose = _prefixId.prefix "hasPercentNecrose"
    /// <summary>
    ///   <para>rdfs:label : has photo manager</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasPhotoManager">arp:hasPhotoManager</a>
    /// </summary>
    let hasPhotoManager = _prefixId.prefix "hasPhotoManager"
    /// <summary>
    ///   <para>rdfs:label : has photograph</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasPhotograph">arp:hasPhotograph</a>
    /// </summary>
    let hasPhotograph = _prefixId.prefix "hasPhotograph"
    /// <summary>
    ///   <para>rdfs:label : has pixel height mm</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasPixelHeight_mm">arp:hasPixelHeight_mm</a>
    /// </summary>
    let hasPixelHeight_mm = _prefixId.prefix "hasPixelHeight_mm"
    /// <summary>
    ///   <para>rdfs:label : has pixel widht mm</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasPixelWidth_mm">arp:hasPixelWidth_mm</a>
    /// </summary>
    let hasPixelWidth_mm = _prefixId.prefix "hasPixelWidth_mm"
    /// <summary>
    ///   <para>rdfs:label : has point manager</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasPointManager">arp:hasPointManager</a>
    /// </summary>
    let hasPointManager = _prefixId.prefix "hasPointManager"
    /// <summary>
    ///   <para>rdfs:label : has ratio diameter height</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRatioDiamHeight">arp:hasRatioDiamHeight</a>
    /// </summary>
    let hasRatioDiamHeight = _prefixId.prefix "hasRatioDiamHeight"
    /// <summary>
    ///   <para>rdfs:label :  has relation is earlier than</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationAnteriorita">arp:hasRelationAnteriorita</a>
    /// </summary>
    let hasRelationAnteriorita = _prefixId.prefix "hasRelationAnteriorita"
    /// <summary>
    ///   <para>rdfs:label : has relation is leaned against</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationAppoggiatoA">arp:hasRelationAppoggiatoA</a>
    /// </summary>
    let hasRelationAppoggiatoA = _prefixId.prefix "hasRelationAppoggiatoA"
    /// <summary>
    ///   <para>rdfs:label : has relation is connected with</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationCollegatoA">arp:hasRelationCollegatoA</a>
    /// </summary>
    let hasRelationCollegatoA = _prefixId.prefix "hasRelationCollegatoA"
    /// <summary>
    ///   <para>rdfs:label :  has relation is contemporary to</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationContemporaneita">arp:hasRelationContemporaneita</a>
    /// </summary>
    let hasRelationContemporaneita = _prefixId.prefix "hasRelationContemporaneita"
    /// <summary>
    ///   <para>rdfs:label :  has relation is covered by</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationCopertoDa">arp:hasRelationCopertoDa</a>
    /// </summary>
    let hasRelationCopertoDa = _prefixId.prefix "hasRelationCopertoDa"
    /// <summary>
    ///   <para>rdfs:label :  has relation covers</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationCopre">arp:hasRelationCopre</a>
    /// </summary>
    let hasRelationCopre = _prefixId.prefix "hasRelationCopre"
    /// <summary>
    ///   <para>rdfs:label : has relation leans against a</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationGliSiAppoggia">arp:hasRelationGliSiAppoggia</a>
    /// </summary>
    let hasRelationGliSiAppoggia = _prefixId.prefix "hasRelationGliSiAppoggia"
    /// <summary>
    ///   <para>rdfs:label :  has relation is linked to</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationLegatoA">arp:hasRelationLegatoA</a>
    /// </summary>
    let hasRelationLegatoA = _prefixId.prefix "hasRelationLegatoA"
    /// <summary>
    ///   <para>rdfs:label :  has relation is later than</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationPosteriorita">arp:hasRelationPosteriorita</a>
    /// </summary>
    let hasRelationPosteriorita = _prefixId.prefix "hasRelationPosteriorita"
    /// <summary>
    ///   <para>rdfs:label :  has relation fills</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationRiempie">arp:hasRelationRiempie</a>
    /// </summary>
    let hasRelationRiempie = _prefixId.prefix "hasRelationRiempie"
    /// <summary>
    ///   <para>rdfs:label :  has relation is filled by</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationRiempitoDa">arp:hasRelationRiempitoDa</a>
    /// </summary>
    let hasRelationRiempitoDa = _prefixId.prefix "hasRelationRiempitoDa"
    /// <summary>
    ///   <para>rdfs:label :  has relation cuts</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationTaglia">arp:hasRelationTaglia</a>
    /// </summary>
    let hasRelationTaglia = _prefixId.prefix "hasRelationTaglia"
    /// <summary>
    ///   <para>rdfs:label :  has relation is cut by</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationTagliatoDa">arp:hasRelationTagliatoDa</a>
    /// </summary>
    let hasRelationTagliatoDa = _prefixId.prefix "hasRelationTagliatoDa"
    /// <summary>
    ///   <para>rdfs:label :  has relation is equal to</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationUgualeA">arp:hasRelationUgualeA</a>
    /// </summary>
    let hasRelationUgualeA = _prefixId.prefix "hasRelationUgualeA"
    /// <summary>
    ///   <para>rdfs:label : has reprojection residual</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasReprojectionResidual">arp:hasReprojectionResidual</a>
    /// </summary>
    let hasReprojectionResidual = _prefixId.prefix "hasReprojectionResidual"
    /// <summary>
    ///   <para>rdfs:label : has residual</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasResidual">arp:hasResidual</a>
    /// </summary>
    let hasResidual = _prefixId.prefix "hasResidual"
    /// <summary>
    ///   <para>rdfs:label : has residual X</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasResidualX">arp:hasResidualX</a>
    /// </summary>
    let hasResidualX = _prefixId.prefix "hasResidualX"
    /// <summary>
    ///   <para>rdfs:label : has residual Y</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasResidualY">arp:hasResidualY</a>
    /// </summary>
    let hasResidualY = _prefixId.prefix "hasResidualY"
    /// <summary>
    ///   <para>rdfs:label : has residual Z</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasResidualZ">arp:hasResidualZ</a>
    /// </summary>
    let hasResidualZ = _prefixId.prefix "hasResidualZ"
    /// <summary>
    ///   <para>rdfs:label : has rotation matrix</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRotationMatrix">arp:hasRotationMatrix</a>
    /// </summary>
    let hasRotationMatrix = _prefixId.prefix "hasRotationMatrix"
    /// <summary>
    ///   <para>rdfs:label : has scale</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasScale">arp:hasScale</a>
    /// </summary>
    let hasScale = _prefixId.prefix "hasScale"
    /// <summary>
    ///   <para>rdfs:label : has sigla</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasSigla">arp:hasSigla</a>
    /// </summary>
    let hasSigla = _prefixId.prefix "hasSigla"
    /// <summary>
    ///   <para>rdfs:label : has cityrdfs:label :  has city</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasSito">arp:hasSito</a>
    /// </summary>
    let hasSito = _prefixId.prefix "hasSito"
    /// <summary>
    ///   <para>rdfs:label : has state of conservation</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStateOfConservation">arp:hasStateOfConservation</a>
    /// </summary>
    let hasStateOfConservation = _prefixId.prefix "hasStateOfConservation"

    /// <summary>
    ///   <para>rdfs:label :  has stratigraphic relation is earlier than</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationAnteriorita">arp:hasStratigraphicRelationAnteriorita</a>
    /// </summary>
    let hasStratigraphicRelationAnteriorita =
        _prefixId.prefix "hasStratigraphicRelationAnteriorita"

    /// <summary>
    ///   <para>rdfs:label :  has stratigraphic relation is leaned against a</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationAppoggiatoA">arp:hasStratigraphicRelationAppoggiatoA</a>
    /// </summary>
    let hasStratigraphicRelationAppoggiatoA =
        _prefixId.prefix "hasStratigraphicRelationAppoggiatoA"

    /// <summary>
    ///   <para>rdfs:label :  has stratigraphic relation connects</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationCollegatoA">arp:hasStratigraphicRelationCollegatoA</a>
    /// </summary>
    let hasStratigraphicRelationCollegatoA =
        _prefixId.prefix "hasStratigraphicRelationCollegatoA"

    /// <summary>
    ///   <para>rdfs:label :  has stratigraphic relation is contemporary to</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationContemporaneita">arp:hasStratigraphicRelationContemporaneita</a>
    /// </summary>
    let hasStratigraphicRelationContemporaneita =
        _prefixId.prefix "hasStratigraphicRelationContemporaneita"

    /// <summary>
    ///   <para>rdfs:label :  has stratigraphic relation is covered by</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationCopertoDa">arp:hasStratigraphicRelationCopertoDa</a>
    /// </summary>
    let hasStratigraphicRelationCopertoDa =
        _prefixId.prefix "hasStratigraphicRelationCopertoDa"

    /// <summary>
    ///   <para>rdfs:label :  has stratigraphic relation covers</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationCopre">arp:hasStratigraphicRelationCopre</a>
    /// </summary>
    let hasStratigraphicRelationCopre = _prefixId.prefix "hasStratigraphicRelationCopre"

    /// <summary>
    ///   <para>rdfs:label :  has stratigraphic relation leans against a</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationGliSiAppoggia">arp:hasStratigraphicRelationGliSiAppoggia</a>
    /// </summary>
    let hasStratigraphicRelationGliSiAppoggia =
        _prefixId.prefix "hasStratigraphicRelationGliSiAppoggia"

    /// <summary>
    ///   <para>rdfs:label :  has stratigraphic relation is linked to</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationLegatoA">arp:hasStratigraphicRelationLegatoA</a>
    /// </summary>
    let hasStratigraphicRelationLegatoA =
        _prefixId.prefix "hasStratigraphicRelationLegatoA"

    /// <summary>
    ///   <para>rdfs:label :  has stratigraphic relation is later than</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationPosteriorita">arp:hasStratigraphicRelationPosteriorita</a>
    /// </summary>
    let hasStratigraphicRelationPosteriorita =
        _prefixId.prefix "hasStratigraphicRelationPosteriorita"

    /// <summary>
    ///   <para>rdfs:label :  has stratigraphic relation fills</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationRiempie">arp:hasStratigraphicRelationRiempie</a>
    /// </summary>
    let hasStratigraphicRelationRiempie =
        _prefixId.prefix "hasStratigraphicRelationRiempie"

    /// <summary>
    ///   <para>rdfs:label :  has stratigraphic relation is filled by</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationRiempitoDa">arp:hasStratigraphicRelationRiempitoDa</a>
    /// </summary>
    let hasStratigraphicRelationRiempitoDa =
        _prefixId.prefix "hasStratigraphicRelationRiempitoDa"

    /// <summary>
    ///   <para>rdfs:label :  has stratigraphic relation cuts</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationTaglia">arp:hasStratigraphicRelationTaglia</a>
    /// </summary>
    let hasStratigraphicRelationTaglia =
        _prefixId.prefix "hasStratigraphicRelationTaglia"

    /// <summary>
    ///   <para>rdfs:label :  has stratigraphic relation is cut by</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationTagliatoDa">arp:hasStratigraphicRelationTagliatoDa</a>
    /// </summary>
    let hasStratigraphicRelationTagliatoDa =
        _prefixId.prefix "hasStratigraphicRelationTagliatoDa"

    /// <summary>
    ///   <para>rdfs:label :  has stratigraphic relation equal to</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationUgualeA">arp:hasStratigraphicRelationUgualeA</a>
    /// </summary>
    let hasStratigraphicRelationUgualeA =
        _prefixId.prefix "hasStratigraphicRelationUgualeA"

    /// <summary>
    ///   <para>rdfs:label : has 3D transformation</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasTransformation3D">arp:hasTransformation3D</a>
    /// </summary>
    let hasTransformation3D = _prefixId.prefix "hasTransformation3D"
    /// <summary>
    ///   <para>rdfs:label : has translation</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasTranslation">arp:hasTranslation</a>
    /// </summary>
    let hasTranslation = _prefixId.prefix "hasTranslation"
    /// <summary>
    ///   <para>rdfs:label : has typology name</para>
    ///   <para>rdfs:comment : Typology name, often used to compute the paradigm filename in ply^^xsd:string</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasTypologyName">arp:hasTypologyName</a>
    /// </summary>
    let hasTypologyName = _prefixId.prefix "hasTypologyName"
    /// <summary>
    ///   <para>rdfs:label : has a stratigraphic unit</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasUnitaStratigrafica">arp:hasUnitaStratigrafica</a>
    /// </summary>
    let hasUnitaStratigrafica = _prefixId.prefix "hasUnitaStratigrafica"
    /// <summary>
    ///   <para>rdfs:label : has volume</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasVolume">arp:hasVolume</a>
    /// </summary>
    let hasVolume = _prefixId.prefix "hasVolume"
    /// <summary>
    ///   <para>rdfs:label : has width</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasWidth">arp:hasWidth</a>
    /// </summary>
    let hasWidth = _prefixId.prefix "hasWidth"
    /// <summary>
    ///   <para>rdfs:label : has width between upper handles</para>
    ///   <para>rdfs:comment : For more accuracy we take widht between upper hadles in adition to the diameter which is between down handles^^xsd:string</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasWidthBetweenUpperHandles">arp:hasWidthBetweenUpperHandles</a>
    /// </summary>
    let hasWidthBetweenUpperHandles = _prefixId.prefix "hasWidthBetweenUpperHandles"
    /// <summary>
    ///   <para>rdfs:label : has width lips</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasWidthLips">arp:hasWidthLips</a>
    /// </summary>
    let hasWidthLips = _prefixId.prefix "hasWidthLips"
    /// <summary>
    ///   <para>rdfs:label : has dimension coordinate X</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasX">arp:hasX</a>
    /// </summary>
    let hasX = _prefixId.prefix "hasX"
    /// <summary>
    ///   <para>rdfs:label : has maximal dimension coordinate X</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasXMax">arp:hasXMax</a>
    /// </summary>
    let hasXMax = _prefixId.prefix "hasXMax"
    /// <summary>
    ///   <para>rdfs:label : has minimal dimension coordinate X</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasXMin">arp:hasXMin</a>
    /// </summary>
    let hasXMin = _prefixId.prefix "hasXMin"
    /// <summary>
    ///   <para>rdfs:label : has dimension coordinate Y</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasY">arp:hasY</a>
    /// </summary>
    let hasY = _prefixId.prefix "hasY"
    /// <summary>
    ///   <para>rdfs:label : has maximal dimension coordinate Y</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasYMax">arp:hasYMax</a>
    /// </summary>
    let hasYMax = _prefixId.prefix "hasYMax"
    /// <summary>
    ///   <para>rdfs:label : has minimal dimension coordinate Y</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasYMin">arp:hasYMin</a>
    /// </summary>
    let hasYMin = _prefixId.prefix "hasYMin"
    /// <summary>
    ///   <para>rdfs:label : has dimension coordinate Z</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasZ">arp:hasZ</a>
    /// </summary>
    let hasZ = _prefixId.prefix "hasZ"
    /// <summary>
    ///   <para>rdfs:label : has maximal dimension coordinate Z</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasZMax">arp:hasZMax</a>
    /// </summary>
    let hasZMax = _prefixId.prefix "hasZMax"
    /// <summary>
    ///   <para>rdfs:label : has minimal dimension coordinate Z</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasZMin">arp:hasZMin</a>
    /// </summary>
    let hasZMin = _prefixId.prefix "hasZMin"
    /// <summary>
    ///   <para>rdfs:label : has matrix coordinate (0,0)</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#has_m00">arp:has_m00</a>
    /// </summary>
    let has_m00 = _prefixId.prefix "has_m00"
    /// <summary>
    ///   <para>rdfs:label : has matrix coordinate (0,1)</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#has_m01">arp:has_m01</a>
    /// </summary>
    let has_m01 = _prefixId.prefix "has_m01"
    /// <summary>
    ///   <para>rdfs:label : has matrix coordinate (0,2)</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#has_m02">arp:has_m02</a>
    /// </summary>
    let has_m02 = _prefixId.prefix "has_m02"
    /// <summary>
    ///   <para>rdfs:label : has matrix coordinate (1,0)</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#has_m10">arp:has_m10</a>
    /// </summary>
    let has_m10 = _prefixId.prefix "has_m10"
    /// <summary>
    ///   <para>rdfs:label : has matrix coordinate (1,1)</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#has_m11">arp:has_m11</a>
    /// </summary>
    let has_m11 = _prefixId.prefix "has_m11"
    /// <summary>
    ///   <para>rdfs:label : has matrix coordinate (1,2)</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#has_m12">arp:has_m12</a>
    /// </summary>
    let has_m12 = _prefixId.prefix "has_m12"
    /// <summary>
    ///   <para>rdfs:label : has matrix coordinate (2,0)</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#has_m20">arp:has_m20</a>
    /// </summary>
    let has_m20 = _prefixId.prefix "has_m20"
    /// <summary>
    ///   <para>rdfs:label : has matrix coordinate (2,1)</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#has_m21">arp:has_m21</a>
    /// </summary>
    let has_m21 = _prefixId.prefix "has_m21"
    /// <summary>
    ///   <para>rdfs:label : has matrix coordinate (2,2)</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#has_m22">arp:has_m22</a>
    /// </summary>
    let has_m22 = _prefixId.prefix "has_m22"
    /// <summary>
    ///   <para>rdfs:label : have a set of photograph</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#haveASetOfPhotograph">arp:haveASetOfPhotograph</a>
    /// </summary>
    let haveASetOfPhotograph = _prefixId.prefix "haveASetOfPhotograph"
    /// <summary>
    ///   <para>rdfs:label : is active</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#isActive">arp:isActive</a>
    /// </summary>
    let isActive = _prefixId.prefix "isActive"
    /// <summary>
    ///   <para>rdfs:label : is element of</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#isElementOf">arp:isElementOf</a>
    /// </summary>
    let isElementOf = _prefixId.prefix "isElementOf"
    /// <summary>
    ///   <para>rdfs:label : is extruded</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#isExtruded">arp:isExtruded</a>
    /// </summary>
    let isExtruded = _prefixId.prefix "isExtruded"
    /// <summary>
    ///   <para>rdfs:label : is extruded by</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#isExtrudedBy">arp:isExtrudedBy</a>
    /// </summary>
    let isExtrudedBy = _prefixId.prefix "isExtrudedBy"
    /// <summary>
    ///   <para>rdfs:label : is negative</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#isNegative">arp:isNegative</a>
    /// </summary>
    let isNegative = _prefixId.prefix "isNegative"
    /// <summary>
    ///   <para>rdfs:label : is observation of</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#isObservationOf">arp:isObservationOf</a>
    /// </summary>
    let isObservationOf = _prefixId.prefix "isObservationOf"
    /// <summary>
    ///   <para>rdfs:label : is photograph of</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#isPhotographOf">arp:isPhotographOf</a>
    /// </summary>
    let isPhotographOf = _prefixId.prefix "isPhotographOf"
    /// <summary>
    ///   <para>rdfs:label : is valide</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#isValid">arp:isValid</a>
    /// </summary>
    let isValid = _prefixId.prefix "isValid"
    /// <summary>
    ///   <para>rdfs:label : percent of measured</para>
    ///   <a href="http://www.arpenteur.org/ontology/Arpenteur.owl#percentOfMeasured">arp:percentOfMeasured</a>
    /// </summary>
    let percentOfMeasured = _prefixId.prefix "percentOfMeasured"

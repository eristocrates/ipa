namespace http.www.arpenteur.org.ontology.Arpenteur.owl.hash

open DoxAletheia

module arp =
    let _namespace_name = "http://www.arpenteur.org/ontology/Arpenteur.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Alcyonacea"></see>
    /// </summary>
    let Alcyonacea = _prefix "Alcyonacea"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Zoology"></see>
    /// </summary>
    let Zoology = _prefix "Zoology"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Amphorae"></see>
    /// </summary>
    let Amphorae = _prefix "Amphorae"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#RecipientTransport"></see>
    /// </summary>
    let RecipientTransport = _prefix "RecipientTransport"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Archaeology"></see>
    /// </summary>
    let Archaeology = _prefix "Archaeology"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Measurable"></see>
    /// </summary>
    let Measurable = _prefix "Measurable"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Architecture"></see>
    /// </summary>
    let Architecture = _prefix "Architecture"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#AreaFunzionale"></see>
    /// </summary>
    let AreaFunzionale = _prefix "AreaFunzionale"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#UnitaArcheologica"></see>
    /// </summary>
    let UnitaArcheologica = _prefix "UnitaArcheologica"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Artifact"></see>
    /// </summary>
    let Artifact = _prefix "Artifact"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Attivita"></see>
    /// </summary>
    let Attivita = _prefix "Attivita"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#ElementoStratigrafico"></see>
    /// </summary>
    let ElementoStratigrafico = _prefix "ElementoStratigrafico"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Bloc"></see>
    /// </summary>
    let Bloc = _prefix "Bloc"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#ElementDeParement"></see>
    /// </summary>
    let ElementDeParement = _prefix "ElementDeParement"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#BoundingBox"></see>
    /// </summary>
    let BoundingBox = _prefix "BoundingBox"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#MathematicalObject"></see>
    /// </summary>
    let MathematicalObject = _prefix "MathematicalObject"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Brique"></see>
    /// </summary>
    let Brique = _prefix "Brique"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#BundleModel"></see>
    /// </summary>
    let BundleModel = _prefix "BundleModel"
    /// <summary>
    /// This is a photogrammetric model. It contains a set of oriented photograph and a set of 3D points which are at least visible on two oriented photographs.
    /// <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Model"></see></summary>
    let Model = _prefix "Model"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Camera"></see>
    /// </summary>
    let Camera = _prefix "Camera"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Photogrammetry"></see>
    /// </summary>
    let Photogrammetry = _prefix "Photogrammetry"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#CameraManager"></see>
    /// </summary>
    let CameraManager = _prefix "CameraManager"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#GenericManager"></see>
    /// </summary>
    let GenericManager = _prefix "GenericManager"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Cassettone"></see>
    /// </summary>
    let Cassettone = _prefix "Cassettone"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#ElementDeCouverture"></see>
    /// </summary>
    let ElementDeCouverture = _prefix "ElementDeCouverture"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#ComplessoArchitettonico"></see>
    /// </summary>
    let ComplessoArchitettonico = _prefix "ComplessoArchitettonico"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#ConstraintManager"></see>
    /// </summary>
    let ConstraintManager = _prefix "ConstraintManager"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#ControlPoint"></see>
    /// </summary>
    let ControlPoint = _prefix "ControlPoint"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#IPoint3D"></see>
    /// </summary>
    let IPoint3D = _prefix "IPoint3D"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Coralliidae"></see>
    /// </summary>
    let Coralliidae = _prefix "Coralliidae"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#CoralliumRubrum"></see>
    /// </summary>
    let CoralliumRubrum = _prefix "CoralliumRubrum"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#CorpoDiFabbrica"></see>
    /// </summary>
    let CorpoDiFabbrica = _prefix "CorpoDiFabbrica"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#DigitalCamera"></see>
    /// </summary>
    let DigitalCamera = _prefix "DigitalCamera"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#FilmBasedCamera"></see>
    /// </summary>
    let FilmBasedCamera = _prefix "FilmBasedCamera"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Dolia"></see>
    /// </summary>
    let Dolia = _prefix "Dolia"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#IIdentifiedObject"></see>
    /// </summary>
    let IIdentifiedObject = _prefix "IIdentifiedObject"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Geometry"></see>
    /// </summary>
    let Geometry = _prefix "Geometry"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#GrindingStone"></see>
    /// </summary>
    let GrindingStone = _prefix "GrindingStone"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#StoneTool"></see>
    /// </summary>
    let StoneTool = _prefix "StoneTool"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#IColoredPoint"></see>
    /// </summary>
    let IColoredPoint = _prefix "IColoredPoint"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#IFixedPoint"></see>
    /// </summary>
    let IFixedPoint = _prefix "IFixedPoint"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#IPoint"></see>
    /// </summary>
    let IPoint = _prefix "IPoint"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#IPoint2D"></see>
    /// </summary>
    let IPoint2D = _prefix "IPoint2D"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#ImagePoint"></see>
    /// </summary>
    let ImagePoint = _prefix "ImagePoint"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#ImagePointManager"></see>
    /// </summary>
    let ImagePointManager = _prefix "ImagePointManager"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Point2DManager"></see>
    /// </summary>
    let Point2DManager = _prefix "Point2DManager"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Matrix"></see>
    /// </summary>
    let Matrix = _prefix "Matrix"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#SpatialObject"></see>
    /// </summary>
    let SpatialObject = _prefix "SpatialObject"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#MeasuredPointManager"></see>
    /// </summary>
    let MeasuredPointManager = _prefix "MeasuredPointManager"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Point3DManager"></see>
    /// </summary>
    let Point3DManager = _prefix "Point3DManager"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#NauticalArchaeology"></see>
    /// </summary>
    let NauticalArchaeology = _prefix "NauticalArchaeology"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Ollae"></see>
    /// </summary>
    let Ollae = _prefix "Ollae"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#PetraData"></see>
    /// </summary>
    let PetraData = _prefix "PetraData"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#PhotoManager"></see>
    /// </summary>
    let PhotoManager = _prefix "PhotoManager"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Photograph"></see>
    /// </summary>
    let Photograph = _prefix "Photograph"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#PointManager"></see>
    /// </summary>
    let PointManager = _prefix "PointManager"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Point_3D"></see>
    /// </summary>
    let Point_3D = _prefix "Point_3D"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Prospetto"></see>
    /// </summary>
    let Prospetto = _prefix "Prospetto"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#ProspettoGenerale"></see>
    /// </summary>
    let ProspettoGenerale = _prefix "ProspettoGenerale"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#ProspettoParticolare"></see>
    /// </summary>
    let ProspettoParticolare = _prefix "ProspettoParticolare"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#RadialDecenteringDistortion"></see>
    /// </summary>
    let RadialDecenteringDistortion = _prefix "RadialDecenteringDistortion"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#RotationMatrix"></see>
    /// </summary>
    let RotationMatrix = _prefix "RotationMatrix"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRotationMatrix"></see>
    /// </summary>
    let hasRotationMatrix = _prefix "hasRotationMatrix"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Transformation3D"></see>
    /// </summary>
    let Transformation3D = _prefix "Transformation3D"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#SitiList"></see>
    /// </summary>
    let SitiList = _prefix "SitiList"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Sito"></see>
    /// </summary>
    let Sito = _prefix "Sito"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#SpatialLocalization"></see>
    /// </summary>
    let SpatialLocalization = _prefix "SpatialLocalization"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Subergorgia"></see>
    /// </summary>
    let Subergorgia = _prefix "Subergorgia"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#TriangleManager"></see>
    /// </summary>
    let TriangleManager = _prefix "TriangleManager"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Tuile"></see>
    /// </summary>
    let Tuile = _prefix "Tuile"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#TuileRonde"></see>
    /// </summary>
    let TuileRonde = _prefix "TuileRonde"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#UnitaFunzionale"></see>
    /// </summary>
    let UnitaFunzionale = _prefix "UnitaFunzionale"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#UnitaStratigrafica"></see>
    /// </summary>
    let UnitaStratigrafica = _prefix "UnitaStratigrafica"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#UnitaStratigraficaMurale"></see>
    /// </summary>
    let UnitaStratigraficaMurale = _prefix "UnitaStratigraficaMurale"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#UnitaTopografica"></see>
    /// </summary>
    let UnitaTopografica = _prefix "UnitaTopografica"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#belongToUSM"></see>
    /// </summary>
    let belongToUSM = _prefix "belongToUSM"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasASetOf3DPoint"></see>
    /// </summary>
    let hasASetOf3DPoint = _prefix "hasASetOf3DPoint"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasASetOf3DPointWithObs"></see>
    /// </summary>
    let hasASetOf3DPointWithObs = _prefix "hasASetOf3DPointWithObs"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasASetOfCA"></see>
    /// </summary>
    let hasASetOfCA = _prefix "hasASetOfCA"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasASetOfCF"></see>
    /// </summary>
    let hasASetOfCF = _prefix "hasASetOfCF"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasASetOfCamera"></see>
    /// </summary>
    let hasASetOfCamera = _prefix "hasASetOfCamera"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasASetOfObservation"></see>
    /// </summary>
    let hasASetOfObservation = _prefix "hasASetOfObservation"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasASetOfPP"></see>
    /// </summary>
    let hasASetOfPP = _prefix "hasASetOfPP"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasASetOfSiti"></see>
    /// </summary>
    let hasASetOfSiti = _prefix "hasASetOfSiti"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#ManagerCA"></see>
    /// </summary>
    let ManagerCA = _prefix "ManagerCA"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasASetOfSito"></see>
    /// </summary>
    let hasASetOfSito = _prefix "hasASetOfSito"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasASetOfUS"></see>
    /// </summary>
    let hasASetOfUS = _prefix "hasASetOfUS"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasASetOfUT"></see>
    /// </summary>
    let hasASetOfUT = _prefix "hasASetOfUT"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasBellyDiameter"></see>
    /// </summary>
    let hasBellyDiameter = _prefix "hasBellyDiameter"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasBoundingBox"></see>
    /// </summary>
    let hasBoundingBox = _prefix "hasBoundingBox"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasCA"></see>
    /// </summary>
    let hasCA = _prefix "hasCA"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasCF"></see>
    /// </summary>
    let hasCF = _prefix "hasCF"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasCamera"></see>
    /// </summary>
    let hasCamera = _prefix "hasCamera"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasCameraManager"></see>
    /// </summary>
    let hasCameraManager = _prefix "hasCameraManager"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasCenter"></see>
    /// </summary>
    let hasCenter = _prefix "hasCenter"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasCoef_K1"></see>
    /// </summary>
    let hasCoef_K1 = _prefix "hasCoef_K1"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasCoef_K2"></see>
    /// </summary>
    let hasCoef_K2 = _prefix "hasCoef_K2"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasCoef_K3"></see>
    /// </summary>
    let hasCoef_K3 = _prefix "hasCoef_K3"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasCoef_K4"></see>
    /// </summary>
    let hasCoef_K4 = _prefix "hasCoef_K4"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasCoef_P1"></see>
    /// </summary>
    let hasCoef_P1 = _prefix "hasCoef_P1"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasCoef_P2"></see>
    /// </summary>
    let hasCoef_P2 = _prefix "hasCoef_P2"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasColor_B"></see>
    /// </summary>
    let hasColor_B = _prefix "hasColor_B"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasColor_G"></see>
    /// </summary>
    let hasColor_G = _prefix "hasColor_G"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasColor_R"></see>
    /// </summary>
    let hasColor_R = _prefix "hasColor_R"
    /// <summary>
    /// manual evaluation of the Percent of necrosed part in a colony
    /// <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasComment"></see></summary>
    let hasComment = _prefix "hasComment"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasCorrelationCoef"></see>
    /// </summary>
    let hasCorrelationCoef = _prefix "hasCorrelationCoef"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasData"></see>
    /// </summary>
    let hasData = _prefix "hasData"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasDefinition"></see>
    /// </summary>
    let hasDefinition = _prefix "hasDefinition"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasDescription"></see>
    /// </summary>
    let hasDescription = _prefix "hasDescription"
    /// <summary>
    /// Should be max Diameter
    /// <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasDiameter"></see></summary>
    let hasDiameter = _prefix "hasDiameter"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasDiameterNeck"></see>
    /// </summary>
    let hasDiameterNeck = _prefix "hasDiameterNeck"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasDiameterSupport"></see>
    /// </summary>
    let hasDiameterSupport = _prefix "hasDiameterSupport"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasDirettore"></see>
    /// </summary>
    let hasDirettore = _prefix "hasDirettore"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasDistanceHandles"></see>
    /// </summary>
    let hasDistanceHandles = _prefix "hasDistanceHandles"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasDistortion"></see>
    /// </summary>
    let hasDistortion = _prefix "hasDistortion"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasExtrudeDepth"></see>
    /// </summary>
    let hasExtrudeDepth = _prefix "hasExtrudeDepth"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasExtrudedData1"></see>
    /// </summary>
    let hasExtrudedData1 = _prefix "hasExtrudedData1"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasExtrudedData2"></see>
    /// </summary>
    let hasExtrudedData2 = _prefix "hasExtrudedData2"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasExtrudedPt1X"></see>
    /// </summary>
    let hasExtrudedPt1X = _prefix "hasExtrudedPt1X"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasExtrudedPt1Y"></see>
    /// </summary>
    let hasExtrudedPt1Y = _prefix "hasExtrudedPt1Y"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasExtrudedPt1Z"></see>
    /// </summary>
    let hasExtrudedPt1Z = _prefix "hasExtrudedPt1Z"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasExtrudedPt2X"></see>
    /// </summary>
    let hasExtrudedPt2X = _prefix "hasExtrudedPt2X"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasExtrudedPt2Y"></see>
    /// </summary>
    let hasExtrudedPt2Y = _prefix "hasExtrudedPt2Y"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasExtrudedPt2Z"></see>
    /// </summary>
    let hasExtrudedPt2Z = _prefix "hasExtrudedPt2Z"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasFinitura"></see>
    /// </summary>
    let hasFinitura = _prefix "hasFinitura"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasFocalLength"></see>
    /// </summary>
    let hasFocalLength = _prefix "hasFocalLength"
    /// <summary>
    /// manual evaluation of the Percent of necrosed part in a colony
    /// <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasFootDiameter"></see></summary>
    let hasFootDiameter = _prefix "hasFootDiameter"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasFrameHeigthInPixel"></see>
    /// </summary>
    let hasFrameHeigthInPixel = _prefix "hasFrameHeigthInPixel"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasFrameHeigthInmm"></see>
    /// </summary>
    let hasFrameHeigthInmm = _prefix "hasFrameHeigthInmm"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasFrameWidthInPixel"></see>
    /// </summary>
    let hasFrameWidthInPixel = _prefix "hasFrameWidthInPixel"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasFrameWidthInmm"></see>
    /// </summary>
    let hasFrameWidthInmm = _prefix "hasFrameWidthInmm"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasFullFileName"></see>
    /// </summary>
    let hasFullFileName = _prefix "hasFullFileName"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasHandlesWidth"></see>
    /// </summary>
    let hasHandlesWidth = _prefix "hasHandlesWidth"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasHeight"></see>
    /// </summary>
    let hasHeight = _prefix "hasHeight"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasHeightLips"></see>
    /// </summary>
    let hasHeightLips = _prefix "hasHeightLips"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasId"></see>
    /// </summary>
    let hasId = _prefix "hasId"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasIdn"></see>
    /// </summary>
    let hasIdn = _prefix "hasIdn"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasImagePointManager"></see>
    /// </summary>
    let hasImagePointManager = _prefix "hasImagePointManager"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasInternalVolume"></see>
    /// </summary>
    let hasInternalVolume = _prefix "hasInternalVolume"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasLavorazione"></see>
    /// </summary>
    let hasLavorazione = _prefix "hasLavorazione"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasLength"></see>
    /// </summary>
    let hasLength = _prefix "hasLength"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasLitotipo"></see>
    /// </summary>
    let hasLitotipo = _prefix "hasLitotipo"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasMass"></see>
    /// </summary>
    let hasMass = _prefix "hasMass"
    /// <summary>
    /// Should be Diameter
    /// <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasMaxDiameter"></see></summary>
    let hasMaxDiameter = _prefix "hasMaxDiameter"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasMeasuredPointManager"></see>
    /// </summary>
    let hasMeasuredPointManager = _prefix "hasMeasuredPointManager"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasName"></see>
    /// </summary>
    let hasName = _prefix "hasName"
    /// <summary>
    /// manual evaluation of the Percent of necrosed part in a colony
    /// <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasNbBranch"></see></summary>
    let hasNbBranch = _prefix "hasNbBranch"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasNormalizedDiamMaxPos"></see>
    /// </summary>
    let hasNormalizedDiamMaxPos = _prefix "hasNormalizedDiamMaxPos"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasObservation"></see>
    /// </summary>
    let hasObservation = _prefix "hasObservation"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasPPX"></see>
    /// </summary>
    let hasPPX = _prefix "hasPPX"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasPPY"></see>
    /// </summary>
    let hasPPY = _prefix "hasPPY"
    /// <summary>
    /// manual evaluation of the Percent of necrosed part in a colony
    /// <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasPercentNecrose"></see></summary>
    let hasPercentNecrose = _prefix "hasPercentNecrose"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasPhotoManager"></see>
    /// </summary>
    let hasPhotoManager = _prefix "hasPhotoManager"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasPhotograph"></see>
    /// </summary>
    let hasPhotograph = _prefix "hasPhotograph"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasPixelHeight_mm"></see>
    /// </summary>
    let hasPixelHeight_mm = _prefix "hasPixelHeight_mm"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasPixelWidth_mm"></see>
    /// </summary>
    let hasPixelWidth_mm = _prefix "hasPixelWidth_mm"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasPointManager"></see>
    /// </summary>
    let hasPointManager = _prefix "hasPointManager"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRatioDiamHeight"></see>
    /// </summary>
    let hasRatioDiamHeight = _prefix "hasRatioDiamHeight"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationAnteriorita"></see>
    /// </summary>
    let hasRelationAnteriorita = _prefix "hasRelationAnteriorita"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationAppoggiatoA"></see>
    /// </summary>
    let hasRelationAppoggiatoA = _prefix "hasRelationAppoggiatoA"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationCollegatoA"></see>
    /// </summary>
    let hasRelationCollegatoA = _prefix "hasRelationCollegatoA"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationContemporaneita"></see>
    /// </summary>
    let hasRelationContemporaneita = _prefix "hasRelationContemporaneita"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationCopertoDa"></see>
    /// </summary>
    let hasRelationCopertoDa = _prefix "hasRelationCopertoDa"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationCopre"></see>
    /// </summary>
    let hasRelationCopre = _prefix "hasRelationCopre"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationGliSiAppoggia"></see>
    /// </summary>
    let hasRelationGliSiAppoggia = _prefix "hasRelationGliSiAppoggia"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationLegatoA"></see>
    /// </summary>
    let hasRelationLegatoA = _prefix "hasRelationLegatoA"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationPosteriorita"></see>
    /// </summary>
    let hasRelationPosteriorita = _prefix "hasRelationPosteriorita"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationRiempie"></see>
    /// </summary>
    let hasRelationRiempie = _prefix "hasRelationRiempie"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationRiempitoDa"></see>
    /// </summary>
    let hasRelationRiempitoDa = _prefix "hasRelationRiempitoDa"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationTaglia"></see>
    /// </summary>
    let hasRelationTaglia = _prefix "hasRelationTaglia"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationTagliatoDa"></see>
    /// </summary>
    let hasRelationTagliatoDa = _prefix "hasRelationTagliatoDa"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationUgualeA"></see>
    /// </summary>
    let hasRelationUgualeA = _prefix "hasRelationUgualeA"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasReprojectionResidual"></see>
    /// </summary>
    let hasReprojectionResidual = _prefix "hasReprojectionResidual"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasResidual"></see>
    /// </summary>
    let hasResidual = _prefix "hasResidual"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasResidualX"></see>
    /// </summary>
    let hasResidualX = _prefix "hasResidualX"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasResidualY"></see>
    /// </summary>
    let hasResidualY = _prefix "hasResidualY"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasResidualZ"></see>
    /// </summary>
    let hasResidualZ = _prefix "hasResidualZ"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasScale"></see>
    /// </summary>
    let hasScale = _prefix "hasScale"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasSigla"></see>
    /// </summary>
    let hasSigla = _prefix "hasSigla"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasSito"></see>
    /// </summary>
    let hasSito = _prefix "hasSito"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStateOfConservation"></see>
    /// </summary>
    let hasStateOfConservation = _prefix "hasStateOfConservation"

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationAnteriorita"></see>
    /// </summary>
    let hasStratigraphicRelationAnteriorita =
        _prefix "hasStratigraphicRelationAnteriorita"

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationAppoggiatoA"></see>
    /// </summary>
    let hasStratigraphicRelationAppoggiatoA =
        _prefix "hasStratigraphicRelationAppoggiatoA"

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationCollegatoA"></see>
    /// </summary>
    let hasStratigraphicRelationCollegatoA =
        _prefix "hasStratigraphicRelationCollegatoA"

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationContemporaneita"></see>
    /// </summary>
    let hasStratigraphicRelationContemporaneita =
        _prefix "hasStratigraphicRelationContemporaneita"

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationCopertoDa"></see>
    /// </summary>
    let hasStratigraphicRelationCopertoDa = _prefix "hasStratigraphicRelationCopertoDa"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationCopre"></see>
    /// </summary>
    let hasStratigraphicRelationCopre = _prefix "hasStratigraphicRelationCopre"

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationGliSiAppoggia"></see>
    /// </summary>
    let hasStratigraphicRelationGliSiAppoggia =
        _prefix "hasStratigraphicRelationGliSiAppoggia"

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationLegatoA"></see>
    /// </summary>
    let hasStratigraphicRelationLegatoA = _prefix "hasStratigraphicRelationLegatoA"

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationPosteriorita"></see>
    /// </summary>
    let hasStratigraphicRelationPosteriorita =
        _prefix "hasStratigraphicRelationPosteriorita"

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationRiempie"></see>
    /// </summary>
    let hasStratigraphicRelationRiempie = _prefix "hasStratigraphicRelationRiempie"

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationRiempitoDa"></see>
    /// </summary>
    let hasStratigraphicRelationRiempitoDa =
        _prefix "hasStratigraphicRelationRiempitoDa"

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationTaglia"></see>
    /// </summary>
    let hasStratigraphicRelationTaglia = _prefix "hasStratigraphicRelationTaglia"

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationTagliatoDa"></see>
    /// </summary>
    let hasStratigraphicRelationTagliatoDa =
        _prefix "hasStratigraphicRelationTagliatoDa"

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationUgualeA"></see>
    /// </summary>
    let hasStratigraphicRelationUgualeA = _prefix "hasStratigraphicRelationUgualeA"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasTransformation3D"></see>
    /// </summary>
    let hasTransformation3D = _prefix "hasTransformation3D"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasTranslation"></see>
    /// </summary>
    let hasTranslation = _prefix "hasTranslation"
    /// <summary>
    /// Typology name, often used to compute the paradigm filename in ply
    /// <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasTypologyName"></see></summary>
    let hasTypologyName = _prefix "hasTypologyName"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasUnitaStratigrafica"></see>
    /// </summary>
    let hasUnitaStratigrafica = _prefix "hasUnitaStratigrafica"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasVolume"></see>
    /// </summary>
    let hasVolume = _prefix "hasVolume"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasWidth"></see>
    /// </summary>
    let hasWidth = _prefix "hasWidth"
    /// <summary>
    /// For more accuracy we take widht between upper hadles in adition to the diameter which is between down handles
    /// <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasWidthBetweenUpperHandles"></see></summary>
    let hasWidthBetweenUpperHandles = _prefix "hasWidthBetweenUpperHandles"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasWidthLips"></see>
    /// </summary>
    let hasWidthLips = _prefix "hasWidthLips"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasX"></see>
    /// </summary>
    let hasX = _prefix "hasX"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasXMax"></see>
    /// </summary>
    let hasXMax = _prefix "hasXMax"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasXMin"></see>
    /// </summary>
    let hasXMin = _prefix "hasXMin"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasY"></see>
    /// </summary>
    let hasY = _prefix "hasY"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasYMax"></see>
    /// </summary>
    let hasYMax = _prefix "hasYMax"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasYMin"></see>
    /// </summary>
    let hasYMin = _prefix "hasYMin"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasZ"></see>
    /// </summary>
    let hasZ = _prefix "hasZ"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasZMax"></see>
    /// </summary>
    let hasZMax = _prefix "hasZMax"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasZMin"></see>
    /// </summary>
    let hasZMin = _prefix "hasZMin"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#has_m00"></see>
    /// </summary>
    let has_m00 = _prefix "has_m00"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#has_m01"></see>
    /// </summary>
    let has_m01 = _prefix "has_m01"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#has_m02"></see>
    /// </summary>
    let has_m02 = _prefix "has_m02"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#has_m10"></see>
    /// </summary>
    let has_m10 = _prefix "has_m10"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#has_m11"></see>
    /// </summary>
    let has_m11 = _prefix "has_m11"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#has_m12"></see>
    /// </summary>
    let has_m12 = _prefix "has_m12"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#has_m20"></see>
    /// </summary>
    let has_m20 = _prefix "has_m20"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#has_m21"></see>
    /// </summary>
    let has_m21 = _prefix "has_m21"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#has_m22"></see>
    /// </summary>
    let has_m22 = _prefix "has_m22"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#haveASetOfPhotograph"></see>
    /// </summary>
    let haveASetOfPhotograph = _prefix "haveASetOfPhotograph"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#isActive"></see>
    /// </summary>
    let isActive = _prefix "isActive"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#isElementOf"></see>
    /// </summary>
    let isElementOf = _prefix "isElementOf"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#isExtruded"></see>
    /// </summary>
    let isExtruded = _prefix "isExtruded"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#isExtrudedBy"></see>
    /// </summary>
    let isExtrudedBy = _prefix "isExtrudedBy"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#isNegative"></see>
    /// </summary>
    let isNegative = _prefix "isNegative"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#isObservationOf"></see>
    /// </summary>
    let isObservationOf = _prefix "isObservationOf"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#isPhotographOf"></see>
    /// </summary>
    let isPhotographOf = _prefix "isPhotographOf"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#isValid"></see>
    /// </summary>
    let isValid = _prefix "isValid"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#percentOfMeasured"></see>
    /// </summary>
    let percentOfMeasured = _prefix "percentOfMeasured"

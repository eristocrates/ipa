namespace http.www.arpenteur.org.ontology.Arpenteur.owl.hash

open DoxAletheia.Rdf_Vocabulary

module arp =
    let _namespace_name = "http://www.arpenteur.org/ontology/Arpenteur.owl#"
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Alcyonacea"></see>
    /// </summary>
    let Alcyonacea = Namespaced_IRI.parse _namespace_name "Alcyonacea" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Zoology"></see>
    /// </summary>
    let Zoology = Namespaced_IRI.parse _namespace_name "Zoology" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Amphorae"></see>
    /// </summary>
    let Amphorae = Namespaced_IRI.parse _namespace_name "Amphorae" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#RecipientTransport"></see>
    /// </summary>
    let RecipientTransport =
        Namespaced_IRI.parse _namespace_name "RecipientTransport" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Archaeology"></see>
    /// </summary>
    let Archaeology =
        Namespaced_IRI.parse _namespace_name "Archaeology" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Measurable"></see>
    /// </summary>
    let Measurable = Namespaced_IRI.parse _namespace_name "Measurable" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Architecture"></see>
    /// </summary>
    let Architecture =
        Namespaced_IRI.parse _namespace_name "Architecture" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#AreaFunzionale"></see>
    /// </summary>
    let AreaFunzionale =
        Namespaced_IRI.parse _namespace_name "AreaFunzionale" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#UnitaArcheologica"></see>
    /// </summary>
    let UnitaArcheologica =
        Namespaced_IRI.parse _namespace_name "UnitaArcheologica" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Artifact"></see>
    /// </summary>
    let Artifact = Namespaced_IRI.parse _namespace_name "Artifact" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Attivita"></see>
    /// </summary>
    let Attivita = Namespaced_IRI.parse _namespace_name "Attivita" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#ElementoStratigrafico"></see>
    /// </summary>
    let ElementoStratigrafico =
        Namespaced_IRI.parse _namespace_name "ElementoStratigrafico" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Bloc"></see>
    /// </summary>
    let Bloc = Namespaced_IRI.parse _namespace_name "Bloc" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#ElementDeParement"></see>
    /// </summary>
    let ElementDeParement =
        Namespaced_IRI.parse _namespace_name "ElementDeParement" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#BoundingBox"></see>
    /// </summary>
    let BoundingBox =
        Namespaced_IRI.parse _namespace_name "BoundingBox" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#MathematicalObject"></see>
    /// </summary>
    let MathematicalObject =
        Namespaced_IRI.parse _namespace_name "MathematicalObject" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Brique"></see>
    /// </summary>
    let Brique = Namespaced_IRI.parse _namespace_name "Brique" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#BundleModel"></see>
    /// </summary>
    let BundleModel =
        Namespaced_IRI.parse _namespace_name "BundleModel" |> NamespacedName

    /// <summary>
    /// This is a photogrammetric model. It contains a set of oriented photograph and a set of 3D points which are at least visible on two oriented photographs.
    /// <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Model"></see></summary>
    let Model = Namespaced_IRI.parse _namespace_name "Model" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Camera"></see>
    /// </summary>
    let Camera = Namespaced_IRI.parse _namespace_name "Camera" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Photogrammetry"></see>
    /// </summary>
    let Photogrammetry =
        Namespaced_IRI.parse _namespace_name "Photogrammetry" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#CameraManager"></see>
    /// </summary>
    let CameraManager =
        Namespaced_IRI.parse _namespace_name "CameraManager" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#GenericManager"></see>
    /// </summary>
    let GenericManager =
        Namespaced_IRI.parse _namespace_name "GenericManager" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Cassettone"></see>
    /// </summary>
    let Cassettone = Namespaced_IRI.parse _namespace_name "Cassettone" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#ElementDeCouverture"></see>
    /// </summary>
    let ElementDeCouverture =
        Namespaced_IRI.parse _namespace_name "ElementDeCouverture" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#ComplessoArchitettonico"></see>
    /// </summary>
    let ComplessoArchitettonico =
        Namespaced_IRI.parse _namespace_name "ComplessoArchitettonico" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#ConstraintManager"></see>
    /// </summary>
    let ConstraintManager =
        Namespaced_IRI.parse _namespace_name "ConstraintManager" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#ControlPoint"></see>
    /// </summary>
    let ControlPoint =
        Namespaced_IRI.parse _namespace_name "ControlPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#IPoint3D"></see>
    /// </summary>
    let IPoint3D = Namespaced_IRI.parse _namespace_name "IPoint3D" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Coralliidae"></see>
    /// </summary>
    let Coralliidae =
        Namespaced_IRI.parse _namespace_name "Coralliidae" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#CoralliumRubrum"></see>
    /// </summary>
    let CoralliumRubrum =
        Namespaced_IRI.parse _namespace_name "CoralliumRubrum" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#CorpoDiFabbrica"></see>
    /// </summary>
    let CorpoDiFabbrica =
        Namespaced_IRI.parse _namespace_name "CorpoDiFabbrica" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#DigitalCamera"></see>
    /// </summary>
    let DigitalCamera =
        Namespaced_IRI.parse _namespace_name "DigitalCamera" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#FilmBasedCamera"></see>
    /// </summary>
    let FilmBasedCamera =
        Namespaced_IRI.parse _namespace_name "FilmBasedCamera" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Dolia"></see>
    /// </summary>
    let Dolia = Namespaced_IRI.parse _namespace_name "Dolia" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#IIdentifiedObject"></see>
    /// </summary>
    let IIdentifiedObject =
        Namespaced_IRI.parse _namespace_name "IIdentifiedObject" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Geometry"></see>
    /// </summary>
    let Geometry = Namespaced_IRI.parse _namespace_name "Geometry" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#GrindingStone"></see>
    /// </summary>
    let GrindingStone =
        Namespaced_IRI.parse _namespace_name "GrindingStone" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#StoneTool"></see>
    /// </summary>
    let StoneTool = Namespaced_IRI.parse _namespace_name "StoneTool" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#IColoredPoint"></see>
    /// </summary>
    let IColoredPoint =
        Namespaced_IRI.parse _namespace_name "IColoredPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#IFixedPoint"></see>
    /// </summary>
    let IFixedPoint =
        Namespaced_IRI.parse _namespace_name "IFixedPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#IPoint"></see>
    /// </summary>
    let IPoint = Namespaced_IRI.parse _namespace_name "IPoint" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#IPoint2D"></see>
    /// </summary>
    let IPoint2D = Namespaced_IRI.parse _namespace_name "IPoint2D" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#ImagePoint"></see>
    /// </summary>
    let ImagePoint = Namespaced_IRI.parse _namespace_name "ImagePoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#ImagePointManager"></see>
    /// </summary>
    let ImagePointManager =
        Namespaced_IRI.parse _namespace_name "ImagePointManager" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Point2DManager"></see>
    /// </summary>
    let Point2DManager =
        Namespaced_IRI.parse _namespace_name "Point2DManager" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Matrix"></see>
    /// </summary>
    let Matrix = Namespaced_IRI.parse _namespace_name "Matrix" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#SpatialObject"></see>
    /// </summary>
    let SpatialObject =
        Namespaced_IRI.parse _namespace_name "SpatialObject" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#MeasuredPointManager"></see>
    /// </summary>
    let MeasuredPointManager =
        Namespaced_IRI.parse _namespace_name "MeasuredPointManager" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Point3DManager"></see>
    /// </summary>
    let Point3DManager =
        Namespaced_IRI.parse _namespace_name "Point3DManager" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#NauticalArchaeology"></see>
    /// </summary>
    let NauticalArchaeology =
        Namespaced_IRI.parse _namespace_name "NauticalArchaeology" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Ollae"></see>
    /// </summary>
    let Ollae = Namespaced_IRI.parse _namespace_name "Ollae" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#PetraData"></see>
    /// </summary>
    let PetraData = Namespaced_IRI.parse _namespace_name "PetraData" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#PhotoManager"></see>
    /// </summary>
    let PhotoManager =
        Namespaced_IRI.parse _namespace_name "PhotoManager" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Photograph"></see>
    /// </summary>
    let Photograph = Namespaced_IRI.parse _namespace_name "Photograph" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#PointManager"></see>
    /// </summary>
    let PointManager =
        Namespaced_IRI.parse _namespace_name "PointManager" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Point_3D"></see>
    /// </summary>
    let Point_3D = Namespaced_IRI.parse _namespace_name "Point_3D" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Prospetto"></see>
    /// </summary>
    let Prospetto = Namespaced_IRI.parse _namespace_name "Prospetto" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#ProspettoGenerale"></see>
    /// </summary>
    let ProspettoGenerale =
        Namespaced_IRI.parse _namespace_name "ProspettoGenerale" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#ProspettoParticolare"></see>
    /// </summary>
    let ProspettoParticolare =
        Namespaced_IRI.parse _namespace_name "ProspettoParticolare" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#RadialDecenteringDistortion"></see>
    /// </summary>
    let RadialDecenteringDistortion =
        Namespaced_IRI.parse _namespace_name "RadialDecenteringDistortion" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#RotationMatrix"></see>
    /// </summary>
    let RotationMatrix =
        Namespaced_IRI.parse _namespace_name "RotationMatrix" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRotationMatrix"></see>
    /// </summary>
    let hasRotationMatrix =
        Namespaced_IRI.parse _namespace_name "hasRotationMatrix" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Transformation3D"></see>
    /// </summary>
    let Transformation3D =
        Namespaced_IRI.parse _namespace_name "Transformation3D" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#SitiList"></see>
    /// </summary>
    let SitiList = Namespaced_IRI.parse _namespace_name "SitiList" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Sito"></see>
    /// </summary>
    let Sito = Namespaced_IRI.parse _namespace_name "Sito" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#SpatialLocalization"></see>
    /// </summary>
    let SpatialLocalization =
        Namespaced_IRI.parse _namespace_name "SpatialLocalization" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Subergorgia"></see>
    /// </summary>
    let Subergorgia =
        Namespaced_IRI.parse _namespace_name "Subergorgia" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#TriangleManager"></see>
    /// </summary>
    let TriangleManager =
        Namespaced_IRI.parse _namespace_name "TriangleManager" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#Tuile"></see>
    /// </summary>
    let Tuile = Namespaced_IRI.parse _namespace_name "Tuile" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#TuileRonde"></see>
    /// </summary>
    let TuileRonde = Namespaced_IRI.parse _namespace_name "TuileRonde" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#UnitaFunzionale"></see>
    /// </summary>
    let UnitaFunzionale =
        Namespaced_IRI.parse _namespace_name "UnitaFunzionale" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#UnitaStratigrafica"></see>
    /// </summary>
    let UnitaStratigrafica =
        Namespaced_IRI.parse _namespace_name "UnitaStratigrafica" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#UnitaStratigraficaMurale"></see>
    /// </summary>
    let UnitaStratigraficaMurale =
        Namespaced_IRI.parse _namespace_name "UnitaStratigraficaMurale" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#UnitaTopografica"></see>
    /// </summary>
    let UnitaTopografica =
        Namespaced_IRI.parse _namespace_name "UnitaTopografica" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#belongToUSM"></see>
    /// </summary>
    let belongToUSM =
        Namespaced_IRI.parse _namespace_name "belongToUSM" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasASetOf3DPoint"></see>
    /// </summary>
    let hasASetOf3DPoint =
        Namespaced_IRI.parse _namespace_name "hasASetOf3DPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasASetOf3DPointWithObs"></see>
    /// </summary>
    let hasASetOf3DPointWithObs =
        Namespaced_IRI.parse _namespace_name "hasASetOf3DPointWithObs" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasASetOfCA"></see>
    /// </summary>
    let hasASetOfCA =
        Namespaced_IRI.parse _namespace_name "hasASetOfCA" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasASetOfCF"></see>
    /// </summary>
    let hasASetOfCF =
        Namespaced_IRI.parse _namespace_name "hasASetOfCF" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasASetOfCamera"></see>
    /// </summary>
    let hasASetOfCamera =
        Namespaced_IRI.parse _namespace_name "hasASetOfCamera" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasASetOfObservation"></see>
    /// </summary>
    let hasASetOfObservation =
        Namespaced_IRI.parse _namespace_name "hasASetOfObservation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasASetOfPP"></see>
    /// </summary>
    let hasASetOfPP =
        Namespaced_IRI.parse _namespace_name "hasASetOfPP" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasASetOfSiti"></see>
    /// </summary>
    let hasASetOfSiti =
        Namespaced_IRI.parse _namespace_name "hasASetOfSiti" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#ManagerCA"></see>
    /// </summary>
    let ManagerCA = Namespaced_IRI.parse _namespace_name "ManagerCA" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasASetOfSito"></see>
    /// </summary>
    let hasASetOfSito =
        Namespaced_IRI.parse _namespace_name "hasASetOfSito" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasASetOfUS"></see>
    /// </summary>
    let hasASetOfUS =
        Namespaced_IRI.parse _namespace_name "hasASetOfUS" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasASetOfUT"></see>
    /// </summary>
    let hasASetOfUT =
        Namespaced_IRI.parse _namespace_name "hasASetOfUT" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasBellyDiameter"></see>
    /// </summary>
    let hasBellyDiameter =
        Namespaced_IRI.parse _namespace_name "hasBellyDiameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasBoundingBox"></see>
    /// </summary>
    let hasBoundingBox =
        Namespaced_IRI.parse _namespace_name "hasBoundingBox" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasCA"></see>
    /// </summary>
    let hasCA = Namespaced_IRI.parse _namespace_name "hasCA" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasCF"></see>
    /// </summary>
    let hasCF = Namespaced_IRI.parse _namespace_name "hasCF" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasCamera"></see>
    /// </summary>
    let hasCamera = Namespaced_IRI.parse _namespace_name "hasCamera" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasCameraManager"></see>
    /// </summary>
    let hasCameraManager =
        Namespaced_IRI.parse _namespace_name "hasCameraManager" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasCenter"></see>
    /// </summary>
    let hasCenter = Namespaced_IRI.parse _namespace_name "hasCenter" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasCoef_K1"></see>
    /// </summary>
    let hasCoef_K1 = Namespaced_IRI.parse _namespace_name "hasCoef_K1" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasCoef_K2"></see>
    /// </summary>
    let hasCoef_K2 = Namespaced_IRI.parse _namespace_name "hasCoef_K2" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasCoef_K3"></see>
    /// </summary>
    let hasCoef_K3 = Namespaced_IRI.parse _namespace_name "hasCoef_K3" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasCoef_K4"></see>
    /// </summary>
    let hasCoef_K4 = Namespaced_IRI.parse _namespace_name "hasCoef_K4" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasCoef_P1"></see>
    /// </summary>
    let hasCoef_P1 = Namespaced_IRI.parse _namespace_name "hasCoef_P1" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasCoef_P2"></see>
    /// </summary>
    let hasCoef_P2 = Namespaced_IRI.parse _namespace_name "hasCoef_P2" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasColor_B"></see>
    /// </summary>
    let hasColor_B = Namespaced_IRI.parse _namespace_name "hasColor_B" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasColor_G"></see>
    /// </summary>
    let hasColor_G = Namespaced_IRI.parse _namespace_name "hasColor_G" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasColor_R"></see>
    /// </summary>
    let hasColor_R = Namespaced_IRI.parse _namespace_name "hasColor_R" |> NamespacedName
    /// <summary>
    /// manual evaluation of the Percent of necrosed part in a colony
    /// <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasComment"></see></summary>
    let hasComment = Namespaced_IRI.parse _namespace_name "hasComment" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasCorrelationCoef"></see>
    /// </summary>
    let hasCorrelationCoef =
        Namespaced_IRI.parse _namespace_name "hasCorrelationCoef" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasData"></see>
    /// </summary>
    let hasData = Namespaced_IRI.parse _namespace_name "hasData" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasDefinition"></see>
    /// </summary>
    let hasDefinition =
        Namespaced_IRI.parse _namespace_name "hasDefinition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasDescription"></see>
    /// </summary>
    let hasDescription =
        Namespaced_IRI.parse _namespace_name "hasDescription" |> NamespacedName

    /// <summary>
    /// Should be max Diameter
    /// <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasDiameter"></see></summary>
    let hasDiameter =
        Namespaced_IRI.parse _namespace_name "hasDiameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasDiameterNeck"></see>
    /// </summary>
    let hasDiameterNeck =
        Namespaced_IRI.parse _namespace_name "hasDiameterNeck" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasDiameterSupport"></see>
    /// </summary>
    let hasDiameterSupport =
        Namespaced_IRI.parse _namespace_name "hasDiameterSupport" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasDirettore"></see>
    /// </summary>
    let hasDirettore =
        Namespaced_IRI.parse _namespace_name "hasDirettore" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasDistanceHandles"></see>
    /// </summary>
    let hasDistanceHandles =
        Namespaced_IRI.parse _namespace_name "hasDistanceHandles" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasDistortion"></see>
    /// </summary>
    let hasDistortion =
        Namespaced_IRI.parse _namespace_name "hasDistortion" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasExtrudeDepth"></see>
    /// </summary>
    let hasExtrudeDepth =
        Namespaced_IRI.parse _namespace_name "hasExtrudeDepth" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasExtrudedData1"></see>
    /// </summary>
    let hasExtrudedData1 =
        Namespaced_IRI.parse _namespace_name "hasExtrudedData1" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasExtrudedData2"></see>
    /// </summary>
    let hasExtrudedData2 =
        Namespaced_IRI.parse _namespace_name "hasExtrudedData2" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasExtrudedPt1X"></see>
    /// </summary>
    let hasExtrudedPt1X =
        Namespaced_IRI.parse _namespace_name "hasExtrudedPt1X" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasExtrudedPt1Y"></see>
    /// </summary>
    let hasExtrudedPt1Y =
        Namespaced_IRI.parse _namespace_name "hasExtrudedPt1Y" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasExtrudedPt1Z"></see>
    /// </summary>
    let hasExtrudedPt1Z =
        Namespaced_IRI.parse _namespace_name "hasExtrudedPt1Z" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasExtrudedPt2X"></see>
    /// </summary>
    let hasExtrudedPt2X =
        Namespaced_IRI.parse _namespace_name "hasExtrudedPt2X" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasExtrudedPt2Y"></see>
    /// </summary>
    let hasExtrudedPt2Y =
        Namespaced_IRI.parse _namespace_name "hasExtrudedPt2Y" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasExtrudedPt2Z"></see>
    /// </summary>
    let hasExtrudedPt2Z =
        Namespaced_IRI.parse _namespace_name "hasExtrudedPt2Z" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasFinitura"></see>
    /// </summary>
    let hasFinitura =
        Namespaced_IRI.parse _namespace_name "hasFinitura" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasFocalLength"></see>
    /// </summary>
    let hasFocalLength =
        Namespaced_IRI.parse _namespace_name "hasFocalLength" |> NamespacedName

    /// <summary>
    /// manual evaluation of the Percent of necrosed part in a colony
    /// <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasFootDiameter"></see></summary>
    let hasFootDiameter =
        Namespaced_IRI.parse _namespace_name "hasFootDiameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasFrameHeigthInPixel"></see>
    /// </summary>
    let hasFrameHeigthInPixel =
        Namespaced_IRI.parse _namespace_name "hasFrameHeigthInPixel" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasFrameHeigthInmm"></see>
    /// </summary>
    let hasFrameHeigthInmm =
        Namespaced_IRI.parse _namespace_name "hasFrameHeigthInmm" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasFrameWidthInPixel"></see>
    /// </summary>
    let hasFrameWidthInPixel =
        Namespaced_IRI.parse _namespace_name "hasFrameWidthInPixel" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasFrameWidthInmm"></see>
    /// </summary>
    let hasFrameWidthInmm =
        Namespaced_IRI.parse _namespace_name "hasFrameWidthInmm" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasFullFileName"></see>
    /// </summary>
    let hasFullFileName =
        Namespaced_IRI.parse _namespace_name "hasFullFileName" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasHandlesWidth"></see>
    /// </summary>
    let hasHandlesWidth =
        Namespaced_IRI.parse _namespace_name "hasHandlesWidth" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasHeight"></see>
    /// </summary>
    let hasHeight = Namespaced_IRI.parse _namespace_name "hasHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasHeightLips"></see>
    /// </summary>
    let hasHeightLips =
        Namespaced_IRI.parse _namespace_name "hasHeightLips" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasId"></see>
    /// </summary>
    let hasId = Namespaced_IRI.parse _namespace_name "hasId" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasIdn"></see>
    /// </summary>
    let hasIdn = Namespaced_IRI.parse _namespace_name "hasIdn" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasImagePointManager"></see>
    /// </summary>
    let hasImagePointManager =
        Namespaced_IRI.parse _namespace_name "hasImagePointManager" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasInternalVolume"></see>
    /// </summary>
    let hasInternalVolume =
        Namespaced_IRI.parse _namespace_name "hasInternalVolume" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasLavorazione"></see>
    /// </summary>
    let hasLavorazione =
        Namespaced_IRI.parse _namespace_name "hasLavorazione" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasLength"></see>
    /// </summary>
    let hasLength = Namespaced_IRI.parse _namespace_name "hasLength" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasLitotipo"></see>
    /// </summary>
    let hasLitotipo =
        Namespaced_IRI.parse _namespace_name "hasLitotipo" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasMass"></see>
    /// </summary>
    let hasMass = Namespaced_IRI.parse _namespace_name "hasMass" |> NamespacedName

    /// <summary>
    /// Should be Diameter
    /// <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasMaxDiameter"></see></summary>
    let hasMaxDiameter =
        Namespaced_IRI.parse _namespace_name "hasMaxDiameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasMeasuredPointManager"></see>
    /// </summary>
    let hasMeasuredPointManager =
        Namespaced_IRI.parse _namespace_name "hasMeasuredPointManager" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasName"></see>
    /// </summary>
    let hasName = Namespaced_IRI.parse _namespace_name "hasName" |> NamespacedName

    /// <summary>
    /// manual evaluation of the Percent of necrosed part in a colony
    /// <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasNbBranch"></see></summary>
    let hasNbBranch =
        Namespaced_IRI.parse _namespace_name "hasNbBranch" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasNormalizedDiamMaxPos"></see>
    /// </summary>
    let hasNormalizedDiamMaxPos =
        Namespaced_IRI.parse _namespace_name "hasNormalizedDiamMaxPos" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasObservation"></see>
    /// </summary>
    let hasObservation =
        Namespaced_IRI.parse _namespace_name "hasObservation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasPPX"></see>
    /// </summary>
    let hasPPX = Namespaced_IRI.parse _namespace_name "hasPPX" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasPPY"></see>
    /// </summary>
    let hasPPY = Namespaced_IRI.parse _namespace_name "hasPPY" |> NamespacedName

    /// <summary>
    /// manual evaluation of the Percent of necrosed part in a colony
    /// <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasPercentNecrose"></see></summary>
    let hasPercentNecrose =
        Namespaced_IRI.parse _namespace_name "hasPercentNecrose" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasPhotoManager"></see>
    /// </summary>
    let hasPhotoManager =
        Namespaced_IRI.parse _namespace_name "hasPhotoManager" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasPhotograph"></see>
    /// </summary>
    let hasPhotograph =
        Namespaced_IRI.parse _namespace_name "hasPhotograph" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasPixelHeight_mm"></see>
    /// </summary>
    let hasPixelHeight_mm =
        Namespaced_IRI.parse _namespace_name "hasPixelHeight_mm" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasPixelWidth_mm"></see>
    /// </summary>
    let hasPixelWidth_mm =
        Namespaced_IRI.parse _namespace_name "hasPixelWidth_mm" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasPointManager"></see>
    /// </summary>
    let hasPointManager =
        Namespaced_IRI.parse _namespace_name "hasPointManager" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRatioDiamHeight"></see>
    /// </summary>
    let hasRatioDiamHeight =
        Namespaced_IRI.parse _namespace_name "hasRatioDiamHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationAnteriorita"></see>
    /// </summary>
    let hasRelationAnteriorita =
        Namespaced_IRI.parse _namespace_name "hasRelationAnteriorita" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationAppoggiatoA"></see>
    /// </summary>
    let hasRelationAppoggiatoA =
        Namespaced_IRI.parse _namespace_name "hasRelationAppoggiatoA" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationCollegatoA"></see>
    /// </summary>
    let hasRelationCollegatoA =
        Namespaced_IRI.parse _namespace_name "hasRelationCollegatoA" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationContemporaneita"></see>
    /// </summary>
    let hasRelationContemporaneita =
        Namespaced_IRI.parse _namespace_name "hasRelationContemporaneita" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationCopertoDa"></see>
    /// </summary>
    let hasRelationCopertoDa =
        Namespaced_IRI.parse _namespace_name "hasRelationCopertoDa" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationCopre"></see>
    /// </summary>
    let hasRelationCopre =
        Namespaced_IRI.parse _namespace_name "hasRelationCopre" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationGliSiAppoggia"></see>
    /// </summary>
    let hasRelationGliSiAppoggia =
        Namespaced_IRI.parse _namespace_name "hasRelationGliSiAppoggia" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationLegatoA"></see>
    /// </summary>
    let hasRelationLegatoA =
        Namespaced_IRI.parse _namespace_name "hasRelationLegatoA" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationPosteriorita"></see>
    /// </summary>
    let hasRelationPosteriorita =
        Namespaced_IRI.parse _namespace_name "hasRelationPosteriorita" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationRiempie"></see>
    /// </summary>
    let hasRelationRiempie =
        Namespaced_IRI.parse _namespace_name "hasRelationRiempie" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationRiempitoDa"></see>
    /// </summary>
    let hasRelationRiempitoDa =
        Namespaced_IRI.parse _namespace_name "hasRelationRiempitoDa" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationTaglia"></see>
    /// </summary>
    let hasRelationTaglia =
        Namespaced_IRI.parse _namespace_name "hasRelationTaglia" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationTagliatoDa"></see>
    /// </summary>
    let hasRelationTagliatoDa =
        Namespaced_IRI.parse _namespace_name "hasRelationTagliatoDa" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasRelationUgualeA"></see>
    /// </summary>
    let hasRelationUgualeA =
        Namespaced_IRI.parse _namespace_name "hasRelationUgualeA" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasReprojectionResidual"></see>
    /// </summary>
    let hasReprojectionResidual =
        Namespaced_IRI.parse _namespace_name "hasReprojectionResidual" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasResidual"></see>
    /// </summary>
    let hasResidual =
        Namespaced_IRI.parse _namespace_name "hasResidual" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasResidualX"></see>
    /// </summary>
    let hasResidualX =
        Namespaced_IRI.parse _namespace_name "hasResidualX" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasResidualY"></see>
    /// </summary>
    let hasResidualY =
        Namespaced_IRI.parse _namespace_name "hasResidualY" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasResidualZ"></see>
    /// </summary>
    let hasResidualZ =
        Namespaced_IRI.parse _namespace_name "hasResidualZ" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasScale"></see>
    /// </summary>
    let hasScale = Namespaced_IRI.parse _namespace_name "hasScale" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasSigla"></see>
    /// </summary>
    let hasSigla = Namespaced_IRI.parse _namespace_name "hasSigla" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasSito"></see>
    /// </summary>
    let hasSito = Namespaced_IRI.parse _namespace_name "hasSito" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStateOfConservation"></see>
    /// </summary>
    let hasStateOfConservation =
        Namespaced_IRI.parse _namespace_name "hasStateOfConservation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationAnteriorita"></see>
    /// </summary>
    let hasStratigraphicRelationAnteriorita =
        Namespaced_IRI.parse _namespace_name "hasStratigraphicRelationAnteriorita" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationAppoggiatoA"></see>
    /// </summary>
    let hasStratigraphicRelationAppoggiatoA =
        Namespaced_IRI.parse _namespace_name "hasStratigraphicRelationAppoggiatoA" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationCollegatoA"></see>
    /// </summary>
    let hasStratigraphicRelationCollegatoA =
        Namespaced_IRI.parse _namespace_name "hasStratigraphicRelationCollegatoA" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationContemporaneita"></see>
    /// </summary>
    let hasStratigraphicRelationContemporaneita =
        Namespaced_IRI.parse _namespace_name "hasStratigraphicRelationContemporaneita" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationCopertoDa"></see>
    /// </summary>
    let hasStratigraphicRelationCopertoDa =
        Namespaced_IRI.parse _namespace_name "hasStratigraphicRelationCopertoDa" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationCopre"></see>
    /// </summary>
    let hasStratigraphicRelationCopre =
        Namespaced_IRI.parse _namespace_name "hasStratigraphicRelationCopre" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationGliSiAppoggia"></see>
    /// </summary>
    let hasStratigraphicRelationGliSiAppoggia =
        Namespaced_IRI.parse _namespace_name "hasStratigraphicRelationGliSiAppoggia" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationLegatoA"></see>
    /// </summary>
    let hasStratigraphicRelationLegatoA =
        Namespaced_IRI.parse _namespace_name "hasStratigraphicRelationLegatoA" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationPosteriorita"></see>
    /// </summary>
    let hasStratigraphicRelationPosteriorita =
        Namespaced_IRI.parse _namespace_name "hasStratigraphicRelationPosteriorita" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationRiempie"></see>
    /// </summary>
    let hasStratigraphicRelationRiempie =
        Namespaced_IRI.parse _namespace_name "hasStratigraphicRelationRiempie" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationRiempitoDa"></see>
    /// </summary>
    let hasStratigraphicRelationRiempitoDa =
        Namespaced_IRI.parse _namespace_name "hasStratigraphicRelationRiempitoDa" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationTaglia"></see>
    /// </summary>
    let hasStratigraphicRelationTaglia =
        Namespaced_IRI.parse _namespace_name "hasStratigraphicRelationTaglia" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationTagliatoDa"></see>
    /// </summary>
    let hasStratigraphicRelationTagliatoDa =
        Namespaced_IRI.parse _namespace_name "hasStratigraphicRelationTagliatoDa" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasStratigraphicRelationUgualeA"></see>
    /// </summary>
    let hasStratigraphicRelationUgualeA =
        Namespaced_IRI.parse _namespace_name "hasStratigraphicRelationUgualeA" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasTransformation3D"></see>
    /// </summary>
    let hasTransformation3D =
        Namespaced_IRI.parse _namespace_name "hasTransformation3D" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasTranslation"></see>
    /// </summary>
    let hasTranslation =
        Namespaced_IRI.parse _namespace_name "hasTranslation" |> NamespacedName

    /// <summary>
    /// Typology name, often used to compute the paradigm filename in ply
    /// <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasTypologyName"></see></summary>
    let hasTypologyName =
        Namespaced_IRI.parse _namespace_name "hasTypologyName" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasUnitaStratigrafica"></see>
    /// </summary>
    let hasUnitaStratigrafica =
        Namespaced_IRI.parse _namespace_name "hasUnitaStratigrafica" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasVolume"></see>
    /// </summary>
    let hasVolume = Namespaced_IRI.parse _namespace_name "hasVolume" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasWidth"></see>
    /// </summary>
    let hasWidth = Namespaced_IRI.parse _namespace_name "hasWidth" |> NamespacedName

    /// <summary>
    /// For more accuracy we take widht between upper hadles in adition to the diameter which is between down handles
    /// <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasWidthBetweenUpperHandles"></see></summary>
    let hasWidthBetweenUpperHandles =
        Namespaced_IRI.parse _namespace_name "hasWidthBetweenUpperHandles" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasWidthLips"></see>
    /// </summary>
    let hasWidthLips =
        Namespaced_IRI.parse _namespace_name "hasWidthLips" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasX"></see>
    /// </summary>
    let hasX = Namespaced_IRI.parse _namespace_name "hasX" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasXMax"></see>
    /// </summary>
    let hasXMax = Namespaced_IRI.parse _namespace_name "hasXMax" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasXMin"></see>
    /// </summary>
    let hasXMin = Namespaced_IRI.parse _namespace_name "hasXMin" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasY"></see>
    /// </summary>
    let hasY = Namespaced_IRI.parse _namespace_name "hasY" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasYMax"></see>
    /// </summary>
    let hasYMax = Namespaced_IRI.parse _namespace_name "hasYMax" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasYMin"></see>
    /// </summary>
    let hasYMin = Namespaced_IRI.parse _namespace_name "hasYMin" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasZ"></see>
    /// </summary>
    let hasZ = Namespaced_IRI.parse _namespace_name "hasZ" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasZMax"></see>
    /// </summary>
    let hasZMax = Namespaced_IRI.parse _namespace_name "hasZMax" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#hasZMin"></see>
    /// </summary>
    let hasZMin = Namespaced_IRI.parse _namespace_name "hasZMin" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#has_m00"></see>
    /// </summary>
    let has_m00 = Namespaced_IRI.parse _namespace_name "has_m00" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#has_m01"></see>
    /// </summary>
    let has_m01 = Namespaced_IRI.parse _namespace_name "has_m01" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#has_m02"></see>
    /// </summary>
    let has_m02 = Namespaced_IRI.parse _namespace_name "has_m02" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#has_m10"></see>
    /// </summary>
    let has_m10 = Namespaced_IRI.parse _namespace_name "has_m10" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#has_m11"></see>
    /// </summary>
    let has_m11 = Namespaced_IRI.parse _namespace_name "has_m11" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#has_m12"></see>
    /// </summary>
    let has_m12 = Namespaced_IRI.parse _namespace_name "has_m12" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#has_m20"></see>
    /// </summary>
    let has_m20 = Namespaced_IRI.parse _namespace_name "has_m20" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#has_m21"></see>
    /// </summary>
    let has_m21 = Namespaced_IRI.parse _namespace_name "has_m21" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#has_m22"></see>
    /// </summary>
    let has_m22 = Namespaced_IRI.parse _namespace_name "has_m22" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#haveASetOfPhotograph"></see>
    /// </summary>
    let haveASetOfPhotograph =
        Namespaced_IRI.parse _namespace_name "haveASetOfPhotograph" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#isActive"></see>
    /// </summary>
    let isActive = Namespaced_IRI.parse _namespace_name "isActive" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#isElementOf"></see>
    /// </summary>
    let isElementOf =
        Namespaced_IRI.parse _namespace_name "isElementOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#isExtruded"></see>
    /// </summary>
    let isExtruded = Namespaced_IRI.parse _namespace_name "isExtruded" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#isExtrudedBy"></see>
    /// </summary>
    let isExtrudedBy =
        Namespaced_IRI.parse _namespace_name "isExtrudedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#isNegative"></see>
    /// </summary>
    let isNegative = Namespaced_IRI.parse _namespace_name "isNegative" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#isObservationOf"></see>
    /// </summary>
    let isObservationOf =
        Namespaced_IRI.parse _namespace_name "isObservationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#isPhotographOf"></see>
    /// </summary>
    let isPhotographOf =
        Namespaced_IRI.parse _namespace_name "isPhotographOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#isValid"></see>
    /// </summary>
    let isValid = Namespaced_IRI.parse _namespace_name "isValid" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.arpenteur.org/ontology/Arpenteur.owl#percentOfMeasured"></see>
    /// </summary>
    let percentOfMeasured =
        Namespaced_IRI.parse _namespace_name "percentOfMeasured" |> NamespacedName

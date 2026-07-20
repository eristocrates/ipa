namespace http._open.vocab.org.terms.slash

open DoxAletheia

module open_ =
    let _namespace_name = "http://open.vocab.org/terms/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The ceramic ware produced during the Roman period in the region of what is now the modern country of Tunisia.
    /// <see href="http://open.vocab.org/terms/AfricanRedSlip"></see></summary>
    let AfricanRedSlip = _prefix "AfricanRedSlip"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/markdownDescription"></see>
    /// </summary>
    let markdownDescription = _prefix "markdownDescription"
    /// <summary>
    /// Generic term for category of ceramics that may be distinguished by function, surface treatment, distinguishing features of clay, or other set of criteria as defined by usage. Commonly used in the discipline of Archaeology.
    /// <see href="http://open.vocab.org/terms/Ware"></see></summary>
    let Ware = _prefix "Ware"
    /// <summary>
    /// It is a major goal of Amateur Radio Operators to make contact with each other.  This contact is formally defined as the exchange of certain information, usually consisting of each operator's call sign and a signal report (how well each operator receives the signal of the other).  A contact can last a few seconds to many minutes.  Nickname "QSL".
    /// <see href="http://open.vocab.org/terms/AmateurRadioContact"></see></summary>
    let AmateurRadioContact = _prefix "AmateurRadioContact"
    /// <summary>
    /// A person who is licensed in at least one ITU region to operate (transmit and receive) a radio using frequencies and modes permitted only  to licensed persons.
    /// <see href="http://open.vocab.org/terms/AmateurRadioOperator"></see></summary>
    let AmateurRadioOperator = _prefix "AmateurRadioOperator"
    /// <summary>
    /// A type of dataset that contains annotations on a set of resources.
    /// <see href="http://open.vocab.org/terms/AnnotationSet"></see></summary>
    let AnnotationSet = _prefix "AnnotationSet"
    /// <summary>
    /// Automobiles, when presented as a catalog, are generally categorized using the Car Maker / Car Model / Trim Package hierarchy.
    /// <see href="http://open.vocab.org/terms/AutomobileCataologType"></see></summary>
    let AutomobileCataologType = _prefix "AutomobileCataologType"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/AutomobileCataologType.html"></see>
    /// </summary>
    let ``AutomobileCataologType.html`` = _prefix "AutomobileCataologType.html"
    /// <summary>
    /// From en.wikipedia.org:
    /// "A car model is a particular brand of vehicle sold under a marque. From an engineering point of view, a particular car model is usually defined and/or constrained by the use of a particular car chassis/bodywork combination or the same monocoque."
    /// <see href="http://open.vocab.org/terms/AutomobileModel"></see></summary>
    let AutomobileModel = _prefix "AutomobileModel"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/AutomobileModel.html"></see>
    /// </summary>
    let ``AutomobileModel.html`` = _prefix "AutomobileModel.html"
    /// <summary>
    /// This class of character traits was created to describe the characters in the graphic novel Avatar-The Last Airbender.
    /// The motivation was to create a unique class identifying the characters in the trilogy.
    /// <see href="http://open.vocab.org/terms/AvatarCharacterTraits"></see></summary>
    let AvatarCharacterTraits = _prefix "AvatarCharacterTraits"
    /// <summary>
    /// Database for Biologists (Bioinformatics)
    /// <see href="http://open.vocab.org/terms/BiologicalDatabase"></see></summary>
    let BiologicalDatabase = _prefix "BiologicalDatabase"
    /// <summary>
    /// A Scientific Database
    /// <see href="http://open.vocab.org/terms/ScientificDatabase"></see></summary>
    let ScientificDatabase = _prefix "ScientificDatabase"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/BiologicalDatabase.html"></see>
    /// </summary>
    let ``BiologicalDatabase.html`` = _prefix "BiologicalDatabase.html"
    /// <summary>
    /// Birth class
    /// <see href="http://open.vocab.org/terms/Birth"></see></summary>
    let Birth = _prefix "Birth"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Death"></see>
    /// </summary>
    let Death = _prefix "Death"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Birth.html"></see>
    /// </summary>
    let ``Birth.html`` = _prefix "Birth.html"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Calendar"></see>
    /// </summary>
    let Calendar = _prefix "Calendar"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Calendar.html"></see>
    /// </summary>
    let ``Calendar.html`` = _prefix "Calendar.html"
    /// <summary>
    /// Cheese is a food made from milk, usually the milk of cows, buffalo, goats, or sheep, by coagulation.
    /// <see href="http://open.vocab.org/terms/Cheese"></see></summary>
    let Cheese = _prefix "Cheese"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Cheese.html"></see>
    /// </summary>
    let ``Cheese.html`` = _prefix "Cheese.html"
    /// <summary>
    /// Members of this class represent class skeletons which are sort of templates of a class.
    ///
    /// Members of a class which has a class skeleton (http://open.vocab.org/terms/classSkeleton property) should have the triples relating from/to the skeleton, which don't use property http://open.vocab.org/terms/classSkeletonIgnore and its sub-properties as predicate, relating from/to them too.
    ///
    /// This materialization of triples is expected to be carried out by for example some kind of rule engine.
    ///
    /// Important: This kind of inference is already possible with OWL using property restrictions (Functional-Style Syntax):
    ///   EquivalentClasses(
    ///     :JohnsChildren
    ///     ObjectHasValue( :hasParent :John )
    ///   )
    /// So you might better use OWL since the functionality is the same.
    /// http://www.w3.org/TR/owl2-primer/#Property_Restrictions
    /// <see href="http://open.vocab.org/terms/ClassSkeleton"></see></summary>
    let ClassSkeleton = _prefix "ClassSkeleton"
    /// <summary>
    /// A country is a geographical region. A country may be the territory of a sovereign state, the territory of a non-sovereign (or formerly sovereign) political division, or a region associated with a certain people or certain characteristics.
    /// <see href="http://open.vocab.org/terms/Country"></see></summary>
    let Country = _prefix "Country"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Course"></see>
    /// </summary>
    let Course = _prefix "Course"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Course.html"></see>
    /// </summary>
    let ``Course.html`` = _prefix "Course.html"
    /// <summary>
    /// A boundary-point's position in a Document or DocumentFragment tree can be characterized by a node and an offset.
    /// http://www.w3.org/TR/2000/REC-DOM-Level-2-Traversal-Range-20001113/ranges.html#Level-2-Range-Definitions
    /// <see href="http://open.vocab.org/terms/DOMBoundaryPoint"></see></summary>
    let DOMBoundaryPoint = _prefix "DOMBoundaryPoint"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/DOMBoundaryPoint.html"></see>
    /// </summary>
    let ``DOMBoundaryPoint.html`` = _prefix "DOMBoundaryPoint.html"
    /// <summary>
    /// A boundary-point's position in a Document or DocumentFragment tree can be characterized by a node and an offset
    ///
    /// http://www.w3.org/TR/2000/REC-DOM-Level-2-Traversal-Range-20001113/ranges.html#Level-2-Range-Definitions
    /// <see href="http://open.vocab.org/terms/DOMBoundaryPointPosition"></see></summary>
    let DOMBoundaryPointPosition = _prefix "DOMBoundaryPointPosition"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/DOMBoundaryPointPosition.html"></see>
    /// </summary>
    let ``DOMBoundaryPointPosition.html`` = _prefix "DOMBoundaryPointPosition.html"
    /// <summary>
    /// DOMNode can be a Attribute, Document, DocumentFragment, Element or EntityReference node.
    /// <see href="http://open.vocab.org/terms/DOMNode"></see></summary>
    let DOMNode = _prefix "DOMNode"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/DOMNode.html"></see>
    /// </summary>
    let ``DOMNode.html`` = _prefix "DOMNode.html"
    /// <summary>
    /// the offset within a DOM node
    /// <see href="http://open.vocab.org/terms/DOMOffset"></see></summary>
    let DOMOffset = _prefix "DOMOffset"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/DOMOffset.html"></see>
    /// </summary>
    let ``DOMOffset.html`` = _prefix "DOMOffset.html"
    /// <summary>
    /// A DOM Range consists of two boundary-points corresponding to the start and the end of the Range.
    /// http://www.w3.org/TR/2000/REC-DOM-Level-2-Traversal-Range-20001113/ranges.html#Level-2-Range-Definitions
    /// <see href="http://open.vocab.org/terms/DOMRange"></see></summary>
    let DOMRange = _prefix "DOMRange"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/DOMRange.html"></see>
    /// </summary>
    let ``DOMRange.html`` = _prefix "DOMRange.html"
    /// <summary>
    /// A Database
    /// <see href="http://open.vocab.org/terms/Database"></see></summary>
    let Database = _prefix "Database"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Database.html"></see>
    /// </summary>
    let ``Database.html`` = _prefix "Database.html"
    /// <summary>
    /// A construct representing a deleted entry in an Atom feed.
    /// <see href="http://open.vocab.org/terms/DeletedEntry"></see></summary>
    let DeletedEntry = _prefix "DeletedEntry"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/DeletedEntry.html"></see>
    /// </summary>
    let ``DeletedEntry.html`` = _prefix "DeletedEntry.html"
    /// <summary>
    /// A diff, showing the difference between a source resource and a target resource.
    /// <see href="http://open.vocab.org/terms/Diff"></see></summary>
    let Diff = _prefix "Diff"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Diff.html"></see>
    /// </summary>
    let ``Diff.html`` = _prefix "Diff.html"
    /// <summary>
    /// DAs would be typically files. Audio, movies, software licenses, software installers, documents, etc. Anything stored that needs a computer to get it and/or read it.
    /// <see href="http://open.vocab.org/terms/DigitalAsset"></see></summary>
    let DigitalAsset = _prefix "DigitalAsset"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/DigitalAsset.html"></see>
    /// </summary>
    let ``DigitalAsset.html`` = _prefix "DigitalAsset.html"
    /// <summary>
    /// A Distance should have two distance points and a distance value. eg:
    ///
    /// &lt;distances/a/b&gt;
    ///     a ov:Distance ;
    ///     ov:distancePoint &lt;a&gt; , &lt;b&gt; ;
    ///     ov:kilometres 0.5 ;
    /// .
    /// <see href="http://open.vocab.org/terms/Distance"></see></summary>
    let Distance = _prefix "Distance"
    /// <summary>
    /// class is now deprecated in favour of Earworm class.
    /// <see href="http://open.vocab.org/terms/EarWorm"></see></summary>
    let EarWorm = _prefix "EarWorm"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/EarWorm.html"></see>
    /// </summary>
    let ``EarWorm.html`` = _prefix "EarWorm.html"
    /// <summary>
    /// The experience of having a song in your head which you can't get rid of.
    /// <see href="http://open.vocab.org/terms/Earworm"></see></summary>
    let Earworm = _prefix "Earworm"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Earworm.html"></see>
    /// </summary>
    let ``Earworm.html`` = _prefix "Earworm.html"
    /// <summary>
    /// The class of all motion pictures
    /// <see href="http://open.vocab.org/terms/Film"></see></summary>
    let Film = _prefix "Film"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Film.html"></see>
    /// </summary>
    let ``Film.html`` = _prefix "Film.html"
    /// <summary>
    /// A formula or graph literal, in the sense used by Notation 3.
    ///
    /// This is intended to be used as a datatype. e.g.
    ///
    ///   &lt;#bob&gt; ex:believes "&lt;#alice&gt; a &lt;http://xmlns.com/foaf/0.1/Person&gt; ."^^ov:Formula .
    ///
    /// Note that the wrapping "{"..."}" are omitted from the value.
    /// <see href="http://open.vocab.org/terms/Formula"></see></summary>
    let Formula = _prefix "Formula"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/HUDCourseLoan"></see>
    /// </summary>
    let HUDCourseLoan = _prefix "HUDCourseLoan"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/HUDCourseLoan.html"></see>
    /// </summary>
    let ``HUDCourseLoan.html`` = _prefix "HUDCourseLoan.html"
    /// <summary>
    /// The loan history of a book within a school
    /// <see href="http://open.vocab.org/terms/HUDSchoolLoan"></see></summary>
    let HUDSchoolLoan = _prefix "HUDSchoolLoan"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/HUDSchoolLoan.html"></see>
    /// </summary>
    let ``HUDSchoolLoan.html`` = _prefix "HUDSchoolLoan.html"
    /// <summary>
    /// Suggested book based on circulation data
    /// <see href="http://open.vocab.org/terms/HUDSuggestion"></see></summary>
    let HUDSuggestion = _prefix "HUDSuggestion"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/HUDSuggestion.html"></see>
    /// </summary>
    let ``HUDSuggestion.html`` = _prefix "HUDSuggestion.html"
    /// <summary>
    /// The loan history for a book by year.
    /// <see href="http://open.vocab.org/terms/HUDYearLoan"></see></summary>
    let HUDYearLoan = _prefix "HUDYearLoan"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/HUDYearLoan.html"></see>
    /// </summary>
    let ``HUDYearLoan.html`` = _prefix "HUDYearLoan.html"
    /// <summary>
    /// Structure in which someone lives
    /// <see href="http://open.vocab.org/terms/House"></see></summary>
    let House = _prefix "House"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/building"></see>
    /// </summary>
    let building = _prefix "building"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/horse"></see>
    /// </summary>
    let horse = _prefix "horse"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/domicile"></see>
    /// </summary>
    let domicile = _prefix "domicile"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/House.html"></see>
    /// </summary>
    let ``House.html`` = _prefix "House.html"
    /// <summary>
    /// The ITU defines a set of world-wide regions which uniquely describe locations for radio operation (in particular, amateur radio operation).  These regions are widely-used by amateur radio operators to report operation and radio contacts.  Each region has a unique abbreviation.
    /// <see href="http://open.vocab.org/terms/ITUREgion"></see></summary>
    let ITUREgion = _prefix "ITUREgion"
    /// <summary>
    /// A statement that would be illegal to express in a non-reified form in RDF/XML - usually because the predicate cannot be converted to a QName.
    /// <see href="http://open.vocab.org/terms/IllegalRDFXMLStatement"></see></summary>
    let IllegalRDFXMLStatement = _prefix "IllegalRDFXMLStatement"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/IllegalRDFXMLStatement.html"></see>
    /// </summary>
    let ``IllegalRDFXMLStatement.html`` = _prefix "IllegalRDFXMLStatement.html"
    /// <summary>
    /// An irc chat bot
    /// <see href="http://open.vocab.org/terms/IrcBot"></see></summary>
    let IrcBot = _prefix "IrcBot"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/IrcBot.html"></see>
    /// </summary>
    let ``IrcBot.html`` = _prefix "IrcBot.html"
    /// <summary>
    /// the concept of "this" in a javascript object. In other words a mean in which to refer to "self"
    /// <see href="http://open.vocab.org/terms/JavascriptThis"></see></summary>
    let JavascriptThis = _prefix "JavascriptThis"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/JavascriptThis.html"></see>
    /// </summary>
    let ``JavascriptThis.html`` = _prefix "JavascriptThis.html"
    /// <summary>
    /// A gorilla that kills or has the inclination to do so.
    /// <see href="http://open.vocab.org/terms/KillerGorilla"></see></summary>
    let KillerGorilla = _prefix "KillerGorilla"
    /// <summary>
    /// Indicates that something is definitely not a Killer-Gorilla. (It may still be a killer though. Or a gorilla.)
    /// <see href="http://open.vocab.org/terms/NotAKillerGorilla"></see></summary>
    let NotAKillerGorilla = _prefix "NotAKillerGorilla"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/KillerGorilla.html"></see>
    /// </summary>
    let ``KillerGorilla.html`` = _prefix "KillerGorilla.html"
    /// <summary>
    /// The class of all MOT Testing Stations.
    /// <see href="http://open.vocab.org/terms/MOTTestingStation"></see></summary>
    let MOTTestingStation = _prefix "MOTTestingStation"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Madre"></see>
    /// </summary>
    let Madre = _prefix "Madre"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Madre.html"></see>
    /// </summary>
    let ``Madre.html`` = _prefix "Madre.html"
    /// <summary>
    /// A manifest is a listing of files or URIs or resources of some sort encoded in some way
    /// <see href="http://open.vocab.org/terms/Manifest"></see></summary>
    let Manifest = _prefix "Manifest"
    /// <summary>
    /// A post on a microblogging service like Twitter, identi.ca, Jaiku or FriendFeed. Usually untitled and with a limited number of characters, and sometimes containing in-line text-based syntactical elements like at-replies, hashtags, group 'bangtags' etc.
    /// <see href="http://open.vocab.org/terms/MicroblogPost"></see></summary>
    let MicroblogPost = _prefix "MicroblogPost"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/MicroblogPost.html"></see>
    /// </summary>
    let ``MicroblogPost.html`` = _prefix "MicroblogPost.html"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/MultiSportEvent"></see>
    /// </summary>
    let MultiSportEvent = _prefix "MultiSportEvent"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/MultiSportEvent.html"></see>
    /// </summary>
    let ``MultiSportEvent.html`` = _prefix "MultiSportEvent.html"
    /// <summary>
    /// A piece of News
    /// <see href="http://open.vocab.org/terms/NewsItem"></see></summary>
    let NewsItem = _prefix "NewsItem"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/NotAKillerGorilla.html"></see>
    /// </summary>
    let ``NotAKillerGorilla.html`` = _prefix "NotAKillerGorilla.html"
    /// <summary>
    /// Numismatics is  the study of coins, medals and other related items.
    /// <see href="http://open.vocab.org/terms/Numismatics"></see></summary>
    let Numismatics = _prefix "Numismatics"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Numismatics.html"></see>
    /// </summary>
    let ``Numismatics.html`` = _prefix "Numismatics.html"
    /// <summary>
    /// Any entity that can be identified using the OKKAM entity naming system. In general one could say this is equivalent to resource but there are certain entity types that will work better on the OKKAM system
    /// <see href="http://open.vocab.org/terms/OkkamEntity"></see></summary>
    let OkkamEntity = _prefix "OkkamEntity"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/OkkamEntity.html"></see>
    /// </summary>
    let ``OkkamEntity.html`` = _prefix "OkkamEntity.html"
    /// <summary>
    /// The Olympic Games are an international multi-sport event established for both summer and winter sports.
    /// <see href="http://open.vocab.org/terms/OlympicGames"></see></summary>
    let OlympicGames = _prefix "OlympicGames"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/OlympicGames.html"></see>
    /// </summary>
    let ``OlympicGames.html`` = _prefix "OlympicGames.html"
    /// <summary>
    /// A Plot of anything.
    /// <see href="http://open.vocab.org/terms/Plot"></see></summary>
    let Plot = _prefix "Plot"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Plot.html"></see>
    /// </summary>
    let ``Plot.html`` = _prefix "Plot.html"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/PrimaryVisualElement"></see>
    /// </summary>
    let PrimaryVisualElement = _prefix "PrimaryVisualElement"
    /// <summary>
    /// A thing that manifests visually.
    /// <see href="http://open.vocab.org/terms/VisualElement"></see></summary>
    let VisualElement = _prefix "VisualElement"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/PrimaryVisualElement.html"></see>
    /// </summary>
    let ``PrimaryVisualElement.html`` = _prefix "PrimaryVisualElement.html"
    /// <summary>
    /// RTFMImperative is an instruction for foaf:Agent(s) to read a given document.
    /// <see href="http://open.vocab.org/terms/RTFMImperative"></see></summary>
    let RTFMImperative = _prefix "RTFMImperative"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/RTFMImperative.html"></see>
    /// </summary>
    let ``RTFMImperative.html`` = _prefix "RTFMImperative.html"
    /// <summary>
    /// When a radio transmits a signal, a range of frequencies is used to carry information.  This range may be continuous or dis-contiguous ("spread spectrum").  There is usually a single frequency that is used to "name" the tranmission frequency, although this naming depends on the mode used.  (See RadioOperationMode).  The standard method of expression is "Herz" (or a multiple).  Sometimes, surprisingly, the "frequency" is expressed in terms of length (actually wavelength, often in meters).  This is merely an colloquial and equivalent expresssion, since freq(Herz) = the-speed-of-light / wavelength.
    /// <see href="http://open.vocab.org/terms/RadioOperationFrequency"></see></summary>
    let RadioOperationFrequency = _prefix "RadioOperationFrequency"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/ScientificDatabase.html"></see>
    /// </summary>
    let ``ScientificDatabase.html`` = _prefix "ScientificDatabase.html"
    /// <summary>
    /// e.g. : 100m in Beijing 2008
    /// <see href="http://open.vocab.org/terms/SportEvent"></see></summary>
    let SportEvent = _prefix "SportEvent"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/SportEvent.html"></see>
    /// </summary>
    let ``SportEvent.html`` = _prefix "SportEvent.html"
    /// <summary>
    /// Indicates that the subject is a non-deceased killer gorilla.
    /// <see href="http://open.vocab.org/terms/StillAKillerGorilla"></see></summary>
    let StillAKillerGorilla = _prefix "StillAKillerGorilla"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/StillAKillerGorilla.html"></see>
    /// </summary>
    let ``StillAKillerGorilla.html`` = _prefix "StillAKillerGorilla.html"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/SummerOlympicGames"></see>
    /// </summary>
    let SummerOlympicGames = _prefix "SummerOlympicGames"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/WinterOlympicGames"></see>
    /// </summary>
    let WinterOlympicGames = _prefix "WinterOlympicGames"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/SummerOlympicGames.html"></see>
    /// </summary>
    let ``SummerOlympicGames.html`` = _prefix "SummerOlympicGames.html"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Test"></see>
    /// </summary>
    let Test = _prefix "Test"
    /// <summary>
    /// A Trim Package represents a standard configuration of options for an automobile.  Usually, a Car Model will be available as several Trim Packages.
    /// <see href="http://open.vocab.org/terms/TrimPackage"></see></summary>
    let TrimPackage = _prefix "TrimPackage"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/TrimPackage.html"></see>
    /// </summary>
    let ``TrimPackage.html`` = _prefix "TrimPackage.html"
    /// <summary>
    /// A course taught at a university
    /// <see href="http://open.vocab.org/terms/UnivCourse"></see></summary>
    let UnivCourse = _prefix "UnivCourse"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/UnivCourse.html"></see>
    /// </summary>
    let ``UnivCourse.html`` = _prefix "UnivCourse.html"
    /// <summary>
    /// A school of a university (e.g., School of Business).
    /// <see href="http://open.vocab.org/terms/UnivSchool"></see></summary>
    let UnivSchool = _prefix "UnivSchool"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/UnivSchool.html"></see>
    /// </summary>
    let ``UnivSchool.html`` = _prefix "UnivSchool.html"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/UuOjngyFVCE"></see>
    /// </summary>
    let UuOjngyFVCE = _prefix "UuOjngyFVCE"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/VisualElement.html"></see>
    /// </summary>
    let ``VisualElement.html`` = _prefix "VisualElement.html"
    /// <summary>
    /// A set of terms or names, each one having an assigned meaning.
    /// <see href="http://open.vocab.org/terms/Vocabulary"></see></summary>
    let Vocabulary = _prefix "Vocabulary"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Vocabulary.html"></see>
    /// </summary>
    let ``Vocabulary.html`` = _prefix "Vocabulary.html"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Ware.html"></see>
    /// </summary>
    let ``Ware.html`` = _prefix "Ware.html"
    /// <summary>
    /// A place that is accessible with a wheel chair.
    /// <see href="http://open.vocab.org/terms/WheelChairEnabled"></see></summary>
    let WheelChairEnabled = _prefix "WheelChairEnabled"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/WinterOlympicGames.html"></see>
    /// </summary>
    let ``WinterOlympicGames.html`` = _prefix "WinterOlympicGames.html"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Yoli"></see>
    /// </summary>
    let Yoli = _prefix "Yoli"
    /// <summary>
    /// A command issued to the code4lib IRC chat bot, zoia.
    /// <see href="http://open.vocab.org/terms/ZoiaCommand"></see></summary>
    let ZoiaCommand = _prefix "ZoiaCommand"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/ZoiaCommand.html"></see>
    /// </summary>
    let ``ZoiaCommand.html`` = _prefix "ZoiaCommand.html"
    /// <summary>
    /// foaf:OnlineAccount's can have an accountName, but plenty of services use an account identifier internally that is not the same as the public account name: for instance, Twitter uses a nickname and a user_id property. Facebook now assigns usernames as well as internal identification numbers. Google's various services assign a unique identifier so that people are not revealing their e-mail address or username. This property is for these kind of identifiers.
    /// <see href="http://open.vocab.org/terms/accountIdentifier"></see></summary>
    let accountIdentifier = _prefix "accountIdentifier"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/admWIUQRlVUqNMadZQ"></see>
    /// </summary>
    let admWIUQRlVUqNMadZQ = _prefix "admWIUQRlVUqNMadZQ"
    /// <summary>
    /// The Authorised Examiner Number of an MOT Testing Station.
    /// <see href="http://open.vocab.org/terms/aeNumber"></see></summary>
    let aeNumber = _prefix "aeNumber"
    /// <summary>
    /// Used to describe the affiliation, place of work or association of a foaf:Person when the source data is too ambiguous to model into its own resource.
    /// <see href="http://open.vocab.org/terms/affiliation"></see></summary>
    let affiliation = _prefix "affiliation"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/affiliation.html"></see>
    /// </summary>
    let ``affiliation.html`` = _prefix "affiliation.html"
    /// <summary>
    /// An agent syndicates a document some way.
    /// <see href="http://open.vocab.org/terms/aggregates"></see></summary>
    let aggregates = _prefix "aggregates"
    /// <summary>
    /// The anniversary of some event
    /// <see href="http://open.vocab.org/terms/anniversary"></see></summary>
    let anniversary = _prefix "anniversary"
    /// <summary>
    /// The area of some physical thing in hectares.
    /// <see href="http://open.vocab.org/terms/areaHectares"></see></summary>
    let areaHectares = _prefix "areaHectares"
    /// <summary>
    /// This property is used to relate two FRBR Endeavours/entities (http://vocab.org/frbr/core.html#Endeavour) together even if the entire Work-Expression-Manifestation-Item hierarchy does not exist.  For example, it could be used to relate a frbr:Work to a frbr:Manifestation without the need of a frbr:Expression to link them through.  The property is symmetric (if a &lt;_:work&gt; ov:associatedEntity &lt;_:item&gt; then &lt;_:item&gt; ov:associatedEntity &lt;_:work&gt;.  It is not transitive (items may be associated with the same work but not be in the same WEMI chain, for example).
    /// <see href="http://open.vocab.org/terms/associatedEntity"></see></summary>
    let associatedEntity = _prefix "associatedEntity"
    /// <summary>
    /// A thing that provides evidence for the existence or historicity of another thing attests to that other thing.
    /// <see href="http://open.vocab.org/terms/attestsTo"></see></summary>
    let attestsTo = _prefix "attestsTo"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/attestsTo.html"></see>
    /// </summary>
    let ``attestsTo.html`` = _prefix "attestsTo.html"
    /// <summary>
    /// The literal, human readable author string of a Document.
    /// <see href="http://open.vocab.org/terms/authorString"></see></summary>
    let authorString = _prefix "authorString"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/authorString.html"></see>
    /// </summary>
    let ``authorString.html`` = _prefix "authorString.html"
    /// <summary>
    /// One or more of the four elements viz. Air, Water, Fire and Earth that can be bent.
    /// <see href="http://open.vocab.org/terms/avatarBendingElement"></see></summary>
    let avatarBendingElement = _prefix "avatarBendingElement"
    /// <summary>
    /// Describes the eye color of an individual
    /// <see href="http://open.vocab.org/terms/avatarEyeColor"></see></summary>
    let avatarEyeColor = _prefix "avatarEyeColor"
    /// <summary>
    /// Describes when the character was introduced in the series.
    /// <see href="http://open.vocab.org/terms/avatarFirstAppearance"></see></summary>
    let avatarFirstAppearance = _prefix "avatarFirstAppearance"
    /// <summary>
    /// Defines the hair color (or no hair at all!) of an individual
    /// <see href="http://open.vocab.org/terms/avatarHairColor"></see></summary>
    let avatarHairColor = _prefix "avatarHairColor"
    /// <summary>
    /// The nationality of a character in Avatar. It can be one of Air, Fire, Water and Earth.
    /// <see href="http://open.vocab.org/terms/avatarNationality"></see></summary>
    let avatarNationality = _prefix "avatarNationality"
    /// <summary>
    /// Determines if the character is protagonist, antagonist, supporting character etc.
    /// <see href="http://open.vocab.org/terms/avatarPosition"></see></summary>
    let avatarPosition = _prefix "avatarPosition"
    /// <summary>
    /// The BBC provides IDs for places. This can be used to link BBC weather IDs to places.
    /// <see href="http://open.vocab.org/terms/bbcWeatherId"></see></summary>
    let bbcWeatherId = _prefix "bbcWeatherId"
    /// <summary>
    /// Following an EAD description, collections consist of one or more "components". Components act much like files and folders - a component may contain others (folder) or it may be a leaf node (file) - EAD is vague enough not to make this distinction, but provides a "level" attribute instead. This property is used by a component to show that if is a "componentOf" either another component or a collection or both.
    /// <see href="http://open.vocab.org/terms/beam-componentOf"></see></summary>
    let ``beam-componentOf`` = _prefix "beam-componentOf"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/beam-componentOf.html"></see>
    /// </summary>
    let ``beam-componentOf.html`` = _prefix "beam-componentOf.html"
    /// <summary>
    /// A sub-classing of bibo:identifier to narrow the range to be the numeric part of a BL identifier. For example:
    ///
    /// '(Uk)33994949'  ---&gt;  '&lt;foo&gt; &lt;ov:blid&gt; "33994949"'
    /// <see href="http://open.vocab.org/terms/blid"></see></summary>
    let blid = _prefix "blid"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/bsRGyjqyy"></see>
    /// </summary>
    let bsRGyjqyy = _prefix "bsRGyjqyy"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/bthPpNLjjQHuCC"></see>
    /// </summary>
    let bthPpNLjjQHuCC = _prefix "bthPpNLjjQHuCC"
    /// <summary>
    /// A business card associated with this resource.
    /// <see href="http://open.vocab.org/terms/businessCard"></see></summary>
    let businessCard = _prefix "businessCard"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/businessInterest"></see>
    /// </summary>
    let businessInterest = _prefix "businessInterest"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/businessInterest.html"></see>
    /// </summary>
    let ``businessInterest.html`` = _prefix "businessInterest.html"
    /// <summary>
    /// A calendar associated with this resource.
    /// <see href="http://open.vocab.org/terms/calendar"></see></summary>
    let calendar = _prefix "calendar"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/canonicalInformationResource"></see>
    /// </summary>
    let canonicalInformationResource = _prefix "canonicalInformationResource"
    /// <summary>
    /// Denotes the canonical URI that should be used to refer to this resource.
    /// <see href="http://open.vocab.org/terms/canonicalUri"></see></summary>
    let canonicalUri = _prefix "canonicalUri"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/canonicalUri.html"></see>
    /// </summary>
    let ``canonicalUri.html`` = _prefix "canonicalUri.html"
    /// <summary>
    /// A category that the resource has been classified under
    /// <see href="http://open.vocab.org/terms/category"></see></summary>
    let category = _prefix "category"
    /// <summary>
    /// The value of this property is something that has been classified under the resource
    /// <see href="http://open.vocab.org/terms/isCategoryOf"></see></summary>
    let isCategoryOf = _prefix "isCategoryOf"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/category.html"></see>
    /// </summary>
    let ``category.html`` = _prefix "category.html"
    /// <summary>
    /// Relates class to a class skeleton. If class has more than one of this relations, it should use them all.
    /// <see href="http://open.vocab.org/terms/classSkeleton"></see></summary>
    let classSkeleton = _prefix "classSkeleton"
    /// <summary>
    /// Triples using his property and its sub-properties as predicate are to be ignored by the class skeleton materialization process (http://open.vocab.org/terms/ClassSkeleton).
    ///
    /// This property is not to be used in real data, it serves just to exist and have sub-properties.
    /// <see href="http://open.vocab.org/terms/classSkeletonIgnore"></see></summary>
    let classSkeletonIgnore = _prefix "classSkeletonIgnore"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/colour"></see>
    /// </summary>
    let colour = _prefix "colour"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/colour.html"></see>
    /// </summary>
    let ``colour.html`` = _prefix "colour.html"
    /// <summary>
    /// commonEndeavour is intended to define a FRBR (Functional Requirements for Bibliographic Records) relationship between two resources that may or may not be modeled as FRBR.  This makes it possible to assert that a resource modeled using a vocabulary that does not use the FRBR entity model explicitly is describing the same Work, Expression, Manifestation, and/or Item as another resource (which may or may not use the FRBR model, as well).
    ///
    /// commonEndeavour is intended to be used merely as a superproperty for WEMI-specific subproperties to inherit from, but there are no restrictions on its use.
    /// <see href="http://open.vocab.org/terms/commonEndeavour"></see></summary>
    let commonEndeavour = _prefix "commonEndeavour"
    /// <summary>
    /// This property is used to declare that two resources which may or may not conform to the FRBR (Functional Requirements for Bibliographic Resources) entity model share the same Expression. An example of its use would be to relate a resource described with a vocabulary such as bibo (which does not acknowledge the FRBR model) to other resources that describe endeavours which have the same implied Expression (which could be other bibo resources or FRBR entities or anything else).
    ///
    /// The property is symmetrical, so if &lt;_:someBiboBook&gt; &lt;ov:commonExpression&gt; &lt;_:otherEdition&gt;, this also means &lt;_:otherEdition&gt; &lt;ov:commonExpression&gt; &lt;_:someBiboBook&gt;.
    ///
    /// It is not transitive.
    ///
    /// Having this property also implies ov:commonWork.
    /// <see href="http://open.vocab.org/terms/commonExpression"></see></summary>
    let commonExpression = _prefix "commonExpression"
    /// <summary>
    /// This property is used to declare that two resources which may or may not conform to the FRBR (Functional Requirements for Bibliographic Resources) entity model share the same Item. An example of its use would be to relate a resource described with a vocabulary such as bibo (which does not acknowledge the FRBR model) to other resources that describe endeavours which contains the same specific Item (which could be other bibo resources or FRBR entities or anything else). This implies identical WEMI hierarchies.
    ///
    /// The property is symmetrical, so if &lt;_:specificPhysicalItem&gt; &lt;ov:commonItem&gt; &lt;_:someArchive&gt;, this also means &lt;_:someArchive&gt; &lt;ov:commonItem&gt; &lt;_:specificPhysicalItem&gt;.
    ///
    /// It is not transitive.
    ///
    /// Having this property also entails ov:commonManifestation, ov:commonExpression and ov:commonWork.
    /// <see href="http://open.vocab.org/terms/commonItem"></see></summary>
    let commonItem = _prefix "commonItem"
    /// <summary>
    /// This property is used to declare that two resources which may or may not conform to the FRBR (Functional Requirements for Bibliographic Resources) entity model share the same Manifestation.  An example of its use would be to relate a resource described with a vocabulary such as bibo (which does not acknowledge the FRBR model) to other resources that describe endeavours which include the same implied Manifestation (which could be other bibo resources or FRBR entities or anything else).
    ///
    /// The property is symmetrical, so if &lt;_:someBiboBook&gt; &lt;ov:commonManifestation&gt; &lt;_:someFrbrWork&gt;, this also means &lt;_:someFrbrWork&gt; &lt;ov:commonManifestation&gt; &lt;_:someBiboBook&gt;.  It is not transitive.
    ///
    /// Having this property also implies ov:commonExpression and ov:commonWork.
    /// <see href="http://open.vocab.org/terms/commonManifestation"></see></summary>
    let commonManifestation = _prefix "commonManifestation"
    /// <summary>
    /// This property is used to declare that two resources which may or may not conform to the FRBR (Functional Requirements for Bibliographic Resources) entity model share the same Work. An example of its use would be to relate a resource described with a vocabulary such as bibo (which does not acknowledge the FRBR model) to other resources that describe endeavours that fall within the same implied Work (which could be other bibo resources or FRBR entities or anything else).
    ///
    /// The property is symmetrical, so if &lt;_:someBiboBook&gt; &lt;ov:commonWork&gt; &lt;_:someOtherBiboBook&gt;, this also means &lt;_:someOtherBiboBook&gt; &lt;ov:commonWork&gt; &lt;_:someBiboBook&gt;.
    ///
    /// It is not transitive.
    /// <see href="http://open.vocab.org/terms/commonWork"></see></summary>
    let commonWork = _prefix "commonWork"
    /// <summary>
    /// The Compass Direction that a Thing faces.
    /// <see href="http://open.vocab.org/terms/compassDirection"></see></summary>
    let compassDirection = _prefix "compassDirection"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/compassDirection.html"></see>
    /// </summary>
    let ``compassDirection.html`` = _prefix "compassDirection.html"
    /// <summary>
    /// :s :composedBy :o .
    /// :o is a "larger thing" that composes :s and potentially other "smaller things". :s may also establish some structural organization of the things it composes.
    /// <see href="http://open.vocab.org/terms/composedBy"></see></summary>
    let composedBy = _prefix "composedBy"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/composedBy.html"></see>
    /// </summary>
    let ``composedBy.html`` = _prefix "composedBy.html"
    /// <summary>
    /// associates a manifestation of a musical work with music artist who composed the work
    /// <see href="http://open.vocab.org/terms/composer"></see></summary>
    let composer = _prefix "composer"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/composer.html"></see>
    /// </summary>
    let ``composer.html`` = _prefix "composer.html"
    /// <summary>
    /// Describes the size of the file of a dataset in compressed state
    /// <see href="http://open.vocab.org/terms/compressedFileSize"></see></summary>
    let compressedFileSize = _prefix "compressedFileSize"
    /// <summary>
    /// A confidence level for a calculation or value.  Usually between 0 and 1.
    /// <see href="http://open.vocab.org/terms/confidence"></see></summary>
    let confidence = _prefix "confidence"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/confidence.html"></see>
    /// </summary>
    let ``confidence.html`` = _prefix "confidence.html"
    /// <summary>
    /// A country associated with this resource. This could be a country of origin or operation of an entity. For example a company may be based in a country and operate from there.
    /// <see href="http://open.vocab.org/terms/country"></see></summary>
    let country = _prefix "country"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/creation-tool-used"></see>
    /// </summary>
    let ``creation-tool-used`` = _prefix "creation-tool-used"
    /// <summary>
    /// The user-agent string of the software used by the creator of an item.
    /// <see href="http://open.vocab.org/terms/creatorUserAgent"></see></summary>
    let creatorUserAgent = _prefix "creatorUserAgent"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/creatorUserAgent.html"></see>
    /// </summary>
    let ``creatorUserAgent.html`` = _prefix "creatorUserAgent.html"
    /// <summary>
    /// The column of a comma separated value file from which this property was created.
    /// <see href="http://open.vocab.org/terms/csvCol"></see></summary>
    let csvCol = _prefix "csvCol"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/csvCol.html"></see>
    /// </summary>
    let ``csvCol.html`` = _prefix "csvCol.html"
    /// <summary>
    /// The row number of a csv from which this instance was created. This is different from the r-th entry within the table, which may be less than the csv row if the csv has title information and a header above the data.
    /// <see href="http://open.vocab.org/terms/csvRow"></see></summary>
    let csvRow = _prefix "csvRow"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/csvRow.html"></see>
    /// </summary>
    let ``csvRow.html`` = _prefix "csvRow.html"
    /// <summary>
    /// The date someone died.
    /// <see href="http://open.vocab.org/terms/dateOfDeath"></see></summary>
    let dateOfDeath = _prefix "dateOfDeath"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/dateOfDeath.html"></see>
    /// </summary>
    let ``dateOfDeath.html`` = _prefix "dateOfDeath.html"
    /// <summary>
    /// Associates properties to a class where the properties are meant to be present in some default view - basically a very light version of fresnel ;-)
    /// <see href="http://open.vocab.org/terms/defaultProperty"></see></summary>
    let defaultProperty = _prefix "defaultProperty"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/defaultProperty.html"></see>
    /// </summary>
    let ``defaultProperty.html`` = _prefix "defaultProperty.html"
    /// <summary>
    /// The things defined by this resource - for example, the terms defined by an Ontology.
    /// <see href="http://open.vocab.org/terms/defines"></see></summary>
    let defines = _prefix "defines"
    /// <summary>
    /// Teacher of the course. Should belong to the organization specified by ov:offeredBy of the course
    /// <see href="http://open.vocab.org/terms/deliveredBy"></see></summary>
    let deliveredBy = _prefix "deliveredBy"
    /// <summary>
    /// Date and time your travel will commence
    /// <see href="http://open.vocab.org/terms/departureDate"></see></summary>
    let departureDate = _prefix "departureDate"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/departureDate.html"></see>
    /// </summary>
    let ``departureDate.html`` = _prefix "departureDate.html"
    /// <summary>
    /// When :s :depicts :o, :s is communicable via a visual medium and, when transmitted, depicts the resource :o.
    /// <see href="http://open.vocab.org/terms/depicts"></see></summary>
    let depicts = _prefix "depicts"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/depicts.html"></see>
    /// </summary>
    let ``depicts.html`` = _prefix "depicts.html"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/depictsSameResourceAs"></see>
    /// </summary>
    let depictsSameResourceAs = _prefix "depictsSameResourceAs"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/depictsSameResourceAs.html"></see>
    /// </summary>
    let ``depictsSameResourceAs.html`` = _prefix "depictsSameResourceAs.html"
    /// <summary>
    /// The subject is a document that, to any extent, describes the object.
    /// <see href="http://open.vocab.org/terms/describes"></see></summary>
    let describes = _prefix "describes"
    /// <summary>
    /// A diff that goes from another resource to this one.
    /// <see href="http://open.vocab.org/terms/diffFromOther"></see></summary>
    let diffFromOther = _prefix "diffFromOther"
    /// <summary>
    /// The resource that this diff goes to.
    /// <see href="http://open.vocab.org/terms/diffTarget"></see></summary>
    let diffTarget = _prefix "diffTarget"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/diffFromOther.html"></see>
    /// </summary>
    let ``diffFromOther.html`` = _prefix "diffFromOther.html"
    /// <summary>
    /// The resource that this diff goes from.
    /// <see href="http://open.vocab.org/terms/diffSource"></see></summary>
    let diffSource = _prefix "diffSource"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/diffSource.html"></see>
    /// </summary>
    let ``diffSource.html`` = _prefix "diffSource.html"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/diffTarget.html"></see>
    /// </summary>
    let ``diffTarget.html`` = _prefix "diffTarget.html"
    /// <summary>
    /// A diff that goes from this resource to another one.
    /// <see href="http://open.vocab.org/terms/diffToOther"></see></summary>
    let diffToOther = _prefix "diffToOther"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/diffToOther.html"></see>
    /// </summary>
    let ``diffToOther.html`` = _prefix "diffToOther.html"
    /// <summary>
    /// Relates a property to a Dimension Property with identical meaning for use with the RDF DataCube vocabulary.
    /// <see href="http://open.vocab.org/terms/dimensionProperty"></see></summary>
    let dimensionProperty = _prefix "dimensionProperty"
    /// <summary>
    /// The disclaimer property links a resource to a document that details a disclaimer applied to the resource by the resource owner or other relevant party.
    /// <see href="http://open.vocab.org/terms/disclaimer"></see></summary>
    let disclaimer = _prefix "disclaimer"
    /// <summary>
    /// The disclaimerText property associates a resource with the text of a disclaimer (in the form of an rdfs:Literal) applied to the resource by the resource owner or other relevant party.
    /// <see href="http://open.vocab.org/terms/disclaimerText"></see></summary>
    let disclaimerText = _prefix "disclaimerText"
    /// <summary>
    /// A location from which a distance is measured. (A distance measurement will have two points, and a distance measurement value).
    /// <see href="http://open.vocab.org/terms/distancePoint"></see></summary>
    let distancePoint = _prefix "distancePoint"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/doesnt-live-here-anymore"></see>
    /// </summary>
    let ``doesnt-live-here-anymore`` = _prefix "doesnt-live-here-anymore"
    /// <summary>
    /// The song that is the focus of a particular earworm
    /// <see href="http://open.vocab.org/terms/earwormSong"></see></summary>
    let earwormSong = _prefix "earwormSong"
    /// <summary>
    /// A song which is the focus of a particular Earworm
    /// <see href="http://open.vocab.org/terms/isSongOfEarworm"></see></summary>
    let isSongOfEarworm = _prefix "isSongOfEarworm"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/earwormSong.html"></see>
    /// </summary>
    let ``earwormSong.html`` = _prefix "earwormSong.html"
    /// <summary>
    /// The person who experiences or suffers from a particular ear worm
    /// <see href="http://open.vocab.org/terms/earwormSufferer"></see></summary>
    let earwormSufferer = _prefix "earwormSufferer"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/earwormSufferer.html"></see>
    /// </summary>
    let ``earwormSufferer.html`` = _prefix "earwormSufferer.html"
    /// <summary>
    /// The transmitter of a particular Earworm
    /// <see href="http://open.vocab.org/terms/earwormTransmitter"></see></summary>
    let earwormTransmitter = _prefix "earwormTransmitter"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/earwormTransmitter.html"></see>
    /// </summary>
    let ``earwormTransmitter.html`` = _prefix "earwormTransmitter.html"
    /// <summary>
    /// Associates a resource with a form that can be used to edit its description. See http://patterns.dataincubator.org/book/edit-trail.html for more information.
    /// <see href="http://open.vocab.org/terms/editForm"></see></summary>
    let editForm = _prefix "editForm"
    /// <summary>
    /// The time of day that something ends.
    /// <see href="http://open.vocab.org/terms/endTime"></see></summary>
    let endTime = _prefix "endTime"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/endTime.html"></see>
    /// </summary>
    let ``endTime.html`` = _prefix "endTime.html"
    /// <summary>
    /// This property is to be used to relate a resource to an "enhanced description". An enhanced description is one that provides additional, richer detail about a resource than may typically be obtained by a simple de-reference of the resource's URI.
    /// <see href="http://open.vocab.org/terms/enhancedDescription"></see></summary>
    let enhancedDescription = _prefix "enhancedDescription"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/enhancedDescription.html"></see>
    /// </summary>
    let ``enhancedDescription.html`` = _prefix "enhancedDescription.html"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/exampleInstance"></see>
    /// </summary>
    let exampleInstance = _prefix "exampleInstance"
    /// <summary>
    /// an example resource using a vocabulary term or terms
    /// <see href="http://open.vocab.org/terms/exampleResource"></see></summary>
    let exampleResource = _prefix "exampleResource"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/exampleResource.html"></see>
    /// </summary>
    let ``exampleResource.html`` = _prefix "exampleResource.html"
    /// <summary>
    /// Eye Color
    /// <see href="http://open.vocab.org/terms/eyeColor"></see></summary>
    let eyeColor = _prefix "eyeColor"
    /// <summary>
    /// The name used in familiar situations by friends, e.g. Ian
    ///
    /// <see href="http://open.vocab.org/terms/familiarName"></see></summary>
    let familiarName = _prefix "familiarName"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/familiarName.html"></see>
    /// </summary>
    let ``familiarName.html`` = _prefix "familiarName.html"
    /// <summary>
    /// A drink, alcoholic or not, that the person in question is particularly fond of. It's what they would typically order in a place where the drink is available. The object can be a literal stating the name of the drink, or (preferred) an RDF resource.
    /// <see href="http://open.vocab.org/terms/favouriteDrink"></see></summary>
    let favouriteDrink = _prefix "favouriteDrink"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/favouriteDrink.html"></see>
    /// </summary>
    let ``favouriteDrink.html`` = _prefix "favouriteDrink.html"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/favouritedBy"></see>
    /// </summary>
    let favouritedBy = _prefix "favouritedBy"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/favouritedBy.html"></see>
    /// </summary>
    let ``favouritedBy.html`` = _prefix "favouritedBy.html"
    /// <summary>
    /// A fax number that can be used to send faxes to a Person or Organisation.
    /// <see href="http://open.vocab.org/terms/faxNumber"></see></summary>
    let faxNumber = _prefix "faxNumber"
    /// <summary>
    /// associates a musical item with a feature file describing that item
    /// <see href="http://open.vocab.org/terms/featurefile"></see></summary>
    let featurefile = _prefix "featurefile"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/featurefile.html"></see>
    /// </summary>
    let ``featurefile.html`` = _prefix "featurefile.html"
    /// <summary>
    /// Describes the size of the file of a dataset in the normal (uncompressed) state
    /// <see href="http://open.vocab.org/terms/fileSize"></see></summary>
    let fileSize = _prefix "fileSize"
    /// <summary>
    /// The place at which a thing is found.
    /// <see href="http://open.vocab.org/terms/findspot"></see></summary>
    let findspot = _prefix "findspot"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/findspot.html"></see>
    /// </summary>
    let ``findspot.html`` = _prefix "findspot.html"
    /// <summary>
    /// The first sentence of a resource.
    /// <see href="http://open.vocab.org/terms/firstSentence"></see></summary>
    let firstSentence = _prefix "firstSentence"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/firstSentence.html"></see>
    /// </summary>
    let ``firstSentence.html`` = _prefix "firstSentence.html"
    /// <summary>
    /// Use this property to state that you admire a friend's fro
    /// <see href="http://open.vocab.org/terms/foafro"></see></summary>
    let foafro = _prefix "foafro"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/foafro.html"></see>
    /// </summary>
    let ``foafro.html`` = _prefix "foafro.html"
    /// <summary>
    /// The name used when referred to in formal situations, e.g. Mr. Davis
    ///
    /// <see href="http://open.vocab.org/terms/formalName"></see></summary>
    let formalName = _prefix "formalName"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/formalName.html"></see>
    /// </summary>
    let ``formalName.html`` = _prefix "formalName.html"
    /// <summary>
    /// The full name as expected to be used on an identifying document e.g. Mr Ian Robert Davis
    ///
    /// <see href="http://open.vocab.org/terms/fullName"></see></summary>
    let fullName = _prefix "fullName"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/fullName.html"></see>
    /// </summary>
    let ``fullName.html`` = _prefix "fullName.html"
    /// <summary>
    /// The agent that defines the boundaries of a geographic area.
    /// <see href="http://open.vocab.org/terms/geoBoundaryDefiner"></see></summary>
    let geoBoundaryDefiner = _prefix "geoBoundaryDefiner"
    /// <summary>
    /// The value of this property is a QRCode image that encodes the geographic coordinates of the resource. The coordinates are encoded using the WGS84 datum in the following form - geo:[lat],[long]
    /// <see href="http://open.vocab.org/terms/geoqrcode"></see></summary>
    let geoqrcode = _prefix "geoqrcode"
    /// <summary>
    /// Boundary point has a position
    /// <see href="http://open.vocab.org/terms/has"></see></summary>
    let has = _prefix "has"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/has.html"></see>
    /// </summary>
    let ``has.html`` = _prefix "has.html"
    /// <summary>
    /// DOMRange has 2 boundary points
    /// <see href="http://open.vocab.org/terms/hasBoundary"></see></summary>
    let hasBoundary = _prefix "hasBoundary"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hasBoundary.html"></see>
    /// </summary>
    let ``hasBoundary.html`` = _prefix "hasBoundary.html"
    /// <summary>
    /// has checksum - expecting (acronym/name):(checksum hexdigest)
    ///
    /// eg        ov:hasChecksum  "sha1:a526a7c1bc65348dc7649556bee283ee3c999b92"
    /// <see href="http://open.vocab.org/terms/hasChecksum"></see></summary>
    let hasChecksum = _prefix "hasChecksum"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hasChecksum.html"></see>
    /// </summary>
    let ``hasChecksum.html`` = _prefix "hasChecksum.html"
    /// <summary>
    /// Encoding MIME-Type information in a trivial manner - equivalent to HTTP header: Content-Type.
    /// <see href="http://open.vocab.org/terms/hasContentType"></see></summary>
    let hasContentType = _prefix "hasContentType"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hasContentType.html"></see>
    /// </summary>
    let ``hasContentType.html`` = _prefix "hasContentType.html"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hasFavourited"></see>
    /// </summary>
    let hasFavourited = _prefix "hasFavourited"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hasFavourited.html"></see>
    /// </summary>
    let ``hasFavourited.html`` = _prefix "hasFavourited.html"
    /// <summary>
    /// Domain: any institution or individual who borrows money from loaner
    /// Range: any institution or individual who loans a borrower money
    /// <see href="http://open.vocab.org/terms/hasLender"></see></summary>
    let hasLender = _prefix "hasLender"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Borrower"></see>
    /// </summary>
    let Borrower = _prefix "Borrower"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Loaner"></see>
    /// </summary>
    let Loaner = _prefix "Loaner"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hasMD5"></see>
    /// </summary>
    let hasMD5 = _prefix "hasMD5"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hasMD5.html"></see>
    /// </summary>
    let ``hasMD5.html`` = _prefix "hasMD5.html"
    /// <summary>
    /// Links a person to a country that he or she may be a member. (A person can have multiple nationalities). The domain is foaf:Person but the range is open (although http://dbpedia.org/ontology/Country or http://umbel.org/umbel/rc/Country are suggested)
    /// <see href="http://open.vocab.org/terms/hasNationality"></see></summary>
    let hasNationality = _prefix "hasNationality"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hasNode"></see>
    /// </summary>
    let hasNode = _prefix "hasNode"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hasNode.html"></see>
    /// </summary>
    let ``hasNode.html`` = _prefix "hasNode.html"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hasOffset"></see>
    /// </summary>
    let hasOffset = _prefix "hasOffset"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hasOffset.html"></see>
    /// </summary>
    let ``hasOffset.html`` = _prefix "hasOffset.html"
    /// <summary>
    /// Something has a plot.
    /// <see href="http://open.vocab.org/terms/hasPlot"></see></summary>
    let hasPlot = _prefix "hasPlot"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hasPlot.html"></see>
    /// </summary>
    let ``hasPlot.html`` = _prefix "hasPlot.html"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hasPosition"></see>
    /// </summary>
    let hasPosition = _prefix "hasPosition"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hasPosition.html"></see>
    /// </summary>
    let ``hasPosition.html`` = _prefix "hasPosition.html"
    /// <summary>
    /// a resource (e.g. HTML content --&gt; awol:Content) has a DOM range
    /// <see href="http://open.vocab.org/terms/hasRange"></see></summary>
    let hasRange = _prefix "hasRange"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hasRange.html"></see>
    /// </summary>
    let ``hasRange.html`` = _prefix "hasRange.html"
    /// <summary>
    /// Slang for loves.
    /// <see href="http://open.vocab.org/terms/hearts"></see></summary>
    let hearts = _prefix "hearts"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hearts.html"></see>
    /// </summary>
    let ``hearts.html`` = _prefix "hearts.html"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/homepage"></see>
    /// </summary>
    let homepage = _prefix "homepage"
    /// <summary>
    /// color of a house
    /// <see href="http://open.vocab.org/terms/houseColor"></see></summary>
    let houseColor = _prefix "houseColor"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Colors"></see>
    /// </summary>
    let Colors = _prefix "Colors"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/housePaintColor"></see>
    /// </summary>
    let housePaintColor = _prefix "housePaintColor"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/colorsOfHouses"></see>
    /// </summary>
    let colorsOfHouses = _prefix "colorsOfHouses"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/houseColor.html"></see>
    /// </summary>
    let ``houseColor.html`` = _prefix "houseColor.html"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hudBefore"></see>
    /// </summary>
    let hudBefore = _prefix "hudBefore"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hudBefore.html"></see>
    /// </summary>
    let ``hudBefore.html`` = _prefix "hudBefore.html"
    /// <summary>
    /// The number of loans two books have in common
    /// <see href="http://open.vocab.org/terms/hudCommon"></see></summary>
    let hudCommon = _prefix "hudCommon"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hudCommon.html"></see>
    /// </summary>
    let ``hudCommon.html`` = _prefix "hudCommon.html"
    /// <summary>
    /// A course associated with a book loan
    /// <see href="http://open.vocab.org/terms/hudCourse"></see></summary>
    let hudCourse = _prefix "hudCourse"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hudCourse.html"></see>
    /// </summary>
    let ``hudCourse.html`` = _prefix "hudCourse.html"
    /// <summary>
    /// The number of loans of a book within a year, school, or course
    /// <see href="http://open.vocab.org/terms/hudLoanCount"></see></summary>
    let hudLoanCount = _prefix "hudLoanCount"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hudLoanCount.html"></see>
    /// </summary>
    let ``hudLoanCount.html`` = _prefix "hudLoanCount.html"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hudLoanTotal"></see>
    /// </summary>
    let hudLoanTotal = _prefix "hudLoanTotal"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hudLoanTotal.html"></see>
    /// </summary>
    let ``hudLoanTotal.html`` = _prefix "hudLoanTotal.html"
    /// <summary>
    /// simultaneous loans
    /// <see href="http://open.vocab.org/terms/hudSame"></see></summary>
    let hudSame = _prefix "hudSame"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hudSame.html"></see>
    /// </summary>
    let ``hudSame.html`` = _prefix "hudSame.html"
    /// <summary>
    /// The school associated with the loan history of a book
    /// <see href="http://open.vocab.org/terms/hudSchool"></see></summary>
    let hudSchool = _prefix "hudSchool"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hudSchool.html"></see>
    /// </summary>
    let ``hudSchool.html`` = _prefix "hudSchool.html"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hudSchoolLoan"></see>
    /// </summary>
    let hudSchoolLoan = _prefix "hudSchoolLoan"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hudSchoolLoan.html"></see>
    /// </summary>
    let ``hudSchoolLoan.html`` = _prefix "hudSchoolLoan.html"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hudSuggestedBook"></see>
    /// </summary>
    let hudSuggestedBook = _prefix "hudSuggestedBook"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hudSuggestion"></see>
    /// </summary>
    let hudSuggestion = _prefix "hudSuggestion"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hudSuggestion.html"></see>
    /// </summary>
    let ``hudSuggestion.html`` = _prefix "hudSuggestion.html"
    /// <summary>
    /// The year associated with a loan history
    /// <see href="http://open.vocab.org/terms/hudYear"></see></summary>
    let hudYear = _prefix "hudYear"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hudYear.html"></see>
    /// </summary>
    let ``hudYear.html`` = _prefix "hudYear.html"
    /// <summary>
    /// a pictorial representation for something.
    /// <see href="http://open.vocab.org/terms/icon"></see></summary>
    let icon = _prefix "icon"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/imWsBhgGVLi"></see>
    /// </summary>
    let imWsBhgGVLi = _prefix "imWsBhgGVLi"
    /// <summary>
    /// an image of the resource, whatever it may be. Typically the value of this property will be the URI of some sort of digital image.
    /// <see href="http://open.vocab.org/terms/image"></see></summary>
    let image = _prefix "image"
    /// <summary>
    /// The name used when referred to in informal situations, e.g. Ian Davis
    ///
    /// <see href="http://open.vocab.org/terms/informalName"></see></summary>
    let informalName = _prefix "informalName"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/informalName.html"></see>
    /// </summary>
    let ``informalName.html`` = _prefix "informalName.html"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/isCategoryOf.html"></see>
    /// </summary>
    let ``isCategoryOf.html`` = _prefix "isCategoryOf.html"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/isCuratedBy"></see>
    /// </summary>
    let isCuratedBy = _prefix "isCuratedBy"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/isCuratedBy.html"></see>
    /// </summary>
    let ``isCuratedBy.html`` = _prefix "isCuratedBy.html"
    /// <summary>
    /// DOMBoundaryPointPosition is defines by a DOMNode and a DOMOffset
    /// <see href="http://open.vocab.org/terms/isDefinedBy"></see></summary>
    let isDefinedBy = _prefix "isDefinedBy"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/isDefinedBy.html"></see>
    /// </summary>
    let ``isDefinedBy.html`` = _prefix "isDefinedBy.html"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/isHeaderOf"></see>
    /// </summary>
    let isHeaderOf = _prefix "isHeaderOf"
    /// <summary>
    /// Property to link an agent with an organization (inverse property of http://xmlns.com/foaf/0.1/member)
    /// <see href="http://open.vocab.org/terms/isMemberOf"></see></summary>
    let isMemberOf = _prefix "isMemberOf"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/isHeaderOf.html"></see>
    /// </summary>
    let ``isHeaderOf.html`` = _prefix "isHeaderOf.html"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/isSongOfEarworm.html"></see>
    /// </summary>
    let ``isSongOfEarworm.html`` = _prefix "isSongOfEarworm.html"
    /// <summary>
    /// The JSON representation of a (usually small) dataset.
    /// <see href="http://open.vocab.org/terms/json"></see></summary>
    let json = _prefix "json"
    /// <summary>
    /// A comma separated list of words that are particularly pertinent to this resource.
    /// <see href="http://open.vocab.org/terms/keywords"></see></summary>
    let keywords = _prefix "keywords"
    /// <summary>
    /// The number of kilometres of a distance measurement.
    /// <see href="http://open.vocab.org/terms/kilometres"></see></summary>
    let kilometres = _prefix "kilometres"
    /// <summary>
    /// to express kudos to someone (acknowledge a contribution, feedback, etc.)
    /// <see href="http://open.vocab.org/terms/kudosTo"></see></summary>
    let kudosTo = _prefix "kudosTo"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/kudosTo.html"></see>
    /// </summary>
    let ``kudosTo.html`` = _prefix "kudosTo.html"
    /// <summary>
    /// The most recently cached static page describing the resource.
    /// <see href="http://open.vocab.org/terms/lastCachedPage"></see></summary>
    let lastCachedPage = _prefix "lastCachedPage"
    /// <summary>
    /// The linear extent of a thing.
    /// <see href="http://open.vocab.org/terms/length"></see></summary>
    let length = _prefix "length"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/length.html"></see>
    /// </summary>
    let ``length.html`` = _prefix "length.html"
    /// <summary>
    /// A service providing access to bibliographic resources.
    /// <see href="http://open.vocab.org/terms/libraryService"></see></summary>
    let libraryService = _prefix "libraryService"
    /// <summary>
    /// a machine tag that can be used to identify the domain resource in tagging applications.
    /// <see href="http://open.vocab.org/terms/machineTag"></see></summary>
    let machineTag = _prefix "machineTag"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/machineTag.html"></see>
    /// </summary>
    let ``machineTag.html`` = _prefix "machineTag.html"
    /// <summary>
    /// The place where a particular object was made. (Made is left intentionally vague and follows the same semantics as foaf:maker, foaf:made etc.)
    /// <see href="http://open.vocab.org/terms/madeIn"></see></summary>
    let madeIn = _prefix "madeIn"
    /// <summary>
    /// A person's maiden name.
    /// <see href="http://open.vocab.org/terms/maidenName"></see></summary>
    let maidenName = _prefix "maidenName"
    /// <summary>
    /// The Manchester Syntax for a owl construct (e.g., Restriction).
    ///
    /// :manchex rdfs:subPropertyOf rdfs:label .
    /// <see href="http://open.vocab.org/terms/manchax"></see></summary>
    let manchax = _prefix "manchax"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/manchax.html"></see>
    /// </summary>
    let ``manchax.html`` = _prefix "manchax.html"
    /// <summary>
    /// Indicates a resource that is designed to be a mirror or surrogate of the object resource; a backup copy, should the object resource be lost or unobtainable.
    /// <see href="http://open.vocab.org/terms/mirror"></see></summary>
    let mirror = _prefix "mirror"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/mirror.html"></see>
    /// </summary>
    let ``mirror.html`` = _prefix "mirror.html"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/mllxMBbjeh"></see>
    /// </summary>
    let mllxMBbjeh = _prefix "mllxMBbjeh"
    /// <summary>
    /// The Vehicle Classes an MOT Test Station is authorised to test, as a comma separated list using Arabic numerals (plus A where appropriate), e.g "3, 4, 4A, 5".
    /// <see href="http://open.vocab.org/terms/motVehicleClasses"></see></summary>
    let motVehicleClasses = _prefix "motVehicleClasses"
    /// <summary>
    /// Places named in a text.
    /// <see href="http://open.vocab.org/terms/namedPlace"></see></summary>
    let namedPlace = _prefix "namedPlace"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/namedPlace.html"></see>
    /// </summary>
    let ``namedPlace.html`` = _prefix "namedPlace.html"
    /// <summary>
    /// A (UK) national grid reference for a given location, using the alphanumeric syntax.
    /// <see href="http://open.vocab.org/terms/national-grid-reference"></see></summary>
    let ``national-grid-reference`` = _prefix "national-grid-reference"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/national-grid-reference.html"></see>
    /// </summary>
    let ``national-grid-reference.html`` = _prefix "national-grid-reference.html"
    /// <summary>
    /// This property is a relationship between some thing and a map that shows that thing's location at a national scale.
    /// <see href="http://open.vocab.org/terms/nationalContextMap"></see></summary>
    let nationalContextMap = _prefix "nationalContextMap"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/nationalContextMap.html"></see>
    /// </summary>
    let ``nationalContextMap.html`` = _prefix "nationalContextMap.html"
    /// <summary>
    /// x is 'near' y if they are near to each other in physical space, for a deliberately vague notion of near.
    /// <see href="http://open.vocab.org/terms/near"></see></summary>
    let near = _prefix "near"
    /// <summary>
    /// The desired visibility of a User's social network. Suggested options: "Just Me", "My Network", "Everyone".
    /// <see href="http://open.vocab.org/terms/networkVisibility"></see></summary>
    let networkVisibility = _prefix "networkVisibility"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/networkVisibility.html"></see>
    /// </summary>
    let ``networkVisibility.html`` = _prefix "networkVisibility.html"
    /// <summary>
    /// a total count of the number of resources of type &lt;http://purl.org/stuff/rev#Review&gt; that an Agent is known to have created
    /// <see href="http://open.vocab.org/terms/noOfReviewsWritten"></see></summary>
    let noOfReviewsWritten = _prefix "noOfReviewsWritten"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/noOfReviewsWritten.html"></see>
    /// </summary>
    let ``noOfReviewsWritten.html`` = _prefix "noOfReviewsWritten.html"
    /// <summary>
    /// The number of pages a resource has
    /// <see href="http://open.vocab.org/terms/numberOfPages"></see></summary>
    let numberOfPages = _prefix "numberOfPages"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/numberOfPages.html"></see>
    /// </summary>
    let ``numberOfPages.html`` = _prefix "numberOfPages.html"
    /// <summary>
    /// Organization who offers the course, e.g. a department, a school, a research institute
    /// <see href="http://open.vocab.org/terms/offeredBy"></see></summary>
    let offeredBy = _prefix "offeredBy"
    /// <summary>
    /// Course offered by the organization
    /// <see href="http://open.vocab.org/terms/offersCourse"></see></summary>
    let offersCourse = _prefix "offersCourse"
    /// <summary>
    /// the okkam ID of the entity, given in human legible form (literal)
    /// <see href="http://open.vocab.org/terms/okkamID"></see></summary>
    let okkamID = _prefix "okkamID"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/okkamID.html"></see>
    /// </summary>
    let ``okkamID.html`` = _prefix "okkamID.html"
    /// <summary>
    /// The source of a thing.
    /// <see href="http://open.vocab.org/terms/origin"></see></summary>
    let origin = _prefix "origin"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/origin.html"></see>
    /// </summary>
    let ``origin.html`` = _prefix "origin.html"
    /// <summary>
    /// A thing that came into existence at a place and time originates from that place and time.
    /// <see href="http://open.vocab.org/terms/originatesFrom"></see></summary>
    let originatesFrom = _prefix "originatesFrom"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/originatesFrom.html"></see>
    /// </summary>
    let ``originatesFrom.html`` = _prefix "originatesFrom.html"
    /// <summary>
    /// An element of a whole.
    /// <see href="http://open.vocab.org/terms/part"></see></summary>
    let part = _prefix "part"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/part.html"></see>
    /// </summary>
    let ``part.html`` = _prefix "part.html"
    /// <summary>
    /// a password usually stored in md5
    /// <see href="http://open.vocab.org/terms/passwd"></see></summary>
    let passwd = _prefix "passwd"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/passwd.html"></see>
    /// </summary>
    let ``passwd.html`` = _prefix "passwd.html"
    /// <summary>
    /// 7dFHvo  &lt;a href="http://nussehqldled.com/"&gt;nussehqldled&lt;/a&gt;, [url=http://uvurwqyxjgik.com/]uvurwqyxjgik[/url], [link=http://yqeuzuciwezi.com/]yqeuzuciwezi[/link], http://sdzwxhzsaaqq.com/
    /// <see href="http://open.vocab.org/terms/performer"></see></summary>
    let performer = _prefix "performer"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/performer.html"></see>
    /// </summary>
    let ``performer.html`` = _prefix "performer.html"
    /// <summary>
    /// A telephone number that can be used to contact a Person or Organisation.
    /// <see href="http://open.vocab.org/terms/phoneNumber"></see></summary>
    let phoneNumber = _prefix "phoneNumber"
    /// <summary>
    /// A plot of anything.
    /// <see href="http://open.vocab.org/terms/plot"></see></summary>
    let plot = _prefix "plot"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/plot.html"></see>
    /// </summary>
    let ``plot.html`` = _prefix "plot.html"
    /// <summary>
    /// A postal address to which letters and parcels can be sent to a Person or Organisation.
    /// <see href="http://open.vocab.org/terms/postalAddress"></see></summary>
    let postalAddress = _prefix "postalAddress"
    /// <summary>
    /// Preferred or official acronym as used by the subject.
    /// <see href="http://open.vocab.org/terms/prefAcronym"></see></summary>
    let prefAcronym = _prefix "prefAcronym"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/prefAcronym.html"></see>
    /// </summary>
    let ``prefAcronym.html`` = _prefix "prefAcronym.html"
    /// <summary>
    /// The preferred animal of a person.
    /// <see href="http://open.vocab.org/terms/preferredAnimal"></see></summary>
    let preferredAnimal = _prefix "preferredAnimal"
    /// <summary>
    /// The primary material from which something is made.
    ///
    /// Examples: leather (shoe), paper (book), cotton (t-shirt), nylon (tights), plastic (carrier bag), rubber (wellington boots), iron (pipe) etc.
    /// <see href="http://open.vocab.org/terms/primaryMaterial"></see></summary>
    let primaryMaterial = _prefix "primaryMaterial"
    /// <summary>
    /// It is about provenance of web data.
    /// <see href="http://open.vocab.org/terms/provenance"></see></summary>
    let provenance = _prefix "provenance"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/quote"></see>
    /// </summary>
    let quote = _prefix "quote"
    /// <summary>
    /// The rank of the resource within the ordered collection represented by the current document
    /// <see href="http://open.vocab.org/terms/rank"></see></summary>
    let rank = _prefix "rank"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/rank.html"></see>
    /// </summary>
    let ``rank.html`` = _prefix "rank.html"
    /// <summary>
    /// express the ability/right to read from a graph
    /// <see href="http://open.vocab.org/terms/readGraph"></see></summary>
    let readGraph = _prefix "readGraph"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/readGraph.html"></see>
    /// </summary>
    let ``readGraph.html`` = _prefix "readGraph.html"
    /// <summary>
    /// A property to capture an un-intepreted written address, notably for addresses that have yet to be or can never be semantically represented using an existing scheme, such as the vcard ontology.
    /// <see href="http://open.vocab.org/terms/recordedAddress"></see></summary>
    let recordedAddress = _prefix "recordedAddress"
    /// <summary>
    /// This property is a relationship between some thing and a map that shows that thing's location at a regional scale.
    /// <see href="http://open.vocab.org/terms/regionalContextMap"></see></summary>
    let regionalContextMap = _prefix "regionalContextMap"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/regionalContextMap.html"></see>
    /// </summary>
    let ``regionalContextMap.html`` = _prefix "regionalContextMap.html"
    /// <summary>
    /// Defines reincarnation of someone
    /// <see href="http://open.vocab.org/terms/reincarnationOf"></see></summary>
    let reincarnationOf = _prefix "reincarnationOf"
    /// <summary>
    /// Organization who is responsible for (offers) the course. Like a department, a school...
    /// <see href="http://open.vocab.org/terms/responsiblityOf"></see></summary>
    let responsiblityOf = _prefix "responsiblityOf"
    /// <summary>
    /// The result of the test case obtained from the target specified. For example, the target could be a script that is executed.
    /// <see href="http://open.vocab.org/terms/resultFrom"></see></summary>
    let resultFrom = _prefix "resultFrom"
    /// <summary>
    /// The diameter of a thing measured at its rim.
    /// <see href="http://open.vocab.org/terms/rimDiameter"></see></summary>
    let rimDiameter = _prefix "rimDiameter"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/rimDiameter.html"></see>
    /// </summary>
    let ``rimDiameter.html`` = _prefix "rimDiameter.html"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/rtfm"></see>
    /// </summary>
    let rtfm = _prefix "rtfm"
    /// <summary>
    /// A screenshot showing the (software) project in action. Since DOAP only has a property to link a "web page with screenshots of project", not a specific screenshot, this property is sometimes more useful.
    /// <see href="http://open.vocab.org/terms/screenshot"></see></summary>
    let screenshot = _prefix "screenshot"
    /// <summary>
    /// Semester in which the course is offered
    /// <see href="http://open.vocab.org/terms/semester"></see></summary>
    let semester = _prefix "semester"
    /// <summary>
    /// The shape of something
    /// <see href="http://open.vocab.org/terms/shape"></see></summary>
    let shape = _prefix "shape"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/shape.html"></see>
    /// </summary>
    let ``shape.html`` = _prefix "shape.html"
    /// <summary>
    /// Just a simple readable name, a mnemonic.
    /// <see href="http://open.vocab.org/terms/shortName"></see></summary>
    let shortName = _prefix "shortName"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/shortName.html"></see>
    /// </summary>
    let ``shortName.html`` = _prefix "shortName.html"
    /// <summary>
    /// Relate a thing (usually a person) to the scent with which they are most commonly associated.
    /// <see href="http://open.vocab.org/terms/signatureScent"></see></summary>
    let signatureScent = _prefix "signatureScent"
    /// <summary>
    /// Having two things that are not the owl:sameAs but are similar to a certain extent. It is thought of being used where owl:sameAs is too strong but rdfs:seeAlso is too loose. Motivation: http://lists.w3.org/Archives/Public/public-lod/2009Feb/0189.html
    /// <see href="http://open.vocab.org/terms/similarTo"></see></summary>
    let similarTo = _prefix "similarTo"
    /// <summary>
    /// The number of results retrieved for a search on that uri from the Search Engine sindice
    /// <see href="http://open.vocab.org/terms/sindiceResultCount"></see></summary>
    let sindiceResultCount = _prefix "sindiceResultCount"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/sindiceResultCount.html"></see>
    /// </summary>
    let ``sindiceResultCount.html`` = _prefix "sindiceResultCount.html"
    /// <summary>
    /// Someone's ID in the Skype chat and telephony service.
    /// <see href="http://open.vocab.org/terms/skypeID"></see></summary>
    let skypeID = _prefix "skypeID"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/skypeID.html"></see>
    /// </summary>
    let ``skypeID.html`` = _prefix "skypeID.html"
    /// <summary>
    /// Associate a name that can be used for sorting to a foaf:Agent
    /// <see href="http://open.vocab.org/terms/sort-name"></see></summary>
    let ``sort-name`` = _prefix "sort-name"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/sort-name.html"></see>
    /// </summary>
    let ``sort-name.html`` = _prefix "sort-name.html"
    /// <summary>
    /// A label for a resource that is syntactically arranged to be suitable for sorting
    /// <see href="http://open.vocab.org/terms/sortLabel"></see></summary>
    let sortLabel = _prefix "sortLabel"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/sortLabel.html"></see>
    /// </summary>
    let ``sortLabel.html`` = _prefix "sortLabel.html"
    /// <summary>
    /// associates a given feature file document with the audio file that is described by that document
    /// <see href="http://open.vocab.org/terms/sourcefile"></see></summary>
    let sourcefile = _prefix "sourcefile"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/sourcefile.html"></see>
    /// </summary>
    let ``sourcefile.html`` = _prefix "sourcefile.html"
    /// <summary>
    /// The specification(s) that the resource implemented.
    /// <see href="http://open.vocab.org/terms/specification"></see></summary>
    let specification = _prefix "specification"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/specification.html"></see>
    /// </summary>
    let ``specification.html`` = _prefix "specification.html"
    /// <summary>
    /// The time of day that something starts at.
    /// <see href="http://open.vocab.org/terms/startTime"></see></summary>
    let startTime = _prefix "startTime"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/startTime.html"></see>
    /// </summary>
    let ``startTime.html`` = _prefix "startTime.html"
    /// <summary>
    /// Asserts that a reified rdf:Statement is asserted (in a non-reified form) by a particular RDF graph.
    /// <see href="http://open.vocab.org/terms/statement"></see></summary>
    let statement = _prefix "statement"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/statement.html"></see>
    /// </summary>
    let ``statement.html`` = _prefix "statement.html"
    /// <summary>
    /// A human readable description of the status of an opmv:Process upon completion.
    /// <see href="http://open.vocab.org/terms/status"></see></summary>
    let status = _prefix "status"
    /// <summary>
    /// The the measure of how sticky something is
    /// <see href="http://open.vocab.org/terms/stickiness"></see></summary>
    let stickiness = _prefix "stickiness"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/stickiness.html"></see>
    /// </summary>
    let ``stickiness.html`` = _prefix "stickiness.html"
    /// <summary>
    /// A topic or work that is studied by a person or group (e.g., a university course)
    /// <see href="http://open.vocab.org/terms/studies"></see></summary>
    let studies = _prefix "studies"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/studies.html"></see>
    /// </summary>
    let ``studies.html`` = _prefix "studies.html"
    /// <summary>
    /// An additional or secondary title usually used expand or limit the main title
    /// <see href="http://open.vocab.org/terms/subtitle"></see></summary>
    let subtitle = _prefix "subtitle"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/subtitle.html"></see>
    /// </summary>
    let ``subtitle.html`` = _prefix "subtitle.html"
    /// <summary>
    /// Relates a person to an earworm that they suffer.
    /// <see href="http://open.vocab.org/terms/suffersEarworm"></see></summary>
    let suffersEarworm = _prefix "suffersEarworm"
    /// <summary>
    /// An agent syndicates a document some way.
    /// <see href="http://open.vocab.org/terms/syndicates"></see></summary>
    let syndicates = _prefix "syndicates"
    /// <summary>
    /// the number of times a tag has been used in taggings of things
    /// <see href="http://open.vocab.org/terms/taggingCount"></see></summary>
    let taggingCount = _prefix "taggingCount"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/taggingCount.html"></see>
    /// </summary>
    let ``taggingCount.html`` = _prefix "taggingCount.html"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/teaches"></see>
    /// </summary>
    let teaches = _prefix "teaches"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/teaches.html"></see>
    /// </summary>
    let ``teaches.html`` = _prefix "teaches.html"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/test"></see>
    /// </summary>
    let test = _prefix "test"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/twitter-id"></see>
    /// </summary>
    let ``twitter-id`` = _prefix "twitter-id"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/twitter-id.html"></see>
    /// </summary>
    let ``twitter-id.html`` = _prefix "twitter-id.html"
    /// <summary>
    /// An Internet host used in the context of an opmv:Process.
    /// <see href="http://open.vocab.org/terms/usedHost"></see></summary>
    let usedHost = _prefix "usedHost"
    /// <summary>
    /// The subject (perhaps a foaf:Agent) made HTTP requests with a header described by this http:MessageHeader resource.
    /// <see href="http://open.vocab.org/terms/usedHttpHeader"></see></summary>
    let usedHttpHeader = _prefix "usedHttpHeader"
    /// <summary>
    /// links to a thing used by an agent
    /// <see href="http://open.vocab.org/terms/uses"></see></summary>
    let uses = _prefix "uses"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/uses.html"></see>
    /// </summary>
    let ``uses.html`` = _prefix "uses.html"
    /// <summary>
    /// To mark the beginning date or event at which the named graph object is true/accurate.
    /// <see href="http://open.vocab.org/terms/validFrom"></see></summary>
    let validFrom = _prefix "validFrom"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/validFrom.html"></see>
    /// </summary>
    let ``validFrom.html`` = _prefix "validFrom.html"
    /// <summary>
    /// To mark the date or event at which the named graph object ceases to be accurate.
    /// <see href="http://open.vocab.org/terms/validUntil"></see></summary>
    let validUntil = _prefix "validUntil"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/validUntil.html"></see>
    /// </summary>
    let ``validUntil.html`` = _prefix "validUntil.html"
    /// <summary>
    /// Property to encode the version of things - simple intent, to record the sequence of items. (The items themselves will have temporal/finer grained detail)
    /// <see href="http://open.vocab.org/terms/versionnumber"></see></summary>
    let versionnumber = _prefix "versionnumber"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/versionnumber.html"></see>
    /// </summary>
    let ``versionnumber.html`` = _prefix "versionnumber.html"
    /// <summary>
    /// The visibility of a resource (e.g. public, internal), expressed as a literal term.
    /// <see href="http://open.vocab.org/terms/visibility"></see></summary>
    let visibility = _prefix "visibility"
    /// <summary>
    /// The weight of a resource
    /// <see href="http://open.vocab.org/terms/weight"></see></summary>
    let weight = _prefix "weight"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/weight.html"></see>
    /// </summary>
    let ``weight.html`` = _prefix "weight.html"
    /// <summary>
    /// A wiki page associated with this resource
    /// <see href="http://open.vocab.org/terms/wikiPage"></see></summary>
    let wikiPage = _prefix "wikiPage"
    /// <summary>
    /// express the ability/right to write to a graph
    /// <see href="http://open.vocab.org/terms/writeGraph"></see></summary>
    let writeGraph = _prefix "writeGraph"
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/writeGraph.html"></see>
    /// </summary>
    let ``writeGraph.html`` = _prefix "writeGraph.html"

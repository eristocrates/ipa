namespace http._open.vocab.org.terms.slash

open DoxAletheia.Rdf_Vocabulary

module open_ =
    let _namespace_name = "http://open.vocab.org/terms/"

    /// <summary>
    /// The ceramic ware produced during the Roman period in the region of what is now the modern country of Tunisia.
    /// <see href="http://open.vocab.org/terms/AfricanRedSlip"></see></summary>
    let AfricanRedSlip =
        Namespaced_IRI.parse _namespace_name "AfricanRedSlip" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/markdownDescription"></see>
    /// </summary>
    let markdownDescription =
        Namespaced_IRI.parse _namespace_name "markdownDescription" |> NamespacedName

    /// <summary>
    /// Generic term for category of ceramics that may be distinguished by function, surface treatment, distinguishing features of clay, or other set of criteria as defined by usage. Commonly used in the discipline of Archaeology.
    /// <see href="http://open.vocab.org/terms/Ware"></see></summary>
    let Ware = Namespaced_IRI.parse _namespace_name "Ware" |> NamespacedName

    /// <summary>
    /// It is a major goal of Amateur Radio Operators to make contact with each other.  This contact is formally defined as the exchange of certain information, usually consisting of each operator's call sign and a signal report (how well each operator receives the signal of the other).  A contact can last a few seconds to many minutes.  Nickname "QSL".
    /// <see href="http://open.vocab.org/terms/AmateurRadioContact"></see></summary>
    let AmateurRadioContact =
        Namespaced_IRI.parse _namespace_name "AmateurRadioContact" |> NamespacedName

    /// <summary>
    /// A person who is licensed in at least one ITU region to operate (transmit and receive) a radio using frequencies and modes permitted only  to licensed persons.
    /// <see href="http://open.vocab.org/terms/AmateurRadioOperator"></see></summary>
    let AmateurRadioOperator =
        Namespaced_IRI.parse _namespace_name "AmateurRadioOperator" |> NamespacedName

    /// <summary>
    /// A type of dataset that contains annotations on a set of resources.
    /// <see href="http://open.vocab.org/terms/AnnotationSet"></see></summary>
    let AnnotationSet =
        Namespaced_IRI.parse _namespace_name "AnnotationSet" |> NamespacedName

    /// <summary>
    /// Automobiles, when presented as a catalog, are generally categorized using the Car Maker / Car Model / Trim Package hierarchy.
    /// <see href="http://open.vocab.org/terms/AutomobileCataologType"></see></summary>
    let AutomobileCataologType =
        Namespaced_IRI.parse _namespace_name "AutomobileCataologType" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/AutomobileCataologType.html"></see>
    /// </summary>
    let ``AutomobileCataologType.html`` =
        Namespaced_IRI.parse _namespace_name "AutomobileCataologType.html" |> NamespacedName

    /// <summary>
    /// From en.wikipedia.org:
    /// "A car model is a particular brand of vehicle sold under a marque. From an engineering point of view, a particular car model is usually defined and/or constrained by the use of a particular car chassis/bodywork combination or the same monocoque."
    /// <see href="http://open.vocab.org/terms/AutomobileModel"></see></summary>
    let AutomobileModel =
        Namespaced_IRI.parse _namespace_name "AutomobileModel" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/AutomobileModel.html"></see>
    /// </summary>
    let ``AutomobileModel.html`` =
        Namespaced_IRI.parse _namespace_name "AutomobileModel.html" |> NamespacedName

    /// <summary>
    /// This class of character traits was created to describe the characters in the graphic novel Avatar-The Last Airbender.
    /// The motivation was to create a unique class identifying the characters in the trilogy.
    /// <see href="http://open.vocab.org/terms/AvatarCharacterTraits"></see></summary>
    let AvatarCharacterTraits =
        Namespaced_IRI.parse _namespace_name "AvatarCharacterTraits" |> NamespacedName

    /// <summary>
    /// Database for Biologists (Bioinformatics)
    /// <see href="http://open.vocab.org/terms/BiologicalDatabase"></see></summary>
    let BiologicalDatabase =
        Namespaced_IRI.parse _namespace_name "BiologicalDatabase" |> NamespacedName

    /// <summary>
    /// A Scientific Database
    /// <see href="http://open.vocab.org/terms/ScientificDatabase"></see></summary>
    let ScientificDatabase =
        Namespaced_IRI.parse _namespace_name "ScientificDatabase" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/BiologicalDatabase.html"></see>
    /// </summary>
    let ``BiologicalDatabase.html`` =
        Namespaced_IRI.parse _namespace_name "BiologicalDatabase.html" |> NamespacedName

    /// <summary>
    /// Birth class
    /// <see href="http://open.vocab.org/terms/Birth"></see></summary>
    let Birth = Namespaced_IRI.parse _namespace_name "Birth" |> NamespacedName
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Death"></see>
    /// </summary>
    let Death = Namespaced_IRI.parse _namespace_name "Death" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Birth.html"></see>
    /// </summary>
    let ``Birth.html`` =
        Namespaced_IRI.parse _namespace_name "Birth.html" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Calendar"></see>
    /// </summary>
    let Calendar = Namespaced_IRI.parse _namespace_name "Calendar" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Calendar.html"></see>
    /// </summary>
    let ``Calendar.html`` =
        Namespaced_IRI.parse _namespace_name "Calendar.html" |> NamespacedName

    /// <summary>
    /// Cheese is a food made from milk, usually the milk of cows, buffalo, goats, or sheep, by coagulation.
    /// <see href="http://open.vocab.org/terms/Cheese"></see></summary>
    let Cheese = Namespaced_IRI.parse _namespace_name "Cheese" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Cheese.html"></see>
    /// </summary>
    let ``Cheese.html`` =
        Namespaced_IRI.parse _namespace_name "Cheese.html" |> NamespacedName

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
    let ClassSkeleton =
        Namespaced_IRI.parse _namespace_name "ClassSkeleton" |> NamespacedName

    /// <summary>
    /// A country is a geographical region. A country may be the territory of a sovereign state, the territory of a non-sovereign (or formerly sovereign) political division, or a region associated with a certain people or certain characteristics.
    /// <see href="http://open.vocab.org/terms/Country"></see></summary>
    let Country = Namespaced_IRI.parse _namespace_name "Country" |> NamespacedName
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Course"></see>
    /// </summary>
    let Course = Namespaced_IRI.parse _namespace_name "Course" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Course.html"></see>
    /// </summary>
    let ``Course.html`` =
        Namespaced_IRI.parse _namespace_name "Course.html" |> NamespacedName

    /// <summary>
    /// A boundary-point's position in a Document or DocumentFragment tree can be characterized by a node and an offset.
    /// http://www.w3.org/TR/2000/REC-DOM-Level-2-Traversal-Range-20001113/ranges.html#Level-2-Range-Definitions
    /// <see href="http://open.vocab.org/terms/DOMBoundaryPoint"></see></summary>
    let DOMBoundaryPoint =
        Namespaced_IRI.parse _namespace_name "DOMBoundaryPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/DOMBoundaryPoint.html"></see>
    /// </summary>
    let ``DOMBoundaryPoint.html`` =
        Namespaced_IRI.parse _namespace_name "DOMBoundaryPoint.html" |> NamespacedName

    /// <summary>
    /// A boundary-point's position in a Document or DocumentFragment tree can be characterized by a node and an offset
    ///
    /// http://www.w3.org/TR/2000/REC-DOM-Level-2-Traversal-Range-20001113/ranges.html#Level-2-Range-Definitions
    /// <see href="http://open.vocab.org/terms/DOMBoundaryPointPosition"></see></summary>
    let DOMBoundaryPointPosition =
        Namespaced_IRI.parse _namespace_name "DOMBoundaryPointPosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/DOMBoundaryPointPosition.html"></see>
    /// </summary>
    let ``DOMBoundaryPointPosition.html`` =
        Namespaced_IRI.parse _namespace_name "DOMBoundaryPointPosition.html" |> NamespacedName

    /// <summary>
    /// DOMNode can be a Attribute, Document, DocumentFragment, Element or EntityReference node.
    /// <see href="http://open.vocab.org/terms/DOMNode"></see></summary>
    let DOMNode = Namespaced_IRI.parse _namespace_name "DOMNode" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/DOMNode.html"></see>
    /// </summary>
    let ``DOMNode.html`` =
        Namespaced_IRI.parse _namespace_name "DOMNode.html" |> NamespacedName

    /// <summary>
    /// the offset within a DOM node
    /// <see href="http://open.vocab.org/terms/DOMOffset"></see></summary>
    let DOMOffset = Namespaced_IRI.parse _namespace_name "DOMOffset" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/DOMOffset.html"></see>
    /// </summary>
    let ``DOMOffset.html`` =
        Namespaced_IRI.parse _namespace_name "DOMOffset.html" |> NamespacedName

    /// <summary>
    /// A DOM Range consists of two boundary-points corresponding to the start and the end of the Range.
    /// http://www.w3.org/TR/2000/REC-DOM-Level-2-Traversal-Range-20001113/ranges.html#Level-2-Range-Definitions
    /// <see href="http://open.vocab.org/terms/DOMRange"></see></summary>
    let DOMRange = Namespaced_IRI.parse _namespace_name "DOMRange" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/DOMRange.html"></see>
    /// </summary>
    let ``DOMRange.html`` =
        Namespaced_IRI.parse _namespace_name "DOMRange.html" |> NamespacedName

    /// <summary>
    /// A Database
    /// <see href="http://open.vocab.org/terms/Database"></see></summary>
    let Database = Namespaced_IRI.parse _namespace_name "Database" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Database.html"></see>
    /// </summary>
    let ``Database.html`` =
        Namespaced_IRI.parse _namespace_name "Database.html" |> NamespacedName

    /// <summary>
    /// A construct representing a deleted entry in an Atom feed.
    /// <see href="http://open.vocab.org/terms/DeletedEntry"></see></summary>
    let DeletedEntry =
        Namespaced_IRI.parse _namespace_name "DeletedEntry" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/DeletedEntry.html"></see>
    /// </summary>
    let ``DeletedEntry.html`` =
        Namespaced_IRI.parse _namespace_name "DeletedEntry.html" |> NamespacedName

    /// <summary>
    /// A diff, showing the difference between a source resource and a target resource.
    /// <see href="http://open.vocab.org/terms/Diff"></see></summary>
    let Diff = Namespaced_IRI.parse _namespace_name "Diff" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Diff.html"></see>
    /// </summary>
    let ``Diff.html`` =
        Namespaced_IRI.parse _namespace_name "Diff.html" |> NamespacedName

    /// <summary>
    /// DAs would be typically files. Audio, movies, software licenses, software installers, documents, etc. Anything stored that needs a computer to get it and/or read it.
    /// <see href="http://open.vocab.org/terms/DigitalAsset"></see></summary>
    let DigitalAsset =
        Namespaced_IRI.parse _namespace_name "DigitalAsset" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/DigitalAsset.html"></see>
    /// </summary>
    let ``DigitalAsset.html`` =
        Namespaced_IRI.parse _namespace_name "DigitalAsset.html" |> NamespacedName

    /// <summary>
    /// A Distance should have two distance points and a distance value. eg:
    ///
    /// &lt;distances/a/b&gt;
    ///     a ov:Distance ;
    ///     ov:distancePoint &lt;a&gt; , &lt;b&gt; ;
    ///     ov:kilometres 0.5 ;
    /// .
    /// <see href="http://open.vocab.org/terms/Distance"></see></summary>
    let Distance = Namespaced_IRI.parse _namespace_name "Distance" |> NamespacedName
    /// <summary>
    /// class is now deprecated in favour of Earworm class.
    /// <see href="http://open.vocab.org/terms/EarWorm"></see></summary>
    let EarWorm = Namespaced_IRI.parse _namespace_name "EarWorm" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/EarWorm.html"></see>
    /// </summary>
    let ``EarWorm.html`` =
        Namespaced_IRI.parse _namespace_name "EarWorm.html" |> NamespacedName

    /// <summary>
    /// The experience of having a song in your head which you can't get rid of.
    /// <see href="http://open.vocab.org/terms/Earworm"></see></summary>
    let Earworm = Namespaced_IRI.parse _namespace_name "Earworm" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Earworm.html"></see>
    /// </summary>
    let ``Earworm.html`` =
        Namespaced_IRI.parse _namespace_name "Earworm.html" |> NamespacedName

    /// <summary>
    /// The class of all motion pictures
    /// <see href="http://open.vocab.org/terms/Film"></see></summary>
    let Film = Namespaced_IRI.parse _namespace_name "Film" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Film.html"></see>
    /// </summary>
    let ``Film.html`` =
        Namespaced_IRI.parse _namespace_name "Film.html" |> NamespacedName

    /// <summary>
    /// A formula or graph literal, in the sense used by Notation 3.
    ///
    /// This is intended to be used as a datatype. e.g.
    ///
    ///   &lt;#bob&gt; ex:believes "&lt;#alice&gt; a &lt;http://xmlns.com/foaf/0.1/Person&gt; ."^^ov:Formula .
    ///
    /// Note that the wrapping "{"..."}" are omitted from the value.
    /// <see href="http://open.vocab.org/terms/Formula"></see></summary>
    let Formula = Namespaced_IRI.parse _namespace_name "Formula" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/HUDCourseLoan"></see>
    /// </summary>
    let HUDCourseLoan =
        Namespaced_IRI.parse _namespace_name "HUDCourseLoan" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/HUDCourseLoan.html"></see>
    /// </summary>
    let ``HUDCourseLoan.html`` =
        Namespaced_IRI.parse _namespace_name "HUDCourseLoan.html" |> NamespacedName

    /// <summary>
    /// The loan history of a book within a school
    /// <see href="http://open.vocab.org/terms/HUDSchoolLoan"></see></summary>
    let HUDSchoolLoan =
        Namespaced_IRI.parse _namespace_name "HUDSchoolLoan" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/HUDSchoolLoan.html"></see>
    /// </summary>
    let ``HUDSchoolLoan.html`` =
        Namespaced_IRI.parse _namespace_name "HUDSchoolLoan.html" |> NamespacedName

    /// <summary>
    /// Suggested book based on circulation data
    /// <see href="http://open.vocab.org/terms/HUDSuggestion"></see></summary>
    let HUDSuggestion =
        Namespaced_IRI.parse _namespace_name "HUDSuggestion" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/HUDSuggestion.html"></see>
    /// </summary>
    let ``HUDSuggestion.html`` =
        Namespaced_IRI.parse _namespace_name "HUDSuggestion.html" |> NamespacedName

    /// <summary>
    /// The loan history for a book by year.
    /// <see href="http://open.vocab.org/terms/HUDYearLoan"></see></summary>
    let HUDYearLoan =
        Namespaced_IRI.parse _namespace_name "HUDYearLoan" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/HUDYearLoan.html"></see>
    /// </summary>
    let ``HUDYearLoan.html`` =
        Namespaced_IRI.parse _namespace_name "HUDYearLoan.html" |> NamespacedName

    /// <summary>
    /// Structure in which someone lives
    /// <see href="http://open.vocab.org/terms/House"></see></summary>
    let House = Namespaced_IRI.parse _namespace_name "House" |> NamespacedName
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/building"></see>
    /// </summary>
    let building = Namespaced_IRI.parse _namespace_name "building" |> NamespacedName
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/horse"></see>
    /// </summary>
    let horse = Namespaced_IRI.parse _namespace_name "horse" |> NamespacedName
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/domicile"></see>
    /// </summary>
    let domicile = Namespaced_IRI.parse _namespace_name "domicile" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/House.html"></see>
    /// </summary>
    let ``House.html`` =
        Namespaced_IRI.parse _namespace_name "House.html" |> NamespacedName

    /// <summary>
    /// The ITU defines a set of world-wide regions which uniquely describe locations for radio operation (in particular, amateur radio operation).  These regions are widely-used by amateur radio operators to report operation and radio contacts.  Each region has a unique abbreviation.
    /// <see href="http://open.vocab.org/terms/ITUREgion"></see></summary>
    let ITUREgion = Namespaced_IRI.parse _namespace_name "ITUREgion" |> NamespacedName

    /// <summary>
    /// A statement that would be illegal to express in a non-reified form in RDF/XML - usually because the predicate cannot be converted to a QName.
    /// <see href="http://open.vocab.org/terms/IllegalRDFXMLStatement"></see></summary>
    let IllegalRDFXMLStatement =
        Namespaced_IRI.parse _namespace_name "IllegalRDFXMLStatement" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/IllegalRDFXMLStatement.html"></see>
    /// </summary>
    let ``IllegalRDFXMLStatement.html`` =
        Namespaced_IRI.parse _namespace_name "IllegalRDFXMLStatement.html" |> NamespacedName

    /// <summary>
    /// An irc chat bot
    /// <see href="http://open.vocab.org/terms/IrcBot"></see></summary>
    let IrcBot = Namespaced_IRI.parse _namespace_name "IrcBot" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/IrcBot.html"></see>
    /// </summary>
    let ``IrcBot.html`` =
        Namespaced_IRI.parse _namespace_name "IrcBot.html" |> NamespacedName

    /// <summary>
    /// the concept of "this" in a javascript object. In other words a mean in which to refer to "self"
    /// <see href="http://open.vocab.org/terms/JavascriptThis"></see></summary>
    let JavascriptThis =
        Namespaced_IRI.parse _namespace_name "JavascriptThis" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/JavascriptThis.html"></see>
    /// </summary>
    let ``JavascriptThis.html`` =
        Namespaced_IRI.parse _namespace_name "JavascriptThis.html" |> NamespacedName

    /// <summary>
    /// A gorilla that kills or has the inclination to do so.
    /// <see href="http://open.vocab.org/terms/KillerGorilla"></see></summary>
    let KillerGorilla =
        Namespaced_IRI.parse _namespace_name "KillerGorilla" |> NamespacedName

    /// <summary>
    /// Indicates that something is definitely not a Killer-Gorilla. (It may still be a killer though. Or a gorilla.)
    /// <see href="http://open.vocab.org/terms/NotAKillerGorilla"></see></summary>
    let NotAKillerGorilla =
        Namespaced_IRI.parse _namespace_name "NotAKillerGorilla" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/KillerGorilla.html"></see>
    /// </summary>
    let ``KillerGorilla.html`` =
        Namespaced_IRI.parse _namespace_name "KillerGorilla.html" |> NamespacedName

    /// <summary>
    /// The class of all MOT Testing Stations.
    /// <see href="http://open.vocab.org/terms/MOTTestingStation"></see></summary>
    let MOTTestingStation =
        Namespaced_IRI.parse _namespace_name "MOTTestingStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Madre"></see>
    /// </summary>
    let Madre = Namespaced_IRI.parse _namespace_name "Madre" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Madre.html"></see>
    /// </summary>
    let ``Madre.html`` =
        Namespaced_IRI.parse _namespace_name "Madre.html" |> NamespacedName

    /// <summary>
    /// A manifest is a listing of files or URIs or resources of some sort encoded in some way
    /// <see href="http://open.vocab.org/terms/Manifest"></see></summary>
    let Manifest = Namespaced_IRI.parse _namespace_name "Manifest" |> NamespacedName

    /// <summary>
    /// A post on a microblogging service like Twitter, identi.ca, Jaiku or FriendFeed. Usually untitled and with a limited number of characters, and sometimes containing in-line text-based syntactical elements like at-replies, hashtags, group 'bangtags' etc.
    /// <see href="http://open.vocab.org/terms/MicroblogPost"></see></summary>
    let MicroblogPost =
        Namespaced_IRI.parse _namespace_name "MicroblogPost" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/MicroblogPost.html"></see>
    /// </summary>
    let ``MicroblogPost.html`` =
        Namespaced_IRI.parse _namespace_name "MicroblogPost.html" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/MultiSportEvent"></see>
    /// </summary>
    let MultiSportEvent =
        Namespaced_IRI.parse _namespace_name "MultiSportEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/MultiSportEvent.html"></see>
    /// </summary>
    let ``MultiSportEvent.html`` =
        Namespaced_IRI.parse _namespace_name "MultiSportEvent.html" |> NamespacedName

    /// <summary>
    /// A piece of News
    /// <see href="http://open.vocab.org/terms/NewsItem"></see></summary>
    let NewsItem = Namespaced_IRI.parse _namespace_name "NewsItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/NotAKillerGorilla.html"></see>
    /// </summary>
    let ``NotAKillerGorilla.html`` =
        Namespaced_IRI.parse _namespace_name "NotAKillerGorilla.html" |> NamespacedName

    /// <summary>
    /// Numismatics is  the study of coins, medals and other related items.
    /// <see href="http://open.vocab.org/terms/Numismatics"></see></summary>
    let Numismatics =
        Namespaced_IRI.parse _namespace_name "Numismatics" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Numismatics.html"></see>
    /// </summary>
    let ``Numismatics.html`` =
        Namespaced_IRI.parse _namespace_name "Numismatics.html" |> NamespacedName

    /// <summary>
    /// Any entity that can be identified using the OKKAM entity naming system. In general one could say this is equivalent to resource but there are certain entity types that will work better on the OKKAM system
    /// <see href="http://open.vocab.org/terms/OkkamEntity"></see></summary>
    let OkkamEntity =
        Namespaced_IRI.parse _namespace_name "OkkamEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/OkkamEntity.html"></see>
    /// </summary>
    let ``OkkamEntity.html`` =
        Namespaced_IRI.parse _namespace_name "OkkamEntity.html" |> NamespacedName

    /// <summary>
    /// The Olympic Games are an international multi-sport event established for both summer and winter sports.
    /// <see href="http://open.vocab.org/terms/OlympicGames"></see></summary>
    let OlympicGames =
        Namespaced_IRI.parse _namespace_name "OlympicGames" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/OlympicGames.html"></see>
    /// </summary>
    let ``OlympicGames.html`` =
        Namespaced_IRI.parse _namespace_name "OlympicGames.html" |> NamespacedName

    /// <summary>
    /// A Plot of anything.
    /// <see href="http://open.vocab.org/terms/Plot"></see></summary>
    let Plot = Namespaced_IRI.parse _namespace_name "Plot" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Plot.html"></see>
    /// </summary>
    let ``Plot.html`` =
        Namespaced_IRI.parse _namespace_name "Plot.html" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/PrimaryVisualElement"></see>
    /// </summary>
    let PrimaryVisualElement =
        Namespaced_IRI.parse _namespace_name "PrimaryVisualElement" |> NamespacedName

    /// <summary>
    /// A thing that manifests visually.
    /// <see href="http://open.vocab.org/terms/VisualElement"></see></summary>
    let VisualElement =
        Namespaced_IRI.parse _namespace_name "VisualElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/PrimaryVisualElement.html"></see>
    /// </summary>
    let ``PrimaryVisualElement.html`` =
        Namespaced_IRI.parse _namespace_name "PrimaryVisualElement.html" |> NamespacedName

    /// <summary>
    /// RTFMImperative is an instruction for foaf:Agent(s) to read a given document.
    /// <see href="http://open.vocab.org/terms/RTFMImperative"></see></summary>
    let RTFMImperative =
        Namespaced_IRI.parse _namespace_name "RTFMImperative" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/RTFMImperative.html"></see>
    /// </summary>
    let ``RTFMImperative.html`` =
        Namespaced_IRI.parse _namespace_name "RTFMImperative.html" |> NamespacedName

    /// <summary>
    /// When a radio transmits a signal, a range of frequencies is used to carry information.  This range may be continuous or dis-contiguous ("spread spectrum").  There is usually a single frequency that is used to "name" the tranmission frequency, although this naming depends on the mode used.  (See RadioOperationMode).  The standard method of expression is "Herz" (or a multiple).  Sometimes, surprisingly, the "frequency" is expressed in terms of length (actually wavelength, often in meters).  This is merely an colloquial and equivalent expresssion, since freq(Herz) = the-speed-of-light / wavelength.
    /// <see href="http://open.vocab.org/terms/RadioOperationFrequency"></see></summary>
    let RadioOperationFrequency =
        Namespaced_IRI.parse _namespace_name "RadioOperationFrequency" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/ScientificDatabase.html"></see>
    /// </summary>
    let ``ScientificDatabase.html`` =
        Namespaced_IRI.parse _namespace_name "ScientificDatabase.html" |> NamespacedName

    /// <summary>
    /// e.g. : 100m in Beijing 2008
    /// <see href="http://open.vocab.org/terms/SportEvent"></see></summary>
    let SportEvent = Namespaced_IRI.parse _namespace_name "SportEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/SportEvent.html"></see>
    /// </summary>
    let ``SportEvent.html`` =
        Namespaced_IRI.parse _namespace_name "SportEvent.html" |> NamespacedName

    /// <summary>
    /// Indicates that the subject is a non-deceased killer gorilla.
    /// <see href="http://open.vocab.org/terms/StillAKillerGorilla"></see></summary>
    let StillAKillerGorilla =
        Namespaced_IRI.parse _namespace_name "StillAKillerGorilla" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/StillAKillerGorilla.html"></see>
    /// </summary>
    let ``StillAKillerGorilla.html`` =
        Namespaced_IRI.parse _namespace_name "StillAKillerGorilla.html" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/SummerOlympicGames"></see>
    /// </summary>
    let SummerOlympicGames =
        Namespaced_IRI.parse _namespace_name "SummerOlympicGames" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/WinterOlympicGames"></see>
    /// </summary>
    let WinterOlympicGames =
        Namespaced_IRI.parse _namespace_name "WinterOlympicGames" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/SummerOlympicGames.html"></see>
    /// </summary>
    let ``SummerOlympicGames.html`` =
        Namespaced_IRI.parse _namespace_name "SummerOlympicGames.html" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Test"></see>
    /// </summary>
    let Test = Namespaced_IRI.parse _namespace_name "Test" |> NamespacedName

    /// <summary>
    /// A Trim Package represents a standard configuration of options for an automobile.  Usually, a Car Model will be available as several Trim Packages.
    /// <see href="http://open.vocab.org/terms/TrimPackage"></see></summary>
    let TrimPackage =
        Namespaced_IRI.parse _namespace_name "TrimPackage" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/TrimPackage.html"></see>
    /// </summary>
    let ``TrimPackage.html`` =
        Namespaced_IRI.parse _namespace_name "TrimPackage.html" |> NamespacedName

    /// <summary>
    /// A course taught at a university
    /// <see href="http://open.vocab.org/terms/UnivCourse"></see></summary>
    let UnivCourse = Namespaced_IRI.parse _namespace_name "UnivCourse" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/UnivCourse.html"></see>
    /// </summary>
    let ``UnivCourse.html`` =
        Namespaced_IRI.parse _namespace_name "UnivCourse.html" |> NamespacedName

    /// <summary>
    /// A school of a university (e.g., School of Business).
    /// <see href="http://open.vocab.org/terms/UnivSchool"></see></summary>
    let UnivSchool = Namespaced_IRI.parse _namespace_name "UnivSchool" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/UnivSchool.html"></see>
    /// </summary>
    let ``UnivSchool.html`` =
        Namespaced_IRI.parse _namespace_name "UnivSchool.html" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/UuOjngyFVCE"></see>
    /// </summary>
    let UuOjngyFVCE =
        Namespaced_IRI.parse _namespace_name "UuOjngyFVCE" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/VisualElement.html"></see>
    /// </summary>
    let ``VisualElement.html`` =
        Namespaced_IRI.parse _namespace_name "VisualElement.html" |> NamespacedName

    /// <summary>
    /// A set of terms or names, each one having an assigned meaning.
    /// <see href="http://open.vocab.org/terms/Vocabulary"></see></summary>
    let Vocabulary = Namespaced_IRI.parse _namespace_name "Vocabulary" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Vocabulary.html"></see>
    /// </summary>
    let ``Vocabulary.html`` =
        Namespaced_IRI.parse _namespace_name "Vocabulary.html" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Ware.html"></see>
    /// </summary>
    let ``Ware.html`` =
        Namespaced_IRI.parse _namespace_name "Ware.html" |> NamespacedName

    /// <summary>
    /// A place that is accessible with a wheel chair.
    /// <see href="http://open.vocab.org/terms/WheelChairEnabled"></see></summary>
    let WheelChairEnabled =
        Namespaced_IRI.parse _namespace_name "WheelChairEnabled" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/WinterOlympicGames.html"></see>
    /// </summary>
    let ``WinterOlympicGames.html`` =
        Namespaced_IRI.parse _namespace_name "WinterOlympicGames.html" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Yoli"></see>
    /// </summary>
    let Yoli = Namespaced_IRI.parse _namespace_name "Yoli" |> NamespacedName

    /// <summary>
    /// A command issued to the code4lib IRC chat bot, zoia.
    /// <see href="http://open.vocab.org/terms/ZoiaCommand"></see></summary>
    let ZoiaCommand =
        Namespaced_IRI.parse _namespace_name "ZoiaCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/ZoiaCommand.html"></see>
    /// </summary>
    let ``ZoiaCommand.html`` =
        Namespaced_IRI.parse _namespace_name "ZoiaCommand.html" |> NamespacedName

    /// <summary>
    /// foaf:OnlineAccount's can have an accountName, but plenty of services use an account identifier internally that is not the same as the public account name: for instance, Twitter uses a nickname and a user_id property. Facebook now assigns usernames as well as internal identification numbers. Google's various services assign a unique identifier so that people are not revealing their e-mail address or username. This property is for these kind of identifiers.
    /// <see href="http://open.vocab.org/terms/accountIdentifier"></see></summary>
    let accountIdentifier =
        Namespaced_IRI.parse _namespace_name "accountIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/admWIUQRlVUqNMadZQ"></see>
    /// </summary>
    let admWIUQRlVUqNMadZQ =
        Namespaced_IRI.parse _namespace_name "admWIUQRlVUqNMadZQ" |> NamespacedName

    /// <summary>
    /// The Authorised Examiner Number of an MOT Testing Station.
    /// <see href="http://open.vocab.org/terms/aeNumber"></see></summary>
    let aeNumber = Namespaced_IRI.parse _namespace_name "aeNumber" |> NamespacedName

    /// <summary>
    /// Used to describe the affiliation, place of work or association of a foaf:Person when the source data is too ambiguous to model into its own resource.
    /// <see href="http://open.vocab.org/terms/affiliation"></see></summary>
    let affiliation =
        Namespaced_IRI.parse _namespace_name "affiliation" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/affiliation.html"></see>
    /// </summary>
    let ``affiliation.html`` =
        Namespaced_IRI.parse _namespace_name "affiliation.html" |> NamespacedName

    /// <summary>
    /// An agent syndicates a document some way.
    /// <see href="http://open.vocab.org/terms/aggregates"></see></summary>
    let aggregates = Namespaced_IRI.parse _namespace_name "aggregates" |> NamespacedName

    /// <summary>
    /// The anniversary of some event
    /// <see href="http://open.vocab.org/terms/anniversary"></see></summary>
    let anniversary =
        Namespaced_IRI.parse _namespace_name "anniversary" |> NamespacedName

    /// <summary>
    /// The area of some physical thing in hectares.
    /// <see href="http://open.vocab.org/terms/areaHectares"></see></summary>
    let areaHectares =
        Namespaced_IRI.parse _namespace_name "areaHectares" |> NamespacedName

    /// <summary>
    /// This property is used to relate two FRBR Endeavours/entities (http://vocab.org/frbr/core.html#Endeavour) together even if the entire Work-Expression-Manifestation-Item hierarchy does not exist.  For example, it could be used to relate a frbr:Work to a frbr:Manifestation without the need of a frbr:Expression to link them through.  The property is symmetric (if a &lt;_:work&gt; ov:associatedEntity &lt;_:item&gt; then &lt;_:item&gt; ov:associatedEntity &lt;_:work&gt;.  It is not transitive (items may be associated with the same work but not be in the same WEMI chain, for example).
    /// <see href="http://open.vocab.org/terms/associatedEntity"></see></summary>
    let associatedEntity =
        Namespaced_IRI.parse _namespace_name "associatedEntity" |> NamespacedName

    /// <summary>
    /// A thing that provides evidence for the existence or historicity of another thing attests to that other thing.
    /// <see href="http://open.vocab.org/terms/attestsTo"></see></summary>
    let attestsTo = Namespaced_IRI.parse _namespace_name "attestsTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/attestsTo.html"></see>
    /// </summary>
    let ``attestsTo.html`` =
        Namespaced_IRI.parse _namespace_name "attestsTo.html" |> NamespacedName

    /// <summary>
    /// The literal, human readable author string of a Document.
    /// <see href="http://open.vocab.org/terms/authorString"></see></summary>
    let authorString =
        Namespaced_IRI.parse _namespace_name "authorString" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/authorString.html"></see>
    /// </summary>
    let ``authorString.html`` =
        Namespaced_IRI.parse _namespace_name "authorString.html" |> NamespacedName

    /// <summary>
    /// One or more of the four elements viz. Air, Water, Fire and Earth that can be bent.
    /// <see href="http://open.vocab.org/terms/avatarBendingElement"></see></summary>
    let avatarBendingElement =
        Namespaced_IRI.parse _namespace_name "avatarBendingElement" |> NamespacedName

    /// <summary>
    /// Describes the eye color of an individual
    /// <see href="http://open.vocab.org/terms/avatarEyeColor"></see></summary>
    let avatarEyeColor =
        Namespaced_IRI.parse _namespace_name "avatarEyeColor" |> NamespacedName

    /// <summary>
    /// Describes when the character was introduced in the series.
    /// <see href="http://open.vocab.org/terms/avatarFirstAppearance"></see></summary>
    let avatarFirstAppearance =
        Namespaced_IRI.parse _namespace_name "avatarFirstAppearance" |> NamespacedName

    /// <summary>
    /// Defines the hair color (or no hair at all!) of an individual
    /// <see href="http://open.vocab.org/terms/avatarHairColor"></see></summary>
    let avatarHairColor =
        Namespaced_IRI.parse _namespace_name "avatarHairColor" |> NamespacedName

    /// <summary>
    /// The nationality of a character in Avatar. It can be one of Air, Fire, Water and Earth.
    /// <see href="http://open.vocab.org/terms/avatarNationality"></see></summary>
    let avatarNationality =
        Namespaced_IRI.parse _namespace_name "avatarNationality" |> NamespacedName

    /// <summary>
    /// Determines if the character is protagonist, antagonist, supporting character etc.
    /// <see href="http://open.vocab.org/terms/avatarPosition"></see></summary>
    let avatarPosition =
        Namespaced_IRI.parse _namespace_name "avatarPosition" |> NamespacedName

    /// <summary>
    /// The BBC provides IDs for places. This can be used to link BBC weather IDs to places.
    /// <see href="http://open.vocab.org/terms/bbcWeatherId"></see></summary>
    let bbcWeatherId =
        Namespaced_IRI.parse _namespace_name "bbcWeatherId" |> NamespacedName

    /// <summary>
    /// Following an EAD description, collections consist of one or more "components". Components act much like files and folders - a component may contain others (folder) or it may be a leaf node (file) - EAD is vague enough not to make this distinction, but provides a "level" attribute instead. This property is used by a component to show that if is a "componentOf" either another component or a collection or both.
    /// <see href="http://open.vocab.org/terms/beam-componentOf"></see></summary>
    let ``beam-componentOf`` =
        Namespaced_IRI.parse _namespace_name "beam-componentOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/beam-componentOf.html"></see>
    /// </summary>
    let ``beam-componentOf.html`` =
        Namespaced_IRI.parse _namespace_name "beam-componentOf.html" |> NamespacedName

    /// <summary>
    /// A sub-classing of bibo:identifier to narrow the range to be the numeric part of a BL identifier. For example:
    ///
    /// '(Uk)33994949'  ---&gt;  '&lt;foo&gt; &lt;ov:blid&gt; "33994949"'
    /// <see href="http://open.vocab.org/terms/blid"></see></summary>
    let blid = Namespaced_IRI.parse _namespace_name "blid" |> NamespacedName
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/bsRGyjqyy"></see>
    /// </summary>
    let bsRGyjqyy = Namespaced_IRI.parse _namespace_name "bsRGyjqyy" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/bthPpNLjjQHuCC"></see>
    /// </summary>
    let bthPpNLjjQHuCC =
        Namespaced_IRI.parse _namespace_name "bthPpNLjjQHuCC" |> NamespacedName

    /// <summary>
    /// A business card associated with this resource.
    /// <see href="http://open.vocab.org/terms/businessCard"></see></summary>
    let businessCard =
        Namespaced_IRI.parse _namespace_name "businessCard" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/businessInterest"></see>
    /// </summary>
    let businessInterest =
        Namespaced_IRI.parse _namespace_name "businessInterest" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/businessInterest.html"></see>
    /// </summary>
    let ``businessInterest.html`` =
        Namespaced_IRI.parse _namespace_name "businessInterest.html" |> NamespacedName

    /// <summary>
    /// A calendar associated with this resource.
    /// <see href="http://open.vocab.org/terms/calendar"></see></summary>
    let calendar = Namespaced_IRI.parse _namespace_name "calendar" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/canonicalInformationResource"></see>
    /// </summary>
    let canonicalInformationResource =
        Namespaced_IRI.parse _namespace_name "canonicalInformationResource" |> NamespacedName

    /// <summary>
    /// Denotes the canonical URI that should be used to refer to this resource.
    /// <see href="http://open.vocab.org/terms/canonicalUri"></see></summary>
    let canonicalUri =
        Namespaced_IRI.parse _namespace_name "canonicalUri" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/canonicalUri.html"></see>
    /// </summary>
    let ``canonicalUri.html`` =
        Namespaced_IRI.parse _namespace_name "canonicalUri.html" |> NamespacedName

    /// <summary>
    /// A category that the resource has been classified under
    /// <see href="http://open.vocab.org/terms/category"></see></summary>
    let category = Namespaced_IRI.parse _namespace_name "category" |> NamespacedName

    /// <summary>
    /// The value of this property is something that has been classified under the resource
    /// <see href="http://open.vocab.org/terms/isCategoryOf"></see></summary>
    let isCategoryOf =
        Namespaced_IRI.parse _namespace_name "isCategoryOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/category.html"></see>
    /// </summary>
    let ``category.html`` =
        Namespaced_IRI.parse _namespace_name "category.html" |> NamespacedName

    /// <summary>
    /// Relates class to a class skeleton. If class has more than one of this relations, it should use them all.
    /// <see href="http://open.vocab.org/terms/classSkeleton"></see></summary>
    let classSkeleton =
        Namespaced_IRI.parse _namespace_name "classSkeleton" |> NamespacedName

    /// <summary>
    /// Triples using his property and its sub-properties as predicate are to be ignored by the class skeleton materialization process (http://open.vocab.org/terms/ClassSkeleton).
    ///
    /// This property is not to be used in real data, it serves just to exist and have sub-properties.
    /// <see href="http://open.vocab.org/terms/classSkeletonIgnore"></see></summary>
    let classSkeletonIgnore =
        Namespaced_IRI.parse _namespace_name "classSkeletonIgnore" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/colour"></see>
    /// </summary>
    let colour = Namespaced_IRI.parse _namespace_name "colour" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/colour.html"></see>
    /// </summary>
    let ``colour.html`` =
        Namespaced_IRI.parse _namespace_name "colour.html" |> NamespacedName

    /// <summary>
    /// commonEndeavour is intended to define a FRBR (Functional Requirements for Bibliographic Records) relationship between two resources that may or may not be modeled as FRBR.  This makes it possible to assert that a resource modeled using a vocabulary that does not use the FRBR entity model explicitly is describing the same Work, Expression, Manifestation, and/or Item as another resource (which may or may not use the FRBR model, as well).
    ///
    /// commonEndeavour is intended to be used merely as a superproperty for WEMI-specific subproperties to inherit from, but there are no restrictions on its use.
    /// <see href="http://open.vocab.org/terms/commonEndeavour"></see></summary>
    let commonEndeavour =
        Namespaced_IRI.parse _namespace_name "commonEndeavour" |> NamespacedName

    /// <summary>
    /// This property is used to declare that two resources which may or may not conform to the FRBR (Functional Requirements for Bibliographic Resources) entity model share the same Expression. An example of its use would be to relate a resource described with a vocabulary such as bibo (which does not acknowledge the FRBR model) to other resources that describe endeavours which have the same implied Expression (which could be other bibo resources or FRBR entities or anything else).
    ///
    /// The property is symmetrical, so if &lt;_:someBiboBook&gt; &lt;ov:commonExpression&gt; &lt;_:otherEdition&gt;, this also means &lt;_:otherEdition&gt; &lt;ov:commonExpression&gt; &lt;_:someBiboBook&gt;.
    ///
    /// It is not transitive.
    ///
    /// Having this property also implies ov:commonWork.
    /// <see href="http://open.vocab.org/terms/commonExpression"></see></summary>
    let commonExpression =
        Namespaced_IRI.parse _namespace_name "commonExpression" |> NamespacedName

    /// <summary>
    /// This property is used to declare that two resources which may or may not conform to the FRBR (Functional Requirements for Bibliographic Resources) entity model share the same Item. An example of its use would be to relate a resource described with a vocabulary such as bibo (which does not acknowledge the FRBR model) to other resources that describe endeavours which contains the same specific Item (which could be other bibo resources or FRBR entities or anything else). This implies identical WEMI hierarchies.
    ///
    /// The property is symmetrical, so if &lt;_:specificPhysicalItem&gt; &lt;ov:commonItem&gt; &lt;_:someArchive&gt;, this also means &lt;_:someArchive&gt; &lt;ov:commonItem&gt; &lt;_:specificPhysicalItem&gt;.
    ///
    /// It is not transitive.
    ///
    /// Having this property also entails ov:commonManifestation, ov:commonExpression and ov:commonWork.
    /// <see href="http://open.vocab.org/terms/commonItem"></see></summary>
    let commonItem = Namespaced_IRI.parse _namespace_name "commonItem" |> NamespacedName

    /// <summary>
    /// This property is used to declare that two resources which may or may not conform to the FRBR (Functional Requirements for Bibliographic Resources) entity model share the same Manifestation.  An example of its use would be to relate a resource described with a vocabulary such as bibo (which does not acknowledge the FRBR model) to other resources that describe endeavours which include the same implied Manifestation (which could be other bibo resources or FRBR entities or anything else).
    ///
    /// The property is symmetrical, so if &lt;_:someBiboBook&gt; &lt;ov:commonManifestation&gt; &lt;_:someFrbrWork&gt;, this also means &lt;_:someFrbrWork&gt; &lt;ov:commonManifestation&gt; &lt;_:someBiboBook&gt;.  It is not transitive.
    ///
    /// Having this property also implies ov:commonExpression and ov:commonWork.
    /// <see href="http://open.vocab.org/terms/commonManifestation"></see></summary>
    let commonManifestation =
        Namespaced_IRI.parse _namespace_name "commonManifestation" |> NamespacedName

    /// <summary>
    /// This property is used to declare that two resources which may or may not conform to the FRBR (Functional Requirements for Bibliographic Resources) entity model share the same Work. An example of its use would be to relate a resource described with a vocabulary such as bibo (which does not acknowledge the FRBR model) to other resources that describe endeavours that fall within the same implied Work (which could be other bibo resources or FRBR entities or anything else).
    ///
    /// The property is symmetrical, so if &lt;_:someBiboBook&gt; &lt;ov:commonWork&gt; &lt;_:someOtherBiboBook&gt;, this also means &lt;_:someOtherBiboBook&gt; &lt;ov:commonWork&gt; &lt;_:someBiboBook&gt;.
    ///
    /// It is not transitive.
    /// <see href="http://open.vocab.org/terms/commonWork"></see></summary>
    let commonWork = Namespaced_IRI.parse _namespace_name "commonWork" |> NamespacedName

    /// <summary>
    /// The Compass Direction that a Thing faces.
    /// <see href="http://open.vocab.org/terms/compassDirection"></see></summary>
    let compassDirection =
        Namespaced_IRI.parse _namespace_name "compassDirection" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/compassDirection.html"></see>
    /// </summary>
    let ``compassDirection.html`` =
        Namespaced_IRI.parse _namespace_name "compassDirection.html" |> NamespacedName

    /// <summary>
    /// :s :composedBy :o .
    /// :o is a "larger thing" that composes :s and potentially other "smaller things". :s may also establish some structural organization of the things it composes.
    /// <see href="http://open.vocab.org/terms/composedBy"></see></summary>
    let composedBy = Namespaced_IRI.parse _namespace_name "composedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/composedBy.html"></see>
    /// </summary>
    let ``composedBy.html`` =
        Namespaced_IRI.parse _namespace_name "composedBy.html" |> NamespacedName

    /// <summary>
    /// associates a manifestation of a musical work with music artist who composed the work
    /// <see href="http://open.vocab.org/terms/composer"></see></summary>
    let composer = Namespaced_IRI.parse _namespace_name "composer" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/composer.html"></see>
    /// </summary>
    let ``composer.html`` =
        Namespaced_IRI.parse _namespace_name "composer.html" |> NamespacedName

    /// <summary>
    /// Describes the size of the file of a dataset in compressed state
    /// <see href="http://open.vocab.org/terms/compressedFileSize"></see></summary>
    let compressedFileSize =
        Namespaced_IRI.parse _namespace_name "compressedFileSize" |> NamespacedName

    /// <summary>
    /// A confidence level for a calculation or value.  Usually between 0 and 1.
    /// <see href="http://open.vocab.org/terms/confidence"></see></summary>
    let confidence = Namespaced_IRI.parse _namespace_name "confidence" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/confidence.html"></see>
    /// </summary>
    let ``confidence.html`` =
        Namespaced_IRI.parse _namespace_name "confidence.html" |> NamespacedName

    /// <summary>
    /// A country associated with this resource. This could be a country of origin or operation of an entity. For example a company may be based in a country and operate from there.
    /// <see href="http://open.vocab.org/terms/country"></see></summary>
    let country = Namespaced_IRI.parse _namespace_name "country" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/creation-tool-used"></see>
    /// </summary>
    let ``creation-tool-used`` =
        Namespaced_IRI.parse _namespace_name "creation-tool-used" |> NamespacedName

    /// <summary>
    /// The user-agent string of the software used by the creator of an item.
    /// <see href="http://open.vocab.org/terms/creatorUserAgent"></see></summary>
    let creatorUserAgent =
        Namespaced_IRI.parse _namespace_name "creatorUserAgent" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/creatorUserAgent.html"></see>
    /// </summary>
    let ``creatorUserAgent.html`` =
        Namespaced_IRI.parse _namespace_name "creatorUserAgent.html" |> NamespacedName

    /// <summary>
    /// The column of a comma separated value file from which this property was created.
    /// <see href="http://open.vocab.org/terms/csvCol"></see></summary>
    let csvCol = Namespaced_IRI.parse _namespace_name "csvCol" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/csvCol.html"></see>
    /// </summary>
    let ``csvCol.html`` =
        Namespaced_IRI.parse _namespace_name "csvCol.html" |> NamespacedName

    /// <summary>
    /// The row number of a csv from which this instance was created. This is different from the r-th entry within the table, which may be less than the csv row if the csv has title information and a header above the data.
    /// <see href="http://open.vocab.org/terms/csvRow"></see></summary>
    let csvRow = Namespaced_IRI.parse _namespace_name "csvRow" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/csvRow.html"></see>
    /// </summary>
    let ``csvRow.html`` =
        Namespaced_IRI.parse _namespace_name "csvRow.html" |> NamespacedName

    /// <summary>
    /// The date someone died.
    /// <see href="http://open.vocab.org/terms/dateOfDeath"></see></summary>
    let dateOfDeath =
        Namespaced_IRI.parse _namespace_name "dateOfDeath" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/dateOfDeath.html"></see>
    /// </summary>
    let ``dateOfDeath.html`` =
        Namespaced_IRI.parse _namespace_name "dateOfDeath.html" |> NamespacedName

    /// <summary>
    /// Associates properties to a class where the properties are meant to be present in some default view - basically a very light version of fresnel ;-)
    /// <see href="http://open.vocab.org/terms/defaultProperty"></see></summary>
    let defaultProperty =
        Namespaced_IRI.parse _namespace_name "defaultProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/defaultProperty.html"></see>
    /// </summary>
    let ``defaultProperty.html`` =
        Namespaced_IRI.parse _namespace_name "defaultProperty.html" |> NamespacedName

    /// <summary>
    /// The things defined by this resource - for example, the terms defined by an Ontology.
    /// <see href="http://open.vocab.org/terms/defines"></see></summary>
    let defines = Namespaced_IRI.parse _namespace_name "defines" |> NamespacedName

    /// <summary>
    /// Teacher of the course. Should belong to the organization specified by ov:offeredBy of the course
    /// <see href="http://open.vocab.org/terms/deliveredBy"></see></summary>
    let deliveredBy =
        Namespaced_IRI.parse _namespace_name "deliveredBy" |> NamespacedName

    /// <summary>
    /// Date and time your travel will commence
    /// <see href="http://open.vocab.org/terms/departureDate"></see></summary>
    let departureDate =
        Namespaced_IRI.parse _namespace_name "departureDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/departureDate.html"></see>
    /// </summary>
    let ``departureDate.html`` =
        Namespaced_IRI.parse _namespace_name "departureDate.html" |> NamespacedName

    /// <summary>
    /// When :s :depicts :o, :s is communicable via a visual medium and, when transmitted, depicts the resource :o.
    /// <see href="http://open.vocab.org/terms/depicts"></see></summary>
    let depicts = Namespaced_IRI.parse _namespace_name "depicts" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/depicts.html"></see>
    /// </summary>
    let ``depicts.html`` =
        Namespaced_IRI.parse _namespace_name "depicts.html" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/depictsSameResourceAs"></see>
    /// </summary>
    let depictsSameResourceAs =
        Namespaced_IRI.parse _namespace_name "depictsSameResourceAs" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/depictsSameResourceAs.html"></see>
    /// </summary>
    let ``depictsSameResourceAs.html`` =
        Namespaced_IRI.parse _namespace_name "depictsSameResourceAs.html" |> NamespacedName

    /// <summary>
    /// The subject is a document that, to any extent, describes the object.
    /// <see href="http://open.vocab.org/terms/describes"></see></summary>
    let describes = Namespaced_IRI.parse _namespace_name "describes" |> NamespacedName

    /// <summary>
    /// A diff that goes from another resource to this one.
    /// <see href="http://open.vocab.org/terms/diffFromOther"></see></summary>
    let diffFromOther =
        Namespaced_IRI.parse _namespace_name "diffFromOther" |> NamespacedName

    /// <summary>
    /// The resource that this diff goes to.
    /// <see href="http://open.vocab.org/terms/diffTarget"></see></summary>
    let diffTarget = Namespaced_IRI.parse _namespace_name "diffTarget" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/diffFromOther.html"></see>
    /// </summary>
    let ``diffFromOther.html`` =
        Namespaced_IRI.parse _namespace_name "diffFromOther.html" |> NamespacedName

    /// <summary>
    /// The resource that this diff goes from.
    /// <see href="http://open.vocab.org/terms/diffSource"></see></summary>
    let diffSource = Namespaced_IRI.parse _namespace_name "diffSource" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/diffSource.html"></see>
    /// </summary>
    let ``diffSource.html`` =
        Namespaced_IRI.parse _namespace_name "diffSource.html" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/diffTarget.html"></see>
    /// </summary>
    let ``diffTarget.html`` =
        Namespaced_IRI.parse _namespace_name "diffTarget.html" |> NamespacedName

    /// <summary>
    /// A diff that goes from this resource to another one.
    /// <see href="http://open.vocab.org/terms/diffToOther"></see></summary>
    let diffToOther =
        Namespaced_IRI.parse _namespace_name "diffToOther" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/diffToOther.html"></see>
    /// </summary>
    let ``diffToOther.html`` =
        Namespaced_IRI.parse _namespace_name "diffToOther.html" |> NamespacedName

    /// <summary>
    /// Relates a property to a Dimension Property with identical meaning for use with the RDF DataCube vocabulary.
    /// <see href="http://open.vocab.org/terms/dimensionProperty"></see></summary>
    let dimensionProperty =
        Namespaced_IRI.parse _namespace_name "dimensionProperty" |> NamespacedName

    /// <summary>
    /// The disclaimer property links a resource to a document that details a disclaimer applied to the resource by the resource owner or other relevant party.
    /// <see href="http://open.vocab.org/terms/disclaimer"></see></summary>
    let disclaimer = Namespaced_IRI.parse _namespace_name "disclaimer" |> NamespacedName

    /// <summary>
    /// The disclaimerText property associates a resource with the text of a disclaimer (in the form of an rdfs:Literal) applied to the resource by the resource owner or other relevant party.
    /// <see href="http://open.vocab.org/terms/disclaimerText"></see></summary>
    let disclaimerText =
        Namespaced_IRI.parse _namespace_name "disclaimerText" |> NamespacedName

    /// <summary>
    /// A location from which a distance is measured. (A distance measurement will have two points, and a distance measurement value).
    /// <see href="http://open.vocab.org/terms/distancePoint"></see></summary>
    let distancePoint =
        Namespaced_IRI.parse _namespace_name "distancePoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/doesnt-live-here-anymore"></see>
    /// </summary>
    let ``doesnt-live-here-anymore`` =
        Namespaced_IRI.parse _namespace_name "doesnt-live-here-anymore" |> NamespacedName

    /// <summary>
    /// The song that is the focus of a particular earworm
    /// <see href="http://open.vocab.org/terms/earwormSong"></see></summary>
    let earwormSong =
        Namespaced_IRI.parse _namespace_name "earwormSong" |> NamespacedName

    /// <summary>
    /// A song which is the focus of a particular Earworm
    /// <see href="http://open.vocab.org/terms/isSongOfEarworm"></see></summary>
    let isSongOfEarworm =
        Namespaced_IRI.parse _namespace_name "isSongOfEarworm" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/earwormSong.html"></see>
    /// </summary>
    let ``earwormSong.html`` =
        Namespaced_IRI.parse _namespace_name "earwormSong.html" |> NamespacedName

    /// <summary>
    /// The person who experiences or suffers from a particular ear worm
    /// <see href="http://open.vocab.org/terms/earwormSufferer"></see></summary>
    let earwormSufferer =
        Namespaced_IRI.parse _namespace_name "earwormSufferer" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/earwormSufferer.html"></see>
    /// </summary>
    let ``earwormSufferer.html`` =
        Namespaced_IRI.parse _namespace_name "earwormSufferer.html" |> NamespacedName

    /// <summary>
    /// The transmitter of a particular Earworm
    /// <see href="http://open.vocab.org/terms/earwormTransmitter"></see></summary>
    let earwormTransmitter =
        Namespaced_IRI.parse _namespace_name "earwormTransmitter" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/earwormTransmitter.html"></see>
    /// </summary>
    let ``earwormTransmitter.html`` =
        Namespaced_IRI.parse _namespace_name "earwormTransmitter.html" |> NamespacedName

    /// <summary>
    /// Associates a resource with a form that can be used to edit its description. See http://patterns.dataincubator.org/book/edit-trail.html for more information.
    /// <see href="http://open.vocab.org/terms/editForm"></see></summary>
    let editForm = Namespaced_IRI.parse _namespace_name "editForm" |> NamespacedName
    /// <summary>
    /// The time of day that something ends.
    /// <see href="http://open.vocab.org/terms/endTime"></see></summary>
    let endTime = Namespaced_IRI.parse _namespace_name "endTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/endTime.html"></see>
    /// </summary>
    let ``endTime.html`` =
        Namespaced_IRI.parse _namespace_name "endTime.html" |> NamespacedName

    /// <summary>
    /// This property is to be used to relate a resource to an "enhanced description". An enhanced description is one that provides additional, richer detail about a resource than may typically be obtained by a simple de-reference of the resource's URI.
    /// <see href="http://open.vocab.org/terms/enhancedDescription"></see></summary>
    let enhancedDescription =
        Namespaced_IRI.parse _namespace_name "enhancedDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/enhancedDescription.html"></see>
    /// </summary>
    let ``enhancedDescription.html`` =
        Namespaced_IRI.parse _namespace_name "enhancedDescription.html" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/exampleInstance"></see>
    /// </summary>
    let exampleInstance =
        Namespaced_IRI.parse _namespace_name "exampleInstance" |> NamespacedName

    /// <summary>
    /// an example resource using a vocabulary term or terms
    /// <see href="http://open.vocab.org/terms/exampleResource"></see></summary>
    let exampleResource =
        Namespaced_IRI.parse _namespace_name "exampleResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/exampleResource.html"></see>
    /// </summary>
    let ``exampleResource.html`` =
        Namespaced_IRI.parse _namespace_name "exampleResource.html" |> NamespacedName

    /// <summary>
    /// Eye Color
    /// <see href="http://open.vocab.org/terms/eyeColor"></see></summary>
    let eyeColor = Namespaced_IRI.parse _namespace_name "eyeColor" |> NamespacedName

    /// <summary>
    /// The name used in familiar situations by friends, e.g. Ian
    ///
    /// <see href="http://open.vocab.org/terms/familiarName"></see></summary>
    let familiarName =
        Namespaced_IRI.parse _namespace_name "familiarName" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/familiarName.html"></see>
    /// </summary>
    let ``familiarName.html`` =
        Namespaced_IRI.parse _namespace_name "familiarName.html" |> NamespacedName

    /// <summary>
    /// A drink, alcoholic or not, that the person in question is particularly fond of. It's what they would typically order in a place where the drink is available. The object can be a literal stating the name of the drink, or (preferred) an RDF resource.
    /// <see href="http://open.vocab.org/terms/favouriteDrink"></see></summary>
    let favouriteDrink =
        Namespaced_IRI.parse _namespace_name "favouriteDrink" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/favouriteDrink.html"></see>
    /// </summary>
    let ``favouriteDrink.html`` =
        Namespaced_IRI.parse _namespace_name "favouriteDrink.html" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/favouritedBy"></see>
    /// </summary>
    let favouritedBy =
        Namespaced_IRI.parse _namespace_name "favouritedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/favouritedBy.html"></see>
    /// </summary>
    let ``favouritedBy.html`` =
        Namespaced_IRI.parse _namespace_name "favouritedBy.html" |> NamespacedName

    /// <summary>
    /// A fax number that can be used to send faxes to a Person or Organisation.
    /// <see href="http://open.vocab.org/terms/faxNumber"></see></summary>
    let faxNumber = Namespaced_IRI.parse _namespace_name "faxNumber" |> NamespacedName

    /// <summary>
    /// associates a musical item with a feature file describing that item
    /// <see href="http://open.vocab.org/terms/featurefile"></see></summary>
    let featurefile =
        Namespaced_IRI.parse _namespace_name "featurefile" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/featurefile.html"></see>
    /// </summary>
    let ``featurefile.html`` =
        Namespaced_IRI.parse _namespace_name "featurefile.html" |> NamespacedName

    /// <summary>
    /// Describes the size of the file of a dataset in the normal (uncompressed) state
    /// <see href="http://open.vocab.org/terms/fileSize"></see></summary>
    let fileSize = Namespaced_IRI.parse _namespace_name "fileSize" |> NamespacedName
    /// <summary>
    /// The place at which a thing is found.
    /// <see href="http://open.vocab.org/terms/findspot"></see></summary>
    let findspot = Namespaced_IRI.parse _namespace_name "findspot" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/findspot.html"></see>
    /// </summary>
    let ``findspot.html`` =
        Namespaced_IRI.parse _namespace_name "findspot.html" |> NamespacedName

    /// <summary>
    /// The first sentence of a resource.
    /// <see href="http://open.vocab.org/terms/firstSentence"></see></summary>
    let firstSentence =
        Namespaced_IRI.parse _namespace_name "firstSentence" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/firstSentence.html"></see>
    /// </summary>
    let ``firstSentence.html`` =
        Namespaced_IRI.parse _namespace_name "firstSentence.html" |> NamespacedName

    /// <summary>
    /// Use this property to state that you admire a friend's fro
    /// <see href="http://open.vocab.org/terms/foafro"></see></summary>
    let foafro = Namespaced_IRI.parse _namespace_name "foafro" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/foafro.html"></see>
    /// </summary>
    let ``foafro.html`` =
        Namespaced_IRI.parse _namespace_name "foafro.html" |> NamespacedName

    /// <summary>
    /// The name used when referred to in formal situations, e.g. Mr. Davis
    ///
    /// <see href="http://open.vocab.org/terms/formalName"></see></summary>
    let formalName = Namespaced_IRI.parse _namespace_name "formalName" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/formalName.html"></see>
    /// </summary>
    let ``formalName.html`` =
        Namespaced_IRI.parse _namespace_name "formalName.html" |> NamespacedName

    /// <summary>
    /// The full name as expected to be used on an identifying document e.g. Mr Ian Robert Davis
    ///
    /// <see href="http://open.vocab.org/terms/fullName"></see></summary>
    let fullName = Namespaced_IRI.parse _namespace_name "fullName" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/fullName.html"></see>
    /// </summary>
    let ``fullName.html`` =
        Namespaced_IRI.parse _namespace_name "fullName.html" |> NamespacedName

    /// <summary>
    /// The agent that defines the boundaries of a geographic area.
    /// <see href="http://open.vocab.org/terms/geoBoundaryDefiner"></see></summary>
    let geoBoundaryDefiner =
        Namespaced_IRI.parse _namespace_name "geoBoundaryDefiner" |> NamespacedName

    /// <summary>
    /// The value of this property is a QRCode image that encodes the geographic coordinates of the resource. The coordinates are encoded using the WGS84 datum in the following form - geo:[lat],[long]
    /// <see href="http://open.vocab.org/terms/geoqrcode"></see></summary>
    let geoqrcode = Namespaced_IRI.parse _namespace_name "geoqrcode" |> NamespacedName
    /// <summary>
    /// Boundary point has a position
    /// <see href="http://open.vocab.org/terms/has"></see></summary>
    let has = Namespaced_IRI.parse _namespace_name "has" |> NamespacedName
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/has.html"></see>
    /// </summary>
    let ``has.html`` = Namespaced_IRI.parse _namespace_name "has.html" |> NamespacedName

    /// <summary>
    /// DOMRange has 2 boundary points
    /// <see href="http://open.vocab.org/terms/hasBoundary"></see></summary>
    let hasBoundary =
        Namespaced_IRI.parse _namespace_name "hasBoundary" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hasBoundary.html"></see>
    /// </summary>
    let ``hasBoundary.html`` =
        Namespaced_IRI.parse _namespace_name "hasBoundary.html" |> NamespacedName

    /// <summary>
    /// has checksum - expecting (acronym/name):(checksum hexdigest)
    ///
    /// eg        ov:hasChecksum  "sha1:a526a7c1bc65348dc7649556bee283ee3c999b92"
    /// <see href="http://open.vocab.org/terms/hasChecksum"></see></summary>
    let hasChecksum =
        Namespaced_IRI.parse _namespace_name "hasChecksum" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hasChecksum.html"></see>
    /// </summary>
    let ``hasChecksum.html`` =
        Namespaced_IRI.parse _namespace_name "hasChecksum.html" |> NamespacedName

    /// <summary>
    /// Encoding MIME-Type information in a trivial manner - equivalent to HTTP header: Content-Type.
    /// <see href="http://open.vocab.org/terms/hasContentType"></see></summary>
    let hasContentType =
        Namespaced_IRI.parse _namespace_name "hasContentType" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hasContentType.html"></see>
    /// </summary>
    let ``hasContentType.html`` =
        Namespaced_IRI.parse _namespace_name "hasContentType.html" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hasFavourited"></see>
    /// </summary>
    let hasFavourited =
        Namespaced_IRI.parse _namespace_name "hasFavourited" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hasFavourited.html"></see>
    /// </summary>
    let ``hasFavourited.html`` =
        Namespaced_IRI.parse _namespace_name "hasFavourited.html" |> NamespacedName

    /// <summary>
    /// Domain: any institution or individual who borrows money from loaner
    /// Range: any institution or individual who loans a borrower money
    /// <see href="http://open.vocab.org/terms/hasLender"></see></summary>
    let hasLender = Namespaced_IRI.parse _namespace_name "hasLender" |> NamespacedName
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Borrower"></see>
    /// </summary>
    let Borrower = Namespaced_IRI.parse _namespace_name "Borrower" |> NamespacedName
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Loaner"></see>
    /// </summary>
    let Loaner = Namespaced_IRI.parse _namespace_name "Loaner" |> NamespacedName
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hasMD5"></see>
    /// </summary>
    let hasMD5 = Namespaced_IRI.parse _namespace_name "hasMD5" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hasMD5.html"></see>
    /// </summary>
    let ``hasMD5.html`` =
        Namespaced_IRI.parse _namespace_name "hasMD5.html" |> NamespacedName

    /// <summary>
    /// Links a person to a country that he or she may be a member. (A person can have multiple nationalities). The domain is foaf:Person but the range is open (although http://dbpedia.org/ontology/Country or http://umbel.org/umbel/rc/Country are suggested)
    /// <see href="http://open.vocab.org/terms/hasNationality"></see></summary>
    let hasNationality =
        Namespaced_IRI.parse _namespace_name "hasNationality" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hasNode"></see>
    /// </summary>
    let hasNode = Namespaced_IRI.parse _namespace_name "hasNode" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hasNode.html"></see>
    /// </summary>
    let ``hasNode.html`` =
        Namespaced_IRI.parse _namespace_name "hasNode.html" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hasOffset"></see>
    /// </summary>
    let hasOffset = Namespaced_IRI.parse _namespace_name "hasOffset" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hasOffset.html"></see>
    /// </summary>
    let ``hasOffset.html`` =
        Namespaced_IRI.parse _namespace_name "hasOffset.html" |> NamespacedName

    /// <summary>
    /// Something has a plot.
    /// <see href="http://open.vocab.org/terms/hasPlot"></see></summary>
    let hasPlot = Namespaced_IRI.parse _namespace_name "hasPlot" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hasPlot.html"></see>
    /// </summary>
    let ``hasPlot.html`` =
        Namespaced_IRI.parse _namespace_name "hasPlot.html" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hasPosition"></see>
    /// </summary>
    let hasPosition =
        Namespaced_IRI.parse _namespace_name "hasPosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hasPosition.html"></see>
    /// </summary>
    let ``hasPosition.html`` =
        Namespaced_IRI.parse _namespace_name "hasPosition.html" |> NamespacedName

    /// <summary>
    /// a resource (e.g. HTML content --&gt; awol:Content) has a DOM range
    /// <see href="http://open.vocab.org/terms/hasRange"></see></summary>
    let hasRange = Namespaced_IRI.parse _namespace_name "hasRange" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hasRange.html"></see>
    /// </summary>
    let ``hasRange.html`` =
        Namespaced_IRI.parse _namespace_name "hasRange.html" |> NamespacedName

    /// <summary>
    /// Slang for loves.
    /// <see href="http://open.vocab.org/terms/hearts"></see></summary>
    let hearts = Namespaced_IRI.parse _namespace_name "hearts" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hearts.html"></see>
    /// </summary>
    let ``hearts.html`` =
        Namespaced_IRI.parse _namespace_name "hearts.html" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/homepage"></see>
    /// </summary>
    let homepage = Namespaced_IRI.parse _namespace_name "homepage" |> NamespacedName
    /// <summary>
    /// color of a house
    /// <see href="http://open.vocab.org/terms/houseColor"></see></summary>
    let houseColor = Namespaced_IRI.parse _namespace_name "houseColor" |> NamespacedName
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/Colors"></see>
    /// </summary>
    let Colors = Namespaced_IRI.parse _namespace_name "Colors" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/housePaintColor"></see>
    /// </summary>
    let housePaintColor =
        Namespaced_IRI.parse _namespace_name "housePaintColor" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/colorsOfHouses"></see>
    /// </summary>
    let colorsOfHouses =
        Namespaced_IRI.parse _namespace_name "colorsOfHouses" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/houseColor.html"></see>
    /// </summary>
    let ``houseColor.html`` =
        Namespaced_IRI.parse _namespace_name "houseColor.html" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hudBefore"></see>
    /// </summary>
    let hudBefore = Namespaced_IRI.parse _namespace_name "hudBefore" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hudBefore.html"></see>
    /// </summary>
    let ``hudBefore.html`` =
        Namespaced_IRI.parse _namespace_name "hudBefore.html" |> NamespacedName

    /// <summary>
    /// The number of loans two books have in common
    /// <see href="http://open.vocab.org/terms/hudCommon"></see></summary>
    let hudCommon = Namespaced_IRI.parse _namespace_name "hudCommon" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hudCommon.html"></see>
    /// </summary>
    let ``hudCommon.html`` =
        Namespaced_IRI.parse _namespace_name "hudCommon.html" |> NamespacedName

    /// <summary>
    /// A course associated with a book loan
    /// <see href="http://open.vocab.org/terms/hudCourse"></see></summary>
    let hudCourse = Namespaced_IRI.parse _namespace_name "hudCourse" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hudCourse.html"></see>
    /// </summary>
    let ``hudCourse.html`` =
        Namespaced_IRI.parse _namespace_name "hudCourse.html" |> NamespacedName

    /// <summary>
    /// The number of loans of a book within a year, school, or course
    /// <see href="http://open.vocab.org/terms/hudLoanCount"></see></summary>
    let hudLoanCount =
        Namespaced_IRI.parse _namespace_name "hudLoanCount" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hudLoanCount.html"></see>
    /// </summary>
    let ``hudLoanCount.html`` =
        Namespaced_IRI.parse _namespace_name "hudLoanCount.html" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hudLoanTotal"></see>
    /// </summary>
    let hudLoanTotal =
        Namespaced_IRI.parse _namespace_name "hudLoanTotal" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hudLoanTotal.html"></see>
    /// </summary>
    let ``hudLoanTotal.html`` =
        Namespaced_IRI.parse _namespace_name "hudLoanTotal.html" |> NamespacedName

    /// <summary>
    /// simultaneous loans
    /// <see href="http://open.vocab.org/terms/hudSame"></see></summary>
    let hudSame = Namespaced_IRI.parse _namespace_name "hudSame" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hudSame.html"></see>
    /// </summary>
    let ``hudSame.html`` =
        Namespaced_IRI.parse _namespace_name "hudSame.html" |> NamespacedName

    /// <summary>
    /// The school associated with the loan history of a book
    /// <see href="http://open.vocab.org/terms/hudSchool"></see></summary>
    let hudSchool = Namespaced_IRI.parse _namespace_name "hudSchool" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hudSchool.html"></see>
    /// </summary>
    let ``hudSchool.html`` =
        Namespaced_IRI.parse _namespace_name "hudSchool.html" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hudSchoolLoan"></see>
    /// </summary>
    let hudSchoolLoan =
        Namespaced_IRI.parse _namespace_name "hudSchoolLoan" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hudSchoolLoan.html"></see>
    /// </summary>
    let ``hudSchoolLoan.html`` =
        Namespaced_IRI.parse _namespace_name "hudSchoolLoan.html" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hudSuggestedBook"></see>
    /// </summary>
    let hudSuggestedBook =
        Namespaced_IRI.parse _namespace_name "hudSuggestedBook" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hudSuggestion"></see>
    /// </summary>
    let hudSuggestion =
        Namespaced_IRI.parse _namespace_name "hudSuggestion" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hudSuggestion.html"></see>
    /// </summary>
    let ``hudSuggestion.html`` =
        Namespaced_IRI.parse _namespace_name "hudSuggestion.html" |> NamespacedName

    /// <summary>
    /// The year associated with a loan history
    /// <see href="http://open.vocab.org/terms/hudYear"></see></summary>
    let hudYear = Namespaced_IRI.parse _namespace_name "hudYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/hudYear.html"></see>
    /// </summary>
    let ``hudYear.html`` =
        Namespaced_IRI.parse _namespace_name "hudYear.html" |> NamespacedName

    /// <summary>
    /// a pictorial representation for something.
    /// <see href="http://open.vocab.org/terms/icon"></see></summary>
    let icon = Namespaced_IRI.parse _namespace_name "icon" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/imWsBhgGVLi"></see>
    /// </summary>
    let imWsBhgGVLi =
        Namespaced_IRI.parse _namespace_name "imWsBhgGVLi" |> NamespacedName

    /// <summary>
    /// an image of the resource, whatever it may be. Typically the value of this property will be the URI of some sort of digital image.
    /// <see href="http://open.vocab.org/terms/image"></see></summary>
    let image = Namespaced_IRI.parse _namespace_name "image" |> NamespacedName

    /// <summary>
    /// The name used when referred to in informal situations, e.g. Ian Davis
    ///
    /// <see href="http://open.vocab.org/terms/informalName"></see></summary>
    let informalName =
        Namespaced_IRI.parse _namespace_name "informalName" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/informalName.html"></see>
    /// </summary>
    let ``informalName.html`` =
        Namespaced_IRI.parse _namespace_name "informalName.html" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/isCategoryOf.html"></see>
    /// </summary>
    let ``isCategoryOf.html`` =
        Namespaced_IRI.parse _namespace_name "isCategoryOf.html" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/isCuratedBy"></see>
    /// </summary>
    let isCuratedBy =
        Namespaced_IRI.parse _namespace_name "isCuratedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/isCuratedBy.html"></see>
    /// </summary>
    let ``isCuratedBy.html`` =
        Namespaced_IRI.parse _namespace_name "isCuratedBy.html" |> NamespacedName

    /// <summary>
    /// DOMBoundaryPointPosition is defines by a DOMNode and a DOMOffset
    /// <see href="http://open.vocab.org/terms/isDefinedBy"></see></summary>
    let isDefinedBy =
        Namespaced_IRI.parse _namespace_name "isDefinedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/isDefinedBy.html"></see>
    /// </summary>
    let ``isDefinedBy.html`` =
        Namespaced_IRI.parse _namespace_name "isDefinedBy.html" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/isHeaderOf"></see>
    /// </summary>
    let isHeaderOf = Namespaced_IRI.parse _namespace_name "isHeaderOf" |> NamespacedName
    /// <summary>
    /// Property to link an agent with an organization (inverse property of http://xmlns.com/foaf/0.1/member)
    /// <see href="http://open.vocab.org/terms/isMemberOf"></see></summary>
    let isMemberOf = Namespaced_IRI.parse _namespace_name "isMemberOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/isHeaderOf.html"></see>
    /// </summary>
    let ``isHeaderOf.html`` =
        Namespaced_IRI.parse _namespace_name "isHeaderOf.html" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/isSongOfEarworm.html"></see>
    /// </summary>
    let ``isSongOfEarworm.html`` =
        Namespaced_IRI.parse _namespace_name "isSongOfEarworm.html" |> NamespacedName

    /// <summary>
    /// The JSON representation of a (usually small) dataset.
    /// <see href="http://open.vocab.org/terms/json"></see></summary>
    let json = Namespaced_IRI.parse _namespace_name "json" |> NamespacedName
    /// <summary>
    /// A comma separated list of words that are particularly pertinent to this resource.
    /// <see href="http://open.vocab.org/terms/keywords"></see></summary>
    let keywords = Namespaced_IRI.parse _namespace_name "keywords" |> NamespacedName
    /// <summary>
    /// The number of kilometres of a distance measurement.
    /// <see href="http://open.vocab.org/terms/kilometres"></see></summary>
    let kilometres = Namespaced_IRI.parse _namespace_name "kilometres" |> NamespacedName
    /// <summary>
    /// to express kudos to someone (acknowledge a contribution, feedback, etc.)
    /// <see href="http://open.vocab.org/terms/kudosTo"></see></summary>
    let kudosTo = Namespaced_IRI.parse _namespace_name "kudosTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/kudosTo.html"></see>
    /// </summary>
    let ``kudosTo.html`` =
        Namespaced_IRI.parse _namespace_name "kudosTo.html" |> NamespacedName

    /// <summary>
    /// The most recently cached static page describing the resource.
    /// <see href="http://open.vocab.org/terms/lastCachedPage"></see></summary>
    let lastCachedPage =
        Namespaced_IRI.parse _namespace_name "lastCachedPage" |> NamespacedName

    /// <summary>
    /// The linear extent of a thing.
    /// <see href="http://open.vocab.org/terms/length"></see></summary>
    let length = Namespaced_IRI.parse _namespace_name "length" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/length.html"></see>
    /// </summary>
    let ``length.html`` =
        Namespaced_IRI.parse _namespace_name "length.html" |> NamespacedName

    /// <summary>
    /// A service providing access to bibliographic resources.
    /// <see href="http://open.vocab.org/terms/libraryService"></see></summary>
    let libraryService =
        Namespaced_IRI.parse _namespace_name "libraryService" |> NamespacedName

    /// <summary>
    /// a machine tag that can be used to identify the domain resource in tagging applications.
    /// <see href="http://open.vocab.org/terms/machineTag"></see></summary>
    let machineTag = Namespaced_IRI.parse _namespace_name "machineTag" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/machineTag.html"></see>
    /// </summary>
    let ``machineTag.html`` =
        Namespaced_IRI.parse _namespace_name "machineTag.html" |> NamespacedName

    /// <summary>
    /// The place where a particular object was made. (Made is left intentionally vague and follows the same semantics as foaf:maker, foaf:made etc.)
    /// <see href="http://open.vocab.org/terms/madeIn"></see></summary>
    let madeIn = Namespaced_IRI.parse _namespace_name "madeIn" |> NamespacedName
    /// <summary>
    /// A person's maiden name.
    /// <see href="http://open.vocab.org/terms/maidenName"></see></summary>
    let maidenName = Namespaced_IRI.parse _namespace_name "maidenName" |> NamespacedName
    /// <summary>
    /// The Manchester Syntax for a owl construct (e.g., Restriction).
    ///
    /// :manchex rdfs:subPropertyOf rdfs:label .
    /// <see href="http://open.vocab.org/terms/manchax"></see></summary>
    let manchax = Namespaced_IRI.parse _namespace_name "manchax" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/manchax.html"></see>
    /// </summary>
    let ``manchax.html`` =
        Namespaced_IRI.parse _namespace_name "manchax.html" |> NamespacedName

    /// <summary>
    /// Indicates a resource that is designed to be a mirror or surrogate of the object resource; a backup copy, should the object resource be lost or unobtainable.
    /// <see href="http://open.vocab.org/terms/mirror"></see></summary>
    let mirror = Namespaced_IRI.parse _namespace_name "mirror" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/mirror.html"></see>
    /// </summary>
    let ``mirror.html`` =
        Namespaced_IRI.parse _namespace_name "mirror.html" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/mllxMBbjeh"></see>
    /// </summary>
    let mllxMBbjeh = Namespaced_IRI.parse _namespace_name "mllxMBbjeh" |> NamespacedName

    /// <summary>
    /// The Vehicle Classes an MOT Test Station is authorised to test, as a comma separated list using Arabic numerals (plus A where appropriate), e.g "3, 4, 4A, 5".
    /// <see href="http://open.vocab.org/terms/motVehicleClasses"></see></summary>
    let motVehicleClasses =
        Namespaced_IRI.parse _namespace_name "motVehicleClasses" |> NamespacedName

    /// <summary>
    /// Places named in a text.
    /// <see href="http://open.vocab.org/terms/namedPlace"></see></summary>
    let namedPlace = Namespaced_IRI.parse _namespace_name "namedPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/namedPlace.html"></see>
    /// </summary>
    let ``namedPlace.html`` =
        Namespaced_IRI.parse _namespace_name "namedPlace.html" |> NamespacedName

    /// <summary>
    /// A (UK) national grid reference for a given location, using the alphanumeric syntax.
    /// <see href="http://open.vocab.org/terms/national-grid-reference"></see></summary>
    let ``national-grid-reference`` =
        Namespaced_IRI.parse _namespace_name "national-grid-reference" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/national-grid-reference.html"></see>
    /// </summary>
    let ``national-grid-reference.html`` =
        Namespaced_IRI.parse _namespace_name "national-grid-reference.html" |> NamespacedName

    /// <summary>
    /// This property is a relationship between some thing and a map that shows that thing's location at a national scale.
    /// <see href="http://open.vocab.org/terms/nationalContextMap"></see></summary>
    let nationalContextMap =
        Namespaced_IRI.parse _namespace_name "nationalContextMap" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/nationalContextMap.html"></see>
    /// </summary>
    let ``nationalContextMap.html`` =
        Namespaced_IRI.parse _namespace_name "nationalContextMap.html" |> NamespacedName

    /// <summary>
    /// x is 'near' y if they are near to each other in physical space, for a deliberately vague notion of near.
    /// <see href="http://open.vocab.org/terms/near"></see></summary>
    let near = Namespaced_IRI.parse _namespace_name "near" |> NamespacedName

    /// <summary>
    /// The desired visibility of a User's social network. Suggested options: "Just Me", "My Network", "Everyone".
    /// <see href="http://open.vocab.org/terms/networkVisibility"></see></summary>
    let networkVisibility =
        Namespaced_IRI.parse _namespace_name "networkVisibility" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/networkVisibility.html"></see>
    /// </summary>
    let ``networkVisibility.html`` =
        Namespaced_IRI.parse _namespace_name "networkVisibility.html" |> NamespacedName

    /// <summary>
    /// a total count of the number of resources of type &lt;http://purl.org/stuff/rev#Review&gt; that an Agent is known to have created
    /// <see href="http://open.vocab.org/terms/noOfReviewsWritten"></see></summary>
    let noOfReviewsWritten =
        Namespaced_IRI.parse _namespace_name "noOfReviewsWritten" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/noOfReviewsWritten.html"></see>
    /// </summary>
    let ``noOfReviewsWritten.html`` =
        Namespaced_IRI.parse _namespace_name "noOfReviewsWritten.html" |> NamespacedName

    /// <summary>
    /// The number of pages a resource has
    /// <see href="http://open.vocab.org/terms/numberOfPages"></see></summary>
    let numberOfPages =
        Namespaced_IRI.parse _namespace_name "numberOfPages" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/numberOfPages.html"></see>
    /// </summary>
    let ``numberOfPages.html`` =
        Namespaced_IRI.parse _namespace_name "numberOfPages.html" |> NamespacedName

    /// <summary>
    /// Organization who offers the course, e.g. a department, a school, a research institute
    /// <see href="http://open.vocab.org/terms/offeredBy"></see></summary>
    let offeredBy = Namespaced_IRI.parse _namespace_name "offeredBy" |> NamespacedName

    /// <summary>
    /// Course offered by the organization
    /// <see href="http://open.vocab.org/terms/offersCourse"></see></summary>
    let offersCourse =
        Namespaced_IRI.parse _namespace_name "offersCourse" |> NamespacedName

    /// <summary>
    /// the okkam ID of the entity, given in human legible form (literal)
    /// <see href="http://open.vocab.org/terms/okkamID"></see></summary>
    let okkamID = Namespaced_IRI.parse _namespace_name "okkamID" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/okkamID.html"></see>
    /// </summary>
    let ``okkamID.html`` =
        Namespaced_IRI.parse _namespace_name "okkamID.html" |> NamespacedName

    /// <summary>
    /// The source of a thing.
    /// <see href="http://open.vocab.org/terms/origin"></see></summary>
    let origin = Namespaced_IRI.parse _namespace_name "origin" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/origin.html"></see>
    /// </summary>
    let ``origin.html`` =
        Namespaced_IRI.parse _namespace_name "origin.html" |> NamespacedName

    /// <summary>
    /// A thing that came into existence at a place and time originates from that place and time.
    /// <see href="http://open.vocab.org/terms/originatesFrom"></see></summary>
    let originatesFrom =
        Namespaced_IRI.parse _namespace_name "originatesFrom" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/originatesFrom.html"></see>
    /// </summary>
    let ``originatesFrom.html`` =
        Namespaced_IRI.parse _namespace_name "originatesFrom.html" |> NamespacedName

    /// <summary>
    /// An element of a whole.
    /// <see href="http://open.vocab.org/terms/part"></see></summary>
    let part = Namespaced_IRI.parse _namespace_name "part" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/part.html"></see>
    /// </summary>
    let ``part.html`` =
        Namespaced_IRI.parse _namespace_name "part.html" |> NamespacedName

    /// <summary>
    /// a password usually stored in md5
    /// <see href="http://open.vocab.org/terms/passwd"></see></summary>
    let passwd = Namespaced_IRI.parse _namespace_name "passwd" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/passwd.html"></see>
    /// </summary>
    let ``passwd.html`` =
        Namespaced_IRI.parse _namespace_name "passwd.html" |> NamespacedName

    /// <summary>
    /// 7dFHvo  &lt;a href="http://nussehqldled.com/"&gt;nussehqldled&lt;/a&gt;, [url=http://uvurwqyxjgik.com/]uvurwqyxjgik[/url], [link=http://yqeuzuciwezi.com/]yqeuzuciwezi[/link], http://sdzwxhzsaaqq.com/
    /// <see href="http://open.vocab.org/terms/performer"></see></summary>
    let performer = Namespaced_IRI.parse _namespace_name "performer" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/performer.html"></see>
    /// </summary>
    let ``performer.html`` =
        Namespaced_IRI.parse _namespace_name "performer.html" |> NamespacedName

    /// <summary>
    /// A telephone number that can be used to contact a Person or Organisation.
    /// <see href="http://open.vocab.org/terms/phoneNumber"></see></summary>
    let phoneNumber =
        Namespaced_IRI.parse _namespace_name "phoneNumber" |> NamespacedName

    /// <summary>
    /// A plot of anything.
    /// <see href="http://open.vocab.org/terms/plot"></see></summary>
    let plot = Namespaced_IRI.parse _namespace_name "plot" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/plot.html"></see>
    /// </summary>
    let ``plot.html`` =
        Namespaced_IRI.parse _namespace_name "plot.html" |> NamespacedName

    /// <summary>
    /// A postal address to which letters and parcels can be sent to a Person or Organisation.
    /// <see href="http://open.vocab.org/terms/postalAddress"></see></summary>
    let postalAddress =
        Namespaced_IRI.parse _namespace_name "postalAddress" |> NamespacedName

    /// <summary>
    /// Preferred or official acronym as used by the subject.
    /// <see href="http://open.vocab.org/terms/prefAcronym"></see></summary>
    let prefAcronym =
        Namespaced_IRI.parse _namespace_name "prefAcronym" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/prefAcronym.html"></see>
    /// </summary>
    let ``prefAcronym.html`` =
        Namespaced_IRI.parse _namespace_name "prefAcronym.html" |> NamespacedName

    /// <summary>
    /// The preferred animal of a person.
    /// <see href="http://open.vocab.org/terms/preferredAnimal"></see></summary>
    let preferredAnimal =
        Namespaced_IRI.parse _namespace_name "preferredAnimal" |> NamespacedName

    /// <summary>
    /// The primary material from which something is made.
    ///
    /// Examples: leather (shoe), paper (book), cotton (t-shirt), nylon (tights), plastic (carrier bag), rubber (wellington boots), iron (pipe) etc.
    /// <see href="http://open.vocab.org/terms/primaryMaterial"></see></summary>
    let primaryMaterial =
        Namespaced_IRI.parse _namespace_name "primaryMaterial" |> NamespacedName

    /// <summary>
    /// It is about provenance of web data.
    /// <see href="http://open.vocab.org/terms/provenance"></see></summary>
    let provenance = Namespaced_IRI.parse _namespace_name "provenance" |> NamespacedName
    /// <summary>
    ///   <see href="http://open.vocab.org/terms/quote"></see>
    /// </summary>
    let quote = Namespaced_IRI.parse _namespace_name "quote" |> NamespacedName
    /// <summary>
    /// The rank of the resource within the ordered collection represented by the current document
    /// <see href="http://open.vocab.org/terms/rank"></see></summary>
    let rank = Namespaced_IRI.parse _namespace_name "rank" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/rank.html"></see>
    /// </summary>
    let ``rank.html`` =
        Namespaced_IRI.parse _namespace_name "rank.html" |> NamespacedName

    /// <summary>
    /// express the ability/right to read from a graph
    /// <see href="http://open.vocab.org/terms/readGraph"></see></summary>
    let readGraph = Namespaced_IRI.parse _namespace_name "readGraph" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/readGraph.html"></see>
    /// </summary>
    let ``readGraph.html`` =
        Namespaced_IRI.parse _namespace_name "readGraph.html" |> NamespacedName

    /// <summary>
    /// A property to capture an un-intepreted written address, notably for addresses that have yet to be or can never be semantically represented using an existing scheme, such as the vcard ontology.
    /// <see href="http://open.vocab.org/terms/recordedAddress"></see></summary>
    let recordedAddress =
        Namespaced_IRI.parse _namespace_name "recordedAddress" |> NamespacedName

    /// <summary>
    /// This property is a relationship between some thing and a map that shows that thing's location at a regional scale.
    /// <see href="http://open.vocab.org/terms/regionalContextMap"></see></summary>
    let regionalContextMap =
        Namespaced_IRI.parse _namespace_name "regionalContextMap" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/regionalContextMap.html"></see>
    /// </summary>
    let ``regionalContextMap.html`` =
        Namespaced_IRI.parse _namespace_name "regionalContextMap.html" |> NamespacedName

    /// <summary>
    /// Defines reincarnation of someone
    /// <see href="http://open.vocab.org/terms/reincarnationOf"></see></summary>
    let reincarnationOf =
        Namespaced_IRI.parse _namespace_name "reincarnationOf" |> NamespacedName

    /// <summary>
    /// Organization who is responsible for (offers) the course. Like a department, a school...
    /// <see href="http://open.vocab.org/terms/responsiblityOf"></see></summary>
    let responsiblityOf =
        Namespaced_IRI.parse _namespace_name "responsiblityOf" |> NamespacedName

    /// <summary>
    /// The result of the test case obtained from the target specified. For example, the target could be a script that is executed.
    /// <see href="http://open.vocab.org/terms/resultFrom"></see></summary>
    let resultFrom = Namespaced_IRI.parse _namespace_name "resultFrom" |> NamespacedName

    /// <summary>
    /// The diameter of a thing measured at its rim.
    /// <see href="http://open.vocab.org/terms/rimDiameter"></see></summary>
    let rimDiameter =
        Namespaced_IRI.parse _namespace_name "rimDiameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/rimDiameter.html"></see>
    /// </summary>
    let ``rimDiameter.html`` =
        Namespaced_IRI.parse _namespace_name "rimDiameter.html" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/rtfm"></see>
    /// </summary>
    let rtfm = Namespaced_IRI.parse _namespace_name "rtfm" |> NamespacedName
    /// <summary>
    /// A screenshot showing the (software) project in action. Since DOAP only has a property to link a "web page with screenshots of project", not a specific screenshot, this property is sometimes more useful.
    /// <see href="http://open.vocab.org/terms/screenshot"></see></summary>
    let screenshot = Namespaced_IRI.parse _namespace_name "screenshot" |> NamespacedName
    /// <summary>
    /// Semester in which the course is offered
    /// <see href="http://open.vocab.org/terms/semester"></see></summary>
    let semester = Namespaced_IRI.parse _namespace_name "semester" |> NamespacedName
    /// <summary>
    /// The shape of something
    /// <see href="http://open.vocab.org/terms/shape"></see></summary>
    let shape = Namespaced_IRI.parse _namespace_name "shape" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/shape.html"></see>
    /// </summary>
    let ``shape.html`` =
        Namespaced_IRI.parse _namespace_name "shape.html" |> NamespacedName

    /// <summary>
    /// Just a simple readable name, a mnemonic.
    /// <see href="http://open.vocab.org/terms/shortName"></see></summary>
    let shortName = Namespaced_IRI.parse _namespace_name "shortName" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/shortName.html"></see>
    /// </summary>
    let ``shortName.html`` =
        Namespaced_IRI.parse _namespace_name "shortName.html" |> NamespacedName

    /// <summary>
    /// Relate a thing (usually a person) to the scent with which they are most commonly associated.
    /// <see href="http://open.vocab.org/terms/signatureScent"></see></summary>
    let signatureScent =
        Namespaced_IRI.parse _namespace_name "signatureScent" |> NamespacedName

    /// <summary>
    /// Having two things that are not the owl:sameAs but are similar to a certain extent. It is thought of being used where owl:sameAs is too strong but rdfs:seeAlso is too loose. Motivation: http://lists.w3.org/Archives/Public/public-lod/2009Feb/0189.html
    /// <see href="http://open.vocab.org/terms/similarTo"></see></summary>
    let similarTo = Namespaced_IRI.parse _namespace_name "similarTo" |> NamespacedName

    /// <summary>
    /// The number of results retrieved for a search on that uri from the Search Engine sindice
    /// <see href="http://open.vocab.org/terms/sindiceResultCount"></see></summary>
    let sindiceResultCount =
        Namespaced_IRI.parse _namespace_name "sindiceResultCount" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/sindiceResultCount.html"></see>
    /// </summary>
    let ``sindiceResultCount.html`` =
        Namespaced_IRI.parse _namespace_name "sindiceResultCount.html" |> NamespacedName

    /// <summary>
    /// Someone's ID in the Skype chat and telephony service.
    /// <see href="http://open.vocab.org/terms/skypeID"></see></summary>
    let skypeID = Namespaced_IRI.parse _namespace_name "skypeID" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/skypeID.html"></see>
    /// </summary>
    let ``skypeID.html`` =
        Namespaced_IRI.parse _namespace_name "skypeID.html" |> NamespacedName

    /// <summary>
    /// Associate a name that can be used for sorting to a foaf:Agent
    /// <see href="http://open.vocab.org/terms/sort-name"></see></summary>
    let ``sort-name`` =
        Namespaced_IRI.parse _namespace_name "sort-name" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/sort-name.html"></see>
    /// </summary>
    let ``sort-name.html`` =
        Namespaced_IRI.parse _namespace_name "sort-name.html" |> NamespacedName

    /// <summary>
    /// A label for a resource that is syntactically arranged to be suitable for sorting
    /// <see href="http://open.vocab.org/terms/sortLabel"></see></summary>
    let sortLabel = Namespaced_IRI.parse _namespace_name "sortLabel" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/sortLabel.html"></see>
    /// </summary>
    let ``sortLabel.html`` =
        Namespaced_IRI.parse _namespace_name "sortLabel.html" |> NamespacedName

    /// <summary>
    /// associates a given feature file document with the audio file that is described by that document
    /// <see href="http://open.vocab.org/terms/sourcefile"></see></summary>
    let sourcefile = Namespaced_IRI.parse _namespace_name "sourcefile" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/sourcefile.html"></see>
    /// </summary>
    let ``sourcefile.html`` =
        Namespaced_IRI.parse _namespace_name "sourcefile.html" |> NamespacedName

    /// <summary>
    /// The specification(s) that the resource implemented.
    /// <see href="http://open.vocab.org/terms/specification"></see></summary>
    let specification =
        Namespaced_IRI.parse _namespace_name "specification" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/specification.html"></see>
    /// </summary>
    let ``specification.html`` =
        Namespaced_IRI.parse _namespace_name "specification.html" |> NamespacedName

    /// <summary>
    /// The time of day that something starts at.
    /// <see href="http://open.vocab.org/terms/startTime"></see></summary>
    let startTime = Namespaced_IRI.parse _namespace_name "startTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/startTime.html"></see>
    /// </summary>
    let ``startTime.html`` =
        Namespaced_IRI.parse _namespace_name "startTime.html" |> NamespacedName

    /// <summary>
    /// Asserts that a reified rdf:Statement is asserted (in a non-reified form) by a particular RDF graph.
    /// <see href="http://open.vocab.org/terms/statement"></see></summary>
    let statement = Namespaced_IRI.parse _namespace_name "statement" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/statement.html"></see>
    /// </summary>
    let ``statement.html`` =
        Namespaced_IRI.parse _namespace_name "statement.html" |> NamespacedName

    /// <summary>
    /// A human readable description of the status of an opmv:Process upon completion.
    /// <see href="http://open.vocab.org/terms/status"></see></summary>
    let status = Namespaced_IRI.parse _namespace_name "status" |> NamespacedName
    /// <summary>
    /// The the measure of how sticky something is
    /// <see href="http://open.vocab.org/terms/stickiness"></see></summary>
    let stickiness = Namespaced_IRI.parse _namespace_name "stickiness" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/stickiness.html"></see>
    /// </summary>
    let ``stickiness.html`` =
        Namespaced_IRI.parse _namespace_name "stickiness.html" |> NamespacedName

    /// <summary>
    /// A topic or work that is studied by a person or group (e.g., a university course)
    /// <see href="http://open.vocab.org/terms/studies"></see></summary>
    let studies = Namespaced_IRI.parse _namespace_name "studies" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/studies.html"></see>
    /// </summary>
    let ``studies.html`` =
        Namespaced_IRI.parse _namespace_name "studies.html" |> NamespacedName

    /// <summary>
    /// An additional or secondary title usually used expand or limit the main title
    /// <see href="http://open.vocab.org/terms/subtitle"></see></summary>
    let subtitle = Namespaced_IRI.parse _namespace_name "subtitle" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/subtitle.html"></see>
    /// </summary>
    let ``subtitle.html`` =
        Namespaced_IRI.parse _namespace_name "subtitle.html" |> NamespacedName

    /// <summary>
    /// Relates a person to an earworm that they suffer.
    /// <see href="http://open.vocab.org/terms/suffersEarworm"></see></summary>
    let suffersEarworm =
        Namespaced_IRI.parse _namespace_name "suffersEarworm" |> NamespacedName

    /// <summary>
    /// An agent syndicates a document some way.
    /// <see href="http://open.vocab.org/terms/syndicates"></see></summary>
    let syndicates = Namespaced_IRI.parse _namespace_name "syndicates" |> NamespacedName

    /// <summary>
    /// the number of times a tag has been used in taggings of things
    /// <see href="http://open.vocab.org/terms/taggingCount"></see></summary>
    let taggingCount =
        Namespaced_IRI.parse _namespace_name "taggingCount" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/taggingCount.html"></see>
    /// </summary>
    let ``taggingCount.html`` =
        Namespaced_IRI.parse _namespace_name "taggingCount.html" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/teaches"></see>
    /// </summary>
    let teaches = Namespaced_IRI.parse _namespace_name "teaches" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/teaches.html"></see>
    /// </summary>
    let ``teaches.html`` =
        Namespaced_IRI.parse _namespace_name "teaches.html" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/test"></see>
    /// </summary>
    let test = Namespaced_IRI.parse _namespace_name "test" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/twitter-id"></see>
    /// </summary>
    let ``twitter-id`` =
        Namespaced_IRI.parse _namespace_name "twitter-id" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/twitter-id.html"></see>
    /// </summary>
    let ``twitter-id.html`` =
        Namespaced_IRI.parse _namespace_name "twitter-id.html" |> NamespacedName

    /// <summary>
    /// An Internet host used in the context of an opmv:Process.
    /// <see href="http://open.vocab.org/terms/usedHost"></see></summary>
    let usedHost = Namespaced_IRI.parse _namespace_name "usedHost" |> NamespacedName

    /// <summary>
    /// The subject (perhaps a foaf:Agent) made HTTP requests with a header described by this http:MessageHeader resource.
    /// <see href="http://open.vocab.org/terms/usedHttpHeader"></see></summary>
    let usedHttpHeader =
        Namespaced_IRI.parse _namespace_name "usedHttpHeader" |> NamespacedName

    /// <summary>
    /// links to a thing used by an agent
    /// <see href="http://open.vocab.org/terms/uses"></see></summary>
    let uses = Namespaced_IRI.parse _namespace_name "uses" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/uses.html"></see>
    /// </summary>
    let ``uses.html`` =
        Namespaced_IRI.parse _namespace_name "uses.html" |> NamespacedName

    /// <summary>
    /// To mark the beginning date or event at which the named graph object is true/accurate.
    /// <see href="http://open.vocab.org/terms/validFrom"></see></summary>
    let validFrom = Namespaced_IRI.parse _namespace_name "validFrom" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/validFrom.html"></see>
    /// </summary>
    let ``validFrom.html`` =
        Namespaced_IRI.parse _namespace_name "validFrom.html" |> NamespacedName

    /// <summary>
    /// To mark the date or event at which the named graph object ceases to be accurate.
    /// <see href="http://open.vocab.org/terms/validUntil"></see></summary>
    let validUntil = Namespaced_IRI.parse _namespace_name "validUntil" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/validUntil.html"></see>
    /// </summary>
    let ``validUntil.html`` =
        Namespaced_IRI.parse _namespace_name "validUntil.html" |> NamespacedName

    /// <summary>
    /// Property to encode the version of things - simple intent, to record the sequence of items. (The items themselves will have temporal/finer grained detail)
    /// <see href="http://open.vocab.org/terms/versionnumber"></see></summary>
    let versionnumber =
        Namespaced_IRI.parse _namespace_name "versionnumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/versionnumber.html"></see>
    /// </summary>
    let ``versionnumber.html`` =
        Namespaced_IRI.parse _namespace_name "versionnumber.html" |> NamespacedName

    /// <summary>
    /// The visibility of a resource (e.g. public, internal), expressed as a literal term.
    /// <see href="http://open.vocab.org/terms/visibility"></see></summary>
    let visibility = Namespaced_IRI.parse _namespace_name "visibility" |> NamespacedName
    /// <summary>
    /// The weight of a resource
    /// <see href="http://open.vocab.org/terms/weight"></see></summary>
    let weight = Namespaced_IRI.parse _namespace_name "weight" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/weight.html"></see>
    /// </summary>
    let ``weight.html`` =
        Namespaced_IRI.parse _namespace_name "weight.html" |> NamespacedName

    /// <summary>
    /// A wiki page associated with this resource
    /// <see href="http://open.vocab.org/terms/wikiPage"></see></summary>
    let wikiPage = Namespaced_IRI.parse _namespace_name "wikiPage" |> NamespacedName
    /// <summary>
    /// express the ability/right to write to a graph
    /// <see href="http://open.vocab.org/terms/writeGraph"></see></summary>
    let writeGraph = Namespaced_IRI.parse _namespace_name "writeGraph" |> NamespacedName

    /// <summary>
    ///   <see href="http://open.vocab.org/terms/writeGraph.html"></see>
    /// </summary>
    let ``writeGraph.html`` =
        Namespaced_IRI.parse _namespace_name "writeGraph.html" |> NamespacedName

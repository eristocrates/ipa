namespace http._open.vocab.org.terms.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module open_ =
    let _namespace_iri = Namespace_Iri open_ |> NamespaceIRI
    /// <summary>
    ///   <para>open:AfricanRedSlip</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The ceramic ware produced during the Roman period in the region of what is now the modern country of Tunisia."</para>
    /// labels<para>"African Red Slip"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/AfricanRedSlip">http://open.vocab.org/terms/AfricanRedSlip</seealso>
    let AfricanRedSlip = Prefixed_Name(open_, "AfricanRedSlip") |> PrefixedName

    /// <summary>
    ///   <para>open:AmateurRadioContact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is a major goal of Amateur Radio Operators to make contact with each other.  This contact is formally defined as the exchange of certain information, usually consisting of each operator's call sign and a signal report (how well each operator receives the signal of the other).  A contact can last a few seconds to many minutes.  Nickname "QSL"."</para>
    /// labels<para>"An event that is a contact between two AmateurRadioOperators"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/AmateurRadioContact">http://open.vocab.org/terms/AmateurRadioContact</seealso>
    let AmateurRadioContact =
        Prefixed_Name(open_, "AmateurRadioContact") |> PrefixedName

    /// <summary>
    ///   <para>open:AmateurRadioOperator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person who is licensed in at least one ITU region to operate (transmit and receive) a radio using frequencies and modes permitted only  to licensed persons."</para>
    /// labels<para>"Amateur Radio Operator"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/AmateurRadioOperator">http://open.vocab.org/terms/AmateurRadioOperator</seealso>
    let AmateurRadioOperator =
        Prefixed_Name(open_, "AmateurRadioOperator") |> PrefixedName

    /// <summary>
    ///   <para>open:AnnotationSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A type of dataset that contains annotations on a set of resources."</para>
    /// labels<para>"Annotation Set"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/AnnotationSet">http://open.vocab.org/terms/AnnotationSet</seealso>
    let AnnotationSet = Prefixed_Name(open_, "AnnotationSet") |> PrefixedName

    /// <summary>
    ///   <para>open:AutomobileCataologType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Automobiles, when presented as a catalog, are generally categorized using the Car Maker / Car Model / Trim Package hierarchy."</para>
    /// labels<para>"Automobile Catalog Type"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/AutomobileCataologType">http://open.vocab.org/terms/AutomobileCataologType</seealso>
    let AutomobileCataologType =
        Prefixed_Name(open_, "AutomobileCataologType") |> PrefixedName

    /// <summary>
    ///   <para>open:AutomobileCataologType.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/AutomobileCataologType.html">http://open.vocab.org/terms/AutomobileCataologType.html</seealso>
    let ``AutomobileCataologType.html`` =
        Prefixed_Name(open_, "AutomobileCataologType.html") |> PrefixedName

    /// <summary>
    ///   <para>open:AutomobileModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"From en.wikipedia.org:
    /// "A car model is a particular brand of vehicle sold under a marque. From an engineering point of view, a particular car model is usually defined and/or constrained by the use of a particular car chassis/bodywork combination or the same monocoque.""</para>
    /// labels<para>"Automobile Model"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/AutomobileModel">http://open.vocab.org/terms/AutomobileModel</seealso>
    let AutomobileModel = Prefixed_Name(open_, "AutomobileModel") |> PrefixedName

    /// <summary>
    ///   <para>open:AutomobileModel.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/AutomobileModel.html">http://open.vocab.org/terms/AutomobileModel.html</seealso>
    let ``AutomobileModel.html`` =
        Prefixed_Name(open_, "AutomobileModel.html") |> PrefixedName

    /// <summary>
    ///   <para>open:AvatarCharacterTraits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class of character traits was created to describe the characters in the graphic novel Avatar-The Last Airbender.
    /// The motivation was to create a unique class identifying the characters in the trilogy."</para>
    /// labels<para>"General Trait of Characters in the Animated Series Avatar-The Last Airbender"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/AvatarCharacterTraits">http://open.vocab.org/terms/AvatarCharacterTraits</seealso>
    let AvatarCharacterTraits =
        Prefixed_Name(open_, "AvatarCharacterTraits") |> PrefixedName

    /// <summary>
    ///   <para>open:BiologicalDatabase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Database for Biologists (Bioinformatics)"</para>
    /// labels<para>"Biological Database"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/BiologicalDatabase">http://open.vocab.org/terms/BiologicalDatabase</seealso>
    let BiologicalDatabase = Prefixed_Name(open_, "BiologicalDatabase") |> PrefixedName

    /// <summary>
    ///   <para>open:BiologicalDatabase.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/BiologicalDatabase.html">http://open.vocab.org/terms/BiologicalDatabase.html</seealso>
    let ``BiologicalDatabase.html`` =
        Prefixed_Name(open_, "BiologicalDatabase.html") |> PrefixedName

    /// <summary>
    ///   <para>open:Birth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Birth class"</para>
    /// labels<para>"Birth"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/Birth">http://open.vocab.org/terms/Birth</seealso>
    let Birth = Prefixed_Name(open_, "Birth") |> PrefixedName
    /// <summary>
    ///   <para>open:Birth.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/Birth.html">http://open.vocab.org/terms/Birth.html</seealso>
    let ``Birth.html`` = Prefixed_Name(open_, "Birth.html") |> PrefixedName
    /// <summary>
    ///   <para>open:Borrower</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/Borrower">http://open.vocab.org/terms/Borrower</seealso>
    let Borrower = Prefixed_Name(open_, "Borrower") |> PrefixedName
    /// <summary>
    ///   <para>open:Calendar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Calendar"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/Calendar">http://open.vocab.org/terms/Calendar</seealso>
    let Calendar = Prefixed_Name(open_, "Calendar") |> PrefixedName
    /// <summary>
    ///   <para>open:Calendar.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/Calendar.html">http://open.vocab.org/terms/Calendar.html</seealso>
    let ``Calendar.html`` = Prefixed_Name(open_, "Calendar.html") |> PrefixedName
    /// <summary>
    ///   <para>open:Cheese</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Cheese is a food made from milk, usually the milk of cows, buffalo, goats, or sheep, by coagulation. "</para>
    /// labels<para>"Cheese"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/Cheese">http://open.vocab.org/terms/Cheese</seealso>
    let Cheese = Prefixed_Name(open_, "Cheese") |> PrefixedName
    /// <summary>
    ///   <para>open:Cheese.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/Cheese.html">http://open.vocab.org/terms/Cheese.html</seealso>
    let ``Cheese.html`` = Prefixed_Name(open_, "Cheese.html") |> PrefixedName
    /// <summary>
    ///   <para>open:ClassSkeleton</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Members of this class represent class skeletons which are sort of templates of a class.
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
    /// http://www.w3.org/TR/owl2-primer/#Property_Restrictions"</para>
    /// labels<para>"Class Skeleton"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/ClassSkeleton">http://open.vocab.org/terms/ClassSkeleton</seealso>
    let ClassSkeleton = Prefixed_Name(open_, "ClassSkeleton") |> PrefixedName
    /// <summary>
    ///   <para>open:Colors</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/Colors">http://open.vocab.org/terms/Colors</seealso>
    let Colors = Prefixed_Name(open_, "Colors") |> PrefixedName
    /// <summary>
    ///   <para>open:Country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A country is a geographical region. A country may be the territory of a sovereign state, the territory of a non-sovereign (or formerly sovereign) political division, or a region associated with a certain people or certain characteristics."</para>
    /// labels<para>"Country"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/Country">http://open.vocab.org/terms/Country</seealso>
    let Country = Prefixed_Name(open_, "Country") |> PrefixedName
    /// <summary>
    ///   <para>open:Course</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Course"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/Course">http://open.vocab.org/terms/Course</seealso>
    let Course = Prefixed_Name(open_, "Course") |> PrefixedName
    /// <summary>
    ///   <para>open:Course.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/Course.html">http://open.vocab.org/terms/Course.html</seealso>
    let ``Course.html`` = Prefixed_Name(open_, "Course.html") |> PrefixedName
    /// <summary>
    ///   <para>open:DOMBoundaryPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A boundary-point's position in a Document or DocumentFragment tree can be characterized by a node and an offset.
    /// http://www.w3.org/TR/2000/REC-DOM-Level-2-Traversal-Range-20001113/ranges.html#Level-2-Range-Definitions"</para>
    /// labels<para>"DOMBoundaryPoint"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/DOMBoundaryPoint">http://open.vocab.org/terms/DOMBoundaryPoint</seealso>
    let DOMBoundaryPoint = Prefixed_Name(open_, "DOMBoundaryPoint") |> PrefixedName

    /// <summary>
    ///   <para>open:DOMBoundaryPoint.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/DOMBoundaryPoint.html">http://open.vocab.org/terms/DOMBoundaryPoint.html</seealso>
    let ``DOMBoundaryPoint.html`` =
        Prefixed_Name(open_, "DOMBoundaryPoint.html") |> PrefixedName

    /// <summary>
    ///   <para>open:DOMBoundaryPointPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A boundary-point's position in a Document or DocumentFragment tree can be characterized by a node and an offset
    ///
    /// http://www.w3.org/TR/2000/REC-DOM-Level-2-Traversal-Range-20001113/ranges.html#Level-2-Range-Definitions"</para>
    /// labels<para>"DOMBoundaryPointPosition"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/DOMBoundaryPointPosition">http://open.vocab.org/terms/DOMBoundaryPointPosition</seealso>
    let DOMBoundaryPointPosition =
        Prefixed_Name(open_, "DOMBoundaryPointPosition") |> PrefixedName

    /// <summary>
    ///   <para>open:DOMBoundaryPointPosition.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/DOMBoundaryPointPosition.html">http://open.vocab.org/terms/DOMBoundaryPointPosition.html</seealso>
    let ``DOMBoundaryPointPosition.html`` =
        Prefixed_Name(open_, "DOMBoundaryPointPosition.html") |> PrefixedName

    /// <summary>
    ///   <para>open:DOMNode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"DOMNode can be a Attribute, Document, DocumentFragment, Element or EntityReference node."</para>
    /// labels<para>"DOMNode"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/DOMNode">http://open.vocab.org/terms/DOMNode</seealso>
    let DOMNode = Prefixed_Name(open_, "DOMNode") |> PrefixedName
    /// <summary>
    ///   <para>open:DOMNode.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/DOMNode.html">http://open.vocab.org/terms/DOMNode.html</seealso>
    let ``DOMNode.html`` = Prefixed_Name(open_, "DOMNode.html") |> PrefixedName
    /// <summary>
    ///   <para>open:DOMOffset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"the offset within a DOM node"</para>
    /// labels<para>"DOMOffset"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/DOMOffset">http://open.vocab.org/terms/DOMOffset</seealso>
    let DOMOffset = Prefixed_Name(open_, "DOMOffset") |> PrefixedName
    /// <summary>
    ///   <para>open:DOMOffset.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/DOMOffset.html">http://open.vocab.org/terms/DOMOffset.html</seealso>
    let ``DOMOffset.html`` = Prefixed_Name(open_, "DOMOffset.html") |> PrefixedName
    /// <summary>
    ///   <para>open:DOMRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A DOM Range consists of two boundary-points corresponding to the start and the end of the Range.
    /// http://www.w3.org/TR/2000/REC-DOM-Level-2-Traversal-Range-20001113/ranges.html#Level-2-Range-Definitions"</para>
    /// labels<para>"DOMRange"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/DOMRange">http://open.vocab.org/terms/DOMRange</seealso>
    let DOMRange = Prefixed_Name(open_, "DOMRange") |> PrefixedName
    /// <summary>
    ///   <para>open:DOMRange.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/DOMRange.html">http://open.vocab.org/terms/DOMRange.html</seealso>
    let ``DOMRange.html`` = Prefixed_Name(open_, "DOMRange.html") |> PrefixedName
    /// <summary>
    ///   <para>open:Database</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Database"</para>
    /// labels<para>"Database"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/Database">http://open.vocab.org/terms/Database</seealso>
    let Database = Prefixed_Name(open_, "Database") |> PrefixedName
    /// <summary>
    ///   <para>open:Database.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/Database.html">http://open.vocab.org/terms/Database.html</seealso>
    let ``Database.html`` = Prefixed_Name(open_, "Database.html") |> PrefixedName
    /// <summary>
    ///   <para>open:Death</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/Death">http://open.vocab.org/terms/Death</seealso>
    let Death = Prefixed_Name(open_, "Death") |> PrefixedName
    /// <summary>
    ///   <para>open:DeletedEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A construct representing a deleted entry in an Atom feed."</para>
    /// labels<para>"Deleted Entry"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/DeletedEntry">http://open.vocab.org/terms/DeletedEntry</seealso>
    let DeletedEntry = Prefixed_Name(open_, "DeletedEntry") |> PrefixedName

    /// <summary>
    ///   <para>open:DeletedEntry.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/DeletedEntry.html">http://open.vocab.org/terms/DeletedEntry.html</seealso>
    let ``DeletedEntry.html`` =
        Prefixed_Name(open_, "DeletedEntry.html") |> PrefixedName

    /// <summary>
    ///   <para>open:Diff</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A diff, showing the difference between a source resource and a target resource."</para>
    /// labels<para>"diff"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/Diff">http://open.vocab.org/terms/Diff</seealso>
    let Diff = Prefixed_Name(open_, "Diff") |> PrefixedName
    /// <summary>
    ///   <para>open:Diff.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/Diff.html">http://open.vocab.org/terms/Diff.html</seealso>
    let ``Diff.html`` = Prefixed_Name(open_, "Diff.html") |> PrefixedName
    /// <summary>
    ///   <para>open:DigitalAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"DAs would be typically files. Audio, movies, software licenses, software installers, documents, etc. Anything stored that needs a computer to get it and/or read it."</para>
    /// labels<para>"DigitalAsset"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/DigitalAsset">http://open.vocab.org/terms/DigitalAsset</seealso>
    let DigitalAsset = Prefixed_Name(open_, "DigitalAsset") |> PrefixedName

    /// <summary>
    ///   <para>open:DigitalAsset.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/DigitalAsset.html">http://open.vocab.org/terms/DigitalAsset.html</seealso>
    let ``DigitalAsset.html`` =
        Prefixed_Name(open_, "DigitalAsset.html") |> PrefixedName

    /// <summary>
    ///   <para>open:Distance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Distance should have two distance points and a distance value. eg:
    ///
    /// &lt;distances/a/b&gt;
    ///     a ov:Distance ;
    ///     ov:distancePoint &lt;a&gt; , &lt;b&gt; ;
    ///     ov:kilometres 0.5 ;
    /// ."</para>
    /// labels<para>"Distance"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/Distance">http://open.vocab.org/terms/Distance</seealso>
    let Distance = Prefixed_Name(open_, "Distance") |> PrefixedName
    /// <summary>
    ///   <para>open:EarWorm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"class is now deprecated in favour of Earworm class."</para>
    /// labels<para>"EarWorm"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/EarWorm">http://open.vocab.org/terms/EarWorm</seealso>
    let EarWorm = Prefixed_Name(open_, "EarWorm") |> PrefixedName
    /// <summary>
    ///   <para>open:EarWorm.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/EarWorm.html">http://open.vocab.org/terms/EarWorm.html</seealso>
    let ``EarWorm.html`` = Prefixed_Name(open_, "EarWorm.html") |> PrefixedName
    /// <summary>
    ///   <para>open:Earworm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The experience of having a song in your head which you can't get rid of."</para>
    /// labels<para>"Earworm"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/Earworm">http://open.vocab.org/terms/Earworm</seealso>
    let Earworm = Prefixed_Name(open_, "Earworm") |> PrefixedName
    /// <summary>
    ///   <para>open:Earworm.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/Earworm.html">http://open.vocab.org/terms/Earworm.html</seealso>
    let ``Earworm.html`` = Prefixed_Name(open_, "Earworm.html") |> PrefixedName
    /// <summary>
    ///   <para>open:Film</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of all motion pictures"</para>
    /// labels<para>"Film"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/Film">http://open.vocab.org/terms/Film</seealso>
    let Film = Prefixed_Name(open_, "Film") |> PrefixedName
    /// <summary>
    ///   <para>open:Film.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/Film.html">http://open.vocab.org/terms/Film.html</seealso>
    let ``Film.html`` = Prefixed_Name(open_, "Film.html") |> PrefixedName
    /// <summary>
    ///   <para>open:Formula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A formula or graph literal, in the sense used by Notation 3.
    ///
    /// This is intended to be used as a datatype. e.g.
    ///
    ///   &lt;#bob&gt; ex:believes "&lt;#alice&gt; a &lt;http://xmlns.com/foaf/0.1/Person&gt; ."^^ov:Formula .
    ///
    /// Note that the wrapping "{"..."}" are omitted from the value."</para>
    /// labels<para>"Formula"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/Formula">http://open.vocab.org/terms/Formula</seealso>
    let Formula = Prefixed_Name(open_, "Formula") |> PrefixedName
    /// <summary>
    ///   <para>open:HUDCourseLoan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Course Loan History"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/HUDCourseLoan">http://open.vocab.org/terms/HUDCourseLoan</seealso>
    let HUDCourseLoan = Prefixed_Name(open_, "HUDCourseLoan") |> PrefixedName

    /// <summary>
    ///   <para>open:HUDCourseLoan.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/HUDCourseLoan.html">http://open.vocab.org/terms/HUDCourseLoan.html</seealso>
    let ``HUDCourseLoan.html`` =
        Prefixed_Name(open_, "HUDCourseLoan.html") |> PrefixedName

    /// <summary>
    ///   <para>open:HUDSchoolLoan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The loan history of a book within a school"</para>
    /// labels<para>"School Loan History"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/HUDSchoolLoan">http://open.vocab.org/terms/HUDSchoolLoan</seealso>
    let HUDSchoolLoan = Prefixed_Name(open_, "HUDSchoolLoan") |> PrefixedName

    /// <summary>
    ///   <para>open:HUDSchoolLoan.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/HUDSchoolLoan.html">http://open.vocab.org/terms/HUDSchoolLoan.html</seealso>
    let ``HUDSchoolLoan.html`` =
        Prefixed_Name(open_, "HUDSchoolLoan.html") |> PrefixedName

    /// <summary>
    ///   <para>open:HUDSuggestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Suggested book based on circulation data"</para>
    /// labels<para>"Suggestion"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/HUDSuggestion">http://open.vocab.org/terms/HUDSuggestion</seealso>
    let HUDSuggestion = Prefixed_Name(open_, "HUDSuggestion") |> PrefixedName

    /// <summary>
    ///   <para>open:HUDSuggestion.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/HUDSuggestion.html">http://open.vocab.org/terms/HUDSuggestion.html</seealso>
    let ``HUDSuggestion.html`` =
        Prefixed_Name(open_, "HUDSuggestion.html") |> PrefixedName

    /// <summary>
    ///   <para>open:HUDYearLoan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The loan history for a book by year."</para>
    /// labels<para>"Year Loan History"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/HUDYearLoan">http://open.vocab.org/terms/HUDYearLoan</seealso>
    let HUDYearLoan = Prefixed_Name(open_, "HUDYearLoan") |> PrefixedName
    /// <summary>
    ///   <para>open:HUDYearLoan.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/HUDYearLoan.html">http://open.vocab.org/terms/HUDYearLoan.html</seealso>
    let ``HUDYearLoan.html`` = Prefixed_Name(open_, "HUDYearLoan.html") |> PrefixedName
    /// <summary>
    ///   <para>open:House</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Structure in which someone lives"</para>
    /// labels<para>"House"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/House">http://open.vocab.org/terms/House</seealso>
    let House = Prefixed_Name(open_, "House") |> PrefixedName
    /// <summary>
    ///   <para>open:House.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/House.html">http://open.vocab.org/terms/House.html</seealso>
    let ``House.html`` = Prefixed_Name(open_, "House.html") |> PrefixedName
    /// <summary>
    ///   <para>open:ITUREgion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The ITU defines a set of world-wide regions which uniquely describe locations for radio operation (in particular, amateur radio operation).  These regions are widely-used by amateur radio operators to report operation and radio contacts.  Each region has a unique abbreviation."</para>
    /// labels<para>"ITU Region for governance of radio operation"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/ITUREgion">http://open.vocab.org/terms/ITUREgion</seealso>
    let ITUREgion = Prefixed_Name(open_, "ITUREgion") |> PrefixedName

    /// <summary>
    ///   <para>open:IllegalRDFXMLStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A statement that would be illegal to express in a non-reified form in RDF/XML - usually because the predicate cannot be converted to a QName."</para>
    /// labels<para>"Illegal RDF/XML Statement"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/IllegalRDFXMLStatement">http://open.vocab.org/terms/IllegalRDFXMLStatement</seealso>
    let IllegalRDFXMLStatement =
        Prefixed_Name(open_, "IllegalRDFXMLStatement") |> PrefixedName

    /// <summary>
    ///   <para>open:IllegalRDFXMLStatement.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/IllegalRDFXMLStatement.html">http://open.vocab.org/terms/IllegalRDFXMLStatement.html</seealso>
    let ``IllegalRDFXMLStatement.html`` =
        Prefixed_Name(open_, "IllegalRDFXMLStatement.html") |> PrefixedName

    /// <summary>
    ///   <para>open:IrcBot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An irc chat bot"</para>
    /// labels<para>"IrcBot"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/IrcBot">http://open.vocab.org/terms/IrcBot</seealso>
    let IrcBot = Prefixed_Name(open_, "IrcBot") |> PrefixedName
    /// <summary>
    ///   <para>open:IrcBot.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/IrcBot.html">http://open.vocab.org/terms/IrcBot.html</seealso>
    let ``IrcBot.html`` = Prefixed_Name(open_, "IrcBot.html") |> PrefixedName
    /// <summary>
    ///   <para>open:JavascriptThis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"the concept of "this" in a javascript object. In other words a mean in which to refer to "self""</para>
    /// labels<para>"JavascriptThis"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/JavascriptThis">http://open.vocab.org/terms/JavascriptThis</seealso>
    let JavascriptThis = Prefixed_Name(open_, "JavascriptThis") |> PrefixedName

    /// <summary>
    ///   <para>open:JavascriptThis.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/JavascriptThis.html">http://open.vocab.org/terms/JavascriptThis.html</seealso>
    let ``JavascriptThis.html`` =
        Prefixed_Name(open_, "JavascriptThis.html") |> PrefixedName

    /// <summary>
    ///   <para>open:KillerGorilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gorilla that kills or has the inclination to do so."</para>
    /// labels<para>"Killer Gorilla"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/KillerGorilla">http://open.vocab.org/terms/KillerGorilla</seealso>
    let KillerGorilla = Prefixed_Name(open_, "KillerGorilla") |> PrefixedName

    /// <summary>
    ///   <para>open:KillerGorilla.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/KillerGorilla.html">http://open.vocab.org/terms/KillerGorilla.html</seealso>
    let ``KillerGorilla.html`` =
        Prefixed_Name(open_, "KillerGorilla.html") |> PrefixedName

    /// <summary>
    ///   <para>open:Loaner</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/Loaner">http://open.vocab.org/terms/Loaner</seealso>
    let Loaner = Prefixed_Name(open_, "Loaner") |> PrefixedName
    /// <summary>
    ///   <para>open:MOTTestingStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of all MOT Testing Stations."</para>
    /// labels<para>"MOT Testing Station"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/MOTTestingStation">http://open.vocab.org/terms/MOTTestingStation</seealso>
    let MOTTestingStation = Prefixed_Name(open_, "MOTTestingStation") |> PrefixedName
    /// <summary>
    ///   <para>open:Madre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Madre"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/Madre">http://open.vocab.org/terms/Madre</seealso>
    let Madre = Prefixed_Name(open_, "Madre") |> PrefixedName
    /// <summary>
    ///   <para>open:Madre.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/Madre.html">http://open.vocab.org/terms/Madre.html</seealso>
    let ``Madre.html`` = Prefixed_Name(open_, "Madre.html") |> PrefixedName
    /// <summary>
    ///   <para>open:Manifest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A manifest is a listing of files or URIs or resources of some sort encoded in some way"</para>
    /// labels<para>"Manifest"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/Manifest">http://open.vocab.org/terms/Manifest</seealso>
    let Manifest = Prefixed_Name(open_, "Manifest") |> PrefixedName
    /// <summary>
    ///   <para>open:MicroblogPost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A post on a microblogging service like Twitter, identi.ca, Jaiku or FriendFeed. Usually untitled and with a limited number of characters, and sometimes containing in-line text-based syntactical elements like at-replies, hashtags, group 'bangtags' etc."</para>
    /// labels<para>"MicroblogPost"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/MicroblogPost">http://open.vocab.org/terms/MicroblogPost</seealso>
    let MicroblogPost = Prefixed_Name(open_, "MicroblogPost") |> PrefixedName

    /// <summary>
    ///   <para>open:MicroblogPost.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/MicroblogPost.html">http://open.vocab.org/terms/MicroblogPost.html</seealso>
    let ``MicroblogPost.html`` =
        Prefixed_Name(open_, "MicroblogPost.html") |> PrefixedName

    /// <summary>
    ///   <para>open:MultiSportEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"MultiSportEvent"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/MultiSportEvent">http://open.vocab.org/terms/MultiSportEvent</seealso>
    let MultiSportEvent = Prefixed_Name(open_, "MultiSportEvent") |> PrefixedName

    /// <summary>
    ///   <para>open:MultiSportEvent.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/MultiSportEvent.html">http://open.vocab.org/terms/MultiSportEvent.html</seealso>
    let ``MultiSportEvent.html`` =
        Prefixed_Name(open_, "MultiSportEvent.html") |> PrefixedName

    /// <summary>
    ///   <para>open:NewsItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A piece of News"</para>
    /// labels<para>"News item"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/NewsItem">http://open.vocab.org/terms/NewsItem</seealso>
    let NewsItem = Prefixed_Name(open_, "NewsItem") |> PrefixedName
    /// <summary>
    ///   <para>open:NotAKillerGorilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates that something is definitely not a Killer-Gorilla. (It may still be a killer though. Or a gorilla.)"</para>
    /// labels<para>"Non Killer-Gorilla"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/NotAKillerGorilla">http://open.vocab.org/terms/NotAKillerGorilla</seealso>
    let NotAKillerGorilla = Prefixed_Name(open_, "NotAKillerGorilla") |> PrefixedName

    /// <summary>
    ///   <para>open:NotAKillerGorilla.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/NotAKillerGorilla.html">http://open.vocab.org/terms/NotAKillerGorilla.html</seealso>
    let ``NotAKillerGorilla.html`` =
        Prefixed_Name(open_, "NotAKillerGorilla.html") |> PrefixedName

    /// <summary>
    ///   <para>open:Numismatics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Numismatics is  the study of coins, medals and other related items."</para>
    /// labels<para>"Numismatics"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/Numismatics">http://open.vocab.org/terms/Numismatics</seealso>
    let Numismatics = Prefixed_Name(open_, "Numismatics") |> PrefixedName
    /// <summary>
    ///   <para>open:Numismatics.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/Numismatics.html">http://open.vocab.org/terms/Numismatics.html</seealso>
    let ``Numismatics.html`` = Prefixed_Name(open_, "Numismatics.html") |> PrefixedName
    /// <summary>
    ///   <para>open:OkkamEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any entity that can be identified using the OKKAM entity naming system. In general one could say this is equivalent to resource but there are certain entity types that will work better on the OKKAM system"</para>
    /// labels<para>"Okkam Entity"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/OkkamEntity">http://open.vocab.org/terms/OkkamEntity</seealso>
    let OkkamEntity = Prefixed_Name(open_, "OkkamEntity") |> PrefixedName
    /// <summary>
    ///   <para>open:OkkamEntity.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/OkkamEntity.html">http://open.vocab.org/terms/OkkamEntity.html</seealso>
    let ``OkkamEntity.html`` = Prefixed_Name(open_, "OkkamEntity.html") |> PrefixedName
    /// <summary>
    ///   <para>open:OlympicGames</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Olympic Games are an international multi-sport event established for both summer and winter sports."</para>
    /// labels<para>"Olympic games"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/OlympicGames">http://open.vocab.org/terms/OlympicGames</seealso>
    let OlympicGames = Prefixed_Name(open_, "OlympicGames") |> PrefixedName

    /// <summary>
    ///   <para>open:OlympicGames.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/OlympicGames.html">http://open.vocab.org/terms/OlympicGames.html</seealso>
    let ``OlympicGames.html`` =
        Prefixed_Name(open_, "OlympicGames.html") |> PrefixedName

    /// <summary>
    ///   <para>open:Plot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Plot of anything."</para>
    /// labels<para>"Plot"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/Plot">http://open.vocab.org/terms/Plot</seealso>
    let Plot = Prefixed_Name(open_, "Plot") |> PrefixedName
    /// <summary>
    ///   <para>open:Plot.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/Plot.html">http://open.vocab.org/terms/Plot.html</seealso>
    let ``Plot.html`` = Prefixed_Name(open_, "Plot.html") |> PrefixedName

    /// <summary>
    ///   <para>open:PrimaryVisualElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Primary Visual Element"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/PrimaryVisualElement">http://open.vocab.org/terms/PrimaryVisualElement</seealso>
    let PrimaryVisualElement =
        Prefixed_Name(open_, "PrimaryVisualElement") |> PrefixedName

    /// <summary>
    ///   <para>open:PrimaryVisualElement.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/PrimaryVisualElement.html">http://open.vocab.org/terms/PrimaryVisualElement.html</seealso>
    let ``PrimaryVisualElement.html`` =
        Prefixed_Name(open_, "PrimaryVisualElement.html") |> PrefixedName

    /// <summary>
    ///   <para>open:RTFMImperative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"RTFMImperative is an instruction for foaf:Agent(s) to read a given document."</para>
    /// labels<para>"instruction to RTFM"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/RTFMImperative">http://open.vocab.org/terms/RTFMImperative</seealso>
    let RTFMImperative = Prefixed_Name(open_, "RTFMImperative") |> PrefixedName

    /// <summary>
    ///   <para>open:RTFMImperative.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/RTFMImperative.html">http://open.vocab.org/terms/RTFMImperative.html</seealso>
    let ``RTFMImperative.html`` =
        Prefixed_Name(open_, "RTFMImperative.html") |> PrefixedName

    /// <summary>
    ///   <para>open:RadioOperationFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"When a radio transmits a signal, a range of frequencies is used to carry information.  This range may be continuous or dis-contiguous ("spread spectrum").  There is usually a single frequency that is used to "name" the tranmission frequency, although this naming depends on the mode used.  (See RadioOperationMode).  The standard method of expression is "Herz" (or a multiple).  Sometimes, surprisingly, the "frequency" is expressed in terms of length (actually wavelength, often in meters).  This is merely an colloquial and equivalent expresssion, since freq(Herz) = the-speed-of-light / wavelength."</para>
    /// labels<para>"Frequency of operation of a radio."</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/RadioOperationFrequency">http://open.vocab.org/terms/RadioOperationFrequency</seealso>
    let RadioOperationFrequency =
        Prefixed_Name(open_, "RadioOperationFrequency") |> PrefixedName

    /// <summary>
    ///   <para>open:SchemaExample</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/SchemaExample">http://open.vocab.org/terms/SchemaExample</seealso>
    let SchemaExample = Prefixed_Name(open_, "SchemaExample") |> PrefixedName
    /// <summary>
    ///   <para>open:ScientificDatabase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Scientific Database"</para>
    /// labels<para>"Scientific Database"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/ScientificDatabase">http://open.vocab.org/terms/ScientificDatabase</seealso>
    let ScientificDatabase = Prefixed_Name(open_, "ScientificDatabase") |> PrefixedName

    /// <summary>
    ///   <para>open:ScientificDatabase.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/ScientificDatabase.html">http://open.vocab.org/terms/ScientificDatabase.html</seealso>
    let ``ScientificDatabase.html`` =
        Prefixed_Name(open_, "ScientificDatabase.html") |> PrefixedName

    /// <summary>
    ///   <para>open:SportEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"e.g. : 100m in Beijing 2008"</para>
    /// labels<para>"Sport Event "</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/SportEvent">http://open.vocab.org/terms/SportEvent</seealso>
    let SportEvent = Prefixed_Name(open_, "SportEvent") |> PrefixedName
    /// <summary>
    ///   <para>open:SportEvent.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/SportEvent.html">http://open.vocab.org/terms/SportEvent.html</seealso>
    let ``SportEvent.html`` = Prefixed_Name(open_, "SportEvent.html") |> PrefixedName

    /// <summary>
    ///   <para>open:StillAKillerGorilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates that the subject is a non-deceased killer gorilla."</para>
    /// labels<para>"Living Killer Gorilla"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/StillAKillerGorilla">http://open.vocab.org/terms/StillAKillerGorilla</seealso>
    let StillAKillerGorilla =
        Prefixed_Name(open_, "StillAKillerGorilla") |> PrefixedName

    /// <summary>
    ///   <para>open:StillAKillerGorilla.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/StillAKillerGorilla.html">http://open.vocab.org/terms/StillAKillerGorilla.html</seealso>
    let ``StillAKillerGorilla.html`` =
        Prefixed_Name(open_, "StillAKillerGorilla.html") |> PrefixedName

    /// <summary>
    ///   <para>open:SummerOlympicGames</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Summer Olympic Games"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/SummerOlympicGames">http://open.vocab.org/terms/SummerOlympicGames</seealso>
    let SummerOlympicGames = Prefixed_Name(open_, "SummerOlympicGames") |> PrefixedName

    /// <summary>
    ///   <para>open:SummerOlympicGames.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/SummerOlympicGames.html">http://open.vocab.org/terms/SummerOlympicGames.html</seealso>
    let ``SummerOlympicGames.html`` =
        Prefixed_Name(open_, "SummerOlympicGames.html") |> PrefixedName

    /// <summary>
    ///   <para>open:Test</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/Test">http://open.vocab.org/terms/Test</seealso>
    let Test = Prefixed_Name(open_, "Test") |> PrefixedName
    /// <summary>
    ///   <para>open:TrimPackage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Trim Package represents a standard configuration of options for an automobile.  Usually, a Car Model will be available as several Trim Packages."</para>
    /// labels<para>"Trim Package"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/TrimPackage">http://open.vocab.org/terms/TrimPackage</seealso>
    let TrimPackage = Prefixed_Name(open_, "TrimPackage") |> PrefixedName
    /// <summary>
    ///   <para>open:TrimPackage.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/TrimPackage.html">http://open.vocab.org/terms/TrimPackage.html</seealso>
    let ``TrimPackage.html`` = Prefixed_Name(open_, "TrimPackage.html") |> PrefixedName
    /// <summary>
    ///   <para>open:UnivCourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A course taught at a university"</para>
    /// labels<para>"University Course"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/UnivCourse">http://open.vocab.org/terms/UnivCourse</seealso>
    let UnivCourse = Prefixed_Name(open_, "UnivCourse") |> PrefixedName
    /// <summary>
    ///   <para>open:UnivCourse.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/UnivCourse.html">http://open.vocab.org/terms/UnivCourse.html</seealso>
    let ``UnivCourse.html`` = Prefixed_Name(open_, "UnivCourse.html") |> PrefixedName
    /// <summary>
    ///   <para>open:UnivSchool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A school of a university (e.g., School of Business)."</para>
    /// labels<para>"University School"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/UnivSchool">http://open.vocab.org/terms/UnivSchool</seealso>
    let UnivSchool = Prefixed_Name(open_, "UnivSchool") |> PrefixedName
    /// <summary>
    ///   <para>open:UnivSchool.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/UnivSchool.html">http://open.vocab.org/terms/UnivSchool.html</seealso>
    let ``UnivSchool.html`` = Prefixed_Name(open_, "UnivSchool.html") |> PrefixedName
    /// <summary>
    ///   <para>open:UuOjngyFVCE</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/UuOjngyFVCE">http://open.vocab.org/terms/UuOjngyFVCE</seealso>
    let UuOjngyFVCE = Prefixed_Name(open_, "UuOjngyFVCE") |> PrefixedName
    /// <summary>
    ///   <para>open:VisualElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A thing that manifests visually."</para>
    /// labels<para>"Visual Element"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/VisualElement">http://open.vocab.org/terms/VisualElement</seealso>
    let VisualElement = Prefixed_Name(open_, "VisualElement") |> PrefixedName

    /// <summary>
    ///   <para>open:VisualElement.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/VisualElement.html">http://open.vocab.org/terms/VisualElement.html</seealso>
    let ``VisualElement.html`` =
        Prefixed_Name(open_, "VisualElement.html") |> PrefixedName

    /// <summary>
    ///   <para>open:Vocabulary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A set of terms or names, each one having an assigned meaning."</para>
    /// labels<para>"Vocabulary"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/Vocabulary">http://open.vocab.org/terms/Vocabulary</seealso>
    let Vocabulary = Prefixed_Name(open_, "Vocabulary") |> PrefixedName
    /// <summary>
    ///   <para>open:Vocabulary.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/Vocabulary.html">http://open.vocab.org/terms/Vocabulary.html</seealso>
    let ``Vocabulary.html`` = Prefixed_Name(open_, "Vocabulary.html") |> PrefixedName
    /// <summary>
    ///   <para>open:Ware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Generic term for category of ceramics that may be distinguished by function, surface treatment, distinguishing features of clay, or other set of criteria as defined by usage. Commonly used in the discipline of Archaeology."</para>
    /// labels<para>"Ware"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/Ware">http://open.vocab.org/terms/Ware</seealso>
    let Ware = Prefixed_Name(open_, "Ware") |> PrefixedName
    /// <summary>
    ///   <para>open:Ware.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/Ware.html">http://open.vocab.org/terms/Ware.html</seealso>
    let ``Ware.html`` = Prefixed_Name(open_, "Ware.html") |> PrefixedName
    /// <summary>
    ///   <para>open:WheelChairEnabled</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A place that is accessible with a wheel chair."</para>
    /// labels<para>"wheel chair enabled"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/WheelChairEnabled">http://open.vocab.org/terms/WheelChairEnabled</seealso>
    let WheelChairEnabled = Prefixed_Name(open_, "WheelChairEnabled") |> PrefixedName
    /// <summary>
    ///   <para>open:WinterOlympicGames</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Winter Olympic Games"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/WinterOlympicGames">http://open.vocab.org/terms/WinterOlympicGames</seealso>
    let WinterOlympicGames = Prefixed_Name(open_, "WinterOlympicGames") |> PrefixedName

    /// <summary>
    ///   <para>open:WinterOlympicGames.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/WinterOlympicGames.html">http://open.vocab.org/terms/WinterOlympicGames.html</seealso>
    let ``WinterOlympicGames.html`` =
        Prefixed_Name(open_, "WinterOlympicGames.html") |> PrefixedName

    /// <summary>
    ///   <para>open:Yoli</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/Yoli">http://open.vocab.org/terms/Yoli</seealso>
    let Yoli = Prefixed_Name(open_, "Yoli") |> PrefixedName
    /// <summary>
    ///   <para>open:ZoiaCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A command issued to the code4lib IRC chat bot, zoia."</para>
    /// labels<para>"ZoiaCommand"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/ZoiaCommand">http://open.vocab.org/terms/ZoiaCommand</seealso>
    let ZoiaCommand = Prefixed_Name(open_, "ZoiaCommand") |> PrefixedName
    /// <summary>
    ///   <para>open:ZoiaCommand.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/ZoiaCommand.html">http://open.vocab.org/terms/ZoiaCommand.html</seealso>
    let ``ZoiaCommand.html`` = Prefixed_Name(open_, "ZoiaCommand.html") |> PrefixedName
    /// <summary>
    ///   <para>open:accountIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"foaf:OnlineAccount's can have an accountName, but plenty of services use an account identifier internally that is not the same as the public account name: for instance, Twitter uses a nickname and a user_id property. Facebook now assigns usernames as well as internal identification numbers. Google's various services assign a unique identifier so that people are not revealing their e-mail address or username. This property is for these kind of identifiers."</para>
    /// labels<para>"Account Identifier"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/accountIdentifier">http://open.vocab.org/terms/accountIdentifier</seealso>
    let accountIdentifier = Prefixed_Name(open_, "accountIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>open:admWIUQRlVUqNMadZQ</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/admWIUQRlVUqNMadZQ">http://open.vocab.org/terms/admWIUQRlVUqNMadZQ</seealso>
    let admWIUQRlVUqNMadZQ = Prefixed_Name(open_, "admWIUQRlVUqNMadZQ") |> PrefixedName
    /// <summary>
    ///   <para>open:aeNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The Authorised Examiner Number of an MOT Testing Station."</para>
    /// labels<para>"AE Number"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/aeNumber">http://open.vocab.org/terms/aeNumber</seealso>
    let aeNumber = Prefixed_Name(open_, "aeNumber") |> PrefixedName
    /// <summary>
    ///   <para>open:affiliation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Used to describe the affiliation, place of work or association of a foaf:Person when the source data is too ambiguous to model into its own resource."</para>
    /// labels<para>"Personal or Professional Affiliation"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/affiliation">http://open.vocab.org/terms/affiliation</seealso>
    let affiliation = Prefixed_Name(open_, "affiliation") |> PrefixedName
    /// <summary>
    ///   <para>open:affiliation.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/affiliation.html">http://open.vocab.org/terms/affiliation.html</seealso>
    let ``affiliation.html`` = Prefixed_Name(open_, "affiliation.html") |> PrefixedName
    /// <summary>
    ///   <para>open:aggregates</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An agent syndicates a document some way."</para>
    /// labels<para>"syndicates"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/aggregates">http://open.vocab.org/terms/aggregates</seealso>
    let aggregates = Prefixed_Name(open_, "aggregates") |> PrefixedName
    /// <summary>
    ///   <para>open:anniversary</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The anniversary of some event"</para>
    /// labels<para>"Anniversary"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/anniversary">http://open.vocab.org/terms/anniversary</seealso>
    let anniversary = Prefixed_Name(open_, "anniversary") |> PrefixedName
    /// <summary>
    ///   <para>open:areaHectares</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The area of some physical thing in hectares."</para>
    /// labels<para>"Area in Hectares"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/areaHectares">http://open.vocab.org/terms/areaHectares</seealso>
    let areaHectares = Prefixed_Name(open_, "areaHectares") |> PrefixedName
    /// <summary>
    ///   <para>open:associatedEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"This property is used to relate two FRBR Endeavours/entities (http://vocab.org/frbr/core.html#Endeavour) together even if the entire Work-Expression-Manifestation-Item hierarchy does not exist.  For example, it could be used to relate a frbr:Work to a frbr:Manifestation without the need of a frbr:Expression to link them through.  The property is symmetric (if a &lt;_:work&gt; ov:associatedEntity &lt;_:item&gt; then &lt;_:item&gt; ov:associatedEntity &lt;_:work&gt;.  It is not transitive (items may be associated with the same work but not be in the same WEMI chain, for example)."</para>
    /// labels<para>"Associated Entity"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/associatedEntity">http://open.vocab.org/terms/associatedEntity</seealso>
    let associatedEntity = Prefixed_Name(open_, "associatedEntity") |> PrefixedName
    /// <summary>
    ///   <para>open:attestsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A thing that provides evidence for the existence or historicity of another thing attests to that other thing."</para>
    /// labels<para>"Providing evidence for existence or historicity"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/attestsTo">http://open.vocab.org/terms/attestsTo</seealso>
    let attestsTo = Prefixed_Name(open_, "attestsTo") |> PrefixedName
    /// <summary>
    ///   <para>open:attestsTo.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/attestsTo.html">http://open.vocab.org/terms/attestsTo.html</seealso>
    let ``attestsTo.html`` = Prefixed_Name(open_, "attestsTo.html") |> PrefixedName
    /// <summary>
    ///   <para>open:authorString</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The literal, human readable author string of a Document."</para>
    /// labels<para>"Author string"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/authorString">http://open.vocab.org/terms/authorString</seealso>
    let authorString = Prefixed_Name(open_, "authorString") |> PrefixedName

    /// <summary>
    ///   <para>open:authorString.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/authorString.html">http://open.vocab.org/terms/authorString.html</seealso>
    let ``authorString.html`` =
        Prefixed_Name(open_, "authorString.html") |> PrefixedName

    /// <summary>
    ///   <para>open:avatarBendingElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"One or more of the four elements viz. Air, Water, Fire and Earth that can be bent."</para>
    /// labels<para>"The Element an Individual Can Bend"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/avatarBendingElement">http://open.vocab.org/terms/avatarBendingElement</seealso>
    let avatarBendingElement =
        Prefixed_Name(open_, "avatarBendingElement") |> PrefixedName

    /// <summary>
    ///   <para>open:avatarEyeColor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Describes the eye color of an individual"</para>
    /// labels<para>"Color of Eyes of an Individual"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/avatarEyeColor">http://open.vocab.org/terms/avatarEyeColor</seealso>
    let avatarEyeColor = Prefixed_Name(open_, "avatarEyeColor") |> PrefixedName

    /// <summary>
    ///   <para>open:avatarFirstAppearance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Describes when the character was introduced in the series."</para>
    /// labels<para>"First Appearance of Character"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/avatarFirstAppearance">http://open.vocab.org/terms/avatarFirstAppearance</seealso>
    let avatarFirstAppearance =
        Prefixed_Name(open_, "avatarFirstAppearance") |> PrefixedName

    /// <summary>
    ///   <para>open:avatarHairColor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Defines the hair color (or no hair at all!) of an individual"</para>
    /// labels<para>"Color of Hair of an Individual"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/avatarHairColor">http://open.vocab.org/terms/avatarHairColor</seealso>
    let avatarHairColor = Prefixed_Name(open_, "avatarHairColor") |> PrefixedName
    /// <summary>
    ///   <para>open:avatarNationality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The nationality of a character in Avatar. It can be one of Air, Fire, Water and Earth."</para>
    /// labels<para>"Nationality of a Character in Graphic Novel Avatar"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/avatarNationality">http://open.vocab.org/terms/avatarNationality</seealso>
    let avatarNationality = Prefixed_Name(open_, "avatarNationality") |> PrefixedName
    /// <summary>
    ///   <para>open:avatarPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Determines if the character is protagonist, antagonist, supporting character etc."</para>
    /// labels<para>"Position of the Character in Graphic Novel Avatar"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/avatarPosition">http://open.vocab.org/terms/avatarPosition</seealso>
    let avatarPosition = Prefixed_Name(open_, "avatarPosition") |> PrefixedName
    /// <summary>
    ///   <para>open:bbcWeatherId</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The BBC provides IDs for places. This can be used to link BBC weather IDs to places."</para>
    /// labels<para>"BBC Weather ID"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/bbcWeatherId">http://open.vocab.org/terms/bbcWeatherId</seealso>
    let bbcWeatherId = Prefixed_Name(open_, "bbcWeatherId") |> PrefixedName
    /// <summary>
    ///   <para>open:beam-componentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Following an EAD description, collections consist of one or more "components". Components act much like files and folders - a component may contain others (folder) or it may be a leaf node (file) - EAD is vague enough not to make this distinction, but provides a "level" attribute instead. This property is used by a component to show that if is a "componentOf" either another component or a collection or both."</para>
    /// labels<para>"ComponentOf"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/beam-componentOf">http://open.vocab.org/terms/beam-componentOf</seealso>
    let beam_componentOf = Prefixed_Name(open_, "beam-componentOf") |> PrefixedName

    /// <summary>
    ///   <para>open:beam-componentOf.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/beam-componentOf.html">http://open.vocab.org/terms/beam-componentOf.html</seealso>
    let ``beam_componentOf.html`` =
        Prefixed_Name(open_, "beam-componentOf.html") |> PrefixedName

    /// <summary>
    ///   <para>open:blid</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A sub-classing of bibo:identifier to narrow the range to be the numeric part of a BL identifier. For example:
    ///
    /// '(Uk)33994949'  ---&gt;  '&lt;foo&gt; &lt;ov:blid&gt; "33994949"'"</para>
    /// labels<para>"British Library identifier"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/blid">http://open.vocab.org/terms/blid</seealso>
    let blid = Prefixed_Name(open_, "blid") |> PrefixedName
    /// <summary>
    ///   <para>open:bsRGyjqyy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/bsRGyjqyy">http://open.vocab.org/terms/bsRGyjqyy</seealso>
    let bsRGyjqyy = Prefixed_Name(open_, "bsRGyjqyy") |> PrefixedName
    /// <summary>
    ///   <para>open:bthPpNLjjQHuCC</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/bthPpNLjjQHuCC">http://open.vocab.org/terms/bthPpNLjjQHuCC</seealso>
    let bthPpNLjjQHuCC = Prefixed_Name(open_, "bthPpNLjjQHuCC") |> PrefixedName
    /// <summary>
    ///   <para>open:building</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/building">http://open.vocab.org/terms/building</seealso>
    let building = Prefixed_Name(open_, "building") |> PrefixedName
    /// <summary>
    ///   <para>open:businessCard</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A business card associated with this resource."</para>
    /// labels<para>"Business Card"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/businessCard">http://open.vocab.org/terms/businessCard</seealso>
    let businessCard = Prefixed_Name(open_, "businessCard") |> PrefixedName
    /// <summary>
    ///   <para>open:businessInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Business Interest"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/businessInterest">http://open.vocab.org/terms/businessInterest</seealso>
    let businessInterest = Prefixed_Name(open_, "businessInterest") |> PrefixedName

    /// <summary>
    ///   <para>open:businessInterest.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/businessInterest.html">http://open.vocab.org/terms/businessInterest.html</seealso>
    let ``businessInterest.html`` =
        Prefixed_Name(open_, "businessInterest.html") |> PrefixedName

    /// <summary>
    ///   <para>open:calendar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A calendar associated with this resource."</para>
    /// labels<para>"Calendar"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/calendar">http://open.vocab.org/terms/calendar</seealso>
    let calendar = Prefixed_Name(open_, "calendar") |> PrefixedName

    /// <summary>
    ///   <para>open:canonicalInformationResource</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/canonicalInformationResource">http://open.vocab.org/terms/canonicalInformationResource</seealso>
    let canonicalInformationResource =
        Prefixed_Name(open_, "canonicalInformationResource") |> PrefixedName

    /// <summary>
    ///   <para>open:canonicalUri</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>"Denotes the canonical URI that should be used to refer to this resource."</para>
    /// labels<para>"Canonical URI"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/canonicalUri">http://open.vocab.org/terms/canonicalUri</seealso>
    let canonicalUri = Prefixed_Name(open_, "canonicalUri") |> PrefixedName

    /// <summary>
    ///   <para>open:canonicalUri.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/canonicalUri.html">http://open.vocab.org/terms/canonicalUri.html</seealso>
    let ``canonicalUri.html`` =
        Prefixed_Name(open_, "canonicalUri.html") |> PrefixedName

    /// <summary>
    ///   <para>open:category</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A category that the resource has been classified under"</para>
    /// labels<para>"category"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/category">http://open.vocab.org/terms/category</seealso>
    let category = Prefixed_Name(open_, "category") |> PrefixedName
    /// <summary>
    ///   <para>open:category.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/category.html">http://open.vocab.org/terms/category.html</seealso>
    let ``category.html`` = Prefixed_Name(open_, "category.html") |> PrefixedName
    /// <summary>
    ///   <para>open:classSkeleton</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Relates class to a class skeleton. If class has more than one of this relations, it should use them all."</para>
    /// labels<para>"Class Skeleton"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/classSkeleton">http://open.vocab.org/terms/classSkeleton</seealso>
    let classSkeleton = Prefixed_Name(open_, "classSkeleton") |> PrefixedName

    /// <summary>
    ///   <para>open:classSkeletonIgnore</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Triples using his property and its sub-properties as predicate are to be ignored by the class skeleton materialization process (http://open.vocab.org/terms/ClassSkeleton).
    ///
    /// This property is not to be used in real data, it serves just to exist and have sub-properties."</para>
    /// labels<para>"Class Skeleton Ignore"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/classSkeletonIgnore">http://open.vocab.org/terms/classSkeletonIgnore</seealso>
    let classSkeletonIgnore =
        Prefixed_Name(open_, "classSkeletonIgnore") |> PrefixedName

    /// <summary>
    ///   <para>open:colorsOfHouses</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/colorsOfHouses">http://open.vocab.org/terms/colorsOfHouses</seealso>
    let colorsOfHouses = Prefixed_Name(open_, "colorsOfHouses") |> PrefixedName
    /// <summary>
    ///   <para>open:colour</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Colour"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/colour">http://open.vocab.org/terms/colour</seealso>
    let colour = Prefixed_Name(open_, "colour") |> PrefixedName
    /// <summary>
    ///   <para>open:colour.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/colour.html">http://open.vocab.org/terms/colour.html</seealso>
    let ``colour.html`` = Prefixed_Name(open_, "colour.html") |> PrefixedName
    /// <summary>
    ///   <para>open:commonEndeavour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"commonEndeavour is intended to define a FRBR (Functional Requirements for Bibliographic Records) relationship between two resources that may or may not be modeled as FRBR.  This makes it possible to assert that a resource modeled using a vocabulary that does not use the FRBR entity model explicitly is describing the same Work, Expression, Manifestation, and/or Item as another resource (which may or may not use the FRBR model, as well).
    ///
    /// commonEndeavour is intended to be used merely as a superproperty for WEMI-specific subproperties to inherit from, but there are no restrictions on its use."</para>
    /// labels<para>"Common Endeavour"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/commonEndeavour">http://open.vocab.org/terms/commonEndeavour</seealso>
    let commonEndeavour = Prefixed_Name(open_, "commonEndeavour") |> PrefixedName
    /// <summary>
    ///   <para>open:commonExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"This property is used to declare that two resources which may or may not conform to the FRBR (Functional Requirements for Bibliographic Resources) entity model share the same Expression. An example of its use would be to relate a resource described with a vocabulary such as bibo (which does not acknowledge the FRBR model) to other resources that describe endeavours which have the same implied Expression (which could be other bibo resources or FRBR entities or anything else).
    ///
    /// The property is symmetrical, so if &lt;_:someBiboBook&gt; &lt;ov:commonExpression&gt; &lt;_:otherEdition&gt;, this also means &lt;_:otherEdition&gt; &lt;ov:commonExpression&gt; &lt;_:someBiboBook&gt;.
    ///
    /// It is not transitive.
    ///
    /// Having this property also implies ov:commonWork."</para>
    /// labels<para>"Common Expression"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/commonExpression">http://open.vocab.org/terms/commonExpression</seealso>
    let commonExpression = Prefixed_Name(open_, "commonExpression") |> PrefixedName
    /// <summary>
    ///   <para>open:commonItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"This property is used to declare that two resources which may or may not conform to the FRBR (Functional Requirements for Bibliographic Resources) entity model share the same Item. An example of its use would be to relate a resource described with a vocabulary such as bibo (which does not acknowledge the FRBR model) to other resources that describe endeavours which contains the same specific Item (which could be other bibo resources or FRBR entities or anything else). This implies identical WEMI hierarchies.
    ///
    /// The property is symmetrical, so if &lt;_:specificPhysicalItem&gt; &lt;ov:commonItem&gt; &lt;_:someArchive&gt;, this also means &lt;_:someArchive&gt; &lt;ov:commonItem&gt; &lt;_:specificPhysicalItem&gt;.
    ///
    /// It is not transitive.
    ///
    /// Having this property also entails ov:commonManifestation, ov:commonExpression and ov:commonWork."</para>
    /// labels<para>"Common Item"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/commonItem">http://open.vocab.org/terms/commonItem</seealso>
    let commonItem = Prefixed_Name(open_, "commonItem") |> PrefixedName

    /// <summary>
    ///   <para>open:commonManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"This property is used to declare that two resources which may or may not conform to the FRBR (Functional Requirements for Bibliographic Resources) entity model share the same Manifestation.  An example of its use would be to relate a resource described with a vocabulary such as bibo (which does not acknowledge the FRBR model) to other resources that describe endeavours which include the same implied Manifestation (which could be other bibo resources or FRBR entities or anything else).
    ///
    /// The property is symmetrical, so if &lt;_:someBiboBook&gt; &lt;ov:commonManifestation&gt; &lt;_:someFrbrWork&gt;, this also means &lt;_:someFrbrWork&gt; &lt;ov:commonManifestation&gt; &lt;_:someBiboBook&gt;.  It is not transitive.
    ///
    /// Having this property also implies ov:commonExpression and ov:commonWork."</para>
    /// labels<para>"Common Manifestation"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/commonManifestation">http://open.vocab.org/terms/commonManifestation</seealso>
    let commonManifestation =
        Prefixed_Name(open_, "commonManifestation") |> PrefixedName

    /// <summary>
    ///   <para>open:commonWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"This property is used to declare that two resources which may or may not conform to the FRBR (Functional Requirements for Bibliographic Resources) entity model share the same Work. An example of its use would be to relate a resource described with a vocabulary such as bibo (which does not acknowledge the FRBR model) to other resources that describe endeavours that fall within the same implied Work (which could be other bibo resources or FRBR entities or anything else).
    ///
    /// The property is symmetrical, so if &lt;_:someBiboBook&gt; &lt;ov:commonWork&gt; &lt;_:someOtherBiboBook&gt;, this also means &lt;_:someOtherBiboBook&gt; &lt;ov:commonWork&gt; &lt;_:someBiboBook&gt;.
    ///
    /// It is not transitive."</para>
    /// labels<para>"Common Work"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/commonWork">http://open.vocab.org/terms/commonWork</seealso>
    let commonWork = Prefixed_Name(open_, "commonWork") |> PrefixedName
    /// <summary>
    ///   <para>open:compassDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The Compass Direction that a Thing faces."</para>
    /// labels<para>"Compass Direction"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/compassDirection">http://open.vocab.org/terms/compassDirection</seealso>
    let compassDirection = Prefixed_Name(open_, "compassDirection") |> PrefixedName

    /// <summary>
    ///   <para>open:compassDirection.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/compassDirection.html">http://open.vocab.org/terms/compassDirection.html</seealso>
    let ``compassDirection.html`` =
        Prefixed_Name(open_, "compassDirection.html") |> PrefixedName

    /// <summary>
    ///   <para>open:composedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>":s :composedBy :o .
    /// :o is a "larger thing" that composes :s and potentially other "smaller things". :s may also establish some structural organization of the things it composes."</para>
    /// labels<para>"composed by"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/composedBy">http://open.vocab.org/terms/composedBy</seealso>
    let composedBy = Prefixed_Name(open_, "composedBy") |> PrefixedName
    /// <summary>
    ///   <para>open:composedBy.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/composedBy.html">http://open.vocab.org/terms/composedBy.html</seealso>
    let ``composedBy.html`` = Prefixed_Name(open_, "composedBy.html") |> PrefixedName
    /// <summary>
    ///   <para>open:composer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"associates a manifestation of a musical work with music artist who composed the work"</para>
    /// labels<para>"Composer"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/composer">http://open.vocab.org/terms/composer</seealso>
    let composer = Prefixed_Name(open_, "composer") |> PrefixedName
    /// <summary>
    ///   <para>open:composer.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/composer.html">http://open.vocab.org/terms/composer.html</seealso>
    let ``composer.html`` = Prefixed_Name(open_, "composer.html") |> PrefixedName
    /// <summary>
    ///   <para>open:compressedFileSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Describes the size of the file of a dataset in compressed state"</para>
    /// labels<para>"compressed dataset file has fileSize"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/compressedFileSize">http://open.vocab.org/terms/compressedFileSize</seealso>
    let compressedFileSize = Prefixed_Name(open_, "compressedFileSize") |> PrefixedName
    /// <summary>
    ///   <para>open:confidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A confidence level for a calculation or value.  Usually between 0 and 1."</para>
    /// labels<para>"ConfidenceLevel"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/confidence">http://open.vocab.org/terms/confidence</seealso>
    let confidence = Prefixed_Name(open_, "confidence") |> PrefixedName
    /// <summary>
    ///   <para>open:confidence.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/confidence.html">http://open.vocab.org/terms/confidence.html</seealso>
    let ``confidence.html`` = Prefixed_Name(open_, "confidence.html") |> PrefixedName
    /// <summary>
    ///   <para>open:country</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A country associated with this resource. This could be a country of origin or operation of an entity. For example a company may be based in a country and operate from there."</para>
    /// labels<para>"Country"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/country">http://open.vocab.org/terms/country</seealso>
    let country = Prefixed_Name(open_, "country") |> PrefixedName
    /// <summary>
    ///   <para>open:creation-tool-used</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/creation-tool-used">http://open.vocab.org/terms/creation-tool-used</seealso>
    let creation_tool_used = Prefixed_Name(open_, "creation-tool-used") |> PrefixedName
    /// <summary>
    ///   <para>open:creatorUserAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The user-agent string of the software used by the creator of an item."</para>
    /// labels<para>"Creator User Agent"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/creatorUserAgent">http://open.vocab.org/terms/creatorUserAgent</seealso>
    let creatorUserAgent = Prefixed_Name(open_, "creatorUserAgent") |> PrefixedName

    /// <summary>
    ///   <para>open:creatorUserAgent.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/creatorUserAgent.html">http://open.vocab.org/terms/creatorUserAgent.html</seealso>
    let ``creatorUserAgent.html`` =
        Prefixed_Name(open_, "creatorUserAgent.html") |> PrefixedName

    /// <summary>
    ///   <para>open:csvCol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"First column is column 1; i.e., human-based indexing."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The column of a comma separated value file from which this property was created."</para>
    /// labels<para>"csv column"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/csvCol">http://open.vocab.org/terms/csvCol</seealso>
    let csvCol = Prefixed_Name(open_, "csvCol") |> PrefixedName
    /// <summary>
    ///   <para>open:csvCol.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/csvCol.html">http://open.vocab.org/terms/csvCol.html</seealso>
    let ``csvCol.html`` = Prefixed_Name(open_, "csvCol.html") |> PrefixedName
    /// <summary>
    ///   <para>open:csvRow</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The row number of a csv from which this instance was created. This is different from the r-th entry within the table, which may be less than the csv row if the csv has title information and a header above the data."</para>
    /// labels<para>"csv row"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/csvRow">http://open.vocab.org/terms/csvRow</seealso>
    let csvRow = Prefixed_Name(open_, "csvRow") |> PrefixedName
    /// <summary>
    ///   <para>open:csvRow.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/csvRow.html">http://open.vocab.org/terms/csvRow.html</seealso>
    let ``csvRow.html`` = Prefixed_Name(open_, "csvRow.html") |> PrefixedName
    /// <summary>
    ///   <para>open:dateOfDeath</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The date someone died."</para>
    /// labels<para>"Date of Death"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/dateOfDeath">http://open.vocab.org/terms/dateOfDeath</seealso>
    let dateOfDeath = Prefixed_Name(open_, "dateOfDeath") |> PrefixedName
    /// <summary>
    ///   <para>open:dateOfDeath.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/dateOfDeath.html">http://open.vocab.org/terms/dateOfDeath.html</seealso>
    let ``dateOfDeath.html`` = Prefixed_Name(open_, "dateOfDeath.html") |> PrefixedName
    /// <summary>
    ///   <para>open:defaultProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Associates properties to a class where the properties are meant to be present in some default view - basically a very light version of fresnel ;-)"</para>
    /// labels<para>"default property"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/defaultProperty">http://open.vocab.org/terms/defaultProperty</seealso>
    let defaultProperty = Prefixed_Name(open_, "defaultProperty") |> PrefixedName

    /// <summary>
    ///   <para>open:defaultProperty.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/defaultProperty.html">http://open.vocab.org/terms/defaultProperty.html</seealso>
    let ``defaultProperty.html`` =
        Prefixed_Name(open_, "defaultProperty.html") |> PrefixedName

    /// <summary>
    ///   <para>open:defines</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The things defined by this resource - for example, the terms defined by an Ontology."</para>
    /// labels<para>"Defines"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/defines">http://open.vocab.org/terms/defines</seealso>
    let defines = Prefixed_Name(open_, "defines") |> PrefixedName
    /// <summary>
    ///   <para>open:deliveredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Teacher of the course. Should belong to the organization specified by ov:offeredBy of the course"</para>
    /// labels<para>"Course teacher"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/deliveredBy">http://open.vocab.org/terms/deliveredBy</seealso>
    let deliveredBy = Prefixed_Name(open_, "deliveredBy") |> PrefixedName
    /// <summary>
    ///   <para>open:departureDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Date and time your travel will commence"</para>
    /// labels<para>"departure date"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/departureDate">http://open.vocab.org/terms/departureDate</seealso>
    let departureDate = Prefixed_Name(open_, "departureDate") |> PrefixedName

    /// <summary>
    ///   <para>open:departureDate.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/departureDate.html">http://open.vocab.org/terms/departureDate.html</seealso>
    let ``departureDate.html`` =
        Prefixed_Name(open_, "departureDate.html") |> PrefixedName

    /// <summary>
    ///   <para>open:depicts</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"When :s :depicts :o, :s is communicable via a visual medium and, when transmitted, depicts the resource :o."</para>
    /// labels<para>"depicts"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/depicts">http://open.vocab.org/terms/depicts</seealso>
    let depicts = Prefixed_Name(open_, "depicts") |> PrefixedName
    /// <summary>
    ///   <para>open:depicts.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/depicts.html">http://open.vocab.org/terms/depicts.html</seealso>
    let ``depicts.html`` = Prefixed_Name(open_, "depicts.html") |> PrefixedName

    /// <summary>
    ///   <para>open:depictsSameResourceAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"depicts same resource as"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/depictsSameResourceAs">http://open.vocab.org/terms/depictsSameResourceAs</seealso>
    let depictsSameResourceAs =
        Prefixed_Name(open_, "depictsSameResourceAs") |> PrefixedName

    /// <summary>
    ///   <para>open:depictsSameResourceAs.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/depictsSameResourceAs.html">http://open.vocab.org/terms/depictsSameResourceAs.html</seealso>
    let ``depictsSameResourceAs.html`` =
        Prefixed_Name(open_, "depictsSameResourceAs.html") |> PrefixedName

    /// <summary>
    ///   <para>open:describes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The subject is a document that, to any extent, describes the object."</para>
    /// labels<para>"describes"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/describes">http://open.vocab.org/terms/describes</seealso>
    let describes = Prefixed_Name(open_, "describes") |> PrefixedName
    /// <summary>
    ///   <para>open:diffFromOther</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A diff that goes from another resource to this one."</para>
    /// labels<para>"diff from other"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/diffFromOther">http://open.vocab.org/terms/diffFromOther</seealso>
    let diffFromOther = Prefixed_Name(open_, "diffFromOther") |> PrefixedName

    /// <summary>
    ///   <para>open:diffFromOther.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/diffFromOther.html">http://open.vocab.org/terms/diffFromOther.html</seealso>
    let ``diffFromOther.html`` =
        Prefixed_Name(open_, "diffFromOther.html") |> PrefixedName

    /// <summary>
    ///   <para>open:diffSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The resource that this diff goes from."</para>
    /// labels<para>"source"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/diffSource">http://open.vocab.org/terms/diffSource</seealso>
    let diffSource = Prefixed_Name(open_, "diffSource") |> PrefixedName
    /// <summary>
    ///   <para>open:diffSource.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/diffSource.html">http://open.vocab.org/terms/diffSource.html</seealso>
    let ``diffSource.html`` = Prefixed_Name(open_, "diffSource.html") |> PrefixedName
    /// <summary>
    ///   <para>open:diffTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The resource that this diff goes to."</para>
    /// labels<para>"target"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/diffTarget">http://open.vocab.org/terms/diffTarget</seealso>
    let diffTarget = Prefixed_Name(open_, "diffTarget") |> PrefixedName
    /// <summary>
    ///   <para>open:diffTarget.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/diffTarget.html">http://open.vocab.org/terms/diffTarget.html</seealso>
    let ``diffTarget.html`` = Prefixed_Name(open_, "diffTarget.html") |> PrefixedName
    /// <summary>
    ///   <para>open:diffToOther</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A diff that goes from this resource to another one."</para>
    /// labels<para>"diff to other"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/diffToOther">http://open.vocab.org/terms/diffToOther</seealso>
    let diffToOther = Prefixed_Name(open_, "diffToOther") |> PrefixedName
    /// <summary>
    ///   <para>open:diffToOther.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/diffToOther.html">http://open.vocab.org/terms/diffToOther.html</seealso>
    let ``diffToOther.html`` = Prefixed_Name(open_, "diffToOther.html") |> PrefixedName
    /// <summary>
    ///   <para>open:dimensionProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Relates a property to a Dimension Property with identical meaning for use with the RDF DataCube vocabulary."</para>
    /// labels<para>"Dimension Property"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/dimensionProperty">http://open.vocab.org/terms/dimensionProperty</seealso>
    let dimensionProperty = Prefixed_Name(open_, "dimensionProperty") |> PrefixedName
    /// <summary>
    ///   <para>open:disclaimer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The disclaimer property links a resource to a document that details a disclaimer applied to the resource by the resource owner or other relevant party."</para>
    /// labels<para>"disclaimer"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/disclaimer">http://open.vocab.org/terms/disclaimer</seealso>
    let disclaimer = Prefixed_Name(open_, "disclaimer") |> PrefixedName
    /// <summary>
    ///   <para>open:disclaimerText</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The disclaimerText property associates a resource with the text of a disclaimer (in the form of an rdfs:Literal) applied to the resource by the resource owner or other relevant party."</para>
    /// labels<para>"disclaimer text"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/disclaimerText">http://open.vocab.org/terms/disclaimerText</seealso>
    let disclaimerText = Prefixed_Name(open_, "disclaimerText") |> PrefixedName
    /// <summary>
    ///   <para>open:discussionList</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/discussionList">http://open.vocab.org/terms/discussionList</seealso>
    let discussionList = Prefixed_Name(open_, "discussionList") |> PrefixedName
    /// <summary>
    ///   <para>open:distancePoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A location from which a distance is measured. (A distance measurement will have two points, and a distance measurement value)."</para>
    /// labels<para>"Distance Point"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/distancePoint">http://open.vocab.org/terms/distancePoint</seealso>
    let distancePoint = Prefixed_Name(open_, "distancePoint") |> PrefixedName

    /// <summary>
    ///   <para>open:doesnt-live-here-anymore</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/doesnt-live-here-anymore">http://open.vocab.org/terms/doesnt-live-here-anymore</seealso>
    let doesnt_live_here_anymore =
        Prefixed_Name(open_, "doesnt-live-here-anymore") |> PrefixedName

    /// <summary>
    ///   <para>open:domicile</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/domicile">http://open.vocab.org/terms/domicile</seealso>
    let domicile = Prefixed_Name(open_, "domicile") |> PrefixedName
    /// <summary>
    ///   <para>open:earwormSong</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The song that is the focus of a particular earworm"</para>
    /// labels<para>"Earworm Song"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/earwormSong">http://open.vocab.org/terms/earwormSong</seealso>
    let earwormSong = Prefixed_Name(open_, "earwormSong") |> PrefixedName
    /// <summary>
    ///   <para>open:earwormSong.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/earwormSong.html">http://open.vocab.org/terms/earwormSong.html</seealso>
    let ``earwormSong.html`` = Prefixed_Name(open_, "earwormSong.html") |> PrefixedName
    /// <summary>
    ///   <para>open:earwormSufferer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The person who experiences or suffers from a particular ear worm"</para>
    /// labels<para>"Earworm Sufferer"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/earwormSufferer">http://open.vocab.org/terms/earwormSufferer</seealso>
    let earwormSufferer = Prefixed_Name(open_, "earwormSufferer") |> PrefixedName

    /// <summary>
    ///   <para>open:earwormSufferer.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/earwormSufferer.html">http://open.vocab.org/terms/earwormSufferer.html</seealso>
    let ``earwormSufferer.html`` =
        Prefixed_Name(open_, "earwormSufferer.html") |> PrefixedName

    /// <summary>
    ///   <para>open:earwormTransmitter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The transmitter of a particular Earworm"</para>
    /// labels<para>"Earworm Transmitter"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/earwormTransmitter">http://open.vocab.org/terms/earwormTransmitter</seealso>
    let earwormTransmitter = Prefixed_Name(open_, "earwormTransmitter") |> PrefixedName

    /// <summary>
    ///   <para>open:earwormTransmitter.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/earwormTransmitter.html">http://open.vocab.org/terms/earwormTransmitter.html</seealso>
    let ``earwormTransmitter.html`` =
        Prefixed_Name(open_, "earwormTransmitter.html") |> PrefixedName

    /// <summary>
    ///   <para>open:editForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Associates a resource with a form that can be used to edit its description. See http://patterns.dataincubator.org/book/edit-trail.html for more information."</para>
    /// labels<para>"Edit Form"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/editForm">http://open.vocab.org/terms/editForm</seealso>
    let editForm = Prefixed_Name(open_, "editForm") |> PrefixedName
    /// <summary>
    ///   <para>open:endTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The time of day that something ends."</para>
    /// labels<para>"End Time"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/endTime">http://open.vocab.org/terms/endTime</seealso>
    let endTime = Prefixed_Name(open_, "endTime") |> PrefixedName
    /// <summary>
    ///   <para>open:endTime.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/endTime.html">http://open.vocab.org/terms/endTime.html</seealso>
    let ``endTime.html`` = Prefixed_Name(open_, "endTime.html") |> PrefixedName

    /// <summary>
    ///   <para>open:enhancedDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This property is to be used to relate a resource to an "enhanced description". An enhanced description is one that provides additional, richer detail about a resource than may typically be obtained by a simple de-reference of the resource's URI."</para>
    /// labels<para>"enhanced description"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/enhancedDescription">http://open.vocab.org/terms/enhancedDescription</seealso>
    let enhancedDescription =
        Prefixed_Name(open_, "enhancedDescription") |> PrefixedName

    /// <summary>
    ///   <para>open:enhancedDescription.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/enhancedDescription.html">http://open.vocab.org/terms/enhancedDescription.html</seealso>
    let ``enhancedDescription.html`` =
        Prefixed_Name(open_, "enhancedDescription.html") |> PrefixedName

    /// <summary>
    ///   <para>open:exampleInstance</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/exampleInstance">http://open.vocab.org/terms/exampleInstance</seealso>
    let exampleInstance = Prefixed_Name(open_, "exampleInstance") |> PrefixedName
    /// <summary>
    ///   <para>open:exampleResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"an example resource using a vocabulary term or terms"</para>
    /// labels<para>"Example Resource"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/exampleResource">http://open.vocab.org/terms/exampleResource</seealso>
    let exampleResource = Prefixed_Name(open_, "exampleResource") |> PrefixedName

    /// <summary>
    ///   <para>open:exampleResource.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/exampleResource.html">http://open.vocab.org/terms/exampleResource.html</seealso>
    let ``exampleResource.html`` =
        Prefixed_Name(open_, "exampleResource.html") |> PrefixedName

    /// <summary>
    ///   <para>open:eyeColor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Eye Color"</para>
    /// labels<para>"Color of Eye of an Individual"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/eyeColor">http://open.vocab.org/terms/eyeColor</seealso>
    let eyeColor = Prefixed_Name(open_, "eyeColor") |> PrefixedName
    /// <summary>
    ///   <para>open:familiarName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The name used in familiar situations by friends, e.g. Ian
    /// "</para>
    /// labels<para>"Familiar Name"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/familiarName">http://open.vocab.org/terms/familiarName</seealso>
    let familiarName = Prefixed_Name(open_, "familiarName") |> PrefixedName

    /// <summary>
    ///   <para>open:familiarName.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/familiarName.html">http://open.vocab.org/terms/familiarName.html</seealso>
    let ``familiarName.html`` =
        Prefixed_Name(open_, "familiarName.html") |> PrefixedName

    /// <summary>
    ///   <para>open:favouriteDrink</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A drink, alcoholic or not, that the person in question is particularly fond of. It's what they would typically order in a place where the drink is available. The object can be a literal stating the name of the drink, or (preferred) an RDF resource."</para>
    /// labels<para>"Favourite Drink"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/favouriteDrink">http://open.vocab.org/terms/favouriteDrink</seealso>
    let favouriteDrink = Prefixed_Name(open_, "favouriteDrink") |> PrefixedName

    /// <summary>
    ///   <para>open:favouriteDrink.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/favouriteDrink.html">http://open.vocab.org/terms/favouriteDrink.html</seealso>
    let ``favouriteDrink.html`` =
        Prefixed_Name(open_, "favouriteDrink.html") |> PrefixedName

    /// <summary>
    ///   <para>open:favouritedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"favourite"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/favouritedBy">http://open.vocab.org/terms/favouritedBy</seealso>
    let favouritedBy = Prefixed_Name(open_, "favouritedBy") |> PrefixedName

    /// <summary>
    ///   <para>open:favouritedBy.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/favouritedBy.html">http://open.vocab.org/terms/favouritedBy.html</seealso>
    let ``favouritedBy.html`` =
        Prefixed_Name(open_, "favouritedBy.html") |> PrefixedName

    /// <summary>
    ///   <para>open:faxNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A fax number that can be used to send faxes to a Person or Organisation."</para>
    /// labels<para>"Fax Number"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/faxNumber">http://open.vocab.org/terms/faxNumber</seealso>
    let faxNumber = Prefixed_Name(open_, "faxNumber") |> PrefixedName
    /// <summary>
    ///   <para>open:featurefile</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"associates a musical item with a feature file describing that item"</para>
    /// labels<para>"Feature File"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/featurefile">http://open.vocab.org/terms/featurefile</seealso>
    let featurefile = Prefixed_Name(open_, "featurefile") |> PrefixedName
    /// <summary>
    ///   <para>open:featurefile.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/featurefile.html">http://open.vocab.org/terms/featurefile.html</seealso>
    let ``featurefile.html`` = Prefixed_Name(open_, "featurefile.html") |> PrefixedName
    /// <summary>
    ///   <para>open:fileSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Describes the size of the file of a dataset in the normal (uncompressed) state"</para>
    /// labels<para>"dataset file has fileSize"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/fileSize">http://open.vocab.org/terms/fileSize</seealso>
    let fileSize = Prefixed_Name(open_, "fileSize") |> PrefixedName
    /// <summary>
    ///   <para>open:findspot</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The place at which a thing is found."</para>
    /// labels<para>"Findspot"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/findspot">http://open.vocab.org/terms/findspot</seealso>
    let findspot = Prefixed_Name(open_, "findspot") |> PrefixedName
    /// <summary>
    ///   <para>open:findspot.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/findspot.html">http://open.vocab.org/terms/findspot.html</seealso>
    let ``findspot.html`` = Prefixed_Name(open_, "findspot.html") |> PrefixedName
    /// <summary>
    ///   <para>open:firstSentence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The first sentence of a resource."</para>
    /// labels<para>"First Sentence"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/firstSentence">http://open.vocab.org/terms/firstSentence</seealso>
    let firstSentence = Prefixed_Name(open_, "firstSentence") |> PrefixedName

    /// <summary>
    ///   <para>open:firstSentence.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/firstSentence.html">http://open.vocab.org/terms/firstSentence.html</seealso>
    let ``firstSentence.html`` =
        Prefixed_Name(open_, "firstSentence.html") |> PrefixedName

    /// <summary>
    ///   <para>open:foafro</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Use this property to state that you admire a friend's fro"</para>
    /// labels<para>"Friend of a Fro"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/foafro">http://open.vocab.org/terms/foafro</seealso>
    let foafro = Prefixed_Name(open_, "foafro") |> PrefixedName
    /// <summary>
    ///   <para>open:foafro.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/foafro.html">http://open.vocab.org/terms/foafro.html</seealso>
    let ``foafro.html`` = Prefixed_Name(open_, "foafro.html") |> PrefixedName
    /// <summary>
    ///   <para>open:formalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The name used when referred to in formal situations, e.g. Mr. Davis
    /// "</para>
    /// labels<para>"Formal Name"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/formalName">http://open.vocab.org/terms/formalName</seealso>
    let formalName = Prefixed_Name(open_, "formalName") |> PrefixedName
    /// <summary>
    ///   <para>open:formalName.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/formalName.html">http://open.vocab.org/terms/formalName.html</seealso>
    let ``formalName.html`` = Prefixed_Name(open_, "formalName.html") |> PrefixedName
    /// <summary>
    ///   <para>open:fullName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The full name as expected to be used on an identifying document e.g. Mr Ian Robert Davis
    /// "</para>
    /// labels<para>"Full Name"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/fullName">http://open.vocab.org/terms/fullName</seealso>
    let fullName = Prefixed_Name(open_, "fullName") |> PrefixedName
    /// <summary>
    ///   <para>open:fullName.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/fullName.html">http://open.vocab.org/terms/fullName.html</seealso>
    let ``fullName.html`` = Prefixed_Name(open_, "fullName.html") |> PrefixedName
    /// <summary>
    ///   <para>open:geoBoundaryDefiner</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The agent that defines the boundaries of a geographic area."</para>
    /// labels<para>"Geographic Boundary Definer"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/geoBoundaryDefiner">http://open.vocab.org/terms/geoBoundaryDefiner</seealso>
    let geoBoundaryDefiner = Prefixed_Name(open_, "geoBoundaryDefiner") |> PrefixedName
    /// <summary>
    ///   <para>open:geoqrcode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The value of this property is a QRCode image that encodes the geographic coordinates of the resource. The coordinates are encoded using the WGS84 datum in the following form - geo:[lat],[long]"</para>
    /// labels<para>"Geographic QRCode"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/geoqrcode">http://open.vocab.org/terms/geoqrcode</seealso>
    let geoqrcode = Prefixed_Name(open_, "geoqrcode") |> PrefixedName
    /// <summary>
    ///   <para>open:has</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Boundary point has a position"</para>
    /// labels<para>"has"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/has">http://open.vocab.org/terms/has</seealso>
    let has = Prefixed_Name(open_, "has") |> PrefixedName
    /// <summary>
    ///   <para>open:has.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/has.html">http://open.vocab.org/terms/has.html</seealso>
    let ``has.html`` = Prefixed_Name(open_, "has.html") |> PrefixedName
    /// <summary>
    ///   <para>open:hasBoundary</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"DOMRange has 2 boundary points"</para>
    /// labels<para>"has boundary"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/hasBoundary">http://open.vocab.org/terms/hasBoundary</seealso>
    let hasBoundary = Prefixed_Name(open_, "hasBoundary") |> PrefixedName
    /// <summary>
    ///   <para>open:hasBoundary.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/hasBoundary.html">http://open.vocab.org/terms/hasBoundary.html</seealso>
    let ``hasBoundary.html`` = Prefixed_Name(open_, "hasBoundary.html") |> PrefixedName
    /// <summary>
    ///   <para>open:hasChecksum</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"has checksum - expecting (acronym/name):(checksum hexdigest)
    ///
    /// eg        ov:hasChecksum  "sha1:a526a7c1bc65348dc7649556bee283ee3c999b92""</para>
    /// labels<para>"has checksum"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/hasChecksum">http://open.vocab.org/terms/hasChecksum</seealso>
    let hasChecksum = Prefixed_Name(open_, "hasChecksum") |> PrefixedName
    /// <summary>
    ///   <para>open:hasChecksum.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/hasChecksum.html">http://open.vocab.org/terms/hasChecksum.html</seealso>
    let ``hasChecksum.html`` = Prefixed_Name(open_, "hasChecksum.html") |> PrefixedName
    /// <summary>
    ///   <para>open:hasContentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Encoding MIME-Type information in a trivial manner - equivalent to HTTP header: Content-Type."</para>
    /// labels<para>"Content Type"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/hasContentType">http://open.vocab.org/terms/hasContentType</seealso>
    let hasContentType = Prefixed_Name(open_, "hasContentType") |> PrefixedName

    /// <summary>
    ///   <para>open:hasContentType.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/hasContentType.html">http://open.vocab.org/terms/hasContentType.html</seealso>
    let ``hasContentType.html`` =
        Prefixed_Name(open_, "hasContentType.html") |> PrefixedName

    /// <summary>
    ///   <para>open:hasFavourited</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"favourite"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/hasFavourited">http://open.vocab.org/terms/hasFavourited</seealso>
    let hasFavourited = Prefixed_Name(open_, "hasFavourited") |> PrefixedName

    /// <summary>
    ///   <para>open:hasFavourited.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/hasFavourited.html">http://open.vocab.org/terms/hasFavourited.html</seealso>
    let ``hasFavourited.html`` =
        Prefixed_Name(open_, "hasFavourited.html") |> PrefixedName

    /// <summary>
    ///   <para>open:hasLender</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Domain: any institution or individual who borrows money from loaner
    /// Range: any institution or individual who loans a borrower money"</para>
    /// labels<para>"Has lender"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/hasLender">http://open.vocab.org/terms/hasLender</seealso>
    let hasLender = Prefixed_Name(open_, "hasLender") |> PrefixedName
    /// <summary>
    ///   <para>open:hasMD5</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has MD5 checksum"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/hasMD5">http://open.vocab.org/terms/hasMD5</seealso>
    let hasMD5 = Prefixed_Name(open_, "hasMD5") |> PrefixedName
    /// <summary>
    ///   <para>open:hasMD5.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/hasMD5.html">http://open.vocab.org/terms/hasMD5.html</seealso>
    let ``hasMD5.html`` = Prefixed_Name(open_, "hasMD5.html") |> PrefixedName
    /// <summary>
    ///   <para>open:hasNationality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links a person to a country that he or she may be a member. (A person can have multiple nationalities). The domain is foaf:Person but the range is open (although http://dbpedia.org/ontology/Country or http://umbel.org/umbel/rc/Country are suggested)"</para>
    /// labels<para>"nationality"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/hasNationality">http://open.vocab.org/terms/hasNationality</seealso>
    let hasNationality = Prefixed_Name(open_, "hasNationality") |> PrefixedName
    /// <summary>
    ///   <para>open:hasNode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has node"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/hasNode">http://open.vocab.org/terms/hasNode</seealso>
    let hasNode = Prefixed_Name(open_, "hasNode") |> PrefixedName
    /// <summary>
    ///   <para>open:hasNode.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/hasNode.html">http://open.vocab.org/terms/hasNode.html</seealso>
    let ``hasNode.html`` = Prefixed_Name(open_, "hasNode.html") |> PrefixedName
    /// <summary>
    ///   <para>open:hasOffset</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has offset"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/hasOffset">http://open.vocab.org/terms/hasOffset</seealso>
    let hasOffset = Prefixed_Name(open_, "hasOffset") |> PrefixedName
    /// <summary>
    ///   <para>open:hasOffset.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/hasOffset.html">http://open.vocab.org/terms/hasOffset.html</seealso>
    let ``hasOffset.html`` = Prefixed_Name(open_, "hasOffset.html") |> PrefixedName
    /// <summary>
    ///   <para>open:hasPlot</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Something has a plot."</para>
    /// labels<para>"hasPlot"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/hasPlot">http://open.vocab.org/terms/hasPlot</seealso>
    let hasPlot = Prefixed_Name(open_, "hasPlot") |> PrefixedName
    /// <summary>
    ///   <para>open:hasPlot.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/hasPlot.html">http://open.vocab.org/terms/hasPlot.html</seealso>
    let ``hasPlot.html`` = Prefixed_Name(open_, "hasPlot.html") |> PrefixedName
    /// <summary>
    ///   <para>open:hasPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has position"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/hasPosition">http://open.vocab.org/terms/hasPosition</seealso>
    let hasPosition = Prefixed_Name(open_, "hasPosition") |> PrefixedName
    /// <summary>
    ///   <para>open:hasPosition.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/hasPosition.html">http://open.vocab.org/terms/hasPosition.html</seealso>
    let ``hasPosition.html`` = Prefixed_Name(open_, "hasPosition.html") |> PrefixedName
    /// <summary>
    ///   <para>open:hasRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"a resource (e.g. HTML content --&gt; awol:Content) has a DOM range"</para>
    /// labels<para>"has range"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/hasRange">http://open.vocab.org/terms/hasRange</seealso>
    let hasRange = Prefixed_Name(open_, "hasRange") |> PrefixedName
    /// <summary>
    ///   <para>open:hasRange.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/hasRange.html">http://open.vocab.org/terms/hasRange.html</seealso>
    let ``hasRange.html`` = Prefixed_Name(open_, "hasRange.html") |> PrefixedName
    /// <summary>
    ///   <para>open:hearts</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Slang for loves."</para>
    /// labels<para>"Hearts"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/hearts">http://open.vocab.org/terms/hearts</seealso>
    let hearts = Prefixed_Name(open_, "hearts") |> PrefixedName
    /// <summary>
    ///   <para>open:hearts.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/hearts.html">http://open.vocab.org/terms/hearts.html</seealso>
    let ``hearts.html`` = Prefixed_Name(open_, "hearts.html") |> PrefixedName
    /// <summary>
    ///   <para>open:homepage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/homepage">http://open.vocab.org/terms/homepage</seealso>
    let homepage = Prefixed_Name(open_, "homepage") |> PrefixedName
    /// <summary>
    ///   <para>open:horse</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/horse">http://open.vocab.org/terms/horse</seealso>
    let horse = Prefixed_Name(open_, "horse") |> PrefixedName
    /// <summary>
    ///   <para>open:houseColor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"color of a house"</para>
    /// labels<para>"houseColor"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/houseColor">http://open.vocab.org/terms/houseColor</seealso>
    let houseColor = Prefixed_Name(open_, "houseColor") |> PrefixedName
    /// <summary>
    ///   <para>open:houseColor.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/houseColor.html">http://open.vocab.org/terms/houseColor.html</seealso>
    let ``houseColor.html`` = Prefixed_Name(open_, "houseColor.html") |> PrefixedName
    /// <summary>
    ///   <para>open:housePaintColor</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/housePaintColor">http://open.vocab.org/terms/housePaintColor</seealso>
    let housePaintColor = Prefixed_Name(open_, "housePaintColor") |> PrefixedName
    /// <summary>
    ///   <para>open:hudBefore</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"loans before"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/hudBefore">http://open.vocab.org/terms/hudBefore</seealso>
    let hudBefore = Prefixed_Name(open_, "hudBefore") |> PrefixedName
    /// <summary>
    ///   <para>open:hudBefore.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/hudBefore.html">http://open.vocab.org/terms/hudBefore.html</seealso>
    let ``hudBefore.html`` = Prefixed_Name(open_, "hudBefore.html") |> PrefixedName
    /// <summary>
    ///   <para>open:hudCommon</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The number of loans two books have in common"</para>
    /// labels<para>"loans in common"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/hudCommon">http://open.vocab.org/terms/hudCommon</seealso>
    let hudCommon = Prefixed_Name(open_, "hudCommon") |> PrefixedName
    /// <summary>
    ///   <para>open:hudCommon.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/hudCommon.html">http://open.vocab.org/terms/hudCommon.html</seealso>
    let ``hudCommon.html`` = Prefixed_Name(open_, "hudCommon.html") |> PrefixedName
    /// <summary>
    ///   <para>open:hudCourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A course associated with a book loan"</para>
    /// labels<para>"course"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/hudCourse">http://open.vocab.org/terms/hudCourse</seealso>
    let hudCourse = Prefixed_Name(open_, "hudCourse") |> PrefixedName
    /// <summary>
    ///   <para>open:hudCourse.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/hudCourse.html">http://open.vocab.org/terms/hudCourse.html</seealso>
    let ``hudCourse.html`` = Prefixed_Name(open_, "hudCourse.html") |> PrefixedName
    /// <summary>
    ///   <para>open:hudLoanCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The number of loans of a book within a year, school, or course"</para>
    /// labels<para>"loan count"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/hudLoanCount">http://open.vocab.org/terms/hudLoanCount</seealso>
    let hudLoanCount = Prefixed_Name(open_, "hudLoanCount") |> PrefixedName

    /// <summary>
    ///   <para>open:hudLoanCount.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/hudLoanCount.html">http://open.vocab.org/terms/hudLoanCount.html</seealso>
    let ``hudLoanCount.html`` =
        Prefixed_Name(open_, "hudLoanCount.html") |> PrefixedName

    /// <summary>
    ///   <para>open:hudLoanTotal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"total loans"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/hudLoanTotal">http://open.vocab.org/terms/hudLoanTotal</seealso>
    let hudLoanTotal = Prefixed_Name(open_, "hudLoanTotal") |> PrefixedName

    /// <summary>
    ///   <para>open:hudLoanTotal.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/hudLoanTotal.html">http://open.vocab.org/terms/hudLoanTotal.html</seealso>
    let ``hudLoanTotal.html`` =
        Prefixed_Name(open_, "hudLoanTotal.html") |> PrefixedName

    /// <summary>
    ///   <para>open:hudSame</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"simultaneous loans"</para>
    /// labels<para>"same"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/hudSame">http://open.vocab.org/terms/hudSame</seealso>
    let hudSame = Prefixed_Name(open_, "hudSame") |> PrefixedName
    /// <summary>
    ///   <para>open:hudSame.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/hudSame.html">http://open.vocab.org/terms/hudSame.html</seealso>
    let ``hudSame.html`` = Prefixed_Name(open_, "hudSame.html") |> PrefixedName
    /// <summary>
    ///   <para>open:hudSchool</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The school associated with the loan history of a book"</para>
    /// labels<para>"school"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/hudSchool">http://open.vocab.org/terms/hudSchool</seealso>
    let hudSchool = Prefixed_Name(open_, "hudSchool") |> PrefixedName
    /// <summary>
    ///   <para>open:hudSchool.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/hudSchool.html">http://open.vocab.org/terms/hudSchool.html</seealso>
    let ``hudSchool.html`` = Prefixed_Name(open_, "hudSchool.html") |> PrefixedName
    /// <summary>
    ///   <para>open:hudSchoolLoan</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"school loan"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/hudSchoolLoan">http://open.vocab.org/terms/hudSchoolLoan</seealso>
    let hudSchoolLoan = Prefixed_Name(open_, "hudSchoolLoan") |> PrefixedName

    /// <summary>
    ///   <para>open:hudSchoolLoan.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/hudSchoolLoan.html">http://open.vocab.org/terms/hudSchoolLoan.html</seealso>
    let ``hudSchoolLoan.html`` =
        Prefixed_Name(open_, "hudSchoolLoan.html") |> PrefixedName

    /// <summary>
    ///   <para>open:hudSuggestedBook</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/hudSuggestedBook">http://open.vocab.org/terms/hudSuggestedBook</seealso>
    let hudSuggestedBook = Prefixed_Name(open_, "hudSuggestedBook") |> PrefixedName
    /// <summary>
    ///   <para>open:hudSuggestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"suggestion"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/hudSuggestion">http://open.vocab.org/terms/hudSuggestion</seealso>
    let hudSuggestion = Prefixed_Name(open_, "hudSuggestion") |> PrefixedName

    /// <summary>
    ///   <para>open:hudSuggestion.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/hudSuggestion.html">http://open.vocab.org/terms/hudSuggestion.html</seealso>
    let ``hudSuggestion.html`` =
        Prefixed_Name(open_, "hudSuggestion.html") |> PrefixedName

    /// <summary>
    ///   <para>open:hudYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The year associated with a loan history"</para>
    /// labels<para>"year"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/hudYear">http://open.vocab.org/terms/hudYear</seealso>
    let hudYear = Prefixed_Name(open_, "hudYear") |> PrefixedName
    /// <summary>
    ///   <para>open:hudYear.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/hudYear.html">http://open.vocab.org/terms/hudYear.html</seealso>
    let ``hudYear.html`` = Prefixed_Name(open_, "hudYear.html") |> PrefixedName
    /// <summary>
    ///   <para>open:icon</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"a pictorial representation for something."</para>
    /// labels<para>"Icon"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/icon">http://open.vocab.org/terms/icon</seealso>
    let icon = Prefixed_Name(open_, "icon") |> PrefixedName
    /// <summary>
    ///   <para>open:imWsBhgGVLi</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/imWsBhgGVLi">http://open.vocab.org/terms/imWsBhgGVLi</seealso>
    let imWsBhgGVLi = Prefixed_Name(open_, "imWsBhgGVLi") |> PrefixedName
    /// <summary>
    ///   <para>open:image</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"an image of the resource, whatever it may be. Typically the value of this property will be the URI of some sort of digital image."</para>
    /// labels<para>"Image"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/image">http://open.vocab.org/terms/image</seealso>
    let image = Prefixed_Name(open_, "image") |> PrefixedName
    /// <summary>
    ///   <para>open:informalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The name used when referred to in informal situations, e.g. Ian Davis
    /// "</para>
    /// labels<para>"Informal Name"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/informalName">http://open.vocab.org/terms/informalName</seealso>
    let informalName = Prefixed_Name(open_, "informalName") |> PrefixedName

    /// <summary>
    ///   <para>open:informalName.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/informalName.html">http://open.vocab.org/terms/informalName.html</seealso>
    let ``informalName.html`` =
        Prefixed_Name(open_, "informalName.html") |> PrefixedName

    /// <summary>
    ///   <para>open:isCategoryOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The value of this property is something that has been classified under the resource"</para>
    /// labels<para>"is category of"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/isCategoryOf">http://open.vocab.org/terms/isCategoryOf</seealso>
    let isCategoryOf = Prefixed_Name(open_, "isCategoryOf") |> PrefixedName

    /// <summary>
    ///   <para>open:isCategoryOf.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/isCategoryOf.html">http://open.vocab.org/terms/isCategoryOf.html</seealso>
    let ``isCategoryOf.html`` =
        Prefixed_Name(open_, "isCategoryOf.html") |> PrefixedName

    /// <summary>
    ///   <para>open:isCuratedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"curated by"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/isCuratedBy">http://open.vocab.org/terms/isCuratedBy</seealso>
    let isCuratedBy = Prefixed_Name(open_, "isCuratedBy") |> PrefixedName
    /// <summary>
    ///   <para>open:isCuratedBy.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/isCuratedBy.html">http://open.vocab.org/terms/isCuratedBy.html</seealso>
    let ``isCuratedBy.html`` = Prefixed_Name(open_, "isCuratedBy.html") |> PrefixedName
    /// <summary>
    ///   <para>open:isDefinedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"DOMBoundaryPointPosition is defines by a DOMNode and a DOMOffset"</para>
    /// labels<para>"is defined by"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/isDefinedBy">http://open.vocab.org/terms/isDefinedBy</seealso>
    let isDefinedBy = Prefixed_Name(open_, "isDefinedBy") |> PrefixedName
    /// <summary>
    ///   <para>open:isDefinedBy.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/isDefinedBy.html">http://open.vocab.org/terms/isDefinedBy.html</seealso>
    let ``isDefinedBy.html`` = Prefixed_Name(open_, "isDefinedBy.html") |> PrefixedName
    /// <summary>
    ///   <para>open:isHeaderOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Header"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/isHeaderOf">http://open.vocab.org/terms/isHeaderOf</seealso>
    let isHeaderOf = Prefixed_Name(open_, "isHeaderOf") |> PrefixedName
    /// <summary>
    ///   <para>open:isHeaderOf.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/isHeaderOf.html">http://open.vocab.org/terms/isHeaderOf.html</seealso>
    let ``isHeaderOf.html`` = Prefixed_Name(open_, "isHeaderOf.html") |> PrefixedName
    /// <summary>
    ///   <para>open:isMemberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Property to link an agent with an organization (inverse property of http://xmlns.com/foaf/0.1/member)"</para>
    /// labels<para>"is member of"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/isMemberOf">http://open.vocab.org/terms/isMemberOf</seealso>
    let isMemberOf = Prefixed_Name(open_, "isMemberOf") |> PrefixedName
    /// <summary>
    ///   <para>open:isSongOfEarworm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A song which is the focus of a particular Earworm"</para>
    /// labels<para>"is Song of Earworm"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/isSongOfEarworm">http://open.vocab.org/terms/isSongOfEarworm</seealso>
    let isSongOfEarworm = Prefixed_Name(open_, "isSongOfEarworm") |> PrefixedName

    /// <summary>
    ///   <para>open:isSongOfEarworm.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/isSongOfEarworm.html">http://open.vocab.org/terms/isSongOfEarworm.html</seealso>
    let ``isSongOfEarworm.html`` =
        Prefixed_Name(open_, "isSongOfEarworm.html") |> PrefixedName

    /// <summary>
    ///   <para>open:json</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The JSON representation of a (usually small) dataset."</para>
    /// labels<para>"JSON"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/json">http://open.vocab.org/terms/json</seealso>
    let json = Prefixed_Name(open_, "json") |> PrefixedName
    /// <summary>
    ///   <para>open:keywords</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A comma separated list of words that are particularly pertinent to this resource."</para>
    /// labels<para>"keywords"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/keywords">http://open.vocab.org/terms/keywords</seealso>
    let keywords = Prefixed_Name(open_, "keywords") |> PrefixedName
    /// <summary>
    ///   <para>open:kilometres</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The number of kilometres of a distance measurement."</para>
    /// labels<para>"Kilometres"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/kilometres">http://open.vocab.org/terms/kilometres</seealso>
    let kilometres = Prefixed_Name(open_, "kilometres") |> PrefixedName
    /// <summary>
    ///   <para>open:kudosTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"to express kudos to someone (acknowledge a contribution, feedback, etc.) "</para>
    /// labels<para>"kudos to"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/kudosTo">http://open.vocab.org/terms/kudosTo</seealso>
    let kudosTo = Prefixed_Name(open_, "kudosTo") |> PrefixedName
    /// <summary>
    ///   <para>open:kudosTo.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/kudosTo.html">http://open.vocab.org/terms/kudosTo.html</seealso>
    let ``kudosTo.html`` = Prefixed_Name(open_, "kudosTo.html") |> PrefixedName
    /// <summary>
    ///   <para>open:lastCachedPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The most recently cached static page describing the resource."</para>
    /// labels<para>"Last Cached Page"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/lastCachedPage">http://open.vocab.org/terms/lastCachedPage</seealso>
    let lastCachedPage = Prefixed_Name(open_, "lastCachedPage") |> PrefixedName
    /// <summary>
    ///   <para>open:length</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The linear extent of a thing."</para>
    /// labels<para>"Length"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/length">http://open.vocab.org/terms/length</seealso>
    let length = Prefixed_Name(open_, "length") |> PrefixedName
    /// <summary>
    ///   <para>open:length.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/length.html">http://open.vocab.org/terms/length.html</seealso>
    let ``length.html`` = Prefixed_Name(open_, "length.html") |> PrefixedName
    /// <summary>
    ///   <para>open:libraryService</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A service providing access to bibliographic resources."</para>
    /// labels<para>"Library Service"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/libraryService">http://open.vocab.org/terms/libraryService</seealso>
    let libraryService = Prefixed_Name(open_, "libraryService") |> PrefixedName
    /// <summary>
    ///   <para>open:machineTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"a machine tag that can be used to identify the domain resource in tagging applications. "</para>
    /// labels<para>"machine-tag"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/machineTag">http://open.vocab.org/terms/machineTag</seealso>
    let machineTag = Prefixed_Name(open_, "machineTag") |> PrefixedName
    /// <summary>
    ///   <para>open:machineTag.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/machineTag.html">http://open.vocab.org/terms/machineTag.html</seealso>
    let ``machineTag.html`` = Prefixed_Name(open_, "machineTag.html") |> PrefixedName
    /// <summary>
    ///   <para>open:madeIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The place where a particular object was made. (Made is left intentionally vague and follows the same semantics as foaf:maker, foaf:made etc.)"</para>
    /// labels<para>"place where made"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/madeIn">http://open.vocab.org/terms/madeIn</seealso>
    let madeIn = Prefixed_Name(open_, "madeIn") |> PrefixedName
    /// <summary>
    ///   <para>open:maidenName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A person's maiden name."</para>
    /// labels<para>"Maiden Name"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/maidenName">http://open.vocab.org/terms/maidenName</seealso>
    let maidenName = Prefixed_Name(open_, "maidenName") |> PrefixedName
    /// <summary>
    ///   <para>open:manchax</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The Manchester Syntax for a owl construct (e.g., Restriction).
    ///
    /// :manchex rdfs:subPropertyOf rdfs:label ."</para>
    /// labels<para>"manchester syntax"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/manchax">http://open.vocab.org/terms/manchax</seealso>
    let manchax = Prefixed_Name(open_, "manchax") |> PrefixedName
    /// <summary>
    ///   <para>open:manchax.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/manchax.html">http://open.vocab.org/terms/manchax.html</seealso>
    let ``manchax.html`` = Prefixed_Name(open_, "manchax.html") |> PrefixedName

    /// <summary>
    ///   <para>open:markdownDescription</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/markdownDescription">http://open.vocab.org/terms/markdownDescription</seealso>
    let markdownDescription =
        Prefixed_Name(open_, "markdownDescription") |> PrefixedName

    /// <summary>
    ///   <para>open:mirror</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"Indicates a resource that is designed to be a mirror or surrogate of the object resource; a backup copy, should the object resource be lost or unobtainable."</para>
    /// labels<para>"Mirror"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/mirror">http://open.vocab.org/terms/mirror</seealso>
    let mirror = Prefixed_Name(open_, "mirror") |> PrefixedName
    /// <summary>
    ///   <para>open:mirror.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/mirror.html">http://open.vocab.org/terms/mirror.html</seealso>
    let ``mirror.html`` = Prefixed_Name(open_, "mirror.html") |> PrefixedName
    /// <summary>
    ///   <para>open:mllxMBbjeh</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/mllxMBbjeh">http://open.vocab.org/terms/mllxMBbjeh</seealso>
    let mllxMBbjeh = Prefixed_Name(open_, "mllxMBbjeh") |> PrefixedName
    /// <summary>
    ///   <para>open:motVehicleClasses</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The Vehicle Classes an MOT Test Station is authorised to test, as a comma separated list using Arabic numerals (plus A where appropriate), e.g "3, 4, 4A, 5"."</para>
    /// labels<para>"MOT Vehicle Classes"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/motVehicleClasses">http://open.vocab.org/terms/motVehicleClasses</seealso>
    let motVehicleClasses = Prefixed_Name(open_, "motVehicleClasses") |> PrefixedName
    /// <summary>
    ///   <para>open:namedPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Places named in a text."</para>
    /// labels<para>"Named place"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/namedPlace">http://open.vocab.org/terms/namedPlace</seealso>
    let namedPlace = Prefixed_Name(open_, "namedPlace") |> PrefixedName
    /// <summary>
    ///   <para>open:namedPlace.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/namedPlace.html">http://open.vocab.org/terms/namedPlace.html</seealso>
    let ``namedPlace.html`` = Prefixed_Name(open_, "namedPlace.html") |> PrefixedName

    /// <summary>
    ///   <para>open:national-grid-reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A (UK) national grid reference for a given location, using the alphanumeric syntax."</para>
    /// labels<para>"National Grid Reference"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/national-grid-reference">http://open.vocab.org/terms/national-grid-reference</seealso>
    let national_grid_reference =
        Prefixed_Name(open_, "national-grid-reference") |> PrefixedName

    /// <summary>
    ///   <para>open:national-grid-reference.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/national-grid-reference.html">http://open.vocab.org/terms/national-grid-reference.html</seealso>
    let ``national_grid_reference.html`` =
        Prefixed_Name(open_, "national-grid-reference.html") |> PrefixedName

    /// <summary>
    ///   <para>open:nationalContextMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This property is a relationship between some thing and a map that shows that thing's location at a national scale."</para>
    /// labels<para>"National Context Map"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/nationalContextMap">http://open.vocab.org/terms/nationalContextMap</seealso>
    let nationalContextMap = Prefixed_Name(open_, "nationalContextMap") |> PrefixedName

    /// <summary>
    ///   <para>open:nationalContextMap.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/nationalContextMap.html">http://open.vocab.org/terms/nationalContextMap.html</seealso>
    let ``nationalContextMap.html`` =
        Prefixed_Name(open_, "nationalContextMap.html") |> PrefixedName

    /// <summary>
    ///   <para>open:near</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"x is 'near' y if they are near to each other in physical space, for a deliberately vague notion of near."</para>
    /// labels<para>"Near"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/near">http://open.vocab.org/terms/near</seealso>
    let near = Prefixed_Name(open_, "near") |> PrefixedName
    /// <summary>
    ///   <para>open:networkVisibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The desired visibility of a User's social network. Suggested options: "Just Me", "My Network", "Everyone"."</para>
    /// labels<para>"Network Visibility"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/networkVisibility">http://open.vocab.org/terms/networkVisibility</seealso>
    let networkVisibility = Prefixed_Name(open_, "networkVisibility") |> PrefixedName

    /// <summary>
    ///   <para>open:networkVisibility.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/networkVisibility.html">http://open.vocab.org/terms/networkVisibility.html</seealso>
    let ``networkVisibility.html`` =
        Prefixed_Name(open_, "networkVisibility.html") |> PrefixedName

    /// <summary>
    ///   <para>open:noOfReviewsWritten</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"a total count of the number of resources of type &lt;http://purl.org/stuff/rev#Review&gt; that an Agent is known to have created "</para>
    /// labels<para>"Number of Reviews Written"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/noOfReviewsWritten">http://open.vocab.org/terms/noOfReviewsWritten</seealso>
    let noOfReviewsWritten = Prefixed_Name(open_, "noOfReviewsWritten") |> PrefixedName

    /// <summary>
    ///   <para>open:noOfReviewsWritten.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/noOfReviewsWritten.html">http://open.vocab.org/terms/noOfReviewsWritten.html</seealso>
    let ``noOfReviewsWritten.html`` =
        Prefixed_Name(open_, "noOfReviewsWritten.html") |> PrefixedName

    /// <summary>
    ///   <para>open:numberOfPages</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The number of pages a resource has"</para>
    /// labels<para>"Number of Pages"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/numberOfPages">http://open.vocab.org/terms/numberOfPages</seealso>
    let numberOfPages = Prefixed_Name(open_, "numberOfPages") |> PrefixedName

    /// <summary>
    ///   <para>open:numberOfPages.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/numberOfPages.html">http://open.vocab.org/terms/numberOfPages.html</seealso>
    let ``numberOfPages.html`` =
        Prefixed_Name(open_, "numberOfPages.html") |> PrefixedName

    /// <summary>
    ///   <para>open:offeredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>"Organization who offers the course, e.g. a department, a school, a research institute"</para>
    /// labels<para>"Offering organization"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/offeredBy">http://open.vocab.org/terms/offeredBy</seealso>
    let offeredBy = Prefixed_Name(open_, "offeredBy") |> PrefixedName
    /// <summary>
    ///   <para>open:offersCourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>"Course offered by the organization"</para>
    /// labels<para>"Offered course"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/offersCourse">http://open.vocab.org/terms/offersCourse</seealso>
    let offersCourse = Prefixed_Name(open_, "offersCourse") |> PrefixedName
    /// <summary>
    ///   <para>open:okkamID</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"the okkam ID of the entity, given in human legible form (literal)"</para>
    /// labels<para>"Okkam ID"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/okkamID">http://open.vocab.org/terms/okkamID</seealso>
    let okkamID = Prefixed_Name(open_, "okkamID") |> PrefixedName
    /// <summary>
    ///   <para>open:okkamID.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/okkamID.html">http://open.vocab.org/terms/okkamID.html</seealso>
    let ``okkamID.html`` = Prefixed_Name(open_, "okkamID.html") |> PrefixedName
    /// <summary>
    ///   <para>open:origin</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The source of a thing."</para>
    /// labels<para>"Origin"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/origin">http://open.vocab.org/terms/origin</seealso>
    let origin = Prefixed_Name(open_, "origin") |> PrefixedName
    /// <summary>
    ///   <para>open:origin.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/origin.html">http://open.vocab.org/terms/origin.html</seealso>
    let ``origin.html`` = Prefixed_Name(open_, "origin.html") |> PrefixedName
    /// <summary>
    ///   <para>open:originatesFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A thing that came into existence at a place and time originates from that place and time."</para>
    /// labels<para>"Originally from time and place"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/originatesFrom">http://open.vocab.org/terms/originatesFrom</seealso>
    let originatesFrom = Prefixed_Name(open_, "originatesFrom") |> PrefixedName

    /// <summary>
    ///   <para>open:originatesFrom.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/originatesFrom.html">http://open.vocab.org/terms/originatesFrom.html</seealso>
    let ``originatesFrom.html`` =
        Prefixed_Name(open_, "originatesFrom.html") |> PrefixedName

    /// <summary>
    ///   <para>open:part</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"An element of a whole."</para>
    /// labels<para>"Part"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/part">http://open.vocab.org/terms/part</seealso>
    let part = Prefixed_Name(open_, "part") |> PrefixedName
    /// <summary>
    ///   <para>open:part.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/part.html">http://open.vocab.org/terms/part.html</seealso>
    let ``part.html`` = Prefixed_Name(open_, "part.html") |> PrefixedName
    /// <summary>
    ///   <para>open:passwd</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"a password usually stored in md5"</para>
    /// labels<para>"Password"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/passwd">http://open.vocab.org/terms/passwd</seealso>
    let passwd = Prefixed_Name(open_, "passwd") |> PrefixedName
    /// <summary>
    ///   <para>open:passwd.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/passwd.html">http://open.vocab.org/terms/passwd.html</seealso>
    let ``passwd.html`` = Prefixed_Name(open_, "passwd.html") |> PrefixedName
    /// <summary>
    ///   <para>open:performer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"7dFHvo  &lt;a href="http://nussehqldled.com/"&gt;nussehqldled&lt;/a&gt;, [url=http://uvurwqyxjgik.com/]uvurwqyxjgik[/url], [link=http://yqeuzuciwezi.com/]yqeuzuciwezi[/link], http://sdzwxhzsaaqq.com/"</para>
    /// labels<para>"Performer"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/performer">http://open.vocab.org/terms/performer</seealso>
    let performer = Prefixed_Name(open_, "performer") |> PrefixedName
    /// <summary>
    ///   <para>open:performer.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/performer.html">http://open.vocab.org/terms/performer.html</seealso>
    let ``performer.html`` = Prefixed_Name(open_, "performer.html") |> PrefixedName
    /// <summary>
    ///   <para>open:phoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A telephone number that can be used to contact a Person or Organisation."</para>
    /// labels<para>"Phone Number"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/phoneNumber">http://open.vocab.org/terms/phoneNumber</seealso>
    let phoneNumber = Prefixed_Name(open_, "phoneNumber") |> PrefixedName
    /// <summary>
    ///   <para>open:plot</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A plot of anything."</para>
    /// labels<para>"Plot"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/plot">http://open.vocab.org/terms/plot</seealso>
    let plot = Prefixed_Name(open_, "plot") |> PrefixedName
    /// <summary>
    ///   <para>open:plot.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/plot.html">http://open.vocab.org/terms/plot.html</seealso>
    let ``plot.html`` = Prefixed_Name(open_, "plot.html") |> PrefixedName
    /// <summary>
    ///   <para>open:postalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A postal address to which letters and parcels can be sent to a Person or Organisation."</para>
    /// labels<para>"Postal Address"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/postalAddress">http://open.vocab.org/terms/postalAddress</seealso>
    let postalAddress = Prefixed_Name(open_, "postalAddress") |> PrefixedName
    /// <summary>
    ///   <para>open:prefAcronym</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Preferred or official acronym as used by the subject."</para>
    /// labels<para>"preferred acronym"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/prefAcronym">http://open.vocab.org/terms/prefAcronym</seealso>
    let prefAcronym = Prefixed_Name(open_, "prefAcronym") |> PrefixedName
    /// <summary>
    ///   <para>open:prefAcronym.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/prefAcronym.html">http://open.vocab.org/terms/prefAcronym.html</seealso>
    let ``prefAcronym.html`` = Prefixed_Name(open_, "prefAcronym.html") |> PrefixedName
    /// <summary>
    ///   <para>open:preferredAnimal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The preferred animal of a person."</para>
    /// labels<para>"Preferred animal"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/preferredAnimal">http://open.vocab.org/terms/preferredAnimal</seealso>
    let preferredAnimal = Prefixed_Name(open_, "preferredAnimal") |> PrefixedName
    /// <summary>
    ///   <para>open:primaryMaterial</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The primary material from which something is made.
    ///
    /// Examples: leather (shoe), paper (book), cotton (t-shirt), nylon (tights), plastic (carrier bag), rubber (wellington boots), iron (pipe) etc."</para>
    /// labels<para>"primary material"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/primaryMaterial">http://open.vocab.org/terms/primaryMaterial</seealso>
    let primaryMaterial = Prefixed_Name(open_, "primaryMaterial") |> PrefixedName
    /// <summary>
    ///   <para>open:provenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"It is about provenance of web data."</para>
    /// labels<para>"provenance"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/provenance">http://open.vocab.org/terms/provenance</seealso>
    let provenance = Prefixed_Name(open_, "provenance") |> PrefixedName
    /// <summary>
    ///   <para>open:quote</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/quote">http://open.vocab.org/terms/quote</seealso>
    let quote = Prefixed_Name(open_, "quote") |> PrefixedName
    /// <summary>
    ///   <para>open:rank</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The rank of the resource within the ordered collection represented by the current document"</para>
    /// labels<para>"rank"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/rank">http://open.vocab.org/terms/rank</seealso>
    let rank = Prefixed_Name(open_, "rank") |> PrefixedName
    /// <summary>
    ///   <para>open:rank.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/rank.html">http://open.vocab.org/terms/rank.html</seealso>
    let ``rank.html`` = Prefixed_Name(open_, "rank.html") |> PrefixedName
    /// <summary>
    ///   <para>open:readGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"express the ability/right to read from a graph"</para>
    /// labels<para>"Read Graph"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/readGraph">http://open.vocab.org/terms/readGraph</seealso>
    let readGraph = Prefixed_Name(open_, "readGraph") |> PrefixedName
    /// <summary>
    ///   <para>open:readGraph.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/readGraph.html">http://open.vocab.org/terms/readGraph.html</seealso>
    let ``readGraph.html`` = Prefixed_Name(open_, "readGraph.html") |> PrefixedName
    /// <summary>
    ///   <para>open:recordedAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A property to capture an un-intepreted written address, notably for addresses that have yet to be or can never be semantically represented using an existing scheme, such as the vcard ontology."</para>
    /// labels<para>"recorded address"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/recordedAddress">http://open.vocab.org/terms/recordedAddress</seealso>
    let recordedAddress = Prefixed_Name(open_, "recordedAddress") |> PrefixedName
    /// <summary>
    ///   <para>open:regionalContextMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This property is a relationship between some thing and a map that shows that thing's location at a regional scale."</para>
    /// labels<para>"Regional Context Map"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/regionalContextMap">http://open.vocab.org/terms/regionalContextMap</seealso>
    let regionalContextMap = Prefixed_Name(open_, "regionalContextMap") |> PrefixedName

    /// <summary>
    ///   <para>open:regionalContextMap.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/regionalContextMap.html">http://open.vocab.org/terms/regionalContextMap.html</seealso>
    let ``regionalContextMap.html`` =
        Prefixed_Name(open_, "regionalContextMap.html") |> PrefixedName

    /// <summary>
    ///   <para>open:reincarnationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Defines reincarnation of someone"</para>
    /// labels<para>"Reincarnation of an Individual"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/reincarnationOf">http://open.vocab.org/terms/reincarnationOf</seealso>
    let reincarnationOf = Prefixed_Name(open_, "reincarnationOf") |> PrefixedName
    /// <summary>
    ///   <para>open:responsiblityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Organization who is responsible for (offers) the course. Like a department, a school..."</para>
    /// labels<para>"Responsible organization"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/responsiblityOf">http://open.vocab.org/terms/responsiblityOf</seealso>
    let responsiblityOf = Prefixed_Name(open_, "responsiblityOf") |> PrefixedName
    /// <summary>
    ///   <para>open:resultFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The result of the test case obtained from the target specified. For example, the target could be a script that is executed."</para>
    /// labels<para>"result from"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/resultFrom">http://open.vocab.org/terms/resultFrom</seealso>
    let resultFrom = Prefixed_Name(open_, "resultFrom") |> PrefixedName
    /// <summary>
    ///   <para>open:rimDiameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The diameter of a thing measured at its rim."</para>
    /// labels<para>"Diameter at rim"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/rimDiameter">http://open.vocab.org/terms/rimDiameter</seealso>
    let rimDiameter = Prefixed_Name(open_, "rimDiameter") |> PrefixedName
    /// <summary>
    ///   <para>open:rimDiameter.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/rimDiameter.html">http://open.vocab.org/terms/rimDiameter.html</seealso>
    let ``rimDiameter.html`` = Prefixed_Name(open_, "rimDiameter.html") |> PrefixedName
    /// <summary>
    ///   <para>open:rtfm</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/rtfm">http://open.vocab.org/terms/rtfm</seealso>
    let rtfm = Prefixed_Name(open_, "rtfm") |> PrefixedName
    /// <summary>
    ///   <para>open:screenshot</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A screenshot showing the (software) project in action. Since DOAP only has a property to link a "web page with screenshots of project", not a specific screenshot, this property is sometimes more useful."</para>
    /// labels<para>"screenshot"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/screenshot">http://open.vocab.org/terms/screenshot</seealso>
    let screenshot = Prefixed_Name(open_, "screenshot") |> PrefixedName
    /// <summary>
    ///   <para>open:semester</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Semester in which the course is offered"</para>
    /// labels<para>"Semester"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/semester">http://open.vocab.org/terms/semester</seealso>
    let semester = Prefixed_Name(open_, "semester") |> PrefixedName
    /// <summary>
    ///   <para>open:shape</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The shape of something"</para>
    /// labels<para>"Shape"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/shape">http://open.vocab.org/terms/shape</seealso>
    let shape = Prefixed_Name(open_, "shape") |> PrefixedName
    /// <summary>
    ///   <para>open:shape.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/shape.html">http://open.vocab.org/terms/shape.html</seealso>
    let ``shape.html`` = Prefixed_Name(open_, "shape.html") |> PrefixedName
    /// <summary>
    ///   <para>open:shortName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Just a simple readable name, a mnemonic. "</para>
    /// labels<para>"Short Name"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/shortName">http://open.vocab.org/terms/shortName</seealso>
    let shortName = Prefixed_Name(open_, "shortName") |> PrefixedName
    /// <summary>
    ///   <para>open:shortName.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/shortName.html">http://open.vocab.org/terms/shortName.html</seealso>
    let ``shortName.html`` = Prefixed_Name(open_, "shortName.html") |> PrefixedName
    /// <summary>
    ///   <para>open:signatureScent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Relate a thing (usually a person) to the scent with which they are most commonly associated."</para>
    /// labels<para>"Signature Scent"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/signatureScent">http://open.vocab.org/terms/signatureScent</seealso>
    let signatureScent = Prefixed_Name(open_, "signatureScent") |> PrefixedName
    /// <summary>
    ///   <para>open:similarTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"Having two things that are not the owl:sameAs but are similar to a certain extent. It is thought of being used where owl:sameAs is too strong but rdfs:seeAlso is too loose. Motivation: http://lists.w3.org/Archives/Public/public-lod/2009Feb/0189.html"</para>
    /// labels<para>"similar to"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/similarTo">http://open.vocab.org/terms/similarTo</seealso>
    let similarTo = Prefixed_Name(open_, "similarTo") |> PrefixedName
    /// <summary>
    ///   <para>open:sindiceResultCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The number of results retrieved for a search on that uri from the Search Engine sindice"</para>
    /// labels<para>"Sindice Result Count"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/sindiceResultCount">http://open.vocab.org/terms/sindiceResultCount</seealso>
    let sindiceResultCount = Prefixed_Name(open_, "sindiceResultCount") |> PrefixedName

    /// <summary>
    ///   <para>open:sindiceResultCount.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/sindiceResultCount.html">http://open.vocab.org/terms/sindiceResultCount.html</seealso>
    let ``sindiceResultCount.html`` =
        Prefixed_Name(open_, "sindiceResultCount.html") |> PrefixedName

    /// <summary>
    ///   <para>open:skypeID</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>"Someone's ID in the Skype chat and telephony service."</para>
    /// labels<para>"Skype ID"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/skypeID">http://open.vocab.org/terms/skypeID</seealso>
    let skypeID = Prefixed_Name(open_, "skypeID") |> PrefixedName
    /// <summary>
    ///   <para>open:skypeID.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/skypeID.html">http://open.vocab.org/terms/skypeID.html</seealso>
    let ``skypeID.html`` = Prefixed_Name(open_, "skypeID.html") |> PrefixedName
    /// <summary>
    ///   <para>open:sort-name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Associate a name that can be used for sorting to a foaf:Agent"</para>
    /// labels<para>"Sort name"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/sort-name">http://open.vocab.org/terms/sort-name</seealso>
    let sort_name = Prefixed_Name(open_, "sort-name") |> PrefixedName
    /// <summary>
    ///   <para>open:sort-name.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/sort-name.html">http://open.vocab.org/terms/sort-name.html</seealso>
    let ``sort_name.html`` = Prefixed_Name(open_, "sort-name.html") |> PrefixedName
    /// <summary>
    ///   <para>open:sortLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A label for a resource that is syntactically arranged to be suitable for sorting"</para>
    /// labels<para>"Sort Label"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/sortLabel">http://open.vocab.org/terms/sortLabel</seealso>
    let sortLabel = Prefixed_Name(open_, "sortLabel") |> PrefixedName
    /// <summary>
    ///   <para>open:sortLabel.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/sortLabel.html">http://open.vocab.org/terms/sortLabel.html</seealso>
    let ``sortLabel.html`` = Prefixed_Name(open_, "sortLabel.html") |> PrefixedName
    /// <summary>
    ///   <para>open:sourcefile</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"associates a given feature file document with the audio file that is described by that document"</para>
    /// labels<para>"Source File"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/sourcefile">http://open.vocab.org/terms/sourcefile</seealso>
    let sourcefile = Prefixed_Name(open_, "sourcefile") |> PrefixedName
    /// <summary>
    ///   <para>open:sourcefile.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/sourcefile.html">http://open.vocab.org/terms/sourcefile.html</seealso>
    let ``sourcefile.html`` = Prefixed_Name(open_, "sourcefile.html") |> PrefixedName
    /// <summary>
    ///   <para>open:specification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The specification(s) that the resource implemented. "</para>
    /// labels<para>"Specification"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/specification">http://open.vocab.org/terms/specification</seealso>
    let specification = Prefixed_Name(open_, "specification") |> PrefixedName

    /// <summary>
    ///   <para>open:specification.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/specification.html">http://open.vocab.org/terms/specification.html</seealso>
    let ``specification.html`` =
        Prefixed_Name(open_, "specification.html") |> PrefixedName

    /// <summary>
    ///   <para>open:startTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The time of day that something starts at."</para>
    /// labels<para>"Start Time"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/startTime">http://open.vocab.org/terms/startTime</seealso>
    let startTime = Prefixed_Name(open_, "startTime") |> PrefixedName
    /// <summary>
    ///   <para>open:startTime.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/startTime.html">http://open.vocab.org/terms/startTime.html</seealso>
    let ``startTime.html`` = Prefixed_Name(open_, "startTime.html") |> PrefixedName
    /// <summary>
    ///   <para>open:statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Asserts that a reified rdf:Statement is asserted (in a non-reified form) by a particular RDF graph."</para>
    /// labels<para>"statement"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/statement">http://open.vocab.org/terms/statement</seealso>
    let statement = Prefixed_Name(open_, "statement") |> PrefixedName
    /// <summary>
    ///   <para>open:statement.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/statement.html">http://open.vocab.org/terms/statement.html</seealso>
    let ``statement.html`` = Prefixed_Name(open_, "statement.html") |> PrefixedName
    /// <summary>
    ///   <para>open:status</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A human readable description of the status of an opmv:Process upon completion."</para>
    /// labels<para>"Status"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/status">http://open.vocab.org/terms/status</seealso>
    let status = Prefixed_Name(open_, "status") |> PrefixedName
    /// <summary>
    ///   <para>open:stickiness</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The the measure of how sticky something is"</para>
    /// labels<para>"Stickiness"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/stickiness">http://open.vocab.org/terms/stickiness</seealso>
    let stickiness = Prefixed_Name(open_, "stickiness") |> PrefixedName
    /// <summary>
    ///   <para>open:stickiness.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/stickiness.html">http://open.vocab.org/terms/stickiness.html</seealso>
    let ``stickiness.html`` = Prefixed_Name(open_, "stickiness.html") |> PrefixedName
    /// <summary>
    ///   <para>open:studies</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A topic or work that is studied by a person or group (e.g., a university course)"</para>
    /// labels<para>"studies"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/studies">http://open.vocab.org/terms/studies</seealso>
    let studies = Prefixed_Name(open_, "studies") |> PrefixedName
    /// <summary>
    ///   <para>open:studies.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/studies.html">http://open.vocab.org/terms/studies.html</seealso>
    let ``studies.html`` = Prefixed_Name(open_, "studies.html") |> PrefixedName
    /// <summary>
    ///   <para>open:subtitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An additional or secondary title usually used expand or limit the main title"</para>
    /// labels<para>"Subtitle"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/subtitle">http://open.vocab.org/terms/subtitle</seealso>
    let subtitle = Prefixed_Name(open_, "subtitle") |> PrefixedName
    /// <summary>
    ///   <para>open:subtitle.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/subtitle.html">http://open.vocab.org/terms/subtitle.html</seealso>
    let ``subtitle.html`` = Prefixed_Name(open_, "subtitle.html") |> PrefixedName
    /// <summary>
    ///   <para>open:suffersEarworm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Relates a person to an earworm that they suffer."</para>
    /// labels<para>"Suffers Earworm"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/suffersEarworm">http://open.vocab.org/terms/suffersEarworm</seealso>
    let suffersEarworm = Prefixed_Name(open_, "suffersEarworm") |> PrefixedName
    /// <summary>
    ///   <para>open:syndicates</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An agent syndicates a document some way."</para>
    /// labels<para>"syndicates"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/syndicates">http://open.vocab.org/terms/syndicates</seealso>
    let syndicates = Prefixed_Name(open_, "syndicates") |> PrefixedName
    /// <summary>
    ///   <para>open:taggingCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"the number of times a tag has been used in taggings of things"</para>
    /// labels<para>"Tagging Count"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/taggingCount">http://open.vocab.org/terms/taggingCount</seealso>
    let taggingCount = Prefixed_Name(open_, "taggingCount") |> PrefixedName

    /// <summary>
    ///   <para>open:taggingCount.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/taggingCount.html">http://open.vocab.org/terms/taggingCount.html</seealso>
    let ``taggingCount.html`` =
        Prefixed_Name(open_, "taggingCount.html") |> PrefixedName

    /// <summary>
    ///   <para>open:teaches</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Teaches"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/teaches">http://open.vocab.org/terms/teaches</seealso>
    let teaches = Prefixed_Name(open_, "teaches") |> PrefixedName
    /// <summary>
    ///   <para>open:teaches.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/teaches.html">http://open.vocab.org/terms/teaches.html</seealso>
    let ``teaches.html`` = Prefixed_Name(open_, "teaches.html") |> PrefixedName
    /// <summary>
    ///   <para>open:test</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/test">http://open.vocab.org/terms/test</seealso>
    let test = Prefixed_Name(open_, "test") |> PrefixedName
    /// <summary>
    ///   <para>open:twitter-id</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///
    /// labels<para>"Twitter ID"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/twitter-id">http://open.vocab.org/terms/twitter-id</seealso>
    let twitter_id = Prefixed_Name(open_, "twitter-id") |> PrefixedName
    /// <summary>
    ///   <para>open:twitter-id.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/twitter-id.html">http://open.vocab.org/terms/twitter-id.html</seealso>
    let ``twitter_id.html`` = Prefixed_Name(open_, "twitter-id.html") |> PrefixedName
    /// <summary>
    ///   <para>open:usedHost</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An Internet host used in the context of an opmv:Process."</para>
    /// labels<para>"Used Host"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/usedHost">http://open.vocab.org/terms/usedHost</seealso>
    let usedHost = Prefixed_Name(open_, "usedHost") |> PrefixedName
    /// <summary>
    ///   <para>open:usedHttpHeader</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The subject (perhaps a foaf:Agent) made HTTP requests with a header described by this http:MessageHeader resource."</para>
    /// labels<para>"Used HTTP Header"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/usedHttpHeader">http://open.vocab.org/terms/usedHttpHeader</seealso>
    let usedHttpHeader = Prefixed_Name(open_, "usedHttpHeader") |> PrefixedName
    /// <summary>
    ///   <para>open:uses</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"links to a thing used by an agent"</para>
    /// labels<para>"uses"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/uses">http://open.vocab.org/terms/uses</seealso>
    let uses = Prefixed_Name(open_, "uses") |> PrefixedName
    /// <summary>
    ///   <para>open:uses.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/uses.html">http://open.vocab.org/terms/uses.html</seealso>
    let ``uses.html`` = Prefixed_Name(open_, "uses.html") |> PrefixedName
    /// <summary>
    ///   <para>open:validFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To mark the beginning date or event at which the named graph object is true/accurate."</para>
    /// labels<para>"is valid from"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/validFrom">http://open.vocab.org/terms/validFrom</seealso>
    let validFrom = Prefixed_Name(open_, "validFrom") |> PrefixedName
    /// <summary>
    ///   <para>open:validFrom.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/validFrom.html">http://open.vocab.org/terms/validFrom.html</seealso>
    let ``validFrom.html`` = Prefixed_Name(open_, "validFrom.html") |> PrefixedName
    /// <summary>
    ///   <para>open:validUntil</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To mark the date or event at which the named graph object ceases to be accurate."</para>
    /// labels<para>"is valid until"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/validUntil">http://open.vocab.org/terms/validUntil</seealso>
    let validUntil = Prefixed_Name(open_, "validUntil") |> PrefixedName
    /// <summary>
    ///   <para>open:validUntil.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/validUntil.html">http://open.vocab.org/terms/validUntil.html</seealso>
    let ``validUntil.html`` = Prefixed_Name(open_, "validUntil.html") |> PrefixedName
    /// <summary>
    ///   <para>open:versionnumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Property to encode the version of things - simple intent, to record the sequence of items. (The items themselves will have temporal/finer grained detail)"</para>
    /// labels<para>"Version Number"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/versionnumber">http://open.vocab.org/terms/versionnumber</seealso>
    let versionnumber = Prefixed_Name(open_, "versionnumber") |> PrefixedName

    /// <summary>
    ///   <para>open:versionnumber.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/versionnumber.html">http://open.vocab.org/terms/versionnumber.html</seealso>
    let ``versionnumber.html`` =
        Prefixed_Name(open_, "versionnumber.html") |> PrefixedName

    /// <summary>
    ///   <para>open:visibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The visibility of a resource (e.g. public, internal), expressed as a literal term."</para>
    /// labels<para>"visibility"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/visibility">http://open.vocab.org/terms/visibility</seealso>
    let visibility = Prefixed_Name(open_, "visibility") |> PrefixedName
    /// <summary>
    ///   <para>open:weight</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The weight of a resource"</para>
    /// labels<para>"Weight"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/weight">http://open.vocab.org/terms/weight</seealso>
    let weight = Prefixed_Name(open_, "weight") |> PrefixedName
    /// <summary>
    ///   <para>open:weight.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/weight.html">http://open.vocab.org/terms/weight.html</seealso>
    let ``weight.html`` = Prefixed_Name(open_, "weight.html") |> PrefixedName
    /// <summary>
    ///   <para>open:wikiPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A wiki page associated with this resource"</para>
    /// labels<para>"Wiki Page"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/wikiPage">http://open.vocab.org/terms/wikiPage</seealso>
    let wikiPage = Prefixed_Name(open_, "wikiPage") |> PrefixedName
    /// <summary>
    ///   <para>open:writeGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"express the ability/right to write to a graph"</para>
    /// labels<para>"Write Graph"</para></remarks>
    /// <seealso href="http://open.vocab.org/terms/writeGraph">http://open.vocab.org/terms/writeGraph</seealso>
    let writeGraph = Prefixed_Name(open_, "writeGraph") |> PrefixedName
    /// <summary>
    ///   <para>open:writeGraph.html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open.vocab.org/terms/writeGraph.html">http://open.vocab.org/terms/writeGraph.html</seealso>
    let ``writeGraph.html`` = Prefixed_Name(open_, "writeGraph.html") |> PrefixedName

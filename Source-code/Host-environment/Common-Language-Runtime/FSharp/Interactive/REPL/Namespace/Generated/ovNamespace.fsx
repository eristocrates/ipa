#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ov =
    let _prefixId = PrefixId.fromNamespaceLabel "http://open.vocab.org/terms/" "ov"
    /// <summary>
    ///   <para>ov:markdownDescription : Identifies the ware of any African Red-Slip vessel.</para>
    ///   <para>rdfs:label : African Red Slip</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : 9bb5567d-9f87-47cd-8f0d-2ed0f9fbd24f^^xsd:string</para>
    ///   <para>rdfs:comment : The ceramic ware produced during the Roman period in the region of what is now the modern country of Tunisia.</para>
    ///   <a href="http://open.vocab.org/terms/AfricanRedSlip">ov:AfricanRedSlip</a>
    /// </summary>
    let AfricanRedSlip = _prefixId.prefix "AfricanRedSlip"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dce:created : 2010-06-25T17:28:25Z^^xsd:dateTime</para>
    ///   <para>rdfs:label : An event that is a contact between two AmateurRadioOperators</para>
    ///   <para>label:plural : Events that are a contact between two AmateurRadioOperators</para>
    ///   <para>rdfs:comment : It is a major goal of Amateur Radio Operators to make contact with each other.  This contact is formally defined as the exchange of certain information, usually consisting of each operator's call sign and a signal report (how well each operator receives the signal of the other).  A contact can last a few seconds to many minutes.  Nickname "QSL".</para>
    ///   <a href="http://open.vocab.org/terms/AmateurRadioContact">ov:AmateurRadioContact</a>
    /// </summary>
    let AmateurRadioContact = _prefixId.prefix "AmateurRadioContact"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Amateur Radio Operator</para>
    ///   <para>rdfs:comment : A person who is licensed in at least one ITU region to operate (transmit and receive) a radio using frequencies and modes permitted only  to licensed persons.</para>
    ///   <para>dce:created : 2010-06-25T16:45:26Z^^xsd:dateTime</para>
    ///   <para>label:plural : Amateur Radio Operators</para>
    ///   <a href="http://open.vocab.org/terms/AmateurRadioOperator">ov:AmateurRadioOperator</a>
    /// </summary>
    let AmateurRadioOperator = _prefixId.prefix "AmateurRadioOperator"
    /// <summary>
    ///   <para>rdfs:label : Annotation Set</para>
    ///   <para>rdfs:comment : A type of dataset that contains annotations on a set of resources.</para>
    ///   <para>dce:created : 2010-06-08T23:54:47Z^^xsd:dateTime</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>label:plural : Annotation Sets</para>
    ///   <a href="http://open.vocab.org/terms/AnnotationSet">ov:AnnotationSet</a>
    /// </summary>
    let AnnotationSet = _prefixId.prefix "AnnotationSet"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Automobile Catalog Type</para>
    ///   <para>rdfs:comment : Automobiles, when presented as a catalog, are generally categorized using the Car Maker / Car Model / Trim Package hierarchy.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "48cdcf7d-9cf6-4ea7-95a9-4792e564882d"^^xsd:string</para>
    ///   <para>label:plural : Automobile Catalog Types</para>
    ///   <a href="http://open.vocab.org/terms/AutomobileCataologType">ov:AutomobileCataologType</a>
    /// </summary>
    let AutomobileCataologType = _prefixId.prefix "AutomobileCataologType"
    let ``AutomobileCataologType.html`` = _prefixId.prefix "AutomobileCataologType.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Automobile Model</para>
    ///   <para>rdfs:comment : From en.wikipedia.org:
    /// "A car model is a particular brand of vehicle sold under a marque. From an engineering point of view, a particular car model is usually defined and/or constrained by the use of a particular car chassis/bodywork combination or the same monocoque."</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "3ff64331-76bf-48aa-8274-a5d770e52376"^^xsd:string</para>
    ///   <para>label:plural : Automobile Models</para>
    ///   <a href="http://open.vocab.org/terms/AutomobileModel">ov:AutomobileModel</a>
    /// </summary>
    let AutomobileModel = _prefixId.prefix "AutomobileModel"
    let ``AutomobileModel.html`` = _prefixId.prefix "AutomobileModel.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : General Trait of Characters in the Animated Series Avatar-The Last Airbender</para>
    ///   <para>rdfs:comment : This class of character traits was created to describe the characters in the graphic novel Avatar-The Last Airbender.
    /// The motivation was to create a unique class identifying the characters in the trilogy.</para>
    ///   <para>label:plural : General Trait of Characters in the Animated Series Avatar-The Last Airbender</para>
    ///   <para>dce:created : 2011-03-22T17:22:00Z^^xsd:dateTime</para>
    ///   <a href="http://open.vocab.org/terms/AvatarCharacterTraits">ov:AvatarCharacterTraits</a>
    /// </summary>
    let AvatarCharacterTraits = _prefixId.prefix "AvatarCharacterTraits"
    /// <summary>
    ///   <para>ov:markdownDescription : A Database for Biologists (Bioinformatics)</para>
    ///   <para>rdfs:comment : Database for Biologists (Bioinformatics)</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "40782fae-0f4c-44d7-aa93-d14b7fd2b04a"^^xsd:string</para>
    ///   <para>rdfs:label : Biological Database</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>label:plural : Biological Databases</para>
    ///   <a href="http://open.vocab.org/terms/BiologicalDatabase">ov:BiologicalDatabase</a>
    /// </summary>
    let BiologicalDatabase = _prefixId.prefix "BiologicalDatabase"
    let ``BiologicalDatabase.html`` = _prefixId.prefix "BiologicalDatabase.html"
    /// <summary>
    ///   <para>rdfs:label : Birth</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Birth class</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "305dfbd5-de80-4237-8e8a-19628893ff87"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/Birth">ov:Birth</a>
    /// </summary>
    let Birth = _prefixId.prefix "Birth"
    let ``Birth.html`` = _prefixId.prefix "Birth.html"
    let Borrower = _prefixId.prefix "Borrower"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Calendar</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "772fef82-9a62-4040-afac-80149a2de2b3"^^xsd:string</para>
    ///   <para>label:plural : Calendars</para>
    ///   <a href="http://open.vocab.org/terms/Calendar">ov:Calendar</a>
    /// </summary>
    let Calendar = _prefixId.prefix "Calendar"
    let ``Calendar.html`` = _prefixId.prefix "Calendar.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Cheese</para>
    ///   <para>rdfs:comment : Cheese is a food made from milk, usually the milk of cows, buffalo, goats, or sheep, by coagulation. </para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "25455282-4ad8-4515-b3da-49185e075fc1"^^xsd:string</para>
    ///   <para>label:plural : Cheeses</para>
    ///   <a href="http://open.vocab.org/terms/Cheese">ov:Cheese</a>
    /// </summary>
    let Cheese = _prefixId.prefix "Cheese"
    let ``Cheese.html`` = _prefixId.prefix "Cheese.html"
    /// <summary>
    ///   <para>rdfs:comment : Members of this class represent class skeletons which are sort of templates of a class.
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
    /// http://www.w3.org/TR/owl2-primer/#Property_Restrictions</para>
    ///   <para>rdfs:label : Class Skeleton</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : b5031dc2-fcd7-4d33-b05c-d600b00600f9^^xsd:string</para>
    ///   <para>label:plural : class skeletons</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/ClassSkeleton">ov:ClassSkeleton</a>
    /// </summary>
    let ClassSkeleton = _prefixId.prefix "ClassSkeleton"
    let Colors = _prefixId.prefix "Colors"
    /// <summary>
    ///   <para>rdfs:label : Country</para>
    ///   <para>dce:created : 2011-10-25T14:34:06Z^^xsd:dateTime</para>
    ///   <para>label:plural : Countries</para>
    ///   <para>rdfs:comment : A country is a geographical region. A country may be the territory of a sovereign state, the territory of a non-sovereign (or formerly sovereign) political division, or a region associated with a certain people or certain characteristics.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/Country">ov:Country</a>
    /// </summary>
    let Country = _prefixId.prefix "Country"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Course</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "caec9189-b5dc-43c1-a1b1-3ab2f73c21ee"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/Course">ov:Course</a>
    /// </summary>
    let Course = _prefixId.prefix "Course"
    let ``Course.html`` = _prefixId.prefix "Course.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : DOMBoundaryPoint</para>
    ///   <para>rdfs:comment : A boundary-point's position in a Document or DocumentFragment tree can be characterized by a node and an offset.
    /// http://www.w3.org/TR/2000/REC-DOM-Level-2-Traversal-Range-20001113/ranges.html#Level-2-Range-Definitions</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "63b8cdd0-a5bf-4c9c-b229-8bab040a4797"^^xsd:string</para>
    ///   <para>label:plural : DOMBoundaryPoints</para>
    ///   <a href="http://open.vocab.org/terms/DOMBoundaryPoint">ov:DOMBoundaryPoint</a>
    /// </summary>
    let DOMBoundaryPoint = _prefixId.prefix "DOMBoundaryPoint"
    let ``DOMBoundaryPoint.html`` = _prefixId.prefix "DOMBoundaryPoint.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : DOMBoundaryPointPosition</para>
    ///   <para>rdfs:comment : A boundary-point's position in a Document or DocumentFragment tree can be characterized by a node and an offset
    ///
    /// http://www.w3.org/TR/2000/REC-DOM-Level-2-Traversal-Range-20001113/ranges.html#Level-2-Range-Definitions</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "7b174e16-0fdf-47e5-9d7e-85cdcc367903"^^xsd:string</para>
    ///   <para>label:plural : DOMBoundaryPointPositions</para>
    ///   <a href="http://open.vocab.org/terms/DOMBoundaryPointPosition">ov:DOMBoundaryPointPosition</a>
    /// </summary>
    let DOMBoundaryPointPosition = _prefixId.prefix "DOMBoundaryPointPosition"

    let ``DOMBoundaryPointPosition.html`` =
        _prefixId.prefix "DOMBoundaryPointPosition.html"

    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : DOMNode</para>
    ///   <para>rdfs:comment : DOMNode can be a Attribute, Document, DocumentFragment, Element or EntityReference node.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "f234d851-4c0f-4dae-ae7a-a85f8bbbfdfc"^^xsd:string</para>
    ///   <para>label:plural : DOMNodes</para>
    ///   <a href="http://open.vocab.org/terms/DOMNode">ov:DOMNode</a>
    /// </summary>
    let DOMNode = _prefixId.prefix "DOMNode"
    let ``DOMNode.html`` = _prefixId.prefix "DOMNode.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : DOMOffset</para>
    ///   <para>rdfs:comment : the offset within a DOM node</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "73c4a8f2-68f1-4a7b-b483-bda0c29bacfc"^^xsd:string</para>
    ///   <para>label:plural : Offsets</para>
    ///   <a href="http://open.vocab.org/terms/DOMOffset">ov:DOMOffset</a>
    /// </summary>
    let DOMOffset = _prefixId.prefix "DOMOffset"
    let ``DOMOffset.html`` = _prefixId.prefix "DOMOffset.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : DOMRange</para>
    ///   <para>rdfs:comment : A DOM Range consists of two boundary-points corresponding to the start and the end of the Range.
    /// http://www.w3.org/TR/2000/REC-DOM-Level-2-Traversal-Range-20001113/ranges.html#Level-2-Range-Definitions</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "c5ec7935-1f5f-44c7-b957-8989b185f1ac"^^xsd:string</para>
    ///   <para>label:plural : DOMRanges</para>
    ///   <a href="http://open.vocab.org/terms/DOMRange">ov:DOMRange</a>
    /// </summary>
    let DOMRange = _prefixId.prefix "DOMRange"
    let ``DOMRange.html`` = _prefixId.prefix "DOMRange.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Database</para>
    ///   <para>rdfs:comment : A Database</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "8b432287-3652-439c-b38d-7e07ce5c5a9d"^^xsd:string</para>
    ///   <para>label:plural : Databases</para>
    ///   <para>ov:markdownDescription : A Database</para>
    ///   <a href="http://open.vocab.org/terms/Database">ov:Database</a>
    /// </summary>
    let Database = _prefixId.prefix "Database"
    let ``Database.html`` = _prefixId.prefix "Database.html"
    let Death = _prefixId.prefix "Death"
    /// <summary>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : 65372006-0c7a-4a8b-a2b7-ea6f4f2c7317^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : A construct representing a deleted entry in an Atom feed.</para>
    ///   <para>label:plural : Deleted Entries</para>
    ///   <para>ov:markdownDescription : This is an extension of [AtomOwl](http://bblfish.net/work/atom-owl/2006-06-06/AtomOwl.html) to describe deleted entries (a.k.a. "tombstones"), as defined by [The Atom "deleted-entry" Element](http://tools.ietf.org/html/draft-snell-atompub-tombstones-06).</para>
    ///   <para>rdfs:label : Deleted Entry</para>
    ///   <a href="http://open.vocab.org/terms/DeletedEntry">ov:DeletedEntry</a>
    /// </summary>
    let DeletedEntry = _prefixId.prefix "DeletedEntry"
    let ``DeletedEntry.html`` = _prefixId.prefix "DeletedEntry.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : diff</para>
    ///   <para>rdfs:comment : A diff, showing the difference between a source resource and a target resource.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "a39df784-180e-48e6-b19a-df6b56bfadf1"^^xsd:string</para>
    ///   <para>label:plural : diffs</para>
    ///   <a href="http://open.vocab.org/terms/Diff">ov:Diff</a>
    /// </summary>
    let Diff = _prefixId.prefix "Diff"
    let ``Diff.html`` = _prefixId.prefix "Diff.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : DigitalAsset</para>
    ///   <para>rdfs:comment : DAs would be typically files. Audio, movies, software licenses, software installers, documents, etc. Anything stored that needs a computer to get it and/or read it.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "977812c0-587a-469e-9e8d-dba555516fac"^^xsd:string</para>
    ///   <para>label:plural : DigitalAssets</para>
    ///   <para>ov:markdownDescription : No doubt a hundred different classes already for this! There is a good opportunity to define nice, specific sub-classes for the various things this can track. </para>
    ///   <a href="http://open.vocab.org/terms/DigitalAsset">ov:DigitalAsset</a>
    /// </summary>
    let DigitalAsset = _prefixId.prefix "DigitalAsset"
    let ``DigitalAsset.html`` = _prefixId.prefix "DigitalAsset.html"
    /// <summary>
    ///   <para>rdfs:label : Distance</para>
    ///   <para>rdfs:comment : A Distance should have two distance points and a distance value. eg:
    ///
    /// &lt;distances/a/b&gt;
    ///     a ov:Distance ;
    ///     ov:distancePoint &lt;a&gt; , &lt;b&gt; ;
    ///     ov:kilometres 0.5 ;
    /// .</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : 739df7a1-d131-4f80-9946-b839848eb6fe^^xsd:string</para>
    ///   <para>label:plural : Distances</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/Distance">ov:Distance</a>
    /// </summary>
    let Distance = _prefixId.prefix "Distance"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : EarWorm</para>
    ///   <para>rdfs:comment : class is now deprecated in favour of Earworm class.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "185b2e77-3bb0-494c-8eab-d66bbce468b5"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/EarWorm">ov:EarWorm</a>
    /// </summary>
    let EarWorm = _prefixId.prefix "EarWorm"
    let ``EarWorm.html`` = _prefixId.prefix "EarWorm.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Earworm</para>
    ///   <para>rdfs:comment : The experience of having a song in your head which you can't get rid of.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "6fba532c-e7ed-41dd-9e1f-9be1ba93f247"^^xsd:string</para>
    ///   <para>label:plural : Earworms</para>
    ///   <a href="http://open.vocab.org/terms/Earworm">ov:Earworm</a>
    /// </summary>
    let Earworm = _prefixId.prefix "Earworm"
    let ``Earworm.html`` = _prefixId.prefix "Earworm.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Film</para>
    ///   <para>rdfs:comment : The class of all motion pictures</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "5d241a36-1ab7-4177-9065-f6f7540fa98b"^^xsd:string</para>
    ///   <para>label:plural : Films</para>
    ///   <a href="http://open.vocab.org/terms/Film">ov:Film</a>
    /// </summary>
    let Film = _prefixId.prefix "Film"
    let ``Film.html`` = _prefixId.prefix "Film.html"
    /// <summary>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : ef5d417e-a4b8-4fd5-9605-b11428a153ab^^xsd:string</para>
    ///   <para>label:plural : Formulae</para>
    ///   <para>rdfs:comment : A formula or graph literal, in the sense used by Notation 3.
    ///
    /// This is intended to be used as a datatype. e.g.
    ///
    ///   &lt;#bob&gt; ex:believes "&lt;#alice&gt; a &lt;http://xmlns.com/foaf/0.1/Person&gt; ."^^ov:Formula .
    ///
    /// Note that the wrapping "{"..."}" are omitted from the value.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Formula</para>
    ///   <a href="http://open.vocab.org/terms/Formula">ov:Formula</a>
    /// </summary>
    let Formula = _prefixId.prefix "Formula"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Course Loan History</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "e4953ad2-8b23-4202-b6d6-fff3d5bbe77f"^^xsd:string</para>
    ///   <para>label:plural : The loan history for a book by course</para>
    ///   <a href="http://open.vocab.org/terms/HUDCourseLoan">ov:HUDCourseLoan</a>
    /// </summary>
    let HUDCourseLoan = _prefixId.prefix "HUDCourseLoan"
    let ``HUDCourseLoan.html`` = _prefixId.prefix "HUDCourseLoan.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : School Loan History</para>
    ///   <para>rdfs:comment : The loan history of a book within a school</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "df31df81-ec72-4679-b264-22a78704932c"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/HUDSchoolLoan">ov:HUDSchoolLoan</a>
    /// </summary>
    let HUDSchoolLoan = _prefixId.prefix "HUDSchoolLoan"
    let ``HUDSchoolLoan.html`` = _prefixId.prefix "HUDSchoolLoan.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Suggestion</para>
    ///   <para>rdfs:comment : Suggested book based on circulation data</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "de162105-efcd-4f5d-8f1d-f31e6afa2a4d"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/HUDSuggestion">ov:HUDSuggestion</a>
    /// </summary>
    let HUDSuggestion = _prefixId.prefix "HUDSuggestion"
    let ``HUDSuggestion.html`` = _prefixId.prefix "HUDSuggestion.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Year Loan History</para>
    ///   <para>rdfs:comment : The loan history for a book by year.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "58471450-bbce-4b51-84e8-122eee13c146"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/HUDYearLoan">ov:HUDYearLoan</a>
    /// </summary>
    let HUDYearLoan = _prefixId.prefix "HUDYearLoan"
    let ``HUDYearLoan.html`` = _prefixId.prefix "HUDYearLoan.html"
    /// <summary>
    ///   <para>rdfs:label : House</para>
    ///   <para>rdfs:comment : Structure in which someone lives</para>
    ///   <para>label:plural : Houses</para>
    ///   <para>ov:markdownDescription : This is just a test</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "ff550d4a-c1ac-4b1c-99b3-6f06a66c77b9"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/House">ov:House</a>
    /// </summary>
    let House = _prefixId.prefix "House"
    let ``House.html`` = _prefixId.prefix "House.html"
    /// <summary>
    ///   <para>label:plural : ITU Regions for governance of radio operation</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : The ITU defines a set of world-wide regions which uniquely describe locations for radio operation (in particular, amateur radio operation).  These regions are widely-used by amateur radio operators to report operation and radio contacts.  Each region has a unique abbreviation.</para>
    ///   <para>dce:created : 2010-06-25T17:07:49Z^^xsd:dateTime</para>
    ///   <para>rdfs:label : ITU Region for governance of radio operation</para>
    ///   <a href="http://open.vocab.org/terms/ITUREgion">ov:ITUREgion</a>
    /// </summary>
    let ITUREgion = _prefixId.prefix "ITUREgion"
    /// <summary>
    ///   <para>label:plural : Illegal RDF/XML Statements</para>
    ///   <para>rdfs:comment : A statement that would be illegal to express in a non-reified form in RDF/XML - usually because the predicate cannot be converted to a QName.</para>
    ///   <para>rdfs:label : Illegal RDF/XML Statement</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "55f19a46-1987-4752-b7c7-92a45ae19046"^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>ov:markdownDescription : For example:
    ///
    ///     []
    ///       rdf:type openvocab:IllegalRDFXMLStatement ;
    ///       rdf:subject &lt;http://example.com/some_competition&gt; ;
    ///       rdf:predicate &lt;http://example.com/prizes/1&gt; ;
    ///       rdf:object &lt;http://example.com/some_person&gt; .
    ///
    /// Tools *may* automatically convert between openvocab:IllegalRDFXMLStatement statements and unreified statements when parsing or serialising RDF/XML.</para>
    ///   <a href="http://open.vocab.org/terms/IllegalRDFXMLStatement">ov:IllegalRDFXMLStatement</a>
    /// </summary>
    let IllegalRDFXMLStatement = _prefixId.prefix "IllegalRDFXMLStatement"
    let ``IllegalRDFXMLStatement.html`` = _prefixId.prefix "IllegalRDFXMLStatement.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : IrcBot</para>
    ///   <para>rdfs:comment : An irc chat bot</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : 804ec318-5912-4bb1-a461-793d2bc90033^^xsd:string</para>
    ///   <para>label:plural : IrcBots</para>
    ///   <a href="http://open.vocab.org/terms/IrcBot">ov:IrcBot</a>
    /// </summary>
    let IrcBot = _prefixId.prefix "IrcBot"
    let ``IrcBot.html`` = _prefixId.prefix "IrcBot.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : JavascriptThis</para>
    ///   <para>rdfs:comment : the concept of "this" in a javascript object. In other words a mean in which to refer to "self"</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "92acb8b3-c04c-48eb-a312-0191eac3b016"^^xsd:string</para>
    ///   <para>label:plural : JavascriptThises</para>
    ///   <para>ov:markdownDescription : the concept of "this" in an object. In other words a mean in which to refer to "self"</para>
    ///   <a href="http://open.vocab.org/terms/JavascriptThis">ov:JavascriptThis</a>
    /// </summary>
    let JavascriptThis = _prefixId.prefix "JavascriptThis"
    let ``JavascriptThis.html`` = _prefixId.prefix "JavascriptThis.html"
    /// <summary>
    ///   <para>rdfs:label : Killer Gorilla</para>
    ///   <para>label:plural : Killer Gorillas</para>
    ///   <para>rdfs:comment : A gorilla that kills or has the inclination to do so.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "8cc63a5f-fdf2-4288-9210-0dafb247fae5"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/KillerGorilla">ov:KillerGorilla</a>
    /// </summary>
    let KillerGorilla = _prefixId.prefix "KillerGorilla"
    let ``KillerGorilla.html`` = _prefixId.prefix "KillerGorilla.html"
    let Loaner = _prefixId.prefix "Loaner"
    /// <summary>
    ///   <para>dce:created : 2011-07-26T14:04:06Z^^xsd:dateTime</para>
    ///   <para>rdfs:comment : The class of all MOT Testing Stations.</para>
    ///   <para>rdfs:label : MOT Testing Station</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>label:plural : MOT Testing Stations</para>
    ///   <a href="http://open.vocab.org/terms/MOTTestingStation">ov:MOTTestingStation</a>
    /// </summary>
    let MOTTestingStation = _prefixId.prefix "MOTTestingStation"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Madre</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "9032bd12-9c48-405c-a88b-f8933bfe044f"^^xsd:string</para>
    ///   <para>label:plural : Madres</para>
    ///   <a href="http://open.vocab.org/terms/Madre">ov:Madre</a>
    /// </summary>
    let Madre = _prefixId.prefix "Madre"
    let ``Madre.html`` = _prefixId.prefix "Madre.html"
    /// <summary>
    ///   <para>dce:created : 2011-11-25T10:19:01Z^^xsd:dateTime</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Manifest</para>
    ///   <para>rdfs:comment : A manifest is a listing of files or URIs or resources of some sort encoded in some way</para>
    ///   <para>label:plural : Manifests</para>
    ///   <a href="http://open.vocab.org/terms/Manifest">ov:Manifest</a>
    /// </summary>
    let Manifest = _prefixId.prefix "Manifest"
    /// <summary>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "8607aed0-827c-4bda-b131-b4166b4c8af4"^^xsd:string</para>
    ///   <para>rdfs:comment : A post on a microblogging service like Twitter, identi.ca, Jaiku or FriendFeed. Usually untitled and with a limited number of characters, and sometimes containing in-line text-based syntactical elements like at-replies, hashtags, group 'bangtags' etc.</para>
    ///   <para>label:plural : Microblog Post</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : MicroblogPost</para>
    ///   <para>ov:markdownDescription : Use sioctypes' MicroBlogPost at &lt;http://rdfs.org/sioc/types#MicroblogPost&gt; instead.</para>
    ///   <a href="http://open.vocab.org/terms/MicroblogPost">ov:MicroblogPost</a>
    /// </summary>
    let MicroblogPost = _prefixId.prefix "MicroblogPost"
    let ``MicroblogPost.html`` = _prefixId.prefix "MicroblogPost.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : MultiSportEvent</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "b6186590-a786-4bff-a376-0b2e52d7558b"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/MultiSportEvent">ov:MultiSportEvent</a>
    /// </summary>
    let MultiSportEvent = _prefixId.prefix "MultiSportEvent"
    let ``MultiSportEvent.html`` = _prefixId.prefix "MultiSportEvent.html"
    /// <summary>
    ///   <para>label:plural : News items</para>
    ///   <para>rdfs:comment : A piece of News</para>
    ///   <para>rdfs:label : News item</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dce:created : 2010-11-16T02:21:58Z^^xsd:dateTime</para>
    ///   <a href="http://open.vocab.org/terms/NewsItem">ov:NewsItem</a>
    /// </summary>
    let NewsItem = _prefixId.prefix "NewsItem"
    /// <summary>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "5236de5a-f4e8-47d8-9f06-6f80b2b70df0"^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>label:plural : Non Killer-Gorillas</para>
    ///   <para>rdfs:comment : Indicates that something is definitely not a Killer-Gorilla. (It may still be a killer though. Or a gorilla.)</para>
    ///   <para>rdfs:label : Non Killer-Gorilla</para>
    ///   <a href="http://open.vocab.org/terms/NotAKillerGorilla">ov:NotAKillerGorilla</a>
    /// </summary>
    let NotAKillerGorilla = _prefixId.prefix "NotAKillerGorilla"
    let ``NotAKillerGorilla.html`` = _prefixId.prefix "NotAKillerGorilla.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Numismatics</para>
    ///   <para>rdfs:comment : Numismatics is  the study of coins, medals and other related items.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "7f375a7e-1689-46d3-b57f-a4fedd73bc3f"^^xsd:string</para>
    ///   <para>ov:markdownDescription : Numismatics is  the study of coins, medals and other related items.</para>
    ///   <a href="http://open.vocab.org/terms/Numismatics">ov:Numismatics</a>
    /// </summary>
    let Numismatics = _prefixId.prefix "Numismatics"
    let ``Numismatics.html`` = _prefixId.prefix "Numismatics.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Okkam Entity</para>
    ///   <para>rdfs:comment : Any entity that can be identified using the OKKAM entity naming system. In general one could say this is equivalent to resource but there are certain entity types that will work better on the OKKAM system</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "10b866d1-5d06-4c28-82f1-349d56044222"^^xsd:string</para>
    ///   <para>label:plural : Okkam entities</para>
    ///   <a href="http://open.vocab.org/terms/OkkamEntity">ov:OkkamEntity</a>
    /// </summary>
    let OkkamEntity = _prefixId.prefix "OkkamEntity"
    let ``OkkamEntity.html`` = _prefixId.prefix "OkkamEntity.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Olympic games</para>
    ///   <para>rdfs:comment : The Olympic Games are an international multi-sport event established for both summer and winter sports.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "41789c0e-3be8-4c07-9b27-0b972563eedf"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/OlympicGames">ov:OlympicGames</a>
    /// </summary>
    let OlympicGames = _prefixId.prefix "OlympicGames"
    let ``OlympicGames.html`` = _prefixId.prefix "OlympicGames.html"
    /// <summary>
    ///   <para>rdfs:comment : A Plot of anything.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>ov:markdownDescription : Example: a film's plot (http://en.wikipedia.org/wiki/Forrest_Gump#Plot).
    ///
    /// See elso http://open.vocab.org/terms/Plot.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "1783d6b3-c71a-43f4-b5ee-9bbe5a4de9d7"^^xsd:string</para>
    ///   <para>rdfs:label : Plot</para>
    ///   <para>label:plural : Plots</para>
    ///   <a href="http://open.vocab.org/terms/Plot">ov:Plot</a>
    /// </summary>
    let Plot = _prefixId.prefix "Plot"
    let ``Plot.html`` = _prefixId.prefix "Plot.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Primary Visual Element</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "feca0d81-0e01-46b9-afd4-370edb4399af"^^xsd:string</para>
    ///   <para>label:plural : Primary Visual Elements</para>
    ///   <a href="http://open.vocab.org/terms/PrimaryVisualElement">ov:PrimaryVisualElement</a>
    /// </summary>
    let PrimaryVisualElement = _prefixId.prefix "PrimaryVisualElement"
    let ``PrimaryVisualElement.html`` = _prefixId.prefix "PrimaryVisualElement.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : instruction to RTFM</para>
    ///   <para>rdfs:comment : RTFMImperative is an instruction for foaf:Agent(s) to read a given document.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "6b4810b0-1701-4561-9523-c5f3e1704940"^^xsd:string</para>
    ///   <para>label:plural : instructions to RTFM</para>
    ///   <a href="http://open.vocab.org/terms/RTFMImperative">ov:RTFMImperative</a>
    /// </summary>
    let RTFMImperative = _prefixId.prefix "RTFMImperative"
    let ``RTFMImperative.html`` = _prefixId.prefix "RTFMImperative.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Frequency of operation of a radio.</para>
    ///   <para>rdfs:comment : When a radio transmits a signal, a range of frequencies is used to carry information.  This range may be continuous or dis-contiguous ("spread spectrum").  There is usually a single frequency that is used to "name" the tranmission frequency, although this naming depends on the mode used.  (See RadioOperationMode).  The standard method of expression is "Herz" (or a multiple).  Sometimes, surprisingly, the "frequency" is expressed in terms of length (actually wavelength, often in meters).  This is merely an colloquial and equivalent expresssion, since freq(Herz) = the-speed-of-light / wavelength.</para>
    ///   <para>label:plural : Frequencies of operation of a radio.</para>
    ///   <para>dce:created : 2010-06-25T17:15:10Z^^xsd:dateTime</para>
    ///   <a href="http://open.vocab.org/terms/RadioOperationFrequency">ov:RadioOperationFrequency</a>
    /// </summary>
    let RadioOperationFrequency = _prefixId.prefix "RadioOperationFrequency"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Scientific Database</para>
    ///   <para>rdfs:comment : A Scientific Database</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "b4296af5-1c30-406e-be89-8e3c8b3d2bdb"^^xsd:string</para>
    ///   <para>label:plural : Scientific Databases</para>
    ///   <a href="http://open.vocab.org/terms/ScientificDatabase">ov:ScientificDatabase</a>
    /// </summary>
    let ScientificDatabase = _prefixId.prefix "ScientificDatabase"
    let ``ScientificDatabase.html`` = _prefixId.prefix "ScientificDatabase.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Sport Event </para>
    ///   <para>rdfs:comment : e.g. : 100m in Beijing 2008</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "306d5bc0-a01b-4df9-a86d-ca05856cacdb"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/SportEvent">ov:SportEvent</a>
    /// </summary>
    let SportEvent = _prefixId.prefix "SportEvent"
    let ``SportEvent.html`` = _prefixId.prefix "SportEvent.html"
    /// <summary>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "b8d9a0b9-e2be-4502-a418-2ade8533805b"^^xsd:string</para>
    ///   <para>label:plural : Living Killer Gorillas</para>
    ///   <para>rdfs:comment : Indicates that the subject is a non-deceased killer gorilla.</para>
    ///   <para>ov:markdownDescription : Zombie killer gorillas are an edge case. It is hoped that we'll be able to decide how they are modelled once we gain more experience in this area.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Living Killer Gorilla</para>
    ///   <a href="http://open.vocab.org/terms/StillAKillerGorilla">ov:StillAKillerGorilla</a>
    /// </summary>
    let StillAKillerGorilla = _prefixId.prefix "StillAKillerGorilla"
    let ``StillAKillerGorilla.html`` = _prefixId.prefix "StillAKillerGorilla.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Summer Olympic Games</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "daa558f3-c5ce-4b69-a5b7-4066a7430077"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/SummerOlympicGames">ov:SummerOlympicGames</a>
    /// </summary>
    let SummerOlympicGames = _prefixId.prefix "SummerOlympicGames"
    let ``SummerOlympicGames.html`` = _prefixId.prefix "SummerOlympicGames.html"
    let Test = _prefixId.prefix "Test"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Trim Package</para>
    ///   <para>rdfs:comment : A Trim Package represents a standard configuration of options for an automobile.  Usually, a Car Model will be available as several Trim Packages.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "fb106a26-a7ca-4184-b93a-05119cf00eb7"^^xsd:string</para>
    ///   <para>label:plural : Trim Packages</para>
    ///   <a href="http://open.vocab.org/terms/TrimPackage">ov:TrimPackage</a>
    /// </summary>
    let TrimPackage = _prefixId.prefix "TrimPackage"
    let ``TrimPackage.html`` = _prefixId.prefix "TrimPackage.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : University Course</para>
    ///   <para>rdfs:comment : A course taught at a university</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "d4796e2e-d861-442b-ad09-0d66399a0994"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/UnivCourse">ov:UnivCourse</a>
    /// </summary>
    let UnivCourse = _prefixId.prefix "UnivCourse"
    let ``UnivCourse.html`` = _prefixId.prefix "UnivCourse.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : University School</para>
    ///   <para>rdfs:comment : A school of a university (e.g., School of Business).</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "12c38e7e-a5a6-4890-86b1-34a097dbf48c"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/UnivSchool">ov:UnivSchool</a>
    /// </summary>
    let UnivSchool = _prefixId.prefix "UnivSchool"
    let ``UnivSchool.html`` = _prefixId.prefix "UnivSchool.html"
    let UuOjngyFVCE = _prefixId.prefix "UuOjngyFVCE"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Visual Element</para>
    ///   <para>rdfs:comment : A thing that manifests visually.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "02480410-26e1-4f17-a435-53849497cf51"^^xsd:string</para>
    ///   <para>label:plural : Visual Elements</para>
    ///   <para>ov:markdownDescription : a box in a powerpoint diagram is a VisualElement and can ov:depicts mit:TBL.
    ///
    /// Another box on a different slide is a different VisualElement and can also ov:depicts mit:TBL.</para>
    ///   <a href="http://open.vocab.org/terms/VisualElement">ov:VisualElement</a>
    /// </summary>
    let VisualElement = _prefixId.prefix "VisualElement"
    let ``VisualElement.html`` = _prefixId.prefix "VisualElement.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Vocabulary</para>
    ///   <para>rdfs:comment : A set of terms or names, each one having an assigned meaning.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "7b7177d8-ef11-4bb6-8eb1-21f77125592a"^^xsd:string</para>
    ///   <para>label:plural : vocabularies</para>
    ///   <a href="http://open.vocab.org/terms/Vocabulary">ov:Vocabulary</a>
    /// </summary>
    let Vocabulary = _prefixId.prefix "Vocabulary"
    let ``Vocabulary.html`` = _prefixId.prefix "Vocabulary.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Ware</para>
    ///   <para>rdfs:comment : Generic term for category of ceramics that may be distinguished by function, surface treatment, distinguishing features of clay, or other set of criteria as defined by usage. Commonly used in the discipline of Archaeology.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "7e358f56-84a8-4175-91d5-f4a62075c089"^^xsd:string</para>
    ///   <para>label:plural : Wares</para>
    ///   <para>ov:markdownDescription : The term "Ware" is used by archaeologists and collectors to identify any similar set of ceramic vessels, often by reference to some combination of the physical characteristics of the clay, surface treatment, overall shape, functional class, or place of manufacture. It is a common term in the field of archaeology. Usages include "Halaf Ware", a Sixth Millenium BC product of the Neolithic Halaf Culture of Northern Mesopotamia; "Deptford Ware" from England; "African Red Slip" a Roman period product from what is now the modern country of Tunisia; </para>
    ///   <a href="http://open.vocab.org/terms/Ware">ov:Ware</a>
    /// </summary>
    let Ware = _prefixId.prefix "Ware"
    let ``Ware.html`` = _prefixId.prefix "Ware.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : wheel chair enabled</para>
    ///   <para>rdfs:comment : A place that is accessible with a wheel chair.</para>
    ///   <para>label:plural : wheel chair enabled</para>
    ///   <para>dce:created : 2010-12-04T14:53:07Z^^xsd:dateTime</para>
    ///   <a href="http://open.vocab.org/terms/WheelChairEnabled">ov:WheelChairEnabled</a>
    /// </summary>
    let WheelChairEnabled = _prefixId.prefix "WheelChairEnabled"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Winter Olympic Games</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "08c64b6a-d0cc-4364-9c80-e3ecc9a169f7"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/WinterOlympicGames">ov:WinterOlympicGames</a>
    /// </summary>
    let WinterOlympicGames = _prefixId.prefix "WinterOlympicGames"
    let ``WinterOlympicGames.html`` = _prefixId.prefix "WinterOlympicGames.html"
    let Yoli = _prefixId.prefix "Yoli"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : ZoiaCommand</para>
    ///   <para>rdfs:comment : A command issued to the code4lib IRC chat bot, zoia.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : d7091da8-aaa6-4f7b-8b8a-39a8e8aeddc4^^xsd:string</para>
    ///   <para>label:plural : ZoiaCommands</para>
    ///   <a href="http://open.vocab.org/terms/ZoiaCommand">ov:ZoiaCommand</a>
    /// </summary>
    let ZoiaCommand = _prefixId.prefix "ZoiaCommand"
    let ``ZoiaCommand.html`` = _prefixId.prefix "ZoiaCommand.html"
    /// <summary>
    ///   <para>dce:created : 2010-07-03T19:17:39Z^^xsd:dateTime</para>
    ///   <para>rdfs:label : Account Identifier</para>
    ///   <para>label:plural : Account Identifiers</para>
    ///   <para>rdfs:comment : foaf:OnlineAccount's can have an accountName, but plenty of services use an account identifier internally that is not the same as the public account name: for instance, Twitter uses a nickname and a user_id property. Facebook now assigns usernames as well as internal identification numbers. Google's various services assign a unique identifier so that people are not revealing their e-mail address or username. This property is for these kind of identifiers.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/accountIdentifier">ov:accountIdentifier</a>
    /// </summary>
    let accountIdentifier = _prefixId.prefix "accountIdentifier"
    let admWIUQRlVUqNMadZQ = _prefixId.prefix "admWIUQRlVUqNMadZQ"
    /// <summary>
    ///   <para>rdfs:comment : The Authorised Examiner Number of an MOT Testing Station.</para>
    ///   <para>dce:created : 2011-07-26T14:10:10Z^^xsd:dateTime</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : AE Number</para>
    ///   <para>label:plural : AE Numbers</para>
    ///   <a href="http://open.vocab.org/terms/aeNumber">ov:aeNumber</a>
    /// </summary>
    let aeNumber = _prefixId.prefix "aeNumber"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Used to describe the affiliation, place of work or association of a foaf:Person when the source data is too ambiguous to model into its own resource.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "bec2de41-2196-4eae-9375-52180179deb6"^^xsd:string</para>
    ///   <para>rdfs:label : Personal or Professional Affiliation</para>
    ///   <para>label:plural : Personal or Professional Affiliations</para>
    ///   <a href="http://open.vocab.org/terms/affiliation">ov:affiliation</a>
    /// </summary>
    let affiliation = _prefixId.prefix "affiliation"
    let ``affiliation.html`` = _prefixId.prefix "affiliation.html"
    /// <summary>
    ///   <para>rdfs:label : syndicates</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : 8292a082-1b27-4e4b-aac0-20750acaac82^^xsd:string</para>
    ///   <para>rdfs:comment : An agent syndicates a document some way.</para>
    ///   <para>label:plural : syndicates</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/aggregates">ov:aggregates</a>
    /// </summary>
    let aggregates = _prefixId.prefix "aggregates"
    /// <summary>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : f8e48112-3798-434d-a7d4-0233aab6c5a1^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Anniversary</para>
    ///   <para>rdfs:comment : The anniversary of some event</para>
    ///   <para>ov:markdownDescription : P1DBUm  &lt;a href="http://tlretrishzly.com/"&gt;tlretrishzly&lt;/a&gt;, [url=http://ywdctirrpimo.com/]ywdctirrpimo[/url], [link=http://azbcchuxcjzl.com/]azbcchuxcjzl[/link], http://jhvgdshuwxci.com/</para>
    ///   <para>label:plural : Anniversaries</para>
    ///   <a href="http://open.vocab.org/terms/anniversary">ov:anniversary</a>
    /// </summary>
    let anniversary = _prefixId.prefix "anniversary"
    /// <summary>
    ///   <para>rdfs:comment : The area of some physical thing in hectares.</para>
    ///   <para>label:plural : Area in Hectares</para>
    ///   <para>rdfs:label : Area in Hectares</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : f7db4219-177f-41f9-b1fe-b78a398b39d0^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/areaHectares">ov:areaHectares</a>
    /// </summary>
    let areaHectares = _prefixId.prefix "areaHectares"
    /// <summary>
    ///   <para>label:plural : Associated Entities</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : 9660a248-90f4-4aff-94ec-26dd8a279791^^xsd:string</para>
    ///   <para>rdfs:comment : This property is used to relate two FRBR Endeavours/entities (http://vocab.org/frbr/core.html#Endeavour) together even if the entire Work-Expression-Manifestation-Item hierarchy does not exist.  For example, it could be used to relate a frbr:Work to a frbr:Manifestation without the need of a frbr:Expression to link them through.  The property is symmetric (if a &lt;_:work&gt; ov:associatedEntity &lt;_:item&gt; then &lt;_:item&gt; ov:associatedEntity &lt;_:work&gt;.  It is not transitive (items may be associated with the same work but not be in the same WEMI chain, for example).</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Associated Entity</para>
    ///   <a href="http://open.vocab.org/terms/associatedEntity">ov:associatedEntity</a>
    /// </summary>
    let associatedEntity = _prefixId.prefix "associatedEntity"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Providing evidence for existence or historicity</para>
    ///   <para>rdfs:comment : A thing that provides evidence for the existence or historicity of another thing attests to that other thing.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "dfb9077f-bea2-4d8b-a63a-423e70dcc9a6"^^xsd:string</para>
    ///   <para>label:plural : Providing evidence for existence or historicity</para>
    ///   <para>ov:markdownDescription : For example: the inscription described at http://insaph.kcl.ac.uk/iaph2007/iAph120214.html attests to the existence of the historical places Claudiopolis, Ancyra of Galatia, Pessinus, Damascus, Beirut, Tyre, Caesarea Stratonos, Neapolis of Samaria, Scythopolis, Gaza, Caesarea Panias, Hieropolis, Anazarbus, Mopsuestia, Tripolis of Syria, Philadelphia of Arabia, at Zeugma by the Euphrates, and Kibyra.</para>
    ///   <a href="http://open.vocab.org/terms/attestsTo">ov:attestsTo</a>
    /// </summary>
    let attestsTo = _prefixId.prefix "attestsTo"
    let ``attestsTo.html`` = _prefixId.prefix "attestsTo.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "0a19b995-d483-4cdb-8c95-6d93ca13b80e"^^xsd:string</para>
    ///   <para>rdfs:comment : The literal, human readable author string of a Document.</para>
    ///   <para>rdfs:label : Author string</para>
    ///   <para>ov:markdownDescription : Useful for retaining the author sequence information without reification, rdf:Seq, etc.</para>
    ///   <para>label:plural : Author strings</para>
    ///   <a href="http://open.vocab.org/terms/authorString">ov:authorString</a>
    /// </summary>
    let authorString = _prefixId.prefix "authorString"
    let ``authorString.html`` = _prefixId.prefix "authorString.html"
    /// <summary>
    ///   <para>dce:created : 2011-03-22T17:44:44Z^^xsd:dateTime</para>
    ///   <para>rdfs:comment : One or more of the four elements viz. Air, Water, Fire and Earth that can be bent.</para>
    ///   <para>rdfs:label : The Element an Individual Can Bend</para>
    ///   <para>label:plural : The Elements an Individual Can Bend</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/avatarBendingElement">ov:avatarBendingElement</a>
    /// </summary>
    let avatarBendingElement = _prefixId.prefix "avatarBendingElement"
    /// <summary>
    ///   <para>rdfs:label : Color of Eyes of an Individual</para>
    ///   <para>rdfs:comment : Describes the eye color of an individual</para>
    ///   <para>label:plural : Color of Eyes of an Individual</para>
    ///   <para>dce:created : 2011-03-22T17:51:05Z^^xsd:dateTime</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/avatarEyeColor">ov:avatarEyeColor</a>
    /// </summary>
    let avatarEyeColor = _prefixId.prefix "avatarEyeColor"
    /// <summary>
    ///   <para>dce:created : 2011-03-22T17:52:38Z^^xsd:dateTime</para>
    ///   <para>label:plural : First Appearances of Character</para>
    ///   <para>rdfs:comment : Describes when the character was introduced in the series.</para>
    ///   <para>rdfs:label : First Appearance of Character</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/avatarFirstAppearance">ov:avatarFirstAppearance</a>
    /// </summary>
    let avatarFirstAppearance = _prefixId.prefix "avatarFirstAppearance"
    /// <summary>
    ///   <para>label:plural : Hair Color of an Individual</para>
    ///   <para>rdfs:label : Color of Hair of an Individual</para>
    ///   <para>dce:created : 2011-03-22T17:47:03Z^^xsd:dateTime</para>
    ///   <para>rdfs:comment : Defines the hair color (or no hair at all!) of an individual</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/avatarHairColor">ov:avatarHairColor</a>
    /// </summary>
    let avatarHairColor = _prefixId.prefix "avatarHairColor"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Nationality of a Character in Graphic Novel Avatar</para>
    ///   <para>label:plural : Nationalities of a Character in Graphic Novel Avatar</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : 817ab5ce-bebb-42c0-84a9-29b5c89210dd^^xsd:string</para>
    ///   <para>rdfs:comment : The nationality of a character in Avatar. It can be one of Air, Fire, Water and Earth.</para>
    ///   <a href="http://open.vocab.org/terms/avatarNationality">ov:avatarNationality</a>
    /// </summary>
    let avatarNationality = _prefixId.prefix "avatarNationality"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>label:plural : Position of the Character in Graphic Novel Avatar</para>
    ///   <para>rdfs:label : Position of the Character in Graphic Novel Avatar</para>
    ///   <para>rdfs:comment : Determines if the character is protagonist, antagonist, supporting character etc.</para>
    ///   <para>dce:created : 2011-03-22T17:49:42Z^^xsd:dateTime</para>
    ///   <a href="http://open.vocab.org/terms/avatarPosition">ov:avatarPosition</a>
    /// </summary>
    let avatarPosition = _prefixId.prefix "avatarPosition"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : BBC Weather ID</para>
    ///   <para>rdfs:comment : The BBC provides IDs for places. This can be used to link BBC weather IDs to places.</para>
    ///   <para>label:plural : BBC Weather IDs</para>
    ///   <para>dce:created : 2010-08-25T12:54:11Z^^xsd:dateTime</para>
    ///   <a href="http://open.vocab.org/terms/bbcWeatherId">ov:bbcWeatherId</a>
    /// </summary>
    let bbcWeatherId = _prefixId.prefix "bbcWeatherId"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : ComponentOf</para>
    ///   <para>rdfs:comment : Following an EAD description, collections consist of one or more "components". Components act much like files and folders - a component may contain others (folder) or it may be a leaf node (file) - EAD is vague enough not to make this distinction, but provides a "level" attribute instead. This property is used by a component to show that if is a "componentOf" either another component or a collection or both.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "86d3c156-dea8-49af-9188-24037f86ec27"^^xsd:string</para>
    ///   <para>label:plural : ComponentsOf</para>
    ///   <a href="http://open.vocab.org/terms/beam-componentOf">ov:beam-componentOf</a>
    /// </summary>
    let beam_componentOf = _prefixId.prefix "beam-componentOf"
    let ``beam_componentOf.html`` = _prefixId.prefix "beam-componentOf.html"
    /// <summary>
    ///   <para>dce:created : 2010-11-09T02:14:29Z^^xsd:dateTime</para>
    ///   <para>label:plural : British Library identifiers</para>
    ///   <para>rdfs:label : British Library identifier</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : A sub-classing of bibo:identifier to narrow the range to be the numeric part of a BL identifier. For example:
    ///
    /// '(Uk)33994949'  ---&gt;  '&lt;foo&gt; &lt;ov:blid&gt; "33994949"'</para>
    ///   <a href="http://open.vocab.org/terms/blid">ov:blid</a>
    /// </summary>
    let blid = _prefixId.prefix "blid"
    let bsRGyjqyy = _prefixId.prefix "bsRGyjqyy"
    let bthPpNLjjQHuCC = _prefixId.prefix "bthPpNLjjQHuCC"
    let building = _prefixId.prefix "building"
    /// <summary>
    ///   <para>rdfs:label : Business Card</para>
    ///   <para>label:plural : Business Cards</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : A business card associated with this resource.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : b7eaec45-5c0e-4ae8-b880-131b4ee9129d^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/businessCard">ov:businessCard</a>
    /// </summary>
    let businessCard = _prefixId.prefix "businessCard"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Business Interest</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "e3c06d28-b842-4264-9fa4-75c008ae1fda"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/businessInterest">ov:businessInterest</a>
    /// </summary>
    let businessInterest = _prefixId.prefix "businessInterest"
    let ``businessInterest.html`` = _prefixId.prefix "businessInterest.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>ov:markdownDescription : X8MZrJ  &lt;a href="http://lsxkhoxxsuwb.com/"&gt;lsxkhoxxsuwb&lt;/a&gt;, [url=http://aswturqaprud.com/]aswturqaprud[/url], [link=http://yxtryhogdakn.com/]yxtryhogdakn[/link], http://rasuuqixgaff.com/</para>
    ///   <para>rdfs:comment : A calendar associated with this resource.</para>
    ///   <para>label:plural : Calendars</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : bc1bcb98-0116-46e1-8073-dd3e5579a70a^^xsd:string</para>
    ///   <para>rdfs:label : Calendar</para>
    ///   <a href="http://open.vocab.org/terms/calendar">ov:calendar</a>
    /// </summary>
    let calendar = _prefixId.prefix "calendar"
    let canonicalInformationResource = _prefixId.prefix "canonicalInformationResource"
    /// <summary>
    ///   <para>label:plural : Canonical URIs</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "5e2afc39-395c-479b-a9cc-a421e2e6d3e8"^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes the canonical URI that should be used to refer to this resource.</para>
    ///   <para>rdfs:label : Canonical URI</para>
    ///   <para>ov:markdownDescription : This property should have a literal as its value, not a resource.
    ///
    /// RDF driven systems can use this property to redirect requests to the preferred URI for a resource.</para>
    ///   <a href="http://open.vocab.org/terms/canonicalUri">ov:canonicalUri</a>
    /// </summary>
    let canonicalUri = _prefixId.prefix "canonicalUri"
    let ``canonicalUri.html`` = _prefixId.prefix "canonicalUri.html"
    /// <summary>
    ///   <para>rdfs:comment : A category that the resource has been classified under</para>
    ///   <para>label:plural : categories</para>
    ///   <para>rdfs:label : category</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "f1f8e17c-fdcb-422a-8555-e258ba36d535"^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/category">ov:category</a>
    /// </summary>
    let category = _prefixId.prefix "category"
    let ``category.html`` = _prefixId.prefix "category.html"
    /// <summary>
    ///   <para>rdfs:comment : Relates class to a class skeleton. If class has more than one of this relations, it should use them all.</para>
    ///   <para>label:plural : class skeletons</para>
    ///   <para>rdfs:label : Class Skeleton</para>
    ///   <para>dce:created : 2010-04-13T18:40:41Z^^xsd:dateTime</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/classSkeleton">ov:classSkeleton</a>
    /// </summary>
    let classSkeleton = _prefixId.prefix "classSkeleton"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Class Skeleton Ignore</para>
    ///   <para>rdfs:comment : Triples using his property and its sub-properties as predicate are to be ignored by the class skeleton materialization process (http://open.vocab.org/terms/ClassSkeleton).
    ///
    /// This property is not to be used in real data, it serves just to exist and have sub-properties.</para>
    ///   <para>label:plural : class skeleton ignore</para>
    ///   <para>dce:created : 2010-04-13T19:02:15Z^^xsd:dateTime</para>
    ///   <a href="http://open.vocab.org/terms/classSkeletonIgnore">ov:classSkeletonIgnore</a>
    /// </summary>
    let classSkeletonIgnore = _prefixId.prefix "classSkeletonIgnore"
    let colorsOfHouses = _prefixId.prefix "colorsOfHouses"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Colour</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "ea851fab-d330-47b5-a23a-eda4deef052e"^^xsd:string</para>
    ///   <para>label:plural : Colours</para>
    ///   <a href="http://open.vocab.org/terms/colour">ov:colour</a>
    /// </summary>
    let colour = _prefixId.prefix "colour"
    let ``colour.html`` = _prefixId.prefix "colour.html"
    /// <summary>
    ///   <para>rdfs:comment : commonEndeavour is intended to define a FRBR (Functional Requirements for Bibliographic Records) relationship between two resources that may or may not be modeled as FRBR.  This makes it possible to assert that a resource modeled using a vocabulary that does not use the FRBR entity model explicitly is describing the same Work, Expression, Manifestation, and/or Item as another resource (which may or may not use the FRBR model, as well).
    ///
    /// commonEndeavour is intended to be used merely as a superproperty for WEMI-specific subproperties to inherit from, but there are no restrictions on its use.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Common Endeavour</para>
    ///   <para>label:plural : Common Endeavours</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : 87624008-ebed-489e-94bc-0f61fd0830f0^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/commonEndeavour">ov:commonEndeavour</a>
    /// </summary>
    let commonEndeavour = _prefixId.prefix "commonEndeavour"
    /// <summary>
    ///   <para>rdfs:comment : This property is used to declare that two resources which may or may not conform to the FRBR (Functional Requirements for Bibliographic Resources) entity model share the same Expression. An example of its use would be to relate a resource described with a vocabulary such as bibo (which does not acknowledge the FRBR model) to other resources that describe endeavours which have the same implied Expression (which could be other bibo resources or FRBR entities or anything else).
    ///
    /// The property is symmetrical, so if &lt;_:someBiboBook&gt; &lt;ov:commonExpression&gt; &lt;_:otherEdition&gt;, this also means &lt;_:otherEdition&gt; &lt;ov:commonExpression&gt; &lt;_:someBiboBook&gt;.
    ///
    /// It is not transitive.
    ///
    /// Having this property also implies ov:commonWork.</para>
    ///   <para>label:plural : Common Expressions</para>
    ///   <para>rdfs:label : Common Expression</para>
    ///   <para>dce:created : 2010-12-06T17:43:57Z^^xsd:dateTime</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/commonExpression">ov:commonExpression</a>
    /// </summary>
    let commonExpression = _prefixId.prefix "commonExpression"
    /// <summary>
    ///   <para>dce:created : 2010-12-06T17:52:51Z^^xsd:dateTime</para>
    ///   <para>rdfs:comment : This property is used to declare that two resources which may or may not conform to the FRBR (Functional Requirements for Bibliographic Resources) entity model share the same Item. An example of its use would be to relate a resource described with a vocabulary such as bibo (which does not acknowledge the FRBR model) to other resources that describe endeavours which contains the same specific Item (which could be other bibo resources or FRBR entities or anything else). This implies identical WEMI hierarchies.
    ///
    /// The property is symmetrical, so if &lt;_:specificPhysicalItem&gt; &lt;ov:commonItem&gt; &lt;_:someArchive&gt;, this also means &lt;_:someArchive&gt; &lt;ov:commonItem&gt; &lt;_:specificPhysicalItem&gt;.
    ///
    /// It is not transitive.
    ///
    /// Having this property also entails ov:commonManifestation, ov:commonExpression and ov:commonWork.</para>
    ///   <para>label:plural : Common Items</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Common Item</para>
    ///   <a href="http://open.vocab.org/terms/commonItem">ov:commonItem</a>
    /// </summary>
    let commonItem = _prefixId.prefix "commonItem"
    /// <summary>
    ///   <para>rdfs:comment : This property is used to declare that two resources which may or may not conform to the FRBR (Functional Requirements for Bibliographic Resources) entity model share the same Manifestation.  An example of its use would be to relate a resource described with a vocabulary such as bibo (which does not acknowledge the FRBR model) to other resources that describe endeavours which include the same implied Manifestation (which could be other bibo resources or FRBR entities or anything else).
    ///
    /// The property is symmetrical, so if &lt;_:someBiboBook&gt; &lt;ov:commonManifestation&gt; &lt;_:someFrbrWork&gt;, this also means &lt;_:someFrbrWork&gt; &lt;ov:commonManifestation&gt; &lt;_:someBiboBook&gt;.  It is not transitive.
    ///
    /// Having this property also implies ov:commonExpression and ov:commonWork.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : f78eed93-fa94-4591-ac90-1846598f3920^^xsd:string</para>
    ///   <para>label:plural : Common Manifestations</para>
    ///   <para>rdfs:label : Common Manifestation</para>
    ///   <a href="http://open.vocab.org/terms/commonManifestation">ov:commonManifestation</a>
    /// </summary>
    let commonManifestation = _prefixId.prefix "commonManifestation"
    /// <summary>
    ///   <para>rdfs:label : Common Work</para>
    ///   <para>label:plural : Common Works</para>
    ///   <para>dce:created : 2010-12-06T17:18:34Z^^xsd:dateTime</para>
    ///   <para>rdfs:comment : This property is used to declare that two resources which may or may not conform to the FRBR (Functional Requirements for Bibliographic Resources) entity model share the same Work. An example of its use would be to relate a resource described with a vocabulary such as bibo (which does not acknowledge the FRBR model) to other resources that describe endeavours that fall within the same implied Work (which could be other bibo resources or FRBR entities or anything else).
    ///
    /// The property is symmetrical, so if &lt;_:someBiboBook&gt; &lt;ov:commonWork&gt; &lt;_:someOtherBiboBook&gt;, this also means &lt;_:someOtherBiboBook&gt; &lt;ov:commonWork&gt; &lt;_:someBiboBook&gt;.
    ///
    /// It is not transitive.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/commonWork">ov:commonWork</a>
    /// </summary>
    let commonWork = _prefixId.prefix "commonWork"
    /// <summary>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "b2a1a580-f238-49af-95ca-fd0bb0798a67"^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : The Compass Direction that a Thing faces.</para>
    ///   <para>ov:markdownDescription : Eg: :NordWand rdfs:label "North Face of the Eiger" ; ov:compassDirection "N" .
    ///
    /// Values should be compass directions, eg: N, NE, E, SE, S, SW, W, NW
    /// </para>
    ///   <para>label:plural : Compass Directions</para>
    ///   <para>rdfs:label : Compass Direction</para>
    ///   <a href="http://open.vocab.org/terms/compassDirection">ov:compassDirection</a>
    /// </summary>
    let compassDirection = _prefixId.prefix "compassDirection"
    let ``compassDirection.html`` = _prefixId.prefix "compassDirection.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : composed by</para>
    ///   <para>rdfs:comment : :s :composedBy :o .
    /// :o is a "larger thing" that composes :s and potentially other "smaller things". :s may also establish some structural organization of the things it composes.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : 0806f709-0905-4750-b0ea-b4df356f2072^^xsd:string</para>
    ///   <para>label:plural : composed by</para>
    ///   <para>ov:markdownDescription : for current task, domain and range would be Visual form. However, the range could be more generally Form.</para>
    ///   <a href="http://open.vocab.org/terms/composedBy">ov:composedBy</a>
    /// </summary>
    let composedBy = _prefixId.prefix "composedBy"
    let ``composedBy.html`` = _prefixId.prefix "composedBy.html"
    /// <summary>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "7dfe86b3-9ddd-417d-884c-8622394e3f4d"^^xsd:string</para>
    ///   <para>ov:markdownDescription : this property is a shortcut that allows one to abuse the Music Ontology to some extent</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Composer</para>
    ///   <para>rdfs:comment : associates a manifestation of a musical work with music artist who composed the work</para>
    ///   <para>label:plural : Composers</para>
    ///   <a href="http://open.vocab.org/terms/composer">ov:composer</a>
    /// </summary>
    let composer = _prefixId.prefix "composer"
    let ``composer.html`` = _prefixId.prefix "composer.html"
    /// <summary>
    ///   <para>rdfs:label : compressed dataset file has fileSize</para>
    ///   <para>dce:created : 2010-05-15T18:53:16Z^^xsd:dateTime</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the size of the file of a dataset in compressed state</para>
    ///   <a href="http://open.vocab.org/terms/compressedFileSize">ov:compressedFileSize</a>
    /// </summary>
    let compressedFileSize = _prefixId.prefix "compressedFileSize"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : ConfidenceLevel</para>
    ///   <para>rdfs:comment : A confidence level for a calculation or value.  Usually between 0 and 1.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "c3cfcbe5-c138-41a5-9c86-22b5600ceb27"^^xsd:string</para>
    ///   <para>label:plural : ConfidenceLevels</para>
    ///   <a href="http://open.vocab.org/terms/confidence">ov:confidence</a>
    /// </summary>
    let confidence = _prefixId.prefix "confidence"
    let ``confidence.html`` = _prefixId.prefix "confidence.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Country</para>
    ///   <para>rdfs:comment : A country associated with this resource. This could be a country of origin or operation of an entity. For example a company may be based in a country and operate from there.</para>
    ///   <para>label:plural : Countries</para>
    ///   <para>dce:created : 2010-07-12T10:26:32Z^^xsd:dateTime</para>
    ///   <a href="http://open.vocab.org/terms/country">ov:country</a>
    /// </summary>
    let country = _prefixId.prefix "country"
    let creation_tool_used = _prefixId.prefix "creation-tool-used"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Creator User Agent</para>
    ///   <para>rdfs:comment : The user-agent string of the software used by the creator of an item.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "f76d1653-768d-4a3b-acb8-8e3311f4ffdb"^^xsd:string</para>
    ///   <para>label:plural : Creator User Agents</para>
    ///   <a href="http://open.vocab.org/terms/creatorUserAgent">ov:creatorUserAgent</a>
    /// </summary>
    let creatorUserAgent = _prefixId.prefix "creatorUserAgent"
    let ``creatorUserAgent.html`` = _prefixId.prefix "creatorUserAgent.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : csv column</para>
    ///   <para>rdfs:comment : The column of a comma separated value file from which this property was created.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : e4007e2d-4707-40f5-8e9c-82c216a5b1d4^^xsd:string</para>
    ///   <para>label:plural : csv columns</para>
    ///   <para>ov:markdownDescription : see also http://open.vocab.org/terms/csvRow</para>
    ///   <a href="http://open.vocab.org/terms/csvCol">ov:csvCol</a>
    /// </summary>
    let csvCol = _prefixId.prefix "csvCol"
    let ``csvCol.html`` = _prefixId.prefix "csvCol.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : csv row</para>
    ///   <para>rdfs:comment : The row number of a csv from which this instance was created. This is different from the r-th entry within the table, which may be less than the csv row if the csv has title information and a header above the data.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : 1cdb728e-f479-45ce-a18f-0fd34373bce8^^xsd:string</para>
    ///   <para>label:plural : csv rows</para>
    ///   <para>ov:markdownDescription : Add this property to any instance you make from a row when converting csv to rdf.
    ///
    /// see also http://open.vocab.org/terms/csvCol</para>
    ///   <a href="http://open.vocab.org/terms/csvRow">ov:csvRow</a>
    /// </summary>
    let csvRow = _prefixId.prefix "csvRow"
    let ``csvRow.html`` = _prefixId.prefix "csvRow.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Date of Death</para>
    ///   <para>rdfs:comment : The date someone died.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "27095cdd-ef17-415a-b792-4d09cbc7994a"^^xsd:string</para>
    ///   <para>label:plural : Dates of Death</para>
    ///   <a href="http://open.vocab.org/terms/dateOfDeath">ov:dateOfDeath</a>
    /// </summary>
    let dateOfDeath = _prefixId.prefix "dateOfDeath"
    let ``dateOfDeath.html`` = _prefixId.prefix "dateOfDeath.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : default property</para>
    ///   <para>rdfs:comment : Associates properties to a class where the properties are meant to be present in some default view - basically a very light version of fresnel ;-)</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "d30de59f-edd3-460e-b59f-77a495c7eadd"^^xsd:string</para>
    ///   <para>label:plural : default properties</para>
    ///   <a href="http://open.vocab.org/terms/defaultProperty">ov:defaultProperty</a>
    /// </summary>
    let defaultProperty = _prefixId.prefix "defaultProperty"
    let ``defaultProperty.html`` = _prefixId.prefix "defaultProperty.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Defines</para>
    ///   <para>rdfs:comment : The things defined by this resource - for example, the terms defined by an Ontology.</para>
    ///   <para>dce:created : 2010-08-03T11:04:11Z^^xsd:dateTime</para>
    ///   <a href="http://open.vocab.org/terms/defines">ov:defines</a>
    /// </summary>
    let defines = _prefixId.prefix "defines"
    /// <summary>
    ///   <para>rdfs:comment : Teacher of the course. Should belong to the organization specified by ov:offeredBy of the course</para>
    ///   <para>dce:created : 2011-06-23T12:50:14Z^^xsd:dateTime</para>
    ///   <para>rdfs:label : Course teacher</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/deliveredBy">ov:deliveredBy</a>
    /// </summary>
    let deliveredBy = _prefixId.prefix "deliveredBy"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : departure date</para>
    ///   <para>rdfs:comment : Date and time your travel will commence</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "9214e313-1750-4026-8619-a2279a289ab7"^^xsd:string</para>
    ///   <para>label:plural : departure dates</para>
    ///   <a href="http://open.vocab.org/terms/departureDate">ov:departureDate</a>
    /// </summary>
    let departureDate = _prefixId.prefix "departureDate"
    let ``departureDate.html`` = _prefixId.prefix "departureDate.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : depicts</para>
    ///   <para>rdfs:comment : When :s :depicts :o, :s is communicable via a visual medium and, when transmitted, depicts the resource :o.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "53f9ed8f-1ad7-4085-8eb2-3e86a08c9307"^^xsd:string</para>
    ///   <para>label:plural : depicts</para>
    ///   <para>ov:markdownDescription : The predicate-object of a :depicts triple could be embedded on a powerpoint diagram element. We could then ask for documents that depict a resource of interest and, conversely, ask what an ambiguous blob of pink on the monitor is actually trying to depict.
    ///
    /// foaf:depicts would be a rdfs:subPropertyOf :depicts. :depicts is more general because other things besides foaf:Images can be communicated via a visual medium.
    ///
    /// Is :depicts an ObjectProperty or DatatypeProperty? It could be either.
    ///
    /// </para>
    ///   <a href="http://open.vocab.org/terms/depicts">ov:depicts</a>
    /// </summary>
    let depicts = _prefixId.prefix "depicts"
    let ``depicts.html`` = _prefixId.prefix "depicts.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : depicts same resource as</para>
    ///   <para>label:plural : depict same resource as</para>
    ///   <para>ov:markdownDescription : depictsSameResourceAs is used by a VisualElement to point to the PrimaryVisualElement within the current display.
    ///
    /// both :a and :b are in same display.
    ///
    /// :a ov:depicts :r .
    /// :b ov:depicts :r .
    /// :a ov:depictsSameResourceAs :b .
    /// -----
    /// :a a ov:VisualElement .
    /// :b a ov:PrimaryVisualElement .
    /// :b a ov:VisualElement .
    ///
    /// </para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "64e4a9da-d199-4ec2-a7f1-616765f8a5bb"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/depictsSameResourceAs">ov:depictsSameResourceAs</a>
    /// </summary>
    let depictsSameResourceAs = _prefixId.prefix "depictsSameResourceAs"
    let ``depictsSameResourceAs.html`` = _prefixId.prefix "depictsSameResourceAs.html"
    /// <summary>
    ///   <para>label:plural : describes</para>
    ///   <para>rdfs:comment : The subject is a document that, to any extent, describes the object.</para>
    ///   <para>rdfs:label : describes</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : d18ba60e-c03f-4781-8098-6008b0f371b4^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/describes">ov:describes</a>
    /// </summary>
    let describes = _prefixId.prefix "describes"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : diff from other</para>
    ///   <para>rdfs:comment : A diff that goes from another resource to this one.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "c2a683c4-4b22-4ddf-a8e9-d2eb71309152"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/diffFromOther">ov:diffFromOther</a>
    /// </summary>
    let diffFromOther = _prefixId.prefix "diffFromOther"
    let ``diffFromOther.html`` = _prefixId.prefix "diffFromOther.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : source</para>
    ///   <para>rdfs:comment : The resource that this diff goes from.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "d564cc82-bcb9-472d-add8-b794ea0cc92f"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/diffSource">ov:diffSource</a>
    /// </summary>
    let diffSource = _prefixId.prefix "diffSource"
    let ``diffSource.html`` = _prefixId.prefix "diffSource.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : target</para>
    ///   <para>rdfs:comment : The resource that this diff goes to.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "90e6138e-f106-48a2-8e7d-c91a35b27350"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/diffTarget">ov:diffTarget</a>
    /// </summary>
    let diffTarget = _prefixId.prefix "diffTarget"
    let ``diffTarget.html`` = _prefixId.prefix "diffTarget.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : diff to other</para>
    ///   <para>rdfs:comment : A diff that goes from this resource to another one.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "f50cd934-9b3a-4d10-833a-5c3ae6425a9b"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/diffToOther">ov:diffToOther</a>
    /// </summary>
    let diffToOther = _prefixId.prefix "diffToOther"
    let ``diffToOther.html`` = _prefixId.prefix "diffToOther.html"
    /// <summary>
    ///   <para>label:plural : Dimension Properties</para>
    ///   <para>dce:created : 2011-06-22T09:29:42Z^^xsd:dateTime</para>
    ///   <para>rdfs:label : Dimension Property</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a property to a Dimension Property with identical meaning for use with the RDF DataCube vocabulary.</para>
    ///   <a href="http://open.vocab.org/terms/dimensionProperty">ov:dimensionProperty</a>
    /// </summary>
    let dimensionProperty = _prefixId.prefix "dimensionProperty"
    /// <summary>
    ///   <para>rdfs:comment : The disclaimer property links a resource to a document that details a disclaimer applied to the resource by the resource owner or other relevant party.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : disclaimer</para>
    ///   <para>label:plural : disclaimers</para>
    ///   <para>dce:created : 2011-03-10T16:33:42Z^^xsd:dateTime</para>
    ///   <a href="http://open.vocab.org/terms/disclaimer">ov:disclaimer</a>
    /// </summary>
    let disclaimer = _prefixId.prefix "disclaimer"
    /// <summary>
    ///   <para>label:plural : disclaimer texts</para>
    ///   <para>rdfs:label : disclaimer text</para>
    ///   <para>dce:created : 2011-03-10T16:28:11Z^^xsd:dateTime</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : The disclaimerText property associates a resource with the text of a disclaimer (in the form of an rdfs:Literal) applied to the resource by the resource owner or other relevant party.</para>
    ///   <a href="http://open.vocab.org/terms/disclaimerText">ov:disclaimerText</a>
    /// </summary>
    let disclaimerText = _prefixId.prefix "disclaimerText"
    /// <summary>
    ///   <para>label:plural : Distance Points</para>
    ///   <para>rdfs:label : Distance Point</para>
    ///   <para>rdfs:comment : A location from which a distance is measured. (A distance measurement will have two points, and a distance measurement value).</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : 0dfaa487-6c26-49ed-b2a3-f44024963385^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/distancePoint">ov:distancePoint</a>
    /// </summary>
    let distancePoint = _prefixId.prefix "distancePoint"
    let doesnt_live_here_anymore = _prefixId.prefix "doesnt-live-here-anymore"
    let domicile = _prefixId.prefix "domicile"
    /// <summary>
    ///   <para>label:plural : Earworm Songs</para>
    ///   <para>rdfs:comment : The song that is the focus of a particular earworm</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "bae2faae-baf8-4a4b-9e5d-0d4d644d8e8f"^^xsd:string</para>
    ///   <para>rdfs:label : Earworm Song</para>
    ///   <a href="http://open.vocab.org/terms/earwormSong">ov:earwormSong</a>
    /// </summary>
    let earwormSong = _prefixId.prefix "earwormSong"
    let ``earwormSong.html`` = _prefixId.prefix "earwormSong.html"
    /// <summary>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "c200f00c-80ff-4204-9fa3-140bd40025a3"^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>label:plural : Earworm Sufferers</para>
    ///   <para>rdfs:comment : The person who experiences or suffers from a particular ear worm</para>
    ///   <para>rdfs:label : Earworm Sufferer</para>
    ///   <a href="http://open.vocab.org/terms/earwormSufferer">ov:earwormSufferer</a>
    /// </summary>
    let earwormSufferer = _prefixId.prefix "earwormSufferer"
    let ``earwormSufferer.html`` = _prefixId.prefix "earwormSufferer.html"
    /// <summary>
    ///   <para>label:plural : Earworm Transmitters</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Earworm Transmitter</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "20cb8959-0536-45ab-b44c-e992ee66edbd"^^xsd:string</para>
    ///   <para>rdfs:comment : The transmitter of a particular Earworm</para>
    ///   <a href="http://open.vocab.org/terms/earwormTransmitter">ov:earwormTransmitter</a>
    /// </summary>
    let earwormTransmitter = _prefixId.prefix "earwormTransmitter"
    let ``earwormTransmitter.html`` = _prefixId.prefix "earwormTransmitter.html"
    /// <summary>
    ///   <para>dce:created : 2010-07-30T15:09:08Z^^xsd:dateTime</para>
    ///   <para>rdfs:label : Edit Form</para>
    ///   <para>label:plural : Edit Forms</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a resource with a form that can be used to edit its description. See http://patterns.dataincubator.org/book/edit-trail.html for more information.</para>
    ///   <a href="http://open.vocab.org/terms/editForm">ov:editForm</a>
    /// </summary>
    let editForm = _prefixId.prefix "editForm"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : End Time</para>
    ///   <para>rdfs:comment : The time of day that something ends.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "0479db41-f51c-4faa-8486-ae8337692dd4"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/endTime">ov:endTime</a>
    /// </summary>
    let endTime = _prefixId.prefix "endTime"
    let ``endTime.html`` = _prefixId.prefix "endTime.html"
    /// <summary>
    ///   <para>label:plural : enhanced descriptions</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>ov:markdownDescription : The property can be used in several scenarios the simplest being to refer to an RDF document that provides additional context about a resource. This alone adds little more than rdfs:seeAlso.
    ///
    /// However it is expected that typically a user agent may be issued with an authentication challenge (e.g. at the HTTP protocol level) when attempting to access the document. This would support delivery of "premium" views of a resource as Linked Data. Using this property a user agent could distinguish those documents from others that are simply referred to with an rdfs:seeAlso.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : 09a37218-ac62-494c-9b02-27aee3f6e129^^xsd:string</para>
    ///   <para>rdfs:label : enhanced description</para>
    ///   <para>rdfs:comment : This property is to be used to relate a resource to an "enhanced description". An enhanced description is one that provides additional, richer detail about a resource than may typically be obtained by a simple de-reference of the resource's URI.</para>
    ///   <a href="http://open.vocab.org/terms/enhancedDescription">ov:enhancedDescription</a>
    /// </summary>
    let enhancedDescription = _prefixId.prefix "enhancedDescription"
    let ``enhancedDescription.html`` = _prefixId.prefix "enhancedDescription.html"
    let exampleInstance = _prefixId.prefix "exampleInstance"
    /// <summary>
    ///   <para>label:plural : Example Resources</para>
    ///   <para>rdfs:label : Example Resource</para>
    ///   <para>rdfs:comment : an example resource using a vocabulary term or terms</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>ov:markdownDescription : ex:p ov:exampleResource [ ex:p "example" ] .
    /// ex:C ov:exampleResource [ a ex:C  ] .</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "08960a15-69ec-4190-9759-d67256c68570"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/exampleResource">ov:exampleResource</a>
    /// </summary>
    let exampleResource = _prefixId.prefix "exampleResource"
    let ``exampleResource.html`` = _prefixId.prefix "exampleResource.html"
    /// <summary>
    ///   <para>rdfs:label : Color of Eye of an Individual</para>
    ///   <para>rdfs:comment : Eye Color</para>
    ///   <para>label:plural : Color of Eyes of an Individual</para>
    ///   <para>dce:created : 2011-03-22T20:04:08Z^^xsd:dateTime</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/eyeColor">ov:eyeColor</a>
    /// </summary>
    let eyeColor = _prefixId.prefix "eyeColor"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Familiar Name</para>
    ///   <para>rdfs:comment : The name used in familiar situations by friends, e.g. Ian
    /// </para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "97bc7f71-3dd9-4e51-b75b-686bf817687e"^^xsd:string</para>
    ///   <para>label:plural : Familiar Names</para>
    ///   <a href="http://open.vocab.org/terms/familiarName">ov:familiarName</a>
    /// </summary>
    let familiarName = _prefixId.prefix "familiarName"
    let ``familiarName.html`` = _prefixId.prefix "familiarName.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Favourite Drink</para>
    ///   <para>rdfs:comment : A drink, alcoholic or not, that the person in question is particularly fond of. It's what they would typically order in a place where the drink is available. The object can be a literal stating the name of the drink, or (preferred) an RDF resource.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "97ec2442-9a4f-4af2-bbaa-5a5542983d60"^^xsd:string</para>
    ///   <para>label:plural : Favourite Drink</para>
    ///   <a href="http://open.vocab.org/terms/favouriteDrink">ov:favouriteDrink</a>
    /// </summary>
    let favouriteDrink = _prefixId.prefix "favouriteDrink"
    let ``favouriteDrink.html`` = _prefixId.prefix "favouriteDrink.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : favourite</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "a0be6559-7fb1-43b2-ad95-b4a32c99763a"^^xsd:string</para>
    ///   <para>label:plural : favourite</para>
    ///   <a href="http://open.vocab.org/terms/favouritedBy">ov:favouritedBy</a>
    /// </summary>
    let favouritedBy = _prefixId.prefix "favouritedBy"
    let ``favouritedBy.html`` = _prefixId.prefix "favouritedBy.html"
    /// <summary>
    ///   <para>rdfs:comment : A fax number that can be used to send faxes to a Person or Organisation.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>label:plural : Fax Numbers</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : f6d8ddb3-cc24-42b6-b86e-a794a1621f9b^^xsd:string</para>
    ///   <para>rdfs:label : Fax Number</para>
    ///   <a href="http://open.vocab.org/terms/faxNumber">ov:faxNumber</a>
    /// </summary>
    let faxNumber = _prefixId.prefix "faxNumber"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Feature File</para>
    ///   <para>rdfs:comment : associates a musical item with a feature file describing that item</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "e19352ad-928d-4393-ae82-170efedca7a7"^^xsd:string</para>
    ///   <para>label:plural : Feature Files</para>
    ///   <a href="http://open.vocab.org/terms/featurefile">ov:featurefile</a>
    /// </summary>
    let featurefile = _prefixId.prefix "featurefile"
    let ``featurefile.html`` = _prefixId.prefix "featurefile.html"
    /// <summary>
    ///   <para>rdfs:label : dataset file has fileSize</para>
    ///   <para>dce:created : 2010-05-15T18:50:31Z^^xsd:dateTime</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the size of the file of a dataset in the normal (uncompressed) state</para>
    ///   <a href="http://open.vocab.org/terms/fileSize">ov:fileSize</a>
    /// </summary>
    let fileSize = _prefixId.prefix "fileSize"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Findspot</para>
    ///   <para>rdfs:comment : The place at which a thing is found.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "4a451a70-cf10-41d0-af79-5153a339e112"^^xsd:string</para>
    ///   <para>label:plural : Findspots</para>
    ///   <a href="http://open.vocab.org/terms/findspot">ov:findspot</a>
    /// </summary>
    let findspot = _prefixId.prefix "findspot"
    let ``findspot.html`` = _prefixId.prefix "findspot.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : First Sentence</para>
    ///   <para>rdfs:comment : The first sentence of a resource.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "d0c054eb-1301-4435-b0e9-c26543ceea6d"^^xsd:string</para>
    ///   <para>label:plural : First Sentences</para>
    ///   <a href="http://open.vocab.org/terms/firstSentence">ov:firstSentence</a>
    /// </summary>
    let firstSentence = _prefixId.prefix "firstSentence"
    let ``firstSentence.html`` = _prefixId.prefix "firstSentence.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Friend of a Fro</para>
    ///   <para>rdfs:comment : Use this property to state that you admire a friend's fro</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "b00f1516-b2a6-4844-8dbe-5d4cce398e33"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/foafro">ov:foafro</a>
    /// </summary>
    let foafro = _prefixId.prefix "foafro"
    let ``foafro.html`` = _prefixId.prefix "foafro.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Formal Name</para>
    ///   <para>rdfs:comment : The name used when referred to in formal situations, e.g. Mr. Davis
    /// </para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "d6ea7b0b-ee99-4220-b060-38293560747c"^^xsd:string</para>
    ///   <para>label:plural : Formal Names</para>
    ///   <a href="http://open.vocab.org/terms/formalName">ov:formalName</a>
    /// </summary>
    let formalName = _prefixId.prefix "formalName"
    let ``formalName.html`` = _prefixId.prefix "formalName.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Full Name</para>
    ///   <para>rdfs:comment : The full name as expected to be used on an identifying document e.g. Mr Ian Robert Davis
    /// </para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "64dbc931-a343-46ea-9438-4f279a69cf09"^^xsd:string</para>
    ///   <para>label:plural : Full Name</para>
    ///   <a href="http://open.vocab.org/terms/fullName">ov:fullName</a>
    /// </summary>
    let fullName = _prefixId.prefix "fullName"
    let ``fullName.html`` = _prefixId.prefix "fullName.html"
    /// <summary>
    ///   <para>rdfs:label : Geographic Boundary Definer</para>
    ///   <para>rdfs:comment : The agent that defines the boundaries of a geographic area.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dce:created : 2010-11-10T21:13:29Z^^xsd:dateTime</para>
    ///   <para>label:plural : Geographic Boundary Definers</para>
    ///   <a href="http://open.vocab.org/terms/geoBoundaryDefiner">ov:geoBoundaryDefiner</a>
    /// </summary>
    let geoBoundaryDefiner = _prefixId.prefix "geoBoundaryDefiner"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Geographic QRCode</para>
    ///   <para>rdfs:comment : The value of this property is a QRCode image that encodes the geographic coordinates of the resource. The coordinates are encoded using the WGS84 datum in the following form - geo:[lat],[long]</para>
    ///   <para>label:plural : Geographic QRCodes</para>
    ///   <para>dce:created : 2011-07-11T23:24:29Z^^xsd:dateTime</para>
    ///   <a href="http://open.vocab.org/terms/geoqrcode">ov:geoqrcode</a>
    /// </summary>
    let geoqrcode = _prefixId.prefix "geoqrcode"
    /// <summary>
    ///   <para>rdfs:comment : Boundary point has a position</para>
    ///   <para>rdfs:label : has</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>label:plural : have</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "5d58c32e-8d88-4aab-83e3-df7f1b0bb76e"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/has">ov:has</a>
    /// </summary>
    let has = _prefixId.prefix "has"
    let ``has.html`` = _prefixId.prefix "has.html"
    /// <summary>
    ///   <para>rdfs:label : has boundary</para>
    ///   <para>rdfs:comment : DOMRange has 2 boundary points</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "00ec0301-e6b3-4235-9737-cf33cef44950"^^xsd:string</para>
    ///   <para>label:plural : have boundaries</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/hasBoundary">ov:hasBoundary</a>
    /// </summary>
    let hasBoundary = _prefixId.prefix "hasBoundary"
    let ``hasBoundary.html`` = _prefixId.prefix "hasBoundary.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : has checksum</para>
    ///   <para>rdfs:comment : has checksum - expecting (acronym/name):(checksum hexdigest)
    ///
    /// eg        ov:hasChecksum  "sha1:a526a7c1bc65348dc7649556bee283ee3c999b92"</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "7b9d69fd-2df4-4c7d-9a68-c8890ae90543"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/hasChecksum">ov:hasChecksum</a>
    /// </summary>
    let hasChecksum = _prefixId.prefix "hasChecksum"
    let ``hasChecksum.html`` = _prefixId.prefix "hasChecksum.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Content Type</para>
    ///   <para>rdfs:comment : Encoding MIME-Type information in a trivial manner - equivalent to HTTP header: Content-Type.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "0e8079a2-2449-4887-8568-9acf36c700ed"^^xsd:string</para>
    ///   <para>label:plural : Content Types</para>
    ///   <para>ov:markdownDescription : Use to encode MIME information alongside URIs that correspond to representations of the noted MIME formats.</para>
    ///   <a href="http://open.vocab.org/terms/hasContentType">ov:hasContentType</a>
    /// </summary>
    let hasContentType = _prefixId.prefix "hasContentType"
    let ``hasContentType.html`` = _prefixId.prefix "hasContentType.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : favourite</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "874e8311-ec05-49a7-b641-38a5772bef31"^^xsd:string</para>
    ///   <para>label:plural : favourites</para>
    ///   <a href="http://open.vocab.org/terms/hasFavourited">ov:hasFavourited</a>
    /// </summary>
    let hasFavourited = _prefixId.prefix "hasFavourited"
    let ``hasFavourited.html`` = _prefixId.prefix "hasFavourited.html"
    /// <summary>
    ///   <para>label:plural : has lenders</para>
    ///   <para>dce:created : 2010-11-28T14:41:53Z^^xsd:dateTime</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Domain: any institution or individual who borrows money from loaner
    /// Range: any institution or individual who loans a borrower money</para>
    ///   <para>rdfs:label : Has lender</para>
    ///   <a href="http://open.vocab.org/terms/hasLender">ov:hasLender</a>
    /// </summary>
    let hasLender = _prefixId.prefix "hasLender"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : has MD5 checksum</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "9424ae05-85f0-4975-8e56-9fb295e3f447"^^xsd:string</para>
    ///   <para>label:plural : has MD5 checksums</para>
    ///   <a href="http://open.vocab.org/terms/hasMD5">ov:hasMD5</a>
    /// </summary>
    let hasMD5 = _prefixId.prefix "hasMD5"
    let ``hasMD5.html`` = _prefixId.prefix "hasMD5.html"
    /// <summary>
    ///   <para>rdfs:label : nationality</para>
    ///   <para>label:plural : Nationalities</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : 3c2fe92a-a7ec-4576-afd8-2ad23964ad7b^^xsd:string</para>
    ///   <para>rdfs:comment : Links a person to a country that he or she may be a member. (A person can have multiple nationalities). The domain is foaf:Person but the range is open (although http://dbpedia.org/ontology/Country or http://umbel.org/umbel/rc/Country are suggested)</para>
    ///   <a href="http://open.vocab.org/terms/hasNationality">ov:hasNationality</a>
    /// </summary>
    let hasNationality = _prefixId.prefix "hasNationality"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : has node</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "b1b98130-8b8d-4021-b125-3f44a2399e21"^^xsd:string</para>
    ///   <para>label:plural : has nodes</para>
    ///   <a href="http://open.vocab.org/terms/hasNode">ov:hasNode</a>
    /// </summary>
    let hasNode = _prefixId.prefix "hasNode"
    let ``hasNode.html`` = _prefixId.prefix "hasNode.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : has offset</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "74194e9d-3a50-4d43-851e-5e297456fe9d"^^xsd:string</para>
    ///   <para>label:plural : has offsets</para>
    ///   <para>ov:markdownDescription : TODO: How should this be used? Offset from what?</para>
    ///   <a href="http://open.vocab.org/terms/hasOffset">ov:hasOffset</a>
    /// </summary>
    let hasOffset = _prefixId.prefix "hasOffset"
    let ``hasOffset.html`` = _prefixId.prefix "hasOffset.html"
    /// <summary>
    ///   <para>ov:markdownDescription : Example: a film's plot (http://en.wikipedia.org/wiki/Forrest_Gump#Plot).
    ///
    /// See also http://open.vocab.org/terms/hasPlot</para>
    ///   <para>rdfs:comment : Something has a plot.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "4619db81-f615-4463-b183-969917bfce32"^^xsd:string</para>
    ///   <para>label:plural : hasPlots</para>
    ///   <para>rdfs:label : hasPlot</para>
    ///   <a href="http://open.vocab.org/terms/hasPlot">ov:hasPlot</a>
    /// </summary>
    let hasPlot = _prefixId.prefix "hasPlot"
    let ``hasPlot.html`` = _prefixId.prefix "hasPlot.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : has position</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "2e423a23-cde7-48cb-9e92-cc21332fdafe"^^xsd:string</para>
    ///   <para>label:plural : have positions</para>
    ///   <a href="http://open.vocab.org/terms/hasPosition">ov:hasPosition</a>
    /// </summary>
    let hasPosition = _prefixId.prefix "hasPosition"
    let ``hasPosition.html`` = _prefixId.prefix "hasPosition.html"
    /// <summary>
    ///   <para>label:plural : has ranges</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "94e2e475-f1bd-4ac0-884e-c59418ea5a2c"^^xsd:string</para>
    ///   <para>rdfs:comment : a resource (e.g. HTML content --&gt; awol:Content) has a DOM range</para>
    ///   <para>rdfs:label : has range</para>
    ///   <a href="http://open.vocab.org/terms/hasRange">ov:hasRange</a>
    /// </summary>
    let hasRange = _prefixId.prefix "hasRange"
    let ``hasRange.html`` = _prefixId.prefix "hasRange.html"
    /// <summary>
    ///   <para>label:plural : Hearts</para>
    ///   <para>rdfs:label : Hearts</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Slang for loves.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "d8b21121-64c8-429d-a07e-fbcb39d22ff4"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/hearts">ov:hearts</a>
    /// </summary>
    let hearts = _prefixId.prefix "hearts"
    let ``hearts.html`` = _prefixId.prefix "hearts.html"
    let homepage = _prefixId.prefix "homepage"
    let horse = _prefixId.prefix "horse"
    /// <summary>
    ///   <para>rdfs:comment : color of a house</para>
    ///   <para>ov:markdownDescription : I bet I'm going to wish i could delete this</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "15b175cf-e249-4dce-a2b3-ae6cccb18065"^^xsd:string</para>
    ///   <para>rdfs:label : houseColor</para>
    ///   <para>label:plural : houseColor</para>
    ///   <a href="http://open.vocab.org/terms/houseColor">ov:houseColor</a>
    /// </summary>
    let houseColor = _prefixId.prefix "houseColor"
    let ``houseColor.html`` = _prefixId.prefix "houseColor.html"
    let housePaintColor = _prefixId.prefix "housePaintColor"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : loans before</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "2d376bac-23a8-4e2c-9a7d-423e84fb5ecf"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/hudBefore">ov:hudBefore</a>
    /// </summary>
    let hudBefore = _prefixId.prefix "hudBefore"
    let ``hudBefore.html`` = _prefixId.prefix "hudBefore.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : loans in common</para>
    ///   <para>rdfs:comment : The number of loans two books have in common</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "7fca85bb-d0eb-4be2-a4ae-cb5df73a0ac1"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/hudCommon">ov:hudCommon</a>
    /// </summary>
    let hudCommon = _prefixId.prefix "hudCommon"
    let ``hudCommon.html`` = _prefixId.prefix "hudCommon.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : course</para>
    ///   <para>rdfs:comment : A course associated with a book loan</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "773741a1-9842-42ce-bd24-9caebdf550ef"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/hudCourse">ov:hudCourse</a>
    /// </summary>
    let hudCourse = _prefixId.prefix "hudCourse"
    let ``hudCourse.html`` = _prefixId.prefix "hudCourse.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : loan count</para>
    ///   <para>rdfs:comment : The number of loans of a book within a year, school, or course</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "d86a7d2d-8120-4bee-bbb1-6889fca9bf59"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/hudLoanCount">ov:hudLoanCount</a>
    /// </summary>
    let hudLoanCount = _prefixId.prefix "hudLoanCount"
    let ``hudLoanCount.html`` = _prefixId.prefix "hudLoanCount.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : total loans</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "238d57c2-e3cd-49ac-9aed-93b4712872a7"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/hudLoanTotal">ov:hudLoanTotal</a>
    /// </summary>
    let hudLoanTotal = _prefixId.prefix "hudLoanTotal"
    let ``hudLoanTotal.html`` = _prefixId.prefix "hudLoanTotal.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : same</para>
    ///   <para>rdfs:comment : simultaneous loans</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "e6903663-ad44-42c7-82bf-d3c3b396acfc"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/hudSame">ov:hudSame</a>
    /// </summary>
    let hudSame = _prefixId.prefix "hudSame"
    let ``hudSame.html`` = _prefixId.prefix "hudSame.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : school</para>
    ///   <para>rdfs:comment : The school associated with the loan history of a book</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "52a9580b-e410-4397-93c4-007e0c8a7468"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/hudSchool">ov:hudSchool</a>
    /// </summary>
    let hudSchool = _prefixId.prefix "hudSchool"
    let ``hudSchool.html`` = _prefixId.prefix "hudSchool.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : school loan</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "ab3c1def-5064-4d20-b57d-28bf990264f1"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/hudSchoolLoan">ov:hudSchoolLoan</a>
    /// </summary>
    let hudSchoolLoan = _prefixId.prefix "hudSchoolLoan"
    let ``hudSchoolLoan.html`` = _prefixId.prefix "hudSchoolLoan.html"
    let hudSuggestedBook = _prefixId.prefix "hudSuggestedBook"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : suggestion</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "10325d0c-c101-44d9-bfc7-1d01b09954d5"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/hudSuggestion">ov:hudSuggestion</a>
    /// </summary>
    let hudSuggestion = _prefixId.prefix "hudSuggestion"
    let ``hudSuggestion.html`` = _prefixId.prefix "hudSuggestion.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : year</para>
    ///   <para>rdfs:comment : The year associated with a loan history</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "32c3dfd5-b6da-44f6-b36a-4fd2aa4d4991"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/hudYear">ov:hudYear</a>
    /// </summary>
    let hudYear = _prefixId.prefix "hudYear"
    let ``hudYear.html`` = _prefixId.prefix "hudYear.html"
    /// <summary>
    ///   <para>rdfs:comment : a pictorial representation for something.</para>
    ///   <para>rdfs:label : Icon</para>
    ///   <para>label:plural : Icons</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dce:created : 2010-11-13T17:10:32Z^^xsd:dateTime</para>
    ///   <a href="http://open.vocab.org/terms/icon">ov:icon</a>
    /// </summary>
    let icon = _prefixId.prefix "icon"
    let imWsBhgGVLi = _prefixId.prefix "imWsBhgGVLi"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Image</para>
    ///   <para>rdfs:comment : an image of the resource, whatever it may be. Typically the value of this property will be the URI of some sort of digital image.</para>
    ///   <para>label:plural : Images</para>
    ///   <para>dce:created : 2010-04-20T15:03:38Z^^xsd:dateTime</para>
    ///   <a href="http://open.vocab.org/terms/image">ov:image</a>
    /// </summary>
    let image = _prefixId.prefix "image"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Informal Name</para>
    ///   <para>rdfs:comment : The name used when referred to in informal situations, e.g. Ian Davis
    /// </para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "01be552d-7adf-4404-a476-a352b647a839"^^xsd:string</para>
    ///   <para>label:plural : Informal Names</para>
    ///   <a href="http://open.vocab.org/terms/informalName">ov:informalName</a>
    /// </summary>
    let informalName = _prefixId.prefix "informalName"
    let ``informalName.html`` = _prefixId.prefix "informalName.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : is category of</para>
    ///   <para>rdfs:comment : The value of this property is something that has been classified under the resource</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "967965ac-1341-47b9-9548-12d51fb5050b"^^xsd:string</para>
    ///   <para>label:plural : are categories of</para>
    ///   <a href="http://open.vocab.org/terms/isCategoryOf">ov:isCategoryOf</a>
    /// </summary>
    let isCategoryOf = _prefixId.prefix "isCategoryOf"
    let ``isCategoryOf.html`` = _prefixId.prefix "isCategoryOf.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : curated by</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "0dfc11b3-e58e-435e-87bb-9f91f9421cf9"^^xsd:string</para>
    ///   <para>label:plural : curated by</para>
    ///   <a href="http://open.vocab.org/terms/isCuratedBy">ov:isCuratedBy</a>
    /// </summary>
    let isCuratedBy = _prefixId.prefix "isCuratedBy"
    let ``isCuratedBy.html`` = _prefixId.prefix "isCuratedBy.html"
    /// <summary>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "90391756-74b0-4325-a851-7e1a4b6e07dd"^^xsd:string</para>
    ///   <para>label:plural : are defined by</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : DOMBoundaryPointPosition is defines by a DOMNode and a DOMOffset</para>
    ///   <para>rdfs:label : is defined by</para>
    ///   <a href="http://open.vocab.org/terms/isDefinedBy">ov:isDefinedBy</a>
    /// </summary>
    let isDefinedBy = _prefixId.prefix "isDefinedBy"
    let ``isDefinedBy.html`` = _prefixId.prefix "isDefinedBy.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Header</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "463ac0dc-1778-456b-8653-4efdd97da7e5"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/isHeaderOf">ov:isHeaderOf</a>
    /// </summary>
    let isHeaderOf = _prefixId.prefix "isHeaderOf"
    let ``isHeaderOf.html`` = _prefixId.prefix "isHeaderOf.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : is member of</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : 37ef7bf9-9e9b-4ac0-a8fd-56164a51dab9^^xsd:string</para>
    ///   <para>rdfs:comment : Property to link an agent with an organization (inverse property of http://xmlns.com/foaf/0.1/member)</para>
    ///   <a href="http://open.vocab.org/terms/isMemberOf">ov:isMemberOf</a>
    /// </summary>
    let isMemberOf = _prefixId.prefix "isMemberOf"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : is Song of Earworm</para>
    ///   <para>rdfs:comment : A song which is the focus of a particular Earworm</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "ae14c996-3b3a-440f-984d-cd79e4df59fc"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/isSongOfEarworm">ov:isSongOfEarworm</a>
    /// </summary>
    let isSongOfEarworm = _prefixId.prefix "isSongOfEarworm"
    let ``isSongOfEarworm.html`` = _prefixId.prefix "isSongOfEarworm.html"
    /// <summary>
    ///   <para>rdfs:label : JSON</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : a5b686c5-df11-46df-8eb5-2b94c207f500^^xsd:string</para>
    ///   <para>label:plural : JSON representations</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : The JSON representation of a (usually small) dataset.</para>
    ///   <a href="http://open.vocab.org/terms/json">ov:json</a>
    /// </summary>
    let json = _prefixId.prefix "json"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : keywords</para>
    ///   <para>rdfs:comment : A comma separated list of words that are particularly pertinent to this resource.</para>
    ///   <para>label:plural : keywords</para>
    ///   <para>dce:created : 2010-04-13T19:54:30Z^^xsd:dateTime</para>
    ///   <a href="http://open.vocab.org/terms/keywords">ov:keywords</a>
    /// </summary>
    let keywords = _prefixId.prefix "keywords"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Kilometres</para>
    ///   <para>rdfs:comment : The number of kilometres of a distance measurement.</para>
    ///   <para>dce:created : 2011-08-19T07:40:06Z^^xsd:dateTime</para>
    ///   <a href="http://open.vocab.org/terms/kilometres">ov:kilometres</a>
    /// </summary>
    let kilometres = _prefixId.prefix "kilometres"
    /// <summary>
    ///   <para>ov:markdownDescription : For example, if you have a DOAP project and want to ack some input re contribution, tester, feedback, etc. you would go like:
    ///
    ///     :myproject a doap:Project ;
    ///                ov:kudos :John .
    ///
    /// or, on a more personal level, it would be:
    ///
    ///     :me ov:kudos :John .</para>
    ///   <para>label:plural : kudos to</para>
    ///   <para>rdfs:comment : to express kudos to someone (acknowledge a contribution, feedback, etc.) </para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "cd58f6d1-d6a7-45f6-9de0-67b0ac5c4d84"^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : kudos to</para>
    ///   <a href="http://open.vocab.org/terms/kudosTo">ov:kudosTo</a>
    /// </summary>
    let kudosTo = _prefixId.prefix "kudosTo"
    let ``kudosTo.html`` = _prefixId.prefix "kudosTo.html"
    /// <summary>
    ///   <para>dce:created : 2011-04-26T14:37:11Z^^xsd:dateTime</para>
    ///   <para>rdfs:comment : The most recently cached static page describing the resource.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Last Cached Page</para>
    ///   <a href="http://open.vocab.org/terms/lastCachedPage">ov:lastCachedPage</a>
    /// </summary>
    let lastCachedPage = _prefixId.prefix "lastCachedPage"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Length</para>
    ///   <para>rdfs:comment : The linear extent of a thing.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "688982a5-ddaa-4d03-9a3f-0fe23b1385be"^^xsd:string</para>
    ///   <para>label:plural : Lengths</para>
    ///   <para>ov:markdownDescription : For example: the road has a length of 1 mile.</para>
    ///   <a href="http://open.vocab.org/terms/length">ov:length</a>
    /// </summary>
    let length = _prefixId.prefix "length"
    let ``length.html`` = _prefixId.prefix "length.html"
    /// <summary>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : f1fda987-bf88-4b60-be43-c69e24f1cbb6^^xsd:string</para>
    ///   <para>rdfs:comment : A service providing access to bibliographic resources.</para>
    ///   <para>label:plural : Library Services</para>
    ///   <para>rdfs:label : Library Service</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/libraryService">ov:libraryService</a>
    /// </summary>
    let libraryService = _prefixId.prefix "libraryService"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : machine-tag</para>
    ///   <para>rdfs:comment : a machine tag that can be used to identify the domain resource in tagging applications. </para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "88817428-a23c-444b-abf8-c9c10d6778f6"^^xsd:string</para>
    ///   <para>ov:markdownDescription : eg:
    ///
    /// _:x ov:machineTag "lastfm:event=863464" .</para>
    ///   <a href="http://open.vocab.org/terms/machineTag">ov:machineTag</a>
    /// </summary>
    let machineTag = _prefixId.prefix "machineTag"
    let ``machineTag.html`` = _prefixId.prefix "machineTag.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : place where made</para>
    ///   <para>rdfs:comment : The place where a particular object was made. (Made is left intentionally vague and follows the same semantics as foaf:maker, foaf:made etc.)</para>
    ///   <para>label:plural : places where made</para>
    ///   <para>dce:created : 2011-03-10T16:56:41Z^^xsd:dateTime</para>
    ///   <a href="http://open.vocab.org/terms/madeIn">ov:madeIn</a>
    /// </summary>
    let madeIn = _prefixId.prefix "madeIn"
    /// <summary>
    ///   <para>rdfs:comment : A person's maiden name.</para>
    ///   <para>dce:created : 2010-11-29T21:48:32Z^^xsd:dateTime</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Maiden Name</para>
    ///   <para>label:plural : Maiden Names</para>
    ///   <a href="http://open.vocab.org/terms/maidenName">ov:maidenName</a>
    /// </summary>
    let maidenName = _prefixId.prefix "maidenName"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : manchester syntax</para>
    ///   <para>rdfs:comment : The Manchester Syntax for a owl construct (e.g., Restriction).
    ///
    /// :manchex rdfs:subPropertyOf rdfs:label .</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "61eea541-a1e1-4d83-acc9-5cc85222842b"^^xsd:string</para>
    ///   <para>label:plural : manchester syntax</para>
    ///   <a href="http://open.vocab.org/terms/manchax">ov:manchax</a>
    /// </summary>
    let manchax = _prefixId.prefix "manchax"
    let ``manchax.html`` = _prefixId.prefix "manchax.html"
    let markdownDescription = _prefixId.prefix "markdownDescription"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a resource that is designed to be a mirror or surrogate of the object resource; a backup copy, should the object resource be lost or unobtainable.</para>
    ///   <para>ov:markdownDescription : Consider a resource at http://flickr/set/image1.jpg - if you make a backup or mirror of this resource at a resolvable location, such as http://mirror/flickr_bkup1.jpg, you can indicate it like this:
    ///
    /// &amp;lt;http://mirror/flickr_bkup1.jpg&amp;gt; &amp;lt;o:mirror&amp;gt; &amp;lt;http://flickr/set/image1.jpg&amp;gt;</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>label:plural : Mirrors</para>
    ///   <para>rdfs:label : Mirror</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "13f9dd34-e86a-4fb2-99d4-5ff2f872c1d3"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/mirror">ov:mirror</a>
    /// </summary>
    let mirror = _prefixId.prefix "mirror"
    let ``mirror.html`` = _prefixId.prefix "mirror.html"
    let mllxMBbjeh = _prefixId.prefix "mllxMBbjeh"
    /// <summary>
    ///   <para>rdfs:label : MOT Vehicle Classes</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : The Vehicle Classes an MOT Test Station is authorised to test, as a comma separated list using Arabic numerals (plus A where appropriate), e.g "3, 4, 4A, 5".</para>
    ///   <para>dce:created : 2011-07-26T14:39:30Z^^xsd:dateTime</para>
    ///   <a href="http://open.vocab.org/terms/motVehicleClasses">ov:motVehicleClasses</a>
    /// </summary>
    let motVehicleClasses = _prefixId.prefix "motVehicleClasses"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Named place</para>
    ///   <para>rdfs:comment : Places named in a text.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "2a8698b8-4369-44c6-94b9-a0a31fd80853"^^xsd:string</para>
    ///   <para>label:plural : Named places</para>
    ///   <a href="http://open.vocab.org/terms/namedPlace">ov:namedPlace</a>
    /// </summary>
    let namedPlace = _prefixId.prefix "namedPlace"
    let ``namedPlace.html`` = _prefixId.prefix "namedPlace.html"
    /// <summary>
    ///   <para>ov:markdownDescription : e.g. HU396753.
    ///
    /// rdfs:seeAlso &lt;http://en.wikipedia.org/wiki/British_national_grid_reference_system&gt; .</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "ffea01be-32b5-4e1c-bcfe-93e2bac816cb"^^xsd:string</para>
    ///   <para>label:plural : National Grid References</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : National Grid Reference</para>
    ///   <para>rdfs:comment : A (UK) national grid reference for a given location, using the alphanumeric syntax.</para>
    ///   <a href="http://open.vocab.org/terms/national-grid-reference">ov:national-grid-reference</a>
    /// </summary>
    let national_grid_reference = _prefixId.prefix "national-grid-reference"

    let ``national_grid_reference.html`` =
        _prefixId.prefix "national-grid-reference.html"

    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : National Context Map</para>
    ///   <para>rdfs:comment : This property is a relationship between some thing and a map that shows that thing's location at a national scale.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "f99aea55-e85d-4d9e-aadd-be6400b4aeb5"^^xsd:string</para>
    ///   <para>label:plural : National Context Maps</para>
    ///   <a href="http://open.vocab.org/terms/nationalContextMap">ov:nationalContextMap</a>
    /// </summary>
    let nationalContextMap = _prefixId.prefix "nationalContextMap"
    let ``nationalContextMap.html`` = _prefixId.prefix "nationalContextMap.html"
    /// <summary>
    ///   <para>dce:created : 2010-08-09T14:20:53Z^^xsd:dateTime</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : x is 'near' y if they are near to each other in physical space, for a deliberately vague notion of near.</para>
    ///   <para>rdfs:label : Near</para>
    ///   <a href="http://open.vocab.org/terms/near">ov:near</a>
    /// </summary>
    let near = _prefixId.prefix "near"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : The desired visibility of a User's social network. Suggested options: "Just Me", "My Network", "Everyone".</para>
    ///   <para>label:plural : Network Visibilities</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "ef877b9e-598f-4503-846f-9b061ade7d37"^^xsd:string</para>
    ///   <para>rdfs:label : Network Visibility</para>
    ///   <a href="http://open.vocab.org/terms/networkVisibility">ov:networkVisibility</a>
    /// </summary>
    let networkVisibility = _prefixId.prefix "networkVisibility"
    let ``networkVisibility.html`` = _prefixId.prefix "networkVisibility.html"
    /// <summary>
    ///   <para>rdfs:comment : a total count of the number of resources of type &lt;http://purl.org/stuff/rev#Review&gt; that an Agent is known to have created </para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "0f61ce69-5841-4fe4-94fb-d743fa063462"^^xsd:string</para>
    ///   <para>rdfs:label : Number of Reviews Written</para>
    ///   <a href="http://open.vocab.org/terms/noOfReviewsWritten">ov:noOfReviewsWritten</a>
    /// </summary>
    let noOfReviewsWritten = _prefixId.prefix "noOfReviewsWritten"
    let ``noOfReviewsWritten.html`` = _prefixId.prefix "noOfReviewsWritten.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Number of Pages</para>
    ///   <para>rdfs:comment : The number of pages a resource has</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "3a8091eb-3d1d-495f-80c2-765fb4218564"^^xsd:string</para>
    ///   <para>label:plural : Numbers of Pages</para>
    ///   <a href="http://open.vocab.org/terms/numberOfPages">ov:numberOfPages</a>
    /// </summary>
    let numberOfPages = _prefixId.prefix "numberOfPages"
    let ``numberOfPages.html`` = _prefixId.prefix "numberOfPages.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dce:created : 2011-06-23T07:43:22Z^^xsd:dateTime</para>
    ///   <para>rdfs:label : Offering organization</para>
    ///   <para>rdfs:comment : Organization who offers the course, e.g. a department, a school, a research institute</para>
    ///   <a href="http://open.vocab.org/terms/offeredBy">ov:offeredBy</a>
    /// </summary>
    let offeredBy = _prefixId.prefix "offeredBy"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Course offered by the organization</para>
    ///   <para>dce:created : 2011-06-23T07:45:21Z^^xsd:dateTime</para>
    ///   <para>label:plural : Offered courses</para>
    ///   <para>rdfs:label : Offered course</para>
    ///   <a href="http://open.vocab.org/terms/offersCourse">ov:offersCourse</a>
    /// </summary>
    let offersCourse = _prefixId.prefix "offersCourse"
    /// <summary>
    ///   <para>label:plural : Okkam IDs</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "192d3251-24d6-4765-93a1-8f9c93a1dccf"^^xsd:string</para>
    ///   <para>rdfs:comment : the okkam ID of the entity, given in human legible form (literal)</para>
    ///   <para>rdfs:label : Okkam ID</para>
    ///   <a href="http://open.vocab.org/terms/okkamID">ov:okkamID</a>
    /// </summary>
    let okkamID = _prefixId.prefix "okkamID"
    let ``okkamID.html`` = _prefixId.prefix "okkamID.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Origin</para>
    ///   <para>rdfs:comment : The source of a thing.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "fdfa050f-e161-49f0-8565-bb7974ff908e"^^xsd:string</para>
    ///   <para>label:plural : Origins</para>
    ///   <para>ov:markdownDescription : For example: the Macedonian mint at Acanthus is the origin of the coin described at http://numismatics.org/collection/2008.39.18.</para>
    ///   <a href="http://open.vocab.org/terms/origin">ov:origin</a>
    /// </summary>
    let origin = _prefixId.prefix "origin"
    let ``origin.html`` = _prefixId.prefix "origin.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Originally from time and place</para>
    ///   <para>rdfs:comment : A thing that came into existence at a place and time originates from that place and time.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "f458a16b-81d5-454b-97ac-76e768f5e727"^^xsd:string</para>
    ///   <para>label:plural : Originally from time and place</para>
    ///   <para>ov:markdownDescription : The inscription described at http://insaph.kcl.ac.uk/iaph2007/iAph120214.html originates from the ancient place known as Aphrodisias.</para>
    ///   <a href="http://open.vocab.org/terms/originatesFrom">ov:originatesFrom</a>
    /// </summary>
    let originatesFrom = _prefixId.prefix "originatesFrom"
    let ``originatesFrom.html`` = _prefixId.prefix "originatesFrom.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Part</para>
    ///   <para>rdfs:comment : An element of a whole.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "9e7b32aa-090e-466f-99d2-979d738b5416"^^xsd:string</para>
    ///   <para>label:plural : Parts</para>
    ///   <para>ov:markdownDescription : Example: wheel is a part of a car.</para>
    ///   <a href="http://open.vocab.org/terms/part">ov:part</a>
    /// </summary>
    let part = _prefixId.prefix "part"
    let ``part.html`` = _prefixId.prefix "part.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>label:plural : Passwords</para>
    ///   <para>ov:markdownDescription : this is just adding a password property to a user so SIOC can be used to completely specify logins - not sure if this violates a whole lotta best practice etc :P</para>
    ///   <para>rdfs:label : Password</para>
    ///   <para>rdfs:comment : a password usually stored in md5</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "3e65757b-cecc-42c7-a45f-51c6c9ac3087"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/passwd">ov:passwd</a>
    /// </summary>
    let passwd = _prefixId.prefix "passwd"
    let ``passwd.html`` = _prefixId.prefix "passwd.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Performer</para>
    ///   <para>rdfs:comment : 7dFHvo  &lt;a href="http://nussehqldled.com/"&gt;nussehqldled&lt;/a&gt;, [url=http://uvurwqyxjgik.com/]uvurwqyxjgik[/url], [link=http://yqeuzuciwezi.com/]yqeuzuciwezi[/link], http://sdzwxhzsaaqq.com/</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : 092dcc48-9721-454d-834e-e365ced438da^^xsd:string</para>
    ///   <para>label:plural : Performers</para>
    ///   <para>ov:markdownDescription : 7dFHvo  &lt;a href="http://nussehqldled.com/"&gt;nussehqldled&lt;/a&gt;, [url=http://uvurwqyxjgik.com/]uvurwqyxjgik[/url], [link=http://yqeuzuciwezi.com/]yqeuzuciwezi[/link], http://sdzwxhzsaaqq.com/</para>
    ///   <a href="http://open.vocab.org/terms/performer">ov:performer</a>
    /// </summary>
    let performer = _prefixId.prefix "performer"
    let ``performer.html`` = _prefixId.prefix "performer.html"
    /// <summary>
    ///   <para>rdfs:comment : A telephone number that can be used to contact a Person or Organisation.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dce:created : 2011-05-09T14:40:02Z^^xsd:dateTime</para>
    ///   <para>label:plural : Phone Numbers</para>
    ///   <para>rdfs:label : Phone Number</para>
    ///   <a href="http://open.vocab.org/terms/phoneNumber">ov:phoneNumber</a>
    /// </summary>
    let phoneNumber = _prefixId.prefix "phoneNumber"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Plot</para>
    ///   <para>rdfs:comment : A plot of anything.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "bd674106-2f64-43d4-a80b-9a1aaac45c3c"^^xsd:string</para>
    ///   <para>label:plural : Plots</para>
    ///   <para>ov:markdownDescription : Example: a film's plot.</para>
    ///   <a href="http://open.vocab.org/terms/plot">ov:plot</a>
    /// </summary>
    let plot = _prefixId.prefix "plot"
    let ``plot.html`` = _prefixId.prefix "plot.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>label:plural : Postal Addresses</para>
    ///   <para>rdfs:label : Postal Address</para>
    ///   <para>dce:created : 2011-05-09T14:56:05Z^^xsd:dateTime</para>
    ///   <para>rdfs:comment : A postal address to which letters and parcels can be sent to a Person or Organisation.</para>
    ///   <a href="http://open.vocab.org/terms/postalAddress">ov:postalAddress</a>
    /// </summary>
    let postalAddress = _prefixId.prefix "postalAddress"
    /// <summary>
    ///   <para>label:plural : preferred acronyms</para>
    ///   <para>rdfs:comment : Preferred or official acronym as used by the subject.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "94a8c193-11e3-4145-9487-e42fa044264a"^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : preferred acronym</para>
    ///   <a href="http://open.vocab.org/terms/prefAcronym">ov:prefAcronym</a>
    /// </summary>
    let prefAcronym = _prefixId.prefix "prefAcronym"
    let ``prefAcronym.html`` = _prefixId.prefix "prefAcronym.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Preferred animal</para>
    ///   <para>rdfs:comment : The preferred animal of a person.</para>
    ///   <para>label:plural : Preferred animals</para>
    ///   <para>dce:created : 2011-10-26T16:41:18Z^^xsd:dateTime</para>
    ///   <a href="http://open.vocab.org/terms/preferredAnimal">ov:preferredAnimal</a>
    /// </summary>
    let preferredAnimal = _prefixId.prefix "preferredAnimal"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : primary material</para>
    ///   <para>rdfs:comment : The primary material from which something is made.
    ///
    /// Examples: leather (shoe), paper (book), cotton (t-shirt), nylon (tights), plastic (carrier bag), rubber (wellington boots), iron (pipe) etc.</para>
    ///   <para>label:plural : primary materials</para>
    ///   <para>dce:created : 2011-03-10T17:05:00Z^^xsd:dateTime</para>
    ///   <a href="http://open.vocab.org/terms/primaryMaterial">ov:primaryMaterial</a>
    /// </summary>
    let primaryMaterial = _prefixId.prefix "primaryMaterial"
    /// <summary>
    ///   <para>rdfs:comment : It is about provenance of web data.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : provenance</para>
    ///   <para>dce:created : 2011-09-21T15:47:49Z^^xsd:dateTime</para>
    ///   <para>label:plural : provenance</para>
    ///   <a href="http://open.vocab.org/terms/provenance">ov:provenance</a>
    /// </summary>
    let provenance = _prefixId.prefix "provenance"
    let quote = _prefixId.prefix "quote"
    /// <summary>
    ///   <para>rdfs:comment : The rank of the resource within the ordered collection represented by the current document</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "654d9139-0ddb-4688-9ad3-ae61fbf6880d"^^xsd:string</para>
    ///   <para>rdfs:label : rank</para>
    ///   <para>ov:markdownDescription : The first resource has an ov:rank of 1.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>label:plural : ranks</para>
    ///   <a href="http://open.vocab.org/terms/rank">ov:rank</a>
    /// </summary>
    let rank = _prefixId.prefix "rank"
    let ``rank.html`` = _prefixId.prefix "rank.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Read Graph</para>
    ///   <para>rdfs:comment : express the ability/right to read from a graph</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "286bc858-e567-4471-9c6f-376728559aab"^^xsd:string</para>
    ///   <para>label:plural : Read Graph</para>
    ///   <a href="http://open.vocab.org/terms/readGraph">ov:readGraph</a>
    /// </summary>
    let readGraph = _prefixId.prefix "readGraph"
    let ``readGraph.html`` = _prefixId.prefix "readGraph.html"
    /// <summary>
    ///   <para>rdfs:comment : A property to capture an un-intepreted written address, notably for addresses that have yet to be or can never be semantically represented using an existing scheme, such as the vcard ontology.</para>
    ///   <para>label:plural : recorded addresses</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : recorded address</para>
    ///   <para>dce:created : 2010-09-30T23:51:51Z^^xsd:dateTime</para>
    ///   <a href="http://open.vocab.org/terms/recordedAddress">ov:recordedAddress</a>
    /// </summary>
    let recordedAddress = _prefixId.prefix "recordedAddress"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Regional Context Map</para>
    ///   <para>rdfs:comment : This property is a relationship between some thing and a map that shows that thing's location at a regional scale.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "0207514f-eb63-4a0b-882b-6491576f8925"^^xsd:string</para>
    ///   <para>label:plural : Regional Context Maps</para>
    ///   <a href="http://open.vocab.org/terms/regionalContextMap">ov:regionalContextMap</a>
    /// </summary>
    let regionalContextMap = _prefixId.prefix "regionalContextMap"
    let ``regionalContextMap.html`` = _prefixId.prefix "regionalContextMap.html"
    /// <summary>
    ///   <para>rdfs:comment : Defines reincarnation of someone</para>
    ///   <para>label:plural : Reincarnations of an Individual</para>
    ///   <para>dce:created : 2011-03-22T21:36:14Z^^xsd:dateTime</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Reincarnation of an Individual</para>
    ///   <a href="http://open.vocab.org/terms/reincarnationOf">ov:reincarnationOf</a>
    /// </summary>
    let reincarnationOf = _prefixId.prefix "reincarnationOf"
    /// <summary>
    ///   <para>rdfs:label : Responsible organization</para>
    ///   <para>rdfs:comment : Organization who is responsible for (offers) the course. Like a department, a school...</para>
    ///   <para>dce:created : 2011-06-23T07:39:37Z^^xsd:dateTime</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/responsiblityOf">ov:responsiblityOf</a>
    /// </summary>
    let responsiblityOf = _prefixId.prefix "responsiblityOf"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : result from</para>
    ///   <para>rdfs:comment : The result of the test case obtained from the target specified. For example, the target could be a script that is executed.</para>
    ///   <para>dce:created : 2010-07-03T09:13:15Z^^xsd:dateTime</para>
    ///   <a href="http://open.vocab.org/terms/resultFrom">ov:resultFrom</a>
    /// </summary>
    let resultFrom = _prefixId.prefix "resultFrom"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Diameter at rim</para>
    ///   <para>rdfs:comment : The diameter of a thing measured at its rim.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "10f94170-61b1-4482-8ad6-125705b3b490"^^xsd:string</para>
    ///   <para>ov:markdownDescription : Indicates that a property is the measurement of the diameter of a rim.</para>
    ///   <a href="http://open.vocab.org/terms/rimDiameter">ov:rimDiameter</a>
    /// </summary>
    let rimDiameter = _prefixId.prefix "rimDiameter"
    let ``rimDiameter.html`` = _prefixId.prefix "rimDiameter.html"
    let rtfm = _prefixId.prefix "rtfm"
    /// <summary>
    ///   <para>rdfs:label : screenshot</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>label:plural : screenshots</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : 8d11d38d-217b-4c9f-bab0-de0af3c3a269^^xsd:string</para>
    ///   <para>rdfs:comment : A screenshot showing the (software) project in action. Since DOAP only has a property to link a "web page with screenshots of project", not a specific screenshot, this property is sometimes more useful.</para>
    ///   <a href="http://open.vocab.org/terms/screenshot">ov:screenshot</a>
    /// </summary>
    let screenshot = _prefixId.prefix "screenshot"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Semester</para>
    ///   <para>rdfs:comment : Semester in which the course is offered</para>
    ///   <para>dce:created : 2011-06-23T09:56:11Z^^xsd:dateTime</para>
    ///   <a href="http://open.vocab.org/terms/semester">ov:semester</a>
    /// </summary>
    let semester = _prefixId.prefix "semester"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Shape</para>
    ///   <para>rdfs:comment : The shape of something</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "c3070d4a-3b2c-4fbf-af84-54446f760470"^^xsd:string</para>
    ///   <para>label:plural : Shapes</para>
    ///   <a href="http://open.vocab.org/terms/shape">ov:shape</a>
    /// </summary>
    let shape = _prefixId.prefix "shape"
    let ``shape.html`` = _prefixId.prefix "shape.html"
    /// <summary>
    ///   <para>rdfs:label : Short Name</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "fea8a476-61dd-41d4-a80f-afb8aab80658"^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Just a simple readable name, a mnemonic. </para>
    ///   <para>label:plural : Short Names</para>
    ///   <a href="http://open.vocab.org/terms/shortName">ov:shortName</a>
    /// </summary>
    let shortName = _prefixId.prefix "shortName"
    let ``shortName.html`` = _prefixId.prefix "shortName.html"
    /// <summary>
    ///   <para>label:plural : Signature Scents</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dce:created : 2011-01-14T15:36:51Z^^xsd:dateTime</para>
    ///   <para>rdfs:label : Signature Scent</para>
    ///   <para>rdfs:comment : Relate a thing (usually a person) to the scent with which they are most commonly associated.</para>
    ///   <a href="http://open.vocab.org/terms/signatureScent">ov:signatureScent</a>
    /// </summary>
    let signatureScent = _prefixId.prefix "signatureScent"
    /// <summary>
    ///   <para>rdfs:comment : Having two things that are not the owl:sameAs but are similar to a certain extent. It is thought of being used where owl:sameAs is too strong but rdfs:seeAlso is too loose. Motivation: http://lists.w3.org/Archives/Public/public-lod/2009Feb/0189.html</para>
    ///   <para>rdfs:label : similar to</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : bc9f8c5f-96b2-4812-a1eb-e2aafe15525d^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/similarTo">ov:similarTo</a>
    /// </summary>
    let similarTo = _prefixId.prefix "similarTo"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Sindice Result Count</para>
    ///   <para>rdfs:comment : The number of results retrieved for a search on that uri from the Search Engine sindice</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "89321468-019a-42b2-88ff-e90d52001ecf"^^xsd:string</para>
    ///   <para>label:plural : Sindice Result Counts</para>
    ///   <a href="http://open.vocab.org/terms/sindiceResultCount">ov:sindiceResultCount</a>
    /// </summary>
    let sindiceResultCount = _prefixId.prefix "sindiceResultCount"
    let ``sindiceResultCount.html`` = _prefixId.prefix "sindiceResultCount.html"
    /// <summary>
    ///   <para>rdfs:comment : Someone's ID in the Skype chat and telephony service.</para>
    ///   <para>rdfs:label : Skype ID</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "2c9baf94-f6ec-45d3-a97d-2f2ed36b4d47"^^xsd:string</para>
    ///   <para>label:plural : Skype IDs</para>
    ///   <a href="http://open.vocab.org/terms/skypeID">ov:skypeID</a>
    /// </summary>
    let skypeID = _prefixId.prefix "skypeID"
    let ``skypeID.html`` = _prefixId.prefix "skypeID.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Sort name</para>
    ///   <para>rdfs:comment : Associate a name that can be used for sorting to a foaf:Agent</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "dbdb6bb8-f865-42d5-858c-787e94137cc2"^^xsd:string</para>
    ///   <para>label:plural : Sort names</para>
    ///   <para>ov:markdownDescription : Isn't this the same thing as sortLabel?</para>
    ///   <a href="http://open.vocab.org/terms/sort-name">ov:sort-name</a>
    /// </summary>
    let sort_name = _prefixId.prefix "sort-name"
    let ``sort_name.html`` = _prefixId.prefix "sort-name.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Sort Label</para>
    ///   <para>rdfs:comment : A label for a resource that is syntactically arranged to be suitable for sorting</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "32eeb99b-1398-41ea-af96-d212e85dc1e3"^^xsd:string</para>
    ///   <para>label:plural : Sort Labels</para>
    ///   <a href="http://open.vocab.org/terms/sortLabel">ov:sortLabel</a>
    /// </summary>
    let sortLabel = _prefixId.prefix "sortLabel"
    let ``sortLabel.html`` = _prefixId.prefix "sortLabel.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Source File</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "f8f8af21-127d-4a4a-93ec-2628a215fb3b"^^xsd:string</para>
    ///   <para>rdfs:comment : associates a given feature file document with the audio file that is described by that document</para>
    ///   <para>label:plural : Source Files</para>
    ///   <a href="http://open.vocab.org/terms/sourcefile">ov:sourcefile</a>
    /// </summary>
    let sourcefile = _prefixId.prefix "sourcefile"
    let ``sourcefile.html`` = _prefixId.prefix "sourcefile.html"
    /// <summary>
    ///   <para>label:plural : Specifications</para>
    ///   <para>rdfs:comment : The specification(s) that the resource implemented. </para>
    ///   <para>rdfs:label : Specification</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>ov:markdownDescription : a foaf Personal Profile Document could use this property to link to the foaf specification. a voiD Document could point to the void guide. </para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "665d3614-3642-4c39-9aa6-79025e52593e"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/specification">ov:specification</a>
    /// </summary>
    let specification = _prefixId.prefix "specification"
    let ``specification.html`` = _prefixId.prefix "specification.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Start Time</para>
    ///   <para>rdfs:comment : The time of day that something starts at.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "ed5a1325-8187-45d1-806c-84041c640dd4"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/startTime">ov:startTime</a>
    /// </summary>
    let startTime = _prefixId.prefix "startTime"
    let ``startTime.html`` = _prefixId.prefix "startTime.html"
    /// <summary>
    ///   <para>rdfs:comment : Asserts that a reified rdf:Statement is asserted (in a non-reified form) by a particular RDF graph.</para>
    ///   <para>ov:markdownDescription : Note that http://www.w3.org/2000/10/swap/log#Formula is not equivalent to an RDF/XML, Turtle, etc document. Instead, there is a log:semantics relationship between the two.</para>
    ///   <para>label:plural : statements</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : statement</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "d4fff330-663b-47e8-a0b5-445d1a2558d8"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/statement">ov:statement</a>
    /// </summary>
    let statement = _prefixId.prefix "statement"
    let ``statement.html`` = _prefixId.prefix "statement.html"
    /// <summary>
    ///   <para>rdfs:comment : A human readable description of the status of an opmv:Process upon completion.</para>
    ///   <para>dce:created : 2011-11-15T16:43:35Z^^xsd:dateTime</para>
    ///   <para>rdfs:label : Status</para>
    ///   <para>label:plural : Status</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/status">ov:status</a>
    /// </summary>
    let status = _prefixId.prefix "status"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Stickiness</para>
    ///   <para>rdfs:comment : The the measure of how sticky something is</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "4162307a-3a97-4e5e-82c1-dc28da32b515"^^xsd:string</para>
    ///   <para>label:plural : Stickiness</para>
    ///   <a href="http://open.vocab.org/terms/stickiness">ov:stickiness</a>
    /// </summary>
    let stickiness = _prefixId.prefix "stickiness"
    let ``stickiness.html`` = _prefixId.prefix "stickiness.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : studies</para>
    ///   <para>rdfs:comment : A topic or work that is studied by a person or group (e.g., a university course)</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "cd417984-645d-4269-ad0b-96eaaf088d71"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/studies">ov:studies</a>
    /// </summary>
    let studies = _prefixId.prefix "studies"
    let ``studies.html`` = _prefixId.prefix "studies.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Subtitle</para>
    ///   <para>rdfs:comment : An additional or secondary title usually used expand or limit the main title</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "0792f83f-5f04-472d-8af5-4d3463e43296"^^xsd:string</para>
    ///   <para>label:plural : Subtitles</para>
    ///   <a href="http://open.vocab.org/terms/subtitle">ov:subtitle</a>
    /// </summary>
    let subtitle = _prefixId.prefix "subtitle"
    let ``subtitle.html`` = _prefixId.prefix "subtitle.html"
    /// <summary>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : 2e4b1f01-6923-4773-a03e-ba4f161ad91b^^xsd:string</para>
    ///   <para>ov:markdownDescription : OPmgaB  &lt;a href="http://rzhwdczsolbm.com/"&gt;rzhwdczsolbm&lt;/a&gt;, [url=http://vzwzwxpxvscp.com/]vzwzwxpxvscp[/url], [link=http://heqqpioawnyl.com/]heqqpioawnyl[/link], http://otywxgzucbbi.com/</para>
    ///   <para>label:plural : Suffers Earworm</para>
    ///   <para>rdfs:comment : Relates a person to an earworm that they suffer.</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Suffers Earworm</para>
    ///   <a href="http://open.vocab.org/terms/suffersEarworm">ov:suffersEarworm</a>
    /// </summary>
    let suffersEarworm = _prefixId.prefix "suffersEarworm"
    /// <summary>
    ///   <para>label:plural : syndicate</para>
    ///   <para>rdfs:comment : An agent syndicates a document some way.</para>
    ///   <para>rdfs:label : syndicates</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>dce:created : 2011-03-16T22:53:07Z^^xsd:dateTime</para>
    ///   <a href="http://open.vocab.org/terms/syndicates">ov:syndicates</a>
    /// </summary>
    let syndicates = _prefixId.prefix "syndicates"
    /// <summary>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "7139ef2e-4956-480b-8506-59ae4f7b1dab"^^xsd:string</para>
    ///   <para>label:plural : Tagging Counts</para>
    ///   <para>rdfs:label : Tagging Count</para>
    ///   <para>rdfs:comment : the number of times a tag has been used in taggings of things</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/taggingCount">ov:taggingCount</a>
    /// </summary>
    let taggingCount = _prefixId.prefix "taggingCount"
    let ``taggingCount.html`` = _prefixId.prefix "taggingCount.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Teaches</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "52cd80c3-44c2-47d3-9744-6d0ffb813ed1"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/teaches">ov:teaches</a>
    /// </summary>
    let teaches = _prefixId.prefix "teaches"
    let ``teaches.html`` = _prefixId.prefix "teaches.html"
    let test = _prefixId.prefix "test"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Twitter ID</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "dfa592b1-730b-41a8-bd1d-00301ca33b8f"^^xsd:string</para>
    ///   <para>label:plural : Twitter IDs</para>
    ///   <a href="http://open.vocab.org/terms/twitter-id">ov:twitter-id</a>
    /// </summary>
    let twitter_id = _prefixId.prefix "twitter-id"
    let ``twitter_id.html`` = _prefixId.prefix "twitter-id.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>label:plural : Used Hosts</para>
    ///   <para>dce:created : 2011-11-15T16:56:41Z^^xsd:dateTime</para>
    ///   <para>rdfs:comment : An Internet host used in the context of an opmv:Process.</para>
    ///   <para>rdfs:label : Used Host</para>
    ///   <a href="http://open.vocab.org/terms/usedHost">ov:usedHost</a>
    /// </summary>
    let usedHost = _prefixId.prefix "usedHost"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Used HTTP Header</para>
    ///   <para>rdfs:comment : The subject (perhaps a foaf:Agent) made HTTP requests with a header described by this http:MessageHeader resource.</para>
    ///   <para>dce:created : 2010-06-29T06:26:42Z^^xsd:dateTime</para>
    ///   <a href="http://open.vocab.org/terms/usedHttpHeader">ov:usedHttpHeader</a>
    /// </summary>
    let usedHttpHeader = _prefixId.prefix "usedHttpHeader"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : uses</para>
    ///   <para>rdfs:comment : links to a thing used by an agent</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "035ceecf-9ac7-489f-b9e9-9a7e3f720c53"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/uses">ov:uses</a>
    /// </summary>
    let uses = _prefixId.prefix "uses"
    let ``uses.html`` = _prefixId.prefix "uses.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : is valid from</para>
    ///   <para>rdfs:comment : To mark the beginning date or event at which the named graph object is true/accurate.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "5df13ac3-9283-48a6-be44-caed596ec11f"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/validFrom">ov:validFrom</a>
    /// </summary>
    let validFrom = _prefixId.prefix "validFrom"
    let ``validFrom.html`` = _prefixId.prefix "validFrom.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : is valid until</para>
    ///   <para>rdfs:comment : To mark the date or event at which the named graph object ceases to be accurate.</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "e8c8fe7b-c19c-4b12-80a6-15431e9d7692"^^xsd:string</para>
    ///   <a href="http://open.vocab.org/terms/validUntil">ov:validUntil</a>
    /// </summary>
    let validUntil = _prefixId.prefix "validUntil"
    let ``validUntil.html`` = _prefixId.prefix "validUntil.html"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Version Number</para>
    ///   <para>rdfs:comment : Property to encode the version of things - simple intent, to record the sequence of items. (The items themselves will have temporal/finer grained detail)</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "86041105-91c5-4924-9886-f8b2cf4b4b90"^^xsd:string</para>
    ///   <para>label:plural : Version Numbers</para>
    ///   <a href="http://open.vocab.org/terms/versionnumber">ov:versionnumber</a>
    /// </summary>
    let versionnumber = _prefixId.prefix "versionnumber"
    let ``versionnumber.html`` = _prefixId.prefix "versionnumber.html"
    /// <summary>
    ///   <para>dce:created : 2011-03-10T15:28:23Z^^xsd:dateTime</para>
    ///   <para>rdfs:comment : The visibility of a resource (e.g. public, internal), expressed as a literal term.</para>
    ///   <para>label:plural : visibilities</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : visibility</para>
    ///   <a href="http://open.vocab.org/terms/visibility">ov:visibility</a>
    /// </summary>
    let visibility = _prefixId.prefix "visibility"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Weight</para>
    ///   <para>rdfs:comment : The weight of a resource</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "a49c5649-4162-4fb0-b241-6bb3593d3d65"^^xsd:string</para>
    ///   <para>label:plural : Weight</para>
    ///   <a href="http://open.vocab.org/terms/weight">ov:weight</a>
    /// </summary>
    let weight = _prefixId.prefix "weight"
    let ``weight.html`` = _prefixId.prefix "weight.html"
    /// <summary>
    ///   <para>rdfs:comment : A wiki page associated with this resource</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>label:plural : Wiki Pages</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : 1ed02cd7-c488-4380-b897-224749fb3b59^^xsd:string</para>
    ///   <para>rdfs:label : Wiki Page</para>
    ///   <a href="http://open.vocab.org/terms/wikiPage">ov:wikiPage</a>
    /// </summary>
    let wikiPage = _prefixId.prefix "wikiPage"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Write Graph</para>
    ///   <para>rdfs:comment : express the ability/right to write to a graph</para>
    ///   <para>http://schemas.talis.com/2005/dir/schema#etag : "6168f084-4cfc-4626-8d9d-0255d0e0bfdd"^^xsd:string</para>
    ///   <para>label:plural : Write Graph</para>
    ///   <a href="http://open.vocab.org/terms/writeGraph">ov:writeGraph</a>
    /// </summary>
    let writeGraph = _prefixId.prefix "writeGraph"
    let ``writeGraph.html`` = _prefixId.prefix "writeGraph.html"

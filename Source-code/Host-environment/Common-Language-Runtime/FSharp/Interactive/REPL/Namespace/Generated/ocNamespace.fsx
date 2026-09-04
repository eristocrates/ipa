#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module oc =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://contextus.net/ontology/ontomedia/core/expression#" "oc"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Abstract Item^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents an abstract entity which may participate in an event within the media^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#Abstract-Item">oc:Abstract-Item</a>
    /// </summary>
    let Abstract_Item = _prefixId.prefix "Abstract-Item"
    /// <summary>
    ///   <para>rdfs:label : Action^^xsd:string</para>
    ///   <para>rdfs:comment : This event class describes an action sequence (ie no plot)^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#Action">oc:Action</a>
    /// </summary>
    let Action = _prefixId.prefix "Action"
    /// <summary>
    ///   <para>rdfs:label : Collection^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a collection of entities^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#Collection">oc:Collection</a>
    /// </summary>
    let Collection = _prefixId.prefix "Collection"
    /// <summary>
    ///   <para>rdfs:label : Context^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the context in which an event or entity exists^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#Context">oc:Context</a>
    /// </summary>
    let Context = _prefixId.prefix "Context"
    /// <summary>
    ///   <para>rdfs:comment : The time/date/temporal reference for the the event^^xsd:string</para>
    ///   <para>rdfs:label : Time/Date^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#DiscreteTime">oc:DiscreteTime</a>
    /// </summary>
    let DiscreteTime = _prefixId.prefix "DiscreteTime"
    /// <summary>
    ///   <para>rdfs:comment : The time/date/temporal reference for the end of the event^^xsd:string</para>
    ///   <para>rdfs:label : Period Initial Limit^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#EndTime">oc:EndTime</a>
    /// </summary>
    let EndTime = _prefixId.prefix "EndTime"
    /// <summary>
    ///   <para>rdfs:comment : A thing^^xsd:string</para>
    ///   <para>rdfs:label : Entity^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#Entity">oc:Entity</a>
    /// </summary>
    let Entity = _prefixId.prefix "Entity"
    /// <summary>
    ///   <para>rdfs:comment : This property defines an event^^xsd:string</para>
    ///   <para>rdfs:label : Event^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#Event">oc:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>rdfs:comment : This class represents a piece of information conveyed through a media^^xsd:string</para>
    ///   <para>rdfs:label : Expression^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#Expression">oc:Expression</a>
    /// </summary>
    let Expression = _prefixId.prefix "Expression"
    /// <summary>
    ///   <para>rdfs:comment : This event class results in an overall increase of the entities related to the primary subject or subjects of the event^^xsd:string</para>
    ///   <para>rdfs:label : Gain^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#Gain">oc:Gain</a>
    /// </summary>
    let Gain = _prefixId.prefix "Gain"
    /// <summary>
    ///   <para>rdfs:comment : This event class denotes the introduction of an entity to the media^^xsd:string</para>
    ///   <para>rdfs:label : Introduction^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#Introduction">oc:Introduction</a>
    /// </summary>
    let Introduction = _prefixId.prefix "Introduction"
    /// <summary>
    ///   <para>rdfs:label : Item^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents an entity which may participate in an event within the media. An Item may be abstract or physical^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#Item">oc:Item</a>
    /// </summary>
    let Item = _prefixId.prefix "Item"
    /// <summary>
    ///   <para>rdfs:comment : This event class results in an overall reduction of the entities related to the primary subject or subjects of the event^^xsd:string</para>
    ///   <para>rdfs:label : Loss^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#Loss">oc:Loss</a>
    /// </summary>
    let Loss = _prefixId.prefix "Loss"
    /// <summary>
    ///   <para>rdfs:comment : Terminus Ante Quem (Limit Before Which): The latest point that the period the event covers could have happened^^xsd:string</para>
    ///   <para>rdfs:label : Media End Period Limit^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#MediaTAQ">oc:MediaTAQ</a>
    /// </summary>
    let MediaTAQ = _prefixId.prefix "MediaTAQ"
    /// <summary>
    ///   <para>rdfs:comment : Terminus Post Quem (Limit After Which): The earliest point that the period the event covers could be said to be happening^^xsd:stringrdfs:comment : This property specifies the earliest point in the media at which the event occurrence could have happened^^xsd:string</para>
    ///   <para>rdfs:label : Media Start Period Limit^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#MediaTPQ">oc:MediaTPQ</a>
    /// </summary>
    let MediaTPQ = _prefixId.prefix "MediaTPQ"
    /// <summary>
    ///   <para>rdfs:label : Occurrence^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a single occurrence of an event, placing it at a position in a timeline^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#Occurrence">oc:Occurrence</a>
    /// </summary>
    let Occurrence = _prefixId.prefix "Occurrence"
    /// <summary>
    ///   <para>rdfs:label : Physical Item^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a physical entity which may participate in an event within the media^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#Physical-Item">oc:Physical-Item</a>
    /// </summary>
    let Physical_Item = _prefixId.prefix "Physical-Item"
    /// <summary>
    ///   <para>rdfs:label : Social^^xsd:string</para>
    ///   <para>rdfs:comment : This event class describes a sequence focusing on social, interpersonal and personal emotional elements^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#Social">oc:Social</a>
    /// </summary>
    let Social = _prefixId.prefix "Social"
    /// <summary>
    ///   <para>rdfs:comment : The time/date/temporal reference for the start of the event^^xsd:string</para>
    ///   <para>rdfs:label : Temporal End^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#StartTime">oc:StartTime</a>
    /// </summary>
    let StartTime = _prefixId.prefix "StartTime"
    /// <summary>
    ///   <para>rdfs:comment : Terminus Ante Quem (Limit Before Which): The latest date that the period the event covers could have happened^^xsd:string</para>
    ///   <para>rdfs:label : Period Terminal Limit^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#TAQ">oc:TAQ</a>
    /// </summary>
    let TAQ = _prefixId.prefix "TAQ"
    /// <summary>
    ///   <para>rdfs:comment : The time/date/temporal reference for the start of the event^^xsd:string</para>
    ///   <para>rdfs:label : Temporal Start^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#TPQ">oc:TPQ</a>
    /// </summary>
    let TPQ = _prefixId.prefix "TPQ"
    /// <summary>
    ///   <para>rdfs:label : Timeline^^xsd:string</para>
    ///   <para>rdfs:comment : This class contains a sequence of occurring events^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#Timeline">oc:Timeline</a>
    /// </summary>
    let Timeline = _prefixId.prefix "Timeline"
    /// <summary>
    ///   <para>rdfs:label : Transformation^^xsd:string</para>
    ///   <para>rdfs:comment : This event class results in no gain or loss of attributes or entities, merely alteration^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#Transformation">oc:Transformation</a>
    /// </summary>
    let Transformation = _prefixId.prefix "Transformation"
    /// <summary>
    ///   <para>rdfs:label : Allows Existence Of^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents that the desired expression may exist within the context^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#allows-existence-of">oc:allows-existence-of</a>
    /// </summary>
    let allows_existence_of = _prefixId.prefix "allows-existence-of"
    /// <summary>
    ///   <para>rdfs:comment : This property indicates the instigating factor of an event, whether it be an item, event, or collection.^^xsd:string</para>
    ///   <para>rdfs:label : Caused By^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#caused-by">oc:caused-by</a>
    /// </summary>
    let caused_by = _prefixId.prefix "caused-by"
    /// <summary>
    ///   <para>rdfs:comment : This property indicates the instigating factor of an event, whether it be an item, event, or collection.^^xsd:string</para>
    ///   <para>rdfs:label : Causes^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#causes">oc:causes</a>
    /// </summary>
    let causes = _prefixId.prefix "causes"
    /// <summary>
    ///   <para>rdfs:comment : This property indicates that one expression is contained by the other^^xsd:string</para>
    ///   <para>rdfs:label : Contained By^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#contained-by">oc:contained-by</a>
    /// </summary>
    let contained_by = _prefixId.prefix "contained-by"
    /// <summary>
    ///   <para>rdfs:comment : This property indicates that one expression contains the other^^xsd:string</para>
    ///   <para>rdfs:label : Contains^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#contains">oc:contains</a>
    /// </summary>
    let contains = _prefixId.prefix "contains"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies the point in the media at which the event occurrence stops happening^^xsd:string</para>
    ///   <para>rdfs:label : End Point in Media^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#end-point">oc:end-point</a>
    /// </summary>
    let end_point = _prefixId.prefix "end-point"
    /// <summary>
    ///   <para>rdfs:label : Exists In^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents that the expression exists within the related context^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#exists-in">oc:exists-in</a>
    /// </summary>
    let exists_in = _prefixId.prefix "exists-in"
    let final_event = _prefixId.prefix "final-event"
    /// <summary>
    ///   <para>rdfs:comment : Follows specifies the occurrence that happens after the referencing occurrence^^xsd:string</para>
    ///   <para>rdfs:label : Follows^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#follows">oc:follows</a>
    /// </summary>
    let follows = _prefixId.prefix "follows"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies the entity which is being transformed^^xsd:string</para>
    ///   <para>rdfs:label : From^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#from">oc:from</a>
    /// </summary>
    let from = _prefixId.prefix "from"
    let has_duration = _prefixId.prefix "has-duration"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies the maximum number of parts that can be contained by the collection^^xsd:string</para>
    ///   <para>rdfs:label : Has Maximum Number Of Parts^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#has-max-number-of-parts">oc:has-max-number-of-parts</a>
    /// </summary>
    let has_max_number_of_parts = _prefixId.prefix "has-max-number-of-parts"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies the minimum number of parts that can be contained by the collection^^xsd:string</para>
    ///   <para>rdfs:label : Has Minimum Number Of Parts^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#has-min-number-of-parts">oc:has-min-number-of-parts</a>
    /// </summary>
    let has_min_number_of_parts = _prefixId.prefix "has-min-number-of-parts"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies the number of parts contained by the collection^^xsd:string</para>
    ///   <para>rdfs:label : Has Number Of Parts^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#has-number-of-parts">oc:has-number-of-parts</a>
    /// </summary>
    let has_number_of_parts = _prefixId.prefix "has-number-of-parts"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies the entity which is the target of the event^^xsd:string</para>
    ///   <para>rdfs:label : Has Object Entity^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#has-object-entity">oc:has-object-entity</a>
    /// </summary>
    let has_object_entity = _prefixId.prefix "has-object-entity"
    /// <summary>
    ///   <para>rdfs:comment : This property defines any occurrences of this event^^xsd:string</para>
    ///   <para>rdfs:label : Has occurrence^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#has-occurrence">oc:has-occurrence</a>
    /// </summary>
    let has_occurrence = _prefixId.prefix "has-occurrence"
    /// <summary>
    ///   <para>rdfs:comment : This property indicates that the expression is a variation on another, very similar but not exactly the same. For example the different interpretations of the same character^^xsd:string</para>
    ///   <para>rdfs:label : Has Shadow^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#has-shadow">oc:has-shadow</a>
    /// </summary>
    let has_shadow = _prefixId.prefix "has-shadow"
    /// <summary>
    ///   <para>rdfs:comment : This property indicates that the expression has developed from another^^xsd:string</para>
    ///   <para>rdfs:label : Has Spin Off^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#has-spin-off">oc:has-spin-off</a>
    /// </summary>
    let has_spin_off = _prefixId.prefix "has-spin-off"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies the entity which carries out the aim of the event^^xsd:string</para>
    ///   <para>rdfs:label : Has Subject Entity^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#has-subject-entity">oc:has-subject-entity</a>
    /// </summary>
    let has_subject_entity = _prefixId.prefix "has-subject-entity"
    /// <summary>
    ///   <para>rdfs:comment : This property indicates that the expression is a variation of another^^xsd:string</para>
    ///   <para>rdfs:label : Has Variant^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#has-variant">oc:has-variant</a>
    /// </summary>
    let has_variant = _prefixId.prefix "has-variant"
    /// <summary>
    ///   <para>rdfs:comment : the first event which begins this sequence^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#initial-event">oc:initial-event</a>
    /// </summary>
    let initial_event = _prefixId.prefix "initial-event"
    /// <summary>
    ///   <para>rdfs:comment : This property indicates that the expression inspired another^^xsd:string</para>
    ///   <para>rdfs:label : Inspired^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#inspired">oc:inspired</a>
    /// </summary>
    let inspired = _prefixId.prefix "inspired"
    /// <summary>
    ///   <para>rdfs:comment : This property indicates that the expression was inspired by another^^xsd:string</para>
    ///   <para>rdfs:label : Inspired By^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#inspired-by">oc:inspired-by</a>
    /// </summary>
    let inspired_by = _prefixId.prefix "inspired-by"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies the events involved in by this entity. Note that this includes the subject and object.^^xsd:string</para>
    ///   <para>rdfs:label : Involves^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#involved-in">oc:involved-in</a>
    /// </summary>
    let involved_in = _prefixId.prefix "involved-in"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies the entities involved in this event. Note that this includes the subject and object.^^xsd:string</para>
    ///   <para>rdfs:label : Involves^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#involves">oc:involves</a>
    /// </summary>
    let involves = _prefixId.prefix "involves"
    /// <summary>
    ///   <para>rdfs:comment : This property indicates that the expression is exactly the same as another^^xsd:string</para>
    ///   <para>rdfs:label : Is^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#is">oc:is</a>
    /// </summary>
    let is = _prefixId.prefix "is"
    /// <summary>
    ///   <para>rdfs:comment : This property indicates that there is some type of link between the named Expressions^^xsd:string</para>
    ///   <para>rdfs:label : Is Linked To^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#is-linked-to">oc:is-linked-to</a>
    /// </summary>
    let is_linked_to = _prefixId.prefix "is-linked-to"
    /// <summary>
    ///   <para>rdfs:comment : This property indicates that the expression is entirely different to another^^xsd:string</para>
    ///   <para>rdfs:label : Is Not^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#is-not">oc:is-not</a>
    /// </summary>
    let is_not = _prefixId.prefix "is-not"
    /// <summary>
    ///   <para>rdfs:comment : This property indicates that there is some no link between the named Expressions^^xsd:string</para>
    ///   <para>rdfs:label : Is Not Linked To^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#is-not-linked-to">oc:is-not-linked-to</a>
    /// </summary>
    let is_not_linked_to = _prefixId.prefix "is-not-linked-to"
    /// <summary>
    ///   <para>rdfs:comment : This property indicates that the expression is potentially another. For example, it may be a possible future version^^xsd:string</para>
    ///   <para>rdfs:label : Is Potentially^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#is-potentially">oc:is-potentially</a>
    /// </summary>
    let is_potentially = _prefixId.prefix "is-potentially"
    /// <summary>
    ///   <para>rdfs:comment : This property indicates that the expression is a variation on another, very similar but not exactly the same. For example the different interpretations of the same character^^xsd:string</para>
    ///   <para>rdfs:label : Is Shadow Of^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#is-shadow-of">oc:is-shadow-of</a>
    /// </summary>
    let is_shadow_of = _prefixId.prefix "is-shadow-of"
    /// <summary>
    ///   <para>rdfs:comment : This property indicates that the expression has developed from another^^xsd:string</para>
    ///   <para>rdfs:label : Is Spin Off Of^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#is-spin-off-of">oc:is-spin-off-of</a>
    /// </summary>
    let is_spin_off_of = _prefixId.prefix "is-spin-off-of"
    /// <summary>
    ///   <para>rdfs:comment : This property defines any the event that the occurrence relates to^^xsd:string</para>
    ///   <para>rdfs:label : Occurrence Of^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#occurrence-of">oc:occurrence-of</a>
    /// </summary>
    let occurrence_of = _prefixId.prefix "occurrence-of"
    let occurs = _prefixId.prefix "occurs"
    /// <summary>
    ///   <para>rdfs:comment : This property contains the state which should occur as a consequence of this event^^xsd:string</para>
    ///   <para>rdfs:label : Postcondition^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#postcondition">oc:postcondition</a>
    /// </summary>
    let postcondition = _prefixId.prefix "postcondition"
    /// <summary>
    ///   <para>rdfs:comment : This property defines the occurrence which immediately follows this occurrence^^xsd:string</para>
    ///   <para>rdfs:label : Precedes^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#precedes">oc:precedes</a>
    /// </summary>
    let precedes = _prefixId.prefix "precedes"
    /// <summary>
    ///   <para>rdfs:comment : This property is a state that must exist before the event can occur^^xsd:string</para>
    ///   <para>rdfs:label : Precondition^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#precondition">oc:precondition</a>
    /// </summary>
    let precondition = _prefixId.prefix "precondition"
    /// <summary>
    ///   <para>rdfs:comment : This property indicates that the expression is refered to by another expression.^^xsd:string</para>
    ///   <para>rdfs:label : Refers To^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#referenced-by">oc:referenced-by</a>
    /// </summary>
    let referenced_by = _prefixId.prefix "referenced-by"
    /// <summary>
    ///   <para>rdfs:comment : This property indicates that the expression refers to another expression. This may be an event referring to a location, or a character refering to an event, etc.^^xsd:string</para>
    ///   <para>rdfs:label : Refers To^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#refers-to">oc:refers-to</a>
    /// </summary>
    let refers_to = _prefixId.prefix "refers-to"
    let start_point = _prefixId.prefix "start-point"
    let summary = _prefixId.prefix "summary"
    /// <summary>
    ///   <para>rdfs:comment : Reference to the Timeline that the Occurrence exists on^^xsd:string</para>
    ///   <para>rdfs:label : Timeline Reference^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#timeline-ref">oc:timeline-ref</a>
    /// </summary>
    let timeline_ref = _prefixId.prefix "timeline-ref"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies the resultant entity^^xsd:string</para>
    ///   <para>rdfs:label : To^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/expression#to">oc:to</a>
    /// </summary>
    let to_ = _prefixId.prefix "to"

namespace http.contextus.net.ontology.ontomedia.core.expression.hash

open DoxAletheia

module oc =
    let _namespace_name = "http://contextus.net/ontology/ontomedia/core/expression#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// This class represents an abstract entity which may participate in an event within the media
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#Abstract-Item"></see></summary>
    let ``Abstract-Item`` = _prefix "Abstract-Item"
    /// <summary>
    /// This class represents an entity which may participate in an event within the media. An Item may be abstract or physical
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#Item"></see></summary>
    let Item = _prefix "Item"
    /// <summary>
    /// This event class describes an action sequence (ie no plot)
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#Action"></see></summary>
    let Action = _prefix "Action"
    /// <summary>
    /// This property defines an event
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#Event"></see></summary>
    let Event = _prefix "Event"
    /// <summary>
    /// This class represents a collection of entities
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#Collection"></see></summary>
    let Collection = _prefix "Collection"
    /// <summary>
    /// This class represents the context in which an event or entity exists
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#Context"></see></summary>
    let Context = _prefix "Context"
    /// <summary>
    /// The time/date/temporal reference for the the event
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#DiscreteTime"></see></summary>
    let DiscreteTime = _prefix "DiscreteTime"
    /// <summary>
    /// This class represents a single occurrence of an event, placing it at a position in a timeline
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#Occurrence"></see></summary>
    let Occurrence = _prefix "Occurrence"
    /// <summary>
    /// The time/date/temporal reference for the end of the event
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#EndTime"></see></summary>
    let EndTime = _prefix "EndTime"
    /// <summary>
    /// A thing
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#Entity"></see></summary>
    let Entity = _prefix "Entity"
    /// <summary>
    /// This class represents a piece of information conveyed through a media
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#Expression"></see></summary>
    let Expression = _prefix "Expression"
    /// <summary>
    /// This event class results in an overall increase of the entities related to the primary subject or subjects of the event
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#Gain"></see></summary>
    let Gain = _prefix "Gain"
    /// <summary>
    /// This event class denotes the introduction of an entity to the media
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#Introduction"></see></summary>
    let Introduction = _prefix "Introduction"
    /// <summary>
    /// This event class results in an overall reduction of the entities related to the primary subject or subjects of the event
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#Loss"></see></summary>
    let Loss = _prefix "Loss"
    /// <summary>
    /// Terminus Ante Quem (Limit Before Which): The latest point that the period the event covers could have happened
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#MediaTAQ"></see></summary>
    let MediaTAQ = _prefix "MediaTAQ"
    /// <summary>
    /// Terminus Post Quem (Limit After Which): The earliest point that the period the event covers could be said to be happening
    /// This property specifies the earliest point in the media at which the event occurrence could have happened
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#MediaTPQ"></see></summary>
    let MediaTPQ = _prefix "MediaTPQ"
    /// <summary>
    /// This class represents a physical entity which may participate in an event within the media
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#Physical-Item"></see></summary>
    let ``Physical-Item`` = _prefix "Physical-Item"
    /// <summary>
    /// This event class describes a sequence focusing on social, interpersonal and personal emotional elements
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#Social"></see></summary>
    let Social = _prefix "Social"
    /// <summary>
    /// The time/date/temporal reference for the start of the event
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#StartTime"></see></summary>
    let StartTime = _prefix "StartTime"
    /// <summary>
    /// Terminus Ante Quem (Limit Before Which): The latest date that the period the event covers could have happened
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#TAQ"></see></summary>
    let TAQ = _prefix "TAQ"
    /// <summary>
    /// The time/date/temporal reference for the start of the event
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#TPQ"></see></summary>
    let TPQ = _prefix "TPQ"
    /// <summary>
    /// This class contains a sequence of occurring events
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#Timeline"></see></summary>
    let Timeline = _prefix "Timeline"
    /// <summary>
    /// This event class results in no gain or loss of attributes or entities, merely alteration
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#Transformation"></see></summary>
    let Transformation = _prefix "Transformation"
    /// <summary>
    /// This class represents that the desired expression may exist within the context
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#allows-existence-of"></see></summary>
    let ``allows-existence-of`` = _prefix "allows-existence-of"
    /// <summary>
    /// This class represents that the expression exists within the related context
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#exists-in"></see></summary>
    let ``exists-in`` = _prefix "exists-in"
    /// <summary>
    /// This property indicates the instigating factor of an event, whether it be an item, event, or collection.
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#caused-by"></see></summary>
    let ``caused-by`` = _prefix "caused-by"
    /// <summary>
    /// This property indicates the instigating factor of an event, whether it be an item, event, or collection.
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#causes"></see></summary>
    let causes = _prefix "causes"
    /// <summary>
    /// This property indicates that one expression is contained by the other
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#contained-by"></see></summary>
    let ``contained-by`` = _prefix "contained-by"
    /// <summary>
    /// This property indicates that there is some type of link between the named Expressions
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#is-linked-to"></see></summary>
    let ``is-linked-to`` = _prefix "is-linked-to"
    /// <summary>
    /// This property indicates that one expression contains the other
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#contains"></see></summary>
    let contains = _prefix "contains"
    /// <summary>
    /// This property specifies the point in the media at which the event occurrence stops happening
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#end-point"></see></summary>
    let ``end-point`` = _prefix "end-point"
    /// <summary>
    ///   <see href="http://contextus.net/ontology/ontomedia/core/expression#final-event"></see>
    /// </summary>
    let ``final-event`` = _prefix "final-event"
    /// <summary>
    /// Follows specifies the occurrence that happens after the referencing occurrence
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#follows"></see></summary>
    let follows = _prefix "follows"
    /// <summary>
    /// This property defines the occurrence which immediately follows this occurrence
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#precedes"></see></summary>
    let precedes = _prefix "precedes"
    /// <summary>
    /// This property specifies the entity which is being transformed
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#from"></see></summary>
    let from = _prefix "from"
    /// <summary>
    /// This property specifies the duration of the occurrence
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#has-duration"></see></summary>
    let ``has-duration`` = _prefix "has-duration"
    /// <summary>
    /// This property specifies the maximum number of parts that can be contained by the collection
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#has-max-number-of-parts"></see></summary>
    let ``has-max-number-of-parts`` = _prefix "has-max-number-of-parts"
    /// <summary>
    /// This property specifies the minimum number of parts that can be contained by the collection
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#has-min-number-of-parts"></see></summary>
    let ``has-min-number-of-parts`` = _prefix "has-min-number-of-parts"
    /// <summary>
    /// This property specifies the number of parts contained by the collection
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#has-number-of-parts"></see></summary>
    let ``has-number-of-parts`` = _prefix "has-number-of-parts"
    /// <summary>
    /// This property specifies the entity which is the target of the event
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#has-object-entity"></see></summary>
    let ``has-object-entity`` = _prefix "has-object-entity"
    /// <summary>
    /// This property defines any occurrences of this event
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#has-occurrence"></see></summary>
    let ``has-occurrence`` = _prefix "has-occurrence"
    /// <summary>
    /// This property defines any the event that the occurrence relates to
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#occurrence-of"></see></summary>
    let ``occurrence-of`` = _prefix "occurrence-of"
    /// <summary>
    /// This property indicates that the expression is a variation on another, very similar but not exactly the same. For example the different interpretations of the same character
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#has-shadow"></see></summary>
    let ``has-shadow`` = _prefix "has-shadow"
    /// <summary>
    /// This property indicates that the expression is a variation of another
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#has-variant"></see></summary>
    let ``has-variant`` = _prefix "has-variant"
    /// <summary>
    /// This property indicates that the expression is a variation on another, very similar but not exactly the same. For example the different interpretations of the same character
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#is-shadow-of"></see></summary>
    let ``is-shadow-of`` = _prefix "is-shadow-of"
    /// <summary>
    /// This property indicates that the expression has developed from another
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#has-spin-off"></see></summary>
    let ``has-spin-off`` = _prefix "has-spin-off"
    /// <summary>
    /// This property indicates that the expression has developed from another
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#is-spin-off-of"></see></summary>
    let ``is-spin-off-of`` = _prefix "is-spin-off-of"
    /// <summary>
    /// This property specifies the entity which carries out the aim of the event
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#has-subject-entity"></see></summary>
    let ``has-subject-entity`` = _prefix "has-subject-entity"
    /// <summary>
    /// the first event which begins this sequence
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#initial-event"></see></summary>
    let ``initial-event`` = _prefix "initial-event"
    /// <summary>
    /// This property indicates that the expression inspired another
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#inspired"></see></summary>
    let inspired = _prefix "inspired"
    /// <summary>
    /// This property indicates that the expression was inspired by another
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#inspired-by"></see></summary>
    let ``inspired-by`` = _prefix "inspired-by"
    /// <summary>
    /// This property specifies the events involved in by this entity. Note that this includes the subject and object.
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#involved-in"></see></summary>
    let ``involved-in`` = _prefix "involved-in"
    /// <summary>
    /// This property specifies the entities involved in this event. Note that this includes the subject and object.
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#involves"></see></summary>
    let involves = _prefix "involves"
    /// <summary>
    /// This property indicates that the expression is exactly the same as another
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#is"></see></summary>
    let is = _prefix "is"
    /// <summary>
    /// This property indicates that there is some no link between the named Expressions
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#is-not-linked-to"></see></summary>
    let ``is-not-linked-to`` = _prefix "is-not-linked-to"
    /// <summary>
    /// This property indicates that the expression is entirely different to another
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#is-not"></see></summary>
    let ``is-not`` = _prefix "is-not"
    /// <summary>
    /// This property indicates that the expression is potentially another. For example, it may be a possible future version
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#is-potentially"></see></summary>
    let ``is-potentially`` = _prefix "is-potentially"
    /// <summary>
    /// This property specifies the region of media in when an event occurrence happens
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#occurs"></see></summary>
    let occurs = _prefix "occurs"
    /// <summary>
    /// This property contains the state which should occur as a consequence of this event
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#postcondition"></see></summary>
    let postcondition = _prefix "postcondition"
    /// <summary>
    /// This property is a state that must exist before the event can occur
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#precondition"></see></summary>
    let precondition = _prefix "precondition"
    /// <summary>
    /// This property indicates that the expression is refered to by another expression.
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#referenced-by"></see></summary>
    let ``referenced-by`` = _prefix "referenced-by"
    /// <summary>
    /// This property indicates that the expression refers to another expression. This may be an event referring to a location, or a character refering to an event, etc.
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#refers-to"></see></summary>
    let ``refers-to`` = _prefix "refers-to"
    /// <summary>
    /// This property specifies the point in the media at which the event occurrence starts happening
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#start-point"></see></summary>
    let ``start-point`` = _prefix "start-point"
    /// <summary>
    /// This property is a plain-text summery of what occurs in the event
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#summary"></see></summary>
    let summary = _prefix "summary"
    /// <summary>
    /// Reference to the Timeline that the Occurrence exists on
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#timeline-ref"></see></summary>
    let ``timeline-ref`` = _prefix "timeline-ref"
    /// <summary>
    /// This property specifies the resultant entity
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#to"></see></summary>
    let to_ = _prefix "to"

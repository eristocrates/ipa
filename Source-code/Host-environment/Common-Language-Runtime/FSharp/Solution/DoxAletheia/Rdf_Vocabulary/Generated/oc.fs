namespace http.contextus.net.ontology.ontomedia.core.expression.hash

open DoxAletheia.Rdf_Vocabulary

module oc =
    let _namespace_name = "http://contextus.net/ontology/ontomedia/core/expression#"

    /// <summary>
    /// This class represents an abstract entity which may participate in an event within the media
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#Abstract-Item"></see></summary>
    let ``Abstract-Item`` =
        Namespaced_IRI.parse _namespace_name "Abstract-Item" |> NamespacedName

    /// <summary>
    /// This class represents an entity which may participate in an event within the media. An Item may be abstract or physical
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#Item"></see></summary>
    let Item = Namespaced_IRI.parse _namespace_name "Item" |> NamespacedName
    /// <summary>
    /// This event class describes an action sequence (ie no plot)
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#Action"></see></summary>
    let Action = Namespaced_IRI.parse _namespace_name "Action" |> NamespacedName
    /// <summary>
    /// This property defines an event
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#Event"></see></summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName
    /// <summary>
    /// This class represents a collection of entities
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#Collection"></see></summary>
    let Collection = Namespaced_IRI.parse _namespace_name "Collection" |> NamespacedName
    /// <summary>
    /// This class represents the context in which an event or entity exists
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#Context"></see></summary>
    let Context = Namespaced_IRI.parse _namespace_name "Context" |> NamespacedName

    /// <summary>
    /// The time/date/temporal reference for the the event
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#DiscreteTime"></see></summary>
    let DiscreteTime =
        Namespaced_IRI.parse _namespace_name "DiscreteTime" |> NamespacedName

    /// <summary>
    /// This class represents a single occurrence of an event, placing it at a position in a timeline
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#Occurrence"></see></summary>
    let Occurrence = Namespaced_IRI.parse _namespace_name "Occurrence" |> NamespacedName
    /// <summary>
    /// The time/date/temporal reference for the end of the event
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#EndTime"></see></summary>
    let EndTime = Namespaced_IRI.parse _namespace_name "EndTime" |> NamespacedName
    /// <summary>
    /// A thing
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#Entity"></see></summary>
    let Entity = Namespaced_IRI.parse _namespace_name "Entity" |> NamespacedName
    /// <summary>
    /// This class represents a piece of information conveyed through a media
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#Expression"></see></summary>
    let Expression = Namespaced_IRI.parse _namespace_name "Expression" |> NamespacedName
    /// <summary>
    /// This event class results in an overall increase of the entities related to the primary subject or subjects of the event
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#Gain"></see></summary>
    let Gain = Namespaced_IRI.parse _namespace_name "Gain" |> NamespacedName

    /// <summary>
    /// This event class denotes the introduction of an entity to the media
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#Introduction"></see></summary>
    let Introduction =
        Namespaced_IRI.parse _namespace_name "Introduction" |> NamespacedName

    /// <summary>
    /// This event class results in an overall reduction of the entities related to the primary subject or subjects of the event
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#Loss"></see></summary>
    let Loss = Namespaced_IRI.parse _namespace_name "Loss" |> NamespacedName
    /// <summary>
    /// Terminus Ante Quem (Limit Before Which): The latest point that the period the event covers could have happened
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#MediaTAQ"></see></summary>
    let MediaTAQ = Namespaced_IRI.parse _namespace_name "MediaTAQ" |> NamespacedName
    /// <summary>
    /// Terminus Post Quem (Limit After Which): The earliest point that the period the event covers could be said to be happening
    /// This property specifies the earliest point in the media at which the event occurrence could have happened
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#MediaTPQ"></see></summary>
    let MediaTPQ = Namespaced_IRI.parse _namespace_name "MediaTPQ" |> NamespacedName

    /// <summary>
    /// This class represents a physical entity which may participate in an event within the media
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#Physical-Item"></see></summary>
    let ``Physical-Item`` =
        Namespaced_IRI.parse _namespace_name "Physical-Item" |> NamespacedName

    /// <summary>
    /// This event class describes a sequence focusing on social, interpersonal and personal emotional elements
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#Social"></see></summary>
    let Social = Namespaced_IRI.parse _namespace_name "Social" |> NamespacedName
    /// <summary>
    /// The time/date/temporal reference for the start of the event
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#StartTime"></see></summary>
    let StartTime = Namespaced_IRI.parse _namespace_name "StartTime" |> NamespacedName
    /// <summary>
    /// Terminus Ante Quem (Limit Before Which): The latest date that the period the event covers could have happened
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#TAQ"></see></summary>
    let TAQ = Namespaced_IRI.parse _namespace_name "TAQ" |> NamespacedName
    /// <summary>
    /// The time/date/temporal reference for the start of the event
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#TPQ"></see></summary>
    let TPQ = Namespaced_IRI.parse _namespace_name "TPQ" |> NamespacedName
    /// <summary>
    /// This class contains a sequence of occurring events
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#Timeline"></see></summary>
    let Timeline = Namespaced_IRI.parse _namespace_name "Timeline" |> NamespacedName

    /// <summary>
    /// This event class results in no gain or loss of attributes or entities, merely alteration
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#Transformation"></see></summary>
    let Transformation =
        Namespaced_IRI.parse _namespace_name "Transformation" |> NamespacedName

    /// <summary>
    /// This class represents that the desired expression may exist within the context
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#allows-existence-of"></see></summary>
    let ``allows-existence-of`` =
        Namespaced_IRI.parse _namespace_name "allows-existence-of" |> NamespacedName

    /// <summary>
    /// This class represents that the expression exists within the related context
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#exists-in"></see></summary>
    let ``exists-in`` =
        Namespaced_IRI.parse _namespace_name "exists-in" |> NamespacedName

    /// <summary>
    /// This property indicates the instigating factor of an event, whether it be an item, event, or collection.
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#caused-by"></see></summary>
    let ``caused-by`` =
        Namespaced_IRI.parse _namespace_name "caused-by" |> NamespacedName

    /// <summary>
    /// This property indicates the instigating factor of an event, whether it be an item, event, or collection.
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#causes"></see></summary>
    let causes = Namespaced_IRI.parse _namespace_name "causes" |> NamespacedName

    /// <summary>
    /// This property indicates that one expression is contained by the other
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#contained-by"></see></summary>
    let ``contained-by`` =
        Namespaced_IRI.parse _namespace_name "contained-by" |> NamespacedName

    /// <summary>
    /// This property indicates that there is some type of link between the named Expressions
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#is-linked-to"></see></summary>
    let ``is-linked-to`` =
        Namespaced_IRI.parse _namespace_name "is-linked-to" |> NamespacedName

    /// <summary>
    /// This property indicates that one expression contains the other
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#contains"></see></summary>
    let contains = Namespaced_IRI.parse _namespace_name "contains" |> NamespacedName

    /// <summary>
    /// This property specifies the point in the media at which the event occurrence stops happening
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#end-point"></see></summary>
    let ``end-point`` =
        Namespaced_IRI.parse _namespace_name "end-point" |> NamespacedName

    /// <summary>
    ///   <see href="http://contextus.net/ontology/ontomedia/core/expression#final-event"></see>
    /// </summary>
    let ``final-event`` =
        Namespaced_IRI.parse _namespace_name "final-event" |> NamespacedName

    /// <summary>
    /// Follows specifies the occurrence that happens after the referencing occurrence
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#follows"></see></summary>
    let follows = Namespaced_IRI.parse _namespace_name "follows" |> NamespacedName
    /// <summary>
    /// This property defines the occurrence which immediately follows this occurrence
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#precedes"></see></summary>
    let precedes = Namespaced_IRI.parse _namespace_name "precedes" |> NamespacedName
    /// <summary>
    /// This property specifies the entity which is being transformed
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#from"></see></summary>
    let from = Namespaced_IRI.parse _namespace_name "from" |> NamespacedName

    /// <summary>
    /// This property specifies the duration of the occurrence
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#has-duration"></see></summary>
    let ``has-duration`` =
        Namespaced_IRI.parse _namespace_name "has-duration" |> NamespacedName

    /// <summary>
    /// This property specifies the maximum number of parts that can be contained by the collection
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#has-max-number-of-parts"></see></summary>
    let ``has-max-number-of-parts`` =
        Namespaced_IRI.parse _namespace_name "has-max-number-of-parts" |> NamespacedName

    /// <summary>
    /// This property specifies the minimum number of parts that can be contained by the collection
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#has-min-number-of-parts"></see></summary>
    let ``has-min-number-of-parts`` =
        Namespaced_IRI.parse _namespace_name "has-min-number-of-parts" |> NamespacedName

    /// <summary>
    /// This property specifies the number of parts contained by the collection
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#has-number-of-parts"></see></summary>
    let ``has-number-of-parts`` =
        Namespaced_IRI.parse _namespace_name "has-number-of-parts" |> NamespacedName

    /// <summary>
    /// This property specifies the entity which is the target of the event
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#has-object-entity"></see></summary>
    let ``has-object-entity`` =
        Namespaced_IRI.parse _namespace_name "has-object-entity" |> NamespacedName

    /// <summary>
    /// This property defines any occurrences of this event
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#has-occurrence"></see></summary>
    let ``has-occurrence`` =
        Namespaced_IRI.parse _namespace_name "has-occurrence" |> NamespacedName

    /// <summary>
    /// This property defines any the event that the occurrence relates to
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#occurrence-of"></see></summary>
    let ``occurrence-of`` =
        Namespaced_IRI.parse _namespace_name "occurrence-of" |> NamespacedName

    /// <summary>
    /// This property indicates that the expression is a variation on another, very similar but not exactly the same. For example the different interpretations of the same character
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#has-shadow"></see></summary>
    let ``has-shadow`` =
        Namespaced_IRI.parse _namespace_name "has-shadow" |> NamespacedName

    /// <summary>
    /// This property indicates that the expression is a variation of another
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#has-variant"></see></summary>
    let ``has-variant`` =
        Namespaced_IRI.parse _namespace_name "has-variant" |> NamespacedName

    /// <summary>
    /// This property indicates that the expression is a variation on another, very similar but not exactly the same. For example the different interpretations of the same character
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#is-shadow-of"></see></summary>
    let ``is-shadow-of`` =
        Namespaced_IRI.parse _namespace_name "is-shadow-of" |> NamespacedName

    /// <summary>
    /// This property indicates that the expression has developed from another
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#has-spin-off"></see></summary>
    let ``has-spin-off`` =
        Namespaced_IRI.parse _namespace_name "has-spin-off" |> NamespacedName

    /// <summary>
    /// This property indicates that the expression has developed from another
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#is-spin-off-of"></see></summary>
    let ``is-spin-off-of`` =
        Namespaced_IRI.parse _namespace_name "is-spin-off-of" |> NamespacedName

    /// <summary>
    /// This property specifies the entity which carries out the aim of the event
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#has-subject-entity"></see></summary>
    let ``has-subject-entity`` =
        Namespaced_IRI.parse _namespace_name "has-subject-entity" |> NamespacedName

    /// <summary>
    /// the first event which begins this sequence
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#initial-event"></see></summary>
    let ``initial-event`` =
        Namespaced_IRI.parse _namespace_name "initial-event" |> NamespacedName

    /// <summary>
    /// This property indicates that the expression inspired another
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#inspired"></see></summary>
    let inspired = Namespaced_IRI.parse _namespace_name "inspired" |> NamespacedName

    /// <summary>
    /// This property indicates that the expression was inspired by another
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#inspired-by"></see></summary>
    let ``inspired-by`` =
        Namespaced_IRI.parse _namespace_name "inspired-by" |> NamespacedName

    /// <summary>
    /// This property specifies the events involved in by this entity. Note that this includes the subject and object.
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#involved-in"></see></summary>
    let ``involved-in`` =
        Namespaced_IRI.parse _namespace_name "involved-in" |> NamespacedName

    /// <summary>
    /// This property specifies the entities involved in this event. Note that this includes the subject and object.
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#involves"></see></summary>
    let involves = Namespaced_IRI.parse _namespace_name "involves" |> NamespacedName
    /// <summary>
    /// This property indicates that the expression is exactly the same as another
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#is"></see></summary>
    let is = Namespaced_IRI.parse _namespace_name "is" |> NamespacedName

    /// <summary>
    /// This property indicates that there is some no link between the named Expressions
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#is-not-linked-to"></see></summary>
    let ``is-not-linked-to`` =
        Namespaced_IRI.parse _namespace_name "is-not-linked-to" |> NamespacedName

    /// <summary>
    /// This property indicates that the expression is entirely different to another
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#is-not"></see></summary>
    let ``is-not`` = Namespaced_IRI.parse _namespace_name "is-not" |> NamespacedName

    /// <summary>
    /// This property indicates that the expression is potentially another. For example, it may be a possible future version
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#is-potentially"></see></summary>
    let ``is-potentially`` =
        Namespaced_IRI.parse _namespace_name "is-potentially" |> NamespacedName

    /// <summary>
    /// This property specifies the region of media in when an event occurrence happens
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#occurs"></see></summary>
    let occurs = Namespaced_IRI.parse _namespace_name "occurs" |> NamespacedName

    /// <summary>
    /// This property contains the state which should occur as a consequence of this event
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#postcondition"></see></summary>
    let postcondition =
        Namespaced_IRI.parse _namespace_name "postcondition" |> NamespacedName

    /// <summary>
    /// This property is a state that must exist before the event can occur
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#precondition"></see></summary>
    let precondition =
        Namespaced_IRI.parse _namespace_name "precondition" |> NamespacedName

    /// <summary>
    /// This property indicates that the expression is refered to by another expression.
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#referenced-by"></see></summary>
    let ``referenced-by`` =
        Namespaced_IRI.parse _namespace_name "referenced-by" |> NamespacedName

    /// <summary>
    /// This property indicates that the expression refers to another expression. This may be an event referring to a location, or a character refering to an event, etc.
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#refers-to"></see></summary>
    let ``refers-to`` =
        Namespaced_IRI.parse _namespace_name "refers-to" |> NamespacedName

    /// <summary>
    /// This property specifies the point in the media at which the event occurrence starts happening
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#start-point"></see></summary>
    let ``start-point`` =
        Namespaced_IRI.parse _namespace_name "start-point" |> NamespacedName

    /// <summary>
    /// This property is a plain-text summery of what occurs in the event
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#summary"></see></summary>
    let summary = Namespaced_IRI.parse _namespace_name "summary" |> NamespacedName

    /// <summary>
    /// Reference to the Timeline that the Occurrence exists on
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#timeline-ref"></see></summary>
    let ``timeline-ref`` =
        Namespaced_IRI.parse _namespace_name "timeline-ref" |> NamespacedName

    /// <summary>
    /// This property specifies the resultant entity
    /// <see href="http://contextus.net/ontology/ontomedia/core/expression#to"></see></summary>
    let to_ = Namespaced_IRI.parse _namespace_name "to" |> NamespacedName

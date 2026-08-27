namespace http.contextus.net.ontology.ontomedia.core.expression.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module oc =
    let _namespace_iri = Namespace_Iri oc |> NamespaceIRI
    /// <summary>
    ///   <para>oc:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"OntoMedia Core"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#">http://contextus.net/ontology/ontomedia/core/expression#</seealso>
    let _prefix_iri = Prefixed_Name(oc, "") |> PrefixedName
    /// <summary>
    ///   <para>oc:Abstract-Item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents an abstract entity which may participate in an event within the media"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Abstract Item"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#Abstract-Item">http://contextus.net/ontology/ontomedia/core/expression#Abstract-Item</seealso>
    let Abstract_Item = Prefixed_Name(oc, "Abstract-Item") |> PrefixedName
    /// <summary>
    ///   <para>oc:Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This event class describes an action sequence (ie no plot)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Action"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#Action">http://contextus.net/ontology/ontomedia/core/expression#Action</seealso>
    let Action = Prefixed_Name(oc, "Action") |> PrefixedName
    /// <summary>
    ///   <para>oc:Collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a collection of entities"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Collection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#Collection">http://contextus.net/ontology/ontomedia/core/expression#Collection</seealso>
    let Collection = Prefixed_Name(oc, "Collection") |> PrefixedName
    /// <summary>
    ///   <para>oc:Context</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the context in which an event or entity exists"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Context"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#Context">http://contextus.net/ontology/ontomedia/core/expression#Context</seealso>
    let Context = Prefixed_Name(oc, "Context") |> PrefixedName
    /// <summary>
    ///   <para>oc:DiscreteTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The time/date/temporal reference for the the event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Time/Date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#DiscreteTime">http://contextus.net/ontology/ontomedia/core/expression#DiscreteTime</seealso>
    let DiscreteTime = Prefixed_Name(oc, "DiscreteTime") |> PrefixedName
    /// <summary>
    ///   <para>oc:EndTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The time/date/temporal reference for the end of the event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Period Initial Limit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#EndTime">http://contextus.net/ontology/ontomedia/core/expression#EndTime</seealso>
    let EndTime = Prefixed_Name(oc, "EndTime") |> PrefixedName
    /// <summary>
    ///   <para>oc:Entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A thing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#Entity">http://contextus.net/ontology/ontomedia/core/expression#Entity</seealso>
    let Entity = Prefixed_Name(oc, "Entity") |> PrefixedName
    /// <summary>
    ///   <para>oc:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This property defines an event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#Event">http://contextus.net/ontology/ontomedia/core/expression#Event</seealso>
    let Event = Prefixed_Name(oc, "Event") |> PrefixedName
    /// <summary>
    ///   <para>oc:Expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a piece of information conveyed through a media"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Expression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#Expression">http://contextus.net/ontology/ontomedia/core/expression#Expression</seealso>
    let Expression = Prefixed_Name(oc, "Expression") |> PrefixedName
    /// <summary>
    ///   <para>oc:Gain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This event class results in an overall increase of the entities related to the primary subject or subjects of the event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Gain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#Gain">http://contextus.net/ontology/ontomedia/core/expression#Gain</seealso>
    let Gain = Prefixed_Name(oc, "Gain") |> PrefixedName
    /// <summary>
    ///   <para>oc:Introduction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This event class denotes the introduction of an entity to the media"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Introduction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#Introduction">http://contextus.net/ontology/ontomedia/core/expression#Introduction</seealso>
    let Introduction = Prefixed_Name(oc, "Introduction") |> PrefixedName
    /// <summary>
    ///   <para>oc:Item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents an entity which may participate in an event within the media. An Item may be abstract or physical"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Item"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#Item">http://contextus.net/ontology/ontomedia/core/expression#Item</seealso>
    let Item = Prefixed_Name(oc, "Item") |> PrefixedName
    /// <summary>
    ///   <para>oc:Loss</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This event class results in an overall reduction of the entities related to the primary subject or subjects of the event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Loss"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#Loss">http://contextus.net/ontology/ontomedia/core/expression#Loss</seealso>
    let Loss = Prefixed_Name(oc, "Loss") |> PrefixedName
    /// <summary>
    ///   <para>oc:MediaTAQ</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Terminus Ante Quem (Limit Before Which): The latest point that the period the event covers could have happened"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Media End Period Limit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#MediaTAQ">http://contextus.net/ontology/ontomedia/core/expression#MediaTAQ</seealso>
    let MediaTAQ = Prefixed_Name(oc, "MediaTAQ") |> PrefixedName
    /// <summary>
    ///   <para>oc:MediaTPQ</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the earliest point in the media at which the event occurrence could have happened"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Terminus Post Quem (Limit After Which): The earliest point that the period the event covers could be said to be happening"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Media Start Period Limit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#MediaTPQ">http://contextus.net/ontology/ontomedia/core/expression#MediaTPQ</seealso>
    let MediaTPQ = Prefixed_Name(oc, "MediaTPQ") |> PrefixedName
    /// <summary>
    ///   <para>oc:Occurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a single occurrence of an event, placing it at a position in a timeline"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Occurrence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#Occurrence">http://contextus.net/ontology/ontomedia/core/expression#Occurrence</seealso>
    let Occurrence = Prefixed_Name(oc, "Occurrence") |> PrefixedName
    /// <summary>
    ///   <para>oc:Physical-Item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a physical entity which may participate in an event within the media"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Physical Item"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#Physical-Item">http://contextus.net/ontology/ontomedia/core/expression#Physical-Item</seealso>
    let Physical_Item = Prefixed_Name(oc, "Physical-Item") |> PrefixedName
    /// <summary>
    ///   <para>oc:Social</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This event class describes a sequence focusing on social, interpersonal and personal emotional elements"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Social"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#Social">http://contextus.net/ontology/ontomedia/core/expression#Social</seealso>
    let Social = Prefixed_Name(oc, "Social") |> PrefixedName
    /// <summary>
    ///   <para>oc:StartTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The time/date/temporal reference for the start of the event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Temporal End"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#StartTime">http://contextus.net/ontology/ontomedia/core/expression#StartTime</seealso>
    let StartTime = Prefixed_Name(oc, "StartTime") |> PrefixedName
    /// <summary>
    ///   <para>oc:TAQ</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Terminus Ante Quem (Limit Before Which): The latest date that the period the event covers could have happened"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Period Terminal Limit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#TAQ">http://contextus.net/ontology/ontomedia/core/expression#TAQ</seealso>
    let TAQ = Prefixed_Name(oc, "TAQ") |> PrefixedName
    /// <summary>
    ///   <para>oc:TPQ</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The time/date/temporal reference for the start of the event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Temporal Start"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#TPQ">http://contextus.net/ontology/ontomedia/core/expression#TPQ</seealso>
    let TPQ = Prefixed_Name(oc, "TPQ") |> PrefixedName
    /// <summary>
    ///   <para>oc:Timeline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class contains a sequence of occurring events"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Timeline"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#Timeline">http://contextus.net/ontology/ontomedia/core/expression#Timeline</seealso>
    let Timeline = Prefixed_Name(oc, "Timeline") |> PrefixedName
    /// <summary>
    ///   <para>oc:Transformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This event class results in no gain or loss of attributes or entities, merely alteration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Transformation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#Transformation">http://contextus.net/ontology/ontomedia/core/expression#Transformation</seealso>
    let Transformation = Prefixed_Name(oc, "Transformation") |> PrefixedName
    /// <summary>
    ///   <para>oc:allows-existence-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This class represents that the desired expression may exist within the context"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Allows Existence Of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#allows-existence-of">http://contextus.net/ontology/ontomedia/core/expression#allows-existence-of</seealso>
    let allows_existence_of = Prefixed_Name(oc, "allows-existence-of") |> PrefixedName
    /// <summary>
    ///   <para>oc:caused-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This property indicates the instigating factor of an event, whether it be an item, event, or collection."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Caused By"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#caused-by">http://contextus.net/ontology/ontomedia/core/expression#caused-by</seealso>
    let caused_by = Prefixed_Name(oc, "caused-by") |> PrefixedName
    /// <summary>
    ///   <para>oc:causes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This property indicates the instigating factor of an event, whether it be an item, event, or collection."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Causes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#causes">http://contextus.net/ontology/ontomedia/core/expression#causes</seealso>
    let causes = Prefixed_Name(oc, "causes") |> PrefixedName
    /// <summary>
    ///   <para>oc:contained-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property indicates that one expression is contained by the other"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Contained By"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#contained-by">http://contextus.net/ontology/ontomedia/core/expression#contained-by</seealso>
    let contained_by = Prefixed_Name(oc, "contained-by") |> PrefixedName
    /// <summary>
    ///   <para>oc:contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property indicates that one expression contains the other"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Contains"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#contains">http://contextus.net/ontology/ontomedia/core/expression#contains</seealso>
    let contains = Prefixed_Name(oc, "contains") |> PrefixedName
    /// <summary>
    ///   <para>oc:end-point</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the point in the media at which the event occurrence stops happening"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"End Point in Media"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#end-point">http://contextus.net/ontology/ontomedia/core/expression#end-point</seealso>
    let end_point = Prefixed_Name(oc, "end-point") |> PrefixedName
    /// <summary>
    ///   <para>oc:exists-in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This class represents that the expression exists within the related context"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Exists In"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#exists-in">http://contextus.net/ontology/ontomedia/core/expression#exists-in</seealso>
    let exists_in = Prefixed_Name(oc, "exists-in") |> PrefixedName
    /// <summary>
    ///   <para>oc:final-event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#final-event">http://contextus.net/ontology/ontomedia/core/expression#final-event</seealso>
    let final_event = Prefixed_Name(oc, "final-event") |> PrefixedName
    /// <summary>
    ///   <para>oc:follows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Follows specifies the occurrence that happens after the referencing occurrence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Follows"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#follows">http://contextus.net/ontology/ontomedia/core/expression#follows</seealso>
    let follows = Prefixed_Name(oc, "follows") |> PrefixedName
    /// <summary>
    ///   <para>oc:from</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the entity which is being transformed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"From"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#from">http://contextus.net/ontology/ontomedia/core/expression#from</seealso>
    let from = Prefixed_Name(oc, "from") |> PrefixedName
    /// <summary>
    ///   <para>oc:has-duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This property specifies the duration of the occurrence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Duration of Occurrence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#has-duration">http://contextus.net/ontology/ontomedia/core/expression#has-duration</seealso>
    let has_duration = Prefixed_Name(oc, "has-duration") |> PrefixedName

    /// <summary>
    ///   <para>oc:has-max-number-of-parts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the maximum number of parts that can be contained by the collection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Has Maximum Number Of Parts"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#has-max-number-of-parts">http://contextus.net/ontology/ontomedia/core/expression#has-max-number-of-parts</seealso>
    let has_max_number_of_parts =
        Prefixed_Name(oc, "has-max-number-of-parts") |> PrefixedName

    /// <summary>
    ///   <para>oc:has-min-number-of-parts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the minimum number of parts that can be contained by the collection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Has Minimum Number Of Parts"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#has-min-number-of-parts">http://contextus.net/ontology/ontomedia/core/expression#has-min-number-of-parts</seealso>
    let has_min_number_of_parts =
        Prefixed_Name(oc, "has-min-number-of-parts") |> PrefixedName

    /// <summary>
    ///   <para>oc:has-number-of-parts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the number of parts contained by the collection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Has Number Of Parts"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#has-number-of-parts">http://contextus.net/ontology/ontomedia/core/expression#has-number-of-parts</seealso>
    let has_number_of_parts = Prefixed_Name(oc, "has-number-of-parts") |> PrefixedName
    /// <summary>
    ///   <para>oc:has-object-entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the entity which is the target of the event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Has Object Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#has-object-entity">http://contextus.net/ontology/ontomedia/core/expression#has-object-entity</seealso>
    let has_object_entity = Prefixed_Name(oc, "has-object-entity") |> PrefixedName
    /// <summary>
    ///   <para>oc:has-occurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property defines any occurrences of this event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Has occurrence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#has-occurrence">http://contextus.net/ontology/ontomedia/core/expression#has-occurrence</seealso>
    let has_occurrence = Prefixed_Name(oc, "has-occurrence") |> PrefixedName
    /// <summary>
    ///   <para>oc:has-shadow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property indicates that the expression is a variation on another, very similar but not exactly the same. For example the different interpretations of the same character"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Has Shadow"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#has-shadow">http://contextus.net/ontology/ontomedia/core/expression#has-shadow</seealso>
    let has_shadow = Prefixed_Name(oc, "has-shadow") |> PrefixedName
    /// <summary>
    ///   <para>oc:has-spin-off</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property indicates that the expression has developed from another"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Has Spin Off"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#has-spin-off">http://contextus.net/ontology/ontomedia/core/expression#has-spin-off</seealso>
    let has_spin_off = Prefixed_Name(oc, "has-spin-off") |> PrefixedName
    /// <summary>
    ///   <para>oc:has-subject-entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the entity which carries out the aim of the event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Has Subject Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#has-subject-entity">http://contextus.net/ontology/ontomedia/core/expression#has-subject-entity</seealso>
    let has_subject_entity = Prefixed_Name(oc, "has-subject-entity") |> PrefixedName
    /// <summary>
    ///   <para>oc:has-variant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property indicates that the expression is a variation of another"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Has Variant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#has-variant">http://contextus.net/ontology/ontomedia/core/expression#has-variant</seealso>
    let has_variant = Prefixed_Name(oc, "has-variant") |> PrefixedName
    /// <summary>
    ///   <para>oc:initial-event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"the first event which begins this sequence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#initial-event">http://contextus.net/ontology/ontomedia/core/expression#initial-event</seealso>
    let initial_event = Prefixed_Name(oc, "initial-event") |> PrefixedName
    /// <summary>
    ///   <para>oc:inspired</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property indicates that the expression inspired another"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Inspired"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#inspired">http://contextus.net/ontology/ontomedia/core/expression#inspired</seealso>
    let inspired = Prefixed_Name(oc, "inspired") |> PrefixedName
    /// <summary>
    ///   <para>oc:inspired-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property indicates that the expression was inspired by another"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Inspired By"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#inspired-by">http://contextus.net/ontology/ontomedia/core/expression#inspired-by</seealso>
    let inspired_by = Prefixed_Name(oc, "inspired-by") |> PrefixedName
    /// <summary>
    ///   <para>oc:involved-in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the events involved in by this entity. Note that this includes the subject and object."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Involves"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#involved-in">http://contextus.net/ontology/ontomedia/core/expression#involved-in</seealso>
    let involved_in = Prefixed_Name(oc, "involved-in") |> PrefixedName
    /// <summary>
    ///   <para>oc:involves</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the entities involved in this event. Note that this includes the subject and object."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Involves"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#involves">http://contextus.net/ontology/ontomedia/core/expression#involves</seealso>
    let involves = Prefixed_Name(oc, "involves") |> PrefixedName
    /// <summary>
    ///   <para>oc:is</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property indicates that the expression is exactly the same as another"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Is"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#is">http://contextus.net/ontology/ontomedia/core/expression#is</seealso>
    let is = Prefixed_Name(oc, "is") |> PrefixedName
    /// <summary>
    ///   <para>oc:is-linked-to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property indicates that there is some type of link between the named Expressions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Is Linked To"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#is-linked-to">http://contextus.net/ontology/ontomedia/core/expression#is-linked-to</seealso>
    let is_linked_to = Prefixed_Name(oc, "is-linked-to") |> PrefixedName
    /// <summary>
    ///   <para>oc:is-not</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property indicates that the expression is entirely different to another"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Is Not"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#is-not">http://contextus.net/ontology/ontomedia/core/expression#is-not</seealso>
    let is_not = Prefixed_Name(oc, "is-not") |> PrefixedName
    /// <summary>
    ///   <para>oc:is-not-linked-to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property indicates that there is some no link between the named Expressions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Is Not Linked To"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#is-not-linked-to">http://contextus.net/ontology/ontomedia/core/expression#is-not-linked-to</seealso>
    let is_not_linked_to = Prefixed_Name(oc, "is-not-linked-to") |> PrefixedName
    /// <summary>
    ///   <para>oc:is-potentially</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property indicates that the expression is potentially another. For example, it may be a possible future version"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Is Potentially"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#is-potentially">http://contextus.net/ontology/ontomedia/core/expression#is-potentially</seealso>
    let is_potentially = Prefixed_Name(oc, "is-potentially") |> PrefixedName
    /// <summary>
    ///   <para>oc:is-shadow-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property indicates that the expression is a variation on another, very similar but not exactly the same. For example the different interpretations of the same character"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Is Shadow Of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#is-shadow-of">http://contextus.net/ontology/ontomedia/core/expression#is-shadow-of</seealso>
    let is_shadow_of = Prefixed_Name(oc, "is-shadow-of") |> PrefixedName
    /// <summary>
    ///   <para>oc:is-spin-off-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property indicates that the expression has developed from another"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Is Spin Off Of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#is-spin-off-of">http://contextus.net/ontology/ontomedia/core/expression#is-spin-off-of</seealso>
    let is_spin_off_of = Prefixed_Name(oc, "is-spin-off-of") |> PrefixedName
    /// <summary>
    ///   <para>oc:occurrence-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property defines any the event that the occurrence relates to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Occurrence Of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#occurrence-of">http://contextus.net/ontology/ontomedia/core/expression#occurrence-of</seealso>
    let occurrence_of = Prefixed_Name(oc, "occurrence-of") |> PrefixedName
    /// <summary>
    ///   <para>oc:occurs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property specifies the region of media in when an event occurrence happens"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Occurs"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#occurs">http://contextus.net/ontology/ontomedia/core/expression#occurs</seealso>
    let occurs = Prefixed_Name(oc, "occurs") |> PrefixedName
    /// <summary>
    ///   <para>oc:postcondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property contains the state which should occur as a consequence of this event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Postcondition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#postcondition">http://contextus.net/ontology/ontomedia/core/expression#postcondition</seealso>
    let postcondition = Prefixed_Name(oc, "postcondition") |> PrefixedName
    /// <summary>
    ///   <para>oc:precedes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property defines the occurrence which immediately follows this occurrence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Precedes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#precedes">http://contextus.net/ontology/ontomedia/core/expression#precedes</seealso>
    let precedes = Prefixed_Name(oc, "precedes") |> PrefixedName
    /// <summary>
    ///   <para>oc:precondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is a state that must exist before the event can occur"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Precondition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#precondition">http://contextus.net/ontology/ontomedia/core/expression#precondition</seealso>
    let precondition = Prefixed_Name(oc, "precondition") |> PrefixedName
    /// <summary>
    ///   <para>oc:referenced-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property indicates that the expression is refered to by another expression."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Refers To"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#referenced-by">http://contextus.net/ontology/ontomedia/core/expression#referenced-by</seealso>
    let referenced_by = Prefixed_Name(oc, "referenced-by") |> PrefixedName
    /// <summary>
    ///   <para>oc:refers-to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property indicates that the expression refers to another expression. This may be an event referring to a location, or a character refering to an event, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Refers To"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#refers-to">http://contextus.net/ontology/ontomedia/core/expression#refers-to</seealso>
    let refers_to = Prefixed_Name(oc, "refers-to") |> PrefixedName
    /// <summary>
    ///   <para>oc:start-point</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property specifies the point in the media at which the event occurrence starts happening"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Start point in Media"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#start-point">http://contextus.net/ontology/ontomedia/core/expression#start-point</seealso>
    let start_point = Prefixed_Name(oc, "start-point") |> PrefixedName
    /// <summary>
    ///   <para>oc:summary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property is a plain-text summery of what occurs in the event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Summary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#summary">http://contextus.net/ontology/ontomedia/core/expression#summary</seealso>
    let summary = Prefixed_Name(oc, "summary") |> PrefixedName
    /// <summary>
    ///   <para>oc:timeline-ref</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Reference to the Timeline that the Occurrence exists on"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Timeline Reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#timeline-ref">http://contextus.net/ontology/ontomedia/core/expression#timeline-ref</seealso>
    let timeline_ref = Prefixed_Name(oc, "timeline-ref") |> PrefixedName
    /// <summary>
    ///   <para>oc:to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the resultant entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"To"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/expression#to">http://contextus.net/ontology/ontomedia/core/expression#to</seealso>
    let to_ = Prefixed_Name(oc, "to") |> PrefixedName

namespace http.semanticweb.cs.vu.nl._2009._11.sem.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sem =
    let _namespace_iri = Namespace_Iri sem |> NamespaceIRI
    /// <summary>
    ///   <para>sem:Actor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Actors are entities that take part in an Event, either actively or passively. Actors do not necessarily have to be sentient. They can also be objects. Actors are a thing, animate or inanimate, physical or non-physical.
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Actors are entities that take part in an Event, either actively or passively. Actors do not necessarily have to be sentient. They can also be objects. Actors are a thing, animate or inanimate, physical or non-physical."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Actor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/Actor">http://semanticweb.cs.vu.nl/2009/11/sem/Actor</seealso>
    let Actor = Prefixed_Name(sem, "Actor") |> PrefixedName
    /// <summary>
    ///   <para>sem:ActorType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EventType contains all resources that are used to classify Actors, e.g. person"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Actor type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/ActorType">http://semanticweb.cs.vu.nl/2009/11/sem/ActorType</seealso>
    let ActorType = Prefixed_Name(sem, "ActorType") |> PrefixedName
    /// <summary>
    ///   <para>sem:Authority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Authorities are entities that state SEM properties. Their nature is not specified. They can symbolize people, organizations, sources of information, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Authority"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/Authority">http://semanticweb.cs.vu.nl/2009/11/sem/Authority</seealso>
    let Authority = Prefixed_Name(sem, "Authority") |> PrefixedName
    /// <summary>
    ///   <para>sem:Constraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The SEM Constraint class contains instances of properties that have a constrained (i.e. not universal) validity. This includes time dependent validity (Temporary), validity in the guise of a specific role (Role), or validity according to a given Authority (View)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Constraint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/Constraint">http://semanticweb.cs.vu.nl/2009/11/sem/Constraint</seealso>
    let Constraint = Prefixed_Name(sem, "Constraint") |> PrefixedName
    /// <summary>
    ///   <para>sem:Core</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The SEM Core class contains all entities that make up the context of an event: Events, Actors, Places, Times. This class is meant to be extended for each application domain."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Core"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/Core">http://semanticweb.cs.vu.nl/2009/11/sem/Core</seealso>
    let Core = Prefixed_Name(sem, "Core") |> PrefixedName
    /// <summary>
    ///   <para>sem:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Events are things that happen. This comprises everything from historical events to web site sessions and mythical journeys. Event is the central class of SEM."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/Event">http://semanticweb.cs.vu.nl/2009/11/sem/Event</seealso>
    let Event = Prefixed_Name(sem, "Event") |> PrefixedName
    /// <summary>
    ///   <para>sem:EventType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EventType contains all resources that are used to classify Events, e.g. meeting."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Event type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/EventType">http://semanticweb.cs.vu.nl/2009/11/sem/EventType</seealso>
    let EventType = Prefixed_Name(sem, "EventType") |> PrefixedName
    /// <summary>
    ///   <para>sem:Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Objects are passive, inanimate Actors."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/Object">http://semanticweb.cs.vu.nl/2009/11/sem/Object</seealso>
    let Object = Prefixed_Name(sem, "Object") |> PrefixedName
    /// <summary>
    ///   <para>sem:Place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Places are locations where an Event happens. They do not need to be physical places and hence do not necessarily need coordinates. Neither do they need to have any significance apart from them being the location of an Event."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Place"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/Place">http://semanticweb.cs.vu.nl/2009/11/sem/Place</seealso>
    let Place = Prefixed_Name(sem, "Place") |> PrefixedName
    /// <summary>
    ///   <para>sem:PlaceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EventType contains all resources that are used to classify Places, e.g. river."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Place type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/PlaceType">http://semanticweb.cs.vu.nl/2009/11/sem/PlaceType</seealso>
    let PlaceType = Prefixed_Name(sem, "PlaceType") |> PrefixedName
    /// <summary>
    ///   <para>sem:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Roles are properties with a subspecified function or position indicated by a RoleType in the scope of an Event. For example, the sem:hasActor property can be subspecified with the RoleType attacker, to denote that the type of participation of the Actor in the scope of the Event is "attacker". The sem:hasPlace property can be subspecified with the RoleType origin, to denote that within the scope of the Event it is the origin."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/Role">http://semanticweb.cs.vu.nl/2009/11/sem/Role</seealso>
    let Role = Prefixed_Name(sem, "Role") |> PrefixedName
    /// <summary>
    ///   <para>sem:RoleType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EventType contains all resources that are used to classify Roles, e.g. receiver."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Role type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/RoleType">http://semanticweb.cs.vu.nl/2009/11/sem/RoleType</seealso>
    let RoleType = Prefixed_Name(sem, "RoleType") |> PrefixedName
    /// <summary>
    ///   <para>sem:Temporary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Temporaries are properties that only hold during a certain Time, which is either indicated with the sem:hasTime property to an instance of sem:Time, or with the sem:hasTimeStamp property to some timestamp(s)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Temporary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/Temporary">http://semanticweb.cs.vu.nl/2009/11/sem/Temporary</seealso>
    let Temporary = Prefixed_Name(sem, "Temporary") |> PrefixedName
    /// <summary>
    ///   <para>sem:Time</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Time contains symbolic representations of when an Event took place. Time instances do not necessarily need to have a timestamp associated with them. The Time class exists to represent semantics of time, e.g. that one thing happens before another, even though the exact timestamps are unknown."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/Time">http://semanticweb.cs.vu.nl/2009/11/sem/Time</seealso>
    let Time = Prefixed_Name(sem, "Time") |> PrefixedName
    /// <summary>
    ///   <para>sem:TimeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EventType contains all resources that are used to classify Time, e.g. century."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Time type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/TimeType">http://semanticweb.cs.vu.nl/2009/11/sem/TimeType</seealso>
    let TimeType = Prefixed_Name(sem, "TimeType") |> PrefixedName
    /// <summary>
    ///   <para>sem:Type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The SEM Type class contains all types of Core instances. These can be either individuals of classes themselves. This class is meant to be extended for each application domain."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/Type">http://semanticweb.cs.vu.nl/2009/11/sem/Type</seealso>
    let Type = Prefixed_Name(sem, "Type") |> PrefixedName
    /// <summary>
    ///   <para>sem:View</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Views are properties that only hold according to a certain Authority."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"View"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/View">http://semanticweb.cs.vu.nl/2009/11/sem/View</seealso>
    let View = Prefixed_Name(sem, "View") |> PrefixedName
    /// <summary>
    ///   <para>sem:accordingTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"According to is used to state which Authority sais that a property constrained by the View Constraint is true."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"according to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/accordingTo">http://semanticweb.cs.vu.nl/2009/11/sem/accordingTo</seealso>
    let accordingTo = Prefixed_Name(sem, "accordingTo") |> PrefixedName
    /// <summary>
    ///   <para>sem:actorType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Has actor type is used to assign a type to an actor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has actor type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/actorType">http://semanticweb.cs.vu.nl/2009/11/sem/actorType</seealso>
    let actorType = Prefixed_Name(sem, "actorType") |> PrefixedName
    /// <summary>
    ///   <para>sem:eventProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Event properties connect Events to other SEM Core entities."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Event properties connect Events to other SEM Core entities."</para>
    /// labels<para>"event property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"eventProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/eventProperty">http://semanticweb.cs.vu.nl/2009/11/sem/eventProperty</seealso>
    let eventProperty = Prefixed_Name(sem, "eventProperty") |> PrefixedName
    /// <summary>
    ///   <para>sem:eventType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Has event type is used to assign a type to an event."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has event type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/eventType">http://semanticweb.cs.vu.nl/2009/11/sem/eventType</seealso>
    let eventType = Prefixed_Name(sem, "eventType") |> PrefixedName
    /// <summary>
    ///   <para>sem:hasActor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Has actor is used to state which Actors or Objects participate in an Event."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Has actor is used to state which Actors or Objects participate in an Event."</para>
    /// labels<para>"has Actor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"hasActor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/hasActor">http://semanticweb.cs.vu.nl/2009/11/sem/hasActor</seealso>
    let hasActor = Prefixed_Name(sem, "hasActor") |> PrefixedName
    /// <summary>
    ///   <para>sem:hasBeginTimeStamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Has begin timestamp is used to indicate the beginning of a time interval. Omitting the hasBeginTimeStamp while stating a hasEndTimeStamp is interpreted as an open ended interval."</para>
    ///   <para>"Has begin timestamp is used to indicate the beginning of a time interval. Omitting the hasBeginTimeStamp while stating a hasEndTimeStamp is interpreted as an open ended interval."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has begin timestamp"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"hasBeginTimestamp"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/hasBeginTimeStamp">http://semanticweb.cs.vu.nl/2009/11/sem/hasBeginTimeStamp</seealso>
    let hasBeginTimeStamp = Prefixed_Name(sem, "hasBeginTimeStamp") |> PrefixedName

    /// <summary>
    ///   <para>sem:hasEarliestBeginTimeStamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Has earliest begin timestamp is used to indicate the earliest possible starting time of an uncertain time interval."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has earliest begin timestamp"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/hasEarliestBeginTimeStamp">http://semanticweb.cs.vu.nl/2009/11/sem/hasEarliestBeginTimeStamp</seealso>
    let hasEarliestBeginTimeStamp =
        Prefixed_Name(sem, "hasEarliestBeginTimeStamp") |> PrefixedName

    /// <summary>
    ///   <para>sem:hasEarliestEndTimeStamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Has earliest end timestamp is used to indicate the earliest possible ending time of an uncertain time interval."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has earliest end timestamp"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/hasEarliestEndTimeStamp">http://semanticweb.cs.vu.nl/2009/11/sem/hasEarliestEndTimeStamp</seealso>
    let hasEarliestEndTimeStamp =
        Prefixed_Name(sem, "hasEarliestEndTimeStamp") |> PrefixedName

    /// <summary>
    ///   <para>sem:hasEndTimeStamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Has end timestamp is used to indicate the end of a time interval. Omitting the hasEndTimeStamp while stating a hasBeginTimeStamp is interpreted as an open ended interval."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Has end timestamp is used to indicate the end of a time interval. Omitting the hasEndTimeStamp while stating a hasBeginTimeStamp is interpreted as an open ended interval."</para>
    /// labels<para>"has end timestamp"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"hasEndTimestamp"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/hasEndTimeStamp">http://semanticweb.cs.vu.nl/2009/11/sem/hasEndTimeStamp</seealso>
    let hasEndTimeStamp = Prefixed_Name(sem, "hasEndTimeStamp") |> PrefixedName

    /// <summary>
    ///   <para>sem:hasLatestBeginTimeStamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Has latest begin timestamp is used to indicate the latest possible starting time of an uncertain time interval."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has latest begin timestamp"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/hasLatestBeginTimeStamp">http://semanticweb.cs.vu.nl/2009/11/sem/hasLatestBeginTimeStamp</seealso>
    let hasLatestBeginTimeStamp =
        Prefixed_Name(sem, "hasLatestBeginTimeStamp") |> PrefixedName

    /// <summary>
    ///   <para>sem:hasLatestEndTimeStamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Has latest end timestamp is used to indicate the latest possible ending time of an uncertain time interval."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has latest end timestamp"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/hasLatestEndTimeStamp">http://semanticweb.cs.vu.nl/2009/11/sem/hasLatestEndTimeStamp</seealso>
    let hasLatestEndTimeStamp =
        Prefixed_Name(sem, "hasLatestEndTimeStamp") |> PrefixedName

    /// <summary>
    ///   <para>sem:hasPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Has place is used to state in which Place(s) an Event happened. Coordinates can be attached to the Place with the W3C Geospatial Vocabulary (http://www.w3.org/2005/Incubator/geo/XGR-geo-20071023/)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasPlace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"has Place"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/hasPlace">http://semanticweb.cs.vu.nl/2009/11/sem/hasPlace</seealso>
    let hasPlace = Prefixed_Name(sem, "hasPlace") |> PrefixedName
    /// <summary>
    ///   <para>sem:hasSubEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Has subevent connects an Event to other Events that belong to it. This is a very generic property that does not mean the subevents fully define the superconcept or that there is any causal relationship."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has subevent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/hasSubEvent">http://semanticweb.cs.vu.nl/2009/11/sem/hasSubEvent</seealso>
    let hasSubEvent = Prefixed_Name(sem, "hasSubEvent") |> PrefixedName
    /// <summary>
    ///   <para>sem:hasSubType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Has sub type is used to state that a type falls under another type. This is a generic aggregation relation that is used to generalize over various hierarchical relations that can exist between types."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has subtype"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/hasSubType">http://semanticweb.cs.vu.nl/2009/11/sem/hasSubType</seealso>
    let hasSubType = Prefixed_Name(sem, "hasSubType") |> PrefixedName
    /// <summary>
    ///   <para>sem:hasTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Has time is used to indicate at which time an Event took place or when a property under the Temporary Constraint is valid. Has time points to a symbolic representation of time, which allows semantic relations between time resources. (see http://www.w3.org/TR/owl-time/)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has Time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/hasTime">http://semanticweb.cs.vu.nl/2009/11/sem/hasTime</seealso>
    let hasTime = Prefixed_Name(sem, "hasTime") |> PrefixedName
    /// <summary>
    ///   <para>sem:hasTimeStamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Has timestamp is used to put time indicators on any individual. It is the most common way to state when an Event took place. There are subproperties of hasTimeStamp to represent time intervals and uncertain time intervals. If the exact moment is not known, but it is necessary to specify a certain time, use hasTime instead. All of these properties are also used to indicate the time at which a property under the Temporary Constraint is valid."</para>
    ///   <para>"Has timestamp is used to put time indicators on any individual. It is the most common way to state when an Event took place. There are subproperties of hasTimeStamp to represent time intervals and uncertain time intervals. If the exact moment is not known, but it is necessary to specify a certain time, use hasTime instead. All of these properties are also used to indicate the time at which a property under the Temporary Constraint is valid."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has timestamp"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"hasTimestamp"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/hasTimeStamp">http://semanticweb.cs.vu.nl/2009/11/sem/hasTimeStamp</seealso>
    let hasTimeStamp = Prefixed_Name(sem, "hasTimeStamp") |> PrefixedName
    /// <summary>
    ///   <para>sem:placeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Has place type is used to assign a type to a place."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has place type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/placeType">http://semanticweb.cs.vu.nl/2009/11/sem/placeType</seealso>
    let placeType = Prefixed_Name(sem, "placeType") |> PrefixedName
    /// <summary>
    ///   <para>sem:roleType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Has role type is used to assign a role type to a Role property constraint. This role is a subspecification of the eventProperty which it constrains. For example, if an Event hasActor an Actor and this property is given a Role Constraint, then roleType can be used to assign a role to the participation of the Actor in the Event indicated by hasActor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has role type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/roleType">http://semanticweb.cs.vu.nl/2009/11/sem/roleType</seealso>
    let roleType = Prefixed_Name(sem, "roleType") |> PrefixedName
    /// <summary>
    ///   <para>sem:subEventOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse property of hasSubEvent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"subevent of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/subEventOf">http://semanticweb.cs.vu.nl/2009/11/sem/subEventOf</seealso>
    let subEventOf = Prefixed_Name(sem, "subEventOf") |> PrefixedName
    /// <summary>
    ///   <para>sem:subTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The inverse property of hasSubType."</para>
    ///   <para>"The inverse property of hasSubType."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"subtype of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/subTypeOf">http://semanticweb.cs.vu.nl/2009/11/sem/subTypeOf</seealso>
    let subTypeOf = Prefixed_Name(sem, "subTypeOf") |> PrefixedName
    /// <summary>
    ///   <para>sem:timeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Has time type is used to assign a type to a time individual."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has time type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/timeType">http://semanticweb.cs.vu.nl/2009/11/sem/timeType</seealso>
    let timeType = Prefixed_Name(sem, "timeType") |> PrefixedName
    /// <summary>
    ///   <para>sem:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Type is the super property of the properties that are used to indicate the type of a Core instance, eventType, actorType, placeType, timeType; and of roleType. Types can be both classes and individuals, cf. OWL 2 punning."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"type property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://semanticweb.cs.vu.nl/2009/11/sem/type">http://semanticweb.cs.vu.nl/2009/11/sem/type</seealso>
    let type_ = Prefixed_Name(sem, "type") |> PrefixedName

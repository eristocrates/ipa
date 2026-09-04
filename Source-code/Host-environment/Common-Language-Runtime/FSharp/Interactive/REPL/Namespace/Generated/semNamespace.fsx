#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module sem =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://semanticweb.cs.vu.nl/2009/11/sem/" "sem"

    /// <summary>
    ///   <para>rdfs:comment : Actors are entities that take part in an Event, either actively or passively. Actors do not necessarily have to be sentient. They can also be objects. Actors are a thing, animate or inanimate, physical or non-physical.
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : Actor^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/Actor">sem:Actor</a>
    /// </summary>
    let Actor = _prefixId.prefix "Actor"
    /// <summary>
    ///   <para>rdfs:label : Actor type^^xsd:string</para>
    ///   <para>rdfs:comment : EventType contains all resources that are used to classify Actors, e.g. person^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/ActorType">sem:ActorType</a>
    /// </summary>
    let ActorType = _prefixId.prefix "ActorType"
    /// <summary>
    ///   <para>rdfs:label : Authority^^xsd:string</para>
    ///   <para>rdfs:comment : Authorities are entities that state SEM properties. Their nature is not specified. They can symbolize people, organizations, sources of information, etc.^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/Authority">sem:Authority</a>
    /// </summary>
    let Authority = _prefixId.prefix "Authority"
    /// <summary>
    ///   <para>rdfs:label : Constraint^^xsd:string</para>
    ///   <para>rdfs:comment : The SEM Constraint class contains instances of properties that have a constrained (i.e. not universal) validity. This includes time dependent validity (Temporary), validity in the guise of a specific role (Role), or validity according to a given Authority (View).^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/Constraint">sem:Constraint</a>
    /// </summary>
    let Constraint = _prefixId.prefix "Constraint"
    /// <summary>
    ///   <para>rdfs:label : Core^^xsd:string</para>
    ///   <para>rdfs:comment : The SEM Core class contains all entities that make up the context of an event: Events, Actors, Places, Times. This class is meant to be extended for each application domain.^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/Core">sem:Core</a>
    /// </summary>
    let Core = _prefixId.prefix "Core"
    /// <summary>
    ///   <para>rdfs:label : Event^^xsd:string</para>
    ///   <para>rdfs:comment : Events are things that happen. This comprises everything from historical events to web site sessions and mythical journeys. Event is the central class of SEM.^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/Event">sem:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>rdfs:label : Event type^^xsd:string</para>
    ///   <para>rdfs:comment : EventType contains all resources that are used to classify Events, e.g. meeting.^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/EventType">sem:EventType</a>
    /// </summary>
    let EventType = _prefixId.prefix "EventType"
    /// <summary>
    ///   <para>rdfs:comment : Objects are passive, inanimate Actors.^^xsd:string</para>
    ///   <para>rdfs:label : Object^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/Object">sem:Object</a>
    /// </summary>
    let Object = _prefixId.prefix "Object"
    /// <summary>
    ///   <para>rdfs:comment : Places are locations where an Event happens. They do not need to be physical places and hence do not necessarily need coordinates. Neither do they need to have any significance apart from them being the location of an Event.^^xsd:string</para>
    ///   <para>rdfs:label : Place^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/Place">sem:Place</a>
    /// </summary>
    let Place = _prefixId.prefix "Place"
    /// <summary>
    ///   <para>rdfs:label : Place type^^xsd:string</para>
    ///   <para>rdfs:comment : EventType contains all resources that are used to classify Places, e.g. river.^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/PlaceType">sem:PlaceType</a>
    /// </summary>
    let PlaceType = _prefixId.prefix "PlaceType"
    /// <summary>
    ///   <para>rdfs:label : Role^^xsd:string</para>
    ///   <para>rdfs:comment : Roles are properties with a subspecified function or position indicated by a RoleType in the scope of an Event. For example, the sem:hasActor property can be subspecified with the RoleType attacker, to denote that the type of participation of the Actor in the scope of the Event is "attacker". The sem:hasPlace property can be subspecified with the RoleType origin, to denote that within the scope of the Event it is the origin.^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/Role">sem:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>rdfs:label : Role type^^xsd:string</para>
    ///   <para>rdfs:comment : EventType contains all resources that are used to classify Roles, e.g. receiver.^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/RoleType">sem:RoleType</a>
    /// </summary>
    let RoleType = _prefixId.prefix "RoleType"
    /// <summary>
    ///   <para>rdfs:label : Temporary^^xsd:string</para>
    ///   <para>rdfs:comment : Temporaries are properties that only hold during a certain Time, which is either indicated with the sem:hasTime property to an instance of sem:Time, or with the sem:hasTimeStamp property to some timestamp(s).^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/Temporary">sem:Temporary</a>
    /// </summary>
    let Temporary = _prefixId.prefix "Temporary"
    /// <summary>
    ///   <para>rdfs:label : Time^^xsd:string</para>
    ///   <para>rdfs:comment : Time contains symbolic representations of when an Event took place. Time instances do not necessarily need to have a timestamp associated with them. The Time class exists to represent semantics of time, e.g. that one thing happens before another, even though the exact timestamps are unknown.^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/Time">sem:Time</a>
    /// </summary>
    let Time = _prefixId.prefix "Time"
    /// <summary>
    ///   <para>rdfs:label : Time type^^xsd:string</para>
    ///   <para>rdfs:comment : EventType contains all resources that are used to classify Time, e.g. century.^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/TimeType">sem:TimeType</a>
    /// </summary>
    let TimeType = _prefixId.prefix "TimeType"
    /// <summary>
    ///   <para>rdfs:label : Type^^xsd:string</para>
    ///   <para>rdfs:comment : The SEM Type class contains all types of Core instances. These can be either individuals of classes themselves. This class is meant to be extended for each application domain.^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/Type">sem:Type</a>
    /// </summary>
    let Type = _prefixId.prefix "Type"
    /// <summary>
    ///   <para>rdfs:label : View^^xsd:string</para>
    ///   <para>rdfs:comment : Views are properties that only hold according to a certain Authority.^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/View">sem:View</a>
    /// </summary>
    let View = _prefixId.prefix "View"
    /// <summary>
    ///   <para>rdfs:label : according to^^xsd:string</para>
    ///   <para>rdfs:comment : According to is used to state which Authority sais that a property constrained by the View Constraint is true.^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/accordingTo">sem:accordingTo</a>
    /// </summary>
    let accordingTo = _prefixId.prefix "accordingTo"
    /// <summary>
    ///   <para>rdfs:label : has actor type^^xsd:string</para>
    ///   <para>rdfs:comment : Has actor type is used to assign a type to an actor.^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/actorType">sem:actorType</a>
    /// </summary>
    let actorType = _prefixId.prefix "actorType"
    /// <summary>
    ///   <para>rdfs:label : event property^^xsd:string</para>
    ///   <para>rdfs:comment : Event properties connect Events to other SEM Core entities.^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/eventProperty">sem:eventProperty</a>
    /// </summary>
    let eventProperty = _prefixId.prefix "eventProperty"
    /// <summary>
    ///   <para>rdfs:label : has event type^^xsd:string</para>
    ///   <para>rdfs:comment : Has event type is used to assign a type to an event.^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/eventType">sem:eventType</a>
    /// </summary>
    let eventType = _prefixId.prefix "eventType"
    /// <summary>
    ///   <para>rdfs:label : has Actor^^xsd:string</para>
    ///   <para>rdfs:comment : Has actor is used to state which Actors or Objects participate in an Event.^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/hasActor">sem:hasActor</a>
    /// </summary>
    let hasActor = _prefixId.prefix "hasActor"
    /// <summary>
    ///   <para>rdfs:label : has begin timestamp^^xsd:string</para>
    ///   <para>rdfs:comment : Has begin timestamp is used to indicate the beginning of a time interval. Omitting the hasBeginTimeStamp while stating a hasEndTimeStamp is interpreted as an open ended interval.^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/hasBeginTimeStamp">sem:hasBeginTimeStamp</a>
    /// </summary>
    let hasBeginTimeStamp = _prefixId.prefix "hasBeginTimeStamp"
    /// <summary>
    ///   <para>rdfs:label : has earliest begin timestamp^^xsd:string</para>
    ///   <para>rdfs:comment : Has earliest begin timestamp is used to indicate the earliest possible starting time of an uncertain time interval.^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/hasEarliestBeginTimeStamp">sem:hasEarliestBeginTimeStamp</a>
    /// </summary>
    let hasEarliestBeginTimeStamp = _prefixId.prefix "hasEarliestBeginTimeStamp"
    /// <summary>
    ///   <para>rdfs:label : has earliest end timestamp^^xsd:string</para>
    ///   <para>rdfs:comment : Has earliest end timestamp is used to indicate the earliest possible ending time of an uncertain time interval.^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/hasEarliestEndTimeStamp">sem:hasEarliestEndTimeStamp</a>
    /// </summary>
    let hasEarliestEndTimeStamp = _prefixId.prefix "hasEarliestEndTimeStamp"
    /// <summary>
    ///   <para>rdfs:label : has end timestamp^^xsd:string</para>
    ///   <para>rdfs:comment : Has end timestamp is used to indicate the end of a time interval. Omitting the hasEndTimeStamp while stating a hasBeginTimeStamp is interpreted as an open ended interval.^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/hasEndTimeStamp">sem:hasEndTimeStamp</a>
    /// </summary>
    let hasEndTimeStamp = _prefixId.prefix "hasEndTimeStamp"
    /// <summary>
    ///   <para>rdfs:label : has latest begin timestamp^^xsd:string</para>
    ///   <para>rdfs:comment : Has latest begin timestamp is used to indicate the latest possible starting time of an uncertain time interval.^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/hasLatestBeginTimeStamp">sem:hasLatestBeginTimeStamp</a>
    /// </summary>
    let hasLatestBeginTimeStamp = _prefixId.prefix "hasLatestBeginTimeStamp"
    /// <summary>
    ///   <para>rdfs:label : has latest end timestamp^^xsd:string</para>
    ///   <para>rdfs:comment : Has latest end timestamp is used to indicate the latest possible ending time of an uncertain time interval.^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/hasLatestEndTimeStamp">sem:hasLatestEndTimeStamp</a>
    /// </summary>
    let hasLatestEndTimeStamp = _prefixId.prefix "hasLatestEndTimeStamp"
    /// <summary>
    ///   <para>rdfs:label : has Place^^xsd:string</para>
    ///   <para>rdfs:comment : Has place is used to state in which Place(s) an Event happened. Coordinates can be attached to the Place with the W3C Geospatial Vocabulary (http://www.w3.org/2005/Incubator/geo/XGR-geo-20071023/).^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/hasPlace">sem:hasPlace</a>
    /// </summary>
    let hasPlace = _prefixId.prefix "hasPlace"
    /// <summary>
    ///   <para>rdfs:label : has subevent^^xsd:string</para>
    ///   <para>rdfs:comment : Has subevent connects an Event to other Events that belong to it. This is a very generic property that does not mean the subevents fully define the superconcept or that there is any causal relationship.^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/hasSubEvent">sem:hasSubEvent</a>
    /// </summary>
    let hasSubEvent = _prefixId.prefix "hasSubEvent"
    /// <summary>
    ///   <para>rdfs:label : has subtype^^xsd:string</para>
    ///   <para>rdfs:comment : Has sub type is used to state that a type falls under another type. This is a generic aggregation relation that is used to generalize over various hierarchical relations that can exist between types.^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/hasSubType">sem:hasSubType</a>
    /// </summary>
    let hasSubType = _prefixId.prefix "hasSubType"
    /// <summary>
    ///   <para>rdfs:label : has Time^^xsd:string</para>
    ///   <para>rdfs:comment : Has time is used to indicate at which time an Event took place or when a property under the Temporary Constraint is valid. Has time points to a symbolic representation of time, which allows semantic relations between time resources. (see http://www.w3.org/TR/owl-time/)^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/hasTime">sem:hasTime</a>
    /// </summary>
    let hasTime = _prefixId.prefix "hasTime"
    /// <summary>
    ///   <para>rdfs:label : has timestamp^^xsd:string</para>
    ///   <para>rdfs:comment : Has timestamp is used to put time indicators on any individual. It is the most common way to state when an Event took place. There are subproperties of hasTimeStamp to represent time intervals and uncertain time intervals. If the exact moment is not known, but it is necessary to specify a certain time, use hasTime instead. All of these properties are also used to indicate the time at which a property under the Temporary Constraint is valid.^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/hasTimeStamp">sem:hasTimeStamp</a>
    /// </summary>
    let hasTimeStamp = _prefixId.prefix "hasTimeStamp"
    /// <summary>
    ///   <para>rdfs:label : has place type^^xsd:string</para>
    ///   <para>rdfs:comment : Has place type is used to assign a type to a place.^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/placeType">sem:placeType</a>
    /// </summary>
    let placeType = _prefixId.prefix "placeType"
    /// <summary>
    ///   <para>rdfs:label : has role type^^xsd:string</para>
    ///   <para>rdfs:comment : Has role type is used to assign a role type to a Role property constraint. This role is a subspecification of the eventProperty which it constrains. For example, if an Event hasActor an Actor and this property is given a Role Constraint, then roleType can be used to assign a role to the participation of the Actor in the Event indicated by hasActor.^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/roleType">sem:roleType</a>
    /// </summary>
    let roleType = _prefixId.prefix "roleType"
    /// <summary>
    ///   <para>rdfs:label : subevent of^^xsd:string</para>
    ///   <para>rdfs:comment : Inverse property of hasSubEvent^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/subEventOf">sem:subEventOf</a>
    /// </summary>
    let subEventOf = _prefixId.prefix "subEventOf"
    /// <summary>
    ///   <para>rdfs:label : subtype of^^xsd:string</para>
    ///   <para>rdfs:comment : The inverse property of hasSubType.^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/subTypeOf">sem:subTypeOf</a>
    /// </summary>
    let subTypeOf = _prefixId.prefix "subTypeOf"
    /// <summary>
    ///   <para>rdfs:label : has time type^^xsd:string</para>
    ///   <para>rdfs:comment : Has time type is used to assign a type to a time individual.^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/timeType">sem:timeType</a>
    /// </summary>
    let timeType = _prefixId.prefix "timeType"
    /// <summary>
    ///   <para>rdfs:label : type property^^xsd:string</para>
    ///   <para>rdfs:comment : Type is the super property of the properties that are used to indicate the type of a Core instance, eventType, actorType, placeType, timeType; and of roleType. Types can be both classes and individuals, cf. OWL 2 punning.^^xsd:string</para>
    ///   <a href="http://semanticweb.cs.vu.nl/2009/11/sem/type">sem:type</a>
    /// </summary>
    let type_ = _prefixId.prefix "type"

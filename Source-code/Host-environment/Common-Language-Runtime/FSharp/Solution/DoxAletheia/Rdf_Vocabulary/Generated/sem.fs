namespace http.semanticweb.cs.vu.nl._2009._11.sem.slash

open DoxAletheia

module sem =
    let _namespace_name = "http://semanticweb.cs.vu.nl/2009/11/sem/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Actors are entities that take part in an Event, either actively or passively. Actors do not necessarily have to be sentient. They can also be objects. Actors are a thing, animate or inanimate, physical or non-physical.
    ///
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/Actor"></see></summary>
    let Actor = _prefix "Actor"
    /// <summary>
    /// The SEM Core class contains all entities that make up the context of an event: Events, Actors, Places, Times. This class is meant to be extended for each application domain.
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/Core"></see></summary>
    let Core = _prefix "Core"
    /// <summary>
    /// Authorities are entities that state SEM properties. Their nature is not specified. They can symbolize people, organizations, sources of information, etc.
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/Authority"></see></summary>
    let Authority = _prefix "Authority"
    /// <summary>
    /// EventType contains all resources that are used to classify Actors, e.g. person
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/ActorType"></see></summary>
    let ActorType = _prefix "ActorType"
    /// <summary>
    /// The SEM Type class contains all types of Core instances. These can be either individuals of classes themselves. This class is meant to be extended for each application domain.
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/Type"></see></summary>
    let Type = _prefix "Type"
    /// <summary>
    /// The SEM Constraint class contains instances of properties that have a constrained (i.e. not universal) validity. This includes time dependent validity (Temporary), validity in the guise of a specific role (Role), or validity according to a given Authority (View).
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/Constraint"></see></summary>
    let Constraint = _prefix "Constraint"
    /// <summary>
    /// Events are things that happen. This comprises everything from historical events to web site sessions and mythical journeys. Event is the central class of SEM.
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/Event"></see></summary>
    let Event = _prefix "Event"
    /// <summary>
    /// EventType contains all resources that are used to classify Events, e.g. meeting.
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/EventType"></see></summary>
    let EventType = _prefix "EventType"
    /// <summary>
    /// Objects are passive, inanimate Actors.
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/Object"></see></summary>
    let Object = _prefix "Object"
    /// <summary>
    /// Places are locations where an Event happens. They do not need to be physical places and hence do not necessarily need coordinates. Neither do they need to have any significance apart from them being the location of an Event.
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/Place"></see></summary>
    let Place = _prefix "Place"
    /// <summary>
    /// EventType contains all resources that are used to classify Places, e.g. river.
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/PlaceType"></see></summary>
    let PlaceType = _prefix "PlaceType"
    /// <summary>
    /// Roles are properties with a subspecified function or position indicated by a RoleType in the scope of an Event. For example, the sem:hasActor property can be subspecified with the RoleType attacker, to denote that the type of participation of the Actor in the scope of the Event is "attacker". The sem:hasPlace property can be subspecified with the RoleType origin, to denote that within the scope of the Event it is the origin.
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/Role"></see></summary>
    let Role = _prefix "Role"
    /// <summary>
    /// EventType contains all resources that are used to classify Roles, e.g. receiver.
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/RoleType"></see></summary>
    let RoleType = _prefix "RoleType"
    /// <summary>
    /// Temporaries are properties that only hold during a certain Time, which is either indicated with the sem:hasTime property to an instance of sem:Time, or with the sem:hasTimeStamp property to some timestamp(s).
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/Temporary"></see></summary>
    let Temporary = _prefix "Temporary"
    /// <summary>
    /// Time contains symbolic representations of when an Event took place. Time instances do not necessarily need to have a timestamp associated with them. The Time class exists to represent semantics of time, e.g. that one thing happens before another, even though the exact timestamps are unknown.
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/Time"></see></summary>
    let Time = _prefix "Time"
    /// <summary>
    /// EventType contains all resources that are used to classify Time, e.g. century.
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/TimeType"></see></summary>
    let TimeType = _prefix "TimeType"
    /// <summary>
    /// Views are properties that only hold according to a certain Authority.
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/View"></see></summary>
    let View = _prefix "View"
    /// <summary>
    /// According to is used to state which Authority sais that a property constrained by the View Constraint is true.
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/accordingTo"></see></summary>
    let accordingTo = _prefix "accordingTo"
    /// <summary>
    /// Has actor type is used to assign a type to an actor.
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/actorType"></see></summary>
    let actorType = _prefix "actorType"
    /// <summary>
    /// Type is the super property of the properties that are used to indicate the type of a Core instance, eventType, actorType, placeType, timeType; and of roleType. Types can be both classes and individuals, cf. OWL 2 punning.
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/type"></see></summary>
    let type_ = _prefix "type"
    /// <summary>
    /// Event properties connect Events to other SEM Core entities.
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/eventProperty"></see></summary>
    let eventProperty = _prefix "eventProperty"
    /// <summary>
    /// Has event type is used to assign a type to an event.
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/eventType"></see></summary>
    let eventType = _prefix "eventType"
    /// <summary>
    /// Has actor is used to state which Actors or Objects participate in an Event.
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/hasActor"></see></summary>
    let hasActor = _prefix "hasActor"
    /// <summary>
    /// Has begin timestamp is used to indicate the beginning of a time interval. Omitting the hasBeginTimeStamp while stating a hasEndTimeStamp is interpreted as an open ended interval.
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/hasBeginTimeStamp"></see></summary>
    let hasBeginTimeStamp = _prefix "hasBeginTimeStamp"
    /// <summary>
    /// Has timestamp is used to put time indicators on any individual. It is the most common way to state when an Event took place. There are subproperties of hasTimeStamp to represent time intervals and uncertain time intervals. If the exact moment is not known, but it is necessary to specify a certain time, use hasTime instead. All of these properties are also used to indicate the time at which a property under the Temporary Constraint is valid.
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/hasTimeStamp"></see></summary>
    let hasTimeStamp = _prefix "hasTimeStamp"
    /// <summary>
    /// Has earliest begin timestamp is used to indicate the earliest possible starting time of an uncertain time interval.
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/hasEarliestBeginTimeStamp"></see></summary>
    let hasEarliestBeginTimeStamp = _prefix "hasEarliestBeginTimeStamp"
    /// <summary>
    /// Has earliest end timestamp is used to indicate the earliest possible ending time of an uncertain time interval.
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/hasEarliestEndTimeStamp"></see></summary>
    let hasEarliestEndTimeStamp = _prefix "hasEarliestEndTimeStamp"
    /// <summary>
    /// Has end timestamp is used to indicate the end of a time interval. Omitting the hasEndTimeStamp while stating a hasBeginTimeStamp is interpreted as an open ended interval.
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/hasEndTimeStamp"></see></summary>
    let hasEndTimeStamp = _prefix "hasEndTimeStamp"
    /// <summary>
    /// Has latest begin timestamp is used to indicate the latest possible starting time of an uncertain time interval.
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/hasLatestBeginTimeStamp"></see></summary>
    let hasLatestBeginTimeStamp = _prefix "hasLatestBeginTimeStamp"
    /// <summary>
    /// Has latest end timestamp is used to indicate the latest possible ending time of an uncertain time interval.
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/hasLatestEndTimeStamp"></see></summary>
    let hasLatestEndTimeStamp = _prefix "hasLatestEndTimeStamp"
    /// <summary>
    /// Has place is used to state in which Place(s) an Event happened. Coordinates can be attached to the Place with the W3C Geospatial Vocabulary (http://www.w3.org/2005/Incubator/geo/XGR-geo-20071023/).
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/hasPlace"></see></summary>
    let hasPlace = _prefix "hasPlace"
    /// <summary>
    /// Has subevent connects an Event to other Events that belong to it. This is a very generic property that does not mean the subevents fully define the superconcept or that there is any causal relationship.
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/hasSubEvent"></see></summary>
    let hasSubEvent = _prefix "hasSubEvent"
    /// <summary>
    /// Inverse property of hasSubEvent
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/subEventOf"></see></summary>
    let subEventOf = _prefix "subEventOf"
    /// <summary>
    /// Has sub type is used to state that a type falls under another type. This is a generic aggregation relation that is used to generalize over various hierarchical relations that can exist between types.
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/hasSubType"></see></summary>
    let hasSubType = _prefix "hasSubType"
    /// <summary>
    /// The inverse property of hasSubType.
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/subTypeOf"></see></summary>
    let subTypeOf = _prefix "subTypeOf"
    /// <summary>
    /// Has time is used to indicate at which time an Event took place or when a property under the Temporary Constraint is valid. Has time points to a symbolic representation of time, which allows semantic relations between time resources. (see http://www.w3.org/TR/owl-time/)
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/hasTime"></see></summary>
    let hasTime = _prefix "hasTime"
    /// <summary>
    /// Has place type is used to assign a type to a place.
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/placeType"></see></summary>
    let placeType = _prefix "placeType"
    /// <summary>
    /// Has role type is used to assign a role type to a Role property constraint. This role is a subspecification of the eventProperty which it constrains. For example, if an Event hasActor an Actor and this property is given a Role Constraint, then roleType can be used to assign a role to the participation of the Actor in the Event indicated by hasActor.
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/roleType"></see></summary>
    let roleType = _prefix "roleType"
    /// <summary>
    /// Has time type is used to assign a type to a time individual.
    /// <see href="http://semanticweb.cs.vu.nl/2009/11/sem/timeType"></see></summary>
    let timeType = _prefix "timeType"

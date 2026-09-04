#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module sulo =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/sulo/" "sulo"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>skos:example : the capability to fly, the capabilty to reduce the activation energy of a chemical reaction, the capability to reason</para>
    ///   <para>rdfs:label : capability^^xsd:string</para>
    ///   <para>rdfs:comment : A capability is a feature that describes what an entity is able to do, under some set of circumstances.</para>
    ///   <a href="https://w3id.org/sulo/Capability">sulo:Capability</a>
    /// </summary>
    let Capability = _prefixId.prefix "Capability"
    /// <summary>
    ///   <para>rdfs:label : duration</para>
    ///   <para>rdfs:comment : Duration is a temporal quantity that represents the extent or (non-negative) amount of time that elapses between two temporal points, typically the start and end of a time interval.</para>
    ///   <a href="https://w3id.org/sulo/Duration">sulo:Duration</a>
    /// </summary>
    let Duration = _prefixId.prefix "Duration"
    /// <summary>
    ///   <para>rdfs:label : end time</para>
    ///   <para>rdfs:comment : an end time is a time instant at the end of a process/time interval.</para>
    ///   <a href="https://w3id.org/sulo/EndTime">sulo:EndTime</a>
    /// </summary>
    let EndTime = _prefixId.prefix "EndTime"
    /// <summary>
    ///   <para>skos:example : the capability to fly, a collection of cards, a measured height of 170cm.</para>
    ///   <para>rdfs:label : feature</para>
    ///   <para>rdfs:comment : A feature is any characteristic that stems from the intrisinc structure and/or context</para>
    ///   <a href="https://w3id.org/sulo/Feature">sulo:Feature</a>
    /// </summary>
    let Feature = _prefixId.prefix "Feature"
    /// <summary>
    ///   <para>rdfs:label : information object</para>
    ///   <para>rdfs:comment : an information object is a feature that represents, is about, or encodes some information.</para>
    ///   <a href="https://w3id.org/sulo/InformationObject">sulo:InformationObject</a>
    /// </summary>
    let InformationObject = _prefixId.prefix "InformationObject"
    /// <summary>
    ///   <para>skos:example : a heart, the function to pump blood, the role of a doctor</para>
    ///   <para>rdfs:label : object</para>
    ///   <para>rdfs:comment : An object is an entity that maintains its identity through time, and does not have processes as its parts.^^xsd:string</para>
    ///   <a href="https://w3id.org/sulo/Object">sulo:Object</a>
    /// </summary>
    let Object = _prefixId.prefix "Object"
    /// <summary>
    ///   <para>skos:example : the process of diagnosing a problem condition, the process of walking down the street, the process of teaching a class</para>
    ///   <para>rdfs:label : process</para>
    ///   <para>rdfs:comment : a process is a entity that unfolds in time, has temporal parts, and has objects that participate in the process.</para>
    ///   <a href="https://w3id.org/sulo/Process">sulo:Process</a>
    /// </summary>
    let Process = _prefixId.prefix "Process"
    /// <summary>
    ///   <para>rdfs:label : quality</para>
    ///   <para>rdfs:comment : A quality is a feature that is intrinsically associated with its bearer (or its parts).rdfs:comment : the color of an apple, the smoothness of skin, the brightness of a star, the speed of an event</para>
    ///   <a href="https://w3id.org/sulo/Quality">sulo:Quality</a>
    /// </summary>
    let Quality = _prefixId.prefix "Quality"
    /// <summary>
    ///   <para>rdfs:label : quantity</para>
    ///   <para>rdfs:comment : A quantity is an informational object that contains the magnitude (and unit) of an attribute.</para>
    ///   <a href="https://w3id.org/sulo/Quantity">sulo:Quantity</a>
    /// </summary>
    let Quantity = _prefixId.prefix "Quantity"
    /// <summary>
    ///   <para>skos:example : a teacher, a student, a catalyst, a substrate, a product, a patient</para>
    ///   <para>rdfs:label : role</para>
    ///   <para>rdfs:comment : A role is a feature that describes a context-dependent behaviour.</para>
    ///   <a href="https://w3id.org/sulo/Role">sulo:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>skos:example : a stamp collection, a murder of crows, the arm of a clinical trial</para>
    ///   <para>rdfs:label : set</para>
    ///   <para>rdfs:comment : A set is an information object for which there may be zero or more items.</para>
    ///   <a href="https://w3id.org/sulo/Set">sulo:Set</a>
    /// </summary>
    let Set = _prefixId.prefix "Set"
    /// <summary>
    ///   <para>skos:example : a mountain, a planet, a photon, the lining of the stomach, the cavity of the stomach, the space between mars and earth</para>
    ///   <para>rdfs:label : spatial object</para>
    ///   <para>rdfs:comment : A spatial object is an object that occupies space</para>
    ///   <a href="https://w3id.org/sulo/SpatialObject">sulo:SpatialObject</a>
    /// </summary>
    let SpatialObject = _prefixId.prefix "SpatialObject"
    /// <summary>
    ///   <para>rdfs:label : start time</para>
    ///   <para>rdfs:comment : a start time is a time instant at the beginning of a process/time interval.</para>
    ///   <a href="https://w3id.org/sulo/StartTime">sulo:StartTime</a>
    /// </summary>
    let StartTime = _prefixId.prefix "StartTime"
    /// <summary>
    ///   <para>rdfs:label : time</para>
    ///   <para>rdfs:comment : time is a quantity pertaining to the duration of some interval of time or a particular instant of time (against some frame of reference).</para>
    ///   <a href="https://w3id.org/sulo/Time">sulo:Time</a>
    /// </summary>
    let Time = _prefixId.prefix "Time"
    /// <summary>
    ///   <para>rdfs:label : time instant</para>
    ///   <para>rdfs:comment : time instant is a quantity of time a particular moment in time.</para>
    ///   <a href="https://w3id.org/sulo/TimeInstant">sulo:TimeInstant</a>
    /// </summary>
    let TimeInstant = _prefixId.prefix "TimeInstant"
    /// <summary>
    ///   <para>rdfs:label : time interval^^xsd:string</para>
    ///   <para>rdfs:comment : A time interval is a quantity for a continuous and bounded extent of time, characterized by a start time and an end time.</para>
    ///   <a href="https://w3id.org/sulo/TimeInterval">sulo:TimeInterval</a>
    /// </summary>
    let TimeInterval = _prefixId.prefix "TimeInterval"
    /// <summary>
    ///   <para>rdfs:label : unit^^xsd:string</para>
    ///   <para>rdfs:comment : a unit is a standardized quantity that is used as a reference for a particular quantity.</para>
    ///   <a href="https://w3id.org/sulo/Unit">sulo:Unit</a>
    /// </summary>
    let Unit = _prefixId.prefix "Unit"
    /// <summary>
    ///   <para>dcterms:alternative : existsAt</para>
    ///   <para>rdfs:label : at time</para>
    ///   <para>rdfs:comment : a relation between any thing and the time in which it occurs at.</para>
    ///   <a href="https://w3id.org/sulo/atTime">sulo:atTime</a>
    /// </summary>
    let atTime = _prefixId.prefix "atTime"
    /// <summary>
    ///   <para>rdfs:label : has direct part^^xsd:string</para>
    ///   <para>rdfs:comment : has direct part is a non-transitive parthood relation that can be used to specify cardinality constraints between a whole and its parts.</para>
    ///   <a href="https://w3id.org/sulo/hasDirectPart">sulo:hasDirectPart</a>
    /// </summary>
    let hasDirectPart = _prefixId.prefix "hasDirectPart"
    /// <summary>
    ///   <para>rdfs:label : has feature</para>
    ///   <para>rdfs:comment : has feature is a relation between a thing and an internal, contextual, or externally attributed characteristic.</para>
    ///   <a href="https://w3id.org/sulo/hasFeature">sulo:hasFeature</a>
    /// </summary>
    let hasFeature = _prefixId.prefix "hasFeature"
    /// <summary>
    ///   <para>rdfs:label : has item</para>
    ///   <para>rdfs:comment : has item is a relation between a collection and an item contained therein.</para>
    ///   <a href="https://w3id.org/sulo/hasMember">sulo:hasMember</a>
    /// </summary>
    let hasMember = _prefixId.prefix "hasMember"
    /// <summary>
    ///   <para>rdfs:label : has part</para>
    ///   <para>rdfs:comment : has part is a transitive, reflexive and antisymmetric relation between a whole and itself or a whole and its part.^^xsd:string</para>
    ///   <a href="https://w3id.org/sulo/hasPart">sulo:hasPart</a>
    /// </summary>
    let hasPart = _prefixId.prefix "hasPart"
    /// <summary>
    ///   <para>rdfs:label : has participant</para>
    ///   <para>rdfs:comment : has participant is a relation that describes the participation of a (non-process) thing in a process.</para>
    ///   <a href="https://w3id.org/sulo/hasParticipant">sulo:hasParticipant</a>
    /// </summary>
    let hasParticipant = _prefixId.prefix "hasParticipant"
    /// <summary>
    ///   <para>rdfs:label : has value</para>
    ///   <para>rdfs:comment : has value is the (only) data type attribute to store the values of information objects.</para>
    ///   <a href="https://w3id.org/sulo/hasValue">sulo:hasValue</a>
    /// </summary>
    let hasValue = _prefixId.prefix "hasValue"
    /// <summary>
    ///   <para>rdfs:label : is direct part of</para>
    ///   <para>rdfs:comment : is direct part is a non-transitive parthood relation that can be used to specify cardinality constraints between a part and its whole.</para>
    ///   <a href="https://w3id.org/sulo/isDirectPartOf">sulo:isDirectPartOf</a>
    /// </summary>
    let isDirectPartOf = _prefixId.prefix "isDirectPartOf"
    /// <summary>
    ///   <para>rdfs:label : is feature of</para>
    ///   <para>rdfs:comment : is feature of is a relation between an internal, contextual, or externally attributed characteristic and some Thing.</para>
    ///   <a href="https://w3id.org/sulo/isFeatureOf">sulo:isFeatureOf</a>
    /// </summary>
    let isFeatureOf = _prefixId.prefix "isFeatureOf"
    /// <summary>
    ///   <para>rdfs:label : is item in</para>
    ///   <para>rdfs:comment : has item is a relation between an item and the collection in which it contained.</para>
    ///   <a href="https://w3id.org/sulo/isItemIn">sulo:isItemIn</a>
    /// </summary>
    let isItemIn = _prefixId.prefix "isItemIn"
    /// <summary>
    ///   <para>dcterms:alternative : has location</para>
    ///   <para>rdfs:label : is located in</para>
    ///   <para>rdfs:comment : A is located in B iff the spatialtemporal region occupied by B is the spatialtemporal region occupied by A.</para>
    ///   <a href="https://w3id.org/sulo/isLocatedIn">sulo:isLocatedIn</a>
    /// </summary>
    let isLocatedIn = _prefixId.prefix "isLocatedIn"
    /// <summary>
    ///   <para>rdfs:label : is location of</para>
    ///   <para>rdfs:comment : A is location of B iff the spatialtemporal region occupied by A is the spatialtemporal region occupied by B.</para>
    ///   <a href="https://w3id.org/sulo/isLocationOf">sulo:isLocationOf</a>
    /// </summary>
    let isLocationOf = _prefixId.prefix "isLocationOf"
    /// <summary>
    ///   <para>rdfs:label : is part of</para>
    ///   <para>rdfs:comment : is part of is a transitive, reflexive and antisymmetric relation between a part and itself or a part and a whole.</para>
    ///   <a href="https://w3id.org/sulo/isPartOf">sulo:isPartOf</a>
    /// </summary>
    let isPartOf = _prefixId.prefix "isPartOf"
    /// <summary>
    ///   <para>rdfs:label : is participant in</para>
    ///   <para>rdfs:comment : is participant in is a relation to relate an object and the process in which it participates.</para>
    ///   <a href="https://w3id.org/sulo/isParticipantIn">sulo:isParticipantIn</a>
    /// </summary>
    let isParticipantIn = _prefixId.prefix "isParticipantIn"
    /// <summary>
    ///   <para>rdfs:label : is preceded by</para>
    ///   <para>rdfs:comment : A relation in which one process occurs after to another process.</para>
    ///   <a href="https://w3id.org/sulo/isPrecededBy">sulo:isPrecededBy</a>
    /// </summary>
    let isPrecededBy = _prefixId.prefix "isPrecededBy"
    /// <summary>
    ///   <para>rdfs:label : is referred in</para>
    ///   <para>rdfs:comment : is referred in is relation between an object that is the subject of an information object.</para>
    ///   <a href="https://w3id.org/sulo/isReferredIn">sulo:isReferredIn</a>
    /// </summary>
    let isReferredIn = _prefixId.prefix "isReferredIn"
    /// <summary>
    ///   <para>rdfs:label : is time of^^xsd:string</para>
    ///   <para>rdfs:comment : a relation between a time and an object that occurs within it.</para>
    ///   <a href="https://w3id.org/sulo/isTimeOf">sulo:isTimeOf</a>
    /// </summary>
    let isTimeOf = _prefixId.prefix "isTimeOf"
    /// <summary>
    ///   <para>rdfs:label : precedes^^xsd:string</para>
    ///   <para>rdfs:comment : A relation in which one process occurs prior to another process.</para>
    ///   <a href="https://w3id.org/sulo/precedes">sulo:precedes</a>
    /// </summary>
    let precedes = _prefixId.prefix "precedes"
    /// <summary>
    ///   <para>rdfs:label : refers to</para>
    ///   <para>rdfs:comment : refers to is a binary relation between an information object and any other object that it mentions, describes, represents, encodes, or otherwise provides information about.</para>
    ///   <a href="https://w3id.org/sulo/refersTo">sulo:refersTo</a>
    /// </summary>
    let refersTo = _prefixId.prefix "refersTo"
    let ``sulo_0.2.0.ttl`` = _prefixId.prefix "sulo-0.2.0.ttl"
    let ``sulo.ttl`` = _prefixId.prefix "sulo.ttl"

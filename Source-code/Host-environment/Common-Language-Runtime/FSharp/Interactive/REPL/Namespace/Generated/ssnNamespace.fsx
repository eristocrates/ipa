#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ssn =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/ssn/" "ssn"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>skos:example : For example, a temperature Sensor deployed on a wall, or a whole network of Sensors deployed for an Observation campaign.</para>
    ///   <para>skos:definition : Describes the Deployment of one or more Systems for a particular purpose. Deployment may be done on a Platform.</para>
    ///   <para>rdfs:label : Deployment</para>
    ///   <para>rdfs:comment : Describes the Deployment of one or more Systems for a particular purpose. Deployment may be done on a Platform.</para>
    ///   <a href="http://www.w3.org/ns/ssn/Deployment">ssn:Deployment</a>
    /// </summary>
    let Deployment = _prefixId.prefix "Deployment"
    /// <summary>
    ///   <para>skos:definition : Any information that is provided to a Procedure for its use.</para>
    ///   <para>rdfs:label : Input</para>
    ///   <para>rdfs:comment : Any information that is provided to a Procedure for its use.</para>
    ///   <a href="http://www.w3.org/ns/ssn/Input">ssn:Input</a>
    /// </summary>
    let Input = _prefixId.prefix "Input"
    /// <summary>
    ///   <para>skos:definition : Any information that is reported from a Procedure.</para>
    ///   <para>rdfs:label : Output</para>
    ///   <para>rdfs:comment : Any information that is reported from a Procedure.</para>
    ///   <a href="http://www.w3.org/ns/ssn/Output">ssn:Output</a>
    /// </summary>
    let Output = _prefixId.prefix "Output"
    /// <summary>
    ///   <para>skos:definition : A quality of an entity. An aspect of an entity that is intrinsic to and cannot exist without the entity.</para>
    ///   <para>rdfs:label : Property</para>
    ///   <para>rdfs:comment : A quality of an entity. An aspect of an entity that is intrinsic to and cannot exist without the entity.</para>
    ///   <a href="http://www.w3.org/ns/ssn/Property">ssn:Property</a>
    /// </summary>
    let Property = _prefixId.prefix "Property"
    /// <summary>
    ///   <para>skos:definition : An event in the real world that 'triggers' the Sensor. The properties associated to the Stimulus may be different to the eventual observed ObservableProperty. It is the event, not the object, that triggers the Sensor.</para>
    ///   <para>rdfs:label : Stimulus</para>
    ///   <para>rdfs:comment : An event in the real world that 'triggers' the Sensor. The properties associated to the Stimulus may be different to the eventual observed ObservableProperty. It is the event, not the object, that triggers the Sensor.</para>
    ///   <a href="http://www.w3.org/ns/ssn/Stimulus">ssn:Stimulus</a>
    /// </summary>
    let Stimulus = _prefixId.prefix "Stimulus"
    /// <summary>
    ///   <para>rdfs:comment : System is a unit of abstraction for pieces of infrastructure that implements Procedures. A System may have components, its subsystems, which are other systems.</para>
    ///   <para>skos:definition : System is a unit of abstraction for pieces of infrastructure that implement Procedures. A System may have components, its subsystems, which are other systems.</para>
    ///   <para>rdfs:label : System</para>
    ///   <a href="http://www.w3.org/ns/ssn/System">ssn:System</a>
    /// </summary>
    let System = _prefixId.prefix "System"
    /// <summary>
    ///   <para>skos:definition : Relation between a Deployment and the Platform on which the Systems are deployed.</para>
    ///   <para>rdfs:label : deployed on platform</para>
    ///   <para>rdfs:comment : Relation between a Deployment and the Platform on which the Systems are deployed.</para>
    ///   <a href="http://www.w3.org/ns/ssn/deployedOnPlatform">ssn:deployedOnPlatform</a>
    /// </summary>
    let deployedOnPlatform = _prefixId.prefix "deployedOnPlatform"
    /// <summary>
    ///   <para>skos:definition : Relation between a Deployment and a deployed System.</para>
    ///   <para>rdfs:label : deployed system</para>
    ///   <para>rdfs:comment : Relation between a Deployment and a deployed System.</para>
    ///   <a href="http://www.w3.org/ns/ssn/deployedSystem">ssn:deployedSystem</a>
    /// </summary>
    let deployedSystem = _prefixId.prefix "deployedSystem"
    /// <summary>
    ///   <para>skos:definition : A relation from a Sensor to the Stimulus that the Sensor detects. The Stimulus itself will be serving as a proxy for some ObservableProperty.</para>
    ///   <para>rdfs:label : detects</para>
    ///   <para>rdfs:comment : A relation from a Sensor to the Stimulus that the Sensor can detect. The Stimulus itself will be serving as a proxy for some ObservableProperty.</para>
    ///   <a href="http://www.w3.org/ns/ssn/detects">ssn:detects</a>
    /// </summary>
    let detects = _prefixId.prefix "detects"
    /// <summary>
    ///   <para>skos:example : For example, from a Sensor to the properties it can observe; from an Actuator to the properties it can act on; from a Deployment to the properties it was installed to observe or act on; from a SystemCapability to the Property the capability is described for.</para>
    ///   <para>skos:definition : A relation between some aspect of an entity and a Property.</para>
    ///   <para>rdfs:label : for property</para>
    ///   <para>rdfs:comment : A relation between some aspect of an entity and a Property.</para>
    ///   <a href="http://www.w3.org/ns/ssn/forProperty">ssn:forProperty</a>
    /// </summary>
    let forProperty = _prefixId.prefix "forProperty"
    /// <summary>
    ///   <para>skos:definition : Relation between a System and a Deployment, recording that the System is deployed in that Deployment.</para>
    ///   <para>rdfs:label : has deployment</para>
    ///   <para>rdfs:comment : Relation between a System and a Deployment, recording that the System is deployed in that Deployment.</para>
    ///   <a href="http://www.w3.org/ns/ssn/hasDeployment">ssn:hasDeployment</a>
    /// </summary>
    let hasDeployment = _prefixId.prefix "hasDeployment"
    /// <summary>
    ///   <para>skos:definition : Relation between a Procedure and an Input to it.</para>
    ///   <para>rdfs:label : has input</para>
    ///   <para>rdfs:comment : Relation between a Procedure and an Input to it.</para>
    ///   <a href="http://www.w3.org/ns/ssn/hasInput">ssn:hasInput</a>
    /// </summary>
    let hasInput = _prefixId.prefix "hasInput"
    /// <summary>
    ///   <para>skos:definition : Relation between a Procedure and an Output of it.</para>
    ///   <para>rdfs:label : has output</para>
    ///   <para>rdfs:comment : Relation between a Procedure and an Output of it.</para>
    ///   <a href="http://www.w3.org/ns/ssn/hasOutput">ssn:hasOutput</a>
    /// </summary>
    let hasOutput = _prefixId.prefix "hasOutput"
    /// <summary>
    ///   <para>skos:definition : Relation between an entity and a Property of that entity.</para>
    ///   <para>rdfs:label : has property</para>
    ///   <para>rdfs:comment : Relation between an entity and a Property of that entity.</para>
    ///   <a href="http://www.w3.org/ns/ssn/hasProperty">ssn:hasProperty</a>
    /// </summary>
    let hasProperty = _prefixId.prefix "hasProperty"
    /// <summary>
    ///   <para>skos:definition : Relation between a System and its component parts.</para>
    ///   <para>rdfs:label : has subsystem</para>
    ///   <para>rdfs:comment : Relation between a System and its component parts.</para>
    ///   <a href="http://www.w3.org/ns/ssn/hasSubSystem">ssn:hasSubSystem</a>
    /// </summary>
    let hasSubSystem = _prefixId.prefix "hasSubSystem"
    /// <summary>
    ///   <para>skos:example : For example, the relationship between a scientific measuring Procedure and a sensor that senses via that Procedure.</para>
    ///   <para>skos:definition : Relation between a Procedure (an algorithm, procedure or method) and an entity that implements that Procedure in some executable way.</para>
    ///   <para>rdfs:label : implemented by</para>
    ///   <para>rdfs:comment : Relation between a Procedure (an algorithm, procedure or method) and an entity that implements that Procedure in some executable way.</para>
    ///   <a href="http://www.w3.org/ns/ssn/implementedBy">ssn:implementedBy</a>
    /// </summary>
    let implementedBy = _prefixId.prefix "implementedBy"
    /// <summary>
    ///   <para>skos:example : For example, the relationship between a sensor and the scientific measuring Procedure via which it senses.</para>
    ///   <para>skos:definition : Relation between an entity that implements a Procedure in some executable way and the Procedure (an algorithm, procedure or method).</para>
    ///   <para>rdfs:label : implements</para>
    ///   <para>rdfs:comment : Relation between an entity that implements a Procedure in some executable way and the Procedure (an algorithm, procedure or method).</para>
    ///   <a href="http://www.w3.org/ns/ssn/implements">ssn:implements</a>
    /// </summary>
    let implements = _prefixId.prefix "implements"
    /// <summary>
    ///   <para>skos:example : For example, a relation between a buoy and a deployment of several Sensors.</para>
    ///   <para>skos:definition : Relation between a Platform and a Deployment, meaning that the deployedSystems of the Deployment are hosted on the Platform.</para>
    ///   <para>rdfs:label : in deployment</para>
    ///   <para>rdfs:comment : Relation between a Platform and a Deployment, meaning that the deployedSystems of the Deployment are hosted on the Platform.</para>
    ///   <a href="http://www.w3.org/ns/ssn/inDeployment">ssn:inDeployment</a>
    /// </summary>
    let inDeployment = _prefixId.prefix "inDeployment"
    /// <summary>
    ///   <para>skos:definition : Relation between a Property and the entity it belongs to.</para>
    ///   <para>rdfs:label : is property of</para>
    ///   <para>rdfs:comment : Relation between a Property and the entity it belongs to.</para>
    ///   <a href="http://www.w3.org/ns/ssn/isPropertyOf">ssn:isPropertyOf</a>
    /// </summary>
    let isPropertyOf = _prefixId.prefix "isPropertyOf"
    /// <summary>
    ///   <para>skos:example : For example, the expansion of quicksilver is a stimulus that serves as a proxy for some temperature property. An increase or decrease in the velocity of spinning cups on a wind sensor is serving as a proxy for the wind speed.</para>
    ///   <para>skos:definition : A relation from a Stimulus to the Property that the Stimulus is serving as a proxy for.</para>
    ///   <para>rdfs:label : is proxy for</para>
    ///   <para>rdfs:comment : A relation from a Stimulus to the Property that the Stimulus is serving as a proxy for.</para>
    ///   <a href="http://www.w3.org/ns/ssn/isProxyFor">ssn:isProxyFor</a>
    /// </summary>
    let isProxyFor = _prefixId.prefix "isProxyFor"
    /// <summary>
    ///   <para>skos:definition : Relation between an Observation and the Stimulus that originated it.</para>
    ///   <para>rdfs:label : was originated by</para>
    ///   <para>rdfs:comment : Relation between an Observation and the Stimulus that originated it.</para>
    ///   <a href="http://www.w3.org/ns/ssn/wasOriginatedBy">ssn:wasOriginatedBy</a>
    /// </summary>
    let wasOriginatedBy = _prefixId.prefix "wasOriginatedBy"

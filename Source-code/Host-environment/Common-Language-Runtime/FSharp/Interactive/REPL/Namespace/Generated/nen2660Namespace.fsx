#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module nen2660 =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://w3id.org/nen2660/def#" "nen2660"

    /// <summary>
    ///   <para>skos:prefLabel : Abstract concept</para>
    ///   <para>skos:definition : Concept that forms a manifestation and demarcation in an abstract space. An abstract concept has no life cycle</para>
    ///   <a href="https://w3id.org/nen2660/def#AbstractConcept">nen2660:AbstractConcept</a>
    /// </summary>
    let AbstractConcept = _prefixId.prefix "AbstractConcept"
    /// <summary>
    ///   <para>skos:prefLabel : Activity</para>
    ///   <para>skos:definition : Entity that takes place or can take place in a concrete space-time. An activity transforms objects, and is executed by an object</para>
    ///   <a href="https://w3id.org/nen2660/def#Activity">nen2660:Activity</a>
    /// </summary>
    let Activity = _prefixId.prefix "Activity"
    /// <summary>
    ///   <para>skos:prefLabel : Aggregation state type</para>
    ///   <para>skos:definition : One of the four fundamental states of matter being a solid, liquid, gas or plasma</para>
    ///   <a href="https://w3id.org/nen2660/def#AggregationStateType">nen2660:AggregationStateType</a>
    /// </summary>
    let AggregationStateType = _prefixId.prefix "AggregationStateType"
    let AllDisjointClassesShape = _prefixId.prefix "AllDisjointClassesShape"
    let AllDisjointClasses_1 = _prefixId.prefix "AllDisjointClasses_1"
    let AllDisjointClasses_2 = _prefixId.prefix "AllDisjointClasses_2"
    let AllDisjointClasses_3 = _prefixId.prefix "AllDisjointClasses_3"
    let AllDisjointClasses_4 = _prefixId.prefix "AllDisjointClasses_4"
    /// <summary>
    ///   <para>skos:prefLabel : Amount of bulk matter</para>
    ///   <para>skos:definition : A real object that consists of a continuous amount of non-rigid matter, held together primarily by external forces (gravity or confinement)</para>
    ///   <a href="https://w3id.org/nen2660/def#AmountOfBulkMatter">nen2660:AmountOfBulkMatter</a>
    /// </summary>
    let AmountOfBulkMatter = _prefixId.prefix "AmountOfBulkMatter"
    /// <summary>
    ///   <para>skos:prefLabel : Chemical compound</para>
    ///   <para>skos:definition : Pure substance consisting of two or more chemical elements that have a chemical bond with each other. In a chemical compound, the elements occur in a fixed ratio. A compound can be broken down into simpler substances by means of chemical reactions</para>
    ///   <a href="https://w3id.org/nen2660/def#ChemicalCompound">nen2660:ChemicalCompound</a>
    /// </summary>
    let ChemicalCompound = _prefixId.prefix "ChemicalCompound"
    /// <summary>
    ///   <para>skos:prefLabel : Chemical element</para>
    ///   <para>skos:definition : Pure substance that is made up of atoms with the same atomic number. A chemical element cannot be decomposed through chemical reactions</para>
    ///   <a href="https://w3id.org/nen2660/def#ChemicalElement">nen2660:ChemicalElement</a>
    /// </summary>
    let ChemicalElement = _prefixId.prefix "ChemicalElement"
    /// <summary>
    ///   <para>skos:prefLabel : Concept type</para>
    ///   <para>skos:definition : A meta-concept having concepts as instances that can have attributes or relations</para>
    ///   <a href="https://w3id.org/nen2660/def#ConceptType">nen2660:ConceptType</a>
    /// </summary>
    let ConceptType = _prefixId.prefix "ConceptType"
    /// <summary>
    ///   <para>skos:definition : Concept that forms a manifestation and a demarcation in a concrete space-time. A concrete concept has a life cycle</para>
    ///   <para>skos:prefLabel : Concrete concept</para>
    ///   <a href="https://w3id.org/nen2660/def#ConcreteConcept">nen2660:ConcreteConcept</a>
    /// </summary>
    let ConcreteConcept = _prefixId.prefix "ConcreteConcept"
    /// <summary>
    ///   <para>skos:prefLabel : Connection</para>
    ///   <para>skos:definition : A physical object (real object or spatial area) that connects two other physical objects and over which interaction takes place, namely the transfer of matter, energy, information or forces</para>
    ///   <a href="https://w3id.org/nen2660/def#Connection">nen2660:Connection</a>
    /// </summary>
    let Connection = _prefixId.prefix "Connection"
    /// <summary>
    ///   <para>skos:prefLabel : Discrete object</para>
    ///   <para>skos:definition : A real object consisting of a contiguous amount of form-retaining matter, held together primarily by internal forces (gravity or electromagnetic force)</para>
    ///   <a href="https://w3id.org/nen2660/def#DiscreteObject">nen2660:DiscreteObject</a>
    /// </summary>
    let DiscreteObject = _prefixId.prefix "DiscreteObject"
    let EnergyFlow = _prefixId.prefix "EnergyFlow"
    /// <summary>
    ///   <para>skos:prefLabel : Entity</para>
    ///   <para>skos:definition : Concept that forms a manifestation and a demarcation in a concrete space-time, and which has a certain state at any moment in time. An entity has a unique identity that remains constant throughout its life cycle. The life cycle of an entity is made up of the sequence of states of that entity, which follow each other in time. An entity is an object or an activity. An object exists, an activity takes place</para>
    ///   <a href="https://w3id.org/nen2660/def#Entity">nen2660:Entity</a>
    /// </summary>
    let Entity = _prefixId.prefix "Entity"
    /// <summary>
    ///   <para>skos:prefLabel : Enumeration type</para>
    ///   <para>skos:definition : A meta-concept having concepts as instances having no further attributes or relations (annotations only)</para>
    ///   <a href="https://w3id.org/nen2660/def#EnumerationType">nen2660:EnumerationType</a>
    /// </summary>
    let EnumerationType = _prefixId.prefix "EnumerationType"
    /// <summary>
    ///   <para>skos:definition : Transition between two successive states of an entity (object or activity). An event is triggered in a state</para>
    ///   <para>skos:prefLabel : Event</para>
    ///   <a href="https://w3id.org/nen2660/def#Event">nen2660:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    let Force = _prefixId.prefix "Force"
    /// <summary>
    ///   <para>skos:definition : An entity involving the external behavior where the output contributes to stakeholder objectives implemented/played by one or more technical entities</para>
    ///   <para>skos:prefLabel : Functional entity</para>
    ///   <a href="https://w3id.org/nen2660/def#FunctionalEntity">nen2660:FunctionalEntity</a>
    /// </summary>
    let FunctionalEntity = _prefixId.prefix "FunctionalEntity"
    let Gas = _prefixId.prefix "Gas"
    /// <summary>
    ///   <para>skos:prefLabel : Geometric entity</para>
    ///   <para>skos:definition : Named concept, which forms an actual or virtual demarcation in a concrete (physical, three-dimensional) space, which we experience in reality</para>
    ///   <a href="https://w3id.org/nen2660/def#GeometricEntity">nen2660:GeometricEntity</a>
    /// </summary>
    let GeometricEntity = _prefixId.prefix "GeometricEntity"
    /// <summary>
    ///   <para>skos:prefLabel : Heterogeneous mixture</para>
    ///   <para>skos:definition : A mixture that is separated into different regions or phases that have different compositions or properties</para>
    ///   <a href="https://w3id.org/nen2660/def#HeterogeneousMixture">nen2660:HeterogeneousMixture</a>
    /// </summary>
    let HeterogeneousMixture = _prefixId.prefix "HeterogeneousMixture"
    /// <summary>
    ///   <para>skos:prefLabel : Homogeneous mixture</para>
    ///   <para>skos:definition : A mixture that is uniform throughout, and has only one phase</para>
    ///   <a href="https://w3id.org/nen2660/def#HomogeneousMixture">nen2660:HomogeneousMixture</a>
    /// </summary>
    let HomogeneousMixture = _prefixId.prefix "HomogeneousMixture"
    let InformationFlow = _prefixId.prefix "InformationFlow"
    /// <summary>
    ///   <para>skos:prefLabel : Information object</para>
    ///   <para>skos:definition : Object which describes a thing in reality</para>
    ///   <a href="https://w3id.org/nen2660/def#InformationObject">nen2660:InformationObject</a>
    /// </summary>
    let InformationObject = _prefixId.prefix "InformationObject"
    /// <summary>
    ///   <para>skos:prefLabel : Interaction</para>
    ///   <para>skos:definition : The activity being a combination of sub-activities performed by physical objects between which a transfer of matter, information, energy or force takes place, typically over a connection or interface (directly or through ports)</para>
    ///   <a href="https://w3id.org/nen2660/def#Interaction">nen2660:Interaction</a>
    /// </summary>
    let Interaction = _prefixId.prefix "Interaction"
    /// <summary>
    ///   <para>skos:prefLabel : Interface</para>
    ///   <para>skos:definition : A spatial object, typically a thin 2D physical space (but also 0D or 1D) that connects two physical objects or ports of physical objects through which a static or dynamic interaction or interaction between those elements can take place</para>
    ///   <a href="https://w3id.org/nen2660/def#Interface">nen2660:Interface</a>
    /// </summary>
    let Interface = _prefixId.prefix "Interface"
    let Liquid = _prefixId.prefix "Liquid"
    let MaterialFlow = _prefixId.prefix "MaterialFlow"
    /// <summary>
    ///   <para>skos:prefLabel : Matter</para>
    ///   <para>skos:definition : A pure chemical substance, chemical compound or mixture from which real objects are made</para>
    ///   <a href="https://w3id.org/nen2660/def#Matter">nen2660:Matter</a>
    /// </summary>
    let Matter = _prefixId.prefix "Matter"
    /// <summary>
    ///   <para>skos:prefLabel : Matter portion</para>
    ///   <para>skos:definition : An objectified relation reference for the consists of relation</para>
    ///   <a href="https://w3id.org/nen2660/def#MatterPortion">nen2660:MatterPortion</a>
    /// </summary>
    let MatterPortion = _prefixId.prefix "MatterPortion"
    /// <summary>
    ///   <para>skos:prefLabel : Mixture</para>
    ///   <para>skos:definition : The combination of two or more different pure substances without the molecules losing their identity</para>
    ///   <a href="https://w3id.org/nen2660/def#Mixture">nen2660:Mixture</a>
    /// </summary>
    let Mixture = _prefixId.prefix "Mixture"
    /// <summary>
    ///   <para>skos:prefLabel : Object</para>
    ///   <para>skos:definition : Entity that exists or can exist within a concrete space-time. An object executes an activity, and is transformed by an activity</para>
    ///   <a href="https://w3id.org/nen2660/def#Object">nen2660:Object</a>
    /// </summary>
    let Object = _prefixId.prefix "Object"
    /// <summary>
    ///   <para>skos:prefLabel : Objectification</para>
    ///   <para>skos:definition : An attribute (quality or quantity) or relation represented as an individual defined by a concept</para>
    ///   <a href="https://w3id.org/nen2660/def#Objectification">nen2660:Objectification</a>
    /// </summary>
    let Objectification = _prefixId.prefix "Objectification"
    /// <summary>
    ///   <para>skos:definition : Object that exists or may exist within physical 4D space-time. A physical object forms a manifestation and a demarcation of matter and/or energy, and is (in)directly perceptible by the senses</para>
    ///   <para>skos:prefLabel : Physical object</para>
    ///   <a href="https://w3id.org/nen2660/def#PhysicalObject">nen2660:PhysicalObject</a>
    /// </summary>
    let PhysicalObject = _prefixId.prefix "PhysicalObject"
    /// <summary>
    ///   <para>skos:definition : An entity that does not yet exist in physical reality, but which exists in mental or conceptual reality</para>
    ///   <para>skos:prefLabel : Planned entity</para>
    ///   <a href="https://w3id.org/nen2660/def#PlannedEntity">nen2660:PlannedEntity</a>
    /// </summary>
    let PlannedEntity = _prefixId.prefix "PlannedEntity"
    let Plasma = _prefixId.prefix "Plasma"
    /// <summary>
    ///   <para>skos:prefLabel : Port</para>
    ///   <para>skos:definition : A physical or logical point of interaction as part of a physical object where, through a connection or interface, an interaction can take place</para>
    ///   <a href="https://w3id.org/nen2660/def#Port">nen2660:Port</a>
    /// </summary>
    let Port = _prefixId.prefix "Port"
    /// <summary>
    ///   <para>skos:prefLabel : Pure substance</para>
    ///   <para>skos:definition : Chemical matter that has an equal chemical composition and recognizable uniform and isotropic properties</para>
    ///   <a href="https://w3id.org/nen2660/def#PureSubstance">nen2660:PureSubstance</a>
    /// </summary>
    let PureSubstance = _prefixId.prefix "PureSubstance"
    /// <summary>
    ///   <para>skos:prefLabel : Quality value</para>
    ///   <para>skos:definition : The objectification of a value of a quality having a complex value like a simple value sec combined with other metadata or just a combination of simple values</para>
    ///   <a href="https://w3id.org/nen2660/def#QualityValue">nen2660:QualityValue</a>
    /// </summary>
    let QualityValue = _prefixId.prefix "QualityValue"
    /// <summary>
    ///   <para>skos:prefLabel : Quantity value</para>
    ///   <para>skos:definition : The objectification of a value of a quantity (typically involving a quantity kind and a unit) having a complex value like a simple value sec combined with other metadata or just a combination of simple values</para>
    ///   <a href="https://w3id.org/nen2660/def#QuantityValue">nen2660:QuantityValue</a>
    /// </summary>
    let QuantityValue = _prefixId.prefix "QuantityValue"
    /// <summary>
    ///   <para>skos:definition : physical object (rigid or non-rigid) that is (or can be) tangible and visible in reality, man-made or naturally occurring</para>
    ///   <para>skos:prefLabel : Real object</para>
    ///   <a href="https://w3id.org/nen2660/def#RealObject">nen2660:RealObject</a>
    /// </summary>
    let RealObject = _prefixId.prefix "RealObject"
    /// <summary>
    ///   <para>skos:prefLabel : Realized entity</para>
    ///   <para>skos:definition : An entity that exists or has existed in the physical reality</para>
    ///   <a href="https://w3id.org/nen2660/def#RealizedEntity">nen2660:RealizedEntity</a>
    /// </summary>
    let RealizedEntity = _prefixId.prefix "RealizedEntity"
    /// <summary>
    ///   <para>skos:prefLabel : Relation reference</para>
    ///   <para>skos:definition : The objectification of a reference for a relation having a complex value like a simple reference sec combined with other metadata or just a combination of simple references (n-ary relation)</para>
    ///   <a href="https://w3id.org/nen2660/def#RelationReference">nen2660:RelationReference</a>
    /// </summary>
    let RelationReference = _prefixId.prefix "RelationReference"
    /// <summary>
    ///   <para>skos:prefLabel : Representation</para>
    ///   <para>skos:definition : That which represents something else</para>
    ///   <a href="https://w3id.org/nen2660/def#Representation">nen2660:Representation</a>
    /// </summary>
    let Representation = _prefixId.prefix "Representation"
    /// <summary>
    ///   <para>skos:definition : A rule that should hold for something, defined via its attributes or relations^^xsd:string</para>
    ///   <para>skos:prefLabel : Requirement</para>
    ///   <a href="https://w3id.org/nen2660/def#Requirement">nen2660:Requirement</a>
    /// </summary>
    let Requirement = _prefixId.prefix "Requirement"
    /// <summary>
    ///   <para>skos:prefLabel : Requirement severity type</para>
    ///   <para>skos:definition : The seriousness of a requirement like demanded or wished</para>
    ///   <a href="https://w3id.org/nen2660/def#RequirementSeverityType">nen2660:RequirementSeverityType</a>
    /// </summary>
    let RequirementSeverityType = _prefixId.prefix "RequirementSeverityType"
    /// <summary>
    ///   <para>skos:prefLabel : Requirement source type</para>
    ///   <para>skos:definition : The type of source from which a requirement comes like a client, by definition, recommended by the sector or demanded by law/regulation</para>
    ///   <a href="https://w3id.org/nen2660/def#RequirementSourceType">nen2660:RequirementSourceType</a>
    /// </summary>
    let RequirementSourceType = _prefixId.prefix "RequirementSourceType"
    /// <summary>
    ///   <para>skos:prefLabel : Requirement topic type</para>
    ///   <para>skos:definition : The entity aspect a requirement applies to</para>
    ///   <a href="https://w3id.org/nen2660/def#RequirementTopicType">nen2660:RequirementTopicType</a>
    /// </summary>
    let RequirementTopicType = _prefixId.prefix "RequirementTopicType"
    let Solid = _prefixId.prefix "Solid"
    /// <summary>
    ///   <para>skos:prefLabel : Spatial region</para>
    ///   <para>skos:definition : A physical object that encloses a particular area such as a room, roadway and river, that is bounded by real objects or other spatial areas (e.g., by usage or convention) and that contains primarily liquid or gaseous amount of matter</para>
    ///   <a href="https://w3id.org/nen2660/def#SpatialRegion">nen2660:SpatialRegion</a>
    /// </summary>
    let SpatialRegion = _prefixId.prefix "SpatialRegion"
    /// <summary>
    ///   <para>skos:prefLabel : State</para>
    ///   <para>skos:definition : Temporal part of an entity during a period between two events. A state is characterized by the properties and relations of the entity</para>
    ///   <a href="https://w3id.org/nen2660/def#State">nen2660:State</a>
    /// </summary>
    let State = _prefixId.prefix "State"
    /// <summary>
    ///   <para>skos:prefLabel : Technical entity</para>
    ///   <para>skos:definition : An entity concerned with technical properties and relations that implements or plays functional entities</para>
    ///   <a href="https://w3id.org/nen2660/def#TechnicalEntity">nen2660:TechnicalEntity</a>
    /// </summary>
    let TechnicalEntity = _prefixId.prefix "TechnicalEntity"
    /// <summary>
    ///   <para>skos:prefLabel : Top concept</para>
    ///   <para>skos:definition : The most generic concept</para>
    ///   <a href="https://w3id.org/nen2660/def#TopConcept">nen2660:TopConcept</a>
    /// </summary>
    let TopConcept = _prefixId.prefix "TopConcept"
    /// <summary>
    ///   <para>skos:prefLabel : Transfer type</para>
    ///   <para>skos:definition : The type of thing being transferred, here: material, information, energy or force</para>
    ///   <a href="https://w3id.org/nen2660/def#TransferType">nen2660:TransferType</a>
    /// </summary>
    let TransferType = _prefixId.prefix "TransferType"
    /// <summary>
    ///   <para>skos:prefLabel : Type</para>
    ///   <para>skos:definition : A meta-concept which instances are concepts (not individuals)</para>
    ///   <a href="https://w3id.org/nen2660/def#Type">nen2660:Type</a>
    /// </summary>
    let Type = _prefixId.prefix "Type"
    /// <summary>
    ///   <para>skos:prefLabel : abbreviation</para>
    ///   <para>skos:definition : Acronym or initial word as special case of an external name</para>
    ///   <a href="https://w3id.org/nen2660/def#abbreviation">nen2660:abbreviation</a>
    /// </summary>
    let abbreviation = _prefixId.prefix "abbreviation"
    /// <summary>
    ///   <para>skos:prefLabel : aggregation state type</para>
    ///   <para>skos:definition : The possession of an aggregation state type</para>
    ///   <a href="https://w3id.org/nen2660/def#aggregationStateType">nen2660:aggregationStateType</a>
    /// </summary>
    let aggregationStateType = _prefixId.prefix "aggregationStateType"
    /// <summary>
    ///   <para>skos:prefLabel : begins</para>
    ///   <para>skos:definition : The state that is started by an event</para>
    ///   <a href="https://w3id.org/nen2660/def#begins">nen2660:begins</a>
    /// </summary>
    let begins = _prefixId.prefix "begins"
    /// <summary>
    ///   <para>skos:prefLabel : chemical formula</para>
    ///   <para>skos:definition : The possession of information about the chemical proportions of atoms that constitute a particular chemical compound</para>
    ///   <a href="https://w3id.org/nen2660/def#chemicalFormula">nen2660:chemicalFormula</a>
    /// </summary>
    let chemicalFormula = _prefixId.prefix "chemicalFormula"
    /// <summary>
    ///   <para>skos:prefLabel : connects object</para>
    ///   <para>skos:definition : The physical objects connected by a connection or interface</para>
    ///   <a href="https://w3id.org/nen2660/def#connectsObject">nen2660:connectsObject</a>
    /// </summary>
    let connectsObject = _prefixId.prefix "connectsObject"
    /// <summary>
    ///   <para>skos:prefLabel : connects port</para>
    ///   <para>skos:definition : The ports (as part of physical objects) connected by a connection or interface</para>
    ///   <a href="https://w3id.org/nen2660/def#connectsPort">nen2660:connectsPort</a>
    /// </summary>
    let connectsPort = _prefixId.prefix "connectsPort"
    /// <summary>
    ///   <para>skos:prefLabel : consists of</para>
    ///   <para>skos:definition : The matter a real object or mixture is made of</para>
    ///   <a href="https://w3id.org/nen2660/def#consistsOf">nen2660:consistsOf</a>
    /// </summary>
    let consistsOf = _prefixId.prefix "consistsOf"
    /// <summary>
    ///   <para>skos:prefLabel : contains</para>
    ///   <para>skos:definition : The real objects located in a spatial region, typically the gaseous amount of bulk matter present in that region</para>
    ///   <a href="https://w3id.org/nen2660/def#contains">nen2660:contains</a>
    /// </summary>
    let contains = _prefixId.prefix "contains"
    /// <summary>
    ///   <para>skos:prefLabel : ends</para>
    ///   <para>skos:definition : The state that is ended by an event</para>
    ///   <a href="https://w3id.org/nen2660/def#ends">nen2660:ends</a>
    /// </summary>
    let ends = _prefixId.prefix "ends"
    /// <summary>
    ///   <para>skos:prefLabel : executes</para>
    ///   <para>skos:definition : The activity executed by a physical object</para>
    ///   <a href="https://w3id.org/nen2660/def#executes">nen2660:executes</a>
    /// </summary>
    let executes = _prefixId.prefix "executes"
    /// <summary>
    ///   <para>skos:prefLabel : has boundary</para>
    ///   <para>skos:definition : The geometric entity representing the boundary of a concrete concept</para>
    ///   <a href="https://w3id.org/nen2660/def#hasBoundary">nen2660:hasBoundary</a>
    /// </summary>
    let hasBoundary = _prefixId.prefix "hasBoundary"
    /// <summary>
    ///   <para>skos:prefLabel : has functional part</para>
    ///   <para>skos:definition : The hasPart relation of a functional nature</para>
    ///   <a href="https://w3id.org/nen2660/def#hasFunctionalPart">nen2660:hasFunctionalPart</a>
    /// </summary>
    let hasFunctionalPart = _prefixId.prefix "hasFunctionalPart"
    /// <summary>
    ///   <para>skos:prefLabel : has interior</para>
    ///   <para>skos:definition : The geometric entity representing the interior of a concrete concept</para>
    ///   <a href="https://w3id.org/nen2660/def#hasInterior">nen2660:hasInterior</a>
    /// </summary>
    let hasInterior = _prefixId.prefix "hasInterior"
    /// <summary>
    ///   <para>skos:prefLabel : has part</para>
    ///   <para>skos:definition : A decomposition (hasPart) relation between concrete concepts</para>
    ///   <a href="https://w3id.org/nen2660/def#hasPart">nen2660:hasPart</a>
    /// </summary>
    let hasPart = _prefixId.prefix "hasPart"
    /// <summary>
    ///   <para>skos:prefLabel : has parts group</para>
    ///   <para>skos:definition : The possession of an group of, potentially implicit, parts</para>
    ///   <a href="https://w3id.org/nen2660/def#hasPartsGroup">nen2660:hasPartsGroup</a>
    /// </summary>
    let hasPartsGroup = _prefixId.prefix "hasPartsGroup"
    let hasPeriod = _prefixId.prefix "hasPeriod"
    /// <summary>
    ///   <para>skos:prefLabel : has quantity kind</para>
    ///   <para>skos:definition : The possession of a quantity kind</para>
    ///   <a href="https://w3id.org/nen2660/def#hasQuantityKind">nen2660:hasQuantityKind</a>
    /// </summary>
    let hasQuantityKind = _prefixId.prefix "hasQuantityKind"
    let hasQuantityKindShape = _prefixId.prefix "hasQuantityKindShape"
    /// <summary>
    ///   <para>skos:prefLabel : has requirement</para>
    ///   <para>skos:definition : The (unstructured) requirement for something</para>
    ///   <a href="https://w3id.org/nen2660/def#hasRequirement">nen2660:hasRequirement</a>
    /// </summary>
    let hasRequirement = _prefixId.prefix "hasRequirement"
    /// <summary>
    ///   <para>skos:prefLabel : has solution</para>
    ///   <para>skos:definition : A technical entity that is a potential solution for a functional entity</para>
    ///   <a href="https://w3id.org/nen2660/def#hasSolution">nen2660:hasSolution</a>
    /// </summary>
    let hasSolution = _prefixId.prefix "hasSolution"
    /// <summary>
    ///   <para>skos:prefLabel : has state</para>
    ///   <para>skos:definition : The state of an entity in a certain point or period of time</para>
    ///   <a href="https://w3id.org/nen2660/def#hasState">nen2660:hasState</a>
    /// </summary>
    let hasState = _prefixId.prefix "hasState"
    /// <summary>
    ///   <para>skos:prefLabel : has technical part</para>
    ///   <para>skos:definition : A hasPart relation of a technical nature</para>
    ///   <a href="https://w3id.org/nen2660/def#hasTechnicalPart">nen2660:hasTechnicalPart</a>
    /// </summary>
    let hasTechnicalPart = _prefixId.prefix "hasTechnicalPart"
    /// <summary>
    ///   <para>skos:prefLabel : has temporal entity</para>
    ///   <para>skos:definition : The abstract temporal entity representing a concrete concept in time</para>
    ///   <a href="https://w3id.org/nen2660/def#hasTemporalEntity">nen2660:hasTemporalEntity</a>
    /// </summary>
    let hasTemporalEntity = _prefixId.prefix "hasTemporalEntity"
    /// <summary>
    ///   <para>skos:prefLabel : has unit</para>
    ///   <para>skos:definition : The possession of a unit</para>
    ///   <a href="https://w3id.org/nen2660/def#hasUnit">nen2660:hasUnit</a>
    /// </summary>
    let hasUnit = _prefixId.prefix "hasUnit"
    let hasUnitShape = _prefixId.prefix "hasUnitShape"
    /// <summary>
    ///   <para>skos:prefLabel : is bound by</para>
    ///   <para>skos:definition : The physical object that bounds a spatial region</para>
    ///   <a href="https://w3id.org/nen2660/def#isBoundBy">nen2660:isBoundBy</a>
    /// </summary>
    let isBoundBy = _prefixId.prefix "isBoundBy"
    /// <summary>
    ///   <para>skos:prefLabel : is connected to</para>
    ///   <para>skos:definition : The topological relationship between physical objects</para>
    ///   <a href="https://w3id.org/nen2660/def#isConnectedTo">nen2660:isConnectedTo</a>
    /// </summary>
    let isConnectedTo = _prefixId.prefix "isConnectedTo"
    /// <summary>
    ///   <para>skos:prefLabel : is described by</para>
    ///   <para>skos:definition : The information object that describes something</para>
    ///   <a href="https://w3id.org/nen2660/def#isDescribedBy">nen2660:isDescribedBy</a>
    /// </summary>
    let isDescribedBy = _prefixId.prefix "isDescribedBy"
    /// <summary>
    ///   <para>skos:prefLabel : is implemented by</para>
    ///   <para>skos:definition : The technical entity that implements a functional entity</para>
    ///   <a href="https://w3id.org/nen2660/def#isImplementedBy">nen2660:isImplementedBy</a>
    /// </summary>
    let isImplementedBy = _prefixId.prefix "isImplementedBy"
    /// <summary>
    ///   <para>skos:prefLabel : is plan for</para>
    ///   <para>skos:definition : A potentially realized entity according to this planned entity</para>
    ///   <a href="https://w3id.org/nen2660/def#isPlanFor">nen2660:isPlanFor</a>
    /// </summary>
    let isPlanFor = _prefixId.prefix "isPlanFor"
    /// <summary>
    ///   <para>skos:prefLabel : is realized by</para>
    ///   <para>skos:definition : The realized entity that realizes a planned entity</para>
    ///   <a href="https://w3id.org/nen2660/def#isRealizedBy">nen2660:isRealizedBy</a>
    /// </summary>
    let isRealizedBy = _prefixId.prefix "isRealizedBy"
    /// <summary>
    ///   <para>skos:prefLabel : over connection</para>
    ///   <para>skos:definition : The connection over which an interaction between physical objects takes place</para>
    ///   <a href="https://w3id.org/nen2660/def#overConnection">nen2660:overConnection</a>
    /// </summary>
    let overConnection = _prefixId.prefix "overConnection"
    /// <summary>
    ///   <para>skos:prefLabel : over interface</para>
    ///   <para>skos:definition : The interface over which an interaction between physical objects takes place</para>
    ///   <a href="https://w3id.org/nen2660/def#overInterface">nen2660:overInterface</a>
    /// </summary>
    let overInterface = _prefixId.prefix "overInterface"
    /// <summary>
    ///   <para>skos:prefLabel : participates in</para>
    ///   <para>skos:definition : The interaction a physical object participates in</para>
    ///   <a href="https://w3id.org/nen2660/def#participatesIn">nen2660:participatesIn</a>
    /// </summary>
    let participatesIn = _prefixId.prefix "participatesIn"
    /// <summary>
    ///   <para>skos:prefLabel : portion</para>
    ///   <para>skos:definition : The relative portion of a matter portion</para>
    ///   <a href="https://w3id.org/nen2660/def#portion">nen2660:portion</a>
    /// </summary>
    let portion = _prefixId.prefix "portion"
    /// <summary>
    ///   <para>skos:prefLabel : requirement severity type</para>
    ///   <para>skos:definition : The possession of a severity type by a requirement</para>
    ///   <a href="https://w3id.org/nen2660/def#requirementSeverityType">nen2660:requirementSeverityType</a>
    /// </summary>
    let requirementSeverityType = _prefixId.prefix "requirementSeverityType"
    /// <summary>
    ///   <para>skos:prefLabel : requirement source type</para>
    ///   <para>skos:definition : The possession of a source type by a requirement</para>
    ///   <a href="https://w3id.org/nen2660/def#requirementSourceType">nen2660:requirementSourceType</a>
    /// </summary>
    let requirementSourceType = _prefixId.prefix "requirementSourceType"
    /// <summary>
    ///   <para>skos:prefLabel : requirement topic type</para>
    ///   <para>skos:definition : The possession of a topic type by a requirement</para>
    ///   <a href="https://w3id.org/nen2660/def#requirementTopicType">nen2660:requirementTopicType</a>
    /// </summary>
    let requirementTopicType = _prefixId.prefix "requirementTopicType"
    /// <summary>
    ///   <para>skos:prefLabel : transfer type</para>
    ///   <para>skos:definition : The possession of a transfer type by an interaction</para>
    ///   <a href="https://w3id.org/nen2660/def#transferType">nen2660:transferType</a>
    /// </summary>
    let transferType = _prefixId.prefix "transferType"
    /// <summary>
    ///   <para>skos:prefLabel : transforms</para>
    ///   <para>skos:definition : The object transformed by an activity</para>
    ///   <a href="https://w3id.org/nen2660/def#transforms">nen2660:transforms</a>
    /// </summary>
    let transforms = _prefixId.prefix "transforms"
    /// <summary>
    ///   <para>skos:prefLabel : triggers</para>
    ///   <para>skos:definition : The event triggert by an entity</para>
    ///   <a href="https://w3id.org/nen2660/def#triggers">nen2660:triggers</a>
    /// </summary>
    let triggers = _prefixId.prefix "triggers"

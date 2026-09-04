#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module glc =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://glaciation-project.eu/MetadataReferenceModel#" "glc"

    /// <summary>
    ///   <para>rdfs:label : AggregatedMeasurement^^xsd:string</para>
    ///   <para>rdfs:comment : Represents any AggregatedMeasurement, by using an AggregatedFunction, a time interval and time step resolution.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#AggregatedMeasurement">glc:AggregatedMeasurement</a>
    /// </summary>
    let AggregatedMeasurement = _prefixId.prefix "AggregatedMeasurement"
    /// <summary>
    ///   <para>rdfs:label : Aspect^^xsd:string</para>
    ///   <para>rdfs:comment : It describes the Aspect of a Contstraint, e.g., time, power consumption.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#Aspect">glc:Aspect</a>
    /// </summary>
    let Aspect = _prefixId.prefix "Aspect"
    /// <summary>
    ///   <para>rdfs:label : AssignedTask^^xsd:string</para>
    ///   <para>rdfs:comment : An AssignedTask that will be performed by using some Resources and will be based on some Constraints.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#AssignedTask">glc:AssignedTask</a>
    /// </summary>
    let AssignedTask = _prefixId.prefix "AssignedTask"
    /// <summary>
    ///   <para>rdfs:label : Class^^xsd:string</para>
    ///   <para>rdfs:comment : A generic Class for the GLACIATION project^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#Class">glc:Class</a>
    /// </summary>
    let Class = _prefixId.prefix "Class"
    /// <summary>
    ///   <para>rdfs:label : Constraint^^xsd:string</para>
    ///   <para>rdfs:comment : For representing the Constraint(s) of a Task.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#Constraint">glc:Constraint</a>
    /// </summary>
    let Constraint = _prefixId.prefix "Constraint"
    /// <summary>
    ///   <para>rdfs:label : Electrical Grid^^xsd:string</para>
    ///   <para>rdfs:comment : It represents an electrical grid^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#ElectricalGrid">glc:ElectricalGrid</a>
    /// </summary>
    let ElectricalGrid = _prefixId.prefix "ElectricalGrid"
    /// <summary>
    ///   <para>rdfs:label : Energy Power Generation Resource^^xsd:string</para>
    ///   <para>rdfs:comment : It represents an energy resource that generates power^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#EnergyPowerGenerationResource">glc:EnergyPowerGenerationResource</a>
    /// </summary>
    let EnergyPowerGenerationResource = _prefixId.prefix "EnergyPowerGenerationResource"
    /// <summary>
    ///   <para>rdfs:label : Energy Resource^^xsd:string</para>
    ///   <para>rdfs:comment : It represents an energy resource^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#EnergyResource">glc:EnergyResource</a>
    /// </summary>
    let EnergyResource = _prefixId.prefix "EnergyResource"
    /// <summary>
    ///   <para>rdfs:label : HardConstraint^^xsd:string</para>
    ///   <para>rdfs:comment : For representing the HardConstraints of a Task.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#HardConstraint">glc:HardConstraint</a>
    /// </summary>
    let HardConstraint = _prefixId.prefix "HardConstraint"
    /// <summary>
    ///   <para>rdfs:label : Measurement^^xsd:string</para>
    ///   <para>rdfs:comment : Represents any Measurement, e.g., for energy.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#Measurement">glc:Measurement</a>
    /// </summary>
    let Measurement = _prefixId.prefix "Measurement"
    /// <summary>
    ///   <para>rdfs:label : MeasurementProperty^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a MeasurementProperty, e.g., allocated CPU, energy, etc.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#MeasurementProperty">glc:MeasurementProperty</a>
    /// </summary>
    let MeasurementProperty = _prefixId.prefix "MeasurementProperty"
    /// <summary>
    ///   <para>rdfs:label : MeasurementUnit^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a MeasurementUnit, e.g., Kwh.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#MeasurementUnit">glc:MeasurementUnit</a>
    /// </summary>
    let MeasurementUnit = _prefixId.prefix "MeasurementUnit"
    /// <summary>
    ///   <para>rdfs:label : MeasuringResource^^xsd:string</para>
    ///   <para>rdfs:comment : It represents any WorkProducingResource that can perform Measurements.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#MeasuringResource">glc:MeasuringResource</a>
    /// </summary>
    let MeasuringResource = _prefixId.prefix "MeasuringResource"
    /// <summary>
    ///   <para>rdfs:label : Monitor^^xsd:string</para>
    ///   <para>rdfs:comment : Represents an entity that monitors an AssignedTask.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#Monitor">glc:Monitor</a>
    /// </summary>
    let Monitor = _prefixId.prefix "Monitor"
    /// <summary>
    ///   <para>rdfs:label : NonWorkProducingResource^^xsd:string</para>
    ///   <para>rdfs:comment : It represents any NonWorkProducingResource (e.g., dataset).^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#NonWorkProducingResource">glc:NonWorkProducingResource</a>
    /// </summary>
    let NonWorkProducingResource = _prefixId.prefix "NonWorkProducingResource"
    /// <summary>
    ///   <para>rdfs:label : Resource^^xsd:string</para>
    ///   <para>rdfs:comment : It represents any Resource.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#Resource">glc:Resource</a>
    /// </summary>
    let Resource = _prefixId.prefix "Resource"
    /// <summary>
    ///   <para>rdfs:label : Scheduler^^xsd:string</para>
    ///   <para>rdfs:comment : Responsible for Scheduling a SubmittedTask and for managing the Resources.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#Scheduler">glc:Scheduler</a>
    /// </summary>
    let Scheduler = _prefixId.prefix "Scheduler"
    /// <summary>
    ///   <para>rdfs:label : Site^^xsd:string</para>
    ///   <para>rdfs:comment : It represents any Site, e.g., a location, an island, etc.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#Site">glc:Site</a>
    /// </summary>
    let Site = _prefixId.prefix "Site"
    /// <summary>
    ///   <para>rdfs:label : SoftConstraint^^xsd:string</para>
    ///   <para>rdfs:comment : For representing the SoftConstraints of a Task.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#SoftConstraint">glc:SoftConstraint</a>
    /// </summary>
    let SoftConstraint = _prefixId.prefix "SoftConstraint"
    /// <summary>
    ///   <para>rdfs:label : SoftConstraintComposition^^xsd:string</para>
    ///   <para>rdfs:comment : It describes the composition of SoftConstraints, e.g., the order of soft constraings according to a given preference priority, Pareto, Pareto optimal, etc.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#SoftConstraintComposition">glc:SoftConstraintComposition</a>
    /// </summary>
    let SoftConstraintComposition = _prefixId.prefix "SoftConstraintComposition"
    /// <summary>
    ///   <para>rdfs:label : Status^^xsd:string</para>
    ///   <para>rdfs:comment : Represents information about a specific Status over a given time interval.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#Status">glc:Status</a>
    /// </summary>
    let Status = _prefixId.prefix "Status"
    /// <summary>
    ///   <para>rdfs:label : SubmittedTask^^xsd:string</para>
    ///   <para>rdfs:comment : A Submitted Task that will be processed by a Scheduler.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#SubmittedTask">glc:SubmittedTask</a>
    /// </summary>
    let SubmittedTask = _prefixId.prefix "SubmittedTask"
    /// <summary>
    ///   <para>rdfs:label : Task^^xsd:string</para>
    ///   <para>rdfs:comment : It describes any Task that has Constraints and a Status.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#Task">glc:Task</a>
    /// </summary>
    let Task = _prefixId.prefix "Task"
    /// <summary>
    ///   <para>rdfs:label : WorkProducingResource^^xsd:string</para>
    ///   <para>rdfs:comment : It represents any WorkProducingResource, e.g., a node, a CPU, etc.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#WorkProducingResource">glc:WorkProducingResource</a>
    /// </summary>
    let WorkProducingResource = _prefixId.prefix "WorkProducingResource"
    /// <summary>
    ///   <para>rdfs:label : assigns^^xsd:string</para>
    ///   <para>rdfs:comment : A relationship between a Scheduler and an AssignedTask.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#assigns">glc:assigns</a>
    /// </summary>
    let assigns = _prefixId.prefix "assigns"
    /// <summary>
    ///   <para>rdfs:label : composedBy^^xsd:string</para>
    ///   <para>rdfs:comment : For keeping information about the SoftConstraints that are included in a Composition.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#composedBy">glc:composedBy</a>
    /// </summary>
    let composedBy = _prefixId.prefix "composedBy"
    /// <summary>
    ///   <para>rdfs:label : consumes^^xsd:string</para>
    ///   <para>rdfs:comment : A property for recording the Resource(s) of each AssignedTask.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#consumes">glc:consumes</a>
    /// </summary>
    let consumes = _prefixId.prefix "consumes"
    /// <summary>
    ///   <para>rdfs:label : consumesEnergyFrom^^xsd:string</para>
    ///   <para>rdfs:comment : The grid where a work producing resource consumes energy from^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#consumesEnergyFrom">glc:consumesEnergyFrom</a>
    /// </summary>
    let consumesEnergyFrom = _prefixId.prefix "consumesEnergyFrom"
    /// <summary>
    ///   <para>rdfs:label : endTime^^xsd:string</para>
    ///   <para>rdfs:comment : The end time of a Status of any Class.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#endTime">glc:endTime</a>
    /// </summary>
    let endTime = _prefixId.prefix "endTime"
    /// <summary>
    ///   <para>rdfs:label : endingInterval^^xsd:string</para>
    ///   <para>rdfs:comment : The ending interval time of an AggregatedMeasurement.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#endingInterval">glc:endingInterval</a>
    /// </summary>
    let endingInterval = _prefixId.prefix "endingInterval"
    /// <summary>
    ///   <para>rdfs:label : hasAggregatedFuntion^^xsd:string</para>
    ///   <para>rdfs:comment : The AggregatedFunction of an AggregatedMeasurement.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#hasAggregatedFuntion">glc:hasAggregatedFuntion</a>
    /// </summary>
    let hasAggregatedFuntion = _prefixId.prefix "hasAggregatedFuntion"
    /// <summary>
    ///   <para>rdfs:label : hasAspect^^xsd:string</para>
    ///   <para>rdfs:comment : For keeping information about the Aspect of each Constraint, e.g., time, power consumption.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#hasAspect">glc:hasAspect</a>
    /// </summary>
    let hasAspect = _prefixId.prefix "hasAspect"
    /// <summary>
    ///   <para>rdfs:label : hasComposition^^xsd:string</para>
    ///   <para>rdfs:comment : For keeping information about the Composition of the SoftConstraints of a Task.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#hasComposition">glc:hasComposition</a>
    /// </summary>
    let hasComposition = _prefixId.prefix "hasComposition"
    /// <summary>
    ///   <para>rdfs:label : hasConfiguration^^xsd:string</para>
    ///   <para>rdfs:comment : The Configuration of any instance of a Class, e.g., Task, Resource, etc.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#hasConfiguration">glc:hasConfiguration</a>
    /// </summary>
    let hasConfiguration = _prefixId.prefix "hasConfiguration"
    /// <summary>
    ///   <para>rdfs:label : hasConstraint^^xsd:string</para>
    ///   <para>rdfs:comment : A relationship for recording all the Constraints of a Task.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#hasConstraint">glc:hasConstraint</a>
    /// </summary>
    let hasConstraint = _prefixId.prefix "hasConstraint"
    /// <summary>
    ///   <para>rdfs:label : hasDescription^^xsd:string</para>
    ///   <para>rdfs:comment : The Description of any entity.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#hasDescription">glc:hasDescription</a>
    /// </summary>
    let hasDescription = _prefixId.prefix "hasDescription"
    /// <summary>
    ///   <para>rdfs:label : hasID^^xsd:string</para>
    ///   <para>rdfs:comment : The ID of any entity.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#hasID">glc:hasID</a>
    /// </summary>
    let hasID = _prefixId.prefix "hasID"
    /// <summary>
    ///   <para>rdfs:label : hasResourceMeasurement^^xsd:string</para>
    ///   <para>rdfs:comment : A relationship between a Resource and a Measurement.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#hasResourceMeasurement">glc:hasResourceMeasurement</a>
    /// </summary>
    let hasResourceMeasurement = _prefixId.prefix "hasResourceMeasurement"
    /// <summary>
    ///   <para>rdfs:label : hasStatus^^xsd:string</para>
    ///   <para>rdfs:comment : A relationship between any Class and its Status.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#hasStatus">glc:hasStatus</a>
    /// </summary>
    let hasStatus = _prefixId.prefix "hasStatus"
    /// <summary>
    ///   <para>rdfs:label : hasSubResource^^xsd:string</para>
    ///   <para>rdfs:comment : Relationships for recording the SubResource(s) of each Resource (e.g, the hardware of a node).^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#hasSubResource">glc:hasSubResource</a>
    /// </summary>
    let hasSubResource = _prefixId.prefix "hasSubResource"
    /// <summary>
    ///   <para>rdfs:label : hasTaskMeasurement^^xsd:string</para>
    ///   <para>rdfs:comment : A relationship between a Task and a Measurement.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#hasTaskMeasurement">glc:hasTaskMeasurement</a>
    /// </summary>
    let hasTaskMeasurement = _prefixId.prefix "hasTaskMeasurement"
    /// <summary>
    ///   <para>rdfs:label : hasTaskPredictedMeasurement^^xsd:string</para>
    ///   <para>rdfs:comment : A relationship for recording the PredictedMeasurements of a Task.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#hasTaskPredictedMeasurement">glc:hasTaskPredictedMeasurement</a>
    /// </summary>
    let hasTaskPredictedMeasurement = _prefixId.prefix "hasTaskPredictedMeasurement"
    /// <summary>
    ///   <para>rdfs:label : hasTaskRealizedMeasurement^^xsd:string</para>
    ///   <para>rdfs:comment : A relationship for recording the RealizedMeasurements (actual measurements) of a Task.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#hasTaskRealizedMeasurement">glc:hasTaskRealizedMeasurement</a>
    /// </summary>
    let hasTaskRealizedMeasurement = _prefixId.prefix "hasTaskRealizedMeasurement"
    /// <summary>
    ///   <para>rdfs:label : hasTimestamp^^xsd:string</para>
    ///   <para>rdfs:comment : The date and time of a Measurement.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#hasTimestamp">glc:hasTimestamp</a>
    /// </summary>
    let hasTimestamp = _prefixId.prefix "hasTimestamp"
    /// <summary>
    ///   <para>rdfs:label : hasValue^^xsd:string</para>
    ///   <para>rdfs:comment : The Value of a Measurement.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#hasValue">glc:hasValue</a>
    /// </summary>
    let hasValue = _prefixId.prefix "hasValue"
    /// <summary>
    ///   <para>rdfs:label : isLocatedIn^^xsd:string</para>
    ///   <para>rdfs:comment : The location of a Work Producing Resource^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#isLocatedIn">glc:isLocatedIn</a>
    /// </summary>
    let isLocatedIn = _prefixId.prefix "isLocatedIn"
    /// <summary>
    ///   <para>rdfs:label : makesMeasurement^^xsd:string</para>
    ///   <para>rdfs:comment : A relationship between a MeasuringResource and a Measurement.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#makesMeasurement">glc:makesMeasurement</a>
    /// </summary>
    let makesMeasurement = _prefixId.prefix "makesMeasurement"
    /// <summary>
    ///   <para>rdfs:label : manages^^xsd:string</para>
    ///   <para>rdfs:comment : A relationship between a Scheduler and a Resource.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#manages">glc:manages</a>
    /// </summary>
    let manages = _prefixId.prefix "manages"
    /// <summary>
    ///   <para>rdfs:label : measuredIn^^xsd:string</para>
    ///   <para>rdfs:comment : For recording the MeasurimentUnit of each Measurement.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#measuredIn">glc:measuredIn</a>
    /// </summary>
    let measuredIn = _prefixId.prefix "measuredIn"
    /// <summary>
    ///   <para>rdfs:label : monitors^^xsd:string</para>
    ///   <para>rdfs:comment : For recording which Monitor tracks an AssignedTask.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#monitors">glc:monitors</a>
    /// </summary>
    let monitors = _prefixId.prefix "monitors"
    /// <summary>
    ///   <para>rdfs:label : produces^^xsd:string</para>
    ///   <para>rdfs:comment : For keeping information about the production Resource, e.g., the output, of an AssignedTask.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#produces">glc:produces</a>
    /// </summary>
    let produces = _prefixId.prefix "produces"
    /// <summary>
    ///   <para>rdfs:label : relatesToConstraint^^xsd:string</para>
    ///   <para>rdfs:comment : For keeping information about the Constraint that each Measurement relates to.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#relatesToConstraint">glc:relatesToConstraint</a>
    /// </summary>
    let relatesToConstraint = _prefixId.prefix "relatesToConstraint"
    /// <summary>
    ///   <para>rdfs:label : relatesToMeasurementProperty^^xsd:string</para>
    ///   <para>rdfs:comment : For recording the MeasurementProperty of each Measurement.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#relatesToMeasurementProperty">glc:relatesToMeasurementProperty</a>
    /// </summary>
    let relatesToMeasurementProperty = _prefixId.prefix "relatesToMeasurementProperty"
    /// <summary>
    ///   <para>rdfs:label : reschedules^^xsd:string</para>
    ///   <para>rdfs:comment : A relationship between a Scheduler and an AssignedTask that concerns rescheduling.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#reschedules">glc:reschedules</a>
    /// </summary>
    let reschedules = _prefixId.prefix "reschedules"
    /// <summary>
    ///   <para>rdfs:label : scheduledBy^^xsd:string</para>
    ///   <para>rdfs:comment : A relationship between a SubmittedTask and a Scheduler.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#scheduledBy">glc:scheduledBy</a>
    /// </summary>
    let scheduledBy = _prefixId.prefix "scheduledBy"
    /// <summary>
    ///   <para>rdfs:label : startTime^^xsd:string</para>
    ///   <para>rdfs:comment : The date and time of a Status.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#startTime">glc:startTime</a>
    /// </summary>
    let startTime = _prefixId.prefix "startTime"
    /// <summary>
    ///   <para>rdfs:label : startingInterval^^xsd:string</para>
    ///   <para>rdfs:comment : The starting interval time of an AggregatedMeasurement.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#startingInterval">glc:startingInterval</a>
    /// </summary>
    let startingInterval = _prefixId.prefix "startingInterval"
    /// <summary>
    ///   <para>rdfs:label : statusCode^^xsd:string</para>
    ///   <para>rdfs:comment : The status code of a Status.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#statusCode">glc:statusCode</a>
    /// </summary>
    let statusCode = _prefixId.prefix "statusCode"
    /// <summary>
    ///   <para>rdfs:label : timeStepResolution^^xsd:string</para>
    ///   <para>rdfs:comment : The time step resolution of an AggregatedMeasurement.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#timeStepResolution">glc:timeStepResolution</a>
    /// </summary>
    let timeStepResolution = _prefixId.prefix "timeStepResolution"
    /// <summary>
    ///   <para>rdfs:label : triggersReschedule^^xsd:string</para>
    ///   <para>rdfs:comment : A triggered event relationship about Rescheduling from a Monitor.^^xsd:string</para>
    ///   <a href="https://glaciation-project.eu/MetadataReferenceModel#triggersReschedule">glc:triggersReschedule</a>
    /// </summary>
    let triggersReschedule = _prefixId.prefix "triggersReschedule"

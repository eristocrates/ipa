namespace https.glaciation_project.eu.MetadataReferenceModel.hash

open DoxAletheia

module glc =
    let _namespace_name = "https://glaciation-project.eu/MetadataReferenceModel#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Represents any AggregatedMeasurement, by using an AggregatedFunction, a time interval and time step resolution.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#AggregatedMeasurement"></see></summary>
    let AggregatedMeasurement = _prefix "AggregatedMeasurement"
    /// <summary>
    /// Represents any Measurement, e.g., for energy.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#Measurement"></see></summary>
    let Measurement = _prefix "Measurement"
    /// <summary>
    /// It describes the Aspect of a Contstraint, e.g., time, power consumption.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#Aspect"></see></summary>
    let Aspect = _prefix "Aspect"
    /// <summary>
    /// A generic Class for the GLACIATION project
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#Class"></see></summary>
    let Class = _prefix "Class"
    /// <summary>
    /// An AssignedTask that will be performed by using some Resources and will be based on some Constraints.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#AssignedTask"></see></summary>
    let AssignedTask = _prefix "AssignedTask"
    /// <summary>
    /// It describes any Task that has Constraints and a Status.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#Task"></see></summary>
    let Task = _prefix "Task"
    /// <summary>
    /// For representing the Constraint(s) of a Task.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#Constraint"></see></summary>
    let Constraint = _prefix "Constraint"
    /// <summary>
    /// It represents an electrical grid
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#ElectricalGrid"></see></summary>
    let ElectricalGrid = _prefix "ElectricalGrid"
    /// <summary>
    /// It represents an energy resource
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#EnergyResource"></see></summary>
    let EnergyResource = _prefix "EnergyResource"
    /// <summary>
    /// It represents an energy resource that generates power
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#EnergyPowerGenerationResource"></see></summary>
    let EnergyPowerGenerationResource = _prefix "EnergyPowerGenerationResource"
    /// <summary>
    /// It represents any WorkProducingResource, e.g., a node, a CPU, etc.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#WorkProducingResource"></see></summary>
    let WorkProducingResource = _prefix "WorkProducingResource"
    /// <summary>
    /// For representing the HardConstraints of a Task.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#HardConstraint"></see></summary>
    let HardConstraint = _prefix "HardConstraint"
    /// <summary>
    /// Represents a MeasurementProperty, e.g., allocated CPU, energy, etc.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#MeasurementProperty"></see></summary>
    let MeasurementProperty = _prefix "MeasurementProperty"
    /// <summary>
    /// Represents a MeasurementUnit, e.g., Kwh.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#MeasurementUnit"></see></summary>
    let MeasurementUnit = _prefix "MeasurementUnit"
    /// <summary>
    /// It represents any WorkProducingResource that can perform Measurements.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#MeasuringResource"></see></summary>
    let MeasuringResource = _prefix "MeasuringResource"
    /// <summary>
    /// Represents an entity that monitors an AssignedTask.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#Monitor"></see></summary>
    let Monitor = _prefix "Monitor"
    /// <summary>
    /// It represents any NonWorkProducingResource (e.g., dataset).
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#NonWorkProducingResource"></see></summary>
    let NonWorkProducingResource = _prefix "NonWorkProducingResource"
    /// <summary>
    /// It represents any Resource.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#Resource"></see></summary>
    let Resource = _prefix "Resource"
    /// <summary>
    /// Responsible for Scheduling a SubmittedTask and for managing the Resources.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#Scheduler"></see></summary>
    let Scheduler = _prefix "Scheduler"
    /// <summary>
    /// It represents any Site, e.g., a location, an island, etc.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#Site"></see></summary>
    let Site = _prefix "Site"
    /// <summary>
    /// For representing the SoftConstraints of a Task.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#SoftConstraint"></see></summary>
    let SoftConstraint = _prefix "SoftConstraint"
    /// <summary>
    /// It describes the composition of SoftConstraints, e.g., the order of soft constraings according to a given preference priority, Pareto, Pareto optimal, etc.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#SoftConstraintComposition"></see></summary>
    let SoftConstraintComposition = _prefix "SoftConstraintComposition"
    /// <summary>
    /// Represents information about a specific Status over a given time interval.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#Status"></see></summary>
    let Status = _prefix "Status"
    /// <summary>
    /// A Submitted Task that will be processed by a Scheduler.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#SubmittedTask"></see></summary>
    let SubmittedTask = _prefix "SubmittedTask"
    /// <summary>
    /// A relationship between a Scheduler and an AssignedTask.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#assigns"></see></summary>
    let assigns = _prefix "assigns"
    /// <summary>
    /// For keeping information about the SoftConstraints that are included in a Composition.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#composedBy"></see></summary>
    let composedBy = _prefix "composedBy"
    /// <summary>
    /// A property for recording the Resource(s) of each AssignedTask.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#consumes"></see></summary>
    let consumes = _prefix "consumes"
    /// <summary>
    /// The grid where a work producing resource consumes energy from
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#consumesEnergyFrom"></see></summary>
    let consumesEnergyFrom = _prefix "consumesEnergyFrom"
    /// <summary>
    /// The end time of a Status of any Class.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#endTime"></see></summary>
    let endTime = _prefix "endTime"
    /// <summary>
    /// The ending interval time of an AggregatedMeasurement.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#endingInterval"></see></summary>
    let endingInterval = _prefix "endingInterval"
    /// <summary>
    /// The AggregatedFunction of an AggregatedMeasurement.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#hasAggregatedFuntion"></see></summary>
    let hasAggregatedFuntion = _prefix "hasAggregatedFuntion"
    /// <summary>
    /// For keeping information about the Aspect of each Constraint, e.g., time, power consumption.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#hasAspect"></see></summary>
    let hasAspect = _prefix "hasAspect"
    /// <summary>
    /// For keeping information about the Composition of the SoftConstraints of a Task.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#hasComposition"></see></summary>
    let hasComposition = _prefix "hasComposition"
    /// <summary>
    /// The Configuration of any instance of a Class, e.g., Task, Resource, etc.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#hasConfiguration"></see></summary>
    let hasConfiguration = _prefix "hasConfiguration"
    /// <summary>
    /// A relationship for recording all the Constraints of a Task.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#hasConstraint"></see></summary>
    let hasConstraint = _prefix "hasConstraint"
    /// <summary>
    /// The Description of any entity.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#hasDescription"></see></summary>
    let hasDescription = _prefix "hasDescription"
    /// <summary>
    /// The ID of any entity.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#hasID"></see></summary>
    let hasID = _prefix "hasID"
    /// <summary>
    /// A relationship between a Resource and a Measurement.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#hasResourceMeasurement"></see></summary>
    let hasResourceMeasurement = _prefix "hasResourceMeasurement"
    /// <summary>
    /// A relationship between any Class and its Status.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#hasStatus"></see></summary>
    let hasStatus = _prefix "hasStatus"
    /// <summary>
    /// Relationships for recording the SubResource(s) of each Resource (e.g, the hardware of a node).
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#hasSubResource"></see></summary>
    let hasSubResource = _prefix "hasSubResource"
    /// <summary>
    /// A relationship between a Task and a Measurement.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#hasTaskMeasurement"></see></summary>
    let hasTaskMeasurement = _prefix "hasTaskMeasurement"
    /// <summary>
    /// A relationship for recording the PredictedMeasurements of a Task.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#hasTaskPredictedMeasurement"></see></summary>
    let hasTaskPredictedMeasurement = _prefix "hasTaskPredictedMeasurement"
    /// <summary>
    /// A relationship for recording the RealizedMeasurements (actual measurements) of a Task.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#hasTaskRealizedMeasurement"></see></summary>
    let hasTaskRealizedMeasurement = _prefix "hasTaskRealizedMeasurement"
    /// <summary>
    /// The date and time of a Measurement.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#hasTimestamp"></see></summary>
    let hasTimestamp = _prefix "hasTimestamp"
    /// <summary>
    /// The Value of a Measurement.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#hasValue"></see></summary>
    let hasValue = _prefix "hasValue"
    /// <summary>
    /// The location of a Work Producing Resource
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#isLocatedIn"></see></summary>
    let isLocatedIn = _prefix "isLocatedIn"
    /// <summary>
    /// A relationship between a MeasuringResource and a Measurement.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#makesMeasurement"></see></summary>
    let makesMeasurement = _prefix "makesMeasurement"
    /// <summary>
    /// A relationship between a Scheduler and a Resource.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#manages"></see></summary>
    let manages = _prefix "manages"
    /// <summary>
    /// For recording the MeasurimentUnit of each Measurement.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#measuredIn"></see></summary>
    let measuredIn = _prefix "measuredIn"
    /// <summary>
    /// For recording which Monitor tracks an AssignedTask.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#monitors"></see></summary>
    let monitors = _prefix "monitors"
    /// <summary>
    /// For keeping information about the production Resource, e.g., the output, of an AssignedTask.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#produces"></see></summary>
    let produces = _prefix "produces"
    /// <summary>
    /// For keeping information about the Constraint that each Measurement relates to.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#relatesToConstraint"></see></summary>
    let relatesToConstraint = _prefix "relatesToConstraint"
    /// <summary>
    /// For recording the MeasurementProperty of each Measurement.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#relatesToMeasurementProperty"></see></summary>
    let relatesToMeasurementProperty = _prefix "relatesToMeasurementProperty"
    /// <summary>
    /// A relationship between a Scheduler and an AssignedTask that concerns rescheduling.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#reschedules"></see></summary>
    let reschedules = _prefix "reschedules"
    /// <summary>
    /// A relationship between a SubmittedTask and a Scheduler.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#scheduledBy"></see></summary>
    let scheduledBy = _prefix "scheduledBy"
    /// <summary>
    /// The date and time of a Status.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#startTime"></see></summary>
    let startTime = _prefix "startTime"
    /// <summary>
    /// The starting interval time of an AggregatedMeasurement.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#startingInterval"></see></summary>
    let startingInterval = _prefix "startingInterval"
    /// <summary>
    /// The status code of a Status.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#statusCode"></see></summary>
    let statusCode = _prefix "statusCode"
    /// <summary>
    /// The time step resolution of an AggregatedMeasurement.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#timeStepResolution"></see></summary>
    let timeStepResolution = _prefix "timeStepResolution"
    /// <summary>
    /// A triggered event relationship about Rescheduling from a Monitor.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#triggersReschedule"></see></summary>
    let triggersReschedule = _prefix "triggersReschedule"

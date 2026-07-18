namespace https.glaciation_project.eu.MetadataReferenceModel.hash

open DoxAletheia.Rdf_Vocabulary

module glc =
    let _namespace_name = "https://glaciation-project.eu/MetadataReferenceModel#"

    /// <summary>
    /// Represents any AggregatedMeasurement, by using an AggregatedFunction, a time interval and time step resolution.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#AggregatedMeasurement"></see></summary>
    let AggregatedMeasurement =
        Namespaced_IRI.parse _namespace_name "AggregatedMeasurement" |> NamespacedName

    /// <summary>
    /// Represents any Measurement, e.g., for energy.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#Measurement"></see></summary>
    let Measurement =
        Namespaced_IRI.parse _namespace_name "Measurement" |> NamespacedName

    /// <summary>
    /// It describes the Aspect of a Contstraint, e.g., time, power consumption.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#Aspect"></see></summary>
    let Aspect = Namespaced_IRI.parse _namespace_name "Aspect" |> NamespacedName
    /// <summary>
    /// A generic Class for the GLACIATION project
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#Class"></see></summary>
    let Class = Namespaced_IRI.parse _namespace_name "Class" |> NamespacedName

    /// <summary>
    /// An AssignedTask that will be performed by using some Resources and will be based on some Constraints.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#AssignedTask"></see></summary>
    let AssignedTask =
        Namespaced_IRI.parse _namespace_name "AssignedTask" |> NamespacedName

    /// <summary>
    /// It describes any Task that has Constraints and a Status.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#Task"></see></summary>
    let Task = Namespaced_IRI.parse _namespace_name "Task" |> NamespacedName
    /// <summary>
    /// For representing the Constraint(s) of a Task.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#Constraint"></see></summary>
    let Constraint = Namespaced_IRI.parse _namespace_name "Constraint" |> NamespacedName

    /// <summary>
    /// It represents an electrical grid
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#ElectricalGrid"></see></summary>
    let ElectricalGrid =
        Namespaced_IRI.parse _namespace_name "ElectricalGrid" |> NamespacedName

    /// <summary>
    /// It represents an energy resource
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#EnergyResource"></see></summary>
    let EnergyResource =
        Namespaced_IRI.parse _namespace_name "EnergyResource" |> NamespacedName

    /// <summary>
    /// It represents an energy resource that generates power
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#EnergyPowerGenerationResource"></see></summary>
    let EnergyPowerGenerationResource =
        Namespaced_IRI.parse _namespace_name "EnergyPowerGenerationResource" |> NamespacedName

    /// <summary>
    /// It represents any WorkProducingResource, e.g., a node, a CPU, etc.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#WorkProducingResource"></see></summary>
    let WorkProducingResource =
        Namespaced_IRI.parse _namespace_name "WorkProducingResource" |> NamespacedName

    /// <summary>
    /// For representing the HardConstraints of a Task.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#HardConstraint"></see></summary>
    let HardConstraint =
        Namespaced_IRI.parse _namespace_name "HardConstraint" |> NamespacedName

    /// <summary>
    /// Represents a MeasurementProperty, e.g., allocated CPU, energy, etc.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#MeasurementProperty"></see></summary>
    let MeasurementProperty =
        Namespaced_IRI.parse _namespace_name "MeasurementProperty" |> NamespacedName

    /// <summary>
    /// Represents a MeasurementUnit, e.g., Kwh.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#MeasurementUnit"></see></summary>
    let MeasurementUnit =
        Namespaced_IRI.parse _namespace_name "MeasurementUnit" |> NamespacedName

    /// <summary>
    /// It represents any WorkProducingResource that can perform Measurements.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#MeasuringResource"></see></summary>
    let MeasuringResource =
        Namespaced_IRI.parse _namespace_name "MeasuringResource" |> NamespacedName

    /// <summary>
    /// Represents an entity that monitors an AssignedTask.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#Monitor"></see></summary>
    let Monitor = Namespaced_IRI.parse _namespace_name "Monitor" |> NamespacedName

    /// <summary>
    /// It represents any NonWorkProducingResource (e.g., dataset).
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#NonWorkProducingResource"></see></summary>
    let NonWorkProducingResource =
        Namespaced_IRI.parse _namespace_name "NonWorkProducingResource" |> NamespacedName

    /// <summary>
    /// It represents any Resource.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#Resource"></see></summary>
    let Resource = Namespaced_IRI.parse _namespace_name "Resource" |> NamespacedName
    /// <summary>
    /// Responsible for Scheduling a SubmittedTask and for managing the Resources.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#Scheduler"></see></summary>
    let Scheduler = Namespaced_IRI.parse _namespace_name "Scheduler" |> NamespacedName
    /// <summary>
    /// It represents any Site, e.g., a location, an island, etc.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#Site"></see></summary>
    let Site = Namespaced_IRI.parse _namespace_name "Site" |> NamespacedName

    /// <summary>
    /// For representing the SoftConstraints of a Task.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#SoftConstraint"></see></summary>
    let SoftConstraint =
        Namespaced_IRI.parse _namespace_name "SoftConstraint" |> NamespacedName

    /// <summary>
    /// It describes the composition of SoftConstraints, e.g., the order of soft constraings according to a given preference priority, Pareto, Pareto optimal, etc.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#SoftConstraintComposition"></see></summary>
    let SoftConstraintComposition =
        Namespaced_IRI.parse _namespace_name "SoftConstraintComposition" |> NamespacedName

    /// <summary>
    /// Represents information about a specific Status over a given time interval.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#Status"></see></summary>
    let Status = Namespaced_IRI.parse _namespace_name "Status" |> NamespacedName

    /// <summary>
    /// A Submitted Task that will be processed by a Scheduler.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#SubmittedTask"></see></summary>
    let SubmittedTask =
        Namespaced_IRI.parse _namespace_name "SubmittedTask" |> NamespacedName

    /// <summary>
    /// A relationship between a Scheduler and an AssignedTask.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#assigns"></see></summary>
    let assigns = Namespaced_IRI.parse _namespace_name "assigns" |> NamespacedName
    /// <summary>
    /// For keeping information about the SoftConstraints that are included in a Composition.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#composedBy"></see></summary>
    let composedBy = Namespaced_IRI.parse _namespace_name "composedBy" |> NamespacedName
    /// <summary>
    /// A property for recording the Resource(s) of each AssignedTask.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#consumes"></see></summary>
    let consumes = Namespaced_IRI.parse _namespace_name "consumes" |> NamespacedName

    /// <summary>
    /// The grid where a work producing resource consumes energy from
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#consumesEnergyFrom"></see></summary>
    let consumesEnergyFrom =
        Namespaced_IRI.parse _namespace_name "consumesEnergyFrom" |> NamespacedName

    /// <summary>
    /// The end time of a Status of any Class.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#endTime"></see></summary>
    let endTime = Namespaced_IRI.parse _namespace_name "endTime" |> NamespacedName

    /// <summary>
    /// The ending interval time of an AggregatedMeasurement.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#endingInterval"></see></summary>
    let endingInterval =
        Namespaced_IRI.parse _namespace_name "endingInterval" |> NamespacedName

    /// <summary>
    /// The AggregatedFunction of an AggregatedMeasurement.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#hasAggregatedFuntion"></see></summary>
    let hasAggregatedFuntion =
        Namespaced_IRI.parse _namespace_name "hasAggregatedFuntion" |> NamespacedName

    /// <summary>
    /// For keeping information about the Aspect of each Constraint, e.g., time, power consumption.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#hasAspect"></see></summary>
    let hasAspect = Namespaced_IRI.parse _namespace_name "hasAspect" |> NamespacedName

    /// <summary>
    /// For keeping information about the Composition of the SoftConstraints of a Task.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#hasComposition"></see></summary>
    let hasComposition =
        Namespaced_IRI.parse _namespace_name "hasComposition" |> NamespacedName

    /// <summary>
    /// The Configuration of any instance of a Class, e.g., Task, Resource, etc.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#hasConfiguration"></see></summary>
    let hasConfiguration =
        Namespaced_IRI.parse _namespace_name "hasConfiguration" |> NamespacedName

    /// <summary>
    /// A relationship for recording all the Constraints of a Task.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#hasConstraint"></see></summary>
    let hasConstraint =
        Namespaced_IRI.parse _namespace_name "hasConstraint" |> NamespacedName

    /// <summary>
    /// The Description of any entity.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#hasDescription"></see></summary>
    let hasDescription =
        Namespaced_IRI.parse _namespace_name "hasDescription" |> NamespacedName

    /// <summary>
    /// The ID of any entity.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#hasID"></see></summary>
    let hasID = Namespaced_IRI.parse _namespace_name "hasID" |> NamespacedName

    /// <summary>
    /// A relationship between a Resource and a Measurement.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#hasResourceMeasurement"></see></summary>
    let hasResourceMeasurement =
        Namespaced_IRI.parse _namespace_name "hasResourceMeasurement" |> NamespacedName

    /// <summary>
    /// A relationship between any Class and its Status.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#hasStatus"></see></summary>
    let hasStatus = Namespaced_IRI.parse _namespace_name "hasStatus" |> NamespacedName

    /// <summary>
    /// Relationships for recording the SubResource(s) of each Resource (e.g, the hardware of a node).
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#hasSubResource"></see></summary>
    let hasSubResource =
        Namespaced_IRI.parse _namespace_name "hasSubResource" |> NamespacedName

    /// <summary>
    /// A relationship between a Task and a Measurement.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#hasTaskMeasurement"></see></summary>
    let hasTaskMeasurement =
        Namespaced_IRI.parse _namespace_name "hasTaskMeasurement" |> NamespacedName

    /// <summary>
    /// A relationship for recording the PredictedMeasurements of a Task.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#hasTaskPredictedMeasurement"></see></summary>
    let hasTaskPredictedMeasurement =
        Namespaced_IRI.parse _namespace_name "hasTaskPredictedMeasurement" |> NamespacedName

    /// <summary>
    /// A relationship for recording the RealizedMeasurements (actual measurements) of a Task.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#hasTaskRealizedMeasurement"></see></summary>
    let hasTaskRealizedMeasurement =
        Namespaced_IRI.parse _namespace_name "hasTaskRealizedMeasurement" |> NamespacedName

    /// <summary>
    /// The date and time of a Measurement.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#hasTimestamp"></see></summary>
    let hasTimestamp =
        Namespaced_IRI.parse _namespace_name "hasTimestamp" |> NamespacedName

    /// <summary>
    /// The Value of a Measurement.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#hasValue"></see></summary>
    let hasValue = Namespaced_IRI.parse _namespace_name "hasValue" |> NamespacedName

    /// <summary>
    /// The location of a Work Producing Resource
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#isLocatedIn"></see></summary>
    let isLocatedIn =
        Namespaced_IRI.parse _namespace_name "isLocatedIn" |> NamespacedName

    /// <summary>
    /// A relationship between a MeasuringResource and a Measurement.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#makesMeasurement"></see></summary>
    let makesMeasurement =
        Namespaced_IRI.parse _namespace_name "makesMeasurement" |> NamespacedName

    /// <summary>
    /// A relationship between a Scheduler and a Resource.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#manages"></see></summary>
    let manages = Namespaced_IRI.parse _namespace_name "manages" |> NamespacedName
    /// <summary>
    /// For recording the MeasurimentUnit of each Measurement.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#measuredIn"></see></summary>
    let measuredIn = Namespaced_IRI.parse _namespace_name "measuredIn" |> NamespacedName
    /// <summary>
    /// For recording which Monitor tracks an AssignedTask.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#monitors"></see></summary>
    let monitors = Namespaced_IRI.parse _namespace_name "monitors" |> NamespacedName
    /// <summary>
    /// For keeping information about the production Resource, e.g., the output, of an AssignedTask.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#produces"></see></summary>
    let produces = Namespaced_IRI.parse _namespace_name "produces" |> NamespacedName

    /// <summary>
    /// For keeping information about the Constraint that each Measurement relates to.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#relatesToConstraint"></see></summary>
    let relatesToConstraint =
        Namespaced_IRI.parse _namespace_name "relatesToConstraint" |> NamespacedName

    /// <summary>
    /// For recording the MeasurementProperty of each Measurement.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#relatesToMeasurementProperty"></see></summary>
    let relatesToMeasurementProperty =
        Namespaced_IRI.parse _namespace_name "relatesToMeasurementProperty" |> NamespacedName

    /// <summary>
    /// A relationship between a Scheduler and an AssignedTask that concerns rescheduling.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#reschedules"></see></summary>
    let reschedules =
        Namespaced_IRI.parse _namespace_name "reschedules" |> NamespacedName

    /// <summary>
    /// A relationship between a SubmittedTask and a Scheduler.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#scheduledBy"></see></summary>
    let scheduledBy =
        Namespaced_IRI.parse _namespace_name "scheduledBy" |> NamespacedName

    /// <summary>
    /// The date and time of a Status.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#startTime"></see></summary>
    let startTime = Namespaced_IRI.parse _namespace_name "startTime" |> NamespacedName

    /// <summary>
    /// The starting interval time of an AggregatedMeasurement.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#startingInterval"></see></summary>
    let startingInterval =
        Namespaced_IRI.parse _namespace_name "startingInterval" |> NamespacedName

    /// <summary>
    /// The status code of a Status.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#statusCode"></see></summary>
    let statusCode = Namespaced_IRI.parse _namespace_name "statusCode" |> NamespacedName

    /// <summary>
    /// The time step resolution of an AggregatedMeasurement.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#timeStepResolution"></see></summary>
    let timeStepResolution =
        Namespaced_IRI.parse _namespace_name "timeStepResolution" |> NamespacedName

    /// <summary>
    /// A triggered event relationship about Rescheduling from a Monitor.
    /// <see href="https://glaciation-project.eu/MetadataReferenceModel#triggersReschedule"></see></summary>
    let triggersReschedule =
        Namespaced_IRI.parse _namespace_name "triggersReschedule" |> NamespacedName

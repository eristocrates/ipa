namespace https.glaciation_project.eu.MetadataReferenceModel.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module glc =
    let _namespace_iri = Namespace_Iri glc |> NamespaceIRI

    /// <summary>
    ///   <para>glc:AggregatedMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents any AggregatedMeasurement, by using an AggregatedFunction, a time interval and time step resolution."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AggregatedMeasurement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#AggregatedMeasurement">https://glaciation-project.eu/MetadataReferenceModel#AggregatedMeasurement</seealso>
    let AggregatedMeasurement =
        Prefixed_Name(glc, "AggregatedMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>glc:Aspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It describes the Aspect of a Contstraint, e.g., time, power consumption."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Aspect"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#Aspect">https://glaciation-project.eu/MetadataReferenceModel#Aspect</seealso>
    let Aspect = Prefixed_Name(glc, "Aspect") |> PrefixedName
    /// <summary>
    ///   <para>glc:AssignedTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An AssignedTask that will be performed by using some Resources and will be based on some Constraints."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AssignedTask"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#AssignedTask">https://glaciation-project.eu/MetadataReferenceModel#AssignedTask</seealso>
    let AssignedTask = Prefixed_Name(glc, "AssignedTask") |> PrefixedName
    /// <summary>
    ///   <para>glc:Class</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A generic Class for the GLACIATION project"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#Class">https://glaciation-project.eu/MetadataReferenceModel#Class</seealso>
    let Class = Prefixed_Name(glc, "Class") |> PrefixedName
    /// <summary>
    ///   <para>glc:Constraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"For representing the Constraint(s) of a Task."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Constraint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#Constraint">https://glaciation-project.eu/MetadataReferenceModel#Constraint</seealso>
    let Constraint = Prefixed_Name(glc, "Constraint") |> PrefixedName
    /// <summary>
    ///   <para>glc:ElectricalGrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It represents an electrical grid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Electrical Grid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#ElectricalGrid">https://glaciation-project.eu/MetadataReferenceModel#ElectricalGrid</seealso>
    let ElectricalGrid = Prefixed_Name(glc, "ElectricalGrid") |> PrefixedName

    /// <summary>
    ///   <para>glc:EnergyPowerGenerationResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It represents an energy resource that generates power"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Energy Power Generation Resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#EnergyPowerGenerationResource">https://glaciation-project.eu/MetadataReferenceModel#EnergyPowerGenerationResource</seealso>
    let EnergyPowerGenerationResource =
        Prefixed_Name(glc, "EnergyPowerGenerationResource") |> PrefixedName

    /// <summary>
    ///   <para>glc:EnergyResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It represents an energy resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Energy Resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#EnergyResource">https://glaciation-project.eu/MetadataReferenceModel#EnergyResource</seealso>
    let EnergyResource = Prefixed_Name(glc, "EnergyResource") |> PrefixedName
    /// <summary>
    ///   <para>glc:HardConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"For representing the HardConstraints of a Task."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"HardConstraint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#HardConstraint">https://glaciation-project.eu/MetadataReferenceModel#HardConstraint</seealso>
    let HardConstraint = Prefixed_Name(glc, "HardConstraint") |> PrefixedName
    /// <summary>
    ///   <para>glc:Measurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents any Measurement, e.g., for energy."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Measurement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#Measurement">https://glaciation-project.eu/MetadataReferenceModel#Measurement</seealso>
    let Measurement = Prefixed_Name(glc, "Measurement") |> PrefixedName
    /// <summary>
    ///   <para>glc:MeasurementProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a MeasurementProperty, e.g., allocated CPU, energy, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MeasurementProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#MeasurementProperty">https://glaciation-project.eu/MetadataReferenceModel#MeasurementProperty</seealso>
    let MeasurementProperty = Prefixed_Name(glc, "MeasurementProperty") |> PrefixedName
    /// <summary>
    ///   <para>glc:MeasurementUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a MeasurementUnit, e.g., Kwh."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MeasurementUnit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#MeasurementUnit">https://glaciation-project.eu/MetadataReferenceModel#MeasurementUnit</seealso>
    let MeasurementUnit = Prefixed_Name(glc, "MeasurementUnit") |> PrefixedName
    /// <summary>
    ///   <para>glc:MeasuringResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It represents any WorkProducingResource that can perform Measurements."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MeasuringResource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#MeasuringResource">https://glaciation-project.eu/MetadataReferenceModel#MeasuringResource</seealso>
    let MeasuringResource = Prefixed_Name(glc, "MeasuringResource") |> PrefixedName
    /// <summary>
    ///   <para>glc:Monitor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents an entity that monitors an AssignedTask."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Monitor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#Monitor">https://glaciation-project.eu/MetadataReferenceModel#Monitor</seealso>
    let Monitor = Prefixed_Name(glc, "Monitor") |> PrefixedName

    /// <summary>
    ///   <para>glc:NonWorkProducingResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It represents any NonWorkProducingResource (e.g., dataset)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NonWorkProducingResource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#NonWorkProducingResource">https://glaciation-project.eu/MetadataReferenceModel#NonWorkProducingResource</seealso>
    let NonWorkProducingResource =
        Prefixed_Name(glc, "NonWorkProducingResource") |> PrefixedName

    /// <summary>
    ///   <para>glc:Resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It represents any Resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#Resource">https://glaciation-project.eu/MetadataReferenceModel#Resource</seealso>
    let Resource = Prefixed_Name(glc, "Resource") |> PrefixedName
    /// <summary>
    ///   <para>glc:Scheduler</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Responsible for Scheduling a SubmittedTask and for managing the Resources."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Scheduler"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#Scheduler">https://glaciation-project.eu/MetadataReferenceModel#Scheduler</seealso>
    let Scheduler = Prefixed_Name(glc, "Scheduler") |> PrefixedName
    /// <summary>
    ///   <para>glc:Site</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It represents any Site, e.g., a location, an island, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Site"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#Site">https://glaciation-project.eu/MetadataReferenceModel#Site</seealso>
    let Site = Prefixed_Name(glc, "Site") |> PrefixedName
    /// <summary>
    ///   <para>glc:SoftConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"For representing the SoftConstraints of a Task."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SoftConstraint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#SoftConstraint">https://glaciation-project.eu/MetadataReferenceModel#SoftConstraint</seealso>
    let SoftConstraint = Prefixed_Name(glc, "SoftConstraint") |> PrefixedName

    /// <summary>
    ///   <para>glc:SoftConstraintComposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It describes the composition of SoftConstraints, e.g., the order of soft constraings according to a given preference priority, Pareto, Pareto optimal, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SoftConstraintComposition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#SoftConstraintComposition">https://glaciation-project.eu/MetadataReferenceModel#SoftConstraintComposition</seealso>
    let SoftConstraintComposition =
        Prefixed_Name(glc, "SoftConstraintComposition") |> PrefixedName

    /// <summary>
    ///   <para>glc:Status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents information about a specific Status over a given time interval."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#Status">https://glaciation-project.eu/MetadataReferenceModel#Status</seealso>
    let Status = Prefixed_Name(glc, "Status") |> PrefixedName
    /// <summary>
    ///   <para>glc:SubmittedTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Submitted Task that will be processed by a Scheduler."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SubmittedTask"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#SubmittedTask">https://glaciation-project.eu/MetadataReferenceModel#SubmittedTask</seealso>
    let SubmittedTask = Prefixed_Name(glc, "SubmittedTask") |> PrefixedName
    /// <summary>
    ///   <para>glc:Task</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It describes any Task that has Constraints and a Status."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Task"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#Task">https://glaciation-project.eu/MetadataReferenceModel#Task</seealso>
    let Task = Prefixed_Name(glc, "Task") |> PrefixedName

    /// <summary>
    ///   <para>glc:WorkProducingResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It represents any WorkProducingResource, e.g., a node, a CPU, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"WorkProducingResource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#WorkProducingResource">https://glaciation-project.eu/MetadataReferenceModel#WorkProducingResource</seealso>
    let WorkProducingResource =
        Prefixed_Name(glc, "WorkProducingResource") |> PrefixedName

    /// <summary>
    ///   <para>glc:assigns</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relationship between a Scheduler and an AssignedTask."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"assigns"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#assigns">https://glaciation-project.eu/MetadataReferenceModel#assigns</seealso>
    let assigns = Prefixed_Name(glc, "assigns") |> PrefixedName
    /// <summary>
    ///   <para>glc:composedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"For keeping information about the SoftConstraints that are included in a Composition."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"composedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#composedBy">https://glaciation-project.eu/MetadataReferenceModel#composedBy</seealso>
    let composedBy = Prefixed_Name(glc, "composedBy") |> PrefixedName
    /// <summary>
    ///   <para>glc:consumes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A property for recording the Resource(s) of each AssignedTask."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"consumes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#consumes">https://glaciation-project.eu/MetadataReferenceModel#consumes</seealso>
    let consumes = Prefixed_Name(glc, "consumes") |> PrefixedName
    /// <summary>
    ///   <para>glc:consumesEnergyFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The grid where a work producing resource consumes energy from"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"consumesEnergyFrom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#consumesEnergyFrom">https://glaciation-project.eu/MetadataReferenceModel#consumesEnergyFrom</seealso>
    let consumesEnergyFrom = Prefixed_Name(glc, "consumesEnergyFrom") |> PrefixedName
    /// <summary>
    ///   <para>glc:endTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The end time of a Status of any Class."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"endTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#endTime">https://glaciation-project.eu/MetadataReferenceModel#endTime</seealso>
    let endTime = Prefixed_Name(glc, "endTime") |> PrefixedName
    /// <summary>
    ///   <para>glc:endingInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The ending interval time of an AggregatedMeasurement."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"endingInterval"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#endingInterval">https://glaciation-project.eu/MetadataReferenceModel#endingInterval</seealso>
    let endingInterval = Prefixed_Name(glc, "endingInterval") |> PrefixedName

    /// <summary>
    ///   <para>glc:hasAggregatedFuntion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The AggregatedFunction of an AggregatedMeasurement."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasAggregatedFuntion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#hasAggregatedFuntion">https://glaciation-project.eu/MetadataReferenceModel#hasAggregatedFuntion</seealso>
    let hasAggregatedFuntion =
        Prefixed_Name(glc, "hasAggregatedFuntion") |> PrefixedName

    /// <summary>
    ///   <para>glc:hasAspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"For keeping information about the Aspect of each Constraint, e.g., time, power consumption."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasAspect"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#hasAspect">https://glaciation-project.eu/MetadataReferenceModel#hasAspect</seealso>
    let hasAspect = Prefixed_Name(glc, "hasAspect") |> PrefixedName
    /// <summary>
    ///   <para>glc:hasComposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"For keeping information about the Composition of the SoftConstraints of a Task."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasComposition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#hasComposition">https://glaciation-project.eu/MetadataReferenceModel#hasComposition</seealso>
    let hasComposition = Prefixed_Name(glc, "hasComposition") |> PrefixedName
    /// <summary>
    ///   <para>glc:hasConfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The Configuration of any instance of a Class, e.g., Task, Resource, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasConfiguration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#hasConfiguration">https://glaciation-project.eu/MetadataReferenceModel#hasConfiguration</seealso>
    let hasConfiguration = Prefixed_Name(glc, "hasConfiguration") |> PrefixedName
    /// <summary>
    ///   <para>glc:hasConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relationship for recording all the Constraints of a Task."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasConstraint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#hasConstraint">https://glaciation-project.eu/MetadataReferenceModel#hasConstraint</seealso>
    let hasConstraint = Prefixed_Name(glc, "hasConstraint") |> PrefixedName
    /// <summary>
    ///   <para>glc:hasDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The Description of any entity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasDescription"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#hasDescription">https://glaciation-project.eu/MetadataReferenceModel#hasDescription</seealso>
    let hasDescription = Prefixed_Name(glc, "hasDescription") |> PrefixedName
    /// <summary>
    ///   <para>glc:hasID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The ID of any entity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#hasID">https://glaciation-project.eu/MetadataReferenceModel#hasID</seealso>
    let hasID = Prefixed_Name(glc, "hasID") |> PrefixedName

    /// <summary>
    ///   <para>glc:hasResourceMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relationship between a Resource and a Measurement."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasResourceMeasurement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#hasResourceMeasurement">https://glaciation-project.eu/MetadataReferenceModel#hasResourceMeasurement</seealso>
    let hasResourceMeasurement =
        Prefixed_Name(glc, "hasResourceMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>glc:hasStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relationship between any Class and its Status."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasStatus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#hasStatus">https://glaciation-project.eu/MetadataReferenceModel#hasStatus</seealso>
    let hasStatus = Prefixed_Name(glc, "hasStatus") |> PrefixedName
    /// <summary>
    ///   <para>glc:hasSubResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationships for recording the SubResource(s) of each Resource (e.g, the hardware of a node)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasSubResource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#hasSubResource">https://glaciation-project.eu/MetadataReferenceModel#hasSubResource</seealso>
    let hasSubResource = Prefixed_Name(glc, "hasSubResource") |> PrefixedName
    /// <summary>
    ///   <para>glc:hasTaskMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relationship between a Task and a Measurement."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasTaskMeasurement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#hasTaskMeasurement">https://glaciation-project.eu/MetadataReferenceModel#hasTaskMeasurement</seealso>
    let hasTaskMeasurement = Prefixed_Name(glc, "hasTaskMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>glc:hasTaskPredictedMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relationship for recording the PredictedMeasurements of a Task."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasTaskPredictedMeasurement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#hasTaskPredictedMeasurement">https://glaciation-project.eu/MetadataReferenceModel#hasTaskPredictedMeasurement</seealso>
    let hasTaskPredictedMeasurement =
        Prefixed_Name(glc, "hasTaskPredictedMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>glc:hasTaskRealizedMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relationship for recording the RealizedMeasurements (actual measurements) of a Task."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasTaskRealizedMeasurement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#hasTaskRealizedMeasurement">https://glaciation-project.eu/MetadataReferenceModel#hasTaskRealizedMeasurement</seealso>
    let hasTaskRealizedMeasurement =
        Prefixed_Name(glc, "hasTaskRealizedMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>glc:hasTimestamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The date and time of a Measurement."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasTimestamp"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#hasTimestamp">https://glaciation-project.eu/MetadataReferenceModel#hasTimestamp</seealso>
    let hasTimestamp = Prefixed_Name(glc, "hasTimestamp") |> PrefixedName
    /// <summary>
    ///   <para>glc:hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The Value of a Measurement."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasValue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#hasValue">https://glaciation-project.eu/MetadataReferenceModel#hasValue</seealso>
    let hasValue = Prefixed_Name(glc, "hasValue") |> PrefixedName
    /// <summary>
    ///   <para>glc:isLocatedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The location of a Work Producing Resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isLocatedIn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#isLocatedIn">https://glaciation-project.eu/MetadataReferenceModel#isLocatedIn</seealso>
    let isLocatedIn = Prefixed_Name(glc, "isLocatedIn") |> PrefixedName
    /// <summary>
    ///   <para>glc:makesMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relationship between a MeasuringResource and a Measurement."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"makesMeasurement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#makesMeasurement">https://glaciation-project.eu/MetadataReferenceModel#makesMeasurement</seealso>
    let makesMeasurement = Prefixed_Name(glc, "makesMeasurement") |> PrefixedName
    /// <summary>
    ///   <para>glc:manages</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relationship between a Scheduler and a Resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"manages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#manages">https://glaciation-project.eu/MetadataReferenceModel#manages</seealso>
    let manages = Prefixed_Name(glc, "manages") |> PrefixedName
    /// <summary>
    ///   <para>glc:measuredIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"For recording the MeasurimentUnit of each Measurement."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"measuredIn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#measuredIn">https://glaciation-project.eu/MetadataReferenceModel#measuredIn</seealso>
    let measuredIn = Prefixed_Name(glc, "measuredIn") |> PrefixedName
    /// <summary>
    ///   <para>glc:monitors</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"For recording which Monitor tracks an AssignedTask."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"monitors"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#monitors">https://glaciation-project.eu/MetadataReferenceModel#monitors</seealso>
    let monitors = Prefixed_Name(glc, "monitors") |> PrefixedName
    /// <summary>
    ///   <para>glc:produces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"For keeping information about the production Resource, e.g., the output, of an AssignedTask."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"produces"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#produces">https://glaciation-project.eu/MetadataReferenceModel#produces</seealso>
    let produces = Prefixed_Name(glc, "produces") |> PrefixedName
    /// <summary>
    ///   <para>glc:relatesToConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"For keeping information about the Constraint that each Measurement relates to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"relatesToConstraint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#relatesToConstraint">https://glaciation-project.eu/MetadataReferenceModel#relatesToConstraint</seealso>
    let relatesToConstraint = Prefixed_Name(glc, "relatesToConstraint") |> PrefixedName

    /// <summary>
    ///   <para>glc:relatesToMeasurementProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"For recording the MeasurementProperty of each Measurement."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"relatesToMeasurementProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#relatesToMeasurementProperty">https://glaciation-project.eu/MetadataReferenceModel#relatesToMeasurementProperty</seealso>
    let relatesToMeasurementProperty =
        Prefixed_Name(glc, "relatesToMeasurementProperty") |> PrefixedName

    /// <summary>
    ///   <para>glc:reschedules</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relationship between a Scheduler and an AssignedTask that concerns rescheduling."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"reschedules"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#reschedules">https://glaciation-project.eu/MetadataReferenceModel#reschedules</seealso>
    let reschedules = Prefixed_Name(glc, "reschedules") |> PrefixedName
    /// <summary>
    ///   <para>glc:scheduledBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relationship between a SubmittedTask and a Scheduler."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"scheduledBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#scheduledBy">https://glaciation-project.eu/MetadataReferenceModel#scheduledBy</seealso>
    let scheduledBy = Prefixed_Name(glc, "scheduledBy") |> PrefixedName
    /// <summary>
    ///   <para>glc:startTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The date and time of a Status."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"startTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#startTime">https://glaciation-project.eu/MetadataReferenceModel#startTime</seealso>
    let startTime = Prefixed_Name(glc, "startTime") |> PrefixedName
    /// <summary>
    ///   <para>glc:startingInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The starting interval time of an AggregatedMeasurement."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"startingInterval"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#startingInterval">https://glaciation-project.eu/MetadataReferenceModel#startingInterval</seealso>
    let startingInterval = Prefixed_Name(glc, "startingInterval") |> PrefixedName
    /// <summary>
    ///   <para>glc:statusCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The status code of a Status."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"statusCode"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#statusCode">https://glaciation-project.eu/MetadataReferenceModel#statusCode</seealso>
    let statusCode = Prefixed_Name(glc, "statusCode") |> PrefixedName
    /// <summary>
    ///   <para>glc:timeStepResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The time step resolution of an AggregatedMeasurement."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"timeStepResolution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#timeStepResolution">https://glaciation-project.eu/MetadataReferenceModel#timeStepResolution</seealso>
    let timeStepResolution = Prefixed_Name(glc, "timeStepResolution") |> PrefixedName
    /// <summary>
    ///   <para>glc:triggersReschedule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A triggered event relationship about Rescheduling from a Monitor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"triggersReschedule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://glaciation-project.eu/MetadataReferenceModel#triggersReschedule">https://glaciation-project.eu/MetadataReferenceModel#triggersReschedule</seealso>
    let triggersReschedule = Prefixed_Name(glc, "triggersReschedule") |> PrefixedName

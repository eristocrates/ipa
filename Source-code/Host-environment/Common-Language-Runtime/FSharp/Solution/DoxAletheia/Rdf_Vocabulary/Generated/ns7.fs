namespace https.spdx.org.rdf._3._1.terms.SupplyChain.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ns7 =
    let _namespace_iri = Namespace_Iri ns7 |> NamespaceIRI
    /// <summary>
    ///   <para>spdx:SupplyChain/AssemblyAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"AssemblyAction represents the event of creating a product by assembling individual components."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/AssemblyAction">https://spdx.org/rdf/3.1/terms/SupplyChain/AssemblyAction</seealso>
    let AssemblyAction = Prefixed_Name(ns7, "AssemblyAction") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/AssemblyProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The AssemblyProcess represents the process of creating a product by assembling a set of components, potentially in a way that allows for at disassembly (at least partially)."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/AssemblyProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/AssemblyProcess</seealso>
    let AssemblyProcess = Prefixed_Name(ns7, "AssemblyProcess") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/BoundaryCrossingAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An action of crossing a boundary is defined in this class."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/BoundaryCrossingAction">https://spdx.org/rdf/3.1/terms/SupplyChain/BoundaryCrossingAction</seealso>
    let BoundaryCrossingAction =
        Prefixed_Name(ns7, "BoundaryCrossingAction") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/BoundaryDefinitionAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"The boundary definition is used to define boundaries."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/BoundaryDefinitionAction">https://spdx.org/rdf/3.1/terms/SupplyChain/BoundaryDefinitionAction</seealso>
    let BoundaryDefinitionAction =
        Prefixed_Name(ns7, "BoundaryDefinitionAction") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/BoundaryDefinitionProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Boundary Definition Process refers to the process class used to produce boundaries."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/BoundaryDefinitionProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/BoundaryDefinitionProcess</seealso>
    let BoundaryDefinitionProcess =
        Prefixed_Name(ns7, "BoundaryDefinitionProcess") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/ChangeAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An actual change to a product."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/ChangeAction">https://spdx.org/rdf/3.1/terms/SupplyChain/ChangeAction</seealso>
    let ChangeAction = Prefixed_Name(ns7, "ChangeAction") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/ChangeProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A prescribed change to a product."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/ChangeProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/ChangeProcess</seealso>
    let ChangeProcess = Prefixed_Name(ns7, "ChangeProcess") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/CreateAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"CreationAction represents an event of product creation."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/CreateAction">https://spdx.org/rdf/3.1/terms/SupplyChain/CreateAction</seealso>
    let CreateAction = Prefixed_Name(ns7, "CreateAction") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/CreateProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The CreateProcess refers to the abstract process class that can be used to represent the process of creation of a product."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/CreateProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/CreateProcess</seealso>
    let CreateProcess = Prefixed_Name(ns7, "CreateProcess") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/DefinedStateProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"This process is used to determine the state of an affected Element."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/DefinedStateProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/DefinedStateProcess</seealso>
    let DefinedStateProcess = Prefixed_Name(ns7, "DefinedStateProcess") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/DestroyAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"The record of destruction is entered in this action."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/DestroyAction">https://spdx.org/rdf/3.1/terms/SupplyChain/DestroyAction</seealso>
    let DestroyAction = Prefixed_Name(ns7, "DestroyAction") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/DestroyProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The destruction process is defined in this process."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/DestroyProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/DestroyProcess</seealso>
    let DestroyProcess = Prefixed_Name(ns7, "DestroyProcess") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/HarvestAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"HarvestAction represents the act of creating a product by directly extracting goods or materials from nature."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/HarvestAction">https://spdx.org/rdf/3.1/terms/SupplyChain/HarvestAction</seealso>
    let HarvestAction = Prefixed_Name(ns7, "HarvestAction") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/HarvestProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Harvest is the process of extracting goods or products from nature."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/HarvestProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/HarvestProcess</seealso>
    let HarvestProcess = Prefixed_Name(ns7, "HarvestProcess") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/InspectionAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An inspection action refers to a specific activity or set of activities performed during an inspection to examine, verify, or evaluate an item, process, or system."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/InspectionAction">https://spdx.org/rdf/3.1/terms/SupplyChain/InspectionAction</seealso>
    let InspectionAction = Prefixed_Name(ns7, "InspectionAction") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/InspectionProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"Inspection Process defines specific various processes needed to satisfy the inspection requirements for a specific product or service."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/InspectionProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/InspectionProcess</seealso>
    let InspectionProcess = Prefixed_Name(ns7, "InspectionProcess") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/InstantiateVirtualHardwareProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that describes an InstantiateVirtualHardwareProcess that is used to define VirtualHardware and its source."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/InstantiateVirtualHardwareProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/InstantiateVirtualHardwareProcess</seealso>
    let InstantiateVirtualHardwareProcess =
        Prefixed_Name(ns7, "InstantiateVirtualHardwareProcess") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/ManufactureAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ManufactureAction represents the act of creating a product by a manufacturing process."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/ManufactureAction">https://spdx.org/rdf/3.1/terms/SupplyChain/ManufactureAction</seealso>
    let ManufactureAction = Prefixed_Name(ns7, "ManufactureAction") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/ManufactureProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the process involved in manufacturing products."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/ManufactureProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/ManufactureProcess</seealso>
    let ManufactureProcess = Prefixed_Name(ns7, "ManufactureProcess") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/ModifyAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An actual alteration of a product."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/ModifyAction">https://spdx.org/rdf/3.1/terms/SupplyChain/ModifyAction</seealso>
    let ModifyAction = Prefixed_Name(ns7, "ModifyAction") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/ModifyProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A prescribed alteration of a product."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/ModifyProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/ModifyProcess</seealso>
    let ModifyProcess = Prefixed_Name(ns7, "ModifyProcess") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/OutOfSpecAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An out of specification action is defined in this class."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/OutOfSpecAction">https://spdx.org/rdf/3.1/terms/SupplyChain/OutOfSpecAction</seealso>
    let OutOfSpecAction = Prefixed_Name(ns7, "OutOfSpecAction") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/PlanAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A PlanAction involves the execution of a plan in relation to a PlanProcess."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/PlanAction">https://spdx.org/rdf/3.1/terms/SupplyChain/PlanAction</seealso>
    let PlanAction = Prefixed_Name(ns7, "PlanAction") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/PlanProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Process plans outline the stages of implementation or use related to a process."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/PlanProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/PlanProcess</seealso>
    let PlanProcess = Prefixed_Name(ns7, "PlanProcess") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/ReproduceAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Reproduction is the biological process by which organisms generate new individuals of the same species."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/ReproduceAction">https://spdx.org/rdf/3.1/terms/SupplyChain/ReproduceAction</seealso>
    let ReproduceAction = Prefixed_Name(ns7, "ReproduceAction") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/ReproduceProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Reproduction is the biological process by which living organisms produce offspring."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/ReproduceProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/ReproduceProcess</seealso>
    let ReproduceProcess = Prefixed_Name(ns7, "ReproduceProcess") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/ResolutionAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Products out of specification require a resolution action. This is the action of resolution."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/ResolutionAction">https://spdx.org/rdf/3.1/terms/SupplyChain/ResolutionAction</seealso>
    let ResolutionAction = Prefixed_Name(ns7, "ResolutionAction") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/ResponsibilityChangeAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"ResponsibilityChangeAction refers to the transfer of responsibility from one party to another."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/ResponsibilityChangeAction">https://spdx.org/rdf/3.1/terms/SupplyChain/ResponsibilityChangeAction</seealso>
    let ResponsibilityChangeAction =
        Prefixed_Name(ns7, "ResponsibilityChangeAction") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/ResponsibilityChangeProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"ResponsibilityChangeProcess refers to the process of transferring responsibility from one party to another."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/ResponsibilityChangeProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/ResponsibilityChangeProcess</seealso>
    let ResponsibilityChangeProcess =
        Prefixed_Name(ns7, "ResponsibilityChangeProcess") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/ResponsibilityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"These categories help define sets Responsibility Type."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/ResponsibilityType">https://spdx.org/rdf/3.1/terms/SupplyChain/ResponsibilityType</seealso>
    let ResponsibilityType = Prefixed_Name(ns7, "ResponsibilityType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/ResponsibilityType/custody</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:SupplyChain/ResponsibilityType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Custody refers to the responsibility, control, and safekeeping of an asset, person, or legal entity. It involves both physical possession and legal authority over something or someone."</para>
    /// labels<para>"custody"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/ResponsibilityType/custody">https://spdx.org/rdf/3.1/terms/SupplyChain/ResponsibilityType/custody</seealso>
    let ``ResponsibilityType/custody`` =
        Prefixed_Name(ns7, "ResponsibilityType/custody") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/ResponsibilityType/ownership</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:SupplyChain/ResponsibilityType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Ownership refers to the legal right to control, manage, and benefit from an asset, resource, or responsibility. It establishes authority, accountability, and entitlements over something, whether it's property, a business, intellectual property, or responsibilities."</para>
    /// labels<para>"ownership"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/ResponsibilityType/ownership">https://spdx.org/rdf/3.1/terms/SupplyChain/ResponsibilityType/ownership</seealso>
    let ``ResponsibilityType/ownership`` =
        Prefixed_Name(ns7, "ResponsibilityType/ownership") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/State</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A state is an instance that describes what a system, component, subsystem, process, or project has achieved at any given time."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/State">https://spdx.org/rdf/3.1/terms/SupplyChain/State</seealso>
    let State = Prefixed_Name(ns7, "State") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/StateAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"This is the state of an affected Element at a specific moment in time."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/StateAction">https://spdx.org/rdf/3.1/terms/SupplyChain/StateAction</seealso>
    let StateAction = Prefixed_Name(ns7, "StateAction") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/StorageAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Records the storage of a product."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/StorageAction">https://spdx.org/rdf/3.1/terms/SupplyChain/StorageAction</seealso>
    let StorageAction = Prefixed_Name(ns7, "StorageAction") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/StorageProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"Prescribes the storage of a product."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/StorageProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/StorageProcess</seealso>
    let StorageProcess = Prefixed_Name(ns7, "StorageProcess") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/TestAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A test action is a specific action associated with a test."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/TestAction">https://spdx.org/rdf/3.1/terms/SupplyChain/TestAction</seealso>
    let TestAction = Prefixed_Name(ns7, "TestAction") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/TestProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Test Process defines the testing process for an element."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/TestProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/TestProcess</seealso>
    let TestProcess = Prefixed_Name(ns7, "TestProcess") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/TransportAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"An actual change to a product's location."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/TransportAction">https://spdx.org/rdf/3.1/terms/SupplyChain/TransportAction</seealso>
    let TransportAction = Prefixed_Name(ns7, "TransportAction") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/TransportProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"A prescribed change to a product's location."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/TransportProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/TransportProcess</seealso>
    let TransportProcess = Prefixed_Name(ns7, "TransportProcess") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/UseAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The action of product use."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/UseAction">https://spdx.org/rdf/3.1/terms/SupplyChain/UseAction</seealso>
    let UseAction = Prefixed_Name(ns7, "UseAction") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/UseProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Use Process defines actions used by elements."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/UseProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/UseProcess</seealso>
    let UseProcess = Prefixed_Name(ns7, "UseProcess") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/boundaryParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The boundary parameters define the area or region needed to describe a boundary."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/boundaryParameter">https://spdx.org/rdf/3.1/terms/SupplyChain/boundaryParameter</seealso>
    let boundaryParameter = Prefixed_Name(ns7, "boundaryParameter") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/current</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the individual, business, or organization who currently manages goods, services, or assets."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/current">https://spdx.org/rdf/3.1/terms/SupplyChain/current</seealso>
    let current = Prefixed_Name(ns7, "current") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/currentState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the state of an affected Element."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/currentState">https://spdx.org/rdf/3.1/terms/SupplyChain/currentState</seealso>
    let currentState = Prefixed_Name(ns7, "currentState") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/decisionProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is how the currentState of an affected Element is found."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/decisionProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/decisionProcess</seealso>
    let decisionProcess = Prefixed_Name(ns7, "decisionProcess") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/destructionPerformedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the agent that performed the act of destroying the item."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/destructionPerformedBy">https://spdx.org/rdf/3.1/terms/SupplyChain/destructionPerformedBy</seealso>
    let destructionPerformedBy =
        Prefixed_Name(ns7, "destructionPerformedBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/dropoffLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The location for dropping off or delivering a package or item."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/dropoffLocation">https://spdx.org/rdf/3.1/terms/SupplyChain/dropoffLocation</seealso>
    let dropoffLocation = Prefixed_Name(ns7, "dropoffLocation") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/forDropoffLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The location that an item will be dropping off or delivered."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/forDropoffLocation">https://spdx.org/rdf/3.1/terms/SupplyChain/forDropoffLocation</seealso>
    let forDropoffLocation = Prefixed_Name(ns7, "forDropoffLocation") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/forPickupLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The location for picking up a package or item."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/forPickupLocation">https://spdx.org/rdf/3.1/terms/SupplyChain/forPickupLocation</seealso>
    let forPickupLocation = Prefixed_Name(ns7, "forPickupLocation") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/pickupLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The location for picking up a package or item."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/pickupLocation">https://spdx.org/rdf/3.1/terms/SupplyChain/pickupLocation</seealso>
    let pickupLocation = Prefixed_Name(ns7, "pickupLocation") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/plannedCurrent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the planned individual, business, or organization who currently manages goods, services, or assets."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/plannedCurrent">https://spdx.org/rdf/3.1/terms/SupplyChain/plannedCurrent</seealso>
    let plannedCurrent = Prefixed_Name(ns7, "plannedCurrent") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/plannedInspectionLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The planned location that a good, product or material is inspected."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/plannedInspectionLocation">https://spdx.org/rdf/3.1/terms/SupplyChain/plannedInspectionLocation</seealso>
    let plannedInspectionLocation =
        Prefixed_Name(ns7, "plannedInspectionLocation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/plannedPrevious</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the planned individual, business, or organization who was previously managing goods, services, or assets."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/plannedPrevious">https://spdx.org/rdf/3.1/terms/SupplyChain/plannedPrevious</seealso>
    let plannedPrevious = Prefixed_Name(ns7, "plannedPrevious") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/plannedProductOfResponsibilityChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the planned product associated with the change of responsibility."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/plannedProductOfResponsibilityChange">https://spdx.org/rdf/3.1/terms/SupplyChain/plannedProductOfResponsibilityChange</seealso>
    let plannedProductOfResponsibilityChange =
        Prefixed_Name(ns7, "plannedProductOfResponsibilityChange") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/plannedStorageLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The planned location that a good, product or material is stored."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/plannedStorageLocation">https://spdx.org/rdf/3.1/terms/SupplyChain/plannedStorageLocation</seealso>
    let plannedStorageLocation =
        Prefixed_Name(ns7, "plannedStorageLocation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/plannedTransportRoutes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A transport route refers to the planned path or network used to move people, goods, data, or resources from one location to another."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/plannedTransportRoutes">https://spdx.org/rdf/3.1/terms/SupplyChain/plannedTransportRoutes</seealso>
    let plannedTransportRoutes =
        Prefixed_Name(ns7, "plannedTransportRoutes") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/previous</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the individual, business, or organization who was previously managing goods, services, or assets."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/previous">https://spdx.org/rdf/3.1/terms/SupplyChain/previous</seealso>
    let previous = Prefixed_Name(ns7, "previous") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/responsibilityCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Requirements can be categorized into various types based on their focus, purpose, and scope."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/responsibilityCategory">https://spdx.org/rdf/3.1/terms/SupplyChain/responsibilityCategory</seealso>
    let responsibilityCategory =
        Prefixed_Name(ns7, "responsibilityCategory") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/responsibilityChangedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The element that has it's responsibility changed."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/responsibilityChangedOn">https://spdx.org/rdf/3.1/terms/SupplyChain/responsibilityChangedOn</seealso>
    let responsibilityChangedOn =
        Prefixed_Name(ns7, "responsibilityChangedOn") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/transportRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A transport route refers to the specific path or network used to move people, goods, data, or resources from one location to another."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/transportRoute">https://spdx.org/rdf/3.1/terms/SupplyChain/transportRoute</seealso>
    let transportRoute = Prefixed_Name(ns7, "transportRoute") |> PrefixedName
    /// <summary>
    ///   <para>spdx:SupplyChain/validState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The valid state for DefinedStateProcess."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/validState">https://spdx.org/rdf/3.1/terms/SupplyChain/validState</seealso>
    let validState = Prefixed_Name(ns7, "validState") |> PrefixedName

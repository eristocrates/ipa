namespace http.w3id.org.CEON.ontology._process.slash

open DoxAletheia

module ceon_process =
    let _namespace_name = "http://w3id.org/CEON/ontology/process/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/process/0.5/"></see>
    /// </summary>
    let ``_0.5/`` = _prefix "0.5/"
    /// <summary>
    /// A process of assembling.
    /// <see href="http://w3id.org/CEON/ontology/process/AssemblingProcess"></see></summary>
    let AssemblingProcess = _prefix "AssemblingProcess"
    /// <summary>
    /// Set of interrelated or interacting activities that transforms inputs into outputs.
    /// <see href="http://w3id.org/CEON/ontology/process/TransformationProcess"></see></summary>
    let TransformationProcess = _prefix "TransformationProcess"
    /// <summary>
    /// A process of buying a resource.
    /// <see href="http://w3id.org/CEON/ontology/process/BuyResourceProcess"></see></summary>
    let BuyResourceProcess = _prefix "BuyResourceProcess"
    /// <summary>
    /// An amount of CO2.
    /// <see href="http://w3id.org/CEON/ontology/process/CO2Emission"></see></summary>
    let CO2Emission = _prefix "CO2Emission"
    /// <summary>
    /// A resource that is needed as a catalyst by a process, but that is not considered the direct input or output of it.
    /// <see href="http://w3id.org/CEON/ontology/process/Catalyst"></see></summary>
    let Catalyst = _prefix "Catalyst"
    /// <summary>
    /// A process of a changing resource.
    /// <see href="http://w3id.org/CEON/ontology/process/ChangeResourceProcess"></see></summary>
    let ChangeResourceProcess = _prefix "ChangeResourceProcess"
    /// <summary>
    /// A contact process.
    /// <see href="http://w3id.org/CEON/ontology/process/ContactProcess"></see></summary>
    let ContactProcess = _prefix "ContactProcess"
    /// <summary>
    /// A process of deconstruction.
    /// <see href="http://w3id.org/CEON/ontology/process/DeconstructionProcess"></see></summary>
    let DeconstructionProcess = _prefix "DeconstructionProcess"
    /// <summary>
    /// A process of disassembling.
    /// <see href="http://w3id.org/CEON/ontology/process/DisassemblingProcess"></see></summary>
    let DisassemblingProcess = _prefix "DisassemblingProcess"
    /// <summary>
    /// A process of dismantling.
    /// <see href="http://w3id.org/CEON/ontology/process/DismantleProcess"></see></summary>
    let DismantleProcess = _prefix "DismantleProcess"
    /// <summary>
    /// A process of ensuring a claim.
    /// <see href="http://w3id.org/CEON/ontology/process/EnsureClaimProcess"></see></summary>
    let EnsureClaimProcess = _prefix "EnsureClaimProcess"
    /// <summary>
    /// A process of issuing a certificate.
    /// <see href="http://w3id.org/CEON/ontology/process/IssuingCertificateProcess"></see></summary>
    let IssuingCertificateProcess = _prefix "IssuingCertificateProcess"
    /// <summary>
    /// A process of manufacturing.
    /// <see href="http://w3id.org/CEON/ontology/process/ManufacturingProcess"></see></summary>
    let ManufacturingProcess = _prefix "ManufacturingProcess"
    /// <summary>
    /// A process of offsetting.
    /// <see href="http://w3id.org/CEON/ontology/process/OffsetProcess"></see></summary>
    let OffsetProcess = _prefix "OffsetProcess"
    /// <summary>
    /// A process of production.
    /// <see href="http://w3id.org/CEON/ontology/process/ProductionProcess"></see></summary>
    let ProductionProcess = _prefix "ProductionProcess"
    /// <summary>
    /// A process of recycling.
    /// <see href="http://w3id.org/CEON/ontology/process/RecycleProcess"></see></summary>
    let RecycleProcess = _prefix "RecycleProcess"
    /// <summary>
    /// A process of refurbishment.
    /// <see href="http://w3id.org/CEON/ontology/process/RefurbishmentProcess"></see></summary>
    let RefurbishmentProcess = _prefix "RefurbishmentProcess"
    /// <summary>
    /// A process of removing.
    /// <see href="http://w3id.org/CEON/ontology/process/RemoveProcess"></see></summary>
    let RemoveProcess = _prefix "RemoveProcess"
    /// <summary>
    /// A process of removing a resource.
    /// <see href="http://w3id.org/CEON/ontology/process/RemoveResourceProcess"></see></summary>
    let RemoveResourceProcess = _prefix "RemoveResourceProcess"
    /// <summary>
    /// A process of repairing.
    /// <see href="http://w3id.org/CEON/ontology/process/RepairProcess"></see></summary>
    let RepairProcess = _prefix "RepairProcess"
    /// <summary>
    /// A process of reselling.
    /// <see href="http://w3id.org/CEON/ontology/process/ResellProcess"></see></summary>
    let ResellProcess = _prefix "ResellProcess"
    /// <summary>
    /// A process of reusing.
    /// <see href="http://w3id.org/CEON/ontology/process/ReuseProcess"></see></summary>
    let ReuseProcess = _prefix "ReuseProcess"
    /// <summary>
    /// A process of selling a resource.
    /// <see href="http://w3id.org/CEON/ontology/process/SellResourceProcess"></see></summary>
    let SellResourceProcess = _prefix "SellResourceProcess"
    /// <summary>
    /// A process of servicing.
    /// <see href="http://w3id.org/CEON/ontology/process/ServiceProcess"></see></summary>
    let ServiceProcess = _prefix "ServiceProcess"
    /// <summary>
    /// A process of sharing a resource.
    /// <see href="http://w3id.org/CEON/ontology/process/ShareResourceProcess"></see></summary>
    let ShareResourceProcess = _prefix "ShareResourceProcess"
    /// <summary>
    /// A process of taking back.
    /// <see href="http://w3id.org/CEON/ontology/process/TakeBackProcess"></see></summary>
    let TakeBackProcess = _prefix "TakeBackProcess"
    /// <summary>
    /// A transition is a situation that creates a context for two additional different Situations, one Process, and at least one Object: one Situation is the state before the transition, the second Situation is the state after the transition, the Process is the invariance under some different transitions, in which at least one Object is situated. Finally, one or more time interval(s) may position the situations and the transitional event in time, and we may include the event that triggered the transition as well.
    /// <see href="http://w3id.org/CEON/ontology/process/Transition"></see></summary>
    let Transition = _prefix "Transition"
    /// <summary>
    /// A certain transition may affect objects, e.g. material that changes its state from one situation to another.
    /// <see href="http://w3id.org/CEON/ontology/process/affectsObject"></see></summary>
    let affectsObject = _prefix "affectsObject"
    /// <summary>
    /// The energy needed to perform a certain process.
    /// <see href="http://w3id.org/CEON/ontology/process/needsEnergy"></see></summary>
    let needsEnergy = _prefix "needsEnergy"
    /// <summary>
    /// The CO2 released or produced by the process.
    /// <see href="http://w3id.org/CEON/ontology/process/producesCO2"></see></summary>
    let producesCO2 = _prefix "producesCO2"
    /// <summary>
    /// The resource that is the output (product, i.e. what is produced) from a certain process.
    /// <see href="http://w3id.org/CEON/ontology/process/resultingResource"></see></summary>
    let resultingResource = _prefix "resultingResource"
    /// <summary>
    /// The catalyst used in a process.
    /// <see href="http://w3id.org/CEON/ontology/process/usesCatalyst"></see></summary>
    let usesCatalyst = _prefix "usesCatalyst"

namespace http.w3id.org.CEON.ontology._process.slash

open DoxAletheia.Rdf_Vocabulary

module ceon_process =
    let _namespace_name = "http://w3id.org/CEON/ontology/process/"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/process/0.5/"></see>
    /// </summary>
    let ``_0.5/`` = Namespaced_IRI.parse _namespace_name "0.5/" |> NamespacedName

    /// <summary>
    /// A process of assembling.
    /// <see href="http://w3id.org/CEON/ontology/process/AssemblingProcess"></see></summary>
    let AssemblingProcess =
        Namespaced_IRI.parse _namespace_name "AssemblingProcess" |> NamespacedName

    /// <summary>
    /// Set of interrelated or interacting activities that transforms inputs into outputs.
    /// <see href="http://w3id.org/CEON/ontology/process/TransformationProcess"></see></summary>
    let TransformationProcess =
        Namespaced_IRI.parse _namespace_name "TransformationProcess" |> NamespacedName

    /// <summary>
    /// A process of buying a resource.
    /// <see href="http://w3id.org/CEON/ontology/process/BuyResourceProcess"></see></summary>
    let BuyResourceProcess =
        Namespaced_IRI.parse _namespace_name "BuyResourceProcess" |> NamespacedName

    /// <summary>
    /// An amount of CO2.
    /// <see href="http://w3id.org/CEON/ontology/process/CO2Emission"></see></summary>
    let CO2Emission =
        Namespaced_IRI.parse _namespace_name "CO2Emission" |> NamespacedName

    /// <summary>
    /// A resource that is needed as a catalyst by a process, but that is not considered the direct input or output of it.
    /// <see href="http://w3id.org/CEON/ontology/process/Catalyst"></see></summary>
    let Catalyst = Namespaced_IRI.parse _namespace_name "Catalyst" |> NamespacedName

    /// <summary>
    /// A process of a changing resource.
    /// <see href="http://w3id.org/CEON/ontology/process/ChangeResourceProcess"></see></summary>
    let ChangeResourceProcess =
        Namespaced_IRI.parse _namespace_name "ChangeResourceProcess" |> NamespacedName

    /// <summary>
    /// A contact process.
    /// <see href="http://w3id.org/CEON/ontology/process/ContactProcess"></see></summary>
    let ContactProcess =
        Namespaced_IRI.parse _namespace_name "ContactProcess" |> NamespacedName

    /// <summary>
    /// A process of deconstruction.
    /// <see href="http://w3id.org/CEON/ontology/process/DeconstructionProcess"></see></summary>
    let DeconstructionProcess =
        Namespaced_IRI.parse _namespace_name "DeconstructionProcess" |> NamespacedName

    /// <summary>
    /// A process of disassembling.
    /// <see href="http://w3id.org/CEON/ontology/process/DisassemblingProcess"></see></summary>
    let DisassemblingProcess =
        Namespaced_IRI.parse _namespace_name "DisassemblingProcess" |> NamespacedName

    /// <summary>
    /// A process of dismantling.
    /// <see href="http://w3id.org/CEON/ontology/process/DismantleProcess"></see></summary>
    let DismantleProcess =
        Namespaced_IRI.parse _namespace_name "DismantleProcess" |> NamespacedName

    /// <summary>
    /// A process of ensuring a claim.
    /// <see href="http://w3id.org/CEON/ontology/process/EnsureClaimProcess"></see></summary>
    let EnsureClaimProcess =
        Namespaced_IRI.parse _namespace_name "EnsureClaimProcess" |> NamespacedName

    /// <summary>
    /// A process of issuing a certificate.
    /// <see href="http://w3id.org/CEON/ontology/process/IssuingCertificateProcess"></see></summary>
    let IssuingCertificateProcess =
        Namespaced_IRI.parse _namespace_name "IssuingCertificateProcess" |> NamespacedName

    /// <summary>
    /// A process of manufacturing.
    /// <see href="http://w3id.org/CEON/ontology/process/ManufacturingProcess"></see></summary>
    let ManufacturingProcess =
        Namespaced_IRI.parse _namespace_name "ManufacturingProcess" |> NamespacedName

    /// <summary>
    /// A process of offsetting.
    /// <see href="http://w3id.org/CEON/ontology/process/OffsetProcess"></see></summary>
    let OffsetProcess =
        Namespaced_IRI.parse _namespace_name "OffsetProcess" |> NamespacedName

    /// <summary>
    /// A process of production.
    /// <see href="http://w3id.org/CEON/ontology/process/ProductionProcess"></see></summary>
    let ProductionProcess =
        Namespaced_IRI.parse _namespace_name "ProductionProcess" |> NamespacedName

    /// <summary>
    /// A process of recycling.
    /// <see href="http://w3id.org/CEON/ontology/process/RecycleProcess"></see></summary>
    let RecycleProcess =
        Namespaced_IRI.parse _namespace_name "RecycleProcess" |> NamespacedName

    /// <summary>
    /// A process of refurbishment.
    /// <see href="http://w3id.org/CEON/ontology/process/RefurbishmentProcess"></see></summary>
    let RefurbishmentProcess =
        Namespaced_IRI.parse _namespace_name "RefurbishmentProcess" |> NamespacedName

    /// <summary>
    /// A process of removing.
    /// <see href="http://w3id.org/CEON/ontology/process/RemoveProcess"></see></summary>
    let RemoveProcess =
        Namespaced_IRI.parse _namespace_name "RemoveProcess" |> NamespacedName

    /// <summary>
    /// A process of removing a resource.
    /// <see href="http://w3id.org/CEON/ontology/process/RemoveResourceProcess"></see></summary>
    let RemoveResourceProcess =
        Namespaced_IRI.parse _namespace_name "RemoveResourceProcess" |> NamespacedName

    /// <summary>
    /// A process of repairing.
    /// <see href="http://w3id.org/CEON/ontology/process/RepairProcess"></see></summary>
    let RepairProcess =
        Namespaced_IRI.parse _namespace_name "RepairProcess" |> NamespacedName

    /// <summary>
    /// A process of reselling.
    /// <see href="http://w3id.org/CEON/ontology/process/ResellProcess"></see></summary>
    let ResellProcess =
        Namespaced_IRI.parse _namespace_name "ResellProcess" |> NamespacedName

    /// <summary>
    /// A process of reusing.
    /// <see href="http://w3id.org/CEON/ontology/process/ReuseProcess"></see></summary>
    let ReuseProcess =
        Namespaced_IRI.parse _namespace_name "ReuseProcess" |> NamespacedName

    /// <summary>
    /// A process of selling a resource.
    /// <see href="http://w3id.org/CEON/ontology/process/SellResourceProcess"></see></summary>
    let SellResourceProcess =
        Namespaced_IRI.parse _namespace_name "SellResourceProcess" |> NamespacedName

    /// <summary>
    /// A process of servicing.
    /// <see href="http://w3id.org/CEON/ontology/process/ServiceProcess"></see></summary>
    let ServiceProcess =
        Namespaced_IRI.parse _namespace_name "ServiceProcess" |> NamespacedName

    /// <summary>
    /// A process of sharing a resource.
    /// <see href="http://w3id.org/CEON/ontology/process/ShareResourceProcess"></see></summary>
    let ShareResourceProcess =
        Namespaced_IRI.parse _namespace_name "ShareResourceProcess" |> NamespacedName

    /// <summary>
    /// A process of taking back.
    /// <see href="http://w3id.org/CEON/ontology/process/TakeBackProcess"></see></summary>
    let TakeBackProcess =
        Namespaced_IRI.parse _namespace_name "TakeBackProcess" |> NamespacedName

    /// <summary>
    /// A transition is a situation that creates a context for two additional different Situations, one Process, and at least one Object: one Situation is the state before the transition, the second Situation is the state after the transition, the Process is the invariance under some different transitions, in which at least one Object is situated. Finally, one or more time interval(s) may position the situations and the transitional event in time, and we may include the event that triggered the transition as well.
    /// <see href="http://w3id.org/CEON/ontology/process/Transition"></see></summary>
    let Transition = Namespaced_IRI.parse _namespace_name "Transition" |> NamespacedName

    /// <summary>
    /// A certain transition may affect objects, e.g. material that changes its state from one situation to another.
    /// <see href="http://w3id.org/CEON/ontology/process/affectsObject"></see></summary>
    let affectsObject =
        Namespaced_IRI.parse _namespace_name "affectsObject" |> NamespacedName

    /// <summary>
    /// The energy needed to perform a certain process.
    /// <see href="http://w3id.org/CEON/ontology/process/needsEnergy"></see></summary>
    let needsEnergy =
        Namespaced_IRI.parse _namespace_name "needsEnergy" |> NamespacedName

    /// <summary>
    /// The CO2 released or produced by the process.
    /// <see href="http://w3id.org/CEON/ontology/process/producesCO2"></see></summary>
    let producesCO2 =
        Namespaced_IRI.parse _namespace_name "producesCO2" |> NamespacedName

    /// <summary>
    /// The resource that is the output (product, i.e. what is produced) from a certain process.
    /// <see href="http://w3id.org/CEON/ontology/process/resultingResource"></see></summary>
    let resultingResource =
        Namespaced_IRI.parse _namespace_name "resultingResource" |> NamespacedName

    /// <summary>
    /// The catalyst used in a process.
    /// <see href="http://w3id.org/CEON/ontology/process/usesCatalyst"></see></summary>
    let usesCatalyst =
        Namespaced_IRI.parse _namespace_name "usesCatalyst" |> NamespacedName

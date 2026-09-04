#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``ceon-process`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://w3id.org/CEON/ontology/process/" "ceon-process"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Assembling Process^^xsd:string</para>
    ///   <para>rdfs:comment : A process of assembling.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/process/AssemblingProcess">ceon-process:AssemblingProcess</a>
    /// </summary>
    let AssemblingProcess = _prefixId.prefix "AssemblingProcess"
    /// <summary>
    ///   <para>rdfs:label : Buy Resource Process^^xsd:string</para>
    ///   <para>rdfs:comment : A process of buying a resource.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/process/BuyResourceProcess">ceon-process:BuyResourceProcess</a>
    /// </summary>
    let BuyResourceProcess = _prefixId.prefix "BuyResourceProcess"
    /// <summary>
    ///   <para>rdfs:label : CO2 emission^^xsd:string</para>
    ///   <para>rdfs:comment : An amount of CO2.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/process/CO2Emission">ceon-process:CO2Emission</a>
    /// </summary>
    let CO2Emission = _prefixId.prefix "CO2Emission"
    /// <summary>
    ///   <para>rdfs:label : Catalyst^^xsd:string</para>
    ///   <para>rdfs:comment : A resource that is needed as a catalyst by a process, but that is not considered the direct input or output of it.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/process/Catalyst">ceon-process:Catalyst</a>
    /// </summary>
    let Catalyst = _prefixId.prefix "Catalyst"
    /// <summary>
    ///   <para>rdfs:label : Change Resource Process^^xsd:string</para>
    ///   <para>rdfs:comment : A process of a changing resource.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/process/ChangeResourceProcess">ceon-process:ChangeResourceProcess</a>
    /// </summary>
    let ChangeResourceProcess = _prefixId.prefix "ChangeResourceProcess"
    /// <summary>
    ///   <para>rdfs:label : Contact Process^^xsd:string</para>
    ///   <para>rdfs:comment : A contact process.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/process/ContactProcess">ceon-process:ContactProcess</a>
    /// </summary>
    let ContactProcess = _prefixId.prefix "ContactProcess"
    /// <summary>
    ///   <para>rdfs:label : Deconstruction Process^^xsd:string</para>
    ///   <para>rdfs:comment : A process of deconstruction.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/process/DeconstructionProcess">ceon-process:DeconstructionProcess</a>
    /// </summary>
    let DeconstructionProcess = _prefixId.prefix "DeconstructionProcess"
    /// <summary>
    ///   <para>rdfs:label : Disassembling Process^^xsd:string</para>
    ///   <para>rdfs:comment : A process of disassembling.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/process/DisassemblingProcess">ceon-process:DisassemblingProcess</a>
    /// </summary>
    let DisassemblingProcess = _prefixId.prefix "DisassemblingProcess"
    /// <summary>
    ///   <para>rdfs:label : Dismantle Process^^xsd:string</para>
    ///   <para>rdfs:comment : A process of dismantling.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/process/DismantleProcess">ceon-process:DismantleProcess</a>
    /// </summary>
    let DismantleProcess = _prefixId.prefix "DismantleProcess"
    /// <summary>
    ///   <para>rdfs:label : Ensure Claim Process^^xsd:string</para>
    ///   <para>rdfs:comment : A process of ensuring a claim.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/process/EnsureClaimProcess">ceon-process:EnsureClaimProcess</a>
    /// </summary>
    let EnsureClaimProcess = _prefixId.prefix "EnsureClaimProcess"
    /// <summary>
    ///   <para>rdfs:label : Issuing Certificate Process^^xsd:string</para>
    ///   <para>rdfs:comment : A process of issuing a certificate.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/process/IssuingCertificateProcess">ceon-process:IssuingCertificateProcess</a>
    /// </summary>
    let IssuingCertificateProcess = _prefixId.prefix "IssuingCertificateProcess"
    /// <summary>
    ///   <para>rdfs:label : Manufacturing Process^^xsd:string</para>
    ///   <para>rdfs:comment : A process of manufacturing.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/process/ManufacturingProcess">ceon-process:ManufacturingProcess</a>
    /// </summary>
    let ManufacturingProcess = _prefixId.prefix "ManufacturingProcess"
    /// <summary>
    ///   <para>rdfs:label : Offset Process^^xsd:string</para>
    ///   <para>rdfs:comment : A process of offsetting.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/process/OffsetProcess">ceon-process:OffsetProcess</a>
    /// </summary>
    let OffsetProcess = _prefixId.prefix "OffsetProcess"
    /// <summary>
    ///   <para>rdfs:label : Production Process^^xsd:string</para>
    ///   <para>rdfs:comment : A process of production.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/process/ProductionProcess">ceon-process:ProductionProcess</a>
    /// </summary>
    let ProductionProcess = _prefixId.prefix "ProductionProcess"
    /// <summary>
    ///   <para>rdfs:label : Recycle Process^^xsd:string</para>
    ///   <para>rdfs:comment : A process of recycling.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/process/RecycleProcess">ceon-process:RecycleProcess</a>
    /// </summary>
    let RecycleProcess = _prefixId.prefix "RecycleProcess"
    /// <summary>
    ///   <para>rdfs:label : Refurbishment Process^^xsd:string</para>
    ///   <para>rdfs:comment : A process of refurbishment.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/process/RefurbishmentProcess">ceon-process:RefurbishmentProcess</a>
    /// </summary>
    let RefurbishmentProcess = _prefixId.prefix "RefurbishmentProcess"
    /// <summary>
    ///   <para>rdfs:label : Remove Process^^xsd:string</para>
    ///   <para>rdfs:comment : A process of removing.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/process/RemoveProcess">ceon-process:RemoveProcess</a>
    /// </summary>
    let RemoveProcess = _prefixId.prefix "RemoveProcess"
    /// <summary>
    ///   <para>rdfs:label : Remove Resource Process^^xsd:string</para>
    ///   <para>rdfs:comment : A process of removing a resource.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/process/RemoveResourceProcess">ceon-process:RemoveResourceProcess</a>
    /// </summary>
    let RemoveResourceProcess = _prefixId.prefix "RemoveResourceProcess"
    /// <summary>
    ///   <para>rdfs:label : Repair Process^^xsd:string</para>
    ///   <para>rdfs:comment : A process of repairing.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/process/RepairProcess">ceon-process:RepairProcess</a>
    /// </summary>
    let RepairProcess = _prefixId.prefix "RepairProcess"
    /// <summary>
    ///   <para>rdfs:label : Resell Process^^xsd:string</para>
    ///   <para>rdfs:comment : A process of reselling.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/process/ResellProcess">ceon-process:ResellProcess</a>
    /// </summary>
    let ResellProcess = _prefixId.prefix "ResellProcess"
    /// <summary>
    ///   <para>rdfs:label : Reuse Process^^xsd:string</para>
    ///   <para>rdfs:comment : A process of reusing.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/process/ReuseProcess">ceon-process:ReuseProcess</a>
    /// </summary>
    let ReuseProcess = _prefixId.prefix "ReuseProcess"
    /// <summary>
    ///   <para>rdfs:label : Sell Resource Process^^xsd:string</para>
    ///   <para>rdfs:comment : A process of selling a resource.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/process/SellResourceProcess">ceon-process:SellResourceProcess</a>
    /// </summary>
    let SellResourceProcess = _prefixId.prefix "SellResourceProcess"
    /// <summary>
    ///   <para>rdfs:label : Service Process^^xsd:string</para>
    ///   <para>rdfs:comment : A process of servicing.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/process/ServiceProcess">ceon-process:ServiceProcess</a>
    /// </summary>
    let ServiceProcess = _prefixId.prefix "ServiceProcess"
    /// <summary>
    ///   <para>rdfs:label : Share Resource Process^^xsd:string</para>
    ///   <para>rdfs:comment : A process of sharing a resource.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/process/ShareResourceProcess">ceon-process:ShareResourceProcess</a>
    /// </summary>
    let ShareResourceProcess = _prefixId.prefix "ShareResourceProcess"
    /// <summary>
    ///   <para>rdfs:label : Take Back Process^^xsd:string</para>
    ///   <para>rdfs:comment : A process of taking back.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/process/TakeBackProcess">ceon-process:TakeBackProcess</a>
    /// </summary>
    let TakeBackProcess = _prefixId.prefix "TakeBackProcess"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://ref.gs1.org/epcis/Transformation^^xsd:string</para>
    ///   <para>rdfs:label : Transformation Process^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : ISO 59004:2024  - 3.5.5 process^^xsd:string</para>
    ///   <para>rdfs:comment : Set of interrelated or interacting activities that transforms inputs into outputs.</para>
    ///   <a href="http://w3id.org/CEON/ontology/process/TransformationProcess">ceon-process:TransformationProcess</a>
    /// </summary>
    let TransformationProcess = _prefixId.prefix "TransformationProcess"
    /// <summary>
    ///   <para>rdfs:label : Transition^^xsd:string</para>
    ///   <para>rdfs:comment : A transition is a situation that creates a context for two additional different Situations, one Process, and at least one Object: one Situation is the state before the transition, the second Situation is the state after the transition, the Process is the invariance under some different transitions, in which at least one Object is situated. Finally, one or more time interval(s) may position the situations and the transitional event in time, and we may include the event that triggered the transition as well.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/process/Transition">ceon-process:Transition</a>
    /// </summary>
    let Transition = _prefixId.prefix "Transition"
    /// <summary>
    ///   <para>rdfs:label : affects object^^xsd:string</para>
    ///   <para>rdfs:comment : A certain transition may affect objects, e.g. material that changes its state from one situation to another.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/process/affectsObject">ceon-process:affectsObject</a>
    /// </summary>
    let affectsObject = _prefixId.prefix "affectsObject"
    /// <summary>
    ///   <para>rdfs:label : needs energy^^xsd:string</para>
    ///   <para>rdfs:comment : The energy needed to perform a certain process.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/process/needsEnergy">ceon-process:needsEnergy</a>
    /// </summary>
    let needsEnergy = _prefixId.prefix "needsEnergy"
    /// <summary>
    ///   <para>rdfs:label : produces CO2^^xsd:string</para>
    ///   <para>rdfs:comment : The CO2 released or produced by the process.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/process/producesCO2">ceon-process:producesCO2</a>
    /// </summary>
    let producesCO2 = _prefixId.prefix "producesCO2"
    /// <summary>
    ///   <para>rdfs:label : resulting resource^^xsd:string</para>
    ///   <para>rdfs:comment : The resource that is the output (product, i.e. what is produced) from a certain process.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/process/resultingResource">ceon-process:resultingResource</a>
    /// </summary>
    let resultingResource = _prefixId.prefix "resultingResource"
    /// <summary>
    ///   <para>rdfs:label : uses catalyst^^xsd:string</para>
    ///   <para>rdfs:comment : The catalyst used in a process.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/process/usesCatalyst">ceon-process:usesCatalyst</a>
    /// </summary>
    let usesCatalyst = _prefixId.prefix "usesCatalyst"

namespace http.w3id.org.CEON.ontology._process.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ceon_process =
    let _namespace_iri = Namespace_Iri ceon_process |> NamespaceIRI
    /// <summary>
    ///   <para>ceon-process:0.5/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/process/0.5/">http://w3id.org/CEON/ontology/process/0.5/</seealso>
    let ``_0.5/`` = Prefixed_Name(ceon_process, "0.5/") |> PrefixedName
    /// <summary>
    ///   <para>ceon-process:CO2Emission</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An amount of CO2.</para>
    /// labels<para>CO2 emission</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/process/CO2Emission">http://w3id.org/CEON/ontology/process/CO2Emission</seealso>
    let CO2Emission = Prefixed_Name(ceon_process, "CO2Emission") |> PrefixedName

    /// <summary>
    ///   <para>ceon-process:ChangeResourceProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A process of a changing resource.</para>
    /// labels<para>Change Resource Process</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/process/ChangeResourceProcess">http://w3id.org/CEON/ontology/process/ChangeResourceProcess</seealso>
    let ChangeResourceProcess =
        Prefixed_Name(ceon_process, "ChangeResourceProcess") |> PrefixedName

    /// <summary>
    ///   <para>ceon-process:DeconstructionProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A process of deconstruction.</para>
    /// labels<para>Deconstruction Process</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/process/DeconstructionProcess">http://w3id.org/CEON/ontology/process/DeconstructionProcess</seealso>
    let DeconstructionProcess =
        Prefixed_Name(ceon_process, "DeconstructionProcess") |> PrefixedName

    /// <summary>
    ///   <para>ceon-process:ManufacturingProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A process of manufacturing.</para>
    /// labels<para>Manufacturing Process</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/process/ManufacturingProcess">http://w3id.org/CEON/ontology/process/ManufacturingProcess</seealso>
    let ManufacturingProcess =
        Prefixed_Name(ceon_process, "ManufacturingProcess") |> PrefixedName

    /// <summary>
    ///   <para>ceon-process:OffsetProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A process of offsetting.</para>
    /// labels<para>Offset Process</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/process/OffsetProcess">http://w3id.org/CEON/ontology/process/OffsetProcess</seealso>
    let OffsetProcess = Prefixed_Name(ceon_process, "OffsetProcess") |> PrefixedName

    /// <summary>
    ///   <para>ceon-process:ProductionProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A process of production.</para>
    /// labels<para>Production Process</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/process/ProductionProcess">http://w3id.org/CEON/ontology/process/ProductionProcess</seealso>
    let ProductionProcess =
        Prefixed_Name(ceon_process, "ProductionProcess") |> PrefixedName

    /// <summary>
    ///   <para>ceon-process:RemoveProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A process of removing.</para>
    /// labels<para>Remove Process</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/process/RemoveProcess">http://w3id.org/CEON/ontology/process/RemoveProcess</seealso>
    let RemoveProcess = Prefixed_Name(ceon_process, "RemoveProcess") |> PrefixedName
    /// <summary>
    ///   <para>ceon-process:RepairProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A process of repairing.</para>
    /// labels<para>Repair Process</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/process/RepairProcess">http://w3id.org/CEON/ontology/process/RepairProcess</seealso>
    let RepairProcess = Prefixed_Name(ceon_process, "RepairProcess") |> PrefixedName
    /// <summary>
    ///   <para>ceon-process:ResellProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A process of reselling.</para>
    /// labels<para>Resell Process</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/process/ResellProcess">http://w3id.org/CEON/ontology/process/ResellProcess</seealso>
    let ResellProcess = Prefixed_Name(ceon_process, "ResellProcess") |> PrefixedName
    /// <summary>
    ///   <para>ceon-process:ServiceProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A process of servicing.</para>
    /// labels<para>Service Process</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/process/ServiceProcess">http://w3id.org/CEON/ontology/process/ServiceProcess</seealso>
    let ServiceProcess = Prefixed_Name(ceon_process, "ServiceProcess") |> PrefixedName

    /// <summary>
    ///   <para>ceon-process:ShareResourceProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A process of sharing a resource.</para>
    /// labels<para>Share Resource Process</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/process/ShareResourceProcess">http://w3id.org/CEON/ontology/process/ShareResourceProcess</seealso>
    let ShareResourceProcess =
        Prefixed_Name(ceon_process, "ShareResourceProcess") |> PrefixedName

    /// <summary>
    ///   <para>ceon-process:Transition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A transition is a situation that creates a context for two additional different Situations, one Process, and at least one Object: one Situation is the state before the transition, the second Situation is the state after the transition, the Process is the invariance under some different transitions, in which at least one Object is situated. Finally, one or more time interval(s) may position the situations and the transitional event in time, and we may include the event that triggered the transition as well.</para>
    /// labels<para>Transition</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/process/Transition">http://w3id.org/CEON/ontology/process/Transition</seealso>
    let Transition = Prefixed_Name(ceon_process, "Transition") |> PrefixedName
    /// <summary>
    ///   <para>ceon-process:needsEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The energy needed to perform a certain process.</para>
    /// labels<para>needs energy</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/process/needsEnergy">http://w3id.org/CEON/ontology/process/needsEnergy</seealso>
    let needsEnergy = Prefixed_Name(ceon_process, "needsEnergy") |> PrefixedName

    /// <summary>
    ///   <para>ceon-process:resultingResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The resource that is the output (product, i.e. what is produced) from a certain process.</para>
    /// labels<para>resulting resource</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/process/resultingResource">http://w3id.org/CEON/ontology/process/resultingResource</seealso>
    let resultingResource =
        Prefixed_Name(ceon_process, "resultingResource") |> PrefixedName

    /// <summary>
    ///   <para>ceon-process:usesCatalyst</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The catalyst used in a process.</para>
    /// labels<para>uses catalyst</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/process/usesCatalyst">http://w3id.org/CEON/ontology/process/usesCatalyst</seealso>
    let usesCatalyst = Prefixed_Name(ceon_process, "usesCatalyst") |> PrefixedName

    /// <summary>
    ///   <para>ceon-process:TransformationProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Set of interrelated or interacting activities that transforms inputs into outputs.</para>
    /// labels<para>Transformation Process</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/process/TransformationProcess">http://w3id.org/CEON/ontology/process/TransformationProcess</seealso>
    let TransformationProcess =
        Prefixed_Name(ceon_process, "TransformationProcess") |> PrefixedName

    /// <summary>
    ///   <para>ceon-process:DismantleProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A process of dismantling.</para>
    /// labels<para>Dismantle Process</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/process/DismantleProcess">http://w3id.org/CEON/ontology/process/DismantleProcess</seealso>
    let DismantleProcess =
        Prefixed_Name(ceon_process, "DismantleProcess") |> PrefixedName

    /// <summary>
    ///   <para>ceon-process:SellResourceProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A process of selling a resource.</para>
    /// labels<para>Sell Resource Process</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/process/SellResourceProcess">http://w3id.org/CEON/ontology/process/SellResourceProcess</seealso>
    let SellResourceProcess =
        Prefixed_Name(ceon_process, "SellResourceProcess") |> PrefixedName

    /// <summary>
    ///   <para>ceon-process:TakeBackProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A process of taking back.</para>
    /// labels<para>Take Back Process</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/process/TakeBackProcess">http://w3id.org/CEON/ontology/process/TakeBackProcess</seealso>
    let TakeBackProcess = Prefixed_Name(ceon_process, "TakeBackProcess") |> PrefixedName

    /// <summary>
    ///   <para>ceon-process:RefurbishmentProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A process of refurbishment.</para>
    /// labels<para>Refurbishment Process</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/process/RefurbishmentProcess">http://w3id.org/CEON/ontology/process/RefurbishmentProcess</seealso>
    let RefurbishmentProcess =
        Prefixed_Name(ceon_process, "RefurbishmentProcess") |> PrefixedName

    /// <summary>
    ///   <para>ceon-process:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/process/">http://w3id.org/CEON/ontology/process/</seealso>
    let _prefix_iri = Prefixed_Name(ceon_process, "") |> PrefixedName

    /// <summary>
    ///   <para>ceon-process:AssemblingProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A process of assembling.</para>
    /// labels<para>Assembling Process</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/process/AssemblingProcess">http://w3id.org/CEON/ontology/process/AssemblingProcess</seealso>
    let AssemblingProcess =
        Prefixed_Name(ceon_process, "AssemblingProcess") |> PrefixedName

    /// <summary>
    ///   <para>ceon-process:BuyResourceProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A process of buying a resource.</para>
    /// labels<para>Buy Resource Process</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/process/BuyResourceProcess">http://w3id.org/CEON/ontology/process/BuyResourceProcess</seealso>
    let BuyResourceProcess =
        Prefixed_Name(ceon_process, "BuyResourceProcess") |> PrefixedName

    /// <summary>
    ///   <para>ceon-process:Catalyst</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A resource that is needed as a catalyst by a process, but that is not considered the direct input or output of it.</para>
    /// labels<para>Catalyst</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/process/Catalyst">http://w3id.org/CEON/ontology/process/Catalyst</seealso>
    let Catalyst = Prefixed_Name(ceon_process, "Catalyst") |> PrefixedName
    /// <summary>
    ///   <para>ceon-process:ContactProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A contact process.</para>
    /// labels<para>Contact Process</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/process/ContactProcess">http://w3id.org/CEON/ontology/process/ContactProcess</seealso>
    let ContactProcess = Prefixed_Name(ceon_process, "ContactProcess") |> PrefixedName

    /// <summary>
    ///   <para>ceon-process:DisassemblingProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A process of disassembling.</para>
    /// labels<para>Disassembling Process</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/process/DisassemblingProcess">http://w3id.org/CEON/ontology/process/DisassemblingProcess</seealso>
    let DisassemblingProcess =
        Prefixed_Name(ceon_process, "DisassemblingProcess") |> PrefixedName

    /// <summary>
    ///   <para>ceon-process:EnsureClaimProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A process of ensuring a claim.</para>
    /// labels<para>Ensure Claim Process</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/process/EnsureClaimProcess">http://w3id.org/CEON/ontology/process/EnsureClaimProcess</seealso>
    let EnsureClaimProcess =
        Prefixed_Name(ceon_process, "EnsureClaimProcess") |> PrefixedName

    /// <summary>
    ///   <para>ceon-process:IssuingCertificateProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A process of issuing a certificate.</para>
    /// labels<para>Issuing Certificate Process</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/process/IssuingCertificateProcess">http://w3id.org/CEON/ontology/process/IssuingCertificateProcess</seealso>
    let IssuingCertificateProcess =
        Prefixed_Name(ceon_process, "IssuingCertificateProcess") |> PrefixedName

    /// <summary>
    ///   <para>ceon-process:RecycleProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A process of recycling.</para>
    /// labels<para>Recycle Process</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/process/RecycleProcess">http://w3id.org/CEON/ontology/process/RecycleProcess</seealso>
    let RecycleProcess = Prefixed_Name(ceon_process, "RecycleProcess") |> PrefixedName

    /// <summary>
    ///   <para>ceon-process:RemoveResourceProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A process of removing a resource.</para>
    /// labels<para>Remove Resource Process</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/process/RemoveResourceProcess">http://w3id.org/CEON/ontology/process/RemoveResourceProcess</seealso>
    let RemoveResourceProcess =
        Prefixed_Name(ceon_process, "RemoveResourceProcess") |> PrefixedName

    /// <summary>
    ///   <para>ceon-process:ReuseProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A process of reusing.</para>
    /// labels<para>Reuse Process</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/process/ReuseProcess">http://w3id.org/CEON/ontology/process/ReuseProcess</seealso>
    let ReuseProcess = Prefixed_Name(ceon_process, "ReuseProcess") |> PrefixedName
    /// <summary>
    ///   <para>ceon-process:affectsObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A certain transition may affect objects, e.g. material that changes its state from one situation to another.</para>
    /// labels<para>affects object</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/process/affectsObject">http://w3id.org/CEON/ontology/process/affectsObject</seealso>
    let affectsObject = Prefixed_Name(ceon_process, "affectsObject") |> PrefixedName
    /// <summary>
    ///   <para>ceon-process:producesCO2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The CO2 released or produced by the process.</para>
    /// labels<para>produces CO2</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/process/producesCO2">http://w3id.org/CEON/ontology/process/producesCO2</seealso>
    let producesCO2 = Prefixed_Name(ceon_process, "producesCO2") |> PrefixedName

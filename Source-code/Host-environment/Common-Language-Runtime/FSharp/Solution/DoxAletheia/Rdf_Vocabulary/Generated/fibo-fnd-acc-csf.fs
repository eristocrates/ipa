namespace https.spec.edmcouncil.org.fibo.ontology.FND.Accounting.CashFlows.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_acc_csf =
    let _namespace_iri = Namespace_Iri fibo_fnd_acc_csf |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-acc-csf:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"CashFlows Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CashFlows/">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CashFlows/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_acc_csf, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-acc-csf:CashFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cash flow"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CashFlows/CashFlow">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CashFlows/CashFlow</seealso>
    let CashFlow = Prefixed_Name(fibo_fnd_acc_csf, "CashFlow") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-acc-csf:CashFlowStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cash flow structure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CashFlows/CashFlowStructure">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CashFlows/CashFlowStructure</seealso>
    let CashFlowStructure =
        Prefixed_Name(fibo_fnd_acc_csf, "CashFlowStructure") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-acc-csf:TriggeringEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"triggering event"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CashFlows/TriggeringEvent">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CashFlows/TriggeringEvent</seealso>
    let TriggeringEvent =
        Prefixed_Name(fibo_fnd_acc_csf, "TriggeringEvent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-acc-csf:hasSourceOfMoney</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has source of funds"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CashFlows/hasSourceOfMoney">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CashFlows/hasSourceOfMoney</seealso>
    let hasSourceOfMoney =
        Prefixed_Name(fibo_fnd_acc_csf, "hasSourceOfMoney") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-acc-csf:hasTargetOfMoney</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has target of funds"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CashFlows/hasTargetOfMoney">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CashFlows/hasTargetOfMoney</seealso>
    let hasTargetOfMoney =
        Prefixed_Name(fibo_fnd_acc_csf, "hasTargetOfMoney") |> PrefixedName

namespace http.eulersharp.sourceforge.net._2003._03swap.decisionSupport.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swapdecisionSupport =
    let _namespace_iri = Namespace_Iri swapdecisionSupport |> NamespaceIRI
    /// <summary>
    ///   <para>swapdecisionSupport:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#">http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#</seealso>
    let _prefix_iri = Prefixed_Name(swapdecisionSupport, "") |> PrefixedName

    /// <summary>
    ///   <para>swapdecisionSupport:ClinicalObservablesResultFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>clinical decision support observables result formula</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#ClinicalObservablesResultFormula">http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#ClinicalObservablesResultFormula</seealso>
    let ClinicalObservablesResultFormula =
        Prefixed_Name(swapdecisionSupport, "ClinicalObservablesResultFormula") |> PrefixedName

    /// <summary>
    ///   <para>swapdecisionSupport:Request</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>decision support request</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#Request">http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#Request</seealso>
    let Request = Prefixed_Name(swapdecisionSupport, "Request") |> PrefixedName

    /// <summary>
    ///   <para>swapdecisionSupport:ClinicalRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>clinical decision support request</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#ClinicalRequest">http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#ClinicalRequest</seealso>
    let ClinicalRequest =
        Prefixed_Name(swapdecisionSupport, "ClinicalRequest") |> PrefixedName

    /// <summary>
    ///   <para>swapdecisionSupport:beliefIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>E.g. ([quant:hasValue 9.660533530762310e-001]) decisionsupport:beliefIn i:Lomefloxacin_400mg_PO_UID_3D.</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#beliefIn">http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#beliefIn</seealso>
    let beliefIn = Prefixed_Name(swapdecisionSupport, "beliefIn") |> PrefixedName

    /// <summary>
    ///   <para>swapdecisionSupport:hasPatientStateResultFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#hasPatientStateResultFormula">http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#hasPatientStateResultFormula</seealso>
    let hasPatientStateResultFormula =
        Prefixed_Name(swapdecisionSupport, "hasPatientStateResultFormula") |> PrefixedName

    /// <summary>
    ///   <para>swapdecisionSupport:hasResultFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#hasResultFormula">http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#hasResultFormula</seealso>
    let hasResultFormula =
        Prefixed_Name(swapdecisionSupport, "hasResultFormula") |> PrefixedName

    /// <summary>
    ///   <para>swapdecisionSupport:Belief</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>belief probability</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#Belief">http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#Belief</seealso>
    let Belief = Prefixed_Name(swapdecisionSupport, "Belief") |> PrefixedName

    /// <summary>
    ///   <para>swapdecisionSupport:ObservablesResultFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>decision support observables result formula</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#ObservablesResultFormula">http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#ObservablesResultFormula</seealso>
    let ObservablesResultFormula =
        Prefixed_Name(swapdecisionSupport, "ObservablesResultFormula") |> PrefixedName

    /// <summary>
    ///   <para>swapdecisionSupport:hasObservablesResultFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#hasObservablesResultFormula">http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#hasObservablesResultFormula</seealso>
    let hasObservablesResultFormula =
        Prefixed_Name(swapdecisionSupport, "hasObservablesResultFormula") |> PrefixedName

    /// <summary>
    ///   <para>swapdecisionSupport:PatientStateResultFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>decision support patient state result formula</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#PatientStateResultFormula">http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#PatientStateResultFormula</seealso>
    let PatientStateResultFormula =
        Prefixed_Name(swapdecisionSupport, "PatientStateResultFormula") |> PrefixedName

    /// <summary>
    ///   <para>swapdecisionSupport:StateResultFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>decision support state result formula</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#StateResultFormula">http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#StateResultFormula</seealso>
    let StateResultFormula =
        Prefixed_Name(swapdecisionSupport, "StateResultFormula") |> PrefixedName

    /// <summary>
    ///   <para>swapdecisionSupport:ResultFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>decision support result formula</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#ResultFormula">http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#ResultFormula</seealso>
    let ResultFormula =
        Prefixed_Name(swapdecisionSupport, "ResultFormula") |> PrefixedName

    /// <summary>
    ///   <para>swapdecisionSupport:hasBelief</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#hasBelief">http://eulersharp.sourceforge.net/2003/03swap/decisionSupport#hasBelief</seealso>
    let hasBelief = Prefixed_Name(swapdecisionSupport, "hasBelief") |> PrefixedName

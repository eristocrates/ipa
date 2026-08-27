namespace https.spec.edmcouncil.org.fibo.ontology.ACTUS.ACTUSContractTerms.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_actus_act =
    let _namespace_iri = Namespace_Iri fibo_actus_act |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-actus-act:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"ACTUS Contract Terms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_actus_act, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSBusinessDayConvention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ACTUS business day convention"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSBusinessDayConvention">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSBusinessDayConvention</seealso>
    let ACTUSBusinessDayConvention =
        Prefixed_Name(fibo_actus_act, "ACTUSBusinessDayConvention") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSBusinessDayConvention-CSF</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSBusinessDayConvention</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS business day convention - CSF"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSBusinessDayConvention-CSF">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSBusinessDayConvention-CSF</seealso>
    let ACTUSBusinessDayConvention_CSF =
        Prefixed_Name(fibo_actus_act, "ACTUSBusinessDayConvention-CSF") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSBusinessDayConvention-CSMF</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSBusinessDayConvention</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS business day convention - CSMF"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSBusinessDayConvention-CSMF">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSBusinessDayConvention-CSMF</seealso>
    let ACTUSBusinessDayConvention_CSMF =
        Prefixed_Name(fibo_actus_act, "ACTUSBusinessDayConvention-CSMF") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSBusinessDayConvention-CSMP</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSBusinessDayConvention</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS business day convention - CSMP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSBusinessDayConvention-CSMP">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSBusinessDayConvention-CSMP</seealso>
    let ACTUSBusinessDayConvention_CSMP =
        Prefixed_Name(fibo_actus_act, "ACTUSBusinessDayConvention-CSMP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSBusinessDayConvention-CSP</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSBusinessDayConvention</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS business day convention - CSP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSBusinessDayConvention-CSP">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSBusinessDayConvention-CSP</seealso>
    let ACTUSBusinessDayConvention_CSP =
        Prefixed_Name(fibo_actus_act, "ACTUSBusinessDayConvention-CSP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSBusinessDayConvention-NOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSBusinessDayConvention</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS business day convention - NOS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSBusinessDayConvention-NOS">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSBusinessDayConvention-NOS</seealso>
    let ACTUSBusinessDayConvention_NOS =
        Prefixed_Name(fibo_actus_act, "ACTUSBusinessDayConvention-NOS") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSBusinessDayConvention-SCF</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSBusinessDayConvention</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS business day convention - SCF"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSBusinessDayConvention-SCF">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSBusinessDayConvention-SCF</seealso>
    let ACTUSBusinessDayConvention_SCF =
        Prefixed_Name(fibo_actus_act, "ACTUSBusinessDayConvention-SCF") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSBusinessDayConvention-SCMF</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSBusinessDayConvention</para>
    ///
    /// labels<para>"ACTUS business day convention - SCMF"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSBusinessDayConvention-SCMF">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSBusinessDayConvention-SCMF</seealso>
    let ACTUSBusinessDayConvention_SCMF =
        Prefixed_Name(fibo_actus_act, "ACTUSBusinessDayConvention-SCMF") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSBusinessDayConvention-SCMP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSBusinessDayConvention</para>
    ///
    /// labels<para>"ACTUS business day convention - SCMP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSBusinessDayConvention-SCMP">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSBusinessDayConvention-SCMP</seealso>
    let ACTUSBusinessDayConvention_SCMP =
        Prefixed_Name(fibo_actus_act, "ACTUSBusinessDayConvention-SCMP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSBusinessDayConvention-SCP</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSBusinessDayConvention</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS business day convention - SCP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSBusinessDayConvention-SCP">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSBusinessDayConvention-SCP</seealso>
    let ACTUSBusinessDayConvention_SCP =
        Prefixed_Name(fibo_actus_act, "ACTUSBusinessDayConvention-SCP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSCalendarClassifier-MondayToFriday</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSCalendarCode</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS calendar code - Monday to Friday"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSCalendarClassifier-MondayToFriday">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSCalendarClassifier-MondayToFriday</seealso>
    let ACTUSCalendarClassifier_MondayToFriday =
        Prefixed_Name(fibo_actus_act, "ACTUSCalendarClassifier-MondayToFriday") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSCalendarClassifier-NoCalendar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSCalendarCode</para>
    ///
    /// labels<para>"ACTUS calendar code - no calendar"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSCalendarClassifier-NoCalendar">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSCalendarClassifier-NoCalendar</seealso>
    let ACTUSCalendarClassifier_NoCalendar =
        Prefixed_Name(fibo_actus_act, "ACTUSCalendarClassifier-NoCalendar") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSCalendarCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ACTUS calendar code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSCalendarCode">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSCalendarCode</seealso>
    let ACTUSCalendarCode =
        Prefixed_Name(fibo_actus_act, "ACTUSCalendarCode") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractRoleClassifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ACTUS contract role classifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier</seealso>
    let ACTUSContractRoleClassifier =
        Prefixed_Name(fibo_actus_act, "ACTUSContractRoleClassifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractRoleClassifier-BUY</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractRoleClassifier</para>
    ///
    /// labels<para>"ACTUS contract term - BUY"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-BUY">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-BUY</seealso>
    let ACTUSContractRoleClassifier_BUY =
        Prefixed_Name(fibo_actus_act, "ACTUSContractRoleClassifier-BUY") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractRoleClassifier-CNO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractRoleClassifier</para>
    ///
    /// labels<para>"ACTUS contract term - CNO"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-CNO">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-CNO</seealso>
    let ACTUSContractRoleClassifier_CNO =
        Prefixed_Name(fibo_actus_act, "ACTUSContractRoleClassifier-CNO") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractRoleClassifier-COL</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractRoleClassifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - COL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-COL">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-COL</seealso>
    let ACTUSContractRoleClassifier_COL =
        Prefixed_Name(fibo_actus_act, "ACTUSContractRoleClassifier-COL") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractRoleClassifier-GUA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractRoleClassifier</para>
    ///
    /// labels<para>"ACTUS contract term - GUA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-GUA">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-GUA</seealso>
    let ACTUSContractRoleClassifier_GUA =
        Prefixed_Name(fibo_actus_act, "ACTUSContractRoleClassifier-GUA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractRoleClassifier-LG</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractRoleClassifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - LG"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-LG">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-LG</seealso>
    let ACTUSContractRoleClassifier_LG =
        Prefixed_Name(fibo_actus_act, "ACTUSContractRoleClassifier-LG") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractRoleClassifier-OBL</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractRoleClassifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - OBL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-OBL">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-OBL</seealso>
    let ACTUSContractRoleClassifier_OBL =
        Prefixed_Name(fibo_actus_act, "ACTUSContractRoleClassifier-OBL") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractRoleClassifier-PF</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractRoleClassifier</para>
    ///
    /// labels<para>"ACTUS contract term - PF"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-PF">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-PF</seealso>
    let ACTUSContractRoleClassifier_PF =
        Prefixed_Name(fibo_actus_act, "ACTUSContractRoleClassifier-PF") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractRoleClassifier-PFL</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractRoleClassifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - PFL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-PFL">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-PFL</seealso>
    let ACTUSContractRoleClassifier_PFL =
        Prefixed_Name(fibo_actus_act, "ACTUSContractRoleClassifier-PFL") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractRoleClassifier-RF</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractRoleClassifier</para>
    ///
    /// labels<para>"ACTUS contract term - RF"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-RF">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-RF</seealso>
    let ACTUSContractRoleClassifier_RF =
        Prefixed_Name(fibo_actus_act, "ACTUSContractRoleClassifier-RF") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractRoleClassifier-RFL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractRoleClassifier</para>
    ///
    /// labels<para>"ACTUS contract term - RFL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-RFL">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-RFL</seealso>
    let ACTUSContractRoleClassifier_RFL =
        Prefixed_Name(fibo_actus_act, "ACTUSContractRoleClassifier-RFL") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractRoleClassifier-RPA</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractRoleClassifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - RPA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-RPA">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-RPA</seealso>
    let ACTUSContractRoleClassifier_RPA =
        Prefixed_Name(fibo_actus_act, "ACTUSContractRoleClassifier-RPA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractRoleClassifier-RPL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractRoleClassifier</para>
    ///
    /// labels<para>"ACTUS contract term - RPL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-RPL">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-RPL</seealso>
    let ACTUSContractRoleClassifier_RPL =
        Prefixed_Name(fibo_actus_act, "ACTUSContractRoleClassifier-RPL") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractRoleClassifier-SEL</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractRoleClassifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - SEL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-SEL">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-SEL</seealso>
    let ACTUSContractRoleClassifier_SEL =
        Prefixed_Name(fibo_actus_act, "ACTUSContractRoleClassifier-SEL") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractRoleClassifier-ST</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractRoleClassifier</para>
    ///
    /// labels<para>"ACTUS contract term - ST"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-ST">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-ST</seealso>
    let ACTUSContractRoleClassifier_ST =
        Prefixed_Name(fibo_actus_act, "ACTUSContractRoleClassifier-ST") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractRoleClassifier-UDL</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractRoleClassifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - UDL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-UDL">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-UDL</seealso>
    let ACTUSContractRoleClassifier_UDL =
        Prefixed_Name(fibo_actus_act, "ACTUSContractRoleClassifier-UDL") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractRoleClassifier-UDLM</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractRoleClassifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - UDLM"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-UDLM">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-UDLM</seealso>
    let ACTUSContractRoleClassifier_UDLM =
        Prefixed_Name(fibo_actus_act, "ACTUSContractRoleClassifier-UDLM") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractRoleClassifier-UDLP</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractRoleClassifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - UDLP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-UDLP">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-UDLP</seealso>
    let ACTUSContractRoleClassifier_UDLP =
        Prefixed_Name(fibo_actus_act, "ACTUSContractRoleClassifier-UDLP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ACTUS contract term"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm</seealso>
    let ACTUSContractTerm =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-AMD</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - AMD"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-AMD">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-AMD</seealso>
    let ACTUSContractTerm_AMD =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-AMD") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-ARFIXVAR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - ARFIXVAR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-ARFIXVAR">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-ARFIXVAR</seealso>
    let ACTUSContractTerm_ARFIXVAR =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-ARFIXVAR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-ARINCDEC</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - ARINCDEC"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-ARINCDEC">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-ARINCDEC</seealso>
    let ACTUSContractTerm_ARINCDEC =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-ARINCDEC") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-ARIPANXi</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - ARIPANXi"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-ARIPANXi">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-ARIPANXi</seealso>
    let ACTUSContractTerm_ARIPANXi =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-ARIPANXi") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-ARIPCLi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - ARIPCLi"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-ARIPCLi">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-ARIPCLi</seealso>
    let ACTUSContractTerm_ARIPCLi =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-ARIPCLi") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-ARPRANXj</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - ARPRANXj"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-ARPRANXj">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-ARPRANXj</seealso>
    let ACTUSContractTerm_ARPRANXj =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-ARPRANXj") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-ARPRCLj</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - ARPRCLj"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-ARPRCLj">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-ARPRCLj</seealso>
    let ACTUSContractTerm_ARPRCLj =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-ARPRCLj") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-ARPRNXTj</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - ARPRNXTj"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-ARPRNXTj">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-ARPRNXTj</seealso>
    let ACTUSContractTerm_ARPRNXTj =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-ARPRNXTj") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-ARRATE</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - ARRATE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-ARRATE">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-ARRATE</seealso>
    let ACTUSContractTerm_ARRATE =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-ARRATE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-ARRRANX</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - ARRRANX"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-ARRRANX">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-ARRRANX</seealso>
    let ACTUSContractTerm_ARRRANX =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-ARRRANX") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-ARRRCL</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - ARRRCL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-ARRRCL">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-ARRRCL</seealso>
    let ACTUSContractTerm_ARRRCL =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-ARRRCL") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-BCF</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - BCF"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-BCF">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-BCF</seealso>
    let ACTUSContractTerm_BCF =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-BCF") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-BDC</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - BDC"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-BDC">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-BDC</seealso>
    let ACTUSContractTerm_BDC =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-BDC") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-BDR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - BDR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-BDR">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-BDR</seealso>
    let ACTUSContractTerm_BDR =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-BDR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-BEF</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - BEF"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-BEF">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-BEF</seealso>
    let ACTUSContractTerm_BEF =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-BEF") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-BLIA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - BLIA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-BLIA">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-BLIA</seealso>
    let ACTUSContractTerm_BLIA =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-BLIA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-BMANX</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - BMANX"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-BMANX">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-BMANX</seealso>
    let ACTUSContractTerm_BMANX =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-BMANX") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-BMCL</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - BMCL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-BMCL">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-BMCL</seealso>
    let ACTUSContractTerm_BMCL =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-BMCL") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-BMED</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - BMED"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-BMED">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-BMED</seealso>
    let ACTUSContractTerm_BMED =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-BMED") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-BV</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - BV"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-BV">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-BV</seealso>
    let ACTUSContractTerm_BV =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-BV") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-CDD</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - CDD"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CDD">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CDD</seealso>
    let ACTUSContractTerm_CDD =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-CDD") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-CECV</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - CECV"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CECV">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CECV</seealso>
    let ACTUSContractTerm_CECV =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-CECV") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-CEGE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - CEGE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CEGE">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CEGE</seealso>
    let ACTUSContractTerm_CEGE =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-CEGE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-CETC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - CETC"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CETC">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CETC</seealso>
    let ACTUSContractTerm_CETC =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-CETC") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-CID</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - CID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CID">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CID</seealso>
    let ACTUSContractTerm_CID =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-CID") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-CLA</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - CLA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CLA">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CLA</seealso>
    let ACTUSContractTerm_CLA =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-CLA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-CLDR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - CLDR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CLDR">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CLDR</seealso>
    let ACTUSContractTerm_CLDR =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-CLDR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-CNTRL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CNTRL">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CNTRL</seealso>
    let ACTUSContractTerm_CNTRL =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-CNTRL") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-CPID</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - CPID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CPID">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CPID</seealso>
    let ACTUSContractTerm_CPID =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-CPID") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-CRID</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - CRID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CRID">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CRID</seealso>
    let ACTUSContractTerm_CRID =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-CRID") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-CT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - CT"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT</seealso>
    let ACTUSContractTerm_CT =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-CT") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-CT-ANN</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - CT - ANN"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-ANN">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-ANN</seealso>
    let ACTUSContractTerm_CT_ANN =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-CT-ANN") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-CT-CAPFL</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - CT - CAPFL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-CAPFL">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-CAPFL</seealso>
    let ACTUSContractTerm_CT_CAPFL =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-CT-CAPFL") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-CT-CEC</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - CT - CEC"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-CEC">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-CEC</seealso>
    let ACTUSContractTerm_CT_CEC =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-CT-CEC") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-CT-CEG</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - CT - CEG"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-CEG">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-CEG</seealso>
    let ACTUSContractTerm_CT_CEG =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-CT-CEG") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-CT-CLM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - CT - CLM"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-CLM">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-CLM</seealso>
    let ACTUSContractTerm_CT_CLM =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-CT-CLM") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-CT-COM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - CT - COM"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-COM">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-COM</seealso>
    let ACTUSContractTerm_CT_COM =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-CT-COM") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-CT-CSH</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - CT - CSH"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-CSH">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-CSH</seealso>
    let ACTUSContractTerm_CT_CSH =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-CT-CSH") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-CT-FUTUR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - CT - FUTUR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-FUTUR">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-FUTUR</seealso>
    let ACTUSContractTerm_CT_FUTUR =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-CT-FUTUR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-CT-FXOUT</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - CT - FXOUT"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-FXOUT">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-FXOUT</seealso>
    let ACTUSContractTerm_CT_FXOUT =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-CT-FXOUT") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-CT-LAM</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - CT - LAM"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-LAM">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-LAM</seealso>
    let ACTUSContractTerm_CT_LAM =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-CT-LAM") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-CT-LAX</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - CT - LAX"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-LAX">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-LAX</seealso>
    let ACTUSContractTerm_CT_LAX =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-CT-LAX") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-CT-NAM</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - CT - NAM"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-NAM">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-NAM</seealso>
    let ACTUSContractTerm_CT_NAM =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-CT-NAM") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-CT-OPTNS</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - CT - OPTNS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-OPTNS">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-OPTNS</seealso>
    let ACTUSContractTerm_CT_OPTNS =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-CT-OPTNS") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-CT-PAM</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - CT - PAM"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-PAM">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-PAM</seealso>
    let ACTUSContractTerm_CT_PAM =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-CT-PAM") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-CT-STK</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - CT - STK"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-STK">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-STK</seealso>
    let ACTUSContractTerm_CT_STK =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-CT-STK") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-CT-SWAPS</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - CT - SWAPS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-SWAPS">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-SWAPS</seealso>
    let ACTUSContractTerm_CT_SWAPS =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-CT-SWAPS") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-CT-SWPPV</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - CT - SWPPV"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-SWPPV">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-SWPPV</seealso>
    let ACTUSContractTerm_CT_SWPPV =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-CT-SWPPV") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-CT-UMP</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - CT - UMP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-UMP">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-UMP</seealso>
    let ACTUSContractTerm_CT_UMP =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-CT-UMP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-CTS</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - CTS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CTS">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CTS</seealso>
    let ACTUSContractTerm_CTS =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-CTS") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-CUR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - CUR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CUR">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CUR</seealso>
    let ACTUSContractTerm_CUR =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-CUR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-CUR2</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - CUR2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CUR2">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CUR2</seealso>
    let ACTUSContractTerm_CUR2 =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-CUR2") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-CURS</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - CURS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CURS">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CURS</seealso>
    let ACTUSContractTerm_CURS =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-CURS") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-DQP</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - DQP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-DQP">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-DQP</seealso>
    let ACTUSContractTerm_DQP =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-DQP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-DQR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - DQR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-DQR">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-DQR</seealso>
    let ACTUSContractTerm_DQR =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-DQR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-DS</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - DS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-DS">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-DS</seealso>
    let ACTUSContractTerm_DS =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-DS") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-DVANX</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - DVANX"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-DVANX">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-DVANX</seealso>
    let ACTUSContractTerm_DVANX =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-DVANX") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-DVCL</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - DVCL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-DVCL">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-DVCL</seealso>
    let ACTUSContractTerm_DVCL =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-DVCL") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-DVEX</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - DVEX"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-DVEX">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-DVEX</seealso>
    let ACTUSContractTerm_DVEX =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-DVEX") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-DVNP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - DVNP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-DVNP">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-DVNP</seealso>
    let ACTUSContractTerm_DVNP =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-DVNP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-EOMC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - EOMC"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-EOMC">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-EOMC</seealso>
    let ACTUSContractTerm_EOMC =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-EOMC") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-FEAC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - FEAC"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-FEAC">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-FEAC</seealso>
    let ACTUSContractTerm_FEAC =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-FEAC") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-FEANX</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - FEANX"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-FEANX">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-FEANX</seealso>
    let ACTUSContractTerm_FEANX =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-FEANX") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-FEB</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - FEB"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-FEB">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-FEB</seealso>
    let ACTUSContractTerm_FEB =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-FEB") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-FECL</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - FECL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-FECL">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-FECL</seealso>
    let ACTUSContractTerm_FECL =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-FECL") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-FER</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - FER"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-FER">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-FER</seealso>
    let ACTUSContractTerm_FER =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-FER") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-GRP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - GRP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-GRP">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-GRP</seealso>
    let ACTUSContractTerm_GRP =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-GRP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-IED</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - IED"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IED">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IED</seealso>
    let ACTUSContractTerm_IED =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-IED") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-IPAC</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - IPAC"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IPAC">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IPAC</seealso>
    let ACTUSContractTerm_IPAC =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-IPAC") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-IPANX</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - IPANX"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IPANX">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IPANX</seealso>
    let ACTUSContractTerm_IPANX =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-IPANX") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-IPCB</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - IPCB"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IPCB">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IPCB</seealso>
    let ACTUSContractTerm_IPCB =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-IPCB") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-IPCBA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - IPCBA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IPCBA">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IPCBA</seealso>
    let ACTUSContractTerm_IPCBA =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-IPCBA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-IPCBANX</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - IPCBANX"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IPCBANX">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IPCBANX</seealso>
    let ACTUSContractTerm_IPCBANX =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-IPCBANX") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-IPCBCL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - IPCBCL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IPCBCL">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IPCBCL</seealso>
    let ACTUSContractTerm_IPCBCL =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-IPCBCL") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-IPCED</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - IPCED"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IPCED">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IPCED</seealso>
    let ACTUSContractTerm_IPCED =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-IPCED") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-IPCL</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - IPCL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IPCL">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IPCL</seealso>
    let ACTUSContractTerm_IPCL =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-IPCL") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-IPDC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - IPDC"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IPDC">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IPDC</seealso>
    let ACTUSContractTerm_IPDC =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-IPDC") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-IPNR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - IPNR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IPNR">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IPNR</seealso>
    let ACTUSContractTerm_IPNR =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-IPNR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-IPNR2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - IPNR2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IPNR2">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IPNR2</seealso>
    let ACTUSContractTerm_IPNR2 =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-IPNR2") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-IPPNT</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - IPPNT"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IPPNT">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IPPNT</seealso>
    let ACTUSContractTerm_IPPNT =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-IPPNT") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-MD</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - MD"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-MD">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-MD</seealso>
    let ACTUSContractTerm_MD =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-MD") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-MOC</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - MOC"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-MOC">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-MOC</seealso>
    let ACTUSContractTerm_MOC =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-MOC") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-MPFD</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - MPFD"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-MPFD">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-MPFD</seealso>
    let ACTUSContractTerm_MPFD =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-MPFD") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-MRANX</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - MRANX"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-MRANX">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-MRANX</seealso>
    let ACTUSContractTerm_MRANX =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-MRANX") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-MRCL</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - MRCL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-MRCL">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-MRCL</seealso>
    let ACTUSContractTerm_MRCL =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-MRCL") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-MRCLH</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - MRCLH"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-MRCLH">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-MRCLH</seealso>
    let ACTUSContractTerm_MRCLH =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-MRCLH") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-MRIM</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - MRIM"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-MRIM">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-MRIM</seealso>
    let ACTUSContractTerm_MRIM =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-MRIM") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-MRMML</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - MRMML"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-MRMML">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-MRMML</seealso>
    let ACTUSContractTerm_MRMML =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-MRMML") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-MRMMU</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - MRMMU"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-MRMMU">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-MRMMU</seealso>
    let ACTUSContractTerm_MRMMU =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-MRMMU") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-MRVM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - MRVM"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-MRVM">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-MRVM</seealso>
    let ACTUSContractTerm_MRVM =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-MRVM") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-MVO</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - MVO"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-MVO">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-MVO</seealso>
    let ACTUSContractTerm_MVO =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-MVO") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-NPD</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - NPD"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-NPD">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-NPD</seealso>
    let ACTUSContractTerm_NPD =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-NPD") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-NT</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - NT"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-NT">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-NT</seealso>
    let ACTUSContractTerm_NT =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-NT") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-NT2</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - NT2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-NT2">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-NT2</seealso>
    let ACTUSContractTerm_NT2 =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-NT2") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-OPANX</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - OPANX"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-OPANX">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-OPANX</seealso>
    let ACTUSContractTerm_OPANX =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-OPANX") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-OPCL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - OPCL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-OPCL">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-OPCL</seealso>
    let ACTUSContractTerm_OPCL =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-OPCL") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-OPS1</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - OPS1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-OPS1">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-OPS1</seealso>
    let ACTUSContractTerm_OPS1 =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-OPS1") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-OPS2</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - OPS2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-OPS2">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-OPS2</seealso>
    let ACTUSContractTerm_OPS2 =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-OPS2") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-OPTP</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - OPTP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-OPTP">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-OPTP</seealso>
    let ACTUSContractTerm_OPTP =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-OPTP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-OPXED</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - OPXED"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-OPXED">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-OPXED</seealso>
    let ACTUSContractTerm_OPXED =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-OPXED") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-OPXT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - OPXT"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-OPXT">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-OPXT</seealso>
    let ACTUSContractTerm_OPXT =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-OPXT") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-PDIED</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - PDIED"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PDIED">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PDIED</seealso>
    let ACTUSContractTerm_PDIED =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-PDIED") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-PFUT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - PFUT"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PFUT">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PFUT</seealso>
    let ACTUSContractTerm_PFUT =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-PFUT") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-PPEF</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - PPEF"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PPEF">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PPEF</seealso>
    let ACTUSContractTerm_PPEF =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-PPEF") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-PPP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - PPP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PPP">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PPP</seealso>
    let ACTUSContractTerm_PPP =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-PPP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-PPRD</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - PPRD"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PPRD">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PPRD</seealso>
    let ACTUSContractTerm_PPRD =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-PPRD") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-PRANX</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - PRANX"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PRANX">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PRANX</seealso>
    let ACTUSContractTerm_PRANX =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-PRANX") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-PRCL</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - PRCL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PRCL">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PRCL</seealso>
    let ACTUSContractTerm_PRCL =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-PRCL") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-PRD</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - PRD"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PRD">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PRD</seealso>
    let ACTUSContractTerm_PRD =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-PRD") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-PRF</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - PRF"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PRF">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PRF</seealso>
    let ACTUSContractTerm_PRF =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-PRF") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-PRNXT</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - PRNXT"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PRNXT">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PRNXT</seealso>
    let ACTUSContractTerm_PRNXT =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-PRNXT") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-PTD</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - PTD"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PTD">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PTD</seealso>
    let ACTUSContractTerm_PTD =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-PTD") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-PYRT</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - PYRT"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PYRT">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PYRT</seealso>
    let ACTUSContractTerm_PYRT =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-PYRT") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-PYTP</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - PYTP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PYTP">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PYTP</seealso>
    let ACTUSContractTerm_PYTP =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-PYTP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-QT</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - QT"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-QT">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-QT</seealso>
    let ACTUSContractTerm_QT =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-QT") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-RRANX</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - RRANX"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-RRANX">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-RRANX</seealso>
    let ACTUSContractTerm_RRANX =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-RRANX") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-RRCL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - RRCL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-RRCL">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-RRCL</seealso>
    let ACTUSContractTerm_RRCL =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-RRCL") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-RRFIX</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - RRFIX"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-RRFIX">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-RRFIX</seealso>
    let ACTUSContractTerm_RRFIX =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-RRFIX") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-RRLC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - RRLC"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-RRLC">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-RRLC</seealso>
    let ACTUSContractTerm_RRLC =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-RRLC") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-RRLF</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - RRLF"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-RRLF">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-RRLF</seealso>
    let ACTUSContractTerm_RRLF =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-RRLF") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-RRMLT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - RRMLT"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-RRMLT">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-RRMLT</seealso>
    let ACTUSContractTerm_RRMLT =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-RRMLT") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-RRMO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - RRMO"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-RRMO">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-RRMO</seealso>
    let ACTUSContractTerm_RRMO =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-RRMO") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-RRNXT</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - RRNXT"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-RRNXT">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-RRNXT</seealso>
    let ACTUSContractTerm_RRNXT =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-RRNXT") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-RRPC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - RRPC"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-RRPC">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-RRPC</seealso>
    let ACTUSContractTerm_RRPC =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-RRPC") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-RRPF</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - RRPF"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-RRPF">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-RRPF</seealso>
    let ACTUSContractTerm_RRPF =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-RRPF") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-RRPNT</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - RRPNT"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-RRPNT">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-RRPNT</seealso>
    let ACTUSContractTerm_RRPNT =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-RRPNT") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-RRSP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - RRSP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-RRSP">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-RRSP</seealso>
    let ACTUSContractTerm_RRSP =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-RRSP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-SCANX</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - SCANX"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-SCANX">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-SCANX</seealso>
    let ACTUSContractTerm_SCANX =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-SCANX") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-SCCDD</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - SCCDD"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-SCCDD">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-SCCDD</seealso>
    let ACTUSContractTerm_SCCDD =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-SCCDD") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-SCCL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - SCCL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-SCCL">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-SCCL</seealso>
    let ACTUSContractTerm_SCCL =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-SCCL") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-SCEF</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - SCEF"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-SCEF">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-SCEF</seealso>
    let ACTUSContractTerm_SCEF =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-SCEF") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-SCIP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - SCIP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-SCIP">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-SCIP</seealso>
    let ACTUSContractTerm_SCIP =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-SCIP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-SCMO</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - SCMO"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-SCMO">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-SCMO</seealso>
    let ACTUSContractTerm_SCMO =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-SCMO") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-SCNT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - SCNT"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-SCNT">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-SCNT</seealso>
    let ACTUSContractTerm_SCNT =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-SCNT") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-SD</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - SD"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-SD">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-SD</seealso>
    let ACTUSContractTerm_SD =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-SD") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-SEN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - SEN"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-SEN">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-SEN</seealso>
    let ACTUSContractTerm_SEN =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-SEN") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-STP</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - STP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-STP">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-STP</seealso>
    let ACTUSContractTerm_STP =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-STP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-TD</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - TD"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-TD">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-TD</seealso>
    let ACTUSContractTerm_TD =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-TD") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-UT</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - UT"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-UT">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-UT</seealso>
    let ACTUSContractTerm_UT =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-UT") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-XA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - XA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-XA">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-XA</seealso>
    let ACTUSContractTerm_XA =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-XA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-XD</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///
    /// labels<para>"ACTUS contract term - XD"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-XD">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-XD</seealso>
    let ACTUSContractTerm_XD =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-XD") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTerm-XDN</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTerm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS contract term - XDN"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-XDN">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-XDN</seealso>
    let ACTUSContractTerm_XDN =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTerm-XDN") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTermGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ACTUS dictionary term group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup</seealso>
    let ACTUSContractTermGroup =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTermGroup") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTermGroup-Boundary</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTermGroup</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS dictionary term group - boundary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup-Boundary">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup-Boundary</seealso>
    let ACTUSContractTermGroup_Boundary =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTermGroup-Boundary") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTermGroup-Calendar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTermGroup</para>
    ///
    /// labels<para>"ACTUS dictionary term group - calendar"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup-Calendar">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup-Calendar</seealso>
    let ACTUSContractTermGroup_Calendar =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTermGroup-Calendar") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTermGroup-ContractIdentification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTermGroup</para>
    ///
    /// labels<para>"ACTUS dictionary term group - contract identification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup-ContractIdentification">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup-ContractIdentification</seealso>
    let ACTUSContractTermGroup_ContractIdentification =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTermGroup-ContractIdentification") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTermGroup-Counterparty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTermGroup</para>
    ///
    /// labels<para>"ACTUS dictionary term group - counterparty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup-Counterparty">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup-Counterparty</seealso>
    let ACTUSContractTermGroup_Counterparty =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTermGroup-Counterparty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTermGroup-Dividend</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTermGroup</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS dictionary term group - dividend"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup-Dividend">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup-Dividend</seealso>
    let ACTUSContractTermGroup_Dividend =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTermGroup-Dividend") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTermGroup-Fees</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTermGroup</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS dictionary term group - fees"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup-Fees">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup-Fees</seealso>
    let ACTUSContractTermGroup_Fees =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTermGroup-Fees") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTermGroup-Interest</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTermGroup</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS dictionary term group - interest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup-Interest">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup-Interest</seealso>
    let ACTUSContractTermGroup_Interest =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTermGroup-Interest") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTermGroup-Margining</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTermGroup</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS dictionary term group - margining"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup-Margining">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup-Margining</seealso>
    let ACTUSContractTermGroup_Margining =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTermGroup-Margining") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTermGroup-NotionalPrincipal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTermGroup</para>
    ///
    /// labels<para>"ACTUS dictionary term group - notional principal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup-NotionalPrincipal">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup-NotionalPrincipal</seealso>
    let ACTUSContractTermGroup_NotionalPrincipal =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTermGroup-NotionalPrincipal") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTermGroup-Optionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTermGroup</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS dictionary term group - optionality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup-Optionality">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup-Optionality</seealso>
    let ACTUSContractTermGroup_Optionality =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTermGroup-Optionality") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTermGroup-RateReset</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-actus-act:ACTUSContractTermGroup</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS dictionary term group - rate reset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup-RateReset">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup-RateReset</seealso>
    let ACTUSContractTermGroup_RateReset =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTermGroup-RateReset") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:ACTUSContractTermGroup-Settlement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-actus-act:ACTUSContractTermGroup</para>
    ///
    /// labels<para>"ACTUS dictionary term group - settlement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup-Settlement">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup-Settlement</seealso>
    let ACTUSContractTermGroup_Settlement =
        Prefixed_Name(fibo_actus_act, "ACTUSContractTermGroup-Settlement") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:AlgorithmicContractTypesDataDictionary</para>
    /// </summary>
    /// <remarks>
    ///   <para>CodesAndCodeSets:CodeSet</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Algorithmic Contract Types data dictionary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/AlgorithmicContractTypesDataDictionary">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/AlgorithmicContractTypesDataDictionary</seealso>
    let AlgorithmicContractTypesDataDictionary =
        Prefixed_Name(fibo_actus_act, "AlgorithmicContractTypesDataDictionary") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:hasOptionSequenceNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has option sequence number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/hasOptionSequenceNumber">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/hasOptionSequenceNumber</seealso>
    let hasOptionSequenceNumber =
        Prefixed_Name(fibo_actus_act, "hasOptionSequenceNumber") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:hasParameterMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has parameter mapping"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/hasParameterMapping">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/hasParameterMapping</seealso>
    let hasParameterMapping =
        Prefixed_Name(fibo_actus_act, "hasParameterMapping") |> PrefixedName

    /// <summary>
    ///   <para>fibo-actus-act:hasParameterName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has parameter name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/hasParameterName">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/hasParameterName</seealso>
    let hasParameterName =
        Prefixed_Name(fibo_actus_act, "hasParameterName") |> PrefixedName

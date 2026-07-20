namespace https.spec.edmcouncil.org.fibo.ontology.ACTUS.ACTUSContractTerms.slash

open DoxAletheia

module fibo_actus_act =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSBusinessDayConvention"></see>
    /// </summary>
    let ACTUSBusinessDayConvention = _prefix "ACTUSBusinessDayConvention"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/AlgorithmicContractTypesDataDictionary"></see>
    /// </summary>
    let AlgorithmicContractTypesDataDictionary =
        _prefix "AlgorithmicContractTypesDataDictionary"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSBusinessDayConvention-CSF"></see>
    /// </summary>
    let ``ACTUSBusinessDayConvention-CSF`` = _prefix "ACTUSBusinessDayConvention-CSF"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSBusinessDayConvention-CSMF"></see>
    /// </summary>
    let ``ACTUSBusinessDayConvention-CSMF`` = _prefix "ACTUSBusinessDayConvention-CSMF"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSBusinessDayConvention-CSMP"></see>
    /// </summary>
    let ``ACTUSBusinessDayConvention-CSMP`` = _prefix "ACTUSBusinessDayConvention-CSMP"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSBusinessDayConvention-CSP"></see>
    /// </summary>
    let ``ACTUSBusinessDayConvention-CSP`` = _prefix "ACTUSBusinessDayConvention-CSP"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSBusinessDayConvention-NOS"></see>
    /// </summary>
    let ``ACTUSBusinessDayConvention-NOS`` = _prefix "ACTUSBusinessDayConvention-NOS"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSBusinessDayConvention-SCF"></see>
    /// </summary>
    let ``ACTUSBusinessDayConvention-SCF`` = _prefix "ACTUSBusinessDayConvention-SCF"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSBusinessDayConvention-SCMF"></see>
    /// </summary>
    let ``ACTUSBusinessDayConvention-SCMF`` = _prefix "ACTUSBusinessDayConvention-SCMF"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSBusinessDayConvention-SCMP"></see>
    /// </summary>
    let ``ACTUSBusinessDayConvention-SCMP`` = _prefix "ACTUSBusinessDayConvention-SCMP"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSBusinessDayConvention-SCP"></see>
    /// </summary>
    let ``ACTUSBusinessDayConvention-SCP`` = _prefix "ACTUSBusinessDayConvention-SCP"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSCalendarClassifier-MondayToFriday"></see>
    /// </summary>
    let ``ACTUSCalendarClassifier-MondayToFriday`` =
        _prefix "ACTUSCalendarClassifier-MondayToFriday"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSCalendarCode"></see>
    /// </summary>
    let ACTUSCalendarCode = _prefix "ACTUSCalendarCode"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSCalendarClassifier-NoCalendar"></see>
    /// </summary>
    let ``ACTUSCalendarClassifier-NoCalendar`` =
        _prefix "ACTUSCalendarClassifier-NoCalendar"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier"></see>
    /// </summary>
    let ACTUSContractRoleClassifier = _prefix "ACTUSContractRoleClassifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-BUY"></see>
    /// </summary>
    let ``ACTUSContractRoleClassifier-BUY`` = _prefix "ACTUSContractRoleClassifier-BUY"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-CNO"></see>
    /// </summary>
    let ``ACTUSContractRoleClassifier-CNO`` = _prefix "ACTUSContractRoleClassifier-CNO"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-COL"></see>
    /// </summary>
    let ``ACTUSContractRoleClassifier-COL`` = _prefix "ACTUSContractRoleClassifier-COL"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-GUA"></see>
    /// </summary>
    let ``ACTUSContractRoleClassifier-GUA`` = _prefix "ACTUSContractRoleClassifier-GUA"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-LG"></see>
    /// </summary>
    let ``ACTUSContractRoleClassifier-LG`` = _prefix "ACTUSContractRoleClassifier-LG"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-OBL"></see>
    /// </summary>
    let ``ACTUSContractRoleClassifier-OBL`` = _prefix "ACTUSContractRoleClassifier-OBL"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-PFL"></see>
    /// </summary>
    let ``ACTUSContractRoleClassifier-PFL`` = _prefix "ACTUSContractRoleClassifier-PFL"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-RFL"></see>
    /// </summary>
    let ``ACTUSContractRoleClassifier-RFL`` = _prefix "ACTUSContractRoleClassifier-RFL"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-RPA"></see>
    /// </summary>
    let ``ACTUSContractRoleClassifier-RPA`` = _prefix "ACTUSContractRoleClassifier-RPA"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-RPL"></see>
    /// </summary>
    let ``ACTUSContractRoleClassifier-RPL`` = _prefix "ACTUSContractRoleClassifier-RPL"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-SEL"></see>
    /// </summary>
    let ``ACTUSContractRoleClassifier-SEL`` = _prefix "ACTUSContractRoleClassifier-SEL"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier-ST"></see>
    /// </summary>
    let ``ACTUSContractRoleClassifier-ST`` = _prefix "ACTUSContractRoleClassifier-ST"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm"></see>
    /// </summary>
    let ACTUSContractTerm = _prefix "ACTUSContractTerm"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/hasParameterName"></see>
    /// </summary>
    let hasParameterName = _prefix "hasParameterName"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup"></see>
    /// </summary>
    let ACTUSContractTermGroup = _prefix "ACTUSContractTermGroup"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-AMD"></see>
    /// </summary>
    let ``ACTUSContractTerm-AMD`` = _prefix "ACTUSContractTerm-AMD"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup-NotionalPrincipal"></see>
    /// </summary>
    let ``ACTUSContractTermGroup-NotionalPrincipal`` =
        _prefix "ACTUSContractTermGroup-NotionalPrincipal"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-ARFIXVAR"></see>
    /// </summary>
    let ``ACTUSContractTerm-ARFIXVAR`` = _prefix "ACTUSContractTerm-ARFIXVAR"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup-RateReset"></see>
    /// </summary>
    let ``ACTUSContractTermGroup-RateReset`` =
        _prefix "ACTUSContractTermGroup-RateReset"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-ARINCDEC"></see>
    /// </summary>
    let ``ACTUSContractTerm-ARINCDEC`` = _prefix "ACTUSContractTerm-ARINCDEC"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-ARIPANXi"></see>
    /// </summary>
    let ``ACTUSContractTerm-ARIPANXi`` = _prefix "ACTUSContractTerm-ARIPANXi"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup-Interest"></see>
    /// </summary>
    let ``ACTUSContractTermGroup-Interest`` = _prefix "ACTUSContractTermGroup-Interest"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-ARIPCLi"></see>
    /// </summary>
    let ``ACTUSContractTerm-ARIPCLi`` = _prefix "ACTUSContractTerm-ARIPCLi"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-ARPRANXj"></see>
    /// </summary>
    let ``ACTUSContractTerm-ARPRANXj`` = _prefix "ACTUSContractTerm-ARPRANXj"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-ARPRCLj"></see>
    /// </summary>
    let ``ACTUSContractTerm-ARPRCLj`` = _prefix "ACTUSContractTerm-ARPRCLj"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-ARPRNXTj"></see>
    /// </summary>
    let ``ACTUSContractTerm-ARPRNXTj`` = _prefix "ACTUSContractTerm-ARPRNXTj"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-ARRATE"></see>
    /// </summary>
    let ``ACTUSContractTerm-ARRATE`` = _prefix "ACTUSContractTerm-ARRATE"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-ARRRANX"></see>
    /// </summary>
    let ``ACTUSContractTerm-ARRRANX`` = _prefix "ACTUSContractTerm-ARRRANX"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-ARRRCL"></see>
    /// </summary>
    let ``ACTUSContractTerm-ARRRCL`` = _prefix "ACTUSContractTerm-ARRRCL"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-BCF"></see>
    /// </summary>
    let ``ACTUSContractTerm-BCF`` = _prefix "ACTUSContractTerm-BCF"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup-Boundary"></see>
    /// </summary>
    let ``ACTUSContractTermGroup-Boundary`` = _prefix "ACTUSContractTermGroup-Boundary"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-BDC"></see>
    /// </summary>
    let ``ACTUSContractTerm-BDC`` = _prefix "ACTUSContractTerm-BDC"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup-Calendar"></see>
    /// </summary>
    let ``ACTUSContractTermGroup-Calendar`` = _prefix "ACTUSContractTermGroup-Calendar"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-BDR"></see>
    /// </summary>
    let ``ACTUSContractTerm-BDR`` = _prefix "ACTUSContractTerm-BDR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-BEF"></see>
    /// </summary>
    let ``ACTUSContractTerm-BEF`` = _prefix "ACTUSContractTerm-BEF"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-BLIA"></see>
    /// </summary>
    let ``ACTUSContractTerm-BLIA`` = _prefix "ACTUSContractTerm-BLIA"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-BMANX"></see>
    /// </summary>
    let ``ACTUSContractTerm-BMANX`` = _prefix "ACTUSContractTerm-BMANX"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-BMCL"></see>
    /// </summary>
    let ``ACTUSContractTerm-BMCL`` = _prefix "ACTUSContractTerm-BMCL"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-BMED"></see>
    /// </summary>
    let ``ACTUSContractTerm-BMED`` = _prefix "ACTUSContractTerm-BMED"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-BV"></see>
    /// </summary>
    let ``ACTUSContractTerm-BV`` = _prefix "ACTUSContractTerm-BV"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CDD"></see>
    /// </summary>
    let ``ACTUSContractTerm-CDD`` = _prefix "ACTUSContractTerm-CDD"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CECV"></see>
    /// </summary>
    let ``ACTUSContractTerm-CECV`` = _prefix "ACTUSContractTerm-CECV"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup-Counterparty"></see>
    /// </summary>
    let ``ACTUSContractTermGroup-Counterparty`` =
        _prefix "ACTUSContractTermGroup-Counterparty"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CEGE"></see>
    /// </summary>
    let ``ACTUSContractTerm-CEGE`` = _prefix "ACTUSContractTerm-CEGE"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CETC"></see>
    /// </summary>
    let ``ACTUSContractTerm-CETC`` = _prefix "ACTUSContractTerm-CETC"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CID"></see>
    /// </summary>
    let ``ACTUSContractTerm-CID`` = _prefix "ACTUSContractTerm-CID"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup-ContractIdentification"></see>
    /// </summary>
    let ``ACTUSContractTermGroup-ContractIdentification`` =
        _prefix "ACTUSContractTermGroup-ContractIdentification"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CLA"></see>
    /// </summary>
    let ``ACTUSContractTerm-CLA`` = _prefix "ACTUSContractTerm-CLA"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CLDR"></see>
    /// </summary>
    let ``ACTUSContractTerm-CLDR`` = _prefix "ACTUSContractTerm-CLDR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CNTRL"></see>
    /// </summary>
    let ``ACTUSContractTerm-CNTRL`` = _prefix "ACTUSContractTerm-CNTRL"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CPID"></see>
    /// </summary>
    let ``ACTUSContractTerm-CPID`` = _prefix "ACTUSContractTerm-CPID"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CRID"></see>
    /// </summary>
    let ``ACTUSContractTerm-CRID`` = _prefix "ACTUSContractTerm-CRID"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT"></see>
    /// </summary>
    let ``ACTUSContractTerm-CT`` = _prefix "ACTUSContractTerm-CT"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-ANN"></see>
    /// </summary>
    let ``ACTUSContractTerm-CT-ANN`` = _prefix "ACTUSContractTerm-CT-ANN"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/hasOptionSequenceNumber"></see>
    /// </summary>
    let hasOptionSequenceNumber = _prefix "hasOptionSequenceNumber"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-CAPFL"></see>
    /// </summary>
    let ``ACTUSContractTerm-CT-CAPFL`` = _prefix "ACTUSContractTerm-CT-CAPFL"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-CEC"></see>
    /// </summary>
    let ``ACTUSContractTerm-CT-CEC`` = _prefix "ACTUSContractTerm-CT-CEC"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-CEG"></see>
    /// </summary>
    let ``ACTUSContractTerm-CT-CEG`` = _prefix "ACTUSContractTerm-CT-CEG"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-CLM"></see>
    /// </summary>
    let ``ACTUSContractTerm-CT-CLM`` = _prefix "ACTUSContractTerm-CT-CLM"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-COM"></see>
    /// </summary>
    let ``ACTUSContractTerm-CT-COM`` = _prefix "ACTUSContractTerm-CT-COM"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-CSH"></see>
    /// </summary>
    let ``ACTUSContractTerm-CT-CSH`` = _prefix "ACTUSContractTerm-CT-CSH"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-FUTUR"></see>
    /// </summary>
    let ``ACTUSContractTerm-CT-FUTUR`` = _prefix "ACTUSContractTerm-CT-FUTUR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-FXOUT"></see>
    /// </summary>
    let ``ACTUSContractTerm-CT-FXOUT`` = _prefix "ACTUSContractTerm-CT-FXOUT"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-LAM"></see>
    /// </summary>
    let ``ACTUSContractTerm-CT-LAM`` = _prefix "ACTUSContractTerm-CT-LAM"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-LAX"></see>
    /// </summary>
    let ``ACTUSContractTerm-CT-LAX`` = _prefix "ACTUSContractTerm-CT-LAX"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-NAM"></see>
    /// </summary>
    let ``ACTUSContractTerm-CT-NAM`` = _prefix "ACTUSContractTerm-CT-NAM"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-OPTNS"></see>
    /// </summary>
    let ``ACTUSContractTerm-CT-OPTNS`` = _prefix "ACTUSContractTerm-CT-OPTNS"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-PAM"></see>
    /// </summary>
    let ``ACTUSContractTerm-CT-PAM`` = _prefix "ACTUSContractTerm-CT-PAM"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-STK"></see>
    /// </summary>
    let ``ACTUSContractTerm-CT-STK`` = _prefix "ACTUSContractTerm-CT-STK"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-SWAPS"></see>
    /// </summary>
    let ``ACTUSContractTerm-CT-SWAPS`` = _prefix "ACTUSContractTerm-CT-SWAPS"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-SWPPV"></see>
    /// </summary>
    let ``ACTUSContractTerm-CT-SWPPV`` = _prefix "ACTUSContractTerm-CT-SWPPV"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CT-UMP"></see>
    /// </summary>
    let ``ACTUSContractTerm-CT-UMP`` = _prefix "ACTUSContractTerm-CT-UMP"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CTS"></see>
    /// </summary>
    let ``ACTUSContractTerm-CTS`` = _prefix "ACTUSContractTerm-CTS"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CUR"></see>
    /// </summary>
    let ``ACTUSContractTerm-CUR`` = _prefix "ACTUSContractTerm-CUR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CUR2"></see>
    /// </summary>
    let ``ACTUSContractTerm-CUR2`` = _prefix "ACTUSContractTerm-CUR2"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-CURS"></see>
    /// </summary>
    let ``ACTUSContractTerm-CURS`` = _prefix "ACTUSContractTerm-CURS"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup-Settlement"></see>
    /// </summary>
    let ``ACTUSContractTermGroup-Settlement`` =
        _prefix "ACTUSContractTermGroup-Settlement"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-DQP"></see>
    /// </summary>
    let ``ACTUSContractTerm-DQP`` = _prefix "ACTUSContractTerm-DQP"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-DQR"></see>
    /// </summary>
    let ``ACTUSContractTerm-DQR`` = _prefix "ACTUSContractTerm-DQR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-DS"></see>
    /// </summary>
    let ``ACTUSContractTerm-DS`` = _prefix "ACTUSContractTerm-DS"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-DVANX"></see>
    /// </summary>
    let ``ACTUSContractTerm-DVANX`` = _prefix "ACTUSContractTerm-DVANX"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup-Dividend"></see>
    /// </summary>
    let ``ACTUSContractTermGroup-Dividend`` = _prefix "ACTUSContractTermGroup-Dividend"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-DVCL"></see>
    /// </summary>
    let ``ACTUSContractTerm-DVCL`` = _prefix "ACTUSContractTerm-DVCL"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-DVEX"></see>
    /// </summary>
    let ``ACTUSContractTerm-DVEX`` = _prefix "ACTUSContractTerm-DVEX"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-DVNP"></see>
    /// </summary>
    let ``ACTUSContractTerm-DVNP`` = _prefix "ACTUSContractTerm-DVNP"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-EOMC"></see>
    /// </summary>
    let ``ACTUSContractTerm-EOMC`` = _prefix "ACTUSContractTerm-EOMC"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-FEAC"></see>
    /// </summary>
    let ``ACTUSContractTerm-FEAC`` = _prefix "ACTUSContractTerm-FEAC"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup-Fees"></see>
    /// </summary>
    let ``ACTUSContractTermGroup-Fees`` = _prefix "ACTUSContractTermGroup-Fees"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-FEANX"></see>
    /// </summary>
    let ``ACTUSContractTerm-FEANX`` = _prefix "ACTUSContractTerm-FEANX"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-FEB"></see>
    /// </summary>
    let ``ACTUSContractTerm-FEB`` = _prefix "ACTUSContractTerm-FEB"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-FECL"></see>
    /// </summary>
    let ``ACTUSContractTerm-FECL`` = _prefix "ACTUSContractTerm-FECL"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-FER"></see>
    /// </summary>
    let ``ACTUSContractTerm-FER`` = _prefix "ACTUSContractTerm-FER"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-GRP"></see>
    /// </summary>
    let ``ACTUSContractTerm-GRP`` = _prefix "ACTUSContractTerm-GRP"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IED"></see>
    /// </summary>
    let ``ACTUSContractTerm-IED`` = _prefix "ACTUSContractTerm-IED"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IPAC"></see>
    /// </summary>
    let ``ACTUSContractTerm-IPAC`` = _prefix "ACTUSContractTerm-IPAC"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IPANX"></see>
    /// </summary>
    let ``ACTUSContractTerm-IPANX`` = _prefix "ACTUSContractTerm-IPANX"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IPCB"></see>
    /// </summary>
    let ``ACTUSContractTerm-IPCB`` = _prefix "ACTUSContractTerm-IPCB"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IPCBA"></see>
    /// </summary>
    let ``ACTUSContractTerm-IPCBA`` = _prefix "ACTUSContractTerm-IPCBA"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IPCBANX"></see>
    /// </summary>
    let ``ACTUSContractTerm-IPCBANX`` = _prefix "ACTUSContractTerm-IPCBANX"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IPCBCL"></see>
    /// </summary>
    let ``ACTUSContractTerm-IPCBCL`` = _prefix "ACTUSContractTerm-IPCBCL"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IPCED"></see>
    /// </summary>
    let ``ACTUSContractTerm-IPCED`` = _prefix "ACTUSContractTerm-IPCED"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IPCL"></see>
    /// </summary>
    let ``ACTUSContractTerm-IPCL`` = _prefix "ACTUSContractTerm-IPCL"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IPDC"></see>
    /// </summary>
    let ``ACTUSContractTerm-IPDC`` = _prefix "ACTUSContractTerm-IPDC"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IPNR"></see>
    /// </summary>
    let ``ACTUSContractTerm-IPNR`` = _prefix "ACTUSContractTerm-IPNR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IPNR2"></see>
    /// </summary>
    let ``ACTUSContractTerm-IPNR2`` = _prefix "ACTUSContractTerm-IPNR2"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-IPPNT"></see>
    /// </summary>
    let ``ACTUSContractTerm-IPPNT`` = _prefix "ACTUSContractTerm-IPPNT"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-MD"></see>
    /// </summary>
    let ``ACTUSContractTerm-MD`` = _prefix "ACTUSContractTerm-MD"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-MOC"></see>
    /// </summary>
    let ``ACTUSContractTerm-MOC`` = _prefix "ACTUSContractTerm-MOC"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-MPFD"></see>
    /// </summary>
    let ``ACTUSContractTerm-MPFD`` = _prefix "ACTUSContractTerm-MPFD"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup-Optionality"></see>
    /// </summary>
    let ``ACTUSContractTermGroup-Optionality`` =
        _prefix "ACTUSContractTermGroup-Optionality"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-MRANX"></see>
    /// </summary>
    let ``ACTUSContractTerm-MRANX`` = _prefix "ACTUSContractTerm-MRANX"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup-Margining"></see>
    /// </summary>
    let ``ACTUSContractTermGroup-Margining`` =
        _prefix "ACTUSContractTermGroup-Margining"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-MRCL"></see>
    /// </summary>
    let ``ACTUSContractTerm-MRCL`` = _prefix "ACTUSContractTerm-MRCL"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-MRCLH"></see>
    /// </summary>
    let ``ACTUSContractTerm-MRCLH`` = _prefix "ACTUSContractTerm-MRCLH"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-MRIM"></see>
    /// </summary>
    let ``ACTUSContractTerm-MRIM`` = _prefix "ACTUSContractTerm-MRIM"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-MRMML"></see>
    /// </summary>
    let ``ACTUSContractTerm-MRMML`` = _prefix "ACTUSContractTerm-MRMML"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-MRMMU"></see>
    /// </summary>
    let ``ACTUSContractTerm-MRMMU`` = _prefix "ACTUSContractTerm-MRMMU"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-MRVM"></see>
    /// </summary>
    let ``ACTUSContractTerm-MRVM`` = _prefix "ACTUSContractTerm-MRVM"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-MVO"></see>
    /// </summary>
    let ``ACTUSContractTerm-MVO`` = _prefix "ACTUSContractTerm-MVO"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-NPD"></see>
    /// </summary>
    let ``ACTUSContractTerm-NPD`` = _prefix "ACTUSContractTerm-NPD"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-NT"></see>
    /// </summary>
    let ``ACTUSContractTerm-NT`` = _prefix "ACTUSContractTerm-NT"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-NT2"></see>
    /// </summary>
    let ``ACTUSContractTerm-NT2`` = _prefix "ACTUSContractTerm-NT2"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-OPANX"></see>
    /// </summary>
    let ``ACTUSContractTerm-OPANX`` = _prefix "ACTUSContractTerm-OPANX"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-OPCL"></see>
    /// </summary>
    let ``ACTUSContractTerm-OPCL`` = _prefix "ACTUSContractTerm-OPCL"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-OPS1"></see>
    /// </summary>
    let ``ACTUSContractTerm-OPS1`` = _prefix "ACTUSContractTerm-OPS1"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-OPS2"></see>
    /// </summary>
    let ``ACTUSContractTerm-OPS2`` = _prefix "ACTUSContractTerm-OPS2"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-OPTP"></see>
    /// </summary>
    let ``ACTUSContractTerm-OPTP`` = _prefix "ACTUSContractTerm-OPTP"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-OPXED"></see>
    /// </summary>
    let ``ACTUSContractTerm-OPXED`` = _prefix "ACTUSContractTerm-OPXED"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-OPXT"></see>
    /// </summary>
    let ``ACTUSContractTerm-OPXT`` = _prefix "ACTUSContractTerm-OPXT"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PDIED"></see>
    /// </summary>
    let ``ACTUSContractTerm-PDIED`` = _prefix "ACTUSContractTerm-PDIED"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PFUT"></see>
    /// </summary>
    let ``ACTUSContractTerm-PFUT`` = _prefix "ACTUSContractTerm-PFUT"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PPEF"></see>
    /// </summary>
    let ``ACTUSContractTerm-PPEF`` = _prefix "ACTUSContractTerm-PPEF"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PPP"></see>
    /// </summary>
    let ``ACTUSContractTerm-PPP`` = _prefix "ACTUSContractTerm-PPP"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PPRD"></see>
    /// </summary>
    let ``ACTUSContractTerm-PPRD`` = _prefix "ACTUSContractTerm-PPRD"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PRANX"></see>
    /// </summary>
    let ``ACTUSContractTerm-PRANX`` = _prefix "ACTUSContractTerm-PRANX"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PRCL"></see>
    /// </summary>
    let ``ACTUSContractTerm-PRCL`` = _prefix "ACTUSContractTerm-PRCL"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PRD"></see>
    /// </summary>
    let ``ACTUSContractTerm-PRD`` = _prefix "ACTUSContractTerm-PRD"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PRF"></see>
    /// </summary>
    let ``ACTUSContractTerm-PRF`` = _prefix "ACTUSContractTerm-PRF"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PRNXT"></see>
    /// </summary>
    let ``ACTUSContractTerm-PRNXT`` = _prefix "ACTUSContractTerm-PRNXT"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PTD"></see>
    /// </summary>
    let ``ACTUSContractTerm-PTD`` = _prefix "ACTUSContractTerm-PTD"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PYRT"></see>
    /// </summary>
    let ``ACTUSContractTerm-PYRT`` = _prefix "ACTUSContractTerm-PYRT"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-PYTP"></see>
    /// </summary>
    let ``ACTUSContractTerm-PYTP`` = _prefix "ACTUSContractTerm-PYTP"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-QT"></see>
    /// </summary>
    let ``ACTUSContractTerm-QT`` = _prefix "ACTUSContractTerm-QT"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-RRANX"></see>
    /// </summary>
    let ``ACTUSContractTerm-RRANX`` = _prefix "ACTUSContractTerm-RRANX"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-RRCL"></see>
    /// </summary>
    let ``ACTUSContractTerm-RRCL`` = _prefix "ACTUSContractTerm-RRCL"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-RRFIX"></see>
    /// </summary>
    let ``ACTUSContractTerm-RRFIX`` = _prefix "ACTUSContractTerm-RRFIX"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-RRLC"></see>
    /// </summary>
    let ``ACTUSContractTerm-RRLC`` = _prefix "ACTUSContractTerm-RRLC"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-RRLF"></see>
    /// </summary>
    let ``ACTUSContractTerm-RRLF`` = _prefix "ACTUSContractTerm-RRLF"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-RRMLT"></see>
    /// </summary>
    let ``ACTUSContractTerm-RRMLT`` = _prefix "ACTUSContractTerm-RRMLT"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-RRMO"></see>
    /// </summary>
    let ``ACTUSContractTerm-RRMO`` = _prefix "ACTUSContractTerm-RRMO"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-RRNXT"></see>
    /// </summary>
    let ``ACTUSContractTerm-RRNXT`` = _prefix "ACTUSContractTerm-RRNXT"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-RRPC"></see>
    /// </summary>
    let ``ACTUSContractTerm-RRPC`` = _prefix "ACTUSContractTerm-RRPC"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-RRPF"></see>
    /// </summary>
    let ``ACTUSContractTerm-RRPF`` = _prefix "ACTUSContractTerm-RRPF"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-RRPNT"></see>
    /// </summary>
    let ``ACTUSContractTerm-RRPNT`` = _prefix "ACTUSContractTerm-RRPNT"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-RRSP"></see>
    /// </summary>
    let ``ACTUSContractTerm-RRSP`` = _prefix "ACTUSContractTerm-RRSP"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-SCANX"></see>
    /// </summary>
    let ``ACTUSContractTerm-SCANX`` = _prefix "ACTUSContractTerm-SCANX"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-SCCDD"></see>
    /// </summary>
    let ``ACTUSContractTerm-SCCDD`` = _prefix "ACTUSContractTerm-SCCDD"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-SCCL"></see>
    /// </summary>
    let ``ACTUSContractTerm-SCCL`` = _prefix "ACTUSContractTerm-SCCL"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-SCEF"></see>
    /// </summary>
    let ``ACTUSContractTerm-SCEF`` = _prefix "ACTUSContractTerm-SCEF"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-SCIP"></see>
    /// </summary>
    let ``ACTUSContractTerm-SCIP`` = _prefix "ACTUSContractTerm-SCIP"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-SCMO"></see>
    /// </summary>
    let ``ACTUSContractTerm-SCMO`` = _prefix "ACTUSContractTerm-SCMO"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-SCNT"></see>
    /// </summary>
    let ``ACTUSContractTerm-SCNT`` = _prefix "ACTUSContractTerm-SCNT"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-SD"></see>
    /// </summary>
    let ``ACTUSContractTerm-SD`` = _prefix "ACTUSContractTerm-SD"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-SEN"></see>
    /// </summary>
    let ``ACTUSContractTerm-SEN`` = _prefix "ACTUSContractTerm-SEN"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-STP"></see>
    /// </summary>
    let ``ACTUSContractTerm-STP`` = _prefix "ACTUSContractTerm-STP"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-TD"></see>
    /// </summary>
    let ``ACTUSContractTerm-TD`` = _prefix "ACTUSContractTerm-TD"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-UT"></see>
    /// </summary>
    let ``ACTUSContractTerm-UT`` = _prefix "ACTUSContractTerm-UT"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-XA"></see>
    /// </summary>
    let ``ACTUSContractTerm-XA`` = _prefix "ACTUSContractTerm-XA"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-XD"></see>
    /// </summary>
    let ``ACTUSContractTerm-XD`` = _prefix "ACTUSContractTerm-XD"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm-XDN"></see>
    /// </summary>
    let ``ACTUSContractTerm-XDN`` = _prefix "ACTUSContractTerm-XDN"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/hasParameterMapping"></see>
    /// </summary>
    let hasParameterMapping = _prefix "hasParameterMapping"

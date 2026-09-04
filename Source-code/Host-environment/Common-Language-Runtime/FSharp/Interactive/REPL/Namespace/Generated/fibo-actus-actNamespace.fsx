#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-actus-act`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/" "fibo-actus-act"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : ACTUS business day convention^^xsd:string</para>
    ///   <para>skos:definition : code element for one of a set of conventions that ACTUS supports^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSBusinessDayConvention">fibo-actus-act:ACTUSBusinessDayConvention</a>
    /// </summary>
    let ACTUSBusinessDayConvention = _prefixId.prefix "ACTUSBusinessDayConvention"

    let ACTUSBusinessDayConvention_CSF =
        _prefixId.prefix "ACTUSBusinessDayConvention-CSF"

    let ACTUSBusinessDayConvention_CSMF =
        _prefixId.prefix "ACTUSBusinessDayConvention-CSMF"

    let ACTUSBusinessDayConvention_CSMP =
        _prefixId.prefix "ACTUSBusinessDayConvention-CSMP"

    let ACTUSBusinessDayConvention_CSP =
        _prefixId.prefix "ACTUSBusinessDayConvention-CSP"

    let ACTUSBusinessDayConvention_NOS =
        _prefixId.prefix "ACTUSBusinessDayConvention-NOS"

    let ACTUSBusinessDayConvention_SCF =
        _prefixId.prefix "ACTUSBusinessDayConvention-SCF"

    let ACTUSBusinessDayConvention_SCMF =
        _prefixId.prefix "ACTUSBusinessDayConvention-SCMF"

    let ACTUSBusinessDayConvention_SCMP =
        _prefixId.prefix "ACTUSBusinessDayConvention-SCMP"

    let ACTUSBusinessDayConvention_SCP =
        _prefixId.prefix "ACTUSBusinessDayConvention-SCP"

    let ACTUSCalendarClassifier_MondayToFriday =
        _prefixId.prefix "ACTUSCalendarClassifier-MondayToFriday"

    let ACTUSCalendarClassifier_NoCalendar =
        _prefixId.prefix "ACTUSCalendarClassifier-NoCalendar"

    /// <summary>
    ///   <para>rdfs:label : ACTUS calendar code^^xsd:string</para>
    ///   <para>skos:definition : code for a calendar that applies to a particular contract^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSCalendarCode">fibo-actus-act:ACTUSCalendarCode</a>
    /// </summary>
    let ACTUSCalendarCode = _prefixId.prefix "ACTUSCalendarCode"
    /// <summary>
    ///   <para>rdfs:label : ACTUS contract role classifier^^xsd:string</para>
    ///   <para>dcterms:description : CNTRL defines which position the CRID (the identifier for the creator of the data about the contract, i.e., the record for the contract, which currently must be a contract party, not a third party, such as a regulator, but not necessarily the originator) takes in a contract. For example, whether the contract is an asset or liability, a long or short position for the CRID. Note that this may change as ACTUS evolves beyond the current known implementations and libraries for processing the contract.
    ///
    /// Most contracts are simple on or off balance sheet positions which are assets, liabilities. Such contracts can also play a secondary role as a collateral.
    ///
    /// The attribute is highly significant since it determines the direction of all cash flows. The exact meaning is given with each CT in the ACTUS High Level Specification document.^^xsd:string</para>
    ///   <para>skos:definition : classifier for various roles that are relevant to how the contract is processed by a particular contract party^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : CNTRL^^xsd:string</para>
    ///   <para>cmns-av:synonym : Contract Role^^xsd:stringcmns-av:synonym : contractRole^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractRoleClassifier">fibo-actus-act:ACTUSContractRoleClassifier</a>
    /// </summary>
    let ACTUSContractRoleClassifier = _prefixId.prefix "ACTUSContractRoleClassifier"

    let ACTUSContractRoleClassifier_BUY =
        _prefixId.prefix "ACTUSContractRoleClassifier-BUY"

    let ACTUSContractRoleClassifier_CNO =
        _prefixId.prefix "ACTUSContractRoleClassifier-CNO"

    let ACTUSContractRoleClassifier_COL =
        _prefixId.prefix "ACTUSContractRoleClassifier-COL"

    let ACTUSContractRoleClassifier_GUA =
        _prefixId.prefix "ACTUSContractRoleClassifier-GUA"

    let ACTUSContractRoleClassifier_LG =
        _prefixId.prefix "ACTUSContractRoleClassifier-LG"

    let ACTUSContractRoleClassifier_OBL =
        _prefixId.prefix "ACTUSContractRoleClassifier-OBL"

    let ACTUSContractRoleClassifier_PF =
        _prefixId.prefix "ACTUSContractRoleClassifier-PF"

    let ACTUSContractRoleClassifier_PFL =
        _prefixId.prefix "ACTUSContractRoleClassifier-PFL"

    let ACTUSContractRoleClassifier_RF =
        _prefixId.prefix "ACTUSContractRoleClassifier-RF"

    let ACTUSContractRoleClassifier_RFL =
        _prefixId.prefix "ACTUSContractRoleClassifier-RFL"

    let ACTUSContractRoleClassifier_RPA =
        _prefixId.prefix "ACTUSContractRoleClassifier-RPA"

    let ACTUSContractRoleClassifier_RPL =
        _prefixId.prefix "ACTUSContractRoleClassifier-RPL"

    let ACTUSContractRoleClassifier_SEL =
        _prefixId.prefix "ACTUSContractRoleClassifier-SEL"

    let ACTUSContractRoleClassifier_ST =
        _prefixId.prefix "ACTUSContractRoleClassifier-ST"

    let ACTUSContractRoleClassifier_UDL =
        _prefixId.prefix "ACTUSContractRoleClassifier-UDL"

    let ACTUSContractRoleClassifier_UDLM =
        _prefixId.prefix "ACTUSContractRoleClassifier-UDLM"

    let ACTUSContractRoleClassifier_UDLP =
        _prefixId.prefix "ACTUSContractRoleClassifier-UDLP"

    /// <summary>
    ///   <para>rdfs:label : ACTUS contract term^^xsd:string</para>
    ///   <para>skos:definition : code denoting a term describing an aspect of one or more ACTUS contract type(s)^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTerm">fibo-actus-act:ACTUSContractTerm</a>
    /// </summary>
    let ACTUSContractTerm = _prefixId.prefix "ACTUSContractTerm"
    let ACTUSContractTerm_AMD = _prefixId.prefix "ACTUSContractTerm-AMD"
    let ACTUSContractTerm_ARFIXVAR = _prefixId.prefix "ACTUSContractTerm-ARFIXVAR"
    let ACTUSContractTerm_ARINCDEC = _prefixId.prefix "ACTUSContractTerm-ARINCDEC"
    let ACTUSContractTerm_ARIPANXi = _prefixId.prefix "ACTUSContractTerm-ARIPANXi"
    let ACTUSContractTerm_ARIPCLi = _prefixId.prefix "ACTUSContractTerm-ARIPCLi"
    let ACTUSContractTerm_ARPRANXj = _prefixId.prefix "ACTUSContractTerm-ARPRANXj"
    let ACTUSContractTerm_ARPRCLj = _prefixId.prefix "ACTUSContractTerm-ARPRCLj"
    let ACTUSContractTerm_ARPRNXTj = _prefixId.prefix "ACTUSContractTerm-ARPRNXTj"
    let ACTUSContractTerm_ARRATE = _prefixId.prefix "ACTUSContractTerm-ARRATE"
    let ACTUSContractTerm_ARRRANX = _prefixId.prefix "ACTUSContractTerm-ARRRANX"
    let ACTUSContractTerm_ARRRCL = _prefixId.prefix "ACTUSContractTerm-ARRRCL"
    let ACTUSContractTerm_BCF = _prefixId.prefix "ACTUSContractTerm-BCF"
    let ACTUSContractTerm_BDC = _prefixId.prefix "ACTUSContractTerm-BDC"
    let ACTUSContractTerm_BDR = _prefixId.prefix "ACTUSContractTerm-BDR"
    let ACTUSContractTerm_BEF = _prefixId.prefix "ACTUSContractTerm-BEF"
    let ACTUSContractTerm_BLIA = _prefixId.prefix "ACTUSContractTerm-BLIA"
    let ACTUSContractTerm_BMANX = _prefixId.prefix "ACTUSContractTerm-BMANX"
    let ACTUSContractTerm_BMCL = _prefixId.prefix "ACTUSContractTerm-BMCL"
    let ACTUSContractTerm_BMED = _prefixId.prefix "ACTUSContractTerm-BMED"
    let ACTUSContractTerm_BV = _prefixId.prefix "ACTUSContractTerm-BV"
    let ACTUSContractTerm_CDD = _prefixId.prefix "ACTUSContractTerm-CDD"
    let ACTUSContractTerm_CECV = _prefixId.prefix "ACTUSContractTerm-CECV"
    let ACTUSContractTerm_CEGE = _prefixId.prefix "ACTUSContractTerm-CEGE"
    let ACTUSContractTerm_CETC = _prefixId.prefix "ACTUSContractTerm-CETC"
    let ACTUSContractTerm_CID = _prefixId.prefix "ACTUSContractTerm-CID"
    let ACTUSContractTerm_CLA = _prefixId.prefix "ACTUSContractTerm-CLA"
    let ACTUSContractTerm_CLDR = _prefixId.prefix "ACTUSContractTerm-CLDR"
    let ACTUSContractTerm_CPID = _prefixId.prefix "ACTUSContractTerm-CPID"
    let ACTUSContractTerm_CRID = _prefixId.prefix "ACTUSContractTerm-CRID"
    let ACTUSContractTerm_CT = _prefixId.prefix "ACTUSContractTerm-CT"
    let ACTUSContractTerm_CT_ANN = _prefixId.prefix "ACTUSContractTerm-CT-ANN"
    let ACTUSContractTerm_CT_CAPFL = _prefixId.prefix "ACTUSContractTerm-CT-CAPFL"
    let ACTUSContractTerm_CT_CEC = _prefixId.prefix "ACTUSContractTerm-CT-CEC"
    let ACTUSContractTerm_CT_CEG = _prefixId.prefix "ACTUSContractTerm-CT-CEG"
    let ACTUSContractTerm_CT_CLM = _prefixId.prefix "ACTUSContractTerm-CT-CLM"
    let ACTUSContractTerm_CT_COM = _prefixId.prefix "ACTUSContractTerm-CT-COM"
    let ACTUSContractTerm_CT_CSH = _prefixId.prefix "ACTUSContractTerm-CT-CSH"
    let ACTUSContractTerm_CT_FUTUR = _prefixId.prefix "ACTUSContractTerm-CT-FUTUR"
    let ACTUSContractTerm_CT_FXOUT = _prefixId.prefix "ACTUSContractTerm-CT-FXOUT"
    let ACTUSContractTerm_CT_LAM = _prefixId.prefix "ACTUSContractTerm-CT-LAM"
    let ACTUSContractTerm_CT_LAX = _prefixId.prefix "ACTUSContractTerm-CT-LAX"
    let ACTUSContractTerm_CT_NAM = _prefixId.prefix "ACTUSContractTerm-CT-NAM"
    let ACTUSContractTerm_CT_OPTNS = _prefixId.prefix "ACTUSContractTerm-CT-OPTNS"
    let ACTUSContractTerm_CT_PAM = _prefixId.prefix "ACTUSContractTerm-CT-PAM"
    let ACTUSContractTerm_CT_STK = _prefixId.prefix "ACTUSContractTerm-CT-STK"
    let ACTUSContractTerm_CT_SWAPS = _prefixId.prefix "ACTUSContractTerm-CT-SWAPS"
    let ACTUSContractTerm_CT_SWPPV = _prefixId.prefix "ACTUSContractTerm-CT-SWPPV"
    let ACTUSContractTerm_CT_UMP = _prefixId.prefix "ACTUSContractTerm-CT-UMP"
    let ACTUSContractTerm_CTS = _prefixId.prefix "ACTUSContractTerm-CTS"
    let ACTUSContractTerm_CUR = _prefixId.prefix "ACTUSContractTerm-CUR"
    let ACTUSContractTerm_CUR2 = _prefixId.prefix "ACTUSContractTerm-CUR2"
    let ACTUSContractTerm_CURS = _prefixId.prefix "ACTUSContractTerm-CURS"
    let ACTUSContractTerm_DQP = _prefixId.prefix "ACTUSContractTerm-DQP"
    let ACTUSContractTerm_DQR = _prefixId.prefix "ACTUSContractTerm-DQR"
    let ACTUSContractTerm_DS = _prefixId.prefix "ACTUSContractTerm-DS"
    let ACTUSContractTerm_DVANX = _prefixId.prefix "ACTUSContractTerm-DVANX"
    let ACTUSContractTerm_DVCL = _prefixId.prefix "ACTUSContractTerm-DVCL"
    let ACTUSContractTerm_DVEX = _prefixId.prefix "ACTUSContractTerm-DVEX"
    let ACTUSContractTerm_DVNP = _prefixId.prefix "ACTUSContractTerm-DVNP"
    let ACTUSContractTerm_EOMC = _prefixId.prefix "ACTUSContractTerm-EOMC"
    let ACTUSContractTerm_FEAC = _prefixId.prefix "ACTUSContractTerm-FEAC"
    let ACTUSContractTerm_FEANX = _prefixId.prefix "ACTUSContractTerm-FEANX"
    let ACTUSContractTerm_FEB = _prefixId.prefix "ACTUSContractTerm-FEB"
    let ACTUSContractTerm_FECL = _prefixId.prefix "ACTUSContractTerm-FECL"
    let ACTUSContractTerm_FER = _prefixId.prefix "ACTUSContractTerm-FER"
    let ACTUSContractTerm_GRP = _prefixId.prefix "ACTUSContractTerm-GRP"
    let ACTUSContractTerm_IED = _prefixId.prefix "ACTUSContractTerm-IED"
    let ACTUSContractTerm_IPAC = _prefixId.prefix "ACTUSContractTerm-IPAC"
    let ACTUSContractTerm_IPANX = _prefixId.prefix "ACTUSContractTerm-IPANX"
    let ACTUSContractTerm_IPCB = _prefixId.prefix "ACTUSContractTerm-IPCB"
    let ACTUSContractTerm_IPCBA = _prefixId.prefix "ACTUSContractTerm-IPCBA"
    let ACTUSContractTerm_IPCBANX = _prefixId.prefix "ACTUSContractTerm-IPCBANX"
    let ACTUSContractTerm_IPCBCL = _prefixId.prefix "ACTUSContractTerm-IPCBCL"
    let ACTUSContractTerm_IPCED = _prefixId.prefix "ACTUSContractTerm-IPCED"
    let ACTUSContractTerm_IPCL = _prefixId.prefix "ACTUSContractTerm-IPCL"
    let ACTUSContractTerm_IPDC = _prefixId.prefix "ACTUSContractTerm-IPDC"
    let ACTUSContractTerm_IPNR = _prefixId.prefix "ACTUSContractTerm-IPNR"
    let ACTUSContractTerm_IPNR2 = _prefixId.prefix "ACTUSContractTerm-IPNR2"
    let ACTUSContractTerm_IPPNT = _prefixId.prefix "ACTUSContractTerm-IPPNT"
    let ACTUSContractTerm_MD = _prefixId.prefix "ACTUSContractTerm-MD"
    let ACTUSContractTerm_MOC = _prefixId.prefix "ACTUSContractTerm-MOC"
    let ACTUSContractTerm_MPFD = _prefixId.prefix "ACTUSContractTerm-MPFD"
    let ACTUSContractTerm_MRANX = _prefixId.prefix "ACTUSContractTerm-MRANX"
    let ACTUSContractTerm_MRCL = _prefixId.prefix "ACTUSContractTerm-MRCL"
    let ACTUSContractTerm_MRCLH = _prefixId.prefix "ACTUSContractTerm-MRCLH"
    let ACTUSContractTerm_MRIM = _prefixId.prefix "ACTUSContractTerm-MRIM"
    let ACTUSContractTerm_MRMML = _prefixId.prefix "ACTUSContractTerm-MRMML"
    let ACTUSContractTerm_MRMMU = _prefixId.prefix "ACTUSContractTerm-MRMMU"
    let ACTUSContractTerm_MRVM = _prefixId.prefix "ACTUSContractTerm-MRVM"
    let ACTUSContractTerm_MVO = _prefixId.prefix "ACTUSContractTerm-MVO"
    let ACTUSContractTerm_NPD = _prefixId.prefix "ACTUSContractTerm-NPD"
    let ACTUSContractTerm_NT = _prefixId.prefix "ACTUSContractTerm-NT"
    let ACTUSContractTerm_NT2 = _prefixId.prefix "ACTUSContractTerm-NT2"
    let ACTUSContractTerm_OPANX = _prefixId.prefix "ACTUSContractTerm-OPANX"
    let ACTUSContractTerm_OPCL = _prefixId.prefix "ACTUSContractTerm-OPCL"
    let ACTUSContractTerm_OPS1 = _prefixId.prefix "ACTUSContractTerm-OPS1"
    let ACTUSContractTerm_OPS2 = _prefixId.prefix "ACTUSContractTerm-OPS2"
    let ACTUSContractTerm_OPTP = _prefixId.prefix "ACTUSContractTerm-OPTP"
    let ACTUSContractTerm_OPXED = _prefixId.prefix "ACTUSContractTerm-OPXED"
    let ACTUSContractTerm_OPXT = _prefixId.prefix "ACTUSContractTerm-OPXT"
    let ACTUSContractTerm_PDIED = _prefixId.prefix "ACTUSContractTerm-PDIED"
    let ACTUSContractTerm_PFUT = _prefixId.prefix "ACTUSContractTerm-PFUT"
    let ACTUSContractTerm_PPEF = _prefixId.prefix "ACTUSContractTerm-PPEF"
    let ACTUSContractTerm_PPP = _prefixId.prefix "ACTUSContractTerm-PPP"
    let ACTUSContractTerm_PPRD = _prefixId.prefix "ACTUSContractTerm-PPRD"
    let ACTUSContractTerm_PRANX = _prefixId.prefix "ACTUSContractTerm-PRANX"
    let ACTUSContractTerm_PRCL = _prefixId.prefix "ACTUSContractTerm-PRCL"
    let ACTUSContractTerm_PRD = _prefixId.prefix "ACTUSContractTerm-PRD"
    let ACTUSContractTerm_PRF = _prefixId.prefix "ACTUSContractTerm-PRF"
    let ACTUSContractTerm_PRNXT = _prefixId.prefix "ACTUSContractTerm-PRNXT"
    let ACTUSContractTerm_PTD = _prefixId.prefix "ACTUSContractTerm-PTD"
    let ACTUSContractTerm_PYRT = _prefixId.prefix "ACTUSContractTerm-PYRT"
    let ACTUSContractTerm_PYTP = _prefixId.prefix "ACTUSContractTerm-PYTP"
    let ACTUSContractTerm_QT = _prefixId.prefix "ACTUSContractTerm-QT"
    let ACTUSContractTerm_RRANX = _prefixId.prefix "ACTUSContractTerm-RRANX"
    let ACTUSContractTerm_RRCL = _prefixId.prefix "ACTUSContractTerm-RRCL"
    let ACTUSContractTerm_RRFIX = _prefixId.prefix "ACTUSContractTerm-RRFIX"
    let ACTUSContractTerm_RRLC = _prefixId.prefix "ACTUSContractTerm-RRLC"
    let ACTUSContractTerm_RRLF = _prefixId.prefix "ACTUSContractTerm-RRLF"
    let ACTUSContractTerm_RRMLT = _prefixId.prefix "ACTUSContractTerm-RRMLT"
    let ACTUSContractTerm_RRMO = _prefixId.prefix "ACTUSContractTerm-RRMO"
    let ACTUSContractTerm_RRNXT = _prefixId.prefix "ACTUSContractTerm-RRNXT"
    let ACTUSContractTerm_RRPC = _prefixId.prefix "ACTUSContractTerm-RRPC"
    let ACTUSContractTerm_RRPF = _prefixId.prefix "ACTUSContractTerm-RRPF"
    let ACTUSContractTerm_RRPNT = _prefixId.prefix "ACTUSContractTerm-RRPNT"
    let ACTUSContractTerm_RRSP = _prefixId.prefix "ACTUSContractTerm-RRSP"
    let ACTUSContractTerm_SCANX = _prefixId.prefix "ACTUSContractTerm-SCANX"
    let ACTUSContractTerm_SCCDD = _prefixId.prefix "ACTUSContractTerm-SCCDD"
    let ACTUSContractTerm_SCCL = _prefixId.prefix "ACTUSContractTerm-SCCL"
    let ACTUSContractTerm_SCEF = _prefixId.prefix "ACTUSContractTerm-SCEF"
    let ACTUSContractTerm_SCIP = _prefixId.prefix "ACTUSContractTerm-SCIP"
    let ACTUSContractTerm_SCMO = _prefixId.prefix "ACTUSContractTerm-SCMO"
    let ACTUSContractTerm_SCNT = _prefixId.prefix "ACTUSContractTerm-SCNT"
    let ACTUSContractTerm_SD = _prefixId.prefix "ACTUSContractTerm-SD"
    let ACTUSContractTerm_SEN = _prefixId.prefix "ACTUSContractTerm-SEN"
    let ACTUSContractTerm_STP = _prefixId.prefix "ACTUSContractTerm-STP"
    let ACTUSContractTerm_TD = _prefixId.prefix "ACTUSContractTerm-TD"
    let ACTUSContractTerm_UT = _prefixId.prefix "ACTUSContractTerm-UT"
    let ACTUSContractTerm_XA = _prefixId.prefix "ACTUSContractTerm-XA"
    let ACTUSContractTerm_XD = _prefixId.prefix "ACTUSContractTerm-XD"
    let ACTUSContractTerm_XDN = _prefixId.prefix "ACTUSContractTerm-XDN"
    /// <summary>
    ///   <para>rdfs:label : ACTUS dictionary term group^^xsd:string</para>
    ///   <para>skos:definition : classifier for a collection of ACTUS dictionary parameters that tend to be applied together^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/ACTUSContractTermGroup">fibo-actus-act:ACTUSContractTermGroup</a>
    /// </summary>
    let ACTUSContractTermGroup = _prefixId.prefix "ACTUSContractTermGroup"

    let ACTUSContractTermGroup_Boundary =
        _prefixId.prefix "ACTUSContractTermGroup-Boundary"

    let ACTUSContractTermGroup_Calendar =
        _prefixId.prefix "ACTUSContractTermGroup-Calendar"

    let ACTUSContractTermGroup_ContractIdentification =
        _prefixId.prefix "ACTUSContractTermGroup-ContractIdentification"

    let ACTUSContractTermGroup_Counterparty =
        _prefixId.prefix "ACTUSContractTermGroup-Counterparty"

    let ACTUSContractTermGroup_Dividend =
        _prefixId.prefix "ACTUSContractTermGroup-Dividend"

    let ACTUSContractTermGroup_Fees = _prefixId.prefix "ACTUSContractTermGroup-Fees"

    let ACTUSContractTermGroup_Interest =
        _prefixId.prefix "ACTUSContractTermGroup-Interest"

    let ACTUSContractTermGroup_Margining =
        _prefixId.prefix "ACTUSContractTermGroup-Margining"

    let ACTUSContractTermGroup_NotionalPrincipal =
        _prefixId.prefix "ACTUSContractTermGroup-NotionalPrincipal"

    let ACTUSContractTermGroup_Optionality =
        _prefixId.prefix "ACTUSContractTermGroup-Optionality"

    let ACTUSContractTermGroup_RateReset =
        _prefixId.prefix "ACTUSContractTermGroup-RateReset"

    let ACTUSContractTermGroup_Settlement =
        _prefixId.prefix "ACTUSContractTermGroup-Settlement"

    let AlgorithmicContractTypesDataDictionary =
        _prefixId.prefix "AlgorithmicContractTypesDataDictionary"

    /// <summary>
    ///   <para>rdfs:label : has option sequence number^^xsd:string</para>
    ///   <para>skos:definition : specifies the order of occurance of an optional element in an enumerated list^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/hasOptionSequenceNumber">fibo-actus-act:hasOptionSequenceNumber</a>
    /// </summary>
    let hasOptionSequenceNumber = _prefixId.prefix "hasOptionSequenceNumber"
    /// <summary>
    ///   <para>rdfs:label : has parameter mapping^^xsd:string</para>
    ///   <para>skos:definition : maps a quantitative or qualitative parameter defined in the ACTUS data dictionary with something else, such as a property specified in FIBO^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/hasParameterMapping">fibo-actus-act:hasParameterMapping</a>
    /// </summary>
    let hasParameterMapping = _prefixId.prefix "hasParameterMapping"
    /// <summary>
    ///   <para>rdfs:label : has parameter name^^xsd:string</para>
    ///   <para>skos:definition : associates a name with a quantitative or qualitative factor defined in the ACTUS data dictionary used as a condition for classification of one or more contract type^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/hasParameterName">fibo-actus-act:hasParameterName</a>
    /// </summary>
    let hasParameterName = _prefixId.prefix "hasParameterName"

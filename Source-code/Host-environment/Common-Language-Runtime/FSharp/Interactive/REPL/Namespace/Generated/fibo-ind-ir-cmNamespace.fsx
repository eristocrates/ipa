#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-ind-ir-cm`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/" "fibo-ind-ir-cm"

    let _namespaceIri = _prefixId.prefix ""
    let AED_EIBOR = _prefixId.prefix "AED-EIBOR"
    let AUD_AONIA = _prefixId.prefix "AUD-AONIA"
    let AUD_AONIA_OIS_Compound = _prefixId.prefix "AUD-AONIA-OIS_Compound"
    let AUD_BBR_ISDC = _prefixId.prefix "AUD-BBR-ISDC"
    let AUD_BBSW = _prefixId.prefix "AUD-BBSW"

    let AUD_BBSW_Quarterly_Swap_Rate_ICAP =
        _prefixId.prefix "AUD-BBSW_Quarterly_Swap_Rate_ICAP"

    let AUD_BBSW_Semi_Annual_Swap_Rate_ICAP =
        _prefixId.prefix "AUD-BBSW_Semi_Annual_Swap_Rate_ICAP"

    let AUD_BBSY_Bid = _prefixId.prefix "AUD-BBSY_Bid"
    let AUD_LIBOR_BBA = _prefixId.prefix "AUD-LIBOR-BBA"
    let AUD_LIBOR_BBA_Bloomberg = _prefixId.prefix "AUD-LIBOR-BBA-Bloomberg"
    let AUD_LIBOR_Reference_Banks = _prefixId.prefix "AUD-LIBOR-Reference_Banks"

    let AUD_Quarterly_Swap_Rate_ICAP_Reference_Banks =
        _prefixId.prefix "AUD-Quarterly_Swap_Rate-ICAP-Reference_Banks"

    let AUD_Semi_Annual_Swap_Rate_11_00_BGCANTOR =
        _prefixId.prefix "AUD-Semi-Annual_Swap_Rate-11_00-BGCANTOR"

    let AUD_Semi_Annual_Swap_Rate_BGCANTOR_Reference_Banks =
        _prefixId.prefix "AUD-Semi-Annual_Swap_Rate-BGCANTOR-Reference_Banks"

    let AUD_Semi_Annual_Swap_Rate_ICAP_Reference_Banks =
        _prefixId.prefix "AUD-Semi-Annual_Swap_Rate-ICAP-Reference_Banks"

    let AUD_Swap_Rate_Reuters = _prefixId.prefix "AUD-Swap_Rate-Reuters"
    let BRL_CDI = _prefixId.prefix "BRL-CDI"
    let CAD_BA_ISDD = _prefixId.prefix "CAD-BA-ISDD"
    let CAD_BA_Reference_Banks = _prefixId.prefix "CAD-BA-Reference_Banks"
    let CAD_BA_Telerate = _prefixId.prefix "CAD-BA-Telerate"
    let CAD_CDOR = _prefixId.prefix "CAD-CDOR"
    let CAD_CORRA = _prefixId.prefix "CAD-CORRA"
    let CAD_CORRA_OIS_Compound = _prefixId.prefix "CAD-CORRA-OIS_Compound"
    let CAD_CORRA_CanDeal_TMX_Term = _prefixId.prefix "CAD-CORRA_CanDeal_TMX_Term"
    let CAD_CORRA_Compounded_Index = _prefixId.prefix "CAD-CORRA_Compounded_Index"
    let CAD_ISDA_Swap_Rate = _prefixId.prefix "CAD-ISDA-Swap_Rate"
    let CAD_LIBOR_BBA = _prefixId.prefix "CAD-LIBOR-BBA"
    let CAD_LIBOR_BBA_Bloomberg = _prefixId.prefix "CAD-LIBOR-BBA-Bloomberg"
    let CAD_LIBOR_BBA_SwapMarker = _prefixId.prefix "CAD-LIBOR-BBA-SwapMarker"
    let CAD_LIBOR_Reference_Banks = _prefixId.prefix "CAD-LIBOR-Reference_Banks"
    let CAD_REPO_CORRA = _prefixId.prefix "CAD-REPO-CORRA"
    let CAD_TBILL_ISDD = _prefixId.prefix "CAD-TBILL-ISDD"
    let CAD_TBILL_Reference_Banks = _prefixId.prefix "CAD-TBILL-Reference_Banks"
    let CAD_TBILL_Reuters = _prefixId.prefix "CAD-TBILL-Reuters"
    let CAD_TBILL_Telerate = _prefixId.prefix "CAD-TBILL-Telerate"

    let CHF_3M_LIBOR_SWAP_CME_vs_LCH_ICAP =
        _prefixId.prefix "CHF-3M_LIBOR_SWAP-CME_vs_LCH-ICAP"

    let CHF_3M_LIBOR_SWAP_CME_vs_LCH_ICAP_Bloomberg =
        _prefixId.prefix "CHF-3M_LIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg"

    let CHF_3M_LIBOR_SWAP_EUREX_vs_LCH_ICAP =
        _prefixId.prefix "CHF-3M_LIBOR_SWAP-EUREX_vs_LCH-ICAP"

    let CHF_3M_LIBOR_SWAP_EUREX_vs_LCH_ICAP_Bloomberg =
        _prefixId.prefix "CHF-3M_LIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg"

    let CHF_6M_LIBORSWAP_CME_vs_LCH_ICAP_Bloomberg =
        _prefixId.prefix "CHF-6M_LIBORSWAP-CME_vs_LCH-ICAP-Bloomberg"

    let CHF_6M_LIBOR_SWAP_CME_vs_LCH_ICAP =
        _prefixId.prefix "CHF-6M_LIBOR_SWAP-CME_vs_LCH-ICAP"

    let CHF_6M_LIBOR_SWAP_EUREX_vs_LCH_ICAP =
        _prefixId.prefix "CHF-6M_LIBOR_SWAP-EUREX_vs_LCH-ICAP"

    let CHF_6M_LIBOR_SWAP_EUREX_vs_LCH_ICAP_Bloomberg =
        _prefixId.prefix "CHF-6M_LIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg"

    let CHF_Annual_Swap_Rate = _prefixId.prefix "CHF-Annual_Swap_Rate"

    let CHF_Annual_Swap_Rate_11_00_ICAP =
        _prefixId.prefix "CHF-Annual_Swap_Rate-11_00-ICAP"

    let CHF_Annual_Swap_Rate_Reference_Banks =
        _prefixId.prefix "CHF-Annual_Swap_Rate-Reference_Banks"

    let CHF_Basis_Swap_3m_vs_6m_LIBOR_11_00_ICAP =
        _prefixId.prefix "CHF-Basis_Swap-3m_vs_6m-LIBOR-11_00-ICAP"

    let CHF_ISDAFIX_Swap_Rate = _prefixId.prefix "CHF-ISDAFIX-Swap_Rate"
    let CHF_LIBOR = _prefixId.prefix "CHF-LIBOR"
    let CHF_LIBOR_ISDA = _prefixId.prefix "CHF-LIBOR-ISDA"
    let CHF_LIBOR_Reference_Banks = _prefixId.prefix "CHF-LIBOR-Reference_Banks"
    let CHF_OIS_11_00_ICAP = _prefixId.prefix "CHF-OIS-11_00-ICAP"
    let CHF_SARON = _prefixId.prefix "CHF-SARON"
    let CHF_SARON_OIS_Compound = _prefixId.prefix "CHF-SARON-OIS_Compound"
    let CHF_SARON_Average_12M = _prefixId.prefix "CHF-SARON_Average_12M"
    let CHF_SARON_Average_1M = _prefixId.prefix "CHF-SARON_Average_1M"
    let CHF_SARON_Average_1W = _prefixId.prefix "CHF-SARON_Average_1W"
    let CHF_SARON_Average_2M = _prefixId.prefix "CHF-SARON_Average_2M"
    let CHF_SARON_Average_3M = _prefixId.prefix "CHF-SARON_Average_3M"
    let CHF_SARON_Average_6M = _prefixId.prefix "CHF-SARON_Average_6M"
    let CHF_SARON_Average_9M = _prefixId.prefix "CHF-SARON_Average_9M"
    let CHF_SARON_Compounded_Index = _prefixId.prefix "CHF-SARON_Compounded_Index"
    let CHF_TOIS_OIS_COMPOUND = _prefixId.prefix "CHF-TOIS-OIS-COMPOUND"

    let CHF_USD_Basis_Swaps_11_00_ICAP =
        _prefixId.prefix "CHF_USD-Basis_Swaps-11_00-ICAP"

    let CLP_ICP = _prefixId.prefix "CLP-ICP"
    let CLP_TNA = _prefixId.prefix "CLP-TNA"
    let CNY_Deposit_Rate = _prefixId.prefix "CNY-Deposit_Rate"
    let CNY_Fixing_Repo_Rate = _prefixId.prefix "CNY-Fixing_Repo_Rate"
    let CNY_LPR = _prefixId.prefix "CNY-LPR"

    let CNY_Quarterly_7D_Repo_NDS_Rate_Tradition =
        _prefixId.prefix "CNY-Quarterly_7D_Repo_NDS_Rate_Tradition"

    let CNY_Quarterly_7_day_Repo_Non_Deliverable_Swap_Rate_TRADITION_Reference_Banks =
        _prefixId.prefix "CNY-Quarterly_7_day_Repo_Non_Deliverable_Swap_Rate-TRADITION-Reference_Banks"

    let CNY_SHIBOR = _prefixId.prefix "CNY-SHIBOR"
    let CNY_SHIBOR_OIS_Compound = _prefixId.prefix "CNY-SHIBOR-OIS_Compound"

    let CNY_Semi_Annual_Swap_Rate_11_00_BGCANTOR =
        _prefixId.prefix "CNY-Semi-Annual_Swap_Rate-11_00-BGCANTOR"

    let CNY_Semi_Annual_Swap_Rate_Reference_Banks =
        _prefixId.prefix "CNY-Semi-Annual_Swap_Rate-Reference_Banks"

    let CNY_7_Repo_Compounding_Date = _prefixId.prefix "CNY_7-Repo_Compounding_Date"
    let COP_IBR_OIS_Compound = _prefixId.prefix "COP-IBR-OIS_Compound"

    let CZK_Annual_Swap_Rate_11_00_BGCANTOR =
        _prefixId.prefix "CZK-Annual_Swap_Rate-11_00-BGCANTOR"

    let CZK_Annual_Swap_Rate_Reference_Banks =
        _prefixId.prefix "CZK-Annual_Swap_Rate-Reference_Banks"

    let CZK_CZEONIA = _prefixId.prefix "CZK-CZEONIA"
    let CZK_CZEONIA_OIS_Compound = _prefixId.prefix "CZK-CZEONIA-OIS_Compound"
    let CZK_PRIBOR = _prefixId.prefix "CZK-PRIBOR"
    let CZK_PRIBOR_Reference_Banks = _prefixId.prefix "CZK-PRIBOR-Reference_Banks"
    let DKK_CIBOR = _prefixId.prefix "DKK-CIBOR"
    let DKK_CIBOR_Reference_Banks = _prefixId.prefix "DKK-CIBOR-Reference_Banks"
    let DKK_CIBOR2 = _prefixId.prefix "DKK-CIBOR2"
    let DKK_CITA = _prefixId.prefix "DKK-CITA"
    let DKK_DESTR = _prefixId.prefix "DKK-DESTR"
    let DKK_DESTR_OIS_Compound = _prefixId.prefix "DKK-DESTR-OIS_Compound"
    let DKK_DESTR_Compounded_Index = _prefixId.prefix "DKK-DESTR_Compounded_Index"
    let DKK_Tom_Next_OIS_Compound = _prefixId.prefix "DKK-Tom_Next-OIS_Compound"

    let EUR_3M_EURIBOR_SWAP_CME_vs_LCH_ICAP =
        _prefixId.prefix "EUR-3M_EURIBOR_SWAP-CME_vs_LCH-ICAP"

    let EUR_3M_EURIBOR_SWAP_CME_vs_LCH_ICAP_Bloomberg =
        _prefixId.prefix "EUR-3M_EURIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg"

    let EUR_3M_EURIBOR_SWAP_EUREX_vs_LCH_ICAP =
        _prefixId.prefix "EUR-3M_EURIBOR_SWAP-EUREX_vs_LCH-ICAP"

    let EUR_3M_EURIBOR_SWAP_EUREX_vs_LCH_ICAP_Bloomberg =
        _prefixId.prefix "EUR-3M_EURIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg"

    let EUR_6M_EURIBOR_SWAP_CME_vs_LCH_ICAP =
        _prefixId.prefix "EUR-6M_EURIBOR_SWAP-CME_vs_LCH-ICAP"

    let EUR_6M_EURIBOR_SWAP_CME_vs_LCH_ICAP_Bloomberg =
        _prefixId.prefix "EUR-6M_EURIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg"

    let EUR_6M_EURIBOR_SWAP_EUREX_vs_LCH_ICAP =
        _prefixId.prefix "EUR-6M_EURIBOR_SWAP-EUREX_vs_LCH-ICAP"

    let EUR_6M_EURIBOR_SWAP_EUREX_vs_LCH_ICAP_Bloomberg =
        _prefixId.prefix "EUR-6M_EURIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg"

    let EUR_Annual_Swap_Rate_10_00 = _prefixId.prefix "EUR-Annual_Swap_Rate-10_00"

    let EUR_Annual_Swap_Rate_10_00_BGCANTOR =
        _prefixId.prefix "EUR-Annual_Swap_Rate-10_00-BGCANTOR"

    let EUR_Annual_Swap_Rate_10_00_Bloomberg =
        _prefixId.prefix "EUR-Annual_Swap_Rate-10_00-Bloomberg"

    let EUR_Annual_Swap_Rate_10_00_ICAP =
        _prefixId.prefix "EUR-Annual_Swap_Rate-10_00-ICAP"

    let EUR_Annual_Swap_Rate_10_00_SwapMarker =
        _prefixId.prefix "EUR-Annual_Swap_Rate-10_00-SwapMarker"

    let EUR_Annual_Swap_Rate_10_00_TRADITION =
        _prefixId.prefix "EUR-Annual_Swap_Rate-10_00-TRADITION"

    let EUR_Annual_Swap_Rate_11_00 = _prefixId.prefix "EUR-Annual_Swap_Rate-11_00"

    let EUR_Annual_Swap_Rate_11_00_Bloomberg =
        _prefixId.prefix "EUR-Annual_Swap_Rate-11_00-Bloomberg"

    let EUR_Annual_Swap_Rate_11_00_ICAP =
        _prefixId.prefix "EUR-Annual_Swap_Rate-11_00-ICAP"

    let EUR_Annual_Swap_Rate_11_00_SwapMarker =
        _prefixId.prefix "EUR-Annual_Swap_Rate-11_00-SwapMarker"

    let EUR_Annual_Swap_Rate_3_Month = _prefixId.prefix "EUR-Annual_Swap_Rate-3_Month"

    let EUR_Annual_Swap_Rate_3_Month_SwapMarker =
        _prefixId.prefix "EUR-Annual_Swap_Rate-3_Month-SwapMarker"

    let EUR_Annual_Swap_Rate_4_15_TRADITION =
        _prefixId.prefix "EUR-Annual_Swap_Rate-4_15-TRADITION"

    let EUR_Annual_Swap_Rate_Reference_Banks =
        _prefixId.prefix "EUR-Annual_Swap_Rate-Reference_Banks"

    let EUR_CNO_TEC10 = _prefixId.prefix "EUR-CNO_TEC10"
    let EUR_EONIA = _prefixId.prefix "EUR-EONIA"
    let EUR_EONIA_Average = _prefixId.prefix "EUR-EONIA-Average"
    let EUR_EONIA_OIS_10_00_BGCANTOR = _prefixId.prefix "EUR-EONIA-OIS-10_00-BGCANTOR"
    let EUR_EONIA_OIS_10_00_ICAP = _prefixId.prefix "EUR-EONIA-OIS-10_00-ICAP"
    let EUR_EONIA_OIS_10_00_TRADITION = _prefixId.prefix "EUR-EONIA-OIS-10_00-TRADITION"
    let EUR_EONIA_OIS_11_00_ICAP = _prefixId.prefix "EUR-EONIA-OIS-11_00-ICAP"
    let EUR_EONIA_OIS_4_15_TRADITION = _prefixId.prefix "EUR-EONIA-OIS-4_15-TRADITION"
    let EUR_EONIA_OIS_Compound = _prefixId.prefix "EUR-EONIA-OIS_Compound"
    let EUR_EONIA_Swap_Index = _prefixId.prefix "EUR-EONIA-Swap-Index"
    let EUR_EURIBOR = _prefixId.prefix "EUR-EURIBOR"
    let EUR_EURIBOR_Act_365 = _prefixId.prefix "EUR-EURIBOR-Act_365"
    let EUR_EURIBOR_Act_365_Bloomberg = _prefixId.prefix "EUR-EURIBOR-Act_365-Bloomberg"
    let EUR_EURIBOR_Reference_Banks = _prefixId.prefix "EUR-EURIBOR-Reference_Banks"
    let EUR_EURIBOR_Telerate = _prefixId.prefix "EUR-EURIBOR-Telerate"

    let EUR_EURIBOR_ICE_Swap_Rate_11_00 =
        _prefixId.prefix "EUR-EURIBOR_ICE_Swap_Rate-11_00"

    let EUR_EURIBOR_ICE_Swap_Rate_12_00 =
        _prefixId.prefix "EUR-EURIBOR_ICE_Swap_Rate-12_00"

    let EUR_EURONIA_OIS_Compound = _prefixId.prefix "EUR-EURONIA-OIS_Compound"
    let EUR_EuroSTR = _prefixId.prefix "EUR-EuroSTR"
    let EUR_EuroSTR_OIS_Compound = _prefixId.prefix "EUR-EuroSTR-OIS_Compound"
    let EUR_EuroSTR_Average_12M = _prefixId.prefix "EUR-EuroSTR_Average_12M"
    let EUR_EuroSTR_Average_1M = _prefixId.prefix "EUR-EuroSTR_Average_1M"
    let EUR_EuroSTR_Average_1W = _prefixId.prefix "EUR-EuroSTR_Average_1W"
    let EUR_EuroSTR_Average_3M = _prefixId.prefix "EUR-EuroSTR_Average_3M"
    let EUR_EuroSTR_Average_6M = _prefixId.prefix "EUR-EuroSTR_Average_6M"
    let EUR_EuroSTR_Compounded_Index = _prefixId.prefix "EUR-EuroSTR_Compounded_Index"
    let EUR_EuroSTR_FTSE_Term = _prefixId.prefix "EUR-EuroSTR_FTSE_Term"

    let EUR_EuroSTR_ICE_Compounded_Index =
        _prefixId.prefix "EUR-EuroSTR_ICE_Compounded_Index"

    let EUR_EuroSTR_ICE_Compounded_Index_0_Floor =
        _prefixId.prefix "EUR-EuroSTR_ICE_Compounded_Index_0_Floor"

    let EUR_EuroSTR_ICE_Compounded_Index_0_Floor_2D_Lag =
        _prefixId.prefix "EUR-EuroSTR_ICE_Compounded_Index_0_Floor_2D_Lag"

    let EUR_EuroSTR_ICE_Compounded_Index_0_Floor_5D_Lag =
        _prefixId.prefix "EUR-EuroSTR_ICE_Compounded_Index_0_Floor_5D_Lag"

    let EUR_EuroSTR_ICE_Compounded_Index_2D_Lag =
        _prefixId.prefix "EUR-EuroSTR_ICE_Compounded_Index_2D_Lag"

    let EUR_EuroSTR_ICE_Compounded_Index_5D_Lag =
        _prefixId.prefix "EUR-EuroSTR_ICE_Compounded_Index_5D_Lag"

    let EUR_EuroSTR_ICE_Swap_Rate = _prefixId.prefix "EUR-EuroSTR_ICE_Swap_Rate"
    let EUR_EuroSTR_Term = _prefixId.prefix "EUR-EuroSTR_Term"

    let EUR_ISDA_LIBOR_Swap_Rate_10_00 =
        _prefixId.prefix "EUR-ISDA-LIBOR_Swap_Rate-10_00"

    let EUR_ISDA_LIBOR_Swap_Rate_11_00 =
        _prefixId.prefix "EUR-ISDA-LIBOR_Swap_Rate-11_00"

    let EUR_LIBOR = _prefixId.prefix "EUR-LIBOR"
    let EUR_LIBOR_Reference_Banks = _prefixId.prefix "EUR-LIBOR-Reference_Banks"
    let EUR_TAM_CDC = _prefixId.prefix "EUR-TAM-CDC"
    let EUR_TEC10_Reference_Banks = _prefixId.prefix "EUR-TEC10-Reference_Banks"
    let EUR_TEC5_CNO = _prefixId.prefix "EUR-TEC5-CNO"
    let EUR_TEC5_CNO_SwapMarker = _prefixId.prefix "EUR-TEC5-CNO-SwapMarker"
    let EUR_TEC5_Reference_Banks = _prefixId.prefix "EUR-TEC5-Reference_Banks"
    let EUR_TMM_CDC_COMPOUND = _prefixId.prefix "EUR-TMM-CDC-COMPOUND"

    let EUR_Basis_Swap_EONIA_vs_3m_EUR_IBOR_Swap_Rates_A_360_10_00_ICAP =
        _prefixId.prefix "EUR_Basis_Swap-EONIA_vs_3m_EUR_IBOR_Swap_Rates-A_360-10_00-ICAP"

    let EUR_EURIBOR_Annual_Bond_Swap_vs_1m_11_00_ICAP =
        _prefixId.prefix "EUR_EURIBOR-Annual_Bond_Swap_vs_1m-11_00-ICAP"

    let EUR_EURIBOR_Basis_Swap_1m_vs_3m_Euribor_11_00_ICAP =
        _prefixId.prefix "EUR_EURIBOR-Basis_Swap-1m_vs_3m-Euribor-11_00-ICAP"

    let EUR_EURIBOR_Basis_Swap_3m_vs_6m_11_00_ICAP =
        _prefixId.prefix "EUR_EURIBOR-Basis_Swap-3m_vs_6m-11_00-ICAP"

    let EUR_USD_Basis_Swaps_11_00_ICAP =
        _prefixId.prefix "EUR_USD-Basis_Swaps-11_00-ICAP"

    let GBP_6M_LIBOR_SWAP_CME_vs_LCH_ICAP =
        _prefixId.prefix "GBP-6M_LIBOR_SWAP-CME_vs_LCH-ICAP"

    let GBP_6M_LIBOR_SWAP_CME_vs_LCH_ICAP_Bloomberg =
        _prefixId.prefix "GBP-6M_LIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg"

    let GBP_6M_LIBOR_SWAP_EUREX_vs_LCH_ICAP =
        _prefixId.prefix "GBP-6M_LIBOR_SWAP-EUREX_vs_LCH-ICAP"

    let GBP_6M_LIBOR_SWAP_EUREX_vs_LCH_ICAP_Bloomberg =
        _prefixId.prefix "GBP-6M_LIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg"

    let GBP_LIBOR = _prefixId.prefix "GBP-LIBOR"
    let GBP_LIBOR_ISDA = _prefixId.prefix "GBP-LIBOR-ISDA"
    let GBP_LIBOR_Reference_Banks = _prefixId.prefix "GBP-LIBOR-Reference_Banks"
    let GBP_LIBOR_ICE_Swap_Rate = _prefixId.prefix "GBP-LIBOR_ICE_Swap_Rate"
    let GBP_RONIA = _prefixId.prefix "GBP-RONIA"
    let GBP_RONIA_OIS_Compound = _prefixId.prefix "GBP-RONIA-OIS_Compound"
    let GBP_SONIA = _prefixId.prefix "GBP-SONIA"
    let GBP_SONIA_OIS_11_00_ICAP = _prefixId.prefix "GBP-SONIA-OIS-11_00-ICAP"
    let GBP_SONIA_OIS_11_00_TRADITION = _prefixId.prefix "GBP-SONIA-OIS-11_00-TRADITION"
    let GBP_SONIA_OIS_4_15_TRADITION = _prefixId.prefix "GBP-SONIA-OIS-4_15-TRADITION"
    let GBP_SONIA_OIS_Compound = _prefixId.prefix "GBP-SONIA-OIS_Compound"
    let GBP_SONIA_Compounded_Index = _prefixId.prefix "GBP-SONIA_Compounded_Index"
    let GBP_SONIA_FTSE_Term = _prefixId.prefix "GBP-SONIA_FTSE_Term"

    let GBP_SONIA_ICE_Compounded_Index =
        _prefixId.prefix "GBP-SONIA_ICE_Compounded_Index"

    let GBP_SONIA_ICE_Compounded_Index_0_Floor =
        _prefixId.prefix "GBP-SONIA_ICE_Compounded_Index_0_Floor"

    let GBP_SONIA_ICE_Compounded_Index_0_Floor_2D_Lag =
        _prefixId.prefix "GBP-SONIA_ICE_Compounded_Index_0_Floor_2D_Lag"

    let GBP_SONIA_ICE_Compounded_Index_0_Floor_5D_Lag =
        _prefixId.prefix "GBP-SONIA_ICE_Compounded_Index_0_Floor_5D_Lag"

    let GBP_SONIA_ICE_Compounded_Index_2D_Lag =
        _prefixId.prefix "GBP-SONIA_ICE_Compounded_Index_2D_Lag"

    let GBP_SONIA_ICE_Compounded_Index_5D_Lag =
        _prefixId.prefix "GBP-SONIA_ICE_Compounded_Index_5D_Lag"

    let GBP_SONIA_ICE_Swap_Rate = _prefixId.prefix "GBP-SONIA_ICE_Swap_Rate"
    let GBP_SONIA_ICE_Term = _prefixId.prefix "GBP-SONIA_ICE_Term"
    let GBP_Semi_Annual_Swap_Rate = _prefixId.prefix "GBP-Semi-Annual_Swap_Rate"

    let GBP_Semi_Annual_Swap_Rate_11_00_ICAP =
        _prefixId.prefix "GBP-Semi-Annual_Swap_Rate-11_00-ICAP"

    let GBP_Semi_Annual_Swap_Rate_Reference_Banks =
        _prefixId.prefix "GBP-Semi-Annual_Swap_Rate-Reference_Banks"

    let GBP_Semi_Annual_Swap_Rate_SwapMarker26 =
        _prefixId.prefix "GBP-Semi-Annual_Swap_Rate-SwapMarker26"

    let GBP_Semi_Annual_Swap_Rate_11_00_TRADITION =
        _prefixId.prefix "GBP-Semi_Annual_Swap_Rate-11_00-TRADITION"

    let GBP_Semi_Annual_Swap_Rate_4_15_TRADITION =
        _prefixId.prefix "GBP-Semi_Annual_Swap_Rate-4_15-TRADITION"

    let GBP_UK_Base_Rate = _prefixId.prefix "GBP-UK_Base_Rate"

    let GBP_USD_Basis_Swaps_11_00_ICAP =
        _prefixId.prefix "GBP_USD-Basis_Swaps-11_00-ICAP"

    let GRD_ATHIBOR_ATHIBOR = _prefixId.prefix "GRD-ATHIBOR-ATHIBOR"
    let GRD_ATHIBOR_Reference_Banks = _prefixId.prefix "GRD-ATHIBOR-Reference_Banks"
    let GRD_ATHIBOR_Telerate = _prefixId.prefix "GRD-ATHIBOR-Telerate"
    let GRD_ATHIMID_Reference_Banks = _prefixId.prefix "GRD-ATHIMID-Reference_Banks"
    let GRD_ATHIMID_Reuters = _prefixId.prefix "GRD-ATHIMID-Reuters"
    let HKD_HIBOR = _prefixId.prefix "HKD-HIBOR"
    let HKD_HIBOR_HIBOR_Bloomberg = _prefixId.prefix "HKD-HIBOR-HIBOR-Bloomberg"
    let HKD_HIBOR_HIBOR_ = _prefixId.prefix "HKD-HIBOR-HIBOR_"
    let HKD_HIBOR_ISDC = _prefixId.prefix "HKD-HIBOR-ISDC"
    let HKD_HIBOR_Reference_Banks = _prefixId.prefix "HKD-HIBOR-Reference_Banks"
    let HKD_HONIA = _prefixId.prefix "HKD-HONIA"
    let HKD_HONIA_OIS_Compound = _prefixId.prefix "HKD-HONIA-OIS_Compound"
    let HKD_ISDA_Swap_Rate_11_00 = _prefixId.prefix "HKD-ISDA-Swap_Rate-11_00"
    let HKD_ISDA_Swap_Rate_4_00 = _prefixId.prefix "HKD-ISDA-Swap_Rate-4_00"

    let HKD_Quarterly_Annual_Swap_Rate_11_00_BGCANTOR =
        _prefixId.prefix "HKD-Quarterly-Annual_Swap_Rate-11_00-BGCANTOR"

    let HKD_Quarterly_Annual_Swap_Rate_11_00_TRADITION =
        _prefixId.prefix "HKD-Quarterly-Annual_Swap_Rate-11_00-TRADITION"

    let HKD_Quarterly_Annual_Swap_Rate_4_00_BGCANTOR =
        _prefixId.prefix "HKD-Quarterly-Annual_Swap_Rate-4_00-BGCANTOR"

    let HKD_Quarterly_Annual_Swap_Rate_Reference_Banks =
        _prefixId.prefix "HKD-Quarterly-Annual_Swap_Rate-Reference_Banks"

    let HKD_Quarterly_Quarterly_Swap_Rate_11_00_ICAP =
        _prefixId.prefix "HKD-Quarterly-Quarterly_Swap_Rate-11_00-ICAP"

    let HKD_Quarterly_Quarterly_Swap_Rate_4_00_ICAP =
        _prefixId.prefix "HKD-Quarterly-Quarterly_Swap_Rate-4_00-ICAP"

    let HKD_Quarterly_Quarterly_Swap_Rate_Reference_Banks =
        _prefixId.prefix "HKD-Quarterly-Quarterly_Swap_Rate-Reference_Banks"

    let HUF_BUBOR = _prefixId.prefix "HUF-BUBOR"
    let HUF_BUBOR_Reference_Banks = _prefixId.prefix "HUF-BUBOR-Reference_Banks"
    let HUF_HUFONIA = _prefixId.prefix "HUF-HUFONIA"
    let HUF_HUFONIA_OIS_Compound = _prefixId.prefix "HUF-HUFONIA-OIS_Compound"
    let IDR_IDMA_Bloomberg = _prefixId.prefix "IDR-IDMA-Bloomberg"
    let IDR_IDRFIX = _prefixId.prefix "IDR-IDRFIX"
    let IDR_INDONIA = _prefixId.prefix "IDR-INDONIA"
    let IDR_INDONIA_OIS_Compound = _prefixId.prefix "IDR-INDONIA-OIS_Compound"
    let IDR_JIBOR = _prefixId.prefix "IDR-JIBOR"
    let IDR_SBI_Reuters = _prefixId.prefix "IDR-SBI-Reuters"
    let IDR_SOR_Reference_Banks = _prefixId.prefix "IDR-SOR-Reference_Banks"
    let IDR_SOR_Reuters = _prefixId.prefix "IDR-SOR-Reuters"
    let IDR_SOR_Telerate = _prefixId.prefix "IDR-SOR-Telerate"

    let IDR_Semi_Annual_Swap_Rate_11_00_BGCANTOR =
        _prefixId.prefix "IDR-Semi-Annual_Swap_Rate-11_00-BGCANTOR"

    let IDR_Semi_Annual_Swap_Rate_Reference_Banks =
        _prefixId.prefix "IDR-Semi-Annual_Swap_Rate-Reference_Banks"

    let IDR_Semi_Annual_Swap_Rate_Non_deliverable_16_00_Tullett_Prebon =
        _prefixId.prefix "IDR-Semi_Annual_Swap_Rate-Non-deliverable-16_00-Tullett_Prebon"

    let ILS_SHIR = _prefixId.prefix "ILS-SHIR"
    let ILS_SHIR_OIS_Compound = _prefixId.prefix "ILS-SHIR-OIS_Compound"
    let ILS_TELBOR = _prefixId.prefix "ILS-TELBOR"
    let ILS_TELBOR_Reference_Banks = _prefixId.prefix "ILS-TELBOR-Reference_Banks"
    let INR_BMK = _prefixId.prefix "INR-BMK"
    let INR_CMT = _prefixId.prefix "INR-CMT"
    let INR_INBMK_REUTERS = _prefixId.prefix "INR-INBMK-REUTERS"
    let INR_MIBOR_OIS_COMPOUND = _prefixId.prefix "INR-MIBOR-OIS-COMPOUND"
    let INR_MIBOR_OIS_Compound = _prefixId.prefix "INR-MIBOR-OIS_Compound"
    let INR_MIBOR_OIS = _prefixId.prefix "INR-MIBOR_OIS"
    let INR_MIFOR = _prefixId.prefix "INR-MIFOR"
    let INR_MITOR_OIS_COMPOUND = _prefixId.prefix "INR-MITOR-OIS-COMPOUND"
    let INR_Modified_MIFOR = _prefixId.prefix "INR-Modified_MIFOR"
    let INR_Reference_Banks = _prefixId.prefix "INR-Reference_Banks"

    let INR_Semi_Annual_Swap_Rate_11_30_BGCANTOR =
        _prefixId.prefix "INR-Semi-Annual_Swap_Rate-11_30-BGCANTOR"

    let INR_Semi_Annual_Swap_Rate_Reference_Banks =
        _prefixId.prefix "INR-Semi-Annual_Swap_Rate-Reference_Banks"

    let INR_Semi_Annual_Swap_Rate_Non_deliverable_16_00_Tullett_Prebon =
        _prefixId.prefix "INR-Semi_Annual_Swap_Rate-Non-deliverable-16_00-Tullett_Prebon"

    let ISK_REIBOR = _prefixId.prefix "ISK-REIBOR"
    let ISK_REIBOR_Reference_Banks = _prefixId.prefix "ISK-REIBOR-Reference_Banks"

    let JPY_Annual_Swap_Rate_11_00_TRADITION =
        _prefixId.prefix "JPY-Annual_Swap_Rate-11_00-TRADITION"

    let JPY_Annual_Swap_Rate_3_00_TRADITION =
        _prefixId.prefix "JPY-Annual_Swap_Rate-3_00-TRADITION"

    let JPY_BBSF_Bloomberg_10_00 = _prefixId.prefix "JPY-BBSF-Bloomberg-10_00"
    let JPY_BBSF_Bloomberg_15_00 = _prefixId.prefix "JPY-BBSF-Bloomberg-15_00"
    let JPY_Euroyen_TIBOR = _prefixId.prefix "JPY-Euroyen_TIBOR"
    let JPY_ISDA_Swap_Rate_10_00 = _prefixId.prefix "JPY-ISDA-Swap_Rate-10_00"
    let JPY_ISDA_Swap_Rate_15_00 = _prefixId.prefix "JPY-ISDA-Swap_Rate-15_00"
    let JPY_LIBOR = _prefixId.prefix "JPY-LIBOR"
    let JPY_LIBOR_ISDA = _prefixId.prefix "JPY-LIBOR-ISDA"
    let JPY_LIBOR_Reference_Banks = _prefixId.prefix "JPY-LIBOR-Reference_Banks"
    let JPY_LIBOR_TSR_10_00 = _prefixId.prefix "JPY-LIBOR_TSR-10_00"
    let JPY_LIBOR_TSR_15_00 = _prefixId.prefix "JPY-LIBOR_TSR-15_00"
    let JPY_LTPR_TBC = _prefixId.prefix "JPY-LTPR-TBC"
    let JPY_LTPR_MHBK = _prefixId.prefix "JPY-LTPR_MHBK"
    let JPY_MUTANCALL_TONAR = _prefixId.prefix "JPY-MUTANCALL-TONAR"
    let JPY_OIS_11_00_ICAP = _prefixId.prefix "JPY-OIS-11_00-ICAP"
    let JPY_OIS_11_00_TRADITION = _prefixId.prefix "JPY-OIS-11_00-TRADITION"
    let JPY_OIS_3_00_TRADITION = _prefixId.prefix "JPY-OIS-3_00-TRADITION"
    let JPY_Quoting_Banks_LIBOR = _prefixId.prefix "JPY-Quoting_Banks-LIBOR"
    let JPY_STPR_Quoting_Banks = _prefixId.prefix "JPY-STPR-Quoting_Banks"
    let JPY_TIBOR = _prefixId.prefix "JPY-TIBOR"
    let JPY_TIBOR_17096 = _prefixId.prefix "JPY-TIBOR-17096"
    let JPY_TIBOR_DTIBOR01 = _prefixId.prefix "JPY-TIBOR-DTIBOR01"
    let JPY_TIBOR_TIBM = _prefixId.prefix "JPY-TIBOR-TIBM"

    let JPY_TIBOR_TIBM_Reference_Banks =
        _prefixId.prefix "JPY-TIBOR-TIBM-Reference_Banks"

    let JPY_TIBOR_TIBM_10_Banks = _prefixId.prefix "JPY-TIBOR-TIBM_10_Banks"
    let JPY_TIBOR_TIBM_5_Banks = _prefixId.prefix "JPY-TIBOR-TIBM_5_Banks"
    let JPY_TIBOR_TIBM_All_Banks = _prefixId.prefix "JPY-TIBOR-TIBM_All_Banks"
    let JPY_TONA = _prefixId.prefix "JPY-TONA"
    let JPY_TONA_OIS_Compound = _prefixId.prefix "JPY-TONA-OIS_Compound"
    let JPY_TONA_Average_180D = _prefixId.prefix "JPY-TONA_Average_180D"
    let JPY_TONA_Average_30D = _prefixId.prefix "JPY-TONA_Average_30D"
    let JPY_TONA_Average_90D = _prefixId.prefix "JPY-TONA_Average_90D"
    let JPY_TONA_Compounded_Index = _prefixId.prefix "JPY-TONA_Compounded_Index"
    let JPY_TONA_ICE_Compounded_Index = _prefixId.prefix "JPY-TONA_ICE_Compounded_Index"

    let JPY_TONA_ICE_Compounded_Index_0_Floor =
        _prefixId.prefix "JPY-TONA_ICE_Compounded_Index_0_Floor"

    let JPY_TONA_ICE_Compounded_Index_0_Floor_2D_Lag =
        _prefixId.prefix "JPY-TONA_ICE_Compounded_Index_0_Floor_2D_Lag"

    let JPY_TONA_ICE_Compounded_Index_0_Floor_5D_Lag =
        _prefixId.prefix "JPY-TONA_ICE_Compounded_Index_0_Floor_5D_Lag"

    let JPY_TONA_ICE_Compounded_Index_2D_Lag =
        _prefixId.prefix "JPY-TONA_ICE_Compounded_Index_2D_Lag"

    let JPY_TONA_ICE_Compounded_Index_5D_Lag =
        _prefixId.prefix "JPY-TONA_ICE_Compounded_Index_5D_Lag"

    let JPY_TONA_TSR_10_00 = _prefixId.prefix "JPY-TONA_TSR-10_00"
    let JPY_TONA_TSR_15_00 = _prefixId.prefix "JPY-TONA_TSR-15_00"
    let JPY_TORF_QUICK = _prefixId.prefix "JPY-TORF_QUICK"
    let JPY_TSR_Reference_Banks = _prefixId.prefix "JPY-TSR-Reference_Banks"
    let JPY_TSR_Telerate_10_00 = _prefixId.prefix "JPY-TSR-Telerate-10_00"
    let JPY_TSR_Telerate_15_00 = _prefixId.prefix "JPY-TSR-Telerate-15_00"

    let JPY_USD_Basis_Swaps_11_00_ICAP =
        _prefixId.prefix "JPY_USD-Basis_Swaps-11_00-ICAP"

    let KRW_Bond_3222 = _prefixId.prefix "KRW-Bond-3222"
    let KRW_CD_91D = _prefixId.prefix "KRW-CD_91D"
    let KRW_KOFR = _prefixId.prefix "KRW-KOFR"
    let KRW_KOFR_OIS_Compound = _prefixId.prefix "KRW-KOFR-OIS_Compound"

    let KRW_Quarterly_Annual_Swap_Rate_3_30_ICAP =
        _prefixId.prefix "KRW-Quarterly_Annual_Swap_Rate-3_30-ICAP"

    let MXN_TIIE = _prefixId.prefix "MXN-TIIE"

    let MXN_TIIE_Banxico_Reference_Banks =
        _prefixId.prefix "MXN-TIIE-Banxico-Reference_Banks"

    let MXN_TIIE_Reference_Banks = _prefixId.prefix "MXN-TIIE-Reference_Banks"
    let MXN_TIIE_ON = _prefixId.prefix "MXN-TIIE_ON"
    let MXN_TIIE_ON_OIS_Compound = _prefixId.prefix "MXN-TIIE_ON-OIS_Compound"
    let MYR_KLIBOR = _prefixId.prefix "MYR-KLIBOR"
    let MYR_KLIBOR_Reference_Banks = _prefixId.prefix "MYR-KLIBOR-Reference_Banks"
    let MYR_MYOR = _prefixId.prefix "MYR-MYOR"
    let MYR_MYOR_OIS_Compound = _prefixId.prefix "MYR-MYOR-OIS_Compound"

    let MYR_Quarterly_Swap_Rate_11_00_TRADITION =
        _prefixId.prefix "MYR-Quarterly_Swap_Rate-11_00-TRADITION"

    let MYR_Quarterly_Swap_Rate_TRADITION_Reference_Banks =
        _prefixId.prefix "MYR-Quarterly_Swap_Rate-TRADITION-Reference_Banks"

    let NOK_NIBOR = _prefixId.prefix "NOK-NIBOR"
    let NOK_NIBOR_NIBR = _prefixId.prefix "NOK-NIBOR-NIBR"

    let NOK_NIBOR_NIBR_Reference_Banks =
        _prefixId.prefix "NOK-NIBOR-NIBR-Reference_Banks"

    let NOK_NIBOR_Reference_Banks = _prefixId.prefix "NOK-NIBOR-Reference_Banks"
    let NOK_NOWA = _prefixId.prefix "NOK-NOWA"
    let NOK_NOWA_OIS_Compound = _prefixId.prefix "NOK-NOWA-OIS_Compound"
    let NZD_BBR_ISDC = _prefixId.prefix "NZD-BBR-ISDC"
    let NZD_BBR_Reference_Banks = _prefixId.prefix "NZD-BBR-Reference_Banks"
    let NZD_BBR_Telerate = _prefixId.prefix "NZD-BBR-Telerate"
    let NZD_BKBM_Bid = _prefixId.prefix "NZD-BKBM_Bid"
    let NZD_BKBM_FRA = _prefixId.prefix "NZD-BKBM_FRA"
    let NZD_BKBM_FRA_Swap_Rate_ICAP = _prefixId.prefix "NZD-BKBM_FRA_Swap_Rate_ICAP"
    let NZD_NZIONA = _prefixId.prefix "NZD-NZIONA"
    let NZD_NZIONA_OIS_Compound = _prefixId.prefix "NZD-NZIONA-OIS_Compound"

    let NZD_Semi_Annual_Swap_Rate_11_00_BGCANTOR =
        _prefixId.prefix "NZD-Semi-Annual_Swap_Rate-11_00-BGCANTOR"

    let NZD_Semi_Annual_Swap_Rate_BGCANTOR_Reference_Banks =
        _prefixId.prefix "NZD-Semi-Annual_Swap_Rate-BGCANTOR-Reference_Banks"

    let NZD_Swap_Rate_ICAP_Reference_Banks =
        _prefixId.prefix "NZD-Swap_Rate-ICAP-Reference_Banks"

    let PHP_ORR = _prefixId.prefix "PHP-ORR"
    let PHP_PHIREF = _prefixId.prefix "PHP-PHIREF"
    let PHP_PHIREF_BAP = _prefixId.prefix "PHP-PHIREF-BAP"
    let PHP_PHIREF_Reference_Banks = _prefixId.prefix "PHP-PHIREF-Reference_Banks"

    let PHP_Semi_Annual_Swap_Rate_11_00_BGCANTOR =
        _prefixId.prefix "PHP-Semi-Annual_Swap_Rate-11_00-BGCANTOR"

    let PHP_Semi_Annual_Swap_Rate_Reference_Banks =
        _prefixId.prefix "PHP-Semi-Annual_Swap_Rate-Reference_Banks"

    let PLN_POLONIA = _prefixId.prefix "PLN-POLONIA"
    let PLN_POLONIA_OIS_Compound = _prefixId.prefix "PLN-POLONIA-OIS_Compound"
    let PLN_WIBID = _prefixId.prefix "PLN-WIBID"
    let PLN_WIBOR = _prefixId.prefix "PLN-WIBOR"
    let PLN_WIBOR_Reference_Banks = _prefixId.prefix "PLN-WIBOR-Reference_Banks"
    let PLN_WIRON = _prefixId.prefix "PLN-WIRON"
    let PLN_WIRON_OIS_Compound = _prefixId.prefix "PLN-WIRON-OIS_Compound"
    let PLZ_WIBOR_Reference_Banks = _prefixId.prefix "PLZ-WIBOR-Reference_Banks"
    let PLZ_WIBOR_WIBO = _prefixId.prefix "PLZ-WIBOR-WIBO"

    let REPOFUNDS_RATE_FRANCE_OIS_COMPOUND =
        _prefixId.prefix "REPOFUNDS_RATE-FRANCE-OIS-COMPOUND"

    let REPOFUNDS_RATE_GERMANY_OIS_COMPOUND =
        _prefixId.prefix "REPOFUNDS_RATE-GERMANY-OIS-COMPOUND"

    let REPOFUNDS_RATE_ITALY_OIS_COMPOUND =
        _prefixId.prefix "REPOFUNDS_RATE-ITALY-OIS-COMPOUND"

    let RON_Annual_Swap_Rate_11_00_BGCANTOR =
        _prefixId.prefix "RON-Annual_Swap_Rate-11_00-BGCANTOR"

    let RON_Annual_Swap_Rate_Reference_Banks =
        _prefixId.prefix "RON-Annual_Swap_Rate-Reference_Banks"

    let RON_ROBID = _prefixId.prefix "RON-ROBID"
    let RON_ROBOR = _prefixId.prefix "RON-ROBOR"

    let RUB_Annual_Swap_Rate_11_00_BGCANTOR =
        _prefixId.prefix "RUB-Annual_Swap_Rate-11_00-BGCANTOR"

    let RUB_Annual_Swap_Rate_12_45_TRADITION =
        _prefixId.prefix "RUB-Annual_Swap_Rate-12_45-TRADITION"

    let RUB_Annual_Swap_Rate_4_15_TRADITION =
        _prefixId.prefix "RUB-Annual_Swap_Rate-4_15-TRADITION"

    let RUB_Annual_Swap_Rate_Reference_Banks =
        _prefixId.prefix "RUB-Annual_Swap_Rate-Reference_Banks"

    let RUB_Annual_Swap_Rate_TRADITION_Reference_Banks =
        _prefixId.prefix "RUB-Annual_Swap_Rate-TRADITION-Reference_Banks"

    let RUB_Key_Rate_CBRF = _prefixId.prefix "RUB-Key_Rate_CBRF"
    let RUB_MOSPRIME_Reference_Banks = _prefixId.prefix "RUB-MOSPRIME-Reference_Banks"
    let RUB_MosPrime = _prefixId.prefix "RUB-MosPrime"
    let RUB_RUONIA = _prefixId.prefix "RUB-RUONIA"
    let RUB_RUONIA_OIS_Compound = _prefixId.prefix "RUB-RUONIA-OIS_Compound"
    let SAR_SAIBOR = _prefixId.prefix "SAR-SAIBOR"
    let SAR_SRIOR_Reference_Banks = _prefixId.prefix "SAR-SRIOR-Reference_Banks"
    let SEK_Annual_Swap_Rate = _prefixId.prefix "SEK-Annual_Swap_Rate"
    let SEK_Annual_Swap_Rate_SESWFI = _prefixId.prefix "SEK-Annual_Swap_Rate-SESWFI"
    let SEK_STIBOR = _prefixId.prefix "SEK-STIBOR"
    let SEK_STIBOR_OIS_Compound = _prefixId.prefix "SEK-STIBOR-OIS_Compound"
    let SEK_STIBOR_Reference_Banks = _prefixId.prefix "SEK-STIBOR-Reference_Banks"
    let SEK_SWESTR = _prefixId.prefix "SEK-SWESTR"
    let SEK_SWESTR_OIS_Compound = _prefixId.prefix "SEK-SWESTR-OIS_Compound"
    let SEK_SWESTR_Average_1M = _prefixId.prefix "SEK-SWESTR_Average_1M"
    let SEK_SWESTR_Average_1W = _prefixId.prefix "SEK-SWESTR_Average_1W"
    let SEK_SWESTR_Average_2M = _prefixId.prefix "SEK-SWESTR_Average_2M"
    let SEK_SWESTR_Average_3M = _prefixId.prefix "SEK-SWESTR_Average_3M"
    let SEK_SWESTR_Average_6M = _prefixId.prefix "SEK-SWESTR_Average_6M"
    let SEK_SWESTR_Compounded_Index = _prefixId.prefix "SEK-SWESTR_Compounded_Index"
    let SGD_SIBOR = _prefixId.prefix "SGD-SIBOR"
    let SGD_SIBOR_Reference_Banks = _prefixId.prefix "SGD-SIBOR-Reference_Banks"
    let SGD_SIBOR_Telerate = _prefixId.prefix "SGD-SIBOR-Telerate"
    let SGD_SONAR_OIS_COMPOUND = _prefixId.prefix "SGD-SONAR-OIS-COMPOUND"
    let SGD_SOR = _prefixId.prefix "SGD-SOR"
    let SGD_SOR_Reference_Banks = _prefixId.prefix "SGD-SOR-Reference_Banks"
    let SGD_SOR_Telerate = _prefixId.prefix "SGD-SOR-Telerate"
    let SGD_SOR_VWAP_Reference_Banks = _prefixId.prefix "SGD-SOR-VWAP-Reference_Banks"
    let SGD_SORA = _prefixId.prefix "SGD-SORA"
    let SGD_SORA_OIS_Compound = _prefixId.prefix "SGD-SORA-OIS_Compound"

    let SGD_Semi_Annual_Currency_Basis_Swap_Rate_11_00_Tullett_Prebon =
        _prefixId.prefix "SGD-Semi-Annual_Currency_Basis_Swap_Rate-11_00-Tullett_Prebon"

    let SGD_Semi_Annual_Currency_Basis_Swap_Rate_16_00_Tullett_Prebon =
        _prefixId.prefix "SGD-Semi-Annual_Currency_Basis_Swap_Rate-16_00-Tullett_Prebon"

    let ``SGD_Semi_Annual_Swap_Rate_11.00_TRADITION`` =
        _prefixId.prefix "SGD-Semi-Annual_Swap_Rate-11.00-TRADITION"

    let SGD_Semi_Annual_Swap_Rate_11_00_BGCANTOR =
        _prefixId.prefix "SGD-Semi-Annual_Swap_Rate-11_00-BGCANTOR"

    let SGD_Semi_Annual_Swap_Rate_11_00_Tullett_Prebon =
        _prefixId.prefix "SGD-Semi-Annual_Swap_Rate-11_00-Tullett_Prebon"

    let SGD_Semi_Annual_Swap_Rate_16_00_Tullett_Prebon =
        _prefixId.prefix "SGD-Semi-Annual_Swap_Rate-16_00-Tullett_Prebon"

    let SGD_Semi_Annual_Swap_Rate_ICAP =
        _prefixId.prefix "SGD-Semi-Annual_Swap_Rate-ICAP"

    let SGD_Semi_Annual_Swap_Rate_ICAP_Reference_Banks =
        _prefixId.prefix "SGD-Semi-Annual_Swap_Rate-ICAP-Reference_Banks"

    let SGD_Semi_Annual_Swap_Rate_Reference_Banks =
        _prefixId.prefix "SGD-Semi-Annual_Swap_Rate-Reference_Banks"

    let SGD_Semi_Annual_Swap_Rate_TRADITION_Reference_Banks =
        _prefixId.prefix "SGD-Semi-Annual_Swap_Rate-TRADITION-Reference_Banks"

    let SKK_BRIBOR_BRBO = _prefixId.prefix "SKK-BRIBOR-BRBO"
    let SKK_BRIBOR_Bloomberg = _prefixId.prefix "SKK-BRIBOR-Bloomberg"
    let SKK_BRIBOR_NBSK07 = _prefixId.prefix "SKK-BRIBOR-NBSK07"
    let SKK_BRIBOR_Reference_Banks = _prefixId.prefix "SKK-BRIBOR-Reference_Banks"
    let THB_SOR_Reference_Banks = _prefixId.prefix "THB-SOR-Reference_Banks"
    let THB_SOR_Reuters = _prefixId.prefix "THB-SOR-Reuters"
    let THB_SOR_Telerate = _prefixId.prefix "THB-SOR-Telerate"

    let THB_Semi_Annual_Swap_Rate_11_00_BGCANTOR =
        _prefixId.prefix "THB-Semi-Annual_Swap_Rate-11_00-BGCANTOR"

    let THB_Semi_Annual_Swap_Rate_Reference_Banks =
        _prefixId.prefix "THB-Semi-Annual_Swap_Rate-Reference_Banks"

    let THB_THBFIX = _prefixId.prefix "THB-THBFIX"
    let THB_THBFIX_Reference_Banks = _prefixId.prefix "THB-THBFIX-Reference_Banks"
    let THB_THOR = _prefixId.prefix "THB-THOR"
    let THB_THOR_OIS_Compound = _prefixId.prefix "THB-THOR-OIS_Compound"

    let TRY_Annual_Swap_Rate_11_15_BGCANTOR =
        _prefixId.prefix "TRY-Annual_Swap_Rate-11_15-BGCANTOR"

    let TRY_Annual_Swap_Rate_Reference_Banks =
        _prefixId.prefix "TRY-Annual_Swap_Rate-Reference_Banks"

    let TRY_Semi_Annual_Swap_Rate_TRADITION_Reference_Banks =
        _prefixId.prefix "TRY-Semi-Annual_Swap_Rate-TRADITION-Reference_Banks"

    let TRY_TLREF = _prefixId.prefix "TRY-TLREF"
    let TRY_TLREF_OIS_Compound = _prefixId.prefix "TRY-TLREF-OIS_Compound"
    let TRY_TRLIBOR = _prefixId.prefix "TRY-TRLIBOR"
    let TRY_TRYIBOR_Reference_Banks = _prefixId.prefix "TRY-TRYIBOR-Reference_Banks"

    let TRY_Annual_Swap_Rate_11_00_TRADITION =
        _prefixId.prefix "TRY_Annual_Swap_Rate-11_00-TRADITION"

    let TWD_Quarterly_Annual_Swap_Rate_11_00_BGCANTOR =
        _prefixId.prefix "TWD-Quarterly-Annual_Swap_Rate-11_00-BGCANTOR"

    let TWD_Quarterly_Annual_Swap_Rate_Reference_Banks =
        _prefixId.prefix "TWD-Quarterly-Annual_Swap_Rate-Reference_Banks"

    let TWD_Reference_Dealers = _prefixId.prefix "TWD-Reference_Dealers"
    let TWD_Reuters_6165 = _prefixId.prefix "TWD-Reuters-6165"
    let TWD_TAIBIR01 = _prefixId.prefix "TWD-TAIBIR01"
    let TWD_TAIBIR02 = _prefixId.prefix "TWD-TAIBIR02"
    let TWD_TAIBOR = _prefixId.prefix "TWD-TAIBOR"
    let TWD_TWCPBA = _prefixId.prefix "TWD-TWCPBA"
    let TWD_Telerate_6165 = _prefixId.prefix "TWD-Telerate-6165"

    let USD_3M_LIBOR_SWAP_CME_vs_LCH_ICAP =
        _prefixId.prefix "USD-3M_LIBOR_SWAP-CME_vs_LCH-ICAP"

    let USD_3M_LIBOR_SWAP_CME_vs_LCH_ICAP_Bloomberg =
        _prefixId.prefix "USD-3M_LIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg"

    let USD_6M_LIBOR_SWAP_CME_vs_LCH_ICAP =
        _prefixId.prefix "USD-6M_LIBOR_SWAP-CME_vs_LCH-ICAP"

    let USD_6M_LIBOR_SWAP_CME_vs_LCH_ICAP_Bloomberg =
        _prefixId.prefix "USD-6M_LIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg"

    let USD_AMERIBOR = _prefixId.prefix "USD-AMERIBOR"
    let USD_AMERIBOR_Average_30D = _prefixId.prefix "USD-AMERIBOR_Average_30D"
    let USD_AMERIBOR_Average_90D = _prefixId.prefix "USD-AMERIBOR_Average_90D"
    let USD_AMERIBOR_Term = _prefixId.prefix "USD-AMERIBOR_Term"
    let USD_AMERIBOR_Term_Structure = _prefixId.prefix "USD-AMERIBOR_Term_Structure"
    let USD_AXI_Term = _prefixId.prefix "USD-AXI_Term"

    let USD_Annual_Swap_Rate_11_00_BGCANTOR =
        _prefixId.prefix "USD-Annual_Swap_Rate-11_00-BGCANTOR"

    let USD_Annual_Swap_Rate_11_00_TRADITION =
        _prefixId.prefix "USD-Annual_Swap_Rate-11_00-TRADITION"

    let USD_Annual_Swap_Rate_4_00_TRADITION =
        _prefixId.prefix "USD-Annual_Swap_Rate-4_00-TRADITION"

    let ``USD_BA_H.15`` = _prefixId.prefix "USD-BA-H.15"
    let USD_BA_Reference_Dealers = _prefixId.prefix "USD-BA-Reference_Dealers"
    let USD_BMA_Municipal_Swap_Index = _prefixId.prefix "USD-BMA_Municipal_Swap_Index"
    let USD_BSBY = _prefixId.prefix "USD-BSBY"
    let ``USD_CD_H.15`` = _prefixId.prefix "USD-CD-H.15"
    let USD_CD_Reference_Dealers = _prefixId.prefix "USD-CD-Reference_Dealers"
    let USD_CMS_Reference_Banks = _prefixId.prefix "USD-CMS-Reference_Banks"

    let USD_CMS_Reference_Banks_ICAP_SwapPX =
        _prefixId.prefix "USD-CMS-Reference_Banks-ICAP_SwapPX"

    let USD_CMS_Reuters = _prefixId.prefix "USD-CMS-Reuters"
    let USD_CMS_Telerate = _prefixId.prefix "USD-CMS-Telerate"
    let USD_CMT = _prefixId.prefix "USD-CMT"
    let USD_CMT_Average_1W = _prefixId.prefix "USD-CMT_Average_1W"
    let USD_COF11_Telerate = _prefixId.prefix "USD-COF11-Telerate"
    let USD_COFI = _prefixId.prefix "USD-COFI"
    let USD_CP_Money_Market_Yield = _prefixId.prefix "USD-CP-Money_Market_Yield"
    let USD_CP_Reference_Dealers = _prefixId.prefix "USD-CP-Reference_Dealers"
    let USD_CRITR = _prefixId.prefix "USD-CRITR"
    let USD_FFCB_DISCO = _prefixId.prefix "USD-FFCB-DISCO"
    let USD_FXI_Term = _prefixId.prefix "USD-FXI_Term"
    let USD_Federal_Funds = _prefixId.prefix "USD-Federal_Funds"

    let USD_Federal_Funds_OIS_Compound =
        _prefixId.prefix "USD-Federal_Funds-OIS_Compound"

    let USD_Federal_Funds_Reference_Dealers =
        _prefixId.prefix "USD-Federal_Funds-Reference_Dealers"

    let USD_LIBOR = _prefixId.prefix "USD-LIBOR"
    let USD_LIBOR_ISDA = _prefixId.prefix "USD-LIBOR-ISDA"
    let USD_LIBOR_LIBO = _prefixId.prefix "USD-LIBOR-LIBO"
    let USD_LIBOR_Reference_Banks = _prefixId.prefix "USD-LIBOR-Reference_Banks"
    let USD_LIBOR_ICE_Swap_Rate_11_00 = _prefixId.prefix "USD-LIBOR_ICE_Swap_Rate-11_00"
    let USD_LIBOR_ICE_Swap_Rate_15_00 = _prefixId.prefix "USD-LIBOR_ICE_Swap_Rate-15_00"
    let USD_Municipal_Swap_Index = _prefixId.prefix "USD-Municipal_Swap_Index"

    let USD_Municipal_Swap_Libor_Ratio_11_00_ICAP =
        _prefixId.prefix "USD-Municipal_Swap_Libor_Ratio-11_00-ICAP"

    let USD_Municipal_Swap_Rate_11_00_ICAP =
        _prefixId.prefix "USD-Municipal_Swap_Rate-11_00-ICAP"

    let USD_OIS_11_00_BGCANTOR = _prefixId.prefix "USD-OIS-11_00-BGCANTOR"
    let USD_OIS_11_00_LON_ICAP = _prefixId.prefix "USD-OIS-11_00-LON-ICAP"
    let USD_OIS_11_00_NY_ICAP = _prefixId.prefix "USD-OIS-11_00-NY-ICAP"
    let USD_OIS_11_00_TRADITION = _prefixId.prefix "USD-OIS-11_00-TRADITION"
    let USD_OIS_3_00_BGCANTOR = _prefixId.prefix "USD-OIS-3_00-BGCANTOR"
    let USD_OIS_3_00_NY_ICAP = _prefixId.prefix "USD-OIS-3_00-NY-ICAP"
    let USD_OIS_4_00_TRADITION = _prefixId.prefix "USD-OIS-4_00-TRADITION"

    let USD_Overnight_Bank_Funding_Rate =
        _prefixId.prefix "USD-Overnight_Bank_Funding_Rate"

    let USD_Prime = _prefixId.prefix "USD-Prime"
    let USD_Prime_Reference_Banks = _prefixId.prefix "USD-Prime-Reference_Banks"
    let USD_SIBOR_Reference_Banks = _prefixId.prefix "USD-SIBOR-Reference_Banks"
    let USD_SIBOR_SIBO = _prefixId.prefix "USD-SIBOR-SIBO"
    let USD_SOFR = _prefixId.prefix "USD-SOFR"
    let USD_SOFR_OIS_Compound = _prefixId.prefix "USD-SOFR-OIS_Compound"
    let USD_SOFR_Average_180D = _prefixId.prefix "USD-SOFR_Average_180D"
    let USD_SOFR_Average_30D = _prefixId.prefix "USD-SOFR_Average_30D"
    let USD_SOFR_Average_90D = _prefixId.prefix "USD-SOFR_Average_90D"
    let USD_SOFR_CME_Term = _prefixId.prefix "USD-SOFR_CME_Term"
    let USD_SOFR_Compounded_Index = _prefixId.prefix "USD-SOFR_Compounded_Index"
    let USD_SOFR_ICE_Compounded_Index = _prefixId.prefix "USD-SOFR_ICE_Compounded_Index"

    let USD_SOFR_ICE_Compounded_Index_0_Floor =
        _prefixId.prefix "USD-SOFR_ICE_Compounded_Index_0_Floor"

    let USD_SOFR_ICE_Compounded_Index_0_Floor_2D_Lag =
        _prefixId.prefix "USD-SOFR_ICE_Compounded_Index_0_Floor_2D_Lag"

    let USD_SOFR_ICE_Compounded_Index_0_Floor_5D_Lag =
        _prefixId.prefix "USD-SOFR_ICE_Compounded_Index_0_Floor_5D_Lag"

    let USD_SOFR_ICE_Compounded_Index_2D_Lag =
        _prefixId.prefix "USD-SOFR_ICE_Compounded_Index_2D_Lag"

    let USD_SOFR_ICE_Compounded_Index_5D_Lag =
        _prefixId.prefix "USD-SOFR_ICE_Compounded_Index_5D_Lag"

    let USD_SOFR_ICE_Swap_Rate = _prefixId.prefix "USD-SOFR_ICE_Swap_Rate"

    let USD_SOFR_ICE_Swap_Rate_Spreads =
        _prefixId.prefix "USD-SOFR_ICE_Swap_Rate_Spreads"

    let USD_SOFR_ICE_Term = _prefixId.prefix "USD-SOFR_ICE_Term"
    let USD_SandP_Index_High_Grade = _prefixId.prefix "USD-SandP_Index_High_Grade"
    let ``USD_TBILL_H.15`` = _prefixId.prefix "USD-TBILL-H.15"
    let ``USD_TBILL_H.15_Bloomberg`` = _prefixId.prefix "USD-TBILL-H.15-Bloomberg"
    let USD_TBILL_Auction_High_Rate = _prefixId.prefix "USD-TBILL_Auction_High_Rate"

    let USD_TBILL_Secondary_Market_Bond_Equivalent_Yield =
        _prefixId.prefix "USD-TBILL_Secondary_Market-Bond_Equivalent_Yield"

    let USD_TIBOR_ISDC = _prefixId.prefix "USD-TIBOR-ISDC"
    let USD_TIBOR_Reference_Banks = _prefixId.prefix "USD-TIBOR-Reference_Banks"
    let USD_Treasury_19901_3_00_ICAP = _prefixId.prefix "USD-Treasury-19901-3_00-ICAP"

    let USD_Treasury_Rate_ICAP_BrokerTec =
        _prefixId.prefix "USD-Treasury_Rate-ICAP_BrokerTec"

    let USD_Treasury_Rate_SwapMarker100 =
        _prefixId.prefix "USD-Treasury_Rate-SwapMarker100"

    let USD_Treasury_Rate_SwapMarker99 =
        _prefixId.prefix "USD-Treasury_Rate-SwapMarker99"

    let USD_Treasury_Rate_T19901 = _prefixId.prefix "USD-Treasury_Rate-T19901"
    let USD_Treasury_Rate_T500 = _prefixId.prefix "USD-Treasury_Rate-T500"
    let USD_Swap_Rate_BCMP1 = _prefixId.prefix "USD_Swap_Rate-BCMP1"
    let USD_Treasury_Rate_BCMP1 = _prefixId.prefix "USD_Treasury_Rate-BCMP1"

    let VND_Semi_Annual_Swap_Rate_11_00_BGCANTOR =
        _prefixId.prefix "VND-Semi-Annual_Swap_Rate-11_00-BGCANTOR"

    let VND_Semi_Annual_Swap_Rate_Reference_Banks =
        _prefixId.prefix "VND-Semi-Annual_Swap_Rate-Reference_Banks"

    let ZAR_DEPOSIT_Reference_Banks = _prefixId.prefix "ZAR-DEPOSIT-Reference_Banks"
    let ZAR_DEPOSIT_SAFEX = _prefixId.prefix "ZAR-DEPOSIT-SAFEX"
    let ZAR_JIBAR = _prefixId.prefix "ZAR-JIBAR"
    let ZAR_JIBAR_Reference_Banks = _prefixId.prefix "ZAR-JIBAR-Reference_Banks"

    let ZAR_PRIME_AVERAGE_Reference_Banks =
        _prefixId.prefix "ZAR-PRIME-AVERAGE-Reference_Banks"

    let ZAR_Prime_Average = _prefixId.prefix "ZAR-Prime_Average"

    let ZAR_Quarterly_Swap_Rate_1_00_TRADITION =
        _prefixId.prefix "ZAR-Quarterly_Swap_Rate-1_00-TRADITION"

    let ZAR_Quarterly_Swap_Rate_5_30_TRADITION =
        _prefixId.prefix "ZAR-Quarterly_Swap_Rate-5_30-TRADITION"

    let ZAR_Quarterly_Swap_Rate_TRADITION_Reference_Banks =
        _prefixId.prefix "ZAR-Quarterly_Swap_Rate-TRADITION-Reference_Banks"

    let ZAR_ZARONIA = _prefixId.prefix "ZAR-ZARONIA"
    let ZAR_ZARONIA_OIS_Compound = _prefixId.prefix "ZAR-ZARONIA-OIS_Compound"

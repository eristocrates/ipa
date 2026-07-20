namespace https.spec.edmcouncil.org.fibo.ontology.IND.InterestRates.CommonInterestRates.slash

open DoxAletheia

module fibo_ind_ir_cm =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AED-EIBOR"></see>
    /// </summary>
    let ``AED-EIBOR`` = _prefix "AED-EIBOR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-AONIA"></see>
    /// </summary>
    let ``AUD-AONIA`` = _prefix "AUD-AONIA"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-AONIA-OIS_Compound"></see>
    /// </summary>
    let ``AUD-AONIA-OIS_Compound`` = _prefix "AUD-AONIA-OIS_Compound"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-BBR-ISDC"></see>
    /// </summary>
    let ``AUD-BBR-ISDC`` = _prefix "AUD-BBR-ISDC"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-BBSW"></see>
    /// </summary>
    let ``AUD-BBSW`` = _prefix "AUD-BBSW"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-BBSW_Quarterly_Swap_Rate_ICAP"></see>
    /// </summary>
    let ``AUD-BBSW_Quarterly_Swap_Rate_ICAP`` =
        _prefix "AUD-BBSW_Quarterly_Swap_Rate_ICAP"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-BBSW_Semi_Annual_Swap_Rate_ICAP"></see>
    /// </summary>
    let ``AUD-BBSW_Semi_Annual_Swap_Rate_ICAP`` =
        _prefix "AUD-BBSW_Semi_Annual_Swap_Rate_ICAP"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-BBSY_Bid"></see>
    /// </summary>
    let ``AUD-BBSY_Bid`` = _prefix "AUD-BBSY_Bid"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-LIBOR-BBA"></see>
    /// </summary>
    let ``AUD-LIBOR-BBA`` = _prefix "AUD-LIBOR-BBA"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-LIBOR-BBA-Bloomberg"></see>
    /// </summary>
    let ``AUD-LIBOR-BBA-Bloomberg`` = _prefix "AUD-LIBOR-BBA-Bloomberg"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-LIBOR-Reference_Banks"></see>
    /// </summary>
    let ``AUD-LIBOR-Reference_Banks`` = _prefix "AUD-LIBOR-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-Quarterly_Swap_Rate-ICAP-Reference_Banks"></see>
    /// </summary>
    let ``AUD-Quarterly_Swap_Rate-ICAP-Reference_Banks`` =
        _prefix "AUD-Quarterly_Swap_Rate-ICAP-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-Semi-Annual_Swap_Rate-11_00-BGCANTOR"></see>
    /// </summary>
    let ``AUD-Semi-Annual_Swap_Rate-11_00-BGCANTOR`` =
        _prefix "AUD-Semi-Annual_Swap_Rate-11_00-BGCANTOR"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-Semi-Annual_Swap_Rate-BGCANTOR-Reference_Banks"></see>
    /// </summary>
    let ``AUD-Semi-Annual_Swap_Rate-BGCANTOR-Reference_Banks`` =
        _prefix "AUD-Semi-Annual_Swap_Rate-BGCANTOR-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-Semi-Annual_Swap_Rate-ICAP-Reference_Banks"></see>
    /// </summary>
    let ``AUD-Semi-Annual_Swap_Rate-ICAP-Reference_Banks`` =
        _prefix "AUD-Semi-Annual_Swap_Rate-ICAP-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-Swap_Rate-Reuters"></see>
    /// </summary>
    let ``AUD-Swap_Rate-Reuters`` = _prefix "AUD-Swap_Rate-Reuters"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/BRL-CDI"></see>
    /// </summary>
    let ``BRL-CDI`` = _prefix "BRL-CDI"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-BA-ISDD"></see>
    /// </summary>
    let ``CAD-BA-ISDD`` = _prefix "CAD-BA-ISDD"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-BA-Reference_Banks"></see>
    /// </summary>
    let ``CAD-BA-Reference_Banks`` = _prefix "CAD-BA-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-BA-Telerate"></see>
    /// </summary>
    let ``CAD-BA-Telerate`` = _prefix "CAD-BA-Telerate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-CDOR"></see>
    /// </summary>
    let ``CAD-CDOR`` = _prefix "CAD-CDOR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-CORRA"></see>
    /// </summary>
    let ``CAD-CORRA`` = _prefix "CAD-CORRA"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-CORRA-OIS_Compound"></see>
    /// </summary>
    let ``CAD-CORRA-OIS_Compound`` = _prefix "CAD-CORRA-OIS_Compound"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-CORRA_CanDeal_TMX_Term"></see>
    /// </summary>
    let ``CAD-CORRA_CanDeal_TMX_Term`` = _prefix "CAD-CORRA_CanDeal_TMX_Term"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-CORRA_Compounded_Index"></see>
    /// </summary>
    let ``CAD-CORRA_Compounded_Index`` = _prefix "CAD-CORRA_Compounded_Index"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-ISDA-Swap_Rate"></see>
    /// </summary>
    let ``CAD-ISDA-Swap_Rate`` = _prefix "CAD-ISDA-Swap_Rate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-LIBOR-BBA"></see>
    /// </summary>
    let ``CAD-LIBOR-BBA`` = _prefix "CAD-LIBOR-BBA"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-LIBOR-BBA-Bloomberg"></see>
    /// </summary>
    let ``CAD-LIBOR-BBA-Bloomberg`` = _prefix "CAD-LIBOR-BBA-Bloomberg"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-LIBOR-BBA-SwapMarker"></see>
    /// </summary>
    let ``CAD-LIBOR-BBA-SwapMarker`` = _prefix "CAD-LIBOR-BBA-SwapMarker"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-LIBOR-Reference_Banks"></see>
    /// </summary>
    let ``CAD-LIBOR-Reference_Banks`` = _prefix "CAD-LIBOR-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-REPO-CORRA"></see>
    /// </summary>
    let ``CAD-REPO-CORRA`` = _prefix "CAD-REPO-CORRA"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-TBILL-ISDD"></see>
    /// </summary>
    let ``CAD-TBILL-ISDD`` = _prefix "CAD-TBILL-ISDD"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-TBILL-Reference_Banks"></see>
    /// </summary>
    let ``CAD-TBILL-Reference_Banks`` = _prefix "CAD-TBILL-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-TBILL-Reuters"></see>
    /// </summary>
    let ``CAD-TBILL-Reuters`` = _prefix "CAD-TBILL-Reuters"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-TBILL-Telerate"></see>
    /// </summary>
    let ``CAD-TBILL-Telerate`` = _prefix "CAD-TBILL-Telerate"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-3M_LIBOR_SWAP-CME_vs_LCH-ICAP"></see>
    /// </summary>
    let ``CHF-3M_LIBOR_SWAP-CME_vs_LCH-ICAP`` =
        _prefix "CHF-3M_LIBOR_SWAP-CME_vs_LCH-ICAP"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-3M_LIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg"></see>
    /// </summary>
    let ``CHF-3M_LIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg`` =
        _prefix "CHF-3M_LIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-3M_LIBOR_SWAP-EUREX_vs_LCH-ICAP"></see>
    /// </summary>
    let ``CHF-3M_LIBOR_SWAP-EUREX_vs_LCH-ICAP`` =
        _prefix "CHF-3M_LIBOR_SWAP-EUREX_vs_LCH-ICAP"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-3M_LIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg"></see>
    /// </summary>
    let ``CHF-3M_LIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg`` =
        _prefix "CHF-3M_LIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-6M_LIBORSWAP-CME_vs_LCH-ICAP-Bloomberg"></see>
    /// </summary>
    let ``CHF-6M_LIBORSWAP-CME_vs_LCH-ICAP-Bloomberg`` =
        _prefix "CHF-6M_LIBORSWAP-CME_vs_LCH-ICAP-Bloomberg"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-6M_LIBOR_SWAP-CME_vs_LCH-ICAP"></see>
    /// </summary>
    let ``CHF-6M_LIBOR_SWAP-CME_vs_LCH-ICAP`` =
        _prefix "CHF-6M_LIBOR_SWAP-CME_vs_LCH-ICAP"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-6M_LIBOR_SWAP-EUREX_vs_LCH-ICAP"></see>
    /// </summary>
    let ``CHF-6M_LIBOR_SWAP-EUREX_vs_LCH-ICAP`` =
        _prefix "CHF-6M_LIBOR_SWAP-EUREX_vs_LCH-ICAP"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-6M_LIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg"></see>
    /// </summary>
    let ``CHF-6M_LIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg`` =
        _prefix "CHF-6M_LIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-Annual_Swap_Rate"></see>
    /// </summary>
    let ``CHF-Annual_Swap_Rate`` = _prefix "CHF-Annual_Swap_Rate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-Annual_Swap_Rate-11_00-ICAP"></see>
    /// </summary>
    let ``CHF-Annual_Swap_Rate-11_00-ICAP`` = _prefix "CHF-Annual_Swap_Rate-11_00-ICAP"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-Annual_Swap_Rate-Reference_Banks"></see>
    /// </summary>
    let ``CHF-Annual_Swap_Rate-Reference_Banks`` =
        _prefix "CHF-Annual_Swap_Rate-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-Basis_Swap-3m_vs_6m-LIBOR-11_00-ICAP"></see>
    /// </summary>
    let ``CHF-Basis_Swap-3m_vs_6m-LIBOR-11_00-ICAP`` =
        _prefix "CHF-Basis_Swap-3m_vs_6m-LIBOR-11_00-ICAP"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-ISDAFIX-Swap_Rate"></see>
    /// </summary>
    let ``CHF-ISDAFIX-Swap_Rate`` = _prefix "CHF-ISDAFIX-Swap_Rate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-LIBOR"></see>
    /// </summary>
    let ``CHF-LIBOR`` = _prefix "CHF-LIBOR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-LIBOR-ISDA"></see>
    /// </summary>
    let ``CHF-LIBOR-ISDA`` = _prefix "CHF-LIBOR-ISDA"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-LIBOR-Reference_Banks"></see>
    /// </summary>
    let ``CHF-LIBOR-Reference_Banks`` = _prefix "CHF-LIBOR-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-OIS-11_00-ICAP"></see>
    /// </summary>
    let ``CHF-OIS-11_00-ICAP`` = _prefix "CHF-OIS-11_00-ICAP"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-SARON"></see>
    /// </summary>
    let ``CHF-SARON`` = _prefix "CHF-SARON"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-SARON-OIS_Compound"></see>
    /// </summary>
    let ``CHF-SARON-OIS_Compound`` = _prefix "CHF-SARON-OIS_Compound"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-SARON_Average_12M"></see>
    /// </summary>
    let ``CHF-SARON_Average_12M`` = _prefix "CHF-SARON_Average_12M"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-SARON_Average_1M"></see>
    /// </summary>
    let ``CHF-SARON_Average_1M`` = _prefix "CHF-SARON_Average_1M"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-SARON_Average_1W"></see>
    /// </summary>
    let ``CHF-SARON_Average_1W`` = _prefix "CHF-SARON_Average_1W"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-SARON_Average_2M"></see>
    /// </summary>
    let ``CHF-SARON_Average_2M`` = _prefix "CHF-SARON_Average_2M"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-SARON_Average_3M"></see>
    /// </summary>
    let ``CHF-SARON_Average_3M`` = _prefix "CHF-SARON_Average_3M"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-SARON_Average_6M"></see>
    /// </summary>
    let ``CHF-SARON_Average_6M`` = _prefix "CHF-SARON_Average_6M"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-SARON_Average_9M"></see>
    /// </summary>
    let ``CHF-SARON_Average_9M`` = _prefix "CHF-SARON_Average_9M"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-SARON_Compounded_Index"></see>
    /// </summary>
    let ``CHF-SARON_Compounded_Index`` = _prefix "CHF-SARON_Compounded_Index"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-TOIS-OIS-COMPOUND"></see>
    /// </summary>
    let ``CHF-TOIS-OIS-COMPOUND`` = _prefix "CHF-TOIS-OIS-COMPOUND"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF_USD-Basis_Swaps-11_00-ICAP"></see>
    /// </summary>
    let ``CHF_USD-Basis_Swaps-11_00-ICAP`` = _prefix "CHF_USD-Basis_Swaps-11_00-ICAP"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CLP-ICP"></see>
    /// </summary>
    let ``CLP-ICP`` = _prefix "CLP-ICP"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CLP-TNA"></see>
    /// </summary>
    let ``CLP-TNA`` = _prefix "CLP-TNA"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CNY-Deposit_Rate"></see>
    /// </summary>
    let ``CNY-Deposit_Rate`` = _prefix "CNY-Deposit_Rate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CNY-Fixing_Repo_Rate"></see>
    /// </summary>
    let ``CNY-Fixing_Repo_Rate`` = _prefix "CNY-Fixing_Repo_Rate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CNY-LPR"></see>
    /// </summary>
    let ``CNY-LPR`` = _prefix "CNY-LPR"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CNY-Quarterly_7D_Repo_NDS_Rate_Tradition"></see>
    /// </summary>
    let ``CNY-Quarterly_7D_Repo_NDS_Rate_Tradition`` =
        _prefix "CNY-Quarterly_7D_Repo_NDS_Rate_Tradition"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CNY-Quarterly_7_day_Repo_Non_Deliverable_Swap_Rate-TRADITION-Reference_Banks"></see>
    /// </summary>
    let ``CNY-Quarterly_7_day_Repo_Non_Deliverable_Swap_Rate-TRADITION-Reference_Banks`` =
        _prefix "CNY-Quarterly_7_day_Repo_Non_Deliverable_Swap_Rate-TRADITION-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CNY-SHIBOR"></see>
    /// </summary>
    let ``CNY-SHIBOR`` = _prefix "CNY-SHIBOR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CNY-SHIBOR-OIS_Compound"></see>
    /// </summary>
    let ``CNY-SHIBOR-OIS_Compound`` = _prefix "CNY-SHIBOR-OIS_Compound"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CNY-Semi-Annual_Swap_Rate-11_00-BGCANTOR"></see>
    /// </summary>
    let ``CNY-Semi-Annual_Swap_Rate-11_00-BGCANTOR`` =
        _prefix "CNY-Semi-Annual_Swap_Rate-11_00-BGCANTOR"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CNY-Semi-Annual_Swap_Rate-Reference_Banks"></see>
    /// </summary>
    let ``CNY-Semi-Annual_Swap_Rate-Reference_Banks`` =
        _prefix "CNY-Semi-Annual_Swap_Rate-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CNY_7-Repo_Compounding_Date"></see>
    /// </summary>
    let ``CNY_7-Repo_Compounding_Date`` = _prefix "CNY_7-Repo_Compounding_Date"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/COP-IBR-OIS_Compound"></see>
    /// </summary>
    let ``COP-IBR-OIS_Compound`` = _prefix "COP-IBR-OIS_Compound"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CZK-Annual_Swap_Rate-11_00-BGCANTOR"></see>
    /// </summary>
    let ``CZK-Annual_Swap_Rate-11_00-BGCANTOR`` =
        _prefix "CZK-Annual_Swap_Rate-11_00-BGCANTOR"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CZK-Annual_Swap_Rate-Reference_Banks"></see>
    /// </summary>
    let ``CZK-Annual_Swap_Rate-Reference_Banks`` =
        _prefix "CZK-Annual_Swap_Rate-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CZK-CZEONIA"></see>
    /// </summary>
    let ``CZK-CZEONIA`` = _prefix "CZK-CZEONIA"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CZK-CZEONIA-OIS_Compound"></see>
    /// </summary>
    let ``CZK-CZEONIA-OIS_Compound`` = _prefix "CZK-CZEONIA-OIS_Compound"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CZK-PRIBOR"></see>
    /// </summary>
    let ``CZK-PRIBOR`` = _prefix "CZK-PRIBOR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CZK-PRIBOR-Reference_Banks"></see>
    /// </summary>
    let ``CZK-PRIBOR-Reference_Banks`` = _prefix "CZK-PRIBOR-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/DKK-CIBOR"></see>
    /// </summary>
    let ``DKK-CIBOR`` = _prefix "DKK-CIBOR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/DKK-CIBOR-Reference_Banks"></see>
    /// </summary>
    let ``DKK-CIBOR-Reference_Banks`` = _prefix "DKK-CIBOR-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/DKK-CIBOR2"></see>
    /// </summary>
    let ``DKK-CIBOR2`` = _prefix "DKK-CIBOR2"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/DKK-CITA"></see>
    /// </summary>
    let ``DKK-CITA`` = _prefix "DKK-CITA"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/DKK-DESTR"></see>
    /// </summary>
    let ``DKK-DESTR`` = _prefix "DKK-DESTR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/DKK-DESTR-OIS_Compound"></see>
    /// </summary>
    let ``DKK-DESTR-OIS_Compound`` = _prefix "DKK-DESTR-OIS_Compound"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/DKK-DESTR_Compounded_Index"></see>
    /// </summary>
    let ``DKK-DESTR_Compounded_Index`` = _prefix "DKK-DESTR_Compounded_Index"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/DKK-Tom_Next-OIS_Compound"></see>
    /// </summary>
    let ``DKK-Tom_Next-OIS_Compound`` = _prefix "DKK-Tom_Next-OIS_Compound"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-3M_EURIBOR_SWAP-CME_vs_LCH-ICAP"></see>
    /// </summary>
    let ``EUR-3M_EURIBOR_SWAP-CME_vs_LCH-ICAP`` =
        _prefix "EUR-3M_EURIBOR_SWAP-CME_vs_LCH-ICAP"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-3M_EURIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg"></see>
    /// </summary>
    let ``EUR-3M_EURIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg`` =
        _prefix "EUR-3M_EURIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-3M_EURIBOR_SWAP-EUREX_vs_LCH-ICAP"></see>
    /// </summary>
    let ``EUR-3M_EURIBOR_SWAP-EUREX_vs_LCH-ICAP`` =
        _prefix "EUR-3M_EURIBOR_SWAP-EUREX_vs_LCH-ICAP"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-3M_EURIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg"></see>
    /// </summary>
    let ``EUR-3M_EURIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg`` =
        _prefix "EUR-3M_EURIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-6M_EURIBOR_SWAP-CME_vs_LCH-ICAP"></see>
    /// </summary>
    let ``EUR-6M_EURIBOR_SWAP-CME_vs_LCH-ICAP`` =
        _prefix "EUR-6M_EURIBOR_SWAP-CME_vs_LCH-ICAP"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-6M_EURIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg"></see>
    /// </summary>
    let ``EUR-6M_EURIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg`` =
        _prefix "EUR-6M_EURIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-6M_EURIBOR_SWAP-EUREX_vs_LCH-ICAP"></see>
    /// </summary>
    let ``EUR-6M_EURIBOR_SWAP-EUREX_vs_LCH-ICAP`` =
        _prefix "EUR-6M_EURIBOR_SWAP-EUREX_vs_LCH-ICAP"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-6M_EURIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg"></see>
    /// </summary>
    let ``EUR-6M_EURIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg`` =
        _prefix "EUR-6M_EURIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-10_00"></see>
    /// </summary>
    let ``EUR-Annual_Swap_Rate-10_00`` = _prefix "EUR-Annual_Swap_Rate-10_00"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-10_00-BGCANTOR"></see>
    /// </summary>
    let ``EUR-Annual_Swap_Rate-10_00-BGCANTOR`` =
        _prefix "EUR-Annual_Swap_Rate-10_00-BGCANTOR"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-10_00-Bloomberg"></see>
    /// </summary>
    let ``EUR-Annual_Swap_Rate-10_00-Bloomberg`` =
        _prefix "EUR-Annual_Swap_Rate-10_00-Bloomberg"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-10_00-ICAP"></see>
    /// </summary>
    let ``EUR-Annual_Swap_Rate-10_00-ICAP`` = _prefix "EUR-Annual_Swap_Rate-10_00-ICAP"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-10_00-SwapMarker"></see>
    /// </summary>
    let ``EUR-Annual_Swap_Rate-10_00-SwapMarker`` =
        _prefix "EUR-Annual_Swap_Rate-10_00-SwapMarker"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-10_00-TRADITION"></see>
    /// </summary>
    let ``EUR-Annual_Swap_Rate-10_00-TRADITION`` =
        _prefix "EUR-Annual_Swap_Rate-10_00-TRADITION"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-11_00"></see>
    /// </summary>
    let ``EUR-Annual_Swap_Rate-11_00`` = _prefix "EUR-Annual_Swap_Rate-11_00"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-11_00-Bloomberg"></see>
    /// </summary>
    let ``EUR-Annual_Swap_Rate-11_00-Bloomberg`` =
        _prefix "EUR-Annual_Swap_Rate-11_00-Bloomberg"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-11_00-ICAP"></see>
    /// </summary>
    let ``EUR-Annual_Swap_Rate-11_00-ICAP`` = _prefix "EUR-Annual_Swap_Rate-11_00-ICAP"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-11_00-SwapMarker"></see>
    /// </summary>
    let ``EUR-Annual_Swap_Rate-11_00-SwapMarker`` =
        _prefix "EUR-Annual_Swap_Rate-11_00-SwapMarker"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-3_Month"></see>
    /// </summary>
    let ``EUR-Annual_Swap_Rate-3_Month`` = _prefix "EUR-Annual_Swap_Rate-3_Month"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-3_Month-SwapMarker"></see>
    /// </summary>
    let ``EUR-Annual_Swap_Rate-3_Month-SwapMarker`` =
        _prefix "EUR-Annual_Swap_Rate-3_Month-SwapMarker"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-4_15-TRADITION"></see>
    /// </summary>
    let ``EUR-Annual_Swap_Rate-4_15-TRADITION`` =
        _prefix "EUR-Annual_Swap_Rate-4_15-TRADITION"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-Reference_Banks"></see>
    /// </summary>
    let ``EUR-Annual_Swap_Rate-Reference_Banks`` =
        _prefix "EUR-Annual_Swap_Rate-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-CNO_TEC10"></see>
    /// </summary>
    let ``EUR-CNO_TEC10`` = _prefix "EUR-CNO_TEC10"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EONIA"></see>
    /// </summary>
    let ``EUR-EONIA`` = _prefix "EUR-EONIA"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EONIA-Average"></see>
    /// </summary>
    let ``EUR-EONIA-Average`` = _prefix "EUR-EONIA-Average"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EONIA-OIS-10_00-BGCANTOR"></see>
    /// </summary>
    let ``EUR-EONIA-OIS-10_00-BGCANTOR`` = _prefix "EUR-EONIA-OIS-10_00-BGCANTOR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EONIA-OIS-10_00-ICAP"></see>
    /// </summary>
    let ``EUR-EONIA-OIS-10_00-ICAP`` = _prefix "EUR-EONIA-OIS-10_00-ICAP"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EONIA-OIS-10_00-TRADITION"></see>
    /// </summary>
    let ``EUR-EONIA-OIS-10_00-TRADITION`` = _prefix "EUR-EONIA-OIS-10_00-TRADITION"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EONIA-OIS-11_00-ICAP"></see>
    /// </summary>
    let ``EUR-EONIA-OIS-11_00-ICAP`` = _prefix "EUR-EONIA-OIS-11_00-ICAP"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EONIA-OIS-4_15-TRADITION"></see>
    /// </summary>
    let ``EUR-EONIA-OIS-4_15-TRADITION`` = _prefix "EUR-EONIA-OIS-4_15-TRADITION"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EONIA-OIS_Compound"></see>
    /// </summary>
    let ``EUR-EONIA-OIS_Compound`` = _prefix "EUR-EONIA-OIS_Compound"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EONIA-Swap-Index"></see>
    /// </summary>
    let ``EUR-EONIA-Swap-Index`` = _prefix "EUR-EONIA-Swap-Index"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EURIBOR"></see>
    /// </summary>
    let ``EUR-EURIBOR`` = _prefix "EUR-EURIBOR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EURIBOR-Act_365"></see>
    /// </summary>
    let ``EUR-EURIBOR-Act_365`` = _prefix "EUR-EURIBOR-Act_365"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EURIBOR-Act_365-Bloomberg"></see>
    /// </summary>
    let ``EUR-EURIBOR-Act_365-Bloomberg`` = _prefix "EUR-EURIBOR-Act_365-Bloomberg"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EURIBOR-Reference_Banks"></see>
    /// </summary>
    let ``EUR-EURIBOR-Reference_Banks`` = _prefix "EUR-EURIBOR-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EURIBOR-Telerate"></see>
    /// </summary>
    let ``EUR-EURIBOR-Telerate`` = _prefix "EUR-EURIBOR-Telerate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EURIBOR_ICE_Swap_Rate-11_00"></see>
    /// </summary>
    let ``EUR-EURIBOR_ICE_Swap_Rate-11_00`` = _prefix "EUR-EURIBOR_ICE_Swap_Rate-11_00"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EURIBOR_ICE_Swap_Rate-12_00"></see>
    /// </summary>
    let ``EUR-EURIBOR_ICE_Swap_Rate-12_00`` = _prefix "EUR-EURIBOR_ICE_Swap_Rate-12_00"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EURONIA-OIS_Compound"></see>
    /// </summary>
    let ``EUR-EURONIA-OIS_Compound`` = _prefix "EUR-EURONIA-OIS_Compound"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR"></see>
    /// </summary>
    let ``EUR-EuroSTR`` = _prefix "EUR-EuroSTR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR-OIS_Compound"></see>
    /// </summary>
    let ``EUR-EuroSTR-OIS_Compound`` = _prefix "EUR-EuroSTR-OIS_Compound"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_Average_12M"></see>
    /// </summary>
    let ``EUR-EuroSTR_Average_12M`` = _prefix "EUR-EuroSTR_Average_12M"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_Average_1M"></see>
    /// </summary>
    let ``EUR-EuroSTR_Average_1M`` = _prefix "EUR-EuroSTR_Average_1M"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_Average_1W"></see>
    /// </summary>
    let ``EUR-EuroSTR_Average_1W`` = _prefix "EUR-EuroSTR_Average_1W"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_Average_3M"></see>
    /// </summary>
    let ``EUR-EuroSTR_Average_3M`` = _prefix "EUR-EuroSTR_Average_3M"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_Average_6M"></see>
    /// </summary>
    let ``EUR-EuroSTR_Average_6M`` = _prefix "EUR-EuroSTR_Average_6M"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_Compounded_Index"></see>
    /// </summary>
    let ``EUR-EuroSTR_Compounded_Index`` = _prefix "EUR-EuroSTR_Compounded_Index"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_FTSE_Term"></see>
    /// </summary>
    let ``EUR-EuroSTR_FTSE_Term`` = _prefix "EUR-EuroSTR_FTSE_Term"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_ICE_Compounded_Index"></see>
    /// </summary>
    let ``EUR-EuroSTR_ICE_Compounded_Index`` =
        _prefix "EUR-EuroSTR_ICE_Compounded_Index"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_ICE_Compounded_Index_0_Floor"></see>
    /// </summary>
    let ``EUR-EuroSTR_ICE_Compounded_Index_0_Floor`` =
        _prefix "EUR-EuroSTR_ICE_Compounded_Index_0_Floor"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_ICE_Compounded_Index_0_Floor_2D_Lag"></see>
    /// </summary>
    let ``EUR-EuroSTR_ICE_Compounded_Index_0_Floor_2D_Lag`` =
        _prefix "EUR-EuroSTR_ICE_Compounded_Index_0_Floor_2D_Lag"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_ICE_Compounded_Index_0_Floor_5D_Lag"></see>
    /// </summary>
    let ``EUR-EuroSTR_ICE_Compounded_Index_0_Floor_5D_Lag`` =
        _prefix "EUR-EuroSTR_ICE_Compounded_Index_0_Floor_5D_Lag"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_ICE_Compounded_Index_2D_Lag"></see>
    /// </summary>
    let ``EUR-EuroSTR_ICE_Compounded_Index_2D_Lag`` =
        _prefix "EUR-EuroSTR_ICE_Compounded_Index_2D_Lag"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_ICE_Compounded_Index_5D_Lag"></see>
    /// </summary>
    let ``EUR-EuroSTR_ICE_Compounded_Index_5D_Lag`` =
        _prefix "EUR-EuroSTR_ICE_Compounded_Index_5D_Lag"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_ICE_Swap_Rate"></see>
    /// </summary>
    let ``EUR-EuroSTR_ICE_Swap_Rate`` = _prefix "EUR-EuroSTR_ICE_Swap_Rate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_Term"></see>
    /// </summary>
    let ``EUR-EuroSTR_Term`` = _prefix "EUR-EuroSTR_Term"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-ISDA-LIBOR_Swap_Rate-10_00"></see>
    /// </summary>
    let ``EUR-ISDA-LIBOR_Swap_Rate-10_00`` = _prefix "EUR-ISDA-LIBOR_Swap_Rate-10_00"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-ISDA-LIBOR_Swap_Rate-11_00"></see>
    /// </summary>
    let ``EUR-ISDA-LIBOR_Swap_Rate-11_00`` = _prefix "EUR-ISDA-LIBOR_Swap_Rate-11_00"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-LIBOR"></see>
    /// </summary>
    let ``EUR-LIBOR`` = _prefix "EUR-LIBOR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-LIBOR-Reference_Banks"></see>
    /// </summary>
    let ``EUR-LIBOR-Reference_Banks`` = _prefix "EUR-LIBOR-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-TAM-CDC"></see>
    /// </summary>
    let ``EUR-TAM-CDC`` = _prefix "EUR-TAM-CDC"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-TEC10-Reference_Banks"></see>
    /// </summary>
    let ``EUR-TEC10-Reference_Banks`` = _prefix "EUR-TEC10-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-TEC5-CNO"></see>
    /// </summary>
    let ``EUR-TEC5-CNO`` = _prefix "EUR-TEC5-CNO"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-TEC5-CNO-SwapMarker"></see>
    /// </summary>
    let ``EUR-TEC5-CNO-SwapMarker`` = _prefix "EUR-TEC5-CNO-SwapMarker"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-TEC5-Reference_Banks"></see>
    /// </summary>
    let ``EUR-TEC5-Reference_Banks`` = _prefix "EUR-TEC5-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-TMM-CDC-COMPOUND"></see>
    /// </summary>
    let ``EUR-TMM-CDC-COMPOUND`` = _prefix "EUR-TMM-CDC-COMPOUND"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR_Basis_Swap-EONIA_vs_3m_EUR_IBOR_Swap_Rates-A_360-10_00-ICAP"></see>
    /// </summary>
    let ``EUR_Basis_Swap-EONIA_vs_3m_EUR_IBOR_Swap_Rates-A_360-10_00-ICAP`` =
        _prefix "EUR_Basis_Swap-EONIA_vs_3m_EUR_IBOR_Swap_Rates-A_360-10_00-ICAP"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR_EURIBOR-Annual_Bond_Swap_vs_1m-11_00-ICAP"></see>
    /// </summary>
    let ``EUR_EURIBOR-Annual_Bond_Swap_vs_1m-11_00-ICAP`` =
        _prefix "EUR_EURIBOR-Annual_Bond_Swap_vs_1m-11_00-ICAP"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR_EURIBOR-Basis_Swap-1m_vs_3m-Euribor-11_00-ICAP"></see>
    /// </summary>
    let ``EUR_EURIBOR-Basis_Swap-1m_vs_3m-Euribor-11_00-ICAP`` =
        _prefix "EUR_EURIBOR-Basis_Swap-1m_vs_3m-Euribor-11_00-ICAP"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR_EURIBOR-Basis_Swap-3m_vs_6m-11_00-ICAP"></see>
    /// </summary>
    let ``EUR_EURIBOR-Basis_Swap-3m_vs_6m-11_00-ICAP`` =
        _prefix "EUR_EURIBOR-Basis_Swap-3m_vs_6m-11_00-ICAP"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR_USD-Basis_Swaps-11_00-ICAP"></see>
    /// </summary>
    let ``EUR_USD-Basis_Swaps-11_00-ICAP`` = _prefix "EUR_USD-Basis_Swaps-11_00-ICAP"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-6M_LIBOR_SWAP-CME_vs_LCH-ICAP"></see>
    /// </summary>
    let ``GBP-6M_LIBOR_SWAP-CME_vs_LCH-ICAP`` =
        _prefix "GBP-6M_LIBOR_SWAP-CME_vs_LCH-ICAP"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-6M_LIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg"></see>
    /// </summary>
    let ``GBP-6M_LIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg`` =
        _prefix "GBP-6M_LIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-6M_LIBOR_SWAP-EUREX_vs_LCH-ICAP"></see>
    /// </summary>
    let ``GBP-6M_LIBOR_SWAP-EUREX_vs_LCH-ICAP`` =
        _prefix "GBP-6M_LIBOR_SWAP-EUREX_vs_LCH-ICAP"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-6M_LIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg"></see>
    /// </summary>
    let ``GBP-6M_LIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg`` =
        _prefix "GBP-6M_LIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-LIBOR"></see>
    /// </summary>
    let ``GBP-LIBOR`` = _prefix "GBP-LIBOR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-LIBOR-ISDA"></see>
    /// </summary>
    let ``GBP-LIBOR-ISDA`` = _prefix "GBP-LIBOR-ISDA"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-LIBOR-Reference_Banks"></see>
    /// </summary>
    let ``GBP-LIBOR-Reference_Banks`` = _prefix "GBP-LIBOR-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-LIBOR_ICE_Swap_Rate"></see>
    /// </summary>
    let ``GBP-LIBOR_ICE_Swap_Rate`` = _prefix "GBP-LIBOR_ICE_Swap_Rate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-RONIA"></see>
    /// </summary>
    let ``GBP-RONIA`` = _prefix "GBP-RONIA"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-RONIA-OIS_Compound"></see>
    /// </summary>
    let ``GBP-RONIA-OIS_Compound`` = _prefix "GBP-RONIA-OIS_Compound"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA"></see>
    /// </summary>
    let ``GBP-SONIA`` = _prefix "GBP-SONIA"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA-OIS-11_00-ICAP"></see>
    /// </summary>
    let ``GBP-SONIA-OIS-11_00-ICAP`` = _prefix "GBP-SONIA-OIS-11_00-ICAP"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA-OIS-11_00-TRADITION"></see>
    /// </summary>
    let ``GBP-SONIA-OIS-11_00-TRADITION`` = _prefix "GBP-SONIA-OIS-11_00-TRADITION"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA-OIS-4_15-TRADITION"></see>
    /// </summary>
    let ``GBP-SONIA-OIS-4_15-TRADITION`` = _prefix "GBP-SONIA-OIS-4_15-TRADITION"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA-OIS_Compound"></see>
    /// </summary>
    let ``GBP-SONIA-OIS_Compound`` = _prefix "GBP-SONIA-OIS_Compound"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA_Compounded_Index"></see>
    /// </summary>
    let ``GBP-SONIA_Compounded_Index`` = _prefix "GBP-SONIA_Compounded_Index"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA_FTSE_Term"></see>
    /// </summary>
    let ``GBP-SONIA_FTSE_Term`` = _prefix "GBP-SONIA_FTSE_Term"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA_ICE_Compounded_Index"></see>
    /// </summary>
    let ``GBP-SONIA_ICE_Compounded_Index`` = _prefix "GBP-SONIA_ICE_Compounded_Index"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA_ICE_Compounded_Index_0_Floor"></see>
    /// </summary>
    let ``GBP-SONIA_ICE_Compounded_Index_0_Floor`` =
        _prefix "GBP-SONIA_ICE_Compounded_Index_0_Floor"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA_ICE_Compounded_Index_0_Floor_2D_Lag"></see>
    /// </summary>
    let ``GBP-SONIA_ICE_Compounded_Index_0_Floor_2D_Lag`` =
        _prefix "GBP-SONIA_ICE_Compounded_Index_0_Floor_2D_Lag"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA_ICE_Compounded_Index_0_Floor_5D_Lag"></see>
    /// </summary>
    let ``GBP-SONIA_ICE_Compounded_Index_0_Floor_5D_Lag`` =
        _prefix "GBP-SONIA_ICE_Compounded_Index_0_Floor_5D_Lag"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA_ICE_Compounded_Index_2D_Lag"></see>
    /// </summary>
    let ``GBP-SONIA_ICE_Compounded_Index_2D_Lag`` =
        _prefix "GBP-SONIA_ICE_Compounded_Index_2D_Lag"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA_ICE_Compounded_Index_5D_Lag"></see>
    /// </summary>
    let ``GBP-SONIA_ICE_Compounded_Index_5D_Lag`` =
        _prefix "GBP-SONIA_ICE_Compounded_Index_5D_Lag"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA_ICE_Swap_Rate"></see>
    /// </summary>
    let ``GBP-SONIA_ICE_Swap_Rate`` = _prefix "GBP-SONIA_ICE_Swap_Rate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA_ICE_Term"></see>
    /// </summary>
    let ``GBP-SONIA_ICE_Term`` = _prefix "GBP-SONIA_ICE_Term"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-Semi-Annual_Swap_Rate"></see>
    /// </summary>
    let ``GBP-Semi-Annual_Swap_Rate`` = _prefix "GBP-Semi-Annual_Swap_Rate"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-Semi-Annual_Swap_Rate-11_00-ICAP"></see>
    /// </summary>
    let ``GBP-Semi-Annual_Swap_Rate-11_00-ICAP`` =
        _prefix "GBP-Semi-Annual_Swap_Rate-11_00-ICAP"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-Semi-Annual_Swap_Rate-Reference_Banks"></see>
    /// </summary>
    let ``GBP-Semi-Annual_Swap_Rate-Reference_Banks`` =
        _prefix "GBP-Semi-Annual_Swap_Rate-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-Semi-Annual_Swap_Rate-SwapMarker26"></see>
    /// </summary>
    let ``GBP-Semi-Annual_Swap_Rate-SwapMarker26`` =
        _prefix "GBP-Semi-Annual_Swap_Rate-SwapMarker26"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-Semi_Annual_Swap_Rate-11_00-TRADITION"></see>
    /// </summary>
    let ``GBP-Semi_Annual_Swap_Rate-11_00-TRADITION`` =
        _prefix "GBP-Semi_Annual_Swap_Rate-11_00-TRADITION"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-Semi_Annual_Swap_Rate-4_15-TRADITION"></see>
    /// </summary>
    let ``GBP-Semi_Annual_Swap_Rate-4_15-TRADITION`` =
        _prefix "GBP-Semi_Annual_Swap_Rate-4_15-TRADITION"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-UK_Base_Rate"></see>
    /// </summary>
    let ``GBP-UK_Base_Rate`` = _prefix "GBP-UK_Base_Rate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP_USD-Basis_Swaps-11_00-ICAP"></see>
    /// </summary>
    let ``GBP_USD-Basis_Swaps-11_00-ICAP`` = _prefix "GBP_USD-Basis_Swaps-11_00-ICAP"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GRD-ATHIBOR-ATHIBOR"></see>
    /// </summary>
    let ``GRD-ATHIBOR-ATHIBOR`` = _prefix "GRD-ATHIBOR-ATHIBOR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GRD-ATHIBOR-Reference_Banks"></see>
    /// </summary>
    let ``GRD-ATHIBOR-Reference_Banks`` = _prefix "GRD-ATHIBOR-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GRD-ATHIBOR-Telerate"></see>
    /// </summary>
    let ``GRD-ATHIBOR-Telerate`` = _prefix "GRD-ATHIBOR-Telerate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GRD-ATHIMID-Reference_Banks"></see>
    /// </summary>
    let ``GRD-ATHIMID-Reference_Banks`` = _prefix "GRD-ATHIMID-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GRD-ATHIMID-Reuters"></see>
    /// </summary>
    let ``GRD-ATHIMID-Reuters`` = _prefix "GRD-ATHIMID-Reuters"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-HIBOR"></see>
    /// </summary>
    let ``HKD-HIBOR`` = _prefix "HKD-HIBOR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-HIBOR-HIBOR-Bloomberg"></see>
    /// </summary>
    let ``HKD-HIBOR-HIBOR-Bloomberg`` = _prefix "HKD-HIBOR-HIBOR-Bloomberg"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-HIBOR-HIBOR_"></see>
    /// </summary>
    let ``HKD-HIBOR-HIBOR_`` = _prefix "HKD-HIBOR-HIBOR_"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-HIBOR-ISDC"></see>
    /// </summary>
    let ``HKD-HIBOR-ISDC`` = _prefix "HKD-HIBOR-ISDC"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-HIBOR-Reference_Banks"></see>
    /// </summary>
    let ``HKD-HIBOR-Reference_Banks`` = _prefix "HKD-HIBOR-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-HONIA"></see>
    /// </summary>
    let ``HKD-HONIA`` = _prefix "HKD-HONIA"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-HONIA-OIS_Compound"></see>
    /// </summary>
    let ``HKD-HONIA-OIS_Compound`` = _prefix "HKD-HONIA-OIS_Compound"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-ISDA-Swap_Rate-11_00"></see>
    /// </summary>
    let ``HKD-ISDA-Swap_Rate-11_00`` = _prefix "HKD-ISDA-Swap_Rate-11_00"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-ISDA-Swap_Rate-4_00"></see>
    /// </summary>
    let ``HKD-ISDA-Swap_Rate-4_00`` = _prefix "HKD-ISDA-Swap_Rate-4_00"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-Quarterly-Annual_Swap_Rate-11_00-BGCANTOR"></see>
    /// </summary>
    let ``HKD-Quarterly-Annual_Swap_Rate-11_00-BGCANTOR`` =
        _prefix "HKD-Quarterly-Annual_Swap_Rate-11_00-BGCANTOR"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-Quarterly-Annual_Swap_Rate-11_00-TRADITION"></see>
    /// </summary>
    let ``HKD-Quarterly-Annual_Swap_Rate-11_00-TRADITION`` =
        _prefix "HKD-Quarterly-Annual_Swap_Rate-11_00-TRADITION"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-Quarterly-Annual_Swap_Rate-4_00-BGCANTOR"></see>
    /// </summary>
    let ``HKD-Quarterly-Annual_Swap_Rate-4_00-BGCANTOR`` =
        _prefix "HKD-Quarterly-Annual_Swap_Rate-4_00-BGCANTOR"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-Quarterly-Annual_Swap_Rate-Reference_Banks"></see>
    /// </summary>
    let ``HKD-Quarterly-Annual_Swap_Rate-Reference_Banks`` =
        _prefix "HKD-Quarterly-Annual_Swap_Rate-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-Quarterly-Quarterly_Swap_Rate-11_00-ICAP"></see>
    /// </summary>
    let ``HKD-Quarterly-Quarterly_Swap_Rate-11_00-ICAP`` =
        _prefix "HKD-Quarterly-Quarterly_Swap_Rate-11_00-ICAP"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-Quarterly-Quarterly_Swap_Rate-4_00-ICAP"></see>
    /// </summary>
    let ``HKD-Quarterly-Quarterly_Swap_Rate-4_00-ICAP`` =
        _prefix "HKD-Quarterly-Quarterly_Swap_Rate-4_00-ICAP"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-Quarterly-Quarterly_Swap_Rate-Reference_Banks"></see>
    /// </summary>
    let ``HKD-Quarterly-Quarterly_Swap_Rate-Reference_Banks`` =
        _prefix "HKD-Quarterly-Quarterly_Swap_Rate-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HUF-BUBOR"></see>
    /// </summary>
    let ``HUF-BUBOR`` = _prefix "HUF-BUBOR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HUF-BUBOR-Reference_Banks"></see>
    /// </summary>
    let ``HUF-BUBOR-Reference_Banks`` = _prefix "HUF-BUBOR-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HUF-HUFONIA"></see>
    /// </summary>
    let ``HUF-HUFONIA`` = _prefix "HUF-HUFONIA"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HUF-HUFONIA-OIS_Compound"></see>
    /// </summary>
    let ``HUF-HUFONIA-OIS_Compound`` = _prefix "HUF-HUFONIA-OIS_Compound"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/IDR-IDMA-Bloomberg"></see>
    /// </summary>
    let ``IDR-IDMA-Bloomberg`` = _prefix "IDR-IDMA-Bloomberg"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/IDR-IDRFIX"></see>
    /// </summary>
    let ``IDR-IDRFIX`` = _prefix "IDR-IDRFIX"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/IDR-INDONIA"></see>
    /// </summary>
    let ``IDR-INDONIA`` = _prefix "IDR-INDONIA"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/IDR-INDONIA-OIS_Compound"></see>
    /// </summary>
    let ``IDR-INDONIA-OIS_Compound`` = _prefix "IDR-INDONIA-OIS_Compound"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/IDR-JIBOR"></see>
    /// </summary>
    let ``IDR-JIBOR`` = _prefix "IDR-JIBOR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/IDR-SBI-Reuters"></see>
    /// </summary>
    let ``IDR-SBI-Reuters`` = _prefix "IDR-SBI-Reuters"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/IDR-SOR-Reference_Banks"></see>
    /// </summary>
    let ``IDR-SOR-Reference_Banks`` = _prefix "IDR-SOR-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/IDR-SOR-Reuters"></see>
    /// </summary>
    let ``IDR-SOR-Reuters`` = _prefix "IDR-SOR-Reuters"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/IDR-SOR-Telerate"></see>
    /// </summary>
    let ``IDR-SOR-Telerate`` = _prefix "IDR-SOR-Telerate"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/IDR-Semi-Annual_Swap_Rate-11_00-BGCANTOR"></see>
    /// </summary>
    let ``IDR-Semi-Annual_Swap_Rate-11_00-BGCANTOR`` =
        _prefix "IDR-Semi-Annual_Swap_Rate-11_00-BGCANTOR"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/IDR-Semi-Annual_Swap_Rate-Reference_Banks"></see>
    /// </summary>
    let ``IDR-Semi-Annual_Swap_Rate-Reference_Banks`` =
        _prefix "IDR-Semi-Annual_Swap_Rate-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/IDR-Semi_Annual_Swap_Rate-Non-deliverable-16_00-Tullett_Prebon"></see>
    /// </summary>
    let ``IDR-Semi_Annual_Swap_Rate-Non-deliverable-16_00-Tullett_Prebon`` =
        _prefix "IDR-Semi_Annual_Swap_Rate-Non-deliverable-16_00-Tullett_Prebon"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ILS-SHIR"></see>
    /// </summary>
    let ``ILS-SHIR`` = _prefix "ILS-SHIR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ILS-SHIR-OIS_Compound"></see>
    /// </summary>
    let ``ILS-SHIR-OIS_Compound`` = _prefix "ILS-SHIR-OIS_Compound"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ILS-TELBOR"></see>
    /// </summary>
    let ``ILS-TELBOR`` = _prefix "ILS-TELBOR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ILS-TELBOR-Reference_Banks"></see>
    /// </summary>
    let ``ILS-TELBOR-Reference_Banks`` = _prefix "ILS-TELBOR-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-BMK"></see>
    /// </summary>
    let ``INR-BMK`` = _prefix "INR-BMK"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-CMT"></see>
    /// </summary>
    let ``INR-CMT`` = _prefix "INR-CMT"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-INBMK-REUTERS"></see>
    /// </summary>
    let ``INR-INBMK-REUTERS`` = _prefix "INR-INBMK-REUTERS"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-MIBOR-OIS-COMPOUND"></see>
    /// </summary>
    let ``INR-MIBOR-OIS-COMPOUND`` = _prefix "INR-MIBOR-OIS-COMPOUND"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-MIBOR-OIS_Compound"></see>
    /// </summary>
    let ``INR-MIBOR-OIS_Compound`` = _prefix "INR-MIBOR-OIS_Compound"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-MIBOR_OIS"></see>
    /// </summary>
    let ``INR-MIBOR_OIS`` = _prefix "INR-MIBOR_OIS"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-MIFOR"></see>
    /// </summary>
    let ``INR-MIFOR`` = _prefix "INR-MIFOR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-MITOR-OIS-COMPOUND"></see>
    /// </summary>
    let ``INR-MITOR-OIS-COMPOUND`` = _prefix "INR-MITOR-OIS-COMPOUND"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-Modified_MIFOR"></see>
    /// </summary>
    let ``INR-Modified_MIFOR`` = _prefix "INR-Modified_MIFOR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-Reference_Banks"></see>
    /// </summary>
    let ``INR-Reference_Banks`` = _prefix "INR-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-Semi-Annual_Swap_Rate-11_30-BGCANTOR"></see>
    /// </summary>
    let ``INR-Semi-Annual_Swap_Rate-11_30-BGCANTOR`` =
        _prefix "INR-Semi-Annual_Swap_Rate-11_30-BGCANTOR"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-Semi-Annual_Swap_Rate-Reference_Banks"></see>
    /// </summary>
    let ``INR-Semi-Annual_Swap_Rate-Reference_Banks`` =
        _prefix "INR-Semi-Annual_Swap_Rate-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-Semi_Annual_Swap_Rate-Non-deliverable-16_00-Tullett_Prebon"></see>
    /// </summary>
    let ``INR-Semi_Annual_Swap_Rate-Non-deliverable-16_00-Tullett_Prebon`` =
        _prefix "INR-Semi_Annual_Swap_Rate-Non-deliverable-16_00-Tullett_Prebon"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ISK-REIBOR"></see>
    /// </summary>
    let ``ISK-REIBOR`` = _prefix "ISK-REIBOR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ISK-REIBOR-Reference_Banks"></see>
    /// </summary>
    let ``ISK-REIBOR-Reference_Banks`` = _prefix "ISK-REIBOR-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-Annual_Swap_Rate-11_00-TRADITION"></see>
    /// </summary>
    let ``JPY-Annual_Swap_Rate-11_00-TRADITION`` =
        _prefix "JPY-Annual_Swap_Rate-11_00-TRADITION"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-Annual_Swap_Rate-3_00-TRADITION"></see>
    /// </summary>
    let ``JPY-Annual_Swap_Rate-3_00-TRADITION`` =
        _prefix "JPY-Annual_Swap_Rate-3_00-TRADITION"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-BBSF-Bloomberg-10_00"></see>
    /// </summary>
    let ``JPY-BBSF-Bloomberg-10_00`` = _prefix "JPY-BBSF-Bloomberg-10_00"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-BBSF-Bloomberg-15_00"></see>
    /// </summary>
    let ``JPY-BBSF-Bloomberg-15_00`` = _prefix "JPY-BBSF-Bloomberg-15_00"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-Euroyen_TIBOR"></see>
    /// </summary>
    let ``JPY-Euroyen_TIBOR`` = _prefix "JPY-Euroyen_TIBOR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-ISDA-Swap_Rate-10_00"></see>
    /// </summary>
    let ``JPY-ISDA-Swap_Rate-10_00`` = _prefix "JPY-ISDA-Swap_Rate-10_00"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-ISDA-Swap_Rate-15_00"></see>
    /// </summary>
    let ``JPY-ISDA-Swap_Rate-15_00`` = _prefix "JPY-ISDA-Swap_Rate-15_00"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-LIBOR"></see>
    /// </summary>
    let ``JPY-LIBOR`` = _prefix "JPY-LIBOR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-LIBOR-ISDA"></see>
    /// </summary>
    let ``JPY-LIBOR-ISDA`` = _prefix "JPY-LIBOR-ISDA"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-LIBOR-Reference_Banks"></see>
    /// </summary>
    let ``JPY-LIBOR-Reference_Banks`` = _prefix "JPY-LIBOR-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-LIBOR_TSR-10_00"></see>
    /// </summary>
    let ``JPY-LIBOR_TSR-10_00`` = _prefix "JPY-LIBOR_TSR-10_00"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-LIBOR_TSR-15_00"></see>
    /// </summary>
    let ``JPY-LIBOR_TSR-15_00`` = _prefix "JPY-LIBOR_TSR-15_00"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-LTPR-TBC"></see>
    /// </summary>
    let ``JPY-LTPR-TBC`` = _prefix "JPY-LTPR-TBC"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-LTPR_MHBK"></see>
    /// </summary>
    let ``JPY-LTPR_MHBK`` = _prefix "JPY-LTPR_MHBK"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-MUTANCALL-TONAR"></see>
    /// </summary>
    let ``JPY-MUTANCALL-TONAR`` = _prefix "JPY-MUTANCALL-TONAR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-OIS-11_00-ICAP"></see>
    /// </summary>
    let ``JPY-OIS-11_00-ICAP`` = _prefix "JPY-OIS-11_00-ICAP"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-OIS-11_00-TRADITION"></see>
    /// </summary>
    let ``JPY-OIS-11_00-TRADITION`` = _prefix "JPY-OIS-11_00-TRADITION"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-OIS-3_00-TRADITION"></see>
    /// </summary>
    let ``JPY-OIS-3_00-TRADITION`` = _prefix "JPY-OIS-3_00-TRADITION"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-Quoting_Banks-LIBOR"></see>
    /// </summary>
    let ``JPY-Quoting_Banks-LIBOR`` = _prefix "JPY-Quoting_Banks-LIBOR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-STPR-Quoting_Banks"></see>
    /// </summary>
    let ``JPY-STPR-Quoting_Banks`` = _prefix "JPY-STPR-Quoting_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TIBOR"></see>
    /// </summary>
    let ``JPY-TIBOR`` = _prefix "JPY-TIBOR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TIBOR-17096"></see>
    /// </summary>
    let ``JPY-TIBOR-17096`` = _prefix "JPY-TIBOR-17096"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TIBOR-DTIBOR01"></see>
    /// </summary>
    let ``JPY-TIBOR-DTIBOR01`` = _prefix "JPY-TIBOR-DTIBOR01"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TIBOR-TIBM"></see>
    /// </summary>
    let ``JPY-TIBOR-TIBM`` = _prefix "JPY-TIBOR-TIBM"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TIBOR-TIBM-Reference_Banks"></see>
    /// </summary>
    let ``JPY-TIBOR-TIBM-Reference_Banks`` = _prefix "JPY-TIBOR-TIBM-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TIBOR-TIBM_10_Banks"></see>
    /// </summary>
    let ``JPY-TIBOR-TIBM_10_Banks`` = _prefix "JPY-TIBOR-TIBM_10_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TIBOR-TIBM_5_Banks"></see>
    /// </summary>
    let ``JPY-TIBOR-TIBM_5_Banks`` = _prefix "JPY-TIBOR-TIBM_5_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TIBOR-TIBM_All_Banks"></see>
    /// </summary>
    let ``JPY-TIBOR-TIBM_All_Banks`` = _prefix "JPY-TIBOR-TIBM_All_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA"></see>
    /// </summary>
    let ``JPY-TONA`` = _prefix "JPY-TONA"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA-OIS_Compound"></see>
    /// </summary>
    let ``JPY-TONA-OIS_Compound`` = _prefix "JPY-TONA-OIS_Compound"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA_Average_180D"></see>
    /// </summary>
    let ``JPY-TONA_Average_180D`` = _prefix "JPY-TONA_Average_180D"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA_Average_30D"></see>
    /// </summary>
    let ``JPY-TONA_Average_30D`` = _prefix "JPY-TONA_Average_30D"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA_Average_90D"></see>
    /// </summary>
    let ``JPY-TONA_Average_90D`` = _prefix "JPY-TONA_Average_90D"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA_Compounded_Index"></see>
    /// </summary>
    let ``JPY-TONA_Compounded_Index`` = _prefix "JPY-TONA_Compounded_Index"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA_ICE_Compounded_Index"></see>
    /// </summary>
    let ``JPY-TONA_ICE_Compounded_Index`` = _prefix "JPY-TONA_ICE_Compounded_Index"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA_ICE_Compounded_Index_0_Floor"></see>
    /// </summary>
    let ``JPY-TONA_ICE_Compounded_Index_0_Floor`` =
        _prefix "JPY-TONA_ICE_Compounded_Index_0_Floor"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA_ICE_Compounded_Index_0_Floor_2D_Lag"></see>
    /// </summary>
    let ``JPY-TONA_ICE_Compounded_Index_0_Floor_2D_Lag`` =
        _prefix "JPY-TONA_ICE_Compounded_Index_0_Floor_2D_Lag"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA_ICE_Compounded_Index_0_Floor_5D_Lag"></see>
    /// </summary>
    let ``JPY-TONA_ICE_Compounded_Index_0_Floor_5D_Lag`` =
        _prefix "JPY-TONA_ICE_Compounded_Index_0_Floor_5D_Lag"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA_ICE_Compounded_Index_2D_Lag"></see>
    /// </summary>
    let ``JPY-TONA_ICE_Compounded_Index_2D_Lag`` =
        _prefix "JPY-TONA_ICE_Compounded_Index_2D_Lag"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA_ICE_Compounded_Index_5D_Lag"></see>
    /// </summary>
    let ``JPY-TONA_ICE_Compounded_Index_5D_Lag`` =
        _prefix "JPY-TONA_ICE_Compounded_Index_5D_Lag"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA_TSR-10_00"></see>
    /// </summary>
    let ``JPY-TONA_TSR-10_00`` = _prefix "JPY-TONA_TSR-10_00"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA_TSR-15_00"></see>
    /// </summary>
    let ``JPY-TONA_TSR-15_00`` = _prefix "JPY-TONA_TSR-15_00"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TORF_QUICK"></see>
    /// </summary>
    let ``JPY-TORF_QUICK`` = _prefix "JPY-TORF_QUICK"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TSR-Reference_Banks"></see>
    /// </summary>
    let ``JPY-TSR-Reference_Banks`` = _prefix "JPY-TSR-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TSR-Telerate-10_00"></see>
    /// </summary>
    let ``JPY-TSR-Telerate-10_00`` = _prefix "JPY-TSR-Telerate-10_00"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TSR-Telerate-15_00"></see>
    /// </summary>
    let ``JPY-TSR-Telerate-15_00`` = _prefix "JPY-TSR-Telerate-15_00"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY_USD-Basis_Swaps-11_00-ICAP"></see>
    /// </summary>
    let ``JPY_USD-Basis_Swaps-11_00-ICAP`` = _prefix "JPY_USD-Basis_Swaps-11_00-ICAP"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/KRW-Bond-3222"></see>
    /// </summary>
    let ``KRW-Bond-3222`` = _prefix "KRW-Bond-3222"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/KRW-CD_91D"></see>
    /// </summary>
    let ``KRW-CD_91D`` = _prefix "KRW-CD_91D"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/KRW-KOFR"></see>
    /// </summary>
    let ``KRW-KOFR`` = _prefix "KRW-KOFR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/KRW-KOFR-OIS_Compound"></see>
    /// </summary>
    let ``KRW-KOFR-OIS_Compound`` = _prefix "KRW-KOFR-OIS_Compound"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/KRW-Quarterly_Annual_Swap_Rate-3_30-ICAP"></see>
    /// </summary>
    let ``KRW-Quarterly_Annual_Swap_Rate-3_30-ICAP`` =
        _prefix "KRW-Quarterly_Annual_Swap_Rate-3_30-ICAP"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/MXN-TIIE"></see>
    /// </summary>
    let ``MXN-TIIE`` = _prefix "MXN-TIIE"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/MXN-TIIE-Banxico-Reference_Banks"></see>
    /// </summary>
    let ``MXN-TIIE-Banxico-Reference_Banks`` =
        _prefix "MXN-TIIE-Banxico-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/MXN-TIIE-Reference_Banks"></see>
    /// </summary>
    let ``MXN-TIIE-Reference_Banks`` = _prefix "MXN-TIIE-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/MXN-TIIE_ON"></see>
    /// </summary>
    let ``MXN-TIIE_ON`` = _prefix "MXN-TIIE_ON"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/MXN-TIIE_ON-OIS_Compound"></see>
    /// </summary>
    let ``MXN-TIIE_ON-OIS_Compound`` = _prefix "MXN-TIIE_ON-OIS_Compound"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/MYR-KLIBOR"></see>
    /// </summary>
    let ``MYR-KLIBOR`` = _prefix "MYR-KLIBOR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/MYR-KLIBOR-Reference_Banks"></see>
    /// </summary>
    let ``MYR-KLIBOR-Reference_Banks`` = _prefix "MYR-KLIBOR-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/MYR-MYOR"></see>
    /// </summary>
    let ``MYR-MYOR`` = _prefix "MYR-MYOR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/MYR-MYOR-OIS_Compound"></see>
    /// </summary>
    let ``MYR-MYOR-OIS_Compound`` = _prefix "MYR-MYOR-OIS_Compound"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/MYR-Quarterly_Swap_Rate-11_00-TRADITION"></see>
    /// </summary>
    let ``MYR-Quarterly_Swap_Rate-11_00-TRADITION`` =
        _prefix "MYR-Quarterly_Swap_Rate-11_00-TRADITION"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/MYR-Quarterly_Swap_Rate-TRADITION-Reference_Banks"></see>
    /// </summary>
    let ``MYR-Quarterly_Swap_Rate-TRADITION-Reference_Banks`` =
        _prefix "MYR-Quarterly_Swap_Rate-TRADITION-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NOK-NIBOR"></see>
    /// </summary>
    let ``NOK-NIBOR`` = _prefix "NOK-NIBOR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NOK-NIBOR-NIBR"></see>
    /// </summary>
    let ``NOK-NIBOR-NIBR`` = _prefix "NOK-NIBOR-NIBR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NOK-NIBOR-NIBR-Reference_Banks"></see>
    /// </summary>
    let ``NOK-NIBOR-NIBR-Reference_Banks`` = _prefix "NOK-NIBOR-NIBR-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NOK-NIBOR-Reference_Banks"></see>
    /// </summary>
    let ``NOK-NIBOR-Reference_Banks`` = _prefix "NOK-NIBOR-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NOK-NOWA"></see>
    /// </summary>
    let ``NOK-NOWA`` = _prefix "NOK-NOWA"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NOK-NOWA-OIS_Compound"></see>
    /// </summary>
    let ``NOK-NOWA-OIS_Compound`` = _prefix "NOK-NOWA-OIS_Compound"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NZD-BBR-ISDC"></see>
    /// </summary>
    let ``NZD-BBR-ISDC`` = _prefix "NZD-BBR-ISDC"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NZD-BBR-Reference_Banks"></see>
    /// </summary>
    let ``NZD-BBR-Reference_Banks`` = _prefix "NZD-BBR-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NZD-BBR-Telerate"></see>
    /// </summary>
    let ``NZD-BBR-Telerate`` = _prefix "NZD-BBR-Telerate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NZD-BKBM_Bid"></see>
    /// </summary>
    let ``NZD-BKBM_Bid`` = _prefix "NZD-BKBM_Bid"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NZD-BKBM_FRA"></see>
    /// </summary>
    let ``NZD-BKBM_FRA`` = _prefix "NZD-BKBM_FRA"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NZD-BKBM_FRA_Swap_Rate_ICAP"></see>
    /// </summary>
    let ``NZD-BKBM_FRA_Swap_Rate_ICAP`` = _prefix "NZD-BKBM_FRA_Swap_Rate_ICAP"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NZD-NZIONA"></see>
    /// </summary>
    let ``NZD-NZIONA`` = _prefix "NZD-NZIONA"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NZD-NZIONA-OIS_Compound"></see>
    /// </summary>
    let ``NZD-NZIONA-OIS_Compound`` = _prefix "NZD-NZIONA-OIS_Compound"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NZD-Semi-Annual_Swap_Rate-11_00-BGCANTOR"></see>
    /// </summary>
    let ``NZD-Semi-Annual_Swap_Rate-11_00-BGCANTOR`` =
        _prefix "NZD-Semi-Annual_Swap_Rate-11_00-BGCANTOR"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NZD-Semi-Annual_Swap_Rate-BGCANTOR-Reference_Banks"></see>
    /// </summary>
    let ``NZD-Semi-Annual_Swap_Rate-BGCANTOR-Reference_Banks`` =
        _prefix "NZD-Semi-Annual_Swap_Rate-BGCANTOR-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NZD-Swap_Rate-ICAP-Reference_Banks"></see>
    /// </summary>
    let ``NZD-Swap_Rate-ICAP-Reference_Banks`` =
        _prefix "NZD-Swap_Rate-ICAP-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PHP-ORR"></see>
    /// </summary>
    let ``PHP-ORR`` = _prefix "PHP-ORR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PHP-PHIREF"></see>
    /// </summary>
    let ``PHP-PHIREF`` = _prefix "PHP-PHIREF"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PHP-PHIREF-BAP"></see>
    /// </summary>
    let ``PHP-PHIREF-BAP`` = _prefix "PHP-PHIREF-BAP"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PHP-PHIREF-Reference_Banks"></see>
    /// </summary>
    let ``PHP-PHIREF-Reference_Banks`` = _prefix "PHP-PHIREF-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PHP-Semi-Annual_Swap_Rate-11_00-BGCANTOR"></see>
    /// </summary>
    let ``PHP-Semi-Annual_Swap_Rate-11_00-BGCANTOR`` =
        _prefix "PHP-Semi-Annual_Swap_Rate-11_00-BGCANTOR"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PHP-Semi-Annual_Swap_Rate-Reference_Banks"></see>
    /// </summary>
    let ``PHP-Semi-Annual_Swap_Rate-Reference_Banks`` =
        _prefix "PHP-Semi-Annual_Swap_Rate-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PLN-POLONIA"></see>
    /// </summary>
    let ``PLN-POLONIA`` = _prefix "PLN-POLONIA"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PLN-POLONIA-OIS_Compound"></see>
    /// </summary>
    let ``PLN-POLONIA-OIS_Compound`` = _prefix "PLN-POLONIA-OIS_Compound"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PLN-WIBID"></see>
    /// </summary>
    let ``PLN-WIBID`` = _prefix "PLN-WIBID"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PLN-WIBOR"></see>
    /// </summary>
    let ``PLN-WIBOR`` = _prefix "PLN-WIBOR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PLN-WIBOR-Reference_Banks"></see>
    /// </summary>
    let ``PLN-WIBOR-Reference_Banks`` = _prefix "PLN-WIBOR-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PLN-WIRON"></see>
    /// </summary>
    let ``PLN-WIRON`` = _prefix "PLN-WIRON"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PLN-WIRON-OIS_Compound"></see>
    /// </summary>
    let ``PLN-WIRON-OIS_Compound`` = _prefix "PLN-WIRON-OIS_Compound"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PLZ-WIBOR-Reference_Banks"></see>
    /// </summary>
    let ``PLZ-WIBOR-Reference_Banks`` = _prefix "PLZ-WIBOR-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PLZ-WIBOR-WIBO"></see>
    /// </summary>
    let ``PLZ-WIBOR-WIBO`` = _prefix "PLZ-WIBOR-WIBO"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/REPOFUNDS_RATE-FRANCE-OIS-COMPOUND"></see>
    /// </summary>
    let ``REPOFUNDS_RATE-FRANCE-OIS-COMPOUND`` =
        _prefix "REPOFUNDS_RATE-FRANCE-OIS-COMPOUND"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/REPOFUNDS_RATE-GERMANY-OIS-COMPOUND"></see>
    /// </summary>
    let ``REPOFUNDS_RATE-GERMANY-OIS-COMPOUND`` =
        _prefix "REPOFUNDS_RATE-GERMANY-OIS-COMPOUND"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/REPOFUNDS_RATE-ITALY-OIS-COMPOUND"></see>
    /// </summary>
    let ``REPOFUNDS_RATE-ITALY-OIS-COMPOUND`` =
        _prefix "REPOFUNDS_RATE-ITALY-OIS-COMPOUND"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RON-Annual_Swap_Rate-11_00-BGCANTOR"></see>
    /// </summary>
    let ``RON-Annual_Swap_Rate-11_00-BGCANTOR`` =
        _prefix "RON-Annual_Swap_Rate-11_00-BGCANTOR"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RON-Annual_Swap_Rate-Reference_Banks"></see>
    /// </summary>
    let ``RON-Annual_Swap_Rate-Reference_Banks`` =
        _prefix "RON-Annual_Swap_Rate-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RON-ROBID"></see>
    /// </summary>
    let ``RON-ROBID`` = _prefix "RON-ROBID"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RON-ROBOR"></see>
    /// </summary>
    let ``RON-ROBOR`` = _prefix "RON-ROBOR"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RUB-Annual_Swap_Rate-11_00-BGCANTOR"></see>
    /// </summary>
    let ``RUB-Annual_Swap_Rate-11_00-BGCANTOR`` =
        _prefix "RUB-Annual_Swap_Rate-11_00-BGCANTOR"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RUB-Annual_Swap_Rate-12_45-TRADITION"></see>
    /// </summary>
    let ``RUB-Annual_Swap_Rate-12_45-TRADITION`` =
        _prefix "RUB-Annual_Swap_Rate-12_45-TRADITION"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RUB-Annual_Swap_Rate-4_15-TRADITION"></see>
    /// </summary>
    let ``RUB-Annual_Swap_Rate-4_15-TRADITION`` =
        _prefix "RUB-Annual_Swap_Rate-4_15-TRADITION"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RUB-Annual_Swap_Rate-Reference_Banks"></see>
    /// </summary>
    let ``RUB-Annual_Swap_Rate-Reference_Banks`` =
        _prefix "RUB-Annual_Swap_Rate-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RUB-Annual_Swap_Rate-TRADITION-Reference_Banks"></see>
    /// </summary>
    let ``RUB-Annual_Swap_Rate-TRADITION-Reference_Banks`` =
        _prefix "RUB-Annual_Swap_Rate-TRADITION-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RUB-Key_Rate_CBRF"></see>
    /// </summary>
    let ``RUB-Key_Rate_CBRF`` = _prefix "RUB-Key_Rate_CBRF"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RUB-MOSPRIME-Reference_Banks"></see>
    /// </summary>
    let ``RUB-MOSPRIME-Reference_Banks`` = _prefix "RUB-MOSPRIME-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RUB-MosPrime"></see>
    /// </summary>
    let ``RUB-MosPrime`` = _prefix "RUB-MosPrime"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RUB-RUONIA"></see>
    /// </summary>
    let ``RUB-RUONIA`` = _prefix "RUB-RUONIA"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RUB-RUONIA-OIS_Compound"></see>
    /// </summary>
    let ``RUB-RUONIA-OIS_Compound`` = _prefix "RUB-RUONIA-OIS_Compound"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SAR-SAIBOR"></see>
    /// </summary>
    let ``SAR-SAIBOR`` = _prefix "SAR-SAIBOR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SAR-SRIOR-Reference_Banks"></see>
    /// </summary>
    let ``SAR-SRIOR-Reference_Banks`` = _prefix "SAR-SRIOR-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-Annual_Swap_Rate"></see>
    /// </summary>
    let ``SEK-Annual_Swap_Rate`` = _prefix "SEK-Annual_Swap_Rate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-Annual_Swap_Rate-SESWFI"></see>
    /// </summary>
    let ``SEK-Annual_Swap_Rate-SESWFI`` = _prefix "SEK-Annual_Swap_Rate-SESWFI"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-STIBOR"></see>
    /// </summary>
    let ``SEK-STIBOR`` = _prefix "SEK-STIBOR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-STIBOR-OIS_Compound"></see>
    /// </summary>
    let ``SEK-STIBOR-OIS_Compound`` = _prefix "SEK-STIBOR-OIS_Compound"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-STIBOR-Reference_Banks"></see>
    /// </summary>
    let ``SEK-STIBOR-Reference_Banks`` = _prefix "SEK-STIBOR-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-SWESTR"></see>
    /// </summary>
    let ``SEK-SWESTR`` = _prefix "SEK-SWESTR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-SWESTR-OIS_Compound"></see>
    /// </summary>
    let ``SEK-SWESTR-OIS_Compound`` = _prefix "SEK-SWESTR-OIS_Compound"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-SWESTR_Average_1M"></see>
    /// </summary>
    let ``SEK-SWESTR_Average_1M`` = _prefix "SEK-SWESTR_Average_1M"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-SWESTR_Average_1W"></see>
    /// </summary>
    let ``SEK-SWESTR_Average_1W`` = _prefix "SEK-SWESTR_Average_1W"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-SWESTR_Average_2M"></see>
    /// </summary>
    let ``SEK-SWESTR_Average_2M`` = _prefix "SEK-SWESTR_Average_2M"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-SWESTR_Average_3M"></see>
    /// </summary>
    let ``SEK-SWESTR_Average_3M`` = _prefix "SEK-SWESTR_Average_3M"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-SWESTR_Average_6M"></see>
    /// </summary>
    let ``SEK-SWESTR_Average_6M`` = _prefix "SEK-SWESTR_Average_6M"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-SWESTR_Compounded_Index"></see>
    /// </summary>
    let ``SEK-SWESTR_Compounded_Index`` = _prefix "SEK-SWESTR_Compounded_Index"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-SIBOR"></see>
    /// </summary>
    let ``SGD-SIBOR`` = _prefix "SGD-SIBOR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-SIBOR-Reference_Banks"></see>
    /// </summary>
    let ``SGD-SIBOR-Reference_Banks`` = _prefix "SGD-SIBOR-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-SIBOR-Telerate"></see>
    /// </summary>
    let ``SGD-SIBOR-Telerate`` = _prefix "SGD-SIBOR-Telerate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-SONAR-OIS-COMPOUND"></see>
    /// </summary>
    let ``SGD-SONAR-OIS-COMPOUND`` = _prefix "SGD-SONAR-OIS-COMPOUND"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-SOR"></see>
    /// </summary>
    let ``SGD-SOR`` = _prefix "SGD-SOR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-SOR-Reference_Banks"></see>
    /// </summary>
    let ``SGD-SOR-Reference_Banks`` = _prefix "SGD-SOR-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-SOR-Telerate"></see>
    /// </summary>
    let ``SGD-SOR-Telerate`` = _prefix "SGD-SOR-Telerate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-SOR-VWAP-Reference_Banks"></see>
    /// </summary>
    let ``SGD-SOR-VWAP-Reference_Banks`` = _prefix "SGD-SOR-VWAP-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-SORA"></see>
    /// </summary>
    let ``SGD-SORA`` = _prefix "SGD-SORA"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-SORA-OIS_Compound"></see>
    /// </summary>
    let ``SGD-SORA-OIS_Compound`` = _prefix "SGD-SORA-OIS_Compound"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-Semi-Annual_Currency_Basis_Swap_Rate-11_00-Tullett_Prebon"></see>
    /// </summary>
    let ``SGD-Semi-Annual_Currency_Basis_Swap_Rate-11_00-Tullett_Prebon`` =
        _prefix "SGD-Semi-Annual_Currency_Basis_Swap_Rate-11_00-Tullett_Prebon"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-Semi-Annual_Currency_Basis_Swap_Rate-16_00-Tullett_Prebon"></see>
    /// </summary>
    let ``SGD-Semi-Annual_Currency_Basis_Swap_Rate-16_00-Tullett_Prebon`` =
        _prefix "SGD-Semi-Annual_Currency_Basis_Swap_Rate-16_00-Tullett_Prebon"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-Semi-Annual_Swap_Rate-11.00-TRADITION"></see>
    /// </summary>
    let ``SGD-Semi-Annual_Swap_Rate-11.00-TRADITION`` =
        _prefix "SGD-Semi-Annual_Swap_Rate-11.00-TRADITION"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-Semi-Annual_Swap_Rate-11_00-BGCANTOR"></see>
    /// </summary>
    let ``SGD-Semi-Annual_Swap_Rate-11_00-BGCANTOR`` =
        _prefix "SGD-Semi-Annual_Swap_Rate-11_00-BGCANTOR"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-Semi-Annual_Swap_Rate-11_00-Tullett_Prebon"></see>
    /// </summary>
    let ``SGD-Semi-Annual_Swap_Rate-11_00-Tullett_Prebon`` =
        _prefix "SGD-Semi-Annual_Swap_Rate-11_00-Tullett_Prebon"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-Semi-Annual_Swap_Rate-16_00-Tullett_Prebon"></see>
    /// </summary>
    let ``SGD-Semi-Annual_Swap_Rate-16_00-Tullett_Prebon`` =
        _prefix "SGD-Semi-Annual_Swap_Rate-16_00-Tullett_Prebon"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-Semi-Annual_Swap_Rate-ICAP"></see>
    /// </summary>
    let ``SGD-Semi-Annual_Swap_Rate-ICAP`` = _prefix "SGD-Semi-Annual_Swap_Rate-ICAP"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-Semi-Annual_Swap_Rate-ICAP-Reference_Banks"></see>
    /// </summary>
    let ``SGD-Semi-Annual_Swap_Rate-ICAP-Reference_Banks`` =
        _prefix "SGD-Semi-Annual_Swap_Rate-ICAP-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-Semi-Annual_Swap_Rate-Reference_Banks"></see>
    /// </summary>
    let ``SGD-Semi-Annual_Swap_Rate-Reference_Banks`` =
        _prefix "SGD-Semi-Annual_Swap_Rate-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-Semi-Annual_Swap_Rate-TRADITION-Reference_Banks"></see>
    /// </summary>
    let ``SGD-Semi-Annual_Swap_Rate-TRADITION-Reference_Banks`` =
        _prefix "SGD-Semi-Annual_Swap_Rate-TRADITION-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SKK-BRIBOR-BRBO"></see>
    /// </summary>
    let ``SKK-BRIBOR-BRBO`` = _prefix "SKK-BRIBOR-BRBO"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SKK-BRIBOR-Bloomberg"></see>
    /// </summary>
    let ``SKK-BRIBOR-Bloomberg`` = _prefix "SKK-BRIBOR-Bloomberg"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SKK-BRIBOR-NBSK07"></see>
    /// </summary>
    let ``SKK-BRIBOR-NBSK07`` = _prefix "SKK-BRIBOR-NBSK07"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SKK-BRIBOR-Reference_Banks"></see>
    /// </summary>
    let ``SKK-BRIBOR-Reference_Banks`` = _prefix "SKK-BRIBOR-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/THB-SOR-Reference_Banks"></see>
    /// </summary>
    let ``THB-SOR-Reference_Banks`` = _prefix "THB-SOR-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/THB-SOR-Reuters"></see>
    /// </summary>
    let ``THB-SOR-Reuters`` = _prefix "THB-SOR-Reuters"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/THB-SOR-Telerate"></see>
    /// </summary>
    let ``THB-SOR-Telerate`` = _prefix "THB-SOR-Telerate"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/THB-Semi-Annual_Swap_Rate-11_00-BGCANTOR"></see>
    /// </summary>
    let ``THB-Semi-Annual_Swap_Rate-11_00-BGCANTOR`` =
        _prefix "THB-Semi-Annual_Swap_Rate-11_00-BGCANTOR"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/THB-Semi-Annual_Swap_Rate-Reference_Banks"></see>
    /// </summary>
    let ``THB-Semi-Annual_Swap_Rate-Reference_Banks`` =
        _prefix "THB-Semi-Annual_Swap_Rate-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/THB-THBFIX"></see>
    /// </summary>
    let ``THB-THBFIX`` = _prefix "THB-THBFIX"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/THB-THBFIX-Reference_Banks"></see>
    /// </summary>
    let ``THB-THBFIX-Reference_Banks`` = _prefix "THB-THBFIX-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/THB-THOR"></see>
    /// </summary>
    let ``THB-THOR`` = _prefix "THB-THOR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/THB-THOR-OIS_Compound"></see>
    /// </summary>
    let ``THB-THOR-OIS_Compound`` = _prefix "THB-THOR-OIS_Compound"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TRY-Annual_Swap_Rate-11_15-BGCANTOR"></see>
    /// </summary>
    let ``TRY-Annual_Swap_Rate-11_15-BGCANTOR`` =
        _prefix "TRY-Annual_Swap_Rate-11_15-BGCANTOR"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TRY-Annual_Swap_Rate-Reference_Banks"></see>
    /// </summary>
    let ``TRY-Annual_Swap_Rate-Reference_Banks`` =
        _prefix "TRY-Annual_Swap_Rate-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TRY-Semi-Annual_Swap_Rate-TRADITION-Reference_Banks"></see>
    /// </summary>
    let ``TRY-Semi-Annual_Swap_Rate-TRADITION-Reference_Banks`` =
        _prefix "TRY-Semi-Annual_Swap_Rate-TRADITION-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TRY-TLREF"></see>
    /// </summary>
    let ``TRY-TLREF`` = _prefix "TRY-TLREF"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TRY-TLREF-OIS_Compound"></see>
    /// </summary>
    let ``TRY-TLREF-OIS_Compound`` = _prefix "TRY-TLREF-OIS_Compound"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TRY-TRLIBOR"></see>
    /// </summary>
    let ``TRY-TRLIBOR`` = _prefix "TRY-TRLIBOR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TRY-TRYIBOR-Reference_Banks"></see>
    /// </summary>
    let ``TRY-TRYIBOR-Reference_Banks`` = _prefix "TRY-TRYIBOR-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TRY_Annual_Swap_Rate-11_00-TRADITION"></see>
    /// </summary>
    let ``TRY_Annual_Swap_Rate-11_00-TRADITION`` =
        _prefix "TRY_Annual_Swap_Rate-11_00-TRADITION"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TWD-Quarterly-Annual_Swap_Rate-11_00-BGCANTOR"></see>
    /// </summary>
    let ``TWD-Quarterly-Annual_Swap_Rate-11_00-BGCANTOR`` =
        _prefix "TWD-Quarterly-Annual_Swap_Rate-11_00-BGCANTOR"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TWD-Quarterly-Annual_Swap_Rate-Reference_Banks"></see>
    /// </summary>
    let ``TWD-Quarterly-Annual_Swap_Rate-Reference_Banks`` =
        _prefix "TWD-Quarterly-Annual_Swap_Rate-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TWD-Reference_Dealers"></see>
    /// </summary>
    let ``TWD-Reference_Dealers`` = _prefix "TWD-Reference_Dealers"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TWD-Reuters-6165"></see>
    /// </summary>
    let ``TWD-Reuters-6165`` = _prefix "TWD-Reuters-6165"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TWD-TAIBIR01"></see>
    /// </summary>
    let ``TWD-TAIBIR01`` = _prefix "TWD-TAIBIR01"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TWD-TAIBIR02"></see>
    /// </summary>
    let ``TWD-TAIBIR02`` = _prefix "TWD-TAIBIR02"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TWD-TAIBOR"></see>
    /// </summary>
    let ``TWD-TAIBOR`` = _prefix "TWD-TAIBOR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TWD-TWCPBA"></see>
    /// </summary>
    let ``TWD-TWCPBA`` = _prefix "TWD-TWCPBA"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TWD-Telerate-6165"></see>
    /// </summary>
    let ``TWD-Telerate-6165`` = _prefix "TWD-Telerate-6165"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-3M_LIBOR_SWAP-CME_vs_LCH-ICAP"></see>
    /// </summary>
    let ``USD-3M_LIBOR_SWAP-CME_vs_LCH-ICAP`` =
        _prefix "USD-3M_LIBOR_SWAP-CME_vs_LCH-ICAP"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-3M_LIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg"></see>
    /// </summary>
    let ``USD-3M_LIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg`` =
        _prefix "USD-3M_LIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-6M_LIBOR_SWAP-CME_vs_LCH-ICAP"></see>
    /// </summary>
    let ``USD-6M_LIBOR_SWAP-CME_vs_LCH-ICAP`` =
        _prefix "USD-6M_LIBOR_SWAP-CME_vs_LCH-ICAP"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-6M_LIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg"></see>
    /// </summary>
    let ``USD-6M_LIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg`` =
        _prefix "USD-6M_LIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-AMERIBOR"></see>
    /// </summary>
    let ``USD-AMERIBOR`` = _prefix "USD-AMERIBOR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-AMERIBOR_Average_30D"></see>
    /// </summary>
    let ``USD-AMERIBOR_Average_30D`` = _prefix "USD-AMERIBOR_Average_30D"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-AMERIBOR_Average_90D"></see>
    /// </summary>
    let ``USD-AMERIBOR_Average_90D`` = _prefix "USD-AMERIBOR_Average_90D"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-AMERIBOR_Term"></see>
    /// </summary>
    let ``USD-AMERIBOR_Term`` = _prefix "USD-AMERIBOR_Term"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-AMERIBOR_Term_Structure"></see>
    /// </summary>
    let ``USD-AMERIBOR_Term_Structure`` = _prefix "USD-AMERIBOR_Term_Structure"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-AXI_Term"></see>
    /// </summary>
    let ``USD-AXI_Term`` = _prefix "USD-AXI_Term"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Annual_Swap_Rate-11_00-BGCANTOR"></see>
    /// </summary>
    let ``USD-Annual_Swap_Rate-11_00-BGCANTOR`` =
        _prefix "USD-Annual_Swap_Rate-11_00-BGCANTOR"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Annual_Swap_Rate-11_00-TRADITION"></see>
    /// </summary>
    let ``USD-Annual_Swap_Rate-11_00-TRADITION`` =
        _prefix "USD-Annual_Swap_Rate-11_00-TRADITION"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Annual_Swap_Rate-4_00-TRADITION"></see>
    /// </summary>
    let ``USD-Annual_Swap_Rate-4_00-TRADITION`` =
        _prefix "USD-Annual_Swap_Rate-4_00-TRADITION"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-BA-H.15"></see>
    /// </summary>
    let ``USD-BA-H.15`` = _prefix "USD-BA-H.15"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-BA-Reference_Dealers"></see>
    /// </summary>
    let ``USD-BA-Reference_Dealers`` = _prefix "USD-BA-Reference_Dealers"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-BMA_Municipal_Swap_Index"></see>
    /// </summary>
    let ``USD-BMA_Municipal_Swap_Index`` = _prefix "USD-BMA_Municipal_Swap_Index"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-BSBY"></see>
    /// </summary>
    let ``USD-BSBY`` = _prefix "USD-BSBY"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-CD-H.15"></see>
    /// </summary>
    let ``USD-CD-H.15`` = _prefix "USD-CD-H.15"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-CD-Reference_Dealers"></see>
    /// </summary>
    let ``USD-CD-Reference_Dealers`` = _prefix "USD-CD-Reference_Dealers"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-CMS-Reference_Banks"></see>
    /// </summary>
    let ``USD-CMS-Reference_Banks`` = _prefix "USD-CMS-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-CMS-Reference_Banks-ICAP_SwapPX"></see>
    /// </summary>
    let ``USD-CMS-Reference_Banks-ICAP_SwapPX`` =
        _prefix "USD-CMS-Reference_Banks-ICAP_SwapPX"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-CMS-Reuters"></see>
    /// </summary>
    let ``USD-CMS-Reuters`` = _prefix "USD-CMS-Reuters"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-CMS-Telerate"></see>
    /// </summary>
    let ``USD-CMS-Telerate`` = _prefix "USD-CMS-Telerate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-CMT"></see>
    /// </summary>
    let ``USD-CMT`` = _prefix "USD-CMT"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-CMT_Average_1W"></see>
    /// </summary>
    let ``USD-CMT_Average_1W`` = _prefix "USD-CMT_Average_1W"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-COF11-Telerate"></see>
    /// </summary>
    let ``USD-COF11-Telerate`` = _prefix "USD-COF11-Telerate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-COFI"></see>
    /// </summary>
    let ``USD-COFI`` = _prefix "USD-COFI"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-CP-Money_Market_Yield"></see>
    /// </summary>
    let ``USD-CP-Money_Market_Yield`` = _prefix "USD-CP-Money_Market_Yield"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-CP-Reference_Dealers"></see>
    /// </summary>
    let ``USD-CP-Reference_Dealers`` = _prefix "USD-CP-Reference_Dealers"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-CRITR"></see>
    /// </summary>
    let ``USD-CRITR`` = _prefix "USD-CRITR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-FFCB-DISCO"></see>
    /// </summary>
    let ``USD-FFCB-DISCO`` = _prefix "USD-FFCB-DISCO"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-FXI_Term"></see>
    /// </summary>
    let ``USD-FXI_Term`` = _prefix "USD-FXI_Term"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Federal_Funds"></see>
    /// </summary>
    let ``USD-Federal_Funds`` = _prefix "USD-Federal_Funds"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Federal_Funds-OIS_Compound"></see>
    /// </summary>
    let ``USD-Federal_Funds-OIS_Compound`` = _prefix "USD-Federal_Funds-OIS_Compound"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Federal_Funds-Reference_Dealers"></see>
    /// </summary>
    let ``USD-Federal_Funds-Reference_Dealers`` =
        _prefix "USD-Federal_Funds-Reference_Dealers"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-LIBOR"></see>
    /// </summary>
    let ``USD-LIBOR`` = _prefix "USD-LIBOR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-LIBOR-ISDA"></see>
    /// </summary>
    let ``USD-LIBOR-ISDA`` = _prefix "USD-LIBOR-ISDA"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-LIBOR-LIBO"></see>
    /// </summary>
    let ``USD-LIBOR-LIBO`` = _prefix "USD-LIBOR-LIBO"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-LIBOR-Reference_Banks"></see>
    /// </summary>
    let ``USD-LIBOR-Reference_Banks`` = _prefix "USD-LIBOR-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-LIBOR_ICE_Swap_Rate-11_00"></see>
    /// </summary>
    let ``USD-LIBOR_ICE_Swap_Rate-11_00`` = _prefix "USD-LIBOR_ICE_Swap_Rate-11_00"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-LIBOR_ICE_Swap_Rate-15_00"></see>
    /// </summary>
    let ``USD-LIBOR_ICE_Swap_Rate-15_00`` = _prefix "USD-LIBOR_ICE_Swap_Rate-15_00"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Municipal_Swap_Index"></see>
    /// </summary>
    let ``USD-Municipal_Swap_Index`` = _prefix "USD-Municipal_Swap_Index"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Municipal_Swap_Libor_Ratio-11_00-ICAP"></see>
    /// </summary>
    let ``USD-Municipal_Swap_Libor_Ratio-11_00-ICAP`` =
        _prefix "USD-Municipal_Swap_Libor_Ratio-11_00-ICAP"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Municipal_Swap_Rate-11_00-ICAP"></see>
    /// </summary>
    let ``USD-Municipal_Swap_Rate-11_00-ICAP`` =
        _prefix "USD-Municipal_Swap_Rate-11_00-ICAP"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-OIS-11_00-BGCANTOR"></see>
    /// </summary>
    let ``USD-OIS-11_00-BGCANTOR`` = _prefix "USD-OIS-11_00-BGCANTOR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-OIS-11_00-LON-ICAP"></see>
    /// </summary>
    let ``USD-OIS-11_00-LON-ICAP`` = _prefix "USD-OIS-11_00-LON-ICAP"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-OIS-11_00-NY-ICAP"></see>
    /// </summary>
    let ``USD-OIS-11_00-NY-ICAP`` = _prefix "USD-OIS-11_00-NY-ICAP"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-OIS-11_00-TRADITION"></see>
    /// </summary>
    let ``USD-OIS-11_00-TRADITION`` = _prefix "USD-OIS-11_00-TRADITION"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-OIS-3_00-BGCANTOR"></see>
    /// </summary>
    let ``USD-OIS-3_00-BGCANTOR`` = _prefix "USD-OIS-3_00-BGCANTOR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-OIS-3_00-NY-ICAP"></see>
    /// </summary>
    let ``USD-OIS-3_00-NY-ICAP`` = _prefix "USD-OIS-3_00-NY-ICAP"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-OIS-4_00-TRADITION"></see>
    /// </summary>
    let ``USD-OIS-4_00-TRADITION`` = _prefix "USD-OIS-4_00-TRADITION"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Overnight_Bank_Funding_Rate"></see>
    /// </summary>
    let ``USD-Overnight_Bank_Funding_Rate`` = _prefix "USD-Overnight_Bank_Funding_Rate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Prime"></see>
    /// </summary>
    let ``USD-Prime`` = _prefix "USD-Prime"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Prime-Reference_Banks"></see>
    /// </summary>
    let ``USD-Prime-Reference_Banks`` = _prefix "USD-Prime-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SIBOR-Reference_Banks"></see>
    /// </summary>
    let ``USD-SIBOR-Reference_Banks`` = _prefix "USD-SIBOR-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SIBOR-SIBO"></see>
    /// </summary>
    let ``USD-SIBOR-SIBO`` = _prefix "USD-SIBOR-SIBO"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR"></see>
    /// </summary>
    let ``USD-SOFR`` = _prefix "USD-SOFR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR-OIS_Compound"></see>
    /// </summary>
    let ``USD-SOFR-OIS_Compound`` = _prefix "USD-SOFR-OIS_Compound"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_Average_180D"></see>
    /// </summary>
    let ``USD-SOFR_Average_180D`` = _prefix "USD-SOFR_Average_180D"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_Average_30D"></see>
    /// </summary>
    let ``USD-SOFR_Average_30D`` = _prefix "USD-SOFR_Average_30D"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_Average_90D"></see>
    /// </summary>
    let ``USD-SOFR_Average_90D`` = _prefix "USD-SOFR_Average_90D"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_CME_Term"></see>
    /// </summary>
    let ``USD-SOFR_CME_Term`` = _prefix "USD-SOFR_CME_Term"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_Compounded_Index"></see>
    /// </summary>
    let ``USD-SOFR_Compounded_Index`` = _prefix "USD-SOFR_Compounded_Index"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_ICE_Compounded_Index"></see>
    /// </summary>
    let ``USD-SOFR_ICE_Compounded_Index`` = _prefix "USD-SOFR_ICE_Compounded_Index"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_ICE_Compounded_Index_0_Floor"></see>
    /// </summary>
    let ``USD-SOFR_ICE_Compounded_Index_0_Floor`` =
        _prefix "USD-SOFR_ICE_Compounded_Index_0_Floor"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_ICE_Compounded_Index_0_Floor_2D_Lag"></see>
    /// </summary>
    let ``USD-SOFR_ICE_Compounded_Index_0_Floor_2D_Lag`` =
        _prefix "USD-SOFR_ICE_Compounded_Index_0_Floor_2D_Lag"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_ICE_Compounded_Index_0_Floor_5D_Lag"></see>
    /// </summary>
    let ``USD-SOFR_ICE_Compounded_Index_0_Floor_5D_Lag`` =
        _prefix "USD-SOFR_ICE_Compounded_Index_0_Floor_5D_Lag"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_ICE_Compounded_Index_2D_Lag"></see>
    /// </summary>
    let ``USD-SOFR_ICE_Compounded_Index_2D_Lag`` =
        _prefix "USD-SOFR_ICE_Compounded_Index_2D_Lag"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_ICE_Compounded_Index_5D_Lag"></see>
    /// </summary>
    let ``USD-SOFR_ICE_Compounded_Index_5D_Lag`` =
        _prefix "USD-SOFR_ICE_Compounded_Index_5D_Lag"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_ICE_Swap_Rate"></see>
    /// </summary>
    let ``USD-SOFR_ICE_Swap_Rate`` = _prefix "USD-SOFR_ICE_Swap_Rate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_ICE_Swap_Rate_Spreads"></see>
    /// </summary>
    let ``USD-SOFR_ICE_Swap_Rate_Spreads`` = _prefix "USD-SOFR_ICE_Swap_Rate_Spreads"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_ICE_Term"></see>
    /// </summary>
    let ``USD-SOFR_ICE_Term`` = _prefix "USD-SOFR_ICE_Term"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SandP_Index_High_Grade"></see>
    /// </summary>
    let ``USD-SandP_Index_High_Grade`` = _prefix "USD-SandP_Index_High_Grade"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-TBILL-H.15"></see>
    /// </summary>
    let ``USD-TBILL-H.15`` = _prefix "USD-TBILL-H.15"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-TBILL-H.15-Bloomberg"></see>
    /// </summary>
    let ``USD-TBILL-H.15-Bloomberg`` = _prefix "USD-TBILL-H.15-Bloomberg"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-TBILL_Auction_High_Rate"></see>
    /// </summary>
    let ``USD-TBILL_Auction_High_Rate`` = _prefix "USD-TBILL_Auction_High_Rate"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-TBILL_Secondary_Market-Bond_Equivalent_Yield"></see>
    /// </summary>
    let ``USD-TBILL_Secondary_Market-Bond_Equivalent_Yield`` =
        _prefix "USD-TBILL_Secondary_Market-Bond_Equivalent_Yield"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-TIBOR-ISDC"></see>
    /// </summary>
    let ``USD-TIBOR-ISDC`` = _prefix "USD-TIBOR-ISDC"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-TIBOR-Reference_Banks"></see>
    /// </summary>
    let ``USD-TIBOR-Reference_Banks`` = _prefix "USD-TIBOR-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Treasury-19901-3_00-ICAP"></see>
    /// </summary>
    let ``USD-Treasury-19901-3_00-ICAP`` = _prefix "USD-Treasury-19901-3_00-ICAP"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Treasury_Rate-ICAP_BrokerTec"></see>
    /// </summary>
    let ``USD-Treasury_Rate-ICAP_BrokerTec`` =
        _prefix "USD-Treasury_Rate-ICAP_BrokerTec"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Treasury_Rate-SwapMarker100"></see>
    /// </summary>
    let ``USD-Treasury_Rate-SwapMarker100`` = _prefix "USD-Treasury_Rate-SwapMarker100"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Treasury_Rate-SwapMarker99"></see>
    /// </summary>
    let ``USD-Treasury_Rate-SwapMarker99`` = _prefix "USD-Treasury_Rate-SwapMarker99"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Treasury_Rate-T19901"></see>
    /// </summary>
    let ``USD-Treasury_Rate-T19901`` = _prefix "USD-Treasury_Rate-T19901"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Treasury_Rate-T500"></see>
    /// </summary>
    let ``USD-Treasury_Rate-T500`` = _prefix "USD-Treasury_Rate-T500"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD_Swap_Rate-BCMP1"></see>
    /// </summary>
    let ``USD_Swap_Rate-BCMP1`` = _prefix "USD_Swap_Rate-BCMP1"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD_Treasury_Rate-BCMP1"></see>
    /// </summary>
    let ``USD_Treasury_Rate-BCMP1`` = _prefix "USD_Treasury_Rate-BCMP1"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/VND-Semi-Annual_Swap_Rate-11_00-BGCANTOR"></see>
    /// </summary>
    let ``VND-Semi-Annual_Swap_Rate-11_00-BGCANTOR`` =
        _prefix "VND-Semi-Annual_Swap_Rate-11_00-BGCANTOR"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/VND-Semi-Annual_Swap_Rate-Reference_Banks"></see>
    /// </summary>
    let ``VND-Semi-Annual_Swap_Rate-Reference_Banks`` =
        _prefix "VND-Semi-Annual_Swap_Rate-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ZAR-DEPOSIT-Reference_Banks"></see>
    /// </summary>
    let ``ZAR-DEPOSIT-Reference_Banks`` = _prefix "ZAR-DEPOSIT-Reference_Banks"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ZAR-DEPOSIT-SAFEX"></see>
    /// </summary>
    let ``ZAR-DEPOSIT-SAFEX`` = _prefix "ZAR-DEPOSIT-SAFEX"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ZAR-JIBAR"></see>
    /// </summary>
    let ``ZAR-JIBAR`` = _prefix "ZAR-JIBAR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ZAR-JIBAR-Reference_Banks"></see>
    /// </summary>
    let ``ZAR-JIBAR-Reference_Banks`` = _prefix "ZAR-JIBAR-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ZAR-PRIME-AVERAGE-Reference_Banks"></see>
    /// </summary>
    let ``ZAR-PRIME-AVERAGE-Reference_Banks`` =
        _prefix "ZAR-PRIME-AVERAGE-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ZAR-Prime_Average"></see>
    /// </summary>
    let ``ZAR-Prime_Average`` = _prefix "ZAR-Prime_Average"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ZAR-Quarterly_Swap_Rate-1_00-TRADITION"></see>
    /// </summary>
    let ``ZAR-Quarterly_Swap_Rate-1_00-TRADITION`` =
        _prefix "ZAR-Quarterly_Swap_Rate-1_00-TRADITION"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ZAR-Quarterly_Swap_Rate-5_30-TRADITION"></see>
    /// </summary>
    let ``ZAR-Quarterly_Swap_Rate-5_30-TRADITION`` =
        _prefix "ZAR-Quarterly_Swap_Rate-5_30-TRADITION"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ZAR-Quarterly_Swap_Rate-TRADITION-Reference_Banks"></see>
    /// </summary>
    let ``ZAR-Quarterly_Swap_Rate-TRADITION-Reference_Banks`` =
        _prefix "ZAR-Quarterly_Swap_Rate-TRADITION-Reference_Banks"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ZAR-ZARONIA"></see>
    /// </summary>
    let ``ZAR-ZARONIA`` = _prefix "ZAR-ZARONIA"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ZAR-ZARONIA-OIS_Compound"></see>
    /// </summary>
    let ``ZAR-ZARONIA-OIS_Compound`` = _prefix "ZAR-ZARONIA-OIS_Compound"

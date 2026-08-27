namespace https.spec.edmcouncil.org.fibo.ontology.IND.InterestRates.CommonInterestRates.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_ind_ir_cm =
    let _namespace_iri = Namespace_Iri fibo_ind_ir_cm |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-ind-ir-cm:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Common Interest Rates Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_ind_ir_cm, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-cm:AED-EIBOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"AED-EIBOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AED-EIBOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AED-EIBOR</seealso>
    let AED_EIBOR = Prefixed_Name(fibo_ind_ir_cm, "AED-EIBOR") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-cm:AUD-AONIA</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"AUD-AONIA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-AONIA">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-AONIA</seealso>
    let AUD_AONIA = Prefixed_Name(fibo_ind_ir_cm, "AUD-AONIA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:AUD-AONIA-OIS_Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"AUD-AONIA-OIS Compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-AONIA-OIS_Compound">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-AONIA-OIS_Compound</seealso>
    let AUD_AONIA_OIS_Compound =
        Prefixed_Name(fibo_ind_ir_cm, "AUD-AONIA-OIS_Compound") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:AUD-BBR-ISDC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"AUD-BBR-ISDC"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-BBR-ISDC">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-BBR-ISDC</seealso>
    let AUD_BBR_ISDC = Prefixed_Name(fibo_ind_ir_cm, "AUD-BBR-ISDC") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-cm:AUD-BBSW</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"AUD-BBSW"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-BBSW">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-BBSW</seealso>
    let AUD_BBSW = Prefixed_Name(fibo_ind_ir_cm, "AUD-BBSW") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:AUD-BBSW_Quarterly_Swap_Rate_ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"AUD-BBSW Quarterly Swap Rate ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-BBSW_Quarterly_Swap_Rate_ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-BBSW_Quarterly_Swap_Rate_ICAP</seealso>
    let AUD_BBSW_Quarterly_Swap_Rate_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "AUD-BBSW_Quarterly_Swap_Rate_ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:AUD-BBSW_Semi_Annual_Swap_Rate_ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"AUD-BBSW Semi Annual Swap Rate ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-BBSW_Semi_Annual_Swap_Rate_ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-BBSW_Semi_Annual_Swap_Rate_ICAP</seealso>
    let AUD_BBSW_Semi_Annual_Swap_Rate_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "AUD-BBSW_Semi_Annual_Swap_Rate_ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:AUD-BBSY_Bid</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"AUD-BBSY Bid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-BBSY_Bid">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-BBSY_Bid</seealso>
    let AUD_BBSY_Bid = Prefixed_Name(fibo_ind_ir_cm, "AUD-BBSY_Bid") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-cm:AUD-LIBOR-BBA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"AUD-LIBOR-BBA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-LIBOR-BBA">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-LIBOR-BBA</seealso>
    let AUD_LIBOR_BBA = Prefixed_Name(fibo_ind_ir_cm, "AUD-LIBOR-BBA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:AUD-LIBOR-BBA-Bloomberg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"AUD-LIBOR-BBA-Bloomberg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-LIBOR-BBA-Bloomberg">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-LIBOR-BBA-Bloomberg</seealso>
    let AUD_LIBOR_BBA_Bloomberg =
        Prefixed_Name(fibo_ind_ir_cm, "AUD-LIBOR-BBA-Bloomberg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:AUD-LIBOR-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"AUD-LIBOR-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-LIBOR-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-LIBOR-Reference_Banks</seealso>
    let AUD_LIBOR_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "AUD-LIBOR-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:AUD-Quarterly_Swap_Rate-ICAP-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"AUD-Quarterly Swap Rate-ICAP-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-Quarterly_Swap_Rate-ICAP-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-Quarterly_Swap_Rate-ICAP-Reference_Banks</seealso>
    let AUD_Quarterly_Swap_Rate_ICAP_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "AUD-Quarterly_Swap_Rate-ICAP-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:AUD-Semi-Annual_Swap_Rate-11_00-BGCANTOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"AUD-Semi-Annual Swap Rate-11:00-BGCANTOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-Semi-Annual_Swap_Rate-11_00-BGCANTOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-Semi-Annual_Swap_Rate-11_00-BGCANTOR</seealso>
    let AUD_Semi_Annual_Swap_Rate_11_00_BGCANTOR =
        Prefixed_Name(fibo_ind_ir_cm, "AUD-Semi-Annual_Swap_Rate-11_00-BGCANTOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:AUD-Semi-Annual_Swap_Rate-BGCANTOR-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"AUD-Semi-Annual Swap Rate-BGCANTOR-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-Semi-Annual_Swap_Rate-BGCANTOR-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-Semi-Annual_Swap_Rate-BGCANTOR-Reference_Banks</seealso>
    let AUD_Semi_Annual_Swap_Rate_BGCANTOR_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "AUD-Semi-Annual_Swap_Rate-BGCANTOR-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:AUD-Semi-Annual_Swap_Rate-ICAP-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"AUD-Semi-Annual Swap Rate-ICAP-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-Semi-Annual_Swap_Rate-ICAP-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-Semi-Annual_Swap_Rate-ICAP-Reference_Banks</seealso>
    let AUD_Semi_Annual_Swap_Rate_ICAP_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "AUD-Semi-Annual_Swap_Rate-ICAP-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:AUD-Swap_Rate-Reuters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"AUD-Swap Rate-Reuters"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-Swap_Rate-Reuters">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/AUD-Swap_Rate-Reuters</seealso>
    let AUD_Swap_Rate_Reuters =
        Prefixed_Name(fibo_ind_ir_cm, "AUD-Swap_Rate-Reuters") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:BRL-CDI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"BRL-CDI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/BRL-CDI">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/BRL-CDI</seealso>
    let BRL_CDI = Prefixed_Name(fibo_ind_ir_cm, "BRL-CDI") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-cm:CAD-BA-ISDD</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"CAD-BA-ISDD"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-BA-ISDD">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-BA-ISDD</seealso>
    let CAD_BA_ISDD = Prefixed_Name(fibo_ind_ir_cm, "CAD-BA-ISDD") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CAD-BA-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"CAD-BA-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-BA-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-BA-Reference_Banks</seealso>
    let CAD_BA_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "CAD-BA-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CAD-BA-Telerate</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CAD-BA-Telerate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-BA-Telerate">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-BA-Telerate</seealso>
    let CAD_BA_Telerate =
        Prefixed_Name(fibo_ind_ir_cm, "CAD-BA-Telerate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CAD-CDOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CAD-CDOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-CDOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-CDOR</seealso>
    let CAD_CDOR = Prefixed_Name(fibo_ind_ir_cm, "CAD-CDOR") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-cm:CAD-CORRA</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CAD-CORRA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-CORRA">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-CORRA</seealso>
    let CAD_CORRA = Prefixed_Name(fibo_ind_ir_cm, "CAD-CORRA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CAD-CORRA-OIS_Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"CAD-CORRA-OIS Compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-CORRA-OIS_Compound">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-CORRA-OIS_Compound</seealso>
    let CAD_CORRA_OIS_Compound =
        Prefixed_Name(fibo_ind_ir_cm, "CAD-CORRA-OIS_Compound") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CAD-CORRA_CanDeal_TMX_Term</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"CAD-CORRA CanDeal TMX Term"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-CORRA_CanDeal_TMX_Term">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-CORRA_CanDeal_TMX_Term</seealso>
    let CAD_CORRA_CanDeal_TMX_Term =
        Prefixed_Name(fibo_ind_ir_cm, "CAD-CORRA_CanDeal_TMX_Term") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CAD-CORRA_Compounded_Index</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"CAD-CORRA Compounded Index"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-CORRA_Compounded_Index">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-CORRA_Compounded_Index</seealso>
    let CAD_CORRA_Compounded_Index =
        Prefixed_Name(fibo_ind_ir_cm, "CAD-CORRA_Compounded_Index") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CAD-ISDA-Swap_Rate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"CAD-ISDA-Swap Rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-ISDA-Swap_Rate">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-ISDA-Swap_Rate</seealso>
    let CAD_ISDA_Swap_Rate =
        Prefixed_Name(fibo_ind_ir_cm, "CAD-ISDA-Swap_Rate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CAD-LIBOR-BBA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"CAD-LIBOR-BBA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-LIBOR-BBA">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-LIBOR-BBA</seealso>
    let CAD_LIBOR_BBA = Prefixed_Name(fibo_ind_ir_cm, "CAD-LIBOR-BBA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CAD-LIBOR-BBA-Bloomberg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"CAD-LIBOR-BBA-Bloomberg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-LIBOR-BBA-Bloomberg">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-LIBOR-BBA-Bloomberg</seealso>
    let CAD_LIBOR_BBA_Bloomberg =
        Prefixed_Name(fibo_ind_ir_cm, "CAD-LIBOR-BBA-Bloomberg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CAD-LIBOR-BBA-SwapMarker</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CAD-LIBOR-BBA-SwapMarker"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-LIBOR-BBA-SwapMarker">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-LIBOR-BBA-SwapMarker</seealso>
    let CAD_LIBOR_BBA_SwapMarker =
        Prefixed_Name(fibo_ind_ir_cm, "CAD-LIBOR-BBA-SwapMarker") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CAD-LIBOR-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"CAD-LIBOR-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-LIBOR-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-LIBOR-Reference_Banks</seealso>
    let CAD_LIBOR_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "CAD-LIBOR-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CAD-REPO-CORRA</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CAD-REPO-CORRA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-REPO-CORRA">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-REPO-CORRA</seealso>
    let CAD_REPO_CORRA = Prefixed_Name(fibo_ind_ir_cm, "CAD-REPO-CORRA") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-cm:CAD-TBILL-ISDD</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CAD-TBILL-ISDD"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-TBILL-ISDD">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-TBILL-ISDD</seealso>
    let CAD_TBILL_ISDD = Prefixed_Name(fibo_ind_ir_cm, "CAD-TBILL-ISDD") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CAD-TBILL-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"CAD-TBILL-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-TBILL-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-TBILL-Reference_Banks</seealso>
    let CAD_TBILL_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "CAD-TBILL-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CAD-TBILL-Reuters</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CAD-TBILL-Reuters"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-TBILL-Reuters">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-TBILL-Reuters</seealso>
    let CAD_TBILL_Reuters =
        Prefixed_Name(fibo_ind_ir_cm, "CAD-TBILL-Reuters") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CAD-TBILL-Telerate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"CAD-TBILL-Telerate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-TBILL-Telerate">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CAD-TBILL-Telerate</seealso>
    let CAD_TBILL_Telerate =
        Prefixed_Name(fibo_ind_ir_cm, "CAD-TBILL-Telerate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CHF-3M_LIBOR_SWAP-CME_vs_LCH-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CHF-3M LIBOR SWAP-CME vs LCH-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-3M_LIBOR_SWAP-CME_vs_LCH-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-3M_LIBOR_SWAP-CME_vs_LCH-ICAP</seealso>
    let CHF_3M_LIBOR_SWAP_CME_vs_LCH_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "CHF-3M_LIBOR_SWAP-CME_vs_LCH-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CHF-3M_LIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CHF-3M LIBOR SWAP-CME vs LCH-ICAP-Bloomberg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-3M_LIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-3M_LIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg</seealso>
    let CHF_3M_LIBOR_SWAP_CME_vs_LCH_ICAP_Bloomberg =
        Prefixed_Name(fibo_ind_ir_cm, "CHF-3M_LIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CHF-3M_LIBOR_SWAP-EUREX_vs_LCH-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"CHF-3M LIBOR SWAP-EUREX vs LCH-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-3M_LIBOR_SWAP-EUREX_vs_LCH-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-3M_LIBOR_SWAP-EUREX_vs_LCH-ICAP</seealso>
    let CHF_3M_LIBOR_SWAP_EUREX_vs_LCH_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "CHF-3M_LIBOR_SWAP-EUREX_vs_LCH-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CHF-3M_LIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CHF-3M LIBOR SWAP-EUREX vs LCH-ICAP-Bloomberg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-3M_LIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-3M_LIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg</seealso>
    let CHF_3M_LIBOR_SWAP_EUREX_vs_LCH_ICAP_Bloomberg =
        Prefixed_Name(fibo_ind_ir_cm, "CHF-3M_LIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CHF-6M_LIBORSWAP-CME_vs_LCH-ICAP-Bloomberg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"CHF-6M LIBORSWAP-CME vs LCH-ICAP-Bloomberg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-6M_LIBORSWAP-CME_vs_LCH-ICAP-Bloomberg">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-6M_LIBORSWAP-CME_vs_LCH-ICAP-Bloomberg</seealso>
    let CHF_6M_LIBORSWAP_CME_vs_LCH_ICAP_Bloomberg =
        Prefixed_Name(fibo_ind_ir_cm, "CHF-6M_LIBORSWAP-CME_vs_LCH-ICAP-Bloomberg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CHF-6M_LIBOR_SWAP-CME_vs_LCH-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"CHF-6M LIBOR SWAP-CME vs LCH-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-6M_LIBOR_SWAP-CME_vs_LCH-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-6M_LIBOR_SWAP-CME_vs_LCH-ICAP</seealso>
    let CHF_6M_LIBOR_SWAP_CME_vs_LCH_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "CHF-6M_LIBOR_SWAP-CME_vs_LCH-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CHF-6M_LIBOR_SWAP-EUREX_vs_LCH-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"CHF-6M LIBOR SWAP-EUREX vs LCH-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-6M_LIBOR_SWAP-EUREX_vs_LCH-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-6M_LIBOR_SWAP-EUREX_vs_LCH-ICAP</seealso>
    let CHF_6M_LIBOR_SWAP_EUREX_vs_LCH_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "CHF-6M_LIBOR_SWAP-EUREX_vs_LCH-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CHF-6M_LIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CHF-6M LIBOR SWAP-EUREX vs LCH-ICAP-Bloomberg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-6M_LIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-6M_LIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg</seealso>
    let CHF_6M_LIBOR_SWAP_EUREX_vs_LCH_ICAP_Bloomberg =
        Prefixed_Name(fibo_ind_ir_cm, "CHF-6M_LIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CHF-Annual_Swap_Rate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"CHF-Annual Swap Rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-Annual_Swap_Rate">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-Annual_Swap_Rate</seealso>
    let CHF_Annual_Swap_Rate =
        Prefixed_Name(fibo_ind_ir_cm, "CHF-Annual_Swap_Rate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CHF-Annual_Swap_Rate-11_00-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CHF-Annual Swap Rate-11:00-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-Annual_Swap_Rate-11_00-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-Annual_Swap_Rate-11_00-ICAP</seealso>
    let CHF_Annual_Swap_Rate_11_00_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "CHF-Annual_Swap_Rate-11_00-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CHF-Annual_Swap_Rate-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CHF-Annual Swap Rate-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-Annual_Swap_Rate-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-Annual_Swap_Rate-Reference_Banks</seealso>
    let CHF_Annual_Swap_Rate_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "CHF-Annual_Swap_Rate-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CHF-Basis_Swap-3m_vs_6m-LIBOR-11_00-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CHF-Basis Swap-3m vs 6m-LIBOR-11:00-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-Basis_Swap-3m_vs_6m-LIBOR-11_00-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-Basis_Swap-3m_vs_6m-LIBOR-11_00-ICAP</seealso>
    let CHF_Basis_Swap_3m_vs_6m_LIBOR_11_00_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "CHF-Basis_Swap-3m_vs_6m-LIBOR-11_00-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CHF-ISDAFIX-Swap_Rate</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CHF-ISDAFIX-Swap Rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-ISDAFIX-Swap_Rate">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-ISDAFIX-Swap_Rate</seealso>
    let CHF_ISDAFIX_Swap_Rate =
        Prefixed_Name(fibo_ind_ir_cm, "CHF-ISDAFIX-Swap_Rate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CHF-LIBOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"CHF-LIBOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-LIBOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-LIBOR</seealso>
    let CHF_LIBOR = Prefixed_Name(fibo_ind_ir_cm, "CHF-LIBOR") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-cm:CHF-LIBOR-ISDA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"CHF-LIBOR-ISDA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-LIBOR-ISDA">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-LIBOR-ISDA</seealso>
    let CHF_LIBOR_ISDA = Prefixed_Name(fibo_ind_ir_cm, "CHF-LIBOR-ISDA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CHF-LIBOR-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CHF-LIBOR-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-LIBOR-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-LIBOR-Reference_Banks</seealso>
    let CHF_LIBOR_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "CHF-LIBOR-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CHF-OIS-11_00-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CHF-OIS-11:00-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-OIS-11_00-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-OIS-11_00-ICAP</seealso>
    let CHF_OIS_11_00_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "CHF-OIS-11_00-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CHF-SARON</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CHF-SARON"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-SARON">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-SARON</seealso>
    let CHF_SARON = Prefixed_Name(fibo_ind_ir_cm, "CHF-SARON") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CHF-SARON-OIS_Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CHF-SARON-OIS Compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-SARON-OIS_Compound">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-SARON-OIS_Compound</seealso>
    let CHF_SARON_OIS_Compound =
        Prefixed_Name(fibo_ind_ir_cm, "CHF-SARON-OIS_Compound") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CHF-SARON_Average_12M</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CHF-SARON Average 12M"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-SARON_Average_12M">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-SARON_Average_12M</seealso>
    let CHF_SARON_Average_12M =
        Prefixed_Name(fibo_ind_ir_cm, "CHF-SARON_Average_12M") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CHF-SARON_Average_1M</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"CHF-SARON Average 1M"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-SARON_Average_1M">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-SARON_Average_1M</seealso>
    let CHF_SARON_Average_1M =
        Prefixed_Name(fibo_ind_ir_cm, "CHF-SARON_Average_1M") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CHF-SARON_Average_1W</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"CHF-SARON Average 1W"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-SARON_Average_1W">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-SARON_Average_1W</seealso>
    let CHF_SARON_Average_1W =
        Prefixed_Name(fibo_ind_ir_cm, "CHF-SARON_Average_1W") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CHF-SARON_Average_2M</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"CHF-SARON Average 2M"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-SARON_Average_2M">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-SARON_Average_2M</seealso>
    let CHF_SARON_Average_2M =
        Prefixed_Name(fibo_ind_ir_cm, "CHF-SARON_Average_2M") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CHF-SARON_Average_3M</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"CHF-SARON Average 3M"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-SARON_Average_3M">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-SARON_Average_3M</seealso>
    let CHF_SARON_Average_3M =
        Prefixed_Name(fibo_ind_ir_cm, "CHF-SARON_Average_3M") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CHF-SARON_Average_6M</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CHF-SARON Average 6M"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-SARON_Average_6M">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-SARON_Average_6M</seealso>
    let CHF_SARON_Average_6M =
        Prefixed_Name(fibo_ind_ir_cm, "CHF-SARON_Average_6M") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CHF-SARON_Average_9M</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CHF-SARON Average 9M"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-SARON_Average_9M">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-SARON_Average_9M</seealso>
    let CHF_SARON_Average_9M =
        Prefixed_Name(fibo_ind_ir_cm, "CHF-SARON_Average_9M") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CHF-SARON_Compounded_Index</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CHF-SARON Compounded Index"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-SARON_Compounded_Index">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-SARON_Compounded_Index</seealso>
    let CHF_SARON_Compounded_Index =
        Prefixed_Name(fibo_ind_ir_cm, "CHF-SARON_Compounded_Index") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CHF-TOIS-OIS-COMPOUND</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CHF-TOIS-OIS-COMPOUND"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-TOIS-OIS-COMPOUND">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF-TOIS-OIS-COMPOUND</seealso>
    let CHF_TOIS_OIS_COMPOUND =
        Prefixed_Name(fibo_ind_ir_cm, "CHF-TOIS-OIS-COMPOUND") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CHF_USD-Basis_Swaps-11_00-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"CHF USD-Basis Swaps-11:00-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF_USD-Basis_Swaps-11_00-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CHF_USD-Basis_Swaps-11_00-ICAP</seealso>
    let CHF_USD_Basis_Swaps_11_00_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "CHF_USD-Basis_Swaps-11_00-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CLP-ICP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"CLP-ICP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CLP-ICP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CLP-ICP</seealso>
    let CLP_ICP = Prefixed_Name(fibo_ind_ir_cm, "CLP-ICP") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-cm:CLP-TNA</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CLP-TNA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CLP-TNA">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CLP-TNA</seealso>
    let CLP_TNA = Prefixed_Name(fibo_ind_ir_cm, "CLP-TNA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CNY-Deposit_Rate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"CNY-Deposit Rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CNY-Deposit_Rate">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CNY-Deposit_Rate</seealso>
    let CNY_Deposit_Rate =
        Prefixed_Name(fibo_ind_ir_cm, "CNY-Deposit_Rate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CNY-Fixing_Repo_Rate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"CNY-Fixing Repo Rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CNY-Fixing_Repo_Rate">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CNY-Fixing_Repo_Rate</seealso>
    let CNY_Fixing_Repo_Rate =
        Prefixed_Name(fibo_ind_ir_cm, "CNY-Fixing_Repo_Rate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CNY-LPR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CNY-LPR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CNY-LPR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CNY-LPR</seealso>
    let CNY_LPR = Prefixed_Name(fibo_ind_ir_cm, "CNY-LPR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CNY-Quarterly_7D_Repo_NDS_Rate_Tradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"CNY-Quarterly 7D Repo NDS Rate Tradition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CNY-Quarterly_7D_Repo_NDS_Rate_Tradition">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CNY-Quarterly_7D_Repo_NDS_Rate_Tradition</seealso>
    let CNY_Quarterly_7D_Repo_NDS_Rate_Tradition =
        Prefixed_Name(fibo_ind_ir_cm, "CNY-Quarterly_7D_Repo_NDS_Rate_Tradition") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CNY-Quarterly_7_day_Repo_Non_Deliverable_Swap_Rate-TRADITION-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"CNY-Quarterly 7 day Repo Non Deliverable Swap Rate-TRADITION-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CNY-Quarterly_7_day_Repo_Non_Deliverable_Swap_Rate-TRADITION-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CNY-Quarterly_7_day_Repo_Non_Deliverable_Swap_Rate-TRADITION-Reference_Banks</seealso>
    let CNY_Quarterly_7_day_Repo_Non_Deliverable_Swap_Rate_TRADITION_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "CNY-Quarterly_7_day_Repo_Non_Deliverable_Swap_Rate-TRADITION-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CNY-SHIBOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CNY-SHIBOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CNY-SHIBOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CNY-SHIBOR</seealso>
    let CNY_SHIBOR = Prefixed_Name(fibo_ind_ir_cm, "CNY-SHIBOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CNY-SHIBOR-OIS_Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"CNY-SHIBOR-OIS Compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CNY-SHIBOR-OIS_Compound">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CNY-SHIBOR-OIS_Compound</seealso>
    let CNY_SHIBOR_OIS_Compound =
        Prefixed_Name(fibo_ind_ir_cm, "CNY-SHIBOR-OIS_Compound") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CNY-Semi-Annual_Swap_Rate-11_00-BGCANTOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"CNY-Semi-Annual Swap Rate-11:00-BGCANTOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CNY-Semi-Annual_Swap_Rate-11_00-BGCANTOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CNY-Semi-Annual_Swap_Rate-11_00-BGCANTOR</seealso>
    let CNY_Semi_Annual_Swap_Rate_11_00_BGCANTOR =
        Prefixed_Name(fibo_ind_ir_cm, "CNY-Semi-Annual_Swap_Rate-11_00-BGCANTOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CNY-Semi-Annual_Swap_Rate-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"CNY-Semi-Annual Swap Rate-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CNY-Semi-Annual_Swap_Rate-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CNY-Semi-Annual_Swap_Rate-Reference_Banks</seealso>
    let CNY_Semi_Annual_Swap_Rate_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "CNY-Semi-Annual_Swap_Rate-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CNY_7-Repo_Compounding_Date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"CNY 7-Repo Compounding Date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CNY_7-Repo_Compounding_Date">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CNY_7-Repo_Compounding_Date</seealso>
    let CNY_7_Repo_Compounding_Date =
        Prefixed_Name(fibo_ind_ir_cm, "CNY_7-Repo_Compounding_Date") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:COP-IBR-OIS_Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"COP-IBR-OIS Compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/COP-IBR-OIS_Compound">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/COP-IBR-OIS_Compound</seealso>
    let COP_IBR_OIS_Compound =
        Prefixed_Name(fibo_ind_ir_cm, "COP-IBR-OIS_Compound") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CZK-Annual_Swap_Rate-11_00-BGCANTOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"CZK-Annual Swap Rate-11:00-BGCANTOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CZK-Annual_Swap_Rate-11_00-BGCANTOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CZK-Annual_Swap_Rate-11_00-BGCANTOR</seealso>
    let CZK_Annual_Swap_Rate_11_00_BGCANTOR =
        Prefixed_Name(fibo_ind_ir_cm, "CZK-Annual_Swap_Rate-11_00-BGCANTOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CZK-Annual_Swap_Rate-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CZK-Annual Swap Rate-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CZK-Annual_Swap_Rate-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CZK-Annual_Swap_Rate-Reference_Banks</seealso>
    let CZK_Annual_Swap_Rate_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "CZK-Annual_Swap_Rate-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CZK-CZEONIA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"CZK-CZEONIA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CZK-CZEONIA">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CZK-CZEONIA</seealso>
    let CZK_CZEONIA = Prefixed_Name(fibo_ind_ir_cm, "CZK-CZEONIA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CZK-CZEONIA-OIS_Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CZK-CZEONIA-OIS Compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CZK-CZEONIA-OIS_Compound">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CZK-CZEONIA-OIS_Compound</seealso>
    let CZK_CZEONIA_OIS_Compound =
        Prefixed_Name(fibo_ind_ir_cm, "CZK-CZEONIA-OIS_Compound") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CZK-PRIBOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CZK-PRIBOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CZK-PRIBOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CZK-PRIBOR</seealso>
    let CZK_PRIBOR = Prefixed_Name(fibo_ind_ir_cm, "CZK-PRIBOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:CZK-PRIBOR-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"CZK-PRIBOR-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CZK-PRIBOR-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/CZK-PRIBOR-Reference_Banks</seealso>
    let CZK_PRIBOR_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "CZK-PRIBOR-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:DKK-CIBOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"DKK-CIBOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/DKK-CIBOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/DKK-CIBOR</seealso>
    let DKK_CIBOR = Prefixed_Name(fibo_ind_ir_cm, "DKK-CIBOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:DKK-CIBOR-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"DKK-CIBOR-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/DKK-CIBOR-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/DKK-CIBOR-Reference_Banks</seealso>
    let DKK_CIBOR_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "DKK-CIBOR-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:DKK-CIBOR2</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"DKK-CIBOR2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/DKK-CIBOR2">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/DKK-CIBOR2</seealso>
    let DKK_CIBOR2 = Prefixed_Name(fibo_ind_ir_cm, "DKK-CIBOR2") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-cm:DKK-CITA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"DKK-CITA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/DKK-CITA">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/DKK-CITA</seealso>
    let DKK_CITA = Prefixed_Name(fibo_ind_ir_cm, "DKK-CITA") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-cm:DKK-DESTR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"DKK-DESTR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/DKK-DESTR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/DKK-DESTR</seealso>
    let DKK_DESTR = Prefixed_Name(fibo_ind_ir_cm, "DKK-DESTR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:DKK-DESTR-OIS_Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"DKK-DESTR-OIS Compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/DKK-DESTR-OIS_Compound">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/DKK-DESTR-OIS_Compound</seealso>
    let DKK_DESTR_OIS_Compound =
        Prefixed_Name(fibo_ind_ir_cm, "DKK-DESTR-OIS_Compound") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:DKK-DESTR_Compounded_Index</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"DKK-DESTR Compounded Index"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/DKK-DESTR_Compounded_Index">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/DKK-DESTR_Compounded_Index</seealso>
    let DKK_DESTR_Compounded_Index =
        Prefixed_Name(fibo_ind_ir_cm, "DKK-DESTR_Compounded_Index") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:DKK-Tom_Next-OIS_Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"DKK-Tom Next-OIS Compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/DKK-Tom_Next-OIS_Compound">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/DKK-Tom_Next-OIS_Compound</seealso>
    let DKK_Tom_Next_OIS_Compound =
        Prefixed_Name(fibo_ind_ir_cm, "DKK-Tom_Next-OIS_Compound") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-3M_EURIBOR_SWAP-CME_vs_LCH-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EUR-3M EURIBOR SWAP-CME vs LCH-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-3M_EURIBOR_SWAP-CME_vs_LCH-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-3M_EURIBOR_SWAP-CME_vs_LCH-ICAP</seealso>
    let EUR_3M_EURIBOR_SWAP_CME_vs_LCH_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-3M_EURIBOR_SWAP-CME_vs_LCH-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-3M_EURIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR-3M EURIBOR SWAP-CME vs LCH-ICAP-Bloomberg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-3M_EURIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-3M_EURIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg</seealso>
    let EUR_3M_EURIBOR_SWAP_CME_vs_LCH_ICAP_Bloomberg =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-3M_EURIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-3M_EURIBOR_SWAP-EUREX_vs_LCH-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR-3M EURIBOR SWAP-EUREX vs LCH-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-3M_EURIBOR_SWAP-EUREX_vs_LCH-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-3M_EURIBOR_SWAP-EUREX_vs_LCH-ICAP</seealso>
    let EUR_3M_EURIBOR_SWAP_EUREX_vs_LCH_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-3M_EURIBOR_SWAP-EUREX_vs_LCH-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-3M_EURIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR-3M EURIBOR SWAP-EUREX vs LCH-ICAP-Bloomberg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-3M_EURIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-3M_EURIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg</seealso>
    let EUR_3M_EURIBOR_SWAP_EUREX_vs_LCH_ICAP_Bloomberg =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-3M_EURIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-6M_EURIBOR_SWAP-CME_vs_LCH-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR-6M EURIBOR SWAP-CME vs LCH-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-6M_EURIBOR_SWAP-CME_vs_LCH-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-6M_EURIBOR_SWAP-CME_vs_LCH-ICAP</seealso>
    let EUR_6M_EURIBOR_SWAP_CME_vs_LCH_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-6M_EURIBOR_SWAP-CME_vs_LCH-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-6M_EURIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EUR-6M EURIBOR SWAP-CME vs LCH-ICAP-Bloomberg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-6M_EURIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-6M_EURIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg</seealso>
    let EUR_6M_EURIBOR_SWAP_CME_vs_LCH_ICAP_Bloomberg =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-6M_EURIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-6M_EURIBOR_SWAP-EUREX_vs_LCH-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR-6M EURIBOR SWAP-EUREX vs LCH-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-6M_EURIBOR_SWAP-EUREX_vs_LCH-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-6M_EURIBOR_SWAP-EUREX_vs_LCH-ICAP</seealso>
    let EUR_6M_EURIBOR_SWAP_EUREX_vs_LCH_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-6M_EURIBOR_SWAP-EUREX_vs_LCH-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-6M_EURIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EUR-6M EURIBOR SWAP-EUREX vs LCH-ICAP-Bloomberg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-6M_EURIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-6M_EURIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg</seealso>
    let EUR_6M_EURIBOR_SWAP_EUREX_vs_LCH_ICAP_Bloomberg =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-6M_EURIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-Annual_Swap_Rate-10_00</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EUR-Annual Swap Rate-10:00"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-10_00">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-10_00</seealso>
    let EUR_Annual_Swap_Rate_10_00 =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-Annual_Swap_Rate-10_00") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-Annual_Swap_Rate-10_00-BGCANTOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR-Annual Swap Rate-10:00-BGCANTOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-10_00-BGCANTOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-10_00-BGCANTOR</seealso>
    let EUR_Annual_Swap_Rate_10_00_BGCANTOR =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-Annual_Swap_Rate-10_00-BGCANTOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-Annual_Swap_Rate-10_00-Bloomberg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR-Annual Swap Rate-10:00-Bloomberg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-10_00-Bloomberg">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-10_00-Bloomberg</seealso>
    let EUR_Annual_Swap_Rate_10_00_Bloomberg =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-Annual_Swap_Rate-10_00-Bloomberg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-Annual_Swap_Rate-10_00-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR-Annual Swap Rate-10:00-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-10_00-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-10_00-ICAP</seealso>
    let EUR_Annual_Swap_Rate_10_00_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-Annual_Swap_Rate-10_00-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-Annual_Swap_Rate-10_00-SwapMarker</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EUR-Annual Swap Rate-10:00-SwapMarker"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-10_00-SwapMarker">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-10_00-SwapMarker</seealso>
    let EUR_Annual_Swap_Rate_10_00_SwapMarker =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-Annual_Swap_Rate-10_00-SwapMarker") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-Annual_Swap_Rate-10_00-TRADITION</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EUR-Annual Swap Rate-10:00-TRADITION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-10_00-TRADITION">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-10_00-TRADITION</seealso>
    let EUR_Annual_Swap_Rate_10_00_TRADITION =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-Annual_Swap_Rate-10_00-TRADITION") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-Annual_Swap_Rate-11_00</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR-Annual Swap Rate-11:00"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-11_00">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-11_00</seealso>
    let EUR_Annual_Swap_Rate_11_00 =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-Annual_Swap_Rate-11_00") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-Annual_Swap_Rate-11_00-Bloomberg</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EUR-Annual Swap Rate-11:00-Bloomberg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-11_00-Bloomberg">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-11_00-Bloomberg</seealso>
    let EUR_Annual_Swap_Rate_11_00_Bloomberg =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-Annual_Swap_Rate-11_00-Bloomberg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-Annual_Swap_Rate-11_00-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EUR-Annual Swap Rate-11:00-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-11_00-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-11_00-ICAP</seealso>
    let EUR_Annual_Swap_Rate_11_00_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-Annual_Swap_Rate-11_00-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-Annual_Swap_Rate-11_00-SwapMarker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR-Annual Swap Rate-11:00-SwapMarker"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-11_00-SwapMarker">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-11_00-SwapMarker</seealso>
    let EUR_Annual_Swap_Rate_11_00_SwapMarker =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-Annual_Swap_Rate-11_00-SwapMarker") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-Annual_Swap_Rate-3_Month</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EUR-Annual Swap Rate-3 Month"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-3_Month">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-3_Month</seealso>
    let EUR_Annual_Swap_Rate_3_Month =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-Annual_Swap_Rate-3_Month") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-Annual_Swap_Rate-3_Month-SwapMarker</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EUR-Annual Swap Rate-3 Month-SwapMarker"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-3_Month-SwapMarker">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-3_Month-SwapMarker</seealso>
    let EUR_Annual_Swap_Rate_3_Month_SwapMarker =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-Annual_Swap_Rate-3_Month-SwapMarker") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-Annual_Swap_Rate-4_15-TRADITION</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR-Annual Swap Rate-4:15-TRADITION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-4_15-TRADITION">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-4_15-TRADITION</seealso>
    let EUR_Annual_Swap_Rate_4_15_TRADITION =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-Annual_Swap_Rate-4_15-TRADITION") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-Annual_Swap_Rate-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EUR-Annual Swap Rate-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-Annual_Swap_Rate-Reference_Banks</seealso>
    let EUR_Annual_Swap_Rate_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-Annual_Swap_Rate-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-CNO_TEC10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR-CNO TEC10"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-CNO_TEC10">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-CNO_TEC10</seealso>
    let EUR_CNO_TEC10 = Prefixed_Name(fibo_ind_ir_cm, "EUR-CNO_TEC10") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-EONIA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR-EONIA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EONIA">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EONIA</seealso>
    let EUR_EONIA = Prefixed_Name(fibo_ind_ir_cm, "EUR-EONIA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-EONIA-Average</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR-EONIA-Average"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EONIA-Average">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EONIA-Average</seealso>
    let EUR_EONIA_Average =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-EONIA-Average") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-EONIA-OIS-10_00-BGCANTOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EUR-EONIA-OIS-10:00-BGCANTOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EONIA-OIS-10_00-BGCANTOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EONIA-OIS-10_00-BGCANTOR</seealso>
    let EUR_EONIA_OIS_10_00_BGCANTOR =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-EONIA-OIS-10_00-BGCANTOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-EONIA-OIS-10_00-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EUR-EONIA-OIS-10:00-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EONIA-OIS-10_00-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EONIA-OIS-10_00-ICAP</seealso>
    let EUR_EONIA_OIS_10_00_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-EONIA-OIS-10_00-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-EONIA-OIS-10_00-TRADITION</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EUR-EONIA-OIS-10:00-TRADITION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EONIA-OIS-10_00-TRADITION">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EONIA-OIS-10_00-TRADITION</seealso>
    let EUR_EONIA_OIS_10_00_TRADITION =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-EONIA-OIS-10_00-TRADITION") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-EONIA-OIS-11_00-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR-EONIA-OIS-11:00-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EONIA-OIS-11_00-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EONIA-OIS-11_00-ICAP</seealso>
    let EUR_EONIA_OIS_11_00_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-EONIA-OIS-11_00-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-EONIA-OIS-4_15-TRADITION</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR-EONIA-OIS-4:15-TRADITION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EONIA-OIS-4_15-TRADITION">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EONIA-OIS-4_15-TRADITION</seealso>
    let EUR_EONIA_OIS_4_15_TRADITION =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-EONIA-OIS-4_15-TRADITION") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-EONIA-OIS_Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR-EONIA-OIS Compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EONIA-OIS_Compound">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EONIA-OIS_Compound</seealso>
    let EUR_EONIA_OIS_Compound =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-EONIA-OIS_Compound") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-EONIA-Swap-Index</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR-EONIA-Swap-Index"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EONIA-Swap-Index">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EONIA-Swap-Index</seealso>
    let EUR_EONIA_Swap_Index =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-EONIA-Swap-Index") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-EURIBOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EUR-EURIBOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EURIBOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EURIBOR</seealso>
    let EUR_EURIBOR = Prefixed_Name(fibo_ind_ir_cm, "EUR-EURIBOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-EURIBOR-Act_365</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EUR-EURIBOR-Act/365"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EURIBOR-Act_365">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EURIBOR-Act_365</seealso>
    let EUR_EURIBOR_Act_365 =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-EURIBOR-Act_365") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-EURIBOR-Act_365-Bloomberg</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EUR-EURIBOR-Act/365-Bloomberg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EURIBOR-Act_365-Bloomberg">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EURIBOR-Act_365-Bloomberg</seealso>
    let EUR_EURIBOR_Act_365_Bloomberg =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-EURIBOR-Act_365-Bloomberg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-EURIBOR-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR-EURIBOR-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EURIBOR-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EURIBOR-Reference_Banks</seealso>
    let EUR_EURIBOR_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-EURIBOR-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-EURIBOR-Telerate</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EUR-EURIBOR-Telerate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EURIBOR-Telerate">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EURIBOR-Telerate</seealso>
    let EUR_EURIBOR_Telerate =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-EURIBOR-Telerate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-EURIBOR_ICE_Swap_Rate-11_00</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EUR-EURIBOR ICE Swap Rate-11:00"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EURIBOR_ICE_Swap_Rate-11_00">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EURIBOR_ICE_Swap_Rate-11_00</seealso>
    let EUR_EURIBOR_ICE_Swap_Rate_11_00 =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-EURIBOR_ICE_Swap_Rate-11_00") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-EURIBOR_ICE_Swap_Rate-12_00</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EUR-EURIBOR ICE Swap Rate-12:00"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EURIBOR_ICE_Swap_Rate-12_00">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EURIBOR_ICE_Swap_Rate-12_00</seealso>
    let EUR_EURIBOR_ICE_Swap_Rate_12_00 =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-EURIBOR_ICE_Swap_Rate-12_00") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-EURONIA-OIS_Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR-EURONIA-OIS Compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EURONIA-OIS_Compound">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EURONIA-OIS_Compound</seealso>
    let EUR_EURONIA_OIS_Compound =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-EURONIA-OIS_Compound") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-EuroSTR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EUR-EuroSTR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR</seealso>
    let EUR_EuroSTR = Prefixed_Name(fibo_ind_ir_cm, "EUR-EuroSTR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-EuroSTR-OIS_Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EUR-EuroSTR-OIS Compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR-OIS_Compound">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR-OIS_Compound</seealso>
    let EUR_EuroSTR_OIS_Compound =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-EuroSTR-OIS_Compound") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-EuroSTR_Average_12M</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EUR-EuroSTR Average 12M"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_Average_12M">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_Average_12M</seealso>
    let EUR_EuroSTR_Average_12M =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-EuroSTR_Average_12M") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-EuroSTR_Average_1M</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EUR-EuroSTR Average 1M"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_Average_1M">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_Average_1M</seealso>
    let EUR_EuroSTR_Average_1M =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-EuroSTR_Average_1M") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-EuroSTR_Average_1W</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EUR-EuroSTR Average 1W"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_Average_1W">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_Average_1W</seealso>
    let EUR_EuroSTR_Average_1W =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-EuroSTR_Average_1W") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-EuroSTR_Average_3M</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR-EuroSTR Average 3M"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_Average_3M">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_Average_3M</seealso>
    let EUR_EuroSTR_Average_3M =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-EuroSTR_Average_3M") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-EuroSTR_Average_6M</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EUR-EuroSTR Average 6M"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_Average_6M">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_Average_6M</seealso>
    let EUR_EuroSTR_Average_6M =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-EuroSTR_Average_6M") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-EuroSTR_Compounded_Index</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EUR-EuroSTR Compounded Index"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_Compounded_Index">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_Compounded_Index</seealso>
    let EUR_EuroSTR_Compounded_Index =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-EuroSTR_Compounded_Index") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-EuroSTR_FTSE_Term</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EUR-EuroSTR FTSE Term"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_FTSE_Term">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_FTSE_Term</seealso>
    let EUR_EuroSTR_FTSE_Term =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-EuroSTR_FTSE_Term") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-EuroSTR_ICE_Compounded_Index</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EUR-EuroSTR ICE Compounded Index"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_ICE_Compounded_Index">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_ICE_Compounded_Index</seealso>
    let EUR_EuroSTR_ICE_Compounded_Index =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-EuroSTR_ICE_Compounded_Index") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-EuroSTR_ICE_Compounded_Index_0_Floor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR-EuroSTR ICE Compounded Index 0 Floor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_ICE_Compounded_Index_0_Floor">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_ICE_Compounded_Index_0_Floor</seealso>
    let EUR_EuroSTR_ICE_Compounded_Index_0_Floor =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-EuroSTR_ICE_Compounded_Index_0_Floor") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-EuroSTR_ICE_Compounded_Index_0_Floor_2D_Lag</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EUR-EuroSTR ICE Compounded Index 0 Floor 2D Lag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_ICE_Compounded_Index_0_Floor_2D_Lag">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_ICE_Compounded_Index_0_Floor_2D_Lag</seealso>
    let EUR_EuroSTR_ICE_Compounded_Index_0_Floor_2D_Lag =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-EuroSTR_ICE_Compounded_Index_0_Floor_2D_Lag") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-EuroSTR_ICE_Compounded_Index_0_Floor_5D_Lag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR-EuroSTR ICE Compounded Index 0 Floor 5D Lag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_ICE_Compounded_Index_0_Floor_5D_Lag">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_ICE_Compounded_Index_0_Floor_5D_Lag</seealso>
    let EUR_EuroSTR_ICE_Compounded_Index_0_Floor_5D_Lag =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-EuroSTR_ICE_Compounded_Index_0_Floor_5D_Lag") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-EuroSTR_ICE_Compounded_Index_2D_Lag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR-EuroSTR ICE Compounded Index 2D Lag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_ICE_Compounded_Index_2D_Lag">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_ICE_Compounded_Index_2D_Lag</seealso>
    let EUR_EuroSTR_ICE_Compounded_Index_2D_Lag =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-EuroSTR_ICE_Compounded_Index_2D_Lag") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-EuroSTR_ICE_Compounded_Index_5D_Lag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR-EuroSTR ICE Compounded Index 5D Lag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_ICE_Compounded_Index_5D_Lag">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_ICE_Compounded_Index_5D_Lag</seealso>
    let EUR_EuroSTR_ICE_Compounded_Index_5D_Lag =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-EuroSTR_ICE_Compounded_Index_5D_Lag") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-EuroSTR_ICE_Swap_Rate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR-EuroSTR ICE Swap Rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_ICE_Swap_Rate">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_ICE_Swap_Rate</seealso>
    let EUR_EuroSTR_ICE_Swap_Rate =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-EuroSTR_ICE_Swap_Rate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-EuroSTR_Term</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EUR-EuroSTR Term"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_Term">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-EuroSTR_Term</seealso>
    let EUR_EuroSTR_Term =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-EuroSTR_Term") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-ISDA-LIBOR_Swap_Rate-10_00</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR-ISDA-LIBOR Swap Rate-10:00"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-ISDA-LIBOR_Swap_Rate-10_00">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-ISDA-LIBOR_Swap_Rate-10_00</seealso>
    let EUR_ISDA_LIBOR_Swap_Rate_10_00 =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-ISDA-LIBOR_Swap_Rate-10_00") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-ISDA-LIBOR_Swap_Rate-11_00</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR-ISDA-LIBOR Swap Rate-11:00"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-ISDA-LIBOR_Swap_Rate-11_00">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-ISDA-LIBOR_Swap_Rate-11_00</seealso>
    let EUR_ISDA_LIBOR_Swap_Rate_11_00 =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-ISDA-LIBOR_Swap_Rate-11_00") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-LIBOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR-LIBOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-LIBOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-LIBOR</seealso>
    let EUR_LIBOR = Prefixed_Name(fibo_ind_ir_cm, "EUR-LIBOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-LIBOR-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EUR-LIBOR-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-LIBOR-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-LIBOR-Reference_Banks</seealso>
    let EUR_LIBOR_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-LIBOR-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-TAM-CDC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR-TAM-CDC"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-TAM-CDC">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-TAM-CDC</seealso>
    let EUR_TAM_CDC = Prefixed_Name(fibo_ind_ir_cm, "EUR-TAM-CDC") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-TEC10-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR-TEC10-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-TEC10-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-TEC10-Reference_Banks</seealso>
    let EUR_TEC10_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-TEC10-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-TEC5-CNO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR-TEC5-CNO"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-TEC5-CNO">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-TEC5-CNO</seealso>
    let EUR_TEC5_CNO = Prefixed_Name(fibo_ind_ir_cm, "EUR-TEC5-CNO") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-TEC5-CNO-SwapMarker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR-TEC5-CNO-SwapMarker"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-TEC5-CNO-SwapMarker">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-TEC5-CNO-SwapMarker</seealso>
    let EUR_TEC5_CNO_SwapMarker =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-TEC5-CNO-SwapMarker") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-TEC5-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR-TEC5-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-TEC5-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-TEC5-Reference_Banks</seealso>
    let EUR_TEC5_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-TEC5-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR-TMM-CDC-COMPOUND</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR-TMM-CDC-COMPOUND"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-TMM-CDC-COMPOUND">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR-TMM-CDC-COMPOUND</seealso>
    let EUR_TMM_CDC_COMPOUND =
        Prefixed_Name(fibo_ind_ir_cm, "EUR-TMM-CDC-COMPOUND") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR_Basis_Swap-EONIA_vs_3m_EUR_IBOR_Swap_Rates-A_360-10_00-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EUR Basis Swap-EONIA vs 3m EUR+IBOR Swap Rates-A/360-10:00-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR_Basis_Swap-EONIA_vs_3m_EUR_IBOR_Swap_Rates-A_360-10_00-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR_Basis_Swap-EONIA_vs_3m_EUR_IBOR_Swap_Rates-A_360-10_00-ICAP</seealso>
    let EUR_Basis_Swap_EONIA_vs_3m_EUR_IBOR_Swap_Rates_A_360_10_00_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "EUR_Basis_Swap-EONIA_vs_3m_EUR_IBOR_Swap_Rates-A_360-10_00-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR_EURIBOR-Annual_Bond_Swap_vs_1m-11_00-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR EURIBOR-Annual Bond Swap vs 1m-11:00-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR_EURIBOR-Annual_Bond_Swap_vs_1m-11_00-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR_EURIBOR-Annual_Bond_Swap_vs_1m-11_00-ICAP</seealso>
    let EUR_EURIBOR_Annual_Bond_Swap_vs_1m_11_00_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "EUR_EURIBOR-Annual_Bond_Swap_vs_1m-11_00-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR_EURIBOR-Basis_Swap-1m_vs_3m-Euribor-11_00-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR EURIBOR-Basis Swap-1m vs 3m-Euribor-11:00-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR_EURIBOR-Basis_Swap-1m_vs_3m-Euribor-11_00-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR_EURIBOR-Basis_Swap-1m_vs_3m-Euribor-11_00-ICAP</seealso>
    let EUR_EURIBOR_Basis_Swap_1m_vs_3m_Euribor_11_00_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "EUR_EURIBOR-Basis_Swap-1m_vs_3m-Euribor-11_00-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR_EURIBOR-Basis_Swap-3m_vs_6m-11_00-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EUR EURIBOR-Basis Swap-3m vs 6m-11:00-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR_EURIBOR-Basis_Swap-3m_vs_6m-11_00-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR_EURIBOR-Basis_Swap-3m_vs_6m-11_00-ICAP</seealso>
    let EUR_EURIBOR_Basis_Swap_3m_vs_6m_11_00_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "EUR_EURIBOR-Basis_Swap-3m_vs_6m-11_00-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:EUR_USD-Basis_Swaps-11_00-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"EUR USD-Basis Swaps-11:00-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR_USD-Basis_Swaps-11_00-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/EUR_USD-Basis_Swaps-11_00-ICAP</seealso>
    let EUR_USD_Basis_Swaps_11_00_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "EUR_USD-Basis_Swaps-11_00-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:GBP-6M_LIBOR_SWAP-CME_vs_LCH-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"GBP-6M LIBOR SWAP-CME vs LCH-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-6M_LIBOR_SWAP-CME_vs_LCH-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-6M_LIBOR_SWAP-CME_vs_LCH-ICAP</seealso>
    let GBP_6M_LIBOR_SWAP_CME_vs_LCH_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "GBP-6M_LIBOR_SWAP-CME_vs_LCH-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:GBP-6M_LIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"GBP-6M LIBOR SWAP-CME vs LCH-ICAP-Bloomberg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-6M_LIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-6M_LIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg</seealso>
    let GBP_6M_LIBOR_SWAP_CME_vs_LCH_ICAP_Bloomberg =
        Prefixed_Name(fibo_ind_ir_cm, "GBP-6M_LIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:GBP-6M_LIBOR_SWAP-EUREX_vs_LCH-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"GBP-6M LIBOR SWAP-EUREX vs LCH-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-6M_LIBOR_SWAP-EUREX_vs_LCH-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-6M_LIBOR_SWAP-EUREX_vs_LCH-ICAP</seealso>
    let GBP_6M_LIBOR_SWAP_EUREX_vs_LCH_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "GBP-6M_LIBOR_SWAP-EUREX_vs_LCH-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:GBP-6M_LIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"GBP-6M LIBOR SWAP-EUREX vs LCH-ICAP-Bloomberg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-6M_LIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-6M_LIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg</seealso>
    let GBP_6M_LIBOR_SWAP_EUREX_vs_LCH_ICAP_Bloomberg =
        Prefixed_Name(fibo_ind_ir_cm, "GBP-6M_LIBOR_SWAP-EUREX_vs_LCH-ICAP-Bloomberg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:GBP-LIBOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"GBP-LIBOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-LIBOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-LIBOR</seealso>
    let GBP_LIBOR = Prefixed_Name(fibo_ind_ir_cm, "GBP-LIBOR") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-cm:GBP-LIBOR-ISDA</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"GBP-LIBOR-ISDA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-LIBOR-ISDA">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-LIBOR-ISDA</seealso>
    let GBP_LIBOR_ISDA = Prefixed_Name(fibo_ind_ir_cm, "GBP-LIBOR-ISDA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:GBP-LIBOR-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"GBP-LIBOR-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-LIBOR-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-LIBOR-Reference_Banks</seealso>
    let GBP_LIBOR_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "GBP-LIBOR-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:GBP-LIBOR_ICE_Swap_Rate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"GBP-LIBOR ICE Swap Rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-LIBOR_ICE_Swap_Rate">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-LIBOR_ICE_Swap_Rate</seealso>
    let GBP_LIBOR_ICE_Swap_Rate =
        Prefixed_Name(fibo_ind_ir_cm, "GBP-LIBOR_ICE_Swap_Rate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:GBP-RONIA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"GBP-RONIA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-RONIA">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-RONIA</seealso>
    let GBP_RONIA = Prefixed_Name(fibo_ind_ir_cm, "GBP-RONIA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:GBP-RONIA-OIS_Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"GBP-RONIA-OIS Compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-RONIA-OIS_Compound">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-RONIA-OIS_Compound</seealso>
    let GBP_RONIA_OIS_Compound =
        Prefixed_Name(fibo_ind_ir_cm, "GBP-RONIA-OIS_Compound") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:GBP-SONIA</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"GBP-SONIA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA</seealso>
    let GBP_SONIA = Prefixed_Name(fibo_ind_ir_cm, "GBP-SONIA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:GBP-SONIA-OIS-11_00-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"GBP-SONIA-OIS-11:00-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA-OIS-11_00-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA-OIS-11_00-ICAP</seealso>
    let GBP_SONIA_OIS_11_00_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "GBP-SONIA-OIS-11_00-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:GBP-SONIA-OIS-11_00-TRADITION</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"GBP-SONIA-OIS-11:00-TRADITION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA-OIS-11_00-TRADITION">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA-OIS-11_00-TRADITION</seealso>
    let GBP_SONIA_OIS_11_00_TRADITION =
        Prefixed_Name(fibo_ind_ir_cm, "GBP-SONIA-OIS-11_00-TRADITION") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:GBP-SONIA-OIS-4_15-TRADITION</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"GBP-SONIA-OIS-4:15-TRADITION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA-OIS-4_15-TRADITION">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA-OIS-4_15-TRADITION</seealso>
    let GBP_SONIA_OIS_4_15_TRADITION =
        Prefixed_Name(fibo_ind_ir_cm, "GBP-SONIA-OIS-4_15-TRADITION") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:GBP-SONIA-OIS_Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"GBP-SONIA-OIS Compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA-OIS_Compound">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA-OIS_Compound</seealso>
    let GBP_SONIA_OIS_Compound =
        Prefixed_Name(fibo_ind_ir_cm, "GBP-SONIA-OIS_Compound") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:GBP-SONIA_Compounded_Index</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"GBP-SONIA Compounded Index"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA_Compounded_Index">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA_Compounded_Index</seealso>
    let GBP_SONIA_Compounded_Index =
        Prefixed_Name(fibo_ind_ir_cm, "GBP-SONIA_Compounded_Index") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:GBP-SONIA_FTSE_Term</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"GBP-SONIA FTSE Term"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA_FTSE_Term">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA_FTSE_Term</seealso>
    let GBP_SONIA_FTSE_Term =
        Prefixed_Name(fibo_ind_ir_cm, "GBP-SONIA_FTSE_Term") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:GBP-SONIA_ICE_Compounded_Index</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"GBP-SONIA ICE Compounded Index"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA_ICE_Compounded_Index">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA_ICE_Compounded_Index</seealso>
    let GBP_SONIA_ICE_Compounded_Index =
        Prefixed_Name(fibo_ind_ir_cm, "GBP-SONIA_ICE_Compounded_Index") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:GBP-SONIA_ICE_Compounded_Index_0_Floor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"GBP-SONIA ICE Compounded Index 0 Floor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA_ICE_Compounded_Index_0_Floor">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA_ICE_Compounded_Index_0_Floor</seealso>
    let GBP_SONIA_ICE_Compounded_Index_0_Floor =
        Prefixed_Name(fibo_ind_ir_cm, "GBP-SONIA_ICE_Compounded_Index_0_Floor") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:GBP-SONIA_ICE_Compounded_Index_0_Floor_2D_Lag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"GBP-SONIA ICE Compounded Index 0 Floor 2D Lag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA_ICE_Compounded_Index_0_Floor_2D_Lag">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA_ICE_Compounded_Index_0_Floor_2D_Lag</seealso>
    let GBP_SONIA_ICE_Compounded_Index_0_Floor_2D_Lag =
        Prefixed_Name(fibo_ind_ir_cm, "GBP-SONIA_ICE_Compounded_Index_0_Floor_2D_Lag") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:GBP-SONIA_ICE_Compounded_Index_0_Floor_5D_Lag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"GBP-SONIA ICE Compounded Index 0 Floor 5D Lag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA_ICE_Compounded_Index_0_Floor_5D_Lag">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA_ICE_Compounded_Index_0_Floor_5D_Lag</seealso>
    let GBP_SONIA_ICE_Compounded_Index_0_Floor_5D_Lag =
        Prefixed_Name(fibo_ind_ir_cm, "GBP-SONIA_ICE_Compounded_Index_0_Floor_5D_Lag") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:GBP-SONIA_ICE_Compounded_Index_2D_Lag</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"GBP-SONIA ICE Compounded Index 2D Lag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA_ICE_Compounded_Index_2D_Lag">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA_ICE_Compounded_Index_2D_Lag</seealso>
    let GBP_SONIA_ICE_Compounded_Index_2D_Lag =
        Prefixed_Name(fibo_ind_ir_cm, "GBP-SONIA_ICE_Compounded_Index_2D_Lag") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:GBP-SONIA_ICE_Compounded_Index_5D_Lag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"GBP-SONIA ICE Compounded Index 5D Lag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA_ICE_Compounded_Index_5D_Lag">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA_ICE_Compounded_Index_5D_Lag</seealso>
    let GBP_SONIA_ICE_Compounded_Index_5D_Lag =
        Prefixed_Name(fibo_ind_ir_cm, "GBP-SONIA_ICE_Compounded_Index_5D_Lag") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:GBP-SONIA_ICE_Swap_Rate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"GBP-SONIA ICE Swap Rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA_ICE_Swap_Rate">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA_ICE_Swap_Rate</seealso>
    let GBP_SONIA_ICE_Swap_Rate =
        Prefixed_Name(fibo_ind_ir_cm, "GBP-SONIA_ICE_Swap_Rate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:GBP-SONIA_ICE_Term</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"GBP-SONIA ICE Term"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA_ICE_Term">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-SONIA_ICE_Term</seealso>
    let GBP_SONIA_ICE_Term =
        Prefixed_Name(fibo_ind_ir_cm, "GBP-SONIA_ICE_Term") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:GBP-Semi-Annual_Swap_Rate</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"GBP-Semi-Annual Swap Rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-Semi-Annual_Swap_Rate">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-Semi-Annual_Swap_Rate</seealso>
    let GBP_Semi_Annual_Swap_Rate =
        Prefixed_Name(fibo_ind_ir_cm, "GBP-Semi-Annual_Swap_Rate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:GBP-Semi-Annual_Swap_Rate-11_00-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"GBP-Semi-Annual Swap Rate-11:00-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-Semi-Annual_Swap_Rate-11_00-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-Semi-Annual_Swap_Rate-11_00-ICAP</seealso>
    let GBP_Semi_Annual_Swap_Rate_11_00_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "GBP-Semi-Annual_Swap_Rate-11_00-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:GBP-Semi-Annual_Swap_Rate-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"GBP-Semi-Annual Swap Rate-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-Semi-Annual_Swap_Rate-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-Semi-Annual_Swap_Rate-Reference_Banks</seealso>
    let GBP_Semi_Annual_Swap_Rate_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "GBP-Semi-Annual_Swap_Rate-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:GBP-Semi-Annual_Swap_Rate-SwapMarker26</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"GBP-Semi-Annual Swap Rate-SwapMarker26"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-Semi-Annual_Swap_Rate-SwapMarker26">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-Semi-Annual_Swap_Rate-SwapMarker26</seealso>
    let GBP_Semi_Annual_Swap_Rate_SwapMarker26 =
        Prefixed_Name(fibo_ind_ir_cm, "GBP-Semi-Annual_Swap_Rate-SwapMarker26") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:GBP-Semi_Annual_Swap_Rate-11_00-TRADITION</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"GBP-Semi Annual Swap Rate-11:00-TRADITION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-Semi_Annual_Swap_Rate-11_00-TRADITION">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-Semi_Annual_Swap_Rate-11_00-TRADITION</seealso>
    let GBP_Semi_Annual_Swap_Rate_11_00_TRADITION =
        Prefixed_Name(fibo_ind_ir_cm, "GBP-Semi_Annual_Swap_Rate-11_00-TRADITION") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:GBP-Semi_Annual_Swap_Rate-4_15-TRADITION</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"GBP-Semi Annual Swap Rate-4:15-TRADITION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-Semi_Annual_Swap_Rate-4_15-TRADITION">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-Semi_Annual_Swap_Rate-4_15-TRADITION</seealso>
    let GBP_Semi_Annual_Swap_Rate_4_15_TRADITION =
        Prefixed_Name(fibo_ind_ir_cm, "GBP-Semi_Annual_Swap_Rate-4_15-TRADITION") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:GBP-UK_Base_Rate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"GBP-UK Base Rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-UK_Base_Rate">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP-UK_Base_Rate</seealso>
    let GBP_UK_Base_Rate =
        Prefixed_Name(fibo_ind_ir_cm, "GBP-UK_Base_Rate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:GBP_USD-Basis_Swaps-11_00-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"GBP USD-Basis Swaps-11:00-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP_USD-Basis_Swaps-11_00-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GBP_USD-Basis_Swaps-11_00-ICAP</seealso>
    let GBP_USD_Basis_Swaps_11_00_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "GBP_USD-Basis_Swaps-11_00-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:GRD-ATHIBOR-ATHIBOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"GRD-ATHIBOR-ATHIBOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GRD-ATHIBOR-ATHIBOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GRD-ATHIBOR-ATHIBOR</seealso>
    let GRD_ATHIBOR_ATHIBOR =
        Prefixed_Name(fibo_ind_ir_cm, "GRD-ATHIBOR-ATHIBOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:GRD-ATHIBOR-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"GRD-ATHIBOR-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GRD-ATHIBOR-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GRD-ATHIBOR-Reference_Banks</seealso>
    let GRD_ATHIBOR_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "GRD-ATHIBOR-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:GRD-ATHIBOR-Telerate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"GRD-ATHIBOR-Telerate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GRD-ATHIBOR-Telerate">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GRD-ATHIBOR-Telerate</seealso>
    let GRD_ATHIBOR_Telerate =
        Prefixed_Name(fibo_ind_ir_cm, "GRD-ATHIBOR-Telerate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:GRD-ATHIMID-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"GRD-ATHIMID-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GRD-ATHIMID-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GRD-ATHIMID-Reference_Banks</seealso>
    let GRD_ATHIMID_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "GRD-ATHIMID-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:GRD-ATHIMID-Reuters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"GRD-ATHIMID-Reuters"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GRD-ATHIMID-Reuters">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/GRD-ATHIMID-Reuters</seealso>
    let GRD_ATHIMID_Reuters =
        Prefixed_Name(fibo_ind_ir_cm, "GRD-ATHIMID-Reuters") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:HKD-HIBOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"HKD-HIBOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-HIBOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-HIBOR</seealso>
    let HKD_HIBOR = Prefixed_Name(fibo_ind_ir_cm, "HKD-HIBOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:HKD-HIBOR-HIBOR-Bloomberg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"HKD-HIBOR-HIBOR-Bloomberg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-HIBOR-HIBOR-Bloomberg">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-HIBOR-HIBOR-Bloomberg</seealso>
    let HKD_HIBOR_HIBOR_Bloomberg =
        Prefixed_Name(fibo_ind_ir_cm, "HKD-HIBOR-HIBOR-Bloomberg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:HKD-HIBOR-HIBOR_</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"HKD-HIBOR-HIBOR="^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-HIBOR-HIBOR_">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-HIBOR-HIBOR_</seealso>
    let HKD_HIBOR_HIBOR_ =
        Prefixed_Name(fibo_ind_ir_cm, "HKD-HIBOR-HIBOR_") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:HKD-HIBOR-ISDC</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"HKD-HIBOR-ISDC"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-HIBOR-ISDC">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-HIBOR-ISDC</seealso>
    let HKD_HIBOR_ISDC = Prefixed_Name(fibo_ind_ir_cm, "HKD-HIBOR-ISDC") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:HKD-HIBOR-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"HKD-HIBOR-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-HIBOR-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-HIBOR-Reference_Banks</seealso>
    let HKD_HIBOR_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "HKD-HIBOR-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:HKD-HONIA</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"HKD-HONIA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-HONIA">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-HONIA</seealso>
    let HKD_HONIA = Prefixed_Name(fibo_ind_ir_cm, "HKD-HONIA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:HKD-HONIA-OIS_Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"HKD-HONIA-OIS Compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-HONIA-OIS_Compound">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-HONIA-OIS_Compound</seealso>
    let HKD_HONIA_OIS_Compound =
        Prefixed_Name(fibo_ind_ir_cm, "HKD-HONIA-OIS_Compound") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:HKD-ISDA-Swap_Rate-11_00</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"HKD-ISDA-Swap Rate-11:00"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-ISDA-Swap_Rate-11_00">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-ISDA-Swap_Rate-11_00</seealso>
    let HKD_ISDA_Swap_Rate_11_00 =
        Prefixed_Name(fibo_ind_ir_cm, "HKD-ISDA-Swap_Rate-11_00") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:HKD-ISDA-Swap_Rate-4_00</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"HKD-ISDA-Swap Rate-4:00"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-ISDA-Swap_Rate-4_00">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-ISDA-Swap_Rate-4_00</seealso>
    let HKD_ISDA_Swap_Rate_4_00 =
        Prefixed_Name(fibo_ind_ir_cm, "HKD-ISDA-Swap_Rate-4_00") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:HKD-Quarterly-Annual_Swap_Rate-11_00-BGCANTOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"HKD-Quarterly-Annual Swap Rate-11:00-BGCANTOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-Quarterly-Annual_Swap_Rate-11_00-BGCANTOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-Quarterly-Annual_Swap_Rate-11_00-BGCANTOR</seealso>
    let HKD_Quarterly_Annual_Swap_Rate_11_00_BGCANTOR =
        Prefixed_Name(fibo_ind_ir_cm, "HKD-Quarterly-Annual_Swap_Rate-11_00-BGCANTOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:HKD-Quarterly-Annual_Swap_Rate-11_00-TRADITION</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"HKD-Quarterly-Annual Swap Rate-11:00-TRADITION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-Quarterly-Annual_Swap_Rate-11_00-TRADITION">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-Quarterly-Annual_Swap_Rate-11_00-TRADITION</seealso>
    let HKD_Quarterly_Annual_Swap_Rate_11_00_TRADITION =
        Prefixed_Name(fibo_ind_ir_cm, "HKD-Quarterly-Annual_Swap_Rate-11_00-TRADITION") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:HKD-Quarterly-Annual_Swap_Rate-4_00-BGCANTOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"HKD-Quarterly-Annual Swap Rate-4:00-BGCANTOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-Quarterly-Annual_Swap_Rate-4_00-BGCANTOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-Quarterly-Annual_Swap_Rate-4_00-BGCANTOR</seealso>
    let HKD_Quarterly_Annual_Swap_Rate_4_00_BGCANTOR =
        Prefixed_Name(fibo_ind_ir_cm, "HKD-Quarterly-Annual_Swap_Rate-4_00-BGCANTOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:HKD-Quarterly-Annual_Swap_Rate-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"HKD-Quarterly-Annual Swap Rate-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-Quarterly-Annual_Swap_Rate-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-Quarterly-Annual_Swap_Rate-Reference_Banks</seealso>
    let HKD_Quarterly_Annual_Swap_Rate_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "HKD-Quarterly-Annual_Swap_Rate-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:HKD-Quarterly-Quarterly_Swap_Rate-11_00-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"HKD-Quarterly-Quarterly Swap Rate-11:00-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-Quarterly-Quarterly_Swap_Rate-11_00-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-Quarterly-Quarterly_Swap_Rate-11_00-ICAP</seealso>
    let HKD_Quarterly_Quarterly_Swap_Rate_11_00_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "HKD-Quarterly-Quarterly_Swap_Rate-11_00-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:HKD-Quarterly-Quarterly_Swap_Rate-4_00-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"HKD-Quarterly-Quarterly Swap Rate-4:00-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-Quarterly-Quarterly_Swap_Rate-4_00-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-Quarterly-Quarterly_Swap_Rate-4_00-ICAP</seealso>
    let HKD_Quarterly_Quarterly_Swap_Rate_4_00_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "HKD-Quarterly-Quarterly_Swap_Rate-4_00-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:HKD-Quarterly-Quarterly_Swap_Rate-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"HKD-Quarterly-Quarterly Swap Rate-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-Quarterly-Quarterly_Swap_Rate-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HKD-Quarterly-Quarterly_Swap_Rate-Reference_Banks</seealso>
    let HKD_Quarterly_Quarterly_Swap_Rate_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "HKD-Quarterly-Quarterly_Swap_Rate-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:HUF-BUBOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"HUF-BUBOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HUF-BUBOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HUF-BUBOR</seealso>
    let HUF_BUBOR = Prefixed_Name(fibo_ind_ir_cm, "HUF-BUBOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:HUF-BUBOR-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"HUF-BUBOR-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HUF-BUBOR-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HUF-BUBOR-Reference_Banks</seealso>
    let HUF_BUBOR_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "HUF-BUBOR-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:HUF-HUFONIA</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"HUF-HUFONIA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HUF-HUFONIA">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HUF-HUFONIA</seealso>
    let HUF_HUFONIA = Prefixed_Name(fibo_ind_ir_cm, "HUF-HUFONIA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:HUF-HUFONIA-OIS_Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"HUF-HUFONIA-OIS Compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HUF-HUFONIA-OIS_Compound">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/HUF-HUFONIA-OIS_Compound</seealso>
    let HUF_HUFONIA_OIS_Compound =
        Prefixed_Name(fibo_ind_ir_cm, "HUF-HUFONIA-OIS_Compound") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:IDR-IDMA-Bloomberg</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"IDR-IDMA-Bloomberg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/IDR-IDMA-Bloomberg">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/IDR-IDMA-Bloomberg</seealso>
    let IDR_IDMA_Bloomberg =
        Prefixed_Name(fibo_ind_ir_cm, "IDR-IDMA-Bloomberg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:IDR-IDRFIX</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"IDR-IDRFIX"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/IDR-IDRFIX">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/IDR-IDRFIX</seealso>
    let IDR_IDRFIX = Prefixed_Name(fibo_ind_ir_cm, "IDR-IDRFIX") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-cm:IDR-INDONIA</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"IDR-INDONIA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/IDR-INDONIA">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/IDR-INDONIA</seealso>
    let IDR_INDONIA = Prefixed_Name(fibo_ind_ir_cm, "IDR-INDONIA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:IDR-INDONIA-OIS_Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"IDR-INDONIA-OIS Compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/IDR-INDONIA-OIS_Compound">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/IDR-INDONIA-OIS_Compound</seealso>
    let IDR_INDONIA_OIS_Compound =
        Prefixed_Name(fibo_ind_ir_cm, "IDR-INDONIA-OIS_Compound") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:IDR-JIBOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"IDR-JIBOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/IDR-JIBOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/IDR-JIBOR</seealso>
    let IDR_JIBOR = Prefixed_Name(fibo_ind_ir_cm, "IDR-JIBOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:IDR-SBI-Reuters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"IDR-SBI-Reuters"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/IDR-SBI-Reuters">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/IDR-SBI-Reuters</seealso>
    let IDR_SBI_Reuters =
        Prefixed_Name(fibo_ind_ir_cm, "IDR-SBI-Reuters") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:IDR-SOR-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"IDR-SOR-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/IDR-SOR-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/IDR-SOR-Reference_Banks</seealso>
    let IDR_SOR_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "IDR-SOR-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:IDR-SOR-Reuters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"IDR-SOR-Reuters"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/IDR-SOR-Reuters">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/IDR-SOR-Reuters</seealso>
    let IDR_SOR_Reuters =
        Prefixed_Name(fibo_ind_ir_cm, "IDR-SOR-Reuters") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:IDR-SOR-Telerate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"IDR-SOR-Telerate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/IDR-SOR-Telerate">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/IDR-SOR-Telerate</seealso>
    let IDR_SOR_Telerate =
        Prefixed_Name(fibo_ind_ir_cm, "IDR-SOR-Telerate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:IDR-Semi-Annual_Swap_Rate-11_00-BGCANTOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"IDR-Semi-Annual Swap Rate-11:00-BGCANTOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/IDR-Semi-Annual_Swap_Rate-11_00-BGCANTOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/IDR-Semi-Annual_Swap_Rate-11_00-BGCANTOR</seealso>
    let IDR_Semi_Annual_Swap_Rate_11_00_BGCANTOR =
        Prefixed_Name(fibo_ind_ir_cm, "IDR-Semi-Annual_Swap_Rate-11_00-BGCANTOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:IDR-Semi-Annual_Swap_Rate-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"IDR-Semi-Annual Swap Rate-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/IDR-Semi-Annual_Swap_Rate-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/IDR-Semi-Annual_Swap_Rate-Reference_Banks</seealso>
    let IDR_Semi_Annual_Swap_Rate_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "IDR-Semi-Annual_Swap_Rate-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:IDR-Semi_Annual_Swap_Rate-Non-deliverable-16_00-Tullett_Prebon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"IDR-Semi Annual Swap Rate-Non-deliverable-16:00-Tullett Prebon"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/IDR-Semi_Annual_Swap_Rate-Non-deliverable-16_00-Tullett_Prebon">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/IDR-Semi_Annual_Swap_Rate-Non-deliverable-16_00-Tullett_Prebon</seealso>
    let IDR_Semi_Annual_Swap_Rate_Non_deliverable_16_00_Tullett_Prebon =
        Prefixed_Name(fibo_ind_ir_cm, "IDR-Semi_Annual_Swap_Rate-Non-deliverable-16_00-Tullett_Prebon") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:ILS-SHIR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ILS-SHIR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ILS-SHIR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ILS-SHIR</seealso>
    let ILS_SHIR = Prefixed_Name(fibo_ind_ir_cm, "ILS-SHIR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:ILS-SHIR-OIS_Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"ILS-SHIR-OIS Compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ILS-SHIR-OIS_Compound">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ILS-SHIR-OIS_Compound</seealso>
    let ILS_SHIR_OIS_Compound =
        Prefixed_Name(fibo_ind_ir_cm, "ILS-SHIR-OIS_Compound") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:ILS-TELBOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ILS-TELBOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ILS-TELBOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ILS-TELBOR</seealso>
    let ILS_TELBOR = Prefixed_Name(fibo_ind_ir_cm, "ILS-TELBOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:ILS-TELBOR-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ILS-TELBOR-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ILS-TELBOR-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ILS-TELBOR-Reference_Banks</seealso>
    let ILS_TELBOR_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "ILS-TELBOR-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:INR-BMK</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"INR-BMK"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-BMK">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-BMK</seealso>
    let INR_BMK = Prefixed_Name(fibo_ind_ir_cm, "INR-BMK") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-cm:INR-CMT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"INR-CMT"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-CMT">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-CMT</seealso>
    let INR_CMT = Prefixed_Name(fibo_ind_ir_cm, "INR-CMT") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:INR-INBMK-REUTERS</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"INR-INBMK-REUTERS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-INBMK-REUTERS">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-INBMK-REUTERS</seealso>
    let INR_INBMK_REUTERS =
        Prefixed_Name(fibo_ind_ir_cm, "INR-INBMK-REUTERS") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:INR-MIBOR-OIS-COMPOUND</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"INR-MIBOR-OIS-COMPOUND"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-MIBOR-OIS-COMPOUND">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-MIBOR-OIS-COMPOUND</seealso>
    let INR_MIBOR_OIS_COMPOUND =
        Prefixed_Name(fibo_ind_ir_cm, "INR-MIBOR-OIS-COMPOUND") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:INR-MIBOR-OIS_Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"INR-MIBOR-OIS Compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-MIBOR-OIS_Compound">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-MIBOR-OIS_Compound</seealso>
    let INR_MIBOR_OIS_Compound =
        Prefixed_Name(fibo_ind_ir_cm, "INR-MIBOR-OIS_Compound") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:INR-MIBOR_OIS</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"INR-MIBOR OIS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-MIBOR_OIS">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-MIBOR_OIS</seealso>
    let INR_MIBOR_OIS = Prefixed_Name(fibo_ind_ir_cm, "INR-MIBOR_OIS") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-cm:INR-MIFOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"INR-MIFOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-MIFOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-MIFOR</seealso>
    let INR_MIFOR = Prefixed_Name(fibo_ind_ir_cm, "INR-MIFOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:INR-MITOR-OIS-COMPOUND</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"INR-MITOR-OIS-COMPOUND"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-MITOR-OIS-COMPOUND">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-MITOR-OIS-COMPOUND</seealso>
    let INR_MITOR_OIS_COMPOUND =
        Prefixed_Name(fibo_ind_ir_cm, "INR-MITOR-OIS-COMPOUND") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:INR-Modified_MIFOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"INR-Modified MIFOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-Modified_MIFOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-Modified_MIFOR</seealso>
    let INR_Modified_MIFOR =
        Prefixed_Name(fibo_ind_ir_cm, "INR-Modified_MIFOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:INR-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"INR-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-Reference_Banks</seealso>
    let INR_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "INR-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:INR-Semi-Annual_Swap_Rate-11_30-BGCANTOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"INR-Semi-Annual Swap Rate-11:30-BGCANTOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-Semi-Annual_Swap_Rate-11_30-BGCANTOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-Semi-Annual_Swap_Rate-11_30-BGCANTOR</seealso>
    let INR_Semi_Annual_Swap_Rate_11_30_BGCANTOR =
        Prefixed_Name(fibo_ind_ir_cm, "INR-Semi-Annual_Swap_Rate-11_30-BGCANTOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:INR-Semi-Annual_Swap_Rate-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"INR-Semi-Annual Swap Rate-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-Semi-Annual_Swap_Rate-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-Semi-Annual_Swap_Rate-Reference_Banks</seealso>
    let INR_Semi_Annual_Swap_Rate_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "INR-Semi-Annual_Swap_Rate-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:INR-Semi_Annual_Swap_Rate-Non-deliverable-16_00-Tullett_Prebon</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"INR-Semi Annual Swap Rate-Non-deliverable-16:00-Tullett Prebon"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-Semi_Annual_Swap_Rate-Non-deliverable-16_00-Tullett_Prebon">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/INR-Semi_Annual_Swap_Rate-Non-deliverable-16_00-Tullett_Prebon</seealso>
    let INR_Semi_Annual_Swap_Rate_Non_deliverable_16_00_Tullett_Prebon =
        Prefixed_Name(fibo_ind_ir_cm, "INR-Semi_Annual_Swap_Rate-Non-deliverable-16_00-Tullett_Prebon") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:ISK-REIBOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ISK-REIBOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ISK-REIBOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ISK-REIBOR</seealso>
    let ISK_REIBOR = Prefixed_Name(fibo_ind_ir_cm, "ISK-REIBOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:ISK-REIBOR-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ISK-REIBOR-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ISK-REIBOR-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ISK-REIBOR-Reference_Banks</seealso>
    let ISK_REIBOR_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "ISK-REIBOR-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-Annual_Swap_Rate-11_00-TRADITION</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"JPY-Annual Swap Rate-11:00-TRADITION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-Annual_Swap_Rate-11_00-TRADITION">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-Annual_Swap_Rate-11_00-TRADITION</seealso>
    let JPY_Annual_Swap_Rate_11_00_TRADITION =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-Annual_Swap_Rate-11_00-TRADITION") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-Annual_Swap_Rate-3_00-TRADITION</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JPY-Annual Swap Rate-3:00-TRADITION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-Annual_Swap_Rate-3_00-TRADITION">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-Annual_Swap_Rate-3_00-TRADITION</seealso>
    let JPY_Annual_Swap_Rate_3_00_TRADITION =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-Annual_Swap_Rate-3_00-TRADITION") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-BBSF-Bloomberg-10_00</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"JPY-BBSF-Bloomberg-10:00"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-BBSF-Bloomberg-10_00">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-BBSF-Bloomberg-10_00</seealso>
    let JPY_BBSF_Bloomberg_10_00 =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-BBSF-Bloomberg-10_00") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-BBSF-Bloomberg-15_00</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"JPY-BBSF-Bloomberg-15:00"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-BBSF-Bloomberg-15_00">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-BBSF-Bloomberg-15_00</seealso>
    let JPY_BBSF_Bloomberg_15_00 =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-BBSF-Bloomberg-15_00") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-Euroyen_TIBOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"JPY-Euroyen TIBOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-Euroyen_TIBOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-Euroyen_TIBOR</seealso>
    let JPY_Euroyen_TIBOR =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-Euroyen_TIBOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-ISDA-Swap_Rate-10_00</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JPY-ISDA-Swap Rate-10:00"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-ISDA-Swap_Rate-10_00">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-ISDA-Swap_Rate-10_00</seealso>
    let JPY_ISDA_Swap_Rate_10_00 =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-ISDA-Swap_Rate-10_00") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-ISDA-Swap_Rate-15_00</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"JPY-ISDA-Swap Rate-15:00"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-ISDA-Swap_Rate-15_00">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-ISDA-Swap_Rate-15_00</seealso>
    let JPY_ISDA_Swap_Rate_15_00 =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-ISDA-Swap_Rate-15_00") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-LIBOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JPY-LIBOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-LIBOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-LIBOR</seealso>
    let JPY_LIBOR = Prefixed_Name(fibo_ind_ir_cm, "JPY-LIBOR") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-LIBOR-ISDA</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JPY-LIBOR-ISDA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-LIBOR-ISDA">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-LIBOR-ISDA</seealso>
    let JPY_LIBOR_ISDA = Prefixed_Name(fibo_ind_ir_cm, "JPY-LIBOR-ISDA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-LIBOR-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JPY-LIBOR-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-LIBOR-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-LIBOR-Reference_Banks</seealso>
    let JPY_LIBOR_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-LIBOR-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-LIBOR_TSR-10_00</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"JPY-LIBOR TSR-10:00"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-LIBOR_TSR-10_00">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-LIBOR_TSR-10_00</seealso>
    let JPY_LIBOR_TSR_10_00 =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-LIBOR_TSR-10_00") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-LIBOR_TSR-15_00</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"JPY-LIBOR TSR-15:00"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-LIBOR_TSR-15_00">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-LIBOR_TSR-15_00</seealso>
    let JPY_LIBOR_TSR_15_00 =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-LIBOR_TSR-15_00") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-LTPR-TBC</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JPY-LTPR-TBC"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-LTPR-TBC">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-LTPR-TBC</seealso>
    let JPY_LTPR_TBC = Prefixed_Name(fibo_ind_ir_cm, "JPY-LTPR-TBC") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-LTPR_MHBK</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JPY-LTPR MHBK"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-LTPR_MHBK">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-LTPR_MHBK</seealso>
    let JPY_LTPR_MHBK = Prefixed_Name(fibo_ind_ir_cm, "JPY-LTPR_MHBK") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-MUTANCALL-TONAR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"JPY-MUTANCALL-TONAR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-MUTANCALL-TONAR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-MUTANCALL-TONAR</seealso>
    let JPY_MUTANCALL_TONAR =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-MUTANCALL-TONAR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-OIS-11_00-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"JPY-OIS-11:00-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-OIS-11_00-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-OIS-11_00-ICAP</seealso>
    let JPY_OIS_11_00_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-OIS-11_00-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-OIS-11_00-TRADITION</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"JPY-OIS-11:00-TRADITION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-OIS-11_00-TRADITION">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-OIS-11_00-TRADITION</seealso>
    let JPY_OIS_11_00_TRADITION =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-OIS-11_00-TRADITION") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-OIS-3_00-TRADITION</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JPY-OIS-3:00-TRADITION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-OIS-3_00-TRADITION">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-OIS-3_00-TRADITION</seealso>
    let JPY_OIS_3_00_TRADITION =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-OIS-3_00-TRADITION") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-Quoting_Banks-LIBOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JPY-Quoting Banks-LIBOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-Quoting_Banks-LIBOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-Quoting_Banks-LIBOR</seealso>
    let JPY_Quoting_Banks_LIBOR =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-Quoting_Banks-LIBOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-STPR-Quoting_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JPY-STPR-Quoting Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-STPR-Quoting_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-STPR-Quoting_Banks</seealso>
    let JPY_STPR_Quoting_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-STPR-Quoting_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-TIBOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"JPY-TIBOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TIBOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TIBOR</seealso>
    let JPY_TIBOR = Prefixed_Name(fibo_ind_ir_cm, "JPY-TIBOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-TIBOR-17096</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JPY-TIBOR-17096"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TIBOR-17096">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TIBOR-17096</seealso>
    let JPY_TIBOR_17096 =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-TIBOR-17096") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-TIBOR-DTIBOR01</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JPY-TIBOR-DTIBOR01"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TIBOR-DTIBOR01">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TIBOR-DTIBOR01</seealso>
    let JPY_TIBOR_DTIBOR01 =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-TIBOR-DTIBOR01") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-TIBOR-TIBM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"JPY-TIBOR-TIBM"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TIBOR-TIBM">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TIBOR-TIBM</seealso>
    let JPY_TIBOR_TIBM = Prefixed_Name(fibo_ind_ir_cm, "JPY-TIBOR-TIBM") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-TIBOR-TIBM-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JPY-TIBOR-TIBM-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TIBOR-TIBM-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TIBOR-TIBM-Reference_Banks</seealso>
    let JPY_TIBOR_TIBM_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-TIBOR-TIBM-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-TIBOR-TIBM_10_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"JPY-TIBOR-TIBM (10 Banks)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TIBOR-TIBM_10_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TIBOR-TIBM_10_Banks</seealso>
    let JPY_TIBOR_TIBM_10_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-TIBOR-TIBM_10_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-TIBOR-TIBM_5_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"JPY-TIBOR-TIBM (5 Banks)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TIBOR-TIBM_5_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TIBOR-TIBM_5_Banks</seealso>
    let JPY_TIBOR_TIBM_5_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-TIBOR-TIBM_5_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-TIBOR-TIBM_All_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"JPY-TIBOR-TIBM (All Banks)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TIBOR-TIBM_All_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TIBOR-TIBM_All_Banks</seealso>
    let JPY_TIBOR_TIBM_All_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-TIBOR-TIBM_All_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-TONA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"JPY-TONA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA</seealso>
    let JPY_TONA = Prefixed_Name(fibo_ind_ir_cm, "JPY-TONA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-TONA-OIS_Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JPY-TONA-OIS Compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA-OIS_Compound">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA-OIS_Compound</seealso>
    let JPY_TONA_OIS_Compound =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-TONA-OIS_Compound") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-TONA_Average_180D</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JPY-TONA Average 180D"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA_Average_180D">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA_Average_180D</seealso>
    let JPY_TONA_Average_180D =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-TONA_Average_180D") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-TONA_Average_30D</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JPY-TONA Average 30D"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA_Average_30D">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA_Average_30D</seealso>
    let JPY_TONA_Average_30D =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-TONA_Average_30D") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-TONA_Average_90D</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JPY-TONA Average 90D"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA_Average_90D">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA_Average_90D</seealso>
    let JPY_TONA_Average_90D =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-TONA_Average_90D") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-TONA_Compounded_Index</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JPY-TONA Compounded Index"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA_Compounded_Index">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA_Compounded_Index</seealso>
    let JPY_TONA_Compounded_Index =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-TONA_Compounded_Index") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-TONA_ICE_Compounded_Index</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"JPY-TONA ICE Compounded Index"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA_ICE_Compounded_Index">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA_ICE_Compounded_Index</seealso>
    let JPY_TONA_ICE_Compounded_Index =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-TONA_ICE_Compounded_Index") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-TONA_ICE_Compounded_Index_0_Floor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"JPY-TONA ICE Compounded Index 0 Floor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA_ICE_Compounded_Index_0_Floor">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA_ICE_Compounded_Index_0_Floor</seealso>
    let JPY_TONA_ICE_Compounded_Index_0_Floor =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-TONA_ICE_Compounded_Index_0_Floor") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-TONA_ICE_Compounded_Index_0_Floor_2D_Lag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"JPY-TONA ICE Compounded Index 0 Floor 2D Lag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA_ICE_Compounded_Index_0_Floor_2D_Lag">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA_ICE_Compounded_Index_0_Floor_2D_Lag</seealso>
    let JPY_TONA_ICE_Compounded_Index_0_Floor_2D_Lag =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-TONA_ICE_Compounded_Index_0_Floor_2D_Lag") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-TONA_ICE_Compounded_Index_0_Floor_5D_Lag</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JPY-TONA ICE Compounded Index 0 Floor 5D Lag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA_ICE_Compounded_Index_0_Floor_5D_Lag">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA_ICE_Compounded_Index_0_Floor_5D_Lag</seealso>
    let JPY_TONA_ICE_Compounded_Index_0_Floor_5D_Lag =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-TONA_ICE_Compounded_Index_0_Floor_5D_Lag") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-TONA_ICE_Compounded_Index_2D_Lag</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JPY-TONA ICE Compounded Index 2D Lag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA_ICE_Compounded_Index_2D_Lag">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA_ICE_Compounded_Index_2D_Lag</seealso>
    let JPY_TONA_ICE_Compounded_Index_2D_Lag =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-TONA_ICE_Compounded_Index_2D_Lag") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-TONA_ICE_Compounded_Index_5D_Lag</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JPY-TONA ICE Compounded Index 5D Lag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA_ICE_Compounded_Index_5D_Lag">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA_ICE_Compounded_Index_5D_Lag</seealso>
    let JPY_TONA_ICE_Compounded_Index_5D_Lag =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-TONA_ICE_Compounded_Index_5D_Lag") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-TONA_TSR-10_00</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JPY-TONA TSR-10:00"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA_TSR-10_00">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA_TSR-10_00</seealso>
    let JPY_TONA_TSR_10_00 =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-TONA_TSR-10_00") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-TONA_TSR-15_00</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JPY-TONA TSR-15:00"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA_TSR-15_00">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TONA_TSR-15_00</seealso>
    let JPY_TONA_TSR_15_00 =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-TONA_TSR-15_00") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-TORF_QUICK</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"JPY-TORF QUICK"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TORF_QUICK">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TORF_QUICK</seealso>
    let JPY_TORF_QUICK = Prefixed_Name(fibo_ind_ir_cm, "JPY-TORF_QUICK") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-TSR-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"JPY-TSR-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TSR-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TSR-Reference_Banks</seealso>
    let JPY_TSR_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-TSR-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-TSR-Telerate-10_00</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"JPY-TSR-Telerate-10:00"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TSR-Telerate-10_00">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TSR-Telerate-10_00</seealso>
    let JPY_TSR_Telerate_10_00 =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-TSR-Telerate-10_00") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY-TSR-Telerate-15_00</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JPY-TSR-Telerate-15:00"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TSR-Telerate-15_00">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY-TSR-Telerate-15_00</seealso>
    let JPY_TSR_Telerate_15_00 =
        Prefixed_Name(fibo_ind_ir_cm, "JPY-TSR-Telerate-15_00") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:JPY_USD-Basis_Swaps-11_00-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JPY USD-Basis Swaps-11:00-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY_USD-Basis_Swaps-11_00-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/JPY_USD-Basis_Swaps-11_00-ICAP</seealso>
    let JPY_USD_Basis_Swaps_11_00_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "JPY_USD-Basis_Swaps-11_00-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:KRW-Bond-3222</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"KRW-Bond-3222"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/KRW-Bond-3222">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/KRW-Bond-3222</seealso>
    let KRW_Bond_3222 = Prefixed_Name(fibo_ind_ir_cm, "KRW-Bond-3222") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-cm:KRW-CD_91D</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"KRW-CD 91D"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/KRW-CD_91D">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/KRW-CD_91D</seealso>
    let KRW_CD_91D = Prefixed_Name(fibo_ind_ir_cm, "KRW-CD_91D") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-cm:KRW-KOFR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"KRW-KOFR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/KRW-KOFR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/KRW-KOFR</seealso>
    let KRW_KOFR = Prefixed_Name(fibo_ind_ir_cm, "KRW-KOFR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:KRW-KOFR-OIS_Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"KRW-KOFR-OIS Compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/KRW-KOFR-OIS_Compound">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/KRW-KOFR-OIS_Compound</seealso>
    let KRW_KOFR_OIS_Compound =
        Prefixed_Name(fibo_ind_ir_cm, "KRW-KOFR-OIS_Compound") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:KRW-Quarterly_Annual_Swap_Rate-3_30-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"KRW-Quarterly Annual Swap Rate-3:30-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/KRW-Quarterly_Annual_Swap_Rate-3_30-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/KRW-Quarterly_Annual_Swap_Rate-3_30-ICAP</seealso>
    let KRW_Quarterly_Annual_Swap_Rate_3_30_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "KRW-Quarterly_Annual_Swap_Rate-3_30-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:MXN-TIIE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"MXN-TIIE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/MXN-TIIE">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/MXN-TIIE</seealso>
    let MXN_TIIE = Prefixed_Name(fibo_ind_ir_cm, "MXN-TIIE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:MXN-TIIE-Banxico-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"MXN-TIIE-Banxico-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/MXN-TIIE-Banxico-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/MXN-TIIE-Banxico-Reference_Banks</seealso>
    let MXN_TIIE_Banxico_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "MXN-TIIE-Banxico-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:MXN-TIIE-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"MXN-TIIE-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/MXN-TIIE-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/MXN-TIIE-Reference_Banks</seealso>
    let MXN_TIIE_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "MXN-TIIE-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:MXN-TIIE_ON</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"MXN-TIIE ON"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/MXN-TIIE_ON">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/MXN-TIIE_ON</seealso>
    let MXN_TIIE_ON = Prefixed_Name(fibo_ind_ir_cm, "MXN-TIIE_ON") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:MXN-TIIE_ON-OIS_Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"MXN-TIIE ON-OIS Compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/MXN-TIIE_ON-OIS_Compound">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/MXN-TIIE_ON-OIS_Compound</seealso>
    let MXN_TIIE_ON_OIS_Compound =
        Prefixed_Name(fibo_ind_ir_cm, "MXN-TIIE_ON-OIS_Compound") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:MYR-KLIBOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"MYR-KLIBOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/MYR-KLIBOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/MYR-KLIBOR</seealso>
    let MYR_KLIBOR = Prefixed_Name(fibo_ind_ir_cm, "MYR-KLIBOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:MYR-KLIBOR-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"MYR-KLIBOR-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/MYR-KLIBOR-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/MYR-KLIBOR-Reference_Banks</seealso>
    let MYR_KLIBOR_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "MYR-KLIBOR-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:MYR-MYOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"MYR-MYOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/MYR-MYOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/MYR-MYOR</seealso>
    let MYR_MYOR = Prefixed_Name(fibo_ind_ir_cm, "MYR-MYOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:MYR-MYOR-OIS_Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"MYR-MYOR-OIS Compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/MYR-MYOR-OIS_Compound">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/MYR-MYOR-OIS_Compound</seealso>
    let MYR_MYOR_OIS_Compound =
        Prefixed_Name(fibo_ind_ir_cm, "MYR-MYOR-OIS_Compound") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:MYR-Quarterly_Swap_Rate-11_00-TRADITION</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"MYR-Quarterly Swap Rate-11:00-TRADITION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/MYR-Quarterly_Swap_Rate-11_00-TRADITION">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/MYR-Quarterly_Swap_Rate-11_00-TRADITION</seealso>
    let MYR_Quarterly_Swap_Rate_11_00_TRADITION =
        Prefixed_Name(fibo_ind_ir_cm, "MYR-Quarterly_Swap_Rate-11_00-TRADITION") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:MYR-Quarterly_Swap_Rate-TRADITION-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"MYR-Quarterly Swap Rate-TRADITION-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/MYR-Quarterly_Swap_Rate-TRADITION-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/MYR-Quarterly_Swap_Rate-TRADITION-Reference_Banks</seealso>
    let MYR_Quarterly_Swap_Rate_TRADITION_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "MYR-Quarterly_Swap_Rate-TRADITION-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:NOK-NIBOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"NOK-NIBOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NOK-NIBOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NOK-NIBOR</seealso>
    let NOK_NIBOR = Prefixed_Name(fibo_ind_ir_cm, "NOK-NIBOR") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-cm:NOK-NIBOR-NIBR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"NOK-NIBOR-NIBR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NOK-NIBOR-NIBR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NOK-NIBOR-NIBR</seealso>
    let NOK_NIBOR_NIBR = Prefixed_Name(fibo_ind_ir_cm, "NOK-NIBOR-NIBR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:NOK-NIBOR-NIBR-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"NOK-NIBOR-NIBR-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NOK-NIBOR-NIBR-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NOK-NIBOR-NIBR-Reference_Banks</seealso>
    let NOK_NIBOR_NIBR_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "NOK-NIBOR-NIBR-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:NOK-NIBOR-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"NOK-NIBOR-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NOK-NIBOR-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NOK-NIBOR-Reference_Banks</seealso>
    let NOK_NIBOR_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "NOK-NIBOR-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:NOK-NOWA</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"NOK-NOWA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NOK-NOWA">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NOK-NOWA</seealso>
    let NOK_NOWA = Prefixed_Name(fibo_ind_ir_cm, "NOK-NOWA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:NOK-NOWA-OIS_Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"NOK-NOWA-OIS Compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NOK-NOWA-OIS_Compound">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NOK-NOWA-OIS_Compound</seealso>
    let NOK_NOWA_OIS_Compound =
        Prefixed_Name(fibo_ind_ir_cm, "NOK-NOWA-OIS_Compound") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:NZD-BBR-ISDC</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"NZD-BBR-ISDC"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NZD-BBR-ISDC">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NZD-BBR-ISDC</seealso>
    let NZD_BBR_ISDC = Prefixed_Name(fibo_ind_ir_cm, "NZD-BBR-ISDC") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:NZD-BBR-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"NZD-BBR-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NZD-BBR-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NZD-BBR-Reference_Banks</seealso>
    let NZD_BBR_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "NZD-BBR-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:NZD-BBR-Telerate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"NZD-BBR-Telerate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NZD-BBR-Telerate">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NZD-BBR-Telerate</seealso>
    let NZD_BBR_Telerate =
        Prefixed_Name(fibo_ind_ir_cm, "NZD-BBR-Telerate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:NZD-BKBM_Bid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"NZD-BKBM Bid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NZD-BKBM_Bid">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NZD-BKBM_Bid</seealso>
    let NZD_BKBM_Bid = Prefixed_Name(fibo_ind_ir_cm, "NZD-BKBM_Bid") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-cm:NZD-BKBM_FRA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"NZD-BKBM FRA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NZD-BKBM_FRA">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NZD-BKBM_FRA</seealso>
    let NZD_BKBM_FRA = Prefixed_Name(fibo_ind_ir_cm, "NZD-BKBM_FRA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:NZD-BKBM_FRA_Swap_Rate_ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"NZD-BKBM FRA Swap Rate ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NZD-BKBM_FRA_Swap_Rate_ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NZD-BKBM_FRA_Swap_Rate_ICAP</seealso>
    let NZD_BKBM_FRA_Swap_Rate_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "NZD-BKBM_FRA_Swap_Rate_ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:NZD-NZIONA</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"NZD-NZIONA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NZD-NZIONA">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NZD-NZIONA</seealso>
    let NZD_NZIONA = Prefixed_Name(fibo_ind_ir_cm, "NZD-NZIONA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:NZD-NZIONA-OIS_Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"NZD-NZIONA-OIS Compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NZD-NZIONA-OIS_Compound">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NZD-NZIONA-OIS_Compound</seealso>
    let NZD_NZIONA_OIS_Compound =
        Prefixed_Name(fibo_ind_ir_cm, "NZD-NZIONA-OIS_Compound") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:NZD-Semi-Annual_Swap_Rate-11_00-BGCANTOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"NZD-Semi-Annual Swap Rate-11:00-BGCANTOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NZD-Semi-Annual_Swap_Rate-11_00-BGCANTOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NZD-Semi-Annual_Swap_Rate-11_00-BGCANTOR</seealso>
    let NZD_Semi_Annual_Swap_Rate_11_00_BGCANTOR =
        Prefixed_Name(fibo_ind_ir_cm, "NZD-Semi-Annual_Swap_Rate-11_00-BGCANTOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:NZD-Semi-Annual_Swap_Rate-BGCANTOR-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"NZD-Semi-Annual Swap Rate-BGCANTOR-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NZD-Semi-Annual_Swap_Rate-BGCANTOR-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NZD-Semi-Annual_Swap_Rate-BGCANTOR-Reference_Banks</seealso>
    let NZD_Semi_Annual_Swap_Rate_BGCANTOR_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "NZD-Semi-Annual_Swap_Rate-BGCANTOR-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:NZD-Swap_Rate-ICAP-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"NZD-Swap Rate-ICAP-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NZD-Swap_Rate-ICAP-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/NZD-Swap_Rate-ICAP-Reference_Banks</seealso>
    let NZD_Swap_Rate_ICAP_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "NZD-Swap_Rate-ICAP-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:PHP-ORR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"PHP-ORR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PHP-ORR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PHP-ORR</seealso>
    let PHP_ORR = Prefixed_Name(fibo_ind_ir_cm, "PHP-ORR") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-cm:PHP-PHIREF</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"PHP-PHIREF"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PHP-PHIREF">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PHP-PHIREF</seealso>
    let PHP_PHIREF = Prefixed_Name(fibo_ind_ir_cm, "PHP-PHIREF") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-cm:PHP-PHIREF-BAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"PHP-PHIREF-BAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PHP-PHIREF-BAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PHP-PHIREF-BAP</seealso>
    let PHP_PHIREF_BAP = Prefixed_Name(fibo_ind_ir_cm, "PHP-PHIREF-BAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:PHP-PHIREF-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"PHP-PHIREF-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PHP-PHIREF-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PHP-PHIREF-Reference_Banks</seealso>
    let PHP_PHIREF_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "PHP-PHIREF-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:PHP-Semi-Annual_Swap_Rate-11_00-BGCANTOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"PHP-Semi-Annual Swap Rate-11:00-BGCANTOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PHP-Semi-Annual_Swap_Rate-11_00-BGCANTOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PHP-Semi-Annual_Swap_Rate-11_00-BGCANTOR</seealso>
    let PHP_Semi_Annual_Swap_Rate_11_00_BGCANTOR =
        Prefixed_Name(fibo_ind_ir_cm, "PHP-Semi-Annual_Swap_Rate-11_00-BGCANTOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:PHP-Semi-Annual_Swap_Rate-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"PHP-Semi-Annual Swap Rate-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PHP-Semi-Annual_Swap_Rate-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PHP-Semi-Annual_Swap_Rate-Reference_Banks</seealso>
    let PHP_Semi_Annual_Swap_Rate_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "PHP-Semi-Annual_Swap_Rate-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:PLN-POLONIA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"PLN-POLONIA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PLN-POLONIA">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PLN-POLONIA</seealso>
    let PLN_POLONIA = Prefixed_Name(fibo_ind_ir_cm, "PLN-POLONIA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:PLN-POLONIA-OIS_Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"PLN-POLONIA-OIS Compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PLN-POLONIA-OIS_Compound">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PLN-POLONIA-OIS_Compound</seealso>
    let PLN_POLONIA_OIS_Compound =
        Prefixed_Name(fibo_ind_ir_cm, "PLN-POLONIA-OIS_Compound") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:PLN-WIBID</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"PLN-WIBID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PLN-WIBID">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PLN-WIBID</seealso>
    let PLN_WIBID = Prefixed_Name(fibo_ind_ir_cm, "PLN-WIBID") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-cm:PLN-WIBOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"PLN-WIBOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PLN-WIBOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PLN-WIBOR</seealso>
    let PLN_WIBOR = Prefixed_Name(fibo_ind_ir_cm, "PLN-WIBOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:PLN-WIBOR-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"PLN-WIBOR-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PLN-WIBOR-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PLN-WIBOR-Reference_Banks</seealso>
    let PLN_WIBOR_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "PLN-WIBOR-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:PLN-WIRON</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"PLN-WIRON"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PLN-WIRON">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PLN-WIRON</seealso>
    let PLN_WIRON = Prefixed_Name(fibo_ind_ir_cm, "PLN-WIRON") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:PLN-WIRON-OIS_Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"PLN-WIRON-OIS Compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PLN-WIRON-OIS_Compound">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PLN-WIRON-OIS_Compound</seealso>
    let PLN_WIRON_OIS_Compound =
        Prefixed_Name(fibo_ind_ir_cm, "PLN-WIRON-OIS_Compound") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:PLZ-WIBOR-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"PLZ-WIBOR-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PLZ-WIBOR-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PLZ-WIBOR-Reference_Banks</seealso>
    let PLZ_WIBOR_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "PLZ-WIBOR-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:PLZ-WIBOR-WIBO</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"PLZ-WIBOR-WIBO"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PLZ-WIBOR-WIBO">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/PLZ-WIBOR-WIBO</seealso>
    let PLZ_WIBOR_WIBO = Prefixed_Name(fibo_ind_ir_cm, "PLZ-WIBOR-WIBO") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:REPOFUNDS_RATE-FRANCE-OIS-COMPOUND</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"REPOFUNDS RATE-FRANCE-OIS-COMPOUND"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/REPOFUNDS_RATE-FRANCE-OIS-COMPOUND">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/REPOFUNDS_RATE-FRANCE-OIS-COMPOUND</seealso>
    let REPOFUNDS_RATE_FRANCE_OIS_COMPOUND =
        Prefixed_Name(fibo_ind_ir_cm, "REPOFUNDS_RATE-FRANCE-OIS-COMPOUND") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:REPOFUNDS_RATE-GERMANY-OIS-COMPOUND</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"REPOFUNDS RATE-GERMANY-OIS-COMPOUND"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/REPOFUNDS_RATE-GERMANY-OIS-COMPOUND">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/REPOFUNDS_RATE-GERMANY-OIS-COMPOUND</seealso>
    let REPOFUNDS_RATE_GERMANY_OIS_COMPOUND =
        Prefixed_Name(fibo_ind_ir_cm, "REPOFUNDS_RATE-GERMANY-OIS-COMPOUND") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:REPOFUNDS_RATE-ITALY-OIS-COMPOUND</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"REPOFUNDS RATE-ITALY-OIS-COMPOUND"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/REPOFUNDS_RATE-ITALY-OIS-COMPOUND">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/REPOFUNDS_RATE-ITALY-OIS-COMPOUND</seealso>
    let REPOFUNDS_RATE_ITALY_OIS_COMPOUND =
        Prefixed_Name(fibo_ind_ir_cm, "REPOFUNDS_RATE-ITALY-OIS-COMPOUND") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:RON-Annual_Swap_Rate-11_00-BGCANTOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"RON-Annual Swap Rate-11:00-BGCANTOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RON-Annual_Swap_Rate-11_00-BGCANTOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RON-Annual_Swap_Rate-11_00-BGCANTOR</seealso>
    let RON_Annual_Swap_Rate_11_00_BGCANTOR =
        Prefixed_Name(fibo_ind_ir_cm, "RON-Annual_Swap_Rate-11_00-BGCANTOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:RON-Annual_Swap_Rate-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"RON-Annual Swap Rate-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RON-Annual_Swap_Rate-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RON-Annual_Swap_Rate-Reference_Banks</seealso>
    let RON_Annual_Swap_Rate_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "RON-Annual_Swap_Rate-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:RON-ROBID</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"RON-ROBID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RON-ROBID">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RON-ROBID</seealso>
    let RON_ROBID = Prefixed_Name(fibo_ind_ir_cm, "RON-ROBID") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-cm:RON-ROBOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"RON-ROBOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RON-ROBOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RON-ROBOR</seealso>
    let RON_ROBOR = Prefixed_Name(fibo_ind_ir_cm, "RON-ROBOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:RUB-Annual_Swap_Rate-11_00-BGCANTOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"RUB-Annual Swap Rate-11:00-BGCANTOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RUB-Annual_Swap_Rate-11_00-BGCANTOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RUB-Annual_Swap_Rate-11_00-BGCANTOR</seealso>
    let RUB_Annual_Swap_Rate_11_00_BGCANTOR =
        Prefixed_Name(fibo_ind_ir_cm, "RUB-Annual_Swap_Rate-11_00-BGCANTOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:RUB-Annual_Swap_Rate-12_45-TRADITION</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"RUB-Annual Swap Rate-12:45-TRADITION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RUB-Annual_Swap_Rate-12_45-TRADITION">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RUB-Annual_Swap_Rate-12_45-TRADITION</seealso>
    let RUB_Annual_Swap_Rate_12_45_TRADITION =
        Prefixed_Name(fibo_ind_ir_cm, "RUB-Annual_Swap_Rate-12_45-TRADITION") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:RUB-Annual_Swap_Rate-4_15-TRADITION</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"RUB-Annual Swap Rate-4:15-TRADITION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RUB-Annual_Swap_Rate-4_15-TRADITION">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RUB-Annual_Swap_Rate-4_15-TRADITION</seealso>
    let RUB_Annual_Swap_Rate_4_15_TRADITION =
        Prefixed_Name(fibo_ind_ir_cm, "RUB-Annual_Swap_Rate-4_15-TRADITION") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:RUB-Annual_Swap_Rate-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"RUB-Annual Swap Rate-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RUB-Annual_Swap_Rate-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RUB-Annual_Swap_Rate-Reference_Banks</seealso>
    let RUB_Annual_Swap_Rate_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "RUB-Annual_Swap_Rate-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:RUB-Annual_Swap_Rate-TRADITION-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"RUB-Annual Swap Rate-TRADITION-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RUB-Annual_Swap_Rate-TRADITION-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RUB-Annual_Swap_Rate-TRADITION-Reference_Banks</seealso>
    let RUB_Annual_Swap_Rate_TRADITION_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "RUB-Annual_Swap_Rate-TRADITION-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:RUB-Key_Rate_CBRF</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"RUB-Key Rate CBRF"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RUB-Key_Rate_CBRF">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RUB-Key_Rate_CBRF</seealso>
    let RUB_Key_Rate_CBRF =
        Prefixed_Name(fibo_ind_ir_cm, "RUB-Key_Rate_CBRF") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:RUB-MOSPRIME-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"RUB-MOSPRIME-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RUB-MOSPRIME-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RUB-MOSPRIME-Reference_Banks</seealso>
    let RUB_MOSPRIME_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "RUB-MOSPRIME-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:RUB-MosPrime</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"RUB-MosPrime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RUB-MosPrime">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RUB-MosPrime</seealso>
    let RUB_MosPrime = Prefixed_Name(fibo_ind_ir_cm, "RUB-MosPrime") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-cm:RUB-RUONIA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"RUB-RUONIA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RUB-RUONIA">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RUB-RUONIA</seealso>
    let RUB_RUONIA = Prefixed_Name(fibo_ind_ir_cm, "RUB-RUONIA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:RUB-RUONIA-OIS_Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"RUB-RUONIA-OIS Compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RUB-RUONIA-OIS_Compound">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/RUB-RUONIA-OIS_Compound</seealso>
    let RUB_RUONIA_OIS_Compound =
        Prefixed_Name(fibo_ind_ir_cm, "RUB-RUONIA-OIS_Compound") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SAR-SAIBOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"SAR-SAIBOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SAR-SAIBOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SAR-SAIBOR</seealso>
    let SAR_SAIBOR = Prefixed_Name(fibo_ind_ir_cm, "SAR-SAIBOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SAR-SRIOR-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"SAR-SRIOR-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SAR-SRIOR-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SAR-SRIOR-Reference_Banks</seealso>
    let SAR_SRIOR_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "SAR-SRIOR-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SEK-Annual_Swap_Rate</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"SEK-Annual Swap Rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-Annual_Swap_Rate">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-Annual_Swap_Rate</seealso>
    let SEK_Annual_Swap_Rate =
        Prefixed_Name(fibo_ind_ir_cm, "SEK-Annual_Swap_Rate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SEK-Annual_Swap_Rate-SESWFI</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"SEK-Annual Swap Rate-SESWFI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-Annual_Swap_Rate-SESWFI">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-Annual_Swap_Rate-SESWFI</seealso>
    let SEK_Annual_Swap_Rate_SESWFI =
        Prefixed_Name(fibo_ind_ir_cm, "SEK-Annual_Swap_Rate-SESWFI") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SEK-STIBOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"SEK-STIBOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-STIBOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-STIBOR</seealso>
    let SEK_STIBOR = Prefixed_Name(fibo_ind_ir_cm, "SEK-STIBOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SEK-STIBOR-OIS_Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"SEK-STIBOR-OIS Compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-STIBOR-OIS_Compound">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-STIBOR-OIS_Compound</seealso>
    let SEK_STIBOR_OIS_Compound =
        Prefixed_Name(fibo_ind_ir_cm, "SEK-STIBOR-OIS_Compound") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SEK-STIBOR-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"SEK-STIBOR-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-STIBOR-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-STIBOR-Reference_Banks</seealso>
    let SEK_STIBOR_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "SEK-STIBOR-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SEK-SWESTR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"SEK-SWESTR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-SWESTR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-SWESTR</seealso>
    let SEK_SWESTR = Prefixed_Name(fibo_ind_ir_cm, "SEK-SWESTR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SEK-SWESTR-OIS_Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"SEK-SWESTR-OIS Compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-SWESTR-OIS_Compound">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-SWESTR-OIS_Compound</seealso>
    let SEK_SWESTR_OIS_Compound =
        Prefixed_Name(fibo_ind_ir_cm, "SEK-SWESTR-OIS_Compound") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SEK-SWESTR_Average_1M</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"SEK-SWESTR Average 1M"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-SWESTR_Average_1M">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-SWESTR_Average_1M</seealso>
    let SEK_SWESTR_Average_1M =
        Prefixed_Name(fibo_ind_ir_cm, "SEK-SWESTR_Average_1M") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SEK-SWESTR_Average_1W</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"SEK-SWESTR Average 1W"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-SWESTR_Average_1W">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-SWESTR_Average_1W</seealso>
    let SEK_SWESTR_Average_1W =
        Prefixed_Name(fibo_ind_ir_cm, "SEK-SWESTR_Average_1W") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SEK-SWESTR_Average_2M</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"SEK-SWESTR Average 2M"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-SWESTR_Average_2M">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-SWESTR_Average_2M</seealso>
    let SEK_SWESTR_Average_2M =
        Prefixed_Name(fibo_ind_ir_cm, "SEK-SWESTR_Average_2M") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SEK-SWESTR_Average_3M</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"SEK-SWESTR Average 3M"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-SWESTR_Average_3M">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-SWESTR_Average_3M</seealso>
    let SEK_SWESTR_Average_3M =
        Prefixed_Name(fibo_ind_ir_cm, "SEK-SWESTR_Average_3M") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SEK-SWESTR_Average_6M</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"SEK-SWESTR Average 6M"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-SWESTR_Average_6M">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-SWESTR_Average_6M</seealso>
    let SEK_SWESTR_Average_6M =
        Prefixed_Name(fibo_ind_ir_cm, "SEK-SWESTR_Average_6M") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SEK-SWESTR_Compounded_Index</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"SEK-SWESTR Compounded Index"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-SWESTR_Compounded_Index">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SEK-SWESTR_Compounded_Index</seealso>
    let SEK_SWESTR_Compounded_Index =
        Prefixed_Name(fibo_ind_ir_cm, "SEK-SWESTR_Compounded_Index") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SGD-SIBOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"SGD-SIBOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-SIBOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-SIBOR</seealso>
    let SGD_SIBOR = Prefixed_Name(fibo_ind_ir_cm, "SGD-SIBOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SGD-SIBOR-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"SGD-SIBOR-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-SIBOR-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-SIBOR-Reference_Banks</seealso>
    let SGD_SIBOR_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "SGD-SIBOR-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SGD-SIBOR-Telerate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"SGD-SIBOR-Telerate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-SIBOR-Telerate">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-SIBOR-Telerate</seealso>
    let SGD_SIBOR_Telerate =
        Prefixed_Name(fibo_ind_ir_cm, "SGD-SIBOR-Telerate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SGD-SONAR-OIS-COMPOUND</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"SGD-SONAR-OIS-COMPOUND"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-SONAR-OIS-COMPOUND">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-SONAR-OIS-COMPOUND</seealso>
    let SGD_SONAR_OIS_COMPOUND =
        Prefixed_Name(fibo_ind_ir_cm, "SGD-SONAR-OIS-COMPOUND") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SGD-SOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"SGD-SOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-SOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-SOR</seealso>
    let SGD_SOR = Prefixed_Name(fibo_ind_ir_cm, "SGD-SOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SGD-SOR-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"SGD-SOR-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-SOR-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-SOR-Reference_Banks</seealso>
    let SGD_SOR_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "SGD-SOR-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SGD-SOR-Telerate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"SGD-SOR-Telerate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-SOR-Telerate">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-SOR-Telerate</seealso>
    let SGD_SOR_Telerate =
        Prefixed_Name(fibo_ind_ir_cm, "SGD-SOR-Telerate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SGD-SOR-VWAP-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"SGD-SOR-VWAP-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-SOR-VWAP-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-SOR-VWAP-Reference_Banks</seealso>
    let SGD_SOR_VWAP_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "SGD-SOR-VWAP-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SGD-SORA</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"SGD-SORA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-SORA">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-SORA</seealso>
    let SGD_SORA = Prefixed_Name(fibo_ind_ir_cm, "SGD-SORA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SGD-SORA-OIS_Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"SGD-SORA-OIS Compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-SORA-OIS_Compound">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-SORA-OIS_Compound</seealso>
    let SGD_SORA_OIS_Compound =
        Prefixed_Name(fibo_ind_ir_cm, "SGD-SORA-OIS_Compound") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SGD-Semi-Annual_Currency_Basis_Swap_Rate-11_00-Tullett_Prebon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"SGD-Semi-Annual Currency Basis Swap Rate-11:00-Tullett Prebon"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-Semi-Annual_Currency_Basis_Swap_Rate-11_00-Tullett_Prebon">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-Semi-Annual_Currency_Basis_Swap_Rate-11_00-Tullett_Prebon</seealso>
    let SGD_Semi_Annual_Currency_Basis_Swap_Rate_11_00_Tullett_Prebon =
        Prefixed_Name(fibo_ind_ir_cm, "SGD-Semi-Annual_Currency_Basis_Swap_Rate-11_00-Tullett_Prebon") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SGD-Semi-Annual_Currency_Basis_Swap_Rate-16_00-Tullett_Prebon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"SGD-Semi-Annual Currency Basis Swap Rate-16:00-Tullett Prebon"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-Semi-Annual_Currency_Basis_Swap_Rate-16_00-Tullett_Prebon">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-Semi-Annual_Currency_Basis_Swap_Rate-16_00-Tullett_Prebon</seealso>
    let SGD_Semi_Annual_Currency_Basis_Swap_Rate_16_00_Tullett_Prebon =
        Prefixed_Name(fibo_ind_ir_cm, "SGD-Semi-Annual_Currency_Basis_Swap_Rate-16_00-Tullett_Prebon") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SGD-Semi-Annual_Swap_Rate-11.00-TRADITION</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"SGD-Semi-Annual Swap Rate-11.00-TRADITION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-Semi-Annual_Swap_Rate-11.00-TRADITION">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-Semi-Annual_Swap_Rate-11.00-TRADITION</seealso>
    let ``SGD_Semi_Annual_Swap_Rate_11.00_TRADITION`` =
        Prefixed_Name(fibo_ind_ir_cm, "SGD-Semi-Annual_Swap_Rate-11.00-TRADITION") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SGD-Semi-Annual_Swap_Rate-11_00-BGCANTOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"SGD-Semi-Annual Swap Rate-11:00-BGCANTOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-Semi-Annual_Swap_Rate-11_00-BGCANTOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-Semi-Annual_Swap_Rate-11_00-BGCANTOR</seealso>
    let SGD_Semi_Annual_Swap_Rate_11_00_BGCANTOR =
        Prefixed_Name(fibo_ind_ir_cm, "SGD-Semi-Annual_Swap_Rate-11_00-BGCANTOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SGD-Semi-Annual_Swap_Rate-11_00-Tullett_Prebon</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"SGD-Semi-Annual Swap Rate-11:00-Tullett Prebon"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-Semi-Annual_Swap_Rate-11_00-Tullett_Prebon">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-Semi-Annual_Swap_Rate-11_00-Tullett_Prebon</seealso>
    let SGD_Semi_Annual_Swap_Rate_11_00_Tullett_Prebon =
        Prefixed_Name(fibo_ind_ir_cm, "SGD-Semi-Annual_Swap_Rate-11_00-Tullett_Prebon") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SGD-Semi-Annual_Swap_Rate-16_00-Tullett_Prebon</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"SGD-Semi-Annual Swap Rate-16:00-Tullett Prebon"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-Semi-Annual_Swap_Rate-16_00-Tullett_Prebon">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-Semi-Annual_Swap_Rate-16_00-Tullett_Prebon</seealso>
    let SGD_Semi_Annual_Swap_Rate_16_00_Tullett_Prebon =
        Prefixed_Name(fibo_ind_ir_cm, "SGD-Semi-Annual_Swap_Rate-16_00-Tullett_Prebon") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SGD-Semi-Annual_Swap_Rate-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"SGD-Semi-Annual Swap Rate-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-Semi-Annual_Swap_Rate-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-Semi-Annual_Swap_Rate-ICAP</seealso>
    let SGD_Semi_Annual_Swap_Rate_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "SGD-Semi-Annual_Swap_Rate-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SGD-Semi-Annual_Swap_Rate-ICAP-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"SGD-Semi-Annual Swap Rate-ICAP-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-Semi-Annual_Swap_Rate-ICAP-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-Semi-Annual_Swap_Rate-ICAP-Reference_Banks</seealso>
    let SGD_Semi_Annual_Swap_Rate_ICAP_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "SGD-Semi-Annual_Swap_Rate-ICAP-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SGD-Semi-Annual_Swap_Rate-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"SGD-Semi-Annual Swap Rate-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-Semi-Annual_Swap_Rate-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-Semi-Annual_Swap_Rate-Reference_Banks</seealso>
    let SGD_Semi_Annual_Swap_Rate_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "SGD-Semi-Annual_Swap_Rate-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SGD-Semi-Annual_Swap_Rate-TRADITION-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"SGD-Semi-Annual Swap Rate-TRADITION-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-Semi-Annual_Swap_Rate-TRADITION-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SGD-Semi-Annual_Swap_Rate-TRADITION-Reference_Banks</seealso>
    let SGD_Semi_Annual_Swap_Rate_TRADITION_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "SGD-Semi-Annual_Swap_Rate-TRADITION-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SKK-BRIBOR-BRBO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"SKK-BRIBOR-BRBO"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SKK-BRIBOR-BRBO">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SKK-BRIBOR-BRBO</seealso>
    let SKK_BRIBOR_BRBO =
        Prefixed_Name(fibo_ind_ir_cm, "SKK-BRIBOR-BRBO") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SKK-BRIBOR-Bloomberg</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"SKK-BRIBOR-Bloomberg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SKK-BRIBOR-Bloomberg">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SKK-BRIBOR-Bloomberg</seealso>
    let SKK_BRIBOR_Bloomberg =
        Prefixed_Name(fibo_ind_ir_cm, "SKK-BRIBOR-Bloomberg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SKK-BRIBOR-NBSK07</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"SKK-BRIBOR-NBSK07"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SKK-BRIBOR-NBSK07">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SKK-BRIBOR-NBSK07</seealso>
    let SKK_BRIBOR_NBSK07 =
        Prefixed_Name(fibo_ind_ir_cm, "SKK-BRIBOR-NBSK07") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:SKK-BRIBOR-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"SKK-BRIBOR-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SKK-BRIBOR-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/SKK-BRIBOR-Reference_Banks</seealso>
    let SKK_BRIBOR_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "SKK-BRIBOR-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:THB-SOR-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"THB-SOR-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/THB-SOR-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/THB-SOR-Reference_Banks</seealso>
    let THB_SOR_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "THB-SOR-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:THB-SOR-Reuters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"THB-SOR-Reuters"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/THB-SOR-Reuters">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/THB-SOR-Reuters</seealso>
    let THB_SOR_Reuters =
        Prefixed_Name(fibo_ind_ir_cm, "THB-SOR-Reuters") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:THB-SOR-Telerate</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"THB-SOR-Telerate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/THB-SOR-Telerate">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/THB-SOR-Telerate</seealso>
    let THB_SOR_Telerate =
        Prefixed_Name(fibo_ind_ir_cm, "THB-SOR-Telerate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:THB-Semi-Annual_Swap_Rate-11_00-BGCANTOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"THB-Semi-Annual Swap Rate-11:00-BGCANTOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/THB-Semi-Annual_Swap_Rate-11_00-BGCANTOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/THB-Semi-Annual_Swap_Rate-11_00-BGCANTOR</seealso>
    let THB_Semi_Annual_Swap_Rate_11_00_BGCANTOR =
        Prefixed_Name(fibo_ind_ir_cm, "THB-Semi-Annual_Swap_Rate-11_00-BGCANTOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:THB-Semi-Annual_Swap_Rate-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"THB-Semi-Annual Swap Rate-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/THB-Semi-Annual_Swap_Rate-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/THB-Semi-Annual_Swap_Rate-Reference_Banks</seealso>
    let THB_Semi_Annual_Swap_Rate_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "THB-Semi-Annual_Swap_Rate-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:THB-THBFIX</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"THB-THBFIX"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/THB-THBFIX">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/THB-THBFIX</seealso>
    let THB_THBFIX = Prefixed_Name(fibo_ind_ir_cm, "THB-THBFIX") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:THB-THBFIX-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"THB-THBFIX-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/THB-THBFIX-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/THB-THBFIX-Reference_Banks</seealso>
    let THB_THBFIX_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "THB-THBFIX-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:THB-THOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"THB-THOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/THB-THOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/THB-THOR</seealso>
    let THB_THOR = Prefixed_Name(fibo_ind_ir_cm, "THB-THOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:THB-THOR-OIS_Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"THB-THOR-OIS Compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/THB-THOR-OIS_Compound">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/THB-THOR-OIS_Compound</seealso>
    let THB_THOR_OIS_Compound =
        Prefixed_Name(fibo_ind_ir_cm, "THB-THOR-OIS_Compound") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:TRY-Annual_Swap_Rate-11_15-BGCANTOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"TRY-Annual Swap Rate-11:15-BGCANTOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TRY-Annual_Swap_Rate-11_15-BGCANTOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TRY-Annual_Swap_Rate-11_15-BGCANTOR</seealso>
    let TRY_Annual_Swap_Rate_11_15_BGCANTOR =
        Prefixed_Name(fibo_ind_ir_cm, "TRY-Annual_Swap_Rate-11_15-BGCANTOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:TRY-Annual_Swap_Rate-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"TRY-Annual Swap Rate-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TRY-Annual_Swap_Rate-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TRY-Annual_Swap_Rate-Reference_Banks</seealso>
    let TRY_Annual_Swap_Rate_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "TRY-Annual_Swap_Rate-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:TRY-Semi-Annual_Swap_Rate-TRADITION-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"TRY-Semi-Annual Swap Rate-TRADITION-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TRY-Semi-Annual_Swap_Rate-TRADITION-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TRY-Semi-Annual_Swap_Rate-TRADITION-Reference_Banks</seealso>
    let TRY_Semi_Annual_Swap_Rate_TRADITION_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "TRY-Semi-Annual_Swap_Rate-TRADITION-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:TRY-TLREF</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"TRY-TLREF"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TRY-TLREF">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TRY-TLREF</seealso>
    let TRY_TLREF = Prefixed_Name(fibo_ind_ir_cm, "TRY-TLREF") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:TRY-TLREF-OIS_Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"TRY-TLREF-OIS Compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TRY-TLREF-OIS_Compound">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TRY-TLREF-OIS_Compound</seealso>
    let TRY_TLREF_OIS_Compound =
        Prefixed_Name(fibo_ind_ir_cm, "TRY-TLREF-OIS_Compound") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:TRY-TRLIBOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"TRY-TRLIBOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TRY-TRLIBOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TRY-TRLIBOR</seealso>
    let TRY_TRLIBOR = Prefixed_Name(fibo_ind_ir_cm, "TRY-TRLIBOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:TRY-TRYIBOR-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"TRY-TRYIBOR-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TRY-TRYIBOR-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TRY-TRYIBOR-Reference_Banks</seealso>
    let TRY_TRYIBOR_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "TRY-TRYIBOR-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:TRY_Annual_Swap_Rate-11_00-TRADITION</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"TRY Annual Swap Rate-11:00-TRADITION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TRY_Annual_Swap_Rate-11_00-TRADITION">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TRY_Annual_Swap_Rate-11_00-TRADITION</seealso>
    let TRY_Annual_Swap_Rate_11_00_TRADITION =
        Prefixed_Name(fibo_ind_ir_cm, "TRY_Annual_Swap_Rate-11_00-TRADITION") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:TWD-Quarterly-Annual_Swap_Rate-11_00-BGCANTOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"TWD-Quarterly-Annual Swap Rate-11:00-BGCANTOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TWD-Quarterly-Annual_Swap_Rate-11_00-BGCANTOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TWD-Quarterly-Annual_Swap_Rate-11_00-BGCANTOR</seealso>
    let TWD_Quarterly_Annual_Swap_Rate_11_00_BGCANTOR =
        Prefixed_Name(fibo_ind_ir_cm, "TWD-Quarterly-Annual_Swap_Rate-11_00-BGCANTOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:TWD-Quarterly-Annual_Swap_Rate-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"TWD-Quarterly-Annual Swap Rate-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TWD-Quarterly-Annual_Swap_Rate-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TWD-Quarterly-Annual_Swap_Rate-Reference_Banks</seealso>
    let TWD_Quarterly_Annual_Swap_Rate_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "TWD-Quarterly-Annual_Swap_Rate-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:TWD-Reference_Dealers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"TWD-Reference Dealers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TWD-Reference_Dealers">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TWD-Reference_Dealers</seealso>
    let TWD_Reference_Dealers =
        Prefixed_Name(fibo_ind_ir_cm, "TWD-Reference_Dealers") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:TWD-Reuters-6165</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"TWD-Reuters-6165"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TWD-Reuters-6165">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TWD-Reuters-6165</seealso>
    let TWD_Reuters_6165 =
        Prefixed_Name(fibo_ind_ir_cm, "TWD-Reuters-6165") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:TWD-TAIBIR01</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"TWD-TAIBIR01"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TWD-TAIBIR01">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TWD-TAIBIR01</seealso>
    let TWD_TAIBIR01 = Prefixed_Name(fibo_ind_ir_cm, "TWD-TAIBIR01") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-cm:TWD-TAIBIR02</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"TWD-TAIBIR02"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TWD-TAIBIR02">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TWD-TAIBIR02</seealso>
    let TWD_TAIBIR02 = Prefixed_Name(fibo_ind_ir_cm, "TWD-TAIBIR02") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-cm:TWD-TAIBOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"TWD-TAIBOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TWD-TAIBOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TWD-TAIBOR</seealso>
    let TWD_TAIBOR = Prefixed_Name(fibo_ind_ir_cm, "TWD-TAIBOR") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-cm:TWD-TWCPBA</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"TWD-TWCPBA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TWD-TWCPBA">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TWD-TWCPBA</seealso>
    let TWD_TWCPBA = Prefixed_Name(fibo_ind_ir_cm, "TWD-TWCPBA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:TWD-Telerate-6165</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"TWD-Telerate-6165"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TWD-Telerate-6165">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/TWD-Telerate-6165</seealso>
    let TWD_Telerate_6165 =
        Prefixed_Name(fibo_ind_ir_cm, "TWD-Telerate-6165") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-3M_LIBOR_SWAP-CME_vs_LCH-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"USD-3M LIBOR SWAP-CME vs LCH-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-3M_LIBOR_SWAP-CME_vs_LCH-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-3M_LIBOR_SWAP-CME_vs_LCH-ICAP</seealso>
    let USD_3M_LIBOR_SWAP_CME_vs_LCH_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "USD-3M_LIBOR_SWAP-CME_vs_LCH-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-3M_LIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-3M LIBOR SWAP-CME vs LCH-ICAP-Bloomberg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-3M_LIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-3M_LIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg</seealso>
    let USD_3M_LIBOR_SWAP_CME_vs_LCH_ICAP_Bloomberg =
        Prefixed_Name(fibo_ind_ir_cm, "USD-3M_LIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-6M_LIBOR_SWAP-CME_vs_LCH-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"USD-6M LIBOR SWAP-CME vs LCH-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-6M_LIBOR_SWAP-CME_vs_LCH-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-6M_LIBOR_SWAP-CME_vs_LCH-ICAP</seealso>
    let USD_6M_LIBOR_SWAP_CME_vs_LCH_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "USD-6M_LIBOR_SWAP-CME_vs_LCH-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-6M_LIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-6M LIBOR SWAP-CME vs LCH-ICAP-Bloomberg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-6M_LIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-6M_LIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg</seealso>
    let USD_6M_LIBOR_SWAP_CME_vs_LCH_ICAP_Bloomberg =
        Prefixed_Name(fibo_ind_ir_cm, "USD-6M_LIBOR_SWAP-CME_vs_LCH-ICAP-Bloomberg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-AMERIBOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-AMERIBOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-AMERIBOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-AMERIBOR</seealso>
    let USD_AMERIBOR = Prefixed_Name(fibo_ind_ir_cm, "USD-AMERIBOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-AMERIBOR_Average_30D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"USD-AMERIBOR Average 30D"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-AMERIBOR_Average_30D">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-AMERIBOR_Average_30D</seealso>
    let USD_AMERIBOR_Average_30D =
        Prefixed_Name(fibo_ind_ir_cm, "USD-AMERIBOR_Average_30D") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-AMERIBOR_Average_90D</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-AMERIBOR Average 90D"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-AMERIBOR_Average_90D">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-AMERIBOR_Average_90D</seealso>
    let USD_AMERIBOR_Average_90D =
        Prefixed_Name(fibo_ind_ir_cm, "USD-AMERIBOR_Average_90D") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-AMERIBOR_Term</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"USD-AMERIBOR Term"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-AMERIBOR_Term">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-AMERIBOR_Term</seealso>
    let USD_AMERIBOR_Term =
        Prefixed_Name(fibo_ind_ir_cm, "USD-AMERIBOR_Term") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-AMERIBOR_Term_Structure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"USD-AMERIBOR Term Structure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-AMERIBOR_Term_Structure">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-AMERIBOR_Term_Structure</seealso>
    let USD_AMERIBOR_Term_Structure =
        Prefixed_Name(fibo_ind_ir_cm, "USD-AMERIBOR_Term_Structure") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-AXI_Term</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-AXI Term"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-AXI_Term">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-AXI_Term</seealso>
    let USD_AXI_Term = Prefixed_Name(fibo_ind_ir_cm, "USD-AXI_Term") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-Annual_Swap_Rate-11_00-BGCANTOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"USD-Annual Swap Rate-11:00-BGCANTOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Annual_Swap_Rate-11_00-BGCANTOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Annual_Swap_Rate-11_00-BGCANTOR</seealso>
    let USD_Annual_Swap_Rate_11_00_BGCANTOR =
        Prefixed_Name(fibo_ind_ir_cm, "USD-Annual_Swap_Rate-11_00-BGCANTOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-Annual_Swap_Rate-11_00-TRADITION</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"USD-Annual Swap Rate-11:00-TRADITION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Annual_Swap_Rate-11_00-TRADITION">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Annual_Swap_Rate-11_00-TRADITION</seealso>
    let USD_Annual_Swap_Rate_11_00_TRADITION =
        Prefixed_Name(fibo_ind_ir_cm, "USD-Annual_Swap_Rate-11_00-TRADITION") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-Annual_Swap_Rate-4_00-TRADITION</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-Annual Swap Rate-4:00-TRADITION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Annual_Swap_Rate-4_00-TRADITION">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Annual_Swap_Rate-4_00-TRADITION</seealso>
    let USD_Annual_Swap_Rate_4_00_TRADITION =
        Prefixed_Name(fibo_ind_ir_cm, "USD-Annual_Swap_Rate-4_00-TRADITION") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-BA-H.15</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"USD-BA-H.15"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-BA-H.15">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-BA-H.15</seealso>
    let ``USD_BA_H.15`` = Prefixed_Name(fibo_ind_ir_cm, "USD-BA-H.15") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-BA-Reference_Dealers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"USD-BA-Reference Dealers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-BA-Reference_Dealers">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-BA-Reference_Dealers</seealso>
    let USD_BA_Reference_Dealers =
        Prefixed_Name(fibo_ind_ir_cm, "USD-BA-Reference_Dealers") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-BMA_Municipal_Swap_Index</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-BMA Municipal Swap Index"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-BMA_Municipal_Swap_Index">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-BMA_Municipal_Swap_Index</seealso>
    let USD_BMA_Municipal_Swap_Index =
        Prefixed_Name(fibo_ind_ir_cm, "USD-BMA_Municipal_Swap_Index") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-BSBY</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-BSBY"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-BSBY">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-BSBY</seealso>
    let USD_BSBY = Prefixed_Name(fibo_ind_ir_cm, "USD-BSBY") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-CD-H.15</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-CD-H.15"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-CD-H.15">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-CD-H.15</seealso>
    let ``USD_CD_H.15`` = Prefixed_Name(fibo_ind_ir_cm, "USD-CD-H.15") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-CD-Reference_Dealers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"USD-CD-Reference Dealers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-CD-Reference_Dealers">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-CD-Reference_Dealers</seealso>
    let USD_CD_Reference_Dealers =
        Prefixed_Name(fibo_ind_ir_cm, "USD-CD-Reference_Dealers") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-CMS-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"USD-CMS-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-CMS-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-CMS-Reference_Banks</seealso>
    let USD_CMS_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "USD-CMS-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-CMS-Reference_Banks-ICAP_SwapPX</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"USD-CMS-Reference Banks-ICAP SwapPX"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-CMS-Reference_Banks-ICAP_SwapPX">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-CMS-Reference_Banks-ICAP_SwapPX</seealso>
    let USD_CMS_Reference_Banks_ICAP_SwapPX =
        Prefixed_Name(fibo_ind_ir_cm, "USD-CMS-Reference_Banks-ICAP_SwapPX") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-CMS-Reuters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"USD-CMS-Reuters"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-CMS-Reuters">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-CMS-Reuters</seealso>
    let USD_CMS_Reuters =
        Prefixed_Name(fibo_ind_ir_cm, "USD-CMS-Reuters") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-CMS-Telerate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"USD-CMS-Telerate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-CMS-Telerate">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-CMS-Telerate</seealso>
    let USD_CMS_Telerate =
        Prefixed_Name(fibo_ind_ir_cm, "USD-CMS-Telerate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-CMT</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-CMT"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-CMT">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-CMT</seealso>
    let USD_CMT = Prefixed_Name(fibo_ind_ir_cm, "USD-CMT") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-CMT_Average_1W</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"USD-CMT Average 1W"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-CMT_Average_1W">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-CMT_Average_1W</seealso>
    let USD_CMT_Average_1W =
        Prefixed_Name(fibo_ind_ir_cm, "USD-CMT_Average_1W") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-COF11-Telerate</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-COF11-Telerate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-COF11-Telerate">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-COF11-Telerate</seealso>
    let USD_COF11_Telerate =
        Prefixed_Name(fibo_ind_ir_cm, "USD-COF11-Telerate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-COFI</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-COFI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-COFI">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-COFI</seealso>
    let USD_COFI = Prefixed_Name(fibo_ind_ir_cm, "USD-COFI") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-CP-Money_Market_Yield</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"USD-CP-Money Market Yield"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-CP-Money_Market_Yield">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-CP-Money_Market_Yield</seealso>
    let USD_CP_Money_Market_Yield =
        Prefixed_Name(fibo_ind_ir_cm, "USD-CP-Money_Market_Yield") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-CP-Reference_Dealers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"USD-CP-Reference Dealers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-CP-Reference_Dealers">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-CP-Reference_Dealers</seealso>
    let USD_CP_Reference_Dealers =
        Prefixed_Name(fibo_ind_ir_cm, "USD-CP-Reference_Dealers") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-CRITR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-CRITR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-CRITR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-CRITR</seealso>
    let USD_CRITR = Prefixed_Name(fibo_ind_ir_cm, "USD-CRITR") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-FFCB-DISCO</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-FFCB-DISCO"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-FFCB-DISCO">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-FFCB-DISCO</seealso>
    let USD_FFCB_DISCO = Prefixed_Name(fibo_ind_ir_cm, "USD-FFCB-DISCO") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-FXI_Term</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"USD-FXI Term"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-FXI_Term">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-FXI_Term</seealso>
    let USD_FXI_Term = Prefixed_Name(fibo_ind_ir_cm, "USD-FXI_Term") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-Federal_Funds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"USD-Federal Funds"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Federal_Funds">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Federal_Funds</seealso>
    let USD_Federal_Funds =
        Prefixed_Name(fibo_ind_ir_cm, "USD-Federal_Funds") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-Federal_Funds-OIS_Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-Federal Funds-OIS Compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Federal_Funds-OIS_Compound">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Federal_Funds-OIS_Compound</seealso>
    let USD_Federal_Funds_OIS_Compound =
        Prefixed_Name(fibo_ind_ir_cm, "USD-Federal_Funds-OIS_Compound") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-Federal_Funds-Reference_Dealers</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-Federal Funds-Reference Dealers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Federal_Funds-Reference_Dealers">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Federal_Funds-Reference_Dealers</seealso>
    let USD_Federal_Funds_Reference_Dealers =
        Prefixed_Name(fibo_ind_ir_cm, "USD-Federal_Funds-Reference_Dealers") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-LIBOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-LIBOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-LIBOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-LIBOR</seealso>
    let USD_LIBOR = Prefixed_Name(fibo_ind_ir_cm, "USD-LIBOR") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-LIBOR-ISDA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"USD-LIBOR-ISDA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-LIBOR-ISDA">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-LIBOR-ISDA</seealso>
    let USD_LIBOR_ISDA = Prefixed_Name(fibo_ind_ir_cm, "USD-LIBOR-ISDA") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-LIBOR-LIBO</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-LIBOR-LIBO"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-LIBOR-LIBO">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-LIBOR-LIBO</seealso>
    let USD_LIBOR_LIBO = Prefixed_Name(fibo_ind_ir_cm, "USD-LIBOR-LIBO") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-LIBOR-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"USD-LIBOR-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-LIBOR-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-LIBOR-Reference_Banks</seealso>
    let USD_LIBOR_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "USD-LIBOR-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-LIBOR_ICE_Swap_Rate-11_00</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-LIBOR ICE Swap Rate-11:00"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-LIBOR_ICE_Swap_Rate-11_00">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-LIBOR_ICE_Swap_Rate-11_00</seealso>
    let USD_LIBOR_ICE_Swap_Rate_11_00 =
        Prefixed_Name(fibo_ind_ir_cm, "USD-LIBOR_ICE_Swap_Rate-11_00") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-LIBOR_ICE_Swap_Rate-15_00</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-LIBOR ICE Swap Rate-15:00"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-LIBOR_ICE_Swap_Rate-15_00">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-LIBOR_ICE_Swap_Rate-15_00</seealso>
    let USD_LIBOR_ICE_Swap_Rate_15_00 =
        Prefixed_Name(fibo_ind_ir_cm, "USD-LIBOR_ICE_Swap_Rate-15_00") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-Municipal_Swap_Index</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"USD-Municipal Swap Index"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Municipal_Swap_Index">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Municipal_Swap_Index</seealso>
    let USD_Municipal_Swap_Index =
        Prefixed_Name(fibo_ind_ir_cm, "USD-Municipal_Swap_Index") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-Municipal_Swap_Libor_Ratio-11_00-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-Municipal Swap Libor Ratio-11:00-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Municipal_Swap_Libor_Ratio-11_00-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Municipal_Swap_Libor_Ratio-11_00-ICAP</seealso>
    let USD_Municipal_Swap_Libor_Ratio_11_00_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "USD-Municipal_Swap_Libor_Ratio-11_00-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-Municipal_Swap_Rate-11_00-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-Municipal Swap Rate-11:00-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Municipal_Swap_Rate-11_00-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Municipal_Swap_Rate-11_00-ICAP</seealso>
    let USD_Municipal_Swap_Rate_11_00_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "USD-Municipal_Swap_Rate-11_00-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-OIS-11_00-BGCANTOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-OIS-11:00-BGCANTOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-OIS-11_00-BGCANTOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-OIS-11_00-BGCANTOR</seealso>
    let USD_OIS_11_00_BGCANTOR =
        Prefixed_Name(fibo_ind_ir_cm, "USD-OIS-11_00-BGCANTOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-OIS-11_00-LON-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-OIS-11:00-LON-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-OIS-11_00-LON-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-OIS-11_00-LON-ICAP</seealso>
    let USD_OIS_11_00_LON_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "USD-OIS-11_00-LON-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-OIS-11_00-NY-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-OIS-11:00-NY-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-OIS-11_00-NY-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-OIS-11_00-NY-ICAP</seealso>
    let USD_OIS_11_00_NY_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "USD-OIS-11_00-NY-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-OIS-11_00-TRADITION</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"USD-OIS-11:00-TRADITION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-OIS-11_00-TRADITION">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-OIS-11_00-TRADITION</seealso>
    let USD_OIS_11_00_TRADITION =
        Prefixed_Name(fibo_ind_ir_cm, "USD-OIS-11_00-TRADITION") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-OIS-3_00-BGCANTOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-OIS-3:00-BGCANTOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-OIS-3_00-BGCANTOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-OIS-3_00-BGCANTOR</seealso>
    let USD_OIS_3_00_BGCANTOR =
        Prefixed_Name(fibo_ind_ir_cm, "USD-OIS-3_00-BGCANTOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-OIS-3_00-NY-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"USD-OIS-3:00-NY-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-OIS-3_00-NY-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-OIS-3_00-NY-ICAP</seealso>
    let USD_OIS_3_00_NY_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "USD-OIS-3_00-NY-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-OIS-4_00-TRADITION</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-OIS-4:00-TRADITION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-OIS-4_00-TRADITION">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-OIS-4_00-TRADITION</seealso>
    let USD_OIS_4_00_TRADITION =
        Prefixed_Name(fibo_ind_ir_cm, "USD-OIS-4_00-TRADITION") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-Overnight_Bank_Funding_Rate</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-Overnight Bank Funding Rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Overnight_Bank_Funding_Rate">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Overnight_Bank_Funding_Rate</seealso>
    let USD_Overnight_Bank_Funding_Rate =
        Prefixed_Name(fibo_ind_ir_cm, "USD-Overnight_Bank_Funding_Rate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-Prime</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-Prime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Prime">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Prime</seealso>
    let USD_Prime = Prefixed_Name(fibo_ind_ir_cm, "USD-Prime") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-Prime-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"USD-Prime-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Prime-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Prime-Reference_Banks</seealso>
    let USD_Prime_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "USD-Prime-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-SIBOR-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-SIBOR-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SIBOR-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SIBOR-Reference_Banks</seealso>
    let USD_SIBOR_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "USD-SIBOR-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-SIBOR-SIBO</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-SIBOR-SIBO"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SIBOR-SIBO">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SIBOR-SIBO</seealso>
    let USD_SIBOR_SIBO = Prefixed_Name(fibo_ind_ir_cm, "USD-SIBOR-SIBO") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-SOFR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"USD-SOFR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR</seealso>
    let USD_SOFR = Prefixed_Name(fibo_ind_ir_cm, "USD-SOFR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-SOFR-OIS_Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-SOFR-OIS Compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR-OIS_Compound">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR-OIS_Compound</seealso>
    let USD_SOFR_OIS_Compound =
        Prefixed_Name(fibo_ind_ir_cm, "USD-SOFR-OIS_Compound") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-SOFR_Average_180D</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-SOFR Average 180D"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_Average_180D">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_Average_180D</seealso>
    let USD_SOFR_Average_180D =
        Prefixed_Name(fibo_ind_ir_cm, "USD-SOFR_Average_180D") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-SOFR_Average_30D</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-SOFR Average 30D"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_Average_30D">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_Average_30D</seealso>
    let USD_SOFR_Average_30D =
        Prefixed_Name(fibo_ind_ir_cm, "USD-SOFR_Average_30D") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-SOFR_Average_90D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"USD-SOFR Average 90D"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_Average_90D">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_Average_90D</seealso>
    let USD_SOFR_Average_90D =
        Prefixed_Name(fibo_ind_ir_cm, "USD-SOFR_Average_90D") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-SOFR_CME_Term</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"USD-SOFR CME Term"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_CME_Term">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_CME_Term</seealso>
    let USD_SOFR_CME_Term =
        Prefixed_Name(fibo_ind_ir_cm, "USD-SOFR_CME_Term") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-SOFR_Compounded_Index</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-SOFR Compounded Index"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_Compounded_Index">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_Compounded_Index</seealso>
    let USD_SOFR_Compounded_Index =
        Prefixed_Name(fibo_ind_ir_cm, "USD-SOFR_Compounded_Index") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-SOFR_ICE_Compounded_Index</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"USD-SOFR ICE Compounded Index"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_ICE_Compounded_Index">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_ICE_Compounded_Index</seealso>
    let USD_SOFR_ICE_Compounded_Index =
        Prefixed_Name(fibo_ind_ir_cm, "USD-SOFR_ICE_Compounded_Index") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-SOFR_ICE_Compounded_Index_0_Floor</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-SOFR ICE Compounded Index 0 Floor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_ICE_Compounded_Index_0_Floor">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_ICE_Compounded_Index_0_Floor</seealso>
    let USD_SOFR_ICE_Compounded_Index_0_Floor =
        Prefixed_Name(fibo_ind_ir_cm, "USD-SOFR_ICE_Compounded_Index_0_Floor") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-SOFR_ICE_Compounded_Index_0_Floor_2D_Lag</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-SOFR ICE Compounded Index 0 Floor 2D Lag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_ICE_Compounded_Index_0_Floor_2D_Lag">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_ICE_Compounded_Index_0_Floor_2D_Lag</seealso>
    let USD_SOFR_ICE_Compounded_Index_0_Floor_2D_Lag =
        Prefixed_Name(fibo_ind_ir_cm, "USD-SOFR_ICE_Compounded_Index_0_Floor_2D_Lag") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-SOFR_ICE_Compounded_Index_0_Floor_5D_Lag</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-SOFR ICE Compounded Index 0 Floor 5D Lag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_ICE_Compounded_Index_0_Floor_5D_Lag">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_ICE_Compounded_Index_0_Floor_5D_Lag</seealso>
    let USD_SOFR_ICE_Compounded_Index_0_Floor_5D_Lag =
        Prefixed_Name(fibo_ind_ir_cm, "USD-SOFR_ICE_Compounded_Index_0_Floor_5D_Lag") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-SOFR_ICE_Compounded_Index_2D_Lag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"USD-SOFR ICE Compounded Index 2D Lag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_ICE_Compounded_Index_2D_Lag">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_ICE_Compounded_Index_2D_Lag</seealso>
    let USD_SOFR_ICE_Compounded_Index_2D_Lag =
        Prefixed_Name(fibo_ind_ir_cm, "USD-SOFR_ICE_Compounded_Index_2D_Lag") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-SOFR_ICE_Compounded_Index_5D_Lag</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-SOFR ICE Compounded Index 5D Lag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_ICE_Compounded_Index_5D_Lag">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_ICE_Compounded_Index_5D_Lag</seealso>
    let USD_SOFR_ICE_Compounded_Index_5D_Lag =
        Prefixed_Name(fibo_ind_ir_cm, "USD-SOFR_ICE_Compounded_Index_5D_Lag") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-SOFR_ICE_Swap_Rate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"USD-SOFR ICE Swap Rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_ICE_Swap_Rate">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_ICE_Swap_Rate</seealso>
    let USD_SOFR_ICE_Swap_Rate =
        Prefixed_Name(fibo_ind_ir_cm, "USD-SOFR_ICE_Swap_Rate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-SOFR_ICE_Swap_Rate_Spreads</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"USD-SOFR ICE Swap Rate Spreads"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_ICE_Swap_Rate_Spreads">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_ICE_Swap_Rate_Spreads</seealso>
    let USD_SOFR_ICE_Swap_Rate_Spreads =
        Prefixed_Name(fibo_ind_ir_cm, "USD-SOFR_ICE_Swap_Rate_Spreads") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-SOFR_ICE_Term</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-SOFR ICE Term"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_ICE_Term">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SOFR_ICE_Term</seealso>
    let USD_SOFR_ICE_Term =
        Prefixed_Name(fibo_ind_ir_cm, "USD-SOFR_ICE_Term") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-SandP_Index_High_Grade</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-SandP Index High Grade"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SandP_Index_High_Grade">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-SandP_Index_High_Grade</seealso>
    let USD_SandP_Index_High_Grade =
        Prefixed_Name(fibo_ind_ir_cm, "USD-SandP_Index_High_Grade") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-TBILL-H.15</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"USD-TBILL-H.15"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-TBILL-H.15">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-TBILL-H.15</seealso>
    let ``USD_TBILL_H.15`` =
        Prefixed_Name(fibo_ind_ir_cm, "USD-TBILL-H.15") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-TBILL-H.15-Bloomberg</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-TBILL-H.15-Bloomberg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-TBILL-H.15-Bloomberg">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-TBILL-H.15-Bloomberg</seealso>
    let ``USD_TBILL_H.15_Bloomberg`` =
        Prefixed_Name(fibo_ind_ir_cm, "USD-TBILL-H.15-Bloomberg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-TBILL_Auction_High_Rate</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-TBILL Auction High Rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-TBILL_Auction_High_Rate">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-TBILL_Auction_High_Rate</seealso>
    let USD_TBILL_Auction_High_Rate =
        Prefixed_Name(fibo_ind_ir_cm, "USD-TBILL_Auction_High_Rate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-TBILL_Secondary_Market-Bond_Equivalent_Yield</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"USD-TBILL Secondary Market-Bond Equivalent Yield"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-TBILL_Secondary_Market-Bond_Equivalent_Yield">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-TBILL_Secondary_Market-Bond_Equivalent_Yield</seealso>
    let USD_TBILL_Secondary_Market_Bond_Equivalent_Yield =
        Prefixed_Name(fibo_ind_ir_cm, "USD-TBILL_Secondary_Market-Bond_Equivalent_Yield") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-TIBOR-ISDC</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-TIBOR-ISDC"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-TIBOR-ISDC">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-TIBOR-ISDC</seealso>
    let USD_TIBOR_ISDC = Prefixed_Name(fibo_ind_ir_cm, "USD-TIBOR-ISDC") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-TIBOR-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-TIBOR-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-TIBOR-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-TIBOR-Reference_Banks</seealso>
    let USD_TIBOR_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "USD-TIBOR-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-Treasury-19901-3_00-ICAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"USD-Treasury-19901-3:00-ICAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Treasury-19901-3_00-ICAP">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Treasury-19901-3_00-ICAP</seealso>
    let USD_Treasury_19901_3_00_ICAP =
        Prefixed_Name(fibo_ind_ir_cm, "USD-Treasury-19901-3_00-ICAP") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-Treasury_Rate-ICAP_BrokerTec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"USD-Treasury Rate-ICAP BrokerTec"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Treasury_Rate-ICAP_BrokerTec">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Treasury_Rate-ICAP_BrokerTec</seealso>
    let USD_Treasury_Rate_ICAP_BrokerTec =
        Prefixed_Name(fibo_ind_ir_cm, "USD-Treasury_Rate-ICAP_BrokerTec") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-Treasury_Rate-SwapMarker100</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-Treasury Rate-SwapMarker100"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Treasury_Rate-SwapMarker100">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Treasury_Rate-SwapMarker100</seealso>
    let USD_Treasury_Rate_SwapMarker100 =
        Prefixed_Name(fibo_ind_ir_cm, "USD-Treasury_Rate-SwapMarker100") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-Treasury_Rate-SwapMarker99</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-Treasury Rate-SwapMarker99"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Treasury_Rate-SwapMarker99">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Treasury_Rate-SwapMarker99</seealso>
    let USD_Treasury_Rate_SwapMarker99 =
        Prefixed_Name(fibo_ind_ir_cm, "USD-Treasury_Rate-SwapMarker99") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-Treasury_Rate-T19901</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"USD-Treasury Rate-T19901"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Treasury_Rate-T19901">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Treasury_Rate-T19901</seealso>
    let USD_Treasury_Rate_T19901 =
        Prefixed_Name(fibo_ind_ir_cm, "USD-Treasury_Rate-T19901") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD-Treasury_Rate-T500</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD-Treasury Rate-T500"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Treasury_Rate-T500">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD-Treasury_Rate-T500</seealso>
    let USD_Treasury_Rate_T500 =
        Prefixed_Name(fibo_ind_ir_cm, "USD-Treasury_Rate-T500") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD_Swap_Rate-BCMP1</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD Swap Rate-BCMP1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD_Swap_Rate-BCMP1">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD_Swap_Rate-BCMP1</seealso>
    let USD_Swap_Rate_BCMP1 =
        Prefixed_Name(fibo_ind_ir_cm, "USD_Swap_Rate-BCMP1") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:USD_Treasury_Rate-BCMP1</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USD Treasury Rate-BCMP1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD_Treasury_Rate-BCMP1">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/USD_Treasury_Rate-BCMP1</seealso>
    let USD_Treasury_Rate_BCMP1 =
        Prefixed_Name(fibo_ind_ir_cm, "USD_Treasury_Rate-BCMP1") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:VND-Semi-Annual_Swap_Rate-11_00-BGCANTOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"VND-Semi-Annual Swap Rate-11:00-BGCANTOR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/VND-Semi-Annual_Swap_Rate-11_00-BGCANTOR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/VND-Semi-Annual_Swap_Rate-11_00-BGCANTOR</seealso>
    let VND_Semi_Annual_Swap_Rate_11_00_BGCANTOR =
        Prefixed_Name(fibo_ind_ir_cm, "VND-Semi-Annual_Swap_Rate-11_00-BGCANTOR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:VND-Semi-Annual_Swap_Rate-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"VND-Semi-Annual Swap Rate-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/VND-Semi-Annual_Swap_Rate-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/VND-Semi-Annual_Swap_Rate-Reference_Banks</seealso>
    let VND_Semi_Annual_Swap_Rate_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "VND-Semi-Annual_Swap_Rate-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:ZAR-DEPOSIT-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ZAR-DEPOSIT-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ZAR-DEPOSIT-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ZAR-DEPOSIT-Reference_Banks</seealso>
    let ZAR_DEPOSIT_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "ZAR-DEPOSIT-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:ZAR-DEPOSIT-SAFEX</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"ZAR-DEPOSIT-SAFEX"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ZAR-DEPOSIT-SAFEX">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ZAR-DEPOSIT-SAFEX</seealso>
    let ZAR_DEPOSIT_SAFEX =
        Prefixed_Name(fibo_ind_ir_cm, "ZAR-DEPOSIT-SAFEX") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:ZAR-JIBAR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"ZAR-JIBAR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ZAR-JIBAR">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ZAR-JIBAR</seealso>
    let ZAR_JIBAR = Prefixed_Name(fibo_ind_ir_cm, "ZAR-JIBAR") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:ZAR-JIBAR-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ZAR-JIBAR-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ZAR-JIBAR-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ZAR-JIBAR-Reference_Banks</seealso>
    let ZAR_JIBAR_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "ZAR-JIBAR-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:ZAR-PRIME-AVERAGE-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"ZAR-PRIME-AVERAGE-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ZAR-PRIME-AVERAGE-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ZAR-PRIME-AVERAGE-Reference_Banks</seealso>
    let ZAR_PRIME_AVERAGE_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "ZAR-PRIME-AVERAGE-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:ZAR-Prime_Average</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ZAR-Prime Average"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ZAR-Prime_Average">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ZAR-Prime_Average</seealso>
    let ZAR_Prime_Average =
        Prefixed_Name(fibo_ind_ir_cm, "ZAR-Prime_Average") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:ZAR-Quarterly_Swap_Rate-1_00-TRADITION</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"ZAR-Quarterly Swap Rate-1:00-TRADITION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ZAR-Quarterly_Swap_Rate-1_00-TRADITION">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ZAR-Quarterly_Swap_Rate-1_00-TRADITION</seealso>
    let ZAR_Quarterly_Swap_Rate_1_00_TRADITION =
        Prefixed_Name(fibo_ind_ir_cm, "ZAR-Quarterly_Swap_Rate-1_00-TRADITION") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:ZAR-Quarterly_Swap_Rate-5_30-TRADITION</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ZAR-Quarterly Swap Rate-5:30-TRADITION"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ZAR-Quarterly_Swap_Rate-5_30-TRADITION">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ZAR-Quarterly_Swap_Rate-5_30-TRADITION</seealso>
    let ZAR_Quarterly_Swap_Rate_5_30_TRADITION =
        Prefixed_Name(fibo_ind_ir_cm, "ZAR-Quarterly_Swap_Rate-5_30-TRADITION") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:ZAR-Quarterly_Swap_Rate-TRADITION-Reference_Banks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"ZAR-Quarterly Swap Rate-TRADITION-Reference Banks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ZAR-Quarterly_Swap_Rate-TRADITION-Reference_Banks">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ZAR-Quarterly_Swap_Rate-TRADITION-Reference_Banks</seealso>
    let ZAR_Quarterly_Swap_Rate_TRADITION_Reference_Banks =
        Prefixed_Name(fibo_ind_ir_cm, "ZAR-Quarterly_Swap_Rate-TRADITION-Reference_Banks") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:ZAR-ZARONIA</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ZAR-ZARONIA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ZAR-ZARONIA">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ZAR-ZARONIA</seealso>
    let ZAR_ZARONIA = Prefixed_Name(fibo_ind_ir_cm, "ZAR-ZARONIA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ir-cm:ZAR-ZARONIA-OIS_Compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-ind-ir-ir:InterestRateBenchmark</para>
    ///
    /// labels<para>"ZAR-ZARONIA-OIS Compound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ZAR-ZARONIA-OIS_Compound">https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/ZAR-ZARONIA-OIS_Compound</seealso>
    let ZAR_ZARONIA_OIS_Compound =
        Prefixed_Name(fibo_ind_ir_cm, "ZAR-ZARONIA-OIS_Compound") |> PrefixedName

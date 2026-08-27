namespace https.spec.edmcouncil.org.fibo.ontology.IND.EconomicIndicators.NorthAmericanIndicators.USEconomicIndicators.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_ind_ei_usei =
    let _namespace_iri = Namespace_Iri fibo_ind_ei_usei |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-ind-ei-usei:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"American Economic Indicators Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_ind_ei_usei, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-usei:AmericanStatisticsPublisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"American statistics publisher"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/AmericanStatisticsPublisher">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/AmericanStatisticsPublisher</seealso>
    let AmericanStatisticsPublisher =
        Prefixed_Name(fibo_ind_ei_usei, "AmericanStatisticsPublisher") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-usei:BureauOfLaborStatistics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:GovernmentAgency</para>
    ///
    /// labels<para>"Bureau of Labor Statistics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/BureauOfLaborStatistics">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/BureauOfLaborStatistics</seealso>
    let BureauOfLaborStatistics =
        Prefixed_Name(fibo_ind_ei_usei, "BureauOfLaborStatistics") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-usei:ConsumerExpenditureSurvey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"consumer expenditure survey"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/ConsumerExpenditureSurvey">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/ConsumerExpenditureSurvey</seealso>
    let ConsumerExpenditureSurvey =
        Prefixed_Name(fibo_ind_ei_usei, "ConsumerExpenditureSurvey") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-usei:CurrentEmploymentStatistics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"current employment statistics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/CurrentEmploymentStatistics">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/CurrentEmploymentStatistics</seealso>
    let CurrentEmploymentStatistics =
        Prefixed_Name(fibo_ind_ei_usei, "CurrentEmploymentStatistics") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-usei:CurrentPopulationSurvey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"current population survey"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/CurrentPopulationSurvey">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/CurrentPopulationSurvey</seealso>
    let CurrentPopulationSurvey =
        Prefixed_Name(fibo_ind_ei_usei, "CurrentPopulationSurvey") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-usei:EmploymentSituationEstablishmentSurvey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"employment situation establishment survey"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/EmploymentSituationEstablishmentSurvey">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/EmploymentSituationEstablishmentSurvey</seealso>
    let EmploymentSituationEstablishmentSurvey =
        Prefixed_Name(fibo_ind_ei_usei, "EmploymentSituationEstablishmentSurvey") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-usei:EmploymentSituationHouseholdSurvey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"employment situation household survey"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/EmploymentSituationHouseholdSurvey">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/EmploymentSituationHouseholdSurvey</seealso>
    let EmploymentSituationHouseholdSurvey =
        Prefixed_Name(fibo_ind_ei_usei, "EmploymentSituationHouseholdSurvey") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-usei:EmploymentSituationSurvey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"employment situation survey"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/EmploymentSituationSurvey">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/EmploymentSituationSurvey</seealso>
    let EmploymentSituationSurvey =
        Prefixed_Name(fibo_ind_ei_usei, "EmploymentSituationSurvey") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-usei:PointOfPurchaseSurvey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"point of purchase survey"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/PointOfPurchaseSurvey">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/PointOfPurchaseSurvey</seealso>
    let PointOfPurchaseSurvey =
        Prefixed_Name(fibo_ind_ei_usei, "PointOfPurchaseSurvey") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-usei:USProducerPriceIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"U.S. producer price index"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/USProducerPriceIndex">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/USProducerPriceIndex</seealso>
    let USProducerPriceIndex =
        Prefixed_Name(fibo_ind_ei_usei, "USProducerPriceIndex") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-usei:UnitedStatesDepartmentOfLabor</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:GovernmentDepartment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"United States Department of Labor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/UnitedStatesDepartmentOfLabor">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/UnitedStatesDepartmentOfLabor</seealso>
    let UnitedStatesDepartmentOfLabor =
        Prefixed_Name(fibo_ind_ei_usei, "UnitedStatesDepartmentOfLabor") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-usei:UrbanConsumerPriceIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"urban consumer price index"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/UrbanConsumerPriceIndex">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/UrbanConsumerPriceIndex</seealso>
    let UrbanConsumerPriceIndex =
        Prefixed_Name(fibo_ind_ei_usei, "UrbanConsumerPriceIndex") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-usei:UrbanConsumersUniverse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"urban consumers universe"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/UrbanConsumersUniverse">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/UrbanConsumersUniverse</seealso>
    let UrbanConsumersUniverse =
        Prefixed_Name(fibo_ind_ei_usei, "UrbanConsumersUniverse") |> PrefixedName

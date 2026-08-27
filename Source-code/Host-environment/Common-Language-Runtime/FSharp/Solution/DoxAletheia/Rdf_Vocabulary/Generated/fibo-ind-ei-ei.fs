namespace https.spec.edmcouncil.org.fibo.ontology.IND.EconomicIndicators.EconomicIndicators.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_ind_ei_ei =
    let _namespace_iri = Namespace_Iri fibo_ind_ei_ei |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-ind-ei-ei:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Economic Indicators Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_ind_ei_ei, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:AverageDailyEarnings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"average daily earnings"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/AverageDailyEarnings">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/AverageDailyEarnings</seealso>
    let AverageDailyEarnings =
        Prefixed_Name(fibo_ind_ei_ei, "AverageDailyEarnings") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:AverageEarnings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"average earnings"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/AverageEarnings">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/AverageEarnings</seealso>
    let AverageEarnings =
        Prefixed_Name(fibo_ind_ei_ei, "AverageEarnings") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:AverageHourlyEarnings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"average hourly earnings"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/AverageHourlyEarnings">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/AverageHourlyEarnings</seealso>
    let AverageHourlyEarnings =
        Prefixed_Name(fibo_ind_ei_ei, "AverageHourlyEarnings") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:AverageMonthlyEarnings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"average monthly earnings"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/AverageMonthlyEarnings">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/AverageMonthlyEarnings</seealso>
    let AverageMonthlyEarnings =
        Prefixed_Name(fibo_ind_ei_ei, "AverageMonthlyEarnings") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:AverageWeeklyEarnings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"average weekly earnings"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/AverageWeeklyEarnings">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/AverageWeeklyEarnings</seealso>
    let AverageWeeklyEarnings =
        Prefixed_Name(fibo_ind_ei_ei, "AverageWeeklyEarnings") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:CapitalLaborEnergyMaterialsMultifactorProductivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"capital-labor-energy-materials multifactor productivity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CapitalLaborEnergyMaterialsMultifactorProductivity">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CapitalLaborEnergyMaterialsMultifactorProductivity</seealso>
    let CapitalLaborEnergyMaterialsMultifactorProductivity =
        Prefixed_Name(fibo_ind_ei_ei, "CapitalLaborEnergyMaterialsMultifactorProductivity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:CapitalLaborMultifactorProductivityValueAdded</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"capital-labor multifactor productivity (MFP), based on value added"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CapitalLaborMultifactorProductivityValueAdded">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CapitalLaborMultifactorProductivityValueAdded</seealso>
    let CapitalLaborMultifactorProductivityValueAdded =
        Prefixed_Name(fibo_ind_ei_ei, "CapitalLaborMultifactorProductivityValueAdded") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:CapitalProductivityValueAdded</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"capital productivity, based on value added"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CapitalProductivityValueAdded">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CapitalProductivityValueAdded</seealso>
    let CapitalProductivityValueAdded =
        Prefixed_Name(fibo_ind_ei_ei, "CapitalProductivityValueAdded") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:Civilian</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"civilian"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Civilian">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Civilian</seealso>
    let Civilian = Prefixed_Name(fibo_ind_ei_ei, "Civilian") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:CivilianLaborForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"civilian labor force"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CivilianLaborForce">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CivilianLaborForce</seealso>
    let CivilianLaborForce =
        Prefixed_Name(fibo_ind_ei_ei, "CivilianLaborForce") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:CivilianLaborForceParticipationRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"civilian labor force participation rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CivilianLaborForceParticipationRate">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CivilianLaborForceParticipationRate</seealso>
    let CivilianLaborForceParticipationRate =
        Prefixed_Name(fibo_ind_ei_ei, "CivilianLaborForceParticipationRate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:CivilianNonInstitutionalPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"civilian non-institutional person"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CivilianNonInstitutionalPerson">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CivilianNonInstitutionalPerson</seealso>
    let CivilianNonInstitutionalPerson =
        Prefixed_Name(fibo_ind_ei_ei, "CivilianNonInstitutionalPerson") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:CivilianNonInstitutionalPopulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"civilian non-institutional population"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CivilianNonInstitutionalPopulation">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CivilianNonInstitutionalPopulation</seealso>
    let CivilianNonInstitutionalPopulation =
        Prefixed_Name(fibo_ind_ei_ei, "CivilianNonInstitutionalPopulation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:CombinedStatisticalArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"combined statistical area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CombinedStatisticalArea">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CombinedStatisticalArea</seealso>
    let CombinedStatisticalArea =
        Prefixed_Name(fibo_ind_ei_ei, "CombinedStatisticalArea") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:ConsumerPriceIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"consumer price index"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/ConsumerPriceIndex">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/ConsumerPriceIndex</seealso>
    let ConsumerPriceIndex =
        Prefixed_Name(fibo_ind_ei_ei, "ConsumerPriceIndex") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:Daily</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-dt-fd:ExplicitRecurrenceInterval</para>
    ///
    /// labels<para>"daily"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Daily">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Daily</seealso>
    let Daily = Prefixed_Name(fibo_ind_ei_ei, "Daily") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:DiscouragedWorkerPopulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"discouraged worker population"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/DiscouragedWorkerPopulation">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/DiscouragedWorkerPopulation</seealso>
    let DiscouragedWorkerPopulation =
        Prefixed_Name(fibo_ind_ei_ei, "DiscouragedWorkerPopulation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:EconomicIndicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"economic indicator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EconomicIndicator">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EconomicIndicator</seealso>
    let EconomicIndicator =
        Prefixed_Name(fibo_ind_ei_ei, "EconomicIndicator") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:EmployedPopulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"employed population"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EmployedPopulation">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EmployedPopulation</seealso>
    let EmployedPopulation =
        Prefixed_Name(fibo_ind_ei_ei, "EmployedPopulation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:EmployedPopulationPartTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"employed population part-time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EmployedPopulationPartTime">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EmployedPopulationPartTime</seealso>
    let EmployedPopulationPartTime =
        Prefixed_Name(fibo_ind_ei_ei, "EmployedPopulationPartTime") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:EmployedPopulationPartTimeForEconomicReasons</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"employed population part-time for economic reasons"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EmployedPopulationPartTimeForEconomicReasons">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EmployedPopulationPartTimeForEconomicReasons</seealso>
    let EmployedPopulationPartTimeForEconomicReasons =
        Prefixed_Name(fibo_ind_ei_ei, "EmployedPopulationPartTimeForEconomicReasons") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:EmployedPopulationPartTimeForNonEconomicReasons</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"employed population part-time for non-economic reasons"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EmployedPopulationPartTimeForNonEconomicReasons">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EmployedPopulationPartTimeForNonEconomicReasons</seealso>
    let EmployedPopulationPartTimeForNonEconomicReasons =
        Prefixed_Name(fibo_ind_ei_ei, "EmployedPopulationPartTimeForNonEconomicReasons") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:EmployedPopulationTemporarilyNotAtWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"employed population temporarily not at work"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EmployedPopulationTemporarilyNotAtWork">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EmployedPopulationTemporarilyNotAtWork</seealso>
    let EmployedPopulationTemporarilyNotAtWork =
        Prefixed_Name(fibo_ind_ei_ei, "EmployedPopulationTemporarilyNotAtWork") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:EmploymentPopulationRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"employment-population ratio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EmploymentPopulationRatio">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EmploymentPopulationRatio</seealso>
    let EmploymentPopulationRatio =
        Prefixed_Name(fibo_ind_ei_ei, "EmploymentPopulationRatio") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:Enterprise</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"enterprise"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Enterprise">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Enterprise</seealso>
    let Enterprise = Prefixed_Name(fibo_ind_ei_ei, "Enterprise") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:EnterprisePopulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"enterprise population"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EnterprisePopulation">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EnterprisePopulation</seealso>
    let EnterprisePopulation =
        Prefixed_Name(fibo_ind_ei_ei, "EnterprisePopulation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:Establishment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"establishment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Establishment">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Establishment</seealso>
    let Establishment = Prefixed_Name(fibo_ind_ei_ei, "Establishment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:EstablishmentEmployment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"establishment employment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EstablishmentEmployment">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EstablishmentEmployment</seealso>
    let EstablishmentEmployment =
        Prefixed_Name(fibo_ind_ei_ei, "EstablishmentEmployment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:EstablishmentPopulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"establishment population"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EstablishmentPopulation">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EstablishmentPopulation</seealso>
    let EstablishmentPopulation =
        Prefixed_Name(fibo_ind_ei_ei, "EstablishmentPopulation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:FixedBasket</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fixed basket"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/FixedBasket">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/FixedBasket</seealso>
    let FixedBasket = Prefixed_Name(fibo_ind_ei_ei, "FixedBasket") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:FixedBasketConstituent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fixed basket constituent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/FixedBasketConstituent">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/FixedBasketConstituent</seealso>
    let FixedBasketConstituent =
        Prefixed_Name(fibo_ind_ei_ei, "FixedBasketConstituent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:FixedBasketPopulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fixed basket population"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/FixedBasketPopulation">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/FixedBasketPopulation</seealso>
    let FixedBasketPopulation =
        Prefixed_Name(fibo_ind_ei_ei, "FixedBasketPopulation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:GovernmentSpecifiedStatisticalArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"government-specified statistical area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/GovernmentSpecifiedStatisticalArea">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/GovernmentSpecifiedStatisticalArea</seealso>
    let GovernmentSpecifiedStatisticalArea =
        Prefixed_Name(fibo_ind_ei_ei, "GovernmentSpecifiedStatisticalArea") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:GrossDomesticProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"gross domestic product"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/GrossDomesticProduct">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/GrossDomesticProduct</seealso>
    let GrossDomesticProduct =
        Prefixed_Name(fibo_ind_ei_ei, "GrossDomesticProduct") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:Hourly</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-dt-fd:ExplicitRecurrenceInterval</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"hourly"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Hourly">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Hourly</seealso>
    let Hourly = Prefixed_Name(fibo_ind_ei_ei, "Hourly") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ei-ei:Household</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"household"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Household">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Household</seealso>
    let Household = Prefixed_Name(fibo_ind_ei_ei, "Household") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ei-ei:HousingUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"housing unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/HousingUnit">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/HousingUnit</seealso>
    let HousingUnit = Prefixed_Name(fibo_ind_ei_ei, "HousingUnit") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ei-ei:InflationRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"inflation rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/InflationRate">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/InflationRate</seealso>
    let InflationRate = Prefixed_Name(fibo_ind_ei_ei, "InflationRate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:InputProducerPriceIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"input producer price index"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/InputProducerPriceIndex">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/InputProducerPriceIndex</seealso>
    let InputProducerPriceIndex =
        Prefixed_Name(fibo_ind_ei_ei, "InputProducerPriceIndex") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:InstitutionalPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"institutional person"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/InstitutionalPerson">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/InstitutionalPerson</seealso>
    let InstitutionalPerson =
        Prefixed_Name(fibo_ind_ei_ei, "InstitutionalPerson") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:InstitutionalUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"institutional unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/InstitutionalUnit">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/InstitutionalUnit</seealso>
    let InstitutionalUnit =
        Prefixed_Name(fibo_ind_ei_ei, "InstitutionalUnit") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:LaborProductivityGrossOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"labor productivity, based on gross output"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/LaborProductivityGrossOutput">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/LaborProductivityGrossOutput</seealso>
    let LaborProductivityGrossOutput =
        Prefixed_Name(fibo_ind_ei_ei, "LaborProductivityGrossOutput") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:LaborProductivityValueAdded</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"labor productivity, based on value added"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/LaborProductivityValueAdded">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/LaborProductivityValueAdded</seealso>
    let LaborProductivityValueAdded =
        Prefixed_Name(fibo_ind_ei_ei, "LaborProductivityValueAdded") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:MarginallyAttachedPopulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"marginally attached population"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/MarginallyAttachedPopulation">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/MarginallyAttachedPopulation</seealso>
    let MarginallyAttachedPopulation =
        Prefixed_Name(fibo_ind_ei_ei, "MarginallyAttachedPopulation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:MetropolitanStatisticalArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"metropolitan statistical area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/MetropolitanStatisticalArea">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/MetropolitanStatisticalArea</seealso>
    let MetropolitanStatisticalArea =
        Prefixed_Name(fibo_ind_ei_ei, "MetropolitanStatisticalArea") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:MicropolitanStatisticalArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"micropolitan statistical area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/MicropolitanStatisticalArea">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/MicropolitanStatisticalArea</seealso>
    let MicropolitanStatisticalArea =
        Prefixed_Name(fibo_ind_ei_ei, "MicropolitanStatisticalArea") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:MilitaryPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"military person"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/MilitaryPerson">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/MilitaryPerson</seealso>
    let MilitaryPerson = Prefixed_Name(fibo_ind_ei_ei, "MilitaryPerson") |> PrefixedName
    /// <summary>
    ///   <para>fibo-ind-ei-ei:Monthly</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-dt-fd:ExplicitRecurrenceInterval</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"monthly"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Monthly">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Monthly</seealso>
    let Monthly = Prefixed_Name(fibo_ind_ei_ei, "Monthly") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:OutputProducerPriceIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"output producer price index"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/OutputProducerPriceIndex">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/OutputProducerPriceIndex</seealso>
    let OutputProducerPriceIndex =
        Prefixed_Name(fibo_ind_ei_ei, "OutputProducerPriceIndex") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:PersonalConsumptionExpenditures</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"personal consumption expenditures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/PersonalConsumptionExpenditures">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/PersonalConsumptionExpenditures</seealso>
    let PersonalConsumptionExpenditures =
        Prefixed_Name(fibo_ind_ei_ei, "PersonalConsumptionExpenditures") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:PopulationNotInLaborForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"population not in the labor force"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/PopulationNotInLaborForce">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/PopulationNotInLaborForce</seealso>
    let PopulationNotInLaborForce =
        Prefixed_Name(fibo_ind_ei_ei, "PopulationNotInLaborForce") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:ProducerPriceIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"producer price index"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/ProducerPriceIndex">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/ProducerPriceIndex</seealso>
    let ProducerPriceIndex =
        Prefixed_Name(fibo_ind_ei_ei, "ProducerPriceIndex") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:Productivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"productivity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Productivity">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Productivity</seealso>
    let Productivity = Prefixed_Name(fibo_ind_ei_ei, "Productivity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:StatisticalInformationPublisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"statistical information publisher"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/StatisticalInformationPublisher">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/StatisticalInformationPublisher</seealso>
    let StatisticalInformationPublisher =
        Prefixed_Name(fibo_ind_ei_ei, "StatisticalInformationPublisher") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:UltimateConsumer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ultimate consumer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/UltimateConsumer">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/UltimateConsumer</seealso>
    let UltimateConsumer =
        Prefixed_Name(fibo_ind_ei_ei, "UltimateConsumer") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:UnderemployedPopulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"underemployed population"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/UnderemployedPopulation">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/UnderemployedPopulation</seealso>
    let UnderemployedPopulation =
        Prefixed_Name(fibo_ind_ei_ei, "UnderemployedPopulation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:UnderemployedPopulationWithRespectToOccupation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"underemployed population with respect to occupation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/UnderemployedPopulationWithRespectToOccupation">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/UnderemployedPopulationWithRespectToOccupation</seealso>
    let UnderemployedPopulationWithRespectToOccupation =
        Prefixed_Name(fibo_ind_ei_ei, "UnderemployedPopulationWithRespectToOccupation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:UnderutilizedPopulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"underutilized population"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/UnderutilizedPopulation">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/UnderutilizedPopulation</seealso>
    let UnderutilizedPopulation =
        Prefixed_Name(fibo_ind_ei_ei, "UnderutilizedPopulation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:UnemployedPopulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"unemployed population"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/UnemployedPopulation">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/UnemployedPopulation</seealso>
    let UnemployedPopulation =
        Prefixed_Name(fibo_ind_ei_ei, "UnemployedPopulation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:UnemploymentRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"unemployment rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/UnemploymentRate">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/UnemploymentRate</seealso>
    let UnemploymentRate =
        Prefixed_Name(fibo_ind_ei_ei, "UnemploymentRate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:ValueAddedProducerPriceIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"value-added producer price index"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/ValueAddedProducerPriceIndex">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/ValueAddedProducerPriceIndex</seealso>
    let ValueAddedProducerPriceIndex =
        Prefixed_Name(fibo_ind_ei_ei, "ValueAddedProducerPriceIndex") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:Weekly</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-dt-fd:ExplicitRecurrenceInterval</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"weekly"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Weekly">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Weekly</seealso>
    let Weekly = Prefixed_Name(fibo_ind_ei_ei, "Weekly") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:excludesEnergyAndFood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"excludes energy and food"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/excludesEnergyAndFood">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/excludesEnergyAndFood</seealso>
    let excludesEnergyAndFood =
        Prefixed_Name(fibo_ind_ei_ei, "excludesEnergyAndFood") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:hasBaselinePopulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has baseline population"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/hasBaselinePopulation">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/hasBaselinePopulation</seealso>
    let hasBaselinePopulation =
        Prefixed_Name(fibo_ind_ei_ei, "hasBaselinePopulation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:hasComparisonPopulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has comparison population"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/hasComparisonPopulation">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/hasComparisonPopulation</seealso>
    let hasComparisonPopulation =
        Prefixed_Name(fibo_ind_ei_ei, "hasComparisonPopulation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:hasDurationOfUnemployment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has duration of unemployment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/hasDurationOfUnemployment">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/hasDurationOfUnemployment</seealso>
    let hasDurationOfUnemployment =
        Prefixed_Name(fibo_ind_ei_ei, "hasDurationOfUnemployment") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:hasIndicatorValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has indicator value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/hasIndicatorValue">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/hasIndicatorValue</seealso>
    let hasIndicatorValue =
        Prefixed_Name(fibo_ind_ei_ei, "hasIndicatorValue") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:hasSeriesOrigin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has series origin"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/hasSeriesOrigin">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/hasSeriesOrigin</seealso>
    let hasSeriesOrigin =
        Prefixed_Name(fibo_ind_ei_ei, "hasSeriesOrigin") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-ei:isSeasonallyAdjusted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is seasonally adjusted"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/isSeasonallyAdjusted">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/isSeasonallyAdjusted</seealso>
    let isSeasonallyAdjusted =
        Prefixed_Name(fibo_ind_ei_ei, "isSeasonallyAdjusted") |> PrefixedName

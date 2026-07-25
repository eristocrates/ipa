namespace https.saref.etsi.org.saref4watr.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module s4watr =
    let _namespace_iri = Namespace_Iri s4watr |> NamespaceIRI
    /// <summary>
    ///   <para>s4watr:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/">https://saref.etsi.org/saref4watr/</seealso>
    let _prefix_iri = Prefixed_Name(s4watr, "") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:12Dichloroethane</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:ChemicalProperty</para>
    ///   <para>Property of the water indicating its concentration of 1,2-dichloroethane.</para>
    /// labels<para>1,2-dichloroethane</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/12Dichloroethane">https://saref.etsi.org/saref4watr/12Dichloroethane</seealso>
    let _12Dichloroethane = Prefixed_Name(s4watr, "12Dichloroethane") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:AcceptabilityProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An acceptability property is a property of water that is related to its acceptability.</para>
    /// labels<para>Acceptability property</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/AcceptabilityProperty">https://saref.etsi.org/saref4watr/AcceptabilityProperty</seealso>
    let AcceptabilityProperty =
        Prefixed_Name(s4watr, "AcceptabilityProperty") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:Acrylamide</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4watr:ChemicalProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Property of the water indicating its concentration of acrylamide.</para>
    /// labels<para>Acrylamide</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Acrylamide">https://saref.etsi.org/saref4watr/Acrylamide</seealso>
    let Acrylamide = Prefixed_Name(s4watr, "Acrylamide") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Agriculture</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4watr:WaterUse</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Use of water for the farming of plants and livestock.</para>
    /// labels<para>Agriculture</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Agriculture">https://saref.etsi.org/saref4watr/Agriculture</seealso>
    let Agriculture = Prefixed_Name(s4watr, "Agriculture") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Antimony</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4watr:ChemicalProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Property of the water indicating its concentration of antimony.</para>
    /// labels<para>Antimony</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Antimony">https://saref.etsi.org/saref4watr/Antimony</seealso>
    let Antimony = Prefixed_Name(s4watr, "Antimony") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Boron</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4watr:ChemicalProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Property of the water indicating its concentration of boron.</para>
    /// labels<para>Boron</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Boron">https://saref.etsi.org/saref4watr/Boron</seealso>
    let Boron = Prefixed_Name(s4watr, "Boron") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:appliesTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The water meter to which a tariff applies to.</para>
    /// labels<para>applies to</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/appliesTo">https://saref.etsi.org/saref4watr/appliesTo</seealso>
    let appliesTo = Prefixed_Name(s4watr, "appliesTo") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:controlsFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship specifying the features of interest that are controlled by a device.</para>
    /// labels<para>controls feature</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/controlsFeature">https://saref.etsi.org/saref4watr/controlsFeature</seealso>
    let controlsFeature = Prefixed_Name(s4watr, "controlsFeature") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:forAbsoluteTimeAtDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The time interval in each day for which a tariff is applied (e.g., 8:00 to 10:00).</para>
    /// labels<para>for absolute time at day</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/forAbsoluteTimeAtDay">https://saref.etsi.org/saref4watr/forAbsoluteTimeAtDay</seealso>
    let forAbsoluteTimeAtDay =
        Prefixed_Name(s4watr, "forAbsoluteTimeAtDay") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:forFinancialConsumption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The financial consumption related to a tariff (e.g., prepaid tariffs).</para>
    /// labels<para>for financial consumption</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/forFinancialConsumption">https://saref.etsi.org/saref4watr/forFinancialConsumption</seealso>
    let forFinancialConsumption =
        Prefixed_Name(s4watr, "forFinancialConsumption") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:forVolumeConsumption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The volume consumption related to a tariff (e.g., after consumption of 900 litres).</para>
    /// labels<para>for volume consumption</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/forVolumeConsumption">https://saref.etsi.org/saref4watr/forVolumeConsumption</seealso>
    let forVolumeConsumption =
        Prefixed_Name(s4watr, "forVolumeConsumption") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:forWeekDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The day of the week for which a tariff is applied (e.g., each Saturday and Sunday).</para>
    /// labels<para>for week day</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/forWeekDay">https://saref.etsi.org/saref4watr/forWeekDay</seealso>
    let forWeekDay = Prefixed_Name(s4watr, "forWeekDay") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:hasDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The duration of a tariff.</para>
    /// labels<para>has duration</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/hasDuration">https://saref.etsi.org/saref4watr/hasDuration</seealso>
    let hasDuration = Prefixed_Name(s4watr, "hasDuration") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:hasPhenomenonTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The time for which the value of a measurement applies to the feature of interest.</para>
    /// labels<para>has phenomenon time</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/hasPhenomenonTime">https://saref.etsi.org/saref4watr/hasPhenomenonTime</seealso>
    let hasPhenomenonTime = Prefixed_Name(s4watr, "hasPhenomenonTime") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:measuresFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship specifying the features of interest that are measured by a device.</para>
    /// labels<para>measures feature</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/measuresFeature">https://saref.etsi.org/saref4watr/measuresFeature</seealso>
    let measuresFeature = Prefixed_Name(s4watr, "measuresFeature") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:requiresPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The power required by a device.</para>
    /// labels<para>requires power</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/requiresPower">https://saref.etsi.org/saref4watr/requiresPower</seealso>
    let requiresPower = Prefixed_Name(s4watr, "requiresPower") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:WaterProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class to group those properties related to the water.</para>
    /// labels<para>Water property</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/WaterProperty">https://saref.etsi.org/saref4watr/WaterProperty</seealso>
    let WaterProperty = Prefixed_Name(s4watr, "WaterProperty") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Aluminium</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4watr:ChemicalProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Property of the water indicating its concentration of aluminium.</para>
    /// labels<para>Aluminium</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Aluminium">https://saref.etsi.org/saref4watr/Aluminium</seealso>
    let Aluminium = Prefixed_Name(s4watr, "Aluminium") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Aquaculture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:WaterUse</para>
    ///   <para>Use of water for the farming of fish, crustaceans, molluscs, aquatic plants, algae, and other organisms.</para>
    /// labels<para>Aquaculture</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Aquaculture">https://saref.etsi.org/saref4watr/Aquaculture</seealso>
    let Aquaculture = Prefixed_Name(s4watr, "Aquaculture") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Arsenic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:ChemicalProperty</para>
    ///   <para>Property of the water indicating its concentration of arsenic.</para>
    /// labels<para>Arsenic</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Arsenic">https://saref.etsi.org/saref4watr/Arsenic</seealso>
    let Arsenic = Prefixed_Name(s4watr, "Arsenic") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:MicrobialProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A microbial property is a property of water that is related to microbes.</para>
    /// labels<para>Microbial property</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/MicrobialProperty">https://saref.etsi.org/saref4watr/MicrobialProperty</seealso>
    let MicrobialProperty = Prefixed_Name(s4watr, "MicrobialProperty") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:BatteryLastChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:WaterMeterProperty</para>
    ///   <para>The time in which the battery was last changed.</para>
    /// labels<para>Battery last change</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/BatteryLastChange">https://saref.etsi.org/saref4watr/BatteryLastChange</seealso>
    let BatteryLastChange = Prefixed_Name(s4watr, "BatteryLastChange") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:BatteryRemainingTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:WaterMeterProperty</para>
    ///   <para>The time until the battery is discharged.</para>
    /// labels<para>Battery remaining time</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/BatteryRemainingTime">https://saref.etsi.org/saref4watr/BatteryRemainingTime</seealso>
    let BatteryRemainingTime =
        Prefixed_Name(s4watr, "BatteryRemainingTime") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:Benzoapyrene</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:ChemicalProperty</para>
    ///   <para>Property of the water indicating its concentration of benzo(a)pyrene.</para>
    /// labels<para>Benzo(a)pyrene</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Benzoapyrene">https://saref.etsi.org/saref4watr/Benzoapyrene</seealso>
    let Benzoapyrene = Prefixed_Name(s4watr, "Benzoapyrene") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Bromate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:ChemicalProperty</para>
    ///   <para>Property of the water indicating its concentration of bromate.</para>
    /// labels<para>Bromate</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Bromate">https://saref.etsi.org/saref4watr/Bromate</seealso>
    let Bromate = Prefixed_Name(s4watr, "Bromate") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Cadmium</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4watr:ChemicalProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Property of the water indicating its concentration of cadmium.</para>
    /// labels<para>Cadmium</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Cadmium">https://saref.etsi.org/saref4watr/Cadmium</seealso>
    let Cadmium = Prefixed_Name(s4watr, "Cadmium") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Main</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A main is a passage of water to flow through.</para>
    /// labels<para>Main</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Main">https://saref.etsi.org/saref4watr/Main</seealso>
    let Main = Prefixed_Name(s4watr, "Main") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Chromium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:ChemicalProperty</para>
    ///   <para>Property of the water indicating its concentration of chromium.</para>
    /// labels<para>Chromium</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Chromium">https://saref.etsi.org/saref4watr/Chromium</seealso>
    let Chromium = Prefixed_Name(s4watr, "Chromium") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:ClostridiumPerfringens</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:BacterialProperty</para>
    ///   <para>Property of the water indicating its concentration of clostridium perfringens.</para>
    /// labels<para>Clostridium perfringens</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/ClostridiumPerfringens">https://saref.etsi.org/saref4watr/ClostridiumPerfringens</seealso>
    let ClostridiumPerfringens =
        Prefixed_Name(s4watr, "ClostridiumPerfringens") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:ColonyCount22C</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:BacterialProperty</para>
    ///   <para>Property of the water indicating its colony count at 22 ºC.</para>
    /// labels<para>Colony count at 22 °C</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/ColonyCount22C">https://saref.etsi.org/saref4watr/ColonyCount22C</seealso>
    let ColonyCount22C = Prefixed_Name(s4watr, "ColonyCount22C") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Conductivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4watr:AcceptabilityProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Property of the water indicating its conductivity.</para>
    /// labels<para>Conductivity</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Conductivity">https://saref.etsi.org/saref4watr/Conductivity</seealso>
    let Conductivity = Prefixed_Name(s4watr, "Conductivity") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Tariff</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A tariff is a schedule of rates or charges of a business or a public utility. Tariffs can be based on time, thresholds or consumption; however, combined tariffs may also exist that mix more than one of these types.</para>
    /// labels<para>Tariff</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Tariff">https://saref.etsi.org/saref4watr/Tariff</seealso>
    let Tariff = Prefixed_Name(s4watr, "Tariff") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Copper</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4watr:ChemicalProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Property of the water indicating its concentration of copper.</para>
    /// labels<para>Copper</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Copper">https://saref.etsi.org/saref4watr/Copper</seealso>
    let Copper = Prefixed_Name(s4watr, "Copper") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Cyanide</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:ChemicalProperty</para>
    ///   <para>Property of the water indicating its concentration of cyanide.</para>
    /// labels<para>Cyanide</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Cyanide">https://saref.etsi.org/saref4watr/Cyanide</seealso>
    let Cyanide = Prefixed_Name(s4watr, "Cyanide") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:DistributionSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A water distribution system is an infrastructure to carry potable water from a centralized treatment plant or wells to water consumers in order to adequately deliver water to satisfy residential, commercial, industrial and fire fighting requirements.</para>
    /// labels<para>Distribution system</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/DistributionSystem">https://saref.etsi.org/saref4watr/DistributionSystem</seealso>
    let DistributionSystem = Prefixed_Name(s4watr, "DistributionSystem") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Domestic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:WaterUse</para>
    ///   <para>Use of water for domestic purposes.</para>
    /// labels<para>Domestic</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Domestic">https://saref.etsi.org/saref4watr/Domestic</seealso>
    let Domestic = Prefixed_Name(s4watr, "Domestic") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:DrinkingWater</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:Water</para>
    ///   <para>Drinking water is water that is treated to comply with drinking water standards.</para>
    /// labels<para>Drinking water</para><para>Potable water</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/DrinkingWater">https://saref.etsi.org/saref4watr/DrinkingWater</seealso>
    let DrinkingWater = Prefixed_Name(s4watr, "DrinkingWater") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Water</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class is used to define a particular quantity or body of water.</para>
    /// labels<para>Water</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Water">https://saref.etsi.org/saref4watr/Water</seealso>
    let Water = Prefixed_Name(s4watr, "Water") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Epichlorohydrin</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4watr:ChemicalProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Property of the water indicating its concentration of epichlorohydrin.</para>
    /// labels<para>Epichlorohydrin</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Epichlorohydrin">https://saref.etsi.org/saref4watr/Epichlorohydrin</seealso>
    let Epichlorohydrin = Prefixed_Name(s4watr, "Epichlorohydrin") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:EscherichiaColi</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4watr:BacterialProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Property of the water indicating its concentration of escherichia coli.</para>
    /// labels<para>Escherichia coli</para><para>E. coli</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/EscherichiaColi">https://saref.etsi.org/saref4watr/EscherichiaColi</seealso>
    let EscherichiaColi = Prefixed_Name(s4watr, "EscherichiaColi") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Estuary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An estuary is a partially enclosed coastal body of brackish water with one or more rivers or streams flowing into it, and with a free connection to the open sea.</para>
    /// labels<para>Estuary</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Estuary">https://saref.etsi.org/saref4watr/Estuary</seealso>
    let Estuary = Prefixed_Name(s4watr, "Estuary") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:SinkAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A sink asset is a water asset where water sinks.</para>
    /// labels<para>Sink asset</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/SinkAsset">https://saref.etsi.org/saref4watr/SinkAsset</seealso>
    let SinkAsset = Prefixed_Name(s4watr, "SinkAsset") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:ExternalTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:EnvironmentalProperty</para>
    ///   <para>Property of the environment indicating the temperature.</para>
    /// labels<para>External temperature</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/ExternalTemperature">https://saref.etsi.org/saref4watr/ExternalTemperature</seealso>
    let ExternalTemperature =
        Prefixed_Name(s4watr, "ExternalTemperature") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:WaterDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A water device is a device that is also a water asset.</para>
    /// labels<para>Water device</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/WaterDevice">https://saref.etsi.org/saref4watr/WaterDevice</seealso>
    let WaterDevice = Prefixed_Name(s4watr, "WaterDevice") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:FlowPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:WaterFlowProperty</para>
    ///   <para>Property indicating the pressure of a water flow.</para>
    /// labels<para>Flow pressure</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/FlowPressure">https://saref.etsi.org/saref4watr/FlowPressure</seealso>
    let FlowPressure = Prefixed_Name(s4watr, "FlowPressure") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:WaterFlowProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class to group those properties related to water flow.</para>
    /// labels<para>Water flow property</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/WaterFlowProperty">https://saref.etsi.org/saref4watr/WaterFlowProperty</seealso>
    let WaterFlowProperty = Prefixed_Name(s4watr, "WaterFlowProperty") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:FlowRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:WaterFlowProperty</para>
    ///   <para>Property indicating the rate of a water flow.</para>
    /// labels<para>Flow rate</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/FlowRate">https://saref.etsi.org/saref4watr/FlowRate</seealso>
    let FlowRate = Prefixed_Name(s4watr, "FlowRate") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Fluoride</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:ChemicalProperty</para>
    ///   <para>Property of the water indicating its concentration of fluoride.</para>
    /// labels<para>Fluoride</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Fluoride">https://saref.etsi.org/saref4watr/Fluoride</seealso>
    let Fluoride = Prefixed_Name(s4watr, "Fluoride") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:GaugingStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A gauging station is an infrastructure to monitor and test terrestrial bodies of water.</para>
    /// labels<para>Gauging station</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/GaugingStation">https://saref.etsi.org/saref4watr/GaugingStation</seealso>
    let GaugingStation = Prefixed_Name(s4watr, "GaugingStation") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:MonitoringInfrastructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A monitoring infrastructure is an infrastructure to monitor water.</para>
    /// labels<para>Monitoring infrastructure</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/MonitoringInfrastructure">https://saref.etsi.org/saref4watr/MonitoringInfrastructure</seealso>
    let MonitoringInfrastructure =
        Prefixed_Name(s4watr, "MonitoringInfrastructure") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:SourceAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A source asset is a water asset that is a natural source of water.</para>
    /// labels<para>Source asset</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/SourceAsset">https://saref.etsi.org/saref4watr/SourceAsset</seealso>
    let SourceAsset = Prefixed_Name(s4watr, "SourceAsset") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Hardness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:AcceptabilityProperty</para>
    ///   <para>Property of the water indicating its hardness.</para>
    /// labels<para>Hardness</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Hardness">https://saref.etsi.org/saref4watr/Hardness</seealso>
    let Hardness = Prefixed_Name(s4watr, "Hardness") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Humidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4watr:EnvironmentalProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Property of the environment indicating the humidity.</para>
    /// labels<para>Humidity</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Humidity">https://saref.etsi.org/saref4watr/Humidity</seealso>
    let Humidity = Prefixed_Name(s4watr, "Humidity") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:HydroelectricPowerPlant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A hydroelectric power plant is an infrastructure to generate electricity by conversion of the energy of running water.</para>
    /// labels<para>Hydroelectric power plant</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/HydroelectricPowerPlant">https://saref.etsi.org/saref4watr/HydroelectricPowerPlant</seealso>
    let HydroelectricPowerPlant =
        Prefixed_Name(s4watr, "HydroelectricPowerPlant") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:HydrogenIonConcentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:AcceptabilityProperty</para>
    ///   <para>Property of the water indicating its hydrogen ion concentration.</para>
    /// labels<para>Hydrogen ion concentration</para><para>pH</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/HydrogenIonConcentration">https://saref.etsi.org/saref4watr/HydrogenIonConcentration</seealso>
    let HydrogenIonConcentration =
        Prefixed_Name(s4watr, "HydrogenIonConcentration") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:Industry</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4watr:WaterUse</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Use of water for industrial purposes.</para>
    /// labels<para>Industry</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Industry">https://saref.etsi.org/saref4watr/Industry</seealso>
    let Industry = Prefixed_Name(s4watr, "Industry") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:TransportAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A transport asset is a water asset used to enable and support the transport and distribution of water.</para>
    /// labels<para>Transport asset</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/TransportAsset">https://saref.etsi.org/saref4watr/TransportAsset</seealso>
    let TransportAsset = Prefixed_Name(s4watr, "TransportAsset") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Iron</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:ChemicalProperty</para>
    ///   <para>Property of the water indicating its concentration of iron.</para>
    /// labels<para>Iron</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Iron">https://saref.etsi.org/saref4watr/Iron</seealso>
    let Iron = Prefixed_Name(s4watr, "Iron") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Lagoon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A lagoon is a shallow body of water separated from a larger body of water by barrier islands or reefs.</para>
    /// labels<para>Lagoon</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Lagoon">https://saref.etsi.org/saref4watr/Lagoon</seealso>
    let Lagoon = Prefixed_Name(s4watr, "Lagoon") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Lake</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A lake is an area filled with water, localized in a basin, surrounded by land, apart from any river or other outlet that serves to feed or drain the lake.</para>
    /// labels<para>Lake</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Lake">https://saref.etsi.org/saref4watr/Lake</seealso>
    let Lake = Prefixed_Name(s4watr, "Lake") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Lead</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4watr:ChemicalProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Property of the water indicating its concentration of lead.</para>
    /// labels<para>Lead</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Lead">https://saref.etsi.org/saref4watr/Lead</seealso>
    let Lead = Prefixed_Name(s4watr, "Lead") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Manhole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A maintenance hole is an enclosure that facilitates human access to and working space for equipment.</para>
    /// labels<para>Maintenance hole</para><para>Manhole</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Manhole">https://saref.etsi.org/saref4watr/Manhole</seealso>
    let Manhole = Prefixed_Name(s4watr, "Manhole") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Mercury</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4watr:ChemicalProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Property of the water indicating its concentration of mercury.</para>
    /// labels<para>Mercury</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Mercury">https://saref.etsi.org/saref4watr/Mercury</seealso>
    let Mercury = Prefixed_Name(s4watr, "Mercury") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:MeterOnTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:WaterMeterProperty</para>
    ///   <para>The duration of the meter power up.</para>
    /// labels<para>Meter on time</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/MeterOnTime">https://saref.etsi.org/saref4watr/MeterOnTime</seealso>
    let MeterOnTime = Prefixed_Name(s4watr, "MeterOnTime") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:MeterOperatingTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:WaterMeterProperty</para>
    ///   <para>The time for which the meter has been operating.</para>
    /// labels<para>Meter operating time</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/MeterOperatingTime">https://saref.etsi.org/saref4watr/MeterOperatingTime</seealso>
    let MeterOperatingTime = Prefixed_Name(s4watr, "MeterOperatingTime") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Nitrate</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4watr:ChemicalProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Property of the water indicating its concentration of nitrate.</para>
    /// labels<para>Nitrate</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Nitrate">https://saref.etsi.org/saref4watr/Nitrate</seealso>
    let Nitrate = Prefixed_Name(s4watr, "Nitrate") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Nitrite</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4watr:ChemicalProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Property of the water indicating its concentration of nitrite.</para>
    /// labels<para>Nitrite</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Nitrite">https://saref.etsi.org/saref4watr/Nitrite</seealso>
    let Nitrite = Prefixed_Name(s4watr, "Nitrite") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Ocean</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An ocean is a large body of salt water.</para>
    /// labels<para>Ocean</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Ocean">https://saref.etsi.org/saref4watr/Ocean</seealso>
    let Ocean = Prefixed_Name(s4watr, "Ocean") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Odour</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4watr:AcceptabilityProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Property of the water indicating its odour.</para>
    /// labels<para>Odour</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Odour">https://saref.etsi.org/saref4watr/Odour</seealso>
    let Odour = Prefixed_Name(s4watr, "Odour") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Oxidisability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:AcceptabilityProperty</para>
    ///   <para>Property of the water indicating its oxidisability.</para>
    /// labels<para>Oxidisability</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Oxidisability">https://saref.etsi.org/saref4watr/Oxidisability</seealso>
    let Oxidisability = Prefixed_Name(s4watr, "Oxidisability") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Pipe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A pipe is a passage of water flowing in a closed conduit (i.e., not subject to atmospheric pressure).</para>
    /// labels<para>Pipe</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Pipe">https://saref.etsi.org/saref4watr/Pipe</seealso>
    let Pipe = Prefixed_Name(s4watr, "Pipe") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Pit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A pit is a well or hole sunk in the ground to procure, store or drain water.</para>
    /// labels<para>Pit</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Pit">https://saref.etsi.org/saref4watr/Pit</seealso>
    let Pit = Prefixed_Name(s4watr, "Pit") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:PolycyclicAromaticHydrocarbons</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:ChemicalProperty</para>
    ///   <para>Property of the water indicating its concentration of polycyclic aromatic hydrocarbons.</para>
    /// labels<para>Polycyclic aromatic hydrocarbons</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/PolycyclicAromaticHydrocarbons">https://saref.etsi.org/saref4watr/PolycyclicAromaticHydrocarbons</seealso>
    let PolycyclicAromaticHydrocarbons =
        Prefixed_Name(s4watr, "PolycyclicAromaticHydrocarbons") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:Precipitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:EnvironmentalProperty</para>
    ///   <para>Property of the environment indicating the precipitation.</para>
    /// labels<para>Precipitation</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Precipitation">https://saref.etsi.org/saref4watr/Precipitation</seealso>
    let Precipitation = Prefixed_Name(s4watr, "Precipitation") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Pump</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A pump is a device for moving water by mechanical action.</para>
    /// labels<para>Pump</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Pump">https://saref.etsi.org/saref4watr/Pump</seealso>
    let Pump = Prefixed_Name(s4watr, "Pump") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:RawWater</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4watr:Water</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Raw water is water found in the environment that has not been treated and does not have any of its minerals, ions, particles, bacteria, or parasites removed.</para>
    /// labels<para>Raw water</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/RawWater">https://saref.etsi.org/saref4watr/RawWater</seealso>
    let RawWater = Prefixed_Name(s4watr, "RawWater") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Recreation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:WaterUse</para>
    ///   <para>Use of water for recreational purposes.</para>
    /// labels<para>Recreation</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Recreation">https://saref.etsi.org/saref4watr/Recreation</seealso>
    let Recreation = Prefixed_Name(s4watr, "Recreation") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Reservoir</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A reservoir is an enlarged natural or artificial lake, pond or impoundment created using a dam or lock to store water.</para>
    /// labels<para>Reservoir</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Reservoir">https://saref.etsi.org/saref4watr/Reservoir</seealso>
    let Reservoir = Prefixed_Name(s4watr, "Reservoir") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:River</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A river is a natural flowing watercourse, usually freshwater, flowing towards an ocean, sea, lake or another river.</para>
    /// labels<para>River</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/River">https://saref.etsi.org/saref4watr/River</seealso>
    let River = Prefixed_Name(s4watr, "River") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Selenium</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4watr:ChemicalProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Property of the water indicating its concentration of selenium.</para>
    /// labels<para>Selenium</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Selenium">https://saref.etsi.org/saref4watr/Selenium</seealso>
    let Selenium = Prefixed_Name(s4watr, "Selenium") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:WaterAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A water asset is a physical entity used in the process of transporting, treating, storing and distributing water.</para>
    /// labels<para>Water asset</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/WaterAsset">https://saref.etsi.org/saref4watr/WaterAsset</seealso>
    let WaterAsset = Prefixed_Name(s4watr, "WaterAsset") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Sodium</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4watr:ChemicalProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Property of the water indicating its concentration of sodium.</para>
    /// labels<para>Sodium</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Sodium">https://saref.etsi.org/saref4watr/Sodium</seealso>
    let Sodium = Prefixed_Name(s4watr, "Sodium") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:StorageInfrastructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An storage infrastructure is an infrastructure to storage both potable water for consumption, and non potable water for use in agriculture.</para>
    /// labels<para>Storage infrastructure</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/StorageInfrastructure">https://saref.etsi.org/saref4watr/StorageInfrastructure</seealso>
    let StorageInfrastructure =
        Prefixed_Name(s4watr, "StorageInfrastructure") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:Sulphate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:ChemicalProperty</para>
    ///   <para>Property of the water indicating its concentration of sulphate.</para>
    /// labels<para>Sulphate</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Sulphate">https://saref.etsi.org/saref4watr/Sulphate</seealso>
    let Sulphate = Prefixed_Name(s4watr, "Sulphate") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Tank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A tank is a container for storing water.</para>
    /// labels<para>Tank</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Tank">https://saref.etsi.org/saref4watr/Tank</seealso>
    let Tank = Prefixed_Name(s4watr, "Tank") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Taste</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4watr:AcceptabilityProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Property of the water indicating its taste.</para>
    /// labels<para>Taste</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Taste">https://saref.etsi.org/saref4watr/Taste</seealso>
    let Taste = Prefixed_Name(s4watr, "Taste") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Temperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4watr:AcceptabilityProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Property of the water indicating its temperature.</para>
    /// labels<para>Temperature</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Temperature">https://saref.etsi.org/saref4watr/Temperature</seealso>
    let Temperature = Prefixed_Name(s4watr, "Temperature") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:ThresholdBasedTariff</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A threshold-based tariff is a tariff that is based on a threshold.</para>
    /// labels<para>Threshold-based tariff</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/ThresholdBasedTariff">https://saref.etsi.org/saref4watr/ThresholdBasedTariff</seealso>
    let ThresholdBasedTariff =
        Prefixed_Name(s4watr, "ThresholdBasedTariff") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:TimeBasedTariff</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A time-based tariff is a tariff that is based on time.</para>
    /// labels<para>Time-based tariff</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/TimeBasedTariff">https://saref.etsi.org/saref4watr/TimeBasedTariff</seealso>
    let TimeBasedTariff = Prefixed_Name(s4watr, "TimeBasedTariff") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:TotalDissolvedSolids</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:AcceptabilityProperty</para>
    ///   <para>Property of the water indicating the dissolved combined content of all inorganic and organic substances present in a sample of water.</para>
    /// labels<para>Total dissolved solids</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/TotalDissolvedSolids">https://saref.etsi.org/saref4watr/TotalDissolvedSolids</seealso>
    let TotalDissolvedSolids =
        Prefixed_Name(s4watr, "TotalDissolvedSolids") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:TotalIndicativeDose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:AcceptabilityProperty</para>
    ///   <para>Property of the water indicating its total indicative dose.</para>
    /// labels<para>Total indicative dose</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/TotalIndicativeDose">https://saref.etsi.org/saref4watr/TotalIndicativeDose</seealso>
    let TotalIndicativeDose =
        Prefixed_Name(s4watr, "TotalIndicativeDose") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:TotalOrganicCarbon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:ChemicalProperty</para>
    ///   <para>Property of the water indicating its concentration of total organic carbon.</para>
    /// labels<para>Total organic carbon</para><para>TOC</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/TotalOrganicCarbon">https://saref.etsi.org/saref4watr/TotalOrganicCarbon</seealso>
    let TotalOrganicCarbon = Prefixed_Name(s4watr, "TotalOrganicCarbon") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:ChemicalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A chemical property is a property of water that is related to chemical components.</para>
    /// labels<para>ChemicalProperty</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/ChemicalProperty">https://saref.etsi.org/saref4watr/ChemicalProperty</seealso>
    let ChemicalProperty = Prefixed_Name(s4watr, "ChemicalProperty") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:WaterUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class is used to define the different uses of water.</para>
    /// labels<para>Water use</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/WaterUse">https://saref.etsi.org/saref4watr/WaterUse</seealso>
    let WaterUse = Prefixed_Name(s4watr, "WaterUse") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Ammonium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:ChemicalProperty</para>
    ///   <para>Property of the water indicating its concentration of ammonium.</para>
    /// labels<para>Ammonium</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Ammonium">https://saref.etsi.org/saref4watr/Ammonium</seealso>
    let Ammonium = Prefixed_Name(s4watr, "Ammonium") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Aquifer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An aquifer is an underground layer of water-bearing permeable rock, rock fractures or unconsolidated materials.</para>
    /// labels<para>Aquifer</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Aquifer">https://saref.etsi.org/saref4watr/Aquifer</seealso>
    let Aquifer = Prefixed_Name(s4watr, "Aquifer") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:StorageAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A storage asset is a water asset used to store water.</para>
    /// labels<para>Storage asset</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/StorageAsset">https://saref.etsi.org/saref4watr/StorageAsset</seealso>
    let StorageAsset = Prefixed_Name(s4watr, "StorageAsset") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:AtmosphericPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4watr:EnvironmentalProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Property of the environment indicating the atmospheric pressure.</para>
    /// labels<para>Atmospheric pressure</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/AtmosphericPressure">https://saref.etsi.org/saref4watr/AtmosphericPressure</seealso>
    let AtmosphericPressure =
        Prefixed_Name(s4watr, "AtmosphericPressure") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:EnvironmentalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class to group those properties related to the environment.</para>
    /// labels<para>Environmental property</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/EnvironmentalProperty">https://saref.etsi.org/saref4watr/EnvironmentalProperty</seealso>
    let EnvironmentalProperty =
        Prefixed_Name(s4watr, "EnvironmentalProperty") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:WaterMeterProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class to group those properties related to water meters.</para>
    /// labels<para>Water meter property</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/WaterMeterProperty">https://saref.etsi.org/saref4watr/WaterMeterProperty</seealso>
    let WaterMeterProperty = Prefixed_Name(s4watr, "WaterMeterProperty") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:BatteryOperatingTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4watr:WaterMeterProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The time for which the battery has been operating since the last charge.</para>
    /// labels<para>Battery operating time</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/BatteryOperatingTime">https://saref.etsi.org/saref4watr/BatteryOperatingTime</seealso>
    let BatteryOperatingTime =
        Prefixed_Name(s4watr, "BatteryOperatingTime") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:Benzene</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:ChemicalProperty</para>
    ///   <para>Property of the water indicating its concentration of benzene.</para>
    /// labels<para>Benzene</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Benzene">https://saref.etsi.org/saref4watr/Benzene</seealso>
    let Benzene = Prefixed_Name(s4watr, "Benzene") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Channel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A channel is a passage of water flowing in an open conduit (i.e., subject to atmospheric pressure).</para>
    /// labels<para>Channel</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Channel">https://saref.etsi.org/saref4watr/Channel</seealso>
    let Channel = Prefixed_Name(s4watr, "Channel") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Chloride</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4watr:ChemicalProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Property of the water indicating its concentration of chloride.</para>
    /// labels<para>Chloride</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Chloride">https://saref.etsi.org/saref4watr/Chloride</seealso>
    let Chloride = Prefixed_Name(s4watr, "Chloride") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:ColiformBacteria</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:BacterialProperty</para>
    ///   <para>Property of the water indicating its concentration of coliform bacteria.</para>
    /// labels<para>Coliform bacteria</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/ColiformBacteria">https://saref.etsi.org/saref4watr/ColiformBacteria</seealso>
    let ColiformBacteria = Prefixed_Name(s4watr, "ColiformBacteria") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:ColonyCount37C</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:BacterialProperty</para>
    ///   <para>Property of the water indicating its colony count at 37 ºC.</para>
    /// labels<para>Colony count at 37 °C</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/ColonyCount37C">https://saref.etsi.org/saref4watr/ColonyCount37C</seealso>
    let ColonyCount37C = Prefixed_Name(s4watr, "ColonyCount37C") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Colour</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4watr:AcceptabilityProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Property of the water indicating its colour.</para>
    /// labels<para>Colour</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Colour">https://saref.etsi.org/saref4watr/Colour</seealso>
    let Colour = Prefixed_Name(s4watr, "Colour") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:ConsumptionBasedTariff</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A consumption-based tariff is a tariff that is based on consumption.</para>
    /// labels<para>Consumption-based tariff</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/ConsumptionBasedTariff">https://saref.etsi.org/saref4watr/ConsumptionBasedTariff</seealso>
    let ConsumptionBasedTariff =
        Prefixed_Name(s4watr, "ConsumptionBasedTariff") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:BacterialProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A bacterial property is a property of water that is related to bacteria.</para>
    /// labels<para>Bacterial property</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/BacterialProperty">https://saref.etsi.org/saref4watr/BacterialProperty</seealso>
    let BacterialProperty = Prefixed_Name(s4watr, "BacterialProperty") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:WaterInfrastructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A water infrastructure is the set of facilities, services, and installations needed for water management.</para>
    /// labels<para>Water infrastructure</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/WaterInfrastructure">https://saref.etsi.org/saref4watr/WaterInfrastructure</seealso>
    let WaterInfrastructure =
        Prefixed_Name(s4watr, "WaterInfrastructure") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:Enterococci</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:BacterialProperty</para>
    ///   <para>Property of the water indicating its concentration of enterococci.</para>
    /// labels<para>Enterococci</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Enterococci">https://saref.etsi.org/saref4watr/Enterococci</seealso>
    let Enterococci = Prefixed_Name(s4watr, "Enterococci") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Intake</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An intake is an installation for obtaining water from a source of supply (river, lake, reservoir, and so on).</para>
    /// labels<para>Intake</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Intake">https://saref.etsi.org/saref4watr/Intake</seealso>
    let Intake = Prefixed_Name(s4watr, "Intake") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:FireHydrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A fire hydrant is a fitting in a street or other public place with a nozzle by which a fire hose may be attached to a water main.</para>
    /// labels<para>Fire hydrant</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/FireHydrant">https://saref.etsi.org/saref4watr/FireHydrant</seealso>
    let FireHydrant = Prefixed_Name(s4watr, "FireHydrant") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:FlowTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:WaterFlowProperty</para>
    ///   <para>Property indicating the temperature of a water flow.</para>
    /// labels<para>Flow temperature</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/FlowTemperature">https://saref.etsi.org/saref4watr/FlowTemperature</seealso>
    let FlowTemperature = Prefixed_Name(s4watr, "FlowTemperature") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:FlowVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:WaterFlowProperty</para>
    ///   <para>Property indicating the volume of a water flow.</para>
    /// labels<para>Flow volume</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/FlowVolume">https://saref.etsi.org/saref4watr/FlowVolume</seealso>
    let FlowVolume = Prefixed_Name(s4watr, "FlowVolume") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Glacier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A glacier is a persistent body of dense ice that is constantly moving under its own weight.</para>
    /// labels<para>Glacier</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Glacier">https://saref.etsi.org/saref4watr/Glacier</seealso>
    let Glacier = Prefixed_Name(s4watr, "Glacier") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Manganese</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4watr:ChemicalProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Property of the water indicating its concentration of manganese.</para>
    /// labels<para>Manganese</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Manganese">https://saref.etsi.org/saref4watr/Manganese</seealso>
    let Manganese = Prefixed_Name(s4watr, "Manganese") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:hasVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The version of a device.</para>
    /// labels<para>has version</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/hasVersion">https://saref.etsi.org/saref4watr/hasVersion</seealso>
    let hasVersion = Prefixed_Name(s4watr, "hasVersion") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:hasFirmwareVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The firmware version of a device.</para>
    /// labels<para>has firmware version</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/hasFirmwareVersion">https://saref.etsi.org/saref4watr/hasFirmwareVersion</seealso>
    let hasFirmwareVersion = Prefixed_Name(s4watr, "hasFirmwareVersion") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Nickel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:ChemicalProperty</para>
    ///   <para>Property of the water indicating its concentration of nickel.</para>
    /// labels<para>Nickel</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Nickel">https://saref.etsi.org/saref4watr/Nickel</seealso>
    let Nickel = Prefixed_Name(s4watr, "Nickel") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Oxygen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:ChemicalProperty</para>
    ///   <para>Property of the water indicating its oxygen saturation.</para>
    /// labels<para>Oxygen saturation</para><para>Dissolved oxygen</para><para>Oxygen</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Oxygen">https://saref.etsi.org/saref4watr/Oxygen</seealso>
    let Oxygen = Prefixed_Name(s4watr, "Oxygen") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Valve</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A valve is a device designed to control water flow, pressure or volume.</para>
    /// labels<para>Valve</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Valve">https://saref.etsi.org/saref4watr/Valve</seealso>
    let Valve = Prefixed_Name(s4watr, "Valve") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:VinylChloride</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:ChemicalProperty</para>
    ///   <para>Property of the water indicating its concentration of vinyl chloride.</para>
    /// labels<para>Vinyl chloride</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/VinylChloride">https://saref.etsi.org/saref4watr/VinylChloride</seealso>
    let VinylChloride = Prefixed_Name(s4watr, "VinylChloride") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:PseudomonasAeruginosa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:BacterialProperty</para>
    ///   <para>Property of the water indicating its concentration of pseudomonas aeruginosa.</para>
    /// labels<para>Pseudomonas aeruginosa</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/PseudomonasAeruginosa">https://saref.etsi.org/saref4watr/PseudomonasAeruginosa</seealso>
    let PseudomonasAeruginosa =
        Prefixed_Name(s4watr, "PseudomonasAeruginosa") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:Sea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A sea is a body of salt water partly or fully enclosed by land.</para>
    /// labels<para>Sea</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Sea">https://saref.etsi.org/saref4watr/Sea</seealso>
    let Sea = Prefixed_Name(s4watr, "Sea") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Stormwater</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:Water</para>
    ///   <para>Stormwater is water that originates during precipitation events and snow/ice melt.</para>
    /// labels<para>Storm water</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Stormwater">https://saref.etsi.org/saref4watr/Stormwater</seealso>
    let Stormwater = Prefixed_Name(s4watr, "Stormwater") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Tetrachloroethene</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4watr:ChemicalProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Property of the water indicating its concentration of tetrachloroethene.</para>
    /// labels<para>Tetrachloroethene</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Tetrachloroethene">https://saref.etsi.org/saref4watr/Tetrachloroethene</seealso>
    let Tetrachloroethene = Prefixed_Name(s4watr, "Tetrachloroethene") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:TotalSuspendedSolids</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:AcceptabilityProperty</para>
    ///   <para>Property of the water indicating the dry-weight of suspended particles, that are not dissolved, in a sample of water.</para>
    /// labels<para>Total suspended solids</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/TotalSuspendedSolids">https://saref.etsi.org/saref4watr/TotalSuspendedSolids</seealso>
    let TotalSuspendedSolids =
        Prefixed_Name(s4watr, "TotalSuspendedSolids") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:TreatmentPlant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A treatment plant is an infrastructure to improve the quality of water to make it more acceptable for a specific end-use.</para>
    /// labels<para>Treatment plant</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/TreatmentPlant">https://saref.etsi.org/saref4watr/TreatmentPlant</seealso>
    let TreatmentPlant = Prefixed_Name(s4watr, "TreatmentPlant") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Trichloroethene</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4watr:ChemicalProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Property of the water indicating its concentration of trichloroethene.</para>
    /// labels<para>Trichloroethene</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Trichloroethene">https://saref.etsi.org/saref4watr/Trichloroethene</seealso>
    let Trichloroethene = Prefixed_Name(s4watr, "Trichloroethene") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Trihalomethanes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:ChemicalProperty</para>
    ///   <para>Property of the water indicating its concentration of trihalomethanes.</para>
    /// labels<para>Trihalomethanes</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Trihalomethanes">https://saref.etsi.org/saref4watr/Trihalomethanes</seealso>
    let Trihalomethanes = Prefixed_Name(s4watr, "Trihalomethanes") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Turbidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4watr:AcceptabilityProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Property of the water indicating its turbidity.</para>
    /// labels<para>Turbidity</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Turbidity">https://saref.etsi.org/saref4watr/Turbidity</seealso>
    let Turbidity = Prefixed_Name(s4watr, "Turbidity") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Vent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A vent is the part of a system that allows air to enter a plumbing system to maintain proper air pressure and sewer gases to escape to the outside.</para>
    /// labels<para>Vent</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Vent">https://saref.etsi.org/saref4watr/Vent</seealso>
    let Vent = Prefixed_Name(s4watr, "Vent") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Wastewater</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4watr:Water</para>
    ///   <para>Wastewater is water that has been used in the home, in a business, or as part of an industrial process.</para>
    /// labels<para>Waste water</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Wastewater">https://saref.etsi.org/saref4watr/Wastewater</seealso>
    let Wastewater = Prefixed_Name(s4watr, "Wastewater") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:isDesignedFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The type of water for which an infrastructure is designed for.</para>
    /// labels<para>is designed for</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/isDesignedFor">https://saref.etsi.org/saref4watr/isDesignedFor</seealso>
    let isDesignedFor = Prefixed_Name(s4watr, "isDesignedFor") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:isIntendedFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The intended use of the infrastructure.</para>
    /// labels<para>is intended for</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/isIntendedFor">https://saref.etsi.org/saref4watr/isIntendedFor</seealso>
    let isIntendedFor = Prefixed_Name(s4watr, "isIntendedFor") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:WaterMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A water meter is an instrument intended to measure continuously, memorize, and display the volume of water passing through the meter.</para>
    /// labels<para>Water meter</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/WaterMeter">https://saref.etsi.org/saref4watr/WaterMeter</seealso>
    let WaterMeter = Prefixed_Name(s4watr, "WaterMeter") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:hasFabricationNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The fabrication number of a device.</para>
    /// labels<para>has fabrication number</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/hasFabricationNumber">https://saref.etsi.org/saref4watr/hasFabricationNumber</seealso>
    let hasFabricationNumber =
        Prefixed_Name(s4watr, "hasFabricationNumber") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:hasHardwareVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The hardware version of a device.</para>
    /// labels<para>has hardware version</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/hasHardwareVersion">https://saref.etsi.org/saref4watr/hasHardwareVersion</seealso>
    let hasHardwareVersion = Prefixed_Name(s4watr, "hasHardwareVersion") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:Tritium</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4watr:ChemicalProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Property of the water indicating its concentration of tritium.</para>
    /// labels<para>Tritium</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/Tritium">https://saref.etsi.org/saref4watr/Tritium</seealso>
    let Tritium = Prefixed_Name(s4watr, "Tritium") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:featureIsControlledByDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship specifying the devices that control a feature of interest.</para>
    /// labels<para>feature is controlled by device</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/featureIsControlledByDevice">https://saref.etsi.org/saref4watr/featureIsControlledByDevice</seealso>
    let featureIsControlledByDevice =
        Prefixed_Name(s4watr, "featureIsControlledByDevice") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:featureIsMeasuredByDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship specifying the devices that measure a feature of interest.</para>
    /// labels<para>feature is measured by device</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/featureIsMeasuredByDevice">https://saref.etsi.org/saref4watr/featureIsMeasuredByDevice</seealso>
    let featureIsMeasuredByDevice =
        Prefixed_Name(s4watr, "featureIsMeasuredByDevice") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:forDayInMonth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The day of the month for which a tariff is applied (e.g., each 15).</para>
    /// labels<para>for day in month</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/forDayInMonth">https://saref.etsi.org/saref4watr/forDayInMonth</seealso>
    let forDayInMonth = Prefixed_Name(s4watr, "forDayInMonth") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:forVolumeFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The volume flow related to a tariff.</para>
    /// labels<para>for volume flow</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/forVolumeFlow">https://saref.etsi.org/saref4watr/forVolumeFlow</seealso>
    let forVolumeFlow = Prefixed_Name(s4watr, "forVolumeFlow") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:hasBillingDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The billing date of a tariff.</para>
    /// labels<para>has billing date</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/hasBillingDate">https://saref.etsi.org/saref4watr/hasBillingDate</seealso>
    let hasBillingDate = Prefixed_Name(s4watr, "hasBillingDate") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:hasBillingPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The billing period of a tariff.</para>
    /// labels<para>has billing period</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/hasBillingPeriod">https://saref.etsi.org/saref4watr/hasBillingPeriod</seealso>
    let hasBillingPeriod = Prefixed_Name(s4watr, "hasBillingPeriod") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:v1.1.1/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/v1.1.1/">https://saref.etsi.org/saref4watr/v1.1.1/</seealso>
    let ``v1.1.1/`` = Prefixed_Name(s4watr, "v1.1.1/") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:hasPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The period of a tariff.</para>
    /// labels<para>has period</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/hasPeriod">https://saref.etsi.org/saref4watr/hasPeriod</seealso>
    let hasPeriod = Prefixed_Name(s4watr, "hasPeriod") |> PrefixedName
    /// <summary>
    ///   <para>s4watr:hasStartTimestamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The start date and time of a tariff.</para>
    /// labels<para>has start timestamp</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/hasStartTimestamp">https://saref.etsi.org/saref4watr/hasStartTimestamp</seealso>
    let hasStartTimestamp = Prefixed_Name(s4watr, "hasStartTimestamp") |> PrefixedName

    /// <summary>
    ///   <para>s4watr:operatesAtRadioFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The radio frequency at which a device operates.</para>
    /// labels<para>operates at radio frequency</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4watr/operatesAtRadioFrequency">https://saref.etsi.org/saref4watr/operatesAtRadioFrequency</seealso>
    let operatesAtRadioFrequency =
        Prefixed_Name(s4watr, "operatesAtRadioFrequency") |> PrefixedName
